namespace System.Reflection.Emit;

public abstract class FieldBuilder : FieldInfo
{

	public override FieldAttributes Attributes
	{
		 get { } //Length: 49
	}

	public override Type DeclaringType
	{
		 get { } //Length: 73
	}

	public override RuntimeFieldHandle FieldHandle
	{
		 get { } //Length: 73
	}

	public override Type FieldType
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

	public override FieldAttributes get_Attributes() { }

	public override Type get_DeclaringType() { }

	public override RuntimeFieldHandle get_FieldHandle() { }

	public override Type get_FieldType() { }

	public override string get_Name() { }

	public override Type get_ReflectedType() { }

	public override object[] GetCustomAttributes(bool inherit) { }

	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	public override object GetValue(object obj) { }

	public override bool IsDefined(Type attributeType, bool inherit) { }

	public override void SetValue(object obj, object val, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }

}

