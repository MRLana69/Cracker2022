namespace System.Reflection;

public sealed class Pointer : ISerializable
{
	private void* _ptr; //Field offset: 0x8
	private RuntimeType _ptrType; //Field offset: 0xC

	private Pointer() { }

	private Pointer(SerializationInfo info, StreamingContext context) { }

	public static object Box(void* ptr, Type type) { }

	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

}

