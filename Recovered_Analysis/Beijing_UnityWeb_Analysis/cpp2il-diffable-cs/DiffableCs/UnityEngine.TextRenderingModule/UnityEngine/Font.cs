namespace UnityEngine;

public sealed class Font : Object
{
	public delegate FontTextureRebuildCallback
	{

		public FontTextureRebuildCallback(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke() { }

	}

	private static Action<Font> textureRebuilt; //Field offset: 0x0
	private FontTextureRebuildCallback m_FontTextureRebuildCallback; //Field offset: 0xC

	public static event Action<Font> textureRebuilt
	{
		 add { } //Length: 81
		 remove { } //Length: 132
	}

	public bool dynamic
	{
		 get { } //Length: 49
	}

	public string[] fontNames
	{
		 get { } //Length: 49
	}

	public int fontSize
	{
		 get { } //Length: 49
	}

	public Material material
	{
		 get { } //Length: 12
	}

	public Font() { }

	public static void add_textureRebuilt(Action<Font> value) { }

	public bool get_dynamic() { }

	public string[] get_fontNames() { }

	public int get_fontSize() { }

	public Material get_material() { }

	public bool GetCharacterInfo(char ch, out CharacterInfo info, int size, FontStyle style) { }

	public bool HasCharacter(char c) { }

	private bool HasCharacter(int c) { }

	private static void Internal_CreateFont(Font self, string name) { }

	internal static void InvokeTextureRebuilt_Internal(Font font) { }

	public static void remove_textureRebuilt(Action<Font> value) { }

	public void RequestCharactersInTexture(string characters, int size, FontStyle style) { }

}

