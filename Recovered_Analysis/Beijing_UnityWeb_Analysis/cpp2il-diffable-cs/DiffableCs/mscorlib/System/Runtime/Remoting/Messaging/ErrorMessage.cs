namespace System.Runtime.Remoting.Messaging;

internal class ErrorMessage : IMethodCallMessage, IMethodMessage, IMessage
{
	private string _uri; //Field offset: 0x8

	public int ArgCount
	{
		 get { } //Length: 9
	}

	public object[] Args
	{
		 get { } //Length: 3
	}

	public LogicalCallContext LogicalCallContext
	{
		 get { } //Length: 6
	}

	public MethodBase MethodBase
	{
		 get { } //Length: 3
	}

	public string MethodName
	{
		 get { } //Length: 3
	}

	public object MethodSignature
	{
		 get { } //Length: 43
	}

	public virtual IDictionary Properties
	{
		 get { } //Length: 3
	}

	public string TypeName
	{
		 get { } //Length: 3
	}

	public string Uri
	{
		 get { } //Length: 43
	}

	public ErrorMessage() { }

	public int get_ArgCount() { }

	public object[] get_Args() { }

	public LogicalCallContext get_LogicalCallContext() { }

	public MethodBase get_MethodBase() { }

	public string get_MethodName() { }

	public object get_MethodSignature() { }

	public virtual IDictionary get_Properties() { }

	public string get_TypeName() { }

	public string get_Uri() { }

	public object GetArg(int arg_num) { }

}

