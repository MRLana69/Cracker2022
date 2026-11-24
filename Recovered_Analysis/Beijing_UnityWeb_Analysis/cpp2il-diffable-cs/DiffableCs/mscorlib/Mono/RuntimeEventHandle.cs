namespace Mono;

internal struct RuntimeEventHandle
{
	private nint value; //Field offset: 0x0

	public nint Value
	{
		 get { } //Length: 12
	}

	internal RuntimeEventHandle(nint v) { }

	public override bool Equals(object obj) { }

	public nint get_Value() { }

	public override int GetHashCode() { }

}

