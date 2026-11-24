using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Data.Managers;
using Data.Save;
using Data.Save.Internal;
using Info;
using Missions;
using SYBO.Subway.Info;
using UI.Generic.Layout;
using UI.Screens.PauseScreenInternal;
using UI.Screens.RewardManagement;
using UnityEngine;
using UnityEngine.UI;

public static class MysteryBox
{
	public enum Type
	{
		Normal,
		Super,
		Mini
	}

	private class LootTableEntry
	{
		public CelebrationRewardType itemType;

		public float weight;

		public int min;

		public int max;

		public UpgradeType upgradeType;
	}

	public static readonly Characters.CharacterId[] TOKEN_REWARD_IDS;

	public static readonly Dictionary<Characters.CharacterId, int> characterTokenWeight;

	private static readonly LootTableEntry[][] _lootTables;

	public const int MYSTERY_BOX_JACKPOT_AMOUNT = 100000;

	public const int SUPER_MYSTERY_BOX_JACKPOT_AMOUNT = 300000;

	public const int DEFAULT_MEGA_JACKPOT_MYSTERYBOX = 900000;

	public const int DEFAULT_MEGA_JACKPOT_SUPER_MYSTERYBOX = 1500000;

	public const int MYSTERY_BOX_RARE_COINS_AMOUNT = 5000;

	public const int MYSTERY_BOX_SPECIAL_COINS_AMOUNT = 2500;

	public const int MYSTERY_BOX_SPECIAL_BOARDS_AMOUNT = 10;

	public const int SUPER_MYSTERY_BOX_RARE_COINS_AMOUNT = 50000;

	public const int SUPER_MYSTERY_BOX_SPECIAL_COINS_AMOUNT = 8000;

	public const int SUPER_MYSTERY_BOX_SPECIAL_BOARDS_AMOUNT = 20;

	public const int MINI_MYSTERY_BOX_COMMON_BOARDS_AMOUNT = 3;

	public const int MINI_MYSTERY_BOX_COMMON_COINS_AMOUNT = 200;

	public const int MINI_MYSTERY_BOX_RARE_KEYS_AMOUNT = 2;

	private static readonly CelebrationReward MYSTERYBOX_CONSOLATION_REWARD;

	private static readonly CelebrationReward SUPERMYSTERYBOX_CONSOLATION_REWARD;

	public static void TestRolls(int numberOfRolls, Type mysteryBoxType = Type.Normal)
	{
		//IL_0024: Expected Obj, but got I4
		string msg = string.ConcatArray((string[])(object)"GlobalDebug: ", numberOfRolls);
		SDebug.LogFormat(msg, (object[])mysteryBoxType);
	}

	static MysteryBox()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected Obj, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected Obj, but got Unknown
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected Obj, but got Unknown
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected Obj, but got Unknown
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected Obj, but got Unknown
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Expected Obj, but got Unknown
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected Obj, but got Unknown
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected Obj, but got Unknown
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		LeaderboardDummyData.LeaderboardDummy leaderboardDummy = default;
		object obj = leaderboardDummy + 8;
		obj = "DUMMY_FRIEND_NAME_1";
		leaderboardDummy.score = 999999;
		List<LeaderboardDummyData.LeaderboardDummy> list = default;
		list.Add(leaderboardDummy);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		LeaderboardDummyData.LeaderboardDummy leaderboardDummy2 = default;
		object obj2 = leaderboardDummy2 + 8;
		obj2 = "DUMMY_FRIEND_NAME_2";
		leaderboardDummy2.score = 810312;
		list.Add(leaderboardDummy2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		LeaderboardDummyData.LeaderboardDummy leaderboardDummy3 = default;
		object obj3 = leaderboardDummy3 + 8;
		obj3 = "DUMMY_FRIEND_NAME_3";
		leaderboardDummy3.score = 555555;
		list.Add(leaderboardDummy3);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		LeaderboardDummyData.LeaderboardDummy leaderboardDummy4 = default;
		object obj4 = leaderboardDummy4 + 8;
		obj4 = "DUMMY_FRIEND_NAME_4";
		leaderboardDummy4.score = 345678;
		list.Add(leaderboardDummy4);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		LeaderboardDummyData.LeaderboardDummy leaderboardDummy5 = default;
		object obj5 = leaderboardDummy5 + 8;
		obj5 = "DUMMY_FRIEND_NAME_5";
		leaderboardDummy5.score = 171110;
		list.Add(leaderboardDummy5);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		LeaderboardDummyData.LeaderboardDummy leaderboardDummy6 = default;
		object obj6 = leaderboardDummy6 + 8;
		obj6 = "DUMMY_FRIEND_NAME_6";
		leaderboardDummy6.score = 123456;
		list.Add(leaderboardDummy6);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		LeaderboardDummyData.LeaderboardDummy leaderboardDummy7 = default;
		object obj7 = leaderboardDummy7 + 8;
		obj7 = "DUMMY_FRIEND_NAME_7";
		leaderboardDummy7.score = 65900;
		list.Add(leaderboardDummy7);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		LeaderboardDummyData.LeaderboardDummy leaderboardDummy8 = default;
		object obj8 = leaderboardDummy8 + 8;
		obj8 = "DUMMY_FRIEND_NAME_8";
		leaderboardDummy8.score = 15505;
		list.Add(leaderboardDummy8);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		LeaderboardDummyData.LeaderboardDummy leaderboardDummy9 = default;
		object obj9 = leaderboardDummy9 + 8;
		obj9 = "DUMMY_FRIEND_NAME_9";
		leaderboardDummy9.score = 1000;
		list.Add(leaderboardDummy9);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		LeaderboardDummyData.LeaderboardDummy leaderboardDummy10 = default;
		object obj10 = leaderboardDummy10 + 8;
		obj10 = "DUMMY_FRIEND_NAME_10";
		leaderboardDummy10.score = 500;
		list.Add(leaderboardDummy10);
		LeaderboardDummyData.dummyData = list;
	}

