using System;
using Cpp2ILInjected;
using Data.Save;
using InApp;
using Info;
using Info.Localization;
using Kiloo.Common.Plugins.DeviceUtility;
using UI.FreeStuff;
using UI.Generic.Layout;
using UI.Screens;
using UnityEngine;

public class UpdateApp : CharacterPopup
{
	private static bool _isUpdateNowOnScreen;

	private static bool _hasShownThisSession;

	private UILabel title;

	private UILabel buttonLabel;

	private UILabel changeListLabel;

	private UILabel okButtonLabel;

	private Layout _buttonLayout;

	public override void Init()
	{
		//IL_000b: Expected Obj, but got I4
		screenName = (string)(-1);
		CancelInvoke();
	}

	public override void Show()
	{
		//IL_00a9: Expected I, but got Obj
		//IL_00bf: Expected Obj, but got I
		//IL_00f9: Expected I4, but got Obj
		//IL_0061: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0083: Expected I4, but got Obj
		base.Hide();
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S1_v4 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v18 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault("UPDATE_APP_POPUP_TITLE");
		title.fontSize = (int)text;
		string text2 = Strings.GetDefault("UPDATE_APP_POPUP_BUTTON");
		buttonLabel.fontSize = (int)text2;
		string text3 = Strings.GetDefault("UPDATE_APP_BUTTON_DOWNLOAD");
		okButtonLabel.fontSize = (int)text3;
		((RewardForVideoButton)(object)_buttonLayout).Init((VideoButtonPayload)null);
	}

