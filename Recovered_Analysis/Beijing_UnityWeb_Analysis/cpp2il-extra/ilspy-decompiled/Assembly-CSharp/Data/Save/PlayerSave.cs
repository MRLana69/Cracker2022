using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Data.Managers;
using Data.Save.Internal;
using Info;
using Kiloo.Common.Extensions;
using Missions;
using SYBO.Subway.Info;
using UI.Screens.RewardManagement;
using UnityEngine;

namespace Data.Save;

public class PlayerSave : DataManager<PlayerSave>
{
	private static Action m_highScoreChanged;

	private static int bragScoreThreshold__BackingField;

	private static Action<Stat, int> m_statChanged;

	public static int runsCompletedInCurrentMissionsSet
	{
		get
		{
			if (OnboardingSave.hasShownMissionIntroPopup)
			{
				return 1;
			}
			if (OnboardingSave.hasShownFacebookPopup)
			{
				return 1;
			}
			if (OnboardingSave.hasShownHoverboardPopup)
			{
				return 1;
			}
			return OnboardingSave.hasShownEndGameMissionPopup ? 1 : 0;
		}
		set
		{
			//IL_000e: Expected Obj, but got I4
			((DataManager<>)value).OnSaveGameChanged();
		}
	}

	public static int currentMissionSet
	{
		get
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+3C]");
			return 0;
		}
		set
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
		}
	}

	public static int currentSkipForVideoMissionIndex
	{
		get
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			//IL_0021: Expected I4, but got Obj
			LocalDebugData localDebugData = DataManager<>.localDebug;
			object obj = localDebugData - -64;
			return (int)obj;
		}
		set
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			//IL_0024: Expected Obj, but got I4
			LocalDebugData localDebugData = DataManager<>.localDebug;
			object obj = localDebugData - -64;
			obj = value;
		}
	}

	public static DateTime currentSkipForVideoIndexSetAt
	{
		get
		{
			//IL_0018: Expected VT, but got I4
			CloudData cloudData = DataManager<>.cloud;
			return (DateTime)cloudData.completedRunCount;
		}
		set
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
		}
	}

	public static DateTime lastTimeMissionWasSkippedForVideo
	{
		get
		{
			//IL_001b: Expected VT, but got I
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+50]");
			return (DateTime)0;
		}
		set
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
		}
	}

	public unsafe static bool hasSkippedMissionForVideoThisSet
	{
		get
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+4C]");
			return false;
		}
		set
		{
			//IL_001b: Expected Obj, but got I4
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Expected Obj, but got Unknown
			LocalDebugData localDebugData = DataManager<>.localDebug;
			object obj = ((bool*)(value ? 1 : 0))->m_value;
			object obj2 = obj + 8;
			obj2 = obj;
		}
	}

	public static int missionSetCompletedCount
	{
		get
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+60]");
			return ((nint)0 != 0) ? 1 : 0;
		}
		set
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			//IL_0025: Expected Obj, but got I4
			if (value != 0)
			{
				LocalDebugData localDebugData = DataManager<>.localDebug;
				object obj = localDebugData + 100;
				List<int> list = Enumerable.ToList((IEnumerable<int>)value);
				obj = list;
			}
		}
	}

	public static int missionsVersion
	{
		get
		{
			//IL_0087: Expected I, but got Obj
			//IL_009d: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+48]");
			int num = 0;
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v10 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num3 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v19 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (1 > num)
			{
				num = 1;
			}
			return num;
		}
		set
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
		}
	}

	public static int unreportedGames
	{
		get
		{
			//IL_0018: Expected I4, but got Obj
			CloudData cloudData = DataManager<>.cloud;
			return (int)cloudData.pendingRewards;
		}
		set
		{
			//IL_001b: Expected Obj, but got I4
			CloudData cloudData = DataManager<>.cloud;
			cloudData.pendingRewards = (List<CelebrationReward>)value;
		}
	}

	public static DateTime unreportedGamesTimeStamp
	{
		get
		{
			//IL_001b: Expected VT, but got I
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+58]");
			return (DateTime)0;
		}
		set
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
		}
	}

	public static int highScore
	{
		get
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+68]");
			return 0;
		}
	}

	public static int bragScoreThreshold
	{
		get
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+78]");
			return 0;
		}
		set
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
			TransformExtensions.Reset((Transform)(object)PlayerSave.m_highScoreChanged);
		}
	}

	public static Dictionary<AwardId, PersistentAwardProgress> awardsProgress
	{
		get
		{
			//IL_0024: Expected Obj, but got I
			//IL_0081: Unknown result type (might be due to invalid IL or missing references)
			//IL_0086: Expected Obj, but got Unknown
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Expected Obj, but got Unknown
			Dictionary<AwardId, PersistentAwardProgress> dictionary = null;
			object obj = default;
			object obj4 = default;
			while ((nint)obj <= 7)
			{
				LocalDebugData localDebugData = DataManager<>.localDebug;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v12 (Data.Save.Internal.LocalDebugData)+7C]");
				object obj2 = (nint)0 + (nint)16;
				object obj3 = obj2 + obj;
				if (obj3 != null)
				{
					Dictionary<AwardId, PersistentAwardProgress> dictionary2 = (Dictionary<AwardId, PersistentAwardProgress>)(dictionary + 1);
					dictionary = dictionary2;
				}
				obj = obj4 + 1;
			}
			return dictionary;
		}
		set
		{
			//IL_0024: Expected Obj, but got I
			//IL_003a: Expected Obj, but got I4
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+7C]");
			object obj = (nint)0 + (nint)16;
			object obj2 = obj + (object)value;
			obj2 = 1;
		}
	}

	public static DateTime weeklyGiftUnlockTime
	{
		get
		{
			//IL_001b: Expected VT, but got I
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+70]");
			return (DateTime)0;
		}
		set
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
		}
	}

	public static int completedRunCount
	{
		get
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+80]");
			return 0;
		}
		set
		{
			//IL_0024: Expected Obj, but got I
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Expected Obj, but got Unknown
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Expected Obj, but got Unknown
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+94]");
			object obj = (nint)0 + (nint)16;
			int num = value << 2;
			object obj2 = obj + num;
			object obj3 = obj2 + 1;
			obj2 = obj3;
		}
	}

	public static int currentOutfitIndex
	{
		get
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+98]");
			return 0;
		}
		set
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
		}
	}

	public static Characters.CharacterId currentCharacterId
	{
		get
		{
			//IL_0069: Expected I, but got Obj
			//IL_007f: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			Boards.BoardId characterId = currentBoardId;
			nint num = (nint)typeof(CharacterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S1_v3 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(CharacterManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S1_v8 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return CharacterManager.HasCharacterBeenSeen((Characters.CharacterId)characterId) ? Characters.CharacterId.tricky : Characters.CharacterId.slick;
		}
		set
		{
			//IL_0069: Expected I, but got Obj
			//IL_007f: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			Boards.BoardId character = currentBoardId;
			nint num = (nint)typeof(CharacterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S1_v3 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(CharacterManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S1_v8 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			CharacterManager.UnlockOutfit((Characters.CharacterId)character, (int)value);
		}
	}

	public static Boards.BoardId currentBoardId
	{
		get
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+9C]");
			return Boards.BoardId.normal;
		}
		set
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
		}
	}

	public static Boards.BoardId previousBoardId
	{
		get
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+A0]");
			return Boards.BoardId.normal;
		}
		set
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
		}
	}

	public static Dictionary<AwardId, bool> awardIsNew
	{
		get
		{
			//IL_001b: Expected Obj, but got I
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+A4]");
			return (Dictionary<AwardId, bool>)0;
		}
		set
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
		}
	}

	public static Dictionary<AwardId, bool> awardHasPayedOut
	{
		get
		{
			//IL_001b: Expected Obj, but got I
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+A8]");
			return (Dictionary<AwardId, bool>)0;
		}
		set
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			LocalDebugData localDebugData = DataManager<>.localDebug;
			object obj = localDebugData + 168;
			obj = value;
		}
	}

	public static bool awardsFirstLoaded
	{
		get
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+AC]");
			return false;
		}
		set
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			//IL_0024: Expected Obj, but got I4
			LocalDebugData localDebugData = DataManager<>.localDebug;
			object obj = localDebugData + 172;
			obj = value;
		}
	}

	public static event Action highScoreChanged
	{
		add
		{
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Expected Obj, but got Unknown
			LocalDebugData localDebugData = DataManager<>.localDebug;
			object obj = value + 8;
			obj = value;
		}
		remove
		{
			Delegate obj = PlayerSave.m_highScoreChanged;
			Action action = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				if ((object)PlayerSave.m_highScoreChanged == obj)
				{
					PlayerSave.m_highScoreChanged = action;
				}
				if ((object)PlayerSave.m_highScoreChanged != obj)
				{
					obj = PlayerSave.m_highScoreChanged;
					continue;
				}
				break;
			}
		}
	}

	public static event Action<Stat, int> statChanged
	{
		add
		{
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Expected Obj, but got Unknown
			LocalDebugData localDebugData = DataManager<>.localDebug;
			object obj = value + 8;
			obj = value;
		}
		remove
		{
			//IL_0081: Expected I, but got Obj
			//IL_0097: Expected Obj, but got I
			Delegate obj = PlayerSave.m_statChanged;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num = (nint)typeof(PlayerSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v14 (Il2CppClass<Data.Save.PlayerSave>)+5C]");
				object obj3 = (nint)0 + (nint)8;
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
	}

	public static bool HasSkippedMission(int index)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0ee2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee7: Expected Obj, but got Unknown
		//IL_0ef0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef5: Expected Obj, but got Unknown
		//IL_0efe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f03: Expected Obj, but got Unknown
		//IL_0f0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f11: Expected Obj, but got Unknown
		//IL_0f1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f1f: Expected Obj, but got Unknown
		//IL_0f28: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f2d: Expected Obj, but got Unknown
		//IL_0f36: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f3b: Expected Obj, but got Unknown
		//IL_0f44: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f49: Expected Obj, but got Unknown
		//IL_0f52: Expected Obj, but got I4
		//IL_0f5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f60: Expected Obj, but got Unknown
		//IL_0ed9: Expected I4, but got Obj
		object obj2 = default;
		object obj = obj2 - -64;
		object obj3 = obj2 + 16;
		object obj4 = obj2 + 56;
		object obj5 = obj2 + 52;
		object obj6 = obj2 + 48;
		object obj7 = obj2 + 44;
		object obj8 = obj2 + 8;
		object obj9 = obj2 + 24;
		object obj10 = obj2 + 40;
		obj10 = 0;
		object obj11 = obj2 + 32;
		obj11 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		object obj13 = default;
		object obj12 = obj13;
		object obj15 = default;
		object obj14 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj16 = default;
		if (obj14 == obj16)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			object obj18 = default;
			object obj17 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
			object obj20 = default;
			object obj19 = obj20;
		}
		else
		{
			object obj19 = obj12;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		ScorePointsSingleLane scorePointsSingleLane = default;
		return (byte)(int)scorePointsSingleLane != 0;
	}

	public static void ResetSkipMissions()
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected I4, but got Unknown
		List<CelebrationReward> pendingRewards = InventorySave.pendingRewards;
		if ((nint)pendingRewards > 0)
		{
			int unrewardedCoins = InventorySave.unrewardedCoins;
			List<CelebrationReward> pendingRewards2 = InventorySave.pendingRewards;
			int unrewardedCoins2 = pendingRewards2 + unrewardedCoins;
			InventorySave.unrewardedCoins = unrewardedCoins2;
			InventorySave.lastAddedReward = null;
		}
	}

	public unsafe static void SetSkipMission(int index, bool skip)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0370: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Expected Obj, but got Unknown
		//IL_037e: Expected Obj, but got I4
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0392: Expected Obj, but got Unknown
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Expected Obj, but got Unknown
		//IL_03c0: Expected Obj, but got I4
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected Obj, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected Obj, but got Unknown
		//IL_011d: Expected Obj, but got I4
		//IL_01a5: Expected Obj, but got I
		//IL_0436: Expected Obj, but got I4
		//IL_025e: Expected Obj, but got I
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected Obj, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected Obj, but got Unknown
		//IL_00d0: Expected Obj, but got I4
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Expected Obj, but got Unknown
		//IL_0333: Expected Obj, but got I
		//IL_0347: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Expected Obj, but got Unknown
		//IL_035c: Expected native int or pointer, but got Obj
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Expected Obj, but got Unknown
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected Obj, but got Unknown
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj6 = default;
		object obj5 = obj6 + 8;
		obj5 = skip;
		Dictionary<Boards.BoardId, Dictionary<HoverboardThemes.ThemeIdentifier, BoardThemeData>> boardThemeData = InventorySave.boardThemeData;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj7 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj7 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v95+30]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [index @ L0 (System.Int32)+30]");
				if (num == 0)
				{
					object obj8 = obj4 + 4;
					object obj9 = obj8 + 1;
					obj8 = obj9;
					object obj10 = obj9 << 2;
					object obj11 = obj4 + obj10;
					obj11 = 112;
					break;
				}
				continue;
			}
			object obj12 = obj4 + 4;
			object obj13 = obj12 + 1;
			obj12 = obj13;
			object obj14 = obj13 << 2;
			object obj15 = obj4 + obj14;
			obj15 = 73;
			break;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj16 = (nint)0 << 2;
			object obj17 = obj4 + obj16;
			if ((nint)obj17 == 112)
			{
				object obj18 = obj4 + 4;
				if ((nint)obj18 > -1)
				{
					object obj19 = obj18 + -1;
					obj18 = obj19;
				}
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj20 = (nint)0 << 2;
			object obj21 = obj4 + obj20;
			if ((nint)obj21 == 73)
			{
				object obj22 = obj4 + 4;
				if ((nint)obj22 > -1)
				{
					object obj23 = obj22 + -1;
					obj22 = obj23;
				}
				goto IL_0416;
			}
		}
		object obj24 = default;
		if (obj24 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0416;
		IL_0416:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @925A");
		Dictionary<Boards.BoardId, Dictionary<HoverboardThemes.ThemeIdentifier, BoardThemeData>> boardThemeData2 = InventorySave.boardThemeData;
		((List<CelebrationReward>)(object)boardThemeData2).Add((CelebrationReward)index);
		Dictionary<Boards.BoardId, Dictionary<HoverboardThemes.ThemeIdentifier, BoardThemeData>> boardThemeData3 = InventorySave.boardThemeData;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num2 = 0;
		Queue<_00210> queue = default;
		queue._array = (_00210[])num2;
		queue._size = 0;
		object obj25 = queue + 16;
		obj25 = obj6;
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)boardThemeData3, new Queue<T>.Enumerator((Queue<T>)(object)queue));
	}

	public static int GetCurrentMissionProgress(int index)
	{
		//IL_0073: Expected Obj, but got I
		//IL_001b: Expected Obj, but got I
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected Obj, but got Unknown
		LocalDebugData localDebugData = DataManager<>.localDebug;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+38]");
		if (Kiloo.Common.Extensions.CollectionExtensions.ValidIndex((IList<bool>)0, index))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+38]");
			object obj = (nint)0 + (nint)16;
			object obj2 = obj + index;
			return (obj2 != null) ? 1 : 0;
		}
		return 0;
	}

	public static int GetAchievementProgress(int index)
	{
		//IL_0081: Expected Obj, but got I
		//IL_001a: Expected Obj, but got I
		//IL_00b9: Expected Obj, but got I
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected Obj, but got Unknown
		//IL_00dc: Expected I4, but got Obj
		//IL_005a: Expected Obj, but got I
		LocalDebugData localDebugData = DataManager<>.localDebug;
		if (index >= 3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+64]");
			if (Kiloo.Common.Extensions.CollectionExtensions.ValidIndex((IList<int>)0, index))
			{
				int index2 = index - 3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+64]");
				return ((List<int>)0).get_Item(index2);
			}
		}
		LocalDebugData localDebugData2 = DataManager<>.localDebug;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15 (Data.Save.Internal.LocalDebugData)+44]");
		if (Kiloo.Common.Extensions.CollectionExtensions.ValidIndex((IList<int>)0, index))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15 (Data.Save.Internal.LocalDebugData)+44]");
			object obj = (nint)0 + (nint)16;
			int num = index << 2;
			object obj2 = obj + num;
			return (int)obj2;
		}
		return 0;
	}

	public static void SetCurrentMissionProgress(int index, int value)
	{
		//IL_0061: Expected Obj, but got I
		//IL_001b: Expected Obj, but got I
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected Obj, but got Unknown
		//IL_003e: Expected Obj, but got I4
		LocalDebugData localDebugData = DataManager<>.localDebug;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+38]");
		if (Kiloo.Common.Extensions.CollectionExtensions.ValidIndex((IList<bool>)0, index))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+38]");
			object obj = (nint)0 + (nint)16;
			object obj2 = obj + index;
			int num = value & 1;
			obj2 = num;
		}
	}

	public static void InitializeCurrentMissionProgress(int count)
	{
		LocalDebugData localDebugData = DataManager<>.localDebug;
		int num = count & 1;
	}

	public static void LoadCurrentMissionProgress(int[] savedArray)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		LocalDebugData localDebugData = DataManager<>.localDebug;
		object obj = localDebugData + 68;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj2 = default;
		obj = obj2;
	}

	public static void LoadAchievementProgress(int[] savedArray)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		LocalDebugData localDebugData = DataManager<>.localDebug;
		object obj = localDebugData + 68;
		obj = savedArray;
	}

	public static void SetHighScore(int value)
	{
		//IL_0068: Expected Obj, but got I4
		Delegate obj = PlayerSave.m_highScoreChanged;
		Action action = default;
		while (true)
		{
			Delegate obj2 = obj.RemoveImpl((Delegate)value);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			if ((object)PlayerSave.m_highScoreChanged == obj)
			{
				PlayerSave.m_highScoreChanged = action;
			}
			if ((object)PlayerSave.m_highScoreChanged != obj)
			{
				obj = PlayerSave.m_highScoreChanged;
				continue;
			}
			break;
		}
	}

	public static int GetTrophyAchievementProgressCount()
	{
		return bragScoreThreshold__BackingField;
	}

	public static void UnlockTrophy(Trophies.Trophy trophy)
	{
		bragScoreThreshold__BackingField = (int)trophy;
	}

	public static int GetStatValue(Stat stat)
	{
		//IL_004f: Expected Obj, but got I
		//IL_001a: Expected Obj, but got I
		LocalDebugData localDebugData = DataManager<>.localDebug;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+64]");
		if (Kiloo.Common.Extensions.CollectionExtensions.ValidIndex((IList<int>)0, (int)stat))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+64]");
			return ((List<int>)0).get_Item((int)stat);
		}
		return 0;
	}

	public static void SetStatValue(Stat stat, int value)
	{
		//IL_00f3: Expected Obj, but got I
		//IL_001a: Expected Obj, but got I
		//IL_0079: Expected Obj, but got I
		//IL_0087: Expected Obj, but got I4
		//IL_009c: Expected Obj, but got I4
		//IL_005e: Expected Obj, but got I
		LocalDebugData localDebugData = DataManager<>.localDebug;
		if (stat >= Stat.GoldChainClock)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+64]");
			if (Kiloo.Common.Extensions.CollectionExtensions.ValidIndex((IList<int>)0, (int)stat))
			{
				int index = (int)(stat - 3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+64]");
				((List<int>)0).set_Item(index, value);
			}
		}
		LocalDebugData localDebugData2 = DataManager<>.localDebug;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v14 (Data.Save.Internal.LocalDebugData)+44]");
		if (Kiloo.Common.Extensions.CollectionExtensions.ValidIndex((IList<int>)0, (int)stat))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v14 (Data.Save.Internal.LocalDebugData)+44]");
			object obj = (nint)0 + (nint)16;
			object obj2 = (int)stat << 2;
			object obj3 = obj + obj2;
			obj3 = value;
		}
	}

	public static int GetMysteryBoxesOpened(MysteryBox.Type type)
	{
		//IL_0024: Expected Obj, but got I
		//IL_0032: Expected Obj, but got I4
		//IL_0044: Expected I4, but got Obj
		LocalDebugData localDebugData = DataManager<>.localDebug;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+90]");
		object obj = (nint)0 + (nint)16;
		object obj2 = (int)type << 2;
		object obj3 = obj + obj2;
		return (int)obj3;
	}

	public static void IncrementMysteryBoxesOpened(MysteryBox.Type type)
	{
		//IL_0065: Expected Obj, but got I4
		//IL_0081: Expected I, but got Obj
		//IL_0097: Expected Obj, but got I
		Delegate obj = PlayerSave.m_statChanged;
		object obj4 = default;
		while (true)
		{
			Delegate obj2 = obj.RemoveImpl((Delegate)type);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			nint num = (nint)typeof(PlayerSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v14 (Il2CppClass<Data.Save.PlayerSave>)+5C]");
			object obj3 = (nint)0 + (nint)8;
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

	public static void MigrateMysteryBoxOpened(MysteryBox.Type type, int value)
	{
		//IL_0098: Expected Obj, but got I
		//IL_00a6: Expected Obj, but got I4
		//IL_00bb: Expected Obj, but got I4
		//IL_0039: Expected Obj, but got I
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected Obj, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		int mysteryBoxesOpened = GetMysteryBoxesOpened(type);
		LocalDebugData localDebugData = DataManager<>.localDebug;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S1_v5 (Data.Save.Internal.LocalDebugData)+90]");
		object obj = (nint)0 + (nint)16;
		object obj2 = (int)type << 2;
		object obj3 = obj + obj2;
		obj3 = value;
		if (mysteryBoxesOpened != value && PlayerSave.m_statChanged != null)
		{
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S3_v3 (Il2CppMethodInfo)+18]");
			object obj4 = 0;
			object obj5 = obj4;
			object obj6 = obj5 & 0x1FFF;
			object obj7 = obj6 + 113696;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v47 @ S4_v5 (should have been resolved before IL gen)");
		}
	}

	public PlayerSave()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected Obj, but got Unknown
		LocalDebugData localDebugData = DataManager<>.localDebug;
		object obj = this & 1;
	}
}
