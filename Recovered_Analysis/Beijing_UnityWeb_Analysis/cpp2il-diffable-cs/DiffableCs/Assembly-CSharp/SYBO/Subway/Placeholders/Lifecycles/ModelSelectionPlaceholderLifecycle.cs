namespace SYBO.Subway.Placeholders.Lifecycles;

public class ModelSelectionPlaceholderLifecycle : SelectionPlaceholderLifecycle
{
	private sealed class <CombineMeshesAsync>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public ModelSelectionPlaceholderLifecycle <>4__this; //Field offset: 0x10
		public IList<CombineableMesh> combineableMeshes; //Field offset: 0x14

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 205
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <CombineMeshesAsync>d__12(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private bool _combineModelsInstantly; //Field offset: 0x2C
	private MeshContainer _meshContainer; //Field offset: 0x30
	private MeshFilter _meshFilter; //Field offset: 0x34
	private MeshRenderer _meshRenderer; //Field offset: 0x38
	private bool _usingCombinedMesh; //Field offset: 0x3C
	private CombineableMeshGroup _spawnedCombineableMeshGroup; //Field offset: 0x40
	private bool _isCombiningMeshes; //Field offset: 0x44
	private IEnumerator _meshCombiningRoutine; //Field offset: 0x48
	private bool _spawnedOnceOnStart; //Field offset: 0x4C

	public ModelSelectionPlaceholderLifecycle() { }

	private void CombineMeshes(IList<CombineableMesh> combineableMeshes) { }

	private IEnumerator CombineMeshesAsync(IList<CombineableMesh> combineableMeshes) { }

	protected override void DespawnInstances() { }

	protected override void GetSpawnedObjects(List<Selector> selectors) { }

	protected override void Initialize() { }

	private void OnValidate() { }

	private void ReceiveCombinedMeshAndDespawn(ModelInfo combinedMeshes) { }

	protected override void SpawnInstances(PlaceholderPrefabProviderBase prefabProvider, bool spawnInChildrenLifecycles = false, bool spawningOnceOnStart = false, bool locatedInIntro = false) { }

	private void UpdateToCombinedMesh(ModelInfo combinedMeshes) { }

}

