namespace System.Runtime.CompilerServices;

public abstract class CustomConstantAttribute : Attribute
{

	public abstract object Value
	{
		 get { } //Length: 0
	}

	protected CustomConstantAttribute() { }

	public abstract object get_Value() { }

}

