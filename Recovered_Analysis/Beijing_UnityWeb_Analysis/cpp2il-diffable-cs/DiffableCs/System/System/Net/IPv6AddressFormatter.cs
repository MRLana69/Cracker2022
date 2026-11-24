namespace System.Net;

internal struct IPv6AddressFormatter
{
	private ushort[] address; //Field offset: 0x0
	private long scopeId; //Field offset: 0x8

	public IPv6AddressFormatter(ushort[] addr, long scopeId) { }

	private uint AsIPv4Int() { }

	private bool IsIPv4Compatible() { }

	private bool IsIPv4Mapped() { }

	private static ushort SwapUShort(ushort number) { }

	public override string ToString() { }

}

