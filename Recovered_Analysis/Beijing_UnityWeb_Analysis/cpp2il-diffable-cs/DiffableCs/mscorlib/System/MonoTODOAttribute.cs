namespace System;

internal class MonoTODOAttribute : Attribute
{
	private string comment; //Field offset: 0x8

	public MonoTODOAttribute() { }

	public MonoTODOAttribute(string comment) { }

}

