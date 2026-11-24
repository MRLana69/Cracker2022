using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;
using SYBO.Components.Analytics.Albatross;
using UnityEngine;

namespace SYBO.Components.Utilities;

[Serializable]
public class PrefabPool
{
	private class Comparer : IComparer<PrefabPool>
	{
		int IComparer<PrefabPool>.Compare(PrefabPool x, PrefabPool y)
		{
			//IL_0017: Expected I4, but got Obj
			return (object)x.prefab - (object)y.prefab;
		}

		public Comparer()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	public Transform prefab;

	internal GameObject prefabGO;

	public int preloadAmount;

	public bool limitInstances;

	public int limitAmount;

	public bool limitFIFO;

	public bool cullDespawned;

	public int cullAbove;

	public SpawnPool spawnPool;

	[NonSerialized]
	public int maxActive;

	[NonSerialized]
	public int loadedOnDemand;

	private bool initialized;

	internal LinkedList<PooledInstanceData> _spawned;

	internal LinkedList<PooledInstanceData> _despawned;

	private static IComparer<PrefabPool> _comparer;

	public LinkedList<PooledInstanceData> spawned
	{
		get
		{
			//IL_0019: Expected Obj, but got I4
			LinkedList<PooledInstanceData> linkedList = _despawned;
			return (LinkedList<PooledInstanceData>)linkedList.count;
		}
	}

