namespace Kiloo.Common.Backend.Cloud;

public sealed class CloudServer2 : ICloudServer
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<RequestItem, ICloudItem> <>9__38_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal ICloudItem <ProcessCloudItemsResponse>b__38_0(RequestItem responseItem) { }

	}

	private sealed class <>c__DisplayClass50_0
	{
		public bool authSuccess; //Field offset: 0x8
		public Error authError; //Field offset: 0xC

		public <>c__DisplayClass50_0() { }

		internal void <CheckAuthenticationCoroutine>b__0(bool success, Error error) { }

	}

	private sealed class <>c__DisplayClass52_0
	{
		public bool authenticationOk; //Field offset: 0x8

		public <>c__DisplayClass52_0() { }

		internal void <ListItemsCoroutine>b__0(bool authOk) { }

	}

	private sealed class <>c__DisplayClass53_0
	{
		public bool authenticationOk; //Field offset: 0x8

		public <>c__DisplayClass53_0() { }

		internal void <UpdateItemsCoroutine>b__0(bool authOk) { }

	}

	private sealed class <>c__DisplayClass54_0
	{
		public bool authenticationOk; //Field offset: 0x8

		public <>c__DisplayClass54_0() { }

		internal void <CommitItemsCoroutine>b__0(bool authOk) { }

	}

	private sealed class <CheckAuthenticationCoroutine>d__50 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public CloudServer2 <>4__this; //Field offset: 0x10
		public Action<bool> completeHandler; //Field offset: 0x14
		public string expectedKilooTag; //Field offset: 0x18
		private <>c__DisplayClass50_0 <>8__1; //Field offset: 0x1C

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 276
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <CheckAuthenticationCoroutine>d__50(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <CommitItemsCoroutine>d__54 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public CloudServer2 <>4__this; //Field offset: 0x10
		public string forKilooTag; //Field offset: 0x14
		private <>c__DisplayClass54_0 <>8__1; //Field offset: 0x18
		public IEnumerable<ICloudItem> items; //Field offset: 0x1C
		public CloudServerCommitCompleteHandler completeHandler; //Field offset: 0x20
		private IDictionary<string, CloudServerCommitInfo> <commitInfo>5__2; //Field offset: 0x24
		private IRequest <request>5__3; //Field offset: 0x28

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 501
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <CommitItemsCoroutine>d__54(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <ListItemsCoroutine>d__52 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public CloudServer2 <>4__this; //Field offset: 0x10
		public string forKilooTag; //Field offset: 0x14
		private <>c__DisplayClass52_0 <>8__1; //Field offset: 0x18
		public CloudServerRequestCompleteHandler completeHandler; //Field offset: 0x1C
		private IRequest <request>5__2; //Field offset: 0x20

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 433
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <ListItemsCoroutine>d__52(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <UpdateItemsCoroutine>d__53 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public CloudServer2 <>4__this; //Field offset: 0x10
		public string forKilooTag; //Field offset: 0x14
		private <>c__DisplayClass53_0 <>8__1; //Field offset: 0x18
		public IEnumerable<ICloudItem> items; //Field offset: 0x1C
		public CloudServerRequestCompleteHandler completeHandler; //Field offset: 0x20
		private IRequest <request>5__2; //Field offset: 0x24

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 438
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <UpdateItemsCoroutine>d__53(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	public static class ErrorCodes
	{
		public const string CATEGORY = "CloudSave"; //Field offset: 0x0
		public const int INTERNAL_ERROR = 3000; //Field offset: 0x0
		public const int INVALID_REQUEST = 3001; //Field offset: 0x0
		public const int TIMEOUT = 3002; //Field offset: 0x0
		public const int QUOTA_EXCEEDED = 3003; //Field offset: 0x0

	}

	private class Item : ICloudItem
	{
		private readonly RequestItem _requestItem; //Field offset: 0x8
		private readonly CloudUserData _cloudUserData; //Field offset: 0xC
		private readonly string _revision; //Field offset: 0x10
		private readonly string _sourceDescription; //Field offset: 0x14
		private readonly string _sourceInstallationId; //Field offset: 0x18
		private readonly int _dataVersion; //Field offset: 0x1C
		private readonly bool _zipped; //Field offset: 0x20

		public int dataVersion
		{
			 get { } //Length: 6
		}

		public bool isModified
		{
			 get { } //Length: 6
		}

		public bool isOutOfDate
		{
			 get { } //Length: 3
		}

		public Nullable<DateTime> lastModified
		{
			 get { } //Length: 11
		}

		public string name
		{
			 get { } //Length: 6
		}

		public string revision
		{
			 get { } //Length: 9
		}

		public string sourceDescription
		{
			 get { } //Length: 3
		}

		public string sourceInstallationId
		{
			 get { } //Length: 6
		}

		public ICloudUserData userData
		{
			 get { } //Length: 6
		}

		public Item(RequestItem requestItem) { }

		public int get_dataVersion() { }

		public bool get_isModified() { }

		public bool get_isOutOfDate() { }

		public Nullable<DateTime> get_lastModified() { }

		public string get_name() { }

		public string get_revision() { }

		public string get_sourceDescription() { }

		public string get_sourceInstallationId() { }

		public ICloudUserData get_userData() { }

		public Stream GetDataStream() { }

	}

	private class Metadata
	{
		public string sourceDescription; //Field offset: 0x8
		public string sourceInstallationId; //Field offset: 0xC
		public int dataVersion; //Field offset: 0x10
		public bool zipped; //Field offset: 0x14

		public Metadata() { }

	}

	private class RequestItem
	{
		public string name; //Field offset: 0x8
		public Nullable<DateTime> lastModified; //Field offset: 0x10
		public Nullable<int> size; //Field offset: 0x20
		public Dictionary<string, string> metadata; //Field offset: 0x28
		public byte[] data; //Field offset: 0x2C

		public RequestItem() { }

	}

	private class RequestObject
	{
		public List<RequestItem> items; //Field offset: 0x8

		public RequestObject() { }

	}

	private class ResponseObject
	{
		public CloudSaveStatus status; //Field offset: 0x8
		public List<RequestItem> items; //Field offset: 0xC

		public ResponseObject() { }

	}

	private const string API_ROUTE = "api/v2/cloudsave"; //Field offset: 0x0
	private static readonly DateTime _epoch; //Field offset: 0x0
	private Uri <baseUri>k__BackingField; //Field offset: 0x8
	private IKilooAuth <kilooAuth>k__BackingField; //Field offset: 0xC
	private IBsonSerializer <bsonSerializer>k__BackingField; //Field offset: 0x10
	private float <timeout>k__BackingField; //Field offset: 0x14
	private int <minimumSizeForCompression>k__BackingField; //Field offset: 0x18
	private CompressionLevel <compressionLevel>k__BackingField; //Field offset: 0x1C

	public Uri baseUri
	{
		 get { } //Length: 6
		private set { } //Length: 11
	}

	public IBsonSerializer bsonSerializer
	{
		 get { } //Length: 6
		private set { } //Length: 11
	}

	public CompressionLevel compressionLevel
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public IKilooAuth kilooAuth
	{
		 get { } //Length: 6
		private set { } //Length: 11
	}

	public string kilooTag
	{
		 get { } //Length: 6
	}

	public int minimumSizeForCompression
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public float timeout
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	private static CloudServer2() { }

	public CloudServer2(Uri baseUri, IKilooAuth kilooAuth, IBsonSerializer bsonSerializer) { }

	private string BuildRefItemsQueryParameter(IEnumerable<ICloudItem> refItems) { }

	private bool CheckAuthentication(string expectedKilooTag) { }

	private Coroutine CheckAuthenticationAsync(string expectedKilooTag, Action<bool> completeHandler) { }

	private IEnumerator CheckAuthenticationCoroutine(string expectedKilooTag, Action<bool> completeHandler) { }

	private bool CheckAuthenticationResult(string expectedKilooTag, bool isAuthenticated, Error error) { }

	public CloudServerCommitResult CommitItems(string forKilooTag, IEnumerable<ICloudItem> items) { }

	public Coroutine CommitItemsAsync(string forKilooTag, IEnumerable<ICloudItem> items, CloudServerCommitCompleteHandler completeHandler) { }

	private IEnumerator CommitItemsCoroutine(string forKilooTag, IEnumerable<ICloudItem> items, CloudServerCommitCompleteHandler completeHandler) { }

	private static string EscapeName(string name) { }

	private static Nullable<DateTime> FromRevision(string value) { }

	public Uri get_baseUri() { }

	public IBsonSerializer get_bsonSerializer() { }

	public CompressionLevel get_compressionLevel() { }

	public IKilooAuth get_kilooAuth() { }

	public string get_kilooTag() { }

	public int get_minimumSizeForCompression() { }

	public float get_timeout() { }

	public CloudServerResult ListItems(string forKilooTag) { }

	public Coroutine ListItemsAsync(string forKilooTag, CloudServerRequestCompleteHandler completeHandler) { }

	private IEnumerator ListItemsCoroutine(string forKilooTag, CloudServerRequestCompleteHandler completeHandler) { }

	private static void LogError(string msg) { }

	private static void LogResult(string method, CloudServerResult result) { }

	private Dictionary<string, string> MakeMetadataDictionary(ICloudItem item, bool zipped) { }

	private IRequest PrepareCommitItemsRequest(IEnumerable<ICloudItem> items, out IDictionary<string, CloudServerCommitInfo> commitInfo) { }

	private IRequest PrepareListItemsRequest() { }

	private IRequest PrepareUpdateItemsRequest(IEnumerable<ICloudItem> refItems) { }

	private CloudServerResult ProcessCloudItemsResponse(IRequest request) { }

	private void set_baseUri(Uri value) { }

	private void set_bsonSerializer(IBsonSerializer value) { }

	public void set_compressionLevel(CompressionLevel value) { }

	private void set_kilooAuth(IKilooAuth value) { }

	public void set_minimumSizeForCompression(int value) { }

	public void set_timeout(float value) { }

	private static string ToRevision(Nullable<DateTime> value) { }

	public CloudServerResult UpdateItems(string forKilooTag, IEnumerable<ICloudItem> items) { }

	public Coroutine UpdateItemsAsync(string forKilooTag, IEnumerable<ICloudItem> items, CloudServerRequestCompleteHandler completeHandler) { }

	private IEnumerator UpdateItemsCoroutine(string forKilooTag, IEnumerable<ICloudItem> items, CloudServerRequestCompleteHandler completeHandler) { }

	private byte[] Zip(Stream data, out int inputCrc32, out int inputLength, out int outputLength) { }

}

