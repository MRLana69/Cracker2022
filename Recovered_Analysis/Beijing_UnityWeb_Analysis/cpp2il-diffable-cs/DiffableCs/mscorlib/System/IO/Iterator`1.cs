namespace System.IO;

internal abstract class Iterator`1 : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator
{
	private int threadId; //Field offset: 0x0
	internal int state; //Field offset: 0x0
	internal TSource current; //Field offset: 0x0

	public TSource Current
	{
		 get { } //Length: 351
	}

	private object System.Collections.IEnumerator.Current
	{
		 get { } //Length: 6
	}

	public Iterator`1() { }

	protected abstract Iterator<TSource> Clone() { }

	public void Dispose() { }

	protected virtual void Dispose(bool disposing) { }

	public TSource get_Current() { }

	public IEnumerator<TSource> GetEnumerator() { }

	public abstract bool MoveNext() { }

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	private object System.Collections.IEnumerator.get_Current() { }

	private void System.Collections.IEnumerator.Reset() { }

}

