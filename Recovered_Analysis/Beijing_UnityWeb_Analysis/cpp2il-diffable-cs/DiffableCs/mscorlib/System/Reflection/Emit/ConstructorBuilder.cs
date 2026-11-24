namespace System.Reflection.Emit;

public abstract class ConstructorBuilder : ConstructorInfo
{

	public override MethodAttributes Attributes
	{
		 get { } //Length: 13
	}

	public override Type DeclaringType
	{
		 get { } //Length: 73
	}

	public override RuntimeMethodHandle MethodHandle
	{
		 get { } //Length: 73
	}

	public override string Name
	{
		 get { } //Length: 73
	}

	public override Type ReflectedType
	{
		 get { } //Length: 49
	}

	public override MethodAttributes get_Attributes() { }

	public override Type get_DeclaringType() { }

	public override RuntimeMethodHandle get_MethodHandle() { }

	public override string get_Name() { }

	public override Type get_ReflectedType() { }

	public override object[] GetCustomAttributes(bool inherit) { }

	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	public override MethodImplAttributes GetMethodImplementationFlags() { }

	public override ParameterInfo[] GetParameters() { }

	public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	public override object Invoke(BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	public override bool IsDefined(Type attributeType, bool inherit) { }

}

