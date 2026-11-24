namespace SYBO.Components.Analytics.Integration;

public class GameContinuedEvent : SubwayBaseSessionEvent
{
	public int GameID; //Field offset: 0x24
	public int AutoRevive; //Field offset: 0x28
	public int RevivedWithAdds; //Field offset: 0x2C
	public int AdsAvailable; //Field offset: 0x30
	public int AdsFailed; //Field offset: 0x34

	public override string EventName
	{
		 get { } //Length: 43
	}

	public GameContinuedEvent(int gameIdInSession, bool autoRevived, bool revivedWithAds, bool adsWasAvailable, bool adsFailed) { }

	public override string get_EventName() { }

}

