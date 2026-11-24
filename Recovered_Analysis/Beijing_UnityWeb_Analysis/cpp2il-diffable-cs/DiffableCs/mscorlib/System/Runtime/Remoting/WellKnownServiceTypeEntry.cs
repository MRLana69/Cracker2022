namespace System.Runtime.Remoting;

public class WellKnownServiceTypeEntry : TypeEntry
{
	private Type obj_type; //Field offset: 0x10
	private string obj_uri; //Field offset: 0x14
	private WellKnownObjectMode obj_mode; //Field offset: 0x18

	public WellKnownObjectMode Mode
	{
		 get { } //Length: 60
	}

	public Type ObjectType
	{
		 get { } //Length: 6
	}

	public string ObjectUri
	{
		 get { } //Length: 6
	}

	public WellKnownServiceTypeEntry(string typeName, string assemblyName, string objectUri, WellKnownObjectMode mode) { }

	public WellKnownObjectMode get_Mode() { }

	public Type get_ObjectType() { }

	public string get_ObjectUri() { }

	public override string ToString() { }

}

