namespace System.Threading;

internal class SparselyPopulatedArrayFragment`1
{
	internal readonly T[] m_elements; //Field offset: 0x0
	internal int m_freeCount; //Field offset: 0x0
	internal SparselyPopulatedArrayFragment<T> m_next; //Field offset: 0x0
	internal SparselyPopulatedArrayFragment<T> m_prev; //Field offset: 0x0

	internal T Item
	{
		 get { } //Length: 659
	}

	internal int Length
	{
		 get { } //Length: 9
	}

	internal SparselyPopulatedArrayFragment<T> Prev
	{
		 get { } //Length: 9
	}

	internal SparselyPopulatedArrayFragment`1(int size) { }

	internal SparselyPopulatedArrayFragment`1(int size, SparselyPopulatedArrayFragment<T> prev) { }

	internal T get_Item(int index) { }

	internal int get_Length() { }

	internal SparselyPopulatedArrayFragment<T> get_Prev() { }

	internal T SafeAtomicRemove(int index, T expectedElement) { }

}

