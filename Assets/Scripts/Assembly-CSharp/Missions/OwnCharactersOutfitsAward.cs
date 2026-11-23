using System;
using System.Globalization;
using System.Text;
using Cpp2ILInjected;
using SYBO.Subway.Info;

namespace Missions;

public class OwnCharactersOutfitsAward : Award
{
	public OwnCharactersOutfitsAward(AwardStaticData trophyData, string savedProgress, Action<Award> handler)
		: base(trophyData, savedProgress, handler)
	{
	}

	private int GetNumberOfOwnedCharacterOutfits()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_044b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0450: Expected Obj, but got Unknown
		//IL_047d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0482: Expected Obj, but got Unknown
		//IL_04cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d0: Expected Obj, but got Unknown
		//IL_04a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ad: Expected Obj, but got Unknown
		//IL_03c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cd: Expected Obj, but got Unknown
		//IL_054a: Expected Obj, but got I
		//IL_0150: Expected Obj, but got I4
		//IL_051c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		object obj3 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @728");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj4 = obj + 32;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj6 = default;
		object obj7;
		object obj8 = default;
		int num = default;
		object obj11 = default;
		object obj13 = default;
		object obj14 = default;
		object obj16 = default;
		object obj17 = default;
		while (true)
		{
			IL_04bc:
			_ = 0;
			object obj5 = obj + 32;
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
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							if (obj8 == null)
							{
								continue;
							}
							_ = 0;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ S0_v88+C]");
								bool flag2 = (nint)0 >= (nint)1;
								object obj9 = 1;
								if (!flag2)
								{
									continue;
								}
								while (true)
								{
									_ = 0;
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 == 1)
									{
										break;
									}
									object obj10 = obj9;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ S0_v88+C]");
									if ((nint)obj10 > 0)
									{
										goto IL_04bc;
									}
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 == 1)
									{
										goto IL_02ba;
									}
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 == 1)
									{
										goto IL_02c9;
									}
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										num++;
										if (obj11 == null)
										{
											num = num;
										}
										object obj12 = obj9 + 1;
										obj9 = obj12;
										continue;
									}
									goto IL_02d8;
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
			goto IL_02f6;
			IL_02f6:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag3 = obj13 == obj14;
			bool flag4 = !flag3;
			object obj15 = obj16;
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag5 = (nint)0 != 1;
				obj7 = obj;
				if (flag5)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj15 = obj17;
			}
			_ = 0;
			object obj18 = obj + 16;
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			obj7 = 0;
			break;
			IL_02ba:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_02f6;
			IL_02d8:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_02f6;
			IL_02c9:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_02f6;
		}
		object obj19 = obj7 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9BA");
		return num;
	}

	protected override int GetProgressForGoal(AwardGoal goal)
	{
		return ((OwnCharactersOutfitsAward)null).GetNumberOfOwnedCharacterOutfits();
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
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v22 @ S3_v4 (Il2CppClass<Missions.OwnCharactersOutfitsAward>)+E4] (should have been resolved before IL gen)");
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

	protected override void ActivateCurrentAwardTier()
	{
		PlayerInfo instance = PlayerInfo.Instance;
		throw new ArgumentException();
	}

	protected override void DeactivateCurrentAwardTier()
	{
		PlayerInfo instance = PlayerInfo.Instance;
		throw new ArgumentException();
	}

	private void OnOutfitUnlocked(Characters.CharacterType type)
	{
		CheckAndUpdateProgress();
	}

	protected override void RecordNewOffsets()
	{
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
		//IL_01d9: Expected I, but got Obj
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
			string value5 = ((DateTime*)dateTime)->ToString(invariantCulture);
			StringBuilder stringBuilder6 = stringBuilder.Append(value5);
			nint num5 = (nint)stringBuilder;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v138 @ S1_v36 (Il2CppClass<System.Text.StringBuilder>)+D4] (should have been resolved before IL gen)");
		}
		string result = default;
		return result;
	}

	public override void ParseSavedProgressAndCreateAwardState(string s)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0849: Unknown result type (might be due to invalid IL or missing references)
		//IL_084e: Expected Obj, but got Unknown
		//IL_0894: Expected Obj, but got I
		//IL_01b8: Expected I4, but got Obj
		//IL_0674: Expected Obj, but got I
		//IL_069f: Expected Obj, but got I
		//IL_06c4: Expected Obj, but got I
		//IL_06da: Unknown result type (might be due to invalid IL or missing references)
		//IL_06df: Expected Obj, but got Unknown
		//IL_06f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fd: Expected Obj, but got Unknown
		//IL_073f: Expected Obj, but got I
		//IL_0273: Expected I4, but got Obj
		//IL_032e: Expected I4, but got Obj
		//IL_03e9: Expected I4, but got Obj
		object obj2 = default;
		object obj = obj2 - 16;
		object obj3 = obj + 8;
		_ = 0;
		string text = default;
		if (text != null && text._stringLength >= 1)
		{
			string[] array = text.Split(',');
			if (array.Length >= 5)
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
																		goto IL_056c;
																	}
																}
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
															}
															else
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
															}
															goto IL_056c;
														}
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
												}
												else
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
												}
												goto IL_056c;
											}
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									}
									goto IL_056c;
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
				goto IL_056c;
			}
			goto IL_0871;
		}
		ResetAwardToDefaultState();
		return;
		IL_056c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj8 = default;
		object obj9 = default;
		bool flag = obj8 == obj9;
		bool flag2 = !flag;
		string text2 = default;
		text = text2;
		if (!flag2)
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
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v431 @ S1_v54+D4] (should have been resolved before IL gen)");
						string text4 = default;
						string text3 = "OwnCharacterOutfitAward parse failed: " + text4;
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
			bool flag3 = (nint)0 == 1;
			string text5 = default;
			text = text5;
			if (flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		goto IL_0871;
		IL_0871:
		string text6 = "OwnCharacterOutfitAward parse failed :Split size not right: " + text;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		((Award)0).ResetAwardToDefaultState();
	}
}
