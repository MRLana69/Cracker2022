namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class PrimitiveArray
{
	private InternalPrimitiveTypeE code; //Field offset: 0x8
	private bool[] booleanA; //Field offset: 0xC
	private char[] charA; //Field offset: 0x10
	private double[] doubleA; //Field offset: 0x14
	private short[] int16A; //Field offset: 0x18
	private int[] int32A; //Field offset: 0x1C
	private long[] int64A; //Field offset: 0x20
	private sbyte[] sbyteA; //Field offset: 0x24
	private float[] singleA; //Field offset: 0x28
	private ushort[] uint16A; //Field offset: 0x2C
	private uint[] uint32A; //Field offset: 0x30
	private ulong[] uint64A; //Field offset: 0x34

	internal PrimitiveArray(InternalPrimitiveTypeE code, Array array) { }

	internal void Init(InternalPrimitiveTypeE code, Array array) { }

	internal void SetValue(string value, int index) { }

}

