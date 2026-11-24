namespace System;

public struct byte : IComparable, IFormattable, IConvertible, IComparable<byte>, IEquatable<byte>
{
	public const byte MaxValue = 255; //Field offset: 0x0
	public const byte MinValue = 0; //Field offset: 0x0
	private byte m_value; //Field offset: 0x0

	public int CompareTo(object value) { }

	public int CompareTo(byte value) { }

	public override bool Equals(object obj) { }

	public bool Equals(byte obj) { }

	public override int GetHashCode() { }

	public TypeCode GetTypeCode() { }

	public static byte Parse(string s, NumberStyles style) { }

	public static byte Parse(string s, IFormatProvider provider) { }

	public static byte Parse(string s, NumberStyles style, IFormatProvider provider) { }

	private static byte Parse(string s, NumberStyles style, NumberFormatInfo info) { }

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

	public string ToString(string format) { }

	public override string ToString() { }

	public string ToString(string format, IFormatProvider provider) { }

	public string ToString(IFormatProvider provider) { }

}

