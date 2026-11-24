namespace Kiloo.Common.Utility;

public static class KRandom
{
	private static Random _internalRandom; //Field offset: 0x0

	private static Random random
	{
		 get { } //Length: 110
	}

	private static Random get_random() { }

	private static double NextTriangularDouble(double min, double max, double mean) { }

	public static float Range(float min, float max) { }

	public static int Range(int min, int max) { }

	public static int RangeTriangle(int min, int max, int mean) { }

	public static float RangeTriangle(float min, float max, float mean) { }

}

