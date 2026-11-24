using System;
using Cpp2ILInjected;
using Info;
using SYBO.Subway.Info;
using UI.Screens.RewardManagement;
using UnityEngine;

namespace WeeklyHunt;

public class PrizeIconPrefabReferences : MonoBehaviour
{
	[Serializable]
	private struct PrizeModel
	{
		public WeeklyHuntData.WeeklyHuntPrize rewardType;

		public GameObject iconPrefab;
	}

	private PrizeModel[] modelReferences;

	public unsafe GameObject GetPrefab(WeeklyHuntData.PrizeData prizeData)
	{
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Expected Obj, but got Unknown
		//IL_0348: Expected Obj, but got I4
		//IL_0355: Expected Obj, but got I4
		//IL_0381: Expected I, but got Obj
		//IL_0397: Expected Obj, but got I
		//IL_03f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f8: Expected VT, but got Unknown
		//IL_0405: Expected I4, but got Obj
		//IL_0400: Expected native int or pointer, but got VT
		//IL_0415: Expected native int or pointer, but got VT
		//IL_042a: Expected native int or pointer, but got VT
		//IL_043f: Expected native int or pointer, but got VT
		//IL_0462: Unknown result type (might be due to invalid IL or missing references)
		//IL_0467: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0264: Expected I, but got Obj
		//IL_027a: Expected Obj, but got I
		//IL_015e: Expected Obj, but got I
		//IL_02a5: Expected I, but got Obj
		//IL_0173: Expected Obj, but got I
		//IL_0188: Expected Obj, but got I
		//IL_019d: Expected Obj, but got I
		//IL_01b2: Expected Obj, but got I
		//IL_01c7: Expected Obj, but got I
		//IL_01dc: Expected Obj, but got I
		//IL_01f1: Expected Obj, but got I
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 28;
		obj = 0;
		obj2 = prizeData.amount;
		_ = prizeData.rewardType;
		_ = prizeData.characterId;
		_ = prizeData.trophyType;
		nint num = (nint)typeof(WeeklyHuntManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v15 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(WeeklyHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v74 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		WeeklyHuntData.PrizeData prizeData2 = (WeeklyHuntData.PrizeData)(obj2 + 32);
		((WeeklyHuntData.PrizeData*)(nint)prizeData2)->amount = (int)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((WeeklyHuntData.PrizeData*)(nint)prizeData2)->rewardType = CelebrationRewardType._notset;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
		((WeeklyHuntData.PrizeData*)(nint)prizeData2)->characterId = Characters.CharacterId.slick;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+18]");
		((WeeklyHuntData.PrizeData*)(nint)prizeData2)->trophyType = Trophies.Trophy.diamond;
		string text = WeeklyHuntManager.Get(prizeData2);
		obj = text;
		object obj4 = text - 1;
		UnityEngine.Object obj6;
		if ((nint)text != 1)
		{
			if ((nint)obj4 != 1)
			{
				if ((nint)obj4 != 2)
				{
					if ((nint)obj4 != 3)
					{
						if ((nint)obj4 != 4)
						{
							if ((nint)obj4 != 5)
							{
								if ((nint)obj4 != 6)
								{
									if ((nint)obj4 != 7)
									{
										if ((nint)obj4 != 8)
										{
											object obj5 = prizeData + 8;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
											throw new NullReferenceException();
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (WeeklyHunt.PrizeIconPrefabReferences)+2C]");
										obj6 = (UnityEngine.Object)0;
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (WeeklyHunt.PrizeIconPrefabReferences)+28]");
										obj6 = (UnityEngine.Object)0;
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (WeeklyHunt.PrizeIconPrefabReferences)+24]");
									obj6 = (UnityEngine.Object)0;
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (WeeklyHunt.PrizeIconPrefabReferences)+20]");
								obj6 = (UnityEngine.Object)0;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (WeeklyHunt.PrizeIconPrefabReferences)+1C]");
							obj6 = (UnityEngine.Object)0;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (WeeklyHunt.PrizeIconPrefabReferences)+18]");
						obj6 = (UnityEngine.Object)0;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (WeeklyHunt.PrizeIconPrefabReferences)+14]");
					obj6 = (UnityEngine.Object)0;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (WeeklyHunt.PrizeIconPrefabReferences)+10]");
				obj6 = (UnityEngine.Object)0;
			}
		}
		else
		{
			obj6 = (UnityEngine.Object)(object)modelReferences;
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v32 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v45 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!UnityEngine.Object.IsNativeObjectAlive(obj6))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			throw new NullReferenceException();
		}
		return (GameObject)obj6;
	}

	public PrizeIconPrefabReferences()
	{
		ScriptableObject.CreateScriptableObject((ScriptableObject)(object)this);
	}
}
