using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Common.Visuals;

public class QualityPlatformSupportIOS : IQualityPlatformSupport
{
	private enum IPhoneQualityCategory
	{
		HighPerformanceDevice
	}

	private bool _isInitialized;

	private Dictionary<IPhoneQualityCategory, bool> _qualityCategorySupport;

	private Dictionary<QualityFeature, IPhoneQualityCategory> _qualityFeatureCategory;

	public void Initialize()
	{
	}

	public bool IsSupported(QualityFeature feature)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(DeviceInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<DeviceInfo>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DeviceInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<DeviceInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int runAverageFPS = InRunAverageFPSCounter.runAverageFPS;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v11 (System.Int32)+8]");
		return (nint)0 >= (nint)2;
	}

	public QualityPlatformSupportIOS()
	{
		//IL_001e: Expected I, but got Obj
		//IL_0034: Expected Obj, but got I
		//IL_0160: Expected Obj, but got I
		//IL_0170: Expected Obj, but got I
		//IL_0180: Expected Obj, but got I
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected Obj, but got Unknown
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected Obj, but got Unknown
		//IL_01bd: Expected Obj, but got I4
		//IL_005f: Expected I, but got Obj
		//IL_00d9: Expected Obj, but got I4
		if (~(_isInitialized ? 1u : 0u) == 0)
		{
			return;
		}
		_isInitialized = true;
		nint num = (nint)typeof(DeviceInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v5 (Il2CppClass<DeviceInfo>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DeviceInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S1_v17 (Il2CppClass<DeviceInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int runAverageFPS = InRunAverageFPSCounter.runAverageFPS;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S2_v4 (System.Int32)+8]");
		bool flag = (nint)0 >= (nint)2;
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S4_v3 (Il2CppMethodInfo)+C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S4_v4+60]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S4_v5+48]");
		object obj4 = 0;
		object obj5 = obj4 & 0x7FF;
		object obj6 = obj5 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v31 @ S5_v5 (should have been resolved before IL gen)");
		OperatingSystemFamily operatingSystemFamily = SystemInfo.GetOperatingSystemFamily();
		if (!((string)operatingSystemFamily).EndsWith("iPhone OS 7"))
		{
			OperatingSystemFamily operatingSystemFamily2 = SystemInfo.GetOperatingSystemFamily();
			bool flag2 = ((string)operatingSystemFamily2).EndsWith("iOS 7");
		}
		string graphicsDeviceVersion = SystemInfo.GetGraphicsDeviceVersion();
		bool flag3 = graphicsDeviceVersion.EndsWith("Apple A7");
	}
}
