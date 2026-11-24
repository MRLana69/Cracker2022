namespace System.ComponentModel;

public sealed class DefaultEventAttribute : Attribute
{
	public static readonly DefaultEventAttribute Default; //Field offset: 0x0
	private readonly string name; //Field offset: 0x8

	public string Name
	{
		 get { } //Length: 112
	}

	private static DefaultEventAttribute() { }

	public DefaultEventAttribute(string name) { }

	public override bool Equals(object obj) { }

	public string get_Name() { }

	public override int GetHashCode() { }

}

