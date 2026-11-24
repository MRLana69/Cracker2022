namespace Kiloo.Common.Plugins.DeviceUtility.Internal;

internal interface IDeviceUtilityPlatformBridge
{

	public bool hasPhysicalBackButton
	{
		 get { } //Length: 0
	}

	public bool isKindleDevice
	{
		 get { } //Length: 0
	}

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

	public void MakeIOSNSLog(string message) { }

	public void SetDeviceClipBoard(string text) { }

	public void SetDeviceUtilityDebugEnabled(bool val) { }

	public void SetKeyboardReturnType(int returnKeyType) { }

	public void ShowNativePopup(string title, string message, string dismissButton, string optionalButton1, string optionalButton2, Action<string> onDismissed) { }

}

