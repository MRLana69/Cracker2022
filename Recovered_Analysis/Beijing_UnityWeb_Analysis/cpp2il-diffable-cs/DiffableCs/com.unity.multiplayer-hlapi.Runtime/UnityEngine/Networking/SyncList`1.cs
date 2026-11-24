namespace UnityEngine.Networking;

public abstract class SyncList`1 : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
{
	public enum Operation
	{
		OP_ADD = 0,
		OP_CLEAR = 1,
		OP_INSERT = 2,
		OP_REMOVE = 3,
		OP_REMOVEAT = 4,
		OP_SET = 5,
		OP_DIRTY = 6,
	}

	public delegate SyncListChanged
	{

		public SyncListChanged(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(Operation<T> op, int itemIndex, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(Operation<T> op, int itemIndex) { }

	}

	private List<T> m_Objects; //Field offset: 0x0
	private NetworkBehaviour m_Behaviour; //Field offset: 0x0
	private int m_CmdHash; //Field offset: 0x0
	private SyncListChanged<T> m_Callback; //Field offset: 0x0

	public SyncListChanged<T> Callback
	{
		 get { } //Length: 3
		 set { } //Length: 10
	}

	public int Count
	{
		 get { } //Length: 55
	}

	public bool IsReadOnly
	{
		 get { } //Length: 87
	}

	public T Item
	{
		 get { } //Length: 333
		 set { } //Length: 83
	}

	protected SyncList`1() { }

	public void Add(T item) { }

	internal void AddInternal(T item) { }

	public void Clear() { }

	public bool Contains(T item) { }

	public void CopyTo(T[] array, int index) { }

	protected abstract T DeserializeItem(NetworkReader reader) { }

	public void Dirty(int index) { }

	public SyncListChanged<T> get_Callback() { }

	public int get_Count() { }

	public bool get_IsReadOnly() { }

	public T get_Item(int i) { }

	public IEnumerator<T> GetEnumerator() { }

	public void HandleMsg(NetworkReader reader) { }

	public int IndexOf(T item) { }

	public void InitializeBehaviour(NetworkBehaviour beh, int cmdHash) { }

	public void Insert(int index, T item) { }

	public bool Remove(T item) { }

	public void RemoveAt(int index) { }

	private void SendMsg(Operation<T> op, int itemIndex) { }

	private void SendMsg(Operation<T> op, int itemIndex, T item) { }

	protected abstract void SerializeItem(NetworkWriter writer, T item) { }

	public void set_Callback(SyncListChanged<T> value) { }

	public void set_Item(int i, T value) { }

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

