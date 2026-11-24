namespace System.Diagnostics;

public sealed class DebuggerBrowsableAttribute : Attribute
{
	private DebuggerBrowsableState state; //Field offset: 0x8

	public DebuggerBrowsableAttribute(DebuggerBrowsableState state) { }

}

