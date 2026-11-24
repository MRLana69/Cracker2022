using Cpp2ILInjected;
using Kiloo.Common.Plugins.DeviceUtility;
using SYBO.Common.Utilities;
using SYBO.Subway.Benchmarking;
using UnityEngine;

namespace SYBO.Components.Analytics.Integration;

public class PerformanceTracker : IPerformanceTracker
{
	private const int MaxFrameTimeSampleCount = 10;

	private FramerateTracker _framerateTracker;

	public float AverageInGameFramerate
	{
		get
		{
			//IL_000d: Expected F4, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Analytics.Integration.PerformanceTracker)+14]");
			return 0f;
		}
	}

	public float MaxFrameTimeMS => _framerateTracker.GetPotentialFramerate();

	public PerformanceTracker(float maxFrameTimeSampleRangeMS)
	{
	}

	private void Game_OnGameStarted()
	{
		//IL_028c: Expected I, but got Obj
		//IL_02a2: Expected Obj, but got I
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Expected Obj, but got Unknown
		//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Expected Obj, but got Unknown
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Expected Obj, but got Unknown
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Expected Obj, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected Obj, but got Unknown
		//IL_0089: Expected I, but got Obj
		//IL_009f: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0362: Expected Obj, but got Unknown
		//IL_0111: Expected Obj, but got I4
		//IL_00ca: Expected I, but got Obj
		//IL_014d: Expected F4, but got I4
		//IL_037b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Expected Obj, but got Unknown
		//IL_0186: Expected F4, but got I4
		//IL_01bf: Expected F4, but got I4
		//IL_01f8: Expected I, but got Obj
		//IL_020e: Expected Obj, but got I
		//IL_03bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c0: Expected Obj, but got Unknown
		//IL_0239: Expected I, but got Obj
		((SubwaySessionStartedEvent)this)._002Ector();
		nint num = (nint)typeof(BaseSessionEvent);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v7 (Il2CppClass<SYBO.Components.Analytics.BaseSessionEvent>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(BaseSessionEvent);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v52 (Il2CppClass<SYBO.Components.Analytics.BaseSessionEvent>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = this + 36;
		string text = BaseSessionEvent.GetOperatingSystem();
		obj2 = text;
		object obj3 = this + 40;
		obj3 = "ios";
		object obj4 = this + 44;
		string text2 = BaseSessionEvent.GetDeviceModel();
		obj4 = text2;
		object obj5 = this + 48;
		string text3 = BaseSessionEvent.GetDeviceID();
		obj5 = text3;
		object obj6 = this + 52;
		string text4 = BaseSessionEvent.GetISOThreeLetterLanguageCode();
		obj6 = text4;
		nint num3 = (nint)typeof(DeviceInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v22 (Il2CppClass<DeviceInfo>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num4 = (nint)typeof(DeviceInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v48 (Il2CppClass<DeviceInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int runAverageFPS = InRunAverageFPSCounter.runAverageFPS;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S1_v32 (System.Int32)+8]");
		_ = 0;
		int sleepTimeout = Screen.sleepTimeout;
		object obj8 = this - -64;
		int height = Screen.height;
		obj8 = height;
		float value = Random.value;
		if (value != value)
		{
			value = -2.1474836E+09f;
		}
		else if (!(value < 2.1474836E+09f))
		{
			value = -2.1474836E+09f;
		}
		else if (!(value > -2.1474836E+09f))
		{
			value = -2.1474836E+09f;
		}
		object obj9 = this + 72;
		SYBO.Common.Utilities.IRandomGen randomGen = SYBO.Common.Utilities.SyboRandom.MakeRandomGen();
		obj9 = randomGen;
		int runAverageFPS2 = InRunAverageFPSCounter.runAverageFPS;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S1_v47 (System.Int32)+1C]");
		_ = 0;
		int physicalMemoryMB = SystemInfo.GetPhysicalMemoryMB();
		int processorCount = SystemInfo.GetProcessorCount();
		string deviceUniqueIdentifier = SystemInfo.GetDeviceUniqueIdentifier();
		nint num5 = (nint)typeof(DeviceUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S0_v38 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num6 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S0_v44 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj11 = this + 92;
		string unfilteredLocale = DeviceUtility.GetUnfilteredLocale();
		obj11 = unfilteredLocale;
	}

	private void Game_OnGameEnded()
	{
		_framerateTracker.EndTracking();
	}

	public void Reset()
	{
		_framerateTracker.Reset();
	}
}
