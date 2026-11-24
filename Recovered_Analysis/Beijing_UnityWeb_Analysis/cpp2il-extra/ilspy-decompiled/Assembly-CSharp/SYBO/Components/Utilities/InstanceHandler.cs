using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Missions;
using UnityEngine;

namespace SYBO.Components.Utilities;

public static class InstanceHandler
{
	public delegate GameObject InstantiateDelegate(GameObject prefab, Vector3 pos, Quaternion rot);

	public delegate void DestroyDelegate(GameObject instance);

	public static InstantiateDelegate InstantiateDelegates;

	public static DestroyDelegate DestroyDelegates;

	internal unsafe static GameObject InstantiatePrefab(GameObject prefab, Vector3 pos, Quaternion rot)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		//IL_0033: Expected Obj, but got I4
		//IL_0054: Expected native int or pointer, but got VT
		//IL_0082: Expected Obj, but got I4
		//IL_011e: Invalid comparison between Obj and VT
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Expected Obj, but got Unknown
		//IL_0202: Expected F4, but got I
		//IL_01fd: Expected native int or pointer, but got VT
		//IL_020b: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 8;
		object obj4 = obj2 + 88;
		obj4 = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		((Vector3*)(nint)rot)->x = 0f;
		StayInOneLaneMission instance = StayInOneLaneMission.instance;
		int currentMissionSet = ((MissionsManager)(object)instance).currentMissionSet;
		object obj5 = currentMissionSet + 12;
		GameObject result = null;
		object obj6 = default;
		object obj7 = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8283");
			obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+20]");
			_ = 0;
			obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+20]");
			_ = 0;
			obj2 = obj3;
			if (obj2 == (object)pos)
			{
				obj = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v9+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v9+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v9+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v9+20]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+24]");
				if ((nint)0 == 0)
				{
					obj = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v9+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v9+10]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v9+18]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v9+20]");
					_ = 0;
					obj3 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+4]");
					((Vector3*)(nint)rot)->x = 0f;
					result = (GameObject)1;
				}
			}
			obj6 = obj7 + 1;
		}
		return result;
	}

	internal static void DestroyInstance(GameObject instance)
	{
		//IL_00b2: Expected I, but got Obj
		//IL_00c8: Expected Obj, but got I
		//IL_0024: Expected I, but got Obj
		//IL_003a: Expected Obj, but got I
		//IL_00f3: Expected I, but got Obj
		//IL_0148: Expected Obj, but got I
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected Obj, but got Unknown
		//IL_0065: Expected I, but got Obj
		Transform transform = default;
		Transform transform2 = default;
		while (true)
		{
			LinkedList<PooledInstanceData> spawned = ((PrefabPool)(object)instance).spawned;
			if (System.Runtime.CompilerServices.Unsafe.As<Transform, UIntPtr>(ref transform) >= System.Runtime.CompilerServices.Unsafe.As<LinkedList<PooledInstanceData>, UIntPtr>(ref spawned))
			{
				break;
			}
			bool flag = ((ICollection<Transform>)(object)instance).Remove(transform);
			nint num = (nint)typeof(PoolManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v25 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(PoolManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v35 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Dictionary<Transform, PrefabPool> prefabPoolLookup = PoolManager._prefabPoolLookup;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v23 (System.Boolean)+8]");
			bool flag2 = prefabPoolLookup.Remove((Transform)0);
			transform = (Transform)(transform2 + 1);
		}
		nint num3 = (nint)typeof(PoolManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v8 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(PoolManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v16 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag3 = PoolManager.Pools.Remove((string)(object)instance);
	}
}
