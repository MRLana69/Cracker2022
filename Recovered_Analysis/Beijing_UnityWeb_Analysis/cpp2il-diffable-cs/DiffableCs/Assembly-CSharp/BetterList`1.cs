//Type is in global namespace

public class BetterList`1
{
	private sealed class <GetEnumerator>d__2 : IEnumerator<T>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private T <>2__current; //Field offset: 0x0
		public BetterList<T> <>4__this; //Field offset: 0x0
		private int <i>5__2; //Field offset: 0x0

		private T System.Collections.Generic.IEnumerator<T>.Current
		{
			 get { } //Length: 39
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <GetEnumerator>d__2(int <>1__state) { }

		private bool MoveNext() { }

		private T System.Collections.Generic.IEnumerator<T>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	public delegate CompareFunc
	{

		public CompareFunc(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(T left, T right, AsyncCallback callback, object object) { }

		public virtual int EndInvoke(IAsyncResult result) { }

		public virtual int Invoke(T left, T right) { }

	}

	public T[] buffer; //Field offset: 0x0
	public int size; //Field offset: 0x0

	public T Item
	{
		 get { } //Length: 80
		 set { } //Length: 35
	}

	public BetterList`1() { }

	public void Add(T item) { }

	private void AllocateMore() { }

	public void Clear() { }

	public bool Contains(T item) { }

	public T get_Item(int i) { }

	public IEnumerator<T> GetEnumerator() { }

	public int IndexOf(T item) { }

	public void Insert(int index, T item) { }

	public T Pop() { }

	public void Release() { }

	public bool Remove(T item) { }

	public void RemoveAt(int index) { }

	public void set_Item(int i, T value) { }

	public void Sort(CompareFunc<T> comparer) { }

	public T[] ToArray() { }

	private void Trim() { }

}

