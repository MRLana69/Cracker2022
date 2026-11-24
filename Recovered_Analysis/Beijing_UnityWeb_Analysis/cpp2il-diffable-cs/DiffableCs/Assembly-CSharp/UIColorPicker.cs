//Type is in global namespace

public class UIColorPicker : MonoBehaviour
{
	public static UIColorPicker current; //Field offset: 0x0
	private static AnimationCurve mRed; //Field offset: 0x4
	private static AnimationCurve mGreen; //Field offset: 0x8
	private static AnimationCurve mBlue; //Field offset: 0xC
	public Color value; //Field offset: 0xC
	public UIWidget selectionWidget; //Field offset: 0x1C
	public List<EventDelegate> onChange; //Field offset: 0x20
	private Transform mTrans; //Field offset: 0x24
	private UITexture mUITex; //Field offset: 0x28
	private Texture2D mTex; //Field offset: 0x2C
	private UICamera mCam; //Field offset: 0x30
	private Vector2 mPos; //Field offset: 0x34
	private int mWidth; //Field offset: 0x3C
	private int mHeight; //Field offset: 0x40

	public UIColorPicker() { }

	private void OnDestroy() { }

	private void OnDrag(Vector2 delta) { }

	private void OnPan(Vector2 delta) { }

	private void OnPress(bool pressed) { }

	private void Sample() { }

	public static Color Sample(float x, float y) { }

	public void Select(Vector2 v) { }

	public Vector2 Select(Color c) { }

	private void Start() { }

}

