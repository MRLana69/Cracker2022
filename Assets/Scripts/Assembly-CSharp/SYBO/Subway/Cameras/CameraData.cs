using System;
using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Subway.Cameras;

[Serializable]
public class CameraData
{
	public static readonly CameraDataMode CAMERA_MODE_DEFAULT = CameraDataMode.CameraUpdateEnabled_IgnoreMe;

	public static readonly float FIELD_OF_VIEW_DEFAULT = 40f;

	public static readonly Vector3 CAMERA_TARGET_OFFSET_DEFAULT;

	public static readonly Vector3 CAMERA_POSITION_OFFSET_DEFAULT;

	public static readonly Vector3 CAMERA_TARGET_OFFSET_SMOOTH_TIME_DEFAULT;

	public static readonly Vector3 CAMERA_POSITION_OFFSET_SMOOTH_TIME_DEFAULT;

	public static readonly float TRANSFORM_TWEEN_DURATION;

	public static readonly float FIELD_OF_VIEW_SMOOTH_TIME_DEFAULT;

	internal CameraDataMode _cameraDataMode = CAMERA_MODE_DEFAULT;

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
			return _cameraDataMode;
		}
		internal set
		{
			_cameraDataMode = value;
		}
	}

	public bool UseLastGroundedY => _useLastGroundedY;

	public bool DontMoveInY => _dontMoveInY;

	public SmoothDampFloat FieldOfView
	{
		get
		{
			return _fieldOfView;
		}
		set
		{
			_fieldOfView = value;
		}
	}

	public unsafe Vector3 CameraTargetOffset
	{
		get
		{
			//IL_000f: Expected F4, but got VT
			//IL_000a: Expected native int or pointer, but got VT
			//IL_0024: Expected F4, but got I
			//IL_001f: Expected native int or pointer, but got VT
			Vector3 vector = default;
			((Vector3*)(nint)vector)->x = (float)_cameraTargetOffset;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (SYBO.Subway.Cameras.CameraData)+1C]");
			((Vector3*)(nint)vector)->z = 0f;
			return vector;
		}
	}

	public unsafe Vector3 CameraTargetOffsetSmoothTime
	{
		get
		{
			//IL_000f: Expected F4, but got VT
			//IL_000a: Expected native int or pointer, but got VT
			//IL_0024: Expected F4, but got I
			//IL_001f: Expected native int or pointer, but got VT
			Vector3 vector = default;
			((Vector3*)(nint)vector)->x = (float)_cameraTargetOffsetSmoothTime;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (SYBO.Subway.Cameras.CameraData)+28]");
			((Vector3*)(nint)vector)->z = 0f;
			return vector;
		}
	}

	public unsafe Vector3 CameraPositionOffset
	{
		get
		{
			//IL_000f: Expected F4, but got VT
			//IL_000a: Expected native int or pointer, but got VT
			//IL_0024: Expected F4, but got I
			//IL_001f: Expected native int or pointer, but got VT
			Vector3 vector = default;
			((Vector3*)(nint)vector)->x = (float)_cameraPositionOffset;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (SYBO.Subway.Cameras.CameraData)+34]");
			((Vector3*)(nint)vector)->z = 0f;
			return vector;
		}
		set
		{
			//IL_000f: Expected VT, but got F4
			_cameraPositionOffset = (Vector3)value.x;
			_ = value.z;
		}
	}

	public unsafe Vector3 CameraPositionOffsetSmoothTime
	{
		get
		{
			//IL_000f: Expected F4, but got VT
			//IL_000a: Expected native int or pointer, but got VT
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected Obj, but got Unknown
			//IL_0027: Expected F4, but got Obj
			//IL_0022: Expected native int or pointer, but got VT
			Vector3 vector = default;
			((Vector3*)(nint)vector)->x = (float)_cameraPositionOffsetSmoothTime;
			object obj = this - -64;
			((Vector3*)(nint)vector)->z = (float)obj;
			return vector;
		}
	}

	public float TransformTweenDuration => _transformTweenDuration;

	public CameraData()
	{
		//IL_0052: Expected I, but got Obj
		//IL_0088: Expected I, but got Obj
		//IL_00be: Expected I, but got Obj
		//IL_00f4: Expected I, but got Obj
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected Obj, but got Unknown
		//IL_011f: Expected Obj, but got I
		SmoothDampFloat smoothDampFloat = default;
		smoothDampFloat._value = FIELD_OF_VIEW_DEFAULT;
		smoothDampFloat._smoothTime = FIELD_OF_VIEW_SMOOTH_TIME_DEFAULT;
		smoothDampFloat._target = FIELD_OF_VIEW_DEFAULT;
		_fieldOfView = smoothDampFloat;
		nint num = (nint)typeof(CameraData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v23 (Il2CppClass<SYBO.Subway.Cameras.CameraData>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v24 (Il2CppStaticFields<SYBO.Subway.Cameras.CameraData>)+10]");
		_ = 0;
		_cameraTargetOffset = CAMERA_TARGET_OFFSET_DEFAULT;
		nint num3 = (nint)typeof(CameraData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v29 (Il2CppClass<SYBO.Subway.Cameras.CameraData>)+5C]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v30 (Il2CppStaticFields<SYBO.Subway.Cameras.CameraData>)+28]");
		_ = 0;
		_cameraTargetOffsetSmoothTime = CAMERA_TARGET_OFFSET_SMOOTH_TIME_DEFAULT;
		nint num5 = (nint)typeof(CameraData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v35 (Il2CppClass<SYBO.Subway.Cameras.CameraData>)+5C]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v36 (Il2CppStaticFields<SYBO.Subway.Cameras.CameraData>)+1C]");
		_ = 0;
		_cameraPositionOffset = CAMERA_POSITION_OFFSET_DEFAULT;
		nint num7 = (nint)typeof(CameraData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v41 (Il2CppClass<SYBO.Subway.Cameras.CameraData>)+5C]");
		nint num8 = 0;
		object obj = this - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v42 (Il2CppStaticFields<SYBO.Subway.Cameras.CameraData>)+34]");
		obj = 0;
		_cameraPositionOffsetSmoothTime = CAMERA_POSITION_OFFSET_SMOOTH_TIME_DEFAULT;
		_transformTweenDuration = TRANSFORM_TWEEN_DURATION;
	}

	static CameraData()
	{
		//IL_0027: Expected I, but got Obj
		//IL_004b: Expected VT, but got I8
		//IL_0059: Expected I, but got Obj
		//IL_007d: Expected VT, but got I8
		//IL_008b: Expected I, but got Obj
		//IL_00af: Expected VT, but got I8
		//IL_00bd: Expected I, but got Obj
		//IL_00dd: Expected VT, but got I4
		nint num = (nint)typeof(CameraData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v12 (Il2CppClass<SYBO.Subway.Cameras.CameraData>)+5C]");
		nint num2 = 0;
		_ = 0;
		CAMERA_TARGET_OFFSET_DEFAULT = (Vector3)4728779608739020800L;
		nint num3 = (nint)typeof(CameraData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v16 (Il2CppClass<SYBO.Subway.Cameras.CameraData>)+5C]");
		nint num4 = 0;
		_ = -1039925248;
		CAMERA_POSITION_OFFSET_DEFAULT = (Vector3)4756927106410086400L;
		nint num5 = (nint)typeof(CameraData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v20 (Il2CppClass<SYBO.Subway.Cameras.CameraData>)+5C]");
		nint num6 = 0;
		_ = 0;
		CAMERA_TARGET_OFFSET_SMOOTH_TIME_DEFAULT = (Vector3)4453159313431383245L;
		nint num7 = (nint)typeof(CameraData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v24 (Il2CppClass<SYBO.Subway.Cameras.CameraData>)+5C]");
		nint num8 = 0;
		_ = 0;
		CAMERA_POSITION_OFFSET_SMOOTH_TIME_DEFAULT = (Vector3)0;
		TRANSFORM_TWEEN_DURATION = 0.5f;
		FIELD_OF_VIEW_SMOOTH_TIME_DEFAULT = 0.2f;
	}
}
