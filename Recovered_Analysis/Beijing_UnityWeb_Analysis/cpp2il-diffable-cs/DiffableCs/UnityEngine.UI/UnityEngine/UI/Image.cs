namespace UnityEngine.UI;

public class Image : MaskableGraphic, ISerializationCallbackReceiver, ILayoutElement, ICanvasRaycastFilter
{
	public enum FillMethod
	{
		Horizontal = 0,
		Vertical = 1,
		Radial90 = 2,
		Radial180 = 3,
		Radial360 = 4,
	}

	public enum Origin180
	{
		Bottom = 0,
		Left = 1,
		Top = 2,
		Right = 3,
	}

	public enum Origin360
	{
		Bottom = 0,
		Right = 1,
		Top = 2,
		Left = 3,
	}

	public enum Origin90
	{
		BottomLeft = 0,
		TopLeft = 1,
		TopRight = 2,
		BottomRight = 3,
	}

	public enum OriginHorizontal
	{
		Left = 0,
		Right = 1,
	}

	public enum OriginVertical
	{
		Bottom = 0,
		Top = 1,
	}

	public enum Type
	{
		Simple = 0,
		Sliced = 1,
		Tiled = 2,
		Filled = 3,
	}

	protected static Material s_ETC1DefaultUI; //Field offset: 0x0
	private static readonly Vector2[] s_VertScratch; //Field offset: 0x4
	private static readonly Vector2[] s_UVScratch; //Field offset: 0x8
	private static readonly Vector3[] s_Xy; //Field offset: 0xC
	private static readonly Vector3[] s_Uv; //Field offset: 0x10
	private static List<Image> m_TrackedTexturelessImages; //Field offset: 0x14
	private static bool s_Initialized; //Field offset: 0x18
	private Sprite m_Sprite; //Field offset: 0x6C
	private Sprite m_OverrideSprite; //Field offset: 0x70
	private Type m_Type; //Field offset: 0x74
	private bool m_PreserveAspect; //Field offset: 0x78
	private bool m_FillCenter; //Field offset: 0x79
	private FillMethod m_FillMethod; //Field offset: 0x7C
	private float m_FillAmount; //Field offset: 0x80
	private bool m_FillClockwise; //Field offset: 0x84
	private int m_FillOrigin; //Field offset: 0x88
	private float m_AlphaHitTestMinimumThreshold; //Field offset: 0x8C
	private bool m_Tracked; //Field offset: 0x90
	private bool m_UseSpriteMesh; //Field offset: 0x91
	private float m_PixelsPerUnitMultiplier; //Field offset: 0x94
	private float m_CachedReferencePixelsPerUnit; //Field offset: 0x98

	private Sprite activeSprite
	{
		 get { } //Length: 9
	}

	public float alphaHitTestMinimumThreshold
	{
		 get { } //Length: 13
		 set { } //Length: 15
	}

	public static Material defaultETC1GraphicMaterial
	{
		 get { } //Length: 223
	}

	public float eventAlphaThreshold
	{
		 get { } //Length: 7
		 set { } //Length: 136
	}

	public float fillAmount
	{
		 get { } //Length: 6
		 set { } //Length: 90
	}

	public bool fillCenter
	{
		 get { } //Length: 9
		 set { } //Length: 66
	}

	public bool fillClockwise
	{
		 get { } //Length: 6
		 set { } //Length: 74
	}

	public FillMethod fillMethod
	{
		 get { } //Length: 9
		 set { } //Length: 66
	}

	public int fillOrigin
	{
		 get { } //Length: 10
		 set { } //Length: 66
	}

	public virtual float flexibleHeight
	{
		 get { } //Length: 258
	}

	public virtual float flexibleWidth
	{
		 get { } //Length: 258
	}

	public bool hasBorder
	{
		 get { } //Length: 298
	}

	public virtual int layoutPriority
	{
		 get { } //Length: 266
	}

	public override Texture mainTexture
	{
		 get { } //Length: 10
	}

	public override Material material
	{
		 get { } //Length: 177
		 set { } //Length: 66
	}

	public virtual float minHeight
	{
		 get { } //Length: 6
	}

	public virtual float minWidth
	{
		 get { } //Length: 16
	}

	protected float multipliedPixelsPerUnit
	{
		 get { } //Length: 188
	}

	public Sprite overrideSprite
	{
		 get { } //Length: 6
		 set { } //Length: 918
	}

	public float pixelsPerUnit
	{
		 get { } //Length: 7
	}

	public float pixelsPerUnitMultiplier
	{
		 get { } //Length: 7
		 set { } //Length: 9
	}

	public virtual float preferredHeight
	{
		 get { } //Length: 6
	}

