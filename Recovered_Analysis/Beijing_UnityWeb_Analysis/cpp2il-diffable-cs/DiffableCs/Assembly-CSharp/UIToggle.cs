//Type is in global namespace

public class UIToggle : UIWidgetContainer
{
	public delegate Validate
	{

		public Validate(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(bool choice, AsyncCallback callback, object object) { }

		public virtual bool EndInvoke(IAsyncResult result) { }

		public virtual bool Invoke(bool choice) { }

	}

	public static BetterList<UIToggle> list; //Field offset: 0x0
	public static UIToggle current; //Field offset: 0x4
	public int group; //Field offset: 0xC
	public UIWidget activeSprite; //Field offset: 0x10
	public bool invertSpriteState; //Field offset: 0x14
	public Animation activeAnimation; //Field offset: 0x18
	public Animator animator; //Field offset: 0x1C
	public UITweener tween; //Field offset: 0x20
	public bool startsActive; //Field offset: 0x24
	public bool instantTween; //Field offset: 0x25
	public bool optionCanBeNone; //Field offset: 0x26
	public List<EventDelegate> onChange; //Field offset: 0x28
	public Validate validator; //Field offset: 0x2C
	private UISprite checkSprite; //Field offset: 0x30
	private Animation checkAnimation; //Field offset: 0x34
	private GameObject eventReceiver; //Field offset: 0x38
	private string functionName; //Field offset: 0x3C
	private bool startsChecked; //Field offset: 0x40
	private bool mIsActive; //Field offset: 0x41
	private bool mStarted; //Field offset: 0x42

	public bool isChecked
	{
		 get { } //Length: 185
		 set { } //Length: 64
	}

	public bool isColliderEnabled
	{
		 get { } //Length: 26
	}

	public bool value
	{
		 get { } //Length: 558
		 set { } //Length: 5375
	}

	private static UIToggle() { }

	public UIToggle() { }

	public bool get_isChecked() { }

	public bool get_isColliderEnabled() { }

	public bool get_value() { }

	public static UIToggle GetActiveToggle(int group) { }

	private void OnClick() { }

	private void OnDisable() { }

	private void OnEnable() { }

	public void Set(bool state, bool notify = true) { }

	public void set_isChecked(bool value) { }

	public void set_value(bool value) { }

	public void Start() { }

}

