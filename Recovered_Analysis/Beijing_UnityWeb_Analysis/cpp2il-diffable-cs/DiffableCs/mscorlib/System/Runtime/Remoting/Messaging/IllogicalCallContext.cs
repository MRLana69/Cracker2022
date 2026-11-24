namespace System.Runtime.Remoting.Messaging;

internal class IllogicalCallContext
{
	private Hashtable m_Datastore; //Field offset: 0x8
	private object m_HostContext; //Field offset: 0xC

	private Hashtable Datastore
	{
		 get { } //Length: 31
	}

	internal bool HasUserData
	{
		 get { } //Length: 6
	}

	internal object HostContext
	{
		 get { } //Length: 79
		 set { } //Length: 346
	}

	public IllogicalCallContext() { }

	public IllogicalCallContext CreateCopy() { }

	private Hashtable get_Datastore() { }

	internal bool get_HasUserData() { }

	internal object get_HostContext() { }

	internal void set_HostContext(object value) { }

}

