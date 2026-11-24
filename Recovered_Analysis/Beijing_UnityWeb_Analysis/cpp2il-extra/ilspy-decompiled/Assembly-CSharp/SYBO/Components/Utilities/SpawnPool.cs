using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using ABTest;
using AppRefresh;
using Cpp2ILInjected;
using Data.Save;
using Kiloo.Common;
using Kiloo.Common.Ads;
using Kiloo.Common.HTTP;
using Missions;
using SYBO.Components.Analytics.Albatross;
using SYBO.Components.Analytics.Integration;
using SYBO.Components.Logging;
using TopRun.Internal;
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
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				string text = default;
				string value = default;
				return text.Contains(value) ? 1 : 0;
			}

			public Comparer()
			{
				//IL_0016: Expected Obj, but got I
				//IL_001f: Expected Obj, but got I4
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Utilities.SpawnPool+PrefabPoolGroup+Comparer)+8]");
				object obj = (nint)0 + (nint)28;
				obj = 0;
			}
		}

		public bool expandPrefabs;

		public string name;

		public List<PrefabPool> prefabPools;

		private static IComparer<PrefabPoolGroup> _comparer;

		public static IComparer<PrefabPoolGroup> comparer
		{
			get
			{
				//IL_0060: Expected I, but got Obj
				//IL_0076: Expected Obj, but got I
				//IL_00ab: Expected Obj, but got I4
				//IL_0013: Expected I, but got Obj
				nint num = (nint)typeof(ABTestManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<ABTest.ABTestManager>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num2 = (nint)typeof(ABTestManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<ABTest.ABTestManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag = ABTestManager.isInitialized__BackingField;
				return (IComparer<PrefabPoolGroup>)flag;
			}
		}

		public PrefabPoolGroup()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	public delegate GameObject InstantiateDelegate(GameObject prefab, Vector3 pos, Quaternion rot);

	public delegate void DestroyDelegate(GameObject instance);

	private sealed class _003CDoDespawnAfterSeconds_003Ed__57 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Transform instance;

		public float seconds;

		public SpawnPool _003C_003E4__this;

		private GameObject _003Cgo_003E5__2;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0054: Unknown result type (might be due to invalid IL or missing references)
				//IL_0059: Expected Obj, but got Unknown
				//IL_0151: Expected I4, but got Obj
				//IL_0119: Unknown result type (might be due to invalid IL or missing references)
				//IL_011e: Expected Obj, but got Unknown
				//IL_0127: Expected Obj, but got I4
				//IL_013b: Expected Obj, but got I4
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						return null;
					}
					_003C_003E1__state = -1;
					string tag = _003Cgo_003E5__2.tag;
					if (tag == null)
					{
						return null;
					}
					float unscaledTime = Time.unscaledTime;
					float num = seconds - unscaledTime;
					seconds = num;
				}
				else
				{
					_003C_003E1__state = -1;
					object obj = this + 28;
					string tag2 = instance.tag;
					obj = tag2;
				}
				if (seconds > 0f)
				{
					object obj2 = this + 12;
					obj2 = 0;
					_003C_003E1__state = 1;
					return 1;
				}
				_003C_003E4__this.RemoveAt((int)instance);
				return null;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CDoDespawnAfterSeconds_003Ed__57(int _003C_003E1__state)
		{
			throw new InvalidOperationException();
		}

		void IDisposable.Dispose()
		{
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Expected Obj, but got Unknown
			_003C_003E1__state = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<PrefabPool> list = default;
			list._002Ector();
			object obj = this + 16;
			obj = list;
		}

		private bool MoveNext()
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_003C_003E2__current != 0;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CListForAudioStop_003Ed__64(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public AudioSource src;

		public SpawnPool _003C_003E4__this;

		private GameObject _003CsrcGameObject_003E5__2;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0073: Unknown result type (might be due to invalid IL or missing references)
				//IL_0078: Expected Obj, but got Unknown
				//IL_0081: Expected Obj, but got I4
				//IL_0095: Expected Obj, but got I4
				//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b0: Expected Obj, but got Unknown
				//IL_0114: Unknown result type (might be due to invalid IL or missing references)
				//IL_0119: Expected Obj, but got Unknown
				//IL_0122: Expected Obj, but got I4
				//IL_0136: Expected Obj, but got I4
				//IL_0185: Expected I4, but got Obj
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state != 2)
						{
							return null;
						}
						_003C_003E1__state = -1;
					}
					else
					{
						_003C_003E1__state = -1;
						object obj = this + 24;
						string tag = src.tag;
						obj = tag;
					}
					if (src.loop)
					{
						object obj2 = this + 12;
						obj2 = 0;
						_003C_003E1__state = 2;
						return 1;
					}
					string tag2 = _003CsrcGameObject_003E5__2.tag;
					if (tag2 != null)
					{
						GameObject gameObject = src.gameObject;
						_003C_003E4__this.RemoveAt((int)gameObject);
					}
					else
					{
						src.Pause();
					}
					return null;
				}
				_003C_003E1__state = -1;
				object obj3 = this + 12;
				obj3 = 0;
				_003C_003E1__state = 1;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		private bool MoveNext()
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_003C_003E2__current != 0;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CGetEnumerator_003Ed__73(int _003C_003E1__state) : IEnumerator<Transform>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private Transform _003C_003E2__current;

		public SpawnPool _003C_003E4__this;

		private int _003Cj_003E5__2;

		private LinkedListNode<PooledInstanceData> _003Cnode_003E5__3;

		Transform IEnumerator<Transform>.Current
		{
			get
			{
				//IL_0048: Expected Obj, but got I4
				//IL_005e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0063: Expected Obj, but got Unknown
				//IL_02f4: Expected Obj, but got I4
				//IL_00fc: Expected Obj, but got I4
				//IL_0177: Unknown result type (might be due to invalid IL or missing references)
				//IL_017c: Expected Obj, but got Unknown
				//IL_0185: Expected Obj, but got I4
				//IL_01a8: Expected Obj, but got I4
				//IL_0126: Unknown result type (might be due to invalid IL or missing references)
				//IL_012b: Expected Obj, but got Unknown
				//IL_0163: Expected Obj, but got I4
				//IL_016c: Expected Obj, but got I4
				//IL_022e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0233: Expected Obj, but got Unknown
				//IL_0249: Expected Obj, but got I4
				//IL_01f9: Expected Obj, but got I4
				SpawnPool spawnPool = _003C_003E4__this;
				object obj2;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						object obj = this + 24;
						LinkedListNode<PooledInstanceData> linkedListNode = _003Cnode_003E5__3;
						LinkedListNode<PooledInstanceData> linkedListNode2;
						if (linkedListNode.next != null)
						{
							LinkedList<PooledInstanceData> list = linkedListNode.list;
							linkedListNode2 = ((linkedListNode.next != list.head) ? linkedListNode.next : null);
						}
						else
						{
							linkedListNode2 = null;
						}
						obj = linkedListNode2;
						obj2 = 8;
					}
					else
					{
						obj2 = 11;
					}
				}
				else
				{
					_003C_003E1__state = -1;
					_003Cj_003E5__2 = 0;
					obj2 = 10;
				}
				object obj3 = obj2;
				Transform result = default;
				while (true)
				{
					if ((nint)obj3 == 8)
					{
						if (_003Cnode_003E5__3 != null)
						{
							object obj4 = this + 12;
							LinkedListNode<PooledInstanceData> linkedListNode3 = _003Cnode_003E5__3;
							PooledInstanceData item = linkedListNode3.item;
							obj4 = item.transform__BackingField;
							_003C_003E1__state = 1;
							result = (Transform)1;
							obj3 = 11;
						}
						else
						{
							object obj5 = this + 24;
							obj5 = 0;
							int num = _003Cj_003E5__2 + 1;
							_003Cj_003E5__2 = num;
							obj3 = 10;
						}
					}
					else if ((nint)obj3 == 10)
					{
						List<PrefabPool> prefabPools = spawnPool._prefabPools;
						if (_003Cj_003E5__2 >= prefabPools._size)
						{
							result = null;
							obj3 = 11;
							continue;
						}
						PrefabPool prefabPool = spawnPool._prefabPools.get_Item(_003Cj_003E5__2);
						LinkedList<PooledInstanceData> despawned = prefabPool.despawned;
						object obj6 = this + 24;
						obj6 = despawned.head;
						obj3 = 8;
					}
					else if ((nint)obj3 == 11)
					{
						break;
					}
				}
				return result;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		private bool MoveNext()
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_003C_003E2__current != 0;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CSystem_002DCollections_002DIEnumerable_002DGetEnumerator_003Ed__74(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public SpawnPool _003C_003E4__this;

		private int _003Cj_003E5__2;

		private LinkedListNode<PooledInstanceData> _003Cnode_003E5__3;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0048: Expected Obj, but got I4
				//IL_005e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0063: Expected Obj, but got Unknown
				//IL_02e7: Expected Obj, but got I4
				//IL_00fc: Expected Obj, but got I4
				//IL_016a: Unknown result type (might be due to invalid IL or missing references)
				//IL_016f: Expected Obj, but got Unknown
				//IL_0178: Expected Obj, but got I4
				//IL_019b: Expected Obj, but got I4
				//IL_0126: Unknown result type (might be due to invalid IL or missing references)
				//IL_012b: Expected Obj, but got Unknown
				//IL_0156: Expected Obj, but got I4
				//IL_015f: Expected Obj, but got I4
				//IL_0221: Unknown result type (might be due to invalid IL or missing references)
				//IL_0226: Expected Obj, but got Unknown
				//IL_023c: Expected Obj, but got I4
				//IL_01ec: Expected Obj, but got I4
				SpawnPool spawnPool = _003C_003E4__this;
				object obj2;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						object obj = this + 24;
						LinkedListNode<PooledInstanceData> linkedListNode = _003Cnode_003E5__3;
						LinkedListNode<PooledInstanceData> linkedListNode2;
						if (linkedListNode.next != null)
						{
							LinkedList<PooledInstanceData> list = linkedListNode.list;
							linkedListNode2 = ((linkedListNode.next != list.head) ? linkedListNode.next : null);
						}
						else
						{
							linkedListNode2 = null;
						}
						obj = linkedListNode2;
						obj2 = 8;
					}
					else
					{
						obj2 = 11;
					}
				}
				else
				{
					_003C_003E1__state = -1;
					_003Cj_003E5__2 = 0;
					obj2 = 10;
				}
				object obj3 = obj2;
				object result = default;
				while (true)
				{
					if ((nint)obj3 == 8)
					{
						if (_003Cnode_003E5__3 != null)
						{
							object obj4 = this + 12;
							LinkedListNode<PooledInstanceData> linkedListNode3 = _003Cnode_003E5__3;
							obj4 = linkedListNode3.item;
							_003C_003E1__state = 1;
							result = 1;
							obj3 = 11;
						}
						else
						{
							object obj5 = this + 24;
							obj5 = 0;
							int num = _003Cj_003E5__2 + 1;
							_003Cj_003E5__2 = num;
							obj3 = 10;
						}
					}
					else if ((nint)obj3 == 10)
					{
						List<PrefabPool> prefabPools = spawnPool._prefabPools;
						if (_003Cj_003E5__2 >= prefabPools._size)
						{
							result = null;
							obj3 = 11;
							continue;
						}
						PrefabPool prefabPool = spawnPool._prefabPools.get_Item(_003Cj_003E5__2);
						LinkedList<PooledInstanceData> despawned = prefabPool.despawned;
						object obj6 = this + 24;
						obj6 = despawned.head;
						obj3 = 8;
					}
					else if ((nint)obj3 == 11)
					{
						break;
					}
				}
				return result;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		private bool MoveNext()
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_003C_003E2__current != 0;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	public int spawnPriority;

	public int despawnPriority;

	public int logLevelAdjust;

	public string poolName;

	public bool dontReparent;

	public bool _dontDestroyOnLoad;

	public bool sendUnityEvents;

	public List<PrefabPoolGroup> _prefabPoolGroups;

	public Dictionary<object, bool> prefabsFoldOutStates;

	public float maxParticleDespawnTime;

	private Transform group__BackingField;

	public PrefabsDict prefabs;

	public Dictionary<object, bool> _editorListItemStates;

	private List<PrefabPool> _prefabPools;

	public InstantiateDelegate instantiateDelegates;

	public DestroyDelegate destroyDelegates;

	public bool dontDestroyOnLoad
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			bool result = default;
			return result;
		}
		set
		{
			//IL_00c9: Expected I, but got Obj
			//IL_00df: Expected Obj, but got I
			//IL_0144: Expected I, but got Obj
			//IL_015a: Expected Obj, but got I
			//IL_0177: Expected I, but got Obj
			//IL_0112: Expected Obj, but got I
			//IL_011d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0122: Expected Obj, but got Unknown
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_0090: Expected I, but got Obj
			//IL_00b6: Expected I, but got Obj
			nint num = (nint)typeof(LogCategory);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(LogCategory);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v27 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((UnityEngine.Object)this).m_CachedPtr = (IntPtr)(value ? 1 : 0);
			nint num3 = (nint)typeof(Log);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v12 (Il2CppClass<SYBO.Components.Logging.Log>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			bool flag = obj2 == null;
			nint num4 = (nint)typeof(Log);
			if (!flag)
			{
				nint num5 = (nint)typeof(Log);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v21 (Il2CppClass<SYBO.Components.Logging.Log>)+74]");
				bool flag2 = (nint)0 == 0;
				bool flag3 = !flag2;
				num4 = (nint)typeof(Log);
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num4 = (nint)typeof(Log);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ L1_v2 (Il2CppClass<SYBO.Components.Logging.Log>)+5C]");
			object obj3 = (nint)0 + (nint)48;
			obj3 = this;
			object obj4 = this + 12;
			obj4 = "Pool";
		}
	}

	public Transform group
	{
		get
		{
			//IL_0019: Expected Obj, but got I4
			bool flag = _dontDestroyOnLoad;
			return (Transform)flag;
		}
		private set
		{
			//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fe: Expected I4, but got Unknown
			//IL_0116: Expected I, but got Obj
			//IL_012c: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_006f: Expected I, but got Obj
			//IL_0085: Expected Obj, but got I
			//IL_00b0: Expected I, but got Obj
			bool flag = (byte)(value & 1) != 0;
			_dontDestroyOnLoad = flag;
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S1_v5 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S1_v22 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)group__BackingField).FindKernel((string)null) == 0)
			{
				return;
			}
			string text = group__BackingField.tag;
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S1_v18 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((UnityEngine.UnitySynchronizationContext)(object)text).Exec();
		}
	}

	// C# has no syntax for parameterized property 'Item'.
	public Transform get_Item(int index)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected Obj, but got Unknown
		//IL_0046: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Transform transform = default;
		((UnityEngine.Object)transform).m_CachedPtr = (IntPtr)0;
		object obj = transform + 20;
		obj = this;
		object obj2 = transform + 16;
		obj2 = index;
		return transform;
	}

	public void set_Item(int index, Transform value)
	{
		RemoveAt(index);
	}

	public int Count
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_04d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_04db: Expected Obj, but got Unknown
			//IL_04e4: Expected Obj, but got I4
			//IL_04f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_04f8: Expected Obj, but got Unknown
			//IL_0501: Expected Obj, but got I4
			//IL_0516: Unknown result type (might be due to invalid IL or missing references)
			//IL_051b: Expected Obj, but got Unknown
			//IL_0053: Expected Obj, but got I4
			//IL_035b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0360: Expected Obj, but got Unknown
			//IL_0369: Unknown result type (might be due to invalid IL or missing references)
			//IL_036e: Expected Obj, but got Unknown
			//IL_039a: Expected Obj, but got I4
			//IL_0423: Expected Obj, but got I
			//IL_0459: Unknown result type (might be due to invalid IL or missing references)
			//IL_045e: Expected Obj, but got Unknown
			//IL_0112: Unknown result type (might be due to invalid IL or missing references)
			//IL_0117: Expected Obj, but got Unknown
			//IL_0120: Unknown result type (might be due to invalid IL or missing references)
			//IL_0125: Expected Obj, but got Unknown
			//IL_0151: Expected Obj, but got I4
			//IL_048f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0494: Expected Obj, but got Unknown
			//IL_020e: Expected Obj, but got I
			//IL_02a3: Expected Obj, but got I4
			//IL_0244: Unknown result type (might be due to invalid IL or missing references)
			//IL_0249: Expected Obj, but got Unknown
			//IL_027a: Unknown result type (might be due to invalid IL or missing references)
			//IL_027f: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 80;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [457F45]");
			bool flag = (nint)0 == 0;
			bool flag2 = !flag;
			object obj3 = obj2 + 56;
			obj3 = 0;
			_ = 0;
			object obj4 = obj2 + 32;
			obj4 = 0;
			_ = 0;
			_ = 0;
			object obj5 = obj2 + 24;
			obj5 = obj;
			_ = -1;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<string> list = default;
			list._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			object obj6 = 0;
			object obj7 = default;
			object obj8 = default;
			object obj18 = default;
			object obj20 = default;
			object obj21 = default;
			object obj22 = default;
			object obj23 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj7 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
					obj4 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
					_ = 0;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						if (obj8 == null)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
					}
					object obj9 = obj5 + 4;
					object obj10 = obj9 + 1;
					obj9 = obj10;
					object obj11 = obj10 << 2;
					object obj12 = obj5 + obj11;
					obj12 = 90;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v19+4]");
					if ((nint)0 != -1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v19+4]");
						object obj13 = (nint)0 << 2;
						object obj14 = obj5 + obj13;
						if ((nint)obj14 == 90)
						{
							object obj15 = obj5 + 4;
							if ((nint)obj15 > -1)
							{
								object obj16 = obj15 + -1;
								obj15 = obj16;
							}
							continue;
						}
					}
					if (obj6 == null)
					{
						obj6 = 0;
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
					object obj17 = obj18;
					object obj19 = obj20;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
					if (obj17 == obj21)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
						obj22 = obj23;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
					}
					break;
				}
				object obj24 = obj5 + 4;
				object obj25 = obj24 + 1;
				obj24 = obj25;
				object obj26 = obj25 << 2;
				object obj27 = obj5 + obj26;
				obj27 = 115;
				obj22 = obj6;
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v19+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v19+4]");
				object obj28 = (nint)0 << 2;
				object obj29 = obj5 + obj28;
				if ((nint)obj29 == 115)
				{
					object obj30 = obj5 + 4;
					if ((nint)obj30 > -1)
					{
						object obj31 = obj30 + -1;
						obj30 = obj31;
					}
					goto IL_05bc;
				}
			}
			if (obj22 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
			goto IL_05bc;
			IL_05bc:
			string[] strB = list.ToArray();
			return string.CompareOrdinalIgnoreCaseHelper(", ", (string)(object)strB);
		}
	}

	public bool IsReadOnly
	{
		get
		{
			//IL_0023: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			_ = 0;
			bool flag = default;
			object obj = (flag ? 1 : 0) + 16;
			obj = this;
			return flag;
		}
	}

	public int PrefabPoolCount
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			return 0;
		}
	}

	private void Awake()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected Obj, but got Unknown
		object obj = this + 12;
		obj = "";
		object obj2 = this + 16;
		obj2 = "";
		logLevelAdjust = 1;
		CancelInvoke();
	}

	public int GetBalanceOperations()
	{
		//IL_0007: Expected I4, but got Obj
		return (int)group__BackingField;
	}

	internal GameObject InstantiatePrefab(GameObject prefab, Vector3 pos, Quaternion rot)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected Obj, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		GameObject gameObject = default;
		((UnityEngine.Object)gameObject).m_CachedPtr = (IntPtr)0;
		object obj = gameObject + 16;
		obj = this;
		object obj2 = pos & 1;
		object obj3 = rot & 1;
		return gameObject;
	}

	internal void DestroyInstance(GameObject instance)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 44;
		obj = instance;
	}

	private void OnDestroy()
	{
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected Obj, but got Unknown
		//IL_001d: Expected I, but got Obj
		//IL_0033: Expected Obj, but got I
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected Obj, but got Unknown
		//IL_0119: Expected I4, but got Obj
		//IL_0119: Expected I4, but got Obj
		//IL_005e: Expected I, but got Obj
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Expected Obj, but got Unknown
		//IL_0357: Expected I, but got Obj
		//IL_036d: Expected Obj, but got I
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected Obj, but got Unknown
		//IL_014a: Expected I4, but got Obj
		//IL_014a: Expected I4, but got Obj
		//IL_051b: Expected VT, but got Obj
		//IL_0398: Expected I, but got Obj
		//IL_01a8: Expected I, but got Obj
		//IL_01be: Expected Obj, but got I
		//IL_01e9: Expected I, but got Obj
		//IL_0470: Expected I, but got Obj
		//IL_0486: Expected Obj, but got I
		//IL_02b2: Expected I, but got Obj
		if (~(_dontDestroyOnLoad ? 1u : 0u) == 0)
		{
			string text = tag;
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v60 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S1_v65 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((UnityEngine.UnitySynchronizationContext)(object)text).Exec();
		}
		object obj2 = this + 44;
		GameObject gameObject = base.gameObject;
		obj2 = gameObject;
		if (poolName != "")
		{
			object obj3 = this + 24;
			UnityEngine.Object obj4 = UnityEngine.Object.Instantiate((UnityEngine.Object)group__BackingField);
			string text2 = ((string)(object)obj4).Remove((int)"Pool", (int)"");
			obj3 = text2;
			object obj5 = this + 24;
			string text3 = poolName.Remove((int)"(Clone)", (int)"");
			obj5 = text3;
		}
		int num3 = default;
		int num10 = default;
		while (true)
		{
			List<PrefabPoolGroup> prefabPoolGroups = _prefabPoolGroups;
			if (num3 >= prefabPoolGroups._size)
			{
				break;
			}
			PrefabPoolGroup prefabPoolGroup = _prefabPoolGroups.get_Item(num3);
			List<PrefabPool> prefabPools = prefabPoolGroup.prefabPools;
			int num4 = 0;
			while (num4 < prefabPools._size)
			{
				PrefabPool prefabPool = prefabPools.get_Item(num4);
				nint num5 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S1_v27 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num6 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ S1_v45 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (!(prefabPool.prefab != null))
				{
					prefabPool.SelfDestruct();
					Add((Transform)(object)prefabPool);
					if (~(prefabPool.cullDespawned ? 1u : 0u) == 0 && prefabPool.cullAbove < prefabPool.preloadAmount)
					{
						prefabPool.preloadAmount = prefabPool.cullAbove;
					}
					PrefabPool prefabPool2 = prefabPools.get_Item(num4);
					nint num7 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ S0_v72 (Il2CppClass<UnityEngine.Mathf>)+BA]");
					object obj7 = (nint)0 & (nint)0x200;
					if (obj7 != null)
					{
						nint num8 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ S0_v82 (Il2CppClass<UnityEngine.Mathf>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (prefabPool.preloadAmount <= prefabPool2.limitAmount)
					{
					}
				}
				int num9 = num4 + 1;
				num4 = num9;
			}
			num3 = num10 + 1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_003CDoDespawnAfterSeconds_003Ed__57 obj8 = default;
		((IDisposable)obj8).Dispose();
		object obj9 = obj8 + 12;
		obj9 = "Runtime Group";
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F73");
		nint num11 = (nint)typeof(PoolManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ S0_v29 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num12 = (nint)typeof(PoolManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S0_v36 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		PoolManager.Pools.Add((KeyValuePair<string, SpawnPool>)this);
	}

	public void CreatePrefabPool(PrefabPool prefabPool)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		object obj = this - -64;
		if (obj != null)
		{
			object obj2 = this - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7C62");
		}
		else
		{
			((SpawnPoolsDict)(object)prefabPool).DestroyAll();
		}
	}

	public unsafe void Add(Transform instance, string prefabName, bool despawn, bool parent)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_092f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0934: Expected Obj, but got Unknown
		//IL_093d: Expected Obj, but got I4
		//IL_0946: Unknown result type (might be due to invalid IL or missing references)
		//IL_094b: Expected Obj, but got Unknown
		//IL_0954: Expected Obj, but got I4
		//IL_095d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0962: Expected Obj, but got Unknown
		//IL_096b: Expected Obj, but got I4
		//IL_0974: Unknown result type (might be due to invalid IL or missing references)
		//IL_0979: Expected Obj, but got Unknown
		//IL_098d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0992: Expected Obj, but got Unknown
		//IL_099a: Expected Obj, but got I4
		//IL_09a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a5: Expected Obj, but got Unknown
		//IL_09ad: Expected Obj, but got I4
		//IL_09b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b8: Expected Obj, but got Unknown
		//IL_09d3: Expected Obj, but got VT
		//IL_09f0: Expected I4, but got VT
		//IL_001b: Expected Obj, but got VT
		//IL_0033: Expected I, but got Obj
		//IL_0049: Expected Obj, but got I
		//IL_0a11: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a16: Expected Obj, but got Unknown
		//IL_0a1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a24: Expected Obj, but got Unknown
		//IL_0a35: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3a: Expected Obj, but got Unknown
		//IL_0a4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a50: Expected Obj, but got Unknown
		//IL_0a61: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a66: Expected I4, but got Unknown
		//IL_0a73: Expected I4, but got Obj
		//IL_0a7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a81: Expected Obj, but got Unknown
		//IL_0aa0: Expected I4, but got Obj
		//IL_00bb: Expected Obj, but got VT
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected Obj, but got Unknown
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected Obj, but got Unknown
		//IL_0106: Expected I4, but got Obj
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected Obj, but got Unknown
		//IL_0074: Expected I, but got Obj
		//IL_0138: Expected I4, but got Obj
		//IL_0162: Expected Obj, but got VT
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected Obj, but got Unknown
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected Obj, but got Unknown
		//IL_01ad: Expected I4, but got Obj
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected Obj, but got Unknown
		//IL_01df: Expected I4, but got Obj
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Expected Obj, but got Unknown
		//IL_0200: Expected Obj, but got VT
		//IL_020d: Expected I4, but got Obj
		//IL_0220: Expected VT, but got I4
		//IL_0231: Expected Obj, but got VT
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Expected Obj, but got Unknown
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Expected Obj, but got Unknown
		//IL_027c: Expected I4, but got Obj
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Expected Obj, but got Unknown
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Expected Obj, but got Unknown
		//IL_02ce: Expected I4, but got Obj
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Expected Obj, but got Unknown
		//IL_02f7: Expected I4, but got I8
		//IL_0312: Expected Obj, but got I4
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Expected Obj, but got Unknown
		//IL_0acb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad0: Expected Obj, but got Unknown
		//IL_0ad9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ade: Expected Obj, but got Unknown
		//IL_0b0a: Expected Obj, but got I4
		//IL_0b13: Expected Obj, but got I4
		//IL_0c54: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c59: Expected Obj, but got Unknown
		//IL_0543: Expected Obj, but got I
		//IL_03e9: Expected I4, but got Obj
		//IL_03f9: Expected Obj, but got I4
		//IL_0408: Expected Obj, but got I4
		//IL_0422: Expected Obj, but got I4
		//IL_0432: Expected Obj, but got I4
		//IL_0441: Expected Obj, but got I4
		//IL_0456: Unknown result type (might be due to invalid IL or missing references)
		//IL_045b: Expected I4, but got Unknown
		//IL_0579: Unknown result type (might be due to invalid IL or missing references)
		//IL_057e: Expected Obj, but got Unknown
		//IL_0b35: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3a: Expected Obj, but got Unknown
		//IL_0b43: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b48: Expected Obj, but got Unknown
		//IL_0b74: Expected Obj, but got I4
		//IL_05af: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b4: Expected Obj, but got Unknown
		//IL_0c76: Expected I, but got Obj
		//IL_0c8c: Expected Obj, but got I
		//IL_0796: Expected Obj, but got I
		//IL_067f: Expected I4, but got Obj
		//IL_068f: Expected Obj, but got I4
		//IL_069e: Expected Obj, but got I4
		//IL_06b8: Expected Obj, but got I4
		//IL_0cb8: Expected Obj, but got I4
		//IL_084e: Expected I, but got Obj
		//IL_07cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d1: Expected Obj, but got Unknown
		//IL_089b: Expected I, but got Obj
		//IL_08b1: Expected Obj, but got I
		//IL_0be0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be5: Expected Obj, but got Unknown
		//IL_0bfc: Expected I, but got Obj
		//IL_0c12: Expected Obj, but got I
		//IL_0802: Unknown result type (might be due to invalid IL or missing references)
		//IL_0807: Expected Obj, but got Unknown
		//IL_08dc: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 176;
		object obj3 = obj2 - -64;
		obj3 = 0;
		object obj4 = obj2 + 40;
		obj4 = 0;
		object obj5 = obj2 + 24;
		obj5 = 0;
		object obj6 = obj2 + 168;
		obj6 = obj;
		_ = -1;
		object obj7 = this + 36;
		obj7 = despawn;
		object obj8 = this + 8;
		obj8 = parent;
		object obj9 = this + 24;
		_0021_00210 val = (_0021_00210)JsonObject.Get<T>((object)instance, "TournamentId", (IFormatProvider)null);
		obj9 = val;
		_0021_00210 val2 = (_0021_00210)JsonObject.Get<T>((object)instance, "SequenceId", (IFormatProvider)null);
		dontReparent = (byte)(int)val2 != 0;
		DateTime dateTime = ((JsonObject)(object)instance).Get<DateTime>("CurrentTournamentEndDateUtc", (IFormatProvider)null);
		obj3 = dateTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCDB");
		nint num = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v33 (Il2CppClass<System.DateTime>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num2 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v249 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj11 = obj2 + 8;
		object obj12 = obj2 + 144;
		object obj13 = default;
		obj12 = obj13;
		object obj14 = obj2 + 136;
		obj14 = prefabName;
		object obj15 = obj2 + 152;
		obj15 = obj12;
		RefreshType refreshType = (RefreshType)(obj2 + 160);
		((RefreshType*)(int)refreshType)->value__ = (int)obj14;
		object obj16 = obj2 + 128;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCFF");
		object obj17 = default;
		obj16 = obj17;
		((RefreshType*)(int)refreshType)->value__ = (int)obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8E5B");
		DateTime dateTime2 = ((JsonObject)(object)instance).Get<DateTime>("NextTournamentStartDateUtc", (IFormatProvider)null);
		obj3 = dateTime2;
		object obj18 = obj2 + 120;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCDB");
		object obj19 = default;
		obj18 = obj19;
		object obj20 = obj2 + 112;
		obj20 = prefabName;
		obj15 = obj18;
		((RefreshType*)(int)refreshType)->value__ = (int)obj20;
		object obj21 = obj2 + 104;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCFF");
		object obj22 = default;
		obj21 = obj22;
		((RefreshType*)(int)refreshType)->value__ = (int)obj21;
		((Award)(object)this).AppWillRefresh(refreshType);
		DateTime dateTime3 = ((JsonObject)(object)instance).Get<DateTime>("CurrentTournamentStartDateUtc", (IFormatProvider)null);
		obj3 = dateTime3;
		object obj23 = obj2 + 96;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCDB");
		object obj24 = default;
		obj23 = obj24;
		object obj25 = obj2 + 88;
		obj25 = prefabName;
		obj15 = obj23;
		((RefreshType*)(int)refreshType)->value__ = (int)obj25;
		object obj26 = obj2 + 80;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCFF");
		object obj27 = default;
		obj26 = obj27;
		((RefreshType*)(int)refreshType)->value__ = (int)obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8E5D");
		object obj28 = obj2 + 72;
		obj28 = DateTime.MinValue;
		((RefreshType*)(int)refreshType)->value__ = (int)obj28;
		DateTime dateTime4 = ((JsonObject)(object)instance).Get("LatestCalculationDateUtc", (DateTime)refreshType, (IFormatProvider)null);
		obj3 = dateTime4;
		object obj29 = obj2 + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCDB");
		object obj30 = default;
		obj29 = obj30;
		object obj31 = obj2 + 48;
		obj31 = prefabName;
		obj15 = obj29;
		((RefreshType*)(int)refreshType)->value__ = (int)obj31;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCFF");
		object obj32 = obj2 + 32;
		object obj33 = default;
		obj32 = obj33;
		object obj34 = obj2 + 16;
		obj34 = prefabs;
		obj15 = obj32;
		((RefreshType*)(int)refreshType)->value__ = (int)obj34;
		object obj35 = obj15 & 0x3FFFFFFFFFFFFFFFL;
		int num3 = (int)(((RefreshType*)(int)refreshType)->value__ & 0x3FFFFFFFFFFFFFFFL);
		bool flag = (nint)obj35 >= num3;
		_prefabPoolGroups = (List<PrefabPoolGroup>)flag;
		IList<object> list = ((JsonObject)(object)instance).Get<IList<object>>("TournamentDivisions", (IFormatProvider)null);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj36 = this + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj37 = default;
		obj36 = obj37;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		int num4 = 0;
		object obj38 = default;
		object obj39 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj38 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
			obj4 = obj39;
			obj11 = obj4;
			((RefreshType*)(int)refreshType)->value__ = (int)obj11;
			object obj40 = despawnPriority + 16;
			object obj41 = 0 << 3;
			object obj42 = obj40 + obj41;
			obj42 = ((RefreshType*)(int)refreshType)->value__;
			object obj43 = despawnPriority + 16;
			object obj44 = 0 << 3;
			object obj45 = obj43 + obj44;
			int num5 = obj45 + num4;
			num4 = num5;
		}
		object obj46 = obj6 + 4;
		object obj47 = obj46 + 1;
		obj46 = obj47;
		object obj48 = obj47 << 2;
		object obj49 = obj6 + obj48;
		obj49 = 369;
		object obj50 = 0;
		object obj51 = default;
		if (obj51 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v18+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v18+4]");
			object obj52 = (nint)0 << 2;
			object obj53 = obj6 + obj52;
			if ((nint)obj53 == 369)
			{
				object obj54 = obj6 + 4;
				if ((nint)obj54 > -1)
				{
					object obj55 = obj54 + -1;
					obj54 = obj55;
				}
				goto IL_0c27;
			}
		}
		if (obj50 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0c27;
		IL_0c68:
		nint num6 = (nint)typeof(Tournament._003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v832 @ S1_v147 (Il2CppClass<TopRun.Internal.Tournament+<>c>)+BA]");
		object obj56 = (nint)0 & (nint)0x200;
		if (obj56 != null)
		{
			nint num7 = (nint)typeof(Tournament._003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v853 @ S1_v184 (Il2CppClass<TopRun.Internal.Tournament+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag2 = Tournament._003C_003Ec._003C_003E9__6_0 == null;
		bool flag3 = !flag2;
		Comparison<Tournament.Participant> comparison = Tournament._003C_003Ec._003C_003E9__6_0;
		if (!flag3)
		{
			nint num8 = (nint)typeof(Tournament._003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v872 @ S1_v158 (Il2CppClass<TopRun.Internal.Tournament+<>c>)+BA]");
			object obj57 = (nint)0 & (nint)0x200;
			if (obj57 != null)
			{
				nint num9 = (nint)typeof(Tournament._003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v905 @ S1_v178 (Il2CppClass<TopRun.Internal.Tournament+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num10 = 0;
			_ = 0;
			Comparison<Tournament.Participant> comparison2 = default;
			object obj58 = comparison2 + 16;
			obj58 = Tournament._003C_003Ec._003C_003E9;
			nint num11 = (nint)typeof(Tournament._003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v933 @ S1_v175 (Il2CppClass<TopRun.Internal.Tournament+<>c>)+5C]");
			object obj59 = (nint)0 + (nint)4;
			obj59 = comparison2;
			comparison = comparison2;
		}
		Array.Sort((Tournament.Participant[])logLevelAdjust, comparison);
		return;
		IL_0c27:
		spawnPriority = num4;
		IList<object> list2 = ((JsonObject)(object)instance).Get<IList<object>>("TournamentParticipants", (IFormatProvider)null);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj60 = this + 20;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj61 = default;
		obj60 = obj61;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj62 = default;
		object obj63 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj62 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
			obj5 = obj63;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
			obj2 = obj5;
			((RefreshType*)(int)refreshType)->value__ = (int)obj2;
			object obj64 = logLevelAdjust + 16;
			object obj65 = 0 << 3;
			object obj66 = obj64 + obj65;
			obj66 = ((RefreshType*)(int)refreshType)->value__;
		}
		object obj67 = obj6 + 4;
		object obj68 = obj67 + 1;
		obj67 = obj68;
		object obj69 = obj68 << 2;
		object obj70 = obj6 + obj69;
		obj70 = 519;
		object obj71 = default;
		if (obj71 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v18+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v18+4]");
			object obj72 = (nint)0 << 2;
			object obj73 = obj6 + obj72;
			if ((nint)obj73 == 519)
			{
				object obj74 = obj6 + 4;
				if ((nint)obj74 > -1)
				{
					object obj75 = obj74 + -1;
					obj74 = obj75;
				}
				goto IL_0c68;
			}
		}
		if (obj50 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0c68;
	}

	public void Add(Transform item)
	{
		//IL_01ef: Expected I, but got Obj
		//IL_0205: Expected Obj, but got I
		//IL_0292: Expected Obj, but got I
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected Obj, but got Unknown
		//IL_0131: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0152: Expected Obj, but got I
		//IL_0160: Expected I, but got Obj
		//IL_0176: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0230: Expected Obj, but got I
		//IL_0244: Expected Obj, but got I
		//IL_0263: Expected Obj, but got I
		//IL_0263: Expected Obj, but got I
		//IL_01a1: Expected I, but got Obj
		//IL_00ed: Expected I4, but got Obj
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(PoolManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(PoolManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v31 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = ((SpawnPoolsDict)(nint)((UnityEngine.Object)item).m_CachedPtr).ToString();
		if (text != null)
		{
			nint num3 = (nint)typeof(PoolManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v18 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(PoolManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S1_v27 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = PoolManager.PrefabPoolExists((Transform)(nint)((UnityEngine.Object)item).m_CachedPtr);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v27 (System.Boolean)+24]");
			object obj3 = 0;
			IntPtr cachedPtr = ((UnityEngine.Object)item).m_CachedPtr;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S2_v10+18]");
			string text2 = string.Format((IFormatProvider)(object)"Prefab '{0}' is already pooled in  SpawnPool '{1}'.Prefabs cannot be in more than 1 SpawnPool.", (string)(nint)cachedPtr, 0);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Exception ex = default;
			ex.SetErrorCode((int)text2);
			((SpawnPool)(object)ex).CreatePrefabPool((PrefabPool)null);
			return;
		}
		object obj4 = item + 36;
		obj4 = this;
		_prefabPools.Add((PrefabPool)(object)item);
		UnityEngine.Object key = UnityEngine.Object.Instantiate((UnityEngine.Object)(nint)((UnityEngine.Object)item).m_CachedPtr);
		prefabs.Add((string)(object)key, (Transform)(nint)((UnityEngine.Object)item).m_CachedPtr);
		nint num5 = (nint)typeof(PoolManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v16 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num6 = (nint)typeof(PoolManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v21 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		PoolManager.Remove((SpawnPool)(object)item);
	}

	public void Remove(Transform item)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		NotSupportedException ex = default;
		ex._002Ector("Use SpawnPool.Spawn() to properly add items to the pool.");
		((SpawnPool)(object)ex).Add((Transform)null);
	}

	public Transform Spawn(Transform prefab, Vector3 pos, Quaternion rot, Transform parent)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_1479: Unknown result type (might be due to invalid IL or missing references)
		//IL_147e: Expected Obj, but got Unknown
		//IL_1487: Unknown result type (might be due to invalid IL or missing references)
		//IL_148c: Expected Obj, but got Unknown
		//IL_1495: Unknown result type (might be due to invalid IL or missing references)
		//IL_149a: Expected Obj, but got Unknown
		//IL_14a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_14a8: Expected Obj, but got Unknown
		//IL_14f6: Expected Obj, but got I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - -64;
		object obj3 = obj2 + 32;
		object obj4 = obj2 + 24;
		object obj5 = obj2 + 16;
		object obj6 = obj2 + 48;
		obj6 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		X509Certificate2 x509Certificate = default;
		bool flag = x509Certificate != null;
		if (flag)
		{
			bool flag2 = TrustedRoots.VerifyTrust(x509Certificate);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			object obj8 = default;
			object obj7 = flag & obj8;
			if (obj7 != null && ResponseExtensions.IsBson((IResponse)x509Certificate))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				object obj9 = default;
				if (obj9 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
					object obj11 = default;
					object obj10 = obj11;
					object obj13 = default;
					object obj12 = obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
					object obj14 = default;
					if (obj12 == obj14)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
						object obj16 = default;
						object obj15 = obj16;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
						object obj18 = default;
						object obj17 = obj18;
					}
					else
					{
						object obj17 = obj10;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
				}
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		}
		return (Transform)1;
	}

	public Transform Spawn(Transform prefab, Vector3 pos, Quaternion rot)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0087: Expected Obj, but got F4
		//IL_0099: Expected I4, but got F4
		//IL_00a6: Expected Obj, but got F4
		//IL_00b8: Expected I, but got F4
		//IL_003a: Expected Obj, but got F4
		//IL_004c: Expected I4, but got F4
		//IL_0059: Expected Obj, but got F4
		//IL_006b: Expected I, but got F4
		string text = default;
		GameObject gameObject = (GameObject)(object)(text + 16);
		if (instantiateDelegates != null)
		{
			text = (string)pos.x;
			text.m_stringLength = (int)pos.z;
			gameObject = (GameObject)rot.x;
			((UnityEngine.Object)gameObject).m_CachedPtr = (IntPtr)rot.z;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8548");
			Transform result = default;
			return result;
		}
		text = (string)pos.x;
		text.m_stringLength = (int)pos.z;
		gameObject = (GameObject)rot.x;
		((UnityEngine.Object)gameObject).m_CachedPtr = (IntPtr)rot.z;
		return (Transform)(object)((SpawnPoolsDict)(object)prefab).Create(text, gameObject);
	}

	public Transform Spawn(Transform prefab)
	{
		//IL_002d: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		NotSupportedException ex = default;
		ex._002Ector("SpawnPools can only be destroyed, not removed and kept alive outside of PoolManager. There are only 2 legal ways to destroy a SpawnPool: Destroy the GameObject directly, if you have a reference, or use PoolManager.Destroy(string poolName).");
		((SpawnPoolsDict)(object)ex).Remove((KeyValuePair<string, SpawnPool>)0);
		return null;
	}

	public T Spawn<T>(T prefab) where T : Component
	{
		//IL_0060: Expected Obj, but got I
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected Obj, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected Obj, but got Unknown
		//IL_00a4: Expected I, but got Obj
		//IL_00ba: Expected Obj, but got I
		//IL_00ef: Expected Obj, but got I
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected Obj, but got Unknown
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		nint num = default;
		object obj = num + 24;
		object obj2 = obj;
		object obj3 = obj2;
		object obj4 = obj3 & 0x3FFF;
		object obj5 = obj4 + 6161;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v26 @ S2_v5 (should have been resolved before IL gen)");
		nint num2 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S1_v7 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S2_v8+4]");
		object obj8 = 0;
		object obj9 = obj8 & 0x1FFF;
		object obj10 = obj9 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v53 @ S3_v6 (should have been resolved before IL gen)");
		T result = default;
		return result;
	}

	public T Spawn<T>(T prefab, Vector3 position, Quaternion rotation, Transform parent) where T : Component
	{
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120A3");
		T result = default;
		return result;
	}

	public T Spawn<T>(T prefab, Transform parent) where T : Component
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Expected Obj, but got Unknown
		//IL_03e7: Expected Obj, but got I4
		//IL_03f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f5: Expected Obj, but got Unknown
		//IL_03fe: Expected Obj, but got I4
		//IL_0413: Unknown result type (might be due to invalid IL or missing references)
		//IL_0418: Expected Obj, but got Unknown
		//IL_0421: Expected Obj, but got I4
		//IL_042a: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Expected Obj, but got Unknown
		//IL_047c: Expected Obj, but got I4
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected Obj, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected Obj, but got Unknown
		//IL_00f4: Expected Obj, but got I4
		//IL_0529: Unknown result type (might be due to invalid IL or missing references)
		//IL_052e: Expected Obj, but got Unknown
		//IL_0537: Expected Obj, but got I4
		//IL_0545: Unknown result type (might be due to invalid IL or missing references)
		//IL_054a: Expected Obj, but got Unknown
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected Obj, but got Unknown
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Expected Obj, but got Unknown
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Expected Obj, but got Unknown
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected Obj, but got Unknown
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected Obj, but got Unknown
		//IL_048a: Unknown result type (might be due to invalid IL or missing references)
		//IL_048f: Expected Obj, but got Unknown
		//IL_0498: Unknown result type (might be due to invalid IL or missing references)
		//IL_049d: Expected Obj, but got Unknown
		//IL_04c9: Expected Obj, but got I4
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected Obj, but got Unknown
		//IL_0214: Expected Obj, but got I
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected Obj, but got Unknown
		//IL_0589: Expected Obj, but got I
		//IL_05a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a7: Expected Obj, but got Unknown
		//IL_05b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b5: Expected Obj, but got Unknown
		//IL_02c6: Expected Obj, but got I
		//IL_0388: Expected Obj, but got I
		//IL_0391: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Expected Obj, but got Unknown
		//IL_039f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Expected Obj, but got Unknown
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Expected Obj, but got Unknown
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_0337: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 80;
		object obj3 = obj2 + 68;
		obj3 = 0;
		object obj4 = obj2 + 48;
		obj4 = 0;
		_ = 0;
		_ = 0;
		object obj5 = obj2 + 32;
		obj5 = 0;
		object obj6 = obj2 + 40;
		obj6 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @77DB");
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
		_ = 0;
		object obj7 = 0;
		object obj8 = default;
		object obj9 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj8 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj9 != parent)
				{
					object obj10 = obj7 + 1;
					obj7 = obj10;
					continue;
				}
				object obj11 = obj6 + 4;
				object obj12 = obj11 + 1;
				obj11 = obj12;
				object obj13 = obj12 << 2;
				object obj14 = obj6 + obj13;
				obj14 = 73;
				break;
			}
			object obj15 = obj6 + 4;
			object obj16 = obj15 + 1;
			obj15 = obj16;
			object obj17 = obj16 << 2;
			object obj18 = obj6 + obj17;
			obj18 = 73;
			break;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @919F");
		object obj19 = obj2;
		object obj20 = obj2 + 88;
		object obj21 = 0;
		object obj33 = default;
		while (true)
		{
			object obj22 = obj21 & 0xFFFF;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ S0_v39+B2]");
			if ((nint)obj22 < 0)
			{
				object obj23 = obj21 + 1;
				object obj24 = obj23 << 16;
				object obj25 = obj24 >> 16;
				object obj26 = obj21 & 0xFFFF;
				object obj27 = obj26 << 3;
				object obj28 = obj20 + obj27;
				if (obj28 != typeof(IDisposable))
				{
					obj21 = obj25;
					continue;
				}
				object obj29 = obj2 + 188;
				object obj30 = obj26 << 3;
				object obj31 = obj20 + obj30;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ S2_v40+4]");
				object obj32 = (nint)0 << 3;
				obj33 = obj29 + obj32;
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11C74");
			break;
		}
		object obj34 = obj33 & 0x3FFF;
		object obj35 = obj34 + 80504;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v293 @ S2_v16 (should have been resolved before IL gen)");
		object obj36 = obj2 + 8;
		obj4 = obj36;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ S1_v39+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ S1_v39+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v20+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v20+4]");
			object obj37 = (nint)0 << 2;
			object obj38 = obj6 + obj37;
			if ((nint)obj38 == 73)
			{
				object obj39 = obj6 + 4;
				if ((nint)obj39 > -1)
				{
					object obj40 = obj39 + -1;
					obj39 = obj40;
				}
				goto IL_057b;
			}
		}
		object obj41 = default;
		if (obj41 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_057b;
		IL_057b:
		nint num = default;
		object obj42 = num + 24;
		object obj43 = obj42;
		object obj44 = obj43;
		object obj45 = obj44 & 0x3FFF;
		object obj46 = obj45 + 6161;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v363 @ S3_v11 (should have been resolved before IL gen)");
		object obj47 = default;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj47))
		{
			object obj48 = obj42;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ S3_v14+4]");
			object obj49 = 0;
			object obj50 = obj49 & 0x1FFF;
			object obj51 = obj50 + 22691;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v383 @ S4_v8 (should have been resolved before IL gen)");
			T val = default;
			obj3 = val;
			return val;
		}
		return (T)obj3;
	}

	public unsafe Transform Spawn(Transform prefab, Transform parent)
	{
		//IL_0018: Expected Obj, but got I
		//IL_001c: Expected Obj, but got I4
		return (Transform)((Dictionary<string, SpawnPool>)(nint)((UnityEngine.Object)this).m_CachedPtr).TryGetValue((string)(object)prefab, out *(SpawnPool*)parent);
	}

	public unsafe Transform Spawn(GameObject prefab, Vector3 pos, Quaternion rot, Transform parent)
	{
		//IL_024f: Expected native int or pointer, but got VT
		//IL_0261: Expected native int or pointer, but got VT
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Expected VT, but got Unknown
		//IL_0281: Expected native int or pointer, but got VT
		//IL_0293: Expected native int or pointer, but got VT
		//IL_02bb: Expected I, but got Obj
		//IL_02d1: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_03b8: Expected I, but got Obj
		//IL_03ce: Expected Obj, but got I
		//IL_00da: Expected I, but got Obj
		//IL_012a: Expected VT, but got Obj
		//IL_016e: Expected I, but got Obj
		//IL_0184: Expected Obj, but got I
		//IL_0227: Expected Obj, but got I4
		//IL_0222: Expected native int or pointer, but got Obj
		//IL_01af: Expected I, but got Obj
		//IL_0201: Expected VT, but got Obj
		PrefabPool prefabPool = GetPrefabPool(prefab);
		Vector3 vector = default;
		((Vector3*)(nint)vector)->x = pos.x;
		((Vector3*)(nint)vector)->z = pos.z;
		Quaternion quaternion = (Quaternion)(vector + 16);
		((Quaternion*)(nint)quaternion)->x = rot.x;
		((Quaternion*)(nint)quaternion)->z = rot.z;
		Transform transform = prefabPool.SpawnNew(vector, quaternion);
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v49 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Transform result;
		if (transform != null)
		{
			result = null;
		}
		else
		{
			Transform transform2;
			if ((object)transform == null)
			{
				transform2 = null;
			}
			else
			{
				transform2 = (((object)transform.GetType() != typeof(RectTransform)) ? null : transform);
			}
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S1_v15 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S1_v30 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool relativeTo = (object)transform2 == null;
			if (((ComputeShader)(object)parent).FindKernel((string)null) != 0)
			{
				transform.Translate((Vector3)parent, relativeTo ? Space.Self : Space.World);
			}
			else if (~(dontReparent ? 1u : 0u) != 0)
			{
				Transform parentInternal = transform.parentInternal;
				nint num5 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S2_v19 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num6 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S2_v25 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)(object)parentInternal).FindKernel((string)(object)group__BackingField) != 0)
				{
					transform.Translate((Vector3)group__BackingField, relativeTo ? Space.Self : Space.World);
				}
			}
			bool flag = (byte)(~(sendUnityEvents ? 1u : 0u)) != 0;
			result = transform;
			if (!flag)
			{
				string text = transform.tag;
				System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)text, new UnityEngine.UnitySynchronizationContext.WorkRequest((SendOrPostCallback)(object)"OnSpawned", this, (ManualResetEvent)1));
				result = transform;
			}
		}
		return result;
	}

	public unsafe Transform Spawn(GameObject prefab, Vector3 pos, Quaternion rot)
	{
		//IL_0069: Expected native int or pointer, but got VT
		//IL_007b: Expected native int or pointer, but got VT
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected VT, but got Unknown
		//IL_009b: Expected native int or pointer, but got VT
		//IL_00ad: Expected native int or pointer, but got VT
		//IL_00d7: Expected I, but got Obj
		//IL_00ed: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		Vector3 vector = default;
		((Vector3*)(nint)vector)->x = pos.x;
		((Vector3*)(nint)vector)->z = pos.z;
		Quaternion quaternion = (Quaternion)(vector + 16);
		((Quaternion*)(nint)quaternion)->x = rot.x;
		((Quaternion*)(nint)quaternion)->z = rot.z;
		Transform transform = Spawn(prefab, vector, quaternion, null);
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v16 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v26 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = transform != null;
		bool flag2 = !flag;
		Transform result = transform;
		if (!flag2)
		{
			result = null;
		}
		return result;
	}

	public unsafe Transform Spawn(GameObject prefab)
	{
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected Obj, but got Unknown
		//IL_0189: Expected I, but got Obj
		//IL_019f: Expected Obj, but got I
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected VT, but got Unknown
		//IL_0104: Expected F4, but got Obj
		//IL_00ff: Expected native int or pointer, but got VT
		//IL_0119: Expected F4, but got I
		//IL_0114: Expected native int or pointer, but got VT
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected VT, but got Unknown
		//IL_0134: Expected F4, but got Obj
		//IL_012f: Expected native int or pointer, but got VT
		//IL_0149: Expected F4, but got I
		//IL_0144: Expected native int or pointer, but got VT
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
		Vector3 vector = (Vector3)(obj3 + 28);
		((Vector3*)(nint)vector)->x = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v14+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Quaternion quaternion = (Quaternion)(obj3 + 40);
		((Quaternion*)(nint)quaternion)->x = (float)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Quaternion*)(nint)quaternion)->z = 0f;
		return Spawn(prefab, vector, quaternion);
	}

	public unsafe Transform Spawn(GameObject prefab, Transform parent)
	{
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected Obj, but got Unknown
		//IL_018d: Expected I, but got Obj
		//IL_01a3: Expected Obj, but got I
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected VT, but got Unknown
		//IL_0104: Expected F4, but got Obj
		//IL_00ff: Expected native int or pointer, but got VT
		//IL_0119: Expected F4, but got I
		//IL_0114: Expected native int or pointer, but got VT
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected VT, but got Unknown
		//IL_0134: Expected F4, but got Obj
		//IL_012f: Expected native int or pointer, but got VT
		//IL_0149: Expected F4, but got I
		//IL_0144: Expected native int or pointer, but got VT
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
		Vector3 vector = (Vector3)(obj3 + 28);
		((Vector3*)(nint)vector)->x = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v14+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Quaternion quaternion = (Quaternion)(obj3 + 40);
		((Quaternion*)(nint)quaternion)->x = (float)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Quaternion*)(nint)quaternion)->z = 0f;
		return Spawn(prefab, vector, quaternion, parent);
	}

	public Transform Spawn(string prefabName)
	{
		//IL_0017: Expected Obj, but got I4
		int layer = ((GameObject)(object)prefabName).layer;
		return Spawn((GameObject)layer);
	}

	public Transform Spawn(string prefabName, Transform parent)
	{
		//IL_001b: Expected Obj, but got I4
		int layer = ((GameObject)(object)prefabName).layer;
		return Spawn((GameObject)layer, parent);
	}

	public unsafe Transform Spawn(string prefabName, Vector3 pos, Quaternion rot)
	{
		//IL_001a: Expected native int or pointer, but got VT
		//IL_002c: Expected native int or pointer, but got VT
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected VT, but got Unknown
		//IL_004c: Expected native int or pointer, but got VT
		//IL_005e: Expected native int or pointer, but got VT
		//IL_0075: Expected Obj, but got I4
		int layer = ((GameObject)(object)prefabName).layer;
		Vector3 vector = default;
		((Vector3*)(nint)vector)->x = pos.x;
		((Vector3*)(nint)vector)->z = pos.z;
		Quaternion quaternion = (Quaternion)(vector + 16);
		((Quaternion*)(nint)quaternion)->x = rot.x;
		((Quaternion*)(nint)quaternion)->z = rot.z;
		return Spawn((GameObject)layer, vector, quaternion);
	}

	public unsafe Transform Spawn(string prefabName, Vector3 pos, Quaternion rot, Transform parent)
	{
		//IL_001a: Expected native int or pointer, but got VT
		//IL_002c: Expected native int or pointer, but got VT
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected VT, but got Unknown
		//IL_004c: Expected native int or pointer, but got VT
		//IL_005e: Expected native int or pointer, but got VT
		//IL_0079: Expected Obj, but got I4
		int layer = ((GameObject)(object)prefabName).layer;
		Vector3 vector = default;
		((Vector3*)(nint)vector)->x = pos.x;
		((Vector3*)(nint)vector)->z = pos.z;
		Quaternion quaternion = (Quaternion)(vector + 16);
		((Quaternion*)(nint)quaternion)->x = rot.x;
		((Quaternion*)(nint)quaternion)->z = rot.z;
		return Spawn((GameObject)layer, vector, quaternion, parent);
	}

	public unsafe AudioSource Spawn(AudioSource prefab, Vector3 pos, Quaternion rot)
	{
		//IL_000f: Expected VT, but got Obj
		//IL_0020: Expected native int or pointer, but got VT
		//IL_0032: Expected native int or pointer, but got VT
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected VT, but got Unknown
		//IL_0052: Expected native int or pointer, but got VT
		//IL_0064: Expected native int or pointer, but got VT
		//IL_007b: Expected Obj, but got I4
		bool flag = prefabs.Remove((KeyValuePair<string, Transform>)prefab);
		Vector3 vector = default;
		((Vector3*)(nint)vector)->x = pos.x;
		((Vector3*)(nint)vector)->z = pos.z;
		Quaternion quaternion = (Quaternion)(vector + 16);
		((Quaternion*)(nint)quaternion)->x = rot.x;
		((Quaternion*)(nint)quaternion)->z = rot.z;
		return (AudioSource)(object)Spawn((GameObject)flag, vector, quaternion);
	}

	public AudioSource Spawn(AudioSource prefab)
	{
		//IL_000f: Expected VT, but got Obj
		//IL_001d: Expected Obj, but got I4
		bool flag = prefabs.Remove((KeyValuePair<string, Transform>)prefab);
		return (AudioSource)(object)Spawn((GameObject)flag);
	}

	public AudioSource Spawn(AudioSource prefab, Transform parent)
	{
		//IL_000f: Expected VT, but got Obj
		//IL_0021: Expected Obj, but got I4
		bool flag = prefabs.Remove((KeyValuePair<string, Transform>)prefab);
		return (AudioSource)(object)Spawn((GameObject)flag, parent);
	}

	public unsafe AudioSource Spawn(AudioSource prefab, Vector3 pos, Quaternion rot, Transform parent)
	{
		//IL_000f: Expected VT, but got Obj
		//IL_0020: Expected native int or pointer, but got VT
		//IL_0032: Expected native int or pointer, but got VT
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected VT, but got Unknown
		//IL_0052: Expected native int or pointer, but got VT
		//IL_0064: Expected native int or pointer, but got VT
		//IL_007f: Expected Obj, but got I4
		bool flag = prefabs.Remove((KeyValuePair<string, Transform>)prefab);
		Vector3 vector = default;
		((Vector3*)(nint)vector)->x = pos.x;
		((Vector3*)(nint)vector)->z = pos.z;
		Quaternion quaternion = (Quaternion)(vector + 16);
		((Quaternion*)(nint)quaternion)->x = rot.x;
		((Quaternion*)(nint)quaternion)->z = rot.z;
		return (AudioSource)(object)Spawn((GameObject)flag, vector, quaternion, parent);
	}

	public void Despawn(Transform instance)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		NotSupportedException ex = default;
		ex._002Ector("Use Despawn() to properly manage items that should remain in the pool but be deactivated.");
		((SpawnPool)(object)ex).Remove((Transform)null);
	}

	public void Despawn(Transform instance, Transform parent)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected Obj, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected Obj, but got Unknown
		object obj = this + 24;
		obj = parent;
		object obj2 = this + 20;
		obj2 = instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj4 = default;
		object obj3 = obj4 + 20;
		obj3 = this;
		object obj5 = this + 8;
		obj5 = obj4;
		int hashCode = instance.GetHashCode();
		despawnPriority = hashCode;
	}

	public void Despawn(Transform instance, float seconds)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		_prefabPoolGroups = (List<PrefabPoolGroup>)(object)instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		object obj2 = default;
		object obj = obj2 + 16;
		obj = this;
		throw new ArrayTypeMismatchException();
	}

	public void Despawn(Transform instance, float seconds, Transform parent)
	{
		//IL_0a95: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9a: Expected Obj, but got Unknown
		//IL_0aa3: Expected Obj, but got I4
		//IL_0206: Expected I, but got Obj
		//IL_021c: Expected Obj, but got I
		//IL_0027: Expected Obj, but got I4
		//IL_0bbc: Expected I, but got Obj
		//IL_0bd2: Expected Obj, but got I
		//IL_0247: Expected I, but got Obj
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected Obj, but got Unknown
		//IL_0294: Expected I, but got Obj
		//IL_00a7: Expected I, but got Obj
		//IL_00bd: Expected Obj, but got I
		//IL_0af3: Expected Obj, but got I
		//IL_0b1c: Expected I, but got Obj
		//IL_0b32: Expected Obj, but got I
		//IL_042d: Expected Obj, but got I4
		//IL_00e8: Expected I, but got Obj
		//IL_02f7: Expected I4, but got Obj
		//IL_0309: Expected Obj, but got I4
		//IL_0135: Expected I, but got Obj
		//IL_047f: Expected Obj, but got I4
		//IL_0358: Expected Obj, but got I4
		//IL_0361: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Expected Obj, but got Unknown
		//IL_0cd5: Expected Obj, but got I4
		//IL_03b1: Expected Obj, but got I
		//IL_0b98: Expected Obj, but got I4
		//IL_0bfd: Expected I, but got Obj
		//IL_0c13: Expected Obj, but got I
		//IL_039c: Expected Obj, but got I
		//IL_0497: Expected I4, but got Obj
		//IL_0fa4: Expected I4, but got Obj
		//IL_0fb6: Expected Obj, but got I4
		//IL_0fe1: Expected Obj, but got I
		//IL_04ae: Expected Obj, but got I4
		//IL_04c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c9: Expected Obj, but got Unknown
		//IL_03c4: Expected I, but got Obj
		//IL_0603: Expected Obj, but got I4
		//IL_0c61: Expected I4, but got Obj
		//IL_0c73: Expected Obj, but got I4
		//IL_0c89: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c8e: Expected Obj, but got Unknown
		//IL_0628: Expected I, but got Obj
		//IL_063e: Expected Obj, but got I
		//IL_056c: Expected I, but got Obj
		//IL_0582: Expected Obj, but got I
		//IL_0504: Unknown result type (might be due to invalid IL or missing references)
		//IL_0509: Expected Obj, but got Unknown
		//IL_0d37: Expected Obj, but got I4
		//IL_0d37: Expected Obj, but got I4
		//IL_0d37: Expected Obj, but got I4
		//IL_0d0b: Expected Obj, but got I
		//IL_0d1d: Expected Obj, but got I4
		//IL_051f: Expected Obj, but got I4
		//IL_0d6d: Expected Obj, but got I4
		//IL_0d73: Expected I4, but got Obj
		//IL_0669: Expected I, but got Obj
		//IL_05ad: Expected I, but got Obj
		//IL_072b: Expected Obj, but got I4
		//IL_0731: Expected I4, but got Obj
		//IL_06b1: Expected Obj, but got I4
		//IL_0e8b: Expected Obj, but got I4
		//IL_076f: Expected I, but got Obj
		//IL_0785: Expected Obj, but got I
		//IL_06c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c6: Expected Obj, but got Unknown
		//IL_06ea: Expected Obj, but got I4
		//IL_06f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f8: Expected Obj, but got Unknown
		//IL_0dd2: Expected I, but got Obj
		//IL_0de8: Expected Obj, but got I
		//IL_095e: Expected I, but got Obj
		//IL_0974: Expected Obj, but got I
		//IL_0e18: Expected VT, but got Obj
		//IL_0e18: Expected Obj, but got I4
		//IL_07b0: Expected I, but got Obj
		//IL_07fd: Expected I, but got Obj
		//IL_0a1d: Expected Obj, but got I4
		//IL_0a2b: Expected Obj, but got I4
		//IL_099f: Expected I, but got Obj
		//IL_084a: Expected I, but got Obj
		//IL_0860: Expected Obj, but got I
		//IL_0a87: Expected Obj, but got I4
		//IL_0a87: Expected Obj, but got I4
		//IL_0a87: Expected Obj, but got I4
		//IL_0e58: Expected Obj, but got I4
		//IL_088b: Expected I, but got Obj
		//IL_08be: Expected I, but got Obj
		//IL_08d4: Expected Obj, but got I
		//IL_0eb9: Expected Obj, but got I4
		//IL_08ff: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 4;
		obj = 0;
		if ((nint)instance > 2)
		{
			bool flag = _prefabPoolGroups != null;
			object obj3 = (flag ? 1 : 0) ^ 1;
			object obj4 = obj3 | (object)parent;
			if (obj4 == null)
			{
				return;
			}
			object obj5 = instance - 3;
			if ((nint)obj5 >= 41)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7422");
			}
			nint num = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v195 (Il2CppClass<SocialManager>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num2 = (nint)typeof(SocialManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S0_v201 (Il2CppClass<SocialManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool facebookDialogsSupported = SocialManager.facebookDialogsSupported;
			CollectCoinsDummy[] defaultDummyList = CollectCoinsDummyData.GetDefaultDummyList();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ S1_v147 (CollectCoinsDummy[])+8]");
			object obj7 = (nint)0 + (nint)16;
			object obj8 = obj5 << 2;
			object camera = obj7 + obj8;
			nint num3 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ S2_v69 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num4 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ S2_v82 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float num5;
			if (seconds < 0f)
			{
				num5 = 0f;
			}
			else
			{
				num5 = ((!(seconds > 1f)) ? seconds : 1f);
			}
			float x = num5 * 100f;
			((UIScreenController)facebookDialogsSupported).SetViewportRectXForCamera((Camera)camera, x);
			return;
		}
		if ((object)group__BackingField != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A448");
		}
		nint num6 = (nint)typeof(Math);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v18 (Il2CppClass<System.Math>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num7 = (nint)typeof(Math);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S0_v179 (Il2CppClass<System.Math>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float value = seconds - 1f;
		nint num8 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S1_v11 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num9 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ S1_v131 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num10 = Math.Abs(value);
		if (num10 > Mathf.Epsilon)
		{
			return;
		}
		if (MissionsManager.onMissionComplete != null)
		{
			int num11 = MissionsManager.ApplyCoinDoublers((int)this);
			object obj12 = num11 + 16;
			object obj13 = (object)instance << 3;
			object obj14 = obj12 + obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ S0_v168+4]");
			bool flag2 = (nint)0 == 1;
			bool inRun = ((MissionsManager)(object)this).inRun;
			object obj15 = (inRun ? 1 : 0) + 16;
			object obj16 = instance * 24;
			object obj17 = obj15 + obj16;
			string key;
			if (flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ S1_v113+C]");
				key = (string)0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ S1_v113+8]");
				key = (string)0;
			}
			nint num12 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ S1_v115 (Il2CppClass<Strings>)+BA]");
			object obj18 = (nint)0 & (nint)0x200;
			if (obj18 != null)
			{
				nint num13 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ S1_v127 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string format = Strings.GetDefault(key);
			int num14 = MissionsManager.ApplyCoinDoublers((int)this);
			object obj19 = num14 + 16;
			object obj20 = (object)instance << 3;
			object obj21 = obj19 + obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ S1_v123+4]");
			obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			object[] args = default;
			string text = string.Format(format, args);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A74");
		}
		((NewMonoBehaviour)13)._002Ector();
		bool hasSkippedMissionForVideoThisSet = PlayerSave.hasSkippedMissionForVideoThisSet;
		if ((hasSkippedMissionForVideoThisSet ? 1 : 0) == (nint)instance)
		{
			((MissionsManager)(object)this).LogMissionSetRuns();
		}
		int num15 = 0;
		object obj22 = 0;
		object obj23;
		while (true)
		{
			bool flag3 = num15 > 2;
			obj23 = 1;
			if (flag3)
			{
				break;
			}
			int achievementProgress = PlayerSave.GetAchievementProgress(num15);
			int num16 = MissionsManager.ApplyCoinDoublers((int)this);
			object obj24 = num16 + 16;
			int num17 = num15 << 3;
			object obj25 = obj24 + num17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ S1_v94+4]");
			if ((nint)achievementProgress >= (nint)0)
			{
				object obj26 = obj22 + 1;
				obj22 = obj26;
			}
			int num18 = MissionsManager.ApplyCoinDoublers((int)this);
			object obj27 = num18 + 16;
			int num19 = num15 << 3;
			object obj28 = obj27 + num19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ S1_v100+4]");
			if ((nint)achievementProgress < (nint)0)
			{
				obj23 = 0;
				break;
			}
			int num20 = num15 + 1;
			num15 = num20;
		}
		if ((nint)obj22 >= 2 && _prefabPoolGroups != null)
		{
			nint num21 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ S1_v80 (Il2CppClass<SocialManager>)+BA]");
			object obj29 = (nint)0 & (nint)0x200;
			if (obj29 != null)
			{
				nint num22 = (nint)typeof(SocialManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ S1_v86 (Il2CppClass<SocialManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool facebookDialogsSupported2 = SocialManager.facebookDialogsSupported;
			CollectCoinsDummy[] defaultDummyList2 = CollectCoinsDummyData.GetDefaultDummyList();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ S2_v36 (CollectCoinsDummy[])+8]");
			object camera2 = (nint)0 + (nint)160;
			((UIScreenController)facebookDialogsSupported2).SetViewportRectXForCamera((Camera)camera2, 100f);
		}
		if (obj23 == null)
		{
			return;
		}
		int missionsVersion = PlayerSave.missionsVersion;
		object obj30 = missionsVersion + 1;
		obj = obj30;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		nint num23 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ S0_v46 (Il2CppClass<Flurry>)+BA]");
		object obj31 = (nint)0 & (nint)0x200;
		if (obj31 != null)
		{
			nint num24 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ S0_v149 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((OwnBoardsAward)(object)this)._002Ector((AwardStaticData)58, (PersistentAwardProgress)1, (Action<Award>)(-1));
		if (_prefabPoolGroups != null)
		{
			object obj32 = 0;
			while ((nint)obj32 <= 2)
			{
				object obj33 = _prefabPoolGroups + 16;
				object obj34 = obj32 << 2;
				object obj35 = obj33 + obj34;
				obj35 = 0;
				object obj36 = obj32 + 1;
				obj32 = obj36;
			}
		}
		int currentSkipForVideoMissionIndex = PlayerSave.currentSkipForVideoMissionIndex;
		object obj37 = currentSkipForVideoMissionIndex + 1;
		AdLocationInfo currentLocationInfo = MissionsManager.GetCurrentLocationInfo((byte)(int)this != 0);
		if (obj37 == currentLocationInfo)
		{
			OnboardingSave.lastShownTopRunIntroPopupVersionNumber = 1;
		}
		int currentSkipForVideoMissionIndex2 = PlayerSave.currentSkipForVideoMissionIndex;
		object obj38 = currentSkipForVideoMissionIndex2 + 1;
		AdLocationInfo currentLocationInfo2 = MissionsManager.GetCurrentLocationInfo((byte)(int)this != 0);
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj38) > System.Runtime.CompilerServices.Unsafe.As<AdLocationInfo, UIntPtr>(ref currentLocationInfo2))
		{
			nint num25 = (nint)typeof(AnalyticsHelper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ S0_v94 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsHelper>)+BA]");
			object obj39 = (nint)0 & (nint)0x200;
			if (obj39 != null)
			{
				nint num26 = (nint)typeof(AnalyticsHelper);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v504 @ S0_v134 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsHelper>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string newUserId = AnalyticsIntegration.GetNewUserId();
			nint num27 = (nint)typeof(RewardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ S0_v101 (Il2CppClass<RewardManager>)+BA]");
			object obj40 = (nint)0 & (nint)0x200;
			if (obj40 != null)
			{
				nint num28 = (nint)typeof(RewardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v527 @ S0_v130 (Il2CppClass<RewardManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector3 vector = ((SSEventsPopup)10).VerifySettingOnline("MissionSet", (Vector3)newUserId);
			if (_prefabPoolGroups == null)
			{
				nint num29 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v560 @ S0_v110 (Il2CppClass<UIScreenController>)+BA]");
				object obj41 = (nint)0 & (nint)0x200;
				if (obj41 != null)
				{
					nint num30 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v578 @ S0_v127 (Il2CppClass<UIScreenController>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag4 = UIScreenController.ShouldShowOnlineScreen();
				string topScreenName = ((UIScreenController)flag4).GetTopScreenName();
				if (topScreenName == null)
				{
					nint num31 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v602 @ S0_v118 (Il2CppClass<UIScreenController>)+BA]");
					object obj42 = (nint)0 & (nint)0x200;
					if (obj42 != null)
					{
						nint num32 = (nint)typeof(UIScreenController);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v619 @ S0_v124 (Il2CppClass<UIScreenController>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool flag5 = UIScreenController.ShouldShowOnlineScreen();
					((UIScreenController)flag5).ClosePopup();
				}
			}
		}
		int currentSkipForVideoMissionIndex3 = PlayerSave.currentSkipForVideoMissionIndex;
		int missionSetStoryCount = ((MissionsManager)(object)this).missionSetStoryCount;
		object obj43 = missionSetStoryCount - 1;
		bool flag6 = currentSkipForVideoMissionIndex3 < (nint)obj43;
		int currentSkipForVideoMissionIndex4 = PlayerSave.currentSkipForVideoMissionIndex;
		bool flag7 = !flag6;
		bool flag8 = !flag7;
		int num33 = currentSkipForVideoMissionIndex4;
		if (!flag8)
		{
			nint num34 = (nint)typeof(MissionsData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ S0_v81 (Il2CppClass<Missions.MissionsData>)+BA]");
			object obj44 = (nint)0 & (nint)0x200;
			if (obj44 != null)
			{
				nint num35 = (nint)typeof(MissionsData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ S0_v87 (Il2CppClass<Missions.MissionsData>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Mission[][] repeatableMissions = MissionsData.repeatableMissions;
			int num36 = currentSkipForVideoMissionIndex4 - repeatableMissions.Length;
			num33 = num36;
		}
		int missionsVersion2 = PlayerSave.missionsVersion;
		int missionsVersion3 = missionsVersion2 + 1;
		PlayerSave.missionsVersion = missionsVersion3;
		MissionTarget missionTarget = (MissionTarget)(num33 + 1);
		int missionSetStoryCount2 = ((MissionsManager)(object)this).missionSetStoryCount;
		int value2;
		if ((int)missionTarget < missionSetStoryCount2)
		{
			int numberOfBasicMission = ((MissionsManager)(object)this).GetNumberOfBasicMission();
			object obj45 = numberOfBasicMission + 16;
			object obj46 = (int)missionTarget << 2;
			object obj47 = obj45 + obj46;
			object obj48 = obj47;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v612 @ S2_v28+C]");
			value2 = 0;
		}
		else
		{
			value2 = 0;
		}
		((MissionsManager)(object)this).PlayerDidThis(missionTarget, value2, 1);
		if (MissionsManager.onMissionSetComplete != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
		}
		((OwnBoardsAward)(object)this)._002Ector((AwardStaticData)39, (PersistentAwardProgress)1, (Action<Award>)(-1));
	}

	private IEnumerator DoDespawnAfterSeconds(Transform instance, float seconds)
	{
		//IL_0099: Expected I, but got Obj
		//IL_00af: Expected Obj, but got I
		//IL_00d6: Expected Obj, but got VT
		//IL_00ed: Expected Obj, but got VT
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected Obj, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected Obj, but got Unknown
		//IL_0154: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0077: Expected Obj, but got I4
		_0021_00210 componentInChildren = (_0021_00210)((GameObject)(object)this).GetComponentInChildren<T>();
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v11 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v35 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = (UnityEngine.Object)componentInChildren != null;
		bool flag2 = !flag;
		SpringPosition springPosition = (SpringPosition)componentInChildren;
		if (!flag2)
		{
			SpringPosition springPosition2 = ((GameObject)(object)this).AddComponent<SpringPosition>();
			springPosition = springPosition2;
		}
		_ = ((UnityEngine.Object)instance).m_CachedPtr;
		object obj2 = springPosition + 12;
		obj2 = instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		springPosition.strength = seconds;
		object obj3 = springPosition + 32;
		obj3 = 0;
		if (!springPosition.isActiveAndEnabled)
		{
			springPosition.tag = (string)1;
		}
		return (IEnumerator)springPosition;
	}

	public void DespawnAll()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Expected Obj, but got Unknown
		//IL_024b: Expected Obj, but got I4
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Expected Obj, but got Unknown
		//IL_027b: Expected I, but got Obj
		//IL_0291: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected Obj, but got Unknown
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected Obj, but got Unknown
		//IL_0102: Expected Obj, but got I4
		//IL_018a: Expected Obj, but got I
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected Obj, but got Unknown
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		nint num = (nint)typeof(PoolManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(PoolManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v89 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		InstanceHandler.DestroyInstance((GameObject)(object)this);
		MonoBehaviour.print(this);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj6 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj6 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		}
		object obj7 = obj4 + 4;
		object obj8 = obj7 + 1;
		obj7 = obj8;
		object obj9 = obj8 << 2;
		object obj10 = obj4 + obj9;
		obj10 = 63;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj11 = (nint)0 << 2;
			object obj12 = obj4 + obj11;
			if ((nint)obj12 == 63)
			{
				object obj13 = obj4 + 4;
				if ((nint)obj13 > -1)
				{
					object obj14 = obj13 + -1;
					obj13 = obj14;
				}
				goto IL_0302;
			}
		}
		object obj15 = default;
		if (obj15 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0302;
		IL_0302:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB86");
		prefabs.Clear();
	}

	public bool IsSpawned(Transform instance)
	{
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected Obj, but got Unknown
		//IL_0178: Expected I, but got Obj
		//IL_018e: Expected Obj, but got I
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected Obj, but got Unknown
		//IL_0114: Expected Obj, but got I
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected Obj, but got Unknown
		//IL_014e: Expected I4, but got Obj
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
		return (byte)(int)((MinimalHTTPPost)(object)this).WaitForWWWRequest((string)(object)instance, dictionary, array, (Action<int, string, string>)null) != 0;
	}

	public PrefabPool GetPrefabPool(Transform prefab)
	{
		//IL_0091: Expected I, but got Obj
		//IL_00a7: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0074: Expected Obj, but got I4
		nint num = (nint)typeof(PoolManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(PoolManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v17 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Transform transform = PoolManager.Spawn(prefab);
		if ((object)transform != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v11 (UnityEngine.Transform)+C]");
			bool flag = (nint)0 != 0;
			return (PrefabPool)flag;
		}
		return null;
	}

	public PrefabPool GetPrefabPool(GameObject prefab)
	{
		//IL_016d: Expected I, but got Obj
		//IL_0183: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_01b5: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(PoolManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(PoolManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v33 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = ((SpawnPoolsDict)(object)prefab).ToString();
		if (text != null)
		{
			nint num3 = (nint)typeof(PoolManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v23 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(PoolManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v29 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = PoolManager.PrefabPoolExists((Transform)(object)prefab);
			return (PrefabPool)flag;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		PrefabPool prefabPool = default;
		prefabPool.nameInstance((Transform)(object)prefab);
		Add((Transform)(object)prefabPool);
		List<PrefabPoolGroup> prefabPoolGroups = _prefabPoolGroups;
		int index = prefabPoolGroups._size - 1;
		PrefabPoolGroup prefabPoolGroup = _prefabPoolGroups.get_Item(index);
		prefabPoolGroup.prefabPools.Add(prefabPool);
		return prefabPool;
	}

	public Transform GetPrefab(Transform instance)
	{
		//IL_0017: Expected Obj, but got I4
		int layer = ((GameObject)(object)instance).layer;
		return (Transform)(object)GetPrefabPool((GameObject)layer);
	}

	public GameObject GetPrefab(GameObject instance)
	{
		//IL_008f: Expected I, but got Obj
		//IL_00a5: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0062: Expected Obj, but got I
		//IL_0072: Expected Obj, but got I
		nint num = (nint)typeof(PoolManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(PoolManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v17 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Transform transform = PoolManager.Spawn((Transform)(object)instance);
		if ((object)transform != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v11 (UnityEngine.Transform)+18]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+8]");
			return (GameObject)0;
		}
		return null;
	}

	private IEnumerator ListForAudioStop(AudioSource src)
	{
		//IL_00a9: Expected I, but got Obj
		//IL_00bf: Expected Obj, but got I
		//IL_00e5: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0062: Expected Obj, but got I
		//IL_0073: Expected Obj, but got I
		int layer = ((GameObject)(object)src).layer;
		nint num = (nint)typeof(PoolManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S1_v4 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(PoolManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v11 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Transform transform = PoolManager.Spawn((Transform)layer);
		if ((object)transform != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v7 (UnityEngine.Transform)+18]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v11+8]");
			return (IEnumerator)(object)((Component)0).tag;
		}
		return null;
	}

	public override string ToString()
	{
		//IL_0021: Expected Obj, but got I4
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected Obj, but got Unknown
		//IL_0062: Expected Obj, but got I4
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected Obj, but got Unknown
		//IL_009e: Expected Obj, but got I4
		//IL_00da: Expected Obj, but got I4
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected Obj, but got Unknown
		string text = null;
		Transform transform = default;
		Transform transform6 = default;
		while (true)
		{
			LinkedList<PooledInstanceData> spawned = ((PrefabPool)(object)this).spawned;
			if (System.Runtime.CompilerServices.Unsafe.As<Transform, UIntPtr>(ref transform) >= System.Runtime.CompilerServices.Unsafe.As<LinkedList<PooledInstanceData>, UIntPtr>(ref spawned))
			{
				break;
			}
			bool flag = ((ICollection<Transform>)this).Remove(transform);
			Transform transform2 = ((PrefabPool)flag).SpawnNew();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v7 (System.Boolean)+10]");
			if ((nint)transform2 < 0)
			{
				Transform transform3 = ((PrefabPool)flag).SpawnNew();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v7 (System.Boolean)+10]");
				object obj = 0 - transform3;
				string text2 = obj + text;
				text = text2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v7 (System.Boolean)+1D]");
			if ((nint)0 != 0)
			{
				Transform transform4 = ((PrefabPool)flag).SpawnNew();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v7 (System.Boolean)+20]");
				if ((nint)transform4 > 0)
				{
					Transform transform5 = ((PrefabPool)flag).SpawnNew();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v7 (System.Boolean)+20]");
					object obj2 = transform5 - 0;
					string text3 = obj2 + text;
					text = text3;
				}
			}
			transform = (Transform)(transform6 + 1);
		}
		return text;
	}

	public bool Contains(Transform item)
	{
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Expected Obj, but got Unknown
		//IL_0193: Expected I4, but got Obj
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected Obj, but got Unknown
		int num = 0;
		Transform transform = default;
		LinkedList<PooledInstanceData> linkedList = default;
		InvalidCastException ex = default;
		while (true)
		{
			List<PrefabPool> prefabPools = _prefabPools;
			if (num < prefabPools._size)
			{
				PrefabPool prefabPool = _prefabPools.get_Item(num);
				LinkedList<PooledInstanceData> despawned = prefabPool.despawned;
				bool flag = (nint)transform < despawned.count;
				LinkedList<PooledInstanceData> despawned2 = prefabPool.despawned;
				if (!flag)
				{
					Transform transform2 = (Transform)(transform - despawned2.count);
					int num2 = num + 1;
					num = num2;
					transform = transform2;
					linkedList = despawned2;
					continue;
				}
				linkedList = despawned2;
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			ex._002Ector();
			((SpawnPool)(object)ex).get_Item(0);
			break;
		}
		LinkedListNode<PooledInstanceData> linkedListNode = linkedList.head;
		while (true)
		{
			Transform transform3 = (Transform)(transform - 1);
			if ((nint)transform < 1)
			{
				break;
			}
			LinkedListNode<PooledInstanceData> linkedListNode2;
			if (linkedListNode.next != null)
			{
				LinkedList<PooledInstanceData> list = linkedListNode.list;
				linkedListNode2 = ((linkedListNode.next != list.head) ? linkedListNode.next : null);
			}
			else
			{
				linkedListNode2 = null;
			}
			linkedListNode = linkedListNode2;
			transform = transform3;
		}
		PooledInstanceData item2 = linkedListNode.item;
		return (byte)(int)item2.transform__BackingField != 0;
	}

	public void CopyTo(Transform[] array, int arrayIndex)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		NotSupportedException ex = default;
		ex._002Ector("Read-only.");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
	}

	public IEnumerator<Transform> GetEnumerator()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected Obj, but got Unknown
		int num = 0;
		IEnumerator<Transform> result = default;
		IEnumerator<Transform> enumerator = default;
		while (true)
		{
			List<PrefabPool> prefabPools = _prefabPools;
			if (num >= prefabPools._size)
			{
				break;
			}
			PrefabPool prefabPool = _prefabPools.get_Item(num);
			LinkedList<PooledInstanceData> despawned = prefabPool.despawned;
			result = (IEnumerator<Transform>)(despawned.count + enumerator);
			int num2 = num + 1;
			num = num2;
		}
		return result;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 16;
		obj = this;
		return enumerator;
	}

	public int IndexOf(Transform item)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		NotSupportedException ex = default;
		ex._002Ector("Use IsSpawned(Transform instance) instead.");
		((SpawnPool)(object)ex).Contains((Transform)null);
		return 0;
	}

	public void Insert(int index, Transform item)
	{
		int num = default;
		int num2 = default;
		while (true)
		{
			List<PrefabPool> prefabPools = _prefabPools;
			if (num < prefabPools._size)
			{
				PrefabPool prefabPool = _prefabPools.get_Item(num);
				LinkedList<PooledInstanceData> despawned = prefabPool.despawned;
				LinkedListNode<PooledInstanceData> head = despawned.head;
				if (head != null)
				{
					PooledInstanceData item2 = head.item;
					throw new ArrayTypeMismatchException();
				}
				num = num2 + 1;
				continue;
			}
			break;
		}
	}

	public void RemoveAt(int index)
	{
		//IL_01c4: Expected I, but got Obj
		//IL_01da: Expected Obj, but got I
		//IL_027f: Expected Obj, but got I4
		//IL_0136: Expected I, but got Obj
		//IL_014c: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_024a: Expected Obj, but got I4
		//IL_0271: Expected Obj, but got I4
		//IL_0177: Expected I, but got Obj
		//IL_00a3: Expected I, but got Obj
		//IL_00b9: Expected Obj, but got I
		//IL_020b: Expected Obj, but got I4
		//IL_0232: Expected Obj, but got I4
		//IL_008c: Expected Obj, but got I4
		//IL_008c: Expected Obj, but got I
		//IL_00e4: Expected I, but got Obj
		nint num = (nint)typeof(PoolManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(PoolManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v46 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Transform transform = PoolManager.Spawn((Transform)index);
		if ((object)transform != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v11 (UnityEngine.Transform)+C]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v11 (UnityEngine.Transform)+18]");
				bool flag = ((PrefabPool)0).Contains((Transform)index);
				return;
			}
			nint num3 = (nint)typeof(Log);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v30 (Il2CppClass<SYBO.Components.Logging.Log>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(Log);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v37 (Il2CppClass<SYBO.Components.Logging.Log>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string context = tag;
			UnityEngine.Object arg = UnityEngine.Object.Instantiate((UnityEngine.Object)index);
			Log.PoolManager.LogErrorFormat((UnityEngine.Object)(object)context, (Enum)logLevelAdjust, "SpawnPool {0}: {1} has already been despawned. You cannot despawn something more than once!", poolName, arg);
			return;
		}
		nint num5 = (nint)typeof(Log);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v14 (Il2CppClass<SYBO.Components.Logging.Log>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(Log);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v21 (Il2CppClass<SYBO.Components.Logging.Log>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string context2 = tag;
		UnityEngine.Object arg2 = UnityEngine.Object.Instantiate((UnityEngine.Object)index);
		Log.PoolManager.LogErrorFormat((UnityEngine.Object)(object)context2, (Enum)logLevelAdjust, "SpawnPool {0}: {1} not found in SpawnPool", poolName, arg2);
	}

	public void Clear()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected Obj, but got Unknown
		//IL_01e7: Expected Obj, but got I4
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected Obj, but got Unknown
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Expected Obj, but got Unknown
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Expected Obj, but got Unknown
		//IL_0275: Expected Obj, but got I4
		//IL_0126: Expected Obj, but got I
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected Obj, but got Unknown
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj5 = default;
		object obj6 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj5 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj6 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
					continue;
				}
				break;
			}
		}
		object obj7 = obj4 + 4;
		object obj8 = obj7 + 1;
		obj7 = obj8;
		object obj9 = obj8 << 2;
		object obj10 = obj4 + obj9;
		obj10 = 89;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj11 = (nint)0 << 2;
			object obj12 = obj4 + obj11;
			if ((nint)obj12 == 89)
			{
				object obj13 = obj4 + 4;
				if ((nint)obj13 > -1)
				{
					object obj14 = obj13 + -1;
					obj13 = obj14;
				}
				return;
			}
		}
		object obj15 = default;
		if (obj15 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	public PrefabPool GetPrefabPool(int idx)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		NotSupportedException ex = default;
		ex._002Ector();
		((SpawnPool)(object)ex).IndexOf((Transform)null);
		return null;
	}

	bool ICollection<Transform>.Remove(Transform item)
	{
		//IL_0014: Expected I4, but got Obj
		//IL_0018: Expected I4, but got Obj
		return (byte)(int)_prefabPools.get_Item((int)item) != 0;
	}

	public SpawnPool()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		NotSupportedException ex = default;
		ex._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
	}
}
