namespace System.Linq;

internal abstract class OrderedEnumerable`1 : IOrderedEnumerable<TElement>, IEnumerable<TElement>, IEnumerable
{
	private sealed class <GetEnumerator>d__1 : IEnumerator<TElement>, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x0
		private TElement <>2__current; //Field offset: 0x0
		public OrderedEnumerable<TElement> <>4__this; //Field offset: 0x0
		private Buffer<TElement> <buffer>5__1; //Field offset: 0x0
		private int[] <map>5__2; //Field offset: 0x0
		private int <i>5__3; //Field offset: 0x0

		private TElement System.Collections.Generic.IEnumerator<TElement>.Current
		{
			 get { } //Length: 36
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 370
		}

		public <GetEnumerator>d__1(int <>1__state) { }

		private bool MoveNext() { }

		private TElement System.Collections.Generic.IEnumerator<TElement>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	internal IEnumerable<TElement> source; //Field offset: 0x0

	protected OrderedEnumerable`1() { }

	internal abstract EnumerableSorter<TElement> GetEnumerableSorter(EnumerableSorter<TElement> next) { }

	public IEnumerator<TElement> GetEnumerator() { }

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

