namespace System.Threading;

internal struct SparselyPopulatedArrayAddInfo`1
{
	private SparselyPopulatedArrayFragment<T> m_source; //Field offset: 0x0
	private int m_index; //Field offset: 0x0

	internal int Index
	{
		 get { } //Length: 9
	}

	internal SparselyPopulatedArrayFragment<T> Source
	{
		 get { } //Length: 6
	}

	internal SparselyPopulatedArrayAddInfo`1(SparselyPopulatedArrayFragment<T> source, int index) { }

	internal int get_Index() { }

	internal SparselyPopulatedArrayFragment<T> get_Source() { }

}

