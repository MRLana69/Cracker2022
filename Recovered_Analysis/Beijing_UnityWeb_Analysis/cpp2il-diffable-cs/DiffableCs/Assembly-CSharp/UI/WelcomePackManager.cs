namespace UI;

public class WelcomePackManager
{
	private const int WELCOME_PACK_DAYS_ACTIVE = 3; //Field offset: 0x0
	private const int WELCOME_PACK_ACTIVE_FROM_VERSION = 1890; //Field offset: 0x0

	public static string WelcomePackInAppID
	{
		 get { } //Length: 2534
	}

	public static TimeSpan welcomePackTimeLeft
	{
		 get { } //Length: 138
	}

	public WelcomePackManager() { }

	public static string get_WelcomePackInAppID() { }

	public static TimeSpan get_welcomePackTimeLeft() { }

	private static string GetFirstInstalledVersion() { }

	public static bool IsWelcomeBoardActive(BoardId boardId) { }

	public static bool IsWelcomePackActive() { }

	private static void Log(string msg, Object context = null) { }

	private static int ParseFirstInstalledVersion() { }

	public static void ResetWelcomePack() { }

	private static void UpdateSetWelcomePackStartTime() { }

}

