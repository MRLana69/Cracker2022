using System;
using Cpp2ILInjected;

namespace SYBO.Components.Analytics.Integration;

public class SubwayAccountCreatedEvent : AccountCreatedEvent, ISubwayBaseEvent
{
	public static Func<string> GetOperatingSystem;

	protected string KilooUserID;

	protected string PlatformConfig;

	protected string FirstStartupAt;

	public string Uid => UserId;

	public string Id => EventId;

	public int SessionId => SessionID;

	public int EventNumber => SessionEventID;

	public string KilooId => KilooUserID;

	public SubwayAccountCreatedEvent(string kilooUserID, string platformConfig, DateTime firstStartupAt)
	{
		KilooUserID = kilooUserID;
		PlatformConfig = platformConfig;
		string timeText = AnalyticsEvent.GetTimeText(firstStartupAt);
		FirstStartupAt = timeText;
		Func<string> getOperatingSystem = GetOperatingSystem;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v28 @ S1_v10 (System.Func`1<System.String>)+C] (should have been resolved before IL gen)");
		string text = default;
		deviceOS = text;
	}
}
