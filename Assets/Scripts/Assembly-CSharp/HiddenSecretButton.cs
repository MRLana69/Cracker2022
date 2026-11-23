using UI.Screens;

public class HiddenSecretButton : UIScreen
{
	private const int STANDARD_NUMBER_OF_CLICKS_TO_OPEN = 3;

	private const int DEBUG_NUMBER_OF_CLICKS_TO_OPEN = 1;

	private int tabs;

	private void OnClick()
	{
		//IL_0062: Expected Obj, but got I4
		//IL_000e: Expected Obj, but got I4
		int num = ++tabs;
		object obj = 1;
		if (!Globals.DEBUG)
		{
			obj = 3;
		}
		if ((nint)obj == num)
		{
			UIScreenController instance = UIScreenController.Instance;
			instance.PushPopup("SecretPopup");
			tabs = 0;
		}
	}
}
