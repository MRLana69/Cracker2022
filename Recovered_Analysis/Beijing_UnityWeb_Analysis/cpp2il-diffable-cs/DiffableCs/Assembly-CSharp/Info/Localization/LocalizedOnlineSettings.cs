namespace Info.Localization;

public class LocalizedOnlineSettings
{
	private readonly string _defaultLocale; //Field offset: 0x8
	private readonly string _combinedLocale; //Field offset: 0xC
	private readonly OnlineSettingsData _data; //Field offset: 0x10

	public string latestVersionChangelog
	{
		 get { } //Length: 57
	}

	public string loadScreenTitle
	{
		 get { } //Length: 291
	}

	public UserTip[] userTips
	{
		 get { } //Length: 57
	}

	public LocalizedOnlineSettings(OnlineSettingsData data) { }

	private T FetchOrDefault(IDictionary<string, T> localizedFieldValue) { }

	public string get_latestVersionChangelog() { }

	public string get_loadScreenTitle() { }

	public UserTip[] get_userTips() { }

}

