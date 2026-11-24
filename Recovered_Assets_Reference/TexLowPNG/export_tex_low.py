#!/usr/bin/env python3
"""Extract embedded tex_low AssetBundles from the compiled Beijing WebGL data.

Reads the extracted data.unity3d created from the preserved compiled build.
Does not modify any input build files.
"""
from __future__ import annotations

import csv
import re
import zlib
from pathlib import Path

import UnityPy

BASE = Path("/home/ubuntu/starlane/deliverables/Beijing_UnityWeb_Analysis")
SOURCE = BASE / "data-extracted" / "data.unity3d"
OUT = Path("/home/ubuntu/starlane/deliverables/Beijing_Compiled_TexLow_Export")
BUNDLE_DIR = OUT / "AssetBundles"
TEXTURE_DIR = OUT / "Textures_PNG"


def safe_name(value: str) -> str:
    return re.sub(r"[^A-Za-z0-9_.-]+", "_", value)


def unpack_subway_bundle(payload: bytes) -> bytes:
    # The compiled TextAsset layout is: one-byte string length, UTF-8 label,
    # little-endian uncompressed length, then a raw-DEFLATE UnityFS stream.
    if not payload:
        raise ValueError("empty TextAsset payload")
    label_len = payload[0]
    label_end = 1 + label_len
    label = payload[1:label_end].decode("utf-8")
    if label != "subway_bundles":
        raise ValueError(f"unexpected header label {label!r}")
    if len(payload) < label_end + 4:
        raise ValueError("truncated subway_bundles header")
    expected_size = int.from_bytes(payload[label_end:label_end + 4], "little")
    decoded = zlib.decompress(payload[label_end + 4:], -zlib.MAX_WBITS)
    if len(decoded) != expected_size:
        raise ValueError(f"decoded size mismatch: expected {expected_size}, got {len(decoded)}")
    if not decoded.startswith(b"UnityFS\0"):
        raise ValueError(f"payload did not decode to UnityFS: {decoded[:16]!r}")
    return decoded


def main() -> None:
    BUNDLE_DIR.mkdir(parents=True, exist_ok=True)
    TEXTURE_DIR.mkdir(parents=True, exist_ok=True)
    env = UnityPy.load(str(SOURCE))
    rows: list[dict[str, object]] = []
    errors: list[str] = []

    for obj in env.objects:
        if obj.type.name != "TextAsset":
            continue
        text_asset = obj.read()
        name = getattr(text_asset, "m_Name", "") or ""
        if not name.endswith("_tex_low"):
            continue
        try:
            # UnityPy decodes TextAsset binary bytes to a Python string using
            # surrogateescape; encoding with the same handler recovers bytes.
            wrapped = text_asset.m_Script.encode("utf-8", "surrogateescape")
            bundle = unpack_subway_bundle(wrapped)
            bundle_env = UnityPy.load(bundle)
            texture_objects = [x for x in bundle_env.objects if x.type.name == "Texture2D"]
            if len(texture_objects) != 1:
                raise ValueError(f"expected one Texture2D, found {len(texture_objects)}")
            texture = texture_objects[0].read()
            width, height = texture.m_Width, texture.m_Height

            bundle_path = BUNDLE_DIR / f"{safe_name(name)}.bundle"
            bundle_path.write_bytes(bundle)
            png_path = TEXTURE_DIR / f"{safe_name(name)}.png"
            texture.image.save(png_path, format="PNG")

            internal_paths = []
            for item in bundle_env.objects:
                if item.type.name == "AssetBundle":
                    ab = item.read()
                    internal_paths = [str(entry[0]) for entry in (getattr(ab, "m_Container", []) or [])]
                    break
            rows.append({
                "asset_name": name,
                "internal_path": ";".join(internal_paths),
                "width": width,
                "height": height,
                "source_payload_bytes": len(wrapped),
                "plain_bundle_bytes": len(bundle),
                "texture_png": str(png_path.relative_to(OUT)),
                "assetbundle": str(bundle_path.relative_to(OUT)),
                "status": "OK",
            })
        except Exception as exc:
            errors.append(f"{name}: {type(exc).__name__}: {exc}")
            rows.append({"asset_name": name, "status": "ERROR", "error": str(exc)})

    fields = ["asset_name", "internal_path", "width", "height", "source_payload_bytes", "plain_bundle_bytes", "texture_png", "assetbundle", "status", "error"]
    with (OUT / "tex_low_export_manifest.csv").open("w", newline="", encoding="utf-8") as f:
        writer = csv.DictWriter(f, fieldnames=fields, extrasaction="ignore")
        writer.writeheader()
        writer.writerows(rows)

    ok = sum(row.get("status") == "OK" for row in rows)
    print(f"Exported {ok}/{len(rows)} tex_low TextAssets")
    print(f"AssetBundles: {BUNDLE_DIR}")
    print(f"PNG textures: {TEXTURE_DIR}")
    if errors:
        for error in errors:
            print("ERROR", error)
        raise SystemExit(1)


if __name__ == "__main__":
    main()
