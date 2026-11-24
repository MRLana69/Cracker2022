using System;
using Cpp2ILInjected;
using UnityEngine;

public class ParticleFollow : MonoBehaviour
{
	public Transform Target;

	public float TweenTime;

	public float SineOffset;

	public float SineSpeed;

	public float RotationTweenTime;

	private float tweenVelocity;

	private Vector3 baseRotation;

	private float tweenRotVelocity;

	private void Awake()
	{
		CancelInvoke();
	}

	private void OnEnable()
	{
		//IL_0017: Expected VT, but got Obj
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected Obj, but got Unknown
		GameObject gameObject = base.gameObject;
		Transform transform = default;
		transform.localEulerAngles = (Vector3)gameObject;
		object obj = transform + 12;
		obj = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		object obj2 = this + 36;
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v6+8]");
		_ = 0;
		string text = tag;
		((GameObject)(object)text).tag = null;
	}

	private void OnDisable()
	{
		tweenVelocity = 0f;
		tweenRotVelocity = 0f;
	}

	private void LateUpdate()
	{
		tweenVelocity = 0f;
		tweenRotVelocity = 0f;
	}

	public unsafe ParticleFollow()
	{
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected Obj, but got Unknown
		//IL_021f: Expected Obj, but got I4
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected Obj, but got Unknown
		//IL_023c: Expected Obj, but got I4
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected Obj, but got Unknown
		//IL_025f: Expected VT, but got Obj
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Expected Obj, but got Unknown
		//IL_0296: Expected VT, but got Obj
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		//IL_003f: Expected VT, but got Obj
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected Ref, but got Unknown
		//IL_0058: Expected I, but got Obj
		//IL_006e: Expected Obj, but got I
		//IL_02b2: Expected F4, but got Obj
		//IL_02b2: Expected F4, but got Obj
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Expected Obj, but got Unknown
		//IL_00fb: Expected Obj, but got F4
		//IL_0099: Expected I, but got Obj
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Expected Obj, but got Unknown
		//IL_037b: Expected VT, but got Obj
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected Obj, but got Unknown
		//IL_0119: Expected I, but got Obj
		//IL_012f: Expected Obj, but got I
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected Obj, but got Unknown
		//IL_01ce: Expected Obj, but got F4
		//IL_015a: Expected I, but got Obj
		Transform transform = default;
		object obj = transform + 48;
		obj = 0;
		_ = 0;
		object obj2 = transform + 36;
		obj2 = 0;
		_ = 0;
		Transform transform2 = (Transform)(transform + 60);
		transform2.position = (Vector3)Target;
		obj = transform2;
		_ = ((UnityEngine.Object)transform2).m_CachedPtr;
		Transform transform3 = (Transform)(transform + 24);
		GameObject gameObject = base.gameObject;
		transform3.position = (Vector3)gameObject;
		obj = transform3;
		object obj3 = transform + 12;
		obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		transform.position = (Vector3)Target;
		ref float currentVelocity = ref *(float*)(this + 32);
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S4_v2 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S4_v8 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num3 = Mathf.SmoothDampAngle((float)obj3, (float)transform, ref currentVelocity, TweenTime);
		object obj5 = num3 & 0x7FFFFFFF;
		if ((nint)obj5 > 2139095040)
		{
			tweenVelocity = 0f;
			tweenRotVelocity = 0f;
		}
		else
		{
			obj = num3;
		}
		GameObject gameObject2 = base.gameObject;
		transform2 = (Transform)obj;
		Transform transform4 = transform2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
		Vector3 localPosition = transform2.localPosition;
		object obj6 = this + 36;
		transform3 = (Transform)obj6;
		Transform transform5 = transform3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S1_v37+8]");
		((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
		obj2 = transform3;
		_ = ((UnityEngine.Object)transform3).m_CachedPtr;
		obj3 = transform3;
		_ = ((UnityEngine.Object)transform3).m_CachedPtr;
		transform.localEulerAngles = (Vector3)Target;
		object obj7 = this + 48;
		nint num4 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S0_v48 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num5 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S0_v63 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F6BD");
		float timeSinceLevelLoad = Time.timeSinceLevelLoad;
		float num6 = timeSinceLevelLoad * SineSpeed;
		float num7 = SineOffset + num6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @122E7");
		object obj9 = default;
		float num8 = (float)obj9 * 5.5f;
		object obj10 = obj2 + 4;
		float num9 = (float)obj10 + num8;
		obj10 = num9;
		GameObject gameObject3 = base.gameObject;
		transform2 = (Transform)obj2;
		Transform transform6 = transform2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		((UnityEngine.Object)transform6).m_CachedPtr = (IntPtr)0;
		Vector3 right = transform2.right;
	}
}
