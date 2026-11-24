namespace SYBO.Subway.Visuals;

public class HuntTokenCollectVFXColorCycle : HuntTokenCollectVFX
{
	private sealed class <PlayEffect>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public HuntTokenCollectVFXColorCycle <>4__this; //Field offset: 0x10

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 143
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <PlayEffect>d__6(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	public class ColorEntry
	{
		private Color _minColor; //Field offset: 0x8
		private Color _maxColor; //Field offset: 0x18

		public MinMaxGradient Gradient
		{
			 get { } //Length: 8
		}

		public ColorEntry() { }

		public MinMaxGradient get_Gradient() { }

	}

	private Random _randomGen; //Field offset: 0x10
	private MainModule _mainParticleModule; //Field offset: 0x14
	private List<ColorEntry> _colorEntries; //Field offset: 0x18
	private int _randomSeed; //Field offset: 0x1C

	public HuntTokenCollectVFXColorCycle() { }

	private MinMaxGradient PickRandomColorGradient() { }

	public override IEnumerator PlayEffect() { }

	public override void Setup() { }

}

