namespace System.Runtime.Serialization;

internal sealed class SerializationFieldInfo : FieldInfo
{
	private RuntimeFieldInfo m_field; //Field offset: 0x8
	private string m_serializationName; //Field offset: 0xC

	public override FieldAttributes Attributes
	{
		 get { } //Length: 12
	}

	public override Type DeclaringType
	{
		 get { } //Length: 6
	}

	public override RuntimeFieldHandle FieldHandle
	{
		 get { } //Length: 6
	}

	internal RuntimeFieldInfo FieldInfo
	{
		 get { } //Length: 12
	}

	public override Type FieldType
	{
		 get { } //Length: 12
	}

	public override int MetadataToken
	{
		 get { } //Length: 12
	}

	public override Module Module
	{
		 get { } //Length: 890
	}

	public override string Name
	{
		 get { } //Length: 12
	}

	public override Type ReflectedType
	{
		 get { } //Length: 12
	}

	internal SerializationFieldInfo(RuntimeFieldInfo field, string namePrefix) { }

	public override FieldAttributes get_Attributes() { }

	public override Type get_DeclaringType() { }

	public override RuntimeFieldHandle get_FieldHandle() { }

	internal RuntimeFieldInfo get_FieldInfo() { }

	public override Type get_FieldType() { }

	public override int get_MetadataToken() { }

	public override Module get_Module() { }

	public override string get_Name() { }

	public override Type get_ReflectedType() { }

	public override object[] GetCustomAttributes(bool inherit) { }

	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	public override object GetValue(object obj) { }

	internal object InternalGetValue(object obj) { }

	internal void InternalSetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }

	public override bool IsDefined(Type attributeType, bool inherit) { }

	public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }

}

