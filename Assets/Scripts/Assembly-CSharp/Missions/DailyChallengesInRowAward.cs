using System;
using System.Globalization;
using System.Text;
using Cpp2ILInjected;

namespace Missions;

public class DailyChallengesInRowAward : Award
{
	private bool _isDailyChallengeCompletedToday;

	private int _offset = -1;

	public int offset
	{
		get
		{
			return _offset;
		}
		set
		{
			_offset = value;
		}
	}

	public DailyChallengesInRowAward(AwardStaticData trophyData, string savedProgress, Action<Award> handler)
		: base(trophyData, savedProgress, handler)
	{
		SyncOffset();
	}

	private unsafe int GetDailyChallengesInRow()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected Ref, but got Unknown
		PlayerInfo instance = PlayerInfo.Instance;
		return instance.GetDailyWordDaysInARow(out *(bool*)(this + 61));
	}

	protected override int GetProgressForGoal(AwardGoal goal)
	{
		int dailyChallengesInRow = GetDailyChallengesInRow();
		return dailyChallengesInRow - _offset;
	}

	public bool IsDailyChallengeCompletedToday()
	{
		return _isDailyChallengeCompletedToday;
	}

	public override bool isGoalAccomplished(AwardGoal goal)
	{
		//IL_000a: Expected I, but got Obj
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
		object obj = default;
		bool result;
		if (obj != null)
		{
			nint num = (nint)this;
			object obj2 = this + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v22 @ S3_v4 (Il2CppClass<Missions.DailyChallengesInRowAward>)+E4] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S0_v6+8]");
			object obj3 = default;
			bool flag = (nint)obj3 >= 0;
			result = true;
			if (flag)
			{
				goto IL_0084;
			}
		}
		result = false;
		goto IL_0084;
		IL_0084:
		return result;
	}

	protected unsafe override void ActivateCurrentAwardTier()
	{
		PlayerInfo instance = PlayerInfo.Instance;
		Action action = default;
		action._002Ector(this, (nint)__ldftn(DailyChallengesInRowAward.OnDailyWordInRowChanged));
		Delegate obj = Delegate.Combine(instance.OnDailyWordInRowChanged, action);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		Action onDailyWordInRowChanged = default;
		instance.OnDailyWordInRowChanged = onDailyWordInRowChanged;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		CheckAndUpdateProgress();
	}

	protected unsafe override void DeactivateCurrentAwardTier()
	{
		PlayerInfo instance = PlayerInfo.Instance;
		Action action = default;
		action._002Ector(this, (nint)__ldftn(DailyChallengesInRowAward.OnDailyWordInRowChanged));
		Delegate obj = Delegate.Remove(instance.OnDailyWordInRowChanged, action);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		Action onDailyWordInRowChanged = default;
		instance.OnDailyWordInRowChanged = onDailyWordInRowChanged;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
	}

	protected override void RecordNewOffsets()
	{
	}

	private void SyncOffset()
	{
		//IL_0038: Expected Obj, but got I4
		//IL_005e: Expected Obj, but got I4
		int dailyChallengesInRow = GetDailyChallengesInRow();
		bool flag = _offset == -1;
		bool flag2 = _offset > dailyChallengesInRow;
		object obj = flag | flag2;
		if (obj == null)
		{
			dailyChallengesInRow = _offset;
		}
		bool flag3 = dailyChallengesInRow > -1;
		object obj2 = obj;
		if (!flag3)
		{
			obj2 = 1;
		}
		if (obj2 != null)
		{
			bool flag4 = dailyChallengesInRow < 0;
			int num = 0;
			if (!flag4)
			{
				num = dailyChallengesInRow;
			}
			_offset = num;
		}
	}

	private void OnDailyWordInRowChanged()
	{
		CheckAndUpdateProgress();
	}

	public unsafe override string AwardToString()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected I4, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected I4, but got Unknown
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected I4, but got Unknown
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected I4, but got Unknown
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Expected VT, but got Unknown
		//IL_01b7: Expected Ref, but got VT
		//IL_0203: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 - 16;
		if (_awardActiveTier != null && _awardProgressTier != null)
		{
			StringBuilder stringBuilder = default;
			stringBuilder._002Ector(string.Empty);
			AwardTier awardActiveTier = _awardActiveTier;
			_ = awardActiveTier.tierType__BackingField;
			int num = obj + 12;
			string text = ((int*)num)->ToString();
			string value = text + ",";
			StringBuilder stringBuilder2 = stringBuilder.Append(value);
			_ = _currentActiveAwardState;
			int num2 = obj + 12;
			string text2 = ((int*)num2)->ToString();
			string value2 = text2 + ",";
			StringBuilder stringBuilder3 = stringBuilder.Append(value2);
			AwardTier awardProgressTier = _awardProgressTier;
			_ = awardProgressTier.tierType__BackingField;
			int num3 = obj + 12;
			string text3 = ((int*)num3)->ToString();
			string value3 = text3 + ",";
			StringBuilder stringBuilder4 = stringBuilder.Append(value3);
			_ = _currentProgressAwardState;
			int num4 = obj + 12;
			string text4 = ((int*)num4)->ToString();
			string value4 = text4 + ",";
			StringBuilder stringBuilder5 = stringBuilder.Append(value4);
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			DateTime dateTime = (DateTime)(this + 24);
			string text5 = ((DateTime*)dateTime)->ToString(invariantCulture);
			string value5 = text5 + ",";
			StringBuilder stringBuilder6 = stringBuilder.Append(value5);
			StringBuilder stringBuilder7 = stringBuilder.Append(_offset);
			nint num5 = (nint)stringBuilder;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v147 @ S1_v39 (Il2CppClass<System.Text.StringBuilder>)+D4] (should have been resolved before IL gen)");
		}
		string result = default;
		return result;
	}

	public override void ParseSavedProgressAndCreateAwardState(string s)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_08a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a7: Expected Obj, but got Unknown
		//IL_08db: Expected Obj, but got I
		//IL_01bd: Expected I4, but got Obj
		//IL_06cd: Expected Obj, but got I
		//IL_06f8: Expected Obj, but got I
		//IL_071d: Expected Obj, but got I
		//IL_0733: Unknown result type (might be due to invalid IL or missing references)
		//IL_0738: Expected Obj, but got Unknown
		//IL_0751: Unknown result type (might be due to invalid IL or missing references)
		//IL_0756: Expected Obj, but got Unknown
		//IL_0798: Expected Obj, but got I
		//IL_0278: Expected I4, but got Obj
		//IL_0333: Expected I4, but got Obj
		//IL_03ee: Expected I4, but got Obj
		object obj2 = default;
		object obj = obj2 - 16;
		object obj3 = obj + 8;
		_ = 0;
		string[] array2;
		if (s != null && s._stringLength >= 1)
		{
			string[] array = s.Split(',');
			bool flag = array.Length == 6;
			bool flag2 = !flag;
			array2 = array;
			if (!flag2)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
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
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									object obj4 = default;
									_savedActiveTierType = (AwardTierType)obj4;
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 != 1)
											{
												object obj5 = default;
												_currentActiveAwardState = (AwardState)obj5;
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 != 1)
												{
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													if ((nint)0 != 1)
													{
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
														if ((nint)0 != 1)
														{
															object obj6 = default;
															_savedProgressTierType = (AwardTierType)obj6;
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
															if ((nint)0 != 1)
															{
																_ = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
																_ = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																if ((nint)0 != 1)
																{
																	_ = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
																	_ = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																	if ((nint)0 != 1)
																	{
																		object obj7 = default;
																		_currentProgressAwardState = (AwardState)obj7;
																		_ = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
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
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @FD2");
																				_ = 0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																				if ((nint)0 != 1)
																				{
																					DateTime lastActiveStateChangeDateTime = default;
																					_lastActiveStateChangeDateTime = lastActiveStateChangeDateTime;
																					_ = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
																					_ = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																					if ((nint)0 != 1)
																					{
																						int num = default;
																						_offset = num;
																						return;
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
																		goto IL_05c5;
																	}
																}
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
															}
															else
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
															}
															goto IL_05c5;
														}
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
												}
												else
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
												}
												goto IL_05c5;
											}
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									}
									goto IL_05c5;
								}
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
				goto IL_05c5;
			}
			goto IL_08ca;
		}
		ResetAwardToDefaultState();
		return;
		IL_08ca:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		((Award)0).ResetAwardToDefaultState();
		return;
		IL_05c5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj8 = default;
		object obj9 = default;
		bool flag3 = obj8 == obj9;
		bool flag4 = !flag3;
		string[] array3 = default;
		array2 = array3;
		if (!flag4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				object obj11 = default;
				object obj10 = obj11;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj12 = default;
					if (obj12 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
						object obj13 = (nint)0 << 2;
						object obj14 = obj3 + obj13;
						obj14 = obj11;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
						object obj15 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
						object obj16 = (nint)0 << 2;
						object obj17 = obj16 + obj3;
						object obj18 = obj17 - 4;
						object obj19 = obj18;
						object obj20 = obj19;
						object obj21 = obj19 + 24;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v432 @ S1_v53+D4] (should have been resolved before IL gen)");
						string text2 = default;
						string text = "DailyChallengeInRowAward parse failed: " + text2;
						ResetAwardToDefaultState();
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
						object obj22 = -1;
						return;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
					object obj23 = obj11;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						return;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag5 = (nint)0 == 1;
			string[] array4 = default;
			array2 = array4;
			if (flag5)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		goto IL_08ca;
	}
}
