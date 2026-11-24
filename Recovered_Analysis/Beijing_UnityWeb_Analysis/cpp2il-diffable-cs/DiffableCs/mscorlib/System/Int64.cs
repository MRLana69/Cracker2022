namespace System;

public struct long : IComparable, IFormattable, IConvertible, IComparable<long>, IEquatable<long>
{
	public const long MaxValue = 9223372036854775807; //Field offset: 0x0
	public const long MinValue = -9223372036854775808; //Field offset: 0x0
	internal long m_value; //Field offset: 0x0

	public int CompareTo(object value) { }

	public int CompareTo(long value) { }

	public override bool Equals(object obj) { }

	public bool Equals(long obj) { }

	public override int GetHashCode() { }

	public TypeCode GetTypeCode() { }

	public static long Parse(string s) { }

	public static long Parse(string s, NumberStyles style) { }

	public static long Parse(string s, IFormatProvider provider) { }

	public static long Parse(string s, NumberStyles style, IFormatProvider provider) { }

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

	public string ToString(string format) { }

	public string ToString(IFormatProvider provider) { }

	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out long result) { }

	public static bool TryParse(string s, out long result) { }

}

