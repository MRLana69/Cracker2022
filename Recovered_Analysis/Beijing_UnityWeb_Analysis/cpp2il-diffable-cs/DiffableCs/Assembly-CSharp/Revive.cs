//Type is in global namespace

public class Revive : MonoBehaviour
{
	private sealed class <ReviveNow>d__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public Revive <>4__this; //Field offset: 0x10
		public bool revivedWithAds; //Field offset: 0x14
		public bool adsWasAvailable; //Field offset: 0x15
		public bool adsFailed; //Field offset: 0x16
		private float <timeLeft>5__2; //Field offset: 0x18
		private float <timeLeftFX>5__3; //Field offset: 0x1C

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 567
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <ReviveNow>d__19(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	public delegate OnReviveDelegate
	{

		public OnReviveDelegate(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke() { }

	}

	public delegate OnSwitchToRunningDelegate
	{

		public OnSwitchToRunningDelegate(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke() { }

	}

	private static Revive instance; //Field offset: 0x0
	private Game game; //Field offset: 0xC
	private Character character; //Field offset: 0x10
	public float WaitForParticlesDelay; //Field offset: 0x14
	public float RemoveObstaclesDistance; //Field offset: 0x18
	private OnSwitchToRunningDelegate OnSwitchToRunning; //Field offset: 0x1C
	private OnReviveDelegate OnRevive; //Field offset: 0x20
	private MainCamera _mainCamera; //Field offset: 0x24
	private ParticleSystem _reviveParticles; //Field offset: 0x28
	private ReviveFX _reviveFX; //Field offset: 0x2C
	private AnimationClip ReviveAnimationClip; //Field offset: 0x30

	public event OnReviveDelegate OnRevive
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public event OnSwitchToRunningDelegate OnSwitchToRunning
	{
		 add { } //Length: 2
		 remove { } //Length: 111
	}

	public static Revive Instance
	{
		 get { } //Length: 121
	}

	private static Revive() { }

	public Revive() { }

	public void add_OnRevive(OnReviveDelegate value) { }

	public void add_OnSwitchToRunning(OnSwitchToRunningDelegate value) { }

	public static Revive get_Instance() { }

	public void remove_OnRevive(OnReviveDelegate value) { }

	public void remove_OnSwitchToRunning(OnSwitchToRunningDelegate value) { }

	private IEnumerator ReviveNow(bool revivedWithAds, bool adsWasAvailable, bool adsFailed) { }

	public void SendRevive(bool revivedWithAds, bool adsWasAvailable, bool adsFailed) { }

	public void SendSkipRevive() { }

	private void Start() { }

}

