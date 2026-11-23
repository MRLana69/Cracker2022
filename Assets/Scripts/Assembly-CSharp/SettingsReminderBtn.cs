using UnityEngine;

public class SettingsReminderBtn : MonoBehaviour
{
	private UISprite iconOff;

	private UILabel reminderLabel;

	private void Awake()
	{
		SetupButton();
	}

	public void Click()
	{
		bool optionReminder = Settings.optionReminder;
		bool optionReminder2 = (byte)((optionReminder ? 1u : 0u) ^ 1u) != 0;
		Settings.optionReminder = optionReminder2;
		SetupButton();
	}

	private void SetupButton()
	{
		bool optionReminder = Settings.optionReminder;
		StringID key = StringID.SETTINGS_POPUP_REMINDER_ON;
		if (!optionReminder)
		{
			key = StringID.SETTINGS_POPUP_REMINDER_OFF;
		}
		string text = Strings.Get(key);
		reminderLabel.text = text;
		bool flag = (byte)((optionReminder ? 1u : 0u) ^ 1u) != 0;
		iconOff.enabled = flag;
	}
}
