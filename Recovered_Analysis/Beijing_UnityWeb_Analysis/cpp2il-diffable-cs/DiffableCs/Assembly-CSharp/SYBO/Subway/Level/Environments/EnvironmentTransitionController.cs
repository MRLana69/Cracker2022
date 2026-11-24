namespace SYBO.Subway.Level.Environments;

public class EnvironmentTransitionController
{
	private EnvironmentKind _lastEnvironmentKind; //Field offset: 0x10
	private Queue<Transform> _spawnedTransitions; //Field offset: 0x14

	public EnvironmentTransitionController() { }

	private void DespawnFirstInstance() { }

	private void Game_OnGameEnded() { }

	private void LateUpdate() { }

	protected override void OnDestroy() { }

	private void RouteChunk_OnEnvironmentSegmentSpawned(EnvironmentKind environmentKind, int gamePositionZ, Route route) { }

	private void Spawn(Transform prefab, int gamePositionZ) { }

	protected override void SubclassInitialize() { }

}

