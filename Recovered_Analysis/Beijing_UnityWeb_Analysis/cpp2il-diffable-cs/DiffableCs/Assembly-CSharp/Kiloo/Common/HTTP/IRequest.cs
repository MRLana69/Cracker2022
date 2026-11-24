namespace Kiloo.Common.HTTP;

public interface IRequest
{

	public bool acceptGzip
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public byte[] bytes
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public Exception exception
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public Headers headers
	{
		 get { } //Length: 0
	}

	public bool ignoreCertificateErrors
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public bool ignoreContentMD5
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public bool isFinished
	{
		 get { } //Length: 0
	}

	public bool isSuccessful
	{
		 get { } //Length: 0
	}

	public float keepAlive
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public float maxBackOffTime
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public uint maxRedirectCount
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public string method
	{
		 get { } //Length: 0
	}

	public float minBackOffTime
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public IResponse response
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public RequestState state
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public string statusMessage
	{
		 get { } //Length: 0
	}

	public float timeout
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public Uri uri
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public void FetchResponse() { }

	public void FetchResponseAsync() { }

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

	public void PrepareFetchResponse() { }

	public void set_acceptGzip(bool value) { }

	public void set_bytes(byte[] value) { }

	public void set_exception(Exception value) { }

	public void set_ignoreCertificateErrors(bool value) { }

	public void set_ignoreContentMD5(bool value) { }

	public void set_keepAlive(float value) { }

	public void set_maxBackOffTime(float value) { }

	public void set_maxRedirectCount(uint value) { }

	public void set_minBackOffTime(float value) { }

	public void set_response(IResponse value) { }

	public void set_state(RequestState value) { }

	public void set_timeout(float value) { }

	public void set_uri(Uri value) { }

}

