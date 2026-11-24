using System;
using Cpp2ILInjected;
using Data.Save;
using Info;
using SYBO.Subway;
using UnityEngine;
using UnityEngine.UI;

public class CurveParent : MonoBehaviour
{
	private bool _disableGizmos;

	public Color color;

	private Vector3 _localPositionAtCaching;

	private Curve _cachedCurve;

	private bool _forceLinearZ;

	public float MaxTime
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0010: Expected F4, but got Obj
			object obj = this - -64;
			return (float)obj;
		}
	}

	public float MinTime
	{
		get
		{
			//IL_0017: Expected F4, but got I
			string debugText = GetDebugText();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.String)+30]");
			return 0f;
		}
	}

	public Curve CachedCurve
	{
		get
		{
			//IL_0006: Expected Obj, but got I4
			return (Curve)1;
		}
	}

	public void OnDrawGizmos()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0099: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(SaveMeManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SaveMeManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SaveMeManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<SaveMeManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SaveMeManager.ReviveCountInCurrentRun__BackingField = (int)this;
	}

	public Quaternion GetRotationForTime(float time, float timeOffset = 0.25f)
	{
		float time2 = ScrollRect.RubberDelta(time, timeOffset);
		((AudioSource)(object)this).time = time2;
		((AudioSource)(object)this).Stop();
		Quaternion result = default;
		return result;
	}

	public Vector3 GetDerivativeForTime(float time)
	{
		((CharacterController)(object)this).height = time;
		Vector3 result = default;
		return result;
	}

	public Vector3 GetLocalPositionForTime(float time)
	{
		//IL_001b: Expected VT, but got Obj
		//IL_001b: Expected Obj, but got VT
		string debugText = GetDebugText();
		Vector3 vector = default;
		((SmoothDampVector3)vector)._002Ector((Vector3)debugText, time);
		return vector;
	}

	public bool HasTimeForLocalZ(float z)
	{
		//IL_0023: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		bool flag = default;
		object obj = (flag ? 1 : 0) + 20;
		obj = this;
		return flag;
	}

	public float GetTimeForLocalZ(float z, bool clampForInvalidTime = false)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		return 0f;
	}

	public float GetTimeForWorldZ(float z, bool clampForInvalidTime = false)
	{
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Expected Obj, but got Unknown
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Expected Obj, but got Unknown
		//IL_01f7: Expected Obj, but got I
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected Obj, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected Obj, but got Unknown
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected Obj, but got Unknown
		//IL_0182: Expected Obj, but got I
		//IL_0094: Expected Obj, but got F4
		//IL_00d1: Expected I4, but got Obj
		//IL_002f: Expected Obj, but got I
		//IL_0041: Expected Obj, but got I4
		//IL_0051: Invalid comparison between I and F4
		object obj2 = default;
		object obj = obj2 + 24;
		string debugText = GetDebugText();
		if (!HasTimeForWorldZ(z))
		{
			if (clampForInvalidTime)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v11 (System.String)+10]");
				int length = ((AnimationCurve)0).length;
				object obj3 = length + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v63+4]");
				if (0f > z)
				{
					return 0f;
				}
				return 1f;
			}
			obj = z;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			string text2 = default;
			string text = "CurveParent.GetTimeForZ(" + text2 + ") failed. Use CurveParent.HasTimeForZ() first.";
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Exception ex = default;
			ex.SetErrorCode((int)text);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		object obj4 = obj2 + 12;
		float num5 = default;
		if (~(_forceLinearZ ? 1u : 0u) == 0)
		{
			object obj5 = debugText + 20;
			obj = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S1_v15+8]");
			_ = 0;
			object obj6 = debugText + 32;
			obj4 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S1_v20+8]");
			_ = 0;
			object obj7 = debugText + 20;
			obj2 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S1_v25+8]");
			_ = 0;
			float num = z;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			float num2 = num - 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v17+8]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			object obj8 = num3 - 0;
			float num4 = num2 / (float)obj8;
			num5 = num4;
		}
		else
		{
			while (true)
			{
				if (num5 > 1f)
				{
					num5 = 0f;
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v11 (System.String)+10]");
				float num6 = PlayerPrefs.GetFloat((string)0, num5);
				if (!(num6 < z))
				{
					break;
				}
				float num7 = num5 + 1E-05f;
				num5 = num7;
			}
		}
		return num5;
	}

	public bool HasTimeForWorldZ(float z)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected Obj, but got Unknown
		//IL_003d: Invalid comparison between I and F4
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected Obj, but got Unknown
		//IL_0092: Invalid comparison between I and F4
		string debugText = GetDebugText();
		object obj = debugText + 20;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S1_v4+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		if (!(0f > z))
		{
			object obj3 = debugText + 32;
			obj2 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S1_v12+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			return !(0f < z);
		}
		return false;
	}

	public Vector3 GetWorldPositionForTime(float time, bool clampForInvalidTime = false)
	{
		//IL_00cc: Expected I, but got Obj
		//IL_00e2: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0114: Expected Obj, but got I4
		//IL_0114: Expected Obj, but got I
		//IL_0099: Expected Obj, but got VT
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected Obj, but got Unknown
		nint num = (nint)typeof(Settings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.Settings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Settings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v24 (Il2CppClass<Info.Settings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector = default;
		if (PreferencesSave.topRunChallengersEnabled)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+18]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				SprayDetectionAwaker sprayDetectionAwaker = default;
				sprayDetectionAwaker.CheckScreen((string)vector);
				object obj2 = vector + 24;
				obj2 = sprayDetectionAwaker;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+18]");
			((Sound)0)._002Ector((So)clampForInvalidTime);
		}
		return vector;
	}

	public void ForceLinearZ(bool v)
	{
		//IL_013c: Expected I, but got Obj
		//IL_0152: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0182: Expected Obj, but got I4
		//IL_0194: Expected I, but got Obj
		//IL_01aa: Expected Obj, but got I
		//IL_01e0: Expected Obj, but got I
		//IL_01fd: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		nint num = (nint)typeof(RunnerAnimation);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<RunnerAnimation>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(RunnerAnimation);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v40 (Il2CppClass<RunnerAnimation>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(RunnerAnimation.addedListeners ? 1u : 0u) == 0)
		{
			return;
		}
		nint num3 = (nint)typeof(RunnerAnimation);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v16 (Il2CppClass<RunnerAnimation>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(RunnerAnimation);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v34 (Il2CppClass<RunnerAnimation>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		RunnerAnimation.addedListeners = true;
		AnimationClip clip = ((Animation)v).clip;
		nint num5 = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v25 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v30 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isInstantiated = Game.IsInstantiated;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S3_v3 (System.Boolean)+58]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S3_v3 (System.Boolean)+44]");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S4_v3+8]");
		object obj5 = num7 / 0;
		float num8 = (float)obj5 - 1f;
		float num9 = num8 * (float)(_disableGizmos ? 1 : 0);
		float num10 = 1f + num9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9414");
	}

	public unsafe string GetDebugText()
	{
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected VT, but got Unknown
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected VT, but got Unknown
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected Obj, but got Unknown
		//IL_001c: Expected VT, but got Obj
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected Obj, but got Unknown
		//IL_004f: Expected I, but got Obj
		//IL_0065: Expected Obj, but got I
		//IL_013c: Expected F4, but got Obj
		//IL_0137: Expected native int or pointer, but got VT
		//IL_014e: Expected F4, but got I
		//IL_0149: Expected native int or pointer, but got VT
		//IL_015b: Expected F4, but got Obj
		//IL_0156: Expected native int or pointer, but got VT
		//IL_0170: Expected F4, but got I
		//IL_016b: Expected native int or pointer, but got VT
		//IL_0090: Expected I, but got Obj
		object obj = default;
		Quaternion quaternion = (Quaternion)(obj + 36);
		Quaternion quaternion2 = (Quaternion)(obj + 24);
		Transform transform = (Transform)(obj + 12);
		if (_cachedCurve != null)
		{
			GameObject gameObject = base.gameObject;
			transform.localPosition = (Vector3)gameObject;
			object obj2 = this + 32;
			obj = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S1_v13+8]");
			_ = 0;
			nint num = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v26 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num2 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v36 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Quaternion*)(nint)quaternion2)->x = (float)transform;
			((Quaternion*)(nint)quaternion2)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
			((Quaternion*)(nint)quaternion)->x = (float)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((Quaternion*)(nint)quaternion)->z = 0f;
			if (!(quaternion2 == quaternion))
			{
				goto IL_00df;
			}
		}
		LinearizeZ();
		goto IL_00df;
		IL_00df:
		return (string)(object)_cachedCurve;
	}

	public void RecacheCurve()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected Obj, but got Unknown
		object obj = default;
		CurvePoint curvePoint = (CurvePoint)(obj + 16);
		if (~(_disableGizmos ? 1u : 0u) != 0)
		{
			object obj2 = this + 16;
			obj = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S1_v5+8]");
			_ = 0;
			curvePoint = (CurvePoint)obj;
			CurvePoint curvePoint2 = curvePoint;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((UnityEngine.Object)curvePoint2).m_CachedPtr = (IntPtr)0;
			Vector3 tangentInPoint = curvePoint.TangentInPoint;
		}
	}

	private void LinearizeZ()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0046: Expected VT, but got Obj
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected Obj, but got Unknown
		object obj = this + 44;
		GameObject gameObject = base.gameObject;
		string text = ((CurvePoint)(object)gameObject).GetName();
		obj = text;
		GameObject gameObject2 = base.gameObject;
		Transform transform = default;
		transform.localPosition = (Vector3)gameObject2;
		object obj2 = transform + 12;
		obj2 = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		object obj3 = this + 32;
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v8+8]");
		_ = 0;
		if (~(_forceLinearZ ? 1u : 0u) == 0)
		{
			this._002Ector();
		}
	}

	private static Curve CreateCurve(Transform curvePointsParent, Vector3 offset)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected Obj, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected Obj, but got Unknown
		//IL_0045: Expected Obj, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Curve curve = default;
		curve.curveX = null;
		object obj = curve + 20;
		obj = curvePointsParent;
		object obj2 = curve + 16;
		obj2 = offset;
		return curve;
	}

	private static Curve CreateCurve(Transform curvePointsParent)
	{
		//IL_04ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f2: Expected Obj, but got Unknown
		//IL_04fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0500: Expected Obj, but got Unknown
		//IL_0509: Unknown result type (might be due to invalid IL or missing references)
		//IL_050e: Expected Obj, but got Unknown
		//IL_0517: Unknown result type (might be due to invalid IL or missing references)
		//IL_051c: Expected Obj, but got Unknown
		//IL_0525: Unknown result type (might be due to invalid IL or missing references)
		//IL_052a: Expected Obj, but got Unknown
		//IL_0533: Unknown result type (might be due to invalid IL or missing references)
		//IL_0538: Expected Obj, but got Unknown
		//IL_0541: Expected Obj, but got I4
		//IL_0550: Unknown result type (might be due to invalid IL or missing references)
		//IL_0555: Expected Obj, but got Unknown
		//IL_055e: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 52;
		object obj3 = obj2 + 48;
		object obj4 = obj2 + 36;
		object obj5 = obj2 + 24;
		Transform transform = (Transform)(obj2 + 12);
		object obj6 = obj2 + 164;
		obj6 = 0;
		_ = 0;
		object obj7 = obj2 + 136;
		obj7 = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		throw new ArrayTypeMismatchException();
	}

	private void DrawCurve(Color color)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected I4, but got Unknown
		bool forceLinearZ = (byte)(color & 1) != 0;
		_forceLinearZ = forceLinearZ;
		LinearizeZ();
	}

	public CurveParent()
	{
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected Obj, but got Unknown
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected Obj, but got Unknown
		//IL_0035: Expected Obj, but got I
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected Obj, but got Unknown
		//IL_005b: Expected Obj, but got I4
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected Obj, but got Unknown
		//IL_00cc: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 68;
		float metersInCurrentGame = ((GameStats)(object)this).MetersInCurrentGame;
		Vector3 vector = _cachedCurve.EvaluateDerivative(metersInCurrentGame);
		object obj3 = obj2 + 56;
		float minTime = MinTime;
		Vector3 vector2 = _cachedCurve.EvaluateDerivative(minTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v13+8]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		object obj4 = num - 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj5 = obj2 + 28;
		obj5 = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F64A");
		object obj6 = obj2 + 80;
		obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v21+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v21+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v21+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @752D");
		obj2 = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F64A");
		obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @752D");
		Curve cachedCurve = _cachedCurve;
		Keyframe[] keys = default;
		cachedCurve.curveZ.SetKeys(keys);
	}
}
