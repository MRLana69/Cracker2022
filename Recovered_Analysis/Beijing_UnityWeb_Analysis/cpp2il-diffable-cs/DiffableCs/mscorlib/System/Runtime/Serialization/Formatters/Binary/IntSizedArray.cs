namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class IntSizedArray : ICloneable
{
	internal int[] objects; //Field offset: 0x8
	internal int[] negObjects; //Field offset: 0xC

	internal int Item
	{
		 get { } //Length: 89
		 set { } //Length: 145
	}

	public IntSizedArray() { }

	private IntSizedArray(IntSizedArray sizedArray) { }

	public object Clone() { }

	internal int get_Item(int index) { }

	internal void IncreaseCapacity(int index) { }

	internal void set_Item(int index, int value) { }

}

