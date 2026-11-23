using UI.Screens;

public class PrizeListPopup : UIScreen
{
	private void ClosePrizeList()
	{
		UIScreenController instance = UIScreenController.Instance;
		instance.CloseActivePopups(screenName);
	}
}
