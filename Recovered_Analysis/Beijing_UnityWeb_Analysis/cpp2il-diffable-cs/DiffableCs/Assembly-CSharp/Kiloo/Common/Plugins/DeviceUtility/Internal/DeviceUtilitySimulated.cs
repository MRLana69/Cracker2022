namespace Kiloo.Common.Plugins.DeviceUtility.Internal;

internal class DeviceUtilitySimulated : MonoBehaviour, IDeviceUtilityPlatformBridge
{
	private const string ASSETS_FOLDER = "Assets"; //Field offset: 0x0
	private const string EDITOR_CACHE_FOLDER = "EditorCache"; //Field offset: 0x0
	private const int SIMULATED_ANDROID_BUNDLE_VERSION_CODE = 1; //Field offset: 0x0
	private const int SIMULATED_ANDROID_API_LEVEL = 8; //Field offset: 0x0
	private const bool SIMULATED_IOS_OTHER_AUDIO_PLAYING = False; //Field offset: 0x0
	private const string CALLBACK_RECEIVER_NAME = "DeviceUtility Receiver"; //Field offset: 0x0
	private Action<string> _simulatedOnDismissed; //Field offset: 0xC
	private bool _showingPopup; //Field offset: 0x10
	private string _titleText; //Field offset: 0x14
	private string _messageText; //Field offset: 0x18
	private string _dismissText; //Field offset: 0x1C
	private string _optionalButton1Text; //Field offset: 0x20
	private string _optionalButton2Text; //Field offset: 0x24

	public bool hasPhysicalBackButton
	{
		 get { } //Length: 3
	}

	public bool isKindleDevice
	{
		 get { } //Length: 43
	}

	public DeviceUtilitySimulated() { }

	public static DeviceUtilitySimulated CreatePlugin() { }

	public bool get_hasPhysicalBackButton() { }

	public bool get_isKindleDevice() { }

	public string GetAndroidAdvertisingID() { }

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

	private void OnGUI() { }

	public void SetDeviceClipBoard(string text) { }

	public void SetDeviceUtilityDebugEnabled(bool val) { }

	public void SetKeyboardReturnType(int returnKeyType) { }

	public void ShowNativePopup(string title, string message, string dismissButton, string positiveButton, string negativeButton, Action<string> onDismissed) { }

	private void SimClosePopup() { }

	private void TriggerNativePopupDismissEvent(Action<string> onDismissed, string button) { }

}

