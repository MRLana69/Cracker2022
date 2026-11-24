using System;
using Cpp2ILInjected;
using Kiloo.Common.Extensions;
using SYBO.Subway.Info;
using UI.FreeStuff;
using UI.Generic.Layout;
using UI.Screens;
using UnityEngine;

namespace UI.Popups;

public class PrizeMBPopup : UIScreen
{
	private UILabel _titleLabel;

	private UILabel _subtitleLabel;

	private Layout _subtitleLayout;

	private UILabel _rareLabel;

	private UILabel _keyLabel;

	private UILabel _scoreBoosterLabel;

	private UILabel _trophiesLabel;

	private UILabel _amountOfCoinsLabel;

	private UILabel _specialLabel;

	private UILabel _headstartsLabel;

	private UILabel _upToBoardsLabel;

	private UILabel _upToCoinsLabel;

	private UILabel _commonLabel;

	private GameObject _defaultJackpotElements;

	private GameObject _megaJackpotElements;

	private UILabel _jackpotLabel;

	private UILabel _coinsTitleLabel;

	private Layout _defaultJackpotLayout;

	private UILabel _newJackpotTitleLabel;

	private UILabel _oldJackpotLabel;

	private UILabel _newJackpotLabel;

	private Layout _megaJackpotLayout;

	private UISprite _lineThrough;

	private UISprite _lineThroughShadow;

	private const int LINETHROUGH_WIDTH_PADDING = 4;

	private const float LINETHROUGH_Y_OFFSET = -1f;

	public override void Init()
	{
		((UpgradeScreen)this).Start();
	}

	public override void Show()
	{
		//IL_0270: Expected I, but got Obj
		//IL_0286: Expected Obj, but got I
		//IL_02c0: Expected I4, but got Obj
		//IL_0061: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_008f: Expected I4, but got Obj
		//IL_00d1: Expected I4, but got Obj
		//IL_00f3: Expected I4, but got Obj
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected Obj, but got Unknown
		//IL_011e: Expected I4, but got Obj
		//IL_013b: Expected Obj, but got I4
		//IL_0151: Expected Obj, but got I4
		//IL_0164: Expected I4, but got Obj
		//IL_0186: Expected I4, but got Obj
		//IL_01a8: Expected I4, but got Obj
		//IL_01c5: Expected Obj, but got I4
		//IL_01db: Expected Obj, but got I4
		//IL_01ee: Expected I4, but got Obj
		//IL_020b: Expected Obj, but got I4
		//IL_0221: Expected Obj, but got I4
		//IL_0234: Expected I4, but got Obj
		//IL_0256: Expected I4, but got Obj
		ShowIfInactive();
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S1_v4 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v50 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault("PRIZE_POPUP_TITLE");
		_titleLabel.fontSize = (int)text;
		string text2 = Strings.GetDefault("PRIZE_POPUP_SUBTITLE_MB");
		_subtitleLabel.fontSize = (int)text2;
		((RewardForVideoButton)(object)_subtitleLayout).Init((VideoButtonPayload)null);
		string text3 = Strings.GetDefault("PRIZE_POPUP_CATEGORY_RARE");
		_rareLabel.fontSize = (int)text3;
		string text4 = Strings.GetDefault("PRIZE_POPUP_REWARD_KEY_SINGULAR");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A40");
		object obj2 = default;
		string text5 = text4 + obj2;
		_keyLabel.fontSize = (int)text5;
		string text6 = Strings.GetDefault("PRIZE_POPUP_REWARD_SCORE_BOOSTER_PLURAL");
		_scoreBoosterLabel.fontSize = (int)text6;
		object obj3 = this - -64;
		string text7 = Strings.GetDefault("PRIZE_POPUP_REWARD_TROPHIES");
		((UILabel)obj3).fontSize = (int)text7;
		string format = Strings.GetDefault("PRIZE_POPUP_REWARD_COINS");
		int autoRunLength = ((FPSLog)5000).autoRunLength;
		string text8 = string.Format(format, (object[])autoRunLength);
		_amountOfCoinsLabel.fontSize = (int)text8;
		string text9 = Strings.GetDefault("PRIZE_POPUP_CATEGORY_SPECIAL");
		_specialLabel.fontSize = (int)text9;
		string text10 = Strings.GetDefault("PRIZE_POPUP_REWARD_HEADSTARTS");
		_headstartsLabel.fontSize = (int)text10;
		string format2 = Strings.GetDefault("PRIZE_POPUP_REWARD_UP_TO_BOARDS");
		int autoRunLength2 = ((FPSLog)10).autoRunLength;
		string text11 = string.Format(format2, (object[])autoRunLength2);
		_upToBoardsLabel.fontSize = (int)text11;
		string format3 = Strings.GetDefault("PRIZE_POPUP_REWARD_UP_TO_COINS");
		int autoRunLength3 = ((FPSLog)2500).autoRunLength;
		string text12 = string.Format(format3, (object[])autoRunLength3);
		_upToCoinsLabel.fontSize = (int)text12;
		string text13 = Strings.GetDefault("PRIZE_POPUP_CATEGORY_COMMON");
		_commonLabel.fontSize = (int)text13;
	}

