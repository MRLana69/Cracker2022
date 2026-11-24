namespace Kiloo.Common.UI;

public abstract class AbstractListAdapter
{
	public Action<int> onNotifyDataSetChanged; //Field offset: 0x8

	protected AbstractListAdapter() { }

	public virtual Container GetContainer(Container container, int dataIndex, bool isMeasurePass = false) { }

	public abstract int GetCount() { }

	public virtual long GetItemId(int position) { }

	public virtual int GetModelType(int index) { }

	public virtual bool HasStableIds() { }

	public void NotifyDataSetChanged(int selection = 0) { }

}

