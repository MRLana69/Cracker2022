namespace System.Reflection;

public abstract class MethodBase : MemberInfo, _MethodBase
{

	public abstract MethodAttributes Attributes
	{
		 get { } //Length: 0
	}

	public virtual CallingConventions CallingConvention
	{
		 get { } //Length: 9
	}

	public virtual bool ContainsGenericParameters
	{
		 get { } //Length: 3
	}

	public bool IsAbstract
	{
		 get { } //Length: 16
	}

	public bool IsConstructor
	{
		 get { } //Length: 16
	}

	public virtual bool IsGenericMethod
	{
		 get { } //Length: 3
	}

	public virtual bool IsGenericMethodDefinition
	{
		 get { } //Length: 85
	}

	public bool IsPublic
	{
		 get { } //Length: 73
	}

	public virtual bool IsSecurityCritical
	{
		 get { } //Length: 3
	}

	public bool IsStatic
	{
		 get { } //Length: 15
	}

	public bool IsVirtual
	{
		 get { } //Length: 15
	}

	public abstract RuntimeMethodHandle MethodHandle
	{
		 get { } //Length: 0
	}

	protected MethodBase() { }

	internal static string ConstructParameters(Type[] parameterTypes, CallingConventions callingConvention, bool serialization) { }

	public override bool Equals(object obj) { }

	internal virtual string FormatNameAndSig(bool serialization) { }

	public abstract MethodAttributes get_Attributes() { }

	public virtual CallingConventions get_CallingConvention() { }

	public virtual bool get_ContainsGenericParameters() { }

	public bool get_IsAbstract() { }

	public bool get_IsConstructor() { }

	public virtual bool get_IsGenericMethod() { }

	public virtual bool get_IsGenericMethodDefinition() { }

	public bool get_IsPublic() { }

	public virtual bool get_IsSecurityCritical() { }

	public bool get_IsStatic() { }

	public bool get_IsVirtual() { }

	public abstract RuntimeMethodHandle get_MethodHandle() { }

	public virtual Type[] GetGenericArguments() { }

	public override int GetHashCode() { }

	public static MethodBase GetMethodFromHandle(RuntimeMethodHandle handle) { }

	private static MethodBase GetMethodFromHandleInternalType(nint method_handle, nint type_handle) { }

	internal static MethodBase GetMethodFromHandleInternalType_native(nint method_handle, nint type_handle, bool genericCheck) { }

	internal static MethodBase GetMethodFromHandleNoGenericCheck(RuntimeMethodHandle handle) { }

	internal static MethodBase GetMethodFromHandleNoGenericCheck(RuntimeMethodHandle handle, RuntimeTypeHandle reflectedType) { }

	public abstract MethodImplAttributes GetMethodImplementationFlags() { }

	public abstract ParameterInfo[] GetParameters() { }

	internal virtual int GetParametersCount() { }

	internal virtual ParameterInfo[] GetParametersInternal() { }

	internal virtual ParameterInfo[] GetParametersNoCopy() { }

	internal virtual Type[] GetParameterTypes() { }

	public abstract object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	public object Invoke(object obj, object[] parameters) { }

	public static bool op_Equality(MethodBase left, MethodBase right) { }

	public static bool op_Inequality(MethodBase left, MethodBase right) { }

}

