namespace System.Runtime.CompilerServices;

public sealed class ConditionalWeakTable`2
{
	public delegate CreateValueCallback
	{

		public CreateValueCallback(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(TKey key, AsyncCallback callback, object object) { }

		public virtual TValue EndInvoke(IAsyncResult result) { }

		public virtual TValue Invoke(TKey key) { }

	}

	private const int INITIAL_SIZE = 13; //Field offset: 0x0
	private const float LOAD_FACTOR = 0.7; //Field offset: 0x0
	private const float COMPACT_FACTOR = 0.5; //Field offset: 0x0
	private const float EXPAND_FACTOR = 1.1; //Field offset: 0x0
	private Ephemeron[] data; //Field offset: 0x0
	private object _lock; //Field offset: 0x0
	private int size; //Field offset: 0x0

	public ConditionalWeakTable`2() { }

	public void Add(TKey key, TValue value) { }

	protected override void Finalize() { }

	public TValue GetValue(TKey key, CreateValueCallback<TKey, TValue> createValueCallback) { }

	private void RecomputeSize() { }

	private void Rehash() { }

	private void RehashWithoutResize() { }

	public bool Remove(TKey key) { }

	public bool TryGetValue(TKey key, out TValue value) { }

}

