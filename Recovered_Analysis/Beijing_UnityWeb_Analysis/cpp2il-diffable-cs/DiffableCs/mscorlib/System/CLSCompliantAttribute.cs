namespace System;

public sealed class CLSCompliantAttribute : Attribute
{
	private bool m_compliant; //Field offset: 0x8

	public CLSCompliantAttribute(bool isCompliant) { }

}

