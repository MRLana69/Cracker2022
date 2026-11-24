using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Data.Managers;
using Data.Migration;
using Data.Save.Internal;
using Info;
using Kiloo.Common.Extensions;
using Kiloo.Common.Plugins.DeviceUtility;
using Kiloo.Common.Utility;
using SYBO.Components.Analytics.Integration;
using SYBO.Components.Crypt;
using UnityEngine;

namespace Data.Save;

public class SyboAnalyticsSave : DataManager<SyboAnalyticsSave>
{
	public static string syboAnalyticsUserId
	{
		get
		{
			//IL_001b: Expected Obj, but got I
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+208]");
			return (string)0;
		}
		set
		{
			((DataManager<>)(object)value).OnSaveGameChanged();
		}
	}

	public static int syboAnalyticsCurrentSession
	{
		get
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+114]");
			return 0;
		}
		set
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			//IL_0024: Expected Obj, but got I4
			LocalDebugData localDebugData = DataManager<>.localDebug;
			object obj = localDebugData + 276;
			obj = value;
		}
	}

	public static int persistedSessionEventNumber
	{
		get
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+120]");
			return 0;
		}
		set
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
		}
	}

	public static int syboAnalyticsGamesSinceFlush
	{
		get
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+128]");
			return 0;
		}
		set
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
		}
	}

	public static string syboAnalyticsPreviousClientVersion
	{
		get
		{
			CloudData cloudData = DataManager<>.cloud;
			return (string)(object)cloudData.boardThemeData;
		}
		set
		{
			CloudData cloudData = DataManager<>.cloud;
			cloudData.boardThemeData = (Dictionary<Boards.BoardId, Dictionary<HoverboardThemes.ThemeIdentifier, BoardThemeData>>)(object)value;
		}
	}

	public static string syboAnalyticsOperatingSystem
	{
		get
		{
			CloudData cloudData = DataManager<>.cloud;
			return (string)(object)cloudData.unlockedCharacters;
		}
		set
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			CloudData cloudData = DataManager<>.cloud;
			object obj = cloudData + 36;
			obj = value;
		}
	}

	public static string syboAnalyticsDeviceID
	{
		get
		{
			CloudData cloudData = DataManager<>.cloud;
			return (string)(object)cloudData.collectedCharacterTokens;
		}
		set
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			CloudData cloudData = DataManager<>.cloud;
			object obj = cloudData + 40;
			obj = value;
		}
	}

	public static string syboAnalyticsOSLanguage
	{
		get
		{
			CloudData cloudData = DataManager<>.cloud;
			return (string)(object)cloudData.selectedOutfits;
		}
		set
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			CloudData cloudData = DataManager<>.cloud;
			object obj = cloudData + 44;
			obj = value;
		}
	}

	public static DeviceInfo.PerformanceLevel syboAnalyticsPerformanceLevel
	{
		get
		{
			//IL_0018: Expected I4, but got Obj
			CloudData cloudData = DataManager<>.cloud;
			return (DeviceInfo.PerformanceLevel)cloudData.unlockedOutfits;
		}
		set
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			//IL_0024: Expected Obj, but got I4
			CloudData cloudData = DataManager<>.cloud;
			object obj = cloudData + 48;
			obj = value;
		}
	}

	public static int syboAnalyticsGpuScore
	{
		get
		{
			//IL_0018: Expected I4, but got Obj
			CloudData cloudData = DataManager<>.cloud;
			return (int)cloudData.unlockedBoards;
		}
		set
		{
			//IL_001b: Expected Obj, but got I4
			CloudData cloudData = DataManager<>.cloud;
			cloudData.unlockedBoards = (List<Boards.BoardId>)value;
		}
	}

	public static string syboAnalyticsOnlineSettingsLocale
	{
		get
		{
			CloudData cloudData = DataManager<>.cloud;
			return (string)(object)cloudData.hasSkippedMissions;
		}
		set
		{
			CloudData cloudData = DataManager<>.cloud;
			cloudData.hasSkippedMissions = (bool[])(object)value;
		}
	}

	public static Dictionary<string, string> syboAnalyticsPendingOfferRewardToOfferIdMap
	{
		get
		{
			//IL_0018: Expected Obj, but got I4
			CloudData cloudData = DataManager<>.cloud;
			return (Dictionary<string, string>)cloudData.runsCompletedInCurrentMissionSet;
		}
		set
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			CloudData cloudData = DataManager<>.cloud;
			object obj = cloudData + 60;
			obj = value;
		}
	}

	public static Dictionary<string, string> syboAnalyticsUnhandledAbTestData
	{
		get
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			CloudData cloudData = DataManager<>.cloud;
			return (Dictionary<string, string>)(cloudData - -64);
		}
		set
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			CloudData cloudData = DataManager<>.cloud;
			object obj = cloudData - -64;
			obj = value;
		}
	}

	public static SampleState syboAnalyticsSampleState
	{
		get
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+11C]");
			return SampleState.Undefined;
		}
		set
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			//IL_0024: Expected Obj, but got I4
			LocalDebugData localDebugData = DataManager<>.localDebug;
			object obj = localDebugData + 284;
			obj = value;
		}
	}

	public static string syboAggregatedDataString
	{
		get
		{
			//IL_001b: Expected Obj, but got I
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+110]");
			return (string)0;
		}
		set
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
		}
	}

	public static bool kilooAnalyticsHasLoggedSyboUserId
	{
		get
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+118]");
			return false;
		}
		set
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			//IL_0024: Expected Obj, but got I4
			LocalDebugData localDebugData = DataManager<>.localDebug;
			object obj = localDebugData + 280;
			obj = value;
		}
	}

	public static bool isSyboAnalyticsUserIdAssigned
	{
		get
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+124]");
			return (nint)0 != 0;
		}
	}

	public static void SyboAnalyticsAddUnhandledAbTestData(string testTag, int segmentIndex)
	{
		//IL_0429: Expected I, but got Obj
		//IL_043f: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0526: Expected I, but got Obj
		//IL_053c: Expected Obj, but got I
		//IL_007d: Expected I, but got Obj
		//IL_0093: Expected Obj, but got I
		//IL_01ed: Expected I, but got Obj
		//IL_0203: Expected Obj, but got I
		//IL_047d: Expected Obj, but got I4
		//IL_0486: Expected Obj, but got I4
		//IL_03ca: Expected I4, but got Obj
		//IL_03d8: Expected I, but got Obj
		//IL_03ee: Expected Obj, but got I
		//IL_03f6: Expected Obj, but got I4
		//IL_0379: Expected I, but got Obj
		//IL_050f: Expected Obj, but got I4
		//IL_00be: Expected I, but got Obj
		//IL_027b: Expected Obj, but got I4
		//IL_0284: Expected Obj, but got I4
		//IL_022e: Expected I, but got Obj
		//IL_010b: Expected Obj, but got I4
		//IL_015f: Expected I, but got Obj
		//IL_0175: Expected Obj, but got I
		//IL_0297: Expected Obj, but got I4
		//IL_04ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bf: Expected Obj, but got Unknown
		//IL_02eb: Expected I, but got Obj
		//IL_0301: Expected Obj, but got I
		//IL_01a0: Expected I, but got Obj
		//IL_056b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0570: Expected Obj, but got Unknown
		//IL_032c: Expected I, but got Obj
		nint num = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Globals>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v102 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(Globals.DEBUG ? 1u : 0u) == 0)
		{
			if (testTag != null)
			{
				nint num3 = (nint)typeof(SaveManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v75 (Il2CppClass<Data.Save.SaveManager>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(SaveManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v96 (Il2CppClass<Data.Save.SaveManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				int mostRecentSlot = FileUtil.GetMostRecentSlot(SaveManager.LOCAL_FILE_PATH, false);
				object obj3 = mostRecentSlot + 12;
				object obj4 = 0;
				int totalLength = default;
				while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3))
				{
					object obj5 = mostRecentSlot + 16;
					object obj6 = obj4 << 2;
					object obj7 = obj5 + obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
					string message = string.ConcatArray((string[])(object)"File deleted: ", totalLength);
					nint num5 = (nint)typeof(Debug);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ S1_v50 (Il2CppClass<UnityEngine.Debug>)+BA]");
					object obj8 = (nint)0 & (nint)0x200;
					if (obj8 != null)
					{
						nint num6 = (nint)typeof(Debug);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ S1_v56 (Il2CppClass<UnityEngine.Debug>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Debug.LogError(message);
					object obj9 = obj4 + 1;
					obj4 = obj9;
				}
			}
			if (segmentIndex != 0)
			{
				nint num7 = (nint)typeof(SaveManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v49 (Il2CppClass<Data.Save.SaveManager>)+BA]");
				object obj10 = (nint)0 & (nint)0x200;
				if (obj10 != null)
				{
					nint num8 = (nint)typeof(SaveManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S0_v70 (Il2CppClass<Data.Save.SaveManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Dictionary<string, Friend.Status> friendStatus = SocialSave.friendStatus;
				bool flag = PlayerInfoMigrator.MigrateInventorySave((Dictionary<Key, string>)(object)friendStatus);
				int mostRecentSlot2 = FileUtil.GetMostRecentSlot((string)flag, false);
				object obj11 = mostRecentSlot2 + 12;
				object obj12 = 0;
				int totalLength2 = default;
				while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11))
				{
					object obj13 = mostRecentSlot2 + 16;
					object obj14 = obj12 << 2;
					object obj15 = obj13 + obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
					string message2 = string.ConcatArray((string[])(object)"File deleted: ", totalLength2);
					nint num9 = (nint)typeof(Debug);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ S1_v27 (Il2CppClass<UnityEngine.Debug>)+BA]");
					object obj16 = (nint)0 & (nint)0x200;
					if (obj16 != null)
					{
						nint num10 = (nint)typeof(Debug);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ S1_v33 (Il2CppClass<UnityEngine.Debug>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Debug.LogError(message2);
					object obj17 = obj12 + 1;
					obj12 = obj17;
				}
			}
			nint num11 = (nint)typeof(SaveManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S0_v21 (Il2CppClass<Data.Save.SaveManager>)+BA]");
			object obj18 = (nint)0 & (nint)0x200;
			if (obj18 != null)
			{
				nint num12 = (nint)typeof(SaveManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S0_v42 (Il2CppClass<Data.Save.SaveManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Dictionary<string, Friend.Status> friendStatus2 = SocialSave.friendStatus;
			bool active = PlayerInfoMigrator.MigrateInventorySave((Dictionary<Key, string>)(object)friendStatus2);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Boards.BoardId boardId = default;
			BoardManager.SetThemeActive(boardId, (HoverboardThemes.ThemeIdentifier)SaveManager.LOCAL_FILE_PATH, active);
			nint num13 = (nint)typeof(SaveManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ S0_v35 (Il2CppClass<Data.Save.SaveManager>)+5C]");
			object obj19 = (nint)0 + (nint)12;
			obj19 = boardId;
			TransformExtensions.Reset((Transform)(object)SaveManager.saveGameChanged);
		}
		else
		{
			SDebug.LogFormat("DEBUG is not enabled - you cannot delete files with current project settings!", null);
		}
	}

	public static void SyboAnalyticsClearUnhandledAbTestData()
	{
		//IL_023a: Expected I, but got Obj
		//IL_0250: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0284: Expected I, but got Obj
		//IL_029a: Expected Obj, but got I
		//IL_02d2: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_013b: Expected Obj, but got I4
		//IL_013b: Expected Obj, but got I4
		//IL_0149: Expected I, but got Obj
		//IL_015f: Expected Obj, but got I
		//IL_01db: Expected I4, but got Obj
		//IL_01e9: Expected I, but got Obj
		//IL_01ff: Expected Obj, but got I
		//IL_0207: Expected Obj, but got I4
		//IL_018a: Expected I, but got Obj
		nint num = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Globals>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v59 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(Globals.DEBUG ? 1u : 0u) == 0)
		{
			nint num3 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v17 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(DeviceUtility);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v55 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string cachePath = DeviceUtility.GetCachePath();
			nint num5 = (nint)typeof(Path);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S1_v7 (Il2CppClass<System.IO.Path>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(Path);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S1_v22 (Il2CppClass<System.IO.Path>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = Path.SameRoot(cachePath, "Save");
			if (!Directory.IsRootDirectory((string)flag))
			{
				return;
			}
			Directory.Move((string)flag, (string)1);
			nint num7 = (nint)typeof(SaveManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v28 (Il2CppClass<Data.Save.SaveManager>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num8 = (nint)typeof(SaveManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v49 (Il2CppClass<Data.Save.SaveManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Dictionary<string, Friend.Status> friendStatus = SocialSave.friendStatus;
			bool active = PlayerInfoMigrator.MigrateInventorySave((Dictionary<Key, string>)(object)friendStatus);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Boards.BoardId boardId = default;
			BoardManager.SetThemeActive(boardId, (HoverboardThemes.ThemeIdentifier)SaveManager.LOCAL_FILE_PATH, active);
			nint num9 = (nint)typeof(SaveManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S0_v42 (Il2CppClass<Data.Save.SaveManager>)+5C]");
			object obj5 = (nint)0 + (nint)12;
			obj5 = boardId;
			TransformExtensions.Reset((Transform)(object)SaveManager.saveGameChanged);
		}
		else
		{
			SDebug.LogFormat("DEBUG is not enabled - you cannot delete files with current project settings!", null);
		}
	}

	public static void SyboAnalyticsAddPendingOfferReward(string rewardAmount, long offerId)
	{
		//IL_0027: Expected I8, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		NullReferenceException ex = default;
		ex._002Ector();
		((EncryptedCTRStream)(object)ex).SetLength(0L);
	}

	public static void SyboAnalyticsRemovePendingOffer(string rewardAmount)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		LocalDebugData localDebugData = DataManager<>.localDebug;
		object obj = rewardAmount & 1;
	}

	public static void SyboAnalyticsClearPendingOffers()
	{
		//IL_0040: Expected Obj, but got I
		SampleState sampleState = syboAnalyticsSampleState;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (SYBO.Components.Analytics.Integration.SampleState)+10]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (SYBO.Components.Analytics.Integration.SampleState)+1C]");
		object obj = num - 0;
		if ((nint)obj > 0)
		{
			SampleState sampleState2 = syboAnalyticsSampleState;
			throw new IndexOutOfRangeException();
		}
	}

	public static Dictionary<string, string> SyboAnalyticsGetPendingOfferRewards()
	{
		//IL_0048: Expected Obj, but got I
		//IL_007b: Expected Obj, but got I4
		LocalDebugData localDebugData = DataManager<>.localDebug;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+114]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+114]");
		bool flag;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S0_v8+8]");
			flag = (nint)0 == 0;
		}
		else
		{
			flag = true;
		}
		return (Dictionary<string, string>)((flag ? 1 : 0) ^ 1);
	}

	public SyboAnalyticsSave()
	{
		//IL_0041: Expected Obj, but got I
		//IL_0051: Expected Obj, but got I
		//IL_0061: Expected Obj, but got I
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected Obj, but got Unknown
		Dictionary<string, string> dictionary = syboAnalyticsUnhandledAbTestData;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S2_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S2_v3+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S2_v4+44]");
		object obj3 = 0;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v26 @ S3_v4 (should have been resolved before IL gen)");
		object obj6 = default;
		if ((nint)obj6 > -1)
		{
			Dictionary<string, string> dictionary2 = syboAnalyticsUnhandledAbTestData;
			bool flag = dictionary2.Remove((string)(object)this);
		}
	}
}
