namespace UI.VideoAdPrizes;

public abstract class PrizeIconSetup
{
	private const string ICON_NAME_MYSTERY_BOX = "icon_MysteryBox_big"; //Field offset: 0x0
	private const string ICON_NAME_MINI_MYSTERY_BOX = "icon_big_mini_mysteryBox"; //Field offset: 0x0
	private const string ICON_NAME_SUPER_MYSTERY_BOX = "icon_bigSuperMysteryBox"; //Field offset: 0x0
	private const string ICON_NAME_COINS = "Icon_coin_pouch_larger"; //Field offset: 0x0
	private const string ICON_NAME_KEY = "icon_key_cloud"; //Field offset: 0x0
	protected VideoAdPrizeType _prizeType; //Field offset: 0x8
	protected Vector3 _iconPosition; //Field offset: 0xC
	protected Vector3 _iconRotation; //Field offset: 0x18
	protected int _iconHeight; //Field offset: 0x24

	public abstract UISprite iconSprite
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public VideoAdPrizeType prizeType
	{
		 get { } //Length: 6
	}

	protected PrizeIconSetup() { }

	public void Deactivate() { }

	private void DeactivateSetupIconSprite() { }

	public abstract UISprite get_iconSprite() { }

	public VideoAdPrizeType get_prizeType() { }

	public static List<T> GetPrizeIconSetupsWithTypeAndDeactivateTheRest(IEnumerable<T> prizeIconSetups, VideoAdPrizeType prizeType) { }

	protected virtual void OnDeactivate() { }

	protected virtual void OnSetup() { }

	public abstract void set_iconSprite(UISprite value) { }

	public void Setup() { }

	private void SetupIconSprite() { }

}

