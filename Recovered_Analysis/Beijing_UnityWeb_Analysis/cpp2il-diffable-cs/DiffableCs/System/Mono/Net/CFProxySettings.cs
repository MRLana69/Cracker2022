namespace Mono.Net;

internal class CFProxySettings
{
	private static nint kCFNetworkProxiesHTTPEnable; //Field offset: 0x0
	private static nint kCFNetworkProxiesHTTPPort; //Field offset: 0x4
	private static nint kCFNetworkProxiesHTTPProxy; //Field offset: 0x8
	private static nint kCFNetworkProxiesProxyAutoConfigEnable; //Field offset: 0xC
	private static nint kCFNetworkProxiesProxyAutoConfigJavaScript; //Field offset: 0x10
	private static nint kCFNetworkProxiesProxyAutoConfigURLString; //Field offset: 0x14
	private CFDictionary settings; //Field offset: 0x8

	public CFDictionary Dictionary
	{
		 get { } //Length: 166
	}

	private static CFProxySettings() { }

	public CFProxySettings(CFDictionary settings) { }

	public CFDictionary get_Dictionary() { }

}

