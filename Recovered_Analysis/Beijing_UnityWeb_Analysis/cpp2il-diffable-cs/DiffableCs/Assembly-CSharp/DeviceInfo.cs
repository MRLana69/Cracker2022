//Type is in global namespace

public class DeviceInfo
{
	public enum FormFactor
	{
		iPhone = 0,
		iPad = 1,
		small = 2,
		medium = 3,
		large = 4,
		iPhone5 = 5,
		iPhone6 = 6,
		iPhone6Plus = 7,
		iPhoneUnknown = 8,
	}

	public enum PerformanceLevel
	{
		Low = 0,
		Medium = 1,
		High = 2,
	}

	private const int DEFAULT_ANDROID_PERFORMANCE_LEVEL_THRESHOLD_VALUE = 1000; //Field offset: 0x0
	private const int DEFAULT_KINDLE_PERFORMANCE_LEVEL_THRESHOLD_VALUE = 900; //Field offset: 0x0
	private static readonly string ShaderBackgroundBlendSrcPropName; //Field offset: 0x0
	private static readonly string ShaderBackgroundBlendDstPropName; //Field offset: 0x4
	private static DeviceInfo _instance; //Field offset: 0x8
	public PerformanceLevel _performanceLevel; //Field offset: 0x8
	public string deviceModel; //Field offset: 0xC
	private float <dpi>k__BackingField; //Field offset: 0x10
	private FormFactor <formFactor>k__BackingField; //Field offset: 0x14
	private bool <isHighres>k__BackingField; //Field offset: 0x18
	private int <gpuScore>k__BackingField; //Field offset: 0x1C
	private GPUCategory <gpuCategory>k__BackingField; //Field offset: 0x20

	public float dpi
	{
		 get { } //Length: 212
		private set { } //Length: 8
	}

	public FormFactor formFactor
	{
		 get { } //Length: 6
		private set { } //Length: 7028
	}

	public GPUCategory gpuCategory
	{
		 get { } //Length: 6
		private set { } //Length: 8
	}

	public int gpuScore
	{
		 get { } //Length: 9
		private set { } //Length: 11
	}

	public static DeviceInfo Instance
	{
		 get { } //Length: 97
	}

	public bool isHighres
	{
		 get { } //Length: 6
		private set { } //Length: 8
	}

	public PerformanceLevel performanceLevel
	{
		 get { } //Length: 2277
	}

	private static DeviceInfo() { }

	private DeviceInfo() { }

	public float get_dpi() { }

	public FormFactor get_formFactor() { }

	public GPUCategory get_gpuCategory() { }

	public int get_gpuScore() { }

	public static DeviceInfo get_Instance() { }

	public bool get_isHighres() { }

	public PerformanceLevel get_performanceLevel() { }

	public bool IsDeviceCapablePerformance(PerformanceLevel perfLevel) { }

	private static void Log(string msg, Object context = null) { }

	private static void LogError(string msg, Object context = null) { }

	private void LogUnknownGPU(string gpuName) { }

	private static void LogWarning(string msg, Object context = null) { }

	private void set_dpi(float value) { }

	private void set_formFactor(FormFactor value) { }

	private void set_gpuCategory(GPUCategory value) { }

	private void set_gpuScore(int value) { }

	private void set_isHighres(bool value) { }

	private void SetDeviceInfoForUnknownIpad() { }

	private void SetDeviceInfoForUnknownIphone() { }

}

