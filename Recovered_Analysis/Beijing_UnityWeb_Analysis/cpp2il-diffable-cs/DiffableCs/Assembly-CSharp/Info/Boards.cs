namespace Info;

public static class Boards
{
	public class Board
	{
		public string name; //Field offset: 0x8
		public string boardModelName; //Field offset: 0xC
		public int price; //Field offset: 0x10
		public UnlockType unlockType; //Field offset: 0x14
		public string tokenSprite2dName; //Field offset: 0x18
		public string description; //Field offset: 0x1C
		public string limitedDescription; //Field offset: 0x20
		public bool isNewInThisUpdate; //Field offset: 0x24
		public bool hasOnlineTimeLimit; //Field offset: 0x25
		public DateTime defaultExpirationTime; //Field offset: 0x28
		public DateTime defaultStartDate; //Field offset: 0x30
		public bool overrideDynamicIapIdAndroid; //Field offset: 0x38
		public bool overrideDynamicIapIdiOS; //Field offset: 0x39
		public bool overrideDynamicIapIdKindle; //Field offset: 0x3A
		public string dynamicIapId; //Field offset: 0x3C

		public Board() { }

	}

	public enum BoardId
	{
		normal = 0,
		bouncer = 1,
		lowrider = 2,
		snowboard = 3,
		surfboard = 4,
		theoriginal = 5,
		starboard = 6,
		miami = 7,
		monster = 8,
		skullfire = 9,
		speedboard = 10,
		treehugger = 11,
		rome = 12,
		greatWhiteWakeboard = 13,
		hotrod = 14,
		teleboard = 15,
		gliderboard = 16,
	}

	public const string ONLINE_SETTINGS_BOARD_PREFIX_EXPIRE = "hoverboard_expiretime_"; //Field offset: 0x0
	public const string ONLINE_SETTINGS_BOARD_PREFIX_START = "hoverboard_starttime_"; //Field offset: 0x0
	public static readonly Dictionary<BoardId, Board> boardData; //Field offset: 0x0
	public static List<BoardId> boardOrder; //Field offset: 0x4

	private static Boards() { }

	public static string[] GetAllBoardNames() { }

}

