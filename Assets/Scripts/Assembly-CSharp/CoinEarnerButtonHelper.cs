using System;
using Cpp2ILInjected;
using UI.Screens;
using UnityEngine;

public class CoinEarnerButtonHelper : MonoBehaviour
{
	private GameObject _normalContent;

	private GameObject _connectingContent;

	private BoxCollider _collider;

	public UISprite icon;

	public UILabel title;

	public UILabel description;

	public UILabel priceLabel;

	private int earnCurrencyProfileIndex;

	private Action _onClickDelegate;

	private bool _createdFromCoinScreen;

	public unsafe void Init(int earnCurrencyProfileIndex, string title, string desc, string iconName, int price, Action onClickDelegate, bool createdFromCoinScreen = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0091: Expected I, but got Obj
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected Obj, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		this.earnCurrencyProfileIndex = earnCurrencyProfileIndex;
		this.title.text = title;
		_onClickDelegate = onClickDelegate;
		icon.spriteName = iconName;
		description.text = desc;
		if (priceLabel != null)
		{
			int num = obj + 12;
			string text = ((int*)num)->ToString();
			priceLabel.text = text;
		}
		_createdFromCoinScreen = createdFromCoinScreen;
		UISprite uISprite = icon;
		nint num2 = (nint)uISprite;
		object obj3 = uISprite + 296;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v68 @ S1_v13 (Il2CppClass<UISprite>)+1E4] (should have been resolved before IL gen)");
		GoToNormalState();
	}

	private void OnClick()
	{
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected Obj, but got Unknown
		//IL_00b3: Expected Obj, but got I
		int num = earnCurrencyProfileIndex << 2;
		object obj = EarnCoinsData.profiles + num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v11+10]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v12+8]");
		if ((nint)0 == 9)
		{
			if (~(_createdFromCoinScreen ? 1u : 0u) == 0)
			{
				CoinScreen.FacebookLoginClicked();
			}
			else
			{
				EarnCoinsScreen.FacebookLoginClicked();
			}
			GoToConnectingState();
		}
		else
		{
			EarnCoinsData.Trigger(earnCurrencyProfileIndex);
		}
		Action onClickDelegate = _onClickDelegate;
		if (_onClickDelegate != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v48.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	private void GoToNormalState()
	{
		_normalContent.SetActive(value: true);
		_connectingContent.SetActive(value: false);
		_collider.enabled = true;
	}

	private void GoToConnectingState()
	{
		_normalContent.SetActive(value: false);
		_connectingContent.SetActive(value: true);
		_collider.enabled = false;
	}
}
