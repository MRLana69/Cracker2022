namespace UI.Screens;

public class CharacterNameEventPopup : UIScreen
{
	private sealed class <>c__DisplayClass74_0
	{
		public CharacterId characterId; //Field offset: 0x8
		public CharacterNameEventPopup <>4__this; //Field offset: 0xC
		public int focusedIndex; //Field offset: 0x10

		public <>c__DisplayClass74_0() { }

		internal void <InsertCharacterIntoModelsList>b__0(CharacterScreenController currentCharacterModelController) { }

	}

	private sealed class <AnimateCharacter>d__91 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public CharacterScreenController characterController; //Field offset: 0x10
		public float speedFactor; //Field offset: 0x14
		public float freezeStart; //Field offset: 0x18
		public float freezeEnd; //Field offset: 0x1C
		public float scaleStartValue; //Field offset: 0x20
		public float scaleEndValue; //Field offset: 0x24
		public float positionStartValue; //Field offset: 0x28
		public float positionEndValue; //Field offset: 0x2C
		private float <animationLerpFactor>5__2; //Field offset: 0x30
		private Transform <characterModelTrans>5__3; //Field offset: 0x34
		private Vector3 <characterModelPosition>5__4; //Field offset: 0x38

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 622
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <AnimateCharacter>d__91(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <AnimateScrollBar>d__90 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public CharacterNameEventPopup <>4__this; //Field offset: 0x10
		public float amount; //Field offset: 0x14
		public HorizontalScrollDirections direction; //Field offset: 0x18
		public float speedFactor; //Field offset: 0x1C
		private float <animationLerpFactor>5__2; //Field offset: 0x20
		private Transform <characterScrollTrans>5__3; //Field offset: 0x24
		private Vector3 <characterScrollLocalPosition>5__4; //Field offset: 0x28
		private float <startValue>5__5; //Field offset: 0x34
		private float <endValue>5__6; //Field offset: 0x38

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 462
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <AnimateScrollBar>d__90(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <DelayPositioning>d__77 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public UISprite tracker; //Field offset: 0x10
		public GameObject objectToPosition; //Field offset: 0x14
		public Vector3 positionOffset; //Field offset: 0x18
		public Vector3 newRotation; //Field offset: 0x24
		public Vector3 newScale; //Field offset: 0x30

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 951
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <DelayPositioning>d__77(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private enum HorizontalScrollDirections
	{
		left = -1,
		right = 1,
	}

	private const float DEFAULT_Y_POSITION_ON_SCROLL = 0; //Field offset: 0x0
	private const float DEFAULT_SCALE_FACTOR = 9.3; //Field offset: 0x0
	private const float FOCUSED_Y_POSITION_ON_SCROLL = -9; //Field offset: 0x0
	private const float DEFAULT_FREEZE_VALUE = 1; //Field offset: 0x0
	private const float FOCUSED_FREEZE_VALUE = 0; //Field offset: 0x0
	private const float ANIMATION_SPEED_FACTOR = 2; //Field offset: 0x0
	private const float SPACING_BETWEEN_CHARACTERS = 77; //Field offset: 0x0
	private const string ONLINESETTINGS_ALLOW_SKIP_WITH_ADS_KEY = "character_name_event_skip_with_ads"; //Field offset: 0x0
	private const bool DEFAULT_ALLOW_SKIP_WITH_ADS = True; //Field offset: 0x0
	private const string ONLINE_SETTING_EVENT_ELEMENT_NEW_POSITION_OFFSET = "event_popup_element_new_position_offset"; //Field offset: 0x0
	private const string ONLINE_SETTING_EVENT_ELEMENT_NEW_ROTATION = "event_popup_element_new_rotation"; //Field offset: 0x0
	private const string ONLINE_SETTING_EVENT_ELEMENT_NEW_SCALE = "event_popup_element_new_scale"; //Field offset: 0x0
	private const float FOCUSED_SCALE_FACTOR = 13; //Field offset: 0x0
	private UIWidget outline; //Field offset: 0x28
	private GameObject characterScrollAnchor; //Field offset: 0x2C
	private GameObject _categoryModelAnchor; //Field offset: 0x30
	private GameObject skipWithKeysButtonWidget; //Field offset: 0x34
	private GameObject skipWithAdButtonWidget; //Field offset: 0x38
	private GameObject completeSignWidget; //Field offset: 0x3C
	private GameObject centerAnchor; //Field offset: 0x40
	private GameObject overlayClipAnchor; //Field offset: 0x44
	private GameObject selectButtonPrefab; //Field offset: 0x48
	private GameObject eventDescriptionBox; //Field offset: 0x4C
	private UILabel eventDescriptionBoxName; //Field offset: 0x50
	private GameObject eventDescriptionBoxActive; //Field offset: 0x54
	private UILabel eventDescriptionBoxTitleInactive; //Field offset: 0x58
	private UILabel eventDescriptionTitleActive; //Field offset: 0x5C
	private UILabel eventDescriptionBoxNameActive; //Field offset: 0x60
	private UILabel eventDescriptionBoxNameActiveShadow; //Field offset: 0x64
	private UILabel firstTitle; //Field offset: 0x68
	private UILabel secondTitle; //Field offset: 0x6C
	private UILabel skipButtonKeyAmount; //Field offset: 0x70
	private GameObject _lpModelPrefab; //Field offset: 0x74
	private UISprite _topSplatSprite; //Field offset: 0x78
	private GameObject _superMysteryBoxIcon; //Field offset: 0x7C
	private GameObject _movieIcon; //Field offset: 0x80
	private GameObject _danceIcon; //Field offset: 0x84
	private TimerHelper _timerPrefab; //Field offset: 0x88
	private UIWidget _timerContainer; //Field offset: 0x8C
	private TimerHelper _timer; //Field offset: 0x90
	private GameObject _lpModel; //Field offset: 0x94
	private List<KeyValuePair<CharacterId, CharacterScreenController>> _characterControllers; //Field offset: 0x98
	private int _scrollPopulationStartFromSlot; //Field offset: 0x9C
	private int _currentlyFocusedIndex; //Field offset: 0xA0
	private bool _isFirstFocused; //Field offset: 0xA4
	private bool _isLastFocused; //Field offset: 0xA5
	private CharacterNameEventManager _characterNameEventManager; //Field offset: 0xA8
	private CharacterSelectButton _selectButton; //Field offset: 0xAC
	private BoxCollider _skipWithKeysButtonCollider; //Field offset: 0xB0
	private BoxCollider _skipWithAdButtonCollider; //Field offset: 0xB4
	private readonly Vector3 LP_POSITION_OFFSET; //Field offset: 0xB8
	private readonly Vector3 LP_ROTATION; //Field offset: 0xC4
	private readonly Vector3 LP_SCALE; //Field offset: 0xD0
	private readonly Color32 _timerBackgroundColor; //Field offset: 0xDC
	private readonly Color32 _timerContentColor; //Field offset: 0xE0

	private bool isAllowedToSkipWithAds
	{
		 get { } //Length: 43
	}

	public CharacterNameEventPopup() { }

	private IEnumerator AnimateCharacter(CharacterScreenController characterController, float scaleStartValue, float scaleEndValue, float positionStartValue, float positionEndValue, float freezeStart, float freezeEnd, float speedFactor) { }

	private IEnumerator AnimateScrollBar(HorizontalScrollDirections direction, float amount, float speedFactor) { }

	private void ClearScrollListOfCharacters() { }

	private void CreateAndPositionLP3DElements() { }

	private IEnumerator DelayPositioning(UISprite tracker, GameObject objectToPosition, Vector3 positionOffset, Vector3 newRotation, Vector3 newScale) { }

	private void EnableUIElementsForList() { }

	public override void GainFocus() { }

	private bool get_isAllowedToSkipWithAds() { }

	public override void Hide() { }

	public void HidePopupIfNeeded() { }

	public override void Init() { }

	private void InitCategorySpecificElements() { }

	private void InitializeSelectButton() { }

	private void InitializeTimer() { }

	private void InitScrollWithCharacterModels() { }

	private void InsertCharacterIntoModelsList(CharacterId characterId, int focusedIndex) { }

	private bool IsFilteredCharacter(char newChar) { }

	public override void LoseFocus() { }

	private void OnSelectCharacter() { }

	public void OnSkipClicked() { }

	public void OnSkipWithAdClicked() { }

	private void OnSkipWithAdSuccessful() { }

	private void PositionModelOnSprite(UISprite tracker, GameObject objectToPosition, Vector3 positionOffset, Vector3 newRotation, Vector3 newScale) { }

	private void RefreshDescriptionBox() { }

	private void ReloadSelectButton(CharacterId charId, int themeIndex) { }

	private void ScrollListTo(int currentCharacterIndex) { }

	private void ScrollToNextCharacter() { }

	private void SetActiveCharacterBox(string descriptionLine1, string descriptionLine2) { }

	private void SetActiveCharacterNameEventManager() { }

	private void SetActiveIfExists(GameObject go, bool state) { }

	private void SetInactiveCharacterBox(string descriptionLine1, string descriptionLine2) { }

	private void SetSkipButtonCollidersEnabled(bool state) { }

	public override void Show() { }

	private void StartTimer() { }

	private void StopTimer() { }

	private void UpdateSkipButtonState() { }

	private Vector3 VerifySettingOnline(string key, Vector3 defaultVal) { }

}

