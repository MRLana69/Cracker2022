using UnityEngine;

public class TopRunChallengersButton : MonoBehaviour
{
	private UISprite iconOff;

	private UILabel topRunChallengersLabel;

	private void Awake()
	{
		bool optionTopRunChallengers = Settings.optionTopRunChallengers;
		_SetupButton(optionTopRunChallengers);
	}

	public void Click()
	{
		bool optionTopRunChallengers = Settings.optionTopRunChallengers;
		bool optionTopRunChallengers2 = (byte)((optionTopRunChallengers ? 1u : 0u) ^ 1u) != 0;
		Settings.optionTopRunChallengers = optionTopRunChallengers2;
		bool optionTopRunChallengers3 = Settings.optionTopRunChallengers;
		_SetupButton(optionTopRunChallengers3);
	}

	private void _SetupButton(bool enabled)
	{
		StringID key = StringID.SETTINGS_POPUP_TOPRUNCHALLENGERS_ON;
		if (!enabled)
		{
			key = StringID.SETTINGS_POPUP_TOPRUNCHALLENGERS_OFF;
		}
		string text = Strings.Get(key);
		topRunChallengersLabel.text = text;
		bool flag = (byte)((enabled ? 1u : 0u) ^ 1u) != 0;
		iconOff.enabled = flag;
	}
}
