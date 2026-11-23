namespace SYBO.Components.Analytics.Integration;

public class GameContinuedEvent : SubwayBaseSessionEvent
{
	public int GameID;

	public int AutoRevive;

	public override string EventName => "game_continued";

	public GameContinuedEvent(int gameIdInSession, bool autoRevived)
	{
		AutoRevive = (autoRevived ? 1 : 0);
		GameID = gameIdInSession;
	}
}
