namespace System;

public struct RuntimeMethodHandle : ISerializable
{
	private nint value; //Field offset: 0x0

	public nint Value
	{
		 get { } //Length: 9
	}

	internal RuntimeMethodHandle(nint v) { }

	private RuntimeMethodHandle(SerializationInfo info, StreamingContext context) { }

	internal static string ConstructInstantiation(RuntimeMethodInfo method, TypeNameFormatFlags format) { }

	public override bool Equals(object obj) { }

	public nint get_Value() { }

	public override int GetHashCode() { }

	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	internal bool IsNullHandle() { }

}

