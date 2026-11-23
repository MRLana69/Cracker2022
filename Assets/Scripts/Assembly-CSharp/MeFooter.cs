using UnityEngine;

public class MeFooter : MonoBehaviour
{
	private UILabel menuLabel;

	private UILabel charactersLabel;

	private UILabel boarsLabel;

	private UILabel awardsLabel;

	private UILabel boardsGiftTopLabel;

	private UILabel boardsGiftBottomLabel;

	private void Awake()
	{
		string text = Strings.Get(StringID.ME_FOOTER_MENU);
		menuLabel.text = text;
		string text2 = Strings.Get(StringID.ME_FOOTER_CHARACTERS);
		charactersLabel.text = text2;
		string text3 = Strings.Get(StringID.ME_FOOTER_BOARDS);
		boarsLabel.text = text3;
		string text4 = Strings.Get(StringID.ME_FOOTER_AWARDS);
		awardsLabel.text = text4;
		string text5 = Strings.Get(StringID.ME_FOOTER_BOARDS_GIFT_TOP);
		boardsGiftTopLabel.text = text5;
		string text6 = Strings.Get(StringID.ME_FOOTER_BOARDS_GIFT_BOTTOM);
		boardsGiftBottomLabel.text = text6;
	}
}
