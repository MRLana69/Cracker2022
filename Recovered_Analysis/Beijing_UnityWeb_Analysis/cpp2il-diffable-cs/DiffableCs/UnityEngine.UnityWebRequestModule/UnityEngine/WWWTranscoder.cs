namespace UnityEngine;

internal class WWWTranscoder
{
	private static byte[] ucHexChars; //Field offset: 0x0
	private static byte[] lcHexChars; //Field offset: 0x4
	private static byte urlEscapeChar; //Field offset: 0x8
	private static byte[] urlSpace; //Field offset: 0xC
	private static byte[] dataSpace; //Field offset: 0x10
	private static byte[] urlForbidden; //Field offset: 0x14
	private static byte qpEscapeChar; //Field offset: 0x18
	private static byte[] qpSpace; //Field offset: 0x1C
	private static byte[] qpForbidden; //Field offset: 0x20

	private static WWWTranscoder() { }

	private static byte[] Byte2Hex(byte b, byte[] hexChars) { }

	private static bool ByteArrayContains(byte[] array, byte b) { }

	private static bool ByteSubArrayEquals(byte[] array, int index, byte[] comperand) { }

	public static byte[] DataEncode(byte[] toEncode) { }

	public static byte[] Decode(byte[] input, byte escapeChar, byte[] space) { }

	public static byte[] Encode(byte[] input, byte escapeChar, byte[] space, byte[] forbidden, bool uppercase) { }

	private static byte Hex2Byte(byte[] b, int offset) { }

	public static string QPEncode(string toEncode, Encoding e) { }

	public static bool SevenBitClean(string s, Encoding e) { }

	public static bool SevenBitClean(byte[] input) { }

	public static byte[] URLDecode(byte[] toEncode) { }

	public static byte[] URLEncode(byte[] toEncode) { }

}

