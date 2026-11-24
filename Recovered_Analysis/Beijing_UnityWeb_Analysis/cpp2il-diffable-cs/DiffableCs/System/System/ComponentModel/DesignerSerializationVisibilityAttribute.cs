namespace System.ComponentModel;

public sealed class DesignerSerializationVisibilityAttribute : Attribute
{
	public static readonly DesignerSerializationVisibilityAttribute Content; //Field offset: 0x0
	public static readonly DesignerSerializationVisibilityAttribute Hidden; //Field offset: 0x4
	public static readonly DesignerSerializationVisibilityAttribute Visible; //Field offset: 0x8
	public static readonly DesignerSerializationVisibilityAttribute Default; //Field offset: 0xC
	private DesignerSerializationVisibility visibility; //Field offset: 0x8

	public DesignerSerializationVisibility Visibility
	{
		 get { } //Length: 12
	}

	private static DesignerSerializationVisibilityAttribute() { }

	public DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility visibility) { }

	public override bool Equals(object obj) { }

	public DesignerSerializationVisibility get_Visibility() { }

	public override int GetHashCode() { }

}

