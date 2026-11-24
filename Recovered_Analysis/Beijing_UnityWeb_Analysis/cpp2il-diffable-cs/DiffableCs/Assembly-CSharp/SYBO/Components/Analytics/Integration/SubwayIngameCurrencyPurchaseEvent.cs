namespace SYBO.Components.Analytics.Integration;

public class SubwayIngameCurrencyPurchaseEvent : SubwayPurchaseEvent
{
	public readonly string CurrencyType; //Field offset: 0x44
	public readonly long CurrencyDelta; //Field offset: 0x48
	public readonly long CurrencyBalanceAfter; //Field offset: 0x50

	public override string EventName
	{
		 get { } //Length: 43
	}

	public SubwayIngameCurrencyPurchaseEvent(string itemTitleId, ItemType itemType, long purchaseId, string menusBefore, Nullable<int> gameNumberOrNull, InGameCurrencyType currencyType, long currencyDelta, long currencyBalanceAfter) { }

	public override string get_EventName() { }

}

