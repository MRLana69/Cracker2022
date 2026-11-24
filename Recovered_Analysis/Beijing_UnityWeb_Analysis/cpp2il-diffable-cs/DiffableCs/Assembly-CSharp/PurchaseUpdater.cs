//Type is in global namespace

public class PurchaseUpdater : MonoBehaviour
{
	public UILabel price; //Field offset: 0xC
	public UISprite coin; //Field offset: 0x10
	public UITierHelper tierHelper; //Field offset: 0x14
	public UILabel haveAmount; //Field offset: 0x18
	public GameObject buyButton; //Field offset: 0x1C
	public UILabel buyButtonTitle; //Field offset: 0x20
	public UISprite buyButtonBackground; //Field offset: 0x24

	public PurchaseUpdater() { }

	public void UpgradePurchased(UpgradeType type) { }

}

