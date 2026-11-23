using System;
using Cpp2ILInjected;
using Kiloo.Plugins.DeviceUtility;
using SYBO.Subway.Info;
using UnityEngine;

public class RatingPopup : CharacterPopup
{
	private UILabel bigLabel;

	private UILabel pleaseLabel;

	private UILabel rateButtonLabel;

	private UILabel cancelButtonLabel;

	private UILabel notAgainLabel;

	private UIToggle notAgainCheckBox;

	public override void Show()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected Obj, but got Unknown
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected Obj, but got Unknown
		//IL_004a: Expected VT, but got I
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected VT, but got Unknown
		object obj = default;
		Vector3? vector = (Vector3?)(object)(obj - 80);
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		base.Show();
		object obj2 = (Nullable)vector - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Nullable`1<UnityEngine.Vector3>)+48]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Nullable`1<UnityEngine.Vector3>)+40]");
		_ = 0;
		object obj3 = (Nullable)vector + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Nullable`1<UnityEngine.Vector3>)+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Nullable`1<UnityEngine.Vector3>)+38]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Nullable`1<UnityEngine.Vector3>)+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Nullable`1<UnityEngine.Vector3>)+30]");
		vector = (Vector3?)(object)0;
		Vector2? offsetFromAnchor = (Vector2?)(object)((Nullable)vector + 16);
		SetCharacter(Characters.CharacterType.tricky, offsetFromAnchor, vector);
		string text = Strings.Get(StringID.POPUP_RATING_BIG_LABEL);
		bigLabel.text = text;
		string text2 = Strings.Get(StringID.POPUP_RATING_PLEASE_LABEL);
		pleaseLabel.text = text2;
		string text3 = Strings.Get(StringID.POPUP_RATING_RATE_BUTTON_LABEL);
		rateButtonLabel.text = text3;
		string text4 = Strings.Get(StringID.POPUP_RATING_CANCEL_BUTTON_LABEL);
		cancelButtonLabel.text = text4;
		string text5 = Strings.Get(StringID.POPUP_RATING_NOTAGAIN_LABEL);
		notAgainLabel.text = text5;
	}

	private void OkClicked()
	{
		UIScreenController instance = UIScreenController.Instance;
		string currentPopupName = instance.GetCurrentPopupName();
		if (currentPopupName == "RatingPopup")
		{
			UIScreenController instance2 = UIScreenController.Instance;
			instance2.CloseActivePopups(screenName);
			PlayerInfo instance3 = PlayerInfo.Instance;
			if (!instance3._neverAskForRating)
			{
				instance3._dirty = true;
				instance3._neverAskForRating = true;
			}
			PlayerInfo instance4 = PlayerInfo.Instance;
			string bundleVersion = DeviceUtility.GetBundleVersion();
			instance4.lastVersionRated = bundleVersion;
		}
		RuntimePlatform platform = Application.platform;
		if (platform != RuntimePlatform.MetroPlayerARM)
		{
			string ratingURL = Globals.RatingURL;
			Application.OpenURL(ratingURL);
		}
	}

	private void CancelClicked()
	{
		//IL_006e: Expected Obj, but got I4
		//IL_008a: Expected Obj, but got I4
		//IL_00c2: Expected Obj, but got I4
		//IL_00aa: Expected I4, but got Obj
		//IL_00de: Expected Obj, but got I4
		UIScreenController instance = UIScreenController.Instance;
		string currentPopupName = instance.GetCurrentPopupName();
		if (!(currentPopupName == "RatingPopup"))
		{
			return;
		}
		UIScreenController instance2 = UIScreenController.Instance;
		instance2.CloseActivePopups(screenName);
		PlayerInfo instance3 = PlayerInfo.Instance;
		UIToggle uIToggle = notAgainCheckBox;
		object obj = 57;
		if (!uIToggle.mStarted)
		{
			obj = 28;
		}
		object obj2 = obj + (object)uIToggle;
		if ((instance3._neverAskForRating ? 1 : 0) != (nint)obj2)
		{
			instance3._dirty = true;
			instance3._neverAskForRating = (byte)(int)obj2 != 0;
		}
		object obj4;
		do
		{
			PlayerInfo instance4 = PlayerInfo.Instance;
			string bundleVersion = DeviceUtility.GetBundleVersion();
			instance4.lastVersionRated = bundleVersion;
			UIToggle uIToggle2 = notAgainCheckBox;
			object obj3 = 57;
			if (!uIToggle2.mStarted)
			{
				obj3 = 28;
			}
			obj4 = obj3 + (object)uIToggle2;
		}
		while (obj4 == null);
	}
}
