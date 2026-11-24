#!/usr/bin/env python3
"""Serve a Unity WebGL build folder with the required Brotli response headers.

Usage:
  python3 Tools/serve_webgl.py /path/to/unzipped/beijing
  python3 Tools/serve_webgl.py /path/to/unzipped/beijing --host 0.0.0.0 --port 8000
  cd /path/to/unzipped/beijing && python3 /path/to/serve_webgl.py --port 1873
"""
from __future__ import annotations

import argparse
import functools
import http.server
import mimetypes
from pathlib import Path


class UnityWebGLHandler(http.server.SimpleHTTPRequestHandler):
    def guess_type(self, path: str) -> str:
        lower = path.lower()
        if lower.endswith(".wasm.br"):
            return "application/wasm"
        if lower.endswith(".js.br"):
            return "application/javascript"
        if lower.endswith(".data.br"):
            return "application/octet-stream"
        return mimetypes.guess_type(path, strict=False)[0] or "application/octet-stream"

    def end_headers(self) -> None:
        if self.path.lower().split("?", 1)[0].endswith(".br"):
            self.send_header("Content-Encoding", "br")
        super().end_headers()


def main() -> None:
    parser = argparse.ArgumentParser(description="Serve a Unity WebGL build, including Brotli headers.")
    parser.add_argument("directory", type=Path, nargs="?", default=Path("."), help="Folder containing index.html and Build/ (default: current folder)")
    parser.add_argument("--host", default="127.0.0.1", help="Bind address (default: 127.0.0.1)")
    parser.add_argument("--port", type=int, default=8000, help="HTTP port (default: 8000)")
    args = parser.parse_args()

    root = args.directory.expanduser().resolve()
    if not (root / "index.html").is_file() or not (root / "Build").is_dir():
        parser.error(f"{root} must contain index.html and a Build/ directory")

    handler = functools.partial(UnityWebGLHandler, directory=str(root))
    server = http.server.ThreadingHTTPServer((args.host, args.port), handler)
    print(f"Serving {root} at http://{args.host}:{args.port}/ (Ctrl+C to stop)", flush=True)
    try:
        server.serve_forever()
    except KeyboardInterrupt:
        print("\nStopping server.")
    finally:
        server.server_close()


if __name__ == "__main__":
    main()
