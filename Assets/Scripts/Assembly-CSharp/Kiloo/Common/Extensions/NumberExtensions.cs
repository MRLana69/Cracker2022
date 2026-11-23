using System;
using System.Globalization;
using Cpp2ILInjected;
using Kiloo.Common.Utility;

namespace Kiloo.Common.Extensions;

public static class NumberExtensions
{
	public static float MRound(float f, float roundFactor)
	{
		float num = f / roundFactor;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		object obj = default;
		return (float)obj * roundFactor;
	}

	public static int MRoundToInt(float f, float roundFactor)
	{
		float f2 = MRound(f, roundFactor);
		return RoundToInt(f2);
	}

	public static bool IsBetween(int current, int low, int high)
	{
		bool flag = current < high;
		bool flag2 = current > low;
		return flag & flag2;
	}

	public static bool Chance(float percentChance)
	{
		float num = KRandom.Range(0f, 1f);
		return !(num > percentChance);
	}

	public static float Roll(float max)
	{
		return KRandom.Range(0f, max);
	}

	public static int Roll(int max)
	{
		return KRandom.Range(0, max);
	}

	public static float Variance(float baseValue, float percentVariance)
	{
		float num = 0f - baseValue;
		float min = num * percentVariance;
		float max = baseValue * percentVariance;
		float num2 = KRandom.Range(min, max);
		return baseValue + num2;
	}

	public unsafe static string ToOrdinal(int num)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0066: Expected Obj, but got I4
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected Obj, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected Obj, but got Unknown
		//IL_00ff: Expected Obj, but got I4
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected Obj, but got Unknown
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected Obj, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected I4, but got Unknown
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected I4, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected I4, but got Unknown
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected I4, but got Unknown
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Expected I4, but got Unknown
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		if (num <= 0)
		{
			int num2 = obj + 12;
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			return ((int*)num2)->ToString(invariantCulture);
		}
		int num3 = num / 100;
		object obj3 = num3 * 100;
		object obj4 = num - obj3;
		object obj5 = obj4 - 11;
		if ((nint)obj5 <= 2)
		{
			int num4 = obj + 12;
			string text = ((int*)num4)->ToString();
			return text + "th";
		}
		int num5 = num / 10;
		object obj6 = num5 * 10;
		object obj7 = num - obj6;
		object obj8 = obj7 - 1;
		if ((nint)obj7 != 1)
		{
			if ((nint)obj8 != 1)
			{
				if ((nint)obj8 == 2)
				{
					int num6 = obj + 12;
					string text2 = ((int*)num6)->ToString();
					return text2 + "rd";
				}
				int num7 = obj + 12;
				string text3 = ((int*)num7)->ToString();
				return text3 + "th";
			}
			int num8 = obj + 12;
			string text4 = ((int*)num8)->ToString();
			return text4 + "nd";
		}
		int num9 = obj + 12;
		string text5 = ((int*)num9)->ToString();
		return text5 + "st";
	}

	public static float Round(float f)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		float result = default;
		return result;
	}

	public static int RoundToInt(float f)
	{
		//IL_0039: Expected I4, but got F8
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
		double num2 = default;
		double num = Math.Abs(num2);
		if (num < 2147483648.0)
		{
			return (int)num2;
		}
		return int.MinValue;
	}

	public static float Ceil(float f)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Ceiling not resolved\"");
		return f;
	}

	public static int CeilToInt(float f)
	{
		//IL_000d: Expected I4, but got F4
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Ceiling not resolved\"");
		double num = Math.Abs((double)f);
		if (num < 2147483648.0)
		{
			return (int)f;
		}
		return int.MinValue;
	}

	public static float Floor(float f)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Floor not resolved\"");
		return f;
	}

	public static int FloorToInt(float f)
	{
		//IL_000d: Expected I4, but got F4
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Floor not resolved\"");
		double num = Math.Abs((double)f);
		if (num < 2147483648.0)
		{
			return (int)f;
		}
		return int.MinValue;
	}

	public static float Pow(float f, float power)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D4");
		float result = default;
		return result;
	}

	public static float Pow(int i, float power)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D4");
		float result = default;
		return result;
	}

	public static float Clamp(float f, float min, float max)
	{
		bool flag = f > max;
		float num = max;
		if (!flag)
		{
			num = f;
		}
		bool flag2 = f < min;
		float result = min;
		if (!flag2)
		{
			result = num;
		}
		return result;
	}

	public static int Clamp(int f, int min, int max)
	{
		bool flag = f > max;
		int num = max;
		if (!flag)
		{
			num = f;
		}
		bool flag2 = f < min;
		int result = min;
		if (!flag2)
		{
			result = num;
		}
		return result;
	}
}
