namespace System;

public struct bool : IComparable, IConvertible, IComparable<bool>, IEquatable<bool>
{
	internal const int True = 1; //Field offset: 0x0
	internal const int False = 0; //Field offset: 0x0
	internal const string TrueLiteral = "True"; //Field offset: 0x0
	internal const string FalseLiteral = "False"; //Field offset: 0x0
	public static readonly string TrueString; //Field offset: 0x0
	public static readonly string FalseString; //Field offset: 0x4
	private bool m_value; //Field offset: 0x0

	private static bool() { }

	public int CompareTo(bool value) { }

	public int CompareTo(object obj) { }

	public override bool Equals(object obj) { }

	public bool Equals(bool obj) { }

	public override int GetHashCode() { }

	public TypeCode GetTypeCode() { }

	public static bool Parse(string value) { }

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

	public string ToString(IFormatProvider provider) { }

	public override string ToString() { }

	private static string TrimWhiteSpaceAndNull(string value) { }

	public static bool TryParse(string value, out bool result) { }

}

