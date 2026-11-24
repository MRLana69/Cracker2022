using Cpp2ILInjected;
using SYBO.Components.Logging;
using UnityEngine;

namespace SYBO.Components.Analytics.Integration;

public class DeviceInfoEvent : SubwayBaseSessionEvent
{
	public readonly string DeviceOS;

	public readonly string DevicePlatformConfig;

	public readonly string Device;

	public readonly string DeviceID;

	public readonly string Language;

	public readonly int PerformanceLevel;

	public readonly int ScreenHeight;

	public readonly int ScreenWidth;

	public readonly int ScreenPPI;

	public readonly string Gpu;

	public readonly int GpuScore;

	public readonly int CpuTreads;

	public readonly int CpuFrequencey;

	public readonly int SystemMemory;

	public readonly string OnlineSettingsLocale;

	public override string EventName
	{
		get
		{
			//IL_0007: Expected Obj, but got I4
			return (string)PerformanceLevel;
		}
	}

	public DeviceInfoEvent()
	{
		((SubwaySessionStartedEvent)(object)this)._002Ector();
	}

	public DeviceInfo.PerformanceLevel GetPerformanceLevel()
	{
		//IL_000b: Expected I4, but got Obj
		return (DeviceInfo.PerformanceLevel)"real_currency_purchase";
	}

	public static string GetTrimmedGPUName()
	{
		//IL_00fc: Expected I, but got Obj
		//IL_0112: Expected Obj, but got I
		//IL_01db: Expected Obj, but got F4
		//IL_013d: Expected I, but got Obj
		string dataPath = Application.dataPath;
		if ((nint)dataPath == 11)
		{
			return "google";
		}
		string dataPath2 = Application.dataPath;
		if ((nint)dataPath2 == 8)
		{
			return "apple";
		}
		string dataPath3 = Application.dataPath;
		if ((nint)dataPath3 != 20)
		{
			string dataPath4 = Application.dataPath;
			if ((nint)dataPath4 != 18)
			{
				string dataPath5 = Application.dataPath;
				if ((nint)dataPath5 != 19)
				{
					nint num = (nint)typeof(Log);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v28 (Il2CppClass<SYBO.Components.Logging.Log>)+BA]");
					object obj = (nint)0 & (nint)0x200;
					if (obj != null)
					{
						nint num2 = (nint)typeof(Log);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v36 (Il2CppClass<SYBO.Components.Logging.Log>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					float timeSinceLevelLoad = Time.timeSinceLevelLoad;
					object obj2 = timeSinceLevelLoad;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
					object[] args = default;
					Log.Analytics.LogErrorFormat(0, "[SYBO Analytics] - {0:0.00}s : Could not determine purchase platform!", args);
					return null;
				}
			}
		}
		return "microsoft";
	}
}
