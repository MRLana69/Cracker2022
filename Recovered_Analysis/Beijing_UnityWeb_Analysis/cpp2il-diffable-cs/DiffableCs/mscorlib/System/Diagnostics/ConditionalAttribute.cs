namespace System.Diagnostics;

public sealed class ConditionalAttribute : Attribute
{
	private string m_conditionString; //Field offset: 0x8

	public ConditionalAttribute(string conditionString) { }

}

