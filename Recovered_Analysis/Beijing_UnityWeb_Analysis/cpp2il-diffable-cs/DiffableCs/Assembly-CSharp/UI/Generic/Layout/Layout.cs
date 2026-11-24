namespace UI.Generic.Layout;

public class Layout : MonoBehaviour
{
	public enum AlignMode
	{
		Off = 0,
		OnEnable = 1,
		OnUpdate = 2,
		OnLateUpdate = 3,
	}

	public bool autosizeWidget; //Field offset: 0xC
	public float autosizeWidgetMargin; //Field offset: 0x10
	public float autosizeWidgetMinWidth; //Field offset: 0x14
	public UIWidget targetWidget; //Field offset: 0x18
	public bool adjustWidgetPosition; //Field offset: 0x1C
	public AlignMode mode; //Field offset: 0x20
	public int padding; //Field offset: 0x24
	private bool _alignNow; //Field offset: 0x28
	protected bool _snapToLabelContent; //Field offset: 0x29
	protected UIPanel _panel; //Field offset: 0x2C
	protected float _calculatedHeight; //Field offset: 0x30
	protected float _calculatedWidth; //Field offset: 0x34

	public float calculatedHeight
	{
		 get { } //Length: 6
	}

	public float calculateWidth
	{
		 get { } //Length: 6
	}

	public Layout() { }

	public void Align(bool once = false) { }

	protected virtual void Align_Internal() { }

	public float get_calculatedHeight() { }

	public float get_calculateWidth() { }

	private void LateUpdate() { }

	private void OnEnable() { }

	public void SetToAlignModeForSpecfiedDuration(AlignMode alignMode, float duration) { }

	private void Start() { }

	private void TurnOff() { }

	private void Update() { }

}

