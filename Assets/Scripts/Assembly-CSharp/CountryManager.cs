using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo.Plugins.DeviceUtility;
using TopRun;
using UnityEngine;

public class CountryManager
{
	private enum LocaleComponents
	{
		language,
		countryCode
	}

	private static CountryManager _instance;

	public static CountryManager instance
	{
		get
		{
			if (_instance == null)
			{
				CountryManager countryManager = default;
				_instance = countryManager;
			}
			return _instance;
		}
	}

	private CountryManager()
	{
	}

	public string GetDefaultCountryCodeFromDevice()
	{
		string locale = DeviceUtility.GetLocale();
		string contryCodeFromLocale = GetContryCodeFromLocale(locale);
		Country countryForID = CountryData.GetCountryForID(contryCodeFromLocale);
		Country country = countryForID;
		if (countryForID == null)
		{
			Country motherCountryForCountryID = CountryData.GetMotherCountryForCountryID(contryCodeFromLocale);
			country = motherCountryForCountryID;
			if (motherCountryForCountryID == null)
			{
				return "US";
			}
		}
		return country.countryCode__BackingField.ToUpper();
	}

	public List<Country> getListOfCountries()
	{
		return CountryData.getListOfCountries();
	}

	public int getCurrentCountryIndex()
	{
		if (TopRunRoot.manager__BackingField != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			object obj = default;
			if (obj != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			}
			string text2 = default;
			string text = text2.ToLower();
			int num = 0;
			while (true)
			{
				List<Country> listOfCountries = CountryData.getListOfCountries();
				if (num >= listOfCountries._size)
				{
					break;
				}
				List<Country> listOfCountries2 = CountryData.getListOfCountries();
				Country country = listOfCountries2.get_Item(num);
				if (country.countryCode__BackingField == text)
				{
					return num;
				}
				int num2 = num + 1;
				num = num2;
			}
		}
		return 0;
	}

	private static string GetContryCodeFromLocale(string deviceLocale)
	{
		//IL_002a: Expected Obj, but got I4
		//IL_000e: Expected Obj, but got I4
		object obj;
		if (deviceLocale != null)
		{
			obj = 0;
			if (deviceLocale._stringLength != 0)
			{
				goto IL_0114;
			}
		}
		obj = 1;
		goto IL_0114;
		IL_0114:
		string result = string.Empty;
		if (obj == null)
		{
			string text = deviceLocale.Trim();
			string text2 = text.ToLower();
			string text3 = text2.Replace('-', '_');
			bool flag = text3.Contains("_");
			bool flag2 = !flag;
			result = string.Empty;
			if (!flag2)
			{
				string[] array = text3.Split('_');
				bool flag3 = array.Length != 2;
				result = string.Empty;
				if (!flag3)
				{
					result = array[1];
				}
			}
		}
		return result;
	}

	public Country GetCurrentTournamentCountry()
	{
		Country result;
		if (TopRunRoot.manager__BackingField != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			object obj = default;
			if (obj != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			}
			string id = default;
			Country countryForID = CountryData.GetCountryForID(id);
			result = countryForID;
			if (countryForID != null)
			{
				goto IL_00b8;
			}
		}
		Country country = default;
		country.name__BackingField = string.Empty;
		country.flag__BackingField = string.Empty;
		country.countryCode__BackingField = string.Empty;
		result = country;
		goto IL_00b8;
		IL_00b8:
		return result;
	}

	public static void LogError(string msg, Object context = null)
	{
		string text = "[CountryManager] " + msg;
	}

	public static void LogWarning(string msg, Object context = null)
	{
	}

	public static void Log(string msg, Object context = null)
	{
	}
}
