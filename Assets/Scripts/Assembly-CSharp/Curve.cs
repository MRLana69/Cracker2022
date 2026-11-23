using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public class Curve
{
	public AnimationCurve curveX;

	public AnimationCurve curveY;

	public AnimationCurve curveZ;

	private Vector3 MinCoords__BackingField;

	private Vector3 MaxCoords__BackingField;

	private float MinTime__BackingField;

	private float MaxTime__BackingField;

	public unsafe Vector3 MinCoords
	{
		get
		{
			//IL_000f: Expected F4, but got VT
			//IL_000a: Expected native int or pointer, but got VT
			//IL_0024: Expected F4, but got I
			//IL_001f: Expected native int or pointer, but got VT
			Vector3 vector = default;
			((Vector3*)(nint)vector)->x = (float)MinCoords__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (Curve)+1C]");
			((Vector3*)(nint)vector)->z = 0f;
			return vector;
		}
		private set
		{
			//IL_000f: Expected VT, but got F4
			MinCoords__BackingField = (Vector3)value.x;
			_ = value.z;
		}
	}

	public unsafe Vector3 MaxCoords
	{
		get
		{
			//IL_000f: Expected F4, but got VT
			//IL_000a: Expected native int or pointer, but got VT
			//IL_0024: Expected F4, but got I
			//IL_001f: Expected native int or pointer, but got VT
			Vector3 vector = default;
			((Vector3*)(nint)vector)->x = (float)MaxCoords__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (Curve)+28]");
			((Vector3*)(nint)vector)->z = 0f;
			return vector;
		}
		private set
		{
			//IL_000f: Expected VT, but got F4
			MaxCoords__BackingField = (Vector3)value.x;
			_ = value.z;
		}
	}

	public float MinTime
	{
		get
		{
			return MinTime__BackingField;
		}
		private set
		{
			MinTime__BackingField = value;
		}
	}

	public float MaxTime
	{
		get
		{
			return MaxTime__BackingField;
		}
		private set
		{
			MaxTime__BackingField = value;
		}
	}

	public Curve()
	{
		//IL_00e0: Expected I, but got Obj
		//IL_0145: Expected VT, but got F4
		//IL_0158: Expected I, but got Obj
		//IL_01bd: Expected VT, but got F4
		AnimationCurve animationCurve = default;
		animationCurve._002Ector();
		curveX = animationCurve;
		AnimationCurve animationCurve2 = default;
		animationCurve2._002Ector();
		curveY = animationCurve2;
		AnimationCurve animationCurve3 = default;
		animationCurve3._002Ector();
		curveZ = animationCurve3;
		curveX.postWrapMode = WrapMode.ClampForever;
		curveX.preWrapMode = WrapMode.ClampForever;
		curveY.postWrapMode = WrapMode.ClampForever;
		curveY.preWrapMode = WrapMode.ClampForever;
		curveZ.postWrapMode = WrapMode.ClampForever;
		curveZ.preWrapMode = WrapMode.ClampForever;
		MinTime__BackingField = float.PositiveInfinity;
		MaxTime__BackingField = float.NegativeInfinity;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v36 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		float num3 = (float)Vector3.oneVector * float.PositiveInfinity;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v37 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
		float num4 = 0f * float.PositiveInfinity;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v37 (Il2CppStaticFields<UnityEngine.Vector3>)+10]");
		float num5 = 0f * float.PositiveInfinity;
		MinCoords__BackingField = (Vector3)num3;
		nint num6 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v52 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num7 = 0;
		float num8 = (float)Vector3.oneVector * float.NegativeInfinity;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v53 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
		float num9 = 0f * float.NegativeInfinity;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v53 (Il2CppStaticFields<UnityEngine.Vector3>)+10]");
		float num10 = 0f * float.NegativeInfinity;
		MaxCoords__BackingField = (Vector3)num8;
	}

	public unsafe void AddKey(float t, Vector3 value)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00e4: Expected native int or pointer, but got VT
		//IL_00f6: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 16);
		int num = curveX.AddKey(t, value.x);
		int num2 = curveY.AddKey(t, value.y);
		int num3 = curveZ.AddKey(t, value.z);
		if (t < MinTime__BackingField)
		{
			MinTime__BackingField = t;
		}
		if (t > MaxTime__BackingField)
		{
			MaxTime__BackingField = t;
		}
		((Vector3*)(nint)vector)->z = value.z;
		((Vector3*)(nint)vector)->x = value.x;
		UpdateMinMaxCoords(vector);
	}

	public unsafe void AddKey(float t, Vector3 value, Vector3 inTangent, Vector3 outTangent)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected VT, but got Unknown
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected Obj, but got Unknown
		//IL_011c: Expected Obj, but got I
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected VT, but got Unknown
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected VT, but got Unknown
		//IL_0275: Expected native int or pointer, but got VT
		//IL_0287: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 208);
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = outTangent.x;
		_ = inTangent.x;
		_ = value.x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B0]");
		_ = 0;
		Keyframe key = (Keyframe)(vector + 80);
		int num = curveX.AddKey(key);
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = outTangent.y;
		_ = inTangent.y;
		_ = value.y;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A8]");
		_ = 0;
		object obj2 = vector - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A0]");
		obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+98]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+90]");
		_ = 0;
		Keyframe key2 = (Keyframe)(vector + 48);
		int num2 = curveY.AddKey(key2);
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = outTangent.z;
		_ = inTangent.z;
		_ = value.z;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+78]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+70]");
		_ = 0;
		Keyframe key3 = (Keyframe)(vector + 16);
		int num3 = curveZ.AddKey(key3);
		if (t < MinTime__BackingField)
		{
			MinTime__BackingField = t;
		}
		if (t > MaxTime__BackingField)
		{
			MaxTime__BackingField = t;
		}
		((Vector3*)(nint)vector)->z = value.z;
		((Vector3*)(nint)vector)->x = value.x;
		UpdateMinMaxCoords(vector);
	}

	public unsafe void MoveKey(int index, float t, Vector3 value, Vector3 inTangent, Vector3 outTangent)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected VT, but got Unknown
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected Obj, but got Unknown
		//IL_0120: Expected Obj, but got I
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected VT, but got Unknown
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Expected VT, but got Unknown
		//IL_0281: Expected native int or pointer, but got VT
		//IL_0293: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 208);
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = outTangent.x;
		_ = inTangent.x;
		_ = value.x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B0]");
		_ = 0;
		Keyframe key = (Keyframe)(vector + 80);
		int num = curveX.MoveKey(index, key);
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = outTangent.y;
		_ = inTangent.y;
		_ = value.y;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A8]");
		_ = 0;
		object obj2 = vector - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A0]");
		obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+98]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+90]");
		_ = 0;
		Keyframe key2 = (Keyframe)(vector + 48);
		int num2 = curveY.MoveKey(index, key2);
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = outTangent.z;
		_ = inTangent.z;
		_ = value.z;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+78]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+70]");
		_ = 0;
		Keyframe key3 = (Keyframe)(vector + 16);
		int num3 = curveZ.MoveKey(index, key3);
		if (t < MinTime__BackingField)
		{
			MinTime__BackingField = t;
		}
		if (t > MaxTime__BackingField)
		{
			MaxTime__BackingField = t;
		}
		((Vector3*)(nint)vector)->z = value.z;
		((Vector3*)(nint)vector)->x = value.x;
		UpdateMinMaxCoords(vector);
	}

	public unsafe void MoveKey(int index, float t, Vector3 value)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected VT, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected Obj, but got Unknown
		//IL_0104: Expected Obj, but got I
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected VT, but got Unknown
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected VT, but got Unknown
		//IL_0257: Expected native int or pointer, but got VT
		//IL_0269: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 208);
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = value.x;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B0]");
		_ = 0;
		Keyframe key = (Keyframe)(vector + 80);
		int num = curveX.MoveKey(index, key);
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = value.y;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A8]");
		_ = 0;
		object obj2 = vector - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A0]");
		obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+98]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+90]");
		_ = 0;
		Keyframe key2 = (Keyframe)(vector + 48);
		int num2 = curveY.MoveKey(index, key2);
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = value.z;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+78]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+70]");
		_ = 0;
		Keyframe key3 = (Keyframe)(vector + 16);
		int num3 = curveZ.MoveKey(index, key3);
		if (t < MinTime__BackingField)
		{
			MinTime__BackingField = t;
		}
		if (t > MaxTime__BackingField)
		{
			MaxTime__BackingField = t;
		}
		((Vector3*)(nint)vector)->z = value.z;
		((Vector3*)(nint)vector)->x = value.x;
		UpdateMinMaxCoords(vector);
	}

	public void SmoothTangents(int index, float weight)
	{
		curveX.SmoothTangents(index, weight);
		curveY.SmoothTangents(index, weight);
		curveZ.SmoothTangents(index, weight);
	}

	public unsafe Vector3 Evaluate(float t)
	{
		//IL_0046: Expected native int or pointer, but got VT
		//IL_0053: Expected native int or pointer, but got VT
		//IL_0060: Expected native int or pointer, but got VT
		float x = curveX.Evaluate(t);
		float y = curveY.Evaluate(t);
		float z = curveZ.Evaluate(t);
		Vector3 vector = default;
		((Vector3*)(nint)vector)->z = z;
		((Vector3*)(nint)vector)->y = y;
		((Vector3*)(nint)vector)->x = x;
		return vector;
	}

	public unsafe Vector3 EvaluateDerivative(float t)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0865: Expected I, but got Obj
		//IL_087e: Expected Obj, but got I4
		//IL_057f: Expected Obj, but got I
		//IL_058f: Expected Obj, but got I
		//IL_05a8: Expected Obj, but got I
		//IL_05b8: Expected Obj, but got I
		//IL_05d1: Expected Obj, but got I
		//IL_05e1: Expected Obj, but got I
		//IL_05fa: Expected Obj, but got I
		//IL_060a: Expected Obj, but got I
		//IL_0890: Expected Obj, but got VT
		//IL_08d1: Expected Obj, but got VT
		//IL_091f: Expected Obj, but got VT
		//IL_096d: Expected Obj, but got VT
		//IL_09b7: Invalid comparison between Obj and F4
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected Obj, but got Unknown
		//IL_079d: Expected native int or pointer, but got VT
		//IL_0813: Expected native int or pointer, but got VT
		//IL_084d: Expected native int or pointer, but got VT
		//IL_011a: Invalid comparison between F4 and I
		//IL_0a1c: Expected I, but got Obj
		//IL_0a3a: Expected F4, but got VT
		//IL_0a35: Expected native int or pointer, but got VT
		//IL_0a4f: Expected F4, but got I
		//IL_0a4a: Expected native int or pointer, but got VT
		//IL_055d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0562: Expected Obj, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected Obj, but got Unknown
		//IL_0152: Invalid comparison between F4 and Obj
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected Obj, but got Unknown
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected Obj, but got Unknown
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected Obj, but got Unknown
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Expected Obj, but got Unknown
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Expected Obj, but got Unknown
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Expected Obj, but got Unknown
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Expected Obj, but got Unknown
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Expected Obj, but got Unknown
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected Obj, but got Unknown
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Expected Obj, but got Unknown
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected Obj, but got Unknown
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Expected Obj, but got Unknown
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Expected Obj, but got Unknown
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Expected Obj, but got Unknown
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Expected Obj, but got Unknown
		//IL_0340: Unknown result type (might be due to invalid IL or missing references)
		//IL_0345: Expected Obj, but got Unknown
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0362: Expected Obj, but got Unknown
		//IL_0378: Unknown result type (might be due to invalid IL or missing references)
		//IL_037d: Expected Obj, but got Unknown
		//IL_039a: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Expected Obj, but got Unknown
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ba: Expected Obj, but got Unknown
		//IL_03d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d7: Expected Obj, but got Unknown
		//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f2: Expected Obj, but got Unknown
		//IL_040f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0414: Expected Obj, but got Unknown
		//IL_042a: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Expected Obj, but got Unknown
		//IL_044f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0454: Expected Obj, but got Unknown
		//IL_0464: Unknown result type (might be due to invalid IL or missing references)
		//IL_0469: Expected Obj, but got Unknown
		//IL_0497: Expected Obj, but got I
		//IL_04a7: Expected Obj, but got I
		//IL_04b7: Expected VT, but got I
		//IL_04c7: Expected Obj, but got I
		//IL_04d7: Expected Obj, but got I
		//IL_04e7: Expected VT, but got I
		//IL_04f7: Expected Obj, but got I
		//IL_0507: Expected Obj, but got I
		//IL_0517: Expected VT, but got I
		//IL_0527: Expected Obj, but got I
		//IL_0537: Expected Obj, but got I
		//IL_0547: Expected VT, but got I
		object obj2 = default;
		object obj = obj2 - 128;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		float num2 = default;
		float num = num2 * num2;
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v18 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num4 = 0;
		object obj3 = 1;
		float num7 = default;
		object obj45;
		object obj46;
		Vector3 vector;
		object obj47;
		object obj48;
		Vector3 vector2;
		object obj49;
		object obj50;
		Vector3 vector3;
		object obj51;
		object obj52;
		Vector3 vector4;
		float num9;
		while (true)
		{
			Keyframe[] keys = curveZ.keys;
			if (keys.Length > (nint)obj3)
			{
				object obj4 = obj + 32;
				Keyframe[] keys2 = curveZ.keys;
				object obj5 = obj3 - 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1643");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
				_ = 0;
				Keyframe[] keys3 = curveZ.keys;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1643");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+60]");
				if (!(num2 < 0f))
				{
					object obj6 = obj - -64;
					if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6))
					{
						Keyframe[] keys4 = curveX.keys;
						object obj7 = obj3 * 28;
						object obj8 = (object)keys4 + obj7;
						object obj9 = obj8 - 12;
						Keyframe[] keys5 = curveY.keys;
						object obj10 = obj3 * 28;
						object obj11 = (object)keys5 + obj10;
						object obj12 = obj11 - 12;
						Keyframe[] keys6 = curveZ.keys;
						object obj13 = obj3 * 28;
						object obj14 = (object)keys6 + obj13;
						object obj15 = obj14 - 12;
						Keyframe[] keys7 = curveX.keys;
						object obj16 = obj3 * 28;
						object obj17 = (object)keys7 + obj16;
						object obj18 = obj17 + 16;
						Keyframe[] keys8 = curveY.keys;
						object obj19 = obj3 * 28;
						object obj20 = (object)keys8 + obj19;
						object obj21 = obj20 + 16;
						Keyframe[] keys9 = curveZ.keys;
						object obj22 = obj3 * 28;
						object obj23 = (object)keys9 + obj22;
						object obj24 = obj23 + 16;
						Keyframe[] keys10 = curveX.keys;
						object obj25 = obj3 * 28;
						object obj26 = (object)keys10 + obj25;
						object obj27 = obj26 - 12;
						Keyframe[] keys11 = curveY.keys;
						object obj28 = obj3 * 28;
						object obj29 = (object)keys11 + obj28;
						object obj30 = obj29 - 12;
						Keyframe[] keys12 = curveZ.keys;
						object obj31 = obj3 * 28;
						object obj32 = (object)keys12 + obj31;
						object obj33 = obj32 - 12;
						Keyframe[] keys13 = curveX.keys;
						object obj34 = obj3 * 28;
						object obj35 = (object)keys13 + obj34;
						object obj36 = obj35 + 16;
						Keyframe[] keys14 = curveY.keys;
						object obj37 = obj3 * 28;
						object obj38 = (object)keys14 + obj37;
						object obj39 = obj38 + 16;
						Keyframe[] keys15 = curveZ.keys;
						object obj40 = obj3 * 28;
						object obj41 = (object)keys15 + obj40;
						object obj42 = obj41 + 16;
						float num5 = num2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+60]");
						float num6 = num5 - 0f;
						object obj43 = obj - -64;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+60]");
						object obj44 = obj43 - 0;
						num7 = num6 / (float)obj44;
						float num8 = num7 * num7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v479 @ S0_v156+8]");
						obj45 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ S0_v150+8]");
						obj46 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ S0_v144+8]");
						vector = (Vector3)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ S0_v138+C]");
						obj47 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ S0_v132+C]");
						obj48 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ S0_v126+C]");
						vector2 = (Vector3)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ S0_v120+4]");
						obj49 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ S0_v114+4]");
						obj50 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ S0_v108+4]");
						vector3 = (Vector3)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ S0_v102+4]");
						obj51 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ S0_v96+4]");
						obj52 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ S0_v90+4]");
						vector4 = (Vector3)0;
						num9 = num8;
						break;
					}
				}
				object obj53 = obj3 + 1;
				obj3 = obj53;
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v19 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
			obj45 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v19 (Il2CppStaticFields<UnityEngine.Vector3>)+4]");
			obj46 = 0;
			vector = Vector3.zeroVector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v19 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
			obj47 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v19 (Il2CppStaticFields<UnityEngine.Vector3>)+4]");
			obj48 = 0;
			vector2 = Vector3.zeroVector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v19 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
			obj49 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v19 (Il2CppStaticFields<UnityEngine.Vector3>)+4]");
			obj50 = 0;
			vector3 = Vector3.zeroVector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v19 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
			obj51 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v19 (Il2CppStaticFields<UnityEngine.Vector3>)+4]");
			obj52 = 0;
			vector4 = Vector3.zeroVector;
			num9 = num;
			break;
		}
		object obj54 = vector4 * vector4;
		object obj55 = obj52 * obj52;
		object obj56 = obj54 + obj55;
		object obj57 = obj51 * obj51;
		object obj58 = obj56 + obj57;
		object obj59 = vector3 * vector3;
		object obj60 = obj50 * obj50;
		object obj61 = obj59 + obj60;
		object obj62 = obj49 * obj49;
		object obj63 = obj61 + obj62;
		object obj64 = obj58 + obj63;
		object obj65 = vector2 * vector2;
		object obj66 = obj48 * obj48;
		object obj67 = obj65 + obj66;
		object obj68 = obj47 * obj47;
		object obj69 = obj67 + obj68;
		object obj70 = obj64 + obj69;
		object obj71 = vector * vector;
		object obj72 = obj46 * obj46;
		object obj73 = obj71 + obj72;
		object obj74 = obj45 * obj45;
		object obj75 = obj73 + obj74;
		object obj76 = obj70 + obj75;
		Vector3 vector5 = default;
		if (obj76 != (object)0f)
		{
			float num10 = num9 * 6f;
			float num11 = num7 * 6f;
			float num12 = num10 - num11;
			float num13 = (float)vector4 * num12;
			float num14 = num9 * 3f;
			float num15 = num7 * 4f;
			float num16 = num14 - num15;
			float num17 = num16 + 1f;
			float num18 = (float)vector2 * num17;
			float num19 = num9 * -6f;
			float num20 = num7 * 6f;
			float num21 = num19 + num20;
			float num22 = (float)vector3 * num21;
			float num23 = num9 * 3f;
			float num24 = num7 + num7;
			float num25 = num23 - num24;
			float num26 = (float)vector * num25;
			float num27 = (float)obj51 * num12;
			float num28 = (float)obj47 * num17;
			float num29 = num27 + num28;
			float num30 = (float)obj49 * num21;
			float num31 = num29 + num30;
			float num32 = (float)obj45 * num25;
			float z = num31 + num32;
			((Vector3*)(nint)vector5)->z = z;
			float num33 = (float)obj52 * num12;
			float num34 = (float)obj48 * num17;
			float num35 = num33 + num34;
			float num36 = (float)obj50 * num21;
			float num37 = num35 + num36;
			float num38 = (float)obj46 * num25;
			float y = num37 + num38;
			((Vector3*)(nint)vector5)->y = y;
			float num39 = num13 + num18;
			float num40 = num39 + num22;
			float x = num40 + num26;
			((Vector3*)(nint)vector5)->x = x;
		}
		else
		{
			nint num41 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ S1_v65 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num42 = 0;
			((Vector3*)(nint)vector5)->x = (float)Vector3.zeroVector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ S1_v66 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
			((Vector3*)(nint)vector5)->z = 0f;
		}
		return vector5;
	}

	public unsafe void DrawGizmos(Color color)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected VT, but got Unknown
		//IL_0062: Expected Obj, but got I4
		//IL_00c9: Expected F4, but got I
		//IL_00c4: Expected native int or pointer, but got VT
		//IL_00eb: Expected F4, but got I
		//IL_00e6: Expected native int or pointer, but got VT
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected VT, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected Obj, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj - 80);
		_ = 0;
		_ = 0;
		_ = color.b;
		_ = color.r;
		Color color2 = (Color)(vector + 32);
		Gizmos.color = color2;
		Vector3 vector2 = Evaluate(0f);
		object obj2 = 0;
		while ((nint)obj2 < 1000)
		{
			float num = MaxTime__BackingField - MinTime__BackingField;
			float num2 = num * (float)obj2;
			float t = num2 / 999f;
			Vector3 vector3 = Evaluate(t);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
			((Vector3*)(nint)vector)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
			((Vector3*)(nint)vector)->x = 0f;
			Vector3 vector4 = vector + 16;
			Gizmos.DrawLine(vector4, vector);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
			_ = 0;
			object obj3 = obj2 + 1;
			obj2 = obj3;
		}
	}

	private void UpdateMinMaxTime(float t)
	{
		if (t < MinTime__BackingField)
		{
			MinTime__BackingField = t;
		}
		if (t > MaxTime__BackingField)
		{
			MaxTime__BackingField = t;
		}
	}

	private void UpdateMinMaxCoords(Vector3 v)
	{
		//IL_000f: Invalid comparison between F4 and VT
		//IL_001f: Expected F4, but got VT
		//IL_00a3: Expected VT, but got F4
		//IL_00b2: Invalid comparison between F4 and VT
		//IL_00c2: Expected F4, but got VT
		//IL_0156: Expected VT, but got F4
		//IL_0166: Expected F4, but got I
		//IL_017b: Invalid comparison between I and F4
		//IL_00e5: Expected F4, but got I
		//IL_00fa: Invalid comparison between I and F4
		//IL_01a4: Expected F4, but got I
		//IL_01b9: Invalid comparison between I and F4
		//IL_0123: Expected F4, but got I
		//IL_0138: Invalid comparison between I and F4
		bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)v.x) > System.Runtime.CompilerServices.Unsafe.As<Vector3, UIntPtr>(ref MinCoords__BackingField);
		float num = (float)MinCoords__BackingField;
		if (!flag)
		{
			num = v.x;
		}
		MinCoords__BackingField = (Vector3)num;
		bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)v.x) < System.Runtime.CompilerServices.Unsafe.As<Vector3, UIntPtr>(ref MaxCoords__BackingField);
		float num2 = (float)MaxCoords__BackingField;
		if (!flag2)
		{
			num2 = v.x;
		}
		MaxCoords__BackingField = (Vector3)num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Curve)+1C]");
		float num3 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Curve)+1C]");
		if (!(0f < v.z))
		{
			num3 = v.z;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Curve)+18]");
		float num4 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Curve)+18]");
		if (!(0f < v.y))
		{
			num4 = v.y;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Curve)+24]");
		float num5 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Curve)+24]");
		if (!(0f > v.y))
		{
			num5 = v.y;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Curve)+28]");
		float num6 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Curve)+28]");
		if (!(0f > v.z))
		{
			num6 = v.z;
		}
	}
}
