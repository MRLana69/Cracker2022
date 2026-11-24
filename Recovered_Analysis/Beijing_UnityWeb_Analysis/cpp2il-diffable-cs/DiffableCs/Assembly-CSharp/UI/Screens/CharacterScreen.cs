namespace UI.Screens;

public class CharacterScreen : UIScreen
{
	private sealed class <DelayedInitCenterChar>d__63 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public CharacterScreen <>4__this; //Field offset: 0x10

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 132
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <DelayedInitCenterChar>d__63(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <EnableCamerasDelayed>d__59 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public CharacterScreen <>4__this; //Field offset: 0x10

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 193
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <EnableCamerasDelayed>d__59(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	public class RibbonPayload
	{
		public bool shouldShow; //Field offset: 0x8
		public string line1; //Field offset: 0xC
		public string line2; //Field offset: 0x10
		public string line3; //Field offset: 0x14

		public RibbonPayload() { }

	}

	private const int SCROLL_CHARACTER_VISIBILITY_COUNT = 4; //Field offset: 0x0
	private const CharacterId DEFAULT_CHARACTER_TO_CENTER = 0; //Field offset: 0x0
	private const string CHARACTER_SCREEN_DEBUG_LOG_TAG = "Character Screen: "; //Field offset: 0x0
	private const float SCALE_MODEL_MAX_DISTANCE_FACTOR = 1.5; //Field offset: 0x0
	private const int SYNCHRONOUSLY_LOADED_MODELS = 5; //Field offset: 0x0
	private const int SCALE_MODEL_COUNT = 4; //Field offset: 0x0
	private const int SCROLL_CHARACTER_LOADED_RANGE = 4; //Field offset: 0x0
	public const float FOCUSED_SCALE_FACTOR = 10; //Field offset: 0x0
	public const float DEFAULT_SCALE_FACTOR = 7; //Field offset: 0x0
	public static bool forceRefreshOnCharacterScreen; //Field offset: 0x0
	public static bool forceCenterOnEventCharacter; //Field offset: 0x1
	public static bool forceCenterOnCurrentlySelectedCharacter; //Field offset: 0x2
	private static readonly Vector3 SELECT_BUTTON_POSITION; //Field offset: 0x4
	private UIGrid _characterGrid; //Field offset: 0x28
	private UIPanel _scrollPanel; //Field offset: 0x2C
	private GameObject _scrollPlaceholderPrefab; //Field offset: 0x30
	private UILabel _nameTitle; //Field offset: 0x34
	private UILabel _nameSubtitle; //Field offset: 0x38
	private GameObject _eventRibbon; //Field offset: 0x3C
	private UILabel[] _ribbonLabels; //Field offset: 0x40
	private AudioClip _selectSound; //Field offset: 0x44
	private UICharacterThemeShifter _characterThemeShifter; //Field offset: 0x48
	private GameObject _characterDayParticleSystem; //Field offset: 0x4C
	private GameObject _characterSelectButtonPrefab; //Field offset: 0x50
	private GameObject _centerAnchor; //Field offset: 0x54
	private TimerHelper _timerPrefab; //Field offset: 0x58
	private UIWidget _timerContainer; //Field offset: 0x5C
	private GameObject _scrollListParent; //Field offset: 0x60
	public readonly Vector3 scrollCharacterPosition; //Field offset: 0x64
	public readonly Vector3 scrollCharacterRotation; //Field offset: 0x70
	private CharacterId _initiallyCenteredCharacterId; //Field offset: 0x7C
	private List<KeyValuePair<CharacterId, Model>> _characterList; //Field offset: 0x80
	public CharacterListManager _characterListManager; //Field offset: 0x84
	private CharacterSelectButton _characterSelectButton; //Field offset: 0x88
	public CharacterScreenManager _screenManagerInstance; //Field offset: 0x8C
	private float _cellWidth; //Field offset: 0x90
	private bool _hasShownModel; //Field offset: 0x94
	private SSEventType _cachedActiveEventType; //Field offset: 0x98
	private long _cachedActiveEventID; //Field offset: 0xA0
	private bool _inappOverlayActive; //Field offset: 0xA8
	private bool _popupActive; //Field offset: 0xA9
	private bool _charactersEnabled; //Field offset: 0xAA
	private bool _firstShow; //Field offset: 0xAB
	private bool _hasInited; //Field offset: 0xAC
	private TimerHelper _timer; //Field offset: 0xB0
	private CenterOnChild _centerer; //Field offset: 0xB4
	private bool _scrollListInitialized; //Field offset: 0xB8
	private bool _initialCenteredCharacterSelected; //Field offset: 0xB9
	public int _cachedCenteredIndex; //Field offset: 0xBC
	private bool _hasSetiPhoneXOffsetsIfNecessary; //Field offset: 0xC0

	public CharacterId initiallyCenteredCharacter
	{
		 get { } //Length: 93
		private set { } //Length: 312
	}

	private static CharacterScreen() { }

	public CharacterScreen() { }

	public bool AreCharactersEnabled() { }

	private bool CacheActiveEventType() { }

	public void CenterScrollOnCharacterType(CharacterId charId) { }

	public void ChangeCurrentlyShownCharacter(CharacterId charId, int index) { }

	private void CharacterEventFinished() { }

	private void CharacterEventStarted() { }

	private void ClearScrollList() { }

	private IEnumerator DelayedInitCenterChar() { }

	private bool DetectChangeInCharacterList() { }

	private IEnumerator EnableCamerasDelayed() { }

	public CharacterId get_initiallyCenteredCharacter() { }

	public int GetAmountOfSyncModelsLoaded() { }

	private int GetCenteredSlotIndex() { }

	private int GetCenterIndex() { }

	public int GetCharacterLoadRange() { }

	public int GetCharacterVisibilityCount() { }

	public override void Hide() { }

	public override void Init() { }

	private void InitializeCentererIfNeeded() { }

	private void InitializeScrollList() { }

	private void InitializeSelectButton() { }

	private void InitializeTimer() { }

	private static void Log(string msg, Object context = null) { }

	private static void LogError(string msg, Object context = null) { }

	private static void LogWarning(string msg, Object context = null) { }

	private void OnCharacterUnlocked(CharacterId charId, int version) { }

	public void OnInitialModelLoadingComplete() { }

	private void OnLastPopupClosed() { }

	private void OnPopupShown(string popupName) { }

	public void OnSingleModelLoaded(CharacterId characterId) { }

	private void OnThemeButtonClicked(int index) { }

	private void RefreshCharacterListIfNeeded() { }

	private void RefreshCharacterModelInScrollList(CharacterId charId, int themeIndex) { }

	private void RefreshCharacterScreen() { }

	private void RefreshScrollListUiOverlay(int centerIndex) { }

	public void ScaleScrollModels(bool forceScaleSingleCharacter = false, int scrollIndex = 0) { }

	public void ScrollClicked(Vector2 pos) { }

	private void SelectInitialCenteredCharacter() { }

	private void set_initiallyCenteredCharacter(CharacterId value) { }

	private void SetEventRibbonActive() { }

	private void SetRibbonInfo(RibbonPayload payload) { }

	private bool ShouldEnableCharacterDayParticleSystem() { }

	public override void Show() { }

	private void ShowTimer(bool showTimer, TimeSpan timeLeft) { }

	private void Update() { }

	private void UpdateCharacterModelsState() { }

	private void UpdateCharacterSticker(CharacterId charId, int index) { }

	private void UpdateSelectedCharacter() { }

	public void UpdateThemeShifter(CharacterId charId, int index) { }

	public void UpdateUIElements() { }

	private void VerifyCharacterAmount() { }

}

