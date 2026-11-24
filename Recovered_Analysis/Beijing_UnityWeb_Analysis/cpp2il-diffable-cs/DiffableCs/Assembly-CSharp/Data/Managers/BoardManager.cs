namespace Data.Managers;

public static class BoardManager
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<KeyValuePair<ThemeIdentifier, BoardThemeData>, bool> <>9__36_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal bool <HasAllThemesBeenSeen>b__36_0(KeyValuePair<ThemeIdentifier, BoardThemeData> t) { }

	}

	public enum ScreenContext
	{
		BoardScreen = 0,
		LimitedBoardPopup = 1,
		BoardPromotionPopup = 2,
	}

	private static readonly CultureInfo ONLINESETTINGS_DATETIME_CULTUREINFO; //Field offset: 0x0
	public const int MAX_THEMES_PER_BOARD = 2; //Field offset: 0x0
	private static bool[] _displayCustomSets; //Field offset: 0x4
	private static Action boardSelected; //Field offset: 0x8
	private static Action<BoardAbility> themeActiveStateChanged; //Field offset: 0xC
	private static Action<BoardId> boardUnlocked; //Field offset: 0x10

	public static event Action boardSelected
	{
		 add { } //Length: 111
		 remove { } //Length: 209
	}

	public static event Action<BoardId> boardUnlocked
	{
		 add { } //Length: 120
		 remove { } //Length: 209
	}

	public static event Action<BoardAbility> themeActiveStateChanged
	{
		 add { } //Length: 209
		 remove { } //Length: 209
	}

	private static BoardManager() { }

	public static void add_boardSelected(Action value) { }

	public static void add_boardUnlocked(Action<BoardId> value) { }

	public static void add_themeActiveStateChanged(Action<BoardAbility> value) { }

	public static bool AreAllNewThemesSeenForBoard(BoardId boardId) { }

	public static DateTime BoardExpirationDate(BoardId boardId) { }

	public static TimeSpan BoardExpirationTimespan(BoardId boardId) { }

	public static DateTime BoardStartAvailabilityDate(BoardId boardId) { }

	public static void ChangeThemeActiveState(ScreenContext context, BoardAbility boardAbility = 0) { }

	public static int CountBoardThemesUnlocked() { }

	private static DateTime DefaultExpirationDateForHoverboard(BoardId bId) { }

	public static void DisplayCustomSet(int themeIndex, bool display) { }

	public static bool DoesBoardHaveThemes(BoardId boardId) { }

	public static BoardId GetCurrentlyShownBoard(ScreenContext context) { }

	public static int GetCurrentlyShownHoverboardTheme(ScreenContext context) { }

	public static Nullable<BoardId> GetEventBoardType() { }

	public static bool HasAllThemesBeenSeen(BoardId boardId) { }

	public static bool HasBoardBeenSeen(BoardId boardId) { }

	public static bool HasThemeBeenSeen(BoardId boardId, ThemeIdentifier themeId) { }

	public static bool IsBoardActive(BoardId boardId) { }

	public static bool IsBoardDisabled(BoardId boardId) { }

	public static bool IsBoardEventLimitedExpiredBoard(BoardId boardId) { }

	public static bool IsBoardOwned(BoardId boardId) { }

	public static bool IsBoardTrySpecialPowerBoard(BoardId boardId) { }

	public static bool IsBoardUnlocked(BoardId boardId) { }

	public static bool IsCustomSetEquippedForBoard(BoardId boardId, int themeIndex) { }

	public static bool IsThemeActive(BoardId boardId, ThemeIdentifier themeId) { }

	private static bool IsThemeActiveForUIIndex(BoardId board, int uiIndex) { }

	public static bool IsThemeOwned(BoardId boardId, ThemeIdentifier themeId) { }

	public static void LockBoard(BoardId boardId) { }

	public static void MarkHoverboardAsSeen(BoardId boardId) { }

	public static void remove_boardSelected(Action value) { }

	public static void remove_boardUnlocked(Action<BoardId> value) { }

	public static void remove_themeActiveStateChanged(Action<BoardAbility> value) { }

	public static void ResetDisplayedCustomSets(BoardId newBoard) { }

	public static void SelectCurrentlyShownBoard(ScreenContext context) { }

	public static void SetThemeAcquired(BoardId boardId, ThemeIdentifier themeId) { }

	public static void SetThemeActive(BoardId boardId, ThemeIdentifier themeId, bool active) { }

	public static void SetThemeSeen(BoardId boardId, ThemeIdentifier themeId) { }

	public static bool ShouldCustomSetBeDisplayed(int themeIndex) { }

	public static void UnlockBoard(BoardId boardId) { }

}

