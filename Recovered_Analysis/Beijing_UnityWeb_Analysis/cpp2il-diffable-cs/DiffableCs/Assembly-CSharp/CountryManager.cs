//Type is in global namespace

public class CountryManager
{
	private enum LocaleComponents
	{
		language = 0,
		countryCode = 1,
	}

	private static CountryManager _instance; //Field offset: 0x0

	public static CountryManager instance
	{
		 get { } //Length: 13739
	}

	private CountryManager() { }

	public static CountryManager get_instance() { }

	private static string GetCountryCodeFromLocale(string deviceLocale) { }

	public int GetCurrentCountryIndex() { }

	public Country GetCurrentTournamentCountry() { }

	public string GetDefaultCountryCodeFromDevice() { }

	public List<Country> GetListOfCountries() { }

	public static void Log(string msg, Object context = null) { }

	public static void LogError(string msg, Object context = null) { }

	public static void LogWarning(string msg, Object context = null) { }

}

