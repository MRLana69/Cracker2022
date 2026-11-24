//Type is in global namespace

public class MysteryPowerup
{
	private const float randomBoardDuration = 15; //Field offset: 0x0
	private const int randomBoardWeight = 22; //Field offset: 0x0
	private const string randomBoardIconName = "icon_random_board"; //Field offset: 0x0
	private static readonly Dictionary<UpgradeType, CharacterModifier> mysteryPowerupCharacterModifiers; //Field offset: 0x0
	private static readonly List<BoardId> excludedBoards; //Field offset: 0x4

	private static MysteryPowerup() { }

	public MysteryPowerup() { }

	public static string GetRandomBoardIconName() { }

	public static List<BoardId> GetRandomBoardList() { }

	public static float GetRandomHoverboardDuration() { }

	public static CharacterModifier GetRandomModifier() { }

	private static CharacterModifier SelectRandomCharacterModifier() { }

}

