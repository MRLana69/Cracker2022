namespace Mono.Net;

internal static class CFNetwork
{
	private sealed class <>c__DisplayClass13_0
	{
		public CFProxy[] proxies; //Field offset: 0x8
		public CFRunLoop runLoop; //Field offset: 0xC

		public <>c__DisplayClass13_0() { }

		internal void <ExecuteProxyAutoConfigurationURL>b__0(nint client, nint proxyList, nint error) { }

	}

	private delegate CFProxyAutoConfigurationResultCallback
	{

		public CFProxyAutoConfigurationResultCallback(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(nint client, nint proxyList, nint error, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(nint client, nint proxyList, nint error) { }

	}

	private class CFWebProxy : IWebProxy
	{
		private ICredentials credentials; //Field offset: 0x8
		private bool userSpecified; //Field offset: 0xC

		public CFWebProxy() { }

		private static Uri ExecuteProxyAutoConfigurationURL(nint proxyAutoConfigURL, Uri targetUri, out NetworkCredential credentials) { }

		public Uri GetProxy(Uri targetUri) { }

		private static Uri GetProxyUri(CFProxy proxy, out NetworkCredential credentials) { }

		private static Uri GetProxyUriFromScript(nint script, Uri targetUri, out NetworkCredential credentials) { }

		public bool IsBypassed(Uri targetUri) { }

		private static Uri SelectProxy(CFProxy[] proxies, Uri targetUri, out NetworkCredential credentials) { }

	}

	private class GetProxyData : IDisposable
	{
		public nint script; //Field offset: 0x8
		public nint targetUri; //Field offset: 0xC
		public nint error; //Field offset: 0x10
		public nint result; //Field offset: 0x14
		public ManualResetEvent evt; //Field offset: 0x18

		public GetProxyData() { }

		public void Dispose() { }

	}

	private static object lock_obj; //Field offset: 0x0
	private static Queue<GetProxyData> get_proxy_queue; //Field offset: 0x4
	private static AutoResetEvent proxy_event; //Field offset: 0x8

	private static CFNetwork() { }

	private static nint CFNetworkCopyProxiesForAutoConfigurationScript(nint proxyAutoConfigurationScript, nint targetURL, out nint error) { }

	private static nint CFNetworkCopyProxiesForAutoConfigurationScriptSequential(nint proxyAutoConfigurationScript, nint targetURL, out nint error) { }

	private static void CFNetworkCopyProxiesForAutoConfigurationScriptThread() { }

	private static nint CFNetworkCopyProxiesForURL(nint url, nint proxySettings) { }

	private static nint CFNetworkCopySystemProxySettings() { }

	private static nint CFNetworkExecuteProxyAutoConfigurationURL(nint proxyAutoConfigURL, nint targetURL, CFProxyAutoConfigurationResultCallback cb, ref CFStreamClientContext clientContext) { }

	private static CFArray CopyProxiesForAutoConfigurationScript(nint proxyAutoConfigurationScript, CFUrl targetURL) { }

	private static CFArray CopyProxiesForURL(CFUrl url, CFDictionary proxySettings) { }

	public static CFProxy[] ExecuteProxyAutoConfigurationURL(nint proxyAutoConfigURL, Uri targetURL) { }

	public static IWebProxy GetDefaultProxy() { }

	public static CFProxy[] GetProxiesForAutoConfigurationScript(nint proxyAutoConfigurationScript, CFUrl targetURL) { }

	public static CFProxy[] GetProxiesForAutoConfigurationScript(nint proxyAutoConfigurationScript, Uri targetUri) { }

	public static CFProxy[] GetProxiesForUri(Uri uri, CFProxySettings proxySettings) { }

	public static CFProxy[] GetProxiesForURL(CFUrl url, CFProxySettings proxySettings) { }

	public static CFProxySettings GetSystemProxySettings() { }

}

