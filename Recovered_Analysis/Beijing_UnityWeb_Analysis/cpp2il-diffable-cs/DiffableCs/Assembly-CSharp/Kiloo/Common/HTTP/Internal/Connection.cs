namespace Kiloo.Common.HTTP.Internal;

internal class Connection : IDisposable
{
	private static readonly List<Connection> _idleConnections; //Field offset: 0x0
	private string <host>k__BackingField; //Field offset: 0x8
	private int <port>k__BackingField; //Field offset: 0xC
	private bool <useSsl>k__BackingField; //Field offset: 0x10
	private int <sendTimeout>k__BackingField; //Field offset: 0x14
	private int <receiveTimeout>k__BackingField; //Field offset: 0x18
	private bool <ignoreCertificateErrors>k__BackingField; //Field offset: 0x1C
	private Stream _stream; //Field offset: 0x20
	private bool _idle; //Field offset: 0x24
	private Nullable<DateTime> _expires; //Field offset: 0x28

	public string host
	{
		 get { } //Length: 793
		private set { } //Length: 65
	}

	public bool ignoreCertificateErrors
	{
		 get { } //Length: 6
		private set { } //Length: 8
	}

	public int port
	{
		 get { } //Length: 6
		private set { } //Length: 11
	}

	public int receiveTimeout
	{
		 get { } //Length: 6
		private set { } //Length: 8
	}

	public bool reused
	{
		 get { } //Length: 9
	}

	public int sendTimeout
	{
		 get { } //Length: 9
		private set { } //Length: 11
	}

	public bool useSsl
	{
		 get { } //Length: 6
		private set { } //Length: 8
	}

	private static Connection() { }

	private Connection(string host, int port, bool useSsl, int sendTimeout, int receiveTimeout, bool ignoreCertificateErrors) { }

	private void CheckValidOperation() { }

	public void Close() { }

	public static void CloseExpiredIdleConnections() { }

	public static void CloseIdleConnections() { }

	public static void CloseIdleConnectionsToHost(string host) { }

	private void Connect() { }

	public void Dispose() { }

	public string get_host() { }

	public bool get_ignoreCertificateErrors() { }

	public int get_port() { }

	public int get_receiveTimeout() { }

	public bool get_reused() { }

	public int get_sendTimeout() { }

	public bool get_useSsl() { }

	public Stream GetStream() { }

	public void KeepAlive(int milliseconds) { }

	private static void Log(string msg) { }

	public static Connection Open(string host, int port, bool useSsl, int sendTimeout, int receiveTimeout, bool ignoreCertificateErrors = false) { }

	public void Reconnect() { }

	private void set_host(string value) { }

	private void set_ignoreCertificateErrors(bool value) { }

	private void set_port(int value) { }

	private void set_receiveTimeout(int value) { }

	private void set_sendTimeout(int value) { }

	private void set_useSsl(bool value) { }

	private bool ValidateServerCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { }

}

