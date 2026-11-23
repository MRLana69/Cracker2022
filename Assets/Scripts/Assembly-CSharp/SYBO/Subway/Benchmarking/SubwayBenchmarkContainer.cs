using System;
using System.Collections.Generic;

namespace SYBO.Subway.Benchmarking;

public static class SubwayBenchmarkContainer
{
	private class BenchmarkWrapper
	{
		public string BenchmarkName;

		public SubwayBenchmark Benchmark;

		public string ProcessorSheetNamePostfix;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<BenchmarkWrapper, string> _003C_003E9__7_0;

		static _003C_003Ec()
		{
			_003C_003Ec obj = default;
			_003C_003E9 = obj;
		}

		internal string _003Cget_BenchmarkNames_003Eb__7_0(BenchmarkWrapper bw)
		{
			return bw.BenchmarkName;
		}
	}

	private static readonly List<BenchmarkWrapper> Benchmarks;

	private static int SelectedBenchmarkIndex__BackingField;

	public static int SelectedBenchmarkIndex
	{
		get
		{
			return SelectedBenchmarkIndex__BackingField;
		}
		private set
		{
			SelectedBenchmarkIndex__BackingField = value;
		}
	}

	public static List<string> BenchmarkNames
	{
		get
		{
			bool flag = _003C_003Ec._003C_003E9__7_0 == null;
			bool flag2 = !flag;
			Converter<BenchmarkWrapper, string> converter = _003C_003Ec._003C_003E9__7_0;
			if (!flag2)
			{
				throw new ArgumentException();
			}
			return Benchmarks.ConvertAll(converter);
		}
	}

	public static string SelectedBenchmarkName
	{
		get
		{
			BenchmarkWrapper benchmarkWrapper = Benchmarks.get_Item(SelectedBenchmarkIndex__BackingField);
			return benchmarkWrapper.BenchmarkName;
		}
		set
		{
			List<BenchmarkWrapper> benchmarks = Benchmarks;
			throw new ArgumentException();
		}
	}

	public static SubwayBenchmark SelectedBenchmark
	{
		get
		{
			BenchmarkWrapper benchmarkWrapper = Benchmarks.get_Item(SelectedBenchmarkIndex__BackingField);
			return benchmarkWrapper.Benchmark;
		}
	}

	public static string SelectedBencharmProcessorPostfix
	{
		get
		{
			BenchmarkWrapper benchmarkWrapper = Benchmarks.get_Item(SelectedBenchmarkIndex__BackingField);
			return benchmarkWrapper.ProcessorSheetNamePostfix;
		}
	}

	static SubwayBenchmarkContainer()
	{
		List<BenchmarkWrapper> list = default;
		list._002Ector();
		BenchmarkWrapper benchmarkWrapper = default;
		benchmarkWrapper.BenchmarkName = "Perf. Standard";
		SubwayRunningBenchmark subwayRunningBenchmark = default;
		subwayRunningBenchmark._002Ector();
		benchmarkWrapper.Benchmark = subwayRunningBenchmark;
		benchmarkWrapper.ProcessorSheetNamePostfix = "perf";
		list.Add(benchmarkWrapper);
		BenchmarkWrapper benchmarkWrapper2 = default;
		benchmarkWrapper2.BenchmarkName = "Perf. Long";
		SubwayRunningBenchmark subwayRunningBenchmark2 = default;
		subwayRunningBenchmark2._002Ector(7200f, 6f);
		benchmarkWrapper2.Benchmark = subwayRunningBenchmark2;
		benchmarkWrapper2.ProcessorSheetNamePostfix = "perf_long";
		list.Add(benchmarkWrapper2);
		BenchmarkWrapper benchmarkWrapper3 = default;
		benchmarkWrapper3.BenchmarkName = "Memory Standard";
		SubwayMemoryBenchmark subwayMemoryBenchmark = default;
		subwayMemoryBenchmark._002Ector(forceAllCharacters: false, forceAllBoards: false);
		benchmarkWrapper3.Benchmark = subwayMemoryBenchmark;
		benchmarkWrapper3.ProcessorSheetNamePostfix = "memory";
		list.Add(benchmarkWrapper3);
		BenchmarkWrapper benchmarkWrapper4 = default;
		benchmarkWrapper4.BenchmarkName = "Memory All Chars";
		SubwayMemoryBenchmark subwayMemoryBenchmark2 = default;
		subwayMemoryBenchmark2._002Ector(forceAllCharacters: true, forceAllBoards: true);
		benchmarkWrapper4.Benchmark = subwayMemoryBenchmark2;
		benchmarkWrapper4.ProcessorSheetNamePostfix = "memory_all";
		list.Add(benchmarkWrapper4);
		Benchmarks = list;
	}
}
