using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Data.Save;
using Info;
using Kiloo;
using SYBO.Components.Utilities;
using SYBO.Subway.Info;
using SYBO.Subway.Pickups;
using SYBO.Subway.Pickups.Pickers;
using UI.Screens.RewardManagement;
using UnityEngine;
using UnityEngine.Rendering;
using WordHunt;

namespace WeeklyHunt;

public static class WeeklyHuntData
{
	public enum WeeklyHuntPrize
	{
		NotAvailable,
		Key,
		SuperMysteryBox,
		Hoverboard,
		ScoreBooster,
		Headstart,
		ChristmasBoard,
		RioBoard2,
		NorthpoleBoard2016,
		CherryBoard
	}

	public enum PrizePeriodId
	{
		None,
		PeriodOne,
		PeriodTwo,
		PeriodThree,
		PeriodFour
	}

	public enum PeriodStatus
	{
		Unstarted,
		Expired,
		Current
	}

	public class WeeklyHuntPeriodData
	{
		public int itemsToCollect;

		public int itemsCollected;

		public bool hiddenUntilUnlocked;

		public string periodTitle;

		public DateTime periodStartDate;

		public DateTime periodEndDate;

		public PrizeData mainPrize;

		public WeeklyHuntPeriodData()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	[StructLayout((LayoutKind)0, Size = 28)]
	public struct PrizeData
	{
		public int amount;

		public CelebrationRewardOrigin celebrationRewardOrigin;

		public CelebrationRewardType rewardType;

		public UpgradeType upgradeType;

		public Characters.CharacterId characterId;

		public Boards.BoardId boardId;

		public Trophies.Trophy trophyType;
	}

	public static bool hideLastPeriod;

	private static bool _hasInited;

	private const string DEBUG_TIME_OFFSET_PLAYER_PREFS_KEY = "WEEKLY_HUNT_TIME_OFFSET";

	private static Dictionary<int, WeeklyHuntPeriodData> _huntPeriodData;

	public static DateTime startChallengeDateTime
	{
		get
		{
			//IL_0011: Expected Obj, but got VT
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Expected Obj, but got Unknown
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Expected VT, but got Unknown
			DateTime utcNow = CDateTime.UtcNow;
			object obj = utcNow;
			object obj2 = obj & 0x3FFFFFFFFFFFFFFFL;
			int num = UnityEngine.Random.RandomRangeInt(0, int.MaxValue);
			return (DateTime)(num + obj2);
		}
	}

	public static Dictionary<int, WeeklyHuntPeriodData> GetHuntData()
	{
		//IL_007c: Expected I, but got Obj
		//IL_0092: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (PrizeIconPrefabData._instance != null)
		{
			_0021_00210[] instance = (_0021_00210[])(object)Resources.LoadAll<T>("Info/PrizeIconPrefabData");
			PrizeIconPrefabData._instance = (PrizeIconPrefabData)(object)instance;
		}
		return (Dictionary<int, WeeklyHuntPeriodData>)(object)PrizeIconPrefabData._instance;
	}

	private static void Init()
	{
		//IL_01b1: Expected Obj, but got I4
		//IL_01d4: Expected Obj, but got I4
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected Obj, but got Unknown
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Expected Obj, but got Unknown
		//IL_000e: Expected Obj, but got I4
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected Obj, but got Unknown
		//IL_005f: Expected Obj, but got I4
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected Obj, but got Unknown
		//IL_00b5: Expected Obj, but got I4
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected Obj, but got Unknown
		//IL_0106: Expected Obj, but got I4
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected Obj, but got Unknown
		//IL_015b: Expected I, but got Obj
		//IL_0171: Expected Obj, but got I
		//IL_017a: Expected Obj, but got I4
		//IL_0188: Expected I, but got Obj
		//IL_019e: Expected Obj, but got I
		//IL_01a7: Expected Obj, but got I4
		object obj = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		obj = 1;
		_ = 0;
		object obj2 = obj + 12;
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		WordHuntManager.WordHuntReward[] array = default;
		object obj3 = array + 16;
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v17+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		obj = 1;
		_ = 0;
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj4 = array + 28;
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v17+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		obj = 0;
		_ = 1050;
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj5 = array + 40;
		obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v17+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		obj = 0;
		_ = 1500;
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj6 = array + 52;
		obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v17+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		obj = 1;
		_ = 1;
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj7 = array - -64;
		obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v17+8]");
		_ = 0;
		WordHuntManager.REWARDS = array;
		nint num = (nint)typeof(WordHuntManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S0_v58 (Il2CppClass<WordHunt.WordHuntManager>)+5C]");
		object obj8 = (nint)0 + (nint)8;
		obj8 = 0;
		nint num2 = (nint)typeof(WordHuntManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S0_v62 (Il2CppClass<WordHunt.WordHuntManager>)+5C]");
		object obj9 = (nint)0 + (nint)12;
		obj9 = 0;
	}

