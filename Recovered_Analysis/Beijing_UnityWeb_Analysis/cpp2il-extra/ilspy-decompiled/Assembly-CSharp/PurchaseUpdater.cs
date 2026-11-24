using System.Collections.Generic;
using Cpp2ILInjected;
using Data.Save;
using InApp;
using Info;
using UI.Screens.UpgradeScreenInternal;
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

	public void UpgradePurchased(UpgradeType type)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00b3: Expected Obj, but got I4
		//IL_00b3: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(InAppManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<InApp.InAppManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<InApp.InAppManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Dictionary<string, InAppItemModel> activeInAppOffers = InAppManager.GetActiveInAppOffers();
		InventorySave.LogSpentEvent((int)activeInAppOffers, (InAppItemModel.ItemType)type, "Keys popup", (string)6);
	}
}
