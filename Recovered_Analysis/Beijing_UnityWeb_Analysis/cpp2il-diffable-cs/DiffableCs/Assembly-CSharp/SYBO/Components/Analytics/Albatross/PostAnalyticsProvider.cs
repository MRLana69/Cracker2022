namespace SYBO.Components.Analytics.Albatross;

public class PostAnalyticsProvider : IPostAnalytics
{
	private sealed class <>c__DisplayClass9_0
	{
		public byte[] postData; //Field offset: 0x8
		public int uncompressedLength; //Field offset: 0xC
		public string url; //Field offset: 0x10
		public Action<ProcessAnalyticsEventsResponse> onFinished; //Field offset: 0x14

		public <>c__DisplayClass9_0() { }

		internal void <PostAnalyticsEvents>b__0(int responseCode, string httpResponse, string errorMessage) { }

	}

	public interface IHTTPPostLayer
	{

		public void POST(string url, Dictionary<string, string> headers, byte[] bytes, Action<int, string, string> onFinish) { }

	}

	private const string AUTH_FORMAT = "{0} {1}
{2}"; //Field offset: 0x0
	private const bool CompressContent = True; //Field offset: 0x0
	private string _baseURL; //Field offset: 0x8
	private string _applicationId; //Field offset: 0xC
	private string _userAgentString; //Field offset: 0x10
	private string _apiVersion; //Field offset: 0x14
	private HMACSHA1 _hmac; //Field offset: 0x18
	private IHTTPPostLayer _httpLayer; //Field offset: 0x1C

	private string SYBO.Components.Analytics.IPostAnalytics.BaseURL
	{
		 get { } //Length: 197
		 set { } //Length: 11
	}

	public PostAnalyticsProvider(string baseUrl, string applicationId, string apiVersion, string userAgentString, byte[] key, IHTTPPostLayer httpLayer) { }

	private Dictionary<string, string> GenerateHeaders(string method, string uri, string uncompressedMD5Hash, bool gzipData) { }

	public void PostAnalyticsEvents(byte[] analyticsJsonBytes, int uncompressedLength, string uncompressedMD5Hash, Action<ProcessAnalyticsEventsResponse> onFinished) { }

	private string SYBO.Components.Analytics.IPostAnalytics.get_BaseURL() { }

	private void SYBO.Components.Analytics.IPostAnalytics.set_BaseURL(string value) { }

}

