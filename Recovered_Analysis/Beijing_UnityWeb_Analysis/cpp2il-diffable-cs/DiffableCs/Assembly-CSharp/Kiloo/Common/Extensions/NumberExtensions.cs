namespace Kiloo.Common.Extensions;

public static class NumberExtensions
{

	public static float Ceil(float f) { }

	public static int CeilToInt(float f) { }

	public static bool Chance(float percentChance) { }

	public static float Clamp(float f, float min, float max) { }

	public static int Clamp(int f, int min, int max) { }

	public static float Floor(float f) { }

	public static int FloorToInt(float f) { }

	public static bool IsBetween(int current, int low, int high) { }

	public static bool IsBetween(float f, float smallFloat, float bigFloat) { }

	public static bool IsOneOf(int needle, int[] haystack) { }

	public static float Lerp(float t, float a, float b, bool extrapolate = false) { }

	public static float MRound(float f, float roundFactor) { }

	public static int MRoundToInt(float f, float roundFactor) { }

	public static float Pow(float f, float power) { }

	public static float Pow(int i, float power) { }

	public static int Roll(int max) { }

	public static float Roll(float max) { }

	public static float Round(float f) { }

	public static int RoundToInt(float f) { }

	public static float Sqr(float f) { }

	public static string ToOrdinal(int num) { }

	public static float Variance(float baseValue, float percentVariance) { }

}

