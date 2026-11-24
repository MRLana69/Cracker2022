namespace UI;

public class UIFooterHandler : MonoBehaviour
{
	public UIButtonOverlayOff button0; //Field offset: 0xC
	public UIButtonOverlayOff button1; //Field offset: 0x10
	public UIButtonOverlayOff button2; //Field offset: 0x14
	public UIButtonOverlayOff button3; //Field offset: 0x18
	public GameObject boostDiscount; //Field offset: 0x1C
	public GameObject coinshopDiscount; //Field offset: 0x20
	public GameObject specialSaleCoinshopDiscount; //Field offset: 0x24
	private UISprite[] discountStickers; //Field offset: 0x28
	private UILabel[] discountStickerLabels; //Field offset: 0x2C
	private UISprite specialSaleDiscountSticker; //Field offset: 0x30
	private UILabel specialSaleDiscountStickerLabel; //Field offset: 0x34

	public UIFooterHandler() { }

	public void HandleStickers() { }

}

