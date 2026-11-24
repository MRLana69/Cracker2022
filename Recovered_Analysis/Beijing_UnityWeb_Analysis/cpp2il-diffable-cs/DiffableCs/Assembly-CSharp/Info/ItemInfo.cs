namespace Info;

public static class ItemInfo
{
	private sealed class <>c__DisplayClass10_0
	{
		public ThemeIdentifier themeIdentifier; //Field offset: 0x8

		public <>c__DisplayClass10_0() { }

		internal bool <GetItemTitleId>b__0(HoverboardTheme x) { }

	}

	public const int ItemAmountReceiveDefault = 1; //Field offset: 0x0
	private const string ItemTitleIdHoverboard = "hoverboard"; //Field offset: 0x0
	private const string ItemTitleIdHeadstart = "headstart"; //Field offset: 0x0
	private const string ItemTitleIdScorebooster = "scorebooster"; //Field offset: 0x0
	private static readonly string[] SKIP_MISSION_IDS; //Field offset: 0x0

	private static ItemInfo() { }

	public static string GetItemTitleId(UpgradeType upgradeType) { }

	public static string GetItemTitleId(Type boxType) { }

	public static string GetItemTitleId(CharacterId characterId, Outfit outfit = null) { }

	public static string GetItemTitleId(BoardId boardId) { }

	public static string GetItemTitleId(BoardId boardId, ThemeIdentifier themeIdentifier) { }

	public static string GetItemTitleId(BoardId boardId, HoverboardTheme boardTheme) { }

	public static string GetItemTitleId(ItemType itemType) { }

	public static string GetItemTitleId(BundleItem bundleItem) { }

	public static string GetSkipMissionItemTitleId(int missionIndex) { }

	public static bool TryGetItemTitleId(InAppItemModel item, out string itemTitleId) { }

}

