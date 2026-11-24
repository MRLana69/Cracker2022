namespace Kiloo.Common.UI;

public class ListAdapter`1 : AbstractListAdapter
{
	private List<T> <dataList>k__BackingField; //Field offset: 0x0

	public List<T> dataList
	{
		 get { } //Length: 39
		protected set { } //Length: 441
	}

	public ListAdapter`1(List<T> list) { }

	public virtual void AddItem(T element) { }

	public virtual void AddMany(IEnumerable<T> list) { }

	public virtual void Clear() { }

	public List<T> get_dataList() { }

	public override int GetCount() { }

	public virtual T GetItem(int index) { }

	public virtual void Insert(int index, T element) { }

	public virtual void RemoveItem(T element) { }

	public virtual void RemoveItemAt(int index) { }

	protected void set_dataList(List<T> value) { }

}

