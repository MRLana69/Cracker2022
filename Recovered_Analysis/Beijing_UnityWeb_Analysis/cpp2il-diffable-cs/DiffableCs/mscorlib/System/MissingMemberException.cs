namespace System;

public class MissingMemberException : MemberAccessException, ISerializable
{
	protected string ClassName; //Field offset: 0x44
	protected string MemberName; //Field offset: 0x48
	protected byte[] Signature; //Field offset: 0x4C

	public override string Message
	{
		 get { } //Length: 204
	}

	public MissingMemberException() { }

	public MissingMemberException(string message) { }

	protected MissingMemberException(SerializationInfo info, StreamingContext context) { }

	internal static string FormatSignature(byte[] signature) { }

	public override string get_Message() { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

