//Type is in global namespace

public class UICharacterThemeShifter : MonoBehaviour
{
	private const int MAX_NUMBER_OF_CUSTOM_THEMES = 3; //Field offset: 0x0
	private GameObject _defaultCharacterThemeButton; //Field offset: 0xC
	private GameObject _customCharacterThemeButton; //Field offset: 0x10
	private Transform _selectedMarker; //Field offset: 0x14
	private Vector3 _distanceBetweenButtons; //Field offset: 0x18
	private List<CharacterThemeButton> _customButtons; //Field offset: 0x24
	private Action<int> OnThemeButtonPressed; //Field offset: 0x28
	private int _activeTheme; //Field offset: 0x2C
	private CharacterId _cachedCharacter; //Field offset: 0x30
	private List<Outfit> _currentCharacterThemes; //Field offset: 0x34
	private Outfit[] _sortedOutfits; //Field offset: 0x38

	public event Action<int> OnThemeButtonPressed
	{
		 add { } //Length: 2
		 remove { } //Length: 111
	}

	public UICharacterThemeShifter() { }

	public void add_OnThemeButtonPressed(Action<int> value) { }

	private void Awake() { }

	public void InitValues(CharacterId charId, int index) { }

	public void MakeCustomThemesAvailable(List<Outfit> themes) { }

	private void OnDisable() { }

	public void remove_OnThemeButtonPressed(Action<int> value) { }

	private void SelectButton(int index) { }

	private void SetActiveBubbles(CharacterThemeButton btn, Outfit ot, CharacterId id, int index) { }

	private Outfit[] SortThemes(List<Outfit> themes) { }

	private void ThemeButtonPressed(int index) { }

	public void UpdateUIForCharacter(CharacterId charId, int outfitIndex) { }

}

