namespace System.Collections;

public abstract class ReadOnlyCollectionBase : ICollection, IEnumerable
{
	private ArrayList list; //Field offset: 0x8

	public virtual int Count
	{
		 get { } //Length: 79
	}

	protected ArrayList InnerList
	{
		 get { } //Length: 125
	}

	protected ReadOnlyCollectionBase() { }

	public virtual int get_Count() { }

	protected ArrayList get_InnerList() { }

	public virtual IEnumerator GetEnumerator() { }

	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

}

