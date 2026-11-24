namespace Kiloo.Common.Ads;

public class AdProviderInfo
{
	private float <weight>k__BackingField; //Field offset: 0x8
	private int <priority>k__BackingField; //Field offset: 0xC
	private string <providerID>k__BackingField; //Field offset: 0x10

	public int priority
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public string providerID
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public float weight
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public AdProviderInfo() { }

	public int get_priority() { }

	public string get_providerID() { }

	public float get_weight() { }

	public void set_priority(int value) { }

	public void set_providerID(string value) { }

	public void set_weight(float value) { }

}

