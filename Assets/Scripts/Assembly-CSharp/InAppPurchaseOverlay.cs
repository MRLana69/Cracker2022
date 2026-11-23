using UnityEngine;

public class InAppPurchaseOverlay : MonoBehaviour
{
	public UILabel titleLabel;

	private void OnEnable()
	{
		if (titleLabel != null)
		{
			string text = Strings.Get(StringID.INAPP_MANAGER_OVERLAY_TEXT_GOOGLEPLAY);
			titleLabel.text = text;
		}
	}
}
