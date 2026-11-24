namespace SYBO.Subway.Level;

public class EnvironmentBackground : MonoBehaviour
{
	private sealed class <Start>d__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public EnvironmentBackground <>4__this; //Field offset: 0x10

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 391
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <Start>d__11(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private List<BackgroundLayer> _backgroundLayers; //Field offset: 0xC
	private List<BackgroundCulling> _backgroundCulling; //Field offset: 0x10
	private Material _cullingMaterial; //Field offset: 0x14
	private Transform _characterCameraTransform; //Field offset: 0x18
	private Transform _transform; //Field offset: 0x1C
	private ThemeManager _themeManager; //Field offset: 0x20
	private Theme _theme; //Field offset: 0x24
	private WaitForSeconds _waitForOneSecond; //Field offset: 0x28
	private float _layerSpacing; //Field offset: 0x2C
	private EnvironmentType _lastSpawnedEnvironmentType; //Field offset: 0x30

	public EnvironmentBackground() { }

	private void Awake() { }

	private void ClearData(BackgroundLayer layer) { }

	private void ExecuteOnEachBackgroundLayer(Action<BackgroundLayer> actionToExecute) { }

	private void Game_OnMenuScreenShown() { }

	private float GetMaxBoundsSizeX(IEnumerable<MeshRenderer> meshRenderers) { }

	private float GetZ(int layerIndex) { }

	private BackgroundObject InitializeBackgroundObject(BackgroundObject bgObject, BackgroundLayer layer) { }

	private void LateUpdate() { }

	private void OnDestroy() { }

	private void PlaceMovingSingleObjects(List<BackgroundObject> singleObjects, BackgroundLayer layer) { }

	private void PlaceSkylineFillObjects(BackgroundLayer layer) { }

	private void PrepareLayer(BackgroundLayer layer) { }

	private void ResetBackground(Theme theme) { }

	private void RouteChunk_OnEnvironmentSegmentSpawned(EnvironmentKind kind, int gamePositionZ, Route route) { }

	private void SetObjectVisibility(BackgroundObject bo, bool visibility) { }

	private IEnumerator Start() { }

	private void ThemeManager_ThemeChanged(Theme theme) { }

	private void UpdateLayer(BackgroundLayer layer) { }

	private int UpdateMovingSingleObjects(List<BackgroundObject> singleObjects, BackgroundLayer layer, int spawnElementIndex) { }

	private void UpdateSkylineFillMovement(List<BackgroundObject> bgObjects, BackgroundLayer layer) { }

}

