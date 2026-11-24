using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected;
using Info;
using SYBO.Components.Utilities;
using SYBO.Subway.Level;
using SYBO.Subway.Placeholders;
using SYBO.Subway.Placeholders.PrefabProviders;
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
				//IL_0007: Expected I4, but got Obj
				return (byte)(int)Chunk != 0;
			}
		}

		public WorkWrapper(RouteChunk chunk, Stack<IEnumerator> workStack, WorkType workType)
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Expected Obj, but got Unknown
			//IL_00b0: Expected I4, but got Obj
			//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bb: Expected Obj, but got Unknown
			//IL_00c3: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(EventArgs);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.EventArgs>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(EventArgs);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v15 (Il2CppClass<System.EventArgs>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj2 = this + 8;
			obj2 = chunk;
			WorkType = (WorkType)workStack;
			object obj3 = this + 12;
			obj3 = workType;
		}

		public bool Work()
		{
			Stack<IEnumerator> workStack = _workStack;
			return workStack._size == 0;
		}

		public void WorkUntilDone()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
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
		//IL_01e7: Expected Obj, but got I
		//IL_001b: Expected Obj, but got I
		//IL_0055: Expected Obj, but got I
		//IL_006e: Expected Obj, but got I
		//IL_0085: Expected I, but got Obj
		//IL_009b: Expected Obj, but got I
		//IL_01c4: Expected Obj, but got I4
		//IL_0120: Expected I, but got Obj
		//IL_0136: Expected Obj, but got I
		//IL_00c6: Expected I, but got Obj
		//IL_0161: Expected I, but got Obj
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Routes.Builders.Worker.RouteBuilderWorker)+B8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v8+C]");
			if ((nint)0 <= (nint)0)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Routes.Builders.Worker.RouteBuilderWorker)+B8]");
			RouteSection routeSection = ((List<RouteSection>)0).get_Item(0);
			IRouteTransitionTrigger transitionTrigger = routeSection.GetTransitionTrigger();
			if (transitionTrigger != null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Routes.Builders.Worker.RouteBuilderWorker)+B8]");
			RouteSection routeSection2 = ((List<RouteSection>)0).get_Item(0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Routes.Builders.Worker.RouteBuilderWorker)+B8]");
			bool flag = ((List<RouteSection>)0).Remove(routeSection2);
			nint num = (nint)typeof(GamePositionRoot);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v23 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(GamePositionRoot);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v31 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool isRestricted = AgeRestriction.isRestricted;
			GameObject gameObject = routeSection2.gameObject;
			((GamePositionRoot)isRestricted).AddLock(gameObject);
			GameObject gameObject2 = routeSection2.gameObject;
			nint num3 = (nint)typeof(PoolManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S1_v13 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(PoolManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S1_v18 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			PoolManager.AddPool((PrefabPool)(object)gameObject2);
		}
	}

	public void EnqueueSpawnWork(RouteChunk chunk, IEnumerator workRoutine, bool instantComplete = false)
	{
		//IL_0015: Expected Obj, but got I
		//IL_016c: Expected Obj, but got I
		//IL_017a: Expected I, but got Obj
		//IL_0190: Expected Obj, but got I
		//IL_0059: Expected Obj, but got I
		//IL_006a: Expected F4, but got Obj
		//IL_007d: Expected I, but got Obj
		//IL_01bb: Expected Obj, but got I4
		//IL_00d1: Invalid comparison between VT and I
		//IL_0118: Expected Obj, but got I
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
		object obj = default;
		if (obj == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Routes.Builders.Worker.RouteBuilderWorker)+CC]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v11+C]");
		if ((nint)0 >= (nint)1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Routes.Builders.Worker.RouteBuilderWorker)+CC]");
			RouteBuilder.EnvironmentRangeWrapper environmentRangeWrapper = Enumerable.Last((IEnumerable<RouteBuilder.EnvironmentRangeWrapper>)0);
			environmentRangeWrapper.EndGamePositionZ = (float)workRoutine;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Routes.Builders.Worker.RouteBuilderWorker)+D0]");
		object obj3 = 0;
		nint num = (nint)typeof(EnvironmentKind);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v18 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(EnvironmentKind);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v39 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		IntPtr cachedPtr = ((UnityEngine.Object)chunk).m_CachedPtr;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v16+8]");
		bool flag;
		if (cachedPtr == (IntPtr)0)
		{
			Vector3 logicHideOffset = chunk.LogicHideOffset;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v16+C]");
			flag = logicHideOffset == (Vector3)(object)0;
		}
		else
		{
			flag = false;
		}
		object obj5 = (flag ? 1 : 0) ^ 1;
		if (obj5 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9754");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Routes.Builders.Worker.RouteBuilderWorker)+CC]");
			RouteBuilder.EnvironmentRangeWrapper value = default;
			LinkedListNode<RouteBuilder.EnvironmentRangeWrapper> linkedListNode = ((LinkedList<RouteBuilder.EnvironmentRangeWrapper>)0).AddLast(value);
			object obj6 = this + 208;
			obj6 = chunk;
		}
	}

	public void EnqueueDespawnWork(RouteChunk chunk, IEnumerator workRoutine, bool instantComplete = false)
	{
		//IL_0017: Expected I4, but got Obj
		((SelectionPlaceholderLifecycle)this).SpawnInstances((PlaceholderPrefabProviderBase)(object)chunk, (byte)(int)workRoutine != 0, false, instantComplete);
	}

	private unsafe void EnqueueWork(RouteChunk chunk, IEnumerator workRoutine, WorkType workType, bool instantComplete = false)
	{
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected Obj, but got Unknown
		//IL_0130: Expected Obj, but got I4
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected Obj, but got Unknown
		//IL_014d: Expected Obj, but got I4
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected Obj, but got Unknown
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected Obj, but got Unknown
		//IL_01a4: Expected I, but got Obj
		//IL_01ba: Expected Obj, but got I
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected VT, but got Unknown
		//IL_01f2: Expected F4, but got Obj
		//IL_01ed: Expected native int or pointer, but got VT
		//IL_0207: Expected F4, but got I
		//IL_0202: Expected native int or pointer, but got VT
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected VT, but got Unknown
		//IL_0222: Expected F4, but got Obj
		//IL_021d: Expected native int or pointer, but got VT
		//IL_0237: Expected F4, but got I
		//IL_0232: Expected native int or pointer, but got VT
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Expected Obj, but got Unknown
		//IL_027d: Expected F4, but got I4
		//IL_0278: Expected native int or pointer, but got VT
		//IL_0292: Expected F4, but got I
		//IL_028d: Expected native int or pointer, but got VT
		//IL_02a4: Expected F4, but got I4
		//IL_029f: Expected native int or pointer, but got VT
		//IL_02b9: Expected F4, but got I
		//IL_02b4: Expected native int or pointer, but got VT
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Expected Obj, but got Unknown
		//IL_005f: Expected F4, but got Obj
		//IL_005a: Expected native int or pointer, but got VT
		//IL_0074: Expected F4, but got I
		//IL_006f: Expected native int or pointer, but got VT
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected Obj, but got Unknown
		//IL_009c: Expected F4, but got Obj
		//IL_0097: Expected native int or pointer, but got VT
		//IL_00b1: Expected F4, but got I
		//IL_00ac: Expected native int or pointer, but got VT
		//IL_00be: Expected F4, but got Obj
		//IL_00b9: Expected native int or pointer, but got VT
		//IL_00d3: Expected F4, but got I
		//IL_00ce: Expected native int or pointer, but got VT
		//IL_0013: Expected I, but got Obj
		//IL_00f6: Expected F4, but got Obj
		//IL_00f1: Expected native int or pointer, but got VT
		//IL_010b: Expected F4, but got I
		//IL_0106: Expected native int or pointer, but got VT
		//IL_0114: Expected Obj, but got VT
		object obj2 = default;
		object obj = obj2 + 104;
		obj = 0;
		_ = 0;
		object obj3 = obj2 + 88;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 76;
		obj4 = chunk;
		_ = ((UnityEngine.Object)chunk).m_CachedPtr;
		object obj5 = obj2 - -64;
		obj5 = workRoutine;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [workRoutine @ L2 (System.Collections.IEnumerator)+8]");
		_ = 0;
		nint num = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v21 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num2 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v47 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Quaternion quaternion = (Quaternion)(obj2 + 120);
		((Quaternion*)(nint)quaternion)->x = (float)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
		((Quaternion*)(nint)quaternion)->z = 0f;
		Quaternion quaternion2 = (Quaternion)(obj2 + 136);
		((Quaternion*)(nint)quaternion2)->x = (float)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v18+8]");
		((Quaternion*)(nint)quaternion2)->z = 0f;
		object obj7 = obj2 + 48;
		Quaternion quaternion3 = quaternion * quaternion2;
		obj = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v32+8]");
		_ = 0;
		((Quaternion*)(nint)quaternion)->x = ((WorkType*)(int)workType)->value__;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [workType @ L3 (SYBO.Subway.Routes.Builders.Worker.RouteBuilderWorker+WorkType)+8]");
		((Quaternion*)(nint)quaternion)->z = 0f;
		((Quaternion*)(nint)quaternion2)->x = (((bool*)(instantComplete ? 1 : 0))->m_value ? 1 : 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [instantComplete @ L4 (System.Boolean)+8]");
		((Quaternion*)(nint)quaternion2)->z = 0f;
		object obj8 = obj2 + 32;
		Quaternion quaternion4 = quaternion * quaternion2;
		obj3 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v40+8]");
		_ = 0;
		int layer = ((GameObject)this).layer;
		((Quaternion*)(nint)quaternion2)->x = (float)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		((Quaternion*)(nint)quaternion2)->z = 0f;
		object obj9 = obj2 + 16;
		Quaternion quaternion5 = Quaternion.Internal_FromEulerRad((Vector3)quaternion2);
		((Quaternion*)(nint)quaternion)->x = (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((Quaternion*)(nint)quaternion)->z = 0f;
		((Quaternion*)(nint)quaternion2)->x = (float)obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S1_v54+8]");
		((Quaternion*)(nint)quaternion2)->z = 0f;
		Vector3 vector = quaternion * (Vector3)quaternion2;
		((Quaternion*)(nint)quaternion2)->x = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Quaternion*)(nint)quaternion2)->z = 0f;
		Quaternion localRotation = ((Transform)quaternion2).localRotation;
	}

	private void SwitchActiveWorkQueue()
	{
		//IL_00b8: Expected Obj, but got I
		//IL_00c8: Expected Obj, but got I
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected Obj, but got Unknown
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected Obj, but got Unknown
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected Obj, but got Unknown
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected Obj, but got Unknown
		//IL_0137: Expected Obj, but got I
		//IL_0147: Expected Obj, but got I
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected Obj, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected Obj, but got Unknown
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected Obj, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_0029: Expected Obj, but got I
		//IL_0039: Expected Obj, but got I
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected Obj, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected Obj, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S3_v3+60]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v28 @ S4_v4 (should have been resolved before IL gen)");
		object obj6 = this + 8;
		object obj7 = default;
		obj6 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj9 = default;
		object obj8 = obj9 + 8;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S1_v7 (Il2CppMethodInfo)+C]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v8+60]");
		object obj11 = 0;
		object obj12 = obj11;
		object obj13 = obj12 & 0xFFF;
		object obj14 = obj13 + 1797;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v52 @ S2_v5 (should have been resolved before IL gen)");
		object obj15 = default;
		obj8 = obj15;
		object obj16 = this + 12;
		obj16 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj18 = default;
		object obj17 = obj18 + 8;
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S1_v16 (Il2CppMethodInfo)+C]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S1_v17+60]");
		object obj20 = 0;
		object obj21 = obj20;
		object obj22 = obj21 & 0xFFF;
		object obj23 = obj22 + 1797;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v75 @ S2_v9 (should have been resolved before IL gen)");
		object obj24 = default;
		obj17 = obj24;
		object obj25 = this + 16;
		obj25 = obj18;
		object obj26 = this + 20;
		obj26 = _despawnWorkQueue;
	}

	private float ComputeDistanceFactor(float chunkEdgeZ, float requiredDonePositionZ, float workRampupDistance)
	{
		float num = workRampupDistance * chunkEdgeZ;
		return num / requiredDonePositionZ;
	}

	public void UpdateWorker(float reqPositionReadyGameZ, float reqPositionCleanedUpGameZ)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Expected Obj, but got Unknown
		//IL_0246: Expected Obj, but got I4
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected Obj, but got Unknown
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Expected Obj, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected Obj, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected Obj, but got Unknown
		//IL_011e: Expected Obj, but got I4
		//IL_0185: Expected Obj, but got I
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected Obj, but got Unknown
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - -64;
		object obj3 = obj2 + 40;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 32;
		obj4 = obj;
		_ = -1;
		float num = reqPositionReadyGameZ + reqPositionCleanedUpGameZ;
		object obj5 = obj2 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v13+8]");
		_ = 0;
		object obj6 = default;
		object obj7 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj6 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @94F4");
			if (obj7 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23");
			}
		}
		object obj8 = obj4 + 4;
		object obj9 = obj8 + 1;
		obj8 = obj9;
		object obj10 = obj9 << 2;
		object obj11 = obj4 + obj10;
		obj11 = 95;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v8+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v8+4]");
			object obj12 = (nint)0 << 2;
			object obj13 = obj4 + obj12;
			if ((nint)obj13 == 95)
			{
				object obj14 = obj4 + 4;
				if ((nint)obj14 > -1)
				{
					object obj15 = obj14 + -1;
					obj14 = obj15;
				}
				return;
			}
		}
		object obj16 = default;
		if (obj16 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}
}
