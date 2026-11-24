namespace UI.Popups;

public class PrizeMBPopup : UIScreen
{
	private const float LINETHROUGH_Y_OFFSET = -1; //Field offset: 0x0
	private const int LINETHROUGH_WIDTH_PADDING = 4; //Field offset: 0x0
	private UILabel _titleLabel; //Field offset: 0x28
	private UILabel _subtitleLabel; //Field offset: 0x2C
	private Layout _subtitleLayout; //Field offset: 0x30
	private UILabel _rareLabel; //Field offset: 0x34
	private UILabel _keyLabel; //Field offset: 0x38
	private UILabel _scoreBoosterLabel; //Field offset: 0x3C
	private UILabel _trophiesLabel; //Field offset: 0x40
	private UILabel _amountOfCoinsLabel; //Field offset: 0x44
	private UILabel _specialLabel; //Field offset: 0x48
	private UILabel _headstartsLabel; //Field offset: 0x4C
	private UILabel _upToBoardsLabel; //Field offset: 0x50
	private UILabel _upToCoinsLabel; //Field offset: 0x54
	private UILabel _commonLabel; //Field offset: 0x58
	private GameObject _defaultJackpotElements; //Field offset: 0x5C
	private GameObject _megaJackpotElements; //Field offset: 0x60
	private UILabel _jackpotLabel; //Field offset: 0x64
	private UILabel _coinsTitleLabel; //Field offset: 0x68
	private Layout _defaultJackpotLayout; //Field offset: 0x6C
	private UILabel _newJackpotTitleLabel; //Field offset: 0x70
	private UILabel _oldJackpotLabel; //Field offset: 0x74
	private UILabel _newJackpotLabel; //Field offset: 0x78
	private Layout _megaJackpotLayout; //Field offset: 0x7C
	private UISprite _lineThrough; //Field offset: 0x80
	private UISprite _lineThroughShadow; //Field offset: 0x84

	public PrizeMBPopup() { }

	public override void Hide() { }

	public override void Init() { }

	private void SetJackpotLabels() { }

	public override void Show() { }

}

