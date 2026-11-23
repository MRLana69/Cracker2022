using System.Text;
using Cpp2ILInjected;
using Info;
using Missions;
using SYBO.Subway.Info;

public class CelebrationReward
{
	public CelebrationRewardOrigin CelebrationRewardOrigin;

	public CelebrationRewardType rewardType;

	public int amount;

	public Characters.CharacterType characterType;

	public int characterOutfitIndex;

	public Hoverboards.BoardType boardType;

	public Trophies.Trophy trophyType;

	public PowerupType powerupType;

	public long Uid;

	public AwardTierType awardTierType;

	public string awardTitle;

	public int rank = 1;

	public int score;

	public int weekNumber;

	public Hoverboard.BoardAbility boardPower;

	public int characterEventCompleted;

	public string description = string.Empty;

	public override string ToString()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_03c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cd: Expected Obj, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected Obj, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected Obj, but got Unknown
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected Obj, but got Unknown
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected Obj, but got Unknown
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected Obj, but got Unknown
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Expected Obj, but got Unknown
		//IL_0324: Expected Obj, but got I4
		//IL_03a0: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 - 32;
		StringBuilder stringBuilder = default;
		stringBuilder._002Ector();
		_ = CelebrationRewardOrigin;
		object obj3 = obj + 28;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		object value = default;
		StringBuilder stringBuilder2 = stringBuilder.Append(value);
		StringBuilder stringBuilder3 = stringBuilder2.Append(",");
		_ = rewardType;
		object obj4 = obj + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		object value2 = default;
		StringBuilder stringBuilder4 = stringBuilder.Append(value2);
		StringBuilder stringBuilder5 = stringBuilder4.Append(",");
		StringBuilder stringBuilder6 = stringBuilder.Append(amount);
		StringBuilder stringBuilder7 = stringBuilder6.Append(",");
		_ = characterType;
		object obj5 = obj + 20;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		object value3 = default;
		StringBuilder stringBuilder8 = stringBuilder.Append(value3);
		StringBuilder stringBuilder9 = stringBuilder8.Append(",");
		StringBuilder stringBuilder10 = stringBuilder.Append(characterOutfitIndex);
		StringBuilder stringBuilder11 = stringBuilder10.Append(",");
		_ = boardType;
		object obj6 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		object value4 = default;
		StringBuilder stringBuilder12 = stringBuilder.Append(value4);
		StringBuilder stringBuilder13 = stringBuilder12.Append(",");
		_ = trophyType;
		object obj7 = obj + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		object value5 = default;
		StringBuilder stringBuilder14 = stringBuilder.Append(value5);
		StringBuilder stringBuilder15 = stringBuilder14.Append(",");
		_ = powerupType;
		object obj8 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		object value6 = default;
		StringBuilder stringBuilder16 = stringBuilder.Append(value6);
		StringBuilder stringBuilder17 = stringBuilder16.Append(",");
		StringBuilder stringBuilder18 = stringBuilder.Append(Uid);
		StringBuilder stringBuilder19 = stringBuilder18.Append(",");
		_ = awardTierType;
		object obj9 = obj + 4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		object value7 = default;
		StringBuilder stringBuilder20 = stringBuilder.Append(value7);
		StringBuilder stringBuilder21 = stringBuilder20.Append(",");
		StringBuilder stringBuilder22 = stringBuilder.Append(awardTitle);
		StringBuilder stringBuilder23 = stringBuilder22.Append(",");
		StringBuilder stringBuilder24 = stringBuilder.Append(rank);
		StringBuilder stringBuilder25 = stringBuilder24.Append(",");
		StringBuilder stringBuilder26 = stringBuilder.Append(score);
		StringBuilder stringBuilder27 = stringBuilder26.Append(",");
		StringBuilder stringBuilder28 = stringBuilder.Append(weekNumber);
		StringBuilder stringBuilder29 = stringBuilder28.Append(",");
		obj = boardPower;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		object value8 = default;
		StringBuilder stringBuilder30 = stringBuilder.Append(value8);
		StringBuilder stringBuilder31 = stringBuilder30.Append(",");
		StringBuilder stringBuilder32 = stringBuilder.Append(characterEventCompleted);
		StringBuilder stringBuilder33 = stringBuilder32.Append(",");
		StringBuilder stringBuilder34 = stringBuilder.Append(description);
		nint num = (nint)stringBuilder;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v235 @ S1_v95 (Il2CppClass<System.Text.StringBuilder>)+D4] (should have been resolved before IL gen)");
		string result = default;
		return result;
	}

	public void PopulateFromString(string rewardAsString)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0e8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e94: Expected Obj, but got Unknown
		//IL_0152: Expected I4, but got Obj
		//IL_0cbf: Expected Obj, but got I
		//IL_0cea: Expected Obj, but got I
		//IL_0d0f: Expected Obj, but got I
		//IL_0d25: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d2a: Expected Obj, but got Unknown
		//IL_0d4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d53: Expected Obj, but got Unknown
		//IL_0d8a: Expected Obj, but got I
		//IL_020d: Expected I4, but got Obj
		//IL_030d: Expected I4, but got Obj
		//IL_040d: Expected I4, but got Obj
		//IL_04c8: Expected I4, but got Obj
		//IL_0583: Expected I4, but got Obj
		//IL_082d: Expected I4, but got Obj
		//IL_0a7f: Expected I4, but got Obj
		//IL_0aef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af4: Expected Obj, but got Unknown
		//IL_0b06: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		object obj3 = obj + 8;
		_ = 0;
		ResetToDefaultValues();
		string[] array = rewardAsString.Split(',');
		if (array.Length < 9)
		{
			return;
		}
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
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
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
							CelebrationRewardOrigin = (CelebrationRewardOrigin)obj4;
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
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										object obj5 = default;
										rewardType = (CelebrationRewardType)obj5;
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											int num = default;
											amount = num;
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
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													if ((nint)0 != 1)
													{
														object obj6 = default;
														characterType = (Characters.CharacterType)obj6;
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
														if ((nint)0 != 1)
														{
															int num2 = default;
															characterOutfitIndex = num2;
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
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
																	_ = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																	if ((nint)0 != 1)
																	{
																		object obj7 = default;
																		boardType = (Hoverboards.BoardType)obj7;
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
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
																				_ = 0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																				if ((nint)0 != 1)
																				{
																					object obj8 = default;
																					trophyType = (Trophies.Trophy)obj8;
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
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
																							_ = 0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																							if ((nint)0 != 1)
																							{
																								object obj9 = default;
																								powerupType = (PowerupType)obj9;
																								_ = 0;
																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3DE");
																								_ = 0;
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																								if ((nint)0 != 1)
																								{
																									long uid = default;
																									Uid = uid;
																									if (array.Length < 11)
																									{
																										return;
																									}
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
																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
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
																														object obj10 = default;
																														awardTierType = (AwardTierType)obj10;
																														awardTitle = array[10];
																														if (array.Length < 14)
																														{
																															return;
																														}
																														_ = 0;
																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
																														_ = 0;
																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																														if ((nint)0 != 1)
																														{
																															int num3 = default;
																															rank = num3;
																															_ = 0;
																															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
																															_ = 0;
																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																															if ((nint)0 != 1)
																															{
																																int num4 = default;
																																score = num4;
																																_ = 0;
																																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
																																_ = 0;
																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																if ((nint)0 != 1)
																																{
																																	int num5 = default;
																																	weekNumber = num5;
																																	if (array.Length < 15)
																																	{
																																		return;
																																	}
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
																																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
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
																																						object obj11 = default;
																																						boardPower = (Hoverboard.BoardAbility)obj11;
																																						if (array.Length > 16)
																																						{
																																							_ = 0;
																																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
																																							_ = 0;
																																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																							if ((nint)0 != 1)
																																							{
																																								int num6 = default;
																																								characterEventCompleted = num6;
																																								object obj12 = array - -64;
																																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1015 @ S1_v251+10]");
																																								description = (string)0;
																																								return;
																																							}
																																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																							goto IL_0bbf;
																																						}
																																						return;
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
																														goto IL_0bbf;
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
																								}
																								else
																								{
																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																								}
																								goto IL_0bbf;
																							}
																						}
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																					}
																					else
																					{
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																					}
																					goto IL_0bbf;
																				}
																			}
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																		}
																		else
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																		}
																		goto IL_0bbf;
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
														goto IL_0bbf;
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
										goto IL_0bbf;
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							}
							goto IL_0bbf;
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
		goto IL_0bbf;
		IL_0bbf:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj13 = default;
		object obj14 = default;
		bool flag = obj13 != obj14;
		object obj16 = default;
		object obj15 = obj16;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				object obj18 = default;
				object obj17 = obj18;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj19 = default;
					if (obj19 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
						object obj20 = (nint)0 << 2;
						object obj21 = obj3 + obj20;
						obj21 = obj18;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
						object obj22 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
						object obj23 = (nint)0 << 2;
						object obj24 = obj23 + obj3;
						object obj25 = obj24 - 4;
						object obj26 = obj25;
						ResetToDefaultValues();
						object obj27 = obj26;
						object obj28 = obj26 + 40;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v501 @ S1_v50+E4] (should have been resolved before IL gen)");
						string text2 = default;
						string text = "The string could not be converted to a reward!" + text2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
						object obj29 = -1;
						return;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
					object obj30 = obj18;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag2 = (nint)0 != 1;
					obj15 = obj18;
					if (flag2)
					{
						goto IL_0ed7;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag3 = (nint)0 != 1;
			object obj31 = default;
			obj15 = obj31;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				obj15 = obj31;
			}
		}
		goto IL_0ed7;
		IL_0ed7:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
	}

	private void ResetToDefaultValues()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		object obj = this + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @237");
		awardTitle = string.Empty;
		weekNumber = 1;
		rank = 1;
	}
}
