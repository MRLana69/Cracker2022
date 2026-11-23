using UnityEngine;

public class SfxButton : MonoBehaviour
{
	private UISprite iconOff;

	private UILabel sfxLabel;

	private void Awake()
	{
		bool optionSfx = Settings.optionSfx;
		_SetupButton(optionSfx);
	}

	private void OnEnable()
	{
		bool optionSfx = Settings.optionSfx;
		bool flag = !optionSfx;
		bool flag2 = false;
		if (!flag)
		{
			bool flag3 = (byte)(~(Settings._anotherSoundIsPlayingOnDevice ? 1u : 0u)) != 0;
			flag2 = flag3;
		}
		_SetupButton(flag2);
	}

	public void Click()
	{
		Settings.ToggleCurrentSfxOption();
		bool optionSfx = Settings.optionSfx;
		_SetupButton(optionSfx);
	}

	private void _SetupButton(bool enabled)
	{
		StringID key = StringID.SETTINGS_POPUP_SFX_ON;
		if (!enabled)
		{
			key = StringID.SETTINGS_POPUP_SFX_OFF;
		}
		string text = Strings.Get(key);
		sfxLabel.text = text;
		bool flag = (byte)((enabled ? 1u : 0u) ^ 1u) != 0;
		iconOff.enabled = flag;
	}
}
