namespace SYBO.Subway.Pickups.Picker.Pickers;

public abstract class BasePicker : IPicker
{
	private Action<PickerRemoveRequestEventArgs> _onRemoveRequest; //Field offset: 0x8
	protected PickupManager _pickupManager; //Field offset: 0xC
	protected PickerData _pickerData; //Field offset: 0x10
	private List<PickupData> _filteredPickupDatas; //Field offset: 0x14

	protected event Action<PickerRemoveRequestEventArgs> _onRemoveRequest
	{
		 add { } //Length: 11
		 remove { } //Length: 111
	}

	private event Action<PickerRemoveRequestEventArgs> SYBO.Subway.Pickups.Pickers.IPicker.OnRemoveRequest
	{
		 add { } //Length: 111
		 remove { } //Length: 11
	}

	public int ExecutionOrder
	{
		 get { } //Length: 6
	}

	public string Name
	{
		 get { } //Length: 9
	}

	public float ProbabilityToSpawn
	{
		 get { } //Length: 9
	}

	public float SpawnDistanceMinToPrevious
	{
		 get { } //Length: 6
	}

	protected BasePicker() { }

	public void Add(PickupManager pickupManager) { }

	protected void add__onRemoveRequest(Action<PickerRemoveRequestEventArgs> value) { }

	protected void AddProtected(PickupManager pickupManager, PickerType pickerType) { }

	protected PickupData ChoosePickupDataBasedUponWeight(List<PickupData> pickupDataList) { }

	public int get_ExecutionOrder() { }

	public string get_Name() { }

	public float get_ProbabilityToSpawn() { }

	public float get_SpawnDistanceMinToPrevious() { }

	private PickupData MaybeChoosePickupDataForSpawnPoint(PickupSpawnPoint pickupSpawnPoint) { }

	protected void MaybeChooseSpawnPoint(List<PickupSpawnPoint> populatedSpawnedPoints = null) { }

	protected void remove__onRemoveRequest(Action<PickerRemoveRequestEventArgs> value) { }

	private void SYBO.Subway.Pickups.Pickers.IPicker.add_OnRemoveRequest(Action<PickerRemoveRequestEventArgs> value) { }

	private void SYBO.Subway.Pickups.Pickers.IPicker.remove_OnRemoveRequest(Action<PickerRemoveRequestEventArgs> value) { }

	protected void TriggerOnRequestRemoval(PickerRemoveRequestEventArgs requestRemovalEvent) { }

	public bool UpdatePicker() { }

	protected void UpdatePickerProtected(List<PickupSpawnPoint> populatedSpawnedPoints = null) { }

}

