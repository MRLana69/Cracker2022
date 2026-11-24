namespace UnityEngine.UI;

public abstract class MaskableGraphic : Graphic, IClippable, IMaskable, IMaterialModifier
{
	public class CullStateChangedEvent
	{

		public CullStateChangedEvent() { }

	}

	protected bool m_ShouldRecalculateStencil; //Field offset: 0x4D
	protected Material m_MaskMaterial; //Field offset: 0x50
	private RectMask2D m_ParentMask; //Field offset: 0x54
	private bool m_Maskable; //Field offset: 0x58
	protected bool m_IncludeForMasking; //Field offset: 0x59
	private CullStateChangedEvent m_OnCullStateChanged; //Field offset: 0x5C
	protected bool m_ShouldRecalculate; //Field offset: 0x60
	protected int m_StencilValue; //Field offset: 0x64
	private readonly Vector3[] m_Corners; //Field offset: 0x68

	public bool maskable
	{
		 get { } //Length: 6
		 set { } //Length: 12
	}

	public CullStateChangedEvent onCullStateChanged
	{
		 get { } //Length: 101
		 set { } //Length: 128
	}

	private Rect rootCanvasRect
	{
		 get { } //Length: 114
	}

	protected MaskableGraphic() { }

	public virtual void Cull(Rect clipRect, bool validRect) { }

	public bool get_maskable() { }

	public CullStateChangedEvent get_onCullStateChanged() { }

	private Rect get_rootCanvasRect() { }

	public virtual Material GetModifiedMaterial(Material baseMaterial) { }

	protected override void OnCanvasHierarchyChanged() { }

	protected override void OnDisable() { }

	protected override void OnEnable() { }

	protected override void OnTransformParentChanged() { }

	public virtual void ParentMaskStateChanged() { }

	public virtual void RecalculateClipping() { }

	public virtual void RecalculateMasking() { }

	public void set_maskable(bool value) { }

	public void set_onCullStateChanged(CullStateChangedEvent value) { }

	public virtual void SetClipRect(Rect clipRect, bool validRect) { }

	private GameObject UnityEngine.UI.IClippable.get_gameObject() { }

	private void UpdateClipParent() { }

	private void UpdateCull(bool cull) { }

}

