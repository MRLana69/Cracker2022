using System;
using Cpp2ILInjected;

namespace SYBO.Components.Analytics;

public class SessionStartedEvent : AnalyticsEvent
{
	protected int SessionID;

	protected string EventTime;

	protected string GameVersion;

	public static Func<int> GetIncrementedSessionID;

	public override string EventName => "session_started";

	public SessionStartedEvent()
	{
		Func<int> getIncrementedSessionID = GetIncrementedSessionID;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v18 @ S1_v6 (System.Func`1<System.Int32>)+C] (should have been resolved before IL gen)");
		int sessionID = default;
		SessionID = sessionID;
		string eventTimeText = GetEventTimeText();
		EventTime = eventTimeText;
		Func<string> getGameVersion = AnalyticsEvent.GetGameVersion;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v34 @ S1_v14 (System.Func`1<System.String>)+C] (should have been resolved before IL gen)");
		string gameVersion = default;
		GameVersion = gameVersion;
	}
}
