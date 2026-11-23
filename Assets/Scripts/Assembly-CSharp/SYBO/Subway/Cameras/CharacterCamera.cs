using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Common.Data;
using SYBO.Common.Exceptions;
using SYBO.Subway.Characters;
using SYBO.Subway.Characters.States;
using UnityEngine;

namespace SYBO.Subway.Cameras;

public class CharacterCamera : MonoBehaviour
{
	private sealed class _003CFOVTarget_Coroutine_003Ed__80(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_003c: Expected I4, but got I8
			if (_003C_003E1__state <= 1)
			{
				_003C_003E1__state = -1;
				_003C_003E1__state = 1;
			}
			return _003C_003E1__state < 2;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	public const float DefaultCharacterLookAtAngle = 21.5f;

	public const float DefaultAspectRatio = 0.5625f;

	private const float _HIGH_SPEED_1_FOV = 5f;

	private const float _HIGH_SPEED_1_FOV_SMOOTH_DURATION = 1f;

	private const float _HIGH_SPEED_2_FOV = 10f;

	private const float _HIGH_SPEED_2_FOV_SMOOTH_DURATION = 1f;

	private const float _SMOOTH_DAMP_THRESHHOLD = 0.5f;

	private const float MenuFieldOfView = 71f;

	public const float DefaultFieldOfView = 68f;

	private float tunnelDelta = -20f;

	private MainCamera _mainCamera;

	private Vector3 _position;

	private Vector3 _target;

	public float _speed;

	private float _previousCameraEndYPosition;

	private float _previousCameraEndXRotation;

	private CameraData _currentCameraData;

	private CameraSpeedType _cameraSpeedType;

	private float _customhighSpeedFOV;

	private CharacterState _currentCharacterState;

	private float _lastZ;

	private Vector3 _shake;

	private Vector3 _diff;

	private bool _fovGipping;

	private Camera _camera;

	private SmoothDampVector3B _cameraTarget;

	private Vector3 _lastCameraTransformPosition;

	private Vector3 _lastCameraTarget;

	private SmoothDampVector3B _cameraPosition;

	private Character _character;

	private SmoothDampFloat _fieldOfViewSmoothDampFloat;

	private Transform _characterTransform;

	private bool _hasSuperSneakers;

	private float _cameraModifierColliderStartZ;

	private Curve offsetDeltaCurve;

	private float _cameraModifierColliderEndZ;

	private float _cameraModifierY;

	private float _cameraModifierX;

	private Vector3 _previousCameraEndPosition;

	private Vector3 _previousTargetEndPosition;

	private float _tweenTimeTransform;

	private bool _initialized;

	private static CharacterCamera instance;

	private float _lastDeltaYFactor;

	public unsafe Vector3 Position
	{
		get
		{
			//IL_000f: Expected F4, but got VT
			//IL_000a: Expected native int or pointer, but got VT
			//IL_0024: Expected F4, but got I
			//IL_001f: Expected native int or pointer, but got VT
			Vector3 vector = default;
			((Vector3*)(nint)vector)->x = (float)_position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (SYBO.Subway.Cameras.CharacterCamera)+1C]");
			((Vector3*)(nint)vector)->z = 0f;
			return vector;
		}
		set
		{
			//IL_000f: Expected VT, but got F4
			_position = (Vector3)value.x;
			_ = value.z;
		}
	}

