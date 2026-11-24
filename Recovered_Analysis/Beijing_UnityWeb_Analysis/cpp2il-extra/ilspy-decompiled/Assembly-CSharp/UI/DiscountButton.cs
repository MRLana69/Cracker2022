using System;
using System.Collections;
using System.Collections.Generic;
using Cloud.Internal;
using Cpp2ILInjected;
using Data.Managers;
using Data.Save;
using InApp;
using Info;
using Kiloo.Common.Extensions;
using SYBO.Subway.Info;
using SYBO.Subway.Promotion;
using UI.FreeStuff;
using UI.Generic;
using UI.Popups.LimitedBoardPopupInternal;
using UI.Popups.LimitedCharacterPopupInternal;
using UI.Screens;
using UnityEngine;

namespace UI;

public class DiscountButton : MonoBehaviour
{
	private enum DiscountButtonState
	{
		Normal,
		Sale,
		Promotion
	}

	protected const int SALE_BUTTON_GROWTH = 12;

	protected const int LINETHROUGH_WIDTH_OFFSET = 6;

	protected static Vector2 SHADOW_OFFSET;

	protected static Vector3 PRICE_DISCOUNT_OFFSET;

	protected Color32 titleColor;

	protected Color32 titleColorShadow;

	protected Color32 description1ColorInactive;

	protected Color32 description1ColorShadowInactive;

	protected Color32 description1ColorActive;

	protected Color32 description1ColorShadowActive;

	protected Color32 description2Color;

	protected Color32 description2ColorShadow;

	protected Color32 priceColor;

	protected Color32 priceColorShadow;

	protected Color32 limitedTimerColor;

	protected Color32 limitedTimerColorShadow;

	protected Color32 stickerColor;

	protected Color32 stickerLabelColor;

	protected Color32 lineThroughColor;

	protected Color32 lineThroughShadowColor;

	protected const string SPRITE_NAME_ICON_BACKGROUND_NORMAL = "icon_background_normal";

	protected const string SPRITE_NAME_ICON_BACKGROUND_KEYS = "icon_background_keys";

	protected const string SPRITE_NAME_ICON_BACKGROUND_THEME = "icon_background_theme";

	protected string SPRITE_NAME_FILL_SHOPITEM_HIGHLIGHT_SALE;

	protected string SPRITE_NAME_FILL_SHOPITEM_MAIN_SALE;

	protected const string SPRITE_NAME_SALE_STRIKEOVER_HIGH = "sale_strikeover_hi";

	protected const string SPRITE_NAME_SALE_STRIKEOVER_LOW = "sale_strikeover_lo";

	protected const string ONLINE_SETTINGS_KEY_DISCOUNT_DEAL_NAME = "discount_deal_name";

	protected string iconBackgroundNormalSpriteName;

	protected string iconBackgroundKeysSpriteName;

	protected Vector3 originalMainTextPosition;

	protected Vector3 originalDescriptionPosition;

	protected Vector3 originalPricePosition;

	protected Color32 originalPriceColor;

	protected Color32 originalPriceColorShadow;

	protected Vector3 originalFillGrayScale;

	protected Vector3 originalFillColorScale;

	protected Vector3 originalOutlineScale;

	protected Vector3 originalContentPosition;

	protected string originalFillColorSpirteName;

	protected string originalFillGraySpriteName;

	protected Color32 originalTitleColor;

	protected Color32 originalTitleColorShadow;

	protected Vector2 originalTitleDistanceShadow;

	protected Color32 originalDescription1Color;

	protected Color32 originalDescription1ColorShadow;

	protected Color32 originalDescription2Color;

	protected Color32 originalDescription2ColorShadow;

	protected Vector2 originalIconSize;

	protected Vector2 originalIconBGSize;

	protected Vector3 originalIconBGPosition;

	protected Vector3 originalWidgetScale;

	protected UISprite iconBG;

	protected UISprite icon;

	protected UILabel title;

	protected UILabel description1;

	protected UILabel description2;

	protected UISprite lineThrough;

	protected UISprite lineThroughShadow;

	protected UILabel price;

	protected UISprite fillGraySprite;

	protected UISprite fillColorSprite;

	protected UISprite outlineSprite;

	protected Transform content;

	protected Transform leftContent;

	protected Transform rightContent;

	protected Transform mainTextContent;

	protected UISprite discountSticker;

	protected UILabel discountLabel;

	protected UILabel discountLabelSingleLine;

	protected UILabel limitedTitle;

	protected UILabel limitedTime;

	protected UILabel discountLabelSpecialSale;

	protected UIWidget _widget;

	protected bool _showDiscountSticker;

	public virtual void Awake()
	{
		CancelInvoke();
	}

