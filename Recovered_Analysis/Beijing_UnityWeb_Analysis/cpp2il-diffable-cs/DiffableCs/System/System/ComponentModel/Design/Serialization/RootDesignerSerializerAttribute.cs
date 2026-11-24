namespace System.ComponentModel.Design.Serialization;

public sealed class RootDesignerSerializerAttribute : Attribute
{
	private bool reloadable; //Field offset: 0x8
	private string serializerTypeName; //Field offset: 0xC
	private string serializerBaseTypeName; //Field offset: 0x10

	public RootDesignerSerializerAttribute(string serializerTypeName, string baseSerializerTypeName, bool reloadable) { }

}

