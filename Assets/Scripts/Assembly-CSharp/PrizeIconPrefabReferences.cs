using System;
using Cpp2ILInjected;
using UnityEngine;

public class PrizeIconPrefabReferences : MonoBehaviour
{
	[Serializable]
	private struct PrizeModel
	{
		public WeeklyHuntManager.WeeklyHuntPrize rewardType;

		public GameObject iconPrefab;
	}

	private PrizeModel[] modelReferences;

	public GameObject GetPrefab(WeeklyHuntManager.PrizeData prizeData)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected Obj, but got Unknown
		//IL_0176: Expected Obj, but got I4
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected VT, but got Unknown
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected Obj, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected Obj, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected Obj, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected Obj, but got Unknown
		//IL_009f: Expected Obj, but got I
		//IL_00b8: Expected Obj, but got I
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected Obj, but got Unknown
		//IL_0138: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 96;
		_ = 0;
		object obj3 = obj - -64;
		obj3 = prizeData.rewardType;
		_ = prizeData.characterType;
		_ = prizeData.trophyType;
		_ = prizeData.amount;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+50]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
		_ = 0;
		WeeklyHuntManager.PrizeData prizeData2 = (WeeklyHuntManager.PrizeData)(obj + 8);
		WeeklyHuntManager.WeeklyHuntPrize weeklyHuntPrize = WeeklyHuntManager.DeterminePrize(prizeData2);
		object obj4 = default;
		UnityEngine.Object result;
		object obj12 = default;
		while (true)
		{
			PrizeModel[] array = modelReferences;
			if (array.Length > (nint)obj4)
			{
				object obj5 = obj4 << 3;
				object obj6 = (object)array + obj5;
				object obj7 = obj6 + 16;
				if ((nint)weeklyHuntPrize == (nint)obj7)
				{
					object obj8 = obj4 << 3;
					object obj9 = (object)modelReferences + obj8;
					object obj10 = obj9 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S0_v50+4]");
					bool flag = (UnityEngine.Object)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S0_v50+4]");
					result = (UnityEngine.Object)0;
					if (!flag)
					{
						Enum obj11 = (Enum)(obj + 40);
						_ = -1;
						obj11 = (Enum)(object)typeof(WeeklyHuntManager.WeeklyHuntPrize);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+5C]");
						_ = 0;
						string text = obj11.ToString();
						string text2 = "Prize '" + text + "' doesn't have a model set";
						GameObject gameObject = base.gameObject;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S0_v50+4]");
						result = (UnityEngine.Object)0;
					}
					break;
				}
				obj4 = obj12 + 1;
				continue;
			}
			Enum obj13 = (Enum)(obj + 40);
			_ = -1;
			obj13 = (Enum)(object)typeof(CelebrationRewardType);
			_ = prizeData.rewardType;
			string text3 = obj13.ToString();
			string text4 = "Unable to find icon prefab for prize '" + text3 + "'";
			GameObject gameObject2 = base.gameObject;
			result = null;
			break;
		}
		return (GameObject)result;
	}

	public PrizeIconPrefabReferences()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		PrizeModel[] array = default;
		modelReferences = array;
		base._002Ector();
	}
}
