namespace Info;

public static class Settings
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal void <.cctor>b__11_0(RefreshType refreshType) { }

	}

	private const int OPTION_REMINDER_DEFAULT_ANDROID = 1; //Field offset: 0x0
	private const int OPTION_REMINDER_DEFAULT_IOS = 0; //Field offset: 0x0
	private static Action<bool> onTopRunChallengerSettingChanged; //Field offset: 0x0
	private static Action onSfxSettingChanged; //Field offset: 0x4
	private static Action onMusicSettingsChanged; //Field offset: 0x8

	public static event Action onMusicSettingsChanged
	{
		 add { } //Length: 209
		 remove { } //Length: 209
	}

	public static event Action onSfxSettingChanged
	{
		 add { } //Length: 206
		 remove { } //Length: 209
	}

	public static event Action<bool> onTopRunChallengerSettingChanged
	{
		 add { } //Length: 129
		 remove { } //Length: 206
	}

	public static bool anySoundEnabled
	{
		 get { } //Length: 7
	}

	public static bool optionMusic
	{
		 get { } //Length: 7
		 set { } //Length: 165
	}

	public static bool optionReminder
	{
		 get { } //Length: 125
		 set { } //Length: 144
	}

	public static bool optionSfx
	{
		 get { } //Length: 49
		 set { } //Length: 209
	}

	public static bool optionTopRunChallengers
	{
		 get { } //Length: 7
		 set { } //Length: 103
	}

	private static Settings() { }

	public static void add_onMusicSettingsChanged(Action value) { }

	public static void add_onSfxSettingChanged(Action value) { }

	public static void add_onTopRunChallengerSettingChanged(Action<bool> value) { }

	public static void DisableAllSoundOptions() { }

	public static void EnableAllSoundOptions() { }

	public static bool get_anySoundEnabled() { }

	public static bool get_optionMusic() { }

	public static bool get_optionReminder() { }

	public static bool get_optionSfx() { }

	public static bool get_optionTopRunChallengers() { }

	private static void RefreshSettings() { }

	public static void remove_onMusicSettingsChanged(Action value) { }

	public static void remove_onSfxSettingChanged(Action value) { }

	public static void remove_onTopRunChallengerSettingChanged(Action<bool> value) { }

	public static void set_optionMusic(bool value) { }

	public static void set_optionReminder(bool value) { }

	public static void set_optionSfx(bool value) { }

	public static void set_optionTopRunChallengers(bool value) { }

	public static void ToggleCurrentMusicOption() { }

	public static void ToggleCurrentSfxOption() { }

	public static void ToggleOptionReminders() { }

}