	public static CelebrationReward Roll(Type mysteryBoxType)
	{
		//IL_005b: Expected Obj, but got I4
		//IL_0069: Expected I, but got Obj
		//IL_007f: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		object result = 0;
		nint num = (nint)typeof(HoverboardThemes);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<HoverboardThemes>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(HoverboardThemes);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v20 (Il2CppClass<HoverboardThemes>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @108D8");
		return (CelebrationReward)result;
	}

	public static int GetMegaJackpotAmount(Type mysteryBoxType)
	{
		//IL_0d3c: Expected I, but got Obj
		//IL_0d52: Expected Obj, but got I
		//IL_0c6b: Expected Obj, but got I4
		//IL_0c79: Expected Obj, but got I4
		//IL_0c8d: Expected Obj, but got I4
		//IL_0c9b: Expected I, but got Obj
		//IL_0cb1: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0ddc: Expected I4, but got Obj
		//IL_0cdc: Expected I, but got Obj
		//IL_0094: Expected Obj, but got I4
		//IL_0245: Expected Obj, but got I4
		//IL_0253: Expected Obj, but got I4
		//IL_00dd: Expected Obj, but got I4
		//IL_02a0: Expected Obj, but got I4
		//IL_02ae: Expected Obj, but got I4
		//IL_02bc: Expected I, but got Obj
		//IL_02d2: Expected Obj, but got I
		//IL_0da4: Expected I, but got Obj
		//IL_0dba: Expected Obj, but got I
		//IL_0398: Expected Obj, but got I4
		//IL_03a6: Expected Obj, but got I4
		//IL_03b4: Expected Obj, but got I4
		//IL_0f4c: Expected Obj, but got I4
		//IL_010f: Expected Obj, but got I4
		//IL_011d: Expected Obj, but got I4
		//IL_03f9: Expected Obj, but got I4
		//IL_0407: Expected Obj, but got I4
		//IL_0353: Expected Obj, but got I4
		//IL_02fd: Expected I, but got Obj
		//IL_0f74: Expected Obj, but got I4
		//IL_041a: Expected I, but got Obj
		//IL_013e: Expected Obj, but got I4
		//IL_0345: Expected Obj, but got I4
		//IL_01ab: Expected Obj, but got I4
		//IL_0178: Expected Obj, but got I4
		//IL_0186: Expected Obj, but got I4
		//IL_0194: Expected Obj, but got I4
		//IL_01e5: Expected Obj, but got I4
		//IL_01f3: Expected Obj, but got I4
		//IL_05ce: Expected Obj, but got I4
		//IL_05fc: Expected Obj, but got I4
		//IL_04d8: Expected I, but got Obj
		//IL_04ee: Expected Obj, but got I
		//IL_0836: Expected Obj, but got I4
		//IL_0864: Expected Obj, but got I4
		//IL_0660: Expected I, but got Obj
		//IL_0676: Expected Obj, but got I
		//IL_08af: Expected Obj, but got I4
		//IL_08c4: Expected Obj, but got I
		//IL_08f2: Expected Obj, but got I4
		//IL_0e59: Expected Obj, but got I4
		//IL_064d: Expected Obj, but got I4
		//IL_064d: Expected Obj, but got I4
		//IL_064d: Expected Obj, but got I4
		//IL_0519: Expected I, but got Obj
		//IL_06a1: Expected I, but got Obj
		//IL_0ed2: Expected I, but got Obj
		//IL_0ee8: Expected Obj, but got I
		//IL_0721: Expected Obj, but got I4
		//IL_0729: Unknown result type (might be due to invalid IL or missing references)
		//IL_072e: Expected Obj, but got Unknown
		//IL_0af8: Expected Obj, but got I4
		//IL_0b26: Expected Obj, but got I4
		//IL_0b39: Expected I4, but got Obj
		//IL_096d: Expected Obj, but got I4
		//IL_099b: Expected Obj, but got I4
		//IL_09a9: Expected I, but got Obj
		//IL_09bf: Expected Obj, but got I
		//IL_0778: Expected I, but got Obj
		//IL_078e: Expected Obj, but got I
		//IL_0b60: Expected Obj, but got I4
		//IL_0a9f: Expected Obj, but got I4
		//IL_0aad: Expected Obj, but got I4
		//IL_0ea6: Expected I4, but got Obj
		//IL_0c10: Expected I, but got Obj
		//IL_09ea: Expected I, but got Obj
		//IL_07b9: Expected I, but got Obj
		//IL_0b9f: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		DailyChallengeRewardHelper dailyChallengeRewardHelper = default;
		dailyChallengeRewardHelper.Refresh();
		nint num = (nint)typeof(BoardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v9 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v254 (Il2CppClass<Data.Managers.BoardManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag;
		DailyChallengeRewardHelper dailyChallengeRewardHelper2;
		if (BoardManager.HasBoardBeenSeen(Boards.BoardId.starboard))
		{
			PlayerSave.completedRunCount = (int)mysteryBoxType;
			flag = mysteryBoxType != Type.Normal;
			if (flag)
			{
				object obj2 = mysteryBoxType - 1;
				if (mysteryBoxType != Type.Super)
				{
					if ((nint)obj2 != 1)
					{
						goto IL_0d96;
					}
					LocalData local = ((SaveGame)2).local;
					if ((nint)local == 1)
					{
						dailyChallengeRewardHelper._rewardLayout = (Layout)2;
						dailyChallengeRewardHelper._superMysteryBoxReward = (GameObject)15;
						dailyChallengeRewardHelper._checkmark = (UISprite)1;
						dailyChallengeRewardHelper2 = dailyChallengeRewardHelper;
					}
					else
					{
						LocalData local2 = ((SaveGame)2).local;
						if ((nint)local2 != 2)
						{
							goto IL_0d96;
						}
						dailyChallengeRewardHelper._rewardLayout = (Layout)6;
						dailyChallengeRewardHelper._checkmark = (UISprite)1;
						dailyChallengeRewardHelper2 = dailyChallengeRewardHelper;
					}
				}
				else
				{
					LocalData local3 = ((SaveGame)1).local;
					if ((nint)local3 != 1)
					{
						goto IL_0d96;
					}
					dailyChallengeRewardHelper._rewardLayout = (Layout)6;
					dailyChallengeRewardHelper._checkmark = (UISprite)1;
					dailyChallengeRewardHelper2 = dailyChallengeRewardHelper;
				}
			}
			else
			{
				LocalData local4 = ((SaveGame)null).local;
				if ((nint)local4 == 1)
				{
					dailyChallengeRewardHelper._rewardLayout = (Layout)1;
					dailyChallengeRewardHelper._checkmark = (UISprite)1000;
					dailyChallengeRewardHelper2 = dailyChallengeRewardHelper;
				}
				else
				{
					LocalData local5 = ((SaveGame)null).local;
					if ((nint)local5 == 2)
					{
						dailyChallengeRewardHelper._rewardLayout = (Layout)3;
						dailyChallengeRewardHelper._checkmark = (UISprite)1;
						nint num3 = (nint)typeof(CharacterManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ S0_v225 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
						object obj3 = (nint)0 & (nint)0x200;
						if (obj3 != null)
						{
							nint num4 = (nint)typeof(CharacterManager);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ S0_v230 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						UILabel rewardLabel = ((!CharacterManager.IsCollectionComplete(Characters.CharacterId.tricky)) ? ((UILabel)1) : ((UILabel)2));
						dailyChallengeRewardHelper._rewardLabel = rewardLabel;
					}
					else
					{
						LocalData local6 = ((SaveGame)null).local;
						if ((nint)local6 == 3)
						{
							dailyChallengeRewardHelper._rewardLayout = (Layout)2;
							dailyChallengeRewardHelper._checkmark = (UISprite)3;
							dailyChallengeRewardHelper._superMysteryBoxReward = (GameObject)1;
							dailyChallengeRewardHelper2 = dailyChallengeRewardHelper;
							goto IL_0dd7;
						}
						LocalData local7 = ((SaveGame)null).local;
						if ((nint)local7 != 4)
						{
							goto IL_0d96;
						}
						dailyChallengeRewardHelper._rewardLayout = (Layout)6;
						dailyChallengeRewardHelper._checkmark = (UISprite)1;
					}
					dailyChallengeRewardHelper2 = dailyChallengeRewardHelper;
				}
			}
		}
		else
		{
			((UnityEngine.Object)dailyChallengeRewardHelper).m_CachedPtr = (IntPtr)8;
			dailyChallengeRewardHelper._rewardLayout = (Layout)7;
			dailyChallengeRewardHelper._6BagsReward = (GameObject)6;
			_ = 0;
			dailyChallengeRewardHelper._checkmark = (UISprite)1;
			nint num5 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v23 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num6 = (nint)typeof(BoardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v28 (Il2CppClass<Data.Managers.BoardManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			BoardManager.LockBoard(Boards.BoardId.starboard);
			dailyChallengeRewardHelper2 = dailyChallengeRewardHelper;
		}
		goto IL_0dd7;
		IL_0ec4:
		nint num7 = (nint)typeof(MysteryBox);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ S0_v82 (Il2CppClass<MysteryBox>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		bool flag2 = obj5 == null;
		DailyChallengeRewardHelper dailyChallengeRewardHelper3;
		if (flag)
		{
			if (!flag2)
			{
				nint num8 = (nint)typeof(MysteryBox);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ S0_v106 (Il2CppClass<MysteryBox>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			dailyChallengeRewardHelper3 = (DailyChallengeRewardHelper)(object)SUPERMYSTERYBOX_CONSOLATION_REWARD;
		}
		else
		{
			if (!flag2)
			{
				nint num9 = (nint)typeof(MysteryBox);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ S0_v94 (Il2CppClass<MysteryBox>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			dailyChallengeRewardHelper3 = (DailyChallengeRewardHelper)(object)MYSTERYBOX_CONSOLATION_REWARD;
		}
		dailyChallengeRewardHelper2 = dailyChallengeRewardHelper3;
		goto IL_0dd7;
		IL_0dd7:
		return (int)dailyChallengeRewardHelper2;
		IL_076a:
		nint num10 = (nint)typeof(MysteryBox);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ S0_v168 (Il2CppClass<MysteryBox>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num11 = (nint)typeof(MysteryBox);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ S0_v173 (Il2CppClass<MysteryBox>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		LootTableEntry checkmark = MakeRoll(mysteryBoxType);
		dailyChallengeRewardHelper._checkmark = (UISprite)(object)checkmark;
		dailyChallengeRewardHelper2 = dailyChallengeRewardHelper;
		goto IL_0dd7;
		IL_0d96:
		nint num12 = (nint)typeof(MysteryBox);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ S0_v37 (Il2CppClass<MysteryBox>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num13 = (nint)typeof(MysteryBox);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ S0_v200 (Il2CppClass<MysteryBox>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIPanel scrollPanel = ((TableElementAlwaysVisible)mysteryBoxType).scrollPanel;
		Layers instance = Layers.Instance;
		Characters.CharacterId randomCharacterTokenTypeUsingWeights;
		while (true)
		{
			randomCharacterTokenTypeUsingWeights = GetRandomCharacterTokenTypeUsingWeights((List<Characters.CharacterId>)mysteryBoxType);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ S0_v47 (SYBO.Subway.Info.Characters+CharacterId)+8]");
			if ((nint)0 != 4 || (nint)scrollPanel.leftAnchor > 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ S0_v47 (SYBO.Subway.Info.Characters+CharacterId)+8]");
				if ((nint)0 != 3 || instance.Hit > 0)
				{
					break;
				}
			}
			nint num14 = (nint)typeof(MysteryBox);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ S0_v52 (Il2CppClass<MysteryBox>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num15 = (nint)typeof(MysteryBox);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ S0_v56 (Il2CppClass<MysteryBox>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
		}
		if (randomCharacterTokenTypeUsingWeights == Characters.CharacterId.slick)
		{
			SDebug.LogFormat("A reward was empty, how did this happen?", null);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ S0_v47 (SYBO.Subway.Info.Characters+CharacterId)+8]");
		if ((nint)0 == 1)
		{
			dailyChallengeRewardHelper._rewardLayout = (Layout)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ S0_v47 (SYBO.Subway.Info.Characters+CharacterId)+10]");
			nint num16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ S0_v47 (SYBO.Subway.Info.Characters+CharacterId)+14]");
			int num17 = UnityEngine.Random.RandomRangeInt((int)num16, 0);
			dailyChallengeRewardHelper._checkmark = (UISprite)num17;
			if ((nint)dailyChallengeRewardHelper._checkmark >= 5000)
			{
				StayInOneLaneMission instance2 = StayInOneLaneMission.instance;
				((OwnBoardsAward)(object)instance2)._002Ector((AwardStaticData)56, (PersistentAwardProgress)1, (Action<Award>)(-1));
			}
			nint num18 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ S0_v157 (Il2CppClass<SSEventsManagerController>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num19 = (nint)typeof(SSEventsManagerController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ S0_v182 (Il2CppClass<SSEventsManagerController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string flurryUserId = Flurry.flurryUserId;
			bool flag3 = ((SSEventsManagerController)(object)flurryUserId).DoesCharacterMatchCurrentEvent(Characters.CharacterId.yutani);
			bool flag4 = (nint)dailyChallengeRewardHelper._checkmark != 100000;
			object obj10 = flag | flag4;
			if (obj10 != null)
			{
				bool flag5 = !flag3;
				bool flag6 = (nint)dailyChallengeRewardHelper._checkmark != 300000;
				bool flag7 = mysteryBoxType != Type.Super;
				object obj11 = flag6 | flag7;
				object obj12 = flag5 | obj11;
				dailyChallengeRewardHelper2 = dailyChallengeRewardHelper;
				if (obj12 == null)
				{
					goto IL_076a;
				}
			}
			else
			{
				bool flag8 = !flag3;
				dailyChallengeRewardHelper2 = dailyChallengeRewardHelper;
				if (!flag8)
				{
					goto IL_076a;
				}
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ S0_v47 (SYBO.Subway.Info.Characters+CharacterId)+8]");
			if ((nint)0 == 6)
			{
				dailyChallengeRewardHelper._rewardLayout = (Layout)6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ S0_v47 (SYBO.Subway.Info.Characters+CharacterId)+10]");
				nint num20 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ S0_v47 (SYBO.Subway.Info.Characters+CharacterId)+14]");
				int num21 = UnityEngine.Random.RandomRangeInt((int)num20, 0);
				dailyChallengeRewardHelper._checkmark = (UISprite)num21;
				dailyChallengeRewardHelper2 = dailyChallengeRewardHelper;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ S0_v47 (SYBO.Subway.Info.Characters+CharacterId)+8]");
				if ((nint)0 == 2)
				{
					dailyChallengeRewardHelper._rewardLayout = (Layout)2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ S0_v47 (SYBO.Subway.Info.Characters+CharacterId)+18]");
					dailyChallengeRewardHelper._superMysteryBoxReward = (GameObject)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ S0_v47 (SYBO.Subway.Info.Characters+CharacterId)+10]");
					nint num22 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ S0_v47 (SYBO.Subway.Info.Characters+CharacterId)+14]");
					int num23 = UnityEngine.Random.RandomRangeInt((int)num22, 0);
					dailyChallengeRewardHelper._checkmark = (UISprite)num23;
					dailyChallengeRewardHelper2 = dailyChallengeRewardHelper;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ S0_v47 (SYBO.Subway.Info.Characters+CharacterId)+8]");
					if ((nint)0 == 3)
					{
						if (instance.Hit < 1)
						{
							goto IL_0ec4;
						}
						dailyChallengeRewardHelper._rewardLayout = (Layout)3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ S0_v47 (SYBO.Subway.Info.Characters+CharacterId)+10]");
						nint num24 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ S0_v47 (SYBO.Subway.Info.Characters+CharacterId)+14]");
						int num25 = UnityEngine.Random.RandomRangeInt((int)num24, 0);
						dailyChallengeRewardHelper._checkmark = (UISprite)num25;
						nint num26 = (nint)typeof(MysteryBox);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ S0_v136 (Il2CppClass<MysteryBox>)+BA]");
						object obj13 = (nint)0 & (nint)0x200;
						if (obj13 != null)
						{
							nint num27 = (nint)typeof(MysteryBox);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v462 @ S0_v141 (Il2CppClass<MysteryBox>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						List<Trophies.Trophy> availableTrophyList = GetAvailableTrophyList((Type)instance);
						dailyChallengeRewardHelper._rewardLabel = (UILabel)(object)availableTrophyList;
						dailyChallengeRewardHelper2 = dailyChallengeRewardHelper;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ S0_v47 (SYBO.Subway.Info.Characters+CharacterId)+8]");
						if ((nint)0 != 4)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ S0_v47 (SYBO.Subway.Info.Characters+CharacterId)+8]");
							bool flag9 = (nint)0 != 5;
							dailyChallengeRewardHelper2 = dailyChallengeRewardHelper;
							if (!flag9)
							{
								dailyChallengeRewardHelper._rewardLayout = (Layout)5;
								dailyChallengeRewardHelper._checkmark = (UISprite)1;
								dailyChallengeRewardHelper2 = dailyChallengeRewardHelper;
							}
						}
						else
						{
							if ((nint)scrollPanel.leftAnchor < 1)
							{
								goto IL_0ec4;
							}
							dailyChallengeRewardHelper._rewardLayout = (Layout)4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ S0_v47 (SYBO.Subway.Info.Characters+CharacterId)+10]");
							nint num28 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ S0_v47 (SYBO.Subway.Info.Characters+CharacterId)+14]");
							int num29 = UnityEngine.Random.RandomRangeInt((int)num28, 0);
							dailyChallengeRewardHelper._checkmark = (UISprite)num29;
							int index = UnityEngine.Random.RandomRangeInt(0, (int)scrollPanel.leftAnchor);
							Trophies.Trophy trophy = ((List<Trophies.Trophy>)(object)scrollPanel).get_Item(index);
							dailyChallengeRewardHelper._mysteryBoxReward = (GameObject)trophy;
							dailyChallengeRewardHelper2 = dailyChallengeRewardHelper;
						}
					}
				}
			}
		}
		goto IL_0dd7;
	}

	private static LootTableEntry MakeRoll(Type mysteryBoxType)
	{
		//IL_0137: Expected I, but got Obj
		//IL_014d: Expected Obj, but got I
		//IL_00a8: Expected I, but got Obj
		//IL_0124: Expected Obj, but got I4
		//IL_0037: Expected I, but got Obj
		//IL_0117: Expected Obj, but got I4
		//IL_0109: Expected Obj, but got I4
		nint num = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		bool flag = obj == null;
		bool flag2 = mysteryBoxType != Type.Normal;
		object key;
		uint defaultValue;
		if (flag2)
		{
			if (!flag)
			{
				nint num2 = (nint)typeof(OnlineSettings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v37 (Il2CppClass<Info.OnlineSettings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			key = "event_jackpot_supermysterybox_value";
			defaultValue = 1500000u;
		}
		else
		{
			if (!flag)
			{
				nint num3 = (nint)typeof(OnlineSettings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v28 (Il2CppClass<Info.OnlineSettings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			key = "event_jackpot_mysterybox_value";
			defaultValue = 900000u;
		}
		string saveDataPath = OnlineSettings.GetSaveDataPath();
		uint value = ((OnlineSettings)(object)saveDataPath).GetValue((string)key, defaultValue);
		if ((int)value < 1)
		{
			if (flag2)
			{
				return (LootTableEntry)1500000;
			}
			return (LootTableEntry)900000;
		}
		return (LootTableEntry)value;
	}

	private static Characters.CharacterId GetRandomCharacterTokenTypeUsingWeights(List<Characters.CharacterId> validCharacters)
	{
		//IL_0468: Expected I, but got Obj
		//IL_047e: Expected Obj, but got I
		//IL_040b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0410: Expected Obj, but got Unknown
		//IL_010b: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_03ce: Expected I, but got Obj
		//IL_03e4: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Expected Obj, but got Unknown
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected Obj, but got Unknown
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected Obj, but got Unknown
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Expected Obj, but got Unknown
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected Obj, but got Unknown
		//IL_0182: Expected I, but got Obj
		//IL_0198: Expected Obj, but got I
		//IL_0127: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Expected Obj, but got Unknown
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Expected Obj, but got Unknown
		//IL_036c: Expected I4, but got Obj
		//IL_01c3: Expected I, but got Obj
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected Obj, but got Unknown
		object obj7 = default;
		object obj14 = default;
		object obj17 = default;
		object obj18 = default;
		while (true)
		{
			nint num = (nint)typeof(MysteryBox);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v6 (Il2CppClass<MysteryBox>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(MysteryBox);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v65 (Il2CppClass<MysteryBox>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj2 = _lootTables + 16;
			object obj3 = (object)validCharacters << 2;
			object obj4 = obj2 + obj3;
			object obj5 = obj4;
			object obj6 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S1_v8+C]");
			if ((nint)obj6 >= 0)
			{
				break;
			}
			nint num3 = (nint)typeof(MysteryBox);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v51 (Il2CppClass<MysteryBox>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num4 = (nint)typeof(MysteryBox);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v59 (Il2CppClass<MysteryBox>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj9 = _lootTables + 16;
			object obj10 = (object)validCharacters << 2;
			object obj11 = obj9 + obj10;
			object obj12 = obj11 + 16;
			object obj13 = obj14 << 2;
			object obj15 = obj12 + obj13;
			object obj16 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S1_v35+C]");
			obj17 = obj18 + 0;
			obj7 = obj14 + 1;
		}
		float num5 = ScrollRect.RubberDelta(0f, 1f);
		float num6 = num5 * (float)obj17;
		object obj19 = 0;
		float num7 = 0f;
		Characters.CharacterId result;
		while (true)
		{
			nint num8 = (nint)typeof(MysteryBox);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v19 (Il2CppClass<MysteryBox>)+BA]");
			object obj20 = (nint)0 & (nint)0x200;
			if (obj20 != null)
			{
				nint num9 = (nint)typeof(MysteryBox);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S0_v44 (Il2CppClass<MysteryBox>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj21 = _lootTables + 16;
			object obj22 = (object)validCharacters << 2;
			object obj23 = obj21 + obj22;
			object obj24 = obj23;
			object obj25 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S1_v19+C]");
			if ((nint)obj25 >= 0)
			{
				result = Characters.CharacterId.slick;
				break;
			}
			nint num10 = (nint)typeof(MysteryBox);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S0_v28 (Il2CppClass<MysteryBox>)+BA]");
			object obj26 = (nint)0 & (nint)0x200;
			if (obj26 != null)
			{
				nint num11 = (nint)typeof(MysteryBox);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v37 (Il2CppClass<MysteryBox>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj27 = _lootTables + 16;
			object obj28 = (object)validCharacters << 2;
			object obj29 = obj27 + obj28;
			object obj30 = obj29 + 16;
			object obj31 = obj19 << 2;
			object obj32 = obj30 + obj31;
			Characters.CharacterId characterId = (Characters.CharacterId)obj32;
			float num12 = num7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ S2_v19 (SYBO.Subway.Info.Characters+CharacterId)+C]");
			float num13 = num12 + 0f;
			bool flag = !(num6 > num13);
			bool flag2 = !flag;
			bool flag3 = !flag2;
			result = characterId;
			if (flag3)
			{
				break;
			}
			object obj33 = obj19 + 1;
			obj19 = obj33;
			num7 = num13;
		}
		return result;
	}

	private static List<Trophies.Trophy> GetAvailableTrophyList(Type mysteryBoxType)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Expected Obj, but got Unknown
		//IL_032a: Expected Obj, but got I4
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Expected Obj, but got Unknown
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Expected Obj, but got Unknown
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_038c: Expected Obj, but got Unknown
		//IL_03b8: Expected Obj, but got I4
		//IL_004d: Expected I, but got Obj
		//IL_0063: Expected Obj, but got I
		//IL_0162: Expected Obj, but got I
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Expected Obj, but got Unknown
		//IL_022c: Expected Obj, but got I4
		//IL_008e: Expected I, but got Obj
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected Obj, but got Unknown
		//IL_0244: Expected I, but got Obj
		//IL_025a: Expected Obj, but got I
		//IL_03ed: Expected Obj, but got I4
		//IL_040b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0410: Expected Obj, but got Unknown
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected Obj, but got Unknown
		//IL_0302: Expected Obj, but got I4
		//IL_030e: Expected Obj, but got I4
		//IL_0285: Expected I, but got Obj
		//IL_02f0: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj5 = default;
		object obj8 = default;
		object obj9 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj5 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			nint num = (nint)typeof(MysteryBox);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ S0_v107 (Il2CppClass<MysteryBox>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num2 = (nint)typeof(MysteryBox);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S0_v120 (Il2CppClass<MysteryBox>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			object obj7 = obj8 + obj9;
		}
		object obj10 = obj4 + 4;
		object obj11 = obj10 + 1;
		obj10 = obj11;
		object obj12 = obj11 << 2;
		object obj13 = obj4 + obj12;
		obj13 = 63;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj14 = (nint)0 << 2;
			object obj15 = obj4 + obj14;
			if ((nint)obj15 == 63)
			{
				object obj16 = obj4 + 4;
				if ((nint)obj16 > -1)
				{
					object obj17 = obj16 + -1;
					obj16 = obj17;
				}
				goto IL_048b;
			}
		}
		object obj18 = default;
		if (obj18 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_048b;
		IL_048b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		RankException ex = default;
		ex._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @726B");
		object obj20 = default;
		object obj19 = obj20 + 1;
		int num3 = 0;
		object obj21 = 0;
		while (true)
		{
			int num4 = num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [mysteryBoxType @ L0 (MysteryBox+Type)+C]");
			if ((nint)num4 < (nint)0)
			{
				nint num5 = (nint)typeof(MysteryBox);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ S0_v50 (Il2CppClass<MysteryBox>)+BA]");
				object obj22 = (nint)0 & (nint)0x200;
				if (obj22 != null)
				{
					nint num6 = (nint)typeof(MysteryBox);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ S0_v60 (Il2CppClass<MysteryBox>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Characters.CharacterId key = ((List<Characters.CharacterId>)mysteryBoxType).get_Item(num3);
				int num7 = characterTokenWeight.get_Item(key);
				object obj23 = num7 + obj21;
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj19) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj23))
				{
					break;
				}
				int num8 = num3 + 1;
				num3 = num8;
				obj21 = obj23;
				continue;
			}
			return (List<Trophies.Trophy>)1;
		}
		Characters.CharacterId characterId = ((List<Characters.CharacterId>)mysteryBoxType).get_Item(num3);
		return (List<Trophies.Trophy>)characterId;
	}

	private static List<Characters.CharacterId> GetAvailableCharacterTokens()
	{
		//IL_0196: Expected I, but got Obj
		//IL_01ac: Expected Obj, but got I
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_01e0: Expected Obj, but got I4
		//IL_01f2: Expected I, but got Obj
		//IL_0208: Expected Obj, but got I
		//IL_005b: Expected Obj, but got I4
		//IL_00af: Expected I, but got Obj
		//IL_00fc: Expected I, but got Obj
		//IL_0250: Expected Obj, but got I4
		//IL_0144: Expected Obj, but got I4
		//IL_0183: Expected Obj, but got I4
		//IL_0175: Expected Obj, but got I4
		nint num = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Globals>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v49 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		List<Characters.CharacterId> result;
		if (~(Globals.DEBUG_USE_DEBUG_LOGIN_STATE ? 1u : 0u) == 0)
		{
			result = (List<Characters.CharacterId>)1;
		}
		else
		{
			nint num3 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v16 (Il2CppClass<SocialManager>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(SocialManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v43 (Il2CppClass<SocialManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool facebookDialogsSupported = SocialManager.facebookDialogsSupported;
			bool gamecenterIsLoggedOut = ((SocialManager)facebookDialogsSupported).gamecenterIsLoggedOut;
			nint num5 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v24 (Il2CppClass<SocialManager>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(SocialManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v39 (Il2CppClass<SocialManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			List<Characters.CharacterId> list = ((!gamecenterIsLoggedOut) ? null : ((List<Characters.CharacterId>)2));
			bool facebookDialogsSupported2 = SocialManager.facebookDialogsSupported;
			bool flag = ((SocialManager)facebookDialogsSupported2).HasFacebookAccessToken();
			bool flag2 = !flag;
			result = list;
			if (!flag2)
			{
				if (gamecenterIsLoggedOut)
				{
					return (List<Characters.CharacterId>)3;
				}
				return (List<Characters.CharacterId>)1;
			}
		}
		return result;
	}
}
