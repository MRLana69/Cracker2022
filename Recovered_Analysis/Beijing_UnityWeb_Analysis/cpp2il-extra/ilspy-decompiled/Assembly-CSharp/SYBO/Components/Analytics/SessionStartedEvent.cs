using System;
using Cpp2ILInjected;
using Info;

namespace SYBO.Components.Analytics;

public class SessionStartedEvent : AnalyticsEvent
{
	protected int _sessionID;

	public static Func<int> GetIncrementedSessionID;

	public int SessionId
	{
		get
		{
			//IL_0036: Expected I4, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11995");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			string format = default;
			return (int)string.Format((IFormatProvider)(object)"{0} for user {1}", format, _userID);
		}
	}

	public override string EventName
	{
		get
		{
			//IL_0007: Expected Obj, but got I4
			return (string)_sessionID;
		}
	}

	public SessionStartedEvent()
	{
		//IL_0011: Expected Obj, but got VT
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected Obj, but got Unknown
		DateTime userBirthday = AgeRestriction.GetUserBirthday();
		object obj = userBirthday;
		object obj2 = obj + 8;
		obj2 = obj;
		throw new ArrayTypeMismatchException();
	}
}
