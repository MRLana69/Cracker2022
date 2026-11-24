namespace System;

public struct double : IComparable, IFormattable, IConvertible, IComparable<double>, IEquatable<double>
{
	public const double MinValue = -1.7976931348623157E+308; //Field offset: 0x0
	public const double MaxValue = 1.7976931348623157E+308; //Field offset: 0x0
	public const double Epsilon = 5E-324; //Field offset: 0x0
	public const double NegativeInfinity = -Infinity; //Field offset: 0x0
	public const double PositiveInfinity = Infinity; //Field offset: 0x0
	public const double NaN = NaN; //Field offset: 0x0
	internal static double NegativeZero; //Field offset: 0x0
	internal double m_value; //Field offset: 0x0

	private static double() { }

	public int CompareTo(object value) { }

	public int CompareTo(double value) { }

	public override bool Equals(object obj) { }

	public bool Equals(double obj) { }

	public override int GetHashCode() { }

	public TypeCode GetTypeCode() { }

	public static bool IsInfinity(double d) { }

	public static bool IsNaN(double d) { }

	public static bool IsPositiveInfinity(double d) { }

	public static double Parse(string s) { }

	public static double Parse(string s, IFormatProvider provider) { }

	public static double Parse(string s, NumberStyles style, IFormatProvider provider) { }

	private static double Parse(string s, NumberStyles style, NumberFormatInfo info) { }

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

	public override string ToString() { }

	public string ToString(string format, IFormatProvider provider) { }

	public string ToString(IFormatProvider provider) { }

	public string ToString(string format) { }

	public static bool TryParse(string s, out double result) { }

	private static bool TryParse(string s, NumberStyles style, NumberFormatInfo info, out double result) { }

	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out double result) { }

}

