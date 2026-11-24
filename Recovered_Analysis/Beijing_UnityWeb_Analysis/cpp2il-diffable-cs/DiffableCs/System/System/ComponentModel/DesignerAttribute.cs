namespace System.ComponentModel;

public sealed class DesignerAttribute : Attribute
{
	private readonly string designerTypeName; //Field offset: 0x8
	private readonly string designerBaseTypeName; //Field offset: 0xC

	public DesignerAttribute(string designerTypeName) { }

	public DesignerAttribute(string designerTypeName, Type designerBaseType) { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

}

