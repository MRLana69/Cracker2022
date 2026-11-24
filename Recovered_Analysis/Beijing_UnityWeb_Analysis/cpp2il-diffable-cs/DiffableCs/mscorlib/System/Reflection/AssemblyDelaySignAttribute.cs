namespace System.Reflection;

public sealed class AssemblyDelaySignAttribute : Attribute
{
	private bool m_delaySign; //Field offset: 0x8

	public AssemblyDelaySignAttribute(bool delaySign) { }

}

