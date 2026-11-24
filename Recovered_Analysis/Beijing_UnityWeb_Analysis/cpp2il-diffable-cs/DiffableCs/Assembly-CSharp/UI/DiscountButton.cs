namespace UI;

public class DiscountButton : MonoBehaviour
{
	private enum DiscountButtonState
	{
		Normal = 0,
		Sale = 1,
		Promotion = 2,
	}

	protected const int SALE_BUTTON_GROWTH = 12; //Field offset: 0x0
	protected const string SPRITE_NAME_ICON_BACKGROUND_KEYS = "icon_background_keys"; //Field offset: 0x0
	protected const string SPRITE_NAME_ICON_BACKGROUND_NORMAL = "icon_background_normal"; //Field offset: 0x0
	protected const string SPRITE_NAME_SALE_STRIKEOVER_LOW = "sale_strikeover_lo"; //Field offset: 0x0
	protected const string ONLINE_SETTINGS_KEY_DISCOUNT_DEAL_NAME = "discount_deal_name"; //Field offset: 0x0
	protected const string SPRITE_NAME_ICON_BACKGROUND_THEME = "icon_background_theme"; //Field offset: 0x0
	protected const string SPRITE_NAME_SALE_STRIKEOVER_HIGH = "sale_strikeover_hi"; //Field offset: 0x0
	protected const int LINETHROUGH_WIDTH_OFFSET = 6; //Field offset: 0x0
	protected static Vector2 SHADOW_OFFSET; //Field offset: 0x0
	protected static Vector3 PRICE_DISCOUNT_OFFSET; //Field offset: 0x8
	protected Color32 titleColor; //Field offset: 0xC
	protected Color32 titleColorShadow; //Field offset: 0x10
	protected Color32 description1ColorInactive; //Field offset: 0x14
	protected Color32 description1ColorShadowInactive; //Field offset: 0x18
	protected Color32 description1ColorActive; //Field offset: 0x1C
	protected Color32 description1ColorShadowActive; //Field offset: 0x20
	protected Color32 description2Color; //Field offset: 0x24
	protected Color32 description2ColorShadow; //Field offset: 0x28
	protected Color32 priceColor; //Field offset: 0x2C
	protected Color32 priceColorShadow; //Field offset: 0x30
	protected Color32 limitedTimerColor; //Field offset: 0x34
	protected Color32 limitedTimerColorShadow; //Field offset: 0x38
	protected Color32 stickerColor; //Field offset: 0x3C
	protected Color32 stickerLabelColor; //Field offset: 0x40
	protected Color32 lineThroughColor; //Field offset: 0x44
	protected Color32 lineThroughShadowColor; //Field offset: 0x48
	protected string SPRITE_NAME_FILL_SHOPITEM_HIGHLIGHT_SALE; //Field offset: 0x4C
	protected string SPRITE_NAME_FILL_SHOPITEM_MAIN_SALE; //Field offset: 0x50
	protected string iconBackgroundNormalSpriteName; //Field offset: 0x54
	protected string iconBackgroundKeysSpriteName; //Field offset: 0x58
	protected Vector3 originalMainTextPosition; //Field offset: 0x5C
	protected Vector3 originalDescriptionPosition; //Field offset: 0x68
	protected Vector3 originalPricePosition; //Field offset: 0x74
	protected Color32 originalPriceColor; //Field offset: 0x80
	protected Color32 originalPriceColorShadow; //Field offset: 0x84
	protected Vector3 originalFillGrayScale; //Field offset: 0x88
	protected Vector3 originalFillColorScale; //Field offset: 0x94
	protected Vector3 originalOutlineScale; //Field offset: 0xA0
	protected Vector3 originalContentPosition; //Field offset: 0xAC
	protected string originalFillColorSpirteName; //Field offset: 0xB8
	protected string originalFillGraySpriteName; //Field offset: 0xBC
	protected Color32 originalTitleColor; //Field offset: 0xC0
	protected Color32 originalTitleColorShadow; //Field offset: 0xC4
	protected Vector2 originalTitleDistanceShadow; //Field offset: 0xC8
	protected Color32 originalDescription1Color; //Field offset: 0xD0
	protected Color32 originalDescription1ColorShadow; //Field offset: 0xD4
	protected Color32 originalDescription2Color; //Field offset: 0xD8
	protected Color32 originalDescription2ColorShadow; //Field offset: 0xDC
	protected Vector2 originalIconSize; //Field offset: 0xE0
	protected Vector2 originalIconBGSize; //Field offset: 0xE8
	protected Vector3 originalIconBGPosition; //Field offset: 0xF0
	protected Vector3 originalWidgetScale; //Field offset: 0xFC
	protected UISprite iconBG; //Field offset: 0x108
	protected UISprite icon; //Field offset: 0x10C
	protected UILabel title; //Field offset: 0x110
	protected UILabel description1; //Field offset: 0x114
	protected UILabel description2; //Field offset: 0x118
	protected UISprite lineThrough; //Field offset: 0x11C
	protected UISprite lineThroughShadow; //Field offset: 0x120
	protected UILabel price; //Field offset: 0x124
	protected UISprite fillGraySprite; //Field offset: 0x128
	protected UISprite fillColorSprite; //Field offset: 0x12C
	protected UISprite outlineSprite; //Field offset: 0x130
	protected Transform content; //Field offset: 0x134
	protected Transform leftContent; //Field offset: 0x138
	protected Transform rightContent; //Field offset: 0x13C
	protected Transform mainTextContent; //Field offset: 0x140
	protected UISprite discountSticker; //Field offset: 0x144
	protected UILabel discountLabel; //Field offset: 0x148
	protected UILabel discountLabelSingleLine; //Field offset: 0x14C
	protected UILabel limitedTitle; //Field offset: 0x150
	protected UILabel limitedTime; //Field offset: 0x154
	protected UILabel discountLabelSpecialSale; //Field offset: 0x158
	protected UIWidget _widget; //Field offset: 0x15C
	protected bool _showDiscountSticker; //Field offset: 0x160

	private static DiscountButton() { }

	public DiscountButton() { }

	public virtual void Awake() { }

	private void FormatButton(DiscountButtonState state) { }

	private void PositionContent(DiscountButtonState state) { }

	private void SetDiscountAssets(DiscountButtonState state, string productString) { }

	private void SetDiscountColors(DiscountButtonState state) { }

	private void SetLimitedLabels(DiscountButtonState state) { }

	private void SetNodiscountColors() { }

	private void SetProductData(DiscountButtonState state, string productString, string backupDescription, string backupDescription2 = "") { }

	protected virtual void ShowNoDiscount(string productString, string backupDescription = "") { }

	protected virtual void ShowOnPromotion(string productString, string backupDescription, string backupDescription2) { }

	protected virtual void ShowOnSale(string productString, string backupDescription = "") { }

	public virtual bool SupportsSpecialSale() { }

}

