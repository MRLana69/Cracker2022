using System;
using System.Collections.Generic;
using System.IO;
using Cpp2ILInjected;
using Info;
using Kiloo.Common.Ads;
using SYBO.Components.Utilities;
using SYBO.Subway.Benchmarking;
using SYBO.Subway.Info;
using SYBO.Subway.Level;
using SYBO.Subway.Utilities;
using UnityEngine;

public class DebugSettingsHelper : MonoBehaviour
{
	private const string MOBVISTA_DISPLAY_TEXT = "MobVista";

	private const string FACEBOOK_DISPLAY_TEXT = "Facebook";

	private const string TAPJOY_DISPLAY_TEXT = "Tapjoy";

	private const string INMOBI_DISPLAY_TEXT = "InMobi";

	private const string VUNGLE_DISPLAY_TEXT = "Vungle";

	private const string ADCOLONY_DISPLAY_TEXT = "AdColony";

	private const string SUPERSONIC_DISPLAY_TEXT = "Supersonic";

	private const string CHARTBOOST_DISPLAY_TEXT = "Chartboost";

	private const string FLURRY_DISPLAY_TEXT = "Flurry";

	private const string YEAH_MOBI_DISPLAY_TEXT = "YeahMobi";

	public UILabel Title;

	public UILabel Description;

	public GameObject EventTesterIcon;

	public GameObject CelebrationTesterIcon;

	public GameObject SkipTutorialIcon;

	public GameObject MemoryBenchmarkIcon;

	public GameObject FPSTestIcon;

	public GameObject WelcomePopupIcon;

	public GameObject WeeklyHuntIcon;

	public GameObject AdSystemTesterIcon;

	public GameObject OffIcon;

	public GameObject OnIcon;

	public SelectPopupButton PopupList;

	public UILabel PopupListTitle;

	private bool currentIconState;

	private DebugSetting _settingType;

	public bool multiSelect;

