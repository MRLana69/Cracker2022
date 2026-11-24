namespace System.Resources;

public sealed class NeutralResourcesLanguageAttribute : Attribute
{
	private string _culture; //Field offset: 0x8
	private UltimateResourceFallbackLocation _fallbackLoc; //Field offset: 0xC

	public string CultureName
	{
		 get { } //Length: 57
	}

	public UltimateResourceFallbackLocation Location
	{
		 get { } //Length: 6
	}

	public NeutralResourcesLanguageAttribute(string cultureName) { }

	public string get_CultureName() { }

	public UltimateResourceFallbackLocation get_Location() { }

}

