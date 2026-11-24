using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Data.Managers;
using Data.Save;
using Info;
using SYBO.Components.Utilities;
using UnityEngine;

namespace Missions;

public class OwnBoardsAward : Award
{
	public unsafe OwnBoardsAward(AwardStaticData awardData, PersistentAwardProgress savedProgress, Action<Award> handler)
	{
		//IL_06cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d2: Expected Obj, but got Unknown
		//IL_06db: Expected Obj, but got I4
		//IL_06fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ff: Expected Obj, but got Unknown
		//IL_0705: Expected Obj, but got I
		//IL_070e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0713: Expected I4, but got Unknown
		//IL_0720: Expected I4, but got Obj
		//IL_074c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0751: Expected Obj, but got Unknown
		//IL_087d: Expected I4, but got Obj
		//IL_008b: Expected Obj, but got I4
		//IL_0099: Expected Obj, but got I4
		//IL_00b3: Expected I4, but got Obj
		//IL_00d4: Expected Obj, but got I4
		//IL_00f4: Expected I4, but got Obj
		//IL_010b: Expected Obj, but got I4
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected Obj, but got Unknown
		//IL_0195: Expected I4, but got Obj
		//IL_0203: Expected I4, but got Obj
		//IL_0330: Expected Obj, but got I4
		//IL_079b: Expected I4, but got Obj
		//IL_041f: Expected I4, but got Obj
		//IL_0345: Expected Obj, but got I4
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0360: Expected Obj, but got Unknown
		//IL_0291: Expected Obj, but got I4
		//IL_0546: Expected I4, but got Obj
		//IL_037a: Expected I4, but got Obj
		//IL_05c0: Expected I4, but got Obj
		//IL_05ce: Expected I, but got Obj
		//IL_05e4: Expected Obj, but got I
		//IL_046b: Expected I4, but got Obj
		//IL_02ac: Expected I4, but got Obj
		//IL_02d5: Expected Obj, but got I4
		//IL_0582: Expected I4, but got Obj
		//IL_03af: Expected I4, but got Obj
		//IL_060f: Expected I, but got Obj
		//IL_02f3: Expected Obj, but got I4
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Expected Obj, but got Unknown
		//IL_0656: Expected I4, but got Obj
		//IL_065e: Expected I4, but got Obj
		//IL_03e1: Expected I4, but got Obj
		//IL_0406: Expected Obj, but got I4
		//IL_04b6: Expected Obj, but got I4
		//IL_0695: Expected I4, but got Obj
		//IL_06bb: Expected Obj, but got I4
		//IL_04da: Unknown result type (might be due to invalid IL or missing references)
		//IL_04df: Expected Obj, but got Unknown
		//IL_04e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ed: Expected Obj, but got Unknown
		//IL_0503: Unknown result type (might be due to invalid IL or missing references)
		//IL_0508: Expected Obj, but got Unknown
		//IL_052d: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - -64;
		obj = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj3 = obj2 + 56;
		obj3 = 0;
		CallingConvention callingConvention = (CallingConvention)(obj2 + 8);
		((CallingConvention*)(int)callingConvention)->value__ = (int)obj3;
		UnmanagedFunctionPointerAttribute unmanagedFunctionPointerAttribute = default;
		unmanagedFunctionPointerAttribute._002Ector(callingConvention);
		PersistentAwardProgress persistentAwardProgress2 = default;
		PersistentAwardProgress persistentAwardProgress = (PersistentAwardProgress)((((OwnBoardsAward)(object)awardData).GetProgressForGoal((AwardGoal)(object)unmanagedFunctionPointerAttribute) == 0) ? ((object)persistentAwardProgress2) : ((object)((MissionsManager)(object)persistentAwardProgress2).GetMissionInfo()));
		object obj4 = obj2 + 32;
		bool flag = (nint)awardData == 78;
		int num = 0;
		while (true)
		{
			int num2 = MissionsManager.ApplyCoinDoublers((int)this);
			int num3 = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S1_v21 (System.Int32)+C]");
			if ((nint)num3 >= (nint)0)
			{
				break;
			}
			if (num != (nint)handler)
			{
				bool inRun = ((MissionsManager)(object)this).inRun;
				object obj5 = (inRun ? 1 : 0) + 16;
				object obj6 = num * 24;
				PersistentAwardProgress persistentAwardProgress3 = (PersistentAwardProgress)(object)(obj5 + obj6);
				((CallingConvention*)(int)callingConvention)->value__ = (int)persistentAwardProgress3;
				_ = persistentAwardProgress3.activeTierType;
				_ = persistentAwardProgress3.currentActiveAwardState;
				obj = ((CallingConvention*)(int)callingConvention)->value__;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18 (System.Runtime.InteropServices.CallingConvention)+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18 (System.Runtime.InteropServices.CallingConvention)+10]");
				_ = 0;
				int num4 = MissionsManager.ApplyCoinDoublers((int)this);
				object obj7 = num4 + 16;
				int num5 = num << 3;
				object obj8 = obj7 + num5;
				obj2 = obj8;
				obj4 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v24+10]");
				bool flag2 = 0 == (nint)awardData;
				bool flag3 = !flag2;
				persistentAwardProgress2 = persistentAwardProgress3;
				if (!flag3)
				{
					((CallingConvention*)(int)callingConvention)->value__ = (int)obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+10]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18 (System.Runtime.InteropServices.CallingConvention)+14]");
					if ((nint)0 != 0)
					{
						bool flag4 = (byte)(~(base.isInPreview__BackingField ? 1u : 0u)) != 0;
						persistentAwardProgress2 = persistentAwardProgress3;
						if (flag4)
						{
							goto IL_076e;
						}
					}
					((CallingConvention*)(int)callingConvention)->value__ = (int)obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+10]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18 (System.Runtime.InteropServices.CallingConvention)+14]");
					if ((nint)0 != 0 && ~(base.isInPreview__BackingField ? 1u : 0u) == 0)
					{
						bool flag5 = (byte)(~(base.isInPreview__BackingField ? 1u : 0u)) != 0;
						int achievementProgress = PlayerSave.GetAchievementProgress(num);
						bool flag6 = !flag5;
						bool flag7 = !flag6;
						persistentAwardProgress2 = (PersistentAwardProgress)achievementProgress;
						if (!flag7)
						{
							((CallingConvention*)(int)callingConvention)->value__ = (int)obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18 (System.Runtime.InteropServices.CallingConvention)+4]");
							bool flag8 = (nint)achievementProgress < (nint)0;
							bool flag9 = !flag8;
							persistentAwardProgress2 = (PersistentAwardProgress)achievementProgress;
							if (!flag9)
							{
								object obj9 = (base.isInPreview__BackingField ? 1 : 0) + 16;
								int num6 = num << 2;
								object obj10 = obj9 + num6;
								persistentAwardProgress2 = (PersistentAwardProgress)obj10;
							}
						}
					}
					else
					{
						int achievementProgress2 = PlayerSave.GetAchievementProgress(num);
						persistentAwardProgress2 = (PersistentAwardProgress)achievementProgress2;
					}
					PersistentAwardProgress persistentAwardProgress4 = (PersistentAwardProgress)(object)((object)persistentAwardProgress + (object)persistentAwardProgress2);
					if (~(base.isInPreview__BackingField ? 1u : 0u) == 0)
					{
						object obj11 = (base.isInPreview__BackingField ? 1 : 0) + 16;
						int num7 = num << 2;
						object obj12 = obj11 + num7;
						obj12 = persistentAwardProgress4;
					}
					((CallingConvention*)(int)callingConvention)->value__ = (int)obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+10]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18 (System.Runtime.InteropServices.CallingConvention)+15]");
					if ((nint)0 != 0)
					{
						((CallingConvention*)(int)callingConvention)->value__ = (int)obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18 (System.Runtime.InteropServices.CallingConvention)+4]");
						if ((nint)persistentAwardProgress < 0)
						{
							((CallingConvention*)(int)callingConvention)->value__ = (int)obj2;
							PersistentAwardProgress persistentAwardProgress5 = persistentAwardProgress2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18 (System.Runtime.InteropServices.CallingConvention)+4]");
							if (persistentAwardProgress5 != null)
							{
								((CallingConvention*)(int)callingConvention)->value__ = (int)obj2;
								int stat = num;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18 (System.Runtime.InteropServices.CallingConvention)+4]");
								PlayerSave.SetStatValue((Stat)stat, 0);
								((SpawnPool)(object)this).Despawn((Transform)num, 1f, (Transform)null);
							}
						}
					}
					else
					{
						((CallingConvention*)(int)callingConvention)->value__ = (int)obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+10]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18 (System.Runtime.InteropServices.CallingConvention)+16]");
						if ((nint)0 != 0)
						{
							((CallingConvention*)(int)callingConvention)->value__ = (int)obj2;
							PersistentAwardProgress persistentAwardProgress6 = ((!flag) ? persistentAwardProgress4 : persistentAwardProgress);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18 (System.Runtime.InteropServices.CallingConvention)+4]");
							if (persistentAwardProgress6 == null)
							{
								int numberOfBasicMission = ((MissionsManager)(object)this).GetNumberOfBasicMission();
								object obj13 = numberOfBasicMission + 16;
								int currentSkipForVideoMissionIndex = PlayerSave.currentSkipForVideoMissionIndex;
								int num8 = currentSkipForVideoMissionIndex << 2;
								object obj14 = obj13 + num8;
								object obj15 = obj14 + 16;
								int num9 = num << 3;
								object obj16 = obj15 + num9;
								int stat2 = num;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ S1_v111+4]");
								PlayerSave.SetStatValue((Stat)stat2, 0);
								((SpawnPool)(object)this).Despawn((Transform)num, 1f, (Transform)null);
							}
						}
						else
						{
							((CallingConvention*)(int)callingConvention)->value__ = (int)obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18 (System.Runtime.InteropServices.CallingConvention)+4]");
							if ((nint)persistentAwardProgress4 < 0)
							{
								((CallingConvention*)(int)callingConvention)->value__ = (int)obj;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+10]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18 (System.Runtime.InteropServices.CallingConvention)+14]");
								if ((nint)0 != 0)
								{
									goto IL_076e;
								}
							}
							((CallingConvention*)(int)callingConvention)->value__ = (int)obj2;
							nint num10 = (nint)typeof(Mathf);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ S0_v88 (Il2CppClass<UnityEngine.Mathf>)+BA]");
							object obj17 = (nint)0 & (nint)0x200;
							if (obj17 != null)
							{
								nint num11 = (nint)typeof(Mathf);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ S0_v98 (Il2CppClass<UnityEngine.Mathf>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18 (System.Runtime.InteropServices.CallingConvention)+4]");
							int num12;
							int value;
							if ((nint)persistentAwardProgress4 < 0)
							{
								num12 = (int)persistentAwardProgress4;
								value = (int)persistentAwardProgress4;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18 (System.Runtime.InteropServices.CallingConvention)+4]");
								num12 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18 (System.Runtime.InteropServices.CallingConvention)+4]");
								value = 0;
							}
							PlayerSave.SetStatValue((Stat)num, value);
							obj2 = obj2;
							PersistentAwardProgress persistentAwardProgress7 = persistentAwardProgress2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
							if ((nint)persistentAwardProgress7 < 0)
							{
								((CallingConvention*)(int)callingConvention)->value__ = (int)obj2;
								float num13 = num12;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18 (System.Runtime.InteropServices.CallingConvention)+4]");
								float seconds = num13 / 0f;
								((SpawnPool)(object)this).Despawn((Transform)num, seconds, (Transform)null);
							}
						}
					}
				}
			}
			goto IL_076e;
			IL_076e:
			int num14 = num + 1;
			num = num14;
		}
	}

	private int GetNumberOfOwnedBoards()
	{
		//IL_0109: Expected I, but got Obj
		//IL_011f: Expected Obj, but got I
		//IL_0084: Expected I, but got Obj
		//IL_016f: Expected Obj, but got I
		//IL_0177: Expected I4, but got Obj
		//IL_00a0: Expected I, but got Obj
		//IL_00d0: Expected I, but got Obj
		//IL_0154: Expected I4, but got Obj
		//IL_002c: Expected I, but got Obj
		//IL_00f6: Expected I, but got Obj
		nint num = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<AdLocations>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		bool flag = obj != null;
		if (this != null)
		{
			if (flag)
			{
				nint num2 = (nint)typeof(AdLocations);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v29 (Il2CppClass<AdLocations>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (int)AdLocations.SKIP_MISSION_PAUSE_VIDEOS;
		}
		bool flag2 = !flag;
		nint num3 = (nint)typeof(AdLocations);
		if (!flag2)
		{
			nint num4 = (nint)typeof(AdLocations);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18 (Il2CppClass<AdLocations>)+74]");
			bool flag3 = (nint)0 == 0;
			bool flag4 = !flag3;
			num3 = (nint)typeof(AdLocations);
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num3 = (nint)typeof(AdLocations);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ L1_v3 (Il2CppClass<AdLocations>)+5C]");
		object obj2 = -(-64);
		return (int)obj2;
	}

	protected override int GetProgressForGoal(AwardGoal goal)
	{
		//IL_0013: Expected I4, but got Obj
		return (int)Enumerable.OrderBy<TSource, TKey>((IEnumerable<TSource>)goal, (Func<TSource, TKey>)(object)this);
	}

	public override bool IsGoalAccomplished(AwardGoal goal)
	{
		return (byte)((OwnCharactersOutfitsAward)null).GetNumberOfOwnedCharacterOutfits() != 0;
	}

	protected override void ActivateCurrentAwardTier()
	{
		//IL_0049: Expected Obj, but got I4
		int currentSkipForVideoMissionIndex = PlayerSave.currentSkipForVideoMissionIndex;
		if (currentSkipForVideoMissionIndex == -1)
		{
			int numberOfBasicMission = ((MissionsManager)(object)this).GetNumberOfBasicMission();
			object obj = numberOfBasicMission + 16;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S2_v5+C]");
			((MissionsManager)(object)this).PlayerDidThis(MissionTarget.none, 0, 1);
		}
	}

	protected override void DeactivateCurrentAwardTier()
	{
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_008b: Expected I, but got Obj
		//IL_00a1: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		Action<Boards.BoardId> action = default;
		object obj = action + 16;
		obj = this;
		nint num2 = (nint)typeof(BoardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num3 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v21 (Il2CppClass<Data.Managers.BoardManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		BoardManager.boardUnlocked -= action;
		RewardPayedOut();
	}

	protected override void RecordNewOffsets()
	{
		//IL_0078: Expected Obj, but got I4
		//IL_008b: Expected I, but got Obj
		//IL_00a1: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		Boards.BoardId boardId = default;
		object obj = boardId + 16;
		obj = this;
		nint num2 = (nint)typeof(BoardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num3 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v20 (Il2CppClass<Data.Managers.BoardManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		BoardManager.UnlockBoard(boardId);
	}

	private void BoardUnlocked(Boards.BoardId boardId)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		//IL_0040: Expected Obj, but got I4
		//IL_0053: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 4;
		obj = boardId;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		obj2 = 2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		Enum obj3 = default;
		IFormatProvider provider = default;
		if (obj3.System_002EIConvertible_002EToBoolean(provider))
		{
			ActivateCurrentAwardTier();
		}
	}
}
