using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Common.Components.Singleton;
using SYBO.Common.Exceptions;
using SYBO.Common.Utilities;
using UnityEngine;

namespace SYBO.Subway.Inputs;

public class InputManager : SingletonMonobehavior<InputManager>
{
	private Game.SwipeInfo _swipeInfo;

	private bool _isEnabled = true;

	private InputEventArgs _previousInputEventArgs;

	private InputEventArgs _currentInputEventArgs;

	private Swipe _currentSwipe;

	private float _lastTapTime = float.MinValue;

	private Camera __gameCamera;

	private Camera __menuCamera;

	private int _lastInputFrame;

	private bool WasButtonClicked__BackingField;

	private EventHandler<InputEventArgs> m_OnInputEvent;

	public bool IsEnabled
	{
		get
		{
			return _isEnabled;
		}
		set
		{
			if (value != _isEnabled)
			{
				_isEnabled = value;
			}
		}
	}

	public InputEventArgs PreviousInputEventArgs => _previousInputEventArgs;

	public InputEventArgs CurrentInputEventArgs => _currentInputEventArgs;

	public bool WasButtonClicked
	{
		get
		{
			return WasButtonClicked__BackingField;
		}
		set
		{
			WasButtonClicked__BackingField = value;
		}
	}

	private Camera _gameCamera
	{
		get
		{
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Expected Obj, but got Unknown
			object result = this + 36;
			if (__gameCamera == null)
			{
				GameObject gameObject = GameObject.Find("Main Camera");
				Camera component = gameObject.GetComponent<Camera>();
				result = component;
			}
			return (Camera)result;
		}
	}

	private Camera _menuCamera
	{
		get
		{
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Expected Obj, but got Unknown
			object result = this + 40;
			if (__menuCamera == null)
			{
				GameObject gameObject = GameObject.Find("1normal 2D Camera");
				Camera component = gameObject.GetComponent<Camera>();
				result = component;
			}
			return (Camera)result;
		}
	}

