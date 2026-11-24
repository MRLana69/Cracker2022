namespace SYBO.Components.Analytics.Integration;

public class AnalyticsHelper
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<char, bool> <>9__0_0; //Field offset: 0x4
		public static Func<char, bool> <>9__0_1; //Field offset: 0x8
		public static Func<char, bool> <>9__1_0; //Field offset: 0xC

		private static <>c() { }

		public <>c() { }

		internal bool <ContainsDigits>b__1_0(char c) { }

		internal bool <GetLocalCurrencyPriceAsFloat>b__0_0(char c) { }

		internal bool <GetLocalCurrencyPriceAsFloat>b__0_1(char c) { }

	}

	private static Dictionary<string, string> AndroidOsVersionByApiVersion; //Field offset: 0x0
	private static List<KeyValuePair<string, string>> AndroidApiVersionByOsVersion; //Field offset: 0x4

	private static AnalyticsHelper() { }

	public AnalyticsHelper() { }

	private static bool ContainsDigits(string text) { }

	public static ItemType ConvertFacebookRewardToItemType(FacebookRewardType rewardType) { }

	public static void ConvertRewardToItemAddedParameters(CelebrationReward reward, out ObtainableItemSource itemSource, out long sourceId, out string sourceMeta, out string itemTitleId, out ItemType itemType, out long itemBalanceAfter, out long itemDelta) { }

	public static string GetAndroidDeviceOsString(string deviceOs) { }

	private static string GetAndroidDeviceOsString(string osVersion, string apiVersion) { }

	private static string GetAndroidOsVersionFromApiVersion(string apiVersion) { }

	public static int GetItemBalance(ItemType itemType, CharacterId characterId = 2) { }

	public static int GetItemPayoutAmount(InAppItemModel item) { }

	public static float GetLocalCurrencyPriceAsFloat(string localPriceWithCurrency, ItemType itemType, string itemTitleId) { }

	public static string GetSyboAnalyticsMissionSetString() { }

	public static bool IsRewardAnUnpurchasedItem(CelebrationReward reward) { }

	private static bool IsVideoReward(CelebrationReward reward) { }

	private static string ValidateAndroidOsVersionFromApiVersion(string osVersion, string apiVersion) { }

}

