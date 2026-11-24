namespace UI;

public class CoinButtonHelper : DiscountButton
{
	private Transform _onDisplayParent; //Field offset: 0x164
	private CoinContainer _coinContainer; //Field offset: 0x168
	private InAppItemModel _itemData; //Field offset: 0x16C
	private string _screenName; //Field offset: 0x170
	public Action onClick; //Field offset: 0x174

	public CoinButtonHelper() { }

	public void AddMostPopularSticker(GameObject prefab, Vector2 stickerOffset, UIPanel coinScreenPanel, int padding = 0) { }

	public void AddSticker(GameObject stickerGo, Vector2 stickerOffset, int stickerHeight, int padding = 0) { }

	private void ForceEndDiscount() { }

	private string GetCurrencyText() { }

	public void Init(InAppItemModel inAppItem, Transform offerContainer, string screenName, bool showDiscountSticker = true) { }

	private void OnClick() { }

	private void SetOffsets(GameObject stickerGo, Vector2 stickerOffset, int stickerHeight, int padding = 0) { }

	public void Show(bool forceEndDiscount = false) { }

	private void ShowAsPromotion() { }

	public override bool SupportsSpecialSale() { }

}

