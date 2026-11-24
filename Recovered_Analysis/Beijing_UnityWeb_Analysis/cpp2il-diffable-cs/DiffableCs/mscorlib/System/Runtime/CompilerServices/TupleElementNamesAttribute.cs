namespace System.Runtime.CompilerServices;

public sealed class TupleElementNamesAttribute : Attribute
{
	private readonly string[] _transformNames; //Field offset: 0x8

	public TupleElementNamesAttribute(string[] transformNames) { }

}

