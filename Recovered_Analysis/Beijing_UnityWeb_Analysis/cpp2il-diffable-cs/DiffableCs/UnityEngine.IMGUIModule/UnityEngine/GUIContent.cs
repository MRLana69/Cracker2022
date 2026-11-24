namespace UnityEngine;

public class GUIContent
{
	private static readonly GUIContent s_Text; //Field offset: 0x0
	private static readonly GUIContent s_Image; //Field offset: 0x4
	private static readonly GUIContent s_TextImage; //Field offset: 0x8
	public static GUIContent none; //Field offset: 0xC
	private string m_Text; //Field offset: 0x8
	private Texture m_Image; //Field offset: 0xC
	private string m_Tooltip; //Field offset: 0x10

	public Texture image
	{
		 set { } //Length: 11
	}

	public string text
	{
		 get { } //Length: 49
		 set { } //Length: 118
	}

	public string tooltip
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	private static GUIContent() { }

	public GUIContent() { }

	public GUIContent(string text) { }

	public GUIContent(string text, string tooltip) { }

	public GUIContent(string text, Texture image, string tooltip) { }

	public GUIContent(GUIContent src) { }

	internal static void ClearStaticCache() { }

	public string get_text() { }

	public string get_tooltip() { }

	public void set_image(Texture value) { }

	public void set_text(string value) { }

	public void set_tooltip(string value) { }

	internal static GUIContent Temp(string t) { }

}

