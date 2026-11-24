//Type is in global namespace

public class UIDrawCall : MonoBehaviour
{
	public enum Clipping
	{
		None = 0,
		TextureMask = 1,
		SoftClip = 3,
		ConstrainButDontClip = 4,
	}

	public delegate OnCreateDrawCall
	{

		public OnCreateDrawCall(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(UIDrawCall dc, MeshFilter filter, MeshRenderer ren, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(UIDrawCall dc, MeshFilter filter, MeshRenderer ren) { }

	}

	public delegate OnRenderCallback
	{

		public OnRenderCallback(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(Material mat, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(Material mat) { }

	}

	public enum ShadowMode
	{
		None = 0,
		Receive = 1,
		CastAndReceive = 2,
	}

	private static BetterList<UIDrawCall> mActiveList; //Field offset: 0x0
	private const int maxIndexBufferCache = 10; //Field offset: 0x0
	private static BetterList<UIDrawCall> mInactiveList; //Field offset: 0x4
	private static ColorSpace mColorSpace; //Field offset: 0x8
	private static List<int[]> mCache; //Field offset: 0xC
	private static int[] ClipRange; //Field offset: 0x10
	private static int[] ClipArgs; //Field offset: 0x14
	private static int dx9BugWorkaround; //Field offset: 0x18
	public int widgetCount; //Field offset: 0xC
	public int depthStart; //Field offset: 0x10
	public int depthEnd; //Field offset: 0x14
	public UIPanel manager; //Field offset: 0x18
	public UIPanel panel; //Field offset: 0x1C
	public Texture2D clipTexture; //Field offset: 0x20
	public bool alwaysOnScreen; //Field offset: 0x24
	public List<Vector3> verts; //Field offset: 0x28
	public List<Vector3> norms; //Field offset: 0x2C
	public List<Vector4> tans; //Field offset: 0x30
	public List<Vector2> uvs; //Field offset: 0x34
	public List<Vector4> uv2; //Field offset: 0x38
	public List<Color> cols; //Field offset: 0x3C
	private Material mMaterial; //Field offset: 0x40
	private Texture mTexture; //Field offset: 0x44
	private Shader mShader; //Field offset: 0x48
	private int mClipCount; //Field offset: 0x4C
	private Transform mTrans; //Field offset: 0x50
	private Mesh mMesh; //Field offset: 0x54
	private MeshFilter mFilter; //Field offset: 0x58
	private MeshRenderer mRenderer; //Field offset: 0x5C
	private Material mDynamicMat; //Field offset: 0x60
	private int[] mIndices; //Field offset: 0x64
	private ShadowMode mShadowMode; //Field offset: 0x68
	private bool mRebuildMat; //Field offset: 0x6C
	private bool mLegacyShader; //Field offset: 0x6D
	private int mRenderQueue; //Field offset: 0x70
	private int mTriangles; //Field offset: 0x74
	public bool isDirty; //Field offset: 0x78
	private bool mTextureClip; //Field offset: 0x79
	private bool mIsNew; //Field offset: 0x7A
	public OnRenderCallback onRender; //Field offset: 0x7C
	public OnCreateDrawCall onCreateDrawCall; //Field offset: 0x80
	private string mSortingLayerName; //Field offset: 0x84
	private int mSortingOrder; //Field offset: 0x88
	protected MaterialPropertyBlock mBlock; //Field offset: 0x8C

	public static BetterList<UIDrawCall> activeList
	{
		 get { } //Length: 89
	}

	public Material baseMaterial
	{
		 get { } //Length: 109
		 set { } //Length: 128
	}

	public Transform cachedTransform
	{
		 get { } //Length: 104
	}

	public Material dynamicMaterial
	{
		 get { } //Length: 9
	}

	public int finalRenderQueue
	{
		 get { } //Length: 149
	}

	public static BetterList<UIDrawCall> inactiveList
	{
		 get { } //Length: 89
	}

	public bool isClipped
	{
		 get { } //Length: 95
	}

	public static BetterList<UIDrawCall> list
	{
		 get { } //Length: 72
	}

	public Texture mainTexture
	{
		 get { } //Length: 6
		 set { } //Length: 107
	}

	public int renderQueue
	{
		 get { } //Length: 3
		 set { } //Length: 276
	}

	public Shader shader
	{
		 get { } //Length: 6
		 set { } //Length: 123
	}

	public ShadowMode shadowMode
	{
		 get { } //Length: 6
		 set { } //Length: 105
	}

	public string sortingLayerName
	{
		 get { } //Length: 7
		 set { } //Length: 120
	}

	public int sortingOrder
	{
		 get { } //Length: 6
		 set { } //Length: 118
	}

	public int triangles
	{
		 get { } //Length: 6
	}

	private static UIDrawCall() { }

	public UIDrawCall() { }

	private void Awake() { }

	public static void ClearAll() { }

	public static int Count(UIPanel panel) { }

	private static UIDrawCall Create(string name) { }

	private static UIDrawCall Create(string name, UIPanel pan, Material mat, Texture tex, Shader shader) { }

	public static UIDrawCall Create(UIPanel panel, Material mat, Texture tex, Shader shader) { }

	private void CreateMaterial() { }

	public static void Destroy(UIDrawCall dc) { }

	private int[] GenerateCachedIndexBuffer(int vertexCount, int indexCount) { }

	public static BetterList<UIDrawCall> get_activeList() { }

	public Material get_baseMaterial() { }

	public Transform get_cachedTransform() { }

	public Material get_dynamicMaterial() { }

	public int get_finalRenderQueue() { }

	public static BetterList<UIDrawCall> get_inactiveList() { }

	public bool get_isClipped() { }

	public static BetterList<UIDrawCall> get_list() { }

	public Texture get_mainTexture() { }

	public int get_renderQueue() { }

	public Shader get_shader() { }

	public ShadowMode get_shadowMode() { }

	public string get_sortingLayerName() { }

	public int get_sortingOrder() { }

	public int get_triangles() { }

	public static void MoveToScene(Scene scene) { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void OnWillRenderObject() { }

	private Material RebuildMaterial() { }

	public static void ReleaseAll() { }

	public static void ReleaseInactive() { }

	public void set_baseMaterial(Material value) { }

	public void set_mainTexture(Texture value) { }

	public void set_renderQueue(int value) { }

	public void set_shader(Shader value) { }

	public void set_shadowMode(ShadowMode value) { }

	public void set_sortingLayerName(string value) { }

	public void set_sortingOrder(int value) { }

	private void SetClipping(int index, Vector4 cr, Vector2 soft, float angle) { }

	public void UpdateGeometry(int widgetCount) { }

	private void UpdateMaterials() { }

}

