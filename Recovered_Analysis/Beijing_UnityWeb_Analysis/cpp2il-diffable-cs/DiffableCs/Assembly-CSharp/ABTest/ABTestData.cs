namespace ABTest;

public class ABTestData
{
	public class ABTestDataItem
	{
		public bool forceDisable; //Field offset: 0x8
		public string identifier; //Field offset: 0xC
		public string defaultPayload; //Field offset: 0x10
		public TestRange testRange; //Field offset: 0x14
		public string debugTitle; //Field offset: 0x18
		public List<string> debugPayload; //Field offset: 0x1C

		public ABTestDataItem() { }

	}

	public const string ABTEST_AD_DOUBLE_COINS = "doublecoins"; //Field offset: 0x0
	public const string ABTEST_TWO_KEYS = "twokeys"; //Field offset: 0x0
	public const string ABTEST_MAIN_SCREEN_BUTTONS = "mainscreenbuttons"; //Field offset: 0x0
	public const string ABTEST_WELCOME_PACK_PRICEPOINTS = "welcomepackprice"; //Field offset: 0x0
	public const string ABTEST_DOUBLE_COINS_VIDEO = "doublecoinsvideo"; //Field offset: 0x0
	public static readonly List<ABTestDataItem> testData; //Field offset: 0x0

	private static ABTestData() { }

	public ABTestData() { }

}

