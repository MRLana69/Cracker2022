using Cpp2ILInjected;
using InApp;

namespace SYBO.Components.Analytics.Integration;

public class SubwayRealCurrencyPurchaseEvent : SubwayPurchaseEvent
{
	public readonly string Vendor;

	public readonly float LocalCurrencyPrice;

	public override string EventName => "ingame_currency_purchase";

	public SubwayRealCurrencyPurchaseEvent(string itemTitleId, InAppItemModel.ItemType itemType, long purchaseId, string menusBefore, int? gameNumberOrNull, string vendor, float localCurrencyPrice)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
	}
}
