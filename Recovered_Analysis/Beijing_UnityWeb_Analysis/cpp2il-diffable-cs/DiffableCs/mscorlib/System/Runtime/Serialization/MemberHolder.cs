namespace System.Runtime.Serialization;

internal class MemberHolder
{
	internal Type memberType; //Field offset: 0x8
	internal StreamingContext context; //Field offset: 0xC

	internal MemberHolder(Type type, StreamingContext ctx) { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

}

