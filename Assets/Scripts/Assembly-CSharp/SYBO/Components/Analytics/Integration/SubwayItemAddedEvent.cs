namespace SYBO.Components.Analytics.Integration;

public class SubwayItemAddedEvent : SubwayBaseSessionEvent
{
	public readonly int Source;

	public readonly long SourceId;

	public readonly string ItemTitleId;

	public readonly int ItemType;

	public readonly long ItemBalanceAfter;

	public readonly long ItemDelta;

	protected readonly string EventTime;

	public override string EventName => "item_added";

	public SubwayItemAddedEvent(ObtainableItemSource source, long sourceId, string itemTitleId, InAppItemModel.ItemType itemType, long itemBalanceAfter, long itemDelta)
	{
		ItemTitleId = itemTitleId;
		SourceId = sourceId;
		Source = (int)source;
		ItemDelta = itemDelta;
		ItemBalanceAfter = itemBalanceAfter;
		ItemType = (int)itemType;
		string eventTimeText = GetEventTimeText();
		EventTime = eventTimeText;
	}
}
