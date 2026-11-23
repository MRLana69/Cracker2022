public class SellableConsumable
{
	public static readonly SellableConsumable headstart;

	public static readonly SellableConsumable scorebooster;

	public static readonly SellableConsumable hoverboard;

	private PowerupType powerupType__BackingField;

	private int price__BackingField;

	private string sprite__BackingField;

	private string header__BackingField;

	public PowerupType powerupType
	{
		get
		{
			return powerupType__BackingField;
		}
		private set
		{
			powerupType__BackingField = value;
		}
	}

	public int price
	{
		get
		{
			return price__BackingField;
		}
		private set
		{
			price__BackingField = value;
		}
	}

	public string sprite
	{
		get
		{
			return sprite__BackingField;
		}
		private set
		{
			sprite__BackingField = value;
		}
	}

	public string header
	{
		get
		{
			return header__BackingField;
		}
		private set
		{
			header__BackingField = value;
		}
	}

	private SellableConsumable(PowerupType powerupType, int price, string sprite, string header)
	{
		this.sprite__BackingField = sprite;
		this.price__BackingField = price;
		this.powerupType__BackingField = powerupType;
		this.header__BackingField = header;
	}

	static SellableConsumable()
	{
		Upgrade upgrade = Upgrades.upgrades.get_Item(PowerupType.headstart2000);
		int num = upgrade.getPrice(0);
		string text = Strings.Get(StringID.CONSUMABLES_POPUP_HEADER_HEADSTART);
		SellableConsumable sellableConsumable = default;
		sellableConsumable.sprite__BackingField = "icon_upgrades_headstart2000_large";
		sellableConsumable.price__BackingField = num;
		sellableConsumable.powerupType__BackingField = PowerupType.headstart2000;
		sellableConsumable.header__BackingField = text;
		headstart = sellableConsumable;
		Upgrade upgrade2 = Upgrades.upgrades.get_Item(PowerupType.scorebooster);
		int num2 = upgrade2.getPrice(0);
		string text2 = Strings.Get(StringID.CONSUMABLES_POPUP_HEADER_SCOREBOOSTER);
		SellableConsumable sellableConsumable2 = default;
		sellableConsumable2.sprite__BackingField = "icon_upgrades_scorebooster_large";
		sellableConsumable2.price__BackingField = num2;
		sellableConsumable2.powerupType__BackingField = PowerupType.scorebooster;
		sellableConsumable2.header__BackingField = text2;
		scorebooster = sellableConsumable2;
		Upgrade upgrade3 = Upgrades.upgrades.get_Item(PowerupType.hoverboard);
		int num3 = upgrade3.getPrice(0);
		string text3 = Strings.Get(StringID.CONSUMABLES_POPUP_HEADER_HOVERBOARD);
		SellableConsumable sellableConsumable3 = default;
		sellableConsumable3.sprite__BackingField = "icon_upgrades_hoverboard_large";
		sellableConsumable3.price__BackingField = num3;
		sellableConsumable3.powerupType__BackingField = PowerupType.hoverboard;
		sellableConsumable3.header__BackingField = text3;
		hoverboard = sellableConsumable3;
	}
}
