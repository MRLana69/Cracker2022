namespace SYBO.Components.Analytics.Integration;

public class OfferInitiatedEvent : SubwayBaseSessionEvent
{
	public readonly long OfferId; //Field offset: 0x28
	public readonly string OfferType; //Field offset: 0x30
	public readonly string OfferTitle; //Field offset: 0x34
	public readonly int OfferItemAmount; //Field offset: 0x38
	public readonly string ItemTitleId; //Field offset: 0x3C
	public readonly int ItemType; //Field offset: 0x40

	public override string EventName
	{
		 get { } //Length: 43
	}

	public OfferInitiatedEvent(long offerId, string offerType, string offerTitle, int offerItemAmount, string itemTitleId, ItemType itemType) { }

	public override string get_EventName() { }

}

