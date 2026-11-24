namespace System.Reflection;

internal abstract class RuntimeMethodInfo : MethodInfo, ISerializable
{

	internal BindingFlags BindingFlags
	{
		 get { } //Length: 31
	}

	public override Module Module
	{
		 get { } //Length: 3
	}

	private RuntimeType ReflectedTypeInternal
	{
		 get { } //Length: 9
	}

	protected RuntimeMethodInfo() { }

	internal override string FormatNameAndSig(bool serialization) { }

	internal BindingFlags get_BindingFlags() { }

	public override Module get_Module() { }

	private RuntimeType get_ReflectedTypeInternal() { }

	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	internal RuntimeModule GetRuntimeModule() { }

	internal string SerializationToString() { }

	public override string ToString() { }

}

