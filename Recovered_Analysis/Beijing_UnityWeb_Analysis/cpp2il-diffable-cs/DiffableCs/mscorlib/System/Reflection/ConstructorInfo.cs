namespace System.Reflection;

public abstract class ConstructorInfo : MethodBase, _ConstructorInfo
{
	public static readonly string ConstructorName; //Field offset: 0x0
	public static readonly string TypeConstructorName; //Field offset: 0x4

	public override MemberTypes MemberType
	{
		 get { } //Length: 7
	}

	private static ConstructorInfo() { }

	protected ConstructorInfo() { }

	public override bool Equals(object obj) { }

	public override MemberTypes get_MemberType() { }

	public override int GetHashCode() { }

	public object Invoke(object[] parameters) { }

	public abstract object Invoke(BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	public static bool op_Equality(ConstructorInfo left, ConstructorInfo right) { }

	public static bool op_Inequality(ConstructorInfo left, ConstructorInfo right) { }

}

