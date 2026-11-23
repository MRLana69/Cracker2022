using UI.Screens;
using UnityEngine;

public class PrivacyPolicyButton : MonoBehaviour
{
	private UIScreen myScreen;

	private void OnClick()
	{
		UIScreenController instance = UIScreenController.Instance;
		instance.PushPopup("PrivacyPolicyPopup");
	}
}
