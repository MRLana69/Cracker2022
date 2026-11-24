namespace System;

internal sealed class NumberFormatter
{
	private class CustomInfo
	{
		public bool UseGroup; //Field offset: 0x8
		public int DecimalDigits; //Field offset: 0xC
		public int DecimalPointPos; //Field offset: 0x10
		public int DecimalTailSharpDigits; //Field offset: 0x14
		public int IntegerDigits; //Field offset: 0x18
		public int IntegerHeadSharpDigits; //Field offset: 0x1C
		public int IntegerHeadPos; //Field offset: 0x20
		public bool UseExponent; //Field offset: 0x24
		public int ExponentDigits; //Field offset: 0x28
		public int ExponentTailSharpDigits; //Field offset: 0x2C
		public bool ExponentNegativeSignOnly; //Field offset: 0x30
		public int DividePlaces; //Field offset: 0x34
		public int Percents; //Field offset: 0x38
		public int Permilles; //Field offset: 0x3C

		public CustomInfo() { }

		public string Format(string format, int offset, int length, NumberFormatInfo nfi, bool positive, StringBuilder sb_int, StringBuilder sb_dec, StringBuilder sb_exp) { }

		public static void GetActiveSection(string format, ref bool positive, bool zero, ref int offset, ref int length) { }

		public static CustomInfo Parse(string format, int offset, int length, NumberFormatInfo nfi) { }

	}

	private static NumberFormatter threadNumberFormatter; //Field offset: 0x80000000
	private static NumberFormatter userFormatProvider; //Field offset: 0x80000004
	private static readonly ulong* MantissaBitsTable; //Field offset: 0x0
	private static readonly int* TensExponentTable; //Field offset: 0x4
	private static readonly char* DigitLowerTable; //Field offset: 0x8
	private static readonly char* DigitUpperTable; //Field offset: 0xC
	private static readonly long* TenPowersList; //Field offset: 0x10
	private static readonly int* DecHexDigits; //Field offset: 0x14
	private NumberFormatInfo _nfi; //Field offset: 0x8
	private char[] _cbuf; //Field offset: 0xC
	private bool _NaN; //Field offset: 0x10
	private bool _infinity; //Field offset: 0x11
	private bool _isCustomFormat; //Field offset: 0x12
	private bool _specifierIsUpper; //Field offset: 0x13
	private bool _positive; //Field offset: 0x14
	private char _specifier; //Field offset: 0x16
	private int _precision; //Field offset: 0x18
	private int _defPrecision; //Field offset: 0x1C
	private int _digitsLen; //Field offset: 0x20
	private int _offset; //Field offset: 0x24
	private int _decPointPos; //Field offset: 0x28
	private uint _val1; //Field offset: 0x2C
	private uint _val2; //Field offset: 0x30
	private uint _val3; //Field offset: 0x34
	private uint _val4; //Field offset: 0x38
	private int _ind; //Field offset: 0x3C

	private CultureInfo CurrentCulture
	{
		 set { } //Length: 111
	}

	private int DecimalDigits
	{
		 get { } //Length: 20
	}

	private int IntegerDigits
	{
		 get { } //Length: 80
	}

	private bool IsFloatingSource
	{
		 get { } //Length: 29
	}

	private bool IsZero
	{
		 get { } //Length: 23
	}

	private bool IsZeroInteger
	{
		 get { } //Length: 7
	}

	private static NumberFormatter() { }

	private NumberFormatter(Thread current) { }

	private static uint AddOneToDecHex(uint val) { }

	private void AddOneToDecHex() { }

	private void Append(char c, int cnt) { }

	private void Append(string s) { }

	private void Append(char c) { }

	private void AppendDecimalString(int precision, StringBuilder sb) { }

	private void AppendDecimalString(int precision) { }

	private void AppendDigits(int start, int end) { }

	private void AppendDigits(int start, int end, StringBuilder sb) { }

	private void AppendExponent(NumberFormatInfo nfi, int exponent, int minDigits) { }

	private void AppendIntegerString(int minLength) { }

	private void AppendIntegerString(int minLength, StringBuilder sb) { }

