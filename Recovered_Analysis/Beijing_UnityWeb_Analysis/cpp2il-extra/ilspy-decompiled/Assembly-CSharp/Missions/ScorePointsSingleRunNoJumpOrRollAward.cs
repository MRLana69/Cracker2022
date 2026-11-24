using System;
using Cpp2ILInjected;
using Info;
using SYBO.Subway;

namespace Missions;

public class ScorePointsSingleRunNoJumpOrRollAward : Award
{
	private int _offset;

	public ScorePointsSingleRunNoJumpOrRollAward(AwardStaticData awardData, PersistentAwardProgress savedProgress, Action<Award> handler)
	{
		throw new ArrayTypeMismatchException();
	}

	protected override int GetProgressForGoal(AwardGoal goal)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
		object obj = default;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v6+8]");
			object obj2 = default;
			if ((nint)obj2 >= 0)
			{
				return 1;
			}
		}
		return 0;
	}

	public override bool IsGoalAccomplished(AwardGoal goal)
	{
		string privacyPolicyUrl = Globals.GetPrivacyPolicyUrl();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ S0_v2 (System.String)+74]");
		return (byte)(-_offset) != 0;
	}

	protected override void ActivateCurrentAwardTier()
	{
		RewardPayedOut();
	}

	protected unsafe override void DeactivateCurrentAwardTier()
	{
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Expected Obj, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected Obj, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected Obj, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected Obj, but got Unknown
		//IL_010b: Expected I, but got Obj
		//IL_0121: Expected Obj, but got I
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected Obj, but got Unknown
		//IL_014c: Expected I, but got Obj
		string privacyPolicyUrl = Globals.GetPrivacyPolicyUrl();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(ScorePointsSingleRunNoJumpOrRollAward.OnScoreChanged);
		object obj = action + 16;
		obj = this;
		((GameStats)(object)privacyPolicyUrl).OnScoreChanged -= action;
		string privacyPolicyUrl2 = Globals.GetPrivacyPolicyUrl();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Action action2 = default;
		((Delegate)action2).method_ptr = method_ptr2;
		((Delegate)action2).method = (nint)__ldftn(ScorePointsSingleRunNoJumpOrRollAward.OnJumpsChanged);
		object obj2 = action2 + 16;
		obj2 = this;
		((GameStats)(object)privacyPolicyUrl2).OnJumpsChanged -= action2;
		string privacyPolicyUrl3 = Globals.GetPrivacyPolicyUrl();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr3 = 0;
		Action action3 = default;
		((Delegate)action3).method_ptr = method_ptr3;
		((Delegate)action3).method = (nint)__ldftn(ScorePointsSingleRunNoJumpOrRollAward.OnRollsChanged);
		object obj3 = action3 + 16;
		obj3 = this;
		((GameStats)(object)privacyPolicyUrl3).OnRollsChanged -= action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr4 = 0;
		Action action4 = default;
		((Delegate)action4).method_ptr = method_ptr4;
		((Delegate)action4).method = (nint)__ldftn(ScorePointsSingleRunNoJumpOrRollAward.OnRunStarted);
		object obj4 = action4 + 16;
		obj4 = this;
		nint num = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v18 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v31 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Game.OnGameStarted -= action4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr5 = 0;
		Action action5 = default;
		((Delegate)action5).method_ptr = method_ptr5;
		((Delegate)action5).method = (nint)__ldftn(ScorePointsSingleRunNoJumpOrRollAward.OnRunEnded);
		object obj6 = action5 + 16;
		obj6 = this;
		Game.OnMenuScreenShown -= action5;
		RewardPayedOut();
	}

	protected unsafe override void RecordNewOffsets()
	{
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected Obj, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected Obj, but got Unknown
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected Obj, but got Unknown
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected Obj, but got Unknown
		//IL_00e3: Expected I, but got Obj
		//IL_00f9: Expected Obj, but got I
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected Obj, but got Unknown
		//IL_0124: Expected I, but got Obj
		string privacyPolicyUrl = Globals.GetPrivacyPolicyUrl();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(ScorePointsSingleRunNoJumpOrRollAward.OnScoreChanged);
		object obj = action + 16;
		obj = this;
		((GameStats)(object)privacyPolicyUrl).OnJumpsChanged += action;
		string privacyPolicyUrl2 = Globals.GetPrivacyPolicyUrl();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Action action2 = default;
		((Delegate)action2).method_ptr = method_ptr2;
		((Delegate)action2).method = (nint)__ldftn(ScorePointsSingleRunNoJumpOrRollAward.OnJumpsChanged);
		object obj2 = action2 + 16;
		obj2 = this;
		((GameStats)(object)privacyPolicyUrl2).OnRollsChanged += action2;
		string privacyPolicyUrl3 = Globals.GetPrivacyPolicyUrl();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		Action<UpgradeType> action3 = default;
		object obj3 = action3 + 16;
		obj3 = this;
		((GameStats)(object)privacyPolicyUrl3).PowerupTriggered += action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num2 = 0;
		_ = 0;
		Action<bool, bool, bool, bool> action4 = default;
		object obj4 = action4 + 16;
		obj4 = this;
		nint num3 = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v18 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num4 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v30 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Game.OnRunStarted += action4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr3 = 0;
		Action action5 = default;
		((Delegate)action5).method_ptr = method_ptr3;
		((Delegate)action5).method = (nint)__ldftn(ScorePointsSingleRunNoJumpOrRollAward.OnRunEnded);
		object obj6 = action5 + 16;
		obj6 = this;
		Game.OnGameDestroyed += action5;
	}

	private void OnRunStarted()
	{
	}

	private void OnRunEnded()
	{
		_offset = 0;
	}

	private void OnScoreChanged()
	{
		string privacyPolicyUrl = Globals.GetPrivacyPolicyUrl();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S1_v2 (System.String)+74]");
		_offset = 0;
	}

	private void OnJumpsChanged()
	{
		RewardPayedOut();
	}

	private void OnRollsChanged()
	{
		string privacyPolicyUrl = Globals.GetPrivacyPolicyUrl();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S1_v2 (System.String)+74]");
		_offset = 0;
	}
}
