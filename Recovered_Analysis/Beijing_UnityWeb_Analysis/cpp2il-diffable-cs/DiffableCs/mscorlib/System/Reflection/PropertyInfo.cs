namespace System.Reflection;

public abstract class PropertyInfo : MemberInfo, _PropertyInfo
{

	public abstract PropertyAttributes Attributes
	{
		 get { } //Length: 0
	}

	public abstract bool CanRead
	{
		 get { } //Length: 0
	}

	public abstract bool CanWrite
	{
		 get { } //Length: 0
	}

	public override MemberTypes MemberType
	{
		 get { } //Length: 73
	}

	public abstract Type PropertyType
	{
		 get { } //Length: 0
	}

	protected PropertyInfo() { }

	private static NotImplementedException CreateNIE() { }

	public override bool Equals(object obj) { }

	public abstract PropertyAttributes get_Attributes() { }

	public abstract bool get_CanRead() { }

	public abstract bool get_CanWrite() { }

	public override MemberTypes get_MemberType() { }

	public abstract Type get_PropertyType() { }

	public abstract MethodInfo[] GetAccessors(bool nonPublic) { }

	public virtual object GetConstantValue() { }

	public abstract MethodInfo GetGetMethod(bool nonPublic) { }

	public override int GetHashCode() { }

	public abstract ParameterInfo[] GetIndexParameters() { }

	public virtual Type[] GetOptionalCustomModifiers() { }

	internal static PropertyInfo GetPropertyFromHandle(RuntimePropertyHandle handle, RuntimeTypeHandle reflectedType) { }

	public virtual object GetRawConstantValue() { }

	public virtual Type[] GetRequiredCustomModifiers() { }

	public abstract MethodInfo GetSetMethod(bool nonPublic) { }

	public abstract object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) { }

	public virtual object GetValue(object obj, object[] index) { }

	private static PropertyInfo internal_from_handle_type(nint event_handle, nint type_handle) { }

	public static bool op_Equality(PropertyInfo left, PropertyInfo right) { }

	public static bool op_Inequality(PropertyInfo left, PropertyInfo right) { }

	public abstract void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) { }

	public virtual void SetValue(object obj, object value, object[] index) { }

}

