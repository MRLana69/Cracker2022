//Type is in global namespace

public class PlusMultiplier : CharacterModifier
{
	private sealed class <Begin>d__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public PlusMultiplier <>4__this; //Field offset: 0x10
		private float <duration>5__2; //Field offset: 0x14

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 327
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <Begin>d__5(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	public static bool plusMultiplierEnabled; //Field offset: 0x0
	private static PlusMultiplier instance; //Field offset: 0x4
	public float ratio; //Field offset: 0x20
	public AudioClipInfo powerDownSound; //Field offset: 0x24

	public static PlusMultiplier Instance
	{
		 get { } //Length: 309
	}

	private static PlusMultiplier() { }

	public PlusMultiplier() { }

	private void Awake() { }

	public override IEnumerator Begin() { }

	private void ChangeTheMultiplier() { }

	public override void ExpireSoon() { }

	public static PlusMultiplier get_Instance() { }

	public override void Reset() { }

	private void ResetLabelColour() { }

	public void StartPlusMultiplier() { }

	public void StopPlusMultiplier() { }

}

