namespace System;

public class ResolveEventArgs : EventArgs
{
	private string m_Name; //Field offset: 0x8
	private Assembly m_Requesting; //Field offset: 0xC

	public ResolveEventArgs(string name) { }

	public ResolveEventArgs(string name, Assembly requestingAssembly) { }

}

