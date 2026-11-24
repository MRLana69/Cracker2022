namespace UnityEngine;

internal class GUILayoutGroup : GUILayoutEntry
{
	public List<GUILayoutEntry> entries; //Field offset: 0x38
	public bool isVertical; //Field offset: 0x3C
	public bool resetCoords; //Field offset: 0x3D
	public float spacing; //Field offset: 0x40
	public bool sameSize; //Field offset: 0x44
	public bool isWindow; //Field offset: 0x45
	public int windowID; //Field offset: 0x48
	private int m_Cursor; //Field offset: 0x4C
	protected int m_StretchableCountX; //Field offset: 0x50
	protected int m_StretchableCountY; //Field offset: 0x54
	protected bool m_UserSpecifiedWidth; //Field offset: 0x58
	protected bool m_UserSpecifiedHeight; //Field offset: 0x59
	protected float m_ChildMinWidth; //Field offset: 0x5C
	protected float m_ChildMaxWidth; //Field offset: 0x60
	protected float m_ChildMinHeight; //Field offset: 0x64
	protected float m_ChildMaxHeight; //Field offset: 0x68
	protected int m_MarginLeft; //Field offset: 0x6C
	protected int m_MarginRight; //Field offset: 0x70
	protected int m_MarginTop; //Field offset: 0x74
	protected int m_MarginBottom; //Field offset: 0x78

	public override int marginBottom
	{
		 get { } //Length: 6
	}

	public override int marginLeft
	{
		 get { } //Length: 930
	}

	public override int marginRight
	{
		 get { } //Length: 6
	}

	public override int marginTop
	{
		 get { } //Length: 6
	}

	public GUILayoutGroup() { }

	public void Add(GUILayoutEntry e) { }

	public override void ApplyOptions(GUILayoutOption[] options) { }

	protected override void ApplyStyleSettings(GUIStyle style) { }

	public override void CalcHeight() { }

	public override void CalcWidth() { }

	public override int get_marginBottom() { }

	public override int get_marginLeft() { }

	public override int get_marginRight() { }

	public override int get_marginTop() { }

	public GUILayoutEntry GetNext() { }

	public void ResetCursor() { }

	public override void SetHorizontal(float x, float width) { }

	public override void SetVertical(float y, float height) { }

	public override string ToString() { }

}

