//Type is in global namespace

public class UIPopupList : UIWidgetContainer
{
	private sealed class <CloseIfUnselected>d__111 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public UIPopupList <>4__this; //Field offset: 0x10

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 485
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <CloseIfUnselected>d__111(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <UpdateTweenPosition>d__94 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public UIPopupList <>4__this; //Field offset: 0x10
		private TweenPosition <tp>5__2; //Field offset: 0x14

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 412
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <UpdateTweenPosition>d__94(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	public delegate LegacyEvent
	{

		public LegacyEvent(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(string val, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(string val) { }

	}

	public enum OpenOn
	{
		ClickOrTap = 0,
		RightClick = 1,
		DoubleClick = 2,
		Manual = 3,
	}

	public enum Position
	{
		Auto = 0,
		Above = 1,
		Below = 2,
	}

	public enum Selection
	{
		OnPress = 0,
		OnClick = 1,
	}

	public static UIPopupList current; //Field offset: 0x0
	private const float animSpeed = 0.15; //Field offset: 0x0
	protected static GameObject mChild; //Field offset: 0x4
	protected static float mFadeOutComplete; //Field offset: 0x8
	public UIAtlas atlas; //Field offset: 0xC
	public UIFont bitmapFont; //Field offset: 0x10
	public Font trueTypeFont; //Field offset: 0x14
	public int fontSize; //Field offset: 0x18
	public FontStyle fontStyle; //Field offset: 0x1C
	public string backgroundSprite; //Field offset: 0x20
	public string highlightSprite; //Field offset: 0x24
	public Sprite background2DSprite; //Field offset: 0x28
	public Sprite highlight2DSprite; //Field offset: 0x2C
	public Position position; //Field offset: 0x30
	public Selection selection; //Field offset: 0x34
	public Alignment alignment; //Field offset: 0x38
	public List<string> items; //Field offset: 0x3C
	public List<object> itemData; //Field offset: 0x40
	public List<Action> itemCallbacks; //Field offset: 0x44
	public Vector2 padding; //Field offset: 0x48
	public Color textColor; //Field offset: 0x50
	public Color backgroundColor; //Field offset: 0x60
	public Color highlightColor; //Field offset: 0x70
	public bool isAnimated; //Field offset: 0x80
	public bool isLocalized; //Field offset: 0x81
	public Modifier textModifier; //Field offset: 0x84
	public bool separatePanel; //Field offset: 0x88
	public int overlap; //Field offset: 0x8C
	public OpenOn openOn; //Field offset: 0x90
	public List<EventDelegate> onChange; //Field offset: 0x94
	protected string mSelectedItem; //Field offset: 0x98
	protected UIPanel mPanel; //Field offset: 0x9C
	protected UIBasicSprite mBackground; //Field offset: 0xA0
	protected UIBasicSprite mHighlight; //Field offset: 0xA4
	protected UILabel mHighlightedLabel; //Field offset: 0xA8
	protected List<UILabel> mLabelList; //Field offset: 0xAC
	protected float mBgBorder; //Field offset: 0xB0
	public bool keepValue; //Field offset: 0xB4
	protected GameObject mSelection; //Field offset: 0xB8
	protected int mOpenFrame; //Field offset: 0xBC
	private GameObject eventReceiver; //Field offset: 0xC0
	private string functionName; //Field offset: 0xC4
	private float textScale; //Field offset: 0xC8
	private UIFont font; //Field offset: 0xCC
	private UILabel textLabel; //Field offset: 0xD0
	public Vector3 startingPosition; //Field offset: 0xD4
	private LegacyEvent mLegacyEvent; //Field offset: 0xE0
	protected bool mExecuting; //Field offset: 0xE4
	protected bool mUseDynamicFont; //Field offset: 0xE5
	protected bool mStarted; //Field offset: 0xE6
	protected bool mTweening; //Field offset: 0xE7
	public GameObject source; //Field offset: 0xE8

	protected float activeFontScale
	{
		 get { } //Length: 6
	}

	protected int activeFontSize
	{
		 get { } //Length: 139
	}

	public Object ambigiousFont
	{
		 get { } //Length: 125
		 set { } //Length: 856
	}

	public Action callback
	{
		 get { } //Length: 157
	}

	public virtual object data
	{
		 get { } //Length: 7
	}

	protected float fitScale
	{
		 get { } //Length: 170
	}

	public bool isColliderEnabled
	{
		 get { } //Length: 151
	}

	public static bool isOpen
	{
		 get { } //Length: 145
	}

	protected bool isValid
	{
		 get { } //Length: 185
	}

	public LegacyEvent onSelectionChange
	{
		 get { } //Length: 157
		 set { } //Length: 196
	}

	public virtual string value
	{
		 get { } //Length: 7
		 set { } //Length: 12
	}

	private static UIPopupList() { }

	public UIPopupList() { }

	public virtual void AddItem(string text, object data, Action del = null) { }

	public virtual void AddItem(string text, Action del) { }

	public virtual void AddItem(string text) { }

	protected void Animate(UIWidget widget, bool placeAbove, float bottom) { }

	protected virtual void AnimateColor(UIWidget widget) { }

	protected virtual void AnimatePosition(UIWidget widget, bool placeAbove, float bottom) { }

	protected virtual void AnimateScale(UIWidget widget, bool placeAbove, float bottom) { }

	public virtual void Clear() { }

	public static void Close() { }

	private IEnumerator CloseIfUnselected() { }

	public virtual void CloseSelf() { }

	protected float get_activeFontScale() { }

	protected int get_activeFontSize() { }

	public Object get_ambigiousFont() { }

	public Action get_callback() { }

	public virtual object get_data() { }

	protected float get_fitScale() { }

	public bool get_isColliderEnabled() { }

	public static bool get_isOpen() { }

	protected bool get_isValid() { }

	public LegacyEvent get_onSelectionChange() { }

	public virtual string get_value() { }

	protected virtual Vector3 GetHighlightPosition() { }

	protected virtual void Highlight(UILabel lbl, bool instant) { }

	protected virtual void OnClick() { }

	protected virtual void OnDisable() { }

	protected virtual void OnDoubleClick() { }

	protected virtual void OnEnable() { }

	protected virtual void OnItemClick(GameObject go) { }

	protected virtual void OnItemHover(GameObject go, bool isOver) { }

	protected virtual void OnItemPress(GameObject go, bool isPressed) { }

	protected virtual void OnKey(KeyCode key) { }

	protected virtual void OnLocalize() { }

	protected virtual void OnNavigate(KeyCode key) { }

	protected virtual void OnSelect(bool isSelected) { }

	protected virtual void OnValidate() { }

	public virtual void RemoveItem(string text) { }

	public virtual void RemoveItemByData(object data) { }

	private void Select(UILabel lbl, bool instant) { }

	public void Set(string value, bool notify = true) { }

	public void set_ambigiousFont(Object value) { }

	public void set_onSelectionChange(LegacyEvent value) { }

	public virtual void set_value(string value) { }

	public virtual void Show() { }

	public virtual void Start() { }

	protected void TriggerCallbacks() { }

	protected virtual IEnumerator UpdateTweenPosition() { }

}

