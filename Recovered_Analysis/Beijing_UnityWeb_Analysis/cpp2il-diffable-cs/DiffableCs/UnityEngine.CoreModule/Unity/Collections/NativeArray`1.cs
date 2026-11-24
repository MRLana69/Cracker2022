namespace Unity.Collections;

public struct NativeArray`1 : IDisposable, IEnumerable<T>, IEquatable<NativeArray<T>>, IEnumerable
{
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		private NativeArray<T> m_Array; //Field offset: 0x0
		private int m_Index; //Field offset: 0x0

		public T Current
		{
			 get { } //Length: 30
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 23
		}

		public Enumerator(ref NativeArray<T> array) { }

		public void Dispose() { }

		public T get_Current() { }

		public bool MoveNext() { }

		public void Reset() { }

		private object System.Collections.IEnumerator.get_Current() { }

	}

	internal void* m_Buffer; //Field offset: 0x0
	internal int m_Length; //Field offset: 0x0
	internal Allocator m_AllocatorLabel; //Field offset: 0x0

	public T Item
	{
		 get { } //Length: 14
		 set { } //Length: 18
	}

	public int Length
	{
		 get { } //Length: 12
	}

	public void Dispose() { }

	public bool Equals(NativeArray<T> other) { }

	public override bool Equals(object obj) { }

	public T get_Item(int index) { }

	public int get_Length() { }

	public Enumerator<T> GetEnumerator() { }

	public override int GetHashCode() { }

	public void set_Item(int index, T value) { }

	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

