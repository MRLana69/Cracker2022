namespace SYBO.Subway.Benchmarking;

public class FramerateTracker
{
	private const float MillisecondsToSeconds = 0.001; //Field offset: 0x0
	private Stopwatch _stopWatch; //Field offset: 0x8
	private float _framesRendered; //Field offset: 0xC
	private GameObject _updater; //Field offset: 0x10
	private FirstMonobehaviour _first; //Field offset: 0x14
	private LastMonobehaviour _last; //Field offset: 0x18
	private float _totalScriptTime; //Field offset: 0x1C
	private float _totalRenderTime; //Field offset: 0x20
	private float _totalPhysicsTime; //Field offset: 0x24
	private float _scriptStartTime; //Field offset: 0x28
	private float _renderStartTime; //Field offset: 0x2C
	private float _physicsStartTime; //Field offset: 0x30
	private bool _paused; //Field offset: 0x34
	private bool _skipFrame; //Field offset: 0x35
	private bool _maxFrametimeSamplingEnabled; //Field offset: 0x36
	private float _maxFrameTimeSampleInterval; //Field offset: 0x38
	private long _lastFrameStartTicks; //Field offset: 0x40
	private float[] _samples; //Field offset: 0x48
	private int _currentSampleIndex; //Field offset: 0x4C
	private float _currentSampleInterval; //Field offset: 0x50
	private float _currentSampleMaxTime; //Field offset: 0x54

	public long ElapsedMilliseconds
	{
		 get { } //Length: 176
	}

	public bool IsTracking
	{
		 get { } //Length: 6
	}

	public float MaxFrameTime
	{
		 get { } //Length: 6
	}

	public FramerateTracker(float maxFrameTimeSampleRange, int maxFrametimeSampleCount) { }

	public void EndTracking() { }

	private void FirstMonobehaviour_OnFixedUpdate() { }

	private void FirstMonobehaviour_OnOnApplicationPause(bool paused) { }

	private void FirstMonobehaviour_OnOnGUI() { }

	private void FirstMonobehaviour_OnUpdate() { }

	public long get_ElapsedMilliseconds() { }

	public bool get_IsTracking() { }

	public float get_MaxFrameTime() { }

	public float GetFramerate() { }

	public float GetPotentialFramerate() { }

	private void LastMonobehaviour_OnLateUpdate() { }

	private void LastMonobehaviour_OnYieldFixedUpdate() { }

	public void Reset() { }

	private void ResetFrameTimes() { }

	public void StartTracking() { }

	public void TogglePause(bool paused) { }

}

