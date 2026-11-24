namespace System;

public struct DateTimeOffset : IComparable, IFormattable, ISerializable, IDeserializationCallback, IComparable<DateTimeOffset>, IEquatable<DateTimeOffset>
{
	public static readonly DateTimeOffset MinValue; //Field offset: 0x0
	public static readonly DateTimeOffset MaxValue; //Field offset: 0x10
	private DateTime m_dateTime; //Field offset: 0x0
	private short m_offsetMinutes; //Field offset: 0x8

	private DateTime ClockDateTime
	{
		 get { } //Length: 12
	}

	public static DateTimeOffset Now
	{
		 get { } //Length: 2
	}

	public TimeSpan Offset
	{
		 get { } //Length: 12
	}

	public long Ticks
	{
		 get { } //Length: 12
	}

	public DateTime UtcDateTime
	{
		 get { } //Length: 12
	}

	public static DateTimeOffset UtcNow
	{
		 get { } //Length: 140
	}

	private static DateTimeOffset() { }

	private DateTimeOffset(SerializationInfo info, StreamingContext context) { }

	public DateTimeOffset(long ticks, TimeSpan offset) { }

	public DateTimeOffset(DateTime dateTime) { }

	public DateTimeOffset(DateTime dateTime, TimeSpan offset) { }

	public DateTimeOffset AddTicks(long ticks) { }

	public int CompareTo(DateTimeOffset other) { }

	public bool Equals(DateTimeOffset other) { }

	public override bool Equals(object obj) { }

	private DateTime get_ClockDateTime() { }

	public static DateTimeOffset get_Now() { }

	public TimeSpan get_Offset() { }

	public long get_Ticks() { }

	public DateTime get_UtcDateTime() { }

	public static DateTimeOffset get_UtcNow() { }

	public override int GetHashCode() { }

	public static DateTimeOffset op_Implicit(DateTime dateTime) { }

	public static bool op_LessThan(DateTimeOffset left, DateTimeOffset right) { }

	public static DateTimeOffset Parse(string input, IFormatProvider formatProvider, DateTimeStyles styles) { }

	private int System.IComparable.CompareTo(object obj) { }

	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	public override string ToString() { }

	public string ToString(string format, IFormatProvider formatProvider) { }

	private static DateTime ValidateDate(DateTime dateTime, TimeSpan offset) { }

	private static short ValidateOffset(TimeSpan offset) { }

	private static DateTimeStyles ValidateStyles(DateTimeStyles style, string parameterName) { }

}

