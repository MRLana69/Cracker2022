namespace System.Runtime.Remoting.Messaging;

internal class MessageDictionary : IDictionary, ICollection, IEnumerable
{
	private class DictionaryEnumerator : IDictionaryEnumerator, IEnumerator
	{
		private MessageDictionary _methodDictionary; //Field offset: 0x8
		private IDictionaryEnumerator _hashtableEnum; //Field offset: 0xC
		private int _posMethod; //Field offset: 0x10

		public object Current
		{
			 get { } //Length: 59
		}

		public DictionaryEntry Entry
		{
			 get { } //Length: 96
		}

		public object Key
		{
			 get { } //Length: 195
		}

		public object Value
		{
			 get { } //Length: 38
		}

		public DictionaryEnumerator(MessageDictionary methodDictionary) { }

		public object get_Current() { }

		public DictionaryEntry get_Entry() { }

		public object get_Key() { }

		public object get_Value() { }

		public bool MoveNext() { }

		public void Reset() { }

	}

	private IDictionary _internalProperties; //Field offset: 0x8
	protected IMethodMessage _message; //Field offset: 0xC
	private string[] _methodKeys; //Field offset: 0x10
	private bool _ownProperties; //Field offset: 0x14

	public int Count
	{
		 get { } //Length: 693
	}

	internal IDictionary InternalDictionary
	{
		 get { } //Length: 136
	}

	public object Item
	{
		 get { } //Length: 94
		 set { } //Length: 725
	}

	public ICollection Keys
	{
		 get { } //Length: 31
	}

	public string[] MethodKeys
	{
		 set { } //Length: 11
	}

	public ICollection Values
	{
		 get { } //Length: 588
	}

	public MessageDictionary(IMethodMessage message) { }

	public void Add(object key, object value) { }

	protected virtual IDictionary AllocInternalProperties() { }

	public bool Contains(object key) { }

	public void CopyTo(Array array, int index) { }

	public int get_Count() { }

	internal IDictionary get_InternalDictionary() { }

	public object get_Item(object key) { }

	public ICollection get_Keys() { }

	public ICollection get_Values() { }

	public IDictionaryEnumerator GetEnumerator() { }

	public IDictionary GetInternalProperties() { }

	protected virtual object GetMethodProperty(string key) { }

	internal bool HasUserData() { }

	private bool IsOverridenKey(string key) { }

	public void Remove(object key) { }

	public void set_Item(object key, object value) { }

	public void set_MethodKeys(string[] value) { }

	protected virtual void SetMethodProperty(string key, object value) { }

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

