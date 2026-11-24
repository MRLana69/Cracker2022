namespace System.Net;

public class WebProxy : IWebProxy, ISerializable
{
	private bool _UseRegistry; //Field offset: 0x8
	private bool _BypassOnLocal; //Field offset: 0x9
	private bool m_EnableAutoproxy; //Field offset: 0xA
	private Uri _ProxyAddress; //Field offset: 0xC
	private ArrayList _BypassList; //Field offset: 0x10
	private ICredentials _Credentials; //Field offset: 0x14
	private Regex[] _RegExBypassList; //Field offset: 0x18
	private Hashtable _ProxyHostAddresses; //Field offset: 0x1C
	private AutoWebProxyScriptEngine m_ScriptEngine; //Field offset: 0x20

	public ICredentials Credentials
	{
		 get { } //Length: 9
	}

	internal AutoWebProxyScriptEngine ScriptEngine
	{
		 get { } //Length: 55
	}

	public bool UseDefaultCredentials
	{
		 get { } //Length: 6
		 set { } //Length: 460
	}

	public WebProxy() { }

	public WebProxy(Uri Address, bool BypassOnLocal, string[] BypassList, ICredentials Credentials) { }

	internal WebProxy(bool enableAutoproxy) { }

	protected WebProxy(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	private static bool AreAllBypassed(IEnumerable<string> proxies, bool checkFirstOnly) { }

	public static IWebProxy CreateDefaultProxy() { }

	public ICredentials get_Credentials() { }

	internal AutoWebProxyScriptEngine get_ScriptEngine() { }

	public bool get_UseDefaultCredentials() { }

	protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	public Uri GetProxy(Uri destination) { }

	private bool GetProxyAuto(Uri destination, out Uri proxyUri) { }

	public bool IsBypassed(Uri host) { }

	private bool IsBypassedAuto(Uri destination, out bool isBypassed) { }

	private bool IsBypassedManual(Uri host) { }

	private bool IsLocal(Uri host) { }

	private bool IsLocalInProxyHash(Uri host) { }

	private bool IsMatchInBypassList(Uri input) { }

	private static Uri ProxyUri(string proxyName) { }

	public void set_UseDefaultCredentials(bool value) { }

	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	internal void UnsafeUpdateFromRegistry() { }

	private void UpdateRegExList(bool canThrow) { }

}

