using Cpp2ILInjected;
using UI.Screens;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace UI.Popups;

public class HomeConfirmationPopup : UIScreen
{
	private Button YesButton;

	private Button NoButton;

	private UIPopupIn UIPopupIn;

	public unsafe override void Init()
	{
		//IL_0065: Expected I, but got Obj
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v13 @ S1_v3 (Il2CppClass<UI.Popups.HomeConfirmationPopup>)+104] (should have been resolved before IL gen)");
		Button yesButton = YesButton;
		UnityAction unityAction = default;
		unityAction._002Ector(this, (nint)__ldftn(HomeConfirmationPopup._003CInit_003Eb__2_0));
		yesButton.m_OnClick.AddListener(unityAction);
		Button noButton = NoButton;
		UnityAction unityAction2 = default;
		unityAction2._002Ector(this, (nint)__ldftn(HomeConfirmationPopup._003CInit_003Eb__2_1));
		noButton.m_OnClick.AddListener(unityAction2);
		UnityAction unityAction3 = default;
		unityAction3._002Ector(this, (nint)__ldftn(HomeConfirmationPopup._003CInit_003Eb__2_2));
		OutConplete.AddListener(unityAction3);
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

	private void NoClicked()
	{
		UIScreenController instance = UIScreenController.Instance;
		instance.CloseActivePopups("HomeConfirmationPopup");
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			((HomeConfirmationPopup)null).NoClicked();
		}
	}

	private void _003CInit_003Eb__2_0()
	{
		UIScreenController instance = UIScreenController.Instance;
		GameObject sender = gameObject;
		instance.GoToMainMenuFromGame(sender);
		UIScreenController instance2 = UIScreenController.Instance;
		instance2.CloseActivePopups("PauseUI");
		UIScreenController instance3 = UIScreenController.Instance;
		instance3.CloseActivePopups("HomeConfirmationPopup");
	}

	private void _003CInit_003Eb__2_1()
	{
		((HomeConfirmationPopup)null).NoClicked();
	}

	private void _003CInit_003Eb__2_2()
	{
		//IL_0005: Expected I, but got Obj
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		nint num = (nint)this;
		object obj = this + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3 @ S1_v2 (Il2CppClass<UI.Popups.HomeConfirmationPopup>)+EC] (should have been resolved before IL gen)");
	}
}
