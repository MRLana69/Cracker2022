namespace SYBO.Subway.Placeholders;

public class SpawnOnceOnStartPlaceholderLifecycle : PlaceholderLifecycle
{

	public SpawnOnceOnStartPlaceholderLifecycle() { }

	private void SpawnInstances(bool spawnInChildrenLifecycles = false) { }

	protected virtual void SpawnInstances(PlaceholderPrefabProviderBase prefabProvider, bool spawnInChildrenLifecycles = false) { }

	protected void Start() { }

}

