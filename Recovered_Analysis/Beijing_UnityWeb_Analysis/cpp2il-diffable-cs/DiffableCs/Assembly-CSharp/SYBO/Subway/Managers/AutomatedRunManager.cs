namespace SYBO.Subway.Managers;

public class AutomatedRunManager
{
	public const string AutomatedRunFinishedFileName = "sybo_automated_run_finished.txt"; //Field offset: 0x0
	private int _gameAutoStartCount; //Field offset: 0x10
	private int _gameAutoRestartDelay; //Field offset: 0x14
	private int _gameAutoReviveCount; //Field offset: 0x18
	private float _hitsEnabledDelayedSeconds; //Field offset: 0x1C
	private bool _enableBenchmarking; //Field offset: 0x20
	private int _numberOfFakeEvents; //Field offset: 0x24
	private float _flushDelay; //Field offset: 0x28
	private bool _editorEnabledEventTesting; //Field offset: 0x2C

	public AutomatedRunManager() { }

}

