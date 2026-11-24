namespace UI.Screens;

public class FrontScreen : RunStartScreen
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__54_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal void <CheckForCloudSaveWelcomeSlideIn>b__54_0() { }

	}

	private sealed class <AnimateButtonHorizontal>d__90 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public GameObject button; //Field offset: 0x10
		public FrontScreen <>4__this; //Field offset: 0x14
		public float offset; //Field offset: 0x18
		public float delay; //Field offset: 0x1C
		public Action onComplete; //Field offset: 0x20
		private float <endX>5__2; //Field offset: 0x24
		private float <startX>5__3; //Field offset: 0x28

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 344
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <AnimateButtonHorizontal>d__90(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <AnimateButtonVertical>d__89 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public GameObject button; //Field offset: 0x10
		public float offset; //Field offset: 0x14
		public float delay; //Field offset: 0x18
		public FrontScreen <>4__this; //Field offset: 0x1C
		public Action onComplete; //Field offset: 0x20
		private float <endY>5__2; //Field offset: 0x24
		private float <startY>5__3; //Field offset: 0x28

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 318
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <AnimateButtonVertical>d__89(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <AnimateSlideInButton>d__91 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public bool horizontal; //Field offset: 0x10
		public Transform t; //Field offset: 0x14
		public float start; //Field offset: 0x18
		public float end; //Field offset: 0x1C
		private float <currentDuration>5__2; //Field offset: 0x20
		private Action<float> <setPos>5__3; //Field offset: 0x24

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 523
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <AnimateSlideInButton>d__91(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private enum AnimatingButton
	{
		SettingsButton = 0,
		MyTourButton = 1,
		HoverboardButton = 2,
		BottomMenuButtons = 3,
		EventButton = 4,
		QuickVideoButton = 5,
		OfferwallButton = 6,
		BoardBundleButton = 7,
		FirstPurchaseBonusButton = 8,
		PromotionButton = 9,
		WelcomePackButton = 10,
	}

	private const float DEFAULT_INTERSTITIAL_SHOW_ONCACHE_TIMEFRAME = 1.5; //Field offset: 0x0
	private const bool DEFAULT_OFFERWALL_POPUP_ENABLED = True; //Field offset: 0x0
	private const string ONLINESETTINGS_OFFERWALL_POPUP_ENABLED_KEY = "kiloo_offerwall_popup_enabled"; //Field offset: 0x0
	private const string INTERSTITIAL_FRONTSCREEN_SHOW_ONCACHE_TIMEFRAME = "interstitial_frontscreen_show_oncache_timeframe"; //Field offset: 0x0
	private static bool _firstTimeShown; //Field offset: 0x0
	private const float LEFT_SLIDEIN_BUTTON_START_OFFSET = -60; //Field offset: 0x0
	private const float RIGHT_SLIDEIN_BUTTON_START_OFFSET = 60; //Field offset: 0x0
	private const float TOP_SLIDEIN_BUTTON_START_OFFSET = 70; //Field offset: 0x0
	private const float BOTTOM_SLIDEIN_BUTTON_START_OFFSET = -110; //Field offset: 0x0
	private const int MY_TOUR_WIDE_RIGHT_OFFSET = -106; //Field offset: 0x0
	private GameObject[] _tweenButtons; //Field offset: 0x28
	private UIWidget[] _widgetFrames; //Field offset: 0x2C
	private GameObject discountStickerNormal; //Field offset: 0x30
	private GameObject discountStickerSpecialSale; //Field offset: 0x34
	private UISprite sticker; //Field offset: 0x38
	private UISprite stickerSpecialSale; //Field offset: 0x3C
	private UISprite stickerSpecialSaleOutline; //Field offset: 0x40
	private BoxCollider startButtonCollider; //Field offset: 0x44
	private Layout _topLeftLayout; //Field offset: 0x48
	private GameObject _settingsPopupButton; //Field offset: 0x4C
	private GameObject _showEventsPopupButton; //Field offset: 0x50
	private GameObject _hoverboardPopupButton; //Field offset: 0x54
	private GameObject _boardBundleButton; //Field offset: 0x58
	private UISprite _boardBundleIcon; //Field offset: 0x5C
	private UIWidget _myTourContainer; //Field offset: 0x60
	private GameObject _myTourButton; //Field offset: 0x64
	private Layout _topRightLayout; //Field offset: 0x68
	private GameObject _quickVideoButton; //Field offset: 0x6C
	private GameObject _quickVideoButtonPrefab; //Field offset: 0x70
	private GameObject _offerWallButton; //Field offset: 0x74
	private GameObject _firstPurchaseBonusButtonPrefab; //Field offset: 0x78
	private GameObject _welcomePackButtonPrefab; //Field offset: 0x7C
	private GameObject _promotionButton; //Field offset: 0x80
	private GameObject _firstPurchaseBonusButton; //Field offset: 0x84
	private GameObject _welcomePackButton; //Field offset: 0x88
	private QuickVideoButtonHelper _quickVideoButtonHelper; //Field offset: 0x8C
	private GameObject _bottomParent; //Field offset: 0x90
	private UILabel shopDiscountLabel1; //Field offset: 0x94
	private UILabel shopDiscountLabel2; //Field offset: 0x98
	private UILabel shopDiscountLabelSingleLine; //Field offset: 0x9C
	private UILabel shopDiscountLabelSpecialSale; //Field offset: 0xA0
	private GuidelineButton _guidelineButtonShop; //Field offset: 0xA4
	private UILabel tapToPlayLabel; //Field offset: 0xA8
	private DateTime _frontScreenShowTimeStamp; //Field offset: 0xB0
	private bool _buttonsHaveTweened; //Field offset: 0xB8
	private Dictionary<AnimatingButton, IEnumerator> _buttonAnimationCoroutines; //Field offset: 0xBC
	private bool _hasShownPromotionPopupThisSession; //Field offset: 0xC0
	private float _iphoneXTopOffset; //Field offset: 0xC4
	private float _iphoneXBottomOffset; //Field offset: 0xC8
	private bool _hasShownBefore; //Field offset: 0xCC
	private bool _animationsAllowed; //Field offset: 0xCD
	private bool _wasAnimationInterrupted; //Field offset: 0xCE
	private readonly List<AnimatingButton> _completedButtonAnimations; //Field offset: 0xD0
	private readonly List<AnimatingButton> _isButtonAnimatingNow; //Field offset: 0xD4
	private bool _isApplicationResuming; //Field offset: 0xD8

	private void _PauseApplication(bool paused) { }

	private static FrontScreen() { }

	public FrontScreen() { }

	private void <StartAnimation>b__80_0() { }

	private void <StartAnimation>b__80_1() { }

	private void <StartAnimation>b__80_2() { }

	private void <StartAnimation>b__80_3() { }

	private void <StartAnimation>b__80_4() { }

	private void <StartAnimation>b__80_5() { }

	private void <StartAnimation>b__80_6() { }

	private void <StartAnimation>b__80_7() { }

	private void <StartAnimation>b__80_8() { }

	private void <StartAnimation>b__80_9() { }

	private void AnimateBoardBundleButton() { }

	private void AnimateBottomButtons() { }

	private IEnumerator AnimateButtonHorizontal(GameObject button, float delay, float offset, Action onComplete) { }

	private void AnimateButtons() { }

	private IEnumerator AnimateButtonVertical(GameObject button, float delay, float offset, Action onComplete) { }

	private void AnimateEventButton() { }

	private void AnimateFirstPurchaseBonusButton() { }

	private void AnimateHoverboardButton() { }

	private void AnimateMyTourButton() { }

	private void AnimateOfferwallButton() { }

	private void AnimatePromotionButton() { }

	public void AnimateQuickVideoButton() { }

	private void AnimateSettingsButton() { }

	private static IEnumerator AnimateSlideInButton(Transform t, float start, float end, bool horizontal) { }

	private void AnimateWelcomePackButton() { }

	public void BoardBundleButtonClicked() { }

	private bool CanShowInterstitial() { }

	private void CheckForCloudSaveIntroduction() { }

	private void CheckForCloudSavePromotion() { }

	private void CheckForCloudSaveReminder() { }

	private void CheckForCloudSaveWelcomeSlideIn() { }

	private void CheckForDiscountButton() { }

	private void CompleteAnimation(AnimatingButton b) { }

	public void EventsButtonClicked() { }

	public void FirstPurchaseButtonClicked() { }

	private static string FormatVersionNumber(string oldVersionNumber) { }

	protected override string GetFlurryName() { }

	private void HandleIphoneX() { }

	private void HandleOnCachedInterstitial(string adLocationId) { }

	private void HandleOnLastPopupClosed() { }

	private void HandleOnMenuScreenShown() { }

	private void HandleOnQuickVideoStarted() { }

	private void HandleOnVideoStateChanged(string adLocationId) { }

	private void HandleOnVideoStateChanged(string adLocationId, bool wasAlreadyCached) { }

	private void HandlePopups() { }

	private bool HasCompletedAnimation(AnimatingButton b) { }

	public override void Hide() { }

	private void HookEvents() { }

	public override void Init() { }

	private void InitHttp() { }

	private void InterruptCurrentButtonAnimations() { }

	private bool IsAnimating(AnimatingButton b) { }

	private void LateUpdate() { }

	private static void Log(string msg, Object context = null) { }

	private static void LogError(string msg, Object context = null) { }

	private static void LogWarning(string msg, Object context = null) { }

	public void OfferWallButtonClicked() { }

	private void OnAnimationsComplete() { }

	private void OnApplicationFocus(bool focus) { }

	private void OnApplicationPause(bool paused) { }

	private void OnDestroy() { }

	private void OnItemRestored(string result) { }

	private void OnOfferWallOffersRecieved() { }

	private void OnOnlineSettingsFinishedDownloading() { }

	private void OnPopupClosed(string popupName) { }

	private void ResetAnimation(AnimatingButton b) { }

	private void RetriggerSlideinAnimations() { }

	private void SetDefaultSaleStickerColors() { }

	private static bool ShouldDisplayChangeLog() { }

	public override void Show() { }

	private void SkipAnimationTween(AnimatingButton b) { }

	private void StartAnimation(AnimatingButton b) { }

	private void TournamentChanged(object sender, TournamentChangedEventArgs eventArg) { }

	private void UnhookEvents() { }

}

