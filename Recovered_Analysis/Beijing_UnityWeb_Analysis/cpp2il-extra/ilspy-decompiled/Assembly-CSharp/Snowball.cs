using System;
using System.Collections;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering;

public class Snowball : CharacterCustomizationProp
{
	public override void Initialize(CharacterRig characterRig, bool alternateSetup)
	{
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Expected Obj, but got Unknown
		//IL_001d: Expected I, but got Obj
		//IL_0033: Expected Obj, but got I
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected Obj, but got Unknown
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Expected Obj, but got Unknown
		//IL_00ab: Expected I, but got Obj
		//IL_00c1: Expected Obj, but got I
		//IL_005e: Expected I, but got Obj
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Expected Obj, but got Unknown
		//IL_00ec: Expected I, but got Obj
		//IL_0192: Expected Obj, but got I
		//IL_01a8: Expected Obj, but got I
		//IL_01c3: Expected Obj, but got I
		//IL_01d9: Expected Obj, but got I
		object obj = this + 28;
		obj = characterRig;
		GameObject gameObject = base.gameObject;
		GameObject parentInternal = characterRig.attachPoint1.gameObject;
		((Transform)(object)gameObject).parentInternal = (Transform)(object)parentInternal;
		GameObject gameObject2 = base.gameObject;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v11 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S1_v48 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = default;
		object obj3 = obj4 + 32;
		Vector3 one = Vector3.one;
		Transform transform = (Transform)(obj4 + 48);
		transform = (Transform)obj3;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S1_v16+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
		GameObject gameObject3 = base.gameObject;
		nint num3 = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S1_v23 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num4 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S1_v44 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj6 = obj4 + 16;
		Vector2 zero = Vector2.zero;
		transform = (Transform)obj6;
		Transform transform3 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S1_v28+8]");
		((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
		Vector3 localScale = transform.localScale;
		GameObject gameObject4 = base.gameObject;
		Vector3 forward = Vector3.forward;
		transform = (Transform)obj4;
		Transform transform4 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
		((Transform)(object)gameObject4).parent = transform;
		if (alternateSetup)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Snowball)+C]");
			((Renderer)0).shadowCastingMode = ShadowCastingMode.Off;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Snowball)+10]");
			((Renderer)0).shadowCastingMode = ShadowCastingMode.Off;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Snowball)+14]");
			((Renderer)0).shadowCastingMode = ShadowCastingMode.Off;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Snowball)+18]");
			((Renderer)0).shadowCastingMode = ShadowCastingMode.Off;
		}
		else
		{
			Renderer currentHoverboadBasemodel = ((CharacterModel)(object)this).CurrentHoverboadBasemodel;
			Coroutine coroutine = StartCoroutine_Auto((IEnumerator)currentHoverboadBasemodel);
		}
	}

	public Snowball()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		object obj = this + 32;
		obj = "";
		base._002Ector();
	}
}
