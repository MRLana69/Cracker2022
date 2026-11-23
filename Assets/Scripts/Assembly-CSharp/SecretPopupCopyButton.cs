using UnityEngine;

public class SecretPopupCopyButton : MonoBehaviour
{
	private SecretPopup _secretPopUpScreen;

	private void OnClick()
	{
		_secretPopUpScreen.CopyToClipboard();
	}
}
