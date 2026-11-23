using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Components.Logging;
using UnityEngine;

namespace SYBO.Components.Utilities;

public sealed class SpawnPool : MonoBehaviour, IList<Transform>, ICollection<Transform>, IEnumerable<Transform>, IEnumerable
{
	[Serializable]
	public class PrefabPoolGroup
	{
		private class Comparer : IComparer<PrefabPoolGroup>
		{
			int IComparer<PrefabPoolGroup>.Compare(PrefabPoolGroup x, PrefabPoolGroup y)
			{
				return x.name.CompareTo(y.name);
			}
		}

		public bool expandPrefabs = true;

		public string name;

		public List<PrefabPool> prefabPools;

		private static IComparer<PrefabPoolGroup> _comparer;

		public static IComparer<PrefabPoolGroup> comparer
		{
			get
			{
				if (_comparer == null)
				{
					IComparer<PrefabPoolGroup> comparer = default;
					_comparer = comparer;
				}
				return _comparer;
			}
		}

		public PrefabPoolGroup()
		{
			List<PrefabPool> list = default;
			list._002Ector();
			prefabPools = list;
		}
	}

	public delegate GameObject InstantiateDelegate(GameObject prefab, Vector3 pos, Quaternion rot);

	public delegate void DestroyDelegate(GameObject instance);

