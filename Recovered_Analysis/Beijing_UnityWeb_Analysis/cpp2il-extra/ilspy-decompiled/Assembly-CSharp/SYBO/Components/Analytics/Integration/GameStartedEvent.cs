namespace SYBO.Components.Analytics.Integration;

public class GameStartedEvent : SubwayBaseSessionEvent
{
	public int GameID;

	public string Character;

	public string CharacterOutfit;

	public string Board;

	public string BoardAbilityTypesAdded;

	public string BoardAbilityDescriptionsAdded;

	public short PlayerLevel;

	public long HighScore;

	public long CoinBalance;

	public long KeyBalance;

	public long HoverboardBalance;

	public long HeadStartBalance;

	public long ScoreBoosterBalance;

	public override string EventName => "app_leaves_foreground";

	public GameStartedEvent()
	{
		((SubwaySessionStartedEvent)(object)this)._002Ector();
	}
}
