using System;
using Cpp2ILInjected;
using Kiloo.Common.Timer;
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

	private static Action _003C_003Ef__mg_0024cache0;

	public override void Init()
	{
		//IL_0093: Expected I, but got Obj
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v13 @ S1_v3 (Il2CppClass<UI.Popups.QuitApplicationPopup>)+104] (should have been resolved before IL gen)");
		string text = Strings.Get(StringID.QUIT_APPLICATION_POPUP_TITLE);
		_title.text = text;
		string text2 = Strings.Get(StringID.QUIT_APPLICATION_POPUP_DESCRIPTION);
		_description.text = text2;
		string text3 = Strings.Get(StringID.QUIT_APPLICATION_POPUP_DESCRIPTION_SUB);
		_subDescription.text = text3;
		string text4 = Strings.Get(StringID.QUIT_APPLICATION_POPUP_NO);
		_noLabel.text = text4;
		string text5 = Strings.Get(StringID.QUIT_APPLICATION_POPUP_YES);
		_yesLabel.text = text5;
	}

	public void NoClicked()
	{
		UIScreenController instance = UIScreenController.Instance;
		instance.CloseActivePopups(screenName);
	}

	public unsafe void YesClicked()
	{
		Action action = default;
		action._002Ector(null, (nint)(delegate*<void>)(&Application.Quit));
		Timer.ExecuteNextFrame(action);
		UIScreenController instance = UIScreenController.Instance;
		instance.CloseActivePopups(screenName);
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			NoClicked();
		}
	}
}
