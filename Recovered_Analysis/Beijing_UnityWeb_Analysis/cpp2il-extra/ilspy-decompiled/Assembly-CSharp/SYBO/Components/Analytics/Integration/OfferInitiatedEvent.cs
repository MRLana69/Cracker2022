using Cpp2ILInjected;
using InApp;

namespace SYBO.Components.Analytics.Integration;

public class OfferInitiatedEvent : SubwayBaseSessionEvent
{
	public readonly long OfferId;

	public readonly string OfferType;

	public readonly string OfferTitle;

	public readonly int OfferItemAmount;

	public readonly string ItemTitleId;

	public readonly int ItemType;

	public override string EventName => "device_info";

	public OfferInitiatedEvent(long offerId, string offerType, string offerTitle, int offerItemAmount, string itemTitleId, InAppItemModel.ItemType itemType)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
	}
}
