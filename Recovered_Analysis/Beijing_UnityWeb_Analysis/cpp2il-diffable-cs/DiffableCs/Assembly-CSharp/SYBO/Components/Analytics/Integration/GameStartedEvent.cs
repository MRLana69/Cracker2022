namespace SYBO.Components.Analytics.Integration;

public class GameStartedEvent : SubwayBaseSessionEvent
{
	public int GameID; //Field offset: 0x24
	public string Character; //Field offset: 0x28
	public string CharacterOutfit; //Field offset: 0x2C
	public string Board; //Field offset: 0x30
	public string BoardAbilityTypesAdded; //Field offset: 0x34
	public string BoardAbilityDescriptionsAdded; //Field offset: 0x38
	public short PlayerLevel; //Field offset: 0x3C
	public long HighScore; //Field offset: 0x40
	public long CoinBalance; //Field offset: 0x48
	public long KeyBalance; //Field offset: 0x50
	public long HoverboardBalance; //Field offset: 0x58
	public long HeadStartBalance; //Field offset: 0x60
	public long ScoreBoosterBalance; //Field offset: 0x68

	public override string EventName
	{
		 get { } //Length: 43
	}

	public GameStartedEvent() { }

	public override string get_EventName() { }

}

