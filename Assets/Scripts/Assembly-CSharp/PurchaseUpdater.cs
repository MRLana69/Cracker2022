using UnityEngine;

public class PurchaseUpdater : MonoBehaviour
{
	public UILabel price;

	public UISprite coin;

	public UITierHelper tierHelper;

	public UILabel haveAmount;

	public GameObject buyButton;

	public UILabel buyButtonTitle;

	public UISprite buyButtonBackground;

	public unsafe void UpgradePurchased(PowerupType type)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_02ed: Expected Obj, but got I4
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected I4, but got Unknown
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		object obj3 = type - 1;
		if (type != PowerupType.hoverboard && (nint)obj3 != 1 && (nint)obj3 != 2)
		{
			if ((nint)obj3 != 3 && (nint)obj3 != 4 && ((nint)obj3 == 5 || (nint)obj3 == 6 || (nint)obj3 == 7 || (nint)obj3 == 8 || (nint)obj3 == 9))
			{
				if (tierHelper.ResetTiers())
				{
					NGUITools.Destroy(coin);
					price.text = string.Empty;
					buyButtonTitle.text = "Max";
					BoxCollider component = buyButton.GetComponent<BoxCollider>();
					Object.Destroy(component);
				}
				else
				{
					Upgrade upgrade = Upgrades.upgrades.get_Item(type);
					PlayerInfo instance = PlayerInfo.Instance;
					int currentTier = instance.GetCurrentTier(type);
					int tier = currentTier + 1;
					int num = upgrade.getPrice(tier);
					int num2 = obj + 12;
					string text = ((int*)num2)->ToString();
					string text2 = string.Empty + text;
					price.text = text2;
				}
			}
		}
		else if (haveAmount != null)
		{
			PlayerInfo instance2 = PlayerInfo.Instance;
			int upgradeAmount = instance2.GetUpgradeAmount(type);
			int num3 = obj + 12;
			string text3 = ((int*)num3)->ToString();
			string text4 = "You have: " + text3;
			haveAmount.text = text4;
		}
	}
}
