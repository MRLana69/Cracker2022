namespace SYBO.Subway.Benchmarking;

public abstract class SubwayBenchmark : Benchmark
{
	private sealed class <ReturnToHomeScreen>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 160
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <ReturnToHomeScreen>d__7(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private int _originalScreenTimeout; //Field offset: 0x20
	protected int _initialSampleCount; //Field offset: 0x24

	protected override int InitialSampleCount
	{
		 get { } //Length: 12
	}

	public SubwayBenchmark(IAutomationStep[] steps, IBenchmarkMetric[] metrics, IMetricSampler[] samplers) { }

	protected override IBenchmarkProcessor CreateProcessor() { }

	protected override int get_InitialSampleCount() { }

	public override void Initialize() { }

	private IEnumerator ReturnToHomeScreen() { }

	public override void Terminate() { }

}

