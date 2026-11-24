namespace UnityEngine;

public sealed class GUIStyleState
{
	internal nint m_Ptr; //Field offset: 0x8
	private readonly GUIStyle m_SourceStyle; //Field offset: 0xC

	public Texture2D background
	{
		 set { } //Length: 10
	}

	public Color textColor
	{
		 set { } //Length: 53
	}

	public GUIStyleState() { }

	private GUIStyleState(GUIStyle sourceStyle, nint source) { }

	private void Cleanup() { }

	protected override void Finalize() { }

	internal static GUIStyleState GetGUIStyleState(GUIStyle sourceStyle, nint source) { }

	private static nint Init() { }

	public void set_background(Texture2D value) { }

	public void set_textColor(Color value) { }

	private void set_textColor_Injected(ref Color value) { }

}

