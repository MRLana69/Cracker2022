namespace System.Net.NetworkInformation;

internal class MibIPGlobalProperties : UnixIPGlobalProperties
{
	private static readonly char[] wsChars; //Field offset: 0x0
	public readonly string StatisticsFile; //Field offset: 0x8
	public readonly string StatisticsFileIPv6; //Field offset: 0xC
	public readonly string TcpFile; //Field offset: 0x10
	public readonly string Tcp6File; //Field offset: 0x14
	public readonly string UdpFile; //Field offset: 0x18
	public readonly string Udp6File; //Field offset: 0x1C

	private static MibIPGlobalProperties() { }

	public MibIPGlobalProperties(string procDir) { }

}

