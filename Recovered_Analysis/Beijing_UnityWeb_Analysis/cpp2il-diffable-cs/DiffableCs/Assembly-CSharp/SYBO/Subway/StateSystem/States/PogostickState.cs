namespace SYBO.Subway.StateSystem.States;

public class PogostickState : InGameState
{
	private sealed class <RemovePickups>d__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public PogostickState <>4__this; //Field offset: 0x10
		public float endPosition; //Field offset: 0x14

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 342
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <RemovePickups>d__28(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private PogostickStateSettings _settings; //Field offset: 0x18
	private PickupType[] _pickupWeightedList; //Field offset: 0x1C
	private GameObject _pickupSpawnPointPrefabInstance; //Field offset: 0x20
	public Action OnStart; //Field offset: 0x24
	public Action OnHangtime; //Field offset: 0x28
	public Action OnStop; //Field offset: 0x2C
	private List<Action> _startHandlers; //Field offset: 0x30
	private Vector3 _startGamePosition; //Field offset: 0x34
	private float _endGamePositionZ; //Field offset: 0x40
	private bool _reachedHangtime; //Field offset: 0x44
	private SmoothDampFloat _smoothCameraX; //Field offset: 0x48
	private Vector3 _cameraPositionStart; //Field offset: 0x4C
	private Vector3 _cameraTargetStartOffset; //Field offset: 0x58

	public PogostickState(int id) { }

	private void EndPogo() { }

	public override void Enter(State fromState) { }

	public override void HandleSwipe(SwipeDir swipeDir) { }

	private void InitializeSpawnList() { }

	public override void Leave(State toState) { }

	private void NotifyHangtime() { }

	private void NotifyOnStart() { }

	private void NotifyOnStop() { }

	public override void OnUpdate() { }

	public void RegisterStartHandler(Action handler) { }

	private IEnumerator RemovePickups(float endPosition) { }

	private void SetActiveForPickupPrefabInstance(bool isActive) { }

	private void SpawnCoinRow(float z, float height) { }

	private void SpawnCoinRows() { }

	private void SpawnPickup(float endGamePositionZ) { }

}

