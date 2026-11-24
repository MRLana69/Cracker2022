namespace System.Net;

public class ServicePointManager
{
	private class SPKey
	{
		private Uri uri; //Field offset: 0x8
		private Uri proxy; //Field offset: 0xC
		private bool use_connect; //Field offset: 0x10

		public bool UsesProxy
		{
			 get { } //Length: 12
		}

		public SPKey(Uri uri, Uri proxy, bool use_connect) { }

		public override bool Equals(object obj) { }

		public bool get_UsesProxy() { }

		public override int GetHashCode() { }

	}

	private static HybridDictionary servicePoints; //Field offset: 0x0
	private static ICertificatePolicy policy; //Field offset: 0x4
	private static int defaultConnectionLimit; //Field offset: 0x8
	private static int maxServicePointIdleTime; //Field offset: 0xC
	private static int maxServicePoints; //Field offset: 0x10
	private static int dnsRefreshTimeout; //Field offset: 0x14
	private static bool _checkCRL; //Field offset: 0x18
	private static SecurityProtocolType _securityProtocol; //Field offset: 0x1C
	private static bool expectContinue; //Field offset: 0x20
	private static bool useNagle; //Field offset: 0x21
	private static ServerCertValidationCallback server_cert_cb; //Field offset: 0x24
	private static bool tcp_keepalive; //Field offset: 0x28
	private static int tcp_keepalive_time; //Field offset: 0x2C
	private static int tcp_keepalive_interval; //Field offset: 0x30

	internal static ServerCertValidationCallback ServerCertValidationCallback
	{
		 get { } //Length: 89
	}

	private static ServicePointManager() { }

	public static ServicePoint FindServicePoint(Uri address, IWebProxy proxy) { }

	internal static ServerCertValidationCallback get_ServerCertValidationCallback() { }

	internal static ICertificatePolicy GetLegacyCertificatePolicy() { }

}

