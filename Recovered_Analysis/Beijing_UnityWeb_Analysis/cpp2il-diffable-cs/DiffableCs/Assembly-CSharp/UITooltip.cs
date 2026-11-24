//Type is in global namespace

public class UITooltip : MonoBehaviour
{
	protected static UITooltip mInstance; //Field offset: 0x0
	public Camera uiCamera; //Field offset: 0xC
	public UILabel text; //Field offset: 0x10
	public GameObject tooltipRoot; //Field offset: 0x14
	public UISprite background; //Field offset: 0x18
	public float appearSpeed; //Field offset: 0x1C
	public bool scalingTransitions; //Field offset: 0x20
	protected GameObject mTooltip; //Field offset: 0x24
	protected Transform mTrans; //Field offset: 0x28
	protected float mTarget; //Field offset: 0x2C
	protected float mCurrent; //Field offset: 0x30
	protected Vector3 mPos; //Field offset: 0x34
	protected Vector3 mSize; //Field offset: 0x40
	protected UIWidget[] mWidgets; //Field offset: 0x4C

	public static bool isVisible
	{
		 get { } //Length: 273
	}

	public UITooltip() { }

	private void Awake() { }

	public static bool get_isVisible() { }

	public static void Hide() { }

	private void OnDestroy() { }

	protected virtual void SetAlpha(float val) { }

	protected virtual void SetText(string tooltipText) { }

	public static void Show(string text) { }

	public static void ShowText(string text) { }

	protected virtual void Start() { }

	protected virtual void Update() { }

}