	public static void LoadProgressFromResources()
	{
		//IL_017c: Expected I, but got Obj
		//IL_0192: Expected Obj, but got I
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_012f: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Globals>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v38 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(Globals.DEBUG ? 1u : 0u) == 0)
		{
			nint num3 = (nint)typeof(WeeklyHuntData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v29 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(WeeklyHuntData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v34 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			DebugResetWeeklyHuntData();
		}
		nint num5 = (nint)typeof(WeeklyHuntData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v15 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(WeeklyHuntData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v22 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_hasInited = true;
		FlurryLogCurrentUpdatesWeeklyHuntPeriodProgress();
	}

	private static bool ShouldResetChallengeData(string currentStartDate)
	{
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected Obj, but got Unknown
		//IL_00fe: Expected Obj, but got I4
		//IL_0107: Expected Obj, but got I4
		//IL_0115: Expected I, but got Obj
		//IL_012b: Expected Obj, but got I
		//IL_015e: Expected Obj, but got I8
		//IL_0013: Expected I, but got Obj
		//IL_00e2: Expected I4, but got F8
		object obj2 = default;
		object obj = obj2 + 8;
		obj = 0;
		obj2 = 0;
		nint num = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12 (Il2CppClass<System.DateTime>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v30 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		long systemTimeAsFileTime = DateTime.GetSystemTimeAsFileTime();
		obj = systemTimeAsFileTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCCE");
		object obj4 = default;
		obj2 = obj4;
		double num3 = (double)obj2 * 1E-07;
		double num4 = 86400.0 - num3;
		if (num4 != num4)
		{
			return false;
		}
		if (!(num4 < 2147483648.0))
		{
			return false;
		}
		if (!(num4 > -2147483649.0))
		{
			return false;
		}
		return (byte)(int)num4 != 0;
	}

	public static void SaveNewProgress(bool shouldStartNewProgress)
	{
		//IL_006a: Expected Obj, but got I4
		//IL_008a: Expected Obj, but got I4
		//IL_00aa: Expected Obj, but got I4
		//IL_001b: Expected Obj, but got I4
		//IL_003b: Expected Obj, but got I4
		//IL_005b: Expected Obj, but got I4
		object obj = (shouldStartNewProgress ? 1 : 0) + 20;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj2 = default;
		obj = obj2;
		object obj3 = (shouldStartNewProgress ? 1 : 0) + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj4 = default;
		obj3 = obj4;
		object obj5 = (shouldStartNewProgress ? 1 : 0) + 28;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj6 = default;
		obj5 = obj6;
		object obj7 = (shouldStartNewProgress ? 1 : 0) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj8 = default;
		obj7 = obj8;
		object obj9 = (shouldStartNewProgress ? 1 : 0) + 36;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj10 = default;
		obj9 = obj10;
		ScriptableObject.CreateScriptableObject((ScriptableObject)shouldStartNewProgress);
	}

	private static void FlurryLogCurrentUpdatesWeeklyHuntPeriodProgress()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_044e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0453: Expected Obj, but got Unknown
		//IL_045c: Expected Obj, but got I4
		//IL_0471: Unknown result type (might be due to invalid IL or missing references)
		//IL_0476: Expected Obj, but got Unknown
		//IL_047f: Expected Obj, but got I4
		//IL_0488: Unknown result type (might be due to invalid IL or missing references)
		//IL_048d: Expected Obj, but got Unknown
		//IL_04a9: Expected I, but got Obj
		//IL_04bf: Expected Obj, but got I
		//IL_05f5: Expected I, but got Obj
		//IL_060b: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_0149: Expected I, but got Obj
		//IL_015f: Expected Obj, but got I
		//IL_006e: Expected I, but got Obj
		//IL_00bb: Expected I, but got Obj
		//IL_00d1: Expected Obj, but got I
		//IL_018a: Expected I, but got Obj
		//IL_051a: Expected Obj, but got I4
		//IL_00fc: Expected I, but got Obj
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Expected Obj, but got Unknown
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Expected Obj, but got Unknown
		//IL_02e6: Expected Obj, but got I4
		//IL_0645: Expected I, but got Obj
		//IL_065b: Expected Obj, but got I
		//IL_034d: Expected Obj, but got I
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Expected Obj, but got Unknown
		//IL_0405: Expected I, but got Obj
		//IL_0383: Unknown result type (might be due to invalid IL or missing references)
		//IL_0388: Expected Obj, but got Unknown
		//IL_027a: Expected Obj, but got I4
		//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03be: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - -64;
		object obj3 = obj2 + 40;
		obj3 = 0;
		_ = 0;
		_ = 0;
		object obj4 = obj2 + 24;
		obj4 = 0;
		object obj5 = obj2 + 32;
		obj5 = obj;
		_ = -1;
		nint num = (nint)typeof(EventsSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v21 (Il2CppClass<Data.Save.EventsSave>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num2 = (nint)typeof(EventsSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v133 (Il2CppClass<Data.Save.EventsSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string wordHuntDailyWord = EventsSave.wordHuntDailyWord;
		nint num3 = (nint)typeof(WeeklyHuntData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S1_v15 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num4 = (nint)typeof(WeeklyHuntData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S1_v92 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (WeeklyHuntManager.GetPeriodStatus((PrizePeriodId)wordHuntDailyWord.m_stringLength) != PeriodStatus.Unstarted)
		{
			nint num5 = (nint)typeof(WeeklyHuntData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v123 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num6 = (nint)typeof(WeeklyHuntData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v129 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			ApplyDebugTimeOffset();
			((WeeklyHuntIconPositioning)1).ForceUpdate();
			return;
		}
		nint num7 = (nint)typeof(WeeklyHuntData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v34 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num8 = (nint)typeof(WeeklyHuntData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v116 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @759C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
		_ = 0;
		object obj10 = default;
		object obj12 = default;
		object obj13 = default;
		object obj15 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj10 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			object obj11 = obj12 - 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj13 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				object obj14 = obj15;
			}
			else
			{
				object obj14 = 0;
			}
		}
		object obj16 = obj5 + 4;
		object obj17 = obj16 + 1;
		obj16 = obj17;
		object obj18 = obj17 << 2;
		object obj19 = obj5 + obj18;
		obj19 = 116;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
			object obj20 = (nint)0 << 2;
			object obj21 = obj5 + obj20;
			if ((nint)obj21 == 116)
			{
				object obj22 = obj5 + 4;
				if ((nint)obj22 > -1)
				{
					object obj23 = obj22 + -1;
					obj22 = obj23;
				}
				goto IL_0637;
			}
		}
		object obj24 = default;
		if (obj24 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0637;
		IL_0637:
		nint num9 = (nint)typeof(WeeklyHuntData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ S0_v56 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+BA]");
		object obj25 = (nint)0 & (nint)0x200;
		if (obj25 != null)
		{
			nint num10 = (nint)typeof(WeeklyHuntData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ S0_v61 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		FlurryLogPreviousUpdatesWeeklyHuntPeriodProgress();
	}

	private static void FlurryLogPreviousUpdatesWeeklyHuntPeriodProgress()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0db6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dbb: Expected Obj, but got Unknown
		//IL_0dc4: Expected Obj, but got I4
		//IL_0dd9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dde: Expected Obj, but got Unknown
		//IL_0de7: Expected Obj, but got I4
		//IL_0df0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df5: Expected Obj, but got Unknown
		//IL_0e11: Expected I, but got Obj
		//IL_0e27: Expected Obj, but got I
		//IL_0f29: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f2e: Expected Obj, but got Unknown
		//IL_0f37: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f3c: Expected Obj, but got Unknown
		//IL_0f45: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f4a: Expected Obj, but got Unknown
		//IL_0021: Expected I, but got Obj
		//IL_009f: Expected Obj, but got I4
		//IL_057d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0582: Expected Obj, but got Unknown
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected Obj, but got Unknown
		//IL_013c: Expected I, but got Obj
		//IL_0152: Expected Obj, but got I
		//IL_017d: Expected I, but got Obj
		//IL_0d03: Expected Obj, but got I
		//IL_0d39: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d3e: Expected Obj, but got Unknown
		//IL_029d: Expected I, but got Obj
		//IL_02b3: Expected Obj, but got I
		//IL_0d6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d74: Expected Obj, but got Unknown
		//IL_0e63: Expected Obj, but got I
		//IL_0e88: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e8d: Expected Obj, but got Unknown
		//IL_0e9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e9f: Expected Obj, but got Unknown
		//IL_02de: Expected I, but got Obj
		//IL_0400: Expected I, but got Obj
		//IL_0416: Expected Obj, but got I
		//IL_037e: Expected I, but got Obj
		//IL_0394: Expected Obj, but got I
		//IL_0441: Expected I, but got Obj
		//IL_03bf: Expected I, but got Obj
		//IL_04cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d2: Expected Obj, but got Unknown
		//IL_04fd: Expected I, but got Obj
		//IL_0513: Expected Obj, but got I
		//IL_053f: Expected I, but got Obj
		//IL_0c3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c43: Expected Obj, but got Unknown
		//IL_0c4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c51: Expected Obj, but got Unknown
		//IL_0c7d: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 96;
		object obj3 = obj2 - -64;
		obj3 = 0;
		_ = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = 0;
		object obj5 = obj2 + 56;
		obj5 = obj;
		_ = -1;
		nint num = (nint)typeof(WeeklyHuntData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v21 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num2 = (nint)typeof(WeeklyHuntData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v278 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj7 = obj2 + 24;
		object obj8 = obj2 + 8;
		object obj9 = obj2 + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @759C");
		obj3 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v30+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v30+10]");
		_ = 0;
		object obj10 = default;
		object obj12 = default;
		object obj14 = default;
		object obj15 = default;
		object obj17 = default;
		object obj19 = default;
		object obj23 = default;
		object obj27 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj10 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj4 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			object obj11 = obj12 - 1;
			nint num3 = (nint)typeof(EventsSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ S0_v133 (Il2CppClass<Data.Save.EventsSave>)+BA]");
			object obj13 = (nint)0 & (nint)0x200;
			if (obj13 != null)
			{
				nint num4 = (nint)typeof(EventsSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v484 @ S0_v266 (Il2CppClass<Data.Save.EventsSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj14 == null)
			{
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj15 != null)
			{
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D9");
			object obj16 = obj17 << 32;
			object obj18 = obj19 | obj16;
			nint num5 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v566 @ S0_v166 (Il2CppClass<System.DateTime>)+BA]");
			object obj20 = (nint)0 & (nint)0x200;
			if (obj20 != null)
			{
				nint num6 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ S0_v255 (Il2CppClass<System.DateTime>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ S0_v123+20]");
			obj8 = 0;
			obj2 = obj18;
			obj7 = obj8;
			obj9 = obj2;
			object obj21 = obj7 & 0x3FFFFFFFFFFFFFFFL;
			object obj22 = obj9 & 0x3FFFFFFFFFFFFFFFL;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj21) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj22))
			{
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
			if ((nint)obj23 == 4)
			{
				nint num7 = (nint)typeof(WeeklyHuntData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v617 @ S0_v238 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+BA]");
				object obj24 = (nint)0 & (nint)0x200;
				if (obj24 != null)
				{
					nint num8 = (nint)typeof(WeeklyHuntData);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v635 @ S0_v245 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				if (hideLastPeriod)
				{
					continue;
				}
			}
			nint num9 = (nint)typeof(EventsSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v629 @ S0_v188 (Il2CppClass<Data.Save.EventsSave>)+BA]");
			object obj25 = (nint)0 & (nint)0x200;
			if (obj25 != null)
			{
				nint num10 = (nint)typeof(EventsSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v642 @ S0_v230 (Il2CppClass<Data.Save.EventsSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			obj9 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			object obj26 = obj27 + 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			nint num11 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v706 @ S0_v216 (Il2CppClass<Flurry>)+BA]");
			object obj28 = (nint)0 & (nint)0x200;
			if (obj28 != null)
			{
				nint num12 = (nint)typeof(Flurry);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v708 @ S0_v219 (Il2CppClass<Flurry>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
		}
		object obj29 = 64;
		object obj30 = obj29 - 14;
		object obj33;
		object obj31;
		if ((nint)obj29 != 14 && (nint)obj30 != 1 && (nint)obj30 != 2 && (nint)obj30 != 3)
		{
			if ((nint)obj30 != 4 && (nint)obj30 != 5 && (nint)obj30 != 6 && (nint)obj30 != 7)
			{
				if ((nint)obj30 == 8 || (nint)obj30 == 9)
				{
					goto IL_0c82;
				}
				if ((nint)obj30 != 10 && (nint)obj30 != 11 && (nint)obj30 != 12)
				{
					if ((nint)obj30 != 13)
					{
						if ((nint)obj30 == 14 || (nint)obj30 == 15 || (nint)obj30 == 16 || (nint)obj30 == 17)
						{
							goto IL_0f8f;
						}
						if ((nint)obj30 != 18)
						{
							if ((nint)obj30 == 19 || (nint)obj30 == 20 || (nint)obj30 == 21)
							{
								goto IL_0f8f;
							}
							if ((nint)obj30 != 22)
							{
								if ((nint)obj30 == 23 || (nint)obj30 == 24 || (nint)obj30 == 25 || (nint)obj30 == 26)
								{
									goto IL_0f8f;
								}
								if ((nint)obj30 != 27)
								{
									if ((nint)obj30 == 28 || (nint)obj30 == 29 || (nint)obj30 == 30 || (nint)obj30 == 31 || (nint)obj30 == 32 || (nint)obj30 == 33 || (nint)obj30 == 34 || (nint)obj30 == 35 || (nint)obj30 == 36 || (nint)obj30 == 37 || (nint)obj30 == 38)
									{
										goto IL_0f8f;
									}
									if ((nint)obj30 != 39)
									{
										if ((nint)obj30 != 40 && (nint)obj30 != 41 && (nint)obj30 != 42)
										{
											if ((nint)obj30 != 43 && (nint)obj30 != 44 && (nint)obj30 != 45 && (nint)obj30 != 46)
											{
												if ((nint)obj30 == 47)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
													object obj32 = default;
													obj31 = obj32;
													obj33 = obj17;
													goto IL_0eea;
												}
												if ((nint)obj30 != 48 && (nint)obj30 != 49 && (nint)obj30 == 50)
												{
													object obj34 = obj5 + 4;
													object obj35 = obj34 + 1;
													obj34 = obj35;
													object obj36 = obj35 << 2;
													object obj37 = obj5 + obj36;
													obj37 = 191;
												}
											}
											goto IL_0f8f;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
										object obj38 = default;
										obj31 = obj38;
										obj33 = obj17;
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
										object obj39 = default;
										obj31 = obj39;
										obj33 = obj17;
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
									object obj40 = default;
									obj31 = obj40;
									obj33 = obj17;
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
								object obj41 = default;
								obj31 = obj41;
								obj33 = obj17;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
							object obj42 = default;
							obj31 = obj42;
							obj33 = obj17;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
						object obj43 = default;
						obj31 = obj43;
						obj33 = obj17;
					}
					goto IL_0eea;
				}
			}
			goto IL_0f8f;
		}
		goto IL_0c82;
		IL_0eea:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj44 = default;
		if (obj33 == obj44)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
		goto IL_0f8f;
		IL_0c82:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		object obj45 = default;
		obj31 = obj45;
		obj33 = obj17;
		goto IL_0eea;
		IL_0f8f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
			object obj46 = (nint)0 << 2;
			object obj47 = obj5 + obj46;
			if ((nint)obj47 == 191)
			{
				object obj48 = obj5 + 4;
				if ((nint)obj48 > -1)
				{
					object obj49 = obj48 + -1;
					obj48 = obj49;
				}
				return;
			}
		}
		object obj50 = default;
		if (obj50 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	private static void ApplyDebugTimeOffset()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0b24: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b29: Expected Obj, but got Unknown
		//IL_0b32: Expected Obj, but got I4
		//IL_0b47: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4c: Expected Obj, but got Unknown
		//IL_0b55: Expected Obj, but got I4
		//IL_0b5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b63: Expected Obj, but got Unknown
		//IL_0b6c: Expected Obj, but got I4
		//IL_0b75: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b7a: Expected Obj, but got Unknown
		//IL_0b96: Expected I, but got Obj
		//IL_0bac: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_0095: Expected I, but got Obj
		//IL_00ab: Expected Obj, but got I
		//IL_0bf9: Expected I, but got Obj
		//IL_0c0f: Expected Obj, but got I
		//IL_00d6: Expected I, but got Obj
		//IL_0123: Expected I, but got Obj
		//IL_01a1: Expected Obj, but got I4
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Expected Obj, but got Unknown
		//IL_044c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0451: Expected Obj, but got Unknown
		//IL_0278: Expected Obj, but got I4
		//IL_0c70: Expected I, but got Obj
		//IL_0c86: Expected Obj, but got I
		//IL_02ea: Expected I, but got Obj
		//IL_0a86: Expected Obj, but got I
		//IL_0ac4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac9: Expected Obj, but got Unknown
		//IL_03cf: Expected I, but got Obj
		//IL_03e5: Expected Obj, but got I
		//IL_0afa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aff: Expected Obj, but got Unknown
		//IL_0410: Expected I, but got Obj
		//IL_09c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c6: Expected Obj, but got Unknown
		//IL_09cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d4: Expected Obj, but got Unknown
		//IL_0a00: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 80;
		object obj3 = obj2 + 48;
		obj3 = 0;
		_ = 0;
		_ = 0;
		object obj4 = obj2 + 24;
		obj4 = 0;
		object obj5 = obj2 + 40;
		obj5 = 0;
		object obj6 = obj2 + 32;
		obj6 = obj;
		_ = -1;
		nint num = (nint)typeof(EventsSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v23 (Il2CppClass<Data.Save.EventsSave>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num2 = (nint)typeof(EventsSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v247 (Il2CppClass<Data.Save.EventsSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string wordHuntDailyWord = EventsSave.wordHuntDailyWord;
		WeeklyHuntProgressData weeklyHuntProgressData = EventsSave.weeklyHuntProgressData;
		if (weeklyHuntProgressData != null && weeklyHuntProgressData.huntStartVersion != null)
		{
			return;
		}
		nint num3 = (nint)typeof(EventsSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v36 (Il2CppClass<Data.Save.EventsSave>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num4 = (nint)typeof(EventsSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v239 (Il2CppClass<Data.Save.EventsSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string weeklyHuntProgressVersion = EventsSave.weeklyHuntProgressVersion;
		nint num5 = (nint)typeof(WeeklyHuntData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S0_v43 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num6 = (nint)typeof(WeeklyHuntData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S0_v233 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @759C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
		_ = 0;
		object obj10 = default;
		object obj12 = default;
		object obj13 = default;
		object obj14 = default;
		object obj15 = default;
		object obj16 = default;
		object obj18 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj10 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			object obj11 = obj12 - 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj13 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				if (obj14 != null)
				{
					continue;
				}
			}
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj15 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				obj5 = obj16;
			}
			nint num7 = (nint)typeof(EventsSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ S0_v156 (Il2CppClass<Data.Save.EventsSave>)+BA]");
			object obj17 = (nint)0 & (nint)0x200;
			if (obj17 != null)
			{
				nint num8 = (nint)typeof(EventsSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v523 @ S0_v206 (Il2CppClass<Data.Save.EventsSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			obj2 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			nint num9 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v592 @ S0_v191 (Il2CppClass<Flurry>)+BA]");
			object obj19 = (nint)0 & (nint)0x200;
			if (obj19 != null)
			{
				nint num10 = (nint)typeof(Flurry);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v594 @ S0_v194 (Il2CppClass<Flurry>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
		}
		object obj20 = 56;
		object obj21 = obj20 - 18;
		object obj24;
		object obj25 = default;
		if ((nint)obj20 != 18 && (nint)obj21 != 1 && (nint)obj21 != 2)
		{
			if ((nint)obj21 == 3 || (nint)obj21 == 4 || (nint)obj21 == 5)
			{
				goto IL_0d48;
			}
			if ((nint)obj21 != 6)
			{
				if ((nint)obj21 == 7 || (nint)obj21 == 8)
				{
					goto IL_0d48;
				}
				if ((nint)obj21 != 9)
				{
					if ((nint)obj21 == 10 || (nint)obj21 == 11 || (nint)obj21 == 12 || (nint)obj21 == 13 || (nint)obj21 == 14)
					{
						goto IL_0d48;
					}
					if ((nint)obj21 != 15)
					{
						if ((nint)obj21 != 16)
						{
							if ((nint)obj21 == 17 || (nint)obj21 == 18 || (nint)obj21 == 19 || (nint)obj21 == 20 || (nint)obj21 == 21 || (nint)obj21 == 22 || (nint)obj21 == 23 || (nint)obj21 == 24)
							{
								goto IL_0d48;
							}
							if ((nint)obj21 != 25)
							{
								if ((nint)obj21 != 26)
								{
									object obj22;
									if ((nint)obj21 != 27 && (nint)obj21 != 28 && (nint)obj21 != 29)
									{
										if ((nint)obj21 != 30 && (nint)obj21 != 31 && (nint)obj21 != 32 && (nint)obj21 != 33 && (nint)obj21 != 34)
										{
											if ((nint)obj21 == 35)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
												object obj23 = default;
												obj22 = obj23;
												obj24 = obj25;
												goto IL_0ca8;
											}
											if ((nint)obj21 != 36 && (nint)obj21 != 37 && (nint)obj21 == 38)
											{
												object obj26 = obj6 + 4;
												object obj27 = obj26 + 1;
												obj26 = obj27;
												object obj28 = obj27 << 2;
												object obj29 = obj6 + obj28;
												obj29 = 169;
											}
										}
										goto IL_0d48;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
									object obj30 = default;
									obj22 = obj30;
									obj24 = obj25;
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
									object obj31 = default;
									object obj22 = obj31;
									obj24 = obj25;
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
								object obj32 = default;
								object obj22 = obj32;
								obj24 = obj25;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
							object obj33 = default;
							object obj22 = obj33;
							obj24 = obj25;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
						object obj34 = default;
						object obj22 = obj34;
						obj24 = obj25;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
					object obj35 = default;
					object obj22 = obj35;
					obj24 = obj25;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
				object obj36 = default;
				object obj22 = obj36;
				obj24 = obj25;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			object obj37 = default;
			object obj22 = obj37;
			obj24 = obj25;
		}
		goto IL_0ca8;
		IL_0ca8:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj38 = default;
		if (obj24 == obj38)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
		goto IL_0d48;
		IL_0d48:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v20+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v20+4]");
			object obj39 = (nint)0 << 2;
			object obj40 = obj6 + obj39;
			if ((nint)obj40 == 169)
			{
				object obj41 = obj6 + 4;
				if ((nint)obj41 > -1)
				{
					object obj42 = obj41 + -1;
					obj41 = obj42;
				}
				return;
			}
		}
		object obj43 = default;
		if (obj43 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	public unsafe static void DebugJumpToWeek(int period, int additionalOffset)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03db: Expected Obj, but got Unknown
		//IL_03e4: Expected Obj, but got I4
		//IL_03f2: Expected I, but got Obj
		//IL_0408: Expected Obj, but got I
		//IL_0621: Expected I, but got Obj
		//IL_0637: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_042e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0433: Expected I4, but got Unknown
		//IL_043c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0441: Expected Obj, but got Unknown
		//IL_0458: Expected Obj, but got I4
		//IL_015c: Expected I, but got Obj
		//IL_0172: Expected Obj, but got I
		//IL_0081: Expected I, but got Obj
		//IL_04dc: Invalid comparison between VT and I4
		//IL_00ce: Expected I, but got Obj
		//IL_00e4: Expected Obj, but got I
		//IL_021e: Expected I, but got Obj
		//IL_0234: Expected Obj, but got I
		//IL_019d: Expected I, but got Obj
		//IL_048a: Expected I4, but got Obj
		//IL_0494: Expected VT, but got I4
		//IL_049d: Expected Obj, but got I4
		//IL_04a6: Expected Obj, but got I4
		//IL_04bb: Expected I4, but got Obj
		//IL_050c: Expected Obj, but got I8
		//IL_01e5: Expected VT, but got Obj
		//IL_01f4: Expected Obj, but got I4
		//IL_01f4: Expected Obj, but got VT
		//IL_010f: Expected I, but got Obj
		//IL_02a6: Expected Obj, but got VT
		//IL_02be: Expected I, but got Obj
		//IL_02d4: Expected Obj, but got I
		//IL_025f: Expected I, but got Obj
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0532: Expected Obj, but got Unknown
		//IL_0543: Expected Obj, but got VT
		//IL_054c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0551: Expected Obj, but got Unknown
		//IL_0566: Expected I4, but got Obj
		//IL_0573: Unknown result type (might be due to invalid IL or missing references)
		//IL_0578: Expected Obj, but got Unknown
		//IL_058f: Expected I4, but got I8
		//IL_02ff: Expected I, but got Obj
		//IL_034c: Expected I, but got Obj
		//IL_0362: Expected Obj, but got I
		//IL_05ce: Expected I4, but got Obj
		//IL_05ec: Expected I4, but got Obj
		//IL_038d: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 8;
		obj3 = 0;
		nint num = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (Il2CppClass<Globals>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v132 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(Globals.DEBUG_USE_DEBUG_DAILYWORD ? 1u : 0u) == 0)
		{
			int num4 = default;
			int num3 = num4 + 1;
		}
		nint num5 = (nint)typeof(EventsSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v20 (Il2CppClass<Data.Save.EventsSave>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num6 = (nint)typeof(EventsSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v124 (Il2CppClass<Data.Save.EventsSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num7 = obj2 + 32;
		object obj6 = obj2 + 40;
		bool wordHuntPayedOut = EventsSave.wordHuntPayedOut;
		if (!string.Equals((string)wordHuntPayedOut, "Day"))
		{
			nint num8 = (nint)typeof(EventsSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v103 (Il2CppClass<Data.Save.EventsSave>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num9 = (nint)typeof(EventsSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v120 (Il2CppClass<Data.Save.EventsSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			EventsSave.wordHuntPayedOut = (byte)(int)"Day" != 0;
			EventsSave.wordHuntUnlockedMask = (IntMask)0;
			obj = 0;
			obj = 0;
			obj6 = obj;
			((int*)num7)->m_value = (int)obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9211");
		}
		nint num10 = (nint)typeof(EventsSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v34 (Il2CppClass<Data.Save.EventsSave>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num11 = (nint)typeof(EventsSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S0_v98 (Il2CppClass<Data.Save.EventsSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		IntMask wordHuntUnlockedMask = EventsSave.wordHuntUnlockedMask;
		if (wordHuntUnlockedMask == (IntMask)(object)0)
		{
			_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
			((PickupManager)val).PickupSpawnPoint_OnPickupSpawned((PickupSpawnPoint)2, (PickerData)null);
			AndroidIncomingCallBridge androidIncomingCallBridge = AndroidIncomingCallBridge.CreatePlugin();
			((DailyLetterPickupManager)(object)androidIncomingCallBridge)._002Ector();
		}
		nint num12 = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S0_v43 (Il2CppClass<System.DateTime>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num13 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S0_v89 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		long systemTimeAsFileTime = DateTime.GetSystemTimeAsFileTime();
		obj3 = systemTimeAsFileTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCA5");
		DateTime today = CDateTime.Today;
		obj3 = today;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCA5");
		nint num14 = (nint)typeof(EventsSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ S0_v54 (Il2CppClass<Data.Save.EventsSave>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num15 = (nint)typeof(EventsSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ S0_v85 (Il2CppClass<Data.Save.EventsSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj11 = obj2 + 16;
		TimeSpan wordHuntTimeLeft = EventsSave.wordHuntTimeLeft;
		obj3 = wordHuntTimeLeft;
		object obj12 = obj2 + 24;
		object obj13 = default;
		obj12 = obj13;
		((int*)num7)->m_value = (int)obj12;
		object obj14 = obj3 & 0x3FFFFFFFFFFFFFFFL;
		int num16 = (int)(((int*)num7)->m_value & 0x3FFFFFFFFFFFFFFFL);
		if ((nint)obj14 == num16)
		{
			return;
		}
		nint num17 = (nint)typeof(EventsSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ S0_v71 (Il2CppClass<Data.Save.EventsSave>)+BA]");
		object obj15 = (nint)0 & (nint)0x200;
		if (obj15 != null)
		{
			nint num18 = (nint)typeof(EventsSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ S0_v81 (Il2CppClass<Data.Save.EventsSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj11 = obj13;
		((int*)num7)->m_value = (int)obj11;
		EventsSave.wordHuntWordsInRow = num7;
		object obj16 = default;
		obj2 = obj16;
		((int*)num7)->m_value = (int)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11225");
	}

	public unsafe static void DebugSetProgress(int period, int progress)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0498: Unknown result type (might be due to invalid IL or missing references)
		//IL_049d: Expected Obj, but got Unknown
		//IL_04a6: Expected Obj, but got I4
		//IL_04af: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b4: Expected Obj, but got Unknown
		//IL_04bd: Expected Obj, but got I4
		//IL_04c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cb: Expected Obj, but got Unknown
		//IL_04d4: Expected Obj, but got I4
		//IL_04e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ee: Expected Obj, but got Unknown
		//IL_04f7: Expected Obj, but got I4
		//IL_0500: Unknown result type (might be due to invalid IL or missing references)
		//IL_0505: Expected Obj, but got Unknown
		//IL_0530: Expected I, but got Obj
		//IL_0546: Expected Obj, but got I
		//IL_0582: Expected Obj, but got VT
		//IL_05d6: Expected I, but got Obj
		//IL_05ec: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_0636: Unknown result type (might be due to invalid IL or missing references)
		//IL_063b: Expected Obj, but got Unknown
		//IL_064c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0651: Expected Obj, but got Unknown
		//IL_0659: Expected Obj, but got VT
		//IL_0662: Unknown result type (might be due to invalid IL or missing references)
		//IL_0667: Expected VT, but got Unknown
		//IL_0674: Expected I8, but got Obj
		//IL_066f: Expected native int or pointer, but got VT
		//IL_067d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0682: Expected Obj, but got Unknown
		//IL_0697: Expected Ref, but got VT
		//IL_06a3: Expected Obj, but got I8
		//IL_06c5: Expected I, but got Obj
		//IL_06db: Expected Obj, but got I
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_0721: Unknown result type (might be due to invalid IL or missing references)
		//IL_0726: Expected Obj, but got Unknown
		//IL_0742: Expected I, but got Obj
		//IL_0758: Expected Obj, but got I
		//IL_00fc: Expected I, but got Obj
		//IL_0628: Expected Obj, but got VT
		//IL_077e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0783: Expected Obj, but got Unknown
		//IL_0149: Expected I, but got Obj
		//IL_00af: Expected I, but got Obj
		//IL_0196: Expected I, but got Obj
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Expected Obj, but got Unknown
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_0305: Expected Obj, but got Unknown
		//IL_0331: Expected Obj, but got I4
		//IL_020e: Expected Obj, but got I8
		//IL_0857: Expected I, but got Obj
		//IL_086d: Expected Obj, but got I
		//IL_0398: Expected Obj, but got I
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Expected Obj, but got Unknown
		//IL_0450: Expected I, but got Obj
		//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Expected Obj, but got Unknown
		//IL_0404: Unknown result type (might be due to invalid IL or missing references)
		//IL_0409: Expected Obj, but got Unknown
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 128;
		object obj3 = obj2 + 48;
		obj3 = 0;
		object obj4 = obj2 + 40;
		obj4 = 0;
		object obj5 = obj2 + 96;
		obj5 = 0;
		_ = 0;
		_ = 0;
		object obj6 = obj2 + 32;
		obj6 = 0;
		object obj7 = obj2 + 88;
		obj7 = obj;
		_ = -1;
		string text = PlayerPrefs.GetString("WEEKLY_HUNT_TIME_OFFSET", null);
		nint num = (nint)typeof(WeeklyHuntData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v28 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num2 = (nint)typeof(WeeklyHuntData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v182 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		WeeklyHuntPeriodData weeklyHuntPeriodData = _huntPeriodData.get_Item(period);
		obj3 = weeklyHuntPeriodData.periodStartDate;
		if (progress <= -1)
		{
			nint num3 = (nint)typeof(WeeklyHuntData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v171 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num4 = (nint)typeof(WeeklyHuntData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v176 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			WeeklyHuntPeriodData weeklyHuntPeriodData2 = _huntPeriodData.get_Item(period);
			obj3 = weeklyHuntPeriodData2.periodEndDate;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCA5");
		object obj10 = default;
		obj3 = obj10;
		DateTime today = CDateTime.Today;
		nint num5 = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S0_v40 (Il2CppClass<System.DateTime>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num6 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S0_v166 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj12 = obj2 + 24;
		obj12 = obj10;
		object obj13 = obj2 + 16;
		obj13 = today;
		DateTime dateTime = (DateTime)(obj2 + 56);
		((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj12;
		IFormatProvider formatProvider = (IFormatProvider)(obj2 - -64);
		formatProvider = (IFormatProvider)obj13;
		long num7 = ((DateTime*)dateTime)->System_002EIConvertible_002EToInt64(formatProvider);
		obj4 = num7;
		double num8 = (double)obj4 * 1E-07;
		nint num9 = (nint)typeof(Convert);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ S0_v57 (Il2CppClass<System.Convert>)+BA]");
		object obj14 = (nint)0 & (nint)0x200;
		if (obj14 != null)
		{
			nint num10 = (nint)typeof(Convert);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ S0_v162 (Il2CppClass<System.Convert>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		double value = -1.0 * num8;
		uint num11 = Convert.ToUInt32(value);
		string value2 = num11 + text;
		PlayerPrefs.SetString("WEEKLY_HUNT_TIME_OFFSET", value2);
		nint num12 = (nint)typeof(WeeklyHuntData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ S0_v67 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+BA]");
		object obj15 = (nint)0 & (nint)0x200;
		if (obj15 != null)
		{
			nint num13 = (nint)typeof(WeeklyHuntData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ S0_v156 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj16 = obj2 + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @759C");
		obj5 = formatProvider;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ S0_v51 (System.IFormatProvider)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ S0_v51 (System.IFormatProvider)+10]");
		_ = 0;
		object obj17 = default;
		object obj19 = default;
		object obj21 = default;
		object obj23 = default;
		object obj25 = default;
		object obj28 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj17 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj6 = dateTime.dateData;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			object obj18 = obj19 + 24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1DA");
			object obj20 = obj21 << 32;
			object obj22 = obj23 | obj20;
			obj16 = obj22;
			formatProvider = (IFormatProvider)obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			object obj24 = obj25 + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1DA");
			object obj26 = obj21 << 32;
			object obj27 = obj28 | obj26;
			obj2 = obj27;
			formatProvider = (IFormatProvider)obj2;
		}
		object obj29 = obj7 + 4;
		object obj30 = obj29 + 1;
		obj29 = obj30;
		object obj31 = obj30 << 2;
		object obj32 = obj7 + obj31;
		obj32 = 218;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v22+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v22+4]");
			object obj33 = (nint)0 << 2;
			object obj34 = obj7 + obj33;
			if ((nint)obj34 == 218)
			{
				object obj35 = obj7 + 4;
				if ((nint)obj35 > -1)
				{
					object obj36 = obj35 + -1;
					obj35 = obj36;
				}
				goto IL_0844;
			}
		}
		object obj37 = default;
		if (obj37 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0844;
		IL_0844:
		RenderPipelineManager.CleanupRenderPipeline();
		nint num14 = (nint)typeof(WeeklyHuntData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ S0_v93 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+BA]");
		object obj38 = (nint)0 & (nint)0x200;
		if (obj38 != null)
		{
			nint num15 = (nint)typeof(WeeklyHuntData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ S0_v99 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((WeeklyHuntIconPositioning)null).ForceUpdate();
	}

	public static void DebugResetWeeklyHuntData()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Expected Obj, but got Unknown
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Expected Obj, but got Unknown
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Expected Obj, but got Unknown
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Expected Obj, but got Unknown
		//IL_0335: Expected Obj, but got I4
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Expected Obj, but got Unknown
		//IL_0358: Expected Obj, but got I4
		//IL_0361: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Expected Obj, but got Unknown
		//IL_0021: Expected I, but got Obj
		//IL_0037: Expected Obj, but got I
		//IL_0062: Expected I, but got Obj
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected Obj, but got Unknown
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected Obj, but got Unknown
		//IL_01f8: Expected Obj, but got I4
		//IL_025f: Expected Obj, but got I
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected Obj, but got Unknown
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Expected Obj, but got Unknown
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Expected Obj, but got Unknown
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 96;
		object obj3 = obj2 + 32;
		object obj4 = obj2 + 8;
		object obj5 = obj2 + 16;
		object obj6 = obj2 - -64;
		obj6 = 0;
		_ = 0;
		_ = 0;
		object obj7 = obj2 + 24;
		obj7 = 0;
		object obj8 = obj2 + 56;
		obj8 = obj;
		_ = -1;
		string text = PlayerPrefs.GetString("WEEKLY_HUNT_TIME_OFFSET", null);
		if (text == null)
		{
			return;
		}
		nint num = (nint)typeof(WeeklyHuntData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v32 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num2 = (nint)typeof(WeeklyHuntData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v106 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @759C");
		obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+10]");
		_ = 0;
		object obj10 = default;
		object obj12 = default;
		object obj14 = default;
		object obj16 = default;
		object obj18 = default;
		object obj21 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj10 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj7 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			object obj11 = obj12 + 24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1DA");
			object obj13 = obj14 << 32;
			object obj15 = obj16 | obj13;
			obj5 = obj15;
			obj3 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			object obj17 = obj18 + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1DA");
			object obj19 = obj14 << 32;
			object obj20 = obj21 | obj19;
			obj2 = obj20;
			obj3 = obj2;
		}
		object obj22 = obj8 + 4;
		object obj23 = obj22 + 1;
		obj22 = obj23;
		object obj24 = obj23 << 2;
		object obj25 = obj8 + obj24;
		obj25 = 123;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v24+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v24+4]");
			object obj26 = (nint)0 << 2;
			object obj27 = obj8 + obj26;
			if ((nint)obj27 == 123)
			{
				object obj28 = obj8 + 4;
				if ((nint)obj28 > -1)
				{
					object obj29 = obj28 + -1;
					obj28 = obj29;
				}
				return;
			}
		}
		object obj30 = default;
		if (obj30 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	public static PrizePeriodId GetActivePeriod()
	{
		//IL_017c: Expected I, but got Obj
		//IL_0192: Expected Obj, but got I
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_01bf: Expected I4, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_012f: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(WeeklyHuntData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(WeeklyHuntData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v39 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(_hasInited ? 1u : 0u) != 0)
		{
			nint num3 = (nint)typeof(WeeklyHuntData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v30 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(WeeklyHuntData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v35 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			LoadProgressFromResources();
		}
		nint num5 = (nint)typeof(WeeklyHuntData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v16 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(WeeklyHuntData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v23 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (PrizePeriodId)_huntPeriodData;
	}

	static WeeklyHuntData()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0531: Unknown result type (might be due to invalid IL or missing references)
		//IL_0536: Expected Obj, but got Unknown
		//IL_053f: Expected Obj, but got I4
		//IL_0554: Unknown result type (might be due to invalid IL or missing references)
		//IL_0559: Expected Obj, but got Unknown
		//IL_0562: Expected Obj, but got I4
		//IL_056b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0570: Expected Obj, but got Unknown
		//IL_059b: Expected I, but got Obj
		//IL_05b1: Expected Obj, but got I
		//IL_05d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05dc: Expected Obj, but got Unknown
		//IL_05e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ea: Expected Obj, but got Unknown
		//IL_05f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f8: Expected Obj, but got Unknown
		//IL_0667: Expected Obj, but got I4
		//IL_0021: Expected I, but got Obj
		//IL_0078: Expected Obj, but got I4
		//IL_0632: Unknown result type (might be due to invalid IL or missing references)
		//IL_0637: Expected Obj, but got Unknown
		//IL_0099: Expected Obj, but got I4
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected Obj, but got Unknown
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected Obj, but got Unknown
		//IL_06f0: Expected I, but got Obj
		//IL_0706: Expected Obj, but got I
		//IL_0431: Expected Obj, but got I
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected Obj, but got Unknown
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected Obj, but got Unknown
		//IL_04e9: Expected I, but got Obj
		//IL_0467: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Expected Obj, but got Unknown
		//IL_049d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a2: Expected Obj, but got Unknown
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0390: Expected Obj, but got Unknown
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Expected Obj, but got Unknown
		//IL_03ca: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 96;
		object obj3 = obj2 - -64;
		obj3 = 0;
		_ = 0;
		_ = 0;
		object obj4 = obj2 + 24;
		obj4 = 0;
		object obj5 = obj2 + 56;
		obj5 = obj;
		_ = -1;
		string text = PlayerPrefs.GetString("WEEKLY_HUNT_TIME_OFFSET", null);
		nint num = (nint)typeof(WeeklyHuntData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v24 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num2 = (nint)typeof(WeeklyHuntData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v138 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj7 = obj2 + 8;
		object obj8 = obj2 + 16;
		object obj9 = obj2 + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @759C");
		obj3 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v33+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v33+10]");
		_ = 0;
		object obj11 = default;
		object obj10;
		object obj13 = default;
		object obj16 = default;
		object obj18 = default;
		object obj20 = default;
		object obj24 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			obj10 = 27;
			bool flag = obj11 == null;
			obj10 = 28;
			if (flag)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj10 = 18;
			obj4 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			object obj12 = obj13 + 24;
			object obj14 = text * -1;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1DA");
			object obj15 = obj16 << 32;
			object obj17 = obj18 | obj15;
			obj8 = obj17;
			obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			object obj19 = obj20 + 32;
			object obj21 = text * -1;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1DA");
			object obj22 = obj16 << 32;
			object obj23 = obj24 | obj22;
			obj2 = obj23;
			obj9 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			_ = 0;
		}
		object obj25 = obj10 - 18;
		object obj28;
		object obj26;
		if ((nint)obj10 != 18 && (nint)obj25 != 1 && (nint)obj25 != 2 && (nint)obj25 != 3 && (nint)obj25 != 4 && (nint)obj25 != 5 && (nint)obj25 != 6 && (nint)obj25 != 7)
		{
			if ((nint)obj25 != 8)
			{
				if ((nint)obj25 == 9)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
					object obj27 = default;
					obj26 = obj27;
					obj28 = obj16;
					goto IL_0671;
				}
				if ((nint)obj25 == 10)
				{
					object obj29 = obj5 + 4;
					object obj30 = obj29 + 1;
					obj29 = obj30;
					object obj31 = obj30 << 2;
					object obj32 = obj5 + obj31;
					obj32 = 137;
				}
			}
			goto IL_06b3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		object obj33 = default;
		obj26 = obj33;
		obj28 = obj16;
		goto IL_0671;
		IL_06b3:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
			object obj34 = (nint)0 << 2;
			object obj35 = obj5 + obj34;
			if ((nint)obj35 == 137)
			{
				object obj36 = obj5 + 4;
				if ((nint)obj36 > -1)
				{
					object obj37 = obj36 + -1;
					obj36 = obj37;
				}
				goto IL_06d8;
			}
		}
		object obj38 = default;
		if (obj38 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_06d8;
		IL_0671:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj39 = default;
		if (obj28 == obj39)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
		goto IL_06b3;
		IL_06d8:
		((PropertyAttribute)(object)"WEEKLY_HUNT_TIME_OFFSET")._002Ector();
		nint num3 = (nint)typeof(WeeklyHuntData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ S0_v58 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+BA]");
		object obj40 = (nint)0 & (nint)0x200;
		if (obj40 != null)
		{
			nint num4 = (nint)typeof(WeeklyHuntData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ S0_v65 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((WeeklyHuntIconPositioning)null).ForceUpdate();
		RenderPipelineManager.CleanupRenderPipeline();
	}
}
