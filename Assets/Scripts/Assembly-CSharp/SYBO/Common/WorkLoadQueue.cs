using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Common.Components.Singleton;
using SYBO.Common.Utilities;
using UnityEngine;

namespace SYBO.Common;

public class WorkLoadQueue : SingletonMonobehavior<WorkLoadQueue>
{
	private List<IEnumerator> _workQueue;

	private Stack<IEnumerator> _jobStack;

	private bool _relaxOneFrame;

	public bool IsIdle
	{
		get
		{
			Stack<IEnumerator> jobStack = _jobStack;
			int num;
			if (jobStack._size != 0)
			{
				num = 1;
			}
			else
			{
				List<IEnumerator> workQueue = _workQueue;
				num = workQueue._size;
			}
			return num == 0;
		}
	}

	protected override void Initialize()
	{
		Transform childTransform = transform;
		HierarchyUtility.ReparentByHierarchyPathType(childTransform, HierarchyPathType.Dynamic);
	}

	public void EnqueueWork(IEnumerator workItem)
	{
		_workQueue.Add(workItem);
	}

	public void CancelWork(IEnumerator workItem)
	{
		if (_jobStack.Contains(workItem))
		{
			throw new IndexOutOfRangeException();
		}
		if (_workQueue.Contains(workItem))
		{
			bool flag = _workQueue.Remove(workItem);
		}
	}

	private void Update()
	{
		if (~(_relaxOneFrame ? 1u : 0u) == 0)
		{
			_relaxOneFrame = false;
			return;
		}
		Work();
		while (true)
		{
			List<IEnumerator> workQueue = _workQueue;
			if (workQueue._size <= 25)
			{
				break;
			}
			Work();
		}
		List<IEnumerator> workQueue2 = _workQueue;
		if (workQueue2._size >= 21)
		{
			Work();
		}
		List<IEnumerator> workQueue3 = _workQueue;
		if (workQueue3._size >= 11)
		{
			Work();
		}
	}

	public void WorkUntilDone()
	{
		while (!IsIdle)
		{
			Work();
		}
	}

	private void Work()
	{
		object obj = default;
		object obj2 = default;
		IEnumerator item2 = default;
		while (true)
		{
			Stack<IEnumerator> jobStack = _jobStack;
			if (jobStack._size == 0)
			{
				List<IEnumerator> workQueue = _workQueue;
				if (workQueue._size == 0)
				{
					break;
				}
			}
			Stack<IEnumerator> jobStack2 = _jobStack;
			if (jobStack2._size == 0)
			{
				IEnumerator item = _workQueue.get_Item(0);
				_jobStack.Push(item);
				_workQueue.RemoveAt(0);
			}
			IEnumerator enumerator = _jobStack.Peek();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			if (obj == null)
			{
				IEnumerator enumerator2 = _jobStack.Pop();
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23B");
			if (obj2 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23B");
				_jobStack.Push(item2);
				continue;
			}
			break;
		}
	}

	public WorkLoadQueue()
	{
		List<IEnumerator> list = default;
		list._002Ector(64);
		_workQueue = list;
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v36 @ S2_v6 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Stack`1<System.Collections.IEnumerator>>>)+4] (should have been resolved before IL gen)");
		Stack<IEnumerator> stack = default;
		IEnumerator[] array = default;
		stack._array = array;
		_jobStack = stack;
		base._002Ector();
	}
}
