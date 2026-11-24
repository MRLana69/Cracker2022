namespace System.Runtime.CompilerServices;

public sealed class RuntimeWrappedException : Exception
{
	private object m_wrappedException; //Field offset: 0x44

	private RuntimeWrappedException(object thrownObject) { }

	internal RuntimeWrappedException(SerializationInfo info, StreamingContext context) { }

	internal RuntimeWrappedException() { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

