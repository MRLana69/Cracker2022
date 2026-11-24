namespace System.Runtime.CompilerServices;

public sealed class InternalsVisibleToAttribute : Attribute
{
	private string _assemblyName; //Field offset: 0x8
	private bool _allInternalsVisible; //Field offset: 0xC

	public bool AllInternalsVisible
	{
		 get { } //Length: 6
		 set { } //Length: 18
	}

	public string AssemblyName
	{
		 get { } //Length: 6
	}

	public InternalsVisibleToAttribute(string assemblyName) { }

	public bool get_AllInternalsVisible() { }

	public string get_AssemblyName() { }

	public void set_AllInternalsVisible(bool value) { }

}

