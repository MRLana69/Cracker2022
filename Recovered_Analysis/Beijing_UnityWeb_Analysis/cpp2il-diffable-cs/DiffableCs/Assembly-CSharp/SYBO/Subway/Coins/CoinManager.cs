namespace SYBO.Subway.Coins;

public class CoinManager
{
	private GameObject _coinPrefab; //Field offset: 0x10
	private EventHandler OnCoinCollected; //Field offset: 0x14
	private HashSet<Coin> _activeCoins; //Field offset: 0x18
	private List<Coin> _coinsCopy; //Field offset: 0x1C
	private GameStats _gameStats; //Field offset: 0x20
	private Character _character; //Field offset: 0x24

	public event EventHandler OnCoinCollected
	{
		 add { } //Length: 72
		 remove { } //Length: 111
	}

	public CoinManager() { }

	public void add_OnCoinCollected(EventHandler value) { }

	public bool IsSpawned(Coin coin) { }

	public void NotifyCoinActivated(Coin coin) { }

	public void NotifyCoinDeactivated(Coin coin) { }

	public void NotifyCoinDestroyed(Coin coin) { }

	public void PickupCoin(Coin coin) { }

	private void RaiseOnCoinCollected() { }

	public void remove_OnCoinCollected(EventHandler value) { }

	public void ResetCoins() { }

	private void RewardCoin() { }

	public Coin SpawnCoin(Vector3 position, Transform parentTransform = null) { }

	protected void Start() { }

	private void Update() { }

}

