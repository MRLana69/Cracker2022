//Type is in global namespace

public class Achievements
{
	public const int ACHIEVEMENT_COUNT = 41; //Field offset: 0x0
	private static Achievements _instance; //Field offset: 0x0
	private string[] _achievementIds; //Field offset: 0x8
	private Mission[] _achievementArray; //Field offset: 0xC

	public Mission[] achievementArray
	{
		 get { } //Length: 6
	}

	public string[] achievementIds
	{
		 get { } //Length: 546
	}

	public static Achievements Instance
	{
		 get { } //Length: 56
	}

	public Achievements() { }

	public Mission[] get_achievementArray() { }

	public string[] get_achievementIds() { }

	public static Achievements get_Instance() { }

	public int GetAchievementIndexInArray(MissionType type) { }

	public int GetNumberOfHoverboardsUsed() { }

}

