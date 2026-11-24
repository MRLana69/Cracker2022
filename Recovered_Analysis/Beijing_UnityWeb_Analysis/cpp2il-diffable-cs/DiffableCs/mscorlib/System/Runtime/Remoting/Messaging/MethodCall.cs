namespace System.Runtime.Remoting.Messaging;

public class MethodCall : IMethodCallMessage, IMethodMessage, IMessage, ISerializable, IInternalMessage
{
	private string _uri; //Field offset: 0x8
	private string _typeName; //Field offset: 0xC
	private string _methodName; //Field offset: 0x10
	private object[] _args; //Field offset: 0x14
	private Type[] _methodSignature; //Field offset: 0x18
	private MethodBase _methodBase; //Field offset: 0x1C
	private LogicalCallContext _callContext; //Field offset: 0x20
	private Identity _targetIdentity; //Field offset: 0x24
	private Type[] _genericArguments; //Field offset: 0x28
	protected IDictionary ExternalProperties; //Field offset: 0x2C
	protected IDictionary InternalProperties; //Field offset: 0x30

	public int ArgCount
	{
		 get { } //Length: 3
	}

	public object[] Args
	{
		 get { } //Length: 9
	}

	private Type[] GenericArguments
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
		 get { } //Length: 30
	}

	public object MethodSignature
	{
		 get { } //Length: 34
	}

	public virtual IDictionary Properties
	{
		 get { } //Length: 187
	}

	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.TargetIdentity
	{
		 get { } //Length: 107
		 set { } //Length: 11
	}

	private string System.Runtime.Remoting.Messaging.IInternalMessage.Uri
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public string TypeName
	{
		 get { } //Length: 23
	}

	public string Uri
	{
		 get { } //Length: 40
		 set { } //Length: 223
	}

	internal MethodCall(SerializationInfo info, StreamingContext context) { }

	internal MethodCall(CADMethodCallMessage msg) { }

	internal MethodCall() { }

	private Type CastTo(string clientType, Type serverType) { }

	internal void CopyFrom(IMethodMessage call) { }

	public int get_ArgCount() { }

	public object[] get_Args() { }

	private Type[] get_GenericArguments() { }

	public LogicalCallContext get_LogicalCallContext() { }

	public MethodBase get_MethodBase() { }

	public string get_MethodName() { }

	public object get_MethodSignature() { }

	public virtual IDictionary get_Properties() { }

	public string get_TypeName() { }

	public string get_Uri() { }

	public object GetArg(int argNum) { }

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	private static string GetTypeNameFromAssemblyQualifiedName(string aqname) { }

	public virtual void Init() { }

	internal virtual void InitDictionary() { }

	internal virtual void InitMethodProperty(string key, object value) { }

	public void ResolveMethod() { }

	public void set_Uri(string value) { }

	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity() { }

	private string System.Runtime.Remoting.Messaging.IInternalMessage.get_Uri() { }

	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(Identity value) { }

	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_Uri(string value) { }

}

