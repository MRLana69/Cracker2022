namespace SYBO.Components.Analytics.Integration;

public class UnsampledIngameCurrencyPurchasesEvent : SubwayBaseSessionEvent
{
	public readonly string ItemTitleId; //Field offset: 0x24
	public readonly int Amount; //Field offset: 0x28

	public override string EventName
	{
		 get { } //Length: 43
	}

	public UnsampledIngameCurrencyPurchasesEvent(string itemTitleId, int amount) { }

	public override string get_EventName() { }

}

