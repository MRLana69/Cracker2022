//Type is in global namespace

public class BoardScreenManager
{
	private static BoardScreenManager _instance; //Field offset: 0x0
	private bool <forceRefreshOnBoardScreen>k__BackingField; //Field offset: 0x8
	private bool <forceCenterOnSpecificBoard>k__BackingField; //Field offset: 0x9
	private bool <comingFromHoverboardCustomizationPopup>k__BackingField; //Field offset: 0xA
	private bool <willResetBoardAnimation>k__BackingField; //Field offset: 0xB
	private bool <shouldResetThemeSelection>k__BackingField; //Field offset: 0xC
	private bool <refreshBoardsWhenNotShowingPopup>k__BackingField; //Field offset: 0xD
	private BoardId <currentlyShownBoardId>k__BackingField; //Field offset: 0x10
	private int <currentlyShownThemeIndex>k__BackingField; //Field offset: 0x14

	public bool comingFromHoverboardCustomizationPopup
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public BoardId currentlyShownBoardId
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public int currentlyShownThemeIndex
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public bool forceCenterOnSpecificBoard
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public bool forceRefreshOnBoardScreen
	{
		 get { } //Length: 6
		 set { } //Length: 303
	}

	public static BoardScreenManager Instance
	{
		 get { } //Length: 306
	}

	public bool refreshBoardsWhenNotShowingPopup
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public bool shouldResetThemeSelection
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public bool willResetBoardAnimation
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	private static BoardScreenManager() { }

	private BoardScreenManager() { }

	public void ChangedDisplayedHoverboard(BoardId newBoard) { }

	public bool get_comingFromHoverboardCustomizationPopup() { }

	public BoardId get_currentlyShownBoardId() { }

	public int get_currentlyShownThemeIndex() { }

	public bool get_forceCenterOnSpecificBoard() { }

	public bool get_forceRefreshOnBoardScreen() { }

	public static BoardScreenManager get_Instance() { }

	public bool get_refreshBoardsWhenNotShowingPopup() { }

	public bool get_shouldResetThemeSelection() { }

	public bool get_willResetBoardAnimation() { }

	public void set_comingFromHoverboardCustomizationPopup(bool value) { }

	public void set_currentlyShownBoardId(BoardId value) { }

	public void set_currentlyShownThemeIndex(int value) { }

	public void set_forceCenterOnSpecificBoard(bool value) { }

	public void set_forceRefreshOnBoardScreen(bool value) { }

	public void set_refreshBoardsWhenNotShowingPopup(bool value) { }

	public void set_shouldResetThemeSelection(bool value) { }

	public void set_willResetBoardAnimation(bool value) { }

}

