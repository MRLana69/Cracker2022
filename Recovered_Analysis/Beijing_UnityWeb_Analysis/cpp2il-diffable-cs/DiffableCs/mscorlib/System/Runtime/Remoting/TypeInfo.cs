namespace System.Runtime.Remoting;

internal class TypeInfo : IRemotingTypeInfo
{
	private string serverType; //Field offset: 0x8
	private string[] serverHierarchy; //Field offset: 0xC
	private string[] interfacesImplemented; //Field offset: 0x10

	public string TypeName
	{
		 get { } //Length: 6
	}

	public TypeInfo(Type type) { }

	public bool CanCastTo(Type fromType, object o) { }

	public string get_TypeName() { }

}

