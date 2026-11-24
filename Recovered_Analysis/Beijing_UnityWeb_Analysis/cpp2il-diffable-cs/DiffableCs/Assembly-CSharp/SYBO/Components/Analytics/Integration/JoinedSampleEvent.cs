namespace SYBO.Components.Analytics.Integration;

public class JoinedSampleEvent : SubwayBaseSessionEvent
{
	public readonly int Source; //Field offset: 0x24
	public readonly long SourceId; //Field offset: 0x28
	public readonly string AggregatedDataCompleteness; //Field offset: 0x30
	public readonly int DaysPlayed; //Field offset: 0x34
	public readonly int SessionCount; //Field offset: 0x38
	public readonly int KeysBalance; //Field offset: 0x3C
	public readonly int KeysReceived; //Field offset: 0x40
	public readonly int CoinsBalance; //Field offset: 0x44
	public readonly int CoinsReceived; //Field offset: 0x48
	public readonly int MissingKeysCount; //Field offset: 0x4C
	public readonly int MissingCoinsCount; //Field offset: 0x50
	public readonly int HighScore; //Field offset: 0x54

	public override string EventName
	{
		 get { } //Length: 6
	}

	public JoinedSampleEvent(JoinedSampleSource source, long sourceId, DataCompleteness aggregatedDataCompleteness, int daysPlayed, int sessionCount, int keysBalance, int keysReceived, int coinsBalance, int coinsReceived, int missingKeysCount, int missingCoinsCount, int highscore) { }

	public override string get_EventName() { }

}

