namespace System.Net;

public abstract class WebRequest : MarshalByRefObject, ISerializable
{
	internal class DesignerWebRequestCreate
	{

		public DesignerWebRequestCreate() { }

	}

	internal class WebProxyWrapper : WebProxyWrapperOpaque
	{

		internal WebProxy WebProxy
		{
			 get { } //Length: 33
		}

		internal WebProxy get_WebProxy() { }

	}

	internal class WebProxyWrapperOpaque : IWebProxy
	{
		protected readonly WebProxy webProxy; //Field offset: 0x8

		public Uri GetProxy(Uri destination) { }

		public bool IsBypassed(Uri host) { }

	}

	private static object s_InternalSyncObject; //Field offset: 0x0
	private static Queue s_DefaultTimerQueue; //Field offset: 0x4
	private static DesignerWebRequestCreate webRequestCreate; //Field offset: 0x8
	private static IWebProxy s_DefaultWebProxy; //Field offset: 0xC
	private static bool s_DefaultWebProxyInitialized; //Field offset: 0x10
	private AuthenticationLevel m_AuthenticationLevel; //Field offset: 0xC
	private TokenImpersonationLevel m_ImpersonationLevel; //Field offset: 0x10

	public static IWebProxy DefaultWebProxy
	{
		 get { } //Length: 897
	}

	internal static IWebProxy InternalDefaultWebProxy
	{
		 get { } //Length: 235
	}

	private static object InternalSyncObject
	{
		 get { } //Length: 69
	}

	private static WebRequest() { }

	protected WebRequest() { }

	protected WebRequest(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	public static IWebProxy get_DefaultWebProxy() { }

	internal static IWebProxy get_InternalDefaultWebProxy() { }

	private static object get_InternalSyncObject() { }

	protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

}

