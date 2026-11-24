namespace UnityEngine;

internal class GUILayoutEntry
{
	internal static Rect kDummyRect; //Field offset: 0x0
	protected static int indent; //Field offset: 0x10
	public float minWidth; //Field offset: 0x8
	public float maxWidth; //Field offset: 0xC
	public float minHeight; //Field offset: 0x10
	public float maxHeight; //Field offset: 0x14
	public Rect rect; //Field offset: 0x18
	public int stretchWidth; //Field offset: 0x28
	public int stretchHeight; //Field offset: 0x2C
	public bool consideredForMargin; //Field offset: 0x30
	private GUIStyle m_Style; //Field offset: 0x34

	public virtual int marginBottom
	{
		 get { } //Length: 18
	}

	public int marginHorizontal
	{
		 get { } //Length: 18
	}

	public virtual int marginLeft
	{
		 get { } //Length: 6
	}

	public virtual int marginRight
	{
		 get { } //Length: 18
	}

	public virtual int marginTop
	{
		 get { } //Length: 18
	}

	public int marginVertical
	{
		 get { } //Length: 22
	}

	public GUIStyle style
	{
		 get { } //Length: 9
		 set { } //Length: 53
	}

	private static GUILayoutEntry() { }

	public GUILayoutEntry(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, GUIStyle _style) { }

	public GUILayoutEntry(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, GUIStyle _style, GUILayoutOption[] options) { }

	public virtual void ApplyOptions(GUILayoutOption[] options) { }

	protected virtual void ApplyStyleSettings(GUIStyle style) { }

	public virtual void CalcHeight() { }

	public virtual void CalcWidth() { }

	public virtual int get_marginBottom() { }

	public int get_marginHorizontal() { }

	public virtual int get_marginLeft() { }

	public virtual int get_marginRight() { }

	public virtual int get_marginTop() { }

	public int get_marginVertical() { }

	public GUIStyle get_style() { }

	public void set_style(GUIStyle value) { }

	public virtual void SetHorizontal(float x, float width) { }

	public virtual void SetVertical(float y, float height) { }

	public override string ToString() { }

}

