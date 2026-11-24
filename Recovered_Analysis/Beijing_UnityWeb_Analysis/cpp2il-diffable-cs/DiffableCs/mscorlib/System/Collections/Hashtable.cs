namespace System.Collections;

public class Hashtable : IDictionary, ICollection, IEnumerable, ISerializable, IDeserializationCallback, ICloneable
{
	private struct bucket
	{
		public object key; //Field offset: 0x0
		public object val; //Field offset: 0x4
		public int hash_coll; //Field offset: 0x8

	}

	internal class HashtableDebugView
	{

	}

	private class HashtableEnumerator : IDictionaryEnumerator, IEnumerator, ICloneable
	{
		private Hashtable hashtable; //Field offset: 0x8
		private int bucket; //Field offset: 0xC
		private int version; //Field offset: 0x10
		private bool current; //Field offset: 0x14
		private int getObjectRetType; //Field offset: 0x18
		private object currentKey; //Field offset: 0x1C
		private object currentValue; //Field offset: 0x20

		public virtual object Current
		{
			 get { } //Length: 240
		}

		public virtual DictionaryEntry Entry
		{
			 get { } //Length: 2
		}

		public virtual object Key
		{
			 get { } //Length: 7
		}

		public virtual object Value
		{
			 get { } //Length: 210
		}

		internal HashtableEnumerator(Hashtable hashtable, int getObjRetType) { }

		public object Clone() { }

		public virtual object get_Current() { }

		public virtual DictionaryEntry get_Entry() { }

		public virtual object get_Key() { }

		public virtual object get_Value() { }

		public virtual bool MoveNext() { }

		public virtual void Reset() { }

	}

	private class KeyCollection : ICollection, IEnumerable
	{
		private Hashtable _hashtable; //Field offset: 0x8

		public virtual int Count
		{
			 get { } //Length: 68
		}

		internal KeyCollection(Hashtable hashtable) { }

		public virtual void CopyTo(Array array, int arrayIndex) { }

		public virtual int get_Count() { }

		public virtual IEnumerator GetEnumerator() { }

	}

	private class SyncHashtable : Hashtable, IEnumerable
	{
		protected Hashtable _table; //Field offset: 0x34

		public override int Count
		{
			 get { } //Length: 9
		}

		public override object Item
		{
			 get { } //Length: 73
			 set { } //Length: 564
		}

		public override ICollection Keys
		{
			 get { } //Length: 12
		}

		public override object SyncRoot
		{
			 get { } //Length: 12
		}

		internal SyncHashtable(Hashtable table) { }

		internal SyncHashtable(SerializationInfo info, StreamingContext context) { }

		public override void Add(object key, object value) { }

		public override void Clear() { }

		public override object Clone() { }

		public override bool Contains(object key) { }

		public override bool ContainsKey(object key) { }

		public override void CopyTo(Array array, int arrayIndex) { }

		public override int get_Count() { }

		public override object get_Item(object key) { }

		public override ICollection get_Keys() { }

		public override object get_SyncRoot() { }

		public override IDictionaryEnumerator GetEnumerator() { }

		public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

		public override void OnDeserialization(object sender) { }

		public override void Remove(object key) { }

		public override void set_Item(object key, object value) { }

		private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	internal const int HashPrime = 101; //Field offset: 0x0
	private const int InitialSize = 3; //Field offset: 0x0
	private const string LoadFactorName = "LoadFactor"; //Field offset: 0x0
	private const string VersionName = "Version"; //Field offset: 0x0
	private const string ComparerName = "Comparer"; //Field offset: 0x0
	private const string HashCodeProviderName = "HashCodeProvider"; //Field offset: 0x0
	private const string HashSizeName = "HashSize"; //Field offset: 0x0
	private const string KeysName = "Keys"; //Field offset: 0x0
	private const string ValuesName = "Values"; //Field offset: 0x0
	private const string KeyComparerName = "KeyComparer"; //Field offset: 0x0
	private bucket[] buckets; //Field offset: 0x8
	private int count; //Field offset: 0xC
	private int occupancy; //Field offset: 0x10
	private int loadsize; //Field offset: 0x14
	private float loadFactor; //Field offset: 0x18
	private int version; //Field offset: 0x1C
	private bool isWriterInProgress; //Field offset: 0x20
	private ICollection keys; //Field offset: 0x24
	private ICollection values; //Field offset: 0x28
	private IEqualityComparer _keycomparer; //Field offset: 0x2C
	private object _syncRoot; //Field offset: 0x30

	public virtual int Count
	{
		 get { } //Length: 91
	}

	public virtual object Item
	{
		 get { } //Length: 487
		 set { } //Length: 105
	}

	public virtual ICollection Keys
	{
		 get { } //Length: 61
	}

	public virtual object SyncRoot
	{
		 get { } //Length: 81
	}

	internal Hashtable(bool trash) { }

	protected Hashtable(SerializationInfo info, StreamingContext context) { }

	public Hashtable(IEqualityComparer equalityComparer) { }

	public Hashtable(IHashCodeProvider hcp, IComparer comparer) { }

	public Hashtable(int capacity, float loadFactor, IEqualityComparer equalityComparer) { }

	public Hashtable(int capacity, IEqualityComparer equalityComparer) { }

	public Hashtable(int capacity, float loadFactor) { }

	public Hashtable(int capacity) { }

	public Hashtable() { }

	public Hashtable(int capacity, float loadFactor, IHashCodeProvider hcp, IComparer comparer) { }

	public virtual void Add(object key, object value) { }

	public virtual void Clear() { }

	public virtual object Clone() { }

	public virtual bool Contains(object key) { }

	public virtual bool ContainsKey(object key) { }

	private void CopyEntries(Array array, int arrayIndex) { }

	private void CopyKeys(Array array, int arrayIndex) { }

	public virtual void CopyTo(Array array, int arrayIndex) { }

	private void CopyValues(Array array, int arrayIndex) { }

	private void expand() { }

	public virtual int get_Count() { }

	public virtual object get_Item(object key) { }

	public virtual ICollection get_Keys() { }

	public virtual object get_SyncRoot() { }

	public virtual IDictionaryEnumerator GetEnumerator() { }

	protected virtual int GetHash(object key) { }

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	private uint InitHash(object key, int hashsize, out uint seed, out uint incr) { }

	private void Insert(object key, object nvalue, bool add) { }

	protected virtual bool KeyEquals(object item, object key) { }

	public virtual void OnDeserialization(object sender) { }

	private void putEntry(bucket[] newBuckets, object key, object nvalue, int hashcode) { }

	private void rehash(int newsize, bool forceNewHashCode) { }

	private void rehash() { }

	public virtual void Remove(object key) { }

	public virtual void set_Item(object key, object value) { }

	public static Hashtable Synchronized(Hashtable table) { }

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	private void UpdateVersion() { }

}

