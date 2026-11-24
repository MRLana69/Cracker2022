namespace UI.Screens;

public class GameOverScreen : RunStartScreen
{
	private sealed class <>c__DisplayClass115_0
	{
		public int payoutCoins; //Field offset: 0x8
		public GameOverScreen <>4__this; //Field offset: 0xC

		public <>c__DisplayClass115_0() { }

		internal void <SetupDoubleCoinsVideo>b__0() { }

	}

	private sealed class <CorouReloadFriends>d__103 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public bool framedelay; //Field offset: 0x10
		public GameOverScreen <>4__this; //Field offset: 0x14
		private float <framestamp>5__2; //Field offset: 0x18

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 259
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <CorouReloadFriends>d__103(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <CountUpCoins>d__111 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public GameOverScreen <>4__this; //Field offset: 0x10
		private float <countTime>5__2; //Field offset: 0x14
		private float <countFactor>5__3; //Field offset: 0x18

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 856
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <CountUpCoins>d__111(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <CountUpDoubleCoinsVideo>d__112 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public GameOverScreen <>4__this; //Field offset: 0x10
		public int coinsToPayout; //Field offset: 0x14
		private int <from>5__2; //Field offset: 0x18
		private int <to>5__3; //Field offset: 0x1C
		private float <countTime>5__4; //Field offset: 0x20
		private int <totalTo>5__5; //Field offset: 0x24
		private int <totalFrom>5__6; //Field offset: 0x28
		private float <countFactor>5__7; //Field offset: 0x2C

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 771
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <CountUpDoubleCoinsVideo>d__112(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	public enum ActiveTabState
	{
		LeaderBoard = 0,
		TopRun = 1,
	}

	private enum DoubleCoinsElementType
	{
		Button = 0,
		SmallBanner = 1,
		BigBanner = 2,
	}

	private static Action onGameOverScreenShown; //Field offset: 0x0
	private const int RATING_POPUP_RUN_LIMIT = 15; //Field offset: 0x0
	private const bool RATING_POPUP_ENABLED_DEFAULT_VALUE = True; //Field offset: 0x0
	private const string RATING_POPUP_ENABLED_ONLINESETTINGS_KEY = "rating_popup_enabled"; //Field offset: 0x0
	private const string INTERSTITIAL_GAMEOVER_ACTIVE_SHOW_SLOT = "interstitial_game_over_active_show_slot"; //Field offset: 0x0
	private const string INTERSTITIAL_GAMEOVER_TOTAL_SHOW_SLOTS = "interstitial_game_over_total_show_slots"; //Field offset: 0x0
	private const string INTERSTITIAL_GAMEOVER_COUNTER_EXPIRE_TIME = "interstitial_game_over_counter_expire_time"; //Field offset: 0x0
	private const uint DEFAULT_ACTIVE_SHOW_SLOT = 1; //Field offset: 0x0
	private const uint DEFAULT_TOTAL_SHOW_SLOTS = 5; //Field offset: 0x0
	private const uint DEFAULT_COUNTER_EXPIRE_TIME = 72000; //Field offset: 0x0
	private UILabel scoreLabel; //Field offset: 0x28
	private UILabel collectedCoinLabel; //Field offset: 0x2C
	private UILabel _doubleCoinsLabel; //Field offset: 0x30
	private UISprite _doubleCoinDots; //Field offset: 0x34
	private UISprite _doubleCoinInfo; //Field offset: 0x38
	private Layout _doubleCoinLayout; //Field offset: 0x3C
	private GameObject _scoreBoard; //Field offset: 0x40
	private GameObject _doubleCoinsButton; //Field offset: 0x44
	private GameObject _doubleCoinVariationAnchor; //Field offset: 0x48
	private GameObject _DoubleCoinVariationBPrefab; //Field offset: 0x4C
	private GameObject _DoubleCoinVariationCPrefab; //Field offset: 0x50
	private GameObject _DoubleCoinVariationDPrefab; //Field offset: 0x54
	private GameObject _DoubleCoinVariationEPrefab; //Field offset: 0x58
	private string _currentVariation; //Field offset: 0x5C
	private DoubleCoinsButton _currentButton; //Field offset: 0x60
	private CoinBoxSizer _coinBoxSizer; //Field offset: 0x64
	private UILabel _coinboxLabel; //Field offset: 0x68
	private int _scoreFrom; //Field offset: 0x6C
	private int _scoreTo; //Field offset: 0x70
	private int _coinboxFrom; //Field offset: 0x74
	private int _coinboxTo; //Field offset: 0x78
	private int _collectedCoinsFrom; //Field offset: 0x7C
	private int _collectedCoinsTo; //Field offset: 0x80
	private bool _countingUpCoins; //Field offset: 0x84
	private ScoreCounterSoundPlayer _scoreCounterSoundPlayer; //Field offset: 0x88
	private int _counter; //Field offset: 0x8C
	private int _facebookShowCounter; //Field offset: 0x90
	private DateTime _lastCountUpTimeStamp; //Field offset: 0x98
	private bool _hasAttemptedToShowAdOnTopOfPopup; //Field offset: 0xA0
	private GameObject discountSticker; //Field offset: 0xA4
	private UISprite discountStickerSprite; //Field offset: 0xA8
	private UILabel discountLabel; //Field offset: 0xAC
	private UILabel discountLabelSingleLine; //Field offset: 0xB0
	private UISprite playButtonFill; //Field offset: 0xB4
	private UIButtonOverlayOff playButtonOverlayOff; //Field offset: 0xB8
	private UILabel homeButtonLabel; //Field offset: 0xBC
	private UILabel boostsButtonLabel; //Field offset: 0xC0
	private UILabel boostsButtonCoolDealLabel; //Field offset: 0xC4
	private UILabel playButtonLabel; //Field offset: 0xC8
	private UILabel topScoreLabel; //Field offset: 0xCC
	private Layout _topScoreLayout; //Field offset: 0xD0
	private UIWidget _topContainer; //Field offset: 0xD4
	private GameOverLeaderboardHandler leaderboardHandler; //Field offset: 0xD8
	private GameObject _leaderboardContent; //Field offset: 0xDC
	private GameObject _topRunContent; //Field offset: 0xE0
	private TopRunOnlineGameOverScreen _topRunContentScript; //Field offset: 0xE4
	private BreadCrumbHelper _breadcrumb; //Field offset: 0xE8
	private GameObject _eventRibbon; //Field offset: 0xEC
	private UILabel[] _ribbonLabels; //Field offset: 0xF0
	private GameObject _characterDayParticleSystem; //Field offset: 0xF4
	private UIPanel _leaderboardPanel; //Field offset: 0xF8
	private UIPanel _topRunPanel; //Field offset: 0xFC
	private Transform _doubleCoinVideoButtonParent; //Field offset: 0x100
	private Transform _doubleCoinVideoBannerParent; //Field offset: 0x104
	private DoubleCoinsVideo _doubleCoinVideoButtonPrefab; //Field offset: 0x108
	private DoubleCoinsVideo _doubleCoinsVideoBannerSmallPrefab; //Field offset: 0x10C
	private DoubleCoinsVideo _doubleCoinsVideoBannerBigPrefab; //Field offset: 0x110
	private DoubleCoinsVideo _doubleCoinsVideoElement; //Field offset: 0x114
	private bool _hasDoubledCoinsThisRun; //Field offset: 0x118
	private bool _disableDoubleCoinsVideoByABTest; //Field offset: 0x119
	private bool _leaderboardTabActive; //Field offset: 0x11A
	private Color darkBlue; //Field offset: 0x11C
	private Color yellow; //Field offset: 0x12C
	private bool _hasBeenSetupAfterAGame; //Field offset: 0x13C
	private IEnumerator _reloadFriendsCoroutine; //Field offset: 0x140
	private bool _hasSetListiPhoneXOffset; //Field offset: 0x144
	private Dictionary<string, string> _doubleCoinsVideoResultParams; //Field offset: 0x148
	private ActiveTabState _currentActiveTab; //Field offset: 0x14C
	private Action onTabClicked; //Field offset: 0x150

	public static event Action onGameOverScreenShown
	{
		 add { } //Length: 11
		 remove { } //Length: 126
	}

	private event Action onTabClicked
	{
		 add { } //Length: 807
		 remove { } //Length: 113
	}

	public GameOverScreen() { }

	private void ActivateEventRibbon(bool currentCharIsRelevant, IEventManager activeEventManager) { }

	public static void add_onGameOverScreenShown(Action value) { }

	private void add_onTabClicked(Action value) { }

	private void ChangePlayButtonState() { }

	private IEnumerator CorouReloadFriends(bool framedelay) { }

	private IEnumerator CountUpCoins() { }

	private void CountUpCompleted() { }

	private IEnumerator CountUpDoubleCoinsVideo(int coinsToPayout) { }

	public ActiveTabState GetActiveTabState(Action onTabChanged) { }

	private DoubleCoinsElementType GetDoubleCoinsElementType() { }

	private DoubleCoinsVideo GetDoubleCoinsInstance(DoubleCoinsVideo prefab, Transform container) { }

	protected override string GetFlurryName() { }

	private bool HasAdFill() { }

	public override void Hide() { }

	private void HideEventStarsIfNecessary() { }

	private void InAppManager_OnPurchaseSuccess(string productId, bool wasRestored, IPurchaseValidationResult validationResult) { }

	public override void Init() { }

	private bool IsAllowedToShowInterstitial() { }

	private bool IsLoggedInToFacebook() { }

	private bool IsSmallAspect() { }

	public void LeaderboardTabTapped() { }

	private void OnApplicationPause(bool pause) { }

	private void OnCoinsChanged() { }

	public void OnDoubleCoinsClicked() { }

	private void OnEnable() { }

	private void OnFriendsChanged() { }

	private void OnLastPopupClosed() { }

	private void OnMissionComplete(string message, int missionIndex) { }

	private void OnPopupShown(string popupName) { }

	private void PushNewHighScoreCelebrationScreen(int newHighSchore) { }

	private void ReloadFriends() { }

	public static void remove_onGameOverScreenShown(Action value) { }

	private void remove_onTabClicked(Action value) { }

	private void RemoveDoubleCoinsVideo() { }

	private void SetRibbonInfo(RibbonPayload payload) { }

	public void SetupAfterMysteryBox() { }

	public void SetupBeforeMysteryBox() { }

	private void SetupBigBanner() { }

	private void SetupDoubleCoinsVideo(int coinsCollectedTotal, bool showValueImmediately = false) { }

	private void SetupDoubleCoinsVideoBanner(DoubleCoinsVideo prefab, Transform container) { }

	private void SetUpEventUIElements() { }

	private void SetupLoggedInDoubleCoinsVideoButton() { }

	private void SetupSmallBanner() { }

	private bool ShouldEnableCharacterDayEventElements(IEventManager activeEventManager) { }

	public override void Show() { }

	private void SpawnDoubleCoinVariation(string variation) { }

	public override void StartRun() { }

	private void StartRunAfterAd() { }

	public void StopCoinsCountUp() { }

	public void TopRunTabTapped() { }

	private void UpdateDoubleCoin(string data = "") { }

	private void UpdateUpgradeSticker() { }

}

