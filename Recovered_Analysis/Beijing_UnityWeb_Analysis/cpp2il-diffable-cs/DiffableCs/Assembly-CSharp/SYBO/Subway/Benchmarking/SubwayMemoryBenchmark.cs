namespace SYBO.Subway.Benchmarking;

public class SubwayMemoryBenchmark : SubwayBenchmark
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<FieldInfo, bool> <>9__14_0; //Field offset: 0x4
		public static Func<FieldInfo, bool> <>9__14_1; //Field offset: 0x8
		public static Func<FieldInfo, object> <>9__14_2; //Field offset: 0xC
		public static Func<string, bool> <>9__14_3; //Field offset: 0x10
		public static Func<string, bool> <>9__14_4; //Field offset: 0x14

		private static <>c() { }

		public <>c() { }

		internal bool <CachePopupsAndScreens>b__14_0(FieldInfo x) { }

		internal bool <CachePopupsAndScreens>b__14_1(FieldInfo x) { }

		internal object <CachePopupsAndScreens>b__14_2(FieldInfo x) { }

		internal bool <CachePopupsAndScreens>b__14_3(string x) { }

		internal bool <CachePopupsAndScreens>b__14_4(string x) { }

	}

	private const int CycleCount = 3; //Field offset: 0x0
	private const int UIRepeatCount = 10; //Field offset: 0x0
	private const float DurationSeconds = 180; //Field offset: 0x0
	private const float SampleInterval = 6; //Field offset: 0x0
	private static string[] _popups; //Field offset: 0x0
	private static string[] _screens; //Field offset: 0x4
	private bool _forceAllCharacters; //Field offset: 0x28
	private bool _forceAllBoards; //Field offset: 0x29

	public override string ConfirmationMessage
	{
		 get { } //Length: 3
	}

	public override bool RequiresConfirmation
	{
		 get { } //Length: 119
	}

	public SubwayMemoryBenchmark(bool forceAllCharacters, bool forceAllBoards) { }

	private static void CachePopupsAndScreens() { }

	private static IAutomationStep[] GenerateCompleteMemoryTestSteps(int totalRepeatCount, int uiRepeatCount) { }

	private static CompoundAutomationStep GenerateSingleUICompoundStep() { }

	private static IAutomationStep GenerateUICompoundSteps(int count) { }

	public override string get_ConfirmationMessage() { }

	public override bool get_RequiresConfirmation() { }

	public override void Initialize() { }

}

