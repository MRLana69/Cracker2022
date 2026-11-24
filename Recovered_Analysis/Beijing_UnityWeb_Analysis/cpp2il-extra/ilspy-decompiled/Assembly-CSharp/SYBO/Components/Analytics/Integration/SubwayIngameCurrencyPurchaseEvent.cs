using Cpp2ILInjected;
using InApp;

namespace SYBO.Components.Analytics.Integration;

public class SubwayIngameCurrencyPurchaseEvent : SubwayPurchaseEvent
{
	public readonly string CurrencyType;

	public readonly long CurrencyDelta;

	public readonly long CurrencyBalanceAfter;

	public override string EventName => "item_added";

	public SubwayIngameCurrencyPurchaseEvent(string itemTitleId, InAppItemModel.ItemType itemType, long purchaseId, string menusBefore, int? gameNumberOrNull, InGameCurrencyType currencyType, long currencyDelta, long currencyBalanceAfter)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
	}
}
