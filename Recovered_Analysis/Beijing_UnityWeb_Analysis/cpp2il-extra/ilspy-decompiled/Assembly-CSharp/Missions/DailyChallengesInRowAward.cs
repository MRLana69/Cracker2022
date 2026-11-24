using System;
using Cpp2ILInjected;
using WordHunt;

namespace Missions;

public class DailyChallengesInRowAward : Award
{
	public DailyChallengesInRowAward(AwardStaticData awardData, PersistentAwardProgress savedProgress, Action<Award> handler)
	{
		throw new ArrayTypeMismatchException();
	}

	private int GetDailyChallengesInRow()
	{
		//IL_000b: Expected Obj, but got I4
		//IL_001a: Expected Obj, but got I4
		//IL_002e: Expected Obj, but got I4
		//IL_0040: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected I4, but got Unknown
		bool flag = ((AwardsManager)(object)this).ShouldInsertAwardToList((Award)3);
		bool flag2 = ((AwardsManager)(object)this).ShouldInsertAwardToList((Award)2);
		bool flag3 = ((AwardsManager)(object)this).ShouldInsertAwardToList((Award)1);
		object obj = (flag2 ? 1u : 0u) << 1;
		object obj2 = (flag ? 1 : 0) * 3;
		object obj3 = obj + obj2;
		return (int)(flag3 + obj3);
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
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected I4, but got Unknown
		string name = ((MissionSkip)null).name;
		PersistentAwardProgress persistentAwardProgress = savedProgress;
		return (byte)(name - persistentAwardProgress.offset) != 0;
	}

	protected override void ActivateCurrentAwardTier()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Missions.DailyChallengesInRowAward)+2C]");
		_ = 0;
	}

	protected unsafe override void DeactivateCurrentAwardTier()
	{
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected Obj, but got Unknown
		//IL_009f: Expected I, but got Obj
		//IL_00b5: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(DailyChallengesInRowAward.OnDailyWordInRowChanged);
		object obj = action + 16;
		obj = this;
		nint num = (nint)typeof(WordHuntManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v12 (Il2CppClass<WordHunt.WordHuntManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(WordHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v18 (Il2CppClass<WordHunt.WordHuntManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		WordHuntManager.OnDailyWordInRowChanged -= action;
		RewardPayedOut();
	}

	protected override void RecordNewOffsets()
	{
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_008b: Expected I, but got Obj
		//IL_00a1: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		Action<int> action = default;
		object obj = action + 16;
		obj = this;
		nint num2 = (nint)typeof(WordHuntManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v12 (Il2CppClass<WordHunt.WordHuntManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num3 = (nint)typeof(WordHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v17 (Il2CppClass<WordHunt.WordHuntManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		WordHuntManager.OnDailyLetterCoinsRewarded += action;
	}

	private void SyncOffset()
	{
	}

	private void OnDailyWordInRowChanged()
	{
		//IL_007d: Expected I4, but got Obj
		string name = ((MissionSkip)null).name;
		PersistentAwardProgress persistentAwardProgress = savedProgress;
		if (persistentAwardProgress.offset != -1)
		{
			PersistentAwardProgress persistentAwardProgress2 = savedProgress;
			if (persistentAwardProgress2.offset <= (nint)name)
			{
				goto IL_009f;
			}
		}
		PersistentAwardProgress persistentAwardProgress3 = savedProgress;
		persistentAwardProgress3.offset = (int)name;
		goto IL_009f;
		IL_009f:
		PersistentAwardProgress persistentAwardProgress4 = savedProgress;
		if (persistentAwardProgress4.offset < 0)
		{
			PersistentAwardProgress persistentAwardProgress5 = savedProgress;
			persistentAwardProgress5.offset = 0;
		}
	}
}
