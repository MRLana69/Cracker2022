using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace Missions;

public static class AwardsData
{
	private const string ICON_NAME_DIAMOND = "icon_gemstone";

	private const string ICON_NAME_GOLDBAR = "icon_goldbar";

	private const string ICON_NAME_CLOCK = "icon_classyclock";

	private const string ICON_NAME_DOLLAR = "icon_dollarchain";

	private const string ICON_NAME_SKULL = "icon_paperweight";

	private const string ICON_NAME_HEADPHONES = "icon_headphones";

	private const string ICON_NAME_PLATINUMRECORD = "icon_record";

	private const string ICON_NAME_CASSETTE = "icon_cassettetape";

	private static List<AwardId> trophyMissionsOrder;

	private static AwardStaticData[] _trophyMissionsData__BackingField;

	public static AwardStaticData[] _trophyMissionsData
	{
		get
		{
			return _trophyMissionsData__BackingField;
		}
		private set
		{
			_trophyMissionsData__BackingField = value;
		}
	}

	static AwardsData()
	{
		//IL_0117: Expected VT, but got Obj
		List<AwardId> list = default;
		list._002Ector();
		list.Add(AwardId.SCORE_POINTS_SINGLE_LANE);
		list.Add(AwardId.COMPLETE_HUNT_SINGLE_RUN_X_TIMES);
		list.Add(AwardId.OPEN_X_SUPER_MYSTERY_BOXES);
		list.Add(AwardId.COMPLETE_X_WORDY_WEEKEND_CHALLENGES_IN_ONE_WEEKEND);
		list.Add(AwardId.COMPLETE_X_WORDY_WEEKEND_CHALLENGES);
		list.Add(AwardId.SCORE_POINTS_SINGLE_RUN_NO_JUMP_OR_ROLL);
		list.Add(AwardId.OPEN_X_MYSTERY_BOXES);
		list.Add(AwardId.PICK_X_KEYS_INGAME);
		list.Add(AwardId.HAVE_SUPERSNICKERS_ACTIVE_X_MIN_IN_A_ROW);
		list.Add(AwardId.COMPLETE_MISSIONS_SINGLE_RUN);
		list.Add(AwardId.SCORE_POINTS_SINGLE_RUN_NO_COINS);
		list.Add(AwardId.PICKUP_POWERUPS);
		list.Add(AwardId.OWN_X_BOARDS);
		list.Add(AwardId.COMPLETE_DAILY_CHALLANGES_INROW);
		list.Add(AwardId.OWN_X_CHARACTERS);
		list.Add(AwardId.COMPLETE_X_MISSIONS);
		trophyMissionsOrder = list;
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(AwardId));
		string[] names = Enum.GetNames(typeFromHandle);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		AwardStaticData[] array = default;
		_trophyMissionsData__BackingField = array;
		AwardStaticData[] array2 = _trophyMissionsData__BackingField;
		_ = 0;
		_ = 0;
		_ = 256;
		_ = 1;
		_ = 0;
		_ = 1;
		_ = 1;
		_ = 0;
		_ = 993;
		_ = 0;
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v204 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<Missions.AwardTierType, Missions.AwardTier>>>)+4] (should have been resolved before IL gen)");
		_ = 12884901889L;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		_ = 0;
		_ = 1;
		_ = 1;
		_ = 3;
		throw new ArrayTypeMismatchException();
	}

	public static AwardStaticData[] GetAwardStaticDataList()
	{
		//IL_0093: Expected Obj, but got I4
		List<AwardId> list = trophyMissionsOrder;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		int num = 0;
		List<AwardId> list2 = trophyMissionsOrder;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S1_v13 (System.Collections.Generic.List`1<Missions.AwardId>)+C]");
		if ((nint)num >= (nint)0)
		{
			AwardStaticData[] result = default;
			return result;
		}
		AwardId awardId = trophyMissionsOrder.get_Item(num);
		object obj = (int)awardId << 2;
		object obj2 = (object)_trophyMissionsData__BackingField + obj;
		throw new ArrayTypeMismatchException();
	}

	public static AwardStaticData GetAwardStaticDataItem(int index)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Obj, but got Unknown
		//IL_0033: Expected Obj, but got I
		int num = index << 2;
		object obj = _trophyMissionsData__BackingField + num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v17+10]");
		return (AwardStaticData)0;
	}

	public static void ResetWordyWeekendChallengeOneWeekend()
	{
		//IL_00eb: Expected Obj, but got I4
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected Obj, but got Unknown
		//IL_0145: Expected Obj, but got I4
		AwardStaticData awardStaticDataItem = GetAwardStaticDataItem(22);
		PlayerInfo instance = PlayerInfo.Instance;
		Statistics stats = instance._stats;
		int[] values = stats._values;
		AwardTier awardTier = awardStaticDataItem.missionTiers__BackingField.get_Item(AwardTierType.Bronze);
		AwardGoal[] array = awardTier.listGoals__BackingField;
		AwardGoal awardGoal = array[0];
		AwardTier awardTier2 = awardStaticDataItem.missionTiers__BackingField.get_Item(AwardTierType.Silver);
		AwardGoal[] array2 = awardTier2.listGoals__BackingField;
		AwardGoal awardGoal2 = array2[0];
		AwardTier awardTier3 = awardStaticDataItem.missionTiers__BackingField.get_Item(AwardTierType.Gold);
		AwardGoal[] array3 = awardTier3.listGoals__BackingField;
		AwardGoal awardGoal3 = array3[0];
		object obj = awardGoal2.goal__BackingField + awardGoal3.goal__BackingField;
		object obj2 = awardGoal.goal__BackingField + obj;
		if (values[34] >= (nint)obj2)
		{
			return;
		}
		object obj3 = awardGoal.goal__BackingField + awardGoal2.goal__BackingField;
		if (values[34] >= (nint)obj3)
		{
			PlayerInfo instance2 = PlayerInfo.Instance;
			int value = awardGoal.goal__BackingField + awardGoal2.goal__BackingField;
			instance2._stats.set_Item(Stat.WordyWeekendChallengesCompletedOneWeekend, value);
			return;
		}
		PlayerInfo instance3 = PlayerInfo.Instance;
		if (awardGoal.goal__BackingField <= values[34])
		{
			instance3._stats.set_Item(Stat.WordyWeekendChallengesCompletedOneWeekend, awardGoal.goal__BackingField);
		}
		else
		{
			instance3._stats.set_Item(Stat.WordyWeekendChallengesCompletedOneWeekend, 0);
		}
	}
}
