namespace System;

public sealed class string : IComparable, ICloneable, IConvertible, IEnumerable, IComparable<string>, IEnumerable<char>, IEquatable<string>
{
	private const int TrimHead = 0; //Field offset: 0x0
	private const int TrimTail = 1; //Field offset: 0x0
	private const int TrimBoth = 2; //Field offset: 0x0
	public static readonly string Empty; //Field offset: 0x0
	private const int charPtrAlignConst = 1; //Field offset: 0x0
	private const int alignConst = 3; //Field offset: 0x0
	private int m_stringLength; //Field offset: 0x8
	private char m_firstChar; //Field offset: 0xC

	public char Chars
	{
		 get { } //Length: 14
	}

	public int Length
	{
		 get { } //Length: 68
	}

	public string(char c, int count) { }

	public string(char[] value) { }

	public string(char[] value, int startIndex, int length) { }

	public string(sbyte* value, int startIndex, int length, Encoding enc) { }

	public string(char* value, int startIndex, int length) { }

	public string(char* value) { }

	internal static void bzero(byte* dest, int len) { }

	internal static void bzero_aligned_1(byte* dest, int len) { }

	internal static void bzero_aligned_2(byte* dest, int len) { }

	internal static void bzero_aligned_4(byte* dest, int len) { }

	internal static void bzero_aligned_8(byte* dest, int len) { }

	internal static void CharCopy(char* dest, char* src, int count) { }

	public object Clone() { }

	public static int Compare(string strA, string strB, bool ignoreCase, CultureInfo culture) { }

	public static int Compare(string strA, int indexA, string strB, int indexB, int length, CultureInfo culture, CompareOptions options) { }

	public static int Compare(string strA, int indexA, string strB, int indexB, int length, StringComparison comparisonType) { }

	public static int Compare(string strA, string strB) { }

	public static int Compare(string strA, string strB, StringComparison comparisonType) { }

	public static int CompareOrdinal(string strA, string strB) { }

	public static int CompareOrdinal(string strA, int indexA, string strB, int indexB, int length) { }

	private static int CompareOrdinalHelper(string strA, string strB) { }

	private static int CompareOrdinalIgnoreCaseHelper(string strA, string strB) { }

	internal static int CompareOrdinalUnchecked(string strA, int indexA, int lenA, string strB, int indexB, int lenB) { }

	public int CompareTo(object value) { }

	public int CompareTo(string strB) { }

	public static string Concat(object arg0, object arg1, object arg2) { }

	public static string Concat(object arg0, object arg1) { }

	public static string Concat(string[] values) { }

	public static string Concat(object arg0) { }

	public static string Concat(string str0, string str1, string str2, string str3) { }

	public static string Concat(string str0, string str1, string str2) { }

	public static string Concat(string str0, string str1) { }

	public static string Concat(object[] args) { }

	private static string ConcatArray(string[] values, int totalLength) { }

	public bool Contains(string value) { }

	public static string Copy(string str) { }

