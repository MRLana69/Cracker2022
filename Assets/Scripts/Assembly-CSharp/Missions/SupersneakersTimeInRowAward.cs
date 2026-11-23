using System;
using System.Globalization;
using System.Text;
using Cpp2ILInjected;

namespace Missions;

public class SupersneakersTimeInRowAward : Award
{
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

	public SupersneakersTimeInRowAward(AwardStaticData awardData, string savedProgress, Action<Award> handler)
		: base(awardData, savedProgress, handler)
	{
		_offset = 0;
	}

	protected override int GetProgressForGoal(AwardGoal goal)
	{
		//IL_0077: Expected F8, but got I4
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected I4, but got Unknown
		SuperSneakers instance = SuperSneakers.Instance;
		if (instance != null)
		{
			double num = instance.timeActiveInARow;
			double num2 = Math.Abs((double)instance.timeActiveInARow);
			if (!(num2 < 2147483648.0))
			{
				num = -2147483648.0;
			}
			return (int)(num / 60);
		}
		return 0;
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
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v22 @ S3_v4 (Il2CppClass<Missions.SupersneakersTimeInRowAward>)+E4] (should have been resolved before IL gen)");
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
		Action action = default;
		action._002Ector(this, (nint)__ldftn(SupersneakersTimeInRowAward.OnTimeChanged));
		Delegate obj = Delegate.Combine(SuperSneakers.OnSupersneakersTimeActiveChange, action);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		Action onSupersneakersTimeActiveChange = default;
		SuperSneakers.OnSupersneakersTimeActiveChange = onSupersneakersTimeActiveChange;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		CheckAndUpdateProgress();
	}

	protected unsafe override void DeactivateCurrentAwardTier()
	{
		Action action = default;
		action._002Ector(this, (nint)__ldftn(SupersneakersTimeInRowAward.OnTimeChanged));
		Delegate obj = Delegate.Remove(SuperSneakers.OnSupersneakersTimeActiveChange, action);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		Action onSupersneakersTimeActiveChange = default;
		SuperSneakers.OnSupersneakersTimeActiveChange = onSupersneakersTimeActiveChange;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
	}

	protected override void RecordNewOffsets()
	{
	}

	private void OnTimeChanged()
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
		//IL_087c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0881: Expected Obj, but got Unknown
		//IL_06a8: Expected Obj, but got I
		//IL_06d3: Expected Obj, but got I
		//IL_06f8: Expected Obj, but got I
		//IL_070e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0713: Expected Obj, but got Unknown
		//IL_08e8: Expected Obj, but got I
		//IL_01e5: Expected I4, but got Obj
		//IL_075c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0761: Expected Obj, but got Unknown
		//IL_02a0: Expected I4, but got Obj
		//IL_035b: Expected I4, but got Obj
		//IL_0416: Expected I4, but got Obj
		object obj2 = default;
		object obj = obj2 - 16;
		object obj3 = obj + 8;
		_ = 0;
		ResetAwardToDefaultState();
		if (s == null || s._stringLength < 1)
		{
			return;
		}
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v20+C]");
			if ((nint)0 <= (nint)4)
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
																	goto IL_05a8;
																}
															}
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
														}
														else
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
														}
														goto IL_05a8;
													}
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
											}
											else
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
											}
											goto IL_05a8;
										}
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								}
								goto IL_05a8;
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
		goto IL_05a8;
		IL_08ab:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		return;
		IL_05a8:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj8 = default;
		object obj9 = default;
		bool flag = obj8 != obj9;
		object obj11 = default;
		object obj10 = obj11;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				object obj13 = default;
				object obj12 = obj13;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj14 = default;
					if (obj14 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
						object obj15 = (nint)0 << 2;
						object obj16 = obj3 + obj15;
						obj16 = obj13;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
						object obj17 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
						object obj18 = (nint)0 << 2;
						object obj19 = obj18 + obj3;
						object obj20 = obj19 - 4;
						object obj21 = obj20;
						bool flag2 = obj20 == null;
						string text = null;
						string text2 = "SupersneakersTimeInRowAward parse failed: ";
						if (!flag2)
						{
							object obj22 = obj21;
							object obj23 = obj21 + 24;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v435 @ S1_v55+D4] (should have been resolved before IL gen)");
							string text3 = default;
							text = text3;
							text2 = "SupersneakersTimeInRowAward parse failed: ";
						}
						string text4 = text2 + text;
						ResetAwardToDefaultState();
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
						object obj24 = -1;
						return;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
					object obj25 = obj13;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag3 = (nint)0 != 1;
					obj10 = obj13;
					if (flag3)
					{
						goto IL_08ab;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag4 = (nint)0 != 1;
			object obj26 = default;
			obj10 = obj26;
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				obj10 = obj26;
			}
		}
		goto IL_08ab;
	}
}
