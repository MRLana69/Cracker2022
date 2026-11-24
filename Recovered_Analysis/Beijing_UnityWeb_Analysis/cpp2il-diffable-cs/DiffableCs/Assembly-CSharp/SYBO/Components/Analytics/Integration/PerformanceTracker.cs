namespace SYBO.Components.Analytics.Integration;

public class PerformanceTracker : IPerformanceTracker
{
	private const int MaxFrameTimeSampleCount = 10; //Field offset: 0x0
	private FramerateTracker _framerateTracker; //Field offset: 0x8

	public float AverageInGameFramerate
	{
		 get { } //Length: 6
	}

	public float MaxFrameTimeMS
	{
		 get { } //Length: 12
	}

	public PerformanceTracker(float maxFrameTimeSampleRangeMS) { }

	private void Game_OnGameEnded() { }

	private void Game_OnGameStarted() { }

	public float get_AverageInGameFramerate() { }

	public float get_MaxFrameTimeMS() { }

	public void Reset() { }

}

