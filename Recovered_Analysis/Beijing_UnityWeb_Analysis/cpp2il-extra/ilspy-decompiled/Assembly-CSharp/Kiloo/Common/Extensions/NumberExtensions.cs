using System;
using Cpp2ILInjected;
using Kiloo.Common.HTTP;
using Kiloo.Common.HTTP.Internal;
using Kiloo.Common.Utility;
using UnityEngine;

namespace Kiloo.Common.Extensions;

public static class NumberExtensions
{
	public static float MRound(float f, float roundFactor)
	{
		StaticUpdater instance = StaticUpdater.instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9E28");
		float num = roundFactor - f;
		object obj = default;
		float num2 = (float)obj * num;
		return num2 + f;
	}

	public static int MRoundToInt(float f, float roundFactor)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		return 0;
	}

	public unsafe static bool IsBetween(int current, int low, int high)
	{
		//IL_0023: Expected Obj, but got I4
		//IL_0023: Expected Obj, but got I4
		//IL_0027: Expected I4, but got Obj
		int num = default;
		((int*)num)->m_value = 0;
		return (byte)(int)Util.ContentAsHex((byte[])current, (Headers)low, high, num) != 0;
	}

	public static bool Chance(float percentChance)
	{
		//IL_006b: Expected F4, but got I4
		//IL_0114: Invalid comparison between F4 and I4
		//IL_00a4: Expected F4, but got I4
		//IL_00dd: Expected F4, but got I4
		//IL_00ea: Expected I4, but got F4
		if (percentChance > 0f)
		{
			float num = percentChance * 1000f;
			if (num != num)
			{
				num = -2.1474836E+09f;
			}
			else if (!(num < 2.1474836E+09f))
			{
				num = -2.1474836E+09f;
			}
			else if (!(num > -2.1474836E+09f))
			{
				num = -2.1474836E+09f;
			}
			if (num != 0f)
			{
				return (byte)(int)num != 0;
			}
			return true;
		}
		return false;
	}

	public static float Roll(float max)
	{
		float num = max * 2f;
		if (max < 0.5f)
		{
			float num2 = Easings.BounceEaseOut(num);
			return 0.5f * num2;
		}
		float p = num - 1f;
		float num3 = Easings.BounceEaseInOut(p);
		float num4 = 0.5f * num3;
		return num4 + 0.5f;
	}

	public unsafe static int Roll(int max)
	{
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected Obj, but got Unknown
		//IL_000e: Expected F8, but got I4
		//IL_0197: Expected Obj, but got F8
		//IL_004b: Expected F8, but got I4
		//IL_0088: Expected F8, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj2 = default;
		object obj = obj2 + 8;
		double num = (double)((int*)max)->m_value * 2.7777777777777777E-11;
		if (num != num)
		{
			num = -2147483648.0;
		}
		else if (!(num < 2147483648.0))
		{
			num = -2147483648.0;
		}
		else if (!(num > -2147483649.0))
		{
			num = -2147483648.0;
		}
		obj = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		throw new ArrayTypeMismatchException();
	}

	public static float Lerp(float t, float a, float b, bool extrapolate = false)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		return 0f;
	}

	public static float Variance(float baseValue, float percentVariance)
	{
		float f = baseValue / percentVariance;
		float num = Ceil(f);
		return num * percentVariance;
	}

	public static bool IsBetween(float f, float smallFloat, float bigFloat)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		return false;
	}

	public unsafe static bool IsOneOf(int needle, int[] haystack)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Expected VT, but got Unknown
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected Obj, but got Unknown
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Expected Obj, but got Unknown
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_002a: Expected Obj, but got I4
		//IL_009c: Expected Obj, but got I4
		//IL_00a5: Expected Obj, but got I4
		//IL_00d2: Expected F4, but got Obj
		//IL_00cd: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj = obj2 - -64;
		Matrix4x4 matrix4x = (Matrix4x4)(obj2 + 40);
		object obj3 = obj2 + 24;
		object obj4 = obj2 + 8;
		object obj5 = obj2 + 32;
		obj5 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		object obj7 = default;
		object obj6 = obj7 + 16;
		obj6 = 35;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
		obj3 = 0;
		obj3 = 0;
		object obj8 = default;
		obj3 = obj8;
		_ = -1;
		obj2 = obj3;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj2;
		Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
		int[] array = (int[])obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
		_ = 0;
		return true;
	}

	public static string ToOrdinal(int num)
	{
		//IL_000a: Expected Obj, but got I4
		//IL_000e: Expected Obj, but got I4
		return (string)((ObfuscatedMemory)null).GetBoolean((string)num);
	}

	public static float Round(float f)
	{
		return MRound(0f, f);
	}

	public static int RoundToInt(float f)
	{
		float num = MRound(0f, 1f);
		return (!(num > f)) ? 1 : 0;
	}

	public static float Ceil(float f)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72EB");
		float result = default;
		return result;
	}

	public static int CeilToInt(float f)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a0: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (int)GUILayout.Width(f);
	}

	public static float Floor(float f)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Ceiling not resolved\"");
		return f;
	}

	public static int FloorToInt(float f)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return Mathf.FloorToInt(f);
	}

	public static float Pow(float f, float power)
	{
		//IL_0009: Expected Obj, but got F4
		object obj = 0f - f;
		float f2 = (float)obj * power;
		float roundFactor = f * power;
		float num = MRound(f2, roundFactor);
		return f + num;
	}

	public static float Pow(int i, float power)
	{
		float num = power;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [i @ L0 (System.Int32)+10]");
		return num - 0f;
	}

	public static float Clamp(float f, float min, float max)
	{
		return (float)Math.Pow(f, min);
	}

	public static int Clamp(int f, int min, int max)
	{
		bool flag = f > min;
		bool flag2 = f < max;
		return (flag & flag2) ? 1 : 0;
	}

	public static float Sqr(float f)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Floor not resolved\"");
		return f;
	}
}
