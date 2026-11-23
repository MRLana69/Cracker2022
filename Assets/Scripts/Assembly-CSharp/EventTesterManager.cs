using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo;
using Kiloo.Common.Utility;

public class EventTesterManager
{
	private static EventTesterManager _instance;

	private Dictionary<string, string> _settings;

	private static Action m_OnEventTesterInfoChanged;

	public static EventTesterManager Instance
	{
		get
		{
			if (_instance == null)
			{
				EventTesterManager eventTesterManager = default;
				eventTesterManager._002Ector();
				_instance = eventTesterManager;
			}
			return _instance;
		}
	}

	public static bool isInitialized => _instance != null;

	public static event Action OnEventTesterInfoChanged
	{
		add
		{
			Delegate obj = EventTesterManager.m_OnEventTesterInfoChanged;
			Action action = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == EventTesterManager.m_OnEventTesterInfoChanged;
				Action onEventTesterInfoChanged = action;
				if (!flag)
				{
					onEventTesterInfoChanged = EventTesterManager.m_OnEventTesterInfoChanged;
				}
				EventTesterManager.m_OnEventTesterInfoChanged = onEventTesterInfoChanged;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = EventTesterManager.m_OnEventTesterInfoChanged;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = EventTesterManager.m_OnEventTesterInfoChanged;
			Action action = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == EventTesterManager.m_OnEventTesterInfoChanged;
				Action onEventTesterInfoChanged = action;
				if (!flag)
				{
					onEventTesterInfoChanged = EventTesterManager.m_OnEventTesterInfoChanged;
				}
				EventTesterManager.m_OnEventTesterInfoChanged = onEventTesterInfoChanged;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = EventTesterManager.m_OnEventTesterInfoChanged;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	private EventTesterManager()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		Enum obj = (Enum)(obj2 - 16);
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v31 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>>)+4] (should have been resolved before IL gen)");
		Dictionary<string, string> settings = default;
		_settings = settings;
		UpdateTimeLimit(24);
		UpdateSettingValue("event_value", "Slick");
		_ = 0;
		_ = -1;
		obj = (Enum)(object)typeof(SSEventType);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+C]");
		_ = 0;
		string value = obj.ToString();
		UpdateSettingValue("event_type", value);
	}

	public long GetEventEndTime()
	{
		//IL_005a: Expected Obj, but got I
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected Obj, but got Unknown
		//IL_0039: Expected I8, but got I4
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>)+54]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v24 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj3 = default;
		object obj2 = obj3 ^ -1;
		object obj4 = obj2 >> 31;
		if (obj4 != null)
		{
			string s = _settings.get_Item("event_end");
			return long.Parse(s);
		}
		return 0L;
	}

	public long GetEventStartTime()
	{
		//IL_005a: Expected Obj, but got I
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected Obj, but got Unknown
		//IL_0039: Expected I8, but got I4
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>)+54]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v24 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj3 = default;
		object obj2 = obj3 ^ -1;
		object obj4 = obj2 >> 31;
		if (obj4 != null)
		{
			string s = _settings.get_Item("event_start");
			return long.Parse(s);
		}
		return 0L;
	}

	public long GetEventID()
	{
		//IL_005a: Expected Obj, but got I
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected Obj, but got Unknown
		//IL_0039: Expected I8, but got I4
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>)+54]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v24 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj3 = default;
		object obj2 = obj3 ^ -1;
		object obj4 = obj2 >> 31;
		if (obj4 != null)
		{
			string s = _settings.get_Item("event_end");
			return long.Parse(s);
		}
		return 0L;
	}

	public SSEventType GetEventType()
	{
		//IL_008e: Expected Obj, but got I
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected Obj, but got Unknown
		//IL_0014: Expected VT, but got Obj
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>)+54]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v24 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj3 = default;
		object obj2 = obj3 ^ -1;
		object obj4 = obj2 >> 31;
		if (obj4 != null)
		{
			Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(SSEventType));
			string value = _settings.get_Item("event_type");
			object obj5 = Enum.Parse(typeFromHandle, value, ignoreCase: true);
			throw new NullReferenceException();
		}
		return SSEventType.None;
	}

	public string GetEventValue()
	{
		//IL_0040: Expected Obj, but got I
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>)+54]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v24 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj3 = default;
		object obj2 = obj3 ^ -1;
		object obj4 = obj2 >> 31;
		if (obj4 != null)
		{
			return _settings.get_Item("event_value");
		}
		return string.Empty;
	}

	public SSEventCategory GetEventCategory()
	{
		//IL_0089: Expected Obj, but got I
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected Obj, but got Unknown
		//IL_002d: Expected VT, but got Obj
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>)+54]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v24 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj3 = default;
		object obj2 = obj3 ^ -1;
		object obj4 = obj2 >> 31;
		if (obj4 != null)
		{
			string value = _settings.get_Item("event_category");
			Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(SSEventCategory));
			object obj5 = Enum.Parse(typeFromHandle, value);
			throw new NullReferenceException();
		}
		return SSEventCategory.None;
	}

	public void UpdateInfo(string eventType, string charType, string boardType, string eventCategory, string hoursLeft)
	{
		//IL_0014: Expected VT, but got Obj
		int hoursFromNow = int.Parse(hoursLeft);
		UpdateTimeLimit(hoursFromNow);
		UpdateSettingValue("event_type", eventType);
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(SSEventType));
		object obj = Enum.Parse(typeFromHandle, eventType, ignoreCase: true);
		throw new NullReferenceException();
	}

	private unsafe void UpdateTimeLimit(int hoursFromNow)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected VT, but got Unknown
		//IL_0046: Expected F8, but got I4
		//IL_0046: Expected Ref, but got VT
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected I8, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected I8, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected I8, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		DateTime now = CDateTime.Now;
		long num = TimeUtility.ToUnixTime(now);
		DateTime now2 = CDateTime.Now;
		DateTime dateTime = (DateTime)(obj + 8);
		DateTime time = ((DateTime*)dateTime)->AddHours(hoursFromNow);
		long num2 = TimeUtility.ToUnixTime(time);
		long num3 = obj + 24;
		string value = ((long*)num3)->ToString();
		UpdateSettingValue("event_start", value);
		long num4 = obj + 16;
		string value2 = ((long*)num4)->ToString();
		UpdateSettingValue("event_end", value2);
		long num5 = obj + 16;
		string value3 = ((long*)num5)->ToString();
		UpdateSettingValue("event_id", value3);
	}

	private void UpdateSettingValue(string key, string value)
	{
		//IL_006f: Expected Obj, but got I
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_0048: Expected Obj, but got I
		//IL_0021: Expected Obj, but got I
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>)+54]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v24 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj3 = default;
		object obj2 = obj3 ^ -1;
		object obj4 = obj2 >> 31;
		if (obj4 != null)
		{
			nint num3 = 0;
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S5_v8 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>)+5C]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v52 @ S5_v9+4] (should have been resolved before IL gen)");
		}
		else
		{
			nint num5 = 0;
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S5_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>)+5C]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v68 @ S5_v4+4] (should have been resolved before IL gen)");
		}
	}
}
