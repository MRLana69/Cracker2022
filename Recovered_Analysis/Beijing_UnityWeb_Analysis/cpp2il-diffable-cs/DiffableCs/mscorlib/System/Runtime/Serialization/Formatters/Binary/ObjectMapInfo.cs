namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class ObjectMapInfo
{
	internal int objectId; //Field offset: 0x8
	private int numMembers; //Field offset: 0xC
	private string[] memberNames; //Field offset: 0x10
	private Type[] memberTypes; //Field offset: 0x14

	internal ObjectMapInfo(int objectId, int numMembers, string[] memberNames, Type[] memberTypes) { }

	internal bool isCompatible(int numMembers, string[] memberNames, Type[] memberTypes) { }

}

