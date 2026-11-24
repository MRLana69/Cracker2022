namespace Kiloo.Common.HTTP;

public static class WebClient
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<KeyValuePair<string, string>, string> <>9__11_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal string <AddQueryParametersToUri>b__11_0(KeyValuePair<string, string> pair) { }

	}

	private sealed class <>c__DisplayClass44_0
	{
		public IRequest request; //Field offset: 0x8
		public SimulatedRequestResult simulatedResult; //Field offset: 0xC

		public <>c__DisplayClass44_0() { }

		internal void <DoSimulation>b__0() { }

	}

	private sealed class <SendRequestCoroutine>d__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public IRequest request; //Field offset: 0x10
		public SendOptions options; //Field offset: 0x14
		public RequestCompleteHandler onComplete; //Field offset: 0x24
		private CacheInfo <cache>5__2; //Field offset: 0x28
		private Action <applySimulationToRequest>5__3; //Field offset: 0x2C
		private float <requestTimeout>5__4; //Field offset: 0x30
		private float <startTime>5__5; //Field offset: 0x34

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 1102
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <SendRequestCoroutine>d__22(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private class CacheInfo
	{
		public bool expired; //Field offset: 0x8
		public CacheMetaData metadata; //Field offset: 0xC
		public string filename; //Field offset: 0x10
		public string metaFilename; //Field offset: 0x14

		public CacheInfo() { }

	}

	private class CacheMetaData
	{
		public DateTime timestamp; //Field offset: 0x8
		public Headers requestHeaders; //Field offset: 0x10
		public Headers responseHeaders; //Field offset: 0x14

		public CacheMetaData() { }

	}

	public enum ClearCacheFlags
	{
		All = 1,
		Expired = 2,
		Old = 4,
	}

	public delegate RequestCompleteHandler
	{

		public RequestCompleteHandler(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(IRequest request, bool isFromCache, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(IRequest request, bool isFromCache) { }

	}

	public struct SendOptions
	{
		public bool disableCache; //Field offset: 0x0
		public bool useCacheOnError; //Field offset: 0x1
		public float simulatedRequestLatency; //Field offset: 0x4
		public IList<SimulatedRequestResult> simulatedRequestResults; //Field offset: 0x8
		public int debugOutputLimit; //Field offset: 0xC

	}

	public const string META_DATA_SUFFIX = ".metadata"; //Field offset: 0x0
	public const string KILOO_DEVICE_TIME_HEADER = "Kiloo-Device-Time"; //Field offset: 0x0
	private static float <timeout>k__BackingField; //Field offset: 0x0
	private static string _cachePath; //Field offset: 0x4
	private static readonly string[] _cachedHeadersToUpdate; //Field offset: 0x8
	public static float defaultSimulatedRequestLatency; //Field offset: 0xC
	public static IList<SimulatedRequestResult> defaultSimulatedRequestResults; //Field offset: 0x10
	private static Random _random; //Field offset: 0x14

	public static string cachePath
	{
		 get { } //Length: 570
	}

	public static float timeout
	{
		 get { } //Length: 307
		 set { } //Length: 53
	}

	private static WebClient() { }

	public static Uri AddQueryParametersToUri(Uri uri, IEnumerable<KeyValuePair<string, string>> queryParameters) { }

	public static Uri AddQueryParametersToUri(string uri, IEnumerable<KeyValuePair<string, string>> queryParameters) { }

	private static void ApplyDefaultSimulationParameters(ref SendOptions options) { }

	public static void ClearCache(ClearCacheFlags flags, float olderThanSeconds) { }

	public static void CloseExpiredIdleConnections() { }

	public static void CloseIdleConnections() { }

	public static void CloseIdleConnectionsToHost(string host) { }

	public static IRequest CreateDelete(Uri uri, IEnumerable<KeyValuePair<string, string>> queryParameters = null) { }

	public static IRequest CreateGet(Uri uri, IEnumerable<KeyValuePair<string, string>> queryParameters = null) { }

	public static IRequest CreatePost(Uri uri, IEnumerable<KeyValuePair<string, string>> queryParameters = null) { }

	public static IRequest CreatePut(Uri uri, IEnumerable<KeyValuePair<string, string>> queryParameters = null) { }

	private static void DoSimulation(IRequest request, ref Action applySimulationToRequest, ref float waitTimeBeforeApply, float simulatedRequestLatency, IList<SimulatedRequestResult> simulatedRequestResults) { }

	public static string get_cachePath() { }

	public static float get_timeout() { }

	private static SimulatedRequestResult GetRandomSimulatedRequestResult(IList<SimulatedRequestResult> simulatedRequestResults) { }

	private static float GetSimulatedRequestResponseChanceTotal(IList<SimulatedRequestResult> simulatedRequestResults) { }

	private static void HandleCacheAfterRequest(IRequest request, CacheInfo cacheInfo, bool useCacheOnError) { }

	private static CacheInfo HandleCacheBeforeRequest(IRequest request) { }

	private static byte[] LoadCacheContents(string file) { }

	private static CacheMetaData LoadCacheMetaData(string file) { }

	private static void Log(string msg) { }

	private static void LogError(string msg) { }

	private static void LogWarning(string msg) { }

	private static void PrepareRequest(IRequest request) { }

	public static IRequest Request(IRequest request, SendOptions options) { }

	public static Coroutine RequestAsync(IRequest request, RequestCompleteHandler onComplete = null, SendOptions options = null) { }

	private static void SaveCacheContents(string file, byte[] bytes) { }

	private static void SaveCacheMetaData(string file, CacheMetaData metadata) { }

	public static IRequest SendRequest(IRequest request, SendOptions options = null) { }

	public static Coroutine SendRequestAsync(IRequest request, RequestCompleteHandler onComplete = null, SendOptions options = null) { }

	private static IEnumerator SendRequestCoroutine(IRequest request, RequestCompleteHandler onComplete, SendOptions options) { }

	public static void set_timeout(float value) { }

	private static void UpdateCachedHeaders(Headers cached, Headers updated) { }

}

