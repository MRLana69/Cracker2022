namespace SYBO.Subway.Info;

public class Characters
{
	public enum CharacterId
	{
		slick = 0,
		tricky = 1,
		fresh = 2,
		spike = 3,
		yutani = 4,
		frank = 5,
		frizzy = 6,
		king = 7,
		lucy = 8,
		ninja = 9,
		tag = 10,
		tasha = 11,
		zoe = 12,
		brody = 13,
		princek = 14,
		tony = 15,
		seoulCharacter01 = 16,
		amsterdamCharacter01 = 17,
	}

	public class Model
	{
		public string name; //Field offset: 0x8
		public string modelName; //Field offset: 0xC
		public int Price; //Field offset: 0x10
		public UnlockType unlockType; //Field offset: 0x14
		public string tokenName; //Field offset: 0x18
		public string tokenSprite2dName; //Field offset: 0x1C
		public MissionTarget missionTargetKey; //Field offset: 0x20
		public string characterLimitedDescription; //Field offset: 0x24
		public bool isNewInThisUpdate; //Field offset: 0x28
		public bool hasOnlineSettings; //Field offset: 0x29
		public DateTime defaultExpirationDate; //Field offset: 0x30
		public DateTime defaultStartDate; //Field offset: 0x38
		public bool overrideDynamicIapIdAndroid; //Field offset: 0x40
		public bool overrideDynamicIapIdiOS; //Field offset: 0x41
		public bool overrideDynamicIapIdKindle; //Field offset: 0x42
		public string dynamicIapId; //Field offset: 0x44

		public Model() { }

	}

	public const string ONLINE_SETTINGS_CHARACTER_PREFIX_EXPIRE = "character_expiretime_"; //Field offset: 0x0
	public const string ONLINE_SETTINGS_CHARACTER_PREFIX_START = "character_starttime_"; //Field offset: 0x0
	public static readonly Dictionary<CharacterId, Model> characterData; //Field offset: 0x0
	public static List<CharacterId> characterOrder; //Field offset: 0x4

	private static Characters() { }

	public Characters() { }

	public static Nullable<CharacterId> GetCharacterTypeForName(string name) { }

}

