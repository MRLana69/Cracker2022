namespace SYBO.Components.Logging;

public class Sample
{
	public float time; //Field offset: 0x8
	public byte loadedScene; //Field offset: 0xC
	public float memory; //Field offset: 0x10
	public float fps; //Field offset: 0x14
	public string fpsText; //Field offset: 0x18

	public Sample() { }

	public static float MemSize() { }

}

