namespace System.ComponentModel;

public sealed class DefaultPropertyAttribute : Attribute
{
	public static readonly DefaultPropertyAttribute Default; //Field offset: 0x0
	private readonly string name; //Field offset: 0x8

	public string Name
	{
		 get { } //Length: 9
	}

	private static DefaultPropertyAttribute() { }

	public DefaultPropertyAttribute(string name) { }

	public override bool Equals(object obj) { }

	public string get_Name() { }

	public override int GetHashCode() { }

}

