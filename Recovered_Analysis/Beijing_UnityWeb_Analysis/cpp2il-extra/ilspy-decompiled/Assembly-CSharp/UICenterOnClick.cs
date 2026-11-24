using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public class UICenterOnClick : MonoBehaviour
{
	private void OnClick()
	{
		_ = 8f;
		CancelInvoke();
	}

	public unsafe UICenterOnClick()
	{
		//IL_032e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Expected Obj, but got Unknown
		//IL_033c: Expected Obj, but got I4
		//IL_035a: Expected I, but got Obj
		//IL_0370: Expected Obj, but got I
		//IL_039a: Expected VT, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_03bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c4: Expected Ref, but got Unknown
		//IL_03cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d2: Expected Obj, but got Unknown
		//IL_03db: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e0: Expected Obj, but got Unknown
		//IL_03ea: Expected Obj, but got VT
		//IL_0135: Expected I, but got Obj
		//IL_014b: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00e9: Expected Obj, but got VT
		//IL_0176: Expected I, but got Obj
		//IL_011d: Expected I4, but got Obj
		//IL_011d: Expected Obj, but got VT
		//IL_020d: Expected VT, but got Obj
		//IL_0243: Expected I, but got Obj
		//IL_0259: Expected Obj, but got I
		//IL_0452: Expected VT, but got Ref
		//IL_0284: Expected I, but got Obj
		//IL_0501: Expected VT, but got Ref
		//IL_02dd: Expected VT, but got Obj
		//IL_02dd: Expected Obj, but got Ref
		//IL_030e: Expected VT, but got Obj
		//IL_030e: Expected Obj, but got Ref
		//IL_02ef: Expected Obj, but got VT
		object obj2 = default;
		object obj = obj2 + 36;
		obj = 0;
		_ = 0;
		string trans = tag;
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S1_v8 (Il2CppClass<NGUITools>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v65 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_0021_00210 val = (_0021_00210)NGUITools.FindInParents<T>((Transform)(object)trans);
		string go = tag;
		UIPanel uIPanel = NGUITools.FindInParents<UIPanel>((GameObject)(object)go);
		nint num3 = (nint)typeof(Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v18 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v86 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		ref Vector3 reference = ref *(Vector3*)(obj2 + 48);
		Transform transform = (Transform)(obj2 + 24);
		Transform transform2 = (Transform)(obj2 + 12);
		if (((ComputeShader)val).FindKernel(null) != 0)
		{
			if (((Behaviour)val).isActiveAndEnabled)
			{
				GameObject gameObject = base.gameObject;
				((UIDragCamera)val).OnPress((byte)(int)gameObject != 0);
			}
			return;
		}
		nint num5 = (nint)typeof(Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v33 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num6 = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v78 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)uIPanel).FindKernel((string)null) == 0 || uIPanel.mClipping == UIDrawCall.Clipping.None)
		{
			return;
		}
		UIScrollView component = uIPanel.GetComponent<UIScrollView>();
		Camera anchorCamera = uIPanel.anchorCamera;
		GameObject gameObject2 = base.gameObject;
		transform.position = (Vector3)gameObject2;
		reference = ref *(Vector3*)transform;
		_ = ((Object)transform).m_CachedPtr;
		transform2.Internal_LookAt_Injected(ref *(Vector3*)anchorCamera, ref reference);
		nint num7 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S0_v50 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num8 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ S0_v74 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		reference = ref *(Vector3*)transform2;
		_ = ((Object)transform2).m_CachedPtr;
		Quaternion quaternion = Quaternion.Inverse((Quaternion)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
		obj = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		if (!component.canMoveVertically)
		{
			Camera anchorCamera2 = uIPanel.anchorCamera;
			((Transform)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference)).localPosition = (Vector3)anchorCamera2;
			obj = reference;
		}
		if (!component.shouldMoveHorizontally)
		{
			Camera anchorCamera3 = uIPanel.anchorCamera;
			((Transform)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference)).localPosition = (Vector3)anchorCamera3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v23 (UnityEngine.Vector3&)+4]");
			_ = 0;
		}
		Transform cachedTransform = uIPanel.cachedTransform;
		reference = ref *(Vector3*)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		SpringPosition springPosition = SpringPosition.Begin((GameObject)(object)cachedTransform, (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference), 6f);
	}
}
