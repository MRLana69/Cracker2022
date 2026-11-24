namespace Info;

public static class EarnCoinsData
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__12_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal void <Trigger>b__12_0() { }

	}

	public class EarnCurrencyProfile
	{
		public Id id; //Field offset: 0x8
		public Type type; //Field offset: 0xC
		public Repeatability repeatability; //Field offset: 0x10
		public int defaultAmountOfCoins; //Field offset: 0x14
		public string title; //Field offset: 0x18
		public string desc; //Field offset: 0x1C
		public string iOSDesc; //Field offset: 0x20
		public string iconName; //Field offset: 0x24
		public string url; //Field offset: 0x28
		public string overrideAmountOfCoinsOnlineSettingKey; //Field offset: 0x2C

		public EarnCurrencyProfile() { }

		public int GetAmountOfCoins() { }

	}

	public enum Id
	{
		FacebookKiloo = 0,
		FacebookSybo = 1,
		TwitterKiloo = 2,
		TwitterSybo = 3,
		YoutubeKiloo = 4,
		YoutubeSybo = 5,
		Review = 6,
		AdColony = 7,
		VideoAdCycle = 8,
		FacebookLogin = 9,
		FacebookWeeklyGift = 10,
		RewardForVideo = 11,
	}

	public enum Repeatability
	{
		Once = 0,
		OncePerVersion = 1,
		Forever = 2,
	}

	public enum Type
	{
		OpenURL = 0,
		VideoAd = 1,
		ClaimReward = 2,
	}

	private const string ONLINESETTINGS_VIDEOADS_DEFAULTREWARD_KEY = "videoads_defaultreward"; //Field offset: 0x0
	private static Action<Id, int> OnRewardURLOpened; //Field offset: 0x0
	public static readonly EarnCurrencyProfile[] profiles; //Field offset: 0x4

	public static event Action<Id, int> OnRewardURLOpened
	{
		 add { } //Length: 2
		 remove { } //Length: 206
	}

	private static bool isVideoAddsSupported
	{
		 get { } //Length: 168
	}

	private static EarnCoinsData() { }

	public static void add_OnRewardURLOpened(Action<Id, int> value) { }

	private static bool get_isVideoAddsSupported() { }

	public static int GetNumberOfDisplayedNonOfferEarners() { }

	public static void remove_OnRewardURLOpened(Action<Id, int> value) { }

	public static bool ShouldShowInGUI(int profileIndex) { }

	public static void Trigger(int profileIndex) { }

}

