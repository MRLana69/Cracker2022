namespace SYBO.Subway.Level;

public class Background
{
	public float SkylineLeftLimit; //Field offset: 0x8
	public float SkylineRightLimit; //Field offset: 0xC
	public Shader LayerCommonMaterialShader; //Field offset: 0x10
	public float LayerSpacing; //Field offset: 0x14
	public BackgroundLayer[] Layers; //Field offset: 0x18
	public float GradientTop; //Field offset: 0x1C
	public float GradientBottom; //Field offset: 0x20
	public Color GradientTopColor; //Field offset: 0x24
	public Color GradientBottomColor; //Field offset: 0x34
	public BackgroundCulling[] Culling; //Field offset: 0x44
	public Color BackgroundCullingColor; //Field offset: 0x48

	public Background() { }

}

