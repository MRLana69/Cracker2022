using System;
using Cpp2ILInjected;
using UnityEngine;

public class PrizeSMBPopup : MonoBehaviour
{
	private UILabel titleLabel;

	private UILabel subtitleLabel;

	private UILabel superLabel;

	private UILabel superShadowLabel;

	private UILabel jackpotLabel;

	private UILabel jackpotShadowLabel;

	private UILabel coinsTitleLabel;

	private UILabel coinsTitleShadowLabel;

	private UILabel newSuperTitleLabel;

	private UILabel newSuperTitleShadowLabel;

	private UILabel newJackpotTitleLabel;

	private UILabel newJackpotTitleShadowLabel;

	private UILabel oldJackpotLabel;

	private UILabel oldJackpotShadowLabel;

	private UILabel newJackpotLabel;

	private UILabel newJackpotShadowLabel;

	private UILabel rareLabel;

	private UILabel keyLabel;

	private UILabel scoreLabel;

	private UILabel boosterLabel;

	private UILabel trophies;

	private UILabel amountOfCoinsLabel;

	private UILabel coinsAmountLabel;

	private UILabel specialLabel;

	private UILabel headstartsLabel;

	private UILabel upTo20BoardsLabel;

	private UILabel boardsUpTo20BoardsLabel;

	private UILabel upToCoinsLabel;

	private UILabel coinsLabel;

	private UILabel commonLabel;

	private GameObject defaultJackpotElements;

	private GameObject megaJackpotElements;

	private void Awake()
	{
		string text = Strings.Get(StringID.PRIZE_SMB_POPUP_TITLE);
		titleLabel.text = text;
		string text2 = Strings.Get(StringID.PRIZE_SMB_POPUP_SUBTITLE);
		subtitleLabel.text = text2;
		string text3 = Strings.Get(StringID.PRIZE_MB_POPUP_COINS_TITLE);
		coinsTitleLabel.text = text3;
		string text4 = Strings.Get(StringID.PRIZE_MB_POPUP_COINS_TITLE);
		coinsTitleShadowLabel.text = text4;
		string text5 = Strings.Get(StringID.PRIZE_SMB_RARE);
		rareLabel.text = text5;
		if (keyLabel != null)
		{
			string text6 = Strings.Get(StringID.PRIZE_SMB_KEYS);
			keyLabel.text = text6;
		}
		string text7 = Strings.Get(StringID.PRIZE_SMB_SCORE);
		scoreLabel.text = text7;
		string text8 = Strings.Get(StringID.PRIZE_SMB_BOOSTER);
		boosterLabel.text = text8;
		string text9 = Strings.Get(StringID.PRIZE_MB_POPUP_TROPHIES);
		trophies.text = text9;
		string text10 = Strings.Get(StringID.PRIZE_SMB_AMOUNT_OF_COINS);
		amountOfCoinsLabel.text = text10;
		string text11 = Strings.Get(StringID.PRIZE_SMB_COINS);
		coinsAmountLabel.text = text11;
		string text12 = Strings.Get(StringID.PRIZE_SMB_SPECIAL);
		specialLabel.text = text12;
		string text13 = Strings.Get(StringID.PRIZE_SMB_HEADSTARTS);
		headstartsLabel.text = text13;
		string text14 = Strings.Get(StringID.PRIZE_SMB_UP_TO_20_BOARDS);
		upTo20BoardsLabel.text = text14;
		string text15 = Strings.Get(StringID.PRIZE_SMB_UP_TO_COINS);
		upToCoinsLabel.text = text15;
		string text16 = Strings.Get(StringID.PRIZE_SMB_COINS);
		coinsLabel.text = text16;
		string text17 = Strings.Get(StringID.PRIZE_SMB_COMMON);
		commonLabel.text = text17;
	}

