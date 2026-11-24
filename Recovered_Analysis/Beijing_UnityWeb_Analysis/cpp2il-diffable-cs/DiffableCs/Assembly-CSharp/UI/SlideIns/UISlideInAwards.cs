namespace UI.SlideIns;

public class UISlideInAwards : UISlideIn
{
	private const string CAN_BRONZE = "icon_bronze_can"; //Field offset: 0x0
	private const string CAN_SILVER = "icon_silver_can"; //Field offset: 0x0
	private const string CAN_GOLD = "icon_gold_can"; //Field offset: 0x0
	private const string CAN_DIAMOND = "icon_diamond_can"; //Field offset: 0x0
	private UISprite _icon; //Field offset: 0x3C
	private UILabel _textLine1; //Field offset: 0x40
	private Layout _layout; //Field offset: 0x44
	private GameObject _starObj; //Field offset: 0x48

	public UISlideInAwards() { }

	public override void SetupSlideIn(SlideIn slideIn) { }

}

