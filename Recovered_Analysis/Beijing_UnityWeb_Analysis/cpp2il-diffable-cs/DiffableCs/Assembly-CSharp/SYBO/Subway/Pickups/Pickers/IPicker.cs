namespace SYBO.Subway.Pickups.Pickers;

public interface IPicker
{

	public event Action<PickerRemoveRequestEventArgs> OnRemoveRequest
	{
		 add { } //Length: 0
		 remove { } //Length: 0
	}

	public int ExecutionOrder
	{
		 get { } //Length: 0
	}

	public string Name
	{
		 get { } //Length: 0
	}

	public float ProbabilityToSpawn
	{
		 get { } //Length: 0
	}

	public float SpawnDistanceMinToPrevious
	{
		 get { } //Length: 0
	}

	public void Add(PickupManager pickupManager) { }

	public void add_OnRemoveRequest(Action<PickerRemoveRequestEventArgs> value) { }

	public int get_ExecutionOrder() { }

	public string get_Name() { }

	public float get_ProbabilityToSpawn() { }

	public float get_SpawnDistanceMinToPrevious() { }

	public void remove_OnRemoveRequest(Action<PickerRemoveRequestEventArgs> value) { }

	public bool UpdatePicker() { }

}

