namespace SYBO.Components.Analytics.Integration;

public class PlayerDiedEvent : SubwayBaseSessionEvent
{
	public int GameID; //Field offset: 0x24
	public int RunTime; //Field offset: 0x28
	public string DeathCause; //Field offset: 0x2C
	public string LastObstacle; //Field offset: 0x30
	public float Speed; //Field offset: 0x34
	public string Chunk; //Field offset: 0x38
	public string ChunkPrev; //Field offset: 0x3C
	public string ChunkNext; //Field offset: 0x40
	public float PositionInChunk; //Field offset: 0x44
	public string Lane; //Field offset: 0x48
	public int MaxFrameTime2s; //Field offset: 0x4C

	public override string EventName
	{
		 get { } //Length: 43
	}

	public PlayerDiedEvent() { }

	public override string get_EventName() { }

}

