using System.Text;
using Cpp2ILInjected;
using SYBO.Components.Logging.Ftp;

namespace SYBO.Components.Analytics;

public class AnalyticsIntegrationConstants
{
	public const string PrefsKeySamplingKey = "AnalyticsComponent_SamplingKey";

	public const string PrefsKeySessionCounter = "AnalyticsComponent_SessionCounter";

	public const int PrefsKeySessionCounterDefault = -1;

	public const string PrefsKeyUserID = "AnalyticsComponent_UserID";

	public const string PrefsKeyClientVersion = "AnalyticsComponent_ClientVersion";

	public const string PrefsKeyDeviceInfo = "AnalyticsComponent_DeviceInfo";

	public const string PrefsKeySessionEventNumber = "AnalyticsComponent_SessionEventNumber";

	public const int PrefsKeySessionEventNumberDefault = -1;

	public const string PrefsKeyLeavesForegroundTime = "LeavesForegroundTime";

	public static readonly string PrefsKeyLeavesForegroundTimeDefault;

	public const string PrefsKeyLeavesForegroundSessionDelta = "LeavesForegroundSessionDelta";

	public const int PrefsKeyLeavesForegroundSessionDeltaDefault = -1;

	public const int EventJsonDeviceIdFieldSize = 44;

	public AnalyticsIntegrationConstants()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected Obj, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected Obj, but got Unknown
		//IL_00e5: Expected Obj, but got I4
		//IL_0100: Expected Obj, but got I
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected Obj, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 8;
		obj = obj2;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		object obj3 = obj + 4;
		object obj4 = obj3 + 1;
		obj3 = obj4;
		object obj5 = obj4 << 2;
		object obj6 = obj + obj5;
		obj6 = 15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+4]");
			object obj7 = (nint)0 << 2;
			object obj8 = obj + obj7;
			if ((nint)obj8 == 15)
			{
				object obj9 = obj + 4;
				if ((nint)obj9 > -1)
				{
					object obj10 = obj9 + -1;
					obj9 = obj10;
				}
				return;
			}
		}
		object obj11 = default;
		if (obj11 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	static AnalyticsIntegrationConstants()
	{
		//IL_0026: Expected I, but got Obj
		//IL_003c: Expected Obj, but got I
		FtpClient.BUFFER_SIZE = 512;
		Encoding latin = Encoding.Latin1;
		nint num = (nint)typeof(FtpClient);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v11 (Il2CppClass<SYBO.Components.Logging.Ftp.FtpClient>)+5C]");
		object obj = (nint)0 + (nint)4;
		obj = latin;
	}
}
