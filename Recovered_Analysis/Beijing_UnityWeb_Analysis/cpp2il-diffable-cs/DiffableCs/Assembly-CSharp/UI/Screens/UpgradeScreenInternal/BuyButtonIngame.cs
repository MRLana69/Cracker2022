namespace UI.Screens.UpgradeScreenInternal;

public class BuyButtonIngame : MonoBehaviour, IBuyButton
{
	public UpgradeHelper updater; //Field offset: 0xC
	private UpgradeType _type; //Field offset: 0x10
	private bool _purchaseInProgress; //Field offset: 0x14

	public UpgradeType type
	{
		 get { } //Length: 940
	}

	public BuyButtonIngame() { }

	public UpgradeType get_type() { }

	public void InitBuyButton(UpgradeType type) { }

	private void OnClick() { }

	public void OnPurchaseFailure() { }

	public void OnPurchaseSuccessful() { }

}

