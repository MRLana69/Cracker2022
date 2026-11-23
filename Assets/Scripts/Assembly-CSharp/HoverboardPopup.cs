using System;
using Cpp2ILInjected;
using TMPro;
using UI.Screens;
using UnityEngine.Events;
using UnityEngine.UI;

public class HoverboardPopup : UIScreen
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static UnityAction _003C_003E9__4_0;

		public static UnityAction _003C_003E9__4_1;

		static _003C_003Ec()
		{
			_003C_003Ec obj = default;
			_003C_003E9 = obj;
		}

		internal void _003CAwake_003Eb__4_0()
		{
			UIScreenController instance = UIScreenController.Instance;
			instance.CloseActivePopups("HoverboardPopup");
		}

		internal void _003CAwake_003Eb__4_1()
		{
			UIScreenController instance = UIScreenController.Instance;
			instance.CloseActivePopups("HoverboardPopup");
		}
	}

	private TMP_Text amountLabel;

	private TMP_Text hoverboardDescription;

	private Button CloseButton;

	private Button BackButton;

	private UIPopupIn UIPopupIn;

	private unsafe void Awake()
	{
		//IL_00bb: Expected I, but got Obj
		TMP_Text tMP_Text = hoverboardDescription;
		string text = Strings.Get(StringID.HOVERBOARD_POPUP_DESCRIPTION_LONG);
		nint num = (nint)tMP_Text;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v23 @ S2_v3 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		Button backButton = BackButton;
		bool flag = _003C_003Ec._003C_003E9__4_0 == null;
		bool flag2 = !flag;
		UnityAction call = _003C_003Ec._003C_003E9__4_0;
		if (!flag2)
		{
			UnityAction unityAction = default;
			unityAction._002Ector(_003C_003Ec._003C_003E9, (nint)__ldftn(_003C_003Ec._003CAwake_003Eb__4_0));
			_003C_003Ec._003C_003E9__4_0 = unityAction;
			call = unityAction;
		}
		backButton.m_OnClick.AddListener(call);
		Button closeButton = CloseButton;
		bool flag3 = _003C_003Ec._003C_003E9__4_1 == null;
		bool flag4 = !flag3;
		UnityAction call2 = _003C_003Ec._003C_003E9__4_1;
		if (!flag4)
		{
			UnityAction unityAction2 = default;
			unityAction2._002Ector(_003C_003Ec._003C_003E9, (nint)__ldftn(_003C_003Ec._003CAwake_003Eb__4_1));
			_003C_003Ec._003C_003E9__4_1 = unityAction2;
			call2 = unityAction2;
		}
		closeButton.m_OnClick.AddListener(call2);
		UnityAction unityAction3 = default;
		unityAction3._002Ector(this, (nint)__ldftn(HoverboardPopup._003CAwake_003Eb__4_2));
		OutConplete.AddListener(unityAction3);
	}

	public override void Init()
	{
		//IL_0005: Expected I, but got Obj
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3 @ S1_v2 (Il2CppClass<HoverboardPopup>)+104] (should have been resolved before IL gen)");
	}

	public override void Show()
	{
		base.Show();
		ShowPopUp();
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
	}

	private void _003CAwake_003Eb__4_2()
	{
		//IL_0005: Expected I, but got Obj
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		nint num = (nint)this;
		object obj = this + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3 @ S1_v2 (Il2CppClass<HoverboardPopup>)+EC] (should have been resolved before IL gen)");
	}
}
