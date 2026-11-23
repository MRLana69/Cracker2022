using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace RSG;

public class PromiseTimer : IPromiseTimer
{
	private float curTime;

	private int curFrame;

	private readonly LinkedList<PredicateWait> waiting;

	public IPromise WaitFor(float seconds)
	{
		throw new ArgumentException();
	}

	public IPromise WaitWhile(Func<TimeData, bool> predicate)
	{
		throw new ArgumentException();
	}

	public IPromise WaitUntil(Func<TimeData, bool> predicate)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected Obj, but got Unknown
		Promise promise = default;
		promise._002Ector();
		PredicateWait predicateWait = default;
		predicateWait.pendingPromise = promise;
		predicateWait.timeStarted = curTime;
		object obj = predicateWait + 20;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		predicateWait.predicate = predicate;
		predicateWait.frameStarted = curFrame;
		LinkedListNode<PredicateWait> linkedListNode = waiting.AddLast(predicateWait);
		return promise;
	}

	public bool Cancel(IPromise promise)
	{
		LinkedListNode<PredicateWait> linkedListNode = FindInWaiting(promise);
		if (linkedListNode != null)
		{
			PredicateWait item = linkedListNode.item;
			PromiseCancelledException ex = default;
			ex._002Ector("Promise was cancelled by user.");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
			waiting.Remove(linkedListNode);
		}
		return linkedListNode != null;
	}

	private LinkedListNode<PredicateWait> FindInWaiting(IPromise promise)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		LinkedList<PredicateWait> linkedList = waiting;
		LinkedListNode<PredicateWait> linkedListNode = linkedList.head;
		object obj3 = default;
		while (linkedListNode != null)
		{
			PredicateWait item = linkedListNode.item;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			if (obj3 == null)
			{
				break;
			}
			LinkedListNode<PredicateWait> linkedListNode2;
			if (linkedListNode.next != null)
			{
				LinkedList<PredicateWait> list = linkedListNode.list;
				bool flag = linkedListNode.next == list.head;
				linkedListNode2 = null;
				if (!flag)
				{
					linkedListNode2 = linkedListNode.next;
				}
			}
			else
			{
				linkedListNode2 = null;
			}
			linkedListNode = linkedListNode2;
		}
		return linkedListNode;
	}

	public void Update(float deltaTime)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0470: Unknown result type (might be due to invalid IL or missing references)
		//IL_0475: Expected Obj, but got Unknown
		//IL_005a: Expected VT, but got F4
		//IL_0076: Expected Obj, but got I4
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected Obj, but got Unknown
		//IL_0125: Expected Obj, but got I
		//IL_03a5: Expected Obj, but got I
		//IL_024d: Expected Obj, but got I
		//IL_0278: Expected Obj, but got I
		//IL_029d: Expected Obj, but got I
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Expected Obj, but got Unknown
		//IL_02e6: Expected Obj, but got I
		//IL_0305: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 32;
		object obj3 = obj + 24;
		_ = 0;
		float num = curTime + deltaTime;
		curTime = num;
		int num2 = curFrame + 1;
		curFrame = num2;
		LinkedList<PredicateWait> linkedList = waiting;
		LinkedListNode<PredicateWait> linkedListNode = linkedList.head;
		PromiseTimer promiseTimer = default;
		object obj6 = default;
		object obj7 = default;
		object obj8 = default;
		object obj10 = default;
		object obj12 = default;
		object obj13 = default;
		object obj22 = default;
		while (linkedListNode != null)
		{
			PredicateWait item = linkedListNode.item;
			float num3 = promiseTimer.curTime - item.timeStarted;
			float num4 = num3 - (float)item.timeData;
			item.timeData = (TimeData)num3;
			object obj4 = promiseTimer.curFrame - item.frameStarted;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S1_v14 (RSG.PredicateWait)+1C]");
			_ = 0;
			_ = item.timeData;
			object obj5 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj6 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B7");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					LinkedListNode<PredicateWait> linkedListNode2 = ((PromiseTimer)0).RemoveNode(linkedListNode);
					linkedListNode = linkedListNode2;
					continue;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				bool flag = obj7 == obj8;
				bool flag2 = !flag;
				object obj9 = obj10;
				if (!flag2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						object obj11 = obj12;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							if (obj13 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
								object obj14 = (nint)0 << 2;
								object obj15 = obj3 + obj14;
								obj15 = obj12;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
								object obj16 = (nint)0 + (nint)1;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
								object obj17 = (nint)0 << 2;
								object obj18 = obj17 + obj3;
								object obj19 = obj18 - 4;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								LinkedListNode<PredicateWait> linkedListNode3 = ((PromiseTimer)0).RemoveNode(linkedListNode);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
								object obj20 = -1;
								linkedListNode = linkedListNode3;
								continue;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
							object obj21 = obj12;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								break;
							}
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					promiseTimer = (PromiseTimer)0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag3 = (nint)0 == 1;
					obj9 = obj22;
					if (flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
						break;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			}
			LinkedListNode<PredicateWait> linkedListNode4;
			if (linkedListNode.next != null)
			{
				LinkedList<PredicateWait> list = linkedListNode.list;
				bool flag4 = linkedListNode.next == list.head;
				linkedListNode4 = null;
				if (!flag4)
				{
					linkedListNode4 = linkedListNode.next;
				}
			}
			else
			{
				linkedListNode4 = null;
			}
			linkedListNode = linkedListNode4;
		}
	}

	private LinkedListNode<PredicateWait> RemoveNode(LinkedListNode<PredicateWait> node)
	{
		LinkedListNode<PredicateWait> result;
		if (node.next != null)
		{
			LinkedList<PredicateWait> list = node.list;
			bool flag = node.next == list.head;
			result = null;
			if (!flag)
			{
				result = node.next;
			}
		}
		else
		{
			result = null;
		}
		waiting.Remove(node);
		return result;
	}

	public PromiseTimer()
	{
		LinkedList<PredicateWait> linkedList = default;
		waiting = linkedList;
	}
}