	public event EventHandler<InputEventArgs> OnInputEvent
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 52;
			Delegate obj2 = this.m_OnInputEvent;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
		remove
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 52;
			Delegate obj2 = this.m_OnInputEvent;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
	}

	protected void Awake()
	{
	}

	protected void Start()
	{
		InputEventArgs e = default;
		e._002Ector(InputType.None, KeyCode.None);
		_currentInputEventArgs = e;
		InputEventArgs e2 = default;
		e2._002Ector(InputType.None, KeyCode.None);
		_previousInputEventArgs = e2;
	}

	private void FixedUpdate()
	{
		HandleControls();
	}

	protected void Update()
	{
		if (~(_isEnabled ? 1u : 0u) == 0)
		{
			Game instance = Game.Instance;
			if (~(instance._isPaused ? 1u : 0u) == 0)
			{
				Game instance2 = Game.Instance;
				Variable<bool> isInGame = instance2.IsInGame;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v21 (Variable`1<System.Boolean>)+8]");
				if ((nint)0 == 0)
				{
					goto IL_0060;
				}
			}
			HandleControls();
			return;
		}
		goto IL_0060;
		IL_0060:
		_currentSwipe = null;
	}

	private void ProcessKeyCode(KeyCode keyCode)
	{
		//IL_012b: Expected Obj, but got I4
		InputEventArgs previousInputEventArgs = _previousInputEventArgs;
		object obj = previousInputEventArgs._inputType - 7;
		if ((nint)obj <= 1 && previousInputEventArgs._keyCode == keyCode && Input.GetKey(keyCode))
		{
			InputEventArgs e = default;
			e._002Ector(InputType.KeyDownStay, keyCode);
			RaiseOnInputEvent(e);
		}
		if (Input.GetKeyDown(keyCode))
		{
			InputEventArgs e2 = default;
			e2._002Ector(InputType.KeyDownEnter, keyCode);
			RaiseOnInputEvent(e2);
		}
		if (Input.GetKeyUp(keyCode))
		{
			InputEventArgs e3 = default;
			e3._002Ector(InputType.KeyDownExit, keyCode);
			RaiseOnInputEvent(e3);
		}
	}

	private void HandleControls()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0353: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Expected Obj, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected Obj, but got Unknown
		//IL_011e: Expected Obj, but got I
		//IL_0144: Expected VT, but got Obj
		//IL_0214: Expected Obj, but got I
		//IL_023a: Expected VT, but got Obj
		//IL_02df: Expected Obj, but got I
		//IL_0305: Expected VT, but got Obj
		object obj = default;
		Swipe swipe = (Swipe)(obj - 144);
		object obj2 = swipe + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @237");
		if (Input.GetKeyDown(KeyCode.Space))
		{
			InputEventArgs e = default;
			e._002Ector(InputType.FingerDoubleTap);
			RaiseOnInputEvent(e);
		}
		int frameCount = Time.frameCount;
		if (frameCount == _lastInputFrame)
		{
			return;
		}
		int frameCount2 = Time.frameCount;
		_lastInputFrame = frameCount2;
		int touchCount = Input.touchCount;
		if (touchCount < 1)
		{
			return;
		}
		Touch[] touches = Input.touches;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A54A");
		object obj3 = swipe + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Inputs.Swipe)+6C]");
		if ((nint)0 == 0)
		{
			Swipe currentSwipe = default;
			_currentSwipe = currentSwipe;
			Swipe currentSwipe2 = _currentSwipe;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Inputs.Swipe)+4C]");
			swipe = (Swipe)0;
			_ = 0;
			object obj4 = (object)swipe >> 32;
			currentSwipe2.start = (Vector3)swipe;
			Swipe currentSwipe3 = _currentSwipe;
			float time = Time.time;
			currentSwipe3.startTime = time;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Inputs.Swipe)+6C]");
		if ((nint)0 != 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Inputs.Swipe)+6C]");
			if ((nint)0 != 3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Inputs.Swipe)+6C]");
				if ((nint)0 != 4)
				{
					goto IL_03ae;
				}
			}
		}
		Swipe currentSwipe4 = _currentSwipe;
		if (_currentSwipe != null)
		{
			float time2 = Time.time;
			currentSwipe4.endTime = time2;
			Swipe currentSwipe5 = _currentSwipe;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Inputs.Swipe)+4C]");
			swipe = (Swipe)0;
			_ = 0;
			object obj5 = (object)swipe >> 32;
			currentSwipe5.end = (Vector3)swipe;
			SwipeDir swipeDir = AnalyzeSwipe(_currentSwipe);
			if (swipeDir != SwipeDir.None)
			{
				ConvertSwipeToInputEventAndRaise(swipe, swipeDir);
				_currentSwipe = null;
			}
		}
		goto IL_03ae;
		IL_03ae:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Inputs.Swipe)+6C]");
		if ((nint)0 != 3)
		{
			return;
		}
		Swipe currentSwipe6 = _currentSwipe;
		if (_currentSwipe != null)
		{
			float time3 = Time.time;
			currentSwipe6.endTime = time3;
			Swipe currentSwipe7 = _currentSwipe;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Inputs.Swipe)+4C]");
			swipe = (Swipe)0;
			_ = 0;
			object obj6 = (object)swipe >> 32;
			currentSwipe7.end = (Vector3)swipe;
			SwipeDir swipeDir2 = AnalyzeSwipe(_currentSwipe);
			if (swipeDir2 == SwipeDir.None)
			{
				bool flag = HandleTap();
			}
		}
	}

	private unsafe SwipeDir AnalyzeSwipe(Swipe nextSwipe)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected VT, but got Unknown
		//IL_00a5: Expected F4, but got I
		//IL_00a0: Expected native int or pointer, but got VT
		//IL_00c4: Expected F4, but got I
		//IL_00bf: Expected native int or pointer, but got VT
		//IL_01fd: Expected Obj, but got I
		//IL_0227: Expected Obj, but got I
		//IL_025e: Expected Obj, but got I
		//IL_028f: Invalid comparison between F4 and Obj
		//IL_00f6: Expected Obj, but got VT
		//IL_0113: Expected Obj, but got I
		//IL_0130: Expected Obj, but got I
		//IL_02ba: Expected I, but got Obj
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Expected Obj, but got Unknown
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Expected Obj, but got Unknown
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Expected Obj, but got Unknown
		//IL_0349: Expected I, but got Obj
		//IL_0362: Unknown result type (might be due to invalid IL or missing references)
		//IL_0367: Expected Obj, but got Unknown
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Expected Obj, but got Unknown
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Expected Obj, but got Unknown
		//IL_03d7: Expected I, but got Obj
		//IL_03f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f5: Expected Obj, but got Unknown
		//IL_0405: Unknown result type (might be due to invalid IL or missing references)
		//IL_040a: Expected Obj, but got Unknown
		//IL_0427: Unknown result type (might be due to invalid IL or missing references)
		//IL_042c: Expected Obj, but got Unknown
		//IL_0465: Expected I, but got Obj
		//IL_04ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b3: Expected Obj, but got Unknown
		//IL_04c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c8: Expected Obj, but got Unknown
		//IL_04e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ea: Expected Obj, but got Unknown
		//IL_04ff: Invalid comparison between F4 and Obj
		object obj = default;
		Vector3 vector = (Vector3)(obj - 80);
		Camera gameCamera = _gameCamera;
		bool flag = gameCamera == null;
		bool flag2 = !flag;
		Camera camera = gameCamera;
		if (!flag2)
		{
			Camera menuCamera = _menuCamera;
			camera = menuCamera;
		}
		bool flag3 = camera != null;
		bool flag4 = !flag3;
		SwipeDir result = SwipeDir.None;
		if (!flag4)
		{
			_ = 1073741824;
			_ = 1073741824;
			_ = nextSwipe.start;
			_ = nextSwipe.start;
			Vector3 position = vector + 16;
			Vector3 vector2 = camera.ScreenToWorldPoint(position);
			_ = 1073741824;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
			((Vector3*)(nint)vector)->z = 0f;
			_ = nextSwipe.end;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
			((Vector3*)(nint)vector)->x = 0f;
			Vector3 vector3 = camera.ScreenToWorldPoint(vector);
			Game.SwipeInfo swipeInfo = _swipeInfo;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
			object obj2 = num - 0;
			object obj3 = obj2 * obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+44]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+44]");
			object obj4 = num2 - 0;
			object obj5 = obj4 * obj4;
			object obj6 = obj3 + obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
			object obj7 = num3 - 0;
			object obj8 = obj7 * obj7;
			object obj9 = obj6 + obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Sqrt not resolved\"");
			float distanceMin = swipeInfo.distanceMin;
			bool flag5 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)distanceMin) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9);
			result = SwipeDir.None;
			if (!flag5)
			{
				object obj10 = nextSwipe.end - nextSwipe.start;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [nextSwipe @ L1 (SYBO.Subway.Inputs.Swipe)+18]");
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [nextSwipe @ L1 (SYBO.Subway.Inputs.Swipe)+C]");
				object obj11 = num4 - 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [nextSwipe @ L1 (SYBO.Subway.Inputs.Swipe)+1C]");
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [nextSwipe @ L1 (SYBO.Subway.Inputs.Swipe)+10]");
				object obj12 = num5 - 0;
				nint num6 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ S0_v76 (Il2CppClass<UnityEngine.Vector3>)+5C]");
				nint num7 = 0;
				object obj13 = obj10 * Vector3.upVector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ S0_v77 (Il2CppStaticFields<UnityEngine.Vector3>)+1C]");
				object obj14 = obj11 * 0;
				object obj15 = obj13 + obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ S0_v77 (Il2CppStaticFields<UnityEngine.Vector3>)+20]");
				object obj16 = obj12 * 0;
				float num8 = (float)obj15 + (float)obj16;
				bool flag6 = num8 > 0f;
				if (!flag6)
				{
					num8 = 0f;
				}
				nint num9 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ S0_v89 (Il2CppClass<UnityEngine.Vector3>)+5C]");
				nint num10 = 0;
				object obj17 = obj10 * Vector3.downVector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ S0_v90 (Il2CppStaticFields<UnityEngine.Vector3>)+28]");
				object obj18 = obj11 * 0;
				object obj19 = obj17 + obj18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ S0_v90 (Il2CppStaticFields<UnityEngine.Vector3>)+2C]");
				object obj20 = obj12 * 0;
				float num11 = (float)obj19 + (float)obj20;
				bool flag7 = num8 < num11;
				if (!flag7)
				{
					num11 = num8;
				}
				nint num12 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ S0_v102 (Il2CppClass<UnityEngine.Vector3>)+5C]");
				nint num13 = 0;
				object obj21 = obj10 * Vector3.leftVector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ S0_v103 (Il2CppStaticFields<UnityEngine.Vector3>)+34]");
				object obj22 = obj11 * 0;
				object obj23 = obj21 + obj22;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ S0_v103 (Il2CppStaticFields<UnityEngine.Vector3>)+38]");
				object obj24 = obj12 * 0;
				float num14 = (float)obj23 + (float)obj24;
				bool flag8 = num11 < num14;
				if (!flag8)
				{
					num14 = num11;
				}
				nint num15 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ S0_v115 (Il2CppClass<UnityEngine.Vector3>)+5C]");
				nint num16 = 0;
				bool flag9 = !flag6;
				SwipeDir swipeDir = (SwipeDir)((flag9 ? 1u : 0u) << 2);
				SwipeDir swipeDir2 = SwipeDir.Down;
				if (!flag7)
				{
					swipeDir2 = swipeDir;
				}
				SwipeDir swipeDir3 = SwipeDir.Left;
				if (!flag8)
				{
					swipeDir3 = swipeDir2;
				}
				object obj25 = obj10 * Vector3.rightVector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ S0_v116 (Il2CppStaticFields<UnityEngine.Vector3>)+40]");
				object obj26 = obj11 * 0;
				object obj27 = obj25 + obj26;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ S0_v116 (Il2CppStaticFields<UnityEngine.Vector3>)+44]");
				object obj28 = obj12 * 0;
				object obj29 = obj27 + obj28;
				bool flag10 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num14) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj29);
				SwipeDir swipeDir4 = SwipeDir.Right;
				if (!flag10)
				{
					swipeDir4 = swipeDir3;
				}
				result = swipeDir4;
			}
		}
		return result;
	}

	private bool HandleTap()
	{
		float time = Time.time;
		Game.SwipeInfo swipeInfo = _swipeInfo;
		float num = _lastTapTime + swipeInfo.doubleTapDuration;
		bool flag = num > time;
		bool result;
		InputEventArgs inputEventArgs;
		if (flag)
		{
			result = false;
			if (!WasButtonClicked__BackingField)
			{
				InputEventArgs e = default;
				e._002Ector(InputType.FingerDoubleTap);
				inputEventArgs = e;
				goto IL_0072;
			}
		}
		else
		{
			result = false;
			if (!WasButtonClicked__BackingField)
			{
				InputEventArgs e2 = default;
				e2._002Ector(InputType.FingerTap);
				inputEventArgs = e2;
				goto IL_0072;
			}
		}
		goto IL_00d9;
		IL_0072:
		RaiseOnInputEvent(inputEventArgs);
		result = flag;
		goto IL_00d9;
		IL_00d9:
		WasButtonClicked__BackingField = false;
		float time2 = Time.time;
		_lastTapTime = time2;
		return result;
	}

	private void ConvertSwipeToInputEventAndRaise(Swipe swipe, SwipeDir swipeDir)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		Enum obj = (Enum)(obj2 - 16);
		InputType inputType;
		if (swipeDir >= SwipeDir.None)
		{
			_ = -1;
			obj = (Enum)(object)typeof(SwipeDir);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+C]");
			_ = 0;
			string missingSwitchValue = obj.ToString();
			SwitchDefaultException.Throw(missingSwitchValue);
			inputType = InputType.None;
		}
		else
		{
			inputType = (InputType)(swipeDir + 1);
		}
		InputEventArgs e = default;
		e._002Ector(inputType);
		RaiseOnInputEvent(e);
	}

	protected override void Initialize()
	{
		Transform childTransform = transform;
		HierarchyUtility.ReparentByHierarchyPathType(childTransform, HierarchyPathType.DynamicManagers);
	}

	public void SendInputEvent(InputEventArgs inputEventArgs)
	{
		RaiseOnInputEvent(inputEventArgs);
	}

	private void RaiseOnInputEvent(InputEventArgs inputEventArgs)
	{
		_currentInputEventArgs = inputEventArgs;
		EventHandler<InputEventArgs> onInputEvent = this.m_OnInputEvent;
		if (this.m_OnInputEvent != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v5 @ S0_v3 (System.EventHandler`1<SYBO.Subway.Inputs.InputEventArgs>)+C] (should have been resolved before IL gen)");
		}
		_previousInputEventArgs = _currentInputEventArgs;
	}
}
