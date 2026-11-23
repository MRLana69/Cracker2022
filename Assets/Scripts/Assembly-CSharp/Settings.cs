using System;
using Cpp2ILInjected;
using UnityEngine;

public class Settings : MonoBehaviour
{
	private static bool _optionsLoaded;

	private const string OPTION_SOUND_KEY = "OPTION_SOUND";

	private const string OPTION_SFX_KEY = "OPTION_SFX";

	private const int OPTION_SFX_DEFAULT = 1;

	private static bool _optionSfx;

	private const string OPTION_MUSIC_KEY = "OPTION_MUSIC";

	private const int OPTION_MUSIC_DEFAULT = 1;

	private static bool _optionMusic;

	private static bool _anotherSoundIsPlayingOnDevice;

	private const string OPTION_REMINDER_KEY = "OPTION_REMINDER_WITH_DEFAULT_OFF";

	private const int OPTION_REMINDER_DEFAULT = 0;

	private static bool _optionReminder;

	private static bool _optionMessages;

	private const string OPTION_TOPRUNCHALLENGERS_KEY = "OPTION_TOPRUNCHALLENGERS";

	private const int OPTION_TOPRUNCHALLENGERS_DEFAULT = 1;

	private static bool _optionTopRunChallengers;

	private static bool optionMessageDirty;

	public bool GEN_DEFAULT;

	private static Action<bool> m_OnTopRunChallengerSettingChanged;

	private static Action m_onSfxSettingChanged;

	private static Action m_onMusicSettingsChanged;

