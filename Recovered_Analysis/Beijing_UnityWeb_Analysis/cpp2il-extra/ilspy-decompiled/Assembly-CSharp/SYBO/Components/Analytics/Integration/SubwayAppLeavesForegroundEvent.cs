using System;
using Cpp2ILInjected;

namespace SYBO.Components.Analytics.Integration;

public class SubwayAppLeavesForegroundEvent : SubwayBaseSessionEvent
{
	public override string EventName
	{
		get
		{
			//IL_0006: Expected Obj, but got I4
			return (string)(-1);
		}
	}

	public SubwayAppLeavesForegroundEvent()
	{
		((AppLeavesForegroundEvent)(object)this)._002Ector();
	}

	public SubwayAppLeavesForegroundEvent(DateTime eventTime, int sessionDelta)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
	}
}
