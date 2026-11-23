using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Components.Utilities;

[Serializable]
public class PrefabPool
{
	private class Comparer : IComparer<PrefabPool>
	{
		int IComparer<PrefabPool>.Compare(PrefabPool x, PrefabPool y)
		{
			string name = x.prefab.name;
			string name2 = y.prefab.name;
			return name.CompareTo(name2);
		}
	}

	public Transform prefab;

	internal GameObject prefabGO;

	public int preloadAmount = 1;

	public bool limitInstances;

	public int limitAmount = 100;

	public bool limitFIFO;

	public bool cullDespawned;

	public int cullAbove = 50;

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
			LinkedList<PooledInstanceData> linkedList = default;
			linkedList._002Ector((IEnumerable<PooledInstanceData>)_spawned);
			return linkedList;
		}
	}

	public LinkedList<PooledInstanceData> despawned
	{
		get
		{
			LinkedList<PooledInstanceData> linkedList = default;
			linkedList._002Ector((IEnumerable<PooledInstanceData>)_despawned);
			return linkedList;
		}
	}

	public int totalCount
	{
		get
		{
			LinkedList<PooledInstanceData> linkedList = _spawned;
			LinkedList<PooledInstanceData> linkedList2 = _despawned;
			return linkedList.count + linkedList2.count;
		}
	}

	public static IComparer<PrefabPool> comparer
	{
		get
		{
			if (_comparer == null)
			{
				IComparer<PrefabPool> comparer = default;
				_comparer = comparer;
			}
			return _comparer;
		}
	}

	public PrefabPool(Transform prefab)
	{
		LinkedList<PooledInstanceData> linkedList = default;
		_spawned = linkedList;
		LinkedList<PooledInstanceData> linkedList2 = default;
		_despawned = linkedList2;
		this.prefab = prefab;
		GameObject gameObject = prefab.gameObject;
		prefabGO = gameObject;
	}

	public PrefabPool()
	{
		LinkedList<PooledInstanceData> linkedList = default;
		_spawned = linkedList;
		LinkedList<PooledInstanceData> linkedList2 = default;
		_despawned = linkedList2;
	}

	internal void inspectorInstanceConstructor()
	{
		GameObject gameObject = prefab.gameObject;
		prefabGO = gameObject;
		LinkedList<PooledInstanceData> linkedList = default;
		_spawned = linkedList;
		LinkedList<PooledInstanceData> linkedList2 = default;
		_despawned = linkedList2;
	}

	internal void SelfDestruct()
	{
		//IL_0310: Expected I4, but got Obj
		//IL_0170: Expected I4, but got Obj
		//IL_003a: Expected Obj, but got I
		//IL_004c: Expected Obj, but got I
		//IL_0379: Expected I4, but got Obj
		//IL_0108: Expected Obj, but got I
		//IL_01aa: Expected Obj, but got I
		//IL_01bc: Expected Obj, but got I
		//IL_0325: Expected Obj, but got I
		//IL_0386: Expected I4, but got Obj
		//IL_0278: Expected Obj, but got I
		//IL_014a: Expected Obj, but got I
		//IL_008d: Expected Obj, but got I
		//IL_0353: Expected Obj, but got I
		//IL_00a2: Expected Obj, but got I
		//IL_00b3: Expected Obj, but got I
		//IL_02b9: Expected Obj, but got I
		//IL_01fd: Expected Obj, but got I
		//IL_0212: Expected Obj, but got I
		//IL_0223: Expected Obj, but got I
		LinkedList<PooledInstanceData> linkedList = _despawned;
		bool flag = (byte)(int)linkedList.head != 0;
		while (flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ L1_v2 (System.Boolean)+14]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ L1_v2 (System.Boolean)+14]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v78+14]");
				bool flag2 = (UnityEngine.Object)0 != null;
				bool flag3 = !flag2;
				bool flag4 = false;
				GameObject gameObject = null;
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ L1_v2 (System.Boolean)+14]");
					PoolManager.UnregisterInstance((PooledInstanceData)0);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ L1_v2 (System.Boolean)+14]");
					object obj2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ S1_v30+14]");
					gameObject = ((Component)0).gameObject;
					spawnPool.DestroyInstance(gameObject);
					flag4 = flag;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ L1_v2 (System.Boolean)+C]");
			GameObject gameObject2;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ L1_v2 (System.Boolean)+8]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ L1_v2 (System.Boolean)+C]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S3_v9+8]");
				bool flag4 = num == 0;
				gameObject2 = null;
				if (!flag4)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ L1_v2 (System.Boolean)+C]");
					gameObject2 = (GameObject)0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ L1_v2 (System.Boolean)+C]");
				GameObject gameObject = (GameObject)0;
			}
			else
			{
				gameObject2 = null;
			}
			flag = (byte)(int)gameObject2 != 0;
		}
		LinkedList<PooledInstanceData> linkedList2 = _spawned;
		bool flag5 = (byte)(int)linkedList2.head != 0;
		while (flag5)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ L1_v4 (System.Boolean)+14]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ L1_v4 (System.Boolean)+14]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v44+14]");
				bool flag6 = (UnityEngine.Object)0 != null;
				bool flag7 = !flag6;
				bool flag4 = false;
				GameObject gameObject = null;
				if (!flag7)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ L1_v4 (System.Boolean)+14]");
					PoolManager.UnregisterInstance((PooledInstanceData)0);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ L1_v4 (System.Boolean)+14]");
					object obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ S1_v19+14]");
					gameObject = ((Component)0).gameObject;
					spawnPool.DestroyInstance(gameObject);
					flag4 = flag5;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ L1_v4 (System.Boolean)+C]");
			GameObject gameObject3;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ L1_v4 (System.Boolean)+8]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ L1_v4 (System.Boolean)+C]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S3_v5+8]");
				bool flag4 = num2 == 0;
				gameObject3 = null;
				if (!flag4)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ L1_v4 (System.Boolean)+C]");
					gameObject3 = (GameObject)0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ L1_v4 (System.Boolean)+C]");
				GameObject gameObject = (GameObject)0;
			}
			else
			{
				gameObject3 = null;
			}
			flag5 = (byte)(int)gameObject3 != 0;
		}
		_spawned.Clear();
		_despawned.Clear();
		prefab = null;
		prefabGO = null;
		spawnPool = null;
	}

	internal bool DespawnInstance(Transform xform)
	{
		bool flag = DespawnInstance(xform, sendEventMessage: true);
		return true;
	}

	internal bool DespawnInstance(Transform xform, bool sendEventMessage)
	{
		//IL_01ab: Expected I4, but got Obj
		PooledInstanceData instanceData = PoolManager.GetInstanceData(xform);
		if (instanceData != null && ~(instanceData.inUse ? 1u : 0u) == 0)
		{
			instanceData.inUse = false;
			_spawned.Remove(instanceData.node__BackingField);
			_despawned.AddLast(instanceData.node__BackingField);
			if (sendEventMessage)
			{
				SpawnPool spawnPool = this.spawnPool;
				if (~(spawnPool.sendUnityEvents ? 1u : 0u) == 0)
				{
					GameObject gameObject = xform.gameObject;
					gameObject.BroadcastMessage("OnDespawned", this.spawnPool, SendMessageOptions.DontRequireReceiver);
				}
			}
			GameObject gameObject2 = xform.gameObject;
			gameObject2.SetActive(value: false);
			SpawnPool spawnPool2 = this.spawnPool;
			bool flag = (object)xform == null;
			Transform transform = null;
			if (!flag)
			{
				bool flag2 = (object)xform.GetType() == typeof(RectTransform);
				transform = xform;
				if (!flag2)
				{
					transform = null;
				}
			}
			bool worldPositionStays = (object)transform == null;
			xform.SetParent(spawnPool2.group__BackingField, worldPositionStays);
			if (~(cullDespawned ? 1u : 0u) == 0)
			{
				int num = totalCount;
				if (num > cullAbove)
				{
					PoolManager.TriggerPoolBalancing(this.spawnPool);
				}
			}
			return true;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		NotImplementedException ex = default;
		ex._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		return (byte)(int)ex != 0;
	}

	internal unsafe Transform SpawnInstance(Vector3 pos, Quaternion rot)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0107: Expected native int or pointer, but got VT
		//IL_0119: Expected native int or pointer, but got VT
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected VT, but got Unknown
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected VT, but got Unknown
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Expected VT, but got Unknown
		object obj = default;
		Quaternion quaternion = (Quaternion)(obj + -64);
		if (~(limitInstances ? 1u : 0u) == 0 && ~(limitFIFO ? 1u : 0u) == 0)
		{
			LinkedList<PooledInstanceData> linkedList = _spawned;
			if (linkedList.count >= limitAmount)
			{
				LinkedList<PooledInstanceData> linkedList2 = _spawned;
				LinkedListNode<PooledInstanceData> head = linkedList2.head;
				PooledInstanceData item = head.item;
				bool flag = DespawnInstance(item.transform__BackingField);
			}
		}
		LinkedList<PooledInstanceData> linkedList3 = _despawned;
		Transform result;
		if (linkedList3.count == 0)
		{
			int num = loadedOnDemand + 1;
			loadedOnDemand = num;
			_ = pos.z;
			_ = pos.x;
			((Quaternion*)(nint)quaternion)->z = rot.z;
			((Quaternion*)(nint)quaternion)->x = rot.x;
			Vector3 pos2 = (Vector3)(quaternion + 16);
			Transform transform = SpawnNew(pos2, quaternion);
			result = transform;
		}
		else
		{
			LinkedList<PooledInstanceData> linkedList4 = _despawned;
			LinkedListNode<PooledInstanceData> head2 = linkedList4.head;
			LinkedListNode<PooledInstanceData> linkedListNode = ((linkedList4.head == null) ? null : head2.prev);
			PooledInstanceData item2 = linkedListNode.item;
			PooledInstanceData item3 = linkedListNode.item;
			item3.inUse = true;
			_despawned.Remove(linkedListNode);
			_spawned.AddLast(linkedListNode);
			if (!(item2.transform__BackingField != null))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
				MissingReferenceException ex = default;
				ex._002Ector("Make sure you didn't delete a despawned instance directly.");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
				return (Transform)(object)ex;
			}
			_ = pos.z;
			_ = pos.x;
			Vector3 position = (Vector3)(quaternion + 48);
			item2.transform__BackingField.position = position;
			_ = rot.z;
			_ = rot.x;
			Quaternion rotation = (Quaternion)(quaternion + 32);
			item2.transform__BackingField.rotation = rotation;
			GameObject gameObject = item2.transform__BackingField.gameObject;
			gameObject.SetActive(value: true);
			result = item2.transform__BackingField;
		}
		LinkedList<PooledInstanceData> linkedList5 = _spawned;
		if (linkedList5.count > maxActive)
		{
			LinkedList<PooledInstanceData> linkedList6 = _spawned;
			maxActive = linkedList6.count;
		}
		return result;
	}

	public unsafe Transform SpawnNew()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0021: Expected I, but got Obj
		//IL_0057: Expected I, but got Obj
		//IL_0096: Expected F4, but got I
		//IL_0091: Expected native int or pointer, but got VT
		//IL_00a4: Expected F4, but got VT
		//IL_009f: Expected native int or pointer, but got VT
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected VT, but got Unknown
		object obj = default;
		Quaternion quaternion = (Quaternion)(obj - 48);
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S1_v4 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v5 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		_ = Vector3.zeroVector;
		nint num3 = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v14 (Il2CppClass<UnityEngine.Quaternion>)+5C]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v15 (Il2CppStaticFields<UnityEngine.Quaternion>)+8]");
		((Quaternion*)(nint)quaternion)->z = 0f;
		((Quaternion*)(nint)quaternion)->x = (float)Quaternion.identityQuaternion;
		Vector3 pos = (Vector3)(quaternion + 16);
		return SpawnNew(pos, quaternion);
	}

	public unsafe Transform SpawnNew(Vector3 pos, Quaternion rot)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0250: Expected I, but got Obj
		//IL_032e: Expected I, but got Obj
		//IL_00d8: Expected F4, but got I
		//IL_00d3: Expected native int or pointer, but got VT
		//IL_00ed: Expected F4, but got I
		//IL_00e8: Expected native int or pointer, but got VT
		//IL_044c: Expected native int or pointer, but got VT
		//IL_045e: Expected native int or pointer, but got VT
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0471: Expected VT, but got Unknown
		//IL_0123: Expected F4, but got I
		//IL_011e: Expected native int or pointer, but got VT
		//IL_0138: Expected F4, but got I
		//IL_0133: Expected native int or pointer, but got VT
		object obj = default;
		Quaternion quaternion = (Quaternion)(obj - 48);
		if (!initialized)
		{
			initialized = true;
			IPrefabBehaviour component = prefabGO.GetComponent<IPrefabBehaviour>();
			if (component != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B7");
			}
		}
		Transform result;
		if (~(limitInstances ? 1u : 0u) == 0)
		{
			int num = totalCount;
			bool flag = num >= limitAmount;
			result = null;
			if (flag)
			{
				goto IL_022d;
			}
		}
		nint num2 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v28 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num3 = 0;
		float num4 = pos.x - (float)Vector3.zeroVector;
		float num5 = num4 * num4;
		float num6 = pos.y;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v29 (Il2CppStaticFields<UnityEngine.Vector3>)+4]");
		float num7 = num6 - 0f;
		float num8 = num7 * num7;
		float num9 = num5 + num8;
		float num10 = pos.z;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v29 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		float num11 = num10 - 0f;
		float num12 = num11 * num11;
		float num13 = num9 + num12;
		if (num13 < 9.9999994E-11f)
		{
			SpawnPool spawnPool = this.spawnPool;
			Vector3 position = spawnPool.group__BackingField.position;
			Vector3 vector = pos;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+28]");
			((Vector3*)(nint)vector)->z = 0f;
			Vector3 vector2 = pos;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+20]");
			((Vector3*)(nint)vector2)->x = 0f;
		}
		nint num14 = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ S0_v51 (Il2CppClass<UnityEngine.Quaternion>)+5C]");
		nint num15 = 0;
		float num16 = rot.x * (float)Quaternion.identityQuaternion;
		float num17 = rot.y;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ S0_v52 (Il2CppStaticFields<UnityEngine.Quaternion>)+4]");
		float num18 = num17 * 0f;
		float num19 = num16 + num18;
		float num20 = rot.z;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ S0_v52 (Il2CppStaticFields<UnityEngine.Quaternion>)+8]");
		float num21 = num20 * 0f;
		float num22 = num19 + num21;
		float num23 = rot.w;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ S0_v52 (Il2CppStaticFields<UnityEngine.Quaternion>)+C]");
		float num24 = num23 * 0f;
		float num25 = num22 + num24;
		if (num25 > 0.999999f)
		{
			SpawnPool spawnPool2 = this.spawnPool;
			Quaternion rotation = spawnPool2.group__BackingField.rotation;
			Quaternion quaternion2 = rot;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+28]");
			((Quaternion*)(nint)quaternion2)->z = 0f;
			Quaternion quaternion3 = rot;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+20]");
			((Quaternion*)(nint)quaternion3)->x = 0f;
		}
		_ = pos.z;
		_ = pos.x;
		((Quaternion*)(nint)quaternion)->z = rot.z;
		((Quaternion*)(nint)quaternion)->x = rot.x;
		Vector3 pos2 = (Vector3)(quaternion + 16);
		GameObject gameObject = this.spawnPool.InstantiatePrefab(prefabGO, pos2, quaternion);
		Transform transform = gameObject.transform;
		PooledInstanceData pooledInstanceData = default;
		pooledInstanceData._002Ector(transform, this);
		pooledInstanceData.inUse = true;
		PoolManager.RegisterInstance(pooledInstanceData);
		nameInstance(transform);
		SpawnPool spawnPool3 = this.spawnPool;
		if (~(spawnPool3.dontReparent ? 1u : 0u) != 0)
		{
			SpawnPool spawnPool4 = this.spawnPool;
			bool flag2 = (object)transform == null;
			Transform transform2 = null;
			if (!flag2)
			{
				bool flag3 = (object)transform.GetType() == typeof(RectTransform);
				transform2 = transform;
				if (!flag3)
				{
					transform2 = null;
				}
			}
			bool worldPositionStays = (object)transform2 == null;
			transform.SetParent(spawnPool4.group__BackingField, worldPositionStays);
		}
		_spawned.AddLast(pooledInstanceData.node__BackingField);
		result = transform;
		goto IL_022d;
		IL_022d:
		return result;
	}

	private void SetRecursively(Transform xform, int layer)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Obj, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Expected Obj, but got Unknown
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		GameObject gameObject = xform.gameObject;
		gameObject.layer = layer;
		IEnumerator enumerator = xform.GetEnumerator();
		object obj3 = obj + 24;
		object obj4 = obj + 28;
		obj = obj4;
		_ = 0;
		object obj5 = default;
		object obj6 = default;
		object obj7 = default;
		object obj9 = default;
		object obj10 = default;
		while (true)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj5 == null)
				{
					break;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						goto IL_0154;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			goto IL_0154;
			IL_0154:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag = obj6 == obj7;
			bool flag2 = !flag;
			object obj8 = obj9;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj8 = obj10;
			}
			_ = 0;
			object obj11 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			return;
		}
		object obj12 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @38A");
	}

	internal void AddUnpooled(Transform inst, bool despawn)
	{
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected Obj, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected Obj, but got Unknown
		nameInstance(inst);
		PooledInstanceData pooledInstanceData = default;
		pooledInstanceData._002Ector(inst, this);
		bool inUse = (byte)((despawn ? 1u : 0u) ^ 1u) != 0;
		pooledInstanceData.inUse = inUse;
		object obj;
		if (despawn)
		{
			GameObject gameObject = inst.gameObject;
			gameObject.SetActive(value: false);
			obj = this + 56;
		}
		else
		{
			obj = this + 52;
		}
		((LinkedList<PooledInstanceData>)obj).AddLast(pooledInstanceData.node__BackingField);
		PoolManager.RegisterInstance(pooledInstanceData);
	}

	public bool Contains(Transform transform)
	{
		if (prefabGO == null)
		{
			GameObject gameObject = this.spawnPool.gameObject;
			SpawnPool spawnPool = this.spawnPool;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			SpawnPool spawnPool2 = this.spawnPool;
			throw new ArrayTypeMismatchException();
		}
		PooledInstanceData instanceData = PoolManager.GetInstanceData(transform);
		if (instanceData != null)
		{
			return instanceData.pool__BackingField == this;
		}
		return false;
	}

	private unsafe void nameInstance(Transform instance)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_005c: Expected Obj, but got I4
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		string name = instance.name;
		int num = totalCount;
		object obj3 = num + 1;
		int num2 = obj + 12;
		string text = ((int*)num2)->ToString("#000");
		string name2 = name + text;
		instance.name = name2;
	}
}
