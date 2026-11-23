using System;
using Cpp2ILInjected;

namespace Kiloo.Common.UI;

public abstract class AbstractListAdapter
{
	public Action<int> onNotifyDataSetChanged;

	public abstract int GetCount();

	public virtual Container GetContainer(Container container, int dataIndex, bool isMeasurePass = false)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		NotImplementedException ex = default;
		ex._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		return (Container)(object)ex;
	}

	public virtual int GetModelType(int index)
	{
		return 0;
	}

	public virtual long GetItemId(int position)
	{
		//IL_0005: Expected I8, but got I4
		return position;
	}

	public virtual bool HasStableIds()
	{
		return false;
	}

	public void NotifyDataSetChanged(int selection = 0)
	{
		Action<int> action = onNotifyDataSetChanged;
		if (onNotifyDataSetChanged != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2 @ S0_v2 (System.Action`1<System.Int32>)+C] (should have been resolved before IL gen)");
		}
	}
}
