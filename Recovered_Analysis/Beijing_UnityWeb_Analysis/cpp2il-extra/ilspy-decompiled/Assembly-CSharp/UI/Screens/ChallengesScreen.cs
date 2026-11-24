using System;
using Cpp2ILInjected;
using Kiloo.Common.Extensions;
using SYBO.Subway.Info;
using UI.DoubleCoinsVideo;
using UI.Footer;
using UI.FreeStuff;
using UI.Generic.Layout;
using UI.Pages;
using UnityEngine;

namespace UI.Screens;

public class ChallengesScreen : UIScreen
{
	public enum PageIndex
	{
		DailyChallengePage,
		MissionsPage,
		WeeklyHuntPage
	}

	private sealed class _003C_003Ec__DisplayClass17_0
	{
		public int pageIndex;

		public ChallengesScreen _003C_003E4__this;

		public _003C_003Ec__DisplayClass17_0()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		internal void _003CLoadFooter_003Eb__1()
		{
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__17_0;

		static _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			RewardForVideoButtonHelper._003C_003Ec obj = default;
			RewardForVideoButtonHelper._003C_003Ec._003C_003E9 = obj;
		}

		public _003C_003Ec()
		{
			//IL_0022: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.ChallengesScreen+<>c)+C]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.ChallengesScreen+<>c)+8]");
			((CharacterNameEventPopup)num).ReloadSelectButton(Characters.CharacterId.slick, 1);
		}

		internal void _003CLoadFooter_003Eb__17_0()
		{
		}
	}

	private UIWidget _footerGuideWidget;

	private UIWidget _pageGuideWidget;

	private Layout _footerLayout;

	private FooterButton _footerButtonPrefab;

	private Page[] _pagePrefabs;

	private Page[] _pages;

	private FooterButton[] _footerButtons;

	private static int _currentlySelectedPageIndex;

