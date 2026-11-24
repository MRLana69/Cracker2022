using System;
using Cpp2ILInjected;
using Data.Save;
using UnityEngine;

public class RemoteNotificationControl
{
	public delegate void RemoteNotificationsEnabledHandler(string token, string oldToken);

	private const string CACHED_DEVICE_TOKEN_KEY = "remote_notifications_cached_device_token";

	private static bool _cachedDeviceTokenLoaded;

	private static string _cachedDeviceToken;

	public static void Disable()
	{
	}

	public static void Enable(RemoteNotificationsEnabledHandler completionHandler, string soundToPlay)
	{
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected Obj, but got Unknown
		Delegate obj = (Delegate)(object)((Delegate)completionHandler).data;
		object obj4 = default;
		while (true)
		{
			Delegate obj2 = obj.RemoveImpl((Delegate)(object)soundToPlay);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			object obj3 = completionHandler + 44;
			if (obj3 == obj)
			{
				obj3 = obj4;
			}
			if (obj3 != obj)
			{
				obj = (Delegate)obj3;
				continue;
			}
			break;
		}
	}

	private unsafe static string CacheTokenAndGetOldIfChanged(string token)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected I4, but got Unknown
		//IL_003b: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [token @ L0 (System.String)+28]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v10 @ S1_v3+8]");
		object obj2 = 0;
		int num = obj2 + 8;
		((int*)num)->m_value = (int)obj2;
		return (string)(object)((SocialManager)(object)token).FindFriend(num);
	}

	public static string GetDeviceToken()
	{
		//IL_013b: Expected I, but got Obj
		//IL_0151: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0178: Expected Obj, but got I4
		//IL_017c: Expected VT, but got Obj
		//IL_018a: Expected I, but got Obj
		//IL_01a0: Expected Obj, but got I
		//IL_01c6: Expected Obj, but got VT
		//IL_01ce: Expected Obj, but got VT
		//IL_00a1: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		nint num = (nint)typeof(Revive);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Revive>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Revive);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v41 (Il2CppClass<Revive>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = (object)Revive.instance == null;
		bool flag2 = !flag;
		string result = (string)(object)Revive.instance;
		if (!flag2)
		{
			nint num3 = (nint)typeof(Utils);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17 (Il2CppClass<Utils>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(Utils);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v37 (Il2CppClass<Utils>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			_0021_00210 val = (_0021_00210)Utils.FindComponentInThisOrParents<T>((MonoBehaviour)1);
			nint num5 = (nint)typeof(Revive);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v24 (Il2CppClass<Revive>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(Revive);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v31 (Il2CppClass<Revive>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Revive.instance = (Revive)val;
			result = (string)val;
		}
		return result;
	}

	private static string ByteArrayToHex(byte[] barray)
	{
		//IL_02ea: Expected I, but got Obj
		//IL_0300: Expected Obj, but got I
		//IL_03f8: Expected I, but got Obj
		//IL_040e: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_03c4: Expected I4, but got Obj
		//IL_0061: Expected I4, but got Obj
		//IL_0073: Expected I, but got Obj
		//IL_0089: Expected Obj, but got I
		//IL_00a6: Expected I, but got Obj
		//IL_012b: Expected I, but got Obj
		//IL_0333: Expected Obj, but got I
		//IL_033b: Expected Obj, but got I4
		//IL_0178: Expected I, but got Obj
		//IL_018e: Expected Obj, but got I
		//IL_00c2: Expected I, but got Obj
		//IL_00f2: Expected I, but got Obj
		//IL_01b9: Expected I, but got Obj
		//IL_0118: Expected I, but got Obj
		//IL_0228: Expected I, but got Obj
		//IL_023e: Expected Obj, but got I
		//IL_025b: Expected I, but got Obj
		//IL_037d: Expected Obj, but got I
		//IL_0277: Expected I, but got Obj
		//IL_02a7: Expected I, but got Obj
		//IL_02cd: Expected I, but got Obj
		nint num = (nint)typeof(RemoteNotificationControl);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<RemoteNotificationControl>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(RemoteNotificationControl);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v85 (Il2CppClass<RemoteNotificationControl>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(_cachedDeviceTokenLoaded ? 1u : 0u) != 0)
		{
			int num3 = UnityEngine.Random.Range((int)"remote_notifications_cached_device_token", 0);
			nint num4 = (nint)typeof(RemoteNotificationControl);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v69 (Il2CppClass<RemoteNotificationControl>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			bool flag = obj2 == null;
			nint num5 = (nint)typeof(RemoteNotificationControl);
			if (!flag)
			{
				nint num6 = (nint)typeof(RemoteNotificationControl);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v79 (Il2CppClass<RemoteNotificationControl>)+74]");
				bool flag2 = (nint)0 == 0;
				bool flag3 = !flag2;
				num5 = (nint)typeof(RemoteNotificationControl);
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num5 = (nint)typeof(RemoteNotificationControl);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ L1_v16 (Il2CppClass<RemoteNotificationControl>)+5C]");
			object obj3 = (nint)0 + (nint)4;
			obj3 = num3;
			_cachedDeviceTokenLoaded = true;
		}
		nint num7 = (nint)typeof(RemoteNotificationControl);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v16 (Il2CppClass<RemoteNotificationControl>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num8 = (nint)typeof(RemoteNotificationControl);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v59 (Il2CppClass<RemoteNotificationControl>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((string)(object)barray).get_Chars((int)_cachedDeviceToken) != '\0')
		{
			nint num9 = (nint)typeof(RemoteNotificationControl);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v26 (Il2CppClass<RemoteNotificationControl>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num10 = (nint)typeof(RemoteNotificationControl);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v53 (Il2CppClass<RemoteNotificationControl>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (barray != null)
			{
				((TooltipAttribute)(object)"remote_notifications_cached_device_token")._002Ector((string)(object)barray);
			}
			else
			{
				((PropertyAttribute)(object)"remote_notifications_cached_device_token")._002Ector();
			}
			nint num11 = (nint)typeof(RemoteNotificationControl);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S0_v38 (Il2CppClass<RemoteNotificationControl>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			bool flag4 = obj6 == null;
			nint num12 = (nint)typeof(RemoteNotificationControl);
			if (!flag4)
			{
				nint num13 = (nint)typeof(RemoteNotificationControl);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S0_v45 (Il2CppClass<RemoteNotificationControl>)+74]");
				bool flag5 = (nint)0 == 0;
				bool flag6 = !flag5;
				num12 = (nint)typeof(RemoteNotificationControl);
				if (!flag6)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num12 = (nint)typeof(RemoteNotificationControl);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ L1_v11 (Il2CppClass<RemoteNotificationControl>)+5C]");
			object obj7 = (nint)0 + (nint)4;
			obj7 = barray;
			return _cachedDeviceToken;
		}
		return null;
	}

	static RemoteNotificationControl()
	{
		PreferencesSave.localNotificationsEnabled = 0;
	}
}
