namespace System.ComponentModel;

public sealed class DesignerCategoryAttribute : Attribute
{
	public static readonly DesignerCategoryAttribute Component; //Field offset: 0x0
	public static readonly DesignerCategoryAttribute Default; //Field offset: 0x4
	public static readonly DesignerCategoryAttribute Form; //Field offset: 0x8
	public static readonly DesignerCategoryAttribute Generic; //Field offset: 0xC
	private string category; //Field offset: 0x8

	private static DesignerCategoryAttribute() { }

	public DesignerCategoryAttribute() { }

	public DesignerCategoryAttribute(string category) { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

}

