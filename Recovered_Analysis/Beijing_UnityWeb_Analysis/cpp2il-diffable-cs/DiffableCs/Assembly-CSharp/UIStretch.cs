//Type is in global namespace

public class UIStretch : MonoBehaviour
{
	public enum Style
	{
		None = 0,
		Horizontal = 1,
		Vertical = 2,
		Both = 3,
		BasedOnHeight = 4,
		FillKeepingRatio = 5,
		FitInternalKeepingRatio = 6,
	}

	public Camera uiCamera; //Field offset: 0xC
	public GameObject container; //Field offset: 0x10
	public Style style; //Field offset: 0x14
	public bool runOnlyOnce; //Field offset: 0x18
	public Vector2 relativeSize; //Field offset: 0x1C
	public Vector2 initialSize; //Field offset: 0x24
	public Vector2 borderPadding; //Field offset: 0x2C
	private UIWidget widgetContainer; //Field offset: 0x34
	private Transform mTrans; //Field offset: 0x38
	private UIWidget mWidget; //Field offset: 0x3C
	private UISprite mSprite; //Field offset: 0x40
	private UIPanel mPanel; //Field offset: 0x44
	private UIRoot mRoot; //Field offset: 0x48
	private Animation mAnim; //Field offset: 0x4C
	private Rect mRect; //Field offset: 0x50
	private bool mStarted; //Field offset: 0x60

	public UIStretch() { }

	private void Awake() { }

	private void OnDestroy() { }

	private void ScreenSizeChanged() { }

	private void Start() { }

	private void Update() { }

}

