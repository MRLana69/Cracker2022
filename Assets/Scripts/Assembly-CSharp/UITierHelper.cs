using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

public class UITierHelper : MonoBehaviour
{
	public Image[] slots;

	private PowerupType _type;

	public bool ResetTiers()
	{
		//IL_0044: Expected Obj, but got I4
		SetupTiers(_type);
		PlayerInfo instance = PlayerInfo.Instance;
		int currentTier = instance.GetCurrentTier(_type);
		Upgrade upgrade = Upgrades.upgrades.get_Item(_type);
		object obj = upgrade.numberOfTiers - 1;
		return currentTier >= (nint)obj;
	}

	public void SetupTiers(PowerupType type)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00de: Expected Obj, but got I8
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		if (slots == null)
		{
			return;
		}
		_type = type;
		PlayerInfo instance = PlayerInfo.Instance;
		int currentTier = instance.GetCurrentTier(type);
		object obj3 = default;
		object obj6 = default;
		while (true)
		{
			Image[] array = slots;
			if ((nint)obj3 < array.Length)
			{
				object obj4 = obj3 << 2;
				object obj5 = (object)array + obj4;
				_ = 1065353216;
				bool flag = currentTier > (nint)obj3;
				float num = 1f;
				if (!flag)
				{
					num = 0f;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
				_ = 0;
				_ = 4575657222473777152L;
				obj = 4575657222473777152L;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @388");
				obj3 = obj6 + 1;
				continue;
			}
			break;
		}
	}
}
