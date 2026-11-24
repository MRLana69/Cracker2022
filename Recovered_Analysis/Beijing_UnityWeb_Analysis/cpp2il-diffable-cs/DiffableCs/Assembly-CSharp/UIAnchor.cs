//Type is in global namespace

public class UIAnchor : MonoBehaviour
{
	public enum Side
	{
		BottomLeft = 0,
		Left = 1,
		TopLeft = 2,
		Top = 3,
		TopRight = 4,
		Right = 5,
		BottomRight = 6,
		Bottom = 7,
		Center = 8,
	}

	public Camera uiCamera; //Field offset: 0xC
	public GameObject container; //Field offset: 0x10
	public Side side; //Field offset: 0x14
	public bool runOnlyOnce; //Field offset: 0x18
	public Vector2 relativeOffset; //Field offset: 0x1C
	public Vector2 pixelOffset; //Field offset: 0x24
	private UIWidget widgetContainer; //Field offset: 0x2C
	private Transform mTrans; //Field offset: 0x30
	private Animation mAnim; //Field offset: 0x34
	private Rect mRect; //Field offset: 0x38
	private UIRoot mRoot; //Field offset: 0x48
	private bool mStarted; //Field offset: 0x4C

	public UIAnchor() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void ScreenSizeChanged() { }

	private void Start() { }

	private void Update() { }

}

