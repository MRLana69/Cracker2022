namespace SYBO.Components.Analytics.Integration;

public class SubwayRealCurrencyPurchaseEvent : SubwayPurchaseEvent
{
	public readonly string Vendor; //Field offset: 0x44
	public readonly float LocalCurrencyPrice; //Field offset: 0x48

	public override string EventName
	{
		 get { } //Length: 43
	}

	public SubwayRealCurrencyPurchaseEvent(string itemTitleId, ItemType itemType, long purchaseId, string menusBefore, Nullable<int> gameNumberOrNull, string vendor, float localCurrencyPrice) { }

	public override string get_EventName() { }

}

