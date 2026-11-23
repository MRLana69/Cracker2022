using SYBO.Components.Utilities;

namespace SYBO.Subway.Managers;

public class AutomatedRunManager : Singleton<AutomatedRunManager>
{
	public const string AutomatedRunFinishedFileName = "sybo_automated_run_finished.txt";

	private int _gameAutoStartCount;

	private int _gameAutoRestartDelay;

	private int _gameAutoReviveCount;

	private float _hitsEnabledDelayedSeconds;

	private bool _enableBenchmarking;

	private int _numberOfFakeEvents;

	private float _flushDelay;

	private bool _editorEnabledEventTesting;
}
