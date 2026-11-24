namespace System.Net;

public class IPAddress
{
	public static readonly IPAddress Any; //Field offset: 0x0
	internal const int IPv4AddressBytes = 4; //Field offset: 0x0
	internal const int IPv6AddressBytes = 16; //Field offset: 0x0
	internal const long LoopbackMask = 255; //Field offset: 0x0
	internal const int NumberOfLabels = 8; //Field offset: 0x0
	public static readonly IPAddress Loopback; //Field offset: 0x4
	public static readonly IPAddress Broadcast; //Field offset: 0x8
	public static readonly IPAddress None; //Field offset: 0xC
	public static readonly IPAddress IPv6Any; //Field offset: 0x10
	public static readonly IPAddress IPv6Loopback; //Field offset: 0x14
	public static readonly IPAddress IPv6None; //Field offset: 0x18
	internal long m_Address; //Field offset: 0x8
	internal string m_ToString; //Field offset: 0x10
	private AddressFamily m_Family; //Field offset: 0x14
	private ushort[] m_Numbers; //Field offset: 0x18
	private long m_ScopeId; //Field offset: 0x20
	private int m_HashCode; //Field offset: 0x28

	public AddressFamily AddressFamily
	{
		 get { } //Length: 240
	}

	public long ScopeId
	{
		 get { } //Length: 6
	}

	private static IPAddress() { }

	internal IPAddress(int newAddress) { }

	public IPAddress(long newAddress) { }

	public IPAddress(byte[] address, long scopeid) { }

	private IPAddress(ushort[] address, uint scopeid) { }

	internal bool Equals(object comparandObj, bool compareScopeId) { }

	public override bool Equals(object comparand) { }

	public AddressFamily get_AddressFamily() { }

	public long get_ScopeId() { }

	public byte[] GetAddressBytes() { }

	public override int GetHashCode() { }

	private static IPAddress InternalParse(string ipString, bool tryParse) { }

	public static bool IsLoopback(IPAddress address) { }

	public IPAddress MapToIPv6() { }

	public static IPAddress Parse(string ipString) { }

	public override string ToString() { }

	public static bool TryParse(string ipString, out IPAddress address) { }

}

