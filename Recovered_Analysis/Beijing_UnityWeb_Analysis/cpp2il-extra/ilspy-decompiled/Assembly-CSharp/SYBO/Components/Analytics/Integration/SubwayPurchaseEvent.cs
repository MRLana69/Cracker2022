using Cpp2ILInjected;
using InApp;

namespace SYBO.Components.Analytics.Integration;

public abstract class SubwayPurchaseEvent : SubwayBaseSessionEvent
{
	public readonly long PurchaseId;

	public readonly string MenusBefore;

	public readonly int? GameNumberOrNull;

	public readonly string ItemTitleId;

	public readonly int ItemType;

	public SubwayPurchaseEvent(string itemTitleId, InAppItemModel.ItemType itemType, long purchaseId, string menusBefore, int? gameNumberOrNull)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
	}
}
