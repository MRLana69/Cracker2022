namespace Kiloo.Common.Performance;

public static class AndroidGPUCategorizer
{
	public delegate UknownGPUHandler
	{

		public UknownGPUHandler(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(string gpuName, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(string gpuName) { }

	}

	private const string GPU_SCORES_PATH = "Kiloo/Performance/AndroidGPUScores"; //Field offset: 0x0
	private static int <gpuScore>k__BackingField; //Field offset: 0x0
	private static GPUCategory <gpuCategory>k__BackingField; //Field offset: 0x4
	private static UknownGPUHandler _unknownGPUHandler; //Field offset: 0x8
	private static Dictionary<string, int> _gpuScores; //Field offset: 0xC
	private static bool _isInitialized; //Field offset: 0x10

	private static event UknownGPUHandler _unknownGPUHandler
	{
		 add { } //Length: 91
		 remove { } //Length: 209
	}

	public static GPUCategory gpuCategory
	{
		 get { } //Length: 89
		private set { } //Length: 91
	}

	public static string gpuInfo
	{
		 get { } //Length: 89
	}

	public static int gpuScore
	{
		 get { } //Length: 281
		private set { } //Length: 9
	}

	private static AndroidGPUCategorizer() { }

	private static void add__unknownGPUHandler(UknownGPUHandler value) { }

	public static void CalculateGpuCaterogy(CategoryThresholds thresholds) { }

	public static GPUCategory get_gpuCategory() { }

	public static string get_gpuInfo() { }

	public static int get_gpuScore() { }

	private static GPUCategory GetCategory(Dictionary<string, int> gpuToScore, CategoryThresholds thresholds, UknownGPUHandler unknownGPUHandler) { }

	private static GPUCategory GetCategoryFromScore(int score, CategoryThresholds thresholds) { }

	private static string GetTrimmedGPUName() { }

	public static void Initialize(CategoryThresholds thresholds, UknownGPUHandler unknownGPUHandler = null) { }

	public static bool IsSupportedOnPlatform() { }

	private static Dictionary<string, int> LoadGPUScores() { }

	private static void remove__unknownGPUHandler(UknownGPUHandler value) { }

	private static void set_gpuCategory(GPUCategory value) { }

	private static void set_gpuScore(int value) { }

}

