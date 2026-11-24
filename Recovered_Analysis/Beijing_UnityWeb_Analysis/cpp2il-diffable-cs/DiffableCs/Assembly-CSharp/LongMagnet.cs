//Type is in global namespace

public class LongMagnet : MonoBehaviour
{
	private sealed class <>c__DisplayClass9_0
	{
		public PickupSpawnPoint pickupSpawnPoint; //Field offset: 0x8
		public Vector3 position; //Field offset: 0xC
		public LongMagnet <>4__this; //Field offset: 0x18

		public <>c__DisplayClass9_0() { }

		internal void <PullPickupSpawnPoint>b__0(float t) { }

	}

	private sealed class <PullPickupSpawnPoint>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public PickupSpawnPoint pickupSpawnPoint; //Field offset: 0x10
		public LongMagnet <>4__this; //Field offset: 0x14
		private <>c__DisplayClass9_0 <>8__1; //Field offset: 0x18

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 659
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <PullPickupSpawnPoint>d__9(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private Game game; //Field offset: 0xC
	private CharacterController characterController; //Field offset: 0x10
	private CharacterRendering characterRendering; //Field offset: 0x14
	private Character character; //Field offset: 0x18
	private CollisionNotifier coinMagnetCollider; //Field offset: 0x1C
	public float pullSpeed; //Field offset: 0x20
	private VariableBool longMagnetSuction; //Field offset: 0x24

	public VariableBool LongMagnetSuction
	{
		 get { } //Length: 152
	}

	public bool ShouldBeActive
	{
		 get { } //Length: 3
	}

	public LongMagnet() { }

	private void <Start>b__7_0(bool value) { }

	private void <Start>b__7_1(bool value) { }

	public void Activate() { }

	public void CoinHit(Collider collider) { }

	public void Deactivate() { }

	public VariableBool get_LongMagnetSuction() { }

	public bool get_ShouldBeActive() { }

	private IEnumerator PullPickupSpawnPoint(PickupSpawnPoint pickupSpawnPoint) { }

	public void Start() { }

}

