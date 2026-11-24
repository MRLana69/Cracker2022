namespace UI.Generic;

public class ButtonPressedColorChange : MonoBehaviour
{
	private UIWidget _widget; //Field offset: 0xC
	private Color <normalColor>k__BackingField; //Field offset: 0x10
	private Color <pressedColor>k__BackingField; //Field offset: 0x20

	public Color normalColor
	{
		private get { } //Length: 23
		 set { } //Length: 26
	}

	public Color pressedColor
	{
		private get { } //Length: 61
		 set { } //Length: 26
	}

	public ButtonPressedColorChange() { }

	private Color get_normalColor() { }

	private Color get_pressedColor() { }

	private void OnPress(bool pressed) { }

	public void set_normalColor(Color value) { }

	public void set_pressedColor(Color value) { }

}

