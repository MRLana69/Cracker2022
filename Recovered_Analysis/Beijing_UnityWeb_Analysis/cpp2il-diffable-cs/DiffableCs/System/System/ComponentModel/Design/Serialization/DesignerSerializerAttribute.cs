namespace System.ComponentModel.Design.Serialization;

public sealed class DesignerSerializerAttribute : Attribute
{
	private string serializerTypeName; //Field offset: 0x8
	private string serializerBaseTypeName; //Field offset: 0xC

	public DesignerSerializerAttribute(string serializerTypeName, string baseSerializerTypeName) { }

}

