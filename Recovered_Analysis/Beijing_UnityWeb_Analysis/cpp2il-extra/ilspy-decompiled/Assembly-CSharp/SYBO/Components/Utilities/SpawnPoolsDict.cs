using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Data.Save;
using Missions;
using SYBO.Components.Logging;
using UnityEngine;

namespace SYBO.Components.Utilities;

public class SpawnPoolsDict : IDictionary<string, SpawnPool>, ICollection<KeyValuePair<string, SpawnPool>>, IEnumerable<KeyValuePair<string, SpawnPool>>, IEnumerable
{
	private Dictionary<string, SpawnPool> _pools;

	public int Count
	{
		get
		{
			//IL_0054: Expected Obj, but got I4
			//IL_0025: Expected Obj, but got I4
			//IL_0029: Expected I4, but got Obj
			Dictionary<string, SpawnPool> pools = _pools;
			object obj = pools.count - pools.freeCount;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @CE17");
			Dictionary<string, SpawnPool>.KeyCollection keyCollection = default;
			string[] array = default;
			keyCollection.CopyTo(array, 0);
			int num = string.CompareOrdinalIgnoreCaseHelper(", ", (string)(object)array);
			return (int)$"[{(object[])num}]";
		}
	}

	// C# has no syntax for parameterized property 'Item'.
	public SpawnPool get_Item(string key)
	{
		//IL_002d: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		NotSupportedException ex = default;
		ex._002Ector("Use PoolManager.Pools.Contains(string poolName) instead.");
		((SpawnPoolsDict)(object)ex).Contains((KeyValuePair<string, SpawnPool>)0);
		return null;
	}

