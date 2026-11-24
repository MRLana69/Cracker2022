namespace System.Runtime.Remoting;

public class WellKnownClientTypeEntry : TypeEntry
{
	private Type obj_type; //Field offset: 0x10
	private string obj_url; //Field offset: 0x14
	private string app_url; //Field offset: 0x18

	public string ApplicationUrl
	{
		 get { } //Length: 6
	}

	public Type ObjectType
	{
		 get { } //Length: 6
	}

	public string ObjectUrl
	{
		 get { } //Length: 6
	}

	public WellKnownClientTypeEntry(string typeName, string assemblyName, string objectUrl) { }

	public string get_ApplicationUrl() { }

	public Type get_ObjectType() { }

	public string get_ObjectUrl() { }

	public override string ToString() { }

}

