namespace SYBO.Subway.Pickups;

public class PickupManager
{
	public class PickupEventArgs : EventArgs
	{
		public readonly PickupSpawnPoint SpawnPoint; //Field offset: 0x8
		public readonly PickupData PickupData; //Field offset: 0xC
		public readonly SpawnPointMode SpawnPointMode; //Field offset: 0x10

		public PickupEventArgs(PickupSpawnPoint spawnPoint, PickupData pickupData, SpawnPointMode spawnPointMode) { }

	}

	private enum ReasonToResetHistory
	{
		SESSION_STARTED = 0,
		GAME_STARTED = 1,
		RUN_STARTED = 2,
	}

	private const int PickerTypeShortNameLength = 8; //Field offset: 0x0
	private const int PickupTypeShortNameLength = 9; //Field offset: 0x0
	private const int DelayBeforeUpdatingPickerCollectionCountMax = 60; //Field offset: 0x0
	public static readonly float SpawnDistanceMinToCharacter; //Field offset: 0x0
	private EventHandler<PickupEventArgs> OnPickupSpawned; //Field offset: 0x10
	private EventHandler<PickupEventArgs> OnPickupDespawned; //Field offset: 0x14
	private EventHandler<PickupEventArgs> OnPickupCollected; //Field offset: 0x18
	private Action<PickupSpawnPoint> OnPickupSpawnPointRegistered; //Field offset: 0x1C
	private Action<PickupSpawnPoint> OnPickupSpawnPointDeregistered; //Field offset: 0x20
	private Action<PickerRemovedEventArgs> OnPickerRemoved; //Field offset: 0x24
	private bool _willDebugLogPickers; //Field offset: 0x28
	private bool _willDebugLogPickupData; //Field offset: 0x29
	internal GameObject _pickupSpawnPointPrefab; //Field offset: 0x2C
	private float _spawnDistanceMinToGameStart; //Field offset: 0x30
	internal PickupData[] _pickupData; //Field offset: 0x34
	public PickerData[] _pickerData; //Field offset: 0x38
	private List<PickupSpawnPoint> _pickupSpawnPoints; //Field offset: 0x3C
	internal PickerCollection _pickerCollection; //Field offset: 0x40
	private int _delayBeforeUpdatingPickerCollectionCount; //Field offset: 0x44
	public readonly Dictionary<int, float> PickupLastSpawnZGamePosition; //Field offset: 0x48
	public readonly Dictionary<int, float> PickerLastSpawnZGamePosition; //Field offset: 0x4C

	public event Action<PickerRemovedEventArgs> OnPickerRemoved
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public event EventHandler<PickupEventArgs> OnPickupCollected
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public event EventHandler<PickupEventArgs> OnPickupDespawned
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public event EventHandler<PickupEventArgs> OnPickupSpawned
	{
		 add { } //Length: 66
		 remove { } //Length: 111
	}

	public event Action<PickupSpawnPoint> OnPickupSpawnPointDeregistered
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public event Action<PickupSpawnPoint> OnPickupSpawnPointRegistered
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	internal List<PickupSpawnPoint> PickupSpawnPointList
	{
		 get { } //Length: 166
	}

	public float SpawnDistanceMinToGameStart
	{
		 get { } //Length: 6
	}

	public bool WillDebugLogPickers
	{
		 get { } //Length: 6
	}

	public bool WillDebugLogPickupData
	{
		 get { } //Length: 9
	}

	private static PickupManager() { }

	public PickupManager() { }

	public void add_OnPickerRemoved(Action<PickerRemovedEventArgs> value) { }

	public void add_OnPickupCollected(EventHandler<PickupEventArgs> value) { }

	public void add_OnPickupDespawned(EventHandler<PickupEventArgs> value) { }

	public void add_OnPickupSpawned(EventHandler<PickupEventArgs> value) { }

	public void add_OnPickupSpawnPointDeregistered(Action<PickupSpawnPoint> value) { }

	public void add_OnPickupSpawnPointRegistered(Action<PickupSpawnPoint> value) { }

	public void DeregisterPickupSpawnPoint(PickupSpawnPoint pickupSpawnPoint) { }

	public void Despawn(Transform transformToDespawn) { }

	protected void FixedUpdate() { }

	public void Game_OnGameStarted() { }

	public void Game_OnRunStarted(bool wasPlayerRevived, bool revivedWithAds = false, bool adsWasAvailable = true, bool adsFailed = false) { }

	internal List<PickupSpawnPoint> get_PickupSpawnPointList() { }

	public float get_SpawnDistanceMinToGameStart() { }

	public bool get_WillDebugLogPickers() { }

	public bool get_WillDebugLogPickupData() { }

	internal PickerData GetPickerDataForPickerType(PickerType pickerType) { }

	public PickupData GetPickupDataForPickupType(PickupType pickupType) { }

	public bool HasPickupDataForPickupType(PickupType pickupType) { }

	public bool IsSpawned(Transform transformToDespawn) { }

	protected override void OnDestroy() { }

	private void PickerCollection_OnPickerRemoveRequest(PickerRemoveRequestEventArgs pickerRemoveRequestEvent) { }

	private void PickupSpawnPoint_OnDeregistered(PickupSpawnPoint pickupSpawnPoint) { }

	private void PickupSpawnPoint_OnPickupCollected(PickupSpawnPoint pickupSpawnPoint) { }

	private void PickupSpawnPoint_OnPickupDespawned(PickupSpawnPoint pickupSpawnPoint) { }

	private void PickupSpawnPoint_OnPickupSpawned(PickupSpawnPoint pickupSpawnPoint, PickerData pickerData) { }

	private void PickupSpawnPoint_OnRegistered(PickupSpawnPoint pickupSpawnPoint) { }

	public void RegisterPickupSpawnPoint(PickupSpawnPoint pickupSpawnPoint) { }

	public void remove_OnPickerRemoved(Action<PickerRemovedEventArgs> value) { }

	public void remove_OnPickupCollected(EventHandler<PickupEventArgs> value) { }

	public void remove_OnPickupDespawned(EventHandler<PickupEventArgs> value) { }

	public void remove_OnPickupSpawned(EventHandler<PickupEventArgs> value) { }

	public void remove_OnPickupSpawnPointDeregistered(Action<PickupSpawnPoint> value) { }

	public void remove_OnPickupSpawnPointRegistered(Action<PickupSpawnPoint> value) { }

	private void ResetPickerLastSpawnPositions(ReasonToResetHistory reasonToResetHistory) { }

	private void ResetPickupAndPickerLastPositions(ReasonToResetHistory reasonToResetHistory) { }

	private void ResetPickupLastSpawnPositions(ReasonToResetHistory reasonToResetHistory) { }

	public void SetPickerState(PickerType pickerType, PickerEnabledState state) { }

	private static int SortSpawnPointsClosestFirst(PickupSpawnPoint left, PickupSpawnPoint right) { }

	public GameObject Spawn(Transform transformToSpawn, Vector3 position, Quaternion rotation) { }

	public GameObject SpawnPickupSpawnPoint() { }

	protected override void SubclassInitialize() { }

	private void UpdatePickerCollection(bool isForcedUpdate) { }

	public void UpdatePickerCollectionForced() { }

}

