namespace UnityEngine.UI;

public abstract class LayoutGroup : UIBehaviour, ILayoutElement, ILayoutGroup, ILayoutController
{
	private sealed class <DelayedSetDirty>d__56 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public RectTransform rectTransform; //Field offset: 0x10

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 145
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <DelayedSetDirty>d__56(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	protected RectOffset m_Padding; //Field offset: 0xC
	protected TextAnchor m_ChildAlignment; //Field offset: 0x10
	private RectTransform m_Rect; //Field offset: 0x14
	protected DrivenRectTransformTracker m_Tracker; //Field offset: 0x18
	private Vector2 m_TotalMinSize; //Field offset: 0x1C
	private Vector2 m_TotalPreferredSize; //Field offset: 0x24
	private Vector2 m_TotalFlexibleSize; //Field offset: 0x2C
	private List<RectTransform> m_RectChildren; //Field offset: 0x34

	public TextAnchor childAlignment
	{
		 get { } //Length: 6
		 set { } //Length: 56
	}

	public virtual float flexibleHeight
	{
		 get { } //Length: 11
	}

	public virtual float flexibleWidth
	{
		 get { } //Length: 11
	}

	private bool isRootLayoutGroup
	{
		 get { } //Length: 3
	}

	public virtual int layoutPriority
	{
		 get { } //Length: 6
	}

	public virtual float minHeight
	{
		 get { } //Length: 11
	}

	public virtual float minWidth
	{
		 get { } //Length: 6
	}

	public RectOffset padding
	{
		 get { } //Length: 6
		 set { } //Length: 65
	}

	public virtual float preferredHeight
	{
		 get { } //Length: 11
	}

	public virtual float preferredWidth
	{
		 get { } //Length: 11
	}

	protected List<RectTransform> rectChildren
	{
		 get { } //Length: 114
	}

	protected RectTransform rectTransform
	{
		 get { } //Length: 6
	}

	protected LayoutGroup() { }

	public virtual void CalculateLayoutInputHorizontal() { }

	public abstract void CalculateLayoutInputVertical() { }

	private IEnumerator DelayedSetDirty(RectTransform rectTransform) { }

	public TextAnchor get_childAlignment() { }

	public virtual float get_flexibleHeight() { }

	public virtual float get_flexibleWidth() { }

	private bool get_isRootLayoutGroup() { }

	public virtual int get_layoutPriority() { }

	public virtual float get_minHeight() { }

	public virtual float get_minWidth() { }

	public RectOffset get_padding() { }

	public virtual float get_preferredHeight() { }

	public virtual float get_preferredWidth() { }

	protected List<RectTransform> get_rectChildren() { }

	protected RectTransform get_rectTransform() { }

	protected float GetAlignmentOnAxis(int axis) { }

	protected float GetStartOffset(int axis, float requiredSpaceWithoutPadding) { }

	protected float GetTotalFlexibleSize(int axis) { }

	protected float GetTotalMinSize(int axis) { }

	protected float GetTotalPreferredSize(int axis) { }

	protected override void OnDidApplyAnimationProperties() { }

	protected override void OnDisable() { }

	protected override void OnEnable() { }

	protected override void OnRectTransformDimensionsChange() { }

	protected virtual void OnTransformChildrenChanged() { }

	public void set_childAlignment(TextAnchor value) { }

	public void set_padding(RectOffset value) { }

	protected void SetChildAlongAxis(RectTransform rect, int axis, float pos, float size) { }

	protected void SetChildAlongAxis(RectTransform rect, int axis, float pos) { }

	protected void SetChildAlongAxisWithScale(RectTransform rect, int axis, float pos, float size, float scaleFactor) { }

	protected void SetChildAlongAxisWithScale(RectTransform rect, int axis, float pos, float scaleFactor) { }

	protected void SetDirty() { }

	public abstract void SetLayoutHorizontal() { }

	protected void SetLayoutInputForAxis(float totalMin, float totalPreferred, float totalFlexible, int axis) { }

	public abstract void SetLayoutVertical() { }

	protected void SetProperty(ref T currentValue, T newValue) { }

}

