using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Cloud;
using Cpp2ILInjected;
using Data.Managers;
using Data.Save;
using InApp;
using Info;
using Kiloo.Common.Backend.Cloud;
using Kiloo.Common.Extensions;
using Missions;
using SYBO.Subway.Info;
using UI.Generic.Layout;
using UI.Screens;
using UI.Screens.RewardManagement;
using UI.VideoAdPrizes;
using UnityEngine;

namespace UI;

public class CelebrationPopupLabelTemplate : MonoBehaviour
{
	public UILabel bigLabel;

	public UILabel subLabel;

	private GameObject normalStateGO;

	private GameObject megaJackpotStateGO;

	private GameObject awardStateGO;

	private GameObject topRunStateGO;

	private GameObject characterEventStateGO;

	private GameObject doubleUpEventStateGO;

	private UILabel jackpotBigLabel;

	private UILabel jackpotSubLabel;

	private UILabel awardTopDescriptionLabel;

	private UILabel awardBigLabel;

	private UILabel awardBottomDescriptionLabel;

	private UILabel doubleUpTitleLabel;

	private UILabel doubleUpSubLabel;

	public UILabel doubleUpItemLabel;

	private UILabel doubleUpDescribtionLabel;

	private UILabel topRunTopDescriptionLabel;

	private UILabel topRunBigLabel;

	private UILabel topRunScore;

	private UILabel topRunWeekNr;

	private UILabel topRunCountry;

	private UISprite topRunCountryFlag;

	private Layout _topRunCountryLayout;

	private UILabel topRunCheckMarkText;

	private UILabel characterEventWordNumber;

	private UILabel characterEventWordNumberShadow;

	private UILabel characterEventWord;

