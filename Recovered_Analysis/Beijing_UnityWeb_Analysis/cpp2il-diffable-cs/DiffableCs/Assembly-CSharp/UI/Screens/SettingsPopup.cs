namespace UI.Screens;

public class SettingsPopup : UIScreen
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<GameObject> <>9__32_0; //Field offset: 0x4
		public static Action<UILabel> <>9__32_1; //Field offset: 0x8
		public static Action<UILabel> <>9__32_2; //Field offset: 0xC
		public static Action<GameObject> <>9__32_3; //Field offset: 0x10
		public static Action<UILabel> <>9__32_4; //Field offset: 0x14
		public static Action<UILabel> <>9__32_5; //Field offset: 0x18
		public static Action <>9__32_6; //Field offset: 0x1C
		public static Action<GameObject> <>9__32_7; //Field offset: 0x20
		public static Action<UILabel> <>9__32_8; //Field offset: 0x24
		public static Action<UILabel> <>9__32_9; //Field offset: 0x28
		public static Action <>9__32_10; //Field offset: 0x2C
		public static Action<GameObject> <>9__32_11; //Field offset: 0x30
		public static Action<UILabel> <>9__32_12; //Field offset: 0x34
		public static Action<UILabel> <>9__32_13; //Field offset: 0x38
		public static Action <>9__32_14; //Field offset: 0x3C
		public static Action<GameObject> <>9__32_15; //Field offset: 0x40
		public static Action<UILabel> <>9__32_16; //Field offset: 0x44
		public static Action<UILabel> <>9__32_17; //Field offset: 0x48

		private static <>c() { }

		public <>c() { }

		internal void <LoadAllButtons>b__32_0(GameObject go) { }

		internal void <LoadAllButtons>b__32_1(UILabel label) { }

		internal void <LoadAllButtons>b__32_10() { }

		internal void <LoadAllButtons>b__32_11(GameObject go) { }

		internal void <LoadAllButtons>b__32_12(UILabel label) { }

		internal void <LoadAllButtons>b__32_13(UILabel desc) { }

		internal void <LoadAllButtons>b__32_14() { }

		internal void <LoadAllButtons>b__32_15(GameObject go) { }

		internal void <LoadAllButtons>b__32_16(UILabel label) { }

		internal void <LoadAllButtons>b__32_17(UILabel desc) { }

		internal void <LoadAllButtons>b__32_2(UILabel desc) { }

		internal void <LoadAllButtons>b__32_3(GameObject go) { }

		internal void <LoadAllButtons>b__32_4(UILabel label) { }

		internal void <LoadAllButtons>b__32_5(UILabel desc) { }

		internal void <LoadAllButtons>b__32_6() { }

		internal void <LoadAllButtons>b__32_7(GameObject go) { }

		internal void <LoadAllButtons>b__32_8(UILabel label) { }

		internal void <LoadAllButtons>b__32_9(UILabel desc) { }

	}

	private sealed class <>c__DisplayClass33_0
	{
		public bool tutorialCompleted; //Field offset: 0x8

		public <>c__DisplayClass33_0() { }

		internal void <Show>b__0(UISprite s) { }

	}

	private const int POPUP_PARENT_POSITION_TUTORIAL_OFFSET = 30; //Field offset: 0x0
	private const int POPUP_PARENT_POSITION_TUTORIAL = -90; //Field offset: 0x0
	private const int BACKGROUND_FILL_HEIGHT_TUTORIAL = 310; //Field offset: 0x0
	private const int POPUP_PARENT_POSITION_NORMAL = -30; //Field offset: 0x0
	private const int BACKGROUND_FILL_HEIGHT_NORMAL = 423; //Field offset: 0x0
	private const int BACKGROUND_FILL_HEIGHT_TUTORIAL_OFFSET = 60; //Field offset: 0x0
	private Transform _fillParent; //Field offset: 0x28
	private UISprite _fill; //Field offset: 0x2C
	private UISprite _outline; //Field offset: 0x30
	private VerticalLayout _layout; //Field offset: 0x34
	private UILabel _titleLabel; //Field offset: 0x38
	private UILabel _version; //Field offset: 0x3C
	private UILabel _contactInfo; //Field offset: 0x40
	public UIScrollView _scrollView; //Field offset: 0x44
	private GameObject _debugButton; //Field offset: 0x48
	private SettingsButton _settingsButtonPrefab; //Field offset: 0x4C
	private SettingsLogInFacebookButton _facebookLoginButtonPrefab; //Field offset: 0x50
	private UISprite _settingsDividerPrefab; //Field offset: 0x54
	public UIScrollBar scrollbar; //Field offset: 0x58
	private SettingsButton _topRunChallengersButton; //Field offset: 0x5C
	private SettingsButton _facebookLogoutButton; //Field offset: 0x60
	private SettingsLogInFacebookButton _facebookLoginButton; //Field offset: 0x64
	private SettingsButton _reminderButton; //Field offset: 0x68
	private SettingsButton _supportButton; //Field offset: 0x6C
	private SettingsButton _languageSelectionButton; //Field offset: 0x70
	private SettingsButton _withdrawConsentButton; //Field offset: 0x74
	private SettingsButton _onlineSaveButton; //Field offset: 0x78
	private List<UISprite> _extraDividers; //Field offset: 0x7C

	public SettingsPopup() { }

	private UISprite AddDivider() { }

	public void ConnectedToFacebook() { }

	public override void GainFocus() { }

	public override void Hide() { }

	public override void Init() { }

	private void LoadAllButtons() { }

	public void LoggedOutOfFacebook() { }

	private void SetupBasic() { }

	public override void Show() { }

	private void UpdatePopupDimension(bool tutorialCompleted) { }

}

