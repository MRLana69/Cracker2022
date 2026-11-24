//Type is in global namespace

public class SSEventsPopup : UIScreen
{
	private sealed class <>c__DisplayClass71_0
	{
		public SSEventType activeEventType; //Field offset: 0x8

		public <>c__DisplayClass71_0() { }

		internal bool <PresentCurrentEventAvailable>b__0(EventTypeGameObjectPair pair) { }

	}

	private sealed class <>c__DisplayClass76_0
	{
		public SSEventsPopup <>4__this; //Field offset: 0x8
		public Nullable<CharacterId> eventCharacterId; //Field offset: 0xC
		public SSEventType eventType; //Field offset: 0x14

		public <>c__DisplayClass76_0() { }

		internal void <AddLimitedCharacter3DElements>b__0(GameObject lC) { }

	}

	private sealed class <DelayPositioning>d__85 : IEnumerator<object>, IEnumerator, IDisposable
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

		public <DelayPositioning>d__85(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private class EventTypeGameObjectPair
	{
		public SSEventType _eventType; //Field offset: 0x8
		public GameObject _gameObject; //Field offset: 0xC

		public EventTypeGameObjectPair() { }

	}

	private const float COIN_SPRITE_OFFSET = 2; //Field offset: 0x0
	private const string ONLINE_SETTING_EVENT_ELEMENT_NEW_POSITION_OFFSET = "event_popup_element_new_position_offset"; //Field offset: 0x0
	private const string ONLINE_SETTING_EVENT_ELEMENT_NEW_ROTATION = "event_popup_element_new_rotation"; //Field offset: 0x0
	private const string ONLINE_SETTING_EVENT_ELEMENT_NEW_SCALE = "event_popup_element_new_scale"; //Field offset: 0x0
	private const int DESCRIPTION_BOX_EXTENDED_HEIGHT = 105; //Field offset: 0x0
	private const int DESCRIPTION_BOX_NORMAL_HEIGHT = 80; //Field offset: 0x0
	private static Vector3 SPECIAL_POWER_BOARD_POSITION_OFFSET; //Field offset: 0x0
	private static Vector3 SPECIAL_POWER_BOARD_ROTATION; //Field offset: 0xC
	private static Vector3 SPECIAL_POWER_BOARD_SCALE; //Field offset: 0x18
	private static Vector3 LIMITED_CHAR_POSITION_OFFSET; //Field offset: 0x24
	private static Vector3 LIMITED_CHAR_ROTATION; //Field offset: 0x30
	private static Vector3 LIMITED_CHAR_SCALE; //Field offset: 0x3C
	private static Vector3 CHARACTER_DAY_MODEL_POSITION_OFFSET; //Field offset: 0x48
	private static Vector3 CHARACTER_DAY_MODEL_ROTATION; //Field offset: 0x54
	private static Vector3 CHARACTER_DAY_MODEL_SCALE; //Field offset: 0x60
	private static Vector3 MYSTERY_POWERUP_POSITION_OFFSET; //Field offset: 0x6C
	private static Vector3 MYSTERY_POWERUP_ROTATION; //Field offset: 0x78
	private static Vector3 MYSTERY_POWERUP_SCALE; //Field offset: 0x84
	private List<EventTypeGameObjectPair> _stateGameObjects; //Field offset: 0x28
	private Color32 _timerBackgroundColor; //Field offset: 0x2C
	private Color32 _timerContentColor; //Field offset: 0x30
	private GameObject _specialPowerBoard; //Field offset: 0x34
	private GameObject _limitedCharacter; //Field offset: 0x38
	private GameObject _mysteryPowerup; //Field offset: 0x3C
	private UISprite _bgFill; //Field offset: 0x40
	private UISprite _bgOutline; //Field offset: 0x44
	private UILabel _eventTitleLine1; //Field offset: 0x48
	private UILabel _eventTitleLine2; //Field offset: 0x4C
	private UILabel _checkItOutLabel; //Field offset: 0x50
	private UILabel _messageTitleLabel; //Field offset: 0x54
	private UILabel _messageSecondTitleLabel; //Field offset: 0x58
	private GameObject _twoLinesDescription; //Field offset: 0x5C
	private Layout _twoLinesLayout; //Field offset: 0x60
	private GameObject _jackpotBottomElements; //Field offset: 0x64
	private GameObject _jackpotTopElements; //Field offset: 0x68
	private GameObject _jackpotTopElementsHearts; //Field offset: 0x6C
	private GameObject _jackpotTopElementsNormal; //Field offset: 0x70
	private GameObject _goToItemButton; //Field offset: 0x74
	private UILabel _jackpotsDescriptionLabel; //Field offset: 0x78
	private UILabel _MBJackpotLabel; //Field offset: 0x7C
	private UILabel _SMBJackpotLabel; //Field offset: 0x80
	private UISprite _coinLeft; //Field offset: 0x84
	private UISprite _coinRight; //Field offset: 0x88
	private UISprite _bottomDescriptionBoxSprite; //Field offset: 0x8C
	private UISprite _topSplatSprite; //Field offset: 0x90
	private UISprite _glowEffectSprite; //Field offset: 0x94
	private List<UISprite> _listBgStripes; //Field offset: 0x98
	private GameObject _mysteryPowerupPrefab; //Field offset: 0x9C
	private TimerHelper _timerPrefab; //Field offset: 0xA0
	private UIWidget _timerContainer; //Field offset: 0xA4
	private TimerHelper _timer; //Field offset: 0xA8
	private IEventManager _activeEventManager; //Field offset: 0xAC
	private readonly Vector2 _dimensionsBgFillNormalEvent; //Field offset: 0xB0
	private readonly Vector2 _dimensionsBgOutlineNormalEvent; //Field offset: 0xB8
	private readonly Vector2 _dimensionsBgFillCheckOutItemEvent; //Field offset: 0xC0
	private readonly Vector2 _dimensionsBgOutlineCheckOutItemEvent; //Field offset: 0xC8
	private readonly Vector2 _dimensionsBgFillExtendedCheckOutItemEvent; //Field offset: 0xD0
	private readonly Vector2 _dimensionsBgOutlineExtendedCheckOutItemEvent; //Field offset: 0xD8
	private Nullable<CharacterId> _cachedCharacter; //Field offset: 0xE0
	private List<SSEventCategory> _supportedCategories; //Field offset: 0xE8

	private static SSEventsPopup() { }

	public SSEventsPopup() { }

	private void AddLimitedCharacter3DElements(SSEventType eventType) { }

	private void AddSpecialPowerBoardEvent3DElements() { }

	private IEnumerator DelayPositioning(UISprite tracker, GameObject objectToPosition, Vector3 positionOffset, Vector3 newRotation, Vector3 newScale) { }

	private void DisableAllStates() { }

	private SSEventCategory GetEventCategory() { }

	public void GoToEventItem() { }

	public override void Hide() { }

	private void HidePopupIfNeeded() { }

	public override void Init() { }

	private void InitializeTimer() { }

	private GameObject PlaceModelUnderAnchor(GameObject model, Transform anchor, int layer) { }

	private GameObject PlacePrefabUnderAnchor(GameObject prefab, Transform anchor, int layer) { }

	private void PositionCoinIcons() { }

	private void PositionModelOnSprite(UISprite tracker, GameObject objectToPosition, Vector3 positionOffset, Vector3 newRotation, Vector3 newScale) { }

	private void PositionMysteryPowerup3DElements() { }

	private void PresentCurrentEventAvailable() { }

	private void SetCategorySpecificElements() { }

	private void SetExtraSettingsForState(SSEventType eventType) { }

	private void SetLabelsTexts() { }

	public override void Show() { }

	public static void ShowIfNeeded() { }

	private void StartTimer() { }

	private void StopTimer() { }

	private void UpdateUIElements() { }

	private Vector3 VerifySettingOnline(string key, Vector3 defaultVal) { }

}

