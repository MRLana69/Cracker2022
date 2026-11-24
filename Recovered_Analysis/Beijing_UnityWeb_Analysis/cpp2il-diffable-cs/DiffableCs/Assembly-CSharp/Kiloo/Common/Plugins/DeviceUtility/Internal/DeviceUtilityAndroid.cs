namespace Kiloo.Common.Plugins.DeviceUtility.Internal;

internal class DeviceUtilityAndroid : MonoBehaviour, IDeviceUtilityPlatformBridge
{
	private const char PARAMETER_SEPARATOR = '\u3B'; //Field offset: 0x0
	private const string OS_IDENTIFIER = "android"; //Field offset: 0x0
	private const int ANDROID_BUTTON_POSITIVE = -1; //Field offset: 0x0
	private const int ANDROID_BUTTON_NEGATIVE = -2; //Field offset: 0x0
	private const int ANDROID_BUTTON_NEUTRAL = -3; //Field offset: 0x0
	private const string CALLBACK_RECEIVER_NAME = "DeviceUtility Receiver"; //Field offset: 0x0

	public bool hasPhysicalBackButton
	{
		 get { } //Length: 3
	}

	public bool isKindleDevice
	{
		 get { } //Length: 3
	}

	private void _callback_alertViewDidDismissWithButtonIndex(string message) { }

	public DeviceUtilityAndroid() { }

	private void Awake() { }

	public static DeviceUtilityAndroid CreatePlugin() { }

	public bool get_hasPhysicalBackButton() { }

	public bool get_isKindleDevice() { }

	public int GetAndroidApiLevel() { }

	public string GetAndroidExternalSavePath() { }

	public int GetAndroidVersionCode() { }

	public int GetBatteryLevel() { }

	public string GetBuildIdentifier() { }

	public string GetBundleIdentifier() { }

	public string GetBundleVersion() { }

	public string GetCachePath() { }

	public int GetCurrentMemoryUsage() { }

	public int GetDeviceFreeMemory() { }

	public string GetDeviceIdentifier() { }

	public int GetFreeDiskSpace() { }

	public int GetFreeSDCardSpace() { }

	public string GetiOSBuildNumber() { }

	public bool GetIOSOtherAudioPlaying() { }

	public string GetLocale() { }

	public int GetMemoryUsageLimit() { }

	public string GetOSIdentifier() { }

	public string GetOSVersion() { }

	public int GetPeakMemoryUsage() { }

	public int GetTotalDiskSpace() { }

	public int GetTotalSDCardSpace() { }

	public string GetUnfilteredLocale() { }

	public string GetUserDataPath() { }

	public string GetUserDocumentsPathiOS() { }

	public string GetUserLibraryPathiOS() { }

	public string GetUserTempPathiOS() { }

	private static void Log(string msg) { }

	private static void LogError(string msg) { }

	private static void LogWarning(string msg) { }

	public void MakeIOSNSLog(string message) { }

	public void SetDeviceClipBoard(string text) { }

	public void SetDeviceUtilityDebugEnabled(bool val) { }

	public void SetKeyboardReturnType(int returnKeyType) { }

	public void ShowNativePopup(string title, string message, string cancelButton, string optionalButton1, string optionalButton2, Action<string> onDismissed) { }

}

