using System;
using Cpp2ILInjected;
using UnityEngine;

public class UIScale : MonoBehaviour
{
	private Vector2 iPadSize;

	private void Start()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		//IL_0026: Expected Obj, but got I4
		//IL_002f: Expected Obj, but got I4
		//IL_0038: Expected Obj, but got I4
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected Obj, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected Obj, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected Obj, but got Unknown
		//IL_00a3: Expected Obj, but got I4
		//IL_00ac: Expected Obj, but got I4
		//IL_00b5: Expected Obj, but got I4
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected Obj, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected Obj, but got Unknown
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected Obj, but got Unknown
		//IL_0112: Expected Obj, but got I4
		//IL_011b: Expected Obj, but got I4
		//IL_0124: Expected Obj, but got I4
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected Obj, but got Unknown
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj2 = default;
		object obj = obj2 + 16;
		obj = 0;
		obj = 0;
		obj = -1;
		_ = -1;
		_ = -1;
		_ = -1;
		object obj3 = obj2 + 20;
		obj3 = obj;
		object obj4 = obj2 + 24;
		obj4 = obj3;
		object obj6 = default;
		object obj5 = obj6 + 16;
		obj5 = obj4;
		object obj7 = obj2 + 8;
		obj7 = 0;
		obj7 = 0;
		obj7 = -107;
		_ = -64;
		_ = 34;
		_ = -1;
		object obj8 = obj2 + 12;
		obj8 = obj7;
		obj4 = obj8;
		object obj9 = obj6 + 20;
		obj9 = obj4;
		object obj10 = obj2 + 4;
		obj10 = 0;
		obj10 = 0;
		obj10 = 84;
		_ = 118;
		_ = 64;
		_ = -1;
		obj2 = obj10;
		obj4 = obj2;
		object obj11 = obj6 + 24;
		obj11 = obj4;
		object obj12 = this + 80;
		obj12 = obj6;
		_ = 3;
		_ = 3;
		_ = 1f;
		CancelInvoke();
	}

	public UIScale()
	{
		//IL_00fa: Expected I, but got Obj
		//IL_0110: Expected Obj, but got I
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected Obj, but got Unknown
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected Obj, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected Obj, but got Unknown
		//IL_008e: Expected VT, but got Obj
		//IL_0097: Expected Obj, but got I4
		nint num = (nint)typeof(DeviceInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<DeviceInfo>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DeviceInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v25 (Il2CppClass<DeviceInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = default;
		Transform transform = (Transform)(obj2 + 24);
		Transform transform2 = (Transform)(obj2 + 12);
		int runAverageFPS = InRunAverageFPSCounter.runAverageFPS;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v18 (System.Int32)+14]");
		if ((nint)0 == 1)
		{
			GameObject gameObject = base.gameObject;
			object obj3 = this + 12;
			object obj4 = this + 12;
			GameObject gameObject2 = base.gameObject;
			transform2.localScale = (Vector3)gameObject2;
			obj2 = 0;
			_ = 0;
			obj2 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S1_v13+4]");
			_ = 0;
			_ = ((UnityEngine.Object)transform2).m_CachedPtr;
			transform = (Transform)obj2;
			Transform transform3 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
			((Transform)(object)gameObject).parent = transform;
		}
	}
}
