using System;
using Cpp2ILInjected;
using UnityEngine;

namespace Missions;

public class SupersneakersTimeInRowAward : Award
{
	public SupersneakersTimeInRowAward(AwardStaticData awardData, PersistentAwardProgress savedProgress, Action<Award> handler)
	{
		throw new ArrayTypeMismatchException();
	}

	protected override int GetProgressForGoal(AwardGoal goal)
	{
		//IL_0023: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		int num = default;
		object obj = num + 16;
		obj = this;
		return num;
	}

	public override bool IsGoalAccomplished(AwardGoal goal)
	{
		//IL_0195: Expected I, but got Obj
		//IL_01ab: Expected Obj, but got I
		//IL_021d: Expected I, but got Obj
		//IL_0233: Expected Obj, but got I
		//IL_01d2: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00af: Expected Obj, but got I
		//IL_0108: Invalid comparison between I and F4
		//IL_0149: Invalid comparison between I and F4
		//IL_00f2: Expected Obj, but got I4
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected I4, but got Unknown
		//IL_0133: Expected Obj, but got I4
		//IL_0174: Expected Obj, but got I4
		nint num = (nint)typeof(SuperSneakers);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SuperSneakers>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SuperSneakers);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v38 (Il2CppClass<SuperSneakers>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool watchedReviveAdInCurrentRun = SaveMeManager.WatchedReviveAdInCurrentRun;
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v13 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v34 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)watchedReviveAdInCurrentRun).FindKernel(null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v11 (System.Boolean)+34]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v11 (System.Boolean)+34]");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v11 (System.Boolean)+34]");
			if (num5 != 0)
			{
				obj3 = int.MinValue;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v11 (System.Boolean)+34]");
				if (!(0f < 2.1474836E+09f))
				{
					obj3 = int.MinValue;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v11 (System.Boolean)+34]");
					if (!(0f > -2.1474836E+09f))
					{
						obj3 = int.MinValue;
					}
				}
			}
			return (byte)(obj3 / 60) != 0;
		}
		return false;
	}

	protected override void ActivateCurrentAwardTier()
	{
	}

	protected unsafe override void DeactivateCurrentAwardTier()
	{
		//IL_0070: Expected I, but got Obj
		//IL_0086: Expected Obj, but got I
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(SuperSneakers);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SuperSneakers>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SuperSneakers);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v18 (Il2CppClass<SuperSneakers>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Delegate obj2 = default;
		obj2.method_ptr = method_ptr;
		obj2.method = (nint)__ldftn(SupersneakersTimeInRowAward.OnTimeChanged);
		object obj3 = obj2 + 16;
		obj3 = this;
		Delegate obj4 = ((Delegate)SuperSneakers.OnSupersneakersTimeActiveChange).CombineImpl(obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		Action onSupersneakersTimeActiveChange = default;
		SuperSneakers.OnSupersneakersTimeActiveChange = onSupersneakersTimeActiveChange;
		RewardPayedOut();
	}

	protected unsafe override void RecordNewOffsets()
	{
		//IL_006a: Expected I, but got Obj
		//IL_0080: Expected Obj, but got I
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(SuperSneakers);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SuperSneakers>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SuperSneakers);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v17 (Il2CppClass<SuperSneakers>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Delegate obj2 = default;
		obj2.method_ptr = method_ptr;
		obj2.method = (nint)__ldftn(SupersneakersTimeInRowAward.OnTimeChanged);
		object obj3 = obj2 + 16;
		obj3 = this;
		Delegate obj4 = ((Delegate)SuperSneakers.OnSupersneakersTimeActiveChange).RemoveImpl(obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		Action onSupersneakersTimeActiveChange = default;
		SuperSneakers.OnSupersneakersTimeActiveChange = onSupersneakersTimeActiveChange;
	}

	private void OnTimeChanged()
	{
	}
}
