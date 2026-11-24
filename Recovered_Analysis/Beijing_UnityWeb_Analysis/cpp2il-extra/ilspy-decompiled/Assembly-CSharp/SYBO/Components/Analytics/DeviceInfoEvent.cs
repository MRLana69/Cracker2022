using Cpp2ILInjected;
using SYBO.Components.Json;
using SYBO.Components.Native;

namespace SYBO.Components.Analytics;

public class DeviceInfoEvent : BaseSessionEvent
{
	public readonly string DeviceOS;

	public readonly string Device;

	public readonly string DeviceID;

	public readonly string Language;

	public readonly int ScreenHeight;

	public readonly int ScreenWidth;

	public readonly int ScreenPPI;

	public readonly string Gpu;

	public readonly int CpuTreads;

	public readonly int CpuFrequencey;

	public readonly int SystemMemory;

	public override string EventName => "app_leaves_foreground";

	public DeviceInfoEvent()
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
		InitializeCommon();
	}

	protected DeviceInfoEvent(bool initializeParentValues)
		: base(initializeParentValues)
	{
		//IL_0019: Expected I, but got Obj
		//IL_002f: Expected Obj, but got I
		//IL_005a: Expected I, but got Obj
		if (!initializeParentValues)
		{
			return;
		}
		((AccountCreatedEvent)this)._002Ector();
		nint num = (nint)typeof(BaseSessionEvent);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v10 (Il2CppClass<SYBO.Components.Analytics.BaseSessionEvent>)+BA]");
		if ((object)((nint)0 & (nint)0x200) != null)
		{
			nint num2 = (nint)typeof(BaseSessionEvent);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v15 (Il2CppClass<SYBO.Components.Analytics.BaseSessionEvent>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int sessionDelta = BaseSessionEvent.GetSessionDelta();
		_sessionDelta = sessionDelta;
	}

	public static string GetDeviceInfoJson()
	{
		return Platform.GetPlatformVersion();
	}

	public static string GetTrimmedGPUName()
	{
		//IL_0030: Expected Obj, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		PersistentAnalyticsEventLog persistentAnalyticsEventLog = default;
		persistentAnalyticsEventLog.HasData = false;
		return (string)JsonApi.ReflectionDeserializeDom<T>((object)persistentAnalyticsEventLog, (JsonContext)null);
	}
}
