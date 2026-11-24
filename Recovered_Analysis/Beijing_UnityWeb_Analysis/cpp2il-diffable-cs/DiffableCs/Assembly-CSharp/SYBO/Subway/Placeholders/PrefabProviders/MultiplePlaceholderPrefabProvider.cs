namespace SYBO.Subway.Placeholders.PrefabProviders;

public class MultiplePlaceholderPrefabProvider : PlaceholderPrefabProviderBase
{
	public class GenericSpawnInfo
	{
		public GameObject Target; //Field offset: 0x8
		internal float Weight; //Field offset: 0xC
		internal PerformanceLevel MinDevicePerformance; //Field offset: 0x10

		public GenericSpawnInfo() { }

	}

	private static Dictionary<GameObject, GameObject> _nonRepeatableToLastPrefabDict; //Field offset: 0x0
	private bool _spawnWeighted; //Field offset: 0x18
	private bool _spawnAll; //Field offset: 0x19
	protected List<GenericSpawnInfo> _prefabList; //Field offset: 0x1C
	private float _weightSum; //Field offset: 0x20
	private GameObject _lastSelectedObject; //Field offset: 0x24
	private List<GameObject> _nonRepeatablePrefabs; //Field offset: 0x28
	protected List<GenericSpawnInfo> _prefabPickingList; //Field offset: 0x2C

	internal override int PrefabCount
	{
		 get { } //Length: 52
	}

	public ReadOnlyCollection<GenericSpawnInfo> PrefabList
	{
		 get { } //Length: 9
	}

	private static MultiplePlaceholderPrefabProvider() { }

	public MultiplePlaceholderPrefabProvider() { }

	protected virtual bool CanPickPrefab(GameObject prefab) { }

	internal override void Evaluate() { }

	internal override int get_PrefabCount() { }

	public ReadOnlyCollection<GenericSpawnInfo> get_PrefabList() { }

	internal override Transform GetPrefab(int prefabIndex) { }

	protected override void Initialize() { }

	private bool IsNonRepeatableSpawned(GameObject nonRepeatablePrefab) { }

	protected virtual bool NeedRecomputePickingList() { }

	protected virtual void RecomputePickingList() { }

	private void RecomputeWeightAndPickingList() { }

	private void RecomupteWeights() { }

	protected virtual GameObject SelectPrefab() { }

}

