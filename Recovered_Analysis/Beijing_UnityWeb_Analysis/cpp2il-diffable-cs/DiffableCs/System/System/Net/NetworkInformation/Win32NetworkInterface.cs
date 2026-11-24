namespace System.Net.NetworkInformation;

internal class Win32NetworkInterface
{
	private static Win32_FIXED_INFO fixedInfo; //Field offset: 0x0
	private static bool initialized; //Field offset: 0x30

	public static Win32_FIXED_INFO FixedInfo
	{
		 get { } //Length: 2
	}

	public static Win32_FIXED_INFO get_FixedInfo() { }

	private static int GetNetworkParams(nint ptr, ref int size) { }

}

