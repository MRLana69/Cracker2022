namespace UI.Generic;

public class ButtonColor : MonoBehaviour
{
	private UIWidget _widget; //Field offset: 0xC
	private Color _normalColor; //Field offset: 0x10
	private Color _pressedColor; //Field offset: 0x20

	public ButtonColor() { }

	private void MakePressedFromNormalColor() { }

	private void OnPress(bool pressed) { }

	private void TakeNormalColorFromWidget() { }

}

