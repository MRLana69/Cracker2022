//Type is in global namespace

public class UIHoverboardThemeShifter : MonoBehaviour
{
	private const int MAX_NUMBER_OF_CUSTOM_THEMES = 3; //Field offset: 0x0
	private GameObject _defaultHoverboardThemeButton; //Field offset: 0xC
	private GameObject _customHoverboardThemeButton; //Field offset: 0x10
	private Transform _selectedMarker; //Field offset: 0x14
	private Vector3 _distanceBetweenButtons; //Field offset: 0x18
	private List<HoverboardThemeButton> _customButtons; //Field offset: 0x24
	private Action<int> OnClickedTheme; //Field offset: 0x28
	private BoardId _cachedBoard; //Field offset: 0x2C
	private int _cachedThemeIndex; //Field offset: 0x30
	private List<HoverboardTheme> _currentBoardThemes; //Field offset: 0x34
	private HoverboardTheme[] _sortedThemes; //Field offset: 0x38
	private ScreenContext _context; //Field offset: 0x3C

	public event Action<int> OnClickedTheme
	{
		 add { } //Length: 14
		 remove { } //Length: 111
	}

	public UIHoverboardThemeShifter() { }

	public void add_OnClickedTheme(Action<int> value) { }

	private void Awake() { }

	public void ClickedTheme(int index) { }

	public void DisableThemeShifter() { }

	public void Init(ScreenContext context) { }

	public void MakeCustomThemesAvailable(List<HoverboardTheme> themes) { }

	private void OnDisable() { }

	public void remove_OnClickedTheme(Action<int> value) { }

	public void ResetThemeSelection() { }

	private void SetActiveBubbles(HoverboardThemeButton btn, HoverboardTheme ht, BoardId boardId, int index, int themeCount) { }

	private HoverboardTheme[] SortThemes(List<HoverboardTheme> themes) { }

	private void UpdateSelector(int index) { }

	public void UpdateThemeStates() { }

}

