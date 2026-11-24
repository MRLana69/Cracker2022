namespace System.Threading;

public static class Volatile
{

	public static bool Read(ref bool location) { }

	public static T Read(ref T location) { }

	public static void Write(ref T location, T value) { }

}

