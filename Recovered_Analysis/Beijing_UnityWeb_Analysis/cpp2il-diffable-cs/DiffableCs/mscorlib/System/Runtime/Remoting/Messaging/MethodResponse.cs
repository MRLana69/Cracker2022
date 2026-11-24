namespace System.Runtime.Remoting.Messaging;

public class MethodResponse : IMethodReturnMessage, IMethodMessage, IMessage, ISerializable, IInternalMessage
{
	private string _methodName; //Field offset: 0x8
	private string _uri; //Field offset: 0xC
	private string _typeName; //Field offset: 0x10
	private MethodBase _methodBase; //Field offset: 0x14
	private object _returnValue; //Field offset: 0x18
	private Exception _exception; //Field offset: 0x1C
	private Type[] _methodSignature; //Field offset: 0x20
	private ArgInfo _inArgInfo; //Field offset: 0x24
	private object[] _args; //Field offset: 0x28
	private object[] _outArgs; //Field offset: 0x2C
	private IMethodCallMessage _callMsg; //Field offset: 0x30
	private LogicalCallContext _callContext; //Field offset: 0x34
	private Identity _targetIdentity; //Field offset: 0x38
	protected IDictionary ExternalProperties; //Field offset: 0x3C
	protected IDictionary InternalProperties; //Field offset: 0x40

	public int ArgCount
	{
		 get { } //Length: 38
	}

	public object[] Args
	{
		 get { } //Length: 20
	}

	public Exception Exception
	{
		 get { } //Length: 6
	}

	public LogicalCallContext LogicalCallContext
	{
		 get { } //Length: 6
	}

	public MethodBase MethodBase
	{
		 get { } //Length: 69
	}

	public string MethodName
	{
		 get { } //Length: 170
	}

	public object MethodSignature
	{
		 get { } //Length: 84
	}

	public object[] OutArgs
	{
		 get { } //Length: 96
	}

	public virtual IDictionary Properties
	{
		 get { } //Length: 134
	}

	public object ReturnValue
	{
		 get { } //Length: 97
	}

	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.TargetIdentity
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	private string System.Runtime.Remoting.Messaging.IInternalMessage.Uri
	{
		 get { } //Length: 84
		 set { } //Length: 11
	}

	public string TypeName
	{
		 get { } //Length: 6
	}

	public string Uri
	{
		 get { } //Length: 84
		 set { } //Length: 221
	}

	internal MethodResponse(Exception e, IMethodCallMessage msg) { }

	internal MethodResponse(object returnValue, object[] outArgs, LogicalCallContext callCtx, IMethodCallMessage msg) { }

	internal MethodResponse(IMethodCallMessage msg, CADMethodReturnMessage retmsg) { }

	internal MethodResponse(SerializationInfo info, StreamingContext context) { }

	public int get_ArgCount() { }

	public object[] get_Args() { }

	public Exception get_Exception() { }

	public LogicalCallContext get_LogicalCallContext() { }

	public MethodBase get_MethodBase() { }

	public string get_MethodName() { }

	public object get_MethodSignature() { }

	public object[] get_OutArgs() { }

	public virtual IDictionary get_Properties() { }

	public object get_ReturnValue() { }

	public string get_TypeName() { }

	public string get_Uri() { }

	public object GetArg(int argNum) { }

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	internal void InitMethodProperty(string key, object value) { }

	public void set_Uri(string value) { }

	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity() { }

	private string System.Runtime.Remoting.Messaging.IInternalMessage.get_Uri() { }

	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(Identity value) { }

	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_Uri(string value) { }

}

