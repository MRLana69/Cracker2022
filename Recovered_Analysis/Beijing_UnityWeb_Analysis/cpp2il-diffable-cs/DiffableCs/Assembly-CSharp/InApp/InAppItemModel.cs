namespace InApp;

public class InAppItemModel
{
	public class BundleItem
	{
		private ItemType <type>k__BackingField; //Field offset: 0x8
		private int <amount>k__BackingField; //Field offset: 0xC
		private bool <isBoardTypeValid>k__BackingField; //Field offset: 0x10
		private bool <isThemeIdentifierValid>k__BackingField; //Field offset: 0x11
		private BoardId _boardId; //Field offset: 0x14
		private ThemeIdentifier _themeIdentifier; //Field offset: 0x18

		public int amount
		{
			 get { } //Length: 6
			private set { } //Length: 8
		}

		public BoardId boardId
		{
			 get { } //Length: 9
		}

		public bool isBoardTypeValid
		{
			 get { } //Length: 6
			private set { } //Length: 8
		}

		public bool isThemeIdentifierValid
		{
			 get { } //Length: 9
			private set { } //Length: 11
		}

		public ThemeIdentifier themeIdentifier
		{
			 get { } //Length: 65
		}

		public ItemType type
		{
			 get { } //Length: 9
			private set { } //Length: 19
		}

		public BundleItem(ItemType type, int amount) { }

		public BundleItem(ItemType type, BoardId boardId) { }

		public BundleItem(ItemType type, BoardId boardId, ThemeIdentifier themeIdentifier) { }

		public int get_amount() { }

		public BoardId get_boardId() { }

		public bool get_isBoardTypeValid() { }

		public bool get_isThemeIdentifierValid() { }

		public ThemeIdentifier get_themeIdentifier() { }

		public ItemType get_type() { }

		private void set_amount(int value) { }

		private void set_isBoardTypeValid(bool value) { }

		private void set_isThemeIdentifierValid(bool value) { }

		private void set_type(ItemType value) { }

	}

	public enum ItemType
	{
		Undefined = 0,
		Character = 1,
		CharacterOutfit = 2,
		Board = 3,
		BoardAbility = 4,
		Coins = 5,
		Keys = 6,
		Bundle = 7,
		DoubleCoins = 8,
		Hoverboards = 9,
		Headstarts = 10,
		Scoreboosters = 11,
		Jetpack = 12,
		SuperSneakers = 13,
		CoinMagnet = 14,
		DoubleMultiplier = 15,
		Gachabox = 16,
		SkipMission = 17,
		CharacterToken = 18,
		Trophy = 19,
		AdRemoval = 20,
		CharacterSkip = 21,
	}

	public enum OfferType
	{
		Normal = 0,
		Sale = 1,
		Promotion = 2,
	}

	public string displayName; //Field offset: 0x8
	public string displayText; //Field offset: 0xC
	public string itemId; //Field offset: 0x10
	public int payoutAmount; //Field offset: 0x14
	public bool isConsumable; //Field offset: 0x18
	public string icon; //Field offset: 0x1C
	public string normalOfferId; //Field offset: 0x20
	public List<BundleItem> bundleContents; //Field offset: 0x24
	public ItemType itemType; //Field offset: 0x28
	public OfferType itemOfferType; //Field offset: 0x2C
	private string _localizedPrize; //Field offset: 0x30
	public bool isValidated; //Field offset: 0x34
	public bool isDynamic; //Field offset: 0x35

	public string localizedPrice
	{
		 get { } //Length: 254
		 set { } //Length: 127
	}

	public InAppItemModel() { }

	public static InAppItemModel Clone(InAppItemModel objectToClone) { }

	public void ConvertToPromotion(int payoutIncrement) { }

	public string get_localizedPrice() { }

	public List<int> GetAllThemesForBoard(BoardId boardId) { }

	public static ItemType GetItemTypeFromPowerup(UpgradeType upgradeType) { }

	private static void LogError(string msg, Object context = null) { }

	public void set_localizedPrice(string value) { }

	public override string ToString() { }

}

