namespace UI.Screens;

public class EarnCoinsScreen : UIScreen
{
	private sealed class <DelayedSetScrollViewCenterOffset>d__42 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public EarnCoinsScreen <>4__this; //Field offset: 0x10

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 123
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <DelayedSetScrollViewCenterOffset>d__42(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <DelayingRefreshForUserFeedback>d__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public EarnCoinsScreen <>4__this; //Field offset: 0x10

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 135
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <DelayingRefreshForUserFeedback>d__35(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private static bool _facebookLoginRunning; //Field offset: 0x0
	private const int LARGE_CELL_HEIGHT = 79; //Field offset: 0x0
	private const int SMALL_CELL_HEIGHT = 65; //Field offset: 0x0
	private const int TITLE_LABEL_HEIGHT = 39; //Field offset: 0x0
	private static bool _shouldRefreshCurrencyEarners; //Field offset: 0x1
	public GameObject WatchVideoPrefab; //Field offset: 0x28
	public GameObject coinEarnerPrefab; //Field offset: 0x2C
	public GameObject facebookGiftPrefab; //Field offset: 0x30
	private GameObject _rewardForVideoButtonPrefab; //Field offset: 0x34
	public Font headerFont; //Field offset: 0x38
	private GameObject _facebookRewardsButtonPrefab; //Field offset: 0x3C
	private UITable _table; //Field offset: 0x40
	private UIScrollView _dragPanel; //Field offset: 0x44
	private GameObject _loadingOffersPrefab; //Field offset: 0x48
	private GameObject _listTitleComponent; //Field offset: 0x4C
	private GameObject _scrollBar; //Field offset: 0x50
	private GameObject _noOffersLabelGameObject; //Field offset: 0x54
	private CoinEarnerLoadingOffer _coinEarnerLoadingOffer; //Field offset: 0x58
	private UIPanel _panel; //Field offset: 0x5C
	private GameObject _facebookRewardsButton; //Field offset: 0x60
	private int _tableContentCombinedHeight; //Field offset: 0x64

	private bool isVideoAdsSupported
	{
		 get { } //Length: 159
	}

	private static EarnCoinsScreen() { }

	public EarnCoinsScreen() { }

	private IEnumerator DelayedSetScrollViewCenterOffset() { }

	private IEnumerator DelayingRefreshForUserFeedback() { }

	public void FacebookLoginClicked() { }

	private void FacebookStatusChanged(bool success) { }

	private void FillTable() { }

	private void ForceRefreshOfferWall() { }

	public override void GainFocus() { }

	private bool get_isVideoAdsSupported() { }

	public override void Hide() { }

	public override void Init() { }

	private void InsertEarner(int index, ref int numberOfObjects) { }

	private void InsertOffer(ref int numberOfObjects, OffersState offerState) { }

	private void InsertVideoButtons(ref int numberOfObjects) { }

	private bool IsListBiggerThanClip() { }

	private void OfferWallRequestSuccess() { }

	private void OnApplicationPause(bool pause) { }

	public void OnFacebookLoginResult(bool loggedIn) { }

	private void OnFailSlideInFinish() { }

	private static void QueueFacebookFailSlideIn(Action onFinishCallback) { }

	public void RefreshCurrencyEarners() { }

	private void SetScrollViewCenterOffset() { }

	public override void Show() { }

	private void Update() { }

}

