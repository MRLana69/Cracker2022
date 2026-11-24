using Cpp2ILInjected;
using SYBO.Subway.Benchmarking;

namespace SYBO.Components.Analytics.Integration;

public class SessionTracker
{
	private int _sessionTimeoutSeconds;

	private long _msTicksWhenLastActive;

	public SessionTracker(int sessionTimeoutSeconds)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_0059: Expected Obj, but got I
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected Obj, but got Unknown
		//IL_0074: Expected Obj, but got I
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		//IL_008d: Expected Obj, but got I4
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected Obj, but got Unknown
		//IL_012a: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sessionTimeoutSeconds @ L1 (System.Int32)+C]");
		bool flag = (nint)0 != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sessionTimeoutSeconds @ L1 (System.Int32)+D]");
		bool flag2 = (nint)0 != 0;
		object obj = this + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sessionTimeoutSeconds @ L1 (System.Int32)+10]");
		obj = 0;
		object obj2 = this + 36;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sessionTimeoutSeconds @ L1 (System.Int32)+24]");
		obj2 = 0;
		object obj3 = this - -64;
		object obj4 = sessionTimeoutSeconds - -64;
		obj3 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sessionTimeoutSeconds @ L1 (System.Int32)+14]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sessionTimeoutSeconds @ L1 (System.Int32)+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sessionTimeoutSeconds @ L1 (System.Int32)+1C]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sessionTimeoutSeconds @ L1 (System.Int32)+20]");
		bool flag3 = (nint)0 != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sessionTimeoutSeconds @ L1 (System.Int32)+2C]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sessionTimeoutSeconds @ L1 (System.Int32)+30]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sessionTimeoutSeconds @ L1 (System.Int32)+34]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sessionTimeoutSeconds @ L1 (System.Int32)+38]");
		_ = 0;
		object obj5 = this + 60;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sessionTimeoutSeconds @ L1 (System.Int32)+3C]");
		obj5 = 0;
	}

	public void RegisterLastActiveMsTicks()
	{
		//IL_000b: Expected Obj, but got I4
		((FramerateTracker)_sessionTimeoutSeconds).ResetFrameTimes();
	}

	public long GetMSTicksSinceLastActive()
	{
		//IL_000d: Expected I8, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Analytics.Integration.SessionTracker)+28]");
		return 0L;
	}

	public bool ShouldStartNewSession()
	{
		//IL_000b: Expected I4, but got Obj
		return (byte)(int)"dev_session_started" != 0;
	}

	public bool ShouldStartNewSession(long msTicksSinceLastActive)
	{
		return msTicksSinceLastActive > 2000;
	}
}
