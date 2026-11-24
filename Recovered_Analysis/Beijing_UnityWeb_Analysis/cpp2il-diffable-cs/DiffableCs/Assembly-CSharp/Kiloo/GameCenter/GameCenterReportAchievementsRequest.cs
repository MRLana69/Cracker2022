namespace Kiloo.GameCenter;

public class GameCenterReportAchievementsRequest : GameCenterRequest
{
	private Achievement[] <achievements>k__BackingField; //Field offset: 0x14
	private bool <showsCompletionBanner>k__BackingField; //Field offset: 0x18

	public Achievement[] achievements
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public bool showsCompletionBanner
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public GameCenterReportAchievementsRequest(Achievement[] achievements, bool showsCompletionBanner) { }

	public GameCenterReportAchievementsRequest(Achievement achievement, bool showsCompletionBanner) { }

	public GameCenterReportAchievementsRequest(string identifier, float percentComplete, bool showsCompletionBanner) { }

	public Achievement[] get_achievements() { }

	public bool get_showsCompletionBanner() { }

	public void set_achievements(Achievement[] value) { }

	public void set_showsCompletionBanner(bool value) { }

}

