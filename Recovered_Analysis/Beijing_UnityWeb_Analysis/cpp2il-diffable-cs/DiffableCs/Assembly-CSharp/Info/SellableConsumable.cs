namespace Info;

public class SellableConsumable
{
	public static readonly SellableConsumable headstart; //Field offset: 0x0
	public static readonly SellableConsumable scorebooster; //Field offset: 0x4
	public static readonly SellableConsumable hoverboard; //Field offset: 0x8
	private UpgradeType <upgradeType>k__BackingField; //Field offset: 0x8
	private int <price>k__BackingField; //Field offset: 0xC
	private string <spriteName>k__BackingField; //Field offset: 0x10
	private string <header>k__BackingField; //Field offset: 0x14
	private string <description>k__BackingField; //Field offset: 0x18

	public string description
	{
		 get { } //Length: 6
		private set { } //Length: 11
	}

	public string header
	{
		 get { } //Length: 6
		private set { } //Length: 11
	}

	public int price
	{
		 get { } //Length: 6
		private set { } //Length: 8
	}

	public string spriteName
	{
		 get { } //Length: 6
		private set { } //Length: 8
	}

	public UpgradeType upgradeType
	{
		 get { } //Length: 222
		private set { } //Length: 172
	}

	private static SellableConsumable() { }

	private SellableConsumable(UpgradeType upgradeType, int price, string spriteName, string header, string description) { }

	public string get_description() { }

	public string get_header() { }

	public int get_price() { }

	public string get_spriteName() { }

	public UpgradeType get_upgradeType() { }

	private void set_description(string value) { }

	private void set_header(string value) { }

	private void set_price(int value) { }

	private void set_spriteName(string value) { }

	private void set_upgradeType(UpgradeType value) { }

}

