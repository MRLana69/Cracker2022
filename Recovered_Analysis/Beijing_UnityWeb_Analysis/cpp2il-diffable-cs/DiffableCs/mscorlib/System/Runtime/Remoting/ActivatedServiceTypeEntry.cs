namespace System.Runtime.Remoting;

public class ActivatedServiceTypeEntry : TypeEntry
{
	private Type obj_type; //Field offset: 0x10

	public Type ObjectType
	{
		 get { } //Length: 22
	}

	public ActivatedServiceTypeEntry(string typeName, string assemblyName) { }

	public Type get_ObjectType() { }

	public override string ToString() { }

}

