namespace System.ComponentModel;

public class DefaultValueAttribute : Attribute
{
	private object value; //Field offset: 0x8

	public virtual object Value
	{
		 get { } //Length: 9
	}

	public DefaultValueAttribute(bool value) { }

	public DefaultValueAttribute(string value) { }

	public DefaultValueAttribute(object value) { }

	public override bool Equals(object obj) { }

	public virtual object get_Value() { }

	public override int GetHashCode() { }

}

