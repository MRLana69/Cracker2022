public struct MissionInfo
{
	public Mission mission;

	public MissionTemplate template;

	public int progress;

	public bool complete;

	public MissionInfo(Mission mission, MissionTemplate template, int progress, bool complete)
	{
		//IL_000f: Expected VT, but got I4
		//IL_001e: Expected VT, but got I4
		this.mission = (Mission)mission.type;
		this.template = (MissionTemplate)template.description;
		_ = template.ultraShortDescription;
		_ = template.missionTarget;
		this.complete = complete;
		this.progress = progress;
	}
}
