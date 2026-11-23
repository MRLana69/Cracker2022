using UnityEngine;

public class ShopFooter : MonoBehaviour
{
	private UILabel menuButtonLabel;

	private UILabel boostsButtonLabel;

	private UILabel boostsCoolDealLabel;

	private UILabel boostsCoolDealSingleLineLabel;

	private UILabel earnCoinsButtonLabel;

	private UILabel storeButtonLabel;

	private UILabel storeCoolDealLabel;

	private UILabel storeCoolDealSingleLineLabel;

	private void Awake()
	{
		string text = Strings.Get(StringID.SHOP_FOOTER_MENU);
		menuButtonLabel.text = text;
		string text2 = Strings.Get(StringID.SHOP_FOOTER_BOOSTS);
		boostsButtonLabel.text = text2;
		string text3 = Strings.Get(StringID.SHOP_FOOTER_COOL_DEAL_SINGLE_LINE);
		boostsCoolDealSingleLineLabel.text = text3;
		string text4 = Strings.Get(StringID.SHOP_FOOTER_EARN_COINS);
		earnCoinsButtonLabel.text = text4;
		string text5 = Strings.Get(StringID.SHOP_FOOTER_STORE);
		storeButtonLabel.text = text5;
		string text6 = Strings.Get(StringID.SHOP_FOOTER_COOL_DEAL_SINGLE_LINE);
		storeCoolDealSingleLineLabel.text = text6;
	}
}
