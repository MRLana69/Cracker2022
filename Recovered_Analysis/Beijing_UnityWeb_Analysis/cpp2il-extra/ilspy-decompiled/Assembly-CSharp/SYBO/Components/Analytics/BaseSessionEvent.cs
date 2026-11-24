using System;
using System.Security.Cryptography;
using Cpp2ILInjected;
using Info;
using SYBO.Components.Logging;
using UnityEngine;

namespace SYBO.Components.Analytics;

public abstract class BaseSessionEvent : AnalyticsEvent
{
	protected int _sessionID;

	protected int _sessionDelta;

	protected int _sessionEventID;

	public static Func<int> GetSessionID;

	public static Func<int> GetSessionDelta;

	public static Func<int> GetIncrementedSessionEventNumber;

	public static Func<string> GetDeviceID;

	public static Func<string> GetOperatingSystem;

	public static Func<string> GetDeviceModel;

	public static Func<string> GetISOThreeLetterLanguageCode;

	public int SessionId
	{
		get
		{
			//IL_000b: Expected I4, but got Obj
			return (int)"session_started";
		}
	}

	public int SessionDelta => _sessionID;

	public int SessionEventId => _sessionDelta;

	public BaseSessionEvent()
	{
		int sessionID = SessionStartedEvent.GetIncrementedSessionID();
		_sessionID = sessionID;
	}

	protected BaseSessionEvent(DateTime eventTime, int sessionDelta)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
	}

	protected BaseSessionEvent(bool initializeValues)
	{
		//IL_0011: Expected Obj, but got VT
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected Obj, but got Unknown
		DateTime userBirthday = AgeRestriction.GetUserBirthday();
		object obj = userBirthday;
		object obj2 = obj + 8;
		obj2 = obj;
		throw new ArrayTypeMismatchException();
	}

	protected BaseSessionEvent(bool initializeValues, DateTime eventTime, int sessionDelta)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
	}

	private void InitializeCommon()
	{
		((DeviceInfoEvent)this)._002Ector(true);
	}

	private static string GetDeviceIDDefault()
	{
		//IL_01a7: Expected I, but got Obj
		//IL_01bd: Expected Obj, but got I
		//IL_01da: Expected I, but got Obj
		//IL_01f6: Expected I, but got Obj
		//IL_020c: Expected Obj, but got I
		//IL_0229: Expected I, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0043: Expected I, but got Obj
		//IL_02ad: Expected Obj, but got I
		//IL_0086: Expected I, but got Obj
		//IL_009c: Expected Obj, but got I
		//IL_00b9: Expected I, but got Obj
		//IL_013e: Expected I, but got Obj
		//IL_016e: Expected I, but got Obj
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Expected Obj, but got Unknown
		//IL_0069: Expected I, but got Obj
		//IL_00d5: Expected I, but got Obj
		//IL_0105: Expected I, but got Obj
		//IL_0194: Expected I, but got Obj
		//IL_012b: Expected I, but got Obj
		nint num = (nint)typeof(LogCategory);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		bool flag = obj == null;
		nint num2 = (nint)typeof(LogCategory);
		if (!flag)
		{
			nint num3 = (nint)typeof(LogCategory);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v46 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+74]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			num2 = (nint)typeof(LogCategory);
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num2 = (nint)typeof(LogCategory);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120A7");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v11+8]");
		if ((nint)0 == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			nint num4 = (nint)typeof(LogCategory);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v33 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			bool flag4 = obj2 == null;
			nint num5 = (nint)typeof(LogCategory);
			if (!flag4)
			{
				nint num6 = (nint)typeof(LogCategory);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v40 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+74]");
				bool flag5 = (nint)0 == 0;
				bool flag6 = !flag5;
				num5 = (nint)typeof(LogCategory);
				if (!flag6)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num5 = (nint)typeof(LogCategory);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120A7");
			object obj4 = default;
			object obj3 = obj4 + 8;
			object obj5 = default;
			obj3 = obj5;
		}
		nint num7 = (nint)typeof(LogCategory);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v16 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		bool flag7 = obj6 == null;
		nint num8 = (nint)typeof(LogCategory);
		if (!flag7)
		{
			nint num9 = (nint)typeof(LogCategory);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v23 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+74]");
			bool flag8 = (nint)0 == 0;
			bool flag9 = !flag8;
			num8 = (nint)typeof(LogCategory);
			if (!flag9)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num8 = (nint)typeof(LogCategory);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120A7");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v21+8]");
		return (string)0;
	}

	private static string GetDeviceModelDefault()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_021d: Expected Obj, but got I
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Expected Obj, but got Unknown
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		string deviceName = SystemInfo.GetDeviceName();
		if (deviceName != null && deviceName.m_stringLength != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			SHA256Managed sHA256Managed = default;
			sHA256Managed.Initialize();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			object obj4 = default;
			object obj3 = obj4;
			object obj6 = default;
			object obj5 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
			object obj7 = default;
			if (obj5 == obj7)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
			}
			if (sHA256Managed != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
				object obj8 = (nint)0 << 2;
				object obj9 = obj2 + obj8;
				if ((nint)obj9 == 59)
				{
					object obj10 = obj2 + 4;
					if ((nint)obj10 > -1)
					{
						object obj11 = obj10 + -1;
						obj10 = obj11;
					}
					goto IL_03a8;
				}
			}
			object obj12 = default;
			if (obj12 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
		}
		goto IL_03a8;
		IL_03a8:
		string result = default;
		return result;
	}

	private static string GetOperatingSystemDefault()
	{
		return SystemInfo.GetGraphicsDeviceName();
	}

	private static string GetISOThreeLetterLanguageCodeDefault()
	{
		//IL_0009: Expected Obj, but got I4
		return (string)SystemInfo.GetOperatingSystemFamily();
	}

	static BaseSessionEvent()
	{
		//IL_0019: Expected I8, but got I4
		//IL_0023: Expected I8, but got I4
		AnalyticsManager.DefaultUserID = "00000000-0000-f000-0000-000000000000";
		AnalyticsManager._tickOffset = 0L;
		AnalyticsManager._lastTick = -1L;
	}
}
