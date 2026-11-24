namespace InApp;

public static class InAppData
{
	private sealed class <GetAllWithItemAndOfferType>d__97 : IEnumerable<InAppItemModel>, IEnumerable, IEnumerator<InAppItemModel>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private InAppItemModel <>2__current; //Field offset: 0xC
		private int <>l__initialThreadId; //Field offset: 0x10
		private ItemType itemType; //Field offset: 0x14
		public ItemType <>3__itemType; //Field offset: 0x18
		private OfferType offerType; //Field offset: 0x1C
		public OfferType <>3__offerType; //Field offset: 0x20
		private Enumerator<string, InAppItemModel> <>7__wrap1; //Field offset: 0x24

		private InAppItemModel System.Collections.Generic.IEnumerator<InApp.InAppItemModel>.Current
		{
			 get { } //Length: 672
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <GetAllWithItemAndOfferType>d__97(int <>1__state) { }

		private void <>m__Finally1() { }

		private bool MoveNext() { }

		private IEnumerator<InAppItemModel> System.Collections.Generic.IEnumerable<InApp.InAppItemModel>.GetEnumerator() { }

		private InAppItemModel System.Collections.Generic.IEnumerator<InApp.InAppItemModel>.get_Current() { }

		private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	public enum BundleTier
	{
		None = 0,
		BundleTier1 = 1,
		BundleTier2 = 2,
		BundleTier3 = 3,
		BundleTier4 = 4,
		BundleTier5 = 5,
	}

	private const string IN_APP_PREFIX_DEFAULT = "com.kiloo.subwaysurfers."; //Field offset: 0x0
	public const string IN_APP_TIER2_5_SPECIAL_DISCOUNT = "com.kiloo.subwaysurfers.coinstier2.5specialdiscount"; //Field offset: 0x0
	public const string IN_APP_TIER3_SPECIAL_DISCOUNT = "com.kiloo.subwaysurfers.coinstier3specialdiscount"; //Field offset: 0x0
	public const string IN_APP_TIER5_SPECIAL_DISCOUNT = "com.kiloo.subwaysurfers.coinstier5specialdiscount"; //Field offset: 0x0
	public const string IN_APP_TIER6_SPECIAL_DISCOUNT = "com.kiloo.subwaysurfers.keystier1specialdiscount"; //Field offset: 0x0
	public const string IN_APP_TIER6_5_SPECIAL_DISCOUNT = "com.kiloo.subwaysurfers.keystier1.5specialdiscount"; //Field offset: 0x0
	public const string IN_APP_TIER7_SPECIAL_DISCOUNT = "com.kiloo.subwaysurfers.keystier2specialdiscount"; //Field offset: 0x0
	public const string IN_APP_TIER8_SPECIAL_DISCOUNT = "com.kiloo.subwaysurfers.keystier3specialdiscount"; //Field offset: 0x0
	public const string IN_APP_TIER9_SPECIAL_DISCOUNT = "com.kiloo.subwaysurfers.keystier4specialdiscount"; //Field offset: 0x0
	public const string IN_APP_DOUBLE_COINS = "com.kiloo.subwaysurfers.doublecoins"; //Field offset: 0x0
	public const string IN_APP_DOUBLE_COINS_DISCOUNT = "com.kiloo.subwaysurfers.doublecoinsdiscount"; //Field offset: 0x0
	public const string IN_APP_BUNDLE_TIER1 = "com.kiloo.subwaysurfers.bundletier1"; //Field offset: 0x0
	public const string IN_APP_BUNDLE_TIER2 = "com.kiloo.subwaysurfers.bundletier2"; //Field offset: 0x0
	public const string IN_APP_BUNDLE_TIER3 = "com.kiloo.subwaysurfers.bundletier3"; //Field offset: 0x0
	public const string IN_APP_BUNDLE_TIER4 = "com.kiloo.subwaysurfers.bundletier4"; //Field offset: 0x0
	public const string IN_APP_BUNDLE_TIER5 = "com.kiloo.subwaysurfers.bundletier5"; //Field offset: 0x0
	public const string IN_APP_AD_REMOVAL_TIER1 = "com.kiloo.subwaysurfers.adremovaltier1"; //Field offset: 0x0
	public const string IN_APP_AD_REMOVAL_TIER2 = "com.kiloo.subwaysurfers.adremovaltier2"; //Field offset: 0x0
	public const string IN_APP_AD_REMOVAL_TIER3 = "com.kiloo.subwaysurfers.adremovaltier3"; //Field offset: 0x0
	public const string IN_APP_AD_REMOVAL_TIER4 = "com.kiloo.subwaysurfers.adremovaltier4"; //Field offset: 0x0
	public const string IN_APP_CAIRO_BOARD_BUNDLE_TIER1 = "com.kiloo.subwayboard.cairoBoard02.bundletier1"; //Field offset: 0x0
	public const string IN_APP_CAIRO_BOARD_BUNDLE_TIER2 = "com.kiloo.subwayboard.cairoBoard02.bundletier2"; //Field offset: 0x0
	public const string IN_APP_MUMBAI_BOARD_BUNDLE_TIER1 = "com.kiloo.subwayboard.mumbai.bundletier1"; //Field offset: 0x0
	public const string IN_APP_MUMBAI_BOARD_BUNDLE_TIER2 = "com.kiloo.subwayboard.mumbai.bundletier2"; //Field offset: 0x0
	public const string IN_APP_CHICK_BOARD_BUNDLE_TIER1 = "com.kiloo.subwayboard.chick.bundletier1"; //Field offset: 0x0
	public const string IN_APP_CHICK_BOARD_BUNDLE_TIER2 = "com.kiloo.subwayboard.chick.bundletier2"; //Field offset: 0x0
	public const string IN_APP_WELCOME_PACK_TIER1 = "com.kiloo.subwaysurfers.welcomePackTier01"; //Field offset: 0x0
	public const string IN_APP_WELCOME_PACK_TIER2 = "com.kiloo.subwaysurfers.welcomePackTier02"; //Field offset: 0x0
	public const string IN_APP_TIER2_SPECIAL_DISCOUNT = "com.kiloo.subwaysurfers.coinstier2specialdiscount"; //Field offset: 0x0
	public const string IN_APP_TIER1_SPECIAL_DISCOUNT = "com.kiloo.subwaysurfers.coinstier1specialdiscount"; //Field offset: 0x0
	public const string IN_APP_TIER4_SPECIAL_DISCOUNT = "com.kiloo.subwaysurfers.coinstier4specialdiscount"; //Field offset: 0x0
	public const string IN_APP_TIER8_DISCOUNT = "com.kiloo.subwaysurfers.keystier3discount"; //Field offset: 0x0
	private const string IN_APP_CHARACTER_PREFIX = "com.kiloo.subwaycharacter."; //Field offset: 0x0
	public const string IN_APP_BOARD_PREFIX = "com.kiloo.subwayboard."; //Field offset: 0x0
	private const string IN_APP_PREFIX_IOS = "com.kiloo.subwaysurfers."; //Field offset: 0x0
	private const string IN_APP_PREFIX_ANDROID = "com.kiloo.subways."; //Field offset: 0x0
	public const string IN_APP_PREFIX = "com.kiloo.subwaysurfers."; //Field offset: 0x0
	private const bool IS_PURE_ANDROID = False; //Field offset: 0x0
	private const bool IS_IOS = True; //Field offset: 0x0
	private static readonly string[] IN_APP_PREFIXES; //Field offset: 0x0
	public const string IN_APP_TIER1 = "com.kiloo.subwaysurfers.coinstier1"; //Field offset: 0x0
	public const string IN_APP_TIER9_DISCOUNT = "com.kiloo.subwaysurfers.keystier4discount"; //Field offset: 0x0
	public const string IN_APP_TIER2_5 = "com.kiloo.subwaysurfers.coinstier2.5"; //Field offset: 0x0
	public const string IN_APP_TIER3 = "com.kiloo.subwaysurfers.coinstier3"; //Field offset: 0x0
	public const string IN_APP_TIER4 = "com.kiloo.subwaysurfers.coinstier4"; //Field offset: 0x0
	public const string IN_APP_TIER5 = "com.kiloo.subwaysurfers.coinstier5"; //Field offset: 0x0
	public const string IN_APP_TIER2 = "com.kiloo.subwaysurfers.coinstier2"; //Field offset: 0x0
	public const string IN_APP_TIER6_5 = "com.kiloo.subwaysurfers.keystier1.5"; //Field offset: 0x0
	public const string IN_APP_TIER7_DISCOUNT = "com.kiloo.subwaysurfers.keystier2discount"; //Field offset: 0x0
	public const string IN_APP_TIER6 = "com.kiloo.subwaysurfers.keystier1"; //Field offset: 0x0
	public const string IN_APP_TIER6_DISCOUNT = "com.kiloo.subwaysurfers.keystier1discount"; //Field offset: 0x0
	public const string IN_APP_TIER5_DISCOUNT = "com.kiloo.subwaysurfers.coinstier5discount"; //Field offset: 0x0
	public const string IN_APP_TIER4_DISCOUNT = "com.kiloo.subwaysurfers.coinstier4discount"; //Field offset: 0x0
	public const string IN_APP_TIER3_DISCOUNT = "com.kiloo.subwaysurfers.coinstier3discount"; //Field offset: 0x0
	public const string IN_APP_TIER6_5_DISCOUNT = "com.kiloo.subwaysurfers.keystier1.5discount"; //Field offset: 0x0
	public const string IN_APP_TIER2_DISCOUNT = "com.kiloo.subwaysurfers.coinstier2discount"; //Field offset: 0x0
	public const string IN_APP_TIER1_DISCOUNT = "com.kiloo.subwaysurfers.coinstier1discount"; //Field offset: 0x0
	public const string IN_APP_TIER2_5_DISCOUNT = "com.kiloo.subwaysurfers.coinstier2.5discount"; //Field offset: 0x0
	public const string IN_APP_TIER9 = "com.kiloo.subwaysurfers.keystier_4"; //Field offset: 0x0
	public const string IN_APP_TIER8 = "com.kiloo.subwaysurfers.keystier3"; //Field offset: 0x0
	public const string IN_APP_TIER7 = "com.kiloo.subwaysurfers.keystier2"; //Field offset: 0x0
	private static readonly string[] IN_APP_CURRENCY_TIERS; //Field offset: 0x4
	private static readonly string[] IN_APP_CURRENCY_DISCOUNT_TIERS; //Field offset: 0x8
	private static readonly string[] IN_APP_CURRENCY_SPECIAL_DISCOUNT_TIERS; //Field offset: 0xC
	private static readonly string[] IN_APP_AD_REMOVAL_TIERS; //Field offset: 0x10
	private static readonly string[] IN_APP_BUNDLE_TIERS; //Field offset: 0x14
	private static readonly string[] IN_APP_BOARD_BUNDLE_TIERS; //Field offset: 0x18
	private static readonly string[] inAppSpecialBundles; //Field offset: 0x1C
	private static readonly Dictionary<string, string> IN_APP_TIERS_ONLINE_SETTINGS_IDS; //Field offset: 0x20
	private static readonly Dictionary<string, string> IGNORED_IN_APP_TIERS_ONLINE_SETTINGS_IDS; //Field offset: 0x24
	public static readonly List<string> LIST_OF_MANAGED_INAPP_IDS; //Field offset: 0x28
	public static Dictionary<string, InAppItemModel> inAppData; //Field offset: 0x2C

	public static string commaSeparatedProductIds
	{
		 get { } //Length: 109
	}

	public static int inAppPurchaseCount
	{
		 get { } //Length: 89
	}

	private static InAppData() { }

	public static string ConvertBoardTypeToDynamicPurchaseId(BoardId boardId) { }

	public static string ConvertCharacterTypeToDynamicPurchaseId(CharacterId charId) { }

	public static string get_commaSeparatedProductIds() { }

	public static int get_inAppPurchaseCount() { }

	public static string[] GetAdRemovalTiers() { }

	public static string[] GetAllProductIds() { }

	public static IEnumerable<InAppItemModel> GetAllWithItemAndOfferType(ItemType itemType, OfferType offerType) { }

	public static string GetBundleId(BundleTier tier) { }

	public static string[] GetCurrencyDiscountTiers() { }

	public static string[] GetCurrencySpecialDiscountTiers() { }

	public static string[] GetCurrencyTiers() { }

	public static string GetDiscountIdForNormalOffer(string normalOffer) { }

	public static string GetIgnoredInAppOnlineSettingsId(string inAppId) { }

	public static string[] GetInAppBoardBundleTiers() { }

	public static string[] GetInAppBundleTiers() { }

	public static string GetInAppOnlineSettingsId(string inAppId) { }

	public static string[] GetInAppSpecialBundles() { }

	public static string GetSpecialDiscountIdForNormalOffer(string normalOffer) { }

	public static bool InappidIsDynamicLimitedBoardPurchase(string inappId) { }

	public static bool InappidIsDynamicLimitedCharacterPurchase(string inappId) { }

	private static bool IsUsingCustomIapIdForBoard(Board board) { }

	private static bool IsUsingCustomIapIdForCharacter(Model model) { }

	public static string OutputAllInapps() { }

	public static void PrintDynamicIdsForBoardTypeForAllPlatforms(BoardId boardId) { }

	public static void PrintDynamicIdsForCharacterTypeForAllPlatforms(CharacterId characterId) { }

	public static string StripProductPrefixes(string productID) { }

	public static bool TryConvertDynamicBoardIdToBoardType(string purchaseId, out BoardId boardReturned) { }

	public static bool TryConvertDynamicPurchaseIdToCharacterType(string purchaseId, out CharacterId charReturned) { }

}

