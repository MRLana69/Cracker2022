namespace System.ComponentModel;

public sealed class NotifyParentPropertyAttribute : Attribute
{
	public static readonly NotifyParentPropertyAttribute Yes; //Field offset: 0x0
	public static readonly NotifyParentPropertyAttribute No; //Field offset: 0x4
	public static readonly NotifyParentPropertyAttribute Default; //Field offset: 0x8
	private bool notifyParent; //Field offset: 0x8

	public bool NotifyParent
	{
		 get { } //Length: 280
	}

	private static NotifyParentPropertyAttribute() { }

	public NotifyParentPropertyAttribute(bool notifyParent) { }

	public override bool Equals(object obj) { }

	public bool get_NotifyParent() { }

	public override int GetHashCode() { }

}

