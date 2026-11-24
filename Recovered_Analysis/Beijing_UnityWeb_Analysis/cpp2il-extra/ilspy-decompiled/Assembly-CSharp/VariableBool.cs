using System;
using System.Collections.Generic;
using System.Threading;
using Cpp2ILInjected;

public class VariableBool
{
	public delegate void OnChangeDelegate(bool value);

	private bool value;

	public OnChangeDelegate OnChange;

	private HashSet<object> objects;

	public bool Value
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			bool result = default;
			return result;
		}
	}

	public VariableBool()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		Thread thread = (Thread)(this + 8);
		thread = (Thread)(object)this;
		thread.ConstructInternalThread();
	}

	public void FireOnChange()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		HashSet<object> hashSet = default;
		hashSet._002Ector();
		object obj = this + 16;
		obj = hashSet;
		value = false;
	}

	private void NotifyOnChange()
	{
		Clear();
	}

	public void Add(object o)
	{
	}

	public void Remove(object o)
	{
		//IL_001b: Expected Obj, but got I
		//IL_002b: Expected Obj, but got I
		//IL_003b: Expected Obj, but got I
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		if (!objects.Contains(o))
		{
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S2_v5 (Il2CppMethodInfo)+C]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S2_v6+60]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S2_v7+38]");
			object obj3 = 0;
			object obj4 = obj3 & 0x1FFF;
			object obj5 = obj4 + 22691;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v35 @ S3_v5 (should have been resolved before IL gen)");
		}
		((AwardsScreenNavigation)this).OnEnable();
	}

	public void Clear()
	{
		//IL_0042: Expected Obj, but got I4
		if (OnChange != null)
		{
			bool flag = value;
			OnChange.EndInvoke((IAsyncResult)flag);
		}
	}

	private void UpdateValue()
	{
		throw new IndexOutOfRangeException();
	}
}
