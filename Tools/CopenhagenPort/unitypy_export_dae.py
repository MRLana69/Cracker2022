#!/usr/bin/env python3
"""Export a skinned Unity Mesh and its renderer bones to Collada using UnityPy.

This reads Unity serialized objects only; it never loads or executes game code.
"""
from __future__ import annotations
import argparse
import math
import os
import re
import zipfile
import xml.etree.ElementTree as ET
from pathlib import Path

import numpy as np
import UnityPy
from UnityPy.helpers.MeshHelper import MeshHandler

# Map the common Copenhagen skeleton to the source project's legacy Animation names.
# Shoulder tracks map to the actual shoulder joints. The exporter flattens the extra
# root and clavicle parents while preserving world bind transforms and joint weights.
BONE_RENAMES = {
    "Root_jnt": "jRoot",
    "L_Leg_jnt": "jLeg_L", "L_Knee_jnt": "jKnee_L",
    "L_Foot_jnt": "jFoot_L", "L_Toes_jnt": "jToes_L",
    "R_Leg_jnt": "jLeg_R", "R_Knee_jnt": "jKnee_R",
    "R_Foot_jnt": "jFoot_R", "R_Toes_jnt": "jToes_R",
    "LowerSpine_jnt": "jLowerSpine",
    "R_Shoulder_jnt": "jShoulder_R", "L_Shoulder_jnt": "jShoulder_L",
    "R_Elbow_jnt": "jElbow_R", "R_Hand_jnt": "jHand_R",
    "L_Elbow_jnt": "jElbow_L", "L_Hand_jnt": "jHand_L",
    "Head_jnt": "jHead", "head_misc_jnt": "jAfro_3",
}
NS = "http://www.collada.org/2005/11/COLLADASchema"
ET.register_namespace("", NS)

def tag(name):
    return f"{{{NS}}}{name}"

def safe_id(s):
    s = re.sub(r"[^A-Za-z0-9_.-]", "_", str(s))
    return s if s and not s[0].isdigit() else "n_" + s

def fmt(values):
    return " ".join(f"{float(v):.9g}" for v in values)

def xyz(obj):
    return (float(obj.x), float(obj.y), float(obj.z))

def quat(obj):
    return (float(obj.x), float(obj.y), float(obj.z), float(obj.w))

def add_source(parent, sid, array_tag, values, count, stride, params):
    src = ET.SubElement(parent, tag("source"), {"id": sid})
    arr_id = sid + "-array"
    flat = [x for row in values for x in row] if values and isinstance(values[0], (tuple, list)) else values
    ET.SubElement(src, tag(array_tag), {"id": arr_id, "count": str(len(flat))}).text = fmt(flat)
    tc = ET.SubElement(src, tag("technique_common"))
    acc = ET.SubElement(tc, tag("accessor"), {"source": "#" + arr_id, "count": str(count), "stride": str(stride)})
    for name, typ in params:
        ET.SubElement(acc, tag("param"), {"name": name, "type": typ})
    return src

def quat_axis_angle(q):
    x, y, z, w = q
    length = math.sqrt(x*x + y*y + z*z + w*w) or 1.0
    x, y, z, w = x/length, y/length, z/length, w/length
    if w < 0:
        x, y, z, w = -x, -y, -z, -w
    angle = 2.0 * math.acos(max(-1.0, min(1.0, w)))
    s = math.sqrt(max(0.0, 1.0 - w*w))
    axis = (x/s, y/s, z/s) if s > 1e-7 else (0.0, 1.0, 0.0)
    return (*axis, math.degrees(angle))

def trs_matrix(tr):
    x, y, z, w = quat(tr.m_LocalRotation)
    length = math.sqrt(x*x + y*y + z*z + w*w) or 1.0
    x, y, z, w = x/length, y/length, z/length, w/length
    rotation = np.array([
        [1-2*(y*y+z*z), 2*(x*y-z*w), 2*(x*z+y*w)],
        [2*(x*y+z*w), 1-2*(x*x+z*z), 2*(y*z-x*w)],
        [2*(x*z-y*w), 2*(y*z+x*w), 1-2*(x*x+y*y)],
    ], dtype=float)
    matrix = np.eye(4)
    matrix[:3, :3] = rotation @ np.diag(xyz(tr.m_LocalScale))
    matrix[:3, 3] = xyz(tr.m_LocalPosition)
    return matrix