	public unsafe Vector3 Target
	{
		get
		{
			//IL_000f: Expected F4, but got VT
			//IL_000a: Expected native int or pointer, but got VT
			//IL_0024: Expected F4, but got I
			//IL_001f: Expected native int or pointer, but got VT
			Vector3 vector = default;
			((Vector3*)(nint)vector)->x = (float)_target;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (SYBO.Subway.Cameras.CharacterCamera)+28]");
			((Vector3*)(nint)vector)->z = 0f;
			return vector;
		}
		set
		{
			//IL_000f: Expected VT, but got F4
			_target = (Vector3)value.x;
			_ = value.z;
		}
	}

	public float Speed => _speed;

	public unsafe CameraData CameraData
	{
		get
		{
			return _currentCameraData;
		}
		private set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			//IL_0295: Unknown result type (might be due to invalid IL or missing references)
			//IL_029a: Expected VT, but got Unknown
			//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a8: Expected VT, but got Unknown
			//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f1: Expected Obj, but got Unknown
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Expected VT, but got Unknown
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Expected VT, but got Unknown
			//IL_00f1: Expected F4, but got I
			//IL_014a: Unknown result type (might be due to invalid IL or missing references)
			//IL_014f: Expected VT, but got Unknown
			//IL_01c3: Expected F4, but got I
			//IL_01be: Expected native int or pointer, but got VT
			//IL_01e2: Expected F4, but got I
			//IL_01dd: Expected native int or pointer, but got VT
			//IL_020c: Expected F4, but got I
			object obj = default;
			Vector3 vector = (Vector3)(obj - 208);
			_ = 0;
			_ = 0;
			_currentCameraData = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Cameras.CharacterCamera)+28]");
			_ = 0;
			_ = _target;
			CameraData currentCameraData = _currentCameraData;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v11 (SYBO.Subway.Cameras.CameraData)+28]");
			_ = 0;
			_ = currentCameraData._cameraTargetOffsetSmoothTime;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+98]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A0]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+90]");
			_ = 0;
			Vector3 value2 = vector + 80;
			Vector3 smoothTime = vector - -64;
			SmoothDampVector3B smoothDampVector3B = default;
			smoothDampVector3B._002Ector(value2, smoothTime);
			_cameraTarget = smoothDampVector3B;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Cameras.CharacterCamera)+1C]");
			_ = 0;
			_ = _position;
			CameraData currentCameraData2 = _currentCameraData;
			object obj2 = _currentCameraData - -64;
			_ = currentCameraData2._cameraPositionOffsetSmoothTime;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+78]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+70]");
			_ = 0;
			Vector3 value3 = vector + 48;
			Vector3 smoothTime2 = vector + 32;
			SmoothDampVector3B smoothDampVector3B2 = default;
			smoothDampVector3B2._002Ector(value3, smoothTime2);
			_cameraPosition = smoothDampVector3B2;
			SmoothDampFloat fieldOfViewSmoothDampFloat = _fieldOfViewSmoothDampFloat;
			CameraData currentCameraData3 = _currentCameraData;
			SmoothDampFloat fieldOfView = currentCameraData3._fieldOfView;
			fieldOfViewSmoothDampFloat._target = fieldOfView._target;
			fieldOfViewSmoothDampFloat._smoothTime = fieldOfView._smoothTime;
			Transform transform = base.transform;
			Vector3 position = transform.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+64]");
			_previousCameraEndYPosition = 0f;
			Transform transform2 = base.transform;
			Quaternion rotation = transform2.rotation;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
			_ = 0;
			Quaternion rotation2 = (Quaternion)(vector + 16);
			Vector3 vector2 = Quaternion.Internal_ToEulerRad(rotation2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
			float num = 0f * 57.29578f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+64]");
			float num2 = 0f * 57.29578f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
			float num3 = 0f * 57.29578f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C8]");
			((Vector3*)(nint)vector)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C0]");
			((Vector3*)(nint)vector)->x = 0f;
			Vector3 vector3 = Quaternion.Internal_MakePositive(vector);
			_tweenTimeTransform = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
			_previousCameraEndXRotation = 0f;
		}
	}

	public CameraSpeedType CameraSpeedType
	{
		get
		{
			return _cameraSpeedType;
		}
		private set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0199: Unknown result type (might be due to invalid IL or missing references)
			//IL_019e: Expected Obj, but got Unknown
			object obj2 = default;
			Enum obj = (Enum)(obj2 - 16);
			_cameraSpeedType = value;
			object obj3 = this + 60;
			switch (value)
			{
			case CameraSpeedType.Normal:
			{
				CameraData currentCameraData = _currentCameraData;
				if (_currentCameraData != null)
				{
					_fieldOfViewSmoothDampFloat = currentCameraData._fieldOfView;
					break;
				}
				_ = -1;
				obj = (Enum)(object)typeof(CameraSpeedType);
				string text = obj.ToString();
				string text2 = "We are missing a _cameraData when _cameraSpeedType: " + text;
				break;
			}
			case CameraSpeedType.HighSpeed1:
			{
				SmoothDampFloat fieldOfViewSmoothDampFloat3 = _fieldOfViewSmoothDampFloat;
				fieldOfViewSmoothDampFloat3._target = 5f;
				break;
			}
			case CameraSpeedType.HighSpeed2:
			{
				SmoothDampFloat fieldOfViewSmoothDampFloat2 = _fieldOfViewSmoothDampFloat;
				fieldOfViewSmoothDampFloat2._target = 10f;
				break;
			}
			case CameraSpeedType.CustomSpeed:
			{
				SmoothDampFloat fieldOfViewSmoothDampFloat = _fieldOfViewSmoothDampFloat;
				fieldOfViewSmoothDampFloat._smoothTime = 1f;
				fieldOfViewSmoothDampFloat._target = _customhighSpeedFOV;
				break;
			}
			default:
			{
				_ = -1;
				obj = (Enum)(object)typeof(CameraSpeedType);
				string missingSwitchValue = obj.ToString();
				SwitchDefaultException.Throw(missingSwitchValue);
				break;
			}
			}
		}
	}

	public Camera Camera => _camera;

	public static CharacterCamera Instance
	{
		get
		{
			//IL_0019: Expected VT, but got Obj
			CharacterCamera result = instance;
			if ((object)instance == null)
			{
				Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(CharacterCamera));
				UnityEngine.Object obj = UnityEngine.Object.FindObjectOfType(typeFromHandle);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
				CharacterCamera characterCamera = default;
				instance = characterCamera;
				result = characterCamera.Initialize();
			}
			return result;
		}
	}

	public unsafe Vector3 CameraPositionValue
	{
		get
		{
			//IL_001c: Expected F4, but got VT
			//IL_0017: Expected native int or pointer, but got VT
			//IL_0031: Expected F4, but got I
			//IL_002c: Expected native int or pointer, but got VT
			SmoothDampVector3B cameraPosition = _cameraPosition;
			Vector3 vector = default;
			((Vector3*)(nint)vector)->x = (float)cameraPosition._value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4 @ S1_v2 (SYBO.Common.Data.SmoothDampVector3B)+28]");
			((Vector3*)(nint)vector)->z = 0f;
			return vector;
		}
	}

	public MainCamera MainCamera => _mainCamera;

	public unsafe void SetCameraDataForcefully(CameraData cameraData)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0099: Expected F4, but got I
		//IL_0094: Expected native int or pointer, but got VT
		//IL_00c8: Expected F4, but got I
		//IL_00c3: Expected native int or pointer, but got VT
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected VT, but got Unknown
		object obj = default;
		Quaternion quaternion = (Quaternion)(obj - 80);
		Transform transform = _camera.transform;
		Vector3 localPosition = transform.localPosition;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+48]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+40]");
		_ = 0;
		Transform transform2 = _camera.transform;
		Quaternion localRotation = transform2.localRotation;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+48]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+38]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+48]");
		((Quaternion*)(nint)quaternion)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+40]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+30]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+40]");
		((Quaternion*)(nint)quaternion)->x = 0f;
		Vector3 cameraLocalPosition = (Vector3)(quaternion + 16);
		SetCameraDataForcefully(cameraData, cameraLocalPosition, quaternion);
	}

	public unsafe void SetCameraDataForcefully(CameraData cameraData, Vector3 cameraLocalPosition, Quaternion cameraLocalRotation)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Expected VT, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected VT, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected Obj, but got Unknown
		//IL_00cc: Expected Obj, but got I
		//IL_00e9: Expected Obj, but got I
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected VT, but got Unknown
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected VT, but got Unknown
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected Obj, but got Unknown
		//IL_01d9: Expected Obj, but got I
		//IL_01f6: Expected Obj, but got I
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected Obj, but got Unknown
		//IL_023e: Expected F4, but got I
		//IL_0239: Expected native int or pointer, but got VT
		//IL_026a: Expected F4, but got I
		//IL_0265: Expected native int or pointer, but got VT
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Expected VT, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj - 160);
		CameraData = cameraData;
		Transform transform = _camera.transform;
		_ = cameraLocalPosition.z;
		_ = cameraLocalPosition.x;
		Vector3 localPosition = vector + 80;
		transform.localPosition = localPosition;
		Transform transform2 = _camera.transform;
		_ = cameraLocalRotation.z;
		_ = cameraLocalRotation.x;
		Quaternion localRotation = (Quaternion)(vector - -64);
		transform2.localRotation = localRotation;
		SmoothDampFloat fieldOfView = cameraData._fieldOfView;
		_camera.fieldOfView = fieldOfView._target;
		Vector3 position = _characterTransform.position;
		CameraData currentCameraData = _currentCameraData;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+90]");
		object obj2 = 0 + currentCameraData._cameraTargetOffset;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+94]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v25 (SYBO.Subway.Cameras.CameraData)+18]");
		object obj3 = num + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+98]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v25 (SYBO.Subway.Cameras.CameraData)+1C]");
		object obj4 = num2 + 0;
		CameraData currentCameraData2 = _currentCameraData;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S1_v30 (SYBO.Subway.Cameras.CameraData)+28]");
		_ = 0;
		_ = currentCameraData2._cameraTargetOffsetSmoothTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+98]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+90]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
		_ = 0;
		Vector3 value = vector + 48;
		Vector3 smoothTime = vector + 32;
		SmoothDampVector3B smoothDampVector3B = default;
		smoothDampVector3B._002Ector(value, smoothTime);
		_cameraTarget = smoothDampVector3B;
		Vector3 position2 = _characterTransform.position;
		CameraData currentCameraData3 = _currentCameraData;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+70]");
		object obj5 = 0 + currentCameraData3._cameraPositionOffset;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+74]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S0_v53 (SYBO.Subway.Cameras.CameraData)+30]");
		object obj6 = num3 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+78]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S0_v53 (SYBO.Subway.Cameras.CameraData)+34]");
		object obj7 = num4 + 0;
		CameraData currentCameraData4 = _currentCameraData;
		object obj8 = _currentCameraData - -64;
		_ = currentCameraData4._cameraPositionOffsetSmoothTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+78]");
		((Vector3*)(nint)vector)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+70]");
		((Vector3*)(nint)vector)->x = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
		_ = 0;
		Vector3 value2 = vector + 16;
		SmoothDampVector3B smoothDampVector3B2 = default;
		smoothDampVector3B2._002Ector(value2, vector);
		_cameraPosition = smoothDampVector3B2;
	}

	public unsafe void SetCurrentCharacterState(CharacterState nextCharacterState)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Expected Obj, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		//IL_00aa: Expected Obj, but got I
		//IL_00c7: Expected Obj, but got I
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected VT, but got Unknown
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected VT, but got Unknown
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected Obj, but got Unknown
		//IL_01bc: Expected Obj, but got I
		//IL_01d9: Expected Obj, but got I
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected Obj, but got Unknown
		//IL_021c: Expected F4, but got I
		//IL_0217: Expected native int or pointer, but got VT
		//IL_0248: Expected F4, but got I
		//IL_0243: Expected native int or pointer, but got VT
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Expected VT, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj - 128);
		_currentCharacterState = nextCharacterState;
		if (_currentCharacterState != null)
		{
			CharacterState currentCharacterState = _currentCharacterState;
			CameraData = currentCharacterState._cameraData;
			if (_currentCharacterState == null)
			{
				CameraData currentCameraData = _currentCameraData;
				Vector3 position = _characterTransform.position;
				Vector3 cameraTargetOffset = currentCameraData._cameraTargetOffset;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+70]");
				object obj2 = cameraTargetOffset + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v38 (SYBO.Subway.Cameras.CameraData)+18]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+74]");
				object obj3 = num + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v38 (SYBO.Subway.Cameras.CameraData)+1C]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+78]");
				object obj4 = num2 + 0;
				CameraData currentCameraData2 = _currentCameraData;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S1_v30 (SYBO.Subway.Cameras.CameraData)+28]");
				_ = 0;
				_ = currentCameraData2._cameraTargetOffsetSmoothTime;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+78]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+70]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
				_ = 0;
				Vector3 value = vector + 48;
				Vector3 smoothTime = vector + 32;
				SmoothDampVector3B smoothDampVector3B = default;
				smoothDampVector3B._002Ector(value, smoothTime);
				_cameraTarget = smoothDampVector3B;
				CameraData currentCameraData3 = _currentCameraData;
				Vector3 position2 = _characterTransform.position;
				Vector3 cameraPositionOffset = currentCameraData3._cameraPositionOffset;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
				object obj5 = cameraPositionOffset + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ S0_v67 (SYBO.Subway.Cameras.CameraData)+30]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+54]");
				object obj6 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ S0_v67 (SYBO.Subway.Cameras.CameraData)+34]");
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
				object obj7 = num4 + 0;
				CameraData currentCameraData4 = _currentCameraData;
				object obj8 = _currentCameraData - -64;
				_ = currentCameraData4._cameraPositionOffsetSmoothTime;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
				((Vector3*)(nint)vector)->z = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
				((Vector3*)(nint)vector)->x = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
				_ = 0;
				Vector3 value2 = vector + 16;
				SmoothDampVector3B smoothDampVector3B2 = default;
				smoothDampVector3B2._002Ector(value2, vector);
				_cameraPosition = smoothDampVector3B2;
			}
			else
			{
				CameraData currentCameraData5 = _currentCameraData;
				SmoothDampVector3B cameraTarget = _cameraTarget;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v26 (SYBO.Subway.Cameras.CameraData)+28]");
				_ = 0;
				cameraTarget._smoothTime = currentCameraData5._cameraTargetOffsetSmoothTime;
				CameraData currentCameraData6 = _currentCameraData;
				SmoothDampVector3B cameraPosition = _cameraPosition;
				object obj9 = _currentCameraData - -64;
				cameraPosition._smoothTime = currentCameraData6._cameraPositionOffsetSmoothTime;
			}
		}
		else
		{
			CameraData defaultCameraDataForMenu = GetDefaultCameraDataForMenu();
			SetCameraDataForcefully(defaultCameraDataForMenu);
		}
	}

	protected void Awake()
	{
		CharacterCamera characterCamera = Initialize();
	}

	private unsafe CharacterCamera Initialize()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0041: Expected F4, but got I
		//IL_025b: Expected I, but got Obj
		//IL_028c: Expected I, but got Obj
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected VT, but got Unknown
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected VT, but got Unknown
		//IL_011f: Expected I, but got Obj
		//IL_0150: Expected I, but got Obj
		//IL_019a: Expected F4, but got I
		//IL_0195: Expected native int or pointer, but got VT
		//IL_01bc: Expected F4, but got I
		//IL_01b7: Expected native int or pointer, but got VT
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected VT, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj - 128);
		if (~(_initialized ? 1u : 0u) != 0)
		{
			Transform transform = base.transform;
			Vector3 position = transform.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+78]");
			_lastZ = 0f;
			Camera component = GetComponent<Camera>();
			_camera = component;
			MainCamera component2 = GetComponent<MainCamera>();
			_mainCamera = component2;
			if (instance == null)
			{
				instance = this;
			}
			SmoothDampFloat smoothDampFloat = default;
			smoothDampFloat._value = CameraData.FIELD_OF_VIEW_DEFAULT;
			smoothDampFloat._smoothTime = CameraData.FIELD_OF_VIEW_SMOOTH_TIME_DEFAULT;
			smoothDampFloat._target = CameraData.FIELD_OF_VIEW_DEFAULT;
			_fieldOfViewSmoothDampFloat = smoothDampFloat;
			nint num = (nint)typeof(CameraData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S1_v21 (Il2CppClass<SYBO.Subway.Cameras.CameraData>)+5C]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S1_v22 (Il2CppStaticFields<SYBO.Subway.Cameras.CameraData>)+1C]");
			_ = 0;
			_ = CameraData.CAMERA_POSITION_OFFSET_DEFAULT;
			nint num3 = (nint)typeof(CameraData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S1_v27 (Il2CppClass<SYBO.Subway.Cameras.CameraData>)+5C]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S1_v28 (Il2CppStaticFields<SYBO.Subway.Cameras.CameraData>)+34]");
			_ = 0;
			_ = CameraData.CAMERA_POSITION_OFFSET_SMOOTH_TIME_DEFAULT;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+78]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+70]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
			_ = 0;
			Vector3 value = vector + 48;
			Vector3 smoothTime = vector + 32;
			SmoothDampVector3B smoothDampVector3B = default;
			smoothDampVector3B._002Ector(value, smoothTime);
			_cameraTarget = smoothDampVector3B;
			nint num5 = (nint)typeof(CameraData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S1_v44 (Il2CppClass<SYBO.Subway.Cameras.CameraData>)+5C]");
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ S1_v45 (Il2CppStaticFields<SYBO.Subway.Cameras.CameraData>)+10]");
			_ = 0;
			_ = CameraData.CAMERA_TARGET_OFFSET_DEFAULT;
			nint num7 = (nint)typeof(CameraData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ S1_v50 (Il2CppClass<SYBO.Subway.Cameras.CameraData>)+5C]");
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ S1_v51 (Il2CppStaticFields<SYBO.Subway.Cameras.CameraData>)+28]");
			_ = 0;
			_ = CameraData.CAMERA_TARGET_OFFSET_SMOOTH_TIME_DEFAULT;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
			((Vector3*)(nint)vector)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
			((Vector3*)(nint)vector)->x = 0f;
			Vector3 value2 = vector + 16;
			SmoothDampVector3B smoothDampVector3B2 = default;
			smoothDampVector3B2._002Ector(value2, vector);
			_cameraPosition = smoothDampVector3B2;
			_initialized = true;
		}
		return this;
	}

	protected void Start()
	{
		Game game = Game.Instance;
		_character = game._character;
		Game game2 = Game.Instance;
		Transform characterTransform = game2._character.transform;
		_characterTransform = characterTransform;
	}

	protected unsafe void LateUpdate()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0026: Expected Obj, but got I4
		//IL_08de: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e3: Expected Obj, but got Unknown
		//IL_08f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fd: Expected VT, but got Unknown
		//IL_0b10: Expected I, but got Obj
		//IL_0b30: Expected Obj, but got I
		//IL_092e: Expected F4, but got I
		//IL_0929: Expected native int or pointer, but got VT
		//IL_093d: Expected F4, but got VT
		//IL_0938: Expected native int or pointer, but got VT
		//IL_0a9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa2: Expected Obj, but got Unknown
		//IL_0ac1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac6: Expected Obj, but got Unknown
		//IL_00e0: Expected Obj, but got I
		//IL_11ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_11bf: Expected Obj, but got Unknown
		//IL_0b5c: Expected Obj, but got I
		//IL_0b80: Expected VT, but got I
		//IL_0bf9: Invalid comparison between I and F4
		//IL_0cf4: Invalid comparison between I and F4
		//IL_09fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a01: Expected Obj, but got Unknown
		//IL_1203: Invalid comparison between I and F4
		//IL_1219: Expected F4, but got I
		//IL_124b: Expected VT, but got I
		//IL_029d: Expected F4, but got I
		//IL_11ab: Expected Obj, but got I4
		//IL_0d16: Expected I, but got Obj
		//IL_0d2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d34: Expected Obj, but got Unknown
		//IL_0d6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d71: Expected Obj, but got Unknown
		//IL_0da1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da6: Expected Obj, but got Unknown
		//IL_0de2: Expected VT, but got F4
		//IL_0dfa: Invalid comparison between VT and F4
		//IL_1266: Unknown result type (might be due to invalid IL or missing references)
		//IL_126b: Expected Obj, but got Unknown
		//IL_12a1: Expected Obj, but got I
		//IL_12bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_12c0: Expected Obj, but got Unknown
		//IL_12ec: Expected Obj, but got I
		//IL_1310: Expected VT, but got I
		//IL_134f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1354: Expected Obj, but got Unknown
		//IL_136e: Expected Obj, but got I
		//IL_0e4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e50: Expected VT, but got Unknown
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		//IL_0335: Expected VT, but got Unknown
		//IL_0e9c: Expected Obj, but got VT
		//IL_0ea9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eae: Expected VT, but got Unknown
		//IL_0ef9: Expected Obj, but got I
		//IL_0f09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f0e: Expected Obj, but got Unknown
		//IL_077c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0781: Expected Obj, but got Unknown
		//IL_079e: Expected Obj, but got I
		//IL_07bb: Expected Obj, but got I
		//IL_07ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f2: Expected VT, but got Unknown
		//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e8: Expected VT, but got Unknown
		//IL_046f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0474: Expected VT, but got Unknown
		//IL_1168: Unknown result type (might be due to invalid IL or missing references)
		//IL_116d: Expected Obj, but got Unknown
		//IL_1044: Unknown result type (might be due to invalid IL or missing references)
		//IL_1049: Expected VT, but got Unknown
		//IL_08bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c1: Expected Obj, but got Unknown
		//IL_0581: Unknown result type (might be due to invalid IL or missing references)
		//IL_0586: Expected VT, but got Unknown
		//IL_113d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1142: Expected VT, but got Unknown
		//IL_0671: Expected Obj, but got I
		//IL_06db: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e0: Expected VT, but got Unknown
		//IL_072a: Unknown result type (might be due to invalid IL or missing references)
		//IL_072f: Expected VT, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj - 320);
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		CameraData currentCameraData = _currentCameraData;
		if (_currentCameraData == null)
		{
			return;
		}
		object obj2 = currentCameraData._cameraDataMode - 1;
		object obj5;
		object obj6;
		if (currentCameraData._cameraDataMode != CameraDataMode.CameraUpdateEnabled_UseMyCameraData)
		{
			if ((nint)obj2 != 1)
			{
				return;
			}
			Transform transform = base.transform;
			object obj3 = this + 28;
			_ = _position;
			Vector3 position = vector + 16;
			transform.position = position;
			Transform transform2 = base.transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Cameras.CharacterCamera)+28]");
			((Vector3*)(nint)vector)->z = 0f;
			((Vector3*)(nint)vector)->x = (float)_target;
			transform2.LookAt(vector);
			SmoothDampVector3B cameraTarget = _cameraTarget;
			cameraTarget._value = _target;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Cameras.CharacterCamera)+28]");
			_ = 0;
			_cameraTarget.Update();
			SmoothDampVector3B cameraPosition = _cameraPosition;
			cameraPosition._target = _position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Cameras.CharacterCamera)+1C]");
			_ = 0;
			_cameraPosition.Update();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Cameras.CharacterCamera)+1C]");
			float num = 0f - _lastZ;
			float deltaTime = Time.deltaTime;
			object obj4 = (_speed = num / deltaTime) & 0x7FFFFFFF;
			bool flag = (nint)obj4 < 2139095041;
			obj5 = obj3;
			if (flag)
			{
				goto IL_1195;
			}
			obj6 = this + 44;
			obj5 = obj3;
			goto IL_11a2;
		}
		object obj7;
		if (offsetDeltaCurve != null)
		{
			Character character = _character;
			if (character.z < _cameraModifierColliderEndZ)
			{
				float t = character.z - _cameraModifierColliderStartZ;
				Vector3 vector2 = offsetDeltaCurve.Evaluate(t);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+134]");
				obj7 = 0;
				goto IL_0a7b;
			}
		}
		nint num2 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ S0_v321 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S0_v322 (Il2CppStaticFields<UnityEngine.Vector3>)+4]");
		obj7 = 0;
		goto IL_0a7b;
		IL_0a7b:
		Vector3 position2 = _characterTransform.position;
		CameraData currentCameraData2 = _currentCameraData;
		object obj8 = vector + 272;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+130]");
		object obj9 = 0 + currentCameraData2._cameraTargetOffset;
		float num4 = (float)obj9 * _cameraModifierX;
		CameraData currentCameraData3 = _currentCameraData;
		if (~(currentCameraData3._dontMoveInY ? 1u : 0u) == 0)
		{
			SmoothDampVector3B cameraTarget2 = _cameraTarget;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ S1_v290 (SYBO.Common.Data.SmoothDampVector3B)+C]");
			_ = 0;
			goto IL_0b35;
		}
		float num5;
		if (!_hasSuperSneakers)
		{
			Character character2 = _character;
			if (!character2.__isInLipFlight)
			{
				Hoverboard hoverboard = character2._hoverboard;
				if (~(hoverboard.isActive ? 1u : 0u) != 0 || !hoverboard.isJumper)
				{
					bool isDoubleJumping = character2.IsDoubleJumping;
					bool flag2 = !isDoubleJumping;
					num5 = 0f;
					if (flag2)
					{
						goto IL_0c0d;
					}
				}
			}
		}
		if (_character.IsDoubleJumping)
		{
			bool isJumpingHigher = _character.IsJumpingHigher;
			num5 = 0.8f;
			if (isJumpingHigher)
			{
				goto IL_0c0d;
			}
		}
		num5 = 0.5f;
		goto IL_0c0d;
		IL_0b35:
		CameraData currentCameraData4 = _currentCameraData;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+138]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ S2_v11 (SYBO.Subway.Cameras.CameraData)+1C]");
		object obj10 = num6 + 0;
		SmoothDampVector3B cameraTarget3 = _cameraTarget;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+110]");
		cameraTarget3._target = (Vector3)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+118]");
		_ = 0;
		_cameraTarget.Update();
		SmoothDampVector3B cameraTarget4 = _cameraTarget;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ S1_v35 (SYBO.Common.Data.SmoothDampVector3B)+28]");
		_ = 0;
		_ = cameraTarget4._value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+134]");
		float num7 = 0f - 5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+134]");
		float num8 = 0f + 25f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+114]");
		if (!(0f > num8))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+114]");
			num8 = 0f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+114]");
		if (!(0f < num7))
		{
			num7 = num8;
		}
		SmoothDampVector3B cameraTarget5 = _cameraTarget;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+110]");
		cameraTarget5._value = (Vector3)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+118]");
		_ = 0;
		nint num9 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ S0_v77 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num10 = 0;
		object obj11 = Vector3.upVector * obj7;
		float num11 = (float)obj11 * _cameraModifierY;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+110]");
		float num12 = 0f + num11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v491 @ S0_v78 (Il2CppStaticFields<UnityEngine.Vector3>)+1C]");
		object obj12 = 0 * obj7;
		float num13 = (float)obj12 * _cameraModifierY;
		float num14 = num7 + num13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v491 @ S0_v78 (Il2CppStaticFields<UnityEngine.Vector3>)+20]");
		object obj13 = 0 * obj7;
		float num15 = (float)obj13 * _cameraModifierY;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+118]");
		float num16 = 0f + num15;
		_target = (Vector3)num12;
		CameraData currentCameraData5 = _currentCameraData;
		bool flag3 = currentCameraData5._cameraPositionOffset != (Vector3)(object)0f;
		bool flag4 = !flag3;
		float num17 = num12;
		if (!flag4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+130]");
			float num18 = 0f + (float)currentCameraData5._cameraPositionOffset;
			num17 = num18;
		}
		object obj14 = vector + 256;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		CameraData currentCameraData6 = _currentCameraData;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Cameras.CharacterCamera)+24]");
		nint num19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v597 @ S2_v26 (SYBO.Subway.Cameras.CameraData)+30]");
		object obj15 = num19 + 0;
		CameraData currentCameraData7 = _currentCameraData;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v601 @ S2_v29 (SYBO.Subway.Cameras.CameraData)+18]");
		object obj16 = obj15 - 0;
		CameraData currentCameraData8 = _currentCameraData;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+138]");
		nint num20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v607 @ S2_v32 (SYBO.Subway.Cameras.CameraData)+34]");
		object obj17 = num20 + 0;
		SmoothDampVector3B cameraPosition2 = _cameraPosition;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+100]");
		cameraPosition2._target = (Vector3)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+108]");
		_ = 0;
		_cameraPosition.Update();
		SmoothDampVector3B cameraPosition3 = _cameraPosition;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v631 @ S0_v105 (SYBO.Common.Data.SmoothDampVector3B)+24]");
		float num21 = 0f + (float)obj7;
		object obj18 = this + 28;
		SmoothDampVector3B cameraPosition4 = _cameraPosition;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v644 @ S1_v77 (SYBO.Common.Data.SmoothDampVector3B)+28]");
		obj18 = 0;
		_position = cameraPosition3._value;
		Character character3 = _character;
		if (~(character3._isInsideSubway ? 1u : 0u) == 0)
		{
			float num22 = character3.SubwayMaxY;
			if (!(num21 > character3.SubwayMaxY))
			{
				num22 = num21;
			}
			CameraData currentCameraData9 = _currentCameraData;
			CameraData currentCameraData10 = _currentCameraData;
			object obj19 = cameraPosition3._value - currentCameraData9._cameraPositionOffset;
			Vector3 target = obj19 + currentCameraData10._cameraTargetOffset;
			float num23 = num22;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v691 @ S0_v262 (SYBO.Subway.Cameras.CameraData)+30]");
			float num24 = num23 - 0f;
			float num25 = num24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v694 @ S0_v265 (SYBO.Subway.Cameras.CameraData)+18]");
			float num26 = num25 + 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v644 @ S1_v77 (SYBO.Common.Data.SmoothDampVector3B)+28]");
			nint num27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v691 @ S0_v262 (SYBO.Subway.Cameras.CameraData)+34]");
			object obj20 = num27 - 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v694 @ S0_v265 (SYBO.Subway.Cameras.CameraData)+1C]");
			object obj21 = obj20 + 0;
			_target = target;
		}
		Transform transform3 = base.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Cameras.CharacterCamera)+1C]");
		_ = 0;
		_ = _position;
		Vector3 position3 = vector + 176;
		transform3.position = position3;
		Transform transform4 = base.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Cameras.CharacterCamera)+28]");
		_ = 0;
		_ = _target;
		Vector3 worldPosition = vector + 160;
		transform4.LookAt(worldPosition);
		CameraData currentCameraData11 = _currentCameraData;
		float num28 = _tweenTimeTransform / currentCameraData11._transformTweenDuration;
		if (num28 < 1f)
		{
			Transform transform5 = base.transform;
			Quaternion rotation = transform5.rotation;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+138]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+138]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+130]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+130]");
			_ = 0;
			Quaternion rotation2 = (Quaternion)(vector + 144);
			Vector3 vector3 = Quaternion.Internal_ToEulerRad(rotation2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+130]");
			float num29 = 0f * 57.29578f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+134]");
			float num30 = 0f * 57.29578f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+138]");
			float num31 = 0f * 57.29578f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+128]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+120]");
			_ = 0;
			Vector3 euler = vector + 128;
			Vector3 vector4 = Quaternion.Internal_MakePositive(euler);
			Transform transform6 = base.transform;
			Vector3 position4 = transform6.position;
			CameraData currentCameraData12 = _currentCameraData;
			float num32 = _tweenTimeTransform / currentCameraData12._transformTweenDuration;
			float num33 = Math.Min(num32, 1f);
			bool flag5 = num32 < 0f;
			float num34 = 0f;
			if (!flag5)
			{
				num34 = num33;
			}
			float num35 = num34 * -2f;
			float num36 = num35 * num34;
			float num37 = num36 * num34;
			float num38 = num34 * 3f;
			float num39 = num38 * num34;
			float num40 = num37 + num39;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Cameras.CharacterCamera)+18]");
			float num41 = 0f * num40;
			float num42 = 1f - num40;
			float num43 = _previousCameraEndYPosition * num42;
			float num44 = num41 + num43;
			Transform transform7 = base.transform;
			Quaternion rotation3 = transform7.rotation;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+138]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+138]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+130]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+130]");
			_ = 0;
			Quaternion rotation4 = (Quaternion)(vector + 112);
			Vector3 vector5 = Quaternion.Internal_ToEulerRad(rotation4);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+130]");
			float num45 = 0f * 57.29578f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+134]");
			float num46 = 0f * 57.29578f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+138]");
			float num47 = 0f * 57.29578f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+128]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+120]");
			_ = 0;
			Vector3 euler2 = vector + 96;
			Vector3 vector6 = Quaternion.Internal_MakePositive(euler2);
			CameraData currentCameraData13 = _currentCameraData;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+130]");
			float num48 = 0f - _previousCameraEndXRotation;
			float num49 = num48 / 360f;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Floor not resolved\"");
			float num50 = num49 * 360f;
			float num51 = num48 - num50;
			float num52 = Math.Min(num51, 360f);
			bool flag6 = num51 < 0f;
			float num53 = 0f;
			if (!flag6)
			{
				num53 = num52;
			}
			if (num53 > 180f)
			{
				num53 -= 360f;
			}
			float num54 = _tweenTimeTransform / currentCameraData13._transformTweenDuration;
			float num55 = Math.Min(num54, 1f);
			bool flag7 = num54 < 0f;
			float num56 = 0f;
			if (!flag7)
			{
				num56 = num55;
			}
			float num57 = num53 * num56;
			float num58 = _previousCameraEndXRotation + num57;
			Transform transform8 = base.transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+138]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+E8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+130]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+E0]");
			_ = 0;
			Vector3 position5 = vector + 80;
			transform8.position = position5;
			Transform transform9 = base.transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+134]");
			object obj22 = (nint)0 >> 32;
			float num59 = (float)obj22 * ((float)Math.PI / 180f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+128]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+134]");
			float num60 = 0f * ((float)Math.PI / 180f);
			float num61 = num58 * ((float)Math.PI / 180f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+120]");
			_ = 0;
			Vector3 euler3 = vector - -64;
			Quaternion quaternion = Quaternion.Internal_FromEulerRad(euler3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+138]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+138]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+130]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+130]");
			_ = 0;
			Quaternion rotation5 = (Quaternion)(vector + 48);
			transform9.rotation = rotation5;
			float deltaTime2 = Time.deltaTime;
			float tweenTimeTransform = _tweenTimeTransform + deltaTime2;
			_tweenTimeTransform = tweenTimeTransform;
		}
		Transform transform10 = base.transform;
		Transform transform11 = base.transform;
		Vector3 position6 = transform11.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+130]");
		object obj23 = 0 + _shake;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+134]");
		nint num62 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Cameras.CharacterCamera)+50]");
		object obj24 = num62 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+138]");
		nint num63 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Cameras.CharacterCamera)+54]");
		object obj25 = num63 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C0]");
		_ = 0;
		Vector3 position7 = vector + 32;
		transform10.position = position7;
		float fieldOfView = _camera.fieldOfView;
		SmoothDampFloat fieldOfViewSmoothDampFloat = _fieldOfViewSmoothDampFloat;
		float value = fieldOfView - fieldOfViewSmoothDampFloat._target;
		float num64 = Math.Abs(value);
		if (num64 > 0.5f)
		{
			_fieldOfViewSmoothDampFloat.Update();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Cameras.CharacterCamera)+1C]");
		float num65 = 0f - _lastZ;
		float deltaTime3 = Time.deltaTime;
		object obj26 = (_speed = num65 / deltaTime3) & 0x7FFFFFFF;
		bool flag8 = (nint)obj26 <= 2139095040;
		obj5 = obj18;
		if (flag8)
		{
			goto IL_1195;
		}
		obj6 = this + 44;
		obj5 = obj18;
		goto IL_11a2;
		IL_0c0d:
		Character character4 = _character;
		Variable<bool> isGrounded = character4.IsGrounded;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v478 @ S0_v287 (Variable`1<System.Boolean>)+8]");
		bool flag9 = (nint)0 == 0;
		bool flag10 = !flag9;
		float num66 = num5;
		if (!flag10)
		{
			float num67 = num5 - _lastDeltaYFactor;
			float deltaTime4 = Time.deltaTime;
			float num68 = deltaTime4 + deltaTime4;
			float num69 = Math.Min(num68, 1f);
			bool flag11 = num68 < 0f;
			float num70 = 0f;
			if (!flag11)
			{
				num70 = num69;
			}
			float num71 = num67 * num70;
			float num72 = _lastDeltaYFactor + num71;
			num66 = num72;
		}
		Character character5 = _character;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+134]");
		bool flag12 = 0f < character5.LastGroundedY;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+134]");
		float num73 = 0f;
		if (!flag12)
		{
			num73 = character5.LastGroundedY;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+134]");
		float num74 = 0f - character5.LastGroundedY;
		if (!(num74 > 0f))
		{
			num74 = 0f;
		}
		float num75 = num66 * num74;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+114]");
		float num76 = 0f + num75;
		CameraData currentCameraData14 = _currentCameraData;
		float num77 = num76;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v628 @ S2_v113 (SYBO.Subway.Cameras.CameraData)+18]");
		float num78 = num77 + 0f;
		_lastDeltaYFactor = num66;
		goto IL_0b35;
		IL_1195:
		object obj27 = obj5;
		return;
		IL_11a2:
		obj6 = 0;
		goto IL_1195;
	}

	private void DebugLogCameraDetails()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		//IL_006b: Expected Obj, but got I
		//IL_00a2: Expected Obj, but got I
		//IL_00c5: Invalid comparison between Obj and F4
		//IL_01d2: Expected VT, but got Obj
		//IL_00f5: Expected Obj, but got VT
		//IL_011f: Expected Obj, but got I
		//IL_0156: Expected Obj, but got I
		//IL_0179: Invalid comparison between Obj and F4
		object obj2 = default;
		object obj = obj2 - 32;
		Transform transform = base.transform;
		Vector3 position = transform.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		object obj3 = 0 - _lastCameraTransformPosition;
		object obj4 = obj3 * obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+14]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Cameras.CharacterCamera)+74]");
		object obj5 = num - 0;
		object obj6 = obj5 * obj5;
		object obj7 = obj4 + obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Cameras.CharacterCamera)+78]");
		object obj8 = num2 - 0;
		object obj9 = obj8 * obj8;
		object obj10 = obj7 + obj9;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)9.9999994E-11f))
		{
			object obj11 = _target - _lastCameraTarget;
			object obj12 = obj11 * obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Cameras.CharacterCamera)+24]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Cameras.CharacterCamera)+80]");
			object obj13 = num3 - 0;
			object obj14 = obj13 * obj13;
			object obj15 = obj12 + obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Cameras.CharacterCamera)+28]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Cameras.CharacterCamera)+84]");
			object obj16 = num4 - 0;
			object obj17 = obj16 * obj16;
			object obj18 = obj15 + obj17;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj18) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)9.9999994E-11f))
			{
				return;
			}
		}
		Transform transform2 = base.transform;
		Vector3 position2 = transform2.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		_lastCameraTransformPosition = (Vector3)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Cameras.CharacterCamera)+28]");
		_ = 0;
		_lastCameraTarget = _target;
	}

	protected unsafe void OnDrawGizmos()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected VT, but got Unknown
		//IL_0076: Expected F4, but got I
		//IL_0071: Expected native int or pointer, but got VT
		//IL_0085: Expected F4, but got VT
		//IL_0080: Expected native int or pointer, but got VT
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected VT, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj + -64);
		_ = 4575657221408423936L;
		_ = 4575657221408423936L;
		_ = 4575657221408423936L;
		_ = 4575657221408423936L;
		Color color = (Color)(vector + 32);
		Gizmos.color = color;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Cameras.CharacterCamera)+1C]");
		_ = 0;
		_ = _position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Cameras.CharacterCamera)+28]");
		((Vector3*)(nint)vector)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)_target;
		Vector3 vector2 = vector + 16;
		Gizmos.DrawLine(vector2, vector);
	}

	public void Shake()
	{
		//IL_0029: Expected I, but got Obj
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v13 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		_diff = Vector3.zeroVector;
		_ = 1120403456;
		throw new ArgumentException();
	}

	public void ResetShake()
	{
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ S0_v6 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v7 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		_shake = Vector3.zeroVector;
	}

	public void Shake(float intensity)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00a3: Expected VT, but got F4
		object obj2 = default;
		object obj = obj2 - 16;
		Vector3 insideUnitSphere = UnityEngine.Random.insideUnitSphere;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
		float num = 0f * intensity;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		float num2 = 0f * intensity;
		float num3 = (float)obj * intensity;
		float deltaTime = Time.deltaTime;
		float num4 = num3 * deltaTime;
		float num5 = num2 * deltaTime;
		float num6 = num * deltaTime;
		_shake = (Vector3)num4;
	}

	public void FOVGip(float time, float multiplier)
	{
		if (~(_fovGipping ? 1u : 0u) != 0)
		{
			_fovGipping = true;
			float fieldOfView = _camera.fieldOfView;
			throw new ArgumentException();
		}
	}

	public void SetFOV(float addedFOV)
	{
		_customhighSpeedFOV = addedFOV;
		StopCoroutine("FOVTarget_Coroutine");
		Coroutine coroutine = StartCoroutine("FOVTarget_Coroutine");
	}

	private IEnumerator FOVTarget_Coroutine()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	public void RevertFOV()
	{
		StopCoroutine("FOVTarget_Coroutine");
	}

	public unsafe void EnterCameraModifierCollider(float colliderLength)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0070: Expected I, but got Obj
		//IL_03c9: Expected I, but got Obj
		//IL_03ea: Expected Obj, but got I
		//IL_03fb: Expected Obj, but got I
		//IL_0400: Unsupported input type for neg.
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		//IL_0405: Expected Obj, but got Unknown
		//IL_00a6: Expected I, but got Obj
		//IL_00cc: Expected Obj, but got I
		//IL_0113: Expected Obj, but got I
		//IL_011d: Unsupported input type for neg.
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected Obj, but got Unknown
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected VT, but got Unknown
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected VT, but got Unknown
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected VT, but got Unknown
		//IL_01a7: Expected I, but got Obj
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Expected VT, but got Unknown
		//IL_0268: Expected I, but got Obj
		//IL_0418: Expected I, but got Obj
		//IL_029e: Expected I, but got Obj
		//IL_0340: Expected F4, but got I
		//IL_033b: Expected native int or pointer, but got VT
		//IL_0383: Expected F4, but got I
		//IL_037e: Expected native int or pointer, but got VT
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Expected VT, but got Unknown
		//IL_039a: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Expected VT, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj - 224);
		Character character = _character;
		_cameraModifierColliderStartZ = character.z;
		float cameraModifierColliderEndZ = character.z + colliderLength;
		_cameraModifierColliderEndZ = cameraModifierColliderEndZ;
		Curve curve = default;
		curve._002Ector();
		offsetDeltaCurve = curve;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S1_v12 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S1_v13 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		_ = Vector3.zeroVector;
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v26 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v27 (Il2CppStaticFields<UnityEngine.Vector3>)+20]");
		object obj2 = -0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v27 (Il2CppStaticFields<UnityEngine.Vector3>)+1C]");
		object obj3 = -0;
		object obj4 = 0 - Vector3.upVector;
		nint num5 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v41 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v42 (Il2CppStaticFields<UnityEngine.Vector3>)+20]");
		object obj5 = -0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v42 (Il2CppStaticFields<UnityEngine.Vector3>)+1C]");
		object obj6 = -0;
		object obj7 = 0 - Vector3.upVector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B0]");
		_ = 0;
		Vector3 value = vector + 96;
		Vector3 inTangent = vector + 80;
		Vector3 outTangent = vector - -64;
		offsetDeltaCurve.AddKey(0f, value, inTangent, outTangent);
		nint num7 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S0_v68 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num8 = 0;
		float num9 = (float)Vector3.upVector * tunnelDelta;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S0_v69 (Il2CppStaticFields<UnityEngine.Vector3>)+1C]");
		float num10 = 0f * tunnelDelta;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S0_v69 (Il2CppStaticFields<UnityEngine.Vector3>)+20]");
		float num11 = 0f * tunnelDelta;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A0]");
		_ = 0;
		float t = colliderLength * 0.5f;
		Vector3 value2 = vector + 48;
		offsetDeltaCurve.AddKey(t, value2);
		nint num12 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ S1_v57 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ S1_v58 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		_ = Vector3.zeroVector;
		nint num14 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ S0_v96 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num15 = 0;
		float num16 = (float)Vector3.upVector * 0.001f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ S0_v97 (Il2CppStaticFields<UnityEngine.Vector3>)+1C]");
		float num17 = 0f * 0.001f;
		nint num18 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ S0_v110 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num19 = 0;
		float num20 = (float)Vector3.upVector * 0.001f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ S0_v111 (Il2CppStaticFields<UnityEngine.Vector3>)+1C]");
		float num21 = 0f * 0.001f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ S0_v97 (Il2CppStaticFields<UnityEngine.Vector3>)+20]");
		float num22 = 0f * 0.001f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ S0_v111 (Il2CppStaticFields<UnityEngine.Vector3>)+20]");
		float num23 = 0f * 0.001f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+98]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+78]");
		((Vector3*)(nint)vector)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+90]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+70]");
		((Vector3*)(nint)vector)->x = 0f;
		Vector3 value3 = vector + 32;
		Vector3 inTangent2 = vector + 16;
		offsetDeltaCurve.AddKey(colliderLength, value3, inTangent2, vector);
	}

	public void ExitCameraModifierCollider()
	{
		offsetDeltaCurve = null;
	}

	public void Game_OnCharacterStateChanged(object sender, CharacterStateChangedEventArgs characterStateChangedEventArgs)
	{
		//IL_0138: Expected Obj, but got I
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_0054: Expected Obj, but got I
		//IL_0088: Expected Obj, but got I
		//IL_00ba: Expected Obj, but got I
		//IL_00ca: Expected Obj, but got I
		//IL_0104: Expected Obj, but got I
		if (_characterTransform == null)
		{
			object obj = this + 148;
			Game game = Game.Instance;
			Transform transform = game._character.transform;
			obj = transform;
		}
		if (!(_currentCharacterState == null))
		{
			CharacterState currentCharacterState = _currentCharacterState;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [characterStateChangedEventArgs @ L2 (System.Object)+C]");
			if (!(currentCharacterState != (UnityEngine.Object)0))
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [characterStateChangedEventArgs @ L2 (System.Object)+C]");
			if (!((UnityEngine.Object)0 != null))
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [characterStateChangedEventArgs @ L2 (System.Object)+C]");
			UnityEngine.Object obj2 = (UnityEngine.Object)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v39 (UnityEngine.Object)+C]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v40+8]");
			if ((nint)0 == 0)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [characterStateChangedEventArgs @ L2 (System.Object)+8]");
			if (!(obj2 != (UnityEngine.Object)0))
			{
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [characterStateChangedEventArgs @ L2 (System.Object)+C]");
		SetCurrentCharacterState((CharacterState)0);
	}

	public unsafe void CharacterModifierCollection_OnChanged(object sender, CharacterModifierCollectionChangedEventArgs characterModifierCollectionChangedEventArgs)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_005b: Expected VT, but got Obj
		//IL_01d8: Expected VT, but got Obj
		//IL_00b7: Expected F4, but got I
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected VT, but got Unknown
		//IL_0184: Expected F4, but got I
		//IL_017f: Expected native int or pointer, but got VT
		//IL_01a3: Expected F4, but got I
		//IL_019e: Expected native int or pointer, but got VT
		//IL_0234: Expected F4, but got I
		//IL_034d: Expected F4, but got I
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Expected VT, but got Unknown
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Expected VT, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj - 112);
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [characterModifierCollectionChangedEventArgs @ L2 (System.Object)+8]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [characterModifierCollectionChangedEventArgs @ L2 (System.Object)+8]");
			if ((nint)0 != 1)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @252");
			Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(SuperSneakers));
			object obj2 = default;
			if (typeFromHandle != obj2)
			{
				return;
			}
			_hasSuperSneakers = false;
			Transform transform = base.transform;
			Vector3 position = transform.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+44]");
			_previousCameraEndYPosition = 0f;
			Transform transform2 = base.transform;
			Quaternion rotation = transform2.rotation;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
			_ = 0;
			Quaternion rotation2 = (Quaternion)(vector + 48);
			Vector3 vector2 = Quaternion.Internal_ToEulerRad(rotation2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
			float num = 0f * 57.29578f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+44]");
			float num2 = 0f * 57.29578f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
			float num3 = 0f * 57.29578f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
			_ = 0;
			Vector3 euler = vector + 32;
			Vector3 vector3 = Quaternion.Internal_MakePositive(euler);
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @252");
			Type typeFromHandle2 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(SuperSneakers));
			object obj3 = default;
			if (typeFromHandle2 != obj3)
			{
				return;
			}
			_hasSuperSneakers = true;
			Transform transform3 = base.transform;
			Vector3 position2 = transform3.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+44]");
			_previousCameraEndYPosition = 0f;
			Transform transform4 = base.transform;
			Quaternion rotation3 = transform4.rotation;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
			_ = 0;
			Quaternion rotation4 = (Quaternion)(vector + 16);
			Vector3 vector4 = Quaternion.Internal_ToEulerRad(rotation4);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
			float num4 = 0f * 57.29578f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+44]");
			float num5 = 0f * 57.29578f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
			float num6 = 0f * 57.29578f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
			((Vector3*)(nint)vector)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
			((Vector3*)(nint)vector)->x = 0f;
			Vector3 vector5 = Quaternion.Internal_MakePositive(vector);
		}
		_tweenTimeTransform = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
		_previousCameraEndXRotation = 0f;
	}

	public CameraData GetDefaultCameraDataForMenu()
	{
		CameraData defaultCameraData = ((CharacterCamera)null).GetDefaultCameraData();
		defaultCameraData._cameraDataMode = CameraDataMode.CameraUpdateDisabled;
		SmoothDampFloat fieldOfView = defaultCameraData._fieldOfView;
		fieldOfView._target = 71f;
		return defaultCameraData;
	}

	public CameraData GetDefaultCameraData()
	{
		CameraData cameraData = default;
		cameraData._002Ector();
		return cameraData;
	}

	public CharacterCamera()
	{
		//IL_001e: Expected I, but got Obj
		//IL_0059: Expected I, but got Obj
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S0_v8 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		_shake = Vector3.zeroVector;
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v17 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v18 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		_diff = Vector3.zeroVector;
		_cameraModifierY = 0.5f;
		base._002Ector();
	}
}
