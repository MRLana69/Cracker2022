using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Data.Save.Internal;
using TopRun.Internal;

namespace Data.Save;

public class TopRunSave : DataManager<TopRunSave>
{
	public static ManagerData managerData
	{
		get
		{
			//IL_002e: Expected Obj, but got I
			//IL_003e: Expected Obj, but got I
			//IL_004e: Expected Obj, but got I
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Expected Obj, but got Unknown
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Expected Obj, but got Unknown
			Dictionary<string, string> syboAnalyticsUnhandledAbTestData = SyboAnalyticsSave.syboAnalyticsUnhandledAbTestData;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S3_v2 (Il2CppMethodInfo)+C]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S3_v3+60]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S3_v4+10]");
			object obj3 = 0;
			object obj4 = obj3 & 0x1FFF;
			object obj5 = obj4 + 113696;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v31 @ S4_v4 (should have been resolved before IL gen)");
			ManagerData result = default;
			return result;
		}
		set
		{
			((DataManager<>)(object)value).OnSaveGameChanged();
		}
	}

	public static RanksData ranksData
	{
		get
		{
			//IL_001b: Expected Obj, but got I
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+12C]");
			return (RanksData)0;
		}
		set
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			LocalDebugData localDebugData = DataManager<>.localDebug;
			object obj = localDebugData + 300;
			obj = value;
		}
	}

	public static PlayerIdsData playerIdsData
	{
		get
		{
			CloudData cloudData = DataManager<>.cloud;
			return (PlayerIdsData)(object)cloudData.statValues;
		}
		set
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			CloudData cloudData = DataManager<>.cloud;
			object obj = cloudData + 144;
			obj = value;
		}
	}

	public static string lastTopRunResultAwardedID
	{
		get
		{
			//IL_001b: Expected Obj, but got I
			CloudData cloudData = DataManager<>.cloud;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.CloudData)+8C]");
			return (string)0;
		}
		set
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			CloudData cloudData = DataManager<>.cloud;
			object obj = cloudData + 140;
			obj = value;
		}
	}

	public static string pendingTopRunResultID
	{
		get
		{
			//IL_001b: Expected Obj, but got I
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+130]");
			return (string)0;
		}
		set
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			LocalDebugData localDebugData = DataManager<>.localDebug;
			object obj = localDebugData + 304;
			obj = value;
		}
	}

	public static int pendingTopRunResultsScore
	{
		get
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+134]");
			return 0;
		}
		set
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			//IL_0024: Expected Obj, but got I4
			LocalDebugData localDebugData = DataManager<>.localDebug;
			object obj = localDebugData + 308;
			obj = value;
		}
	}

	public static int pendingTopRunResultsRank
	{
		get
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+138]");
			return 0;
		}
		set
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
		}
	}

	public static int pendingTopRunResultsWeek
	{
		get
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+13C]");
			return 0;
		}
		set
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
		}
	}

	public static int lastWeekMedalWasShown
	{
		get
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+140]");
			return 0;
		}
		set
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
		}
	}

	public static int pendingTopRunBeatenFriendsAward
	{
		get
		{
			//IL_0018: Expected I4, but got VT
			CloudData cloudData = DataManager<>.cloud;
			return (int)cloudData.weeklyGiftUnlockTime;
		}
		set
		{
			//IL_001b: Expected VT, but got I4
			CloudData cloudData = DataManager<>.cloud;
			cloudData.weeklyGiftUnlockTime = (DateTime)value;
		}
	}

	public TopRunSave()
	{
		LocalDebugData localDebugData = DataManager<>.localDebug;
	}
}
