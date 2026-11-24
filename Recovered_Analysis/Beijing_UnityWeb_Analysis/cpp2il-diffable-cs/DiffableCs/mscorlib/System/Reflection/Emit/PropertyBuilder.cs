namespace System.Reflection.Emit;

public abstract class PropertyBuilder : PropertyInfo
{

	public override PropertyAttributes Attributes
	{
		 get { } //Length: 49
	}

	public override bool CanRead
	{
		 get { } //Length: 73
	}

	public override bool CanWrite
	{
		 get { } //Length: 73
	}

	public override Type DeclaringType
	{
		 get { } //Length: 73
	}

	public override string Name
	{
		 get { } //Length: 73
	}

	public override Type PropertyType
	{
		 get { } //Length: 73
	}

	public override Type ReflectedType
	{
		 get { } //Length: 73
	}

	public override PropertyAttributes get_Attributes() { }

	public override bool get_CanRead() { }

	public override bool get_CanWrite() { }

	public override Type get_DeclaringType() { }

	public override string get_Name() { }

	public override Type get_PropertyType() { }

	public override Type get_ReflectedType() { }

	public override MethodInfo[] GetAccessors(bool nonPublic) { }

	public override object[] GetCustomAttributes(bool inherit) { }

	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	public override MethodInfo GetGetMethod(bool nonPublic) { }

	public override ParameterInfo[] GetIndexParameters() { }

	public override MethodInfo GetSetMethod(bool nonPublic) { }

	public override object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) { }

	public override bool IsDefined(Type attributeType, bool inherit) { }

	public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) { }

}

