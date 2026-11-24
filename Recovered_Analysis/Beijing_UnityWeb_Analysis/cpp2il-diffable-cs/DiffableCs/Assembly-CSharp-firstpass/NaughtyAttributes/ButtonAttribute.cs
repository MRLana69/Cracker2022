namespace NaughtyAttributes;

public class ButtonAttribute : DrawerAttribute
{
	private string text; //Field offset: 0x8

	public string Text
	{
		 get { } //Length: 6
	}

	public ButtonAttribute(string text = null) { }

	public string get_Text() { }

}

