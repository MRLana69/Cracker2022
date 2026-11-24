namespace Kiloo.Common.LocalizationManager;

public class Locale
{
	public enum LocaleType
	{
		Language = 0,
		LanguageAndRegion = 1,
	}

	public readonly LocaleType localeType; //Field offset: 0x8
	public readonly string language; //Field offset: 0xC
	public readonly string region; //Field offset: 0x10
	public readonly string[] extraRegions; //Field offset: 0x14
	public readonly string combined; //Field offset: 0x18
	public readonly string nativeName; //Field offset: 0x1C

	private Locale(string language, string region, string[] extraRegions, string nativeName) { }

	public static Locale Create(string language, string region = null, string[] extraRegions = null, string nativeName = null) { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	private string GetLanguageCode() { }

	private bool IsValid() { }

	public static bool op_Equality(Locale loc1, Locale loc2) { }

	public static bool op_Inequality(Locale loc1, Locale loc2) { }

	public static Locale Parse(string input) { }

	public static bool TryParse(string input, out Locale locale) { }

}

