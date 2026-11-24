namespace SYBO.Components.Analytics.Integration;

public class PlayerDiedEvent : SubwayBaseSessionEvent
{
	public int GameID;

	public int RunTime;

	public string DeathCause;

	public string LastObstacle;

	public float Speed;

	public string Chunk;

	public string ChunkPrev;

	public string ChunkNext;

	public float PositionInChunk;

	public string Lane;

	public int MaxFrameTime2s;

	public override string EventName => "game_started";

	public PlayerDiedEvent()
	{
		((SubwaySessionStartedEvent)(object)this)._002Ector();
	}
}
