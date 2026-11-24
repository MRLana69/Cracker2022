namespace SYBO.Components.Analytics.Integration;

public class UnsampledIngameCurrencyPurchasesEvent : SubwayBaseSessionEvent
{
	public readonly string ItemTitleId;

	public readonly int Amount;

	public override string EventName => "mission_completed";

	public UnsampledIngameCurrencyPurchasesEvent(string itemTitleId, int amount)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected Obj, but got Unknown
		((SubwaySessionStartedEvent)(object)this)._002Ector();
		object obj = this + 36;
		obj = itemTitleId;
		Amount = amount;
	}
}
