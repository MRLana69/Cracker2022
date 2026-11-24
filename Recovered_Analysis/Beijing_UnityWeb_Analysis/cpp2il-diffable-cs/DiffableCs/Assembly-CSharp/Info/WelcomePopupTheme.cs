namespace Info;

public class WelcomePopupTheme : ScriptableObject
{
	private static WelcomePopupTheme _instance; //Field offset: 0x0
	public Color backgroundColor; //Field offset: 0xC
	public Color textColor; //Field offset: 0x1C

	public static WelcomePopupTheme instance
	{
		 get { } //Length: 48
	}

	private static WelcomePopupTheme() { }

	public WelcomePopupTheme() { }

	public static WelcomePopupTheme get_instance() { }

}

