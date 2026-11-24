//Type is in global namespace

public class UIForwardEvents : MonoBehaviour
{
	public GameObject target; //Field offset: 0xC
	public bool onHover; //Field offset: 0x10
	public bool onPress; //Field offset: 0x11
	public bool onClick; //Field offset: 0x12
	public bool onDoubleClick; //Field offset: 0x13
	public bool onSelect; //Field offset: 0x14
	public bool onDrag; //Field offset: 0x15
	public bool onDrop; //Field offset: 0x16
	public bool onSubmit; //Field offset: 0x17
	public bool onScroll; //Field offset: 0x18

	public UIForwardEvents() { }

	private void OnClick() { }

	private void OnDoubleClick() { }

	private void OnDrag(Vector2 delta) { }

	private void OnDrop(GameObject go) { }

	private void OnHover(bool isOver) { }

	private void OnPress(bool pressed) { }

	private void OnScroll(float delta) { }

	private void OnSelect(bool selected) { }

	private void OnSubmit() { }

}

