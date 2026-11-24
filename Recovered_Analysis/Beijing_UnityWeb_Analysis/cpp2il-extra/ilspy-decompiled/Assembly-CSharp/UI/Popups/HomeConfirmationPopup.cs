using System;
using System.Collections;
using Cpp2ILInjected;
using Data.Save;
using UI.Generic;
using UI.Screens;
using UI.Screens.RewardManagement;
using UnityEngine;

namespace UI.Popups;

public class HomeConfirmationPopup : UIScreen
{
	private UILabel _title;

	private UILabel _description;

	private UILabel _subDescription;

	private UILabel _noLabel;

	private UILabel _yesLabel;

	public override void Init()
	{
		//IL_0026: Expected Obj, but got I
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		MonoBehaviour.print(this);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Popups.HomeConfirmationPopup)+3C]");
		GameObject gameObject = ((Component)0).gameObject;
		object obj = this + 148;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S2_v4+8]");
		_ = 0;
		Transform transform = (Transform)(obj2 + 12);
		transform = (Transform)obj2;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		((Transform)(object)gameObject).parent = transform;
		IEnumerator routine = ((UIScaleAnimation)(object)this).WaitForSecondsAndRestart(0f);
		Coroutine coroutine = StartCoroutine_Auto(routine);
		((ConsumablesPopup)this).OnShowVideoFailure((string)null);
	}

	public void YesClicked()
	{
		//IL_00dc: Expected I, but got Obj
		//IL_00f2: Expected Obj, but got I
		//IL_012c: Expected I4, but got Obj
		//IL_0061: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0083: Expected I4, but got Obj
		//IL_00a5: Expected I4, but got Obj
		//IL_00c7: Expected I4, but got Obj
		ShowIfInactive();
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S1_v4 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v23 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault("HOME_CONFIRMATION_POPUP_TITLE");
		_title.fontSize = (int)text;
		string text2 = Strings.GetDefault("HOME_CONFIRMATION_POPUP_DESCRIPTION");
		_description.fontSize = (int)text2;
		string text3 = Strings.GetDefault("HOME_CONFIRMATION_POPUP_DESCRIPTION_SUB");
		_subDescription.fontSize = (int)text3;
		string text4 = Strings.GetDefault("HOME_CONFIRMATION_POPUP_NO");
		_noLabel.fontSize = (int)text4;
		string text5 = Strings.GetDefault("HOME_CONFIRMATION_POPUP_YES");
		_yesLabel.fontSize = (int)text5;
	}

	public void NoClicked()
	{
		//IL_0082: Expected I, but got Obj
		//IL_0098: Expected Obj, but got I
		//IL_00cc: Expected Obj, but got I4
		//IL_0069: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		PlayerSave.ResetSkipMissions();
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v15 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag).ClosePopup((GameObject)(object)"HomeConfirmationPopup");
		bool flag2 = UIScreenController.ShouldShowOnlineScreen();
		string reward = tag;
		((UIScreenController)flag2).PayoutCelebrationReward((CelebrationReward)(object)reward);
	}

	private void Update()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00aa: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag).ClosePopup((GameObject)(object)"HomeConfirmationPopup");
	}

	public HomeConfirmationPopup()
	{
		//IL_000a: Expected Obj, but got I4
		if (Input.GetKeyDown((string)27))
		{
			((HomeConfirmationPopup)null).Update();
		}
	}
}
