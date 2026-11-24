namespace System.Runtime.Serialization;

internal class LongList
{
	private long[] m_values; //Field offset: 0x8
	private int m_count; //Field offset: 0xC
	private int m_totalItems; //Field offset: 0x10
	private int m_currentItem; //Field offset: 0x14

	internal int Count
	{
		 get { } //Length: 64
	}

	internal long Current
	{
		 get { } //Length: 20
	}

	internal LongList() { }

	internal LongList(int startingSize) { }

	internal void Add(long value) { }

	private void EnlargeArray() { }

	internal int get_Count() { }

	internal long get_Current() { }

	internal bool MoveNext() { }

	internal bool RemoveElement(long value) { }

	internal void StartEnumeration() { }

}

