//Type is in global namespace

public class EventTesterPopup : UIScreen
{
	private SelectPopupButton _eventTypePopupButton; //Field offset: 0x28
	private SelectPopupButton _charPopupButton; //Field offset: 0x2C
	private SelectPopupButton _boardPopupButton; //Field offset: 0x30
	private SelectPopupButton _hoursLeftPopupButton; //Field offset: 0x34
	private SelectPopupButton _eventCategoryPopupButton; //Field offset: 0x38
	private GameObject boardTypeButton; //Field offset: 0x3C
	private GameObject characterTypeButton; //Field offset: 0x40
	private GameObject _eventCategoryButton; //Field offset: 0x44
	private GameObject enableButton; //Field offset: 0x48
	private GameObject disableButton; //Field offset: 0x4C
	private GameObject _updateButton; //Field offset: 0x50
	private string _hoursLeft; //Field offset: 0x54
	private string _charType; //Field offset: 0x58
	private string _boardType; //Field offset: 0x5C
	private string _eventType; //Field offset: 0x60
	private string _eventCategory; //Field offset: 0x64

	public EventTesterPopup() { }

	public void BoardSelected() { }

	public void CharSelected() { }

	private void CheckDirty(string originalValue, string newValue) { }

	public void DisableEvent() { }

	public void EnableEvent() { }

	public void EventCategorySelected() { }

	public void EventTypeSelected() { }

	private List<string> GetEventTypes() { }

	public override void Init() { }

	public void NewTimeLimitSelected() { }

	public void UpdateEvent() { }

}

