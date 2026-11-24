namespace UI.Popups;

public class LimitedBoardPopup : UIScreen
{
	private const bool ALLOW_SIGNATURE_ANIMATIONS = False; //Field offset: 0x0
	private GameObject _modelAnchor; //Field offset: 0x28
	private UILabel _nameLabel; //Field offset: 0x2C
	private UILabel _staticPowerupLabel; //Field offset: 0x30
	private UILabel _descriptionLabel; //Field offset: 0x34
	private UISprite _powerIcon; //Field offset: 0x38
	private UILabel _themeLimitedLabel; //Field offset: 0x3C
	private GameObject _themePower; //Field offset: 0x40
	private UILabel _themePowerLabel; //Field offset: 0x44
	private UIWidget _coinBoxAnchor; //Field offset: 0x48
	private UIHoverboardThemeShifter _hoverboardThemeShifter; //Field offset: 0x4C
	private BoardSelectButton _boardSelectButtonPrefab; //Field offset: 0x50
	private UIWidget _boardSelectButtonParent; //Field offset: 0x54
	private BoardSelectButton _boardSelectButton; //Field offset: 0x58
	private TimerHelper _timerPrefab; //Field offset: 0x5C
	private UIWidget _timerParent; //Field offset: 0x60
	private TimerHelper _timer; //Field offset: 0x64

	public LimitedBoardPopup() { }

	private void BoardUnlocked(BoardId boardId) { }

	public override void GainFocus() { }

	private string GetStateString(bool state) { }

	public override void Hide() { }

	private void HidePopupIfNeeded() { }

	public override void Init() { }

	private void InitializeSelectButton() { }

	private void InitializeTimer() { }

	private static void Log(string msg, Object context = null) { }

	private static void LogError(string msg, Object context = null) { }

	private void LogFlurryEvent() { }

	private static void LogWarning(string msg, Object context = null) { }

	public override void LoseFocus() { }

	private void OnThemeActiveStateChanged(BoardAbility boardAbility) { }

	private void SetupThemeShifter() { }

	public override void Show() { }

	private void ShowHoverboardInMenu(bool willUpdateAnimation, bool willAllowSignatureAnimation, BoardAbility ability = 0) { }

	private void ThemeButtonClicked(int index) { }

	private void UpdateDisplayedModelWithTheme(BoardId boardId, int themeIndex) { }

	private void UpdateThemeShifter() { }

	private void UpdateUIElements() { }

}

