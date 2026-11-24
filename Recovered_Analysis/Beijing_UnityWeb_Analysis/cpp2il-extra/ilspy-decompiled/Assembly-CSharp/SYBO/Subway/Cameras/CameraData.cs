using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Subway.Characters;
using UnityEngine;

namespace SYBO.Subway.Cameras;

[Serializable]
public class CameraData
{
	public static readonly CameraDataMode CAMERA_MODE_DEFAULT;

	public static readonly float FIELD_OF_VIEW_DEFAULT;

	public static readonly Vector3 CAMERA_TARGET_OFFSET_DEFAULT;

	public static readonly Vector3 CAMERA_POSITION_OFFSET_DEFAULT;

	public static readonly Vector3 CAMERA_TARGET_OFFSET_SMOOTH_TIME_DEFAULT;

	public static readonly Vector3 CAMERA_POSITION_OFFSET_SMOOTH_TIME_DEFAULT;

	public static readonly float TRANSFORM_TWEEN_DURATION;

	public static readonly float FIELD_OF_VIEW_SMOOTH_TIME_DEFAULT;

	internal CameraDataMode _cameraDataMode;

	internal bool _useLastGroundedY;

	internal bool _dontMoveInY;

	internal SmoothDampFloat _fieldOfView;

	internal Vector3 _cameraTargetOffset;

	internal Vector3 _cameraTargetOffsetSmoothTime;

	internal Vector3 _cameraPositionOffset;

	internal Vector3 _cameraPositionOffsetSmoothTime;

	private float _transformTweenDuration;

	public CameraDataMode CameraDataMode
	{
		get
		{
			//IL_0023: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			_ = 0;
			CameraDataMode cameraDataMode = default;
			object obj = cameraDataMode + 16;
			obj = this;
			return cameraDataMode;
		}
		internal set
		{
			if (value == CameraDataMode.CameraUpdateEnabled_IgnoreMe)
			{
				((CharacterRendering)this).OnApplicationPause(false);
			}
		}
	}

	public bool UseLastGroundedY => (byte)_cameraDataMode != 0;

	public bool DontMoveInY => _useLastGroundedY;

	public SmoothDampFloat FieldOfView
	{
		get
		{
			//IL_0019: Expected Obj, but got I4
			bool dontMoveInY = _dontMoveInY;
			return (SmoothDampFloat)dontMoveInY;
		}
		set
		{
			//IL_000a: Expected I4, but got Obj
			_cameraDataMode = (CameraDataMode)value;
		}
	}

	public Vector3 CameraTargetOffset
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			Vector3 vector = default;
			object obj = vector + 16;
			obj = this;
			return vector;
		}
	}

	public unsafe Vector3 CameraTargetOffsetSmoothTime
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0018: Expected F4, but got Obj
			//IL_0013: Expected native int or pointer, but got VT
			//IL_002d: Expected F4, but got I
			//IL_0028: Expected native int or pointer, but got VT
			object obj = this + 20;
			Vector3 vector = default;
			((Vector3*)(nint)vector)->x = (float)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v2+8]");
			((Vector3*)(nint)vector)->z = 0f;
			return vector;
		}
	}

	public unsafe Vector3 CameraPositionOffset
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0018: Expected F4, but got Obj
			//IL_0013: Expected native int or pointer, but got VT
			//IL_002d: Expected F4, but got I
			//IL_0028: Expected native int or pointer, but got VT
			object obj = this + 32;
			Vector3 vector = default;
			((Vector3*)(nint)vector)->x = (float)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v2+8]");
			((Vector3*)(nint)vector)->z = 0f;
			return vector;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			object obj = value + 44;
			CameraData cameraData = (CameraData)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v2+8]");
			_cameraDataMode = CameraDataMode.CameraUpdateEnabled_IgnoreMe;
		}
	}

	public unsafe Vector3 CameraPositionOffsetSmoothTime
	{
		get
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected VT, but got Unknown
			//IL_0027: Expected F4, but got Obj
			//IL_0022: Expected native int or pointer, but got VT
			//IL_003c: Expected F4, but got I
			//IL_0037: Expected native int or pointer, but got VT
			_ = _cameraDataMode;
			object obj = default;
			Vector3 vector = (Vector3)(obj + 44);
			((Vector3*)(nint)vector)->x = (float)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((Vector3*)(nint)vector)->z = 0f;
			return vector;
		}
	}

	public float TransformTweenDuration
	{
		get
		{
			//IL_0012: Expected F4, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Cameras.CameraData)+48]");
			return ((CharacterCamera)this).GetFOVForAspectRatio(0f);
		}
	}

	public CameraData()
	{
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected Obj, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected Obj, but got Unknown
		//IL_002f: Expected I, but got Obj
		//IL_0045: Expected Obj, but got I
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected Obj, but got Unknown
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected Obj, but got Unknown
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected Obj, but got Unknown
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected Obj, but got Unknown
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected Obj, but got Unknown
		//IL_0070: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		CharacterRendering.AnimationClipLists animationClipLists = default;
		animationClipLists._002Ector();
		object obj = this + 48;
		obj = animationClipLists;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<AnimationClip> list = default;
		list._002Ector();
		object obj2 = this + 144;
		obj2 = list;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v19 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		if ((object)((nint)0 & (nint)0x200) != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v42 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = default;
		object obj3 = obj4 + 12;
		Vector3 one = Vector3.one;
		object obj5 = obj4 + 24;
		obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v24+8]");
		_ = 0;
		object obj6 = this + 156;
		obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v26+8]");
		_ = 0;
		Vector3 forward = Vector3.forward;
		obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj7 = this + 168;
		obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v26+8]");
		_ = 0;
		_ = 1;
		object obj8 = this + 232;
		obj8 = "";
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}

	static CameraData()
	{
		CharacterRendering._instance = null;
		CharacterRendering._DEFAULT_SPEED_RUN_ANIMATION = 1f;
	}
}
