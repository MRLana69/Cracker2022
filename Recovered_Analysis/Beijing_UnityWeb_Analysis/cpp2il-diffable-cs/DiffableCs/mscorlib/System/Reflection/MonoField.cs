namespace System.Reflection;

internal class MonoField : RtFieldInfo
{
	internal nint klass; //Field offset: 0x8
	internal RuntimeFieldHandle fhandle; //Field offset: 0xC
	private string name; //Field offset: 0x10
	private Type type; //Field offset: 0x14
	private FieldAttributes attrs; //Field offset: 0x18

	public override FieldAttributes Attributes
	{
		 get { } //Length: 13
	}

	public override Type DeclaringType
	{
		 get { } //Length: 11
	}

	public override RuntimeFieldHandle FieldHandle
	{
		 get { } //Length: 6
	}

	public override Type FieldType
	{
		 get { } //Length: 42
	}

	public override string Name
	{
		 get { } //Length: 11
	}

	public override Type ReflectedType
	{
		 get { } //Length: 134
	}

	public MonoField() { }

	private void CheckGeneric() { }

	public override FieldAttributes get_Attributes() { }

	public override Type get_DeclaringType() { }

	public override RuntimeFieldHandle get_FieldHandle() { }

	public override Type get_FieldType() { }

	public override string get_Name() { }

	public override Type get_ReflectedType() { }

	public override object[] GetCustomAttributes(bool inherit) { }

	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	public override IList<CustomAttributeData> GetCustomAttributesData() { }

	internal override int GetFieldOffset() { }

	private Type GetParentType(bool declaring) { }

	public override object GetRawConstantValue() { }

	public override object GetValue(object obj) { }

	private object GetValueInternal(object obj) { }

	public override bool IsDefined(Type attributeType, bool inherit) { }

	private Type ResolveType() { }

	public override void SetValue(object obj, object val, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }

	private static void SetValueInternal(FieldInfo fi, object obj, object value) { }

	public override string ToString() { }

}

