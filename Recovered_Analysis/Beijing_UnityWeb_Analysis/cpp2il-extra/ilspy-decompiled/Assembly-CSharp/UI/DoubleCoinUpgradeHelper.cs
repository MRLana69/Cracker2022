using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Data.Save;
using InApp;
using Kiloo.Common.Backend.PurchaseValidation;
using SYBO.Subway.Info;
using UI.Screens;
using UnityEngine;

namespace UI;

public class DoubleCoinUpgradeHelper : DiscountButton
{
	private Vector3 _shownDiscStickerPos;

	private Vector3 _shownDiscLabelPos;

	private Vector3 _shownDiscLabelSingleLinePos;

	private string doubleCoinVersion;

	private bool _inited;

	public bool OnSale => false;

	private void ForceEndDiscount()
	{
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected Obj, but got Unknown
		//IL_00f7: Expected Obj, but got VT
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected Obj, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected Obj, but got Unknown
		//IL_012d: Expected VT, but got Obj
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected Obj, but got Unknown
		//IL_0144: Expected Obj, but got VT
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected Obj, but got Unknown
		//IL_016c: Expected VT, but got Obj
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected Obj, but got Unknown
		//IL_0183: Expected Obj, but got VT
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected Obj, but got Unknown
		//IL_01ab: Expected VT, but got Obj
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected Obj, but got Unknown
		//IL_01c2: Expected Obj, but got VT
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Expected Obj, but got Unknown
		//IL_01ea: Expected VT, but got Obj
		//IL_01f8: Expected I, but got Obj
		//IL_020e: Expected Obj, but got I
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Expected Obj, but got Unknown
		//IL_0242: Expected Obj, but got VT
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected Obj, but got Unknown
		//IL_026a: Expected VT, but got Obj
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected Obj, but got Unknown
		//IL_0281: Expected Obj, but got VT
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Expected Obj, but got Unknown
		//IL_02a9: Expected VT, but got Obj
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Expected Obj, but got Unknown
		//IL_02c0: Expected Obj, but got VT
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Expected Obj, but got Unknown
		//IL_02e8: Expected VT, but got Obj
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f6: Expected Obj, but got Unknown
		//IL_02ff: Expected Obj, but got VT
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Expected Obj, but got Unknown
		//IL_0327: Expected VT, but got Obj
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		//IL_0335: Expected Obj, but got Unknown
		//IL_033e: Expected Obj, but got VT
		//IL_0347: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Expected Obj, but got Unknown
		//IL_0366: Expected VT, but got Obj
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Expected Obj, but got Unknown
		//IL_037d: Expected Obj, but got VT
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Expected Obj, but got Unknown
		//IL_03a5: Expected VT, but got Obj
		//IL_03ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b3: Expected Obj, but got Unknown
		//IL_03bc: Expected Obj, but got VT
		//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ca: Expected Obj, but got Unknown
		//IL_03e4: Expected VT, but got Obj
		//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f2: Expected Obj, but got Unknown
		//IL_03fb: Expected Obj, but got VT
		//IL_0404: Unknown result type (might be due to invalid IL or missing references)
		//IL_0409: Expected Obj, but got Unknown
		//IL_0423: Expected VT, but got Obj
		//IL_042c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0431: Expected Obj, but got Unknown
		//IL_043a: Expected Obj, but got VT
		//IL_0443: Unknown result type (might be due to invalid IL or missing references)
		//IL_0448: Expected Obj, but got Unknown
		//IL_0462: Expected VT, but got Obj
		//IL_046b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0470: Expected Obj, but got Unknown
		//IL_0479: Expected Obj, but got VT
		//IL_0482: Unknown result type (might be due to invalid IL or missing references)
		//IL_0487: Expected Obj, but got Unknown
		//IL_049d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a2: Expected Obj, but got Unknown
		//IL_04b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b8: Expected Obj, but got Unknown
		//IL_04c1: Expected Obj, but got VT
		//IL_04ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cf: Expected Obj, but got Unknown
		//IL_04e9: Expected VT, but got Obj
		//IL_04f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f7: Expected Obj, but got Unknown
		//IL_0500: Expected Obj, but got VT
		//IL_051a: Expected VT, but got Obj
		//IL_0520: Unknown result type (might be due to invalid IL or missing references)
		//IL_0525: Expected Obj, but got Unknown
		//IL_0534: Unknown result type (might be due to invalid IL or missing references)
		//IL_0539: Expected Obj, but got Unknown
		//IL_0548: Unknown result type (might be due to invalid IL or missing references)
		//IL_054d: Expected Obj, but got Unknown
		//IL_055c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0561: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		nint num = (nint)typeof(GlobalColorsGenerated);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<GlobalColorsGenerated>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(GlobalColorsGenerated);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v131 (Il2CppClass<GlobalColorsGenerated>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 92;
		obj2 = GlobalColorsGenerated.DISCOUNT_BUTTON_TITLE_COLOR;
		object obj4 = obj3 + 124;
		obj4 = obj2;
		object obj5 = obj3 + 128;
		obj5 = obj4;
		titleColor = (Color32)obj5;
		object obj6 = obj3 + 88;
		obj6 = GlobalColorsGenerated.DISCOUNT_BUTTON_TITLE_COLOR_SHADOW;
		object obj7 = obj3 + 120;
		obj7 = obj6;
		obj5 = obj7;
		titleColorShadow = (Color32)obj5;
		object obj8 = obj3 + 80;
		obj8 = GlobalColorsGenerated.DISCOUNT_BUTTON_DESCRIPTION1_INACTIVE_COLOR;
		object obj9 = obj3 + 116;
		obj9 = obj8;
		obj5 = obj9;
		description1ColorInactive = (Color32)obj5;
		object obj10 = obj3 + 76;
		obj10 = GlobalColorsGenerated.DISCOUNT_BUTTON_DESCRIPTION1_INACTIVE_SHADOW_COLOR;
		object obj11 = obj3 + 112;
		obj11 = obj10;
		obj5 = obj11;
		description1ColorShadowInactive = (Color32)obj5;
		nint num3 = (nint)typeof(GlobalColors);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v39 (Il2CppClass<GlobalColors>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num4 = (nint)typeof(GlobalColors);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S0_v125 (Il2CppClass<GlobalColors>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj13 = obj3 + 72;
		obj13 = GlobalColors.DISCOUNT_BUTTON_DESCRIPTION1_ACTIVE_COLOR;
		object obj14 = obj3 + 108;
		obj14 = obj13;
		obj5 = obj14;
		description1ColorActive = (Color32)obj5;
		object obj15 = obj3 - -64;
		obj15 = GlobalColors.DISCOUNT_BUTTON_DESCRIPTION1_ACTIVE_SHADOW_COLOR;
		object obj16 = obj3 + 104;
		obj16 = obj15;
		obj5 = obj16;
		description1ColorShadowActive = (Color32)obj5;
		object obj17 = obj3 + 60;
		obj17 = GlobalColors.DISCOUNT_BUTTON_DESCRIPTION2_COLOR;
		object obj18 = obj3 + 100;
		obj18 = obj17;
		obj5 = obj18;
		description2Color = (Color32)obj5;
		object obj19 = obj3 + 52;
		obj19 = GlobalColors.DISCOUNT_BUTTON_DESCRIPTION2_SHADOW_COLOR;
		object obj20 = obj3 + 96;
		obj20 = obj19;
		obj5 = obj20;
		description2ColorShadow = (Color32)obj5;
		object obj21 = obj3 + 44;
		obj21 = GlobalColorsGenerated.DISCOUNT_BUTTON_PRICE_COLOR;
		object obj22 = obj3 + 84;
		obj22 = obj21;
		obj5 = obj22;
		priceColor = (Color32)obj5;
		object obj23 = obj3 + 40;
		obj23 = GlobalColorsGenerated.DISCOUNT_BUTTON_PRICE_SHADOW_COLOR;
		object obj24 = obj3 + 68;
		obj24 = obj23;
		obj5 = obj24;
		priceColorShadow = (Color32)obj5;
		object obj25 = obj3 + 36;
		obj25 = GlobalColorsGenerated.DISCOUNT_BUTTON_LIMITED_TIME_COLOR;
		object obj26 = obj3 + 56;
		obj26 = obj25;
		obj5 = obj26;
		limitedTimerColor = (Color32)obj5;
		object obj27 = obj3 + 28;
		obj27 = GlobalColorsGenerated.DISCOUNT_BUTTON_LIMITED_TIME_SHADOW_COLOR;
		object obj28 = obj3 + 48;
		obj28 = obj27;
		obj5 = obj28;
		limitedTimerColorShadow = (Color32)obj5;
		object obj29 = obj3 + 24;
		obj29 = GlobalColorsGenerated.DISCOUNT_STICKER_COLOR;
		object obj30 = obj3 + 32;
		obj30 = obj29;
		obj5 = obj30;
		stickerColor = (Color32)obj5;
		object obj31 = obj3 + 16;
		obj31 = GlobalColorsGenerated.DISCOUNT_STICKER_LABEL_COLOR;
		object obj32 = obj3 + 20;
		obj32 = obj31;
		obj5 = obj32;
		object obj33 = this - -64;
		obj33 = obj5;
		object obj34 = obj3 + 12;
		obj34 = GlobalColors.DISCOUNT_BUTTON_LINE_THROUGH_COLOR;
		object obj35 = obj3 + 8;
		obj35 = obj34;
		obj5 = obj35;
		lineThroughColor = (Color32)obj5;
		object obj36 = obj3 + 4;
		obj36 = GlobalColors.DISCOUNT_BUTTON_LINE_THROUGH_SHADOW_COLOR;
		obj3 = obj36;
		obj5 = obj3;
		lineThroughShadowColor = (Color32)obj5;
		object obj37 = this + 76;
		obj37 = "button_fill_shopItem_highlight_sale";
		object obj38 = this + 80;
		obj38 = "button_fill_shopItem_main_sale";
		object obj39 = this + 84;
		obj39 = "icon_background_normal";
		object obj40 = this + 88;
		obj40 = "icon_background_keys";
		CancelInvoke();
	}

	private unsafe void _DefaultSetup(string data, bool wasRestored, IPurchaseValidationResult validationResult)
	{
		//IL_002a: Expected Obj, but got I4
		//IL_0051: Expected I4, but got Obj
		SetLimitedLabels(DiscountButton.DiscountButtonState.Promotion);
		SetDiscountColors(DiscountButton.DiscountButtonState.Promotion);
		ShowOnSale((string)2, data);
		_Setup(forceEndDiscount: true);
		((GameOverLeaderboardHandler)(object)this).InsertPlayerScoreToLeaderboard(ref *(int*)2, ref *(int*)data, wasRestored, (byte)(int)validationResult != 0);
		PositionContent(DiscountButton.DiscountButtonState.Promotion);
	}

	private unsafe void _Setup(bool forceEndDiscount = false)
	{
		//IL_07fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ff: Expected Obj, but got Unknown
		//IL_0809: Expected Obj, but got VT
		//IL_0812: Unknown result type (might be due to invalid IL or missing references)
		//IL_0817: Expected Obj, but got Unknown
		//IL_0828: Unknown result type (might be due to invalid IL or missing references)
		//IL_082d: Expected VT, but got Unknown
		//IL_083a: Expected F4, but got Obj
		//IL_0835: Expected native int or pointer, but got VT
		//IL_0843: Unknown result type (might be due to invalid IL or missing references)
		//IL_0848: Expected Obj, but got Unknown
		//IL_0862: Expected F4, but got Obj
		//IL_085d: Expected native int or pointer, but got VT
		//IL_0877: Expected F4, but got I
		//IL_0872: Expected native int or pointer, but got VT
		//IL_0886: Expected I4, but got VT
		//IL_088f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0894: Expected Obj, but got Unknown
		//IL_089e: Expected Obj, but got VT
		//IL_08a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ac: Expected Obj, but got Unknown
		//IL_08c1: Expected F4, but got Obj
		//IL_08bc: Expected native int or pointer, but got VT
		//IL_08ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cf: Expected Obj, but got Unknown
		//IL_0012: Expected F4, but got Obj
		//IL_000d: Expected native int or pointer, but got VT
		//IL_0027: Expected F4, but got I
		//IL_0022: Expected native int or pointer, but got VT
		//IL_0030: Expected Obj, but got VT
		//IL_0042: Expected I, but got Obj
		//IL_0058: Expected Obj, but got I
		//IL_08ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ef: Expected Obj, but got Unknown
		//IL_08f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fd: Expected Obj, but got Unknown
		//IL_0906: Unknown result type (might be due to invalid IL or missing references)
		//IL_090b: Expected Obj, but got Unknown
		//IL_0914: Unknown result type (might be due to invalid IL or missing references)
		//IL_0919: Expected Obj, but got Unknown
		//IL_0922: Unknown result type (might be due to invalid IL or missing references)
		//IL_0927: Expected Obj, but got Unknown
		//IL_0930: Expected Obj, but got VT
		//IL_093d: Expected F4, but got Obj
		//IL_0938: Expected native int or pointer, but got VT
		//IL_094c: Expected I4, but got VT
		//IL_0955: Unknown result type (might be due to invalid IL or missing references)
		//IL_095a: Expected Obj, but got Unknown
		//IL_0964: Expected Obj, but got VT
		//IL_096d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0972: Expected Obj, but got Unknown
		//IL_0987: Expected F4, but got Obj
		//IL_0982: Expected native int or pointer, but got VT
		//IL_0990: Unknown result type (might be due to invalid IL or missing references)
		//IL_0995: Expected Obj, but got Unknown
		//IL_09af: Expected F4, but got Obj
		//IL_09aa: Expected native int or pointer, but got VT
		//IL_09c4: Expected F4, but got I
		//IL_09bf: Expected native int or pointer, but got VT
		//IL_09d3: Expected I4, but got VT
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected Obj, but got Unknown
		//IL_00da: Expected Obj, but got VT
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected Obj, but got Unknown
		//IL_00fd: Expected F4, but got Obj
		//IL_00f8: Expected native int or pointer, but got VT
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected Obj, but got Unknown
		//IL_0125: Expected F4, but got Obj
		//IL_0120: Expected native int or pointer, but got VT
		//IL_013a: Expected F4, but got I
		//IL_0135: Expected native int or pointer, but got VT
		//IL_0143: Expected Obj, but got VT
		//IL_0083: Expected I, but got Obj
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected Obj, but got Unknown
		//IL_0164: Expected Obj, but got VT
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected Obj, but got Unknown
		//IL_0187: Expected F4, but got Obj
		//IL_0182: Expected native int or pointer, but got VT
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected Obj, but got Unknown
		//IL_01af: Expected F4, but got Obj
		//IL_01aa: Expected native int or pointer, but got VT
		//IL_01c4: Expected F4, but got I
		//IL_01bf: Expected native int or pointer, but got VT
		//IL_01d3: Expected I4, but got VT
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Expected Obj, but got Unknown
		//IL_01f0: Expected Obj, but got VT
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected Obj, but got Unknown
		//IL_0213: Expected F4, but got Obj
		//IL_020e: Expected native int or pointer, but got VT
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Expected Obj, but got Unknown
		//IL_023b: Expected F4, but got Obj
		//IL_0236: Expected native int or pointer, but got VT
		//IL_0250: Expected F4, but got I
		//IL_024b: Expected native int or pointer, but got VT
		//IL_0259: Expected Obj, but got VT
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Expected Obj, but got Unknown
		//IL_027a: Expected Obj, but got VT
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Expected Obj, but got Unknown
		//IL_029d: Expected F4, but got Obj
		//IL_0298: Expected native int or pointer, but got VT
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Expected Obj, but got Unknown
		//IL_02c5: Expected F4, but got Obj
		//IL_02c0: Expected native int or pointer, but got VT
		//IL_02da: Expected F4, but got I
		//IL_02d5: Expected native int or pointer, but got VT
		//IL_02e9: Expected I4, but got VT
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Expected Obj, but got Unknown
		//IL_0306: Expected Obj, but got VT
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Expected Obj, but got Unknown
		//IL_0329: Expected F4, but got Obj
		//IL_0324: Expected native int or pointer, but got VT
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_0337: Expected Obj, but got Unknown
		//IL_0351: Expected F4, but got Obj
		//IL_034c: Expected native int or pointer, but got VT
		//IL_0366: Expected F4, but got I
		//IL_0361: Expected native int or pointer, but got VT
		//IL_036f: Expected Obj, but got VT
		//IL_0381: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Expected Obj, but got Unknown
		//IL_0390: Expected Obj, but got VT
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Expected Obj, but got Unknown
		//IL_03b3: Expected F4, but got Obj
		//IL_03ae: Expected native int or pointer, but got VT
		//IL_03bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Expected Obj, but got Unknown
		//IL_03db: Expected F4, but got Obj
		//IL_03d6: Expected native int or pointer, but got VT
		//IL_03f0: Expected F4, but got I
		//IL_03eb: Expected native int or pointer, but got VT
		//IL_03ff: Expected I4, but got VT
		//IL_040d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0412: Expected Obj, but got Unknown
		//IL_041c: Expected Obj, but got VT
		//IL_0425: Unknown result type (might be due to invalid IL or missing references)
		//IL_042a: Expected Obj, but got Unknown
		//IL_043f: Expected F4, but got Obj
		//IL_043a: Expected native int or pointer, but got VT
		//IL_0448: Unknown result type (might be due to invalid IL or missing references)
		//IL_044d: Expected Obj, but got Unknown
		//IL_0467: Expected F4, but got Obj
		//IL_0462: Expected native int or pointer, but got VT
		//IL_047c: Expected F4, but got I
		//IL_0477: Expected native int or pointer, but got VT
		//IL_0485: Expected Obj, but got VT
		//IL_0497: Unknown result type (might be due to invalid IL or missing references)
		//IL_049c: Expected Obj, but got Unknown
		//IL_04a6: Expected Obj, but got VT
		//IL_04af: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b4: Expected Obj, but got Unknown
		//IL_04c9: Expected F4, but got Obj
		//IL_04c4: Expected native int or pointer, but got VT
		//IL_04d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d7: Expected Obj, but got Unknown
		//IL_04f1: Expected F4, but got Obj
		//IL_04ec: Expected native int or pointer, but got VT
		//IL_0506: Expected F4, but got I
		//IL_0501: Expected native int or pointer, but got VT
		//IL_0515: Expected I4, but got VT
		//IL_0523: Unknown result type (might be due to invalid IL or missing references)
		//IL_0528: Expected Obj, but got Unknown
		//IL_052e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0533: Expected Obj, but got Unknown
		//IL_0544: Unknown result type (might be due to invalid IL or missing references)
		//IL_0549: Expected Obj, but got Unknown
		//IL_055e: Expected F4, but got Obj
		//IL_0559: Expected native int or pointer, but got VT
		//IL_0567: Unknown result type (might be due to invalid IL or missing references)
		//IL_056c: Expected Obj, but got Unknown
		//IL_0586: Expected F4, but got Obj
		//IL_0581: Expected native int or pointer, but got VT
		//IL_059b: Expected F4, but got I
		//IL_0596: Expected native int or pointer, but got VT
		//IL_05aa: Expected I4, but got VT
		//IL_05bd: Expected Obj, but got I4
		//IL_0606: Expected Obj, but got VT
		//IL_061b: Expected F4, but got Obj
		//IL_0616: Expected native int or pointer, but got VT
		//IL_0635: Expected F4, but got Obj
		//IL_0630: Expected native int or pointer, but got VT
		//IL_064a: Expected F4, but got I
		//IL_0645: Expected native int or pointer, but got VT
		//IL_0659: Expected I4, but got VT
		//IL_0668: Expected Obj, but got VT
		//IL_067d: Expected F4, but got Obj
		//IL_0678: Expected native int or pointer, but got VT
		//IL_0697: Expected F4, but got Obj
		//IL_0692: Expected native int or pointer, but got VT
		//IL_06ac: Expected F4, but got I
		//IL_06a7: Expected native int or pointer, but got VT
		//IL_06b5: Expected Obj, but got VT
		//IL_06cd: Expected Obj, but got VT
		//IL_06e2: Expected F4, but got Obj
		//IL_06dd: Expected native int or pointer, but got VT
		//IL_06fc: Expected F4, but got Obj
		//IL_06f7: Expected native int or pointer, but got VT
		//IL_0711: Expected F4, but got I
		//IL_070c: Expected native int or pointer, but got VT
		//IL_0720: Expected I4, but got VT
		//IL_072f: Expected Obj, but got VT
		//IL_0744: Expected F4, but got Obj
		//IL_073f: Expected native int or pointer, but got VT
		//IL_075e: Expected F4, but got Obj
		//IL_0759: Expected native int or pointer, but got VT
		//IL_0773: Expected F4, but got I
		//IL_076e: Expected native int or pointer, but got VT
		//IL_077c: Expected Obj, but got VT
		//IL_078b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0790: Expected Obj, but got Unknown
		//IL_07ad: Expected F4, but got Obj
		//IL_07a8: Expected native int or pointer, but got VT
		//IL_07c7: Expected F4, but got Obj
		//IL_07c2: Expected native int or pointer, but got VT
		//IL_07dc: Expected F4, but got I
		//IL_07d7: Expected native int or pointer, but got VT
		//IL_07eb: Expected I4, but got VT
		object obj2 = default;
		object obj = obj2 + 304;
		obj = titleColor;
		object obj3 = obj2 + 348;
		obj3 = obj;
		Matrix4x4 matrix4x = (Matrix4x4)(obj2 + 352);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
		object obj4 = obj2 + 288;
		Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S1_v10+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		title.rawPivot = (UIWidget.Pivot)matrix4x;
		object obj5 = obj2 + 284;
		obj5 = titleColorShadow;
		object obj6 = obj2 + 344;
		obj6 = obj5;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj6;
		object obj7 = obj2 + 264;
		Matrix4x4 matrix4x3 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S1_v20+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		Vector2 effectDistance = ((UILabel)matrix4x).effectDistance;
		nint num = (nint)typeof(DiscountButton);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S1_v25 (Il2CppClass<UI.DiscountButton>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num2 = (nint)typeof(DiscountButton);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S1_v179 (Il2CppClass<UI.DiscountButton>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj9 = obj2 + 256;
		object obj10 = obj2 + 252;
		object obj11 = obj2 + 224;
		object obj12 = obj2 + 216;
		object obj13 = obj2 + 196;
		obj2 = DiscountButton.SHADOW_OFFSET;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj2;
		title.shrinkToFit = (byte)(int)matrix4x != 0;
		object obj14 = obj2 + 248;
		obj14 = description2Color;
		object obj15 = obj2 + 340;
		obj15 = obj14;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj15;
		object obj16 = obj2 + 232;
		Matrix4x4 matrix4x4 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S1_v48+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		description2.rawPivot = (UIWidget.Pivot)matrix4x;
		object obj17 = obj2 + 220;
		obj17 = description2ColorShadow;
		object obj18 = obj2 + 336;
		obj18 = obj17;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj18;
		object obj19 = obj2 + 200;
		Matrix4x4 matrix4x5 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S1_v58+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		Vector2 effectDistance2 = ((UILabel)matrix4x).effectDistance;
		object obj20 = obj2 + 192;
		obj20 = priceColor;
		object obj21 = obj2 + 332;
		obj21 = obj20;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj21;
		object obj22 = obj2 + 176;
		Matrix4x4 matrix4x6 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ S1_v68+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		price.rawPivot = (UIWidget.Pivot)matrix4x;
		object obj23 = obj2 + 168;
		obj23 = priceColorShadow;
		object obj24 = obj2 + 328;
		obj24 = obj23;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj24;
		object obj25 = obj2 + 152;
		Matrix4x4 matrix4x7 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ S1_v78+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		Vector2 effectDistance3 = ((UILabel)matrix4x).effectDistance;
		object obj26 = obj2 + 144;
		obj26 = limitedTimerColor;
		object obj27 = obj2 + 324;
		obj27 = obj26;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj27;
		object obj28 = obj2 + 128;
		Matrix4x4 matrix4x8 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj28;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ S1_v88+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		limitedTitle.rawPivot = (UIWidget.Pivot)matrix4x;
		object obj29 = obj2 + 120;
		obj29 = limitedTimerColorShadow;
		object obj30 = obj2 + 320;
		obj30 = obj29;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj30;
		object obj31 = obj2 + 104;
		Matrix4x4 matrix4x9 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj31;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ S1_v98+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		Vector2 effectDistance4 = ((UILabel)matrix4x).effectDistance;
		object obj32 = obj2 + 96;
		obj32 = limitedTimerColor;
		object obj33 = obj2 + 316;
		obj33 = obj32;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj33;
		object obj34 = obj2 + 80;
		Matrix4x4 matrix4x10 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj34;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ S1_v108+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		limitedTime.rawPivot = (UIWidget.Pivot)matrix4x;
		object obj35 = obj2 + 72;
		obj35 = limitedTimerColorShadow;
		object obj36 = obj2 + 312;
		obj36 = obj35;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj36;
		object obj37 = obj2 + 56;
		Matrix4x4 matrix4x11 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj37;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ S1_v118+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		Vector2 effectDistance5 = ((UILabel)matrix4x).effectDistance;
		object obj38 = obj2 + 48;
		obj38 = stickerColor;
		object obj39 = obj2 + 308;
		obj39 = obj38;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj39;
		object obj40 = obj2 + 32;
		Matrix4x4 matrix4x12 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj40;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ S1_v128+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		discountSticker.rawPivot = (UIWidget.Pivot)matrix4x;
		object obj41 = obj2 + 24;
		object obj42 = this - -64;
		obj41 = obj42;
		object obj43 = obj2 + 280;
		obj43 = obj41;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj43;
		object obj44 = obj2 + 8;
		Matrix4x4 matrix4x13 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj44;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ S1_v138+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		discountLabel.rawPivot = (UIWidget.Pivot)matrix4x;
		object obj45 = (forceEndDiscount ? 1 : 0) - 1;
		if (!forceEndDiscount)
		{
			if ((nint)obj45 == 1)
			{
				obj = description1ColorInactive;
				obj11 = obj;
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj11;
				Matrix4x4 matrix4x14 = Matrix4x4.Inverse(matrix4x);
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S1_v10+8]");
				((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
				description1.rawPivot = (UIWidget.Pivot)matrix4x;
				obj5 = description1ColorShadowInactive;
				obj12 = obj5;
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj12;
				Matrix4x4 matrix4x15 = Matrix4x4.Inverse(matrix4x);
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S1_v20+8]");
				((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
				Vector2 effectDistance6 = ((UILabel)matrix4x).effectDistance;
				object obj46 = this - -64;
				obj14 = obj46;
				obj13 = obj14;
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj13;
				Matrix4x4 matrix4x16 = Matrix4x4.Inverse(matrix4x);
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S1_v48+8]");
				((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
				discountLabelSingleLine.rawPivot = (UIWidget.Pivot)matrix4x;
			}
		}
		else
		{
			obj = description1ColorActive;
			obj9 = obj;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj9;
			Matrix4x4 matrix4x17 = Matrix4x4.Inverse(matrix4x);
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S1_v10+8]");
			((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
			description1.rawPivot = (UIWidget.Pivot)matrix4x;
			obj5 = description1ColorShadowActive;
			obj10 = obj5;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj10;
			Matrix4x4 matrix4x18 = Matrix4x4.Inverse(matrix4x);
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S1_v20+8]");
			((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
			Vector2 effectDistance7 = ((UILabel)matrix4x).effectDistance;
		}
	}

	public void Init()
	{
		//IL_0107: Expected Obj, but got I4
		//IL_0020: Expected I, but got Obj
		//IL_0036: Expected Obj, but got I
		//IL_013e: Expected I, but got Obj
		//IL_0154: Expected Obj, but got I
		//IL_0061: Expected I, but got Obj
		//IL_00ae: Expected I, but got Obj
		LogError((string)(object)this, (UnityEngine.Object)1);
		GameObject gameObject = base.gameObject;
		Transform parentInternal = ((Transform)(object)gameObject).parentInternal;
		string go = parentInternal.tag;
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v7 (Il2CppClass<NGUITools>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S1_v17 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UpgradeScreen upgradeScreen = NGUITools.FindInParents<UpgradeScreen>((GameObject)(object)go);
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v20 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)upgradeScreen).FindKernel((string)null) != 0)
		{
			upgradeScreen.FillTable();
		}
	}

	private void OnEnable()
	{
		_inited = true;
		LogError((string)(object)this);
	}

	private unsafe void OnDisable()
	{
		//IL_0161: Expected I, but got Obj
		//IL_0177: Expected Obj, but got I
		//IL_0230: Expected I, but got Obj
		//IL_0246: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Expected Obj, but got Unknown
		//IL_00ee: Expected I, but got Obj
		nint num = (nint)typeof(InAppManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<InApp.InAppManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v29 (Il2CppClass<InApp.InAppManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Dictionary<string, InAppItemModel> activeInAppOffers = InAppManager.GetActiveInAppOffers();
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v20 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)activeInAppOffers).FindKernel((string)null) != 0)
		{
			nint num5 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v19 (Il2CppClass<InApp.InAppManager>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(InAppManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v25 (Il2CppClass<InApp.InAppManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Dictionary<string, InAppItemModel> activeInAppOffers2 = InAppManager.GetActiveInAppOffers();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr = 0;
			InAppManager.OnPurchaseSuccess onPurchaseSuccess = default;
			((Delegate)onPurchaseSuccess).method_ptr = method_ptr;
			((Delegate)onPurchaseSuccess).method = (nint)__ldftn(DoubleCoinUpgradeHelper._DefaultSetup);
			object obj4 = onPurchaseSuccess + 16;
			obj4 = this;
			((InAppManager)(object)activeInAppOffers2).onPurchaseSuccess -= onPurchaseSuccess;
		}
		if (~(_inited ? 1u : 0u) == 0)
		{
			LogError((string)(object)this);
		}
	}

	private unsafe void UpdatePrice()
	{
		//IL_013c: Expected I, but got Obj
		//IL_0152: Expected Obj, but got I
		//IL_020b: Expected I, but got Obj
		//IL_0221: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Expected Obj, but got Unknown
		//IL_00ee: Expected I, but got Obj
		nint num = (nint)typeof(InAppManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<InApp.InAppManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v25 (Il2CppClass<InApp.InAppManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Dictionary<string, InAppItemModel> activeInAppOffers = InAppManager.GetActiveInAppOffers();
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v18 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)activeInAppOffers).FindKernel((string)null) == 0)
		{
			return;
		}
		nint num5 = (nint)typeof(InAppManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v15 (Il2CppClass<InApp.InAppManager>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v21 (Il2CppClass<InApp.InAppManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Dictionary<string, InAppItemModel> activeInAppOffers2 = InAppManager.GetActiveInAppOffers();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		InAppManager.OnPurchaseFailure onPurchaseFailure = default;
		((Delegate)onPurchaseFailure).method_ptr = method_ptr;
		((Delegate)onPurchaseFailure).method = (nint)__ldftn(DoubleCoinUpgradeHelper._DefaultSetup);
		object obj4 = onPurchaseFailure + 16;
		obj4 = this;
		((InAppManager)(object)activeInAppOffers2).onPurchaseFailure += onPurchaseFailure;
	}

	private void OnClick()
	{
		//IL_0061: Expected I, but got Obj
		//IL_0077: Expected Obj, but got I
		//IL_00c4: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(InAppData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<InApp.InAppData>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(InAppData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v12 (Il2CppClass<InApp.InAppData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		InAppItemModel objectToClone = InAppData.inAppData.get_Item(doubleCoinVersion);
		InAppItemModel inAppItemModel = InAppItemModel.Clone(objectToClone);
		price.fontSize = (int)inAppItemModel;
	}

	protected override void ShowOnPromotion(string productString, string sendDescription, string sendDescription2)
	{
		LogError((string)(object)this);
	}

	protected unsafe override void ShowOnSale(string productString, string sendDescription = "")
	{
		//IL_05a4: Expected Obj, but got I4
		//IL_05de: Expected Obj, but got I4
		//IL_05ec: Expected I, but got Obj
		//IL_0602: Expected Obj, but got I
		//IL_0628: Unknown result type (might be due to invalid IL or missing references)
		//IL_062d: Expected VT, but got Unknown
		//IL_0636: Unknown result type (might be due to invalid IL or missing references)
		//IL_063b: Expected Obj, but got Unknown
		//IL_0644: Unknown result type (might be due to invalid IL or missing references)
		//IL_0649: Expected Obj, but got Unknown
		//IL_01ce: Expected I, but got Obj
		//IL_01e4: Expected Obj, but got I
		//IL_0061: Expected I, but got Obj
		//IL_00ae: Expected I, but got Obj
		//IL_00c4: Expected Obj, but got I
		//IL_027a: Expected Obj, but got I4
		//IL_020f: Expected I, but got Obj
		//IL_0696: Expected Obj, but got I4
		//IL_00ef: Expected I, but got Obj
		//IL_014b: Expected Obj, but got I4
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Expected Obj, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected Obj, but got Unknown
		//IL_0178: Expected F4, but got Obj
		//IL_0173: Expected native int or pointer, but got VT
		//IL_0192: Expected F4, but got Obj
		//IL_018d: Expected native int or pointer, but got VT
		//IL_01a7: Expected F4, but got I
		//IL_01a2: Expected native int or pointer, but got VT
		//IL_01b6: Expected I4, but got VT
		//IL_03d2: Expected I, but got Obj
		//IL_03e8: Expected Obj, but got I
		//IL_072f: Expected I, but got Obj
		//IL_0745: Expected Obj, but got I
		//IL_033a: Expected I, but got Obj
		//IL_0350: Expected Obj, but got I
		//IL_077e: Expected I, but got Obj
		//IL_0794: Expected Obj, but got I
		//IL_0413: Expected I, but got Obj
		//IL_06f8: Expected I4, but got Obj
		//IL_07ba: Expected Obj, but got I4
		//IL_07cc: Expected I, but got Obj
		//IL_07e2: Expected Obj, but got I
		//IL_0460: Expected I, but got Obj
		//IL_037b: Expected I, but got Obj
		//IL_081a: Expected F4, but got I4
		//IL_0815: Expected native int or pointer, but got VT
		//IL_04ad: Expected I, but got Obj
		//IL_0548: Expected I4, but got Obj
		//IL_04fa: Expected I, but got Obj
		string text = discountSticker.tag;
		bool flag = productString == null;
		bool flag2 = !flag && _showDiscountSticker;
		bool flag3 = flag2;
		((GameObject)(object)text).tag = (string)flag3;
		bool flag4 = !flag && _showDiscountSticker;
		bool flag5 = flag4;
		discountSticker.tag = (string)flag5;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v16 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v92 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = default;
		Matrix4x4 matrix4x = (Matrix4x4)(obj2 + 24);
		object obj3 = obj2 + 20;
		object obj4 = obj2 + 16;
		if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)discountLabelSpecialSale))
		{
			nint num3 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v75 (Il2CppClass<InApp.InAppManager>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num4 = (nint)typeof(InAppManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v88 (Il2CppClass<InApp.InAppManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag6 = (nint)productString == 2;
			bool isWinterHolidaySpecialSaleActive = InAppManager.IsWinterHolidaySpecialSaleActive;
			object obj6 = flag6 & isWinterHolidaySpecialSaleActive;
			if (obj6 != null)
			{
				string text2 = discountLabelSpecialSale.tag;
				((GameObject)(object)text2).tag = (string)1;
				object obj7 = this - -64;
				obj3 = obj7;
				obj4 = obj3;
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj4;
				Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
				discountLabelSpecialSale.rawPivot = (UIWidget.Pivot)matrix4x;
				return;
			}
		}
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S1_v19 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S1_v83 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)discountLabelSpecialSale))
		{
			string text3 = discountLabelSpecialSale.tag;
			((GameObject)(object)text3).tag = null;
		}
		string text4 = (string)((flag ? 1 : 0) ^ 1);
		discountLabel.tag = text4;
		string text5 = discountLabel.tag;
		((GameObject)(object)text5).tag = text4;
		discountLabelSingleLine.tag = text4;
		string text6 = discountLabelSingleLine.tag;
		((GameObject)(object)text6).tag = text4;
		object obj9 = productString - 1;
		if ((nint)productString != 1)
		{
			if ((nint)obj9 != 1)
			{
				return;
			}
			nint num7 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ S1_v70 (Il2CppClass<Strings>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num8 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ S1_v77 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text7 = Strings.GetDefault("COOL_DEAL_SINGLE_LINE");
			discountLabelSingleLine.fontSize = (int)text7;
			return;
		}
		nint num9 = (nint)typeof(InAppData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ S0_v49 (Il2CppClass<InApp.InAppData>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num10 = (nint)typeof(InAppData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ S0_v63 (Il2CppClass<InApp.InAppData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		InAppItemModel inAppItemModel = InAppData.inAppData.get_Item(sendDescription);
		string ignoredInAppOnlineSettingsId = InAppData.GetIgnoredInAppOnlineSettingsId(inAppItemModel.normalOfferId);
		nint num11 = (nint)typeof(InAppManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ S1_v37 (Il2CppClass<InApp.InAppManager>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num12 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ S1_v65 (Il2CppClass<InApp.InAppManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag7 = InAppManager.TryAddTransactionToHistory(ignoredInAppOnlineSettingsId, null);
		nint num13 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ S1_v43 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num14 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ S1_v61 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num15 = Mathf.Min((int[])flag7);
		nint num16 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ S1_v49 (Il2CppClass<Strings>)+BA]");
		object obj14 = (nint)0 & (nint)0x200;
		if (obj14 != null)
		{
			nint num17 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ S1_v57 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string format = Strings.GetDefault("DISCOUNT_BUTTON_COOL_OFF");
		((Matrix4x4*)(nint)matrix4x)->m00 = num15;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		object[] args = default;
		string text8 = string.Format(format, args);
		discountLabel.fontSize = (int)text8;
	}

	protected override void ShowNoDiscount(string productString, string backupDescription = "")
	{
		base.ShowNoDiscount(productString, backupDescription);
		DisableDiscount();
	}

	private void EnableDiscount()
	{
		//IL_00ef: Expected I, but got Obj
		//IL_0105: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_013a: Expected I4, but got Obj
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v25 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Dictionary<Characters.CharacterId, bool> hasCharacterBeenSeen = UserSave.hasCharacterBeenSeen;
		if (hasCharacterBeenSeen != null)
		{
			return;
		}
		nint num3 = (nint)typeof(InAppManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v15 (Il2CppClass<InApp.InAppManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v21 (Il2CppClass<InApp.InAppManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Dictionary<string, InAppItemModel> activeInAppOffers = InAppManager.GetActiveInAppOffers();
		((InAppManager)(object)activeInAppOffers).InitFinishedCallback((byte)(int)doubleCoinVersion != 0);
	}

	private void DisableDiscount()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected Obj, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected Obj, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected Obj, but got Unknown
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected Obj, but got Unknown
		Camera anchorCamera = discountSticker.anchorCamera;
		object obj2 = default;
		object obj = obj2 + 24;
		object obj3 = this + 356;
		obj = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S2_v3+8]");
		_ = 0;
		Transform transform = (Transform)(obj2 + 36);
		transform = (Transform)obj;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S1_v4+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
		Camera anchorCamera2 = discountLabel.anchorCamera;
		object obj4 = obj2 + 12;
		object obj5 = this + 368;
		obj4 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S2_v15+8]");
		_ = 0;
		transform = (Transform)obj4;
		Transform transform3 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v12+8]");
		((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles2 = transform.eulerAngles;
		Camera anchorCamera3 = discountLabelSingleLine.anchorCamera;
		object obj6 = this + 380;
		obj2 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S2_v25+8]");
		_ = 0;
		transform = (Transform)obj2;
		Transform transform4 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles3 = transform.eulerAngles;
	}

	public static void LogError(string msg, UnityEngine.Object context = null)
	{
		//IL_02af: Expected I, but got Obj
		//IL_02c5: Expected Obj, but got I
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Expected Obj, but got Unknown
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Expected Obj, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_0089: Expected I4, but got Obj
		//IL_0089: Expected Obj, but got I
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected Obj, but got Unknown
		//IL_00a4: Expected Obj, but got I
		//IL_00ce: Expected Obj, but got I
		//IL_00e0: Expected Obj, but got I4
		//IL_00ef: Expected Obj, but got F4
		//IL_0137: Expected Obj, but got I
		nint num = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v53 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = default;
		Transform transform = (Transform)(obj2 + 12);
		Dictionary<Characters.CharacterId, bool> hasCharacterBeenSeen = UserSave.hasCharacterBeenSeen;
		if (hasCharacterBeenSeen != null)
		{
			object obj3 = msg + 392;
			obj3 = "com.kiloo.subwaysurfers.doublecoins";
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7767");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+12C]");
			((UISprite)0).fillCenter = (byte)(int)"button_check_grey" != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+12C]");
			((UIWidget)0).depth = 4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+12C]");
			Camera anchorCamera = ((UIRect)0).anchorCamera;
			obj2 = 0;
			_ = 0;
			obj2 = 97f;
			_ = 2f;
			_ = 0f;
			transform = (Transform)obj2;
			Transform transform2 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
			Vector3 eulerAngles = transform.eulerAngles;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+124]");
			((Component)0).tag = null;
			BoxCollider component = ((Component)(object)msg).GetComponent<BoxCollider>();
			component.isTrigger = false;
			return;
		}
		IEnumerator enumerator = ((FacebookLoginButtonOnline)null).UserFeedback();
		object obj4 = enumerator ^ 1;
		object obj5 = obj4 | (object)context;
		if (obj5 == null)
		{
			object obj6 = msg + 392;
			obj6 = "com.kiloo.subwaysurfers.doublecoinsdiscount";
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7767");
			return;
		}
		object obj7 = msg + 392;
		obj7 = "com.kiloo.subwaysurfers.doublecoins";
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7767");
		GameObject gameObject = ((Component)(object)msg).gameObject;
		Transform parentInternal = ((Transform)(object)gameObject).parentInternal;
		UnityEngine.Object obj8 = UnityEngine.Object.Instantiate((UnityEngine.Object)parentInternal);
		if ((string)(object)obj8 != "000")
		{
			GameObject gameObject2 = ((Component)(object)msg).gameObject;
			GameObject gameObject3 = ((Component)(object)msg).gameObject;
			Transform parentInternal2 = ((Transform)(object)gameObject3).parentInternal;
			Transform parentInternal3 = parentInternal2.parentInternal;
			((Transform)(object)gameObject2).parentInternal = parentInternal3;
		}
	}

	public static void LogWarning(string msg, UnityEngine.Object context = null)
	{
		SDebug.LogFormat(msg, (object[])(object)context);
	}

	public static void Log(string msg, UnityEngine.Object context = null)
	{
	}

	public DoubleCoinUpgradeHelper()
	{
		//IL_012e: Expected I, but got Obj
		//IL_0144: Expected Obj, but got I
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected Obj, but got Unknown
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected Obj, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_0069: Expected Obj, but got I4
		//IL_0078: Expected Obj, but got F4
		//IL_0013: Expected I, but got Obj
		//IL_00cb: Expected Obj, but got I4
		//IL_00da: Expected Obj, but got F4
		Camera anchorCamera = discountSticker.anchorCamera;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v5 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S1_v34 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 24;
		Vector3 one = Vector3.one;
		Transform transform = (Transform)(obj3 + 36);
		transform = (Transform)obj2;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v10+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
		Camera anchorCamera2 = discountLabel.anchorCamera;
		object obj4 = obj3 + 12;
		obj4 = 0;
		_ = 0;
		obj4 = 0f;
		_ = 0f;
		_ = -1f;
		transform = (Transform)obj4;
		Transform transform3 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S1_v17+8]");
		((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles2 = transform.eulerAngles;
		Camera anchorCamera3 = discountLabelSingleLine.anchorCamera;
		obj3 = 0;
		_ = 0;
		obj3 = 0f;
		_ = 0f;
		_ = -1f;
		transform = (Transform)obj3;
		Transform transform4 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles3 = transform.eulerAngles;
	}
}
