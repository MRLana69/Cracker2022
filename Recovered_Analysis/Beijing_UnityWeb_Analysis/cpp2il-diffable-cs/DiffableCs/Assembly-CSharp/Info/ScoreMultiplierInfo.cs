namespace Info;

public static class ScoreMultiplierInfo
{
	private static Action onScoreMultiplierChanged; //Field offset: 0x0

	public static event Action onScoreMultiplierChanged
	{
		 add { } //Length: 2
		 remove { } //Length: 206
	}

	public static int rawMultiplier
	{
		 get { } //Length: 240
	}

	public static int scoreMultiplier
	{
		 get { } //Length: 268
	}

	private static ScoreMultiplierInfo() { }

	public static void add_onScoreMultiplierChanged(Action value) { }

	public static int get_rawMultiplier() { }

	public static int get_scoreMultiplier() { }

	public static void remove_onScoreMultiplierChanged(Action value) { }

	public static void TriggerOnScoreMultiplierChanged() { }

}

