namespace System;

public struct float : IComparable, IFormattable, IConvertible, IComparable<float>, IEquatable<float>
{
	public const float MinValue = -3.4028235E+38; //Field offset: 0x0
	public const float Epsilon = 1E-45; //Field offset: 0x0
	public const float MaxValue = 3.4028235E+38; //Field offset: 0x0
	public const float PositiveInfinity = Infinity; //Field offset: 0x0
	public const float NegativeInfinity = -Infinity; //Field offset: 0x0
	public const float NaN = NaN; //Field offset: 0x0
	internal float m_value; //Field offset: 0x0

	public int CompareTo(object value) { }

	public int CompareTo(float value) { }

	public override bool Equals(object obj) { }

	public bool Equals(float obj) { }

	public override int GetHashCode() { }

	public TypeCode GetTypeCode() { }

	public static bool IsInfinity(float f) { }

	public static bool IsNaN(float f) { }

	private static float Parse(string s, NumberStyles style, NumberFormatInfo info) { }

	public static float Parse(string s, NumberStyles style, IFormatProvider provider) { }

	public static float Parse(string s, IFormatProvider provider) { }

	public static float Parse(string s) { }

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

	public string ToString(string format) { }

	public string ToString(IFormatProvider provider) { }

	public override string ToString() { }

	public static bool TryParse(string s, out float result) { }

	private static bool TryParse(string s, NumberStyles style, NumberFormatInfo info, out float result) { }

	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out float result) { }

}

