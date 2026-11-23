using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using Info;
using Kiloo;
using SYBO.Subway;
using SYBO.Subway.Info;
using UnityEngine;

public static class WeeklyHuntManager
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
		public int itemsToColect;

		public int itemsCollected;

		public bool hiddenUntilUnlocked;

		public StringID periodTitle;

		public DateTime periodStartDate;

		public DateTime periodEndDate;

		public PrizeData mainPrize;

		public PrizeData alternatePrize;

		public bool hasAlternatePrize;

		public bool alternatePrizeCondition;
	}

	public struct PrizeData
	{
		public int amount;

		public CelebrationRewardOrigin CelebrationRewardOrigin;

		public CelebrationRewardType rewardType;

		public PowerupType powerupType;

		public Characters.CharacterType characterType;

		public Hoverboards.BoardType boardType;

		public Trophies.Trophy trophyType;

		public string name;
	}

	private static DateTime START_CHALLANGE_DATE_TIME;

	private static bool _hasInited;

	public static bool HIDE_LAST_PERIOD;

	public static Vector3 HUNT_ITEM_POSITION_OFFSET;

	public static Vector3 HUNT_ITEM_ROTATION;

	public static Vector3 HUNT_ITEM_SCALE;

	public static bool _canCollectAllTokensInOneRun;

	private static Dictionary<int, WeeklyHuntPeriodData> huntPeriodData;

	private static Action _003C_003Ef__mg_0024cache0;

	private static Action _003C_003Ef__mg_0024cache1;

	private static Action m_ItemCountUpdated;

	public static event Action ItemCountUpdated
	{
		add
		{
			//IL_0013: Expected I, but got Obj
			//IL_0029: Expected Obj, but got I
			Delegate obj = WeeklyHuntManager.m_ItemCountUpdated;
			Delegate obj5 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				nint num = (nint)typeof(WeeklyHuntManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S1_v7 (Il2CppClass<WeeklyHuntManager>)+5C]");
				object obj3 = -(-64);
				bool flag = obj == obj3;
				Delegate obj4 = obj5;
				if (!flag)
				{
					obj4 = (Delegate)obj3;
				}
				obj3 = obj4;
				Delegate obj6 = obj;
				if (!flag)
				{
					obj6 = (Delegate)obj3;
				}
				flag2 = (object)obj != obj6;
				obj = obj6;
			}
			while (flag2);
		}
		remove
		{
			//IL_0013: Expected I, but got Obj
			//IL_0029: Expected Obj, but got I
			Delegate obj = WeeklyHuntManager.m_ItemCountUpdated;
			Delegate obj5 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				nint num = (nint)typeof(WeeklyHuntManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S1_v7 (Il2CppClass<WeeklyHuntManager>)+5C]");
				object obj3 = -(-64);
				bool flag = obj == obj3;
				Delegate obj4 = obj5;
				if (!flag)
				{
					obj4 = (Delegate)obj3;
				}
				obj3 = obj4;
				Delegate obj6 = obj;
				if (!flag)
				{
					obj6 = (Delegate)obj3;
				}
				flag2 = (object)obj != obj6;
				obj = obj6;
			}
			while (flag2);
		}
	}

	public static void UpdateHuntData(DateTime dateTime)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_06db: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e0: Expected Obj, but got Unknown
		//IL_071a: Unknown result type (might be due to invalid IL or missing references)
		//IL_071f: Expected Obj, but got Unknown
		//IL_0764: Unknown result type (might be due to invalid IL or missing references)
		//IL_0769: Expected Obj, but got Unknown
		//IL_0745: Unknown result type (might be due to invalid IL or missing references)
		//IL_074a: Expected Obj, but got Unknown
		//IL_062c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0631: Expected Obj, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected Obj, but got Unknown
		//IL_069d: Expected Obj, but got I
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected Obj, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected Obj, but got Unknown
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected Obj, but got Unknown
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected Obj, but got Unknown
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected Obj, but got Unknown
		//IL_01ad: Expected Obj, but got I
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Expected Obj, but got Unknown
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Expected Obj, but got Unknown
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected Obj, but got Unknown
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Expected Obj, but got Unknown
		//IL_0325: Expected Obj, but got I
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0364: Expected Obj, but got Unknown
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ad: Expected Obj, but got Unknown
		//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f6: Expected Obj, but got Unknown
		//IL_043a: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 96;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		object obj3 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @442");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj4 = obj - -64;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj6 = default;
		object obj7;
		object obj11 = default;
		object obj23 = default;
		object obj24 = default;
		object obj26 = default;
		object obj27 = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				bool flag = obj6 == null;
				obj7 = obj;
				if (flag)
				{
					break;
				}
				_ = 0;
				object obj8 = obj - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S1_v52+C]");
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
					_ = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						object obj9 = obj + 88;
						object obj10 = obj11 * 7;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1477");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							object obj12 = obj + 88;
							obj11++;
							object obj13 = obj11 * 7;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1477");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3C]");
								object obj14 = 0;
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									_ = 0;
									object obj15 = obj + 48;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										_ = 0;
										object obj16 = obj + 48;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											_ = 0;
											object obj17 = obj + 48;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 != 1)
											{
												_ = 0;
												_ = 0;
												object obj18 = obj + 8;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 != 1)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
													_ = 0;
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3C]");
													object obj19 = 0;
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													if ((nint)0 != 1)
													{
														_ = 0;
														object obj20 = obj + 40;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
														if ((nint)0 != 1)
														{
															_ = 0;
															object obj21 = obj + 40;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
															if ((nint)0 != 1)
															{
																_ = 0;
																object obj22 = obj + 40;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
																_ = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																if ((nint)0 != 1)
																{
																	_ = 0;
																	obj = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
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
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag2 = obj23 == obj24;
			bool flag3 = !flag2;
			object obj25 = obj26;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag4 = (nint)0 != 1;
				obj7 = obj;
				if (flag4)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj25 = obj27;
			}
			_ = 0;
			object obj28 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				obj7 = 0;
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			return;
		}
		object obj29 = obj7 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @ADBB");
	}

	public static bool IsAnyPeriodActive()
	{
		InitIfNeeded();
		PrizePeriodId activePeriode = GetActivePeriode();
		bool flag = activePeriode == PrizePeriodId.None;
		bool result = false;
		if (!flag)
		{
			WeeklyHuntPeriodData weeklyHuntPeriodData = huntPeriodData.get_Item((int)activePeriode);
			bool flag2 = weeklyHuntPeriodData.itemsCollected >= weeklyHuntPeriodData.itemsToColect;
			result = false;
			if (!flag2)
			{
				result = true;
				if (weeklyHuntPeriodData.itemsCollected == 0)
				{
					_canCollectAllTokensInOneRun = true;
					result = true;
				}
			}
		}
		return result;
	}

	public static bool IsHuntStillActive()
	{
		InitIfNeeded();
		WeeklyHuntPeriodData weeklyHuntPeriodData = huntPeriodData.get_Item(1);
		int key = 3;
		if (!HIDE_LAST_PERIOD)
		{
			key = 4;
		}
		WeeklyHuntPeriodData weeklyHuntPeriodData2 = huntPeriodData.get_Item(key);
		DateTime now = CDateTime.Now;
		int num = DateTime.Compare(weeklyHuntPeriodData2.periodEndDate, now);
		bool result;
		if (num >= 0)
		{
			DateTime now2 = CDateTime.Now;
			int num2 = DateTime.Compare(weeklyHuntPeriodData.periodStartDate, now2);
			bool flag = num2 < 1;
			result = true;
			if (flag)
			{
				goto IL_0101;
			}
		}
		result = false;
		goto IL_0101;
		IL_0101:
		return result;
	}

	public unsafe static PrizePeriodId GetActivePeriode()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected Obj, but got Unknown
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected VT, but got Unknown
		//IL_01b6: Expected Ref, but got VT
		//IL_0083: Expected Obj, but got I
		//IL_00a6: Expected VT, but got I
		//IL_00ea: Expected VT, but got I
		object obj2 = default;
		object obj = obj2 + -64;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		InitIfNeeded();
		object obj3 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @442");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		PrizePeriodId result;
		while (true)
		{
			Dictionary<int, WeeklyHuntPeriodData>.Enumerator enumerator = (Dictionary<int, WeeklyHuntPeriodData>.Enumerator)(obj + 40);
			bool flag = ((Dictionary<int, WeeklyHuntPeriodData>.Enumerator*)enumerator)->MoveNext();
			bool flag2 = !flag;
			result = PrizePeriodId.None;
			if (flag2)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+34]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+34]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+24]");
			object obj4 = 0;
			DateTime now = CDateTime.Now;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v44+20]");
			int num = DateTime.Compare((DateTime)0, now);
			if (num < 0)
			{
				continue;
			}
			DateTime now2 = CDateTime.Now;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v44+18]");
			int num2 = DateTime.Compare((DateTime)0, now2);
			if (num2 <= 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
				bool flag3 = (nint)0 != 4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
				result = PrizePeriodId.None;
				if (flag3)
				{
					break;
				}
				if (!HIDE_LAST_PERIOD)
				{
					result = PrizePeriodId.PeriodFour;
					break;
				}
			}
		}
		return result;
	}

	public static PeriodStatus GetPeriodStatus(PrizePeriodId period)
	{
		InitIfNeeded();
		WeeklyHuntPeriodData weeklyHuntPeriodData = huntPeriodData.get_Item((int)period);
		DateTime now = CDateTime.Now;
		int num = DateTime.Compare(weeklyHuntPeriodData.periodEndDate, now);
		if (num >= 0)
		{
			DateTime now2 = CDateTime.Now;
			int num2 = DateTime.Compare(weeklyHuntPeriodData.periodStartDate, now2);
			if (num2 < 1)
			{
				return PeriodStatus.Current;
			}
		}
		DateTime now3 = CDateTime.Now;
		int num3 = DateTime.Compare(weeklyHuntPeriodData.periodEndDate, now3);
		return (PeriodStatus)(num3 >> 31);
	}

	public static WeeklyHuntPeriodData GetPrizeDataForPeriod(PrizePeriodId period)
	{
		InitIfNeeded();
		if (period == PrizePeriodId.None)
		{
			if (~(HIDE_LAST_PERIOD ? 1u : 0u) == 0)
			{
				return huntPeriodData.get_Item(3);
			}
			return huntPeriodData.get_Item(4);
		}
		return huntPeriodData.get_Item((int)period);
	}

	public static bool CanSpawnToken()
	{
		if (IsAnyPeriodActive())
		{
			PrizePeriodId activePeriode = GetActivePeriode();
			WeeklyHuntPeriodData prizeDataForPeriod = GetPrizeDataForPeriod(activePeriode);
			return prizeDataForPeriod.itemsCollected < prizeDataForPeriod.itemsToColect;
		}
		return false;
	}

	public static bool GetHiddenUntilUnlockedForPeriod(PrizePeriodId period)
	{
		InitIfNeeded();
		if (period != PrizePeriodId.None)
		{
			WeeklyHuntPeriodData weeklyHuntPeriodData = huntPeriodData.get_Item((int)period);
			return weeklyHuntPeriodData.hiddenUntilUnlocked;
		}
		return false;
	}

	private static CelebrationReward GetRewardForPeriod(PrizePeriodId period)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0529: Expected Obj, but got I
		//IL_053c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0541: Expected Obj, but got Unknown
		//IL_0040: Expected Obj, but got I
		//IL_0116: Expected I4, but got Obj
		//IL_014f: Expected Obj, but got I
		//IL_0310: Expected I4, but got Obj
		//IL_0349: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 32;
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Int32, WeeklyHuntManager+WeeklyHuntPeriodData>>)+54]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v35 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj5 = default;
		object obj4 = obj5 ^ -1;
		object obj6 = obj4 >> 31;
		bool flag = obj6 == null;
		CelebrationReward result = null;
		if (!flag)
		{
			SetAlternativeHuntPrizeData();
			PrizeData prizeForPeriod = GetPrizeForPeriod(period);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
			object obj7 = -1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
			if ((nint)0 == 1)
			{
				goto IL_02c0;
			}
			if ((nint)obj7 == 1)
			{
				goto IL_028b;
			}
			if ((nint)obj7 != 2)
			{
				if ((nint)obj7 == 3)
				{
					goto IL_02c0;
				}
				if ((nint)obj7 == 4)
				{
					goto IL_028b;
				}
				if ((nint)obj7 == 5)
				{
					CelebrationReward celebrationReward = default;
					celebrationReward._002Ector();
					celebrationReward.amount = (int)obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
					celebrationReward.rewardType = CelebrationRewardType._notset;
					celebrationReward.CelebrationRewardOrigin = CelebrationRewardOrigin.WeeklyChallengeHiddenPrize;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
					object obj8 = -2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
					if ((nint)0 != 2)
					{
						bool flag2 = (nint)obj8 == 1;
						result = celebrationReward;
						if (!flag2)
						{
							bool flag3 = (nint)obj8 == 2;
							result = celebrationReward;
							if (!flag3)
							{
								if ((nint)obj8 != 3)
								{
									if ((nint)obj8 != 4)
									{
										result = celebrationReward;
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
										celebrationReward.characterType = Characters.CharacterType.slick;
										result = celebrationReward;
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+14]");
									celebrationReward.boardType = Hoverboards.BoardType.normal;
									PlayerInfo instance = PlayerInfo.Instance;
									instance.UnlockHoverboard(celebrationReward.boardType);
									PlayerInfo instance2 = PlayerInfo.Instance;
									if (instance2._currentHoverboard != celebrationReward.boardType)
									{
										instance2._dirty = true;
										instance2._currentHoverboard = celebrationReward.boardType;
									}
									UIModelController instance3 = UIModelController.Instance;
									instance3.SelectCurrentlyShownBoard(celebrationReward.boardType);
									result = celebrationReward;
								}
							}
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
						celebrationReward.powerupType = PowerupType._notset;
						result = celebrationReward;
					}
				}
				else
				{
					CelebrationReward celebrationReward2 = MysteryBox.Roll(MysteryBox.Type.Normal);
					celebrationReward2.CelebrationRewardOrigin = CelebrationRewardOrigin.WeeklyChallengeNormal;
					result = celebrationReward2;
				}
			}
			else
			{
				CelebrationReward celebrationReward3 = default;
				celebrationReward3._002Ector();
				celebrationReward3.amount = (int)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				celebrationReward3.rewardType = CelebrationRewardType._notset;
				celebrationReward3.CelebrationRewardOrigin = CelebrationRewardOrigin.WeeklyChallengeNormal;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				object obj9 = -2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				if ((nint)0 != 2)
				{
					bool flag4 = (nint)obj9 == 1;
					result = celebrationReward3;
					if (!flag4)
					{
						bool flag5 = (nint)obj9 == 2;
						result = celebrationReward3;
						if (!flag5)
						{
							if ((nint)obj9 != 3)
							{
								if ((nint)obj9 != 4)
								{
									result = celebrationReward3;
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
									celebrationReward3.characterType = Characters.CharacterType.slick;
									result = celebrationReward3;
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+14]");
								celebrationReward3.boardType = Hoverboards.BoardType.normal;
								PlayerInfo instance4 = PlayerInfo.Instance;
								instance4.UnlockHoverboard(celebrationReward3.boardType);
								result = celebrationReward3;
							}
						}
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
					celebrationReward3.powerupType = PowerupType._notset;
					result = celebrationReward3;
				}
			}
		}
		goto IL_0571;
		IL_02c0:
		CelebrationReward celebrationReward4 = MysteryBox.Roll(MysteryBox.Type.Normal);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
		celebrationReward4.CelebrationRewardOrigin = CelebrationRewardOrigin.Notset;
		result = celebrationReward4;
		goto IL_0571;
		IL_028b:
		CelebrationReward celebrationReward5 = MysteryBox.Roll(MysteryBox.Type.Super);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
		celebrationReward5.CelebrationRewardOrigin = CelebrationRewardOrigin.Notset;
		result = celebrationReward5;
		goto IL_0571;
		IL_0571:
		return result;
	}

	public unsafe static void ItemPickedUp()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_008a: Expected Obj, but got I
		//IL_00e9: Expected I, but got Obj
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		InitIfNeeded();
		PrizePeriodId activePeriode = GetActivePeriode();
		WeeklyHuntPeriodData weeklyHuntPeriodData = huntPeriodData.get_Item((int)activePeriode);
		if (weeklyHuntPeriodData.itemsCollected < weeklyHuntPeriodData.itemsToColect)
		{
			int itemsCollected = weeklyHuntPeriodData.itemsCollected + 1;
			weeklyHuntPeriodData.itemsCollected = itemsCollected;
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S5_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Int32, WeeklyHuntManager+WeeklyHuntPeriodData>>)+5C]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v94 @ S5_v5+4] (should have been resolved before IL gen)");
			SaveNewProgress(shouldStartNewProgress: false);
			if (weeklyHuntPeriodData.itemsCollected == weeklyHuntPeriodData.itemsToColect)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
				nint num3 = (nint)typeof(WeeklyHuntManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S1_v20 (Il2CppClass<WeeklyHuntManager>)+5C]");
				int day = ((DateTime*)null)->Day;
				int num4 = obj + 12;
				string text = ((int*)num4)->ToString();
				throw new ArrayTypeMismatchException();
			}
		}
		if (WeeklyHuntManager.m_ItemCountUpdated != null)
		{
			Action itemCountUpdated = WeeklyHuntManager.m_ItemCountUpdated;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v132.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	private unsafe static void InitIfNeeded()
	{
		if (~(_hasInited ? 1u : 0u) != 0)
		{
			_hasInited = true;
			WeeklyHuntPeriodData weeklyHuntPeriodData = huntPeriodData.get_Item(1);
			START_CHALLANGE_DATE_TIME = weeklyHuntPeriodData.periodStartDate;
			LoadProgressFromResources();
			Action action = default;
			action._002Ector(null, (nint)(delegate*<void>)(&OnRunStarted));
			Game.OnGameStarted += action;
			Action action2 = default;
			action2._002Ector(null, (nint)(delegate*<void>)(&OnRunEnded));
			Game.OnMenuScreenShown += action2;
		}
	}

	public static void SetAlternativeHuntPrizeData()
	{
		//IL_00b5: Expected Obj, but got I
		//IL_006f: Expected Obj, but got I
		//IL_00fc: Expected Obj, but got I
		//IL_02f8: Expected Obj, but got I
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected Obj, but got Unknown
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Expected Obj, but got Unknown
		PlayerInfo instance = PlayerInfo.Instance;
		bool[] array = DeserializeAlternativeHuntPrizeData(instance._shouldUseAlternativeHuntPrizes);
		bool flag = array.Length == 1;
		bool flag2 = !flag;
		bool[] array2 = array;
		if (!flag2)
		{
			Dictionary<int, WeeklyHuntPeriodData> dictionary = huntPeriodData;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S1_v48 (System.Collections.Generic.Dictionary`2<System.Int32, WeeklyHuntManager+WeeklyHuntPeriodData>)+10]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S1_v48 (System.Collections.Generic.Dictionary`2<System.Int32, WeeklyHuntManager+WeeklyHuntPeriodData>)+18]");
			object obj = num - 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			bool[] array3 = default;
			array2 = array3;
		}
		List<WeeklyHuntPeriodData> list = default;
		list._002Ector();
		Dictionary<int, WeeklyHuntPeriodData>.ValueCollection values = huntPeriodData.Values;
		nint num2 = 0;
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S4_v3 (Il2CppRgctx<System.Collections.Generic.List`1<WeeklyHuntManager+WeeklyHuntPeriodData>>)+3C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v87 @ S4_v4+4] (should have been resolved before IL gen)");
		List<int> list2 = default;
		list2._002Ector();
		Dictionary<int, WeeklyHuntPeriodData>.KeyCollection keys = huntPeriodData.Keys;
		nint num4 = 0;
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S4_v8 (Il2CppRgctx<System.Collections.Generic.List`1<System.Int32>>)+3C]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v120 @ S4_v9+4] (should have been resolved before IL gen)");
		int num6 = 0;
		while (true)
		{
			Dictionary<int, WeeklyHuntPeriodData> dictionary2 = huntPeriodData;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S1_v21 (System.Collections.Generic.Dictionary`2<System.Int32, WeeklyHuntManager+WeeklyHuntPeriodData>)+10]");
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S1_v21 (System.Collections.Generic.Dictionary`2<System.Int32, WeeklyHuntManager+WeeklyHuntPeriodData>)+18]");
			object obj4 = num7 - 0;
			if (num6 >= (nint)obj4)
			{
				break;
			}
			WeeklyHuntPeriodData weeklyHuntPeriodData = list.get_Item(num6);
			if (weeklyHuntPeriodData.itemsCollected != weeklyHuntPeriodData.itemsToColect)
			{
				if (~(weeklyHuntPeriodData.hasAlternatePrize ? 1u : 0u) != 0)
				{
					bool flag3 = false;
				}
				else
				{
					PrizePeriodId activePeriode = GetActivePeriode();
					int num8 = list2.get_Item(num6);
					bool flag4 = activePeriode != (PrizePeriodId)num8;
					bool flag3 = false;
					if (!flag4)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S0_v53 (WeeklyHuntManager+WeeklyHuntPeriodData)+30]");
						bool flag5 = (nint)0 != 5;
						flag3 = false;
						if (!flag5)
						{
							PlayerInfo instance2 = PlayerInfo.Instance;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S0_v53 (WeeklyHuntManager+WeeklyHuntPeriodData)+3C]");
							flag3 = (weeklyHuntPeriodData.alternatePrizeCondition = instance2.IsHoverboardUnlocked(Hoverboards.BoardType.normal));
						}
					}
				}
				object obj5 = num6 + array2;
			}
			else
			{
				object obj6 = num6 + array2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S1_v32+10]");
				weeklyHuntPeriodData.alternatePrizeCondition = false;
			}
			int num9 = num6 + 1;
			num6 = num9;
		}
		PlayerInfo instance3 = PlayerInfo.Instance;
		string shouldUseAlternativeHuntPrizes = SerializeAlternativeHuntPrizeData(array2);
		instance3.ShouldUseAlternativeHuntPrizes = shouldUseAlternativeHuntPrizes;
	}

	private static string SerializeAlternativeHuntPrizeData(bool[] alternativeHuntPrizes)
	{
		//IL_00bd: Expected Obj, but got I4
		//IL_009c: Expected I, but got Obj
		//IL_003b: Expected Obj, but got I4
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		StringBuilder stringBuilder = default;
		stringBuilder._002Ector();
		object obj = 0;
		while (alternativeHuntPrizes.Length > (nint)obj)
		{
			object obj2 = (object)alternativeHuntPrizes + obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v9+10]");
			StringBuilder stringBuilder2 = stringBuilder.Append(value: false);
			object obj3 = alternativeHuntPrizes.Length - 1;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3))
			{
				StringBuilder stringBuilder3 = stringBuilder.Append(";");
			}
			object obj4 = obj + 1;
			obj = obj4;
		}
		nint num = (nint)stringBuilder;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v44 @ S1_v6 (Il2CppClass<System.Text.StringBuilder>)+D4] (should have been resolved before IL gen)");
		string result = default;
		return result;
	}

	private unsafe static bool[] DeserializeAlternativeHuntPrizeData(string serialzedData)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00cb: Expected Obj, but got I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected Ref, but got Unknown
		//IL_0051: Expected Obj, but got I
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		string[] array = serialzedData.Split(';');
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		object obj3 = 0;
		bool[] array2 = default;
		while (array.Length > (nint)obj3)
		{
			object obj4 = obj3 << 2;
			object obj5 = (object)array + obj4;
			ref bool result = ref *(bool*)(obj + 15);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v22+10]");
			bool flag = bool.TryParse((string)0, out result);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F]");
			if ((nint)0 != 0)
			{
				object obj6 = obj3 + (object)array2;
			}
			object obj7 = obj3 + 1;
			obj3 = obj7;
		}
		return array2;
	}

	private static void OnRunStarted()
	{
		PrizePeriodId activePeriode = GetActivePeriode();
		if (activePeriode != PrizePeriodId.None)
		{
			WeeklyHuntPeriodData weeklyHuntPeriodData = huntPeriodData.get_Item((int)activePeriode);
			if (weeklyHuntPeriodData.itemsCollected == 0)
			{
				_canCollectAllTokensInOneRun = true;
			}
		}
	}

	private static void OnRunEnded()
	{
		_canCollectAllTokensInOneRun = false;
	}

	private static void OnWeekCompleted()
	{
		if (~(_canCollectAllTokensInOneRun ? 1u : 0u) == 0)
		{
			PlayerInfo instance = PlayerInfo.Instance;
			Statistics stats = instance._stats;
			int[] values = stats._values;
			int value = values[36] + 1;
			stats.set_Item(Stat.HuntsCompletedInOneRun, value);
		}
	}

	private unsafe static void LoadProgressFromResources()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected Obj, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected Ref, but got Unknown
		//IL_00a5: Expected Obj, but got I
		//IL_00f1: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		PlayerInfo instance = PlayerInfo.Instance;
		string[] array = instance._weeklyChallangeData.Split(',');
		if (!ShouldResetChallangeData(array[0]))
		{
			int num = 1;
			while (num < array.Length)
			{
				_ = 0;
				int num2 = num << 2;
				object obj3 = array + num2;
				ref int result = ref *(int*)(obj + 12);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v31+10]");
				bool flag = int.TryParse((string)0, out result);
				WeeklyHuntPeriodData weeklyHuntPeriodData = huntPeriodData.get_Item(num);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
				weeklyHuntPeriodData.itemsCollected = 0;
				nint num3 = 0;
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S5_v5 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Int32, WeeklyHuntManager+WeeklyHuntPeriodData>>)+5C]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v116 @ S5_v6+4] (should have been resolved before IL gen)");
				int num5 = num + 1;
				num = num5;
			}
		}
		else
		{
			SaveNewProgress(shouldStartNewProgress: true);
		}
	}

	private unsafe static bool ShouldResetChallangeData(string storedStringDate)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Ref, but got Unknown
		//IL_0029: Expected VT, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = DateTime.MinValue;
		bool flag = DateTime.TryParse(storedStringDate, out *(DateTime*)(obj + 8));
		bool flag2 = !flag;
		bool result = true;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			int num = DateTime.Compare((DateTime)0, START_CHALLANGE_DATE_TIME);
			bool flag3 = num != 0;
			result = flag3;
		}
		return result;
	}

	public unsafe static void SaveNewProgress(bool shouldStartNewProgress)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0034: Expected I, but got Obj
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected Obj, but got Unknown
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected Obj, but got Unknown
		//IL_04ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bf: Expected Obj, but got Unknown
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected Obj, but got Unknown
		//IL_036c: Expected I, but got Obj
		//IL_0423: Unknown result type (might be due to invalid IL or missing references)
		//IL_0428: Expected Obj, but got Unknown
		//IL_03db: Expected I, but got Obj
		//IL_014a: Expected Obj, but got I
		//IL_016c: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		PlayerInfo instance = PlayerInfo.Instance;
		StringBuilder stringBuilder = default;
		stringBuilder._002Ector(string.Empty);
		nint num = (nint)typeof(WeeklyHuntManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S1_v7 (Il2CppClass<WeeklyHuntManager>)+5C]");
		string text = ((DateTime*)null)->ToString();
		string value = text + ",";
		StringBuilder stringBuilder2 = stringBuilder.Append(value);
		object obj3 = obj + 16;
		Dictionary<int, WeeklyHuntPeriodData>.ValueCollection values = huntPeriodData.Values;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @961");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj4 = obj + 32;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj6 = default;
		object obj8 = default;
		object obj9 = default;
		object obj11 = default;
		object obj12 = default;
		string text2 = default;
		string weeklyChallangeData = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj6 == null)
				{
					goto IL_034c;
				}
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
					object obj7 = (nint)0 + (nint)12;
					if (shouldStartNewProgress)
					{
						obj7 = 0;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
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
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag = obj8 != obj9;
			object obj10 = obj11;
			if (flag)
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
				goto IL_034c;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			obj10 = obj12;
			break;
			IL_034c:
			object obj13 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @ADAF");
			nint num2 = (nint)stringBuilder;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v176 @ S1_v35 (Il2CppClass<System.Text.StringBuilder>)+D4] (should have been resolved before IL gen)");
			int num3 = text2.LastIndexOf(',');
			if (num3 >= 0)
			{
				StringBuilder stringBuilder3 = stringBuilder.Remove(num3, 1);
			}
			nint num4 = (nint)stringBuilder;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v243 @ S2_v21 (Il2CppClass<System.Text.StringBuilder>)+D4] (should have been resolved before IL gen)");
			instance.weeklyChallangeData = weeklyChallangeData;
			return;
		}
		_ = 0;
		object obj14 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
	}

	public static int GetPrizeDataCount()
	{
		Dictionary<int, WeeklyHuntPeriodData> dictionary = huntPeriodData;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (System.Collections.Generic.Dictionary`2<System.Int32, WeeklyHuntManager+WeeklyHuntPeriodData>)+10]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (System.Collections.Generic.Dictionary`2<System.Int32, WeeklyHuntManager+WeeklyHuntPeriodData>)+18]");
		return (int)(num - 0);
	}

	public static bool IsBoardAwardedInCurrentPeriod(Hoverboards.BoardType boardType)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		PrizePeriodId activePeriode = GetActivePeriode();
		if (activePeriode != PrizePeriodId.None)
		{
			PrizeData prizeForPeriod = GetPrizeForPeriod(activePeriode);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			if ((nint)0 == 5)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+14]");
				return (nint)0 == (nint)boardType;
			}
		}
		bool result = default;
		return result;
	}

	public static int ItemsCollectedForBoardType(Hoverboards.BoardType boardType)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_03cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d4: Expected Obj, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		//IL_0405: Expected Obj, but got Unknown
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Expected Obj, but got Unknown
		//IL_035c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0361: Expected Obj, but got Unknown
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + -64;
		_ = 0;
		_ = 0;
		object obj3 = obj + 8;
		Dictionary<int, WeeklyHuntPeriodData>.KeyCollection keys = huntPeriodData.Keys;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @94E");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj4 = obj + 48;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj6 = default;
		object obj8 = default;
		object obj9 = default;
		object obj11 = default;
		object obj12 = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj + 48;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			int result;
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				if (obj6 == null)
				{
					result = 0;
					goto IL_030f;
				}
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						object obj7 = obj + 8;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
							if ((nint)0 != 5)
							{
								continue;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
							if ((nint)0 != (nint)boardType)
							{
								continue;
							}
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
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
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ S0_v115+C]");
									result = 0;
									goto IL_030f;
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
			bool flag = obj8 != obj9;
			object obj10 = obj11;
			if (flag)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag2 = (nint)0 == 1;
			result = 0;
			if (!flag2)
			{
				goto IL_030f;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			obj10 = obj12;
			break;
			IL_030f:
			object obj13 = obj + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3A01");
			return result;
		}
		_ = 0;
		object obj14 = obj + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
		int result2 = default;
		return result2;
	}

	public static int ItemsToCollectForBoardType(Hoverboards.BoardType boardType)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_03cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d4: Expected Obj, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		//IL_0405: Expected Obj, but got Unknown
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Expected Obj, but got Unknown
		//IL_035c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0361: Expected Obj, but got Unknown
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + -64;
		_ = 0;
		_ = 0;
		object obj3 = obj + 8;
		Dictionary<int, WeeklyHuntPeriodData>.KeyCollection keys = huntPeriodData.Keys;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @94E");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj4 = obj + 48;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj6 = default;
		object obj8 = default;
		object obj9 = default;
		object obj11 = default;
		object obj12 = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj + 48;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			int result;
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				if (obj6 == null)
				{
					result = 0;
					goto IL_030f;
				}
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						object obj7 = obj + 8;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
							if ((nint)0 != 5)
							{
								continue;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
							if ((nint)0 != (nint)boardType)
							{
								continue;
							}
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
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
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ S0_v115+8]");
									result = 0;
									goto IL_030f;
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
			bool flag = obj8 != obj9;
			object obj10 = obj11;
			if (flag)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag2 = (nint)0 == 1;
			result = 0;
			if (!flag2)
			{
				goto IL_030f;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			obj10 = obj12;
			break;
			IL_030f:
			object obj13 = obj + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3A01");
			return result;
		}
		_ = 0;
		object obj14 = obj + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
		int result2 = default;
		return result2;
	}

	public unsafe static PrizeData GetPrizeForPeriod(PrizePeriodId periodId)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected Obj, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_006d: Expected I4, but got Obj
		//IL_0068: Expected native int or pointer, but got VT
		//IL_007d: Expected native int or pointer, but got VT
		//IL_0092: Expected native int or pointer, but got VT
		//IL_00a7: Expected native int or pointer, but got VT
		bool flag = IsPeriodShowingAlternatePrize(periodId);
		WeeklyHuntPeriodData weeklyHuntPeriodData = huntPeriodData.get_Item((int)periodId);
		object obj = weeklyHuntPeriodData + 72;
		object obj2 = weeklyHuntPeriodData + 40;
		if (!flag)
		{
			obj = obj2;
		}
		PrizeData prizeData = default;
		((PrizeData*)(nint)prizeData)->amount = (int)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v9+18]");
		((PrizeData*)(nint)prizeData)->trophyType = Trophies.Trophy.diamond;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v9+10]");
		((PrizeData*)(nint)prizeData)->characterType = Characters.CharacterType.slick;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v9+8]");
		((PrizeData*)(nint)prizeData)->rewardType = CelebrationRewardType._notset;
		return prizeData;
	}

	public static bool IsPeriodShowingAlternatePrize(PrizePeriodId periodId)
	{
		WeeklyHuntPeriodData weeklyHuntPeriodData = huntPeriodData.get_Item((int)periodId);
		if (~(weeklyHuntPeriodData.hasAlternatePrize ? 1u : 0u) == 0)
		{
			return weeklyHuntPeriodData.alternatePrizeCondition;
		}
		return false;
	}

	public static WeeklyHuntPrize DeterminePrize(PrizeData prizeData)
	{
		//IL_0018: Expected Obj, but got I4
		//IL_0202: Expected Obj, but got I4
		bool flag = prizeData.CelebrationRewardOrigin == CelebrationRewardOrigin.WeeklyChallengeSuperMysteryBox;
		WeeklyHuntPrize result = WeeklyHuntPrize.SuperMysteryBox;
		if (!flag)
		{
			object obj = prizeData.rewardType - 4;
			bool flag2 = prizeData.rewardType == CelebrationRewardType.keys;
			result = WeeklyHuntPrize.Key;
			if (!flag2)
			{
				if ((nint)obj == 1)
				{
					if (prizeData.boardType <= Hoverboards.BoardType.londonBoard01)
					{
						if (prizeData.boardType == Hoverboards.BoardType.cherry)
						{
							return WeeklyHuntPrize.CherryBoard;
						}
						if (prizeData.boardType == Hoverboards.BoardType.londonBoard01)
						{
							return WeeklyHuntPrize.ChristmasBoard;
						}
					}
					else
					{
						if (prizeData.boardType == Hoverboards.BoardType.londonBoard03)
						{
							return WeeklyHuntPrize.NorthpoleBoard2016;
						}
						if (prizeData.boardType == Hoverboards.BoardType.rioBoard02)
						{
							return WeeklyHuntPrize.RioBoard2;
						}
					}
				}
				object obj2 = prizeData.powerupType - 1;
				bool flag3 = prizeData.powerupType == PowerupType.hoverboard;
				result = WeeklyHuntPrize.Hoverboard;
				if (!flag3)
				{
					if ((nint)obj2 == 1 || (nint)obj2 != 2)
					{
						bool flag4 = prizeData.powerupType == PowerupType.scorebooster;
						return (WeeklyHuntPrize)((flag4 ? 1u : 0u) << 2);
					}
					result = WeeklyHuntPrize.Headstart;
				}
			}
		}
		return result;
	}

	public unsafe static string GetPrizeTitle(PrizeData prizeData)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_01f3: Expected native int or pointer, but got VT
		//IL_0205: Expected native int or pointer, but got VT
		//IL_0217: Expected native int or pointer, but got VT
		//IL_0229: Expected native int or pointer, but got VT
		//IL_0249: Expected Obj, but got I4
		object obj = default;
		PrizeData prizeData2 = (PrizeData)(obj - 32);
		((PrizeData*)(nint)prizeData2)->trophyType = prizeData.trophyType;
		((PrizeData*)(nint)prizeData2)->characterType = prizeData.characterType;
		((PrizeData*)(nint)prizeData2)->rewardType = prizeData.rewardType;
		((PrizeData*)(nint)prizeData2)->amount = prizeData.amount;
		WeeklyHuntPrize weeklyHuntPrize = DeterminePrize(prizeData2);
		object obj2 = weeklyHuntPrize - 1;
		if (weeklyHuntPrize != WeeklyHuntPrize.Key)
		{
			if ((nint)obj2 != 1)
			{
				if ((nint)obj2 != 2)
				{
					if ((nint)obj2 != 3)
					{
						if ((nint)obj2 != 4)
						{
							if ((nint)obj2 != 5)
							{
								if ((nint)obj2 != 6)
								{
									if ((nint)obj2 != 7)
									{
										if ((nint)obj2 == 8)
										{
											return Strings.Get(StringID.WEEKLYHUNT_PRIZE_CHERRY);
										}
										return string.Empty;
									}
									return Strings.Get(StringID.HOVERBOARDS_LONDONBOARD03);
								}
								return Strings.Get(StringID.WEEKLYHUNT_PRIZE_RIO);
							}
							return Strings.Get(StringID.HOVERBOARDS_LONDONBOARD01);
						}
						return Strings.Get(StringID.WEEKLYHUNT_PRIZE_HEADSTART_TITLE);
					}
					return Strings.Get(StringID.WEEKLYHUNT_PRIZE_SCOREBOOSTER_TITLE);
				}
				return Strings.Get(StringID.WEEKLYHUNT_PRIZE_HOVERBOARD_TITLE);
			}
			return Strings.Get(StringID.WEEKLYHUNT_PRIZE_SUPERMYSTERYBOX_TITLE);
		}
		return Strings.Get(StringID.WEEKLYHUNT_PRIZE_KEYS_TITLE);
	}

	public unsafe static string GetPrizeTitleShort(PrizeData prizeData)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_01f3: Expected native int or pointer, but got VT
		//IL_0205: Expected native int or pointer, but got VT
		//IL_0217: Expected native int or pointer, but got VT
		//IL_0229: Expected native int or pointer, but got VT
		//IL_0249: Expected Obj, but got I4
		object obj = default;
		PrizeData prizeData2 = (PrizeData)(obj - 32);
		((PrizeData*)(nint)prizeData2)->trophyType = prizeData.trophyType;
		((PrizeData*)(nint)prizeData2)->characterType = prizeData.characterType;
		((PrizeData*)(nint)prizeData2)->rewardType = prizeData.rewardType;
		((PrizeData*)(nint)prizeData2)->amount = prizeData.amount;
		WeeklyHuntPrize weeklyHuntPrize = DeterminePrize(prizeData2);
		object obj2 = weeklyHuntPrize - 1;
		if (weeklyHuntPrize != WeeklyHuntPrize.Key)
		{
			if ((nint)obj2 != 1)
			{
				if ((nint)obj2 != 2)
				{
					if ((nint)obj2 != 3)
					{
						if ((nint)obj2 != 4)
						{
							if ((nint)obj2 != 5)
							{
								if ((nint)obj2 != 6)
								{
									if ((nint)obj2 != 7)
									{
										if ((nint)obj2 == 8)
										{
											return Strings.Get(StringID.WEEKLYHUNT_PRIZE_CHERRY_SHORT);
										}
										return string.Empty;
									}
									return Strings.Get(StringID.HOVERBOARDS_LONDONBOARD03);
								}
								return Strings.Get(StringID.WEEKLYHUNT_PRIZE_RIO_SHORT);
							}
							return Strings.Get(StringID.HOVERBOARDS_LONDONBOARD01);
						}
						return Strings.Get(StringID.WEEKLYHUNT_PRIZE_HEADSTART_TITLE_SHORT);
					}
					return Strings.Get(StringID.WEEKLYHUNT_PRIZE_SCOREBOOSTER_TITLE_SHORT);
				}
				return Strings.Get(StringID.WEEKLYHUNT_PRIZE_HOVERBOARD_TITLE_SHORT);
			}
			return Strings.Get(StringID.WEEKLYHUNT_PRIZE_SUPERMYSTERYBOX_TITLE_SHORT);
		}
		return Strings.Get(StringID.WEEKLYHUNT_PRIZE_KEYS_TITLE_SHORT);
	}

	public static TimeSpan GetTimeLeftForActivePeriod()
	{
		PrizePeriodId activePeriode = GetActivePeriode();
		WeeklyHuntPeriodData weeklyHuntPeriodData = huntPeriodData.get_Item((int)activePeriode);
		DateTime now = CDateTime.Now;
		return weeklyHuntPeriodData.periodEndDate - now;
	}

	unsafe static WeeklyHuntManager()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_04d9: Expected I, but got Obj
		//IL_04fd: Expected VT, but got I8
		//IL_050b: Expected I, but got Obj
		//IL_052f: Expected VT, but got I8
		//IL_0542: Expected I, but got Obj
		//IL_0589: Expected I, but got Obj
		//IL_05c4: Expected VT, but got F4
		//IL_060d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0612: Expected VT, but got Unknown
		//IL_0625: Expected native int or pointer, but got VT
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected VT, but got Unknown
		//IL_0047: Expected native int or pointer, but got VT
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected Obj, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected Obj, but got Unknown
		//IL_00ae: Expected Obj, but got I
		//IL_00f7: Expected Obj, but got I
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected VT, but got Unknown
		//IL_013a: Expected native int or pointer, but got VT
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected VT, but got Unknown
		//IL_0178: Expected native int or pointer, but got VT
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected Obj, but got Unknown
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Expected Obj, but got Unknown
		//IL_01df: Expected Obj, but got I
		//IL_0228: Expected Obj, but got I
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected VT, but got Unknown
		//IL_026b: Expected native int or pointer, but got VT
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Expected VT, but got Unknown
		//IL_02a9: Expected native int or pointer, but got VT
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Expected Obj, but got Unknown
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Expected Obj, but got Unknown
		//IL_0310: Expected Obj, but got I
		//IL_0359: Expected Obj, but got I
		//IL_0384: Unknown result type (might be due to invalid IL or missing references)
		//IL_0389: Expected VT, but got Unknown
		//IL_039c: Expected native int or pointer, but got VT
		//IL_03c1: Expected I8, but got I4
		//IL_03bc: Expected native int or pointer, but got VT
		//IL_03d4: Expected native int or pointer, but got VT
		//IL_03ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f1: Expected Obj, but got Unknown
		//IL_0423: Unknown result type (might be due to invalid IL or missing references)
		//IL_0428: Expected Obj, but got Unknown
		//IL_0438: Expected Obj, but got I
		//IL_0481: Expected Obj, but got I
		object obj = default;
		DateTime dateTime = (DateTime)(obj - 96);
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		START_CHALLANGE_DATE_TIME = DateTime.MinValue;
		_hasInited = false;
		HIDE_LAST_PERIOD = true;
		nint num = (nint)typeof(WeeklyHuntManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v23 (Il2CppClass<WeeklyHuntManager>)+5C]");
		nint num2 = 0;
		_ = 0;
		HUNT_ITEM_POSITION_OFFSET = (Vector3)(-4566650021054775296L);
		nint num3 = (nint)typeof(WeeklyHuntManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v27 (Il2CppClass<WeeklyHuntManager>)+5C]");
		nint num4 = 0;
		_ = 1096024064;
		HUNT_ITEM_ROTATION = (Vector3)(-4497970124593247027L);
		nint num5 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v35 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num6 = 0;
		float num7 = (float)Vector3.oneVector * 12f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v36 (Il2CppStaticFields<UnityEngine.Vector3>)+10]");
		float num8 = 0f * 12f;
		nint num9 = (nint)typeof(WeeklyHuntManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v45 (Il2CppClass<WeeklyHuntManager>)+5C]");
		nint num10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v36 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
		float num11 = 0f * 12f;
		HUNT_ITEM_SCALE = (Vector3)num7;
		_canCollectAllTokensInOneRun = false;
		nint num12 = 0;
		nint num13 = 0;
		IntPtr intPtr = num13;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v112 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Int32, WeeklyHuntManager+WeeklyHuntPeriodData>>>)+4] (should have been resolved before IL gen)");
		_ = 724;
		_ = 0;
		_ = 10;
		_ = 0;
		DateTime dateTime2 = dateTime + 56;
		*(DateTime*)(nint)dateTime2 = new DateTime(2017, 7, 6);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+38]");
		_ = 0;
		_ = 0;
		DateTime dateTime3 = dateTime + 48;
		*(DateTime*)(nint)dateTime3 = new DateTime(2017, 8, 17);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+30]");
		_ = 0;
		object obj2 = dateTime - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		_ = 4294967298L;
		_ = 12884901898L;
		object obj4 = default;
		object obj3 = obj4 - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+58]");
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+50]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+48]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+40]");
		_ = 0;
		_ = 0;
		nint num14 = 0;
		nint num15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ S5_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Int32, WeeklyHuntManager+WeeklyHuntPeriodData>>)+5C]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v192 @ S5_v4+4] (should have been resolved before IL gen)");
		_ = 727;
		_ = 0;
		_ = 20;
		_ = 0;
		DateTime dateTime4 = dateTime + 40;
		*(DateTime*)(nint)dateTime4 = new DateTime(2017, 8, 17);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+28]");
		_ = 0;
		_ = 0;
		DateTime dateTime5 = dateTime + 32;
		*(DateTime*)(nint)dateTime5 = new DateTime(2017, 8, 24);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+20]");
		_ = 0;
		object obj6 = dateTime - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		_ = 64424509442L;
		_ = 12884901891L;
		object obj8 = default;
		object obj7 = obj8 - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+58]");
		obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+50]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+48]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+40]");
		_ = 0;
		_ = 0;
		nint num16 = 0;
		nint num17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ S5_v8 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Int32, WeeklyHuntManager+WeeklyHuntPeriodData>>)+5C]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v269 @ S5_v9+4] (should have been resolved before IL gen)");
		_ = 732;
		_ = 0;
		_ = 25;
		_ = 0;
		DateTime dateTime6 = dateTime + 24;
		*(DateTime*)(nint)dateTime6 = new DateTime(2017, 8, 24);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+18]");
		_ = 0;
		_ = 0;
		DateTime dateTime7 = dateTime + 16;
		*(DateTime*)(nint)dateTime7 = new DateTime(2017, 8, 31);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+10]");
		_ = 0;
		object obj10 = dateTime - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		_ = 12884901890L;
		_ = 12884901894L;
		object obj12 = default;
		object obj11 = obj12 - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+58]");
		obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+50]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+48]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+40]");
		_ = 0;
		_ = 0;
		nint num18 = 0;
		nint num19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ S5_v13 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Int32, WeeklyHuntManager+WeeklyHuntPeriodData>>)+5C]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v345 @ S5_v14+4] (should have been resolved before IL gen)");
		_ = 735;
		_ = 0;
		_ = 10;
		_ = 0;
		DateTime dateTime8 = dateTime + 8;
		*(DateTime*)(nint)dateTime8 = new DateTime(2017, 8, 31);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+8]");
		_ = 0;
		((DateTime*)(nint)dateTime)->_dateData = 0uL;
		*(DateTime*)(nint)dateTime = new DateTime(2017, 9, 7);
		_ = dateTime._dateData;
		object obj14 = dateTime - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		_ = 64424509442L;
		_ = 12884901890L;
		object obj16 = default;
		object obj15 = obj16 - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+58]");
		obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+50]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+48]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+40]");
		_ = 0;
		_ = 0;
		nint num20 = 0;
		nint num21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ S5_v18 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Int32, WeeklyHuntManager+WeeklyHuntPeriodData>>)+5C]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v419 @ S5_v19+4] (should have been resolved before IL gen)");
		Dictionary<int, WeeklyHuntPeriodData> dictionary = default;
		huntPeriodData = dictionary;
	}
}
