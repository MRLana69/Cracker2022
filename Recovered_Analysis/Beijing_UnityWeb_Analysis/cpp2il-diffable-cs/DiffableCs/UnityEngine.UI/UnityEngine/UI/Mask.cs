namespace UnityEngine.UI;

public class Mask : UIBehaviour, ICanvasRaycastFilter, IMaterialModifier
{
	private RectTransform m_RectTransform; //Field offset: 0xC
	private bool m_ShowMaskGraphic; //Field offset: 0x10
	private Graphic m_Graphic; //Field offset: 0x14
	private Material m_MaskMaterial; //Field offset: 0x18
	private Material m_UnmaskMaterial; //Field offset: 0x1C

	public Graphic graphic
	{
		 get { } //Length: 9
	}

	public RectTransform rectTransform
	{
		 get { } //Length: 54
	}

	public bool showMaskGraphic
	{
		 get { } //Length: 76
		 set { } //Length: 899
	}

	protected Mask() { }

	public Graphic get_graphic() { }

	public RectTransform get_rectTransform() { }

	public bool get_showMaskGraphic() { }

	public virtual Material GetModifiedMaterial(Material baseMaterial) { }

	public virtual bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

	public virtual bool MaskEnabled() { }

	protected override void OnDisable() { }

	protected override void OnEnable() { }

	public virtual void OnSiblingGraphicEnabledDisabled() { }

	public void set_showMaskGraphic(bool value) { }

}

