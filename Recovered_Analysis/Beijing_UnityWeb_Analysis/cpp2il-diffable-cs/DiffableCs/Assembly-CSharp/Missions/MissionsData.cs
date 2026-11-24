namespace Missions;

public static class MissionsData
{
	public const int MISSION_COUNT_IN_SET = 3; //Field offset: 0x0
	public const int MISSIONS_VERSION = 3; //Field offset: 0x0
	public static List<MissionIndicator> missionsModificationsForStoryline; //Field offset: 0x0
	public static List<MissionIndicator> missionsModificationsForRepeatable; //Field offset: 0x4
	public static Dictionary<int, int[]> missionsInsertedForRepeatable; //Field offset: 0x8
	public static Mission[][] repeatableMissions; //Field offset: 0xC
	public static Mission[][] storylineMissions; //Field offset: 0x10
	public static readonly Dictionary<MissionType, MissionTemplate> missionTemplates; //Field offset: 0x14
	public static MissionSkip[] skipData; //Field offset: 0x18

	private static MissionsData() { }

}

