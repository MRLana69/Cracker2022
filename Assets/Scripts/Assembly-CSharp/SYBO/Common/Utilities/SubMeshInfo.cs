using UnityEngine;

namespace SYBO.Common.Utilities;

public class SubMeshInfo(MeshFilter meshFilter, int submeshIndex, Material material)
{
	public MeshFilter MeshFilter = meshFilter;

	public int SubmeshIndex = submeshIndex;

	public Material Material = material;
}
