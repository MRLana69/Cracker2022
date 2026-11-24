namespace System;

public sealed class TypeInitializationException : SystemException
{
	private string _typeName; //Field offset: 0x44

	public string TypeName
	{
		 get { } //Length: 29
	}

	private TypeInitializationException() { }

	public TypeInitializationException(string fullTypeName, Exception innerException) { }

	internal TypeInitializationException(SerializationInfo info, StreamingContext context) { }

	public string get_TypeName() { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

