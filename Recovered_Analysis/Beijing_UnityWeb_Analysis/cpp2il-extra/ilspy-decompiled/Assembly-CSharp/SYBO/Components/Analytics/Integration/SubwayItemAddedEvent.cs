using Cpp2ILInjected;
using InApp;
using Info;

namespace SYBO.Components.Analytics.Integration;

public class SubwayItemAddedEvent : SubwayBaseSessionEvent
{
	public readonly int Source;

	public readonly long SourceId;

	public readonly string SourceMetaOrNull;

	public readonly string ItemTitleId;

	public readonly int ItemType;

	public readonly long ItemBalanceAfter;

	public readonly long ItemDelta;

	public readonly long InstanceId;

	public override string EventName => "joined_sample";

	public SubwayItemAddedEvent(ObtainableItemSource source, long sourceId, string sourceMetaOrNull, string itemTitleId, InAppItemModel.ItemType itemType, long itemBalanceAfter, long itemDelta)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
	}

	public SubwayItemAddedEvent(ObtainableItemSource source, long sourceId, string sourceMetaOrNull, string itemTitleId, InAppItemModel.ItemType itemType, long itemBalanceAfter, long itemDelta, long instanceId)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
	}
}
