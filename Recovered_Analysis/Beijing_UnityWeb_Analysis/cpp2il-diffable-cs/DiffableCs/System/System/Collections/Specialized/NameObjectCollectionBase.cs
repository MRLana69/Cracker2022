namespace System.Collections.Specialized;

public abstract class NameObjectCollectionBase : ICollection, IEnumerable, ISerializable, IDeserializationCallback
{
	internal class NameObjectEntry
	{
		internal string Key; //Field offset: 0x8
		internal object Value; //Field offset: 0xC

		internal NameObjectEntry(string name, object value) { }

	}

	internal class NameObjectKeysEnumerator : IEnumerator
	{
		private int _pos; //Field offset: 0x8
		private NameObjectCollectionBase _coll; //Field offset: 0xC
		private int _version; //Field offset: 0x10

		public object Current
		{
			 get { } //Length: 157
		}

		internal NameObjectKeysEnumerator(NameObjectCollectionBase coll) { }

		public object get_Current() { }

		public bool MoveNext() { }

		public void Reset() { }

	}

	private static StringComparer defaultComparer; //Field offset: 0x0
	private bool _readOnly; //Field offset: 0x8
	private ArrayList _entriesArray; //Field offset: 0xC
	private IEqualityComparer _keyComparer; //Field offset: 0x10
	private Hashtable _entriesTable; //Field offset: 0x14
	private NameObjectEntry _nullKeyEntry; //Field offset: 0x18
	private SerializationInfo _serializationInfo; //Field offset: 0x1C
	private int _version; //Field offset: 0x20

	public virtual int Count
	{
		 get { } //Length: 81
	}

	protected bool IsReadOnly
	{
		 get { } //Length: 164
	}

	private static NameObjectCollectionBase() { }

	protected NameObjectCollectionBase(SerializationInfo info, StreamingContext context) { }

	internal NameObjectCollectionBase(DBNull dummy) { }

	protected NameObjectCollectionBase() { }

	protected NameObjectCollectionBase(IEqualityComparer equalityComparer) { }

	protected NameObjectCollectionBase(int capacity, IEqualityComparer equalityComparer) { }

	protected void BaseAdd(string name, object value) { }

	protected object BaseGet(string name) { }

	protected object BaseGet(int index) { }

	protected string BaseGetKey(int index) { }

	private NameObjectEntry FindEntry(string key) { }

	public virtual int get_Count() { }

	protected bool get_IsReadOnly() { }

	public virtual IEnumerator GetEnumerator() { }

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	public virtual void OnDeserialization(object sender) { }

	private void Reset() { }

	private void Reset(int capacity) { }

	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

}

