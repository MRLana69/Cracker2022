namespace SYBO.Components.Analytics.Integration;

public abstract class SubwayPurchaseEvent : SubwayBaseSessionEvent
{
	public readonly long PurchaseNumber;

	public readonly string MenusBefore;

	public readonly int? GameNumberOrNull;

	public readonly string ItemTitleId;

	public readonly int ItemType;

	protected readonly string EventTime;

	public SubwayPurchaseEvent(string itemTitleId, InAppItemModel.ItemType itemType, long purchaseNumber, string menusBefore, int? gameNumberOrNull)
	{
		ItemTitleId = itemTitleId;
		MenusBefore = menusBefore;
		PurchaseNumber = purchaseNumber;
		ItemType = (int)itemType;
		GameNumberOrNull = gameNumberOrNull;
		string eventTimeText = GetEventTimeText();
		EventTime = eventTimeText;
	}
}
