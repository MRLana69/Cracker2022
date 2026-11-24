namespace System.Runtime.Remoting.Messaging;

public class ConstructionCall : MethodCall, IConstructionCallMessage, IMessage, IMethodCallMessage, IMethodMessage
{
	private IActivator _activator; //Field offset: 0x34
	private object[] _activationAttributes; //Field offset: 0x38
	private IList _contextProperties; //Field offset: 0x3C
	private Type _activationType; //Field offset: 0x40
	private string _activationTypeName; //Field offset: 0x44
	private bool _isContextOk; //Field offset: 0x48
	private RemotingProxy _sourceProxy; //Field offset: 0x4C

	public Type ActivationType
	{
		 get { } //Length: 9
	}

	public string ActivationTypeName
	{
		 get { } //Length: 156
	}

	public IActivator Activator
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public object[] CallSiteActivationAttributes
	{
		 get { } //Length: 6
	}

	public IList ContextProperties
	{
		 get { } //Length: 6
	}

	internal bool IsContextOk
	{
		 get { } //Length: 6
		 set { } //Length: 35
	}

	public override IDictionary Properties
	{
		 get { } //Length: 79
	}

	internal RemotingProxy SourceProxy
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	internal ConstructionCall(Type type) { }

	internal ConstructionCall(SerializationInfo info, StreamingContext context) { }

	public Type get_ActivationType() { }

	public string get_ActivationTypeName() { }

	public IActivator get_Activator() { }

	public object[] get_CallSiteActivationAttributes() { }

	public IList get_ContextProperties() { }

	internal bool get_IsContextOk() { }

	public override IDictionary get_Properties() { }

	internal RemotingProxy get_SourceProxy() { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	internal override void InitDictionary() { }

	internal override void InitMethodProperty(string key, object value) { }

	public void set_Activator(IActivator value) { }

	internal void set_IsContextOk(bool value) { }

	internal void set_SourceProxy(RemotingProxy value) { }

	internal void SetActivationAttributes(object[] attributes) { }

}

