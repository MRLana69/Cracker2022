using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace Kiloo.Common.Utility;

public class ActionQueue
{
	private sealed class _003C_003Ec__DisplayClass6_0
	{
		public ActionQueue _003C_003E4__this;

		public Action callback;

		public LinkedListNode<Action<Action>> element;

		public Action recursiveAction;

		internal void _003CRunSequentially_003Eb__0()
		{
			ActionQueue actionQueue = _003C_003E4__this;
			LinkedList<Action<Action>> actionQueue2 = actionQueue.actionQueue;
			element = actionQueue2.head;
			LinkedListNode<Action<Action>> linkedListNode = element;
			if (element != null)
			{
				Action<Action> item = linkedListNode.item;
				ActionQueue actionQueue3 = _003C_003E4__this;
				actionQueue3.actionQueue.RemoveFirst();
				if (linkedListNode.item != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v26 @ S0_v21 (System.Action`1<System.Action>)+C] (should have been resolved before IL gen)");
				}
			}
			else
			{
				ActionQueue actionQueue4 = _003C_003E4__this;
				actionQueue4._running = false;
				Action action = callback;
				if (callback != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v37.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				}
			}
		}
	}

	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public ActionQueue _003C_003E4__this;

		public Action callback;

		public int size;

		public int index;

		internal void _003CRunParallel_003Eb__0()
		{
			if (++index >= size)
			{
				ActionQueue actionQueue = _003C_003E4__this;
				actionQueue._running = false;
				Action action = callback;
				if (callback != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v15.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				}
			}
		}
	}

	private LinkedList<Action<Action>> actionQueue;

	private bool _running;

	public int Count
	{
		get
		{
			LinkedList<Action<Action>> linkedList = actionQueue;
			return linkedList.count;
		}
	}

	public void AddAction(Action<Action> action)
	{
		LinkedListNode<Action<Action>> linkedListNode = actionQueue.AddLast(action);
	}

	public void AddAndRunSequentially(Action<Action> action)
	{
		AddAction(action);
		RunSequentially();
	}

	public unsafe void RunSequentially(Action callback = null)
	{
		//IL_0049: Expected Obj, but got I
		if (~(_running ? 1u : 0u) != 0)
		{
			_running = true;
			_ = 0;
			_ = 0;
			Action action = default;
			object obj = default;
			action._002Ector(obj, (nint)__ldftn(_003C_003Ec__DisplayClass6_0._003CRunSequentially_003Eb__0));
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v7 (System.Object)+14]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v56 @ S0_v21+C] (should have been resolved before IL gen)");
		}
	}

	public unsafe void RunParallel(Action callback = null)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected Obj, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected Obj, but got Unknown
		//IL_034d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0352: Expected Obj, but got Unknown
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected Obj, but got Unknown
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + -64;
		_ = 0;
		_ = 0;
		_ = 0;
		if (_running)
		{
			return;
		}
		_running = true;
		LinkedList<Action<Action>> linkedList = actionQueue;
		_ = linkedList.count;
		if (linkedList.count < 1)
		{
			return;
		}
		_ = 0;
		Action action = default;
		object obj3 = default;
		action._002Ector(obj3, (nint)__ldftn(_003C_003Ec__DisplayClass7_0._003CRunParallel_003Eb__0));
		object obj4 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C6");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj5 = obj + 40;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj7 = default;
		object obj8 = default;
		object obj9 = default;
		object obj11 = default;
		object obj12 = default;
		while (true)
		{
			_ = 0;
			object obj6 = obj + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj7 == null)
				{
					goto IL_024e;
				}
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+34]");
					if ((nint)0 == 0)
					{
						continue;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag = obj8 != obj9;
			object obj10 = obj11;
			if (flag)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				goto IL_024e;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			obj10 = obj12;
			break;
			IL_024e:
			object obj13 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A1DC");
			actionQueue.Clear();
			return;
		}
		_ = 0;
		object obj14 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
	}

	public ActionQueue()
	{
		LinkedList<Action<Action>> linkedList = default;
		actionQueue = linkedList;
	}
}
