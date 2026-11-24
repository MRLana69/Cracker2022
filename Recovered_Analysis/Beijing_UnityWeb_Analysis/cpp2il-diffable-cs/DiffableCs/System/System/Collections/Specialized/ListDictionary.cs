namespace System.Collections.Specialized;

public class ListDictionary : IDictionary, ICollection, IEnumerable
{
	private class DictionaryNode
	{
		public object key; //Field offset: 0x8
		public object value; //Field offset: 0xC
		public DictionaryNode next; //Field offset: 0x10

		public DictionaryNode() { }

	}

	private class NodeEnumerator : IDictionaryEnumerator, IEnumerator
	{
		private ListDictionary list; //Field offset: 0x8
		private DictionaryNode current; //Field offset: 0xC
		private int version; //Field offset: 0x10
		private bool start; //Field offset: 0x14

		public object Current
		{
			 get { } //Length: 88
		}

		public DictionaryEntry Entry
		{
			 get { } //Length: 38
		}

		public object Key
		{
			 get { } //Length: 89
		}

		public object Value
		{
			 get { } //Length: 103
		}

		public NodeEnumerator(ListDictionary list) { }

		public object get_Current() { }

		public DictionaryEntry get_Entry() { }

		public object get_Key() { }

		public object get_Value() { }

		public bool MoveNext() { }

		public void Reset() { }

	}

	private class NodeKeyValueCollection : ICollection, IEnumerable
	{
		private class NodeKeyValueEnumerator : IEnumerator
		{
			private ListDictionary list; //Field offset: 0x8
			private DictionaryNode current; //Field offset: 0xC
			private int version; //Field offset: 0x10
			private bool isKeys; //Field offset: 0x14
			private bool start; //Field offset: 0x15

			public object Current
			{
				 get { } //Length: 78
			}

			public NodeKeyValueEnumerator(ListDictionary list, bool isKeys) { }

			public object get_Current() { }

			public bool MoveNext() { }

			public void Reset() { }

		}

		private ListDictionary list; //Field offset: 0x8
		private bool isKeys; //Field offset: 0xC

		private int System.Collections.ICollection.Count
		{
			 get { } //Length: 164
		}

		public NodeKeyValueCollection(ListDictionary list, bool isKeys) { }

		private void System.Collections.ICollection.CopyTo(Array array, int index) { }

		private int System.Collections.ICollection.get_Count() { }

		private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	private DictionaryNode head; //Field offset: 0x8
	private int version; //Field offset: 0xC
	private int count; //Field offset: 0x10
	private IComparer comparer; //Field offset: 0x14

	public int Count
	{
		 get { } //Length: 162
	}

	public object Item
	{
		 get { } //Length: 152
		 set { } //Length: 43
	}

	public ICollection Keys
	{
		 get { } //Length: 6
	}

	public ListDictionary() { }

	public ListDictionary(IComparer comparer) { }

	public void Add(object key, object value) { }

	public bool Contains(object key) { }

	public void CopyTo(Array array, int index) { }

	public int get_Count() { }

	public object get_Item(object key) { }

	public ICollection get_Keys() { }

	public IDictionaryEnumerator GetEnumerator() { }

	public void Remove(object key) { }

	public void set_Item(object key, object value) { }

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

