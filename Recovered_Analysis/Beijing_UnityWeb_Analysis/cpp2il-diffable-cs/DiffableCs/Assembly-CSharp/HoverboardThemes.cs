//Type is in global namespace

public class HoverboardThemes
{
	public class HoverboardTheme
	{
		public int price; //Field offset: 0x8
		public UnlockType unlockType; //Field offset: 0xC
		public Color32 buttonBgColor; //Field offset: 0x10
		public Color32 buttonIconColor; //Field offset: 0x14
		public bool isNewInThisUpdate; //Field offset: 0x18
		public string title; //Field offset: 0x1C
		public UIOrder uiOrder; //Field offset: 0x20
		public BoardAbility power; //Field offset: 0x24
		public ThemeIdentifier identifier; //Field offset: 0x28
		public string iconName; //Field offset: 0x2C

		public HoverboardTheme() { }

		public string GetAnalyticsReadablePowerName() { }

	}

	public enum ThemeIdentifier
	{
		none = 0,
		heroboardTheme01 = 1,
		heroboardTheme02 = 2,
		starboardTheme01 = 3,
		starboardTheme02 = 4,
		greatWhiteTheme01 = 5,
		greatWhiteTheme02 = 6,
		surfboardTheme01 = 7,
		surfboardTheme02 = 8,
		monsterTheme1 = 9,
		monsterTheme2 = 10,
		snowboardTheme1 = 11,
		snowboardTheme2 = 12,
		miamiTheme1 = 13,
		miamiTheme2 = 14,
		skullfireTheme1 = 15,
		romeTheme01 = 16,
		skullfireTheme02 = 17,
		lumberjackTheme01 = 18,
		lumberjackTheme02 = 19,
		romeTheme02 = 20,
		londonBoard01Theme01 = 21,
		londonBoard01Theme02 = 22,
		chicky01Theme01 = 23,
		chicky01Theme02 = 24,
		veniceBoard02Theme01 = 25,
		transylvaniaBoard01Theme01 = 26,
		sanfranciscoBoard01Theme01 = 27,
		arabiaBoard01Theme01 = 28,
		bangkokBoard01Theme01 = 29,
		cairoBoard02Theme01 = 30,
		cairoBoard02Theme02 = 31,
		starterPackBoard01Theme01 = 32,
		starterPackBoard01Theme02 = 33,
		mumbaiBoard02Theme01 = 34,
		mumbaiBoard02Theme02 = 35,
		hongKongBoard01Theme01 = 36,
	}

	public enum UIOrder
	{
		First = 0,
		Second = 1,
	}

	public static readonly Dictionary<BoardId, List<HoverboardTheme>> hoverboardCustomThemes; //Field offset: 0x0

	private static HoverboardThemes() { }

	public HoverboardThemes() { }

	public static string GetBoardPowerName(BoardId board, BoardAbility power) { }

	public static int GetIndexForTheme(BoardId boardId, ThemeIdentifier themeIdentifier) { }

	public static ThemeIdentifier GetThemeIdentifier(BoardId bId, int tIndex) { }

	public static List<HoverboardTheme> TryGetCustomThemesForBoard(BoardId boardId) { }

	private static void ValidateUIOrder(KeyValuePair<BoardId, List<HoverboardTheme>> themeSet) { }

	public static void VerifyData() { }

}

