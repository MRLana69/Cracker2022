using System;
using System.Globalization;
using System.Text;
using Cpp2ILInjected;
using SYBO.Subway;
using SYBO.Subway.Characters;

namespace Missions;

public class ScorePointsSingleLane : Award
{
	private Character character;

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

	public ScorePointsSingleLane(AwardStaticData awardData, string savedProgress, Action<Award> handler)
		: base(awardData, savedProgress, handler)
	{
		_offset = 0;
	}

	protected override int GetProgressForGoal(AwardGoal goal)
	{
		GameStats instance = GameStats.Instance;
		return instance._score - _offset;
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
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v22 @ S3_v4 (Il2CppClass<Missions.ScorePointsSingleLane>)+E4] (should have been resolved before IL gen)");
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
		GameStats instance = GameStats.Instance;
		Action action = default;
		action._002Ector(this, (nint)__ldftn(ScorePointsSingleLane.OnScoreChanged));
		instance.OnScoreChanged += action;
		Action action2 = default;
		action2._002Ector(this, (nint)__ldftn(ScorePointsSingleLane.OnRunStarted));
		Game.OnGameStarted += action2;
		Action action3 = default;
		action3._002Ector(this, (nint)__ldftn(ScorePointsSingleLane.OnRunEnded));
		Game.OnMenuScreenShown += action3;
		CheckAndUpdateProgress();
	}

	protected unsafe override void DeactivateCurrentAwardTier()
	{
		GameStats instance = GameStats.Instance;
		Action action = default;
		action._002Ector(this, (nint)__ldftn(ScorePointsSingleLane.OnScoreChanged));
		instance.OnScoreChanged -= action;
		Action action2 = default;
		action2._002Ector(this, (nint)__ldftn(ScorePointsSingleLane.OnRunStarted));
		Game.OnGameStarted -= action2;
		Action action3 = default;
		action3._002Ector(this, (nint)__ldftn(ScorePointsSingleLane.OnRunEnded));
		Game.OnMenuScreenShown -= action3;
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
		//IL_0851: Unknown result type (might be due to invalid IL or missing references)
		//IL_0856: Expected Obj, but got Unknown
		//IL_0038: Expected Obj, but got I4
		//IL_001c: Expected Obj, but got I4
		//IL_08b2: Expected Obj, but got I
		//IL_01c0: Expected I4, but got Obj
		//IL_067c: Expected Obj, but got I
		//IL_06a7: Expected Obj, but got I
		//IL_06cc: Expected Obj, but got I
		//IL_06e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e7: Expected Obj, but got Unknown
		//IL_0700: Unknown result type (might be due to invalid IL or missing references)
		//IL_0705: Expected Obj, but got Unknown
		//IL_0747: Expected Obj, but got I
		//IL_027b: Expected I4, but got Obj
		//IL_0336: Expected I4, but got Obj
		//IL_03f1: Expected I4, but got Obj
		object obj2 = default;
		object obj = obj2 - 16;
		object obj3 = obj + 8;
		_ = 0;
		object obj4;
		if (s != null)
		{
			obj4 = 0;
			if (s._stringLength != 0)
			{
				goto IL_0879;
			}
		}
		obj4 = 1;
		goto IL_0879;
		IL_0574:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj5 = default;
		object obj6 = default;
		bool flag = obj5 == obj6;
		bool flag2 = !flag;
		object obj8 = default;
		object obj7 = obj8;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				object obj10 = default;
				object obj9 = obj10;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj11 = default;
					if (obj11 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
						object obj12 = (nint)0 << 2;
						object obj13 = obj3 + obj12;
						obj13 = obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
						object obj14 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
						object obj15 = (nint)0 << 2;
						object obj16 = obj15 + obj3;
						object obj17 = obj16 - 4;
						object obj18 = obj17;
						object obj19 = obj18;
						object obj20 = obj18 + 24;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v432 @ S1_v52+D4] (should have been resolved before IL gen)");
						string text2 = default;
						string text = "ScorePointsOneRunNoJumpOrRollAward parse failed: " + text2;
						ResetAwardToDefaultState();
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
						object obj21 = -1;
						return;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
					object obj22 = obj10;
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
			object obj23 = default;
			obj7 = obj23;
			if (flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		goto IL_08a1;
		IL_08a1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		((Award)0).ResetAwardToDefaultState();
		return;
		IL_0879:
		if (obj4 == null)
		{
			string[] array = s.Split(',');
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
									object obj24 = default;
									_savedActiveTierType = (AwardTierType)obj24;
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
												object obj25 = default;
												_currentActiveAwardState = (AwardState)obj25;
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
															object obj26 = default;
															_savedProgressTierType = (AwardTierType)obj26;
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
																		object obj27 = default;
																		_currentProgressAwardState = (AwardState)obj27;
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
																		goto IL_0574;
																	}
																}
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
															}
															else
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
															}
															goto IL_0574;
														}
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
												}
												else
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
												}
												goto IL_0574;
											}
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									}
									goto IL_0574;
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
				goto IL_0574;
			}
			goto IL_08a1;
		}
		ResetAwardToDefaultState();
	}

	private unsafe void OnRunStarted()
	{
		Character instance = Character.Instance;
		character = instance;
		if (character != null)
		{
			Character.OnChangeTrackDelegate onChangeTrackDelegate = default;
			onChangeTrackDelegate._002Ector(this, (nint)__ldftn(ScorePointsSingleLane.OnLaneChanged));
			character.OnChangeTrack += onChangeTrackDelegate;
		}
		_offset = 0;
	}

	private unsafe void OnRunEnded()
	{
		if (character != null)
		{
			Character.OnChangeTrackDelegate onChangeTrackDelegate = default;
			onChangeTrackDelegate._002Ector(this, (nint)__ldftn(ScorePointsSingleLane.OnLaneChanged));
			character.OnChangeTrack -= onChangeTrackDelegate;
		}
		GameStats instance = GameStats.Instance;
		_offset = instance._score;
	}

	private void OnScoreChanged()
	{
		CheckAndUpdateProgress();
	}

	private void OnLaneChanged(Character.OnChangeTrackDirection direction)
	{
		GameStats instance = GameStats.Instance;
		_offset = instance._score;
	}
}
