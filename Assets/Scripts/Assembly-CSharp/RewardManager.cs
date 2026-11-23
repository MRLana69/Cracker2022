using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected;

public static class RewardManager
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<CelebrationReward, bool> _003C_003E9__9_0;

		static _003C_003Ec()
		{
			_003C_003Ec obj = default;
			_003C_003E9 = obj;
		}

		internal bool _003CPayoutNonMysteryBoxRewards_003Eb__9_0(CelebrationReward celebrationReward)
		{
			//IL_0013: Expected Obj, but got I4
			//IL_0068: Expected Obj, but got I4
			//IL_0076: Unknown result type (might be due to invalid IL or missing references)
			//IL_007b: Expected I4, but got Unknown
			//IL_004c: Expected Obj, but got I4
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Expected Obj, but got Unknown
			object obj = celebrationReward.CelebrationRewardOrigin - 1;
			object obj3;
			if ((nint)obj <= 12)
			{
				object obj2 = 4123 >> (int)obj;
				obj3 = obj2 & 1;
			}
			else
			{
				obj3 = 0;
			}
			return (byte)(obj3 ^ 1) != 0;
		}
	}

	public static bool canShowMultipleQueuedCelebrations;

	public static int rewardsToUnlockCount
	{
		get
		{
			PlayerInfo instance = PlayerInfo.Instance;
			List<CelebrationReward> pendingRewards = instance._pendingRewards;
			return pendingRewards._size;
		}
	}

	public static void AddRewardToUnlock(CelebrationRewardOrigin origin, bool shouldSaveToDisk = true)
	{
		//IL_00ee: Expected Obj, but got I4
		object obj = origin - 1;
		bool flag = origin == CelebrationRewardOrigin.MysteryBox;
		MysteryBox.Type mysteryBoxType = MysteryBox.Type.Normal;
		if (!flag)
		{
			if ((nint)obj == 1)
			{
				goto IL_00b2;
			}
			if ((nint)obj == 2)
			{
				return;
			}
			bool flag2 = (nint)obj == 3;
			mysteryBoxType = MysteryBox.Type.Normal;
			if (!flag2)
			{
				if ((nint)obj == 4)
				{
					goto IL_00b2;
				}
				bool flag3 = origin == CelebrationRewardOrigin.MysteryBoxMini;
				mysteryBoxType = MysteryBox.Type.Mini;
				if (!flag3)
				{
					return;
				}
			}
		}
		goto IL_0114;
		IL_00b2:
		mysteryBoxType = MysteryBox.Type.Super;
		goto IL_0114;
		IL_0114:
		CelebrationReward celebrationReward = MysteryBox.Roll(mysteryBoxType);
		if (celebrationReward != null)
		{
			celebrationReward.CelebrationRewardOrigin = origin;
			AddMysteryBoxToUnlock(celebrationReward, shouldSaveToDisk);
		}
	}

	public static void AddRewardToUnlock(CelebrationReward reward, bool shouldSaveToDisk = true)
	{
		if (reward.CelebrationRewardOrigin != CelebrationRewardOrigin.Notset && reward.rewardType != CelebrationRewardType._notset)
		{
			AddMysteryBoxToUnlock(reward, shouldSaveToDisk);
		}
	}

	private static void AddMysteryBoxToUnlock(CelebrationReward reward, bool shouldSaveToDisk = true)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		PlayerInfo instance = PlayerInfo.Instance;
		throw new ArgumentException();
	}

	public static CelebrationReward[] GetRewardsToUnlockForCelebration()
	{
		PlayerInfo instance = PlayerInfo.Instance;
		if (instance._lastAddedReward != null && !canShowMultipleQueuedCelebrations)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			PlayerInfo instance2 = PlayerInfo.Instance;
			throw new ArrayTypeMismatchException();
		}
		PlayerInfo instance3 = PlayerInfo.Instance;
		return instance3._pendingRewards.ToArray();
	}

	public static void RewardPayedOut(CelebrationReward celebrationReward)
	{
		PlayerInfo instance = PlayerInfo.Instance;
		instance.RemovePendingReward(celebrationReward);
	}

	public static List<CelebrationReward> GetWeeklyHuntRewardsToUnlock()
	{
		PlayerInfo instance = PlayerInfo.Instance;
		List<CelebrationReward> list = default;
		list._002Ector();
		int num = 0;
		while (true)
		{
			List<CelebrationReward> pendingRewards = instance._pendingRewards;
			if (num >= pendingRewards._size)
			{
				break;
			}
			CelebrationReward celebrationReward = instance._pendingRewards.get_Item(num);
			if (celebrationReward.CelebrationRewardOrigin == CelebrationRewardOrigin.WeeklyChallengeNormal)
			{
				list.Add(celebrationReward);
			}
			int num2 = num + 1;
			num = num2;
		}
		return list;
	}

	public static void PayoutNonMysteryBoxRewards()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_037f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0384: Expected Obj, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Obj, but got Unknown
		//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Expected Obj, but got Unknown
		//IL_03ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bf: Expected Obj, but got Unknown
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Expected Obj, but got Unknown
		//IL_034b: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		PlayerInfo instance = PlayerInfo.Instance;
		List<CelebrationReward> list = default;
		list._002Ector((IEnumerable<CelebrationReward>)instance._pendingRewards);
		bool flag = _003C_003Ec._003C_003E9__9_0 == null;
		bool flag2 = !flag;
		Func<CelebrationReward, bool> predicate = _003C_003Ec._003C_003E9__9_0;
		if (!flag2)
		{
			throw new ArgumentException();
		}
		object obj3 = obj + 16;
		IEnumerable<CelebrationReward> source = Enumerable.Where(list, predicate);
		List<CelebrationReward> list2 = Enumerable.ToList(source);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
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
		object obj9 = default;
		object obj11 = default;
		object obj12 = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				bool flag3 = obj6 == null;
				obj7 = obj;
				if (flag3)
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
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								continue;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
						goto IL_0208;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			goto IL_0208;
			IL_0208:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag4 = obj8 == obj9;
			bool flag5 = !flag4;
			object obj10 = obj11;
			if (!flag5)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag6 = (nint)0 != 1;
				obj7 = obj;
				if (flag6)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj10 = obj12;
			}
			_ = 0;
			object obj13 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				obj7 = 0;
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			return;
		}
		object obj14 = obj7 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2386");
	}

	private static bool IsRewardMysteryBox(CelebrationReward reward)
	{
		//IL_0013: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected I4, but got Unknown
		object obj = reward.CelebrationRewardOrigin - 1;
		if ((nint)obj <= 12)
		{
			object obj2 = 4123 >> (int)obj;
			return (byte)(obj2 & 1) != 0;
		}
		return false;
	}
}
