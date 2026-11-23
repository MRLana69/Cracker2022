using System;
using Cpp2ILInjected;
using UnityEngine;

public class RemoteNotificationControl
{
	public delegate void RemoteNotificationsEnabledHandler(string token, string oldToken);

	private const string CACHED_DEVICE_TOKEN_KEY = "remote_notifications_cached_device_token";

	private static bool _cachedDeviceTokenLoaded;

	private static string _cachedDeviceToken;

	public static void Disable()
	{
		PlayerInfo instance = PlayerInfo.Instance;
		if (~(instance._remoteNotificationsEnabled ? 1u : 0u) == 0)
		{
			instance._dirty = true;
			instance._remoteNotificationsEnabled = false;
		}
	}

	public static void Enable(RemoteNotificationsEnabledHandler completionHandler, string soundToPlay)
	{
		//IL_0074: Expected Obj, but got I
		//IL_0121: Expected Obj, but got I4
		//IL_0105: Expected Obj, but got I4
		//IL_0181: Expected Obj, but got I
		if (Globals.DEBUG_DISABLE_NOTIFICATION_REQUEST)
		{
			return;
		}
		PlayerInfo instance = PlayerInfo.Instance;
		if (!instance._remoteNotificationsEnabled)
		{
			instance._dirty = true;
			instance._remoteNotificationsEnabled = true;
		}
		RuntimePlatform platform = Application.platform;
		if (platform == RuntimePlatform.IPhonePlayer)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v7+8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v7+8]");
			if ((nint)0 != 0)
			{
				string deviceToken = GetDeviceToken();
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v102 @ S0_v47+C] (should have been resolved before IL gen)");
			}
			return;
		}
		RuntimePlatform platform2 = Application.platform;
		if (platform2 != RuntimePlatform.Android)
		{
			return;
		}
		string deviceToken2 = GCMPlugin.deviceToken;
		object obj2;
		if (deviceToken2 != null)
		{
			obj2 = 0;
			if (deviceToken2._stringLength != 0)
			{
				goto IL_01d6;
			}
		}
		obj2 = 1;
		goto IL_01d6;
		IL_01d6:
		if (obj2 != null)
		{
			throw new ArgumentException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v7+8]");
		if ((nint)0 != 0)
		{
			string text = CacheTokenAndGetOldIfChanged(deviceToken2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v7+8]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v132 @ S0_v37+C] (should have been resolved before IL gen)");
		}
	}

	private static string CacheTokenAndGetOldIfChanged(string token)
	{
		if (~(_cachedDeviceTokenLoaded ? 1u : 0u) != 0)
		{
			string cachedDeviceToken = PlayerPrefs.GetString("remote_notifications_cached_device_token", null);
			_cachedDeviceToken = cachedDeviceToken;
			_cachedDeviceTokenLoaded = true;
		}
		bool flag = token != _cachedDeviceToken;
		bool flag2 = !flag;
		string result = null;
		if (!flag2)
		{
			if (token == null)
			{
				PlayerPrefs.DeleteKey("remote_notifications_cached_device_token");
			}
			else
			{
				PlayerPrefs.SetString("remote_notifications_cached_device_token", token);
			}
			_cachedDeviceToken = token;
			result = _cachedDeviceToken;
		}
		return result;
	}

	public static string GetDeviceToken()
	{
		PlayerInfo instance = PlayerInfo.Instance;
		if (~(instance._remoteNotificationsEnabled ? 1u : 0u) == 0)
		{
			RuntimePlatform platform = Application.platform;
			if (platform != RuntimePlatform.IPhonePlayer)
			{
				RuntimePlatform platform2 = Application.platform;
				if (platform2 == RuntimePlatform.Android)
				{
					return GCMPlugin.deviceToken;
				}
			}
		}
		return string.Empty;
	}

	private static string ByteArrayToHex(byte[] barray)
	{
		//IL_00fe: Expected Obj, but got I4
		//IL_0111: Expected Obj, but got I4
		//IL_0028: Expected Obj, but got I
		//IL_008e: Expected Obj, but got I4
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected Obj, but got Unknown
		//IL_0182: Expected Obj, but got I
		//IL_0080: Expected Obj, but got I4
		//IL_00ce: Expected Obj, but got I4
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected Obj, but got Unknown
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected Obj, but got Unknown
		//IL_00c0: Expected Obj, but got I4
		object obj = barray.Length << 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		object obj2 = 0;
		char[] array = default;
		while (barray.Length > (nint)obj2)
		{
			object obj3 = (object)barray + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v16+10]");
			object obj4 = (nint)0 >> 4;
			object obj5 = obj2 << 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v16+10]");
			object obj6;
			object obj7;
			if ((nint)0 <= (nint)159)
			{
				obj6 = obj2 << 1;
				obj7 = 48;
			}
			else
			{
				obj7 = 55;
				obj6 = obj5;
			}
			object obj8 = obj6 << 1;
			object obj9 = (object)array + obj8;
			object obj10 = obj7 + obj4;
			object obj11 = obj2 << 1;
			object obj12 = obj11 + 1;
			object obj13 = (object)barray + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S1_v20+10]");
			object obj14 = (nint)0 & (nint)0xF;
			object obj16;
			object obj17;
			if ((nint)obj14 <= 9)
			{
				object obj15 = obj2 << 1;
				obj16 = obj15 + 1;
				obj17 = 48;
			}
			else
			{
				obj17 = 55;
				obj16 = obj12;
			}
			object obj18 = obj16 << 1;
			object obj19 = (object)array + obj18;
			object obj20 = obj14 + obj17;
			object obj21 = obj2 + 1;
			obj2 = obj21;
		}
		return ((string)null).CreateString(array);
	}
}
