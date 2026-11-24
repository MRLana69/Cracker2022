namespace UnityEngine.U2D;

public class SpriteAtlasManager
{
	private static Action<string, Action<SpriteAtlas>> atlasRequested; //Field offset: 0x0
	private static Action<SpriteAtlas> atlasRegistered; //Field offset: 0x4
	private static Action<SpriteAtlas> <>f__mg$cache0; //Field offset: 0x8

	public static event Action<SpriteAtlas> atlasRegistered
	{
		 add { } //Length: 71
		 remove { } //Length: 211
	}

	private static SpriteAtlasManager() { }

	public static void add_atlasRegistered(Action<SpriteAtlas> value) { }

	private static void PostRegisteredAtlas(SpriteAtlas spriteAtlas) { }

	internal static void Register(SpriteAtlas spriteAtlas) { }

	public static void remove_atlasRegistered(Action<SpriteAtlas> value) { }

	private static bool RequestAtlas(string tag) { }

}

