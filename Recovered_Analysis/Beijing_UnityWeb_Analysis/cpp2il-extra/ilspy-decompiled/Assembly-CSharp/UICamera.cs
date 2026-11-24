using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Internal;

public class UICamera : MonoBehaviour
{
	public enum ControlScheme
	{
		Mouse,
		Touch,
		Controller
	}

	public enum ClickNotification
	{
		None,
		Always,
		BasedOnDelta
	}

	public class MouseOrTouch
	{
		public KeyCode key;

		public Vector2 pos;

		public Vector2 lastPos;

		public Vector2 delta;

		public Vector2 totalDelta;

		public Camera pressedCam;

		public GameObject last;

		public GameObject current;

		public GameObject pressed;

		public GameObject dragged;

		public float pressTime;

		public float clickTime;

		public ClickNotification clickNotification;

		public bool touchBegan;

		public bool pressStarted;

		public bool dragStarted;

		public int ignoreDelta;

		public float deltaTime
		{
			get
			{
				//IL_0007: Expected F4, but got VT
				return (float)pos;
			}
		}

		public bool isOverUI
		{
			get
			{
				//IL_000b: Invalid comparison between Obj and F4
				//IL_0035: Invalid comparison between Obj and F4
				//IL_005f: Invalid comparison between Obj and F4
				//IL_0089: Invalid comparison between Obj and F4
				if (last == (object)0f)
				{
					if (current == (object)0f)
					{
						if (pressed == (object)0f)
						{
							return dragged != (object)0f;
						}
						return true;
					}
					return true;
				}
				return true;
			}
		}
	}

	public enum EventType
	{
		World_3D,
		UI_3D,
		World_2D,
		UI_2D
	}

	public delegate bool GetKeyStateFunc(KeyCode key);

	public delegate float GetAxisFunc(string name);

	public delegate bool GetAnyKeyFunc();

	public delegate MouseOrTouch GetMouseDelegate(int button);

	public delegate MouseOrTouch GetTouchDelegate(int id, bool createIfMissing);

	public delegate void RemoveTouchDelegate(int id);

	public delegate void OnScreenResize();

	public enum ProcessEventsIn
	{
		Update,
		LateUpdate
	}

	public delegate void OnCustomInput();

	public delegate void OnSchemeChange();

	public delegate void MoveDelegate(Vector2 delta);

	public delegate void VoidDelegate(GameObject go);

	public delegate void BoolDelegate(GameObject go, bool state);

	public delegate void FloatDelegate(GameObject go, float delta);

	public delegate void VectorDelegate(GameObject go, Vector2 delta);

	public delegate void ObjectDelegate(GameObject go, GameObject obj);

	public delegate void KeyCodeDelegate(GameObject go, KeyCode key);

	private struct DepthEntry
	{
		public int depth;

		public RaycastHit hit;

		public Vector3 point;

		public GameObject go;
	}

	public class Touch
	{
		public int fingerId;

		public TouchPhase phase;

		public Vector2 position;

		public int tapCount;

		public Touch()
		{
			//IL_0015: Expected Obj, but got I
			//IL_007e: Expected Obj, but got I4
			//IL_0050: Expected Obj, but got I
			//IL_0060: Expected Obj, but got I
			//IL_00b6: Expected Obj, but got I
			//IL_00c6: Expected Obj, but got I
			//IL_011b: Expected Obj, but got I
			//IL_0138: Expected Obj, but got I4
			//IL_037a: Expected Obj, but got I
			//IL_0383: Unknown result type (might be due to invalid IL or missing references)
			//IL_0388: Expected Obj, but got Unknown
			//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_03cf: Expected Obj, but got Unknown
			//IL_01c4: Expected Obj, but got I
			//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d2: Expected Obj, but got Unknown
			//IL_0190: Expected Obj, but got I
			//IL_0199: Unknown result type (might be due to invalid IL or missing references)
			//IL_019e: Expected Obj, but got Unknown
			//IL_0257: Expected Obj, but got I
			//IL_02b1: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UICamera+Touch)+34]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UICamera+Touch)+34]");
			object obj3;
			object obj4;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UICamera+Touch)+34]");
				object obj2 = (nint)0 + (nint)16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6+C]");
				obj3 = 0;
				obj4 = obj2;
			}
			else
			{
				obj4 = this;
				obj3 = 1;
			}
			object obj5 = default;
			object obj23 = default;
			object obj20 = default;
			for (; obj5 != obj3; obj5 = obj23 + 1)
			{
				object obj6 = obj5 << 2;
				object obj7 = obj4 + obj6;
				object obj8 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v14+10]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v14+14]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v19+28]");
				if ((nint)0 == -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A98");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v19+24]");
				object obj11 = (nint)0 & (nint)0x10;
				bool flag = obj11 == null;
				object obj12 = (flag ? 1 : 0) ^ 1;
				if (obj12 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v19+2A]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v14+8]");
						object obj13 = (nint)0 & (nint)0x3FFF;
						object obj14 = obj13 + 80504;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v104 @ S2_v14 (should have been resolved before IL gen)");
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v14+8]");
						object obj15 = (nint)0 & (nint)0x7FFF;
						object obj16 = obj15 + 46824;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v111 @ S1_v33 (should have been resolved before IL gen)");
					}
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v19+28]");
				if ((nint)0 != -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v14+10]");
					bool flag2;
					if ((nint)0 != 0)
					{
						object obj17 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S0_v59+9C]");
						object obj18 = (nint)0 & (nint)0x100;
						flag2 = obj18 != null;
					}
					else
					{
						flag2 = false;
					}
					if (!flag2 && phase != TouchPhase.Began)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v19+2B]");
						object obj19 = (nint)0 & (nint)3;
						bool flag3 = (nint)obj19 == 2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120B8");
						if (flag3)
						{
							if (obj20 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B8");
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B9");
							}
						}
						else if (obj20 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
						}
						continue;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v14+8]");
				object obj21 = (nint)0 & (nint)0x3FFF;
				object obj22 = obj21 + 80504;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v129 @ S2_v6 (should have been resolved before IL gen)");
			}
		}
	}

	public delegate int GetTouchCountCallback();

	public delegate Touch GetTouchCallback(int index);

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static BetterList<DepthEntry>.CompareFunc _003C_003E9__190_0;

		public static BetterList<DepthEntry>.CompareFunc _003C_003E9__190_1;

		static _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			UIAtlas._003C_003Ec obj = default;
			UIAtlas._003C_003Ec._003C_003E9 = obj;
		}

		internal int _003CRaycast_003Eb__190_0(DepthEntry r1, DepthEntry r2)
		{
			//IL_0009: Expected Obj, but got I4
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120A3");
			int result = default;
			return result;
		}

		internal int _003CRaycast_003Eb__190_1(DepthEntry r1, DepthEntry r2)
		{
			//IL_000d: Expected Obj, but got I4
			object obj = r1.depth;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [r1 @ L1 (UICamera+DepthEntry)+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [r1 @ L1 (UICamera+DepthEntry)+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [r1 @ L1 (UICamera+DepthEntry)+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [r1 @ L1 (UICamera+DepthEntry)+20]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [r1 @ L1 (UICamera+DepthEntry)+28]");
			_ = 0;
			_ = r1.point;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [r1 @ L1 (UICamera+DepthEntry)+38]");
			_ = 0;
			if (r2.depth < (nint)obj)
			{
				return -1;
			}
			return (r2.depth > (nint)obj) ? 1 : 0;
		}

		internal bool _003C_002Ecctor_003Eb__227_0(KeyCode key)
		{
			//IL_000e: Expected I4, but got Obj
			InvalidOperationException ex = new InvalidOperationException();
			return (byte)(int)ex != 0;
		}

		internal bool _003C_002Ecctor_003Eb__227_1(KeyCode key)
		{
			//IL_00aa: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			//IL_0029: Expected Obj, but got I
			//IL_0054: Expected I, but got Obj
			if (key > KeyCode.Mouse6)
			{
				nint num = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v12 (Il2CppClass<UICamera>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num2 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v21 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (~(ignoreControllerInput ? 1u : 0u) == 0)
				{
					return false;
				}
			}
			return Input.GetKeyDown((string)key);
		}

		internal bool _003C_002Ecctor_003Eb__227_2(KeyCode key)
		{
			//IL_0013: Expected I, but got Obj
			//IL_0029: Expected Obj, but got I
			//IL_0054: Expected I, but got Obj
			if (key > KeyCode.Mouse6)
			{
				nint num = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v12 (Il2CppClass<UICamera>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num2 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v21 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (~(ignoreControllerInput ? 1u : 0u) == 0)
				{
					return false;
				}
			}
			return Input.GetKeyDown(key);
		}

		internal float _003C_002Ecctor_003Eb__227_3(string axis)
		{
			InvalidOperationException ex = new InvalidOperationException();
			throw new NullReferenceException();
		}

		internal MouseOrTouch _003C_002Ecctor_003Eb__227_4(int button)
		{
			//IL_00b2: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			//IL_0029: Expected Obj, but got I
			//IL_0054: Expected I, but got Obj
			if (button > 329)
			{
				nint num = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v12 (Il2CppClass<UICamera>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num2 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v21 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (~(ignoreControllerInput ? 1u : 0u) == 0)
				{
					return null;
				}
			}
			bool keyUp = Input.GetKeyUp((KeyCode)button);
			return (MouseOrTouch)keyUp;
		}

		internal unsafe MouseOrTouch _003C_002Ecctor_003Eb__227_5(int id, bool createIfMissing)
		{
			//IL_000d: Expected Obj, but got I4
			//IL_00bd: Expected Obj, but got I4
			//IL_009d: Expected Obj, but got I4
			object obj = ((int*)id)->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [id @ L1 (System.Int32)+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [id @ L1 (System.Int32)+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [id @ L1 (System.Int32)+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [id @ L1 (System.Int32)+20]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [id @ L1 (System.Int32)+28]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [id @ L1 (System.Int32)+30]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [id @ L1 (System.Int32)+38]");
			_ = 0;
			if ((((bool*)(createIfMissing ? 1 : 0))->m_value ? 1 : 0) < (nint)obj)
			{
				return (MouseOrTouch)(-1);
			}
			bool flag = (((bool*)(createIfMissing ? 1 : 0))->m_value ? 1 : 0) > (nint)obj;
			return (MouseOrTouch)flag;
		}

		internal void _003C_002Ecctor_003Eb__227_6(int id)
		{
			throw new InvalidOperationException();
		}
	}

	public static BetterList<UICamera> list;

	public static GetKeyStateFunc GetKeyDown;

	public static GetKeyStateFunc GetKeyUp;

	public static GetKeyStateFunc GetKey;

	public static GetAxisFunc GetAxis;

	public static GetAnyKeyFunc GetAnyKeyDown;

	public static GetMouseDelegate GetMouse;

	public static GetTouchDelegate GetTouch;

	public static RemoveTouchDelegate RemoveTouch;

	public static OnScreenResize onScreenResize;

	public EventType eventType;

	public bool eventsGoToColliders;

	public LayerMask eventReceiverMask;

	public ProcessEventsIn processEventsIn;

	public bool debug;

	public bool useMouse;

	public bool useTouch;

	public bool allowMultiTouch;

	public bool useKeyboard;

	public bool useController;

	public bool stickyTooltip;

	public float tooltipDelay;

	public bool longPressTooltip;

	public float mouseDragThreshold;

	public float mouseClickThreshold;

	public float touchDragThreshold;

	public float touchClickThreshold;

	public float rangeDistance;

	public string horizontalAxisName;

	public string verticalAxisName;

	public string horizontalPanAxisName;

	public string verticalPanAxisName;

	public string scrollAxisName;

	public bool commandClick;

	public KeyCode submitKey0;

	public KeyCode submitKey1;

	public KeyCode cancelKey0;

	public KeyCode cancelKey1;

	public bool autoHideCursor;

	public static OnCustomInput onCustomInput;

	public static bool showTooltips;

	public static bool ignoreAllEvents;

	public static bool ignoreControllerInput;

	private static bool mDisableController;

	private static Vector2 mLastPos;

	public static Vector3 lastWorldPosition;

	public static Ray lastWorldRay;

	public static RaycastHit lastHit;

	public static UICamera current;

	public static Camera currentCamera;

	public static OnSchemeChange onSchemeChange;

	private static ControlScheme mLastScheme;

	public static int currentTouchID;

	private static KeyCode mCurrentKey;

	public static MouseOrTouch currentTouch;

	private static bool mInputFocus;

	private static GameObject mGenericHandler;

	public static GameObject fallThrough;

	public static VoidDelegate onClick;

	public static VoidDelegate onDoubleClick;

	public static BoolDelegate onHover;

	public static BoolDelegate onPress;

	public static BoolDelegate onSelect;

	public static FloatDelegate onScroll;

	public static VectorDelegate onDrag;

	public static VoidDelegate onDragStart;

	public static ObjectDelegate onDragOver;

	public static ObjectDelegate onDragOut;

	public static VoidDelegate onDragEnd;

	public static ObjectDelegate onDrop;

	public static KeyCodeDelegate onKey;

	public static KeyCodeDelegate onNavigate;

	public static VectorDelegate onPan;

	public static BoolDelegate onTooltip;

	public static MoveDelegate onMouseMove;

	private static MouseOrTouch[] mMouse;

	public static MouseOrTouch controller;

	public static List<MouseOrTouch> activeTouches;

	private static List<int> mTouchIDs;

	private static int mWidth;

	private static int mHeight;

	private static GameObject mTooltip;

	private Camera mCam;

	private static float mTooltipTime;

	private float mNextRaycast;

	public static bool isDragging;

	private static int mLastInteractionCheck;

	private static bool mLastInteractionResult;

	private static int mLastFocusCheck;

	private static bool mLastFocusResult;

	private static int mLastOverCheck;

	private static bool mLastOverResult;

	private static GameObject mRayHitObject;

	private static GameObject mHover;

	private static GameObject mSelected;

	private static DepthEntry mHit;

	private static BetterList<DepthEntry> mHits;

	private static RaycastHit[] mRayHits;

	private static Collider2D[] mOverlap;

	private static Plane m2DPlane;

	private static float mNextEvent;

	private static int mNotifying;

	private static bool mUsingTouchEvents;

	public static GetTouchCountCallback GetInputTouchCount;

	public static GetTouchCallback GetInputTouch;

	public unsafe bool stickyPress
	{
		get
		{
			//IL_06f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_06f5: Expected Obj, but got Unknown
			//IL_06fe: Expected Obj, but got I4
			//IL_070d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0712: Expected Obj, but got Unknown
			//IL_071b: Expected Obj, but got I4
			//IL_072f: Expected I, but got Obj
			//IL_0745: Expected Obj, but got I
			//IL_0890: Unknown result type (might be due to invalid IL or missing references)
			//IL_0895: Expected VT, but got Unknown
			//IL_08a0: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			//IL_005d: Expected Obj, but got I4
			//IL_00eb: Expected I, but got Obj
			//IL_0101: Expected Obj, but got I
			//IL_0772: Expected Obj, but got I4
			//IL_012c: Expected I, but got Obj
			//IL_0176: Expected Obj, but got I4
			//IL_0188: Expected I, but got Obj
			//IL_019e: Expected Obj, but got I
			//IL_0799: Expected Obj, but got I4
			//IL_0220: Expected VT, but got I4
			//IL_01c9: Expected I, but got Obj
			//IL_07c8: Expected I, but got Obj
			//IL_07de: Expected Obj, but got I
			//IL_08c7: Expected Obj, but got I4
			//IL_028a: Expected VT, but got I4
			//IL_0233: Expected I, but got Obj
			//IL_029e: Expected Obj, but got I4
			//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b0: Expected Obj, but got Unknown
			//IL_02bd: Expected F4, but got Obj
			//IL_02b8: Expected native int or pointer, but got VT
			//IL_02d7: Expected Obj, but got F4
			//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f2: Expected Obj, but got Unknown
			//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_03db: Expected Obj, but got Unknown
			//IL_03f6: Expected I, but got Obj
			//IL_040c: Expected Obj, but got I
			//IL_0353: Expected F4, but got Obj
			//IL_034e: Expected native int or pointer, but got VT
			//IL_0376: Expected VT, but got I4
			//IL_0387: Expected F4, but got Obj
			//IL_0382: Expected native int or pointer, but got VT
			//IL_03aa: Expected VT, but got I4
			//IL_0804: Expected F4, but got Obj
			//IL_0826: Expected F4, but got I
			//IL_0848: Expected F4, but got I
			//IL_0483: Expected I4, but got Obj
			//IL_0494: Expected F4, but got I
			//IL_04a5: Expected I4, but got Obj
			//IL_0437: Expected I, but got Obj
			//IL_04e0: Expected VT, but got Obj
			//IL_05ad: Expected VT, but got Obj
			//IL_05bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_05c2: Expected Obj, but got Unknown
			//IL_05d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_05d7: Expected Obj, but got Unknown
			//IL_0615: Expected Obj, but got I
			//IL_0632: Expected Obj, but got I
			//IL_0691: Expected VT, but got Obj
			object obj2 = default;
			object obj = obj2 + 32;
			obj = 0;
			_ = 0;
			object obj3 = obj2 + 16;
			obj3 = 0;
			_ = 0;
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S1_v130 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector2 vector = (Vector2)(obj2 + 48);
			if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)processEventsIn))
			{
				return ((UICamera)processEventsIn).stickyPress;
			}
			bool flag = eventsGoToColliders;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v21 (System.Boolean)+C]");
			if ((nint)0 != 0)
			{
				return false;
			}
			bool flag2 = useKeyboard;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v26 (System.Boolean)+C]");
			if ((nint)0 > (nint)0)
			{
				nint num3 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S1_v21 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num4 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S1_v125 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)eventType))
				{
					int renderQueue = ((Material)eventType).renderQueue;
					nint num5 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S0_v39 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj6 = (nint)0 & (nint)0x200;
					if (obj6 != null)
					{
						nint num6 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S0_v123 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Vector2 maxRect = default;
					if (((ComputeShader)renderQueue).FindKernel(null) != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
					}
					else
					{
						maxRect = (Vector2)512;
					}
					nint num7 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ S0_v47 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj7 = (nint)0 & (nint)0x200;
					if (obj7 != null)
					{
						nint num8 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ S0_v116 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Vector2 minArea = default;
					if (((ComputeShader)renderQueue).FindKernel(null) != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
					}
					else
					{
						minArea = (Vector2)512;
					}
					int num10 = default;
					UIStretch uIStretch = default;
					int num20 = default;
					while (true)
					{
						bool flag3 = useKeyboard;
						int num9 = num10;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ S1_v36 (System.Boolean)+C]");
						if ((nint)num9 >= (nint)0)
						{
							break;
						}
						UIAtlas.Sprite sprite = ((List<UIAtlas.Sprite>)useKeyboard).get_Item(num10);
						object obj8 = sprite + 12;
						((Vector2*)(nint)vector)->x = (float)obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ S1_v42+8]");
						_ = 0;
						obj = vector.x;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S1_v15 (UnityEngine.Vector2)+8]");
						_ = 0;
						object obj9 = sprite + 28;
						obj2 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ S1_v51+8]");
						_ = 0;
						obj3 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
						_ = 0;
						if (debug)
						{
							((Vector2*)(nint)vector)->x = (float)obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
							_ = 0;
							Vector2 vector2 = NGUIMath.ConstrainRect(vector, maxRect, minArea, (Vector2)1);
							((Vector2*)(nint)vector)->x = (float)obj3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
							_ = 0;
							Vector2 vector3 = NGUIMath.ConstrainRect(vector, maxRect, minArea, (Vector2)1);
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						uIStretch.Awake();
						object obj10 = uIStretch + 8;
						obj10 = sprite.name;
						nint num11 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ S0_v83 (Il2CppClass<UnityEngine.Mathf>)+BA]");
						object obj11 = (nint)0 & (nint)0x200;
						if (obj11 != null)
						{
							nint num12 = (nint)typeof(Mathf);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ S0_v103 (Il2CppClass<UnityEngine.Mathf>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						GUILayoutOption uiCamera = GUILayout.Width((float)obj);
						uIStretch.uiCamera = (Camera)(object)uiCamera;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
						GUILayoutOption container = GUILayout.Width(0f);
						uIStretch.container = (GameObject)(object)container;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
						GUILayoutOption gUILayoutOption = GUILayout.Width(0f);
						uIStretch.style = (UIStretch.Style)gUILayoutOption;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+C]");
						GUILayoutOption gUILayoutOption2 = GUILayout.Width(0f);
						uIStretch.runOnlyOnce = (byte)(int)gUILayoutOption2 != 0;
						float num13 = sprite.paddingLeft;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
						float width = num13 * 0f;
						GUILayoutOption gUILayoutOption3 = GUILayout.Width(width);
						uIStretch.borderPadding = (Vector2)gUILayoutOption3;
						float num14 = sprite.paddingRight;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
						float width2 = num14 * 0f;
						GUILayoutOption gUILayoutOption4 = GUILayout.Width(width2);
						float num15 = sprite.paddingBottom;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+C]");
						float width3 = num15 * 0f;
						GUILayoutOption mTrans = GUILayout.Width(width3);
						uIStretch.mTrans = (Transform)(object)mTrans;
						float num16 = sprite.paddingTop;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+C]");
						float width4 = num16 * 0f;
						GUILayoutOption widgetContainer = GUILayout.Width(width4);
						uIStretch.widgetContainer = (UIWidget)(object)widgetContainer;
						float width5 = (float)obj3 - (float)obj;
						GUILayoutOption gUILayoutOption5 = GUILayout.Width(width5);
						uIStretch.relativeSize = (Vector2)gUILayoutOption5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
						object obj12 = 0 + obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
						object obj13 = 0 + obj3;
						float width6 = (float)obj12 - (float)obj13;
						GUILayoutOption gUILayoutOption6 = GUILayout.Width(width6);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+C]");
						nint num17 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
						object obj14 = num17 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+C]");
						nint num18 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+4]");
						object obj15 = num18 + 0;
						float width7 = (float)obj14 - (float)obj15;
						GUILayoutOption gUILayoutOption7 = GUILayout.Width(width7);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+4]");
						float num19 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
						float width8 = num19 - 0f;
						GUILayoutOption gUILayoutOption8 = GUILayout.Width(width8);
						uIStretch.initialSize = (Vector2)gUILayoutOption8;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F73");
						num10 = num20 + 1;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB86");
					return true;
				}
				return false;
			}
			return false;
		}
	}

	public static bool disableController
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0099: Expected I4, but got Obj
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(UIDrawCall);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIDrawCall>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UIDrawCall);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<UIDrawCall>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (byte)(int)UIDrawCall.mInactiveList != 0;
		}
		set
		{
			//IL_00d1: Expected Obj, but got I4
			//IL_001d: Expected Obj, but got I4
			//IL_0050: Expected Obj, but got I
			//IL_0060: Expected Obj, but got I
			//IL_0071: Unknown result type (might be due to invalid IL or missing references)
			//IL_0076: Expected Obj, but got Unknown
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0084: Expected Obj, but got Unknown
			//IL_009c: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
			object obj = (value ? 1 : 0) + 16;
			object obj2 = default;
			obj = obj2;
			_ = 1f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
			object obj3 = (value ? 1 : 0) + 32;
			object obj4 = default;
			obj3 = obj4;
			_ = -1;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S3_v2 (Il2CppMethodInfo)+C]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S3_v3+60]");
			object obj6 = 0;
			object obj7 = obj6;
			object obj8 = obj7 & 0x1FFF;
			object obj9 = obj8 + 113696;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v53 @ S4_v4 (should have been resolved before IL gen)");
			object obj10 = (value ? 1 : 0) + 40;
			object obj11 = default;
			obj10 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
		}
	}

	public unsafe static Vector2 lastTouchPosition
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_009c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a1: Expected I4, but got Unknown
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UICamera>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector2 vector = default;
			bool flag = (byte)(vector & 1) != 0;
			mDisableController = flag;
			return vector;
		}
		set
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00a1: Expected F4, but got VT
			//IL_009c: Expected native int or pointer, but got VT
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UICamera>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Vector2*)(nint)value)->x = (float)mLastPos;
		}
	}

	public unsafe static Vector2 lastEventPosition
	{
		get
		{
			//IL_007c: Expected I, but got Obj
			//IL_0092: Expected Obj, but got I
			//IL_00af: Expected VT, but got Obj
			//IL_00cd: Expected Obj, but got I
			//IL_00de: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e3: Expected Obj, but got Unknown
			//IL_0013: Expected I, but got Obj
			//IL_0043: Expected VT, but got Obj
			//IL_0069: Expected VT, but got Obj
			nint num = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v11 (Il2CppClass<UICamera>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			bool flag = obj == null;
			Vector2 result = (Vector2)typeof(UICamera);
			if (!flag)
			{
				nint num2 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v18 (Il2CppClass<UICamera>)+74]");
				bool flag2 = (nint)0 == 0;
				bool flag3 = !flag2;
				result = (Vector2)typeof(UICamera);
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					result = (Vector2)typeof(UICamera);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v2 (UnityEngine.Vector2)+5C]");
			object obj2 = 0;
			object obj4 = default;
			object obj3 = obj4;
			object obj5 = obj3 + 8;
			obj5 = obj3;
			return result;
		}
		set
		{
			//IL_032e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0333: Expected Obj, but got Unknown
			//IL_033c: Expected Obj, but got I4
			//IL_0356: Expected I, but got Obj
			//IL_036c: Expected Obj, but got I
			//IL_049e: Unknown result type (might be due to invalid IL or missing references)
			//IL_04a3: Expected VT, but got Unknown
			//IL_04ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_04b1: Expected Obj, but got Unknown
			//IL_04ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_04bf: Expected Obj, but got Unknown
			//IL_02a5: Expected I, but got Obj
			//IL_02bb: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0490: Expected F4, but got VT
			//IL_048b: Expected native int or pointer, but got VT
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_02e6: Expected I, but got Obj
			//IL_03a0: Expected I, but got Obj
			//IL_03b6: Expected Obj, but got I
			//IL_00a1: Expected I, but got Obj
			//IL_00ee: Expected I, but got Obj
			//IL_0143: Expected Obj, but got I4
			//IL_0189: Expected I, but got Obj
			//IL_019f: Expected Obj, but got I
			//IL_0407: Expected Obj, but got I4
			//IL_0422: Expected F4, but got Obj
			//IL_041d: Expected native int or pointer, but got VT
			//IL_0437: Expected F4, but got I
			//IL_0432: Expected native int or pointer, but got VT
			//IL_0217: Expected I, but got Obj
			//IL_022d: Expected Obj, but got I
			//IL_01ca: Expected I, but got Obj
			//IL_045a: Expected F4, but got Obj
			//IL_0455: Expected native int or pointer, but got VT
			//IL_046f: Expected F4, but got I
			//IL_046a: Expected native int or pointer, but got VT
			//IL_0258: Expected I, but got Obj
			object obj2 = default;
			object obj = obj2 + 48;
			obj = 0;
			_ = 0;
			_ = 0;
			nint num = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13 (Il2CppClass<UICamera>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num2 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v87 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector3 vector = (Vector3)(obj2 + 72);
			object obj4 = obj2 + 24;
			object obj5 = obj2 + 12;
			KeyCode keyCode = currentKey;
			if (keyCode == (KeyCode)2)
			{
				nint num3 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v42 (Il2CppClass<UICamera>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num4 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v83 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				GameObject gameObject = controllerNavigationObject;
				nint num5 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v49 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num6 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S0_v79 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)(object)gameObject).FindKernel((string)null) != 0)
				{
					int layer = gameObject.layer;
					Bounds bounds = NGUIMath.CalculateRelativeWidgetBounds((Transform)layer);
					obj = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v20+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v20+10]");
					_ = 0;
					bool activeSelf = gameObject.activeSelf;
					nint num7 = (nint)typeof(NGUITools);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S1_v31 (Il2CppClass<NGUITools>)+BA]");
					object obj8 = (nint)0 & (nint)0x200;
					if (obj8 != null)
					{
						nint num8 = (nint)typeof(NGUITools);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S1_v48 (Il2CppClass<NGUITools>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					string typeName = NGUITools.GetTypeName((UnityEngine.Object)activeSelf);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F499");
					((Vector3*)(nint)vector)->x = (float)obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v22+8]");
					((Vector3*)(nint)vector)->z = 0f;
					Vector3 vector2 = ((Camera)(object)typeName).WorldToViewportPoint(vector);
					nint num9 = (nint)typeof(Vector2);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ S0_v68 (Il2CppClass<UnityEngine.Vector2>)+BA]");
					object obj9 = (nint)0 & (nint)0x200;
					if (obj9 != null)
					{
						nint num10 = (nint)typeof(Vector2);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ S0_v75 (Il2CppClass<UnityEngine.Vector2>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					((Vector3*)(nint)vector)->x = (float)obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					((Vector3*)(nint)vector)->z = 0f;
					Vector3 vector3 = (Vector2)vector;
					return;
				}
			}
			nint num11 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v30 (Il2CppClass<UICamera>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num12 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v35 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Vector2*)(nint)value)->x = (float)mLastPos;
		}
	}

	public static UICamera first
	{
		get
		{
			//IL_00f8: Expected I, but got Obj
			//IL_010e: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_013d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0142: Expected Obj, but got Unknown
			//IL_00a1: Expected I, but got Obj
			nint num = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UICamera>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v27 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (~(mDisableController ? 1u : 0u) == 0)
			{
				nint num3 = (nint)typeof(UIPopupList);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v16 (Il2CppClass<UIPopupList>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(UIPopupList);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v23 (Il2CppClass<UIPopupList>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Dictionary<string, string[]> dictionary = Localization.dictionary;
				return (UICamera)(dictionary ^ 1);
			}
			return null;
		}
	}

	public unsafe static ControlScheme currentScheme
	{
		get
		{
			//IL_0198: Expected I, but got Obj
			//IL_01ae: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00a1: Expected I, but got Obj
			//IL_00ee: Expected I, but got Obj
			//IL_0104: Expected Obj, but got I
			//IL_020d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0212: Expected Obj, but got Unknown
			//IL_021a: Expected I4, but got Obj
			//IL_012f: Expected I, but got Obj
			nint num = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UICamera>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v51 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (list != null)
			{
				nint num3 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v16 (Il2CppClass<UICamera>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v45 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				BetterList<UICamera> betterList = list;
				if (betterList.size != 0)
				{
					nint num5 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v27 (Il2CppClass<UICamera>)+BA]");
					object obj3 = (nint)0 & (nint)0x200;
					if (obj3 != null)
					{
						nint num6 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v39 (Il2CppClass<UICamera>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					BetterList<UICamera> betterList2 = list;
					object obj4 = betterList2.buffer + 16;
					return (ControlScheme)obj4;
				}
				return ControlScheme.Mouse;
			}
			return ControlScheme.Mouse;
		}
		set
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00a0: Expected Obj, but got I4
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ae: Expected Obj, but got Unknown
			//IL_00bf: Expected VT, but got Obj
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v11 (Il2CppClass<UICamera>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v18 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj2 = ((ControlScheme*)(int)value)->value__;
			object obj3 = obj2 + 8;
			obj3 = obj2;
			mLastPos = (Vector2)obj3;
		}
	}

	public static KeyCode currentKey
	{
		get
		{
			//IL_04e8: Expected I, but got Obj
			//IL_04fe: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00fc: Expected I, but got Obj
			//IL_0112: Expected Obj, but got I
			//IL_00a1: Expected I, but got Obj
			//IL_0557: Expected I, but got Obj
			//IL_056d: Expected Obj, but got I
			//IL_013d: Expected I, but got Obj
			//IL_018a: Expected I, but got Obj
			//IL_01d7: Expected I, but got Obj
			//IL_01ed: Expected Obj, but got I
			//IL_0381: Expected I, but got Obj
			//IL_0397: Expected Obj, but got I
			//IL_0218: Expected I, but got Obj
			//IL_0265: Expected I, but got Obj
			//IL_027b: Expected Obj, but got I
			//IL_0414: Expected I, but got Obj
			//IL_042a: Expected Obj, but got I
			//IL_03c2: Expected I, but got Obj
			//IL_02a6: Expected I, but got Obj
			//IL_0455: Expected I, but got Obj
			//IL_02f3: Expected I, but got Obj
			//IL_0309: Expected Obj, but got I
			//IL_0334: Expected I, but got Obj
			nint num = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UICamera>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v123 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			KeyCode result;
			if (mCurrentKey != KeyCode.None)
			{
				nint num3 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v16 (Il2CppClass<UICamera>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v116 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (mCurrentKey > KeyCode.Mouse6)
				{
					result = (KeyCode)2;
				}
				else
				{
					nint num5 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v26 (Il2CppClass<UICamera>)+BA]");
					object obj3 = (nint)0 & (nint)0x200;
					if (obj3 != null)
					{
						nint num6 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v109 (Il2CppClass<UICamera>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					nint num7 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S1_v9 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj4 = (nint)0 & (nint)0x200;
					if (obj4 != null)
					{
						nint num8 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S1_v29 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (((ComputeShader)(object)current).FindKernel((string)null) != 0)
					{
						nint num9 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v36 (Il2CppClass<UICamera>)+BA]");
						object obj5 = (nint)0 & (nint)0x200;
						if (obj5 != null)
						{
							nint num10 = (nint)typeof(UICamera);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S0_v103 (Il2CppClass<UICamera>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						if (mLastScheme != ControlScheme.Controller)
						{
							goto IL_0373;
						}
						nint num11 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S0_v80 (Il2CppClass<UICamera>)+BA]");
						object obj6 = (nint)0 & (nint)0x200;
						if (obj6 != null)
						{
							nint num12 = (nint)typeof(UICamera);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ S0_v97 (Il2CppClass<UICamera>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						UICamera uICamera = current;
						bool flag = mCurrentKey == uICamera.submitKey0;
						result = (KeyCode)2;
						if (!flag)
						{
							nint num13 = (nint)typeof(UICamera);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ S0_v86 (Il2CppClass<UICamera>)+BA]");
							object obj7 = (nint)0 & (nint)0x200;
							if (obj7 != null)
							{
								nint num14 = (nint)typeof(UICamera);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ S0_v91 (Il2CppClass<UICamera>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							UICamera uICamera2 = current;
							bool flag2 = mCurrentKey == uICamera2.submitKey1;
							result = (KeyCode)2;
							if (!flag2)
							{
								goto IL_0373;
							}
						}
					}
					else
					{
						result = KeyCode.None;
					}
				}
			}
			else
			{
				result = (KeyCode)1;
			}
			goto IL_06b4;
			IL_06b4:
			return result;
			IL_0373:
			nint num15 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ S0_v46 (Il2CppClass<UICamera>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num16 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ S0_v73 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UICamera uICamera3 = current;
			if (~(uICamera3.useMouse ? 1u : 0u) != 0)
			{
				nint num17 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ S0_v55 (Il2CppClass<UICamera>)+BA]");
				object obj9 = (nint)0 & (nint)0x200;
				if (obj9 != null)
				{
					nint num18 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ S0_v66 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				UICamera uICamera4 = current;
				if (~(uICamera4.useTouch ? 1u : 0u) == 0)
				{
					return (KeyCode)1;
				}
				return (KeyCode)2;
			}
			result = KeyCode.None;
			goto IL_06b4;
		}
		set
		{
			//IL_034f: Expected I, but got Obj
			//IL_0365: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_00bc: Expected I, but got Obj
			//IL_00d2: Expected Obj, but got I
			//IL_039e: Expected I, but got Obj
			//IL_03b4: Expected Obj, but got I
			//IL_00fd: Expected I, but got Obj
			//IL_01d8: Expected I, but got Obj
			//IL_01ee: Expected Obj, but got I
			//IL_0302: Expected I, but got Obj
			//IL_014a: Expected I, but got Obj
			//IL_0160: Expected Obj, but got I
			//IL_02b5: Expected I, but got Obj
			//IL_024f: Expected I, but got Obj
			//IL_018b: Expected I, but got Obj
			nint num = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UICamera>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v71 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (mLastScheme == (ControlScheme)value)
			{
				return;
			}
			switch (value)
			{
			case KeyCode.None:
			{
				nint num6 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v31 (Il2CppClass<UICamera>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num7 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v36 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Ray ray3 = currentRay;
				break;
			}
			case (KeyCode)2:
			{
				nint num8 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v62 (Il2CppClass<UICamera>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num9 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v67 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Ray ray4 = currentRay;
				break;
			}
			default:
			{
				nint num3 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v41 (Il2CppClass<UICamera>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				bool flag = obj2 != null;
				if (value == (KeyCode)1)
				{
					if (flag)
					{
						nint num4 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v57 (Il2CppClass<UICamera>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Ray ray = currentRay;
					break;
				}
				if (flag)
				{
					nint num5 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S0_v50 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Ray ray2 = currentRay;
				break;
			}
			}
			nint num10 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S0_v18 (Il2CppClass<UICamera>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num11 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S0_v24 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			mLastScheme = (ControlScheme)value;
		}
	}

	public static Ray currentRay
	{
		get
		{
			//IL_0511: Expected I, but got Obj
			//IL_0527: Expected Obj, but got I
			//IL_06a4: Invalid comparison between I4 and VT
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_054d: Expected I4, but got VT
			//IL_0585: Expected VT, but got I4
			//IL_00a1: Expected I, but got Obj
			//IL_00ee: Expected I, but got Obj
			//IL_0104: Expected Obj, but got I
			//IL_012f: Expected I, but got Obj
			//IL_03a1: Expected I, but got Obj
			//IL_03b7: Expected Obj, but got I
			//IL_03d4: Expected VT, but got Obj
			//IL_017c: Expected I, but got Obj
			//IL_0192: Expected Obj, but got I
			//IL_0657: Expected Obj, but got I
			//IL_05c8: Expected I, but got Obj
			//IL_05de: Expected Obj, but got I
			//IL_03f0: Expected I, but got Obj
			//IL_0420: Expected VT, but got Obj
			//IL_01bd: Expected I, but got Obj
			//IL_0459: Expected I, but got Obj
			//IL_046f: Expected Obj, but got I
			//IL_048c: Expected VT, but got Obj
			//IL_020a: Expected I, but got Obj
			//IL_068c: Expected Obj, but got I
			//IL_0446: Expected VT, but got Obj
			//IL_0257: Expected I, but got Obj
			//IL_026d: Expected Obj, but got I
			//IL_04a8: Expected I, but got Obj
			//IL_04d8: Expected VT, but got Obj
			//IL_0298: Expected I, but got Obj
			//IL_04fe: Expected VT, but got Obj
			//IL_02eb: Expected Obj, but got I4
			//IL_02fe: Expected I, but got Obj
			//IL_0314: Expected Obj, but got I
			//IL_062f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0634: Expected Obj, but got Unknown
			//IL_033f: Expected I, but got Obj
			nint num = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UICamera>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v125 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Ray ray = default;
			if ((object)mCurrentKey != (object)ray)
			{
				nint num3 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v16 (Il2CppClass<UICamera>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v119 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				mCurrentKey = (KeyCode)ray;
				KeyCode keyCode = (KeyCode)(mLastScheme = (ControlScheme)currentKey);
				bool flag = mLastScheme != mLastScheme;
				bool flag2 = !flag;
				ray = (Ray)keyCode;
				if (!flag2)
				{
					nint num5 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v25 (Il2CppClass<UICamera>)+BA]");
					object obj3 = (nint)0 & (nint)0x200;
					if (obj3 != null)
					{
						nint num6 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v115 (Il2CppClass<UICamera>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					int nextUnusedDepth = UIPanel.nextUnusedDepth;
					if (mLastScheme != ControlScheme.Mouse)
					{
						nint num7 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v67 (Il2CppClass<UICamera>)+BA]");
						object obj4 = (nint)0 & (nint)0x200;
						if (obj4 != null)
						{
							nint num8 = (nint)typeof(UICamera);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v109 (Il2CppClass<UICamera>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						nint num9 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S1_v27 (Il2CppClass<UnityEngine.Object>)+BA]");
						object obj5 = (nint)0 & (nint)0x200;
						if (obj5 != null)
						{
							nint num10 = (nint)typeof(UnityEngine.Object);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S1_v39 (Il2CppClass<UnityEngine.Object>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						if (((ComputeShader)(object)current).FindKernel((string)null) != 0)
						{
							nint num11 = (nint)typeof(UICamera);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v77 (Il2CppClass<UICamera>)+BA]");
							object obj6 = (nint)0 & (nint)0x200;
							if (obj6 != null)
							{
								nint num12 = (nint)typeof(UICamera);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S0_v103 (Il2CppClass<UICamera>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							UICamera uICamera = current;
							if (~(uICamera.autoHideCursor ? 1u : 0u) == 0)
							{
								Cursor.lockState = CursorLockMode.None;
								((ExcludeFromDocsAttribute)1)._002Ector();
								nint num13 = (nint)typeof(UICamera);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ S0_v88 (Il2CppClass<UICamera>)+BA]");
								object obj7 = (nint)0 & (nint)0x200;
								if (obj7 != null)
								{
									nint num14 = (nint)typeof(UICamera);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ S0_v97 (Il2CppClass<UICamera>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								object obj8 = mMouse + 16;
								object obj9 = obj8;
								_ = 2;
							}
						}
					}
					else
					{
						((ExcludeFromDocsAttribute)null)._002Ector();
						Cursor.lockState = CursorLockMode.Locked;
					}
					nint num15 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S0_v37 (Il2CppClass<UICamera>)+BA]");
					object obj10 = (nint)0 & (nint)0x200;
					bool flag3 = obj10 == null;
					ray = (Ray)typeof(UICamera);
					if (!flag3)
					{
						nint num16 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ S0_v58 (Il2CppClass<UICamera>)+74]");
						bool flag4 = (nint)0 == 0;
						bool flag5 = !flag4;
						ray = (Ray)typeof(UICamera);
						if (!flag5)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							ray = (Ray)typeof(UICamera);
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (UnityEngine.Ray)+5C]");
					object obj11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ S0_v42+90]");
					if ((nint)0 != 0)
					{
						nint num17 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ S0_v45 (Il2CppClass<UICamera>)+BA]");
						object obj12 = (nint)0 & (nint)0x200;
						bool flag6 = obj12 == null;
						ray = (Ray)typeof(UICamera);
						if (!flag6)
						{
							nint num18 = (nint)typeof(UICamera);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ S0_v52 (Il2CppClass<UICamera>)+74]");
							bool flag7 = (nint)0 == 0;
							bool flag8 = !flag7;
							ray = (Ray)typeof(UICamera);
							if (!flag8)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								ray = (Ray)typeof(UICamera);
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (UnityEngine.Ray)+5C]");
						object obj13 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
					}
				}
			}
			return ray;
		}
	}

	public static bool inputHasFocus
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UICamera>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (byte)mCurrentKey != 0;
		}
	}

	public unsafe static GameObject genericEventHandler
	{
		get
		{
			//IL_01e1: Expected I, but got Obj
			//IL_01f7: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0222: Expected I, but got Obj
			//IL_0238: Expected Obj, but got I
			//IL_00a1: Expected I, but got Obj
			//IL_00ee: Expected I, but got Obj
			//IL_013b: Expected I, but got Obj
			//IL_0151: Expected Obj, but got I
			//IL_017c: Expected I, but got Obj
			//IL_01c4: Expected Obj, but got I4
			nint num = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UICamera>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v50 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (~(mInputFocus ? 1u : 0u) == 0)
			{
				nint num3 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v18 (Il2CppClass<UICamera>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v44 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				nint num5 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S1_v7 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num6 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S1_v14 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)mSelected))
				{
					nint num7 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v28 (Il2CppClass<UICamera>)+BA]");
					object obj4 = (nint)0 & (nint)0x200;
					if (obj4 != null)
					{
						nint num8 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v38 (Il2CppClass<UICamera>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					string text = mSelected.tag;
					if (text != null)
					{
						return (GameObject)1;
					}
				}
			}
			return null;
		}
		set
		{
			//IL_024a: Unknown result type (might be due to invalid IL or missing references)
			//IL_024f: Expected Obj, but got Unknown
			//IL_0258: Expected Obj, but got I4
			//IL_0272: Expected I, but got Obj
			//IL_0288: Expected Obj, but got I
			//IL_0329: Expected I, but got Obj
			//IL_033f: Expected Obj, but got I
			//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c5: Expected VT, but got Unknown
			//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d3: Expected Obj, but got Unknown
			//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e1: Expected Obj, but got Unknown
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_00ad: Expected I, but got Obj
			//IL_00c3: Expected Obj, but got I
			//IL_00ee: Expected I, but got Obj
			//IL_013b: Expected I, but got Obj
			//IL_0151: Expected Obj, but got I
			//IL_02d9: Expected Obj, but got VT
			//IL_02e7: Expected I, but got Obj
			//IL_02fd: Expected Obj, but got I
			//IL_0371: Expected F4, but got Obj
			//IL_036c: Expected native int or pointer, but got VT
			//IL_038b: Expected F4, but got Obj
			//IL_0386: Expected native int or pointer, but got VT
			//IL_03a0: Expected F4, but got I
			//IL_039b: Expected native int or pointer, but got VT
			//IL_03b2: Expected Ref, but got VT
			//IL_017c: Expected I, but got Obj
			//IL_01c9: Expected I, but got Obj
			object obj2 = default;
			object obj = obj2 + 32;
			obj = 0;
			_ = 0;
			_ = 0;
			nint num = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13 (Il2CppClass<UICamera>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num2 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v90 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v21 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v86 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector4 vector = (Vector4)(obj2 + 56);
			object obj5 = obj2 + 8;
			object obj6 = obj2 + 16;
			if (((ComputeShader)(object)currentCamera).FindKernel((string)null) != 0)
			{
				nint num5 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v42 (Il2CppClass<UICamera>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num6 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v80 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (currentTouch != null)
				{
					nint num7 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v51 (Il2CppClass<UICamera>)+BA]");
					object obj8 = (nint)0 & (nint)0x200;
					if (obj8 != null)
					{
						nint num8 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S0_v74 (Il2CppClass<UICamera>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					MouseOrTouch mouseOrTouch = currentTouch;
					obj5 = mouseOrTouch.pos;
					nint num9 = (nint)typeof(Vector2);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S0_v60 (Il2CppClass<UnityEngine.Vector2>)+BA]");
					object obj9 = (nint)0 & (nint)0x200;
					if (obj9 != null)
					{
						nint num10 = (nint)typeof(Vector2);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ S0_v70 (Il2CppClass<UnityEngine.Vector2>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					obj2 = obj5;
					((Vector4*)(nint)vector)->x = (float)obj2;
					Vector3 vector2 = vector;
					((Vector4*)(nint)vector)->x = (float)obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v30+8]");
					((Vector4*)(nint)vector)->z = 0f;
					((Camera)(object)value).ScreenToViewportPoint_Injected(ref *(Vector3*)currentCamera, out *(Vector3*)vector);
					return;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
			GameObject gameObject = (GameObject)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			((UnityEngine.Object)value).m_CachedPtr = (IntPtr)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+10]");
			_ = 0;
		}
	}

	public static MouseOrTouch mouse0
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UICamera>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (MouseOrTouch)(object)mGenericHandler;
		}
	}

	public static MouseOrTouch mouse1
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_009d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a2: Expected Obj, but got Unknown
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UICamera>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v15 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (MouseOrTouch)(mMouse + 16);
		}
	}

	public static MouseOrTouch mouse2
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_009d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a2: Expected Obj, but got Unknown
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UICamera>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v15 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (MouseOrTouch)(mMouse + 20);
		}
	}

	private bool handlesEvents => true;

	public Camera cachedCamera
	{
		get
		{
			//IL_00ad: Expected I, but got Obj
			//IL_00c3: Expected Obj, but got I
			//IL_010a: Expected I, but got Obj
			//IL_0120: Expected Obj, but got I
			//IL_00ea: Expected Obj, but got I4
			//IL_00ee: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			nint num = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UICamera>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = HideTooltip();
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v9 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (Camera)((UnityEngine.Object)flag != this);
		}
	}

	public static GameObject tooltipObject
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_009d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a2: Expected Obj, but got Unknown
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UICamera>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v15 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (GameObject)(mMouse + 24);
		}
		set
		{
			//IL_007c: Expected I, but got Obj
			//IL_0092: Expected Obj, but got I
			//IL_00af: Expected I, but got Obj
			//IL_00d3: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0043: Expected I, but got Obj
			//IL_0069: Expected I, but got Obj
			nint num = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UICamera>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			bool flag = obj == null;
			nint num2 = (nint)typeof(UICamera);
			if (!flag)
			{
				nint num3 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<UICamera>)+74]");
				bool flag2 = (nint)0 == 0;
				bool flag3 = !flag2;
				num2 = (nint)typeof(UICamera);
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num2 = (nint)typeof(UICamera);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ L1_v2 (Il2CppClass<UICamera>)+5C]");
			object obj2 = (nint)0 + (nint)168;
			obj2 = value;
		}
	}

	public static bool isOverUI
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0099: Expected I4, but got Obj
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UICamera>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (byte)(int)mTooltip != 0;
		}
	}

	public static bool uiHasFocus
	{
		get
		{
			//IL_06a5: Expected I, but got Obj
			//IL_06bb: Expected Obj, but got I
			//IL_0a02: Expected I, but got Obj
			//IL_0a18: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_064f: Expected I, but got Obj
			//IL_071a: Expected I, but got Obj
			//IL_0730: Expected Obj, but got I
			//IL_00a1: Expected I, but got Obj
			//IL_02c0: Expected I, but got Obj
			//IL_0774: Expected I, but got Obj
			//IL_078a: Expected Obj, but got I
			//IL_0a56: Expected I, but got Obj
			//IL_0a6c: Expected Obj, but got I
			//IL_0112: Expected I, but got Obj
			//IL_0444: Expected Obj, but got I4
			//IL_030d: Expected I, but got Obj
			//IL_0323: Expected Obj, but got I
			//IL_015f: Expected I, but got Obj
			//IL_0986: Expected I, but got Obj
			//IL_099c: Expected Obj, but got I
			//IL_03bb: Expected I, but got Obj
			//IL_03d1: Expected Obj, but got I
			//IL_034e: Expected I, but got Obj
			//IL_0241: Expected I, but got Obj
			//IL_01d0: Expected I, but got Obj
			//IL_0602: Expected I, but got Obj
			//IL_088d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0892: Expected Obj, but got Unknown
			//IL_08c3: Expected I, but got Obj
			//IL_08d9: Expected Obj, but got I
			//IL_03fc: Expected I, but got Obj
			//IL_0aaa: Expected Obj, but got I
			//IL_0470: Expected I, but got Obj
			//IL_0521: Expected Obj, but got I
			//IL_04bd: Expected I, but got Obj
			//IL_0904: Expected I, but got Obj
			//IL_091a: Expected Obj, but got I
			//IL_050c: Expected Obj, but got I
			//IL_0945: Expected I, but got Obj
			//IL_095b: Expected Obj, but got I
			//IL_0534: Expected I, but got Obj
			//IL_057c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0581: Expected Obj, but got Unknown
			//IL_059c: Expected I, but got Obj
			int renderedFrameCount = Time.renderedFrameCount;
			nint num = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v8 (Il2CppClass<UICamera>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v219 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (mLastOverCheck != renderedFrameCount)
			{
				nint num3 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v33 (Il2CppClass<UICamera>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v213 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				mLastOverCheck = renderedFrameCount;
				nint num5 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v40 (Il2CppClass<UICamera>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				bool flag = obj3 == null;
				if (currentTouch != null)
				{
					if (!flag)
					{
						nint num6 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S0_v207 (Il2CppClass<UICamera>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					MouseOrTouch mouseOrTouch = currentTouch;
					nint num7 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S1_v53 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj4 = (nint)0 & (nint)0x200;
					if (obj4 != null)
					{
						nint num8 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S1_v68 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					int num9 = ((ComputeShader)(object)mouseOrTouch.pressed).FindKernel((string)null);
					nint num10 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ S1_v59 (Il2CppClass<UICamera>)+BA]");
					object obj5 = (nint)0 & (nint)0x200;
					bool flag2 = obj5 == null;
					bool flag3;
					if (num9 != 0)
					{
						if (!flag2)
						{
							nint num11 = (nint)typeof(UICamera);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ S0_v201 (Il2CppClass<UICamera>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						MouseOrTouch mouseOrTouch2 = currentTouch;
						flag3 = IsPressed(mouseOrTouch2.pressed);
					}
					else
					{
						if (!flag2)
						{
							nint num12 = (nint)typeof(UICamera);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ S0_v187 (Il2CppClass<UICamera>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						MouseOrTouch mouseOrTouch3 = currentTouch;
						flag3 = IsPressed(mouseOrTouch3.current);
					}
					mLastOverResult = flag3;
					goto IL_07e7;
				}
				if (!flag)
				{
					nint num13 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S0_v159 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				List<MouseOrTouch> list = activeTouches;
				int num14 = 0;
				while (num14 < list._size)
				{
					nint num15 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ S0_v126 (Il2CppClass<UICamera>)+BA]");
					object obj6 = (nint)0 & (nint)0x200;
					if (obj6 != null)
					{
						nint num16 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ S0_v153 (Il2CppClass<UICamera>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					MouseOrTouch mouseOrTouch4 = activeTouches.get_Item(num14);
					if (!IsPressed(mouseOrTouch4.pressed))
					{
						int num17 = num14 + 1;
						num14 = num17;
						continue;
					}
					goto IL_03ad;
				}
				object obj7 = 0;
				bool flag4;
				while (true)
				{
					nint num18 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ S0_v64 (Il2CppClass<UICamera>)+BA]");
					object obj8 = (nint)0 & (nint)0x200;
					flag4 = obj8 != null;
					if ((nint)obj7 > 2)
					{
						break;
					}
					if (flag4)
					{
						nint num19 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ S0_v119 (Il2CppClass<UICamera>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					object obj9 = mMouse + 16;
					object obj10 = obj7 << 2;
					object obj11 = obj9 + obj10;
					object obj12 = obj11;
					nint num20 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ S1_v24 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj13 = (nint)0 & (nint)0x200;
					if (obj13 != null)
					{
						nint num21 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ S1_v42 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ S0_v93+38]");
					GameObject go;
					if (((ComputeShader)0).FindKernel(null) != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ S0_v93+38]");
						go = (GameObject)0;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ S0_v93+34]");
						go = (GameObject)0;
					}
					nint num22 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ S1_v30 (Il2CppClass<UICamera>)+BA]");
					object obj14 = (nint)0 & (nint)0x200;
					if (obj14 != null)
					{
						nint num23 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ S1_v38 (Il2CppClass<UICamera>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (!IsPressed(go))
					{
						object obj15 = obj7 + 1;
						obj7 = obj15;
						continue;
					}
					goto IL_0937;
				}
				if (flag4)
				{
					nint num24 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ S0_v80 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				MouseOrTouch mouseOrTouch5 = controller;
				bool flag5 = IsPressed(mouseOrTouch5.pressed);
				mLastOverResult = flag5;
			}
			nint num25 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v18 (Il2CppClass<UICamera>)+BA]");
			object obj16 = (nint)0 & (nint)0x200;
			if (obj16 != null)
			{
				nint num26 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v21 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			goto IL_07e7;
			IL_07e7:
			return mLastOverResult;
			IL_03ad:
			nint num27 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ S0_v137 (Il2CppClass<UICamera>)+BA]");
			object obj17 = (nint)0 & (nint)0x200;
			if (obj17 != null)
			{
				nint num28 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ S0_v145 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			mLastOverResult = true;
			goto IL_07e7;
			IL_0937:
			nint num29 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ S0_v99 (Il2CppClass<UICamera>)+BA]");
			object obj18 = (nint)0 & (nint)0x200;
			if (obj18 != null)
			{
				nint num30 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ S0_v107 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			mLastOverResult = true;
			goto IL_07e7;
		}
	}

	public static bool interactingWithUI
	{
		get
		{
			//IL_0614: Expected I, but got Obj
			//IL_062a: Expected Obj, but got I
			//IL_0945: Expected I, but got Obj
			//IL_095b: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_05be: Expected I, but got Obj
			//IL_0692: Expected I, but got Obj
			//IL_06a8: Expected Obj, but got I
			//IL_00a1: Expected I, but got Obj
			//IL_0701: Expected I, but got Obj
			//IL_0717: Expected Obj, but got I
			//IL_0183: Expected I, but got Obj
			//IL_0112: Expected I, but got Obj
			//IL_0265: Expected I, but got Obj
			//IL_01f4: Expected I, but got Obj
			//IL_03e9: Expected Obj, but got I4
			//IL_02b2: Expected I, but got Obj
			//IL_02c8: Expected Obj, but got I
			//IL_08c9: Expected I, but got Obj
			//IL_08df: Expected Obj, but got I
			//IL_0360: Expected I, but got Obj
			//IL_0376: Expected Obj, but got I
			//IL_02f3: Expected I, but got Obj
			//IL_0571: Expected I, but got Obj
			//IL_080c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0811: Expected Obj, but got Unknown
			//IL_0845: Expected Obj, but got I
			//IL_03a1: Expected I, but got Obj
			//IL_0865: Expected I, but got Obj
			//IL_087b: Expected Obj, but got I
			//IL_0415: Expected I, but got Obj
			//IL_0462: Expected I, but got Obj
			//IL_0478: Expected Obj, but got I
			//IL_050b: Expected I, but got Obj
			//IL_08a9: Expected Obj, but got I
			//IL_04a3: Expected I, but got Obj
			//IL_04eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_04f0: Expected Obj, but got Unknown
			int renderedFrameCount = Time.renderedFrameCount;
			nint num = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v8 (Il2CppClass<UICamera>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v207 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (mLastFocusCheck != renderedFrameCount)
			{
				nint num3 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v33 (Il2CppClass<UICamera>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v201 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				mLastFocusCheck = renderedFrameCount;
				GameObject gameObject = genericEventHandler;
				nint num5 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S1_v11 (Il2CppClass<UICamera>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				bool flag = obj3 == null;
				if ((object)gameObject != null)
				{
					if (!flag)
					{
						nint num6 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S0_v195 (Il2CppClass<UICamera>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					mLastFocusResult = true;
				}
				else
				{
					if (!flag)
					{
						nint num7 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S0_v182 (Il2CppClass<UICamera>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool flag2 = currentTouch == null;
					nint num8 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ S1_v16 (Il2CppClass<UICamera>)+BA]");
					object obj4 = (nint)0 & (nint)0x200;
					bool flag3 = obj4 == null;
					if (flag2)
					{
						if (!flag3)
						{
							nint num9 = (nint)typeof(UICamera);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ S0_v158 (Il2CppClass<UICamera>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						List<MouseOrTouch> list = activeTouches;
						int num10 = 0;
						while (num10 < list._size)
						{
							nint num11 = (nint)typeof(UICamera);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ S0_v125 (Il2CppClass<UICamera>)+BA]");
							object obj5 = (nint)0 & (nint)0x200;
							if (obj5 != null)
							{
								nint num12 = (nint)typeof(UICamera);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ S0_v152 (Il2CppClass<UICamera>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							MouseOrTouch mouseOrTouch = activeTouches.get_Item(num10);
							if (!IsPressed(mouseOrTouch.pressed))
							{
								int num13 = num10 + 1;
								num10 = num13;
								continue;
							}
							goto IL_0352;
						}
						object obj6 = 0;
						bool flag4;
						while (true)
						{
							nint num14 = (nint)typeof(UICamera);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ S0_v65 (Il2CppClass<UICamera>)+BA]");
							object obj7 = (nint)0 & (nint)0x200;
							flag4 = obj7 != null;
							if ((nint)obj6 > 2)
							{
								break;
							}
							if (flag4)
							{
								nint num15 = (nint)typeof(UICamera);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ S0_v118 (Il2CppClass<UICamera>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							object obj8 = mMouse + 16;
							object obj9 = obj6 << 2;
							object obj10 = obj8 + obj9;
							object obj11 = obj10;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ S0_v94+38]");
							if (!IsPressed((GameObject)0))
							{
								nint num16 = (nint)typeof(UICamera);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ S1_v37 (Il2CppClass<UICamera>)+BA]");
								object obj12 = (nint)0 & (nint)0x200;
								if (obj12 != null)
								{
									nint num17 = (nint)typeof(UICamera);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ S1_v43 (Il2CppClass<UICamera>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ S0_v94+34]");
								if (!IsPressed((GameObject)0))
								{
									object obj13 = obj6 + 1;
									obj6 = obj13;
									continue;
								}
							}
							goto IL_0857;
						}
						if (flag4)
						{
							nint num18 = (nint)typeof(UICamera);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ S0_v81 (Il2CppClass<UICamera>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						MouseOrTouch mouseOrTouch2 = controller;
						bool flag5 = IsPressed(mouseOrTouch2.pressed);
						mLastFocusResult = flag5;
						goto IL_0937;
					}
					if (!flag3)
					{
						nint num19 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ S0_v176 (Il2CppClass<UICamera>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool flag6 = currentTouch();
					mLastFocusResult = flag6;
				}
				goto IL_0766;
			}
			goto IL_0937;
			IL_0352:
			nint num20 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ S0_v136 (Il2CppClass<UICamera>)+BA]");
			object obj14 = (nint)0 & (nint)0x200;
			if (obj14 != null)
			{
				nint num21 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ S0_v144 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			mLastFocusResult = true;
			goto IL_0766;
			IL_0857:
			nint num22 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ S0_v99 (Il2CppClass<UICamera>)+BA]");
			object obj15 = (nint)0 & (nint)0x200;
			if (obj15 != null)
			{
				nint num23 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ S0_v107 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			mLastFocusResult = true;
			goto IL_0766;
			IL_0937:
			nint num24 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v18 (Il2CppClass<UICamera>)+BA]");
			object obj16 = (nint)0 & (nint)0x200;
			if (obj16 != null)
			{
				nint num25 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v21 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			goto IL_0766;
			IL_0766:
			return mLastFocusResult;
		}
	}

	public static GameObject hoveredObject
	{
		get
		{
			//IL_04a4: Expected I, but got Obj
			//IL_04ba: Expected Obj, but got I
			//IL_0717: Expected I, but got Obj
			//IL_072d: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0762: Expected Obj, but got I4
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_044e: Expected I, but got Obj
			//IL_0522: Expected I, but got Obj
			//IL_0538: Expected Obj, but got I
			//IL_00a1: Expected I, but got Obj
			//IL_0183: Expected I, but got Obj
			//IL_0112: Expected I, but got Obj
			//IL_0307: Expected Obj, but got I4
			//IL_01d0: Expected I, but got Obj
			//IL_01e6: Expected Obj, but got I
			//IL_069b: Expected I, but got Obj
			//IL_06b1: Expected Obj, but got I
			//IL_027e: Expected I, but got Obj
			//IL_0294: Expected Obj, but got I
			//IL_0211: Expected I, but got Obj
			//IL_0401: Expected I, but got Obj
			//IL_0601: Unknown result type (might be due to invalid IL or missing references)
			//IL_0606: Expected Obj, but got Unknown
			//IL_063a: Expected Obj, but got I
			//IL_02bf: Expected I, but got Obj
			//IL_065a: Expected I, but got Obj
			//IL_0670: Expected Obj, but got I
			//IL_0333: Expected I, but got Obj
			//IL_037b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0380: Expected Obj, but got Unknown
			//IL_039b: Expected I, but got Obj
			int renderedFrameCount = Time.renderedFrameCount;
			nint num = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v8 (Il2CppClass<UICamera>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v171 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (mLastInteractionCheck != renderedFrameCount)
			{
				nint num3 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v33 (Il2CppClass<UICamera>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v165 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				mLastInteractionCheck = renderedFrameCount;
				GameObject gameObject = genericEventHandler;
				nint num5 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S1_v11 (Il2CppClass<UICamera>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				bool flag = obj3 == null;
				if ((object)gameObject != null)
				{
					if (!flag)
					{
						nint num6 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v159 (Il2CppClass<UICamera>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					mLastInteractionResult = true;
					goto IL_074a;
				}
				if (!flag)
				{
					nint num7 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S0_v146 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				List<MouseOrTouch> list = activeTouches;
				int num8 = 0;
				while (num8 < list._size)
				{
					nint num9 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ S0_v113 (Il2CppClass<UICamera>)+BA]");
					object obj4 = (nint)0 & (nint)0x200;
					if (obj4 != null)
					{
						nint num10 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S0_v140 (Il2CppClass<UICamera>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					MouseOrTouch mouseOrTouch = activeTouches.get_Item(num8);
					if (!IsPressed(mouseOrTouch.pressed))
					{
						int num11 = num8 + 1;
						num8 = num11;
						continue;
					}
					goto IL_0270;
				}
				object obj5 = 0;
				bool flag2;
				while (true)
				{
					nint num12 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ S0_v57 (Il2CppClass<UICamera>)+BA]");
					object obj6 = (nint)0 & (nint)0x200;
					flag2 = obj6 != null;
					if ((nint)obj5 > 2)
					{
						break;
					}
					if (flag2)
					{
						nint num13 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ S0_v106 (Il2CppClass<UICamera>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					object obj7 = mMouse + 16;
					object obj8 = obj5 << 2;
					object obj9 = obj7 + obj8;
					object obj10 = obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ S0_v86+38]");
					if (!IsPressed((GameObject)0))
					{
						object obj11 = obj5 + 1;
						obj5 = obj11;
						continue;
					}
					goto IL_064c;
				}
				if (flag2)
				{
					nint num14 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ S0_v73 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				MouseOrTouch mouseOrTouch2 = controller;
				bool flag3 = IsPressed(mouseOrTouch2.pressed);
				mLastInteractionResult = flag3;
			}
			nint num15 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v23 (Il2CppClass<UICamera>)+BA]");
			object obj12 = (nint)0 & (nint)0x200;
			if (obj12 != null)
			{
				nint num16 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v26 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			goto IL_074a;
			IL_074a:
			bool flag4 = mLastInteractionResult;
			return (GameObject)flag4;
			IL_064c:
			nint num17 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ S0_v90 (Il2CppClass<UICamera>)+BA]");
			object obj13 = (nint)0 & (nint)0x200;
			if (obj13 != null)
			{
				nint num18 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ S0_v98 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			mLastInteractionResult = true;
			goto IL_074a;
			IL_0270:
			nint num19 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ S0_v124 (Il2CppClass<UICamera>)+BA]");
			object obj14 = (nint)0 & (nint)0x200;
			if (obj14 != null)
			{
				nint num20 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ S0_v132 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			mLastInteractionResult = true;
			goto IL_074a;
		}
		set
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UICamera>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			BMFont bmFont = ((UIFont)(object)value).bmFont;
		}
	}

	public static GameObject controllerNavigationObject
	{
		get
		{
			//IL_046a: Expected I, but got Obj
			//IL_0480: Expected Obj, but got I
			//IL_020a: Expected I, but got Obj
			//IL_0220: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_051c: Expected I, but got Obj
			//IL_0532: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_024b: Expected I, but got Obj
			//IL_055d: Expected I, but got Obj
			//IL_0573: Expected Obj, but got I
			//IL_0590: Expected I, but got Obj
			//IL_0298: Expected I, but got Obj
			//IL_017c: Expected I, but got Obj
			//IL_0192: Expected Obj, but got I
			//IL_00a1: Expected I, but got Obj
			//IL_0637: Expected Obj, but got I
			//IL_0640: Expected Obj, but got I4
			//IL_02e5: Expected I, but got Obj
			//IL_02fb: Expected Obj, but got I
			//IL_00ee: Expected I, but got Obj
			//IL_0104: Expected Obj, but got I
			//IL_0401: Expected I, but got Obj
			//IL_0431: Expected I, but got Obj
			//IL_01bd: Expected I, but got Obj
			//IL_0326: Expected I, but got Obj
			//IL_012f: Expected I, but got Obj
			//IL_0457: Expected I, but got Obj
			//IL_0373: Expected I, but got Obj
			//IL_0389: Expected Obj, but got I
			//IL_03b4: Expected I, but got Obj
			nint num = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UICamera>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v120 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (currentTouch != null)
			{
				nint num3 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v77 (Il2CppClass<UICamera>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v116 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (currentKey == KeyCode.None)
				{
					nint num5 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v101 (Il2CppClass<UICamera>)+BA]");
					object obj3 = (nint)0 & (nint)0x200;
					if (obj3 != null)
					{
						nint num6 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S0_v110 (Il2CppClass<UICamera>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					MouseOrTouch mouseOrTouch = currentTouch;
					if (~(mouseOrTouch.dragStarted ? 1u : 0u) != 0)
					{
						goto IL_01fc;
					}
				}
				nint num7 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v86 (Il2CppClass<UICamera>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num8 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v94 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				MouseOrTouch mouseOrTouch2 = currentTouch;
				return mouseOrTouch2.current;
			}
			goto IL_01fc;
			IL_01fc:
			nint num9 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v17 (Il2CppClass<UICamera>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num10 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v70 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num11 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S1_v7 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num12 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S1_v19 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)mHover))
			{
				nint num13 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S0_v42 (Il2CppClass<UICamera>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num14 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S0_v64 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string text = mHover.tag;
				if (text != null)
				{
					nint num15 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ S0_v51 (Il2CppClass<UICamera>)+BA]");
					object obj8 = (nint)0 & (nint)0x200;
					if (obj8 != null)
					{
						nint num16 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ S0_v58 (Il2CppClass<UICamera>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					return mHover;
				}
			}
			nint num17 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S0_v27 (Il2CppClass<UICamera>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			bool flag = obj9 == null;
			nint num18 = (nint)typeof(UICamera);
			if (!flag)
			{
				nint num19 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S0_v35 (Il2CppClass<UICamera>)+74]");
				bool flag2 = (nint)0 == 0;
				bool flag3 = !flag2;
				num18 = (nint)typeof(UICamera);
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num18 = (nint)typeof(UICamera);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ L0_v10 (Il2CppClass<UICamera>)+5C]");
			object obj10 = (nint)0 + (nint)308;
			obj10 = 0;
			return null;
		}
		set
		{
			//IL_0dd4: Expected I, but got Obj
			//IL_0dea: Expected Obj, but got I
			//IL_151d: Expected I, but got Obj
			//IL_1533: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_00ad: Expected I, but got Obj
			//IL_00c3: Expected Obj, but got I
			//IL_0149: Expected I, but got Obj
			//IL_015f: Expected Obj, but got I
			//IL_00ee: Expected I, but got Obj
			//IL_0e7f: Expected I, but got Obj
			//IL_0e95: Expected Obj, but got I
			//IL_0ea7: Expected Obj, but got I4
			//IL_0136: Expected Obj, but got I4
			//IL_0e34: Expected I, but got Obj
			//IL_0e4a: Expected Obj, but got I
			//IL_018a: Expected I, but got Obj
			//IL_1568: Expected I, but got Obj
			//IL_157e: Expected Obj, but got I
			//IL_01d7: Expected I, but got Obj
			//IL_0ee1: Expected I, but got Obj
			//IL_0ef7: Expected Obj, but got I
			//IL_0224: Expected I, but got Obj
			//IL_15a9: Expected I, but got Obj
			//IL_15bf: Expected Obj, but got I
			//IL_0271: Expected I, but got Obj
			//IL_0287: Expected Obj, but got I
			//IL_04d3: Expected I, but got Obj
			//IL_0fca: Expected I, but got Obj
			//IL_0fe0: Expected Obj, but got I
			//IL_0ffd: Expected I, but got Obj
			//IL_0520: Expected I, but got Obj
			//IL_02b2: Expected I, but got Obj
			//IL_15f2: Expected Obj, but got I
			//IL_161f: Expected I, but got Obj
			//IL_1635: Expected Obj, but got I
			//IL_056d: Expected I, but got Obj
			//IL_0583: Expected Obj, but got I
			//IL_02ff: Expected I, but got Obj
			//IL_0315: Expected Obj, but got I
			//IL_0689: Expected I, but got Obj
			//IL_06b9: Expected I, but got Obj
			//IL_1014: Expected Obj, but got I4
			//IL_1031: Expected I4, but got Obj
			//IL_0f4e: Expected Obj, but got I4
			//IL_0f6b: Expected I4, but got Obj
			//IL_06f2: Expected I, but got Obj
			//IL_05ae: Expected I, but got Obj
			//IL_041b: Expected I, but got Obj
			//IL_0431: Expected Obj, but got I
			//IL_044e: Expected I, but got Obj
			//IL_0340: Expected I, but got Obj
			//IL_073f: Expected I, but got Obj
			//IL_0755: Expected Obj, but got I
			//IL_06df: Expected I, but got Obj
			//IL_05fb: Expected I, but got Obj
			//IL_0611: Expected Obj, but got I
			//IL_0fae: Expected Obj, but got I
			//IL_0fb7: Expected Obj, but got I4
			//IL_038d: Expected I, but got Obj
			//IL_03a3: Expected Obj, but got I
			//IL_0c79: Expected I, but got Obj
			//IL_0c8f: Expected Obj, but got I
			//IL_0cac: Expected I, but got Obj
			//IL_1075: Expected I, but got Obj
			//IL_108b: Expected Obj, but got I
			//IL_046a: Expected I, but got Obj
			//IL_049a: Expected I, but got Obj
			//IL_13f0: Expected Obj, but got I
			//IL_1407: Expected I, but got Obj
			//IL_141d: Expected Obj, but got I
			//IL_0780: Expected I, but got Obj
			//IL_063c: Expected I, but got Obj
			//IL_03ce: Expected I, but got Obj
			//IL_0cc8: Expected I, but got Obj
			//IL_0cf8: Expected I, but got Obj
			//IL_07cd: Expected I, but got Obj
			//IL_04c0: Expected I, but got Obj
			//IL_0d31: Expected I, but got Obj
			//IL_12f3: Expected I, but got Obj
			//IL_1309: Expected Obj, but got I
			//IL_0800: Expected I, but got Obj
			//IL_0816: Expected Obj, but got I
			//IL_1474: Expected I, but got Obj
			//IL_148a: Expected Obj, but got I
			//IL_14a7: Expected I, but got Obj
			//IL_0d1e: Expected I, but got Obj
			//IL_091b: Expected I, but got Obj
			//IL_0931: Expected Obj, but got I
			//IL_10f8: Expected I, but got Obj
			//IL_110e: Expected Obj, but got I
			//IL_14cb: Expected Obj, but got I
			//IL_14d3: Expected Obj, but got I4
			//IL_14e1: Expected I, but got Obj
			//IL_14f7: Expected Obj, but got I
			//IL_1500: Expected Obj, but got I4
			//IL_0be8: Expected I, but got Obj
			//IL_0bfe: Expected Obj, but got I
			//IL_0b41: Expected I, but got Obj
			//IL_119e: Expected I, but got Obj
			//IL_11b4: Expected Obj, but got I
			//IL_0841: Expected I, but got Obj
			//IL_0d85: Expected I, but got Obj
			//IL_0d93: Expected I, but got Obj
			//IL_13b8: Expected Obj, but got I4
			//IL_13d5: Expected I4, but got Obj
			//IL_0b74: Expected I, but got Obj
			//IL_0b8a: Expected Obj, but got I
			//IL_11ee: Expected I, but got Obj
			//IL_1204: Expected Obj, but got I
			//IL_095c: Expected I, but got Obj
			//IL_0874: Expected I, but got Obj
			//IL_0c29: Expected I, but got Obj
			//IL_098f: Expected I, but got Obj
			//IL_08a7: Expected I, but got Obj
			//IL_08bd: Expected Obj, but got I
			//IL_0dc1: Expected I, but got Obj
			//IL_0bb5: Expected I, but got Obj
			//IL_12a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_12ad: Expected Obj, but got Unknown
			//IL_12b5: Expected I4, but got Obj
			//IL_117d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1182: Expected Obj, but got Unknown
			//IL_125e: Expected I, but got Obj
			//IL_1274: Expected Obj, but got I
			//IL_0a3d: Expected I, but got Obj
			//IL_1247: Expected Obj, but got I4
			//IL_08e8: Expected I, but got Obj
			//IL_12c4: Expected Obj, but got I4
			//IL_09e6: Expected I, but got Obj
			//IL_0a70: Expected I, but got Obj
			//IL_0aa3: Expected I, but got Obj
			//IL_0ab9: Expected Obj, but got I
			//IL_0ad6: Expected I, but got Obj
			//IL_133c: Expected Obj, but got I
			//IL_1344: Expected Obj, but got I4
			//IL_134d: Expected Obj, but got I4
			//IL_135f: Expected I, but got Obj
			//IL_1375: Expected Obj, but got I
			//IL_137d: Expected Obj, but got I4
			//IL_0af2: Expected I, but got Obj
			//IL_0b00: Expected I, but got Obj
			//IL_0b2e: Expected I, but got Obj
			nint num = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UICamera>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v431 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v5 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S1_v167 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (mHover != value)
			{
				return;
			}
			nint num5 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v21 (Il2CppClass<UICamera>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v425 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj4;
			if (currentTouch != null)
			{
				obj4 = 0;
			}
			else
			{
				nint num7 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v407 (Il2CppClass<UICamera>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num8 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S0_v418 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				currentTouchID = -100;
				nint num9 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S0_v414 (Il2CppClass<UICamera>)+5C]");
				object obj6 = (nint)0 + (nint)160;
				obj6 = controller;
				obj4 = 1;
			}
			nint num10 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S0_v34 (Il2CppClass<UICamera>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num11 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S0_v402 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			BMFont bmFont = ((UIFont)null).bmFont;
			nint num12 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S1_v16 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num13 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S1_v156 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)mSelected))
			{
				nint num14 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ S0_v344 (Il2CppClass<UICamera>)+BA]");
				object obj9 = (nint)0 & (nint)0x200;
				if (obj9 != null)
				{
					nint num15 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ S0_v398 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				KeyCode keyCode = currentKey;
				if (keyCode == (KeyCode)2)
				{
					nint num16 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ S0_v352 (Il2CppClass<UICamera>)+BA]");
					object obj10 = (nint)0 & (nint)0x200;
					if (obj10 != null)
					{
						nint num17 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ S0_v392 (Il2CppClass<UICamera>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					object obj11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
					bool released = default;
					((UICamera)(object)mSelected).ProcessTouch((byte)(int)"OnSelect" != 0, released);
					if (onSelect != null)
					{
						nint num18 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ S0_v379 (Il2CppClass<UICamera>)+BA]");
						object obj12 = (nint)0 & (nint)0x200;
						if (obj12 != null)
						{
							nint num19 = (nint)typeof(UICamera);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ S0_v386 (Il2CppClass<UICamera>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A74");
					}
					nint num20 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ S0_v365 (Il2CppClass<UICamera>)+BA]");
					object obj13 = (nint)0 & (nint)0x200;
					bool flag = obj13 == null;
					nint num21 = (nint)typeof(UICamera);
					if (!flag)
					{
						nint num22 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ S0_v372 (Il2CppClass<UICamera>)+74]");
						bool flag2 = (nint)0 == 0;
						bool flag3 = !flag2;
						num21 = (nint)typeof(UICamera);
						if (!flag3)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							num21 = (nint)typeof(UICamera);
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ L1_v37 (Il2CppClass<UICamera>)+5C]");
					object obj14 = (nint)0 + (nint)312;
					obj14 = 0;
				}
			}
			nint num23 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ S0_v47 (Il2CppClass<UICamera>)+BA]");
			object obj15 = (nint)0 & (nint)0x200;
			if (obj15 != null)
			{
				nint num24 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ S0_v337 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num25 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ S1_v24 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj16 = (nint)0 & (nint)0x200;
			if (obj16 != null)
			{
				nint num26 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ S1_v134 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)mHover))
			{
				nint num27 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ S0_v306 (Il2CppClass<UICamera>)+BA]");
				object obj17 = (nint)0 & (nint)0x200;
				if (obj17 != null)
				{
					nint num28 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ S0_v331 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				bool released2 = default;
				((UICamera)(object)mHover).ProcessTouch((byte)(int)"OnHover" != 0, released2);
				if (onHover != null)
				{
					nint num29 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ S0_v318 (Il2CppClass<UICamera>)+BA]");
					object obj18 = (nint)0 & (nint)0x200;
					if (obj18 != null)
					{
						nint num30 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ S0_v325 (Il2CppClass<UICamera>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A74");
				}
			}
			nint num31 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ S0_v57 (Il2CppClass<UICamera>)+BA]");
			object obj19 = (nint)0 & (nint)0x200;
			bool flag4 = obj19 == null;
			nint num32 = (nint)typeof(UICamera);
			if (!flag4)
			{
				nint num33 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ S0_v299 (Il2CppClass<UICamera>)+74]");
				bool flag5 = (nint)0 == 0;
				bool flag6 = !flag5;
				num32 = (nint)typeof(UICamera);
				if (!flag6)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num32 = (nint)typeof(UICamera);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ L1_v16 (Il2CppClass<UICamera>)+5C]");
			object obj20 = (nint)0 + (nint)308;
			obj20 = value;
			MouseOrTouch mouseOrTouch = currentTouch;
			mouseOrTouch.clickNotification = ClickNotification.None;
			nint num34 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ S1_v35 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj21 = (nint)0 & (nint)0x200;
			if (obj21 != null)
			{
				nint num35 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ S1_v118 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)mHover))
			{
				nint num36 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ S0_v124 (Il2CppClass<UICamera>)+BA]");
				object obj22 = (nint)0 & (nint)0x200;
				if (obj22 != null)
				{
					nint num37 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ S0_v293 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				MouseOrTouch mouseOrTouch2 = controller;
				nint num38 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ S0_v137 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj23 = (nint)0 & (nint)0x200;
				if (obj23 != null)
				{
					nint num39 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ S0_v290 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)(object)mHover).FindKernel((string)(object)mouseOrTouch2.current) != 0)
				{
					nint num40 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v557 @ S0_v261 (Il2CppClass<UICamera>)+BA]");
					object obj24 = (nint)0 & (nint)0x200;
					if (obj24 != null)
					{
						nint num41 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v581 @ S0_v285 (Il2CppClass<UICamera>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					UIKeyNavigation component = mHover.GetComponent<UIKeyNavigation>();
					nint num42 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v629 @ S1_v104 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj25 = (nint)0 & (nint)0x200;
					if (obj25 != null)
					{
						nint num43 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v668 @ S1_v115 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (((ComputeShader)(object)component).FindKernel((string)null) != 0)
					{
						nint num44 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v760 @ S0_v272 (Il2CppClass<UICamera>)+BA]");
						object obj26 = (nint)0 & (nint)0x200;
						if (obj26 != null)
						{
							nint num45 = (nint)typeof(UICamera);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v775 @ S0_v280 (Il2CppClass<UICamera>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						object obj27 = controller + 52;
						obj27 = mHover;
					}
				}
				if (obj4 != null)
				{
					nint num46 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v594 @ S0_v187 (Il2CppClass<UICamera>)+BA]");
					object obj28 = (nint)0 & (nint)0x200;
					if (obj28 != null)
					{
						nint num47 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v633 @ S0_v255 (Il2CppClass<UICamera>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					nint num48 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v643 @ S1_v75 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj29 = (nint)0 & (nint)0x200;
					if (obj29 != null)
					{
						nint num49 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v674 @ S1_v97 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					int num50 = ((ComputeShader)(object)mHover).FindKernel((string)null);
					nint num51 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v726 @ S1_v81 (Il2CppClass<UICamera>)+BA]");
					object obj30 = (nint)0 & (nint)0x200;
					bool flag7 = obj30 == null;
					int num53;
					if (num50 != 0)
					{
						if (!flag7)
						{
							nint num52 = (nint)typeof(UICamera);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v787 @ S0_v250 (Il2CppClass<UICamera>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						bool activeSelf = mHover.activeSelf;
						num53 = GetDirection((string)activeSelf);
					}
					else
					{
						if (!flag7)
						{
							nint num54 = (nint)typeof(UICamera);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v798 @ S0_v237 (Il2CppClass<UICamera>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						BetterList<UICamera> betterList = list;
						object obj31 = betterList.buffer + 16;
						num53 = (int)obj31;
					}
					nint num55 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v825 @ S0_v197 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj32 = (nint)0 & (nint)0x200;
					if (obj32 != null)
					{
						nint num56 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v832 @ S0_v223 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (((ComputeShader)num53).FindKernel(null) != 0)
					{
						nint num57 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v839 @ S0_v205 (Il2CppClass<UICamera>)+BA]");
						object obj33 = (nint)0 & (nint)0x200;
						bool flag8 = obj33 == null;
						nint num58 = (nint)typeof(UICamera);
						if (!flag8)
						{
							nint num59 = (nint)typeof(UICamera);
							num58 = (nint)typeof(UICamera);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v844 @ S0_v218 (Il2CppClass<UICamera>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								num58 = (nint)typeof(UICamera);
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v846 @ L0_v33 (Il2CppClass<UICamera>)+5C]");
						object obj34 = (nint)0 + (nint)136;
						obj34 = num53;
						bool flag9 = IsPartOfUI((GameObject)num53);
						nint num60 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v860 @ S0_v215 (Il2CppClass<UICamera>)+5C]");
						object obj35 = (nint)0 + (nint)140;
						obj35 = flag9;
					}
				}
				nint num61 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v617 @ S0_v147 (Il2CppClass<UICamera>)+BA]");
				object obj36 = (nint)0 & (nint)0x200;
				if (obj36 != null)
				{
					nint num62 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v649 @ S0_v181 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (onHover != null)
				{
					nint num63 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v683 @ S0_v169 (Il2CppClass<UICamera>)+BA]");
					object obj37 = (nint)0 & (nint)0x200;
					if (obj37 != null)
					{
						nint num64 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v735 @ S0_v176 (Il2CppClass<UICamera>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A74");
				}
				nint num65 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v701 @ S0_v156 (Il2CppClass<UICamera>)+BA]");
				object obj38 = (nint)0 & (nint)0x200;
				if (obj38 != null)
				{
					nint num66 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v745 @ S0_v163 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj11 = 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				bool released3 = default;
				((UICamera)(object)mHover).ProcessTouch((byte)(int)"OnHover" != 0, released3);
			}
			if (obj4 == null)
			{
				return;
			}
			nint num67 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v506 @ S0_v76 (Il2CppClass<UICamera>)+BA]");
			object obj39 = (nint)0 & (nint)0x200;
			bool flag10 = obj39 == null;
			nint num68 = (nint)typeof(UICamera);
			if (!flag10)
			{
				nint num69 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v524 @ S0_v117 (Il2CppClass<UICamera>)+74]");
				bool flag11 = (nint)0 == 0;
				bool flag12 = !flag11;
				num68 = (nint)typeof(UICamera);
				if (!flag12)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num68 = (nint)typeof(UICamera);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v528 @ L0_v5 (Il2CppClass<UICamera>)+5C]");
			object obj40 = (nint)0 + (nint)136;
			obj40 = current;
			nint num70 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ S0_v84 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj41 = (nint)0 & (nint)0x200;
			if (obj41 != null)
			{
				nint num71 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v549 @ S0_v114 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag13 = ((ComputeShader)(object)current).FindKernel((string)null) != 0 && IsPartOfUI((GameObject)(object)current);
			nint num72 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v662 @ S0_v92 (Il2CppClass<UICamera>)+BA]");
			object obj42 = (nint)0 & (nint)0x200;
			bool flag14 = obj42 == null;
			nint num73 = (nint)typeof(UICamera);
			if (!flag14)
			{
				nint num74 = (nint)typeof(UICamera);
				num73 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v706 @ S0_v106 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num73 = (nint)typeof(UICamera);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ L0_v8 (Il2CppClass<UICamera>)+5C]");
			object obj43 = (nint)0 + (nint)140;
			obj43 = flag13;
			nint num75 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v717 @ S0_v100 (Il2CppClass<UICamera>)+5C]");
			object obj44 = (nint)0 + (nint)160;
			obj44 = 0;
			currentTouchID = -100;
		}
	}

	public static GameObject selectedObject
	{
		get
		{
			//IL_093f: Expected I, but got Obj
			//IL_0955: Expected Obj, but got I
			//IL_0d9d: Expected I, but got Obj
			//IL_0db3: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_01c9: Expected I, but got Obj
			//IL_01df: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_00ad: Expected I, but got Obj
			//IL_00c3: Expected Obj, but got I
			//IL_0e6d: Expected I, but got Obj
			//IL_0e83: Expected Obj, but got I
			//IL_020a: Expected I, but got Obj
			//IL_0dda: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ddf: Expected Obj, but got Unknown
			//IL_0de8: Expected Obj, but got I4
			//IL_0257: Expected I, but got Obj
			//IL_026d: Expected Obj, but got I
			//IL_00ee: Expected I, but got Obj
			//IL_08f2: Expected I, but got Obj
			//IL_0a04: Expected I, but got Obj
			//IL_0a1a: Expected Obj, but got I
			//IL_013b: Expected I, but got Obj
			//IL_0151: Expected Obj, but got I
			//IL_0298: Expected I, but got Obj
			//IL_02e5: Expected I, but got Obj
			//IL_017c: Expected I, but got Obj
			//IL_0332: Expected I, but got Obj
			//IL_0348: Expected Obj, but got I
			//IL_0373: Expected I, but got Obj
			//IL_03c0: Expected I, but got Obj
			//IL_03d6: Expected Obj, but got I
			//IL_0401: Expected I, but got Obj
			//IL_044e: Expected I, but got Obj
			//IL_0464: Expected Obj, but got I
			//IL_048f: Expected I, but got Obj
			//IL_04d7: Expected Obj, but got I4
			//IL_0e2c: Expected I, but got Obj
			//IL_0e42: Expected Obj, but got I
			//IL_04ea: Expected I, but got Obj
			//IL_0685: Expected I, but got Obj
			//IL_069b: Expected Obj, but got I
			//IL_051d: Expected I, but got Obj
			//IL_0533: Expected Obj, but got I
			//IL_0be8: Expected I, but got Obj
			//IL_0bfe: Expected Obj, but got I
			//IL_0afc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b01: Expected Obj, but got Unknown
			//IL_0b32: Expected I, but got Obj
			//IL_0b48: Expected Obj, but got I
			//IL_06c6: Expected I, but got Obj
			//IL_055e: Expected I, but got Obj
			//IL_0713: Expected I, but got Obj
			//IL_0b94: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b99: Expected Obj, but got Unknown
			//IL_0591: Expected I, but got Obj
			//IL_0741: Expected Obj, but got I4
			//IL_0d24: Expected I, but got Obj
			//IL_0d3a: Expected Obj, but got I
			//IL_0754: Expected I, but got Obj
			//IL_0611: Expected I, but got Obj
			//IL_0627: Expected Obj, but got I
			//IL_0787: Expected I, but got Obj
			//IL_079d: Expected Obj, but got I
			//IL_0bb9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bbe: Expected Obj, but got Unknown
			//IL_0c87: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c8c: Expected Obj, but got Unknown
			//IL_0cbd: Expected I, but got Obj
			//IL_0cd3: Expected Obj, but got I
			//IL_0652: Expected I, but got Obj
			//IL_07c8: Expected I, but got Obj
			//IL_0851: Unknown result type (might be due to invalid IL or missing references)
			//IL_0856: Expected Obj, but got Unknown
			//IL_07fb: Expected I, but got Obj
			//IL_087e: Expected I, but got Obj
			//IL_0894: Expected Obj, but got I
			//IL_0d6a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d6f: Expected Obj, but got Unknown
			//IL_08bf: Expected I, but got Obj
			nint num = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UICamera>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v287 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			MouseOrTouch mouseOrTouch = controller;
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v283 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)mouseOrTouch.current))
			{
				nint num5 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v252 (Il2CppClass<UICamera>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num6 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v277 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				MouseOrTouch mouseOrTouch2 = controller;
				string text = mouseOrTouch2.current.tag;
				if (text != null)
				{
					nint num7 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v263 (Il2CppClass<UICamera>)+BA]");
					object obj4 = (nint)0 & (nint)0x200;
					if (obj4 != null)
					{
						nint num8 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S0_v271 (Il2CppClass<UICamera>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					MouseOrTouch mouseOrTouch3 = controller;
					return mouseOrTouch3.current;
				}
			}
			nint num9 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v25 (Il2CppClass<UICamera>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num10 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v247 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			KeyCode keyCode = currentKey;
			if (keyCode == (KeyCode)2)
			{
				nint num11 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v50 (Il2CppClass<UICamera>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num12 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ S0_v241 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				nint num13 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S1_v15 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num14 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ S1_v94 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)(object)current).FindKernel((string)null) != 0)
				{
					nint num15 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ S0_v59 (Il2CppClass<UICamera>)+BA]");
					object obj8 = (nint)0 & (nint)0x200;
					if (obj8 != null)
					{
						nint num16 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ S0_v235 (Il2CppClass<UICamera>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					UICamera uICamera = current;
					if (~(uICamera.useController ? 1u : 0u) == 0)
					{
						nint num17 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ S0_v68 (Il2CppClass<UICamera>)+BA]");
						object obj9 = (nint)0 & (nint)0x200;
						if (obj9 != null)
						{
							nint num18 = (nint)typeof(UICamera);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ S0_v229 (Il2CppClass<UICamera>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						if (~(ignoreControllerInput ? 1u : 0u) != 0)
						{
							nint num19 = (nint)typeof(UIKeyNavigation);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ S0_v77 (Il2CppClass<UIKeyNavigation>)+BA]");
							object obj10 = (nint)0 & (nint)0x200;
							if (obj10 != null)
							{
								nint num20 = (nint)typeof(UIKeyNavigation);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ S0_v223 (Il2CppClass<UIKeyNavigation>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							BetterList<UIKeyNavigation> betterList = UIKeyNavigation.list;
							if (betterList.size >= 1)
							{
								object obj11 = 0;
								while (true)
								{
									nint num21 = (nint)typeof(UIKeyNavigation);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ S0_v89 (Il2CppClass<UIKeyNavigation>)+BA]");
									object obj12 = (nint)0 & (nint)0x200;
									if (obj12 != null)
									{
										nint num22 = (nint)typeof(UIKeyNavigation);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ S0_v218 (Il2CppClass<UIKeyNavigation>)+74]");
										if ((nint)0 == 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
										}
									}
									BetterList<UIKeyNavigation> betterList2 = UIKeyNavigation.list;
									if ((nint)obj11 >= betterList2.size)
									{
										break;
									}
									nint num23 = (nint)typeof(UIKeyNavigation);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ S0_v171 (Il2CppClass<UIKeyNavigation>)+BA]");
									object obj13 = (nint)0 & (nint)0x200;
									if (obj13 != null)
									{
										nint num24 = (nint)typeof(UIKeyNavigation);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ S0_v213 (Il2CppClass<UIKeyNavigation>)+74]");
										if ((nint)0 == 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
										}
									}
									BetterList<UIKeyNavigation> betterList3 = UIKeyNavigation.list;
									object obj14 = betterList3.buffer + 16;
									object obj15 = obj11 << 2;
									object obj16 = obj14 + obj15;
									UnityEngine.Object obj17 = (UnityEngine.Object)obj16;
									nint num25 = (nint)typeof(UnityEngine.Object);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ S0_v185 (Il2CppClass<UnityEngine.Object>)+BA]");
									object obj18 = (nint)0 & (nint)0x200;
									if (obj18 != null)
									{
										nint num26 = (nint)typeof(UnityEngine.Object);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ S0_v210 (Il2CppClass<UnityEngine.Object>)+74]");
										if ((nint)0 == 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
										}
									}
									if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)obj16))
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ S0_v183 (UnityEngine.Object)+C]");
										if ((nint)0 != 3)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ S0_v183 (UnityEngine.Object)+28]");
											if ((nint)0 != 0)
											{
												string text2 = ((Component)obj16).tag;
												nint num27 = (nint)typeof(UICamera);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ S1_v81 (Il2CppClass<UICamera>)+BA]");
												object obj19 = (nint)0 & (nint)0x200;
												if (obj19 != null)
												{
													nint num28 = (nint)typeof(UICamera);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v447 @ S1_v91 (Il2CppClass<UICamera>)+74]");
													if ((nint)0 == 0)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
													}
												}
												controllerNavigationObject = (GameObject)(object)text2;
												object obj20 = controller + 52;
												obj20 = mHover;
												return mHover;
											}
										}
									}
									object obj21 = obj11 + 1;
									obj11 = obj21;
								}
								nint num29 = (nint)typeof(UICamera);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ S0_v96 (Il2CppClass<UICamera>)+BA]");
								object obj22 = (nint)0 & (nint)0x200;
								if (obj22 != null)
								{
									nint num30 = (nint)typeof(UICamera);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ S0_v164 (Il2CppClass<UICamera>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								nint num31 = (nint)typeof(UnityEngine.Object);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ S1_v32 (Il2CppClass<UnityEngine.Object>)+BA]");
								object obj23 = (nint)0 & (nint)0x200;
								if (obj23 != null)
								{
									nint num32 = (nint)typeof(UnityEngine.Object);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ S1_v67 (Il2CppClass<UnityEngine.Object>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								if (mHover != null)
								{
									object obj24 = 0;
									while (true)
									{
										nint num33 = (nint)typeof(UIKeyNavigation);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ S0_v107 (Il2CppClass<UIKeyNavigation>)+BA]");
										object obj25 = (nint)0 & (nint)0x200;
										if (obj25 != null)
										{
											nint num34 = (nint)typeof(UIKeyNavigation);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ S0_v159 (Il2CppClass<UIKeyNavigation>)+74]");
											if ((nint)0 == 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
											}
										}
										BetterList<UIKeyNavigation> betterList4 = UIKeyNavigation.list;
										if ((nint)obj24 >= betterList4.size)
										{
											break;
										}
										nint num35 = (nint)typeof(UIKeyNavigation);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v454 @ S0_v114 (Il2CppClass<UIKeyNavigation>)+BA]");
										object obj26 = (nint)0 & (nint)0x200;
										if (obj26 != null)
										{
											nint num36 = (nint)typeof(UIKeyNavigation);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ S0_v154 (Il2CppClass<UIKeyNavigation>)+74]");
											if ((nint)0 == 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
											}
										}
										BetterList<UIKeyNavigation> betterList5 = UIKeyNavigation.list;
										object obj27 = betterList5.buffer + 16;
										object obj28 = obj24 << 2;
										object obj29 = obj27 + obj28;
										UnityEngine.Object obj30 = (UnityEngine.Object)obj29;
										nint num37 = (nint)typeof(UnityEngine.Object);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ S0_v128 (Il2CppClass<UnityEngine.Object>)+BA]");
										object obj31 = (nint)0 & (nint)0x200;
										if (obj31 != null)
										{
											nint num38 = (nint)typeof(UnityEngine.Object);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ S0_v151 (Il2CppClass<UnityEngine.Object>)+74]");
											if ((nint)0 == 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
											}
										}
										if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)obj29))
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ S0_v126 (UnityEngine.Object)+C]");
											if ((nint)0 != 3)
											{
												string text3 = ((Component)obj29).tag;
												nint num39 = (nint)typeof(UICamera);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ S1_v54 (Il2CppClass<UICamera>)+BA]");
												object obj32 = (nint)0 & (nint)0x200;
												if (obj32 != null)
												{
													nint num40 = (nint)typeof(UICamera);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ S1_v64 (Il2CppClass<UICamera>)+74]");
													if ((nint)0 == 0)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
													}
												}
												controllerNavigationObject = (GameObject)(object)text3;
												object obj33 = controller + 52;
												obj33 = mHover;
												return mHover;
											}
										}
										object obj34 = obj24 + 1;
										obj24 = obj34;
									}
								}
							}
						}
					}
				}
			}
			nint num41 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S0_v34 (Il2CppClass<UICamera>)+BA]");
			object obj35 = (nint)0 & (nint)0x200;
			if (obj35 != null)
			{
				nint num42 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ S0_v43 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj36 = controller + 52;
			obj36 = 0;
			return null;
		}
		set
		{
			//IL_037f: Expected I, but got Obj
			//IL_0395: Expected Obj, but got I
			//IL_04da: Expected I, but got Obj
			//IL_04f0: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_03c0: Expected I, but got Obj
			//IL_03d6: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_00ad: Expected I, but got Obj
			//IL_00c3: Expected Obj, but got I
			//IL_0332: Expected I, but got Obj
			//IL_040a: Expected I, but got Obj
			//IL_0420: Expected Obj, but got I
			//IL_00ee: Expected I, but got Obj
			//IL_013b: Expected I, but got Obj
			//IL_0188: Expected I, but got Obj
			//IL_019e: Expected Obj, but got I
			//IL_044f: Expected Obj, but got I4
			//IL_0470: Expected I4, but got Obj
			//IL_02a4: Expected I, but got Obj
			//IL_02ba: Expected Obj, but got I
			//IL_01c9: Expected I, but got Obj
			//IL_04b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_04b5: Expected Obj, but got Unknown
			//IL_04be: Expected Obj, but got I4
			//IL_0216: Expected I, but got Obj
			//IL_022c: Expected Obj, but got I
			//IL_02e5: Expected I, but got Obj
			//IL_0257: Expected I, but got Obj
			nint num = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UICamera>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v95 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			MouseOrTouch mouseOrTouch = controller;
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v5 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S1_v41 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)mouseOrTouch.current).FindKernel((string)(object)value) != 0)
			{
				nint num5 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v31 (Il2CppClass<UICamera>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num6 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v89 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				MouseOrTouch mouseOrTouch2 = controller;
				nint num7 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S1_v15 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num8 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S1_v37 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)mouseOrTouch2.current))
				{
					nint num9 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S0_v41 (Il2CppClass<UICamera>)+BA]");
					object obj5 = (nint)0 & (nint)0x200;
					if (obj5 != null)
					{
						nint num10 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S0_v83 (Il2CppClass<UICamera>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					MouseOrTouch mouseOrTouch3 = controller;
					object obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
					bool released = default;
					((UICamera)(object)mouseOrTouch3.current).ProcessTouch((byte)(int)"OnHover" != 0, released);
					if (onHover != null)
					{
						nint num11 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ S0_v70 (Il2CppClass<UICamera>)+BA]");
						object obj7 = (nint)0 & (nint)0x200;
						if (obj7 != null)
						{
							nint num12 = (nint)typeof(UICamera);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ S0_v77 (Il2CppClass<UICamera>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						MouseOrTouch mouseOrTouch4 = controller;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A74");
					}
					nint num13 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S0_v55 (Il2CppClass<UICamera>)+BA]");
					object obj8 = (nint)0 & (nint)0x200;
					if (obj8 != null)
					{
						nint num14 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ S0_v63 (Il2CppClass<UICamera>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					object obj9 = controller + 52;
					obj9 = 0;
				}
			}
			nint num15 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v20 (Il2CppClass<UICamera>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num16 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v26 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			controllerNavigationObject = value;
		}
	}

	public static int touchCount
	{
		get
		{
			//IL_0281: Expected I, but got Obj
			//IL_0297: Expected Obj, but got I
			//IL_0328: Expected I, but got Obj
			//IL_033e: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_01c9: Expected I, but got Obj
			//IL_01df: Expected Obj, but got I
			//IL_01fc: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_0303: Expected Obj, but got I
			//IL_030c: Expected Obj, but got I4
			//IL_00ad: Expected I, but got Obj
			//IL_00c3: Expected Obj, but got I
			//IL_0218: Expected I, but got Obj
			//IL_0248: Expected I, but got Obj
			//IL_00ee: Expected I, but got Obj
			//IL_026e: Expected I, but got Obj
			//IL_013b: Expected I, but got Obj
			//IL_0151: Expected Obj, but got I
			//IL_02e8: Expected I4, but got Obj
			//IL_017c: Expected I, but got Obj
			nint num = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UICamera>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v72 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v14 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v68 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)mSelected))
			{
				nint num5 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v39 (Il2CppClass<UICamera>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num6 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v62 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string text = mSelected.tag;
				if (text != null)
				{
					nint num7 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v49 (Il2CppClass<UICamera>)+BA]");
					object obj4 = (nint)0 & (nint)0x200;
					if (obj4 != null)
					{
						nint num8 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v56 (Il2CppClass<UICamera>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					return (int)mSelected;
				}
			}
			nint num9 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v24 (Il2CppClass<UICamera>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			bool flag = obj5 == null;
			nint num10 = (nint)typeof(UICamera);
			if (!flag)
			{
				nint num11 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v32 (Il2CppClass<UICamera>)+74]");
				bool flag2 = (nint)0 == 0;
				bool flag3 = !flag2;
				num10 = (nint)typeof(UICamera);
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num10 = (nint)typeof(UICamera);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ L0_v7 (Il2CppClass<UICamera>)+5C]");
			object obj6 = (nint)0 + (nint)312;
			obj6 = 0;
			return 0;
		}
	}

	public static int dragCount
	{
		get
		{
			//IL_034d: Expected I, but got Obj
			//IL_0363: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0151: Expected Obj, but got I4
			//IL_05df: Expected I, but got Obj
			//IL_05f5: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_043d: Expected I, but got Obj
			//IL_0453: Expected Obj, but got I
			//IL_03a0: Expected I, but got Obj
			//IL_03b6: Expected Obj, but got I
			//IL_0164: Expected I, but got Obj
			//IL_00a1: Expected I, but got Obj
			//IL_0523: Expected I, but got Obj
			//IL_0539: Expected Obj, but got I
			//IL_00ee: Expected I, but got Obj
			//IL_0298: Expected I, but got Obj
			//IL_0488: Unknown result type (might be due to invalid IL or missing references)
			//IL_048d: Expected Obj, but got Unknown
			//IL_04be: Expected I, but got Obj
			//IL_04d4: Expected Obj, but got I
			//IL_02e5: Expected I, but got Obj
			//IL_05b0: Expected Obj, but got I
			//IL_01ca: Expected I, but got Obj
			//IL_04fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ff: Expected Obj, but got Unknown
			//IL_0217: Expected I, but got Obj
			nint num = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UICamera>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v96 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			List<MouseOrTouch> list = activeTouches;
			int num3 = 0;
			int num4 = default;
			int num10 = default;
			while (num4 < list._size)
			{
				nint num5 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v75 (Il2CppClass<UICamera>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num6 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v90 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				MouseOrTouch mouseOrTouch = activeTouches.get_Item(num4);
				nint num7 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S1_v47 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num8 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S1_v55 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)(object)mouseOrTouch.pressed).FindKernel((string)null) != 0)
				{
					int num9 = num3 + 1;
					num3 = num9;
				}
				num4 = num10 + 1;
			}
			object obj4 = 0;
			bool flag2;
			while (true)
			{
				nint num11 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v23 (Il2CppClass<UICamera>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num12 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v68 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				MouseOrTouch[] array = mMouse;
				bool flag = (nint)obj4 < array.Length;
				nint num13 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S1_v12 (Il2CppClass<UICamera>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				flag2 = obj6 != null;
				if (!flag)
				{
					break;
				}
				if (flag2)
				{
					nint num14 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S0_v62 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj7 = mMouse + 16;
				object obj8 = obj4 << 2;
				object obj9 = obj7 + obj8;
				object obj10 = obj9;
				nint num15 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S1_v32 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj11 = (nint)0 & (nint)0x200;
				if (obj11 != null)
				{
					nint num16 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ S1_v40 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S0_v54+38]");
				if (((ComputeShader)0).FindKernel(null) != 0)
				{
					int num17 = num3 + 1;
					num3 = num17;
				}
				object obj12 = obj4 + 1;
				obj4 = obj12;
			}
			if (flag2)
			{
				nint num18 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S0_v41 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			MouseOrTouch mouseOrTouch2 = controller;
			nint num19 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ S1_v17 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj13 = (nint)0 & (nint)0x200;
			if (obj13 != null)
			{
				nint num20 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ S1_v24 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)mouseOrTouch2.pressed).FindKernel((string)null) != 0)
			{
				int num21 = num3 + 1;
				num3 = num21;
			}
			return num3;
		}
	}

	public static Camera mainCamera
	{
		get
		{
			//IL_034d: Expected I, but got Obj
			//IL_0363: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0151: Expected Obj, but got I4
			//IL_05db: Expected I, but got Obj
			//IL_05f1: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_043d: Expected I, but got Obj
			//IL_0453: Expected Obj, but got I
			//IL_03a0: Expected I, but got Obj
			//IL_03b6: Expected Obj, but got I
			//IL_0164: Expected I, but got Obj
			//IL_00a1: Expected I, but got Obj
			//IL_0523: Expected I, but got Obj
			//IL_0539: Expected Obj, but got I
			//IL_00ee: Expected I, but got Obj
			//IL_0298: Expected I, but got Obj
			//IL_0488: Unknown result type (might be due to invalid IL or missing references)
			//IL_048d: Expected Obj, but got Unknown
			//IL_04be: Expected I, but got Obj
			//IL_04d4: Expected Obj, but got I
			//IL_0136: Unknown result type (might be due to invalid IL or missing references)
			//IL_013b: Expected Obj, but got Unknown
			//IL_02e5: Expected I, but got Obj
			//IL_05ac: Expected Obj, but got I
			//IL_01ca: Expected I, but got Obj
			//IL_032d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0332: Expected Obj, but got Unknown
			//IL_04fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ff: Expected Obj, but got Unknown
			//IL_0217: Expected I, but got Obj
			//IL_025f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0264: Expected Obj, but got Unknown
			nint num = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UICamera>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v96 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			List<MouseOrTouch> list = activeTouches;
			Camera camera = null;
			int num3 = default;
			int num8 = default;
			while (num3 < list._size)
			{
				nint num4 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v75 (Il2CppClass<UICamera>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num5 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v90 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				MouseOrTouch mouseOrTouch = activeTouches.get_Item(num3);
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S1_v47 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num7 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S1_v55 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)(object)mouseOrTouch.dragged).FindKernel((string)null) != 0)
				{
					Camera camera2 = (Camera)(camera + 1);
					camera = camera2;
				}
				num3 = num8 + 1;
			}
			object obj4 = 0;
			bool flag2;
			while (true)
			{
				nint num9 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v23 (Il2CppClass<UICamera>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num10 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v68 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				MouseOrTouch[] array = mMouse;
				bool flag = (nint)obj4 < array.Length;
				nint num11 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S1_v12 (Il2CppClass<UICamera>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				flag2 = obj6 != null;
				if (!flag)
				{
					break;
				}
				if (flag2)
				{
					nint num12 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S0_v62 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj7 = mMouse + 16;
				object obj8 = obj4 << 2;
				object obj9 = obj7 + obj8;
				object obj10 = obj9;
				nint num13 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S1_v32 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj11 = (nint)0 & (nint)0x200;
				if (obj11 != null)
				{
					nint num14 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ S1_v40 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S0_v54+3C]");
				if (((ComputeShader)0).FindKernel(null) != 0)
				{
					Camera camera3 = (Camera)(camera + 1);
					camera = camera3;
				}
				object obj12 = obj4 + 1;
				obj4 = obj12;
			}
			if (flag2)
			{
				nint num15 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S0_v41 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			MouseOrTouch mouseOrTouch2 = controller;
			nint num16 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ S1_v17 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj13 = (nint)0 & (nint)0x200;
			if (obj13 != null)
			{
				nint num17 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ S1_v24 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)mouseOrTouch2.dragged).FindKernel((string)null) != 0)
			{
				Camera camera4 = (Camera)(camera + 1);
				camera = camera4;
			}
			return camera;
		}
	}

	public static UICamera eventHandler
	{
		get
		{
			//IL_00d1: Expected I, but got Obj
			//IL_00e7: Expected Obj, but got I
			//IL_014b: Expected I, but got Obj
			//IL_0161: Expected Obj, but got I
			//IL_010e: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_00a8: Expected Obj, but got I4
			//IL_00b4: Expected Obj, but got I4
			nint num = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UICamera>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v27 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = HideTooltip();
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v13 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v23 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)flag).FindKernel(null) != 0)
			{
				bool flag2 = IsPartOfUI((GameObject)flag);
				return (UICamera)flag2;
			}
			return null;
		}
	}

	public static bool IsPartOfUI(GameObject go)
	{
		//IL_0088: Expected I, but got Obj
		//IL_009e: Expected Obj, but got I
		//IL_00da: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [go @ L0 (UnityEngine.GameObject)+6C]");
		if ((UnityEngine.Object)0 != null)
		{
			object obj2 = go + 108;
			Camera component = ((Component)(object)go).GetComponent<Camera>();
			obj2 = component;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [go @ L0 (UnityEngine.GameObject)+6C]");
		return false;
	}

	public static bool IsPressed(GameObject go)
	{
		//IL_0232: Expected I, but got Obj
		//IL_0248: Expected Obj, but got I
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0278: Expected I, but got Obj
		//IL_028e: Expected Obj, but got I
		//IL_00af: Expected I, but got Obj
		//IL_0157: Expected I, but got Obj
		//IL_016d: Expected Obj, but got I
		//IL_00fc: Expected I, but got Obj
		//IL_02c6: Expected I, but got Obj
		//IL_02dc: Expected Obj, but got I
		//IL_0198: Expected I, but got Obj
		//IL_01e5: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v52 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (go != null)
		{
			return false;
		}
		nint num3 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v14 (Il2CppClass<UICamera>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v45 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v22 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v41 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (go != fallThrough)
		{
			return false;
		}
		nint num7 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v29 (Il2CppClass<NGUITools>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num8 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v36 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIRoot uIRoot = NGUITools.FindInParents<UIRoot>(go);
		nint num9 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num10 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S1_v17 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (byte)((ComputeShader)(object)uIRoot).FindKernel((string)null) != 0;
	}

	public static int CountInputSources()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UICamera>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return dragCount;
	}

	private static int CompareFunc(UICamera a, UICamera b)
	{
		//IL_01fc: Expected I, but got Obj
		//IL_0212: Expected Obj, but got I
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_010a: Expected I, but got Obj
		//IL_0120: Expected Obj, but got I
		//IL_00af: Expected I, but got Obj
		//IL_014b: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v43 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (a != null)
		{
			return 0;
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v14 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v38 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (b != null)
		{
			return 0;
		}
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v21 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v33 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (a != b)
		{
			return 1;
		}
		if (UIAtlas.CheckIfRelated((UIAtlas)(object)a, (UIAtlas)(object)b))
		{
			return 1;
		}
		return UIAtlas.CheckIfRelated((UIAtlas)(object)b, (UIAtlas)(object)a) ? 1 : 0;
	}

	private static Rigidbody FindRootRigidbody(Transform trans)
	{
		//IL_0354: Expected I, but got Obj
		//IL_036a: Expected Obj, but got I
		//IL_0432: Expected I, but got Obj
		//IL_0448: Expected Obj, but got I
		//IL_010d: Expected I, but got Obj
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Expected Obj, but got Unknown
		//IL_0313: Expected I, but got Obj
		//IL_0329: Expected Obj, but got I
		//IL_04dd: Expected Obj, but got I
		//IL_0037: Expected I, but got Obj
		//IL_0495: Expected I, but got Obj
		//IL_04ab: Expected Obj, but got I
		//IL_0084: Expected I, but got Obj
		//IL_051b: Expected Obj, but got I4
		//IL_0241: Expected I, but got Obj
		//IL_03cd: Expected I, but got Obj
		//IL_03e3: Expected Obj, but got I
		//IL_02d3: Expected Obj, but got I4
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected Obj, but got Unknown
		//IL_028e: Expected I, but got Obj
		//IL_0173: Expected I, but got Obj
		//IL_01c0: Expected I, but got Obj
		object obj2 = default;
		object obj8 = default;
		while (true)
		{
			nint num = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v6 (Il2CppClass<UICamera>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			bool flag = obj == null;
			if ((nint)obj2 <= 2)
			{
				if (!flag)
				{
					nint num2 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v81 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj3 = mMouse + 16;
				object obj4 = obj2 << 2;
				object obj5 = obj3 + obj4;
				object obj6 = obj5;
				nint num3 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S1_v35 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num4 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S1_v41 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v75+38]");
				if (!((UnityEngine.Object)0 != trans))
				{
					obj2 = obj8 + 1;
					continue;
				}
				break;
			}
			if (!flag)
			{
				nint num5 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v61 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			List<MouseOrTouch> list = activeTouches;
			int num6 = 0;
			while (true)
			{
				nint num7 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S0_v26 (Il2CppClass<UICamera>)+BA]");
				object obj9 = (nint)0 & (nint)0x200;
				bool flag2 = obj9 != null;
				if (num6 < list._size)
				{
					if (flag2)
					{
						nint num8 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S0_v55 (Il2CppClass<UICamera>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					MouseOrTouch mouseOrTouch = activeTouches.get_Item(num6);
					nint num9 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ S1_v21 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj10 = (nint)0 & (nint)0x200;
					if (obj10 != null)
					{
						nint num10 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ S1_v27 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (mouseOrTouch.pressed == trans)
					{
						int num11 = num6 + 1;
						num6 = num11;
						continue;
					}
					break;
				}
				if (flag2)
				{
					nint num12 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S0_v39 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				MouseOrTouch mouseOrTouch2 = controller;
				nint num13 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj11 = (nint)0 & (nint)0x200;
				if (obj11 != null)
				{
					nint num14 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ S1_v15 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				return (Rigidbody)(mouseOrTouch2.pressed != trans);
			}
			break;
		}
		return (Rigidbody)1;
	}

	private static Rigidbody2D FindRootRigidbody2D(Transform trans)
	{
		//IL_0206: Expected I, but got Obj
		//IL_021c: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_006d: Expected I, but got Obj
		//IL_0083: Expected Obj, but got I
		//IL_00ae: Expected I, but got Obj
		//IL_0108: Expected I, but got Obj
		//IL_011e: Expected Obj, but got I
		//IL_0149: Expected I, but got Obj
		Transform parentInternal = default;
		Rigidbody2D result;
		Transform transform = default;
		while (true)
		{
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v40 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int num3 = ((ComputeShader)(object)parentInternal).FindKernel((string)null);
			bool flag = num3 == 0;
			result = null;
			if (flag)
			{
				break;
			}
			UIPanel component = parentInternal.GetComponent<UIPanel>();
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v15 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num5 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v36 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int num6 = ((ComputeShader)(object)component).FindKernel((string)null);
			result = null;
			if (num6 != 0)
			{
				break;
			}
			Rigidbody component2 = parentInternal.GetComponent<Rigidbody>();
			nint num7 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v23 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num8 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v32 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)component2).FindKernel((string)null) != 0)
			{
				result = (Rigidbody2D)(object)component2;
				break;
			}
			parentInternal = transform.parentInternal;
		}
		return result;
	}

	public static void Raycast(MouseOrTouch touch)
	{
		//IL_0cd6: Expected I, but got Obj
		//IL_0cec: Expected Obj, but got I
		//IL_138b: Expected I, but got Obj
		//IL_13a1: Expected Obj, but got I
		//IL_1521: Expected I, but got Obj
		//IL_1537: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_019d: Expected I, but got Obj
		//IL_01b3: Expected Obj, but got I
		//IL_0142: Expected I, but got Obj
		//IL_0d1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d21: Expected Obj, but got Unknown
		//IL_0db0: Expected I, but got Obj
		//IL_0dc6: Expected Obj, but got I
		//IL_0dd8: Expected Obj, but got I4
		//IL_018a: Expected Obj, but got I4
		//IL_00d1: Expected I, but got Obj
		//IL_0d65: Expected I, but got Obj
		//IL_0d7b: Expected Obj, but got I
		//IL_01de: Expected I, but got Obj
		//IL_13d6: Expected I, but got Obj
		//IL_13ec: Expected Obj, but got I
		//IL_022b: Expected I, but got Obj
		//IL_0deb: Expected I, but got Obj
		//IL_0e01: Expected Obj, but got I
		//IL_0e1e: Expected I, but got Obj
		//IL_0278: Expected I, but got Obj
		//IL_141f: Expected Obj, but got I
		//IL_144c: Expected I, but got Obj
		//IL_1462: Expected Obj, but got I
		//IL_02c5: Expected I, but got Obj
		//IL_02db: Expected Obj, but got I
		//IL_03e1: Expected I, but got Obj
		//IL_0411: Expected I, but got Obj
		//IL_0e35: Expected Obj, but got I4
		//IL_0e52: Expected I4, but got Obj
		//IL_0e8d: Expected I, but got Obj
		//IL_0ea3: Expected Obj, but got I
		//IL_044a: Expected I, but got Obj
		//IL_0306: Expected I, but got Obj
		//IL_148d: Expected I, but got Obj
		//IL_14a3: Expected Obj, but got I
		//IL_04a4: Expected I, but got Obj
		//IL_04ba: Expected Obj, but got I
		//IL_0437: Expected I, but got Obj
		//IL_0353: Expected I, but got Obj
		//IL_0369: Expected Obj, but got I
		//IL_15c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_15cc: Expected Obj, but got Unknown
		//IL_05c0: Expected I, but got Obj
		//IL_106a: Expected I, but got Obj
		//IL_1080: Expected Obj, but got I
		//IL_060d: Expected I, but got Obj
		//IL_04e5: Expected I, but got Obj
		//IL_0394: Expected I, but got Obj
		//IL_14ce: Expected I, but got Obj
		//IL_14e4: Expected Obj, but got I
		//IL_065a: Expected I, but got Obj
		//IL_0670: Expected Obj, but got I
		//IL_0532: Expected I, but got Obj
		//IL_0548: Expected Obj, but got I
		//IL_089a: Expected I, but got Obj
		//IL_0f15: Expected I, but got Obj
		//IL_0f2b: Expected Obj, but got I
		//IL_0ef5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0efa: Expected Obj, but got Unknown
		//IL_08e7: Expected I, but got Obj
		//IL_0f65: Expected I, but got Obj
		//IL_0f7b: Expected Obj, but got I
		//IL_069b: Expected I, but got Obj
		//IL_0573: Expected I, but got Obj
		//IL_0934: Expected I, but got Obj
		//IL_094a: Expected Obj, but got I
		//IL_06e8: Expected I, but got Obj
		//IL_0b95: Expected I, but got Obj
		//IL_0bab: Expected Obj, but got I
		//IL_0bc8: Expected I, but got Obj
		//IL_101f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1024: Expected Obj, but got Unknown
		//IL_102c: Expected I4, but got Obj
		//IL_125e: Expected Obj, but got I
		//IL_1275: Expected I, but got Obj
		//IL_128b: Expected Obj, but got I
		//IL_0975: Expected I, but got Obj
		//IL_0fd5: Expected I, but got Obj
		//IL_0feb: Expected Obj, but got I
		//IL_0796: Expected I, but got Obj
		//IL_0fbe: Expected Obj, but got I4
		//IL_0be4: Expected I, but got Obj
		//IL_0bf2: Expected I, but got Obj
		//IL_11a2: Expected I, but got Obj
		//IL_11b8: Expected Obj, but got I
		//IL_09a8: Expected I, but got Obj
		//IL_09be: Expected Obj, but got I
		//IL_103b: Expected Obj, but got I4
		//IL_073f: Expected I, but got Obj
		//IL_0c33: Expected I, but got Obj
		//IL_1140: Expected I, but got Obj
		//IL_1156: Expected Obj, but got I
		//IL_07c9: Expected I, but got Obj
		//IL_12e2: Expected I, but got Obj
		//IL_12f8: Expected Obj, but got I
		//IL_1315: Expected I, but got Obj
		//IL_0c20: Expected I, but got Obj
		//IL_0b04: Expected I, but got Obj
		//IL_0b1a: Expected Obj, but got I
		//IL_0a5d: Expected I, but got Obj
		//IL_09e9: Expected I, but got Obj
		//IL_07fc: Expected I, but got Obj
		//IL_0812: Expected Obj, but got I
		//IL_082f: Expected I, but got Obj
		//IL_1339: Expected Obj, but got I
		//IL_1341: Expected Obj, but got I4
		//IL_134f: Expected I, but got Obj
		//IL_1365: Expected Obj, but got I
		//IL_136e: Expected Obj, but got I4
		//IL_1226: Expected Obj, but got I4
		//IL_1243: Expected I4, but got Obj
		//IL_0a90: Expected I, but got Obj
		//IL_0aa6: Expected Obj, but got I
		//IL_0a1c: Expected I, but got Obj
		//IL_10b3: Expected Obj, but got I
		//IL_10bb: Expected Obj, but got I4
		//IL_10c4: Expected Obj, but got I4
		//IL_10d6: Expected I, but got Obj
		//IL_10ec: Expected Obj, but got I
		//IL_10f4: Expected Obj, but got I4
		//IL_0c87: Expected I, but got Obj
		//IL_0c95: Expected I, but got Obj
		//IL_0b45: Expected I, but got Obj
		//IL_084b: Expected I, but got Obj
		//IL_0859: Expected I, but got Obj
		//IL_0ad1: Expected I, but got Obj
		//IL_0cc3: Expected I, but got Obj
		//IL_0887: Expected I, but got Obj
		nint num = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UICamera>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v408 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v5 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S1_v164 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = mSelected != (UnityEngine.Object)(object)touch;
		nint num5 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S1_v11 (Il2CppClass<UICamera>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		bool flag2 = obj3 == null;
		if (flag)
		{
			if (!flag2)
			{
				nint num6 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v404 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			controllerNavigationObject = (GameObject)(object)touch;
			object obj4 = controller + 52;
			obj4 = touch;
			return;
		}
		if (!flag2)
		{
			nint num7 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v391 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		BMFont bmFont = ((UIFont)null).bmFont;
		object obj5;
		if (currentTouch != null)
		{
			obj5 = 0;
		}
		else
		{
			nint num8 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S0_v373 (Il2CppClass<UICamera>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num9 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ S0_v384 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			currentTouchID = -100;
			nint num10 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S0_v380 (Il2CppClass<UICamera>)+5C]");
			object obj7 = (nint)0 + (nint)160;
			obj7 = controller;
			obj5 = 1;
		}
		nint num11 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S0_v34 (Il2CppClass<UICamera>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num12 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S0_v366 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		mInputFocus = false;
		nint num13 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ S1_v21 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num14 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ S1_v150 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)mSelected))
		{
			nint num15 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ S0_v335 (Il2CppClass<UICamera>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num16 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ S0_v360 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			bool released = default;
			((UICamera)(object)mSelected).ProcessTouch((byte)(int)"OnSelect" != 0, released);
			if (onSelect != null)
			{
				nint num17 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ S0_v347 (Il2CppClass<UICamera>)+BA]");
				object obj12 = (nint)0 & (nint)0x200;
				if (obj12 != null)
				{
					nint num18 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ S0_v354 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A74");
			}
		}
		nint num19 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ S0_v47 (Il2CppClass<UICamera>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		bool flag3 = obj13 == null;
		nint num20 = (nint)typeof(UICamera);
		if (!flag3)
		{
			nint num21 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ S0_v328 (Il2CppClass<UICamera>)+74]");
			bool flag4 = (nint)0 == 0;
			bool flag5 = !flag4;
			num20 = (nint)typeof(UICamera);
			if (!flag5)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num20 = (nint)typeof(UICamera);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ L1_v12 (Il2CppClass<UICamera>)+5C]");
		object obj14 = (nint)0 + (nint)312;
		obj14 = touch;
		MouseOrTouch mouseOrTouch = currentTouch;
		mouseOrTouch.clickNotification = ClickNotification.None;
		nint num22 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ S0_v59 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj15 = (nint)0 & (nint)0x200;
		if (obj15 != null)
		{
			nint num23 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ S0_v324 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)touch).FindKernel((string)null) != 0)
		{
			UIKeyNavigation component = ((GameObject)(object)touch).GetComponent<UIKeyNavigation>();
			nint num24 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ S1_v126 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj16 = (nint)0 & (nint)0x200;
			if (obj16 != null)
			{
				nint num25 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ S1_v134 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)component).FindKernel((string)null) != 0)
			{
				nint num26 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ S0_v310 (Il2CppClass<UICamera>)+BA]");
				object obj17 = (nint)0 & (nint)0x200;
				if (obj17 != null)
				{
					nint num27 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ S0_v318 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj18 = controller + 52;
				obj18 = touch;
			}
		}
		nint num28 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ S0_v67 (Il2CppClass<UICamera>)+BA]");
		object obj19 = (nint)0 & (nint)0x200;
		if (obj19 != null)
		{
			nint num29 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ S0_v300 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num30 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ S0_v75 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj20 = (nint)0 & (nint)0x200;
		if (obj20 != null)
		{
			nint num31 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ S0_v296 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag6 = UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)mSelected);
		object obj21 = obj5 & flag6;
		if (obj21 != null)
		{
			nint num32 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ S0_v222 (Il2CppClass<UICamera>)+BA]");
			object obj22 = (nint)0 & (nint)0x200;
			if (obj22 != null)
			{
				nint num33 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ S0_v290 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num34 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ S1_v98 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj23 = (nint)0 & (nint)0x200;
			if (obj23 != null)
			{
				nint num35 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ S1_v120 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int num36 = ((ComputeShader)(object)mSelected).FindKernel((string)null);
			nint num37 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v513 @ S1_v104 (Il2CppClass<UICamera>)+BA]");
			object obj24 = (nint)0 & (nint)0x200;
			bool flag7 = obj24 == null;
			int num39;
			if (num36 != 0)
			{
				if (!flag7)
				{
					nint num38 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ S0_v285 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool activeSelf = mSelected.activeSelf;
				num39 = GetDirection((string)activeSelf);
			}
			else
			{
				if (!flag7)
				{
					nint num40 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ S0_v272 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				BetterList<UICamera> betterList = list;
				object obj25 = betterList.buffer + 16;
				num39 = (int)obj25;
			}
			nint num41 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v598 @ S0_v232 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj26 = (nint)0 & (nint)0x200;
			if (obj26 != null)
			{
				nint num42 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v624 @ S0_v258 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)num39).FindKernel(null) != 0)
			{
				nint num43 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v680 @ S0_v240 (Il2CppClass<UICamera>)+BA]");
				object obj27 = (nint)0 & (nint)0x200;
				bool flag8 = obj27 == null;
				nint num44 = (nint)typeof(UICamera);
				if (!flag8)
				{
					nint num45 = (nint)typeof(UICamera);
					num44 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v711 @ S0_v253 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num44 = (nint)typeof(UICamera);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v713 @ L0_v43 (Il2CppClass<UICamera>)+5C]");
				object obj28 = (nint)0 + (nint)136;
				obj28 = num39;
				bool flag9 = IsPartOfUI((GameObject)num39);
				nint num46 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v767 @ S0_v250 (Il2CppClass<UICamera>)+5C]");
				object obj29 = (nint)0 + (nint)140;
				obj29 = flag9;
			}
		}
		nint num47 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ S0_v83 (Il2CppClass<UICamera>)+BA]");
		object obj30 = (nint)0 & (nint)0x200;
		if (obj30 != null)
		{
			nint num48 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ S0_v215 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num49 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ S1_v41 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj31 = (nint)0 & (nint)0x200;
		if (obj31 != null)
		{
			nint num50 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ S1_v92 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)mSelected))
		{
			nint num51 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v530 @ S0_v141 (Il2CppClass<UICamera>)+BA]");
			object obj32 = (nint)0 & (nint)0x200;
			if (obj32 != null)
			{
				nint num52 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ S0_v210 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text = mSelected.tag;
			int num58;
			if (text != null)
			{
				nint num53 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v632 @ S0_v195 (Il2CppClass<UICamera>)+BA]");
				object obj33 = (nint)0 & (nint)0x200;
				if (obj33 != null)
				{
					nint num54 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v647 @ S0_v205 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				UIInput component2 = mSelected.GetComponent<UIInput>();
				nint num55 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v687 @ S1_v83 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj34 = (nint)0 & (nint)0x200;
				if (obj34 != null)
				{
					nint num56 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v726 @ S1_v89 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				int num57 = ((ComputeShader)(object)component2).FindKernel((string)null);
				num58 = num57 & 1;
			}
			else
			{
				num58 = 0;
			}
			nint num59 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v671 @ S0_v151 (Il2CppClass<UICamera>)+BA]");
			object obj35 = (nint)0 & (nint)0x200;
			if (obj35 != null)
			{
				nint num60 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v691 @ S0_v188 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag10 = num58 != 0;
			mInputFocus = flag10;
			if (onSelect != null)
			{
				nint num61 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v734 @ S0_v176 (Il2CppClass<UICamera>)+BA]");
				object obj36 = (nint)0 & (nint)0x200;
				if (obj36 != null)
				{
					nint num62 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v771 @ S0_v183 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A74");
			}
			nint num63 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v752 @ S0_v163 (Il2CppClass<UICamera>)+BA]");
			object obj37 = (nint)0 & (nint)0x200;
			if (obj37 != null)
			{
				nint num64 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v781 @ S0_v170 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj11 = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			bool released2 = default;
			((UICamera)(object)mSelected).ProcessTouch((byte)(int)"OnSelect" != 0, released2);
		}
		if (obj5 == null)
		{
			return;
		}
		nint num65 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v583 @ S0_v94 (Il2CppClass<UICamera>)+BA]");
		object obj38 = (nint)0 & (nint)0x200;
		bool flag11 = obj38 == null;
		nint num66 = (nint)typeof(UICamera);
		if (!flag11)
		{
			nint num67 = (nint)typeof(UICamera);
			num66 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v604 @ S0_v135 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num66 = (nint)typeof(UICamera);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v606 @ L0_v11 (Il2CppClass<UICamera>)+5C]");
		object obj39 = (nint)0 + (nint)136;
		obj39 = current;
		nint num68 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v616 @ S0_v102 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj40 = (nint)0 & (nint)0x200;
		if (obj40 != null)
		{
			nint num69 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ S0_v132 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag12 = ((ComputeShader)(object)current).FindKernel((string)null) != 0 && IsPartOfUI((GameObject)(object)current);
		nint num70 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v760 @ S0_v110 (Il2CppClass<UICamera>)+BA]");
		object obj41 = (nint)0 & (nint)0x200;
		bool flag13 = obj41 == null;
		nint num71 = (nint)typeof(UICamera);
		if (!flag13)
		{
			nint num72 = (nint)typeof(UICamera);
			num71 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v794 @ S0_v124 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num71 = (nint)typeof(UICamera);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ L0_v14 (Il2CppClass<UICamera>)+5C]");
		object obj42 = (nint)0 + (nint)140;
		obj42 = flag12;
		nint num73 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v805 @ S0_v118 (Il2CppClass<UICamera>)+5C]");
		object obj43 = (nint)0 + (nint)160;
		obj43 = 0;
		currentTouchID = -100;
	}

	public static bool Raycast(Vector3 inPos)
	{
		//IL_020a: Expected I, but got Obj
		//IL_0220: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_006d: Expected I, but got Obj
		//IL_0083: Expected Obj, but got I
		//IL_00ae: Expected I, but got Obj
		//IL_0108: Expected I, but got Obj
		//IL_011e: Expected Obj, but got I
		//IL_019e: Expected Obj, but got VT
		//IL_0149: Expected I, but got Obj
		//IL_0190: Expected I4, but got Obj
		Transform parentInternal = default;
		bool result;
		Vector3 vector = default;
		while (true)
		{
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v40 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int num3 = ((ComputeShader)(object)parentInternal).FindKernel((string)null);
			bool flag = num3 == 0;
			result = false;
			if (flag)
			{
				break;
			}
			UIPanel component = parentInternal.GetComponent<UIPanel>();
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v15 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num5 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v36 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int num6 = ((ComputeShader)(object)component).FindKernel((string)null);
			result = false;
			if (num6 != 0)
			{
				break;
			}
			Rigidbody2D component2 = parentInternal.GetComponent<Rigidbody2D>();
			nint num7 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v23 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num8 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v32 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)component2).FindKernel((string)null) != 0)
			{
				result = (byte)(int)component2 != 0;
				break;
			}
			parentInternal = ((Transform)vector).parentInternal;
		}
		return result;
	}

	private static bool IsVisible(Vector3 worldPoint, GameObject go)
	{
		//IL_0009: Expected Obj, but got VT
		//IL_0016: Expected Obj, but got I4
		//IL_0035: Expected Obj, but got I4
		//IL_007c: Expected Obj, but got VT
		//IL_0089: Expected Obj, but got I4
		//IL_00a8: Expected Obj, but got I4
		//IL_00cd: Expected Obj, but got I4
		//IL_00db: Expected I4, but got Obj
		bool flag = IsPartOfUI((GameObject)worldPoint);
		float aspect = ((Camera)flag).aspect;
		bool flag2 = IsPartOfUI(go);
		float aspect2 = ((Camera)flag2).aspect;
		if (aspect < aspect2)
		{
			return true;
		}
		bool flag3 = IsPartOfUI((GameObject)worldPoint);
		float aspect3 = ((Camera)flag3).aspect;
		bool flag4 = IsPartOfUI(go);
		float aspect4 = ((Camera)flag4).aspect;
		bool flag5 = aspect3 > aspect4;
		object obj = (flag5 ? 1u : 0u) << 31;
		return (byte)(obj >> 31) != 0;
	}

	private unsafe static bool IsVisible(ref DepthEntry de)
	{
		//IL_2a44: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a49: Expected VT, but got Unknown
		//IL_2a52: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a57: Expected Obj, but got Unknown
		//IL_2a60: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a65: Expected Obj, but got Unknown
		//IL_2a6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a73: Expected Obj, but got Unknown
		//IL_2a7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a81: Expected Obj, but got Unknown
		//IL_2a8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a8f: Expected Obj, but got Unknown
		//IL_2a98: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a9d: Expected Obj, but got Unknown
		//IL_2aa6: Unknown result type (might be due to invalid IL or missing references)
		//IL_2aab: Expected Obj, but got Unknown
		//IL_2ab4: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ab9: Expected Obj, but got Unknown
		//IL_2ac2: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ac7: Expected Obj, but got Unknown
		//IL_2ad0: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ad5: Expected Obj, but got Unknown
		//IL_2ade: Expected Obj, but got I4
		//IL_2aed: Unknown result type (might be due to invalid IL or missing references)
		//IL_2af2: Expected Obj, but got Unknown
		//IL_2afb: Expected Obj, but got I4
		//IL_2b10: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b15: Expected Obj, but got Unknown
		//IL_2b1e: Expected Obj, but got F4
		//IL_2b27: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b2c: Expected Obj, but got Unknown
		//IL_2b35: Expected Obj, but got I4
		//IL_48da: Expected I, but got Obj
		//IL_48f0: Expected Obj, but got I
		//IL_0065: Expected I, but got Obj
		//IL_007b: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_2b57: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b5c: Expected Obj, but got Unknown
		//IL_2f1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f1f: Expected Obj, but got Unknown
		//IL_00a6: Expected I, but got Obj
		//IL_0100: Expected I, but got Obj
		//IL_0116: Expected Obj, but got I
		//IL_0141: Expected I, but got Obj
		//IL_019b: Expected I, but got Obj
		//IL_01b1: Expected Obj, but got I
		//IL_01ce: Expected I, but got Obj
		//IL_2be5: Expected Obj, but got I
		//IL_2bed: Expected Obj, but got I4
		//IL_01ea: Expected I, but got Obj
		//IL_021a: Expected I, but got Obj
		//IL_0253: Expected I, but got Obj
		//IL_0269: Expected Obj, but got I
		//IL_2c35: Expected F4, but got VT
		//IL_2c30: Expected native int or pointer, but got VT
		//IL_2c4a: Expected F4, but got I
		//IL_2c45: Expected native int or pointer, but got VT
		//IL_2c7b: Expected F4, but got Obj
		//IL_2c76: Expected native int or pointer, but got VT
		//IL_2c8d: Expected F4, but got I
		//IL_2c88: Expected native int or pointer, but got VT
		//IL_2c9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ca0: Expected Obj, but got Unknown
		//IL_0240: Expected I, but got Obj
		//IL_0294: Expected I, but got Obj
		//IL_02e0: Expected F4, but got Obj
		//IL_02db: Expected native int or pointer, but got VT
		//IL_02f5: Expected F4, but got I
		//IL_02f0: Expected native int or pointer, but got VT
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Expected Obj, but got Unknown
		//IL_0349: Expected F4, but got Obj
		//IL_0344: Expected native int or pointer, but got VT
		//IL_035e: Expected F4, but got I
		//IL_0359: Expected native int or pointer, but got VT
		//IL_03ac: Expected F4, but got Obj
		//IL_03a7: Expected native int or pointer, but got VT
		//IL_03c1: Expected F4, but got I
		//IL_03bc: Expected native int or pointer, but got VT
		//IL_040f: Expected F4, but got Obj
		//IL_040a: Expected native int or pointer, but got VT
		//IL_0424: Expected F4, but got I
		//IL_041f: Expected native int or pointer, but got VT
		//IL_0472: Expected F4, but got Obj
		//IL_046d: Expected native int or pointer, but got VT
		//IL_0487: Expected F4, but got I
		//IL_0482: Expected native int or pointer, but got VT
		//IL_04d6: Expected I, but got Obj
		//IL_04ec: Expected Obj, but got I
		//IL_2ce6: Expected F4, but got VT
		//IL_2ce1: Expected native int or pointer, but got VT
		//IL_2cfb: Expected F4, but got I
		//IL_2cf6: Expected native int or pointer, but got VT
		//IL_2d0d: Expected Ref, but got VT
		//IL_2d4a: Expected Obj, but got I
		//IL_2d57: Expected F4, but got Obj
		//IL_2d52: Expected native int or pointer, but got VT
		//IL_2d64: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d69: Expected I4, but got Unknown
		//IL_2d7a: Invalid comparison between I and F4
		//IL_0568: Expected I, but got Obj
		//IL_057e: Expected Obj, but got I
		//IL_0517: Expected I, but got Obj
		//IL_054c: Expected F4, but got I
		//IL_2da1: Expected Obj, but got F4
		//IL_05a9: Expected I, but got Obj
		//IL_0606: Expected I, but got Obj
		//IL_061c: Expected Obj, but got I
		//IL_0639: Expected I, but got Obj
		//IL_06eb: Expected I, but got Obj
		//IL_0701: Expected Obj, but got I
		//IL_2e17: Expected F4, but got Obj
		//IL_2e12: Expected native int or pointer, but got VT
		//IL_2e29: Expected F4, but got I
		//IL_2e24: Expected native int or pointer, but got VT
		//IL_2e4c: Expected Obj, but got I
		//IL_2e59: Expected Obj, but got F4
		//IL_2ea0: Expected I, but got Obj
		//IL_2eb6: Expected VT, but got I
		//IL_2ec3: Expected F4, but got Obj
		//IL_2ebe: Expected native int or pointer, but got VT
		//IL_2ed8: Expected F4, but got I
		//IL_2ed3: Expected native int or pointer, but got VT
		//IL_2eff: Expected F4, but got Obj
		//IL_1313: Expected I, but got Obj
		//IL_1329: Expected Obj, but got I
		//IL_1346: Expected I, but got Obj
		//IL_2064: Expected I, but got Obj
		//IL_207a: Expected Obj, but got I
		//IL_2097: Expected I, but got Obj
		//IL_0655: Expected I, but got Obj
		//IL_0663: Expected I, but got Obj
		//IL_14f0: Expected I, but got Obj
		//IL_1506: Expected Obj, but got I
		//IL_1523: Expected I, but got Obj
		//IL_3759: Expected Obj, but got I
		//IL_3766: Expected F4, but got Obj
		//IL_3761: Expected native int or pointer, but got VT
		//IL_3778: Expected F4, but got I
		//IL_3773: Expected native int or pointer, but got VT
		//IL_4945: Expected I, but got Obj
		//IL_495b: Expected Obj, but got I
		//IL_072c: Expected I, but got Obj
		//IL_439e: Expected Obj, but got I
		//IL_43b6: Expected I, but got Obj
		//IL_43c3: Expected F4, but got Obj
		//IL_43be: Expected native int or pointer, but got VT
		//IL_43d5: Expected F4, but got I
		//IL_43d0: Expected native int or pointer, but got VT
		//IL_43eb: Expected Obj, but got I
		//IL_43f8: Expected Obj, but got F4
		//IL_4410: Expected I, but got Obj
		//IL_4426: Expected Obj, but got I
		//IL_38e0: Expected Obj, but got I
		//IL_38ed: Expected F4, but got Obj
		//IL_38e8: Expected native int or pointer, but got VT
		//IL_38ff: Expected F4, but got I
		//IL_38fa: Expected native int or pointer, but got VT
		//IL_1362: Expected I, but got Obj
		//IL_1370: Expected I, but got Obj
		//IL_2f7d: Expected F4, but got Obj
		//IL_2f78: Expected native int or pointer, but got VT
		//IL_2f8f: Expected F4, but got I
		//IL_2f8a: Expected native int or pointer, but got VT
		//IL_2fb7: Expected F4, but got Obj
		//IL_2fb7: Expected VT, but got Obj
		//IL_0769: Expected I, but got Obj
		//IL_077f: Expected Obj, but got I
		//IL_079c: Expected I, but got Obj
		//IL_211c: Expected I, but got Obj
		//IL_2132: Expected Obj, but got I
		//IL_20b3: Expected I, but got Obj
		//IL_20e3: Expected I, but got Obj
		//IL_0691: Expected I, but got Obj
		//IL_153f: Expected I, but got Obj
		//IL_154d: Expected I, but got Obj
		//IL_13df: Expected I, but got Obj
		//IL_13f5: Expected Obj, but got I
		//IL_0ba7: Expected Obj, but got I4
		//IL_0807: Expected I, but got Obj
		//IL_2f63: Expected Obj, but got I
		//IL_1598: Expected I, but got Obj
		//IL_15ae: Expected Obj, but got I
		//IL_15cb: Expected I, but got Obj
		//IL_37c2: Expected F4, but got Obj
		//IL_37bd: Expected native int or pointer, but got VT
		//IL_37d7: Expected F4, but got I
		//IL_37d2: Expected native int or pointer, but got VT
		//IL_37f2: Expected I, but got Obj
		//IL_3808: Expected Obj, but got I
		//IL_139e: Expected I, but got Obj
		//IL_34d5: Expected I, but got Obj
		//IL_34eb: Expected Obj, but got I
		//IL_07b8: Expected I, but got Obj
		//IL_07c6: Expected I, but got Obj
		//IL_2178: Expected I, but got Obj
		//IL_218e: Expected Obj, but got I
		//IL_2109: Expected I, but got Obj
		//IL_3949: Expected F4, but got Obj
		//IL_3944: Expected native int or pointer, but got VT
		//IL_395b: Expected F4, but got I
		//IL_3956: Expected native int or pointer, but got VT
		//IL_3971: Expected Obj, but got I
		//IL_397e: Expected Obj, but got F4
		//IL_157b: Expected I, but got Obj
		//IL_383a: Expected F4, but got Obj
		//IL_3835: Expected native int or pointer, but got VT
		//IL_3852: Expected I, but got Obj
		//IL_3868: Expected Obj, but got I
		//IL_1420: Expected I, but got Obj
		//IL_446c: Expected I, but got Obj
		//IL_4482: Expected Obj, but got I
		//IL_49a2: Expected I, but got Obj
		//IL_49b8: Expected Obj, but got I
		//IL_49d5: Expected I, but got Obj
		//IL_15e7: Expected I, but got Obj
		//IL_15f5: Expected I, but got Obj
		//IL_1453: Expected I, but got Obj
		//IL_3532: Expected I, but got Obj
		//IL_3548: Expected Obj, but got I
		//IL_086c: Expected I, but got Obj
		//IL_0882: Expected Obj, but got I
		//IL_07f4: Expected I, but got Obj
		//IL_21b9: Expected I, but got Obj
		//IL_39ea: Expected Obj, but got I
		//IL_3a15: Expected I, but got Obj
		//IL_3a2b: Expected Obj, but got I
		//IL_1640: Expected I, but got Obj
		//IL_1656: Expected Obj, but got I
		//IL_1673: Expected I, but got Obj
		//IL_26ab: Expected I, but got Obj
		//IL_26c1: Expected Obj, but got I
		//IL_26de: Expected I, but got Obj
		//IL_1486: Expected I, but got Obj
		//IL_1123: Expected I, but got Obj
		//IL_31d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_31d5: Expected Obj, but got Unknown
		//IL_31de: Unknown result type (might be due to invalid IL or missing references)
		//IL_31e3: Expected Obj, but got Unknown
		//IL_2fed: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ff2: Expected Obj, but got Unknown
		//IL_2206: Expected I, but got Obj
		//IL_3a55: Expected F4, but got Obj
		//IL_3a50: Expected native int or pointer, but got VT
		//IL_3a67: Expected F4, but got I
		//IL_3a62: Expected native int or pointer, but got VT
		//IL_3a82: Expected I, but got Obj
		//IL_3a98: Expected Obj, but got I
		//IL_16de: Expected I, but got Obj
		//IL_16ec: Expected I, but got Obj
		//IL_39c7: Expected Obj, but got I
		//IL_1623: Expected I, but got Obj
		//IL_46ad: Expected F4, but got Obj
		//IL_46a8: Expected native int or pointer, but got VT
		//IL_46bf: Expected F4, but got I
		//IL_46ba: Expected native int or pointer, but got VT
		//IL_46d5: Expected Obj, but got I
		//IL_46e2: Expected Obj, but got F4
		//IL_4707: Expected I, but got Obj
		//IL_471d: Expected Obj, but got I
		//IL_498f: Expected Obj, but got I4
		//IL_1156: Expected I, but got Obj
		//IL_0c0e: Expected I, but got Obj
		//IL_0c24: Expected Obj, but got I
		//IL_0bdb: Expected I, but got Obj
		//IL_08e0: Expected I, but got Obj
		//IL_08f6: Expected Obj, but got I
		//IL_08ad: Expected I, but got Obj
		//IL_2260: Expected I, but got Obj
		//IL_2276: Expected Obj, but got I
		//IL_2293: Expected I, but got Obj
		//IL_3aca: Expected F4, but got Obj
		//IL_3ac5: Expected native int or pointer, but got VT
		//IL_3adc: Expected Obj, but got I4
		//IL_3adc: Expected VT, but got Obj
		//IL_3adc: Expected Obj, but got VT
		//IL_172d: Expected I, but got Obj
		//IL_168f: Expected I, but got Obj
		//IL_169d: Expected I, but got Obj
		//IL_26fa: Expected I, but got Obj
		//IL_272a: Expected I, but got Obj
		//IL_36d1: Expected I, but got Obj
		//IL_36e7: Expected Obj, but got I
		//IL_1189: Expected I, but got Obj
		//IL_119f: Expected Obj, but got I
		//IL_44e0: Expected Obj, but got I
		//IL_1aa0: Expected Obj, but got I4
		//IL_1760: Expected I, but got Obj
		//IL_171a: Expected I, but got Obj
		//IL_2763: Expected I, but got Obj
		//IL_2779: Expected Obj, but got I
		//IL_362d: Expected I, but got Obj
		//IL_3643: Expected Obj, but got I
		//IL_35b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_35bd: Expected Obj, but got Unknown
		//IL_35d4: Expected I, but got Obj
		//IL_35ea: Expected Obj, but got I
		//IL_0d58: Expected I, but got Obj
		//IL_0d6e: Expected Obj, but got I
		//IL_0c4f: Expected I, but got Obj
		//IL_0a38: Expected I, but got Obj
		//IL_0a4e: Expected Obj, but got I
		//IL_0921: Expected I, but got Obj
		//IL_22af: Expected I, but got Obj
		//IL_22df: Expected I, but got Obj
		//IL_4140: Expected I, but got Obj
		//IL_4156: Expected Obj, but got I
		//IL_16cb: Expected I, but got Obj
		//IL_477a: Expected VT, but got I4
		//IL_478c: Expected I, but got Obj
		//IL_47a2: Expected Obj, but got I
		//IL_2750: Expected I, but got Obj
		//IL_11fd: Expected I, but got Obj
		//IL_11ca: Expected I, but got Obj
		//IL_32e9: Expected I, but got Obj
		//IL_32ff: Expected Obj, but got I
		//IL_311c: Expected I, but got Obj
		//IL_3132: Expected Obj, but got I
		//IL_47c9: Expected Obj, but got I4
		//IL_27a4: Expected I, but got Obj
		//IL_0d99: Expected I, but got Obj
		//IL_10ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ef: Expected Obj, but got Unknown
		//IL_0a79: Expected I, but got Obj
		//IL_2305: Expected I, but got Obj
		//IL_419d: Expected I, but got Obj
		//IL_41b3: Expected Obj, but got I
		//IL_17bc: Expected I, but got Obj
		//IL_17d2: Expected Obj, but got I
		//IL_27f1: Expected I, but got Obj
		//IL_12b0: Expected I, but got Obj
		//IL_368d: Expected Obj, but got I
		//IL_0e53: Expected I, but got Obj
		//IL_0e69: Expected Obj, but got I
		//IL_0dcc: Expected I, but got Obj
		//IL_3054: Expected I, but got Obj
		//IL_306a: Expected Obj, but got I
		//IL_0aac: Expected I, but got Obj
		//IL_1e96: Expected I, but got Obj
		//IL_3d75: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d7a: Expected Obj, but got Unknown
		//IL_3dbd: Expected I, but got Obj
		//IL_3dd3: Expected Obj, but got I
		//IL_3b12: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b17: Expected Obj, but got Unknown
		//IL_3b3f: Expected I, but got Obj
		//IL_3b55: Expected Obj, but got I
		//IL_2839: Expected Obj, but got I4
		//IL_284b: Expected I, but got Obj
		//IL_2861: Expected Obj, but got I
		//IL_287e: Expected I, but got Obj
		//IL_2318: Expected I, but got Obj
		//IL_232e: Expected Obj, but got I
		//IL_1249: Expected I, but got Obj
		//IL_3356: Expected I, but got Obj
		//IL_336c: Expected Obj, but got I
		//IL_318c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3191: Expected Obj, but got Unknown
		//IL_31a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_31aa: Expected Obj, but got Unknown
		//IL_49fa: Expected Obj, but got I4
		//IL_1ec9: Expected I, but got Obj
		//IL_1ad5: Expected I, but got Obj
		//IL_17fd: Expected I, but got Obj
		//IL_4800: Expected Obj, but got I
		//IL_450f: Expected I, but got Obj
		//IL_451c: Expected F4, but got Obj
		//IL_4517: Expected native int or pointer, but got VT
		//IL_4531: Expected F4, but got I
		//IL_452c: Expected native int or pointer, but got VT
		//IL_1277: Unknown result type (might be due to invalid IL or missing references)
		//IL_127c: Expected Obj, but got Unknown
		//IL_33a4: Expected I, but got Obj
		//IL_33ba: Expected Obj, but got I
		//IL_33c2: Expected Obj, but got I4
		//IL_33d0: Expected I, but got Obj
		//IL_33e6: Expected Obj, but got I
		//IL_0e94: Expected I, but got Obj
		//IL_0ccc: Expected I, but got Obj
		//IL_0ce2: Expected Obj, but got I
		//IL_0b4d: Expected F4, but got Obj
		//IL_0b48: Expected native int or pointer, but got VT
		//IL_0b5f: Expected F4, but got I
		//IL_0b5a: Expected native int or pointer, but got VT
		//IL_0b6c: Expected I4, but got Obj
		//IL_0b6c: Expected I4, but got VT
		//IL_0b1b: Expected I, but got Obj
		//IL_09b6: Expected I, but got Obj
		//IL_09cc: Expected Obj, but got I
		//IL_433c: Expected I, but got Obj
		//IL_4352: Expected Obj, but got I
		//IL_1efc: Expected I, but got Obj
		//IL_1f12: Expected Obj, but got I
		//IL_1c32: Expected I, but got Obj
		//IL_1c48: Expected Obj, but got I
		//IL_1b08: Expected I, but got Obj
		//IL_196c: Expected I, but got Obj
		//IL_1982: Expected Obj, but got I
		//IL_1830: Expected I, but got Obj
		//IL_289a: Expected I, but got Obj
		//IL_28ca: Expected I, but got Obj
		//IL_23b0: Expected I, but got Obj
		//IL_23c6: Expected Obj, but got I
		//IL_23d6: Expected Obj, but got I
		//IL_2406: Expected I, but got Obj
		//IL_2413: Expected F4, but got Obj
		//IL_240e: Expected native int or pointer, but got VT
		//IL_2428: Expected F4, but got I
		//IL_2423: Expected native int or pointer, but got VT
		//IL_244b: Expected Obj, but got I
		//IL_2458: Expected Obj, but got F4
		//IL_2359: Expected I, but got Obj
		//IL_0ec7: Expected I, but got Obj
		//IL_324e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3253: Expected Obj, but got Unknown
		//IL_325c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3261: Expected Obj, but got Unknown
		//IL_3285: Expected F4, but got Obj
		//IL_3280: Expected native int or pointer, but got VT
		//IL_3297: Expected F4, but got I
		//IL_3292: Expected native int or pointer, but got VT
		//IL_32a9: Expected Obj, but got VT
		//IL_2529: Expected I, but got Obj
		//IL_253f: Expected Obj, but got I
		//IL_3091: Unknown result type (might be due to invalid IL or missing references)
		//IL_3096: Expected Obj, but got Unknown
		//IL_30ad: Expected F4, but got Obj
		//IL_30a8: Expected native int or pointer, but got VT
		//IL_30bf: Expected F4, but got I
		//IL_30ba: Expected native int or pointer, but got VT
		//IL_30d1: Expected Obj, but got VT
		//IL_4298: Expected I, but got Obj
		//IL_42ae: Expected Obj, but got I
		//IL_4223: Unknown result type (might be due to invalid IL or missing references)
		//IL_4228: Expected Obj, but got Unknown
		//IL_423f: Expected I, but got Obj
		//IL_4255: Expected Obj, but got I
		//IL_3eb6: Expected I, but got Obj
		//IL_3ecc: Expected Obj, but got I
		//IL_3c92: Expected I, but got Obj
		//IL_3ca8: Expected Obj, but got I
		//IL_2487: Unknown result type (might be due to invalid IL or missing references)
		//IL_248c: Expected Obj, but got Unknown
		//IL_24af: Expected I, but got Obj
		//IL_24bc: Expected F4, but got Obj
		//IL_24b7: Expected native int or pointer, but got VT
		//IL_24d1: Expected F4, but got I
		//IL_24cc: Expected native int or pointer, but got VT
		//IL_24e7: Expected Obj, but got I
		//IL_24f4: Expected Obj, but got F4
		//IL_0efa: Expected I, but got Obj
		//IL_0f10: Expected Obj, but got I
		//IL_0d0d: Expected I, but got Obj
		//IL_458c: Expected I, but got Obj
		//IL_4599: Expected F4, but got Obj
		//IL_4594: Expected native int or pointer, but got VT
		//IL_45ab: Expected F4, but got I
		//IL_45a6: Expected native int or pointer, but got VT
		//IL_4619: Expected I, but got Obj
		//IL_4626: Expected F4, but got Obj
		//IL_4621: Expected native int or pointer, but got VT
		//IL_463b: Expected F4, but got I
		//IL_4636: Expected native int or pointer, but got VT
		//IL_465e: Expected Obj, but got I
		//IL_466b: Expected Obj, but got F4
		//IL_468c: Unknown result type (might be due to invalid IL or missing references)
		//IL_4691: Expected Obj, but got Unknown
		//IL_09f7: Expected I, but got Obj
		//IL_1f70: Expected I, but got Obj
		//IL_1f3d: Expected I, but got Obj
		//IL_1c73: Expected I, but got Obj
		//IL_1e5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e62: Expected Obj, but got Unknown
		//IL_19ad: Expected I, but got Obj
		//IL_28f0: Expected I, but got Obj
		//IL_341b: Expected I, but got Obj
		//IL_3431: Expected Obj, but got I
		//IL_343e: Expected F4, but got Obj
		//IL_3439: Expected native int or pointer, but got VT
		//IL_3450: Expected F4, but got I
		//IL_344b: Expected native int or pointer, but got VT
		//IL_3498: Unknown result type (might be due to invalid IL or missing references)
		//IL_349d: Expected Obj, but got Unknown
		//IL_34a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_34ab: Expected Obj, but got Unknown
		//IL_25b7: Expected I, but got Obj
		//IL_25c4: Expected F4, but got Obj
		//IL_25bf: Expected native int or pointer, but got VT
		//IL_25d9: Expected F4, but got I
		//IL_25d4: Expected native int or pointer, but got VT
		//IL_25ef: Expected Obj, but got I
		//IL_25fc: Expected Obj, but got F4
		//IL_2614: Expected I, but got Obj
		//IL_262a: Expected Obj, but got I
		//IL_256a: Expected I, but got Obj
		//IL_1d1d: Expected I, but got Obj
		//IL_1d33: Expected Obj, but got I
		//IL_1ca6: Expected I, but got Obj
		//IL_3bab: Expected I, but got Obj
		//IL_3bc1: Expected Obj, but got I
		//IL_3bde: Expected I, but got Obj
		//IL_19e0: Expected I, but got Obj
		//IL_0f6e: Expected I, but got Obj
		//IL_0f84: Expected Obj, but got I
		//IL_0f91: Expected F4, but got Obj
		//IL_0f8c: Expected native int or pointer, but got VT
		//IL_0fa6: Expected F4, but got I
		//IL_0fa1: Expected native int or pointer, but got VT
		//IL_0faf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb4: Expected Obj, but got Unknown
		//IL_0fc1: Expected Obj, but got F4
		//IL_0fd5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fda: Expected Obj, but got Unknown
		//IL_0fe3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe8: Expected Obj, but got Unknown
		//IL_0f3b: Expected I, but got Obj
		//IL_2654: Expected I, but got Obj
		//IL_266a: Expected Obj, but got I
		//IL_2023: Expected I, but got Obj
		//IL_42f8: Expected Obj, but got I
		//IL_3f23: Expected I, but got Obj
		//IL_3f39: Expected Obj, but got I
		//IL_3d10: Expected Obj, but got I
		//IL_3d3a: Expected F4, but got Obj
		//IL_3d35: Expected native int or pointer, but got VT
		//IL_3d4c: Expected F4, but got I
		//IL_3d47: Expected native int or pointer, but got VT
		//IL_3d59: Expected I4, but got Obj
		//IL_3d59: Expected I4, but got VT
		//IL_101f: Expected I, but got Obj
		//IL_1035: Expected Obj, but got I
		//IL_104b: Expected I, but got Obj
		//IL_1062: Expected F4, but got Obj
		//IL_105d: Expected native int or pointer, but got VT
		//IL_1077: Expected F4, but got I
		//IL_1072: Expected native int or pointer, but got VT
		//IL_2903: Expected I, but got Obj
		//IL_2919: Expected Obj, but got I
		//IL_1fbc: Expected I, but got Obj
		//IL_3f71: Expected I, but got Obj
		//IL_3f87: Expected Obj, but got I
		//IL_3f8f: Expected Obj, but got I4
		//IL_3f9d: Expected I, but got Obj
		//IL_3fb3: Expected Obj, but got I
		//IL_1d5e: Expected I, but got Obj
		//IL_1b85: Expected I, but got Obj
		//IL_1b9b: Expected Obj, but got I
		//IL_1bb8: Expected I, but got Obj
		//IL_2991: Expected I, but got Obj
		//IL_29a7: Expected Obj, but got I
		//IL_29c4: Expected I, but got Obj
		//IL_1a49: Expected I, but got Obj
		//IL_1a57: Expected I, but got Obj
		//IL_18bf: Expected I, but got Obj
		//IL_18d5: Expected Obj, but got I
		//IL_18f2: Expected I, but got Obj
		//IL_4825: Expected I, but got Obj
		//IL_483b: Expected Obj, but got I
		//IL_484b: Expected Obj, but got I
		//IL_1fea: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fef: Expected Obj, but got Unknown
		//IL_1d91: Expected I, but got Obj
		//IL_3e31: Expected Obj, but got I
		//IL_3e5b: Expected F4, but got Obj
		//IL_3e56: Expected native int or pointer, but got VT
		//IL_3e6d: Expected F4, but got I
		//IL_3e68: Expected native int or pointer, but got VT
		//IL_3e7f: Expected Obj, but got VT
		//IL_487e: Expected Obj, but got I
		//IL_3c02: Expected Obj, but got I
		//IL_3c2c: Expected F4, but got Obj
		//IL_3c27: Expected native int or pointer, but got VT
		//IL_3c3e: Expected F4, but got I
		//IL_3c39: Expected native int or pointer, but got VT
		//IL_3c50: Expected Obj, but got VT
		//IL_2944: Expected I, but got Obj
		//IL_1dc4: Expected I, but got Obj
		//IL_1dda: Expected Obj, but got I
		//IL_1df7: Expected I, but got Obj
		//IL_1bd4: Expected I, but got Obj
		//IL_1be2: Expected I, but got Obj
		//IL_29e0: Expected I, but got Obj
		//IL_2a10: Expected I, but got Obj
		//IL_1a85: Expected I, but got Obj
		//IL_190e: Expected I, but got Obj
		//IL_191c: Expected I, but got Obj
		//IL_3fe6: Expected Obj, but got I
		//IL_3ffc: Expected I, but got Obj
		//IL_4012: Expected Obj, but got I
		//IL_403d: Expected I, but got Obj
		//IL_4053: Expected Obj, but got I
		//IL_4060: Expected F4, but got Obj
		//IL_405b: Expected native int or pointer, but got VT
		//IL_4072: Expected F4, but got I
		//IL_406d: Expected native int or pointer, but got VT
		//IL_407b: Unknown result type (might be due to invalid IL or missing references)
		//IL_4080: Expected Obj, but got Unknown
		//IL_408d: Expected Obj, but got F4
		//IL_40a5: Expected I, but got Obj
		//IL_40bc: Expected F4, but got Obj
		//IL_40b7: Expected native int or pointer, but got VT
		//IL_40d1: Expected F4, but got I
		//IL_40cc: Expected native int or pointer, but got VT
		//IL_1e13: Expected I, but got Obj
		//IL_1e21: Expected I, but got Obj
		//IL_1c10: Expected I, but got Obj
		//IL_2a36: Expected I, but got Obj
		//IL_194a: Expected I, but got Obj
		//IL_1e4f: Expected I, but got Obj
		object obj = default;
		Vector3 vector = (Vector3)(obj + 400);
		Camera camera = (Camera)(obj + 248);
		object obj2 = obj + 392;
		object obj3 = obj + 368;
		object obj4 = obj - -64;
		object obj5 = obj + 224;
		object obj6 = obj + 160;
		object obj7 = obj + 144;
		object obj8 = obj + 136;
		object obj9 = obj + 128;
		object obj10 = obj + 352;
		obj10 = 0;
		_ = 0;
		object obj11 = obj + 328;
		obj11 = 0;
		_ = 0;
		_ = 0;
		object obj12 = obj + 324;
		obj12 = 0f;
		object obj13 = obj + 312;
		obj13 = 0;
		_ = 0;
		object obj15 = default;
		Component component = default;
		object obj42 = default;
		Component component2 = default;
		Component component4 = default;
		Component component5 = default;
		Component component6 = default;
		Component component8 = default;
		BetterList<DepthEntry>.CompareFunc compareFunc = default;
		object obj106 = default;
		UnityEngine.Object obj110 = default;
		object obj114 = default;
		object obj119 = default;
		BetterList<DepthEntry>.CompareFunc compareFunc2 = default;
		object obj168 = default;
		while (true)
		{
			nint num = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S0_v42 (Il2CppClass<UICamera>)+BA]");
			object obj14 = (nint)0 & (nint)0x200;
			if (obj14 != null)
			{
				nint num2 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S0_v1240 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			BetterList<UICamera> betterList = list;
			if ((nint)obj15 < betterList.size)
			{
				nint num3 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S0_v52 (Il2CppClass<UICamera>)+BA]");
				object obj16 = (nint)0 & (nint)0x200;
				if (obj16 != null)
				{
					nint num4 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S0_v1233 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				BetterList<UICamera> betterList2 = list;
				object obj17 = betterList2.buffer + 16;
				object obj18 = obj15 << 2;
				object obj19 = obj17 + obj18;
				Behaviour behaviour = (Behaviour)obj19;
				if (((Behaviour)obj19).isActiveAndEnabled)
				{
					string fileName = ((Component)obj19).tag;
					nint num5 = (nint)typeof(NGUITools);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ S1_v41 (Il2CppClass<NGUITools>)+BA]");
					object obj20 = (nint)0 & (nint)0x200;
					if (obj20 != null)
					{
						nint num6 = (nint)typeof(NGUITools);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ S1_v796 (Il2CppClass<NGUITools>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					byte[] array = NGUITools.Load(fileName);
					if (array != null)
					{
						bool flag = IsPartOfUI((GameObject)obj19);
						nint num7 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ S0_v73 (Il2CppClass<UICamera>)+BA]");
						object obj21 = (nint)0 & (nint)0x200;
						bool flag2 = obj21 == null;
						nint num8 = (nint)typeof(UICamera);
						if (!flag2)
						{
							nint num9 = (nint)typeof(UICamera);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ S0_v1227 (Il2CppClass<UICamera>)+74]");
							bool flag3 = (nint)0 == 0;
							bool flag4 = !flag3;
							num8 = (nint)typeof(UICamera);
							if (!flag4)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								num8 = (nint)typeof(UICamera);
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ L1_v10 (Il2CppClass<UICamera>)+5C]");
						object obj22 = (nint)0 + (nint)140;
						obj22 = flag;
						if (Camera.GetAllCamerasImpl((Camera[])(object)currentCamera) == 0)
						{
							nint num10 = (nint)typeof(UICamera);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ S0_v87 (Il2CppClass<UICamera>)+BA]");
							object obj23 = (nint)0 & (nint)0x200;
							if (obj23 != null)
							{
								nint num11 = (nint)typeof(UICamera);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ S0_v1221 (Il2CppClass<UICamera>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							((Vector3*)(nint)vector)->x = (float)de;
							Vector3 vector2 = vector;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [de @ L0 (DepthEntry&)+8]");
							((Vector3*)(nint)vector2)->z = 0f;
							Ray ray = currentCamera.ScreenPointToRay(vector);
							obj10 = camera;
							_ = ((UnityEngine.Object)camera).m_CachedPtr;
							((Vector3*)(nint)vector)->x = (float)camera;
							((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)camera).m_CachedPtr;
							object obj24 = vector.x & 0x7FFFFFFF;
							bool flag5 = (nint)obj24 <= 2139095040;
							bool flag6 = !flag5;
							int num12 = 0;
							if (!flag6)
							{
								((Vector3*)(nint)vector)->x = (float)obj10;
								Vector3 vector3 = vector;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v29+8]");
								((Vector3*)(nint)vector3)->z = 0f;
								object obj25 = vector.y & 0x7FFFFFFF;
								bool flag7 = (nint)obj25 <= 2139095040;
								bool flag8 = !flag7;
								num12 = 0;
								if (!flag8)
								{
									((Vector3*)(nint)vector)->x = (float)obj10;
									Vector3 vector4 = vector;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v29+8]");
									((Vector3*)(nint)vector4)->z = 0f;
									bool flag9 = vector.x < 0f;
									bool flag10 = !flag9;
									bool flag11 = !flag10;
									num12 = 0;
									if (!flag11)
									{
										((Vector3*)(nint)vector)->x = (float)obj10;
										Vector3 vector5 = vector;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v29+8]");
										((Vector3*)(nint)vector5)->z = 0f;
										bool flag12 = vector.x > 1f;
										bool flag13 = !flag12;
										bool flag14 = !flag13;
										num12 = 0;
										if (!flag14)
										{
											((Vector3*)(nint)vector)->x = (float)obj10;
											Vector3 vector6 = vector;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v29+8]");
											((Vector3*)(nint)vector6)->z = 0f;
											bool flag15 = vector.y < 0f;
											bool flag16 = !flag15;
											bool flag17 = !flag16;
											num12 = 0;
											if (!flag17)
											{
												((Vector3*)(nint)vector)->x = (float)obj10;
												Vector3 vector7 = vector;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v29+8]");
												((Vector3*)(nint)vector7)->z = 0f;
												bool flag18 = vector.y > 1f;
												bool flag19 = !flag18;
												bool flag20 = !flag19;
												num12 = 0;
												if (!flag20)
												{
													nint num13 = (nint)typeof(UICamera);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ S0_v136 (Il2CppClass<UICamera>)+BA]");
													object obj26 = (nint)0 & (nint)0x200;
													if (obj26 != null)
													{
														nint num14 = (nint)typeof(UICamera);
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ S0_v1216 (Il2CppClass<UICamera>)+74]");
														if ((nint)0 == 0)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
														}
													}
													((Vector3*)(nint)vector)->x = (float)de;
													Vector3 vector8 = vector;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [de @ L0 (DepthEntry&)+8]");
													((Vector3*)(nint)vector8)->z = 0f;
													camera.ScreenToViewportPoint_Injected(ref *(Vector3*)currentCamera, out *(Vector3*)vector);
													obj11 = camera;
													_ = ((UnityEngine.Object)camera).m_CachedPtr;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Camera)+10]");
													_ = 0;
													int eventMask = currentCamera.eventMask;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v62 (UnityEngine.Behaviour)+14]");
													obj2 = 0;
													((Vector3*)(nint)vector)->x = (float)obj2;
													int num15 = vector.x & eventMask;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v62 (UnityEngine.Behaviour)+3C]");
													float num16;
													if (0f > 0f)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v62 (UnityEngine.Behaviour)+3C]");
														num16 = 0f;
														num12 = 0;
													}
													else
													{
														nint num17 = (nint)typeof(UICamera);
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v605 @ S1_v780 (Il2CppClass<UICamera>)+BA]");
														object obj27 = (nint)0 & (nint)0x200;
														if (obj27 != null)
														{
															nint num18 = (nint)typeof(UICamera);
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v621 @ S1_v789 (Il2CppClass<UICamera>)+74]");
															if ((nint)0 == 0)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
															}
														}
														float fieldOfView = currentCamera.fieldOfView;
														float farClipPlane = currentCamera.farClipPlane;
														num16 = fieldOfView - farClipPlane;
														num12 = 0;
													}
													obj12 = num16;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v62 (UnityEngine.Behaviour)+C]");
													if ((nint)0 == 0)
													{
														camera = (Camera)obj11;
														Camera camera2 = camera;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v32+8]");
														((UnityEngine.Object)camera2).m_CachedPtr = (IntPtr)0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v32+10]");
														_ = 0;
														nint num19 = (nint)typeof(UICamera);
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v641 @ S0_v1114 (Il2CppClass<UICamera>)+BA]");
														object obj28 = (nint)0 & (nint)0x200;
														bool flag21 = obj28 == null;
														nint num20 = (nint)typeof(UICamera);
														if (!flag21)
														{
															nint num21 = (nint)typeof(UICamera);
															num20 = (nint)typeof(UICamera);
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v656 @ S0_v1211 (Il2CppClass<UICamera>)+74]");
															if ((nint)0 == 0)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																num20 = (nint)typeof(UICamera);
															}
														}
														((Vector3*)(nint)vector)->x = (float)camera;
														((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)camera).m_CachedPtr;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Camera)+10]");
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v658 @ L1_v168 (Il2CppClass<UICamera>)+5C]");
														object obj29 = (nint)0 + (nint)68;
														obj29 = vector.x;
														_ = vector.z;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Vector3)+10]");
														_ = 0;
														obj3 = obj11;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v32+8]");
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v32+10]");
														_ = 0;
														nint num22 = (nint)typeof(UICamera);
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v696 @ S0_v1129 (Il2CppClass<UICamera>)+5C]");
														Ray ray2 = (Ray)((nint)0 + (nint)92);
														((Vector3*)(nint)vector)->x = (float)obj3;
														Vector3 vector9 = vector;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
														((Vector3*)(nint)vector9)->z = 0f;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+10]");
														_ = 0;
														RaycastHit[] array2 = Physics.Internal_RaycastAll((PhysicsScene)vector, ray2, (float)obj12, num15, QueryTriggerInteraction.Ignore);
														if (array2 != null)
														{
															nint num23 = (nint)typeof(UICamera);
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v744 @ S0_v1138 (Il2CppClass<UICamera>)+BA]");
															object obj30 = (nint)0 & (nint)0x200;
															bool flag22 = obj30 == null;
															nint num24 = (nint)typeof(UICamera);
															if (!flag22)
															{
																nint num25 = (nint)typeof(UICamera);
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ S0_v1205 (Il2CppClass<UICamera>)+74]");
																bool flag23 = (nint)0 == 0;
																bool flag24 = !flag23;
																num24 = (nint)typeof(UICamera);
																if (!flag24)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																	num24 = (nint)typeof(UICamera);
																}
															}
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v818 @ L0_v39 (Il2CppClass<UICamera>)+5C]");
															object obj31 = (nint)0 + (nint)92;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F499");
															nint num26 = (nint)typeof(UICamera);
															((Vector3*)(nint)vector)->x = (float)camera;
															((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)camera).m_CachedPtr;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v890 @ S0_v1144 (Il2CppClass<UICamera>)+5C]");
															object obj32 = (nint)0 + (nint)56;
															obj32 = vector.x;
															_ = vector.z;
															nint num27 = (nint)typeof(UICamera);
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v907 @ S0_v1149 (Il2CppClass<UICamera>)+5C]");
															object obj33 = (nint)0 + (nint)92;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1168A");
															string text = component.tag;
															nint num28 = (nint)typeof(UICamera);
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v965 @ S0_v1155 (Il2CppClass<UICamera>)+5C]");
															object obj34 = (nint)0 + (nint)304;
															obj34 = text;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v62 (UnityEngine.Behaviour)+10]");
															if ((nint)0 == 0)
															{
																nint num29 = (nint)typeof(UICamera);
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1034 @ S0_v1164 (Il2CppClass<UICamera>)+BA]");
																object obj35 = (nint)0 & (nint)0x200;
																if (obj35 != null)
																{
																	nint num30 = (nint)typeof(UICamera);
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1105 @ S0_v1199 (Il2CppClass<UICamera>)+74]");
																	if ((nint)0 == 0)
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																	}
																}
																_0021_00210[] components = (_0021_00210[])(object)mRayHitObject.GetComponents<T>();
																nint num31 = (nint)typeof(UnityEngine.Object);
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1193 @ S0_v1173 (Il2CppClass<UnityEngine.Object>)+BA]");
																object obj36 = (nint)0 & (nint)0x200;
																if (obj36 != null)
																{
																	nint num32 = (nint)typeof(UnityEngine.Object);
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1254 @ S0_v1195 (Il2CppClass<UnityEngine.Object>)+74]");
																	if ((nint)0 == 0)
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																	}
																}
																if (((ComputeShader)(object)components).FindKernel((string)null) != 0)
																{
																	string text2 = ((Component)(object)components).tag;
																	nint num33 = (nint)typeof(UICamera);
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1439 @ S0_v1182 (Il2CppClass<UICamera>)+BA]");
																	object obj37 = (nint)0 & (nint)0x200;
																	bool flag25 = obj37 == null;
																	nint num34 = (nint)typeof(UICamera);
																	if (!flag25)
																	{
																		nint num35 = (nint)typeof(UICamera);
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1506 @ S0_v1189 (Il2CppClass<UICamera>)+74]");
																		bool flag26 = (nint)0 == 0;
																		bool flag27 = !flag26;
																		num34 = (nint)typeof(UICamera);
																		if (!flag27)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																			num34 = (nint)typeof(UICamera);
																		}
																	}
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1042 @ L0_v48 (Il2CppClass<UICamera>)+5C]");
																	object obj38 = (nint)0 + (nint)304;
																	obj38 = text2;
																}
															}
															return true;
														}
														QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.Ignore;
														num12 = num15;
													}
													else
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v62 (UnityEngine.Behaviour)+C]");
														if ((nint)0 == 1)
														{
															nint num36 = (nint)typeof(UICamera);
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v711 @ S0_v692 (Il2CppClass<UICamera>)+BA]");
															object obj39 = (nint)0 & (nint)0x200;
															if (obj39 != null)
															{
																nint num37 = (nint)typeof(UICamera);
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v723 @ S0_v1105 (Il2CppClass<UICamera>)+74]");
																if ((nint)0 == 0)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																}
															}
															if (mRayHits == null)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
																nint num38 = (nint)typeof(UICamera);
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v831 @ S0_v1093 (Il2CppClass<UICamera>)+BA]");
																object obj40 = (nint)0 & (nint)0x200;
																bool flag28 = obj40 == null;
																nint num39 = (nint)typeof(UICamera);
																if (!flag28)
																{
																	nint num40 = (nint)typeof(UICamera);
																	num39 = (nint)typeof(UICamera);
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v913 @ S0_v1100 (Il2CppClass<UICamera>)+74]");
																	if ((nint)0 == 0)
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																		num39 = (nint)typeof(UICamera);
																	}
																}
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v757 @ L1_v164 (Il2CppClass<UICamera>)+5C]");
																object obj41 = (nint)0 + (nint)384;
																obj41 = obj42;
															}
															camera = (Camera)obj11;
															Camera camera3 = camera;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v32+8]");
															((UnityEngine.Object)camera3).m_CachedPtr = (IntPtr)0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v32+10]");
															_ = 0;
															nint num41 = (nint)typeof(UICamera);
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v774 @ S0_v705 (Il2CppClass<UICamera>)+BA]");
															object obj43 = (nint)0 & (nint)0x200;
															if (obj43 != null)
															{
																nint num42 = (nint)typeof(UICamera);
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v836 @ S0_v1084 (Il2CppClass<UICamera>)+74]");
																if ((nint)0 == 0)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																}
															}
															((Vector3*)(nint)vector)->x = (float)camera;
															((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)camera).m_CachedPtr;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Camera)+10]");
															_ = 0;
															Collider[] array3 = Physics.OverlapSphere_Internal((PhysicsScene)vector, (Vector3)mRayHits, (float)obj12, num15, QueryTriggerInteraction.Collide);
															if ((nint)array3 < 2)
															{
																bool flag29 = (nint)array3 != 1;
																QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.Collide;
																num12 = num15;
																if (!flag29)
																{
																	nint num43 = (nint)typeof(UICamera);
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v976 @ S0_v960 (Il2CppClass<UICamera>)+BA]");
																	object obj44 = (nint)0 & (nint)0x200;
																	if (obj44 != null)
																	{
																		nint num44 = (nint)typeof(UICamera);
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1053 @ S0_v1079 (Il2CppClass<UICamera>)+74]");
																		if ((nint)0 == 0)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																		}
																	}
																	object obj45 = mRayHits + 16;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1168A");
																	string text3 = component2.tag;
																	UIWidget component3 = ((GameObject)(object)text3).GetComponent<UIWidget>();
																	nint num45 = (nint)typeof(UnityEngine.Object);
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1263 @ S0_v972 (Il2CppClass<UnityEngine.Object>)+BA]");
																	object obj46 = (nint)0 & (nint)0x200;
																	if (obj46 != null)
																	{
																		nint num46 = (nint)typeof(UnityEngine.Object);
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1323 @ S0_v1076 (Il2CppClass<UnityEngine.Object>)+74]");
																		if ((nint)0 == 0)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																		}
																	}
																	int num47;
																	if (((ComputeShader)(object)component3).FindKernel((string)null) != 0)
																	{
																		bool hasVertices = component3.hasVertices;
																		bool flag30 = !hasVertices;
																		queryTriggerInteraction = QueryTriggerInteraction.Collide;
																		num12 = num15;
																		if (flag30)
																		{
																			goto IL_2f11;
																		}
																		bool flag31 = component3.hitCheck == null;
																		num47 = num15;
																		if (!flag31)
																		{
																			nint num48 = (nint)typeof(UICamera);
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1658 @ S1_v705 (Il2CppClass<UICamera>)+BA]");
																			object obj47 = (nint)0 & (nint)0x200;
																			if (obj47 != null)
																			{
																				nint num49 = (nint)typeof(UICamera);
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1753 @ S1_v713 (Il2CppClass<UICamera>)+74]");
																				if ((nint)0 == 0)
																				{
																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																				}
																			}
																			object obj48 = mRayHits + 16;
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F499");
																			((Vector3*)(nint)vector)->x = (float)camera;
																			((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)camera).m_CachedPtr;
																			bool flag32 = component3.hitCheck.EndInvoke((IAsyncResult)vector);
																			bool flag33 = !flag32;
																			queryTriggerInteraction = QueryTriggerInteraction.Collide;
																			num12 = 0;
																			if (flag33)
																			{
																				goto IL_2f11;
																			}
																			num47 = 0;
																		}
																	}
																	else
																	{
																		nint num50 = (nint)typeof(NGUITools);
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1448 @ S0_v1043 (Il2CppClass<NGUITools>)+BA]");
																		object obj49 = (nint)0 & (nint)0x200;
																		if (obj49 != null)
																		{
																			nint num51 = (nint)typeof(NGUITools);
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1516 @ S0_v1063 (Il2CppClass<NGUITools>)+74]");
																			if ((nint)0 == 0)
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																			}
																		}
																		UIRect uIRect = NGUITools.FindInParents<UIRect>((GameObject)(object)text3);
																		nint num52 = (nint)typeof(UnityEngine.Object);
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1557 @ S0_v1050 (Il2CppClass<UnityEngine.Object>)+BA]");
																		object obj50 = (nint)0 & (nint)0x200;
																		if (obj50 != null)
																		{
																			nint num53 = (nint)typeof(UnityEngine.Object);
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1676 @ S0_v1060 (Il2CppClass<UnityEngine.Object>)+74]");
																			if ((nint)0 == 0)
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																			}
																		}
																		int num54 = ((ComputeShader)(object)uIRect).FindKernel((string)null);
																		bool flag34 = num54 == 0;
																		num47 = num15;
																		if (!flag34)
																		{
																			bool flag35 = uIRect.finalAlpha < 0.001f;
																			queryTriggerInteraction = QueryTriggerInteraction.Collide;
																			num12 = num15;
																			num47 = num15;
																			if (flag35)
																			{
																				goto IL_2f11;
																			}
																		}
																	}
																	nint num55 = (nint)typeof(UICamera);
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1671 @ S0_v980 (Il2CppClass<UICamera>)+BA]");
																	object obj51 = (nint)0 & (nint)0x200;
																	if (obj51 != null)
																	{
																		nint num56 = (nint)typeof(UICamera);
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1764 @ S0_v1037 (Il2CppClass<UICamera>)+74]");
																		if ((nint)0 == 0)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																		}
																	}
																	object obj52 = mRayHits + 16;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F499");
																	object obj53 = mRayHits + 16;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1168A");
																	string text4 = component4.tag;
																	((Vector3*)(nint)vector)->x = (float)camera;
																	((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)camera).m_CachedPtr;
																	if (GetDirection((KeyCode)vector, (KeyCode)text4) != 0)
																	{
																		nint num57 = (nint)typeof(UICamera);
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2155 @ S0_v997 (Il2CppClass<UICamera>)+BA]");
																		object obj54 = (nint)0 & (nint)0x200;
																		if (obj54 != null)
																		{
																			nint num58 = (nint)typeof(UICamera);
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2264 @ S0_v1031 (Il2CppClass<UICamera>)+74]");
																			if ((nint)0 == 0)
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																			}
																		}
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9BB5");
																		nint num59 = (nint)typeof(UICamera);
																		((Vector3*)(nint)vector)->x = (float)camera;
																		((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)camera).m_CachedPtr;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Camera)+10]");
																		_ = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Camera)+18]");
																		_ = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Camera)+20]");
																		_ = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Camera)+28]");
																		_ = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9BBD");
																		obj4 = obj11;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v32+8]");
																		_ = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v32+10]");
																		_ = 0;
																		nint num60 = (nint)typeof(UICamera);
																		((Vector3*)(nint)vector)->x = (float)obj4;
																		Vector3 vector10 = vector;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
																		((Vector3*)(nint)vector10)->z = 0f;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+10]");
																		_ = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2497 @ S0_v1009 (Il2CppClass<UICamera>)+5C]");
																		object obj55 = (nint)0 + (nint)68;
																		obj55 = vector.x;
																		_ = vector.z;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Vector3)+10]");
																		_ = 0;
																		object obj56 = mRayHits + 16;
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F499");
																		nint num61 = (nint)typeof(UICamera);
																		((Vector3*)(nint)vector)->x = (float)obj;
																		Vector3 vector11 = vector;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
																		((Vector3*)(nint)vector11)->z = 0f;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2641 @ S0_v1016 (Il2CppClass<UICamera>)+5C]");
																		object obj57 = (nint)0 + (nint)56;
																		obj57 = vector.x;
																		_ = vector.z;
																		nint num62 = (nint)typeof(UICamera);
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2657 @ S0_v1021 (Il2CppClass<UICamera>)+5C]");
																		object obj58 = (nint)0 + (nint)92;
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1168A");
																		string text5 = component5.tag;
																		nint num63 = (nint)typeof(UICamera);
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2759 @ S0_v1027 (Il2CppClass<UICamera>)+5C]");
																		object obj59 = (nint)0 + (nint)304;
																		obj59 = text5;
																		return true;
																	}
																	queryTriggerInteraction = QueryTriggerInteraction.Collide;
																	num12 = num47;
																}
															}
															else
															{
																QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.Collide;
																object obj60 = 0;
																num12 = num15;
																bool flag36;
																while (true)
																{
																	nint num64 = (nint)typeof(UICamera);
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1001 @ S0_v723 (Il2CppClass<UICamera>)+BA]");
																	object obj61 = (nint)0 & (nint)0x200;
																	flag36 = obj61 != null;
																	if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj60) >= System.Runtime.CompilerServices.Unsafe.As<Collider[], UIntPtr>(ref array3))
																	{
																		break;
																	}
																	if (flag36)
																	{
																		nint num65 = (nint)typeof(UICamera);
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1123 @ S0_v952 (Il2CppClass<UICamera>)+74]");
																		if ((nint)0 == 0)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																		}
																	}
																	object obj62 = mRayHits + 16;
																	object obj63 = obj60 * 44;
																	object obj64 = obj62 + obj63;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1168A");
																	string text6 = component6.tag;
																	UIWidget component7 = ((GameObject)(object)text6).GetComponent<UIWidget>();
																	nint num66 = (nint)typeof(UnityEngine.Object);
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1332 @ S0_v838 (Il2CppClass<UnityEngine.Object>)+BA]");
																	object obj65 = (nint)0 & (nint)0x200;
																	if (obj65 != null)
																	{
																		nint num67 = (nint)typeof(UnityEngine.Object);
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1368 @ S0_v949 (Il2CppClass<UnityEngine.Object>)+74]");
																		if ((nint)0 == 0)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																		}
																	}
																	QueryTriggerInteraction queryTriggerInteraction2;
																	int num70;
																	if (((ComputeShader)(object)component7).FindKernel((string)null) != 0)
																	{
																		if (!component7.hasVertices)
																		{
																			goto IL_10e1;
																		}
																		if (component7.hitCheck != null)
																		{
																			nint num68 = (nint)typeof(UICamera);
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1780 @ S1_v617 (Il2CppClass<UICamera>)+BA]");
																			object obj66 = (nint)0 & (nint)0x200;
																			if (obj66 != null)
																			{
																				nint num69 = (nint)typeof(UICamera);
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1884 @ S1_v625 (Il2CppClass<UICamera>)+74]");
																				if ((nint)0 == 0)
																				{
																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																				}
																			}
																			object obj67 = mRayHits + 16;
																			object obj68 = obj60 * 44;
																			object obj69 = obj67 + obj68;
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F499");
																			((Vector3*)(nint)vector)->x = (float)camera;
																			((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)camera).m_CachedPtr;
																			bool flag37 = component7.hitCheck.EndInvoke((IAsyncResult)vector);
																			queryTriggerInteraction = (QueryTriggerInteraction)44;
																			num12 = 0;
																			if (!flag37)
																			{
																				queryTriggerInteraction2 = (QueryTriggerInteraction)44;
																				num70 = 0;
																				goto IL_0e30;
																			}
																		}
																	}
																	else
																	{
																		nint num71 = (nint)typeof(NGUITools);
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1528 @ S0_v916 (Il2CppClass<NGUITools>)+BA]");
																		object obj70 = (nint)0 & (nint)0x200;
																		if (obj70 != null)
																		{
																			nint num72 = (nint)typeof(NGUITools);
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1562 @ S0_v937 (Il2CppClass<NGUITools>)+74]");
																			if ((nint)0 == 0)
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																			}
																		}
																		UIRect uIRect2 = NGUITools.FindInParents<UIRect>((GameObject)(object)text6);
																		nint num73 = (nint)typeof(UnityEngine.Object);
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1713 @ S0_v923 (Il2CppClass<UnityEngine.Object>)+BA]");
																		object obj71 = (nint)0 & (nint)0x200;
																		if (obj71 != null)
																		{
																			nint num74 = (nint)typeof(UnityEngine.Object);
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1808 @ S0_v934 (Il2CppClass<UnityEngine.Object>)+74]");
																			if ((nint)0 == 0)
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																			}
																		}
																		if (((ComputeShader)(object)uIRect2).FindKernel((string)null) != 0)
																		{
																			bool flag38 = uIRect2.finalAlpha < 0.001f;
																			bool flag39 = !flag38;
																			queryTriggerInteraction2 = queryTriggerInteraction;
																			num70 = num12;
																			if (!flag39)
																			{
																				goto IL_0e30;
																			}
																		}
																	}
																	nint num75 = (nint)typeof(UICamera);
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1802 @ S0_v849 (Il2CppClass<UICamera>)+BA]");
																	object obj72 = (nint)0 & (nint)0x200;
																	if (obj72 != null)
																	{
																		nint num76 = (nint)typeof(UICamera);
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1898 @ S0_v911 (Il2CppClass<UICamera>)+74]");
																		if ((nint)0 == 0)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																		}
																	}
																	nint num77 = (nint)typeof(NGUITools);
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1903 @ S0_v854 (Il2CppClass<NGUITools>)+BA]");
																	object obj73 = (nint)0 & (nint)0x200;
																	if (obj73 != null)
																	{
																		nint num78 = (nint)typeof(NGUITools);
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1966 @ S0_v908 (Il2CppClass<NGUITools>)+74]");
																		if ((nint)0 == 0)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																		}
																	}
																	int num79 = NGUITools.CalculateNextDepth((GameObject)(object)text6);
																	nint num80 = (nint)typeof(UICamera);
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2035 @ S0_v861 (Il2CppClass<UICamera>)+5C]");
																	object obj74 = (nint)0 + (nint)316;
																	obj74 = num79;
																	nint num81 = (nint)typeof(UICamera);
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2041 @ S0_v865 (Il2CppClass<UICamera>)+5C]");
																	object obj75 = (nint)0 + (nint)316;
																	if ((nint)obj75 != int.MaxValue)
																	{
																		nint num82 = (nint)typeof(UICamera);
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2093 @ S0_v871 (Il2CppClass<UICamera>)+BA]");
																		object obj76 = (nint)0 & (nint)0x200;
																		if (obj76 != null)
																		{
																			nint num83 = (nint)typeof(UICamera);
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2161 @ S0_v903 (Il2CppClass<UICamera>)+74]");
																			if ((nint)0 == 0)
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																			}
																		}
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9BB5");
																		nint num84 = (nint)typeof(UICamera);
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2279 @ S0_v877 (Il2CppClass<UICamera>)+5C]");
																		object obj77 = (nint)0 + (nint)316;
																		((Vector3*)(nint)vector)->x = (float)camera;
																		((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)camera).m_CachedPtr;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Camera)+10]");
																		_ = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Camera)+18]");
																		_ = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Camera)+20]");
																		_ = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Camera)+28]");
																		_ = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9BB6");
																		object obj78 = mRayHits + 16;
																		object obj79 = obj60 * 44;
																		object obj80 = obj78 + obj79;
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F499");
																		nint num85 = (nint)typeof(UICamera);
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2528 @ S0_v882 (Il2CppClass<UICamera>)+5C]");
																		object obj81 = (nint)0 + (nint)316;
																		((Vector3*)(nint)vector)->x = (float)obj4;
																		Vector3 vector12 = vector;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
																		((Vector3*)(nint)vector12)->z = 0f;
																		object obj82 = obj81 + 48;
																		obj82 = vector.x;
																		_ = vector.z;
																		object obj83 = mRayHits + 16;
																		object obj84 = obj60 * 44;
																		object obj85 = obj83 + obj84;
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1168A");
																		string text7 = component8.tag;
																		nint num86 = (nint)typeof(UICamera);
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2712 @ S0_v896 (Il2CppClass<UICamera>)+5C]");
																		object obj86 = (nint)0 + (nint)376;
																		obj86 = text7;
																		nint num87 = (nint)typeof(UICamera);
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9BB7");
																		((Vector3*)(nint)vector)->x = (float)obj;
																		Vector3 vector13 = vector;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
																		((Vector3*)(nint)vector13)->z = 0f;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
																		_ = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+18]");
																		_ = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+20]");
																		_ = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+28]");
																		_ = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+30]");
																		_ = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+38]");
																		_ = 0;
																		mHits.Add((DepthEntry)vector);
																		num12 = 44;
																	}
																	goto IL_10e1;
																	IL_10e1:
																	object obj87 = obj60 + 1;
																	obj60 = obj87;
																	continue;
																	IL_0e30:
																	queryTriggerInteraction = queryTriggerInteraction2;
																	num12 = num70;
																	goto IL_10e1;
																}
																if (flag36)
																{
																	nint num88 = (nint)typeof(UICamera);
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1140 @ S0_v822 (Il2CppClass<UICamera>)+74]");
																	if ((nint)0 == 0)
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																	}
																}
																nint num89 = (nint)typeof(_003C_003Ec);
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1150 @ S1_v434 (Il2CppClass<UICamera+<>c>)+BA]");
																object obj88 = (nint)0 & (nint)0x200;
																if (obj88 != null)
																{
																	nint num90 = (nint)typeof(_003C_003Ec);
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1206 @ S1_v539 (Il2CppClass<UICamera+<>c>)+74]");
																	if ((nint)0 == 0)
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																	}
																}
																bool flag40 = _003C_003Ec._003C_003E9__190_0 == null;
																bool flag41 = !flag40;
																BetterList<DepthEntry>.CompareFunc comparer = _003C_003Ec._003C_003E9__190_0;
																if (!flag41)
																{
																	nint num91 = (nint)typeof(_003C_003Ec);
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1276 @ S1_v514 (Il2CppClass<UICamera+<>c>)+BA]");
																	object obj89 = (nint)0 & (nint)0x200;
																	if (obj89 != null)
																	{
																		nint num92 = (nint)typeof(_003C_003Ec);
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1339 @ S1_v534 (Il2CppClass<UICamera+<>c>)+74]");
																		if ((nint)0 == 0)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																		}
																	}
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
																	nint num93 = 0;
																	_ = 0;
																	object obj90 = compareFunc + 16;
																	obj90 = _003C_003Ec._003C_003E9;
																	nint num94 = (nint)typeof(_003C_003Ec);
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1390 @ S1_v531 (Il2CppClass<UICamera+<>c>)+5C]");
																	object obj91 = (nint)0 + (nint)4;
																	obj91 = compareFunc;
																	comparer = compareFunc;
																}
																mHits.Sort(comparer);
																object obj92 = 0;
																bool flag43;
																while (true)
																{
																	nint num95 = (nint)typeof(UICamera);
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1405 @ S0_v737 (Il2CppClass<UICamera>)+BA]");
																	object obj93 = (nint)0 & (nint)0x200;
																	if (obj93 != null)
																	{
																		nint num96 = (nint)typeof(UICamera);
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1456 @ S0_v817 (Il2CppClass<UICamera>)+74]");
																		if ((nint)0 == 0)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																		}
																	}
																	BetterList<DepthEntry> betterList3 = mHits;
																	object obj94 = obj92;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1465 @ S1_v448 (BetterList`1<UICamera+DepthEntry>)+C]");
																	bool flag42 = (nint)obj94 < 0;
																	nint num97 = (nint)typeof(UICamera);
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1469 @ S1_v451 (Il2CppClass<UICamera>)+BA]");
																	object obj95 = (nint)0 & (nint)0x200;
																	flag43 = obj95 != null;
																	if (!flag42)
																	{
																		break;
																	}
																	if (flag43)
																	{
																		nint num98 = (nint)typeof(UICamera);
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1571 @ S0_v812 (Il2CppClass<UICamera>)+74]");
																		if ((nint)0 == 0)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																		}
																	}
																	BetterList<DepthEntry> betterList4 = mHits;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1578 @ S0_v760 (BetterList`1<UICamera+DepthEntry>)+8]");
																	object obj96 = (nint)0 + (nint)16;
																	object obj97 = obj92 << 6;
																	GameObject go = (GameObject)(object)(obj96 + obj97);
																	if (!IsHighlighted(go))
																	{
																		object obj98 = obj92 + 1;
																		obj92 = obj98;
																		continue;
																	}
																	nint num99 = (nint)typeof(UICamera);
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1817 @ S0_v766 (Il2CppClass<UICamera>)+BA]");
																	object obj99 = (nint)0 & (nint)0x200;
																	if (obj99 != null)
																	{
																		nint num100 = (nint)typeof(UICamera);
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1908 @ S0_v804 (Il2CppClass<UICamera>)+74]");
																		if ((nint)0 == 0)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																		}
																	}
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9BBB");
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9BBC");
																	nint num101 = (nint)typeof(UICamera);
																	((Vector3*)(nint)vector)->x = (float)obj4;
																	Vector3 vector14 = vector;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
																	((Vector3*)(nint)vector14)->z = 0f;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+10]");
																	_ = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+18]");
																	_ = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+20]");
																	_ = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+28]");
																	_ = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9BBD");
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9BBB");
																	nint num102 = (nint)typeof(UICamera);
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2173 @ S0_v777 (Il2CppClass<UICamera>)+5C]");
																	object obj100 = (nint)0 + (nint)304;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+3C]");
																	obj100 = 0;
																	obj5 = obj11;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v32+8]");
																	_ = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v32+10]");
																	_ = 0;
																	nint num103 = (nint)typeof(UICamera);
																	((Vector3*)(nint)vector)->x = (float)obj5;
																	Vector3 vector15 = vector;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
																	((Vector3*)(nint)vector15)->z = 0f;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+10]");
																	_ = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2189 @ S0_v784 (Il2CppClass<UICamera>)+5C]");
																	object obj101 = (nint)0 + (nint)68;
																	obj101 = vector.x;
																	_ = vector.z;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Vector3)+10]");
																	_ = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9BBB");
																	object obj102 = obj6 + 48;
																	obj7 = obj102;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2305 @ S1_v500+8]");
																	_ = 0;
																	nint num104 = (nint)typeof(UICamera);
																	((Vector3*)(nint)vector)->x = (float)obj7;
																	Vector3 vector16 = vector;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v23+8]");
																	((Vector3*)(nint)vector16)->z = 0f;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2312 @ S0_v793 (Il2CppClass<UICamera>)+5C]");
																	object obj103 = (nint)0 + (nint)56;
																	obj103 = vector.x;
																	_ = vector.z;
																	BetterList<DepthEntry> betterList5 = mHits;
																	_ = 0;
																	return true;
																}
																if (flag43)
																{
																	nint num105 = (nint)typeof(UICamera);
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1587 @ S0_v751 (Il2CppClass<UICamera>)+74]");
																	if ((nint)0 == 0)
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																	}
																}
																BetterList<DepthEntry> betterList6 = mHits;
																_ = 0;
															}
														}
														else
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v62 (UnityEngine.Behaviour)+C]");
															if ((nint)0 == 2)
															{
																nint num106 = (nint)typeof(UICamera);
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v735 @ S0_v565 (Il2CppClass<UICamera>)+BA]");
																object obj104 = (nint)0 & (nint)0x200;
																bool flag44 = obj104 == null;
																nint num107 = (nint)typeof(UICamera);
																if (!flag44)
																{
																	nint num108 = (nint)typeof(UICamera);
																	num107 = (nint)typeof(UICamera);
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v780 @ S0_v686 (Il2CppClass<UICamera>)+74]");
																	if ((nint)0 == 0)
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																		num107 = (nint)typeof(UICamera);
																	}
																}
																camera = (Camera)obj11;
																Camera camera4 = camera;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v32+8]");
																((UnityEngine.Object)camera4).m_CachedPtr = (IntPtr)0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v32+10]");
																_ = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ L1_v93 (Il2CppClass<UICamera>)+5C]");
																object obj105 = (nint)0 + (nint)392;
																((Vector3*)(nint)vector)->x = (float)camera;
																((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)camera).m_CachedPtr;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Camera)+10]");
																_ = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F8D6");
																bool flag45 = obj106 == null;
																num12 = 0;
																if (!flag45)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F969");
																	obj13 = camera;
																	_ = ((UnityEngine.Object)camera).m_CachedPtr;
																	obj4 = camera;
																	_ = ((UnityEngine.Object)camera).m_CachedPtr;
																	nint num109 = (nint)typeof(Vector2);
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v951 @ S0_v583 (Il2CppClass<UnityEngine.Vector2>)+BA]");
																	object obj107 = (nint)0 & (nint)0x200;
																	if (obj107 != null)
																	{
																		nint num110 = (nint)typeof(Vector2);
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1013 @ S0_v683 (Il2CppClass<UnityEngine.Vector2>)+74]");
																		if ((nint)0 == 0)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																		}
																	}
																	((Vector3*)(nint)vector)->x = (float)obj4;
																	Vector3 vector17 = vector;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
																	((Vector3*)(nint)vector17)->z = 0f;
																	Vector3 vector18 = (Vector2)vector;
																	nint num111 = (nint)typeof(Physics2D);
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1071 @ S0_v591 (Il2CppClass<UnityEngine.Physics2D>)+BA]");
																	object obj108 = (nint)0 & (nint)0x200;
																	if (obj108 != null)
																	{
																		nint num112 = (nint)typeof(Physics2D);
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1156 @ S0_v680 (Il2CppClass<UnityEngine.Physics2D>)+74]");
																		if ((nint)0 == 0)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																		}
																	}
																	obj8 = obj;
																	((Vector3*)(nint)vector)->x = (float)obj8;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @115E7");
																	nint num113 = (nint)typeof(UnityEngine.Object);
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1219 @ S0_v600 (Il2CppClass<UnityEngine.Object>)+BA]");
																	object obj109 = (nint)0 & (nint)0x200;
																	if (obj109 != null)
																	{
																		nint num114 = (nint)typeof(UnityEngine.Object);
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1296 @ S0_v677 (Il2CppClass<UnityEngine.Object>)+74]");
																		if ((nint)0 == 0)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																		}
																	}
																	if (UnityEngine.Object.IsNativeObjectAlive(obj110))
																	{
																		camera = (Camera)obj13;
																		Camera camera5 = camera;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v38+8]");
																		((UnityEngine.Object)camera5).m_CachedPtr = (IntPtr)0;
																		nint num115 = (nint)typeof(UICamera);
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1418 @ S0_v609 (Il2CppClass<UICamera>)+BA]");
																		object obj111 = (nint)0 & (nint)0x200;
																		bool flag46 = obj111 == null;
																		nint num116 = (nint)typeof(UICamera);
																		if (!flag46)
																		{
																			nint num117 = (nint)typeof(UICamera);
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1476 @ S0_v671 (Il2CppClass<UICamera>)+74]");
																			bool flag47 = (nint)0 == 0;
																			bool flag48 = !flag47;
																			num116 = (nint)typeof(UICamera);
																			if (!flag48)
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																				num116 = (nint)typeof(UICamera);
																			}
																		}
																		break;
																	}
																	num12 = 0;
																}
															}
															else
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v62 (UnityEngine.Behaviour)+C]");
																if ((nint)0 == 3)
																{
																	nint num118 = (nint)typeof(UICamera);
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v809 @ S0_v173 (Il2CppClass<UICamera>)+BA]");
																	object obj112 = (nint)0 & (nint)0x200;
																	bool flag49 = obj112 == null;
																	nint num119 = (nint)typeof(UICamera);
																	if (!flag49)
																	{
																		nint num120 = (nint)typeof(UICamera);
																		num119 = (nint)typeof(UICamera);
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v860 @ S0_v559 (Il2CppClass<UICamera>)+74]");
																		if ((nint)0 == 0)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																			num119 = (nint)typeof(UICamera);
																		}
																	}
																	camera = (Camera)obj11;
																	Camera camera6 = camera;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v32+8]");
																	((UnityEngine.Object)camera6).m_CachedPtr = (IntPtr)0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v32+10]");
																	_ = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ L1_v19 (Il2CppClass<UICamera>)+5C]");
																	object obj113 = (nint)0 + (nint)392;
																	((Vector3*)(nint)vector)->x = (float)camera;
																	((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)camera).m_CachedPtr;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Camera)+10]");
																	_ = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F8D6");
																	bool flag50 = obj114 == null;
																	num12 = 0;
																	if (!flag50)
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F969");
																		nint num121 = (nint)typeof(UICamera);
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1027 @ S0_v187 (Il2CppClass<UICamera>)+BA]");
																		object obj115 = (nint)0 & (nint)0x200;
																		bool flag51 = obj115 == null;
																		nint num122 = (nint)typeof(UICamera);
																		if (!flag51)
																		{
																			nint num123 = (nint)typeof(UICamera);
																			num122 = (nint)typeof(UICamera);
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1077 @ S0_v554 (Il2CppClass<UICamera>)+74]");
																			if ((nint)0 == 0)
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																				num122 = (nint)typeof(UICamera);
																			}
																		}
																		((Vector3*)(nint)vector)->x = (float)camera;
																		((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)camera).m_CachedPtr;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1079 @ L1_v21 (Il2CppClass<UICamera>)+5C]");
																		object obj116 = (nint)0 + (nint)56;
																		obj116 = vector.x;
																		_ = vector.z;
																		if (mOverlap == null)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
																			nint num124 = (nint)typeof(UICamera);
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1225 @ S0_v542 (Il2CppClass<UICamera>)+BA]");
																			object obj117 = (nint)0 & (nint)0x200;
																			bool flag52 = obj117 == null;
																			nint num125 = (nint)typeof(UICamera);
																			if (!flag52)
																			{
																				nint num126 = (nint)typeof(UICamera);
																				num125 = (nint)typeof(UICamera);
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1301 @ S0_v549 (Il2CppClass<UICamera>)+74]");
																				if ((nint)0 == 0)
																				{
																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																					num125 = (nint)typeof(UICamera);
																				}
																			}
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1177 @ L1_v88 (Il2CppClass<UICamera>)+5C]");
																			object obj118 = (nint)0 + (nint)388;
																			obj118 = obj119;
																		}
																		nint num127 = (nint)typeof(UICamera);
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1185 @ S0_v202 (Il2CppClass<UICamera>)+BA]");
																		object obj120 = (nint)0 & (nint)0x200;
																		bool flag53 = obj120 == null;
																		nint num128 = (nint)typeof(UICamera);
																		if (!flag53)
																		{
																			nint num129 = (nint)typeof(UICamera);
																			num128 = (nint)typeof(UICamera);
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1230 @ S0_v533 (Il2CppClass<UICamera>)+74]");
																			if ((nint)0 == 0)
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																				num128 = (nint)typeof(UICamera);
																			}
																		}
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1232 @ L1_v25 (Il2CppClass<UICamera>)+5C]");
																		object obj121 = (nint)0 + (nint)56;
																		camera = (Camera)obj121;
																		Camera camera7 = camera;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1240 @ S1_v143+8]");
																		((UnityEngine.Object)camera7).m_CachedPtr = (IntPtr)0;
																		nint num130 = (nint)typeof(Vector2);
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1247 @ S0_v209 (Il2CppClass<UnityEngine.Vector2>)+BA]");
																		object obj122 = (nint)0 & (nint)0x200;
																		if (obj122 != null)
																		{
																			nint num131 = (nint)typeof(Vector2);
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1310 @ S0_v530 (Il2CppClass<UnityEngine.Vector2>)+74]");
																			if ((nint)0 == 0)
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																			}
																		}
																		((Vector3*)(nint)vector)->x = (float)camera;
																		((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)camera).m_CachedPtr;
																		Vector3 vector19 = (Vector2)vector;
																		nint num132 = (nint)typeof(Physics2D);
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1360 @ S0_v221 (Il2CppClass<UnityEngine.Physics2D>)+BA]");
																		object obj123 = (nint)0 & (nint)0x200;
																		if (obj123 != null)
																		{
																			nint num133 = (nint)typeof(Physics2D);
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1425 @ S0_v527 (Il2CppClass<UnityEngine.Physics2D>)+74]");
																			if ((nint)0 == 0)
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																			}
																		}
																		obj9 = obj4;
																		((Vector3*)(nint)vector)->x = (float)obj9;
																		bool flag54 = ((CanvasGroup)vector).IsRaycastLocationValid((Vector2)mOverlap, (Camera)num15);
																		if ((flag54 ? 1 : 0) < 2)
																		{
																			bool flag55 = !flag54;
																			num12 = 0;
																			if (!flag55)
																			{
																				nint num134 = (nint)typeof(UICamera);
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1618 @ S0_v435 (Il2CppClass<UICamera>)+BA]");
																				object obj124 = (nint)0 & (nint)0x200;
																				if (obj124 != null)
																				{
																					nint num135 = (nint)typeof(UICamera);
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1735 @ S0_v522 (Il2CppClass<UICamera>)+74]");
																					if ((nint)0 == 0)
																					{
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																					}
																				}
																				object obj125 = mOverlap + 16;
																				string text8 = ((Component)obj125).tag;
																				UIWidget component9 = ((GameObject)(object)text8).GetComponent<UIWidget>();
																				nint num136 = (nint)typeof(UnityEngine.Object);
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1932 @ S0_v447 (Il2CppClass<UnityEngine.Object>)+BA]");
																				object obj126 = (nint)0 & (nint)0x200;
																				if (obj126 != null)
																				{
																					nint num137 = (nint)typeof(UnityEngine.Object);
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1987 @ S0_v519 (Il2CppClass<UnityEngine.Object>)+74]");
																					if ((nint)0 == 0)
																					{
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																					}
																				}
																				int num138;
																				if (((ComputeShader)(object)component9).FindKernel((string)null) != 0)
																				{
																					bool hasVertices2 = component9.hasVertices;
																					bool flag56 = !hasVertices2;
																					num12 = 0;
																					if (flag56)
																					{
																						goto IL_2f11;
																					}
																					bool flag57 = component9.hitCheck == null;
																					num138 = 0;
																					if (!flag57)
																					{
																						nint num139 = (nint)typeof(UICamera);
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2402 @ S1_v334 (Il2CppClass<UICamera>)+BA]");
																						object obj127 = (nint)0 & (nint)0x200;
																						bool flag58 = obj127 == null;
																						nint num140 = (nint)typeof(UICamera);
																						if (!flag58)
																						{
																							nint num141 = (nint)typeof(UICamera);
																							num140 = (nint)typeof(UICamera);
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2559 @ S1_v343 (Il2CppClass<UICamera>)+74]");
																							if ((nint)0 == 0)
																							{
																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																								num140 = (nint)typeof(UICamera);
																							}
																						}
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2561 @ L1_v82 (Il2CppClass<UICamera>)+5C]");
																						object obj128 = (nint)0 + (nint)56;
																						camera = (Camera)obj128;
																						Camera camera8 = camera;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2568 @ S2_v96+8]");
																						((UnityEngine.Object)camera8).m_CachedPtr = (IntPtr)0;
																						((Vector3*)(nint)vector)->x = (float)camera;
																						((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)camera).m_CachedPtr;
																						bool flag59 = component9.hitCheck.EndInvoke((IAsyncResult)vector);
																						bool flag60 = !flag59;
																						num12 = 56;
																						if (flag60)
																						{
																							goto IL_2f11;
																						}
																						num138 = 56;
																					}
																				}
																				else
																				{
																					nint num142 = (nint)typeof(NGUITools);
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2112 @ S0_v486 (Il2CppClass<NGUITools>)+BA]");
																					object obj129 = (nint)0 & (nint)0x200;
																					if (obj129 != null)
																					{
																						nint num143 = (nint)typeof(NGUITools);
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2225 @ S0_v506 (Il2CppClass<NGUITools>)+74]");
																						if ((nint)0 == 0)
																						{
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																						}
																					}
																					UIRect uIRect3 = NGUITools.FindInParents<UIRect>((GameObject)(object)text8);
																					nint num144 = (nint)typeof(UnityEngine.Object);
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2347 @ S0_v493 (Il2CppClass<UnityEngine.Object>)+BA]");
																					object obj130 = (nint)0 & (nint)0x200;
																					if (obj130 != null)
																					{
																						nint num145 = (nint)typeof(UnityEngine.Object);
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2420 @ S0_v503 (Il2CppClass<UnityEngine.Object>)+74]");
																						if ((nint)0 == 0)
																						{
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																						}
																					}
																					int num146 = ((ComputeShader)(object)uIRect3).FindKernel((string)null);
																					bool flag61 = num146 == 0;
																					num138 = 0;
																					if (!flag61)
																					{
																						bool flag62 = uIRect3.finalAlpha < 0.001f;
																						num12 = 0;
																						num138 = 0;
																						if (flag62)
																						{
																							goto IL_2f11;
																						}
																					}
																				}
																				nint num147 = (nint)typeof(UICamera);
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2415 @ S0_v455 (Il2CppClass<UICamera>)+BA]");
																				object obj131 = (nint)0 & (nint)0x200;
																				bool flag63 = obj131 == null;
																				nint num148 = (nint)typeof(UICamera);
																				if (!flag63)
																				{
																					nint num149 = (nint)typeof(UICamera);
																					num148 = (nint)typeof(UICamera);
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2580 @ S0_v480 (Il2CppClass<UICamera>)+74]");
																					if ((nint)0 == 0)
																					{
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																						num148 = (nint)typeof(UICamera);
																					}
																				}
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2582 @ L1_v76 (Il2CppClass<UICamera>)+5C]");
																				object obj132 = (nint)0 + (nint)56;
																				camera = (Camera)obj132;
																				Camera camera9 = camera;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2590 @ S1_v314+8]");
																				((UnityEngine.Object)camera9).m_CachedPtr = (IntPtr)0;
																				((Vector3*)(nint)vector)->x = (float)camera;
																				((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)camera).m_CachedPtr;
																				if (GetDirection((KeyCode)vector, (KeyCode)text8) != 0)
																				{
																					nint num150 = (nint)typeof(UICamera);
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2727 @ S0_v466 (Il2CppClass<UICamera>)+BA]");
																					object obj133 = (nint)0 & (nint)0x200;
																					bool flag64 = obj133 == null;
																					nint num151 = (nint)typeof(UICamera);
																					if (!flag64)
																					{
																						nint num152 = (nint)typeof(UICamera);
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2789 @ S0_v474 (Il2CppClass<UICamera>)+74]");
																						bool flag65 = (nint)0 == 0;
																						bool flag66 = !flag65;
																						num151 = (nint)typeof(UICamera);
																						if (!flag66)
																						{
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																							num151 = (nint)typeof(UICamera);
																						}
																					}
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2793 @ L0_v7 (Il2CppClass<UICamera>)+5C]");
																					object obj134 = (nint)0 + (nint)304;
																					obj134 = text8;
																					return true;
																				}
																				num12 = num138;
																			}
																		}
																		else
																		{
																			object obj135 = 0;
																			num12 = 0;
																			bool flag67;
																			while (true)
																			{
																				nint num153 = (nint)typeof(UICamera);
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1642 @ S0_v233 (Il2CppClass<UICamera>)+BA]");
																				object obj136 = (nint)0 & (nint)0x200;
																				flag67 = obj136 != null;
																				if ((nint)obj135 >= (flag54 ? 1 : 0))
																				{
																					break;
																				}
																				if (flag67)
																				{
																					nint num154 = (nint)typeof(UICamera);
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1831 @ S0_v427 (Il2CppClass<UICamera>)+74]");
																					if ((nint)0 == 0)
																					{
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																					}
																				}
																				object obj137 = mOverlap + 16;
																				object obj138 = obj135 << 2;
																				object obj139 = obj137 + obj138;
																				string text9 = ((Component)obj139).tag;
																				UIWidget component10 = ((GameObject)(object)text9).GetComponent<UIWidget>();
																				nint num155 = (nint)typeof(UnityEngine.Object);
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1997 @ S0_v326 (Il2CppClass<UnityEngine.Object>)+BA]");
																				object obj140 = (nint)0 & (nint)0x200;
																				if (obj140 != null)
																				{
																					nint num156 = (nint)typeof(UnityEngine.Object);
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2069 @ S0_v424 (Il2CppClass<UnityEngine.Object>)+74]");
																					if ((nint)0 == 0)
																					{
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																					}
																				}
																				int num160;
																				if (((ComputeShader)(object)component10).FindKernel((string)null) != 0)
																				{
																					if (!component10.hasVertices)
																					{
																						goto IL_1e54;
																					}
																					if (component10.hitCheck != null)
																					{
																						nint num157 = (nint)typeof(UICamera);
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2605 @ S1_v288 (Il2CppClass<UICamera>)+BA]");
																						object obj141 = (nint)0 & (nint)0x200;
																						bool flag68 = obj141 == null;
																						nint num158 = (nint)typeof(UICamera);
																						if (!flag68)
																						{
																							nint num159 = (nint)typeof(UICamera);
																							num158 = (nint)typeof(UICamera);
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2669 @ S1_v297 (Il2CppClass<UICamera>)+74]");
																							if ((nint)0 == 0)
																							{
																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																								num158 = (nint)typeof(UICamera);
																							}
																						}
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2671 @ L1_v67 (Il2CppClass<UICamera>)+5C]");
																						object obj142 = (nint)0 + (nint)56;
																						camera = (Camera)obj142;
																						Camera camera10 = camera;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2678 @ S2_v79+8]");
																						((UnityEngine.Object)camera10).m_CachedPtr = (IntPtr)0;
																						((Vector3*)(nint)vector)->x = (float)camera;
																						((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)camera).m_CachedPtr;
																						bool flag69 = component10.hitCheck.EndInvoke((IAsyncResult)vector);
																						num12 = 56;
																						if (!flag69)
																						{
																							num160 = 56;
																							goto IL_1d02;
																						}
																					}
																				}
																				else
																				{
																					nint num161 = (nint)typeof(NGUITools);
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2237 @ S0_v391 (Il2CppClass<NGUITools>)+BA]");
																					object obj143 = (nint)0 & (nint)0x200;
																					if (obj143 != null)
																					{
																						nint num162 = (nint)typeof(NGUITools);
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2352 @ S0_v412 (Il2CppClass<NGUITools>)+74]");
																						if ((nint)0 == 0)
																						{
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																						}
																					}
																					UIRect uIRect4 = NGUITools.FindInParents<UIRect>((GameObject)(object)text9);
																					nint num163 = (nint)typeof(UnityEngine.Object);
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2454 @ S0_v398 (Il2CppClass<UnityEngine.Object>)+BA]");
																					object obj144 = (nint)0 & (nint)0x200;
																					if (obj144 != null)
																					{
																						nint num164 = (nint)typeof(UnityEngine.Object);
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2632 @ S0_v409 (Il2CppClass<UnityEngine.Object>)+74]");
																						if ((nint)0 == 0)
																						{
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																						}
																					}
																					if (((ComputeShader)(object)uIRect4).FindKernel((string)null) != 0)
																					{
																						bool flag70 = uIRect4.finalAlpha < 0.001f;
																						bool flag71 = !flag70;
																						num160 = num12;
																						if (!flag71)
																						{
																							goto IL_1d02;
																						}
																					}
																				}
																				nint num165 = (nint)typeof(UICamera);
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2626 @ S0_v337 (Il2CppClass<UICamera>)+BA]");
																				object obj145 = (nint)0 & (nint)0x200;
																				if (obj145 != null)
																				{
																					nint num166 = (nint)typeof(UICamera);
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2689 @ S0_v386 (Il2CppClass<UICamera>)+74]");
																					if ((nint)0 == 0)
																					{
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																					}
																				}
																				nint num167 = (nint)typeof(NGUITools);
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2694 @ S0_v342 (Il2CppClass<NGUITools>)+BA]");
																				object obj146 = (nint)0 & (nint)0x200;
																				if (obj146 != null)
																				{
																					nint num168 = (nint)typeof(NGUITools);
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2734 @ S0_v383 (Il2CppClass<NGUITools>)+74]");
																					if ((nint)0 == 0)
																					{
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																					}
																				}
																				int num169 = NGUITools.CalculateNextDepth((GameObject)(object)text9);
																				nint num170 = (nint)typeof(UICamera);
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2803 @ S0_v349 (Il2CppClass<UICamera>)+5C]");
																				object obj147 = (nint)0 + (nint)316;
																				obj147 = num169;
																				nint num171 = (nint)typeof(UICamera);
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2809 @ S0_v353 (Il2CppClass<UICamera>)+5C]");
																				object obj148 = (nint)0 + (nint)316;
																				if ((nint)obj148 != int.MaxValue)
																				{
																					nint num172 = (nint)typeof(UICamera);
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2830 @ S0_v359 (Il2CppClass<UICamera>)+BA]");
																					object obj149 = (nint)0 & (nint)0x200;
																					bool flag72 = obj149 == null;
																					nint num173 = (nint)typeof(UICamera);
																					if (!flag72)
																					{
																						nint num174 = (nint)typeof(UICamera);
																						num173 = (nint)typeof(UICamera);
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2837 @ S0_v378 (Il2CppClass<UICamera>)+74]");
																						if ((nint)0 == 0)
																						{
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																							num173 = (nint)typeof(UICamera);
																						}
																					}
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2839 @ L1_v59 (Il2CppClass<UICamera>)+5C]");
																					object obj150 = (nint)0 + (nint)376;
																					obj150 = text9;
																					nint num175 = (nint)typeof(UICamera);
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2850 @ S1_v253 (Il2CppClass<UICamera>)+5C]");
																					object obj151 = (nint)0 + (nint)56;
																					camera = (Camera)obj151;
																					Camera camera11 = camera;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2853 @ S1_v255+8]");
																					((UnityEngine.Object)camera11).m_CachedPtr = (IntPtr)0;
																					nint num176 = (nint)typeof(UICamera);
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2860 @ S0_v369 (Il2CppClass<UICamera>)+5C]");
																					object obj152 = (nint)0 + (nint)316;
																					((Vector3*)(nint)vector)->x = (float)camera;
																					((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)camera).m_CachedPtr;
																					object obj153 = obj152 + 48;
																					obj153 = vector.x;
																					_ = vector.z;
																					nint num177 = (nint)typeof(UICamera);
																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9BB7");
																					((Vector3*)(nint)vector)->x = (float)obj4;
																					Vector3 vector20 = vector;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
																					((Vector3*)(nint)vector20)->z = 0f;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+10]");
																					_ = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+18]");
																					_ = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+20]");
																					_ = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+28]");
																					_ = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+30]");
																					_ = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+38]");
																					_ = 0;
																					mHits.Add((DepthEntry)vector);
																				}
																				goto IL_1e54;
																				IL_1e54:
																				object obj154 = obj135 + 1;
																				obj135 = obj154;
																				continue;
																				IL_1d02:
																				num12 = num160;
																				goto IL_1e54;
																			}
																			if (flag67)
																			{
																				nint num178 = (nint)typeof(UICamera);
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1849 @ S0_v310 (Il2CppClass<UICamera>)+74]");
																				if ((nint)0 == 0)
																				{
																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																				}
																			}
																			nint num179 = (nint)typeof(_003C_003Ec);
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1859 @ S1_v165 (Il2CppClass<UICamera+<>c>)+BA]");
																			object obj155 = (nint)0 & (nint)0x200;
																			if (obj155 != null)
																			{
																				nint num180 = (nint)typeof(_003C_003Ec);
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1943 @ S1_v226 (Il2CppClass<UICamera+<>c>)+74]");
																				if ((nint)0 == 0)
																				{
																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																				}
																			}
																			bool flag73 = _003C_003Ec._003C_003E9__190_1 == null;
																			bool flag74 = !flag73;
																			BetterList<DepthEntry>.CompareFunc comparer2 = _003C_003Ec._003C_003E9__190_1;
																			if (!flag74)
																			{
																				nint num181 = (nint)typeof(_003C_003Ec);
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2006 @ S1_v201 (Il2CppClass<UICamera+<>c>)+BA]");
																				object obj156 = (nint)0 & (nint)0x200;
																				if (obj156 != null)
																				{
																					nint num182 = (nint)typeof(_003C_003Ec);
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2078 @ S1_v221 (Il2CppClass<UICamera+<>c>)+74]");
																					if ((nint)0 == 0)
																					{
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																					}
																				}
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
																				nint num183 = 0;
																				_ = 0;
																				object obj157 = compareFunc2 + 16;
																				obj157 = _003C_003Ec._003C_003E9;
																				nint num184 = (nint)typeof(_003C_003Ec);
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2133 @ S1_v218 (Il2CppClass<UICamera+<>c>)+5C]");
																				object obj158 = (nint)0 + (nint)8;
																				obj158 = compareFunc2;
																				comparer2 = compareFunc2;
																			}
																			mHits.Sort(comparer2);
																			object obj159 = 0;
																			bool flag76;
																			while (true)
																			{
																				nint num185 = (nint)typeof(UICamera);
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2148 @ S0_v247 (Il2CppClass<UICamera>)+BA]");
																				object obj160 = (nint)0 & (nint)0x200;
																				if (obj160 != null)
																				{
																					nint num186 = (nint)typeof(UICamera);
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2244 @ S0_v305 (Il2CppClass<UICamera>)+74]");
																					if ((nint)0 == 0)
																					{
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																					}
																				}
																				BetterList<DepthEntry> betterList7 = mHits;
																				object obj161 = obj159;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2253 @ S1_v179 (BetterList`1<UICamera+DepthEntry>)+C]");
																				bool flag75 = (nint)obj161 < 0;
																				nint num187 = (nint)typeof(UICamera);
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2257 @ S1_v182 (Il2CppClass<UICamera>)+BA]");
																				object obj162 = (nint)0 & (nint)0x200;
																				flag76 = obj162 != null;
																				if (!flag75)
																				{
																					break;
																				}
																				if (flag76)
																				{
																					nint num188 = (nint)typeof(UICamera);
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2461 @ S0_v300 (Il2CppClass<UICamera>)+74]");
																					if ((nint)0 == 0)
																					{
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																					}
																				}
																				BetterList<DepthEntry> betterList8 = mHits;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2468 @ S0_v270 (BetterList`1<UICamera+DepthEntry>)+8]");
																				object obj163 = (nint)0 + (nint)16;
																				object obj164 = obj159 << 6;
																				GameObject go2 = (GameObject)(object)(obj163 + obj164);
																				if (!IsHighlighted(go2))
																				{
																					object obj165 = obj159 + 1;
																					obj159 = obj165;
																					continue;
																				}
																				nint num189 = (nint)typeof(UICamera);
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2702 @ S0_v276 (Il2CppClass<UICamera>)+BA]");
																				object obj166 = (nint)0 & (nint)0x200;
																				if (obj166 != null)
																				{
																					nint num190 = (nint)typeof(UICamera);
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2744 @ S0_v292 (Il2CppClass<UICamera>)+74]");
																					if ((nint)0 == 0)
																					{
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																					}
																				}
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9BBB");
																				nint num191 = (nint)typeof(UICamera);
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2816 @ S0_v282 (Il2CppClass<UICamera>)+5C]");
																				object obj167 = (nint)0 + (nint)304;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Vector3)+3C]");
																				obj167 = 0;
																				BetterList<DepthEntry> betterList9 = mHits;
																				_ = 0;
																				return true;
																			}
																			if (flag76)
																			{
																				nint num192 = (nint)typeof(UICamera);
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2477 @ S0_v261 (Il2CppClass<UICamera>)+74]");
																				if ((nint)0 == 0)
																				{
																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																				}
																			}
																			BetterList<DepthEntry> betterList10 = mHits;
																			_ = 0;
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_2f11;
			}
			return false;
			IL_2f11:
			obj15 = obj168 + 1;
		}
		((Vector3*)(nint)vector)->x = (float)camera;
		((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)camera).m_CachedPtr;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1480 @ L0_v11 (Il2CppClass<UICamera>)+5C]");
		object obj169 = (nint)0 + (nint)56;
		obj169 = vector.x;
		_ = vector.z;
		string text10 = ((Component)obj110).tag;
		nint num193 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1540 @ S0_v620 (Il2CppClass<UICamera>)+5C]");
		object obj170 = (nint)0 + (nint)304;
		obj170 = text10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v62 (UnityEngine.Behaviour)+10]");
		if ((nint)0 == 0)
		{
			nint num194 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1598 @ S0_v629 (Il2CppClass<UICamera>)+BA]");
			object obj171 = (nint)0 & (nint)0x200;
			if (obj171 != null)
			{
				nint num195 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1721 @ S0_v665 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int layer = mRayHitObject.layer;
			bool flag77 = Raycast((Vector3)layer);
			nint num196 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1925 @ S0_v639 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj172 = (nint)0 & (nint)0x200;
			if (obj172 != null)
			{
				nint num197 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1979 @ S0_v661 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)flag77).FindKernel(null) != 0)
			{
				string text11 = ((Component)flag77).tag;
				nint num198 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2219 @ S0_v648 (Il2CppClass<UICamera>)+BA]");
				object obj173 = (nint)0 & (nint)0x200;
				bool flag78 = obj173 == null;
				nint num199 = (nint)typeof(UICamera);
				if (!flag78)
				{
					nint num200 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2333 @ S0_v655 (Il2CppClass<UICamera>)+74]");
					bool flag79 = (nint)0 == 0;
					bool flag80 = !flag79;
					num199 = (nint)typeof(UICamera);
					if (!flag80)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num199 = (nint)typeof(UICamera);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1606 @ L0_v20 (Il2CppClass<UICamera>)+5C]");
				object obj174 = (nint)0 + (nint)304;
				obj174 = text11;
			}
		}
		return true;
	}

	public static bool IsHighlighted(GameObject go)
	{
		//IL_0137: Expected I, but got Obj
		//IL_014d: Expected Obj, but got I
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Expected Obj, but got Unknown
		//IL_0203: Expected Obj, but got I
		//IL_01b1: Expected I, but got Obj
		//IL_01c7: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected Obj, but got Unknown
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<NGUITools>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v29 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = default;
		UIWidget uIWidget = (UIWidget)(obj2 + 12);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [go @ L0 (UnityEngine.GameObject)+3C]");
		UIPanel uIPanel = NGUITools.FindInParents<UIPanel>((GameObject)0);
		UIPanel uIPanel2 = uIPanel;
		bool result;
		while (true)
		{
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v13 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v28 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int num5 = ((ComputeShader)(object)uIPanel2).FindKernel((string)null);
			bool flag = num5 == 0;
			result = true;
			if (flag)
			{
				break;
			}
			object obj4 = go + 48;
			obj2 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S1_v20+8]");
			_ = 0;
			uIWidget = (UIWidget)obj2;
			UIWidget uIWidget2 = uIWidget;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((UnityEngine.Object)uIWidget2).m_CachedPtr = (IntPtr)0;
			if (uIPanel2.IsVisible(uIWidget))
			{
				uIPanel2 = uIPanel2.mParentPanel;
				continue;
			}
			result = false;
			break;
		}
		return result;
	}

	public static UICamera FindCameraForLayer(int layer)
	{
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_010d: Expected I, but got Obj
		//IL_0123: Expected Obj, but got I
		//IL_00ed: Expected Obj, but got I4
		//IL_00f1: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		nint num = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UICamera>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		GameObject gameObject = controllerNavigationObject;
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v9 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (UICamera)(gameObject != (UnityEngine.Object)layer);
	}

	private unsafe static int GetDirection(KeyCode up, KeyCode down)
	{
		//IL_0119: Expected I, but got Obj
		//IL_012f: Expected Obj, but got I
		//IL_01cf: Expected Obj, but got I4
		//IL_0193: Expected I, but got Obj
		//IL_01a9: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00ac: Expected Obj, but got I4
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<NGUITools>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v34 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIPanel uIPanel = NGUITools.FindInParents<UIPanel>((GameObject)down);
		UIPanel uIPanel2 = uIPanel;
		int result;
		while (true)
		{
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v17 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v30 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int num5 = ((ComputeShader)(object)uIPanel2).FindKernel((string)null);
			bool flag = num5 == 0;
			result = 1;
			if (flag)
			{
				break;
			}
			UIWidget uIWidget = (UIWidget)((KeyCode*)(int)up)->value__;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [up @ L0 (UnityEngine.KeyCode)+8]");
			((UnityEngine.Object)uIWidget).m_CachedPtr = (IntPtr)0;
			if (uIPanel2.IsVisible(uIWidget))
			{
				uIPanel2 = uIPanel2.mParentPanel;
				continue;
			}
			result = 0;
			break;
		}
		return result;
	}

	private static int GetDirection(KeyCode up0, KeyCode up1, KeyCode down0, KeyCode down1)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a9: Expected VT, but got I4
		//IL_00a9: Expected VT, but got I4
		//IL_00a9: Expected VT, but got I4
		//IL_00a9: Expected VT, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UIDrawCall);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIDrawCall>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIDrawCall);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<UIDrawCall>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return ((UIPanel)null).IsVisible((Vector3)up0, (Vector3)up1, (Vector3)down0, (Vector3)down1) ? 1 : 0;
	}

	private static int GetDirection(string axis)
	{
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Expected Obj, but got Unknown
		//IL_01a7: Expected Obj, but got I4
		//IL_01b0: Expected Obj, but got I4
		//IL_0273: Expected I, but got Obj
		//IL_0289: Expected Obj, but got I
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected Obj, but got Unknown
		//IL_0207: Expected I, but got Obj
		//IL_021d: Expected Obj, but got I
		//IL_0244: Expected Obj, but got I4
		//IL_00af: Expected I, but got Obj
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected Obj, but got Unknown
		//IL_00fc: Expected I, but got Obj
		//IL_0144: Expected Obj, but got I4
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected I4, but got Unknown
		//IL_015d: Expected I4, but got Obj
		object obj = axis & 0x1F;
		object obj2 = 1 << (int)obj;
		object obj3 = 0;
		int result;
		while (true)
		{
			nint num = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v10 (Il2CppClass<UICamera>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num2 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v55 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			BetterList<UICamera> betterList = list;
			if ((nint)obj3 >= betterList.size)
			{
				result = 0;
				break;
			}
			nint num3 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v19 (Il2CppClass<UICamera>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num4 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v48 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			BetterList<UICamera> betterList2 = list;
			object obj6 = betterList2.buffer + 16;
			object obj7 = obj3 << 2;
			object obj8 = obj6 + obj7;
			bool flag = IsPartOfUI((GameObject)obj8);
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v32 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v44 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)flag).FindKernel(null) != 0)
			{
				int eventMask = ((Camera)flag).eventMask;
				int num7 = eventMask & obj2;
				result = (int)obj8;
				if (num7 != 0)
				{
					break;
				}
			}
			object obj10 = obj3 + 1;
			obj3 = obj10;
		}
		return result;
	}

	public static void Notify(GameObject go, string funcName, object obj)
	{
		//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dc: Expected Obj, but got Unknown
		//IL_03e5: Expected Obj, but got I4
		//IL_03fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ff: Expected Obj, but got Unknown
		//IL_0408: Expected Obj, but got I4
		//IL_043b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0440: Expected Obj, but got Unknown
		//IL_0449: Expected Obj, but got I4
		//IL_0463: Expected I, but got Obj
		//IL_0479: Expected Obj, but got I
		//IL_058c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0591: Expected Obj, but got Unknown
		//IL_059a: Unknown result type (might be due to invalid IL or missing references)
		//IL_059f: Expected Obj, but got Unknown
		//IL_05a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ad: Expected Obj, but got Unknown
		//IL_05b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bb: Expected Obj, but got Unknown
		//IL_05c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c9: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Expected Obj, but got Unknown
		//IL_0283: Expected I, but got Obj
		//IL_0299: Expected Obj, but got I
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected Obj, but got Unknown
		//IL_008d: Expected I, but got Obj
		//IL_00a3: Expected Obj, but got I
		//IL_0553: Expected Obj, but got I4
		//IL_04dc: Expected Obj, but got I4
		//IL_02c4: Expected I, but got Obj
		//IL_00ce: Expected I, but got Obj
		//IL_030c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Expected Obj, but got Unknown
		//IL_031a: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Expected Obj, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected Obj, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected Obj, but got Unknown
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected Obj, but got Unknown
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0392: Expected Obj, but got Unknown
		object obj3 = default;
		object obj2 = obj3 + 192;
		obj2 = 0;
		_ = 0;
		_ = 0;
		object obj4 = obj3 + 128;
		obj4 = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		object obj5 = obj3 + 104;
		obj5 = 0;
		_ = 0;
		_ = 0;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v26 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v121 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj7 = obj3 + 228;
		object obj8 = obj3 + 216;
		object obj9 = obj3 + 40;
		object obj10 = obj3 + 24;
		object obj11 = obj3 + 12;
		GameObject gameObject;
		if ((UnityEngine.Object)obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			object obj13 = default;
			object obj12 = obj13 + 16;
			obj9 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S1_v94+8]");
			_ = 0;
			nint num3 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v93 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj14 = (nint)0 & (nint)0x200;
			if (obj14 != null)
			{
				nint num4 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S0_v117 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector3 one = Vector3.one;
			obj8 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v35+8]");
			_ = 0;
			obj7 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v37+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F496");
			object obj15 = 1;
			while ((nint)obj15 <= 3)
			{
				object obj16 = obj13 + 16;
				object obj17 = obj15 * 12;
				object obj18 = obj16 + obj17;
				obj8 = obj18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ S1_v119+8]");
				_ = 0;
				obj7 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v33+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4B6");
				object obj19 = obj15 + 1;
				obj15 = obj19;
			}
			gameObject = (GameObject)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			((UnityEngine.Object)go).m_CachedPtr = (IntPtr)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+10]");
			_ = 0;
			return;
		}
		Matrix4x4 localToWorldMatrix = ((Transform)obj).localToWorldMatrix;
		obj4 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v35+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v35+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v35+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v35+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v35+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v35+30]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v35+38]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		object obj21 = default;
		object obj20 = obj21 + 16;
		obj10 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S1_v47+8]");
		_ = 0;
		obj7 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v37+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F6DF");
		nint num5 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ S0_v59 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj22 = (nint)0 & (nint)0x200;
		if (obj22 != null)
		{
			nint num6 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ S0_v86 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 one2 = Vector3.one;
		obj8 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v39+8]");
		_ = 0;
		obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F496");
		object obj23 = 1;
		while ((nint)obj23 <= 3)
		{
			object obj24 = obj21 + 16;
			object obj25 = obj23 * 12;
			object obj26 = obj24 + obj25;
			obj8 = obj26;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ S1_v77+8]");
			_ = 0;
			obj7 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v33+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F6DF");
			obj7 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v35+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4B6");
			object obj27 = obj23 + 1;
			obj23 = obj27;
		}
		gameObject = (GameObject)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v22+8]");
		((UnityEngine.Object)go).m_CachedPtr = (IntPtr)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v22+10]");
		_ = 0;
	}

	private unsafe void Awake()
	{
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Expected Obj, but got Unknown
		//IL_02ba: Expected Obj, but got I4
		//IL_02c8: Expected I, but got Obj
		//IL_02de: Expected Obj, but got I
		//IL_0452: Unknown result type (might be due to invalid IL or missing references)
		//IL_0457: Expected Obj, but got Unknown
		//IL_0468: Unknown result type (might be due to invalid IL or missing references)
		//IL_046d: Expected VT, but got Unknown
		//IL_047a: Expected F4, but got Obj
		//IL_0475: Expected native int or pointer, but got VT
		//IL_0483: Unknown result type (might be due to invalid IL or missing references)
		//IL_0488: Expected Obj, but got Unknown
		//IL_04a3: Expected I, but got Obj
		//IL_04b9: Expected Obj, but got I
		//IL_0308: Expected F4, but got Obj
		//IL_0303: Expected native int or pointer, but got VT
		//IL_031d: Expected F4, but got I
		//IL_0318: Expected native int or pointer, but got VT
		//IL_0326: Expected Ref, but got VT
		//IL_0013: Expected I, but got Obj
		//IL_035c: Expected I, but got Obj
		//IL_0372: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_04e4: Expected I, but got Obj
		//IL_04fa: Expected Obj, but got I
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_013b: Expected I, but got Obj
		//IL_039d: Expected I, but got Obj
		//IL_03b3: Expected Obj, but got I
		//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cc: Expected Obj, but got Unknown
		//IL_03d6: Expected Obj, but got F4
		//IL_03e4: Expected I, but got Obj
		//IL_03fa: Expected Obj, but got I
		//IL_0188: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_051d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0522: Expected Obj, but got Unknown
		//IL_0535: Expected Obj, but got I4
		//IL_054a: Expected F4, but got Obj
		//IL_0545: Expected native int or pointer, but got VT
		//IL_0558: Expected VT, but got F4
		//IL_01d5: Expected I, but got Obj
		//IL_01eb: Expected Obj, but got I
		//IL_0263: Expected I, but got Obj
		//IL_0425: Expected I, but got Obj
		//IL_043b: Expected Obj, but got I
		//IL_0216: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		obj = eventType;
		nint num = (nint)typeof(Vector2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11 (Il2CppClass<UnityEngine.Vector2>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v102 (Il2CppClass<UnityEngine.Vector2>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = obj2 + 8;
		obj4 = obj;
		Vector4 vector = (Vector4)(obj2 + 36);
		((Vector4*)(nint)vector)->x = (float)obj4;
		object obj5 = obj2 + 24;
		Vector3 vector2 = vector;
		nint num3 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v22 (Il2CppClass<UICamera>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num4 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v98 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Vector4*)(nint)vector)->x = (float)obj5;
		Vector4 vector3 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v20+8]");
		((Vector4*)(nint)vector3)->z = 0f;
		if (!IsVisible(ref *(DepthEntry*)vector))
		{
			nint num5 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v84 (Il2CppClass<UICamera>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num6 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v92 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num7 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v89 (Il2CppClass<UICamera>)+5C]");
			object obj8 = (nint)0 + (nint)304;
			obj8 = fallThrough;
		}
		nint num8 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v33 (Il2CppClass<UICamera>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num9 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v77 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num10 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S1_v24 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num11 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S1_v49 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (mRayHitObject != null)
		{
			nint num12 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S0_v63 (Il2CppClass<UICamera>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			if (obj11 != null)
			{
				nint num13 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S0_v71 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num14 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S0_v68 (Il2CppClass<UICamera>)+5C]");
			object obj12 = (nint)0 + (nint)304;
			obj12 = mGenericHandler;
		}
		object obj13 = this + 48;
		obj13 = touchDragThreshold;
		nint num15 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ S0_v45 (Il2CppClass<UICamera>)+BA]");
		object obj14 = (nint)0 & (nint)0x200;
		if (obj14 != null)
		{
			nint num16 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ S0_v56 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj15 = this + 52;
		obj15 = mRayHitObject;
		obj = eventType;
		obj2 = obj;
		((Vector4*)(nint)vector)->x = (float)obj2;
		mLastPos = (Vector2)vector.x;
	}

	private unsafe void OnEnable()
	{
		//IL_02c9: Expected I, but got Obj
		//IL_02df: Expected Obj, but got I
		//IL_008b: Expected I, but got Obj
		//IL_00a1: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0119: Expected I, but got Obj
		//IL_012f: Expected Obj, but got I
		//IL_00cc: Expected I, but got Obj
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		//IL_035b: Expected Obj, but got Unknown
		//IL_036c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0371: Expected Obj, but got Unknown
		//IL_0388: Expected I, but got Obj
		//IL_039e: Expected Obj, but got I
		//IL_03c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c9: Expected Obj, but got Unknown
		//IL_03d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d7: Expected Obj, but got Unknown
		//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e5: Expected VT, but got Unknown
		//IL_03f2: Expected F4, but got Obj
		//IL_03ed: Expected native int or pointer, but got VT
		//IL_0408: Unknown result type (might be due to invalid IL or missing references)
		//IL_040d: Expected Obj, but got Unknown
		//IL_0427: Expected F4, but got Obj
		//IL_0422: Expected native int or pointer, but got VT
		//IL_043a: Expected Obj, but got I4
		//IL_015a: Expected I, but got Obj
		//IL_05b1: Expected I, but got Obj
		//IL_05c7: Expected Obj, but got I
		//IL_01a7: Expected I, but got Obj
		//IL_0554: Unknown result type (might be due to invalid IL or missing references)
		//IL_0559: Expected Obj, but got Unknown
		//IL_0571: Expected Obj, but got I
		//IL_057a: Unknown result type (might be due to invalid IL or missing references)
		//IL_057f: Expected Obj, but got Unknown
		//IL_0594: Expected F4, but got Obj
		//IL_058f: Expected native int or pointer, but got VT
		//IL_05a2: Expected VT, but got F4
		//IL_0273: Expected I, but got Obj
		//IL_0449: Unknown result type (might be due to invalid IL or missing references)
		//IL_044e: Expected Obj, but got Unknown
		//IL_047b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0480: Expected Obj, but got Unknown
		//IL_0498: Expected Obj, but got I
		//IL_04ad: Expected F4, but got Obj
		//IL_04a8: Expected native int or pointer, but got VT
		//IL_04c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c6: Expected Obj, but got Unknown
		//IL_04f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f8: Expected Obj, but got Unknown
		//IL_0510: Expected Obj, but got I
		//IL_0525: Expected F4, but got Obj
		//IL_0520: Expected native int or pointer, but got VT
		//IL_0538: Unknown result type (might be due to invalid IL or missing references)
		//IL_053d: Expected Obj, but got Unknown
		//IL_020d: Expected I, but got Obj
		int height = Screen.height;
		nint num = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v11 (Il2CppClass<UICamera>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v101 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		mWidth = height;
		int sleepTimeout = Screen.sleepTimeout;
		mHeight = sleepTimeout;
		string dataPath = Application.dataPath;
		if ((nint)dataPath != 25)
		{
			string dataPath2 = Application.dataPath;
			if ((nint)dataPath2 != 27)
			{
				goto IL_010b;
			}
		}
		nint num3 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v89 (Il2CppClass<UICamera>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v94 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		currentKey = (KeyCode)2;
		goto IL_010b;
		IL_010b:
		nint num5 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v27 (Il2CppClass<UICamera>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v81 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = mMouse + 16;
		object obj5 = obj4;
		object obj7 = default;
		object obj6 = obj7 + 24;
		Vector2 mouseScrollDelta = Input.mouseScrollDelta;
		nint num7 = (nint)typeof(Vector2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S1_v13 (Il2CppClass<UnityEngine.Vector2>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num8 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S1_v61 (Il2CppClass<UnityEngine.Vector2>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj9 = obj7 + 40;
		object obj10 = obj7 + 16;
		Vector2 vector = (Vector2)(obj7 + 56);
		((Vector2*)(nint)vector)->x = (float)obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S1_v11+8]");
		_ = 0;
		object obj11 = obj7 + 48;
		Vector3 vector2 = vector;
		((Vector2*)(nint)vector)->x = (float)obj11;
		_ = vector.x;
		object obj12 = 1;
		bool flag;
		while (true)
		{
			nint num9 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S0_v39 (Il2CppClass<UICamera>)+BA]");
			object obj13 = (nint)0 & (nint)0x200;
			flag = obj13 != null;
			if ((nint)obj12 > 2)
			{
				break;
			}
			if (flag)
			{
				nint num10 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ S0_v75 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj14 = mMouse + 16;
			object obj15 = obj12 << 2;
			object obj16 = obj14 + obj15;
			object obj17 = obj16;
			object obj18 = mMouse + 16;
			object obj19 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ S2_v28+C]");
			obj6 = 0;
			obj9 = obj6;
			((Vector2*)(nint)vector)->x = (float)obj9;
			_ = vector.x;
			object obj20 = mMouse + 16;
			object obj21 = obj12 << 2;
			object obj22 = obj20 + obj21;
			object obj23 = obj22;
			object obj24 = mMouse + 16;
			object obj25 = obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ S2_v40+C]");
			obj7 = 0;
			obj10 = obj7;
			((Vector2*)(nint)vector)->x = (float)obj10;
			_ = vector.x;
			object obj26 = obj12 + 1;
			obj12 = obj26;
		}
		if (flag)
		{
			nint num11 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ S0_v52 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj27 = mMouse + 16;
		object obj28 = obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ S1_v37+C]");
		obj6 = 0;
		object obj29 = obj7 + 8;
		obj29 = obj6;
		((Vector2*)(nint)vector)->x = (float)obj29;
		mLastPos = (Vector2)vector.x;
	}

	private void OnDisable()
	{
		//IL_0061: Expected I, but got Obj
		//IL_0077: Expected Obj, but got I
		//IL_009f: Expected I4, but got Obj
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		//IL_00ce: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UICamera>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v17 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((BetterList<>)(object)list).RemoveAt((int)this);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		_ = 0;
		BetterList<UICamera>.CompareFunc compareFunc = default;
		object obj2 = compareFunc + 16;
		obj2 = 0;
		list.Sort(compareFunc);
	}

	private void Start()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UICamera>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num3 = ((BetterList<>.CompareFunc)(object)list).EndInvoke((IAsyncResult)this);
	}

	private void Update()
	{
		//IL_0305: Expected I, but got Obj
		//IL_031b: Expected Obj, but got I
		//IL_04d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d6: Expected Obj, but got Unknown
		//IL_04df: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0065: Expected Obj, but got I4
		//IL_00c4: Expected I, but got Obj
		//IL_00da: Expected Obj, but got I
		//IL_036c: Expected I, but got Obj
		//IL_0382: Expected Obj, but got I
		//IL_0105: Expected I, but got Obj
		//IL_00b1: Expected Obj, but got I4
		//IL_03b3: Expected Obj, but got I4
		//IL_0152: Expected I, but got Obj
		//IL_01a9: Expected I, but got Obj
		//IL_01bf: Expected Obj, but got I
		//IL_03d3: Expected I, but got Obj
		//IL_03e9: Expected Obj, but got I
		//IL_01ea: Expected I, but got Obj
		//IL_0237: Expected I, but got Obj
		//IL_044c: Expected I, but got Obj
		//IL_0462: Expected Obj, but got I
		//IL_047f: Expected I, but got Obj
		//IL_04a3: Expected Obj, but got I
		//IL_029b: Expected I, but got Obj
		//IL_02cb: Expected I, but got Obj
		//IL_02f1: Expected I, but got Obj
		nint num = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UICamera>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v75 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		_ = 0;
		BetterList<UICamera>.CompareFunc compareFunc = default;
		object obj2 = compareFunc + 16;
		obj2 = 0;
		list.Sort(compareFunc);
		if (eventType != EventType.World_3D)
		{
			bool flag = IsPartOfUI((GameObject)(object)this);
			int cullingMask = ((Camera)flag).cullingMask;
			if (cullingMask != 2)
			{
				bool flag2 = IsPartOfUI((GameObject)(object)this);
				((Camera)flag2).cullingMask = 2;
			}
		}
		if (Application.platform == RuntimePlatform.OSXEditor)
		{
			return;
		}
		nint num4 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v20 (Il2CppClass<UICamera>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num5 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v63 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num6 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S1_v17 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num7 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S1_v43 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (fallThrough != null)
		{
			string go = tag;
			nint num8 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S1_v27 (Il2CppClass<NGUITools>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num9 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S1_v39 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UIRoot uIRoot = NGUITools.FindInParents<UIRoot>((GameObject)(object)go);
			nint num10 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S0_v35 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num11 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S0_v59 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Component component = ((((ComputeShader)(object)uIRoot).FindKernel((string)null) == 0) ? ((MonoBehaviour)this) : ((MonoBehaviour)uIRoot));
			string text = component.tag;
			nint num12 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ S0_v44 (Il2CppClass<UICamera>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			bool flag3 = obj7 == null;
			nint num13 = (nint)typeof(UICamera);
			if (!flag3)
			{
				nint num14 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ S0_v51 (Il2CppClass<UICamera>)+74]");
				bool flag4 = (nint)0 == 0;
				bool flag5 = !flag4;
				num13 = (nint)typeof(UICamera);
				if (!flag5)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num13 = (nint)typeof(UICamera);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ L1_v11 (Il2CppClass<UICamera>)+5C]");
			object obj8 = (nint)0 + (nint)172;
			obj8 = text;
		}
		bool flag6 = IsPartOfUI((GameObject)(object)this);
		((Camera)flag6).SetLayerCullDistances((float[])null);
	}

	private void LateUpdate()
	{
		//IL_00bc: Expected I, but got Obj
		//IL_00d2: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UICamera>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v21 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(ignoreAllEvents ? 1u : 0u) != 0)
		{
			Camera camera = cachedCamera;
			if ((object)camera != null && processEventsIn == ProcessEventsIn.Update)
			{
				ProcessMouse();
			}
		}
	}

	private void ProcessEvents()
	{
		//IL_005f: Expected I, but got Obj
		//IL_0075: Expected Obj, but got I
		//IL_017b: Expected I, but got Obj
		//IL_0191: Expected Obj, but got I
		//IL_00a0: Expected I, but got Obj
		//IL_0362: Expected I, but got Obj
		//IL_0378: Expected Obj, but got I
		//IL_00ed: Expected I, but got Obj
		//IL_0103: Expected Obj, but got I
		//IL_01bc: Expected I, but got Obj
		//IL_0209: Expected I, but got Obj
		//IL_012e: Expected I, but got Obj
		//IL_0256: Expected I, but got Obj
		//IL_026c: Expected Obj, but got I
		//IL_0297: Expected I, but got Obj
		Camera camera = cachedCamera;
		if ((object)camera == null)
		{
			return;
		}
		if (processEventsIn == ProcessEventsIn.LateUpdate)
		{
			ProcessMouse();
		}
		int height = Screen.height;
		int sleepTimeout = Screen.sleepTimeout;
		nint num = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v17 (Il2CppClass<UICamera>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v82 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (height == mWidth)
		{
			nint num3 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v70 (Il2CppClass<UICamera>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v76 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (sleepTimeout == mHeight)
			{
				return;
			}
		}
		nint num5 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v25 (Il2CppClass<UICamera>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v63 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		mWidth = height;
		mHeight = sleepTimeout;
		nint num7 = (nint)typeof(UIRoot);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v35 (Il2CppClass<UIRoot>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num8 = (nint)typeof(UIRoot);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v59 (Il2CppClass<UIRoot>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((UIRoot)(object)"UpdateAnchors")._002Ector();
		if (onScreenResize == null)
		{
			return;
		}
		nint num9 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S0_v46 (Il2CppClass<UICamera>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num10 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S0_v53 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
	}

	public void ProcessMouse()
	{
		//IL_0ccd: Expected I, but got Obj
		//IL_0ce3: Expected Obj, but got I
		//IL_0d00: Expected I, but got Obj
		//IL_11f1: Expected Obj, but got I
		//IL_1218: Expected I, but got Obj
		//IL_122e: Expected Obj, but got I
		//IL_1380: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0043: Expected I, but got Obj
		//IL_007c: Expected I, but got Obj
		//IL_0d1c: Expected I, but got Obj
		//IL_0d32: Expected Obj, but got I
		//IL_0069: Expected I, but got Obj
		//IL_00f8: Expected I, but got Obj
		//IL_01f8: Expected I, but got Obj
		//IL_020e: Expected Obj, but got I
		//IL_0145: Expected I, but got Obj
		//IL_015b: Expected Obj, but got I
		//IL_0239: Expected I, but got Obj
		//IL_0186: Expected I, but got Obj
		//IL_0f60: Expected I, but got Obj
		//IL_0f76: Expected Obj, but got I
		//IL_0286: Expected I, but got Obj
		//IL_029c: Expected Obj, but got I
		//IL_12e4: Expected I, but got Obj
		//IL_12fa: Expected Obj, but got I
		//IL_031f: Expected I, but got Obj
		//IL_0335: Expected Obj, but got I
		//IL_0a61: Expected I, but got Obj
		//IL_0dd9: Expected I, but got Obj
		//IL_0def: Expected Obj, but got I
		//IL_02c7: Expected I, but got Obj
		//IL_114a: Expected I, but got Obj
		//IL_1160: Expected Obj, but got I
		//IL_117d: Expected I, but got Obj
		//IL_0aae: Expected I, but got Obj
		//IL_0360: Expected I, but got Obj
		//IL_132d: Expected Obj, but got I
		//IL_1336: Expected Obj, but got I4
		//IL_0afb: Expected I, but got Obj
		//IL_0b11: Expected Obj, but got I
		//IL_03ad: Expected I, but got Obj
		//IL_0c64: Expected I, but got Obj
		//IL_0c94: Expected I, but got Obj
		//IL_1199: Expected I, but got Obj
		//IL_11af: Expected Obj, but got I
		//IL_0b3c: Expected I, but got Obj
		//IL_0cba: Expected I, but got Obj
		//IL_0b89: Expected I, but got Obj
		//IL_0bd6: Expected I, but got Obj
		//IL_0bec: Expected Obj, but got I
		//IL_12a3: Expected I, but got Obj
		//IL_12b9: Expected Obj, but got I
		//IL_044a: Expected I, but got Obj
		//IL_0460: Expected Obj, but got I
		//IL_0c17: Expected I, but got Obj
		//IL_064e: Expected I, but got Obj
		//IL_069b: Expected I, but got Obj
		//IL_06b1: Expected Obj, but got I
		//IL_048b: Expected I, but got Obj
		//IL_04d8: Expected I, but got Obj
		//IL_04ee: Expected Obj, but got I
		//IL_06dc: Expected I, but got Obj
		//IL_0729: Expected I, but got Obj
		//IL_073f: Expected Obj, but got I
		//IL_05da: Expected I, but got Obj
		//IL_05f0: Expected Obj, but got I
		//IL_0519: Expected I, but got Obj
		//IL_0ea4: Expected Obj, but got F4
		//IL_0ec1: Expected I4, but got Obj
		//IL_0566: Expected I, but got Obj
		//IL_057c: Expected Obj, but got I
		//IL_076a: Expected I, but got Obj
		//IL_061b: Expected I, but got Obj
		//IL_07b7: Expected I, but got Obj
		//IL_07cd: Expected Obj, but got I
		//IL_05a7: Expected I, but got Obj
		//IL_07f8: Expected I, but got Obj
		//IL_082b: Expected I, but got Obj
		//IL_0841: Expected Obj, but got I
		//IL_0f9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa2: Expected Obj, but got Unknown
		//IL_0fb8: Expected I, but got Obj
		//IL_0fce: Expected Obj, but got I
		//IL_0ffd: Expected Obj, but got I
		//IL_086c: Expected I, but got Obj
		//IL_089f: Expected I, but got Obj
		//IL_08d2: Expected I, but got Obj
		//IL_08e8: Expected Obj, but got I
		//IL_1085: Expected I, but got Obj
		//IL_109b: Expected Obj, but got I
		//IL_0913: Expected I, but got Obj
		//IL_10f2: Expected I, but got Obj
		//IL_1108: Expected Obj, but got I
		//IL_1112: Unknown result type (might be due to invalid IL or missing references)
		//IL_1117: Expected Obj, but got Unknown
		//IL_0946: Expected I, but got Obj
		//IL_095c: Expected Obj, but got I
		//IL_0a2e: Expected I, but got Obj
		//IL_1065: Expected Obj, but got I4
		//IL_0987: Expected I, but got Obj
		//IL_09ba: Expected I, but got Obj
		//IL_09d0: Expected Obj, but got I
		//IL_10c7: Expected Obj, but got I4
		//IL_09fb: Expected I, but got Obj
		nint num = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UICamera>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		bool flag = obj == null;
		nint num2 = (nint)typeof(UICamera);
		if (!flag)
		{
			nint num3 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v370 (Il2CppClass<UICamera>)+74]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			num2 = (nint)typeof(UICamera);
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num2 = (nint)typeof(UICamera);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ L1_v2 (Il2CppClass<UICamera>)+5C]");
		object obj2 = (nint)0 + (nint)136;
		obj2 = this;
		bool flag4 = debug;
		nint num4 = (nint)typeof(NGUIDebug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S1_v8 (Il2CppClass<NGUIDebug>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num5 = (nint)typeof(NGUIDebug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S1_v117 (Il2CppClass<NGUIDebug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		NGUIDebug.LogString((string)flag4);
		if (~(useTouch ? 1u : 0u) == 0)
		{
			ProcessFakeTouches();
		}
		else if (~(useMouse ? 1u : 0u) == 0)
		{
			ProcessTouches();
		}
		nint num6 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v23 (Il2CppClass<UICamera>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num7 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v360 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (onCustomInput != null)
		{
			nint num8 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v347 (Il2CppClass<UICamera>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num9 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v354 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			onCustomInput();
		}
		if (useKeyboard || useController)
		{
			nint num10 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v317 (Il2CppClass<UICamera>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num11 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S0_v340 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UICamera uICamera = first;
			if ((object)uICamera == null)
			{
				nint num12 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ S0_v325 (Il2CppClass<UICamera>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num13 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ S0_v334 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (~(ignoreControllerInput ? 1u : 0u) != 0)
				{
					this._002Ector();
				}
			}
		}
		if (~(useMouse ? 1u : 0u) == 0)
		{
			nint num14 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S0_v99 (Il2CppClass<UICamera>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num15 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ S0_v309 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num16 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ S1_v49 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num17 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ S1_v106 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)mHover).FindKernel((string)null) != 0)
			{
				string text = scrollAxisName;
				if (scrollAxisName != null && text.m_stringLength != 0)
				{
					nint num18 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ S0_v249 (Il2CppClass<UICamera>)+BA]");
					object obj10 = (nint)0 & (nint)0x200;
					if (obj10 != null)
					{
						nint num19 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ S0_v299 (Il2CppClass<UICamera>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					float num20 = GetAxis.EndInvoke((IAsyncResult)(object)scrollAxisName);
					if (num20 != 0f)
					{
						nint num21 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ S0_v259 (Il2CppClass<UICamera>)+BA]");
						object obj11 = (nint)0 & (nint)0x200;
						if (obj11 != null)
						{
							nint num22 = (nint)typeof(UICamera);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v467 @ S0_v293 (Il2CppClass<UICamera>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						if (onScroll != null)
						{
							nint num23 = (nint)typeof(UICamera);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ S0_v281 (Il2CppClass<UICamera>)+BA]");
							object obj12 = (nint)0 & (nint)0x200;
							if (obj12 != null)
							{
								nint num24 = (nint)typeof(UICamera);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v524 @ S0_v288 (Il2CppClass<UICamera>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A07B");
						}
						nint num25 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ S0_v268 (Il2CppClass<UICamera>)+BA]");
						object obj13 = (nint)0 & (nint)0x200;
						if (obj13 != null)
						{
							nint num26 = (nint)typeof(UICamera);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v534 @ S0_v275 (Il2CppClass<UICamera>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						object obj14 = num20;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
						bool released = default;
						((UICamera)(object)mHover).ProcessTouch((byte)(int)"OnScroll" != 0, released);
					}
				}
				nint num27 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ S0_v113 (Il2CppClass<UICamera>)+BA]");
				object obj15 = (nint)0 & (nint)0x200;
				if (obj15 != null)
				{
					nint num28 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ S0_v244 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (currentKey == KeyCode.None)
				{
					nint num29 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v462 @ S0_v121 (Il2CppClass<UICamera>)+BA]");
					object obj16 = (nint)0 & (nint)0x200;
					if (obj16 != null)
					{
						nint num30 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ S0_v238 (Il2CppClass<UICamera>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (~(showTooltips ? 1u : 0u) == 0)
					{
						nint num31 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ S0_v129 (Il2CppClass<UICamera>)+BA]");
						object obj17 = (nint)0 & (nint)0x200;
						if (obj17 != null)
						{
							nint num32 = (nint)typeof(UICamera);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ S0_v232 (Il2CppClass<UICamera>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						if (mTooltipTime != 0f)
						{
							nint num33 = (nint)typeof(UIPopupList);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ S0_v138 (Il2CppClass<UIPopupList>)+BA]");
							object obj18 = (nint)0 & (nint)0x200;
							if (obj18 != null)
							{
								nint num34 = (nint)typeof(UIPopupList);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v570 @ S0_v229 (Il2CppClass<UIPopupList>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							Dictionary<string, string[]> dictionary = Localization.dictionary;
							if (dictionary == null)
							{
								nint num35 = (nint)typeof(UICamera);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v576 @ S0_v145 (Il2CppClass<UICamera>)+BA]");
								object obj19 = (nint)0 & (nint)0x200;
								if (obj19 != null)
								{
									nint num36 = (nint)typeof(UICamera);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v582 @ S0_v224 (Il2CppClass<UICamera>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								object obj20 = mMouse + 16;
								object obj21 = obj20;
								nint num37 = (nint)typeof(UnityEngine.Object);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v596 @ S1_v63 (Il2CppClass<UnityEngine.Object>)+BA]");
								object obj22 = (nint)0 & (nint)0x200;
								if (obj22 != null)
								{
									nint num38 = (nint)typeof(UnityEngine.Object);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v601 @ S1_v85 (Il2CppClass<UnityEngine.Object>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v593 @ S0_v153+3C]");
								if ((UnityEngine.Object)0 != null)
								{
									nint num39 = (nint)typeof(UICamera);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v608 @ S0_v158 (Il2CppClass<UICamera>)+BA]");
									object obj23 = (nint)0 & (nint)0x200;
									if (obj23 != null)
									{
										nint num40 = (nint)typeof(UICamera);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v614 @ S0_v219 (Il2CppClass<UICamera>)+74]");
										if ((nint)0 == 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
										}
									}
									float unscaledDeltaTime = Time.unscaledDeltaTime;
									if (!(mTooltipTime < unscaledDeltaTime))
									{
										nint num41 = (nint)typeof(UICamera);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v631 @ S0_v191 (Il2CppClass<UICamera>)+BA]");
										object obj24 = (nint)0 & (nint)0x200;
										if (obj24 != null)
										{
											nint num42 = (nint)typeof(UICamera);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ S0_v214 (Il2CppClass<UICamera>)+74]");
											if ((nint)0 == 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
											}
										}
										if (!GetKey.EndInvoke((IAsyncResult)304))
										{
											nint num43 = (nint)typeof(UICamera);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v687 @ S0_v200 (Il2CppClass<UICamera>)+BA]");
											object obj25 = (nint)0 & (nint)0x200;
											if (obj25 != null)
											{
												nint num44 = (nint)typeof(UICamera);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v693 @ S0_v209 (Il2CppClass<UICamera>)+74]");
												if ((nint)0 == 0)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
												}
											}
											if (!GetKey.EndInvoke((IAsyncResult)303))
											{
												goto IL_0f52;
											}
										}
									}
									nint num45 = (nint)typeof(UICamera);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v647 @ S0_v169 (Il2CppClass<UICamera>)+BA]");
									object obj26 = (nint)0 & (nint)0x200;
									if (obj26 != null)
									{
										nint num46 = (nint)typeof(UICamera);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v660 @ S0_v185 (Il2CppClass<UICamera>)+74]");
										if ((nint)0 == 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
										}
									}
									nint num47 = (nint)typeof(UICamera);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v666 @ S0_v174 (Il2CppClass<UICamera>)+5C]");
									object obj27 = (nint)0 + (nint)160;
									object obj28 = mMouse + 16;
									obj27 = obj28;
									currentTouchID = -1;
									BMFont bmFont = ((UIFont)(object)mHover).bmFont;
								}
							}
						}
					}
				}
			}
		}
		goto IL_0f52;
		IL_0f52:
		nint num48 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ S0_v38 (Il2CppClass<UICamera>)+BA]");
		object obj29 = (nint)0 & (nint)0x200;
		if (obj29 != null)
		{
			nint num49 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ S0_v92 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num50 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ S1_v20 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj30 = (nint)0 & (nint)0x200;
		if (obj30 != null)
		{
			nint num51 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ S1_v43 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)mTooltip).FindKernel((string)null) != 0)
		{
			nint num52 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ S0_v66 (Il2CppClass<UICamera>)+BA]");
			object obj31 = (nint)0 & (nint)0x200;
			if (obj31 != null)
			{
				nint num53 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ S0_v86 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num54 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ S1_v32 (Il2CppClass<NGUITools>)+BA]");
			object obj32 = (nint)0 & (nint)0x200;
			if (obj32 != null)
			{
				nint num55 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ S1_v39 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			byte[] array = NGUITools.Load((string)(object)mTooltip);
			if (array == null)
			{
				nint num56 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ S0_v76 (Il2CppClass<UICamera>)+BA]");
				object obj33 = (nint)0 & (nint)0x200;
				if (obj33 != null)
				{
					nint num57 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ S0_v82 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				BMFont bmFont2 = ((UIFont)null).bmFont;
			}
		}
		nint num58 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ S0_v48 (Il2CppClass<UICamera>)+BA]");
		object obj34 = (nint)0 & (nint)0x200;
		bool flag5 = obj34 == null;
		nint num59 = (nint)typeof(UICamera);
		if (!flag5)
		{
			nint num60 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ S0_v59 (Il2CppClass<UICamera>)+74]");
			bool flag6 = (nint)0 == 0;
			bool flag7 = !flag6;
			num59 = (nint)typeof(UICamera);
			if (!flag7)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num59 = (nint)typeof(UICamera);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ L0_v7 (Il2CppClass<UICamera>)+5C]");
		object obj35 = (nint)0 + (nint)136;
		obj35 = 0;
		currentTouchID = -100;
	}

	public unsafe void ProcessTouches()
	{
		//IL_017b: Expected I, but got Obj
		//IL_0191: Expected Obj, but got I
		//IL_14bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_14c2: Expected VT, but got Unknown
		//IL_14cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_14d0: Expected VT, but got Unknown
		//IL_14d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_14de: Expected Obj, but got Unknown
		//IL_14e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_14ec: Expected Obj, but got Unknown
		//IL_14f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_14fa: Expected Obj, but got Unknown
		//IL_1503: Unknown result type (might be due to invalid IL or missing references)
		//IL_1508: Expected Obj, but got Unknown
		//IL_1511: Unknown result type (might be due to invalid IL or missing references)
		//IL_1516: Expected Obj, but got Unknown
		//IL_151f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1524: Expected Obj, but got Unknown
		//IL_152d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1532: Expected Obj, but got Unknown
		//IL_153b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1540: Expected Obj, but got Unknown
		//IL_1549: Unknown result type (might be due to invalid IL or missing references)
		//IL_154e: Expected Obj, but got Unknown
		//IL_029c: Expected I, but got Obj
		//IL_02b2: Expected Obj, but got I
		//IL_01bc: Expected I, but got Obj
		//IL_15b1: Expected I, but got Obj
		//IL_15c7: Expected Obj, but got I
		//IL_15d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_15d6: Expected Obj, but got Unknown
		//IL_15f5: Expected I, but got Obj
		//IL_160b: Expected Obj, but got I
		//IL_0209: Expected I, but got Obj
		//IL_021f: Expected Obj, but got I
		//IL_0039: Expected I, but got Obj
		//IL_004f: Expected Obj, but got I
		//IL_1635: Expected native int or pointer, but got VT
		//IL_1662: Expected I, but got Obj
		//IL_1678: Expected Obj, but got I
		//IL_02dd: Expected I, but got Obj
		//IL_00ed: Expected I, but got Obj
		//IL_0103: Expected Obj, but got I
		//IL_1485: Expected Obj, but got I4
		//IL_032a: Expected I, but got Obj
		//IL_024a: Expected I, but got Obj
		//IL_14af: Expected Obj, but got I4
		//IL_007a: Expected I, but got Obj
		//IL_172c: Expected Obj, but got VT
		//IL_173a: Expected I, but got Obj
		//IL_1750: Expected Obj, but got I
		//IL_012e: Expected I, but got Obj
		//IL_20d5: Expected F4, but got Obj
		//IL_20d0: Expected native int or pointer, but got VT
		//IL_20e2: Expected F4, but got Obj
		//IL_20dd: Expected native int or pointer, but got VT
		//IL_2108: Expected F4, but got Obj
		//IL_2103: Expected native int or pointer, but got VT
		//IL_211a: Expected VT, but got F4
		//IL_040c: Expected I, but got Obj
		//IL_16e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_16ea: Expected Obj, but got Unknown
		//IL_16f3: Expected Obj, but got F4
		//IL_16fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1702: Expected Obj, but got Unknown
		//IL_2085: Expected I, but got Obj
		//IL_209b: Expected Obj, but got I
		//IL_0459: Expected I, but got Obj
		//IL_039b: Expected I, but got Obj
		//IL_1777: Unknown result type (might be due to invalid IL or missing references)
		//IL_177c: Expected Obj, but got Unknown
		//IL_17a6: Expected Obj, but got I
		//IL_17d1: Expected F4, but got Obj
		//IL_17cc: Expected native int or pointer, but got VT
		//IL_17e3: Expected VT, but got F4
		//IL_17f8: Expected F4, but got Obj
		//IL_17f3: Expected native int or pointer, but got VT
		//IL_1806: Expected VT, but got F4
		//IL_0599: Invalid comparison between Obj and F4
		//IL_04a6: Expected I, but got Obj
		//IL_05cf: Expected Obj, but got I4
		//IL_04ee: Invalid comparison between Obj and F4
		//IL_184c: Expected Obj, but got I4
		//IL_05c1: Expected Obj, but got I4
		//IL_0510: Expected I, but got Obj
		//IL_0526: Expected Obj, but got I
		//IL_183e: Expected Obj, but got I4
		//IL_06e3: Expected I, but got Obj
		//IL_06f9: Expected Obj, but got I
		//IL_05e2: Expected I, but got Obj
		//IL_05f8: Expected Obj, but got I
		//IL_0551: Expected I, but got Obj
		//IL_185b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1860: Expected Obj, but got Unknown
		//IL_189e: Expected F4, but got VT
		//IL_1899: Expected native int or pointer, but got VT
		//IL_18ab: Expected Obj, but got F4
		//IL_18b8: Expected F4, but got Obj
		//IL_18b3: Expected native int or pointer, but got VT
		//IL_18cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_18d1: Expected Obj, but got Unknown
		//IL_190a: Expected Obj, but got VT
		//IL_191f: Expected F4, but got Obj
		//IL_191a: Expected native int or pointer, but got VT
		//IL_1932: Unknown result type (might be due to invalid IL or missing references)
		//IL_1937: Expected Obj, but got Unknown
		//IL_19ba: Expected I, but got Obj
		//IL_19d0: Expected Obj, but got I
		//IL_0724: Expected I, but got Obj
		//IL_0623: Expected I, but got Obj
		//IL_21a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_21ac: Expected Obj, but got Unknown
		//IL_21cb: Expected I, but got Obj
		//IL_21e1: Expected Obj, but got I
		//IL_076c: Expected Obj, but got I4
		//IL_06ad: Expected Obj, but got I4
		//IL_2311: Expected Obj, but got I
		//IL_081b: Expected I, but got Obj
		//IL_1952: Expected I, but got Obj
		//IL_1968: Expected Obj, but got I
		//IL_0868: Expected I, but got Obj
		//IL_078d: Expected I, but got Obj
		//IL_07a3: Expected Obj, but got I
		//IL_216a: Expected I, but got Obj
		//IL_2180: Expected Obj, but got I
		//IL_08b5: Expected I, but got Obj
		//IL_08cb: Expected Obj, but got I
		//IL_19f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_19fc: Expected Obj, but got Unknown
		//IL_1a20: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a25: Expected Obj, but got Unknown
		//IL_1a44: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a49: Expected Obj, but got Unknown
		//IL_077a: Expected Obj, but got I4
		//IL_22d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_22da: Expected I4, but got Unknown
		//IL_09ca: Expected I, but got Obj
		//IL_1a68: Expected Obj, but got I4
		//IL_07ce: Expected I, but got Obj
		//IL_0af2: Expected I, but got Obj
		//IL_0b08: Expected Obj, but got I
		//IL_0a17: Expected I, but got Obj
		//IL_08f6: Expected I, but got Obj
		//IL_0a64: Expected I, but got Obj
		//IL_0a7a: Expected Obj, but got I
		//IL_0948: Expected I, but got Obj
		//IL_095e: Expected Obj, but got I
		//IL_0c09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c0e: Expected Obj, but got Unknown
		//IL_0b33: Expected I, but got Obj
		//IL_1a77: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a7c: Expected Obj, but got Unknown
		//IL_1aa0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1aa5: Expected Obj, but got Unknown
		//IL_1ac4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ac9: Expected Obj, but got Unknown
		//IL_0b80: Expected I, but got Obj
		//IL_0b96: Expected Obj, but got I
		//IL_0aa5: Expected I, but got Obj
		//IL_0989: Expected I, but got Obj
		//IL_09b7: Expected Obj, but got I4
		//IL_0c5a: Expected Obj, but got I4
		//IL_0c62: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c67: Expected I4, but got Unknown
		//IL_0e9e: Expected I, but got Obj
		//IL_0eb4: Expected Obj, but got I
		//IL_0bc1: Expected I, but got Obj
		//IL_0f80: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f85: Expected I4, but got Unknown
		//IL_0f94: Expected Obj, but got I4
		//IL_0f9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa1: Expected I4, but got Unknown
		//IL_0c92: Expected I, but got Obj
		//IL_0ca8: Expected Obj, but got I
		//IL_12cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_12d0: Expected I4, but got Unknown
		//IL_0edf: Expected I, but got Obj
		//IL_136f: Expected I, but got Obj
		//IL_1385: Expected Obj, but got I
		//IL_13a2: Expected I, but got Obj
		//IL_0fd7: Expected I, but got Obj
		//IL_0fed: Expected Obj, but got I
		//IL_0f12: Expected I, but got Obj
		//IL_0f28: Expected Obj, but got I
		//IL_0d83: Expected I, but got Obj
		//IL_0d99: Expected Obj, but got I
		//IL_0cd3: Expected I, but got Obj
		//IL_1f77: Expected Obj, but got I
		//IL_1f80: Expected Obj, but got I4
		//IL_1f8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f8f: Expected Obj, but got Unknown
		//IL_1f98: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f9d: Expected Obj, but got Unknown
		//IL_1fa7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fac: Expected Obj, but got Unknown
		//IL_1fc4: Expected Obj, but got I
		//IL_1fcd: Expected Obj, but got I4
		//IL_12fb: Expected I, but got Obj
		//IL_1311: Expected Obj, but got I
		//IL_1069: Expected Obj, but got I4
		//IL_1c44: Expected F4, but got VT
		//IL_1c3f: Expected native int or pointer, but got VT
		//IL_1c51: Expected Obj, but got F4
		//IL_1c5e: Expected F4, but got Obj
		//IL_1c59: Expected native int or pointer, but got VT
		//IL_1c6c: Expected Obj, but got VT
		//IL_1c7a: Expected I, but got Obj
		//IL_1c90: Expected Obj, but got I
		//IL_1c99: Expected Obj, but got I4
		//IL_1b80: Expected I, but got Obj
		//IL_1b96: Expected Obj, but got I
		//IL_0d0f: Expected I, but got Obj
		//IL_0d25: Expected Obj, but got I
		//IL_13be: Expected I, but got Obj
		//IL_13cc: Expected I, but got Obj
		//IL_1ee2: Expected I, but got Obj
		//IL_1ef8: Expected Obj, but got I
		//IL_1f02: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f07: Expected Obj, but got Unknown
		//IL_1108: Expected I, but got Obj
		//IL_111e: Expected Obj, but got I
		//IL_1018: Expected I, but got Obj
		//IL_0f53: Expected I, but got Obj
		//IL_0dc4: Expected I, but got Obj
		//IL_133c: Expected I, but got Obj
		//IL_1cd3: Expected I, but got Obj
		//IL_1ce9: Expected Obj, but got I
		//IL_1cf3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cf8: Expected Obj, but got Unknown
		//IL_1d0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d13: Expected Obj, but got Unknown
		//IL_1d49: Expected I, but got Obj
		//IL_1d5f: Expected Obj, but got I
		//IL_1094: Expected I, but got Obj
		//IL_10aa: Expected Obj, but got I
		//IL_0df7: Expected I, but got Obj
		//IL_0d50: Expected I, but got Obj
		//IL_140d: Expected I, but got Obj
		//IL_1423: Expected Obj, but got I
		//IL_13fa: Expected I, but got Obj
		//IL_1149: Expected I, but got Obj
		//IL_0e2a: Expected I, but got Obj
		//IL_0e40: Expected Obj, but got I
		//IL_1fdc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fe1: Expected Obj, but got Unknown
		//IL_2005: Unknown result type (might be due to invalid IL or missing references)
		//IL_200a: Expected Obj, but got Unknown
		//IL_2014: Unknown result type (might be due to invalid IL or missing references)
		//IL_2019: Expected Obj, but got Unknown
		//IL_2031: Expected Obj, but got I
		//IL_203a: Unknown result type (might be due to invalid IL or missing references)
		//IL_203f: Expected Obj, but got Unknown
		//IL_1ddb: Expected I, but got Obj
		//IL_1df1: Expected Obj, but got I
		//IL_10d5: Expected I, but got Obj
		//IL_144e: Expected I, but got Obj
		//IL_11f7: Expected I, but got Obj
		//IL_1d91: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d96: Expected Obj, but got Unknown
		//IL_1da9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dae: Expected Obj, but got Unknown
		//IL_1dbf: Expected Obj, but got F4
		//IL_0e6b: Expected I, but got Obj
		//IL_1e4b: Expected VT, but got I4
		//IL_1e4b: Expected Obj, but got I4
		//IL_122a: Expected I, but got Obj
		//IL_11a0: Expected I, but got Obj
		//IL_125d: Expected I, but got Obj
		//IL_1273: Expected Obj, but got I
		//IL_1e78: Expected I, but got Obj
		//IL_1e8e: Expected Obj, but got I
		//IL_129e: Expected I, but got Obj
		int num = default;
		object obj2 = default;
		int num6 = default;
		while (num <= 2)
		{
			if (Input.GetMouseButtonUp(num))
			{
				nint num2 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v668 (Il2CppClass<UICamera>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num3 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S0_v676 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Ray ray = currentRay;
				obj2 = 1;
			}
			else if (Input.GetMouseButtonDown(num))
			{
				nint num4 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S0_v656 (Il2CppClass<UICamera>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num5 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ S0_v663 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Ray ray = currentRay;
				obj2 = 1;
			}
			num = num6 + 1;
		}
		nint num7 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v11 (Il2CppClass<UICamera>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num8 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v644 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj5 = default;
		Vector2 vector = (Vector2)(obj5 + 96);
		Vector2 vector2 = (Vector2)(obj5 + 56);
		object obj6 = obj5 + 16;
		object obj7 = obj5 + 88;
		object obj8 = obj5 + 80;
		object obj9 = obj5 + 72;
		object obj10 = obj5 + 48;
		object obj11 = obj5 + 40;
		object obj12 = obj5 + 32;
		object obj13 = obj5 + 24;
		object obj14 = obj5 + 8;
		KeyCode keyCode = currentKey;
		if (keyCode == (KeyCode)1)
		{
			nint num9 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S0_v627 (Il2CppClass<UICamera>)+BA]");
			object obj15 = (nint)0 & (nint)0x200;
			if (obj15 != null)
			{
				nint num10 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ S0_v638 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			List<MouseOrTouch> list = activeTouches;
			if (list._size >= 1)
			{
				return;
			}
		}
		nint num11 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S0_v44 (Il2CppClass<UICamera>)+BA]");
		object obj16 = (nint)0 & (nint)0x200;
		if (obj16 != null)
		{
			nint num12 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S0_v620 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num13 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ S0_v49 (Il2CppClass<UICamera>)+5C]");
		object obj17 = (nint)0 + (nint)160;
		object obj18 = mMouse + 16;
		obj17 = obj18;
		Vector2 mouseScrollDelta = Input.mouseScrollDelta;
		nint num14 = (nint)typeof(Vector2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ S0_v54 (Il2CppClass<UnityEngine.Vector2>)+BA]");
		object obj19 = (nint)0 & (nint)0x200;
		if (obj19 != null)
		{
			nint num15 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ S0_v616 (Il2CppClass<UnityEngine.Vector2>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Vector2*)(nint)vector)->x = vector2.x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v18 (UnityEngine.Vector2)+8]");
		_ = 0;
		Vector3 vector3 = vector;
		nint num16 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ S0_v64 (Il2CppClass<UICamera>)+BA]");
		object obj20 = (nint)0 & (nint)0x200;
		bool flag = obj20 == null;
		MouseOrTouch mouseOrTouch = currentTouch;
		if (mouseOrTouch.ignoreDelta != 0)
		{
			if (!flag)
			{
				nint num17 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ S0_v610 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			MouseOrTouch mouseOrTouch2 = currentTouch;
			int ignoreDelta = mouseOrTouch2.ignoreDelta - 1;
			mouseOrTouch2.ignoreDelta = ignoreDelta;
			object obj21 = currentTouch + 28;
			obj21 = 0f;
			object obj22 = currentTouch + 28;
			_ = 0f;
		}
		else
		{
			if (!flag)
			{
				nint num18 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ S0_v588 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			MouseOrTouch mouseOrTouch3 = currentTouch;
			MouseOrTouch mouseOrTouch4 = currentTouch;
			obj6 = mouseOrTouch4.pos;
			nint num19 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ S1_v271 (Il2CppClass<UnityEngine.Vector2>)+BA]");
			object obj23 = (nint)0 & (nint)0x200;
			if (obj23 != null)
			{
				nint num20 = (nint)typeof(Vector2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ S1_v284 (Il2CppClass<UnityEngine.Vector2>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj7 = obj6;
			obj8 = obj6;
			((Vector2*)(nint)vector2)->x = (float)obj7;
			((Vector2*)(nint)vector)->x = (float)obj8;
			Vector2 vector4 = vector2 * vector;
			obj9 = obj5;
			((Vector2*)(nint)vector)->x = (float)obj9;
			mouseOrTouch3.delta = (Vector2)vector.x;
		}
		nint num21 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ S0_v75 (Il2CppClass<UICamera>)+BA]");
		object obj24 = (nint)0 & (nint)0x200;
		if (obj24 != null)
		{
			nint num22 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ S0_v576 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj25 = currentTouch + 28;
		object obj26 = obj25 * obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ S0_v82+4]");
		nint num23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ S0_v82+4]");
		object obj27 = num23 * 0;
		object obj28 = obj26 + obj27;
		MouseOrTouch mouseOrTouch5 = currentTouch;
		obj10 = obj6;
		((Vector2*)(nint)vector)->x = (float)obj10;
		mouseOrTouch5.pos = (Vector2)vector.x;
		obj11 = obj6;
		((Vector2*)(nint)vector)->x = (float)obj11;
		mLastPos = (Vector2)vector.x;
		object obj29;
		if (currentKey == KeyCode.None)
		{
			obj29 = ((System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj28) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0.001f)) ? ((object)0) : ((object)1));
		}
		else
		{
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj28) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0.001f))
			{
				return;
			}
			nint num24 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v477 @ S0_v566 (Il2CppClass<UICamera>)+BA]");
			object obj30 = (nint)0 & (nint)0x200;
			if (obj30 != null)
			{
				nint num25 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ S0_v572 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Ray ray2 = currentRay;
			obj29 = 1;
		}
		object obj31 = 1;
		while ((nint)obj31 <= 2)
		{
			nint num26 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v521 @ S0_v534 (Il2CppClass<UICamera>)+BA]");
			object obj32 = (nint)0 & (nint)0x200;
			if (obj32 != null)
			{
				nint num27 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v530 @ S0_v553 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj33 = mMouse + 16;
			object obj34 = obj31 << 2;
			object obj35 = obj33 + obj34;
			object obj36 = obj35;
			MouseOrTouch mouseOrTouch6 = currentTouch;
			((Vector2*)(nint)vector2)->x = (float)mouseOrTouch6.pos;
			obj12 = vector2.x;
			((Vector2*)(nint)vector)->x = (float)obj12;
			_ = vector.x;
			object obj37 = mMouse + 16;
			object obj38 = obj31 << 2;
			object obj39 = obj37 + obj38;
			object obj40 = obj39;
			MouseOrTouch mouseOrTouch7 = currentTouch;
			obj6 = mouseOrTouch7.delta;
			obj13 = obj6;
			((Vector2*)(nint)vector)->x = (float)obj13;
			_ = vector.x;
			object obj41 = obj31 + 1;
			obj31 = obj41;
		}
		object obj42 = obj2 | obj29;
		object obj43;
		if (obj42 == null)
		{
			float unscaledDeltaTime = Time.unscaledDeltaTime;
			if (!(mNextRaycast < unscaledDeltaTime))
			{
				obj43 = 0;
				goto IL_1944;
			}
		}
		float unscaledDeltaTime2 = Time.unscaledDeltaTime;
		float num28 = unscaledDeltaTime2 + 0.02f;
		mNextRaycast = num28;
		nint num29 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v600 @ S0_v438 (Il2CppClass<UICamera>)+BA]");
		object obj44 = (nint)0 & (nint)0x200;
		if (obj44 != null)
		{
			nint num30 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v609 @ S0_v523 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((UICamera)(object)currentTouch).Awake();
		if (obj2 != null)
		{
			object obj45 = 0;
			while ((nint)obj45 <= 2)
			{
				nint num31 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v752 @ S0_v503 (Il2CppClass<UICamera>)+BA]");
				object obj46 = (nint)0 & (nint)0x200;
				if (obj46 != null)
				{
					nint num32 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v770 @ S0_v516 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj47 = mMouse + 16;
				object obj48 = obj45 << 2;
				object obj49 = obj47 + obj48;
				object obj50 = obj49 + 52;
				MouseOrTouch mouseOrTouch8 = currentTouch;
				obj50 = mouseOrTouch8.current;
				object obj51 = obj45 + 1;
				obj45 = obj51;
			}
			obj43 = 1;
		}
		else
		{
			nint num33 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v688 @ S0_v447 (Il2CppClass<UICamera>)+BA]");
			object obj52 = (nint)0 & (nint)0x200;
			if (obj52 != null)
			{
				nint num34 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v716 @ S0_v492 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj53 = mMouse + 16;
			object obj54 = obj53;
			MouseOrTouch mouseOrTouch9 = currentTouch;
			nint num35 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v737 @ S2_v67 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj55 = (nint)0 & (nint)0x200;
			if (obj55 != null)
			{
				nint num36 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v759 @ S2_v74 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v730 @ S0_v455+34]");
			int num37 = ((ComputeShader)0).FindKernel((string)(object)mouseOrTouch9.current);
			bool flag2 = num37 == 0;
			obj43 = obj29;
			if (!flag2)
			{
				nint num38 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v819 @ S0_v459 (Il2CppClass<UICamera>)+BA]");
				object obj56 = (nint)0 & (nint)0x200;
				if (obj56 != null)
				{
					nint num39 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v850 @ S0_v488 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Ray ray3 = currentRay;
				object obj57 = 0;
				while ((nint)obj57 <= 2)
				{
					nint num40 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v968 @ S0_v469 (Il2CppClass<UICamera>)+BA]");
					object obj58 = (nint)0 & (nint)0x200;
					if (obj58 != null)
					{
						nint num41 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1012 @ S0_v482 (Il2CppClass<UICamera>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					object obj59 = mMouse + 16;
					object obj60 = obj57 << 2;
					object obj61 = obj59 + obj60;
					object obj62 = obj61 + 52;
					MouseOrTouch mouseOrTouch10 = currentTouch;
					obj62 = mouseOrTouch10.current;
					object obj63 = obj57 + 1;
					obj57 = obj63;
				}
				obj43 = 1;
			}
		}
		goto IL_1944;
		IL_1944:
		nint num42 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v650 @ S0_v104 (Il2CppClass<UICamera>)+BA]");
		object obj64 = (nint)0 & (nint)0x200;
		if (obj64 != null)
		{
			nint num43 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v659 @ S0_v429 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		MouseOrTouch mouseOrTouch11 = currentTouch;
		MouseOrTouch mouseOrTouch12 = currentTouch;
		nint num44 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v678 @ S2_v16 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj65 = (nint)0 & (nint)0x200;
		if (obj65 != null)
		{
			nint num45 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v695 @ S2_v61 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num46 = ((ComputeShader)(object)mouseOrTouch11.last).FindKernel((string)(object)mouseOrTouch12.current);
		MouseOrTouch mouseOrTouch13 = currentTouch;
		int num47 = ((ComputeShader)(object)mouseOrTouch13.pressed).FindKernel((string)null);
		int num48 = num47 ^ 1;
		if ((obj43 & num48) != 0)
		{
			nint num49 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v796 @ S0_v415 (Il2CppClass<UICamera>)+BA]");
			object obj66 = (nint)0 & (nint)0x200;
			if (obj66 != null)
			{
				nint num50 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v825 @ S0_v423 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			MouseOrTouch mouseOrTouch14 = currentTouch;
			controllerNavigationObject = mouseOrTouch14.current;
		}
		nint num51 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v811 @ S0_v117 (Il2CppClass<UICamera>)+BA]");
		object obj67 = (nint)0 & (nint)0x200;
		if (obj67 != null)
		{
			nint num52 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v835 @ S0_v408 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		currentTouchID = -1;
		if (num46 != 0)
		{
			nint num53 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v862 @ S0_v399 (Il2CppClass<UICamera>)+BA]");
			object obj68 = (nint)0 & (nint)0x200;
			if (obj68 != null)
			{
				nint num54 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v887 @ S0_v404 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Ray ray4 = currentRay;
		}
		object obj69 = obj2 ^ 1;
		object obj70 = obj43 & obj69;
		if (obj70 != null)
		{
			bool flag3 = stickyTooltip;
			object obj71 = (flag3 ? 1 : 0) ^ 1;
			if ((num46 | obj71) != 0)
			{
				nint num55 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v939 @ S0_v344 (Il2CppClass<UICamera>)+BA]");
				object obj72 = (nint)0 & (nint)0x200;
				if (obj72 != null)
				{
					nint num56 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v973 @ S0_v393 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (mTooltipTime != 0f)
				{
					float unscaledDeltaTime3 = Time.unscaledDeltaTime;
					nint num57 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1082 @ S0_v382 (Il2CppClass<UICamera>)+BA]");
					object obj73 = (nint)0 & (nint)0x200;
					if (obj73 != null)
					{
						nint num58 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1135 @ S0_v388 (Il2CppClass<UICamera>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					float num59 = unscaledDeltaTime3 + tooltipDelay;
					mTooltipTime = num59;
				}
				else
				{
					nint num60 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1038 @ S0_v353 (Il2CppClass<UICamera>)+BA]");
					object obj74 = (nint)0 & (nint)0x200;
					if (obj74 != null)
					{
						nint num61 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1087 @ S0_v372 (Il2CppClass<UICamera>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					nint num62 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1097 @ S1_v187 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj75 = (nint)0 & (nint)0x200;
					if (obj75 != null)
					{
						nint num63 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1143 @ S1_v194 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (((ComputeShader)(object)mTooltip).FindKernel((string)null) != 0)
					{
						nint num64 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1236 @ S0_v363 (Il2CppClass<UICamera>)+BA]");
						object obj76 = (nint)0 & (nint)0x200;
						if (obj76 != null)
						{
							nint num65 = (nint)typeof(UICamera);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1285 @ S0_v369 (Il2CppClass<UICamera>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						BMFont bmFont = ((UIFont)null).bmFont;
					}
				}
			}
		}
		if (obj43 != null)
		{
			nint num66 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v946 @ S0_v312 (Il2CppClass<UICamera>)+BA]");
			object obj77 = (nint)0 & (nint)0x200;
			if (obj77 != null)
			{
				nint num67 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v985 @ S0_v336 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (onMouseMove != null)
			{
				nint num68 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1046 @ S0_v320 (Il2CppClass<UICamera>)+BA]");
				object obj78 = (nint)0 & (nint)0x200;
				if (obj78 != null)
				{
					nint num69 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1102 @ S0_v331 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				MouseOrTouch mouseOrTouch15 = currentTouch;
				((Vector2*)(nint)vector2)->x = (float)mouseOrTouch15.delta;
				obj14 = vector2.x;
				((Vector2*)(nint)vector)->x = (float)obj14;
				onMouseMove.EndInvoke((IAsyncResult)vector);
				nint num70 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1150 @ S0_v328 (Il2CppClass<UICamera>)+5C]");
				object obj79 = (nint)0 + (nint)160;
				obj79 = 0;
			}
		}
		if (num46 != 0)
		{
			int num71 = obj2 | num48;
			object obj80 = 1 ^ 1;
			if ((num71 & obj80) == 0)
			{
				nint num72 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1052 @ S0_v303 (Il2CppClass<UICamera>)+BA]");
				object obj81 = (nint)0 & (nint)0x200;
				if (obj81 != null)
				{
					nint num73 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1123 @ S0_v308 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				controllerNavigationObject = null;
			}
		}
		int num74 = 0;
		while (num74 <= 2)
		{
			bool mouseButtonUp = Input.GetMouseButtonUp(num74);
			bool key = Input.GetKey((KeyCode)num74);
			object obj82 = mouseButtonUp | key;
			if (obj82 != null)
			{
				nint num75 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1241 @ S0_v289 (Il2CppClass<UICamera>)+BA]");
				object obj83 = (nint)0 & (nint)0x200;
				if (obj83 != null)
				{
					nint num76 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1290 @ S0_v295 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Ray ray5 = currentRay;
			}
			nint num77 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1256 @ S0_v215 (Il2CppClass<UICamera>)+BA]");
			object obj84 = (nint)0 & (nint)0x200;
			if (obj84 != null)
			{
				nint num78 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1296 @ S0_v283 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num79 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1303 @ S0_v220 (Il2CppClass<UICamera>)+5C]");
			object obj85 = (nint)0 + (nint)160;
			object obj86 = mMouse + 16;
			int num80 = num74 << 2;
			object obj87 = obj86 + num80;
			obj85 = obj87;
			int num81 = -1 - num74;
			currentTouchID = num81;
			Ray ray6 = currentRay;
			nint num82 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1342 @ S0_v229 (Il2CppClass<UICamera>)+BA]");
			object obj88 = (nint)0 & (nint)0x200;
			bool flag4 = obj88 == null;
			if (mouseButtonUp)
			{
				if (!flag4)
				{
					nint num83 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1383 @ S0_v278 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj89 = currentTouch + 44;
				obj89 = currentCamera;
				object obj90 = currentTouch - -64;
				float unscaledDeltaTime4 = Time.unscaledDeltaTime;
				obj90 = unscaledDeltaTime4;
			}
			else
			{
				if (!flag4)
				{
					nint num84 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1406 @ S0_v261 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				MouseOrTouch mouseOrTouch16 = currentTouch;
				nint num85 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1417 @ S1_v141 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj91 = (nint)0 & (nint)0x200;
				if (obj91 != null)
				{
					nint num86 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1426 @ S1_v152 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)(object)mouseOrTouch16.pressed).FindKernel((string)null) != 0)
				{
					nint num87 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1447 @ S0_v248 (Il2CppClass<UICamera>)+BA]");
					object obj92 = (nint)0 & (nint)0x200;
					if (obj92 != null)
					{
						nint num88 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1452 @ S0_v256 (Il2CppClass<UICamera>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					nint num89 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1458 @ S0_v253 (Il2CppClass<UICamera>)+5C]");
					object obj93 = (nint)0 + (nint)140;
					MouseOrTouch mouseOrTouch17 = currentTouch;
					obj93 = mouseOrTouch17.pressedCam;
				}
			}
			Vector2 vector5 = ((UIColorPicker)mouseButtonUp).Select((Color)key);
			int num90 = num74 + 1;
			num74 = num90;
		}
		if ((num46 & obj69) != 0)
		{
			nint num91 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ S0_v183 (Il2CppClass<UICamera>)+BA]");
			object obj94 = (nint)0 & (nint)0x200;
			if (obj94 != null)
			{
				nint num92 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1186 @ S0_v205 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num93 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1192 @ S0_v188 (Il2CppClass<UICamera>)+5C]");
			object obj95 = (nint)0 + (nint)160;
			object obj96 = mMouse + 16;
			obj95 = obj96;
			float unscaledDeltaTime5 = Time.unscaledDeltaTime;
			float num94 = unscaledDeltaTime5 + tooltipDelay;
			mTooltipTime = num94;
			currentTouchID = -1;
			Ray ray7 = currentRay;
			MouseOrTouch mouseOrTouch18 = currentTouch;
			controllerNavigationObject = mouseOrTouch18.current;
		}
		nint num95 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1175 @ S0_v140 (Il2CppClass<UICamera>)+BA]");
		object obj97 = (nint)0 & (nint)0x200;
		bool flag5 = obj97 == null;
		nint num96 = (nint)typeof(UICamera);
		if (!flag5)
		{
			nint num97 = (nint)typeof(UICamera);
			num96 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1204 @ S0_v177 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num96 = (nint)typeof(UICamera);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1206 @ L0_v3 (Il2CppClass<UICamera>)+5C]");
		object obj98 = (nint)0 + (nint)160;
		obj98 = 0;
		object obj99 = mMouse + 16;
		object obj100 = obj99 + 48;
		object obj101 = mMouse + 16;
		object obj102 = obj101;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1230 @ S1_v91+34]");
		obj100 = 0;
		object obj103 = 1;
		while ((nint)obj103 <= 2)
		{
			nint num98 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1335 @ S0_v159 (Il2CppClass<UICamera>)+BA]");
			object obj104 = (nint)0 & (nint)0x200;
			if (obj104 != null)
			{
				nint num99 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1350 @ S0_v172 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj105 = mMouse + 16;
			object obj106 = obj103 << 2;
			object obj107 = obj105 + obj106;
			object obj108 = obj107 + 48;
			object obj109 = mMouse + 16;
			object obj110 = obj109;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1372 @ S1_v105+30]");
			obj108 = 0;
			object obj111 = obj103 + 1;
			obj103 = obj111;
		}
	}

	private unsafe void ProcessFakeTouches()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0ace: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad3: Expected Obj, but got Unknown
		//IL_0adc: Expected Obj, but got I4
		//IL_0b0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b14: Expected Obj, but got Unknown
		//IL_0b1d: Expected Obj, but got I4
		//IL_0b2b: Expected I, but got Obj
		//IL_0b41: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected I4, but got Unknown
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected VT, but got Unknown
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected Obj, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected Obj, but got Unknown
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected Obj, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected Obj, but got Unknown
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected Obj, but got Unknown
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_08f3: Expected I, but got Obj
		//IL_0909: Expected Obj, but got I
		//IL_00af: Expected I, but got Obj
		//IL_0171: Expected I, but got Obj
		//IL_0187: Expected Obj, but got I
		//IL_0a45: Expected I, but got Obj
		//IL_0a5b: Expected Obj, but got I
		//IL_09d4: Expected I, but got Obj
		//IL_0299: Expected Obj, but got I4
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Expected Obj, but got Unknown
		//IL_0310: Expected Obj, but got I4
		//IL_0328: Expected Obj, but got I
		//IL_0335: Expected F4, but got Obj
		//IL_0330: Expected native int or pointer, but got VT
		//IL_0352: Expected I4, but got F4
		//IL_036a: Expected I4, but got Obj
		//IL_01b2: Expected I, but got Obj
		//IL_0963: Expected I, but got Obj
		//IL_0c0e: Expected I, but got Obj
		//IL_0c24: Expected Obj, but got I
		//IL_01ff: Expected I, but got Obj
		//IL_0215: Expected Obj, but got I
		//IL_0a86: Expected I, but got Obj
		//IL_0b9d: Expected Obj, but got Ref
		//IL_0bb3: Expected I4, but got VT
		//IL_037d: Expected I, but got Obj
		//IL_0240: Expected I, but got Obj
		//IL_0c62: Expected I, but got Obj
		//IL_0c78: Expected Obj, but got I
		//IL_0f1b: Expected I, but got Obj
		//IL_0f31: Expected Obj, but got I
		//IL_03e5: Expected I, but got Obj
		//IL_03fb: Expected Obj, but got I
		//IL_0ce1: Expected Obj, but got VT
		//IL_0cef: Expected I, but got Obj
		//IL_0d05: Expected Obj, but got I
		//IL_0f56: Expected Obj, but got I4
		//IL_0f6b: Expected F4, but got Obj
		//IL_0f66: Expected native int or pointer, but got VT
		//IL_0f78: Expected I4, but got Obj
		//IL_0f85: Expected VT, but got I4
		//IL_0f9e: Expected I4, but got Obj
		//IL_0fb0: Expected VT, but got I4
		//IL_0fc1: Expected Obj, but got I4
		//IL_0fce: Expected I4, but got Obj
		//IL_0fe0: Expected VT, but got I4
		//IL_0481: Expected I, but got Obj
		//IL_0426: Expected I, but got Obj
		//IL_051b: Expected I, but got Obj
		//IL_0531: Expected Obj, but got I
		//IL_04ce: Expected I, but got Obj
		//IL_0d56: Expected I, but got Obj
		//IL_0d6c: Expected Obj, but got I
		//IL_060e: Expected I, but got Obj
		//IL_0d2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d31: Expected Obj, but got Unknown
		//IL_065b: Expected I, but got Obj
		//IL_059d: Expected I, but got Obj
		//IL_1061: Expected Obj, but got I4
		//IL_107d: Expected VT, but got I4
		//IL_107d: Expected Obj, but got I4
		//IL_06a8: Expected I, but got Obj
		//IL_06be: Expected Obj, but got I
		//IL_0852: Expected I, but got Obj
		//IL_0868: Expected Obj, but got I
		//IL_0736: Expected I, but got Obj
		//IL_074c: Expected Obj, but got I
		//IL_0d97: Expected I, but got Obj
		//IL_0dad: Expected Obj, but got I
		//IL_0e21: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e26: Expected Obj, but got Unknown
		//IL_0e2f: Expected Obj, but got I4
		//IL_0e3d: Expected I, but got Obj
		//IL_0e53: Expected Obj, but got I
		//IL_0e5c: Expected Obj, but got I4
		//IL_07c4: Expected I, but got Obj
		//IL_07da: Expected Obj, but got I
		//IL_06e9: Expected I, but got Obj
		//IL_0893: Expected I, but got Obj
		//IL_0dfb: Expected Obj, but got I4
		//IL_0777: Expected I, but got Obj
		//IL_0805: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 192;
		object obj3 = obj2 + 124;
		obj3 = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		object obj4 = obj3 - -64;
		obj4 = 0;
		nint num = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v20 (Il2CppClass<UICamera>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v236 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag;
		if (GetInputTouchCount != null)
		{
			nint num3 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v222 (Il2CppClass<UICamera>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num4 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v230 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			flag = (byte)GetInputTouchCount() != 0;
		}
		else
		{
			flag = Input.touchSupported;
		}
		int num5 = obj2 + 56;
		Vector2 vector = (Vector2)(obj2 + 48);
		object obj7 = obj2 + 16;
		object obj8 = obj2 + 40;
		object obj9 = obj2 + 32;
		object obj10 = obj2 + 24;
		object obj11 = obj2 + 8;
		ref UnityEngine.Touch reference = default;
		object obj18 = default;
		ref UnityEngine.Touch reference2 = default;
		while ((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) < (nint)(flag ? 1 : 0))
		{
			nint num6 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S0_v96 (Il2CppClass<UICamera>)+BA]");
			object obj12 = (nint)0 & (nint)0x200;
			if (obj12 != null)
			{
				nint num7 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S0_v213 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int num10;
			int num11;
			TouchPhase touchPhase;
			int num12;
			if (GetInputTouch != null)
			{
				nint num8 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ S0_v191 (Il2CppClass<UICamera>)+BA]");
				object obj13 = (nint)0 & (nint)0x200;
				if (obj13 != null)
				{
					nint num9 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ S0_v207 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Touch touch = GetInputTouch.EndInvoke((IAsyncResult)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
				((int*)num5)->m_value = (int)touch.position;
				num10 = touch.tapCount;
				num11 = ((int*)num5)->m_value;
				touchPhase = touch.phase;
				num12 = touch.fingerId;
			}
			else
			{
				Input.GetTouch_Injected(num5, out reference);
				obj3 = ((int*)num5)->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v29 (System.Int32)+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v29 (System.Int32)+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v29 (System.Int32)+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v29 (System.Int32)+20]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v29 (System.Int32)+28]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v29 (System.Int32)+30]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v29 (System.Int32)+38]");
				_ = 0;
				object obj14 = obj3 - -64;
				object obj15 = num5 - -64;
				obj14 = obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
				obj = 0;
				((Vector2*)(nint)vector)->x = (float)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+20]");
				num10 = 0;
				num11 = (int)vector.x;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+24]");
				touchPhase = TouchPhase.Began;
				num12 = (int)obj3;
			}
			bool flag2 = allowMultiTouch;
			nint num13 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ S1_v38 (Il2CppClass<UICamera>)+BA]");
			object obj16 = (nint)0 & (nint)0x200;
			if (obj16 != null)
			{
				nint num14 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ S1_v135 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int num15 = ((!flag2) ? 1 : num12);
			currentTouchID = num15;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A092");
			nint num16 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ S1_v50 (Il2CppClass<UICamera>)+5C]");
			object obj17 = (nint)0 + (nint)160;
			obj17 = obj18;
			bool flag3;
			if (touchPhase != TouchPhase.Began)
			{
				nint num17 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ S1_v120 (Il2CppClass<UICamera>)+BA]");
				object obj19 = (nint)0 & (nint)0x200;
				if (obj19 != null)
				{
					nint num18 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ S1_v129 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				MouseOrTouch mouseOrTouch = currentTouch;
				flag3 = mouseOrTouch.touchBegan;
			}
			else
			{
				flag3 = true;
			}
			nint num19 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ S2_v16 (Il2CppClass<UICamera>)+BA]");
			object obj20 = (nint)0 & (nint)0x200;
			if (obj20 != null)
			{
				nint num20 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ S2_v65 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			MouseOrTouch mouseOrTouch2 = currentTouch;
			MouseOrTouch mouseOrTouch3 = currentTouch;
			obj7 = mouseOrTouch3.pos;
			nint num21 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ S3_v7 (Il2CppClass<UnityEngine.Vector2>)+BA]");
			object obj21 = (nint)0 & (nint)0x200;
			if (obj21 != null)
			{
				nint num22 = (nint)typeof(Vector2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ S3_v33 (Il2CppClass<UnityEngine.Vector2>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj8 = num11;
			obj9 = obj7;
			((Vector2*)(nint)vector)->x = (float)obj8;
			((int*)num5)->m_value = (int)obj9;
			Vector2 vector2 = vector * (Vector2)num5;
			obj10 = obj2;
			((int*)num5)->m_value = (int)obj10;
			mouseOrTouch2.delta = (Vector2)((int*)num5)->m_value;
			MouseOrTouch mouseOrTouch4 = currentTouch;
			obj11 = num11;
			((int*)num5)->m_value = (int)obj11;
			mouseOrTouch4.pos = (Vector2)((int*)num5)->m_value;
			Ray ray = currentRay;
			((UICamera)(object)currentTouch).Awake();
			nint num23 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v549 @ S2_v33 (Il2CppClass<UICamera>)+BA]");
			object obj22 = (nint)0 & (nint)0x200;
			bool flag4 = obj22 == null;
			bool flag5 = flag3;
			if (flag5)
			{
				if (!flag4)
				{
					nint num24 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v565 @ S1_v112 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj23 = currentTouch + 44;
				obj23 = currentCamera;
			}
			else
			{
				if (!flag4)
				{
					nint num25 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v583 @ S1_v99 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				MouseOrTouch mouseOrTouch5 = currentTouch;
				nint num26 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v597 @ S2_v45 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj24 = (nint)0 & (nint)0x200;
				if (obj24 != null)
				{
					nint num27 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v621 @ S2_v56 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)(object)mouseOrTouch5.pressed).FindKernel((string)null) != 0)
				{
					nint num28 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v666 @ S1_v85 (Il2CppClass<UICamera>)+BA]");
					object obj25 = (nint)0 & (nint)0x200;
					if (obj25 != null)
					{
						nint num29 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v696 @ S1_v93 (Il2CppClass<UICamera>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					nint num30 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ S1_v90 (Il2CppClass<UICamera>)+5C]");
					object obj26 = (nint)0 + (nint)140;
					MouseOrTouch mouseOrTouch6 = currentTouch;
					obj26 = mouseOrTouch6.pressedCam;
				}
			}
			if (num10 >= 2)
			{
				nint num31 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ S0_v152 (Il2CppClass<UICamera>)+BA]");
				object obj27 = (nint)0 & (nint)0x200;
				if (obj27 != null)
				{
					nint num32 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v653 @ S0_v159 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				MouseOrTouch mouseOrTouch7 = currentTouch;
				float unscaledDeltaTime = Time.unscaledDeltaTime;
				mouseOrTouch7.clickTime = unscaledDeltaTime;
			}
			object obj28 = touchPhase + -3;
			bool flag6 = (nint)obj28 < 2;
			Vector2 vector3 = ((UIColorPicker)flag5).Select((Color)flag6);
			if (flag6)
			{
				nint num33 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v674 @ S0_v138 (Il2CppClass<UICamera>)+BA]");
				object obj29 = (nint)0 & (nint)0x200;
				if (obj29 != null)
				{
					nint num34 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v711 @ S0_v145 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				RemoveTouch.EndInvoke((IAsyncResult)currentTouchID);
			}
			nint num35 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v690 @ S0_v110 (Il2CppClass<UICamera>)+BA]");
			object obj30 = (nint)0 & (nint)0x200;
			if (obj30 != null)
			{
				nint num36 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v723 @ S0_v131 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			MouseOrTouch mouseOrTouch8 = currentTouch;
			mouseOrTouch8.touchBegan = false;
			object obj31 = currentTouch + 48;
			obj31 = 0;
			nint num37 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v742 @ S0_v123 (Il2CppClass<UICamera>)+5C]");
			object obj32 = (nint)0 + (nint)160;
			obj32 = 0;
			if (~(allowMultiTouch ? 1u : 0u) != 0)
			{
				break;
			}
			reference = ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference2, 1);
		}
		nint num38 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ S0_v47 (Il2CppClass<UICamera>)+BA]");
		object obj33 = (nint)0 & (nint)0x200;
		bool flag7 = obj33 == null;
		if (flag)
		{
			if (!flag7)
			{
				nint num39 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ S0_v89 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			mUsingTouchEvents = true;
			return;
		}
		if (!flag7)
		{
			nint num40 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ S0_v78 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(mUsingTouchEvents ? 1u : 0u) != 0)
		{
			if (~(useMouse ? 1u : 0u) == 0)
			{
				ProcessTouches();
			}
			return;
		}
		nint num41 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ S0_v62 (Il2CppClass<UICamera>)+BA]");
		object obj34 = (nint)0 & (nint)0x200;
		if (obj34 != null)
		{
			nint num42 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ S0_v68 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		mUsingTouchEvents = false;
	}

	public unsafe void ProcessOthers()
	{
		//IL_055e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0563: Expected VT, but got Unknown
		//IL_056c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0571: Expected VT, but got Unknown
		//IL_057a: Unknown result type (might be due to invalid IL or missing references)
		//IL_057f: Expected Obj, but got Unknown
		//IL_0588: Unknown result type (might be due to invalid IL or missing references)
		//IL_058d: Expected Obj, but got Unknown
		//IL_0596: Unknown result type (might be due to invalid IL or missing references)
		//IL_059b: Expected Obj, but got Unknown
		//IL_05a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a9: Expected Obj, but got Unknown
		//IL_05b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b7: Expected Obj, but got Unknown
		//IL_05e0: Expected Obj, but got I4
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected Obj, but got Unknown
		//IL_003d: Expected I, but got Obj
		//IL_0053: Expected Obj, but got I
		//IL_060c: Expected I, but got Obj
		//IL_0622: Expected Obj, but got I
		//IL_062c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0631: Expected Obj, but got Unknown
		//IL_0162: Expected I, but got Obj
		//IL_0178: Expected Obj, but got I
		//IL_007e: Expected I, but got Obj
		//IL_06a9: Expected F4, but got Obj
		//IL_06a4: Expected native int or pointer, but got VT
		//IL_06d1: Expected I, but got Obj
		//IL_06e7: Expected Obj, but got I
		//IL_00cb: Expected I, but got Obj
		//IL_00e1: Expected Obj, but got I
		//IL_0723: Expected Obj, but got VT
		//IL_0738: Expected F4, but got Obj
		//IL_0733: Expected native int or pointer, but got VT
		//IL_0745: Expected F4, but got Obj
		//IL_0740: Expected native int or pointer, but got VT
		//IL_0763: Expected F4, but got Obj
		//IL_075e: Expected native int or pointer, but got VT
		//IL_0775: Expected VT, but got F4
		//IL_0793: Expected F4, but got Obj
		//IL_078e: Expected native int or pointer, but got VT
		//IL_07a5: Expected VT, but got F4
		//IL_07bd: Expected I, but got Obj
		//IL_07d3: Expected Obj, but got I
		//IL_01a3: Expected I, but got Obj
		//IL_0672: Unknown result type (might be due to invalid IL or missing references)
		//IL_0677: Expected Obj, but got Unknown
		//IL_0688: Expected Obj, but got F4
		//IL_01f0: Expected I, but got Obj
		//IL_010c: Expected I, but got Obj
		//IL_082f: Expected I, but got Obj
		//IL_0845: Expected Obj, but got I
		//IL_02d2: Expected I, but got Obj
		//IL_0805: Unknown result type (might be due to invalid IL or missing references)
		//IL_080a: Expected Obj, but got Unknown
		//IL_0908: Expected I, but got Obj
		//IL_091e: Expected Obj, but got I
		//IL_031f: Expected I, but got Obj
		//IL_0261: Expected I, but got Obj
		//IL_0981: Expected VT, but got I4
		//IL_0981: Expected Obj, but got I4
		//IL_036c: Expected I, but got Obj
		//IL_0382: Expected Obj, but got I
		//IL_04d5: Expected I, but got Obj
		//IL_04eb: Expected Obj, but got I
		//IL_03fa: Expected I, but got Obj
		//IL_0870: Expected I, but got Obj
		//IL_0886: Expected Obj, but got I
		//IL_08ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bf: Expected Obj, but got Unknown
		//IL_08c8: Expected Obj, but got I4
		//IL_08d6: Expected I, but got Obj
		//IL_08ec: Expected Obj, but got I
		//IL_08f5: Expected Obj, but got I4
		//IL_0447: Expected I, but got Obj
		//IL_045d: Expected Obj, but got I
		//IL_03ad: Expected I, but got Obj
		//IL_0516: Expected I, but got Obj
		//IL_0488: Expected I, but got Obj
		object obj = default;
		Vector2 vector = (Vector2)(obj - -64);
		Vector2 vector2 = (Vector2)(obj + 56);
		object obj2 = obj + 40;
		object obj3 = obj + 8;
		object obj4 = obj + 32;
		object obj5 = obj + 24;
		object obj6 = obj + 16;
		bool mouseButtonUp = Input.GetMouseButtonUp(0);
		bool key = Input.GetKey(KeyCode.None);
		object obj7 = mouseButtonUp | key;
		bool mouseButtonDown = Input.GetMouseButtonDown(0);
		object obj8 = obj7 | mouseButtonDown;
		if (obj8 == null)
		{
			return;
		}
		nint num = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v29 (Il2CppClass<UICamera>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num2 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v197 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		currentTouchID = 1;
		nint num3 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v36 (Il2CppClass<UICamera>)+5C]");
		object obj10 = (nint)0 + (nint)160;
		object obj11 = mMouse + 16;
		obj10 = obj11;
		MouseOrTouch mouseOrTouch = currentTouch;
		mouseOrTouch.touchBegan = mouseButtonUp;
		if (mouseButtonUp)
		{
			nint num4 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S0_v179 (Il2CppClass<UICamera>)+BA]");
			object obj12 = (nint)0 & (nint)0x200;
			if (obj12 != null)
			{
				nint num5 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S0_v191 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj13 = currentTouch - -64;
			float unscaledDeltaTime = Time.unscaledDeltaTime;
			obj13 = unscaledDeltaTime;
			activeTouches.Add(currentTouch);
		}
		Vector2 mouseScrollDelta = Input.mouseScrollDelta;
		nint num6 = (nint)typeof(Vector2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ S0_v47 (Il2CppClass<UnityEngine.Vector2>)+BA]");
		object obj14 = (nint)0 & (nint)0x200;
		if (obj14 != null)
		{
			nint num7 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v174 (Il2CppClass<UnityEngine.Vector2>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Vector2*)(nint)vector)->x = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
		_ = 0;
		Vector3 vector3 = vector;
		nint num8 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ S0_v57 (Il2CppClass<UICamera>)+BA]");
		object obj15 = (nint)0 & (nint)0x200;
		if (obj15 != null)
		{
			nint num9 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ S0_v168 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		MouseOrTouch mouseOrTouch2 = currentTouch;
		MouseOrTouch mouseOrTouch3 = currentTouch;
		obj5 = mouseOrTouch3.pos;
		obj4 = obj3;
		((Vector2*)(nint)vector2)->x = (float)obj4;
		((Vector2*)(nint)vector)->x = (float)obj5;
		Vector2 vector4 = vector2 * vector;
		((Vector2*)(nint)vector)->x = (float)obj6;
		mouseOrTouch2.delta = (Vector2)vector.x;
		MouseOrTouch mouseOrTouch4 = currentTouch;
		obj = obj3;
		((Vector2*)(nint)vector)->x = (float)obj;
		mouseOrTouch4.pos = (Vector2)vector.x;
		((UICamera)(object)currentTouch).Awake();
		nint num10 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ S0_v73 (Il2CppClass<UICamera>)+BA]");
		object obj16 = (nint)0 & (nint)0x200;
		bool flag = obj16 == null;
		if (mouseButtonUp)
		{
			if (!flag)
			{
				nint num11 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ S0_v162 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj17 = currentTouch + 44;
			obj17 = currentCamera;
		}
		else
		{
			if (!flag)
			{
				nint num12 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ S0_v149 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			MouseOrTouch mouseOrTouch5 = currentTouch;
			nint num13 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ S1_v66 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj18 = (nint)0 & (nint)0x200;
			if (obj18 != null)
			{
				nint num14 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ S1_v77 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)mouseOrTouch5.pressed).FindKernel((string)null) != 0)
			{
				nint num15 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ S0_v135 (Il2CppClass<UICamera>)+BA]");
				object obj19 = (nint)0 & (nint)0x200;
				if (obj19 != null)
				{
					nint num16 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ S0_v143 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				nint num17 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ S0_v140 (Il2CppClass<UICamera>)+5C]");
				object obj20 = (nint)0 + (nint)140;
				MouseOrTouch mouseOrTouch6 = currentTouch;
				obj20 = mouseOrTouch6.pressedCam;
			}
		}
		nint num18 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ S0_v80 (Il2CppClass<UICamera>)+BA]");
		object obj21 = (nint)0 & (nint)0x200;
		if (obj21 != null)
		{
			nint num19 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ S0_v122 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Ray ray = currentRay;
		Vector2 vector5 = ((UIColorPicker)mouseButtonUp).Select((Color)key);
		if (key)
		{
			nint num20 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ S0_v108 (Il2CppClass<UICamera>)+BA]");
			object obj22 = (nint)0 & (nint)0x200;
			if (obj22 != null)
			{
				nint num21 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ S0_v116 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10E8D");
		}
		nint num22 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ S0_v89 (Il2CppClass<UICamera>)+BA]");
		object obj23 = (nint)0 & (nint)0x200;
		if (obj23 != null)
		{
			nint num23 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ S0_v101 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj24 = currentTouch + 48;
		obj24 = 0;
		nint num24 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ S0_v98 (Il2CppClass<UICamera>)+5C]");
		object obj25 = (nint)0 + (nint)160;
		obj25 = 0;
	}

	private unsafe void ProcessPress(bool pressed, float click, float drag)
	{
		//IL_012a: Expected I, but got Obj
		//IL_0140: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_007b: Expected I, but got Obj
		//IL_0091: Expected Obj, but got I
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Expected Obj, but got Unknown
		//IL_01ae: Expected Obj, but got I4
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected VT, but got Unknown
		//IL_01c9: Expected F4, but got Obj
		//IL_01c4: Expected native int or pointer, but got VT
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected Obj, but got Unknown
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected Obj, but got Unknown
		//IL_0222: Expected Obj, but got I4
		//IL_022f: Expected F4, but got Obj
		//IL_022a: Expected native int or pointer, but got VT
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Expected Obj, but got Unknown
		//IL_025b: Expected I4, but got Obj
		//IL_0270: Expected F4, but got Obj
		//IL_026b: Expected native int or pointer, but got VT
		//IL_00bc: Expected I, but got Obj
		float num = click * 0.001f;
		float num2 = 1f - num;
		nint num3 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num4 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v46 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num5 = ((!(drag > 1f)) ? drag : 1f);
		float width = num5 * 1000f;
		GUILayoutOption gUILayoutOption = GUILayout.Width(width);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @122F6");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @122F4");
		nint num6 = (nint)typeof(Vector2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v22 (Il2CppClass<UnityEngine.Vector2>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num7 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v42 (Il2CppClass<UnityEngine.Vector2>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = default;
		object obj3 = obj4 + 32;
		obj3 = ((bool*)(pressed ? 1 : 0))->m_value;
		Vector2 vector = (Vector2)(obj4 + 40);
		((Vector2*)(nint)vector)->x = (float)obj3;
		object obj5 = obj4 + 24;
		float num9 = default;
		float num8 = num9 - 1f;
		object obj6 = default;
		float num10 = num8 / (float)obj6;
		Vector2 vector2 = vector / num10;
		object obj7 = obj4 + 8;
		obj7 = ((bool*)(pressed ? 1 : 0))->m_value;
		((Vector2*)(nint)vector)->x = (float)obj7;
		object obj8 = obj4 + 16;
		Vector2 vector3 = vector / num9;
		((bool*)(pressed ? 1 : 0))->m_value = (byte)(int)obj8 != 0;
		obj4 = obj5;
		((Vector2*)(nint)vector)->x = (float)obj4;
		Vector2 vector4 = vector / 0.06f;
	}

	private unsafe void ProcessRelease(bool isMouse, float drag)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected Obj, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected Obj, but got Unknown
		//IL_00e9: Expected VT, but got F4
		//IL_00f6: Expected Obj, but got I4
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected Obj, but got Unknown
		//IL_0130: Expected Obj, but got I4
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v32 (Il2CppClass<UnityEngine.Vector3>)+74]");
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
		object obj4 = this + 36;
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v15+8]");
		_ = 0;
		eventReceiverMask = (LayerMask)drag;
		obj2 = ((bool*)(isMouse ? 1 : 0))->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [isMouse @ L1 (System.Boolean)+8]");
		_ = 0;
		object obj5 = this + 24;
		obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v15+8]");
		_ = 0;
		obj2 = ((bool*)(isMouse ? 1 : 0))->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [isMouse @ L1 (System.Boolean)+8]");
		_ = 0;
		object obj6 = this + 8;
		obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v15+8]");
		_ = 0;
	}

	private bool HasCollider(GameObject go)
	{
		//IL_01de: Expected I, but got Obj
		//IL_01f4: Expected Obj, but got I
		//IL_028c: Expected I, but got Obj
		//IL_02a2: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00f5: Expected I, but got Obj
		//IL_0142: Expected I, but got Obj
		//IL_0158: Expected Obj, but got I
		//IL_0084: Expected I, but got Obj
		//IL_0183: Expected I, but got Obj
		nint num = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UICamera>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v49 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = GetKeyDown.EndInvoke((IAsyncResult)this);
		nint num3 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v5 (Il2CppClass<UICamera>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		bool flag2 = obj2 == null;
		if (flag)
		{
			if (!flag2)
			{
				nint num4 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v45 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Ray ray = currentRay;
			return true;
		}
		if (!flag2)
		{
			nint num5 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v34 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (GetKeyDown.EndInvoke((IAsyncResult)(object)go))
		{
			nint num6 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v24 (Il2CppClass<UICamera>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num7 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v30 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Ray ray2 = currentRay;
			return true;
		}
		return false;
	}

	public void ProcessTouch(bool pressed, bool released)
	{
		//IL_067b: Expected I, but got Obj
		//IL_0691: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_06ed: Expected I, but got Obj
		//IL_0703: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_0373: Expected I, but got Obj
		//IL_012f: Expected I, but got Obj
		//IL_017c: Expected I, but got Obj
		//IL_0192: Expected Obj, but got I
		//IL_03ea: Expected I, but got Obj
		//IL_0400: Expected Obj, but got I
		//IL_075d: Expected I, but got Obj
		//IL_0773: Expected Obj, but got I
		//IL_07f7: Expected Obj, but got I4
		//IL_07f7: Expected Obj, but got I4
		//IL_0805: Expected I, but got Obj
		//IL_081b: Expected Obj, but got I
		//IL_01bd: Expected I, but got Obj
		//IL_042b: Expected I, but got Obj
		//IL_020a: Expected I, but got Obj
		//IL_0872: Expected I, but got Obj
		//IL_0888: Expected Obj, but got I
		//IL_0478: Expected I, but got Obj
		//IL_0257: Expected I, but got Obj
		//IL_026d: Expected Obj, but got I
		//IL_04c5: Expected I, but got Obj
		//IL_04db: Expected Obj, but got I
		//IL_062e: Expected I, but got Obj
		//IL_08b3: Expected I, but got Obj
		//IL_08c9: Expected Obj, but got I
		//IL_0298: Expected I, but got Obj
		//IL_0506: Expected I, but got Obj
		//IL_02e5: Expected I, but got Obj
		//IL_02fb: Expected Obj, but got I
		//IL_0553: Expected I, but got Obj
		//IL_05a0: Expected I, but got Obj
		//IL_05b6: Expected Obj, but got I
		//IL_0326: Expected I, but got Obj
		//IL_08fd: Expected Obj, but got I4
		//IL_08fd: Expected Obj, but got I4
		//IL_05e1: Expected I, but got Obj
		nint num = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UICamera>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v158 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (mNotifying > 10)
		{
			return;
		}
		nint num3 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v16 (Il2CppClass<UICamera>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v154 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		KeyCode keyCode = currentKey;
		string text = default;
		if (keyCode == (KeyCode)2)
		{
			nint num5 = (nint)typeof(UIPopupList);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v102 (Il2CppClass<UIPopupList>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(UIPopupList);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v150 (Il2CppClass<UIPopupList>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Dictionary<string, string[]> dictionary = Localization.dictionary;
			if (dictionary != null)
			{
				nint num7 = (nint)typeof(UIPopupList);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S0_v109 (Il2CppClass<UIPopupList>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num8 = (nint)typeof(UIPopupList);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S0_v144 (Il2CppClass<UIPopupList>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				UIPopupList uIPopupList = UIPopupList.current;
				nint num9 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S1_v49 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num10 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S1_v57 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (uIPopupList.source != this)
				{
					nint num11 = (nint)typeof(UIPopupList);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ S0_v119 (Il2CppClass<UIPopupList>)+BA]");
					object obj6 = (nint)0 & (nint)0x200;
					if (obj6 != null)
					{
						nint num12 = (nint)typeof(UIPopupList);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ S0_v140 (Il2CppClass<UIPopupList>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Dictionary<string, string[]> dictionary2 = Localization.dictionary;
					if (dictionary2 != null)
					{
						nint num13 = (nint)typeof(UIPopupList);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ S0_v126 (Il2CppClass<UIPopupList>)+BA]");
						object obj7 = (nint)0 & (nint)0x200;
						if (obj7 != null)
						{
							nint num14 = (nint)typeof(UIPopupList);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ S0_v134 (Il2CppClass<UIPopupList>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						text = UIPopupList.current.tag;
					}
				}
			}
		}
		nint num15 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v25 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num16 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S0_v97 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)(object)text))
		{
			return;
		}
		string text2 = ((GameObject)(object)text).tag;
		if (text2 == null)
		{
			return;
		}
		nint num17 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S0_v34 (Il2CppClass<UICamera>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num18 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ S0_v91 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num19 = mNotifying + 1;
		mNotifying = num19;
		((GameObject)(object)text).BroadcastMessage((string)pressed, (object)released, SendMessageOptions.DontRequireReceiver);
		nint num20 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ S1_v18 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num21 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ S1_v42 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)mGenericHandler).FindKernel((string)null) != 0)
		{
			nint num22 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ S0_v63 (Il2CppClass<UICamera>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			if (obj11 != null)
			{
				nint num23 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ S0_v85 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num24 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ S1_v31 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj12 = (nint)0 & (nint)0x200;
			if (obj12 != null)
			{
				nint num25 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ S1_v38 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)mGenericHandler).FindKernel(text) != 0)
			{
				nint num26 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ S0_v72 (Il2CppClass<UICamera>)+BA]");
				object obj13 = (nint)0 & (nint)0x200;
				if (obj13 != null)
				{
					nint num27 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ S0_v79 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				mGenericHandler.BroadcastMessage((string)pressed, released, SendMessageOptions.DontRequireReceiver);
			}
		}
		nint num28 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ S0_v49 (Il2CppClass<UICamera>)+BA]");
		object obj14 = (nint)0 & (nint)0x200;
		if (obj14 != null)
		{
			nint num29 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ S0_v56 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num30 = mNotifying - 1;
		mNotifying = num30;
	}

	public static void CancelNextTooltip()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		Vector3[] mSides = default;
		UIRect.mSides = mSides;
	}

	public static bool ShowTooltip(GameObject go)
	{
		//IL_02a9: Expected I, but got Obj
		//IL_02bf: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00b2: Expected I, but got Obj
		//IL_00c8: Expected Obj, but got I
		//IL_00f3: Expected I, but got Obj
		//IL_0140: Expected I, but got Obj
		//IL_0156: Expected Obj, but got I
		//IL_01f6: Expected I, but got Obj
		//IL_020c: Expected Obj, but got I
		//IL_0181: Expected I, but got Obj
		//IL_0237: Expected I, but got Obj
		float unscaledDeltaTime = Time.unscaledDeltaTime;
		nint num = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v8 (Il2CppClass<UICamera>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v73 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!(mNextEvent < unscaledDeltaTime))
		{
			return false;
		}
		if ((object)go == null || ((UnityEngine.Object)go).m_CachedPtr == (IntPtr)0)
		{
			return false;
		}
		nint num3 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v22 (Il2CppClass<UICamera>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v62 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num5 = GetAxis.EndInvoke((IAsyncResult)(object)go);
		if (num5 > 0.75f)
		{
			nint num6 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v49 (Il2CppClass<UICamera>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num7 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S0_v58 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Ray ray = currentRay;
			float num8 = unscaledDeltaTime + 0.25f;
			mNextEvent = num8;
			return true;
		}
		if (num5 < -0.75f)
		{
			nint num9 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S0_v35 (Il2CppClass<UICamera>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num10 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S0_v44 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Ray ray2 = currentRay;
			float num11 = unscaledDeltaTime + 0.25f;
			mNextEvent = num11;
			return true;
		}
		return false;
	}

	public static bool HideTooltip()
	{
		//IL_0327: Expected I, but got Obj
		//IL_033d: Expected Obj, but got I
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Expected Obj, but got Unknown
		//IL_0246: Expected I, but got Obj
		//IL_025c: Expected Obj, but got I
		//IL_00af: Expected I, but got Obj
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Expected Obj, but got Unknown
		//IL_00fc: Expected I, but got Obj
		//IL_017c: Expected I, but got Obj
		//IL_0192: Expected Obj, but got I
		//IL_02a1: Expected I4, but got Obj
		//IL_01bd: Expected I, but got Obj
		object obj2 = default;
		bool result;
		object obj9 = default;
		while (true)
		{
			nint num = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v6 (Il2CppClass<UICamera>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v53 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			BetterList<UICamera> betterList = list;
			if ((nint)obj2 >= betterList.size)
			{
				result = false;
				break;
			}
			nint num3 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v15 (Il2CppClass<UICamera>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v46 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			BetterList<UICamera> betterList2 = list;
			object obj4 = betterList2.buffer + 16;
			object obj5 = obj2 << 2;
			object obj6 = obj4 + obj5;
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v27 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v42 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (!((UnityEngine.Object)obj6 != null) && ((Behaviour)obj6).isActiveAndEnabled)
			{
				string fileName = ((Component)obj6).tag;
				nint num7 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S1_v19 (Il2CppClass<NGUITools>)+BA]");
				object obj8 = (nint)0 & (nint)0x200;
				if (obj8 != null)
				{
					nint num8 = (nint)typeof(NGUITools);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S1_v24 (Il2CppClass<NGUITools>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				byte[] array = NGUITools.Load(fileName);
				result = (byte)(int)obj6 != 0;
				if (array != null)
				{
					break;
				}
			}
			obj2 = obj9 + 1;
		}
		return result;
	}

	public unsafe UICamera()
	{
		//IL_1e8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e91: Expected Obj, but got Unknown
		//IL_1e9a: Expected Obj, but got I4
		//IL_1ea8: Expected I, but got Obj
		//IL_1ebe: Expected Obj, but got I
		//IL_29f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_29fa: Expected VT, but got Unknown
		//IL_2a03: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a08: Expected Obj, but got Unknown
		//IL_2a11: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a16: Expected Obj, but got Unknown
		//IL_2a2e: Expected I, but got Obj
		//IL_2a44: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_02de: Expected I, but got Obj
		//IL_02f4: Expected Obj, but got I
		//IL_019b: Expected I, but got Obj
		//IL_01b1: Expected Obj, but got I
		//IL_1eeb: Expected Obj, but got I4
		//IL_1fbe: Expected Obj, but got I4
		//IL_1f7b: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		//IL_031f: Expected I, but got Obj
		//IL_01dc: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_036c: Expected I, but got Obj
		//IL_0382: Expected Obj, but got I
		//IL_0229: Expected I, but got Obj
		//IL_023f: Expected Obj, but got I
		//IL_1f1a: Expected Obj, but got I4
		//IL_1fed: Expected Obj, but got I4
		//IL_0404: Expected I, but got Obj
		//IL_041a: Expected Obj, but got I
		//IL_1faa: Expected Obj, but got I4
		//IL_012f: Expected I, but got Obj
		//IL_03ad: Expected I, but got Obj
		//IL_0686: Expected I, but got Obj
		//IL_069c: Expected Obj, but got I
		//IL_053f: Expected I, but got Obj
		//IL_0555: Expected Obj, but got I
		//IL_2002: Expected Obj, but got I4
		//IL_026a: Expected I, but got Obj
		//IL_20d3: Expected Obj, but got I4
		//IL_066a: Expected VT, but got I4
		//IL_2090: Expected Obj, but got I4
		//IL_0445: Expected I, but got Obj
		//IL_079d: Expected VT, but got I4
		//IL_06c7: Expected I, but got Obj
		//IL_0580: Expected I, but got Obj
		//IL_0492: Expected I, but got Obj
		//IL_04a8: Expected Obj, but got I
		//IL_0714: Expected I, but got Obj
		//IL_072a: Expected Obj, but got I
		//IL_05cd: Expected I, but got Obj
		//IL_05e3: Expected Obj, but got I
		//IL_2031: Expected VT, but got I4
		//IL_2102: Expected VT, but got I4
		//IL_0851: Expected I, but got Obj
		//IL_0867: Expected Obj, but got I
		//IL_07b0: Expected I, but got Obj
		//IL_07c6: Expected Obj, but got I
		//IL_20bf: Expected VT, but got I4
		//IL_04d3: Expected I, but got Obj
		//IL_0755: Expected I, but got Obj
		//IL_2111: Unknown result type (might be due to invalid IL or missing references)
		//IL_2116: Expected Obj, but got Unknown
		//IL_2127: Expected Obj, but got F4
		//IL_060e: Expected I, but got Obj
		//IL_0892: Expected I, but got Obj
		//IL_07f1: Expected I, but got Obj
		//IL_08df: Expected I, but got Obj
		//IL_08f5: Expected Obj, but got I
		//IL_2a7a: Expected I, but got Obj
		//IL_2a90: Expected Obj, but got I
		//IL_096d: Expected I, but got Obj
		//IL_0983: Expected Obj, but got I
		//IL_2180: Unknown result type (might be due to invalid IL or missing references)
		//IL_2185: Expected Obj, but got Unknown
		//IL_21b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_21b6: Expected Obj, but got Unknown
		//IL_0920: Expected I, but got Obj
		//IL_189e: Expected I, but got Obj
		//IL_0a09: Expected I, but got Obj
		//IL_0a1f: Expected Obj, but got I
		//IL_09ae: Expected I, but got Obj
		//IL_199a: Expected I, but got Obj
		//IL_19b0: Expected Obj, but got I
		//IL_18eb: Expected I, but got Obj
		//IL_1901: Expected Obj, but got I
		//IL_2888: Expected Obj, but got I4
		//IL_0a4a: Expected I, but got Obj
		//IL_19db: Expected I, but got Obj
		//IL_2835: Expected I, but got Obj
		//IL_284b: Expected Obj, but got I
		//IL_2868: Expected I, but got Obj
		//IL_192c: Expected I, but got Obj
		//IL_0a97: Expected I, but got Obj
		//IL_0aad: Expected Obj, but got I
		//IL_2b23: Expected Obj, but got I
		//IL_2b2c: Expected Obj, but got I4
		//IL_1a28: Expected I, but got Obj
		//IL_1a3e: Expected Obj, but got I
		//IL_1e28: Expected I, but got Obj
		//IL_1e58: Expected I, but got Obj
		//IL_0d37: Expected I, but got Obj
		//IL_0d4d: Expected Obj, but got I
		//IL_0ad8: Expected I, but got Obj
		//IL_2897: Unknown result type (might be due to invalid IL or missing references)
		//IL_289c: Expected Obj, but got Unknown
		//IL_0b25: Expected I, but got Obj
		//IL_0b3b: Expected Obj, but got I
		//IL_2952: Unknown result type (might be due to invalid IL or missing references)
		//IL_2957: Expected Obj, but got Unknown
		//IL_1a69: Expected I, but got Obj
		//IL_1e7e: Expected I, but got Obj
		//IL_0d78: Expected I, but got Obj
		//IL_2330: Unknown result type (might be due to invalid IL or missing references)
		//IL_2335: Expected Obj, but got Unknown
		//IL_2267: Expected I, but got Obj
		//IL_227d: Expected Obj, but got I
		//IL_1ab6: Expected I, but got Obj
		//IL_1acc: Expected Obj, but got I
		//IL_0dc5: Expected I, but got Obj
		//IL_0ddb: Expected Obj, but got I
		//IL_0b66: Expected I, but got Obj
		//IL_23a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_23a5: Expected Obj, but got Unknown
		//IL_0c74: Expected I, but got Obj
		//IL_0c8a: Expected Obj, but got I
		//IL_0bb3: Expected I, but got Obj
		//IL_1af7: Expected I, but got Obj
		//IL_0e64: Expected I, but got Obj
		//IL_0e7a: Expected Obj, but got I
		//IL_0e06: Expected I, but got Obj
		//IL_22f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_22fb: Expected Obj, but got Unknown
		//IL_0c00: Expected I, but got Obj
		//IL_0c16: Expected Obj, but got I
		//IL_1b67: Expected Obj, but got I4
		//IL_1b6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b74: Expected Obj, but got Unknown
		//IL_108f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1094: Expected Obj, but got Unknown
		//IL_10a2: Expected I, but got Obj
		//IL_10b8: Expected Obj, but got I
		//IL_0cb5: Expected I, but got Obj
		//IL_0c41: Expected I, but got Obj
		//IL_13f1: Expected I, but got Obj
		//IL_1407: Expected Obj, but got I
		//IL_10e3: Expected I, but got Obj
		//IL_1130: Expected I, but got Obj
		//IL_1146: Expected Obj, but got I
		//IL_1bc3: Expected I, but got Obj
		//IL_1bd9: Expected Obj, but got I
		//IL_23f1: Expected I, but got Obj
		//IL_2407: Expected Obj, but got I
		//IL_1432: Expected I, but got Obj
		//IL_2521: Unknown result type (might be due to invalid IL or missing references)
		//IL_2526: Expected Obj, but got Unknown
		//IL_1c7b: Expected Obj, but got I4
		//IL_1c84: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c89: Expected Obj, but got Unknown
		//IL_1c91: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c96: Expected Obj, but got Unknown
		//IL_293b: Expected Obj, but got I4
		//IL_11cf: Expected I, but got Obj
		//IL_11e5: Expected Obj, but got I
		//IL_1171: Expected I, but got Obj
		//IL_1c04: Expected I, but got Obj
		//IL_0fdd: Expected I, but got Obj
		//IL_0ff3: Expected Obj, but got I
		//IL_0f36: Expected I, but got Obj
		//IL_1ccc: Expected I, but got Obj
		//IL_1ce2: Expected Obj, but got I
		//IL_247d: Expected F4, but got I
		//IL_2478: Expected native int or pointer, but got VT
		//IL_249e: Expected I4, but got Obj
		//IL_0f69: Expected I, but got Obj
		//IL_0f7f: Expected Obj, but got I
		//IL_14ec: Expected I, but got Obj
		//IL_1502: Expected Obj, but got I
		//IL_1210: Expected I, but got Obj
		//IL_101e: Expected I, but got Obj
		//IL_1db4: Expected I, but got Obj
		//IL_1dca: Expected Obj, but got I
		//IL_1d0d: Expected I, but got Obj
		//IL_0faa: Expected I, but got Obj
		//IL_1588: Expected Obj, but got I4
		//IL_152d: Expected I, but got Obj
		//IL_29c6: Expected F4, but got Obj
		//IL_29c1: Expected native int or pointer, but got VT
		//IL_29e7: Expected I4, but got Obj
		//IL_1d40: Expected I, but got Obj
		//IL_1d56: Expected Obj, but got I
		//IL_257a: Expected I, but got Obj
		//IL_2590: Expected Obj, but got I
		//IL_1df5: Expected I, but got Obj
		//IL_29ab: Expected I, but got Obj
		//IL_15be: Expected I, but got Obj
		//IL_15d4: Expected Obj, but got I
		//IL_1d81: Expected I, but got Obj
		//IL_26b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_26bb: Expected Obj, but got Unknown
		//IL_1348: Expected I, but got Obj
		//IL_135e: Expected Obj, but got I
		//IL_12a1: Expected I, but got Obj
		//IL_165d: Expected I, but got Obj
		//IL_1673: Expected Obj, but got I
		//IL_15ff: Expected I, but got Obj
		//IL_2606: Expected F4, but got I
		//IL_2601: Expected native int or pointer, but got VT
		//IL_2627: Expected I4, but got Obj
		//IL_12d4: Expected I, but got Obj
		//IL_12ea: Expected Obj, but got I
		//IL_1389: Expected I, but got Obj
		//IL_1315: Expected I, but got Obj
		//IL_16e5: Expected Obj, but got F4
		//IL_1701: Expected I, but got Obj
		//IL_1717: Expected Obj, but got I
		//IL_270f: Expected F4, but got Obj
		//IL_270a: Expected native int or pointer, but got VT
		//IL_2736: Expected I, but got Obj
		//IL_274c: Expected Obj, but got I
		//IL_1742: Expected I, but got Obj
		//IL_181c: Expected I, but got Obj
		//IL_1832: Expected Obj, but got I
		//IL_1775: Expected I, but got Obj
		//IL_27ca: Expected F4, but got Obj
		//IL_27c5: Expected native int or pointer, but got VT
		//IL_27eb: Expected I4, but got Obj
		//IL_17a8: Expected I, but got Obj
		//IL_17be: Expected Obj, but got I
		//IL_185d: Expected I, but got Obj
		//IL_27a5: Expected F4, but got Obj
		//IL_27a0: Expected native int or pointer, but got VT
		//IL_17e9: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 24;
		obj = 0;
		nint num = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (Il2CppClass<UICamera>)+BA]");
		if ((object)((nint)0 & (nint)0x200) != null)
		{
			nint num2 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v754 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector2 vector = (Vector2)(obj2 + 32);
		object obj3 = obj2 + 16;
		object obj4 = obj2 + 8;
		currentTouchID = -100;
		nint num3 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v24 (Il2CppClass<UICamera>)+5C]");
		object obj5 = (nint)0 + (nint)160;
		obj5 = controller;
		UIColorPicker uIColorPicker;
		if (submitKey0 != KeyCode.None)
		{
			nint num4 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v736 (Il2CppClass<UICamera>)+BA]");
			if ((object)((nint)0 & (nint)0x200) != null)
			{
				nint num5 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v748 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (GetKeyDown.EndInvoke((IAsyncResult)submitKey0))
			{
				nint num6 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S1_v357 (Il2CppClass<UICamera>)+BA]");
				if ((object)((nint)0 & (nint)0x200) != null)
				{
					nint num7 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ S1_v362 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Ray ray = currentRay;
				uIColorPicker = (UIColorPicker)1;
				goto IL_1f1f;
			}
		}
		if (submitKey1 != KeyCode.None)
		{
			nint num8 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v718 (Il2CppClass<UICamera>)+BA]");
			if ((object)((nint)0 & (nint)0x200) != null)
			{
				nint num9 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S0_v729 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (GetKeyDown.EndInvoke((IAsyncResult)submitKey1))
			{
				nint num10 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ S1_v344 (Il2CppClass<UICamera>)+BA]");
				if ((object)((nint)0 & (nint)0x200) != null)
				{
					nint num11 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ S1_v349 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Ray ray = currentRay;
				uIColorPicker = (UIColorPicker)1;
				goto IL_1f1f;
			}
		}
		if (submitKey0 != KeyCode.Return)
		{
			bool flag = submitKey1 != KeyCode.Return;
			uIColorPicker = null;
			if (flag)
			{
				goto IL_1f1f;
			}
		}
		nint num12 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S0_v698 (Il2CppClass<UICamera>)+BA]");
		if ((object)((nint)0 & (nint)0x200) != null)
		{
			nint num13 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ S0_v710 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (GetKeyDown.EndInvoke((IAsyncResult)271))
		{
			nint num14 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ S1_v328 (Il2CppClass<UICamera>)+BA]");
			if ((object)((nint)0 & (nint)0x200) != null)
			{
				nint num15 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ S1_v333 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Ray ray = currentRay;
			uIColorPicker = (UIColorPicker)1;
		}
		else
		{
			uIColorPicker = null;
		}
		goto IL_1f1f;
		IL_198c:
		nint num16 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v700 @ S0_v66 (Il2CppClass<NGUITools>)+BA]");
		if ((object)((nint)0 & (nint)0x200) != null)
		{
			nint num17 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v749 @ S0_v176 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		KeyCode[] keys = NGUITools.keys;
		object obj22;
		nint num20;
		bool released = default;
		for (object obj6 = 0; (nint)obj6 < keys.Length; obj22 = obj6 + 1, obj6 = obj22)
		{
			nint num18 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v816 @ S0_v79 (Il2CppClass<NGUITools>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num19 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v877 @ S0_v170 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj8 = NGUITools.keys + 16;
			object obj9 = obj6 << 2;
			object obj10 = obj8 + obj9;
			if (num20 == (nint)obj10)
			{
				continue;
			}
			nint num21 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v915 @ S0_v89 (Il2CppClass<UICamera>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			if (obj11 != null)
			{
				nint num22 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v969 @ S0_v164 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (!GetKeyDown.EndInvoke((IAsyncResult)obj10))
			{
				continue;
			}
			bool flag2 = (nint)obj10 < 323;
			bool flag3 = useKeyboard;
			object obj12 = (flag3 ? 1 : 0) ^ 1;
			object obj13 = flag2 & obj12;
			if (obj13 != null)
			{
				continue;
			}
			if (~(useController ? 1u : 0u) == 0)
			{
				nint num23 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1131 @ S0_v152 (Il2CppClass<UICamera>)+BA]");
				object obj14 = (nint)0 & (nint)0x200;
				if (obj14 != null)
				{
					nint num24 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1184 @ S0_v159 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag4 = (nint)obj10 > 329;
				bool flag5 = ignoreControllerInput;
				object obj15 = flag4 & flag5;
				if (obj15 != null)
				{
					continue;
				}
			}
			else if ((nint)obj10 > 329)
			{
				continue;
			}
			bool flag6 = (nint)obj10 < 330;
			bool flag7 = useMouse;
			object obj16 = flag2 | flag7;
			object obj17 = obj16 ^ 1;
			object obj18 = flag6 & obj17;
			if (obj18 != null)
			{
				continue;
			}
			nint num25 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1218 @ S0_v109 (Il2CppClass<UICamera>)+BA]");
			object obj19 = (nint)0 & (nint)0x200;
			if (obj19 != null)
			{
				nint num26 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1241 @ S0_v146 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Ray ray = currentRay;
			if (onKey != null)
			{
				nint num27 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1316 @ S0_v134 (Il2CppClass<UICamera>)+BA]");
				object obj20 = (nint)0 & (nint)0x200;
				if (obj20 != null)
				{
					nint num28 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1356 @ S0_v141 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				MouseOrTouch mouseOrTouch = currentTouch;
				onKey._002Ector(mouseOrTouch.current, (IntPtr)obj10);
			}
			nint num29 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1334 @ S0_v120 (Il2CppClass<UICamera>)+BA]");
			object obj21 = (nint)0 & (nint)0x200;
			if (obj21 != null)
			{
				nint num30 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1367 @ S0_v128 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			MouseOrTouch mouseOrTouch2 = currentTouch;
			((Vector2*)(nint)vector)->x = (float)obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			((UICamera)(object)mouseOrTouch2.current).ProcessTouch((byte)(int)"OnKey" != 0, released);
		}
		goto IL_2827;
		IL_2a6c:
		nint num31 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v534 @ S0_v41 (Il2CppClass<UICamera>)+BA]");
		object obj23 = (nint)0 & (nint)0x200;
		if (obj23 != null)
		{
			nint num32 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v557 @ S0_v200 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (GetAnyKeyDown != null)
		{
			nint num33 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v622 @ S0_v186 (Il2CppClass<UICamera>)+BA]");
			if ((object)((nint)0 & (nint)0x200) != null)
			{
				nint num34 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v636 @ S0_v194 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A082");
			object obj24 = default;
			if (obj24 != null)
			{
				goto IL_198c;
			}
		}
		else if (Input.inputString != null)
		{
			goto IL_198c;
		}
		goto IL_2827;
		IL_1f1f:
		Color color;
		if (submitKey0 != KeyCode.None)
		{
			nint num35 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ S0_v671 (Il2CppClass<UICamera>)+BA]");
			if ((object)((nint)0 & (nint)0x200) != null)
			{
				nint num36 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ S0_v683 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (GetKeyUp.EndInvoke((IAsyncResult)submitKey0))
			{
				nint num37 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ S1_v312 (Il2CppClass<UICamera>)+BA]");
				if ((object)((nint)0 & (nint)0x200) != null)
				{
					nint num38 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ S1_v317 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Ray ray = currentRay;
				color = (Color)1;
				goto IL_2036;
			}
		}
		if (submitKey1 != KeyCode.None)
		{
			nint num39 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ S0_v653 (Il2CppClass<UICamera>)+BA]");
			if ((object)((nint)0 & (nint)0x200) != null)
			{
				nint num40 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ S0_v664 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (GetKeyUp.EndInvoke((IAsyncResult)submitKey1))
			{
				nint num41 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ S1_v299 (Il2CppClass<UICamera>)+BA]");
				if ((object)((nint)0 & (nint)0x200) != null)
				{
					nint num42 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ S1_v304 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Ray ray = currentRay;
				color = (Color)1;
				goto IL_2036;
			}
		}
		if (submitKey0 != KeyCode.Return)
		{
			bool flag8 = submitKey1 != KeyCode.Return;
			color = (Color)0;
			if (flag8)
			{
				goto IL_2036;
			}
		}
		nint num43 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ S0_v633 (Il2CppClass<UICamera>)+BA]");
		if ((object)((nint)0 & (nint)0x200) != null)
		{
			nint num44 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ S0_v645 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (GetKeyUp.EndInvoke((IAsyncResult)271))
		{
			nint num45 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ S1_v283 (Il2CppClass<UICamera>)+BA]");
			if ((object)((nint)0 & (nint)0x200) != null)
			{
				nint num46 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ S1_v288 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Ray ray = currentRay;
			color = (Color)1;
		}
		else
		{
			color = (Color)0;
		}
		goto IL_2036;
		IL_212c:
		if (~(useController ? 1u : 0u) == 0)
		{
			nint num47 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v482 @ S0_v208 (Il2CppClass<UICamera>)+BA]");
			if ((object)((nint)0 & (nint)0x200) != null)
			{
				nint num48 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ S0_v568 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (~(ignoreControllerInput ? 1u : 0u) != 0)
			{
				nint num49 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v551 @ S0_v217 (Il2CppClass<UICamera>)+BA]");
				if ((object)((nint)0 & (nint)0x200) != null)
				{
					nint num50 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v611 @ S0_v563 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if ((object)first == null)
				{
					nint num51 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v661 @ S0_v504 (Il2CppClass<UICamera>)+BA]");
					if ((object)((nint)0 & (nint)0x200) != null)
					{
						nint num52 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v706 @ S0_v559 (Il2CppClass<UICamera>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (currentKey == (KeyCode)2)
					{
						nint num53 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v797 @ S0_v512 (Il2CppClass<UICamera>)+BA]");
						if ((object)((nint)0 & (nint)0x200) != null)
						{
							nint num54 = (nint)typeof(UICamera);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v822 @ S0_v553 (Il2CppClass<UICamera>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						MouseOrTouch mouseOrTouch3 = currentTouch;
						nint num55 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v836 @ S1_v242 (Il2CppClass<UnityEngine.Object>)+BA]");
						if ((object)((nint)0 & (nint)0x200) != null)
						{
							nint num56 = (nint)typeof(UnityEngine.Object);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v900 @ S1_v254 (Il2CppClass<UnityEngine.Object>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						if (!(mouseOrTouch3.current != null))
						{
							nint num57 = (nint)typeof(UICamera);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v981 @ S0_v539 (Il2CppClass<UICamera>)+BA]");
							if ((object)((nint)0 & (nint)0x200) != null)
							{
								nint num58 = (nint)typeof(UICamera);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1046 @ S0_v548 (Il2CppClass<UICamera>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							if (currentTouch.current.tag != null)
							{
								goto IL_22c3;
							}
						}
						nint num59 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v991 @ S0_v524 (Il2CppClass<UICamera>)+BA]");
						if ((object)((nint)0 & (nint)0x200) != null)
						{
							nint num60 = (nint)typeof(UICamera);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1055 @ S0_v532 (Il2CppClass<UICamera>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						object obj25 = currentTouch + 52;
						obj25 = selectedObject;
					}
				}
				goto IL_22c3;
			}
			num20 = 0;
		}
		else
		{
			num20 = 0;
		}
		goto IL_2a6c;
		IL_2036:
		if ((object)uIColorPicker != null)
		{
			nint num61 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ S0_v610 (Il2CppClass<UICamera>)+BA]");
			if ((object)((nint)0 & (nint)0x200) != null)
			{
				nint num62 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ S0_v618 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj26 = currentTouch - -64;
			obj26 = Time.unscaledDeltaTime;
		}
		else if ((int)color == 0)
		{
			goto IL_212c;
		}
		nint num63 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ S0_v576 (Il2CppClass<UICamera>)+BA]");
		if ((object)((nint)0 & (nint)0x200) != null)
		{
			nint num64 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ S0_v604 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (currentKey == (KeyCode)2)
		{
			nint num65 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ S0_v584 (Il2CppClass<UICamera>)+BA]");
			if ((object)((nint)0 & (nint)0x200) != null)
			{
				nint num66 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v570 @ S0_v598 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj27 = currentTouch + 52;
			obj27 = selectedObject;
			Vector2 vector2 = uIColorPicker.Select(color);
			object obj28 = currentTouch + 48;
			obj28 = currentTouch.current;
		}
		goto IL_212c;
		IL_2827:
		nint num67 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ S0_v50 (Il2CppClass<UICamera>)+BA]");
		object obj29 = (nint)0 & (nint)0x200;
		bool flag9 = obj29 == null;
		nint num68 = (nint)typeof(UICamera);
		if (!flag9)
		{
			nint num69 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v766 @ S0_v58 (Il2CppClass<UICamera>)+74]");
			bool flag10 = (nint)0 != 0;
			num68 = (nint)typeof(UICamera);
			if (!flag10)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num68 = (nint)typeof(UICamera);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v770 @ L0_v2 (Il2CppClass<UICamera>)+5C]");
		object obj30 = (nint)0 + (nint)160;
		obj30 = 0;
		return;
		IL_22c3:
		string text = verticalAxisName;
		nint num70;
		if (verticalAxisName == null || text.m_stringLength == 0)
		{
			num70 = 0;
		}
		else
		{
			nint num71 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v807 @ S1_v196 (Il2CppClass<UICamera>)+BA]");
			if ((object)((nint)0 & (nint)0x200) != null)
			{
				nint num72 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v868 @ S1_v234 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag11 = ShowTooltip((GameObject)(object)verticalAxisName);
			if (flag11)
			{
				nint num73 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v962 @ S0_v427 (Il2CppClass<UICamera>)+BA]");
				if ((object)((nint)0 & (nint)0x200) != null)
				{
					nint num74 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1035 @ S0_v494 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				BMFont bmFont = ((UIFont)null).bmFont;
				currentKey = (KeyCode)2;
				object obj31 = currentTouch + 52;
				obj31 = selectedObject;
				MouseOrTouch mouseOrTouch4 = currentTouch;
				nint num75 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1125 @ S1_v208 (Il2CppClass<UnityEngine.Object>)+BA]");
				if ((object)((nint)0 & (nint)0x200) != null)
				{
					UIColorPicker typeFromHandle = (UIColorPicker)(object)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1174 @ S1_v230 (UIColorPicker)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)(object)mouseOrTouch4.current).FindKernel((string)null) != 0)
				{
					num70 = (((flag11 ? 1 : 0) <= (false ? 1 : 0)) ? 274 : 273);
					nint num76 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1309 @ S0_v451 (Il2CppClass<UICamera>)+BA]");
					if ((object)((nint)0 & (nint)0x200) != null)
					{
						nint num77 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1346 @ S0_v487 (Il2CppClass<UICamera>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (onNavigate != null)
					{
						nint num78 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1399 @ S0_v475 (Il2CppClass<UICamera>)+BA]");
						if ((object)((nint)0 & (nint)0x200) != null)
						{
							nint num79 = (nint)typeof(UICamera);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1430 @ S0_v482 (Il2CppClass<UICamera>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						MouseOrTouch mouseOrTouch5 = currentTouch;
						onNavigate._002Ector(mouseOrTouch5.current, num70);
					}
					nint num80 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1417 @ S0_v460 (Il2CppClass<UICamera>)+BA]");
					if ((object)((nint)0 & (nint)0x200) != null)
					{
						nint num81 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1441 @ S0_v469 (Il2CppClass<UICamera>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					MouseOrTouch mouseOrTouch6 = currentTouch;
					((Vector2*)(nint)vector)->x = num70;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
					bool released2 = default;
					((UICamera)(object)mouseOrTouch6.current).ProcessTouch((byte)(int)"OnNavigate" != 0, released2);
				}
				else
				{
					num70 = 0;
				}
			}
			else
			{
				num70 = 0;
			}
		}
		object obj32 = this - -64;
		object obj33 = obj32;
		bool flag12;
		if (obj32 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v865 @ S0_v231+8]");
			flag12 = (nint)0 == 0;
		}
		else
		{
			flag12 = true;
		}
		bool flag13 = !flag12;
		bool flag14 = !flag13;
		num20 = num70;
		if (!flag14)
		{
			object go = this - -64;
			nint num82 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1002 @ S1_v154 (Il2CppClass<UICamera>)+BA]");
			if ((object)((nint)0 & (nint)0x200) != null)
			{
				nint num83 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1067 @ S1_v191 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag15 = ShowTooltip((GameObject)go);
			bool flag16 = !flag15;
			num20 = num70;
			if (!flag16)
			{
				nint num84 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1106 @ S0_v349 (Il2CppClass<UICamera>)+BA]");
				if ((object)((nint)0 & (nint)0x200) != null)
				{
					nint num85 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1137 @ S0_v414 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				BMFont bmFont2 = ((UIFont)null).bmFont;
				currentKey = (KeyCode)2;
				object obj34 = currentTouch + 52;
				GameObject gameObject = selectedObject;
				obj34 = gameObject;
				MouseOrTouch mouseOrTouch7 = currentTouch;
				nint num86 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1253 @ S1_v166 (Il2CppClass<UnityEngine.Object>)+BA]");
				if ((object)((nint)0 & (nint)0x200) != null)
				{
					nint num87 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1280 @ S1_v187 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				int num88 = ((ComputeShader)(object)mouseOrTouch7.current).FindKernel((string)null);
				bool flag17 = num88 == 0;
				num20 = num70;
				if (!flag17)
				{
					IntPtr intPtr = (IntPtr)(((flag15 ? 1 : 0) <= (false ? 1 : 0)) ? 276 : 275);
					nint num89 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1461 @ S0_v371 (Il2CppClass<UICamera>)+BA]");
					object obj35 = (nint)0 & (nint)0x200;
					if (obj35 != null)
					{
						nint num90 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1478 @ S0_v407 (Il2CppClass<UICamera>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (onNavigate != null)
					{
						nint num91 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1503 @ S0_v395 (Il2CppClass<UICamera>)+BA]");
						if ((object)((nint)0 & (nint)0x200) != null)
						{
							nint num92 = (nint)typeof(UICamera);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1534 @ S0_v402 (Il2CppClass<UICamera>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						MouseOrTouch mouseOrTouch8 = currentTouch;
						onNavigate._002Ector(mouseOrTouch8.current, intPtr);
					}
					nint num93 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1521 @ S0_v380 (Il2CppClass<UICamera>)+BA]");
					if ((object)((nint)0 & (nint)0x200) != null)
					{
						nint num94 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1545 @ S0_v389 (Il2CppClass<UICamera>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					MouseOrTouch mouseOrTouch9 = currentTouch;
					((Vector2*)(nint)vector)->x = (nint)intPtr;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
					bool released3 = default;
					((UICamera)(object)mouseOrTouch9.current).ProcessTouch((byte)(int)"OnNavigate" != 0, released3);
					num20 = intPtr;
				}
			}
		}
		string text2 = horizontalPanAxisName;
		float num95;
		if (horizontalPanAxisName == null || text2.m_stringLength == 0)
		{
			num95 = 0f;
		}
		else
		{
			nint num96 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1113 @ S0_v325 (Il2CppClass<UICamera>)+BA]");
			if ((object)((nint)0 & (nint)0x200) != null)
			{
				nint num97 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1163 @ S0_v333 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			num95 = GetAxis.EndInvoke((IAsyncResult)(object)horizontalPanAxisName);
		}
		bool flag18 = num95 == 0f;
		string text3 = verticalPanAxisName;
		float num98;
		if (verticalPanAxisName == null || text3.m_stringLength == 0)
		{
			num98 = 0f;
		}
		else
		{
			nint num99 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1260 @ S1_v130 (Il2CppClass<UICamera>)+BA]");
			if ((object)((nint)0 & (nint)0x200) != null)
			{
				nint num100 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1296 @ S1_v138 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			num98 = GetAxis.EndInvoke((IAsyncResult)(object)verticalPanAxisName);
		}
		if ((object)(flag18 & (num98 == 0f)) == null)
		{
			nint num101 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1340 @ S0_v243 (Il2CppClass<UICamera>)+BA]");
			if ((object)((nint)0 & (nint)0x200) != null)
			{
				nint num102 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1386 @ S0_v320 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			BMFont bmFont3 = ((UIFont)null).bmFont;
			currentKey = (KeyCode)2;
			object obj36 = currentTouch + 52;
			GameObject gameObject2 = selectedObject;
			obj36 = gameObject2;
			MouseOrTouch mouseOrTouch10 = currentTouch;
			nint num103 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1494 @ S1_v96 (Il2CppClass<UnityEngine.Object>)+BA]");
			if ((object)((nint)0 & (nint)0x200) != null)
			{
				UIColorPicker typeFromHandle2 = (UIColorPicker)(object)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1526 @ S1_v125 (UIColorPicker)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)mouseOrTouch10.current).FindKernel((string)null) != 0)
			{
				obj = num95;
				float fixedDeltaTime = Time.fixedDeltaTime;
				nint num104 = (nint)typeof(Vector2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1576 @ S0_v268 (Il2CppClass<UnityEngine.Vector2>)+BA]");
				if ((object)((nint)0 & (nint)0x200) != null)
				{
					nint num105 = (nint)typeof(Vector2);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1582 @ S0_v317 (Il2CppClass<UnityEngine.Vector2>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj3 = obj;
				((Vector2*)(nint)vector)->x = (float)obj3;
				Vector2 vector3 = vector / fixedDeltaTime;
				obj = obj2;
				nint num106 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1599 @ S0_v277 (Il2CppClass<UICamera>)+BA]");
				object obj37 = (nint)0 & (nint)0x200;
				if (obj37 != null)
				{
					nint num107 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1605 @ S0_v312 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (onPan != null)
				{
					nint num108 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1617 @ S0_v300 (Il2CppClass<UICamera>)+BA]");
					if ((object)((nint)0 & (nint)0x200) != null)
					{
						nint num109 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1641 @ S0_v307 (Il2CppClass<UICamera>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					MouseOrTouch mouseOrTouch11 = currentTouch;
					obj4 = obj;
					((Vector2*)(nint)vector)->x = (float)obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A09E");
				}
				nint num110 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1635 @ S0_v286 (Il2CppClass<UICamera>)+BA]");
				if ((object)((nint)0 & (nint)0x200) != null)
				{
					nint num111 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1658 @ S0_v294 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				MouseOrTouch mouseOrTouch12 = currentTouch;
				((Vector2*)(nint)vector)->x = (float)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				bool released4 = default;
				((UICamera)(object)mouseOrTouch12.current).ProcessTouch((byte)(int)"OnPan" != 0, released4);
			}
		}
		goto IL_2a6c;
	}

	static UICamera()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UICamera>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		mTooltipTime = 0f;
	}
}
