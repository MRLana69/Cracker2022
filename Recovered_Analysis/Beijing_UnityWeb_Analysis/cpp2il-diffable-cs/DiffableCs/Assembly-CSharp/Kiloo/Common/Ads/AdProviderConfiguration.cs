namespace Kiloo.Common.Ads;

public class AdProviderConfiguration
{
	private bool <isRestricted>k__BackingField; //Field offset: 0x8
	private string <appID>k__BackingField; //Field offset: 0xC
	private string <appSDKKey>k__BackingField; //Field offset: 0x10
	private string <appSignature>k__BackingField; //Field offset: 0x14
	private string[] <zoneIDs>k__BackingField; //Field offset: 0x18
	private string <initializePlacementId>k__BackingField; //Field offset: 0x1C

	public string appID
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public string appSDKKey
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public string appSignature
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public string initializePlacementId
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public bool isRestricted
	{
		 get { } //Length: 57
		 set { } //Length: 52
	}

	public string[] zoneIDs
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public AdProviderConfiguration() { }

	public string get_appID() { }

	public string get_appSDKKey() { }

	public string get_appSignature() { }

	public string get_initializePlacementId() { }

	public bool get_isRestricted() { }

	public string[] get_zoneIDs() { }

	public void set_appID(string value) { }

	public void set_appSDKKey(string value) { }

	public void set_appSignature(string value) { }

	public void set_initializePlacementId(string value) { }

	public void set_isRestricted(bool value) { }

	public void set_zoneIDs(string[] value) { }

}

