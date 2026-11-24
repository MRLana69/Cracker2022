namespace System.Collections;

public class ArrayList : IList, ICollection, IEnumerable, ICloneable
{
	internal class ArrayListDebugView
	{

	}

	private sealed class ArrayListEnumeratorSimple : IEnumerator, ICloneable
	{
		private static object dummyObject; //Field offset: 0x0
		private ArrayList list; //Field offset: 0x8
		private int index; //Field offset: 0xC
		private int version; //Field offset: 0x10
		private object currentElement; //Field offset: 0x14
		private bool isArrayList; //Field offset: 0x18

		public object Current
		{
			 get { } //Length: 404
		}

		private static ArrayListEnumeratorSimple() { }

		internal ArrayListEnumeratorSimple(ArrayList list) { }

		public object Clone() { }

		public object get_Current() { }

		public bool MoveNext() { }

		public void Reset() { }

	}

	private class ReadOnlyArrayList : ArrayList
	{
		private ArrayList _list; //Field offset: 0x18

		public override int Capacity
		{
			 set { } //Length: 83
		}

		public override int Count
		{
			 get { } //Length: 78
		}

		public override bool IsReadOnly
		{
			 get { } //Length: 12
		}

		public override bool IsSynchronized
		{
			 get { } //Length: 3
		}

		public override object Item
		{
			 get { } //Length: 187
			 set { } //Length: 332
		}

		public override object SyncRoot
		{
			 get { } //Length: 12
		}

		internal ReadOnlyArrayList(ArrayList l) { }

		public override int Add(object obj) { }

		public override void AddRange(ICollection c) { }

		public override void Clear() { }

		public override object Clone() { }

		public override bool Contains(object obj) { }

		public override void CopyTo(Array array, int index) { }

		public override int get_Count() { }

		public override bool get_IsReadOnly() { }

		public override bool get_IsSynchronized() { }

		public override object get_Item(int index) { }

		public override object get_SyncRoot() { }

		public override IEnumerator GetEnumerator() { }

		public override int IndexOf(object value) { }

		public override void Insert(int index, object obj) { }

		public override void InsertRange(int index, ICollection c) { }

		public override void Remove(object value) { }

		public override void RemoveAt(int index) { }

		public override void set_Capacity(int value) { }

		public override void set_Item(int index, object value) { }

		public override object[] ToArray() { }

		public override Array ToArray(Type type) { }

	}

	private static readonly object[] emptyArray; //Field offset: 0x0
	private object[] _items; //Field offset: 0x8
	private int _size; //Field offset: 0xC
	private int _version; //Field offset: 0x10
	private object _syncRoot; //Field offset: 0x14

	public virtual int Capacity
	{
		 set { } //Length: 213
	}

	public virtual int Count
	{
		 get { } //Length: 9
	}

	public virtual bool IsReadOnly
	{
		 get { } //Length: 6
	}

	public virtual bool IsSynchronized
	{
		 get { } //Length: 3
	}

	public virtual object Item
	{
		 get { } //Length: 19
		 set { } //Length: 23
	}

	public virtual object SyncRoot
	{
		 get { } //Length: 3
	}

	private static ArrayList() { }

	public ArrayList(ICollection c) { }

	public ArrayList() { }

	public ArrayList(int capacity) { }

	public virtual int Add(object value) { }

	public virtual void AddRange(ICollection c) { }

	public virtual void Clear() { }

	public virtual object Clone() { }

	public virtual bool Contains(object item) { }

	public virtual void CopyTo(Array array, int arrayIndex) { }

	private void EnsureCapacity(int min) { }

	public virtual int get_Count() { }

	public virtual bool get_IsReadOnly() { }

	public virtual bool get_IsSynchronized() { }

	public virtual object get_Item(int index) { }

	public virtual object get_SyncRoot() { }

	public virtual IEnumerator GetEnumerator() { }

	public virtual int IndexOf(object value) { }

	public virtual void Insert(int index, object value) { }

	public virtual void InsertRange(int index, ICollection c) { }

	public static ArrayList ReadOnly(ArrayList list) { }

	public virtual void Remove(object obj) { }

	public virtual void RemoveAt(int index) { }

	public virtual void set_Capacity(int value) { }

	public virtual void set_Item(int index, object value) { }

	public virtual Array ToArray(Type type) { }

	public virtual object[] ToArray() { }

}

