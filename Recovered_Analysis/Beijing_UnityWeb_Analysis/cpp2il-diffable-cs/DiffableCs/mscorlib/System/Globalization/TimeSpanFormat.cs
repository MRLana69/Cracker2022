namespace System.Globalization;

internal static class TimeSpanFormat
{
	internal struct FormatLiterals
	{
		internal string AppCompatLiteral; //Field offset: 0x0
		internal int dd; //Field offset: 0x4
		internal int hh; //Field offset: 0x8
		internal int mm; //Field offset: 0xC
		internal int ss; //Field offset: 0x10
		internal int ff; //Field offset: 0x14
		private string[] literals; //Field offset: 0x18

		internal string DayHourSep
		{
			 get { } //Length: 15
		}

		internal string End
		{
			 get { } //Length: 15
		}

		internal string HourMinuteSep
		{
			 get { } //Length: 15
		}

		internal string MinuteSecondSep
		{
			 get { } //Length: 15
		}

		internal string SecondFractionSep
		{
			 get { } //Length: 15
		}

		internal string Start
		{
			 get { } //Length: 20
		}

		internal string get_DayHourSep() { }

		internal string get_End() { }

		internal string get_HourMinuteSep() { }

		internal string get_MinuteSecondSep() { }

		internal string get_SecondFractionSep() { }

		internal string get_Start() { }

		internal void Init(string format, bool useInvariantFieldLengths) { }

		internal static FormatLiterals InitInvariant(bool isNegative) { }

	}

	internal enum Pattern
	{
		None = 0,
		Minimum = 1,
		Full = 2,
	}

	internal static readonly FormatLiterals PositiveInvariantFormatLiterals; //Field offset: 0x0
	internal static readonly FormatLiterals NegativeInvariantFormatLiterals; //Field offset: 0x1C

	private static TimeSpanFormat() { }

	internal static string Format(TimeSpan value, string format, IFormatProvider formatProvider) { }

	internal static string FormatCustomized(TimeSpan value, string format, DateTimeFormatInfo dtfi) { }

	private static string FormatStandard(TimeSpan value, bool isInvariant, string format, Pattern pattern) { }

	private static string IntToString(int n, int digits) { }

}

