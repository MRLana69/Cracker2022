namespace System.ComponentModel;

public class DescriptionAttribute : Attribute
{
	public static readonly DescriptionAttribute Default; //Field offset: 0x0
	private string description; //Field offset: 0x8

	public virtual string Description
	{
		 get { } //Length: 9
	}

	protected string DescriptionValue
	{
		 get { } //Length: 6
	}

	private static DescriptionAttribute() { }

	public DescriptionAttribute() { }

	public DescriptionAttribute(string description) { }

	public override bool Equals(object obj) { }

	public virtual string get_Description() { }

	protected string get_DescriptionValue() { }

	public override int GetHashCode() { }

}

