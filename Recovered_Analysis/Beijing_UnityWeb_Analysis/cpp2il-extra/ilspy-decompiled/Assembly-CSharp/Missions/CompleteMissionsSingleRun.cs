using System;
using Cpp2ILInjected;
using SYBO.Subway;

namespace Missions;

public class CompleteMissionsSingleRun : Award
{
	private int _progress;

	private int _offset;

	public CompleteMissionsSingleRun(AwardStaticData awardData, PersistentAwardProgress savedProgress, Action<Award> handler)
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
			if (obj2 == null)
			{
				return 1;
			}
		}
		return 0;
	}

	public override bool IsGoalAccomplished(AwardGoal goal)
	{
		return (byte)(_progress - _offset) != 0;
	}

	protected override void ActivateCurrentAwardTier()
	{
		_offset = 0;
		_progress = 0;
	}

	protected unsafe override void DeactivateCurrentAwardTier()
	{
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected Obj, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		//IL_0048: Expected I, but got Obj
		//IL_005e: Expected Obj, but got I
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected Obj, but got Unknown
		//IL_0089: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		MissionsManager.MissionCompleteHandler missionCompleteHandler = default;
		((Delegate)missionCompleteHandler).method_ptr = method_ptr;
		((Delegate)missionCompleteHandler).method = (nint)__ldftn(CompleteMissionsSingleRun.OnMissionCompleted);
		object obj = missionCompleteHandler + 16;
		obj = this;
		MissionsManager.onMissionComplete -= missionCompleteHandler;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr2;
		((Delegate)action).method = (nint)__ldftn(CompleteMissionsSingleRun.OnRunStarted);
		object obj2 = action + 16;
		obj2 = this;
		nint num = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v19 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v32 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Game.OnGameStarted -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr3 = 0;
		Action action2 = default;
		((Delegate)action2).method_ptr = method_ptr3;
		((Delegate)action2).method = (nint)__ldftn(CompleteMissionsSingleRun.OnRunEnded);
		object obj4 = action2 + 16;
		obj4 = this;
		Game.OnMenuScreenShown -= action2;
		RewardPayedOut();
	}

	protected unsafe override void RecordNewOffsets()
	{
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_0034: Expected I, but got Obj
		//IL_004a: Expected Obj, but got I
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected Obj, but got Unknown
		//IL_0075: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		MissionsManager missionsManager = default;
		missionsManager._currentMissionTemplateSetLoaded = (int)num;
		missionsManager._defaultMissionIndexUpdateInterval = 0;
		object obj = missionsManager + 16;
		obj = this;
		missionsManager._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num2 = 0;
		_ = 0;
		Action<bool, bool, bool, bool> action = default;
		object obj2 = action + 16;
		obj2 = this;
		nint num3 = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v19 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v31 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Game.OnRunStarted += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action2 = default;
		((Delegate)action2).method_ptr = method_ptr;
		((Delegate)action2).method = (nint)__ldftn(CompleteMissionsSingleRun.OnRunEnded);
		object obj4 = action2 + 16;
		obj4 = this;
		Game.OnGameDestroyed += action2;
	}

	private void OnRunStarted()
	{
	}

	private void OnRunEnded()
	{
		_offset = 0;
		_progress = 0;
	}

	private void OnMissionCompleted(string description, int missionIndex)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_001d: Expected Obj, but got I4
		object obj = this + 12;
		obj = description;
		_awardData = (AwardStaticData)missionIndex;
	}
}
