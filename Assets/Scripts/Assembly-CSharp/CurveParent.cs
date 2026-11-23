using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public class CurveParent : MonoBehaviour
{
	private bool _disableGizmos;

	public Color color = (Color)1065353216;

	private Vector3 _localPositionAtCaching;

	private Curve _cachedCurve;

	private bool _forceLinearZ;

	public float MaxTime
	{
		get
		{
			Curve cachedCurve = CachedCurve;
			return cachedCurve.MaxTime__BackingField;
		}
	}

	public float MinTime
	{
		get
		{
			Curve cachedCurve = CachedCurve;
			return cachedCurve.MinTime__BackingField;
		}
	}

	public Curve CachedCurve
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Expected Obj, but got Unknown
			//IL_0082: Expected Obj, but got I
			//IL_00b9: Expected Obj, but got I
			//IL_00dc: Invalid comparison between Obj and F4
			object obj2 = default;
			object obj = obj2 - 16;
			if (_cachedCurve != null)
			{
				Transform transform = base.transform;
				Vector3 localPosition = transform.localPosition;
				object obj3 = obj - _localPositionAtCaching;
				object obj4 = obj3 * obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CurveParent)+24]");
				object obj5 = num - 0;
				object obj6 = obj5 * obj5;
				object obj7 = obj4 + obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CurveParent)+28]");
				object obj8 = num2 - 0;
				object obj9 = obj8 * obj8;
				object obj10 = obj7 + obj9;
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)9.9999994E-11f))
				{
					goto IL_00fb;
				}
			}
			RecacheCurve();
			goto IL_00fb;
			IL_00fb:
			return _cachedCurve;
		}
	}

	public unsafe void OnDrawGizmos()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0047: Expected F4, but got I
		//IL_0042: Expected native int or pointer, but got VT
		//IL_0056: Expected F4, but got VT
		//IL_0051: Expected native int or pointer, but got VT
		object obj = default;
		Color color = (Color)(obj - 16);
		if (~(_disableGizmos ? 1u : 0u) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CurveParent)+18]");
			((Color*)(nint)color)->b = 0f;
			((Color*)(nint)color)->r = (float)this.color;
			DrawCurve(color);
		}
	}

	public unsafe Quaternion GetRotationForTime(float time, float timeOffset = 0.25f)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected Obj, but got Unknown
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected VT, but got Unknown
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected VT, but got Unknown
		//IL_015d: Expected Obj, but got I
		//IL_0199: Expected Obj, but got I
		//IL_01e4: Expected Obj, but got I
		//IL_026e: Expected F4, but got I
		//IL_0269: Expected native int or pointer, but got VT
		//IL_0283: Expected F4, but got I
		//IL_027e: Expected native int or pointer, but got VT
		//IL_0296: Expected I, but got Obj
		//IL_02d5: Expected F4, but got I
		//IL_02d0: Expected native int or pointer, but got VT
		//IL_02e3: Expected F4, but got VT
		//IL_02de: Expected native int or pointer, but got VT
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Expected VT, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj - 128);
		_ = 0;
		_ = 0;
		Curve cachedCurve = CachedCurve;
		float t = time - timeOffset;
		Vector3 vector2 = cachedCurve.Evaluate(t);
		Vector3 vector3 = cachedCurve.Evaluate(time);
		object obj2 = vector - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+78]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+78]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+74]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+70]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+74]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+70]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
		_ = 0;
		Vector3 fromDirection = vector + 48;
		Vector3 toDirection = vector + 32;
		Quaternion quaternion = Quaternion.FromToRotation(fromDirection, toDirection);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+78]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+70]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+70]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+70]");
		object obj3 = num - 0;
		float num2 = (float)obj3 - 0f;
		float num3 = num2 * num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+74]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+74]");
		object obj4 = num4 - 0;
		float num5 = (float)obj4 - 0f;
		float num6 = num5 * num5;
		float num7 = num3 + num6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+78]");
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+78]");
		object obj5 = num8 - 0;
		float num9 = (float)obj5 - 0f;
		float num10 = num9 * num9;
		float num11 = num7 + num10;
		if (!(num11 < 9.9999994E-11f))
		{
			nint num12 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ S0_v58 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ S0_v59 (Il2CppStaticFields<UnityEngine.Vector3>)+20]");
			((Vector3*)(nint)vector)->z = 0f;
			((Vector3*)(nint)vector)->x = (float)Vector3.upVector;
			Vector3 forward = vector + 16;
			Quaternion quaternion2 = Quaternion.LookRotation(forward, vector);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+78]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+70]");
			_ = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
		Quaternion quaternion3 = default;
		((Quaternion*)(nint)quaternion3)->x = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
		((Quaternion*)(nint)quaternion3)->z = 0f;
		return quaternion3;
	}

	public unsafe Vector3 GetDerivativeForTime(float time)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0043: Expected F4, but got I
		//IL_003e: Expected native int or pointer, but got VT
		//IL_0050: Expected F4, but got Obj
		//IL_004b: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj = obj2 - 16;
		Curve cachedCurve = CachedCurve;
		Vector3 vector = cachedCurve.EvaluateDerivative(time);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		Vector3 vector2 = default;
		((Vector3*)(nint)vector2)->z = 0f;
		((Vector3*)(nint)vector2)->x = (float)obj;
		return vector2;
	}

	public unsafe Vector3 GetLocalPositionForTime(float time)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0043: Expected F4, but got I
		//IL_003e: Expected native int or pointer, but got VT
		//IL_0050: Expected F4, but got Obj
		//IL_004b: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj = obj2 - 16;
		Curve cachedCurve = CachedCurve;
		Vector3 vector = cachedCurve.Evaluate(time);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		Vector3 vector2 = default;
		((Vector3*)(nint)vector2)->z = 0f;
		((Vector3*)(nint)vector2)->x = (float)obj;
		return vector2;
	}

	public bool HasTimeForLocalZ(float z)
	{
		//IL_001a: Invalid comparison between I and F4
		//IL_0055: Invalid comparison between I and F4
		Curve cachedCurve = CachedCurve;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S0_v3 (Curve)+1C]");
		bool flag = !(0f > z);
		bool flag2 = !flag;
		bool result = false;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S0_v3 (Curve)+28]");
			bool flag3 = !(0f < z);
			bool flag4 = !flag3;
			result = false;
			if (!flag4)
			{
				result = true;
			}
		}
		return result;
	}

	public unsafe float GetTimeForLocalZ(float z, bool clampForInvalidTime = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0181: Invalid comparison between F4 and I
		//IL_00ff: Expected Ref, but got F4
		//IL_01ee: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		Curve cachedCurve = CachedCurve;
		if (HasTimeForLocalZ(z))
		{
			if (!_forceLinearZ)
			{
				float num = default;
				float num3 = default;
				while (!(num > 1f))
				{
					float num2 = cachedCurve.curveZ.Evaluate(num);
					if (!(num2 < z))
					{
						return num;
					}
					num = num3 + 1E-05f;
				}
				float result = default;
				return result;
			}
		}
		else
		{
			if (clampForInvalidTime)
			{
				Keyframe[] keys = cachedCurve.curveZ.keys;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v17 (UnityEngine.Keyframe[])+14]");
				bool flag = z < 0f;
				float result2 = 0f;
				if (!flag)
				{
					result2 = 1f;
				}
				return result2;
			}
			float num4 = (float)obj + 12f;
			string text = ((float*)num4)->ToString();
			string message = "CurveParent.GetTimeForZ(" + text + ") failed. Use CurveParent.HasTimeForZ() first.";
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Exception ex = default;
			ex._002Ector(message);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
		float num5 = z;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S2_v2 (Curve)+1C]");
		float num6 = num5 - 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S2_v2 (Curve)+28]");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S2_v2 (Curve)+1C]");
		object obj3 = num7 - 0;
		return num6 / (float)obj3;
	}

	public float GetTimeForWorldZ(float z, bool clampForInvalidTime = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		Transform transform = base.transform;
		Vector3 position = transform.position;
		float num = z;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		float z2 = num - 0f;
		return GetTimeForLocalZ(z2, clampForInvalidTime);
	}

	public bool HasTimeForWorldZ(float z)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		if (this != null)
		{
			Transform transform = base.transform;
			if (transform != null)
			{
				Transform transform2 = base.transform;
				Vector3 position = transform2.position;
				float num = z;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				float z2 = num - 0f;
				return HasTimeForLocalZ(z2);
			}
		}
		bool result = default;
		return result;
	}

	public unsafe Vector3 GetWorldPositionForTime(float time, bool clampForInvalidTime = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0040: Expected F4, but got I
		//IL_003b: Expected native int or pointer, but got VT
		//IL_0055: Expected F4, but got I
		//IL_0050: Expected native int or pointer, but got VT
		//IL_007b: Expected F4, but got I
		//IL_0076: Expected native int or pointer, but got VT
		//IL_0090: Expected F4, but got I
		//IL_008b: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 48);
		Transform transform = base.transform;
		Vector3 localPositionForTime = GetLocalPositionForTime(time);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
		((Vector3*)(nint)vector)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
		((Vector3*)(nint)vector)->x = 0f;
		Vector3 vector2 = transform.TransformPoint(vector);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
		Vector3 vector3 = default;
		((Vector3*)(nint)vector3)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
		((Vector3*)(nint)vector3)->x = 0f;
		return vector3;
	}

	public void ForceLinearZ(bool v)
	{
		_forceLinearZ = v;
		RecacheCurve();
	}

	public string GetDebugText()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 96;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}

	public void RecacheCurve()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0079: Expected VT, but got Obj
		object obj2 = default;
		object obj = obj2 - 32;
		Transform curvePointsParent = base.transform;
		Curve cachedCurve = CreateCurve(curvePointsParent);
		_cachedCurve = cachedCurve;
		Transform transform = base.transform;
		Vector3 localPosition = transform.localPosition;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		_localPositionAtCaching = (Vector3)obj;
		if (~(_forceLinearZ ? 1u : 0u) == 0)
		{
			LinearizeZ();
		}
	}

	private void LinearizeZ()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0043: Expected Obj, but got I
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected Obj, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected Obj, but got Unknown
		//IL_0133: Expected Obj, but got F4
		//IL_016a: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 128;
		float minTime = MinTime;
		Vector3 vector = _cachedCurve.Evaluate(minTime);
		float maxTime = MaxTime;
		Vector3 vector2 = _cachedCurve.Evaluate(maxTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
		object obj3 = num - 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
		_ = 0;
		_ = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+78]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+70]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+60]");
		_ = 0;
		object obj4 = obj + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @62F");
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		object obj5 = obj - -64;
		_ = 0;
		_ = 0;
		_ = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
		_ = 0;
		obj5 = 1f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+58]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+50]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+40]");
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @62F");
		Curve cachedCurve = _cachedCurve;
		Keyframe[] keys = default;
		cachedCurve.curveZ.keys = keys;
	}

	private unsafe static Curve CreateCurve(Transform curvePointsParent, Vector3 offset)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected Obj, but got Unknown
		//IL_003e: Expected Obj, but got I
		//IL_004f: Expected Obj, but got I
		//IL_00ca: Expected Obj, but got I
		//IL_00df: Expected Obj, but got I
		//IL_00f9: Expected Obj, but got I
		//IL_011c: Expected Obj, but got I
		//IL_0132: Expected Obj, but got I
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected VT, but got Unknown
		//IL_0174: Expected Obj, but got I
		//IL_01a7: Expected Obj, but got I
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected Obj, but got Unknown
		//IL_01d9: Expected Obj, but got I
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected Obj, but got Unknown
		//IL_020b: Expected Obj, but got I
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected Obj, but got Unknown
		//IL_0231: Expected Obj, but got I
		//IL_024b: Expected Obj, but got I
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Expected VT, but got Unknown
		//IL_029e: Expected Obj, but got I
		//IL_02d1: Expected Obj, but got I
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Expected Obj, but got Unknown
		//IL_0303: Expected Obj, but got I
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Expected Obj, but got Unknown
		//IL_0335: Expected Obj, but got I
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_034a: Expected Obj, but got Unknown
		//IL_0388: Expected F4, but got I
		//IL_0383: Expected native int or pointer, but got VT
		//IL_03d5: Expected F4, but got I
		//IL_03d0: Expected native int or pointer, but got VT
		//IL_03de: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Expected VT, but got Unknown
		//IL_03ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f1: Expected VT, but got Unknown
		//IL_0412: Expected F4, but got I
		//IL_0450: Expected F4, but got I
		object obj = default;
		Vector3 vector = (Vector3)(obj - 176);
		Curve curve = default;
		curve._002Ector();
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v31 @ S3_v3 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.Component::GetComponentsInChildren>>)+4] (should have been resolved before IL gen)");
		int num3 = default;
		object obj3 = default;
		int num14 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v11+C]");
			if ((nint)0 <= (nint)num3)
			{
				break;
			}
			int num4 = num3 << 2;
			object obj2 = obj3 + num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v20+10]");
			Component component = (Component)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v20+10]");
			Transform transform = ((Component)0).transform;
			Vector3 localPosition = transform.localPosition;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A0]");
			float num5 = 0f + offset.x;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A4]");
			float num6 = 0f + offset.y;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A8]");
			float num7 = 0f + offset.z;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v20+10]");
			Transform transform2 = ((Component)0).transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v20+10]");
			Vector3 tangentInPoint = ((CurvePoint)0).TangentInPoint;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A8]");
			object obj4 = -0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+98]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A4]");
			object obj5 = -0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A0]");
			object obj6 = -0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+90]");
			_ = 0;
			Vector3 position = vector - -64;
			Vector3 vector2 = transform2.TransformPoint(position);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v20+10]");
			Transform transform3 = ((Component)0).transform;
			Vector3 position2 = transform3.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A0]");
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A0]");
			object obj7 = num8 - 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v21 (UnityEngine.Component)+1C]");
			object obj8 = obj7 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A4]");
			nint num9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A4]");
			object obj9 = num9 - 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v21 (UnityEngine.Component)+1C]");
			object obj10 = obj9 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A8]");
			nint num10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A8]");
			object obj11 = num10 - 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v21 (UnityEngine.Component)+1C]");
			object obj12 = obj11 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v20+10]");
			Transform transform4 = ((Component)0).transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v20+10]");
			Vector3 tangentOutPoint = ((CurvePoint)0).TangentOutPoint;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A0]");
			_ = 0;
			Vector3 position3 = vector + 48;
			Vector3 vector3 = transform4.TransformPoint(position3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v20+10]");
			Transform transform5 = ((Component)0).transform;
			Vector3 position4 = transform5.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
			nint num11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
			object obj13 = num11 - 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v21 (UnityEngine.Component)+1C]");
			object obj14 = obj13 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+84]");
			nint num12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+84]");
			object obj15 = num12 - 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v21 (UnityEngine.Component)+1C]");
			object obj16 = obj15 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
			nint num13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
			object obj17 = num13 - 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v21 (UnityEngine.Component)+1C]");
			object obj18 = obj17 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+78]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
			((Vector3*)(nint)vector)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+70]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
			((Vector3*)(nint)vector)->x = 0f;
			Vector3 value = vector + 32;
			Vector3 inTangent = vector + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v21 (UnityEngine.Component)+C]");
			curve.AddKey(0f, value, inTangent, vector);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v21 (UnityEngine.Component)+10]");
			if ((nint)0 != 0)
			{
				int index = num3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v21 (UnityEngine.Component)+1C]");
				curve.SmoothTangents(index, 0f);
			}
			num3 = num14 + 1;
		}
		return curve;
	}

	private unsafe static Curve CreateCurve(Transform curvePointsParent)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_001d: Expected native int or pointer, but got VT
		//IL_0031: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 32);
		_ = 0;
		((Vector3*)(nint)vector)->z = 0f;
		_ = 0;
		((Vector3*)(nint)vector)->x = 0f;
		return CreateCurve(curvePointsParent, vector);
	}

	private unsafe void DrawCurve(Color color)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected VT, but got Unknown
		//IL_0099: Expected Obj, but got I4
		//IL_00f2: Expected F4, but got I
		//IL_00ed: Expected native int or pointer, but got VT
		//IL_0114: Expected F4, but got I
		//IL_010f: Expected native int or pointer, but got VT
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected VT, but got Unknown
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected Obj, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj - 80);
		_ = 0;
		_ = 0;
		_ = color.b;
		_ = color.r;
		Color color2 = (Color)(vector + 32);
		Gizmos.color = color2;
		Curve cachedCurve = CachedCurve;
		Curve cachedCurve2 = CachedCurve;
		float num = cachedCurve.MaxTime__BackingField - cachedCurve2.MinTime__BackingField;
		Vector3 worldPositionForTime = GetWorldPositionForTime(0f);
		object obj2 = 0;
		while ((nint)obj2 < 13)
		{
			float num2 = num * (float)obj2;
			float time = num2 / 12f;
			Vector3 worldPositionForTime2 = GetWorldPositionForTime(time);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
			((Vector3*)(nint)vector)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
			((Vector3*)(nint)vector)->x = 0f;
			Vector3 vector2 = vector + 16;
			Gizmos.DrawLine(vector2, vector);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
			_ = 0;
			object obj3 = obj2 + 1;
			obj2 = obj3;
		}
	}

	public CurveParent()
	{
		//IL_000b: Expected VT, but got I4
		_ = 4575657221408423936L;
		base._002Ector();
	}
}