	public static bool optionSfx
	{
		get
		{
			LoadOptionsIfNeeded();
			return _optionSfx;
		}
		set
		{
			_optionSfx = value;
			PlayerPrefs.SetInt("OPTION_SFX", value ? 1 : 0);
			Action action = Settings.m_onSfxSettingChanged;
			if (Settings.m_onSfxSettingChanged != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v23.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
			bool flag = optionSfx;
			float soundVolume = 1f;
			if (!flag)
			{
				soundVolume = 0f;
			}
			NGUITools.soundVolume = soundVolume;
		}
	}

	public static bool optionMusic
	{
		get
		{
			LoadOptionsIfNeeded();
			return _optionMusic;
		}
		set
		{
			_optionMusic = value;
			PlayerPrefs.SetInt("OPTION_MUSIC", value ? 1 : 0);
			Action action = Settings.m_onMusicSettingsChanged;
			if (Settings.m_onMusicSettingsChanged != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v23.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
	}

	public static bool optionTopRunChallengers
	{
		get
		{
			LoadOptionsIfNeeded();
			return _optionTopRunChallengers;
		}
		set
		{
			_optionTopRunChallengers = value;
			PlayerPrefs.SetInt("OPTION_TOPRUNCHALLENGERS", _optionTopRunChallengers ? 1 : 0);
			Action<bool> onTopRunChallengerSettingChanged = Settings.m_OnTopRunChallengerSettingChanged;
			if (Settings.m_OnTopRunChallengerSettingChanged != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v26 @ S0_v13 (System.Action`1<System.Boolean>)+C] (should have been resolved before IL gen)");
			}
		}
	}

	public static bool anySoundEnabled
	{
		get
		{
			if (~(_optionMusic ? 1u : 0u) == 0)
			{
				return true;
			}
			return _optionSfx;
		}
	}

	public static bool anotherSoundIsPlayingOnDevice
	{
		get
		{
			return _anotherSoundIsPlayingOnDevice;
		}
		set
		{
			_anotherSoundIsPlayingOnDevice = value;
		}
	}

	public static bool optionReminder
	{
		get
		{
			LoadOptionsIfNeeded();
			return _optionReminder;
		}
		set
		{
			_optionReminder = value;
			PlayerPrefs.SetInt("OPTION_REMINDER_WITH_DEFAULT_OFF", _optionReminder ? 1 : 0);
		}
	}

	public static bool optionMessages
	{
		get
		{
			if (~(optionMessageDirty ? 1u : 0u) != 0)
			{
				PlayerInfo instance = PlayerInfo.Instance;
				_optionMessages = instance._remoteNotificationsEnabled;
			}
			return _optionMessages;
		}
		set
		{
			optionMessageDirty = true;
			_optionMessages = value;
		}
	}

	public static event Action<bool> OnTopRunChallengerSettingChanged
	{
		add
		{
			Delegate obj = Settings.m_OnTopRunChallengerSettingChanged;
			Action<bool> action = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = (object)obj == Settings.m_OnTopRunChallengerSettingChanged;
				Action<bool> onTopRunChallengerSettingChanged = action;
				if (!flag)
				{
					onTopRunChallengerSettingChanged = Settings.m_OnTopRunChallengerSettingChanged;
				}
				Settings.m_OnTopRunChallengerSettingChanged = onTopRunChallengerSettingChanged;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Settings.m_OnTopRunChallengerSettingChanged;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = Settings.m_OnTopRunChallengerSettingChanged;
			Action<bool> action = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = (object)obj == Settings.m_OnTopRunChallengerSettingChanged;
				Action<bool> onTopRunChallengerSettingChanged = action;
				if (!flag)
				{
					onTopRunChallengerSettingChanged = Settings.m_OnTopRunChallengerSettingChanged;
				}
				Settings.m_OnTopRunChallengerSettingChanged = onTopRunChallengerSettingChanged;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Settings.m_OnTopRunChallengerSettingChanged;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event Action onSfxSettingChanged
	{
		add
		{
			Delegate obj = Settings.m_onSfxSettingChanged;
			Action action2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == Settings.m_onSfxSettingChanged;
				Action action = action2;
				if (!flag)
				{
					action = Settings.m_onSfxSettingChanged;
				}
				Settings.m_onSfxSettingChanged = action;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Settings.m_onSfxSettingChanged;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = Settings.m_onSfxSettingChanged;
			Action action2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == Settings.m_onSfxSettingChanged;
				Action action = action2;
				if (!flag)
				{
					action = Settings.m_onSfxSettingChanged;
				}
				Settings.m_onSfxSettingChanged = action;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Settings.m_onSfxSettingChanged;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event Action onMusicSettingsChanged
	{
		add
		{
			Delegate obj = Settings.m_onMusicSettingsChanged;
			Action action2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == Settings.m_onMusicSettingsChanged;
				Action action = action2;
				if (!flag)
				{
					action = Settings.m_onMusicSettingsChanged;
				}
				Settings.m_onMusicSettingsChanged = action;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Settings.m_onMusicSettingsChanged;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = Settings.m_onMusicSettingsChanged;
			Action action2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == Settings.m_onMusicSettingsChanged;
				Action action = action2;
				if (!flag)
				{
					action = Settings.m_onMusicSettingsChanged;
				}
				Settings.m_onMusicSettingsChanged = action;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Settings.m_onMusicSettingsChanged;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static bool SFX_DEFAULT()
	{
		string text = PlayerPrefs.GetString("SFX_DEFAULT");
		bool flag = text != "done";
		if (flag)
		{
			PlayerPrefs.SetString("SFX_DEFAULT", "done");
			optionSfx = true;
		}
		return flag;
	}

	public static bool MUSIC_DEFAULT()
	{
		string text = PlayerPrefs.GetString("MUSIC_DEFAULT");
		bool flag = text != "done";
		if (flag)
		{
			PlayerPrefs.SetString("MUSIC_DEFAULT", "done");
			optionMusic = true;
		}
		return flag;
	}

	private void Awake()
	{
		LoadOptionsIfNeeded();
	}

	public static void LoadOptionsIfNeeded()
	{
		RuntimePlatform platform = Application.platform;
		if ((platform != RuntimePlatform.MetroPlayerARM || ~(FrontScreen.canEnableSound__BackingField ? 1u : 0u) == 0) && !_optionsLoaded)
		{
			_optionsLoaded = true;
			CleanupOldKeys();
			int num = PlayerPrefs.GetInt("OPTION_SFX", 1);
			bool flag = num != 0;
			optionSfx = flag;
			int num2 = PlayerPrefs.GetInt("OPTION_MUSIC", 1);
			bool flag2 = num2 != 0;
			optionMusic = flag2;
			int num3 = PlayerPrefs.GetInt("OPTION_REMINDER_WITH_DEFAULT_OFF", 0);
			bool flag3 = num3 != 0;
			optionReminder = flag3;
			int num4 = PlayerPrefs.GetInt("OPTION_TOPRUNCHALLENGERS", 1);
			bool flag4 = num4 != 0;
			optionTopRunChallengers = flag4;
		}
	}

	public static void ToggleCurrentSfxOption()
	{
		bool flag = optionSfx;
		bool flag2 = (byte)((flag ? 1u : 0u) ^ 1u) != 0;
		optionSfx = flag2;
		_anotherSoundIsPlayingOnDevice = false;
	}

	public static void ToggleCurrentMusicOption()
	{
		bool flag = optionMusic;
		bool flag2 = (byte)((flag ? 1u : 0u) ^ 1u) != 0;
		optionMusic = flag2;
		_anotherSoundIsPlayingOnDevice = false;
	}

	public static void EnableAllSoundOptions()
	{
		optionSfx = true;
		optionMusic = true;
		_anotherSoundIsPlayingOnDevice = false;
	}

	public static void DisableAllSoundOptions()
	{
		optionSfx = false;
		optionMusic = false;
	}

	public static void UpdateOptionMessagesIfNeeded()
	{
		if (~(optionMessageDirty ? 1u : 0u) == 0)
		{
			optionMessageDirty = false;
			SocialManager instance = SocialManager.instance;
			instance.UpdateRemoteNotificationControl(_optionMessages);
		}
	}

	private static void CleanupOldKeys()
	{
		if (PlayerPrefs.HasKey("OPTION_SOUND"))
		{
			PlayerPrefs.DeleteKey("OPTION_SOUND");
		}
	}
}
