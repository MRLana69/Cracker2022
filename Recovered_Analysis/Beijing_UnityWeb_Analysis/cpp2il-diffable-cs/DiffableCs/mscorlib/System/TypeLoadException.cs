namespace System;

public class TypeLoadException : SystemException, ISerializable
{
	private string ClassName; //Field offset: 0x44
	private string AssemblyName; //Field offset: 0x48
	private string MessageArg; //Field offset: 0x4C
	internal int ResourceId; //Field offset: 0x50

	public override string Message
	{
		 get { } //Length: 63
	}

	public TypeLoadException() { }

	public TypeLoadException(string message) { }

	private TypeLoadException(string className, string assemblyName) { }

	private TypeLoadException(string className, string assemblyName, string messageArg, int resourceId) { }

	protected TypeLoadException(SerializationInfo info, StreamingContext context) { }

	public override string get_Message() { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	private void SetMessageField() { }

}

