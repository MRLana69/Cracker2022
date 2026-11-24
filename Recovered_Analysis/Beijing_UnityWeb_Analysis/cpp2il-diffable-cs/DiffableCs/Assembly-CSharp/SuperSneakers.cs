//Type is in global namespace

public class SuperSneakers : CharacterModifier
{
	private sealed class <Begin>d__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public SuperSneakers <>4__this; //Field offset: 0x10

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 514
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <Begin>d__23(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	public delegate OnSwitchToSuperSneakersDelegate
	{

		public OnSwitchToSuperSneakersDelegate(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke() { }

	}

	public delegate SuperSneakerOnStopDelegate
	{

		public SuperSneakerOnStopDelegate(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke() { }

	}

	public static Action OnSupersneakersTimeActiveChange; //Field offset: 0x0
	private static SuperSneakers instance; //Field offset: 0x4
	public bool isActive; //Field offset: 0x20
	private Character character; //Field offset: 0x24
	private CharacterRendering characterRendering; //Field offset: 0x28
	public AudioClipInfo powerDownSound; //Field offset: 0x2C
	private LongMagnet longMagnet; //Field offset: 0x30
	public float timeActiveInARow; //Field offset: 0x34
	private OnSwitchToSuperSneakersDelegate OnSwitchToSuperSneakers; //Field offset: 0x38
	private SuperSneakerOnStopDelegate SuperSneakerOnStop; //Field offset: 0x3C

	public event OnSwitchToSuperSneakersDelegate OnSwitchToSuperSneakers
	{
		 add { } //Length: 238
		 remove { } //Length: 111
	}

	public event SuperSneakerOnStopDelegate SuperSneakerOnStop
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public static SuperSneakers Instance
	{
		 get { } //Length: 309
	}

	public override bool ShouldPauseInAlternateRoutes
	{
		 get { } //Length: 66
	}

	public override bool ShouldPauseInJetpack
	{
		 get { } //Length: 66
	}

	private static SuperSneakers() { }

	public SuperSneakers() { }

	public void add_OnSwitchToSuperSneakers(OnSwitchToSuperSneakersDelegate value) { }

	public void add_SuperSneakerOnStop(SuperSneakerOnStopDelegate value) { }

	public void Awake() { }

	public override IEnumerator Begin() { }

	public override void ExpireSoon() { }

	public static SuperSneakers get_Instance() { }

	public override bool get_ShouldPauseInAlternateRoutes() { }

	public override bool get_ShouldPauseInJetpack() { }

	public override void Pause() { }

	public override void Prepare() { }

	public void remove_OnSwitchToSuperSneakers(OnSwitchToSuperSneakersDelegate value) { }

	public void remove_SuperSneakerOnStop(SuperSneakerOnStopDelegate value) { }

	public override void Resume() { }

	public void StopHack() { }

}

