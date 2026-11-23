using UnityEngine;

public class PrizeMMBPopup : MonoBehaviour
{
	private UILabel titleLabel;

	private UILabel subtitleLabel;

	private UILabel rareLabel;

	private UILabel upToKeyLabel;

	private UILabel keyLabel;

	private UILabel scoreLabel;

	private UILabel boosterLabel;

	private UILabel commonLabel;

	private UILabel upToBoardsLabel;

	private UILabel boardsLabel;

	private UILabel upToCoinsLabel;

	private UILabel coinsLabel;

	private void Awake()
	{
		string text = Strings.Get(StringID.PRIZE_MMB_POPUP_TITLE);
		titleLabel.text = text;
		string text2 = Strings.Get(StringID.PRIZE_MMB_POPUP_SUBTITLE);
		subtitleLabel.text = text2;
		string text3 = Strings.Get(StringID.PRIZE_MMB_POPUP_RARE);
		rareLabel.text = text3;
		string text4 = Strings.Get(StringID.PRIZE_MMB_POPUP_UP_TO_KEYS);
		upToKeyLabel.text = text4;
		string text5 = Strings.Get(StringID.PRIZE_MMB_POPUP_KEY);
		keyLabel.text = text5;
		string text6 = Strings.Get(StringID.PRIZE_MMB_POPUP_SCORE);
		scoreLabel.text = text6;
		string text7 = Strings.Get(StringID.PRIZE_MMB_POPUP_BOOSTER);
		boosterLabel.text = text7;
		string text8 = Strings.Get(StringID.PRIZE_MMB_POPUP_COMMON);
		commonLabel.text = text8;
		string text9 = Strings.Get(StringID.PRIZE_MMB_POPUP_UP_TO_BOARDS);
		upToBoardsLabel.text = text9;
		string text10 = Strings.Get(StringID.PRIZE_MMB_POPUP_BOARDS);
		boardsLabel.text = text10;
		string text11 = Strings.Get(StringID.PRIZE_MMB_POPUP_UP_TO_COINS);
		upToCoinsLabel.text = text11;
		string text12 = Strings.Get(StringID.PRIZE_MMB_POPUP_COINS);
		coinsLabel.text = text12;
	}
}
