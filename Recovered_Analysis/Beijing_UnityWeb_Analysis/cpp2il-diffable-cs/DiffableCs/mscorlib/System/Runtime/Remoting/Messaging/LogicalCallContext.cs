namespace System.Runtime.Remoting.Messaging;

public sealed class LogicalCallContext : ISerializable, ICloneable
{
	internal struct Reader
	{
		private LogicalCallContext m_ctx; //Field offset: 0x0

		public bool HasInfo
		{
			 get { } //Length: 10
		}

		public bool IsNull
		{
			 get { } //Length: 79
		}

		public Reader(LogicalCallContext ctx) { }

		public LogicalCallContext Clone() { }

		public bool get_HasInfo() { }

		public bool get_IsNull() { }

	}

	private static Type s_callContextType; //Field offset: 0x0
	private const string s_CorrelationMgrSlotName = "System.Diagnostics.Trace.CorrelationManagerSlot"; //Field offset: 0x0
	private Hashtable m_Datastore; //Field offset: 0x8
	private CallContextRemotingData m_RemotingData; //Field offset: 0xC
	private CallContextSecurityData m_SecurityData; //Field offset: 0x10
	private object m_HostContext; //Field offset: 0x14
	private bool m_IsCorrelationMgr; //Field offset: 0x18
	private Header[] _sendHeaders; //Field offset: 0x1C
	private Header[] _recvHeaders; //Field offset: 0x20

	private Hashtable Datastore
	{
		 get { } //Length: 26
	}

	public bool HasInfo
	{
		 get { } //Length: 441
	}

	private bool HasUserData
	{
		 get { } //Length: 66
	}

	private static LogicalCallContext() { }

	internal LogicalCallContext() { }

	internal LogicalCallContext(SerializationInfo info, StreamingContext context) { }

	public object Clone() { }

	private Hashtable get_Datastore() { }

	public bool get_HasInfo() { }

	private bool get_HasUserData() { }

	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	internal void Merge(LogicalCallContext lc) { }

}

