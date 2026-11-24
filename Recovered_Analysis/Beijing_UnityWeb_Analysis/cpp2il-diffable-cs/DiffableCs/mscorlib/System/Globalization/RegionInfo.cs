namespace System.Globalization;

public class RegionInfo
{
	private static RegionInfo currentRegion; //Field offset: 0x0
	private int regionId; //Field offset: 0x8
	private string iso2Name; //Field offset: 0xC
	private string iso3Name; //Field offset: 0x10
	private string win3Name; //Field offset: 0x14
	private string englishName; //Field offset: 0x18
	private string nativeName; //Field offset: 0x1C
	private string currencySymbol; //Field offset: 0x20
	private string isoCurrencySymbol; //Field offset: 0x24
	private string currencyEnglishName; //Field offset: 0x28
	private string currencyNativeName; //Field offset: 0x2C

	public virtual string CurrencyEnglishName
	{
		 get { } //Length: 23
	}

	public virtual string CurrencyNativeName
	{
		 get { } //Length: 6
	}

	public virtual string CurrencySymbol
	{
		 get { } //Length: 6
	}

	public static RegionInfo CurrentRegion
	{
		 get { } //Length: 77
	}

	public virtual string DisplayName
	{
		 get { } //Length: 6
	}

	public virtual string EnglishName
	{
		 get { } //Length: 6
	}

	public virtual int GeoId
	{
		 get { } //Length: 6
	}

	public virtual bool IsMetric
	{
		 get { } //Length: 6
	}

	public virtual string ISOCurrencySymbol
	{
		 get { } //Length: 81
	}

	public virtual string Name
	{
		 get { } //Length: 6
	}

	public virtual string NativeName
	{
		 get { } //Length: 6
	}

	public virtual string ThreeLetterISORegionName
	{
		 get { } //Length: 6
	}

	public virtual string ThreeLetterWindowsRegionName
	{
		 get { } //Length: 6
	}

	public virtual string TwoLetterISORegionName
	{
		 get { } //Length: 6
	}

	public RegionInfo(int culture) { }

	public RegionInfo(string name) { }

	private RegionInfo(CultureInfo ci) { }

	internal static void ClearCachedData() { }

	private bool construct_internal_region_from_name(string name) { }

	public override bool Equals(object value) { }

	public virtual string get_CurrencyEnglishName() { }

	public virtual string get_CurrencyNativeName() { }

	public virtual string get_CurrencySymbol() { }

	public static RegionInfo get_CurrentRegion() { }

	public virtual string get_DisplayName() { }

	public virtual string get_EnglishName() { }

	public virtual int get_GeoId() { }

	public virtual bool get_IsMetric() { }

	public virtual string get_ISOCurrencySymbol() { }

	public virtual string get_Name() { }

	public virtual string get_NativeName() { }

	public virtual string get_ThreeLetterISORegionName() { }

	public virtual string get_ThreeLetterWindowsRegionName() { }

	public virtual string get_TwoLetterISORegionName() { }

	private bool GetByTerritory(CultureInfo ci) { }

	public override int GetHashCode() { }

	public override string ToString() { }

}

