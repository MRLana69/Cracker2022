using System;
using System.Collections.Generic;
using Cpp2ILInjected;

public class VariableBool
{
	public delegate void OnChangeDelegate(bool value);

	private bool value;

	public OnChangeDelegate OnChange;

	private HashSet<object> objects;

	public bool Value => value;

	public VariableBool()
	{
		HashSet<object> hashSet = default;
		hashSet._002Ector();
		objects = hashSet;
		value = false;
	}

	public void FireOnChange()
	{
		OnChangeDelegate onChange = OnChange;
		if (OnChange != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	private void NotifyOnChange()
	{
		OnChangeDelegate onChange = OnChange;
		if (OnChange != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	public void Add(object o)
	{
		//IL_0021: Expected Obj, but got I
		if (!objects.Contains(o))
		{
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S3_v4 (Il2CppRgctx<System.Collections.Generic.HashSet`1<System.Object>>)+3C]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v33 @ S3_v5+4] (should have been resolved before IL gen)");
		}
		UpdateValue();
	}

	public void Remove(object o)
	{
		if (objects.Contains(o))
		{
			bool flag = objects.Remove(o);
		}
		UpdateValue();
	}

	public void Clear()
	{
		throw new IndexOutOfRangeException();
	}

	private void UpdateValue()
	{
		HashSet<object> hashSet = objects;
		bool flag = (value = hashSet._count > 0);
		if (value != flag)
		{
			OnChangeDelegate onChange = OnChange;
			if (OnChange != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v28.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
	}
}
