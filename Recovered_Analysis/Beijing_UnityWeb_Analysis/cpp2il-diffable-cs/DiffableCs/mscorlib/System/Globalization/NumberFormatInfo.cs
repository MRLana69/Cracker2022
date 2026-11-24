namespace System.Globalization;

public sealed class NumberFormatInfo : ICloneable, IFormatProvider
{
	private static NumberFormatInfo invariantInfo; //Field offset: 0x0
	private const NumberStyles InvalidNumberStyles = -1024; //Field offset: 0x0
	internal int[] numberGroupSizes; //Field offset: 0x8
	internal int[] currencyGroupSizes; //Field offset: 0xC
	internal int[] percentGroupSizes; //Field offset: 0x10
	internal string positiveSign; //Field offset: 0x14
	internal string negativeSign; //Field offset: 0x18
	internal string numberDecimalSeparator; //Field offset: 0x1C
	internal string numberGroupSeparator; //Field offset: 0x20
	internal string currencyGroupSeparator; //Field offset: 0x24
	internal string currencyDecimalSeparator; //Field offset: 0x28
	internal string currencySymbol; //Field offset: 0x2C
	internal string ansiCurrencySymbol; //Field offset: 0x30
	internal string nanSymbol; //Field offset: 0x34
	internal string positiveInfinitySymbol; //Field offset: 0x38
	internal string negativeInfinitySymbol; //Field offset: 0x3C
	internal string percentDecimalSeparator; //Field offset: 0x40
	internal string percentGroupSeparator; //Field offset: 0x44
	internal string percentSymbol; //Field offset: 0x48
	internal string perMilleSymbol; //Field offset: 0x4C
	internal string[] nativeDigits; //Field offset: 0x50
	internal int m_dataItem; //Field offset: 0x54
	internal int numberDecimalDigits; //Field offset: 0x58
	internal int currencyDecimalDigits; //Field offset: 0x5C
	internal int currencyPositivePattern; //Field offset: 0x60
	internal int currencyNegativePattern; //Field offset: 0x64
	internal int numberNegativePattern; //Field offset: 0x68
	internal int percentPositivePattern; //Field offset: 0x6C
	internal int percentNegativePattern; //Field offset: 0x70
	internal int percentDecimalDigits; //Field offset: 0x74
	internal int digitSubstitution; //Field offset: 0x78
	internal bool isReadOnly; //Field offset: 0x7C
	internal bool m_useUserOverride; //Field offset: 0x7D
	internal bool m_isInvariant; //Field offset: 0x7E
	internal bool validForParseAsNumber; //Field offset: 0x7F
	internal bool validForParseAsCurrency; //Field offset: 0x80

	public int CurrencyDecimalDigits
	{
		 get { } //Length: 62
	}

	public string CurrencyDecimalSeparator
	{
		 get { } //Length: 6
	}

	public string CurrencyGroupSeparator
	{
		 get { } //Length: 56
	}

	public int[] CurrencyGroupSizes
	{
		 get { } //Length: 9
	}

	public int CurrencyNegativePattern
	{
		 get { } //Length: 6
	}

	public int CurrencyPositivePattern
	{
		 get { } //Length: 6
	}

	public string CurrencySymbol
	{
		 get { } //Length: 6
	}

	public static NumberFormatInfo CurrentInfo
	{
		 get { } //Length: 120
	}

	public static NumberFormatInfo InvariantInfo
	{
		 get { } //Length: 178
	}

	public bool IsReadOnly
	{
		 get { } //Length: 6
	}

	public string NaNSymbol
	{
		 get { } //Length: 6
	}

	public string NegativeInfinitySymbol
	{
		 get { } //Length: 6
	}

	public string NegativeSign
	{
		 get { } //Length: 6
	}

	public int NumberDecimalDigits
	{
		 get { } //Length: 6
	}

	public string NumberDecimalSeparator
	{
		 get { } //Length: 6
	}

	public string NumberGroupSeparator
	{
		 get { } //Length: 6
	}

	public int[] NumberGroupSizes
	{
		 get { } //Length: 56
	}

	public int NumberNegativePattern
	{
		 get { } //Length: 6
	}

	public int PercentDecimalDigits
	{
		 get { } //Length: 6
	}

	public string PercentDecimalSeparator
	{
		 get { } //Length: 6
	}

	public string PercentGroupSeparator
	{
		 get { } //Length: 9
	}

	public int[] PercentGroupSizes
	{
		 get { } //Length: 56
	}

	public int PercentNegativePattern
	{
		 get { } //Length: 6
	}

	public int PercentPositivePattern
	{
		 get { } //Length: 6
	}

	public string PercentSymbol
	{
		 get { } //Length: 6
	}

	public string PerMilleSymbol
	{
		 get { } //Length: 6
	}

	public string PositiveInfinitySymbol
	{
		 get { } //Length: 6
	}

	public string PositiveSign
	{
		 get { } //Length: 6
	}

	public NumberFormatInfo() { }

	internal NumberFormatInfo(CultureData cultureData) { }

	public object Clone() { }

	public int get_CurrencyDecimalDigits() { }

	public string get_CurrencyDecimalSeparator() { }

	public string get_CurrencyGroupSeparator() { }

	public int[] get_CurrencyGroupSizes() { }

	public int get_CurrencyNegativePattern() { }

	public int get_CurrencyPositivePattern() { }

	public string get_CurrencySymbol() { }

	public static NumberFormatInfo get_CurrentInfo() { }

	public static NumberFormatInfo get_InvariantInfo() { }

	public bool get_IsReadOnly() { }

	public string get_NaNSymbol() { }

	public string get_NegativeInfinitySymbol() { }

	public string get_NegativeSign() { }

	public int get_NumberDecimalDigits() { }

	public string get_NumberDecimalSeparator() { }

	public string get_NumberGroupSeparator() { }

	public int[] get_NumberGroupSizes() { }

	public int get_NumberNegativePattern() { }

	public int get_PercentDecimalDigits() { }

	public string get_PercentDecimalSeparator() { }

	public string get_PercentGroupSeparator() { }

	public int[] get_PercentGroupSizes() { }

	public int get_PercentNegativePattern() { }

	public int get_PercentPositivePattern() { }

	public string get_PercentSymbol() { }

	public string get_PerMilleSymbol() { }

	public string get_PositiveInfinitySymbol() { }

	public string get_PositiveSign() { }

	public object GetFormat(Type formatType) { }

	public static NumberFormatInfo GetInstance(IFormatProvider formatProvider) { }

	private void OnDeserialized(StreamingContext ctx) { }

	private void OnDeserializing(StreamingContext ctx) { }

	private void OnSerializing(StreamingContext ctx) { }

	public static NumberFormatInfo ReadOnly(NumberFormatInfo nfi) { }

	internal static void ValidateParseStyleFloatingPoint(NumberStyles style) { }

	internal static void ValidateParseStyleInteger(NumberStyles style) { }

}

