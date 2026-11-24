using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Data.Save;
using TopRun;
using TopRun.UI;
using UI.Screens.RewardManagement;
using UnityEngine;

public static class TopRunRewardHelper
{
	private static int _amountOfFriendsBeaten;

	public static void PrepareAndCallCelebrationScreen(IManager manager)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}

	private static void GivePendingRewardSilently()
	{
	}

	public static bool ShouldShowResults()
	{
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		nint num = (nint)typeof(SocialManagerIOS);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SocialManagerIOS>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SocialManagerIOS);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<SocialManagerIOS>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v9 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (byte)((ComputeShader)(object)SocialManagerIOS._instance).FindKernel((string)null) != 0;
	}

	private static CelebrationReward GetPendingReward()
	{
		//IL_007e: Expected Obj, but got I4
		//IL_0090: Expected Obj, but got I4
		bool flag;
		if (TopRunSave.pendingTopRunResultsScore != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ S0_v2 (System.Int32)+8]");
			flag = (nint)0 == 0;
		}
		else
		{
			flag = true;
		}
		if (flag)
		{
			return null;
		}
		int pendingTopRunResultsScore = TopRunSave.pendingTopRunResultsScore;
		string pendingTopRunResultID = TopRunSave.pendingTopRunResultID;
		bool flag2 = (string)pendingTopRunResultsScore == pendingTopRunResultID;
		return (CelebrationReward)((flag2 ? 1 : 0) ^ 1);
	}

	public static void RefreshPendingResults()
	{
		//IL_00a8: Expected I, but got Obj
		//IL_00be: Expected Obj, but got I
		//IL_005b: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(TopRunRewardHelper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<TopRunRewardHelper>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(TopRunRewardHelper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v22 (Il2CppClass<TopRunRewardHelper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		List<Country> listOfCountries = CountryData.GetListOfCountries();
		((CollectCoinsCell)(object)listOfCountries).UpdateCell();
		int pendingTopRunResultsScore = TopRunSave.pendingTopRunResultsScore;
		TopRunSave.pendingTopRunResultID = (string)pendingTopRunResultsScore;
		TopRunNotificationSlideInManager instance = TopRunNotificationSlideInManager.instance;
		TopRunNotificationSlideInManager instance2 = TopRunNotificationSlideInManager.instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		TopRunNormalStateHelper topRunNormalStateHelper = default;
		topRunNormalStateHelper.InitNormalState();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7767");
	}

	private static void CalculateBeatenFriendsAward()
	{
		//IL_01a1: Expected Obj, but got I4
		//IL_00f2: Expected I, but got Obj
		//IL_0108: Expected Obj, but got I
		//IL_0133: Expected I, but got Obj
		//IL_01d5: Expected I, but got Obj
		//IL_01eb: Expected Obj, but got I
		//IL_0274: Expected I, but got Obj
		//IL_028a: Expected Obj, but got I
		//IL_0216: Expected I, but got Obj
		//IL_0359: Expected I, but got Obj
		//IL_02e8: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7502");
		CelebrationReward celebrationReward = default;
		if (celebrationReward == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj = default;
		if (obj == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj2 = default;
		if (obj2 == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj3 = default;
		if ((nint)obj3 <= 0)
		{
			return;
		}
		bool flag;
		if (TopRunSave.pendingTopRunResultsScore != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v18 (System.Int32)+8]");
			flag = (nint)0 == 0;
		}
		else
		{
			flag = true;
		}
		if (flag)
		{
			nint num = (nint)typeof(TopRunRewardHelper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v53 (Il2CppClass<TopRunRewardHelper>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num2 = (nint)typeof(TopRunRewardHelper);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v58 (Il2CppClass<TopRunRewardHelper>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			TrackRewardStats(celebrationReward);
			return;
		}
		int pendingTopRunResultsScore = TopRunSave.pendingTopRunResultsScore;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		int index = default;
		if (((string)pendingTopRunResultsScore).get_Chars(index) == '\0')
		{
			return;
		}
		nint num3 = (nint)typeof(TopRunRewardHelper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v24 (Il2CppClass<TopRunRewardHelper>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num4 = (nint)typeof(TopRunRewardHelper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v48 (Il2CppClass<TopRunRewardHelper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		TopRunRewardHelper._002Ecctor();
		string pendingTopRunResultID = TopRunSave.pendingTopRunResultID;
		int pendingTopRunResultsScore2 = TopRunSave.pendingTopRunResultsScore;
		char c = pendingTopRunResultID.get_Chars(pendingTopRunResultsScore2);
		nint num5 = (nint)typeof(TopRunRewardHelper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S1_v20 (Il2CppClass<TopRunRewardHelper>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		bool flag2 = obj6 == null;
		if (c != '\0')
		{
			if (!flag2)
			{
				nint num6 = (nint)typeof(TopRunRewardHelper);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S0_v44 (Il2CppClass<TopRunRewardHelper>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			RefreshPendingResults();
		}
		else if (!flag2)
		{
			nint num7 = (nint)typeof(TopRunRewardHelper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S0_v36 (Il2CppClass<TopRunRewardHelper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		TrackRewardStats(celebrationReward);
	}

	private static void OverridePendingResults(IManager manager)
	{
		//IL_013b: Expected I, but got Obj
		//IL_0151: Expected Obj, but got I
		//IL_01bd: Expected I, but got Obj
		//IL_01d3: Expected Obj, but got I
		//IL_0189: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_01a5: Expected Obj, but got I4
		//IL_00ee: Expected I, but got Obj
		nint num = (nint)typeof(TopRunRewardHelper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<TopRunRewardHelper>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(TopRunRewardHelper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v25 (Il2CppClass<TopRunRewardHelper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		List<Country> listOfCountries = CountryData.GetListOfCountries();
		nint num3 = (nint)typeof(RewardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v4 (Il2CppClass<RewardManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(RewardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v13 (Il2CppClass<RewardManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		RewardManager.AddMysteryBoxToUnlock((CelebrationReward)(object)listOfCountries);
		int pendingTopRunResultsScore = TopRunSave.pendingTopRunResultsScore;
		TopRunSave.pendingTopRunResultID = (string)pendingTopRunResultsScore;
		nint num5 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v15 (Il2CppClass<UIScreenController>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v21 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag)._ActivateNextPopup("CelebrationPopup");
	}

	public static void TrackRewardStats(CelebrationReward reward)
	{
		//IL_00a5: Expected I, but got Obj
		//IL_00bb: Expected Obj, but got I
		//IL_0157: Expected Obj, but got I4
		//IL_00e6: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj = default;
		if (obj == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		int pendingTopRunResultsScore = default;
		TopRunSave.pendingTopRunResultsScore = pendingTopRunResultsScore;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		int lastWeekMedalWasShown = default;
		TopRunSave.lastWeekMedalWasShown = lastWeekMedalWasShown;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		int pendingTopRunResultsRank = default;
		TopRunSave.pendingTopRunResultsRank = pendingTopRunResultsRank;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
		int pendingTopRunResultsWeek = default;
		TopRunSave.pendingTopRunResultsWeek = pendingTopRunResultsWeek;
		nint num = (nint)typeof(TopRunRewardHelper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v25 (Il2CppClass<TopRunRewardHelper>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(TopRunRewardHelper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v32 (Il2CppClass<TopRunRewardHelper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((TopRunSave)_amountOfFriendsBeaten)._002Ector();
	}

	static TopRunRewardHelper()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0532: Expected Obj, but got Unknown
		//IL_053b: Expected Obj, but got I4
		//IL_054a: Unknown result type (might be due to invalid IL or missing references)
		//IL_054f: Expected Obj, but got Unknown
		//IL_0081: Expected Obj, but got I
		//IL_0091: Expected Obj, but got I
		//IL_00a1: Expected Obj, but got I
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected Obj, but got Unknown
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected Obj, but got Unknown
		//IL_058d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0592: Expected Obj, but got Unknown
		//IL_059b: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a0: Expected Obj, but got Unknown
		//IL_05cc: Expected Obj, but got I4
		//IL_05d5: Expected Obj, but got I4
		//IL_021d: Expected Obj, but got I
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected Obj, but got Unknown
		//IL_05f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fc: Expected Obj, but got Unknown
		//IL_0605: Unknown result type (might be due to invalid IL or missing references)
		//IL_060a: Expected Obj, but got Unknown
		//IL_0636: Expected Obj, but got I4
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Expected Obj, but got Unknown
		//IL_0480: Expected Obj, but got I
		//IL_04be: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c3: Expected Obj, but got Unknown
		//IL_0346: Expected I, but got Obj
		//IL_035c: Expected Obj, but got I
		//IL_04f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f9: Expected Obj, but got Unknown
		//IL_0387: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7502");
		object obj5 = default;
		if (obj5 == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj6 = default;
		if (obj6 == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<IPlayer> list = default;
		list._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S3_v3 (Il2CppMethodInfo)+C]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S3_v4+60]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S3_v5+38]");
		object obj9 = 0;
		object obj10 = obj9 & 0x1FFF;
		object obj11 = obj10 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v137 @ S4_v5 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<IPlayer> list2 = default;
		list2._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj12 = default;
		object obj13 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj12 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj13 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			}
		}
		object obj14 = obj4 + 4;
		object obj15 = obj14 + 1;
		obj14 = obj15;
		object obj16 = obj15 << 2;
		object obj17 = obj4 + obj16;
		obj17 = 107;
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj19 = (nint)0 << 2;
			object obj20 = obj4 + obj19;
			if ((nint)obj20 == 107)
			{
				object obj21 = obj4 + 4;
				if ((nint)obj21 > -1)
				{
					object obj22 = obj21 + -1;
					obj21 = obj22;
				}
				goto IL_067f;
			}
		}
		if (obj18 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_067f;
		IL_067f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj23 = default;
		object obj24 = default;
		object obj25 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj23 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj24) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj25))
			{
				continue;
			}
			nint num2 = (nint)typeof(TopRunRewardHelper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ S0_v115 (Il2CppClass<TopRunRewardHelper>)+BA]");
			object obj26 = (nint)0 & (nint)0x200;
			if (obj26 != null)
			{
				nint num3 = (nint)typeof(TopRunRewardHelper);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ S0_v122 (Il2CppClass<TopRunRewardHelper>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			int amountOfFriendsBeaten = _amountOfFriendsBeaten + 1;
			_amountOfFriendsBeaten = amountOfFriendsBeaten;
		}
		object obj27 = obj4 + 4;
		object obj28 = obj27 + 1;
		obj27 = obj28;
		object obj29 = obj28 << 2;
		object obj30 = obj4 + obj29;
		obj30 = 177;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj31 = (nint)0 << 2;
			object obj32 = obj4 + obj31;
			if ((nint)obj32 == 177)
			{
				object obj33 = obj4 + 4;
				if ((nint)obj33 > -1)
				{
					object obj34 = obj33 + -1;
					obj33 = obj34;
				}
				return;
			}
		}
		if (obj18 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
	}
}
