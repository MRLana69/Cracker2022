using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Components.Utilities.Examples;

public class InstanceHandlerDelegateExample : MonoBehaviour
{
	private void Awake()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		object obj = this + 16;
		obj = "Creator";
		_ = 50;
		_ = 0.25f;
		CancelInvoke();
	}

	private unsafe void Start()
	{
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected Obj, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected Obj, but got Unknown
		//IL_0072: Expected I, but got Obj
		//IL_0088: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Delegate obj = default;
		obj.method_ptr = method_ptr;
		obj.method = (nint)__ldftn(InstanceHandlerDelegateExample.InstantiateDelegate);
		object obj2 = obj + 16;
		obj2 = this;
		Delegate obj3 = ((Delegate)InstanceHandler.InstantiateDelegates).CombineImpl(obj);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		InstanceHandler.InstantiateDelegate instantiateDelegates = default;
		InstanceHandler.InstantiateDelegates = instantiateDelegates;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Delegate obj4 = default;
		obj4.method_ptr = method_ptr2;
		obj4.method = (nint)__ldftn(InstanceHandlerDelegateExample.DestroyDelegate);
		object obj5 = obj4 + 16;
		obj5 = this;
		Delegate obj6 = ((Delegate)InstanceHandler.DestroyDelegates).CombineImpl(obj4);
		nint num = (nint)typeof(InstanceHandler);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v19 (Il2CppClass<SYBO.Components.Utilities.InstanceHandler>)+5C]");
		object obj7 = (nint)0 + (nint)4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj8 = default;
		obj7 = obj8;
	}

	public GameObject InstantiateDelegate(GameObject prefab, Vector3 pos, Quaternion rot)
	{
		return null;
	}

	public void DestroyDelegate(GameObject instance)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 8;
		obj = instance;
		_ = 12;
	}

	public unsafe GameObject InstantiateDelegateForShapesPool(GameObject prefab, Vector3 pos, Quaternion rot)
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_006d: Expected Obj, but got F4
		//IL_0084: Expected Obj, but got F4
		//IL_009c: Expected I, but got Obj
		//IL_00b2: Expected Obj, but got I
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected VT, but got Unknown
		//IL_00ea: Expected F4, but got Obj
		//IL_00e5: Expected native int or pointer, but got VT
		//IL_00ff: Expected F4, but got I
		//IL_00fa: Expected native int or pointer, but got VT
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected VT, but got Unknown
		//IL_011a: Expected F4, but got Obj
		//IL_0115: Expected native int or pointer, but got VT
		//IL_012f: Expected F4, but got I
		//IL_012a: Expected native int or pointer, but got VT
		//IL_0013: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		obj = pos.x;
		_ = pos.z;
		obj2 = rot.x;
		_ = rot.z;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v14 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v28 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector = (Vector3)(obj2 + 28);
		((Vector3*)(nint)vector)->x = (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Quaternion quaternion = (Quaternion)(obj2 + 40);
		((Quaternion*)(nint)quaternion)->x = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Quaternion*)(nint)quaternion)->z = 0f;
		return UnityEngine.Object.Instantiate(prefab, vector, quaternion);
	}

	public unsafe InstanceHandlerDelegateExample()
	{
		//IL_0073: Expected I, but got Obj
		//IL_0089: Expected Obj, but got I
		//IL_00b5: Expected VT, but got Obj
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected Obj, but got Unknown
		//IL_0106: Expected Obj, but got I4
		//IL_011b: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(PoolManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(PoolManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v23 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = PoolManager.Pools.Remove((KeyValuePair<string, SpawnPool>)"Shapes");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Delegate obj2 = default;
		obj2.method_ptr = method_ptr;
		obj2.method = (nint)__ldftn(InstanceHandlerDelegateExample.InstantiateDelegateForShapesPool);
		object obj3 = obj2 + 16;
		obj3 = this;
		object obj4 = (flag ? 1 : 0) + 60;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v13 (System.Boolean)+3C]");
		Delegate obj5 = ((Delegate)0).CombineImpl(obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj6 = default;
		obj4 = obj6;
	}
}
