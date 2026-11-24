using System;
using Cpp2ILInjected;
using SYBO.Subway;

namespace Missions;

public class ScorePointsSingleRunNoCoinsAward : Award
{
	private int _offset;

	public ScorePointsSingleRunNoCoinsAward(AwardStaticData awardData, PersistentAwardProgress savedProgress, Action<Award> handler)
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
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected Obj, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected Obj, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected Obj, but got Unknown
		//IL_00b1: Expected I, but got Obj
		//IL_00c7: Expected Obj, but got I
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Expected Obj, but got Unknown
		//IL_00f2: Expected I, but got Obj
		string privacyPolicyUrl = Globals.GetPrivacyPolicyUrl();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(ScorePointsSingleRunNoCoinsAward.OnScoreChanged);
		object obj = action + 16;
		obj = this;
		((GameStats)(object)privacyPolicyUrl).OnScoreChanged -= action;
		string privacyPolicyUrl2 = Globals.GetPrivacyPolicyUrl();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Action action2 = default;
		((Delegate)action2).method_ptr = method_ptr2;
		((Delegate)action2).method = (nint)__ldftn(ScorePointsSingleRunNoCoinsAward.OnCoinsChanged);
		object obj2 = action2 + 16;
		obj2 = this;
		((GameStats)(object)privacyPolicyUrl2).OnCoinsChanged -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr3 = 0;
		Action action3 = default;
		((Delegate)action3).method_ptr = method_ptr3;
		((Delegate)action3).method = (nint)__ldftn(ScorePointsSingleRunNoCoinsAward.OnRunStarted);
		object obj3 = action3 + 16;
		obj3 = this;
		nint num = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v16 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v29 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Game.OnGameStarted -= action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr4 = 0;
		Action action4 = default;
		((Delegate)action4).method_ptr = method_ptr4;
		((Delegate)action4).method = (nint)__ldftn(ScorePointsSingleRunNoCoinsAward.OnRunEnded);
		object obj5 = action4 + 16;
		obj5 = this;
		Game.OnMenuScreenShown -= action4;
		RewardPayedOut();
	}

	protected unsafe override void RecordNewOffsets()
	{
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected Obj, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected Obj, but got Unknown
		//IL_0089: Expected I, but got Obj
		//IL_009f: Expected Obj, but got I
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected Obj, but got Unknown
		//IL_00ca: Expected I, but got Obj
		string privacyPolicyUrl = Globals.GetPrivacyPolicyUrl();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(ScorePointsSingleRunNoCoinsAward.OnScoreChanged);
		object obj = action + 16;
		obj = this;
		((GameStats)(object)privacyPolicyUrl).OnJumpsChanged += action;
		string privacyPolicyUrl2 = Globals.GetPrivacyPolicyUrl();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		Action<int> action2 = default;
		object obj2 = action2 + 16;
		obj2 = this;
		((GameStats)(object)privacyPolicyUrl2).OnCoinsIncreased += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num2 = 0;
		_ = 0;
		Action<bool, bool, bool, bool> action3 = default;
		object obj3 = action3 + 16;
		obj3 = this;
		nint num3 = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v16 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v28 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Game.OnRunStarted += action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Action action4 = default;
		((Delegate)action4).method_ptr = method_ptr2;
		((Delegate)action4).method = (nint)__ldftn(ScorePointsSingleRunNoCoinsAward.OnRunEnded);
		object obj5 = action4 + 16;
		obj5 = this;
		Game.OnGameDestroyed += action4;
	}

	private void OnCoinsChanged()
	{
	}

	private void OnRunStarted()
	{
		string privacyPolicyUrl = Globals.GetPrivacyPolicyUrl();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S1_v2 (System.String)+74]");
		_offset = 0;
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
}
