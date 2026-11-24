namespace UI.SlideIns;

public class UISlideInVideoPayoutHelper : UISlideIn
{
	private UILabel _line1; //Field offset: 0x3C
	private UILabel _prizeCount; //Field offset: 0x40
	private Layout _layout; //Field offset: 0x44
	private Layout _line2Layout; //Field offset: 0x48
	private UISprite _rewardSprite; //Field offset: 0x4C
	private FitSpriteToWidget _spriteFitter; //Field offset: 0x50

	public UISlideInVideoPayoutHelper() { }

	public override void SetupSlideIn(SlideIn slideIn) { }

}

