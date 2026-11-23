using System;
using Cpp2ILInjected;
using UnityEngine;

public class TweenRotation : UITweener
{
	public Vector3 from;

	public Vector3 to;

	public bool quaternionLerp;

	private Transform mTrans;

	public Transform cachedTransform
	{
		get
		{
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Expected Obj, but got Unknown
			object result = this + 108;
			if (mTrans == null)
			{
				Transform transform = base.transform;
				mTrans = transform;
			}
			return (Transform)result;
		}
	}

	public unsafe Quaternion rotation
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_002d: Expected F4, but got I
			//IL_0028: Expected native int or pointer, but got VT
			//IL_003a: Expected F4, but got Obj
			//IL_0035: Expected native int or pointer, but got VT
			object obj2 = default;
			object obj = obj2 - 16;
			Quaternion quaternion = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			Quaternion quaternion2 = default;
			((Quaternion*)(nint)quaternion2)->z = 0f;
			((Quaternion*)(nint)quaternion2)->x = (float)obj;
			return quaternion2;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			//IL_001b: Expected native int or pointer, but got VT
			//IL_002d: Expected native int or pointer, but got VT
			object obj = default;
			Quaternion quaternion = (Quaternion)(obj - 16);
			((Quaternion*)(nint)quaternion)->z = value.z;
			((Quaternion*)(nint)quaternion)->x = value.x;
			this.value = quaternion;
		}
	}

	public unsafe Quaternion value
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_003f: Expected F4, but got I
			//IL_003a: Expected native int or pointer, but got VT
			//IL_004c: Expected F4, but got Obj
			//IL_0047: Expected native int or pointer, but got VT
			object obj2 = default;
			object obj = obj2 - 16;
			Transform transform = cachedTransform;
			Quaternion localRotation = transform.localRotation;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			Quaternion quaternion = default;
			((Quaternion*)(nint)quaternion)->z = 0f;
			((Quaternion*)(nint)quaternion)->x = (float)obj;
			return quaternion;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			//IL_0025: Expected native int or pointer, but got VT
			//IL_0037: Expected native int or pointer, but got VT
			object obj = default;
			Quaternion quaternion = (Quaternion)(obj - 16);
			Transform transform = cachedTransform;
			((Quaternion*)(nint)quaternion)->z = value.z;
			((Quaternion*)(nint)quaternion)->x = value.x;
			transform.localRotation = quaternion;
		}
	}

	protected unsafe override void OnUpdate(float factor, bool isFinished)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_01e7: Expected Obj, but got VT
		//IL_02b8: Expected Obj, but got I
		//IL_030b: Expected Obj, but got I
		//IL_0383: Unknown result type (might be due to invalid IL or missing references)
		//IL_0388: Expected VT, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected VT, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected VT, but got Unknown
		//IL_025b: Expected F4, but got I
		//IL_0256: Expected native int or pointer, but got VT
		//IL_0270: Expected F4, but got I
		//IL_026b: Expected native int or pointer, but got VT
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected VT, but got Unknown
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected VT, but got Unknown
		object obj = default;
		Quaternion quaternion = (Quaternion)(obj - 160);
		if (~(quaternionLerp ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenRotation)+54]");
			float num = 0f * ((float)Math.PI / 180f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenRotation)+58]");
			float num2 = 0f * ((float)Math.PI / 180f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+88]");
			_ = 0;
			float num3 = (float)from * ((float)Math.PI / 180f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+80]");
			_ = 0;
			Vector3 euler = (Vector3)(quaternion + 80);
			Quaternion quaternion2 = Quaternion.Internal_FromEulerRad(euler);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+98]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+90]");
			_ = 0;
			float num4 = (float)to * ((float)Math.PI / 180f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenRotation)+60]");
			float num5 = 0f * ((float)Math.PI / 180f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenRotation)+64]");
			float num6 = 0f * ((float)Math.PI / 180f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+88]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+80]");
			_ = 0;
			Vector3 euler2 = (Vector3)(quaternion - -64);
			Quaternion quaternion3 = Quaternion.Internal_FromEulerRad(euler2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+98]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+78]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+98]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+90]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+70]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+90]");
			_ = 0;
			Quaternion a = (Quaternion)(quaternion + 48);
			Quaternion b = (Quaternion)(quaternion + 32);
			Quaternion quaternion4 = Quaternion.Slerp(a, b, factor);
		}
		else
		{
			object obj2 = to - from;
			float num7 = Math.Min(factor, 1f);
			bool flag = factor < 0f;
			float num8 = 0f;
			if (!flag)
			{
				num8 = num7;
			}
			float num9 = (float)obj2 * num8;
			float num10 = (float)from + num9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenRotation)+60]");
			nint num11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenRotation)+54]");
			object obj3 = num11 - 0;
			float num12 = (float)obj3 * num8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenRotation)+54]");
			float num13 = 0f + num12;
			float num14 = num13 * ((float)Math.PI / 180f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenRotation)+64]");
			nint num15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenRotation)+58]");
			object obj4 = num15 - 0;
			float num16 = (float)obj4 * num8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenRotation)+58]");
			float num17 = 0f + num16;
			float num18 = num17 * ((float)Math.PI / 180f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+78]");
			_ = 0;
			float num19 = num10 * ((float)Math.PI / 180f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+70]");
			_ = 0;
			Vector3 euler3 = (Vector3)(quaternion + 16);
			Quaternion quaternion5 = Quaternion.Internal_FromEulerRad(euler3);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+98]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+90]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+88]");
		((Quaternion*)(nint)quaternion)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+80]");
		((Quaternion*)(nint)quaternion)->x = 0f;
		value = quaternion;
	}

	public unsafe static TweenRotation Begin(GameObject go, float duration, Quaternion rot)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Expected VT, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected VT, but got Unknown
		//IL_00db: Expected VT, but got I
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected VT, but got Unknown
		//IL_0171: Expected F4, but got I
		//IL_016c: Expected native int or pointer, but got VT
		//IL_0190: Expected F4, but got I
		//IL_018b: Expected native int or pointer, but got VT
		//IL_01d9: Expected VT, but got I
		object obj = default;
		Vector3 vector = (Vector3)(obj - 144);
		_ = 0;
		_ = 0;
		TweenRotation tweenRotation = UITweener.Begin<TweenRotation>(go, duration);
		Quaternion quaternion = tweenRotation.value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
		_ = 0;
		Quaternion quaternion2 = (Quaternion)(vector + 48);
		Vector3 vector2 = Quaternion.Internal_ToEulerRad(quaternion2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
		float num = 0f * 57.29578f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+84]");
		float num2 = 0f * 57.29578f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
		float num3 = 0f * 57.29578f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+78]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+70]");
		_ = 0;
		Vector3 euler = vector + 32;
		Vector3 vector3 = Quaternion.Internal_MakePositive(euler);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
		tweenRotation.from = (Vector3)0;
		_ = rot.z;
		_ = rot.x;
		Quaternion quaternion3 = (Quaternion)(vector + 16);
		Vector3 vector4 = Quaternion.Internal_ToEulerRad(quaternion3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
		float num4 = 0f * 57.29578f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+84]");
		float num5 = 0f * 57.29578f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
		float num6 = 0f * 57.29578f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+78]");
		((Vector3*)(nint)vector)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+70]");
		((Vector3*)(nint)vector)->x = 0f;
		Vector3 vector5 = Quaternion.Internal_MakePositive(vector);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
		tweenRotation.to = (Vector3)0;
		if (!(duration > 0f))
		{
			tweenRotation.Sample(1f, isFinished: true);
			tweenRotation.enabled = false;
		}
		return tweenRotation;
	}

	public unsafe override void SetStartToCurrentValue()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected VT, but got Unknown
		//IL_00c0: Expected F4, but got I
		//IL_00bb: Expected native int or pointer, but got VT
		//IL_00df: Expected F4, but got I
		//IL_00da: Expected native int or pointer, but got VT
		//IL_0125: Expected VT, but got I
		object obj = default;
		Vector3 vector = (Vector3)(obj - 96);
		_ = 0;
		_ = 0;
		Quaternion quaternion = value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
		_ = 0;
		Quaternion quaternion2 = (Quaternion)(vector + 16);
		Vector3 vector2 = Quaternion.Internal_ToEulerRad(quaternion2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
		float num = 0f * 57.29578f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+54]");
		float num2 = 0f * 57.29578f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
		float num3 = 0f * 57.29578f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
		((Vector3*)(nint)vector)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
		((Vector3*)(nint)vector)->x = 0f;
		Vector3 vector3 = Quaternion.Internal_MakePositive(vector);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
		from = (Vector3)0;
	}

	public unsafe override void SetEndToCurrentValue()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected VT, but got Unknown
		//IL_00c0: Expected F4, but got I
		//IL_00bb: Expected native int or pointer, but got VT
		//IL_00df: Expected F4, but got I
		//IL_00da: Expected native int or pointer, but got VT
		//IL_0125: Expected VT, but got I
		object obj = default;
		Vector3 vector = (Vector3)(obj - 96);
		_ = 0;
		_ = 0;
		Quaternion quaternion = value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
		_ = 0;
		Quaternion quaternion2 = (Quaternion)(vector + 16);
		Vector3 vector2 = Quaternion.Internal_ToEulerRad(quaternion2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
		float num = 0f * 57.29578f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+54]");
		float num2 = 0f * 57.29578f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
		float num3 = 0f * 57.29578f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
		((Vector3*)(nint)vector)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
		((Vector3*)(nint)vector)->x = 0f;
		Vector3 vector3 = Quaternion.Internal_MakePositive(vector);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
		to = (Vector3)0;
	}

	private unsafe void SetCurrentValueToStart()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected VT, but got Unknown
		//IL_00b6: Expected F4, but got I
		//IL_00b1: Expected native int or pointer, but got VT
		//IL_00d8: Expected F4, but got I
		//IL_00d3: Expected native int or pointer, but got VT
		object obj = default;
		Quaternion quaternion = (Quaternion)(obj - 80);
		float num = (float)from * ((float)Math.PI / 180f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenRotation)+54]");
		float num2 = 0f * ((float)Math.PI / 180f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenRotation)+58]");
		float num3 = 0f * ((float)Math.PI / 180f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+38]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+30]");
		_ = 0;
		Vector3 euler = (Vector3)(quaternion + 16);
		Quaternion quaternion2 = Quaternion.Internal_FromEulerRad(euler);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+48]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+48]");
		((Quaternion*)(nint)quaternion)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+40]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+40]");
		((Quaternion*)(nint)quaternion)->x = 0f;
		value = quaternion;
	}

	private unsafe void SetCurrentValueToEnd()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected VT, but got Unknown
		//IL_00b6: Expected F4, but got I
		//IL_00b1: Expected native int or pointer, but got VT
		//IL_00d8: Expected F4, but got I
		//IL_00d3: Expected native int or pointer, but got VT
		object obj = default;
		Quaternion quaternion = (Quaternion)(obj - 80);
		float num = (float)to * ((float)Math.PI / 180f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenRotation)+60]");
		float num2 = 0f * ((float)Math.PI / 180f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenRotation)+64]");
		float num3 = 0f * ((float)Math.PI / 180f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+38]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+30]");
		_ = 0;
		Vector3 euler = (Vector3)(quaternion + 16);
		Quaternion quaternion2 = Quaternion.Internal_FromEulerRad(euler);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+48]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+48]");
		((Quaternion*)(nint)quaternion)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+40]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+40]");
		((Quaternion*)(nint)quaternion)->x = 0f;
		value = quaternion;
	}
}
