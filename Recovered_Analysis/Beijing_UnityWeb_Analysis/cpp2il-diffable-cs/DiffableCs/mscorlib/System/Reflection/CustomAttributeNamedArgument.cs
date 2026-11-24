namespace System.Reflection;

public struct CustomAttributeNamedArgument
{
	private CustomAttributeTypedArgument typedArgument; //Field offset: 0x0
	private MemberInfo memberInfo; //Field offset: 0x8

	public CustomAttributeNamedArgument(MemberInfo memberInfo, object value) { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	public override string ToString() { }

}

