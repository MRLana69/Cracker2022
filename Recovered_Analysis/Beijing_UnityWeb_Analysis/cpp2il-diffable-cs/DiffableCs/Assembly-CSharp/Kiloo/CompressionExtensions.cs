namespace Kiloo;

public static class CompressionExtensions
{
	private static string DEBUG_TAG; //Field offset: 0x0

	private static CompressionExtensions() { }

	public static byte[] Compress(byte[] source, string signature) { }

	public static byte[] Decompress(byte[] source, string expectedSignature) { }

	private static void Log(string msg) { }

	private static void LogError(string msg) { }

	private static void LogWarning(string msg) { }

	public static string ToContentString(IEnumerable<T> collection, string separator = ", ") { }

}

