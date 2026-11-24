namespace System;

internal class ArraySpec : ModifierSpec
{
	private int dimensions; //Field offset: 0x8
	private bool bound; //Field offset: 0xC

	internal ArraySpec(int dimensions, bool bound) { }

	public StringBuilder Append(StringBuilder sb) { }

	public Type Resolve(Type type) { }

	public override string ToString() { }

}

