namespace SYBO.Subway.Pickups;

public class PickupSpawnPoint : MonoBehaviour
{
	public const string PickupSpawnPointPrefabProjectPath = "Assets/Resources/Prefabs/Pickups/Refactored/PickupSpawnPoint.prefab"; //Field offset: 0x0
	private Action<PickupSpawnPoint> OnRegistered; //Field offset: 0xC
	private Action<PickupSpawnPoint> OnDeregistered; //Field offset: 0x10
	private Action<PickupSpawnPoint> OnPickupDespawned; //Field offset: 0x14
	private Action<PickupSpawnPoint> OnPickupCollected; //Field offset: 0x18
	private Action<PickupSpawnPoint, PickerData> OnPickupSpawned; //Field offset: 0x1C
	internal GameObject _pickupParent; //Field offset: 0x20
	internal SpawnPointMode __spawnPointMode; //Field offset: 0x24
	internal PickupType __forceSpawnPickupType; //Field offset: 0x28
	internal SpawnPointDifficulty _spawnPointDifficulty; //Field offset: 0x2C
	internal SpawnPointHeight _spawnPointHeight; //Field offset: 0x30
	private PickupRotate _pickupRotate; //Field offset: 0x34
	private bool _ignoreJetpackZ; //Field offset: 0x38
	private PickupData _pickupData; //Field offset: 0x3C
	internal bool __willIgnoreZPositionBeforeSpawn; //Field offset: 0x40
	private SpawnPointMode _spawnPointModeOriginal; //Field offset: 0x44
	private bool _willIgnoreZPositionBeforeSpawnOriginal; //Field offset: 0x48
	private PickupType _forceSpawnPickupTypeOriginal; //Field offset: 0x4C
	private SpawnPointState __spawnPointState; //Field offset: 0x50
	private SpawnPointDifficulty _spawnPointDifficultyOriginal; //Field offset: 0x54
	private SpawnPointHeight _spawnPointHeightOriginal; //Field offset: 0x58
	private GameObject _spawnedPickupVisuals; //Field offset: 0x5C
	private Collider _trigger; //Field offset: 0x60
	private TrackObject _trackObject; //Field offset: 0x64
	private List<TrackObject> _visualsTrackObjects; //Field offset: 0x68
	private Route <ContainingRoute>k__BackingField; //Field offset: 0x6C

	public event Action<PickupSpawnPoint> OnDeregistered
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public event Action<PickupSpawnPoint> OnPickupCollected
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public event Action<PickupSpawnPoint> OnPickupDespawned
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public event Action<PickupSpawnPoint, PickerData> OnPickupSpawned
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public event Action<PickupSpawnPoint> OnRegistered
	{
		 add { } //Length: 224
		 remove { } //Length: 111
	}

	public bool CanTriggerCollisionWithCharacter
	{
		 get { } //Length: 6
	}

	public Route ContainingRoute
	{
		 get { } //Length: 9
		private set { } //Length: 8
	}

	public PickupType ForceSpawnPickupType
	{
		 get { } //Length: 12
		internal set { } //Length: 14
	}

	private bool IsAvailableAsTrackObject
	{
		 get { } //Length: 6
	}

	private bool IsPositionAcceptableBeforeSpawn
	{
		 get { } //Length: 6
	}

	protected bool IsZAvailableToJetpackState
	{
		 get { } //Length: 156
	}

	protected bool IsZPositionToGameStartAcceptableBeforeSpawn
	{
		 get { } //Length: 298
	}

	public PickupData PickupData
	{
		 get { } //Length: 6
	}

	public GameObject SpawnedPickupIcon
	{
		 get { } //Length: 12
	}

	public SpawnPointDifficulty SpawnPointDifficulty
	{
		 get { } //Length: 6
	}

	public SpawnPointHeight SpawnPointHeight
	{
		 get { } //Length: 6
	}

	public SpawnPointMode SpawnPointMode
	{
		 get { } //Length: 9
		internal set { } //Length: 111
	}

