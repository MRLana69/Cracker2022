namespace System;

public struct ArraySegment`1 : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	private sealed class ArraySegmentEnumerator : IEnumerator<T>, IDisposable, IEnumerator
	{
		private T[] _array; //Field offset: 0x0
		private int _start; //Field offset: 0x0
		private int _end; //Field offset: 0x0
		private int _current; //Field offset: 0x0

		public T Current
		{
			 get { } //Length: 42
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 180
		}

		internal ArraySegmentEnumerator(ArraySegment<T> arraySegment) { }

		public void Dispose() { }

		public T get_Current() { }

		public bool MoveNext() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

	}

	private T[] _array; //Field offset: 0x0
	private int _offset; //Field offset: 0x0
	private int _count; //Field offset: 0x0

	public T[] Array
	{
		 get { } //Length: 9
	}

	public int Count
	{
		 get { } //Length: 9
	}

	public int Offset
	{
		 get { } //Length: 9
	}

	private bool System.Collections.Generic.ICollection<T>.IsReadOnly
	{
		 get { } //Length: 12
	}

	private T System.Collections.Generic.IList<T>.Item
	{
		 get { } //Length: 49
		 set { } //Length: 28
	}

	private T System.Collections.Generic.IReadOnlyList<T>.Item
	{
		 get { } //Length: 14
	}

	public ArraySegment`1(T[] array, int offset, int count) { }

	public override bool Equals(object obj) { }

	public bool Equals(ArraySegment<T> obj) { }

	public T[] get_Array() { }

	public int get_Count() { }

	public int get_Offset() { }

	public override int GetHashCode() { }

	private void System.Collections.Generic.ICollection<T>.Add(T item) { }

	private void System.Collections.Generic.ICollection<T>.Clear() { }

	private bool System.Collections.Generic.ICollection<T>.Contains(T item) { }

	private void System.Collections.Generic.ICollection<T>.CopyTo(T[] array, int arrayIndex) { }

	private bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }

	private bool System.Collections.Generic.ICollection<T>.Remove(T item) { }

	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	private T System.Collections.Generic.IList<T>.get_Item(int index) { }

	private int System.Collections.Generic.IList<T>.IndexOf(T item) { }

	private void System.Collections.Generic.IList<T>.Insert(int index, T item) { }

	private void System.Collections.Generic.IList<T>.RemoveAt(int index) { }

	private void System.Collections.Generic.IList<T>.set_Item(int index, T value) { }

	private T System.Collections.Generic.IReadOnlyList<T>.get_Item(int index) { }

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

