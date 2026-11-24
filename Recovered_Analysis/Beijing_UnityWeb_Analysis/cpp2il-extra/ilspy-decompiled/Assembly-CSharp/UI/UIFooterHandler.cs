using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Data.Save;
using InApp;
using SYBO.Subway.Info;
using UnityEngine;

namespace UI;

public class UIFooterHandler : MonoBehaviour
{
	public UIButtonOverlayOff button0;

	public UIButtonOverlayOff button1;

	public UIButtonOverlayOff button2;

	public UIButtonOverlayOff button3;

	public GameObject boostDiscount;

	public GameObject coinshopDiscount;

	public GameObject specialSaleCoinshopDiscount;

	private UISprite[] discountStickers;

	private UILabel[] discountStickerLabels;

	private UISprite specialSaleDiscountSticker;

	private UILabel specialSaleDiscountStickerLabel;

	public void HandleStickers()
	{
		//IL_000b: Expected Obj, but got I4
		boostDiscount = (GameObject)1;
		CancelInvoke();
	}

	public unsafe UIFooterHandler()
	{
		//IL_0963: Expected I, but got Obj
		//IL_0979: Expected Obj, but got I
		//IL_0df6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dfb: Expected VT, but got Unknown
		//IL_0e04: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e09: Expected Obj, but got Unknown
		//IL_0e12: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e17: Expected Obj, but got Unknown
		//IL_0e20: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e25: Expected Obj, but got Unknown
		//IL_0e2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e33: Expected Obj, but got Unknown
		//IL_0e3c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e41: Expected Obj, but got Unknown
		//IL_0e4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e4f: Expected Obj, but got Unknown
		//IL_0e58: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e5d: Expected Obj, but got Unknown
		//IL_0e66: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e6b: Expected Obj, but got Unknown
		//IL_0e74: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e79: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected Obj, but got Unknown
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected Obj, but got Unknown
		//IL_01c7: Expected Obj, but got I4
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected Obj, but got Unknown
		//IL_012e: Expected I, but got Obj
		//IL_0144: Expected Obj, but got I
		//IL_0293: Expected I, but got Obj
		//IL_02a9: Expected Obj, but got I
		//IL_09d4: Expected Obj, but got VT
		//IL_09e9: Expected F4, but got Obj
		//IL_09e4: Expected native int or pointer, but got VT
		//IL_0a03: Expected F4, but got Obj
		//IL_09fe: Expected native int or pointer, but got VT
		//IL_0a18: Expected F4, but got I
		//IL_0a13: Expected native int or pointer, but got VT
		//IL_0a25: Expected I4, but got VT
		//IL_0a2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a33: Expected Obj, but got Unknown
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected Obj, but got Unknown
		//IL_0205: Expected I, but got Obj
		//IL_021b: Expected Obj, but got I
		//IL_016f: Expected I, but got Obj
		//IL_0bd9: Expected I, but got Obj
		//IL_0bef: Expected Obj, but got I
		//IL_02d4: Expected I, but got Obj
		//IL_0a68: Expected Obj, but got VT
		//IL_0a7d: Expected F4, but got Obj
		//IL_0a78: Expected native int or pointer, but got VT
		//IL_0a97: Expected F4, but got Obj
		//IL_0a92: Expected native int or pointer, but got VT
		//IL_0aac: Expected F4, but got I
		//IL_0aa7: Expected native int or pointer, but got VT
		//IL_0ab9: Expected I4, but got VT
		//IL_0ac2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac7: Expected Obj, but got Unknown
		//IL_0ebf: Expected Obj, but got I4
		//IL_0ed1: Expected I, but got Obj
		//IL_0ee7: Expected Obj, but got I
		//IL_0321: Expected I, but got Obj
		//IL_0337: Expected Obj, but got I
		//IL_0246: Expected I, but got Obj
		//IL_05c5: Expected I, but got Obj
		//IL_0612: Expected I, but got Obj
		//IL_0473: Expected I, but got Obj
		//IL_0489: Expected Obj, but got I
		//IL_0362: Expected I, but got Obj
		//IL_03af: Expected I, but got Obj
		//IL_03c5: Expected Obj, but got I
		//IL_04b4: Expected I, but got Obj
		//IL_0b48: Expected Obj, but got VT
		//IL_0b5d: Expected F4, but got Obj
		//IL_0b58: Expected native int or pointer, but got VT
		//IL_0b77: Expected F4, but got Obj
		//IL_0b72: Expected native int or pointer, but got VT
		//IL_0b8c: Expected F4, but got I
		//IL_0b87: Expected native int or pointer, but got VT
		//IL_0b9b: Expected I4, but got VT
		//IL_0ba4: Expected Obj, but got VT
		//IL_0bb9: Expected F4, but got Obj
		//IL_0bb4: Expected native int or pointer, but got VT
		//IL_0d26: Expected Obj, but got I4
		//IL_0501: Expected I, but got Obj
		//IL_0517: Expected Obj, but got I
		//IL_043c: Expected F4, but got Obj
		//IL_0437: Expected native int or pointer, but got VT
		//IL_0451: Expected F4, but got I
		//IL_044c: Expected native int or pointer, but got VT
		//IL_0460: Expected I4, but got VT
		//IL_03f0: Expected I, but got Obj
		//IL_0c37: Expected Obj, but got VT
		//IL_0c4c: Expected F4, but got Obj
		//IL_0c47: Expected native int or pointer, but got VT
		//IL_0c66: Expected F4, but got Obj
		//IL_0c61: Expected native int or pointer, but got VT
		//IL_0c7b: Expected F4, but got I
		//IL_0c76: Expected native int or pointer, but got VT
		//IL_0c8a: Expected I4, but got VT
		//IL_0c93: Expected Obj, but got VT
		//IL_0ca8: Expected F4, but got Obj
		//IL_0ca3: Expected native int or pointer, but got VT
		//IL_06b3: Expected I, but got Obj
		//IL_06c9: Expected Obj, but got I
		//IL_058e: Expected F4, but got Obj
		//IL_0589: Expected native int or pointer, but got VT
		//IL_05a3: Expected F4, but got I
		//IL_059e: Expected native int or pointer, but got VT
		//IL_05b2: Expected I4, but got VT
		//IL_0542: Expected I, but got Obj
		//IL_077d: Expected I, but got Obj
		//IL_0793: Expected Obj, but got I
		//IL_06f4: Expected I, but got Obj
		//IL_080c: Expected Obj, but got I4
		//IL_07be: Expected I, but got Obj
		//IL_0833: Expected I, but got Obj
		//IL_0849: Expected Obj, but got I
		//IL_0d96: Expected Obj, but got I4
		//IL_08cb: Expected I, but got Obj
		//IL_08e1: Expected Obj, but got I
		//IL_0874: Expected I, but got Obj
		//IL_0dd4: Expected Obj, but got I4
		//IL_090c: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v200 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = default;
		Matrix4x4 matrix4x = (Matrix4x4)(obj2 + 72);
		object obj3 = obj2 + 40;
		object obj4 = obj2 + 24;
		object obj5 = obj2 - -64;
		object obj6 = obj2 + 60;
		object obj7 = obj2 + 56;
		object obj8 = obj2 + 16;
		object obj9 = obj2 + 52;
		object obj10 = obj2 + 48;
		object obj11 = obj2 + 44;
		if (boostDiscount != null)
		{
			return;
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S1_v31 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S1_v196 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (coinshopDiscount != null)
		{
			return;
		}
		object obj13 = discountStickers + 12;
		object obj14 = default;
		object obj19 = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13))
		{
			object obj15 = discountStickers + 16;
			object obj16 = obj14 << 2;
			object obj17 = obj15 + obj16;
			nint num5 = (nint)typeof(GlobalColorsGenerated);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S1_v178 (Il2CppClass<GlobalColorsGenerated>)+BA]");
			object obj18 = (nint)0 & (nint)0x200;
			if (obj18 != null)
			{
				nint num6 = (nint)typeof(GlobalColorsGenerated);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S1_v190 (Il2CppClass<GlobalColorsGenerated>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj3 = GlobalColorsGenerated.DISCOUNT_STICKER_COLOR;
			obj5 = obj3;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj5;
			Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S1_v13+8]");
			((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
			((UIWidget)obj17).rawPivot = (UIWidget.Pivot)matrix4x;
			obj14 = obj19 + 1;
		}
		object obj20 = discountStickerLabels + 12;
		object obj21 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj21) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj20))
		{
			object obj22 = discountStickerLabels + 16;
			object obj23 = obj21 << 2;
			object obj24 = obj22 + obj23;
			nint num7 = (nint)typeof(GlobalColorsGenerated);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ S1_v156 (Il2CppClass<GlobalColorsGenerated>)+BA]");
			object obj25 = (nint)0 & (nint)0x200;
			if (obj25 != null)
			{
				nint num8 = (nint)typeof(GlobalColorsGenerated);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ S1_v168 (Il2CppClass<GlobalColorsGenerated>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj3 = GlobalColorsGenerated.DISCOUNT_STICKER_LABEL_COLOR;
			obj6 = obj3;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj6;
			Matrix4x4 matrix4x3 = Matrix4x4.Inverse(matrix4x);
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S1_v13+8]");
			((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
			((UIWidget)obj24).rawPivot = (UIWidget.Pivot)matrix4x;
			object obj26 = obj21 + 1;
			obj21 = obj26;
		}
		nint num9 = (nint)typeof(InAppManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ S0_v32 (Il2CppClass<InApp.InAppManager>)+BA]");
		object obj27 = (nint)0 & (nint)0x200;
		if (obj27 != null)
		{
			nint num10 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ S0_v143 (Il2CppClass<InApp.InAppManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (InAppManager.IsWinterHolidaySpecialSaleActive)
		{
			nint num11 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ S0_v114 (Il2CppClass<InApp.InAppManager>)+BA]");
			object obj28 = (nint)0 & (nint)0x200;
			if (obj28 != null)
			{
				nint num12 = (nint)typeof(InAppManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ S0_v139 (Il2CppClass<InApp.InAppManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (InAppManager.IsNewYearSpecialSaleActive)
			{
				nint num13 = (nint)typeof(GlobalColors);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ S1_v128 (Il2CppClass<GlobalColors>)+BA]");
				object obj29 = (nint)0 & (nint)0x200;
				if (obj29 != null)
				{
					nint num14 = (nint)typeof(GlobalColors);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ S1_v146 (Il2CppClass<GlobalColors>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj3 = GlobalColors.SPECIAL_DISCOUNT_WINTER_HOLIDAY_STICKER_COLOR;
				obj7 = obj3;
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj7;
				Matrix4x4 matrix4x4 = Matrix4x4.Inverse(matrix4x);
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S1_v13+8]");
				((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
				specialSaleDiscountSticker.rawPivot = (UIWidget.Pivot)matrix4x;
				obj8 = GlobalColors.SPECIAL_DISCOUNT_WINTER_HOLIDAY_STICKER_LABEL_COLOR;
				obj9 = obj8;
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj9;
				Matrix4x4 matrix4x5 = Matrix4x4.Inverse(matrix4x);
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
				specialSaleDiscountStickerLabel.rawPivot = (UIWidget.Pivot)matrix4x;
			}
			else
			{
				nint num15 = (nint)typeof(InAppManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ S0_v121 (Il2CppClass<InApp.InAppManager>)+BA]");
				object obj30 = (nint)0 & (nint)0x200;
				if (obj30 != null)
				{
					nint num16 = (nint)typeof(InAppManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ S0_v131 (Il2CppClass<InApp.InAppManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (AdsSave.behavioralAdsAllowed)
				{
					nint num17 = (nint)typeof(GlobalColors);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ S1_v103 (Il2CppClass<GlobalColors>)+BA]");
					object obj31 = (nint)0 & (nint)0x200;
					if (obj31 != null)
					{
						nint num18 = (nint)typeof(GlobalColors);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ S1_v121 (Il2CppClass<GlobalColors>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					obj3 = GlobalColors.SPECIAL_DISCOUNT_NEW_YEAR_STICKER_COLOR;
					obj10 = obj3;
					((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj10;
					Matrix4x4 matrix4x6 = Matrix4x4.Inverse(matrix4x);
					((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S1_v13+8]");
					((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
					specialSaleDiscountSticker.rawPivot = (UIWidget.Pivot)matrix4x;
					obj8 = GlobalColors.SPECIAL_DISCOUNT_NEW_YEAR_STICKER_LABEL_COLOR;
					obj11 = obj8;
					((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj11;
					Matrix4x4 matrix4x7 = Matrix4x4.Inverse(matrix4x);
					((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
					specialSaleDiscountStickerLabel.rawPivot = (UIWidget.Pivot)matrix4x;
				}
			}
		}
		nint num19 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ S0_v40 (Il2CppClass<UIScreenController>)+BA]");
		object obj32 = (nint)0 & (nint)0x200;
		if (obj32 != null)
		{
			nint num20 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ S0_v109 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		IEnumerator enumerator = ((UIScreenController)flag).DelayHideMainCamera();
		nint num21 = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ S0_v48 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj33 = (nint)0 & (nint)0x200;
		if (obj33 != null)
		{
			nint num22 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ S0_v105 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string flurryUserId = Flurry.flurryUserId;
		bool flag2;
		if (((SSEventsManagerController)(object)flurryUserId).DoesCharacterMatchCurrentEvent(Characters.CharacterId.slick))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			object obj34 = default;
			flag2 = (nint)obj34 != 4;
		}
		else
		{
			flag2 = true;
		}
		bool flag3 = (string)(object)enumerator != "CoinsUI_shop" || (string)(object)enumerator != "EarnCoinsScreen";
		object obj35 = flag3 & flag2;
		bool flag4;
		if (obj35 != null)
		{
			nint num23 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ S0_v87 (Il2CppClass<InApp.InAppManager>)+BA]");
			object obj36 = (nint)0 & (nint)0x200;
			if (obj36 != null)
			{
				nint num24 = (nint)typeof(InAppManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ S0_v93 (Il2CppClass<InApp.InAppManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			flag4 = InAppManager.IsAnyCurrencyDiscountActive;
		}
		else
		{
			flag4 = false;
		}
		bool flag5;
		if ((string)(object)enumerator == "UpgradesUI_shop" && !((string)(object)enumerator != "EarnCoinsScreen"))
		{
			flag5 = false;
		}
		else
		{
			nint num25 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ S0_v72 (Il2CppClass<InApp.InAppManager>)+BA]");
			object obj37 = (nint)0 & (nint)0x200;
			if (obj37 != null)
			{
				nint num26 = (nint)typeof(InAppManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v577 @ S0_v78 (Il2CppClass<InApp.InAppManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			flag5 = InAppManager.IsDoubleCoinsDiscountActive;
		}
		boostDiscount.tag = (string)flag4;
		string text;
		if (flag5)
		{
			nint num27 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v601 @ S1_v78 (Il2CppClass<InApp.InAppManager>)+BA]");
			object obj38 = (nint)0 & (nint)0x200;
			if (obj38 != null)
			{
				nint num28 = (nint)typeof(InAppManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v608 @ S1_v85 (Il2CppClass<InApp.InAppManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool isWinterHolidaySpecialSaleActive = InAppManager.IsWinterHolidaySpecialSaleActive;
			text = (string)((isWinterHolidaySpecialSaleActive ? 1 : 0) ^ 1);
		}
		else
		{
			text = null;
		}
		coinshopDiscount.tag = text;
		string text2;
		if (flag5)
		{
			nint num29 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v627 @ S1_v66 (Il2CppClass<InApp.InAppManager>)+BA]");
			object obj39 = (nint)0 & (nint)0x200;
			if (obj39 != null)
			{
				nint num30 = (nint)typeof(InAppManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v634 @ S1_v72 (Il2CppClass<InApp.InAppManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool isWinterHolidaySpecialSaleActive2 = InAppManager.IsWinterHolidaySpecialSaleActive;
			text2 = (string)isWinterHolidaySpecialSaleActive2;
		}
		else
		{
			text2 = null;
		}
		specialSaleCoinshopDiscount.tag = text2;
	}
}
