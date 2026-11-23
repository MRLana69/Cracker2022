using System;
using Cpp2ILInjected;

public class pMath
{
	public static float Bell(float x)
	{
		float value = x - 0.5f;
		float num = Math.Abs(value);
		float num2 = num + num;
		float num3 = 1f - num2;
		float num4 = Math.Min(num3, 1f);
		bool flag = num3 < 0f;
		float num5 = 0f;
		if (!flag)
		{
			num5 = num4;
		}
		float num6 = num5 * -2f;
		float num7 = num6 * num5;
		float num8 = num7 * num5;
		float num9 = num5 * 3f;
		float num10 = num9 * num5;
		float num11 = num8 + num10;
		float num12 = num11 * 1f;
		float num13 = 1f - num11;
		float num14 = num13 * 0f;
		return num12 + num14;
	}

	public static float Lerp(float xFrom, float xTo, float x, float yFrom, float yTo)
	{
		float num = yTo - yFrom;
		float num2 = x - xFrom;
		float num3 = xTo - xFrom;
		float num4 = num2 / num3;
		float num5 = Math.Min(num4, 1f);
		bool flag = num4 < 0f;
		float val = 0f;
		if (!flag)
		{
			val = num5;
		}
		float num6 = Math.Max(val, 0f);
		float num7 = num * num6;
		return yFrom + num7;
	}

	public static float Square(float x)
	{
		//IL_001b: Expected F8, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Floor not resolved\"");
		double num = Math.Abs((double)x);
		double num2 = ((!(num < 2147483648.0)) ? (-2147483648.0) : ((double)x));
		float num3 = x - (float)num2;
		bool flag = num3 < 0.5f;
		float result = 0f;
		if (!flag)
		{
			result = 1f;
		}
		return result;
	}
}