	public override bool BlocksCelebrationPopup()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.ChallengesScreen)+375]");
		if ((nint)0 != 0)
		{
			_ = 0;
			return false;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.ChallengesScreen)+374]");
		return (nint)0 != 0;
	}

	public static void SetPageIndex(int newIndex)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_001c: Expected Obj, but got I4
		//IL_002b: Expected Obj, but got F4
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected Obj, but got Unknown
		//IL_0068: Expected Obj, but got I4
		//IL_008b: Expected Obj, but got I4
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected Obj, but got Unknown
		//IL_00ba: Expected Obj, but got I4
		//IL_00c9: Expected Obj, but got F4
		//IL_00f8: Expected Obj, but got I4
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected Obj, but got Unknown
		//IL_0124: Expected Obj, but got I4
		//IL_0133: Expected Obj, but got F4
		//IL_0162: Expected Obj, but got I4
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected Obj, but got Unknown
		//IL_018e: Expected Obj, but got I4
		//IL_019d: Expected Obj, but got F4
		//IL_01cc: Expected Obj, but got I4
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected Obj, but got Unknown
		//IL_01f8: Expected Obj, but got I4
		//IL_0207: Expected Obj, but got F4
		//IL_0236: Expected Obj, but got I4
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Expected Obj, but got Unknown
		//IL_0262: Expected Obj, but got I4
		//IL_0271: Expected Obj, but got F4
		//IL_02a0: Expected Obj, but got I4
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Expected Obj, but got Unknown
		//IL_02cc: Expected Obj, but got I4
		//IL_02db: Expected Obj, but got F4
		//IL_030a: Expected Obj, but got I4
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Expected Obj, but got Unknown
		//IL_0336: Expected Obj, but got I4
		//IL_0345: Expected Obj, but got F4
		//IL_0374: Expected Obj, but got I4
		//IL_0392: Unknown result type (might be due to invalid IL or missing references)
		//IL_0397: Expected Obj, but got Unknown
		//IL_03a0: Expected Obj, but got I4
		//IL_03af: Expected Obj, but got F4
		//IL_03de: Expected Obj, but got I4
		//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0401: Expected Obj, but got Unknown
		//IL_040a: Expected Obj, but got I4
		//IL_0419: Expected Obj, but got F4
		//IL_0448: Expected Obj, but got I4
		//IL_0466: Unknown result type (might be due to invalid IL or missing references)
		//IL_046b: Expected Obj, but got Unknown
		//IL_0474: Expected Obj, but got I4
		//IL_0483: Expected Obj, but got F4
		//IL_04b2: Expected Obj, but got I4
		//IL_04d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d5: Expected Obj, but got Unknown
		//IL_04de: Expected Obj, but got I4
		//IL_04ed: Expected Obj, but got F4
		//IL_051c: Expected Obj, but got I4
		//IL_053a: Unknown result type (might be due to invalid IL or missing references)
		//IL_053f: Expected Obj, but got Unknown
		//IL_0548: Expected Obj, but got I4
		//IL_0557: Expected Obj, but got F4
		//IL_0586: Expected Obj, but got I4
		//IL_05a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a9: Expected Obj, but got Unknown
		//IL_05b2: Expected Obj, but got I4
		//IL_05c1: Expected Obj, but got F4
		//IL_05f0: Expected Obj, but got I4
		//IL_060e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0613: Expected Obj, but got Unknown
		//IL_061c: Expected Obj, but got I4
		//IL_062b: Expected Obj, but got F4
		//IL_065a: Expected Obj, but got I4
		//IL_0678: Unknown result type (might be due to invalid IL or missing references)
		//IL_067d: Expected Obj, but got Unknown
		//IL_0686: Expected Obj, but got I4
		//IL_0695: Expected Obj, but got F4
		//IL_06c4: Expected Obj, but got I4
		//IL_06e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e7: Expected Obj, but got Unknown
		//IL_06f0: Expected Obj, but got I4
		//IL_06ff: Expected Obj, but got F4
		//IL_072e: Expected Obj, but got I4
		//IL_074c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0751: Expected Obj, but got Unknown
		//IL_075a: Expected Obj, but got I4
		//IL_0769: Expected Obj, but got F4
		//IL_0798: Expected Obj, but got I4
		//IL_07b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bb: Expected Obj, but got Unknown
		//IL_07c4: Expected Obj, but got I4
		//IL_07d3: Expected Obj, but got F4
		//IL_0802: Expected Obj, but got I4
		//IL_0820: Unknown result type (might be due to invalid IL or missing references)
		//IL_0825: Expected Obj, but got Unknown
		//IL_082e: Expected Obj, but got I4
		//IL_083d: Expected Obj, but got F4
		//IL_086c: Expected Obj, but got I4
		//IL_088a: Unknown result type (might be due to invalid IL or missing references)
		//IL_088f: Expected Obj, but got Unknown
		//IL_0898: Expected Obj, but got I4
		//IL_08a7: Expected Obj, but got F4
		//IL_08d6: Expected Obj, but got I4
		//IL_08f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f9: Expected Obj, but got Unknown
		//IL_0902: Expected Obj, but got I4
		//IL_0911: Expected Obj, but got F4
		//IL_0940: Expected Obj, but got I4
		//IL_095e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0963: Expected Obj, but got Unknown
		//IL_096c: Expected Obj, but got I4
		//IL_097b: Expected Obj, but got F4
		//IL_09aa: Expected Obj, but got I4
		//IL_09c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cd: Expected Obj, but got Unknown
		//IL_09d6: Expected Obj, but got I4
		//IL_09e5: Expected Obj, but got F4
		//IL_0a14: Expected Obj, but got I4
		//IL_0a32: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a37: Expected Obj, but got Unknown
		//IL_0a40: Expected Obj, but got I4
		//IL_0a4f: Expected Obj, but got F4
		//IL_0a7e: Expected Obj, but got I4
		//IL_0a9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa1: Expected Obj, but got Unknown
		//IL_0aaa: Expected Obj, but got I4
		//IL_0ab9: Expected Obj, but got F4
		//IL_0ae8: Expected Obj, but got I4
		//IL_0b06: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0b: Expected Obj, but got Unknown
		//IL_0b14: Expected Obj, but got I4
		//IL_0b23: Expected Obj, but got F4
		//IL_0b52: Expected Obj, but got I4
		//IL_0b70: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b75: Expected Obj, but got Unknown
		//IL_0b7e: Expected Obj, but got I4
		//IL_0b8d: Expected Obj, but got F4
		//IL_0bbc: Expected Obj, but got I4
		//IL_0bda: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bdf: Expected Obj, but got Unknown
		//IL_0be8: Expected Obj, but got I4
		//IL_0bf7: Expected Obj, but got F4
		//IL_0c26: Expected Obj, but got I4
		//IL_0c44: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c49: Expected Obj, but got Unknown
		//IL_0c52: Expected Obj, but got I4
		//IL_0c61: Expected Obj, but got F4
		//IL_0c90: Expected Obj, but got I4
		//IL_0cae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb3: Expected Obj, but got Unknown
		//IL_0cbc: Expected Obj, but got I4
		//IL_0ccb: Expected Obj, but got F4
		//IL_0cfa: Expected Obj, but got I4
		//IL_0d18: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d1d: Expected Obj, but got Unknown
		//IL_0d26: Expected Obj, but got I4
		//IL_0d35: Expected Obj, but got F4
		//IL_0d64: Expected Obj, but got I4
		//IL_0d82: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d87: Expected Obj, but got Unknown
		//IL_0d90: Expected Obj, but got I4
		//IL_0d9f: Expected Obj, but got F4
		//IL_0dce: Expected Obj, but got I4
		//IL_0dec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df1: Expected Obj, but got Unknown
		//IL_0dfa: Expected Obj, but got I4
		//IL_0e09: Expected Obj, but got F4
		//IL_0e38: Expected Obj, but got I4
		//IL_0e56: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e5b: Expected Obj, but got Unknown
		//IL_0e64: Expected Obj, but got I4
		//IL_0e6d: Expected Obj, but got I4
		//IL_0e76: Expected Obj, but got I4
		//IL_0e91: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e96: Expected Obj, but got Unknown
		//IL_0ec0: Expected Obj, but got I4
		//IL_0ecf: Expected Obj, but got F4
		//IL_0efe: Expected Obj, but got I4
		//IL_0f34: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 416;
		obj = 0;
		_ = 0;
		obj = 0f;
		_ = -500f;
		_ = 0f;
		object obj3 = obj2 + 428;
		obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		object obj4 = newIndex + 48;
		obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+8]");
		_ = 0;
		object obj5 = newIndex + 124;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj6 = default;
		obj5 = obj6;
		_ = 1;
		object obj7 = obj2 + 400;
		obj7 = 0;
		_ = 0;
		obj7 = 1150f;
		_ = 1150f;
		_ = 1150f;
		obj3 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v24+8]");
		_ = 0;
		object obj8 = newIndex + 328;
		obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+8]");
		_ = 0;
		object obj9 = obj2 + 388;
		obj9 = 0;
		_ = 0;
		obj9 = 0f;
		_ = 250f;
		_ = 20f;
		obj3 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v35+8]");
		_ = 0;
		object obj10 = newIndex + 340;
		obj10 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+8]");
		_ = 0;
		object obj11 = obj2 + 376;
		obj11 = 0;
		_ = 0;
		obj11 = 10f;
		_ = 10f;
		_ = 10f;
		obj3 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S0_v46+8]");
		_ = 0;
		object obj12 = newIndex + 352;
		obj12 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+8]");
		_ = 0;
		object obj13 = obj2 + 364;
		obj13 = 0;
		_ = 0;
		obj13 = 20f;
		_ = 220f;
		_ = 12f;
		obj3 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S0_v57+8]");
		_ = 0;
		object obj14 = newIndex + 364;
		obj14 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+8]");
		_ = 0;
		object obj15 = obj2 + 352;
		obj15 = 0;
		_ = 0;
		obj15 = 0f;
		_ = 0f;
		_ = 0f;
		obj3 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ S0_v68+8]");
		_ = 0;
		object obj16 = newIndex + 376;
		obj16 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+8]");
		_ = 0;
		object obj17 = obj2 + 340;
		obj17 = 0;
		_ = 0;
		obj17 = 19f;
		_ = 19f;
		_ = 19f;
		obj3 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S0_v79+8]");
		_ = 0;
		object obj18 = newIndex + 388;
		obj18 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+8]");
		_ = 0;
		object obj19 = obj2 + 328;
		obj19 = 0;
		_ = 0;
		obj19 = 900f;
		_ = 900f;
		_ = 900f;
		obj3 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ S0_v90+8]");
		_ = 0;
		object obj20 = newIndex + 400;
		obj20 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+8]");
		_ = 0;
		object obj21 = obj2 + 316;
		obj21 = 0;
		_ = 0;
		obj21 = 0f;
		_ = -180f;
		_ = 0f;
		obj3 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ S0_v101+8]");
		_ = 0;
		object obj22 = newIndex + 412;
		obj22 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+8]");
		_ = 0;
		object obj23 = obj2 + 304;
		obj23 = 0;
		_ = 0;
		obj23 = 5f;
		_ = -97f;
		_ = 0f;
		obj3 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ S0_v112+8]");
		_ = 0;
		object obj24 = newIndex + 424;
		obj24 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+8]");
		_ = 0;
		object obj25 = obj2 + 292;
		obj25 = 0;
		_ = 0;
		obj25 = 15f;
		_ = -10.5f;
		_ = 0f;
		obj3 = obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ S0_v123+8]");
		_ = 0;
		object obj26 = newIndex + 436;
		obj26 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+8]");
		_ = 0;
		object obj27 = obj2 + 280;
		obj27 = 0;
		_ = 0;
		obj27 = 4f;
		_ = 4f;
		_ = 4f;
		obj3 = obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ S0_v134+8]");
		_ = 0;
		object obj28 = newIndex + 448;
		obj28 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+8]");
		_ = 0;
		object obj29 = obj2 + 268;
		obj29 = 0;
		_ = 0;
		obj29 = 7f;
		_ = 7f;
		_ = 7f;
		obj3 = obj29;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ S0_v145+8]");
		_ = 0;
		object obj30 = newIndex + 460;
		obj30 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+8]");
		_ = 0;
		object obj31 = obj2 + 256;
		obj31 = 0;
		_ = 0;
		obj31 = 0f;
		_ = 180f;
		_ = 0f;
		obj3 = obj31;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ S0_v156+8]");
		_ = 0;
		object obj32 = newIndex + 472;
		obj32 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+8]");
		_ = 0;
		object obj33 = obj2 + 244;
		obj33 = 0;
		_ = 0;
		obj33 = 15f;
		_ = 180f;
		_ = 0f;
		obj3 = obj33;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ S0_v167+8]");
		_ = 0;
		object obj34 = newIndex + 484;
		obj34 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+8]");
		_ = 0;
		object obj35 = obj2 + 232;
		obj35 = 0;
		_ = 0;
		obj35 = -10f;
		_ = -180f;
		_ = 0f;
		obj3 = obj35;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ S0_v178+8]");
		_ = 0;
		object obj36 = newIndex + 496;
		obj36 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+8]");
		_ = 0;
		object obj37 = obj2 + 220;
		obj37 = 0;
		_ = 0;
		obj37 = -10f;
		_ = -180f;
		_ = 0f;
		obj3 = obj37;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ S0_v189+8]");
		_ = 0;
		object obj38 = newIndex + 508;
		obj38 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+8]");
		_ = 0;
		object obj39 = obj2 + 208;
		obj39 = 0;
		_ = 0;
		obj39 = 0f;
		_ = 0f;
		_ = 0f;
		obj3 = obj39;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ S0_v200+8]");
		_ = 0;
		object obj40 = newIndex + 520;
		obj40 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+8]");
		_ = 0;
		object obj41 = obj2 + 196;
		obj41 = 0;
		_ = 0;
		obj41 = 900f;
		_ = 900f;
		_ = 900f;
		obj3 = obj41;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ S0_v211+8]");
		_ = 0;
		object obj42 = newIndex + 532;
		obj42 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+8]");
		_ = 0;
		object obj43 = obj2 + 184;
		obj43 = 0;
		_ = 0;
		obj43 = 10f;
		_ = 10f;
		_ = 10f;
		obj3 = obj43;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ S0_v222+8]");
		_ = 0;
		object obj44 = newIndex + 544;
		obj44 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+8]");
		_ = 0;
		object obj45 = obj2 + 172;
		obj45 = 0;
		_ = 0;
		obj45 = 9f;
		_ = 9f;
		_ = 9f;
		obj3 = obj45;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v592 @ S0_v233+8]");
		_ = 0;
		object obj46 = newIndex + 556;
		obj46 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+8]");
		_ = 0;
		object obj47 = obj2 + 160;
		obj47 = 0;
		_ = 0;
		obj47 = 1050f;
		_ = 1050f;
		_ = 1050f;
		obj3 = obj47;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v620 @ S0_v244+8]");
		_ = 0;
		object obj48 = newIndex + 568;
		obj48 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+8]");
		_ = 0;
		object obj49 = obj2 + 148;
		obj49 = 0;
		_ = 0;
		obj49 = 0f;
		_ = -95f;
		_ = 0f;
		obj3 = obj49;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v648 @ S0_v255+8]");
		_ = 0;
		object obj50 = newIndex + 580;
		obj50 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+8]");
		_ = 0;
		object obj51 = obj2 + 136;
		obj51 = 0;
		_ = 0;
		obj51 = 18f;
		_ = 18f;
		_ = 18f;
		obj3 = obj51;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v676 @ S0_v266+8]");
		_ = 0;
		object obj52 = newIndex + 592;
		obj52 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+8]");
		_ = 0;
		object obj53 = obj2 + 124;
		obj53 = 0;
		_ = 0;
		obj53 = 16f;
		_ = 16f;
		_ = 16f;
		obj3 = obj53;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ S0_v277+8]");
		_ = 0;
		object obj54 = newIndex + 604;
		obj54 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+8]");
		_ = 0;
		object obj55 = obj2 + 112;
		obj55 = 0;
		_ = 0;
		obj55 = 35f;
		_ = 35f;
		_ = 35f;
		obj3 = obj55;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v732 @ S0_v288+8]");
		_ = 0;
		object obj56 = newIndex + 616;
		obj56 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+8]");
		_ = 0;
		object obj57 = obj2 + 100;
		obj57 = 0;
		_ = 0;
		obj57 = 14f;
		_ = 14f;
		_ = 14f;
		obj3 = obj57;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v760 @ S0_v299+8]");
		_ = 0;
		object obj58 = newIndex + 628;
		obj58 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+8]");
		_ = 0;
		object obj59 = obj2 + 88;
		obj59 = 0;
		_ = 0;
		obj59 = 0f;
		_ = 0f;
		_ = 0f;
		obj3 = obj59;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v788 @ S0_v310+8]");
		_ = 0;
		object obj60 = newIndex + 640;
		obj60 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+8]");
		_ = 0;
		object obj61 = obj2 + 76;
		obj61 = 0;
		_ = 0;
		obj61 = 0f;
		_ = -25f;
		_ = 0f;
		obj3 = obj61;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v816 @ S0_v321+8]");
		_ = 0;
		object obj62 = newIndex + 652;
		obj62 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+8]");
		_ = 0;
		object obj63 = obj2 - -64;
		obj63 = 0;
		_ = 0;
		obj63 = 0f;
		_ = 15f;
		_ = 0f;
		obj3 = obj63;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v844 @ S0_v332+8]");
		_ = 0;
		object obj64 = newIndex + 664;
		obj64 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+8]");
		_ = 0;
		object obj65 = obj2 + 52;
		obj65 = 0;
		_ = 0;
		obj65 = 0f;
		_ = -110f;
		_ = -5f;
		obj3 = obj65;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v872 @ S0_v343+8]");
		_ = 0;
		object obj66 = newIndex + 688;
		obj66 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+8]");
		_ = 0;
		object obj67 = obj2 + 40;
		obj67 = 0;
		_ = 0;
		obj67 = 0f;
		_ = -160f;
		_ = -5f;
		obj3 = obj67;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v900 @ S0_v354+8]");
		_ = 0;
		object obj68 = newIndex + 700;
		obj68 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+8]");
		_ = 0;
		object obj69 = obj2 + 28;
		obj69 = 0;
		_ = 0;
		obj69 = 0f;
		_ = -140f;
		_ = -5f;
		obj3 = obj69;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v928 @ S0_v365+8]");
		_ = 0;
		object obj70 = newIndex + 712;
		obj70 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+8]");
		_ = 0;
		object obj71 = obj2 + 16;
		obj71 = 0;
		_ = 0;
		obj71 = 0f;
		_ = -223f;
		_ = -5f;
		obj3 = obj71;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v956 @ S0_v376+8]");
		_ = 0;
		object obj72 = newIndex + 724;
		obj72 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+8]");
		_ = 0;
		object obj73 = obj2 + 12;
		obj73 = 0;
		obj73 = 0;
		obj73 = -1;
		_ = -1;
		_ = -1;
		_ = 0;
		object obj74 = obj2 + 412;
		obj74 = obj73;
		obj3 = obj74;
		_ = 0.7f;
		_ = 1f;
		obj2 = 0;
		_ = 0;
		obj2 = 1.1f;
		_ = 1.25f;
		_ = 1.25f;
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj75 = newIndex + 844;
		obj75 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+8]");
		_ = 0;
		_ = 2;
		_ = 1;
		_ = 0.0875f;
		_ = 1.5f;
		((UpgradeScreen)newIndex).Start();
	}

	public static int GetPageIndex()
	{
		//IL_0153: Expected I, but got Obj
		//IL_0169: Expected Obj, but got I
		//IL_01d1: Expected I, but got Obj
		//IL_01e7: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_01c3: Expected I4, but got Obj
		//IL_0106: Expected I, but got Obj
		//IL_0078: Expected I, but got Obj
		//IL_008e: Expected Obj, but got I
		//IL_00b9: Expected I, but got Obj
		nint num = (nint)typeof(BoardBundlePopupManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Screens.BoardBundlePopupManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(BoardBundlePopupManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v45 (Il2CppClass<UI.Screens.BoardBundlePopupManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (BoardBundlePopupManager._instance == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			BoardBundlePopupManager boardBundlePopupManager = default;
			boardBundlePopupManager.DebugModeChanged();
			nint num3 = (nint)typeof(BoardBundlePopupManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v33 (Il2CppClass<UI.Screens.BoardBundlePopupManager>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(BoardBundlePopupManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v39 (Il2CppClass<UI.Screens.BoardBundlePopupManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			BoardBundlePopupManager._instance = boardBundlePopupManager;
		}
		nint num5 = (nint)typeof(BoardBundlePopupManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v16 (Il2CppClass<UI.Screens.BoardBundlePopupManager>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(BoardBundlePopupManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v23 (Il2CppClass<UI.Screens.BoardBundlePopupManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (int)BoardBundlePopupManager._instance;
	}

	public override void Init()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0099: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(ChallengesScreen);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Screens.ChallengesScreen>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(ChallengesScreen);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<UI.Screens.ChallengesScreen>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_currentlySelectedPageIndex = (int)this;
	}

	public override void Show()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected Obj, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		ShowIfInactive();
		object obj = this + 60;
		Page[] pagePrefabs = _pagePrefabs;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj2 = default;
		obj = obj2;
		object obj3 = this - -64;
		Page[] pagePrefabs2 = _pagePrefabs;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj4 = default;
		obj3 = obj4;
		this._002Ector();
	}

	public unsafe override void Hide()
	{
		//IL_0108: Expected I, but got Obj
		//IL_011e: Expected Obj, but got I
		//IL_0158: Invalid comparison between VT and I4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		base.Hide();
		((NotebookScreen)null)._002Ector();
		nint num = (nint)typeof(ChallengesScreen);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<UI.Screens.ChallengesScreen>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(ChallengesScreen);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v15 (Il2CppClass<UI.Screens.ChallengesScreen>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_0021_00210 eventValue = (_0021_00210)((ExpiredLimitedBoardEventManager)(object)_pages).GetEventValue<T>(out *(bool*)_currentlySelectedPageIndex);
		Characters.CharacterId charId;
		if (eventValue != (_0021_00210)(object)0)
		{
			nint num3 = (nint)typeof(ChallengesScreen);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S1_v10 (Il2CppClass<UI.Screens.ChallengesScreen>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(ChallengesScreen);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S1_v17 (Il2CppClass<UI.Screens.ChallengesScreen>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			charId = (Characters.CharacterId)_currentlySelectedPageIndex;
		}
		else
		{
			charId = Characters.CharacterId.slick;
		}
		((CharacterNameEventPopup)this).ReloadSelectButton(charId, 0);
	}

	private void ActivatePage(int pageIndex, bool calledFromFooterButton)
	{
		//IL_001a: Expected Obj, but got I4
		bool isInstanced = UIScreenController.IsInstanced;
		((UIModelController)isInstanced).SelectCharacterForPlay((Characters.CharacterId)pageIndex, calledFromFooterButton ? 1 : 0);
	}

	private string GetButtonName(PageIndex pageIndex)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected Obj, but got Unknown
		//IL_0046: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		string text = default;
		text.m_stringLength = 0;
		object obj = text + 16;
		obj = this;
		object obj2 = text + 20;
		obj2 = pageIndex;
		return text;
	}

	private void LoadFooter()
	{
		//IL_00cd: Expected I, but got Obj
		//IL_00e3: Expected Obj, but got I
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected Obj, but got Unknown
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected Obj, but got Unknown
		//IL_013a: Expected I, but got Obj
		//IL_0150: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00b8: Expected Obj, but got I4
		//IL_0060: Expected I, but got Obj
		base.LoseFocus();
		nint num = (nint)typeof(ChallengesScreen);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S1_v4 (Il2CppClass<UI.Screens.ChallengesScreen>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(ChallengesScreen);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v18 (Il2CppClass<UI.Screens.ChallengesScreen>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = _pages + 16;
		int num3 = _currentlySelectedPageIndex << 2;
		object o = obj2 + num3;
		nint num4 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v21 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)o))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		}
		((NotebookScreen)1)._002Ector();
	}

	private void SelectFooterButton(int selectIndex)
	{
		//IL_0064: Expected Obj, but got I4
		//IL_0013: Expected Obj, but got I4
		//IL_0033: Expected Obj, but got I4
		if (!((string)selectIndex == "PrizeMBPopup_Keys") || !((string)selectIndex == "PrizeMMBPopup") || (string)selectIndex != "PrizeSMBPopup_Keys")
		{
			((CelebrationPopup)this).PrizeListNormalClicked();
		}
	}

	private void ChangePage(int index, bool calledFromFooterButton = false)
	{
		//IL_0370: Expected Obj, but got I4
		//IL_037b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Expected Obj, but got Unknown
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Expected Obj, but got Unknown
		//IL_03a9: Expected I, but got Obj
		//IL_03bf: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0410: Expected Obj, but got I4
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected Obj, but got Unknown
		//IL_009a: Expected I, but got Obj
		//IL_00b0: Expected Obj, but got I
		//IL_0251: Expected I, but got Obj
		//IL_0267: Expected Obj, but got I
		//IL_00db: Expected I, but got Obj
		//IL_0292: Expected I, but got Obj
		object obj = 0;
		object obj2 = _pages + 16;
		int num = index << 2;
		object obj3 = obj2 + num;
		nint num2 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v71 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = (UnityEngine.Object)obj3 != null;
		bool flag2 = !flag;
		UnityEngine.Object obj5 = (UnityEngine.Object)obj3;
		if (!flag2)
		{
			object obj6 = _pagePrefabs + 16;
			int num4 = index << 2;
			object original = obj6 + num4;
			GameObject parent = _pageGuideWidget.gameObject;
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S2_v15 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S2_v24 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Page page = UnityEngine.Object.Instantiate((Page)original, (Transform)(object)parent);
			GameObject uiGrid = page.gameObject;
			UIExtensions.RepositionImmediately((UIGrid)(object)uiGrid);
			throw new ArrayTypeMismatchException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		if (calledFromFooterButton)
		{
			bool flag3 = ((CharacterNameEventPopup)null).IsFilteredCharacter((char)index);
			nint num7 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S0_v33 (Il2CppClass<Flurry>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num8 = (nint)typeof(Flurry);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v36 (Il2CppClass<Flurry>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
		}
		obj = index;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		throw new NullReferenceException();
	}

	protected override string GetFlurryName()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a8: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(ChallengesScreen);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Screens.ChallengesScreen>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(ChallengesScreen);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<UI.Screens.ChallengesScreen>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = _currentlySelectedPageIndex == 1;
		return (string)flag;
	}

	public unsafe ChallengesScreen()
	{
		//IL_0471: Expected I, but got Obj
		//IL_0487: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0078: Expected I, but got Obj
		//IL_008e: Expected Obj, but got I
		//IL_070a: Unknown result type (might be due to invalid IL or missing references)
		//IL_070f: Expected Obj, but got Unknown
		//IL_072b: Expected I, but got Obj
		//IL_0741: Expected Obj, but got I
		//IL_00b9: Expected I, but got Obj
		//IL_0593: Unknown result type (might be due to invalid IL or missing references)
		//IL_0598: Expected Obj, but got Unknown
		//IL_05d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d5: Expected Obj, but got Unknown
		//IL_060d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0612: Expected Obj, but got Unknown
		//IL_0629: Expected I, but got Obj
		//IL_063f: Expected Obj, but got I
		//IL_0106: Expected I, but got Obj
		//IL_011c: Expected Obj, but got I
		//IL_0665: Unknown result type (might be due to invalid IL or missing references)
		//IL_066a: Expected Obj, but got Unknown
		//IL_068d: Expected I4, but got Obj
		//IL_069b: Expected I4, but got Obj
		//IL_0194: Expected I, but got Obj
		//IL_0539: Unknown result type (might be due to invalid IL or missing references)
		//IL_053e: Expected Obj, but got Unknown
		//IL_0555: Expected I, but got Obj
		//IL_056b: Expected Obj, but got I
		//IL_0229: Expected Obj, but got I4
		//IL_01e1: Expected I, but got Obj
		//IL_0147: Expected I, but got Obj
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Expected Obj, but got Unknown
		//IL_026d: Expected I, but got Obj
		//IL_0283: Expected Obj, but got I
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Expected Obj, but got Unknown
		//IL_02ae: Expected I, but got Obj
		//IL_0361: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Expected Obj, but got Unknown
		//IL_037c: Expected Obj, but got I4
		//IL_0391: Expected Obj, but got I
		//IL_03cf: Expected I4, but got Obj
		//IL_03cf: Expected Obj, but got I
		//IL_03e5: Expected I4, but got Obj
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f0: Expected Obj, but got Unknown
		GameObject parent = _footerGuideWidget.gameObject;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S2_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S2_v38 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		FooterButton footerButton = UnityEngine.Object.Instantiate(_footerButtonPrefab, (Transform)(object)parent);
		GameObject uiGrid = footerButton.gameObject;
		UIExtensions.RepositionImmediately((UIGrid)(object)uiGrid);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		DoubleCoinsVideoBanner._003CActivateStars_003Ed__14 obj2 = default;
		((IDisposable)obj2).Dispose();
		nint num3 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v16 (Il2CppClass<UI.Screens.ChallengesScreen+<>c>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v127 (Il2CppClass<UI.Screens.ChallengesScreen+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = _003C_003Ec._003C_003E9__17_0 == null;
		bool flag2 = !flag;
		Action action = _003C_003Ec._003C_003E9__17_0;
		if (!flag2)
		{
			nint num5 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v104 (Il2CppClass<UI.Screens.ChallengesScreen+<>c>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num6 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v121 (Il2CppClass<UI.Screens.ChallengesScreen+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr = 0;
			Action action2 = default;
			((Delegate)action2).method_ptr = method_ptr;
			((Delegate)action2).method = (nint)__ldftn(_003C_003Ec._003CLoadFooter_003Eb__17_0);
			object obj5 = action2 + 16;
			obj5 = _003C_003Ec._003C_003E9;
			nint num7 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S0_v118 (Il2CppClass<UI.Screens.ChallengesScreen+<>c>)+5C]");
			object obj6 = (nint)0 + (nint)4;
			obj6 = action2;
			action = action2;
		}
		object obj7 = obj2 + 8;
		obj7 = action;
		_ = 72;
		nint num8 = (nint)typeof(GlobalColors);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v29 (Il2CppClass<GlobalColors>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num9 = (nint)typeof(GlobalColors);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v97 (Il2CppClass<GlobalColors>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @778F");
		object obj10 = default;
		object obj9 = obj10 + 32;
		obj9 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+18]");
		_ = 0;
		object obj11 = obj2 + 16;
		obj11 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S0_v35+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S0_v35+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S0_v35+18]");
		_ = 0;
		object obj12 = obj2 + 12;
		obj12 = "icon_back_menu";
		nint num10 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ S0_v47 (Il2CppClass<Strings>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num11 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S0_v93 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj14 = obj2 + 52;
		string text = Strings.GetDefault("FOOTER_MENU_BUTTON_TITLE");
		obj14 = text;
		footerButton.SetSelectedState((byte)(int)obj2 != 0);
		UnityEngine.Object.DestroyImmediate(footerButton, (byte)(int)"Menu Button" != 0);
		object obj15 = 0;
		Page[] pagePrefabs = _pagePrefabs;
		if ((nint)obj15 < pagePrefabs.Length)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			object obj17 = default;
			object obj16 = obj17 + 12;
			obj16 = this;
			GameObject parent2 = _footerGuideWidget.gameObject;
			nint num12 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ S2_v17 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj18 = (nint)0 & (nint)0x200;
			if (obj18 != null)
			{
				nint num13 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ S2_v34 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			FooterButton footerButton2 = UnityEngine.Object.Instantiate(_footerButtonPrefab, (Transform)(object)parent2);
			GameObject uiGrid2 = footerButton2.gameObject;
			UIExtensions.RepositionImmediately((UIGrid)(object)uiGrid2);
			object obj19 = _pagePrefabs + 16;
			object obj20 = obj15 << 2;
			object obj21 = obj19 + obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr2 = 0;
			Delegate obj22 = default;
			obj22.method_ptr = method_ptr2;
			obj22.method = (nint)__ldftn(_003C_003Ec__DisplayClass17_0._003CLoadFooter_003Eb__1);
			object obj23 = obj22 + 16;
			obj23 = obj17;
			bool flag3 = default;
			object obj24 = (flag3 ? 1 : 0) + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ S0_v71 (System.Boolean)+8]");
			Delegate obj25 = ((Delegate)0).CombineImpl(obj22);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			object obj26 = default;
			obj24 = obj26;
			footerButton2.SetSelectedState(flag3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ S0_v71 (System.Boolean)+34]");
			string text2 = string.ConcatArray((string[])0, (int)" Button");
			UnityEngine.Object.DestroyImmediate(footerButton2, (byte)(int)text2 != 0);
			object obj27 = this - -64;
			throw new ArrayTypeMismatchException();
		}
		((RewardForVideoButton)(object)_footerLayout).Init((VideoButtonPayload)null);
	}

	static ChallengesScreen()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_001c: Expected Obj, but got I4
		//IL_002b: Expected Obj, but got F4
		//IL_0045: Expected I, but got Obj
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected Obj, but got Unknown
		//IL_0081: Expected VT, but got Obj
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected Obj, but got Unknown
		//IL_00a5: Expected Obj, but got I4
		//IL_00b4: Expected Obj, but got F4
		//IL_00ce: Expected I, but got Obj
		//IL_00f9: Expected Obj, but got I
		//IL_0117: Expected Obj, but got I4
		//IL_0126: Expected Obj, but got F4
		//IL_0140: Expected I, but got Obj
		//IL_016b: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 + 24;
		obj = 0;
		_ = 0;
		obj = 0f;
		_ = 15f;
		_ = -50f;
		nint num = (nint)typeof(CelebrationPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15 (Il2CppClass<UI.Screens.CelebrationPopup>)+5C]");
		nint num2 = 0;
		object obj3 = obj2 + 36;
		obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		CelebrationPopup.FIRST_SLOT_POSITION = (Vector3)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		object obj4 = obj2 + 12;
		obj4 = 0;
		_ = 0;
		obj4 = 0f;
		_ = 0f;
		_ = 9370f;
		nint num3 = (nint)typeof(CelebrationPopup);
		obj3 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v23+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v29 (Il2CppClass<UI.Screens.CelebrationPopup>)+5C]");
		object obj5 = (nint)0 + (nint)12;
		obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		obj2 = 0;
		_ = 0;
		obj2 = 0f;
		_ = 0f;
		_ = 180f;
		nint num4 = (nint)typeof(CelebrationPopup);
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v39 (Il2CppClass<UI.Screens.CelebrationPopup>)+5C]");
		object obj6 = (nint)0 + (nint)24;
		obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
	}
}
