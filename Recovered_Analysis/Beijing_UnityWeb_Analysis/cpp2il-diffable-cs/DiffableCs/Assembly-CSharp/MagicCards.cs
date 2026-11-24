//Type is in global namespace

public class MagicCards : CharacterCustomizationProp
{
	private sealed class <Play>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public MagicCards <>4__this; //Field offset: 0x10

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 503
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <Play>d__7(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private Renderer _card1; //Field offset: 0xC
	private Renderer _card2; //Field offset: 0x10
	private Renderer _card3; //Field offset: 0x14
	private Renderer _card4; //Field offset: 0x18
	private CharacterRig _characterRig; //Field offset: 0x1C
	private string _requiredAnimationName; //Field offset: 0x20

	public MagicCards() { }

	public override void Initialize(CharacterRig characterRig, bool alternateSetup) { }

	private IEnumerator Play() { }

}

