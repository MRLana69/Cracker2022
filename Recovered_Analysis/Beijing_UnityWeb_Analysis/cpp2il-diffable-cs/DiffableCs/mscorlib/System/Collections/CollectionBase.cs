namespace System.Collections;

public abstract class CollectionBase : IList, ICollection, IEnumerable
{
	private ArrayList list; //Field offset: 0x8

	public int Count
	{
		 get { } //Length: 79
	}

	protected ArrayList InnerList
	{
		 get { } //Length: 175
	}

	private bool System.Collections.IList.IsReadOnly
	{
		 get { } //Length: 23
	}

	private object System.Collections.IList.Item
	{
		 get { } //Length: 146
		 set { } //Length: 19
	}

	protected CollectionBase() { }

	public void Clear() { }

	public int get_Count() { }

	protected ArrayList get_InnerList() { }

	public IEnumerator GetEnumerator() { }

	protected virtual void OnClear() { }

	protected virtual void OnClearComplete() { }

	protected virtual void OnInsert(int index, object value) { }

	protected virtual void OnInsertComplete(int index, object value) { }

	protected virtual void OnRemove(int index, object value) { }

	protected virtual void OnRemoveComplete(int index, object value) { }

	protected virtual void OnSet(int index, object oldValue, object newValue) { }

	protected virtual void OnSetComplete(int index, object oldValue, object newValue) { }

	protected virtual void OnValidate(object value) { }

	public void RemoveAt(int index) { }

	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	private int System.Collections.IList.Add(object value) { }

	private bool System.Collections.IList.Contains(object value) { }

	private bool System.Collections.IList.get_IsReadOnly() { }

	private object System.Collections.IList.get_Item(int index) { }

	private int System.Collections.IList.IndexOf(object value) { }

	private void System.Collections.IList.Insert(int index, object value) { }

	private void System.Collections.IList.Remove(object value) { }

	private void System.Collections.IList.set_Item(int index, object value) { }

}

