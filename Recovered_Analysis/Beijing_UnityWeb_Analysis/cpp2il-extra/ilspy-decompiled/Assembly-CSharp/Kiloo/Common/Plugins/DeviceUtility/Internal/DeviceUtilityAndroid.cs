using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Kiloo.Common.Plugins.Notifications.Internal;
using Kiloo.Common.Utility;
using UnityEngine;

namespace Kiloo.Common.Plugins.DeviceUtility.Internal;

internal class DeviceUtilityAndroid : MonoBehaviour, IDeviceUtilityPlatformBridge
{
	private const char PARAMETER_SEPARATOR = ';';

	private const string OS_IDENTIFIER = "android";

	private const int ANDROID_BUTTON_POSITIVE = -1;

	private const int ANDROID_BUTTON_NEGATIVE = -2;

	private const int ANDROID_BUTTON_NEUTRAL = -3;

	private const string CALLBACK_RECEIVER_NAME = "DeviceUtility Receiver";

	public bool hasPhysicalBackButton => false;

	public bool isKindleDevice => true;

	private static void LogError(string msg)
	{
		//IL_00ef: Expected I, but got Obj
		//IL_0105: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(DeviceUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v25 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!DeviceUtility.IsSupportedOnPlatform())
		{
			return;
		}
		nint num3 = (nint)typeof(DeviceUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v19 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750C");
	}

	private static void LogWarning(string msg)
	{
		//IL_0013: Expected I4, but got Obj
		string msg2 = string.ConcatArray((string[])(object)"[DeviceUtilityAndroid] ", (int)msg);
		SDebug.LogFormat(msg2, null);
	}

	private static void Log(string msg)
	{
	}

	private void Awake()
	{
	}

	private void _callback_alertViewDidDismissWithButtonIndex(string message)
	{
		//IL_001a: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Plugins.DeviceUtility.Internal.DeviceUtilityAndroid)+14]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Plugins.DeviceUtility.Internal.DeviceUtilityAndroid)+14]");
			((Action<string>)0)(message);
		}
	}

	public string GetBuildIdentifier()
	{
		return (string)(object)((DummyNotifications)null).System_002ECollections_002EIEnumerable_002EGetEnumerator();
	}

