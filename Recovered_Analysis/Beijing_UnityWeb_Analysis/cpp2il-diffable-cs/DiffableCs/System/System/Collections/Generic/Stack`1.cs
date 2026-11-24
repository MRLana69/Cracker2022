namespace System.Collections.Generic;

public class Stack`1 : IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T>
{
	public struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator
	{
		private readonly Stack<T> _stack; //Field offset: 0x0
		private readonly int _version; //Field offset: 0x0
		private int _index; //Field offset: 0x0
		private T _currentElement; //Field offset: 0x0

		public T Current
		{
			 get { } //Length: 146
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 12
		}

		internal Enumerator(Stack<T> stack) { }

		public void Dispose() { }

		public T get_Current() { }

		public bool MoveNext() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void ThrowEnumerationNotStartedOrEnded() { }

	}

	private const int DefaultCapacity = 4; //Field offset: 0x0
	private T[] _array; //Field offset: 0x0
	private int _size; //Field offset: 0x0
	private int _version; //Field offset: 0x0
	private object _syncRoot; //Field offset: 0x0

	public int Count
	{
		 get { } //Length: 12
	}

	public Stack`1() { }

	public void Clear() { }

	public bool Contains(T item) { }

	public int get_Count() { }

	public T Peek() { }

	public T Pop() { }

	public void Push(T item) { }

	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	private void System.Collections.ICollection.CopyTo(Array array, int arrayIndex) { }

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	private void ThrowForEmptyStack() { }

}

