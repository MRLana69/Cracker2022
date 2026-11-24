using System;
using Cpp2ILInjected;
using Info;
using UI.FreeStuff;
using UI.Generic.Layout;
using UnityEngine;

namespace UI;

public class CoinEarnerButtonHelper : MonoBehaviour
{
	private GameObject _normalContent;

	private GameObject _connectingContent;

	private Layout _contentLayout;

	private Layout _connectingLayout;

	private BoxCollider _collider;

	private UILabel _connectingLabel;

	private UISprite _icon;

	private UILabel _title;

	private UILabel _description;

	private UILabel _priceLabel;

	private UILabel _getLabel;

	private int _earnCurrencyProfileIndex;

	private Action _onClickDelegate;

	public void Init(int earnCurrencyProfileIndex, string title, string desc, string iconName, int price, Action onClickDelegate)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Expected Obj, but got Unknown
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Expected Obj, but got Unknown
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_032f: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 32;
		object obj3 = obj2 + 16;
		object obj4 = obj2 + 8;
		object obj5 = obj2 + 24;
		obj5 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		object obj7 = default;
		object obj6 = obj7;
		object obj9 = default;
		object obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj10 = default;
		if (obj8 == obj10)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			object obj12 = default;
			object obj11 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
			object obj14 = default;
			object obj13 = obj14;
		}
		else
		{
			object obj13 = obj6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
	}

	private void OnClick()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(DiscountButton);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.DiscountButton>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DiscountButton);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<UI.DiscountButton>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((DoubleCoinUpgradeHelper)this).ForceEndDiscount();
	}

	private void GoToNormalState()
	{
		//IL_0070: Expected I, but got Obj
		//IL_0086: Expected Obj, but got I
		//IL_00ae: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(EarnCoinsData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<Info.EarnCoinsData>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(EarnCoinsData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v10 (Il2CppClass<Info.EarnCoinsData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((HeadstartTier)_earnCurrencyProfileIndex)._002Ector();
		if (_onClickDelegate != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
		}
	}

	private void GoToConnectingState()
	{
		//IL_0010: Expected Obj, but got I4
		_normalContent.tag = (string)1;
		_connectingContent.tag = null;
		_collider.isTrigger = true;
		((RewardForVideoButton)(object)_contentLayout).Init((VideoButtonPayload)null);
	}

	public CoinEarnerButtonHelper()
	{
		//IL_001c: Expected Obj, but got I4
		_normalContent.tag = null;
		_connectingContent.tag = (string)1;
		_collider.isTrigger = false;
		((RewardForVideoButton)(object)_connectingLayout).Init((VideoButtonPayload)null);
	}
}
