namespace SYBO.Common.Utilities;

public class SubMeshInfo
{
	public MeshFilter MeshFilter; //Field offset: 0x8
	public int SubmeshIndex; //Field offset: 0xC
	public Material Material; //Field offset: 0x10

	public SubMeshInfo(MeshFilter meshFilter, int submeshIndex, Material material) { }

}

