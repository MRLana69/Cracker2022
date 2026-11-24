using System.Collections.Generic;

namespace Missions;

public static class MissionsData
{
	public const int MISSION_COUNT_IN_SET = 3;

	public const int MISSIONS_VERSION = 3;

	public static List<MissionIndicator> missionsModificationsForStoryline;

	public static List<MissionIndicator> missionsModificationsForRepeatable;

	public static Dictionary<int, int[]> missionsInsertedForRepeatable;

	public static Mission[][] repeatableMissions;

	public static Mission[][] storylineMissions;

	public static readonly Dictionary<MissionType, MissionTemplate> missionTemplates;

	public static MissionSkip[] skipData;
}
