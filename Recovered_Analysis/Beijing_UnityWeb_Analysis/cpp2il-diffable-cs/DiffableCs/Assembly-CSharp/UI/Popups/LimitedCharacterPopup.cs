namespace UI.Popups;

public class LimitedCharacterPopup : UIScreen
{
	private GameObject _characterAnchor; //Field offset: 0x28
	private UIWidget _coinBoxAnchor; //Field offset: 0x2C
	private UILabel _nameTitle; //Field offset: 0x30
	private UILabel _nameSubTitle; //Field offset: 0x34
	private UICharacterThemeShifter _characterThemeShifter; //Field offset: 0x38
	private TimerHelper _timerPrefab; //Field offset: 0x3C
	private UIWidget _timerParent; //Field offset: 0x40
	private TimerHelper _timer; //Field offset: 0x44
	private CharacterSelectButton _characterSelectButtonPrefab; //Field offset: 0x48
	private UIWidget _characterSelectButtonParent; //Field offset: 0x4C
	private CharacterSelectButton _characterSelectButton; //Field offset: 0x50
	private List<string> _boughtThemeNames; //Field offset: 0x54
	private bool _characterWasBought; //Field offset: 0x58

	public LimitedCharacterPopup() { }

	public override void GainFocus() { }

	private string GetStateString(bool state) { }

	private string GetThemeNameForAnalytics(Outfit theme) { }

	public override void Hide() { }

	private void HidePopupIfNeeded() { }

	public override void Init() { }

	private void InitializeSelectButton() { }

	private void InitializeTimer() { }

	private void LogFlurryEvent() { }

	public override void LoseFocus() { }

	private void OnCharacterUnlocked(CharacterId charId, int version) { }

	private void OnThemeButtonClicked(int index) { }

	public override void Show() { }

	private void UpdateCharacterSticker(CharacterId charId, int index) { }

	private void UpdateSelectedCharacter() { }

	private void UpdateThemeShifter(CharacterId charId, int index) { }

	private void UpdateUIElements() { }

}

