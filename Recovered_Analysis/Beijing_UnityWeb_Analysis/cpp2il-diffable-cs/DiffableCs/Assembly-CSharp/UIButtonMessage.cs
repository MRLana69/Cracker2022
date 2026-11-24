//Type is in global namespace

public class UIButtonMessage : MonoBehaviour
{
	public enum Trigger
	{
		OnClick = 0,
		OnMouseOver = 1,
		OnMouseOut = 2,
		OnPress = 3,
		OnRelease = 4,
		OnDoubleClick = 5,
	}

	public GameObject target; //Field offset: 0xC
	public string functionName; //Field offset: 0x10
	public Trigger trigger; //Field offset: 0x14
	public bool includeChildren; //Field offset: 0x18
	private bool mStarted; //Field offset: 0x19

	public UIButtonMessage() { }

	private void OnClick() { }

	private void OnDoubleClick() { }

	private void OnEnable() { }

	private void OnHover(bool isOver) { }

	private void OnPress(bool isPressed) { }

	private void OnSelect(bool isSelected) { }

	private void Send() { }

	private void Start() { }

}