def matrix_to_trs(matrix):
    matrix = np.asarray(matrix, dtype=float)
    basis = matrix[:3, :3]
    scale = np.linalg.norm(basis, axis=0)
    if np.any(scale < 1e-8):
        raise RuntimeError("Cannot decompose a zero-scale bone transform")
    rotation = basis / scale
    if np.linalg.det(rotation) < 0:
        scale[0] *= -1
        rotation[:, 0] *= -1
    if not np.allclose(rotation.T @ rotation, np.eye(3), atol=1e-4):
        raise RuntimeError("Reparenting would introduce shear into a bone transform")
    trace = float(np.trace(rotation))
    if trace > 0:
        s = math.sqrt(trace + 1.0) * 2
        q = ((rotation[2,1]-rotation[1,2])/s, (rotation[0,2]-rotation[2,0])/s,
             (rotation[1,0]-rotation[0,1])/s, 0.25*s)
    elif rotation[0,0] > rotation[1,1] and rotation[0,0] > rotation[2,2]:
        s = math.sqrt(1.0 + rotation[0,0] - rotation[1,1] - rotation[2,2]) * 2
        q = (0.25*s, (rotation[0,1]+rotation[1,0])/s, (rotation[0,2]+rotation[2,0])/s, (rotation[2,1]-rotation[1,2])/s)
    elif rotation[1,1] > rotation[2,2]:
        s = math.sqrt(1.0 + rotation[1,1] - rotation[0,0] - rotation[2,2]) * 2
        q = ((rotation[0,1]+rotation[1,0])/s, 0.25*s, (rotation[1,2]+rotation[2,1])/s, (rotation[0,2]-rotation[2,0])/s)
    else:
        s = math.sqrt(1.0 + rotation[2,2] - rotation[0,0] - rotation[1,1]) * 2
        q = ((rotation[0,2]+rotation[2,0])/s, (rotation[1,2]+rotation[2,1])/s, 0.25*s, (rotation[1,0]-rotation[0,1])/s)
    qlen = math.sqrt(sum(v*v for v in q)) or 1.0
    return tuple(matrix[:3, 3]), tuple(v/qlen for v in q), tuple(scale)

def find_texture(env, render_data):
    for material_ptr in render_data.m_Materials:
        try:
            mat = material_ptr.read()
            for key, texenv in mat.m_SavedProperties.m_TexEnvs:
                if key not in ("_MainTex", "_BaseMap"):
                    continue
                tex = texenv.m_Texture.read()
                return mat.m_Name, tex
        except Exception:
            continue
    return "CopenhagenMaterial", None

