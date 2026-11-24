namespace System;

public struct sbyte : IComparable, IFormattable, IConvertible, IComparable<sbyte>, IEquatable<sbyte>
{
	public const sbyte MaxValue = 127; //Field offset: 0x0
	public const sbyte MinValue = -128; //Field offset: 0x0
	private sbyte m_value; //Field offset: 0x0

	public int CompareTo(object obj) { }

	public int CompareTo(sbyte value) { }

	public override bool Equals(object obj) { }

	public bool Equals(sbyte obj) { }

	public override int GetHashCode() { }

	public TypeCode GetTypeCode() { }

	private static sbyte Parse(string s, NumberStyles style, NumberFormatInfo info) { }

	public static sbyte Parse(string s, NumberStyles style, IFormatProvider provider) { }

	public static sbyte Parse(string s, IFormatProvider provider) { }

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

