namespace System.Runtime.Remoting;

public class TypeEntry
{
	private string assembly_name; //Field offset: 0x8
	private string type_name; //Field offset: 0xC

	public string AssemblyName
	{
		 get { } //Length: 103
		 set { } //Length: 11
	}

	public string TypeName
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	protected TypeEntry() { }

	public string get_AssemblyName() { }

	public string get_TypeName() { }

	public void set_AssemblyName(string value) { }

	public void set_TypeName(string value) { }

}

