namespace SYBO.Subway.Placeholders;

public class SelectionPlaceholderLifecycle : PlaceholderLifecycle
{
	protected bool _spawnOnceOnStart; //Field offset: 0x18
	private float _spawnProbability; //Field offset: 0x1C
	private bool _locatedInIntro; //Field offset: 0x20
	private bool _dontSpawnInIntro; //Field offset: 0x21
	private Selector _selector; //Field offset: 0x24
	private TrackObject _trackObject; //Field offset: 0x28

	public bool SpawnOnceOnStart
	{
		 get { } //Length: 6
	}

	public float SpawnProbability
	{
		 get { } //Length: 17
	}

	public SelectionPlaceholderLifecycle() { }

	public bool get_SpawnOnceOnStart() { }

	public float get_SpawnProbability() { }

	protected virtual void GetSpawnedObjects(List<Selector> selectors) { }

	protected override void Initialize() { }

	private void OnDestroy() { }

	private void Selector_OnPerformingSelection(List<Selector> selectors) { }

	private void SpawnInstances(bool spawnInChildrenLifecycles = false, bool spawningOnStart = false, bool locatedInIntro = false) { }

	protected virtual void SpawnInstances(PlaceholderPrefabProviderBase prefabProvider, bool spawnInChildrenLifecycles = false, bool spawningOnStart = false, bool locatedInIntro = false) { }

	protected void Start() { }

	protected virtual void TrackObject_OnActivate() { }

	protected virtual void TrackObject_OnDeactivate() { }

}

