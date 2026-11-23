using System;

namespace SYBO.Common.Math;

public static class MathUtil
{
	public static float SnapValueStep(float value, float step)
	{
		//IL_0081: Expected F8, but got I4
		if (step != 0f)
		{
			double num = (double)value / (double)step;
			double num2 = System.Math.Abs(num);
			if (!(num2 < 2147483648.0))
			{
				num = -2147483648.0;
			}
			return (float)num * step;
		}
		return value;
	}

	public static float ClampMaxAboveChangedMin(float max, float min, float minPrev)
	{
		bool flag = min != minPrev;
		float result = min;
		if (!flag)
		{
			result = max;
		}
		if (!(max < min))
		{
			result = max;
		}
		return result;
	}

	public static float ClampMinBelowChangedMax(float min, float max, float maxPrev)
	{
		bool flag = max != maxPrev;
		float result = max;
		if (!flag)
		{
			result = min;
		}
		if (!(min > max))
		{
			result = min;
		}
		return result;
	}

	public static bool IsValueInRange(float value, float min, float max, bool minInclusive = true, bool maxInclusive = true)
	{
		bool flag = !(value < min);
		bool flag2 = value > min;
		if (!minInclusive)
		{
			flag = flag2;
		}
		if (flag)
		{
			if (maxInclusive)
			{
				return !(value > max);
			}
			return value < max;
		}
		return false;
	}

	public static bool AreRangesOverlapping(float range1Start, float range1End, float range2Start, float range2End)
	{
		bool flag = IsValueInRange(range1Start, range2Start, range2End);
		bool result = true;
		if (!flag)
		{
			bool flag2 = IsValueInRange(range1End, range2Start, range2End);
			result = true;
			if (!flag2)
			{
				bool flag3 = IsValueInRange(range2Start, range1Start, range1End);
				result = true;
				if (!flag3)
				{
					result = IsValueInRange(range2End, range1Start, range1End);
				}
			}
		}
		return result;
	}
}
