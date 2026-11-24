using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering;

public abstract class ATeleboardMenuEffect : MonoBehaviour
{
	protected Transform _rootTransform;

	protected bool _boardOnly;

	public virtual void Initialize(Transform root, bool boardOnly = false)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected Obj, but got Unknown
		//IL_002b: Expected Obj, but got I4
		//IL_003a: Expected Obj, but got F4
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected Obj, but got Unknown
		//IL_00a0: Expected I, but got Obj
		//IL_00b6: Expected Obj, but got I
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Expected Obj, but got Unknown
		//IL_0353: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Expected Obj, but got Unknown
		//IL_012e: Expected I4, but got Obj
		//IL_013a: Expected Obj, but got I4
		//IL_0150: Expected Obj, but got I
		//IL_00e1: Expected I, but got Obj
		//IL_016b: Expected Obj, but got I
		//IL_0176: Expected Obj, but got I4
		//IL_018c: Expected Obj, but got I4
		//IL_019c: Expected Obj, but got I4
		//IL_01ac: Expected Obj, but got I4
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected Obj, but got Unknown
		//IL_01c7: Expected Obj, but got I4
		//IL_01d6: Expected Obj, but got F4
		//IL_021c: Expected Obj, but got I4
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Expected Obj, but got Unknown
		//IL_027a: Expected Obj, but got I4
		//IL_0291: Expected I4, but got Obj
		//IL_029d: Expected Obj, but got I4
		//IL_02b3: Expected Obj, but got I
		//IL_02ce: Expected Obj, but got I
		GameObject gameObject = _rootTransform.gameObject;
		((Transform)(object)gameObject).parentInternal = root;
		((Renderer)(object)_rootTransform).shadowCastingMode = ShadowCastingMode.Off;
		GameObject gameObject2 = _rootTransform.gameObject;
		Transform transform = default;
		object obj = transform + 48;
		obj = 0;
		_ = 0;
		obj = 0f;
		_ = 0.25f;
		_ = -0.8f;
		Transform transform2 = (Transform)(transform - -64);
		transform2 = (Transform)obj;
		Transform transform3 = transform2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v8+8]");
		((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform2.eulerAngles;
		GameObject gameObject3 = _rootTransform.gameObject;
		nint num = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S1_v19 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S1_v60 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Transform transform4 = (Transform)(transform + 32);
		transform4.Rotate(0f, 90f, 35f);
		transform2 = transform4;
		((UnityEngine.Object)transform2).m_CachedPtr = ((UnityEngine.Object)transform4).m_CachedPtr;
		Vector3 localScale = transform2.localScale;
		object obj3 = this + 68;
		Animation component = _rootTransform.GetComponent<Animation>();
		bool flag = component.Play((PlayMode)"POOF");
		obj3 = flag;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (ATeleboardMenuEffect)+44]");
		((AnimationState)0).wrapMode = WrapMode.Once;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (ATeleboardMenuEffect)+44]");
		((AnimationState)0).time = 1f;
		GameObject gameObject4 = ((Component)_boardOnly).gameObject;
		((Transform)(object)gameObject4).parentInternal = (Transform)boardOnly;
		((Renderer)_boardOnly).shadowCastingMode = ShadowCastingMode.Off;
		GameObject gameObject5 = ((Component)_boardOnly).gameObject;
		object obj4 = transform + 16;
		obj4 = 0;
		_ = 0;
		obj4 = 0f;
		_ = -0.25f;
		_ = 0.8f;
		transform2 = (Transform)obj4;
		Transform transform5 = transform2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S1_v40+8]");
		((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles2 = transform2.eulerAngles;
		GameObject gameObject6 = ((Component)_boardOnly).gameObject;
		transform.Rotate(0f, 270f, 325f);
		transform2 = transform;
		((UnityEngine.Object)transform2).m_CachedPtr = ((UnityEngine.Object)transform).m_CachedPtr;
		Vector3 localScale2 = transform2.localScale;
		object obj5 = this + 72;
		Animation component2 = ((Component)_boardOnly).GetComponent<Animation>();
		bool flag2 = component2.Play((PlayMode)"POOF");
		obj5 = flag2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (ATeleboardMenuEffect)+48]");
		((AnimationState)0).wrapMode = WrapMode.Once;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (ATeleboardMenuEffect)+48]");
		((AnimationState)0).time = 1f;
	}

	public abstract void StartTeleboardEffect(float duration, CharacterModel characterModel);

	public abstract void EndTeleboardEffect(float duration, CharacterModel characterModel);

	protected ATeleboardMenuEffect()
	{
		CancelInvoke();
	}
}
