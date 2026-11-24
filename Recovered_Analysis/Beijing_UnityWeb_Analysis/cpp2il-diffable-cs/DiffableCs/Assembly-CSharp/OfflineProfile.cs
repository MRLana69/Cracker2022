//Type is in global namespace

public class OfflineProfile
{
	public enum ProfileOrigin
	{
		Facebook = 0,
		GameCenter = 1,
	}

	public string name; //Field offset: 0x8
	public ProfileOrigin origin; //Field offset: 0xC

	public OfflineProfile() { }

}

