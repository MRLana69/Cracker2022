namespace SYBO.Subway.Coins;

public class CoinStats
{
	public static CoinStats New;

	public static CoinStats Old;

	private int CreatedCoins__BackingField;

	private int DestroyedCoins__BackingField;

	private int ActivatedCoins__BackingField;

	private int DeactivatedCoins__BackingField;

	private int ActivatedSpawnPoints__BackingField;

	private int DeactivatedSpawnPoints__BackingField;

	private int DynamicCoinSpawns__BackingField;

	private int DynamicCoinDespawns__BackingField;

	public int CreatedCoins
	{
		get
		{
			return CreatedCoins__BackingField;
		}
		private set
		{
			CreatedCoins__BackingField = value;
		}
	}

	public int DestroyedCoins
	{
		get
		{
			return DestroyedCoins__BackingField;
		}
		private set
		{
			DestroyedCoins__BackingField = value;
		}
	}

	public int ActivatedCoins
	{
		get
		{
			return ActivatedCoins__BackingField;
		}
		private set
		{
			ActivatedCoins__BackingField = value;
		}
	}

	public int DeactivatedCoins
	{
		get
		{
			return DeactivatedCoins__BackingField;
		}
		private set
		{
			DeactivatedCoins__BackingField = value;
		}
	}

	public int ActivatedSpawnPoints
	{
		get
		{
			return ActivatedSpawnPoints__BackingField;
		}
		private set
		{
			ActivatedSpawnPoints__BackingField = value;
		}
	}

	public int DeactivatedSpawnPoints
	{
		get
		{
			return DeactivatedSpawnPoints__BackingField;
		}
		private set
		{
			DeactivatedSpawnPoints__BackingField = value;
		}
	}

	public int DynamicCoinSpawns
	{
		get
		{
			return DynamicCoinSpawns__BackingField;
		}
		private set
		{
			DynamicCoinSpawns__BackingField = value;
		}
	}

	public int DynamicCoinDespawns
	{
		get
		{
			return DynamicCoinDespawns__BackingField;
		}
		private set
		{
			DynamicCoinDespawns__BackingField = value;
		}
	}

	public void NotifyCoinCreated()
	{
		int num = CreatedCoins__BackingField + 1;
		CreatedCoins__BackingField = num;
	}

	public void NotifyCoinDestroyed()
	{
		int num = DestroyedCoins__BackingField + 1;
		DestroyedCoins__BackingField = num;
	}

	public void NotifyCoinActivated()
	{
		int num = ActivatedCoins__BackingField + 1;
		ActivatedCoins__BackingField = num;
	}

	public void NotifyCoinDeactivated()
	{
		int num = DeactivatedCoins__BackingField + 1;
		DeactivatedCoins__BackingField = num;
	}

	public void NotifySpawnPointActivated(int coins)
	{
		int num = coins + ActivatedSpawnPoints__BackingField;
		ActivatedSpawnPoints__BackingField = num;
	}

	public void NotifySpawnPointDeactivated(int coins)
	{
		int num = coins + DeactivatedSpawnPoints__BackingField;
		DeactivatedSpawnPoints__BackingField = num;
	}

	public void NotifyDynamicCoinSpawned()
	{
		int num = DynamicCoinSpawns__BackingField + 1;
		DynamicCoinSpawns__BackingField = num;
	}

	public void NotifyDynamicCoinsDespawned(int coins)
	{
		int num = coins + DynamicCoinDespawns__BackingField;
		DynamicCoinDespawns__BackingField = num;
	}

	static CoinStats()
	{
		CoinStats coinStats = default;
		New = coinStats;
		CoinStats old = default;
		Old = old;
	}
}
