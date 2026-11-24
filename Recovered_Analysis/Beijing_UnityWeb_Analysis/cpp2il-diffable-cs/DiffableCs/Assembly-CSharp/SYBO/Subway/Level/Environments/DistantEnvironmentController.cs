namespace SYBO.Subway.Level.Environments;

public class DistantEnvironmentController
{
	public class DistantObjectConfig
	{
		private string _name; //Field offset: 0x8
		private Transform[] _prefabs; //Field offset: 0xC
		private EnvironmentSide _environmentSide; //Field offset: 0x10
		private EnvironmentKind[] _environmentKind; //Field offset: 0x14
		private float _projectionSourceOffsetXMin; //Field offset: 0x18
		private float _projectionSourceOffsetXMax; //Field offset: 0x1C
		private float _minDistanceFirstSpawn; //Field offset: 0x20
		private float _minDistanceBetween; //Field offset: 0x24
		private float _spawnProbability; //Field offset: 0x28

		public EnvironmentKind[] EnvironmentKind
		{
			 get { } //Length: 6
		}

		public EnvironmentSide EnvironmentSide
		{
			 get { } //Length: 6
		}

		public float MinDistanceBetween
		{
			 get { } //Length: 6
		}

		public float MinDistanceFirstSpawn
		{
			 get { } //Length: 6
		}

		public string Name
		{
			 get { } //Length: 6
		}

		public Transform[] Prefabs
		{
			 get { } //Length: 6
		}

		public float ProjectionSourceOffsetXMax
		{
			 get { } //Length: 6
		}

		public float ProjectionSourceOffsetXMin
		{
			 get { } //Length: 6
		}

		public float SpawnProbability
		{
			 get { } //Length: 6
		}

		public DistantObjectConfig() { }

		public EnvironmentKind[] get_EnvironmentKind() { }

		public EnvironmentSide get_EnvironmentSide() { }

		public float get_MinDistanceBetween() { }

		public float get_MinDistanceFirstSpawn() { }

		public string get_Name() { }

		public Transform[] get_Prefabs() { }

		public float get_ProjectionSourceOffsetXMax() { }

		public float get_ProjectionSourceOffsetXMin() { }

		public float get_SpawnProbability() { }

		public Transform GetRandomPrefab() { }

	}

	public class DistantObjectGlobalConfig
	{
		private float _globalMinDistanceFirstSpawn; //Field offset: 0x8
		private float _globalMinDistanceBetween; //Field offset: 0xC

		public float GlobalMinDistanceBetween
		{
			 get { } //Length: 6
		}

		public float GlobalMinDistanceFirstSpawn
		{
			 get { } //Length: 9
		}

		public DistantObjectGlobalConfig() { }

		public float get_GlobalMinDistanceBetween() { }

		public float get_GlobalMinDistanceFirstSpawn() { }

	}

	private class DistantObjectSpawner
	{
		private List<Transform> _spawnedTransforms; //Field offset: 0x8
		private float _lastSpawnGamePositionZ; //Field offset: 0xC
		private DistantObjectConfig <Config>k__BackingField; //Field offset: 0x10

		public DistantObjectConfig Config
		{
			 get { } //Length: 32
			private set { } //Length: 18
		}

		public DistantObjectSpawner(DistantObjectConfig config) { }

		public bool CanSpawnAt(float gamePositionZ, EnvironmentKind environmentKind) { }

		private bool CanSpawnAtEnvironmentKind(EnvironmentKind environmentKind) { }

		public void CheckForDespawn(float cameraGamePositionZ) { }

		public DistantObjectConfig get_Config() { }

		public bool HasSpawned(Transform instance) { }

		public void Reset() { }

		private void set_Config(DistantObjectConfig value) { }

		public void Spawn(float spawnGamePositionZ, Vector3 cameraGamePosition, Transform parent) { }

	}

	public enum EnvironmentSide
	{
		Left = 0,
		Right = 1,
		Both = 2,
	}

	private const float SpawnDistance = 1260; //Field offset: 0x0
	private const float SpawnCheckDistance = 90; //Field offset: 0x0
	private const float DistantObjectDespawnDistance = -90; //Field offset: 0x0
	private const float MinimumXOffset = 250; //Field offset: 0x0
	private const float MaximumXOffset = 1500; //Field offset: 0x0
	private const float MaximumProjectedX = 500; //Field offset: 0x0
	private bool _distantEnvironmentActive; //Field offset: 0xF
	private DistantObjectGlobalConfig _distantObjectGlobalConfig; //Field offset: 0x10
	private DistantObjectSpawner[] _distantObjectSpawners; //Field offset: 0x14
	private float _lastCharacterGamePositionZ; //Field offset: 0x18
	private float _distanceSinceLastSpawnCheck; //Field offset: 0x1C
	private float _lastSpawnGamePositionZ; //Field offset: 0x20
	private List<DistantObject> _activeDistantObjects; //Field offset: 0x24
	private List<DistantObjectSpawner> _spawnableSpawners; //Field offset: 0x28

	public DistantEnvironmentController() { }

	public void DeregisterDistantObject(DistantObject obj) { }

	private void Game_OnMenuScreenShown() { }

	public int GetObjectSettingIndex(Transform instance) { }

	private void LateUpdate() { }

	public void RegisterDistantObject(DistantObject obj) { }

	private void Start() { }

	private void UpdateDistantEnvironment(float characterDeltaZ, Vector3 cameraGamePosition) { }

}

