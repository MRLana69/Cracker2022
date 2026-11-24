namespace System;

public struct short : IComparable, IFormattable, IConvertible, IComparable<short>, IEquatable<short>
{
	public const short MaxValue = 32767; //Field offset: 0x0
	public const short MinValue = -32768; //Field offset: 0x0
	internal short m_value; //Field offset: 0x0

	public int CompareTo(object value) { }

	public int CompareTo(short value) { }

	public override bool Equals(object obj) { }

	public bool Equals(short obj) { }

	public override int GetHashCode() { }

	public TypeCode GetTypeCode() { }

	private static short Parse(string s, NumberStyles style, NumberFormatInfo info) { }

	public static short Parse(string s, NumberStyles style, IFormatProvider provider) { }

	public static short Parse(string s, IFormatProvider provider) { }

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

	private string ToString(string format, NumberFormatInfo info) { }

	public override string ToString() { }

	public string ToString(IFormatProvider provider) { }

	public string ToString(string format, IFormatProvider provider) { }

}

