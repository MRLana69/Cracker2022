namespace Mono.Security.Interface;

public interface IMonoSslStream : IDisposable
{

	public bool CanRead
	{
		 get { } //Length: 0
	}

	public bool CanWrite
	{
		 get { } //Length: 0
	}

	public bool IsAuthenticated
	{
		 get { } //Length: 0
	}

	public long Length
	{
		 get { } //Length: 0
	}

	public long Position
	{
		 get { } //Length: 0
	}

	public void AuthenticateAsClient(string targetHost) { }

	public IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	public IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	public int EndRead(IAsyncResult asyncResult) { }

	public void EndWrite(IAsyncResult asyncResult) { }

	public bool get_CanRead() { }

	public bool get_CanWrite() { }

	public bool get_IsAuthenticated() { }

	public long get_Length() { }

	public long get_Position() { }

	public int Read(byte[] buffer, int offset, int count) { }

	public void SetLength(long value) { }

	public void Write(byte[] buffer, int offset, int count) { }

}

