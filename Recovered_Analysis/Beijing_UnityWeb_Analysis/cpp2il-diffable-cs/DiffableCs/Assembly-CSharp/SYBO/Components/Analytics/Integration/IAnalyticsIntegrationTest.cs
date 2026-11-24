namespace SYBO.Components.Analytics.Integration;

public interface IAnalyticsIntegrationTest
{

	public AnalyticsManager Manager
	{
		 get { } //Length: 0
	}

	public void GenerateFakeSessionEvents(int count) { }

	public AnalyticsManager get_Manager() { }

	public void SimulateOnlineSettingsDownload() { }

}

