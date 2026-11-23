public class Country
{
	public string name
	{
		get
		{
			return field;
		}
		set
		{
			field = value;
		}
	}

	public string flag
	{
		get
		{
			return field;
		}
		set
		{
			field = value;
		}
	}

	public string countryCode
	{
		get
		{
			return field;
		}
		set
		{
			field = value;
		}
	}

	public Country(string nameT, string flagT, string countryCodeT)
	{
		name__BackingField = nameT;
		flag__BackingField = flagT;
		countryCode__BackingField = countryCodeT;
	}

	public Country()
	{
	}
}
