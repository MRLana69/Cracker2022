namespace System;

public struct nint : ISerializable
{
	public static readonly nint Zero; //Field offset: 0x0
	private void* m_value; //Field offset: 0x0

	public static int Size
	{
		 get { } //Length: 406
	}

	public nint(int value) { }

	public nint(long value) { }

	public nint(void* value) { }

	private nint(SerializationInfo info, StreamingContext context) { }

	public static nint Add(nint pointer, int offset) { }

	public override bool Equals(object obj) { }

	public static int get_Size() { }

	public override int GetHashCode() { }

	internal bool IsNull() { }

	public static bool op_Equality(nint value1, nint value2) { }

	public static nint op_Explicit(int value) { }

	public static nint op_Explicit(long value) { }

	public static nint op_Explicit(void* value) { }

	public static int op_Explicit(nint value) { }

	public static void* op_Explicit(nint value) { }

	public static bool op_Inequality(nint value1, nint value2) { }

	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	public long ToInt64() { }

	public void* ToPointer() { }

	public string ToString(string format) { }

	public override string ToString() { }

}

