namespace System.Reflection;

public abstract class MethodInfo : MethodBase, _MethodInfo
{

	public override MemberTypes MemberType
	{
		 get { } //Length: 13
	}

	public virtual Type ReturnType
	{
		 get { } //Length: 3
	}

	protected MethodInfo() { }

	public override bool Equals(object obj) { }

	public override MemberTypes get_MemberType() { }

	public virtual Type get_ReturnType() { }

	internal virtual MethodInfo GetBaseMethod() { }

	public override Type[] GetGenericArguments() { }

	public virtual MethodInfo GetGenericMethodDefinition() { }

	public override int GetHashCode() { }

	public virtual MethodInfo MakeGenericMethod(Type[] typeArguments) { }

	public static bool op_Equality(MethodInfo left, MethodInfo right) { }

	public static bool op_Inequality(MethodInfo left, MethodInfo right) { }

}

