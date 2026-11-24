using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Common.Math;

public static class MathUtil
{
	public static float SnapValueStep(float value, float step)
	{
		//IL_010e: Expected I, but got Obj
		//IL_0124: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0177: Expected Obj, but got I4
		//IL_007b: Expected I, but got Obj
		//IL_0091: Expected Obj, but got I
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected Obj, but got Unknown
		//IL_00bc: Expected I, but got Obj
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v38 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num3 = ((!(step > 1f)) ? step : 1f);
		float width = num3 * 1000f;
		GUILayoutOption gUILayoutOption = GUILayout.Width(width);
		float t = 0.001f * value;
		object obj2 = 0;
		float num4 = 0f;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<GUILayoutOption, UIntPtr>(ref gUILayoutOption))
		{
			nint num5 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v24 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v32 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float num7 = Mathf.LerpUnclamped(num4, 1f, t);
			object obj4 = obj2 + 1;
			obj2 = obj4;
			num4 = num7;
		}
		return num4;
	}

	public static float ClampMaxAboveChangedMin(float max, float min, float minPrev)
	{
		float num = minPrev / min;
		return max * num;
	}

	public static float ClampMinBelowChangedMax(float min, float max, float maxPrev)
	{
		//IL_002c: Expected Obj, but got I4
		bool flag = min < max;
		bool flag2 = max != maxPrev;
		object obj = flag & flag2;
		if (obj != null)
		{
			return max;
		}
		return min;
	}

	public static bool IsValueInRange(float value, float min, float max, bool minInclusive = true, bool maxInclusive = true)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		return false;
	}

	public static bool AreRangesOverlapping(float range1Start, float range1End, float range2Start, float range2End)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		return false;
	}
}