	private void AppendIntegerStringWithGroupSeparator(int[] groups, string groupSeparator) { }

	private static void AppendNonNegativeNumber(StringBuilder sb, int v) { }

	private void AppendOneDigit(int start) { }

	private static int CountTrailingZeros(uint val) { }

	private int CountTrailingZeros() { }

	private static int DecHexLen(uint val) { }

	private int DecHexLen() { }

	private void Divide10(int count) { }

	private static int FastDecHexLen(int val) { }

	private static uint FastToDecHex(int val) { }

	private string FormatCurrency(int precision, NumberFormatInfo nfi) { }

	private string FormatCustom(string format, NumberFormatInfo nfi) { }

	private string FormatDecimal(int precision, NumberFormatInfo nfi) { }

	private string FormatExponential(int precision, NumberFormatInfo nfi) { }

	private string FormatExponential(int precision, NumberFormatInfo nfi, int expDigits) { }

	private string FormatFixedPoint(int precision, NumberFormatInfo nfi) { }

	private string FormatGeneral(int precision, NumberFormatInfo nfi) { }

	private string FormatHexadecimal(int precision) { }

	private string FormatNumber(int precision, NumberFormatInfo nfi) { }

	private string FormatPercent(int precision, NumberFormatInfo nfi) { }

	private string FormatRoundtrip(double origval, NumberFormatInfo nfi) { }

	private string FormatRoundtrip(float origval, NumberFormatInfo nfi) { }

	private int get_DecimalDigits() { }

	private int get_IntegerDigits() { }

	private bool get_IsFloatingSource() { }

	private bool get_IsZero() { }

	private bool get_IsZeroInteger() { }

	private NumberFormatter GetClone() { }

	private static void GetFormatterTables(out ulong* MantissaBitsTable, out int* TensExponentTable, out char* DigitLowerTable, out char* DigitUpperTable, out long* TenPowersList, out int* DecHexDigits) { }

	private static NumberFormatter GetInstance(IFormatProvider fp) { }

	private NumberFormatInfo GetNumberFormatInstance(IFormatProvider fp) { }

	private static long GetTenPowerOf(int i) { }

	private void Init(string format) { }

	private void Init(string format, int value, int defPrecision) { }

	private void Init(string format, uint value, int defPrecision) { }

	private void Init(string format, long value) { }

	private void Init(string format, ulong value) { }

	private void Init(string format, decimal value) { }

	private void Init(string format, double value, int defPrecision) { }

	private void InitDecHexDigits(uint hi, ulong lo) { }

	private void InitDecHexDigits(uint value) { }

	private void InitDecHexDigits(ulong value) { }

	private void InitHex(ulong value) { }

	private int InitialFloatingPrecision() { }

	private string IntegerToString(string format, IFormatProvider fp) { }

	private static bool IsZeroOnly(StringBuilder sb) { }

	private void Multiply10(int count) { }

	public static string NumberToString(string format, uint value, IFormatProvider fp) { }

	public static string NumberToString(string format, int value, IFormatProvider fp) { }

	public static string NumberToString(string format, ulong value, IFormatProvider fp) { }

	public static string NumberToString(string format, long value, IFormatProvider fp) { }

	public static string NumberToString(string format, double value, IFormatProvider fp) { }

	public static string NumberToString(string format, decimal value, IFormatProvider fp) { }

	public static string NumberToString(string format, float value, IFormatProvider fp) { }

	private string NumberToString(string format, NumberFormatInfo nfi) { }

	private static int ParsePrecision(string format) { }

	private void Release() { }

	private void RemoveTrailingZeros() { }

	private void ResetCharBuf(int size) { }

	private void Resize(int len) { }

	private bool RoundBits(int shift) { }

	private bool RoundDecimal(int decimals) { }

	private void RoundPos(int pos) { }

	private static int ScaleOrder(long hi) { }

	private void set_CurrentCulture(CultureInfo value) { }

	private static uint ToDecHex(int val) { }

	private static void ZeroTrimEnd(StringBuilder sb, bool canEmpty) { }

}

