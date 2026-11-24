namespace UnityEngine.Networking;

public class UnityWebRequest : IDisposable
{
	internal enum UnityWebRequestError
	{
		OK = 0,
		Unknown = 1,
		SDKError = 2,
		UnsupportedProtocol = 3,
		MalformattedUrl = 4,
		CannotResolveProxy = 5,
		CannotResolveHost = 6,
		CannotConnectToHost = 7,
		AccessDenied = 8,
		GenericHttpError = 9,
		WriteError = 10,
		ReadError = 11,
		OutOfMemory = 12,
		Timeout = 13,
		HTTPPostError = 14,
		SSLCannotConnect = 15,
		Aborted = 16,
		TooManyRedirects = 17,
		ReceivedNoData = 18,
		SSLNotSupported = 19,
		FailedToSendData = 20,
		FailedToReceiveData = 21,
		SSLCertificateError = 22,
		SSLCipherNotAvailable = 23,
		SSLCACertError = 24,
		UnrecognizedContentEncoding = 25,
		LoginFailed = 26,
		SSLShutdownFailed = 27,
		NoInternetConnection = 28,
	}

	internal enum UnityWebRequestMethod
	{
		Get = 0,
		Post = 1,
		Put = 2,
		Head = 3,
		Custom = 4,
	}

	internal nint m_Ptr; //Field offset: 0x8
	internal DownloadHandler m_DownloadHandler; //Field offset: 0xC
	internal UploadHandler m_UploadHandler; //Field offset: 0x10
	internal CertificateHandler m_CertificateHandler; //Field offset: 0x14
	internal Uri m_Uri; //Field offset: 0x18
	private bool <disposeCertificateHandlerOnDispose>k__BackingField; //Field offset: 0x1C
	private bool <disposeDownloadHandlerOnDispose>k__BackingField; //Field offset: 0x1D
	private bool <disposeUploadHandlerOnDispose>k__BackingField; //Field offset: 0x1E

	public CertificateHandler certificateHandler
	{
		 get { } //Length: 6
	}

	public bool chunkedTransfer
	{
		 set { } //Length: 11
	}

	public bool disposeCertificateHandlerOnDispose
	{
		 get { } //Length: 49
		 set { } //Length: 11
	}

	public bool disposeDownloadHandlerOnDispose
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public bool disposeUploadHandlerOnDispose
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public DownloadHandler downloadHandler
	{
		 get { } //Length: 6
		 set { } //Length: 165
	}

	public string error
	{
		 get { } //Length: 49
	}

	public bool isDone
	{
		 get { } //Length: 49
	}

	public bool isHttpError
	{
		 get { } //Length: 49
	}

	public bool isModifiable
	{
		 get { } //Length: 49
	}

	public bool isNetworkError
	{
		 get { } //Length: 49
	}

	public string method
	{
		 set { } //Length: 154
	}

	public int redirectLimit
	{
		 set { } //Length: 53
	}

	public long responseCode
	{
		 get { } //Length: 6
	}

	public UploadHandler uploadHandler
	{
		 get { } //Length: 254
		 set { } //Length: 154
	}

	public string url
	{
		 get { } //Length: 169
		 set { } //Length: 257
	}

	public UnityWebRequest(string url, string method) { }

	public UnityWebRequest(string url, string method, DownloadHandler downloadHandler, UploadHandler uploadHandler) { }

	public void Abort() { }

	internal UnityWebRequestAsyncOperation BeginWebRequest() { }

	internal static nint Create() { }

	public void Dispose() { }

	private void DisposeHandlers() { }

	public static string EscapeURL(string s, Encoding e) { }

	protected override void Finalize() { }

	public static UnityWebRequest Get(string uri) { }

	public CertificateHandler get_certificateHandler() { }

	public bool get_disposeCertificateHandlerOnDispose() { }

	public bool get_disposeDownloadHandlerOnDispose() { }

	public bool get_disposeUploadHandlerOnDispose() { }

	public DownloadHandler get_downloadHandler() { }

	public string get_error() { }

	public bool get_isDone() { }

	public bool get_isHttpError() { }

	public bool get_isModifiable() { }

	public bool get_isNetworkError() { }

	public long get_responseCode() { }

	public UploadHandler get_uploadHandler() { }

	public string get_url() { }

	private UnityWebRequestError GetError() { }

	internal static string GetHTTPStatusString(long responseCode) { }

	public string GetResponseHeader(string name) { }

	internal string[] GetResponseHeaderKeys() { }

	public Dictionary<string, string> GetResponseHeaders() { }

	private string GetUrl() { }

	private static string GetWebErrorString(UnityWebRequestError err) { }

	internal void InternalDestroy() { }

	internal void InternalSetCustomMethod(string customMethodName) { }

	private void InternalSetDefaults() { }

	internal void InternalSetMethod(UnityWebRequestMethod methodType) { }

	internal UnityWebRequestError InternalSetRequestHeader(string name, string value) { }

	private void InternalSetUrl(string url) { }

	public static UnityWebRequest Post(string uri, WWWForm formData) { }

	private void Release() { }

	public AsyncOperation Send() { }

	public UnityWebRequestAsyncOperation SendWebRequest() { }

	public void set_chunkedTransfer(bool value) { }

	public void set_disposeCertificateHandlerOnDispose(bool value) { }

	public void set_disposeDownloadHandlerOnDispose(bool value) { }

	public void set_disposeUploadHandlerOnDispose(bool value) { }

	public void set_downloadHandler(DownloadHandler value) { }

	public void set_method(string value) { }

	public void set_redirectLimit(int value) { }

	public void set_uploadHandler(UploadHandler value) { }

	public void set_url(string value) { }

	private UnityWebRequestError SetChunked(bool chunked) { }

	private UnityWebRequestError SetCustomMethod(string customMethodName) { }

	private UnityWebRequestError SetDownloadHandler(DownloadHandler dh) { }

	private UnityWebRequestError SetMethod(UnityWebRequestMethod methodType) { }

	private void SetRedirectLimitFromScripting(int limit) { }

	public void SetRequestHeader(string name, string value) { }

	private UnityWebRequestError SetUploadHandler(UploadHandler uh) { }

	private static void SetupPost(UnityWebRequest request, WWWForm formData) { }

	private UnityWebRequestError SetUrl(string url) { }

}

