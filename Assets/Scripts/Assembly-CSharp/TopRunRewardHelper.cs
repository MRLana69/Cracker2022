using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using TopRun;

public static class TopRunRewardHelper
{
	private static int _amountOfFriendsBeaten;

	public static void PrepareAndCallCelebrationScreen(IManager manager)
	{
		CelebrationReward pendingReward = GetPendingReward();
		RewardManager.AddRewardToUnlock(pendingReward);
		PlayerInfo instance = PlayerInfo.Instance;
		PlayerInfo instance2 = PlayerInfo.Instance;
		instance.lastTopRunResultAwardedID = instance2._pendingTopRunResultID;
		UIScreenController instance3 = UIScreenController.Instance;
		instance3.QueuePopup("CelebrationPopup");
	}

	private static void GivePendingRewardSilently(PlayerInfo playerInfo)
	{
		//IL_0032: Expected I, but got Obj
		CelebrationReward pendingReward = GetPendingReward();
		TrackRewardStats(pendingReward);
		playerInfo.lastTopRunResultAwardedID = playerInfo._pendingTopRunResultID;
		TopRunEventsHandler instance = TopRunEventsHandler.instance;
		TopRunEventsHandler instance2 = TopRunEventsHandler.instance;
		TournamentChangedEventArgs e = default;
		e._002Ector();
		nint num = (nint)instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v33 @ S3_v2 (Il2CppClass<TopRunEventsHandler>)+DC] (should have been resolved before IL gen)");
	}

	public static bool ShouldShowResults()
	{
		//IL_002a: Expected Obj, but got I4
		//IL_000e: Expected Obj, but got I4
		PlayerInfo instance = PlayerInfo.Instance;
		string pendingTopRunResultID = instance._pendingTopRunResultID;
		object obj;
		if (instance._pendingTopRunResultID != null)
		{
			obj = 0;
			if (pendingTopRunResultID._stringLength != 0)
			{
				goto IL_00bf;
			}
		}
		obj = 1;
		goto IL_00bf;
		IL_00bf:
		if (obj != null)
		{
			return false;
		}
		PlayerInfo instance2 = PlayerInfo.Instance;
		PlayerInfo instance3 = PlayerInfo.Instance;
		bool flag = string.Equals(instance2._pendingTopRunResultID, instance3._lastTopRunResultAwardedID);
		return (byte)((flag ? 1u : 0u) ^ 1u) != 0;
	}

	private static CelebrationReward GetPendingReward()
	{
		//IL_0020: Expected I4, but got I8
		CelebrationReward celebrationReward = default;
		celebrationReward._002Ector();
		PlayerInfo instance = PlayerInfo.Instance;
		celebrationReward.CelebrationRewardOrigin = CelebrationRewardOrigin.TopRun;
		int rank = instance._pendingTopRunResultsRank + 1;
		celebrationReward.rank = rank;
		celebrationReward.score = instance._pendingTopRunResultsScore;
		celebrationReward.weekNumber = instance._pendingTopRunResultsWeek;
		return celebrationReward;
	}

	public static void RefreshPendingResults()
	{
		//IL_00fa: Expected Obj, but got I4
		//IL_00de: Expected Obj, but got I4
		PlayerInfo instance = PlayerInfo.Instance;
		if (TopRunRoot.manager__BackingField == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		object obj = default;
		if (obj == null || instance == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		object obj2 = default;
		if (obj2 == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		object obj3 = default;
		if ((nint)obj3 < 1)
		{
			return;
		}
		string pendingTopRunResultID = instance._pendingTopRunResultID;
		object obj4;
		if (instance._pendingTopRunResultID != null)
		{
			obj4 = 0;
			if (pendingTopRunResultID._stringLength != 0)
			{
				goto IL_01ac;
			}
		}
		obj4 = 1;
		goto IL_01ac;
		IL_01ac:
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			string text = default;
			if (!(instance._pendingTopRunResultID != text))
			{
				return;
			}
			CalculateBeatenFriendsAward();
			if (instance._lastTopRunResultAwardedID != instance._pendingTopRunResultID)
			{
				GivePendingRewardSilently(instance);
			}
		}
		OverridePendingResults(TopRunRoot.manager__BackingField, instance);
	}

	private static void CalculateBeatenFriendsAward()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_007d: Expected Obj, but got I
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected Obj, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected Obj, but got Unknown
		//IL_064f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0654: Expected Obj, but got Unknown
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Expected Obj, but got Unknown
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Expected Obj, but got Unknown
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Expected Obj, but got Unknown
		//IL_06a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a8: Expected Obj, but got Unknown
		//IL_05b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05be: Expected Obj, but got Unknown
		//IL_04fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0502: Expected Obj, but got Unknown
		//IL_0542: Unknown result type (might be due to invalid IL or missing references)
		//IL_0547: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		if (TopRunRoot.manager__BackingField == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		object obj3 = default;
		if (obj3 == null)
		{
			return;
		}
		List<IPlayer> list = default;
		list._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S4_v4 (Il2CppRgctx<System.Collections.Generic.List`1<TopRun.IPlayer>>)+3C]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v136 @ S4_v5+4] (should have been resolved before IL gen)");
		List<IPlayer> list2 = default;
		list2._002Ector();
		object obj5 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj6 = obj + 32;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj8 = default;
		object obj9 = default;
		object obj10 = default;
		object obj11 = default;
		object obj13 = default;
		object obj14 = default;
		object obj21 = default;
		object obj22 = default;
		object obj23 = default;
		object obj24 = default;
		object obj25 = default;
		object obj26 = default;
		object obj27 = default;
		while (true)
		{
			_ = 0;
			object obj7 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				if (obj8 == null)
				{
					goto IL_02a1;
				}
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						if (obj9 == null)
						{
							continue;
						}
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag = obj10 != obj11;
			object obj12 = obj13;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					goto IL_02a1;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj12 = obj14;
			}
			_ = 0;
			object obj15 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag2 = (nint)0 != 1;
			object obj16 = obj12;
			if (flag2)
			{
				break;
			}
			goto IL_05fe;
			IL_05fe:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			obj16 = obj12;
			break;
			IL_02a1:
			object obj17 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3B20");
			object obj18 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			_ = 0;
			object obj19 = obj + 32;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			while (true)
			{
				_ = 0;
				object obj20 = obj + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					if (obj21 == null)
					{
						goto IL_04f4;
					}
					_ = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj22) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj23))
								{
									int amountOfFriendsBeaten = _amountOfFriendsBeaten + 1;
									_amountOfFriendsBeaten = amountOfFriendsBeaten;
								}
								continue;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				bool flag3 = obj24 != obj25;
				obj12 = obj26;
				if (flag3)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					goto IL_04f4;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj12 = obj27;
				break;
				IL_04f4:
				object obj28 = obj + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3B20");
				return;
			}
			_ = 0;
			object obj29 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				obj16 = obj12;
				break;
			}
			goto IL_05fe;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
	}

	private static void OverridePendingResults(IManager manager, PlayerInfo playerInfo)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		string pendingTopRunResultID = default;
		playerInfo.pendingTopRunResultID = pendingTopRunResultID;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		int num = default;
		if (num != playerInfo._pendingTopRunResultsWeek)
		{
			playerInfo._dirty = true;
			playerInfo._pendingTopRunResultsWeek = num;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		int num2 = default;
		if (num2 != playerInfo._pendingTopRunResultsScore)
		{
			playerInfo._dirty = true;
			playerInfo._pendingTopRunResultsScore = num2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
		int num3 = default;
		if (num3 != playerInfo._pendingTopRunResultsRank)
		{
			playerInfo._dirty = true;
			playerInfo._pendingTopRunResultsRank = num3;
		}
		if (_amountOfFriendsBeaten != playerInfo._pendingTopRunBeatenFriendsAward)
		{
			playerInfo._dirty = true;
			playerInfo._pendingTopRunBeatenFriendsAward = _amountOfFriendsBeaten;
		}
	}

	public static void TrackRewardStats(CelebrationReward reward)
	{
		//IL_058a: Expected Obj, but got I4
		//IL_0444: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Expected Obj, but got Unknown
		object obj = reward.rank - 1;
		if (reward.rank != 1)
		{
			if ((nint)obj != 1)
			{
				if ((nint)obj != 2)
				{
					if ((nint)obj != 3)
					{
						if ((nint)obj != 4)
						{
							if ((nint)obj != 5)
							{
								if ((nint)obj != 6)
								{
									if ((nint)obj != 7)
									{
										if ((nint)obj != 8)
										{
											if ((nint)obj != 9)
											{
												if ((nint)obj != 10)
												{
													PlayerInfo instance = PlayerInfo.Instance;
													Statistics stats = instance._stats;
													int[] values = stats._values;
													int value = values[0] + 1;
													stats.set_Item(Stat.NotSet, value);
												}
												else
												{
													PlayerInfo instance2 = PlayerInfo.Instance;
													Statistics stats2 = instance2._stats;
													int[] values2 = stats2._values;
													int value2 = values2[23] + 1;
													stats2.set_Item(Stat.TopRunRank10, value2);
												}
											}
											else
											{
												PlayerInfo instance3 = PlayerInfo.Instance;
												Statistics stats3 = instance3._stats;
												int[] values3 = stats3._values;
												int value3 = values3[22] + 1;
												stats3.set_Item(Stat.TopRunRank9, value3);
											}
										}
										else
										{
											PlayerInfo instance4 = PlayerInfo.Instance;
											Statistics stats4 = instance4._stats;
											int[] values4 = stats4._values;
											int value4 = values4[21] + 1;
											stats4.set_Item(Stat.TopRunRank8, value4);
										}
									}
									else
									{
										PlayerInfo instance5 = PlayerInfo.Instance;
										Statistics stats5 = instance5._stats;
										int[] values5 = stats5._values;
										int value5 = values5[20] + 1;
										stats5.set_Item(Stat.TopRunRank7, value5);
									}
								}
								else
								{
									PlayerInfo instance6 = PlayerInfo.Instance;
									Statistics stats6 = instance6._stats;
									int[] values6 = stats6._values;
									int value6 = values6[19] + 1;
									stats6.set_Item(Stat.TopRunRank6, value6);
								}
							}
							else
							{
								PlayerInfo instance7 = PlayerInfo.Instance;
								Statistics stats7 = instance7._stats;
								int[] values7 = stats7._values;
								int value7 = values7[18] + 1;
								stats7.set_Item(Stat.TopRunRank5, value7);
							}
						}
						else
						{
							PlayerInfo instance8 = PlayerInfo.Instance;
							Statistics stats8 = instance8._stats;
							int[] values8 = stats8._values;
							int value8 = values8[17] + 1;
							stats8.set_Item(Stat.TopRunRank4, value8);
						}
						return;
					}
					PlayerInfo instance9 = PlayerInfo.Instance;
					Statistics stats9 = instance9._stats;
					object obj2 = stats9._values - -64;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S2_v20+10]");
					int value9 = (int)((nint)0 + (nint)1);
					stats9.set_Item(Stat.TopRunRank3, value9);
				}
				else
				{
					PlayerInfo instance10 = PlayerInfo.Instance;
					Statistics stats10 = instance10._stats;
					int[] values9 = stats10._values;
					int value10 = values9[15] + 1;
					stats10.set_Item(Stat.TopRunRank2, value10);
				}
			}
			else
			{
				PlayerInfo instance11 = PlayerInfo.Instance;
				Statistics stats11 = instance11._stats;
				int[] values10 = stats11._values;
				int value11 = values10[14] + 1;
				stats11.set_Item(Stat.TopRunRank1, value11);
			}
		}
		else
		{
			PlayerInfo instance12 = PlayerInfo.Instance;
			Statistics stats12 = instance12._stats;
			int[] values11 = stats12._values;
			int value12 = values11[28] + 1;
			stats12.set_Item(Stat.TopRunRank0, value12);
		}
		PlayerInfo instance13 = PlayerInfo.Instance;
		Statistics stats13 = instance13._stats;
		int[] values12 = stats13._values;
		int value13 = values12[24] + 1;
		stats13.set_Item(Stat.TopRunRank5orBetter, value13);
	}
}
