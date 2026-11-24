namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class BinaryArray
{
	internal int objectId; //Field offset: 0x8
	internal int rank; //Field offset: 0xC
	internal int[] lengthA; //Field offset: 0x10
	internal int[] lowerBoundA; //Field offset: 0x14
	internal BinaryTypeEnum binaryTypeEnum; //Field offset: 0x18
	internal object typeInformation; //Field offset: 0x1C
	internal int assemId; //Field offset: 0x20
	private BinaryHeaderEnum binaryHeaderEnum; //Field offset: 0x24
	internal BinaryArrayTypeEnum binaryArrayTypeEnum; //Field offset: 0x28

	internal BinaryArray() { }

	internal BinaryArray(BinaryHeaderEnum binaryHeaderEnum) { }

	public void Read(__BinaryParser input) { }

	internal void Set(int objectId, int rank, int[] lengthA, int[] lowerBoundA, BinaryTypeEnum binaryTypeEnum, object typeInformation, BinaryArrayTypeEnum binaryArrayTypeEnum, int assemId) { }

	public void Write(__BinaryWriter sout) { }

}

