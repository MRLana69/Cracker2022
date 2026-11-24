namespace UnityEngine.UI;

public class ContentSizeFitter : UIBehaviour, ILayoutSelfController, ILayoutController
{
	public enum FitMode
	{
		Unconstrained = 0,
		MinSize = 1,
		PreferredSize = 2,
	}

	protected FitMode m_HorizontalFit; //Field offset: 0xC
	protected FitMode m_VerticalFit; //Field offset: 0x10
	private RectTransform m_Rect; //Field offset: 0x14
	private DrivenRectTransformTracker m_Tracker; //Field offset: 0x18

	public FitMode horizontalFit
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	private RectTransform rectTransform
	{
		 get { } //Length: 6
	}

	public FitMode verticalFit
	{
		 get { } //Length: 6
		 set { } //Length: 65
	}

	protected ContentSizeFitter() { }

	public FitMode get_horizontalFit() { }

	private RectTransform get_rectTransform() { }

	public FitMode get_verticalFit() { }

	private void HandleSelfFittingAlongAxis(int axis) { }

	protected override void OnDisable() { }

	protected override void OnEnable() { }

	protected override void OnRectTransformDimensionsChange() { }

	public void set_horizontalFit(FitMode value) { }

	public void set_verticalFit(FitMode value) { }

	protected void SetDirty() { }

	public virtual void SetLayoutHorizontal() { }

	public virtual void SetLayoutVertical() { }

}

