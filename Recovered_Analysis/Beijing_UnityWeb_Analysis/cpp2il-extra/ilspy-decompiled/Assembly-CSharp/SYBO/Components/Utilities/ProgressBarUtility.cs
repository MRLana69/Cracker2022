using System.Collections;
using Cpp2ILInjected;
using SYBO.Subway.Routes;
using SYBO.Subway.Routes.Builders;
using UnityEngine;

namespace SYBO.Components.Utilities;

public static class ProgressBarUtility
{
	public static bool IsAvailable()
	{
		//IL_0013: Expected I4, but got Obj
		return (byte)(int)FileUtility.ConvertToPathWithBackSlashes("GIT_BRANCH") != 0;
	}

	public static bool HasProgressBar()
	{
		return false;
	}

	public static void DisplayCancelableProgressBar(string title, string info, float progress)
	{
		//IL_0022: Expected Obj, but got I4
		bool flag = ((RouteBuilder)(object)title).CanDespawnPassedChunk((RouteChunk)(object)info, progress);
		Coroutine coroutine = ((MonoBehaviour)(object)title).StartCoroutine_Auto((IEnumerator)flag);
	}

	public static void DisplayProgressBar(string title, string info, float progress)
	{
	}

	public static void ClearProgressBar()
	{
		//IL_016c: Expected I, but got Obj
		//IL_0182: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0051: Expected Obj, but got I
		//IL_0061: Expected Obj, but got I
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected Obj, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected Obj, but got Unknown
		//IL_009d: Expected I, but got Obj
		//IL_00b3: Expected Obj, but got I
		//IL_00e0: Expected Obj, but got I
		//IL_00f0: Expected Obj, but got I
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected Obj, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected Obj, but got Unknown
		//IL_012c: Expected I, but got Obj
		//IL_0142: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		PreRuntimePoolItem preRuntimePoolItem = default;
		preRuntimePoolItem.Start();
		nint num = (nint)typeof(PoolManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v9 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+5C]");
		object obj = (nint)0 + (nint)4;
		obj = preRuntimePoolItem;
		PoolManager.BalancingBudgetMS = 5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num2 = (nint)typeof(PoolManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v19 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+5C]");
		object obj2 = (nint)0 + (nint)32;
		object obj3 = default;
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S3_v3+60]");
		object obj5 = 0;
		object obj6 = obj5;
		object obj7 = obj6 & 0x1FFF;
		object obj8 = obj7 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v53 @ S4_v4 (should have been resolved before IL gen)");
		nint num4 = (nint)typeof(PoolManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v26 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+5C]");
		object obj9 = (nint)0 + (nint)36;
		object obj10 = default;
		obj9 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S3_v7 (Il2CppMethodInfo)+C]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S3_v8+60]");
		object obj12 = 0;
		object obj13 = obj12;
		object obj14 = obj13 & 0x1FFF;
		object obj15 = obj14 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v78 @ S4_v8 (should have been resolved before IL gen)");
		nint num6 = (nint)typeof(PoolManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v33 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+5C]");
		object obj16 = (nint)0 + (nint)40;
		object obj17 = default;
		obj16 = obj17;
	}

	public static void ClearProgressBarAfterDelay(float delayInSeconds)
	{
		//IL_00ef: Expected I, but got Obj
		//IL_0105: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<NGUITools>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v33 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (NGUITools.mGlobalVolume == delayInSeconds)
		{
			return;
		}
		nint num3 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v16 (Il2CppClass<NGUITools>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v27 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		NGUITools.mLoaded = true;
		NGUITools.mGlobalVolume = delayInSeconds;
		((SpaceAttribute)(object)"Sound")._002Ector(delayInSeconds);
	}
}
