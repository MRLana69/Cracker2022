//Type is in global namespace

public class InRunAverageFPSCounter : MonoBehaviour
{
	private const int MAX_NUMBER_OF_INTERVALS = 10; //Field offset: 0x0
	private static int <runAverageFPS>k__BackingField; //Field offset: 0x0
	private static int <runLength>k__BackingField; //Field offset: 0x4
	private float _runStartedTime; //Field offset: 0xC
	private float _runEndedTime; //Field offset: 0x10
	private float _runPausedTime; //Field offset: 0x14
	private float _runResumedTime; //Field offset: 0x18
	private float _appMinimizedTime; //Field offset: 0x1C
	private float _appResumedTime; //Field offset: 0x20
	private float _amountOfTimePaused; //Field offset: 0x24
	private int _frameCount; //Field offset: 0x28
	private bool _isInitialized; //Field offset: 0x2C
	private bool _isInRun; //Field offset: 0x2D
	private bool _isPaused; //Field offset: 0x2E
	private bool _isSubscribedToOnPause; //Field offset: 0x2F
	private string _gpuName; //Field offset: 0x30

	public static int runAverageFPS
	{
		 get { } //Length: 226
		private set { } //Length: 9
	}

	public static int runLength
	{
		 get { } //Length: 49
		private set { } //Length: 51
	}

	public InRunAverageFPSCounter() { }

	public static int get_runAverageFPS() { }

	public static int get_runLength() { }

	public void Initialize() { }

	private void OnApplicationPause(bool paused) { }

	private void PauseChange(bool pause) { }

	private string RoundUpToTargetValue(int total, int factor) { }

	private void RunEnded() { }

	private void RunStarted() { }

	private static void set_runAverageFPS(int value) { }

	private static void set_runLength(int value) { }

	private void SubscribeToGameInstanceEvents() { }

	private void Update() { }

}

