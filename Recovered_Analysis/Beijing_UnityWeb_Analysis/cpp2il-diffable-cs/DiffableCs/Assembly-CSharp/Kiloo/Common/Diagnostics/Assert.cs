namespace Kiloo.Common.Diagnostics;

public static class Assert
{
	public class AssertFailedException : Exception
	{

		public AssertFailedException() { }

	}


	private static void FailAssert() { }

	public static void IsFalse(bool condition, string message, Object context) { }

	public static void IsFalse(bool condition) { }

	public static void IsFalse(bool condition, string message) { }

	public static void IsNotNull(object obj, string paramName, Object context) { }

	public static void IsNotNull(object obj, string paramName) { }

	public static void IsTrue(bool condition, string message, Object context) { }

	public static void IsTrue(bool condition) { }

	public static void IsTrue(bool condition, string message) { }

}

