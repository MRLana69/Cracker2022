//Type is in global namespace

public static class InRunLogging
{
	private static int _headstartUsedInRun; //Field offset: 0x0
	private static int _scoreboostersUsedInRun; //Field offset: 0x4
	private static bool _isFirstShow; //Field offset: 0x8
	private static bool _isInitialized; //Field offset: 0x9

	private static InRunLogging() { }

	public static void Init() { }

	private static void OnGameStarted() { }

	private static void OnHeadstartActivated(int tier) { }

	private static void OnMenuScreenShown() { }

	private static void OnScoreBoostActivated(int tier) { }

}

