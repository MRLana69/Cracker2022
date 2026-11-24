using Cpp2ILInjected;
using Kiloo.Common.HTTP;
using Kiloo.Common.Performance;
using UnityEngine;

namespace Kiloo.Common.OnGUIWrappers;

public class GizmosColor : InternalColor
{
	public GizmosColor(Color newColor)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00aa: Expected I, but got Obj
		//IL_00c0: Expected Obj, but got I
		//IL_00d6: Expected I, but got Obj
		//IL_00ec: Expected Obj, but got I
		//IL_00f4: Expected Obj, but got VT
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(AndroidGPUCategorizer);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<Kiloo.Common.Performance.AndroidGPUCategorizer>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AndroidGPUCategorizer);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v31 (Il2CppClass<Kiloo.Common.Performance.AndroidGPUCategorizer>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string trimmedGPUName = AndroidGPUCategorizer.GetTrimmedGPUName();
		nint num3 = (nint)typeof(AndroidGPUCategorizer);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v16 (Il2CppClass<Kiloo.Common.Performance.AndroidGPUCategorizer>)+5C]");
		object obj2 = (nint)0 + (nint)12;
		obj2 = trimmedGPUName;
		nint num4 = (nint)typeof(AndroidGPUCategorizer);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v20 (Il2CppClass<Kiloo.Common.Performance.AndroidGPUCategorizer>)+5C]");
		object obj3 = (nint)0 + (nint)8;
		obj3 = newColor;
		AndroidGPUCategorizer._isInitialized = true;
		GizmosColor gizmosColor = (GizmosColor)(this + 4);
		gizmosColor = this;
		gizmosColor.Dispose();
	}

	public override void Dispose()
	{
		//IL_00ef: Expected I, but got Obj
		//IL_0105: Expected Obj, but got I
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(AndroidGPUCategorizer);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<Kiloo.Common.Performance.AndroidGPUCategorizer>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AndroidGPUCategorizer);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v35 (Il2CppClass<Kiloo.Common.Performance.AndroidGPUCategorizer>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = default;
		string text = (string)(obj2 + 4);
		if (~(AndroidGPUCategorizer._isInitialized ? 1u : 0u) != 0)
		{
			return;
		}
		nint num3 = (nint)typeof(AndroidGPUCategorizer);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v21 (Il2CppClass<Kiloo.Common.Performance.AndroidGPUCategorizer>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(AndroidGPUCategorizer);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v29 (Il2CppClass<Kiloo.Common.Performance.AndroidGPUCategorizer>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj2 = this;
		text = (string)obj2;
		Headers headers = ((Headers)(object)AndroidGPUCategorizer._gpuScores).Add(text, (object)AndroidGPUCategorizer._unknownGPUHandler);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC8C");
	}
}
