namespace UnityEngine.UI;

public class RectMask2D : UIBehaviour, IClipper, ICanvasRaycastFilter
{
	private readonly RectangularVertexClipper m_VertexClipper; //Field offset: 0xC
	private RectTransform m_RectTransform; //Field offset: 0x10
	private HashSet<MaskableGraphic> m_MaskableTargets; //Field offset: 0x14
	private HashSet<IClippable> m_ClipTargets; //Field offset: 0x18
	private bool m_ShouldRecalculateClipRects; //Field offset: 0x1C
	private List<RectMask2D> m_Clippers; //Field offset: 0x20
	private Rect m_LastClipRectCanvasSpace; //Field offset: 0x24
	private bool m_ForceClip; //Field offset: 0x34
	private Canvas m_Canvas; //Field offset: 0x38
	private Vector3[] m_Corners; //Field offset: 0x3C

	private Canvas Canvas
	{
		 get { } //Length: 6
	}

	public Rect canvasRect
	{
		 get { } //Length: 1660
	}

	public RectTransform rectTransform
	{
		 get { } //Length: 286
	}

	private Rect rootCanvasRect
	{
		 get { } //Length: 30
	}

	protected RectMask2D() { }

	public void AddClippable(IClippable clippable) { }

	private Canvas get_Canvas() { }

	public Rect get_canvasRect() { }

	public RectTransform get_rectTransform() { }

	private Rect get_rootCanvasRect() { }

	public virtual bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

	protected override void OnCanvasHierarchyChanged() { }

	protected override void OnDisable() { }

	protected override void OnEnable() { }

	protected override void OnTransformParentChanged() { }

	public virtual void PerformClipping() { }

	public void RemoveClippable(IClippable clippable) { }

}

