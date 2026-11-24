namespace System.Globalization;

public static class CharUnicodeInfo
{
	internal static class Debug
	{

		internal static void Assert(bool condition, string message) { }

	}

	private static ushort[] s_pCategoryLevel1Index; //Field offset: 0x0
	private static byte[] s_pCategoriesValue; //Field offset: 0x4
	private static ushort[] s_pNumericLevel1Index; //Field offset: 0x8
	private static byte[] s_pNumericValues; //Field offset: 0xC
	private static ushort[] s_pDigitValues; //Field offset: 0x10

	private static CharUnicodeInfo() { }

	public static double GetNumericValue(char ch) { }

	public static UnicodeCategory GetUnicodeCategory(char ch) { }

	public static UnicodeCategory GetUnicodeCategory(string s, int index) { }

	internal static int InternalConvertToUtf32(string s, int index) { }

	internal static int InternalConvertToUtf32(string s, int index, out int charLength) { }

	internal static byte InternalGetCategoryValue(int ch, int offset) { }

	internal static double InternalGetNumericValue(int ch) { }

	internal static UnicodeCategory InternalGetUnicodeCategory(int ch) { }

	internal static UnicodeCategory InternalGetUnicodeCategory(string value, int index) { }

	internal static UnicodeCategory InternalGetUnicodeCategory(string str, int index, out int charLength) { }

	internal static bool IsWhiteSpace(string s, int index) { }

	internal static bool IsWhiteSpace(char c) { }

}

