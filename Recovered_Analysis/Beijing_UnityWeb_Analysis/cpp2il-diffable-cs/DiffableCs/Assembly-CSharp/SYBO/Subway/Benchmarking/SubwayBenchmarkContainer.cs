namespace SYBO.Subway.Benchmarking;

public static class SubwayBenchmarkContainer
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Converter<BenchmarkWrapper, string> <>9__6_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal string <get_BenchmarkNames>b__6_0(BenchmarkWrapper bw) { }

	}

	private sealed class <>c__DisplayClass9_0
	{
		public string value; //Field offset: 0x8

		public <>c__DisplayClass9_0() { }

		internal bool <set_SelectedBenchmarkName>b__0(BenchmarkWrapper bw) { }

	}

	private class BenchmarkWrapper
	{
		public string BenchmarkName; //Field offset: 0x8
		public SubwayBenchmark Benchmark; //Field offset: 0xC
		public string ProcessorSheetNamePostfix; //Field offset: 0x10

		public BenchmarkWrapper() { }

	}

	private static readonly List<BenchmarkWrapper> Benchmarks; //Field offset: 0x0
	private static int <SelectedBenchmarkIndex>k__BackingField; //Field offset: 0x4

	public static List<string> BenchmarkNames
	{
		 get { } //Length: 89
	}

	public static string SelectedBencharmProcessorPostfix
	{
		 get { } //Length: 110
	}

	public static SubwayBenchmark SelectedBenchmark
	{
		 get { } //Length: 110
	}

	public static int SelectedBenchmarkIndex
	{
		 get { } //Length: 315
		private set { } //Length: 257
	}

	public static string SelectedBenchmarkName
	{
		 get { } //Length: 298
		 set { } //Length: 91
	}

	private static SubwayBenchmarkContainer() { }

	public static List<string> get_BenchmarkNames() { }

	public static string get_SelectedBencharmProcessorPostfix() { }

	public static SubwayBenchmark get_SelectedBenchmark() { }

	public static int get_SelectedBenchmarkIndex() { }

	public static string get_SelectedBenchmarkName() { }

	private static void set_SelectedBenchmarkIndex(int value) { }

	public static void set_SelectedBenchmarkName(string value) { }

}

