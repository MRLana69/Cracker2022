using System;
using Cpp2ILInjected;
using UnityEngine;

public class AndroidLocalNotificationsController : ILocalNotificationController
{
	private bool _logEnabled;

	private static AndroidJavaObject _notifManager;

	private static void CheckIfInitialized()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Expected Obj, but got Unknown
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		if (_notifManager != null)
		{
			return;
		}
		RuntimePlatform platform = Application.platform;
		if (platform != RuntimePlatform.Android)
		{
			return;
		}
		AndroidJavaClass androidJavaClass = default;
		androidJavaClass._002Ector("com.kiloo.unityplugins.localnotifications.LocalNotificationsManager");
		object obj3 = obj + 28;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				AndroidJavaObject notifManager = default;
				_notifManager = notifManager;
				goto IL_01b9;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj4 = default;
		object obj5 = default;
		bool flag = obj4 != obj5;
		object obj7 = default;
		object obj6 = obj7;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				goto IL_01b9;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			object obj8 = default;
			obj6 = obj8;
		}
		_ = 0;
		object obj9 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
		return;
		IL_01b9:
		object obj10 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @245");
	}

	private unsafe static void SetLocaleNotificationAndroid(DateTime date, string title, string message, string soundName)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected VT, but got Unknown
		//IL_0043: Expected native int or pointer, but got VT
		//IL_0067: Expected I, but got Obj
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected VT, but got Unknown
		//IL_00b2: Expected Ref, but got VT
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected VT, but got Unknown
		//IL_00d2: Expected Ref, but got VT
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected VT, but got Unknown
		//IL_00f2: Expected Ref, but got VT
		//IL_0103: Expected Obj, but got I8
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		_ = 0;
		RuntimePlatform platform = Application.platform;
		if (platform == RuntimePlatform.Android)
		{
			CheckIfInitialized();
			DateTime dateTime = (DateTime)(obj + 16);
			*(DateTime*)(nint)dateTime = new DateTime(1970, 1, 1);
			TimeZone currentTimeZone = TimeZone.CurrentTimeZone;
			DateTime now = DateTime.Now;
			nint num = (nint)currentTimeZone;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v79 @ S3_v4 (Il2CppClass<System.TimeZone>)+DC] (should have been resolved before IL gen)");
			DateTime dateTime2 = (DateTime)(obj + 16);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			double value = 0.0 * 2.7777777777777777E-11;
			DateTime dateTime3 = ((DateTime*)dateTime2)->AddHours(value);
			DateTime dateTime4 = (DateTime)(obj + 24);
			long ticks = ((DateTime*)dateTime4)->Ticks;
			DateTime dateTime5 = (DateTime)(obj + 16);
			long ticks2 = ((DateTime*)dateTime5)->Ticks;
			object obj3 = ticks - ticks2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			object obj4 = obj3 / 10000;
			obj = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			throw new ArrayTypeMismatchException();
		}
	}

	private static void RemoveAllLocalNotifications()
	{
		RuntimePlatform platform = Application.platform;
		if (platform == RuntimePlatform.Android)
		{
			CheckIfInitialized();
			object[] args = Array.Empty<object>();
			_notifManager.Call("RemoveAllActiveNotifications", args);
		}
	}

	private static void ShowLogInNotificationPlugin(bool enable)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		RuntimePlatform platform = Application.platform;
		if (platform == RuntimePlatform.Android)
		{
			CheckIfInitialized();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			object obj3 = obj + 15;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			throw new ArrayTypeMismatchException();
		}
	}

	public void ScheduleLocalNotification(DateTime date, string title, string message, string soundPath)
	{
		if (title != null && message != null)
		{
			SetLocaleNotificationAndroid(date, title, message, soundPath);
		}
	}

	public void CancelAllNotifications()
	{
		RemoveAllLocalNotifications();
	}

	public void EnableLogs(bool enable)
	{
		ShowLogInNotificationPlugin(enable);
	}

	public static void LogError(string msg, UnityEngine.Object context = null)
	{
	}

	public static void LogWarning(string msg, UnityEngine.Object context = null)
	{
	}

	public static void Log(string msg, UnityEngine.Object context = null)
	{
	}
}
