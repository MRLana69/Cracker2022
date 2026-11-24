namespace UnityEngine.Bindings;

internal class StaticAccessorAttribute : Attribute
{
	private string <Name>k__BackingField; //Field offset: 0x8
	private StaticAccessorType <Type>k__BackingField; //Field offset: 0xC

	public string Name
	{
		 set { } //Length: 11
	}

	public StaticAccessorType Type
	{
		 set { } //Length: 11
	}

	internal StaticAccessorAttribute(string name) { }

	public StaticAccessorAttribute(string name, StaticAccessorType type) { }

	public void set_Name(string value) { }

	public void set_Type(StaticAccessorType value) { }

}

