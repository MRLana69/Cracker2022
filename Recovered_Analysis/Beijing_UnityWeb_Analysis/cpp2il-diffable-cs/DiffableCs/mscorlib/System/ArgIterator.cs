namespace System;

public struct ArgIterator
{
	private nint sig; //Field offset: 0x0
	private nint args; //Field offset: 0x4
	private int next_arg; //Field offset: 0x8
	private int num_args; //Field offset: 0xC

	public override bool Equals(object o) { }

	public override int GetHashCode() { }

}

