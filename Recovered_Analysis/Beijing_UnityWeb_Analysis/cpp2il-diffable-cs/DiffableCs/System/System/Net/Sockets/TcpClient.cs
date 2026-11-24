namespace System.Net.Sockets;

public class TcpClient : IDisposable
{
	private Socket m_ClientSocket; //Field offset: 0x8
	private bool m_Active; //Field offset: 0xC
	private NetworkStream m_DataStream; //Field offset: 0x10
	private AddressFamily m_Family; //Field offset: 0x14
	private bool m_CleanedUp; //Field offset: 0x18

	public Socket Client
	{
		 get { } //Length: 73
		 set { } //Length: 232
	}

	public int ReceiveTimeout
	{
		 set { } //Length: 419
	}

	public int SendTimeout
	{
		 set { } //Length: 21
	}

	public TcpClient() { }

	public TcpClient(AddressFamily family) { }

	public void Connect(string hostname, int port) { }

	public void Connect(IPEndPoint remoteEP) { }

	protected virtual void Dispose(bool disposing) { }

	public void Dispose() { }

	protected override void Finalize() { }

	public Socket get_Client() { }

	public NetworkStream GetStream() { }

	private void initialize() { }

	public void set_Client(Socket value) { }

	public void set_ReceiveTimeout(int value) { }

	public void set_SendTimeout(int value) { }

}

