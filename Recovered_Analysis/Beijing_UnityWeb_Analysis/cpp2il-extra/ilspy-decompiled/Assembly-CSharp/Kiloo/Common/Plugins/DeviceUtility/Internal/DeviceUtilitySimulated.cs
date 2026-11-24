using System;
using System.Globalization;
using Cpp2ILInjected;
using UnityEngine;

namespace Kiloo.Common.Plugins.DeviceUtility.Internal;

internal class DeviceUtilitySimulated : MonoBehaviour, IDeviceUtilityPlatformBridge
{
	private const string ASSETS_FOLDER = "Assets";

	private const string EDITOR_CACHE_FOLDER = "EditorCache";

	private const int SIMULATED_ANDROID_BUNDLE_VERSION_CODE = 1;

	private const int SIMULATED_ANDROID_API_LEVEL = 8;

	private const bool SIMULATED_IOS_OTHER_AUDIO_PLAYING = false;

	private Action<string> _simulatedOnDismissed;

	private bool _showingPopup = false;

	private string _titleText;

	private string _messageText;

	private string _dismissText;

	private string _optionalButton1Text;

	private string _optionalButton2Text;

	private const string CALLBACK_RECEIVER_NAME = "DeviceUtility Receiver";

	public bool hasPhysicalBackButton => true;

	public bool isKindleDevice
	{
		get
		{
			//IL_000b: Expected I4, but got Obj
			return (byte)(int)"" != 0;
		}
	}

