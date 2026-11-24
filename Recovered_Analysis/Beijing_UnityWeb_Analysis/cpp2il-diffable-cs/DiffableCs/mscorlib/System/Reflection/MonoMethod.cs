namespace System.Reflection;

internal class MonoMethod : RuntimeMethodInfo
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
		 get { } //Length: 7
	}

	public override Type DeclaringType
	{
		 get { } //Length: 6
	}

	public override bool IsGenericMethod
	{
		 get { } //Length: 15
	}

	public override bool IsGenericMethodDefinition
	{
		 get { } //Length: 96
	}

	public override bool IsSecurityCritical
	{
		 get { } //Length: 9
	}

	public override RuntimeMethodHandle MethodHandle
	{
		 get { } //Length: 17
	}

	public override string Name
	{
		 get { } //Length: 12
	}

	public override Type ReflectedType
	{
		 get { } //Length: 12
	}

	public override Type ReturnType
	{
		 get { } //Length: 11
	}

	internal MonoMethod() { }

	internal static void ConvertValues(Binder binder, object[] args, ParameterInfo[] pinfo, CultureInfo culture, BindingFlags invokeAttr) { }

	public override MethodAttributes get_Attributes() { }

	internal static MonoMethod get_base_method(MonoMethod method, bool definition) { }

	public override CallingConventions get_CallingConvention() { }

	public override bool get_ContainsGenericParameters() { }

	private static int get_core_clr_security_level() { }

	public override Type get_DeclaringType() { }

	public override bool get_IsGenericMethod() { }

	public override bool get_IsGenericMethodDefinition() { }

	public override bool get_IsSecurityCritical() { }

	public override RuntimeMethodHandle get_MethodHandle() { }

	internal static string get_name(MethodBase method) { }

	public override string get_Name() { }

	public override Type get_ReflectedType() { }

	public override Type get_ReturnType() { }

	internal override MethodInfo GetBaseMethod() { }

	public override object[] GetCustomAttributes(bool inherit) { }

	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	public override IList<CustomAttributeData> GetCustomAttributesData() { }

	public override Type[] GetGenericArguments() { }

	public override MethodInfo GetGenericMethodDefinition() { }

	private MethodInfo GetGenericMethodDefinition_impl() { }

	public override MethodImplAttributes GetMethodImplementationFlags() { }

	public override ParameterInfo[] GetParameters() { }

	internal override int GetParametersCount() { }

	internal override ParameterInfo[] GetParametersInternal() { }

	internal void GetPInvoke(out PInvokeAttributes flags, out string entryPoint, out string dllName) { }

	internal object[] GetPseudoCustomAttributes() { }

	internal object InternalInvoke(object obj, object[] parameters, out Exception exc) { }

	public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	public override bool IsDefined(Type attributeType, bool inherit) { }

	public override MethodInfo MakeGenericMethod(Type[] methodInstantiation) { }

	private MethodInfo MakeGenericMethod_impl(Type[] types) { }

}

