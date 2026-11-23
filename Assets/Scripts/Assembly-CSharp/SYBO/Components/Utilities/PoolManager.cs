using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Components.Utilities;

public static class PoolManager
{
	private class PoolPriority
	{
		public int Priority;

		public bool IsSpawnPriority;

		public SpawnPool Pool;
	}

	private class PoolPriorityComparer : IComparer<PoolPriority>
	{
		public int Compare(PoolPriority x, PoolPriority y)
		{
			return x.Priority - y.Priority;
		}
	}

	private sealed class _003CPoolBalancing_003Ed__27(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		private Action<float> _003CthisProgress_003E5__2;

		private float _003CtotalBalanceOperations_003E5__3;

		private float _003CbalanceOperation_003E5__4;

		private int _003Ci_003E5__5;

		private PoolPriority _003Cpriority_003E5__6;

		private int _003Cj_003E5__7;

		private PrefabPool _003CprefabPool_003E5__8;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0076: Expected I4, but got I8
			//IL_0188: Expected Obj, but got I4
			//IL_08ef: Expected Obj, but got I
			//IL_00e5: Expected I4, but got F4
			//IL_0821: Expected I, but got Obj
			//IL_017a: Expected Obj, but got I4
			//IL_048f: Expected Obj, but got I4
			//IL_00ff: Expected Obj, but got I4
			//IL_0152: Expected I4, but got F4
			//IL_016c: Expected Obj, but got I4
			//IL_04cd: Expected I4, but got F4
			//IL_057a: Expected Obj, but got I4
			//IL_04ed: Expected Obj, but got I4
			//IL_0557: Expected F4, but got I4
			//IL_0730: Expected Obj, but got I4
			//IL_0588: Expected F4, but got I4
			//IL_0591: Expected Obj, but got I4
			//IL_06e8: Expected I4, but got F4
			//IL_0781: Expected I, but got Obj
			//IL_078b: Expected Obj, but got I4
			//IL_0607: Expected I4, but got F4
			//IL_0619: Expected Obj, but got I4
			//IL_0634: Invalid comparison between F4 and I4
			//IL_09a4: Expected Obj, but got I4
			//IL_0795: Expected I, but got Obj
			//IL_079f: Expected Obj, but got I4
			//IL_07a9: Expected I, but got Obj
			//IL_07b3: Expected Obj, but got I4
			object obj;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					if (_003C_003E1__state != 2)
					{
						if (_003C_003E1__state != 3)
						{
							goto IL_07d7;
						}
						_003C_003E1__state = -1;
						StartClock();
						PoolPriority poolPriority = _003Cpriority_003E5__6;
						SpawnPool pool = poolPriority.Pool;
						float num = (float)pool.logLevelAdjust + 1f;
						pool.logLevelAdjust = (int)num;
						if (_forceRestartBalancing)
						{
							goto IL_0171;
						}
						obj = 1;
					}
					else
					{
						_003C_003E1__state = -1;
						StartClock();
						PoolPriority poolPriority2 = _003Cpriority_003E5__6;
						SpawnPool pool2 = poolPriority2.Pool;
						float num2 = (float)pool2.logLevelAdjust + 1f;
						pool2.logLevelAdjust = (int)num2;
						if (_forceRestartBalancing)
						{
							goto IL_0171;
						}
						obj = 0;
					}
				}
				else
				{
					_003C_003E1__state = -1;
					obj = 3;
				}
				goto IL_07dd;
			}
			_003C_003E1__state = -1;
			_003C_003E1__state = 1;
			return true;
			IL_0171:
			obj = 2;
			goto IL_07dd;
			IL_07d7:
			return false;
			IL_07dd:
			object obj2 = obj;
			nint num3 = default;
			float num6 = default;
			while (true)
			{
				bool flag = obj2 == null;
				_003CPoolBalancing_003Ed__27 obj3 = (_003CPoolBalancing_003Ed__27)num3;
				if (!flag)
				{
					if ((nint)obj2 != 1)
					{
						object obj4;
						if ((nint)obj2 == 2)
						{
							PoolPriority poolPriority3 = _003Cpriority_003E5__6;
							SpawnPool pool3 = poolPriority3.Pool;
							float num4 = (float)pool3.logLevelAdjust - 1f;
							pool3.logLevelAdjust = (int)num4;
							if (!_forceRestartBalancing)
							{
								_003CprefabPool_003E5__8 = null;
								obj4 = 0;
							}
							else
							{
								obj4 = 1;
							}
						}
						else
						{
							if (~(_restartBalancing ? 1u : 0u) != 0)
							{
								break;
							}
							_restartBalancing = false;
							_forceRestartBalancing = false;
							_003CthisProgress_003E5__2 = _onProgress;
							_onProgress = null;
							StartClock();
							int num5 = UpdatePriorityList();
							_003CbalanceOperation_003E5__4 = 0f;
							_003CtotalBalanceOperations_003E5__3 = num5;
							num6 = 0f;
							obj4 = 2;
						}
						object obj5 = obj4;
						while (true)
						{
							int num8;
							if (obj5 != null)
							{
								if ((nint)obj5 == 1)
								{
									if (!_forceRestartBalancing)
									{
										_003Cpriority_003E5__6 = null;
										float num7 = (float)_003Ci_003E5__5 + 1f;
										_003Ci_003E5__5 = (int)num7;
										num6 = num7;
										obj5 = 2;
										continue;
									}
								}
								else
								{
									List<PoolPriority> priorities = _priorities;
									if (num6 < (float)priorities._size)
									{
										PoolPriority poolPriority4 = _priorities.get_Item(_003Ci_003E5__5);
										_003Cpriority_003E5__6 = poolPriority4;
										num3 = 0;
										num8 = 0;
										goto IL_090a;
									}
								}
								Action<float> action = _003CthisProgress_003E5__2;
								if (_003CthisProgress_003E5__2 == null)
								{
									action = action;
								}
								if (_003CthisProgress_003E5__2 != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ S0_v142 (System.Action`1<System.Single>)+C]");
									num3 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v460 @ S0_v142 (System.Action`1<System.Single>)+C] (should have been resolved before IL gen)");
								}
								_003CthisProgress_003E5__2 = null;
								obj2 = 3;
								break;
							}
							int num9 = _003Cj_003E5__7 + 1;
							num8 = num9;
							goto IL_090a;
							IL_090a:
							_003Cj_003E5__7 = num8;
							PoolPriority poolPriority5 = _003Cpriority_003E5__6;
							int prefabPoolCount = poolPriority5.Pool.PrefabPoolCount;
							if (prefabPoolCount > num8)
							{
								PoolPriority poolPriority6 = _003Cpriority_003E5__6;
								PrefabPool prefabPool = poolPriority6.Pool.GetPrefabPool(_003Cj_003E5__7);
								_003CprefabPool_003E5__8 = prefabPool;
								PoolPriority poolPriority7 = _003Cpriority_003E5__6;
								SpawnPool pool4 = poolPriority7.Pool;
								float num10 = (float)pool4.logLevelAdjust + 1f;
								pool4.logLevelAdjust = (int)num10;
								PoolPriority poolPriority8 = _003Cpriority_003E5__6;
								if (poolPriority8.IsSpawnPriority)
								{
									num3 = (nint)this;
									obj2 = 0;
									break;
								}
								PrefabPool prefabPool2 = _003CprefabPool_003E5__8;
								if (prefabPool2.cullDespawned)
								{
									num3 = (nint)this;
									obj2 = 1;
									break;
								}
								num3 = (nint)this;
								obj5 = 0;
							}
							else
							{
								obj5 = 1;
							}
						}
						continue;
					}
					while (true)
					{
						int totalCount = _003CprefabPool_003E5__8.totalCount;
						PrefabPool prefabPool3 = _003CprefabPool_003E5__8;
						if (totalCount <= prefabPool3.cullAbove)
						{
							break;
						}
						LinkedList<PooledInstanceData> despawned = prefabPool3._despawned;
						if (despawned.count == 0)
						{
							_restartBalancing = true;
							break;
						}
						PrefabPool prefabPool4 = _003CprefabPool_003E5__8;
						LinkedList<PooledInstanceData> despawned2 = prefabPool4._despawned;
						LinkedListNode<PooledInstanceData> head = despawned2.head;
						LinkedListNode<PooledInstanceData> linkedListNode = ((despawned2.head == null) ? null : head.prev);
						PooledInstanceData item = linkedListNode.item;
						PrefabPool prefabPool5 = _003CprefabPool_003E5__8;
						prefabPool5._despawned.Remove(linkedListNode);
						UnregisterInstance(linkedListNode.item);
						PrefabPool prefabPool6 = _003CprefabPool_003E5__8;
						GameObject gameObject = item.transform__BackingField.gameObject;
						prefabPool6.spawnPool.DestroyInstance(gameObject);
						float num11 = _003CbalanceOperation_003E5__4 + 1f;
						_003CbalanceOperation_003E5__4 = num11;
						long elapsedMilliseconds = _sw.ElapsedMilliseconds;
						if (elapsedMilliseconds >= BalancingBudgetMS)
						{
							PoolPriority poolPriority9 = _003Cpriority_003E5__6;
							SpawnPool pool5 = poolPriority9.Pool;
							int logLevelAdjust = pool5.logLevelAdjust - 1;
							pool5.logLevelAdjust = logLevelAdjust;
							StopClock();
							Action<float> action2 = _003CthisProgress_003E5__2;
							if (_003CthisProgress_003E5__2 != null)
							{
								float num12 = _003CbalanceOperation_003E5__4 / _003CtotalBalanceOperations_003E5__3;
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v516 @ S0_v97 (System.Action`1<System.Single>)+C] (should have been resolved before IL gen)");
							}
							_003C_003E2__current = null;
							_003C_003E1__state = 3;
							return true;
						}
					}
				}
				else
				{
					while (true)
					{
						int totalCount2 = _003CprefabPool_003E5__8.totalCount;
						PrefabPool prefabPool7 = _003CprefabPool_003E5__8;
						bool flag2 = totalCount2 >= prefabPool7.preloadAmount;
						num3 = (nint)obj3;
						if (flag2)
						{
							break;
						}
						Transform xform = prefabPool7.SpawnNew();
						bool flag3 = _003CprefabPool_003E5__8.DespawnInstance(xform, sendEventMessage: false);
						float num13 = _003CbalanceOperation_003E5__4 + 1f;
						_003CbalanceOperation_003E5__4 = num13;
						long elapsedMilliseconds2 = _sw.ElapsedMilliseconds;
						bool flag4 = elapsedMilliseconds2 < BalancingBudgetMS;
						obj3 = this;
						if (!flag4)
						{
							PoolPriority poolPriority10 = _003Cpriority_003E5__6;
							SpawnPool pool6 = poolPriority10.Pool;
							int logLevelAdjust2 = pool6.logLevelAdjust - 1;
							pool6.logLevelAdjust = logLevelAdjust2;
							StopClock();
							Action<float> action3 = _003CthisProgress_003E5__2;
							if (_003CthisProgress_003E5__2 != null)
							{
								float num14 = _003CbalanceOperation_003E5__4 / _003CtotalBalanceOperations_003E5__3;
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v409 @ S0_v39 (System.Action`1<System.Single>)+C] (should have been resolved before IL gen)");
							}
							_003C_003E2__current = null;
							_003C_003E1__state = 2;
							return true;
						}
					}
				}
				obj2 = 2;
			}
			StopClock();
			_balancing = false;
			goto IL_07d7;
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

	public static Action<Transform> OnObjectInstantiated;

	public static readonly SpawnPoolsDict Pools;

	private static bool _balancing;

	private static bool _restartBalancing;

	private static bool _forceRestartBalancing;

	private static Action<float> _onProgress;

	public static int BalancingBudgetMS;

	private static List<PoolPriority> _priorities;

	private static PoolPriorityComparer _comparer;

	private static int _frameCount;

	private static Stopwatch _sw;

	private static Dictionary<Transform, PrefabPool> _prefabPoolLookup;

	private static Dictionary<int, PooledInstanceData> _pooledLookup;

	public static bool Working => _balancing;

	public static void TriggerPoolBalancing(MonoBehaviour coroutineHost = null)
	{
		MonoBehaviour monoBehaviour = default;
		SpawnPool defaultSpawnPool = default;
		if (monoBehaviour == null)
		{
			defaultSpawnPool = GetDefaultSpawnPool();
		}
		_restartBalancing = true;
		if (~(_balancing ? 1u : 0u) != 0)
		{
			_balancing = true;
			IEnumerator routine = PoolBalancing();
			Coroutine coroutine = defaultSpawnPool.StartCoroutine(routine);
		}
	}

	public static void BeginBalancing(Action<float> onProgress)
	{
		_onProgress = onProgress;
		if (onProgress != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [onProgress @ L0 (System.Action`1<System.Single>)+C] (should have been resolved before IL gen)");
		}
		_forceRestartBalancing = true;
		_restartBalancing = true;
		TriggerPoolBalancing();
	}

	public static void StartClock()
	{
		//IL_002a: Expected I8, but got I4
		int frameCount = Time.frameCount;
		if (_frameCount != frameCount)
		{
			Stopwatch sw = _sw;
			sw.is_running = false;
			sw.elapsed = 0L;
			int frameCount2 = Time.frameCount;
			_frameCount = frameCount2;
		}
		_sw.Start();
	}

	public static void StopClock()
	{
		_sw.Stop();
	}

	public static void RegisterInstance(PooledInstanceData instanceData)
	{
		//IL_0039: Expected Obj, but got I
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S5_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Int32, SYBO.Components.Utilities.PooledInstanceData>>)+5C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v31 @ S5_v4+4] (should have been resolved before IL gen)");
		if (OnObjectInstantiated != null)
		{
			Action<Transform> onObjectInstantiated = OnObjectInstantiated;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v57 @ S0_v22 (System.Action`1<UnityEngine.Transform>)+C] (should have been resolved before IL gen)");
		}
	}

	public static void UnregisterInstance(PooledInstanceData instanceData)
	{
		bool flag = _pooledLookup.Remove(instanceData.instanceId__BackingField);
	}

	public unsafe static PooledInstanceData GetInstanceData(Transform instance)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Ref, but got Unknown
		//IL_0020: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		int instanceID = instance.GetInstanceID();
		bool flag = _pooledLookup.TryGetValue(instanceID, out *(PooledInstanceData*)(obj + 12));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
		return (PooledInstanceData)0;
	}

	public unsafe static Transform Spawn(Transform prefab)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected Ref, but got Unknown
		//IL_0036: Expected Obj, but got I
		//IL_0046: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		SpawnPool spawnPool;
		if (!_prefabPoolLookup.TryGetValue(prefab, out *(PrefabPool*)(obj + 12)))
		{
			spawnPool = GetDefaultSpawnPool();
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v22+24]");
			spawnPool = (SpawnPool)0;
		}
		return spawnPool.Spawn(prefab);
	}

	private unsafe static SpawnPool GetDefaultSpawnPool()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Ref, but got Unknown
		//IL_0048: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		if (!Pools.TryGetValue("Default", out *(SpawnPool*)(obj + 12)))
		{
			GameObject gameObject = default;
			gameObject._002Ector("DefaultPool");
			return gameObject.AddComponent<SpawnPool>();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
		return (SpawnPool)0;
	}

	public static void Despawn(Transform instance)
	{
		PooledInstanceData instanceData = GetInstanceData(instance);
		PrefabPool prefabPool = instanceData.pool__BackingField;
		prefabPool.spawnPool.Despawn(instance);
	}

	private static IEnumerator PoolBalancing()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private static int UpdatePriorityList()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected Obj, but got Unknown
		//IL_0550: Unknown result type (might be due to invalid IL or missing references)
		//IL_0555: Expected Obj, but got Unknown
		//IL_016e: Expected Obj, but got I
		//IL_0430: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Expected Obj, but got Unknown
		//IL_0485: Expected Obj, but got I
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Expected I4, but got Unknown
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Expected Obj, but got Unknown
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		_ = 0;
		int count = Pools.Count;
		int num = count << 1;
		if (_priorities == null)
		{
			List<PoolPriority> list = default;
			list._002Ector(num);
			_priorities = list;
			PoolPriorityComparer comparer = default;
			_comparer = comparer;
		}
		List<PoolPriority> priorities2;
		PoolPriority item = default;
		while (true)
		{
			List<PoolPriority> priorities = _priorities;
			priorities2 = _priorities;
			if (num <= priorities._size)
			{
				break;
			}
			priorities2.Add(item);
		}
		if (num < priorities2._size)
		{
			throw new IndexOutOfRangeException();
		}
		IEnumerator<KeyValuePair<string, SpawnPool>> enumerator = Pools.GetEnumerator();
		object obj3 = obj + 28;
		obj = obj3;
		_ = 0;
		int num2 = 0;
		object obj4 = default;
		object obj5;
		object obj7 = default;
		object obj9 = default;
		object obj10 = default;
		object obj11 = default;
		object obj13 = default;
		object obj14 = default;
		int result = default;
		while (true)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				bool flag = obj4 == null;
				obj5 = obj;
				if (flag)
				{
					break;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+14]");
					object obj6 = 0;
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
							int num3 = obj7 + num2;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							bool flag2 = (nint)0 == 1;
							num2 = num3;
							if (!flag2)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									_ = 1;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+14]");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ S0_v116+C]");
									_ = 0;
									object obj8 = obj9 + 1;
									obj9 = obj8 + 1;
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+14]");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ S0_v116+10]");
										_ = 0;
										num2 = num3;
										continue;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									num2 = num3;
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									num2 = num3;
								}
								goto IL_035e;
							}
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
			}
			goto IL_035e;
			IL_035e:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag3 = obj10 == obj11;
			bool flag4 = !flag3;
			object obj12 = obj13;
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag5 = (nint)0 != 1;
				obj5 = obj;
				if (flag5)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj12 = obj14;
			}
			_ = 0;
			object obj15 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				obj5 = 0;
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			return result;
		}
		object obj16 = obj5 + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @245");
		_priorities.Sort(_comparer);
		return num2;
	}

	public static void AddPool(PrefabPool prefabPool)
	{
		//IL_0021: Expected Obj, but got I
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S5_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<UnityEngine.Transform, SYBO.Components.Utilities.PrefabPool>>)+5C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v31 @ S5_v4+4] (should have been resolved before IL gen)");
	}

	public unsafe static PrefabPool GetPrefabPool(Transform prefab)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Ref, but got Unknown
		//IL_0047: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		if (!_prefabPoolLookup.TryGetValue(prefab, out *(PrefabPool*)(obj + 12)))
		{
			SpawnPool defaultSpawnPool = GetDefaultSpawnPool();
			return defaultSpawnPool.GetPrefabPool(prefab);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
		return (PrefabPool)0;
	}

	public static bool PrefabPoolExists(Transform prefab)
	{
		//IL_0021: Expected Obj, but got I
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_0047: Expected I4, but got Obj
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<UnityEngine.Transform, SYBO.Components.Utilities.PrefabPool>>)+54]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v28 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj3 = default;
		object obj2 = obj3 ^ -1;
		return (byte)(obj2 >> 31) != 0;
	}

	public static void Remove(SpawnPool spawnPool)
	{
		int num = 0;
		while (true)
		{
			int prefabPoolCount = spawnPool.PrefabPoolCount;
			if (prefabPoolCount <= num)
			{
				break;
			}
			PrefabPool prefabPool = spawnPool.GetPrefabPool(num);
			bool flag = _prefabPoolLookup.Remove(prefabPool.prefab);
			int num2 = num + 1;
			num = num2;
		}
		bool flag2 = Pools.Remove(spawnPool);
	}

	static PoolManager()
	{
		SpawnPoolsDict spawnPoolsDict = default;
		spawnPoolsDict._002Ector();
		Pools = spawnPoolsDict;
		BalancingBudgetMS = 5;
		Stopwatch sw = default;
		_sw = sw;
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v56 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<UnityEngine.Transform, SYBO.Components.Utilities.PrefabPool>>>)+4] (should have been resolved before IL gen)");
		Dictionary<Transform, PrefabPool> prefabPoolLookup = default;
		_prefabPoolLookup = prefabPoolLookup;
		nint num3 = 0;
		nint num4 = 0;
		IntPtr intPtr2 = num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v82 @ S4_v9 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Int32, SYBO.Components.Utilities.PooledInstanceData>>>)+4] (should have been resolved before IL gen)");
		Dictionary<int, PooledInstanceData> pooledLookup = default;
		_pooledLookup = pooledLookup;
	}
}
