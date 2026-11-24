using System;
using Cpp2ILInjected;
using UnityEngine;

public class UIShowControlScheme : MonoBehaviour
{
	public GameObject target;

	public bool mouse;

	public bool touch;

	public bool controller;

	private void OnEnable()
	{
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected Obj, but got Unknown
		//IL_00ec: Expected Obj, but got I4
		//IL_00f5: Expected Obj, but got F4
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected Obj, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected Obj, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected Obj, but got Unknown
		//IL_0143: Expected Obj, but got I4
		//IL_0152: Expected Obj, but got F4
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected Obj, but got Unknown
		//IL_01a1: Expected I, but got Obj
		//IL_01b7: Expected Obj, but got I
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Expected Obj, but got Unknown
		//IL_0279: Expected I, but got Obj
		//IL_028f: Expected Obj, but got I
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Expected Obj, but got Unknown
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		mouse = true;
		_ = 1;
		_ = 1;
		_ = 1;
		_ = 0.25f;
		_ = 35f;
		_ = 9f;
		_ = 1;
		object obj2 = default;
		object obj = obj2 + 8;
		obj = 0;
		obj = 1f;
		_ = 0f;
		object obj3 = obj2 + 24;
		obj3 = obj;
		object obj4 = obj2 + 56;
		obj4 = obj3;
		object obj5 = obj2 + 44;
		obj5 = 0;
		_ = 0;
		obj5 = 1f;
		_ = 0f;
		_ = 0f;
		obj4 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v26+8]");
		_ = 0;
		object obj6 = this + 80;
		obj6 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v23+8]");
		_ = 0;
		nint num = (nint)typeof(Vector2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v37 (Il2CppClass<UnityEngine.Vector2>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num2 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v67 (Il2CppClass<UnityEngine.Vector2>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj8 = obj2 + 16;
		Vector2 one = Vector2.one;
		obj4 = obj8;
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v46 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num4 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S0_v63 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj10 = obj2 + 32;
		Vector3 one2 = Vector3.one;
		obj4 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S0_v51+8]");
		_ = 0;
		object obj11 = this + 140;
		obj11 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v23+8]");
		_ = 0;
		_ = -10;
		Vector2 one3 = Vector2.one;
		obj4 = obj2;
		CancelInvoke();
	}

	private unsafe void OnDisable()
	{
		//IL_006f: Expected I, but got Obj
		//IL_0085: Expected Obj, but got I
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected Obj, but got Unknown
		//IL_0101: Expected I, but got Obj
		//IL_0117: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UICamera>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v19 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Delegate obj2 = default;
		obj2.method_ptr = method_ptr;
		obj2.method = (nint)__ldftn(UIShowControlScheme.OnScheme);
		object obj3 = obj2 + 16;
		obj3 = this;
		Delegate obj4 = ((Delegate)UICamera.onSchemeChange).CombineImpl(obj2);
		nint num3 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v15 (Il2CppClass<UICamera>)+5C]");
		object obj5 = (nint)0 + (nint)144;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj6 = default;
		obj5 = obj6;
		this._002Ector();
	}

	private unsafe void OnScheme()
	{
		//IL_0069: Expected I, but got Obj
		//IL_007f: Expected Obj, but got I
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected Obj, but got Unknown
		//IL_00fb: Expected I, but got Obj
		//IL_0111: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UICamera>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v18 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Delegate obj2 = default;
		obj2.method_ptr = method_ptr;
		obj2.method = (nint)__ldftn(UIShowControlScheme.OnScheme);
		object obj3 = obj2 + 16;
		obj3 = this;
		Delegate obj4 = ((Delegate)UICamera.onSchemeChange).RemoveImpl(obj2);
		nint num3 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v15 (Il2CppClass<UICamera>)+5C]");
		object obj5 = (nint)0 + (nint)144;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj6 = default;
		obj5 = obj6;
	}

	public UIShowControlScheme()
	{
		//IL_01a5: Expected I, but got Obj
		//IL_01bb: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0142: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		//IL_016a: Expected Obj, but got I4
		//IL_0192: Expected Obj, but got I4
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v32 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)target).FindKernel((string)null) == 0)
		{
			return;
		}
		nint num3 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v16 (Il2CppClass<UICamera>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v28 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		switch (UICamera.currentKey)
		{
		case KeyCode.None:
		{
			bool flag3 = mouse;
			target.tag = (string)flag3;
			break;
		}
		case (KeyCode)1:
		{
			bool flag2 = touch;
			target.tag = (string)flag2;
			break;
		}
		case (KeyCode)2:
		{
			bool flag = controller;
			target.tag = (string)flag;
			break;
		}
		}
	}
}
