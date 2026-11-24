namespace System.Runtime.Remoting.Messaging;

internal class MonoMethodMessage : IMethodCallMessage, IMethodMessage, IMessage, IMethodReturnMessage, IInternalMessage
{
	internal static string CallContextKey; //Field offset: 0x0
	internal static string UriKey; //Field offset: 0x4
	private MonoMethod method; //Field offset: 0x8
	private object[] args; //Field offset: 0xC
	private string[] names; //Field offset: 0x10
	private byte[] arg_types; //Field offset: 0x14
	public LogicalCallContext ctx; //Field offset: 0x18
	public object rval; //Field offset: 0x1C
	public Exception exc; //Field offset: 0x20
	private AsyncResult asyncResult; //Field offset: 0x24
	private CallType call_type; //Field offset: 0x28
	private string uri; //Field offset: 0x2C
	private MCMDictionary properties; //Field offset: 0x30
	private Type[] methodSignature; //Field offset: 0x34
	private Identity identity; //Field offset: 0x38

	public int ArgCount
	{
		 get { } //Length: 81
	}

	public object[] Args
	{
		 get { } //Length: 37
	}

	public AsyncResult AsyncResult
	{
		 get { } //Length: 6
	}

	internal CallType CallType
	{
		 get { } //Length: 6
	}

	public Exception Exception
	{
		 get { } //Length: 6
	}

	public LogicalCallContext LogicalCallContext
	{
		 get { } //Length: 6
		 set { } //Length: 181
	}

	public MethodBase MethodBase
	{
		 get { } //Length: 6
	}

	public string MethodName
	{
		 get { } //Length: 6
	}

	public object MethodSignature
	{
		 get { } //Length: 77
	}

	public int OutArgCount
	{
		 get { } //Length: 6
	}

	public object[] OutArgs
	{
		 get { } //Length: 86
	}

	public IDictionary Properties
	{
		 get { } //Length: 6
	}

	public object ReturnValue
	{
		 get { } //Length: 190
	}

	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.TargetIdentity
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public string TypeName
	{
		 get { } //Length: 171
	}

	public string Uri
	{
		 get { } //Length: 83
		 set { } //Length: 11
	}

	private static MonoMethodMessage() { }

	public MonoMethodMessage(MethodBase method, object[] out_args) { }

	internal MonoMethodMessage(MethodInfo minfo, object[] in_args, object[] out_args) { }

	public MonoMethodMessage(Type type, string methodName, object[] in_args) { }

	public int get_ArgCount() { }

	public object[] get_Args() { }

	public AsyncResult get_AsyncResult() { }

	internal CallType get_CallType() { }

	public Exception get_Exception() { }

	public LogicalCallContext get_LogicalCallContext() { }

	public MethodBase get_MethodBase() { }

	public string get_MethodName() { }

	public object get_MethodSignature() { }

	public int get_OutArgCount() { }

	public object[] get_OutArgs() { }

	public IDictionary get_Properties() { }

	public object get_ReturnValue() { }

	public string get_TypeName() { }

	public string get_Uri() { }

	public object GetArg(int arg_num) { }

	private static MethodInfo GetMethodInfo(Type type, string methodName) { }

	internal void InitMessage(MonoMethod method, object[] out_args) { }

	public bool NeedsOutProcessing(out int outCount) { }

	public void set_LogicalCallContext(LogicalCallContext value) { }

	public void set_Uri(string value) { }

	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity() { }

	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(Identity value) { }

}

