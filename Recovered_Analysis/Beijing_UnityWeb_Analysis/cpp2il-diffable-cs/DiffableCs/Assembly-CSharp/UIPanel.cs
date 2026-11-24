//Type is in global namespace

public class UIPanel : UIRect
{
	public delegate OnClippingMoved
	{

		public OnClippingMoved(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(UIPanel panel, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(UIPanel panel) { }

	}

	public delegate OnCreateMaterial
	{

		public OnCreateMaterial(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(UIWidget widget, Material mat, AsyncCallback callback, object object) { }

		public virtual Material EndInvoke(IAsyncResult result) { }

		public virtual Material Invoke(UIWidget widget, Material mat) { }

	}

	public delegate OnGeometryUpdated
	{

		public OnGeometryUpdated(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke() { }

	}

	public enum RenderQueue
	{
		Automatic = 0,
		StartAt = 1,
		Explicit = 2,
	}

	public static List<UIPanel> list; //Field offset: 0x0
	private static float[] mTemp; //Field offset: 0x4
	private static Vector3[] mCorners; //Field offset: 0x8
	private static int mUpdateFrame; //Field offset: 0xC
	public OnGeometryUpdated onGeometryUpdated; //Field offset: 0x50
	public bool showInPanelTool; //Field offset: 0x54
	public bool generateNormals; //Field offset: 0x55
	public bool generateUV2; //Field offset: 0x56
	public ShadowMode shadowMode; //Field offset: 0x58
	public bool widgetsAreStatic; //Field offset: 0x5C
	public bool cullWhileDragging; //Field offset: 0x5D
	public bool alwaysOnScreen; //Field offset: 0x5E
	public bool anchorOffset; //Field offset: 0x5F
	public bool softBorderPadding; //Field offset: 0x60
	public RenderQueue renderQueue; //Field offset: 0x64
	public int startingRenderQueue; //Field offset: 0x68
	public List<UIWidget> widgets; //Field offset: 0x6C
	public List<UIDrawCall> drawCalls; //Field offset: 0x70
	public Matrix4x4 worldToLocal; //Field offset: 0x74
	public Vector4 drawCallClipRange; //Field offset: 0xB4
	public OnClippingMoved onClipMove; //Field offset: 0xC4
	public OnCreateMaterial onCreateMaterial; //Field offset: 0xC8
	public OnCreateDrawCall onCreateDrawCall; //Field offset: 0xCC
	private Texture2D mClipTexture; //Field offset: 0xD0
	private float mAlpha; //Field offset: 0xD4
	private Clipping mClipping; //Field offset: 0xD8
	private Vector4 mClipRange; //Field offset: 0xDC
	private Vector2 mClipSoftness; //Field offset: 0xEC
	private int mDepth; //Field offset: 0xF4
	private int mSortingOrder; //Field offset: 0xF8
	private string mSortingLayerName; //Field offset: 0xFC
	private bool mRebuild; //Field offset: 0x100
	private bool mResized; //Field offset: 0x101
	private Vector2 mClipOffset; //Field offset: 0x104
	private int mMatrixFrame; //Field offset: 0x10C
	private int mAlphaFrameID; //Field offset: 0x110
	private int mLayer; //Field offset: 0x114
	private Vector2 mMin; //Field offset: 0x118
	private Vector2 mMax; //Field offset: 0x120
	private bool mSortWidgets; //Field offset: 0x128
	private bool mUpdateScroll; //Field offset: 0x129
	public bool useSortingOrder; //Field offset: 0x12A
	private UIPanel mParentPanel; //Field offset: 0x12C
	private bool mHasMoved; //Field offset: 0x130
	private OnRenderCallback mOnRender; //Field offset: 0x134
	private bool mForced; //Field offset: 0x138

	public override float alpha
	{
		 get { } //Length: 24
		 set { } //Length: 105
	}

	public Vector4 baseClipRegion
	{
		 get { } //Length: 46
		 set { } //Length: 27
	}

	public override bool canBeAnchored
	{
		 get { } //Length: 7
	}

	public int clipCount
	{
		 get { } //Length: 7
	}

	public Vector2 clipOffset
	{
		 get { } //Length: 37
		 set { } //Length: 12
	}

	public Clipping clipping
	{
		 get { } //Length: 104
		 set { } //Length: 487
	}

	public Vector4 clipRange
	{
		 get { } //Length: 99
		 set { } //Length: 27
	}

	public bool clipsChildren
	{
		 get { } //Length: 12
	}

	public Vector2 clipSoftness
	{
		 get { } //Length: 572
		 set { } //Length: 12
	}

	public Texture2D clipTexture
	{
		 get { } //Length: 9
		 set { } //Length: 269
	}

	public int depth
	{
		 get { } //Length: 10
		 set { } //Length: 176
	}

	public Vector3 drawCallOffset
	{
		 get { } //Length: 168
	}

	public Vector4 finalClipRegion
	{
		 get { } //Length: 544
	}

	public bool halfPixelOffset
	{
		 get { } //Length: 7
	}

	public bool hasClipping
	{
		 get { } //Length: 144
	}

	public bool hasCumulativeClipping
	{
		 get { } //Length: 25
	}

	public float height
	{
		 get { } //Length: 31
	}

	public override Vector3[] localCorners
	{
		 get { } //Length: 7
	}

	public static int nextUnusedDepth
	{
		 get { } //Length: 79
	}

	public UIPanel parentPanel
	{
		 get { } //Length: 7
	}

	public string sortingLayerName
	{
		 get { } //Length: 146
		 set { } //Length: 576
	}

	public int sortingOrder
	{
		 get { } //Length: 7
		 set { } //Length: 183
	}

	public bool usedForUI
	{
		 get { } //Length: 3
	}

	public float width
	{
		 get { } //Length: 7
	}

	public override Vector3[] worldCorners
	{
		 get { } //Length: 782
	}

	private static UIPanel() { }

	public UIPanel() { }

	public void AddWidget(UIWidget w) { }

	public bool Affects(UIWidget w) { }

	protected override void Awake() { }

	public virtual Vector3 CalculateConstrainOffset(Vector2 min, Vector2 max) { }

	public override float CalculateFinalAlpha(int frameID) { }

	public static int CompareFunc(UIPanel a, UIPanel b) { }

	public bool ConstrainTargetToBounds(Transform target, bool immediate) { }

	public bool ConstrainTargetToBounds(Transform target, ref Bounds targetBounds, bool immediate) { }

	private void FillAllDrawCalls() { }

	public bool FillDrawCall(UIDrawCall dc) { }

	public static UIPanel Find(Transform trans, bool createIfMissing) { }

	public static UIPanel Find(Transform trans) { }

	public static UIPanel Find(Transform trans, bool createIfMissing, int layer) { }

	public UIDrawCall FindDrawCall(UIWidget w) { }

	private void FindParent() { }

	public override float get_alpha() { }

	public Vector4 get_baseClipRegion() { }

	public override bool get_canBeAnchored() { }

	public int get_clipCount() { }

	public Vector2 get_clipOffset() { }

	public Clipping get_clipping() { }

	public Vector4 get_clipRange() { }

	public bool get_clipsChildren() { }

	public Vector2 get_clipSoftness() { }

	public Texture2D get_clipTexture() { }

	public int get_depth() { }

	public Vector3 get_drawCallOffset() { }

	public Vector4 get_finalClipRegion() { }

	public bool get_halfPixelOffset() { }

	public bool get_hasClipping() { }

	public bool get_hasCumulativeClipping() { }

	public float get_height() { }

	public override Vector3[] get_localCorners() { }

	public static int get_nextUnusedDepth() { }

	public UIPanel get_parentPanel() { }

	public string get_sortingLayerName() { }

	public int get_sortingOrder() { }

	public bool get_usedForUI() { }

	public float get_width() { }

	public override Vector3[] get_worldCorners() { }

	public override Vector3[] GetSides(Transform relativeTo) { }

	public Vector2 GetViewSize() { }

	public Vector2 GetWindowSize() { }

	public override void Invalidate(bool includeChildren) { }

	private void InvalidateClipping() { }

	public bool IsVisible(Vector3 a, Vector3 b, Vector3 c, Vector3 d) { }

	public bool IsVisible(Vector3 worldPos) { }

	public bool IsVisible(UIWidget w) { }

	private void LateUpdate() { }

	protected override void OnAnchor() { }

	protected override void OnDisable() { }

	protected override void OnEnable() { }

	protected override void OnInit() { }

	protected override void OnStart() { }

	public override void ParentHasChanged() { }

	public void RebuildAllDrawCalls() { }

	public void Refresh() { }

	public void RemoveWidget(UIWidget w) { }

	public override void set_alpha(float value) { }

	public void set_baseClipRegion(Vector4 value) { }

	public void set_clipOffset(Vector2 value) { }

	public void set_clipping(Clipping value) { }

	public void set_clipRange(Vector4 value) { }

	public void set_clipSoftness(Vector2 value) { }

	public void set_clipTexture(Texture2D value) { }

	public void set_depth(int value) { }

	public void set_sortingLayerName(string value) { }

	public void set_sortingOrder(int value) { }

	public void SetDirty() { }

	public override void SetRect(float x, float y, float width, float height) { }

	public void SortWidgets() { }

	private void UpdateDrawCalls(int sortOrder) { }

	private void UpdateLayers() { }

	private void UpdateSelf() { }

	private void UpdateTransformMatrix() { }

	private void UpdateWidgets() { }

}

