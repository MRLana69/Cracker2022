namespace UI;

public class CelebrationPopupLabelTemplate : MonoBehaviour
{
	public UILabel bigLabel; //Field offset: 0xC
	public UILabel subLabel; //Field offset: 0x10
	private GameObject normalStateGO; //Field offset: 0x14
	private GameObject megaJackpotStateGO; //Field offset: 0x18
	private GameObject awardStateGO; //Field offset: 0x1C
	private GameObject topRunStateGO; //Field offset: 0x20
	private GameObject characterEventStateGO; //Field offset: 0x24
	private GameObject doubleUpEventStateGO; //Field offset: 0x28
	private UILabel jackpotBigLabel; //Field offset: 0x2C
	private UILabel jackpotSubLabel; //Field offset: 0x30
	private UILabel awardTopDescriptionLabel; //Field offset: 0x34
	private UILabel awardBigLabel; //Field offset: 0x38
	private UILabel awardBottomDescriptionLabel; //Field offset: 0x3C
	private UILabel doubleUpTitleLabel; //Field offset: 0x40
	private UILabel doubleUpSubLabel; //Field offset: 0x44
	public UILabel doubleUpItemLabel; //Field offset: 0x48
	private UILabel doubleUpDescribtionLabel; //Field offset: 0x4C
	private UILabel topRunTopDescriptionLabel; //Field offset: 0x50
	private UILabel topRunBigLabel; //Field offset: 0x54
	private UILabel topRunScore; //Field offset: 0x58
	private UILabel topRunWeekNr; //Field offset: 0x5C
	private UILabel topRunCountry; //Field offset: 0x60
	private UISprite topRunCountryFlag; //Field offset: 0x64
	private Layout _topRunCountryLayout; //Field offset: 0x68
	private UILabel topRunCheckMarkText; //Field offset: 0x6C
	private UILabel characterEventWordNumber; //Field offset: 0x70
	private UILabel characterEventWordNumberShadow; //Field offset: 0x74
	private UILabel characterEventWord; //Field offset: 0x78

	public float Alpha
	{
		 get { } //Length: 7
		 set { } //Length: 172
	}

	private string _GetCoinsLabel(int amount) { }

	private string _GetKeysLabel(int amount) { }

	private string _GetPowerupLabel(UpgradeType type, int amount) { }

	private string _GetTrophyLabel(Trophy trophy) { }

	public CelebrationPopupLabelTemplate() { }

	public float get_Alpha() { }

	private string GetEventLabelPrefix() { }

	public void Init(int backgroundDepth) { }

	private void OnEnable() { }

	public void set_Alpha(float value) { }

	private void SetMaxLineCountNicely(UILabel label, int maxLineCount) { }

	public void SetupAward(string awardTitle, int rewardAmount, AwardTierType type) { }

	public void SetupBoardBundle(string boardName, HoverboardTheme theme1, HoverboardTheme theme2) { }

	public void SetupCharacter(string charName) { }

	public void SetupCharacterWordEvent(int wordNumber, string word) { }

	public void SetupCoins() { }

	public void SetupDoubleUp(CelebrationReward reward) { }

	public void SetupEventSpecialBoard(string boardName) { }

	public void SetupKeys(int amount, bool doubled = false) { }

	public void SetupMedal() { }

	public void SetupPowerup(UpgradeType upgrade, int amount, bool doubled = false) { }

	public void SetupSpecialBoard(string boardName) { }

	public void SetupToken(CharacterId characterId, int amount, int tokensLeft, bool doubled = false) { }

	public void SetupTopRun(int score, int rank, int weekNumber) { }

	public void SetupTrophy(Trophy trophy) { }

	public void UpdateCoins(int amount, bool isMegaJackpot = false, bool doubled = false) { }

}

