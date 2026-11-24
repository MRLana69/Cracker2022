namespace UnityEngine.UI;

public class Slider : Selectable, IDragHandler, IEventSystemHandler, IInitializePotentialDragHandler, ICanvasElement
{
	private enum Axis
	{
		Horizontal = 0,
		Vertical = 1,
	}

	public enum Direction
	{
		LeftToRight = 0,
		RightToLeft = 1,
		BottomToTop = 2,
		TopToBottom = 3,
	}

	public class SliderEvent
	{

		public SliderEvent() { }

	}

	private RectTransform m_FillRect; //Field offset: 0xA4
	private RectTransform m_HandleRect; //Field offset: 0xA8
	private Direction m_Direction; //Field offset: 0xAC
	private float m_MinValue; //Field offset: 0xB0
	private float m_MaxValue; //Field offset: 0xB4
	private bool m_WholeNumbers; //Field offset: 0xB8
	protected float m_Value; //Field offset: 0xBC
	private SliderEvent m_OnValueChanged; //Field offset: 0xC0
	private Image m_FillImage; //Field offset: 0xC4
	private Transform m_FillTransform; //Field offset: 0xC8
	private RectTransform m_FillContainerRect; //Field offset: 0xCC
	private Transform m_HandleTransform; //Field offset: 0xD0
	private RectTransform m_HandleContainerRect; //Field offset: 0xD4
	private Vector2 m_Offset; //Field offset: 0xD8
	private DrivenRectTransformTracker m_Tracker; //Field offset: 0xE0
	private bool m_DelayedUpdateVisuals; //Field offset: 0xE1

	private Axis axis
	{
		 get { } //Length: 7
	}

	public Direction direction
	{
		 get { } //Length: 7
		 set { } //Length: 74
	}

	public RectTransform fillRect
	{
		 get { } //Length: 38
		 set { } //Length: 17
	}

	public RectTransform handleRect
	{
		 get { } //Length: 7
		 set { } //Length: 74
	}

	public float maxValue
	{
		 get { } //Length: 7
		 set { } //Length: 82
	}

	public float minValue
	{
		 get { } //Length: 6
		 set { } //Length: 13
	}

	public float normalizedValue
	{
		 get { } //Length: 98
		 set { } //Length: 13
	}

	public SliderEvent onValueChanged
	{
		 get { } //Length: 10
		 set { } //Length: 82
	}

	private bool reverseValue
	{
		 get { } //Length: 33
	}

	private float stepSize
	{
		 get { } //Length: 160
	}

	public virtual float value
	{
		 get { } //Length: 7
		 set { } //Length: 82
	}

	public bool wholeNumbers
	{
		 get { } //Length: 7
		 set { } //Length: 66
	}

	protected Slider() { }

	private float ClampValue(float input) { }

	public override Selectable FindSelectableOnDown() { }

	public override Selectable FindSelectableOnLeft() { }

	public override Selectable FindSelectableOnRight() { }

	public override Selectable FindSelectableOnUp() { }

	private Axis get_axis() { }

	public Direction get_direction() { }

	public RectTransform get_fillRect() { }

	public RectTransform get_handleRect() { }

	public float get_maxValue() { }

	public float get_minValue() { }

	public float get_normalizedValue() { }

	public SliderEvent get_onValueChanged() { }

	private bool get_reverseValue() { }

	private float get_stepSize() { }

	public virtual float get_value() { }

	public bool get_wholeNumbers() { }

	public virtual void GraphicUpdateComplete() { }

	public virtual void LayoutComplete() { }

	private bool MayDrag(PointerEventData eventData) { }

	protected override void OnDidApplyAnimationProperties() { }

	protected override void OnDisable() { }

	public virtual void OnDrag(PointerEventData eventData) { }

	protected override void OnEnable() { }

	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

	public override void OnMove(AxisEventData eventData) { }

	public override void OnPointerDown(PointerEventData eventData) { }

	protected override void OnRectTransformDimensionsChange() { }

	public virtual void Rebuild(CanvasUpdate executing) { }

	protected virtual void Set(float input, bool sendCallback = true) { }

	public void set_direction(Direction value) { }

	public void set_fillRect(RectTransform value) { }

	public void set_handleRect(RectTransform value) { }

	public void set_maxValue(float value) { }

	public void set_minValue(float value) { }

	public void set_normalizedValue(float value) { }

	public void set_onValueChanged(SliderEvent value) { }

	public virtual void set_value(float value) { }

	public void set_wholeNumbers(bool value) { }

	public void SetDirection(Direction direction, bool includeRectLayouts) { }

	public virtual void SetValueWithoutNotify(float input) { }

	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }

	protected virtual void Update() { }

	private void UpdateCachedReferences() { }

	private void UpdateDrag(PointerEventData eventData, Camera cam) { }

	private void UpdateVisuals() { }

}

