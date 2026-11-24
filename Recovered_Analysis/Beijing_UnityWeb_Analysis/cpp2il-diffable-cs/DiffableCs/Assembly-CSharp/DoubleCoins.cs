//Type is in global namespace

public class DoubleCoins : CharacterModifier
{
	private sealed class <Begin>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public DoubleCoins <>4__this; //Field offset: 0x10
		private float <duration>5__2; //Field offset: 0x14

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 385
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <Begin>d__6(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	public static bool HasDoubleCoinsModifier; //Field offset: 0x0
	public static int numberOfAnimationBlinks; //Field offset: 0x4
	private static DoubleCoins instance; //Field offset: 0x8
	public float ratio; //Field offset: 0x20
	public AudioClipInfo powerDownSound; //Field offset: 0x24

	public static DoubleCoins Instance
	{
		 get { } //Length: 1004
	}

	private static DoubleCoins() { }

	public DoubleCoins() { }

	public void Awake() { }

	public override IEnumerator Begin() { }

	public override void ExpireSoon() { }

	public static DoubleCoins get_Instance() { }

	public override void Reset() { }

	public void StartDoubleCoins() { }

	public void StopDoubleCoins() { }

}

