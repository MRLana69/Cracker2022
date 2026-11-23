using System;
using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Components.Analytics;

public abstract class BaseSessionEvent : AnalyticsEvent
{
	protected int SessionID;

	protected int SessionDelta;

	protected int SessionEventID;

	public static Func<int> GetSessionID;

	public static Func<int> GetSessionDelta;

	public static Func<int> GetIncrementedSessionEventNumber;

	public static Func<string> GetDeviceID;

	private static Func<string> _003C_003Ef__mg_0024cache0;

	public BaseSessionEvent()
	{
		Func<int> getSessionID = GetSessionID;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v19 @ S1_v6 (System.Func`1<System.Int32>)+C] (should have been resolved before IL gen)");
		int sessionID = default;
		SessionID = sessionID;
		Func<int> getSessionDelta = GetSessionDelta;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v31 @ S1_v12 (System.Func`1<System.Int32>)+C] (should have been resolved before IL gen)");
		int sessionDelta = default;
		SessionDelta = sessionDelta;
		Func<int> getIncrementedSessionEventNumber = GetIncrementedSessionEventNumber;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v43 @ S1_v18 (System.Func`1<System.Int32>)+C] (should have been resolved before IL gen)");
		int sessionEventID = default;
		SessionEventID = sessionEventID;
	}

	private static string GetDefaultDeviceID()
	{
		return SystemInfo.GetDeviceUniqueIdentifier();
	}

	static BaseSessionEvent()
	{
		throw new ArgumentException();
	}
}
