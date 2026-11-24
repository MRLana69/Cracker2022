namespace UnityEngine;

public sealed class GUISettings
{
	private bool m_DoubleClickSelectsWord; //Field offset: 0x8
	private bool m_TripleClickSelectsLine; //Field offset: 0x9
	private Color m_CursorColor; //Field offset: 0xC
	private float m_CursorFlashSpeed; //Field offset: 0x1C
	private Color m_SelectionColor; //Field offset: 0x20

	public Color cursorColor
	{
		 get { } //Length: 53
	}

	public float cursorFlashSpeed
	{
		 get { } //Length: 6
	}

	public bool doubleClickSelectsWord
	{
		 get { } //Length: 206
	}

	public Color selectionColor
	{
		 get { } //Length: 100
	}

	public bool tripleClickSelectsLine
	{
		 get { } //Length: 9
	}

	public GUISettings() { }

	public Color get_cursorColor() { }

	public float get_cursorFlashSpeed() { }

	public bool get_doubleClickSelectsWord() { }

	public Color get_selectionColor() { }

	public bool get_tripleClickSelectsLine() { }

	private static float Internal_GetCursorFlashSpeed() { }

}

