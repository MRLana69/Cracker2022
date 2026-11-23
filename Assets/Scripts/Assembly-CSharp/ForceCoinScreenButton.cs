using UnityEngine;

public class ForceCoinScreenButton : MonoBehaviour
{
	private void OnClick()
	{
		UIScreenController instance = UIScreenController.Instance;
		string topScreenName = instance.GetTopScreenName();
		UIScreenController instance2 = default;
		if (topScreenName == null || topScreenName._stringLength != 0)
		{
			instance2 = UIScreenController.Instance;
		}
		instance2.ClosePopup();
		UIScreenController instance3 = UIScreenController.Instance;
		instance3.QueuePopup("CoinsUI_quick");
		UIScreenController instance4 = UIScreenController.Instance;
		instance4.QueuePopup("HoverboardPopup");
	}
}
