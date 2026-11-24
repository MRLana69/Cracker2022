//Type is in global namespace

public class CoinBoxSizer : MonoBehaviour
{
	private const float BOX_COLLIDER_DEPTH = -15; //Field offset: 0x0
	private UISprite _addFundsSprite; //Field offset: 0xC
	private UISprite _grayFGCoins; //Field offset: 0x10
	private UISprite _coinIcon; //Field offset: 0x14
	private UISprite _grayFGKeys; //Field offset: 0x18
	private UISprite _keyIcon; //Field offset: 0x1C
	private UISprite _shadow; //Field offset: 0x20
	private GameObject _fundsParent; //Field offset: 0x24
	private GameObject _coinsParent; //Field offset: 0x28
	private GameObject _keysParent; //Field offset: 0x2C
	private BoxCollider _boxCollider; //Field offset: 0x30
	public UILabel coinAmountLabel; //Field offset: 0x34
	public UILabel keyAmountLabel; //Field offset: 0x38
	private UIAnchor parentAnchor; //Field offset: 0x3C
	private bool _updateAutomatically; //Field offset: 0x40
	private bool _shadowEnabled; //Field offset: 0x41
	private float _cachedCoinsFGWidth; //Field offset: 0x44
	private float _cachedCoinIconWidth; //Field offset: 0x48
	private float _cachedCoinIconOffset; //Field offset: 0x4C
	private float _cachedKeysFGWidth; //Field offset: 0x50
	private float _cachedKeysIconWidth; //Field offset: 0x54
	private float _depthOffset_default; //Field offset: 0x58
	private float _shadowWidthOffset; //Field offset: 0x5C
	private float COINS_FG_SCALE_OFFSET; //Field offset: 0x60
	private float KEYS_FG_SCALE_OFFSET; //Field offset: 0x64
	private bool isInitialized; //Field offset: 0x68
	private UIPanel _panel; //Field offset: 0x6C

	public bool updateAutomatically
	{
		 get { } //Length: 79
		 set { } //Length: 120
	}

	private void _AdjustKeysSegmentSize() { }

	public CoinBoxSizer() { }

	public void AdjustCoinsSegmentSize() { }

	private void CacheCoinsSegmentElements() { }

	private void CacheKeysSegmentElements() { }

	private Vector3 CalculateCoinboxPosition(UIWidget widgetAnchor, Vector3 defaultPosition, float xOffset_custom, float yOffset_custom) { }

	private Vector2 CalculateDistanceToBounds(UIWidget widget) { }

	private void EnableElements(bool fundsEnabled, bool coinsEnabled, bool keysEnabled) { }

	public bool get_updateAutomatically() { }

	public void Init(UIWidget widgetAnchor, bool fundsEnabled, bool coinsEnabled, bool keysEnabled, float xOffset_custom = 0, float yOffset_custom = 0, float zOffset_custom = 0) { }

	private void OnCoinsChanged() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void OnKeysChanged() { }

	private void PlaceSegments() { }

	private void ScaleElementsThatStrechTheBox() { }

	public void set_updateAutomatically(bool value) { }

	private void Start() { }

}

