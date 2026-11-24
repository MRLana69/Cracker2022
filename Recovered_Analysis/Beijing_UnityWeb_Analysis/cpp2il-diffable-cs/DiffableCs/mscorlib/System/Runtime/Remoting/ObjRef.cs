namespace System.Runtime.Remoting;

public class ObjRef : IObjectReference, ISerializable
{
	private static int MarshalledObjectRef; //Field offset: 0x0
	private static int WellKnowObjectRef; //Field offset: 0x4
	private IChannelInfo channel_info; //Field offset: 0x8
	private string uri; //Field offset: 0xC
	private IRemotingTypeInfo typeInfo; //Field offset: 0x10
	private IEnvoyInfo envoyInfo; //Field offset: 0x14
	private int flags; //Field offset: 0x18
	private Type _serverType; //Field offset: 0x1C

	public virtual IChannelInfo ChannelInfo
	{
		 get { } //Length: 102
	}

	public virtual IEnvoyInfo EnvoyInfo
	{
		 get { } //Length: 6
		 set { } //Length: 67
	}

	internal bool IsReferenceToWellKnow
	{
		 get { } //Length: 108
	}

	internal Type ServerType
	{
		 get { } //Length: 6
	}

	public virtual IRemotingTypeInfo TypeInfo
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public virtual string URI
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	private static ObjRef() { }

	protected ObjRef(SerializationInfo info, StreamingContext context) { }

	internal ObjRef(Type type, string url, object remoteChannelData) { }

	public ObjRef() { }

	internal ObjRef(string uri, IChannelInfo cinfo) { }

	internal ObjRef DeserializeInTheCurrentDomain(int domainId, byte[] tInfo) { }

	public virtual IChannelInfo get_ChannelInfo() { }

	public virtual IEnvoyInfo get_EnvoyInfo() { }

	internal bool get_IsReferenceToWellKnow() { }

	internal Type get_ServerType() { }

	public virtual IRemotingTypeInfo get_TypeInfo() { }

	public virtual string get_URI() { }

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	public virtual object GetRealObject(StreamingContext context) { }

	internal byte[] SerializeType() { }

	public virtual void set_EnvoyInfo(IEnvoyInfo value) { }

	public virtual void set_TypeInfo(IRemotingTypeInfo value) { }

	public virtual void set_URI(string value) { }

	internal void UpdateChannelInfo() { }

}

