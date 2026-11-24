namespace System.Runtime.CompilerServices;

public sealed class FixedBufferAttribute : Attribute
{
	private Type elementType; //Field offset: 0x8
	private int length; //Field offset: 0xC

	public Type ElementType
	{
		 get { } //Length: 74
	}

	public int Length
	{
		 get { } //Length: 6
	}

	public FixedBufferAttribute(Type elementType, int length) { }

	public Type get_ElementType() { }

	public int get_Length() { }

}