	public void UpdateTitle(string title)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 32;
		obj = title;
	}

	public void UpdateDescription(string description)
	{
		//IL_000f: Expected I4, but got Obj
		Title.fontSize = (int)description;
	}

	public void SetToggleIcon(DebugSetting settingType)
	{
		Description.fontSize = (int)settingType;
	}

	public void ToggleIcon()
	{
	}

	private List<string> GetCurrentlySelected()
	{
		return (List<string>)(object)MemoryBenchmarkIcon;
	}

	public void SetTesterIcon(ButtonIcon icon)
	{
		//IL_0775: Expected I, but got Obj
		//IL_078b: Expected Obj, but got I
		//IL_1f64: Expected Obj, but got I4
		//IL_1f82: Expected Obj, but got I4
		//IL_07b6: Expected I, but got Obj
		//IL_0803: Expected I, but got Obj
		//IL_0819: Expected Obj, but got I
		//IL_0844: Expected I, but got Obj
		//IL_0891: Expected I, but got Obj
		//IL_08a7: Expected Obj, but got I
		//IL_08d2: Expected I, but got Obj
		//IL_091f: Expected I, but got Obj
		//IL_0935: Expected Obj, but got I
		//IL_0960: Expected I, but got Obj
		//IL_09ad: Expected I, but got Obj
		//IL_09c3: Expected Obj, but got I
		//IL_09ee: Expected I, but got Obj
		//IL_1d71: Expected Obj, but got I4
		//IL_0ac9: Expected I, but got Obj
		//IL_0adf: Expected Obj, but got I
		//IL_0b0a: Expected I, but got Obj
		//IL_0b57: Expected I, but got Obj
		//IL_0b6d: Expected Obj, but got I
		//IL_0b98: Expected I, but got Obj
		//IL_0c73: Expected I, but got Obj
		//IL_0c89: Expected Obj, but got I
		//IL_0cb4: Expected I, but got Obj
		//IL_0d01: Expected I, but got Obj
		//IL_0d17: Expected Obj, but got I
		//IL_0d42: Expected I, but got Obj
		//IL_0d8f: Expected I, but got Obj
		//IL_0da5: Expected Obj, but got I
		//IL_0dd0: Expected I, but got Obj
		//IL_0eab: Expected I, but got Obj
		//IL_0ec1: Expected Obj, but got I
		//IL_0eec: Expected I, but got Obj
		//IL_0fc7: Expected I, but got Obj
		//IL_0fdd: Expected Obj, but got I
		//IL_1008: Expected I, but got Obj
		//IL_1055: Expected I, but got Obj
		//IL_106b: Expected Obj, but got I
		//IL_1096: Expected I, but got Obj
		//IL_133b: Expected I, but got Obj
		//IL_1351: Expected Obj, but got I
		//IL_137c: Expected I, but got Obj
		//IL_13c9: Expected I, but got Obj
		//IL_13df: Expected Obj, but got I
		//IL_140a: Expected I, but got Obj
		//IL_1457: Expected I, but got Obj
		//IL_146d: Expected Obj, but got I
		//IL_1498: Expected I, but got Obj
		//IL_14e5: Expected I, but got Obj
		//IL_14fb: Expected Obj, but got I
		//IL_1526: Expected I, but got Obj
		//IL_1573: Expected I, but got Obj
		//IL_1589: Expected Obj, but got I
		//IL_15b4: Expected I, but got Obj
		//IL_1601: Expected I, but got Obj
		//IL_1617: Expected Obj, but got I
		//IL_1642: Expected I, but got Obj
		//IL_16a5: Expected I, but got Obj
		//IL_16bb: Expected Obj, but got I
		//IL_16e6: Expected I, but got Obj
		//IL_1733: Expected I, but got Obj
		//IL_1749: Expected Obj, but got I
		//IL_1774: Expected I, but got Obj
		//IL_184f: Expected I, but got Obj
		//IL_1865: Expected Obj, but got I
		//IL_1890: Expected I, but got Obj
		//IL_18dd: Expected I, but got Obj
		//IL_18f3: Expected Obj, but got I
		//IL_191e: Expected I, but got Obj
		//IL_1c5b: Expected I, but got Obj
		//IL_1c71: Expected Obj, but got I
		//IL_1c9c: Expected I, but got Obj
		//IL_1ce9: Expected I, but got Obj
		//IL_1cff: Expected Obj, but got I
		//IL_1d2a: Expected I, but got Obj
		//IL_1bcd: Expected I, but got Obj
		//IL_1be3: Expected Obj, but got I
		//IL_1c0e: Expected I, but got Obj
		//IL_1b3f: Expected I, but got Obj
		//IL_1b55: Expected Obj, but got I
		//IL_1b80: Expected I, but got Obj
		//IL_1a87: Expected I, but got Obj
		//IL_1a9d: Expected Obj, but got I
		//IL_1aba: Expected I, but got Obj
		//IL_2123: Expected Obj, but got I
		//IL_1ad6: Expected I, but got Obj
		//IL_1b06: Expected I, but got Obj
		//IL_19f9: Expected I, but got Obj
		//IL_1a0f: Expected Obj, but got I
		//IL_1b2c: Expected I, but got Obj
		//IL_1a3a: Expected I, but got Obj
		//IL_196b: Expected I, but got Obj
		//IL_1981: Expected Obj, but got I
		//IL_19ac: Expected I, but got Obj
		//IL_17c1: Expected I, but got Obj
		//IL_17d7: Expected Obj, but got I
		//IL_1802: Expected I, but got Obj
		//IL_1692: Expected I4, but got Obj
		//IL_12ad: Expected I, but got Obj
		//IL_12c3: Expected Obj, but got I
		//IL_12ee: Expected I, but got Obj
		//IL_121f: Expected I, but got Obj
		//IL_1235: Expected Obj, but got I
		//IL_1260: Expected I, but got Obj
		//IL_1133: Expected I, but got Obj
		//IL_1149: Expected Obj, but got I
		//IL_1174: Expected I, but got Obj
		//IL_0f39: Expected I, but got Obj
		//IL_0f4f: Expected Obj, but got I
		//IL_0f7a: Expected I, but got Obj
		//IL_0e1d: Expected I, but got Obj
		//IL_0e33: Expected Obj, but got I
		//IL_0e5e: Expected I, but got Obj
		//IL_0be5: Expected I, but got Obj
		//IL_0bfb: Expected Obj, but got I
		//IL_0c26: Expected I, but got Obj
		//IL_0a3b: Expected I, but got Obj
		//IL_0a51: Expected Obj, but got I
		//IL_0a7c: Expected I, but got Obj
		bool flag = default;
		switch (icon)
		{
		case ButtonIcon.None:
		{
			nint num64 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v17 (Il2CppClass<Globals>)+BA]");
			object obj34 = (nint)0 & (nint)0x200;
			if (obj34 != null)
			{
				nint num65 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v25 (Il2CppClass<Globals>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			flag = Globals.DEBUG_ALL_CHARS;
			break;
		}
		case ButtonIcon.CelebrationTester:
		{
			nint num23 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v32 (Il2CppClass<Globals>)+BA]");
			object obj13 = (nint)0 & (nint)0x200;
			if (obj13 != null)
			{
				nint num24 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v40 (Il2CppClass<Globals>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			flag = Globals.DEBUG_ALL_BOARDS;
			break;
		}
		case ButtonIcon.EventTester:
		{
			nint num58 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v47 (Il2CppClass<Globals>)+BA]");
			object obj31 = (nint)0 & (nint)0x200;
			if (obj31 != null)
			{
				nint num59 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ S0_v55 (Il2CppClass<Globals>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			flag = Globals.DEBUG_FREE_INAPP_PURCHASE;
			break;
		}
		case ButtonIcon.TutorialSkip:
		{
			nint num42 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ S0_v62 (Il2CppClass<Globals>)+BA]");
			object obj23 = (nint)0 & (nint)0x200;
			if (obj23 != null)
			{
				nint num43 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ S0_v70 (Il2CppClass<Globals>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			flag = Globals.DEBUG_SKIP_DAILY_LETTERS;
			break;
		}
		case ButtonIcon.MemoryBenchmark:
		{
			nint num5 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ S0_v77 (Il2CppClass<Globals>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num6 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ S0_v85 (Il2CppClass<Globals>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			flag = Globals.DEBUG_SHOW_FRONT_SCREEN_IF_NEW_USER;
			break;
		}
		case (ButtonIcon)65:
		{
			nint num60 = (nint)typeof(DebugAdProvider);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v985 @ S0_v597 (Il2CppClass<Kiloo.Common.Ads.DebugAdProvider>)+BA]");
			object obj32 = (nint)0 & (nint)0x200;
			if (obj32 != null)
			{
				nint num61 = (nint)typeof(DebugAdProvider);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1003 @ S0_v605 (Il2CppClass<Kiloo.Common.Ads.DebugAdProvider>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			flag = DebugAdProvider.forceCacheToFail;
			break;
		}
		case ButtonIcon.WelcomePopup:
		{
			nint num48 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ S0_v100 (Il2CppClass<Globals>)+BA]");
			object obj26 = (nint)0 & (nint)0x200;
			if (obj26 != null)
			{
				nint num49 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ S0_v108 (Il2CppClass<Globals>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			flag = Globals.DEBUG_USE_ONLINESETTINGS_SET;
			break;
		}
		case ButtonIcon.WeeklyHunt:
		{
			nint num72 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ S0_v115 (Il2CppClass<Globals>)+BA]");
			object obj38 = (nint)0 & (nint)0x200;
			if (obj38 != null)
			{
				nint num73 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ S0_v123 (Il2CppClass<Globals>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			flag = Globals.DEBUG_USE_ONLINESETTINGS_TESTTIME;
			break;
		}
		case (ButtonIcon)64:
		{
			nint num17 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v967 @ S0_v582 (Il2CppClass<Globals>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num18 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v991 @ S0_v590 (Il2CppClass<Globals>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			flag = Globals.DEBUG_USE_DEBUG_AD_PROVIDER;
			break;
		}
		case (ButtonIcon)9:
		{
			nint num32 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ S0_v130 (Il2CppClass<Globals>)+BA]");
			object obj18 = (nint)0 & (nint)0x200;
			if (obj18 != null)
			{
				nint num33 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ S0_v138 (Il2CppClass<Globals>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			flag = Globals.DEBUG_INTERSTITIAL_PROVIDERS;
			break;
		}
		case (ButtonIcon)10:
		{
			nint num76 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ S0_v145 (Il2CppClass<Globals>)+BA]");
			object obj40 = (nint)0 & (nint)0x200;
			if (obj40 != null)
			{
				nint num77 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ S0_v153 (Il2CppClass<Globals>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			flag = Globals.DEBUG_INTERSTITIAL_PROVIDERS_IGNORE_TIME_LIMIT;
			break;
		}
		case (ButtonIcon)11:
		{
			nint num68 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ S0_v160 (Il2CppClass<Globals>)+BA]");
			object obj36 = (nint)0 & (nint)0x200;
			if (obj36 != null)
			{
				nint num69 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ S0_v168 (Il2CppClass<Globals>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			flag = Globals.DEBUG_INTERSTITIAL_PROVIDERS_IGNORE_IN_APP_PURCHASES;
			break;
		}
		case (ButtonIcon)63:
		{
			nint num36 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v949 @ S0_v567 (Il2CppClass<Globals>)+BA]");
			object obj20 = (nint)0 & (nint)0x200;
			if (obj20 != null)
			{
				nint num37 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v973 @ S0_v575 (Il2CppClass<Globals>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			flag = Globals.DEBUG_INTERSTITIAL_IN_EDITOR;
			break;
		}
		case (ButtonIcon)13:
		{
			nint num3 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ S0_v175 (Il2CppClass<Globals>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ S0_v183 (Il2CppClass<Globals>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			flag = Globals.DEBUG_VIDEOADS_PROVIDERS;
			break;
		}
		case (ButtonIcon)62:
		{
			nint num74 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v940 @ S0_v552 (Il2CppClass<Globals>)+BA]");
			object obj39 = (nint)0 & (nint)0x200;
			if (obj39 != null)
			{
				nint num75 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v955 @ S0_v560 (Il2CppClass<Globals>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			flag = Globals.DEBUG_AD_SYSTEM_SINGLE_IMPRESSION;
			break;
		}
		case (ButtonIcon)15:
		{
			nint num50 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ S0_v190 (Il2CppClass<Globals>)+BA]");
			object obj27 = (nint)0 & (nint)0x200;
			if (obj27 != null)
			{
				nint num51 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v483 @ S0_v198 (Il2CppClass<Globals>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			flag = Globals.DEBUG_TEST_FPS_SPIKES;
			break;
		}
		case (ButtonIcon)16:
		{
			nint num44 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v479 @ S0_v205 (Il2CppClass<DebugSettingsPopup>)+BA]");
			object obj24 = (nint)0 & (nint)0x200;
			if (obj24 != null)
			{
				nint num45 = (nint)typeof(DebugSettingsPopup);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ S0_v211 (Il2CppClass<DebugSettingsPopup>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9399");
			break;
		}
		case (ButtonIcon)17:
		{
			bool flag8 = IOSViewController._GetIsSimulator();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ S0_v216 (System.Boolean)+74]");
			flag = (nint)0 != 0;
			break;
		}
		case (ButtonIcon)18:
		{
			bool flag7 = IOSViewController._GetIsSimulator();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v505 @ S0_v220 (System.Boolean)+75]");
			flag = (nint)0 != 0;
			break;
		}
		case (ButtonIcon)60:
		{
			nint num21 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v920 @ S0_v537 (Il2CppClass<Globals>)+BA]");
			object obj12 = (nint)0 & (nint)0x200;
			if (obj12 != null)
			{
				nint num22 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v928 @ S0_v545 (Il2CppClass<Globals>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			flag = Globals.DEBUG_ENABLE_BOARD_BUNDLE;
			break;
		}
		case (ButtonIcon)59:
			flag = DebugSettings.UseQueuedEnvironmentKinds;
			break;
		case (ButtonIcon)21:
		{
			bool flag2 = IOSViewController._GetIsSimulator();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ S0_v224 (System.Boolean)+68]");
			flag = (nint)0 != 0;
			break;
		}
		case (ButtonIcon)22:
		{
			bool flag3 = IOSViewController._GetIsSimulator();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ S0_v228 (System.Boolean)+69]");
			flag = (nint)0 != 0;
			break;
		}
		case (ButtonIcon)57:
		{
			nint num13 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v888 @ S0_v520 (Il2CppClass<Globals>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num14 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v904 @ S0_v528 (Il2CppClass<Globals>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			flag = Globals.DEBUG_INTERSTITIAL_PROVIDERS_IGNORE_GRACE_PERIOD;
			break;
		}
		case (ButtonIcon)56:
		{
			nint num66 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v881 @ S0_v505 (Il2CppClass<Globals>)+BA]");
			object obj35 = (nint)0 & (nint)0x200;
			if (obj35 != null)
			{
				nint num67 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v894 @ S0_v513 (Il2CppClass<Globals>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			flag = Globals.DEBUG_INTERSTITIAL_PROVIDERS_IGNORE_IMPRESSION_LIMIT;
			break;
		}
		case (ButtonIcon)25:
		{
			nint num56 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v518 @ S0_v232 (Il2CppClass<Globals>)+BA]");
			object obj30 = (nint)0 & (nint)0x200;
			if (obj30 != null)
			{
				nint num57 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ S0_v240 (Il2CppClass<Globals>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			flag = Globals.DEBUG_SHADERS;
			break;
		}
		case (ButtonIcon)26:
		{
			nint num52 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v526 @ S0_v247 (Il2CppClass<Globals>)+BA]");
			object obj28 = (nint)0 & (nint)0x200;
			if (obj28 != null)
			{
				nint num53 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ S0_v255 (Il2CppClass<Globals>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			flag = Globals.DEBUG_CHARACTER_MOVE_THROUGH_COLLIDERS;
			break;
		}
		case (ButtonIcon)27:
		{
			nint num38 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v544 @ S0_v262 (Il2CppClass<DebugSettingsPopup>)+BA]");
			object obj21 = (nint)0 & (nint)0x200;
			if (obj21 != null)
			{
				nint num39 = (nint)typeof(DebugSettingsPopup);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v569 @ S0_v270 (Il2CppClass<DebugSettingsPopup>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			flag = DebugSettingsPopup.ScreenTimoutDisabled;
			break;
		}
		case (ButtonIcon)28:
		{
			nint num30 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ S0_v277 (Il2CppClass<Globals>)+BA]");
			object obj17 = (nint)0 & (nint)0x200;
			if (obj17 != null)
			{
				nint num31 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ S0_v285 (Il2CppClass<Globals>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			flag = Globals.DEBUG_USE_TIMESCALE_PAUSE_BUTTON;
			break;
		}
		case (ButtonIcon)29:
		{
			nint num25 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v583 @ S0_v292 (Il2CppClass<Globals>)+BA]");
			object obj14 = (nint)0 & (nint)0x200;
			if (obj14 != null)
			{
				nint num26 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v608 @ S0_v300 (Il2CppClass<Globals>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			flag = Globals.DEBUG_SKIP_VIDEO_ADS;
			break;
		}
		case (ButtonIcon)30:
		{
			nint num11 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v602 @ S0_v307 (Il2CppClass<Globals>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num12 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v621 @ S0_v315 (Il2CppClass<Globals>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			flag = Globals.DEBUG_LIMITED_CHARACTER_POPUP;
			break;
		}
		case (ButtonIcon)54:
		{
			EnvironmentKind[] queuedEnvironmentKinds = DebugSettings.QueuedEnvironmentKinds;
			flag = (byte)(int)queuedEnvironmentKinds != 0;
			break;
		}
		case (ButtonIcon)32:
		{
			nint num7 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v635 @ S0_v322 (Il2CppClass<Globals>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num8 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v650 @ S0_v330 (Il2CppClass<Globals>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			flag = Globals.DEBUG_LIMITED_CHARACTER_POPUP_IGNORE_EXPIRE;
			break;
		}
		case (ButtonIcon)33:
		{
			nint num70 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v644 @ S0_v337 (Il2CppClass<Globals>)+BA]");
			object obj37 = (nint)0 & (nint)0x200;
			if (obj37 != null)
			{
				nint num71 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v662 @ S0_v345 (Il2CppClass<Globals>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			flag = Globals.DEBUG_LIMITED_BOARD_POPUP;
			break;
		}
		case (ButtonIcon)52:
		{
			nint num62 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v846 @ S0_v488 (Il2CppClass<DebugSettingsPopup>)+BA]");
			object obj33 = (nint)0 & (nint)0x200;
			if (obj33 != null)
			{
				nint num63 = (nint)typeof(DebugSettingsPopup);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v863 @ S0_v496 (Il2CppClass<DebugSettingsPopup>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			flag = DebugSettingsPopup.PrintRouteChunksInDebugLabel;
			break;
		}
		case (ButtonIcon)35:
		{
			nint num54 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v675 @ S0_v352 (Il2CppClass<Globals>)+BA]");
			object obj29 = (nint)0 & (nint)0x200;
			if (obj29 != null)
			{
				nint num55 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v690 @ S0_v360 (Il2CppClass<Globals>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			flag = Globals.DEBUG_LIMITED_BOARD_POPUP_IGNORE_EXPIRE;
			break;
		}
		case (ButtonIcon)36:
		{
			nint num46 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v684 @ S0_v367 (Il2CppClass<Globals>)+BA]");
			object obj25 = (nint)0 & (nint)0x200;
			if (obj25 != null)
			{
				nint num47 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v701 @ S0_v375 (Il2CppClass<Globals>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			flag = Globals.DEBUG_SHOW_PERFORMANCE_INFO;
			break;
		}
		case (ButtonIcon)51:
		{
			nint num40 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v837 @ S0_v473 (Il2CppClass<DebugSettingsPopup>)+BA]");
			object obj22 = (nint)0 & (nint)0x200;
			if (obj22 != null)
			{
				nint num41 = (nint)typeof(DebugSettingsPopup);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v852 @ S0_v481 (Il2CppClass<DebugSettingsPopup>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			flag = DebugSettingsPopup.HasSkippedMissions;
			break;
		}
		case (ButtonIcon)49:
		{
			nint num34 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v803 @ S0_v458 (Il2CppClass<Globals>)+BA]");
			object obj19 = (nint)0 & (nint)0x200;
			if (obj19 != null)
			{
				nint num35 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v823 @ S0_v466 (Il2CppClass<Globals>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			flag = Globals.DEBUG_ENABLE_NEW_YEAR_SALES;
			break;
		}
		case (ButtonIcon)48:
		{
			nint num27 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v786 @ S0_v442 (Il2CppClass<Globals>)+BA]");
			object obj15 = (nint)0 & (nint)0x200;
			bool flag4 = obj15 == null;
			nint num28 = (nint)typeof(Globals);
			if (!flag4)
			{
				nint num29 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v809 @ S0_v451 (Il2CppClass<Globals>)+74]");
				bool flag5 = (nint)0 == 0;
				bool flag6 = !flag5;
				num28 = (nint)typeof(Globals);
				if (!flag6)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num28 = (nint)typeof(Globals);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ L1_v84 (Il2CppClass<Globals>)+5C]");
			object obj16 = -(-64);
			flag = obj16 != null;
			break;
		}
		case (ButtonIcon)47:
		{
			nint num19 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ S0_v427 (Il2CppClass<Globals>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			if (obj11 != null)
			{
				nint num20 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v792 @ S0_v435 (Il2CppClass<Globals>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			flag = Globals.DEBUG_ENABLE_SALES;
			break;
		}
		case (ButtonIcon)44:
		{
			nint num15 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ S0_v412 (Il2CppClass<Globals>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num16 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v760 @ S0_v420 (Il2CppClass<Globals>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			flag = Globals.DEBUG_DISPLAY_ALL_BOARDS;
			break;
		}
		case (ButtonIcon)42:
		{
			nint num9 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v718 @ S0_v382 (Il2CppClass<DebugSettingsPopup>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num10 = (nint)typeof(DebugSettingsPopup);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v732 @ S0_v390 (Il2CppClass<DebugSettingsPopup>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			flag = DebugSettingsPopup.HasDeliveredFullUpgrades;
			break;
		}
		case (ButtonIcon)43:
		{
			nint num = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v726 @ S0_v397 (Il2CppClass<Globals>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v749 @ S0_v405 (Il2CppClass<Globals>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			flag = Globals.DEBUG_DISPLAY_ALL_CHARS;
			break;
		}
		default:
		{
			object obj = icon;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			string text = default;
			string msg = "DebugSettingsHelper: Attempting to use undefined DebugSetting type: " + text;
			SDebug.LogFormat(msg, null);
			flag = false;
			break;
		}
		}
		string text2 = (string)((flag ? 1 : 0) ^ 1);
		OffIcon.tag = text2;
		OnIcon.tag = (string)flag;
		currentIconState = flag;
	}

	public void SetExpandableList(DebugSetting settingType)
	{
		//IL_0280: Expected I, but got Obj
		//IL_0296: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_012f: Expected I, but got Obj
		//IL_018c: Expected Obj, but got I4
		//IL_01aa: Expected Obj, but got I4
		//IL_01cd: Expected Obj, but got I4
		//IL_01eb: Expected Obj, but got I4
		//IL_020e: Expected Obj, but got I4
		//IL_022c: Expected Obj, but got I4
		//IL_024f: Expected Obj, but got I4
		//IL_026d: Expected Obj, but got I4
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v45 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)EventTesterIcon).FindKernel((string)null) == 0)
		{
			return;
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S1_v41 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)CelebrationTesterIcon).FindKernel((string)null) == 0)
		{
			return;
		}
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S1_v16 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S1_v37 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)SkipTutorialIcon).FindKernel((string)null) != 0)
		{
			bool flag = settingType == DebugSetting.Purchases;
			EventTesterIcon.tag = (string)flag;
			bool flag2 = settingType == DebugSetting.Boards;
			CelebrationTesterIcon.tag = (string)flag2;
			bool flag3 = settingType == DebugSetting.Letters;
			SkipTutorialIcon.tag = (string)flag3;
			bool flag4 = settingType == DebugSetting.FrontScreen;
			MemoryBenchmarkIcon.tag = (string)flag4;
			bool flag5 = settingType == DebugSetting.TutorialLevel;
			FPSTestIcon.tag = (string)flag5;
			bool flag6 = settingType == DebugSetting.UseOSSet;
			WelcomePopupIcon.tag = (string)flag6;
			bool flag7 = settingType == DebugSetting.OSTesttime;
			WeeklyHuntIcon.tag = (string)flag7;
			bool flag8 = settingType == DebugSetting.OSSet;
			AdSystemTesterIcon.tag = (string)flag8;
		}
	}

	public void ExpandableListItemSelected()
	{
		//IL_004e: Expected Obj, but got I4
		//IL_0080: Expected Obj, but got I4
		bool flag = currentIconState;
		bool flag2 = (byte)((flag ? 1u : 0u) ^ 1u) != 0;
		currentIconState = flag2;
		bool flag3 = currentIconState;
		string text = (string)((flag3 ? 1 : 0) ^ 1);
		OffIcon.tag = text;
		bool flag4 = currentIconState;
		OnIcon.tag = (string)flag4;
	}

	public unsafe DebugSettingsHelper()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_33f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_33f6: Expected I, but got Unknown
		//IL_33ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_3404: Expected Obj, but got Unknown
		//IL_340d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3412: Expected Obj, but got Unknown
		//IL_341b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3420: Expected Obj, but got Unknown
		//IL_3429: Unknown result type (might be due to invalid IL or missing references)
		//IL_342e: Expected Obj, but got Unknown
		//IL_3437: Expected Obj, but got I4
		//IL_3440: Unknown result type (might be due to invalid IL or missing references)
		//IL_3445: Expected Obj, but got Unknown
		//IL_344e: Expected Obj, but got I4
		//IL_3457: Unknown result type (might be due to invalid IL or missing references)
		//IL_345c: Expected Obj, but got Unknown
		//IL_3465: Expected Obj, but got I4
		//IL_3474: Unknown result type (might be due to invalid IL or missing references)
		//IL_3479: Expected Obj, but got Unknown
		//IL_2c87: Expected Obj, but got I4
		//IL_2d37: Expected I, but got Obj
		//IL_2d4d: Expected Obj, but got I
		//IL_2d6a: Expected I, but got Obj
		//IL_137b: Expected Obj, but got I4
		//IL_3b51: Expected Obj, but got I
		//IL_3b6c: Expected I, but got Obj
		//IL_3b82: Expected Obj, but got I
		//IL_03c0: Expected Obj, but got I4
		//IL_0077: Expected Obj, but got I4
		//IL_2d86: Expected I, but got Obj
		//IL_2db6: Expected I, but got Obj
		//IL_14d6: Expected I, but got Obj
		//IL_14ec: Expected Obj, but got I
		//IL_0670: Expected I, but got Obj
		//IL_0686: Expected Obj, but got I
		//IL_010a: Expected I, but got Obj
		//IL_0120: Expected Obj, but got I
		//IL_2def: Expected I, but got Obj
		//IL_3a1b: Expected Obj, but got I
		//IL_35ce: Expected I, but got Obj
		//IL_35e9: Expected I, but got Obj
		//IL_35ff: Expected Obj, but got I
		//IL_037e: Expected Obj, but got I4
		//IL_2ddc: Expected I, but got Obj
		//IL_1517: Expected I, but got Obj
		//IL_06b1: Expected I, but got Obj
		//IL_014b: Expected I, but got Obj
		//IL_06fe: Expected I, but got Obj
		//IL_074b: Expected I, but got Obj
		//IL_0761: Expected Obj, but got I
		//IL_1595: Expected Obj, but got I4
		//IL_1f6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f74: Expected Obj, but got Unknown
		//IL_078c: Expected I, but got Obj
		//IL_0a28: Expected I, but got Obj
		//IL_0a3e: Expected Obj, but got I
		//IL_2e46: Expected I, but got Obj
		//IL_2e5c: Expected Obj, but got I
		//IL_3793: Expected Obj, but got I4
		//IL_3c04: Expected Obj, but got I
		//IL_0a69: Expected I, but got Obj
		//IL_2e87: Expected I, but got Obj
		//IL_0ab6: Expected I, but got Obj
		//IL_0acc: Expected Obj, but got I
		//IL_1e96: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e9b: Expected Obj, but got Unknown
		//IL_1cbc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cc1: Expected Obj, but got Unknown
		//IL_1be3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1be8: Expected Obj, but got Unknown
		//IL_3c1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c24: Expected Obj, but got Unknown
		//IL_3c2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c32: Expected Obj, but got Unknown
		//IL_3c5e: Expected Obj, but got I4
		//IL_3c67: Expected Obj, but got I4
		//IL_1dbd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dc2: Expected Obj, but got Unknown
		//IL_1b0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b0f: Expected Obj, but got Unknown
		//IL_19e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_19e6: Expected Obj, but got Unknown
		//IL_1807: Unknown result type (might be due to invalid IL or missing references)
		//IL_180c: Expected Obj, but got Unknown
		//IL_172e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1733: Expected Obj, but got Unknown
		//IL_14b9: Expected Obj, but got I4
		//IL_0af7: Expected I, but got Obj
		//IL_0202: Expected I, but got Obj
		//IL_0218: Expected Obj, but got I
		//IL_1908: Unknown result type (might be due to invalid IL or missing references)
		//IL_190d: Expected Obj, but got Unknown
		//IL_1655: Unknown result type (might be due to invalid IL or missing references)
		//IL_165a: Expected Obj, but got Unknown
		//IL_148b: Expected Obj, but got I4
		//IL_0ddd: Expected I, but got Obj
		//IL_0df3: Expected Obj, but got I
		//IL_0e10: Expected I, but got Obj
		//IL_34ea: Expected I, but got Obj
		//IL_350f: Expected I, but got Obj
		//IL_3525: Expected Obj, but got I
		//IL_38aa: Expected Obj, but got I
		//IL_3566: Expected I, but got Obj
		//IL_357c: Expected Obj, but got I
		//IL_0243: Expected I, but got Obj
		//IL_3d56: Expected I, but got Obj
		//IL_3d6c: Expected Obj, but got I
		//IL_32e2: Expected Obj, but got I
		//IL_3cf2: Expected I, but got Obj
		//IL_3d08: Expected Obj, but got I
		//IL_2b80: Expected Obj, but got I
		//IL_0e2c: Expected I, but got Obj
		//IL_0e5c: Expected I, but got Obj
		//IL_0eb1: Expected I, but got Obj
		//IL_0ec7: Expected Obj, but got I
		//IL_0290: Expected I, but got Obj
		//IL_1ef2: Expected I, but got Obj
		//IL_1f08: Expected Obj, but got I
		//IL_1d18: Expected I, but got Obj
		//IL_1d2e: Expected Obj, but got I
		//IL_1c3f: Expected I, but got Obj
		//IL_1c55: Expected Obj, but got I
		//IL_02dd: Expected I, but got Obj
		//IL_339a: Expected I, but got Obj
		//IL_3318: Unknown result type (might be due to invalid IL or missing references)
		//IL_331d: Expected Obj, but got Unknown
		//IL_2f2c: Expected I, but got Obj
		//IL_2f42: Expected Obj, but got I
		//IL_1e19: Expected I, but got Obj
		//IL_1e2f: Expected Obj, but got I
		//IL_1b66: Expected I, but got Obj
		//IL_1b7c: Expected Obj, but got I
		//IL_1a3d: Expected I, but got Obj
		//IL_1a53: Expected Obj, but got I
		//IL_1863: Expected I, but got Obj
		//IL_1879: Expected Obj, but got I
		//IL_178a: Expected I, but got Obj
		//IL_17a0: Expected Obj, but got I
		//IL_2c38: Expected I, but got Obj
		//IL_2bb6: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bbb: Expected Obj, but got Unknown
		//IL_0e82: Expected I, but got Obj
		//IL_0ef2: Expected I, but got Obj
		//IL_0f49: Expected I, but got Obj
		//IL_0f5f: Expected Obj, but got I
		//IL_0f7c: Expected I, but got Obj
		//IL_1f33: Expected I, but got Obj
		//IL_1d59: Expected I, but got Obj
		//IL_1c80: Expected I, but got Obj
		//IL_1964: Expected I, but got Obj
		//IL_197a: Expected Obj, but got I
		//IL_16b1: Expected I, but got Obj
		//IL_16c7: Expected Obj, but got I
		//IL_38e0: Expected Obj, but got I
		//IL_334e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3353: Expected Obj, but got Unknown
		//IL_2fe6: Expected I, but got Obj
		//IL_2ffc: Expected Obj, but got I
		//IL_2f6d: Expected I, but got Obj
		//IL_1e5a: Expected I, but got Obj
		//IL_1ba7: Expected I, but got Obj
		//IL_1a7e: Expected I, but got Obj
		//IL_18a4: Expected I, but got Obj
		//IL_17cb: Expected I, but got Obj
		//IL_2bec: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bf1: Expected Obj, but got Unknown
		//IL_0f98: Expected I, but got Obj
		//IL_0fc8: Expected I, but got Obj
		//IL_101d: Expected I, but got Obj
		//IL_1033: Expected Obj, but got I
		//IL_19a5: Expected I, but got Obj
		//IL_16f2: Expected I, but got Obj
		//IL_3904: Expected VT, but got Obj
		//IL_3915: Invalid comparison between F4 and I
		//IL_30a0: Expected I, but got Obj
		//IL_30b6: Expected Obj, but got I
		//IL_3027: Expected I, but got Obj
		//IL_0fee: Expected I, but got Obj
		//IL_105e: Expected I, but got Obj
		//IL_115e: Expected I, but got Obj
		//IL_1174: Expected Obj, but got I
		//IL_10a6: Expected VT, but got Obj
		//IL_10b4: Expected I, but got Obj
		//IL_10ca: Expected Obj, but got I
		//IL_3946: Expected VT, but got Obj
		//IL_3957: Invalid comparison between F4 and I
		//IL_3140: Expected I, but got Obj
		//IL_3156: Expected Obj, but got I
		//IL_30e1: Expected I, but got Obj
		//IL_119f: Expected I, but got Obj
		//IL_10f5: Expected I, but got Obj
		//IL_11e7: Expected VT, but got Obj
		//IL_11f5: Expected I, but got Obj
		//IL_120b: Expected Obj, but got I
		//IL_31e0: Expected I, but got Obj
		//IL_31f6: Expected Obj, but got I
		//IL_3181: Expected I, but got Obj
		//IL_1236: Expected I, but got Obj
		//IL_3221: Expected I, but got Obj
		//IL_12bc: Expected I, but got Obj
		//IL_12d2: Expected Obj, but got I
		//IL_0bdc: Expected I, but got Obj
		//IL_0bf2: Expected Obj, but got I
		//IL_397f: Expected I4, but got Obj
		//IL_12fd: Expected I, but got Obj
		//IL_0c1d: Expected I, but got Obj
		//IL_0c6a: Expected I, but got Obj
		//IL_0c80: Expected Obj, but got I
		//IL_3808: Expected I, but got Obj
		//IL_382d: Expected I, but got Obj
		//IL_3843: Expected Obj, but got I
		//IL_0cab: Expected I, but got Obj
		//IL_0cf8: Expected I, but got Obj
		//IL_0b4e: Expected I, but got Obj
		//IL_0b64: Expected Obj, but got I
		//IL_0b8f: Expected I, but got Obj
		//IL_099a: Expected I, but got Obj
		//IL_09b0: Expected Obj, but got I
		//IL_3769: Expected I4, but got Obj
		//IL_09db: Expected I, but got Obj
		//IL_0839: Expected I, but got Obj
		//IL_084f: Expected Obj, but got I
		//IL_369d: Expected I, but got Obj
		//IL_36c2: Expected I, but got Obj
		//IL_36d8: Expected Obj, but got I
		//IL_3719: Expected I, but got Obj
		//IL_372f: Expected Obj, but got I
		//IL_087a: Expected I, but got Obj
		//IL_08c7: Expected I, but got Obj
		//IL_0914: Expected I, but got Obj
		//IL_2aa8: Unknown result type (might be due to invalid IL or missing references)
		//IL_2aad: Expected Obj, but got Unknown
		//IL_2ab6: Unknown result type (might be due to invalid IL or missing references)
		//IL_2abb: Expected Obj, but got Unknown
		//IL_2ae7: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 80;
		nint num = (nint)(obj2 + 56);
		object obj3 = obj2 + 40;
		object obj4 = obj2 + 16;
		object obj5 = obj2 + 4;
		IFormatProvider formatProvider = (IFormatProvider)(obj2 + 48);
		formatProvider = (IFormatProvider)0;
		IFormatProvider formatProvider2 = (IFormatProvider)(obj2 + 44);
		formatProvider2 = (IFormatProvider)0;
		object obj6 = obj2 + 24;
		obj6 = 0;
		_ = 0;
		object obj7 = obj2 + 8;
		obj7 = obj;
		_ = -1;
		SelectPopupButton popupList = PopupList;
		if (~(popupList.returningFromSelect__BackingField ? 1u : 0u) != 0)
		{
			return;
		}
		if (_settingType > DebugSetting.FPSTargetFramerate)
		{
			if (_settingType > DebugSetting.NotificationType)
			{
				object obj8 = _settingType - 58;
				if (_settingType != DebugSetting.QueuedEnvironment)
				{
					if ((nint)obj8 == 1 || (nint)obj8 == 2 || (nint)obj8 != 3)
					{
						return;
					}
					SelectPopupButton popupList2 = PopupList;
					string text = popupList2.value__BackingField;
					if (popupList2.value__BackingField == null || text.m_stringLength == 0)
					{
						return;
					}
					nint num2 = (nint)typeof(Type);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v598 @ S0_v970 (Il2CppClass<System.Type>)+BA]");
					object obj9 = (nint)0 & (nint)0x200;
					if (obj9 != null)
					{
						nint num3 = (nint)typeof(Type);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v628 @ S0_v981 (Il2CppClass<System.Type>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					obj2 = typeof(DebugSettingsPopup.DebugGuidelineType);
					((IntPtr*)num)->m_value = (void*)(nint)obj2;
					Type enumType = Type.internal_from_handle((IntPtr)num);
					SelectPopupButton popupList3 = PopupList;
					nint num4 = (nint)typeof(Enum);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v848 @ S2_v127 (Il2CppClass<System.Enum>)+BA]");
					object obj10 = (nint)0 & (nint)0x200;
					if (obj10 != null)
					{
						nint num5 = (nint)typeof(Enum);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v911 @ S2_v133 (Il2CppClass<System.Enum>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					string text2 = Enum.GetName(enumType, popupList3.value__BackingField);
					nint num6 = (nint)typeof(DebugSettingsPopup);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v974 @ S1_v458 (Il2CppClass<DebugSettingsPopup>)+BA]");
					object obj11 = (nint)0 & (nint)0x200;
					if (obj11 != null)
					{
						nint num7 = (nint)typeof(DebugSettingsPopup);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1169 @ S1_v465 (Il2CppClass<DebugSettingsPopup>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					throw new NullReferenceException();
				}
				SelectPopupButton popupList4 = PopupList;
				nint num8 = (nint)typeof(DebugQueuedEnvironments);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ S1_v440 (Il2CppClass<SYBO.Subway.Utilities.DebugQueuedEnvironments>)+BA]");
				object obj12 = (nint)0 & (nint)0x200;
				if (obj12 != null)
				{
					nint num9 = (nint)typeof(DebugQueuedEnvironments);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ S1_v445 (Il2CppClass<SYBO.Subway.Utilities.DebugQueuedEnvironments>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				((PlaceholderPrefab)(object)popupList4.multipleValues__BackingField).Initialize();
				return;
			}
			if (_settingType == DebugSetting.FPSAutoLength)
			{
				bool flag = IOSViewController._GetIsSimulator();
				SelectPopupButton popupList5 = PopupList;
				TypeCode typeCode = ((int*)popupList5.value__BackingField)->GetTypeCode();
				object obj13 = (int)typeCode * 60;
				if (obj13 == null)
				{
					_ = 600;
				}
				return;
			}
			object obj14 = _settingType - 31;
			if (_settingType != DebugSetting.LimitedCharacterPopupType)
			{
				if ((nint)obj14 == 1 || (nint)obj14 == 2)
				{
					return;
				}
				if ((nint)obj14 != 3)
				{
					if ((nint)obj14 == 4 || (nint)obj14 == 5)
					{
						return;
					}
					if ((nint)obj14 != 6)
					{
						if ((nint)obj14 != 7)
						{
							if ((nint)obj14 != 8)
							{
								if ((nint)obj14 != 9)
								{
									if ((nint)obj14 != 10)
									{
										if ((nint)obj14 == 11 || (nint)obj14 == 12 || (nint)obj14 == 13)
										{
											return;
										}
										if ((nint)obj14 != 14)
										{
											if ((nint)obj14 != 15)
											{
												if ((nint)obj14 == 16 || (nint)obj14 == 17 || (nint)obj14 == 18)
												{
													return;
												}
												if ((nint)obj14 != 19)
												{
													if ((nint)obj14 != 20)
													{
														if ((nint)obj14 == 21 || (nint)obj14 != 22)
														{
															return;
														}
														SelectPopupButton popupList6 = PopupList;
														string text3 = popupList6.value__BackingField;
														if (popupList6.value__BackingField == null || text3.m_stringLength == 0)
														{
															return;
														}
														nint num10 = (nint)typeof(Type);
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2182 @ S0_v918 (Il2CppClass<System.Type>)+BA]");
														object obj15 = (nint)0 & (nint)0x200;
														if (obj15 != null)
														{
															nint num11 = (nint)typeof(Type);
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2203 @ S0_v940 (Il2CppClass<System.Type>)+74]");
															if ((nint)0 == 0)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
															}
														}
														obj5 = typeof(DebugSettingsPopup.DebugNotificationType);
														((IntPtr*)num)->m_value = (void*)(nint)obj5;
														Type enumType2 = Type.internal_from_handle((IntPtr)num);
														SelectPopupButton popupList7 = PopupList;
														nint num12 = (nint)typeof(Enum);
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2232 @ S2_v114 (Il2CppClass<System.Enum>)+BA]");
														object obj16 = (nint)0 & (nint)0x200;
														if (obj16 != null)
														{
															nint num13 = (nint)typeof(Enum);
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2241 @ S2_v121 (Il2CppClass<System.Enum>)+74]");
															if ((nint)0 == 0)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
															}
														}
														string text4 = Enum.GetName(enumType2, popupList7.value__BackingField);
														nint num14 = (nint)typeof(DebugSettingsPopup);
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2258 @ S0_v928 (Il2CppClass<DebugSettingsPopup>)+BA]");
														object obj17 = (nint)0 & (nint)0x200;
														if (obj17 != null)
														{
															nint num15 = (nint)typeof(DebugSettingsPopup);
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2272 @ S0_v934 (Il2CppClass<DebugSettingsPopup>)+74]");
															if ((nint)0 == 0)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
															}
														}
														throw new NullReferenceException();
													}
													SelectPopupButton popupList8 = PopupList;
													if (!((int*)popupList8.value__BackingField)->System_002EIConvertible_002EToBoolean(formatProvider2))
													{
														return;
													}
													nint num16 = (nint)typeof(DebugSettingsPopup);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2097 @ S0_v899 (Il2CppClass<DebugSettingsPopup>)+BA]");
													object obj18 = (nint)0 & (nint)0x200;
													if (obj18 != null)
													{
														nint num17 = (nint)typeof(DebugSettingsPopup);
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2141 @ S0_v905 (Il2CppClass<DebugSettingsPopup>)+74]");
														if ((nint)0 == 0)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
														}
													}
													DebugSettingsPopup.amountOfMissionSetsToSkip = (int)formatProvider2;
													return;
												}
												SelectPopupButton popupList9 = PopupList;
												nint num18 = (nint)typeof(SubwayBenchmarkContainer);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1860 @ S1_v409 (Il2CppClass<SYBO.Subway.Benchmarking.SubwayBenchmarkContainer>)+BA]");
												object obj19 = (nint)0 & (nint)0x200;
												if (obj19 != null)
												{
													nint num19 = (nint)typeof(SubwayBenchmarkContainer);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1963 @ S1_v414 (Il2CppClass<SYBO.Subway.Benchmarking.SubwayBenchmarkContainer>)+74]");
													if ((nint)0 == 0)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
													}
												}
												((SubwayMemoryBenchmark)(object)popupList9.value__BackingField).Initialize();
												return;
											}
											nint num20 = (nint)typeof(Globals);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1478 @ S0_v846 (Il2CppClass<Globals>)+BA]");
											object obj20 = (nint)0 & (nint)0x200;
											if (obj20 != null)
											{
												nint num21 = (nint)typeof(Globals);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1647 @ S0_v882 (Il2CppClass<Globals>)+74]");
												if ((nint)0 == 0)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
												}
											}
											if (~(Globals.DEBUG ? 1u : 0u) != 0)
											{
												return;
											}
											nint num22 = (nint)typeof(Type);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1735 @ S0_v857 (Il2CppClass<System.Type>)+BA]");
											object obj21 = (nint)0 & (nint)0x200;
											if (obj21 != null)
											{
												nint num23 = (nint)typeof(Type);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1776 @ S0_v878 (Il2CppClass<System.Type>)+74]");
												if ((nint)0 == 0)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
												}
											}
											obj4 = typeof(DeviceInfo.PerformanceLevel);
											((IntPtr*)num)->m_value = (void*)(nint)obj4;
											Type enumType3 = Type.internal_from_handle((IntPtr)num);
											SelectPopupButton popupList10 = PopupList;
											nint num24 = (nint)typeof(Enum);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1868 @ S2_v102 (Il2CppClass<System.Enum>)+BA]");
											object obj22 = (nint)0 & (nint)0x200;
											if (obj22 != null)
											{
												nint num25 = (nint)typeof(Enum);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1969 @ S2_v107 (Il2CppClass<System.Enum>)+74]");
												if ((nint)0 == 0)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
												}
											}
											string text5 = Enum.GetName(enumType3, popupList10.value__BackingField);
											throw new NullReferenceException();
										}
										SelectPopupButton popupList11 = PopupList;
										if (!((int*)popupList11.value__BackingField)->System_002EIConvertible_002EToBoolean(formatProvider))
										{
											return;
										}
										nint num26 = (nint)typeof(DebugSettingsPopup);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1660 @ S0_v833 (Il2CppClass<DebugSettingsPopup>)+BA]");
										object obj23 = (nint)0 & (nint)0x200;
										if (obj23 != null)
										{
											nint num27 = (nint)typeof(DebugSettingsPopup);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1740 @ S0_v839 (Il2CppClass<DebugSettingsPopup>)+74]");
											if ((nint)0 == 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
											}
										}
										DebugSettingsPopup.amountOfHuntTokensToReward = (int)formatProvider;
										return;
									}
									SelectPopupButton popupList12 = PopupList;
									float timeScaleInMenuOverrideSelectedValue = ((BinaryReader)(object)popupList12.value__BackingField).ReadSingle();
									nint num28 = (nint)typeof(DebugSettingsPopup);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1179 @ S0_v805 (Il2CppClass<DebugSettingsPopup>)+BA]");
									object obj24 = (nint)0 & (nint)0x200;
									if (obj24 != null)
									{
										nint num29 = (nint)typeof(DebugSettingsPopup);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1255 @ S0_v819 (Il2CppClass<DebugSettingsPopup>)+74]");
										if ((nint)0 == 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
										}
									}
									DebugSettingsPopup.TimeScaleInMenuOverrideSelectedValue = timeScaleInMenuOverrideSelectedValue;
									_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
									float timeScaleInMenuOverrideSelectedValue2 = DebugSettingsPopup.TimeScaleInMenuOverrideSelectedValue;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1271 @ S1_v376 (T)+10]");
									if (timeScaleInMenuOverrideSelectedValue2 == 0f)
									{
										return;
									}
									_00210 val2 = (_00210)SingletonMonoBehaviour<>.Instantiate();
									nint num30 = (nint)typeof(DebugSettingsPopup);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1484 @ S1_v379 (Il2CppClass<DebugSettingsPopup>)+BA]");
									object obj25 = (nint)0 & (nint)0x200;
									if (obj25 != null)
									{
										nint num31 = (nint)typeof(DebugSettingsPopup);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1666 @ S1_v386 (Il2CppClass<DebugSettingsPopup>)+74]");
										if ((nint)0 == 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
										}
									}
									_ = DebugSettingsPopup.TimeScaleInMenuOverrideSelectedValue;
									return;
								}
								SelectPopupButton popupList13 = PopupList;
								float timeScaleInGameOverrideSelectedValue = ((BinaryReader)(object)popupList13.value__BackingField).ReadSingle();
								nint num32 = (nint)typeof(DebugSettingsPopup);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v984 @ S0_v780 (Il2CppClass<DebugSettingsPopup>)+BA]");
								object obj26 = (nint)0 & (nint)0x200;
								if (obj26 != null)
								{
									nint num33 = (nint)typeof(DebugSettingsPopup);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1185 @ S0_v794 (Il2CppClass<DebugSettingsPopup>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								DebugSettingsPopup.TimeScaleInGameOverrideSelectedValue = timeScaleInGameOverrideSelectedValue;
								_00210 val3 = (_00210)SingletonMonoBehaviour<>.Instantiate();
								float timeScaleInGameOverrideSelectedValue2 = DebugSettingsPopup.TimeScaleInGameOverrideSelectedValue;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1201 @ S1_v355 (T)+14]");
								if (timeScaleInGameOverrideSelectedValue2 == 0f)
								{
									return;
								}
								_00210 val4 = (_00210)SingletonMonoBehaviour<>.Instantiate();
								nint num34 = (nint)typeof(DebugSettingsPopup);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1400 @ S1_v358 (Il2CppClass<DebugSettingsPopup>)+BA]");
								object obj27 = (nint)0 & (nint)0x200;
								if (obj27 != null)
								{
									nint num35 = (nint)typeof(DebugSettingsPopup);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1489 @ S1_v365 (Il2CppClass<DebugSettingsPopup>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								_ = DebugSettingsPopup.TimeScaleInGameOverrideSelectedValue;
								return;
							}
							SelectPopupButton popupList14 = PopupList;
							nint num36 = (nint)typeof(DebugSettingsPopup);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v858 @ S0_v762 (Il2CppClass<DebugSettingsPopup>)+BA]");
							object obj28 = (nint)0 & (nint)0x200;
							bool flag2 = obj28 == null;
							nint num37 = (nint)typeof(DebugSettingsPopup);
							if (!flag2)
							{
								nint num38 = (nint)typeof(DebugSettingsPopup);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v926 @ S0_v769 (Il2CppClass<DebugSettingsPopup>)+74]");
								bool flag3 = (nint)0 == 0;
								bool flag4 = !flag3;
								num37 = (nint)typeof(DebugSettingsPopup);
								if (!flag4)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									num37 = (nint)typeof(DebugSettingsPopup);
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ L0_v134 (Il2CppClass<DebugSettingsPopup>)+5C]");
							object obj29 = (nint)0 + (nint)12;
							obj29 = popupList14.multipleValues__BackingField;
							return;
						}
						SelectPopupButton popupList15 = PopupList;
						TypeCode typeCode2 = ((int*)popupList15.value__BackingField)->GetTypeCode();
						nint num39 = (nint)typeof(DebugSettingsPopup);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v865 @ S0_v746 (Il2CppClass<DebugSettingsPopup>)+BA]");
						object obj30 = (nint)0 & (nint)0x200;
						if (obj30 != null)
						{
							nint num40 = (nint)typeof(DebugSettingsPopup);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v936 @ S0_v752 (Il2CppClass<DebugSettingsPopup>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						DebugSettingsPopup.completeAwardsTiersSelectedTiers = (int)typeCode2;
						return;
					}
					SelectPopupButton popupList16 = PopupList;
					nint num41 = (nint)typeof(DebugSettingsPopup);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v608 @ S0_v728 (Il2CppClass<DebugSettingsPopup>)+BA]");
					object obj31 = (nint)0 & (nint)0x200;
					bool flag5 = obj31 == null;
					nint num42 = (nint)typeof(DebugSettingsPopup);
					if (!flag5)
					{
						nint num43 = (nint)typeof(DebugSettingsPopup);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v649 @ S0_v735 (Il2CppClass<DebugSettingsPopup>)+74]");
						bool flag6 = (nint)0 == 0;
						bool flag7 = !flag6;
						num42 = (nint)typeof(DebugSettingsPopup);
						if (!flag7)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							num42 = (nint)typeof(DebugSettingsPopup);
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ L0_v128 (Il2CppClass<DebugSettingsPopup>)+5C]");
					object obj32 = (nint)0 + (nint)4;
					obj32 = popupList16.multipleValues__BackingField;
					return;
				}
				nint num44 = (nint)typeof(Boards);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ S0_v699 (Il2CppClass<Info.Boards>)+BA]");
				object obj33 = (nint)0 & (nint)0x200;
				if (obj33 != null)
				{
					nint num45 = (nint)typeof(Boards);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v494 @ S0_v720 (Il2CppClass<Info.Boards>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool isVideoAddsSupported = EarnCoinsData.isVideoAddsSupported;
				SelectPopupButton popupList17 = PopupList;
				int num46 = Array.IndexOf((string[])isVideoAddsSupported, popupList17.value__BackingField);
				if (num46 == -1)
				{
					return;
				}
				nint num47 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v660 @ S0_v708 (Il2CppClass<Globals>)+BA]");
				object obj34 = (nint)0 & (nint)0x200;
				if (obj34 != null)
				{
					nint num48 = (nint)typeof(Globals);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v872 @ S0_v714 (Il2CppClass<Globals>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Globals.debugLimitedBoardPopupId = (Boards.BoardId)num46;
				return;
			}
			nint num49 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ S0_v670 (Il2CppClass<System.Type>)+BA]");
			object obj35 = (nint)0 & (nint)0x200;
			if (obj35 != null)
			{
				nint num50 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ S0_v694 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj3 = typeof(Characters.CharacterId);
			((IntPtr*)num)->m_value = (void*)(nint)obj3;
			Type enumType4 = Type.internal_from_handle((IntPtr)num);
			nint num51 = (nint)typeof(Enum);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ S1_v319 (Il2CppClass<System.Enum>)+BA]");
			object obj36 = (nint)0 & (nint)0x200;
			if (obj36 != null)
			{
				nint num52 = (nint)typeof(Enum);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ S1_v330 (Il2CppClass<System.Enum>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string[] array = Enum.InternalGetNames((System.RuntimeType)enumType4);
			SelectPopupButton popupList18 = PopupList;
			int num53 = Array.IndexOf(array, popupList18.value__BackingField);
			if (num53 == -1)
			{
				return;
			}
			nint num54 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v615 @ S0_v682 (Il2CppClass<Globals>)+BA]");
			object obj37 = (nint)0 & (nint)0x200;
			if (obj37 != null)
			{
				nint num55 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v666 @ S0_v688 (Il2CppClass<Globals>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Globals.debugLimitedCharacterPopupId = (Characters.CharacterId)num53;
			return;
		}
		if (_settingType > DebugSetting.InterstitialProvider)
		{
			object obj38 = _settingType - 14;
			if (_settingType != DebugSetting.VideoAdsProvider)
			{
				if ((nint)obj38 != 1 && (nint)obj38 != 2 && (nint)obj38 != 3 && (nint)obj38 != 4 && (nint)obj38 == 5)
				{
					SelectPopupButton popupList19 = PopupList;
					bool flag8 = popupList19.value__BackingField != "Default";
					bool flag9 = IOSViewController._GetIsSimulator();
					if (flag8)
					{
						((FPSLog)flag9).SetFPSAutoLength();
						return;
					}
					SelectPopupButton popupList20 = PopupList;
					TypeCode typeCode3 = ((int*)popupList20.value__BackingField)->GetTypeCode();
					((FPSLog)flag9).SetFPSAutoLength((int)typeCode3);
				}
				return;
			}
			nint num56 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ S0_v277 (Il2CppClass<Globals>)+BA]");
			object obj39 = (nint)0 & (nint)0x200;
			if (obj39 != null)
			{
				nint num57 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ S0_v648 (Il2CppClass<Globals>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Globals.DEBUG_VIDEOADS_PROVIDERS_ADCOLONY = false;
			Globals.DEBUG_VIDEOADS_PROVIDERS_FLURRY = false;
			Globals.DEBUG_VIDEOADS_PROVIDERS_VUNGLE = false;
			Globals.DEBUG_VIDEOADS_PROVIDERS_INMOBI = false;
			Globals.DEBUG_VIDEOADS_PROVIDERS_TAPJOY = false;
			Globals.DEBUG_VIDEOADS_PROVIDERS_CHARTBOOST = false;
			Globals.DEBUG_VIDEOADS_PROVIDERS_SUPERSONIC = false;
			Globals.DEBUG_VIDEOADS_PROVIDERS_FACEBOOK = false;
			Globals.DEBUG_VIDEOADS_PROVIDERS_MOBVISTA = false;
			Globals.DEBUG_VIDEOADS_PROVIDERS_YEAH_MOBI = false;
			SelectPopupButton popupList21 = PopupList;
			Dictionary<string, string>.ValueCollection values = popupList21.multipleValues__BackingField.Values;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @773C");
			obj6 = (object)((IntPtr*)num)->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (System.IntPtr)+8]");
			_ = 0;
			object obj40 = default;
			object obj41 = default;
			object obj43 = default;
			object obj46 = default;
			object obj49 = default;
			object obj52 = default;
			object obj55 = default;
			object obj58 = default;
			object obj61 = default;
			object obj64 = default;
			object obj67 = default;
			object obj70 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj40 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if ((nint)obj41 < -2106716891)
				{
					if ((nint)obj41 < 1178882339)
					{
						if ((nint)obj41 < 1178882338)
						{
							object obj42 = obj41 - 759091912;
							if (obj42 != null)
							{
								continue;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
							if (obj43 == null)
							{
								continue;
							}
							nint num58 = (nint)typeof(Globals);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1794 @ S0_v630 (Il2CppClass<Globals>)+BA]");
							object obj44 = (nint)0 & (nint)0x200;
							if (obj44 != null)
							{
								nint num59 = (nint)typeof(Globals);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1874 @ S0_v636 (Il2CppClass<Globals>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
								}
							}
							Globals.DEBUG_VIDEOADS_PROVIDERS_SUPERSONIC = true;
							continue;
						}
						object obj45 = obj41 - 1178882338;
						if (obj45 != null)
						{
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
						if (obj46 == null)
						{
							continue;
						}
						nint num60 = (nint)typeof(Globals);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1801 @ S0_v606 (Il2CppClass<Globals>)+BA]");
						object obj47 = (nint)0 & (nint)0x200;
						if (obj47 != null)
						{
							nint num61 = (nint)typeof(Globals);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1881 @ S0_v612 (Il2CppClass<Globals>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
							}
						}
						Globals.DEBUG_VIDEOADS_PROVIDERS_MOBVISTA = true;
						continue;
					}
					if ((nint)obj41 < 1873702865)
					{
						object obj48 = obj41 - -2106716892;
						if (obj48 != null)
						{
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
						if (obj49 == null)
						{
							continue;
						}
						nint num62 = (nint)typeof(Globals);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1808 @ S0_v580 (Il2CppClass<Globals>)+BA]");
						object obj50 = (nint)0 & (nint)0x200;
						if (obj50 != null)
						{
							nint num63 = (nint)typeof(Globals);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1888 @ S0_v586 (Il2CppClass<Globals>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
							}
						}
						Globals.DEBUG_VIDEOADS_PROVIDERS_TAPJOY = true;
						continue;
					}
					if ((nint)obj41 < 1884955870)
					{
						object obj51 = obj41 - 1873702865;
						if (obj51 != null)
						{
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
						if (obj52 == null)
						{
							continue;
						}
						nint num64 = (nint)typeof(Globals);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1896 @ S0_v556 (Il2CppClass<Globals>)+BA]");
						object obj53 = (nint)0 & (nint)0x200;
						if (obj53 != null)
						{
							nint num65 = (nint)typeof(Globals);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1989 @ S0_v562 (Il2CppClass<Globals>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
							}
						}
						Globals.DEBUG_VIDEOADS_PROVIDERS_FLURRY = true;
						continue;
					}
					object obj54 = obj41 - 1884955870;
					if (obj54 != null)
					{
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					if (obj55 == null)
					{
						continue;
					}
					nint num66 = (nint)typeof(Globals);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1903 @ S0_v532 (Il2CppClass<Globals>)+BA]");
					object obj56 = (nint)0 & (nint)0x200;
					if (obj56 != null)
					{
						nint num67 = (nint)typeof(Globals);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2001 @ S0_v538 (Il2CppClass<Globals>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						}
					}
					Globals.DEBUG_VIDEOADS_PROVIDERS_CHARTBOOST = true;
					continue;
				}
				if ((nint)obj41 < -1980256856)
				{
					if ((nint)obj41 < -1980256857)
					{
						object obj57 = obj41 - -2035971584;
						if (obj57 != null)
						{
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
						if (obj58 == null)
						{
							continue;
						}
						nint num68 = (nint)typeof(Globals);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1815 @ S0_v501 (Il2CppClass<Globals>)+BA]");
						object obj59 = (nint)0 & (nint)0x200;
						if (obj59 != null)
						{
							nint num69 = (nint)typeof(Globals);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1909 @ S0_v507 (Il2CppClass<Globals>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
							}
						}
						Globals.DEBUG_VIDEOADS_PROVIDERS_VUNGLE = true;
						continue;
					}
					object obj60 = obj41 - -1980256857;
					if (obj60 != null)
					{
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					if (obj61 == null)
					{
						continue;
					}
					nint num70 = (nint)typeof(Globals);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1822 @ S0_v477 (Il2CppClass<Globals>)+BA]");
					object obj62 = (nint)0 & (nint)0x200;
					if (obj62 != null)
					{
						nint num71 = (nint)typeof(Globals);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1916 @ S0_v483 (Il2CppClass<Globals>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						}
					}
					Globals.DEBUG_VIDEOADS_PROVIDERS_YEAH_MOBI = true;
					continue;
				}
				if ((nint)obj41 < -1405631919)
				{
					object obj63 = obj41 - -1904689034;
					if (obj63 != null)
					{
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					if (obj64 == null)
					{
						continue;
					}
					nint num72 = (nint)typeof(Globals);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1829 @ S0_v451 (Il2CppClass<Globals>)+BA]");
					object obj65 = (nint)0 & (nint)0x200;
					if (obj65 != null)
					{
						nint num73 = (nint)typeof(Globals);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1923 @ S0_v457 (Il2CppClass<Globals>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						}
					}
					Globals.DEBUG_VIDEOADS_PROVIDERS_ADCOLONY = true;
					continue;
				}
				if ((nint)obj41 < -899344965)
				{
					object obj66 = obj41 - -1405631919;
					if (obj66 != null)
					{
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					if (obj67 == null)
					{
						continue;
					}
					nint num74 = (nint)typeof(Globals);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1931 @ S0_v427 (Il2CppClass<Globals>)+BA]");
					object obj68 = (nint)0 & (nint)0x200;
					if (obj68 != null)
					{
						nint num75 = (nint)typeof(Globals);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2025 @ S0_v433 (Il2CppClass<Globals>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						}
					}
					Globals.DEBUG_VIDEOADS_PROVIDERS_FACEBOOK = true;
					continue;
				}
				object obj69 = obj41 - -899344965;
				if (obj69 != null)
				{
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				if (obj70 == null)
				{
					continue;
				}
				nint num76 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1938 @ S0_v403 (Il2CppClass<Globals>)+BA]");
				object obj71 = (nint)0 & (nint)0x200;
				if (obj71 != null)
				{
					nint num77 = (nint)typeof(Globals);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2032 @ S0_v409 (Il2CppClass<Globals>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Globals.DEBUG_VIDEOADS_PROVIDERS_INMOBI = true;
			}
			object obj72 = 184;
			object obj73 = obj72 - 89;
			if ((nint)obj72 != 89 && (nint)obj73 != 1)
			{
				if ((nint)obj73 != 2 && (nint)obj73 != 3 && (nint)obj73 != 4 && (nint)obj73 != 5 && (nint)obj73 != 6 && (nint)obj73 != 7 && (nint)obj73 != 8 && (nint)obj73 != 9)
				{
					if ((nint)obj73 == 10)
					{
						goto IL_2aec;
					}
					if ((nint)obj73 != 11 && (nint)obj73 != 12)
					{
						if ((nint)obj73 == 13)
						{
							goto IL_2aec;
						}
						if ((nint)obj73 != 14 && (nint)obj73 != 15)
						{
							if ((nint)obj73 == 16)
							{
								goto IL_2aec;
							}
							if ((nint)obj73 != 17 && (nint)obj73 != 18)
							{
								if ((nint)obj73 == 19)
								{
									goto IL_2aec;
								}
								if ((nint)obj73 != 20 && (nint)obj73 != 21)
								{
									if ((nint)obj73 == 22)
									{
										goto IL_2aec;
									}
									if ((nint)obj73 != 23 && (nint)obj73 != 24)
									{
										if ((nint)obj73 == 25)
										{
											goto IL_2aec;
										}
										if ((nint)obj73 != 26 && (nint)obj73 != 27)
										{
											if ((nint)obj73 == 28)
											{
												goto IL_2aec;
											}
											if ((nint)obj73 != 29 && (nint)obj73 != 30)
											{
												if ((nint)obj73 == 31)
												{
													goto IL_2aec;
												}
												if ((nint)obj73 != 32 && (nint)obj73 != 33)
												{
													if ((nint)obj73 == 34)
													{
														goto IL_2aec;
													}
													if ((nint)obj73 != 35 && (nint)obj73 != 36 && (nint)obj73 != 37)
													{
														if ((nint)obj73 == 38)
														{
															goto IL_2aec;
														}
														if ((nint)obj73 != 39 && (nint)obj73 != 40 && (nint)obj73 != 41 && (nint)obj73 != 42)
														{
															if ((nint)obj73 == 43)
															{
																goto IL_2aec;
															}
															if ((nint)obj73 != 44 && (nint)obj73 != 45 && (nint)obj73 != 46 && (nint)obj73 != 47 && (nint)obj73 != 48 && (nint)obj73 != 49 && (nint)obj73 != 50 && (nint)obj73 != 51 && (nint)obj73 != 52 && (nint)obj73 != 53 && (nint)obj73 != 54 && (nint)obj73 != 55 && (nint)obj73 != 56 && (nint)obj73 != 57 && (nint)obj73 != 58 && (nint)obj73 != 59 && (nint)obj73 != 60 && (nint)obj73 != 61 && (nint)obj73 != 62 && (nint)obj73 != 63 && (nint)obj73 != 64 && (nint)obj73 != 65 && (nint)obj73 != 66 && (nint)obj73 != 67 && (nint)obj73 != 68 && (nint)obj73 != 69 && (nint)obj73 != 70 && (nint)obj73 != 71 && (nint)obj73 != 72 && (nint)obj73 != 73 && (nint)obj73 != 74 && (nint)obj73 != 75 && (nint)obj73 != 76 && (nint)obj73 != 77 && (nint)obj73 != 78 && (nint)obj73 != 79 && (nint)obj73 != 80 && (nint)obj73 != 81 && (nint)obj73 != 82 && (nint)obj73 != 83 && (nint)obj73 != 84 && (nint)obj73 != 85 && (nint)obj73 != 86 && (nint)obj73 != 87 && (nint)obj73 != 88 && (nint)obj73 != 89 && (nint)obj73 != 90 && (nint)obj73 != 91)
															{
																if ((nint)obj73 == 92)
																{
																	goto IL_2aec;
																}
																if ((nint)obj73 != 93 && (nint)obj73 != 94 && (nint)obj73 == 95)
																{
																	object obj74 = obj7 + 4;
																	object obj75 = obj74 + 1;
																	obj74 = obj75;
																	object obj76 = obj75 << 2;
																	object obj77 = obj7 + obj76;
																	obj77 = 985;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_2b45;
			}
			goto IL_2aec;
		}
		object obj78 = _settingType - 8;
		if (_settingType != DebugSetting.OSSet)
		{
			if ((nint)obj78 == 1 || (nint)obj78 == 2 || (nint)obj78 == 3 || (nint)obj78 != 4)
			{
				return;
			}
			nint num78 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ S0_v75 (Il2CppClass<Globals>)+BA]");
			object obj79 = (nint)0 & (nint)0x200;
			if (obj79 != null)
			{
				nint num79 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v560 @ S0_v268 (Il2CppClass<Globals>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Globals.DEBUG_INTERSTITIAL_PROVIDER_INMOBI = false;
			Globals.DEBUG_INTERSTITIAL_PROVIDER_CHARTBOOST = false;
			Globals.DEBUG_INTERSTITIAL_PROVIDER_SUPERSONIC = false;
			Globals.DEBUG_INTERSTITIAL_PROVIDER_FACEBOOK = false;
			Globals.DEBUG_INTERSTITIAL_PROVIDER_YEAHMOBI = false;
			SelectPopupButton popupList22 = PopupList;
			Dictionary<string, string>.ValueCollection values2 = popupList22.multipleValues__BackingField.Values;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @773C");
			obj6 = (object)((IntPtr*)num)->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (System.IntPtr)+8]");
			_ = 0;
			object obj80 = default;
			object obj81 = default;
			object obj83 = default;
			object obj85 = default;
			object obj87 = default;
			object obj89 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj80 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				if (obj81 != null)
				{
					nint num80 = (nint)typeof(Globals);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1718 @ S0_v253 (Il2CppClass<Globals>)+BA]");
					object obj82 = (nint)0 & (nint)0x200;
					if (obj82 != null)
					{
						nint num81 = (nint)typeof(Globals);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1758 @ S0_v259 (Il2CppClass<Globals>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						}
					}
					Globals.DEBUG_INTERSTITIAL_PROVIDER_INMOBI = true;
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				if (obj83 != null)
				{
					nint num82 = (nint)typeof(Globals);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1947 @ S0_v237 (Il2CppClass<Globals>)+BA]");
					object obj84 = (nint)0 & (nint)0x200;
					if (obj84 != null)
					{
						nint num83 = (nint)typeof(Globals);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2040 @ S0_v243 (Il2CppClass<Globals>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						}
					}
					Globals.DEBUG_INTERSTITIAL_PROVIDER_CHARTBOOST = true;
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				if (obj85 != null)
				{
					nint num84 = (nint)typeof(Globals);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2126 @ S0_v222 (Il2CppClass<Globals>)+BA]");
					object obj86 = (nint)0 & (nint)0x200;
					if (obj86 != null)
					{
						nint num85 = (nint)typeof(Globals);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2159 @ S0_v228 (Il2CppClass<Globals>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						}
					}
					Globals.DEBUG_INTERSTITIAL_PROVIDER_SUPERSONIC = true;
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				if (obj87 != null)
				{
					nint num86 = (nint)typeof(Globals);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2192 @ S0_v207 (Il2CppClass<Globals>)+BA]");
					object obj88 = (nint)0 & (nint)0x200;
					if (obj88 != null)
					{
						nint num87 = (nint)typeof(Globals);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2219 @ S0_v213 (Il2CppClass<Globals>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						}
					}
					Globals.DEBUG_INTERSTITIAL_PROVIDER_FACEBOOK = true;
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				if (obj89 == null)
				{
					continue;
				}
				nint num88 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2253 @ S0_v192 (Il2CppClass<Globals>)+BA]");
				object obj90 = (nint)0 & (nint)0x200;
				if (obj90 != null)
				{
					nint num89 = (nint)typeof(Globals);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2265 @ S0_v198 (Il2CppClass<Globals>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Globals.DEBUG_INTERSTITIAL_PROVIDER_YEAHMOBI = true;
			}
			object obj91 = obj7 + 4;
			object obj92 = obj91 + 1;
			obj91 = obj92;
			object obj93 = obj92 << 2;
			object obj94 = obj7 + obj93;
			obj94 = 418;
			object obj95 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v27+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v27+4]");
				object obj96 = (nint)0 << 2;
				object obj97 = obj7 + obj96;
				if ((nint)obj97 == 418)
				{
					object obj98 = obj7 + 4;
					if ((nint)obj98 > -1)
					{
						object obj99 = obj98 + -1;
						obj98 = obj99;
					}
					goto IL_3d48;
				}
			}
			if (obj95 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
			goto IL_3d48;
		}
		SelectPopupButton popupList23 = PopupList;
		nint num90 = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ S0_v48 (Il2CppClass<Globals>)+BA]");
		object obj100 = (nint)0 & (nint)0x200;
		bool flag10 = obj100 == null;
		nint num91 = (nint)typeof(Globals);
		if (!flag10)
		{
			nint num92 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ S0_v68 (Il2CppClass<Globals>)+74]");
			bool flag11 = (nint)0 == 0;
			bool flag12 = !flag11;
			num91 = (nint)typeof(Globals);
			if (!flag12)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num91 = (nint)typeof(Globals);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ L0_v5 (Il2CppClass<Globals>)+5C]");
		object obj101 = (nint)0 + (nint)16;
		obj101 = popupList23.value__BackingField;
		nint num93 = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ S0_v56 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj102 = (nint)0 & (nint)0x200;
		if (obj102 != null)
		{
			nint num94 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ S0_v62 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		DebugSettingsPopup.DownloadNewOS = true;
		return;
		IL_3d48:
		nint num95 = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1471 @ S0_v110 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj103 = (nint)0 & (nint)0x200;
		if (obj103 != null)
		{
			nint num96 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1639 @ S0_v116 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		DebugSettingsPopup.RefreshInterstitials = true;
		return;
		IL_3ce4:
		nint num97 = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1344 @ S0_v330 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj104 = (nint)0 & (nint)0x200;
		if (obj104 != null)
		{
			nint num98 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1409 @ S0_v336 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		DebugSettingsPopup.RefreshVideoAds = true;
		return;
		IL_2b45:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v27+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v27+4]");
			object obj105 = (nint)0 << 2;
			object obj106 = obj7 + obj105;
			if ((nint)obj106 == 985)
			{
				object obj107 = obj7 + 4;
				if ((nint)obj107 > -1)
				{
					object obj108 = obj107 + -1;
					obj107 = obj108;
				}
				goto IL_3ce4;
			}
		}
		object obj109 = default;
		if (obj109 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_3ce4;
		IL_2aec:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj110 = default;
		object obj111 = default;
		bool flag13 = obj110 != obj111;
		object obj113 = default;
		object obj112 = obj113;
		if (!flag13)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
			goto IL_2b45;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
	}
}