	public virtual bool SupportsSpecialSale()
	{
		//IL_01c6: Expected Obj, but got I
		//IL_01dc: Expected Obj, but got I
		//IL_0035: Expected I, but got Obj
		//IL_004b: Expected Obj, but got I
		//IL_021f: Expected Obj, but got I
		//IL_022f: Expected Obj, but got I
		//IL_00bd: Expected I4, but got Obj
		//IL_0076: Expected I, but got Obj
		//IL_00d0: Expected I, but got Obj
		//IL_00e6: Expected Obj, but got I
		//IL_0272: Expected Obj, but got I
		//IL_0282: Expected Obj, but got I
		//IL_0158: Expected I4, but got Obj
		//IL_0111: Expected I, but got Obj
		//IL_016d: Expected Obj, but got I
		//IL_017d: Expected Obj, but got I
		//IL_01b1: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.DiscountButton)+16C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+28]");
		object obj2 = -5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+28]");
		object obj5;
		if ((nint)0 != 5)
		{
			if ((nint)obj2 == 1)
			{
				nint num = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v27 (Il2CppClass<Strings>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num2 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v35 (Il2CppClass<Strings>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string format = Strings.GetDefault("COIN_BUTTON_HELPER_NUMBER_OF_KEYS");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.DiscountButton)+16C]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S2_v8+14]");
				obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				object[] args = default;
				string text = string.Format(format, args);
				return (byte)(int)text != 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.DiscountButton)+16C]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S1_v19+28]");
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			string text2 = default;
			string msg = "Item type not supported in CoinButtonHelper: " + text2;
			SDebug.LogFormat(msg, null);
			return (byte)(int)string.Empty != 0;
		}
		nint num3 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v14 (Il2CppClass<Strings>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num4 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v22 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string format2 = Strings.GetDefault("COIN_BUTTON_HELPER_NUMBER_OF_COINS");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.DiscountButton)+16C]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S2_v3+14]");
		obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		object[] args2 = default;
		string text3 = string.Format(format2, args2);
		return (byte)(int)text3 != 0;
	}

	protected virtual void ShowOnPromotion(string productString, string backupDescription, string backupDescription2)
	{
		//IL_068c: Expected Obj, but got VT
		//IL_0698: Expected Obj, but got VT
		//IL_0015: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got VT
		//IL_0023: Expected I, but got Obj
		//IL_0039: Expected Obj, but got I
		//IL_06ba: Expected I4, but got Obj
		//IL_06c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c8: Expected Obj, but got Unknown
		//IL_00bf: Expected I4, but got Obj
		//IL_0064: Expected I, but got Obj
		//IL_0109: Expected I4, but got Obj
		//IL_0109: Expected Obj, but got VT
		//IL_011f: Expected Obj, but got I
		//IL_0143: Expected Obj, but got I4
		//IL_0154: Expected Obj, but got I
		//IL_0178: Expected Obj, but got I4
		//IL_01b5: Expected Obj, but got I
		//IL_01e1: Expected Obj, but got I
		//IL_020c: Expected I4, but got Obj
		//IL_020c: Expected Obj, but got I
		//IL_021d: Expected Obj, but got VT
		//IL_022e: Expected Obj, but got I
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected Obj, but got Unknown
		//IL_02e8: Expected I, but got Obj
		//IL_02fe: Expected Obj, but got I
		//IL_06fc: Expected I4, but got Obj
		//IL_0329: Expected I, but got Obj
		//IL_037b: Expected I, but got Obj
		//IL_0391: Expected Obj, but got I
		//IL_072e: Expected I4, but got Obj
		//IL_03bc: Expected I, but got Obj
		//IL_040e: Expected I, but got Obj
		//IL_0424: Expected Obj, but got I
		//IL_0760: Expected I4, but got Obj
		//IL_044f: Expected I, but got Obj
		//IL_04a1: Expected I, but got Obj
		//IL_04b7: Expected Obj, but got I
		//IL_0792: Expected I4, but got Obj
		//IL_04e2: Expected I, but got Obj
		//IL_0537: Expected Obj, but got I
		//IL_055b: Expected Obj, but got I4
		//IL_0569: Expected I, but got Obj
		//IL_057f: Expected Obj, but got I
		//IL_07ca: Expected I4, but got Obj
		//IL_07ca: Expected Obj, but got I
		//IL_05f8: Expected I4, but got Obj
		//IL_0609: Expected Obj, but got I
		//IL_05aa: Expected I, but got Obj
		//IL_063f: Expected Obj, but got I
		((CameraSettings)(object)this).nearClipPlane = 0f;
		((GameObject)description1ColorInactive).tag = null;
		((GameObject)description2ColorShadow).tag = null;
		((GameObject)description1ColorShadowActive).tag = (string)1;
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v8 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S1_v124 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault("TOPRUN_CELEBRATION_TITLE");
		((UILabel)(object)SPRITE_NAME_FILL_SHOPITEM_MAIN_SALE).fontSize = (int)text;
		object obj3 = default;
		object obj2 = obj3 + 4;
		obj2 = productString;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		object[] array = default;
		string text2 = string.Concat(array);
		((UILabel)(object)iconBackgroundKeysSpriteName).fontSize = (int)text2;
		string format = Strings.GetDefault("TOPRUN_WEEK_TITLE");
		obj3 = backupDescription2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		object[] args = default;
		string text3 = string.Format(format, args);
		((UILabel)originalMainTextPosition).fontSize = (int)text3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.DiscountButton)+64]");
		GameObject gameObject = ((Component)0).gameObject;
		string text4 = ((Component)(object)gameObject).tag;
		((GameObject)(object)text4).tag = (string)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.DiscountButton)+60]");
		GameObject gameObject2 = ((Component)0).gameObject;
		string text5 = ((Component)(object)gameObject2).tag;
		((GameObject)(object)text5).tag = (string)1;
		TopRunEventsHandler instance = TopRunEventsHandler.instance;
		IEnumerator enumerator = ((CountryPopup)(object)instance).DelayedSelect();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.DiscountButton)+64]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S1_v33 (System.Collections.IEnumerator)+C]");
		((UISprite)num3).fillCenter = false;
		TopRunEventsHandler instance2 = TopRunEventsHandler.instance;
		IEnumerator enumerator2 = ((CountryPopup)(object)instance2).DelayedSelect();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S1_v37 (System.Collections.IEnumerator)+8]");
		string text6 = Strings.GetDefault((string)0);
		string text7 = text6.ToUpperInvariant();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.DiscountButton)+60]");
		((UILabel)0).fontSize = (int)text7;
		((RewardForVideoButton)originalDescriptionPosition).Init(null);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.DiscountButton)+6C]");
		GameObject gameObject3 = ((Component)0).gameObject;
		string text8 = ((Component)(object)gameObject3).tag;
		((GameObject)(object)text8).tag = null;
		object obj4 = backupDescription - 1;
		if ((nint)backupDescription != 1)
		{
			if ((nint)obj4 != 1)
			{
				if ((nint)obj4 != 2)
				{
					if ((nint)obj4 == 3)
					{
						nint num4 = (nint)typeof(Strings);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ S1_v87 (Il2CppClass<Strings>)+BA]");
						object obj5 = (nint)0 & (nint)0x200;
						if (obj5 != null)
						{
							nint num5 = (nint)typeof(Strings);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ S1_v95 (Il2CppClass<Strings>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						string text9 = Strings.GetDefault("TOPRUN_RANK_4_TITLE");
						((UILabel)(object)iconBackgroundNormalSpriteName).fontSize = (int)text9;
						((UILabel)(object)iconBackgroundNormalSpriteName).fontStyle = (FontStyle)40;
						return;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.DiscountButton)+6C]");
					GameObject gameObject4 = ((Component)0).gameObject;
					string text10 = ((Component)(object)gameObject4).tag;
					((GameObject)(object)text10).tag = (string)1;
					nint num6 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ S1_v103 (Il2CppClass<Strings>)+BA]");
					object obj6 = (nint)0 & (nint)0x200;
					if (obj6 != null)
					{
						nint num7 = (nint)typeof(Strings);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ S1_v120 (Il2CppClass<Strings>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					string text11 = Strings.GetDefault("TOPRUN_RANK_CHECKMARK_SUBTEXT");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.DiscountButton)+6C]");
					((UILabel)0).fontSize = (int)text11;
					string text12 = Strings.GetDefault("TOPRUN_RANK_CHECKMARK");
					((UILabel)(object)iconBackgroundNormalSpriteName).fontSize = (int)text12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.DiscountButton)+64]");
					GameObject gameObject5 = ((Component)0).gameObject;
					string text13 = ((Component)(object)gameObject5).tag;
					((GameObject)(object)text13).tag = null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.DiscountButton)+60]");
					GameObject gameObject6 = ((Component)0).gameObject;
					string text14 = ((Component)(object)gameObject6).tag;
					((GameObject)(object)text14).tag = null;
					((UILabel)(object)iconBackgroundNormalSpriteName).fontStyle = (FontStyle)30;
					return;
				}
				nint num8 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S1_v74 (Il2CppClass<Strings>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num9 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S1_v82 (Il2CppClass<Strings>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string text15 = Strings.GetDefault("TOPRUN_RANK_3_TITLE");
				((UILabel)(object)iconBackgroundNormalSpriteName).fontSize = (int)text15;
				((UILabel)(object)iconBackgroundNormalSpriteName).fontStyle = (FontStyle)40;
				return;
			}
			nint num10 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S1_v61 (Il2CppClass<Strings>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num11 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S1_v69 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text16 = Strings.GetDefault("TOPRUN_RANK_2_TITLE");
			((UILabel)(object)iconBackgroundNormalSpriteName).fontSize = (int)text16;
			((UILabel)(object)iconBackgroundNormalSpriteName).fontStyle = (FontStyle)40;
			return;
		}
		nint num12 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S1_v48 (Il2CppClass<Strings>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num13 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S1_v56 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text17 = Strings.GetDefault("TOPRUN_RANK_1_TITLE");
		((UILabel)(object)iconBackgroundNormalSpriteName).fontSize = (int)text17;
		((UILabel)(object)iconBackgroundNormalSpriteName).fontStyle = (FontStyle)40;
	}

	protected virtual void ShowOnSale(string productString, string backupDescription = "")
	{
		//IL_0094: Expected I, but got Obj
		//IL_00aa: Expected Obj, but got I
		//IL_0aca: Expected VT, but got I
		//IL_04da: Expected I, but got Obj
		//IL_04f0: Expected Obj, but got I
		//IL_00d5: Expected I, but got Obj
		//IL_0c6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c70: Expected Obj, but got Unknown
		//IL_0b74: Expected Obj, but got I
		//IL_05a0: Expected I, but got Obj
		//IL_05b6: Expected Obj, but got I
		//IL_051b: Expected I, but got Obj
		//IL_0144: Expected I, but got Obj
		//IL_015a: Expected Obj, but got I
		//IL_02bd: Expected I, but got Obj
		//IL_02d3: Expected Obj, but got I
		//IL_0d15: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d1a: Expected Obj, but got Unknown
		//IL_0d31: Expected Obj, but got VT
		//IL_0d31: Expected Obj, but got I
		//IL_0d3d: Expected Obj, but got I4
		//IL_0af2: Expected I, but got Obj
		//IL_0b08: Expected Obj, but got I
		//IL_0bc7: Expected VT, but got I4
		//IL_0cc1: Expected Obj, but got I
		//IL_0cdc: Expected I, but got Obj
		//IL_0cf2: Expected Obj, but got I
		//IL_05e1: Expected I, but got Obj
		//IL_0b3a: Expected Obj, but got I4
		//IL_0b3a: Expected Obj, but got I
		//IL_0185: Expected I, but got Obj
		//IL_02fe: Expected I, but got Obj
		//IL_034b: Expected I, but got Obj
		//IL_0361: Expected Obj, but got I
		//IL_0e6b: Expected VT, but got I4
		//IL_0e7b: Expected Obj, but got I
		//IL_057f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0584: Expected Obj, but got Unknown
		//IL_058d: Expected Obj, but got I4
		//IL_022f: Expected I, but got Obj
		//IL_0245: Expected Obj, but got I
		//IL_01d2: Expected I, but got Obj
		//IL_0bde: Expected Obj, but got I4
		//IL_0bf0: Expected I, but got Obj
		//IL_0c06: Expected Obj, but got I
		//IL_0d50: Expected I, but got Obj
		//IL_0d66: Expected Obj, but got I
		//IL_062e: Expected I, but got Obj
		//IL_0b98: Expected VT, but got I4
		//IL_021c: Expected VT, but got I4
		//IL_038c: Expected I, but got Obj
		//IL_067d: Expected Obj, but got I
		//IL_0698: Expected I, but got Obj
		//IL_06ae: Expected Obj, but got I
		//IL_0270: Expected I, but got Obj
		//IL_044c: Expected I, but got Obj
		//IL_0462: Expected Obj, but got I
		//IL_03d9: Expected I, but got Obj
		//IL_0726: Expected I, but got Obj
		//IL_0d9a: Expected Obj, but got VT
		//IL_0d9a: Expected Obj, but got I
		//IL_0439: Expected VT, but got I4
		//IL_06d9: Expected I, but got Obj
		//IL_048d: Expected I, but got Obj
		//IL_0789: Invalid comparison between VT and I4
		//IL_07fa: Expected I, but got Obj
		//IL_0810: Expected Obj, but got I
		//IL_083b: Expected I, but got Obj
		//IL_08e5: Invalid comparison between VT and I4
		//IL_0885: Invalid comparison between VT and I4
		//IL_0929: Invalid comparison between VT and I4
		//IL_095e: Invalid comparison between VT and I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.DiscountButton)+B4]");
		if ((nint)0 != 0)
		{
			if (originalFillGraySpriteName != null)
			{
				if ((nint)originalFillGraySpriteName != 1)
				{
					if ((nint)originalFillGraySpriteName != 2)
					{
						if ((nint)originalFillGraySpriteName == 3)
						{
							nint num = (nint)typeof(PromotionManager);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S0_v207 (Il2CppClass<UI.Screens.PromotionManager>)+BA]");
							object obj = (nint)0 & (nint)0x200;
							if (obj != null)
							{
								nint num2 = (nint)typeof(PromotionManager);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ S0_v239 (Il2CppClass<UI.Screens.PromotionManager>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							bool flag = UIScreen.IsScreenHeightOutOfProportion();
							CharacterPromotion characterPromotion = ((PromotionManager)flag).TryGetCurrentPromotion<CharacterPromotion>();
							nint num3 = (nint)typeof(UnityEngine.Object);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ S0_v215 (Il2CppClass<UnityEngine.Object>)+BA]");
							object obj2 = (nint)0 & (nint)0x200;
							if (obj2 != null)
							{
								nint num4 = (nint)typeof(UnityEngine.Object);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ S0_v235 (Il2CppClass<UnityEngine.Object>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							if (characterPromotion != null)
							{
								nint num5 = (nint)typeof(Debug);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ S0_v223 (Il2CppClass<UnityEngine.Debug>)+BA]");
								object obj3 = (nint)0 & (nint)0x200;
								if (obj3 != null)
								{
									nint num6 = (nint)typeof(Debug);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ S0_v229 (Il2CppClass<UnityEngine.Debug>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								Debug.LogException((Exception)(object)"Current promotion isn't a character promotion");
								return;
							}
							AnimationClip[] characterAnimations = characterPromotion.CharacterAnimations;
							originalOutlineScale = (Vector3)characterPromotion._themeIndex;
						}
					}
					else
					{
						nint num7 = (nint)typeof(LimitedCharacterPopupManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v196 (Il2CppClass<UI.Popups.LimitedCharacterPopupInternal.LimitedCharacterPopupManager>)+BA]");
						object obj4 = (nint)0 & (nint)0x200;
						if (obj4 != null)
						{
							nint num8 = (nint)typeof(LimitedCharacterPopupManager);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S0_v202 (Il2CppClass<UI.Popups.LimitedCharacterPopupInternal.LimitedCharacterPopupManager>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						LimitedBoardPopupManager instance = LimitedBoardPopupManager.instance;
						int currentThemeIndex = ((LimitedCharacterPopupManager)(object)instance).currentThemeIndex;
						originalOutlineScale = (Vector3)instance._overwrittenBoardForNextShowing;
					}
				}
				else
				{
					if (productString != null)
					{
						nint num9 = (nint)typeof(CharacterManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S2_v30 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
						object obj5 = (nint)0 & (nint)0x200;
						if (obj5 != null)
						{
							nint num10 = (nint)typeof(CharacterManager);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S2_v46 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.DiscountButton)+98]");
						bool flag2 = CharacterManager.HasCharacterBeenSeen(Characters.CharacterId.slick);
						nint num11 = (nint)typeof(Outfits);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S2_v36 (Il2CppClass<Info.Outfits>)+BA]");
						object obj6 = (nint)0 & (nint)0x200;
						if (obj6 != null)
						{
							nint num12 = (nint)typeof(Outfits);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ S2_v42 (Il2CppClass<Info.Outfits>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.DiscountButton)+98]");
						if (!((OutfitSet)0).HasOutfitWithName((string)flag2))
						{
							originalOutlineScale = (Vector3)0;
						}
						else
						{
							nint num13 = (nint)typeof(CharacterManager);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ S0_v185 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
							object obj7 = (nint)0 & (nint)0x200;
							if (obj7 != null)
							{
								nint num14 = (nint)typeof(CharacterManager);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ S0_v190 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.DiscountButton)+98]");
							bool flag3 = CharacterManager.HasCharacterBeenSeen(Characters.CharacterId.slick);
							originalOutlineScale = (Vector3)flag3;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.DiscountButton)+78]");
					((GameObject)0).tag = null;
				}
			}
			else
			{
				nint num15 = (nint)typeof(CharacterScreenManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v163 (Il2CppClass<UI.Screens.CharacterScreenManager>)+BA]");
				object obj8 = (nint)0 & (nint)0x200;
				if (obj8 != null)
				{
					nint num16 = (nint)typeof(CharacterScreenManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v169 (Il2CppClass<UI.Screens.CharacterScreenManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool running = FirstPurchaseBonusManager.running;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S1_v76 (System.Boolean)+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S1_v76 (System.Boolean)+14]");
				originalOutlineScale = (Vector3)0;
			}
			nint num17 = (nint)typeof(Characters);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ S0_v16 (Il2CppClass<SYBO.Subway.Info.Characters>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num18 = (nint)typeof(Characters);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ S0_v156 (Il2CppClass<SYBO.Subway.Info.Characters>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj10 = this + 156;
			Dictionary<Characters.CharacterId, Characters.Model> characterData = Characters.characterData;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.DiscountButton)+98]");
			Characters.Model model = characterData.get_Item(Characters.CharacterId.slick);
			obj10 = model;
			if (originalFillGraySpriteName != null && (nint)originalFillGraySpriteName != 2)
			{
				object obj11 = this + 164;
				obj11 = 0;
			}
			else
			{
				nint num19 = (nint)typeof(Outfits);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ S0_v141 (Il2CppClass<Info.Outfits>)+BA]");
				object obj12 = (nint)0 & (nint)0x200;
				if (obj12 != null)
				{
					nint num20 = (nint)typeof(Outfits);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ S0_v147 (Il2CppClass<Info.Outfits>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj13 = this + 164;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.DiscountButton)+98]");
				bool flag4 = ((OutfitSet)0).HasOutfitWithName((string)originalOutlineScale);
				obj13 = flag4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.DiscountButton)+9C]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ S1_v14+14]");
			_ = 0;
			nint num21 = (nint)typeof(CharacterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ S0_v30 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
			object obj15 = (nint)0 & (nint)0x200;
			if (obj15 != null)
			{
				nint num22 = (nint)typeof(CharacterManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ S0_v131 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.DiscountButton)+98]");
			bool flag5 = CharacterManager.IsCollectionComplete(Characters.CharacterId.slick);
			originalContentPosition = (Vector3)flag5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.DiscountButton)+9C]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ S1_v21+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.DiscountButton)+A4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.DiscountButton)+A4]");
				object obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ S1_v58+10]");
				_ = 0;
				nint num23 = (nint)typeof(CharacterManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ S0_v121 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
				object obj18 = (nint)0 & (nint)0x200;
				if (obj18 != null)
				{
					nint num24 = (nint)typeof(CharacterManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ S0_v127 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.DiscountButton)+98]");
				bool flag6 = ((UserData)0).StrictlyBetterThan((UserData)originalOutlineScale);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ S1_v58+1C]");
				_ = 0;
			}
			nint num25 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ S0_v40 (Il2CppClass<SSEventsManagerController>)+BA]");
			object obj19 = (nint)0 & (nint)0x200;
			if (obj19 != null)
			{
				nint num26 = (nint)typeof(SSEventsManagerController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ S0_v111 (Il2CppClass<SSEventsManagerController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string flurryUserId = Flurry.flurryUserId;
			bool flag7 = ((SSEventsManagerController)(object)flurryUserId).DoesCharacterMatchCurrentEvent(Characters.CharacterId.spike);
			if (((CoinButtonHelper)null).SupportsSpecialSale())
			{
				bool flag8;
				if (originalContentPosition == (Vector3)(object)0)
				{
					flag8 = false;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.DiscountButton)+A4]");
					if ((nint)0 != 0)
					{
						goto IL_0db5;
					}
				}
				flag8 = flag7;
			}
			else
			{
				bool flag8 = false;
			}
			goto IL_0db5;
		}
		string args = tag;
		SDebug.LogFormat("CharacterSelectButton not initialized. Aborting reload.", (object[])(object)args);
		return;
		IL_0998:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.DiscountButton)+B5]");
		if ((nint)0 == 0)
		{
			((CharacterSelectButton)this).InitButton(CharacterSelectButton.ButtonContext.CharacterNameEventPopup);
			return;
		}
		goto IL_0e1c;
		IL_0db5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.DiscountButton)+A8]");
		if ((nint)0 == 7)
		{
			nint num27 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v459 @ S0_v96 (Il2CppClass<Globals>)+BA]");
			object obj20 = (nint)0 & (nint)0x200;
			if (obj20 != null)
			{
				nint num28 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ S0_v105 (Il2CppClass<Globals>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (~(Globals.DEBUG_ALL_CHARS ? 1u : 0u) != 0)
			{
				CharacterSelectButton.ButtonContext newContext = ((originalContentPosition != (Vector3)(object)0) ? CharacterSelectButton.ButtonContext.CharacterNameEventPopup : CharacterSelectButton.ButtonContext.CharacterPromotion);
				((CharacterSelectButton)this).InitButton(newContext);
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.DiscountButton)+A8]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.DiscountButton)+A8]");
			if ((nint)0 != 1)
			{
				if (originalContentPosition != (Vector3)(object)0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.DiscountButton)+A4]");
					if ((nint)0 == 0)
					{
						goto IL_0998;
					}
				}
				if (originalContentPosition != (Vector3)(object)0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.DiscountButton)+AD]");
					if ((nint)0 != 0)
					{
						goto IL_0998;
					}
				}
				if (originalContentPosition == (Vector3)(object)0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.DiscountButton)+A4]");
					if ((nint)0 != 0)
					{
						goto IL_0998;
					}
				}
				goto IL_0e1c;
			}
		}
		goto IL_0998;
		IL_0e1c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.DiscountButton)+B5]");
		if ((nint)0 == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.DiscountButton)+A8]");
			if ((nint)0 != 6)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.DiscountButton)+A8]");
				if ((nint)0 == 8)
				{
					((CharacterSelectButton)this).InitButton((CharacterSelectButton.ButtonContext)4);
				}
				else
				{
					((CharacterSelectButton)this).InitButton(CharacterSelectButton.ButtonContext.CharacterScreen);
				}
				return;
			}
		}
		((CharacterSelectButton)this).InitButton(CharacterSelectButton.ButtonContext.LimitedCharacterPopup);
	}

	protected unsafe virtual void ShowNoDiscount(string productString, string backupDescription = "")
	{
		//IL_005e: Expected Obj, but got I4
		//IL_0028: Expected I4, but got Obj
		//IL_0028: Expected I4, but got Obj
		SetLimitedLabels(DiscountButtonState.Sale);
		SetDiscountColors(DiscountButtonState.Sale);
		((DoubleCoinUpgradeHelper)this).ShowOnSale((string)1, productString);
		((DoubleCoinUpgradeHelper)this)._Setup(true);
		((GameOverLeaderboardHandler)this).InsertPlayerScoreToLeaderboard(ref *(int*)1, ref *(int*)productString, (byte)(int)backupDescription != 0, (byte)(int)"" != 0);
		PositionContent(DiscountButtonState.Sale);
	}

	private unsafe void SetProductData(DiscountButtonState state, string productString, string backupDescription, string backupDescription2 = "")
	{
		//IL_007f: Expected Obj, but got I4
		//IL_0091: Expected I, but got Obj
		//IL_00a7: Expected Obj, but got I
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected VT, but got Unknown
		//IL_00e7: Expected F4, but got Obj
		//IL_00e2: Expected native int or pointer, but got VT
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected Obj, but got Unknown
		//IL_010f: Expected F4, but got Obj
		//IL_010a: Expected native int or pointer, but got VT
		//IL_0124: Expected F4, but got I
		//IL_011f: Expected native int or pointer, but got VT
		//IL_012d: Expected Obj, but got VT
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected Obj, but got Unknown
		//IL_015b: Expected VT, but got Obj
		//IL_015b: Expected Obj, but got VT
		//IL_0013: Expected I, but got Obj
		int layer = ((GameObject)state).layer;
		nint num = (nint)typeof(Vector2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S1_v7 (Il2CppClass<UnityEngine.Vector2>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v25 (Il2CppClass<UnityEngine.Vector2>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector4 vector = (Vector4)(productString + 20);
		((Vector4*)(nint)vector)->x = (float)productString;
		object obj2 = productString + 8;
		Vector3 vector2 = vector;
		((Vector4*)(nint)vector)->x = (float)obj2;
		Vector4 vector3 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S1_v15+8]");
		((Vector4*)(nint)vector3)->z = 0f;
		Vector3 eulerAngles = ((Transform)vector).eulerAngles;
		object obj3 = backupDescription / 2;
		object obj4 = backupDescription2 + obj3;
		((Transform)vector).localPosition = (Vector3)leftContent;
		float posZ = vector.y - (float)obj4;
		TransformExtensions.SetLocalPosZ(leftContent, posZ);
	}

	private void FormatButton(DiscountButtonState state)
	{
		//IL_02f4: Expected Obj, but got I
		//IL_0064: Expected Obj, but got I
		//IL_00a7: Expected I, but got Obj
		//IL_00bd: Expected Obj, but got I
		//IL_032e: Expected Obj, but got I
		//IL_00e8: Expected I, but got Obj
		//IL_02df: Expected Obj, but got I
		//IL_0223: Expected Obj, but got I
		//IL_0135: Expected I, but got Obj
		//IL_014b: Expected Obj, but got I
		//IL_0362: Expected Obj, but got I
		//IL_0289: Expected Obj, but got I
		//IL_0299: Expected Obj, but got I
		//IL_0176: Expected I, but got Obj
		//IL_01d0: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.DiscountButton)+16C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+2C]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+2C]");
			if ((nint)0 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+2C]");
				if ((nint)0 == 2)
				{
					if (state == DiscountButtonState.Normal)
					{
						((CoinButtonHelper)this)._002Ector();
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.DiscountButton)+16C]");
					object obj2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S1_v31+28]");
					object obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
					string text = default;
					string msg = "Item offer type not supported in CoinButtonHelper: " + text;
					SDebug.LogFormat(msg, null);
				}
			}
			else if (state == DiscountButtonState.Normal)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.DiscountButton)+16C]");
				object obj4 = 0;
				bool flag = SupportsSpecialSale();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7767");
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.DiscountButton)+16C]");
			object obj5 = 0;
			bool flag2 = SupportsSpecialSale();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7767");
			GameObject gameObject = base.gameObject;
			Transform parentInternal = ((Transform)(object)gameObject).parentInternal;
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S2_v7 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S2_v17 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.DiscountButton)+164]");
			if (parentInternal != (UnityEngine.Object)0)
			{
				nint num3 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num4 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S1_v22 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.DiscountButton)+164]");
				if (((ComputeShader)0).FindKernel(null) != 0)
				{
					GameObject gameObject2 = base.gameObject;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.DiscountButton)+164]");
					Transform parentInternal2 = ((Transform)0).parentInternal;
					((Transform)(object)gameObject2).parentInternal = parentInternal2;
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.DiscountButton)+170]");
		bool flag3 = (string)0 != "NotEnoughCurrencyPopup";
	}

	private void PositionContent(DiscountButtonState state)
	{
		//IL_0283: Expected I, but got Obj
		//IL_0299: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0139: Expected I4, but got Obj
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected Obj, but got Unknown
		//IL_0087: Expected I, but got Obj
		//IL_009d: Expected Obj, but got I
		//IL_012a: Expected I4, but got Obj
		//IL_0157: Expected I4, but got Obj
		//IL_00c8: Expected I, but got Obj
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_035e: Expected Obj, but got Unknown
		//IL_0368: Expected Obj, but got VT
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_0376: Expected Obj, but got Unknown
		//IL_038c: Expected I, but got Obj
		//IL_03a2: Expected Obj, but got I
		//IL_0148: Expected I4, but got Obj
		//IL_03c8: Expected F4, but got Obj
		//IL_03db: Expected I4, but got Obj
		//IL_03f4: Expected F4, but got I
		//IL_016a: Expected I, but got Obj
		//IL_01d8: Expected I, but got Obj
		//IL_01ee: Expected Obj, but got I
		//IL_0219: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v51 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = state == DiscountButtonState.Normal;
		float num3 = ((!flag) ? 12f : 0f);
		if (((ComputeShader)(object)_widget).FindKernel((string)null) != 0)
		{
			object obj2 = this + 252;
			nint num4 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S2_v25 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num5 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S2_v32 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S1_v45+4]");
			float width = 0f + num3;
			GUILayoutOption gUILayoutOption = GUILayout.Width(width);
			Color color = ((UIWidget)(object)gUILayoutOption).color;
		}
		bool fillCenter = (byte)((!flag) ? ((int)SPRITE_NAME_FILL_SHOPITEM_HIGHLIGHT_SALE) : ((int)originalFillColorSpirteName)) != 0;
		fillColorSprite.fillCenter = fillCenter;
		bool fillCenter2 = (byte)((!flag) ? ((int)SPRITE_NAME_FILL_SHOPITEM_MAIN_SALE) : ((int)originalFillGraySpriteName)) != 0;
		fillGraySprite.fillCenter = fillCenter2;
		object obj5 = default;
		object obj4 = obj5 + 16;
		obj4 = originalIconBGSize;
		object obj6 = obj5 + 8;
		obj6 = obj4;
		nint num6 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S2_v9 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num7 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S2_v19 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		GUILayoutOption gUILayoutOption2 = GUILayout.Width((float)obj6);
		iconBG.height = (int)gUILayoutOption2;
		obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		GUILayoutOption gUILayoutOption3 = GUILayout.Width(0f);
		Color color2 = ((UIWidget)(object)gUILayoutOption3).color;
		FitSpriteToWidget component = icon.GetComponent<FitSpriteToWidget>();
		nint num8 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S0_v28 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num9 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ S0_v38 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)component).FindKernel((string)null) != 0)
		{
			component.fittingMode = FitSpriteToWidget.FittingMode.PixelPerfect;
			component.FitStretch();
		}
	}

	private unsafe void SetLimitedLabels(DiscountButtonState state)
	{
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Expected VT, but got Unknown
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Expected Obj, but got Unknown
		//IL_01f9: Expected Obj, but got I4
		//IL_005e: Expected I, but got Obj
		//IL_0074: Expected Obj, but got I
		//IL_000e: Expected native int or pointer, but got VT
		//IL_001c: Expected native int or pointer, but got VT
		//IL_002a: Expected native int or pointer, but got VT
		//IL_0038: Expected native int or pointer, but got VT
		//IL_0046: Expected native int or pointer, but got VT
		//IL_00eb: Expected Obj, but got F4
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected Obj, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected Obj, but got Unknown
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected Obj, but got Unknown
		//IL_0154: Expected I, but got Obj
		//IL_016a: Expected Obj, but got I
		//IL_009f: Expected I, but got Obj
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Expected VT, but got Unknown
		//IL_0245: Expected F4, but got Obj
		//IL_0240: Expected native int or pointer, but got VT
		//IL_025a: Expected F4, but got I
		//IL_0255: Expected native int or pointer, but got VT
		//IL_0267: Expected F4, but got Obj
		//IL_0262: Expected native int or pointer, but got VT
		//IL_027c: Expected F4, but got I
		//IL_0277: Expected native int or pointer, but got VT
		//IL_029a: Expected F4, but got Obj
		//IL_0295: Expected native int or pointer, but got VT
		//IL_02af: Expected F4, but got I
		//IL_02aa: Expected native int or pointer, but got VT
		//IL_02b8: Expected Obj, but got VT
		//IL_0195: Expected I, but got Obj
		object obj = default;
		Vector3 vector = (Vector3)(obj + 60);
		object obj2 = obj + 36;
		obj2 = 0;
		_ = 0;
		if (state != DiscountButtonState.Normal)
		{
			((Vector3*)(nint)vector)->x = 0f;
			((Vector3*)(nint)vector)->z = 0f;
			((Vector3*)(nint)vector)->x = 0f;
			((Vector3*)(nint)vector)->y = 6f;
			((Vector3*)(nint)vector)->z = 0f;
		}
		else
		{
			nint num = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v21 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num2 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v26 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector3 one = Vector3.one;
		}
		obj2 = vector.x;
		_ = vector.z;
		object obj4 = obj + 24;
		object obj5 = this + 172;
		obj4 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S2_v3+8]");
		_ = 0;
		object obj6 = obj + 12;
		obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
		_ = 0;
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S1_v19 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num4 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S1_v32 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector2 = (Vector3)(obj + 48);
		((Vector3*)(nint)vector2)->x = (float)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S1_v13+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)obj6;
		Vector3 vector3 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S1_v16+8]");
		((Vector3*)(nint)vector3)->z = 0f;
		Vector3 vector4 = vector2 - vector;
		((Vector3*)(nint)vector)->x = (float)obj;
		Vector3 vector5 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector5)->z = 0f;
		Vector3 eulerAngles = ((Transform)vector).eulerAngles;
	}

	private unsafe void SetDiscountAssets(DiscountButtonState state, string productString)
	{
		//IL_0051: Expected Obj, but got I4
		//IL_001f: Expected I4, but got Obj
		//IL_001f: Expected I4, but got Obj
		SetLimitedLabels(DiscountButtonState.Normal);
		SetDiscountColors(DiscountButtonState.Normal);
		((DoubleCoinUpgradeHelper)this).ShowOnSale((string)null, (string)state);
		this._002Ector();
		((GameOverLeaderboardHandler)this).InsertPlayerScoreToLeaderboard(ref *(int*)null, ref *(int*)(int)state, (byte)(int)productString != 0, (byte)(int)"" != 0);
		PositionContent(DiscountButtonState.Normal);
	}

	private unsafe void SetNodiscountColors()
	{
		//IL_0ad2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad7: Expected VT, but got Unknown
		//IL_0ae0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae5: Expected Obj, but got Unknown
		//IL_0aee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af3: Expected Obj, but got Unknown
		//IL_0afc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b01: Expected Obj, but got Unknown
		//IL_0b0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0f: Expected Obj, but got Unknown
		//IL_0b18: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1d: Expected Obj, but got Unknown
		//IL_0b26: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2b: Expected Obj, but got Unknown
		//IL_0b34: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b39: Expected Obj, but got Unknown
		//IL_0b42: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b47: Expected Obj, but got Unknown
		//IL_0b50: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b55: Expected Obj, but got Unknown
		//IL_0b5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b63: Expected Obj, but got Unknown
		//IL_0b6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b71: Expected Obj, but got Unknown
		//IL_0b7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b7f: Expected Obj, but got Unknown
		//IL_0b88: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8d: Expected Obj, but got Unknown
		//IL_0b96: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9b: Expected Obj, but got Unknown
		//IL_0ba4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba9: Expected Obj, but got Unknown
		//IL_0bb2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb7: Expected Obj, but got Unknown
		//IL_0bc0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc5: Expected Obj, but got Unknown
		//IL_0bce: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd3: Expected Obj, but got Unknown
		//IL_0bdc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be1: Expected Obj, but got Unknown
		//IL_0bea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bef: Expected Obj, but got Unknown
		//IL_0bf8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfd: Expected Obj, but got Unknown
		//IL_0c06: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c0b: Expected Obj, but got Unknown
		//IL_0c14: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c19: Expected Obj, but got Unknown
		//IL_0c22: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c27: Expected Obj, but got Unknown
		//IL_0c30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c35: Expected Obj, but got Unknown
		//IL_0c3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c43: Expected Obj, but got Unknown
		//IL_0c4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c51: Expected Obj, but got Unknown
		//IL_0c5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c5f: Expected Obj, but got Unknown
		//IL_0c68: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c6d: Expected Obj, but got Unknown
		//IL_0c76: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7b: Expected Obj, but got Unknown
		//IL_0c84: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c89: Expected Obj, but got Unknown
		//IL_0c92: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c97: Expected Obj, but got Unknown
		//IL_0ca0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca5: Expected Obj, but got Unknown
		//IL_0cae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb3: Expected Obj, but got Unknown
		//IL_0cbc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc1: Expected Obj, but got Unknown
		//IL_0cca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ccf: Expected Obj, but got Unknown
		//IL_0cd8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cdd: Expected Obj, but got Unknown
		//IL_0ce6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ceb: Expected Obj, but got Unknown
		//IL_0cf4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf9: Expected Obj, but got Unknown
		//IL_0d02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d07: Expected Obj, but got Unknown
		//IL_0d10: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d15: Expected Obj, but got Unknown
		//IL_0d1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d23: Expected Obj, but got Unknown
		//IL_0d2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d31: Expected Obj, but got Unknown
		//IL_0d3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d3f: Expected Obj, but got Unknown
		//IL_0d48: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d4d: Expected Obj, but got Unknown
		//IL_0d56: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d5b: Expected Obj, but got Unknown
		//IL_0d64: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d69: Expected Obj, but got Unknown
		//IL_0d72: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d77: Expected Obj, but got Unknown
		//IL_171c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1721: Expected Obj, but got Unknown
		//IL_1741: Expected I, but got Obj
		//IL_1757: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_149c: Expected VT, but got Obj
		//IL_14a9: Expected I4, but got Obj
		//IL_14a4: Expected native int or pointer, but got VT
		//IL_14b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_14be: Expected Obj, but got Unknown
		//IL_14cb: Expected Obj, but got I4
		//IL_14de: Unknown result type (might be due to invalid IL or missing references)
		//IL_14e3: Expected Obj, but got Unknown
		//IL_1500: Unknown result type (might be due to invalid IL or missing references)
		//IL_1505: Expected Obj, but got Unknown
		//IL_1539: Expected Obj, but got I4
		//IL_154c: Expected Obj, but got I4
		//IL_1569: Expected I4, but got Obj
		//IL_1564: Expected native int or pointer, but got VT
		//IL_157c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1581: Expected Obj, but got Unknown
		//IL_158e: Expected Obj, but got I4
		//IL_15b8: Expected Obj, but got I4
		//IL_15cb: Expected Obj, but got I4
		//IL_15e8: Expected I4, but got Obj
		//IL_15e3: Expected native int or pointer, but got VT
		//IL_15fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1600: Expected Obj, but got Unknown
		//IL_160d: Expected Obj, but got I4
		//IL_1637: Expected Obj, but got I4
		//IL_164a: Expected Obj, but got I4
		//IL_1667: Expected I4, but got Obj
		//IL_1662: Expected native int or pointer, but got VT
		//IL_167a: Unknown result type (might be due to invalid IL or missing references)
		//IL_167f: Expected Obj, but got Unknown
		//IL_168c: Expected Obj, but got I4
		//IL_16a8: Expected VT, but got Obj
		//IL_16b5: Expected I4, but got Obj
		//IL_16b0: Expected native int or pointer, but got VT
		//IL_16c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_16ca: Expected Obj, but got Unknown
		//IL_16d7: Expected Obj, but got I4
		//IL_02d9: Expected I, but got Obj
		//IL_03b6: Expected VT, but got Obj
		//IL_03c3: Expected I4, but got Obj
		//IL_03be: Expected native int or pointer, but got VT
		//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d8: Expected Obj, but got Unknown
		//IL_03e5: Expected Obj, but got I4
		//IL_0335: Expected Obj, but got I4
		//IL_0350: Expected Obj, but got I4
		//IL_0368: Expected I, but got F4
		//IL_0375: Expected I4, but got Obj
		//IL_0370: Expected native int or pointer, but got VT
		//IL_0385: Unknown result type (might be due to invalid IL or missing references)
		//IL_038a: Expected Obj, but got Unknown
		//IL_0397: Expected Obj, but got I4
		//IL_0054: Expected I, but got Obj
		//IL_0413: Expected VT, but got Obj
		//IL_0420: Expected I4, but got Obj
		//IL_041b: Expected native int or pointer, but got VT
		//IL_0430: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Expected Obj, but got Unknown
		//IL_0442: Expected Obj, but got I4
		//IL_045a: Unknown result type (might be due to invalid IL or missing references)
		//IL_045f: Expected Obj, but got Unknown
		//IL_0481: Expected I4, but got Obj
		//IL_047c: Expected native int or pointer, but got VT
		//IL_00a1: Expected I, but got Obj
		//IL_00b7: Expected Obj, but got I
		//IL_04a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ae: Expected Obj, but got Unknown
		//IL_04c3: Expected I4, but got Obj
		//IL_04be: Expected native int or pointer, but got VT
		//IL_04d2: Expected VT, but got I4
		//IL_04dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e2: Expected Obj, but got Unknown
		//IL_0504: Expected I4, but got Obj
		//IL_04ff: Expected native int or pointer, but got VT
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_052c: Expected Obj, but got Unknown
		//IL_0541: Expected I4, but got Obj
		//IL_053c: Expected native int or pointer, but got VT
		//IL_0550: Expected VT, but got I4
		//IL_055b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0560: Expected Obj, but got Unknown
		//IL_0582: Expected I4, but got Obj
		//IL_057d: Expected native int or pointer, but got VT
		//IL_05aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_05af: Expected Obj, but got Unknown
		//IL_05c4: Expected I4, but got Obj
		//IL_05bf: Expected native int or pointer, but got VT
		//IL_05d3: Expected VT, but got I4
		//IL_05de: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e3: Expected Obj, but got Unknown
		//IL_0605: Expected I4, but got Obj
		//IL_0600: Expected native int or pointer, but got VT
		//IL_0628: Unknown result type (might be due to invalid IL or missing references)
		//IL_062d: Expected Obj, but got Unknown
		//IL_0642: Expected I4, but got Obj
		//IL_063d: Expected native int or pointer, but got VT
		//IL_0651: Expected VT, but got I4
		//IL_065a: Unknown result type (might be due to invalid IL or missing references)
		//IL_065f: Expected Obj, but got Unknown
		//IL_0676: Expected Obj, but got VT
		//IL_0683: Expected I4, but got Obj
		//IL_067e: Expected native int or pointer, but got VT
		//IL_0692: Expected VT, but got I4
		//IL_069d: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a2: Expected Obj, but got Unknown
		//IL_06c4: Expected I4, but got Obj
		//IL_06bf: Expected native int or pointer, but got VT
		//IL_06da: Unknown result type (might be due to invalid IL or missing references)
		//IL_06df: Expected Obj, but got Unknown
		//IL_01bd: Expected I, but got Obj
		//IL_01d3: Expected Obj, but got I
		//IL_00e2: Expected I, but got Obj
		//IL_06fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ff: Expected Obj, but got Unknown
		//IL_0714: Expected I4, but got Obj
		//IL_070f: Expected native int or pointer, but got VT
		//IL_0723: Expected VT, but got I4
		//IL_072c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0731: Expected Obj, but got Unknown
		//IL_073c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0741: Expected Obj, but got Unknown
		//IL_0763: Expected I4, but got Obj
		//IL_075e: Expected native int or pointer, but got VT
		//IL_0779: Unknown result type (might be due to invalid IL or missing references)
		//IL_077e: Expected Obj, but got Unknown
		//IL_0794: Unknown result type (might be due to invalid IL or missing references)
		//IL_0799: Expected Obj, but got Unknown
		//IL_07ae: Expected I4, but got Obj
		//IL_07a9: Expected native int or pointer, but got VT
		//IL_07bd: Expected VT, but got I4
		//IL_07c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cb: Expected Obj, but got Unknown
		//IL_07d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07db: Expected Obj, but got Unknown
		//IL_07fd: Expected I4, but got Obj
		//IL_07f8: Expected native int or pointer, but got VT
		//IL_0813: Unknown result type (might be due to invalid IL or missing references)
		//IL_0818: Expected Obj, but got Unknown
		//IL_012f: Expected I, but got Obj
		//IL_0145: Expected Obj, but got I
		//IL_0833: Unknown result type (might be due to invalid IL or missing references)
		//IL_0838: Expected Obj, but got Unknown
		//IL_084d: Expected I4, but got Obj
		//IL_0848: Expected native int or pointer, but got VT
		//IL_085c: Expected VT, but got I4
		//IL_0865: Unknown result type (might be due to invalid IL or missing references)
		//IL_086a: Expected Obj, but got Unknown
		//IL_0875: Unknown result type (might be due to invalid IL or missing references)
		//IL_087a: Expected Obj, but got Unknown
		//IL_089c: Expected I4, but got Obj
		//IL_0897: Expected native int or pointer, but got VT
		//IL_08b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b7: Expected Obj, but got Unknown
		//IL_08cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d2: Expected Obj, but got Unknown
		//IL_08e7: Expected I4, but got Obj
		//IL_08e2: Expected native int or pointer, but got VT
		//IL_08f6: Expected VT, but got I4
		//IL_0913: Unknown result type (might be due to invalid IL or missing references)
		//IL_0918: Expected Obj, but got Unknown
		//IL_0921: Expected Obj, but got I4
		//IL_092e: Expected Obj, but got I4
		//IL_0941: Unknown result type (might be due to invalid IL or missing references)
		//IL_0946: Expected Obj, but got Unknown
		//IL_095b: Expected I4, but got Obj
		//IL_0956: Expected native int or pointer, but got VT
		//IL_096a: Expected VT, but got I4
		//IL_0987: Expected Obj, but got I4
		//IL_0994: Expected Obj, but got I4
		//IL_09a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ac: Expected Obj, but got Unknown
		//IL_09c1: Expected I4, but got Obj
		//IL_09bc: Expected native int or pointer, but got VT
		//IL_09d0: Expected VT, but got I4
		//IL_09d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09de: Expected Obj, but got Unknown
		//IL_01fe: Expected I, but got Obj
		//IL_0deb: Expected Obj, but got VT
		//IL_0e00: Expected I4, but got Obj
		//IL_0dfb: Expected native int or pointer, but got VT
		//IL_0e0f: Expected VT, but got I4
		//IL_0e18: Expected Obj, but got VT
		//IL_0e2d: Expected I4, but got Obj
		//IL_0e28: Expected native int or pointer, but got VT
		//IL_0e3c: Expected VT, but got I4
		//IL_0e45: Expected Obj, but got VT
		//IL_0e5a: Expected I4, but got Obj
		//IL_0e55: Expected native int or pointer, but got VT
		//IL_0e69: Expected VT, but got I4
		//IL_0e72: Expected Obj, but got VT
		//IL_0e87: Expected I4, but got Obj
		//IL_0e82: Expected native int or pointer, but got VT
		//IL_0e96: Expected VT, but got I4
		//IL_0e9f: Expected Obj, but got VT
		//IL_0eb4: Expected I4, but got Obj
		//IL_0eaf: Expected native int or pointer, but got VT
		//IL_0ec3: Expected VT, but got I4
		//IL_0ecc: Expected Obj, but got VT
		//IL_0ee1: Expected I4, but got Obj
		//IL_0edc: Expected native int or pointer, but got VT
		//IL_0ef0: Expected VT, but got I4
		//IL_0ef9: Expected Obj, but got VT
		//IL_0f0e: Expected I4, but got Obj
		//IL_0f09: Expected native int or pointer, but got VT
		//IL_0f1d: Expected VT, but got I4
		//IL_0f26: Expected Obj, but got VT
		//IL_0f3b: Expected I4, but got Obj
		//IL_0f36: Expected native int or pointer, but got VT
		//IL_0f4a: Expected VT, but got I4
		//IL_0f53: Expected Obj, but got VT
		//IL_0f68: Expected I4, but got Obj
		//IL_0f63: Expected native int or pointer, but got VT
		//IL_0f77: Expected VT, but got I4
		//IL_0f80: Expected Obj, but got VT
		//IL_0f95: Expected I4, but got Obj
		//IL_0f90: Expected native int or pointer, but got VT
		//IL_0f9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa0: Expected Obj, but got Unknown
		//IL_0fad: Expected Obj, but got I4
		//IL_0fb6: Expected Obj, but got VT
		//IL_0fcb: Expected I4, but got Obj
		//IL_0fc6: Expected native int or pointer, but got VT
		//IL_0fda: Expected VT, but got I4
		//IL_0fe3: Expected Obj, but got VT
		//IL_0ff8: Expected I4, but got Obj
		//IL_0ff3: Expected native int or pointer, but got VT
		//IL_1007: Expected VT, but got I4
		//IL_1010: Expected Obj, but got VT
		//IL_1025: Expected I4, but got Obj
		//IL_1020: Expected native int or pointer, but got VT
		//IL_1034: Expected VT, but got I4
		//IL_103d: Expected Obj, but got VT
		//IL_1052: Expected I4, but got Obj
		//IL_104d: Expected native int or pointer, but got VT
		//IL_1061: Expected VT, but got I4
		//IL_106a: Expected Obj, but got VT
		//IL_107f: Expected I4, but got Obj
		//IL_107a: Expected native int or pointer, but got VT
		//IL_108e: Expected VT, but got I4
		//IL_1097: Expected Obj, but got VT
		//IL_10ac: Expected I4, but got Obj
		//IL_10a7: Expected native int or pointer, but got VT
		//IL_10bb: Expected VT, but got I4
		//IL_10c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_10c6: Expected Obj, but got Unknown
		//IL_10d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_10da: Expected Obj, but got Unknown
		//IL_10e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ee: Expected Obj, but got Unknown
		//IL_10fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1102: Expected Obj, but got Unknown
		//IL_09ff: Expected VT, but got Obj
		//IL_0a0c: Expected I4, but got Obj
		//IL_0a07: Expected native int or pointer, but got VT
		//IL_0a1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a21: Expected Obj, but got Unknown
		//IL_0a2e: Expected Obj, but got I4
		//IL_0a49: Expected I, but got Obj
		//IL_0a5f: Expected Obj, but got I
		//IL_024b: Expected I, but got Obj
		//IL_0261: Expected Obj, but got I
		//IL_0170: Expected I, but got Obj
		//IL_1715: Expected I4, but got Obj
		//IL_113b: Expected Obj, but got VT
		//IL_1150: Expected I4, but got Obj
		//IL_114b: Expected native int or pointer, but got VT
		//IL_115f: Expected VT, but got I4
		//IL_1168: Expected Obj, but got VT
		//IL_117d: Expected I4, but got Obj
		//IL_1178: Expected native int or pointer, but got VT
		//IL_118c: Expected VT, but got I4
		//IL_1195: Expected Obj, but got VT
		//IL_11aa: Expected I4, but got Obj
		//IL_11a5: Expected native int or pointer, but got VT
		//IL_11b9: Expected VT, but got I4
		//IL_11c2: Expected Obj, but got VT
		//IL_11d7: Expected I4, but got Obj
		//IL_11d2: Expected native int or pointer, but got VT
		//IL_11e6: Expected VT, but got I4
		//IL_11ef: Expected Obj, but got VT
		//IL_1204: Expected I4, but got Obj
		//IL_11ff: Expected native int or pointer, but got VT
		//IL_1213: Expected VT, but got I4
		//IL_121c: Expected Obj, but got VT
		//IL_1231: Expected I4, but got Obj
		//IL_122c: Expected native int or pointer, but got VT
		//IL_1240: Expected VT, but got I4
		//IL_1249: Expected Obj, but got VT
		//IL_125e: Expected I4, but got Obj
		//IL_1259: Expected native int or pointer, but got VT
		//IL_126d: Expected VT, but got I4
		//IL_1276: Expected Obj, but got VT
		//IL_128b: Expected I4, but got Obj
		//IL_1286: Expected native int or pointer, but got VT
		//IL_129a: Expected VT, but got I4
		//IL_12a3: Expected Obj, but got VT
		//IL_12b8: Expected I4, but got Obj
		//IL_12b3: Expected native int or pointer, but got VT
		//IL_12c7: Expected VT, but got I4
		//IL_12d0: Expected Obj, but got VT
		//IL_12e5: Expected I4, but got Obj
		//IL_12e0: Expected native int or pointer, but got VT
		//IL_12eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_12f0: Expected Obj, but got Unknown
		//IL_12fd: Expected Obj, but got I4
		//IL_1306: Expected Obj, but got VT
		//IL_131b: Expected I4, but got Obj
		//IL_1316: Expected native int or pointer, but got VT
		//IL_132a: Expected VT, but got I4
		//IL_1333: Expected Obj, but got VT
		//IL_1348: Expected I4, but got Obj
		//IL_1343: Expected native int or pointer, but got VT
		//IL_1357: Expected VT, but got I4
		//IL_1360: Expected Obj, but got VT
		//IL_1375: Expected I4, but got Obj
		//IL_1370: Expected native int or pointer, but got VT
		//IL_1384: Expected VT, but got I4
		//IL_138d: Expected Obj, but got VT
		//IL_13a2: Expected I4, but got Obj
		//IL_139d: Expected native int or pointer, but got VT
		//IL_13b1: Expected VT, but got I4
		//IL_13ba: Expected Obj, but got VT
		//IL_13cf: Expected I4, but got Obj
		//IL_13ca: Expected native int or pointer, but got VT
		//IL_13de: Expected VT, but got I4
		//IL_13e7: Expected Obj, but got VT
		//IL_13fc: Expected I4, but got Obj
		//IL_13f7: Expected native int or pointer, but got VT
		//IL_140b: Expected VT, but got I4
		//IL_1411: Unknown result type (might be due to invalid IL or missing references)
		//IL_1416: Expected Obj, but got Unknown
		//IL_1425: Unknown result type (might be due to invalid IL or missing references)
		//IL_142a: Expected Obj, but got Unknown
		//IL_1439: Unknown result type (might be due to invalid IL or missing references)
		//IL_143e: Expected Obj, but got Unknown
		//IL_144d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1452: Expected Obj, but got Unknown
		//IL_0a8a: Expected I, but got Obj
		//IL_028c: Expected I, but got Obj
		object obj = default;
		Color32 color = (Color32)(obj + 488);
		Transform transform = (Transform)(obj + 320);
		object obj2 = obj + 480;
		object obj3 = obj + 304;
		object obj4 = obj + 476;
		object obj5 = obj + 292;
		object obj6 = obj + 472;
		object obj7 = obj + 280;
		object obj8 = obj + 468;
		Transform transform2 = (Transform)(obj + 264);
		object obj9 = obj + 464;
		Transform transform3 = (Transform)(obj + 252);
		object obj10 = obj + 460;
		Transform transform4 = (Transform)(obj + 240);
		object obj11 = obj + 456;
		object obj12 = obj + 224;
		object obj13 = obj + 452;
		object obj14 = obj + 216;
		object obj15 = obj + 448;
		object obj16 = obj + 200;
		object obj17 = obj + 444;
		object obj18 = obj + 192;
		object obj19 = obj + 440;
		object obj20 = obj + 176;
		object obj21 = obj + 436;
		object obj22 = obj + 168;
		object obj23 = obj + 432;
		object obj24 = obj + 152;
		object obj25 = obj + 428;
		object obj26 = obj + 144;
		object obj27 = obj + 424;
		object obj28 = obj + 128;
		object obj29 = obj + 420;
		object obj30 = obj + 416;
		object obj31 = obj + 412;
		object obj32 = obj + 408;
		object obj33 = obj + 404;
		object obj34 = obj + 400;
		object obj35 = obj + 396;
		object obj36 = obj + 392;
		object obj37 = obj + 388;
		object obj38 = obj + 384;
		object obj39 = obj + 380;
		object obj40 = obj + 376;
		object obj41 = obj + 372;
		object obj42 = obj + 368;
		object obj43 = obj + 364;
		object obj44 = obj + 360;
		object obj45 = obj + 356;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		object obj46 = default;
		if (obj46 != null)
		{
			nint num = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ S0_v328 (Il2CppClass<InApp.InAppManager>)+BA]");
			object obj47 = (nint)0 & (nint)0x200;
			if (obj47 != null)
			{
				nint num2 = (nint)typeof(InAppManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ S0_v524 (Il2CppClass<InApp.InAppManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (InAppManager.IsWinterHolidaySpecialSaleActive)
			{
				nint num3 = (nint)typeof(InAppManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ S0_v335 (Il2CppClass<InApp.InAppManager>)+BA]");
				object obj48 = (nint)0 & (nint)0x200;
				if (obj48 != null)
				{
					nint num4 = (nint)typeof(InAppManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ S0_v520 (Il2CppClass<InApp.InAppManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (InAppManager.IsNewYearSpecialSaleActive)
				{
					nint num5 = (nint)typeof(GlobalColors);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ S0_v437 (Il2CppClass<GlobalColors>)+BA]");
					object obj49 = (nint)0 & (nint)0x200;
					if (obj49 != null)
					{
						nint num6 = (nint)typeof(GlobalColors);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ S0_v514 (Il2CppClass<GlobalColors>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					transform = (Transform)GlobalColors.SPECIAL_DISCOUNT_WINTER_HOLIDAY_BUTTON_TITLE_COLOR;
					obj2 = transform;
					((Color32*)(nint)color)->rgba = (int)obj2;
					titleColor = (Color32)color.rgba;
					obj3 = GlobalColors.SPECIAL_DISCOUNT_WINTER_HOLIDAY_BUTTON_TITLE_COLOR_SHADOW;
					obj4 = obj3;
					((Color32*)(nint)color)->rgba = (int)obj4;
					titleColorShadow = (Color32)color.rgba;
					obj5 = GlobalColors.SPECIAL_DISCOUNT_WINTER_HOLIDAY_BUTTON_DESCRIPTION1_INACTIVE_COLOR;
					obj6 = obj5;
					((Color32*)(nint)color)->rgba = (int)obj6;
					description1ColorInactive = (Color32)color.rgba;
					obj7 = GlobalColors.SPECIAL_DISCOUNT_WINTER_HOLIDAY_BUTTON_DESCRIPTION1_INACTIVE_SHADOW_COLOR;
					obj8 = obj7;
					((Color32*)(nint)color)->rgba = (int)obj8;
					description1ColorShadowInactive = (Color32)color.rgba;
					transform2 = (Transform)GlobalColors.SPECIAL_DISCOUNT_WINTER_HOLIDAY_BUTTON_PRICE_COLOR;
					obj9 = transform2;
					((Color32*)(nint)color)->rgba = (int)obj9;
					priceColor = (Color32)color.rgba;
					transform3 = (Transform)GlobalColors.SPECIAL_DISCOUNT_WINTER_HOLIDAY_BUTTON_PRICE_SHADOW_COLOR;
					obj10 = transform3;
					((Color32*)(nint)color)->rgba = (int)obj10;
					priceColorShadow = (Color32)color.rgba;
					transform4 = (Transform)GlobalColors.SPECIAL_DISCOUNT_WINTER_HOLIDAY_BUTTON_LIMITED_TIME_COLOR;
					obj11 = transform4;
					((Color32*)(nint)color)->rgba = (int)obj11;
					limitedTimerColor = (Color32)color.rgba;
					obj12 = GlobalColors.SPECIAL_DISCOUNT_WINTER_HOLIDAY_BUTTON_LIMITED_TIME_SHADOW_COLOR;
					obj13 = obj12;
					((Color32*)(nint)color)->rgba = (int)obj13;
					limitedTimerColorShadow = (Color32)color.rgba;
					obj14 = GlobalColors.SPECIAL_DISCOUNT_WINTER_HOLIDAY_STICKER_COLOR;
					obj15 = obj14;
					((Color32*)(nint)color)->rgba = (int)obj15;
					stickerColor = (Color32)color.rgba;
					obj16 = GlobalColors.SPECIAL_DISCOUNT_WINTER_HOLIDAY_STICKER_LABEL_COLOR;
					obj17 = obj16;
					((Color32*)(nint)color)->rgba = (int)obj17;
					object obj50 = this - -64;
					obj50 = color.rgba;
					obj18 = GlobalColors.SPECIAL_DISCOUNT_WINTER_HOLIDAY_BUTTON_DESCRIPTION1_ACTIVE_COLOR;
					obj19 = obj18;
					((Color32*)(nint)color)->rgba = (int)obj19;
					description1ColorActive = (Color32)color.rgba;
					obj20 = GlobalColors.SPECIAL_DISCOUNT_WINTER_HOLIDAY_BUTTON_DESCRIPTION1_ACTIVE_SHADOW_COLOR;
					obj21 = obj20;
					((Color32*)(nint)color)->rgba = (int)obj21;
					description1ColorShadowActive = (Color32)color.rgba;
					obj22 = GlobalColors.SPECIAL_DISCOUNT_WINTER_HOLIDAY_BUTTON_DESCRIPTION2_COLOR;
					obj23 = obj22;
					((Color32*)(nint)color)->rgba = (int)obj23;
					description2Color = (Color32)color.rgba;
					obj24 = GlobalColors.SPECIAL_DISCOUNT_WINTER_HOLIDAY_BUTTON_DESCRIPTION2_SHADOW_COLOR;
					obj25 = obj24;
					((Color32*)(nint)color)->rgba = (int)obj25;
					description2ColorShadow = (Color32)color.rgba;
					obj26 = GlobalColors.SPECIAL_DISCOUNT_WINTER_HOLIDAY_BUTTON_LINE_THROUGH_COLOR;
					obj27 = obj26;
					((Color32*)(nint)color)->rgba = (int)obj27;
					lineThroughColor = (Color32)color.rgba;
					obj28 = GlobalColors.SPECIAL_DISCOUNT_WINTER_HOLIDAY_BUTTON_LINE_THROUGH_SHADOW_COLOR;
					obj29 = obj28;
					((Color32*)(nint)color)->rgba = (int)obj29;
					lineThroughShadowColor = (Color32)color.rgba;
					object obj51 = this + 76;
					obj51 = "button_fill_shopItem_holiday_highlight_sale";
					object obj52 = this + 80;
					obj52 = "button_fill_shopItem_holiday_main_sale";
					object obj53 = this + 84;
					obj53 = "icon_background_normal";
					object obj54 = this + 88;
					obj54 = "icon_background_keys";
				}
				else
				{
					nint num7 = (nint)typeof(InAppManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ S0_v342 (Il2CppClass<InApp.InAppManager>)+BA]");
					object obj55 = (nint)0 & (nint)0x200;
					if (obj55 != null)
					{
						nint num8 = (nint)typeof(InAppManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v749 @ S0_v432 (Il2CppClass<InApp.InAppManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (AdsSave.behavioralAdsAllowed)
					{
						nint num9 = (nint)typeof(GlobalColors);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v781 @ S0_v349 (Il2CppClass<GlobalColors>)+BA]");
						object obj56 = (nint)0 & (nint)0x200;
						if (obj56 != null)
						{
							nint num10 = (nint)typeof(GlobalColors);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v788 @ S0_v426 (Il2CppClass<GlobalColors>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						transform = (Transform)GlobalColors.SPECIAL_DISCOUNT_NEW_YEAR_BUTTON_TITLE_COLOR;
						obj30 = transform;
						((Color32*)(nint)color)->rgba = (int)obj30;
						titleColor = (Color32)color.rgba;
						obj3 = GlobalColors.SPECIAL_DISCOUNT_NEW_YEAR_BUTTON_TITLE_COLOR_SHADOW;
						obj31 = obj3;
						((Color32*)(nint)color)->rgba = (int)obj31;
						titleColorShadow = (Color32)color.rgba;
						obj5 = GlobalColors.SPECIAL_DISCOUNT_NEW_YEAR_BUTTON_DESCRIPTION1_INACTIVE_COLOR;
						obj32 = obj5;
						((Color32*)(nint)color)->rgba = (int)obj32;
						description1ColorInactive = (Color32)color.rgba;
						obj7 = GlobalColors.SPECIAL_DISCOUNT_NEW_YEAR_BUTTON_DESCRIPTION1_INACTIVE_SHADOW_COLOR;
						obj33 = obj7;
						((Color32*)(nint)color)->rgba = (int)obj33;
						description1ColorShadowInactive = (Color32)color.rgba;
						transform2 = (Transform)GlobalColors.SPECIAL_DISCOUNT_NEW_YEAR_BUTTON_PRICE_COLOR;
						obj34 = transform2;
						((Color32*)(nint)color)->rgba = (int)obj34;
						priceColor = (Color32)color.rgba;
						transform3 = (Transform)GlobalColors.SPECIAL_DISCOUNT_NEW_YEAR_BUTTON_PRICE_SHADOW_COLOR;
						obj35 = transform3;
						((Color32*)(nint)color)->rgba = (int)obj35;
						priceColorShadow = (Color32)color.rgba;
						transform4 = (Transform)GlobalColors.SPECIAL_DISCOUNT_NEW_YEAR_BUTTON_LIMITED_TIME_COLOR;
						obj36 = transform4;
						((Color32*)(nint)color)->rgba = (int)obj36;
						limitedTimerColor = (Color32)color.rgba;
						obj12 = GlobalColors.SPECIAL_DISCOUNT_NEW_YEAR_BUTTON_LIMITED_TIME_SHADOW_COLOR;
						obj37 = obj12;
						((Color32*)(nint)color)->rgba = (int)obj37;
						limitedTimerColorShadow = (Color32)color.rgba;
						obj14 = GlobalColors.SPECIAL_DISCOUNT_NEW_YEAR_STICKER_COLOR;
						obj38 = obj14;
						((Color32*)(nint)color)->rgba = (int)obj38;
						stickerColor = (Color32)color.rgba;
						obj16 = GlobalColors.SPECIAL_DISCOUNT_NEW_YEAR_STICKER_LABEL_COLOR;
						obj39 = obj16;
						((Color32*)(nint)color)->rgba = (int)obj39;
						object obj57 = this - -64;
						obj57 = color.rgba;
						obj18 = GlobalColors.SPECIAL_DISCOUNT_NEW_YEAR_BUTTON_DESCRIPTION1_ACTIVE_COLOR;
						obj40 = obj18;
						((Color32*)(nint)color)->rgba = (int)obj40;
						description1ColorActive = (Color32)color.rgba;
						obj20 = GlobalColors.SPECIAL_DISCOUNT_NEW_YEAR_BUTTON_DESCRIPTION1_ACTIVE_SHADOW_COLOR;
						obj41 = obj20;
						((Color32*)(nint)color)->rgba = (int)obj41;
						description1ColorShadowActive = (Color32)color.rgba;
						obj22 = GlobalColors.SPECIAL_DISCOUNT_NEW_YEAR_BUTTON_DESCRIPTION2_COLOR;
						obj42 = obj22;
						((Color32*)(nint)color)->rgba = (int)obj42;
						description2Color = (Color32)color.rgba;
						obj24 = GlobalColors.SPECIAL_DISCOUNT_NEW_YEAR_BUTTON_DESCRIPTION2_SHADOW_COLOR;
						obj43 = obj24;
						((Color32*)(nint)color)->rgba = (int)obj43;
						description2ColorShadow = (Color32)color.rgba;
						obj26 = GlobalColors.SPECIAL_DISCOUNT_NEW_YEAR_BUTTON_LINE_THROUGH_COLOR;
						obj44 = obj26;
						((Color32*)(nint)color)->rgba = (int)obj44;
						lineThroughColor = (Color32)color.rgba;
						obj28 = GlobalColors.SPECIAL_DISCOUNT_NEW_YEAR_BUTTON_LINE_THROUGH_SHADOW_COLOR;
						obj45 = obj28;
						((Color32*)(nint)color)->rgba = (int)obj45;
						lineThroughShadowColor = (Color32)color.rgba;
						object obj58 = this + 76;
						obj58 = "button_fill_shopItem_newyear_highlight_sale";
						object obj59 = this + 80;
						obj59 = "button_fill_shopItem_newyear_main_sale";
						object obj60 = this + 84;
						obj60 = "icon_background_violet";
						object obj61 = this + 88;
						obj61 = "icon_background_violet";
					}
				}
			}
		}
		object obj62 = this + 348;
		UIWidget component = GetComponent<UIWidget>();
		obj62 = component;
		nint num11 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ S1_v58 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj63 = (nint)0 & (nint)0x200;
		if (obj63 != null)
		{
			nint num12 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ S1_v379 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_widget).FindKernel((string)null) != 0)
		{
			UIWidget widget = _widget;
			UIWidget widget2 = _widget;
			transform = (Transform)0;
			((UnityEngine.Object)transform).m_CachedPtr = (IntPtr)0;
			transform = (Transform)widget.mWidth;
			_ = widget2.mHeight;
			((UnityEngine.Object)transform).m_CachedPtr = (IntPtr)1f;
			((Color32*)(nint)color)->rgba = (int)transform;
			_ = ((UnityEngine.Object)transform).m_CachedPtr;
			object obj64 = this + 252;
			obj64 = color.rgba;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Color32)+8]");
			_ = 0;
		}
		transform.localPosition = (Vector3)mainTextContent;
		((Color32*)(nint)color)->rgba = (int)transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		object obj65 = this + 92;
		obj65 = color.rgba;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Color32)+8]");
		_ = 0;
		object obj66 = this + 184;
		UISprite uISprite = fillColorSprite;
		obj66 = uISprite.mSpriteName;
		object obj67 = this + 188;
		UISprite uISprite2 = fillGraySprite;
		obj67 = uISprite2.mSpriteName;
		UISprite uISprite3 = fillGraySprite;
		UISprite uISprite4 = fillGraySprite;
		obj3 = 0;
		_ = 0;
		obj3 = ((UIWidget)uISprite3).mWidth;
		_ = ((UIWidget)uISprite4).mHeight;
		_ = 1f;
		((Color32*)(nint)color)->rgba = (int)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
		_ = 0;
		object obj68 = this + 136;
		obj68 = color.rgba;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Color32)+8]");
		_ = 0;
		UISprite uISprite5 = fillColorSprite;
		UISprite uISprite6 = fillColorSprite;
		obj5 = 0;
		_ = 0;
		obj5 = ((UIWidget)uISprite5).mWidth;
		_ = ((UIWidget)uISprite6).mHeight;
		_ = 1f;
		((Color32*)(nint)color)->rgba = (int)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
		_ = 0;
		object obj69 = this + 148;
		obj69 = color.rgba;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Color32)+8]");
		_ = 0;
		UISprite uISprite7 = outlineSprite;
		UISprite uISprite8 = outlineSprite;
		obj7 = 0;
		_ = 0;
		obj7 = ((UIWidget)uISprite7).mWidth;
		_ = ((UIWidget)uISprite8).mHeight;
		_ = 1f;
		((Color32*)(nint)color)->rgba = (int)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v23+8]");
		_ = 0;
		object obj70 = this + 160;
		obj70 = color.rgba;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Color32)+8]");
		_ = 0;
		transform2.localPosition = (Vector3)content;
		((Color32*)(nint)color)->rgba = (int)transform2;
		_ = ((UnityEngine.Object)transform2).m_CachedPtr;
		object obj71 = this + 172;
		obj71 = color.rgba;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Color32)+8]");
		_ = 0;
		Camera anchorCamera = description1.anchorCamera;
		transform3.localPosition = (Vector3)anchorCamera;
		((Color32*)(nint)color)->rgba = (int)transform3;
		_ = ((UnityEngine.Object)transform3).m_CachedPtr;
		object obj72 = this + 104;
		obj72 = color.rgba;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Color32)+8]");
		_ = 0;
		Camera anchorCamera2 = price.anchorCamera;
		transform4.localPosition = (Vector3)anchorCamera2;
		((Color32*)(nint)color)->rgba = (int)transform4;
		_ = ((UnityEngine.Object)transform4).m_CachedPtr;
		object obj73 = this + 116;
		obj73 = color.rgba;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Color32)+8]");
		_ = 0;
		object obj74 = price + 80;
		obj12 = obj74;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1057 @ S1_v162+8]");
		_ = 0;
		((Color32*)(nint)color)->rgba = (int)obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v39+8]");
		_ = 0;
		Color color2 = color;
		object obj75 = obj + 352;
		obj75 = obj14;
		((Color32*)(nint)color)->rgba = (int)obj75;
		originalPriceColor = (Color32)color.rgba;
		object obj76 = price + 328;
		obj16 = obj76;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1090 @ S1_v180+8]");
		_ = 0;
		((Color32*)(nint)color)->rgba = (int)obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v47+8]");
		_ = 0;
		Color color3 = color;
		object obj77 = obj + 348;
		obj77 = obj18;
		((Color32*)(nint)color)->rgba = (int)obj77;
		originalPriceColorShadow = (Color32)color.rgba;
		object obj78 = title + 80;
		obj20 = obj78;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1123 @ S1_v198+8]");
		_ = 0;
		((Color32*)(nint)color)->rgba = (int)obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v55+8]");
		_ = 0;
		Color color4 = color;
		object obj79 = obj + 344;
		obj79 = obj22;
		((Color32*)(nint)color)->rgba = (int)obj79;
		originalTitleColor = (Color32)color.rgba;
		object obj80 = title + 328;
		obj24 = obj80;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1155 @ S1_v216+8]");
		_ = 0;
		((Color32*)(nint)color)->rgba = (int)obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v63+8]");
		_ = 0;
		Color color5 = color;
		object obj81 = obj + 340;
		obj81 = obj26;
		((Color32*)(nint)color)->rgba = (int)obj81;
		originalTitleColorShadow = (Color32)color.rgba;
		object obj82 = obj + 32;
		UILabel uILabel = title;
		obj82 = uILabel.mEffectDistance;
		((Color32*)(nint)color)->rgba = (int)obj82;
		originalTitleDistanceShadow = (Vector2)color.rgba;
		object obj83 = description1 + 80;
		obj28 = obj83;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1200 @ S1_v242+8]");
		_ = 0;
		((Color32*)(nint)color)->rgba = (int)obj28;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S0_v71+8]");
		_ = 0;
		object obj84 = obj + 120;
		Color color6 = color;
		object obj85 = obj + 336;
		obj85 = obj84;
		((Color32*)(nint)color)->rgba = (int)obj85;
		originalDescription1Color = (Color32)color.rgba;
		object obj86 = obj + 104;
		object obj87 = description1 + 328;
		obj86 = obj87;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1239 @ S1_v262+8]");
		_ = 0;
		((Color32*)(nint)color)->rgba = (int)obj86;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1233 @ S0_v242+8]");
		_ = 0;
		object obj88 = obj + 96;
		Color color7 = color;
		object obj89 = obj + 332;
		obj89 = obj88;
		((Color32*)(nint)color)->rgba = (int)obj89;
		originalDescription1ColorShadow = (Color32)color.rgba;
		object obj90 = obj + 80;
		object obj91 = description2 + 80;
		obj90 = obj91;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1278 @ S1_v282+8]");
		_ = 0;
		((Color32*)(nint)color)->rgba = (int)obj90;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1272 @ S0_v253+8]");
		_ = 0;
		object obj92 = obj + 72;
		Color color8 = color;
		object obj93 = obj + 316;
		obj93 = obj92;
		((Color32*)(nint)color)->rgba = (int)obj93;
		originalDescription2Color = (Color32)color.rgba;
		object obj94 = obj + 56;
		object obj95 = description2 + 328;
		obj94 = obj95;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1317 @ S1_v302+8]");
		_ = 0;
		((Color32*)(nint)color)->rgba = (int)obj94;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1311 @ S0_v264+8]");
		_ = 0;
		object obj96 = obj + 52;
		Color color9 = color;
		object obj97 = obj + 276;
		obj97 = obj96;
		((Color32*)(nint)color)->rgba = (int)obj97;
		originalDescription2ColorShadow = (Color32)color.rgba;
		UISprite uISprite9 = icon;
		UISprite uISprite10 = icon;
		object obj98 = obj + 8;
		obj98 = 0;
		obj98 = ((UIWidget)uISprite9).mWidth;
		_ = ((UIWidget)uISprite10).mHeight;
		object obj99 = obj + 24;
		obj99 = obj98;
		((Color32*)(nint)color)->rgba = (int)obj99;
		originalIconSize = (Vector2)color.rgba;
		UISprite uISprite11 = iconBG;
		UISprite uISprite12 = iconBG;
		obj = 0;
		obj = ((UIWidget)uISprite11).mWidth;
		_ = ((UIWidget)uISprite12).mHeight;
		object obj100 = obj + 16;
		obj100 = obj;
		((Color32*)(nint)color)->rgba = (int)obj100;
		originalIconBGSize = (Vector2)color.rgba;
		Transform transform5 = (Transform)(obj + 40);
		GameObject gameObject = iconBG.gameObject;
		transform5.localPosition = (Vector3)gameObject;
		((Color32*)(nint)color)->rgba = (int)transform5;
		_ = ((UnityEngine.Object)transform5).m_CachedPtr;
		object obj101 = this + 240;
		obj101 = color.rgba;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Color32)+8]");
		_ = 0;
		nint num13 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1430 @ S1_v354 (Il2CppClass<Strings>)+BA]");
		object obj102 = (nint)0 & (nint)0x200;
		if (obj102 != null)
		{
			nint num14 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1436 @ S1_v361 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault("DISCOUNT_BUTTON_LIMITED_TITLE");
		limitedTitle.fontSize = (int)text;
	}

	private void SetDiscountColors(DiscountButtonState state)
	{
		//IL_01ab: Expected Obj, but got I4
		//IL_01dd: Expected Obj, but got I4
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Expected Obj, but got Unknown
		//IL_0172: Expected Obj, but got I4
		//IL_0189: Expected Obj, but got F4
		//IL_019d: Expected I, but got F4
		//IL_0070: Expected I, but got Obj
		//IL_0086: Expected Obj, but got I
		//IL_0139: Expected Obj, but got I4
		//IL_0150: Expected Obj, but got F4
		//IL_0164: Expected I, but got F4
		//IL_0246: Expected Obj, but got I4
		//IL_0258: Expected Obj, but got I4
		//IL_00b1: Expected I, but got Obj
		//IL_0127: Expected Obj, but got I4
		//IL_0127: Expected Obj, but got I4
		object obj = 0;
		_ = 0;
		string text = limitedTitle.tag;
		bool flag = state == DiscountButtonState.Normal;
		string text2 = (((GameObject)(object)text).tag = (string)((flag ? 1 : 0) ^ 1));
		string text4 = limitedTime.tag;
		((GameObject)(object)text4).tag = text2;
		limitedTitle.tag = text2;
		limitedTime.tag = text2;
		if (limitedTime.isActiveAndEnabled)
		{
			nint num = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v31 (Il2CppClass<UIScreenController>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v42 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag2 = UIScreenController.ShouldShowOnlineScreen();
			bool isShowingPopup = ((UIScreenController)flag2).isShowingPopup;
			if ((string)isShowingPopup != "NotEnoughCurrencyPopup")
			{
				UIWidget component = limitedTime.GetComponent<UIWidget>();
				Bounds bounds = ((UIWidget)65).CalculateBounds((Transform)9);
			}
		}
		Transform transform = (Transform)(obj + 12);
		GameObject gameObject = price.gameObject;
		if (flag)
		{
			transform = (Transform)0;
			((UnityEngine.Object)transform).m_CachedPtr = (IntPtr)0;
			transform = (Transform)97f;
			_ = -1.2f;
			((UnityEngine.Object)transform).m_CachedPtr = (IntPtr)0f;
		}
		else
		{
			transform = (Transform)0;
			((UnityEngine.Object)transform).m_CachedPtr = (IntPtr)0;
			transform = (Transform)97f;
			_ = 2.5f;
			((UnityEngine.Object)transform).m_CachedPtr = (IntPtr)0f;
		}
		obj = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		transform = (Transform)obj;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
	}

	public unsafe DiscountButton()
	{
		//IL_03cc: Expected I, but got Obj
		//IL_03e2: Expected Obj, but got I
		//IL_0408: Unknown result type (might be due to invalid IL or missing references)
		//IL_040d: Expected Obj, but got Unknown
		//IL_0424: Expected Obj, but got I4
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_0447: Expected I4, but got Unknown
		//IL_0454: Expected I4, but got Obj
		//IL_0479: Unknown result type (might be due to invalid IL or missing references)
		//IL_047e: Expected Obj, but got Unknown
		//IL_0060: Expected Obj, but got I4
		//IL_0082: Expected I4, but got Obj
		//IL_0098: Expected Obj, but got I4
		//IL_00a6: Expected Obj, but got VT
		//IL_00b3: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected Obj, but got Unknown
		//IL_00df: Expected Obj, but got VT
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected Obj, but got Unknown
		//IL_0102: Expected I4, but got Obj
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected Obj, but got Unknown
		//IL_0119: Expected VT, but got I4
		//IL_012a: Expected I4, but got Obj
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected Obj, but got Unknown
		//IL_0170: Expected Obj, but got I4
		//IL_0192: Expected I4, but got Obj
		//IL_01a8: Expected Obj, but got I4
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected Obj, but got Unknown
		//IL_01c9: Expected Obj, but got VT
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected Obj, but got Unknown
		//IL_01ec: Expected I4, but got Obj
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected Obj, but got Unknown
		//IL_0203: Expected VT, but got I4
		//IL_0214: Expected I4, but got Obj
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected Obj, but got Unknown
		//IL_024d: Expected Obj, but got VT
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Expected Obj, but got Unknown
		//IL_0270: Expected I4, but got Obj
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected Obj, but got Unknown
		//IL_0287: Expected VT, but got I4
		//IL_0298: Expected I4, but got Obj
		//IL_02ae: Expected Obj, but got I4
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Expected Obj, but got Unknown
		//IL_02cf: Expected Obj, but got VT
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Expected Obj, but got Unknown
		//IL_02f2: Expected I4, but got Obj
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Expected Obj, but got Unknown
		//IL_0309: Expected VT, but got I4
		//IL_031a: Expected I4, but got Obj
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Expected Obj, but got Unknown
		//IL_0353: Expected Obj, but got VT
		//IL_035c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0361: Expected Obj, but got Unknown
		//IL_0376: Expected I4, but got Obj
		//IL_037f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0384: Expected Obj, but got Unknown
		//IL_038d: Expected VT, but got I4
		//IL_039e: Expected I4, but got Obj
		//IL_03b4: Expected Obj, but got I4
		nint num = (nint)typeof(ColorData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<UI.ColorData>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(ColorData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v80 (Il2CppClass<UI.ColorData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 160;
		bool flag = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
		object obj4 = (flag ? 1 : 0) + 268;
		obj2 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S2_v5+8]");
		_ = 0;
		UIWidget.Pivot pivot = (UIWidget.Pivot)(obj3 + 192);
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v9+8]");
		_ = 0;
		title.rawPivot = pivot;
		object obj5 = obj3 + 144;
		bool flag2 = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
		object obj6 = (flag2 ? 1 : 0) + 732;
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S2_v18+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S1_v16+8]");
		_ = 0;
		Vector2 effectDistance = ((UILabel)pivot).effectDistance;
		obj3 = originalTitleDistanceShadow;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj3;
		title.shrinkToFit = (byte)pivot != 0;
		object obj7 = obj3 + 136;
		obj7 = originalDescription1Color;
		object obj8 = obj3 + 184;
		obj8 = obj7;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj8;
		object obj9 = obj3 + 120;
		Matrix4x4 matrix4x = Matrix4x4.Inverse((Matrix4x4)pivot);
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S1_v30+8]");
		_ = 0;
		description1.rawPivot = pivot;
		object obj10 = obj3 + 104;
		bool flag3 = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
		object obj11 = (flag3 ? 1 : 0) + 732;
		obj10 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S2_v50+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S1_v35+8]");
		_ = 0;
		Vector2 effectDistance2 = ((UILabel)pivot).effectDistance;
		object obj12 = obj3 + 96;
		obj12 = originalDescription2Color;
		object obj13 = obj3 + 180;
		obj13 = obj12;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj13;
		object obj14 = obj3 + 80;
		Matrix4x4 matrix4x2 = Matrix4x4.Inverse((Matrix4x4)pivot);
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ S1_v46+8]");
		_ = 0;
		description2.rawPivot = pivot;
		object obj15 = obj3 + 72;
		obj15 = originalDescription2ColorShadow;
		object obj16 = obj3 + 176;
		obj16 = obj15;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj16;
		object obj17 = obj3 + 56;
		Matrix4x4 matrix4x3 = Matrix4x4.Inverse((Matrix4x4)pivot);
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ S1_v56+8]");
		_ = 0;
		Vector2 effectDistance3 = ((UILabel)pivot).effectDistance;
		object obj18 = obj3 + 48;
		obj18 = originalPriceColor;
		object obj19 = obj3 + 140;
		obj19 = obj18;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj19;
		object obj20 = obj3 + 32;
		Matrix4x4 matrix4x4 = Matrix4x4.Inverse((Matrix4x4)pivot);
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ S1_v66+8]");
		_ = 0;
		price.rawPivot = pivot;
		object obj21 = obj3 + 24;
		obj21 = originalPriceColorShadow;
		object obj22 = obj3 + 100;
		obj22 = obj21;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj22;
		object obj23 = obj3 + 8;
		Matrix4x4 matrix4x5 = Matrix4x4.Inverse((Matrix4x4)pivot);
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ S1_v76+8]");
		_ = 0;
		Vector2 effectDistance4 = ((UILabel)pivot).effectDistance;
	}
}
