using System;
using System.Globalization;
using Cpp2ILInjected;
using Kiloo.Plugins.DeviceUtility.Internal;
using UnityEngine;

public class DeviceUtilityWSA : IDeviceUtilityPlatformBridge
{
	private const string OS_IDENTIFIER = "windows_phone";

	public bool hasPhysicalBackButton => true;

	public bool isKindleDevice => false;

	public bool isFlexionDevice => false;

	private DeviceUtilityWSA()
	{
	}

	public static DeviceUtilityWSA CreatePlugin()
	{
		DeviceUtilityWSA result = default;
		return result;
	}

	public void SetDeviceUtilityDebugEnabled(bool val)
	{
	}

	public string GetUserDataPath()
	{
		string dataPath = Application.dataPath;
		return dataPath + "/StreamingAssets";
	}

	public string GetCachePath()
	{
		return Application.temporaryCachePath;
	}

	public string GetDeviceIdentifier()
	{
		return SystemInfo.GetDeviceUniqueIdentifier();
	}

	public string GetBundleVersion()
	{
		return string.Empty;
	}

	public string GetBundleIdentifier()
	{
		return Application.identifier;
	}

	public string GetLocale()
	{
		//IL_000d: Expected I, but got Obj
		//IL_0047: Expected I, but got Obj
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected Obj, but got Unknown
		//IL_00cb: Expected I, but got Obj
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected Obj, but got Unknown
		CultureInfo currentCulture = CultureInfo.CurrentCulture;
		CultureInfo invariantCulture = CultureInfo.InvariantCulture;
		nint num = (nint)invariantCulture;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v21 @ S2_v2 (Il2CppClass<System.Globalization.CultureInfo>)+BC] (should have been resolved before IL gen)");
		object obj = default;
		string result;
		if (obj == null)
		{
			nint num2 = (nint)currentCulture;
			object obj2 = currentCulture + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v31 @ S1_v5 (Il2CppClass<System.Globalization.CultureInfo>)+F4] (should have been resolved before IL gen)");
			string text = default;
			if (text._stringLength == 5)
			{
				char c = text.get_Chars(2);
				bool flag = c == '-';
				result = text;
				if (flag)
				{
					goto IL_0138;
				}
			}
			nint num3 = (nint)currentCulture;
			object obj3 = currentCulture + 88;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v58 @ S1_v11 (Il2CppClass<System.Globalization.CultureInfo>)+114] (should have been resolved before IL gen)");
			string text2 = default;
			if (text2._stringLength != 2)
			{
				return "en-US";
			}
			return text2;
		}
		result = "en-US";
		goto IL_0138;
		IL_0138:
		return result;
	}

	public string GetOSVersion()
	{
		return string.Empty;
	}

	public string GetOSIdentifier()
	{
		return "windows_phone";
	}

	public string GetBuildIdentifier()
	{
		return "windows_phone";
	}

	public void SetKeyboardReturnType(int returnKeyType)
	{
	}

	public void ShowNativePopup(string title, string message, string cancelButton, string optionalButton1, string optionalButton2, Action<string> onDismissed)
	{
		if (optionalButton2 != null)
		{
			LogError("ShowNativePopup: optionalButton2 is not supported on this platform, ignored");
		}
	}

	public void SetDeviceClipBoard(string text)
	{
	}

	public int GetDeviceFreeMemory()
	{
		return -1;
	}

	public int GetCurrentMemoryUsage()
	{
		return -1;
	}

	public int GetPeakMemoryUsage()
	{
		return -1;
	}

	public int GetMemoryUsageLimit()
	{
		return -1;
	}

	public int GetBatteryLevel()
	{
		return -1;
	}

	public int GetFreeDiskSpace()
	{
		return -1;
	}

	public int GetTotalDiskSpace()
	{
		return -1;
	}

	public int GetFreeSDCardSpace()
	{
		return -1;
	}

	public int GetTotalSDCardSpace()
	{
		return -1;
	}

	public string GetAndroidExternalSavePath()
	{
		return string.Empty;
	}

	public int GetAndroidApiLevel()
	{
		return -1;
	}

	public int GetAndroidVersionCode()
	{
		return -1;
	}

	public string GetAndroidAdvertisingID()
	{
		return string.Empty;
	}

	public bool GetIOSOtherAudioPlaying()
	{
		return false;
	}

	private static void LogError(string msg)
	{
		string text = "[DeviceUtilityWSA] " + msg;
	}

	private static void LogWarning(string msg)
	{
	}

	private static void Log(string msg)
	{
	}
}
