using System;
using Cpp2ILInjected;
using Kiloo.Common.Timer;
using UI.Screens;
using UnityEngine;

namespace UI.Popups;

public class PrivacyPolicyPopUp : UIScreen
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__7_0;

		static _003C_003Ec()
		{
			_003C_003Ec obj = default;
			_003C_003E9 = obj;
		}

		internal void _003CYesClicked_003Eb__7_0()
		{
			Application.OpenURL("http://www.kiloo.com/privacy/");
		}
	}

	private UILabel _title;

	private UILabel _description;

	private UILabel _subDescription;

	private UILabel _yesLabel;

	private UILabel _noLabel;

	public override void Init()
	{
		//IL_0093: Expected I, but got Obj
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v13 @ S1_v3 (Il2CppClass<UI.Popups.PrivacyPolicyPopUp>)+104] (should have been resolved before IL gen)");
		string text = Strings.Get(StringID.PRIVACY_POLICY_POPUP_TITLE);
		_title.text = text;
		string text2 = Strings.Get(StringID.PRIVACY_POLICY_POPUP_DESCRIPTION);
		_description.text = text2;
		string text3 = Strings.Get(StringID.PRIVACY_POLICY_POPUP_DESCRIPTION_SUB);
		_subDescription.text = text3;
		string text4 = Strings.Get(StringID.PRIVACY_POLICY_POPUP_NO);
		_noLabel.text = text4;
		string text5 = Strings.Get(StringID.PRIVACY_POLICY_POPUP_YES);
		_yesLabel.text = text5;
	}

	public void NoClicked()
	{
		GameObject gameObject = base.gameObject;
		string goName = gameObject.name;
		string flurryPopUpWithOkAndCloseName = UIScreens.GetFlurryPopUpWithOkAndCloseName(goName);
		Flurry.LogClosePressedOnPopup(flurryPopUpWithOkAndCloseName);
		UIScreenController instance = UIScreenController.Instance;
		instance.CloseActivePopups(screenName);
	}

	public unsafe void YesClicked()
	{
		GameObject gameObject = base.gameObject;
		string goName = gameObject.name;
		string flurryPopUpWithOkAndCloseName = UIScreens.GetFlurryPopUpWithOkAndCloseName(goName);
		Flurry.LogOkPressedOnPopup(flurryPopUpWithOkAndCloseName);
		bool flag = _003C_003Ec._003C_003E9__7_0 == null;
		bool flag2 = !flag;
		Action action = _003C_003Ec._003C_003E9__7_0;
		if (!flag2)
		{
			Action action2 = default;
			action2._002Ector(_003C_003Ec._003C_003E9, (nint)__ldftn(_003C_003Ec._003CYesClicked_003Eb__7_0));
			_003C_003Ec._003C_003E9__7_0 = action2;
			action = action2;
		}
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