	public LinkedList<PooledInstanceData> despawned
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			LinkedList<PooledInstanceData> linkedList = default;
			linkedList._002Ector((IEnumerable<PooledInstanceData>)_spawned);
			return linkedList;
		}
	}

	public int totalCount
	{
		get
		{
			//IL_0023: Expected I4, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			LinkedList<PooledInstanceData> linkedList = default;
			linkedList._002Ector((IEnumerable<PooledInstanceData>)_despawned);
			return (int)linkedList;
		}
	}

	public static IComparer<PrefabPool> comparer
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_06dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_06e2: Expected Obj, but got Unknown
			//IL_06eb: Expected Obj, but got I4
			//IL_06f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_06f9: Expected Obj, but got Unknown
			//IL_0715: Expected I, but got Obj
			//IL_072b: Expected Obj, but got I
			//IL_07c8: Expected I, but got Obj
			//IL_07de: Expected Obj, but got I
			//IL_0021: Expected I, but got Obj
			//IL_09ac: Expected I, but got Obj
			//IL_09c2: Expected Obj, but got I
			//IL_0142: Expected I, but got Obj
			//IL_008a: Expected I, but got Obj
			//IL_00a0: Expected Obj, but got I
			//IL_00bd: Expected I, but got Obj
			//IL_075e: Expected Obj, but got I
			//IL_077e: Expected I, but got Obj
			//IL_0794: Expected Obj, but got I
			//IL_02e9: Expected I, but got Obj
			//IL_02ff: Expected Obj, but got I
			//IL_020e: Expected I, but got Obj
			//IL_00d9: Expected I, but got Obj
			//IL_0109: Expected I, but got Obj
			//IL_0879: Expected Obj, but got I4
			//IL_025b: Expected I, but got Obj
			//IL_0271: Expected Obj, but got I
			//IL_01a8: Expected I, but got Obj
			//IL_032a: Expected I, but got Obj
			//IL_0846: Unknown result type (might be due to invalid IL or missing references)
			//IL_084b: Expected I4, but got Unknown
			//IL_085d: Expected I4, but got Obj
			//IL_012f: Expected I, but got Obj
			//IL_029c: Expected I, but got Obj
			//IL_04f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_04f8: Expected Obj, but got Unknown
			//IL_0501: Unknown result type (might be due to invalid IL or missing references)
			//IL_0506: Expected Obj, but got Unknown
			//IL_0532: Expected Obj, but got I4
			//IL_09fb: Expected I, but got Obj
			//IL_0a11: Expected Obj, but got I
			//IL_05dd: Expected Obj, but got I
			//IL_03d6: Expected I, but got Obj
			//IL_03ec: Expected Obj, but got I
			//IL_08ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_08b0: Expected Obj, but got Unknown
			//IL_0695: Expected I, but got Obj
			//IL_0613: Unknown result type (might be due to invalid IL or missing references)
			//IL_0618: Expected Obj, but got Unknown
			//IL_047a: Unknown result type (might be due to invalid IL or missing references)
			//IL_047f: Expected Obj, but got Unknown
			//IL_0490: Unknown result type (might be due to invalid IL or missing references)
			//IL_0495: Expected Obj, but got Unknown
			//IL_0417: Expected I, but got Obj
			//IL_04c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_04cd: Expected Obj, but got Unknown
			//IL_0649: Unknown result type (might be due to invalid IL or missing references)
			//IL_064e: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 32;
			object obj3 = obj2 + 8;
			obj3 = 0;
			object obj4 = obj2 + 16;
			obj4 = obj;
			_ = -1;
			nint num = (nint)typeof(PoolManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v17 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num2 = (nint)typeof(PoolManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v267 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			ICollection<string> keys = PoolManager.Pools.Keys;
			IEnumerable<_00210> enumerable = (IEnumerable<_00210>)((object)keys << 1);
			if (PoolManager._priorities == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				List<> list = default;
				((List<T>)(object)list)._002Ector((IEnumerable<T>)enumerable);
				nint num3 = (nint)typeof(PoolManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S0_v247 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				bool flag = obj6 == null;
				nint num4 = (nint)typeof(PoolManager);
				if (!flag)
				{
					nint num5 = (nint)typeof(PoolManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S0_v261 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(PoolManager);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(PoolManager);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ L0_v32 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+5C]");
				object obj7 = (nint)0 + (nint)20;
				obj7 = list;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num6 = (nint)typeof(PoolManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ S0_v258 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+5C]");
				object obj8 = (nint)0 + (nint)24;
				object obj9 = default;
				obj8 = obj9;
			}
			bool flag5;
			while (true)
			{
				nint num7 = (nint)typeof(PoolManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v33 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
				object obj10 = (nint)0 & (nint)0x200;
				if (obj10 != null)
				{
					nint num8 = (nint)typeof(PoolManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v237 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				List<PoolManager.PoolPriority> priorities = PoolManager._priorities;
				bool flag4 = priorities._size < (nint)enumerable;
				nint num9 = (nint)typeof(PoolManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S1_v16 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
				object obj11 = (nint)0 & (nint)0x200;
				flag5 = obj11 != null;
				if (!flag4)
				{
					break;
				}
				if (flag5)
				{
					nint num10 = (nint)typeof(PoolManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S0_v231 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F73");
			}
			if (flag5)
			{
				nint num11 = (nint)typeof(PoolManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S0_v220 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			List<PoolManager.PoolPriority> priorities2 = PoolManager._priorities;
			if (priorities2._size > (nint)enumerable)
			{
				nint num12 = (nint)typeof(PoolManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ S0_v207 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
				object obj12 = (nint)0 & (nint)0x200;
				if (obj12 != null)
				{
					nint num13 = (nint)typeof(PoolManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ S0_v214 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				List<PoolManager.PoolPriority> priorities3 = PoolManager._priorities;
				int count = priorities3._size - enumerable;
				((List<T>)(object)PoolManager._priorities).Reverse((int)enumerable, count);
			}
			nint num14 = (nint)typeof(PoolManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ S0_v56 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
			object obj13 = (nint)0 & (nint)0x200;
			if (obj13 != null)
			{
				nint num15 = (nint)typeof(PoolManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ S0_v200 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			IEnumerator enumerator = PoolManager.Pools.System_002ECollections_002EIEnumerable_002EGetEnumerator();
			object obj14 = 0;
			IComparer<PrefabPool> comparer = null;
			object obj15 = default;
			object obj16 = default;
			object obj20 = default;
			object obj21 = default;
			object obj24 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				if (obj15 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
				obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				IComparer<PrefabPool> comparer2 = (IComparer<PrefabPool>)(object)(obj16 + (object)comparer);
				nint num16 = (nint)typeof(PoolManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v529 @ S0_v154 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
				object obj17 = (nint)0 & (nint)0x200;
				if (obj17 != null)
				{
					nint num17 = (nint)typeof(PoolManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v538 @ S0_v191 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						comparer = comparer2;
					}
				}
				object obj18 = obj14 + 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				comparer = comparer2;
				_ = 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ S0_v146+C]");
				_ = 0;
				object obj19 = obj20 + 16;
				obj19 = obj21;
				object obj22 = obj18 + 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				comparer = comparer2;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ S0_v146+10]");
				_ = 0;
				object obj23 = obj24 + 16;
				obj23 = obj21;
				obj14 = obj22;
				comparer = comparer2;
			}
			object obj25 = obj4 + 4;
			object obj26 = obj25 + 1;
			obj25 = obj26;
			object obj27 = obj26 << 2;
			object obj28 = obj4 + obj27;
			obj28 = 255;
			IComparer<PrefabPool> result = comparer;
			if (enumerator != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v14+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v14+4]");
				object obj29 = (nint)0 << 2;
				object obj30 = obj4 + obj29;
				if ((nint)obj30 == 255)
				{
					object obj31 = obj4 + 4;
					if ((nint)obj31 > -1)
					{
						object obj32 = obj31 + -1;
						obj31 = obj32;
					}
					goto IL_09ed;
				}
			}
			object obj33 = default;
			if (obj33 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
			goto IL_09ed;
			IL_09ed:
			nint num18 = (nint)typeof(PoolManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ S0_v81 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
			object obj34 = (nint)0 & (nint)0x200;
			if (obj34 != null)
			{
				nint num19 = (nint)typeof(PoolManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ S0_v90 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((List<T>)(object)PoolManager._priorities).Sort((Comparison<T>)(object)PoolManager._comparer);
			return result;
		}
	}

	public PrefabPool(Transform prefab)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		NotSupportedException ex = default;
		ex._002Ector();
		((SpawnPool)(object)ex).RemoveAt(0);
	}

	public PrefabPool()
	{
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected Obj, but got Unknown
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected Obj, but got Unknown
		//IL_001b: Expected Obj, but got I
		//IL_002b: Expected Obj, but got I
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected Obj, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected Obj, but got Unknown
		//IL_0077: Expected I4, but got F4
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected Obj, but got Unknown
		//IL_00c2: Expected Obj, but got I
		//IL_00d2: Expected Obj, but got I
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected Obj, but got Unknown
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected Obj, but got Unknown
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected Obj, but got Unknown
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected Obj, but got Unknown
		object obj = this + 24;
		obj = "";
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
		object obj2 = this + 32;
		object obj3 = default;
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S3_v3+60]");
		object obj5 = (object)((object)0 & 0x1FFF) + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v44 @ S4_v4 (should have been resolved before IL gen)");
		object obj6 = this + 36;
		object obj7 = default;
		obj6 = obj7;
		maxActive = 300;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		AssetLoader assetLoader = default;
		assetLoader._002Ector();
		object obj8 = this + 48;
		obj8 = assetLoader;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S3_v7 (Il2CppMethodInfo)+C]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S3_v8+60]");
		object obj10 = 0;
		object obj11 = obj10;
		object obj12 = obj11 & 0x1FFF;
		object obj13 = obj12 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v78 @ S4_v8 (should have been resolved before IL gen)");
		object obj14 = this + 52;
		object obj15 = default;
		obj14 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<PrefabPool> list = default;
		list._002Ector();
		object obj16 = this + 56;
		obj16 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}

	internal void inspectorInstanceConstructor()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		preloadAmount = 1;
		limitAmount = 100;
		cullAbove = 50;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj = this + 52;
		object obj2 = default;
		obj = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj3 = this + 56;
		object obj4 = default;
		obj3 = obj4;
	}

	internal void SelfDestruct()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected Obj, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected Obj, but got Unknown
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		object obj = this + 12;
		string tag = prefab.tag;
		obj = tag;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = this + 52;
		object obj3 = default;
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj4 = this + 56;
		object obj5 = default;
		obj4 = obj5;
	}

	internal bool DespawnInstance(Transform xform)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		NotSupportedException ex = default;
		ex._002Ector();
		((ICollection<Transform>)ex).Remove((Transform)null);
		return false;
	}

	internal bool DespawnInstance(Transform xform, bool sendEventMessage)
	{
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected Obj, but got Unknown
		//IL_017b: Expected I, but got Obj
		//IL_0191: Expected Obj, but got I
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected Obj, but got Unknown
		//IL_0114: Expected Obj, but got I
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected Obj, but got Unknown
		//IL_014d: Expected Obj, but got I4
		//IL_0151: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v33 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 16;
		Vector3 one = Vector3.one;
		nint num3 = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v16 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v29 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector2 zero = Vector2.zero;
		Dictionary<string, string> dictionary = (Dictionary<string, string>)(obj3 + 28);
		dictionary = (Dictionary<string, string>)obj2;
		Dictionary<string, string> dictionary2 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v14+8]");
		dictionary2.buckets = (int[])0;
		byte[] array = (byte[])(obj3 + 40);
		array = (byte[])obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		return (byte)(int)((MinimalHTTPPost)this).WaitForWWWRequest((string)(object)xform, dictionary, array, (Action<int, string, string>)sendEventMessage) != 0;
	}

	internal unsafe Transform SpawnInstance(Vector3 pos, Quaternion rot)
	{
		//IL_029b: Expected I, but got Obj
		//IL_02b1: Expected Obj, but got I
		//IL_0330: Expected Obj, but got VT
		//IL_0013: Expected I, but got Obj
		//IL_00ea: Expected Obj, but got I
		//IL_00fe: Expected Obj, but got I
		//IL_010c: Invalid comparison between VT and I4
		//IL_02d7: Expected Obj, but got VT
		//IL_02f8: Invalid comparison between VT and I4
		//IL_01c7: Expected VT, but got I4
		//IL_0365: Invalid comparison between VT and I4
		//IL_0381: Expected VT, but got Obj
		//IL_0381: Expected Obj, but got VT
		//IL_0184: Invalid comparison between F4 and Obj
		//IL_0317: Expected Obj, but got I4
		//IL_01b9: Expected VT, but got I4
		//IL_014f: Expected Obj, but got VT
		//IL_016c: Expected Obj, but got I4
		//IL_0167: Expected native int or pointer, but got Obj
		//IL_020d: Expected I, but got Obj
		//IL_0223: Expected Obj, but got I
		//IL_024e: Expected I, but got Obj
		nint num = (nint)typeof(PoolManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(PoolManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v52 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Transform transform = PoolManager.Spawn((Transform)pos);
		if ((object)transform == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v11 (UnityEngine.Transform)+C]");
		if ((nint)0 == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NotSupportedException ex2 = default;
			ex2._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		_ = 0;
		_spawned.Remove((LinkedListNode<PooledInstanceData>)(nint)((UnityEngine.Object)transform).m_CachedPtr);
		_despawned.AddLast((LinkedListNode<PooledInstanceData>)(nint)((UnityEngine.Object)transform).m_CachedPtr);
		if (rot != (Quaternion)(object)0)
		{
			SpawnPool spawnPool = this.spawnPool;
			if (~(spawnPool.sendUnityEvents ? 1u : 0u) == 0)
			{
				string tag = ((Component)pos).tag;
				System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)tag, new UnityEngine.UnitySynchronizationContext.WorkRequest((SendOrPostCallback)(object)"OnDespawned", this.spawnPool, (ManualResetEvent)1));
			}
		}
		string tag2 = ((Component)pos).tag;
		((GameObject)(object)tag2).tag = null;
		SpawnPool spawnPool2 = this.spawnPool;
		Vector3 vector;
		if (pos == (Vector3)(object)0)
		{
			vector = (Vector3)0;
		}
		else
		{
			vector = (((object)pos.x != typeof(RectTransform)) ? ((Vector3)0) : pos);
		}
		bool relativeTo = vector == (Vector3)(object)0;
		((Transform)pos).Translate((Vector3)spawnPool2.group__BackingField, relativeTo ? Space.Self : Space.World);
		if (~(cullDespawned ? 1u : 0u) == 0)
		{
			Transform transform2 = SpawnNew();
			if ((nint)transform2 > cullAbove)
			{
				nint num3 = (nint)typeof(PoolManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S1_v22 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(PoolManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S1_v27 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				PoolManager.BeginBalancing((Action<float>)(object)this.spawnPool);
			}
		}
		return (Transform)1;
	}

	public Transform SpawnNew()
	{
		//IL_0030: Expected Obj, but got I4
		LinkedList<PooledInstanceData> linkedList = _despawned;
		LinkedList<PooledInstanceData> linkedList2 = _spawned;
		return (Transform)(linkedList.count + linkedList2.count);
	}

	public unsafe Transform SpawnNew(Vector3 pos, Quaternion rot)
	{
		//IL_0353: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Expected Ref, but got Unknown
		//IL_020e: Expected Obj, but got F4
		//IL_0220: Expected I4, but got F4
		//IL_022d: Expected Ref, but got F4
		//IL_034a: Expected Obj, but got I4
		//IL_02e1: Expected I, but got Obj
		//IL_02f7: Expected Obj, but got I
		//IL_0170: Expected Ref, but got F4
		//IL_0183: Expected Obj, but got Ref
		//IL_0194: Expected Ref, but got F4
		//IL_01a7: Expected Obj, but got Ref
		//IL_00f8: Expected I, but got Obj
		//IL_01d0: Expected Obj, but got I4
		//IL_01e2: Expected I4, but got Obj
		if (~(limitInstances ? 1u : 0u) == 0 && ~(limitFIFO ? 1u : 0u) == 0)
		{
			LinkedList<PooledInstanceData> linkedList = _spawned;
			if (linkedList.count >= limitAmount)
			{
				LinkedList<PooledInstanceData> linkedList2 = _spawned;
				LinkedListNode<PooledInstanceData> head = linkedList2.head;
				PooledInstanceData item = head.item;
				bool flag = Contains(item.transform__BackingField);
			}
		}
		string text = default;
		ref Transform reference = ref *(Transform*)(text + 16);
		LinkedList<PooledInstanceData> linkedList3 = _despawned;
		bool flag2 = default;
		if (linkedList3.count != 0)
		{
			LinkedList<PooledInstanceData> linkedList4 = _despawned;
			LinkedListNode<PooledInstanceData> linkedListNode;
			if (linkedList4.head != null)
			{
				LinkedListNode<PooledInstanceData> head2 = linkedList4.head;
				linkedListNode = head2.prev;
			}
			else
			{
				linkedListNode = null;
			}
			PooledInstanceData item2 = linkedListNode.item;
			PooledInstanceData item3 = linkedListNode.item;
			item3.inUse = true;
			_despawned.Remove(linkedListNode);
			_spawned.AddLast(linkedListNode);
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S0_v58 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S0_v78 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (item2.transform__BackingField != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				object sender = default;
				UnityEngine.UnhandledExceptionHandler._003CRegisterUECatcher_003Em__0(sender, (UnhandledExceptionEventArgs)(object)"Make sure you didn't delete a despawned instance directly.");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
			else
			{
				reference = ref *(Transform*)pos.x;
				_ = pos.z;
				Vector3 localPosition = ((Transform)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference)).localPosition;
				reference = ref *(Transform*)rot.x;
				_ = rot.z;
				Quaternion localRotation = ((Transform)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference)).localRotation;
				string tag = item2.transform__BackingField.tag;
				((GameObject)(object)tag).tag = (string)1;
				flag2 = (byte)(int)item2.transform__BackingField != 0;
			}
		}
		else
		{
			int num3 = loadedOnDemand + 1;
			loadedOnDemand = num3;
			text = (string)pos.x;
			text.m_stringLength = (int)pos.z;
			reference = ref *(Transform*)rot.x;
			_ = rot.z;
			bool flag3 = ((PrefabsDict)this).TryGetValue(text, out reference);
			flag2 = flag3;
		}
		LinkedList<PooledInstanceData> linkedList5 = _spawned;
		if (linkedList5.count > maxActive)
		{
			LinkedList<PooledInstanceData> linkedList6 = _spawned;
			maxActive = linkedList6.count;
		}
		return (Transform)flag2;
	}

	private void SetRecursively(Transform xform, int layer)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		NotSupportedException ex = default;
		ex._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
	}

	internal void AddUnpooled(Transform inst, bool despawn)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected Obj, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected Obj, but got Unknown
		//IL_00aa: Expected Obj, but got I4
		//IL_0166: Expected Obj, but got I
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Expected Obj, but got Unknown
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		string tag = inst.tag;
		((GameObject)(object)tag).SetActive(despawn);
		object current = ((Transform.Enumerator)(object)inst).Current;
		object obj3 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj3 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
		}
		object obj4 = obj2 + 4;
		object obj5 = obj4 + 1;
		obj4 = obj5;
		object obj6 = obj5 << 2;
		object obj7 = obj2 + obj6;
		obj7 = 68;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
		object obj8 = default;
		if (obj8 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj9 = (nint)0 << 2;
			object obj10 = obj2 + obj9;
			if ((nint)obj10 == 68)
			{
				object obj11 = obj2 + 4;
				if ((nint)obj11 > -1)
				{
					object obj12 = obj11 + -1;
					obj11 = obj12;
				}
				return;
			}
		}
		object obj13 = default;
		if (obj13 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	public bool Contains(Transform transform)
	{
		//IL_000f: Expected VT, but got I4
		//IL_000f: Expected VT, but got Obj
		Transform transform2 = SpawnInstance((Vector3)transform, (Quaternion)1);
		return true;
	}

	private void nameInstance(Transform instance)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected Obj, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		preloadAmount = 1;
		limitAmount = 100;
		cullAbove = 50;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj = this + 52;
		object obj2 = default;
		obj = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj3 = this + 56;
		object obj4 = default;
		obj3 = obj4;
		object obj5 = this + 8;
		obj5 = instance;
		object obj6 = this + 12;
		string tag = instance.tag;
		obj6 = tag;
	}
}
