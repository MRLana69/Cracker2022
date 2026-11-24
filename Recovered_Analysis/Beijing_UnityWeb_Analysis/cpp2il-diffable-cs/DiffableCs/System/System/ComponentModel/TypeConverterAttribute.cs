namespace System.ComponentModel;

public sealed class TypeConverterAttribute : Attribute
{
	public static readonly TypeConverterAttribute Default; //Field offset: 0x0
	private string typeName; //Field offset: 0x8

	public string ConverterTypeName
	{
		 get { } //Length: 12
	}

	private static TypeConverterAttribute() { }

	public TypeConverterAttribute() { }

	public TypeConverterAttribute(Type type) { }

	public TypeConverterAttribute(string typeName) { }

	public override bool Equals(object obj) { }

	public string get_ConverterTypeName() { }

	public override int GetHashCode() { }

}

