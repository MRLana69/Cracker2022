//Type is in global namespace

public class UIInput : MonoBehaviour
{
	public enum InputType
	{
		Standard = 0,
		AutoCorrect = 1,
		Password = 2,
	}

	public enum KeyboardType
	{
		Default = 0,
		ASCIICapable = 1,
		NumbersAndPunctuation = 2,
		URL = 3,
		NumberPad = 4,
		PhonePad = 5,
		NamePhonePad = 6,
		EmailAddress = 7,
	}

	public enum OnReturnKey
	{
		Default = 0,
		Submit = 1,
		NewLine = 2,
	}

	public delegate OnValidate
	{

		public OnValidate(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(string text, int charIndex, char addedChar, AsyncCallback callback, object object) { }

		public virtual char EndInvoke(IAsyncResult result) { }

		public virtual char Invoke(string text, int charIndex, char addedChar) { }

	}

	public enum Validation
	{
		None = 0,
		Integer = 1,
		Float = 2,
		Alphanumeric = 3,
		Username = 4,
		Name = 5,
		Filename = 6,
	}

	public static UIInput current; //Field offset: 0x0
	public static UIInput selection; //Field offset: 0x4
	protected static int mDrawStart; //Field offset: 0x8
	protected static string mLastIME; //Field offset: 0xC
	private static int mIgnoreKey; //Field offset: 0x10
	public UILabel label; //Field offset: 0xC
	public InputType inputType; //Field offset: 0x10
	public OnReturnKey onReturnKey; //Field offset: 0x14
	public KeyboardType keyboardType; //Field offset: 0x18
	public bool hideInput; //Field offset: 0x1C
	public bool selectAllTextOnFocus; //Field offset: 0x1D
	public bool submitOnUnselect; //Field offset: 0x1E
	public Validation validation; //Field offset: 0x20
	public int characterLimit; //Field offset: 0x24
	public string savedAs; //Field offset: 0x28
	private GameObject selectOnTab; //Field offset: 0x2C
	public Color activeTextColor; //Field offset: 0x30
	public Color caretColor; //Field offset: 0x40
	public Color selectionColor; //Field offset: 0x50
	public List<EventDelegate> onSubmit; //Field offset: 0x60
	public List<EventDelegate> onChange; //Field offset: 0x64
	public OnValidate onValidate; //Field offset: 0x68
	protected string mValue; //Field offset: 0x6C
	protected string mDefaultText; //Field offset: 0x70
	protected Color mDefaultColor; //Field offset: 0x74
	protected float mPosition; //Field offset: 0x84
	protected bool mDoInit; //Field offset: 0x88
	protected Alignment mAlignment; //Field offset: 0x8C
	protected bool mLoadSavedValue; //Field offset: 0x90
	protected int mSelectionStart; //Field offset: 0x94
	protected int mSelectionEnd; //Field offset: 0x98
	protected UITexture mHighlight; //Field offset: 0x9C
	protected UITexture mCaret; //Field offset: 0xA0
	protected Texture2D mBlankTex; //Field offset: 0xA4
	protected float mNextBlink; //Field offset: 0xA8
	protected float mLastAlpha; //Field offset: 0xAC
	protected string mCached; //Field offset: 0xB0
	protected int mSelectMe; //Field offset: 0xB4
	protected int mSelectTime; //Field offset: 0xB8
	protected bool mStarted; //Field offset: 0xBC
	private UIInputOnGUI mOnGUI; //Field offset: 0xC0
	private UICamera mCam; //Field offset: 0xC4
	private bool mEllipsis; //Field offset: 0xC8
	public Action onUpArrow; //Field offset: 0xCC
	public Action onDownArrow; //Field offset: 0xD0

	public UITexture caret
	{
		 get { } //Length: 30
	}

	public int cursorPosition
	{
		 get { } //Length: 133
		 set { } //Length: 146
	}

	public Color defaultColor
	{
		 get { } //Length: 37
		 set { } //Length: 44
	}

	public string defaultText
	{
		 get { } //Length: 132
		 set { } //Length: 83
	}

	public bool inputShouldBeHidden
	{
		 get { } //Length: 23
	}

	public bool isSelected
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public bool selected
	{
		 get { } //Length: 23
		 set { } //Length: 13
	}

	public int selectionEnd
	{
		 get { } //Length: 30
		 set { } //Length: 28
	}

	public int selectionStart
	{
		 get { } //Length: 30
		 set { } //Length: 28
	}

	public string text
	{
		 get { } //Length: 127
		 set { } //Length: 107
	}

	public string value
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	private static UIInput() { }

	public UIInput() { }

	protected virtual void Cleanup() { }

	protected void DoBackspace() { }

	protected void ExecuteOnChange() { }

	public UITexture get_caret() { }

	public int get_cursorPosition() { }

	public Color get_defaultColor() { }

	public string get_defaultText() { }

	public bool get_inputShouldBeHidden() { }

	public bool get_isSelected() { }

	public bool get_selected() { }

	public int get_selectionEnd() { }

	public int get_selectionStart() { }

	public string get_text() { }

	public string get_value() { }

	protected int GetCharUnderMouse() { }

	protected string GetLeftText() { }

	protected string GetRightText() { }

	protected string GetSelection() { }

	protected void Init() { }

	protected virtual void Insert(string text) { }

	public void LoadValue() { }

	protected void OnDeselectEvent() { }

	private void OnDisable() { }

	protected virtual void OnDrag(Vector2 delta) { }

	private void OnKey(KeyCode key) { }

	protected virtual void OnPress(bool isPressed) { }

	protected virtual void OnSelect(bool isSelected) { }

	protected void OnSelectEvent() { }

	public virtual bool ProcessEvent(Event ev) { }

	public void RemoveFocus() { }

	protected void SaveToPlayerPrefs(string val) { }

	public void SaveValue() { }

	public void Set(string value, bool notify = true) { }

	public void set_cursorPosition(int value) { }

	public void set_defaultColor(Color value) { }

	public void set_defaultText(string value) { }

	public void set_isSelected(bool value) { }

	public void set_selected(bool value) { }

	public void set_selectionEnd(int value) { }

	public void set_selectionStart(int value) { }

	public void set_text(string value) { }

	public void set_value(string value) { }

	public void Start() { }

	public void Submit() { }

	protected virtual void Update() { }

	public void UpdateLabel() { }

	public string Validate(string val) { }

	protected char Validate(string text, int pos, char ch) { }

}

