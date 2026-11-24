namespace System.Runtime.Remoting.Messaging;

public class ReturnMessage : IMethodReturnMessage, IMethodMessage, IMessage, IInternalMessage
{
	private object[] _outArgs; //Field offset: 0x8
	private object[] _args; //Field offset: 0xC
	private LogicalCallContext _callCtx; //Field offset: 0x10
	private object _returnValue; //Field offset: 0x14
	private string _uri; //Field offset: 0x18
	private Exception _exception; //Field offset: 0x1C
	private MethodBase _methodBase; //Field offset: 0x20
	private string _methodName; //Field offset: 0x24
	private Type[] _methodSignature; //Field offset: 0x28
	private string _typeName; //Field offset: 0x2C
	private MethodReturnDictionary _properties; //Field offset: 0x30
	private Identity _targetIdentity; //Field offset: 0x34
	private ArgInfo _inArgInfo; //Field offset: 0x38

	public int ArgCount
	{
		 get { } //Length: 106
	}

	public object[] Args
	{
		 get { } //Length: 9
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
		 get { } //Length: 6
	}

	public object MethodSignature
	{
		 get { } //Length: 50
	}

	public object[] OutArgs
	{
		 get { } //Length: 6
	}

	public virtual IDictionary Properties
	{
		 get { } //Length: 187
	}

	public virtual object ReturnValue
	{
		 get { } //Length: 131
	}

	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.TargetIdentity
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	private string System.Runtime.Remoting.Messaging.IInternalMessage.Uri
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public string TypeName
	{
		 get { } //Length: 81
	}

	public string Uri
	{
		 get { } //Length: 56
		 set { } //Length: 11
	}

	public ReturnMessage(object ret, object[] outArgs, int outArgsCount, LogicalCallContext callCtx, IMethodCallMessage mcm) { }

	public ReturnMessage(Exception e, IMethodCallMessage mcm) { }

	public int get_ArgCount() { }

	public object[] get_Args() { }

	public Exception get_Exception() { }

	public LogicalCallContext get_LogicalCallContext() { }

	public MethodBase get_MethodBase() { }

	public string get_MethodName() { }

	public object get_MethodSignature() { }

	public object[] get_OutArgs() { }

	public virtual IDictionary get_Properties() { }

	public virtual object get_ReturnValue() { }

	public string get_TypeName() { }

	public string get_Uri() { }

	public object GetArg(int argNum) { }

	public void set_Uri(string value) { }

	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity() { }

	private string System.Runtime.Remoting.Messaging.IInternalMessage.get_Uri() { }

	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(Identity value) { }

	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_Uri(string value) { }

}

