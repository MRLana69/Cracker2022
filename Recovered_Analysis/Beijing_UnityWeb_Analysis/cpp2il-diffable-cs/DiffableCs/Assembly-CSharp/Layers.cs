//Type is in global namespace

public class Layers
{
	private static Layers _instance; //Field offset: 0x0
	public readonly int Default; //Field offset: 0x8
	public readonly int Hit; //Field offset: 0xC
	public readonly int Unremovable; //Field offset: 0x10
	public readonly int Character; //Field offset: 0x14
	public readonly int Guard; //Field offset: 0x18
	public readonly int Pickup; //Field offset: 0x1C
	public readonly int Coin; //Field offset: 0x20
	public readonly int Background; //Field offset: 0x24
	public readonly int TutorialTrigger; //Field offset: 0x28
	public readonly int TrackEvent; //Field offset: 0x2C
	public readonly int TrackEventTrigger; //Field offset: 0x30
	public readonly int SkateparkSetPiece; //Field offset: 0x34
	public readonly int Ramp; //Field offset: 0x38
	public readonly int LoadScreenLayer; //Field offset: 0x3C
	public readonly int _3DGUI; //Field offset: 0x40
	public readonly int _3DCLIP; //Field offset: 0x44
	public readonly int _RENDERTEXTURE; //Field offset: 0x48
	public readonly int CELEBRATION; //Field offset: 0x4C
	public readonly int _2DGUI; //Field offset: 0x50
	public readonly int _2DOVERLAY; //Field offset: 0x54
	public readonly int _2DOVERLAYCLIP; //Field offset: 0x58
	public readonly int _3DOVERLAY; //Field offset: 0x5C

	public static Layers Instance
	{
		 get { } //Length: 234
	}

	private static Layers() { }

	private Layers() { }

	private static int FindLayer(string name) { }

	public static Layers get_Instance() { }

	public static void Init() { }

}

