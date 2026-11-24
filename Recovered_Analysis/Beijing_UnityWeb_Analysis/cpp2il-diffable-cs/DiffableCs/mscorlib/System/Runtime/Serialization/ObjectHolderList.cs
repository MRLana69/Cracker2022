namespace System.Runtime.Serialization;

internal class ObjectHolderList
{
	internal ObjectHolder[] m_values; //Field offset: 0x8
	internal int m_count; //Field offset: 0xC

	internal int Count
	{
		 get { } //Length: 6
	}

	internal int Version
	{
		 get { } //Length: 88
	}

	internal ObjectHolderList() { }

	internal ObjectHolderList(int startingSize) { }

	internal virtual void Add(ObjectHolder value) { }

	private void EnlargeArray() { }

	internal int get_Count() { }

	internal int get_Version() { }

	internal ObjectHolderListEnumerator GetFixupEnumerator() { }

}