	public unsafe override void Hide()
	{
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected Obj, but got Unknown
		//IL_0172: Expected I, but got Obj
		//IL_0188: Expected Obj, but got I
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected Obj, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected Obj, but got Unknown
		//IL_009f: Expected I, but got Obj
		//IL_00b5: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00e0: Expected I, but got Obj
		base.Hide();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(PrizeMBPopup.SetJackpotLabels);
		object obj = action + 16;
		obj = this;
		nint num = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v13 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v42 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SSEventsManagerController.OnSSEventStartedHandler -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Action action2 = default;
		((Delegate)action2).method_ptr = method_ptr2;
		((Delegate)action2).method = (nint)__ldftn(PrizeMBPopup.SetJackpotLabels);
		object obj3 = action2 + 16;
		obj3 = this;
		SSEventsManagerController.OnSSEventFinishedHandler -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr3 = 0;
		Action action3 = default;
		((Delegate)action3).method_ptr = method_ptr3;
		((Delegate)action3).method = (nint)__ldftn(PrizeMBPopup.SetJackpotLabels);
		object obj4 = action3 + 16;
		obj4 = this;
		nint num3 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v32 (Il2CppClass<UIScreenController>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num4 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v38 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController.OnApplicationResumed -= action3;
		this._002Ector();
	}

	private unsafe void SetJackpotLabels()
	{
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected Obj, but got Unknown
		//IL_015e: Expected I, but got Obj
		//IL_0174: Expected Obj, but got I
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected Obj, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_008b: Expected I, but got Obj
		//IL_00a1: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00cc: Expected I, but got Obj
		base.LoseFocus();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(PrizeMBPopup.SetJackpotLabels);
		object obj = action + 16;
		obj = this;
		nint num = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v13 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v41 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SSEventsManagerController.OnSSEventFinishedHandler += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Action action2 = default;
		((Delegate)action2).method_ptr = method_ptr2;
		((Delegate)action2).method = (nint)__ldftn(PrizeMBPopup.SetJackpotLabels);
		object obj3 = action2 + 16;
		obj3 = this;
		SSEventsManagerController.OnSSEventChangedHandler += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		_ = 0;
		Action<string> action3 = default;
		object obj4 = action3 + 16;
		obj4 = this;
		nint num4 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v32 (Il2CppClass<UIScreenController>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num5 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v37 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController.OnPopupShown += action3;
	}

	public PrizeMBPopup()
	{
		//IL_0415: Expected I, but got Obj
		//IL_042b: Expected Obj, but got I
		//IL_04e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e9: Expected Obj, but got Unknown
		//IL_04f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f7: Expected Obj, but got Unknown
		//IL_0325: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0344: Expected I, but got Obj
		//IL_035a: Expected Obj, but got I
		//IL_04c1: Expected Obj, but got I4
		//IL_04d2: Expected Obj, but got I4
		//IL_03d3: Expected I4, but got Obj
		//IL_0385: Expected I, but got Obj
		//IL_0098: Expected Obj, but got I4
		//IL_03f5: Expected I4, but got Obj
		//IL_00ab: Expected I, but got Obj
		//IL_00c1: Expected Obj, but got I
		//IL_0465: Expected I4, but got Obj
		//IL_0135: Expected Obj, but got I4
		//IL_0146: Expected Obj, but got I4
		//IL_00ec: Expected I, but got Obj
		//IL_016b: Expected I, but got Obj
		//IL_0181: Expected Obj, but got I
		//IL_04a0: Expected Obj, but got I4
		//IL_01fa: Expected I4, but got Obj
		//IL_0209: Expected I4, but got Obj
		//IL_01ac: Expected I, but got Obj
		//IL_0237: Expected F4, but got Obj
		//IL_029c: Expected VT, but got Obj
		//IL_02b6: Expected F4, but got I
		//IL_02e6: Expected VT, but got Obj
		nint num = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v85 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Transform transform = default;
		object obj2 = transform + 24;
		Transform transform2 = (Transform)(transform + 12);
		string flurryUserId = Flurry.flurryUserId;
		if (((SSEventsManagerController)(object)flurryUserId).DoesCharacterMatchCurrentEvent(Characters.CharacterId.slick))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			object obj3 = default;
			if ((nint)obj3 == 4)
			{
				_defaultJackpotElements.tag = null;
				_megaJackpotElements.tag = (string)1;
				nint num3 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S1_v26 (Il2CppClass<Strings>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num4 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S1_v67 (Il2CppClass<Strings>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string text = Strings.GetDefault("PRIZE_POPUP_CATEGORY_JACKPOT");
				_newJackpotTitleLabel.fontSize = (int)text;
				string format = Strings.GetDefault("PRIZE_POPUP_REWARD_JACKPOT_COINS");
				int autoRunLength = ((FPSLog)100000).autoRunLength;
				string text2 = string.Format(format, (object[])autoRunLength);
				string format2 = Strings.GetDefault("PRIZE_POPUP_REWARD_JACKPOT_COINS");
				nint num5 = (nint)typeof(MysteryBox);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ S1_v38 (Il2CppClass<MysteryBox>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num6 = (nint)typeof(MysteryBox);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S1_v63 (Il2CppClass<MysteryBox>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				MysteryBox.LootTableEntry lootTableEntry = MysteryBox.MakeRoll(MysteryBox.Type.Normal);
				int autoRunLength2 = ((FPSLog)(object)lootTableEntry).autoRunLength;
				string text3 = string.Format(format2, (object[])autoRunLength2);
				_oldJackpotLabel.fontSize = (int)text2;
				_newJackpotLabel.fontSize = (int)text3;
				((RewardForVideoButton)(object)_megaJackpotLayout).Init((VideoButtonPayload)null);
				Vector2 localSize = _oldJackpotLabel.localSize;
				int num7 = NumberExtensions.FloorToInt((float)obj2);
				int height = num7 + 4;
				_lineThrough.height = height;
				_lineThroughShadow.height = height;
				GameObject gameObject = _lineThrough.gameObject;
				GameObject gameObject2 = _oldJackpotLabel.gameObject;
				transform2.localPosition = (Vector3)gameObject2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v16 (UnityEngine.Transform)+4]");
				TransformExtensions.SetLocalPosZ((Transform)(object)gameObject, 0f);
				GameObject gameObject3 = _lineThroughShadow.gameObject;
				GameObject gameObject4 = _oldJackpotLabel.gameObject;
				transform.localPosition = (Vector3)gameObject4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (UnityEngine.Transform)+4]");
				float posZ = 0f + -1f;
				TransformExtensions.SetLocalPosZ((Transform)(object)gameObject3, posZ);
				return;
			}
		}
		_defaultJackpotElements.tag = (string)1;
		_megaJackpotElements.tag = null;
		nint num8 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v29 (Il2CppClass<Strings>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num9 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v43 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string format3 = Strings.GetDefault("PRIZE_POPUP_REWARD_JACKPOT_COINS");
		int autoRunLength3 = ((FPSLog)100000).autoRunLength;
		string text4 = string.Format(format3, (object[])autoRunLength3);
		_coinsTitleLabel.fontSize = (int)text4;
		string text5 = Strings.GetDefault("PRIZE_POPUP_CATEGORY_JACKPOT");
		_jackpotLabel.fontSize = (int)text5;
		((RewardForVideoButton)(object)_defaultJackpotLayout).Init((VideoButtonPayload)null);
	}
}
