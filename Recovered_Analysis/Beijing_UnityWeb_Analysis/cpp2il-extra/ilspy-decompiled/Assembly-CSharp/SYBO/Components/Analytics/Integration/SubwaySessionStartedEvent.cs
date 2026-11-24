using Cpp2ILInjected;

namespace SYBO.Components.Analytics.Integration;

public class SubwaySessionStartedEvent : SessionStartedEvent, ISubwayBaseEvent
{
	public long HighScore;

	public long CoinBalance;

	public long KeyBalance;

	public int SessionEventId
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Analytics.Integration.SubwaySessionStartedEvent)+38]");
			return 0;
		}
	}

	public SubwaySessionStartedEvent()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(BaseSessionEvent);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Analytics.BaseSessionEvent>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(BaseSessionEvent);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<SYBO.Components.Analytics.BaseSessionEvent>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((BaseSessionEvent)(object)this).InitializeCommon();
	}
}
