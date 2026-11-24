namespace System.Runtime.Remoting;

public class ActivatedClientTypeEntry : TypeEntry
{
	private string applicationUrl; //Field offset: 0x10
	private Type obj_type; //Field offset: 0x14

	public string ApplicationUrl
	{
		 get { } //Length: 6
	}

	public IContextAttribute[] ContextAttributes
	{
		 get { } //Length: 6
	}

	public Type ObjectType
	{
		 get { } //Length: 3
	}

	public ActivatedClientTypeEntry(string typeName, string assemblyName, string appUrl) { }

	public string get_ApplicationUrl() { }

	public IContextAttribute[] get_ContextAttributes() { }

	public Type get_ObjectType() { }

	public override string ToString() { }

}

