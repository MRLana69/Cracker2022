//Type is in global namespace

public static class NGUITools
{
	public delegate OnInitFunc`1
	{

		public OnInitFunc`1(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(T w, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(T w) { }

	}

	private static AudioListener mListener; //Field offset: 0x0
	public static AudioSource audioSource; //Field offset: 0x4
	private static bool mLoaded; //Field offset: 0x8
	private static float mGlobalVolume; //Field offset: 0xC
	private static float mLastTimestamp; //Field offset: 0x10
	private static AudioClip mLastClip; //Field offset: 0x14
	private static Dictionary<Type, string> mTypeNames; //Field offset: 0x18
	private static Vector3[] mSides; //Field offset: 0x1C
	public static KeyCode[] keys; //Field offset: 0x20
	private static Dictionary<string, UIWidget> mWidgets; //Field offset: 0x24
	private static UIPanel mRoot; //Field offset: 0x28
	private static GameObject mGo; //Field offset: 0x2C
	private static ColorSpace mColorSpace; //Field offset: 0x30

	public static string clipboard
	{
		 get { } //Length: 10
		 set { } //Length: 123
	}

	public static bool fileAccess
	{
		 get { } //Length: 92
	}

	public static Vector2 screenSize
	{
		 get { } //Length: 181
	}

	public static float soundVolume
	{
		 get { } //Length: 126
		 set { } //Length: 6
	}

	private static NGUITools() { }

	private static void Activate(Transform t) { }

	private static void Activate(Transform t, bool compatibilityMode) { }

	public static T AddChild(GameObject parent, bool undo) { }

	public static GameObject AddChild(GameObject parent) { }

	public static GameObject AddChild(GameObject parent, bool undo, int layer) { }

	public static GameObject AddChild(GameObject parent, GameObject prefab) { }

	public static GameObject AddChild(GameObject parent, GameObject prefab, int layer) { }

	public static T AddChild(GameObject parent) { }

	public static GameObject AddChild(GameObject parent, int layer) { }

	public static GameObject AddChild(GameObject parent, bool undo) { }

	public static GameObject AddChildAsFirstSibling(GameObject parent, GameObject prefab) { }

	public static T AddMissingComponent(GameObject go) { }

	public static UISprite AddSprite(GameObject go, UIAtlas atlas, string spriteName, int depth = 2147483647) { }

	public static T AddWidget(GameObject go, int depth = 2147483647) { }

	public static void AddWidgetCollider(GameObject go, bool considerInactive) { }

	public static void AddWidgetCollider(GameObject go) { }

	public static int AdjustDepth(GameObject go, int adjustment) { }

	public static Color ApplyPMA(Color c) { }

	public static void BringForward(GameObject go) { }

	public static void Broadcast(string funcName, object param) { }

	public static void Broadcast(string funcName) { }

	public static int CalculateNextDepth(GameObject go) { }

	public static int CalculateNextDepth(GameObject go, bool ignoreChildrenWithColliders) { }

	public static int CalculateRaycastDepth(GameObject go) { }

	private static void CallCreatePanel(Transform t) { }

	public static UIPanel CreateUI(Transform trans, bool advanced3D, int layer) { }

	public static UIPanel CreateUI(bool advanced3D) { }

	public static UIPanel CreateUI(bool advanced3D, int layer) { }

	private static void Deactivate(Transform t) { }

	public static void Destroy(Object obj) { }

	public static void DestroyChildren(Transform t) { }

	public static void DestroyImmediate(Object obj) { }

	public static T Draw(string id, OnInitFunc<T> onInit = null) { }

	public static string EncodeColor(Color c) { }

	public static void Execute(GameObject go, string funcName) { }

	public static void ExecuteAll(GameObject root, string funcName) { }

	public static T[] FindActive() { }

	public static Camera FindCameraForLayer(int layer) { }

	public static T FindInParents(GameObject go) { }

	public static T FindInParents(Transform trans) { }

	public static void FitOnScreen(Camera cam, Transform t, bool considerInactive = false, bool considerChildren = true) { }

	public static void FitOnScreen(Camera cam, Transform transform, Transform content, Vector3 pos, bool considerInactive = false) { }

	public static void FitOnScreen(Camera cam, Transform transform, Transform content, Vector3 pos, out Bounds bounds, bool considerInactive = false) { }

	public static void FitOnScreen(Camera cam, Transform transform, Vector3 pos) { }

	public static Color GammaToLinearSpace(Color c) { }

	public static string get_clipboard() { }

	public static bool get_fileAccess() { }

	public static Vector2 get_screenSize() { }

	public static float get_soundVolume() { }

	public static bool GetActive(GameObject go) { }

	public static bool GetActive(Behaviour mb) { }

	public static string GetFuncName(object obj, string method) { }

	public static string GetHierarchy(GameObject obj) { }

	public static GameObject GetRoot(GameObject go) { }

	public static Vector3[] GetSides(Camera cam) { }

	public static Vector3[] GetSides(Camera cam, float depth) { }

	public static Vector3[] GetSides(Camera cam, float depth, Transform relativeTo) { }

	public static Vector3[] GetSides(Camera cam, Transform relativeTo) { }

	public static string GetTypeName() { }

	public static string GetTypeName(Object obj) { }

	public static Vector3[] GetWorldCorners(Camera cam, float depth, Transform relativeTo) { }

	public static Vector3[] GetWorldCorners(Camera cam) { }

	public static Vector3[] GetWorldCorners(Camera cam, float depth) { }

	public static Vector3[] GetWorldCorners(Camera cam, Transform relativeTo) { }

	public static void ImmediatelyCreateDrawCalls(GameObject root) { }

	public static bool IsActive(Behaviour mb) { }

	public static bool IsChild(Transform parent, Transform child) { }

	public static string KeyToCaption(KeyCode key) { }

	public static byte[] Load(string fileName) { }

	public static void MakePixelPerfect(Transform t) { }

	public static void MarkParentAsChanged(GameObject go) { }

	public static void NormalizeDepths() { }

	public static void NormalizePanelDepths() { }

	public static void NormalizeWidgetDepths(GameObject go) { }

	public static void NormalizeWidgetDepths() { }

	public static void NormalizeWidgetDepths(UIWidget[] list) { }

	public static Color ParseColor(string text, int offset) { }

	public static AudioSource PlaySound(AudioClip clip) { }

	public static AudioSource PlaySound(AudioClip clip, float volume) { }

	public static AudioSource PlaySound(AudioClip clip, float volume, float pitch) { }

	public static void PushBack(GameObject go) { }

	public static int RandomRange(int min, int max) { }

	public static void RegisterUndo(Object obj, string name) { }

	public static Vector3 Round(Vector3 v) { }

	public static bool Save(string fileName, byte[] bytes) { }

	public static void set_clipboard(string value) { }

	public static void set_soundVolume(float value) { }

	public static void SetActive(GameObject go, bool state, bool compatibilityMode) { }

	public static void SetActive(GameObject go, bool state) { }

	public static void SetActiveChildren(GameObject go, bool state) { }

	public static void SetActiveSelf(GameObject go, bool state) { }

	public static void SetChildLayer(Transform t, int layer) { }

	public static void SetDirty(Object obj, string undoName = "last change") { }

	public static void SetLayer(GameObject go, int layer) { }

	public static string StripSymbols(string text) { }

	public static void UpdateWidgetCollider(UIWidget w, BoxCollider box) { }

	public static void UpdateWidgetCollider(UIWidget w, BoxCollider2D box) { }

	public static void UpdateWidgetCollider(UIWidget w) { }

	public static void UpdateWidgetCollider(BoxCollider box, bool considerInactive) { }

	public static void UpdateWidgetCollider(GameObject go) { }

	public static void UpdateWidgetCollider(BoxCollider2D box, bool considerInactive) { }

	public static void UpdateWidgetCollider(GameObject go, bool considerInactive) { }

}

