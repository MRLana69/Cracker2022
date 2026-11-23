using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Subway.Routes.Builders.Worker;

public class RouteBuilderWorker
{
	private class WorkWrapper
	{
		private readonly Stack<IEnumerator> _workStack;

		public readonly RouteChunk Chunk;

		public readonly WorkType WorkType;

		private int _workIteration;

		public bool IsDone
		{
			get
			{
				Stack<IEnumerator> workStack = _workStack;
				return workStack._size == 0;
			}
		}

		public WorkWrapper(RouteChunk chunk, Stack<IEnumerator> workStack, WorkType workType)
		{
			_workStack = workStack;
			Chunk = chunk;
			WorkType = workType;
		}

		public bool Work()
		{
			if (IsDone)
			{
				return true;
			}
			IEnumerator enumerator = _workStack.Peek();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			object obj = default;
			if (obj == null)
			{
				IEnumerator enumerator2 = _workStack.Pop();
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23B");
				object obj2 = default;
				if (obj2 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23B");
					IEnumerator item = default;
					_workStack.Push(item);
				}
			}
			int workIteration = _workIteration + 1;
			_workIteration = workIteration;
			Stack<IEnumerator> workStack = _workStack;
			return workStack._size == 0;
		}

		public void WorkUntilDone()
		{
			do
			{
				bool flag = Work();
			}
			while (!IsDone);
		}
	}

	private enum WorkType
	{
		Spawning,
		Despawning
	}

	private const float WorkSpeedupDistanceFactorDefault = 0f;

	private const float WorkSpeedupDistanceFactorMax = 1f;

	private const float WorkTimeAllowanceMin = 0.002f;

	private const float WorkTimeAllowanceMax = 0.005f;

	private const int SpawnSpeedupDistance = 100;

	private const int CleanupSpeedupDistance = 1830;

	private Dictionary<RouteChunk, WorkWrapper> _chunkToWorkWrapperMap;

	private Queue<WorkWrapper> _spawnWorkQueue;

	private Queue<WorkWrapper> _despawnWorkQueue;

	private Queue<WorkWrapper> _activeWorkQueue;

