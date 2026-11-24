namespace System;

internal class PointerSpec : ModifierSpec
{
	private int pointer_level; //Field offset: 0x8

	internal PointerSpec(int pointer_level) { }

	public StringBuilder Append(StringBuilder sb) { }

	public Type Resolve(Type type) { }

	public override string ToString() { }

}

