namespace System;

public struct ulong : IComparable, IFormattable, IConvertible, IComparable<ulong>, IEquatable<ulong>
{
	public const ulong MaxValue = 18446744073709551615; //Field offset: 0x0
	public const ulong MinValue = 0; //Field offset: 0x0
	private ulong m_value; //Field offset: 0x0

	public int CompareTo(object value) { }

	public int CompareTo(ulong value) { }

	public override bool Equals(object obj) { }

	public bool Equals(ulong obj) { }

	public override int GetHashCode() { }

	public TypeCode GetTypeCode() { }

	public static ulong Parse(string s, NumberStyles style, IFormatProvider provider) { }

	public static ulong Parse(string s, IFormatProvider provider) { }

	public static ulong Parse(string s) { }

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

	public string ToString(string format, IFormatProvider provider) { }

	public override string ToString() { }

	public string ToString(IFormatProvider provider) { }

	public string ToString(string format) { }

	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out ulong result) { }

}

