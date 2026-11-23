using System;
using Cpp2ILInjected;
using UI.Screens;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class PrizeMBPopup : UIScreen
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static UnityAction _003C_003E9__1_0;

		static _003C_003Ec()
		{
			_003C_003Ec obj = default;
			_003C_003E9 = obj;
		}

		internal void _003COnEnable_003Eb__1_0()
		{
			UIScreenController instance = UIScreenController.Instance;
			instance.CloseActivePopups("PrizeMBPopup_Keys");
		}
	}

	private Button closeButton;

	private UIPopupIn UIPopupIn;

	private unsafe void OnEnable()
	{
		Button button = closeButton;
		bool flag = _003C_003Ec._003C_003E9__1_0 == null;
		bool flag2 = !flag;
		UnityAction call = _003C_003Ec._003C_003E9__1_0;
		if (!flag2)
		{
			UnityAction unityAction = default;
			unityAction._002Ector(_003C_003Ec._003C_003E9, (nint)__ldftn(_003C_003Ec._003COnEnable_003Eb__1_0));
			_003C_003Ec._003C_003E9__1_0 = unityAction;
			call = unityAction;
		}
		button.m_OnClick.AddListener(call);
		UnityAction unityAction2 = default;
		unityAction2._002Ector(this, (nint)__ldftn(PrizeMBPopup._003COnEnable_003Eb__1_1));
		OutConplete.AddListener(unityAction2);
	}

	public override void Init()
	{
		//IL_0005: Expected I, but got Obj
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3 @ S1_v2 (Il2CppClass<PrizeMBPopup>)+104] (should have been resolved before IL gen)");
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: true);
	}

	public override void Show()
	{
		base.Show();
		ShowPopUp();
	}

	public override void Hide()
	{
		base.Hide();
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

	private void _003COnEnable_003Eb__1_1()
	{
		//IL_0005: Expected I, but got Obj
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		nint num = (nint)this;
		object obj = this + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3 @ S1_v2 (Il2CppClass<PrizeMBPopup>)+EC] (should have been resolved before IL gen)");
	}
}
