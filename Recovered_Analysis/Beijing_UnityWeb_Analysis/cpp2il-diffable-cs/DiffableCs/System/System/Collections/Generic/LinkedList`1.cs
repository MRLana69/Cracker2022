namespace System.Collections.Generic;

public class LinkedList`1 : ICollection<T>, IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T>, ISerializable, IDeserializationCallback
{
	public struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator, ISerializable, IDeserializationCallback
	{
		private LinkedList<T> _list; //Field offset: 0x0
		private LinkedListNode<T> _node; //Field offset: 0x0
		private int _version; //Field offset: 0x0
		private T _current; //Field offset: 0x0
		private int _index; //Field offset: 0x0

		public T Current
		{
			 get { } //Length: 115
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 12
		}

		internal Enumerator(LinkedList<T> list) { }

		private Enumerator(SerializationInfo info, StreamingContext context) { }

		public void Dispose() { }

		public T get_Current() { }

		public bool MoveNext() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

		private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	}

	private const string VersionName = "Version"; //Field offset: 0x0
	private const string CountName = "Count"; //Field offset: 0x0
	private const string ValuesName = "Data"; //Field offset: 0x0
	internal LinkedListNode<T> head; //Field offset: 0x0
	internal int count; //Field offset: 0x0
	internal int version; //Field offset: 0x0
	private object _syncRoot; //Field offset: 0x0
	private SerializationInfo _siInfo; //Field offset: 0x0

	public int Count
	{
		 get { } //Length: 12
	}

	public LinkedListNode<T> First
	{
		 get { } //Length: 6
	}

	public LinkedListNode<T> Last
	{
		 get { } //Length: 6
	}

	private bool System.Collections.Generic.ICollection<T>.IsReadOnly
	{
		 get { } //Length: 12
	}

	public LinkedList`1() { }

	public LinkedList`1(IEnumerable<T> collection) { }

	protected LinkedList`1(SerializationInfo info, StreamingContext context) { }

	public LinkedListNode<T> AddFirst(T value) { }

	public void AddFirst(LinkedListNode<T> node) { }

	public void AddLast(LinkedListNode<T> node) { }

	public LinkedListNode<T> AddLast(T value) { }

	public void Clear() { }

	public bool Contains(T value) { }

	public void CopyTo(T[] array, int index) { }

	public LinkedListNode<T> Find(T value) { }

	public int get_Count() { }

	public LinkedListNode<T> get_First() { }

	public LinkedListNode<T> get_Last() { }

	public Enumerator<T> GetEnumerator() { }

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	private void InternalInsertNodeBefore(LinkedListNode<T> node, LinkedListNode<T> newNode) { }

	private void InternalInsertNodeToEmptyList(LinkedListNode<T> newNode) { }

	internal void InternalRemoveNode(LinkedListNode<T> node) { }

	public virtual void OnDeserialization(object sender) { }

	public bool Remove(T value) { }

	public void Remove(LinkedListNode<T> node) { }

	public void RemoveFirst() { }

	public void RemoveLast() { }

	private void System.Collections.Generic.ICollection<T>.Add(T value) { }

	private bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }

	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	internal void ValidateNewNode(LinkedListNode<T> node) { }

	internal void ValidateNode(LinkedListNode<T> node) { }

}

