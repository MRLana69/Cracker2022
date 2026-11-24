namespace System.Reflection;

public sealed class ReflectionTypeLoadException : SystemException, ISerializable
{
	private Type[] _classes; //Field offset: 0x44
	private Exception[] _exceptions; //Field offset: 0x48

	private ReflectionTypeLoadException() { }

	public ReflectionTypeLoadException(Type[] classes, Exception[] exceptions) { }

	internal ReflectionTypeLoadException(SerializationInfo info, StreamingContext context) { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

