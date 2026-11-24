namespace UnityEngine.UI;

public abstract class Graphic : UIBehaviour, ICanvasElement
{
	protected static Material s_DefaultUI; //Field offset: 0x0
	protected static Texture2D s_WhiteTexture; //Field offset: 0x4
	protected static Mesh s_Mesh; //Field offset: 0x8
	private static readonly VertexHelper s_VertexHelper; //Field offset: 0xC
	protected Material m_Material; //Field offset: 0xC
	private Color m_Color; //Field offset: 0x10
	protected bool m_SkipLayoutUpdate; //Field offset: 0x20
	protected bool m_SkipMaterialUpdate; //Field offset: 0x21
	private bool m_RaycastTarget; //Field offset: 0x22
	private RectTransform m_RectTransform; //Field offset: 0x24
	private CanvasRenderer m_CanvasRenderer; //Field offset: 0x28
	private Canvas m_Canvas; //Field offset: 0x2C
	private bool m_VertsDirty; //Field offset: 0x30
	private bool m_MaterialDirty; //Field offset: 0x31
	protected UnityAction m_OnDirtyLayoutCallback; //Field offset: 0x34
	protected UnityAction m_OnDirtyVertsCallback; //Field offset: 0x38
	protected UnityAction m_OnDirtyMaterialCallback; //Field offset: 0x3C
	protected Mesh m_CachedMesh; //Field offset: 0x40
	protected Vector2[] m_CachedUvs; //Field offset: 0x44
	private readonly TweenRunner<ColorTween> m_ColorTweenRunner; //Field offset: 0x48
	private bool <useLegacyMeshGeneration>k__BackingField; //Field offset: 0x4C

	public Canvas canvas
	{
		 get { } //Length: 71
	}

	public CanvasRenderer canvasRenderer
	{
		 get { } //Length: 100
	}

	public virtual Color color
	{
		 get { } //Length: 8
		 set { } //Length: 26
	}

	public static Material defaultGraphicMaterial
	{
		 get { } //Length: 129
	}

	public virtual Material defaultMaterial
	{
		 get { } //Length: 71
	}

	public int depth
	{
		 get { } //Length: 9
	}

	public virtual Texture mainTexture
	{
		 get { } //Length: 330
	}

	public virtual Material material
	{
		 get { } //Length: 77
		 set { } //Length: 11
	}

	public virtual Material materialForRendering
	{
		 get { } //Length: 101
	}

	public virtual bool raycastTarget
	{
		 get { } //Length: 6
		 set { } //Length: 60
	}

	public RectTransform rectTransform
	{
		 get { } //Length: 15
	}

	protected bool useLegacyMeshGeneration
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	protected static Mesh workerMesh
	{
		 get { } //Length: 254
	}

	private static Graphic() { }

	protected Graphic() { }

	private void CacheCanvas() { }

	private static Color CreateColorFromAlpha(float alpha) { }

	public virtual void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) { }

	public virtual void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) { }

	public virtual void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha, bool useRGB) { }

	private void DoLegacyMeshGeneration() { }

	private void DoMeshGeneration() { }

	public Canvas get_canvas() { }

	public CanvasRenderer get_canvasRenderer() { }

	public virtual Color get_color() { }

	public static Material get_defaultGraphicMaterial() { }

	public virtual Material get_defaultMaterial() { }

	public int get_depth() { }

	public virtual Texture get_mainTexture() { }

	public virtual Material get_material() { }

	public virtual Material get_materialForRendering() { }

	public virtual bool get_raycastTarget() { }

	public RectTransform get_rectTransform() { }

	protected bool get_useLegacyMeshGeneration() { }

	protected static Mesh get_workerMesh() { }

	public Rect GetPixelAdjustedRect() { }

	public virtual void GraphicUpdateComplete() { }

	public virtual void LayoutComplete() { }

	protected override void OnBeforeTransformParentChanged() { }

	protected override void OnCanvasHierarchyChanged() { }

	public virtual void OnCullingChanged() { }

	protected override void OnDestroy() { }

	protected override void OnDidApplyAnimationProperties() { }

	protected override void OnDisable() { }

	protected override void OnEnable() { }

	protected virtual void OnFillVBO(List<UIVertex> vbo) { }

	protected virtual void OnPopulateMesh(Mesh m) { }

	protected virtual void OnPopulateMesh(VertexHelper vh) { }

	protected override void OnRectTransformDimensionsChange() { }

	protected override void OnTransformParentChanged() { }

	public Vector2 PixelAdjustPoint(Vector2 point) { }

	public virtual bool Raycast(Vector2 sp, Camera eventCamera) { }

	public virtual void Rebuild(CanvasUpdate update) { }

	public void RegisterDirtyLayoutCallback(UnityAction action) { }

	public void RegisterDirtyMaterialCallback(UnityAction action) { }

	public void RegisterDirtyVerticesCallback(UnityAction action) { }

	public virtual void set_color(Color value) { }

	public virtual void set_material(Material value) { }

	public virtual void set_raycastTarget(bool value) { }

	protected void set_useLegacyMeshGeneration(bool value) { }

	public virtual void SetAllDirty() { }

	public virtual void SetLayoutDirty() { }

	public virtual void SetMaterialDirty() { }

	public virtual void SetNativeSize() { }

	public virtual void SetVerticesDirty() { }

	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }

	public void UnregisterDirtyLayoutCallback(UnityAction action) { }

	public void UnregisterDirtyMaterialCallback(UnityAction action) { }

	public void UnregisterDirtyVerticesCallback(UnityAction action) { }

	protected virtual void UpdateGeometry() { }

	protected virtual void UpdateMaterial() { }

}

