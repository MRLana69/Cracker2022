namespace System.Net.Configuration;

internal sealed class DefaultProxySectionInternal
{
	private static object classSyncObject; //Field offset: 0x0
	private IWebProxy webProxy; //Field offset: 0x8

	internal static object ClassSyncObject
	{
		 get { } //Length: 7
	}

	internal IWebProxy WebProxy
	{
		 get { } //Length: 29
	}

	public DefaultProxySectionInternal() { }

	internal static object get_ClassSyncObject() { }

	internal IWebProxy get_WebProxy() { }

	private static IWebProxy GetDefaultProxy_UsingOldMonoCode() { }

	internal static DefaultProxySectionInternal GetSection() { }

	private static IWebProxy GetSystemWebProxy() { }

}

