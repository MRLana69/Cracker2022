namespace UnityEngine.Assertions;

public static class Assert
{
	public static bool raiseExceptions; //Field offset: 0x0

	private static Assert() { }

	public static void AreEqual(T expected, T actual, string message) { }

	public static void AreEqual(T expected, T actual, string message, IEqualityComparer<T> comparer) { }

	public static void AreEqual(Object expected, Object actual, string message) { }

	public static void AreEqual(int expected, int actual) { }

	private static void Fail(string message, string userMessage) { }

}

