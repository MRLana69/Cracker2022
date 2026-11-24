using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Data.Save;
using Info;
using Kiloo.Common.Extensions;
using Kiloo.Common.Plugins.DeviceUtility;
using SYBO.Subway;
using SYBO.Subway.Promotion;
using SYBO.Subway.UI;
using UI.FreeStuff;
using UI.Generic.Layout;
using UI.Popups.LimitedCharacterPopupInternal;
using UI.Popups.SettingsPopupInternal;
using UnityEngine;

namespace UI.Screens;

public class SettingsPopup : UIScreen
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<GameObject> _003C_003E9__32_0;

		public static Action<UILabel> _003C_003E9__32_1;

		public static Action<UILabel> _003C_003E9__32_2;

		public static Action<GameObject> _003C_003E9__32_3;

		public static Action<UILabel> _003C_003E9__32_4;

		public static Action<UILabel> _003C_003E9__32_5;

		public static Action _003C_003E9__32_6;

		public static Action<GameObject> _003C_003E9__32_7;

		public static Action<UILabel> _003C_003E9__32_8;

		public static Action<UILabel> _003C_003E9__32_9;

		public static Action _003C_003E9__32_10;

		public static Action<GameObject> _003C_003E9__32_11;

		public static Action<UILabel> _003C_003E9__32_12;

		public static Action<UILabel> _003C_003E9__32_13;

		public static Action _003C_003E9__32_14;

		public static Action<GameObject> _003C_003E9__32_15;

		public static Action<UILabel> _003C_003E9__32_16;

		public static Action<UILabel> _003C_003E9__32_17;

		static _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			PauseScreen._003C_003Ec obj = default;
			PauseScreen._003C_003Ec._003C_003E9 = obj;
		}

		public _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		internal void _003CLoadAllButtons_003Eb__32_0(GameObject go)
		{
		}

		internal void _003CLoadAllButtons_003Eb__32_1(UILabel label)
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00aa: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(Settings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.Settings>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Settings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<Info.Settings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool topRunChallengersEnabled = PreferencesSave.topRunChallengersEnabled;
			string tag = (string)((topRunChallengersEnabled ? 1 : 0) ^ 1);
			((GameObject)(object)label).tag = tag;
		}

		internal void _003CLoadAllButtons_003Eb__32_2(UILabel desc)
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00ae: Expected I4, but got Obj
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Strings>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text = Strings.GetDefault("SETTINGS_POPUP_MUSIC");
			desc.fontSize = (int)text;
		}

		internal void _003CLoadAllButtons_003Eb__32_3(GameObject go)
		{
			//IL_00c9: Expected I, but got Obj
			//IL_00df: Expected Obj, but got I
			//IL_0147: Expected I, but got Obj
			//IL_015d: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_012f: Expected I4, but got Obj
			nint num = (nint)typeof(Settings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.Settings>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Settings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v26 (Il2CppClass<Info.Settings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool topRunChallengersEnabled = PreferencesSave.topRunChallengersEnabled;
			nint num3 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17 (Il2CppClass<Strings>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v22 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string key = ((!topRunChallengersEnabled) ? "SETTINGS_POPUP_OFF" : "SETTINGS_POPUP_ON");
			string text = Strings.GetDefault(key);
			((UILabel)(object)go).fontSize = (int)text;
		}

		internal void _003CLoadAllButtons_003Eb__32_4(UILabel label)
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00aa: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(Settings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.Settings>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Settings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<Info.Settings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool musicEnabled = PreferencesSave.musicEnabled;
			string tag = (string)((musicEnabled ? 1 : 0) ^ 1);
			((GameObject)(object)label).tag = tag;
		}

		internal void _003CLoadAllButtons_003Eb__32_5(UILabel desc)
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00ae: Expected I4, but got Obj
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Strings>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text = Strings.GetDefault("SETTINGS_POPUP_SFX");
			desc.fontSize = (int)text;
		}

		internal void _003CLoadAllButtons_003Eb__32_6()
		{
		}

		internal void _003CLoadAllButtons_003Eb__32_7(GameObject go)
		{
			//IL_00c9: Expected I, but got Obj
			//IL_00df: Expected Obj, but got I
			//IL_0147: Expected I, but got Obj
			//IL_015d: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_012f: Expected I4, but got Obj
			nint num = (nint)typeof(Settings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.Settings>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Settings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v26 (Il2CppClass<Info.Settings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool musicEnabled = PreferencesSave.musicEnabled;
			nint num3 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17 (Il2CppClass<Strings>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v22 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string key = ((!musicEnabled) ? "SETTINGS_POPUP_OFF" : "SETTINGS_POPUP_ON");
			string text = Strings.GetDefault(key);
			((UILabel)(object)go).fontSize = (int)text;
		}

		internal void _003CLoadAllButtons_003Eb__32_8(UILabel label)
		{
			((GameObject)(object)label).tag = null;
		}

		internal void _003CLoadAllButtons_003Eb__32_9(UILabel desc)
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00ae: Expected I4, but got Obj
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Strings>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text = Strings.GetDefault("SETTINGS_POPUP_LANGUAGE_TITLE");
			desc.fontSize = (int)text;
		}

		internal void _003CLoadAllButtons_003Eb__32_10()
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
			((UIScreenController)flag).QueuePopup("LanguageSelectionPopup");
		}

		internal void _003CLoadAllButtons_003Eb__32_11(GameObject go)
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00ad: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Strings>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7B5E");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v4+8]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S1_v5+1C]");
			((UILabel)(object)go).fontSize = 0;
		}

		internal void _003CLoadAllButtons_003Eb__32_12(UILabel label)
		{
			((GameObject)(object)label).tag = null;
		}

		internal void _003CLoadAllButtons_003Eb__32_13(UILabel desc)
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00ae: Expected I4, but got Obj
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Strings>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text = Strings.GetDefault("SETTINGS_POPUP_WITHDRAW_CONSENT");
			desc.fontSize = (int)text;
		}

		internal void _003CLoadAllButtons_003Eb__32_14()
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
			((UIScreenController)flag).QueuePopup("WithdrawConsentPopup");
		}

		internal void _003CLoadAllButtons_003Eb__32_15(GameObject go)
		{
			string tag = ((Component)(object)go).tag;
			((GameObject)(object)tag).tag = null;
		}

		internal void _003CLoadAllButtons_003Eb__32_16(UILabel label)
		{
			((GameObject)(object)label).tag = null;
		}

		internal void _003CLoadAllButtons_003Eb__32_17(UILabel desc)
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00ae: Expected I4, but got Obj
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Strings>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text = Strings.GetDefault("SETTINGS_POPUP_PRIVACY");
			desc.fontSize = (int)text;
		}
	}

	private Transform _fillParent;

	private UISprite _fill;

	private UISprite _outline;

	private VerticalLayout _layout;

	private UILabel _titleLabel;

	private UILabel _version;

	private UILabel _contactInfo;

	public UIScrollView _scrollView;

	private GameObject _debugButton;

	private SettingsButton _settingsButtonPrefab;

	private SettingsLogInFacebookButton _facebookLoginButtonPrefab;

	private UISprite _settingsDividerPrefab;

	public UIScrollBar scrollbar;

	private SettingsButton _topRunChallengersButton;

	private SettingsButton _facebookLogoutButton;

	private SettingsLogInFacebookButton _facebookLoginButton;

	private SettingsButton _reminderButton;

	private SettingsButton _supportButton;

	private SettingsButton _languageSelectionButton;

	private SettingsButton _withdrawConsentButton;

	private SettingsButton _onlineSaveButton;

	private List<UISprite> _extraDividers;

	private const int BACKGROUND_FILL_HEIGHT_NORMAL = 423;

	private const int POPUP_PARENT_POSITION_NORMAL = -30;

	private const int BACKGROUND_FILL_HEIGHT_TUTORIAL = 310;

	private const int POPUP_PARENT_POSITION_TUTORIAL = -90;

	private const int BACKGROUND_FILL_HEIGHT_TUTORIAL_OFFSET = 60;

	private const int POPUP_PARENT_POSITION_TUTORIAL_OFFSET = 30;

	public override void Init()
	{
		((UpgradeScreen)this).Start();
	}

	public override void GainFocus()
	{
		//IL_0222: Expected I, but got Obj
		//IL_0238: Expected Obj, but got I
		//IL_026c: Expected I4, but got Obj
		//IL_027f: Expected I4, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0181: Expected I, but got Obj
		//IL_0197: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_01c2: Expected I, but got Obj
		//IL_012f: Expected I, but got Obj
		ShowIfInactive();
		LoadAllButtons();
		nint num = (nint)typeof(DeviceUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S1_v5 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S1_v29 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string bundleIdentifier = DeviceUtility.GetBundleIdentifier();
		string text = string.ConcatArray((string[])(object)"v", (int)bundleIdentifier);
		_version.fontSize = (int)text;
		nint num3 = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v10 (Il2CppClass<Globals>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v38 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(Globals.DEBUG_POPUP ? 1u : 0u) == 0)
		{
			nint num5 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v24 (Il2CppClass<Globals>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v32 (Il2CppClass<Globals>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (~(Globals.DEBUG ? 1u : 0u) == 0)
			{
				goto IL_0201;
			}
		}
		nint num7 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S1_v19 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num8 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S1_v24 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UnityEngine.Object.DestroyImmediate(_debugButton);
		goto IL_0201;
		IL_0201:
		Show();
	}

	private void SetupBasic()
	{
		//IL_003b: Expected Obj, but got I4
		string text = _layout.tag;
		((GameObject)(object)text).tag = null;
		string text2 = _layout.tag;
		((GameObject)(object)text2).tag = (string)1;
	}

	private UISprite AddDivider()
	{
		//IL_0093: Expected I, but got Obj
		//IL_00a9: Expected Obj, but got I
		//IL_00d0: Expected Obj, but got I4
		//IL_0065: Expected Obj, but got I4
		//IL_0071: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		bool isCurrentPromotionActive = ((PromotionManager)(object)this).IsCurrentPromotionActive;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v18 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if ((UnityEngine.Object)isCurrentPromotionActive != null)
		{
			return null;
		}
		bool isActiveCheck = ((PromotionDefinition)isCurrentPromotionActive).IsActiveCheck;
		return (UISprite)isActiveCheck;
	}

	private unsafe void LoadAllButtons()
	{
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_0161: Expected I4, but got Obj
		//IL_016f: Expected I, but got Obj
		//IL_0185: Expected Obj, but got I
		//IL_00f7: Expected Obj, but got I4
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected I4, but got Unknown
		//IL_0127: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v26 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault("SETTINGS_TITLE");
		_titleLabel.fontSize = (int)text;
		nint num3 = (nint)typeof(ColorData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S1_v12 (Il2CppClass<UI.ColorData>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(ColorData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S1_v22 (Il2CppClass<UI.ColorData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
		object obj3 = (flag ? 1 : 0) + 140;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S2_v7+8]");
		_ = 0;
		UIWidget.Pivot pivot = (UIWidget.Pivot)(obj4 + 16);
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		_titleLabel.rawPivot = pivot;
	}

	public unsafe override void Show()
	{
		//IL_1323: Expected I, but got Obj
		//IL_1339: Expected Obj, but got I
		//IL_1377: Expected I4, but got Obj
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected Obj, but got Unknown
		//IL_007b: Expected Obj, but got I4
		//IL_008a: Expected Obj, but got F4
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected Obj, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected Obj, but got Unknown
		//IL_0110: Expected Obj, but got I4
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected Obj, but got Unknown
		//IL_0134: Expected I, but got Obj
		//IL_014a: Expected Obj, but got I
		//IL_1f9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fa2: Expected Obj, but got Unknown
		//IL_1fb8: Expected I, but got Obj
		//IL_1fce: Expected Obj, but got I
		//IL_0175: Expected I, but got Obj
		//IL_01c2: Expected I, but got Obj
		//IL_01d8: Expected Obj, but got I
		//IL_1ff4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ff9: Expected Obj, but got Unknown
		//IL_200f: Expected I, but got Obj
		//IL_2025: Expected Obj, but got I
		//IL_0250: Expected I, but got Obj
		//IL_13d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_13de: Expected Obj, but got Unknown
		//IL_13f5: Expected I, but got Obj
		//IL_140b: Expected Obj, but got I
		//IL_029d: Expected I, but got Obj
		//IL_02b3: Expected Obj, but got I
		//IL_0203: Expected I, but got Obj
		//IL_204b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2050: Expected Obj, but got Unknown
		//IL_2065: Expected I4, but got Obj
		//IL_2082: Expected I, but got Obj
		//IL_2098: Expected Obj, but got I
		//IL_032b: Expected I, but got Obj
		//IL_1473: Unknown result type (might be due to invalid IL or missing references)
		//IL_1478: Expected Obj, but got Unknown
		//IL_148f: Expected I, but got Obj
		//IL_14a5: Expected Obj, but got I
		//IL_1575: Expected I4, but got Obj
		//IL_0378: Expected I, but got Obj
		//IL_038e: Expected Obj, but got I
		//IL_02de: Expected I, but got Obj
		//IL_0457: Unknown result type (might be due to invalid IL or missing references)
		//IL_045c: Expected Obj, but got Unknown
		//IL_0406: Expected I, but got Obj
		//IL_150d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1512: Expected Obj, but got Unknown
		//IL_1529: Expected I, but got Obj
		//IL_153f: Expected Obj, but got I
		//IL_048b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0490: Expected Obj, but got Unknown
		//IL_0499: Expected Obj, but got I4
		//IL_04a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a7: Expected Obj, but got Unknown
		//IL_04bd: Expected I, but got Obj
		//IL_04d3: Expected Obj, but got I
		//IL_03b9: Expected I, but got Obj
		//IL_20be: Unknown result type (might be due to invalid IL or missing references)
		//IL_20c3: Expected Obj, but got Unknown
		//IL_20d9: Expected I, but got Obj
		//IL_20ef: Expected Obj, but got I
		//IL_04fe: Expected I, but got Obj
		//IL_054b: Expected I, but got Obj
		//IL_0561: Expected Obj, but got I
		//IL_2115: Unknown result type (might be due to invalid IL or missing references)
		//IL_211a: Expected Obj, but got Unknown
		//IL_2130: Expected I, but got Obj
		//IL_2146: Expected Obj, but got I
		//IL_05d9: Expected I, but got Obj
		//IL_15d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_15dc: Expected Obj, but got Unknown
		//IL_15f3: Expected I, but got Obj
		//IL_1609: Expected Obj, but got I
		//IL_0626: Expected I, but got Obj
		//IL_063c: Expected Obj, but got I
		//IL_058c: Expected I, but got Obj
		//IL_216c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2171: Expected Obj, but got Unknown
		//IL_2186: Expected I4, but got Obj
		//IL_06b4: Expected I, but got Obj
		//IL_1671: Unknown result type (might be due to invalid IL or missing references)
		//IL_1676: Expected Obj, but got Unknown
		//IL_168d: Expected I, but got Obj
		//IL_16a3: Expected Obj, but got I
		//IL_078f: Expected I, but got Obj
		//IL_07a5: Expected Obj, but got I
		//IL_0701: Expected I, but got Obj
		//IL_0717: Expected Obj, but got I
		//IL_0667: Expected I, but got Obj
		//IL_1758: Unknown result type (might be due to invalid IL or missing references)
		//IL_175d: Expected Obj, but got Unknown
		//IL_1788: Expected I4, but got Obj
		//IL_170b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1710: Expected Obj, but got Unknown
		//IL_1727: Expected I, but got Obj
		//IL_173d: Expected Obj, but got I
		//IL_0821: Unknown result type (might be due to invalid IL or missing references)
		//IL_0826: Expected Obj, but got Unknown
		//IL_0838: Expected Obj, but got I4
		//IL_0847: Expected Obj, but got F4
		//IL_0871: Unknown result type (might be due to invalid IL or missing references)
		//IL_0876: Expected Obj, but got Unknown
		//IL_0899: Expected I, but got Obj
		//IL_08af: Expected Obj, but got I
		//IL_07d0: Expected I, but got Obj
		//IL_0742: Expected I, but got Obj
		//IL_21ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_21b2: Expected Obj, but got Unknown
		//IL_21c8: Expected I, but got Obj
		//IL_21de: Expected Obj, but got I
		//IL_08da: Expected I, but got Obj
		//IL_0927: Expected I, but got Obj
		//IL_093d: Expected Obj, but got I
		//IL_2204: Unknown result type (might be due to invalid IL or missing references)
		//IL_2209: Expected Obj, but got Unknown
		//IL_221f: Expected I, but got Obj
		//IL_2235: Expected Obj, but got I
		//IL_099b: Expected I, but got Obj
		//IL_17fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_1803: Expected Obj, but got Unknown
		//IL_181a: Expected I, but got Obj
		//IL_1830: Expected Obj, but got I
		//IL_09ce: Expected I, but got Obj
		//IL_09e4: Expected Obj, but got I
		//IL_0968: Expected I, but got Obj
		//IL_225b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2260: Expected Obj, but got Unknown
		//IL_2276: Expected I, but got Obj
		//IL_228c: Expected Obj, but got I
		//IL_0a42: Expected I, but got Obj
		//IL_1898: Unknown result type (might be due to invalid IL or missing references)
		//IL_189d: Expected Obj, but got Unknown
		//IL_18b4: Expected I, but got Obj
		//IL_18ca: Expected Obj, but got I
		//IL_0a75: Expected I, but got Obj
		//IL_0a8b: Expected Obj, but got I
		//IL_0a0f: Expected I, but got Obj
		//IL_22b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_22b7: Expected Obj, but got Unknown
		//IL_22ce: Expected I4, but got Obj
		//IL_22e7: Expected Obj, but got I4
		//IL_0ae9: Expected I, but got Obj
		//IL_1932: Unknown result type (might be due to invalid IL or missing references)
		//IL_1937: Expected Obj, but got Unknown
		//IL_194e: Expected I, but got Obj
		//IL_1964: Expected Obj, but got I
		//IL_0b9f: Expected I, but got Obj
		//IL_0bb5: Expected Obj, but got I
		//IL_0b1c: Expected I, but got Obj
		//IL_0b32: Expected Obj, but got I
		//IL_0ab6: Expected I, but got Obj
		//IL_1a19: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a1e: Expected Obj, but got Unknown
		//IL_1a49: Expected I4, but got Obj
		//IL_19cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_19d1: Expected Obj, but got Unknown
		//IL_19e8: Expected I, but got Obj
		//IL_19fe: Expected Obj, but got I
		//IL_0c17: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1c: Expected Obj, but got Unknown
		//IL_0c2e: Expected Obj, but got I4
		//IL_0c3d: Expected Obj, but got F4
		//IL_0c67: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c6c: Expected Obj, but got Unknown
		//IL_0c8f: Expected I, but got Obj
		//IL_0ca5: Expected Obj, but got I
		//IL_0be0: Expected I, but got Obj
		//IL_0b5d: Expected I, but got Obj
		//IL_22f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_22fa: Expected Obj, but got Unknown
		//IL_2310: Expected I, but got Obj
		//IL_2326: Expected Obj, but got I
		//IL_0cd0: Expected I, but got Obj
		//IL_0d03: Expected I, but got Obj
		//IL_0d19: Expected Obj, but got I
		//IL_234c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2351: Expected Obj, but got Unknown
		//IL_2367: Expected I, but got Obj
		//IL_237d: Expected Obj, but got I
		//IL_0d77: Expected I, but got Obj
		//IL_1abf: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ac4: Expected Obj, but got Unknown
		//IL_1adb: Expected I, but got Obj
		//IL_1af1: Expected Obj, but got I
		//IL_0daa: Expected I, but got Obj
		//IL_0dc0: Expected Obj, but got I
		//IL_0d44: Expected I, but got Obj
		//IL_23a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_23a8: Expected Obj, but got Unknown
		//IL_23be: Expected I, but got Obj
		//IL_23d4: Expected Obj, but got I
		//IL_0e1e: Expected I, but got Obj
		//IL_1b59: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b5e: Expected Obj, but got Unknown
		//IL_1b75: Expected I, but got Obj
		//IL_1b8b: Expected Obj, but got I
		//IL_0e51: Expected I, but got Obj
		//IL_0e67: Expected Obj, but got I
		//IL_0deb: Expected I, but got Obj
		//IL_23fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_23ff: Expected Obj, but got Unknown
		//IL_2416: Expected I4, but got Obj
		//IL_2433: Expected I, but got Obj
		//IL_2449: Expected Obj, but got I
		//IL_0ec5: Expected I, but got Obj
		//IL_1bf3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bf8: Expected Obj, but got Unknown
		//IL_1c0f: Expected I, but got Obj
		//IL_1c25: Expected Obj, but got I
		//IL_1cf5: Expected I4, but got Obj
		//IL_0ef8: Expected I, but got Obj
		//IL_0f0e: Expected Obj, but got I
		//IL_0e92: Expected I, but got Obj
		//IL_0fa3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa8: Expected Obj, but got Unknown
		//IL_0fba: Expected Obj, but got I4
		//IL_0fc9: Expected Obj, but got F4
		//IL_0ff3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff8: Expected Obj, but got Unknown
		//IL_101b: Expected I, but got Obj
		//IL_1031: Expected Obj, but got I
		//IL_0f6c: Expected I, but got Obj
		//IL_1c8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c92: Expected Obj, but got Unknown
		//IL_1ca9: Expected I, but got Obj
		//IL_1cbf: Expected Obj, but got I
		//IL_0f39: Expected I, but got Obj
		//IL_246f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2474: Expected Obj, but got Unknown
		//IL_248a: Expected I, but got Obj
		//IL_24a0: Expected Obj, but got I
		//IL_24bd: Expected I, but got Obj
		//IL_105c: Expected I, but got Obj
		//IL_1dc8: Expected Obj, but got I
		//IL_108f: Expected I, but got Obj
		//IL_10a5: Expected Obj, but got I
		//IL_24d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_24d9: Expected Obj, but got Unknown
		//IL_24ef: Expected I, but got Obj
		//IL_2505: Expected Obj, but got I
		//IL_1103: Expected I, but got Obj
		//IL_1111: Expected I, but got Obj
		//IL_1d6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d70: Expected Obj, but got Unknown
		//IL_1d87: Expected I, but got Obj
		//IL_1d9d: Expected Obj, but got I
		//IL_1152: Expected I, but got Obj
		//IL_1168: Expected Obj, but got I
		//IL_10d0: Expected I, but got Obj
		//IL_252b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2530: Expected Obj, but got Unknown
		//IL_2546: Expected I, but got Obj
		//IL_255c: Expected Obj, but got I
		//IL_11c6: Expected I, but got Obj
		//IL_1e19: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e1e: Expected Obj, but got Unknown
		//IL_1e35: Expected I, but got Obj
		//IL_1e4b: Expected Obj, but got I
		//IL_113f: Expected I, but got Obj
		//IL_11f9: Expected I, but got Obj
		//IL_120f: Expected Obj, but got I
		//IL_1193: Expected I, but got Obj
		//IL_2582: Unknown result type (might be due to invalid IL or missing references)
		//IL_2587: Expected Obj, but got Unknown
		//IL_259c: Expected I4, but got Obj
		//IL_126d: Expected I, but got Obj
		//IL_1eb3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1eb8: Expected Obj, but got Unknown
		//IL_1ecf: Expected I, but got Obj
		//IL_1ee5: Expected Obj, but got I
		//IL_12a0: Expected I, but got Obj
		//IL_12b6: Expected Obj, but got I
		//IL_123a: Expected I, but got Obj
		//IL_1f4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f52: Expected Obj, but got Unknown
		//IL_1f69: Expected I, but got Obj
		//IL_1f7f: Expected Obj, but got I
		//IL_12e1: Expected I, but got Obj
		GameObject parent = _layout.gameObject;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S2_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S2_v187 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SettingsButton settingsButton = UnityEngine.Object.Instantiate(_settingsButtonPrefab, (Transform)(object)parent);
		UnityEngine.Object.DestroyImmediate(settingsButton, (byte)(int)"musicButton" != 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		LimitedCharacterPopupManager._003CTimer_003Ed__25 obj2 = default;
		((IDisposable)obj2).Dispose();
		object obj3 = obj2 + 28;
		obj3 = "icon_musicOn";
		object obj4 = 0;
		_ = 0;
		obj4 = -2f;
		_ = 0f;
		_ = 0f;
		object obj5 = obj4 + 12;
		obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj6 = obj2 + 32;
		obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v22+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		_ = 0;
		object obj8 = default;
		object obj7 = obj8 + 16;
		obj7 = 0;
		object obj9 = obj2 + 20;
		obj9 = obj8;
		nint num4 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v36 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num5 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v550 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = _003C_003Ec._003C_003E9__32_0 == null;
		bool flag2 = !flag;
		Action<GameObject> action = _003C_003Ec._003C_003E9__32_0;
		if (!flag2)
		{
			nint num6 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S0_v524 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			if (obj11 != null)
			{
				nint num7 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S0_v544 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num8 = 0;
			_ = 0;
			Action<GameObject> action2 = default;
			object obj12 = action2 + 16;
			obj12 = _003C_003Ec._003C_003E9;
			nint num9 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ S0_v541 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+5C]");
			object obj13 = (nint)0 + (nint)4;
			obj13 = action2;
			action = action2;
		}
		object obj14 = obj2 + 24;
		obj14 = action;
		nint num10 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S0_v48 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+BA]");
		object obj15 = (nint)0 & (nint)0x200;
		if (obj15 != null)
		{
			nint num11 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S0_v517 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag3 = _003C_003Ec._003C_003E9__32_1 == null;
		bool flag4 = !flag3;
		Action<UILabel> action3 = _003C_003Ec._003C_003E9__32_1;
		if (!flag4)
		{
			nint num12 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ S0_v491 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+BA]");
			object obj16 = (nint)0 & (nint)0x200;
			if (obj16 != null)
			{
				nint num13 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ S0_v511 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num14 = 0;
			_ = 0;
			Action<UILabel> action4 = default;
			object obj17 = action4 + 16;
			obj17 = _003C_003Ec._003C_003E9;
			nint num15 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ S0_v508 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+5C]");
			object obj18 = (nint)0 + (nint)8;
			obj18 = action4;
			action3 = action4;
		}
		object obj19 = obj2 + 8;
		obj19 = action3;
		nint num16 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ S0_v60 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+BA]");
		object obj20 = (nint)0 & (nint)0x200;
		if (obj20 != null)
		{
			nint num17 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ S0_v484 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag5 = _003C_003Ec._003C_003E9__32_2 == null;
		bool flag6 = !flag5;
		Action<UILabel> action5 = _003C_003Ec._003C_003E9__32_2;
		if (!flag6)
		{
			nint num18 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ S0_v458 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+BA]");
			object obj21 = (nint)0 & (nint)0x200;
			if (obj21 != null)
			{
				nint num19 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ S0_v478 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num20 = 0;
			_ = 0;
			Action<UILabel> action6 = default;
			object obj22 = action6 + 16;
			obj22 = _003C_003Ec._003C_003E9;
			nint num21 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ S0_v475 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+5C]");
			object obj23 = (nint)0 + (nint)12;
			obj23 = action6;
			action5 = action6;
		}
		object obj24 = obj2 + 12;
		obj24 = action5;
		settingsButton.buttonDisabled = (byte)(int)obj2 != 0;
		GameObject parent2 = _layout.gameObject;
		nint num22 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ S2_v13 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj25 = (nint)0 & (nint)0x200;
		if (obj25 != null)
		{
			nint num23 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ S2_v183 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SettingsButton settingsButton2 = UnityEngine.Object.Instantiate(_settingsButtonPrefab, (Transform)(object)parent2);
		UnityEngine.Object.DestroyImmediate(settingsButton2, (byte)(int)"sfxButton" != 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		LimitedCharacterPopupManager._003CTimer_003Ed__25 obj26 = default;
		((IDisposable)obj26).Dispose();
		object obj27 = obj26 + 28;
		obj27 = "icon_soundOn";
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num24 = 0;
		_ = 0;
		object obj29 = default;
		object obj28 = obj29 + 16;
		obj28 = 0;
		object obj30 = obj26 + 20;
		obj30 = obj29;
		nint num25 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ S0_v89 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+BA]");
		object obj31 = (nint)0 & (nint)0x200;
		if (obj31 != null)
		{
			nint num26 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ S0_v451 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag7 = _003C_003Ec._003C_003E9__32_3 == null;
		bool flag8 = !flag7;
		Action<GameObject> action7 = _003C_003Ec._003C_003E9__32_3;
		if (!flag8)
		{
			nint num27 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ S0_v425 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+BA]");
			object obj32 = (nint)0 & (nint)0x200;
			if (obj32 != null)
			{
				nint num28 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ S0_v445 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num29 = 0;
			_ = 0;
			Action<GameObject> action8 = default;
			object obj33 = action8 + 16;
			obj33 = _003C_003Ec._003C_003E9;
			nint num30 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v504 @ S0_v442 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+5C]");
			object obj34 = (nint)0 + (nint)16;
			obj34 = action8;
			action7 = action8;
		}
		object obj35 = obj26 + 24;
		obj35 = action7;
		nint num31 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v454 @ S0_v101 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+BA]");
		object obj36 = (nint)0 & (nint)0x200;
		if (obj36 != null)
		{
			nint num32 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ S0_v418 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag9 = _003C_003Ec._003C_003E9__32_4 == null;
		bool flag10 = !flag9;
		Action<UILabel> action9 = _003C_003Ec._003C_003E9__32_4;
		if (!flag10)
		{
			nint num33 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v509 @ S0_v392 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+BA]");
			object obj37 = (nint)0 & (nint)0x200;
			if (obj37 != null)
			{
				nint num34 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ S0_v412 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num35 = 0;
			_ = 0;
			Action<UILabel> action10 = default;
			object obj38 = action10 + 16;
			obj38 = _003C_003Ec._003C_003E9;
			nint num36 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v585 @ S0_v409 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+5C]");
			object obj39 = (nint)0 + (nint)20;
			obj39 = action10;
			action9 = action10;
		}
		object obj40 = obj26 + 8;
		obj40 = action9;
		nint num37 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v534 @ S0_v113 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+BA]");
		object obj41 = (nint)0 & (nint)0x200;
		if (obj41 != null)
		{
			nint num38 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ S0_v385 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag11 = _003C_003Ec._003C_003E9__32_5 == null;
		bool flag12 = !flag11;
		Action<UILabel> action11 = _003C_003Ec._003C_003E9__32_5;
		if (!flag12)
		{
			nint num39 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v590 @ S0_v359 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+BA]");
			object obj42 = (nint)0 & (nint)0x200;
			if (obj42 != null)
			{
				nint num40 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v619 @ S0_v379 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num41 = 0;
			_ = 0;
			Action<UILabel> action12 = default;
			object obj43 = action12 + 16;
			obj43 = _003C_003Ec._003C_003E9;
			nint num42 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v650 @ S0_v376 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+5C]");
			object obj44 = (nint)0 + (nint)24;
			obj44 = action12;
			action11 = action12;
		}
		object obj45 = obj26 + 12;
		obj45 = action11;
		settingsButton2.buttonDisabled = (byte)(int)obj26 != 0;
		bool flag13 = isActive;
		GameObject parent3 = _layout.gameObject;
		nint num43 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v663 @ S0_v133 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj46 = (nint)0 & (nint)0x200;
		if (obj46 != null)
		{
			nint num44 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v669 @ S0_v354 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj47 = this + 112;
		SettingsButton settingsButton3 = UnityEngine.Object.Instantiate(_settingsButtonPrefab, (Transform)(object)parent3);
		obj47 = settingsButton3;
		UnityEngine.Object.DestroyImmediate(_languageSelectionButton, (byte)(int)"languageSelectionButton" != 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		LimitedCharacterPopupManager._003CTimer_003Ed__25 obj48 = default;
		((IDisposable)obj48).Dispose();
		object obj49 = obj48 + 28;
		obj49 = "icon_language_settings";
		obj4 = 0;
		_ = 0;
		obj4 = -1f;
		_ = 0f;
		_ = 0f;
		obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj50 = obj48 + 32;
		obj50 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v22+8]");
		_ = 0;
		nint num45 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v727 @ S1_v102 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+BA]");
		object obj51 = (nint)0 & (nint)0x200;
		if (obj51 != null)
		{
			nint num46 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v733 @ S1_v537 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag14 = _003C_003Ec._003C_003E9__32_6 == null;
		bool flag15 = !flag14;
		Action action13 = _003C_003Ec._003C_003E9__32_6;
		if (!flag15)
		{
			nint num47 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v750 @ S1_v515 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+BA]");
			object obj52 = (nint)0 & (nint)0x200;
			if (obj52 != null)
			{
				nint num48 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v781 @ S1_v532 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr = 0;
			Action action14 = default;
			((Delegate)action14).method_ptr = method_ptr;
			((Delegate)action14).method = (nint)__ldftn(_003C_003Ec._003CLoadAllButtons_003Eb__32_6);
			object obj53 = action14 + 16;
			obj53 = _003C_003Ec._003C_003E9;
			nint num49 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v816 @ S1_v529 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+5C]");
			object obj54 = (nint)0 + (nint)28;
			obj54 = action14;
			action13 = action14;
		}
		object obj55 = obj48 + 20;
		obj55 = action13;
		nint num50 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v774 @ S1_v114 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+BA]");
		object obj56 = (nint)0 & (nint)0x200;
		if (obj56 != null)
		{
			nint num51 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v793 @ S1_v509 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag16 = _003C_003Ec._003C_003E9__32_7 == null;
		bool flag17 = !flag16;
		Action<GameObject> action15 = _003C_003Ec._003C_003E9__32_7;
		if (!flag17)
		{
			nint num52 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v821 @ S1_v484 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+BA]");
			object obj57 = (nint)0 & (nint)0x200;
			if (obj57 != null)
			{
				nint num53 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v853 @ S1_v504 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num54 = 0;
			_ = 0;
			Action<GameObject> action16 = default;
			object obj58 = action16 + 16;
			obj58 = _003C_003Ec._003C_003E9;
			nint num55 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v891 @ S1_v501 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+5C]");
			object obj59 = (nint)0 + (nint)32;
			obj59 = action16;
			action15 = action16;
		}
		object obj60 = obj48 + 24;
		obj60 = action15;
		nint num56 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v845 @ S1_v126 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+BA]");
		object obj61 = (nint)0 & (nint)0x200;
		if (obj61 != null)
		{
			nint num57 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v865 @ S1_v478 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag18 = _003C_003Ec._003C_003E9__32_8 == null;
		bool flag19 = !flag18;
		Action<UILabel> action17 = _003C_003Ec._003C_003E9__32_8;
		if (!flag19)
		{
			nint num58 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v896 @ S1_v453 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+BA]");
			object obj62 = (nint)0 & (nint)0x200;
			if (obj62 != null)
			{
				nint num59 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v928 @ S1_v473 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num60 = 0;
			_ = 0;
			Action<UILabel> action18 = default;
			object obj63 = action18 + 16;
			obj63 = _003C_003Ec._003C_003E9;
			nint num61 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v966 @ S1_v470 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+5C]");
			object obj64 = (nint)0 + (nint)36;
			obj64 = action18;
			action17 = action18;
		}
		object obj65 = obj48 + 8;
		obj65 = action17;
		nint num62 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v920 @ S1_v138 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+BA]");
		object obj66 = (nint)0 & (nint)0x200;
		if (obj66 != null)
		{
			nint num63 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v940 @ S1_v447 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag20 = _003C_003Ec._003C_003E9__32_9 == null;
		bool flag21 = !flag20;
		Action<UILabel> action19 = _003C_003Ec._003C_003E9__32_9;
		if (!flag21)
		{
			nint num64 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v971 @ S1_v422 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+BA]");
			object obj67 = (nint)0 & (nint)0x200;
			if (obj67 != null)
			{
				nint num65 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v998 @ S1_v442 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num66 = 0;
			_ = 0;
			Action<UILabel> action20 = default;
			object obj68 = action20 + 16;
			obj68 = _003C_003Ec._003C_003E9;
			nint num67 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1029 @ S1_v439 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+5C]");
			object obj69 = (nint)0 + (nint)40;
			obj69 = action20;
			action19 = action20;
		}
		object obj70 = obj48 + 12;
		obj70 = action19;
		_languageSelectionButton.buttonDisabled = (byte)(int)obj48 != 0;
		bool flag22 = isActive;
		_extraDividers.Add((UISprite)flag22);
		GameObject parent4 = _layout.gameObject;
		nint num68 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1044 @ S0_v151 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj71 = (nint)0 & (nint)0x200;
		if (obj71 != null)
		{
			nint num69 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1050 @ S0_v351 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj72 = this + 116;
		SettingsButton settingsButton4 = UnityEngine.Object.Instantiate(_settingsButtonPrefab, (Transform)(object)parent4);
		obj72 = settingsButton4;
		UnityEngine.Object.DestroyImmediate(_withdrawConsentButton, (byte)(int)"withdrawConsentButton" != 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		LimitedCharacterPopupManager._003CTimer_003Ed__25 obj73 = default;
		((IDisposable)obj73).Dispose();
		object obj74 = obj73 + 28;
		obj74 = "icon_consent";
		obj4 = 0;
		_ = 0;
		obj4 = 0f;
		_ = 1f;
		_ = 0f;
		obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj75 = obj73 + 32;
		obj75 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v22+8]");
		_ = 0;
		nint num70 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1105 @ S1_v175 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+BA]");
		object obj76 = (nint)0 & (nint)0x200;
		if (obj76 != null)
		{
			nint num71 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1111 @ S1_v416 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag23 = _003C_003Ec._003C_003E9__32_10 == null;
		bool flag24 = !flag23;
		Action action21 = _003C_003Ec._003C_003E9__32_10;
		if (!flag24)
		{
			nint num72 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1125 @ S1_v394 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+BA]");
			object obj77 = (nint)0 & (nint)0x200;
			if (obj77 != null)
			{
				nint num73 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1156 @ S1_v411 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr2 = 0;
			Action action22 = default;
			((Delegate)action22).method_ptr = method_ptr2;
			((Delegate)action22).method = (nint)__ldftn(_003C_003Ec._003CLoadAllButtons_003Eb__32_10);
			object obj78 = action22 + 16;
			obj78 = _003C_003Ec._003C_003E9;
			nint num74 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1191 @ S1_v408 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+5C]");
			object obj79 = (nint)0 + (nint)44;
			obj79 = action22;
			action21 = action22;
		}
		object obj80 = obj73 + 20;
		obj80 = action21;
		nint num75 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1149 @ S1_v187 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+BA]");
		object obj81 = (nint)0 & (nint)0x200;
		if (obj81 != null)
		{
			nint num76 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1168 @ S1_v388 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag25 = _003C_003Ec._003C_003E9__32_11 == null;
		bool flag26 = !flag25;
		Action<GameObject> action23 = _003C_003Ec._003C_003E9__32_11;
		if (!flag26)
		{
			nint num77 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1196 @ S1_v363 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+BA]");
			object obj82 = (nint)0 & (nint)0x200;
			if (obj82 != null)
			{
				nint num78 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1228 @ S1_v383 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num79 = 0;
			_ = 0;
			Action<GameObject> action24 = default;
			object obj83 = action24 + 16;
			obj83 = _003C_003Ec._003C_003E9;
			nint num80 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1266 @ S1_v380 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+5C]");
			object obj84 = (nint)0 + (nint)48;
			obj84 = action24;
			action23 = action24;
		}
		object obj85 = obj73 + 24;
		obj85 = action23;
		nint num81 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1220 @ S1_v199 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+BA]");
		object obj86 = (nint)0 & (nint)0x200;
		if (obj86 != null)
		{
			nint num82 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1240 @ S1_v357 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag27 = _003C_003Ec._003C_003E9__32_12 == null;
		bool flag28 = !flag27;
		Action<UILabel> action25 = _003C_003Ec._003C_003E9__32_12;
		if (!flag28)
		{
			nint num83 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1271 @ S1_v332 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+BA]");
			object obj87 = (nint)0 & (nint)0x200;
			if (obj87 != null)
			{
				nint num84 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1303 @ S1_v352 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num85 = 0;
			_ = 0;
			Action<UILabel> action26 = default;
			object obj88 = action26 + 16;
			obj88 = _003C_003Ec._003C_003E9;
			nint num86 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1341 @ S1_v349 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+5C]");
			object obj89 = (nint)0 + (nint)52;
			obj89 = action26;
			action25 = action26;
		}
		object obj90 = obj73 + 8;
		obj90 = action25;
		nint num87 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1295 @ S1_v211 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+BA]");
		object obj91 = (nint)0 & (nint)0x200;
		if (obj91 != null)
		{
			nint num88 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1315 @ S1_v326 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag29 = _003C_003Ec._003C_003E9__32_13 == null;
		bool flag30 = !flag29;
		Action<UILabel> action27 = _003C_003Ec._003C_003E9__32_13;
		if (!flag30)
		{
			nint num89 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1346 @ S1_v301 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+BA]");
			object obj92 = (nint)0 & (nint)0x200;
			if (obj92 != null)
			{
				nint num90 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1373 @ S1_v321 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num91 = 0;
			_ = 0;
			Action<UILabel> action28 = default;
			object obj93 = action28 + 16;
			obj93 = _003C_003Ec._003C_003E9;
			nint num92 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1405 @ S1_v318 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+5C]");
			object obj94 = (nint)0 + (nint)56;
			obj94 = action28;
			action27 = action28;
		}
		object obj95 = obj73 + 12;
		obj95 = action27;
		_withdrawConsentButton.buttonDisabled = (byte)(int)obj73 != 0;
		GameObject parent5 = _layout.gameObject;
		nint num93 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1409 @ S2_v100 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj96 = (nint)0 & (nint)0x200;
		if (obj96 != null)
		{
			nint num94 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1416 @ S2_v108 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SettingsButton settingsButton5 = UnityEngine.Object.Instantiate(_settingsButtonPrefab, (Transform)(object)parent5);
		UnityEngine.Object.DestroyImmediate(settingsButton5, (byte)(int)"privacyPolicyButton" != 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		LimitedCharacterPopupManager._003CTimer_003Ed__25 obj97 = default;
		((IDisposable)obj97).Dispose();
		object obj98 = obj97 + 28;
		obj98 = "popup_settings_i";
		obj4 = 0;
		_ = 0;
		obj4 = 0f;
		_ = 1f;
		_ = 0f;
		obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj99 = obj97 + 32;
		obj99 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v22+8]");
		_ = 0;
		nint num95 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1463 @ S0_v180 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+BA]");
		object obj100 = (nint)0 & (nint)0x200;
		if (obj100 != null)
		{
			nint num96 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1469 @ S0_v346 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag31 = _003C_003Ec._003C_003E9__32_14 == null;
		bool flag32 = !flag31;
		Action action29 = _003C_003Ec._003C_003E9__32_14;
		if (!flag32)
		{
			nint num97 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1483 @ S0_v324 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+BA]");
			object obj101 = (nint)0 & (nint)0x200;
			if (obj101 != null)
			{
				nint num98 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1514 @ S0_v341 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr3 = 0;
			Action action30 = default;
			((Delegate)action30).method_ptr = method_ptr3;
			((Delegate)action30).method = (nint)__ldftn(_003C_003Ec._003CLoadAllButtons_003Eb__32_14);
			object obj102 = action30 + 16;
			obj102 = _003C_003Ec._003C_003E9;
			nint num99 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1551 @ S0_v338 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+5C]");
			object obj103 = (nint)0 + (nint)60;
			obj103 = action30;
			action29 = action30;
		}
		object obj104 = obj97 + 20;
		obj104 = action29;
		nint num100 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1507 @ S0_v192 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+BA]");
		object obj105 = (nint)0 & (nint)0x200;
		bool flag33 = obj105 == null;
		nint num101 = (nint)typeof(_003C_003Ec);
		if (!flag33)
		{
			nint num102 = (nint)typeof(_003C_003Ec);
			num101 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1526 @ S0_v318 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num101 = (nint)typeof(_003C_003Ec);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1528 @ L0_v8 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+5C]");
		object obj106 = -(-64);
		bool flag34 = obj106 == null;
		bool flag35 = !flag34;
		object obj107 = obj106;
		if (!flag35)
		{
			nint num103 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1556 @ S0_v293 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+BA]");
			object obj108 = (nint)0 & (nint)0x200;
			if (obj108 != null)
			{
				nint num104 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1588 @ S0_v313 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num105 = 0;
			_ = 0;
			object obj110 = default;
			object obj109 = obj110 + 16;
			obj109 = _003C_003Ec._003C_003E9;
			nint num106 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1626 @ S0_v310 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+5C]");
			object obj111 = -(-64);
			obj111 = obj110;
			obj107 = obj110;
		}
		object obj112 = obj97 + 24;
		obj112 = obj107;
		nint num107 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1580 @ S0_v205 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+BA]");
		object obj113 = (nint)0 & (nint)0x200;
		if (obj113 != null)
		{
			nint num108 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1600 @ S0_v287 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag36 = _003C_003Ec._003C_003E9__32_16 == null;
		bool flag37 = !flag36;
		Action<UILabel> action31 = _003C_003Ec._003C_003E9__32_16;
		if (!flag37)
		{
			nint num109 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1631 @ S0_v262 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+BA]");
			object obj114 = (nint)0 & (nint)0x200;
			if (obj114 != null)
			{
				nint num110 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1663 @ S0_v282 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num111 = 0;
			_ = 0;
			Action<UILabel> action32 = default;
			object obj115 = action32 + 16;
			obj115 = _003C_003Ec._003C_003E9;
			nint num112 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1701 @ S0_v279 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+5C]");
			object obj116 = (nint)0 + (nint)68;
			obj116 = action32;
			action31 = action32;
		}
		object obj117 = obj97 + 8;
		obj117 = action31;
		nint num113 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1655 @ S0_v217 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+BA]");
		object obj118 = (nint)0 & (nint)0x200;
		if (obj118 != null)
		{
			nint num114 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1675 @ S0_v256 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag38 = _003C_003Ec._003C_003E9__32_17 == null;
		bool flag39 = !flag38;
		Action<UILabel> action33 = _003C_003Ec._003C_003E9__32_17;
		if (!flag39)
		{
			nint num115 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1706 @ S0_v231 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+BA]");
			object obj119 = (nint)0 & (nint)0x200;
			if (obj119 != null)
			{
				nint num116 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1734 @ S0_v251 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num117 = 0;
			_ = 0;
			Action<UILabel> action34 = default;
			object obj120 = action34 + 16;
			obj120 = _003C_003Ec._003C_003E9;
			nint num118 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1762 @ S0_v248 (Il2CppClass<UI.Screens.SettingsPopup+<>c>)+5C]");
			object obj121 = (nint)0 + (nint)72;
			obj121 = action34;
			action33 = action34;
		}
		object obj122 = obj97 + 12;
		obj122 = action33;
		settingsButton5.buttonDisabled = (byte)(int)obj97 != 0;
	}

	private void UpdatePopupDimension(bool tutorialCompleted)
	{
		//IL_01e6: Expected I, but got Obj
		//IL_01fc: Expected Obj, but got I
		//IL_0223: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0069: Expected Obj, but got I4
		//IL_014e: Expected I, but got Obj
		//IL_0164: Expected Obj, but got I
		//IL_00c0: Expected I, but got Obj
		//IL_00d6: Expected Obj, but got I
		//IL_018f: Expected I, but got Obj
		//IL_0101: Expected I, but got Obj
		bool isCurrentPromotionActive = ((PromotionManager)(object)this).IsCurrentPromotionActive;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v45 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if ((UnityEngine.Object)isCurrentPromotionActive != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		string text = default;
		if (!((string)tutorialCompleted != text))
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		object obj2 = default;
		if (obj2 != null)
		{
			nint num3 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v37 (Il2CppClass<Flurry>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(Flurry);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v41 (Il2CppClass<Flurry>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return;
		}
		nint num5 = (nint)typeof(PromotionManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v21 (Il2CppClass<UI.Screens.PromotionManager>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num6 = (nint)typeof(PromotionManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v28 (Il2CppClass<UI.Screens.PromotionManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		TransformExtensions.Reset((Transform)(object)PromotionManager.onPromotionExpiredHandler);
	}

	public override void Hide()
	{
		//IL_0035: Expected I, but got Obj
		//IL_004b: Expected Obj, but got I
		//IL_0382: Expected Obj, but got I4
		//IL_00c3: Expected I, but got Obj
		//IL_00d9: Expected Obj, but got I
		//IL_0076: Expected I, but got Obj
		//IL_0104: Expected I, but got Obj
		//IL_0439: Unknown result type (might be due to invalid IL or missing references)
		//IL_043e: Expected Obj, but got Unknown
		//IL_0151: Expected I, but got Obj
		//IL_0167: Expected Obj, but got I
		//IL_03de: Expected Obj, but got I
		//IL_0406: Expected Obj, but got I4
		//IL_0192: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		base.Hide();
		int numberOfRunsSinceLastGuideline = OnboardingSave.numberOfRunsSinceLastGuideline;
		int num = numberOfRunsSinceLastGuideline & 1;
		string text = _withdrawConsentButton.tag;
		nint num2 = (nint)typeof(AgeRestriction);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v8 (Il2CppClass<Info.AgeRestriction>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num3 = (nint)typeof(AgeRestriction);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v68 (Il2CppClass<Info.AgeRestriction>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool waitForAgeRestriction = AgeRestriction.waitForAgeRestriction;
		string text2 = (string)((waitForAgeRestriction ? 1 : 0) ^ 1);
		((GameObject)(object)text).tag = text2;
		string text3 = _languageSelectionButton.tag;
		nint num4 = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S1_v17 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num5 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S1_v64 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text4;
		if (MergeLevelStartHelp.IsValidLoadedLevelNameForGameplay())
		{
			nint num6 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S1_v50 (Il2CppClass<SYBO.Subway.Game>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num7 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S1_v60 (Il2CppClass<SYBO.Subway.Game>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool isInstantiated = Game.IsInstantiated;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S1_v55 (System.Boolean)+60]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S1_v56+8]");
			bool flag = (nint)0 != 0;
			text4 = (string)((flag ? 1 : 0) ^ 1);
		}
		else
		{
			text4 = null;
		}
		((GameObject)(object)text3).tag = text4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num8 = 0;
		_ = 0;
		object obj6 = default;
		object obj5 = obj6 + 16;
		object obj7 = default;
		obj5 = obj7;
		throw new NullReferenceException();
	}

	public void LoggedOutOfFacebook()
	{
		//IL_001e: Expected Obj, but got I4
		base.LoseFocus();
		int numberOfRunsSinceLastGuideline = OnboardingSave.numberOfRunsSinceLastGuideline;
		((TutorialDoubleCoinsPopup)this).OnNewPopupShown((string)numberOfRunsSinceLastGuideline);
	}

	public void ConnectedToFacebook()
	{
		//IL_013b: Expected I, but got Obj
		//IL_0151: Expected Obj, but got I
		//IL_007e: Expected I, but got Obj
		//IL_0094: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00bf: Expected I, but got Obj
		//IL_011b: Expected Obj, but got I4
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v25 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_facebookLogoutButton).FindKernel((string)null) != 0)
		{
			string text = _facebookLogoutButton.tag;
			((GameObject)(object)text).tag = null;
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S1_v19 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_facebookLoginButton).FindKernel((string)null) != 0)
		{
			string text2 = _facebookLoginButton.tag;
			((GameObject)(object)text2).tag = (string)1;
		}
		((RewardForVideoButton)(object)_layout).Init((VideoButtonPayload)null);
	}

	public SettingsPopup()
	{
		//IL_013b: Expected I, but got Obj
		//IL_0151: Expected Obj, but got I
		//IL_0082: Expected I, but got Obj
		//IL_0098: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_006f: Expected Obj, but got I4
		//IL_00c3: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v25 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_facebookLogoutButton).FindKernel((string)null) != 0)
		{
			string text = _facebookLogoutButton.tag;
			((GameObject)(object)text).tag = (string)1;
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S1_v19 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_facebookLoginButton).FindKernel((string)null) != 0)
		{
			string text2 = _facebookLoginButton.tag;
			((GameObject)(object)text2).tag = null;
		}
		((RewardForVideoButton)(object)_layout).Init((VideoButtonPayload)null);
	}
}
