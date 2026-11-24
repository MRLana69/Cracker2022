using System;
using System.Collections;
using Cpp2ILInjected;
using UnityEngine;

public class FacebookBuilding : CharacterCustomizationProp
{
	public override void Initialize(CharacterRig characterRig, bool alternateSetup)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_001c: Expected Obj, but got I4
		//IL_002b: Expected Obj, but got F4
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected Obj, but got Unknown
		//IL_008c: Expected I, but got Obj
		//IL_00a2: Expected Obj, but got I
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Expected Obj, but got Unknown
		//IL_011a: Expected I, but got Obj
		//IL_0130: Expected Obj, but got I
		//IL_00cd: Expected I, but got Obj
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Expected Obj, but got Unknown
		//IL_015b: Expected I, but got Obj
		GameObject gameObject = base.gameObject;
		((Transform)(object)gameObject).parentInternal = characterRig.headJoint;
		GameObject gameObject2 = base.gameObject;
		object obj2 = default;
		object obj = obj2 + 32;
		obj = 0;
		_ = 0;
		obj = 0f;
		_ = 0.12f;
		_ = -1.35f;
		Transform transform = (Transform)(obj2 + 48);
		transform = (Transform)obj;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S1_v8+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
		GameObject gameObject3 = base.gameObject;
		nint num = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S1_v19 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S1_v47 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Transform transform3 = (Transform)(obj2 + 16);
		transform3.Rotate(-3.44f, -180f, 0f);
		transform = transform3;
		((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)transform3).m_CachedPtr;
		Vector3 localScale = transform.localScale;
		GameObject gameObject4 = base.gameObject;
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S1_v30 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S1_v43 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 forward = Vector3.forward;
		transform = (Transform)obj2;
		Transform transform4 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
		((Transform)(object)gameObject4).parent = transform;
		object obj5 = this + 12;
		Animation component = GetComponent<Animation>();
		obj5 = component;
		IEnumerator routine = ((FanFoldOut)this).Play();
		Coroutine coroutine = StartCoroutine_Auto(routine);
	}

	public FacebookBuilding()
	{
		_ = 5f;
		_ = 2f;
		base._002Ector();
	}
}
