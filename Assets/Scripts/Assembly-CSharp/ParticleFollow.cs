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
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0053: Expected VT, but got Obj
		object obj2 = default;
		object obj = obj2 - 32;
		Transform transform = base.transform;
		Vector3 localEulerAngles = transform.localEulerAngles;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		baseRotation = (Vector3)obj;
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: false);
	}

	private void OnEnable()
	{
		tweenRotVelocity = 0f;
		tweenVelocity = 0f;
	}

	private void OnDisable()
	{
		tweenRotVelocity = 0f;
		tweenVelocity = 0f;
	}

	private unsafe void LateUpdate()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Ref, but got Unknown
		//IL_0091: Expected F4, but got I
		//IL_0091: Expected F4, but got I
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Expected Obj, but got Unknown
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Expected VT, but got Unknown
		//IL_00c5: Expected F4, but got I
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Expected Ref, but got Unknown
		//IL_0321: Expected F4, but got I
		//IL_01d5: Expected F4, but got I
		//IL_01d0: Expected native int or pointer, but got VT
		//IL_01f6: Expected F4, but got I
		//IL_01f1: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 80);
		Vector3 position = Target.position;
		Transform transform = base.transform;
		Vector3 position2 = transform.position;
		Vector3 position3 = Target.position;
		ref float currentVelocity = ref *(float*)(this + 32);
		float deltaTime = Time.deltaTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
		float num2 = Mathf.SmoothDamp(num, 0f, ref currentVelocity, TweenTime, float.PositiveInfinity, deltaTime);
		object obj2 = num2 & 0x7FFFFFFF;
		bool flag = (nint)obj2 >= 2139095041;
		bool flag2 = !flag;
		float num3 = num2;
		if (!flag2)
		{
			tweenRotVelocity = 0f;
			tweenVelocity = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
			num3 = 0f;
		}
		Transform transform2 = base.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+44]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
		_ = 0;
		Vector3 position4 = vector + 16;
		transform2.position = position4;
		Vector3 localEulerAngles = Target.localEulerAngles;
		float deltaTime2 = Time.deltaTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+44]");
		float num4 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (ParticleFollow)+28]");
		float num5 = num4 - 0f;
		float num6 = num5 / 360f;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Floor not resolved\"");
		float num7 = num6 * 360f;
		float num8 = num5 - num7;
		float num9 = Math.Min(num8, 360f);
		bool flag3 = num8 < 0f;
		float num10 = 0f;
		if (!flag3)
		{
			num10 = num9;
		}
		if (num10 > 180f)
		{
			num10 -= 360f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (ParticleFollow)+28]");
		float target = 0f + num10;
		ref float currentVelocity2 = ref *(float*)(this + 48);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (ParticleFollow)+28]");
		float num11 = Mathf.SmoothDamp(0f, target, ref currentVelocity2, RotationTweenTime, float.PositiveInfinity, deltaTime2);
		float time = Time.time;
		float num12 = time * SineSpeed;
		float num13 = SineOffset + num12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @331");
		object obj3 = default;
		float num14 = (float)obj3 * 5.5f;
		float num15 = num11 + num14;
		Transform transform3 = base.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (ParticleFollow)+2C]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
		((Vector3*)(nint)vector)->z = 0f;
		_ = baseRotation;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
		((Vector3*)(nint)vector)->x = 0f;
		transform3.localEulerAngles = vector;
	}
}
