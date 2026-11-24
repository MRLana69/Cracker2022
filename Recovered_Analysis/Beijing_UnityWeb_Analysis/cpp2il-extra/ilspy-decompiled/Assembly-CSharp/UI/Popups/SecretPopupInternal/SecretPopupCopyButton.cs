using UnityEngine;

namespace UI.Popups.SecretPopupInternal;

public class SecretPopupCopyButton : MonoBehaviour
{
	private SecretPopup _secretPopUpScreen;

	private void OnClick()
	{
		CancelInvoke();
	}

	public SecretPopupCopyButton()
	{
		_secretPopUpScreen.CopyAppFileInformationToClipboard();
	}
}
