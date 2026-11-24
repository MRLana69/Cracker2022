//Type is in global namespace

public class CoinEarnerLoadingOffer : MonoBehaviour
{
	private sealed class <StartLoadingCoroutine>d__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public CoinEarnerLoadingOffer <>4__this; //Field offset: 0x10

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 151
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <StartLoadingCoroutine>d__31(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	public enum OffersState
	{
		Loading = 0,
		NoOffersAvailable = 1,
		OfferWall = 2,
	}

	private const int LOADING_TIME_LIMIT = 10; //Field offset: 0x0
	private const string BG_SPRITENAME_INACTIVE = "button_generic_1"; //Field offset: 0x0
	private const string BG_SPRITENAME_OVERLAY_DEFAULT = "button_fill_shopItem_special_highlight"; //Field offset: 0x0
	private const string BG_SPRITENAME_ACTIVE_DEFAULT = "button_fill_shopItem_special_main"; //Field offset: 0x0
	private GameObject _loadingGameObject; //Field offset: 0xC
	private GameObject _noOffersAvailableGameObject; //Field offset: 0x10
	private GameObject _offerWallGameObject; //Field offset: 0x14
	private UISprite _fillOverlay; //Field offset: 0x18
	private UISprite _backgroundFill; //Field offset: 0x1C
	private GameObject _coinEarnerPrefab; //Field offset: 0x20
	private UILabel _titleLabel; //Field offset: 0x24
	private UILabel _getLabel; //Field offset: 0x28
	private UILabel _descriptionLabel; //Field offset: 0x2C
	private UILabelLimiter labelLimiter; //Field offset: 0x30
	private UILabel _loadingAppOffers; //Field offset: 0x34
	private UILabel _couldNotLoad; //Field offset: 0x38
	private UILabel _tryAgain; //Field offset: 0x3C
	private OffersState _currentState; //Field offset: 0x40
	private bool _isLodingTimerStarted; //Field offset: 0x44
	private Action _onClickHandler; //Field offset: 0x48
	private int _indexOnScreen; //Field offset: 0x4C

	public CoinEarnerLoadingOffer() { }

	private void Awake() { }

	private void CheckIfNullAndSetTextWhereIsTheCase() { }

	public OffersState GetOffersState() { }

	public void Init(Action onClickDelegate) { }

	private void LogError(string message) { }

	private void OnClick() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void OnOfferWallReceived() { }

	public void SetOffersState(OffersState state) { }

	private void SetStateGameObjectActive(GameObject go) { }

	private IEnumerator StartLoadingCoroutine() { }

}

