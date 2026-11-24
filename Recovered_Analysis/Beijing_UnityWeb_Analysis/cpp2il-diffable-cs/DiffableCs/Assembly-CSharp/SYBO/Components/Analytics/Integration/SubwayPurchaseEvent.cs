namespace SYBO.Components.Analytics.Integration;

public abstract class SubwayPurchaseEvent : SubwayBaseSessionEvent
{
	public readonly long PurchaseId; //Field offset: 0x28
	public readonly string MenusBefore; //Field offset: 0x30
	public readonly Nullable<int> GameNumberOrNull; //Field offset: 0x34
	public readonly string ItemTitleId; //Field offset: 0x3C
	public readonly int ItemType; //Field offset: 0x40

	public SubwayPurchaseEvent(string itemTitleId, ItemType itemType, long purchaseId, string menusBefore, Nullable<int> gameNumberOrNull) { }

}

