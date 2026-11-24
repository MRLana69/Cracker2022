namespace System;

public class AssemblyLoadEventArgs : EventArgs
{
	private Assembly m_loadedAssembly; //Field offset: 0x8

	public AssemblyLoadEventArgs(Assembly loadedAssembly) { }

}

