namespace System.Net;

public class HttpWebRequest : WebRequest, ISerializable
{
	private struct AuthorizationState
	{
		private readonly HttpWebRequest request; //Field offset: 0x0
		private readonly bool isProxy; //Field offset: 0x4
		private bool isCompleted; //Field offset: 0x5
		private NtlmAuthState ntlm_auth_state; //Field offset: 0x8

		public AuthorizationState(HttpWebRequest request, bool isProxy) { }

		public override string ToString() { }

	}

	private enum NtlmAuthState
	{
		None = 0,
		Challenge = 1,
		Response = 2,
	}

	private static int defaultMaxResponseHeadersLength; //Field offset: 0x0
	private Uri requestUri; //Field offset: 0x14
	private Uri actualUri; //Field offset: 0x18
	private bool hostChanged; //Field offset: 0x1C
	private bool allowAutoRedirect; //Field offset: 0x1D
	private bool allowBuffering; //Field offset: 0x1E
	private X509CertificateCollection certificates; //Field offset: 0x20
	private string connectionGroup; //Field offset: 0x24
	private long contentLength; //Field offset: 0x28
	private WebHeaderCollection webHeaders; //Field offset: 0x30
	private bool keepAlive; //Field offset: 0x34
	private int maxAutoRedirect; //Field offset: 0x38
	private string mediaType; //Field offset: 0x3C
	private string method; //Field offset: 0x40
	private string initialMethod; //Field offset: 0x44
	private bool pipelined; //Field offset: 0x48
	private Version version; //Field offset: 0x4C
	private IWebProxy proxy; //Field offset: 0x50
	private bool sendChunked; //Field offset: 0x54
	private ServicePoint servicePoint; //Field offset: 0x58
	private int timeout; //Field offset: 0x5C
	private int redirects; //Field offset: 0x60
	private object locker; //Field offset: 0x64
	private int readWriteTimeout; //Field offset: 0x68
	private ServerCertValidationCallback certValidationCallback; //Field offset: 0x6C
	private AuthorizationState auth_state; //Field offset: 0x70
	private AuthorizationState proxy_auth_state; //Field offset: 0x7C
	private string host; //Field offset: 0x88
	private bool <ThrowOnError>k__BackingField; //Field offset: 0x8C

	internal ServerCertValidationCallback ServerCertValidationCallback
	{
		 get { } //Length: 6
	}

	public ServicePoint ServicePoint
	{
		 get { } //Length: 225
	}

	internal ServicePoint ServicePointNoLock
	{
		 get { } //Length: 9
	}

	internal bool ThrowOnError
	{
		 set { } //Length: 367
	}

	private static HttpWebRequest() { }

	public HttpWebRequest(Uri uri) { }

	protected HttpWebRequest(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	public HttpWebRequest() { }

	internal ServerCertValidationCallback get_ServerCertValidationCallback() { }

	public ServicePoint get_ServicePoint() { }

	internal ServicePoint get_ServicePointNoLock() { }

	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	internal ServicePoint GetServicePoint() { }

	private void ResetAuthorization() { }

	internal void set_ThrowOnError(bool value) { }

	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

}

