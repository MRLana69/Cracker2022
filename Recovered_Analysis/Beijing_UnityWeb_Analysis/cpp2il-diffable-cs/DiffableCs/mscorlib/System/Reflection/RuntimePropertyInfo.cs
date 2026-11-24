namespace System.Reflection;

internal abstract class RuntimePropertyInfo : PropertyInfo, ISerializable
{

	internal BindingFlags BindingFlags
	{
		 get { } //Length: 42
	}

	public override Module Module
	{
		 get { } //Length: 3
	}

	private RuntimeType ReflectedTypeInternal
	{
		 get { } //Length: 55
	}

	protected RuntimePropertyInfo() { }

	private string FormatNameAndSig(bool serialization) { }

	internal BindingFlags get_BindingFlags() { }

	public override Module get_Module() { }

	private RuntimeType get_ReflectedTypeInternal() { }

	internal RuntimeType GetDeclaringTypeInternal() { }

	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	internal RuntimeModule GetRuntimeModule() { }

	internal string SerializationToString() { }

	public override string ToString() { }

}

