namespace Kiloo.Common.Utility;

public static class Easings
{
	public enum Functions
	{
		Linear = 0,
		QuadraticEaseIn = 1,
		QuadraticEaseOut = 2,
		QuadraticEaseInOut = 3,
		CubicEaseIn = 4,
		CubicEaseOut = 5,
		CubicEaseInOut = 6,
		QuarticEaseIn = 7,
		QuarticEaseOut = 8,
		QuarticEaseInOut = 9,
		QuinticEaseIn = 10,
		QuinticEaseOut = 11,
		QuinticEaseInOut = 12,
		SineEaseIn = 13,
		SineEaseOut = 14,
		SineEaseInOut = 15,
		CircularEaseIn = 16,
		CircularEaseOut = 17,
		CircularEaseInOut = 18,
		ExponentialEaseIn = 19,
		ExponentialEaseOut = 20,
		ExponentialEaseInOut = 21,
		ElasticEaseIn = 22,
		ElasticEaseOut = 23,
		ElasticEaseInOut = 24,
		BackEaseIn = 25,
		BackEaseOut = 26,
		BackEaseInOut = 27,
		BounceEaseIn = 28,
		BounceEaseOut = 29,
		BounceEaseInOut = 30,
	}

	private const float PI = 3.1415927; //Field offset: 0x0
	private const float HALFPI = 1.5707964; //Field offset: 0x0

	public static float BackEaseIn(float p) { }

	public static float BackEaseInOut(float p) { }

	public static float BackEaseOut(float p) { }

	public static float BounceEaseIn(float p) { }

	public static float BounceEaseInOut(float p) { }

	public static float BounceEaseOut(float p) { }

	public static float CircularEaseIn(float p) { }

	public static float CircularEaseInOut(float p) { }

	public static float CircularEaseOut(float p) { }

	public static float CubicEaseIn(float p) { }

	public static float CubicEaseInOut(float p) { }

	public static float CubicEaseOut(float p) { }

	public static float ElasticEaseIn(float p) { }

	public static float ElasticEaseInOut(float p) { }

	public static float ElasticEaseOut(float p) { }

	public static float ExponentialEaseIn(float p) { }

	public static float ExponentialEaseInOut(float p) { }

	public static float ExponentialEaseOut(float p) { }

	public static float Interpolate(float p, Functions function) { }

	public static float Linear(float p) { }

	public static float QuadraticEaseIn(float p) { }

	public static float QuadraticEaseInOut(float p) { }

	public static float QuadraticEaseOut(float p) { }

	public static float QuarticEaseIn(float p) { }

	public static float QuarticEaseInOut(float p) { }

	public static float QuarticEaseOut(float p) { }

	public static float QuinticEaseIn(float p) { }

	public static float QuinticEaseInOut(float p) { }

	public static float QuinticEaseOut(float p) { }

	public static float SineEaseIn(float p) { }

	public static float SineEaseInOut(float p) { }

	public static float SineEaseOut(float p) { }

}

