using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AppRefresh;
using Cpp2ILInjected;
using Data.Save;
using Info;
using Kiloo.Common.HTTP;
using Kiloo.Common.Utility;
using TopRun.Internal;

namespace Missions;

public class AwardsManager
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<Award> _003C_003E9__14_0;

		static _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Tournament._003C_003Ec obj = default;
			Tournament._003C_003Ec._003C_003E9 = obj;
		}

		public _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		internal int _003CGetSortedListAwards_003Eb__14_0(Award a1, Award a2)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 8;
			obj = a2;
			obj2 = a1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+4]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			return (int)(num - 0);
		}
	}

	private static AwardsManager _instance;

	private List<Award> _listAwards;

	private static bool _hasInited;

	public static AwardsManager instance
	{
		get
		{
			//IL_0184: Expected I, but got Obj
			//IL_019a: Expected Obj, but got I
			//IL_0245: Expected I, but got Obj
			//IL_025b: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_00ad: Expected I, but got Obj
			//IL_00c3: Expected Obj, but got I
			//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ff: Expected Obj, but got Unknown
			//IL_021f: Expected Obj, but got I4
			//IL_00ee: Expected I, but got Obj
			nint num = (nint)typeof(AwardsData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Missions.AwardsData>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(AwardsData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v47 (Il2CppClass<Missions.AwardsData>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			List<AwardId> awardOrder = AwardsData.awardOrder;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			nint num3 = (nint)typeof(AwardsData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v17 (Il2CppClass<Missions.AwardsData>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(AwardsData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v41 (Il2CppClass<Missions.AwardsData>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			List<AwardId> awardOrder2 = AwardsData.awardOrder;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S1_v11 (System.Collections.Generic.List`1<Missions.AwardId>)+C]");
			int num5 = default;
			if ((nint)num5 < (nint)0)
			{
				nint num6 = (nint)typeof(AwardsData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v27 (Il2CppClass<Missions.AwardsData>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num7 = (nint)typeof(AwardsData);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v37 (Il2CppClass<Missions.AwardsData>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A3F2");
				object obj5 = default;
				object obj4 = obj5 + 16;
				AwardId awardId = AwardsData.awardOrder.get_Item(num5);
				object obj6 = (int)awardId << 2;
				object obj7 = obj4 + obj6;
				throw new ArrayTypeMismatchException();
			}
			AwardsManager result = default;
			return result;
		}
	}

	private AwardsManager()
	{
		_ = 0;
	}

	private void OnHasRefreshed(RefreshType refreshType)
	{
	}

	private void UpdateTheNewStatusForTheAwardsOnCleanInstall()
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<Award> list = default;
		list._002Ector();
		object obj = this + 8;
		obj = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		Action<RefreshType> action = default;
		object obj2 = action + 16;
		obj2 = this;
		AppRefreshHandler.hasRefreshed -= action;
	}

	public void InitAwards()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_04c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cb: Expected Obj, but got Unknown
		//IL_04d4: Expected Obj, but got I4
		//IL_04e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e8: Expected Obj, but got Unknown
		//IL_001d: Expected Obj, but got I4
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected Obj, but got Unknown
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected Obj, but got Unknown
		//IL_0136: Expected Obj, but got I4
		//IL_013f: Expected Obj, but got I4
		//IL_0148: Expected Obj, but got I4
		//IL_0204: Expected Obj, but got I
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Expected Obj, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected Obj, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected Obj, but got Unknown
		//IL_00d7: Expected Obj, but got I4
		//IL_00e0: Expected Obj, but got I4
		//IL_00e9: Expected Obj, but got I4
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Expected Obj, but got Unknown
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Expected Obj, but got Unknown
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Expected Obj, but got Unknown
		//IL_035a: Expected Obj, but got I4
		//IL_0419: Expected Obj, but got I
		//IL_0457: Unknown result type (might be due to invalid IL or missing references)
		//IL_045c: Expected Obj, but got Unknown
		//IL_048d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0492: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		if (PreferencesSave.neverAskForRating)
		{
			return;
		}
		((PlayerSave)1)._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj5 = default;
		object obj6 = default;
		object obj11;
		object obj12;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj5 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj6 == null)
				{
					object obj7 = obj4 + 4;
					object obj8 = obj7 + 1;
					obj7 = obj8;
					object obj9 = obj8 << 2;
					object obj10 = obj4 + obj9;
					obj10 = 72;
					obj11 = 0;
					obj12 = 0;
					break;
				}
				continue;
			}
			object obj13 = obj4 + 4;
			object obj14 = obj13 + 1;
			obj13 = obj14;
			object obj15 = obj14 << 2;
			object obj16 = obj4 + obj15;
			obj16 = 72;
			obj11 = 1;
			obj12 = 0;
			break;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj17 = (nint)0 << 2;
			object obj18 = obj4 + obj17;
			if ((nint)obj18 == 72)
			{
				object obj19 = obj4 + 4;
				if ((nint)obj19 > -1)
				{
					object obj20 = obj19 + -1;
					obj19 = obj20;
				}
				goto IL_0569;
			}
		}
		if (obj12 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0569;
		IL_0569:
		if (obj11 == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj21 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj21 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		}
		object obj22 = obj4 + 4;
		object obj23 = obj22 + 1;
		obj22 = obj23;
		object obj24 = obj23 << 2;
		object obj25 = obj4 + obj24;
		obj25 = 127;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj26 = (nint)0 << 2;
			object obj27 = obj4 + obj26;
			if ((nint)obj27 == 127)
			{
				object obj28 = obj4 + 4;
				if ((nint)obj28 > -1)
				{
					object obj29 = obj28 + -1;
					obj28 = obj29;
				}
				return;
			}
		}
		if (obj12 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
	}

	private void InitAwardsIfNeeded()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_08fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0901: Expected Obj, but got Unknown
		//IL_090a: Expected Obj, but got I4
		//IL_0913: Unknown result type (might be due to invalid IL or missing references)
		//IL_0918: Expected Obj, but got Unknown
		//IL_0921: Expected Obj, but got I4
		//IL_0930: Unknown result type (might be due to invalid IL or missing references)
		//IL_0935: Expected Obj, but got Unknown
		//IL_0951: Expected I, but got Obj
		//IL_0967: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_09af: Expected I, but got Obj
		//IL_09c5: Expected Obj, but got I
		//IL_09f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f9: Expected Obj, but got Unknown
		//IL_0a07: Expected I, but got Obj
		//IL_00af: Expected I, but got Obj
		//IL_00fc: Expected I, but got Obj
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected Obj, but got Unknown
		//IL_0198: Expected Obj, but got I
		//IL_0a1f: Expected Obj, but got I4
		//IL_0781: Unknown result type (might be due to invalid IL or missing references)
		//IL_0786: Expected Obj, but got Unknown
		//IL_078f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0794: Expected Obj, but got Unknown
		//IL_07c0: Expected Obj, but got I4
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Expected Obj, but got Unknown
		//IL_06db: Expected I, but got Obj
		//IL_037e: Expected Obj, but got I4
		//IL_0848: Expected Obj, but got I
		//IL_0a4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a4f: Expected Obj, but got Unknown
		//IL_03a7: Expected I4, but got Obj
		//IL_0700: Expected I, but got Obj
		//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dc: Expected Obj, but got Unknown
		//IL_087e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0883: Expected Obj, but got Unknown
		//IL_042a: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Expected Obj, but got Unknown
		//IL_08b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b9: Expected Obj, but got Unknown
		//IL_047d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0482: Expected Obj, but got Unknown
		//IL_04d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d5: Expected Obj, but got Unknown
		//IL_0523: Unknown result type (might be due to invalid IL or missing references)
		//IL_0528: Expected Obj, but got Unknown
		//IL_0581: Unknown result type (might be due to invalid IL or missing references)
		//IL_0586: Expected Obj, but got Unknown
		//IL_05d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d9: Expected Obj, but got Unknown
		//IL_0632: Unknown result type (might be due to invalid IL or missing references)
		//IL_0637: Expected Obj, but got Unknown
		//IL_0685: Unknown result type (might be due to invalid IL or missing references)
		//IL_068a: Expected Obj, but got Unknown
		//IL_06bf: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 40;
		obj3 = 0;
		object obj4 = obj2 + 24;
		obj4 = 0;
		_ = 0;
		PersistentAwardProgress persistentAwardProgress = (PersistentAwardProgress)(obj2 + 16);
		persistentAwardProgress = (PersistentAwardProgress)obj;
		_ = -1;
		nint num = (nint)typeof(AwardsManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v20 (Il2CppClass<Missions.AwardsManager>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(AwardsManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v300 (Il2CppClass<Missions.AwardsManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(_hasInited ? 1u : 0u) == 0)
		{
			return;
		}
		nint num3 = (nint)typeof(AwardsManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v31 (Il2CppClass<Missions.AwardsManager>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num4 = (nint)typeof(AwardsManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S0_v294 (Il2CppClass<Missions.AwardsManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_hasInited = true;
		int completedRunCount = PlayerSave.completedRunCount;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB86");
		nint num5 = (nint)typeof(AwardsData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S0_v42 (Il2CppClass<Missions.AwardsData>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num6 = (nint)typeof(AwardsData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S0_v290 (Il2CppClass<Missions.AwardsData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		AwardsManager awardsManager = instance;
		object obj8 = awardsManager + 12;
		nint num7 = (nint)typeof(AwardsData);
		object obj9 = default;
		object obj26 = default;
		object obj13 = default;
		ScorePointsSingleLane scorePointsSingleLane2 = default;
		Action<Award> action = default;
		SupersneakersTimeInRowAward supersneakersTimeInRowAward2 = default;
		Action<Award> action2 = default;
		SupersneakersTimeInRowAward supersneakersTimeInRowAward3 = default;
		Action<Award> action3 = default;
		CompleteMissionsSingleRun completeMissionsSingleRun = default;
		Action<Award> action4 = default;
		SupersneakersTimeInRowAward supersneakersTimeInRowAward4 = default;
		Action<Award> action5 = default;
		DailyChallengesInRowAward dailyChallengesInRowAward = default;
		Action<Award> action6 = default;
		SupersneakersTimeInRowAward supersneakersTimeInRowAward5 = default;
		Action<Award> action7 = default;
		SupersneakersTimeInRowAward supersneakersTimeInRowAward6 = default;
		Action<Award> action8 = default;
		SupersneakersTimeInRowAward supersneakersTimeInRowAward7 = default;
		Action<Award> action9 = default;
		SupersneakersTimeInRowAward supersneakersTimeInRowAward8 = default;
		int num18 = default;
		MissionSkip missionSkip = default;
		Action<Award> action10 = default;
		SupersneakersTimeInRowAward supersneakersTimeInRowAward9 = default;
		for (; System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8); obj9 = obj26 + 1)
		{
			object obj10 = awardsManager + 16;
			object obj11 = obj9 << 2;
			object obj12 = obj10 + obj11;
			AwardStaticData awardStaticData = (AwardStaticData)obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @108D8");
			bool flag = obj13 == null;
			bool flag2 = !flag;
			ScorePointsSingleLane scorePointsSingleLane = (ScorePointsSingleLane)num7;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				scorePointsSingleLane2.ActivateCurrentAwardTier();
				obj3 = scorePointsSingleLane2;
				scorePointsSingleLane = scorePointsSingleLane2;
			}
			object obj14 = awardStaticData.awardType__BackingField - 1;
			SupersneakersTimeInRowAward supersneakersTimeInRowAward;
			if (awardStaticData.awardType__BackingField != AwardStaticData.AwardType.Stat)
			{
				if ((nint)obj14 != 1)
				{
					if ((nint)obj14 != 2)
					{
						if ((nint)obj14 != 3)
						{
							if ((nint)obj14 != 4)
							{
								if ((nint)obj14 != 5)
								{
									if ((nint)obj14 != 6)
									{
										if ((nint)obj14 != 7)
										{
											if ((nint)obj14 != 8)
											{
												if ((nint)obj14 != 9)
												{
													if ((nint)obj14 != 10)
													{
														num7 = (nint)scorePointsSingleLane;
														continue;
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
													nint num8 = 0;
													_ = 0;
													object obj15 = action + 16;
													obj15 = this;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A3FC");
													supersneakersTimeInRowAward = supersneakersTimeInRowAward2;
												}
												else
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
													nint num9 = 0;
													_ = 0;
													object obj16 = action2 + 16;
													obj16 = this;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A3FC");
													supersneakersTimeInRowAward = supersneakersTimeInRowAward3;
												}
											}
											else
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
												nint num10 = 0;
												_ = 0;
												object obj17 = action3 + 16;
												obj17 = this;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
												completeMissionsSingleRun._002Ector(awardStaticData, (PersistentAwardProgress)obj3, action3);
												supersneakersTimeInRowAward = (SupersneakersTimeInRowAward)(object)completeMissionsSingleRun;
											}
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
											nint num11 = 0;
											_ = 0;
											object obj18 = action4 + 16;
											obj18 = this;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A3FC");
											supersneakersTimeInRowAward = supersneakersTimeInRowAward4;
										}
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
										nint num12 = 0;
										_ = 0;
										object obj19 = action5 + 16;
										obj19 = this;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
										dailyChallengesInRowAward._002Ector(awardStaticData, (PersistentAwardProgress)obj3, action5);
										supersneakersTimeInRowAward = (SupersneakersTimeInRowAward)(object)dailyChallengesInRowAward;
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
									nint num13 = 0;
									_ = 0;
									object obj20 = action6 + 16;
									obj20 = this;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A3FC");
									supersneakersTimeInRowAward = supersneakersTimeInRowAward5;
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
								nint num14 = 0;
								_ = 0;
								object obj21 = action7 + 16;
								obj21 = this;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A3FC");
								supersneakersTimeInRowAward = supersneakersTimeInRowAward6;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
							nint num15 = 0;
							_ = 0;
							object obj22 = action8 + 16;
							obj22 = this;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A3FC");
							supersneakersTimeInRowAward = supersneakersTimeInRowAward7;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						nint num16 = 0;
						_ = 0;
						object obj23 = action9 + 16;
						obj23 = this;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A3FC");
						supersneakersTimeInRowAward = supersneakersTimeInRowAward8;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					nint num17 = 0;
					_ = 0;
					object obj24 = num18 + 16;
					obj24 = this;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					missionSkip._002Ector((string)(object)awardStaticData, (int)obj3, num18);
					supersneakersTimeInRowAward = (SupersneakersTimeInRowAward)(object)missionSkip;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num19 = 0;
				_ = 0;
				object obj25 = action10 + 16;
				obj25 = this;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				supersneakersTimeInRowAward9._002Ector(awardStaticData, (PersistentAwardProgress)obj3, action10);
				supersneakersTimeInRowAward = supersneakersTimeInRowAward9;
			}
			bool flag3 = supersneakersTimeInRowAward == null;
			num7 = (nint)supersneakersTimeInRowAward;
			if (!flag3)
			{
				_listAwards.Add(supersneakersTimeInRowAward);
				num7 = (nint)supersneakersTimeInRowAward;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj27 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj27 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		}
		object obj28 = persistentAwardProgress + 4;
		object obj29 = obj28 + 1;
		obj28 = obj29;
		object obj30 = obj29 << 2;
		object obj31 = (object)persistentAwardProgress + obj30;
		obj31 = 507;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v17 (Missions.PersistentAwardProgress)+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v17 (Missions.PersistentAwardProgress)+4]");
			object obj32 = (nint)0 << 2;
			object obj33 = (object)persistentAwardProgress + obj32;
			if ((nint)obj33 == 507)
			{
				object obj34 = persistentAwardProgress + 4;
				if ((nint)obj34 > -1)
				{
					object obj35 = obj34 + -1;
					obj34 = obj35;
				}
				goto IL_0ad7;
			}
		}
		object obj36 = default;
		if (obj36 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0ad7;
		IL_0ad7:
		InitAwards();
		((CollectCoinsSingleRun)this).ActivateCurrentAwardTier();
	}

	private void OnMissionStateChanged(Award award)
	{
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected Obj, but got Unknown
		//IL_0163: Expected Obj, but got I4
		//IL_002c: Expected I, but got Obj
		//IL_0042: Expected Obj, but got I
		//IL_006d: Expected I, but got Obj
		//IL_00ba: Expected I, but got Obj
		//IL_00d0: Expected Obj, but got I
		//IL_00fb: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 4;
		obj = award;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		obj2 = 2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		Enum obj3 = default;
		IFormatProvider provider = default;
		if (!obj3.System_002EIConvertible_002EToBoolean(provider))
		{
			return;
		}
		nint num = (nint)typeof(AwardsManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v17 (Il2CppClass<Missions.AwardsManager>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(AwardsManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v38 (Il2CppClass<Missions.AwardsManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(_hasInited ? 1u : 0u) != 0)
		{
			return;
		}
		nint num3 = (nint)typeof(AwardsManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v25 (Il2CppClass<Missions.AwardsManager>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num4 = (nint)typeof(AwardsManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v32 (Il2CppClass<Missions.AwardsManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_hasInited = false;
		InitAwardsIfNeeded();
	}

	private void SaveAwardProgress(Award award)
	{
		((CollectCoinsSingleRun)null).OnFrontScreen((string)(object)award);
	}

	private void SaveAllAwards()
	{
		//IL_006c: Expected I, but got Obj
		//IL_0082: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(AwardsManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Missions.AwardsManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AwardsManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v16 (Il2CppClass<Missions.AwardsManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(_hasInited ? 1u : 0u) != 0)
		{
			InitAwardsIfNeeded();
		}
	}

	public List<Award> GetAwardsForState(AwardState state)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00cf: Expected Obj, but got I
		//IL_00dd: Expected Obj, but got I4
		//IL_004f: Expected Obj, but got I
		//IL_0114: Expected Obj, but got I
		//IL_0145: Expected Obj, but got I4
		//IL_0092: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Missions.AwardsManager)+18]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ S0_v2+8]");
		if ((nint)0 == (nint)state)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Missions.AwardsManager)+1C]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v19+14]");
			if ((nint)0 != 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Missions.AwardsManager)+1C]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v24+14]");
				if ((nint)0 != 3)
				{
					goto IL_014a;
				}
			}
			goto IL_013c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Missions.AwardsManager)+18]");
		object obj4 = 0;
		object obj5 = state + 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v11+8]");
		if (0 == (nint)obj5)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Missions.AwardsManager)+1C]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v15+14]");
			if ((nint)0 == 1)
			{
				goto IL_013c;
			}
		}
		goto IL_014a;
		IL_014a:
		return null;
		IL_013c:
		return (List<Award>)1;
	}

	public unsafe List<Award> GetSortedListAwards(out bool containsCollectibleAwards)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Expected Obj, but got Unknown
		//IL_02bd: Expected Obj, but got I4
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Expected I, but got Unknown
		//IL_02d9: Expected I, but got Obj
		//IL_030b: Expected Obj, but got I
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Expected Obj, but got Unknown
		//IL_0337: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Expected Obj, but got Unknown
		//IL_0345: Expected Obj, but got I4
		//IL_03b3: Expected Obj, but got I
		//IL_01c1: Expected Obj, but got I
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected Obj, but got Unknown
		//IL_00bd: Expected Obj, but got I
		//IL_00fb: Expected Obj, but got I4
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Expected Obj, but got Unknown
		//IL_01fc: Expected Obj, but got I
		//IL_00ed: Expected Obj, but got I4
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		nint num = (nint)(obj2 + 16);
		num = (nint)obj;
		_ = -1;
		SaveAllAwards();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<Award> list = default;
		list._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj4 = default;
		object obj7 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj4 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v89+20]");
			if ((nint)0 != 0)
			{
				if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref containsCollectibleAwards) == (void*)2)
				{
					goto IL_00e4;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v89+1C]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ S0_v110+10]");
				if (null == System.Runtime.CompilerServices.Unsafe.AsPointer(ref containsCollectibleAwards))
				{
					goto IL_00e4;
				}
			}
			object obj6 = 0;
			goto IL_034a;
			IL_034a:
			if (obj6 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				if (obj7 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				}
			}
			continue;
			IL_00e4:
			obj6 = 1;
			goto IL_034a;
		}
		object obj8 = num + 4;
		object obj9 = obj8 + 1;
		obj8 = obj9;
		object obj10 = obj9 << 2;
		object obj11 = num + obj10;
		obj11 = 84;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15 (Il2CppMethodInfo)+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15 (Il2CppMethodInfo)+4]");
			object obj12 = (nint)0 << 2;
			object obj13 = num + obj12;
			if ((nint)obj13 == 84)
			{
				object obj14 = num + 4;
				if ((nint)obj14 > -1)
				{
					object obj15 = obj14 + -1;
					obj14 = obj15;
				}
				goto IL_03a5;
			}
		}
		object obj16 = default;
		if (obj16 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_03a5;
		IL_03a5:
		object obj17 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref containsCollectibleAwards) & (nint)(-2);
		if ((nint)obj17 == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num2 = 0;
			_ = 0;
			object obj19 = default;
			object obj18 = obj19 + 16;
			obj18 = this;
			throw new NullReferenceException();
		}
		return list;
	}

	public int GetNumberOfNewVisibleAwards()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Missions.AwardsManager)+14]");
		return 0;
	}

	public int GetTotalAwardTiers()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Expected Obj, but got Unknown
		//IL_0215: Expected Obj, but got I4
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Expected Obj, but got Unknown
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Expected Obj, but got Unknown
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Expected Obj, but got Unknown
		//IL_02a9: Expected Obj, but got I4
		//IL_0154: Expected Obj, but got I
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected Obj, but got Unknown
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		if (_listAwards == null)
		{
			InitAwardsIfNeeded();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj5 = default;
		object obj6 = default;
		object obj7 = default;
		int result = default;
		int num = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj5 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj6 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				if (obj7 != null)
				{
					result = num + 1;
				}
			}
		}
		object obj8 = obj4 + 4;
		object obj9 = obj8 + 1;
		obj8 = obj9;
		object obj10 = obj9 << 2;
		object obj11 = obj4 + obj10;
		obj11 = 84;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj12 = (nint)0 << 2;
			object obj13 = obj4 + obj12;
			if ((nint)obj13 == 84)
			{
				object obj14 = obj4 + 4;
				if ((nint)obj14 > -1)
				{
					object obj15 = obj14 + -1;
					obj14 = obj15;
				}
				goto IL_02e7;
			}
		}
		object obj16 = default;
		if (obj16 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_02e7;
		IL_02e7:
		return result;
	}

	public unsafe int GetTotalCompletedTiers()
	{
		//IL_00df: Expected I, but got Obj
		//IL_00f5: Expected Obj, but got I
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Expected Obj, but got Unknown
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected I, but got Unknown
		//IL_0190: Expected I, but got Obj
		//IL_01ab: Expected I, but got Obj
		//IL_01c1: Expected Obj, but got I
		//IL_013a: Expected I, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_00af: Expected Obj, but got I4
		//IL_00bf: Expected Obj, but got I4
		//IL_00cc: Expected I4, but got Obj
		//IL_0060: Expected I, but got Obj
		nint num = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v11 (Il2CppClass<System.Type>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v30 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 4;
		obj2 = typeof(AwardTierType);
		nint num3 = (nint)(obj3 + 8);
		((IntPtr*)num3)->m_value = (void*)(nint)obj2;
		Type enumType = Type.internal_from_handle((IntPtr)num3);
		nint num4 = (nint)typeof(Enum);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S1_v11 (Il2CppClass<System.Enum>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num5 = (nint)typeof(Enum);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S1_v27 (Il2CppClass<System.Enum>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string[] array = Enum.InternalGetNames((System.RuntimeType)enumType);
		obj3 = typeof(AwardId);
		((IntPtr*)num3)->m_value = (void*)(nint)obj3;
		Type enumType2 = Type.internal_from_handle((IntPtr)num3);
		string[] array2 = Enum.InternalGetNames((System.RuntimeType)enumType2);
		object obj5 = array2.Length - 1;
		object obj6 = array.Length - 1;
		return obj5 * obj6;
	}

	public float GetAwardsPercentageComplete()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string saveDataPath = OnlineSettings.GetSaveDataPath();
		return (float)((IConvertible)saveDataPath).ToDouble((IFormatProvider)(object)"toprun_request_max_back_off_time");
	}

	public unsafe int GetNumberOfFinishedAwardsExactTier(AwardTierType awardTierType)
	{
		//IL_0259: Expected Obj, but got I
		//IL_0269: Expected Obj, but got I
		//IL_0279: Expected Obj, but got I
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Expected Obj, but got Unknown
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Expected Obj, but got Unknown
		//IL_02a4: Expected I4, but got Obj
		//IL_0059: Expected Obj, but got I
		//IL_0069: Expected Obj, but got I
		//IL_0079: Expected Obj, but got I
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected Obj, but got Unknown
		//IL_00b2: Expected I, but got Obj
		//IL_00c8: Expected Obj, but got I
		//IL_00f3: Expected I, but got Obj
		//IL_0140: Expected I, but got Obj
		//IL_0156: Expected Obj, but got I
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Expected Obj, but got Unknown
		//IL_030a: Expected I, but got Obj
		//IL_0320: Expected Obj, but got I
		//IL_0181: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<Award> list = default;
		list._002Ector();
		((AwardTierType*)(int)awardTierType)->value__ = 0;
		List<Award> sortedListAwards = GetSortedListAwards(out *(bool*)2);
		if (sortedListAwards._size >= 1)
		{
			((AwardTierType*)(int)awardTierType)->value__ = 1;
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S3_v14 (Il2CppMethodInfo)+C]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S3_v15+60]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S3_v16+38]");
			object obj3 = 0;
			object obj4 = obj3 & 0x1FFF;
			object obj5 = obj4 + 113696;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v49 @ S4_v14 (should have been resolved before IL gen)");
		}
		List<Award> sortedListAwards2 = GetSortedListAwards(out *(bool*)1);
		if (sortedListAwards2._size >= 1)
		{
			nint num2 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v24 (Il2CppClass<Missions.AwardsManager+<>c>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num3 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v62 (Il2CppClass<Missions.AwardsManager+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (_003C_003Ec._003C_003E9__14_0 == null)
			{
				nint num4 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S0_v36 (Il2CppClass<Missions.AwardsManager+<>c>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num5 = (nint)typeof(_003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ S0_v56 (Il2CppClass<Missions.AwardsManager+<>c>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num6 = 0;
				_ = 0;
				object obj9 = default;
				object obj8 = obj9 + 16;
				obj8 = _003C_003Ec._003C_003E9;
				nint num7 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ S0_v53 (Il2CppClass<Missions.AwardsManager+<>c>)+5C]");
				object obj10 = (nint)0 + (nint)4;
				obj10 = obj9;
			}
			throw new NullReferenceException();
		}
		List<Award> sortedListAwards3 = GetSortedListAwards(out *(bool*)3);
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S3_v4 (Il2CppMethodInfo)+C]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S3_v5+60]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S3_v6+38]");
		object obj13 = 0;
		object obj14 = obj13 & 0x1FFF;
		object obj15 = obj14 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v143 @ S4_v6 (should have been resolved before IL gen)");
		return (int)list;
	}

	private bool ShouldInsertAwardToList(Award award)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected Obj, but got Unknown
		//IL_01df: Expected Obj, but got I4
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected Obj, but got Unknown
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Expected Obj, but got Unknown
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected Obj, but got Unknown
		//IL_027c: Expected Obj, but got I4
		//IL_011e: Expected Obj, but got I
		//IL_0069: Expected I4, but got Obj
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected Obj, but got Unknown
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		SaveAllAwards();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		bool flag = false;
		object obj5 = default;
		AwardsManager awardsManager = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj5 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (awardsManager != null)
			{
				List<Award> awardsForState = awardsManager.GetAwardsForState((AwardState)award);
				if (awardsForState != null)
				{
					bool flag2 = (byte)((flag ? 1u : 0u) + 1u) != 0;
					flag = flag2;
				}
			}
		}
		object obj6 = obj4 + 4;
		object obj7 = obj6 + 1;
		obj6 = obj7;
		object obj8 = obj7 << 2;
		object obj9 = obj4 + obj8;
		obj9 = 71;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj10 = (nint)0 << 2;
			object obj11 = obj4 + obj10;
			if ((nint)obj11 == 71)
			{
				object obj12 = obj4 + 4;
				if ((nint)obj12 > -1)
				{
					object obj13 = obj12 + -1;
					obj12 = obj13;
				}
				goto IL_02ba;
			}
		}
		object obj14 = default;
		if (obj14 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_02ba;
		IL_02ba:
		return flag;
	}

	private unsafe int SortAwardByDate(Award a, Award b)
	{
		//IL_019b: Expected Obj, but got I4
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected Obj, but got Unknown
		//IL_0020: Expected I, but got Obj
		//IL_0036: Expected Obj, but got I
		//IL_0061: Expected I, but got Obj
		//IL_00ee: Expected Obj, but got VT
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected Obj, but got Unknown
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected VT, but got Unknown
		//IL_015e: Expected I4, but got Obj
		//IL_0159: Expected native int or pointer, but got VT
		//IL_0173: Expected Obj, but got I
		//IL_016e: Expected native int or pointer, but got VT
		//IL_0188: Expected I4, but got Obj
		object obj = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj3 = default;
		object obj2 = obj3 + 8;
		obj2 = b;
		string otherUri = $"http://graph.facebook.com/{(object[])(object)a}/picture?width=64&height=64";
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Uri uri = default;
		uri.CreateThisFromUri((Uri)(object)otherUri);
		nint num = (nint)typeof(WebClient);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v21 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(WebClient);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v32 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		IRequest request = WebClient.CreatePut(uri);
		float requestMinBackOffTime = ((Manager)null).requestMinBackOffTime;
		IRequest request2 = RequestExtensions.WithKeepAlive(request, requestMinBackOffTime);
		float requestMaxBackOffTime = ((Manager)null).requestMaxBackOffTime;
		IRequest request3 = RequestExtensions.WithMaxBackOffTime(request2, requestMaxBackOffTime);
		float awardsPercentageComplete = ((AwardsManager)null).GetAwardsPercentageComplete();
		Wait.Config.TimeConfig timeConfig = ((Wait.Config)request3).For(awardsPercentageComplete);
		IRequest request4 = RequestExtensions.WithIgnoreContentMD5((IRequest)timeConfig, ignoreContentMD5: true);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		WebClient.RequestCompleteHandler requestCompleteHandler = default;
		((Delegate)requestCompleteHandler).method_ptr = method_ptr;
		((Delegate)requestCompleteHandler).method = (nint)__ldftn(Manager._003C_003Ec__DisplayClass97_0._003CDownloadFacebookImage_003Eb__0);
		object obj5 = requestCompleteHandler + 16;
		obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		WebClient.SendOptions sendOptions = (WebClient.SendOptions)(obj + 16);
		((WebClient.SendOptions*)(nint)sendOptions)->disableCache = (byte)(int)obj != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		System.Runtime.CompilerServices.Unsafe.Write(&((WebClient.SendOptions*)(nint)sendOptions)->simulatedRequestResults, (IList<SimulatedRequestResult>)0);
		return (int)RequestExtensions.SendAsync(request4, requestCompleteHandler, sendOptions);
	}

	public Award GetAwardForId(AwardId id)
	{
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_009a: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0062: Expected Obj, but got I
		nint num = (nint)typeof(AgeRestriction);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.AgeRestriction>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AgeRestriction);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v21 (Il2CppClass<Info.AgeRestriction>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (AgeRestriction.waitForAgeRestriction)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [id @ L1 (Missions.AwardId)+8]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v17+20]");
			if ((nint)0 != 0)
			{
				return null;
			}
		}
		return (Award)1;
	}

	public bool ShouldSpawnOldTrophyForStat(Stat stat)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Expected Obj, but got Unknown
		//IL_0306: Expected Obj, but got I4
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		//IL_031a: Expected Obj, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected Obj, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected Obj, but got Unknown
		//IL_010b: Expected Obj, but got I4
		//IL_004f: Expected Obj, but got I
		//IL_0193: Expected Obj, but got I
		//IL_025a: Expected Obj, but got I
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected Obj, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got Unknown
		//IL_00be: Expected Obj, but got I4
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected Obj, but got Unknown
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Expected Obj, but got Unknown
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Expected Obj, but got Unknown
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		SaveAllAwards();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj5 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj5 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v88 (System.Boolean)+8]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S0_v92+8]");
				if ((nint)0 == (nint)stat)
				{
					object obj7 = obj4 + 4;
					object obj8 = obj7 + 1;
					obj7 = obj8;
					object obj9 = obj8 << 2;
					object obj10 = obj4 + obj9;
					obj10 = 73;
					break;
				}
				continue;
			}
			object obj11 = obj4 + 4;
			object obj12 = obj11 + 1;
			obj11 = obj12;
			object obj13 = obj12 << 2;
			object obj14 = obj4 + obj13;
			obj14 = 71;
			break;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj15 = (nint)0 << 2;
			object obj16 = obj4 + obj15;
			if ((nint)obj16 == 73)
			{
				object obj17 = obj4 + 4;
				if ((nint)obj17 > -1)
				{
					object obj18 = obj17 + -1;
					obj17 = obj18;
				}
				goto IL_03ad;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj19 = (nint)0 << 2;
			object obj20 = obj4 + obj19;
			if ((nint)obj20 == 71)
			{
				object obj21 = obj4 + 4;
				if ((nint)obj21 > -1)
				{
					object obj22 = obj21 + -1;
					obj21 = obj22;
				}
				goto IL_03ad;
			}
		}
		object obj23 = default;
		if (obj23 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_03ad;
		IL_03ad:
		bool result = default;
		return result;
	}
}
