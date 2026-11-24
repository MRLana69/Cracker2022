//Type is in global namespace

public class CoinEarnerVideoAds : MonoBehaviour
{
	private sealed class <CheckCacheState>d__45 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public CoinEarnerVideoAds <>4__this; //Field offset: 0x10
		private float <delay>5__2; //Field offset: 0x14
		private int <i>5__3; //Field offset: 0x18

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 348
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <CheckCacheState>d__45(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private enum ButtonState
	{
		Loading = 0,
		NoVideo = 1,
		VideoReady = 2,
	}

	private const string BG_SPRITENAME_ACTIVE_DEFAULT = "backgroud_callout_square"; //Field offset: 0x0
	private const string BG_SPRITENAME_INACTIVE = "button_generic_1"; //Field offset: 0x0
	private const float CHECK_CACHE_STATE_TIMEOUT = 10; //Field offset: 0x0
	private const int CHECK_CACHE_STATE_COUNT = 3; //Field offset: 0x0
	private const string BG_SPRITENAME_OVERLAY_DEFAULT = "whitebox_div"; //Field offset: 0x0
	private GameObject _videoAvailableGameObject; //Field offset: 0xC
	private GameObject _loadingGameObject; //Field offset: 0x10
	private UILabel _loadingLabel; //Field offset: 0x14
	private GameObject _noVideosGameObject; //Field offset: 0x18
	private UILabel _noVideosLabel; //Field offset: 0x1C
	private UILabel _noVideosTryAgainLabel; //Field offset: 0x20
	private GameObject _prizeContent; //Field offset: 0x24
	private UISprite _fillOverlay; //Field offset: 0x28
	private UISprite _backgroundFill; //Field offset: 0x2C
	private UISprite _backgroundHighlightFill; //Field offset: 0x30
	private UISprite _overlayHighlightFill; //Field offset: 0x34
	private Collider _collider; //Field offset: 0x38
	private UILabel _title; //Field offset: 0x3C
	private UILabel _description; //Field offset: 0x40
	private UILabel _priceLabelKeys; //Field offset: 0x44
	private int _prizeIconDepth; //Field offset: 0x48
	private UISprite _spritePrefab; //Field offset: 0x4C
	private GameObject _tvAnimatedIcon; //Field offset: 0x50
	private UIWidget _tvContainer; //Field offset: 0x54
	private List<EarnCoinButtonPrizeIconSetup> _prizeIconSetups; //Field offset: 0x58
	private int _earnCurrencyProfileIndex; //Field offset: 0x5C
	private Action _onClickDelegate; //Field offset: 0x60
	private ButtonState _currentButtonState; //Field offset: 0x64
	private List<UISprite> _prizeIcons; //Field offset: 0x68
	private bool _hasSubscribedToEvents; //Field offset: 0x6C
	private IEnumerator _checkCacheState; //Field offset: 0x70

	public CoinEarnerVideoAds() { }

	private IEnumerator CheckCacheState() { }

	private string GetDescriptionForVideoAdPrize(VideoAdPrizeType type) { }

	private UISprite GetPrizeIcon(int index) { }

	private string GetTitleForVideoAdPrize(VideoAdPrizeType type) { }

	private string GetTitleStringIdForVideoAdPrize(VideoAdPrizeType type) { }

	public void Init(int earnCurrencyProfileIndex, string title, string desc, string iconName, int price, Action onClickDelegate, UIScrollView panel) { }

	private void LogButtonShownToFlurry() { }

	private void OnClick() { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void OnFinishedWatchingVideo(string adLocationId) { }

	private void OnVideoCached(string adLocationId, bool wasAlreadyCached) { }

	private ButtonState RefreshButton() { }

	private void SetButtonState(ButtonState state) { }

	private void SetButtonText(string title, string desc, int price, bool keys) { }

	private void SetPrizeIconState() { }

	private void SetStateGameObjectActive(GameObject go) { }

	private void SubscribeToEvents() { }

	private void UIScreenController_OnApplicationResumed() { }

	private void UnsubscribeToEvents() { }

}

