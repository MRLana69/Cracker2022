namespace System.Runtime.Remoting.Channels;

internal class CrossAppDomainSink : IMessageSink
{
	private struct ProcessMessageRes
	{
		public byte[] arrResponse; //Field offset: 0x0
		public CADMethodReturnMessage cadMrm; //Field offset: 0x4

	}

	private static Hashtable s_sinks; //Field offset: 0x0
	private static MethodInfo processMessageMethod; //Field offset: 0x4
	private int _domainID; //Field offset: 0x8

	internal int TargetDomainId
	{
		 get { } //Length: 1089
	}

	private static CrossAppDomainSink() { }

	internal CrossAppDomainSink(int domainID) { }

	private void <AsyncProcessMessage>b__10_0(object data) { }

	public virtual IMessageCtrl AsyncProcessMessage(IMessage reqMsg, IMessageSink replySink) { }

	internal int get_TargetDomainId() { }

	internal static CrossAppDomainSink GetSink(int domainID) { }

	private static ProcessMessageRes ProcessMessageInDomain(byte[] arrRequest, CADMethodCallMessage cadMsg) { }

	public void SendAsyncMessage(object data) { }

	public virtual IMessage SyncProcessMessage(IMessage msgRequest) { }

}

