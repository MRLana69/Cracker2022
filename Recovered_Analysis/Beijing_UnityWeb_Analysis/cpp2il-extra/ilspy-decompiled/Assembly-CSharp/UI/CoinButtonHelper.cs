using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using InApp;
using Kiloo.Common.Extensions;
using SYBO.Subway.Info;
using UI.Helpers.WelcomePack;
using UI.Screens;
using UI.Screens.CoinScreenInternal;
using UnityEngine;

namespace UI;

public class CoinButtonHelper : DiscountButton
{
	private Transform _onDisplayParent;

	private CoinContainer _coinContainer;

	private InAppItemModel _itemData;

	private string _screenName;

	public Action onClick;

	private void OnClick()
	{
		CancelInvoke();
	}

	public override bool SupportsSpecialSale()
	{
		//IL_0065: Expected I, but got Obj
		//IL_007b: Expected Obj, but got I
		//IL_00bf: Expected Obj, but got I
		//IL_00c3: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string flurryUserId = Flurry.flurryUserId;
		bool isInstanced = UIScreenController.IsInstanced;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v4 (System.Boolean)+84]");
		return (byte)(int)Flurry.ToDictionary(flurryUserId, (string)0) != 0;
	}

	public void Init(InAppItemModel inAppItem, Transform offerContainer, string screenName, bool showDiscountSticker = true)
	{
		//IL_027f: Expected Obj, but got I4
		//IL_027f: Expected Obj, but got VT
		//IL_02c2: Expected I, but got Obj
		//IL_02d8: Expected Obj, but got I
		//IL_0303: Expected I4, but got Obj
		//IL_0315: Expected I, but got Obj
		//IL_032b: Expected Obj, but got I
		//IL_037f: Expected I4, but got Obj
		//IL_037f: Expected Obj, but got VT
		//IL_002f: Expected I, but got Obj
		//IL_00cc: Expected I4, but got VT
		//IL_00da: Expected I4, but got Obj
		//IL_007c: Expected I, but got Obj
		//IL_00f1: Expected I, but got Obj
		//IL_0107: Expected Obj, but got I
		//IL_0258: Expected I4, but got Obj
		//IL_0258: Expected Obj, but got VT
		//IL_01f5: Expected I, but got Obj
		//IL_026e: Expected I4, but got VT
		//IL_01be: Expected I4, but got Obj
		//IL_01be: Expected Obj, but got VT
		//IL_0170: Expected I, but got Obj
		((GameObject)description1ColorInactive).tag = (string)1;
		float nearClipPlane = ((!showDiscountSticker) ? 0f : 1f);
		((CameraSettings)(object)this).nearClipPlane = nearClipPlane;
		object obj = offerContainer;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		nint num = (nint)typeof(Characters);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S1_v11 (Il2CppClass<SYBO.Subway.Info.Characters>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Characters);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S1_v40 (Il2CppClass<SYBO.Subway.Info.Characters>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Characters.Model model = Characters.characterData.get_Item((Characters.CharacterId)inAppItem);
		nint num3 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S2_v8 (Il2CppClass<Strings>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S2_v29 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string arg = Strings.GetDefault(model.tokenName);
		string format = default;
		string text = string.Format((IFormatProvider)(object)"{0}x {1}", format, arg);
		((UILabel)titleColor).fontSize = (int)text;
		((CharacterScrollListSlot)null).SetEnabledState((byte)(int)titleColor != 0, true);
		Characters.Model model2 = Characters.characterData.get_Item((Characters.CharacterId)inAppItem);
		nint num5 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v22 (Il2CppClass<Strings>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		bool flag = obj4 == null;
		if ((nint)screenName < 1)
		{
			if (!flag)
			{
				nint num6 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v47 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string format2 = Strings.GetDefault("CELEBRATION_POPUP_YOU_UNLOCKED_TROPHY");
			string args = Strings.GetDefault(model2.name);
			string text2 = string.Format(format2, (object[])(object)args);
			((UILabel)titleColorShadow).fontSize = (int)text2;
		}
		else
		{
			if (!flag)
			{
				nint num7 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S0_v39 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string provider = Strings.GetDefault("CELEBRATION_POPUP_COLLECT_MORE_TOKENS");
			obj = screenName;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			string arg2 = Strings.GetDefault(model2.name);
			string format3 = default;
			string text3 = string.Format((IFormatProvider)(object)provider, format3, arg2);
			((UILabel)titleColorShadow).fontSize = (int)text3;
		}
		((CharacterScrollListSlot)null).SetEnabledState((byte)(int)titleColorShadow != 0, true);
	}

	public void AddMostPopularSticker(GameObject prefab, Vector2 stickerOffset, UIPanel coinScreenPanel, int padding = 0)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected Obj, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		//IL_0043: Expected Obj, but got VT
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected Obj, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		int showDiscountSticker = padding & 1;
		_showDiscountSticker = (byte)showDiscountSticker != 0;
		object obj = this + 364;
		obj = prefab;
		object obj2 = this + 356;
		obj2 = stickerOffset;
		object obj3 = this + 368;
		obj3 = coinScreenPanel;
		object obj4 = this + 360;
		_0021_00210[] componentsInParent = (_0021_00210[])(object)((Component)this).GetComponentsInParent<T>();
		obj4 = componentsInParent;
		FormatButton(DiscountButton.DiscountButtonState.Normal);
	}

	public unsafe void AddSticker(GameObject stickerGo, Vector2 stickerOffset, int stickerHeight, int padding = 0)
	{
		//IL_00d8: Expected I, but got Obj
		//IL_00ee: Expected Obj, but got I
		//IL_0118: Expected I4, but got Obj
		//IL_0125: Expected Obj, but got I4
		//IL_013e: Expected Obj, but got I
		//IL_013e: Expected Obj, but got VT
		//IL_005b: Expected Obj, but got VT
		//IL_006f: Expected Obj, but got I
		//IL_007c: Expected Obj, but got F4
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected VT, but got Unknown
		//IL_0097: Expected F4, but got Obj
		//IL_0092: Expected native int or pointer, but got VT
		//IL_0013: Expected I, but got Obj
		string go = content.tag;
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v5 (Il2CppClass<NGUITools>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S1_v21 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num3 = NGUITools.CalculateNextDepth((GameObject)(object)go, (byte)(int)stickerGo != 0);
		_0021_00210 componentInChildren = (_0021_00210)((GameObject)num3).GetComponentInChildren<T>();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [stickerHeight @ L3 (System.Int32)+F4]");
		((WelcomePackBannerHelper)componentInChildren).SetupLabels((List<InAppItemModel.BundleItem>)0);
		string stickerGo2 = ((Component)componentInChildren).tag;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v12 (T)+10]");
		object obj2 = 0;
		object obj3 = stickerOffset.x;
		Vector2 vector = (Vector2)(obj3 + 8);
		((Vector2*)(nint)vector)->x = (float)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v16+68]");
		SetOffsets((GameObject)(object)stickerGo2, vector, 0, padding);
	}

	private void SetOffsets(GameObject stickerGo, Vector2 stickerOffset, int stickerHeight, int padding = 0)
	{
		//IL_000d: Expected Obj, but got F4
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		//IL_0039: Expected Obj, but got I4
		//IL_0039: Expected Obj, but got I4
		//IL_0039: Expected I4, but got Obj
		//IL_0050: Expected Obj, but got I4
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		object obj = stickerOffset.x;
		string text = (string)(obj + 8);
		text = (string)obj;
		SetProductData((DiscountButton.DiscountButtonState)stickerGo, text, (string)stickerHeight, (string)padding);
		UIWidget widget = _widget;
		object obj2 = padding + stickerHeight;
		UIWidget uIWidget = (UIWidget)(obj2 + widget.mHeight);
		Color color = uIWidget.color;
	}

	private void ForceEndDiscount()
	{
		//IL_00c0: Expected Obj, but got I
		//IL_00d0: Expected Obj, but got I
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected Obj, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected Obj, but got Unknown
		//IL_011e: Expected Obj, but got I
		//IL_012e: Expected Obj, but got I
		//IL_013e: Expected Obj, but got I
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected Obj, but got Unknown
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected Obj, but got Unknown
		//IL_017a: Expected Obj, but got I
		//IL_018a: Expected Obj, but got I
		//IL_019a: Expected Obj, but got I
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected Obj, but got Unknown
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Expected Obj, but got Unknown
		//IL_01ce: Expected I, but got Obj
		//IL_01e4: Expected Obj, but got I
		//IL_020f: Expected I, but got Obj
		//IL_0225: Expected Obj, but got I
		//IL_0267: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S3_v3+60]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v28 @ S4_v4 (should have been resolved before IL gen)");
		InAppItemModel itemData = _itemData;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S4_v6 (Il2CppMethodInfo)+C]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S4_v7+60]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S4_v8+48]");
		object obj8 = 0;
		object obj9 = obj8 & 0x7FF;
		object obj10 = obj9 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v49 @ S5_v6 (should have been resolved before IL gen)");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S4_v11 (Il2CppMethodInfo)+C]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S4_v12+60]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S4_v13+48]");
		object obj13 = 0;
		object obj14 = obj13 & 0x7FF;
		object obj15 = obj14 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v68 @ S5_v10 (should have been resolved before IL gen)");
		nint num4 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v13 (Il2CppClass<Flurry>)+BA]");
		object obj16 = (nint)0 & (nint)0x200;
		if (obj16 != null)
		{
			nint num5 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v30 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num6 = (nint)typeof(InAppManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v18 (Il2CppClass<InApp.InAppManager>)+BA]");
		object obj17 = (nint)0 & (nint)0x200;
		if (obj17 != null)
		{
			nint num7 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v26 (Il2CppClass<InApp.InAppManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Dictionary<string, InAppItemModel> activeInAppOffers = InAppManager.GetActiveInAppOffers();
		InAppItemModel itemData2 = _itemData;
		((InAppManager)(object)activeInAppOffers).InitFinishedCallback((byte)(int)itemData2.itemId != 0);
		TransformExtensions.Reset((Transform)(object)onClick);
	}

	public unsafe void Show(bool forceEndDiscount = false)
	{
		//IL_00cf: Expected I4, but got VT
		//IL_00cf: Expected Obj, but got I
		//IL_00cf: Expected Obj, but got VT
		//IL_009c: Expected Obj, but got VT
		//IL_0139: Expected Obj, but got I
		//IL_0139: Expected Obj, but got VT
		//IL_014c: Expected I, but got Obj
		//IL_0162: Expected Obj, but got I
		//IL_010e: Expected Obj, but got VT
		//IL_022d: Expected I4, but got VT
		//IL_022d: Expected Obj, but got I
		//IL_022d: Expected Obj, but got VT
		//IL_018d: Expected I, but got Obj
		//IL_0240: Expected I, but got Obj
		//IL_0256: Expected Obj, but got I
		//IL_0201: Expected Obj, but got VT
		//IL_0328: Expected I4, but got VT
		//IL_0328: Expected Obj, but got I
		//IL_0328: Expected Obj, but got VT
		//IL_0281: Expected I, but got Obj
		//IL_02f5: Expected Obj, but got VT
		if (originalFillGraySpriteName != null)
		{
			if ((nint)originalFillGraySpriteName != 1)
			{
				if ((nint)originalFillGraySpriteName != 2)
				{
					if ((nint)originalFillGraySpriteName == 3)
					{
						if (forceEndDiscount)
						{
							Color32 color = originalTitleColor;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.CoinButtonHelper)+98]");
							((CharacterScreenManager)color).CharacterPurchaseSuccessful(Characters.CharacterId.tricky, 0);
							return;
						}
						Color32 color2 = originalTitleColor;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.CoinButtonHelper)+98]");
						nint num = 0;
						Vector3 vector = originalOutlineScale;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.CoinButtonHelper)+B0]");
						((LeaderboardOnlineScreen)color2).SetOnlineContentListForLeaderboard(true, (Friend[])num, (byte)(int)vector != 0, ref *(bool*)null);
					}
					return;
				}
				if (forceEndDiscount)
				{
					Color32 color3 = originalTitleColor;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.CoinButtonHelper)+98]");
					((CharacterScreenManager)color3).CharacterPurchaseSuccessful(Characters.CharacterId.spike, 0);
				}
				else
				{
					Color32 color4 = originalTitleColor;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.CoinButtonHelper)+98]");
					((LeaderboardOnlineScreen)color4).SetOnlineContentListForLeaderboard(true, (Friend[])0, (byte)(int)originalOutlineScale != 0, ref *(bool*)(-1));
				}
				nint num2 = (nint)typeof(CharacterScreen);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S0_v47 (Il2CppClass<UI.Screens.CharacterScreen>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num3 = (nint)typeof(CharacterScreen);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S0_v56 (Il2CppClass<UI.Screens.CharacterScreen>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				CharacterScreen.forceCenterOnCurrentlySelectedCharacter = true;
				CharacterScreen.forceRefreshOnCharacterScreen = true;
				return;
			}
			if (forceEndDiscount)
			{
				Color32 color5 = originalTitleColor;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.CoinButtonHelper)+98]");
				((CharacterScreenManager)color5).CharacterPurchaseSuccessful(Characters.CharacterId.fresh, 0);
			}
			else
			{
				Color32 color6 = originalTitleColor;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.CoinButtonHelper)+98]");
				((LeaderboardOnlineScreen)color6).SetOnlineContentListForLeaderboard(true, (Friend[])0, false, ref *(bool*)(-1));
			}
			nint num4 = (nint)typeof(CharacterScreen);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v23 (Il2CppClass<UI.Screens.CharacterScreen>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num5 = (nint)typeof(CharacterScreen);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S0_v32 (Il2CppClass<UI.Screens.CharacterScreen>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			CharacterScreen.forceCenterOnCurrentlySelectedCharacter = true;
			CharacterScreen.forceRefreshOnCharacterScreen = true;
		}
		else if (forceEndDiscount)
		{
			Color32 color7 = originalTitleColor;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.CoinButtonHelper)+98]");
			((CharacterScreenManager)color7).CharacterPurchaseSuccessful(Characters.CharacterId.tricky, 0);
		}
		else
		{
			Color32 color8 = originalTitleColor;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.CoinButtonHelper)+98]");
			nint num6 = 0;
			Vector3 vector2 = originalOutlineScale;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.CoinButtonHelper)+B0]");
			((LeaderboardOnlineScreen)color8).SetOnlineContentListForLeaderboard(true, (Friend[])num6, (byte)(int)vector2 != 0, ref *(bool*)null);
		}
	}

	private string GetCurrencyText()
	{
		//IL_0006: Expected Obj, but got I4
		return (string)1;
	}

	private void ShowAsPromotion()
	{
		//IL_008c: Expected I, but got Obj
		//IL_00a2: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_coinContainer).FindKernel((string)null) != 0)
		{
			FormatButton(DiscountButton.DiscountButtonState.Sale);
			_coinContainer.ActivateSpecialSale();
			_coinContainer._002Ector();
		}
	}

	public CoinButtonHelper()
	{
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Expected Obj, but got Unknown
		//IL_0195: Expected I, but got Obj
		//IL_01ab: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_03d9: Expected I, but got Obj
		//IL_03ef: Expected Obj, but got I
		//IL_0157: Expected Obj, but got I4
		//IL_033c: Expected I, but got Obj
		//IL_0352: Expected Obj, but got I
		//IL_043a: Expected Obj, but got I4
		//IL_01d6: Expected I, but got Obj
		//IL_039d: Expected Obj, but got I4
		//IL_0054: Expected I, but got Obj
		//IL_0223: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_02a1: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 4;
		InAppItemModel itemData = _itemData;
		InAppItemModel itemData2 = _itemData;
		string format2;
		if (itemData2.itemType == InAppItemModel.ItemType.Coins)
		{
			nint num = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v53 (Il2CppClass<Strings>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num2 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v64 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string format = Strings.GetDefault("COIN_BUTTON_HELPER_NUMBER_OF_COINS");
			nint num3 = (nint)typeof(InAppData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S1_v40 (Il2CppClass<InApp.InAppData>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num4 = (nint)typeof(InAppData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S1_v49 (Il2CppClass<InApp.InAppData>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			InAppItemModel itemData3 = _itemData;
			InAppItemModel inAppItemModel = InAppData.inAppData.get_Item(itemData3.normalOfferId);
			obj = inAppItemModel.payoutAmount;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			object[] args = default;
			string text = string.Format(format, args);
			format2 = Strings.GetDefault("COIN_BUTTON_HELPER_NUMBER_OF_COINS_SALE");
			string text2 = text;
			string itemId = itemData.itemId;
		}
		else
		{
			bool flag = itemData.itemType == InAppItemModel.ItemType.Keys;
			InAppItemModel itemData4 = _itemData;
			if (!flag)
			{
				obj = itemData4.itemType;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				string text3 = default;
				string msg = "Item type not supported in CoinButtonHelper: " + text3;
				SDebug.LogFormat(msg, null);
				return;
			}
			nint num5 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v28 (Il2CppClass<Strings>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num6 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v39 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string format3 = Strings.GetDefault("COIN_BUTTON_HELPER_NUMBER_OF_KEYS");
			nint num7 = (nint)typeof(InAppData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S1_v17 (Il2CppClass<InApp.InAppData>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num8 = (nint)typeof(InAppData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S1_v26 (Il2CppClass<InApp.InAppData>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			InAppItemModel itemData5 = _itemData;
			InAppItemModel inAppItemModel2 = InAppData.inAppData.get_Item(itemData5.normalOfferId);
			obj = inAppItemModel2.payoutAmount;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			object[] args2 = default;
			string text4 = string.Format(format3, args2);
			format2 = Strings.GetDefault("COIN_BUTTON_HELPER_NUMBER_OF_KEYS_SALE");
			string text2 = text4;
			string itemId = itemData4.itemId;
		}
		InAppItemModel itemData6 = _itemData;
		obj2 = itemData6.payoutAmount;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		object[] args3 = default;
		string text5 = string.Format(format2, args3);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7D0D");
	}
}
