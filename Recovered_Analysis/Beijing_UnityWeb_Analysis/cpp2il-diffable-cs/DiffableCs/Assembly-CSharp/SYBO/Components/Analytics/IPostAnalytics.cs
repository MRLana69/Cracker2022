namespace SYBO.Components.Analytics;

public interface IPostAnalytics
{

	public string BaseURL
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public string get_BaseURL() { }

	public void PostAnalyticsEvents(byte[] analyticsJsonBytes, int uncompressedLength, string uncompressedMD5Hash, Action<ProcessAnalyticsEventsResponse> onFinished) { }

	public void set_BaseURL(string value) { }

}

