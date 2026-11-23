using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace Kiloo.Common.Utility;

public static class KRandom
{
	private static Random _internalRandom;

	private static Random random
	{
		get
		{
			bool flag = _internalRandom == null;
			bool flag2 = !flag;
			Random result = _internalRandom;
			if (!flag2)
			{
				Random random = default;
				random._002Ector();
				_internalRandom = random;
				result = random;
			}
			return result;
		}
	}

	public static float Range(float min, float max)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected Obj, but got Unknown
		Random random = KRandom.random;
		object obj = random - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v6 @ S1_v3+BC] (should have been resolved before IL gen)");
		float num = max - min;
		object obj2 = default;
		float num2 = (float)obj2 * num;
		return num2 + min;
	}

	public static int Range(int min, int max)
	{
		//IL_005d: Expected I, but got Obj
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected Obj, but got Unknown
		//IL_0038: Expected I, but got Obj
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected Obj, but got Unknown
		Random random = KRandom.random;
		if (min > max)
		{
			nint num = (nint)random;
			object obj = random + 48;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v13 @ S3_v6 (Il2CppClass<System.Random>)+EC] (should have been resolved before IL gen)");
			int result = default;
			return result;
		}
		nint num2 = (nint)random;
		object obj2 = random + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v25 @ S3_v2 (Il2CppClass<System.Random>)+EC] (should have been resolved before IL gen)");
		int result2 = default;
		return result2;
	}

	private static double NextTriangularDouble(double min, double max, double mean)
	{
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected Obj, but got Unknown
		//IL_0129: Invalid comparison between F8 and Obj
		Random random = KRandom.random;
		object obj = random - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v16 @ S1_v4+BC] (should have been resolved before IL gen)");
		double num = mean - min;
		double num2 = max - min;
		double num3 = num / num2;
		object obj2 = default;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num3) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2))
		{
			double num4 = max - min;
			double num5 = (double)obj2 * num4;
			double num6 = mean - min;
			double d = num5 * num6;
			double num7 = Math.Sqrt(d);
			return min + num7;
		}
		double num8 = 1.0 - (double)obj2;
		double num9 = max - min;
		double num10 = num8 * num9;
		double num11 = max - mean;
		double d2 = num10 * num11;
		double num12 = Math.Sqrt(d2);
		return max - num12;
	}

	public static int RangeTriangle(int min, int max, int mean)
	{
		//IL_006a: Expected F8, but got I4
		//IL_006a: Expected F8, but got I4
		//IL_006a: Expected F8, but got I4
		//IL_0046: Expected I4, but got F8
		double d = NextTriangularDouble(min, max, mean);
		double num = Math.Floor(d);
		double num2 = Math.Abs(num);
		if (num2 < 2147483648.0)
		{
			return (int)num;
		}
		return int.MinValue;
	}

	public static float RangeTriangle(float min, float max, float mean)
	{
		return (float)NextTriangularDouble(min, max, mean);
	}
}
