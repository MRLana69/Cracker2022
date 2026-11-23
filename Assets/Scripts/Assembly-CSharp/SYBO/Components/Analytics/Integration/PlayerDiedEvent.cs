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

	public override string EventName => "player_died";
}
