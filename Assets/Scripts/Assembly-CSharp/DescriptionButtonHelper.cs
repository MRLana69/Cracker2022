public class DescriptionButtonHelper : UIBasicButton
{
	protected override void Send()
	{
		UIScreenController instance = UIScreenController.Instance;
		string currentPopupName = instance.GetCurrentPopupName();
		bool flag = currentPopupName == "UpgradesUI_quick";
		UIScreenController instance2 = UIScreenController.Instance;
		if (flag)
		{
			instance2.PushPopup("PrizeMBPopup_Keys");
		}
		else
		{
			instance2.QueuePopup("PrizeMBPopup_Keys");
		}
	}
}
