using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Components.Logging;
using UnityEngine;

namespace SYBO.Components.Utilities;

public class PrefabsDict : IDictionary<string, Transform>, ICollection<KeyValuePair<string, Transform>>, IEnumerable<KeyValuePair<string, Transform>>, IEnumerable
{
	private Dictionary<string, Transform> _prefabs;

	public int Count
	{
		get
		{
			//IL_0054: Expected Obj, but got I4
			//IL_0025: Expected Obj, but got I4
			//IL_0029: Expected I4, but got Obj
			Dictionary<string, Transform> prefabs = _prefabs;
			object obj = prefabs.count - prefabs.freeCount;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			Dictionary<string, Transform>.KeyCollection keys = _prefabs.Keys;
			string[] array = default;
			keys.CopyTo(array, 0);
			int num = string.CompareOrdinalIgnoreCaseHelper(", ", (string)(object)array);
			return (int)$"[{(object[])num}]";
		}
	}

	// C# has no syntax for parameterized property 'Item'.
	public Transform get_Item(string key)
	{
		//IL_002d: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		NotSupportedException ex = default;
		ex._002Ector("Use Contains(string prefabName) instead.");
		((PrefabsDict)(object)ex).Contains((KeyValuePair<string, Transform>)0);
		return null;
	}

	public void set_Item(string key, Transform value)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		NotSupportedException ex = default;
		ex._002Ector("Read-Only");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
	}

	public ICollection<string> Keys
	{
		get
		{
			//IL_0026: Expected Obj, but got I4
			Dictionary<string, Transform> prefabs = _prefabs;
			return (ICollection<string>)(prefabs.count - prefabs.freeCount);
		}
	}

	public ICollection<Transform> Values => (ICollection<Transform>)(object)_prefabs.Keys;

	private bool IsReadOnly
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @CE18");
			bool result = default;
			return result;
		}
	}

	bool ICollection<KeyValuePair<string, Transform>>.IsReadOnly => true;

	public unsafe override string ToString()
	{
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected Obj, but got Unknown
		//IL_0173: Expected I, but got Obj
		//IL_0189: Expected Obj, but got I
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected Obj, but got Unknown
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected Ref, but got Unknown
		//IL_0149: Expected Obj, but got I4
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
		string text = (string)(obj3 + 28);
		text = (string)obj2;
		string text2 = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v14+8]");
		text2.m_stringLength = 0;
		ref Transform reference = ref *(Transform*)(obj3 + 40);
		reference = ref *(Transform*)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		return (string)TryGetValue(text, out reference);
	}

	internal void _Add(string prefabName, Transform prefab)
	{
		//IL_013d: Expected VT, but got Obj
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected I4, but got Unknown
		//IL_00a0: Expected Obj, but got I
		//IL_00a0: Expected Obj, but got I
		//IL_00b3: Expected I, but got Obj
		//IL_00c9: Expected Obj, but got I
		//IL_0081: Expected Obj, but got I
		//IL_0081: Expected Obj, but got I
		//IL_00f4: Expected I, but got Obj
		Add((KeyValuePair<string, Transform>)prefabName);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		SpawnPool spawnPool = default;
		spawnPool.Despawn((Transform)(object)prefabName, (Transform)(object)this);
		object obj = prefab ^ 1;
		int spawnPriority = obj & 1;
		spawnPool.spawnPriority = spawnPriority;
		if ((object)prefab != null)
		{
			string tag = ((Component)(object)prefabName).tag;
			((GameObject)(object)tag).tag = null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Utilities.PrefabsDict)+38]");
			((LinkedList<PooledInstanceData>)0).AddLast((LinkedListNode<PooledInstanceData>)(nint)((UnityEngine.Object)spawnPool).m_CachedPtr);
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Utilities.PrefabsDict)+34]");
			((LinkedList<PooledInstanceData>)0).AddLast((LinkedListNode<PooledInstanceData>)(nint)((UnityEngine.Object)spawnPool).m_CachedPtr);
		}
		nint num = (nint)typeof(PoolManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v13 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(PoolManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v18 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		PoolManager.UnregisterInstance((PooledInstanceData)(object)spawnPool);
	}

	internal bool _Remove(string prefabName)
	{
		//IL_01a2: Expected I, but got Obj
		//IL_01b8: Expected Obj, but got I
		//IL_027b: Expected Obj, but got I
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_012f: Expected I, but got Obj
		//IL_01e6: Expected Obj, but got I
		//IL_01fa: Expected Obj, but got I
		//IL_020a: Expected Obj, but got I
		//IL_0235: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v17 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Utilities.PrefabsDict)+C]");
		if ((UnityEngine.Object)0 != null)
		{
			nint num3 = (nint)typeof(Log);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v26 (Il2CppClass<SYBO.Components.Logging.Log>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(Log);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v33 (Il2CppClass<SYBO.Components.Logging.Log>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Utilities.PrefabsDict)+24]");
			string tag = ((Component)0).tag;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Utilities.PrefabsDict)+24]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Utilities.PrefabsDict)+24]");
			object obj4 = 0;
			PoolManagerLogCategory poolManager = Log.PoolManager;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S2_v6+14]");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S4_v3+18]");
			poolManager.LogErrorFormat((UnityEngine.Object)(object)tag, (int)num5, "SpawnPool {0}: PrefabPool.prefabGO is null", (object[])0);
		}
		nint num6 = (nint)typeof(PoolManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v10 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num7 = (nint)typeof(PoolManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v21 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Transform transform = PoolManager.Spawn((Transform)(object)prefabName);
		if ((object)transform != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v15 (UnityEngine.Transform)+18]");
			return 0 == (nint)this;
		}
		return false;
	}

	internal void _Clear()
	{
		//IL_04ba: Expected I, but got Obj
		//IL_04d0: Expected Obj, but got I
		//IL_0649: Expected Obj, but got I
		//IL_007c: Expected Obj, but got I
		//IL_008c: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0063: Expected Obj, but got I
		//IL_026a: Expected Obj, but got I
		//IL_027a: Expected Obj, but got I
		//IL_00a1: Expected Obj, but got I
		//IL_00af: Expected I, but got Obj
		//IL_00c5: Expected Obj, but got I
		//IL_0459: Expected Obj, but got I
		//IL_046a: Expected Obj, but got I
		//IL_04ff: Expected Obj, but got I
		//IL_0475: Unknown result type (might be due to invalid IL or missing references)
		//IL_047a: Expected Obj, but got Unknown
		//IL_0483: Expected Obj, but got I4
		//IL_0489: Unknown result type (might be due to invalid IL or missing references)
		//IL_048e: Expected Obj, but got Unknown
		//IL_0497: Expected Obj, but got I4
		//IL_049d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a2: Expected Obj, but got Unknown
		//IL_04ab: Expected Obj, but got I4
		//IL_028f: Expected Obj, but got I
		//IL_029d: Expected I, but got Obj
		//IL_02b3: Expected Obj, but got I
		//IL_00f0: Expected I, but got Obj
		//IL_05a4: Expected Obj, but got I
		//IL_0255: Expected Obj, but got I4
		//IL_013d: Expected I, but got Obj
		//IL_0153: Expected Obj, but got I
		//IL_02de: Expected I, but got Obj
		//IL_01f2: Expected Obj, but got I
		//IL_0531: Expected Obj, but got I
		//IL_0541: Expected Obj, but got I
		//IL_0552: Expected Obj, but got I
		//IL_056b: Expected Obj, but got I
		//IL_0443: Expected Obj, but got I4
		//IL_032b: Expected I, but got Obj
		//IL_0341: Expected Obj, but got I
		//IL_0247: Expected Obj, but got I
		//IL_017e: Expected I, but got Obj
		//IL_03e0: Expected Obj, but got I
		//IL_05d6: Expected Obj, but got I
		//IL_05e6: Expected Obj, but got I
		//IL_05f7: Expected Obj, but got I
		//IL_0610: Expected Obj, but got I
		//IL_0232: Expected Obj, but got I4
		//IL_0435: Expected Obj, but got I
		//IL_036c: Expected I, but got Obj
		//IL_0420: Expected Obj, but got I4
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v84 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Utilities.PrefabsDict)+C]");
		if (((ComputeShader)0).FindKernel(null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Utilities.PrefabsDict)+C]");
			UnityEngine.Object obj2 = UnityEngine.Object.Instantiate((UnityEngine.Object)0);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Utilities.PrefabsDict)+38]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v12+8]");
		object obj4 = 0;
		while (obj4 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ L1_v3+14]");
			object obj5 = 0;
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S1_v53 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S1_v79 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v62+14]");
			if (((ComputeShader)0).FindKernel(null) != 0)
			{
				nint num5 = (nint)typeof(PoolManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S1_v64 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num6 = (nint)typeof(PoolManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S1_v75 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ L1_v3+14]");
				PoolManager.Despawn((Transform)0);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ L1_v3+14]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S1_v72+14]");
				string tag = ((Component)0).tag;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Utilities.PrefabsDict)+24]");
				((SpawnPool)0).CreatePrefabPool((PrefabPool)(object)tag);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ L1_v3+C]");
			object obj10;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ L1_v3+8]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ L1_v3+C]");
				nint num7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S1_v61+8]");
				if (num7 == 0)
				{
					obj10 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ L1_v3+C]");
					obj10 = 0;
				}
			}
			else
			{
				obj10 = 0;
			}
			obj4 = obj10;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Utilities.PrefabsDict)+34]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v19+8]");
		object obj12 = 0;
		while (obj12 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ L1_v5+14]");
			object obj13 = 0;
			nint num8 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S1_v22 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj14 = (nint)0 & (nint)0x200;
			if (obj14 != null)
			{
				nint num9 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S1_v48 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v36+14]");
			if (((ComputeShader)0).FindKernel(null) != 0)
			{
				nint num10 = (nint)typeof(PoolManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ S1_v33 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
				object obj15 = (nint)0 & (nint)0x200;
				if (obj15 != null)
				{
					nint num11 = (nint)typeof(PoolManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ S1_v44 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ L1_v5+14]");
				PoolManager.Despawn((Transform)0);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ L1_v5+14]");
				object obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ S1_v41+14]");
				string tag2 = ((Component)0).tag;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Utilities.PrefabsDict)+24]");
				((SpawnPool)0).CreatePrefabPool((PrefabPool)(object)tag2);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ L1_v5+C]");
			object obj18;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ L1_v5+8]");
				object obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ L1_v5+C]");
				nint num12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ S1_v30+8]");
				if (num12 == 0)
				{
					obj18 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ L1_v5+C]");
					obj18 = 0;
				}
			}
			else
			{
				obj18 = 0;
			}
			obj12 = obj18;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Utilities.PrefabsDict)+34]");
		((LinkedList<PooledInstanceData>)0).Clear();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Utilities.PrefabsDict)+38]");
		((LinkedList<PooledInstanceData>)0).Clear();
		object obj19 = this + 8;
		obj19 = 0;
		object obj20 = this + 12;
		obj20 = 0;
		object obj21 = this + 36;
		obj21 = 0;
	}

	public bool ContainsKey(string prefabName)
	{
		return _prefabs.Remove(prefabName);
	}

	public unsafe bool TryGetValue(string prefabName, out Transform prefab)
	{
		//IL_0543: Unknown result type (might be due to invalid IL or missing references)
		//IL_0548: Expected VT, but got Unknown
		//IL_0551: Unknown result type (might be due to invalid IL or missing references)
		//IL_0556: Expected VT, but got Unknown
		//IL_055f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0564: Expected Obj, but got Unknown
		//IL_00a8: Expected I, but got Obj
		//IL_00be: Expected Obj, but got I
		//IL_001c: Expected Obj, but got I
		//IL_0029: Invalid comparison between VT and I4
		//IL_03a3: Expected F4, but got Obj
		//IL_039e: Expected native int or pointer, but got VT
		//IL_03b8: Expected F4, but got I
		//IL_03b3: Expected native int or pointer, but got VT
		//IL_03c5: Expected F4, but got Obj
		//IL_03c0: Expected native int or pointer, but got VT
		//IL_03da: Expected F4, but got I
		//IL_03d5: Expected native int or pointer, but got VT
		//IL_0428: Expected I, but got Obj
		//IL_043e: Expected Obj, but got I
		//IL_00e9: Expected I, but got Obj
		//IL_059f: Expected F4, but got Obj
		//IL_059a: Expected native int or pointer, but got VT
		//IL_05b4: Expected F4, but got I
		//IL_05af: Expected native int or pointer, but got VT
		//IL_05c1: Expected F4, but got Obj
		//IL_05bc: Expected native int or pointer, but got VT
		//IL_05d6: Expected F4, but got I
		//IL_05d1: Expected native int or pointer, but got VT
		//IL_0138: Expected Obj, but got I
		//IL_014d: Expected VT, but got I
		//IL_014d: Expected Obj, but got VT
		//IL_015a: Expected Obj, but got F4
		//IL_016c: Expected I4, but got F4
		//IL_0468: Expected F4, but got Obj
		//IL_0463: Expected native int or pointer, but got VT
		//IL_047a: Expected F4, but got I4
		//IL_0475: Expected native int or pointer, but got VT
		//IL_0488: Expected F4, but got Obj
		//IL_0483: Expected native int or pointer, but got VT
		//IL_049d: Expected F4, but got I
		//IL_0498: Expected native int or pointer, but got VT
		//IL_04c2: Expected Obj, but got I
		//IL_04c2: Expected Obj, but got I
		//IL_017f: Expected I, but got Obj
		//IL_020d: Expected Obj, but got I4
		//IL_0229: Expected I, but got Obj
		//IL_023f: Expected Obj, but got I
		//IL_01ce: Expected Obj, but got I
		//IL_01e3: Expected VT, but got I
		//IL_01e3: Expected Obj, but got VT
		//IL_01f0: Expected Ref, but got F4
		//IL_04f5: Expected VT, but got I4
		//IL_0505: Expected Obj, but got I
		//IL_034b: Expected Obj, but got I
		//IL_034b: Expected Obj, but got I
		//IL_026a: Expected I, but got Obj
		//IL_02b9: Expected Obj, but got I
		//IL_0628: Expected VT, but got I
		//IL_0628: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Utilities.PrefabsDict)+30]");
		if ((nint)0 == 0)
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Utilities.PrefabsDict)+C]");
			_0021_00210 componentInChildren = (_0021_00210)((GameObject)0).GetComponentInChildren<T>();
			if (componentInChildren != (_0021_00210)(object)0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
			}
		}
		object obj = default;
		Vector3 vector = (Vector3)(obj + 48);
		Vector3 vector2 = (Vector3)(obj + 32);
		object obj2 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Utilities.PrefabsDict)+14]");
		if ((nint)0 != 0)
		{
			Transform transform = ((PrefabPool)this).SpawnNew();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Utilities.PrefabsDict)+18]");
			if ((nint)transform >= 0)
			{
				return false;
			}
		}
		obj2 = prefabName;
		_ = prefabName.m_stringLength;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v28 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v94 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 one = Vector3.one;
		((Vector3*)(nint)vector2)->x = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v17+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)obj;
		Vector3 vector3 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector3)->z = 0f;
		if (vector2 != vector)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Utilities.PrefabsDict)+24]");
			object obj4 = 0;
			Vector3 vector4 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S1_v63+2C]");
			((Transform)vector4).position = (Vector3)0;
			string text = (string)vector.x;
			prefabName.m_stringLength = (int)vector.z;
		}
		obj2 = prefab;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [prefab @ L2 (UnityEngine.Transform&)+8]");
		_ = 0;
		nint num3 = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S0_v43 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num4 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S0_v87 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector2 zero = Vector2.zero;
		((Vector3*)(nint)vector2)->x = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v17+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)obj;
		Vector3 vector5 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector5)->z = 0f;
		if ((Quaternion)vector2 != (Quaternion)vector)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Utilities.PrefabsDict)+24]");
			object obj6 = 0;
			Vector3 vector6 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ S1_v56+2C]");
			((Transform)vector6).rotation = (Quaternion)0;
			ref Transform reference = ref *(Transform*)vector.x;
			_ = vector.z;
		}
		((Vector3*)(nint)vector2)->x = (float)prefabName;
		((Vector3*)(nint)vector2)->z = prefabName.m_stringLength;
		((Vector3*)(nint)vector)->x = (float)prefab;
		Vector3 vector7 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [prefab @ L2 (UnityEngine.Transform&)+8]");
		((Vector3*)(nint)vector7)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Utilities.PrefabsDict)+24]");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Utilities.PrefabsDict)+C]");
		Transform transform2 = ((SpawnPool)num5).Spawn((Transform)0, vector2, (Quaternion)vector);
		int layer = ((GameObject)(object)transform2).layer;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		SpawnPool spawnPool = default;
		spawnPool.Despawn((Transform)layer, (Transform)(object)this);
		spawnPool.spawnPriority = 1;
		nint num6 = (nint)typeof(PoolManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ S0_v64 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num7 = (nint)typeof(PoolManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ S0_v80 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		PoolManager.UnregisterInstance((PooledInstanceData)(object)spawnPool);
		Add((KeyValuePair<string, Transform>)layer);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Utilities.PrefabsDict)+24]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ S0_v71+1C]");
		if ((nint)0 == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Utilities.PrefabsDict)+24]");
			object obj9 = 0;
			int num8 = ((layer != 0) ? ((((int*)layer)->m_value == (nint)typeof(RectTransform)) ? layer : 0) : 0);
			bool relativeTo = num8 == 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ S1_v53+2C]");
			((Transform)layer).Translate((Vector3)0, relativeTo ? Space.Self : Space.World);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Utilities.PrefabsDict)+34]");
		((LinkedList<PooledInstanceData>)0).AddLast((LinkedListNode<PooledInstanceData>)(nint)((UnityEngine.Object)spawnPool).m_CachedPtr);
		return (byte)layer != 0;
	}

	public void Add(string key, Transform value)
	{
		//IL_001b: Expected Obj, but got I
		//IL_002b: Expected Obj, but got I
		//IL_003b: Expected Obj, but got I
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S4_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S4_v3+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S4_v4+48]");
		object obj3 = 0;
		object obj4 = obj3 & 0x7FF;
		object obj5 = obj4 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v30 @ S5_v4 (should have been resolved before IL gen)");
	}

	public bool Remove(string prefabName)
	{
		//IL_001b: Expected Obj, but got I
		//IL_002b: Expected Obj, but got I
		//IL_003b: Expected Obj, but got I
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S2_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S2_v3+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S2_v4+44]");
		object obj3 = 0;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v27 @ S3_v4 (should have been resolved before IL gen)");
		object obj6 = default;
		return (nint)obj6 > -1;
	}

	public bool Contains(KeyValuePair<string, Transform> item)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		NotSupportedException ex = default;
		ex._002Ector("Read-Only");
		((PrefabsDict)(object)ex).Remove((string)null);
		return false;
	}

	public void Add(KeyValuePair<string, Transform> item)
	{
		//IL_0032: Expected Obj, but got VT
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected Obj, but got Unknown
		//IL_0023: Expected I4, but got Obj
		//IL_0023: Expected Obj, but got VT
		UnityEngine.Object values = UnityEngine.Object.Instantiate((UnityEngine.Object)item);
		Transform transform = ((PrefabPool)this).SpawnNew();
		object obj = transform + 1;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63D");
		int totalLength = default;
		string text = string.ConcatArray((string[])(object)values, totalLength);
		UnityEngine.Object.DestroyImmediate((UnityEngine.Object)item, (byte)(int)text != 0);
	}

	public void Clear()
	{
		((Dictionary<TKey, TValue>)(object)_prefabs).Resize();
	}

	private void CopyTo(KeyValuePair<string, Transform>[] array, int arrayIndex)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		NotSupportedException ex = default;
		ex._002Ector("Read-only.");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
	}

	void ICollection<KeyValuePair<string, Transform>>.CopyTo(KeyValuePair<string, Transform>[] array, int arrayIndex)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		NotSupportedException ex = default;
		ex._002Ector("Cannot be copied");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
	}

	public bool Remove(KeyValuePair<string, Transform> item)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj3 = default;
		object obj4 = default;
		if (obj3 == obj4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			object obj6 = default;
			object obj5 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
			object obj8 = default;
			object obj7 = obj8;
		}
		else
		{
			object obj9 = default;
			object obj7 = obj9;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		return false;
	}

	public IEnumerator<KeyValuePair<string, Transform>> GetEnumerator()
	{
		//IL_0006: Expected Obj, but got I4
		return (IEnumerator<KeyValuePair<string, Transform>>)1;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @759C");
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		IEnumerator result = default;
		return result;
	}

	public PrefabsDict()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		NotSupportedException ex = default;
		ex._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
	}
}
