namespace UI.MessageCenter;

public class UIBasicButton : MonoBehaviour
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

	public UIBasicButton() { }

	protected void OnClick() { }

	protected void OnHover(bool isOver) { }

	protected void OnPress(bool isPressed) { }

	public virtual void Send() { }

}

