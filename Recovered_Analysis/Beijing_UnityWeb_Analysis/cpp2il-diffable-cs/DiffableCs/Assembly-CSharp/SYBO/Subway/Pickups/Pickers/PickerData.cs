namespace SYBO.Subway.Pickups.Pickers;

public class PickerData
{
	internal PickerType _pickerType; //Field offset: 0x8
	private PickerEnabledState _pickerEnabledState; //Field offset: 0xC
	internal PickupType _pickupType; //Field offset: 0x10
	private SpawnDistanceMinToPreviousMode _spawnDistanceMinToPreviousMode; //Field offset: 0x14
	private float _spawnDistanceMinToPrevious; //Field offset: 0x18
	internal float _probabilityToSpawn; //Field offset: 0x1C
	protected int _executionOrder; //Field offset: 0x20

	public int ExecutionOrder
	{
		 get { } //Length: 6
	}

	public PickerEnabledState PickerEnabledState
	{
		 get { } //Length: 6
		 set { } //Length: 62
	}

	public PickerType PickerType
	{
		 get { } //Length: 194
	}

	public PickupType PickupType
	{
		 get { } //Length: 6
	}

	public float ProbabilityToSpawn
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

	public PickerData() { }

	private void DebugLog(string message) { }

	public int get_ExecutionOrder() { }

	public PickerEnabledState get_PickerEnabledState() { }

	public PickerType get_PickerType() { }

	public PickupType get_PickupType() { }

	public float get_ProbabilityToSpawn() { }

	public float get_SpawnDistanceMinToPrevious() { }

	public SpawnDistanceMinToPreviousMode get_SpawnDistanceMinToPreviousMode() { }

	public bool IsCompatibleWithSpawnPoint(PickupSpawnPoint pickupSpawnPoint) { }

	public void set_PickerEnabledState(PickerEnabledState value) { }

	public void set_SpawnDistanceMinToPreviousMode(SpawnDistanceMinToPreviousMode value) { }

	public override string ToString() { }

}

