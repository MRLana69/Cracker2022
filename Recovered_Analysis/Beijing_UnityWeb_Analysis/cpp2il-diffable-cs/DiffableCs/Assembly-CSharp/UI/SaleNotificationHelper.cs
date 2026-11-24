namespace UI;

public class SaleNotificationHelper : MonoBehaviour
{
	private UILabel _line1; //Field offset: 0xC
	private UILabel _line2; //Field offset: 0x10
	private UISprite _bgSprite; //Field offset: 0x14
	private UISprite _bgShadow; //Field offset: 0x18
	private string _offerText; //Field offset: 0x1C

	public SaleNotificationHelper() { }

	public void Init(string saleHeader, string subHeader, string saleText) { }

}

