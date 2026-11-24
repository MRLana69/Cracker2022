namespace UnityEngine.UI;

public class CanvasScaler : UIBehaviour
{
	public enum ScaleMode
	{
		ConstantPixelSize = 0,
		ScaleWithScreenSize = 1,
		ConstantPhysicalSize = 2,
	}

	public enum ScreenMatchMode
	{
		MatchWidthOrHeight = 0,
		Expand = 1,
		Shrink = 2,
	}

	public enum Unit
	{
		Centimeters = 0,
		Millimeters = 1,
		Inches = 2,
		Points = 3,
		Picas = 4,
	}

	private const float kLogBase = 2; //Field offset: 0x0
	private ScaleMode m_UiScaleMode; //Field offset: 0xC
	protected float m_ReferencePixelsPerUnit; //Field offset: 0x10
	protected float m_ScaleFactor; //Field offset: 0x14
	protected Vector2 m_ReferenceResolution; //Field offset: 0x18
	protected ScreenMatchMode m_ScreenMatchMode; //Field offset: 0x20
	protected float m_MatchWidthOrHeight; //Field offset: 0x24
	protected Unit m_PhysicalUnit; //Field offset: 0x28
	protected float m_FallbackScreenDPI; //Field offset: 0x2C
	protected float m_DefaultSpriteDPI; //Field offset: 0x30
	protected float m_DynamicPixelsPerUnit; //Field offset: 0x34
	private Canvas m_Canvas; //Field offset: 0x38
	private float m_PrevScaleFactor; //Field offset: 0x3C
	private float m_PrevReferencePixelsPerUnit; //Field offset: 0x40

	public float defaultSpriteDPI
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public float dynamicPixelsPerUnit
	{
		 get { } //Length: 6
		 set { } //Length: 95
	}

	public float fallbackScreenDPI
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public float matchWidthOrHeight
	{
		 get { } //Length: 6
		 set { } //Length: 95
	}

	public Unit physicalUnit
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public float referencePixelsPerUnit
	{
		 get { } //Length: 6
		 set { } //Length: 65
	}

	public Vector2 referenceResolution
	{
		 get { } //Length: 8
		 set { } //Length: 11
	}

	public float scaleFactor
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public ScreenMatchMode screenMatchMode
	{
		 get { } //Length: 6
		 set { } //Length: 317
	}

	public ScaleMode uiScaleMode
	{
		 get { } //Length: 114
		 set { } //Length: 253
	}

	protected CanvasScaler() { }

	public float get_defaultSpriteDPI() { }

	public float get_dynamicPixelsPerUnit() { }

	public float get_fallbackScreenDPI() { }

	public float get_matchWidthOrHeight() { }

	public Unit get_physicalUnit() { }

	public float get_referencePixelsPerUnit() { }

	public Vector2 get_referenceResolution() { }

	public float get_scaleFactor() { }

	public ScreenMatchMode get_screenMatchMode() { }

	public ScaleMode get_uiScaleMode() { }

	protected virtual void Handle() { }

	protected virtual void HandleConstantPhysicalSize() { }

	protected virtual void HandleConstantPixelSize() { }

	protected virtual void HandleScaleWithScreenSize() { }

	protected virtual void HandleWorldCanvas() { }

	protected override void OnDisable() { }

	protected override void OnEnable() { }

	public void set_defaultSpriteDPI(float value) { }

	public void set_dynamicPixelsPerUnit(float value) { }

	public void set_fallbackScreenDPI(float value) { }

	public void set_matchWidthOrHeight(float value) { }

	public void set_physicalUnit(Unit value) { }

	public void set_referencePixelsPerUnit(float value) { }

	public void set_referenceResolution(Vector2 value) { }

	public void set_scaleFactor(float value) { }

	public void set_screenMatchMode(ScreenMatchMode value) { }

	public void set_uiScaleMode(ScaleMode value) { }

	protected void SetReferencePixelsPerUnit(float referencePixelsPerUnit) { }

	protected void SetScaleFactor(float scaleFactor) { }

	protected virtual void Update() { }

}