	public RouteBuilderWorker()
	{
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v26 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Routes.RouteChunk, SYBO.Subway.Routes.Builders.Worker.RouteBuilderWorker+WorkWrapper>>>)+4] (should have been resolved before IL gen)");
		Dictionary<RouteChunk, WorkWrapper> chunkToWorkWrapperMap = default;
		_chunkToWorkWrapperMap = chunkToWorkWrapperMap;
		nint num3 = 0;
		nint num4 = 0;
		IntPtr intPtr2 = num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v46 @ S2_v5 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Queue`1<SYBO.Subway.Routes.Builders.Worker.RouteBuilderWorker+WorkWrapper>>>)+4] (should have been resolved before IL gen)");
		Queue<WorkWrapper> queue = default;
		WorkWrapper[] array = default;
		queue._array = array;
		_spawnWorkQueue = queue;
		nint num5 = 0;
		nint num6 = 0;
		IntPtr intPtr3 = num6;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v65 @ S2_v10 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Queue`1<SYBO.Subway.Routes.Builders.Worker.RouteBuilderWorker+WorkWrapper>>>)+4] (should have been resolved before IL gen)");
		Queue<WorkWrapper> queue2 = default;
		WorkWrapper[] array2 = default;
		queue2._array = array2;
		_despawnWorkQueue = queue2;
		_activeWorkQueue = _despawnWorkQueue;
	}

	public void EnqueueSpawnWork(RouteChunk chunk, IEnumerator workRoutine, bool instantComplete = false)
	{
		EnqueueWork(chunk, workRoutine, WorkType.Spawning, instantComplete);
	}

	public void EnqueueDespawnWork(RouteChunk chunk, IEnumerator workRoutine, bool instantComplete = false)
	{
		EnqueueWork(chunk, workRoutine, WorkType.Despawning, instantComplete);
	}

	private unsafe void EnqueueWork(RouteChunk chunk, IEnumerator workRoutine, WorkType workType, bool instantComplete = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected Ref, but got Unknown
		//IL_00f6: Expected Obj, but got I
		//IL_0109: Expected Obj, but got I4
		//IL_009b: Expected Obj, but got I
		//IL_0120: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 16;
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v29 @ S2_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Stack`1<System.Collections.IEnumerator>>>)+4] (should have been resolved before IL gen)");
		Stack<IEnumerator> stack = default;
		IEnumerator[] array = default;
		stack._array = array;
		stack.Push(workRoutine);
		WorkWrapper workWrapper = default;
		workWrapper._workStack = stack;
		workWrapper.Chunk = chunk;
		workWrapper.WorkType = workType;
		_ = 0;
		bool flag = _chunkToWorkWrapperMap.TryGetValue(chunk, out *(WorkWrapper*)(obj + 12));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			((WorkWrapper)0).WorkUntilDone();
			bool flag2 = _chunkToWorkWrapperMap.Remove(chunk);
		}
		if (instantComplete)
		{
			workWrapper.WorkUntilDone();
			return;
		}
		nint num3 = 0;
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S5_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Routes.RouteChunk, SYBO.Subway.Routes.Builders.Worker.RouteBuilderWorker+WorkWrapper>>)+5C]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v100 @ S5_v5+4] (should have been resolved before IL gen)");
		object obj4 = 16;
		if (workType == WorkType.Spawning)
		{
			obj4 = 12;
		}
		object obj5 = (object)this + obj4;
		((Queue<WorkWrapper>)obj5).Enqueue(workWrapper);
	}

	private void SwitchActiveWorkQueue()
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected Obj, but got Unknown
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected Obj, but got Unknown
		object obj = this + 20;
		bool flag = _activeWorkQueue == _spawnWorkQueue;
		bool flag2 = !flag;
		Queue<WorkWrapper> queue = _activeWorkQueue;
		object obj2;
		if (!flag2)
		{
			obj2 = this + 16;
			Queue<WorkWrapper> despawnWorkQueue = _despawnWorkQueue;
			if (despawnWorkQueue._size > 0)
			{
				goto IL_0099;
			}
			queue = (Queue<WorkWrapper>)obj;
		}
		if (queue == _despawnWorkQueue)
		{
			obj2 = this + 12;
			goto IL_0099;
		}
		return;
		IL_0099:
		obj = obj2;
	}

	private float ComputeDistanceFactor(float chunkEdgeZ, float requiredDonePositionZ, float workRampupDistance)
	{
		float num = chunkEdgeZ - requiredDonePositionZ;
		bool flag = num < 0f;
		float result = 1f;
		if (!flag)
		{
			bool flag2 = num < workRampupDistance;
			bool flag3 = !flag2;
			result = 0f;
			if (!flag3)
			{
				float num2 = workRampupDistance - num;
				result = num2 / workRampupDistance;
			}
		}
		return result;
	}

	public void UpdateWorker(float reqPositionReadyWorldZ, float reqPositionCleanedUpWorldZ)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00b5: Expected F4, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		SwitchActiveWorkQueue();
		Queue<WorkWrapper> activeWorkQueue = _activeWorkQueue;
		if (activeWorkQueue._size == 0)
		{
			return;
		}
		WorkWrapper workWrapper = _activeWorkQueue.Peek();
		float num;
		if (workWrapper.WorkType == WorkType.Spawning)
		{
			float posStartZ = workWrapper.Chunk.PosStartZ;
			num = ((RouteBuilderWorker)(object)workWrapper).ComputeDistanceFactor(posStartZ, reqPositionReadyWorldZ, 100f);
		}
		else
		{
			Vector3 posEnd = workWrapper.Chunk.PosEnd;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			num = ((RouteBuilderWorker)(object)workWrapper).ComputeDistanceFactor(0f, reqPositionCleanedUpWorldZ, 1830f);
		}
		if (!(num > 0f))
		{
			num = 0f;
		}
		if (num == 1f)
		{
			workWrapper.WorkUntilDone();
		}
		else
		{
			float num2 = Math.Min(num, 1f);
			bool flag = num < 0f;
			float num3 = 0f;
			if (!flag)
			{
				num3 = num2;
			}
			float num4 = num3 * 0.0029999998f;
			float num5 = num4 + 0.002f;
			float realtimeSinceStartup = Time.realtimeSinceStartup;
			float num6;
			do
			{
				bool flag2 = workWrapper.Work();
				float realtimeSinceStartup2 = Time.realtimeSinceStartup;
				num6 = realtimeSinceStartup2 - realtimeSinceStartup;
			}
			while (!workWrapper.IsDone && num5 > num6);
		}
		if (workWrapper.IsDone)
		{
			WorkWrapper workWrapper2 = _activeWorkQueue.Dequeue();
			bool flag3 = _chunkToWorkWrapperMap.Remove(workWrapper.Chunk);
		}
	}
}
