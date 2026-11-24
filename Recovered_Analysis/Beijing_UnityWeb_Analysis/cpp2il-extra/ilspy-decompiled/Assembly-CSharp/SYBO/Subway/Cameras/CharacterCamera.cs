using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Common;
using SYBO.Common.Automation;
using SYBO.Common.Benchmarking;
using SYBO.Common.Data;
using SYBO.Subway.Automation.Samplers;
using SYBO.Subway.Benchmarking;
using SYBO.Subway.Characters;
using SYBO.Subway.Inputs;
using SYBO.Subway.Level;
using SYBO.Subway.Pickups;
using SYBO.Subway.Routes;
using SYBO.Subway.StateSystem;
using UnityEngine;
using UnityEngine.Rendering;

namespace SYBO.Subway.Cameras;

public class CharacterCamera : MonoBehaviour
{
	public enum CameraState
	{
		Menu,
		DefaultRunning,
		Custom
	}

	private sealed class _003CFOVTarget_Coroutine_003Ed__86(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0068: Unknown result type (might be due to invalid IL or missing references)
				//IL_006d: Expected Obj, but got Unknown
				//IL_0076: Expected Obj, but got I4
				//IL_008a: Expected Obj, but got I4
				if (_003C_003E1__state != 0 && _003C_003E1__state != 1)
				{
					return null;
				}
				_003C_003E1__state = -1;
				object obj = this + 12;
				obj = 0;
				_003C_003E1__state = 1;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_003C_003E2__current != 0;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
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

	private const float LOW_ASPECT_RATIO = 1.5f;

	private const float HIGH_ASPECT_RATIO = 2.2f;

	private const float FRONTSCREEN_FOV_LOW_ASPECT_RATIO = 71f;

	private const float FRONTSCREEN_FOV_HIGH_ASPECT_RATIO = 80f;

	private float tunnelDelta;

	private MainCamera _mainCamera;

	private Vector3 _position;

	private Vector3 _target;

	public float _speed;

	private float _previousCameraEndYPosition;

	private float _previousCameraEndXRotation;

	private CameraData _currentCameraData;

	private CameraData _defaultCameraData;

	private CameraSpeedType _cameraSpeedType;

	private float _customhighSpeedFOV;

	private CameraState _currentCameraState;

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

	private bool _hasSuperSneakers;

	private float _cameraModifierColliderStartGamePositionZ;

	private Curve offsetDeltaCurve;

	private float _cameraModifierColliderEndGamePositionZ;

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
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0018: Expected F4, but got Obj
			//IL_0013: Expected native int or pointer, but got VT
			//IL_002d: Expected F4, but got I
			//IL_0028: Expected native int or pointer, but got VT
			object obj = this + 56;
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
			object obj = value + 20;
			CharacterCamera characterCamera = (CharacterCamera)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v2+8]");
			((UnityEngine.Object)this).m_CachedPtr = (IntPtr)0;
		}
	}

	public unsafe Vector3 Target
	{
		get
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected VT, but got Unknown
			//IL_0027: Expected F4, but got Obj
			//IL_0022: Expected native int or pointer, but got VT
			//IL_003c: Expected F4, but got I
			//IL_0037: Expected native int or pointer, but got VT
			_ = ((UnityEngine.Object)this).m_CachedPtr;
			object obj = default;
			Vector3 vector = (Vector3)(obj + 20);
			((Vector3*)(nint)vector)->x = (float)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((Vector3*)(nint)vector)->z = 0f;
			return vector;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			object obj = value + 32;
			CharacterCamera characterCamera = (CharacterCamera)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v2+8]");
			((UnityEngine.Object)this).m_CachedPtr = (IntPtr)0;
		}
	}

	public float Speed => _customhighSpeedFOV;

	public CameraData CameraData
	{
		get
		{
			return (CameraData)(object)_mainCamera;
		}
		private set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_002a: Expected VT, but got Obj
			//IL_004b: Expected VT, but got Obj
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Expected Obj, but got Unknown
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			//IL_007e: Expected Obj, but got Unknown
			Transform transform2 = default;
			Transform transform = (Transform)(transform2 + 16);
			GameObject gameObject = _camera.gameObject;
			transform.localPosition = (Vector3)gameObject;
			GameObject gameObject2 = _camera.gameObject;
			transform2.localRotation = (Quaternion)gameObject2;
			IBenchmarkMetric[] array = (IBenchmarkMetric[])(transform2 + 28);
			array = (IBenchmarkMetric[])(object)transform;
			_ = ((UnityEngine.Object)transform).m_CachedPtr;
			IMetricSampler[] array2 = (IMetricSampler[])(transform2 + 40);
			array2 = (IMetricSampler[])(object)transform2;
			_ = ((UnityEngine.Object)transform2).m_CachedPtr;
			((SubwayBenchmark)(object)this)._002Ector((IAutomationStep[])(object)value, array, array2);
		}
	}

	public CameraSpeedType CameraSpeedType
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (CameraSpeedType)_currentCameraData;
		}
		private set
		{
			//IL_014e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0153: Expected Obj, but got Unknown
			//IL_015c: Expected Obj, but got I4
			//IL_0168: Unknown result type (might be due to invalid IL or missing references)
			//IL_016d: Expected Obj, but got Unknown
			//IL_0175: Expected Obj, but got I4
			//IL_017e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0183: Expected Obj, but got Unknown
			//IL_0189: Unknown result type (might be due to invalid IL or missing references)
			//IL_018e: Expected Obj, but got Unknown
			//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b1: Expected Obj, but got Unknown
			//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c1: Expected Obj, but got Unknown
			//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ee: Expected Obj, but got Unknown
			//IL_020c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0211: Expected Obj, but got Unknown
			//IL_0245: Unknown result type (might be due to invalid IL or missing references)
			//IL_024a: Expected Obj, but got Unknown
			//IL_025b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0260: Expected Obj, but got Unknown
			//IL_0266: Unknown result type (might be due to invalid IL or missing references)
			//IL_026b: Expected Obj, but got Unknown
			//IL_0289: Unknown result type (might be due to invalid IL or missing references)
			//IL_028e: Expected Obj, but got Unknown
			//IL_0299: Unknown result type (might be due to invalid IL or missing references)
			//IL_029e: Expected Obj, but got Unknown
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Expected Obj, but got Unknown
			//IL_00dd: Expected VT, but got Obj
			//IL_00ef: Expected F4, but got I
			//IL_010b: Expected VT, but got Obj
			//IL_0139: Expected F4, but got Obj
			object obj2 = default;
			object obj = obj2 - -64;
			obj = 0;
			_ = 0;
			object obj3 = this + 56;
			obj3 = value;
			object obj4 = obj2 + 48;
			object obj5 = this + 32;
			obj4 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v10+8]");
			_ = 0;
			object obj6 = obj2 + 36;
			object obj7 = _currentCameraData + 32;
			obj6 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S1_v17+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			object obj8 = obj2 + 80;
			obj8 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v14+8]");
			_ = 0;
			InputEventArgs e = (InputEventArgs)(obj2 + 96);
			e = (InputEventArgs)obj6;
			InputEventArgs e2 = e;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v17+8]");
			e2._inputType = InputType.None;
			Game game = default;
			game.InputManager_OnInputEvent(obj8, e);
			object obj9 = this + 112;
			obj9 = game;
			object obj10 = obj2 + 24;
			object obj11 = this + 20;
			obj10 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S1_v36+8]");
			_ = 0;
			object obj12 = obj2 + 12;
			object obj13 = _currentCameraData + 56;
			obj12 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S1_v43+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			obj8 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v32+8]");
			_ = 0;
			e = (InputEventArgs)obj12;
			InputEventArgs e3 = e;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v35+8]");
			e3._inputType = InputType.None;
			Game game2 = default;
			game2.InputManager_OnInputEvent(obj8, e);
			object obj14 = this + 140;
			obj14 = game2;
			SmoothDampFloat fieldOfViewSmoothDampFloat = _fieldOfViewSmoothDampFloat;
			CameraData currentCameraData = _currentCameraData;
			SmoothDampFloat fieldOfView = currentCameraData._fieldOfView;
			fieldOfViewSmoothDampFloat._target = fieldOfView._target;
			SmoothDampFloat fieldOfViewSmoothDampFloat2 = _fieldOfViewSmoothDampFloat;
			CameraData currentCameraData2 = _currentCameraData;
			SmoothDampFloat fieldOfView2 = currentCameraData2._fieldOfView;
			fieldOfViewSmoothDampFloat2._smoothTime = fieldOfView2._smoothTime;
			GameObject gameObject = base.gameObject;
			((Transform)(object)e).position = (Vector3)gameObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v26 (SYBO.Subway.Inputs.InputEventArgs)+4]");
			_previousCameraEndYPosition = 0f;
			GameObject gameObject2 = base.gameObject;
			((Transform)obj8).rotation = (Quaternion)gameObject2;
			obj = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v23 (System.Object)+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F950");
			_previousCameraEndXRotation = (float)obj2;
			_tweenTimeTransform = 0f;
		}
	}

	public Camera Camera
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			return (Camera)(this - -64);
		}
	}

	public static CharacterCamera Instance
	{
		get
		{
			//IL_01d5: Expected I, but got Obj
			//IL_01eb: Expected Obj, but got I
			//IL_02b4: Expected I, but got Obj
			//IL_02ca: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0216: Expected I, but got Obj
			//IL_022c: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_00ad: Expected I, but got Obj
			//IL_00c3: Expected Obj, but got I
			//IL_0188: Expected I, but got Obj
			//IL_0253: Expected Obj, but got I4
			//IL_0257: Expected VT, but got Obj
			//IL_0265: Expected I, but got Obj
			//IL_027b: Expected Obj, but got I
			//IL_02a1: Expected Obj, but got VT
			//IL_00ee: Expected I, but got Obj
			//IL_013b: Expected I, but got Obj
			nint num = (nint)typeof(CharacterRendering);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Characters.CharacterRendering>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(CharacterRendering);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v53 (Il2CppClass<SYBO.Subway.Characters.CharacterRendering>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v16 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (CharacterRendering._instance != null)
			{
				nint num5 = (nint)typeof(Utils);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v30 (Il2CppClass<Utils>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num6 = (nint)typeof(Utils);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v49 (Il2CppClass<Utils>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				_0021_00210 val = (_0021_00210)Utils.FindComponentInThisOrParents<T>((MonoBehaviour)1);
				nint num7 = (nint)typeof(CharacterRendering);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v37 (Il2CppClass<SYBO.Subway.Characters.CharacterRendering>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num8 = (nint)typeof(CharacterRendering);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v43 (Il2CppClass<SYBO.Subway.Characters.CharacterRendering>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				CharacterRendering._instance = (CharacterRendering)val;
			}
			nint num9 = (nint)typeof(CharacterRendering);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v16 (Il2CppClass<SYBO.Subway.Characters.CharacterRendering>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num10 = (nint)typeof(CharacterRendering);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v23 (Il2CppClass<SYBO.Subway.Characters.CharacterRendering>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (CharacterCamera)(object)CharacterRendering._instance;
		}
	}

	public unsafe Vector3 CameraPositionValue
	{
		get
		{
			//IL_037d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0382: Expected VT, but got Unknown
			//IL_038b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0390: Expected VT, but got Unknown
			//IL_0399: Unknown result type (might be due to invalid IL or missing references)
			//IL_039e: Expected Obj, but got Unknown
			//IL_03a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ac: Expected Obj, but got Unknown
			//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ba: Expected Obj, but got Unknown
			//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c8: Expected Obj, but got Unknown
			//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d6: Expected Obj, but got Unknown
			//IL_03df: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e4: Expected Obj, but got Unknown
			//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f2: Expected Obj, but got Unknown
			//IL_035e: Expected Obj, but got VT
			//IL_036f: Expected Obj, but got VT
			//IL_001a: Expected Obj, but got VT
			//IL_011c: Expected Obj, but got I
			//IL_0147: Expected Obj, but got I
			//IL_016a: Expected I, but got Obj
			//IL_0180: Expected Obj, but got I
			//IL_0420: Expected F4, but got Obj
			//IL_041b: Expected native int or pointer, but got VT
			//IL_0435: Expected F4, but got I
			//IL_0430: Expected native int or pointer, but got VT
			//IL_0442: Expected F4, but got Obj
			//IL_043d: Expected native int or pointer, but got VT
			//IL_0457: Expected F4, but got I
			//IL_0452: Expected native int or pointer, but got VT
			//IL_047e: Expected Obj, but got I
			//IL_04aa: Expected F4, but got Obj
			//IL_04a5: Expected native int or pointer, but got VT
			//IL_04bf: Expected F4, but got I
			//IL_04ba: Expected native int or pointer, but got VT
			//IL_04cc: Expected F4, but got Obj
			//IL_04c7: Expected native int or pointer, but got VT
			//IL_04e1: Expected F4, but got I
			//IL_04dc: Expected native int or pointer, but got VT
			//IL_04f2: Expected Obj, but got VT
			//IL_04f2: Expected Obj, but got VT
			//IL_0055: Expected Obj, but got I
			//IL_0062: Expected F4, but got Obj
			//IL_005d: Expected native int or pointer, but got VT
			//IL_0077: Expected F4, but got I
			//IL_0072: Expected native int or pointer, but got VT
			//IL_0084: Expected native int or pointer, but got VT
			//IL_0096: Expected native int or pointer, but got VT
			//IL_00bb: Expected Obj, but got I
			//IL_00dd: Expected F4, but got Obj
			//IL_00d8: Expected native int or pointer, but got VT
			//IL_00f2: Expected F4, but got I
			//IL_00ed: Expected native int or pointer, but got VT
			//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f8: Expected Obj, but got Unknown
			//IL_0216: Expected Obj, but got I
			//IL_0241: Expected Obj, but got I
			//IL_0263: Expected F4, but got Obj
			//IL_025e: Expected native int or pointer, but got VT
			//IL_0278: Expected F4, but got I
			//IL_0273: Expected native int or pointer, but got VT
			//IL_0285: Expected F4, but got Obj
			//IL_0280: Expected native int or pointer, but got VT
			//IL_029a: Expected F4, but got I
			//IL_0295: Expected native int or pointer, but got VT
			//IL_02c1: Expected Obj, but got I
			//IL_01ab: Expected I, but got Obj
			//IL_02f2: Expected F4, but got Obj
			//IL_02ed: Expected native int or pointer, but got VT
			//IL_0307: Expected F4, but got I
			//IL_0302: Expected native int or pointer, but got VT
			//IL_0314: Expected F4, but got Obj
			//IL_030f: Expected native int or pointer, but got VT
			//IL_0329: Expected F4, but got I
			//IL_0324: Expected native int or pointer, but got VT
			//IL_033a: Expected Obj, but got VT
			//IL_033a: Expected Obj, but got VT
			//IL_0343: Unknown result type (might be due to invalid IL or missing references)
			//IL_0348: Expected Obj, but got Unknown
			object obj = default;
			Vector3 vector = (Vector3)(obj + 108);
			Vector3 vector2 = (Vector3)(obj + 96);
			object obj2 = obj + 84;
			object obj3 = obj + 72;
			object obj4 = obj + 60;
			object obj5 = obj + 48;
			object obj6 = obj + 36;
			object obj7 = obj + 24;
			object obj8 = obj + 12;
			Vector3 vector3 = default;
			if ((object)this != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+3C]");
				((CharacterCamera)vector3).CameraSpeedType = CameraSpeedType.Normal;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+48]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+38]");
					object obj9 = (nint)0 + (nint)32;
					((Vector3*)(nint)vector2)->x = (float)obj9;
					Vector3 vector4 = vector2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S2_v17+8]");
					((Vector3*)(nint)vector4)->z = 0f;
					((Vector3*)(nint)vector)->x = vector2.x;
					((Vector3*)(nint)vector)->z = vector2.z;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7516");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+38]");
					object obj10 = (nint)0 + (nint)56;
					obj2 = obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S2_v28+8]");
					_ = 0;
					((Vector3*)(nint)vector)->x = (float)obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
					((Vector3*)(nint)vector)->z = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7516");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+38]");
					object obj11 = (nint)0 + (nint)20;
					obj2 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S1_v20+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+90]");
					object obj12 = (nint)0 + (nint)248;
					obj3 = obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S1_v26+8]");
					_ = 0;
					nint num = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v39 (Il2CppClass<UnityEngine.Vector3>)+BA]");
					object obj13 = (nint)0 & (nint)0x200;
					if (obj13 != null)
					{
						nint num2 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S0_v81 (Il2CppClass<UnityEngine.Vector3>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					((Vector3*)(nint)vector2)->x = (float)obj2;
					Vector3 vector5 = vector2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
					((Vector3*)(nint)vector5)->z = 0f;
					((Vector3*)(nint)vector)->x = (float)obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
					((Vector3*)(nint)vector)->z = 0f;
					Vector3 vector6 = vector2 - vector;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+38]");
					object obj14 = (nint)0 + (nint)32;
					obj5 = obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ S1_v42+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					((Vector3*)(nint)vector2)->x = (float)obj4;
					Vector3 vector7 = vector2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
					((Vector3*)(nint)vector7)->z = 0f;
					((Vector3*)(nint)vector)->x = (float)obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
					((Vector3*)(nint)vector)->z = 0f;
					Game game = default;
					game.InputManager_OnInputEvent((object)vector2, (InputEventArgs)vector);
					object obj15 = vector3 + 112;
					obj15 = game;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+38]");
					object obj16 = (nint)0 + (nint)44;
					obj6 = obj16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ S1_v59+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+90]");
					object obj17 = (nint)0 + (nint)248;
					obj7 = obj17;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ S1_v65+8]");
					_ = 0;
					((Vector3*)(nint)vector2)->x = (float)obj6;
					Vector3 vector8 = vector2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v21+8]");
					((Vector3*)(nint)vector8)->z = 0f;
					((Vector3*)(nint)vector)->x = (float)obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v23+8]");
					((Vector3*)(nint)vector)->z = 0f;
					Vector3 vector9 = vector2 - vector;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+38]");
					object obj18 = (nint)0 + (nint)56;
					obj = obj18;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ S1_v80+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					((Vector3*)(nint)vector2)->x = (float)obj8;
					Vector3 vector10 = vector2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v25+8]");
					((Vector3*)(nint)vector10)->z = 0f;
					((Vector3*)(nint)vector)->x = (float)obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					((Vector3*)(nint)vector)->z = 0f;
					Game game2 = default;
					game2.InputManager_OnInputEvent((object)vector2, (InputEventArgs)vector);
					object obj19 = vector3 + 140;
					obj19 = game2;
				}
			}
			else
			{
				CameraData defaultCameraData = ((CharacterCamera)vector3).GetDefaultCameraData();
				((CharacterCamera)vector3).CameraData = defaultCameraData;
			}
			return vector3;
		}
	}

	public MainCamera MainCamera => (MainCamera)(object)_camera;

	public void SetCameraDataForcefully(CameraData cameraData)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		_ = cameraData._cameraDataMode;
		object obj = this + 32;
		obj = cameraData;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
	}

	public void SetCameraDataForcefully(CameraData cameraData, Vector3 cameraLocalPosition, Quaternion cameraLocalRotation)
	{
		//IL_0009: Invalid comparison between VT and I4
		//IL_0060: Invalid comparison between I and F4
		if (cameraLocalRotation != (Quaternion)(object)0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Cameras.CharacterCamera)+21]");
			if ((nint)0 != 0)
			{
				return;
			}
		}
		float time = Time.time;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Cameras.CharacterCamera)+1C]");
		if (!(0f < time))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8966");
		}
	}

	public void SetCameraState(CameraState state)
	{
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected Obj, but got Unknown
		//IL_01e3: Expected Obj, but got I4
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected Obj, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected Obj, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected Obj, but got Unknown
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected Obj, but got Unknown
		object obj = this - -64;
		obj = state;
		object obj2 = this - -64;
		if (obj2 != null)
		{
			if ((nint)obj2 != 1)
			{
				if ((nint)obj2 != 2)
				{
					if ((nint)obj2 != 3)
					{
						object obj3 = this - -64;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
						throw new NullReferenceException();
					}
					SmoothDampFloat fieldOfViewSmoothDampFloat = _fieldOfViewSmoothDampFloat;
					fieldOfViewSmoothDampFloat._target = _customhighSpeedFOV;
					SmoothDampFloat fieldOfViewSmoothDampFloat2 = _fieldOfViewSmoothDampFloat;
					fieldOfViewSmoothDampFloat2._smoothTime = 1f;
				}
				else
				{
					SmoothDampFloat fieldOfViewSmoothDampFloat3 = _fieldOfViewSmoothDampFloat;
					fieldOfViewSmoothDampFloat3._target = 10f;
					SmoothDampFloat fieldOfViewSmoothDampFloat4 = _fieldOfViewSmoothDampFloat;
					fieldOfViewSmoothDampFloat4._smoothTime = 1f;
				}
			}
			else
			{
				SmoothDampFloat fieldOfViewSmoothDampFloat5 = _fieldOfViewSmoothDampFloat;
				fieldOfViewSmoothDampFloat5._target = 5f;
				SmoothDampFloat fieldOfViewSmoothDampFloat6 = _fieldOfViewSmoothDampFloat;
				fieldOfViewSmoothDampFloat6._smoothTime = 1f;
			}
		}
		else if (_currentCameraData != null)
		{
			object obj4 = this + 148;
			CameraData currentCameraData = _currentCameraData;
			obj4 = currentCameraData._fieldOfView;
		}
		else
		{
			object obj5 = this - -64;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			string text = default;
			string msg = "We are missing a _cameraData when _cameraSpeedType: " + text;
			SDebug.LogFormat(msg, null);
		}
	}

	protected void Awake()
	{
		CancelInvoke();
	}

	private CharacterCamera Initialize()
	{
		return (CharacterCamera)(object)_mainCamera;
	}

	protected void Start()
	{
		IEnumerator enumerator = FOVTarget_Coroutine();
	}

	private void Character_OnStumble(Character.StumbleType stumbleType, Character.StumbleHorizontalHit horizontalHit, Character.StumbleVerticalHit verticalHit, string colliderName, bool safeStumble)
	{
		//IL_000e: Expected Obj, but got I4
		//IL_0058: Expected Obj, but got F4
		//IL_0070: Expected Obj, but got VT
		//IL_0080: Expected Obj, but got F4
		//IL_0098: Expected Obj, but got VT
		//IL_00c6: Expected Obj, but got I
		//IL_00e3: Expected Obj, but got I
		//IL_00e3: Expected Obj, but got I
		//IL_0299: Expected Obj, but got F4
		//IL_02c1: Expected Obj, but got I
		//IL_02de: Expected Obj, but got I
		//IL_02de: Expected Obj, but got I
		//IL_05c3: Expected Obj, but got I
		//IL_05e0: Expected Obj, but got I
		//IL_05e0: Expected Obj, but got I
		//IL_0628: Expected Obj, but got F4
		//IL_0648: Expected Obj, but got VT
		//IL_060c: Expected Obj, but got F4
		//IL_0658: Expected Obj, but got F4
		//IL_066b: Expected Obj, but got VT
		//IL_07b7: Expected Obj, but got VT
		//IL_0751: Expected Obj, but got F4
		//IL_0764: Expected Obj, but got VT
		//IL_020c: Expected Obj, but got F4
		//IL_0224: Expected Obj, but got VT
		//IL_0237: Expected Obj, but got I4
		//IL_0578: Expected Obj, but got F4
		//IL_0590: Expected Obj, but got VT
		//IL_072e: Expected Obj, but got F4
		//IL_0741: Expected Obj, but got VT
		//IL_0506: Expected Obj, but got F4
		//IL_051e: Expected Obj, but got VT
		//IL_0271: Expected Obj, but got F4
		//IL_0289: Expected Obj, but got VT
		//IL_0699: Expected Obj, but got I
		//IL_06b6: Expected Obj, but got I
		//IL_06b6: Expected Obj, but got I
		//IL_043b: Expected Obj, but got I
		//IL_0458: Expected Obj, but got I
		//IL_0458: Expected Obj, but got I
		//IL_06fe: Expected Obj, but got F4
		//IL_054b: Expected Obj, but got F4
		//IL_0563: Expected Obj, but got VT
		//IL_04b1: Expected Obj, but got F4
		//IL_04c9: Expected Obj, but got VT
		//IL_071e: Expected Obj, but got VT
		//IL_06e2: Expected Obj, but got F4
		//IL_04d9: Expected Obj, but got F4
		//IL_04f1: Expected Obj, but got VT
		//IL_0484: Expected Obj, but got F4
		//IL_049c: Expected Obj, but got VT
		object obj = stumbleType - 1;
		if (stumbleType != Character.StumbleType.Bush)
		{
			if ((nint)obj == 1)
			{
				CameraData currentCameraData = _currentCameraData;
				CameraData currentCameraData2 = _currentCameraData;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S1_v10 (SYBO.Subway.Cameras.CameraData)+8C]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S0_v9 (SYBO.Subway.Cameras.CameraData)+8C]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v11+14]");
				IEnumerator enumerator = ((LongMagnet)num).PullPickupSpawnPoint((PickupSpawnPoint)0);
				if (enumerator == null && !((Game)null).IsInPogostickMode && !((Game)null).HasSuperSneakers)
				{
					if (horizontalHit != Character.StumbleHorizontalHit.Left && horizontalHit != Character.StumbleHorizontalHit.LeftCorner)
					{
						if (horizontalHit != Character.StumbleHorizontalHit.Center && (horizontalHit == Character.StumbleHorizontalHit.RightCorner || horizontalHit == Character.StumbleHorizontalHit.Right))
						{
							goto IL_0266;
						}
					}
					else
					{
						string stumbleRightSide = ((CharacterRendering.Animations)_previousCameraEndYPosition).StumbleRightSide;
						((RouteChunk)_diff).HideLogicRecursive((Transform)(object)stumbleRightSide, 0.2f);
						object obj3 = horizontalHit + -3;
						if ((nint)obj3 < 2)
						{
							goto IL_0266;
						}
					}
				}
				goto IL_076a;
			}
			switch (horizontalHit)
			{
			case Character.StumbleHorizontalHit.Center:
				switch (verticalHit)
				{
				case Character.StumbleVerticalHit.Lower:
				{
					CameraData currentCameraData7 = _currentCameraData;
					CameraData currentCameraData8 = _currentCameraData;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ S1_v55 (SYBO.Subway.Cameras.CameraData)+8C]");
					object obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ S0_v58 (SYBO.Subway.Cameras.CameraData)+8C]");
					nint num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ S1_v56+14]");
					IEnumerator enumerator4 = ((LongMagnet)num4).PullPickupSpawnPoint((PickupSpawnPoint)0);
					if (enumerator4 != null)
					{
						string stumbleLeftSide = ((CharacterRendering.Animations)_previousCameraEndYPosition).StumbleLeftSide;
						((RouteChunk)_diff).HideLogicRecursive((Transform)(object)stumbleLeftSide, 0.05f);
					}
					else
					{
						string stumbleDeath = ((CharacterRendering.Animations)_previousCameraEndYPosition).StumbleDeath;
						((RouteChunk)_diff).HideLogicRecursive((Transform)(object)stumbleDeath, 0.05f);
					}
					string land2 = ((CharacterRendering.Animations)_previousCameraEndYPosition).Land;
					((SafeAnimation)_diff).CrossFade(land2, 0.5f);
					break;
				}
				case Character.StumbleVerticalHit.Middle:
				{
					string hitUpper = ((CharacterRendering.Animations)_previousCameraEndYPosition).HitUpper;
					((RouteChunk)_diff).HideLogicRecursive((Transform)(object)hitUpper, 0.07f);
					if (safeStumble)
					{
						string land = ((CharacterRendering.Animations)_previousCameraEndYPosition).Land;
						((SafeAnimation)_diff).CrossFade(land, 0.3f);
					}
					break;
				}
				case Character.StumbleVerticalHit.Upper:
				{
					string hitLower = ((CharacterRendering.Animations)_previousCameraEndYPosition).HitLower;
					((RouteChunk)_diff).HideLogicRecursive((Transform)(object)hitLower, 0.07f);
					break;
				}
				}
				return;
			case Character.StumbleHorizontalHit.Left:
			{
				CameraData currentCameraData5 = _currentCameraData;
				CameraData currentCameraData6 = _currentCameraData;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S2_v26 (SYBO.Subway.Cameras.CameraData)+8C]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S1_v34 (SYBO.Subway.Cameras.CameraData)+8C]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S2_v27+14]");
				IEnumerator enumerator3 = ((LongMagnet)num3).PullPickupSpawnPoint((PickupSpawnPoint)0);
				IEnumerator workItem2;
				if (enumerator3 != null)
				{
					string stumbleRightCorner = ((CharacterRendering.Animations)_previousCameraEndYPosition).StumbleRightCorner;
					workItem2 = (IEnumerator)(object)stumbleRightCorner;
				}
				else
				{
					string stumbleRightSide2 = ((CharacterRendering.Animations)_previousCameraEndYPosition).StumbleRightSide;
					workItem2 = (IEnumerator)(object)stumbleRightSide2;
				}
				((WorkLoadQueue)_diff).EnqueueWork(workItem2);
				break;
			}
			case Character.StumbleHorizontalHit.LeftCorner:
			{
				string stumbleRightCorner2 = ((CharacterRendering.Animations)_previousCameraEndYPosition).StumbleRightCorner;
				((WorkLoadQueue)_diff).EnqueueWork((IEnumerator)(object)stumbleRightCorner2);
				break;
			}
			case Character.StumbleHorizontalHit.Right:
			{
				CameraData currentCameraData3 = _currentCameraData;
				CameraData currentCameraData4 = _currentCameraData;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ S2_v54 (SYBO.Subway.Cameras.CameraData)+8C]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S1_v74 (SYBO.Subway.Cameras.CameraData)+8C]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ S2_v55+14]");
				IEnumerator enumerator2 = ((LongMagnet)num2).PullPickupSpawnPoint((PickupSpawnPoint)0);
				IEnumerator workItem;
				if (enumerator2 != null)
				{
					string wallRideLeft2 = ((CharacterRendering.Animations)_previousCameraEndYPosition).WallRideLeft;
					workItem = (IEnumerator)(object)wallRideLeft2;
				}
				else
				{
					string stumbleLeftCorner = ((CharacterRendering.Animations)_previousCameraEndYPosition).StumbleLeftCorner;
					workItem = (IEnumerator)(object)stumbleLeftCorner;
				}
				((WorkLoadQueue)_diff).EnqueueWork(workItem);
				break;
			}
			case Character.StumbleHorizontalHit.RightCorner:
			{
				string wallRideLeft = ((CharacterRendering.Animations)_previousCameraEndYPosition).WallRideLeft;
				((WorkLoadQueue)_diff).EnqueueWork((IEnumerator)(object)wallRideLeft);
				break;
			}
			}
			string land3 = ((CharacterRendering.Animations)_previousCameraEndYPosition).Land;
			((SafeAnimation)_diff).Play(land3);
			return;
		}
		string stumbleLeftSide2 = ((CharacterRendering.Animations)_previousCameraEndYPosition).StumbleLeftSide;
		((RouteChunk)_diff).HideLogicRecursive((Transform)(object)stumbleLeftSide2, 0.05f);
		string land4 = ((CharacterRendering.Animations)_previousCameraEndYPosition).Land;
		((SafeAnimation)_diff).CrossFade(land4, 0.5f);
		return;
		IL_0266:
		string stumbleLeftCorner2 = ((CharacterRendering.Animations)_previousCameraEndYPosition).StumbleLeftCorner;
		((RouteChunk)_diff).HideLogicRecursive((Transform)(object)stumbleLeftCorner2, 0.2f);
		goto IL_076a;
		IL_076a:
		CameraData defaultCameraData = _defaultCameraData;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v15 (SYBO.Subway.Cameras.CameraData)+9E]");
		if ((nint)0 == 0)
		{
			string land5 = ((CharacterRendering.Animations)_previousCameraEndYPosition).Land;
			CameraData currentCameraData9 = _currentCameraData;
			CameraData currentCameraData10 = _currentCameraData;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S3_v7 (SYBO.Subway.Cameras.CameraData)+8C]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S2_v11 (SYBO.Subway.Cameras.CameraData)+8C]");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S3_v8+14]");
			IEnumerator enumerator5 = ((LongMagnet)num5).PullPickupSpawnPoint((PickupSpawnPoint)0);
			float fadeLength = ((enumerator5 == null) ? 0.02f : 0.4f);
			((SafeAnimation)_diff).CrossFade(land5, fadeLength);
		}
	}

	protected unsafe void LateUpdate()
	{
		//IL_0061: Expected I, but got Obj
		//IL_0077: Expected Obj, but got I
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected Obj, but got Unknown
		//IL_00b8: Expected Obj, but got I
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = this + 144;
		bool isInstantiated = Game.IsInstantiated;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S1_v5 (System.Boolean)+88]");
		obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Character.OnStumbleDelegate onStumbleDelegate = default;
		((Delegate)onStumbleDelegate).method_ptr = method_ptr;
		((Delegate)onStumbleDelegate).method = (nint)__ldftn(CharacterCamera.Character_OnStumble);
		object obj3 = onStumbleDelegate + 16;
		obj3 = this;
		_character.OnStumble -= onStumbleDelegate;
	}

	private unsafe void DebugLogCameraDetails()
	{
		//IL_11c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_11c5: Expected Obj, but got Unknown
		//IL_11ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_11d3: Expected VT, but got Unknown
		//IL_11dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_11e1: Expected Obj, but got Unknown
		//IL_11ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ef: Expected Obj, but got Unknown
		//IL_11f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_11fd: Expected Obj, but got Unknown
		//IL_1206: Unknown result type (might be due to invalid IL or missing references)
		//IL_120b: Expected Obj, but got Unknown
		//IL_1214: Unknown result type (might be due to invalid IL or missing references)
		//IL_1219: Expected Obj, but got Unknown
		//IL_1222: Unknown result type (might be due to invalid IL or missing references)
		//IL_1227: Expected Ref, but got Unknown
		//IL_1230: Unknown result type (might be due to invalid IL or missing references)
		//IL_1235: Expected Obj, but got Unknown
		//IL_123e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1243: Expected Obj, but got Unknown
		//IL_124c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1251: Expected Obj, but got Unknown
		//IL_125a: Unknown result type (might be due to invalid IL or missing references)
		//IL_125f: Expected Obj, but got Unknown
		//IL_1268: Unknown result type (might be due to invalid IL or missing references)
		//IL_126d: Expected Obj, but got Unknown
		//IL_1276: Unknown result type (might be due to invalid IL or missing references)
		//IL_127b: Expected Obj, but got Unknown
		//IL_1284: Expected Obj, but got I4
		//IL_1293: Unknown result type (might be due to invalid IL or missing references)
		//IL_1298: Expected Obj, but got Unknown
		//IL_12a1: Expected Obj, but got I4
		//IL_12b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_12b5: Expected Obj, but got Unknown
		//IL_12be: Expected Obj, but got I4
		//IL_12cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_12d2: Expected Obj, but got Unknown
		//IL_12db: Expected Obj, but got I4
		//IL_12ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ef: Expected Obj, but got Unknown
		//IL_12f8: Expected Obj, but got I4
		//IL_1307: Unknown result type (might be due to invalid IL or missing references)
		//IL_130c: Expected Obj, but got Unknown
		//IL_1315: Expected Obj, but got I4
		//IL_1324: Unknown result type (might be due to invalid IL or missing references)
		//IL_1329: Expected Obj, but got Unknown
		//IL_1332: Expected Obj, but got I4
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_0027: Expected F4, but got Obj
		//IL_0022: Expected native int or pointer, but got VT
		//IL_003c: Expected F4, but got I
		//IL_0037: Expected native int or pointer, but got VT
		//IL_0049: Expected Obj, but got F4
		//IL_005b: Expected I, but got F4
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected Obj, but got Unknown
		//IL_00c6: Expected I4, but got Obj
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected Obj, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected Obj, but got Unknown
		//IL_04f1: Expected I, but got Obj
		//IL_0507: Expected Obj, but got I
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected Obj, but got Unknown
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected Obj, but got Unknown
		//IL_1368: Unknown result type (might be due to invalid IL or missing references)
		//IL_136d: Expected Obj, but got Unknown
		//IL_137f: Expected F4, but got I
		//IL_064c: Expected I, but got Obj
		//IL_0662: Expected Obj, but got I
		//IL_0532: Expected I, but got Obj
		//IL_057c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0581: Expected Obj, but got Unknown
		//IL_05ad: Invalid comparison between I and F4
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Expected Obj, but got Unknown
		//IL_02f7: Expected F4, but got Obj
		//IL_02f2: Expected native int or pointer, but got VT
		//IL_030c: Expected F4, but got I
		//IL_0307: Expected native int or pointer, but got VT
		//IL_0319: Expected Obj, but got F4
		//IL_032b: Expected I, but got F4
		//IL_13ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f1: Expected Obj, but got Unknown
		//IL_142d: Expected F4, but got Obj
		//IL_1428: Expected native int or pointer, but got VT
		//IL_143f: Expected F4, but got I
		//IL_143a: Expected native int or pointer, but got VT
		//IL_144a: Unknown result type (might be due to invalid IL or missing references)
		//IL_144f: Expected Obj, but got Unknown
		//IL_1499: Expected Obj, but got F4
		//IL_068d: Expected I, but got Obj
		//IL_034d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0352: Expected Obj, but got Unknown
		//IL_0396: Expected I4, but got Obj
		//IL_05d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05dc: Expected Obj, but got Unknown
		//IL_062f: Expected Obj, but got F4
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a6: Expected Obj, but got Unknown
		//IL_06d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06dc: Expected Obj, but got Unknown
		//IL_03ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0404: Expected Obj, but got Unknown
		//IL_1507: Unknown result type (might be due to invalid IL or missing references)
		//IL_150c: Expected Obj, but got Unknown
		//IL_1540: Expected Obj, but got I
		//IL_1582: Unknown result type (might be due to invalid IL or missing references)
		//IL_1587: Expected Obj, but got Unknown
		//IL_1600: Expected I, but got Obj
		//IL_1616: Expected Obj, but got I
		//IL_045b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0460: Expected Obj, but got Unknown
		//IL_04a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ab: Expected Obj, but got Unknown
		//IL_17fb: Invalid comparison between I and F4
		//IL_138b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1390: Expected Obj, but got Unknown
		//IL_13a2: Expected F4, but got I
		//IL_1ed6: Invalid comparison between I and F4
		//IL_09a3: Invalid comparison between I and F4
		//IL_0947: Expected I, but got Obj
		//IL_0816: Expected I, but got Obj
		//IL_082c: Expected Obj, but got I
		//IL_09df: Expected F4, but got I
		//IL_16eb: Expected I, but got Obj
		//IL_1701: Expected Obj, but got I
		//IL_186b: Expected I, but got Obj
		//IL_1881: Expected Obj, but got I
		//IL_0857: Expected I, but got Obj
		//IL_18ee: Expected F4, but got I
		//IL_18ee: Expected VT, but got Obj
		//IL_191e: Expected VT, but got Obj
		//IL_172b: Expected F4, but got Obj
		//IL_1726: Expected native int or pointer, but got VT
		//IL_1740: Expected F4, but got I
		//IL_173b: Expected native int or pointer, but got VT
		//IL_174b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1750: Expected Obj, but got Unknown
		//IL_08ec: Expected I, but got Obj
		//IL_0a3e: Expected F4, but got Obj
		//IL_0a39: Expected native int or pointer, but got VT
		//IL_0a53: Expected F4, but got I
		//IL_0a4e: Expected native int or pointer, but got VT
		//IL_0a7d: Expected VT, but got Obj
		//IL_0aa4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa9: Expected Obj, but got Unknown
		//IL_0ac6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0acb: Expected Obj, but got Unknown
		//IL_0af1: Invalid comparison between Obj and F4
		//IL_09f2: Expected I, but got Obj
		//IL_0b50: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b55: Expected Obj, but got Unknown
		//IL_0b62: Expected F4, but got Obj
		//IL_0b5d: Expected native int or pointer, but got VT
		//IL_0b77: Expected F4, but got I
		//IL_0b72: Expected native int or pointer, but got VT
		//IL_192f: Expected Obj, but got F4
		//IL_1935: Unknown result type (might be due to invalid IL or missing references)
		//IL_193a: Expected Obj, but got Unknown
		//IL_1945: Unknown result type (might be due to invalid IL or missing references)
		//IL_194a: Expected Obj, but got Unknown
		//IL_1957: Expected F4, but got Obj
		//IL_1952: Expected native int or pointer, but got VT
		//IL_196c: Expected F4, but got I
		//IL_1967: Expected native int or pointer, but got VT
		//IL_1977: Unknown result type (might be due to invalid IL or missing references)
		//IL_197c: Expected Obj, but got Unknown
		//IL_19f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_19fe: Expected Obj, but got Unknown
		//IL_1a32: Expected Obj, but got I
		//IL_1a74: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a79: Expected Obj, but got Unknown
		//IL_1a99: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a9e: Expected Obj, but got Unknown
		//IL_1ad3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ad8: Expected Obj, but got Unknown
		//IL_1af6: Expected Obj, but got I4
		//IL_1b21: Expected Obj, but got I
		//IL_1b56: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b5b: Expected Obj, but got Unknown
		//IL_0b16: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1b: Expected Obj, but got Unknown
		//IL_0b23: Expected F4, but got Obj
		//IL_1ba3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ba8: Expected Obj, but got Unknown
		//IL_1bb5: Expected F4, but got Obj
		//IL_1bb0: Expected native int or pointer, but got VT
		//IL_1bca: Expected F4, but got I
		//IL_1bc5: Expected native int or pointer, but got VT
		//IL_1bd7: Expected Obj, but got F4
		//IL_1be9: Expected I, but got F4
		//IL_0cb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb9: Expected Obj, but got Unknown
		//IL_0cfd: Expected I4, but got Obj
		//IL_0b9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba0: Expected Obj, but got Unknown
		//IL_0ba6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bab: Expected Obj, but got Unknown
		//IL_0bb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb6: Expected Obj, but got Unknown
		//IL_0bc6: Expected Obj, but got I
		//IL_0bd4: Expected I, but got Obj
		//IL_0bea: Expected Obj, but got I
		//IL_1ce8: Expected VT, but got Obj
		//IL_0fd1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd6: Expected Obj, but got Unknown
		//IL_1001: Expected I, but got Obj
		//IL_1017: Expected Obj, but got I
		//IL_0d5c: Expected VT, but got Obj
		//IL_0d5c: Expected Obj, but got VT
		//IL_1c37: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c3c: Expected Obj, but got Unknown
		//IL_1c64: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c69: Expected Obj, but got Unknown
		//IL_1c94: Expected I, but got Obj
		//IL_1caa: Expected Obj, but got I
		//IL_0c15: Expected I, but got Obj
		//IL_1db7: Expected F4, but got Obj
		//IL_1db2: Expected native int or pointer, but got VT
		//IL_1dc9: Expected F4, but got I
		//IL_1dc4: Expected native int or pointer, but got VT
		//IL_1df0: Expected VT, but got Obj
		//IL_0d6e: Expected Obj, but got F4
		//IL_1f59: Expected F4, but got Obj
		//IL_1f54: Expected native int or pointer, but got VT
		//IL_1f6b: Expected F4, but got I
		//IL_1f66: Expected native int or pointer, but got VT
		//IL_1f92: Expected VT, but got Obj
		//IL_1fa1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fa6: Expected Obj, but got Unknown
		//IL_1fc8: Expected F4, but got Obj
		//IL_1fc3: Expected native int or pointer, but got VT
		//IL_1fda: Expected F4, but got I
		//IL_1fd5: Expected native int or pointer, but got VT
		//IL_2004: Expected VT, but got Obj
		//IL_202b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2030: Expected Obj, but got Unknown
		//IL_1099: Expected I, but got Obj
		//IL_10af: Expected Obj, but got I
		//IL_1042: Expected I, but got Obj
		//IL_0db0: Expected VT, but got Obj
		//IL_0dc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dcd: Expected Obj, but got Unknown
		//IL_0de5: Expected I, but got Obj
		//IL_0dfb: Expected Obj, but got I
		//IL_0c6f: Expected I, but got Obj
		//IL_1d1e: Expected F4, but got I
		//IL_1d3e: Expected VT, but got Obj
		//IL_112f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1134: Expected Obj, but got Unknown
		//IL_117a: Unknown result type (might be due to invalid IL or missing references)
		//IL_117f: Expected Obj, but got Unknown
		//IL_10da: Expected I, but got Obj
		//IL_0eb4: Expected F4, but got Obj
		//IL_0e26: Expected I, but got Obj
		//IL_1e7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e83: Expected Obj, but got Unknown
		//IL_1e95: Expected F4, but got I
		//IL_0ec5: Expected Obj, but got F4
		//IL_0f2b: Expected I, but got Obj
		//IL_0f41: Expected Obj, but got I
		//IL_1d7a: Expected Obj, but got VT
		//IL_0f6c: Expected I, but got Obj
		object obj = default;
		Transform transform = (Transform)(obj + 256);
		Vector3 vector = (Vector3)(obj + 240);
		Transform transform2 = (Transform)(obj + 140);
		Transform transform3 = (Transform)(obj + 128);
		Transform transform4 = (Transform)(obj + 112);
		object obj2 = obj + 100;
		object obj3 = obj + 88;
		ref Quaternion reference = ref *(Quaternion*)(obj + 72);
		object obj4 = obj + 60;
		object obj5 = obj + 48;
		object obj6 = obj + 36;
		object obj7 = obj + 24;
		object obj8 = obj + 12;
		object obj9 = obj + 228;
		obj9 = 0;
		_ = 0;
		object obj10 = obj + 216;
		obj10 = 0;
		_ = 0;
		object obj11 = obj + 204;
		obj11 = 0;
		_ = 0;
		object obj12 = obj + 192;
		obj12 = 0;
		_ = 0;
		object obj13 = obj + 180;
		obj13 = 0;
		_ = 0;
		object obj14 = obj + 168;
		obj14 = 0;
		_ = 0;
		object obj15 = obj + 152;
		obj15 = 0;
		_ = 0;
		if (_currentCameraState == CameraState.Custom)
		{
			GameObject gameObject = base.gameObject;
			object obj16 = this + 20;
			((Vector3*)(nint)vector)->x = (float)obj16;
			Vector3 vector2 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S2_v236+8]");
			((Vector3*)(nint)vector2)->z = 0f;
			transform = (Transform)vector.x;
			((UnityEngine.Object)transform).m_CachedPtr = (IntPtr)vector.z;
			Vector3 localPosition = transform.localPosition;
			GameObject gameObject2 = base.gameObject;
			object obj17 = this + 32;
			transform2 = (Transform)obj17;
			Transform transform5 = transform2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ S2_v246+8]");
			((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
			transform = transform2;
			((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)transform2).m_CachedPtr;
			((Transform)(object)gameObject2).SetSiblingIndex((int)transform);
			object obj18 = this + 32;
			transform3 = (Transform)obj18;
			Transform transform6 = transform3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ S2_v256+8]");
			((UnityEngine.Object)transform6).m_CachedPtr = (IntPtr)0;
			transform = transform3;
			((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)transform3).m_CachedPtr;
			_ = _cameraTarget.Velocity;
			((StackablePrefabData)(object)_cameraTarget)._002Ector();
			object obj19 = this + 20;
			transform4 = (Transform)obj19;
			Transform transform7 = transform4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ S2_v266+8]");
			((UnityEngine.Object)transform7).m_CachedPtr = (IntPtr)0;
			transform = transform4;
			((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)transform4).m_CachedPtr;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @73CB");
			((StackablePrefabData)(object)_cameraPosition)._002Ector();
			object obj20 = this + 20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ S1_v585+8]");
			float num = 0f - _lastZ;
			float unscaledTime = Time.unscaledTime;
			float speed = num / unscaledTime;
			_speed = speed;
			object obj21 = _speed & 0x7FFFFFFF;
			if ((nint)obj21 > 2139095040)
			{
				_speed = 0f;
			}
			object obj22 = this + 20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v521 @ S1_v593+8]");
			_lastZ = 0f;
			return;
		}
		if (_currentCameraData == null)
		{
			return;
		}
		CameraData currentCameraData = _currentCameraData;
		if (currentCameraData._cameraDataMode == CameraDataMode.CameraUpdateDisabled)
		{
			return;
		}
		CameraData currentCameraData2 = _currentCameraData;
		if (currentCameraData2._cameraDataMode != CameraDataMode.CameraUpdateEnabled_UseMyCameraData)
		{
			CameraData currentCameraData3 = _currentCameraData;
			if (currentCameraData3._cameraDataMode == CameraDataMode.CameraUpdateEnabled_DoNotUseMyCameraData)
			{
				GameObject gameObject3 = base.gameObject;
				object obj23 = this + 20;
				((Vector3*)(nint)vector)->x = (float)obj23;
				Vector3 vector3 = vector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ S2_v190+8]");
				((Vector3*)(nint)vector3)->z = 0f;
				transform = (Transform)vector.x;
				((UnityEngine.Object)transform).m_CachedPtr = (IntPtr)vector.z;
				Vector3 localPosition2 = transform.localPosition;
				GameObject gameObject4 = base.gameObject;
				object obj24 = this + 32;
				transform2 = (Transform)obj24;
				Transform transform8 = transform2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ S2_v200+8]");
				((UnityEngine.Object)transform8).m_CachedPtr = (IntPtr)0;
				transform = transform2;
				((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)transform2).m_CachedPtr;
				((Transform)(object)gameObject4).SetSiblingIndex((int)transform);
				object obj25 = this + 32;
				transform3 = (Transform)obj25;
				Transform transform9 = transform3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ S2_v210+8]");
				((UnityEngine.Object)transform9).m_CachedPtr = (IntPtr)0;
				transform = transform3;
				((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)transform3).m_CachedPtr;
				_ = _cameraTarget.Velocity;
				((StackablePrefabData)(object)_cameraTarget)._002Ector();
				object obj26 = this + 20;
				transform4 = (Transform)obj26;
				Transform transform10 = transform4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v526 @ S2_v220+8]");
				((UnityEngine.Object)transform10).m_CachedPtr = (IntPtr)0;
				transform = transform4;
				((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)transform4).m_CachedPtr;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @73CB");
				((StackablePrefabData)(object)_cameraPosition)._002Ector();
				object obj27 = this + 20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v620 @ S1_v549+8]");
				float num2 = 0f - _lastZ;
				float unscaledTime2 = Time.unscaledTime;
				float speed2 = num2 / unscaledTime2;
				_speed = speed2;
				object obj28 = _speed & 0x7FFFFFFF;
				if ((nint)obj28 > 2139095040)
				{
					_speed = 0f;
				}
				object obj29 = this + 20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v710 @ S1_v557+8]");
				_lastZ = 0f;
			}
			return;
		}
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ S0_v71 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj30 = (nint)0 & (nint)0x200;
		if (obj30 != null)
		{
			nint num4 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ S0_v412 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 one = Vector3.one;
		obj9 = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		if (offsetDeltaCurve != null)
		{
			object obj31 = _character + 236;
			transform = (Transform)obj31;
			Transform transform11 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ S1_v506+8]");
			((UnityEngine.Object)transform11).m_CachedPtr = (IntPtr)0;
			if ((float)(nint)((UnityEngine.Object)transform).m_CachedPtr < _cameraModifierColliderEndGamePositionZ)
			{
				object obj32 = _character + 236;
				transform = (Transform)obj32;
				Transform transform12 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ S1_v514+8]");
				((UnityEngine.Object)transform12).m_CachedPtr = (IntPtr)0;
				float t = (float)(nint)((UnityEngine.Object)transform).m_CachedPtr - _cameraModifierColliderStartGamePositionZ;
				Vector3 vector4 = offsetDeltaCurve.EvaluateDerivative(t);
				obj9 = vector.x;
				_ = vector.z;
				goto IL_13e1;
			}
		}
		nint num5 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ S0_v388 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj33 = (nint)0 & (nint)0x200;
		if (obj33 != null)
		{
			nint num6 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ S0_v395 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 one2 = Vector3.one;
		obj9 = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		goto IL_13e1;
		IL_07a3:
		float num7;
		if (_character.IsGliderboard)
		{
			bool isTeleboard = _character.IsTeleboard;
			num7 = 0.8f;
			if (isTeleboard)
			{
				goto IL_1633;
			}
		}
		num7 = 0.5f;
		goto IL_1633;
		IL_1633:
		Character character = _character;
		Variable<bool> isGrounded = character.IsGrounded;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v739 @ S0_v328 (Variable`1<System.Boolean>)+8]");
		bool flag = (nint)0 == 0;
		bool flag2 = !flag;
		float num8 = num7;
		if (!flag2)
		{
			float unscaledTime3 = Time.unscaledTime;
			nint num9 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v796 @ S1_v477 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj34 = (nint)0 & (nint)0x200;
			if (obj34 != null)
			{
				nint num10 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v827 @ S1_v482 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float t2 = unscaledTime3 * 2f;
			float num11 = Mathf.LerpUnclamped(_lastDeltaYFactor, num7, t2);
			num8 = num11;
		}
		transform = (Transform)obj10;
		Transform transform13 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v38+8]");
		((UnityEngine.Object)transform13).m_CachedPtr = (IntPtr)0;
		Character character2 = _character;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Transform)+4]");
		if (0f < character2.LastGroundedY)
		{
			transform = (Transform)obj10;
			Transform transform14 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v38+8]");
			((UnityEngine.Object)transform14).m_CachedPtr = (IntPtr)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Transform)+4]");
			_ = 0;
		}
		else
		{
			Character character3 = _character;
			_ = character3.LastGroundedY;
		}
		transform = (Transform)obj10;
		Transform transform15 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v38+8]");
		((UnityEngine.Object)transform15).m_CachedPtr = (IntPtr)0;
		Character character4 = _character;
		nint num12 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v849 @ S2_v164 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj35 = (nint)0 & (nint)0x200;
		if (obj35 != null)
		{
			nint num13 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v865 @ S2_v173 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Transform)+4]");
		float num14 = 0f - character4.LastGroundedY;
		bool flag3 = num14 > 0f;
		bool flag4 = !flag3;
		bool flag5 = !flag4;
		float num15 = num14;
		if (!flag5)
		{
			num15 = 0f;
		}
		((Vector3*)(nint)vector)->x = (float)obj11;
		Vector3 vector5 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v41+8]");
		((Vector3*)(nint)vector5)->z = 0f;
		object obj36 = _currentCameraData + 20;
		transform2 = (Transform)obj36;
		Transform transform16 = transform2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v912 @ S1_v457+8]");
		((UnityEngine.Object)transform16).m_CachedPtr = (IntPtr)0;
		float num16 = num8 * num15;
		float num17 = vector.y + num16;
		float num18 = num17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13 (UnityEngine.Transform)+4]");
		float num19 = num18 + 0f;
		_lastDeltaYFactor = num8;
		goto IL_14df;
		IL_13e1:
		object obj37 = _character + 248;
		transform = (Transform)obj37;
		Transform transform17 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ S1_v50+8]");
		((UnityEngine.Object)transform17).m_CachedPtr = (IntPtr)0;
		obj10 = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		((Vector3*)(nint)vector)->x = (float)transform;
		((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
		object obj38 = _currentCameraData + 20;
		transform2 = (Transform)obj38;
		Transform transform18 = transform2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ S1_v64+8]");
		((UnityEngine.Object)transform18).m_CachedPtr = (IntPtr)0;
		float num20 = vector.x + (float)transform2;
		float num21 = num20 * _cameraModifierX;
		obj11 = num21;
		CameraData currentCameraData4 = _currentCameraData;
		if (~(currentCameraData4._dontMoveInY ? 1u : 0u) == 0)
		{
			object obj39 = _cameraTarget + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ S1_v495+4]");
			_ = 0;
			goto IL_14df;
		}
		if (!_hasSuperSneakers)
		{
			Character character5 = _character;
			if (!character5.__isInLipFlight)
			{
				Character character6 = _character;
				Hoverboard hoverboard = character6._hoverboard;
				if (~(hoverboard.isActive ? 1u : 0u) == 0)
				{
					Character character7 = _character;
					Hoverboard hoverboard2 = character7._hoverboard;
					if (hoverboard2.isJumper)
					{
						goto IL_07a3;
					}
				}
				if (!_character.IsGliderboard)
				{
					num7 = 0f;
					goto IL_1633;
				}
			}
		}
		goto IL_07a3;
		IL_14df:
		transform2 = (Transform)obj10;
		Transform transform19 = transform2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v38+8]");
		((UnityEngine.Object)transform19).m_CachedPtr = (IntPtr)0;
		object obj40 = _currentCameraData + 20;
		transform3 = (Transform)obj40;
		Transform transform20 = transform3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v581 @ S1_v78+8]");
		((UnityEngine.Object)transform20).m_CachedPtr = (IntPtr)0;
		object obj41 = (nint)((UnityEngine.Object)transform2).m_CachedPtr + (nint)((UnityEngine.Object)transform3).m_CachedPtr;
		transform = (Transform)obj11;
		Transform transform21 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v41+8]");
		((UnityEngine.Object)transform21).m_CachedPtr = (IntPtr)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @73CB");
		((StackablePrefabData)(object)_cameraTarget)._002Ector();
		object obj42 = _cameraTarget + 32;
		transform4 = (Transform)obj42;
		Transform transform22 = transform4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v646 @ S1_v90+8]");
		((UnityEngine.Object)transform22).m_CachedPtr = (IntPtr)0;
		obj11 = transform4;
		_ = ((UnityEngine.Object)transform4).m_CachedPtr;
		obj2 = transform4;
		_ = ((UnityEngine.Object)transform4).m_CachedPtr;
		obj3 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v38+8]");
		_ = 0;
		reference = ref *(Quaternion*)obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v38+8]");
		_ = 0;
		nint num22 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v685 @ S1_v111 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj43 = (nint)0 & (nint)0x200;
		if (obj43 != null)
		{
			nint num23 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v711 @ S1_v429 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v23 (UnityEngine.Quaternion&)+4]");
		float num24 = 0f + 25f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v21+4]");
		float num25 = 0f - 5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+4]");
		if (0f < num25)
		{
			float num26 = num25;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+4]");
			if (0f > num24)
			{
				float num26 = num24;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+4]");
				float num26 = 0f;
			}
		}
		transform = (Transform)obj11;
		Transform transform23 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v41+8]");
		((UnityEngine.Object)transform23).m_CachedPtr = (IntPtr)0;
		_ = _cameraTarget.Velocity;
		obj4 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v41+8]");
		_ = 0;
		nint num27 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v821 @ S0_v131 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj44 = (nint)0 & (nint)0x200;
		if (obj44 != null)
		{
			nint num28 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v855 @ S0_v317 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 down = Vector3.down;
		obj6 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v35+8]");
		_ = 0;
		transform = (Transform)obj5;
		Transform transform24 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v27+8]");
		((UnityEngine.Object)transform24).m_CachedPtr = (IntPtr)0;
		Transform transform25 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v29+4]");
		Vector3 vector6 = (Vector3)transform25 / 0f;
		transform = (Transform)obj7;
		Transform transform26 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v31+8]");
		((UnityEngine.Object)transform26).m_CachedPtr = (IntPtr)0;
		Vector3 vector7 = (Vector3)transform / _cameraModifierY;
		((Vector3*)(nint)vector)->x = (float)obj4;
		Vector3 vector8 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v25+8]");
		((Vector3*)(nint)vector8)->z = 0f;
		transform = (Transform)obj8;
		Transform transform27 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v33+8]");
		((UnityEngine.Object)transform27).m_CachedPtr = (IntPtr)0;
		Vector3 vector9 = vector - (Vector3)transform;
		transform = (Transform)obj;
		Transform transform28 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform28).m_CachedPtr = (IntPtr)0;
		object obj45 = this + 32;
		obj45 = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		object obj46 = _currentCameraData + 44;
		transform = (Transform)obj46;
		Transform transform29 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v974 @ S1_v162+8]");
		((UnityEngine.Object)transform29).m_CachedPtr = (IntPtr)0;
		float num29;
		if (transform == (object)0f)
		{
			object obj47 = this + 32;
			num29 = (float)obj47;
		}
		else
		{
			transform = (Transform)obj10;
			Transform transform30 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v38+8]");
			((UnityEngine.Object)transform30).m_CachedPtr = (IntPtr)0;
			object obj48 = _currentCameraData + 44;
			((Vector3*)(nint)vector)->x = (float)obj48;
			Vector3 vector10 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1002 @ S3_v28+8]");
			((Vector3*)(nint)vector10)->z = 0f;
			num29 = (float)transform + vector.x;
		}
		obj12 = num29;
		object obj49 = this + 32;
		object obj50 = _currentCameraData + 44;
		((Vector3*)(nint)vector)->x = (float)obj50;
		Vector3 vector11 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1025 @ S1_v173+8]");
		((Vector3*)(nint)vector11)->z = 0f;
		object obj51 = _currentCameraData + 20;
		transform2 = (Transform)obj51;
		Transform transform31 = transform2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1038 @ S1_v179+8]");
		((UnityEngine.Object)transform31).m_CachedPtr = (IntPtr)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1018 @ S0_v162+4]");
		float num30 = 0f + vector.y;
		float num31 = num30;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13 (UnityEngine.Transform)+4]");
		float num32 = num31 - 0f;
		transform3 = (Transform)obj10;
		Transform transform32 = transform3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v38+8]");
		((UnityEngine.Object)transform32).m_CachedPtr = (IntPtr)0;
		object obj52 = _currentCameraData + 44;
		transform4 = (Transform)obj52;
		Transform transform33 = transform4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1064 @ S1_v192+8]");
		((UnityEngine.Object)transform33).m_CachedPtr = (IntPtr)0;
		object obj53 = (nint)((UnityEngine.Object)transform3).m_CachedPtr + (nint)((UnityEngine.Object)transform4).m_CachedPtr;
		transform = (Transform)obj12;
		Transform transform34 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v44+8]");
		((UnityEngine.Object)transform34).m_CachedPtr = (IntPtr)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @73CB");
		((StackablePrefabData)(object)_cameraPosition)._002Ector();
		object obj54 = _cameraPosition + 32;
		obj2 = obj54;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1093 @ S1_v204+8]");
		_ = 0;
		object obj55 = _cameraPosition + 32;
		obj3 = obj55;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1106 @ S1_v210+8]");
		_ = 0;
		reference = ref *(Quaternion*)obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v35+8]");
		_ = 0;
		object obj56 = _cameraPosition + 32;
		obj4 = obj56;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1128 @ S1_v220+8]");
		_ = 0;
		obj5 = 0;
		_ = 0;
		obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v21+4]");
		nint num33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v23 (UnityEngine.Quaternion&)+4]");
		object obj57 = num33 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v25+8]");
		_ = 0;
		transform = (Transform)obj5;
		Transform transform35 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v27+8]");
		((UnityEngine.Object)transform35).m_CachedPtr = (IntPtr)0;
		object obj58 = this + 20;
		obj58 = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		Character character8 = _character;
		if (~(character8._isInsideSubway ? 1u : 0u) == 0)
		{
			object obj59 = _character - -64;
			object obj60 = this + 20;
			object obj61 = this + 20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1179 @ S1_v355+4]");
			object obj62 = 0;
			nint num34 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1183 @ S1_v358 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj63 = (nint)0 & (nint)0x200;
			if (obj63 != null)
			{
				nint num35 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1208 @ S1_v412 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj59) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj62))
			{
				obj62 = obj59;
			}
			object obj64 = this + 20;
			transform2 = (Transform)obj64;
			Transform transform36 = transform2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1246 @ S1_v366+8]");
			((UnityEngine.Object)transform36).m_CachedPtr = (IntPtr)0;
			object obj65 = _currentCameraData + 44;
			transform3 = (Transform)obj65;
			Transform transform37 = transform3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1256 @ S1_v372+8]");
			((UnityEngine.Object)transform37).m_CachedPtr = (IntPtr)0;
			nint num36 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1263 @ S0_v292 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj66 = (nint)0 & (nint)0x200;
			if (obj66 != null)
			{
				nint num37 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1285 @ S0_v313 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Vector3*)(nint)vector)->x = (float)transform2;
			((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform2).m_CachedPtr;
			transform = transform3;
			((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)transform3).m_CachedPtr;
			Quaternion quaternion = Quaternion.FromToRotation(vector, (Vector3)transform);
			object obj67 = _currentCameraData + 20;
			obj2 = obj67;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1321 @ S1_v388+8]");
			_ = 0;
			((Vector3*)(nint)vector)->x = (float)transform4;
			((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform4).m_CachedPtr;
			transform = (Transform)obj2;
			Transform transform38 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
			((UnityEngine.Object)transform38).m_CachedPtr = (IntPtr)0;
			Vector3 vector12 = vector - (Vector3)transform;
			transform = (Transform)obj3;
			Transform transform39 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v21+8]");
			((UnityEngine.Object)transform39).m_CachedPtr = (IntPtr)0;
			object obj68 = this + 32;
			obj68 = transform;
			_ = ((UnityEngine.Object)transform).m_CachedPtr;
		}
		GameObject gameObject5 = base.gameObject;
		object obj69 = this + 20;
		((Vector3*)(nint)vector)->x = (float)obj69;
		Vector3 vector13 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1222 @ S2_v53+8]");
		((Vector3*)(nint)vector13)->z = 0f;
		transform = (Transform)vector.x;
		((UnityEngine.Object)transform).m_CachedPtr = (IntPtr)vector.z;
		Vector3 localPosition3 = transform.localPosition;
		GameObject gameObject6 = base.gameObject;
		object obj70 = this + 32;
		transform2 = (Transform)obj70;
		Transform transform40 = transform2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1272 @ S2_v63+8]");
		((UnityEngine.Object)transform40).m_CachedPtr = (IntPtr)0;
		transform = transform2;
		((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)transform2).m_CachedPtr;
		((Transform)(object)gameObject6).SetSiblingIndex((int)transform);
		CameraData currentCameraData5 = _currentCameraData;
		float num38 = _tweenTimeTransform / currentCameraData5._transformTweenDuration;
		if (num38 < 1f)
		{
			GameObject gameObject7 = base.gameObject;
			((Transform)vector).rotation = (Quaternion)gameObject7;
			obj15 = vector.x;
			_ = vector.z;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F950");
			obj13 = transform2;
			_ = ((UnityEngine.Object)transform2).m_CachedPtr;
			GameObject gameObject8 = base.gameObject;
			transform3.position = (Vector3)gameObject8;
			obj14 = transform3;
			_ = ((UnityEngine.Object)transform3).m_CachedPtr;
			object obj71 = this + 20;
			CameraData currentCameraData6 = _currentCameraData;
			nint num39 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1463 @ S0_v260 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj72 = (nint)0 & (nint)0x200;
			if (obj72 != null)
			{
				nint num40 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1477 @ S0_v277 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float value = _tweenTimeTransform / currentCameraData6._transformTweenDuration;
			float previousCameraEndYPosition = _previousCameraEndYPosition;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1455 @ S0_v252+4]");
			float num41 = Mathf.InverseLerp(previousCameraEndYPosition, 0f, value);
			GameObject gameObject9 = base.gameObject;
			transform4.rotation = (Quaternion)gameObject9;
			obj15 = transform4;
			_ = ((UnityEngine.Object)transform4).m_CachedPtr;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F950");
			CameraData currentCameraData7 = _currentCameraData;
			float maxDelta = _tweenTimeTransform / currentCameraData7._transformTweenDuration;
			float num42 = Mathf.MoveTowards(_previousCameraEndXRotation, (float)obj2, maxDelta);
			obj13 = num42;
			GameObject gameObject10 = base.gameObject;
			transform = (Transform)obj14;
			Transform transform41 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v50+8]");
			((UnityEngine.Object)transform41).m_CachedPtr = (IntPtr)0;
			Vector3 localPosition4 = transform.localPosition;
			GameObject gameObject11 = base.gameObject;
			obj3 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v47+8]");
			_ = 0;
			nint num43 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1593 @ S1_v335 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
			object obj73 = (nint)0 & (nint)0x200;
			if (obj73 != null)
			{
				nint num44 = (nint)typeof(Quaternion);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1598 @ S1_v348 (Il2CppClass<UnityEngine.Quaternion>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			transform = (Transform)obj3;
			Transform transform42 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v21+8]");
			((UnityEngine.Object)transform42).m_CachedPtr = (IntPtr)0;
			Quaternion.Inverse_Injected(ref reference, out *(Quaternion*)transform);
			transform = (Transform)reference;
			Transform transform43 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v23 (UnityEngine.Quaternion&)+8]");
			((UnityEngine.Object)transform43).m_CachedPtr = (IntPtr)0;
			Quaternion localRotation = transform.localRotation;
			float unscaledTime4 = Time.unscaledTime;
			float tweenTimeTransform = _tweenTimeTransform + unscaledTime4;
			_tweenTimeTransform = tweenTimeTransform;
		}
		GameObject gameObject12 = base.gameObject;
		GameObject gameObject13 = base.gameObject;
		transform2.position = (Vector3)gameObject13;
		object obj74 = this + 80;
		transform3 = (Transform)obj74;
		Transform transform44 = transform3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1408 @ S2_v76+8]");
		((UnityEngine.Object)transform44).m_CachedPtr = (IntPtr)0;
		nint num45 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1415 @ S1_v262 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj75 = (nint)0 & (nint)0x200;
		if (obj75 != null)
		{
			nint num46 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1421 @ S1_v293 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Vector3*)(nint)vector)->x = (float)transform2;
		((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform2).m_CachedPtr;
		transform = transform3;
		((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)transform3).m_CachedPtr;
		Vector3 vector14 = vector - (Vector3)transform;
		transform = transform4;
		((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)transform4).m_CachedPtr;
		Vector3 localPosition5 = transform.localPosition;
		float orthographicSize = _camera.orthographicSize;
		SmoothDampFloat fieldOfViewSmoothDampFloat = _fieldOfViewSmoothDampFloat;
		nint num47 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1506 @ S2_v96 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj76 = (nint)0 & (nint)0x200;
		if (obj76 != null)
		{
			nint num48 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1511 @ S2_v106 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float value2 = orthographicSize - fieldOfViewSmoothDampFloat._target;
		float num49 = Math.Abs(value2);
		if (num49 > 0.5f)
		{
			((SmoothDampVector3)(object)_fieldOfViewSmoothDampFloat).Update();
		}
		object obj77 = this + 20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1551 @ S1_v281+8]");
		float num50 = 0f - _lastZ;
		float unscaledTime5 = Time.unscaledTime;
		float speed3 = num50 / unscaledTime5;
		_speed = speed3;
		object obj78 = _speed & 0x7FFFFFFF;
		if ((nint)obj78 > 2139095040)
		{
			_speed = 0f;
		}
		object obj79 = this + 20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1582 @ S1_v289+8]");
		_lastZ = 0f;
	}

	protected unsafe void OnDrawGizmos()
	{
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Expected Obj, but got Unknown
		//IL_0222: Expected VT, but got Obj
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Expected Obj, but got Unknown
		//IL_0250: Expected I, but got Obj
		//IL_0266: Expected Obj, but got I
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Expected VT, but got Unknown
		//IL_029e: Expected F4, but got Obj
		//IL_0299: Expected native int or pointer, but got VT
		//IL_02b0: Expected F4, but got I
		//IL_02ab: Expected native int or pointer, but got VT
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Expected VT, but got Unknown
		//IL_02cb: Expected F4, but got Obj
		//IL_02c6: Expected native int or pointer, but got VT
		//IL_02e0: Expected F4, but got I
		//IL_02db: Expected native int or pointer, but got VT
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected Obj, but got Unknown
		//IL_00a8: Expected I, but got Obj
		//IL_00be: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_030c: Expected F4, but got Obj
		//IL_0307: Expected native int or pointer, but got VT
		//IL_031e: Expected F4, but got I
		//IL_0319: Expected native int or pointer, but got VT
		//IL_032b: Expected F4, but got Obj
		//IL_0326: Expected native int or pointer, but got VT
		//IL_0340: Expected F4, but got I
		//IL_033b: Expected native int or pointer, but got VT
		//IL_0144: Expected VT, but got Obj
		//IL_0144: Expected Obj, but got VT
		//IL_00e9: Expected I, but got Obj
		//IL_0156: Expected native int or pointer, but got VT
		//IL_0168: Expected native int or pointer, but got VT
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected Obj, but got Unknown
		//IL_0185: Expected Obj, but got F4
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected Obj, but got Unknown
		//IL_01c4: Expected F4, but got Obj
		//IL_01bf: Expected native int or pointer, but got VT
		//IL_01d6: Expected F4, but got I
		//IL_01d1: Expected native int or pointer, but got VT
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Expected Obj, but got Unknown
		//IL_01ee: Expected Obj, but got F4
		object obj = default;
		Transform transform = (Transform)(obj + 12);
		GameObject gameObject = base.gameObject;
		transform.position = (Vector3)gameObject;
		object obj2 = this + 116;
		obj = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S1_v7+8]");
		_ = 0;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v13 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v60 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Quaternion quaternion = (Quaternion)(obj + 24);
		((Quaternion*)(nint)quaternion)->x = (float)transform;
		((Quaternion*)(nint)quaternion)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
		Quaternion quaternion2 = (Quaternion)(obj + 36);
		((Quaternion*)(nint)quaternion2)->x = (float)obj;
		Quaternion quaternion3 = quaternion2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Quaternion*)(nint)quaternion3)->z = 0f;
		if (quaternion != quaternion2)
		{
			object obj4 = this + 32;
			transform = (Transform)obj4;
			Transform transform2 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S1_v51+8]");
			((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
			object obj5 = this + 128;
			obj = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S1_v56+8]");
			_ = 0;
			nint num3 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v46 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num4 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v56 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Quaternion*)(nint)quaternion)->x = (float)transform;
			((Quaternion*)(nint)quaternion)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
			((Quaternion*)(nint)quaternion2)->x = (float)obj;
			Quaternion quaternion4 = quaternion2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((Quaternion*)(nint)quaternion4)->z = 0f;
			if (!(quaternion == quaternion2))
			{
				return;
			}
		}
		GameObject gameObject2 = base.gameObject;
		((Transform)quaternion).position = (Vector3)gameObject2;
		((Quaternion*)(nint)quaternion2)->x = quaternion.x;
		((Quaternion*)(nint)quaternion2)->z = quaternion.z;
		object obj7 = this + 116;
		obj7 = quaternion2.x;
		_ = quaternion2.z;
		object obj8 = this + 32;
		transform = (Transform)obj8;
		Transform transform3 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S1_v37+8]");
		((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
		((Quaternion*)(nint)quaternion2)->x = (float)transform;
		((Quaternion*)(nint)quaternion2)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
		object obj9 = this + 128;
		obj9 = quaternion2.x;
		_ = quaternion2.z;
	}

	public unsafe void Shake()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected Ref, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected Obj, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected Obj, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected VT, but got Unknown
		//IL_00b1: Expected F4, but got Obj
		//IL_00ac: Expected native int or pointer, but got VT
		//IL_00c6: Expected F4, but got I
		//IL_00c1: Expected native int or pointer, but got VT
		//IL_00e8: Expected VT, but got Ref
		object obj2 = default;
		object obj = obj2 + 24;
		Color blue = Color.blue;
		ref Color reference = ref *(Color*)(obj2 + 56);
		reference = ref *(Color*)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+8]");
		_ = 0;
		Gizmos.set_color_Injected(ref reference);
		object obj3 = obj2 + 12;
		object obj4 = this + 20;
		obj3 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v12+8]");
		_ = 0;
		object obj5 = this + 32;
		obj2 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S1_v17+8]");
		_ = 0;
		Vector3 vector = (Vector3)(obj2 + 40);
		((Vector3*)(nint)vector)->x = (float)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v11+8]");
		((Vector3*)(nint)vector)->z = 0f;
		reference = ref *(Color*)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Gizmos.DrawWireCube(vector, (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
	}

	public void ResetShake()
	{
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected Obj, but got Unknown
		//IL_008c: Expected I, but got Obj
		//IL_00a2: Expected Obj, but got I
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected Obj, but got Unknown
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected Obj, but got Unknown
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = default;
		object obj = obj2 + 8;
		obj = this;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v13 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v37 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 one = Vector3.one;
		object obj5 = default;
		object obj4 = obj5 + 12;
		obj4 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj6 = this + 92;
		obj6 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v19+8]");
		_ = 0;
		_ = 100f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		_ = 0;
		object obj8 = default;
		object obj7 = obj8 + 16;
		obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11247");
		IEnumerator routine = default;
		Coroutine coroutine = StartCoroutine_Auto(routine);
	}

	public void Shake(float intensity)
	{
		//IL_0366: Expected Obj, but got I
		//IL_039c: Expected I, but got Obj
		//IL_03b2: Expected Obj, but got I
		//IL_03d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dd: Expected Obj, but got Unknown
		//IL_03e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Expected Obj, but got Unknown
		//IL_040b: Expected Obj, but got I
		//IL_0088: Expected I, but got Obj
		//IL_00fa: Expected Obj, but got I
		//IL_0123: Expected I, but got Obj
		//IL_0139: Expected Obj, but got I
		//IL_02cc: Expected Obj, but got I
		//IL_02d5: Expected Obj, but got I4
		//IL_0164: Expected I, but got Obj
		//IL_02f0: Expected Obj, but got I
		//IL_0334: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Expected Obj, but got Unknown
		((CharacterRendering)this)._003CHandleOnTurboHeadstart_003Eb__130_0(intensity);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Cameras.CharacterCamera)+88]");
		((CharacterCamera)0).SetFOV(20f);
		float num;
		float num2;
		if (intensity < 0.2f)
		{
			num = intensity;
		}
		else
		{
			if (!(intensity > 0.8f))
			{
				num2 = 1f;
				goto IL_038e;
			}
			float num3 = 1f - intensity;
			num = num3;
		}
		num2 = num * 5f;
		goto IL_038e;
		IL_038e:
		nint num4 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S1_v8 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num5 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S1_v80 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num6 = intensity * 2f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @122E7");
		object obj2 = default;
		float num7 = (float)obj2 * 0.2f;
		float num8 = num2 + num7;
		bool flag = num8 < 0f;
		bool flag2 = !flag;
		float num9 = num8;
		if (!flag2)
		{
			float num10 = num8 * -1f;
			num9 = num10;
		}
		object obj3 = default;
		Transform transform = (Transform)(obj3 + 24);
		object obj4 = obj3 + 12;
		float previousCameraEndXRotation = _previousCameraEndXRotation;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v22 (System.Single)+68]");
		object obj5 = (nint)0 + (nint)12;
		object obj6 = default;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v22 (System.Single)+68]");
			object obj7 = (nint)0 + (nint)16;
			object obj8 = obj6 << 2;
			object obj9 = obj7 + obj8;
			nint num11 = (nint)typeof(GameStateMachine);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S1_v41 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num12 = (nint)typeof(GameStateMachine);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S1_v75 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool useBenchmarkRoute = RouteManager.UseBenchmarkRoute;
			throw new ArrayTypeMismatchException();
		}
		if (intensity == 1f)
		{
			float previousCameraEndXRotation2 = _previousCameraEndXRotation;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S0_v33 (System.Single)+68]");
			object obj11 = (nint)0 + (nint)12;
			object obj12 = 0;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S0_v33 (System.Single)+68]");
				object obj13 = (nint)0 + (nint)16;
				object obj14 = obj12 << 2;
				object obj15 = obj13 + obj14;
				Renderer component = ((Component)obj15).GetComponent<Renderer>();
				component.shadowCastingMode = ShadowCastingMode.Off;
				object obj16 = obj12 + 1;
				obj12 = obj16;
			}
		}
	}

	public void FOVGip(float time, float multiplier)
	{
		//IL_0188: Expected Obj, but got I
		//IL_004b: Expected Obj, but got I4
		//IL_006d: Expected I, but got Obj
		//IL_0083: Expected Obj, but got I
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected Obj, but got Unknown
		//IL_0204: Expected Obj, but got I
		//IL_0103: Expected Obj, but got I
		//IL_0131: Expected Obj, but got I
		//IL_00ae: Expected I, but got Obj
		//IL_014c: Expected Obj, but got I
		//IL_0169: Expected Obj, but got I4
		CameraData defaultCameraData = _defaultCameraData;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v11 (SYBO.Subway.Cameras.CameraData)+84]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v12+8]");
		if ((nint)0 != 0)
		{
			((CharacterRendering)this).Game_OnEndStumbleDeathSequence();
		}
		else
		{
			((CharacterRendering)this).Character_OnHangtime_AfterAlternateRoute();
		}
		int layer = ((GameObject)(object)_cameraTarget).layer;
		GameObject parentInternal = ((Component)(object)_defaultCameraData).gameObject;
		((Transform)layer).parentInternal = (Transform)(object)parentInternal;
		int layer2 = ((GameObject)(object)_cameraTarget).layer;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S1_v10 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S1_v27 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 one = Vector3.one;
		object obj3 = default;
		Transform transform = (Transform)(obj3 + 12);
		transform = (Transform)obj3;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Cameras.CharacterCamera)+78]");
		((AnimationState)0).speed = 1f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Cameras.CharacterCamera)+78]");
		((AnimationState)0).time = 1f;
		float num3 = 0.01f * multiplier;
		float height = 0f - num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Cameras.CharacterCamera)+78]");
		((CharacterController)0).height = height;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Cameras.CharacterCamera)+78]");
		((AnimationState)0).wrapMode = WrapMode.Once;
		bool flag = ((InGameIntervalSampler)(object)this).Update(time);
		Coroutine coroutine = StartCoroutine_Auto((IEnumerator)flag);
	}

	public unsafe void SetFOV(float addedFOV)
	{
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected Ref, but got Unknown
		//IL_00bc: Expected I, but got Obj
		//IL_00d2: Expected Obj, but got I
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected VT, but got Unknown
		//IL_010f: Expected F4, but got VT
		//IL_010a: Expected native int or pointer, but got VT
		//IL_0124: Expected F4, but got I
		//IL_011f: Expected native int or pointer, but got VT
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected Obj, but got Unknown
		//IL_0159: Expected F4, but got Obj
		//IL_0154: Expected native int or pointer, but got VT
		//IL_016e: Expected F4, but got I
		//IL_0169: Expected native int or pointer, but got VT
		//IL_005f: Expected F4, but got Obj
		//IL_005a: Expected native int or pointer, but got VT
		//IL_0074: Expected F4, but got I
		//IL_006f: Expected native int or pointer, but got VT
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		//IL_008c: Expected Obj, but got F4
		//IL_0013: Expected I, but got Obj
		object obj = default;
		ref Vector3 reference = ref *(Vector3*)(obj + 24);
		UnityEngine.Random.get_insideUnitSphere_Injected(out reference);
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v31 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector = (Vector3)(obj + 36);
		((Vector3*)(nint)vector)->x = (float)reference;
		Vector3 vector2 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Vector3&)+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		object obj3 = obj + 12;
		Vector3 vector3 = vector / addedFOV;
		float unscaledTime = Time.unscaledTime;
		((Vector3*)(nint)vector)->x = (float)obj3;
		Vector3 vector4 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v19+8]");
		((Vector3*)(nint)vector4)->z = 0f;
		Vector3 vector5 = vector / unscaledTime;
		((Vector3*)(nint)vector)->x = (float)obj;
		Vector3 vector6 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector6)->z = 0f;
		object obj4 = this + 80;
		obj4 = vector.x;
		_ = vector.z;
	}

	private IEnumerator FOVTarget_Coroutine()
	{
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Expected Obj, but got Unknown
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_033b: Expected Obj, but got Unknown
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Expected Obj, but got Unknown
		//IL_0352: Unknown result type (might be due to invalid IL or missing references)
		//IL_0357: Expected Obj, but got Unknown
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Expected Obj, but got Unknown
		//IL_001c: Expected VT, but got Obj
		//IL_0030: Expected F4, but got I
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		//IL_006f: Expected Obj, but got VT
		//IL_007d: Expected I, but got Obj
		//IL_0093: Expected Obj, but got I
		//IL_0397: Expected I, but got Obj
		//IL_03ad: Expected Obj, but got I
		//IL_00be: Expected I, but got Obj
		//IL_03d8: Expected I, but got Obj
		//IL_03ee: Expected Obj, but got I
		//IL_010b: Expected I, but got Obj
		//IL_0462: Unknown result type (might be due to invalid IL or missing references)
		//IL_0467: Expected Obj, but got Unknown
		//IL_047d: Expected I, but got Obj
		//IL_0493: Expected Obj, but got I
		//IL_04b6: Expected I, but got Obj
		//IL_04cc: Expected Obj, but got I
		//IL_0158: Expected I, but got Obj
		//IL_016e: Expected Obj, but got I
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Expected Obj, but got Unknown
		//IL_0246: Expected I, but got Obj
		//IL_025c: Expected Obj, but got I
		//IL_027f: Expected I, but got Obj
		//IL_0295: Expected Obj, but got I
		//IL_01e6: Expected I, but got Obj
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_0307: Expected Obj, but got Unknown
		//IL_0199: Expected I, but got Obj
		object obj = default;
		Transform transform = (Transform)(obj + 60);
		object obj2 = obj + 48;
		object obj3 = obj + 36;
		object obj4 = obj + 24;
		object obj5 = obj + 12;
		if (~(_initialized ? 1u : 0u) != 0)
		{
			GameObject gameObject = base.gameObject;
			transform.position = (Vector3)gameObject;
			_lastZ = (nint)((UnityEngine.Object)transform).m_CachedPtr;
			object obj6 = this + 108;
			Camera component = GetComponent<Camera>();
			obj6 = component;
			object obj7 = this + 16;
			_0021_00210 componentInChildren = (_0021_00210)((Component)this).GetComponentInChildren<T>();
			obj7 = componentInChildren;
			nint num = (nint)typeof(CharacterCamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v31 (Il2CppClass<SYBO.Subway.Cameras.CharacterCamera>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num2 = (nint)typeof(CharacterCamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v107 (Il2CppClass<SYBO.Subway.Cameras.CharacterCamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S1_v21 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S1_v86 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (instance != null)
			{
				nint num5 = (nint)typeof(CharacterCamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S0_v95 (Il2CppClass<SYBO.Subway.Cameras.CharacterCamera>)+BA]");
				object obj10 = (nint)0 & (nint)0x200;
				if (obj10 != null)
				{
					nint num6 = (nint)typeof(CharacterCamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S0_v101 (Il2CppClass<SYBO.Subway.Cameras.CharacterCamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				instance = this;
			}
			nint num7 = (nint)typeof(CameraData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S0_v41 (Il2CppClass<SYBO.Subway.Cameras.CameraData>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			if (obj11 != null)
			{
				nint num8 = (nint)typeof(CameraData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ S0_v88 (Il2CppClass<SYBO.Subway.Cameras.CameraData>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			_ = CameraData.FIELD_OF_VIEW_SMOOTH_TIME_DEFAULT;
			_ = CameraData.FIELD_OF_VIEW_DEFAULT;
			_ = CameraData.FIELD_OF_VIEW_DEFAULT;
			object obj12 = this + 148;
			object obj13 = default;
			obj12 = obj13;
			nint num9 = (nint)typeof(CameraData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ S1_v34 (Il2CppClass<SYBO.Subway.Cameras.CameraData>)+5C]");
			object obj14 = (nint)0 + (nint)20;
			obj3 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ S1_v36+8]");
			_ = 0;
			nint num10 = (nint)typeof(CameraData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ S1_v41 (Il2CppClass<SYBO.Subway.Cameras.CameraData>)+5C]");
			object obj15 = (nint)0 + (nint)44;
			obj4 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ S1_v43+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			obj2 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
			_ = 0;
			transform = (Transform)obj4;
			Transform transform2 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
			((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
			Game game = default;
			game.InputManager_OnInputEvent(obj2, (InputEventArgs)(object)transform);
			object obj16 = this + 112;
			obj16 = game;
			nint num11 = (nint)typeof(CameraData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ S1_v59 (Il2CppClass<SYBO.Subway.Cameras.CameraData>)+5C]");
			object obj17 = (nint)0 + (nint)8;
			obj5 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ S1_v61+8]");
			_ = 0;
			nint num12 = (nint)typeof(CameraData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ S1_v66 (Il2CppClass<SYBO.Subway.Cameras.CameraData>)+5C]");
			object obj18 = (nint)0 + (nint)32;
			obj = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ S1_v68+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			obj2 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
			_ = 0;
			transform = (Transform)obj;
			Transform transform3 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
			Game game2 = default;
			game2.InputManager_OnInputEvent(obj2, (InputEventArgs)(object)transform);
			object obj19 = this + 140;
			obj19 = game2;
			_initialized = true;
		}
		return (IEnumerator)this;
	}

	public void RevertFOV()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected Obj, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v21 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 one = Vector3.one;
		object obj3 = default;
		object obj2 = obj3 + 12;
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj4 = this + 80;
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v15+8]");
		_ = 0;
	}

	public void EnterCameraModifierCollider(float colliderLength)
	{
		//IL_001a: Expected I4, but got Obj
		_customhighSpeedFOV = colliderLength;
		useGUILayout = (byte)(int)"FOVTarget_Coroutine" != 0;
		Coroutine coroutine = StartCoroutine((IEnumerator)(object)"FOVTarget_Coroutine");
	}

	public void ExitCameraModifierCollider()
	{
		//IL_0010: Expected I4, but got Obj
		useGUILayout = (byte)(int)"FOVTarget_Coroutine" != 0;
	}

	public unsafe void CharacterModifierCollection_OnChanged(object sender, CharacterModifierCollectionChangedEventArgs characterModifierCollectionChangedEventArgs)
	{
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected Obj, but got Unknown
		//IL_002d: Expected Obj, but got I
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7510");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		EventHandler eventHandler = default;
		((Delegate)eventHandler).method_ptr = method_ptr;
		((Delegate)eventHandler).method = (nint)__ldftn(CharacterRendering.AlternateRoute_OnCharacterExited);
		object obj = eventHandler + 16;
		obj = this;
		Route route = default;
		route.OnDestructing += eventHandler;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint cachedPtr = 0;
		Route route2 = default;
		((UnityEngine.Object)route2).m_CachedPtr = cachedPtr;
		route2.OnCharacterEntered = (EventHandler<Route.CharacterEnteredEventArgs>)0;
		object obj2 = route2 + 16;
		obj2 = this;
		Vector3 originGamePosition = route2.OriginGamePosition;
	}

	public CameraData GetDefaultCameraDataForMenu()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		CameraData cameraData = default;
		cameraData._cameraDataMode = CameraDataMode.CameraUpdateEnabled_IgnoreMe;
		return cameraData;
	}

	private float GetFOVForAspectRatio(float aspectRatio)
	{
		//IL_0030: Expected I, but got Obj
		//IL_0046: Expected Obj, but got I
		//IL_0071: Expected I, but got Obj
		if (aspectRatio < 0f)
		{
			string args = tag;
			SDebug.LogFormat("JumpHeight cannot be negative!", (object[])(object)args);
		}
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v11 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v18 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num3 = 2f * aspectRatio;
		float result = num3 * (float)(_fovGipping ? 1 : 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Sqrt not resolved\"");
		return result;
	}

	public CameraData GetDefaultCameraData()
	{
		//IL_007a: Expected Obj, but got I
		//IL_0088: Expected I, but got Obj
		//IL_009e: Expected Obj, but got I
		//IL_00e7: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		Transform skyPlane = ((MainCamera)null).SkyPlane;
		((UnityEngine.Object)skyPlane).m_CachedPtr = (IntPtr)3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (UnityEngine.Transform)+10]");
		object obj = 0;
		nint num = (nint)typeof(Utils);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S1_v5 (Il2CppClass<Utils>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Utils);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S1_v12 (Il2CppClass<Utils>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float soundVolume = NGUITools.soundVolume;
		float worldPositionZ = ((GamePositionRoot)null).GetWorldPositionZ(soundVolume);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (UnityEngine.Transform)+10]");
		object obj3 = 0;
		_ = 1f;
		return (CameraData)(object)skyPlane;
	}

	public CharacterCamera()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0014: Expected Obj, but got I4
		object obj = this + 160;
		obj = 0;
	}

	static CharacterCamera()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected Obj, but got Unknown
		//IL_0030: Expected Obj, but got I4
		//IL_003f: Expected Obj, but got F4
		//IL_0059: Expected I, but got Obj
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected Obj, but got Unknown
		//IL_0092: Expected Obj, but got I
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected Obj, but got Unknown
		//IL_00be: Expected Obj, but got I4
		//IL_00cd: Expected Obj, but got F4
		//IL_00e7: Expected I, but got Obj
		//IL_0112: Expected Obj, but got I
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected Obj, but got Unknown
		//IL_013e: Expected Obj, but got I4
		//IL_014d: Expected Obj, but got F4
		//IL_0167: Expected I, but got Obj
		//IL_0192: Expected Obj, but got I
		//IL_01b0: Expected Obj, but got I4
		//IL_01bf: Expected Obj, but got F4
		//IL_01d9: Expected I, but got Obj
		//IL_0204: Expected Obj, but got I
		CameraData.CAMERA_MODE_DEFAULT = CameraDataMode.CameraUpdateEnabled_IgnoreMe;
		CameraData.FIELD_OF_VIEW_DEFAULT = 40f;
		object obj2 = default;
		object obj = obj2 + 36;
		obj = 0;
		_ = 0;
		obj = 0f;
		_ = 20f;
		_ = 0f;
		nint num = (nint)typeof(CameraData);
		object obj3 = obj2 + 48;
		obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v15+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v21 (Il2CppClass<SYBO.Subway.Cameras.CameraData>)+5C]");
		object obj4 = (nint)0 + (nint)8;
		obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v12+8]");
		_ = 0;
		object obj5 = obj2 + 24;
		obj5 = 0;
		_ = 0;
		obj5 = 0f;
		_ = 33f;
		_ = -33f;
		nint num2 = (nint)typeof(CameraData);
		obj3 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v26+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v32 (Il2CppClass<SYBO.Subway.Cameras.CameraData>)+5C]");
		object obj6 = (nint)0 + (nint)20;
		obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v12+8]");
		_ = 0;
		object obj7 = obj2 + 12;
		obj7 = 0;
		_ = 0;
		obj7 = 0.05f;
		_ = 0.1f;
		_ = 0f;
		nint num3 = (nint)typeof(CameraData);
		obj3 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v37+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v43 (Il2CppClass<SYBO.Subway.Cameras.CameraData>)+5C]");
		object obj8 = (nint)0 + (nint)32;
		obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v12+8]");
		_ = 0;
		obj2 = 0;
		_ = 0;
		obj2 = 0f;
		_ = 0f;
		_ = 0f;
		nint num4 = (nint)typeof(CameraData);
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v53 (Il2CppClass<SYBO.Subway.Cameras.CameraData>)+5C]");
		object obj9 = (nint)0 + (nint)44;
		obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v12+8]");
		_ = 0;
		CameraData.TRANSFORM_TWEEN_DURATION = 0.5f;
		CameraData.FIELD_OF_VIEW_SMOOTH_TIME_DEFAULT = 0.2f;
	}
}
