namespace InAppPurchase;

public struct ProductRequestResultInfo
{
	public string productId; //Field offset: 0x0
	public string localizedPrice; //Field offset: 0x4
	public string title; //Field offset: 0x8
	public string description; //Field offset: 0xC

	public void Init(string productId, string localizedPrice, string title, string description) { }

}