	public void SetKeyboardReturnType(int returnKeyType)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_002a: Expected Obj, but got I4
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected Obj, but got Unknown
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected Obj, but got Unknown
		//IL_00b2: Expected Obj, but got I4
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected Obj, but got Unknown
		//IL_00c9: Expected Obj, but got I4
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected Obj, but got Unknown
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected Obj, but got Unknown
		//IL_0180: Expected I, but got Obj
		//IL_0196: Expected Obj, but got I
		//IL_01c1: Expected I, but got Obj
		//IL_0254: Invalid comparison between Obj and F8
		//IL_0291: Invalid comparison between Obj and F8
		//IL_0242: Expected Obj, but got I4
		//IL_027f: Expected Obj, but got I4
		//IL_02bc: Expected Obj, but got I4
		//IL_02e9: Invalid comparison between Obj and F8
		//IL_0326: Invalid comparison between Obj and F8
		//IL_02d7: Expected Obj, but got I4
		//IL_058f: Expected I, but got Obj
		//IL_05a5: Expected Obj, but got I
		//IL_0314: Expected Obj, but got I4
		//IL_0351: Expected Obj, but got I4
		//IL_0364: Expected I, but got Obj
		//IL_0409: Expected Obj, but got I4
		//IL_03fb: Expected Obj, but got I4
		//IL_0417: Unknown result type (might be due to invalid IL or missing references)
		//IL_041c: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		object obj4 = default;
		object obj3 = obj4 + 16;
		obj3 = 59;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v68+C]");
		if ((nint)0 == 2)
		{
			object obj6 = default;
			object obj5 = obj6 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			object obj7 = obj6 + 20;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			object obj9 = default;
			object obj8 = obj9 + 16;
			obj8 = 32;
			object obj10 = obj9 + 18;
			obj10 = 45;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ S0_v103+C]");
			if ((nint)0 != 1)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ S0_v108+C]");
			if ((nint)0 != 1)
			{
				return;
			}
			object obj12 = default;
			object obj11 = obj12 + 16;
			object obj14 = default;
			object obj13 = obj14 + 16;
			nint num = (nint)typeof(char);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ S0_v125 (Il2CppClass<System.Char>)+BA]");
			object obj15 = (nint)0 & (nint)0x200;
			if (obj15 != null)
			{
				nint num2 = (nint)typeof(char);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ S0_v183 (Il2CppClass<System.Char>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			object obj16 = default;
			if (obj16 != obj16)
			{
				object obj17 = int.MinValue;
			}
			else if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj16) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)2147483648.0))
			{
				object obj17 = int.MinValue;
			}
			else if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj16) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)(-2147483649.0)))
			{
				object obj17 = int.MinValue;
			}
			else
			{
				object obj17 = obj16;
			}
			object obj18 = default;
			if (obj18 != obj18)
			{
				obj18 = int.MinValue;
			}
			else if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj18) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)2147483648.0))
			{
				obj18 = int.MinValue;
			}
			else if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj18) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)(-2147483649.0)))
			{
				obj18 = int.MinValue;
			}
			nint num3 = (nint)typeof(Depository);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ S0_v140 (Il2CppClass<Kiloo.Common.Utility.Depository>)+BA]");
			object obj19 = (nint)0 & (nint)0x200;
			if (obj19 != null)
			{
				nint num4 = (nint)typeof(Depository);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ S0_v168 (Il2CppClass<Kiloo.Common.Utility.Depository>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			object obj20 = default;
			if (obj20 != null)
			{
				if (obj20 != typeof(Action<int>))
				{
					obj20 = 0;
				}
			}
			else
			{
				obj20 = 0;
			}
			if (obj20 != null)
			{
				object obj21 = obj18 * -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			}
		}
		else
		{
			LogWarning("Malformed dialog callback message");
		}
	}

	public void SetDeviceUtilityDebugEnabled(bool val)
	{
	}

	public string GetUserDataPath()
	{
		//IL_000f: Expected Obj, but got I4
		return (string)((DeviceUtilityAndroid)null).GetDeviceFreeMemory();
	}

	public string GetCachePath()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		InvalidProgramException ex = default;
		ex._002Ector("Could not get user data path");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		return null;
	}

	public string GetDeviceIdentifier()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		InvalidProgramException ex = default;
		ex._002Ector("Could not get cache path");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		return null;
	}

	public string GetBundleVersion()
	{
		return "";
	}

	public string GetBundleIdentifier()
	{
		return "";
	}

	public string GetLocale()
	{
		return "";
	}

	public string GetUnfilteredLocale()
	{
		return "";
	}

	public string GetOSVersion()
	{
		return "";
	}

	public string GetOSIdentifier()
	{
		return "";
	}

	public void ShowNativePopup(string title, string message, string cancelButton, string optionalButton1, string optionalButton2, Action<string> onDismissed)
	{
		//IL_0090: Expected Obj, but got I4
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected Obj, but got Unknown
		//IL_0037: Expected I4, but got Obj
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected Obj, but got Unknown
		string text = default;
		bool flag = text != null;
		bool flag2 = message == null;
		object obj = flag | flag2;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		}
		string text2 = default;
		if (text2 != null)
		{
			object obj2 = text2 + 20;
			obj2 = optionalButton1;
			text2.m_firstChar = (char)(int)optionalButton2;
			object obj3 = text2 + 16;
			obj3 = onDismissed;
		}
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7C62");
		}
	}

	public void SetDeviceClipBoard(string text)
	{
	}

	public int GetDeviceFreeMemory()
	{
		//IL_000b: Expected I4, but got Obj
		return (int)"android";
	}

	public int GetCurrentMemoryUsage()
	{
		return -1;
	}

	public int GetPeakMemoryUsage()
	{
		return 0;
	}

	public int GetMemoryUsageLimit()
	{
		return 0;
	}

	public int GetBatteryLevel()
	{
		return 0;
	}

	public int GetFreeDiskSpace()
	{
		return -1;
	}

	public int GetTotalDiskSpace()
	{
		return 0;
	}

	public int GetFreeSDCardSpace()
	{
		return 0;
	}

	public int GetTotalSDCardSpace()
	{
		return 0;
	}

	public string GetAndroidExternalSavePath()
	{
		//IL_0006: Expected Obj, but got I4
		return (string)1;
	}

	public int GetAndroidApiLevel()
	{
		//IL_000b: Expected I4, but got Obj
		return (int)"";
	}

	public int GetAndroidVersionCode()
	{
		return -1;
	}

	public bool GetIOSOtherAudioPlaying()
	{
		return false;
	}

	public string GetUserLibraryPathiOS()
	{
		return null;
	}

	public string GetUserDocumentsPathiOS()
	{
		return "";
	}

	public string GetUserTempPathiOS()
	{
		return "";
	}

	public string GetiOSBuildNumber()
	{
		return "";
	}

	public void MakeIOSNSLog(string message)
	{
	}

	public static DeviceUtilityAndroid CreatePlugin()
	{
		//IL_00fc: Expected I, but got Obj
		//IL_0112: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(DeviceUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v28 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (DeviceUtility.IsSupportedOnPlatform())
		{
			nint num3 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v16 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(DeviceUtility);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v22 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			DeviceUtilityAndroid result = default;
			return result;
		}
		return (DeviceUtilityAndroid)(object)"";
	}
}
