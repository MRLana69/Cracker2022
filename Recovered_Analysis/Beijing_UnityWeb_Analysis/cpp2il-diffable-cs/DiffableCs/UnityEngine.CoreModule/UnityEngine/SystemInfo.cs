namespace UnityEngine;

public sealed class SystemInfo
{

	public static string deviceModel
	{
		 get { } //Length: 7
	}

	public static string deviceName
	{
		 get { } //Length: 7
	}

	public static string deviceUniqueIdentifier
	{
		 get { } //Length: 7
	}

	public static string graphicsDeviceName
	{
		 get { } //Length: 7
	}

	public static string graphicsDeviceVersion
	{
		 get { } //Length: 7
	}

	public static int graphicsShaderLevel
	{
		 get { } //Length: 7
	}

	public static string operatingSystem
	{
		 get { } //Length: 47
	}

	public static OperatingSystemFamily operatingSystemFamily
	{
		 get { } //Length: 7
	}

	public static int processorCount
	{
		 get { } //Length: 7
	}

	public static int processorFrequency
	{
		 get { } //Length: 7
	}

	public static string processorType
	{
		 get { } //Length: 7
	}

	public static int systemMemorySize
	{
		 get { } //Length: 7
	}

	public static string get_deviceModel() { }

	public static string get_deviceName() { }

	public static string get_deviceUniqueIdentifier() { }

	public static string get_graphicsDeviceName() { }

	public static string get_graphicsDeviceVersion() { }

	public static int get_graphicsShaderLevel() { }

	public static string get_operatingSystem() { }

	public static OperatingSystemFamily get_operatingSystemFamily() { }

	public static int get_processorCount() { }

	public static int get_processorFrequency() { }

	public static string get_processorType() { }

	public static int get_systemMemorySize() { }

	public static GraphicsFormat GetCompatibleFormat(GraphicsFormat format, FormatUsage usage) { }

	private static string GetDeviceModel() { }

	private static string GetDeviceName() { }

	private static string GetDeviceUniqueIdentifier() { }

	private static string GetGraphicsDeviceName() { }

	private static string GetGraphicsDeviceVersion() { }

	public static GraphicsFormat GetGraphicsFormat(DefaultFormat format) { }

	private static int GetGraphicsShaderLevel() { }

	private static string GetOperatingSystem() { }

	private static OperatingSystemFamily GetOperatingSystemFamily() { }

	private static int GetPhysicalMemoryMB() { }

	private static int GetProcessorCount() { }

	private static int GetProcessorFrequencyMHz() { }

	private static string GetProcessorType() { }

	public static bool IsFormatSupported(GraphicsFormat format, FormatUsage usage) { }

	private static bool IsValidEnumValue(Enum value) { }

	public static bool SupportsTextureFormat(TextureFormat format) { }

	private static bool SupportsTextureFormatNative(TextureFormat format) { }

}

