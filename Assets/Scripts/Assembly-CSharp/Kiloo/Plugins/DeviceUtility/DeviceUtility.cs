using System;
using Cpp2ILInjected;
using Kiloo.Plugins.DeviceUtility.Internal;
using UnityEngine;

namespace Kiloo.Plugins.DeviceUtility;

public static class DeviceUtility
{
	private static IDeviceUtilityPlatformBridge _platformBridge;

	public static bool hasPhysicalBackButton
	{
		get
		{
			if (CheckInstance())
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				bool result = default;
				return result;
			}
			return false;
		}
	}

	public static bool isKindleDevice
	{
		get
		{
			if (CheckInstance())
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				bool result = default;
				return result;
			}
			return false;
		}
	}

	public static bool isFlexionDevice
	{
		get
		{
			if (CheckInstance())
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				bool result = default;
				return result;
			}
			return false;
		}
	}

	private static void LogError(string msg)
	{
		string text = "[DeviceUtility] " + msg;
	}

	private static void LogWarning(string msg)
	{
	}

	private static void Log(string msg)
	{
	}

	private static bool CheckInstance()
	{
		if (_platformBridge == null)
		{
			LogWarning(null);
			Init();
		}
		return _platformBridge != null;
	}

	public static void Init()
	{
		DeviceUtilityWSA platformBridge = DeviceUtilityWSA.CreatePlugin();
		_platformBridge = platformBridge;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
	}

	public static bool IsSupportedOnPlatform()
	{
		//IL_00a1: Expected Obj, but got I4
		//IL_00da: Expected Obj, but got I4
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected I4, but got Unknown
		//IL_0068: Expected Obj, but got I4
		RuntimePlatform platform = Application.platform;
		bool result;
		if (platform <= RuntimePlatform.IPhonePlayer)
		{
			bool flag = platform < RuntimePlatform.OSXWebPlayer;
			result = true;
			if (!flag)
			{
				object obj = platform - 7;
				if ((nint)obj > 1)
				{
					goto IL_00be;
				}
				result = true;
			}
			goto IL_00ed;
		}
		object obj2 = platform - 11;
		if ((nint)obj2 >= 10)
		{
			goto IL_00be;
		}
		object obj3 = 577 >> (int)obj2;
		return (byte)(obj3 & 1) != 0;
		IL_00be:
		result = false;
		goto IL_00ed;
		IL_00ed:
		return result;
	}

	public static void SetKeyboardReturnType(int keyboardReturnType)
	{
		if (CheckInstance())
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
		}
	}

	public static string GetUserDataPath()
	{
		if (!CheckInstance())
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			InvalidOperationException ex = default;
			ex._002Ector("Could not get user data path");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		string result = default;
		return result;
	}

	public static string GetCachePath()
	{
		if (!CheckInstance())
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			InvalidOperationException ex = default;
			ex._002Ector("Could not get user data path");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		string result = default;
		return result;
	}

	public static string GetDeviceIdentifier()
	{
		if (!CheckInstance())
		{
			return string.Empty;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		string result = default;
		return result;
	}

	public static string GetBundleVersion()
	{
		if (!CheckInstance())
		{
			return string.Empty;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		string result = default;
		return result;
	}

	public static string GetBundleIdentifier()
	{
		if (!CheckInstance())
		{
			return string.Empty;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		string result = default;
		return result;
	}

	public static string GetLocale()
	{
		if (!CheckInstance())
		{
			return string.Empty;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		string result = default;
		return result;
	}

	public static string GetOSVersion()
	{
		if (!CheckInstance())
		{
			return string.Empty;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		string result = default;
		return result;
	}

	public static string GetOSIdentifier()
	{
		if (!CheckInstance())
		{
			return string.Empty;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		string result = default;
		return result;
	}

	public static string GetBuildIdentifier()
	{
		if (!CheckInstance())
		{
			return string.Empty;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		string result = default;
		return result;
	}

	public static void ShowNativePopup(string title, string message, string dismissButton, Action<string> onDismissed = null)
	{
		if (CheckInstance())
		{
			ShowNativePopup(title, message, dismissButton, null, null, onDismissed);
		}
	}

	public static void ShowNativePopup(string title, string message, string dismissButton, string optionalButton1, Action<string> onDismissed = null)
	{
		if (CheckInstance())
		{
			ShowNativePopup(title, message, dismissButton, optionalButton1, null, onDismissed);
		}
	}

	public static void ShowNativePopup(string title, string message, string dismissButton, string optionalButton1, string optionalButton2, Action<string> onDismissed = null)
	{
		if (CheckInstance())
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A7C");
		}
	}

	public static void SetDeviceClipBoard(string text)
	{
		if (CheckInstance())
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
		}
	}

	public static int GetDeviceFreeMemory()
	{
		if (CheckInstance())
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			int result = default;
			return result;
		}
		return 0;
	}

	public static int GetCurrentMemoryUsage()
	{
		if (CheckInstance())
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			int result = default;
			return result;
		}
		return 0;
	}

	public static int GetPeakMemoryUsage()
	{
		if (CheckInstance())
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			int result = default;
			return result;
		}
		return 0;
	}

	public static int GetMemoryUsageLimit()
	{
		if (CheckInstance())
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			int result = default;
			return result;
		}
		return 0;
	}

	public static int GetBatteryLevel()
	{
		if (CheckInstance())
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			int result = default;
			return result;
		}
		return -1;
	}

	public static int GetFreeDiskSpace()
	{
		if (CheckInstance())
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			int result = default;
			return result;
		}
		return -1;
	}

	public static int GetTotalDiskSpace()
	{
		if (CheckInstance())
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			int result = default;
			return result;
		}
		return -1;
	}

	public static int GetFreeSDCardSpace()
	{
		if (CheckInstance())
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			int result = default;
			return result;
		}
		return -1;
	}

	public static int GetTotalSDCardSpace()
	{
		if (CheckInstance())
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			int result = default;
			return result;
		}
		return -1;
	}

	public static string GetAndroidExternalSavePath()
	{
		if (!CheckInstance())
		{
			return string.Empty;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		string result = default;
		return result;
	}

	public static int GetAndroidApiLevel()
	{
		if (CheckInstance())
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			int result = default;
			return result;
		}
		return -1;
	}

	public static int GetAndroidVersionCode()
	{
		if (CheckInstance())
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			int result = default;
			return result;
		}
		return -1;
	}

	public static string GetAndroidAdvertisingID()
	{
		if (!CheckInstance())
		{
			return string.Empty;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		string result = default;
		return result;
	}

	public static bool GetIOSOtherAudioPlaying()
	{
		if (CheckInstance())
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			bool result = default;
			return result;
		}
		return false;
	}
}