	public void CloseClicked()
	{
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected Obj, but got Unknown
		//IL_01bc: Expected Obj, but got I4
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Expected Obj, but got Unknown
		//IL_01d9: Expected Obj, but got I4
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_0063: Expected I, but got Obj
		//IL_0079: Expected Obj, but got I
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected Obj, but got Unknown
		//IL_0124: Expected I, but got Obj
		//IL_013a: Expected Obj, but got I
		//IL_00a4: Expected I, but got Obj
		//IL_0261: Expected I4, but got Obj
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected Obj, but got Unknown
		//IL_00fb: Expected I4, but got Obj
		//IL_0165: Expected I, but got Obj
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
		nint num = (nint)typeof(OnlineSettingsManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v27 (Il2CppClass<Info.OnlineSettingsManager>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num2 = (nint)typeof(OnlineSettingsManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v44 (Il2CppClass<Info.OnlineSettingsManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Outfits instance = Outfits.instance;
		string text = InAppData.StripProductPrefixes((string)(object)instance);
		if (text != null)
		{
			object obj7 = this - -64;
			((UILabel)obj7).fontSize = (int)text;
			return;
		}
		SDebug.LogFormat("Showing NewVersion popup, but no changeList found in OnlineSettings", (object[])(object)this);
		object obj8 = this - -64;
		nint num3 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S1_v33 (Il2CppClass<Strings>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num4 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S1_v40 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text2 = Strings.GetDefault("UPDATE_APP_POPUP_CHANGELOG_DEFAULT");
		((UILabel)obj8).fontSize = (int)text2;
	}

	public void OkClicked()
	{
		//IL_0147: Expected I, but got Obj
		//IL_015d: Expected Obj, but got I
		//IL_024c: Expected Obj, but got I4
		//IL_025a: Expected I, but got Obj
		//IL_0270: Expected Obj, but got I
		//IL_01a9: Expected I, but got Obj
		//IL_01bf: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_01e5: Expected I4, but got Obj
		//IL_01f7: Expected I, but got Obj
		//IL_020d: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_0233: Expected Obj, but got I4
		//IL_00ad: Expected I, but got Obj
		//IL_00fa: Expected I, but got Obj
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v29 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag).ClosePopup((GameObject)(object)screenName);
		nint num3 = (nint)typeof(UpdateApp);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v13 (Il2CppClass<UpdateApp>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UpdateApp);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v23 (Il2CppClass<UpdateApp>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_isUpdateNowOnScreen = false;
		string original = tag;
		UnityEngine.Object obj3 = UnityEngine.Object.Instantiate((UnityEngine.Object)(object)original);
		nint num5 = (nint)typeof(UIScreens);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S1_v10 (Il2CppClass<UIScreens>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num6 = (nint)typeof(UIScreens);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S1_v25 (Il2CppClass<UIScreens>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num7 = Utility.NumberOfDigits((int)obj3);
		nint num8 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S1_v16 (Il2CppClass<Flurry>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num9 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S1_v21 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Flurry.StartSession((string)num7);
	}

	public static void AllowAgainThisSession()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		throw new ArrayTypeMismatchException();
	}

	public override void GainFocus()
	{
		//IL_0194: Expected I, but got Obj
		//IL_01aa: Expected Obj, but got I
		//IL_02fa: Expected I, but got Obj
		//IL_0310: Expected Obj, but got I
		//IL_01df: Expected Obj, but got I4
		//IL_01ed: Expected I, but got Obj
		//IL_0203: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_024f: Expected I, but got Obj
		//IL_0265: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_028b: Expected I4, but got Obj
		//IL_029d: Expected I, but got Obj
		//IL_02b3: Expected Obj, but got I
		//IL_00ad: Expected I, but got Obj
		//IL_02d9: Expected Obj, but got I4
		//IL_00fa: Expected I, but got Obj
		//IL_0147: Expected I, but got Obj
		nint num = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Globals>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v40 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Globals.LogInState loginState = Globals.GetLoginState();
		Application.targetFrameRate = (int)loginState;
		nint num3 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v13 (Il2CppClass<UIScreenController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v36 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag).ClosePopup((GameObject)(object)screenName);
		nint num5 = (nint)typeof(UpdateApp);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v20 (Il2CppClass<UpdateApp>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(UpdateApp);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v30 (Il2CppClass<UpdateApp>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_isUpdateNowOnScreen = false;
		string original = tag;
		UnityEngine.Object obj4 = UnityEngine.Object.Instantiate((UnityEngine.Object)(object)original);
		nint num7 = (nint)typeof(UIScreens);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S1_v12 (Il2CppClass<UIScreens>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num8 = (nint)typeof(UIScreens);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S1_v27 (Il2CppClass<UIScreens>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num9 = Utility.NumberOfDigits((int)obj4);
		nint num10 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S1_v18 (Il2CppClass<Flurry>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num11 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S1_v23 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Flurry.LogClosePressedOnPopup((string)num9);
	}

	public override void LoseFocus()
	{
		base.OnDisable();
	}

	public static void ShowIfNeeded()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UpdateApp);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UpdateApp>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UpdateApp);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<UpdateApp>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_hasShownThisSession = false;
	}

	public UpdateApp()
	{
		ShowCharacter();
	}

	static UpdateApp()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_08e6: Expected I, but got Obj
		//IL_08fc: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_092b: Expected Obj, but got I4
		//IL_093d: Expected I4, but got Obj
		//IL_093d: Expected Obj, but got I4
		//IL_00af: Expected I, but got Obj
		//IL_0119: Expected I, but got Obj
		//IL_012f: Expected Obj, but got I
		//IL_015a: Expected I, but got Obj
		//IL_01f7: Expected I, but got Obj
		//IL_020d: Expected Obj, but got I
		//IL_0238: Expected I, but got Obj
		//IL_0285: Expected I, but got Obj
		//IL_029b: Expected Obj, but got I
		//IL_0552: Expected Obj, but got I4
		//IL_02c6: Expected I, but got Obj
		//IL_0a2e: Expected I, but got Obj
		//IL_0a44: Expected Obj, but got I
		//IL_0313: Expected I, but got Obj
		//IL_0329: Expected Obj, but got I
		//IL_0a16: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1b: Expected Obj, but got Unknown
		//IL_0565: Expected I, but got Obj
		//IL_0354: Expected I, but got Obj
		//IL_077b: Expected I, but got Obj
		//IL_0791: Expected Obj, but got I
		//IL_07bc: Expected I, but got Obj
		//IL_0809: Expected I, but got Obj
		//IL_081f: Expected Obj, but got I
		//IL_0aeb: Expected Obj, but got I4
		//IL_0af9: Expected I, but got Obj
		//IL_0b0f: Expected Obj, but got I
		//IL_084a: Expected I, but got Obj
		//IL_087d: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		nint num = (nint)typeof(UpdateApp);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v14 (Il2CppClass<UpdateApp>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(UpdateApp);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v270 (Il2CppClass<UpdateApp>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(_isUpdateNowOnScreen ? 1u : 0u) == 0)
		{
			return;
		}
		nint num3 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v25 (Il2CppClass<UIScreenController>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S0_v266 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		bool isShowingPopup = ((UIScreenController)flag).isShowingPopup;
		if (((string)isShowingPopup).get_Chars((int)"EventsPopup") == '\0')
		{
			return;
		}
		nint num5 = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S0_v34 (Il2CppClass<Globals>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num6 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S0_v262 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag2;
		if (Globals.GetLoginState() != Globals.LogInState.Offline)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ S0_v39 (Globals+LogInState)+8]");
			flag2 = (nint)0 == 0;
		}
		else
		{
			flag2 = true;
		}
		if (flag2 || OnboardingSave.numberOfRunsSinceLastGuideline == 0)
		{
			return;
		}
		nint num7 = (nint)typeof(OnlineSettingsManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S0_v45 (Il2CppClass<Info.OnlineSettingsManager>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num8 = (nint)typeof(OnlineSettingsManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ S0_v254 (Il2CppClass<Info.OnlineSettingsManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		LocalizedOnlineSettings localizedData = OnlineSettingsManager.localizedData;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ S0_v50 (Info.Localization.LocalizedOnlineSettings)+4C]");
		if ((nint)0 == 0)
		{
			return;
		}
		nint num9 = (nint)typeof(OnlineSettingsManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ S0_v53 (Il2CppClass<Info.OnlineSettingsManager>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num10 = (nint)typeof(OnlineSettingsManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ S0_v250 (Il2CppClass<Info.OnlineSettingsManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		LocalizedOnlineSettings localizedData2 = OnlineSettingsManager.localizedData;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ S0_v58 (Info.Localization.LocalizedOnlineSettings)+48]");
		object obj11;
		if ((nint)0 != 0)
		{
			nint num11 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ S0_v182 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num12 = (nint)typeof(DeviceUtility);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ S0_v246 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string oSIdentifier = DeviceUtility.GetOSIdentifier();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			object obj10 = default;
			object obj9 = obj10 >> 31;
			obj11 = obj9 ^ 1;
		}
		else
		{
			obj11 = 1;
		}
		nint num13 = (nint)typeof(DeviceUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ S0_v62 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num14 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ S0_v171 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string bundleIdentifier = DeviceUtility.GetBundleIdentifier();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
		object obj14 = default;
		object obj13 = obj14 >> 31;
		object obj15 = obj13 & obj11;
		if (obj15 == null)
		{
			return;
		}
		nint num15 = (nint)typeof(UpdateApp);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ S0_v79 (Il2CppClass<UpdateApp>)+BA]");
		object obj16 = (nint)0 & (nint)0x200;
		if (obj16 != null)
		{
			nint num16 = (nint)typeof(UpdateApp);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ S0_v111 (Il2CppClass<UpdateApp>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_hasShownThisSession)
		{
			return;
		}
		nint num17 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ S0_v87 (Il2CppClass<UIScreenController>)+BA]");
		object obj17 = (nint)0 & (nint)0x200;
		if (obj17 != null)
		{
			nint num18 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ S0_v108 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag3 = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag3)._ActivateNextPopup("UpdateAppPopup");
		nint num19 = (nint)typeof(UpdateApp);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ S0_v94 (Il2CppClass<UpdateApp>)+BA]");
		object obj18 = (nint)0 & (nint)0x200;
		if (obj18 != null)
		{
			nint num20 = (nint)typeof(UpdateApp);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ S0_v103 (Il2CppClass<UpdateApp>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_isUpdateNowOnScreen = true;
		_hasShownThisSession = true;
	}
}