	public virtual float preferredWidth
	{
		 get { } //Length: 6
	}

	public bool preserveAspect
	{
		 get { } //Length: 6
		 set { } //Length: 66
	}

	public Sprite sprite
	{
		 get { } //Length: 181
		 set { } //Length: 299
	}

	public Type type
	{
		 get { } //Length: 98
		 set { } //Length: 74
	}

	public bool useSpriteMesh
	{
		 get { } //Length: 7
		 set { } //Length: 66
	}

	private static Image() { }

	protected Image() { }

	private static void AddQuad(VertexHelper vertexHelper, Vector3[] quadPositions, Color32 color, Vector3[] quadUVs) { }

	private static void AddQuad(VertexHelper vertexHelper, Vector2 posMin, Vector2 posMax, Color32 color, Vector2 uvMin, Vector2 uvMax) { }

	public virtual void CalculateLayoutInputHorizontal() { }

	public virtual void CalculateLayoutInputVertical() { }

	public void DisableSpriteOptimizations() { }

	private void GenerateFilledSprite(VertexHelper toFill, bool preserveAspect) { }

	private void GenerateSimpleSprite(VertexHelper vh, bool lPreserveAspect) { }

	private void GenerateSlicedSprite(VertexHelper toFill) { }

	private void GenerateSprite(VertexHelper vh, bool lPreserveAspect) { }

	private void GenerateTiledSprite(VertexHelper toFill) { }

	private Sprite get_activeSprite() { }

	public float get_alphaHitTestMinimumThreshold() { }

	public static Material get_defaultETC1GraphicMaterial() { }

	public float get_eventAlphaThreshold() { }

	public float get_fillAmount() { }

	public bool get_fillCenter() { }

	public bool get_fillClockwise() { }

	public FillMethod get_fillMethod() { }

	public int get_fillOrigin() { }

	public virtual float get_flexibleHeight() { }

	public virtual float get_flexibleWidth() { }

	public bool get_hasBorder() { }

	public virtual int get_layoutPriority() { }

	public override Texture get_mainTexture() { }

	public override Material get_material() { }

	public virtual float get_minHeight() { }

	public virtual float get_minWidth() { }

	protected float get_multipliedPixelsPerUnit() { }

	public Sprite get_overrideSprite() { }

	public float get_pixelsPerUnit() { }

	public float get_pixelsPerUnitMultiplier() { }

	public virtual float get_preferredHeight() { }

	public virtual float get_preferredWidth() { }

	public bool get_preserveAspect() { }

	public Sprite get_sprite() { }

	public Type get_type() { }

	public bool get_useSpriteMesh() { }

	private Vector4 GetAdjustedBorders(Vector4 border, Rect adjustedRect) { }

	private Vector4 GetDrawingDimensions(bool shouldPreserveAspect) { }

	public virtual bool IsRaycastLocationValid(Vector2 screenPoint, Camera eventCamera) { }

	private Vector2 MapCoordinate(Vector2 local, Rect rect) { }

	public virtual void OnAfterDeserialize() { }

	public virtual void OnBeforeSerialize() { }

	protected override void OnCanvasHierarchyChanged() { }

	protected override void OnDisable() { }

	protected override void OnEnable() { }

	protected override void OnPopulateMesh(VertexHelper toFill) { }

	protected override void OnRectTransformDimensionsChange() { }

	protected override void OnTransformParentChanged() { }

	private void PreserveSpriteAspectRatio(ref Rect rect, Vector2 spriteSize) { }

	private static bool RadialCut(Vector3[] xy, Vector3[] uv, float fill, bool invert, int corner) { }

	private static void RadialCut(Vector3[] xy, float cos, float sin, bool invert, int corner) { }

	private static void RebuildImage(SpriteAtlas spriteAtlas) { }

	public void set_alphaHitTestMinimumThreshold(float value) { }

	public void set_eventAlphaThreshold(float value) { }

	public void set_fillAmount(float value) { }

	public void set_fillCenter(bool value) { }

	public void set_fillClockwise(bool value) { }

	public void set_fillMethod(FillMethod value) { }

	public void set_fillOrigin(int value) { }

	public override void set_material(Material value) { }

	public void set_overrideSprite(Sprite value) { }

	public void set_pixelsPerUnitMultiplier(float value) { }

	public void set_preserveAspect(bool value) { }

	public void set_sprite(Sprite value) { }

	public void set_type(Type value) { }

	public void set_useSpriteMesh(bool value) { }

	public override void SetNativeSize() { }

	private static void TrackImage(Image g) { }

	private void TrackSprite() { }

	private static void UnTrackImage(Image g) { }

	protected override void UpdateMaterial() { }

}

