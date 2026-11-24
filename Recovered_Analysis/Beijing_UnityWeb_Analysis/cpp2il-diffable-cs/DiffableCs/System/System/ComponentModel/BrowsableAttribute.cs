namespace System.ComponentModel;

public sealed class BrowsableAttribute : Attribute
{
	public static readonly BrowsableAttribute Yes; //Field offset: 0x0
	public static readonly BrowsableAttribute No; //Field offset: 0x4
	public static readonly BrowsableAttribute Default; //Field offset: 0x8
	private bool browsable; //Field offset: 0x8

	public bool Browsable
	{
		 get { } //Length: 9
	}

	private static BrowsableAttribute() { }

	public BrowsableAttribute(bool browsable) { }

	public override bool Equals(object obj) { }

	public bool get_Browsable() { }

	public override int GetHashCode() { }

}

