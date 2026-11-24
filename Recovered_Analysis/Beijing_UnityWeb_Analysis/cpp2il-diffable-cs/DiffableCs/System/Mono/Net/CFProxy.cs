namespace Mono.Net;

internal class CFProxy
{
	private static nint kCFProxyAutoConfigurationJavaScriptKey; //Field offset: 0x0
	private static nint kCFProxyAutoConfigurationURLKey; //Field offset: 0x4
	private static nint kCFProxyHostNameKey; //Field offset: 0x8
	private static nint kCFProxyPasswordKey; //Field offset: 0xC
	private static nint kCFProxyPortNumberKey; //Field offset: 0x10
	private static nint kCFProxyTypeKey; //Field offset: 0x14
	private static nint kCFProxyUsernameKey; //Field offset: 0x18
	private static nint kCFProxyTypeAutoConfigurationURL; //Field offset: 0x1C
	private static nint kCFProxyTypeAutoConfigurationJavaScript; //Field offset: 0x20
	private static nint kCFProxyTypeFTP; //Field offset: 0x24
	private static nint kCFProxyTypeHTTP; //Field offset: 0x28
	private static nint kCFProxyTypeHTTPS; //Field offset: 0x2C
	private static nint kCFProxyTypeSOCKS; //Field offset: 0x30
	private CFDictionary settings; //Field offset: 0x8

	public nint AutoConfigurationJavaScript
	{
		 get { } //Length: 415
	}

	public nint AutoConfigurationUrl
	{
		 get { } //Length: 160
	}

	public string HostName
	{
		 get { } //Length: 160
	}

	public string Password
	{
		 get { } //Length: 166
	}

	public int Port
	{
		 get { } //Length: 166
	}

	public CFProxyType ProxyType
	{
		 get { } //Length: 166
	}

	public string Username
	{
		 get { } //Length: 166
	}

	private static CFProxy() { }

	internal CFProxy(CFDictionary settings) { }

	private static CFProxyType CFProxyTypeToEnum(nint type) { }

	public nint get_AutoConfigurationJavaScript() { }

	public nint get_AutoConfigurationUrl() { }

	public string get_HostName() { }

	public string get_Password() { }

	public int get_Port() { }

	public CFProxyType get_ProxyType() { }

	public string get_Username() { }

}

