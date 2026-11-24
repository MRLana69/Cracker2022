namespace UI.Helpers;

public class FirstPurchaseBonusQuickShopHelper : MonoBehaviour
{
	private const int POPUP_WIDTH = 310; //Field offset: 0x0
	private UIWidget _scrollViewWidget; //Field offset: 0xC
	private GameObject _dynamicContentRoot; //Field offset: 0x10
	private CoinScreen _coinScreen; //Field offset: 0x14
	private Vector2 _firstPurchaseBonusScrollViewWidgetSize; //Field offset: 0x18
	private float _yOffset; //Field offset: 0x20
	private GameObject _emptyOffsetWidget; //Field offset: 0x24
	private Vector2 _startSize; //Field offset: 0x28

	public FirstPurchaseBonusQuickShopHelper() { }

	private void AddEmptyOffsetWidgetIfNotExist() { }

	private void Awake() { }

	private GameObject CreateEmptyWidget(int height) { }

	private void OnCoinScreenHasAppeared() { }

	private void OnFirstPurchaseBonusBecameInactive() { }

	private void SetScrollWidgetSize(Vector2 size) { }

}

