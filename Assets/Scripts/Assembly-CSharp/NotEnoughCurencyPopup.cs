using System;
using Cpp2ILInjected;
using TMPro;
using UI.Screens;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class NotEnoughCurencyPopup : UIScreen
{
	private enum PopupClosingAction
	{
		none,
		buy,
		cancel,
		ok
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static UnityAction _003C_003E9__6_0;

		static _003C_003Ec()
		{
			_003C_003Ec obj = default;
			_003C_003E9 = obj;
		}

		internal void _003COnEnable_003Eb__6_0()
		{
			UIScreenController instance = UIScreenController.Instance;
			instance.CloseActivePopups("NotEnoughCurencyPopup");
		}
	}

	private TMP_Text popupDescription;

	private Button cancelButton;

	private GameObject uiContentCoins;

	private GameObject uiContentKeys;

	private InAppManagerPopupData _popupData;

	private UIPopupIn UIPopupIn;

	private unsafe void OnEnable()
	{
		Button button = cancelButton;
		bool flag = _003C_003Ec._003C_003E9__6_0 == null;
		bool flag2 = !flag;
		UnityAction call = _003C_003Ec._003C_003E9__6_0;
		if (!flag2)
		{
			UnityAction unityAction = default;
			unityAction._002Ector(_003C_003Ec._003C_003E9, (nint)__ldftn(_003C_003Ec._003COnEnable_003Eb__6_0));
			_003C_003Ec._003C_003E9__6_0 = unityAction;
			call = unityAction;
		}
		button.m_OnClick.AddListener(call);
		UnityAction unityAction2 = default;
		unityAction2._002Ector(this, (nint)__ldftn(NotEnoughCurencyPopup._003COnEnable_003Eb__6_1));
		OutConplete.AddListener(unityAction2);
	}

	public override void Init()
	{
		//IL_0005: Expected I, but got Obj
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3 @ S1_v2 (Il2CppClass<NotEnoughCurencyPopup>)+104] (should have been resolved before IL gen)");
	}

	public override void Show()
	{
		//IL_0058: Expected I, but got Obj
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected Obj, but got Unknown
		base.Show();
		ShowPopUp();
		InAppManager instance = InAppManager.instance;
		_popupData = instance._popupData;
		InAppManagerPopupData popupData = _popupData;
		if (_popupData != null)
		{
			TMP_Text tMP_Text = popupDescription;
			nint num = (nint)tMP_Text;
			object obj = tMP_Text + 528;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v31 @ S2_v3 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
			InAppManagerPopupData popupData2 = _popupData;
			bool active;
			if (~(popupData2.isErrorMessage ? 1u : 0u) == 0)
			{
				uiContentCoins.SetActive(value: false);
				active = false;
			}
			else if (~(popupData2.isCoinsPack ? 1u : 0u) == 0)
			{
				uiContentCoins.SetActive(value: true);
				active = false;
			}
			else
			{
				uiContentCoins.SetActive(value: false);
				active = true;
			}
			uiContentKeys.SetActive(active);
		}
	}

	private void GetComponent()
	{
		if (UIPopupIn == null)
		{
			UIPopupIn componentInChildren = GetComponentInChildren<UIPopupIn>();
			UIPopupIn = componentInChildren;
		}
	}

	private void ShowPopUp()
	{
		GetComponent();
		UIPopupIn.PlayAnim(UIPopupIn.TYPE.IN);
	}

	public void HidePupUp()
	{
		GetComponent();
		UIPopupIn.PlayAnim(UIPopupIn.TYPE.OUT);
	}

	public override void Hide()
	{
		base.Hide();
		_popupData = null;
	}

	private void _003COnEnable_003Eb__6_1()
	{
		//IL_0005: Expected I, but got Obj
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		nint num = (nint)this;
		object obj = this + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3 @ S1_v2 (Il2CppClass<NotEnoughCurencyPopup>)+EC] (should have been resolved before IL gen)");
	}
}
