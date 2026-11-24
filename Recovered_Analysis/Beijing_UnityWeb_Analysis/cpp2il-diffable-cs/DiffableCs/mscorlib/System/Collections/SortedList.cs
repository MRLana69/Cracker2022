namespace System.Collections;

public class SortedList : IDictionary, ICollection, IEnumerable, ICloneable
{
	private class KeyList : IList, ICollection, IEnumerable
	{
		private SortedList sortedList; //Field offset: 0x8

		public virtual int Count
		{
			 get { } //Length: 165
		}

		public virtual bool IsReadOnly
		{
			 get { } //Length: 9
		}

		public virtual object Item
		{
			 get { } //Length: 14
			 set { } //Length: 83
		}

		internal KeyList(SortedList sortedList) { }

		public virtual int Add(object key) { }

		public virtual void Clear() { }

		public virtual bool Contains(object key) { }

		public virtual void CopyTo(Array array, int arrayIndex) { }

		public virtual int get_Count() { }

		public virtual bool get_IsReadOnly() { }

		public virtual object get_Item(int index) { }

		public virtual IEnumerator GetEnumerator() { }

		public virtual int IndexOf(object key) { }

		public virtual void Insert(int index, object value) { }

		public virtual void Remove(object key) { }

		public virtual void RemoveAt(int index) { }

		public virtual void set_Item(int index, object value) { }

	}

	internal class SortedListDebugView
	{

	}

	private class SortedListEnumerator : IDictionaryEnumerator, IEnumerator, ICloneable
	{
		private SortedList sortedList; //Field offset: 0x8
		private object key; //Field offset: 0xC
		private object value; //Field offset: 0x10
		private int index; //Field offset: 0x14
		private int startIndex; //Field offset: 0x18
		private int endIndex; //Field offset: 0x1C
		private int version; //Field offset: 0x20
		private bool current; //Field offset: 0x24
		private int getObjectRetType; //Field offset: 0x28

		public virtual object Current
		{
			 get { } //Length: 228
		}

		public virtual DictionaryEntry Entry
		{
			 get { } //Length: 29
		}

		public virtual object Key
		{
			 get { } //Length: 7
		}

		public virtual object Value
		{
			 get { } //Length: 210
		}

		internal SortedListEnumerator(SortedList sortedList, int index, int count, int getObjRetType) { }

		public object Clone() { }

		public virtual object get_Current() { }

		public virtual DictionaryEntry get_Entry() { }

		public virtual object get_Key() { }

		public virtual object get_Value() { }

		public virtual bool MoveNext() { }

		public virtual void Reset() { }

	}

	private class ValueList
	{
		private SortedList sortedList; //Field offset: 0x8

	}

	private const int _defaultCapacity = 16; //Field offset: 0x0
	private static object[] emptyArray; //Field offset: 0x0
	private object[] keys; //Field offset: 0x8
	private object[] values; //Field offset: 0xC
	private int _size; //Field offset: 0x10
	private int version; //Field offset: 0x14
	private IComparer comparer; //Field offset: 0x18
	private KeyList keyList; //Field offset: 0x1C
	private ValueList valueList; //Field offset: 0x20
	private object _syncRoot; //Field offset: 0x24

	public virtual int Capacity
	{
		 get { } //Length: 15
		 set { } //Length: 24
	}

	public virtual int Count
	{
		 get { } //Length: 9
	}

	public virtual object Item
	{
		 get { } //Length: 133
		 set { } //Length: 440
	}

	public virtual ICollection Keys
	{
		 get { } //Length: 6
	}

	private static SortedList() { }

	public SortedList(IComparer comparer, int capacity) { }

	public SortedList(IComparer comparer) { }

	public SortedList() { }

	public SortedList(int initialCapacity) { }

	public virtual void Add(object key, object value) { }

	public virtual object Clone() { }

	public virtual bool Contains(object key) { }

	public virtual void CopyTo(Array array, int arrayIndex) { }

	private void EnsureCapacity(int min) { }

	public virtual int get_Capacity() { }

	public virtual int get_Count() { }

	public virtual object get_Item(object key) { }

	public virtual ICollection get_Keys() { }

	public virtual object GetByIndex(int index) { }

	public virtual IDictionaryEnumerator GetEnumerator() { }

	public virtual object GetKey(int index) { }

	public virtual IList GetKeyList() { }

	public virtual int IndexOfKey(object key) { }

	private void Init() { }

	private void Insert(int index, object key, object value) { }

	public virtual void Remove(object key) { }

	public virtual void RemoveAt(int index) { }

	public virtual void set_Capacity(int value) { }

	public virtual void set_Item(object key, object value) { }

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

