namespace UnityEngine.UI;

public class AspectRatioFitter : UIBehaviour, ILayoutSelfController, ILayoutController
{
	public enum AspectMode
	{
		None = 0,
		WidthControlsHeight = 1,
		HeightControlsWidth = 2,
		FitInParent = 3,
		EnvelopeParent = 4,
	}

	private AspectMode m_AspectMode; //Field offset: 0xC
	private float m_AspectRatio; //Field offset: 0x10
	private RectTransform m_Rect; //Field offset: 0x14
	private bool m_DelayedSetDirty; //Field offset: 0x18
	private DrivenRectTransformTracker m_Tracker; //Field offset: 0x19

	public AspectMode aspectMode
	{
		 get { } //Length: 9
		 set { } //Length: 83
	}

	public float aspectRatio
	{
		 get { } //Length: 6
		 set { } //Length: 75
	}

	private RectTransform rectTransform
	{
		 get { } //Length: 6
	}

	protected AspectRatioFitter() { }

	public AspectMode get_aspectMode() { }

	public float get_aspectRatio() { }

	private RectTransform get_rectTransform() { }

	private Vector2 GetParentSize() { }

	private float GetSizeDeltaToProduceSize(float size, int axis) { }

	protected override void OnDisable() { }

	protected override void OnEnable() { }

	protected override void OnRectTransformDimensionsChange() { }

	public void set_aspectMode(AspectMode value) { }

	public void set_aspectRatio(float value) { }

	protected void SetDirty() { }

	public virtual void SetLayoutHorizontal() { }

	public virtual void SetLayoutVertical() { }

	protected virtual void Update() { }

	private void UpdateRect() { }

}

