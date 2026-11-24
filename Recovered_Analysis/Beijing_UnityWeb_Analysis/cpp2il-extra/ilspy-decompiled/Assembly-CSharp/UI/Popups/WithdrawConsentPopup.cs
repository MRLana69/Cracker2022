using Cpp2ILInjected;
using Info;
using UI.Popups.SettingsPopupInternal;
using UI.Screens;
using UnityEngine;

namespace UI.Popups;

public class WithdrawConsentPopup : UIScreen
{
	private UILabel _header;

	private UILabel _bodyText;

	private UILabel _requirement;

	private UILabel _verification;

	private UILabel _okLabel;

	private UILabel _cancelLabel;

	public override void Init()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72D5");
	}

	public void WithdrawClicked()
	{
		//IL_00fe: Expected I, but got Obj
		//IL_0114: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		ShowIfInactive();
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S1_v4 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v26 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool fontSize = Strings.IsMapped("WithdrawConsentTitle");
		_header.fontSize = (fontSize ? 1 : 0);
		bool fontSize2 = Strings.IsMapped("WithdrawConsentBody");
		_bodyText.fontSize = (fontSize2 ? 1 : 0);
		bool fontSize3 = Strings.IsMapped("WithdrawConsentRequirement");
		_requirement.fontSize = (fontSize3 ? 1 : 0);
		bool fontSize4 = Strings.IsMapped("WithdrawConsentVerification");
		_verification.fontSize = (fontSize4 ? 1 : 0);
		bool fontSize5 = Strings.IsMapped("WithdrawConsentYes");
		_okLabel.fontSize = (fontSize5 ? 1 : 0);
		bool fontSize6 = Strings.IsMapped("WithdrawConsentNo");
		_cancelLabel.fontSize = (fontSize6 ? 1 : 0);
	}

	public void OnClose()
	{
		//IL_0277: Expected I, but got Obj
		//IL_028d: Expected Obj, but got I
		//IL_035c: Expected I, but got Obj
		//IL_0372: Expected Obj, but got I
		//IL_02cb: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_00b6: Expected Obj, but got I4
		//IL_0060: Expected I, but got Obj
		//IL_00cd: Expected I, but got Obj
		//IL_00e3: Expected Obj, but got I
		//IL_01e9: Expected I, but got Obj
		//IL_01ff: Expected Obj, but got I
		//IL_010e: Expected I, but got Obj
		//IL_0338: Expected Obj, but got I4
		//IL_015b: Expected I, but got Obj
		//IL_0171: Expected Obj, but got I
		//IL_022a: Expected I, but got Obj
		//IL_031c: Expected Obj, but got I4
		//IL_019c: Expected I, but got Obj
		nint num = (nint)typeof(AgeRestriction);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.AgeRestriction>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AgeRestriction);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v54 (Il2CppClass<Info.AgeRestriction>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @89B1");
		((SettingsButton)null).InitButton((SettingsButton.SettingsButtonPayload)(object)"Yes");
		nint num3 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v13 (Il2CppClass<UIScreenController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v50 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		_ = 1;
		bool flag2 = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag2).DebugCloseAllPopups();
		bool flag3 = UIScreenController.ShouldShowOnlineScreen();
		UIScreen uIScreen = ((UIScreenController)flag3)._ActivateScreen("SettingsPopup");
		nint num5 = (nint)typeof(Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S1_v24 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)uIScreen).FindKernel((string)null) != 0)
		{
			nint num7 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v38 (Il2CppClass<UIScreenController>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num8 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v46 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag4 = UIScreenController.ShouldShowOnlineScreen();
			_ = 1;
			bool flag5 = UIScreenController.ShouldShowOnlineScreen();
			((UIScreenController)flag5).DebugCloseAllPopups();
		}
		nint num9 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v27 (Il2CppClass<UIScreenController>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num10 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v33 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag6 = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag6).QueuePopup("ConsentPopup");
	}

	public void OnNoClicked()
	{
		//IL_006b: Expected I, but got Obj
		//IL_0081: Expected Obj, but got I
		//IL_00b0: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		((SettingsButton)null).InitButton((SettingsButton.SettingsButtonPayload)(object)"Cancel");
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v7 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v13 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag).DebugCloseAllPopups();
	}

	private void LogWithdraw(string result)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 116;
		obj = result;
		((SecretPopup)this).DisplayList1();
	}

	public WithdrawConsentPopup()
	{
		//IL_006b: Expected I, but got Obj
		//IL_0081: Expected Obj, but got I
		//IL_00b0: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		((SettingsButton)null).InitButton((SettingsButton.SettingsButtonPayload)(object)"No");
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v7 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v13 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag).DebugCloseAllPopups();
	}
}
