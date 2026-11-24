namespace SYBO.Subway.Coins;

public class CoinStats
{
	public static CoinStats New; //Field offset: 0x0
	public static CoinStats Old; //Field offset: 0x4
	private int <CreatedCoins>k__BackingField; //Field offset: 0x8
	private int <DestroyedCoins>k__BackingField; //Field offset: 0xC
	private int <ActivatedCoins>k__BackingField; //Field offset: 0x10
	private int <DeactivatedCoins>k__BackingField; //Field offset: 0x14
	private int <ActivatedSpawnPoints>k__BackingField; //Field offset: 0x18
	private int <DeactivatedSpawnPoints>k__BackingField; //Field offset: 0x1C
	private int <DynamicCoinSpawns>k__BackingField; //Field offset: 0x20
	private int <DynamicCoinDespawns>k__BackingField; //Field offset: 0x24

	public int ActivatedCoins
	{
		 get { } //Length: 6
		private set { } //Length: 8
	}

	public int ActivatedSpawnPoints
	{
		 get { } //Length: 6
		private set { } //Length: 8
	}

	public int CreatedCoins
	{
		 get { } //Length: 171
		private set { } //Length: 44
	}

	public int DeactivatedCoins
	{
		 get { } //Length: 6
		private set { } //Length: 8
	}

	public int DeactivatedSpawnPoints
	{
		 get { } //Length: 6
		private set { } //Length: 8
	}

	public int DestroyedCoins
	{
		 get { } //Length: 6
		private set { } //Length: 8
	}

	public int DynamicCoinDespawns
	{
		 get { } //Length: 6
		private set { } //Length: 8
	}

	public int DynamicCoinSpawns
	{
		 get { } //Length: 6
		private set { } //Length: 8
	}

	private static CoinStats() { }

	public CoinStats() { }

	public int get_ActivatedCoins() { }

	public int get_ActivatedSpawnPoints() { }

	public int get_CreatedCoins() { }

	public int get_DeactivatedCoins() { }

	public int get_DeactivatedSpawnPoints() { }

	public int get_DestroyedCoins() { }

	public int get_DynamicCoinDespawns() { }

	public int get_DynamicCoinSpawns() { }

	public void NotifyCoinActivated() { }

	public void NotifyCoinCreated() { }

	public void NotifyCoinDeactivated() { }

	public void NotifyCoinDestroyed() { }

	public void NotifyDynamicCoinsDespawned(int coins) { }

	public void NotifyDynamicCoinSpawned() { }

	public void NotifySpawnPointActivated(int coins) { }

	public void NotifySpawnPointDeactivated(int coins) { }

	private void set_ActivatedCoins(int value) { }

	private void set_ActivatedSpawnPoints(int value) { }

	private void set_CreatedCoins(int value) { }

	private void set_DeactivatedCoins(int value) { }

	private void set_DeactivatedSpawnPoints(int value) { }

	private void set_DestroyedCoins(int value) { }

	private void set_DynamicCoinDespawns(int value) { }

	private void set_DynamicCoinSpawns(int value) { }

}

