namespace Kiloo.Common.HTTP.Internal;

internal abstract class Request : IRequest
{
	private string <method>k__BackingField; //Field offset: 0x8
	private IResponse <response>k__BackingField; //Field offset: 0xC
	private uint <maxRedirectCount>k__BackingField; //Field offset: 0x10
	private Exception <exception>k__BackingField; //Field offset: 0x14
	private RequestState <state>k__BackingField; //Field offset: 0x18
	private bool <ignoreCertificateErrors>k__BackingField; //Field offset: 0x1C
	private bool <ignoreContentMD5>k__BackingField; //Field offset: 0x1D
	private float <timeout>k__BackingField; //Field offset: 0x20
	private float <minBackOffTime>k__BackingField; //Field offset: 0x24
	private float <maxBackOffTime>k__BackingField; //Field offset: 0x28
	private bool <acceptGzip>k__BackingField; //Field offset: 0x2C
	private Uri <uri>k__BackingField; //Field offset: 0x30
	private byte[] <bytes>k__BackingField; //Field offset: 0x34
	private float <keepAlive>k__BackingField; //Field offset: 0x38
	private Headers <headers>k__BackingField; //Field offset: 0x3C
	private DateTime _startTime; //Field offset: 0x40

	public bool acceptGzip
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public byte[] bytes
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public Exception exception
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public Headers headers
	{
		 get { } //Length: 6
		protected set { } //Length: 11
	}

	public bool ignoreCertificateErrors
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public bool ignoreContentMD5
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public bool isFinished
	{
		 get { } //Length: 30
	}

	public bool isSuccessful
	{
		 get { } //Length: 39
	}

	public float keepAlive
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public float maxBackOffTime
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public uint maxRedirectCount
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public string method
	{
		 get { } //Length: 14
		protected set { } //Length: 1146
	}

	public float minBackOffTime
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public IResponse response
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public RequestState state
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public string statusMessage
	{
		 get { } //Length: 71
	}

	public float timeout
	{
		 get { } //Length: 416
		 set { } //Length: 2352
	}

	public Uri uri
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	protected Request(string method, Uri uri, byte[] bytes) { }

	protected void AssertNotCanceled(string step) { }

	public void CheckBackOff() { }

	public abstract void FetchResponse() { }

	public abstract void FetchResponseAsync() { }

	public bool get_acceptGzip() { }

	public byte[] get_bytes() { }

	public Exception get_exception() { }

	public Headers get_headers() { }

	public bool get_ignoreCertificateErrors() { }

	public bool get_ignoreContentMD5() { }

	public bool get_isFinished() { }

	public bool get_isSuccessful() { }

	public float get_keepAlive() { }

	public float get_maxBackOffTime() { }

	public uint get_maxRedirectCount() { }

	public string get_method() { }

	public float get_minBackOffTime() { }

	public IResponse get_response() { }

	public RequestState get_state() { }

	public string get_statusMessage() { }

	public float get_timeout() { }

	public Uri get_uri() { }

	protected void InternalPrepareFetchResponse() { }

	protected static bool IsFinalState(RequestState state) { }

	private static void Log(string msg) { }

	public abstract void PrepareFetchResponse() { }

	public void set_acceptGzip(bool value) { }

	public void set_bytes(byte[] value) { }

	public void set_exception(Exception value) { }

	protected void set_headers(Headers value) { }

	public void set_ignoreCertificateErrors(bool value) { }

	public void set_ignoreContentMD5(bool value) { }

	public void set_keepAlive(float value) { }

	public void set_maxBackOffTime(float value) { }

	public void set_maxRedirectCount(uint value) { }

	protected void set_method(string value) { }

	public void set_minBackOffTime(float value) { }

	public void set_response(IResponse value) { }

	public void set_state(RequestState value) { }

	public void set_timeout(float value) { }

	public void set_uri(Uri value) { }

	public void UpdateBackOff(IResponse response) { }

	public void UpdateBackOffError() { }

}

