//Type is in global namespace

public class UIWidget : UIRect
{
	public enum AspectRatioSource
	{
		Free = 0,
		BasedOnWidth = 1,
		BasedOnHeight = 2,
	}

	public delegate HitCheck
	{

		public HitCheck(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(Vector3 worldPos, AsyncCallback callback, object object) { }

		public virtual bool EndInvoke(IAsyncResult result) { }

		public virtual bool Invoke(Vector3 worldPos) { }

	}

	public delegate OnDimensionsChanged
	{

		public OnDimensionsChanged(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke() { }

	}

	public delegate OnPostFillCallback
	{

		public OnPostFillCallback(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(UIWidget widget, int bufferOffset, List<Vector3> verts, List<Vector2> uvs, List<Color> cols, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(UIWidget widget, int bufferOffset, List<Vector3> verts, List<Vector2> uvs, List<Color> cols) { }

	}

	public enum Pivot
	{
		TopLeft = 0,
		Top = 1,
		TopRight = 2,
		Left = 3,
		Center = 4,
		Right = 5,
		BottomLeft = 6,
		Bottom = 7,
		BottomRight = 8,
	}

	protected Color mColor; //Field offset: 0x50
	protected Pivot mPivot; //Field offset: 0x60
	protected int mWidth; //Field offset: 0x64
	protected int mHeight; //Field offset: 0x68
	protected int mDepth; //Field offset: 0x6C
	protected Material mMat; //Field offset: 0x70
	public OnDimensionsChanged onChange; //Field offset: 0x74
	public OnPostFillCallback onPostFill; //Field offset: 0x78
	public OnRenderCallback mOnRender; //Field offset: 0x7C
	public bool autoResizeBoxCollider; //Field offset: 0x80
	public bool hideIfOffScreen; //Field offset: 0x81
	public AspectRatioSource keepAspectRatio; //Field offset: 0x84
	public float aspectRatio; //Field offset: 0x88
	public HitCheck hitCheck; //Field offset: 0x8C
	public UIPanel panel; //Field offset: 0x90
	public UIGeometry geometry; //Field offset: 0x94
	public bool fillGeometry; //Field offset: 0x98
	protected bool mPlayMode; //Field offset: 0x99
	protected Vector4 mDrawRegion; //Field offset: 0x9C
	private Matrix4x4 mLocalToPanel; //Field offset: 0xAC
	private bool mIsVisibleByAlpha; //Field offset: 0xEC
	private bool mIsVisibleByPanel; //Field offset: 0xED
	private bool mIsInFront; //Field offset: 0xEE
	private float mLastAlpha; //Field offset: 0xF0
	private bool mMoved; //Field offset: 0xF4
	public UIDrawCall drawCall; //Field offset: 0xF8
	protected Vector3[] mCorners; //Field offset: 0xFC
	private int mAlphaFrameID; //Field offset: 0x100
	private int mMatrixFrame; //Field offset: 0x104
	private Vector3 mOldV0; //Field offset: 0x108
	private Vector3 mOldV1; //Field offset: 0x114

	public override float alpha
	{
		 get { } //Length: 744
		 set { } //Length: 41
	}

	public virtual Vector4 border
	{
		 get { } //Length: 15
		 set { } //Length: 79
	}

	public Color color
	{
		 get { } //Length: 534
		 set { } //Length: 27
	}

	public int depth
	{
		 get { } //Length: 6
		 set { } //Length: 746
	}

	public virtual Vector4 drawingDimensions
	{
		 get { } //Length: 73
	}

	public Vector4 drawRegion
	{
		 get { } //Length: 279
		 set { } //Length: 27
	}

	public bool hasBoxCollider
	{
		 get { } //Length: 105
	}

	public bool hasVertices
	{
		 get { } //Length: 132
	}

	public int height
	{
		 get { } //Length: 6
		 set { } //Length: 534
	}

	public bool isVisible
	{
		 get { } //Length: 6
	}

	public Vector3 localCenter
	{
		 get { } //Length: 286
	}

	public override Vector3[] localCorners
	{
		 get { } //Length: 178
	}

	public virtual Vector2 localSize
	{
		 get { } //Length: 221
	}

	public virtual Texture mainTexture
	{
		 get { } //Length: 6
		 set { } //Length: 114
	}

	public virtual Material material
	{
		 get { } //Length: 403
		 set { } //Length: 487
	}

	public virtual int minHeight
	{
		 get { } //Length: 3
	}

	public virtual int minWidth
	{
		 get { } //Length: 341
	}

	public OnRenderCallback onRender
	{
		 get { } //Length: 265
		 set { } //Length: 230
	}

	public Pivot pivot
	{
		 get { } //Length: 6
		 set { } //Length: 44
	}

	public Vector2 pivotOffset
	{
		 get { } //Length: 273
	}

	public Pivot rawPivot
	{
		 get { } //Length: 25
		 set { } //Length: 198
	}

	public int raycastDepth
	{
		 get { } //Length: 6
	}

	public Vector2 relativeSize
	{
		 get { } //Length: 95
	}

	public virtual Shader shader
	{
		 get { } //Length: 105
		 set { } //Length: 95
	}

	public int width
	{
		 get { } //Length: 6
		 set { } //Length: 14
	}

	public Vector3 worldCenter
	{
		 get { } //Length: 218
	}

	public override Vector3[] worldCorners
	{
		 get { } //Length: 469
	}

	public UIWidget() { }

	private void AdaptFromCollider() { }

	private void AdaptScale() { }

	protected override void Awake() { }

	public Bounds CalculateBounds(Transform relativeParent) { }

	public Bounds CalculateBounds() { }

	public float CalculateCumulativeAlpha(int frameID) { }

	public override float CalculateFinalAlpha(int frameID) { }

	public void CheckLayer() { }

	private void CreateAndSizeWidget() { }

	public UIPanel CreatePanel() { }

	public static int FullCompareFunc(UIWidget left, UIWidget right) { }

	public override float get_alpha() { }

	public virtual Vector4 get_border() { }

	public Color get_color() { }

	public int get_depth() { }

	public virtual Vector4 get_drawingDimensions() { }

	public Vector4 get_drawRegion() { }

	public bool get_hasBoxCollider() { }

	public bool get_hasVertices() { }

	public int get_height() { }

	public bool get_isVisible() { }

	public Vector3 get_localCenter() { }

	public override Vector3[] get_localCorners() { }

	public virtual Vector2 get_localSize() { }

	public virtual Texture get_mainTexture() { }

	public virtual Material get_material() { }

	public virtual int get_minHeight() { }

	public virtual int get_minWidth() { }

	public OnRenderCallback get_onRender() { }

	public Pivot get_pivot() { }

	public Vector2 get_pivotOffset() { }

	public Pivot get_rawPivot() { }

	public int get_raycastDepth() { }

	public Vector2 get_relativeSize() { }

	public virtual Shader get_shader() { }

	public int get_width() { }

	public Vector3 get_worldCenter() { }

	public override Vector3[] get_worldCorners() { }

	public override Vector3[] GetSides(Transform relativeTo) { }

	public override void Invalidate(bool includeChildren) { }

	public virtual void MakePixelPerfect() { }

	public virtual void MarkAsChanged() { }

	protected override void OnAnchor() { }

	private void OnApplicationPause(bool paused) { }

	private void OnDestroy() { }

	protected override void OnDisable() { }

	public virtual void OnFill(List<Vector3> verts, List<Vector2> uvs, List<Color> cols) { }

	protected override void OnInit() { }

	protected override void OnStart() { }

	protected override void OnUpdate() { }

	public static int PanelCompareFunc(UIWidget left, UIWidget right) { }

	public override void ParentHasChanged() { }

	public void RemoveFromPanel() { }

	public void ResizeCollider() { }

	public override void set_alpha(float value) { }

	public virtual void set_border(Vector4 value) { }

	public void set_color(Color value) { }

	public void set_depth(int value) { }

	public void set_drawRegion(Vector4 value) { }

	public void set_height(int value) { }

	public virtual void set_mainTexture(Texture value) { }

	public virtual void set_material(Material value) { }

	public void set_onRender(OnRenderCallback value) { }

	public void set_pivot(Pivot value) { }

	public void set_rawPivot(Pivot value) { }

	public virtual void set_shader(Shader value) { }

	public void set_width(int value) { }

	public void SetDimensions(int w, int h) { }

	public void SetDirty() { }

	public override void SetRect(float x, float y, float width, float height) { }

	protected void UpdateFinalAlpha(int frameID) { }

	public bool UpdateGeometry(int frame) { }

	public bool UpdateTransform(int frame) { }

	public bool UpdateVisibility(bool visibleByAlpha, bool visibleByPanel) { }

	protected virtual void UpgradeFrom265() { }

	public void WriteToBuffers(List<Vector3> v, List<Vector2> u, List<Color> c, List<Vector3> n, List<Vector4> t, List<Vector4> u2) { }

}

