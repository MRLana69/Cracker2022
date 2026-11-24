namespace UnityEngine.UI;

public class LayoutElement : UIBehaviour, ILayoutElement, ILayoutIgnorer
{
	private bool m_IgnoreLayout; //Field offset: 0xC
	private float m_MinWidth; //Field offset: 0x10
	private float m_MinHeight; //Field offset: 0x14
	private float m_PreferredWidth; //Field offset: 0x18
	private float m_PreferredHeight; //Field offset: 0x1C
	private float m_FlexibleWidth; //Field offset: 0x20
	private float m_FlexibleHeight; //Field offset: 0x24
	private int m_LayoutPriority; //Field offset: 0x28

	public virtual float flexibleHeight
	{
		 get { } //Length: 6
		 set { } //Length: 65
	}

	public virtual float flexibleWidth
	{
		 get { } //Length: 6
		 set { } //Length: 65
	}

	public virtual bool ignoreLayout
	{
		 get { } //Length: 9
		 set { } //Length: 57
	}

	public virtual int layoutPriority
	{
		 get { } //Length: 9
		 set { } //Length: 65
	}

	public virtual float minHeight
	{
		 get { } //Length: 6
		 set { } //Length: 65
	}

	public virtual float minWidth
	{
		 get { } //Length: 6
		 set { } //Length: 56
	}

	public virtual float preferredHeight
	{
		 get { } //Length: 6
		 set { } //Length: 65
	}

	public virtual float preferredWidth
	{
		 get { } //Length: 6
		 set { } //Length: 65
	}

	protected LayoutElement() { }

	public virtual void CalculateLayoutInputHorizontal() { }

	public virtual void CalculateLayoutInputVertical() { }

	public virtual float get_flexibleHeight() { }

	public virtual float get_flexibleWidth() { }

	public virtual bool get_ignoreLayout() { }

	public virtual int get_layoutPriority() { }

	public virtual float get_minHeight() { }

	public virtual float get_minWidth() { }

	public virtual float get_preferredHeight() { }

	public virtual float get_preferredWidth() { }

	protected override void OnBeforeTransformParentChanged() { }

	protected override void OnDidApplyAnimationProperties() { }

	protected override void OnDisable() { }

	protected override void OnEnable() { }

	protected override void OnTransformParentChanged() { }

	public virtual void set_flexibleHeight(float value) { }

	public virtual void set_flexibleWidth(float value) { }

	public virtual void set_ignoreLayout(bool value) { }

	public virtual void set_layoutPriority(int value) { }

	public virtual void set_minHeight(float value) { }

	public virtual void set_minWidth(float value) { }

	public virtual void set_preferredHeight(float value) { }

	public virtual void set_preferredWidth(float value) { }

	protected void SetDirty() { }

}

