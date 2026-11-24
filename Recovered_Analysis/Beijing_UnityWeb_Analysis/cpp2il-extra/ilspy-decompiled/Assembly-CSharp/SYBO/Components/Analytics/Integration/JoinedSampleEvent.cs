using Cpp2ILInjected;

namespace SYBO.Components.Analytics.Integration;

public class JoinedSampleEvent : SubwayBaseSessionEvent
{
	public readonly int Source;

	public readonly long SourceId;

	public readonly string AggregatedDataCompleteness;

	public readonly int DaysPlayed;

	public readonly int SessionCount;

	public readonly int KeysBalance;

	public readonly int KeysReceived;

	public readonly int CoinsBalance;

	public readonly int CoinsReceived;

	public readonly int MissingKeysCount;

	public readonly int MissingCoinsCount;

	public readonly int HighScore;

	public override string EventName
	{
		get
		{
			//IL_000d: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Analytics.Integration.JoinedSampleEvent)+2C]");
			return (string)0;
		}
	}

	public JoinedSampleEvent(JoinedSampleSource source, long sourceId, AggregatedDataTracking.DataCompleteness aggregatedDataCompleteness, int daysPlayed, int sessionCount, int keysBalance, int keysReceived, int coinsBalance, int coinsReceived, int missingKeysCount, int missingCoinsCount, int highscore)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
	}
}
