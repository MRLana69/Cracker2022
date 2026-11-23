using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

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

		public ClickNotification clickNotification = ClickNotification.Always;

		public bool touchBegan = true;

		public bool pressStarted;

		public bool dragStarted;

		public int ignoreDelta;

		public float deltaTime
		{
			get
			{
				float unscaledTime = Time.unscaledTime;
				return unscaledTime - pressTime;
			}
		}

		public bool isOverUI
		{
			get
			{
				bool flag = current != null;
				bool flag2 = !flag;
				bool result = false;
				if (!flag2)
				{
					bool flag3 = current != fallThrough;
					bool flag4 = !flag3;
					result = false;
					if (!flag4)
					{
						UIRoot uIRoot = NGUITools.FindInParents<UIRoot>(current);
						bool flag5 = uIRoot != null;
						result = flag5;
					}
				}
				return result;
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

	public delegate void OnScreenResize();

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
	}

	public delegate int GetTouchCountCallback();

	public delegate Touch GetTouchCallback(int index);

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<UICamera, bool> _003C_003E9__162_0;

		public static Func<UICamera, float> _003C_003E9__162_1;

		public static BetterList<DepthEntry>.CompareFunc _003C_003E9__169_0;

		public static BetterList<DepthEntry>.CompareFunc _003C_003E9__169_1;

		static _003C_003Ec()
		{
			_003C_003Ec obj = default;
			_003C_003E9 = obj;
		}

		internal bool _003Cget_eventHandler_003Eb__162_0(UICamera e)
		{
			return e != null;
		}

		internal float _003Cget_eventHandler_003Eb__162_1(UICamera e)
		{
			Camera cachedCamera = e.cachedCamera;
			return cachedCamera.depth;
		}

		internal int _003CRaycast_003Eb__169_0(DepthEntry r1, DepthEntry r2)
		{
			if (r2.depth >= r1.depth)
			{
				return (r2.depth > r1.depth) ? 1 : 0;
			}
			return -1;
		}

		internal int _003CRaycast_003Eb__169_1(DepthEntry r1, DepthEntry r2)
		{
			if (r2.depth >= r1.depth)
			{
				return (r2.depth > r1.depth) ? 1 : 0;
			}
			return -1;
		}
	}

	public static BetterList<UICamera> list;

	public static GetKeyStateFunc GetKeyDown;

	public static GetKeyStateFunc GetKeyUp;

	public static GetKeyStateFunc GetKey;

	public static GetAxisFunc GetAxis;

	public static GetAnyKeyFunc GetAnyKeyDown;

	public static OnScreenResize onScreenResize;

	public EventType eventType = EventType.UI_3D;

	public bool eventsGoToColliders;

	public LayerMask eventReceiverMask = (LayerMask)(-1);

	public bool debug;

	public bool useMouse = true;

	public bool useTouch;

	public bool allowMultiTouch;

	public bool useKeyboard;

	public bool useController = true;

	public bool stickyTooltip;

	public float tooltipDelay = 1f;

	public bool longPressTooltip;

	public float mouseDragThreshold = 4f;

	public float mouseClickThreshold;

	public float touchDragThreshold = 40f;

	public float touchClickThreshold;

	public float rangeDistance = -1f;

	public string horizontalAxisName = "Horizontal";

	public string verticalAxisName = "Vertical";

	public string horizontalPanAxisName;

	public string verticalPanAxisName;

	public string scrollAxisName = "Mouse ScrollWheel";

	public bool commandClick = true;

	public KeyCode submitKey0 = KeyCode.Return;

	public KeyCode submitKey1;

	public KeyCode cancelKey0 = KeyCode.Escape;

	public KeyCode cancelKey1;

	public static OnCustomInput onCustomInput;

	public static bool showTooltips;

	private static bool mDisableController;

	private static Vector2 mLastPos;

	public static Vector3 lastWorldPosition;

	public static RaycastHit lastHit;

	public static UICamera current;

	public static Camera currentCamera;

	public static OnSchemeChange onSchemeChange;

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

	private static GameObject mRayHitObject;

	private static GameObject mHover;

	private static GameObject mSelected;

	private static DepthEntry mHit;

	private static BetterList<DepthEntry> mHits;

	private static Plane m2DPlane;

	private static float mNextEvent;

	private static int mNotifying;

	private static bool mUsingTouchEvents;

	public static GetTouchCountCallback GetInputTouchCount;

	public static GetTouchCallback GetInputTouch;

	private static BetterList<UICamera>.CompareFunc _003C_003Ef__mg_0024cache0;

	private static GetKeyStateFunc _003C_003Ef__mg_0024cache1;

	private static GetKeyStateFunc _003C_003Ef__mg_0024cache2;

	private static GetKeyStateFunc _003C_003Ef__mg_0024cache3;

	private static GetAxisFunc _003C_003Ef__mg_0024cache4;

	public bool stickyPress => true;

	public static bool disableController
	{
		get
		{
			if (~(mDisableController ? 1u : 0u) == 0)
			{
				bool isOpen = UIPopupList.isOpen;
				return (byte)((isOpen ? 1u : 0u) ^ 1u) != 0;
			}
			return false;
		}
		set
		{
			mDisableController = value;
		}
	}

	public unsafe static Vector2 lastTouchPosition
	{
		get
		{
			//IL_0013: Expected F4, but got VT
			//IL_000e: Expected native int or pointer, but got VT
			Vector2 vector = default;
			((Vector2*)(nint)vector)->x = (float)mLastPos;
			return vector;
		}
		set
		{
			//IL_0013: Expected VT, but got F4
			mLastPos = (Vector2)value.x;
		}
	}

	public unsafe static Vector2 lastEventPosition
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			//IL_0173: Unknown result type (might be due to invalid IL or missing references)
			//IL_0178: Expected Obj, but got Unknown
			//IL_0181: Expected Obj, but got I4
			//IL_015f: Expected F4, but got VT
			//IL_015a: Expected native int or pointer, but got VT
			//IL_0082: Unknown result type (might be due to invalid IL or missing references)
			//IL_0087: Expected Obj, but got Unknown
			//IL_0097: Expected Obj, but got I
			//IL_00ff: Expected F4, but got I
			//IL_00fa: Expected native int or pointer, but got VT
			//IL_0121: Expected F4, but got I
			//IL_011c: Expected native int or pointer, but got VT
			//IL_014c: Expected F4, but got I
			//IL_0147: Expected native int or pointer, but got VT
			object obj = default;
			Vector3 vector = (Vector3)(obj - 80);
			_ = 0;
			object obj2 = vector - -64;
			obj2 = 0;
			_ = 0;
			ControlScheme controlScheme = currentScheme;
			Vector2 vector3 = default;
			if (controlScheme == ControlScheme.Controller)
			{
				GameObject gameObject = hoveredObject;
				if (gameObject != null)
				{
					Transform trans = gameObject.transform;
					Bounds bounds = NGUIMath.CalculateAbsoluteWidgetBounds(trans);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
					_ = 0;
					object obj3 = vector - -64;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
					obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
					_ = 0;
					int layer = gameObject.layer;
					Camera camera = NGUITools.FindCameraForLayer(layer);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
					((Vector3*)(nint)vector)->z = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
					((Vector3*)(nint)vector)->x = 0f;
					Vector3 vector2 = camera.WorldToScreenPoint(vector);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
					((Vector2*)(nint)vector3)->x = 0f;
					goto IL_01b0;
				}
			}
			((Vector2*)(nint)vector3)->x = (float)mLastPos;
			goto IL_01b0;
			IL_01b0:
			return vector3;
		}
		set
		{
			//IL_0013: Expected VT, but got F4
			mLastPos = (Vector2)value.x;
		}
	}

	public static ControlScheme currentScheme
	{
		get
		{
			if (mCurrentKey != KeyCode.None)
			{
				bool flag = mCurrentKey > KeyCode.Mouse6;
				return (ControlScheme)((flag ? 1u : 0u) << 1);
			}
			return ControlScheme.Touch;
		}
		set
		{
			//IL_0013: Expected Obj, but got I4
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected Obj, but got Unknown
			//IL_0029: Expected I4, but got Obj
			bool flag = value <= ControlScheme.Controller;
			bool flag2 = !flag;
			KeyCode keyCode = KeyCode.Alpha0;
			if (!flag2)
			{
				object obj = (int)value << 2;
				object obj2 = obj + 2293152;
				keyCode = (KeyCode)obj2;
			}
			currentKey = keyCode;
		}
	}

	public static KeyCode currentKey
	{
		get
		{
			return mCurrentKey;
		}
		set
		{
			if (mCurrentKey == value)
			{
				return;
			}
			ControlScheme controlScheme = currentScheme;
			mCurrentKey = value;
			ControlScheme controlScheme2 = currentScheme;
			if (controlScheme != controlScheme2)
			{
				bool flag = HideTooltip();
				if (controlScheme2 == ControlScheme.Mouse)
				{
					Cursor.lockState = CursorLockMode.None;
					Cursor.visible = true;
				}
				else
				{
					Cursor.visible = false;
					Cursor.lockState = CursorLockMode.Locked;
					MouseOrTouch[] array = mMouse;
					MouseOrTouch mouseOrTouch = array[0];
					mouseOrTouch.ignoreDelta = 2;
				}
				if (UICamera.onSchemeChange != null)
				{
					OnSchemeChange onSchemeChange = UICamera.onSchemeChange;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v85.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				}
			}
		}
	}

	public unsafe static Ray currentRay
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			//IL_0128: Unknown result type (might be due to invalid IL or missing references)
			//IL_012d: Expected Obj, but got Unknown
			//IL_0136: Expected Obj, but got I4
			//IL_00de: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e3: Expected Obj, but got Unknown
			//IL_0114: Expected VT, but got I
			//IL_010f: Expected native int or pointer, but got VT
			//IL_006e: Expected F4, but got I
			//IL_0069: Expected native int or pointer, but got VT
			//IL_008a: Expected F4, but got VT
			//IL_0085: Expected native int or pointer, but got VT
			//IL_00d0: Expected VT, but got I
			//IL_00cb: Expected native int or pointer, but got VT
			object obj = default;
			Vector3 vector = (Vector3)(obj - 80);
			_ = 0;
			object obj2 = vector - -64;
			obj2 = 0;
			_ = 0;
			Ray ray2 = default;
			if (currentCamera != null && currentTouch != null)
			{
				MouseOrTouch mouseOrTouch = currentTouch;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
				((Vector3*)(nint)vector)->z = 0f;
				_ = mouseOrTouch.pos;
				((Vector3*)(nint)vector)->x = (float)mouseOrTouch.pos;
				Ray ray = currentCamera.ScreenPointToRay(vector);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
				((Ray*)(nint)ray2)->m_Origin = (Vector3)0;
			}
			else
			{
				object obj3 = vector + 56;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
				((Ray*)(nint)ray2)->m_Origin = (Vector3)0;
			}
			return ray2;
		}
	}

	public static bool inputHasFocus
	{
		get
		{
			bool flag = (byte)(~(mInputFocus ? 1u : 0u)) != 0;
			bool result = false;
			if (!flag)
			{
				if ((bool)mSelected)
				{
					bool activeInHierarchy = mSelected.activeInHierarchy;
					result = true;
					if (activeInHierarchy)
					{
						goto IL_008f;
					}
				}
				mInputFocus = false;
				result = false;
			}
			goto IL_008f;
			IL_008f:
			return result;
		}
	}

	public static GameObject genericEventHandler
	{
		get
		{
			return mGenericHandler;
		}
		set
		{
			mGenericHandler = value;
		}
	}

	private bool handlesEvents
	{
		get
		{
			UICamera uICamera = eventHandler;
			return uICamera == this;
		}
	}

	public Camera cachedCamera
	{
		get
		{
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Expected Obj, but got Unknown
			object result = this + 100;
			if (mCam == null)
			{
				Camera component = GetComponent<Camera>();
				mCam = component;
			}
			return (Camera)result;
		}
	}

	public static GameObject tooltipObject => mTooltip;

	public static bool isOverUI
	{
		get
		{
			if (currentTouch != null)
			{
				return currentTouch.isOverUI;
			}
			bool flag = mHover != null;
			bool result = false;
			if (flag)
			{
				bool flag2 = mHover != fallThrough;
				result = false;
				if (flag2)
				{
					UIRoot uIRoot = NGUITools.FindInParents<UIRoot>(mHover);
					result = uIRoot != null;
				}
			}
			return result;
		}
	}

	public static GameObject hoveredObject
	{
		get
		{
			if (currentTouch != null)
			{
				MouseOrTouch mouseOrTouch = currentTouch;
				if (~(mouseOrTouch.dragStarted ? 1u : 0u) == 0)
				{
					MouseOrTouch mouseOrTouch2 = currentTouch;
					return mouseOrTouch2.current;
				}
			}
			if ((bool)mHover && mHover.activeInHierarchy)
			{
				return mHover;
			}
			mHover = null;
			return null;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_014c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0151: Expected Obj, but got Unknown
			//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cc: Expected Obj, but got Unknown
			//IL_045c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0461: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 - 16;
			if (!(mHover != value))
			{
				return;
			}
			if (currentTouch == null)
			{
				currentTouchID = -100;
				currentTouch = controller;
			}
			bool flag = ShowTooltip(null);
			if ((bool)mSelected)
			{
				ControlScheme controlScheme = currentScheme;
				if (controlScheme == ControlScheme.Controller)
				{
					_ = 0;
					object obj3 = obj + 15;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
					object obj4 = default;
					Notify(mSelected, "OnSelect", obj4);
					if (onSelect != null)
					{
						BoolDelegate boolDelegate = onSelect;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v262.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
					}
					mSelected = null;
				}
			}
			if ((bool)mHover)
			{
				_ = 0;
				object obj5 = obj + 14;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
				object obj6 = default;
				Notify(mHover, "OnHover", obj6);
				if (onHover != null)
				{
					BoolDelegate boolDelegate2 = onHover;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v290.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				}
			}
			mHover = value;
			MouseOrTouch mouseOrTouch = currentTouch;
			mouseOrTouch.clickNotification = ClickNotification.None;
			if ((bool)mHover)
			{
				MouseOrTouch mouseOrTouch2 = controller;
				if (mHover != mouseOrTouch2.current)
				{
					UIKeyNavigation component = mHover.GetComponent<UIKeyNavigation>();
					if (component != null)
					{
						MouseOrTouch mouseOrTouch3 = controller;
						mouseOrTouch3.current = mHover;
					}
				}
				if (currentTouch == null)
				{
					UICamera uICamera;
					if (mHover != null)
					{
						int layer = mHover.layer;
						uICamera = FindCameraForLayer(layer);
					}
					else
					{
						BetterList<UICamera> betterList = list;
						UICamera[] buffer = betterList.buffer;
						uICamera = buffer[0];
					}
					if (uICamera != null)
					{
						current = uICamera;
						Camera camera = uICamera.cachedCamera;
						currentCamera = camera;
					}
				}
				if (onHover != null)
				{
					BoolDelegate boolDelegate3 = onHover;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v433.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				}
				_ = 1;
				object obj7 = obj + 13;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
				object obj8 = default;
				Notify(mHover, "OnHover", obj8);
			}
			if (currentTouch == null)
			{
				current = current;
				bool flag2 = current != null;
				bool flag3 = !flag2;
				Camera camera2 = null;
				if (!flag3)
				{
					Camera camera3 = current.cachedCamera;
					camera2 = camera3;
				}
				currentCamera = camera2;
				currentTouch = null;
				currentTouchID = -100;
			}
		}
	}

	public static GameObject controllerNavigationObject
	{
		get
		{
			//IL_010b: Expected Obj, but got I4
			//IL_024f: Expected Obj, but got I4
			//IL_017f: Expected Obj, but got I
			//IL_0195: Expected Obj, but got I
			//IL_021a: Unknown result type (might be due to invalid IL or missing references)
			//IL_021f: Expected Obj, but got Unknown
			//IL_02c3: Expected Obj, but got I
			//IL_02d9: Expected Obj, but got I
			//IL_0339: Unknown result type (might be due to invalid IL or missing references)
			//IL_033e: Expected Obj, but got Unknown
			//IL_020c: Expected Obj, but got I
			//IL_032b: Expected Obj, but got I
			MouseOrTouch mouseOrTouch = controller;
			if ((bool)mouseOrTouch.current)
			{
				MouseOrTouch mouseOrTouch2 = controller;
				if (mouseOrTouch2.current.activeInHierarchy)
				{
					MouseOrTouch mouseOrTouch3 = controller;
					return mouseOrTouch3.current;
				}
			}
			ControlScheme controlScheme = currentScheme;
			if (controlScheme == ControlScheme.Controller && current != null)
			{
				UICamera uICamera = current;
				if (~(uICamera.useController ? 1u : 0u) == 0)
				{
					BetterList<UIKeyNavigation> betterList = UIKeyNavigation.list;
					bool flag = betterList.size < 1;
					object obj = 0;
					if (!flag)
					{
						while (true)
						{
							BetterList<UIKeyNavigation> betterList2 = UIKeyNavigation.list;
							UnityEngine.Object obj5;
							if ((nint)obj < betterList2.size)
							{
								BetterList<UIKeyNavigation> betterList3 = UIKeyNavigation.list;
								object obj2 = obj << 2;
								object obj3 = (object)betterList3.buffer + obj2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S0_v126+10]");
								UnityEngine.Object obj4 = (UnityEngine.Object)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S0_v126+10]");
								if (!(UnityEngine.Object)0)
								{
									goto IL_0211;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S0_v127 (UnityEngine.Object)+C]");
								if ((nint)0 == 3)
								{
									goto IL_0211;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S0_v127 (UnityEngine.Object)+28]");
								if ((nint)0 == 0)
								{
									goto IL_0211;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S0_v126+10]");
								obj5 = (UnityEngine.Object)0;
								goto IL_034b;
							}
							bool flag2 = mHover == null;
							bool flag3 = !flag2;
							object obj6 = 0;
							if (flag3)
							{
								break;
							}
							while (true)
							{
								BetterList<UIKeyNavigation> betterList4 = UIKeyNavigation.list;
								if ((nint)obj6 >= betterList4.size)
								{
									break;
								}
								BetterList<UIKeyNavigation> betterList5 = UIKeyNavigation.list;
								object obj7 = obj6 << 2;
								object obj8 = (object)betterList5.buffer + obj7;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ S0_v104+10]");
								UnityEngine.Object obj9 = (UnityEngine.Object)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ S0_v104+10]");
								if (!(UnityEngine.Object)0)
								{
									goto IL_0330;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ S0_v105 (UnityEngine.Object)+C]");
								if ((nint)0 == 3)
								{
									goto IL_0330;
								}
								goto IL_031b;
								IL_0330:
								object obj10 = obj6 + 1;
								obj6 = obj10;
							}
							break;
							IL_031b:
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ S0_v104+10]");
							obj5 = (UnityEngine.Object)0;
							goto IL_034b;
							IL_0211:
							object obj11 = obj + 1;
							obj = obj11;
							continue;
							IL_034b:
							GameObject gameObject = ((Component)obj5).gameObject;
							hoveredObject = gameObject;
							MouseOrTouch mouseOrTouch4 = controller;
							mouseOrTouch4.current = mHover;
							return mHover;
						}
					}
				}
			}
			MouseOrTouch mouseOrTouch5 = controller;
			mouseOrTouch5.current = null;
			return null;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_007d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0082: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 - 16;
			MouseOrTouch mouseOrTouch = controller;
			if (mouseOrTouch.current != value)
			{
				MouseOrTouch mouseOrTouch2 = controller;
				if ((bool)mouseOrTouch2.current)
				{
					MouseOrTouch mouseOrTouch3 = controller;
					_ = 0;
					object obj3 = obj + 15;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
					object obj4 = default;
					Notify(mouseOrTouch3.current, "OnHover", obj4);
					if (onHover != null)
					{
						BoolDelegate boolDelegate = onHover;
						MouseOrTouch mouseOrTouch4 = controller;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v119.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
					}
					MouseOrTouch mouseOrTouch5 = controller;
					mouseOrTouch5.current = null;
				}
			}
			hoveredObject = value;
		}
	}

	public static GameObject selectedObject
	{
		get
		{
			if ((bool)mSelected && mSelected.activeInHierarchy)
			{
				return mSelected;
			}
			mSelected = null;
			return null;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c9: Expected Obj, but got Unknown
			//IL_0445: Unknown result type (might be due to invalid IL or missing references)
			//IL_044a: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 - 16;
			if (mSelected == value)
			{
				hoveredObject = value;
				MouseOrTouch mouseOrTouch = controller;
				mouseOrTouch.current = value;
				return;
			}
			bool flag = ShowTooltip(null);
			if (currentTouch == null)
			{
				currentTouchID = -100;
				currentTouch = controller;
			}
			mInputFocus = false;
			if ((bool)mSelected)
			{
				_ = 0;
				object obj3 = obj + 15;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
				object obj4 = default;
				Notify(mSelected, "OnSelect", obj4);
				if (onSelect != null)
				{
					BoolDelegate boolDelegate = onSelect;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v216.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				}
			}
			mSelected = value;
			MouseOrTouch mouseOrTouch2 = currentTouch;
			mouseOrTouch2.clickNotification = ClickNotification.None;
			if (value != null)
			{
				UIKeyNavigation component = value.GetComponent<UIKeyNavigation>();
				if (component != null)
				{
					MouseOrTouch mouseOrTouch3 = controller;
					mouseOrTouch3.current = value;
				}
			}
			bool flag2 = mSelected;
			if (currentTouch == null && flag2)
			{
				UICamera uICamera;
				if (mSelected != null)
				{
					int layer = mSelected.layer;
					uICamera = FindCameraForLayer(layer);
				}
				else
				{
					BetterList<UICamera> betterList = list;
					UICamera[] buffer = betterList.buffer;
					uICamera = buffer[0];
				}
				if (uICamera != null)
				{
					current = uICamera;
					Camera camera = uICamera.cachedCamera;
					currentCamera = camera;
				}
			}
			if ((bool)mSelected)
			{
				bool flag3;
				if (mSelected.activeInHierarchy)
				{
					UIInput component2 = mSelected.GetComponent<UIInput>();
					flag3 = component2 != null;
				}
				else
				{
					flag3 = false;
				}
				mInputFocus = flag3;
				if (onSelect != null)
				{
					BoolDelegate boolDelegate2 = onSelect;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v433.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				}
				_ = 1;
				object obj5 = obj + 14;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
				object obj6 = default;
				Notify(mSelected, "OnSelect", obj6);
			}
			if (currentTouch == null)
			{
				current = current;
				bool flag4 = current != null;
				bool flag5 = !flag4;
				Camera camera2 = null;
				if (!flag5)
				{
					Camera camera3 = current.cachedCamera;
					camera2 = camera3;
				}
				currentCamera = camera2;
				currentTouch = null;
				currentTouchID = -100;
			}
		}
	}

	public static int touchCount => CountInputSources();

	public static int dragCount
	{
		get
		{
			//IL_0066: Expected Obj, but got I4
			//IL_0097: Expected Obj, but got I
			//IL_00b7: Expected Obj, but got I
			//IL_0168: Unknown result type (might be due to invalid IL or missing references)
			//IL_016d: Expected Obj, but got Unknown
			List<MouseOrTouch> list = activeTouches;
			int num = 0;
			int num3 = default;
			while (num < list._size)
			{
				MouseOrTouch mouseOrTouch = activeTouches.get_Item(num);
				int num2 = num3 + 1;
				if (mouseOrTouch.dragged == null)
				{
					num2 = num3;
				}
				int num4 = num + 1;
				num3 = num2;
				num = num4;
			}
			object obj = 0;
			while (true)
			{
				MouseOrTouch[] array = mMouse;
				if ((nint)obj >= array.Length)
				{
					break;
				}
				object obj2 = obj << 2;
				object obj3 = (object)mMouse + obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v45+10]");
				object obj4 = 0;
				int num5 = num3 + 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v46+3C]");
				if ((UnityEngine.Object)0 == null)
				{
					num5 = num3;
				}
				object obj5 = obj + 1;
				num3 = num5;
				obj = obj5;
			}
			MouseOrTouch mouseOrTouch2 = controller;
			int result = num3 + 1;
			if (mouseOrTouch2.dragged == null)
			{
				result = num3;
			}
			return result;
		}
	}

	public static Camera mainCamera
	{
		get
		{
			UICamera uICamera = eventHandler;
			if (uICamera != null)
			{
				return uICamera.cachedCamera;
			}
			return null;
		}
	}

	public static UICamera eventHandler
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_04f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_04fe: Expected Obj, but got Unknown
			//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ba: Expected Obj, but got Unknown
			//IL_03f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_03fe: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 - 32;
			_ = 0;
			BetterList<UICamera> betterList = list;
			IEnumerable<UICamera> source = Enumerable.Distinct(betterList.buffer);
			bool flag = _003C_003Ec._003C_003E9__162_0 == null;
			bool flag2 = !flag;
			Func<UICamera, bool> predicate = _003C_003Ec._003C_003E9__162_0;
			if (!flag2)
			{
				throw new ArgumentException();
			}
			IEnumerable<UICamera> source2 = Enumerable.Where(source, predicate);
			bool flag3 = _003C_003Ec._003C_003E9__162_1 == null;
			bool flag4 = !flag3;
			Func<UICamera, float> keySelector = _003C_003Ec._003C_003E9__162_1;
			if (!flag4)
			{
				throw new ArgumentException();
			}
			IOrderedEnumerable<UICamera> orderedEnumerable = Enumerable.OrderBy(source2, keySelector);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			object obj3 = obj + 28;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			object obj4 = default;
			object obj5 = default;
			object obj6 = default;
			object obj7 = default;
			UICamera uICamera = default;
			object obj8 = default;
			object obj9 = default;
			UICamera result2;
			UICamera uICamera2 = default;
			UICamera uICamera3 = default;
			while (true)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				UICamera result;
				if ((nint)0 == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					if (obj4 == null)
					{
						result = null;
						goto IL_03ac;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								if (obj5 != null)
								{
									continue;
								}
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									if (obj6 == null)
									{
										continue;
									}
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 != 1)
											{
												if (obj7 == null)
												{
													continue;
												}
												result = uICamera;
												goto IL_03ac;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
											goto IL_0318;
										}
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
				}
				goto IL_0318;
				IL_0318:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				bool flag5 = obj8 != obj9;
				result2 = uICamera2;
				if (flag5)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag6 = (nint)0 == 1;
				result = null;
				if (!flag6)
				{
					goto IL_03ac;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				result2 = uICamera3;
				break;
				IL_03ac:
				object obj10 = obj + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @245");
				return result;
			}
			_ = 0;
			object obj11 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			return result2;
		}
	}

	public static bool IsPressed(GameObject go)
	{
		//IL_011d: Expected Obj, but got I4
		//IL_0031: Expected Obj, but got I
		//IL_0046: Expected Obj, but got I
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected Obj, but got Unknown
		object obj = 0;
		while (true)
		{
			if ((nint)obj < 3)
			{
				object obj2 = obj << 2;
				object obj3 = (object)mMouse + obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v49+10]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v50+38]");
				if (!((UnityEngine.Object)0 != go))
				{
					break;
				}
				object obj5 = obj + 1;
				obj = obj5;
				continue;
			}
			List<MouseOrTouch> list = activeTouches;
			int num = 0;
			while (true)
			{
				if (num < list._size)
				{
					MouseOrTouch mouseOrTouch = activeTouches.get_Item(num);
					if (!(mouseOrTouch.pressed != go))
					{
						break;
					}
					int num2 = num + 1;
					num = num2;
					continue;
				}
				MouseOrTouch mouseOrTouch2 = controller;
				return mouseOrTouch2.pressed == go;
			}
			break;
		}
		return true;
	}

	public static int CountInputSources()
	{
		//IL_0066: Expected Obj, but got I4
		//IL_0097: Expected Obj, but got I
		//IL_00b7: Expected Obj, but got I
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected Obj, but got Unknown
		List<MouseOrTouch> list = activeTouches;
		int num = 0;
		int num3 = default;
		while (num < list._size)
		{
			MouseOrTouch mouseOrTouch = activeTouches.get_Item(num);
			int num2 = num3 + 1;
			if (mouseOrTouch.pressed == null)
			{
				num2 = num3;
			}
			int num4 = num + 1;
			num3 = num2;
			num = num4;
		}
		object obj = 0;
		while (true)
		{
			MouseOrTouch[] array = mMouse;
			if ((nint)obj >= array.Length)
			{
				break;
			}
			object obj2 = obj << 2;
			object obj3 = (object)mMouse + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v45+10]");
			object obj4 = 0;
			int num5 = num3 + 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v46+38]");
			if ((UnityEngine.Object)0 == null)
			{
				num5 = num3;
			}
			object obj5 = obj + 1;
			num3 = num5;
			obj = obj5;
		}
		MouseOrTouch mouseOrTouch2 = controller;
		int result = num3 + 1;
		if (mouseOrTouch2.pressed == null)
		{
			result = num3;
		}
		return result;
	}

	private static int CompareFunc(UICamera a, UICamera b)
	{
		Camera camera = a.cachedCamera;
		float depth = camera.depth;
		Camera camera2 = b.cachedCamera;
		float depth2 = camera2.depth;
		bool flag = depth < depth2;
		int result = 1;
		if (!flag)
		{
			Camera camera3 = a.cachedCamera;
			float depth3 = camera3.depth;
			Camera camera4 = b.cachedCamera;
			float depth4 = camera4.depth;
			bool flag2 = depth3 > depth4;
			result = -1;
			if (!flag2)
			{
				result = 0;
			}
		}
		return result;
	}

	private static Rigidbody FindRootRigidbody(Transform trans)
	{
		Transform parent = default;
		Rigidbody result;
		Transform transform = default;
		while (true)
		{
			if (parent != null)
			{
				UIPanel component = parent.GetComponent<UIPanel>();
				bool flag = component == null;
				result = null;
				if (!flag)
				{
					break;
				}
				Rigidbody component2 = parent.GetComponent<Rigidbody>();
				bool flag2 = component2 == null;
				result = component2;
				if (!flag2)
				{
					break;
				}
				parent = transform.parent;
				continue;
			}
			result = null;
			break;
		}
		return result;
	}

	private static Rigidbody2D FindRootRigidbody2D(Transform trans)
	{
		Transform parent = default;
		Rigidbody2D result;
		Transform transform = default;
		while (true)
		{
			if (parent != null)
			{
				UIPanel component = parent.GetComponent<UIPanel>();
				bool flag = component == null;
				result = null;
				if (!flag)
				{
					break;
				}
				Rigidbody2D component2 = parent.GetComponent<Rigidbody2D>();
				bool flag2 = component2 == null;
				result = component2;
				if (!flag2)
				{
					break;
				}
				parent = transform.parent;
				continue;
			}
			result = null;
			break;
		}
		return result;
	}

	public unsafe static void Raycast(MouseOrTouch touch)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0059: Expected native int or pointer, but got VT
		//IL_007a: Expected F4, but got VT
		//IL_0075: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 32);
		_ = 0;
		((Vector3*)(nint)vector)->z = 0f;
		_ = touch.pos;
		((Vector3*)(nint)vector)->x = (float)touch.pos;
		if (!Raycast(vector))
		{
			mRayHitObject = fallThrough;
		}
		if (mRayHitObject == null)
		{
			mRayHitObject = mGenericHandler;
		}
		touch.last = touch.current;
		touch.current = mRayHitObject;
		mLastPos = touch.pos;
	}

	public unsafe static bool Raycast(Vector3 inPos)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_006e: Expected Obj, but got I
		//IL_007f: Expected Obj, but got I
		//IL_200e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2013: Expected Obj, but got Unknown
		//IL_00b2: Expected Obj, but got I
		//IL_00f2: Expected Obj, but got I
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected VT, but got Unknown
		//IL_202e: Expected Obj, but got I
		//IL_204d: Expected F4, but got I
		//IL_207a: Expected Obj, but got I
		//IL_2099: Expected F4, but got I
		//IL_0197: Invalid comparison between I and F4
		//IL_01ad: Expected F4, but got I
		//IL_01d5: Invalid comparison between I and F4
		//IL_01eb: Expected F4, but got I
		//IL_0213: Invalid comparison between I and F4
		//IL_0229: Expected F4, but got I
		//IL_0251: Invalid comparison between I and F4
		//IL_0267: Expected F4, but got I
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Expected VT, but got Unknown
		//IL_0312: Invalid comparison between I and F4
		//IL_033e: Expected F4, but got I
		//IL_0462: Expected I, but got Obj
		//IL_0492: Unknown result type (might be due to invalid IL or missing references)
		//IL_0497: Expected VT, but got Unknown
		//IL_04ca: Expected F4, but got I
		//IL_04ef: Expected F4, but got I
		//IL_06ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cf: Expected VT, but got Unknown
		//IL_070a: Expected Obj, but got I4
		//IL_071c: Expected Obj, but got I4
		//IL_0513: Expected I, but got Obj
		//IL_055e: Expected I, but got Obj
		//IL_058c: Expected VT, but got I
		//IL_059a: Expected I, but got Obj
		//IL_05b0: Expected VT, but got I
		//IL_05b9: Expected Ref, but got VT
		//IL_137e: Expected I, but got Obj
		//IL_13bb: Expected VT, but got I
		//IL_13c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_13c9: Expected VT, but got Unknown
		//IL_13d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_13d7: Expected Ref, but got Unknown
		//IL_13e8: Expected Ref, but got VT
		//IL_212a: Expected Obj, but got I4
		//IL_092c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0931: Expected Obj, but got Unknown
		//IL_0947: Unknown result type (might be due to invalid IL or missing references)
		//IL_094c: Expected VT, but got Unknown
		//IL_0955: Expected Ref, but got VT
		//IL_075e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0763: Expected VT, but got Unknown
		//IL_076c: Expected Ref, but got VT
		//IL_1625: Expected I, but got Obj
		//IL_1662: Expected VT, but got I
		//IL_166b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1670: Expected VT, but got Unknown
		//IL_1679: Unknown result type (might be due to invalid IL or missing references)
		//IL_167e: Expected Ref, but got Unknown
		//IL_168f: Expected Ref, but got VT
		//IL_141c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1421: Expected VT, but got Unknown
		//IL_1436: Expected F4, but got I
		//IL_1436: Expected Ref, but got VT
		//IL_147d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1482: Expected VT, but got Unknown
		//IL_0f1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f24: Expected Obj, but got Unknown
		//IL_0f2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f32: Expected Ref, but got Unknown
		//IL_14c0: Expected Obj, but got I
		//IL_14d8: Expected F4, but got I
		//IL_16c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_16c8: Expected VT, but got Unknown
		//IL_16dd: Expected F4, but got I
		//IL_16dd: Expected Ref, but got VT
		//IL_10af: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b4: Expected Obj, but got Unknown
		//IL_0e50: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e55: Expected Obj, but got Unknown
		//IL_0e5f: Expected Obj, but got I4
		//IL_170e: Expected I, but got Obj
		//IL_173c: Expected VT, but got I
		//IL_1751: Unknown result type (might be due to invalid IL or missing references)
		//IL_1756: Expected VT, but got Unknown
		//IL_0f61: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f66: Expected Obj, but got Unknown
		//IL_0c21: Expected VT, but got I4
		//IL_0c2b: Invalid comparison between VT and I4
		//IL_1194: Unknown result type (might be due to invalid IL or missing references)
		//IL_1199: Expected VT, but got Unknown
		//IL_11a2: Expected Ref, but got VT
		//IL_14fd: Expected I, but got Obj
		//IL_1538: Expected VT, but got I
		//IL_17a3: Expected Obj, but got I4
		//IL_17ac: Expected Obj, but got I4
		//IL_0f7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f83: Expected Obj, but got Unknown
		//IL_0f8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f91: Expected Obj, but got Unknown
		//IL_0fa9: Expected I, but got Obj
		//IL_0fbf: Expected Obj, but got I
		//IL_0fc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fcd: Expected Obj, but got Unknown
		//IL_0fd6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fdb: Expected Obj, but got Unknown
		//IL_11db: Unknown result type (might be due to invalid IL or missing references)
		//IL_11e0: Expected VT, but got Unknown
		//IL_0ff3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff8: Expected Obj, but got Unknown
		//IL_1013: Expected Obj, but got I
		//IL_101c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1021: Expected Obj, but got Unknown
		//IL_0c78: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7d: Expected Obj, but got Unknown
		//IL_0a32: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a37: Expected Obj, but got Unknown
		//IL_0a9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa0: Expected Obj, but got Unknown
		//IL_1039: Unknown result type (might be due to invalid IL or missing references)
		//IL_103e: Expected Obj, but got Unknown
		//IL_1047: Unknown result type (might be due to invalid IL or missing references)
		//IL_104c: Expected Obj, but got Unknown
		//IL_1064: Expected I, but got Obj
		//IL_1092: Expected VT, but got I
		//IL_0c9a: Expected I, but got Obj
		//IL_0cb0: Expected Obj, but got I
		//IL_0cb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cbe: Expected Obj, but got Unknown
		//IL_0cd1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd6: Expected Obj, but got Unknown
		//IL_0d25: Expected I, but got Obj
		//IL_0d58: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d5d: Expected Obj, but got Unknown
		//IL_0d73: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d78: Expected VT, but got Unknown
		//IL_0d81: Expected Ref, but got VT
		//IL_0892: Unknown result type (might be due to invalid IL or missing references)
		//IL_0897: Expected Obj, but got Unknown
		//IL_08bb: Expected Obj, but got I
		//IL_21a4: Expected Obj, but got I4
		//IL_181c: Expected Obj, but got I
		//IL_0da5: Expected I, but got Obj
		//IL_0dc3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc8: Expected Obj, but got Unknown
		//IL_0dd6: Expected I, but got Obj
		//IL_0dec: Expected Obj, but got I
		//IL_1238: Unknown result type (might be due to invalid IL or missing references)
		//IL_123d: Expected Obj, but got Unknown
		//IL_17e2: Expected I4, but got VT
		//IL_0e04: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e09: Expected Obj, but got Unknown
		//IL_0e31: Expected Obj, but got I
		//IL_125a: Expected I, but got Obj
		//IL_1270: Expected Obj, but got I
		//IL_1279: Unknown result type (might be due to invalid IL or missing references)
		//IL_127e: Expected Obj, but got Unknown
		//IL_12ca: Expected I, but got Obj
		//IL_12f8: Expected VT, but got I
		//IL_1306: Expected I, but got Obj
		//IL_131c: Expected VT, but got I
		//IL_1325: Expected Ref, but got VT
		//IL_0901: Expected Obj, but got I
		//IL_1c6a: Expected I4, but got VT
		//IL_1d7d: Expected I4, but got VT
		//IL_1c9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ca4: Expected Obj, but got Unknown
		//IL_1cad: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cb2: Expected Ref, but got Unknown
		//IL_1d23: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d28: Expected Obj, but got Unknown
		//IL_1bbf: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bc4: Expected Obj, but got Unknown
		//IL_1bce: Expected Obj, but got I4
		//IL_1f49: Expected I, but got Obj
		//IL_1f75: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f7a: Expected VT, but got Unknown
		//IL_1ce1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ce6: Expected Obj, but got Unknown
		//IL_1a60: Expected VT, but got I4
		//IL_1a6a: Invalid comparison between VT and I4
		//IL_1a90: Expected Obj, but got I4
		//IL_1fb4: Expected I4, but got VT
		//IL_1f24: Expected I4, but got VT
		//IL_1d06: Expected Obj, but got I
		//IL_1deb: Expected I, but got Obj
		//IL_1e17: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e1c: Expected Obj, but got Unknown
		//IL_1e4a: Expected Obj, but got I
		//IL_1e53: Expected I4, but got VT
		//IL_1ab4: Expected I, but got Obj
		//IL_1ad7: Expected I, but got Obj
		//IL_1b08: Expected I, but got Obj
		//IL_1b3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b40: Expected Obj, but got Unknown
		//IL_1b4e: Expected I, but got Obj
		//IL_1b64: Expected Obj, but got I
		//IL_18e9: Expected I, but got Obj
		//IL_1915: Unknown result type (might be due to invalid IL or missing references)
		//IL_191a: Expected Obj, but got Unknown
		//IL_1b7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b81: Expected Obj, but got Unknown
		//IL_1ba9: Expected Obj, but got I
		//IL_1e83: Expected Obj, but got I
		//IL_1990: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 688;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [5310C9]");
		bool flag = (nint)0 == 0;
		bool flag2 = !flag;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		object obj3 = default;
		bool result;
		GameObject gameObject = default;
		int num8 = default;
		nint num15 = default;
		IntPtr intPtr2 = default;
		nint num16 = default;
		object obj13 = default;
		object obj24 = default;
		object obj31 = default;
		object obj49 = default;
		object obj64 = default;
		while (true)
		{
			BetterList<UICamera> betterList = list;
			bool flag3 = (nint)obj3 >= betterList.size;
			result = false;
			if (flag3)
			{
				break;
			}
			BetterList<UICamera> betterList2 = list;
			object obj4 = obj3 << 2;
			object obj5 = (object)betterList2.buffer + obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S0_v28+10]");
			Behaviour behaviour = (Behaviour)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S0_v28+10]");
			if (!((Behaviour)0).enabled)
			{
				goto IL_2005;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S0_v28+10]");
			GameObject go = ((Component)0).gameObject;
			if (!NGUITools.GetActive(go))
			{
				goto IL_2005;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S0_v28+10]");
			Camera camera = ((UICamera)0).cachedCamera;
			currentCamera = camera;
			_ = inPos.z;
			_ = inPos.x;
			Vector3 position = (Vector3)(obj + 360);
			Vector3 vector = currentCamera.ScreenToViewportPoint(position);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [536C27]");
			bool flag4 = (nint)0 == 0;
			flag2 = !flag4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+228]");
			object obj6 = (nint)0 & (nint)int.MaxValue;
			bool flag5 = (nint)obj6 > 2139095040;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+22C]");
			float num = 0f;
			int num2 = 0;
			if (flag5)
			{
				goto IL_2005;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [536C27]");
			bool flag6 = (nint)0 == 0;
			flag2 = !flag6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+22C]");
			object obj7 = (nint)0 & (nint)int.MaxValue;
			bool flag7 = (nint)obj7 > 2139095040;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+22C]");
			num = 0f;
			num2 = 0;
			if (flag7)
			{
				goto IL_2005;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+228]");
			bool flag8 = 0f < 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+22C]");
			num = 0f;
			num2 = 0;
			if (flag8)
			{
				goto IL_2005;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+228]");
			bool flag9 = 0f > 1f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+22C]");
			num = 0f;
			num2 = 0;
			if (flag9)
			{
				goto IL_2005;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+22C]");
			bool flag10 = 0f < 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+22C]");
			num = 0f;
			num2 = 0;
			if (flag10)
			{
				goto IL_2005;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+22C]");
			bool flag11 = 0f > 1f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+22C]");
			num = 0f;
			num2 = 0;
			if (flag11)
			{
				goto IL_2005;
			}
			_ = inPos.z;
			_ = inPos.x;
			Vector3 pos = (Vector3)(obj + 344);
			Ray ray = currentCamera.ScreenPointToRay(pos);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+238]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+230]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+228]");
			_ = 0;
			int cullingMask = currentCamera.cullingMask;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v29 (UnityEngine.Behaviour)+14]");
			int num3 = (int)((nint)cullingMask & (nint)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v29 (UnityEngine.Behaviour)+38]");
			bool flag12 = 0f > 0f;
			bool flag13 = !flag12;
			bool flag14 = !flag13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v29 (UnityEngine.Behaviour)+38]");
			num = 0f;
			if (!flag14)
			{
				float farClipPlane = currentCamera.farClipPlane;
				float nearClipPlane = currentCamera.nearClipPlane;
				float num4 = farClipPlane - nearClipPlane;
				num = num4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v29 (UnityEngine.Behaviour)+C]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v29 (UnityEngine.Behaviour)+C]");
				if ((nint)0 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v29 (UnityEngine.Behaviour)+C]");
					if ((nint)0 == 2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2A8]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2A0]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+298]");
						_ = 0;
						nint num5 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+238]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+230]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+228]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ S0_v495 (Il2CppClass<UICamera>)+5C]");
						Plane plane = (Plane)((nint)0 + (nint)320);
						Ray ray2 = (Ray)(obj + 176);
						bool flag15 = ((Plane*)plane)->Raycast(ray2, out *(float*)(obj + 660));
						bool flag16 = !flag15;
						num2 = 0;
						if (!flag16)
						{
							Ray ray3 = (Ray)(obj + 664);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+294]");
							vector = ((Ray*)ray3)->GetPoint(0f);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+22C]");
							int num6 = (int)((nint)0 << 32);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+228]");
							int num7 = (int)((nint)0 | (nint)num6);
							Vector2 point = (Vector2)(obj + 168);
							Collider2D collider2D = Physics2D.OverlapPoint(point, num3);
							bool flag17 = collider2D;
							bool flag18 = !flag17;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+22C]");
							gameObject = (GameObject)0;
							num8 = num7;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+230]");
							num = 0f;
							num2 = 32;
							if (!flag18)
							{
								nint num9 = (nint)typeof(UICamera);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v948 @ S0_v527 (Il2CppClass<UICamera>)+5C]");
								nint num10 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+230]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+22C]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+228]");
								lastWorldPosition = (Vector3)0;
								GameObject gameObject2 = collider2D.gameObject;
								mRayHitObject = gameObject2;
								result = true;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v29 (UnityEngine.Behaviour)+10]");
								if ((nint)0 == 0)
								{
									Transform trans = mRayHitObject.transform;
									Rigidbody2D rigidbody2D = FindRootRigidbody2D(trans);
									bool flag19 = rigidbody2D != null;
									bool flag20 = !flag19;
									result = true;
									if (!flag20)
									{
										GameObject gameObject3 = rigidbody2D.gameObject;
										mRayHitObject = gameObject3;
										result = true;
									}
								}
								break;
							}
						}
						goto IL_2005;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v29 (UnityEngine.Behaviour)+C]");
					if ((nint)0 != 3)
					{
						num2 = 0;
						goto IL_2005;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2A8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2A0]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+298]");
					_ = 0;
					nint num11 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+238]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+230]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+228]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v592 @ S0_v571 (Il2CppClass<UICamera>)+5C]");
					Plane plane2 = (Plane)((nint)0 + (nint)320);
					Ray ray4 = (Ray)(obj + 320);
					bool flag21 = ((Plane*)plane2)->Raycast(ray4, out *(float*)(obj + 660));
					bool flag22 = !flag21;
					num2 = 0;
					if (flag22)
					{
						goto IL_2005;
					}
					Ray ray5 = (Ray)(obj + 664);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+294]");
					vector = ((Ray*)ray5)->GetPoint(0f);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1F0]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1E8]");
					_ = 0;
					nint num12 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v772 @ S0_v588 (Il2CppClass<UICamera>)+5C]");
					nint num13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+230]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+228]");
					lastWorldPosition = (Vector3)0;
					_ = lastWorldPosition;
					_ = lastWorldPosition;
					Vector2 point2 = (Vector2)(obj + 312);
					Collider2D[] array = Physics2D.OverlapPointAll(point2, num3);
					bool flag23 = array.Length < 2;
					flag2 = !flag23;
					UIWidget uIWidget = (UIWidget)(object)gameObject;
					num2 = 0;
					object obj8 = array.Length;
					object obj9 = 0;
					if (flag2)
					{
						object obj17;
						for (; System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9); obj17 = obj9 + 1, obj8 = array.Length, obj9 = obj17)
						{
							object obj10 = obj9 << 2;
							object obj11 = (object)array + obj10;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v941 @ S0_v678+10]");
							GameObject gameObject4 = ((Component)0).gameObject;
							UIWidget component = gameObject4.GetComponent<UIWidget>();
							nint num14;
							IntPtr intPtr;
							IntPtr intPtr3;
							int num17;
							if (component != null)
							{
								bool isVisible = component.isVisible;
								bool flag24 = !isVisible;
								uIWidget = component;
								if (flag24)
								{
									continue;
								}
								UIWidget.HitCheck hitCheck = component.hitCheck;
								bool flag25 = component.hitCheck == null;
								num14 = num15;
								intPtr = intPtr2;
								intPtr3 = num16;
								num17 = num2;
								if (!flag25)
								{
									nint num18 = (nint)typeof(UICamera);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1532 @ S1_v407 (Il2CppClass<UICamera>)+5C]");
									nint num19 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1533 @ S1_v408 (Il2CppStaticFields<UICamera>)+34]");
									_ = 0;
									_ = lastWorldPosition;
									object obj12 = obj + 296;
									Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1343.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
									num14 = num19;
									intPtr = ((Delegate)hitCheck).method_code;
									intPtr3 = ((Delegate)hitCheck).method;
									num17 = (int)(nint)((Delegate)hitCheck).invoke_impl;
									if (obj13 == null)
									{
										num15 = num19;
										intPtr2 = ((Delegate)hitCheck).method_code;
										num16 = ((Delegate)hitCheck).method;
										uIWidget = (UIWidget)(nint)((Delegate)hitCheck).invoke_impl;
										num2 = (int)(nint)((Delegate)hitCheck).invoke_impl;
										continue;
									}
								}
							}
							else
							{
								UIRect uIRect = NGUITools.FindInParents<UIRect>(gameObject4);
								bool flag26 = uIRect != null;
								bool flag27 = !flag26;
								num14 = num15;
								intPtr = intPtr2;
								intPtr3 = num16;
								num17 = num2;
								if (!flag27)
								{
									bool flag28 = uIRect.finalAlpha < 0.001f;
									num14 = num15;
									intPtr = intPtr2;
									intPtr3 = num16;
									num17 = num2;
									uIWidget = (UIWidget)uIRect;
									if (flag28)
									{
										continue;
									}
								}
							}
							int num20 = NGUITools.CalculateRaycastDepth(gameObject4);
							mHit = (DepthEntry)num20;
							bool flag29 = mHit == (DepthEntry)(object)int.MaxValue;
							num15 = num14;
							intPtr2 = intPtr;
							num16 = intPtr3;
							uIWidget = (UIWidget)num20;
							num2 = num17;
							if (!flag29)
							{
								nint num21 = (nint)typeof(UICamera);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1673 @ S0_v709 (Il2CppClass<UICamera>)+5C]");
								nint num22 = 0;
								nint num23 = (nint)typeof(UICamera);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1681 @ S1_v385 (Il2CppClass<UICamera>)+5C]");
								nint num24 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1682 @ S1_v386 (Il2CppStaticFields<UICamera>)+34]");
								_ = 0;
								_ = lastWorldPosition;
								nint num25 = (nint)typeof(UICamera);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1689 @ S0_v717 (Il2CppClass<UICamera>)+5C]");
								nint num26 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+230]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+228]");
								_ = 0;
								object obj14 = obj + 232;
								nint num27 = (nint)typeof(UICamera);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1707 @ S1_v396 (Il2CppClass<UICamera>)+5C]");
								object obj15 = (nint)0 + (nint)252;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
								object obj16 = obj + 232;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A34E");
								num15 = num14;
								intPtr2 = intPtr;
								num16 = intPtr3;
								uIWidget = (UIWidget)0;
								num2 = num17;
							}
						}
						bool flag30 = _003C_003Ec._003C_003E9__169_1 == null;
						flag2 = !flag30;
						BetterList<DepthEntry>.CompareFunc comparer = _003C_003Ec._003C_003E9__169_1;
						if (!flag2)
						{
							throw new ArgumentException();
						}
						mHits.Sort(comparer);
						object obj18 = 0;
						while (true)
						{
							BetterList<DepthEntry> betterList3 = mHits;
							BetterList<DepthEntry> betterList4 = mHits;
							object obj19 = obj18;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1269 @ S0_v629 (BetterList`1<UICamera+DepthEntry>)+C]");
							bool flag31 = (nint)obj19 >= 0;
							gameObject = (GameObject)(object)uIWidget;
							num8 = (int)lastWorldPosition;
							BetterList<DepthEntry> betterList5 = mHits;
							if (flag31)
							{
								break;
							}
							object obj20 = obj18 << 6;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1304 @ S0_v636 (BetterList`1<UICamera+DepthEntry>)+8]");
							object obj21 = 0 + obj20;
							if (IsVisible(ref *(DepthEntry*)(obj21 + 16)))
							{
								goto IL_1cd8;
							}
							object obj22 = obj18 + 1;
							obj18 = obj22;
						}
						goto IL_1fd8;
					}
					if (array.Length != 1)
					{
						num8 = (int)lastWorldPosition;
						num2 = 0;
						goto IL_2005;
					}
					GameObject gameObject5 = array[0].gameObject;
					UIWidget component2 = gameObject5.GetComponent<UIWidget>();
					nint num28;
					GameObject gameObject6;
					int num29;
					if (component2 != null)
					{
						bool isVisible2 = component2.isVisible;
						bool flag32 = !isVisible2;
						num8 = (int)lastWorldPosition;
						num2 = 0;
						if (flag32)
						{
							goto IL_2005;
						}
						UIWidget.HitCheck hitCheck2 = component2.hitCheck;
						bool flag33 = component2.hitCheck == null;
						num28 = num16;
						gameObject6 = gameObject;
						num29 = 0;
						if (!flag33)
						{
							nint num30 = (nint)typeof(UICamera);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1502 @ S1_v435 (Il2CppClass<UICamera>)+5C]");
							nint num31 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1503 @ S1_v436 (Il2CppStaticFields<UICamera>)+34]");
							_ = 0;
							_ = lastWorldPosition;
							object obj23 = obj + 216;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1337.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
							bool flag34 = obj24 == null;
							num16 = num31;
							gameObject = (GameObject)(nint)((Delegate)hitCheck2).method_code;
							num8 = (int)lastWorldPosition;
							num2 = (int)(nint)((Delegate)hitCheck2).invoke_impl;
							if (flag34)
							{
								goto IL_2005;
							}
							num28 = num31;
							gameObject6 = (GameObject)(nint)((Delegate)hitCheck2).method_code;
							num29 = (int)(nint)((Delegate)hitCheck2).invoke_impl;
						}
					}
					else
					{
						UIRect uIRect2 = NGUITools.FindInParents<UIRect>(gameObject5);
						bool flag35 = uIRect2 != null;
						bool flag36 = !flag35;
						num28 = num16;
						gameObject6 = gameObject;
						num29 = 0;
						if (!flag36)
						{
							bool flag37 = uIRect2.finalAlpha < 0.001f;
							num28 = num16;
							gameObject6 = gameObject;
							num29 = 0;
							num8 = (int)lastWorldPosition;
							num2 = 0;
							if (flag37)
							{
								goto IL_2005;
							}
						}
					}
					nint num32 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1514 @ S1_v421 (Il2CppClass<UICamera>)+5C]");
					nint num33 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1515 @ S1_v422 (Il2CppStaticFields<UICamera>)+34]");
					_ = 0;
					_ = lastWorldPosition;
					Vector3 worldPoint = (Vector3)(obj + 200);
					bool flag38 = IsVisible(worldPoint, gameObject5);
					bool flag39 = !flag38;
					num16 = num28;
					gameObject = gameObject6;
					num8 = (int)lastWorldPosition;
					num2 = num29;
					if (flag39)
					{
						goto IL_2005;
					}
					mRayHitObject = gameObject5;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2A8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2A0]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+298]");
					_ = 0;
					Ray ray6 = (Ray)(obj + 144);
					RaycastHit[] array2 = Physics.RaycastAll(ray6, num, num3);
					bool flag40 = array2.Length < 2;
					flag2 = !flag40;
					GameObject gameObject7 = (GameObject)array2.Length;
					num2 = 0;
					object obj25 = 0;
					if (flag2)
					{
						object obj42;
						for (; System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj25) < System.Runtime.CompilerServices.Unsafe.As<GameObject, UIntPtr>(ref gameObject7); obj42 = obj25 + 1, gameObject7 = (GameObject)array2.Length, obj25 = obj42)
						{
							object obj26 = obj25 * 44;
							object obj27 = (object)array2 + obj26;
							RaycastHit raycastHit = (RaycastHit)(obj27 + 16);
							Collider collider = ((RaycastHit*)raycastHit)->collider;
							GameObject gameObject8 = collider.gameObject;
							UIWidget component3 = gameObject8.GetComponent<UIWidget>();
							IntPtr intPtr4;
							IntPtr intPtr5;
							nint num34;
							int num35;
							int num36;
							if (component3 != null)
							{
								bool isVisible3 = component3.isVisible;
								bool flag41 = !isVisible3;
								gameObject = gameObject8;
								if (flag41)
								{
									continue;
								}
								UIWidget.HitCheck hitCheck3 = component3.hitCheck;
								bool flag42 = component3.hitCheck == null;
								intPtr4 = num15;
								intPtr5 = intPtr2;
								num34 = num16;
								num35 = num8;
								num36 = num2;
								if (!flag42)
								{
									object obj28 = obj25 * 44;
									object obj29 = (object)array2 + obj28;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1082 @ S1_v210+10]");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1082 @ S1_v210+18]");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+230]");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+228]");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+230]");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+228]");
									_ = 0;
									object obj30 = obj + 128;
									Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v966.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
									intPtr4 = ((Delegate)hitCheck3).method_code;
									intPtr5 = ((Delegate)hitCheck3).method;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+230]");
									num34 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+228]");
									num35 = 0;
									num36 = (int)(nint)((Delegate)hitCheck3).invoke_impl;
									if (obj31 == null)
									{
										num15 = ((Delegate)hitCheck3).method_code;
										intPtr2 = ((Delegate)hitCheck3).method;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+230]");
										num16 = 0;
										gameObject = gameObject8;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+228]");
										num8 = 0;
										num2 = (int)(nint)((Delegate)hitCheck3).invoke_impl;
										continue;
									}
								}
							}
							else
							{
								UIRect uIRect3 = NGUITools.FindInParents<UIRect>(gameObject8);
								bool flag43 = uIRect3 != null;
								bool flag44 = !flag43;
								intPtr4 = num15;
								intPtr5 = intPtr2;
								num34 = num16;
								num35 = num8;
								num36 = num2;
								if (!flag44)
								{
									bool flag45 = uIRect3.finalAlpha < 0.001f;
									intPtr4 = num15;
									intPtr5 = intPtr2;
									num34 = num16;
									num35 = num8;
									num36 = num2;
									gameObject = gameObject8;
									if (flag45)
									{
										continue;
									}
								}
							}
							int num37 = NGUITools.CalculateRaycastDepth(gameObject8);
							mHit = (DepthEntry)num37;
							bool flag46 = mHit == (DepthEntry)(object)int.MaxValue;
							num15 = intPtr4;
							intPtr2 = intPtr5;
							num16 = num34;
							gameObject = gameObject8;
							num8 = num35;
							num2 = num36;
							if (!flag46)
							{
								object obj32 = obj + 552;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5E9");
								nint num38 = (nint)typeof(UICamera);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1391 @ S0_v334 (Il2CppClass<UICamera>)+5C]");
								object obj33 = (nint)0 + (nint)256;
								object obj34 = obj + 552;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
								object obj35 = obj25 * 44;
								object obj36 = (object)array2 + obj35;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1448 @ S1_v179+10]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1448 @ S1_v179+18]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1B0]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1A8]");
								_ = 0;
								nint num39 = (nint)typeof(UICamera);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1461 @ S0_v343 (Il2CppClass<UICamera>)+5C]");
								nint num40 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1F0]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1E8]");
								_ = 0;
								object obj37 = obj25 * 44;
								object obj38 = (object)array2 + obj37;
								RaycastHit raycastHit2 = (RaycastHit)(obj38 + 16);
								Collider collider2 = ((RaycastHit*)raycastHit2)->collider;
								GameObject gameObject9 = collider2.gameObject;
								nint num41 = (nint)typeof(UICamera);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1613 @ S0_v352 (Il2CppClass<UICamera>)+5C]");
								nint num42 = 0;
								object obj39 = obj - -64;
								nint num43 = (nint)typeof(UICamera);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1629 @ S1_v199 (Il2CppClass<UICamera>)+5C]");
								object obj40 = (nint)0 + (nint)252;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
								object obj41 = obj - -64;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A34E");
								num15 = intPtr4;
								intPtr2 = intPtr5;
								num16 = num34;
								gameObject = (GameObject)0;
								num8 = num35;
								num2 = 44;
							}
						}
						bool flag47 = _003C_003Ec._003C_003E9__169_0 == null;
						flag2 = !flag47;
						BetterList<DepthEntry>.CompareFunc comparer2 = _003C_003Ec._003C_003E9__169_0;
						if (!flag2)
						{
							throw new ArgumentException();
						}
						mHits.Sort(comparer2);
						object obj43 = 0;
						while (true)
						{
							BetterList<DepthEntry> betterList6 = mHits;
							BetterList<DepthEntry> betterList7 = mHits;
							object obj44 = obj43;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v841 @ S0_v232 (BetterList`1<UICamera+DepthEntry>)+C]");
							bool flag48 = (nint)obj44 >= 0;
							BetterList<DepthEntry> betterList5 = mHits;
							if (flag48)
							{
								break;
							}
							object obj45 = obj43 << 6;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v867 @ S0_v239 (BetterList`1<UICamera+DepthEntry>)+8]");
							object obj46 = 0 + obj45;
							if (IsVisible(ref *(DepthEntry*)(obj46 + 16)))
							{
								goto IL_0f58;
							}
							object obj47 = obj43 + 1;
							obj43 = obj47;
						}
						goto IL_1fd8;
					}
					bool flag49 = array2.Length != 1;
					num2 = 0;
					if (flag49)
					{
						goto IL_2005;
					}
					RaycastHit raycastHit3 = (RaycastHit)(array2 + 16);
					Collider collider3 = ((RaycastHit*)raycastHit3)->collider;
					GameObject gameObject10 = collider3.gameObject;
					UIWidget component4 = gameObject10.GetComponent<UIWidget>();
					IntPtr intPtr6;
					GameObject gameObject11;
					int num44;
					int num45;
					if (component4 != null)
					{
						bool isVisible4 = component4.isVisible;
						bool flag50 = !isVisible4;
						num2 = 0;
						if (flag50)
						{
							goto IL_2005;
						}
						UIWidget.HitCheck hitCheck4 = component4.hitCheck;
						bool flag51 = component4.hitCheck == null;
						intPtr6 = num16;
						gameObject11 = gameObject;
						num44 = num8;
						num45 = 0;
						if (!flag51)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ S0_v204 (UnityEngine.RaycastHit[])+10]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ S0_v204 (UnityEngine.RaycastHit[])+18]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+230]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+228]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+230]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+228]");
							_ = 0;
							object obj48 = obj + 48;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v960.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
							intPtr6 = ((Delegate)hitCheck4).method_code;
							gameObject11 = (GameObject)(nint)((Delegate)hitCheck4).method;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+228]");
							num44 = 0;
							num45 = (int)(nint)((Delegate)hitCheck4).invoke_impl;
							if (obj49 == null)
							{
								num16 = ((Delegate)hitCheck4).method_code;
								gameObject = (GameObject)(nint)((Delegate)hitCheck4).method;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+228]");
								num8 = 0;
								num2 = (int)(nint)((Delegate)hitCheck4).invoke_impl;
								goto IL_2005;
							}
						}
					}
					else
					{
						UIRect uIRect4 = NGUITools.FindInParents<UIRect>(gameObject10);
						bool flag52 = uIRect4 != null;
						bool flag53 = !flag52;
						intPtr6 = num16;
						gameObject11 = gameObject;
						num44 = num8;
						num45 = 0;
						if (!flag53)
						{
							bool flag54 = uIRect4.finalAlpha < 0.001f;
							intPtr6 = num16;
							gameObject11 = gameObject;
							num44 = num8;
							num45 = 0;
							num2 = 0;
							if (flag54)
							{
								goto IL_2005;
							}
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ S0_v204 (UnityEngine.RaycastHit[])+10]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ S0_v204 (UnityEngine.RaycastHit[])+18]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+230]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+228]");
					_ = 0;
					RaycastHit raycastHit4 = (RaycastHit)(array2 + 16);
					Collider collider4 = ((RaycastHit*)raycastHit4)->collider;
					GameObject go2 = collider4.gameObject;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+190]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+188]");
					_ = 0;
					Vector3 worldPoint2 = (Vector3)(obj + 32);
					bool flag55 = IsVisible(worldPoint2, go2);
					bool flag56 = !flag55;
					num16 = intPtr6;
					gameObject = gameObject11;
					num8 = num44;
					num2 = num45;
					if (flag56)
					{
						goto IL_2005;
					}
					object obj50 = obj + 552;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5E9");
					nint num46 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1435 @ S0_v445 (Il2CppClass<UICamera>)+5C]");
					object obj51 = (nint)0 + (nint)56;
					object obj52 = obj + 552;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ S0_v204 (UnityEngine.RaycastHit[])+10]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ S0_v204 (UnityEngine.RaycastHit[])+18]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1B0]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1A8]");
					_ = 0;
					nint num47 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1561 @ S0_v454 (Il2CppClass<UICamera>)+5C]");
					nint num48 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1F0]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1E8]");
					lastWorldPosition = (Vector3)0;
					nint num49 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1570 @ S0_v458 (Il2CppClass<UICamera>)+5C]");
					RaycastHit raycastHit5 = (RaycastHit)((nint)0 + (nint)56);
					Collider collider5 = ((RaycastHit*)raycastHit5)->collider;
					GameObject gameObject12 = collider5.gameObject;
					mRayHitObject = gameObject12;
				}
				goto IL_212f;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2A8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2A0]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+298]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+230]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+238]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+228]");
			_ = 0;
			nint num50 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+288]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+280]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+278]");
			_ = 0;
			Ray ray7 = (Ray)(obj + 8);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ S0_v128 (Il2CppClass<UICamera>)+5C]");
			ref RaycastHit hitInfo = ref *(RaycastHit*)((nint)0 + (nint)56);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+294]");
			bool flag57 = Physics.Raycast(ray7, out hitInfo, 0f, num3);
			bool flag58 = !flag57;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+294]");
			num = 0f;
			num2 = num3;
			if (!flag58)
			{
				nint num51 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v629 @ S1_v80 (Il2CppClass<UICamera>)+5C]");
				nint num52 = 0;
				_ = lastHit;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ S1_v81 (Il2CppStaticFields<UICamera>)+40]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1F0]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1E8]");
				_ = 0;
				nint num53 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v643 @ S0_v144 (Il2CppClass<UICamera>)+5C]");
				nint num54 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+230]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+228]");
				lastWorldPosition = (Vector3)0;
				nint num55 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ S0_v148 (Il2CppClass<UICamera>)+5C]");
				RaycastHit raycastHit6 = (RaycastHit)((nint)0 + (nint)56);
				Collider collider6 = ((RaycastHit*)raycastHit6)->collider;
				GameObject gameObject13 = collider6.gameObject;
				mRayHitObject = gameObject13;
				BetterList<UICamera> betterList8 = list;
				UICamera[] buffer = betterList8.buffer;
				UICamera uICamera = buffer[0];
				result = true;
				if (!uICamera.eventsGoToColliders)
				{
					Transform trans2 = mRayHitObject.transform;
					Rigidbody rigidbody = FindRootRigidbody(trans2);
					bool flag59 = rigidbody != null;
					bool flag60 = !flag59;
					result = true;
					if (!flag60)
					{
						GameObject gameObject14 = rigidbody.gameObject;
						mRayHitObject = gameObject14;
						result = true;
					}
				}
				break;
			}
			goto IL_2005;
			IL_1cd8:
			object obj53 = obj + 552;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @384E");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+264]");
			mRayHitObject = (GameObject)0;
			BetterList<DepthEntry> betterList9 = mHits;
			_ = 0;
			goto IL_212f;
			IL_212f:
			result = true;
			break;
			IL_0f58:
			object obj54 = obj + 488;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @384E");
			object obj55 = obj + 552;
			object obj56 = obj + 488;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
			nint num56 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1244 @ S0_v257 (Il2CppClass<UICamera>)+5C]");
			object obj57 = (nint)0 + (nint)56;
			object obj58 = obj + 552;
			object obj59 = obj58 | 4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
			object obj60 = obj + 488;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @384E");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+224]");
			mRayHitObject = (GameObject)0;
			object obj61 = obj + 424;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @384E");
			object obj62 = obj + 488;
			object obj63 = obj + 424;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
			nint num57 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1479 @ S0_v275 (Il2CppClass<UICamera>)+5C]");
			nint num58 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+220]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+218]");
			lastWorldPosition = (Vector3)0;
			BetterList<DepthEntry> betterList10 = mHits;
			_ = 0;
			goto IL_212f;
			IL_1fd8:
			_ = 0;
			goto IL_2005;
			IL_2005:
			obj3 = obj64 + 1;
		}
		return result;
	}

	private unsafe static bool IsVisible(Vector3 worldPoint, GameObject go)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0020: Expected native int or pointer, but got VT
		//IL_0032: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 16);
		UIPanel uIPanel = NGUITools.FindInParents<UIPanel>(go);
		UIPanel uIPanel2 = uIPanel;
		bool flag;
		while (true)
		{
			flag = uIPanel2 != null;
			if (!flag)
			{
				break;
			}
			((Vector3*)(nint)vector)->z = worldPoint.z;
			((Vector3*)(nint)vector)->x = worldPoint.x;
			if (!uIPanel2.IsVisible(vector))
			{
				break;
			}
			uIPanel2 = uIPanel2.mParentPanel;
		}
		return (byte)((flag ? 1u : 0u) ^ 1u) != 0;
	}

	private unsafe static bool IsVisible(ref DepthEntry de)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0092: Expected Obj, but got Ref
		//IL_00a3: Expected Obj, but got I
		//IL_0028: Expected F4, but got I
		//IL_0023: Expected native int or pointer, but got VT
		//IL_0035: Expected F4, but got Obj
		//IL_0030: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 16);
		object obj2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref de, 48));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [de @ L0 (DepthEntry&)+3C]");
		UIPanel uIPanel = NGUITools.FindInParents<UIPanel>((GameObject)0);
		UIPanel uIPanel2 = uIPanel;
		bool flag;
		while (true)
		{
			flag = uIPanel2 != null;
			if (!flag)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v12+8]");
			((Vector3*)(nint)vector)->z = 0f;
			((Vector3*)(nint)vector)->x = (float)obj2;
			if (!uIPanel2.IsVisible(vector))
			{
				break;
			}
			uIPanel2 = uIPanel2.mParentPanel;
		}
		return (byte)((flag ? 1u : 0u) ^ 1u) != 0;
	}

	public static bool IsHighlighted(GameObject go)
	{
		GameObject gameObject = hoveredObject;
		return gameObject == go;
	}

	public static UICamera FindCameraForLayer(int layer)
	{
		//IL_00e3: Expected Obj, but got I4
		//IL_003f: Expected Obj, but got I
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected Obj, but got Unknown
		//IL_009e: Expected Obj, but got I
		int num = 1 << layer;
		object obj = 0;
		UICamera result;
		while (true)
		{
			BetterList<UICamera> betterList = list;
			bool flag = (nint)obj >= betterList.size;
			result = null;
			if (flag)
			{
				break;
			}
			BetterList<UICamera> betterList2 = list;
			object obj2 = obj << 2;
			object obj3 = (object)betterList2.buffer + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v23+10]");
			Camera camera = ((UICamera)0).cachedCamera;
			if (camera != null)
			{
				int cullingMask = camera.cullingMask;
				int num2 = cullingMask & num;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v23+10]");
				result = (UICamera)0;
				if (num2 != 0)
				{
					break;
				}
			}
			object obj4 = obj + 1;
			obj = obj4;
		}
		return result;
	}

	private static int GetDirection(KeyCode up, KeyCode down)
	{
		GetKeyStateFunc getKeyDown = GetKeyDown;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v15.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		object obj = default;
		bool flag = obj == null;
		bool flag2 = !flag;
		int result = 1;
		if (!flag2)
		{
			GetKeyStateFunc getKeyDown2 = GetKeyDown;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v38.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			object obj2 = default;
			bool flag3 = obj2 == null;
			result = 0;
			if (flag3)
			{
				goto IL_004c;
			}
			result = -1;
		}
		currentKey = down;
		goto IL_004c;
		IL_004c:
		return result;
	}

	private static int GetDirection(KeyCode up0, KeyCode up1, KeyCode down0, KeyCode down1)
	{
		GetKeyStateFunc getKeyDown = GetKeyDown;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v15.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		object obj = default;
		KeyCode keyCode = default;
		int result;
		if (obj != null)
		{
			keyCode = up0;
			result = 1;
		}
		else
		{
			GetKeyStateFunc getKeyDown2 = GetKeyDown;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v37.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			result = 1;
			object obj2 = default;
			if (obj2 == null)
			{
				GetKeyStateFunc getKeyDown3 = GetKeyDown;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v90.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				object obj3 = default;
				if (obj3 != null)
				{
					keyCode = down0;
					result = -1;
				}
				else
				{
					GetKeyStateFunc getKeyDown4 = GetKeyDown;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v105.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
					object obj4 = default;
					bool flag = obj4 == null;
					result = 0;
					if (flag)
					{
						goto IL_00da;
					}
					keyCode = down1;
					result = -1;
				}
			}
		}
		currentKey = keyCode;
		goto IL_00da;
		IL_00da:
		return result;
	}

	private static int GetDirection(string axis)
	{
		//IL_0047: Expected Obj, but got I4
		//IL_002b: Expected Obj, but got I4
		//IL_0068: Invalid comparison between Obj and F4
		//IL_00a4: Invalid comparison between Obj and F4
		float unscaledTime = Time.unscaledTime;
		bool flag = mNextEvent < unscaledTime;
		bool flag2 = !flag;
		int result = 0;
		if (flag2)
		{
			goto IL_0144;
		}
		object obj;
		if (axis != null)
		{
			obj = 0;
			if (axis._stringLength != 0)
			{
				goto IL_0149;
			}
		}
		obj = 1;
		goto IL_0149;
		IL_0149:
		result = 0;
		if (obj == null)
		{
			GetAxisFunc getAxis = GetAxis;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v70.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			object obj2 = default;
			bool flag3 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0.75f);
			bool flag4 = !flag3;
			bool flag5 = !flag4;
			int num = 1;
			if (!flag5)
			{
				bool flag6 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)(-0.75f));
				bool flag7 = !flag6;
				num = -1;
				result = 0;
				if (flag7)
				{
					goto IL_0144;
				}
			}
			currentKey = KeyCode.JoystickButton0;
			float num2 = unscaledTime + 0.25f;
			mNextEvent = num2;
			result = num;
		}
		goto IL_0144;
		IL_0144:
		return result;
	}

	public static void Notify(GameObject go, string funcName, object obj)
	{
		if (mNotifying > 10)
		{
			return;
		}
		ControlScheme controlScheme = currentScheme;
		GameObject gameObject2 = default;
		if (controlScheme == ControlScheme.Controller && UIPopupList.isOpen)
		{
			UIPopupList uIPopupList = UIPopupList.current;
			GameObject gameObject = default;
			if (uIPopupList.source == gameObject && UIPopupList.isOpen)
			{
				gameObject2 = UIPopupList.current.gameObject;
			}
		}
		if ((bool)gameObject2 && gameObject2.activeInHierarchy)
		{
			int num = mNotifying + 1;
			mNotifying = num;
			gameObject2.SendMessage(funcName, obj, SendMessageOptions.DontRequireReceiver);
			if (mGenericHandler != null && mGenericHandler != gameObject2)
			{
				mGenericHandler.SendMessage(funcName, obj, SendMessageOptions.DontRequireReceiver);
			}
			int num2 = mNotifying - 1;
			mNotifying = num2;
		}
	}

	public static MouseOrTouch GetMouse(int button)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_002e: Expected Obj, but got I
		int num = button << 2;
		object obj = mMouse + num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v11+10]");
		return (MouseOrTouch)0;
	}

	public static MouseOrTouch GetTouch(int id, bool createIfMissing = false)
	{
		if (id <= -1)
		{
			int button = -1 - id;
			return GetMouse(button);
		}
		List<int> list = mTouchIDs;
		int num = 0;
		while (true)
		{
			int num2 = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (System.Collections.Generic.List`1<System.Int32>)+C]");
			if ((nint)num2 >= (nint)0)
			{
				break;
			}
			int num3 = mTouchIDs.get_Item(num);
			if (num3 == id)
			{
				return activeTouches.get_Item(num);
			}
			int num4 = num + 1;
			num = num4;
		}
		bool flag = !createIfMissing;
		MouseOrTouch result = null;
		if (!flag)
		{
			MouseOrTouch mouseOrTouch = default;
			mouseOrTouch.touchBegan = true;
			mouseOrTouch.clickNotification = ClickNotification.Always;
			float unscaledTime = Time.unscaledTime;
			mouseOrTouch.touchBegan = true;
			mouseOrTouch.pressTime = unscaledTime;
			activeTouches.Add(mouseOrTouch);
			mTouchIDs.Add(id);
			result = mouseOrTouch;
		}
		return result;
	}

	public static void RemoveTouch(int id)
	{
		List<int> list = mTouchIDs;
		int num = 0;
		while (true)
		{
			int num2 = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (System.Collections.Generic.List`1<System.Int32>)+C]");
			if ((nint)num2 < (nint)0)
			{
				int num3 = mTouchIDs.get_Item(num);
				if (num3 != id)
				{
					int num4 = num + 1;
					num = num4;
					continue;
				}
				mTouchIDs.RemoveAt(num);
				activeTouches.RemoveAt(num);
				break;
			}
			break;
		}
	}

	private void Awake()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_004d: Expected VT, but got Obj
		//IL_0056: Expected Obj, but got I4
		//IL_0086: Expected Obj, but got I
		//IL_00d7: Expected Obj, but got I
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		int width = Screen.width;
		mWidth = width;
		int height = Screen.height;
		mHeight = height;
		MouseOrTouch[] array = mMouse;
		MouseOrTouch mouseOrTouch = array[0];
		Vector3 mousePosition = Input.mousePosition;
		mouseOrTouch.pos = (Vector2)obj;
		object obj3 = 1;
		MouseOrTouch[] array2;
		while (true)
		{
			array2 = mMouse;
			if ((nint)obj3 >= 3)
			{
				break;
			}
			object obj4 = obj3 << 2;
			object obj5 = (object)array2 + obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v42+10]");
			object obj6 = 0;
			MouseOrTouch[] array3 = mMouse;
			MouseOrTouch mouseOrTouch2 = array3[0];
			_ = mouseOrTouch2.pos;
			object obj7 = obj3 << 2;
			object obj8 = (object)mMouse + obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v48+10]");
			object obj9 = 0;
			MouseOrTouch[] array4 = mMouse;
			MouseOrTouch mouseOrTouch3 = array4[0];
			_ = mouseOrTouch3.pos;
			object obj10 = obj3 + 1;
			obj3 = obj10;
		}
		MouseOrTouch mouseOrTouch4 = array2[0];
		mLastPos = mouseOrTouch4.pos;
	}

	private void OnEnable()
	{
		list.Add(this);
		throw new ArgumentException();
	}

	private void OnDisable()
	{
		bool flag = list.Remove(this);
	}

	private void Start()
	{
		if (eventType != EventType.World_3D)
		{
			Camera camera = cachedCamera;
			TransparencySortMode transparencySortMode = camera.transparencySortMode;
			if (transparencySortMode != TransparencySortMode.Orthographic)
			{
				Camera camera2 = cachedCamera;
				camera2.transparencySortMode = TransparencySortMode.Orthographic;
			}
		}
		if (!Application.isPlaying)
		{
			return;
		}
		if (fallThrough == null)
		{
			GameObject go = base.gameObject;
			UIRoot uIRoot = NGUITools.FindInParents<UIRoot>(go);
			bool flag = uIRoot == null;
			UIRoot uIRoot2 = uIRoot;
			if (flag)
			{
				Transform transform = base.transform;
				Transform parent = transform.parent;
				bool flag2 = parent != null;
				bool flag3 = !flag2;
				uIRoot2 = (UIRoot)(object)this;
				if (!flag3)
				{
					Transform parent2 = transform.parent;
					uIRoot2 = (UIRoot)(object)parent2;
				}
			}
			GameObject gameObject = uIRoot2.gameObject;
			fallThrough = gameObject;
		}
		Camera camera3 = cachedCamera;
		camera3.eventMask = 0;
	}

	private void Update()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0176: Expected Obj, but got I4
		//IL_015a: Expected Obj, but got I4
		//IL_0197: Invalid comparison between Obj and F4
		//IL_03af: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b4: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		if (!handlesEvents)
		{
			return;
		}
		current = this;
		NGUIDebug.debugRaycast = debug;
		if (~(useTouch ? 1u : 0u) == 0)
		{
			ProcessTouches();
		}
		else if (~(useMouse ? 1u : 0u) == 0)
		{
			ProcessMouse();
		}
		if (UICamera.onCustomInput != null)
		{
			OnCustomInput onCustomInput = UICamera.onCustomInput;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v109.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
		if ((~(useKeyboard ? 1u : 0u) == 0 || ~(useController ? 1u : 0u) == 0) && !disableController)
		{
			ProcessOthers();
		}
		if (~(useMouse ? 1u : 0u) != 0 || !(mHover != null))
		{
			goto IL_02e3;
		}
		string text = scrollAxisName;
		object obj3;
		if (scrollAxisName != null)
		{
			obj3 = 0;
			if (text._stringLength != 0)
			{
				goto IL_0393;
			}
		}
		obj3 = 1;
		goto IL_0393;
		IL_02e3:
		if (mTooltip != null && !NGUITools.GetActive(mTooltip))
		{
			bool flag = ShowTooltip(null);
		}
		current = null;
		currentTouchID = -100;
		return;
		IL_0393:
		if (obj3 == null)
		{
			GetAxisFunc getAxis = GetAxis;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v243.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			object obj4 = default;
			if (obj4 != (object)0f)
			{
				if (onScroll != null)
				{
					FloatDelegate floatDelegate = onScroll;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v289.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				}
				object obj5 = obj + 12;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
				object obj6 = default;
				Notify(mHover, "OnScroll", obj6);
			}
		}
		if (~(showTooltips ? 1u : 0u) == 0 && mTooltipTime != 0f && !UIPopupList.isOpen)
		{
			float unscaledTime = Time.unscaledTime;
			if (!(mTooltipTime < unscaledTime))
			{
				GetKeyStateFunc getKey = GetKey;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v332.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				object obj7 = default;
				if (obj7 == null)
				{
					GetKeyStateFunc getKey2 = GetKey;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v360.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
					object obj8 = default;
					if (obj8 == null)
					{
						goto IL_02e3;
					}
				}
			}
			MouseOrTouch[] array = mMouse;
			currentTouch = array[0];
			currentTouchID = -1;
			bool flag2 = ShowTooltip(mHover);
		}
		goto IL_02e3;
	}

	private void LateUpdate()
	{
		if (!handlesEvents)
		{
			return;
		}
		int width = Screen.width;
		int height = Screen.height;
		if (mWidth != width || height != mHeight)
		{
			mWidth = width;
			mHeight = height;
			UIRoot.Broadcast("UpdateAnchors");
			if (UICamera.onScreenResize != null)
			{
				OnScreenResize onScreenResize = UICamera.onScreenResize;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v82.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
	}

	public void ProcessMouse()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0986: Expected Obj, but got I4
		//IL_003f: Expected Obj, but got I4
		//IL_0118: Expected Obj, but got I
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected VT, but got Unknown
		//IL_0207: Expected VT, but got I4
		//IL_09bf: Expected Obj, but got VT
		//IL_09dc: Expected Obj, but got I
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected Obj, but got Unknown
		//IL_01a3: Expected Obj, but got I
		//IL_01be: Expected VT, but got Obj
		//IL_0255: Invalid comparison between Obj and F4
		//IL_026f: Expected Obj, but got I4
		//IL_0a37: Expected Obj, but got I4
		//IL_0224: Invalid comparison between Obj and F4
		//IL_0286: Expected Obj, but got I4
		//IL_032d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Expected Obj, but got Unknown
		//IL_02b7: Expected Obj, but got I
		//IL_02f6: Expected Obj, but got I
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Expected Obj, but got Unknown
		//IL_03c7: Expected Obj, but got I4
		//IL_03f8: Expected Obj, but got I
		//IL_0414: Unknown result type (might be due to invalid IL or missing references)
		//IL_0419: Expected Obj, but got Unknown
		//IL_04cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d1: Expected Obj, but got Unknown
		//IL_04fe: Expected Obj, but got I4
		//IL_0506: Unknown result type (might be due to invalid IL or missing references)
		//IL_050b: Expected Obj, but got Unknown
		//IL_064a: Expected Obj, but got I4
		//IL_0653: Unknown result type (might be due to invalid IL or missing references)
		//IL_0658: Expected Obj, but got Unknown
		//IL_0661: Unknown result type (might be due to invalid IL or missing references)
		//IL_0666: Expected Obj, but got Unknown
		//IL_066f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0674: Expected Obj, but got Unknown
		//IL_067d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0682: Expected Obj, but got Unknown
		//IL_0824: Expected Obj, but got I4
		//IL_0622: Unknown result type (might be due to invalid IL or missing references)
		//IL_0627: Expected Obj, but got Unknown
		//IL_090c: Expected Obj, but got I4
		//IL_0699: Expected Obj, but got I4
		//IL_093d: Expected Obj, but got I
		//IL_096b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0970: Expected Obj, but got Unknown
		//IL_072d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0732: Expected Obj, but got Unknown
		//IL_0743: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 32;
		object obj3 = 0;
		int num = default;
		int num2 = default;
		for (; num < 3; num = num2 + 1)
		{
			bool mouseButtonDown = Input.GetMouseButtonDown(num);
			bool flag = !mouseButtonDown;
			bool flag2 = !flag;
			object obj4 = 1;
			if (!flag2)
			{
				bool mouseButton = Input.GetMouseButton(num);
				bool flag3 = !mouseButton;
				obj4 = obj3;
				if (flag3)
				{
					continue;
				}
			}
			KeyCode keyCode = (KeyCode)(num + 323);
			currentKey = keyCode;
			obj3 = obj4;
		}
		ControlScheme controlScheme = currentScheme;
		if (controlScheme == ControlScheme.Touch)
		{
			return;
		}
		MouseOrTouch[] array = mMouse;
		currentTouch = array[0];
		Vector3 mousePosition = Input.mousePosition;
		MouseOrTouch mouseOrTouch = currentTouch;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+14]");
		object obj5 = (nint)0 << 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		Vector2 pos = (Vector2)(0 | obj5);
		MouseOrTouch mouseOrTouch2 = currentTouch;
		if (mouseOrTouch.ignoreDelta == 0)
		{
			MouseOrTouch mouseOrTouch3 = currentTouch;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			object obj6 = 0 - mouseOrTouch3.pos;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+14]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S0_v374 (UICamera+MouseOrTouch)+10]");
			object obj7 = num3 - 0;
			object obj8 = obj7 << 32;
			Vector2 delta = (Vector2)(obj6 | obj8);
			mouseOrTouch2.delta = delta;
		}
		else
		{
			int ignoreDelta = mouseOrTouch2.ignoreDelta - 1;
			mouseOrTouch2.ignoreDelta = ignoreDelta;
			MouseOrTouch mouseOrTouch4 = currentTouch;
			mouseOrTouch4.delta = (Vector2)0;
			MouseOrTouch mouseOrTouch5 = currentTouch;
			_ = 0;
		}
		MouseOrTouch mouseOrTouch6 = currentTouch;
		object obj9 = mouseOrTouch6.delta * mouseOrTouch6.delta;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ S0_v55 (UICamera+MouseOrTouch)+20]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ S0_v55 (UICamera+MouseOrTouch)+20]");
		object obj10 = num4 * 0;
		object obj11 = obj9 + obj10;
		MouseOrTouch mouseOrTouch7 = currentTouch;
		mouseOrTouch7.pos = pos;
		mLastPos = pos;
		object obj12;
		if (currentScheme != ControlScheme.Mouse)
		{
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0.001f))
			{
				return;
			}
			currentKey = KeyCode.Mouse0;
		}
		else
		{
			bool flag4 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0.001f);
			bool flag5 = !flag4;
			obj12 = 0;
			if (flag5)
			{
				goto IL_0a2e;
			}
		}
		obj12 = 1;
		goto IL_0a2e;
		IL_0a2e:
		object obj13 = 1;
		while ((nint)obj13 < 3)
		{
			object obj14 = obj13 << 2;
			object obj15 = (object)mMouse + obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ S0_v342+10]");
			object obj16 = 0;
			MouseOrTouch mouseOrTouch8 = currentTouch;
			_ = mouseOrTouch8.pos;
			object obj17 = obj13 << 2;
			object obj18 = (object)mMouse + obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ S0_v348+10]");
			object obj19 = 0;
			MouseOrTouch mouseOrTouch9 = currentTouch;
			_ = mouseOrTouch9.delta;
			object obj20 = obj13 + 1;
			obj13 = obj20;
		}
		object obj21 = obj12 | 1;
		if (obj21 == null)
		{
			float unscaledTime = Time.unscaledTime;
			if (!(mNextRaycast < unscaledTime))
			{
				goto IL_0a64;
			}
		}
		float unscaledTime2 = Time.unscaledTime;
		float num5 = unscaledTime2 + 0.02f;
		mNextRaycast = num5;
		Raycast(currentTouch);
		object obj22 = 0;
		while ((nint)obj22 < 3)
		{
			object obj23 = obj22 << 2;
			object obj24 = (object)mMouse + obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ S0_v328+10]");
			object obj25 = 0;
			MouseOrTouch mouseOrTouch10 = currentTouch;
			_ = mouseOrTouch10.current;
			object obj26 = obj22 + 1;
			obj22 = obj26;
		}
		goto IL_0a64;
		IL_0a64:
		MouseOrTouch mouseOrTouch11 = currentTouch;
		MouseOrTouch mouseOrTouch12 = currentTouch;
		bool flag6 = mouseOrTouch11.last != mouseOrTouch12.current;
		MouseOrTouch mouseOrTouch13 = currentTouch;
		bool flag7 = mouseOrTouch13.pressed != null;
		if (!flag7)
		{
			MouseOrTouch mouseOrTouch14 = currentTouch;
			hoveredObject = mouseOrTouch14.current;
		}
		currentTouchID = -1;
		if (flag6)
		{
			currentKey = KeyCode.Mouse0;
		}
		bool flag8 = 1 == 0;
		object obj27 = obj12 & flag8;
		if (obj27 != null)
		{
			object obj28 = (stickyTooltip ? 1 : 0) ^ 1;
			object obj29 = obj28 | flag6;
			if (obj29 != null)
			{
				if (mTooltipTime != 0f)
				{
					float unscaledTime3 = Time.unscaledTime;
					float num6 = unscaledTime3 + tooltipDelay;
					mTooltipTime = num6;
				}
				else if (mTooltip != null)
				{
					bool flag9 = ShowTooltip(null);
				}
			}
		}
		if (obj12 != null && onMouseMove != null)
		{
			MoveDelegate moveDelegate = onMouseMove;
			MouseOrTouch mouseOrTouch15 = currentTouch;
			_ = mouseOrTouch15.delta;
			_ = mouseOrTouch15.delta;
			object obj30 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v539.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			currentTouch = null;
		}
		if (flag6)
		{
			object obj31 = (flag7 ? 1 : 0) ^ -1;
			object obj32 = 1 | obj31;
			object obj33 = obj32 & 1;
			object obj34 = obj3 ^ 1;
			object obj35 = obj34 & 1;
			if (obj35 == null)
			{
				obj33 = 0;
			}
			if (obj33 == null)
			{
				hoveredObject = null;
			}
		}
		int num7 = 0;
		while (num7 < 3)
		{
			bool mouseButtonDown2 = Input.GetMouseButtonDown(num7);
			bool mouseButtonUp = Input.GetMouseButtonUp(num7);
			bool flag10 = true;
			if (!mouseButtonUp)
			{
				flag10 = mouseButtonDown2;
			}
			if (flag10)
			{
				KeyCode keyCode2 = (KeyCode)(num7 + 323);
				currentKey = keyCode2;
			}
			int num8 = num7 << 2;
			object obj36 = mMouse + num8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v675 @ S1_v78+10]");
			currentTouch = (MouseOrTouch)0;
			int num9 = -1 - num7;
			currentTouchID = num9;
			KeyCode keyCode3 = (KeyCode)(num7 + 323);
			currentKey = keyCode3;
			MouseOrTouch mouseOrTouch16 = currentTouch;
			if (mouseButtonDown2)
			{
				mouseOrTouch16.pressedCam = currentCamera;
				MouseOrTouch mouseOrTouch17 = currentTouch;
				float unscaledTime4 = Time.unscaledTime;
				mouseOrTouch17.pressTime = unscaledTime4;
			}
			else if (mouseOrTouch16.pressed != null)
			{
				MouseOrTouch mouseOrTouch18 = currentTouch;
				currentCamera = mouseOrTouch18.pressedCam;
			}
			ProcessTouch(mouseButtonDown2, mouseButtonUp);
			int num10 = num7 + 1;
			num7 = num10;
		}
		object obj37 = flag6 & flag8;
		if (obj37 != null)
		{
			MouseOrTouch[] array2 = mMouse;
			currentTouch = array2[0];
			float unscaledTime5 = Time.unscaledTime;
			float num11 = unscaledTime5 + tooltipDelay;
			mTooltipTime = num11;
			currentTouchID = -1;
			currentKey = KeyCode.Mouse0;
			MouseOrTouch mouseOrTouch19 = currentTouch;
			hoveredObject = mouseOrTouch19.current;
		}
		currentTouch = null;
		MouseOrTouch[] array3 = mMouse;
		MouseOrTouch mouseOrTouch20 = array3[0];
		MouseOrTouch[] array4 = mMouse;
		MouseOrTouch mouseOrTouch21 = array4[0];
		mouseOrTouch20.last = mouseOrTouch21.current;
		object obj38 = 1;
		while ((nint)obj38 < 3)
		{
			object obj39 = obj38 << 2;
			object obj40 = (object)mMouse + obj39;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v696 @ S0_v150+10]");
			object obj41 = 0;
			MouseOrTouch[] array5 = mMouse;
			MouseOrTouch mouseOrTouch22 = array5[0];
			_ = mouseOrTouch22.last;
			object obj42 = obj38 + 1;
			obj38 = obj42;
		}
	}

	public void ProcessTouches()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Expected Obj, but got Unknown
		//IL_00fc: Expected Obj, but got I
		//IL_010c: Expected VT, but got I
		//IL_012c: Expected Obj, but got I
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected Obj, but got Unknown
		//IL_009c: Expected Obj, but got I
		//IL_00ac: Expected Obj, but got I
		//IL_00b4: Expected VT, but got Obj
		//IL_00d4: Expected Obj, but got I
		//IL_03e0: Expected Obj, but got VT
		//IL_03ee: Expected Obj, but got VT
		//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0403: Expected Obj, but got Unknown
		//IL_041e: Expected VT, but got Obj
		//IL_04ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b3: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 144;
		object obj3 = obj + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @237");
		int num = default;
		if (GetInputTouchCount == null)
		{
			num = Input.touchCount;
		}
		else
		{
			GetTouchCountCallback getInputTouchCount = GetInputTouchCount;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v37.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
		int num2 = 0;
		while (num2 < num)
		{
			object obj5;
			Vector2 vector;
			int num3;
			object obj6;
			if (GetInputTouch == null)
			{
				UnityEngine.Touch touch = Input.GetTouch(num2);
				object obj4 = obj + 72;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4C]");
				obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
				obj5 = 0;
				vector = (Vector2)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
				num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+6C]");
				obj6 = 0;
			}
			else
			{
				GetTouchCallback getInputTouch = GetInputTouch;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v141.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S0_v173+18]");
				obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S0_v173+10]");
				vector = (Vector2)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S0_v173+8]");
				num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S0_v173+C]");
				obj6 = 0;
			}
			int num4 = num3;
			if (!allowMultiTouch)
			{
				num4 = 1;
			}
			currentTouchID = num4;
			MouseOrTouch touch2 = GetTouch(currentTouchID, createIfMissing: true);
			currentTouch = touch2;
			bool flag;
			if (obj6 != null)
			{
				MouseOrTouch mouseOrTouch = currentTouch;
				flag = mouseOrTouch.touchBegan;
			}
			else
			{
				flag = true;
			}
			MouseOrTouch mouseOrTouch2 = currentTouch;
			mouseOrTouch2.touchBegan = false;
			MouseOrTouch mouseOrTouch3 = currentTouch;
			MouseOrTouch mouseOrTouch4 = currentTouch;
			object obj7 = vector - mouseOrTouch3.pos;
			object obj8 = vector >> 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ S0_v82 (UICamera+MouseOrTouch)+10]");
			object obj9 = obj8 - 0;
			object obj10 = obj9 << 32;
			Vector2 delta = (Vector2)(obj7 | obj10);
			mouseOrTouch4.delta = delta;
			MouseOrTouch mouseOrTouch5 = currentTouch;
			mouseOrTouch5.pos = vector;
			currentKey = KeyCode.None;
			Raycast(currentTouch);
			MouseOrTouch mouseOrTouch6 = currentTouch;
			if (flag)
			{
				mouseOrTouch6.pressedCam = currentCamera;
			}
			else if (mouseOrTouch6.pressed != null)
			{
				MouseOrTouch mouseOrTouch7 = currentTouch;
				currentCamera = mouseOrTouch7.pressedCam;
			}
			if ((nint)obj5 >= 2)
			{
				MouseOrTouch mouseOrTouch8 = currentTouch;
				float unscaledTime = Time.unscaledTime;
				mouseOrTouch8.clickTime = unscaledTime;
			}
			object obj11 = obj6 - 3;
			bool released = (nint)obj11 < 2;
			ProcessTouch(flag, released);
			if ((nint)obj11 <= 1)
			{
				RemoveTouch(currentTouchID);
			}
			MouseOrTouch mouseOrTouch9 = currentTouch;
			mouseOrTouch9.last = null;
			currentTouch = null;
			if (~(allowMultiTouch ? 1u : 0u) != 0)
			{
				break;
			}
			int num5 = num2 + 1;
			num2 = num5;
		}
		if (num == 0)
		{
			if (~(mUsingTouchEvents ? 1u : 0u) == 0)
			{
				mUsingTouchEvents = false;
			}
			else if (~(useMouse ? 1u : 0u) == 0)
			{
				ProcessMouse();
			}
		}
		else
		{
			mUsingTouchEvents = true;
		}
	}

	private void ProcessFakeTouches()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected Obj, but got Unknown
		//IL_0124: Expected Obj, but got I
		//IL_013f: Expected VT, but got Obj
		//IL_016b: Expected Obj, but got I
		//IL_0178: Expected VT, but got Obj
		object obj2 = default;
		object obj = obj2 - 16;
		bool mouseButtonDown = Input.GetMouseButtonDown(0);
		bool mouseButtonUp = Input.GetMouseButtonUp(0);
		bool mouseButton = Input.GetMouseButton(0);
		if (mouseButtonDown || mouseButtonUp || mouseButton)
		{
			currentTouchID = 1;
			MouseOrTouch[] array = mMouse;
			currentTouch = array[0];
			MouseOrTouch mouseOrTouch = currentTouch;
			mouseOrTouch.touchBegan = mouseButtonDown;
			if (mouseButtonDown)
			{
				MouseOrTouch mouseOrTouch2 = currentTouch;
				float unscaledTime = Time.unscaledTime;
				mouseOrTouch2.pressTime = unscaledTime;
				activeTouches.Add(currentTouch);
			}
			Vector3 mousePosition = Input.mousePosition;
			MouseOrTouch mouseOrTouch3 = currentTouch;
			MouseOrTouch mouseOrTouch4 = currentTouch;
			object obj3 = obj - mouseOrTouch3.pos;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v45 (UICamera+MouseOrTouch)+10]");
			object obj4 = num - 0;
			object obj5 = obj4 << 32;
			Vector2 delta = (Vector2)(obj3 | obj5);
			mouseOrTouch4.delta = delta;
			MouseOrTouch mouseOrTouch5 = currentTouch;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
			object obj6 = (nint)0 << 32;
			Vector2 pos = (Vector2)(obj | obj6);
			mouseOrTouch5.pos = pos;
			Raycast(currentTouch);
			MouseOrTouch mouseOrTouch6 = currentTouch;
			if (mouseButtonDown)
			{
				mouseOrTouch6.pressedCam = currentCamera;
			}
			else if (mouseOrTouch6.pressed != null)
			{
				MouseOrTouch mouseOrTouch7 = currentTouch;
				currentCamera = mouseOrTouch7.pressedCam;
			}
			currentKey = KeyCode.None;
			ProcessTouch(mouseButtonDown, mouseButtonUp);
			if (mouseButtonUp)
			{
				bool flag = activeTouches.Remove(currentTouch);
			}
			MouseOrTouch mouseOrTouch8 = currentTouch;
			mouseOrTouch8.last = null;
			currentTouch = null;
		}
	}

	public unsafe void ProcessOthers()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0ae8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aed: Expected I4, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected I4, but got Unknown
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Expected I4, but got Unknown
		//IL_0b70: Expected Obj, but got I4
		//IL_0956: Expected Obj, but got I4
		//IL_049e: Expected Obj, but got I4
		//IL_0380: Expected I4, but got Obj
		//IL_0bb0: Expected Obj, but got I4
		//IL_0482: Expected Obj, but got I4
		//IL_0abc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac1: Expected Obj, but got Unknown
		//IL_0603: Expected Obj, but got I4
		//IL_05e7: Expected Obj, but got I4
		//IL_04cf: Expected Obj, but got I4
		//IL_0460: Expected I4, but got Obj
		//IL_0755: Expected Obj, but got I4
		//IL_0739: Expected Obj, but got I4
		//IL_0df0: Invalid comparison between Obj and F4
		//IL_0798: Expected Obj, but got I4
		//IL_0550: Expected Obj, but got I4
		//IL_077c: Expected Obj, but got I4
		//IL_0e28: Invalid comparison between Obj and F4
		//IL_0577: Expected Obj, but got I4
		//IL_0d68: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d6d: Expected Obj, but got Unknown
		//IL_058e: Expected Obj, but got I4
		//IL_06ca: Expected Obj, but got I4
		//IL_0d05: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d0a: Expected Obj, but got Unknown
		//IL_0db3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db8: Expected Obj, but got Unknown
		//IL_06e1: Expected Obj, but got I4
		//IL_0c82: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c87: Expected Obj, but got Unknown
		//IL_08a5: Expected Obj, but got F4
		//IL_08ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b2: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		currentTouchID = -100;
		currentTouch = controller;
		KeyCode keyCode = (KeyCode)(this + 84);
		KeyCode keyCode2;
		if (submitKey0 != KeyCode.None)
		{
			GetKeyStateFunc getKeyDown = GetKeyDown;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v71.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			keyCode2 = keyCode;
			object obj3 = default;
			if (obj3 != null)
			{
				goto IL_0149;
			}
		}
		KeyCode keyCode3 = (KeyCode)(this + 88);
		if (submitKey1 != KeyCode.None)
		{
			GetKeyStateFunc getKeyDown2 = GetKeyDown;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v119.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			keyCode2 = keyCode3;
			object obj4 = default;
			if (obj4 != null)
			{
				goto IL_0149;
			}
		}
		int value__;
		if (((KeyCode*)(int)keyCode)->value__ != 13)
		{
			bool flag = submitKey1 != KeyCode.Return;
			value__ = ((KeyCode*)(int)keyCode)->value__;
			if (flag)
			{
				goto IL_0b0c;
			}
		}
		GetKeyStateFunc getKeyDown3 = GetKeyDown;
		IntPtr invoke_impl = ((Delegate)getKeyDown3).invoke_impl;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v160.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		object obj5 = default;
		bool flag2 = obj5 == null;
		keyCode2 = keyCode;
		IntPtr intPtr = ((Delegate)getKeyDown3).invoke_impl;
		bool flag3 = false;
		if (!flag2)
		{
			goto IL_0149;
		}
		goto IL_0b29;
		IL_0c30:
		object obj6;
		if (obj6 == null)
		{
			GetAxisFunc getAxis = GetAxis;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v782 @ S2_v47 (UICamera+GetAxisFunc)+C] (should have been resolved before IL gen)");
		}
		object obj7 = default;
		bool flag4;
		if (obj7 != (object)0f)
		{
			flag4 = false;
		}
		object obj8 = default;
		if (!flag4)
		{
			bool flag5 = ShowTooltip(null);
			currentScheme = ControlScheme.Controller;
			MouseOrTouch mouseOrTouch = currentTouch;
			GameObject gameObject = controllerNavigationObject;
			mouseOrTouch.current = gameObject;
			MouseOrTouch mouseOrTouch2 = currentTouch;
			if (mouseOrTouch2.current != null)
			{
				float unscaledDeltaTime = Time.unscaledDeltaTime;
				float num = (float)obj8 * unscaledDeltaTime;
				float num2 = (float)obj7 * unscaledDeltaTime;
				if (onPan != null)
				{
					MouseOrTouch mouseOrTouch3 = currentTouch;
					VectorDelegate vectorDelegate = onPan;
					object obj9 = num2 << 32;
					object obj10 = num | obj9;
					obj = obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1007.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				}
				MouseOrTouch mouseOrTouch4 = currentTouch;
				object obj11 = obj + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
				object obj12 = default;
				Notify(mouseOrTouch4.current, "OnPan", obj12);
			}
		}
		goto IL_08cf;
		IL_0944:
		KeyCode[] keys = NGUITools.keys;
		object obj13 = 0;
		object obj17;
		object obj18 = default;
		object obj20 = default;
		while ((nint)obj13 < keys.Length)
		{
			object obj14 = obj13 << 2;
			object obj15 = (object)NGUITools.keys + obj14;
			object obj16 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ S1_v24+10]");
			if (obj16 != null)
			{
				GetKeyStateFunc getKeyDown4 = GetKeyDown;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v663.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				if (obj18 != null)
				{
					bool flag6 = useKeyboard;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ S1_v24+10]");
					if ((nint)0 >= (nint)323)
					{
						flag6 = true;
					}
					if (flag6)
					{
						bool flag7 = useController;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ S1_v24+10]");
						if ((nint)0 <= (nint)329)
						{
							flag7 = true;
						}
						if (flag7 && ~(useMouse ? 1u : 0u) == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ S1_v24+10]");
							currentKey = KeyCode.None;
							if (onKey != null)
							{
								KeyCodeDelegate keyCodeDelegate = onKey;
								MouseOrTouch mouseOrTouch5 = currentTouch;
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v888.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
							}
							MouseOrTouch mouseOrTouch6 = currentTouch;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ S1_v24+10]");
							_ = 0;
							object obj19 = obj + 8;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
							Notify(mouseOrTouch6.current, "OnKey", obj20);
						}
					}
				}
			}
			object obj21 = obj13 + 1;
			obj13 = obj21;
		}
		goto IL_0cad;
		IL_0b43:
		bool flag8;
		if (flag3)
		{
			MouseOrTouch mouseOrTouch7 = currentTouch;
			float unscaledTime = Time.unscaledTime;
			mouseOrTouch7.pressTime = unscaledTime;
		}
		else if (!flag8)
		{
			goto IL_0b5c;
		}
		ControlScheme controlScheme = currentScheme;
		if (controlScheme == ControlScheme.Controller)
		{
			MouseOrTouch mouseOrTouch8 = currentTouch;
			GameObject gameObject2 = controllerNavigationObject;
			mouseOrTouch8.current = gameObject2;
			ProcessTouch(flag3, flag8);
			KeyCode keyCode4 = (KeyCode)currentTouch;
			MouseOrTouch mouseOrTouch9 = currentTouch;
			_ = mouseOrTouch9.current;
		}
		goto IL_0b5c;
		IL_02b2:
		KeyCode keyCode5;
		currentKey = (KeyCode)((KeyCode*)(int)keyCode5)->value__;
		flag8 = true;
		goto IL_0b43;
		IL_0b7e:
		string text = verticalAxisName;
		object obj22;
		if (verticalAxisName != null)
		{
			obj22 = 0;
			if (text._stringLength != 0)
			{
				goto IL_0ba7;
			}
		}
		obj22 = 1;
		goto IL_0ba7;
		IL_08cf:
		if (GetAnyKeyDown == null)
		{
			if (Input.anyKeyDown)
			{
				goto IL_0944;
			}
		}
		else
		{
			GetAnyKeyFunc getAnyKeyDown = GetAnyKeyDown;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v417.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			object obj23 = default;
			if (obj23 != null)
			{
				goto IL_0944;
			}
		}
		goto IL_0cad;
		IL_0149:
		currentKey = (KeyCode)((KeyCode*)(int)keyCode2)->value__;
		intPtr = invoke_impl;
		flag3 = true;
		goto IL_0b29;
		IL_0b29:
		invoke_impl = intPtr;
		value__ = ((KeyCode*)(int)keyCode)->value__;
		goto IL_0b0c;
		IL_0b0c:
		if (value__ != 0)
		{
			GetKeyStateFunc getKeyUp = GetKeyUp;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v193.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			keyCode5 = keyCode;
			object obj24 = default;
			if (obj24 != null)
			{
				goto IL_02b2;
			}
		}
		KeyCode keyCode6 = (KeyCode)(this + 88);
		if (submitKey1 != KeyCode.None)
		{
			GetKeyStateFunc getKeyUp2 = GetKeyUp;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v240.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			object obj25 = default;
			if (obj25 != null)
			{
				keyCode5 = keyCode6;
				goto IL_02b2;
			}
		}
		if (((KeyCode*)(int)keyCode)->value__ != 13)
		{
			bool flag9 = ((KeyCode*)(int)keyCode6)->value__ != 13;
			flag8 = false;
			if (flag9)
			{
				goto IL_0b43;
			}
		}
		GetKeyStateFunc getKeyUp3 = GetKeyUp;
		invoke_impl = ((Delegate)getKeyUp3).invoke_impl;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v274.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		object obj26 = default;
		bool flag10 = obj26 == null;
		keyCode5 = keyCode;
		flag8 = false;
		if (!flag10)
		{
			goto IL_02b2;
		}
		goto IL_0b43;
		IL_0bdc:
		object obj27;
		if (obj27 == null)
		{
			int direction = GetDirection(horizontalAxisName);
			if (direction != 0)
			{
				bool flag11 = ShowTooltip(null);
				currentScheme = ControlScheme.Controller;
				MouseOrTouch mouseOrTouch10 = currentTouch;
				GameObject gameObject3 = controllerNavigationObject;
				mouseOrTouch10.current = gameObject3;
				MouseOrTouch mouseOrTouch11 = currentTouch;
				if (mouseOrTouch11.current != null)
				{
					bool flag12 = direction < 1;
					object obj28 = 276;
					if (!flag12)
					{
						obj28 = 275;
					}
					if (onNavigate != null)
					{
						KeyCodeDelegate keyCodeDelegate2 = onNavigate;
						MouseOrTouch mouseOrTouch12 = currentTouch;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v944.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
					}
					MouseOrTouch mouseOrTouch13 = currentTouch;
					object obj29 = obj + 8;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
					object obj30 = default;
					Notify(mouseOrTouch13.current, "OnNavigate", obj30);
					obj17 = obj28;
				}
			}
		}
		string text2 = horizontalPanAxisName;
		object obj31;
		if (horizontalPanAxisName != null)
		{
			obj31 = 0;
			if (text2._stringLength != 0)
			{
				goto IL_0c08;
			}
		}
		obj31 = 1;
		goto IL_0c08;
		IL_0c08:
		if (obj31 == null)
		{
			GetAxisFunc getAxis2 = GetAxis;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v728 @ S0_v221 (UICamera+GetAxisFunc)+C] (should have been resolved before IL gen)");
		}
		flag4 = obj8 == (object)0f;
		string text3 = verticalPanAxisName;
		if (verticalPanAxisName != null)
		{
			obj6 = 0;
			if (text3._stringLength != 0)
			{
				goto IL_0c30;
			}
		}
		obj6 = 1;
		goto IL_0c30;
		IL_0ba7:
		obj17 = 0;
		if (obj22 == null)
		{
			int direction2 = GetDirection(verticalAxisName);
			bool flag13 = direction2 == 0;
			obj17 = 0;
			if (!flag13)
			{
				bool flag14 = ShowTooltip(null);
				currentScheme = ControlScheme.Controller;
				MouseOrTouch mouseOrTouch14 = currentTouch;
				GameObject gameObject4 = controllerNavigationObject;
				mouseOrTouch14.current = gameObject4;
				MouseOrTouch mouseOrTouch15 = currentTouch;
				bool flag15 = mouseOrTouch15.current != null;
				bool flag16 = !flag15;
				obj17 = 0;
				if (!flag16)
				{
					bool flag17 = direction2 < 1;
					object obj32 = 274;
					if (!flag17)
					{
						obj32 = 273;
					}
					if (onNavigate != null)
					{
						KeyCodeDelegate keyCodeDelegate3 = onNavigate;
						MouseOrTouch mouseOrTouch16 = currentTouch;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v853.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
					}
					MouseOrTouch mouseOrTouch17 = currentTouch;
					object obj33 = obj + 8;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
					object obj34 = default;
					Notify(mouseOrTouch17.current, "OnNavigate", obj34);
					obj17 = obj32;
				}
			}
		}
		string text4 = horizontalAxisName;
		if (horizontalAxisName != null)
		{
			obj27 = 0;
			if (text4._stringLength != 0)
			{
				goto IL_0bdc;
			}
		}
		obj27 = 1;
		goto IL_0bdc;
		IL_0b5c:
		bool flag18 = (byte)(~(useController ? 1u : 0u)) != 0;
		obj17 = 0;
		if (flag18)
		{
			goto IL_08cf;
		}
		if (!disableController)
		{
			ControlScheme controlScheme2 = currentScheme;
			if (controlScheme2 == ControlScheme.Controller)
			{
				MouseOrTouch mouseOrTouch18 = currentTouch;
				if (!(mouseOrTouch18.current == null))
				{
					MouseOrTouch mouseOrTouch19 = currentTouch;
					if (mouseOrTouch19.current.activeInHierarchy)
					{
						goto IL_0b7e;
					}
				}
				KeyCode keyCode7 = (KeyCode)currentTouch;
				GameObject gameObject5 = controllerNavigationObject;
			}
		}
		goto IL_0b7e;
		IL_0cad:
		currentTouch = null;
	}

	private void ProcessPress(bool pressed, float click, float drag)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0444: Expected Obj, but got VT
		//IL_0461: Expected Obj, but got I
		//IL_0477: Invalid comparison between Obj and F4
		//IL_050a: Expected Obj, but got VT
		//IL_0527: Expected Obj, but got I
		//IL_0542: Expected VT, but got Obj
		//IL_056f: Expected Obj, but got VT
		//IL_058c: Expected Obj, but got I
		//IL_0a28: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2d: Expected Obj, but got Unknown
		//IL_06c0: Expected Obj, but got I4
		//IL_06db: Invalid comparison between F4 and Obj
		//IL_06f5: Expected Obj, but got I4
		//IL_0aae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab3: Expected Obj, but got Unknown
		//IL_0747: Expected Obj, but got I4
		//IL_0bfe: Expected Obj, but got I4
		//IL_0cf8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cfd: Expected Obj, but got Unknown
		//IL_0909: Expected Obj, but got VT
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Expected Obj, but got Unknown
		//IL_09bc: Invalid comparison between F4 and Obj
		//IL_0b5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b60: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		if (pressed)
		{
			if (mTooltip != null)
			{
				bool flag = ShowTooltip(null);
			}
			MouseOrTouch mouseOrTouch = currentTouch;
			mouseOrTouch.pressStarted = true;
			if (onPress != null)
			{
				MouseOrTouch mouseOrTouch2 = currentTouch;
				if ((bool)mouseOrTouch2.pressed)
				{
					BoolDelegate boolDelegate = onPress;
					MouseOrTouch mouseOrTouch3 = currentTouch;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v417.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				}
			}
			MouseOrTouch mouseOrTouch4 = currentTouch;
			_ = 0;
			object obj3 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			object obj4 = default;
			Notify(mouseOrTouch4.pressed, "OnPress", obj4);
			MouseOrTouch mouseOrTouch5 = currentTouch;
			MouseOrTouch mouseOrTouch6 = currentTouch;
			mouseOrTouch5.pressed = mouseOrTouch6.current;
			MouseOrTouch mouseOrTouch7 = currentTouch;
			MouseOrTouch mouseOrTouch8 = currentTouch;
			mouseOrTouch7.dragged = mouseOrTouch8.current;
			MouseOrTouch mouseOrTouch9 = currentTouch;
			mouseOrTouch9.clickNotification = ClickNotification.BasedOnDelta;
			MouseOrTouch mouseOrTouch10 = currentTouch;
			mouseOrTouch10.totalDelta = Vector2.zeroVector;
			MouseOrTouch mouseOrTouch11 = currentTouch;
			mouseOrTouch11.dragStarted = false;
			if (onPress != null)
			{
				MouseOrTouch mouseOrTouch12 = currentTouch;
				if ((bool)mouseOrTouch12.pressed)
				{
					BoolDelegate boolDelegate2 = onPress;
					MouseOrTouch mouseOrTouch13 = currentTouch;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v582.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				}
			}
			MouseOrTouch mouseOrTouch14 = currentTouch;
			_ = 1;
			object obj5 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			object obj6 = default;
			Notify(mouseOrTouch14.pressed, "OnPress", obj6);
			if (mTooltip != null)
			{
				bool flag2 = ShowTooltip(null);
			}
			MouseOrTouch mouseOrTouch15 = currentTouch;
			if (!(mSelected != mouseOrTouch15.pressed))
			{
				return;
			}
			mInputFocus = false;
			if ((bool)mSelected)
			{
				_ = 0;
				object obj7 = obj + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
				object obj8 = default;
				Notify(mSelected, "OnSelect", obj8);
				if (onSelect != null)
				{
					BoolDelegate boolDelegate3 = onSelect;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1057.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				}
			}
			MouseOrTouch mouseOrTouch16 = currentTouch;
			mSelected = mouseOrTouch16.pressed;
			MouseOrTouch mouseOrTouch17 = currentTouch;
			if (mouseOrTouch17.pressed != null)
			{
				MouseOrTouch mouseOrTouch18 = currentTouch;
				UIKeyNavigation component = mouseOrTouch18.pressed.GetComponent<UIKeyNavigation>();
				if (component != null)
				{
					MouseOrTouch mouseOrTouch19 = controller;
					MouseOrTouch mouseOrTouch20 = currentTouch;
					mouseOrTouch19.current = mouseOrTouch20.pressed;
				}
			}
			if ((bool)mSelected)
			{
				bool flag3;
				if (mSelected.activeInHierarchy)
				{
					UIInput component2 = mSelected.GetComponent<UIInput>();
					flag3 = component2 != null;
				}
				else
				{
					flag3 = false;
				}
				mInputFocus = flag3;
				if (onSelect != null)
				{
					BoolDelegate boolDelegate4 = onSelect;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1160.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				}
				_ = 1;
				object obj9 = obj + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
				object obj10 = default;
				Notify(mSelected, "OnSelect", obj10);
			}
			return;
		}
		MouseOrTouch mouseOrTouch21 = currentTouch;
		if (!(mouseOrTouch21.pressed != null))
		{
			return;
		}
		MouseOrTouch mouseOrTouch22 = currentTouch;
		object obj11 = mouseOrTouch22.delta * mouseOrTouch22.delta;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ S0_v29 (UICamera+MouseOrTouch)+20]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ S0_v29 (UICamera+MouseOrTouch)+20]");
		object obj12 = num * 0;
		object obj13 = obj11 + obj12;
		if (obj13 == (object)0f)
		{
			MouseOrTouch mouseOrTouch23 = currentTouch;
			MouseOrTouch mouseOrTouch24 = currentTouch;
			if (!(mouseOrTouch23.current != mouseOrTouch24.last))
			{
				return;
			}
		}
		MouseOrTouch mouseOrTouch25 = currentTouch;
		MouseOrTouch mouseOrTouch26 = currentTouch;
		object obj14 = mouseOrTouch25.totalDelta + mouseOrTouch26.delta;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ S0_v43 (UICamera+MouseOrTouch)+28]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ S0_v48 (UICamera+MouseOrTouch)+20]");
		object obj15 = num2 + 0;
		object obj16 = obj15 << 32;
		Vector2 totalDelta = (Vector2)(obj14 | obj16);
		mouseOrTouch25.totalDelta = totalDelta;
		MouseOrTouch mouseOrTouch27 = currentTouch;
		object obj17 = mouseOrTouch27.totalDelta * mouseOrTouch27.totalDelta;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ S0_v54 (UICamera+MouseOrTouch)+28]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ S0_v54 (UICamera+MouseOrTouch)+28]");
		object obj18 = num3 * 0;
		object obj19 = obj17 + obj18;
		MouseOrTouch mouseOrTouch28 = currentTouch;
		object obj20;
		if (!mouseOrTouch28.dragStarted)
		{
			MouseOrTouch mouseOrTouch29 = currentTouch;
			MouseOrTouch mouseOrTouch30 = currentTouch;
			if (mouseOrTouch29.last != mouseOrTouch30.current)
			{
				MouseOrTouch mouseOrTouch31 = currentTouch;
				mouseOrTouch31.dragStarted = true;
				MouseOrTouch mouseOrTouch32 = currentTouch;
				MouseOrTouch mouseOrTouch33 = currentTouch;
				mouseOrTouch32.delta = mouseOrTouch33.totalDelta;
				isDragging = true;
				if (onDragStart != null)
				{
					VoidDelegate voidDelegate = onDragStart;
					MouseOrTouch mouseOrTouch34 = currentTouch;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v562.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				}
				MouseOrTouch mouseOrTouch35 = currentTouch;
				Notify(mouseOrTouch35.dragged, "OnDragStart", null);
				if (onDragOver != null)
				{
					ObjectDelegate objectDelegate = onDragOver;
					MouseOrTouch mouseOrTouch36 = currentTouch;
					MouseOrTouch mouseOrTouch37 = currentTouch;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v651.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				}
				MouseOrTouch mouseOrTouch38 = currentTouch;
				MouseOrTouch mouseOrTouch39 = currentTouch;
				Notify(mouseOrTouch38.last, "OnDragOver", mouseOrTouch39.dragged);
				isDragging = false;
				obj20 = 0;
				goto IL_0c03;
			}
		}
		MouseOrTouch mouseOrTouch40 = currentTouch;
		obj20 = 0;
		if (!mouseOrTouch40.dragStarted)
		{
			bool flag4 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)drag) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj19);
			bool flag5 = !flag4;
			obj20 = 0;
			if (!flag5)
			{
				MouseOrTouch mouseOrTouch41 = currentTouch;
				mouseOrTouch41.dragStarted = true;
				MouseOrTouch mouseOrTouch42 = currentTouch;
				MouseOrTouch mouseOrTouch43 = currentTouch;
				mouseOrTouch42.delta = mouseOrTouch43.totalDelta;
				obj20 = 1;
			}
		}
		goto IL_0c03;
		IL_0c54:
		MouseOrTouch mouseOrTouch44 = currentTouch;
		MouseOrTouch mouseOrTouch45 = currentTouch;
		Notify(mouseOrTouch44.current, "OnDragOver", mouseOrTouch45.dragged);
		goto IL_08b9;
		IL_088f:
		ObjectDelegate objectDelegate2 = onDragOver;
		MouseOrTouch mouseOrTouch46 = currentTouch;
		MouseOrTouch mouseOrTouch47 = currentTouch;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v825.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		goto IL_0c54;
		IL_08b9:
		if (onDrag != null)
		{
			MouseOrTouch mouseOrTouch48 = currentTouch;
			VectorDelegate vectorDelegate = onDrag;
			MouseOrTouch mouseOrTouch49 = currentTouch;
			_ = mouseOrTouch49.delta;
			obj = mouseOrTouch49.delta;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v934.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
		MouseOrTouch mouseOrTouch50 = currentTouch;
		MouseOrTouch mouseOrTouch51 = currentTouch;
		_ = mouseOrTouch51.delta;
		object obj21 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		object obj22 = default;
		Notify(mouseOrTouch50.dragged, "OnDrag", obj22);
		MouseOrTouch mouseOrTouch52 = currentTouch;
		MouseOrTouch mouseOrTouch53 = currentTouch;
		mouseOrTouch52.last = mouseOrTouch53.current;
		isDragging = false;
		MouseOrTouch mouseOrTouch54 = currentTouch;
		MouseOrTouch mouseOrTouch55;
		if (mouseOrTouch55.clickNotification == ClickNotification.None)
		{
			mouseOrTouch54.clickNotification = ClickNotification.None;
		}
		else if (mouseOrTouch54.clickNotification == ClickNotification.BasedOnDelta && System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)click) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj19))
		{
			MouseOrTouch mouseOrTouch56 = currentTouch;
			mouseOrTouch56.clickNotification = ClickNotification.None;
		}
		return;
		IL_0c03:
		MouseOrTouch mouseOrTouch57 = currentTouch;
		if (~(mouseOrTouch57.dragStarted ? 1u : 0u) != 0)
		{
			return;
		}
		if (mTooltip != null)
		{
			bool flag6 = ShowTooltip(null);
		}
		isDragging = true;
		mouseOrTouch55 = currentTouch;
		if (obj20 != null)
		{
			if (onDragStart != null)
			{
				VoidDelegate voidDelegate2 = onDragStart;
				MouseOrTouch mouseOrTouch58 = currentTouch;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v723.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
			MouseOrTouch mouseOrTouch59 = currentTouch;
			Notify(mouseOrTouch59.dragged, "OnDragStart", null);
			if (onDragOver != null)
			{
				goto IL_088f;
			}
		}
		else
		{
			MouseOrTouch mouseOrTouch60 = currentTouch;
			MouseOrTouch mouseOrTouch61 = currentTouch;
			if (!(mouseOrTouch60.last != mouseOrTouch61.current))
			{
				goto IL_08b9;
			}
			if (onDragOut != null)
			{
				ObjectDelegate objectDelegate3 = onDragOut;
				MouseOrTouch mouseOrTouch62 = currentTouch;
				MouseOrTouch mouseOrTouch63 = currentTouch;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v905.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
			MouseOrTouch mouseOrTouch64 = currentTouch;
			MouseOrTouch mouseOrTouch65 = currentTouch;
			Notify(mouseOrTouch64.last, "OnDragOut", mouseOrTouch65.dragged);
			if (onDragOver != null)
			{
				goto IL_088f;
			}
		}
		goto IL_0c54;
	}

	private void ProcessRelease(bool isMouse, float drag)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_05c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c7: Expected Obj, but got Unknown
		//IL_02f6: Expected Obj, but got VT
		//IL_0313: Expected Obj, but got I
		//IL_0328: Invalid comparison between F4 and Obj
		//IL_0605: Unknown result type (might be due to invalid IL or missing references)
		//IL_060a: Expected Obj, but got Unknown
		object obj = default;
		UICamera uICamera = (UICamera)(obj - 16);
		if (currentTouch == null)
		{
			return;
		}
		MouseOrTouch mouseOrTouch = currentTouch;
		mouseOrTouch.pressStarted = false;
		MouseOrTouch mouseOrTouch2 = currentTouch;
		if (mouseOrTouch2.pressed != null)
		{
			MouseOrTouch mouseOrTouch3 = currentTouch;
			if (~(mouseOrTouch3.dragStarted ? 1u : 0u) == 0)
			{
				if (onDragOut != null)
				{
					ObjectDelegate objectDelegate = onDragOut;
					MouseOrTouch mouseOrTouch4 = currentTouch;
					MouseOrTouch mouseOrTouch5 = currentTouch;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v224.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				}
				MouseOrTouch mouseOrTouch6 = currentTouch;
				MouseOrTouch mouseOrTouch7 = currentTouch;
				Notify(mouseOrTouch6.last, "OnDragOut", mouseOrTouch7.dragged);
				if (onDragEnd != null)
				{
					VoidDelegate voidDelegate = onDragEnd;
					MouseOrTouch mouseOrTouch8 = currentTouch;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v300.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				}
				MouseOrTouch mouseOrTouch9 = currentTouch;
				Notify(mouseOrTouch9.dragged, "OnDragEnd", null);
			}
			if (onPress != null)
			{
				BoolDelegate boolDelegate = onPress;
				MouseOrTouch mouseOrTouch10 = currentTouch;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v251.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
			MouseOrTouch mouseOrTouch11 = currentTouch;
			_ = 0;
			object obj2 = uICamera + 15;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			object obj3 = default;
			Notify(mouseOrTouch11.pressed, "OnPress", obj3);
			if (isMouse)
			{
				MouseOrTouch mouseOrTouch12 = currentTouch;
				if (uICamera.HasCollider(mouseOrTouch12.pressed))
				{
					MouseOrTouch mouseOrTouch13 = currentTouch;
					if (mHover == mouseOrTouch13.current)
					{
						if (onHover != null)
						{
							BoolDelegate boolDelegate2 = onHover;
							MouseOrTouch mouseOrTouch14 = currentTouch;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v469.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
						}
						MouseOrTouch mouseOrTouch15 = currentTouch;
						_ = 1;
						object obj4 = uICamera + 14;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
						object obj5 = default;
						Notify(mouseOrTouch15.current, "OnHover", obj5);
					}
					else
					{
						MouseOrTouch mouseOrTouch16 = currentTouch;
						hoveredObject = mouseOrTouch16.current;
					}
				}
			}
			MouseOrTouch mouseOrTouch17 = currentTouch;
			MouseOrTouch mouseOrTouch18 = currentTouch;
			if (mouseOrTouch17.dragged == mouseOrTouch18.current)
			{
				goto IL_0347;
			}
			ControlScheme controlScheme = currentScheme;
			if (controlScheme != ControlScheme.Controller)
			{
				MouseOrTouch mouseOrTouch19 = currentTouch;
				if (mouseOrTouch19.clickNotification != ClickNotification.None)
				{
					MouseOrTouch mouseOrTouch20 = currentTouch;
					object obj6 = mouseOrTouch20.totalDelta * mouseOrTouch20.totalDelta;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ S0_v223 (UICamera+MouseOrTouch)+28]");
					nint num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ S0_v223 (UICamera+MouseOrTouch)+28]");
					object obj7 = num * 0;
					object obj8 = obj6 + obj7;
					if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)drag) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8))
					{
						goto IL_0347;
					}
				}
			}
			MouseOrTouch mouseOrTouch21 = currentTouch;
			if (~(mouseOrTouch21.dragStarted ? 1u : 0u) == 0)
			{
				if (onDrop != null)
				{
					ObjectDelegate objectDelegate2 = onDrop;
					MouseOrTouch mouseOrTouch22 = currentTouch;
					MouseOrTouch mouseOrTouch23 = currentTouch;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v529.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				}
				MouseOrTouch mouseOrTouch24 = currentTouch;
				MouseOrTouch mouseOrTouch25 = currentTouch;
				Notify(mouseOrTouch24.current, "OnDrop", mouseOrTouch25.dragged);
			}
		}
		goto IL_04db;
		IL_04db:
		MouseOrTouch mouseOrTouch26 = currentTouch;
		mouseOrTouch26.dragStarted = false;
		MouseOrTouch mouseOrTouch27 = currentTouch;
		mouseOrTouch27.pressed = null;
		MouseOrTouch mouseOrTouch28 = currentTouch;
		mouseOrTouch28.dragged = null;
		return;
		IL_0347:
		MouseOrTouch mouseOrTouch29 = currentTouch;
		if (mouseOrTouch29.clickNotification != ClickNotification.None)
		{
			MouseOrTouch mouseOrTouch30 = currentTouch;
			MouseOrTouch mouseOrTouch31 = currentTouch;
			if (mouseOrTouch30.pressed == mouseOrTouch31.current)
			{
				bool flag = ShowTooltip(null);
				float unscaledTime = Time.unscaledTime;
				if (onClick != null)
				{
					VoidDelegate voidDelegate2 = onClick;
					MouseOrTouch mouseOrTouch32 = currentTouch;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v575.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				}
				MouseOrTouch mouseOrTouch33 = currentTouch;
				Notify(mouseOrTouch33.pressed, "OnClick", null);
				MouseOrTouch mouseOrTouch34 = currentTouch;
				float num2 = mouseOrTouch34.clickTime + 0.35f;
				if (unscaledTime < num2)
				{
					if (onDoubleClick != null)
					{
						VoidDelegate voidDelegate3 = onDoubleClick;
						MouseOrTouch mouseOrTouch35 = currentTouch;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v638.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
					}
					MouseOrTouch mouseOrTouch36 = currentTouch;
					Notify(mouseOrTouch36.pressed, "OnDoubleClick", null);
				}
				MouseOrTouch mouseOrTouch37 = currentTouch;
				mouseOrTouch37.clickTime = unscaledTime;
			}
		}
		goto IL_04db;
	}

	private bool HasCollider(GameObject go)
	{
		bool flag = go != null;
		bool result = false;
		if (flag)
		{
			Collider component = go.GetComponent<Collider>();
			if (component != null)
			{
				return component.enabled;
			}
			Collider2D component2 = go.GetComponent<Collider2D>();
			bool flag2 = component2 != null;
			bool flag3 = !flag2;
			result = false;
			if (!flag3)
			{
				bool flag4 = component2.enabled;
				result = flag4;
			}
		}
		return result;
	}

	public void ProcessTouch(bool pressed, bool released)
	{
		//IL_0300: Expected Obj, but got I4
		//IL_02e0: Expected Obj, but got I4
		//IL_003b: Expected Obj, but got I4
		//IL_0049: Expected Obj, but got I4
		if (pressed)
		{
			float unscaledTime = Time.unscaledTime;
			float num = unscaledTime + tooltipDelay;
			mTooltipTime = num;
		}
		ControlScheme controlScheme = currentScheme;
		object obj = 52;
		if (controlScheme == ControlScheme.Mouse)
		{
			obj = 44;
		}
		object obj2 = (object)this + obj;
		object obj3 = 48;
		if (controlScheme == ControlScheme.Mouse)
		{
			obj3 = 40;
		}
		object obj4 = (object)this + obj3;
		float drag = (float)obj4 * (float)obj4;
		float click = (float)obj2 * (float)obj2;
		MouseOrTouch mouseOrTouch = currentTouch;
		if (mouseOrTouch.pressed != null)
		{
			if (released)
			{
				bool isMouse = controlScheme == ControlScheme.Mouse;
				ProcessRelease(isMouse, drag);
			}
			ProcessPress(pressed, click, drag);
			MouseOrTouch mouseOrTouch2 = currentTouch;
			MouseOrTouch mouseOrTouch3 = currentTouch;
			if (!(mouseOrTouch2.pressed == mouseOrTouch3.current) || mTooltipTime == 0f)
			{
				return;
			}
			MouseOrTouch mouseOrTouch4 = currentTouch;
			if (mouseOrTouch4.clickNotification == ClickNotification.None)
			{
				return;
			}
			MouseOrTouch mouseOrTouch5 = currentTouch;
			if (mouseOrTouch5.dragStarted)
			{
				return;
			}
			float deltaTime = currentTouch.deltaTime;
			if (deltaTime > tooltipDelay)
			{
				mTooltipTime = 0f;
				MouseOrTouch mouseOrTouch6 = currentTouch;
				mouseOrTouch6.clickNotification = ClickNotification.None;
				if (~(longPressTooltip ? 1u : 0u) == 0)
				{
					MouseOrTouch mouseOrTouch7 = currentTouch;
					bool flag = ShowTooltip(mouseOrTouch7.pressed);
				}
				MouseOrTouch mouseOrTouch8 = currentTouch;
				Notify(mouseOrTouch8.current, "OnLongPress", null);
			}
		}
		else if (controlScheme == ControlScheme.Mouse || pressed || released)
		{
			ProcessPress(pressed, click, drag);
			if (released)
			{
				bool isMouse2 = controlScheme == ControlScheme.Mouse;
				ProcessRelease(isMouse2, drag);
			}
		}
	}

	public static bool ShowTooltip(GameObject go)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected Obj, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		bool flag = mTooltip != go;
		if (flag)
		{
			if (mTooltip != null)
			{
				if (onTooltip != null)
				{
					BoolDelegate boolDelegate = onTooltip;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v144.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				}
				_ = 0;
				object obj3 = obj + 15;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
				object obj4 = default;
				Notify(mTooltip, "OnTooltip", obj4);
			}
			mTooltip = go;
			mTooltipTime = 0f;
			if (mTooltip != null)
			{
				if (onTooltip != null)
				{
					BoolDelegate boolDelegate2 = onTooltip;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v188.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				}
				_ = 1;
				object obj5 = obj + 14;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
				object obj6 = default;
				Notify(mTooltip, "OnTooltip", obj6);
			}
		}
		return flag;
	}

	public static bool HideTooltip()
	{
		return ShowTooltip(null);
	}

	public UICamera()
	{
		//IL_0026: Expected VT, but got I4
		//IL_008d: Expected I4, but got I8
		//IL_009c: Expected I4, but got I8
	}

	unsafe static UICamera()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_02c1: Expected I, but got Obj
		//IL_02f2: Expected I, but got Obj
		//IL_0320: Expected VT, but got I
		object obj = default;
		Vector3 vector = (Vector3)(obj - 48);
		BetterList<UICamera> betterList = default;
		list = betterList;
		GetKeyStateFunc getKeyStateFunc = default;
		getKeyStateFunc._002Ector(null, (nint)(delegate*<KeyCode, bool>)(&Input.GetKeyDown));
		GetKeyDown = getKeyStateFunc;
		GetKeyStateFunc getKeyStateFunc2 = default;
		getKeyStateFunc2._002Ector(null, (nint)(delegate*<KeyCode, bool>)(&Input.GetKeyUp));
		GetKeyUp = getKeyStateFunc2;
		GetKeyStateFunc getKeyStateFunc3 = default;
		getKeyStateFunc3._002Ector(null, (nint)(delegate*<KeyCode, bool>)(&Input.GetKey));
		GetKey = getKeyStateFunc3;
		GetAxisFunc getAxisFunc = default;
		getAxisFunc._002Ector(null, (nint)(delegate*<string, float>)(&Input.GetAxis));
		GetAxis = getAxisFunc;
		showTooltips = true;
		mDisableController = false;
		mLastPos = Vector2.zeroVector;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S1_v21 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S1_v22 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		_ = Vector3.zeroVector;
		nint num3 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S0_v74 (Il2CppClass<UICamera>)+5C]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
		lastWorldPosition = (Vector3)0;
		current = null;
		currentCamera = null;
		currentTouchID = -100;
		mCurrentKey = KeyCode.Alpha0;
		currentTouch = null;
		mInputFocus = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		_ = 1;
		_ = 1;
		throw new ArrayTypeMismatchException();
	}
}
