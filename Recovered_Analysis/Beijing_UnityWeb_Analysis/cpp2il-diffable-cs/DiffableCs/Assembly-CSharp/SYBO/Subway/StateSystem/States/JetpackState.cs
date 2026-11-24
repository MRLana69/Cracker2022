namespace SYBO.Subway.StateSystem.States;

public class JetpackState : FlyingState
{
	private sealed class <SpawnCoinCurve>d__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public float startZ; //Field offset: 0x10
		public float height; //Field offset: 0x14
		public AnimationCurve curve; //Field offset: 0x18
		public JetpackState <>4__this; //Field offset: 0x1C
		public float endZ; //Field offset: 0x20
		private CoinManager <coinManager>5__2; //Field offset: 0x24
		private float <z>5__3; //Field offset: 0x28

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 482
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <SpawnCoinCurve>d__10(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private const float CoinStayInTrackDistance = 60; //Field offset: 0x0
	private const float CoinSpacingInZ = 30; //Field offset: 0x0
	private JetpackStateSettings _settings; //Field offset: 0x78
	private List<Coin> _dynamicSpawnedCoins; //Field offset: 0x7C

	protected override UpgradeType UpgradeType
	{
		 get { } //Length: 7
	}

	public JetpackState(int id) { }

	private void DespawnCoins() { }

	public override void Enter(State fromState) { }

	protected override UpgradeType get_UpgradeType() { }

	protected override float GetFlyingSpeed() { }

	public override void Leave(State toState) { }

	private IEnumerator SpawnCoinCurve(AnimationCurve curve, float startZ, float endZ, float height) { }

	private void SpawnCoins(float startZ, float endZ, float height) { }

}

