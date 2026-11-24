using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Onboarding;

namespace Missions;

public static class AwardsData
{
	private static AwardStaticData[] awards__BackingField;

	private const string ICON_NAME_DIAMOND = "icon_gemstone";

	private const string ICON_NAME_GOLDBAR = "icon_goldbar";

	private const string ICON_NAME_CLOCK = "icon_classyclock";

	private const string ICON_NAME_DOLLAR = "icon_dollarchain";

	private const string ICON_NAME_SKULL = "icon_paperweight";

	private const string ICON_NAME_HEADPHONES = "icon_headphones";

	private const string ICON_NAME_PLATINUMRECORD = "icon_record";

	private const string ICON_NAME_CASSETTE = "icon_cassettetape";

	private static List<AwardId> awardOrder;

	private static AwardStaticData[] awards
	{
		get
		{
			//IL_0101: Expected I, but got Obj
			//IL_0117: Expected Obj, but got I
			//IL_006e: Expected I, but got Obj
			//IL_0084: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_014a: Expected Obj, but got I4
			//IL_005b: Expected Obj, but got I4
			//IL_00af: Expected I, but got Obj
			nint num = (nint)typeof(OnboardingTracking);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Onboarding.OnboardingTracking>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(OnboardingTracking);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v25 (Il2CppClass<Onboarding.OnboardingTracking>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (OnboardingTracking.LogLimitReached(OnboardingTracking.ScreenType.FrontScreen))
			{
				return (AwardStaticData[])1;
			}
			nint num3 = (nint)typeof(OnboardingTracking);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v14 (Il2CppClass<Onboarding.OnboardingTracking>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(OnboardingTracking);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v20 (Il2CppClass<Onboarding.OnboardingTracking>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = OnboardingTracking.LogLimitReached(OnboardingTracking.ScreenType.Gameover);
			return (AwardStaticData[])flag;
		}
		set
		{
		}
	}

	static AwardsData()
	{
		//IL_001c: Expected I, but got Obj
		//IL_0032: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<string> list = default;
		list._002Ector();
		OnboardingTracking.listOfScreensAfterGameover = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<string> list2 = default;
		list2._002Ector();
		nint num = (nint)typeof(OnboardingTracking);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v15 (Il2CppClass<Onboarding.OnboardingTracking>)+5C]");
		object obj = (nint)0 + (nint)4;
		obj = list2;
	}

	public static AwardStaticData[] GetAwardStaticDataList()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(AwardsData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Missions.AwardsData>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AwardsData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Missions.AwardsData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return awards__BackingField;
	}

	private static AwardStaticData GetAwardStaticDataItem(int index)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_003d: Expected Obj, but got I
		//IL_004d: Expected Obj, but got I
		//IL_0067: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [index @ L0 (System.Int32)+1C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [index @ L0 (System.Int32)+C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4 @ S1_v2+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [index @ L0 (System.Int32)+1C]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [index @ L0 (System.Int32)+18]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S1_v5+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [index @ L0 (System.Int32)+1C]");
		return (AwardStaticData)0;
	}

	public unsafe static void ResetWordyWeekendChallengeOneWeekend()
	{
		//IL_00e7: Expected I, but got Obj
		//IL_00fd: Expected Obj, but got I
		//IL_0113: Expected I, but got Obj
		//IL_0129: Expected Obj, but got I
		//IL_4867: Unknown result type (might be due to invalid IL or missing references)
		//IL_486c: Expected I, but got Unknown
		//IL_4879: Expected I, but got Obj
		//IL_4894: Expected I, but got Obj
		//IL_48aa: Expected Obj, but got I
		//IL_0154: Expected I, but got Obj
		//IL_01a1: Expected I, but got Obj
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected Obj, but got Unknown
		//IL_026c: Expected Obj, but got I
		//IL_027c: Expected Obj, but got I
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Expected Obj, but got Unknown
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Expected Obj, but got Unknown
		//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
		List<AwardId> list = default;
		list.Add(AwardId.SCORE_POINTS_SINGLE_LANE);
		list.Add(AwardId.OPEN_X_SUPER_MYSTERY_BOXES);
		list.Add(AwardId.WIN_X_JACKPOTS);
		list.Add(AwardId.SCORE_POINTS_SINGLE_RUN_NO_JUMP_OR_ROLL);
		list.Add(AwardId.OPEN_X_MYSTERY_BOXES);
		list.Add(AwardId.PICK_X_KEYS_INGAME);
		list.Add(AwardId.COLLECT_COINS_SINGLE_RUN);
		list.Add(AwardId.HAVE_SUPERSNICKERS_ACTIVE_X_MIN_IN_A_ROW);
		list.Add(AwardId.COMPLETE_MISSIONS_SINGLE_RUN);
		list.Add(AwardId.SCORE_POINTS_SINGLE_RUN_NO_COINS);
		list.Add(AwardId.PICKUP_POWERUPS);
		list.Add(AwardId.COMPLETE_X_MISSIONS);
		list.Add(AwardId.COLLECT_OLD_TROPHY_ITEMS_MB);
		list.Add(AwardId.COLLECT_OLD_TROPHY_ITEMS_SMB);
		nint num = (nint)typeof(AwardsData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v26 (Il2CppClass<Missions.AwardsData>)+5C]");
		object obj = (nint)0 + (nint)4;
		obj = list;
		nint num2 = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v32 (Il2CppClass<System.Type>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num3 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v1730 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object typeFromHandle = typeof(AwardId);
		nint num4 = (nint)(typeFromHandle + 4);
		((IntPtr*)num4)->m_value = (void*)(nint)typeFromHandle;
		Type enumType = Type.internal_from_handle((IntPtr)num4);
		nint num5 = (nint)typeof(Enum);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S1_v28 (Il2CppClass<System.Enum>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(Enum);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S1_v1256 (Il2CppClass<System.Enum>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string[] array = Enum.InternalGetNames((System.RuntimeType)enumType);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A3F1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A3F2");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		_ = 1;
		_ = 0;
		_ = 1;
		_ = 0;
		_ = 0;
		_ = 0;
		object obj5 = default;
		object obj4 = obj5 + 16;
		obj4 = "AWARD_1_TITLE";
		_ = 0;
		_ = 1;
		_ = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S3_v3+60]");
		object obj7 = 0;
		object obj8 = obj7;
		object obj9 = obj8 & 0x1FFF;
		object obj10 = obj9 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v185 @ S4_v4 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 1;
		_ = 3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		_ = 3;
		_ = 1;
		_ = 1;
		object obj12 = default;
		object obj11 = obj12 + 16;
		obj11 = "icon_classyclock";
		throw new ArrayTypeMismatchException();
	}
}