	public void set_Item(string key, SpawnPool value)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		NotSupportedException ex = default;
		ex._002Ector("SpawnPools add themselves to PoolManager.Pools when created, so there is no need to Add() them explicitly. Create pools using PoolManager.Pools.Create() or add a SpawnPool component to a GameObject.");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
	}

	public ICollection<string> Keys
	{
		get
		{
			//IL_0026: Expected Obj, but got I4
			Dictionary<string, SpawnPool> pools = _pools;
			return (ICollection<string>)(pools.count - pools.freeCount);
		}
	}

	public ICollection<SpawnPool> Values
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NotSupportedException ex = default;
			ex._002Ector("If you need this, please request it.");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			return null;
		}
	}

	private bool IsReadOnly
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NotSupportedException ex = default;
			ex._002Ector("If you need this, please request it.");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			return false;
		}
	}

	bool ICollection<KeyValuePair<string, SpawnPool>>.IsReadOnly => true;

	public SpawnPool Create(string poolName)
	{
		//IL_003c: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
		object obj = default;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v6+8]");
			object obj2 = default;
			if ((nint)obj2 >= 0)
			{
				return (SpawnPool)1;
			}
		}
		return null;
	}

	public unsafe SpawnPool Create(string poolName, GameObject owner)
	{
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected VT, but got Unknown
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected VT, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected Obj, but got Unknown
		//IL_0084: Expected I, but got Obj
		//IL_009a: Expected Obj, but got I
		//IL_015e: Expected F4, but got Obj
		//IL_0159: Expected native int or pointer, but got VT
		//IL_0173: Expected F4, but got I
		//IL_016e: Expected native int or pointer, but got VT
		//IL_0180: Expected F4, but got Obj
		//IL_017b: Expected native int or pointer, but got VT
		//IL_0195: Expected F4, but got I
		//IL_0190: Expected native int or pointer, but got VT
		//IL_0012: Expected F4, but got Obj
		//IL_000d: Expected native int or pointer, but got VT
		//IL_0024: Expected F4, but got I4
		//IL_001f: Expected native int or pointer, but got VT
		//IL_0031: Expected F4, but got Obj
		//IL_002c: Expected native int or pointer, but got VT
		//IL_0043: Expected F4, but got I
		//IL_003e: Expected native int or pointer, but got VT
		//IL_00c5: Expected I, but got Obj
		object obj = default;
		Quaternion quaternion = (Quaternion)(obj + 40);
		Vector3 vector = (Vector3)(obj + 28);
		object obj2 = obj + 16;
		if (InstanceHandler.InstantiateDelegates != null)
		{
			((Vector3*)(nint)vector)->x = (float)poolName;
			((Vector3*)(nint)vector)->z = poolName.m_stringLength;
			((Quaternion*)(nint)quaternion)->x = (float)owner;
			((Quaternion*)(nint)quaternion)->z = (nint)((UnityEngine.Object)owner).m_CachedPtr;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8548");
			SpawnPool result = default;
			return result;
		}
		obj2 = poolName;
		_ = poolName.m_stringLength;
		obj = owner;
		_ = ((UnityEngine.Object)owner).m_CachedPtr;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v24 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v36 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Vector3*)(nint)vector)->x = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
		((Vector3*)(nint)vector)->z = 0f;
		((Quaternion*)(nint)quaternion)->x = (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Quaternion*)(nint)quaternion)->z = 0f;
		return (SpawnPool)(object)UnityEngine.Object.Instantiate((GameObject)(object)this, vector, quaternion);
	}

	private bool assertValidPoolName(string poolName)
	{
		//IL_0013: Expected I4, but got Obj
		//IL_0033: Expected I4, but got Obj
		//IL_004d: Expected I4, but got Obj
		if (Destroy(poolName))
		{
			string text = string.ConcatArray((string[])(object)poolName, (int)"Pool");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			GameObject gameObject = default;
			gameObject.layer = (int)text;
			SpawnPool spawnPool = gameObject.AddComponent<SpawnPool>();
			return (byte)(int)spawnPool != 0;
		}
		return false;
	}

	public override string ToString()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a9: Expected Obj, but got I
		//IL_00b9: Expected Obj, but got I
		//IL_00c9: Expected Obj, but got I
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected Obj, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected Obj, but got Unknown
		//IL_0103: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(PoolManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(PoolManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v15 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S2_v2 (Il2CppMethodInfo)+C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S2_v3+60]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S2_v4+44]");
		object obj4 = 0;
		object obj5 = obj4 & 0x1FFF;
		object obj6 = obj5 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v43 @ S3_v4 (should have been resolved before IL gen)");
		object obj7 = default;
		bool flag = (nint)obj7 > -1;
		return (string)flag;
	}

	public bool Destroy(string poolName)
	{
		//IL_0032: Expected I4, but got Obj
		//IL_0032: Expected I4, but got Obj
		//IL_0043: Expected I4, but got Obj
		//IL_001a: Expected VT, but got Obj
		//IL_000d: Expected VT, but got Obj
		string text = poolName.Remove((int)"Pool", (int)"");
		KeyValuePair<string, SpawnPool> item = ((text.get_Chars((int)poolName) == '\0') ? ((KeyValuePair<string, SpawnPool>)poolName) : ((KeyValuePair<string, SpawnPool>)text));
		bool flag = Contains(item);
		return (byte)((flag ? 1u : 0u) ^ 1u) != 0;
	}

	public void DestroyAll()
	{
		//IL_0023: Expected I, but got Obj
		//IL_0039: Expected Obj, but got I
		//IL_0064: Expected I, but got Obj
		if (InstanceHandler.DestroyDelegates != null)
		{
			InstanceHandler.DestroyDelegates.EndInvoke((IAsyncResult)this);
			return;
		}
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v11 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v16 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UnityEngine.Object.DestroyImmediate((UnityEngine.Object)(object)this);
	}

	internal void Add(SpawnPool spawnPool)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Utilities.SpawnPoolsDict)+14]");
		if ((nint)0 != 0)
		{
			_ = 0;
			StayInOneLaneMission instance = StayInOneLaneMission.instance;
			((MissionsManager)(object)instance).ResetProgressForMissionIndex(61);
		}
	}

	public void Add(string key, SpawnPool value)
	{
		//IL_0166: Expected Obj, but got I
		//IL_017c: Expected Obj, but got I
		//IL_0185: Expected Obj, but got I4
		//IL_001b: Expected Obj, but got I
		//IL_0143: Expected Obj, but got I4
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected Obj, but got Unknown
		//IL_00bc: Expected I4, but got Obj
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Utilities.SpawnPoolsDict)+18]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6+10]");
		object obj2 = (nint)0 + (nint)12;
		object obj3 = 0;
		bool flag = true;
		object obj8 = default;
		MysteryBox.Type type2 = default;
		while (true)
		{
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6+10]");
				object obj4 = (nint)0 + (nint)16;
				object obj5 = obj3 << 2;
				object obj6 = obj4 + obj5;
				object obj7 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
				if (obj8 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v31+14]");
					if (0 == (nint)key)
					{
						bool flag2;
						if (flag)
						{
							string type = ((Notification)(object)key).type;
							IEnumerator enumerator = ((StayInOneLaneMission)this).CountMissionProgressCoroutine((int)key);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v30+8]");
							object obj9 = enumerator + 0;
							flag2 = System.Runtime.CompilerServices.Unsafe.As<string, UIntPtr>(ref type) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9);
						}
						else
						{
							flag2 = false;
						}
						bool flag3 = flag2;
						object obj10 = obj3 + 1;
						obj3 = obj10;
						flag = flag3;
						continue;
					}
					break;
				}
				break;
			}
			if (flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num = 0;
				_ = 0;
				object obj11 = type2 + 16;
				obj11 = this;
				PlayerSave.IncrementMysteryBoxesOpened(type2);
			}
			break;
		}
		((Award)this).RewardPayedOut();
	}

	internal unsafe bool Remove(SpawnPool spawnPool)
	{
		//IL_00af: Expected I, but got Obj
		//IL_00c5: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_0037: Expected Obj, but got I
		//IL_00f0: Expected I, but got Obj
		//IL_0062: Expected I, but got Obj
		ref SpawnPool reference = ref *(SpawnPool*)null;
		if (_pools.TryGetValue((string)(object)spawnPool, out reference))
		{
			string tag = reference.tag;
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S1_v17 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UnityEngine.Object.DestroyImmediate((UnityEngine.Object)(object)tag);
			return true;
		}
		nint num3 = (nint)typeof(Log);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v14 (Il2CppClass<SYBO.Components.Logging.Log>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Log);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v22 (Il2CppClass<SYBO.Components.Logging.Log>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Log.PoolManager.LogErrorFormat("PoolManager: Unable to destroy '{0}'. Not in PoolManager", (object[])(object)spawnPool);
		return false;
	}

	public bool Remove(string poolName)
	{
		//IL_00ce: Expected VT, but got I
		//IL_00e9: Expected Obj, but got I4
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected Obj, but got Unknown
		//IL_00aa: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_012e: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [poolName @ L1 (System.String)+18]");
		bool flag = Contains((KeyValuePair<string, SpawnPool>)0);
		RuntimePlatform platform = Application.platform;
		object obj = (flag ? 1 : 0) ^ 1;
		object obj2 = platform & obj;
		if (obj2 != null)
		{
			nint num = (nint)typeof(Log);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v16 (Il2CppClass<SYBO.Components.Logging.Log>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num2 = (nint)typeof(Log);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v24 (Il2CppClass<SYBO.Components.Logging.Log>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			PoolManagerLogCategory poolManager = Log.PoolManager;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [poolName @ L1 (System.String)+18]");
			poolManager.LogErrorFormat("PoolManager: Unable to remove '{0}'. Pool not in PoolManager", (object[])0);
			return false;
		}
		Dictionary<string, SpawnPool> pools = _pools;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [poolName @ L1 (System.String)+18]");
		bool flag2 = pools.Remove((string)0);
		return true;
	}

	public bool ContainsKey(string poolName)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		NotSupportedException ex = default;
		ex._002Ector("SpawnPools can only be destroyed, not removed and kept alive outside of PoolManager. There are only 2 legal ways to destroy a SpawnPool: Destroy the GameObject directly, if you have a reference, or use PoolManager.Destroy(string poolName).");
		((SpawnPoolsDict)(object)ex).Remove((string)null);
		return false;
	}

	public unsafe bool TryGetValue(string poolName, out SpawnPool spawnPool)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001c: Expected Obj, but got Ref
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected Obj, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected Obj, but got Unknown
		//IL_008b: Expected Obj, but got I4
		//IL_01f7: Expected I4, but got Obj
		//IL_01f7: Expected Obj, but got Ref
		//IL_0113: Expected Obj, but got I
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected Obj, but got Unknown
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		if (Destroy(poolName))
		{
			UnityEngine.Object obj3 = UnityEngine.Object.Instantiate((UnityEngine.Object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref spawnPool));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			object obj4 = obj2 + 4;
			object obj5 = obj4 + 1;
			obj4 = obj5;
			object obj6 = obj5 << 2;
			object obj7 = obj2 + obj6;
			obj7 = 57;
			UnityEngine.Object.DestroyImmediate((UnityEngine.Object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref spawnPool), (byte)(int)obj3 != 0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			bool result = default;
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
				object obj8 = (nint)0 << 2;
				object obj9 = obj2 + obj8;
				if ((nint)obj9 == 57)
				{
					object obj10 = obj2 + 4;
					if ((nint)obj10 > -1)
					{
						object obj11 = obj10 + -1;
						obj10 = obj11;
					}
					return result;
				}
			}
			object obj12 = default;
			if (obj12 == null)
			{
				return result;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		bool result2 = default;
		return result2;
	}

	public bool Contains(KeyValuePair<string, SpawnPool> item)
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

	public void Add(KeyValuePair<string, SpawnPool> item)
	{
		//IL_0190: Expected VT, but got I
		//IL_00a9: Expected Obj, but got I
		//IL_00b9: Expected Obj, but got I
		//IL_00c9: Expected Obj, but got I
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected Obj, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected Obj, but got Unknown
		//IL_00fd: Expected I, but got Obj
		//IL_0113: Expected Obj, but got I
		//IL_01e7: Expected Obj, but got VT
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_013e: Expected I, but got Obj
		//IL_01b6: Expected Obj, but got VT
		//IL_01d9: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [item @ L1 (System.Collections.Generic.KeyValuePair`2<System.String, SYBO.Components.Utilities.SpawnPool>)+18]");
		if (Contains((KeyValuePair<string, SpawnPool>)0))
		{
			nint num = (nint)typeof(Log);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v22 (Il2CppClass<SYBO.Components.Logging.Log>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Log);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v29 (Il2CppClass<SYBO.Components.Logging.Log>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string tag = ((Component)item).tag;
			PoolManagerLogCategory poolManager = Log.PoolManager;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [item @ L1 (System.Collections.Generic.KeyValuePair`2<System.String, SYBO.Components.Utilities.SpawnPool>)+18]");
			poolManager.LogErrorFormat((UnityEngine.Object)(object)tag, "A pool with the name '{0}' already exists. This should only happen if a SpawnPool with this name is added to a scene twice.", (object[])0);
			return;
		}
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S4_v3 (Il2CppMethodInfo)+C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S4_v4+60]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S4_v5+48]");
		object obj4 = 0;
		object obj5 = obj4 & 0x7FF;
		object obj6 = obj5 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v43 @ S5_v5 (should have been resolved before IL gen)");
		nint num4 = (nint)typeof(PoolManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v12 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num5 = (nint)typeof(PoolManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v17 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		PoolManager.BeginBalancing((Action<float>)item);
	}

	public void Clear()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Expected Obj, but got Unknown
		//IL_0278: Expected Obj, but got I4
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Expected Obj, but got Unknown
		//IL_029b: Expected Obj, but got I4
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Expected Obj, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected Obj, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected Obj, but got Unknown
		//IL_0150: Expected Obj, but got I4
		//IL_01b7: Expected Obj, but got I
		//IL_0064: Expected I, but got Obj
		//IL_007a: Expected Obj, but got I
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Expected Obj, but got Unknown
		//IL_00a5: Expected I, but got Obj
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - -64;
		object obj3 = obj2 + 40;
		obj3 = 0;
		_ = 0;
		_ = 0;
		object obj4 = obj2 + 24;
		obj4 = 0;
		object obj5 = obj2 + 32;
		obj5 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @759C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
		_ = 0;
		object obj6 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj6 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ S0_v91 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ S0_v100 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		}
		object obj8 = obj5 + 4;
		object obj9 = obj8 + 1;
		obj8 = obj9;
		object obj10 = obj9 << 2;
		object obj11 = obj5 + obj10;
		obj11 = 59;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
			object obj12 = (nint)0 << 2;
			object obj13 = obj5 + obj12;
			if ((nint)obj13 == 59)
			{
				object obj14 = obj5 + 4;
				if ((nint)obj14 > -1)
				{
					object obj15 = obj14 + -1;
					obj14 = obj15;
				}
				goto IL_0361;
			}
		}
		object obj16 = default;
		if (obj16 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0361;
		IL_0361:
		((Dictionary<TKey, TValue>)(object)_pools).Resize();
	}

	private void CopyTo(KeyValuePair<string, SpawnPool>[] array, int arrayIndex)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		NotSupportedException ex = default;
		ex._002Ector("Cannot set PoolManager.Pools[key] directly. SpawnPools add themselves to PoolManager.Pools when created, so there is no need to set them explicitly. Create pools using PoolManager.Pools.Create() or add a SpawnPool component to a GameObject.");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
	}

	void ICollection<KeyValuePair<string, SpawnPool>>.CopyTo(KeyValuePair<string, SpawnPool>[] array, int arrayIndex)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		NotSupportedException ex = default;
		ex._002Ector("PoolManager.Pools cannot be copied");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
	}

	public bool Remove(KeyValuePair<string, SpawnPool> item)
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

	public IEnumerator<KeyValuePair<string, SpawnPool>> GetEnumerator()
	{
		//IL_0006: Expected Obj, but got I4
		return (IEnumerator<KeyValuePair<string, SpawnPool>>)1;
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

	public SpawnPoolsDict()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		NotSupportedException ex = default;
		ex._002Ector("Use PoolManager.Pools.DestroyAll() instead.");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
	}
}
