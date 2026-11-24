namespace SYBO.Components.Analytics.Integration;

public class SubwayItemAddedEvent : SubwayBaseSessionEvent
{
	public readonly int Source; //Field offset: 0x24
	public readonly long SourceId; //Field offset: 0x28
	public readonly string SourceMetaOrNull; //Field offset: 0x30
	public readonly string ItemTitleId; //Field offset: 0x34
	public readonly int ItemType; //Field offset: 0x38
	public readonly long ItemBalanceAfter; //Field offset: 0x40
	public readonly long ItemDelta; //Field offset: 0x48
	public readonly long InstanceId; //Field offset: 0x50

	public override string EventName
	{
		 get { } //Length: 43
	}

	public SubwayItemAddedEvent(ObtainableItemSource source, long sourceId, string sourceMetaOrNull, string itemTitleId, ItemType itemType, long itemBalanceAfter, long itemDelta) { }

	public SubwayItemAddedEvent(ObtainableItemSource source, long sourceId, string sourceMetaOrNull, string itemTitleId, ItemType itemType, long itemBalanceAfter, long itemDelta, long instanceId) { }

	public override string get_EventName() { }

}

