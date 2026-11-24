namespace UnityEngine.UI;

public class Scrollbar : Selectable, IBeginDragHandler, IEventSystemHandler, IDragHandler, IInitializePotentialDragHandler, ICanvasElement
{
	private sealed class <ClickRepeat>d__57 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public Scrollbar <>4__this; //Field offset: 0x10
		public PointerEventData eventData; //Field offset: 0x14

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 539
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <ClickRepeat>d__57(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

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

	public class ScrollEvent
	{

		public ScrollEvent() { }

	}

	private RectTransform m_HandleRect; //Field offset: 0xA4
	private Direction m_Direction; //Field offset: 0xA8
	private float m_Value; //Field offset: 0xAC
	private float m_Size; //Field offset: 0xB0
	private int m_NumberOfSteps; //Field offset: 0xB4
	private ScrollEvent m_OnValueChanged; //Field offset: 0xB8
	private RectTransform m_ContainerRect; //Field offset: 0xBC
	private Vector2 m_Offset; //Field offset: 0xC0
	private DrivenRectTransformTracker m_Tracker; //Field offset: 0xC8
	private Coroutine m_PointerDownRepeat; //Field offset: 0xCC
	private bool isPointerDownAndNotDragging; //Field offset: 0xD0
	private bool m_DelayedUpdateVisuals; //Field offset: 0xD1

	private Axis axis
	{
		 get { } //Length: 7
	}

	public Direction direction
	{
		 get { } //Length: 7
		 set { } //Length: 74
	}

	public RectTransform handleRect
	{
		 get { } //Length: 76
		 set { } //Length: 246
	}

	public int numberOfSteps
	{
		 get { } //Length: 7
		 set { } //Length: 66
	}

	public ScrollEvent onValueChanged
	{
		 get { } //Length: 7
		 set { } //Length: 82
	}

	private bool reverseValue
	{
		 get { } //Length: 33
	}

	public float size
	{
		 get { } //Length: 127
		 set { } //Length: 13
	}

	private float stepSize
	{
		 get { } //Length: 7
	}

	public float value
	{
		 get { } //Length: 245
		 set { } //Length: 65
	}

	protected Scrollbar() { }

	protected IEnumerator ClickRepeat(PointerEventData eventData) { }

	private void DoUpdateDrag(Vector2 handleCorner, float remainingSize) { }

	public override Selectable FindSelectableOnDown() { }

	public override Selectable FindSelectableOnLeft() { }

	public override Selectable FindSelectableOnRight() { }

	public override Selectable FindSelectableOnUp() { }

	private Axis get_axis() { }

	public Direction get_direction() { }

	public RectTransform get_handleRect() { }

	public int get_numberOfSteps() { }

	public ScrollEvent get_onValueChanged() { }

	private bool get_reverseValue() { }

	public float get_size() { }

	private float get_stepSize() { }

	public float get_value() { }

	public virtual void GraphicUpdateComplete() { }

	public virtual void LayoutComplete() { }

	private bool MayDrag(PointerEventData eventData) { }

	public virtual void OnBeginDrag(PointerEventData eventData) { }

	protected override void OnDisable() { }

	public virtual void OnDrag(PointerEventData eventData) { }

	protected override void OnEnable() { }

	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

	public override void OnMove(AxisEventData eventData) { }

	public override void OnPointerDown(PointerEventData eventData) { }

	public override void OnPointerUp(PointerEventData eventData) { }

	protected override void OnRectTransformDimensionsChange() { }

	public virtual void Rebuild(CanvasUpdate executing) { }

	private void Set(float input, bool sendCallback = true) { }

	public void set_direction(Direction value) { }

	public void set_handleRect(RectTransform value) { }

	public void set_numberOfSteps(int value) { }

	public void set_onValueChanged(ScrollEvent value) { }

	public void set_size(float value) { }

	public void set_value(float value) { }

	public void SetDirection(Direction direction, bool includeRectLayouts) { }

	public virtual void SetValueWithoutNotify(float input) { }

	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }

	protected virtual void Update() { }

	private void UpdateCachedReferences() { }

	private void UpdateDrag(PointerEventData eventData) { }

	private void UpdateVisuals() { }

}

