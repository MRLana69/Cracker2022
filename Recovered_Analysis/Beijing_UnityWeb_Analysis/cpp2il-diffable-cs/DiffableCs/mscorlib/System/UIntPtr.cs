namespace System;

public struct nuint : ISerializable
{
	public static readonly nuint Zero; //Field offset: 0x0
	private void* _pointer; //Field offset: 0x0

	public static int Size
	{
		 get { } //Length: 816
	}

	private static nuint() { }

	public nuint(uint value) { }

	public override bool Equals(object obj) { }

	public static int get_Size() { }

	public override int GetHashCode() { }

	public static bool op_Equality(nuint value1, nuint value2) { }

	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	public override string ToString() { }

}

