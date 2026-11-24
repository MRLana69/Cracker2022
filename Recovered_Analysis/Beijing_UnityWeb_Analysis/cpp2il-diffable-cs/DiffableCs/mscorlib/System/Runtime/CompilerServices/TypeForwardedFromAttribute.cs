namespace System.Runtime.CompilerServices;

public sealed class TypeForwardedFromAttribute : Attribute
{
	private string assemblyFullName; //Field offset: 0x8

	public string AssemblyFullName
	{
		 get { } //Length: 12
	}

	public TypeForwardedFromAttribute(string assemblyFullName) { }

	public string get_AssemblyFullName() { }

}

