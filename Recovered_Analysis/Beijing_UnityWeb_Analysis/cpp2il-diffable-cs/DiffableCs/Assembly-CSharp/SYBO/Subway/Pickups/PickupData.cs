namespace SYBO.Subway.Pickups;

public class PickupData : ICloneable
{
	private PickupType _pickupType; //Field offset: 0x8
	private GameObject _pickupVisualsPrefab; //Field offset: 0xC
	private PickupEnabledState _pickupEnabledState; //Field offset: 0x10
	private SpawnPointDifficulty _spawnPointDifficulty; //Field offset: 0x14
	private SpawnPointHeight _spawnPointHeight; //Field offset: 0x18
	private SpawnDistanceMinToPreviousMode _spawnDistanceMinToPreviousMode; //Field offset: 0x1C
	private float _spawnDistanceMinToPrevious; //Field offset: 0x20
	private float _spawnWeight; //Field offset: 0x24

	public PickupEnabledState PickupEnabledState
	{
		 get { } //Length: 6
		 set { } //Length: 84
	}

	public PickupType PickupType
	{
		 get { } //Length: 14
	}

	public GameObject PickupVisualsPrefab
	{
		 get { } //Length: 6
	}

	public float SpawnDistanceMinToPrevious
	{
		 get { } //Length: 6
	}

	public SpawnDistanceMinToPreviousMode SpawnDistanceMinToPreviousMode
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public SpawnPointDifficulty SpawnPointDifficulty
	{
		 get { } //Length: 6
	}

	public SpawnPointHeight SpawnPointHeight
	{
		 get { } //Length: 6
	}

	public float SpawnWeight
	{
		 get { } //Length: 6
		 set { } //Length: 126
	}

	public PickupData() { }

	public PickupData(PickupType pickupType, GameObject pickupVisualsPrefab, PickupEnabledState pickupEnabledState, SpawnPointHeight spawnPointHeight, SpawnPointDifficulty spawnPointDifficulty, SpawnDistanceMinToPreviousMode spawnDistanceMinToPreviousMode, float spawnDistanceMinToPrevious) { }

	public PickupData(PickupData other) { }

	public object Clone() { }

	private void DebugLog(string message) { }

	public PickupEnabledState get_PickupEnabledState() { }

	public PickupType get_PickupType() { }

	public GameObject get_PickupVisualsPrefab() { }

	public float get_SpawnDistanceMinToPrevious() { }

	public SpawnDistanceMinToPreviousMode get_SpawnDistanceMinToPreviousMode() { }

	public SpawnPointDifficulty get_SpawnPointDifficulty() { }

	public SpawnPointHeight get_SpawnPointHeight() { }

	public float get_SpawnWeight() { }

	private bool IsCompatibleWithConstrainingBuilder(PickupSpawnPoint pickupSpawnPoint) { }

	public bool IsCompatibleWithSpawnPoint(PickupSpawnPoint pickupSpawnPoint) { }

	private bool IsCompatibleWithSpawnPointDifficulty(PickupSpawnPoint pickupSpawnPoint) { }

	private bool IsCompatibleWithSpawnPointHeight(PickupSpawnPoint pickupSpawnPoint) { }

	private bool IsCompatibleWithSpawnPointZPosition(PickupSpawnPoint pickupSpawnPoint) { }

	public void set_PickupEnabledState(PickupEnabledState value) { }

	public void set_SpawnDistanceMinToPreviousMode(SpawnDistanceMinToPreviousMode value) { }

	public void set_SpawnWeight(float value) { }

	public override string ToString() { }

}

