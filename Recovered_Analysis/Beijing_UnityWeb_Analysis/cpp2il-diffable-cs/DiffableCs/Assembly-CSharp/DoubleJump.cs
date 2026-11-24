//Type is in global namespace

public class DoubleJump : CharacterModifier
{
	private sealed class <Begin>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public DoubleJump <>4__this; //Field offset: 0x10
		private float <duration>5__2; //Field offset: 0x14

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 327
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <Begin>d__8(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	public static bool doubleJumpEnabled; //Field offset: 0x0
	private static DoubleJump instance; //Field offset: 0x4
	public float ratio; //Field offset: 0x20
	public AudioClipInfo powerDownSound; //Field offset: 0x24
	private Character character; //Field offset: 0x28

	public static DoubleJump Instance
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

	private static DoubleJump() { }

	public DoubleJump() { }

	private void Awake() { }

	public override IEnumerator Begin() { }

	public override void ExpireSoon() { }

	public static DoubleJump get_Instance() { }

	public override bool get_ShouldPauseInAlternateRoutes() { }

	public override bool get_ShouldPauseInJetpack() { }

	public override void Pause() { }

	public override void Reset() { }

	public override void Resume() { }

	public void StartDoubleJump() { }

	public void StopDoubleJump() { }

}

