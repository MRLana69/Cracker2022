namespace System;

public struct char : IComparable, IConvertible, IComparable<char>, IEquatable<char>
{
	public const char MaxValue = '\uFFFF'; //Field offset: 0x0
	public const char MinValue = '\u0'; //Field offset: 0x0
	private static readonly byte[] categoryForLatin1; //Field offset: 0x0
	internal const int UNICODE_PLANE00_END = 65535; //Field offset: 0x0
	internal const int UNICODE_PLANE01_START = 65536; //Field offset: 0x0
	internal const int UNICODE_PLANE16_END = 1114111; //Field offset: 0x0
	internal const int HIGH_SURROGATE_START = 55296; //Field offset: 0x0
	internal const int LOW_SURROGATE_END = 57343; //Field offset: 0x0
	internal char m_value; //Field offset: 0x0

	private static char() { }

	internal static bool CheckLetter(UnicodeCategory uc) { }

	internal static bool CheckLetterOrDigit(UnicodeCategory uc) { }

	internal static bool CheckNumber(UnicodeCategory uc) { }

	public int CompareTo(object value) { }

	public int CompareTo(char value) { }

	public static string ConvertFromUtf32(int utf32) { }

	public static int ConvertToUtf32(char highSurrogate, char lowSurrogate) { }

	public override bool Equals(object obj) { }

	public bool Equals(char obj) { }

	public override int GetHashCode() { }

	private static UnicodeCategory GetLatin1UnicodeCategory(char ch) { }

	public static double GetNumericValue(char c) { }

	public TypeCode GetTypeCode() { }

	public static UnicodeCategory GetUnicodeCategory(string s, int index) { }

	public static UnicodeCategory GetUnicodeCategory(char c) { }

	private static bool IsAscii(char ch) { }

	public static bool IsDigit(char c) { }

	public static bool IsHighSurrogate(char c) { }

	public static bool IsHighSurrogate(string s, int index) { }

	private static bool IsLatin1(char ch) { }

	public static bool IsLetter(char c) { }

	public static bool IsLetterOrDigit(char c) { }

	public static bool IsLetterOrDigit(string s, int index) { }

	public static bool IsLower(char c) { }

	public static bool IsLowSurrogate(char c) { }

	public static bool IsNumber(char c) { }

	public static bool IsSurrogate(char c) { }

	public static bool IsSurrogate(string s, int index) { }

	public static bool IsSurrogatePair(char highSurrogate, char lowSurrogate) { }

	public static bool IsUpper(char c) { }

	public static bool IsWhiteSpace(char c) { }

	public static bool IsWhiteSpace(string s, int index) { }

	private static bool IsWhiteSpaceLatin1(char c) { }

	public static char Parse(string s) { }

	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	private decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	public static char ToLower(char c) { }

	public static char ToLower(char c, CultureInfo culture) { }

	public static char ToLowerInvariant(char c) { }

	public string ToString(IFormatProvider provider) { }

	public override string ToString() { }

	public static string ToString(char c) { }

	public static char ToUpper(char c) { }

	public static char ToUpper(char c, CultureInfo culture) { }

	public static char ToUpperInvariant(char c) { }

}

