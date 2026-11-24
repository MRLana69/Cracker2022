namespace System.Net;

public class ServicePoint
{
	private readonly Uri uri; //Field offset: 0x8
	private int connectionLimit; //Field offset: 0xC
	private int maxIdleTime; //Field offset: 0x10
	private int currentConnections; //Field offset: 0x14
	private DateTime idleSince; //Field offset: 0x18
	private bool usesProxy; //Field offset: 0x20
	private bool sendContinue; //Field offset: 0x21
	private bool useConnect; //Field offset: 0x22
	private object hostE; //Field offset: 0x24
	private bool useNagle; //Field offset: 0x28
	private bool tcp_keepalive; //Field offset: 0x29
	private int tcp_keepalive_time; //Field offset: 0x2C
	private int tcp_keepalive_interval; //Field offset: 0x30
	private object m_ServerCertificateOrBytes; //Field offset: 0x34

	public bool Expect100Continue
	{
		 set { } //Length: 12
	}

	internal bool SendContinue
	{
		 set { } //Length: 11
	}

	internal bool UseConnect
	{
		 set { } //Length: 11
	}

	public bool UseNagleAlgorithm
	{
		 set { } //Length: 11
	}

	internal bool UsesProxy
	{
		 set { } //Length: 11
	}

	internal ServicePoint(Uri uri, int connectionLimit, int maxIdleTime) { }

	public void set_Expect100Continue(bool value) { }

	internal void set_SendContinue(bool value) { }

	internal void set_UseConnect(bool value) { }

	public void set_UseNagleAlgorithm(bool value) { }

	internal void set_UsesProxy(bool value) { }

	public void SetTcpKeepAlive(bool enabled, int keepAliveTime, int keepAliveInterval) { }

	internal void UpdateServerCertificate(X509Certificate certificate) { }

}

