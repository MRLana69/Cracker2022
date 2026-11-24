namespace Missions;

public class MissionSkip
{
	private string <name>k__BackingField; //Field offset: 0x8
	private int <rawPrice>k__BackingField; //Field offset: 0xC
	private int <priceIncrease>k__BackingField; //Field offset: 0x10

	public string name
	{
		 get { } //Length: 101
		private set { } //Length: 14
	}

	public int priceIncrease
	{
		 get { } //Length: 6
		private set { } //Length: 8
	}

	public int rawPrice
	{
		 get { } //Length: 6
		private set { } //Length: 11
	}

	public MissionSkip(string name, int rawPrice, int priceIncrease) { }

	public string get_name() { }

	public int get_priceIncrease() { }

	public int get_rawPrice() { }

	public int GetPrice() { }

	private void set_name(string value) { }

	private void set_priceIncrease(int value) { }

	private void set_rawPrice(int value) { }

}

