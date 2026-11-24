namespace UI.Popups;

public class CloudSaveAdvancedComparisonPopup : UIScreen
{
	private UILabel _localHeadline; //Field offset: 0x28
	private UILabel _onlineHeadline; //Field offset: 0x2C
	private UISprite _headerBackground; //Field offset: 0x30
	private UISprite _contentBackground; //Field offset: 0x34
	private UISprite _localBannerBackground; //Field offset: 0x38
	private UISprite _onlineBannerBackground; //Field offset: 0x3C
	private CloudSaveAdvancedComparisonRow _comparisonRowPrefab; //Field offset: 0x40
	private Layout _rowLayout; //Field offset: 0x44

	public CloudSaveAdvancedComparisonPopup() { }

	public override void Init() { }

	private void SetupBasic() { }

	private void SetupComparison() { }

	public override void Show() { }

}

