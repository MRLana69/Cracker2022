namespace UnityEngine.Internal;

public class DefaultValueAttribute : Attribute
{
	private object DefaultValue; //Field offset: 0x8

	public object Value
	{
		 get { } //Length: 12
	}

	public DefaultValueAttribute(string value) { }

	public override bool Equals(object obj) { }

	public object get_Value() { }

	public override int GetHashCode() { }

}

