namespace WeeklyHunt;

public class WeeklyHuntColorImporterSettings : ScriptableObject
{
	public Texture2D salesTexture; //Field offset: 0xC
	public Texture2D huntTexture; //Field offset: 0x10
	public Vector2[] salesPixelSamplers; //Field offset: 0x14
	public Vector2[] huntPixelSamplers; //Field offset: 0x18
	public Color32[] miscColors; //Field offset: 0x1C
	public Color32[] salesColors; //Field offset: 0x20
	public Color32[] huntColors; //Field offset: 0x24

	public WeeklyHuntColorImporterSettings() { }

}

