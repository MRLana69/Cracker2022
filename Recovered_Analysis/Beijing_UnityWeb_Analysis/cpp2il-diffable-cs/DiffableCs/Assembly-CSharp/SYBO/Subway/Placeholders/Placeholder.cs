namespace SYBO.Subway.Placeholders;

public class Placeholder : MonoBehaviour
{
	protected Transform _transform; //Field offset: 0xC
	private bool _initialized; //Field offset: 0x10
	private List<TrackObject> _childTrackObjects; //Field offset: 0x14
	private IPlaceholderInitializer[] _initializers; //Field offset: 0x18

	public bool HasSpawnedInstances
	{
		 get { } //Length: 9
	}

	public Placeholder() { }

	internal void Activate() { }

	internal void Deactivate() { }

	internal void DespawnInstances() { }

	public bool get_HasSpawnedInstances() { }

	public void GetSpawnedObjects(List<Selector> selectors) { }

	protected void GetTrackObjects(Transform t, bool addRootTrackObject = true) { }

	protected void GetTrackObjects_Cached(Transform t) { }

	protected virtual void Initialize() { }

	protected void InitializeCheck() { }

	protected virtual Transform InitializeSpawnedInstance(Transform objectTransform, string newName) { }

	protected virtual void OnValidate() { }

	internal virtual GameObject SpawnInstance(Transform prefab) { }

	internal virtual void SpawnInstances(PlaceholderPrefabProviderBase prefabProvider) { }

}

