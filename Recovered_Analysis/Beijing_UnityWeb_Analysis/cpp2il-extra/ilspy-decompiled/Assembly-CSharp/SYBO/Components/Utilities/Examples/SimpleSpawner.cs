using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Components.Native;
using UnityEngine;

namespace SYBO.Components.Utilities.Examples;

public class SimpleSpawner : MonoBehaviour
{
	private sealed class _003CSpawner_003Ed__6(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public SimpleSpawner _003C_003E4__this;

		private int _003Ccount_003E5__2;

		private SpawnPool _003CshapesPool_003E5__3;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0282: Unknown result type (might be due to invalid IL or missing references)
				//IL_0287: Expected Obj, but got Unknown
				//IL_0073: Expected I, but got Obj
				//IL_0089: Expected Obj, but got I
				//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
				//IL_02bb: Expected Obj, but got Unknown
				//IL_02d1: Expected VT, but got I
				//IL_02dd: Expected Obj, but got I4
				//IL_00b4: Expected I, but got Obj
				//IL_01aa: Expected Obj, but got I
				//IL_01b7: Expected Obj, but got I4
				//IL_01d3: Expected Obj, but got I
				//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
				//IL_01e2: Expected Obj, but got Unknown
				//IL_025c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0261: Expected Obj, but got Unknown
				//IL_02f0: Expected Obj, but got I4
				//IL_0175: Unknown result type (might be due to invalid IL or missing references)
				//IL_017a: Expected Obj, but got Unknown
				//IL_0183: Expected Obj, but got I4
				object obj = default;
				Transform transform = (Transform)(obj + 12);
				SimpleSpawner simpleSpawner = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state == 2)
						{
							_003C_003E1__state = -1;
							return null;
						}
						return null;
					}
					_003C_003E1__state = -1;
				}
				else
				{
					_003C_003E1__state = -1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (SYBO.Components.Utilities.Examples.SimpleSpawner)+14]");
					_003Ccount_003E5__2 = 0;
					nint num = (nint)typeof(PoolManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v41 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
					object obj2 = (nint)0 & (nint)0x200;
					if (obj2 != null)
					{
						nint num2 = (nint)typeof(PoolManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v47 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					object obj3 = this + 24;
					SpawnPoolsDict pools = PoolManager.Pools;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (SYBO.Components.Utilities.Examples.SimpleSpawner)+C]");
					bool flag = pools.Remove((KeyValuePair<string, SpawnPool>)0);
					obj3 = flag;
				}
				if (_003Ccount_003E5__2 < 1)
				{
					string[] callstackPrefixes = ((NativeLogCategory)(object)simpleSpawner).GetCallstackPrefixes();
					Coroutine coroutine = simpleSpawner.StartCoroutine_Auto((IEnumerator)(object)callstackPrefixes);
					object obj4 = this + 12;
					obj4 = 0;
					_003C_003E1__state = 2;
				}
				else
				{
					SpawnPool spawnPool = _003CshapesPool_003E5__3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (SYBO.Components.Utilities.Examples.SimpleSpawner)+10]");
					Transform transform2 = spawnPool.Spawn((GameObject)0);
					obj = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (SYBO.Components.Utilities.Examples.SimpleSpawner)+14]");
					object obj5 = (nint)0 + (nint)2;
					object obj6 = obj5 - _003Ccount_003E5__2;
					obj = obj6;
					_ = 0f;
					_ = 0f;
					transform = (Transform)obj;
					Transform transform3 = transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
					Vector3 eulerAngles = transform.eulerAngles;
					int num3 = _003Ccount_003E5__2 - 1;
					_003Ccount_003E5__2 = num3;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (SYBO.Components.Utilities.Examples.SimpleSpawner)+18]");
					_ = 0;
					object obj7 = this + 12;
					object obj8 = default;
					obj7 = obj8;
					_003C_003E1__state = 1;
				}
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

	private sealed class _003CDespawner_003Ed__7(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public SimpleSpawner _003C_003E4__this;

		private SpawnPool _003CshapesPool_003E5__2;

		private List<Transform>.Enumerator _003C_003E7__wrap2;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0009: Unknown result type (might be due to invalid IL or missing references)
				//IL_000e: Expected Obj, but got Unknown
				//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
				//IL_03d9: Expected Obj, but got Unknown
				//IL_03e2: Unknown result type (might be due to invalid IL or missing references)
				//IL_03e7: Expected Obj, but got Unknown
				//IL_006f: Expected I, but got Obj
				//IL_0085: Expected Obj, but got I
				//IL_0114: Unknown result type (might be due to invalid IL or missing references)
				//IL_0119: Expected Obj, but got Unknown
				//IL_00b0: Expected I, but got Obj
				//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
				//IL_01d7: Expected Obj, but got Unknown
				//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
				//IL_02ac: Expected Obj, but got Unknown
				//IL_0242: Unknown result type (might be due to invalid IL or missing references)
				//IL_0247: Expected Obj, but got Unknown
				object obj2 = default;
				object obj = obj2 + 48;
				object obj3 = obj2 + 24;
				object obj4 = obj2 + 16;
				obj4 = obj;
				_ = -1;
				SimpleSpawner simpleSpawner = _003C_003E4__this;
				object obj10;
				object obj11 = default;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state == 2)
						{
							_003C_003E1__state = -1;
						}
						goto IL_0480;
					}
					_003C_003E1__state = -3;
					object obj5 = this + 24;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					object obj6 = default;
					if (obj6 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
						object obj7 = this + 24;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
						object obj9 = default;
						object obj8 = obj9;
						obj10 = obj11;
					}
					else
					{
						object obj12 = this + 24;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
						object obj13 = default;
						object obj8 = obj13;
						obj10 = obj11;
					}
				}
				else
				{
					_003C_003E1__state = -1;
					nint num = (nint)typeof(PoolManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v116 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
					object obj14 = (nint)0 & (nint)0x200;
					if (obj14 != null)
					{
						nint num2 = (nint)typeof(PoolManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v170 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					object obj15 = this + 20;
					object obj16 = default;
					obj15 = obj16;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
					object obj17 = default;
					object obj8 = obj17;
					obj10 = obj11;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
				object obj18 = default;
				if (obj10 != obj18)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
				_003C_003Em__Finally1();
				object obj19 = default;
				if (obj19 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
				}
				goto IL_0480;
				IL_0480:
				object result = default;
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

		private void _003C_003Em__Finally1()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_002c: Expected Obj, but got I4
			//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d2: Expected Obj, but got Unknown
			//IL_00db: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e0: Expected Obj, but got Unknown
			//IL_010c: Expected Obj, but got I4
			//IL_015b: Expected Obj, but got I
			//IL_0199: Unknown result type (might be due to invalid IL or missing references)
			//IL_019e: Expected Obj, but got Unknown
			//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d4: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 8;
			obj = obj2;
			_ = -1;
			object obj3 = _003C_003E1__state - -3;
			if (_003C_003E1__state != -3 && ((nint)obj3 == 1 || (nint)obj3 == 2 || (nint)obj3 == 3 || (nint)obj3 != 4))
			{
				return;
			}
			object obj4 = obj + 4;
			object obj5 = obj4 + 1;
			obj4 = obj5;
			object obj6 = obj5 << 2;
			object obj7 = obj + obj6;
			obj7 = 26;
			((IEnumerator)this).Reset();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+4]");
			if ((nint)0 == -1)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+4]");
			object obj8 = (nint)0 << 2;
			object obj9 = obj + obj8;
			if ((nint)obj9 == 26)
			{
				object obj10 = obj + 4;
				if ((nint)obj10 > -1)
				{
					object obj11 = obj10 + -1;
					obj10 = obj11;
				}
			}
		}

		void IEnumerator.Reset()
		{
			_003C_003E1__state = -1;
		}
	}

	public string poolName;

	public Transform testPrefab;

	public int spawnAmount;

	public float spawnInterval;

	public string particlesPoolName;

	private void Start()
	{
		//IL_000b: Expected I4, but got F4
		spawnAmount = 2;
		CancelInvoke();
	}

	private IEnumerator Spawner()
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

	private IEnumerator Despawner()
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

	public SimpleSpawner()
	{
		IEnumerator routine = Despawner();
		Coroutine coroutine = StartCoroutine_Auto(routine);
	}
}