def export(zip_path: str, bundle_suffix: str, mesh_name: str, outdir: str):
    zip_path = Path(zip_path)
    outdir = Path(outdir)
    outdir.mkdir(parents=True, exist_ok=True)
    with zipfile.ZipFile(zip_path) as zf:
        matches = [n for n in zf.namelist() if n.endswith(bundle_suffix)]
        if len(matches) != 1:
            raise RuntimeError(f"Expected one bundle match for {bundle_suffix!r}; found {len(matches)}")
        env = UnityPy.load(zf.read(matches[0]))

    renderer = mesh = handler = None
    for obj in env.objects:
        if obj.type.name != "SkinnedMeshRenderer":
            continue
        rd = obj.read()
        try:
            candidate = rd.m_Mesh.read()
        except Exception:
            continue
        if getattr(candidate, "m_Name", "") == mesh_name:
            renderer, mesh = rd, candidate
            handler = MeshHandler(mesh)
            handler.process()
            break
    if renderer is None:
        raise RuntimeError(f"SkinnedMeshRenderer for mesh {mesh_name!r} not found")
    if not handler.m_Vertices or not handler.m_IndexBuffer or not handler.m_BoneWeights:
        raise RuntimeError("Mesh lacks vertices, indices, or skin weights")
    if len(renderer.m_Bones) != len(mesh.m_BindPose):
        raise RuntimeError(f"Bone/bind pose count mismatch: {len(renderer.m_Bones)} vs {len(mesh.m_BindPose)}")

    # Gather all bone transforms and their ancestors, retaining the exact serialized TRS.
    transforms = {}
    parent_ids = {}
    bone_ids = []
    for ptr in renderer.m_Bones:
        bone_ids.append(int(ptr.m_PathID))
        current = ptr
        while current.m_PathID:
            path_id = int(current.m_PathID)
            if path_id in transforms:
                break
            tr = current.read()
            transforms[path_id] = tr
            parent = tr.m_Father
            parent_ids[path_id] = int(parent.m_PathID)
            current = parent
    # Verify every parent reference needed by the exported skeleton is present.
    for path_id, parent_id in parent_ids.items():
        if parent_id and parent_id not in transforms:
            raise RuntimeError(f"Missing parent transform {parent_id} for bone {path_id}")

    path_to_name = {}
    original_names = {}
    for path_id, tr in transforms.items():
        go = tr.m_GameObject.read()
        original = go.m_Name
        original_names[path_id] = original
        path_to_name[path_id] = BONE_RENAMES.get(original, original)
    path_to_id = {pid: "joint_" + safe_id(name) for pid, name in path_to_name.items()}
    # Different source names must not collapse onto one identifier.
    if len(set(path_to_id.values())) != len(path_to_id):
        raise RuntimeError("Bone rename map produced duplicate node identifiers")

    # Match the source animation hierarchy: jRoot is the scene-level rig root, and
    # both shoulder joints are direct children of jLowerSpine. Copenhagen has a
    # non-bone Root parent and an extra clavicle joint, so preserve their world poses
    # while flattening only those hierarchy differences.
    def bone_id(original_name):
        return next((pid for pid in bone_ids if original_names.get(pid) == original_name), None)
    root_joint_id = bone_id("Root_jnt")
    lower_spine_id = bone_id("LowerSpine_jnt")
    left_shoulder_id = bone_id("L_Shoulder_jnt")
    right_shoulder_id = bone_id("R_Shoulder_jnt")
    if None in (root_joint_id, lower_spine_id, left_shoulder_id, right_shoulder_id):
        raise RuntimeError("The Copenhagen skeleton does not contain the expected core joints")
    new_parent_ids = parent_ids.copy()
    new_parent_ids[root_joint_id] = 0
    new_parent_ids[left_shoulder_id] = lower_spine_id
    new_parent_ids[right_shoulder_id] = lower_spine_id
    active_path_ids = {pid for pid in transforms if pid == root_joint_id or is_descendant(pid, root_joint_id, new_parent_ids)}
    if not set(bone_ids).issubset(active_path_ids):
        raise RuntimeError("Flattened skeleton hierarchy lost one or more weighted joints")
    world_cache = {}
    def original_world(pid):
        if pid not in world_cache:
            parent_id = parent_ids.get(pid, 0)
            local = trs_matrix(transforms[pid])
            world_cache[pid] = original_world(parent_id) @ local if parent_id in transforms else local
        return world_cache[pid]
    node_trs = {}
    for pid in active_path_ids:
        if pid == root_joint_id or pid in (left_shoulder_id, right_shoulder_id):
            new_parent = new_parent_ids[pid]
            local_matrix = original_world(pid) if not new_parent else np.linalg.inv(original_world(new_parent)) @ original_world(pid)
            node_trs[pid] = matrix_to_trs(local_matrix)
        else:
            tr = transforms[pid]
            node_trs[pid] = (xyz(tr.m_LocalPosition), quat(tr.m_LocalRotation), xyz(tr.m_LocalScale))

    # Generate normals because many Copenhagen meshes store them compressed without a
    # separately decoded normal channel in the current UnityPy reader.
    vertices = [tuple(map(float, v)) for v in handler.m_Vertices]
    indices = [int(v) for v in handler.m_IndexBuffer]
    if len(indices) % 3:
        raise RuntimeError("Triangle index count is not divisible by three")
    normals = [[0.0, 0.0, 0.0] for _ in vertices]
    for i in range(0, len(indices), 3):
        a, b, c = (vertices[indices[i+j]] for j in range(3))
        u = (b[0]-a[0], b[1]-a[1], b[2]-a[2])
        v = (c[0]-a[0], c[1]-a[1], c[2]-a[2])
        n = (u[1]*v[2]-u[2]*v[1], u[2]*v[0]-u[0]*v[2], u[0]*v[1]-u[1]*v[0])
        for vi in (indices[i], indices[i+1], indices[i+2]):
            normals[vi][0] += n[0]; normals[vi][1] += n[1]; normals[vi][2] += n[2]
    normals = [tuple(c / (math.sqrt(sum(x*x for x in n)) or 1.0) for c in n) for n in normals]
    uvs = [tuple(map(float, uv[:2])) for uv in (handler.m_UV0 or [(0.0, 0.0)]*len(vertices))]
    if len(uvs) != len(vertices):
        raise RuntimeError("UV0 count does not match vertex count")
    if max(indices) >= len(vertices) or min(indices) < 0:
        raise RuntimeError("Mesh index is outside the vertex array")

    # COLLADA 1.4.1 document.
    root = ET.Element(tag("COLLADA"), {"version": "1.4.1"})
    asset = ET.SubElement(root, tag("asset"))
    contributor = ET.SubElement(asset, tag("contributor"))
    ET.SubElement(contributor, tag("authoring_tool")).text = "UnityPy static mesh/rig export"
    ET.SubElement(asset, tag("unit"), {"name": "meter", "meter": "1"})
    ET.SubElement(asset, tag("up_axis")).text = "Y_UP"

    material_name, texture = find_texture(env, renderer)
    material_id = "copenhagen-material"
    image_name = None
    if texture is not None:
        image_name = safe_id(texture.m_Name) + ".png"
        image_path = outdir / image_name
        texture.image.save(image_path)
        images = ET.SubElement(root, tag("library_images"))
        image = ET.SubElement(images, tag("image"), {"id": "copenhagen-image", "name": texture.m_Name})
        ET.SubElement(image, tag("init_from")).text = image_name
        effects = ET.SubElement(root, tag("library_effects"))
        effect = ET.SubElement(effects, tag("effect"), {"id": "copenhagen-effect"})
        profile = ET.SubElement(effect, tag("profile_COMMON"))
        surface = ET.SubElement(profile, tag("newparam"), {"sid": "copenhagen-surface"})
        surf = ET.SubElement(surface, tag("surface"), {"type": "2D"})
        ET.SubElement(surf, tag("init_from")).text = "copenhagen-image"
        sampler = ET.SubElement(profile, tag("newparam"), {"sid": "copenhagen-sampler"})
        samp = ET.SubElement(sampler, tag("sampler2D"))
        ET.SubElement(samp, tag("source")).text = "copenhagen-surface"
        technique = ET.SubElement(profile, tag("technique"), {"sid": "common"})
        phong = ET.SubElement(technique, tag("phong"))
        diffuse = ET.SubElement(phong, tag("diffuse"))
        ET.SubElement(diffuse, tag("texture"), {"texture": "copenhagen-sampler", "texcoord": "UVMap"})
        materials = ET.SubElement(root, tag("library_materials"))
        mat = ET.SubElement(materials, tag("material"), {"id": material_id, "name": material_name})
        ET.SubElement(mat, tag("instance_effect"), {"url": "#copenhagen-effect"})

    geos = ET.SubElement(root, tag("library_geometries"))
    geometry = ET.SubElement(geos, tag("geometry"), {"id": "copenhagen-geometry", "name": mesh_name})
    mesh_node = ET.SubElement(geometry, tag("mesh"))
    add_source(mesh_node, "copenhagen-positions", "float_array", vertices, len(vertices), 3, [("X", "float"), ("Y", "float"), ("Z", "float")])
    add_source(mesh_node, "copenhagen-normals", "float_array", normals, len(normals), 3, [("X", "float"), ("Y", "float"), ("Z", "float")])
    add_source(mesh_node, "copenhagen-uv", "float_array", uvs, len(uvs), 2, [("S", "float"), ("T", "float")])
    verts = ET.SubElement(mesh_node, tag("vertices"), {"id": "copenhagen-vertices"})
    ET.SubElement(verts, tag("input"), {"semantic": "POSITION", "source": "#copenhagen-positions"})
    triangles = ET.SubElement(mesh_node, tag("triangles"), {"count": str(len(indices)//3), "material": "copenhagen-material-symbol"})
    ET.SubElement(triangles, tag("input"), {"semantic": "VERTEX", "source": "#copenhagen-vertices", "offset": "0"})
    ET.SubElement(triangles, tag("input"), {"semantic": "NORMAL", "source": "#copenhagen-normals", "offset": "1"})
    ET.SubElement(triangles, tag("input"), {"semantic": "TEXCOORD", "source": "#copenhagen-uv", "offset": "2", "set": "0"})
    packed_indices = []
    for vi in indices:
        packed_indices.extend((vi, vi, vi))
    ET.SubElement(triangles, tag("p")).text = " ".join(map(str, packed_indices))

    controllers = ET.SubElement(root, tag("library_controllers"))
    controller = ET.SubElement(controllers, tag("controller"), {"id": "copenhagen-skin", "name": mesh_name + "_Skin"})
    skin = ET.SubElement(controller, tag("skin"), {"source": "#copenhagen-geometry"})
    ET.SubElement(skin, tag("bind_shape_matrix")).text = fmt((1,0,0,0, 0,1,0,0, 0,0,1,0, 0,0,0,1))
    joint_names = [path_to_name[pid] for pid in bone_ids]
    name_src = ET.SubElement(skin, tag("source"), {"id": "copenhagen-joints"})
    name_arr = ET.SubElement(name_src, tag("Name_array"), {"id": "copenhagen-joints-array", "count": str(len(joint_names))})
    name_arr.text = " ".join(joint_names)
    tc = ET.SubElement(name_src, tag("technique_common"))
    ET.SubElement(tc, tag("accessor"), {"source": "#copenhagen-joints-array", "count": str(len(joint_names)), "stride": "1"}).append(ET.Element(tag("param"), {"name": "JOINT", "type": "Name"}))
    bind_src = ET.SubElement(skin, tag("source"), {"id": "copenhagen-bindposes"})
    bind_arr = ET.SubElement(bind_src, tag("float_array"), {"id": "copenhagen-bindposes-array", "count": str(16*len(mesh.m_BindPose))})
    bind_flat = []
    for matrix in mesh.m_BindPose:
        rows = [[float(getattr(matrix, f"e{r}{c}")) for c in range(4)] for r in range(4)]
        bind_flat.extend(rows[r][c] for c in range(4) for r in range(4))
    bind_arr.text = fmt(bind_flat)
    bind_tc = ET.SubElement(bind_src, tag("technique_common"))
    bind_acc = ET.SubElement(bind_tc, tag("accessor"), {"source": "#copenhagen-bindposes-array", "count": str(len(mesh.m_BindPose)), "stride": "16"})
    ET.SubElement(bind_acc, tag("param"), {"type": "float4x4"})
    joints = ET.SubElement(skin, tag("joints"))
    ET.SubElement(joints, tag("input"), {"semantic": "JOINT", "source": "#copenhagen-joints"})
    ET.SubElement(joints, tag("input"), {"semantic": "INV_BIND_MATRIX", "source": "#copenhagen-bindposes"})

    weights = []
    vcounts = []
    vstream = []
    for bone_row, weight_row in zip(handler.m_BoneIndices, handler.m_BoneWeights):
        influences = [(int(bi), float(w)) for bi, w in zip(bone_row, weight_row) if float(w) > 1e-6]
        if not influences:
            raise RuntimeError("A vertex has no non-zero skin influences")
        # Unity's packed 5-bit weights can sum to slightly less than 1 after decoding.
        weight_sum = sum(w for _, w in influences)
        if weight_sum <= 0:
            raise RuntimeError("A vertex has a non-positive total skin weight")
        influences = [(bi, w / weight_sum) for bi, w in influences]
        vcounts.append(len(influences))
        for bi, w in influences:
            if bi < 0 or bi >= len(bone_ids):
                raise RuntimeError(f"Bone index {bi} outside {len(bone_ids)} bones")
            wi = len(weights); weights.append(w); vstream.extend((bi, wi))
    weight_src = ET.SubElement(skin, tag("source"), {"id": "copenhagen-weights"})
    w_arr = ET.SubElement(weight_src, tag("float_array"), {"id": "copenhagen-weights-array", "count": str(len(weights))})
    w_arr.text = fmt(weights)
    w_tc = ET.SubElement(weight_src, tag("technique_common"))
    w_acc = ET.SubElement(w_tc, tag("accessor"), {"source": "#copenhagen-weights-array", "count": str(len(weights)), "stride": "1"})
    ET.SubElement(w_acc, tag("param"), {"name": "WEIGHT", "type": "float"})
    vw = ET.SubElement(skin, tag("vertex_weights"), {"count": str(len(vertices))})
    ET.SubElement(vw, tag("input"), {"semantic": "JOINT", "source": "#copenhagen-joints", "offset": "0"})
    ET.SubElement(vw, tag("input"), {"semantic": "WEIGHT", "source": "#copenhagen-weights", "offset": "1"})
    ET.SubElement(vw, tag("vcount")).text = " ".join(map(str, vcounts))
    ET.SubElement(vw, tag("v")).text = " ".join(map(str, vstream))

    scenes = ET.SubElement(root, tag("library_visual_scenes"))
    visual = ET.SubElement(scenes, tag("visual_scene"), {"id": "CopenhagenScene", "name": "CopenhagenScene"})
    children = {}
    roots = []
    for pid, parent_id in new_parent_ids.items():
        if pid not in active_path_ids:
            continue
        if parent_id in active_path_ids:
            children.setdefault(parent_id, []).append(pid)
        else:
            roots.append(pid)
    def emit_joint(parent_xml, pid):
        name = path_to_name[pid]
        attrs = {"id": path_to_id[pid], "name": name, "sid": name, "type": "JOINT" if pid in bone_ids else "NODE"}
        node = ET.SubElement(parent_xml, tag("node"), attrs)
        position, rotation, scale = node_trs[pid]
        ET.SubElement(node, tag("translate")).text = fmt(position)
        ET.SubElement(node, tag("rotate")).text = fmt(quat_axis_angle(rotation))
        ET.SubElement(node, tag("scale")).text = fmt(scale)
        for child_id in children.get(pid, []):
            emit_joint(node, child_id)
        return node
    root_node = None
    for pid in roots:
        node = emit_joint(visual, pid)
        if pid == root_joint_id:
            root_node = node
    if root_node is None:
        raise RuntimeError("Could not locate a skeleton root node")
    model_node = ET.SubElement(visual, tag("node"), {"id": "copenhagen-character", "name": mesh_name + "_Model", "type": "NODE"})
    inst = ET.SubElement(model_node, tag("instance_controller"), {"url": "#copenhagen-skin"})
    ET.SubElement(inst, tag("skeleton")).text = "#" + root_node.get("id")
    if texture is not None:
        bm = ET.SubElement(inst, tag("bind_material"))
        tc = ET.SubElement(bm, tag("technique_common"))
        im = ET.SubElement(tc, tag("instance_material"), {"symbol": "copenhagen-material-symbol", "target": "#" + material_id})
        bind = ET.SubElement(im, tag("bind_vertex_input"), {"semantic": "UVMap", "input_semantic": "TEXCOORD", "input_set": "0"})

    scene = ET.SubElement(root, tag("scene"))
    ET.SubElement(scene, tag("instance_visual_scene"), {"url": "#CopenhagenScene"})
    out = outdir / (safe_id(mesh_name) + ".dae")
    ET.ElementTree(root).write(out, encoding="utf-8", xml_declaration=True)
    return out, image_name, len(vertices), len(indices)//3, len(bone_ids)

def is_descendant(pid, ancestor, parents):
    seen=set()
    while pid and pid not in seen:
        if pid == ancestor: return True
        seen.add(pid); pid=parents.get(pid, 0)
    return False

if __name__ == "__main__":
    ap=argparse.ArgumentParser()
    ap.add_argument("zip")
    ap.add_argument("bundle_suffix", help="Unique path suffix, e.g. CharacterPacks/<hash>.bundle")
    ap.add_argument("mesh_name")
    ap.add_argument("outdir")
    args=ap.parse_args()
    print(export(args.zip,args.bundle_suffix,args.mesh_name,args.outdir))