	public SpawnPointState SpawnPointState
	{
		 get { } //Length: 6
		private set { } //Length: 8
	}

	public bool WillIgnoreZPositionBeforeSpawn
	{
		 get { } //Length: 6
		internal set { } //Length: 8
	}

	public PickupSpawnPoint() { }

	public void add_OnDeregistered(Action<PickupSpawnPoint> value) { }

	public void add_OnPickupCollected(Action<PickupSpawnPoint> value) { }

	public void add_OnPickupDespawned(Action<PickupSpawnPoint> value) { }

	public void add_OnPickupSpawned(Action<PickupSpawnPoint, PickerData> value) { }

	public void add_OnRegistered(Action<PickupSpawnPoint> value) { }

	protected void Awake() { }

	private void DeactivateAndDespawnChild() { }

	private void DeactivateChild() { }

	private void DebugLog(string message) { }

	public void Deregister() { }

	private void DespawnChild() { }

	public bool get_CanTriggerCollisionWithCharacter() { }

	public Route get_ContainingRoute() { }

	public PickupType get_ForceSpawnPickupType() { }

	private bool get_IsAvailableAsTrackObject() { }

	private bool get_IsPositionAcceptableBeforeSpawn() { }

	protected bool get_IsZAvailableToJetpackState() { }

	protected bool get_IsZPositionToGameStartAcceptableBeforeSpawn() { }

	public PickupData get_PickupData() { }

	public GameObject get_SpawnedPickupIcon() { }

	public SpawnPointDifficulty get_SpawnPointDifficulty() { }

	public SpawnPointHeight get_SpawnPointHeight() { }

	public SpawnPointMode get_SpawnPointMode() { }

	public SpawnPointState get_SpawnPointState() { }

	public bool get_WillIgnoreZPositionBeforeSpawn() { }

	private void InitializeAllValues() { }

	public bool IsAvailableForSpawning(bool willShowDebugLog = false) { }

	private bool IsDistanceToCharacterAcceptableBeforeSpawn(bool willShowDebugLog = false) { }

	private bool IsStateAvailableForSpawning(bool willShowDebugLog = false) { }

	public void MarkAsUnavailable() { }

	public void Register() { }

	public void remove_OnDeregistered(Action<PickupSpawnPoint> value) { }

	public void remove_OnPickupCollected(Action<PickupSpawnPoint> value) { }

	public void remove_OnPickupDespawned(Action<PickupSpawnPoint> value) { }

	public void remove_OnPickupSpawned(Action<PickupSpawnPoint, PickerData> value) { }

	public void remove_OnRegistered(Action<PickupSpawnPoint> value) { }

	private void set_ContainingRoute(Route value) { }

	internal void set_ForceSpawnPickupType(PickupType value) { }

	internal void set_SpawnPointMode(SpawnPointMode value) { }

	private void set_SpawnPointState(SpawnPointState value) { }

	internal void set_WillIgnoreZPositionBeforeSpawn(bool value) { }

	public void SetContainingRoute() { }

	private void SetForceSpawnPickupTypeAndOriginalTo(PickupType pickupType, bool ignoreJetpackZ) { }

	public void SetSpawnPointForced(PickupType pickupType, SpawnPointDifficulty spawnPointDifficulty, bool willOffsetYPosition, bool willIgnoreZPositionBeforeSpawn, bool willIgnoreJetpackZ) { }

	private void SetSpawnPointModeAndOriginalTo(SpawnPointMode spawnPointMode) { }

	private void SetWillIgnoreZPositionBeforeSpawnAndOriginalTo(bool willIgnoreZPositionBeforeSpawn) { }

	private void SpawnExistingPlaceholders() { }

	public void SpawnPickup(PickupData pickupData, PickerData pickerData) { }

	private void TrackObject_OnActivate() { }

	private void TrackObject_OnDeactivate() { }

	public void TriggerCollisionWithCharacter(CharacterPickupParticles characterPickupParticles) { }

	private void Update() { }

}

