//Type is in global namespace

public class UICamera : MonoBehaviour
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static CompareFunc<DepthEntry> <>9__190_0; //Field offset: 0x4
		public static CompareFunc<DepthEntry> <>9__190_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <.cctor>b__227_0(KeyCode key) { }

		internal bool <.cctor>b__227_1(KeyCode key) { }

		internal bool <.cctor>b__227_2(KeyCode key) { }

		internal float <.cctor>b__227_3(string axis) { }

		internal MouseOrTouch <.cctor>b__227_4(int button) { }

		internal MouseOrTouch <.cctor>b__227_5(int id, bool createIfMissing) { }

		internal void <.cctor>b__227_6(int id) { }

		internal int <Raycast>b__190_0(DepthEntry r1, DepthEntry r2) { }

		internal int <Raycast>b__190_1(DepthEntry r1, DepthEntry r2) { }

	}

	public delegate BoolDelegate
	{

		public BoolDelegate(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(GameObject go, bool state, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(GameObject go, bool state) { }

	}

	public enum ClickNotification
	{
		None = 0,
		Always = 1,
		BasedOnDelta = 2,
	}

	public enum ControlScheme
	{
		Mouse = 0,
		Touch = 1,
		Controller = 2,
	}

	private struct DepthEntry
	{
		public int depth; //Field offset: 0x0
		public RaycastHit hit; //Field offset: 0x4
		public Vector3 point; //Field offset: 0x30
		public GameObject go; //Field offset: 0x3C

	}

	public enum EventType
	{
		World_3D = 0,
		UI_3D = 1,
		World_2D = 2,
		UI_2D = 3,
	}

	public delegate FloatDelegate
	{

		public FloatDelegate(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(GameObject go, float delta, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(GameObject go, float delta) { }

	}

	public delegate GetAnyKeyFunc
	{

		public GetAnyKeyFunc(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public virtual bool EndInvoke(IAsyncResult result) { }

		public virtual bool Invoke() { }

	}

	public delegate GetAxisFunc
	{

		public GetAxisFunc(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(string name, AsyncCallback callback, object object) { }

		public virtual float EndInvoke(IAsyncResult result) { }

		public virtual float Invoke(string name) { }

	}

	public delegate GetKeyStateFunc
	{

		public GetKeyStateFunc(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(KeyCode key, AsyncCallback callback, object object) { }

		public virtual bool EndInvoke(IAsyncResult result) { }

		public virtual bool Invoke(KeyCode key) { }

	}

	public delegate GetMouseDelegate
	{

		public GetMouseDelegate(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(int button, AsyncCallback callback, object object) { }

		public virtual MouseOrTouch EndInvoke(IAsyncResult result) { }

		public virtual MouseOrTouch Invoke(int button) { }

	}

	public delegate GetTouchCallback
	{

		public GetTouchCallback(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(int index, AsyncCallback callback, object object) { }

		public virtual Touch EndInvoke(IAsyncResult result) { }

		public virtual Touch Invoke(int index) { }

	}

	public delegate GetTouchCountCallback
	{

		public GetTouchCountCallback(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public virtual int EndInvoke(IAsyncResult result) { }

		public virtual int Invoke() { }

	}

	public delegate GetTouchDelegate
	{

		public GetTouchDelegate(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(int id, bool createIfMissing, AsyncCallback callback, object object) { }

		public virtual MouseOrTouch EndInvoke(IAsyncResult result) { }

		public virtual MouseOrTouch Invoke(int id, bool createIfMissing) { }

	}

	public delegate KeyCodeDelegate
	{

		public KeyCodeDelegate(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(GameObject go, KeyCode key, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(GameObject go, KeyCode key) { }

	}

	public class MouseOrTouch
	{
		public KeyCode key; //Field offset: 0x8
		public Vector2 pos; //Field offset: 0xC
		public Vector2 lastPos; //Field offset: 0x14
		public Vector2 delta; //Field offset: 0x1C
		public Vector2 totalDelta; //Field offset: 0x24
		public Camera pressedCam; //Field offset: 0x2C
		public GameObject last; //Field offset: 0x30
		public GameObject current; //Field offset: 0x34
		public GameObject pressed; //Field offset: 0x38
		public GameObject dragged; //Field offset: 0x3C
		public float pressTime; //Field offset: 0x40
		public float clickTime; //Field offset: 0x44
		public ClickNotification clickNotification; //Field offset: 0x48
		public bool touchBegan; //Field offset: 0x4C
		public bool pressStarted; //Field offset: 0x4D
		public bool dragStarted; //Field offset: 0x4E
		public int ignoreDelta; //Field offset: 0x50

		public float deltaTime
		{
			 get { } //Length: 6
		}

		public bool isOverUI
		{
			 get { } //Length: 63
		}

		public MouseOrTouch() { }

		public float get_deltaTime() { }

		public bool get_isOverUI() { }

	}

	public delegate MoveDelegate
	{

		public MoveDelegate(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(Vector2 delta, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(Vector2 delta) { }

	}

	public delegate ObjectDelegate
	{

		public ObjectDelegate(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(GameObject go, GameObject obj, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(GameObject go, GameObject obj) { }

	}

	public delegate OnCustomInput
	{

		public OnCustomInput(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke() { }

	}

	public delegate OnSchemeChange
	{

		public OnSchemeChange(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke() { }

	}

	public delegate OnScreenResize
	{

		public OnScreenResize(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke() { }

	}

	public enum ProcessEventsIn
	{
		Update = 0,
		LateUpdate = 1,
	}

	public delegate RemoveTouchDelegate
	{

		public RemoveTouchDelegate(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(int id, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(int id) { }

	}

	public class Touch
	{
		public int fingerId; //Field offset: 0x8
		public TouchPhase phase; //Field offset: 0xC
		public Vector2 position; //Field offset: 0x10
		public int tapCount; //Field offset: 0x18

		public Touch() { }

	}

	public delegate VectorDelegate
	{

		public VectorDelegate(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(GameObject go, Vector2 delta, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(GameObject go, Vector2 delta) { }

	}

	public delegate VoidDelegate
	{

		public VoidDelegate(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(GameObject go, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(GameObject go) { }

	}

	public static BetterList<UICamera> list; //Field offset: 0x0
	public static GetKeyStateFunc GetKeyDown; //Field offset: 0x4
	public static GetKeyStateFunc GetKeyUp; //Field offset: 0x8
	public static GetKeyStateFunc GetKey; //Field offset: 0xC
	public static GetAxisFunc GetAxis; //Field offset: 0x10
	public static GetAnyKeyFunc GetAnyKeyDown; //Field offset: 0x14
	public static GetMouseDelegate GetMouse; //Field offset: 0x18
	public static GetTouchDelegate GetTouch; //Field offset: 0x1C
	public static RemoveTouchDelegate RemoveTouch; //Field offset: 0x20
	public static OnScreenResize onScreenResize; //Field offset: 0x24
	public static OnCustomInput onCustomInput; //Field offset: 0x28
	public static bool showTooltips; //Field offset: 0x2C
	public static bool ignoreAllEvents; //Field offset: 0x2D
	public static bool ignoreControllerInput; //Field offset: 0x2E
	private static bool mDisableController; //Field offset: 0x2F
	private static Vector2 mLastPos; //Field offset: 0x30
	public static Vector3 lastWorldPosition; //Field offset: 0x38
	public static Ray lastWorldRay; //Field offset: 0x44
	public static RaycastHit lastHit; //Field offset: 0x5C
	public static UICamera current; //Field offset: 0x88
	public static Camera currentCamera; //Field offset: 0x8C
	public static OnSchemeChange onSchemeChange; //Field offset: 0x90
	private static ControlScheme mLastScheme; //Field offset: 0x94
	public static int currentTouchID; //Field offset: 0x98
	private static KeyCode mCurrentKey; //Field offset: 0x9C
	public static MouseOrTouch currentTouch; //Field offset: 0xA0
	private static bool mInputFocus; //Field offset: 0xA4
	private static GameObject mGenericHandler; //Field offset: 0xA8
	public static GameObject fallThrough; //Field offset: 0xAC
	public static VoidDelegate onClick; //Field offset: 0xB0
	public static VoidDelegate onDoubleClick; //Field offset: 0xB4
	public static BoolDelegate onHover; //Field offset: 0xB8
	public static BoolDelegate onPress; //Field offset: 0xBC
	public static BoolDelegate onSelect; //Field offset: 0xC0
	public static FloatDelegate onScroll; //Field offset: 0xC4
	public static VectorDelegate onDrag; //Field offset: 0xC8
	public static VoidDelegate onDragStart; //Field offset: 0xCC
	public static ObjectDelegate onDragOver; //Field offset: 0xD0
	public static ObjectDelegate onDragOut; //Field offset: 0xD4
	public static VoidDelegate onDragEnd; //Field offset: 0xD8
	public static ObjectDelegate onDrop; //Field offset: 0xDC
	public static KeyCodeDelegate onKey; //Field offset: 0xE0
	public static KeyCodeDelegate onNavigate; //Field offset: 0xE4
	public static VectorDelegate onPan; //Field offset: 0xE8
	public static BoolDelegate onTooltip; //Field offset: 0xEC
	public static MoveDelegate onMouseMove; //Field offset: 0xF0
	private static MouseOrTouch[] mMouse; //Field offset: 0xF4
	public static MouseOrTouch controller; //Field offset: 0xF8
	public static List<MouseOrTouch> activeTouches; //Field offset: 0xFC
	private static List<int> mTouchIDs; //Field offset: 0x100
	private static int mWidth; //Field offset: 0x104
	private static int mHeight; //Field offset: 0x108
	private static GameObject mTooltip; //Field offset: 0x10C
	private static float mTooltipTime; //Field offset: 0x110
	public static bool isDragging; //Field offset: 0x114
	private static int mLastInteractionCheck; //Field offset: 0x118
	private static bool mLastInteractionResult; //Field offset: 0x11C
	private static int mLastFocusCheck; //Field offset: 0x120
	private static bool mLastFocusResult; //Field offset: 0x124
	private static int mLastOverCheck; //Field offset: 0x128
	private static bool mLastOverResult; //Field offset: 0x12C
	private static GameObject mRayHitObject; //Field offset: 0x130
	private static GameObject mHover; //Field offset: 0x134
	private static GameObject mSelected; //Field offset: 0x138
	private static DepthEntry mHit; //Field offset: 0x13C
	private static BetterList<DepthEntry> mHits; //Field offset: 0x17C
	private static RaycastHit[] mRayHits; //Field offset: 0x180
	private static Collider2D[] mOverlap; //Field offset: 0x184
	private static Plane m2DPlane; //Field offset: 0x188
	private static float mNextEvent; //Field offset: 0x198
	private static int mNotifying; //Field offset: 0x19C
	private static bool mUsingTouchEvents; //Field offset: 0x1A0
	public static GetTouchCountCallback GetInputTouchCount; //Field offset: 0x1A4
	public static GetTouchCallback GetInputTouch; //Field offset: 0x1A8
	public EventType eventType; //Field offset: 0xC
	public bool eventsGoToColliders; //Field offset: 0x10
	public LayerMask eventReceiverMask; //Field offset: 0x14
	public ProcessEventsIn processEventsIn; //Field offset: 0x18
	public bool debug; //Field offset: 0x1C
	public bool useMouse; //Field offset: 0x1D
	public bool useTouch; //Field offset: 0x1E
	public bool allowMultiTouch; //Field offset: 0x1F
	public bool useKeyboard; //Field offset: 0x20
	public bool useController; //Field offset: 0x21
	public bool stickyTooltip; //Field offset: 0x22
	public float tooltipDelay; //Field offset: 0x24
	public bool longPressTooltip; //Field offset: 0x28
	public float mouseDragThreshold; //Field offset: 0x2C
	public float mouseClickThreshold; //Field offset: 0x30
	public float touchDragThreshold; //Field offset: 0x34
	public float touchClickThreshold; //Field offset: 0x38
	public float rangeDistance; //Field offset: 0x3C
	public string horizontalAxisName; //Field offset: 0x40
	public string verticalAxisName; //Field offset: 0x44
	public string horizontalPanAxisName; //Field offset: 0x48
	public string verticalPanAxisName; //Field offset: 0x4C
	public string scrollAxisName; //Field offset: 0x50
	public bool commandClick; //Field offset: 0x54
	public KeyCode submitKey0; //Field offset: 0x58
	public KeyCode submitKey1; //Field offset: 0x5C
	public KeyCode cancelKey0; //Field offset: 0x60
	public KeyCode cancelKey1; //Field offset: 0x64
	public bool autoHideCursor; //Field offset: 0x68
	private Camera mCam; //Field offset: 0x6C
	private float mNextRaycast; //Field offset: 0x70

	public Camera cachedCamera
	{
		 get { } //Length: 121
	}

	public static GameObject controllerNavigationObject
	{
		 get { } //Length: 549
		 set { } //Length: 2330
	}

	public static KeyCode currentKey
	{
		 get { } //Length: 619
		 set { } //Length: 355
	}

	public static Ray currentRay
	{
		 get { } //Length: 654
	}

	public static ControlScheme currentScheme
	{
		 get { } //Length: 230
		 set { } //Length: 138
	}

	public static bool disableController
	{
		 get { } //Length: 89
		 set { } //Length: 196
	}

	public static int dragCount
	{
		 get { } //Length: 566
	}

	public static UICamera eventHandler
	{
		 get { } //Length: 139
	}

	public static UICamera first
	{
		 get { } //Length: 140
	}

	public static GameObject genericEventHandler
	{
		 get { } //Length: 269
		 set { } //Length: 485
	}

	private bool handlesEvents
	{
		 get { } //Length: 3
	}

	public static GameObject hoveredObject
	{
		 get { } //Length: 795
		 set { } //Length: 80
	}

	public static bool inputHasFocus
	{
		 get { } //Length: 90
	}

	public static bool interactingWithUI
	{
		 get { } //Length: 992
	}

	public static bool isOverUI
	{
		 get { } //Length: 90
	}

	public static Vector2 lastEventPosition
	{
		 get { } //Length: 138
		 set { } //Length: 512
	}

	public static Vector2 lastTouchPosition
	{
		 get { } //Length: 94
		 set { } //Length: 94
	}

	public static Camera mainCamera
	{
		 get { } //Length: 566
	}

	public static MouseOrTouch mouse0
	{
		 get { } //Length: 90
	}

	public static MouseOrTouch mouse1
	{
		 get { } //Length: 96
	}

	public static MouseOrTouch mouse2
	{
		 get { } //Length: 96
	}

	public static GameObject selectedObject
	{
		 get { } //Length: 1446
		 set { } //Length: 561
	}

	public bool stickyPress
	{
		 get { } //Length: 1003
	}

	public static GameObject tooltipObject
	{
		 get { } //Length: 96
		 set { } //Length: 95
	}

	public static int touchCount
	{
		 get { } //Length: 328
	}

	public static bool uiHasFocus
	{
		 get { } //Length: 1090
	}

	private static UICamera() { }

	public UICamera() { }

	private void Awake() { }

	public static void CancelNextTooltip() { }

	private static int CompareFunc(UICamera a, UICamera b) { }

	public static int CountInputSources() { }

	public static UICamera FindCameraForLayer(int layer) { }

	private static Rigidbody FindRootRigidbody(Transform trans) { }

	private static Rigidbody2D FindRootRigidbody2D(Transform trans) { }

	public Camera get_cachedCamera() { }

	public static GameObject get_controllerNavigationObject() { }

	public static KeyCode get_currentKey() { }

	public static Ray get_currentRay() { }

	public static ControlScheme get_currentScheme() { }

	public static bool get_disableController() { }

	public static int get_dragCount() { }

	public static UICamera get_eventHandler() { }

	public static UICamera get_first() { }

	public static GameObject get_genericEventHandler() { }

	private bool get_handlesEvents() { }

	public static GameObject get_hoveredObject() { }

	public static bool get_inputHasFocus() { }

	public static bool get_interactingWithUI() { }

	public static bool get_isOverUI() { }

	public static Vector2 get_lastEventPosition() { }

	public static Vector2 get_lastTouchPosition() { }

	public static Camera get_mainCamera() { }

	public static MouseOrTouch get_mouse0() { }

	public static MouseOrTouch get_mouse1() { }

	public static MouseOrTouch get_mouse2() { }

	public static GameObject get_selectedObject() { }

	public bool get_stickyPress() { }

	public static GameObject get_tooltipObject() { }

	public static int get_touchCount() { }

	public static bool get_uiHasFocus() { }

	private static int GetDirection(KeyCode up, KeyCode down) { }

	private static int GetDirection(string axis) { }

	private static int GetDirection(KeyCode up0, KeyCode up1, KeyCode down0, KeyCode down1) { }

	private bool HasCollider(GameObject go) { }

	public static bool HideTooltip() { }

	public static bool IsHighlighted(GameObject go) { }

	public static bool IsPartOfUI(GameObject go) { }

	public static bool IsPressed(GameObject go) { }

	private static bool IsVisible(Vector3 worldPoint, GameObject go) { }

	private static bool IsVisible(ref DepthEntry de) { }

	private void LateUpdate() { }

	public static void Notify(GameObject go, string funcName, object obj) { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void ProcessEvents() { }

	private void ProcessFakeTouches() { }

	public void ProcessMouse() { }

	public void ProcessOthers() { }

	private void ProcessPress(bool pressed, float click, float drag) { }

	private void ProcessRelease(bool isMouse, float drag) { }

	public void ProcessTouch(bool pressed, bool released) { }

	public void ProcessTouches() { }

	public static void Raycast(MouseOrTouch touch) { }

	public static bool Raycast(Vector3 inPos) { }

	public static void set_controllerNavigationObject(GameObject value) { }

	public static void set_currentKey(KeyCode value) { }

	public static void set_currentScheme(ControlScheme value) { }

	public static void set_disableController(bool value) { }

	public static void set_genericEventHandler(GameObject value) { }

	public static void set_hoveredObject(GameObject value) { }

	public static void set_lastEventPosition(Vector2 value) { }

	public static void set_lastTouchPosition(Vector2 value) { }

	public static void set_selectedObject(GameObject value) { }

	public static void set_tooltipObject(GameObject value) { }

	public static bool ShowTooltip(GameObject go) { }

	private void Start() { }

	private void Update() { }

}

