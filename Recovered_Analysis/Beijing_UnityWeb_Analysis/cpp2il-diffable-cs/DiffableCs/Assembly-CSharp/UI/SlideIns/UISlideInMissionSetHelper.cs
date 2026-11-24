namespace UI.SlideIns;

public class UISlideInMissionSetHelper : UISlideIn
{
	private UILabel line1; //Field offset: 0x3C
	private UILabel lineReward; //Field offset: 0x40
	private UISprite superMysteryBox; //Field offset: 0x44
	private UISprite mysteryBox; //Field offset: 0x48
	private UISprite coinIcon; //Field offset: 0x4C
	private UILabel coinLabel; //Field offset: 0x50
	private Layout _layout; //Field offset: 0x54
	private Layout _coinLayout; //Field offset: 0x58
	private int _missionsInStoryLineSet; //Field offset: 0x5C

	public UISlideInMissionSetHelper() { }

	private void Awake() { }

	private void EnableCoinLabel(bool enable) { }

	public void NewCoinAmount(int coinAmount) { }

	private void NewCoinAmount(string coinAmount) { }

	public override void SetupSlideIn(SlideIn slideIn) { }

}

