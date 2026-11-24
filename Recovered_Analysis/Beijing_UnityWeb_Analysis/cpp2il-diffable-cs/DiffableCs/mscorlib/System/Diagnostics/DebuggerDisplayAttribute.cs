namespace System.Diagnostics;

public sealed class DebuggerDisplayAttribute : Attribute
{
	private string name; //Field offset: 0x8
	private string value; //Field offset: 0xC
	private string type; //Field offset: 0x10

	public DebuggerDisplayAttribute(string value) { }

}

