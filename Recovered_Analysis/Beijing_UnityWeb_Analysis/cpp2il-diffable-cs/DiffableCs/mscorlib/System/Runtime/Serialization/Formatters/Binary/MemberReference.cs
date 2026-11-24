namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class MemberReference
{
	internal int idRef; //Field offset: 0x8

	internal MemberReference() { }

	public void Dump() { }

	public void Read(__BinaryParser input) { }

	internal void Set(int idRef) { }

	public void Write(__BinaryWriter sout) { }

}

