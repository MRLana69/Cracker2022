namespace Mono;

internal struct RuntimePropertyHandle
{
	private nint value; //Field offset: 0x0

	public nint Value
	{
		 get { } //Length: 9
	}

	internal RuntimePropertyHandle(nint v) { }

	public override bool Equals(object obj) { }

	public nint get_Value() { }

	public override int GetHashCode() { }

}