	private static void LogError(string msg)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}

	private static void LogWarning(string msg)
	{
		//IL_0013: Expected I4, but got Obj
		string msg2 = string.ConcatArray((string[])(object)"[DeviceUtilitySimulated] ", (int)msg);
		SDebug.LogFormat(msg2, null);
	}

	private static void Log(string msg)
	{
	}

	public string GetBuildIdentifier()
	{
		return "";
	}

	public void SetKeyboardReturnType(int returnKeyType)
	{
	}

	public void SetDeviceUtilityDebugEnabled(bool val)
	{
	}

	public string GetUserDataPath()
	{
		//IL_000a: Expected Obj, but got I4
		return (string)((DeviceUtilitySimulated)null).GetDeviceFreeMemory();
	}

	public string GetCachePath()
	{
		//IL_0021: Expected I4, but got Obj
		//IL_0021: Expected I4, but got Obj
		string persistentDataPath = Application.persistentDataPath;
		return persistentDataPath.Remove((int)"Assets", (int)"EditorCache");
	}

	public string GetDeviceIdentifier()
	{
		return Application.absoluteURL;
	}

	public string GetBundleVersion()
	{
		return SystemInfo.GetDeviceName();
	}

	public string GetBundleIdentifier()
	{
		return "1.0";
	}

	public string GetLocale()
	{
		return "com.kiloo.subwaysimulated";
	}

	public string GetUnfilteredLocale()
	{
		//IL_0156: Expected I, but got Obj
		//IL_016c: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00b9: Expected Obj, but got I4
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected Obj, but got Unknown
		nint num = (nint)typeof(CultureInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.Globalization.CultureInfo>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CultureInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v35 (Il2CppClass<System.Globalization.CultureInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CultureInfo currentUICulture = CultureInfo.CurrentUICulture;
		CultureInfo currentCulture = CultureInfo.CurrentCulture;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
		object obj2 = default;
		string result;
		if (obj2 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			string text = default;
			if (text.m_stringLength == 5)
			{
				string[] array = text.Split((char[])2);
				object obj3 = array & 0xFFFF;
				bool flag = (nint)obj3 == 45;
				result = text;
				if (flag)
				{
					goto IL_0189;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			string text2 = default;
			if (text2.m_stringLength != 2)
			{
				return "en-US";
			}
			return text2;
		}
		result = "en-US";
		goto IL_0189;
		IL_0189:
		return result;
	}

	public string GetOSVersion()
	{
		//IL_009f: Expected I, but got Obj
		//IL_00b5: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(CultureInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.Globalization.CultureInfo>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CultureInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v19 (Il2CppClass<System.Globalization.CultureInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CultureInfo currentUICulture = CultureInfo.CurrentUICulture;
		CultureInfo currentCulture = CultureInfo.CurrentCulture;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
		object obj2 = default;
		if (obj2 != null)
		{
			return "en-US";
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		string result = default;
		return result;
	}

	public string GetOSIdentifier()
	{
		//IL_001c: Expected Obj, but got I4
		//IL_001c: Expected Obj, but got I4
		//IL_0020: Expected Obj, but got I4
		string stackTrace = Environment.StackTrace;
		return (string)((Version)stackTrace.m_firstChar == (Version)4);
	}

	public void ShowNativePopup(string title, string message, string dismissButton, string positiveButton, string negativeButton, Action<string> onDismissed)
	{
	}

	public void SetDeviceClipBoard(string text)
	{
	}

	public int GetDeviceFreeMemory()
	{
		//IL_011a: Expected I4, but got Obj
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		string dataPath = Application.dataPath;
		object obj2;
		if (dataPath != null)
		{
			object obj = dataPath - 7;
			if ((nint)dataPath == 7)
			{
				obj2 = "windows";
			}
			else if ((nint)obj == 1)
			{
				obj2 = "ios";
			}
			else
			{
				obj2 = (((nint)obj == 2 || (nint)obj == 3 || (nint)obj != 4) ? "other" : "android");
			}
		}
		else
		{
			obj2 = "osx";
		}
		return (int)obj2;
	}

	public int GetCurrentMemoryUsage()
	{
		return 0;
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

	public string GetAndroidAdvertisingID()
	{
		//IL_0006: Expected Obj, but got I4
		return (string)(-1);
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
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		TextEditor textEditor = default;
		textEditor.ClearCursorPos();
		Rect position = ((TextEditor)(object)message).position;
		textEditor.SelectNone();
		textEditor.InitKeyActions();
	}

	private void OnGUI()
	{
	}

	private void SimClosePopup()
	{
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Expected Obj, but got Unknown
		//IL_0025: Expected Obj, but got I4
		//IL_0034: Expected Obj, but got F4
		//IL_0052: Expected I, but got Obj
		//IL_0068: Expected Obj, but got I
		//IL_02d8: Expected I4, but got Obj
		//IL_0093: Expected I, but got Obj
		object obj = default;
		GUI.WindowFunction windowFunction = (GUI.WindowFunction)(obj + 16);
		if (~(_showingPopup ? 1u : 0u) != 0)
		{
			return;
		}
		int height = Screen.height;
		int sleepTimeout = Screen.sleepTimeout;
		obj = 0;
		_ = 0;
		obj = 0f;
		_ = 0f;
		nint num = (nint)typeof(GUI);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v25 (Il2CppClass<UnityEngine.GUI>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(GUI);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v56 (Il2CppClass<UnityEngine.GUI>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		windowFunction = (GUI.WindowFunction)obj;
		GUI.WindowFunction windowFunction2 = windowFunction;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Delegate)windowFunction2).method_ptr = (IntPtr)0;
		windowFunction((int)"Native Popup");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A40");
		GUILayoutOption[] options = default;
		GUILayout.BeginHorizontal(_titleText, options);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A40");
		GUILayoutOption[] options2 = default;
		GUILayout.BeginHorizontal(_messageText, options2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1041B");
		throw new ArrayTypeMismatchException();
	}

	private void TriggerNativePopupDismissEvent(Action<string> onDismissed, string button)
	{
		//IL_000a: Expected I, but got Obj
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected Obj, but got Unknown
		((UnityEngine.Object)this).m_CachedPtr = (IntPtr)button;
		_titleText = button;
		object obj = this + 16;
		obj = onDismissed;
	}

	public static DeviceUtilitySimulated CreatePlugin()
	{
		//IL_006a: Expected I4, but got Obj
		//IL_0078: Expected I, but got Obj
		//IL_008e: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		GameObject gameObject = default;
		gameObject.layer = (int)"DeviceUtility Receiver";
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v16 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((UnityEngine.UnitySynchronizationContext)(object)gameObject).Exec();
		return (DeviceUtilitySimulated)(object)gameObject.AddComponent<DeviceUtilityAndroid>();
	}

	public DeviceUtilitySimulated()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		//IL_001f: Expected Obj, but got I4
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		//IL_0033: Expected Obj, but got I4
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected Obj, but got Unknown
		//IL_0047: Expected Obj, but got I4
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected Obj, but got Unknown
		//IL_005b: Expected Obj, but got I4
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected Obj, but got Unknown
		//IL_006f: Expected Obj, but got I4
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected Obj, but got Unknown
		//IL_0083: Expected Obj, but got I4
		object obj = this + 20;
		obj = 0;
		object obj2 = this + 24;
		obj2 = 0;
		object obj3 = this + 28;
		obj3 = 0;
		object obj4 = this + 32;
		obj4 = 0;
		object obj5 = this + 36;
		obj5 = 0;
		object obj6 = this + 12;
		obj6 = 0;
	}
}