	private unsafe void OnEnable()
	{
		Action action = default;
		action._002Ector(this, (nint)__ldftn(PrizeSMBPopup.SetJackpotLabels));
		SSEventsManagerController.OnSSEventStartedHandler += action;
		Action action2 = default;
		action2._002Ector(this, (nint)__ldftn(PrizeSMBPopup.SetJackpotLabels));
		SSEventsManagerController.OnSSEventFinishedHandler += action2;
		Action action3 = default;
		action3._002Ector(this, (nint)__ldftn(PrizeSMBPopup.SetJackpotLabels));
		UIScreenController.OnApplicationResumed += action3;
		SetJackpotLabels();
	}

	private unsafe void OnDisable()
	{
		Action action = default;
		action._002Ector(this, (nint)__ldftn(PrizeSMBPopup.SetJackpotLabels));
		SSEventsManagerController.OnSSEventStartedHandler -= action;
		Action action2 = default;
		action2._002Ector(this, (nint)__ldftn(PrizeSMBPopup.SetJackpotLabels));
		SSEventsManagerController.OnSSEventFinishedHandler -= action2;
		Action action3 = default;
		action3._002Ector(this, (nint)__ldftn(PrizeSMBPopup.SetJackpotLabels));
		UIScreenController.OnApplicationResumed -= action3;
	}

	private void SetJackpotLabels()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Expected Obj, but got Unknown
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected Obj, but got Unknown
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		SSEventsManagerController instance = SSEventsManagerController.instance;
		IEventManager activeEventManager = instance.GetActiveEventManager();
		if (activeEventManager != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			object obj3 = default;
			if ((nint)obj3 == 4)
			{
				defaultJackpotElements.SetActive(value: false);
				megaJackpotElements.SetActive(value: true);
				string text = Strings.Get(StringID.PRIZE_MB_POPUP_JACKPOT);
				newJackpotTitleLabel.text = text;
				string text2 = Strings.Get(StringID.PRIZE_MB_POPUP_JACKPOT);
				newJackpotTitleShadowLabel.text = text2;
				string text3 = Strings.Get(StringID.PRIZE_SMB_SUPER);
				newSuperTitleLabel.text = text3;
				string text4 = Strings.Get(StringID.PRIZE_SMB_SUPER);
				newSuperTitleShadowLabel.text = text4;
				string format = Strings.Get(StringID.PRIZE_MB_POPUP_COINS_TITLE);
				_ = MysteryBox.superMysteryBoxJackpotAmount;
				object obj4 = obj + 12;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
				object arg2 = default;
				string arg = $"{arg2:#,###0}";
				string text5 = string.Format(format, arg);
				string format2 = Strings.Get(StringID.PRIZE_MB_POPUP_COINS_TITLE);
				int megaJackpotAmount = MysteryBox.GetMegaJackpotAmount(MysteryBox.Type.Super);
				object obj5 = obj + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
				object arg4 = default;
				string arg3 = $"{arg4:#,###0}";
				string text6 = string.Format(format2, arg3);
				oldJackpotLabel.text = text5;
				oldJackpotShadowLabel.text = text5;
				newJackpotLabel.text = text6;
				newJackpotShadowLabel.text = text6;
				return;
			}
		}
		defaultJackpotElements.SetActive(value: true);
		megaJackpotElements.SetActive(value: false);
		string format3 = Strings.Get(StringID.PRIZE_MB_POPUP_COINS_TITLE);
		_ = MysteryBox.superMysteryBoxJackpotAmount;
		object obj6 = obj + 4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		object arg6 = default;
		string arg5 = $"{arg6:#,###0}";
		string text7 = string.Format(format3, arg5);
		coinsTitleLabel.text = text7;
		coinsTitleShadowLabel.text = text7;
		string text8 = Strings.Get(StringID.PRIZE_MB_POPUP_JACKPOT);
		jackpotLabel.text = text8;
		string text9 = Strings.Get(StringID.PRIZE_MB_POPUP_JACKPOT);
		jackpotShadowLabel.text = text9;
		string text10 = Strings.Get(StringID.PRIZE_SMB_SUPER);
		superLabel.text = text10;
		string text11 = Strings.Get(StringID.PRIZE_SMB_SUPER);
		superShadowLabel.text = text11;
	}
}
