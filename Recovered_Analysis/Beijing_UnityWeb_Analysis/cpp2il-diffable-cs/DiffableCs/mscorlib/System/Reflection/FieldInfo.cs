namespace System.Reflection;

public abstract class FieldInfo : MemberInfo, _FieldInfo
{

	public abstract FieldAttributes Attributes
	{
		 get { } //Length: 0
	}

	public abstract RuntimeFieldHandle FieldHandle
	{
		 get { } //Length: 0
	}

	public abstract Type FieldType
	{
		 get { } //Length: 0
	}

	public bool IsInitOnly
	{
		 get { } //Length: 15
	}

	public bool IsLiteral
	{
		 get { } //Length: 3
	}

	public bool IsNotSerialized
	{
		 get { } //Length: 15
	}

	public bool IsPublic
	{
		 get { } //Length: 15
	}

	public bool IsStatic
	{
		 get { } //Length: 16
	}

	public override MemberTypes MemberType
	{
		 get { } //Length: 440
	}

	protected FieldInfo() { }

	public override bool Equals(object obj) { }

	public abstract FieldAttributes get_Attributes() { }

	public abstract RuntimeFieldHandle get_FieldHandle() { }

	public abstract Type get_FieldType() { }

	public bool get_IsInitOnly() { }

	public bool get_IsLiteral() { }

	public bool get_IsNotSerialized() { }

	public bool get_IsPublic() { }

	public bool get_IsStatic() { }

	private MarshalAsAttribute get_marshal_info() { }

	public override MemberTypes get_MemberType() { }

	public static FieldInfo GetFieldFromHandle(RuntimeFieldHandle handle) { }

	public static FieldInfo GetFieldFromHandle(RuntimeFieldHandle handle, RuntimeTypeHandle declaringType) { }

	internal virtual int GetFieldOffset() { }

	public override int GetHashCode() { }

	internal object[] GetPseudoCustomAttributes() { }

	public virtual object GetRawConstantValue() { }

	public abstract object GetValue(object obj) { }

	private static FieldInfo internal_from_handle_type(nint field_handle, nint type_handle) { }

	public static bool op_Equality(FieldInfo left, FieldInfo right) { }

	public static bool op_Inequality(FieldInfo left, FieldInfo right) { }

	public abstract void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }

	public void SetValue(object obj, object value) { }

	public virtual void SetValueDirect(TypedReference obj, object value) { }

}

