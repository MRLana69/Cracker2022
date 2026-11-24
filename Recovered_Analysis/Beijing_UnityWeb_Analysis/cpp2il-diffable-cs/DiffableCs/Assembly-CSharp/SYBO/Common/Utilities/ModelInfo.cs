namespace SYBO.Common.Utilities;

public class ModelInfo
{
	public Mesh Mesh; //Field offset: 0x8
	public Material[] Materials; //Field offset: 0xC

	public ModelInfo(Mesh mesh, Material[] materials) { }

}

