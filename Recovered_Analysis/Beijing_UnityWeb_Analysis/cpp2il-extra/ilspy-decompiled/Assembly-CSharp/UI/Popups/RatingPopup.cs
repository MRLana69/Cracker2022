using Cpp2ILInjected;
using Data.Save;
using Kiloo.Common.Plugins.DeviceUtility;
using UI.FreeStuff;
using UI.Generic.Layout;
using UI.Screens;
using UnityEngine;

namespace UI.Popups;

public class RatingPopup : CharacterPopup
{
	private UILabel bigLabel;

	private UILabel pleaseLabel;

	private UILabel rateButtonLabel;

	private UILabel cancelButtonLabel;

	private UILabel notAgainLabel;

	private UIToggle notAgainCheckBox;

	private Layout _checkMarkLayout;

	public override void Show()
	{
		((UpgradeScreen)(object)this).Start();
	}

	public void OkClicked()
	{
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected Obj, but got Unknown
		//IL_018a: Expected Obj, but got I4
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected Obj, but got Unknown
		//IL_01a7: Expected Obj, but got I4
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_0063: Expected I, but got Obj
		//IL_0079: Expected Obj, but got I
		//IL_01fe: Expected I4, but got Obj
		//IL_00f2: Expected I4, but got Obj
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected Obj, but got Unknown
		//IL_00a4: Expected I, but got Obj
		//IL_011d: Expected I4, but got Obj
		//IL_013f: Expected I4, but got Obj
		//IL_0161: Expected I4, but got Obj
		object obj2 = default;
		object obj = obj2 + 32;
		obj = 0;
		_ = 0;
		object obj3 = obj2 + 16;
		obj3 = 0;
		_ = 0;
		((UIScreen)this).Hide();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		object obj4 = obj2 + 44;
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj5 = obj2 + 56;
		obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8B9F");
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S1_v28 (Il2CppClass<Strings>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S1_v49 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault("POPUP_RATING_BIG_LABEL");
		bigLabel.fontSize = (int)text;
		string text2 = Strings.GetDefault("POPUP_RATING_PLEASE_LABEL");
		pleaseLabel.fontSize = (int)text2;
		object obj7 = this - -64;
		string text3 = Strings.GetDefault("POPUP_RATING_RATE_BUTTON_LABEL");
		((UILabel)obj7).fontSize = (int)text3;
		string text4 = Strings.GetDefault("POPUP_RATING_CANCEL_BUTTON_LABEL");
		cancelButtonLabel.fontSize = (int)text4;
		string text5 = Strings.GetDefault("POPUP_RATING_NOTAGAIN_LABEL");
		notAgainLabel.fontSize = (int)text5;
		((RewardForVideoButton)(object)_checkMarkLayout).Init((VideoButtonPayload)null);
	}

	public void CancelClicked()
	{
		//IL_027c: Expected I, but got Obj
		//IL_0292: Expected Obj, but got I
		//IL_03be: Expected Obj, but got I4
		//IL_03d0: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_02bd: Expected I, but got Obj
		//IL_02d3: Expected Obj, but got I
		//IL_03eb: Expected I4, but got Obj
		//IL_0079: Expected I, but got Obj
		//IL_008f: Expected Obj, but got I
		//IL_022f: Expected I, but got Obj
		//IL_0308: Expected Obj, but got I4
		//IL_0312: Expected Obj, but got I4
		//IL_0107: Expected I, but got Obj
		//IL_011d: Expected Obj, but got I
		//IL_00ba: Expected I, but got Obj
		//IL_032e: Expected I, but got Obj
		//IL_0344: Expected Obj, but got I
		//IL_0379: Expected I, but got Obj
		//IL_038f: Expected Obj, but got I
		//IL_0148: Expected I, but got Obj
		//IL_0195: Expected I, but got Obj
		//IL_01e2: Expected I, but got Obj
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v57 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		bool isShowingPopup = ((UIScreenController)flag).isShowingPopup;
		if ((string)isShowingPopup != "RatingPopup")
		{
			nint num3 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v27 (Il2CppClass<UIScreenController>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v53 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag2 = UIScreenController.ShouldShowOnlineScreen();
			((UIScreenController)flag2).ClosePopup((GameObject)(object)screenName);
			PreferencesSave.language = (string)1;
			nint num5 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v35 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(DeviceUtility);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v49 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string bundleIdentifier = DeviceUtility.GetBundleIdentifier();
			nint num7 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S1_v15 (Il2CppClass<Data.Save.UserSave>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num8 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S1_v21 (Il2CppClass<Data.Save.UserSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9373");
			nint num9 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v42 (Il2CppClass<Flurry>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num10 = (nint)typeof(Flurry);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v45 (Il2CppClass<Flurry>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
		}
		nint num11 = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v16 (Il2CppClass<Globals>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num12 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v22 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string appStoreURL = Globals.AppStoreURL;
		Application.targetFrameRate = (int)appStoreURL;
	}

	public RatingPopup()
	{
		//IL_023b: Expected I, but got Obj
		//IL_0251: Expected Obj, but got I
		//IL_03c4: Expected Obj, but got I4
		//IL_03d6: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0079: Expected I, but got Obj
		//IL_008f: Expected Obj, but got I
		//IL_0287: Expected Obj, but got I4
		//IL_013c: Expected Obj, but got I4
		//IL_00ba: Expected I, but got Obj
		//IL_02c4: Expected I, but got Obj
		//IL_02da: Expected Obj, but got I
		//IL_0118: Expected Obj, but got I4
		//IL_030e: Expected I, but got Obj
		//IL_0324: Expected Obj, but got I
		//IL_014f: Expected I, but got Obj
		//IL_037f: Expected I, but got Obj
		//IL_0395: Expected Obj, but got I
		//IL_019c: Expected I, but got Obj
		//IL_01ee: Expected I, but got Obj
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v65 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		bool isShowingPopup = ((UIScreenController)flag).isShowingPopup;
		if (!((string)isShowingPopup != "RatingPopup"))
		{
			return;
		}
		nint num3 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v16 (Il2CppClass<UIScreenController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v61 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag2 = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag2).ClosePopup((GameObject)(object)screenName);
		UIToggle uIToggle = notAgainCheckBox;
		string language;
		if (~(uIToggle.mStarted ? 1u : 0u) == 0)
		{
			bool mIsActive = uIToggle.mIsActive;
			language = (string)mIsActive;
		}
		else
		{
			bool startsActive = uIToggle.startsActive;
			language = (string)startsActive;
		}
		PreferencesSave.language = language;
		nint num5 = (nint)typeof(DeviceUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v27 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v51 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string bundleIdentifier = DeviceUtility.GetBundleIdentifier();
		nint num7 = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S1_v14 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num8 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S1_v23 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9373");
		UIToggle uIToggle2 = notAgainCheckBox;
		if (~(uIToggle2.mStarted ? 1u : 0u) == 0)
		{
		}
		nint num9 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S0_v38 (Il2CppClass<Flurry>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num10 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S0_v41 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
	}
}
