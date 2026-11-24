namespace Onboarding;

public static class OnboardingTracking
{
	public enum ScreenType
	{
		Gameover = 0,
		FrontScreen = 1,
	}

	private const string PLAYER_PREF_ONBOARDING_GAMEOVER_LOG_KEY = "ShouldLogFrontScreenFlow"; //Field offset: 0x0
	private const string PLAYER_PREF_ONBOARDING_FRONTSCREEN_LOG_KEY = "ShouldLogGameoverScreenFlow"; //Field offset: 0x0
	private static List<string> listOfScreensAfterGameover; //Field offset: 0x0
	private const int LOG_LIMIT = 6; //Field offset: 0x0
	private static List<string> listOfScreensAfterFrontscreen; //Field offset: 0x4

	private static OnboardingTracking() { }

	private static void DisableOnboardingTracking(ScreenType screenType) { }

	private static void DispatchEvents(ScreenType screenType) { }

	private static void DispatchQueuedEventsIfNeeded(ScreenType screenType) { }

	public static void EnableOnboardingTracking(ScreenType screenType) { }

	private static bool IsTrackingActive() { }

	private static bool IsTrackingActiveFor(ScreenType screenType) { }

	private static bool LogLimitReached(ScreenType screenType) { }

	public static void LogScreenFlow(string screenName) { }

	public static void OnApplicationQuit() { }

	private static void QueueOnboardingEvents(string screenName) { }

}

