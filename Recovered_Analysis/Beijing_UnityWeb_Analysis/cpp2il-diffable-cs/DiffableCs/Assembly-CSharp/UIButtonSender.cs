//Type is in global namespace

public class UIButtonSender : MonoBehaviour
{
	public enum Trigger
	{
		OnClick = 0,
		OnMouseOver = 1,
		OnMouseOut = 2,
		OnPress = 3,
		OnRelease = 4,
	}

	public Trigger trigger; //Field offset: 0xC

	public UIButtonSender() { }

	protected virtual void OnClick() { }

	protected virtual void OnHover(bool isOver) { }

	protected virtual void OnPress(bool isPressed) { }

	protected virtual void Send() { }

	protected virtual void Send(bool isPressed) { }

}

