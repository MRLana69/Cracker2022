namespace UnityEngine.EventSystems;

public class EventTrigger : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IInitializePotentialDragHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IDropHandler, IScrollHandler, IUpdateSelectedHandler, ISelectHandler, IDeselectHandler, IMoveHandler, ISubmitHandler, ICancelHandler
{
	public class Entry
	{
		public EventTriggerType eventID; //Field offset: 0x8
		public TriggerEvent callback; //Field offset: 0xC

		public Entry() { }

	}

	public class TriggerEvent
	{

		public TriggerEvent() { }

	}

	private List<Entry> m_Delegates; //Field offset: 0xC

	public List<Entry> delegates
	{
		 get { } //Length: 194
		 set { } //Length: 218
	}

	public List<Entry> triggers
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	protected EventTrigger() { }

	private void Execute(EventTriggerType id, BaseEventData eventData) { }

	public List<Entry> get_delegates() { }

	public List<Entry> get_triggers() { }

	public virtual void OnBeginDrag(PointerEventData eventData) { }

	public virtual void OnCancel(BaseEventData eventData) { }

	public virtual void OnDeselect(BaseEventData eventData) { }

	public virtual void OnDrag(PointerEventData eventData) { }

	public virtual void OnDrop(PointerEventData eventData) { }

	public virtual void OnEndDrag(PointerEventData eventData) { }

	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

	public virtual void OnMove(AxisEventData eventData) { }

	public virtual void OnPointerClick(PointerEventData eventData) { }

	public virtual void OnPointerDown(PointerEventData eventData) { }

	public virtual void OnPointerEnter(PointerEventData eventData) { }

	public virtual void OnPointerExit(PointerEventData eventData) { }

	public virtual void OnPointerUp(PointerEventData eventData) { }

	public virtual void OnScroll(PointerEventData eventData) { }

	public virtual void OnSelect(BaseEventData eventData) { }

	public virtual void OnSubmit(BaseEventData eventData) { }

	public virtual void OnUpdateSelected(BaseEventData eventData) { }

	public void set_delegates(List<Entry> value) { }

	public void set_triggers(List<Entry> value) { }

}