	private sealed class _003CDoDespawnAfterSeconds_003Ed__63(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public Transform instance;

		public float seconds;

		public SpawnPool _003C_003E4__this;

		private GameObject _003Cgo_003E5__2;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			float num;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					if (_003Cgo_003E5__2.activeInHierarchy)
					{
						float deltaTime = Time.deltaTime;
						num = (seconds -= deltaTime);
						goto IL_010e;
					}
				}
				goto IL_00f0;
			}
			_003C_003E1__state = -1;
			GameObject gameObject = instance.gameObject;
			_003Cgo_003E5__2 = gameObject;
			num = seconds;
			goto IL_010e;
			IL_00f0:
			return false;
			IL_010e:
			if (!(num > 0f))
			{
				_003C_003E4__this.Despawn(instance);
				goto IL_00f0;
			}
			_003C_003E2__current = null;
			_003C_003E1__state = 1;
			return true;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	private sealed class _003CListForAudioStop_003Ed__70(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public AudioSource src;

		public SpawnPool _003C_003E4__this;

		private GameObject _003CsrcGameObject_003E5__2;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0071: Expected I4, but got I8
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					if (_003C_003E1__state != 2)
					{
						goto IL_0122;
					}
					_003C_003E1__state = -1;
				}
				else
				{
					_003C_003E1__state = -1;
					GameObject gameObject = src.gameObject;
					_003CsrcGameObject_003E5__2 = gameObject;
				}
				if (!src.isPlaying)
				{
					if (!_003CsrcGameObject_003E5__2.activeInHierarchy)
					{
						src.Stop();
						return false;
					}
					Transform transform = src.transform;
					_003C_003E4__this.Despawn(transform);
					goto IL_0122;
				}
				_003C_003E2__current = null;
				_003C_003E1__state = 2;
				return true;
			}
			_003C_003E1__state = -1;
			_003C_003E1__state = 1;
			return true;
			IL_0122:
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	private sealed class _003CGetEnumerator_003Ed__74(int _003C_003E1__state) : IEnumerator<Transform>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private Transform _003C_003E2__current;

		public SpawnPool _003C_003E4__this;

		private int _003Ci_003E5__2;

		private LinkedListNode<PooledInstanceData> _003Cnode_003E5__3;

		Transform IEnumerator<Transform>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_00d8: Expected Obj, but got I4
			//IL_024f: Expected Obj, but got I4
			//IL_0199: Expected Obj, but got I4
			//IL_0121: Expected Obj, but got I4
			SpawnPool spawnPool = _003C_003E4__this;
			object obj;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					goto IL_01f4;
				}
				_003C_003E1__state = -1;
				LinkedListNode<PooledInstanceData> linkedListNode = _003Cnode_003E5__3;
				LinkedListNode<PooledInstanceData> linkedListNode3;
				if (linkedListNode.next != null)
				{
					LinkedList<PooledInstanceData> list = linkedListNode.list;
					bool flag = linkedListNode.next == list.head;
					LinkedListNode<PooledInstanceData> linkedListNode2 = null;
					if (!flag)
					{
						linkedListNode2 = linkedListNode.next;
					}
					linkedListNode3 = linkedListNode2;
				}
				else
				{
					linkedListNode3 = null;
				}
				_003Cnode_003E5__3 = linkedListNode3;
				obj = 0;
			}
			else
			{
				_003Ci_003E5__2 = 0;
				_003C_003E1__state = -1;
				obj = 1;
			}
			object obj2 = obj;
			int num = default;
			while (true)
			{
				if (obj2 == null)
				{
					LinkedListNode<PooledInstanceData> linkedListNode4 = _003Cnode_003E5__3;
					if (_003Cnode_003E5__3 != null)
					{
						PooledInstanceData item = linkedListNode4.item;
						_003C_003E2__current = item.transform__BackingField;
						_003C_003E1__state = 1;
						return true;
					}
					_003Cnode_003E5__3 = null;
					num = ++_003Ci_003E5__2;
					obj2 = 1;
				}
				else
				{
					List<PrefabPool> prefabPools = spawnPool._prefabPools;
					if (num >= prefabPools._size)
					{
						break;
					}
					PrefabPool prefabPool = spawnPool._prefabPools.get_Item(_003Ci_003E5__2);
					LinkedList<PooledInstanceData> spawned = prefabPool.spawned;
					_003Cnode_003E5__3 = spawned.head;
					obj2 = 0;
				}
			}
			goto IL_01f4;
			IL_01f4:
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	private sealed class _003CSystem_002DCollections_002DIEnumerable_002DGetEnumerator_003Ed__75(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public SpawnPool _003C_003E4__this;

		private int _003Ci_003E5__2;

		private LinkedListNode<PooledInstanceData> _003Cnode_003E5__3;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_00d8: Expected Obj, but got I4
			//IL_0242: Expected Obj, but got I4
			//IL_0199: Expected Obj, but got I4
			//IL_0121: Expected Obj, but got I4
			SpawnPool spawnPool = _003C_003E4__this;
			object obj;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					goto IL_01e7;
				}
				_003C_003E1__state = -1;
				LinkedListNode<PooledInstanceData> linkedListNode = _003Cnode_003E5__3;
				LinkedListNode<PooledInstanceData> linkedListNode3;
				if (linkedListNode.next != null)
				{
					LinkedList<PooledInstanceData> list = linkedListNode.list;
					bool flag = linkedListNode.next == list.head;
					LinkedListNode<PooledInstanceData> linkedListNode2 = null;
					if (!flag)
					{
						linkedListNode2 = linkedListNode.next;
					}
					linkedListNode3 = linkedListNode2;
				}
				else
				{
					linkedListNode3 = null;
				}
				_003Cnode_003E5__3 = linkedListNode3;
				obj = 0;
			}
			else
			{
				_003Ci_003E5__2 = 0;
				_003C_003E1__state = -1;
				obj = 1;
			}
			object obj2 = obj;
			int num = default;
			while (true)
			{
				if (obj2 == null)
				{
					LinkedListNode<PooledInstanceData> linkedListNode4 = _003Cnode_003E5__3;
					if (_003Cnode_003E5__3 != null)
					{
						_003C_003E2__current = linkedListNode4.item;
						_003C_003E1__state = 1;
						return true;
					}
					_003Cnode_003E5__3 = null;
					num = ++_003Ci_003E5__2;
					obj2 = 1;
				}
				else
				{
					List<PrefabPool> prefabPools = spawnPool._prefabPools;
					if (num >= prefabPools._size)
					{
						break;
					}
					PrefabPool prefabPool = spawnPool._prefabPools.get_Item(_003Ci_003E5__2);
					LinkedList<PooledInstanceData> spawned = prefabPool.spawned;
					_003Cnode_003E5__3 = spawned.head;
					obj2 = 0;
				}
			}
			goto IL_01e7;
			IL_01e7:
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	public int spawnPriority;

	public int despawnPriority;

	public int logLevelAdjust;

	public string poolName = string.Empty;

	public bool dontReparent;

	public bool _dontDestroyOnLoad;

	public bool sendUnityEvents;

	public List<PrefabPoolGroup> _prefabPoolGroups;

	public Dictionary<object, bool> prefabsFoldOutStates;

	public float maxParticleDespawnTime;

	public PrefabsDict prefabs;

	public Dictionary<object, bool> _editorListItemStates;

	private List<PrefabPool> _prefabPools;

	public InstantiateDelegate instantiateDelegates;

	public DestroyDelegate destroyDelegates;

	private Transform group__BackingField;

	public bool dontDestroyOnLoad
	{
		get
		{
			return _dontDestroyOnLoad;
		}
		set
		{
			_dontDestroyOnLoad = value;
			if (group__BackingField != null)
			{
				GameObject target = group__BackingField.gameObject;
				UnityEngine.Object.DontDestroyOnLoad(target);
			}
		}
	}

	public Transform group
	{
		get
		{
			return group__BackingField;
		}
		private set
		{
			group__BackingField = value;
		}
	}

	// C# has no syntax for parameterized property 'Item'.
	public Transform get_Item(int index)
	{
		int num = 0;
		int num2 = default;
		while (true)
		{
			List<PrefabPool> prefabPools = _prefabPools;
			if (num >= prefabPools._size)
			{
				break;
			}
			PrefabPool prefabPool = _prefabPools.get_Item(num);
			LinkedList<PooledInstanceData> spawned = prefabPool.spawned;
			LinkedList<PooledInstanceData> spawned2 = prefabPool.spawned;
			if (num2 < spawned.count)
			{
				LinkedListNode<PooledInstanceData> linkedListNode = spawned2.head;
				while (true)
				{
					bool flag = num2 > 0;
					int num3 = num2 - 1;
					if (!flag)
					{
						break;
					}
					LinkedListNode<PooledInstanceData> linkedListNode3;
					if (linkedListNode.next != null)
					{
						LinkedList<PooledInstanceData> list = linkedListNode.list;
						bool flag2 = linkedListNode.next == list.head;
						LinkedListNode<PooledInstanceData> linkedListNode2 = null;
						if (!flag2)
						{
							linkedListNode2 = linkedListNode.next;
						}
						linkedListNode3 = linkedListNode2;
					}
					else
					{
						linkedListNode3 = null;
					}
					num2 = num3;
					linkedListNode = linkedListNode3;
				}
				PooledInstanceData item = linkedListNode.item;
				return item.transform__BackingField;
			}
			int num4 = num2 - spawned2.count;
			int num5 = num + 1;
			num2 = num4;
			num = num5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		IndexOutOfRangeException ex = default;
		ex._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		return (Transform)(object)ex;
	}

	public void set_Item(int index, Transform value)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		NotImplementedException ex = default;
		ex._002Ector("Read-only.");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
	}

	public int Count
	{
		get
		{
			int num = 0;
			int result = default;
			int num2 = default;
			while (true)
			{
				List<PrefabPool> prefabPools = _prefabPools;
				if (num >= prefabPools._size)
				{
					break;
				}
				PrefabPool prefabPool = _prefabPools.get_Item(num);
				LinkedList<PooledInstanceData> spawned = prefabPool.spawned;
				result = num2 + spawned.count;
				int num3 = num + 1;
				num = num3;
			}
			return result;
		}
	}

	public bool IsReadOnly
	{
		get
		{
			//IL_0037: Expected I4, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			NotImplementedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
			return (byte)(int)ex != 0;
		}
	}

	public int PrefabPoolCount
	{
		get
		{
			List<PrefabPool> prefabPools = _prefabPools;
			return prefabPools._size;
		}
	}

	private unsafe void Awake()
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected I4, but got Unknown
		//IL_0081: Expected Obj, but got I4
		if (~(_dontDestroyOnLoad ? 1u : 0u) == 0)
		{
			GameObject target = base.gameObject;
			UnityEngine.Object.DontDestroyOnLoad(target);
		}
		Transform transform = base.transform;
		group__BackingField = transform;
		int num = this - -64;
		if (poolName == string.Empty)
		{
			string text = ((UnityEngine.Object)((int*)num)->m_value).name;
			string text2 = text.Replace("Pool", string.Empty);
			poolName = text2;
			string text3 = poolName.Replace("(Clone)", string.Empty);
			poolName = text3;
		}
		int num2 = default;
		int num5 = default;
		while (true)
		{
			List<PrefabPoolGroup> prefabPoolGroups = _prefabPoolGroups;
			if (prefabPoolGroups._size <= num2)
			{
				break;
			}
			PrefabPoolGroup prefabPoolGroup = _prefabPoolGroups.get_Item(num2);
			List<PrefabPool> prefabPools = prefabPoolGroup.prefabPools;
			int num3 = 0;
			while (num3 < prefabPools._size)
			{
				PrefabPool prefabPool = prefabPools.get_Item(num3);
				if (prefabPool.prefab == null)
				{
					GameObject gameObject = base.gameObject;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
					throw new ArrayTypeMismatchException();
				}
				prefabPool.inspectorInstanceConstructor();
				CreatePrefabPool(prefabPool);
				int preloadAmount;
				if (~(prefabPool.cullDespawned ? 1u : 0u) != 0)
				{
					preloadAmount = prefabPool.preloadAmount;
				}
				else
				{
					bool flag = prefabPool.preloadAmount <= prefabPool.cullAbove;
					preloadAmount = prefabPool.preloadAmount;
					if (!flag)
					{
						GameObject gameObject2 = base.gameObject;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
						throw new ArrayTypeMismatchException();
					}
				}
				PrefabPool prefabPool2 = prefabPools.get_Item(num3);
				if (prefabPool2.limitAmount >= preloadAmount)
				{
				}
				int num4 = num3 + 1;
				num3 = num4;
			}
			num2 = num5 + 1;
		}
		PrefabPoolGroup prefabPoolGroup2 = default;
		prefabPoolGroup2._002Ector();
		prefabPoolGroup2.name = "Runtime Group";
		_prefabPoolGroups.Add(prefabPoolGroup2);
		PoolManager.Pools.Add(this);
	}

	public int GetBalanceOperations()
	{
		//IL_0079: Expected Obj, but got I4
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected I4, but got Unknown
		//IL_00e3: Expected Obj, but got I4
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected I4, but got Unknown
		int num = 0;
		int num2 = default;
		int num5 = default;
		while (true)
		{
			int prefabPoolCount = PrefabPoolCount;
			if (prefabPoolCount <= num2)
			{
				break;
			}
			PrefabPool prefabPool = GetPrefabPool(num2);
			int totalCount = prefabPool.totalCount;
			if (totalCount < prefabPool.preloadAmount)
			{
				int totalCount2 = prefabPool.totalCount;
				object obj = prefabPool.preloadAmount - totalCount2;
				int num3 = obj + num;
				num = num3;
			}
			if (~(prefabPool.cullDespawned ? 1u : 0u) == 0)
			{
				int totalCount3 = prefabPool.totalCount;
				if (totalCount3 > prefabPool.cullAbove)
				{
					int totalCount4 = prefabPool.totalCount;
					object obj2 = totalCount4 - prefabPool.cullAbove;
					int num4 = obj2 + num;
					num = num4;
				}
			}
			num2 = num5 + 1;
		}
		return num;
	}

	internal unsafe GameObject InstantiatePrefab(GameObject prefab, Vector3 pos, Quaternion rot)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00ab: Expected native int or pointer, but got VT
		//IL_00bd: Expected native int or pointer, but got VT
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected VT, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected Obj, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected Obj, but got Unknown
		object obj = default;
		Quaternion quaternion = (Quaternion)(obj + -64);
		InstantiateDelegate instantiateDelegate = instantiateDelegates;
		if (instantiateDelegates != null)
		{
			_ = pos.z;
			_ = pos.x;
			_ = rot.z;
			_ = rot.x;
			object obj2 = quaternion + 48;
			object obj3 = quaternion + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v8.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			GameObject result = default;
			return result;
		}
		_ = pos.z;
		_ = pos.x;
		((Quaternion*)(nint)quaternion)->z = rot.z;
		((Quaternion*)(nint)quaternion)->x = rot.x;
		Vector3 pos2 = (Vector3)(quaternion + 16);
		return InstanceHandler.InstantiatePrefab(prefab, pos2, quaternion);
	}

	internal void DestroyInstance(GameObject instance)
	{
		DestroyDelegate destroyDelegate = destroyDelegates;
		if (destroyDelegates != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
		else
		{
			InstanceHandler.DestroyInstance(instance);
		}
	}

	private void OnDestroy()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected Obj, but got Unknown
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Expected Obj, but got Unknown
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Expected Obj, but got Unknown
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected Obj, but got Unknown
		//IL_0208: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		PoolManager.Remove(this);
		StopAllCoroutines();
		object obj3 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj4 = obj + 32;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj6 = default;
		object obj7 = default;
		object obj8 = default;
		object obj10 = default;
		object obj11 = default;
		SpawnPool spawnPool = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj6 == null)
				{
					break;
				}
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						continue;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag = obj7 == obj8;
			bool flag2 = !flag;
			object obj9 = obj10;
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
				obj9 = obj11;
			}
			_ = 0;
			object obj12 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			spawnPool = (SpawnPool)0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			break;
		}
		object obj13 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C8");
		((List<T>)(object)spawnPool._prefabPools).Clear();
		spawnPool.prefabs._Clear();
	}

	public void CreatePrefabPool(PrefabPool prefabPool)
	{
		PrefabPool prefabPool2 = default;
		string text = default;
		Exception ex = default;
		if (PoolManager.PrefabPoolExists(prefabPool2.prefab))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			PrefabPool prefabPool3 = PoolManager.GetPrefabPool(prefabPool2.prefab);
			SpawnPool spawnPool = prefabPool3.spawnPool;
			text = $"Prefab '{prefabPool2.prefab}' is already pooled in  SpawnPool '{spawnPool.poolName}'.Prefabs cannot be in more than 1 SpawnPool.";
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			ex._002Ector(text);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
		((PrefabPool)(object)ex).spawnPool = (SpawnPool)(object)text;
		((SpawnPool)(object)text)._prefabPools.Add((PrefabPool)(object)ex);
		string prefabName = ((PrefabPool)(object)ex).prefab.name;
		((SpawnPool)(object)text).prefabs._Add(prefabName, ((PrefabPool)(object)ex).prefab);
		PoolManager.AddPool((PrefabPool)(object)ex);
	}

	public void Add(Transform instance, string prefabName, bool despawn, bool parent)
	{
		int num = 0;
		while (true)
		{
			List<PrefabPool> prefabPools = _prefabPools;
			if (num >= prefabPools._size)
			{
				break;
			}
			PrefabPool prefabPool = _prefabPools.get_Item(num);
			if (prefabPool.prefabGO == null)
			{
				GameObject context = base.gameObject;
				object[] args = Array.Empty<object>();
				Log.PoolManager.LogErrorFormat(context, logLevelAdjust, "Unexpected Error: PrefabPool.prefabGO is null", args);
				return;
			}
			PrefabPool prefabPool2 = _prefabPools.get_Item(num);
			string text = prefabPool2.prefabGO.name;
			if (text == prefabName)
			{
				PrefabPool prefabPool3 = _prefabPools.get_Item(num);
				prefabPool3.AddUnpooled(instance, despawn);
				if (!parent)
				{
					return;
				}
				bool flag = (object)instance == null;
				Transform transform = null;
				if (!flag)
				{
					bool flag2 = (object)instance.GetType() == typeof(RectTransform);
					transform = instance;
					if (!flag2)
					{
						transform = null;
					}
				}
				bool worldPositionStays = (object)transform == null;
				instance.SetParent(group__BackingField, worldPositionStays);
				return;
			}
			int num2 = num + 1;
			num = num2;
		}
		GameObject gameObject = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}

	public void Add(Transform item)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		NotImplementedException ex = default;
		ex._002Ector("Use SpawnPool.Spawn() to properly add items to the pool.");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
	}

	public void Remove(Transform item)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		NotImplementedException ex = default;
		ex._002Ector("Use Despawn() to properly manage items that should remain in the pool but be deactivated.");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
	}

	public unsafe Transform Spawn(Transform prefab, Vector3 pos, Quaternion rot, Transform parent)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_018d: Expected native int or pointer, but got VT
		//IL_019f: Expected native int or pointer, but got VT
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected VT, but got Unknown
		object obj = default;
		Quaternion quaternion = (Quaternion)(obj - 32);
		PrefabPool prefabPool = GetPrefabPool(prefab);
		_ = pos.z;
		_ = pos.x;
		((Quaternion*)(nint)quaternion)->z = rot.z;
		((Quaternion*)(nint)quaternion)->x = rot.x;
		Vector3 pos2 = (Vector3)(quaternion + 16);
		Transform transform = prefabPool.SpawnInstance(pos2, quaternion);
		bool flag = transform == null;
		bool flag2 = !flag;
		bool flag3 = !flag2;
		Transform result = null;
		if (flag3)
		{
			goto IL_01cc;
		}
		bool flag4 = (object)transform == null;
		Transform transform2 = null;
		if (!flag4)
		{
			bool flag5 = (object)transform.GetType() == typeof(RectTransform);
			transform2 = transform;
			if (!flag5)
			{
				transform2 = null;
			}
		}
		Transform parent2;
		if (parent != null)
		{
			parent2 = parent;
			goto IL_01f8;
		}
		if (!dontReparent)
		{
			Transform parent3 = transform.parent;
			if (parent3 != group__BackingField)
			{
				parent2 = group__BackingField;
				goto IL_01f8;
			}
		}
		goto IL_010f;
		IL_01f8:
		bool worldPositionStays = (object)transform2 == null;
		transform.SetParent(parent2, worldPositionStays);
		goto IL_010f;
		IL_010f:
		bool flag6 = (byte)(~(sendUnityEvents ? 1u : 0u)) != 0;
		result = transform;
		if (!flag6)
		{
			GameObject gameObject = transform.gameObject;
			gameObject.BroadcastMessage("OnSpawned", this, SendMessageOptions.DontRequireReceiver);
			result = transform;
		}
		goto IL_01cc;
		IL_01cc:
		return result;
	}

	public unsafe Transform Spawn(Transform prefab, Vector3 pos, Quaternion rot)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0054: Expected native int or pointer, but got VT
		//IL_0066: Expected native int or pointer, but got VT
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected VT, but got Unknown
		object obj = default;
		Quaternion quaternion = (Quaternion)(obj - 32);
		_ = pos.z;
		_ = pos.x;
		((Quaternion*)(nint)quaternion)->z = rot.z;
		((Quaternion*)(nint)quaternion)->x = rot.x;
		Vector3 pos2 = (Vector3)(quaternion + 16);
		Transform transform = Spawn(prefab, pos2, quaternion, null);
		bool flag = transform != null;
		Transform result = null;
		if (flag)
		{
			result = transform;
		}
		return result;
	}

	public unsafe Transform Spawn(Transform prefab)
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
		return Spawn(prefab, pos, quaternion);
	}

	public unsafe Transform Spawn(Transform prefab, Transform parent)
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
		return Spawn(prefab, pos, quaternion, parent);
	}

	public unsafe Transform Spawn(GameObject prefab, Vector3 pos, Quaternion rot, Transform parent)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_003c: Expected native int or pointer, but got VT
		//IL_004e: Expected native int or pointer, but got VT
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected VT, but got Unknown
		object obj = default;
		Quaternion quaternion = (Quaternion)(obj - 32);
		Transform prefab2 = prefab.transform;
		_ = pos.z;
		_ = pos.x;
		((Quaternion*)(nint)quaternion)->z = rot.z;
		((Quaternion*)(nint)quaternion)->x = rot.x;
		Vector3 pos2 = (Vector3)(quaternion + 16);
		return Spawn(prefab2, pos2, quaternion, parent);
	}

	public unsafe Transform Spawn(GameObject prefab, Vector3 pos, Quaternion rot)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_003c: Expected native int or pointer, but got VT
		//IL_004e: Expected native int or pointer, but got VT
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected VT, but got Unknown
		object obj = default;
		Quaternion quaternion = (Quaternion)(obj - 32);
		Transform prefab2 = prefab.transform;
		_ = pos.z;
		_ = pos.x;
		((Quaternion*)(nint)quaternion)->z = rot.z;
		((Quaternion*)(nint)quaternion)->x = rot.x;
		Vector3 pos2 = (Vector3)(quaternion + 16);
		return Spawn(prefab2, pos2, quaternion);
	}

	public Transform Spawn(GameObject prefab)
	{
		Transform prefab2 = prefab.transform;
		return Spawn(prefab2);
	}

	public Transform Spawn(GameObject prefab, Transform parent)
	{
		Transform prefab2 = prefab.transform;
		return Spawn(prefab2, parent);
	}

	public Transform Spawn(string prefabName)
	{
		Transform prefab = prefabs.get_Item(prefabName);
		return Spawn(prefab);
	}

	public Transform Spawn(string prefabName, Transform parent)
	{
		Transform prefab = prefabs.get_Item(prefabName);
		return Spawn(prefab, parent);
	}

	public unsafe Transform Spawn(string prefabName, Vector3 pos, Quaternion rot)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0042: Expected native int or pointer, but got VT
		//IL_0054: Expected native int or pointer, but got VT
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected VT, but got Unknown
		object obj = default;
		Quaternion quaternion = (Quaternion)(obj - 32);
		Transform prefab = prefabs.get_Item(prefabName);
		_ = pos.z;
		_ = pos.x;
		((Quaternion*)(nint)quaternion)->z = rot.z;
		((Quaternion*)(nint)quaternion)->x = rot.x;
		Vector3 pos2 = (Vector3)(quaternion + 16);
		return Spawn(prefab, pos2, quaternion);
	}

	public unsafe Transform Spawn(string prefabName, Vector3 pos, Quaternion rot, Transform parent)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0042: Expected native int or pointer, but got VT
		//IL_0054: Expected native int or pointer, but got VT
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected VT, but got Unknown
		object obj = default;
		Quaternion quaternion = (Quaternion)(obj - 32);
		Transform prefab = prefabs.get_Item(prefabName);
		_ = pos.z;
		_ = pos.x;
		((Quaternion*)(nint)quaternion)->z = rot.z;
		((Quaternion*)(nint)quaternion)->x = rot.x;
		Vector3 pos2 = (Vector3)(quaternion + 16);
		return Spawn(prefab, pos2, quaternion, parent);
	}

	public unsafe AudioSource Spawn(AudioSource prefab, Vector3 pos, Quaternion rot)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_002f: Expected native int or pointer, but got VT
		//IL_0041: Expected native int or pointer, but got VT
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected VT, but got Unknown
		object obj = default;
		Quaternion quaternion = (Quaternion)(obj - 32);
		_ = pos.z;
		_ = pos.x;
		((Quaternion*)(nint)quaternion)->z = rot.z;
		((Quaternion*)(nint)quaternion)->x = rot.x;
		Vector3 pos2 = (Vector3)(quaternion + 16);
		return Spawn(prefab, pos2, quaternion, null);
	}

	public unsafe AudioSource Spawn(AudioSource prefab)
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
		return Spawn(prefab, pos, quaternion, null);
	}

	public unsafe AudioSource Spawn(AudioSource prefab, Transform parent)
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
		return Spawn(prefab, pos, quaternion, parent);
	}

	public unsafe AudioSource Spawn(AudioSource prefab, Vector3 pos, Quaternion rot, Transform parent)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00b4: Expected native int or pointer, but got VT
		//IL_00c6: Expected native int or pointer, but got VT
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected VT, but got Unknown
		object obj = default;
		Quaternion quaternion = (Quaternion)(obj - 32);
		Transform prefab2 = prefab.transform;
		_ = pos.z;
		_ = pos.x;
		((Quaternion*)(nint)quaternion)->z = rot.z;
		((Quaternion*)(nint)quaternion)->x = rot.x;
		Vector3 pos2 = (Vector3)(quaternion + 16);
		Transform transform = Spawn(prefab2, pos2, quaternion, parent);
		AudioSource component = default;
		if (!(transform == null))
		{
			component = transform.GetComponent<AudioSource>();
			component.Play();
			IEnumerator routine = ListForAudioStop(component);
			Coroutine coroutine = StartCoroutine(routine);
		}
		return component;
	}

	public void Despawn(Transform instance)
	{
		PooledInstanceData instanceData = PoolManager.GetInstanceData(instance);
		if (instanceData == null)
		{
			GameObject gameObject = base.gameObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			throw new ArrayTypeMismatchException();
		}
		if (~(instanceData.inUse ? 1u : 0u) == 0)
		{
			bool flag = instanceData.pool__BackingField.DespawnInstance(instance);
			return;
		}
		GameObject gameObject2 = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}

	public void Despawn(Transform instance, Transform parent)
	{
		Despawn(instance);
	}

	public void Despawn(Transform instance, float seconds)
	{
		IEnumerator routine = DoDespawnAfterSeconds(instance, seconds);
		Coroutine coroutine = StartCoroutine(routine);
	}

	public void Despawn(Transform instance, float seconds, Transform parent)
	{
		IEnumerator routine = DoDespawnAfterSeconds(instance, seconds);
		Coroutine coroutine = StartCoroutine(routine);
	}

	private IEnumerator DoDespawnAfterSeconds(Transform instance, float seconds)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	public void DespawnAll()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0351: Expected Obj, but got Unknown
		//IL_037e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Expected Obj, but got Unknown
		//IL_03c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cd: Expected Obj, but got Unknown
		//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ae: Expected Obj, but got Unknown
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Expected Obj, but got Unknown
		//IL_004e: Expected Obj, but got I
		//IL_0412: Expected Obj, but got I
		//IL_0326: Expected Obj, but got I
		//IL_00c8: Expected Obj, but got I
		//IL_00de: Expected Obj, but got I
		//IL_012d: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		object obj3 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj4 = obj + 32;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj6 = default;
		object obj7;
		object obj13 = default;
		object obj14 = default;
		object obj16 = default;
		object obj17 = default;
		while (true)
		{
			IL_03b9:
			_ = 0;
			object obj5 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				bool flag = obj6 == null;
				obj7 = obj;
				if (flag)
				{
					break;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
				object obj8 = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v65+34]");
						object obj9 = 0;
						_ = 0;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 == 1)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ S0_v73+8]");
						if ((nint)0 == 0)
						{
							goto IL_03b9;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v65+34]");
						object obj10 = 0;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ S0_v89+8]");
						object obj11 = 0;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 == 1)
						{
							goto IL_0198;
						}
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ S0_v94+14]");
						object obj12 = 0;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 == 1)
						{
							goto IL_01a7;
						}
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							continue;
						}
						goto IL_01b6;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			goto IL_01e3;
			IL_01b6:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_01e3;
			IL_0198:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_01e3;
			IL_01e3:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag2 = obj13 == obj14;
			bool flag3 = !flag2;
			object obj15 = obj16;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag4 = (nint)0 != 1;
				obj7 = obj;
				if (flag4)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj15 = obj17;
			}
			_ = 0;
			object obj18 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				obj7 = 0;
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			return;
			IL_01a7:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_01e3;
		}
		object obj19 = obj7 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C8");
	}

	public bool IsSpawned(Transform instance)
	{
		return PoolManager.GetInstanceData(instance)?.inUse ?? false;
	}

	public PrefabPool GetPrefabPool(Transform prefab)
	{
		if (PoolManager.PrefabPoolExists(prefab))
		{
			return PoolManager.GetPrefabPool(prefab);
		}
		PrefabPool prefabPool = default;
		prefabPool._002Ector(prefab);
		CreatePrefabPool(prefabPool);
		List<PrefabPoolGroup> prefabPoolGroups = _prefabPoolGroups;
		int index = prefabPoolGroups._size - 1;
		PrefabPoolGroup prefabPoolGroup = prefabPoolGroups.get_Item(index);
		prefabPoolGroup.prefabPools.Add(prefabPool);
		return prefabPool;
	}

	public PrefabPool GetPrefabPool(GameObject prefab)
	{
		Transform prefab2 = prefab.transform;
		return GetPrefabPool(prefab2);
	}

	public Transform GetPrefab(Transform instance)
	{
		PooledInstanceData instanceData = PoolManager.GetInstanceData(instance);
		if (instanceData != null)
		{
			PrefabPool prefabPool = instanceData.pool__BackingField;
			return prefabPool.prefab;
		}
		return null;
	}

	public GameObject GetPrefab(GameObject instance)
	{
		Transform instance2 = instance.transform;
		PooledInstanceData instanceData = PoolManager.GetInstanceData(instance2);
		if (instanceData != null)
		{
			PrefabPool prefabPool = instanceData.pool__BackingField;
			return prefabPool.prefab.gameObject;
		}
		return null;
	}

	private IEnumerator ListForAudioStop(AudioSource src)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	public override string ToString()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0505: Unknown result type (might be due to invalid IL or missing references)
		//IL_050a: Expected Obj, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		//IL_05fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0603: Expected Obj, but got Unknown
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Expected Obj, but got Unknown
		//IL_044d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0452: Expected Obj, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected Obj, but got Unknown
		//IL_00a1: Expected Obj, but got I
		//IL_04a2: Expected Obj, but got I
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected Obj, but got Unknown
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected Obj, but got Unknown
		//IL_0564: Unknown result type (might be due to invalid IL or missing references)
		//IL_0569: Expected Obj, but got Unknown
		//IL_05b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ba: Expected Obj, but got Unknown
		//IL_0320: Unknown result type (might be due to invalid IL or missing references)
		//IL_0325: Expected Obj, but got Unknown
		//IL_01a8: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 80;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		List<string> list = default;
		list._002Ector();
		object obj3 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj4 = obj - -64;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj6 = default;
		object obj7;
		nint num2 = default;
		object obj13 = default;
		object obj15 = default;
		object obj16 = default;
		object obj19 = default;
		object obj20 = default;
		object obj21 = default;
		string result = default;
		object obj23 = default;
		object obj24 = default;
		object obj25 = default;
		object obj26 = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			object obj17;
			object obj18;
			if ((nint)0 != 1)
			{
				bool flag = obj6 == null;
				obj7 = obj;
				if (flag)
				{
					break;
				}
				_ = 0;
				object obj8 = obj - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v81+C]");
				object obj9 = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					object obj10 = obj + 8;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C6");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
						_ = 0;
						object obj11 = obj + 40;
						obj = obj11;
						_ = 0;
						nint num;
						while (true)
						{
							_ = 0;
							object obj12 = obj + 40;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							bool flag2 = (nint)0 == 1;
							num = num2;
							if (flag2)
							{
								break;
							}
							if (obj13 != null)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+34]");
								object obj14 = 0;
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								bool flag3 = (nint)0 == 1;
								num = num2;
								if (flag3)
								{
									break;
								}
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								bool flag4 = (nint)0 == 1;
								num = num2;
								if (flag4)
								{
									break;
								}
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								bool flag5 = (nint)0 != 1;
								num = 0;
								num2 = 0;
								if (!flag5)
								{
									break;
								}
								continue;
							}
							goto IL_0311;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
						bool flag6 = obj15 != obj16;
						obj17 = obj15;
						obj18 = obj19;
						if (!flag6)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							bool flag7 = (nint)0 == 1;
							num2 = num;
							if (!flag7)
							{
								goto IL_0311;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
							obj17 = obj20;
							obj18 = obj21;
						}
						_ = 0;
						object obj22 = obj + 8;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 == 1)
						{
							goto IL_04ac;
						}
						goto IL_0638;
					}
				}
			}
			goto IL_0395;
			IL_04ac:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			return result;
			IL_0395:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			obj17 = obj23;
			obj18 = obj24;
			goto IL_0638;
			IL_0638:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			if (obj25 == obj17)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag8 = (nint)0 != 1;
				obj7 = obj;
				if (flag8)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj18 = obj26;
			}
			_ = 0;
			object obj27 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				obj7 = 0;
				break;
			}
			goto IL_04ac;
			IL_0311:
			_ = 0;
			object obj28 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				continue;
			}
			goto IL_0395;
		}
		object obj29 = obj7 + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C8");
		string[] value = list.ToArray();
		return string.Join(", ", value);
	}

	public bool Contains(Transform item)
	{
		//IL_0041: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		NotImplementedException ex = default;
		ex._002Ector("Use IsSpawned(Transform instance) instead.");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		return (byte)(int)ex != 0;
	}

	public void CopyTo(Transform[] array, int arrayIndex)
	{
		int num = default;
		int num2 = default;
		while (true)
		{
			List<PrefabPool> prefabPools = _prefabPools;
			if (num < prefabPools._size)
			{
				PrefabPool prefabPool = _prefabPools.get_Item(num);
				LinkedList<PooledInstanceData> spawned = prefabPool.spawned;
				LinkedListNode<PooledInstanceData> head = spawned.head;
				if (head != null)
				{
					PooledInstanceData item = head.item;
					throw new ArrayTypeMismatchException();
				}
				num = num2 + 1;
				continue;
			}
			break;
		}
	}

	public IEnumerator<Transform> GetEnumerator()
	{
		_ = 0;
		IEnumerator<Transform> result = default;
		return result;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	public int IndexOf(Transform item)
	{
		//IL_0037: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		NotImplementedException ex = default;
		ex._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		return (int)ex;
	}

	public void Insert(int index, Transform item)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		NotImplementedException ex = default;
		ex._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
	}

	public void RemoveAt(int index)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		NotImplementedException ex = default;
		ex._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
	}

	public void Clear()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		NotImplementedException ex = default;
		ex._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
	}

	public PrefabPool GetPrefabPool(int idx)
	{
		return _prefabPools.get_Item(idx);
	}

	bool ICollection<Transform>.Remove(Transform item)
	{
		//IL_0037: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		NotImplementedException ex = default;
		ex._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		return (byte)(int)ex != 0;
	}

	public SpawnPool()
	{
		List<PrefabPoolGroup> list = default;
		list._002Ector();
		_prefabPoolGroups = list;
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v42 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Object, System.Boolean>>>)+4] (should have been resolved before IL gen)");
		Dictionary<object, bool> dictionary = default;
		prefabsFoldOutStates = dictionary;
		maxParticleDespawnTime = 300f;
		PrefabsDict prefabsDict = default;
		prefabsDict._002Ector();
		prefabs = prefabsDict;
		nint num3 = 0;
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v74 @ S4_v9 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Object, System.Boolean>>>)+4] (should have been resolved before IL gen)");
		Dictionary<object, bool> editorListItemStates = default;
		_editorListItemStates = editorListItemStates;
		List<PrefabPool> list2 = default;
		list2._002Ector();
		_prefabPools = list2;
		base._002Ector();
	}
}
