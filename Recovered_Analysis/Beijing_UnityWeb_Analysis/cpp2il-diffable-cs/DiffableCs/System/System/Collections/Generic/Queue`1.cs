namespace System.Collections.Generic;

public class Queue`1 : IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T>
{
	public struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator
	{
		private readonly Queue<T> _q; //Field offset: 0x0
		private readonly int _version; //Field offset: 0x0
		private int _index; //Field offset: 0x0
		private T _currentElement; //Field offset: 0x0

		public T Current
		{
			 get { } //Length: 12
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 12
		}

		internal Enumerator(Queue<T> q) { }

		public void Dispose() { }

		public T get_Current() { }

		public bool MoveNext() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void ThrowEnumerationNotStartedOrEnded() { }

	}

	private const int MinimumGrow = 4; //Field offset: 0x0
	private const int GrowFactor = 200; //Field offset: 0x0
	private T[] _array; //Field offset: 0x0
	private int _head; //Field offset: 0x0
	private int _tail; //Field offset: 0x0
	private int _size; //Field offset: 0x0
	private int _version; //Field offset: 0x0
	private object _syncRoot; //Field offset: 0x0

	public int Count
	{
		 get { } //Length: 6
	}

	public Queue`1() { }

	public Queue`1(int capacity) { }

	public void Clear() { }

	public bool Contains(T item) { }

	public T Dequeue() { }

	public void Enqueue(T item) { }

	public int get_Count() { }

	private void MoveNext(ref int index) { }

	public T Peek() { }

	private void SetCapacity(int capacity) { }

	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	private void ThrowForEmptyQueue() { }

}

