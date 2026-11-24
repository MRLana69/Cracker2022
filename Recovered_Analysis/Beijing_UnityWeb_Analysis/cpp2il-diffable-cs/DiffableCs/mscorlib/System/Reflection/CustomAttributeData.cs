namespace System.Reflection;

public class CustomAttributeData
{
	private class LazyCAttrData
	{
		internal Assembly assembly; //Field offset: 0x8
		internal nint data; //Field offset: 0xC
		internal uint data_length; //Field offset: 0x10

		public LazyCAttrData() { }

	}

	private ConstructorInfo ctorInfo; //Field offset: 0x8
	private IList<CustomAttributeTypedArgument> ctorArgs; //Field offset: 0xC
	private IList<CustomAttributeNamedArgument> namedArgs; //Field offset: 0x10
	private LazyCAttrData lazyData; //Field offset: 0x14

	public Type AttributeType
	{
		 get { } //Length: 79
	}

	public virtual ConstructorInfo Constructor
	{
		 get { } //Length: 13
	}

	public virtual IList<CustomAttributeTypedArgument> ConstructorArguments
	{
		 get { } //Length: 6
	}

	public virtual IList<CustomAttributeNamedArgument> NamedArguments
	{
		 get { } //Length: 14
	}

	protected CustomAttributeData() { }

	internal CustomAttributeData(ConstructorInfo ctorInfo, Assembly assembly, nint data, uint data_length) { }

	public override bool Equals(object obj) { }

	public Type get_AttributeType() { }

	public virtual ConstructorInfo get_Constructor() { }

	public virtual IList<CustomAttributeTypedArgument> get_ConstructorArguments() { }

	public virtual IList<CustomAttributeNamedArgument> get_NamedArguments() { }

	public static IList<CustomAttributeData> GetCustomAttributes(ParameterInfo target) { }

	public static IList<CustomAttributeData> GetCustomAttributes(Module target) { }

	public static IList<CustomAttributeData> GetCustomAttributes(MemberInfo target) { }

	public static IList<CustomAttributeData> GetCustomAttributes(Assembly target) { }

	internal static IList<CustomAttributeData> GetCustomAttributesInternal(RuntimeType target) { }

	public override int GetHashCode() { }

	private void ResolveArguments() { }

	private static void ResolveArgumentsInternal(ConstructorInfo ctor, Assembly assembly, nint data, uint data_length, out object[] ctorArgs, out object[] namedArgs) { }

	public override string ToString() { }

	private static T[] UnboxValues(object[] values) { }

}

