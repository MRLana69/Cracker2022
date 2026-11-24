using Cpp2ILInjected;
using Kiloo.Common.Timer;
using SYBO.Components.Utilities;
using UI.Screens;
using UnityEngine;

namespace UI.Popups;

public class QuitApplicationPopup : UIScreen
{
	private UILabel _title;

	private UILabel _description;

	private UILabel _subDescription;

	private UILabel _yesLabel;

	private UILabel _noLabel;

	public override void Init()
	{
		((UpgradeScreen)this).Start();
	}

	public void NoClicked()
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
		string text = Strings.GetDefault("QUIT_APPLICATION_POPUP_TITLE");
		_title.fontSize = (int)text;
		string text2 = Strings.GetDefault("QUIT_APPLICATION_POPUP_DESCRIPTION");
		_description.fontSize = (int)text2;
		string text3 = Strings.GetDefault("QUIT_APPLICATION_POPUP_DESCRIPTION_SUB");
		_subDescription.fontSize = (int)text3;
		string text4 = Strings.GetDefault("QUIT_APPLICATION_POPUP_NO");
		_noLabel.fontSize = (int)text4;
		string text5 = Strings.GetDefault("QUIT_APPLICATION_POPUP_YES");
		_yesLabel.fontSize = (int)text5;
	}

	public void YesClicked()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00ab: Expected Obj, but got I4
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
		((UIScreenController)flag).ClosePopup((GameObject)(object)screenName);
	}

	private void Update()
	{
		//IL_00a1: Expected VT, but got Obj
		//IL_00aa: Expected Obj, but got VT
		//IL_00b8: Expected I, but got Obj
		//IL_00ce: Expected Obj, but got I
		//IL_0112: Expected Obj, but got I4
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected Obj, but got Unknown
		//IL_0089: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
		((AudioStateLoop)val).OnSfxSettingChanged();
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v9 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v24 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		_ = 1;
		bool flag2 = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag2).ClosePopup((GameObject)(object)screenName);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		string text = default;
		text.m_stringLength = (int)num3;
		_ = 0;
		object obj2 = text + 16;
		obj2 = 0;
		Timer.Log(text);
	}

	public QuitApplicationPopup()
	{
		//IL_000a: Expected Obj, but got I4
		if (Input.GetKeyDown((string)27))
		{
			YesClicked();
		}
	}
}
