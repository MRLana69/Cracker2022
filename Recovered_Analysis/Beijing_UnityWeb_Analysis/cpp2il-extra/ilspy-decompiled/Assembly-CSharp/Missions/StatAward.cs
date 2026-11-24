using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Data.Save;

namespace Missions;

public class StatAward : Award
{
	private bool _shouldMigrateToUseStatOffset;

	public StatAward(AwardStaticData awardData, PersistentAwardProgress savedProgress, Action<Award> handler)
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
		//IL_0016: Expected Obj, but got I
		//IL_0042: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
		object obj = default;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v6+14]");
			string type = ((Notification)0).type;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v6+14]");
			IEnumerator enumerator = ((StayInOneLaneMission)(object)this).CountMissionProgressCoroutine(0);
			return (byte)((object)type - (object)enumerator) != 0;
		}
		return false;
	}

	private int OffsetForStat(Stat stat)
	{
		//IL_0016: Expected Obj, but got I
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
		object obj = default;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v6+14]");
			string type = ((Notification)0).type;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v6+14]");
			IEnumerator enumerator = ((StayInOneLaneMission)(object)this).CountMissionProgressCoroutine(0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v6+8]");
			object obj2 = enumerator + 0;
			if (System.Runtime.CompilerServices.Unsafe.As<string, UIntPtr>(ref type) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2))
			{
				return 1;
			}
		}
		return 0;
	}

	protected override void ActivateCurrentAwardTier()
	{
		string privacyPolicyUrl = Globals.GetPrivacyPolicyUrl();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S1_v2 (System.String)+74]");
		_shouldMigrateToUseStatOffset = false;
	}

	protected override void DeactivateCurrentAwardTier()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		Action<Stat, int> action = default;
		object obj = action + 16;
		obj = this;
		PlayerSave.statChanged -= action;
		RewardPayedOut();
	}

	protected override void RecordNewOffsets()
	{
		//IL_002b: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		MysteryBox.Type type = default;
		object obj = type + 16;
		obj = this;
		PlayerSave.IncrementMysteryBoxesOpened(type);
	}

	private unsafe void OnStatChanged(Stat stat, int newValue)
	{
		//IL_0006: Expected I4, but got Obj
		//IL_0018: Expected Obj, but got I4
		//IL_0026: Expected Obj, but got I4
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_005e: Expected I4, but got Obj
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected Obj, but got Unknown
		//IL_0089: Expected Obj, but got I4
		//IL_0097: Expected Obj, but got I4
		//IL_00f6: Expected Obj, but got I4
		//IL_018e: Expected Obj, but got I4
		//IL_01dc: Expected Obj, but got I4
		//IL_01ea: Expected Obj, but got I4
		int num = MissionsManager.ApplyCoinDoublers((int)this);
		object obj = num + 16;
		object obj2 = (int)stat << 3;
		object obj3 = obj + obj2;
		object obj4 = obj3;
		object obj5 = obj4 + 32;
		obj5 = obj4;
		((int*)newValue)->m_value = (int)obj5;
		object obj6 = obj4 + 8;
		bool inRun = ((MissionsManager)(object)this).inRun;
		object obj7 = (inRun ? 1 : 0) + 16;
		object obj8 = (int)stat * 24;
		object obj9 = obj7 + obj8;
		obj6 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v16+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v16+10]");
		_ = 0;
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v9+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v9+10]");
		_ = 0;
		object obj10 = newValue + 8;
		obj10 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v6+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v6+10]");
		_ = 0;
		int achievementProgress = PlayerSave.GetAchievementProgress((int)stat);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [newValue @ L2 (System.Int32)+20]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [newValue @ L2 (System.Int32)+4]");
		bool flag = num2 >= 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [newValue @ L2 (System.Int32)+24]");
		if ((nint)0 == 0)
		{
			object obj11 = newValue + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v27+14]");
			if ((nint)0 != 0 && ~(base.isInPreview__BackingField ? 1u : 0u) == 0)
			{
				object obj12 = (base.isInPreview__BackingField ? 1 : 0) + 16;
				object obj13 = (int)stat << 2;
				object obj14 = obj12 + obj13;
			}
		}
	}
}
