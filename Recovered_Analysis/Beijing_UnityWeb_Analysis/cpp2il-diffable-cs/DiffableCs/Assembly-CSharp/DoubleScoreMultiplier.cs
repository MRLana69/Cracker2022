//Type is in global namespace

public class DoubleScoreMultiplier : CharacterModifier
{
	private sealed class <Begin>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public DoubleScoreMultiplier <>4__this; //Field offset: 0x10
		private float <duration>5__2; //Field offset: 0x14

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 321
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

	private static bool _doubleScoreActive; //Field offset: 0x0
	public float ratio; //Field offset: 0x20
	public AudioClipInfo powerDownSound; //Field offset: 0x24

	public static bool doubleScoreActive
	{
		 get { } //Length: 306
		private set { } //Length: 19
	}

	public DoubleScoreMultiplier() { }

	public override IEnumerator Begin() { }

	public static bool get_doubleScoreActive() { }

	public override void Reset() { }

	private static void set_doubleScoreActive(bool value) { }

}

