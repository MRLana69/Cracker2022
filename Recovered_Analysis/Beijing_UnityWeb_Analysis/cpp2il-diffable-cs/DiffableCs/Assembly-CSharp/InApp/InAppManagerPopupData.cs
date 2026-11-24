namespace InApp;

public class InAppManagerPopupData
{
	public string popupTitle; //Field offset: 0x8
	public string popupDescription; //Field offset: 0xC
	public string popupName; //Field offset: 0x10
	public bool canMakePurchase; //Field offset: 0x14
	public bool isCoinsPack; //Field offset: 0x15
	public bool isErrorMessage; //Field offset: 0x16
	public int currencyMissing; //Field offset: 0x18
	public InAppItemModel bestOffer; //Field offset: 0x1C

	public InAppManagerPopupData() { }

}

