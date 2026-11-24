using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Components.Utilities.Examples;

public class CreationExample : MonoBehaviour
{
	private sealed class _003CSpawner_003Ed__6(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public CreationExample _003C_003E4__this;

		private int _003Ccount_003E5__2;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
				//IL_0202: Expected VT, but got Unknown
				//IL_020b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0210: Expected VT, but got Unknown
				//IL_0219: Unknown result type (might be due to invalid IL or missing references)
				//IL_021e: Expected Obj, but got Unknown
				//IL_00ca: Expected I, but got Obj
				//IL_00e0: Expected Obj, but got I
				//IL_0263: Expected I, but got Obj
				//IL_0279: Expected Obj, but got I
				//IL_02ac: Expected F4, but got Obj
				//IL_02a7: Expected native int or pointer, but got VT
				//IL_02c1: Expected F4, but got I
				//IL_02bc: Expected native int or pointer, but got VT
				//IL_02ce: Expected F4, but got Obj
				//IL_02c9: Expected native int or pointer, but got VT
				//IL_02e3: Expected F4, but got I
				//IL_02de: Expected native int or pointer, but got VT
				//IL_0308: Expected Obj, but got I
				//IL_0308: Expected Obj, but got I
				//IL_0315: Expected native int or pointer, but got VT
				//IL_0323: Expected native int or pointer, but got VT
				//IL_0349: Expected native int or pointer, but got VT
				//IL_0357: Expected native int or pointer, but got VT
				//IL_0365: Expected native int or pointer, but got VT
				//IL_0377: Expected native int or pointer, but got VT
				//IL_0389: Expected native int or pointer, but got VT
				//IL_0397: Expected Obj, but got VT
				//IL_010b: Expected I, but got Obj
				//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
				//IL_01d3: Expected Obj, but got Unknown
				//IL_01ef: Expected Obj, but got I4
				//IL_0158: Expected I, but got Obj
				object obj = default;
				Quaternion quaternion = (Quaternion)(obj + 40);
				Vector3 vector = (Vector3)(obj + 28);
				object obj2 = obj + 16;
				CreationExample creationExample = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						return null;
					}
					_003C_003E1__state = -1;
				}
				else
				{
					_003C_003E1__state = -1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15 (SYBO.Components.Utilities.Examples.CreationExample)+14]");
					_003Ccount_003E5__2 = 0;
				}
				if (_003Ccount_003E5__2 < 1)
				{
					IEnumerator routine = ((ReallySimpleAudioSpawner)(object)creationExample).MusicSpawner();
					Coroutine coroutine = creationExample.StartCoroutine_Auto(routine);
					return null;
				}
				nint num = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S2_v3 (Il2CppClass<UnityEngine.Vector3>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num2 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S2_v35 (Il2CppClass<UnityEngine.Vector3>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Vector3 one = Vector3.one;
				nint num3 = (nint)typeof(Quaternion);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S2_v9 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num4 = (nint)typeof(Quaternion);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S2_v31 (Il2CppClass<UnityEngine.Quaternion>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Vector2 zero = Vector2.zero;
				((Vector3*)(nint)vector)->x = (float)obj2;
				Vector3 vector2 = vector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
				((Vector3*)(nint)vector2)->z = 0f;
				((Quaternion*)(nint)quaternion)->x = (float)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				((Quaternion*)(nint)quaternion)->z = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15 (SYBO.Components.Utilities.Examples.CreationExample)+1C]");
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15 (SYBO.Components.Utilities.Examples.CreationExample)+C]");
				Transform transform = ((SpawnPool)num5).Spawn((GameObject)0, vector, quaternion);
				((Vector3*)(nint)vector)->x = 0f;
				((Vector3*)(nint)vector)->z = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15 (SYBO.Components.Utilities.Examples.CreationExample)+14]");
				float x = 0f - (float)_003Ccount_003E5__2;
				((Vector3*)(nint)vector)->x = x;
				((Vector3*)(nint)vector)->y = 0f;
				((Vector3*)(nint)vector)->z = 0f;
				((Quaternion*)(nint)quaternion)->x = vector.x;
				((Quaternion*)(nint)quaternion)->z = vector.z;
				Vector3 eulerAngles = ((Transform)quaternion).eulerAngles;
				int num6 = _003Ccount_003E5__2 - 1;
				_003Ccount_003E5__2 = num6;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15 (SYBO.Components.Utilities.Examples.CreationExample)+18]");
				_ = 0;
				object obj5 = this + 12;
				object obj6 = default;
				obj5 = obj6;
				_003C_003E1__state = 1;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
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

		public CreationExample _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ac: Expected Obj, but got Unknown
				//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
				//IL_00fd: Expected Obj, but got Unknown
				//IL_0119: Expected Obj, but got I4
				CreationExample creationExample = _003C_003E4__this;
				if (_003C_003E1__state != 0 && _003C_003E1__state != 1)
				{
					return null;
				}
				_003C_003E1__state = -1;
				IEnumerator<Transform> enumerator = creationExample.pool.GetEnumerator();
				if ((nint)enumerator < 1)
				{
					return null;
				}
				IEnumerator<Transform> enumerator2 = creationExample.pool.GetEnumerator();
				Transform item = (Transform)(enumerator2 - 1);
				bool index = creationExample.pool.Contains(item);
				creationExample.pool.RemoveAt(index ? 1 : 0);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				_ = creationExample.spawnInterval;
				object obj = this + 12;
				object obj2 = default;
				obj = obj2;
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

	public Transform testPrefab;

	public string poolName;

	public int spawnAmount;

	public float spawnInterval;

	private SpawnPool pool;

	private void Start()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F5BB");
	}

	private IEnumerator Spawner()
	{
		//IL_0411: Unknown result type (might be due to invalid IL or missing references)
		//IL_0416: Expected Obj, but got Unknown
		//IL_041f: Expected Obj, but got I4
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected Obj, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected Obj, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected Obj, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected Obj, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected Obj, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected Obj, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected Obj, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected Obj, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected Obj, but got Unknown
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 8;
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCDB");
		object obj3 = default;
		CreationExample creationExample = (CreationExample)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCD1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCC8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCBF");
		object obj4 = this & 0x3FFFFFFFFFFFFFFFL;
		object obj5 = obj4 / 36000000000L;
		object obj6 = obj5 / 24;
		object obj7 = obj6 * 24;
		object obj8 = obj5 - obj7;
		object obj9 = this & 0x3FFFFFFFFFFFFFFFL;
		object obj10 = obj9 / 600000000;
		object obj11 = obj10 / 60;
		object obj12 = obj11 * 60;
		object obj13 = obj10 - obj12;
		object obj14 = this & 0x3FFFFFFFFFFFFFFFL;
		object obj15 = obj14 / 10000000;
		object obj16 = obj15 / 60;
		object obj17 = obj16 * 60;
		object obj18 = obj15 - obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DC8A");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj19 = obj2 + 36;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCD1");
		object obj20 = default;
		obj19 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		throw new ArrayTypeMismatchException();
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

	public CreationExample()
	{
		//IL_0256: Expected I, but got Obj
		//IL_026c: Expected Obj, but got I
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Expected Obj, but got Unknown
		//IL_02f2: Expected Obj, but got I4
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_0069: Expected Obj, but got I4
		//IL_0078: Expected Obj, but got F4
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got Unknown
		//IL_00ca: Expected I, but got Obj
		//IL_00e0: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_010b: Expected I, but got Obj
		//IL_01ed: Expected VT, but got Obj
		//IL_0207: Expected VT, but got Obj
		//IL_0207: Expected Obj, but got I
		//IL_021f: Expected VT, but got Obj
		//IL_0230: Expected Obj, but got I4
		//IL_0230: Expected Obj, but got I4
		//IL_0247: Expected I4, but got Obj
		nint num = (nint)typeof(PoolManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(PoolManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v53 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = this + 28;
		bool flag = PoolManager.Pools.assertValidPoolName(poolName);
		obj2 = flag;
		SpawnPool spawnPool = pool;
		GameObject parentInternal = gameObject;
		spawnPool.group__BackingField.parentInternal = (Transform)(object)parentInternal;
		object obj4 = default;
		object obj3 = obj4 + 16;
		obj3 = 0;
		_ = 0;
		obj3 = 1.5f;
		_ = 0f;
		_ = 0f;
		Transform transform = (Transform)(obj4 + 32);
		transform = (Transform)obj3;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S1_v12+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
		nint num3 = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S1_v22 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num4 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S1_v49 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector2 zero = Vector2.zero;
		transform = (Transform)obj4;
		Transform transform3 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
		Vector3 localScale = transform.localScale;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		PrefabPool prefabPool = default;
		prefabPool.nameInstance(testPrefab);
		prefabPool.preloadAmount = 5;
		prefabPool.cullDespawned = true;
		prefabPool.cullAbove = 10;
		prefabPool.limitInstances = true;
		prefabPool.limitAmount = 5;
		prefabPool.limitFIFO = true;
		pool.Add((Transform)(object)prefabPool);
		IEnumerator routine = Despawner();
		Coroutine coroutine = StartCoroutine_Auto(routine);
		bool flag2 = PoolManager.Pools.Remove((KeyValuePair<string, SpawnPool>)"Shapes");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S0_v43 (System.Boolean)+30]");
		bool flag3 = ((PrefabsDict)0).Remove((KeyValuePair<string, Transform>)"Cube");
		bool flag4 = PoolManager.Pools.Remove((KeyValuePair<string, SpawnPool>)"Shapes");
		Transform obj6 = ((SpawnPool)flag4).Spawn((GameObject)flag3);
		UnityEngine.Object.DestroyImmediate(obj6, (byte)(int)"Cube (Spawned By CreationExample.cs)" != 0);
	}
}
