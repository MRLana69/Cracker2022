namespace System;

public struct decimal : IFormattable, IComparable, IConvertible, IDeserializationCallback, IComparable<decimal>, IEquatable<decimal>
{
	private const int SignMask = -2147483648; //Field offset: 0x0
	private const byte DECIMAL_NEG = 128; //Field offset: 0x0
	private const byte DECIMAL_ADD = 0; //Field offset: 0x0
	private const int ScaleMask = 16711680; //Field offset: 0x0
	private const int ScaleShift = 16; //Field offset: 0x0
	private const int MaxInt32Scale = 9; //Field offset: 0x0
	private static uint[] Powers10; //Field offset: 0x0
	public static readonly decimal Zero; //Field offset: 0x4
	public static readonly decimal One; //Field offset: 0x14
	public static readonly decimal MinusOne; //Field offset: 0x24
	public static readonly decimal MaxValue; //Field offset: 0x34
	public static readonly decimal MinValue; //Field offset: 0x44
	private static readonly decimal NearNegativeZero; //Field offset: 0x54
	private static readonly decimal NearPositiveZero; //Field offset: 0x64
	private int flags; //Field offset: 0x0
	private int hi; //Field offset: 0x4
	private int lo; //Field offset: 0x8
	private int mid; //Field offset: 0xC

	private static decimal() { }

	private decimal(int lo, int mid, int hi, int flags) { }

	public decimal(int lo, int mid, int hi, bool isNegative, byte scale) { }

	public decimal(int[] bits) { }

	public decimal(double value) { }

	public decimal(int value) { }

	public decimal(ulong value) { }

	public decimal(float value) { }

	public decimal(long value) { }

	public decimal(uint value) { }

	public int CompareTo(object value) { }

	public int CompareTo(decimal value) { }

	public bool Equals(decimal value) { }

	public override bool Equals(object value) { }

	private static int FCallCompare(ref decimal d1, ref decimal d2) { }

	private static void FCallRound(ref decimal d, int decimals) { }

	internal static int FCallToInt32(decimal d) { }

	private static void FCallTruncate(ref decimal d) { }

	public static int[] GetBits(decimal d) { }

	internal static void GetBytes(decimal d, byte[] buffer) { }

	public override int GetHashCode() { }

	public TypeCode GetTypeCode() { }

	private void OnSerializing(StreamingContext ctx) { }

	public static bool op_Equality(decimal d1, decimal d2) { }

	public static double op_Explicit(decimal value) { }

	public static decimal op_Explicit(double value) { }

	public static float op_Explicit(decimal value) { }

	public static decimal op_Explicit(float value) { }

	public static decimal op_Implicit(long value) { }

	public static decimal op_Implicit(uint value) { }

	public static decimal op_Implicit(int value) { }

	public static decimal op_Implicit(ushort value) { }

	public static decimal op_Implicit(short value) { }

	public static decimal op_Implicit(sbyte value) { }

	public static decimal op_Implicit(ulong value) { }

	public static decimal op_Implicit(byte value) { }

	public static bool op_Inequality(decimal d1, decimal d2) { }

	public static decimal Parse(string s, IFormatProvider provider) { }

	public static decimal Parse(string s, NumberStyles style, IFormatProvider provider) { }

	public static decimal Round(decimal d, int decimals) { }

	private void SetBits(int[] bits) { }

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

	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	public static byte ToByte(decimal value) { }

	internal static decimal ToDecimal(byte[] buffer) { }

	public static double ToDouble(decimal d) { }

	public static short ToInt16(decimal value) { }

	public static int ToInt32(decimal d) { }

	public static long ToInt64(decimal d) { }

	public static sbyte ToSByte(decimal value) { }

	public static float ToSingle(decimal d) { }

	public string ToString(string format, IFormatProvider provider) { }

	public string ToString(IFormatProvider provider) { }

	public override string ToString() { }

	public static ushort ToUInt16(decimal value) { }

	public static uint ToUInt32(decimal d) { }

	public static ulong ToUInt64(decimal d) { }

}

