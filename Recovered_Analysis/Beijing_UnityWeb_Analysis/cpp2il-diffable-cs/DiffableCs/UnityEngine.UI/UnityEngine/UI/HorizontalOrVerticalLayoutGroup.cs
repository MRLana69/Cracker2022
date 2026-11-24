namespace UnityEngine.UI;

public abstract class HorizontalOrVerticalLayoutGroup : LayoutGroup
{
	protected float m_Spacing; //Field offset: 0x38
	protected bool m_ChildForceExpandWidth; //Field offset: 0x3C
	protected bool m_ChildForceExpandHeight; //Field offset: 0x3D
	protected bool m_ChildControlWidth; //Field offset: 0x3E
	protected bool m_ChildControlHeight; //Field offset: 0x3F
	protected bool m_ChildScaleWidth; //Field offset: 0x40
	protected bool m_ChildScaleHeight; //Field offset: 0x41

	public bool childControlHeight
	{
		 get { } //Length: 9
		 set { } //Length: 56
	}

	public bool childControlWidth
	{
		 get { } //Length: 9
		 set { } //Length: 56
	}

	public bool childForceExpandHeight
	{
		 get { } //Length: 9
		 set { } //Length: 56
	}

	public bool childForceExpandWidth
	{
		 get { } //Length: 6
		 set { } //Length: 2153
	}

	public bool childScaleHeight
	{
		 get { } //Length: 12
		 set { } //Length: 56
	}

	public bool childScaleWidth
	{
		 get { } //Length: 9
		 set { } //Length: 56
	}

	public float spacing
	{
		 get { } //Length: 6
		 set { } //Length: 38
	}

	protected HorizontalOrVerticalLayoutGroup() { }

	protected void CalcAlongAxis(int axis, bool isVertical) { }

	public bool get_childControlHeight() { }

	public bool get_childControlWidth() { }

	public bool get_childForceExpandHeight() { }

	public bool get_childForceExpandWidth() { }

	public bool get_childScaleHeight() { }

	public bool get_childScaleWidth() { }

	public float get_spacing() { }

	private void GetChildSizes(RectTransform child, int axis, bool controlSize, bool childForceExpand, out float min, out float preferred, out float flexible) { }

	public void set_childControlHeight(bool value) { }

	public void set_childControlWidth(bool value) { }

	public void set_childForceExpandHeight(bool value) { }

	public void set_childForceExpandWidth(bool value) { }

	public void set_childScaleHeight(bool value) { }

	public void set_childScaleWidth(bool value) { }

	public void set_spacing(float value) { }

	protected void SetChildrenAlongAxis(int axis, bool isVertical) { }

}

