namespace UI;

public class CoinEarnerButtonHelper : MonoBehaviour
{
	private GameObject _normalContent; //Field offset: 0xC
	private GameObject _connectingContent; //Field offset: 0x10
	private Layout _contentLayout; //Field offset: 0x14
	private Layout _connectingLayout; //Field offset: 0x18
	private BoxCollider _collider; //Field offset: 0x1C
	private UILabel _connectingLabel; //Field offset: 0x20
	private UISprite _icon; //Field offset: 0x24
	private UILabel _title; //Field offset: 0x28
	private UILabel _description; //Field offset: 0x2C
	private UILabel _priceLabel; //Field offset: 0x30
	private UILabel _getLabel; //Field offset: 0x34
	private int _earnCurrencyProfileIndex; //Field offset: 0x38
	private Action _onClickDelegate; //Field offset: 0x3C

	public CoinEarnerButtonHelper() { }

	private void GoToConnectingState() { }

	private void GoToNormalState() { }

	public void Init(int earnCurrencyProfileIndex, string title, string desc, string iconName, int price, Action onClickDelegate) { }

	private void OnClick() { }

}

