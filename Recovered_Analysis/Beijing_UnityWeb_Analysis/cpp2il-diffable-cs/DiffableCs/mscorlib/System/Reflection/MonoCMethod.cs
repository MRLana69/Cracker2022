namespace System.Reflection;

internal class MonoCMethod : RuntimeConstructorInfo
{
	internal nint mhandle; //Field offset: 0x8
	private string name; //Field offset: 0xC
	private Type reftype; //Field offset: 0x10

	public override MethodAttributes Attributes
	{
		 get { } //Length: 42
	}

	public override CallingConventions CallingConvention
	{
		 get { } //Length: 9
	}

	public override bool ContainsGenericParameters
	{
		 get { } //Length: 12
	}

	public override Type DeclaringType
	{
		 get { } //Length: 6
	}

	public override bool IsSecurityCritical
	{
		 get { } //Length: 9
	}

	public override RuntimeMethodHandle MethodHandle
	{
		 get { } //Length: 27
	}

	public override string Name
	{
		 get { } //Length: 12
	}

	public override Type ReflectedType
	{
		 get { } //Length: 16
	}

	public MonoCMethod() { }

	private object DoInvoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	public override MethodAttributes get_Attributes() { }

	public override CallingConventions get_CallingConvention() { }

	public override bool get_ContainsGenericParameters() { }

	private static int get_core_clr_security_level() { }

	public override Type get_DeclaringType() { }

	public override bool get_IsSecurityCritical() { }

	public override RuntimeMethodHandle get_MethodHandle() { }

	public override string get_Name() { }

	public override Type get_ReflectedType() { }

	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	public override object[] GetCustomAttributes(bool inherit) { }

	public override IList<CustomAttributeData> GetCustomAttributesData() { }

	public override MethodImplAttributes GetMethodImplementationFlags() { }

	public override ParameterInfo[] GetParameters() { }

	internal override int GetParametersCount() { }

	internal override ParameterInfo[] GetParametersInternal() { }

	public object InternalInvoke(object obj, object[] parameters) { }

	internal object InternalInvoke(object obj, object[] parameters, out Exception exc) { }

	public override object Invoke(BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	public override bool IsDefined(Type attributeType, bool inherit) { }

	public override string ToString() { }

}

