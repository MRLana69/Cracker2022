namespace System.Reflection;

internal abstract class RuntimeConstructorInfo : ConstructorInfo, ISerializable
{

	internal BindingFlags BindingFlags
	{
		 get { } //Length: 59
	}

	public override Module Module
	{
		 get { } //Length: 3
	}

	private RuntimeType ReflectedTypeInternal
	{
		 get { } //Length: 3
	}

	protected RuntimeConstructorInfo() { }

	internal BindingFlags get_BindingFlags() { }

	public override Module get_Module() { }

	private RuntimeType get_ReflectedTypeInternal() { }

	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	internal RuntimeModule GetRuntimeModule() { }

	internal void SerializationInvoke(object target, SerializationInfo info, StreamingContext context) { }

	internal string SerializationToString() { }

}

