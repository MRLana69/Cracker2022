namespace Kiloo.Common.HTTP.Internal;

internal class Util
{
	public const string EOL = "
"; //Field offset: 0x0

	public Util() { }

	public static string ContentAsHex(byte[] bytes, Headers headers, int bytesPerLine, int maxLines = 0) { }

	public static string ContentAsString(byte[] bytes, Headers headers, int maxChars = 2147483647) { }

	public static string ContentAsString(byte[] bytes, Headers headers, int maxChars, out int totalCharCount) { }

	public static int ConvertTimeoutToMilliseconds(float seconds) { }

	public static ResponseCategory GetResponseCategory(int status) { }

	public static bool IsPrintable(byte[] bytes, int maxScan = 256) { }

	public static bool IsTextContentType(Headers headers) { }

	public static string PrintableContent(byte[] bytes, Headers headers, int maxChars, int maxHexLines) { }

	public static byte[] UnZip(byte[] data) { }

}

