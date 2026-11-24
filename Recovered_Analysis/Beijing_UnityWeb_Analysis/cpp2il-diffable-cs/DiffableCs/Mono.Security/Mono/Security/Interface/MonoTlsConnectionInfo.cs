namespace Mono.Security.Interface;

public class MonoTlsConnectionInfo
{
	private CipherSuiteCode <CipherSuiteCode>k__BackingField; //Field offset: 0x8
	private TlsProtocols <ProtocolVersion>k__BackingField; //Field offset: 0xC
	private string <PeerDomainName>k__BackingField; //Field offset: 0x10

	public CipherSuiteCode CipherSuiteCode
	{
		 get { } //Length: 9
		 set { } //Length: 16
	}

	public string PeerDomainName
	{
		 set { } //Length: 8
	}

	public TlsProtocols ProtocolVersion
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public MonoTlsConnectionInfo() { }

	public CipherSuiteCode get_CipherSuiteCode() { }

	public TlsProtocols get_ProtocolVersion() { }

	public void set_CipherSuiteCode(CipherSuiteCode value) { }

	public void set_PeerDomainName(string value) { }

	public void set_ProtocolVersion(TlsProtocols value) { }

	public override string ToString() { }

}

