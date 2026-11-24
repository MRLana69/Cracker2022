namespace System.Runtime.CompilerServices;

public sealed class DecimalConstantAttribute : Attribute
{
	private decimal dec; //Field offset: 0x8

	public decimal Value
	{
		 get { } //Length: 8
	}

	public DecimalConstantAttribute(byte scale, byte sign, uint hi, uint mid, uint low) { }

	public decimal get_Value() { }

}

