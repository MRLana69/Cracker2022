namespace System;

internal class TimeType
{
	public readonly int Offset; //Field offset: 0x8
	public readonly bool IsDst; //Field offset: 0xC
	public string Name; //Field offset: 0x10

	public TimeType(int offset, bool is_dst, string abbrev) { }

	public override string ToString() { }

}

