//Type is in global namespace

public class TopRunPopup : UIScreen
{
	private struct MedalCategory
	{
		public UILabel title; //Field offset: 0x0
		public UISprite background; //Field offset: 0x4

	}

	public const int NEWEST_TOPRUN_POPUP_VERSION_NUMBER = 2; //Field offset: 0x0
	private UILabel _title; //Field offset: 0x28
	private UILabel _line1Big; //Field offset: 0x2C
	private UILabel _line1Small; //Field offset: 0x30
	private UILabel _buttonText; //Field offset: 0x34
	private MedalCategory _diamond; //Field offset: 0x38
	private MedalCategory _gold; //Field offset: 0x40
	private MedalCategory _silver; //Field offset: 0x48
	private MedalCategory _bronze; //Field offset: 0x50
	private UISprite _topCountryFlag; //Field offset: 0x58
	private UILabel _topCountryName; //Field offset: 0x5C
	private UISprite _infoTextBackground; //Field offset: 0x60
	private Layout _textLayout; //Field offset: 0x64

	public TopRunPopup() { }

	public void OKClicked() { }

	public override void Show() { }

}

