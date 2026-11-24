namespace System;

public struct Guid : IFormattable, IComparable, IComparable<Guid>, IEquatable<Guid>
{
	private enum GuidParseThrowStyle
	{
		None = 0,
		All = 1,
		AllButOverflow = 2,
	}

	private struct GuidResult
	{
		internal Guid parsedGuid; //Field offset: 0x0
		internal GuidParseThrowStyle throwStyle; //Field offset: 0x10
		internal ParseFailureKind m_failure; //Field offset: 0x14
		internal string m_failureMessageID; //Field offset: 0x18
		internal object m_failureMessageFormatArgument; //Field offset: 0x1C
		internal string m_failureArgumentName; //Field offset: 0x20
		internal Exception m_innerException; //Field offset: 0x24

		internal Exception GetGuidParseException() { }

		internal void Init(GuidParseThrowStyle canThrow) { }

		internal void SetFailure(Exception nativeException) { }

		internal void SetFailure(ParseFailureKind failure, string failureMessageID) { }

		internal void SetFailure(ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument) { }

		internal void SetFailure(ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument, string failureArgumentName, Exception innerException) { }

	}

	private enum GuidStyles
	{
		None = 0,
		AllowParenthesis = 1,
		AllowBraces = 2,
		AllowDashes = 4,
		AllowHexPrefix = 8,
		RequireParenthesis = 16,
		RequireBraces = 32,
		RequireDashes = 64,
		RequireHexPrefix = 128,
		HexFormat = 160,
		NumberFormat = 0,
		DigitFormat = 64,
		BraceFormat = 96,
		ParenthesisFormat = 80,
		Any = 15,
	}

	private enum ParseFailureKind
	{
		None = 0,
		ArgumentNull = 1,
		Format = 2,
		FormatWithParameter = 3,
		NativeException = 4,
		FormatWithInnerException = 5,
	}

	public static readonly Guid Empty; //Field offset: 0x0
	private static object _rngAccess; //Field offset: 0x10
	private static RandomNumberGenerator _rng; //Field offset: 0x14
	private static RandomNumberGenerator _fastRng; //Field offset: 0x18
	private int _a; //Field offset: 0x0
	private short _b; //Field offset: 0x4
	private short _c; //Field offset: 0x6
	private byte _d; //Field offset: 0x8
	private byte _e; //Field offset: 0x9
	private byte _f; //Field offset: 0xA
	private byte _g; //Field offset: 0xB
	private byte _h; //Field offset: 0xC
	private byte _i; //Field offset: 0xD
	private byte _j; //Field offset: 0xE
	private byte _k; //Field offset: 0xF

	private static Guid() { }

	public Guid(byte[] b) { }

	public Guid(string g) { }

	public int CompareTo(Guid value) { }

	public int CompareTo(object value) { }

	private static string EatAllWhitespace(string str) { }

	public bool Equals(Guid g) { }

	public override bool Equals(object o) { }

	public override int GetHashCode() { }

	private int GetResult(uint me, uint them) { }

	private static int HexsToChars(char* guidChars, int offset, int a, int b, bool hex) { }

	private static int HexsToChars(char* guidChars, int offset, int a, int b) { }

	private static char HexToChar(int a) { }

	private static bool IsHexPrefix(string str, int i) { }

	public static Guid NewGuid() { }

	public static bool op_Equality(Guid a, Guid b) { }

	public static Guid Parse(string input) { }

	private static bool StringToInt(string str, int* parsePos, int requiredLength, int flags, out int result, ref GuidResult parseResult) { }

	private static bool StringToInt(string str, ref int parsePos, int requiredLength, int flags, out int result, ref GuidResult parseResult) { }

	private static bool StringToInt(string str, int requiredLength, int flags, out int result, ref GuidResult parseResult) { }

	private static bool StringToLong(string str, ref int parsePos, int flags, out long result, ref GuidResult parseResult) { }

	private static bool StringToLong(string str, int* parsePos, int flags, out long result, ref GuidResult parseResult) { }

	private static bool StringToShort(string str, int* parsePos, int requiredLength, int flags, out short result, ref GuidResult parseResult) { }

	private static bool StringToShort(string str, int requiredLength, int flags, out short result, ref GuidResult parseResult) { }

	public byte[] ToByteArray() { }

	public override string ToString() { }

	public string ToString(string format) { }

	public string ToString(string format, IFormatProvider provider) { }

	private static bool TryParseGuid(string g, GuidStyles flags, ref GuidResult result) { }

	private static bool TryParseGuidWithDashes(string guidString, ref GuidResult result) { }

	private static bool TryParseGuidWithHexPrefix(string guidString, ref GuidResult result) { }

	private static bool TryParseGuidWithNoStyle(string guidString, ref GuidResult result) { }

}

