public class BoardScreenManager
{
	private static BoardScreenManager _instance;

	private Hoverboards.BoardType currentlyShownBoard__BackingField;

	public Hoverboards.BoardType current = Hoverboards.BoardType.cherry;

	public static BoardScreenManager Instance
	{
		get
		{
			if (_instance == null)
			{
				BoardScreenManager boardScreenManager = default;
				boardScreenManager.current = Hoverboards.BoardType.cherry;
				_instance = boardScreenManager;
			}
			return _instance;
		}
	}

	public bool forceRefreshOnBoardScreen
	{
		get
		{
			return field;
		}
		set
		{
			field = value;
		}
	}

	public bool forceCenterOnSpecificBoard
	{
		get
		{
			return field;
		}
		set
		{
			field = value;
		}
	}

	public bool comingFromHoverboardCustomizationPopup
	{
		get
		{
			return field;
		}
		set
		{
			field = value;
		}
	}

	public bool willResetBoardAnimation
	{
		get
		{
			return field;
		}
		set
		{
			field = value;
		}
	}

	public bool shouldResetThemeSelection
	{
		get
		{
			return field;
		}
		set
		{
			field = value;
		}
	}

	public bool refreshBoardsWhenNotShowingPopup
	{
		get
		{
			return field;
		}
		set
		{
			field = value;
		}
	}

	public Hoverboards.BoardType currentlyShownBoard
	{
		get
		{
			return currentlyShownBoard__BackingField;
		}
		set
		{
			currentlyShownBoard__BackingField = value;
		}
	}

	public int currentlyShownThemeIndex
	{
		get
		{
			return field;
		}
		set
		{
			field = value;
		}
	}

	private BoardScreenManager()
	{
	}

	public void ChangedDisplayedHoverboard(Hoverboards.BoardType newBoard)
	{
		currentlyShownBoard__BackingField = newBoard;
		HoverboardManager instance = HoverboardManager.Instance;
		instance.ResetDisplayedCustomSets(newBoard);
	}
}
