using Cpp2ILInjected;
using SYBO.Components.Logging.Ftp;

namespace SYBO.Components.Analytics.Integration;

public class GameContinuedEvent : SubwayBaseSessionEvent
{
	public int GameID;

	public int AutoRevive;

	public int RevivedWithAdds;

	public int AdsAvailable;

	public int AdsFailed;

	public override string EventName => "run_summary";

	public GameContinuedEvent(int gameIdInSession, bool autoRevived, bool revivedWithAds, bool adsWasAvailable, bool adsFailed)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected Obj, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected Obj, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected Obj, but got Unknown
		//IL_00bb: Expected I, but got Obj
		//IL_00d1: Expected Obj, but got I
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected Obj, but got Unknown
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected Obj, but got Unknown
		//IL_0124: Expected Obj, but got I4
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected Obj, but got Unknown
		//IL_0137: Expected Obj, but got I4
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected Obj, but got Unknown
		//IL_014a: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		object obj = this + 12;
		obj = "localhost";
		object obj2 = this + 16;
		obj2 = ".";
		object obj3 = this + 20;
		obj3 = "anonymous";
		object obj4 = this + 24;
		obj4 = "anonymous@anonymous.net";
		GameID = 21;
		nint num = (nint)typeof(FtpClient);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v15 (Il2CppClass<SYBO.Components.Logging.Ftp.FtpClient>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(FtpClient);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v30 (Il2CppClass<SYBO.Components.Logging.Ftp.FtpClient>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj6 = this + 52;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj7 = default;
		obj6 = obj7;
		_ = 10;
		object obj8 = this + 12;
		obj8 = gameIdInSession;
		object obj9 = this + 20;
		obj9 = autoRevived;
		object obj10 = this + 24;
		obj10 = revivedWithAds;
		GameID = (adsFailed ? 1 : 0);
	}
}
