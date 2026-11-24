//Type is in global namespace

public class UIEventTrigger : MonoBehaviour
{
	public static UIEventTrigger current; //Field offset: 0x0
	public List<EventDelegate> onHoverOver; //Field offset: 0xC
	public List<EventDelegate> onHoverOut; //Field offset: 0x10
	public List<EventDelegate> onPress; //Field offset: 0x14
	public List<EventDelegate> onRelease; //Field offset: 0x18
	public List<EventDelegate> onSelect; //Field offset: 0x1C
	public List<EventDelegate> onDeselect; //Field offset: 0x20
	public List<EventDelegate> onClick; //Field offset: 0x24
	public List<EventDelegate> onDoubleClick; //Field offset: 0x28
	public List<EventDelegate> onDragStart; //Field offset: 0x2C
	public List<EventDelegate> onDragEnd; //Field offset: 0x30
	public List<EventDelegate> onDragOver; //Field offset: 0x34
	public List<EventDelegate> onDragOut; //Field offset: 0x38
	public List<EventDelegate> onDrag; //Field offset: 0x3C

	public bool isColliderEnabled
	{
		 get { } //Length: 6
	}

	public UIEventTrigger() { }

	public bool get_isColliderEnabled() { }

	private void OnClick() { }

	private void OnDoubleClick() { }

	private void OnDrag(Vector2 delta) { }

	private void OnDragEnd() { }

	private void OnDragOut(GameObject go) { }

	private void OnDragOver(GameObject go) { }

	private void OnDragStart() { }

	private void OnHover(bool isOver) { }

	private void OnPress(bool pressed) { }

	private void OnSelect(bool selected) { }

}

