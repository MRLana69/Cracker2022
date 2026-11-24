namespace System.Net;

public static class Dns
{
	private delegate GetHostAddressesCallback
	{

		public GetHostAddressesCallback(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(string hostName, AsyncCallback callback, object object) { }

		public virtual IPAddress[] EndInvoke(IAsyncResult result) { }

		public virtual IPAddress[] Invoke(string hostName) { }

	}


	public static IAsyncResult BeginGetHostAddresses(string hostNameOrAddress, AsyncCallback requestCallback, object state) { }

	public static IPAddress[] EndGetHostAddresses(IAsyncResult asyncResult) { }

	private static void Error_11001(string hostName) { }

	public static IPAddress[] GetHostAddresses(string hostNameOrAddress) { }

	private static bool GetHostByAddr_internal(string addr, out string h_name, out string[] h_aliases, out string[] h_addr_list, int hint) { }

	private static IPHostEntry GetHostByAddressFromString(string address, bool parse) { }

	public static IPHostEntry GetHostByName(string hostName) { }

	private static bool GetHostByName_internal(string host, out string h_name, out string[] h_aliases, out string[] h_addr_list, int hint) { }

	public static IPHostEntry GetHostEntry(string hostNameOrAddress) { }

	public static IPHostEntry GetHostEntry(IPAddress address) { }

	public static string GetHostName() { }

	private static bool GetHostName_internal(out string h_name) { }

	private static IPHostEntry hostent_to_IPHostEntry(string originalHostName, string h_name, string[] h_aliases, string[] h_addrlist) { }

}

