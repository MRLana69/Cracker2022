namespace System.Threading;

public static class Interlocked
{

	public static int Add(ref int location1, int value) { }

	public static T CompareExchange(ref T location1, T value, T comparand) { }

	public static double CompareExchange(ref double location1, double value, double comparand) { }

	public static nint CompareExchange(ref nint location1, nint value, nint comparand) { }

	public static long CompareExchange(ref long location1, long value, long comparand) { }

	public static float CompareExchange(ref float location1, float value, float comparand) { }

	public static object CompareExchange(ref object location1, object value, object comparand) { }

	internal static int CompareExchange(ref int location1, int value, int comparand, ref bool succeeded) { }

	public static int CompareExchange(ref int location1, int value, int comparand) { }

	public static int Decrement(ref int location) { }

	public static int Exchange(ref int location1, int value) { }

	public static object Exchange(ref object location1, object value) { }

	public static float Exchange(ref float location1, float value) { }

	public static long Exchange(ref long location1, long value) { }

	public static nint Exchange(ref nint location1, nint value) { }

	public static double Exchange(ref double location1, double value) { }

	public static T Exchange(ref T location1, T value) { }

	public static int Increment(ref int location) { }

	public static long Read(ref long location) { }

}

