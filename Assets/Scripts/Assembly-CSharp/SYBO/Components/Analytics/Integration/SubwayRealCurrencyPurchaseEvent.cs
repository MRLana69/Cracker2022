namespace SYBO.Components.Analytics.Integration;

public class SubwayRealCurrencyPurchaseEvent : SubwayPurchaseEvent
{
	public readonly string Vendor;

	public readonly float LocalCurrencyPrice;

	public override string EventName => "real_currency_purchase";

	public SubwayRealCurrencyPurchaseEvent(string itemTitleId, InAppItemModel.ItemType itemType, long purchaseNumber, string menusBefore, int? gameNumberOrNull, string vendor, float localCurrencyPrice)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		object obj = default;
		int? num = (int?)(object)(obj - 16);
		base._002Ector(itemTitleId, itemType, purchaseNumber, menusBefore, gameNumberOrNull);
		Vendor = vendor;
		LocalCurrencyPrice = localCurrencyPrice;
	}
}
