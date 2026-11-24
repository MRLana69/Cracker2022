namespace Kiloo.Common.Plugins.DeviceUtility;

public static class DeviceUtility
{
	private static IDeviceUtilityPlatformBridge _platformBridge; //Field offset: 0x0

	public static bool hasPhysicalBackButton
	{
		 get { } //Length: 151
	}

	public static bool isKindleDevice
	{
		 get { } //Length: 151
	}

	private static DeviceUtility() { }

	private static bool CheckInstance() { }

	public static bool get_hasPhysicalBackButton() { }

	public static bool get_isKindleDevice() { }

	public static int GetAndroidApiLevel() { }

	public static string GetAndroidExternalSavePath() { }

	public static int GetAndroidVersionCode() { }

	public static int GetBatteryLevel() { }

	public static string GetBuildIdentifier() { }

	public static string GetBundleIdentifier() { }

	public static string GetBundleVersion() { }

	public static string GetCachePath() { }

	public static int GetCurrentMemoryUsage() { }

	public static int GetDeviceFreeMemory() { }

	public static string GetDeviceIdentifier() { }

	public static int GetFreeDiskSpace() { }

	public static int GetFreeSDCardSpace() { }

	public static string GetiOSBuildNumber() { }

	public static bool GetIOSOtherAudioPlaying() { }

	public static string GetLocale() { }

	public static int GetMemoryUsageLimit() { }

	public static string GetOSIdentifier() { }

	public static string GetOSVersion() { }

	public static int GetPeakMemoryUsage() { }

	public static int GetTotalDiskSpace() { }

	public static int GetTotalSDCardSpace() { }

	public static string GetUnfilteredLocale() { }

	public static string GetUserDataPath() { }

	public static string GetUserDocumentsPathiOS() { }

	public static string GetUserLibraryPathiOS() { }

	public static string GetUserTempPathiOS() { }

	public static void Init() { }

	public static bool IsSupportedOnPlatform() { }

	private static void Log(string msg) { }

	private static void LogError(string msg) { }

	private static void LogWarning(string msg) { }

	public static void MakeIOSNSLog(string message) { }

	public static void SetDeviceClipBoard(string text) { }

	public static void SetKeyboardReturnType(int keyboardReturnType) { }

	public static void ShowNativePopup(string title, string message, string dismissButton, string optionalButton1, string optionalButton2, Action<string> onDismissed = null) { }

	public static void ShowNativePopup(string title, string message, string dismissButton, string optionalButton1, Action<string> onDismissed = null) { }

	public static void ShowNativePopup(string title, string message, string dismissButton, Action<string> onDismissed = null) { }

}