	public unsafe float Alpha
	{
		get
		{
			//IL_000d: Expected F4, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.CelebrationPopupLabelTemplate)+1B8]");
			return 0f;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected I4, but got Unknown
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			//IL_0025: Expected Obj, but got I4
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Expected Obj, but got Unknown
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Expected Obj, but got Unknown
			//IL_00af: Expected I4, but got Obj
			//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d7: Expected Obj, but got Unknown
			object obj = default;
			UIWidget.Pivot pivot = (UIWidget.Pivot)(obj + 32);
			object obj2 = obj + 16;
			obj2 = 0;
			_ = 0;
			UILabel uILabel = doubleUpDescribtionLabel;
			object obj4 = default;
			object obj7 = default;
			while (true)
			{
				object obj3 = obj4;
				UIRect.AnchorPoint leftAnchor = uILabel.leftAnchor;
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) < System.Runtime.CompilerServices.Unsafe.As<UIRect.AnchorPoint, UIntPtr>(ref leftAnchor))
				{
					object obj5 = doubleUpDescribtionLabel + 16;
					object obj6 = obj7 << 2;
					object obj8 = obj5 + obj6;
					object obj9 = obj8 + 80;
					obj = obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S1_v13+8]");
					_ = 0;
					obj2 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					_ = 0;
					((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
					_ = 0;
					((UIWidget)obj8).rawPivot = pivot;
					obj4 = obj7 + 1;
					continue;
				}
				break;
			}
		}
	}

	private void OnEnable()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00b2: Expected Obj, but got I
		//IL_00b2: Expected Obj, but got I4
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
		bool flag2 = flag;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.CelebrationPopupLabelTemplate)+A8]");
		((UIScreenController)flag2).ShowRewardAnimationForBundlePurchase((List<InAppItemModel.BundleItem>)0, null);
	}

	public unsafe void Init(int backgroundDepth)
	{
		//IL_028a: Expected Obj, but got I4
		//IL_0298: Expected I, but got Obj
		//IL_02ae: Expected Obj, but got I
		//IL_03c5: Expected Obj, but got I
		//IL_03d3: Expected I, but got Obj
		//IL_03e9: Expected Obj, but got I
		//IL_02e0: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00c8: Expected I, but got Obj
		//IL_00de: Expected Obj, but got I
		//IL_0336: Expected I, but got Obj
		//IL_034c: Expected Obj, but got I
		//IL_03aa: Expected Obj, but got I4
		//IL_03aa: Expected Obj, but got I4
		//IL_03aa: Expected Obj, but got I4
		//IL_0109: Expected I, but got Obj
		//IL_01aa: Expected Obj, but got I
		//IL_01b6: Expected Obj, but got I4
		//IL_0156: Expected I, but got Obj
		object obj = 0;
		nint num = (nint)typeof(BoardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v5 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S1_v30 (Il2CppClass<Data.Managers.BoardManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.CelebrationPopupLabelTemplate)+C8]");
		BoardManager.boardSelected += (Action)0;
		nint num3 = (nint)typeof(HoverboardThemes);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S2_v3 (Il2CppClass<HoverboardThemes>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(HoverboardThemes);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S2_v31 (Il2CppClass<HoverboardThemes>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.CelebrationPopupLabelTemplate)+A8]");
		bool themeId = ((NotificationsObserver)0).DidAppStartFromNotificationAndroid(out *(Notification*)backgroundDepth);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.CelebrationPopupLabelTemplate)+A8]");
		if (BoardManager.IsThemeActive(Boards.BoardId.normal, themeId ? HoverboardThemes.ThemeIdentifier.heroboardTheme01 : HoverboardThemes.ThemeIdentifier.none))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.CelebrationPopupLabelTemplate)+A8]");
			SetupPowerup(UpgradeType._notset, backgroundDepth);
			nint num5 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v20 (Il2CppClass<UIScreenController>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num6 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v39 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = UIScreenController.ShouldShowOnlineScreen();
			Boards.BoardId previousBoardId = PlayerSave.previousBoardId;
			nint num7 = (nint)typeof(HoverboardThemes);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S2_v13 (Il2CppClass<HoverboardThemes>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num8 = (nint)typeof(HoverboardThemes);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S2_v25 (Il2CppClass<HoverboardThemes>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Dictionary<Boards.BoardId, List<HoverboardThemes.HoverboardTheme>> hoverboardCustomThemes = HoverboardThemes.hoverboardCustomThemes;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.CelebrationPopupLabelTemplate)+A8]");
			List<HoverboardThemes.HoverboardTheme> list = hoverboardCustomThemes.get_Item(Boards.BoardId.normal);
			HoverboardThemes.HoverboardTheme hoverboardTheme = list.get_Item(backgroundDepth);
			((UIScreenController)flag).ShowRewardAnimationForBundlePurchase((List<InAppItemModel.BundleItem>)previousBoardId, (string)hoverboardTheme.power);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.CelebrationPopupLabelTemplate)+A8]");
			bool flag2 = ((NotificationsObserver)0).DidAppStartFromNotificationAndroid(out *(Notification*)backgroundDepth);
			obj = flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			throw new NullReferenceException();
		}
		SDebug.LogFormat("Purchased theme and current theme differ.", null);
	}

	public unsafe void SetupPowerup(UpgradeType upgrade, int amount, bool doubled = false)
	{
		//IL_023c: Expected Obj, but got I4
		//IL_024a: Expected I, but got Obj
		//IL_0260: Expected Obj, but got I
		//IL_0359: Expected Obj, but got I4
		//IL_036b: Expected I, but got Obj
		//IL_0381: Expected Obj, but got I
		//IL_028f: Expected Obj, but got I4
		//IL_028f: Expected Obj, but got I4
		//IL_028f: Expected Obj, but got I4
		//IL_029c: Expected Obj, but got I4
		//IL_02a8: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		object obj = 0;
		nint num = (nint)typeof(HoverboardThemes);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<HoverboardThemes>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(HoverboardThemes);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v63 (Il2CppClass<HoverboardThemes>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = ((NotificationsObserver)upgrade).DidAppStartFromNotificationAndroid(out *(Notification*)amount);
		nint num3 = (nint)typeof(BoardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v17 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v59 (Il2CppClass<Data.Managers.BoardManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CloudSave.SetUserDataIfChanged((CloudWorkingCopy)upgrade, (string)flag, (ICloudUserData)1);
		bool flag2 = ((NotificationsObserver)upgrade).DidAppStartFromNotificationAndroid(out *(Notification*)amount);
		obj = flag2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		throw new NullReferenceException();
	}

	public void SetupCoins()
	{
		normalStateGO.tag = null;
		megaJackpotStateGO.tag = null;
		awardStateGO.tag = null;
		topRunStateGO.tag = null;
		characterEventStateGO.tag = null;
		doubleUpEventStateGO.tag = null;
	}

	public void UpdateCoins(int amount, bool isMegaJackpot = false, bool doubled = false)
	{
		//IL_011e: Expected Obj, but got I4
		//IL_0162: Expected I4, but got Obj
		//IL_0032: Expected I4, but got Obj
		//IL_0040: Expected I, but got Obj
		//IL_0056: Expected Obj, but got I
		//IL_0187: Expected I, but got Obj
		//IL_019d: Expected Obj, but got I
		//IL_01db: Expected I4, but got Obj
		//IL_01ec: Expected I4, but got Obj
		//IL_0081: Expected I, but got Obj
		//IL_00ce: Expected I, but got Obj
		normalStateGO.tag = (string)1;
		float nearClipPlane = ((!doubled) ? 0f : 1f);
		((CameraSettings)(object)this).nearClipPlane = nearClipPlane;
		CelebrationReward celebrationReward = ((VideoAdPrize)null).CreateMysteryBox((MysteryBox.Type)amount, isMegaJackpot ? CelebrationRewardOrigin.MysteryBox : CelebrationRewardOrigin.Notset);
		bigLabel.fontSize = (int)celebrationReward;
		((CharacterScrollListSlot)null).SetEnabledState((byte)(int)bigLabel != 0, true);
		nint num = (nint)typeof(Upgrades);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S1_v10 (Il2CppClass<Info.Upgrades>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Upgrades);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S1_v22 (Il2CppClass<Info.Upgrades>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Upgrade upgrade = Upgrades.upgrades.get_Item((UpgradeType)amount);
		nint num3 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S2_v9 (Il2CppClass<Strings>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S2_v16 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault(upgrade.mysteryBoxDescription);
		subLabel.fontSize = (int)text;
		((CharacterScrollListSlot)null).SetEnabledState((byte)(int)subLabel != 0, true);
	}

	public void SetupKeys(int amount, bool doubled = false)
	{
		//IL_004e: Expected Obj, but got I
		_ = 0;
		if (amount != 0)
		{
			Init(doubled ? 1 : 0);
		}
		else
		{
			((BoardSelectButton)this).PurchaseFailure();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.CelebrationPopupLabelTemplate)+A0]");
		TransformExtensions.Reset((Transform)0);
	}

	public void SetupToken(Characters.CharacterId characterId, int amount, int tokensLeft, bool doubled = false)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00bb: Expected Obj, but got I4
		//IL_00bb: Expected Obj, but got I4
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Stream);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.IO.Stream>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Stream);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v15 (Il2CppClass<System.IO.Stream>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		FriendsLoginFBButton friendsLoginFBButton = default;
		friendsLoginFBButton.Init((Action)characterId, (byte)amount != 0, (byte)tokensLeft != 0, isGameOverScreen: true, (Action)doubled);
		object obj2 = this + 20;
		obj2 = friendsLoginFBButton;
	}

	public void SetupTrophy(Trophies.Trophy trophy)
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected Obj, but got Unknown
		//IL_00b6: Expected Obj, but got I
		//IL_00c4: Expected I, but got Obj
		//IL_00da: Expected Obj, but got I
		//IL_01ad: Expected Obj, but got I4
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Expected Obj, but got Unknown
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Expected Obj, but got Unknown
		//IL_01ea: Expected Obj, but got I
		//IL_01f9: Expected Obj, but got I4
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Expected Obj, but got Unknown
		//IL_0105: Expected I, but got Obj
		string text = tag;
		UIPanel component = ((GameObject)(object)text).GetComponent<UIPanel>();
		int sortingOrder = (int)(trophy + 1);
		component.sortingOrder = sortingOrder;
		nint num = (nint)typeof(IPhoneXSupport);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v9 (Il2CppClass<IPhoneXSupport>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(IPhoneXSupport);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v39 (Il2CppClass<IPhoneXSupport>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!IPhoneXSupport.CheckIsiPhoneXDevice())
		{
			return;
		}
		object obj2 = this - -64;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v18+18]");
		object obj4 = 0;
		nint num3 = (nint)typeof(IPhoneXSupport);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v22 (Il2CppClass<IPhoneXSupport>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num4 = (nint)typeof(IPhoneXSupport);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v33 (Il2CppClass<IPhoneXSupport>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj6 = IPhoneXSupport.OFFSET_BOTTOM + IPhoneXSupport.OFFSET_TOP;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v19+10]");
		object obj7 = 0 - obj6;
		object obj8 = this - -64;
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v29+14]");
		object obj10 = 0;
		object obj11 = IPhoneXSupport.OFFSET_BOTTOM + IPhoneXSupport.OFFSET_TOP;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v30+10]");
		object obj12 = 0 - obj11;
	}

	public void SetupMedal()
	{
		//IL_003c: Expected Obj, but got I4
		//IL_0057: Expected I4, but got Obj
		//IL_0016: Expected I4, but got Obj
		//IL_0026: Expected I4, but got Obj
		normalStateGO.tag = (string)1;
		((CameraSettings)(object)this).nearClipPlane = 0f;
		bigLabel.fontSize = (int)"";
		((CharacterScrollListSlot)null).SetEnabledState((byte)(int)bigLabel != 0, true);
		subLabel.fontSize = (int)"";
	}

	public void SetupCharacter(string charName)
	{
		//IL_00c9: Expected Obj, but got I4
		//IL_00de: Expected I4, but got Obj
		//IL_0014: Expected I4, but got Obj
		//IL_0025: Expected I4, but got Obj
		//IL_0038: Expected I, but got Obj
		//IL_004e: Expected Obj, but got I
		//IL_0104: Expected I4, but got Obj
		//IL_0115: Expected I4, but got Obj
		//IL_0079: Expected I, but got Obj
		normalStateGO.tag = (string)1;
		((CameraSettings)(object)this).nearClipPlane = 0f;
		string text = ((CelebrationPopupLabelTemplate)null)._GetCoinsLabel((int)charName);
		bigLabel.fontSize = (int)text;
		((CharacterScrollListSlot)null).SetEnabledState((byte)(int)bigLabel != 0, true);
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v9 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S1_v18 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text2 = Strings.GetDefault("CELEBRATION_POPUP_TROPHY_SUBLABEL_TEXT");
		subLabel.fontSize = (int)text2;
		((CharacterScrollListSlot)null).SetEnabledState((byte)(int)subLabel != 0, false);
	}

	public void SetupSpecialBoard(string boardName)
	{
		//IL_0089: Expected Obj, but got I4
		//IL_00a2: Expected I, but got Obj
		//IL_00b8: Expected Obj, but got I
		//IL_0103: Expected I4, but got Obj
		//IL_0063: Expected I4, but got Obj
		//IL_0073: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		normalStateGO.tag = (string)1;
		((CameraSettings)(object)this).nearClipPlane = 0f;
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v5 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v17 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string format = Strings.GetDefault("CELEBRATION_POPUP_UNLOCK");
		string text = string.Format(format, (object[])(object)boardName);
		bigLabel.fontSize = (int)text;
		((CharacterScrollListSlot)null).SetEnabledState((byte)(int)bigLabel != 0, false);
		subLabel.fontSize = (int)"";
	}

	public void SetupBoardBundle(string boardName, HoverboardThemes.HoverboardTheme theme1, HoverboardThemes.HoverboardTheme theme2)
	{
		//IL_00dd: Expected Obj, but got I4
		//IL_001b: Expected I4, but got Obj
		//IL_00f0: Expected I, but got Obj
		//IL_0106: Expected Obj, but got I
		//IL_0085: Expected Obj, but got I4
		//IL_008f: Expected I4, but got Obj
		//IL_0033: Expected I4, but got Obj
		//IL_0043: Expected I4, but got Obj
		//IL_01bf: Expected I4, but got Obj
		//IL_01c9: Expected I4, but got Obj
		//IL_00a7: Expected I4, but got Obj
		//IL_00b7: Expected I4, but got Obj
		//IL_017f: Expected I4, but got Obj
		//IL_0131: Expected I, but got Obj
		if (theme2 != null)
		{
			megaJackpotStateGO.tag = null;
			string text = ((CelebrationPopupLabelTemplate)null)._GetKeysLabel((int)boardName);
			doubleUpItemLabel.fontSize = (int)text;
			subLabel.fontSize = (int)"";
			return;
		}
		if (theme1 == null)
		{
			normalStateGO.tag = (string)1;
			string text2 = ((CelebrationPopupLabelTemplate)null)._GetKeysLabel((int)boardName);
			bigLabel.fontSize = (int)text2;
			subLabel.fontSize = (int)"";
			return;
		}
		normalStateGO.tag = null;
		megaJackpotStateGO.tag = (string)1;
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S1_v6 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S1_v15 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text3 = Strings.GetDefault("CELEBRATION_LABEL_TEMPLATE_MEGA_JACKPOT");
		jackpotBigLabel.fontSize = (int)text3;
		string text4 = ((CelebrationPopupLabelTemplate)null)._GetKeysLabel((int)boardName);
		jackpotSubLabel.fontSize = (int)text4;
	}

	public void SetupEventSpecialBoard(string boardName)
	{
		//IL_0089: Expected Obj, but got I4
		//IL_00a2: Expected I, but got Obj
		//IL_00b8: Expected Obj, but got I
		//IL_0103: Expected I4, but got Obj
		//IL_0063: Expected I4, but got Obj
		//IL_0073: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		normalStateGO.tag = (string)1;
		((CameraSettings)(object)this).nearClipPlane = 0f;
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v5 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v17 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string format = Strings.GetDefault("CELEBRATION_POPUP_UNLOCK");
		string text = string.Format(format, (object[])(object)boardName);
		bigLabel.fontSize = (int)text;
		((CharacterScrollListSlot)null).SetEnabledState((byte)(int)bigLabel != 0, false);
		subLabel.fontSize = (int)"";
	}

	public void SetupAward(string awardTitle, int rewardAmount, AwardTierType type)
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0176: Expected Obj, but got I
		//IL_0188: Expected I4, but got Obj
		//IL_020f: Expected I4, but got Obj
		//IL_0220: Expected I4, but got Obj
		//IL_00af: Expected I, but got Obj
		//IL_00c5: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_01c7: Expected Obj, but got I
		//IL_01d9: Expected I4, but got Obj
		//IL_00f0: Expected I, but got Obj
		SetupEventSpecialBoard(awardTitle);
		Type type2;
		if (rewardAmount != 0)
		{
			nint num = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S3_v14 (Il2CppClass<Strings>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S3_v20 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [rewardAmount @ L2 (System.Int32)+1C]");
			string text = Strings.GetDefault((string)0);
			string text2 = string.ConcatArray((string[])(object)" + ", (int)text);
			type2 = (Type)(object)text2;
		}
		else
		{
			type2 = (Type)(object)"";
		}
		IFormatProvider provider;
		if (type != AwardTierType.None)
		{
			nint num3 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S4_v5 (Il2CppClass<Strings>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S4_v11 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [type @ L3 (Missions.AwardTierType)+1C]");
			string text3 = Strings.GetDefault((string)0);
			string text4 = string.ConcatArray((string[])(object)" + ", (int)text3);
			provider = (IFormatProvider)(object)text4;
		}
		else
		{
			provider = (IFormatProvider)(object)"";
		}
		object obj3 = ((IConvertible)"\n").ToType(type2, provider);
		subLabel.fontSize = (int)obj3;
		((CharacterScrollListSlot)null).SetEnabledState((byte)(int)subLabel != 0, true);
	}

	public void SetupTopRun(int score, int rank, int weekNumber)
	{
		//IL_02fc: Expected Obj, but got I4
		//IL_0052: Expected I, but got Obj
		//IL_0068: Expected Obj, but got I
		//IL_0093: Expected I, but got Obj
		//IL_00e0: Expected I, but got Obj
		//IL_00f6: Expected Obj, but got I
		//IL_035f: Expected Obj, but got I4
		//IL_0121: Expected I, but got Obj
		//IL_016e: Expected I, but got Obj
		//IL_0184: Expected Obj, but got I
		//IL_0245: Expected I4, but got Obj
		//IL_0253: Expected I, but got Obj
		//IL_0269: Expected Obj, but got I
		//IL_0386: Expected Obj, but got I4
		//IL_01af: Expected I, but got Obj
		//IL_02e2: Expected I4, but got Obj
		//IL_0294: Expected I, but got Obj
		((CameraSettings)(object)this).nearClipPlane = 0f;
		object obj = weekNumber - 1;
		string text;
		object key;
		if (weekNumber != 1)
		{
			if ((nint)obj != 1)
			{
				if ((nint)obj != 2)
				{
					text = "";
					goto IL_0343;
				}
				nint num = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v54 (Il2CppClass<Strings>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num2 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v59 (Il2CppClass<Strings>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				key = "AWARD_CELEBRATION_GOLD";
			}
			else
			{
				nint num3 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v44 (Il2CppClass<Strings>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num4 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v49 (Il2CppClass<Strings>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				key = "AWARD_CELEBRATION_SILVER";
			}
		}
		else
		{
			nint num5 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v34 (Il2CppClass<Strings>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num6 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v39 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			key = "AWARD_CELEBRATION_BRONZE";
		}
		string text2 = Strings.GetDefault((string)key);
		text = text2;
		goto IL_0343;
		IL_0343:
		normalStateGO.tag = null;
		awardStateGO.tag = (string)1;
		topRunStateGO.tag = null;
		doubleUpEventStateGO.tag = null;
		awardTopDescriptionLabel.fontSize = score;
		awardBigLabel.fontSize = (int)text;
		nint num7 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S1_v13 (Il2CppClass<Strings>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num8 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S1_v21 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string format = Strings.GetDefault("CELEBRATION_POPUP_AWARD_KEYS");
		object obj6 = rank;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		object[] args = default;
		string text3 = string.Format(format, args);
		awardBottomDescriptionLabel.fontSize = (int)text3;
	}

	public void SetupDoubleUp(CelebrationReward reward)
	{
		//IL_0089: Expected Obj, but got I4
		//IL_00a2: Expected I, but got Obj
		//IL_00b8: Expected Obj, but got I
		//IL_0103: Expected I4, but got Obj
		//IL_0063: Expected I4, but got Obj
		//IL_0073: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		normalStateGO.tag = (string)1;
		((CameraSettings)(object)this).nearClipPlane = 0f;
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v5 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v17 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string format = Strings.GetDefault("CELEBRATION_POPUP_EVENT_BOARD_TRYOUT");
		string text = string.Format(format, (object[])(object)reward);
		bigLabel.fontSize = (int)text;
		((CharacterScrollListSlot)null).SetEnabledState((byte)(int)bigLabel != 0, false);
		subLabel.fontSize = (int)"";
	}

	public void SetupCharacterWordEvent(int wordNumber, string word)
	{
		//IL_0058: Expected Obj, but got I4
		//IL_009c: Expected I4, but got Obj
		//IL_0032: Expected I4, but got Obj
		//IL_0042: Expected I4, but got Obj
		normalStateGO.tag = (string)1;
		float nearClipPlane = ((word == null) ? 0f : 1f);
		((CameraSettings)(object)this).nearClipPlane = nearClipPlane;
		List<VideoAdPrize> shuffledCloneOfRandomPrizePool = ((VideoAdPrizePools)null).GetShuffledCloneOfRandomPrizePool(wordNumber);
		bigLabel.fontSize = (int)shuffledCloneOfRandomPrizePool;
		((CharacterScrollListSlot)null).SetEnabledState((byte)(int)bigLabel != 0, true);
		subLabel.fontSize = (int)"";
	}

	private string GetEventLabelPrefix()
	{
		//IL_013d: Expected I, but got Obj
		//IL_0153: Expected Obj, but got I
		//IL_01fc: Expected Obj, but got I4
		//IL_0062: Expected I, but got Obj
		//IL_0078: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0187: Expected I, but got Obj
		//IL_019d: Expected Obj, but got I
		//IL_01ea: Expected Obj, but got I4
		//IL_00a3: Expected I, but got Obj
		//IL_00f0: Expected I, but got Obj
		nint num = (nint)typeof(BoardBundlePopupManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Screens.BoardBundlePopupManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(BoardBundlePopupManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v29 (Il2CppClass<UI.Screens.BoardBundlePopupManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int pageIndex = ChallengesScreen.GetPageIndex();
		if (!((BoardBundlePopupManager)pageIndex).ShouldButtonBeVisible())
		{
			return null;
		}
		nint num3 = (nint)typeof(BoardBundlePopupManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15 (Il2CppClass<UI.Screens.BoardBundlePopupManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(BoardBundlePopupManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v23 (Il2CppClass<UI.Screens.BoardBundlePopupManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int pageIndex2 = ChallengesScreen.GetPageIndex();
		nint num5 = (nint)typeof(BoardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S2_v2 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S2_v7 (Il2CppClass<Data.Managers.BoardManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.CelebrationPopupLabelTemplate)+C8]");
		int currentlyShownHoverboardTheme = BoardManager.GetCurrentlyShownHoverboardTheme(BoardManager.ScreenContext.BoardScreen);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v20 (System.Int32)+1C]");
		bool flag = (nint)0 == currentlyShownHoverboardTheme;
		return (string)flag;
	}

	private string _GetPowerupLabel(UpgradeType type, int amount)
	{
		//IL_00ec: Expected I, but got Obj
		//IL_0102: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_01b2: Expected Obj, but got I4
		//IL_012d: Expected I, but got Obj
		//IL_00d9: Expected Obj, but got I4
		//IL_0054: Expected I, but got Obj
		string result;
		if (amount < 0)
		{
			nint num = (nint)typeof(Boards);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v32 (Il2CppClass<Info.Boards>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Boards);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v47 (Il2CppClass<Info.Boards>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Boards.Board board = Boards.boardData.get_Item((Boards.BoardId)type);
			if (board.unlockType != PurchaseData.UnlockType.Coins)
			{
				bool flag = board.unlockType != PurchaseData.UnlockType.Keys;
				result = null;
				if (flag)
				{
					goto IL_0221;
				}
			}
			bool flag2 = board.price == 0;
			result = (string)flag2;
		}
		else
		{
			nint num3 = (nint)typeof(HoverboardThemes);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v9 (Il2CppClass<HoverboardThemes>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(HoverboardThemes);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v25 (Il2CppClass<HoverboardThemes>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			List<HoverboardThemes.HoverboardTheme> list = HoverboardThemes.hoverboardCustomThemes.get_Item((Boards.BoardId)type);
			HoverboardThemes.HoverboardTheme hoverboardTheme = list.get_Item(amount);
			if (hoverboardTheme.unlockType != PurchaseData.UnlockType.Coins)
			{
				bool flag3 = hoverboardTheme.unlockType != PurchaseData.UnlockType.Keys;
				result = null;
				if (flag3)
				{
					goto IL_0221;
				}
			}
			bool flag4 = hoverboardTheme.price == 0;
			result = (string)flag4;
		}
		goto IL_0221;
		IL_0221:
		return result;
	}

	private string _GetTrophyLabel(Trophies.Trophy trophy)
	{
		//IL_01b7: Expected Obj, but got I
		//IL_0032: Expected Obj, but got I
		//IL_0042: Expected Obj, but got I
		//IL_0102: Expected Obj, but got I
		//IL_0112: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.CelebrationPopupLabelTemplate)+C4]");
		object result;
		if ((nint)0 == 4)
		{
			if (trophy != Trophies.Trophy.diamond)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.CelebrationPopupLabelTemplate)+D0]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v28+C]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v29+8]");
				result = (((nint)0 != 4) ? "icon_award_collect_bg" : "icon_diamond_award_collect_bg");
			}
			else
			{
				result = "icon_award_collect_bg_small";
			}
		}
		else
		{
			result = ((trophy == Trophies.Trophy.diamond) ? "icon_award_bg_completed_small" : "icon_award_bg_completed");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.CelebrationPopupLabelTemplate)+C4]");
			object obj3 = -5;
			if ((nint)obj3 > 1)
			{
				if (trophy != Trophies.Trophy.diamond)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.CelebrationPopupLabelTemplate)+D0]");
					object obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v15+C]");
					object obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v16+8]");
					result = (((nint)0 != 4) ? "icon_award_bg" : "icon_diamond_award_bg");
				}
				else
				{
					result = "icon_award_bg_small";
				}
			}
		}
		return (string)result;
	}

	private string _GetCoinsLabel(int amount)
	{
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_0117: Expected I, but got Obj
		//IL_012d: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		nint num = (nint)typeof(Trophies);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.Trophies>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Trophies);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v16 (Il2CppClass<Info.Trophies>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		TrophyData trophyData = Trophies.TROPHY_DATA.get_Item((Trophies.Trophy)amount);
		nint num3 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v5 (Il2CppClass<Strings>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S1_v10 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return Strings.GetDefault(trophyData.name);
	}

	private string _GetKeysLabel(int amount)
	{
		//IL_0076: Expected I, but got Obj
		//IL_008c: Expected Obj, but got I
		//IL_00bf: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v17 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string format = Strings.GetDefault("CELEBRATION_POPUP_COINS_AMOUNT");
		object obj2 = amount;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		object[] args2 = default;
		string args = $"{args2:#,###0}";
		return string.Format(format, (object[])(object)args);
	}

	private void SetMaxLineCountNicely(UILabel label, int maxLineCount)
	{
		//IL_0413: Unknown result type (might be due to invalid IL or missing references)
		//IL_0418: Expected Obj, but got Unknown
		//IL_0421: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I4
		//IL_0023: Expected I, but got Obj
		//IL_0039: Expected Obj, but got I
		//IL_0452: Unknown result type (might be due to invalid IL or missing references)
		//IL_0457: Expected Obj, but got Unknown
		//IL_0460: Expected Obj, but got VT
		//IL_0469: Unknown result type (might be due to invalid IL or missing references)
		//IL_046e: Expected Obj, but got Unknown
		//IL_047f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0484: Expected Obj, but got Unknown
		//IL_049f: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a4: Expected Obj, but got Unknown
		//IL_04ad: Expected Obj, but got VT
		//IL_04b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bb: Expected Obj, but got Unknown
		//IL_04de: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e3: Expected Obj, but got Unknown
		//IL_04ec: Expected Obj, but got VT
		//IL_04f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fa: Expected Obj, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected Obj, but got Unknown
		//IL_00ba: Expected Obj, but got VT
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected Obj, but got Unknown
		//IL_0064: Expected I, but got Obj
		//IL_00ff: Expected I, but got Obj
		//IL_0115: Expected Obj, but got I
		//IL_0140: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 40;
		obj = 0;
		((CameraSettings)(object)this).nearClipPlane = 0f;
		normalStateGO.tag = null;
		doubleUpEventStateGO.tag = null;
		characterEventStateGO.tag = (string)1;
		nint num = (nint)typeof(GlobalColors);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18 (Il2CppClass<GlobalColors>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(GlobalColors);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v93 (Il2CppClass<GlobalColors>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = obj2 + 28;
		obj4 = GlobalColors.CHARACTERWORDEVENT_CELEBRATION_BLUE;
		object obj5 = obj2 + 32;
		obj5 = obj4;
		object obj6 = obj2 + 36;
		obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A567");
		object obj7 = obj2 + 20;
		obj7 = GlobalColors.CHARACTERWORDEVENT_CELEBRATION_WHITE;
		object obj8 = obj2 + 24;
		obj8 = obj7;
		obj6 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A567");
		object obj9 = obj2 + 12;
		obj9 = GlobalColors.CHARACTERWORDEVENT_CELEBRATION_BLUESHADOW;
		object obj10 = obj2 + 16;
		obj10 = obj9;
		obj6 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A567");
		object obj11 = obj2 + 8;
		obj11 = GlobalColors.CHARACTERWORDEVENT_CELEBRATION_WHITESHADOW;
		object obj12 = obj2 + 4;
		obj12 = obj11;
		obj6 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A567");
		bool modelReady = ((CharacterScrollListSlot)null).modelReady;
		nint num3 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S0_v54 (Il2CppClass<Strings>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num4 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S0_v89 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault("CELEBRATION_LABEL_TEMPLATE_CHARACTEREVENT_COMPLETED");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		throw new ArrayTypeMismatchException();
	}

	public CelebrationPopupLabelTemplate()
	{
		//IL_0073: Expected Obj, but got I4
		//IL_008c: Expected I, but got Obj
		//IL_00a2: Expected Obj, but got I
		//IL_00dc: Expected I4, but got Obj
		//IL_00ed: Expected I4, but got Obj
		//IL_0062: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		normalStateGO.tag = (string)1;
		((CameraSettings)(object)this).nearClipPlane = 0f;
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v5 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v16 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault("CELEBRATION_POPUP_MEDAL_BIG_LABEL");
		bigLabel.fontSize = (int)text;
		((CharacterScrollListSlot)null).SetEnabledState((byte)(int)bigLabel != 0, true);
		subLabel.fontSize = (int)"";
	}
}
