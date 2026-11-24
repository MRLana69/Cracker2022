using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Common.Utilities;
using SYBO.Common.Visuals;
using SYBO.Components.Utilities;
using UnityEngine;

namespace SYBO.Common;

public class WorkLoadQueue : SingletonMonoBehaviour<WorkLoadQueue>
{
	private List<IEnumerator> _workQueue;

	private Stack<IEnumerator> _jobStack;

	private bool _relaxOneFrame;

	public bool IsIdle
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v8 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (byte)((ComputeShader)(object)_workQueue).FindKernel((string)null) != 0;
		}
	}

	protected override void SubclassInitialize()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}

	public void EnqueueWork(IEnumerator workItem)
	{
		AnimationState animationState = ((Animation)(object)_workQueue).CrossFadeQueued((string)(object)workItem);
		object obj = ((IConvertible)workItem).ToType((Type)(object)" , ", (IFormatProvider)workItem);
		object meshInfos = ((IConvertible)workItem).ToType((Type)(object)" , ", (IFormatProvider)workItem);
		((MeshCombiner)(object)this).Combine((GameObject)(object)"Play", (IList<ObjectModelInfo>)meshInfos);
	}

	public void CancelWork(IEnumerator workItem)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F73");
	}

	private void Update()
	{
		//IL_001d: Expected VT, but got I4
		GameObject childTransform = gameObject;
		HierarchyUtility.ReparentByHierarchyPathType((Transform)(object)childTransform, HierarchyPathType.Dynamic, (Vector3)0);
	}

	public void WorkUntilDone()
	{
		if (~(_relaxOneFrame ? 1u : 0u) == 0)
		{
			_relaxOneFrame = false;
			return;
		}
		this._002Ector();
		while (true)
		{
			List<IEnumerator> workQueue = _workQueue;
			if (workQueue._size < 26)
			{
				break;
			}
			this._002Ector();
		}
		List<IEnumerator> workQueue2 = _workQueue;
		if (workQueue2._size > 20)
		{
			this._002Ector();
		}
		List<IEnumerator> workQueue3 = _workQueue;
		if (workQueue3._size > 10)
		{
			this._002Ector();
		}
	}

	private void Work()
	{
		while (true)
		{
			MeshRenderer meshRenderer = ((CombineableMesh)(object)this).MeshRenderer;
			if ((object)meshRenderer == null)
			{
				this._002Ector();
				continue;
			}
			break;
		}
	}

	public WorkLoadQueue()
	{
		object obj = default;
		object obj2 = default;
		IEnumerator item2 = default;
		while (true)
		{
			List<IEnumerator> workQueue = _workQueue;
			if (workQueue._size == 0)
			{
				break;
			}
			Stack<IEnumerator> jobStack2;
			do
			{
				Stack<IEnumerator> jobStack = _jobStack;
				if (jobStack._size == 0)
				{
					IEnumerator item = _workQueue.get_Item(0);
					_jobStack.Push(item);
					_workQueue.RemoveAt(0);
				}
				IEnumerator enumerator = _jobStack.Peek();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				if (obj != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
					if (obj2 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
						_jobStack.Push(item2);
						jobStack2 = _jobStack;
						continue;
					}
					return;
				}
				IEnumerator enumerator2 = _jobStack.Pop();
				return;
			}
			while (jobStack2._size != 0);
		}
	}
}
