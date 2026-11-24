namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class SizedArray : ICloneable
{
	internal object[] objects; //Field offset: 0x8
	internal object[] negObjects; //Field offset: 0xC

	internal object Item
	{
		 get { } //Length: 736
		 set { } //Length: 197
	}

	internal SizedArray() { }

	internal SizedArray(int length) { }

	private SizedArray(SizedArray sizedArray) { }

	public object Clone() { }

	internal object get_Item(int index) { }

	internal void IncreaseCapacity(int index) { }

	internal void set_Item(int index, object value) { }

}

