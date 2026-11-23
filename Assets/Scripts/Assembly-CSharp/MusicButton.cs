using UnityEngine;

public class MusicButton : MonoBehaviour
{
	private UISprite iconOff;

	private UILabel musicLabel;

	private void Awake()
	{
		bool optionMusic = Settings.optionMusic;
		_SetupButton(optionMusic);
	}

	private void OnEnable()
	{
		bool optionMusic = Settings.optionMusic;
		bool flag = !optionMusic;
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
		Settings.ToggleCurrentMusicOption();
		bool optionMusic = Settings.optionMusic;
		_SetupButton(optionMusic);
	}

	private void _SetupButton(bool enabled)
	{
		StringID key = StringID.SETTINGS_POPUP_MUSIC_ON;
		if (!enabled)
		{
			key = StringID.SETTINGS_POPUP_MUSIC_OFF;
		}
		string text = Strings.Get(key);
		musicLabel.text = text;
		bool flag = (byte)((enabled ? 1u : 0u) ^ 1u) != 0;
		iconOff.enabled = flag;
	}
}
