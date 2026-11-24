using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Data.Save.Internal;
using Events;
using Kiloo;
using Kiloo.Common.Utility;
using WeeklyHunt;

namespace Data.Save;

public class EventsSave : DataManager<EventsSave>
{
	private static bool _willShowSMBAfterDailyChallenge;

	private static DateTime wordHuntExpireDeviceTime__BackingField;

	public static List<bool> hasLoggedWeeklyHuntPeriod
	{
		get
		{
			//IL_000e: Expected VT, but got Obj
			//IL_001b: Expected Obj, but got I
			_00210 val = (_00210)UnityManager<>.instance;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (T)+8]");
			return (List<bool>)0;
		}
		set
		{
			((DataManager<>)(object)value).OnSaveGameChanged();
		}
	}

	public static string weeklyHuntProgressVersion
	{
		get
		{
			//IL_001b: Expected Obj, but got I
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+B8]");
			return (string)0;
		}
		set
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			LocalDebugData localDebugData = DataManager<>.localDebug;
			object obj = localDebugData + 184;
			obj = value;
		}
	}

	public static WeeklyHuntProgressData weeklyHuntProgressData
	{
		get
		{
			//IL_001b: Expected Obj, but got I
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+B4]");
			return (WeeklyHuntProgressData)0;
		}
		set
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			LocalDebugData localDebugData = DataManager<>.localDebug;
			object obj = localDebugData + 180;
			obj = value;
		}
	}

	public static string wordHuntDailyWord
	{
		get
		{
			//IL_001b: Expected Obj, but got I
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+BC]");
			return (string)0;
		}
		set
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			LocalDebugData localDebugData = DataManager<>.localDebug;
			object obj = localDebugData + 188;
			obj = value;
		}
	}

	public static bool wordHuntPayedOut
	{
		get
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+100]");
			return false;
		}
		set
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			//IL_0024: Expected Obj, but got I4
			LocalDebugData localDebugData = DataManager<>.localDebug;
			object obj = localDebugData + 256;
			obj = value;
		}
	}

	public static IntMask wordHuntUnlockedMask
	{
		get
		{
			//IL_002d: Expected VT, but got I4
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+C4]");
			bool flag = (nint)0 != 0;
			return (IntMask)flag;
		}
		set
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			LocalDebugData localDebugData = DataManager<>.localDebug;
			object obj = value & 1;
		}
	}

	public static DateTime wordHuntExpireTime
	{
		get
		{
			//IL_001b: Expected VT, but got I
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+248]");
			return (DateTime)0;
		}
		set
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
		}
	}

	public unsafe static int wordHuntWordsInRow
	{
		get
		{
			//IL_0017: Expected Obj, but got I4
			//IL_0027: Expected Obj, but got I
			//IL_002c: Expected I4, but got Obj
			LocalDebugData localDebugData = DataManager<>.localDebug;
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+C8]");
			obj = 0;
			return (int)obj;
		}
		set
		{
			//IL_001b: Expected Obj, but got I4
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Expected Obj, but got Unknown
			LocalDebugData localDebugData = DataManager<>.localDebug;
			object obj = ((int*)value)->m_value;
			object obj2 = obj + 8;
			obj2 = obj;
		}
	}

	public static int wordHuntLastPayoutDayOfYear
	{
		get
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+C0]");
			return 0;
		}
		set
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
		}
	}

	public static TimeSpan wordHuntTimeLeft
	{
		get
		{
			//IL_001b: Expected VT, but got I
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+108]");
			return (TimeSpan)0;
		}
	}

	public static bool willShowSMBAfterDailyChallenge
	{
		get
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+CC]");
			return false;
		}
		set
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
		}
	}

	public unsafe static DateTime wordHuntExpireDeviceTime
	{
		get
		{
			//IL_00ad: Expected I, but got Obj
			//IL_00c3: Expected Obj, but got I
			//IL_0165: Expected I, but got Obj
			//IL_017b: Expected Obj, but got I
			//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ee: Expected Obj, but got Unknown
			//IL_00f6: Expected Obj, but got VT
			//IL_00fe: Expected Obj, but got VT
			//IL_0107: Unknown result type (might be due to invalid IL or missing references)
			//IL_010c: Expected VT, but got Unknown
			//IL_0119: Expected I8, but got Obj
			//IL_0114: Expected native int or pointer, but got VT
			//IL_0122: Unknown result type (might be due to invalid IL or missing references)
			//IL_0127: Expected Obj, but got Unknown
			//IL_013c: Expected Ref, but got VT
			//IL_0140: Expected VT, but got I8
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			nint num = (nint)typeof(EventsSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<Data.Save.EventsSave>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(EventsSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v35 (Il2CppClass<Data.Save.EventsSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			TimeSpan timeSpan = wordHuntTimeLeft;
			DateTime today = CDateTime.Today;
			nint num3 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v18 (Il2CppClass<System.DateTime>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v31 (Il2CppClass<System.DateTime>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj4 = default;
			object obj3 = obj4 + 8;
			obj3 = timeSpan;
			obj4 = today;
			DateTime dateTime = (DateTime)(obj4 + 16);
			((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj3;
			IFormatProvider formatProvider = (IFormatProvider)(obj4 + 24);
			formatProvider = (IFormatProvider)obj4;
			return (DateTime)((DateTime*)dateTime)->System_002EIConvertible_002EToInt64(formatProvider);
		}
		set
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_009c: Expected I8, but got VT
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(RewardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<RewardManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(RewardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<RewardManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			RewardManager._nextRewardUid = (long)value;
		}
	}

	public static TimeSpan dailyWordDeviceTimeLeft
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(EventsSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.Save.EventsSave>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(EventsSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Data.Save.EventsSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (TimeSpan)wordHuntExpireDeviceTime__BackingField;
		}
	}

	public static CharacterNameEventData characterNameEventData
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00ab: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(EventsSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.Save.EventsSave>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(EventsSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<Data.Save.EventsSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = _willShowSMBAfterDailyChallenge;
			return (CharacterNameEventData)flag;
		}
		set
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a9: Expected Obj, but got Unknown
			//IL_00ba: Expected VT, but got Obj
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(EventsSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v11 (Il2CppClass<Data.Save.EventsSave>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(EventsSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v18 (Il2CppClass<Data.Save.EventsSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj2 = value + 8;
			obj2 = value;
			wordHuntExpireDeviceTime__BackingField = (DateTime)obj2;
		}
	}

	public unsafe static long lastEventID
	{
		get
		{
			//IL_00ad: Expected I, but got Obj
			//IL_00c3: Expected Obj, but got I
			//IL_0166: Expected I, but got Obj
			//IL_017c: Expected Obj, but got I
			//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ee: Expected Obj, but got Unknown
			//IL_00fe: Expected Obj, but got VT
			//IL_0107: Unknown result type (might be due to invalid IL or missing references)
			//IL_010c: Expected VT, but got Unknown
			//IL_0119: Expected I8, but got Obj
			//IL_0114: Expected native int or pointer, but got VT
			//IL_0122: Unknown result type (might be due to invalid IL or missing references)
			//IL_0127: Expected Obj, but got Unknown
			//IL_013c: Expected Ref, but got VT
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			nint num = (nint)typeof(EventsSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<Data.Save.EventsSave>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(EventsSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v35 (Il2CppClass<Data.Save.EventsSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @921E");
			DateTime today = CDateTime.Today;
			nint num3 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v18 (Il2CppClass<System.DateTime>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v31 (Il2CppClass<System.DateTime>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj4 = default;
			object obj3 = obj4 + 8;
			object obj5 = default;
			obj3 = obj5;
			obj4 = today;
			DateTime dateTime = (DateTime)(obj4 + 16);
			((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj3;
			IFormatProvider formatProvider = (IFormatProvider)(obj4 + 24);
			formatProvider = (IFormatProvider)obj4;
			return ((DateTime*)dateTime)->System_002EIConvertible_002EToInt64(formatProvider);
		}
		set
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(RewardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<RewardManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(RewardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<RewardManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			RewardManager._nextRewardUid = value;
		}
	}

	public static long lastTimeAnEventHasBeenTried
	{
		get
		{
			//IL_001b: Expected I8, but got I
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+D8]");
			return 0L;
		}
		set
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
		}
	}

	public static long lastTimeAnEventWasStarted
	{
		get
		{
			//IL_001b: Expected I8, but got I
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+E0]");
			return 0L;
		}
		set
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
		}
	}

	public static string lastEventItemID
	{
		get
		{
			//IL_001b: Expected Obj, but got I
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+D0]");
			return (string)0;
		}
		set
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			LocalDebugData localDebugData = DataManager<>.localDebug;
			object obj = localDebugData + 208;
			obj = value;
		}
	}

	public static long lastTimeEventPopupWasForceShown
	{
		get
		{
			//IL_001b: Expected I8, but got I
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+E8]");
			return 0L;
		}
		set
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
		}
	}

	public static bool shouldRestoreItemAfterEvent
	{
		get
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+F8]");
			return false;
		}
		set
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			//IL_0024: Expected Obj, but got I4
			LocalDebugData localDebugData = DataManager<>.localDebug;
			object obj = localDebugData + 248;
			obj = value;
		}
	}

	public EventsSave()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected Obj, but got Unknown
		LocalDebugData localDebugData = DataManager<>.localDebug;
		object obj = this & 1;
	}

	static EventsSave()
	{
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S3_v3+60]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v28 @ S4_v4 (should have been resolved before IL gen)");
		Dictionary<Type, Dictionary<string, object>> cachedValues = default;
		EventManagerUtils._cachedValues = cachedValues;
	}
}