	public void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count) { }

	private string CreateString(char[] val) { }

	private string CreateString(char[] val, int startIndex, int length) { }

	private string CreateString(char c, int count) { }

	private string CreateString(sbyte* value) { }

	private string CreateString(sbyte* value, int startIndex, int length) { }

	private string CreateString(char* value) { }

	private string CreateString(char* value, int startIndex, int length) { }

	private string CreateString(sbyte* value, int startIndex, int length, Encoding enc) { }

	internal static string CreateStringFromEncoding(byte* bytes, int byteLength, Encoding encoding) { }

	private string CreateTrimmedString(int start, int end) { }

	private string CtorCharArray(char[] value) { }

	private string CtorCharArrayStartLength(char[] value, int startIndex, int length) { }

	private string CtorCharPtr(char* ptr) { }

	private string CtorCharPtrStartLength(char* ptr, int startIndex, int length) { }

	public bool EndsWith(string value) { }

	public bool EndsWith(string value, StringComparison comparisonType) { }

	internal bool EndsWith(char value) { }

	public static bool Equals(string a, string b, StringComparison comparisonType) { }

	public static bool Equals(string a, string b) { }

	public bool Equals(string value, StringComparison comparisonType) { }

	public override bool Equals(object obj) { }

	public bool Equals(string value) { }

	private static bool EqualsHelper(string strA, string strB) { }

	internal static string FastAllocateString(int length) { }

	private static void FillStringChecked(string dest, int destPos, string src) { }

	public static string Format(string format, object arg0) { }

	public static string Format(IFormatProvider provider, string format, object[] args) { }

	public static string Format(IFormatProvider provider, string format, object arg0, object arg1, object arg2) { }

	public static string Format(IFormatProvider provider, string format, object arg0) { }

	public static string Format(string format, object[] args) { }

	public static string Format(string format, object arg0, object arg1, object arg2) { }

	public static string Format(string format, object arg0, object arg1) { }

	public static string Format(IFormatProvider provider, string format, object arg0, object arg1) { }

	private static string FormatHelper(IFormatProvider provider, string format, ParamsArray args) { }

	public char get_Chars(int index) { }

	public int get_Length() { }

	public override int GetHashCode() { }

	internal int GetLegacyNonRandomizedHashCode() { }

	public TypeCode GetTypeCode() { }

	public int IndexOf(char value, int startIndex, int count) { }

	public int IndexOf(string value, int startIndex, StringComparison comparisonType) { }

	public int IndexOf(char value, int startIndex) { }

	public int IndexOf(string value) { }

	public int IndexOf(char value) { }

	public int IndexOf(string value, StringComparison comparisonType) { }

	public int IndexOf(string value, int startIndex) { }

	public int IndexOf(string value, int startIndex, int count, StringComparison comparisonType) { }

	public int IndexOfAny(char[] anyOf, int startIndex) { }

	public int IndexOfAny(char[] anyOf, int startIndex, int count) { }

	public int IndexOfAny(char[] anyOf) { }

	private int IndexOfAnyUnchecked(char[] anyOf, int startIndex, int count) { }

	internal int IndexOfUnchecked(string value, int startIndex, int count) { }

	internal int IndexOfUnchecked(char value, int startIndex, int count) { }

	public string Insert(int startIndex, string value) { }

	private string[] InternalSplitKeepEmptyEntries(int[] sepList, int[] lengthList, int numReplaces, int count) { }

	private string[] InternalSplitOmitEmptyEntries(int[] sepList, int[] lengthList, int numReplaces, int count) { }

	private string InternalSubString(int startIndex, int length) { }

	internal bool IsAscii() { }

	private static bool IsBOMWhitespace(char c) { }

	public static bool IsNullOrEmpty(string value) { }

	public static bool IsNullOrWhiteSpace(string value) { }

	public static string Join(string separator, string[] value) { }

	public static string Join(string separator, string[] value, int startIndex, int count) { }

	public int LastIndexOf(char value, int startIndex) { }

	public int LastIndexOf(char value, int startIndex, int count) { }

	public int LastIndexOf(char value) { }

	public int LastIndexOf(string value) { }

	public int LastIndexOf(string value, int startIndex) { }

	public int LastIndexOf(string value, StringComparison comparisonType) { }

	public int LastIndexOf(string value, int startIndex, int count, StringComparison comparisonType) { }

	public int LastIndexOfAny(char[] anyOf, int startIndex, int count) { }

	public int LastIndexOfAny(char[] anyOf) { }

	public int LastIndexOfAny(char[] anyOf, int startIndex) { }

	private int LastIndexOfAnyUnchecked(char[] anyOf, int startIndex, int count) { }

	internal int LastIndexOfUnchecked(char value, int startIndex, int count) { }

	private int MakeSeparatorList(string[] separators, ref int[] sepList, ref int[] lengthList) { }

	private int MakeSeparatorList(char[] separator, ref int[] sepList) { }

	private static void memcpy(byte* dest, byte* src, int size) { }

	internal static void memcpy_aligned_1(byte* dest, byte* src, int size) { }

	internal static void memcpy_aligned_2(byte* dest, byte* src, int size) { }

	internal static void memcpy_aligned_4(byte* dest, byte* src, int size) { }

	internal static void memcpy_aligned_8(byte* dest, byte* src, int size) { }

	private static void memset(byte* dest, int val, int len) { }

	internal static int nativeCompareOrdinalEx(string strA, int indexA, string strB, int indexB, int count) { }

	public string Normalize(NormalizationForm normalizationForm) { }

	public static bool op_Equality(string a, string b) { }

	public static bool op_Inequality(string a, string b) { }

	private string PadHelper(int totalWidth, char paddingChar, bool isRightPadded) { }

	public string PadLeft(int totalWidth, char paddingChar) { }

	public string PadRight(int totalWidth, char paddingChar) { }

	public string Remove(int startIndex, int count) { }

	public string Remove(int startIndex) { }

	public string Replace(char oldChar, char newChar) { }

	public string Replace(string oldValue, string newValue) { }

	private string ReplaceFallback(string oldValue, string newValue, int testedCount) { }

	internal string ReplaceInternal(string oldValue, string newValue) { }

	private string ReplaceInternal(char oldChar, char newChar) { }

	private string ReplaceUnchecked(string oldValue, string newValue) { }

	public string[] Split(char[] separator, int count, StringSplitOptions options) { }

	public string[] Split(string[] separator, StringSplitOptions options) { }

	public string[] Split(char[] separator) { }

	public string[] Split(char[] separator, StringSplitOptions options) { }

	public string[] Split(string[] separator, int count, StringSplitOptions options) { }

	internal string[] SplitInternal(char[] separator, int count, StringSplitOptions options) { }

	public bool StartsWith(string value, StringComparison comparisonType) { }

	public bool StartsWith(string value) { }

	internal bool StartsWithOrdinalUnchecked(string value) { }

	public string Substring(int startIndex) { }

	public string Substring(int startIndex, int length) { }

	private IEnumerator<char> System.Collections.Generic.IEnumerable<System.Char>.GetEnumerator() { }

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

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

	public char[] ToCharArray() { }

	public string ToLower(CultureInfo culture) { }

	public string ToLower() { }

	public string ToLowerInvariant() { }

	public override string ToString() { }

	public string ToString(IFormatProvider provider) { }

	public string ToUpper(CultureInfo culture) { }

	public string ToUpper() { }

	public string ToUpperInvariant() { }

	public string Trim() { }

	public string Trim(char[] trimChars) { }

	public string TrimEnd(char[] trimChars) { }

	private string TrimHelper(char[] trimChars, int trimType) { }

	private string TrimHelper(int trimType) { }

	public string TrimStart(char[] trimChars) { }

	private static int wcslen(char* ptr) { }

	internal static void wstrcpy(char* dmem, char* smem, int charCount) { }

}

