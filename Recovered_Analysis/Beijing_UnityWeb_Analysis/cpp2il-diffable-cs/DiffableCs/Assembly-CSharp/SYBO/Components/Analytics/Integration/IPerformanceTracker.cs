namespace SYBO.Components.Analytics.Integration;

public interface IPerformanceTracker
{

	public float AverageInGameFramerate
	{
		 get { } //Length: 0
	}

	public float MaxFrameTimeMS
	{
		 get { } //Length: 0
	}

	public float get_AverageInGameFramerate() { }

	public float get_MaxFrameTimeMS() { }

	public void Reset() { }

}

