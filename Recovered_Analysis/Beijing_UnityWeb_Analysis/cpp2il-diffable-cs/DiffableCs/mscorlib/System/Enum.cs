namespace System;

public abstract class Enum : IComparable, IFormattable, IConvertible
{
	private struct EnumResult
	{
		internal object parsedEnum; //Field offset: 0x0
		internal bool canThrow; //Field offset: 0x4
		internal ParseFailureKind m_failure; //Field offset: 0x8
		internal string m_failureMessageID; //Field offset: 0xC
		internal string m_failureParameter; //Field offset: 0x10
		internal object m_failureMessageFormatArgument; //Field offset: 0x14
		internal Exception m_innerException; //Field offset: 0x18

		internal Exception GetEnumParseException() { }

		internal void Init(bool canMethodThrow) { }

		internal void SetFailure(Exception unhandledException) { }

		internal void SetFailure(ParseFailureKind failure, string failureParameter) { }

		internal void SetFailure(ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument) { }

	}

	private enum ParseFailureKind
	{
		None = 0,
		Argument = 1,
		ArgumentNull = 2,
		ArgumentWithParameter = 3,
		UnhandledException = 4,
	}

	private class ValuesAndNames
	{
		public ulong[] Values; //Field offset: 0x8
		public string[] Names; //Field offset: 0xC

		public ValuesAndNames(ulong[] values, string[] names) { }

	}

	private static readonly char[] enumSeperatorCharArray; //Field offset: 0x0
	private const string enumSeperator = ", "; //Field offset: 0x0

	private static Enum() { }

	protected Enum() { }

	public int CompareTo(object target) { }

	public override bool Equals(object obj) { }

	private int get_hashcode() { }

	private object get_value() { }

	private static ValuesAndNames GetCachedValuesAndNames(RuntimeType enumType, bool getNames) { }

	private static bool GetEnumValuesAndNames(RuntimeType enumType, out ulong[] values, out string[] names) { }

	public override int GetHashCode() { }

	public static string GetName(Type enumType, object value) { }

	public static string[] GetNames(Type enumType) { }

	public TypeCode GetTypeCode() { }

	public static Type GetUnderlyingType(Type enumType) { }

	internal object GetValue() { }

	public static Array GetValues(Type enumType) { }

	public bool HasFlag(Enum flag) { }

	private static object InternalBoxEnum(RuntimeType enumType, long value) { }

	private static int InternalCompareTo(object o1, object o2) { }

	private static string InternalFlagsFormat(RuntimeType eT, object value) { }

	private static string InternalFormat(RuntimeType eT, object value) { }

	private static string InternalFormattedHexString(object value) { }

	internal static string[] InternalGetNames(RuntimeType enumType) { }

	internal static RuntimeType InternalGetUnderlyingType(RuntimeType enumType) { }

	internal static ulong[] InternalGetValues(RuntimeType enumType) { }

	private bool InternalHasFlag(Enum flags) { }

	public static bool IsDefined(Type enumType, object value) { }

	public static object Parse(Type enumType, string value, bool ignoreCase) { }

	public static object Parse(Type enumType, string value) { }

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

	public static object ToObject(Type enumType, ulong value) { }

	public static object ToObject(Type enumType, byte value) { }

	public static object ToObject(Type enumType, int value) { }

	public static object ToObject(Type enumType, short value) { }

	public static object ToObject(Type enumType, sbyte value) { }

	private static object ToObject(Type enumType, char value) { }

	public static object ToObject(Type enumType, long value) { }

	public static object ToObject(Type enumType, ushort value) { }

	public static object ToObject(Type enumType, object value) { }

	private static object ToObject(Type enumType, bool value) { }

	public static object ToObject(Type enumType, uint value) { }

	public override string ToString() { }

	public string ToString(IFormatProvider provider) { }

	public string ToString(string format, IFormatProvider provider) { }

	public string ToString(string format) { }

	internal static ulong ToUInt64(object value) { }

	private static bool TryParseEnum(Type enumType, string value, bool ignoreCase, ref EnumResult parseResult) { }

}

