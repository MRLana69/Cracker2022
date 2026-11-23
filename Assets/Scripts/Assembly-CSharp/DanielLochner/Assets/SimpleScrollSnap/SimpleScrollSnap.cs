using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

namespace DanielLochner.Assets.SimpleScrollSnap;

public class SimpleScrollSnap : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler, IDragHandler, IPointerDownHandler, IPointerUpHandler
{
	public enum MovementType
	{
		Fixed,
		Free
	}

	public enum MovementAxis
	{
		Horizontal,
		Vertical
	}

	public enum Direction
	{
		Up,
		Down,
		Left,
		Right
	}

	public enum SnapTarget
	{
		Nearest,
		Previous,
		Next
	}

	public enum SizeControl
	{
		Manual,
		Fit
	}

	[Serializable]
	public class TransitionEffect
	{
		protected float minDisplacement;

		protected float maxDisplacement;

		protected float minValue;

		protected float maxValue;

		protected float defaultMinValue;

		protected float defaultMaxValue;

		protected float defaultMinDisplacement;

		protected float defaultMaxDisplacement;

		protected bool showPanel;

		protected bool showDisplacement;

		protected bool showValue;

		private string label;

		private AnimationCurve function;

		private AnimationCurve defaultFunction;

		private SimpleScrollSnap simpleScrollSnap;

		public string Label
		{
			get
			{
				return label;
			}
			set
			{
				label = value;
			}
		}

		public float MinValue
		{
			get
			{
				return 0f;
			}
			set
			{
				minValue = value;
			}
		}

		public float MaxValue
		{
			get
			{
				return maxValue;
			}
			set
			{
				maxValue = value;
			}
		}

		public float MinDisplacement
		{
			get
			{
				return minDisplacement;
			}
			set
			{
				minDisplacement = value;
			}
		}

		public float MaxDisplacement
		{
			get
			{
				return maxDisplacement;
			}
			set
			{
				maxDisplacement = value;
			}
		}

		public AnimationCurve Function
		{
			get
			{
				return function;
			}
			set
			{
				function = value;
			}
		}

		public TransitionEffect(string label, float minValue, float maxValue, float minDisplacement, float maxDisplacement, AnimationCurve function, SimpleScrollSnap simpleScrollSnap)
		{
			this.label = label;
			this.simpleScrollSnap = simpleScrollSnap;
			this.maxValue = maxValue;
			this.minValue = minValue;
			this.function = function;
			this.maxDisplacement = maxDisplacement;
			this.minDisplacement = minDisplacement;
			defaultFunction = function;
			defaultMaxDisplacement = maxDisplacement;
			defaultMinDisplacement = minDisplacement;
			defaultMaxValue = maxValue;
			defaultMinValue = minValue;
		}

		private void SetDefaultValues(float minValue, float maxValue, float minDisplacement, float maxDisplacement, AnimationCurve function)
		{
			defaultFunction = function;
			defaultMaxDisplacement = maxDisplacement;
			defaultMinDisplacement = minDisplacement;
			defaultMaxValue = maxValue;
			defaultMinValue = minValue;
		}

		public void Reset()
		{
			minValue = defaultMinValue;
			minDisplacement = defaultMinDisplacement;
			function = defaultFunction;
		}

		public float GetValue(float displacement)
		{
			if (function == null)
			{
				return 0f;
			}
			return function.Evaluate(displacement);
		}
	}

	public MovementType movementType;

	public MovementAxis movementAxis;

	public bool automaticallyLayout = true;

	public SizeControl sizeControl = SizeControl.Fit;

	public Vector2 size;

	public float automaticLayoutSpacing;

	public float leftMargin;

	public float rightMargin;

	public float topMargin;

	public float bottomMargin;

	public bool infinitelyScroll;

	public float infiniteScrollingEndSpacing;

	public bool useOcclusionCulling;

	public int startingPanel;

	public bool swipeGestures = true;

	public float minimumSwipeSpeed;

	public Button previousButton;

	public Button nextButton;

	public GameObject pagination;

	public bool toggleNavigation = true;

	public SnapTarget snapTarget = SnapTarget.Next;

	public float snappingSpeed = 10f;

	public float thresholdSnappingSpeed;

	public bool hardSnap = true;

	public bool useUnscaledTime;

	public UnityEvent onPanelChanged;

	public UnityEvent onPanelSelecting;

	public UnityEvent onPanelSelected;

	public UnityEvent onPanelChanging;

	public List<TransitionEffect> transitionEffects;

	private bool dragging;

	private bool selected;

	private bool pressing;

	private float releaseSpeed;

	private float contentLength;

	private Direction releaseDirection;

	private Canvas canvas;

	private RectTransform canvasRectTransform;

	private CanvasScaler canvasScaler;

	private ScrollRect scrollRect;

	private Vector2 previousContentAnchoredPosition;

	private Vector2 velocity;

	private Dictionary<int, Graphic[]> panelGraphics;

	private int CurrentPanel__BackingField;

	private int TargetPanel__BackingField;

	private int NearestPanel__BackingField;

	private RectTransform[] PanelsRT__BackingField;

	private GameObject[] Panels__BackingField;

	private Toggle[] Toggles__BackingField;

	public RectTransform Content
	{
		get
		{
			ScrollRect scrollRect = this.scrollRect;
			return scrollRect.m_Content;
		}
	}

	public RectTransform Viewport
	{
		get
		{
			ScrollRect scrollRect = this.scrollRect;
			return scrollRect.m_Viewport;
		}
	}

	public int CurrentPanel
	{
		get
		{
			return CurrentPanel__BackingField;
		}
		set
		{
			CurrentPanel__BackingField = value;
		}
	}

	public int TargetPanel
	{
		get
		{
			return TargetPanel__BackingField;
		}
		set
		{
			TargetPanel__BackingField = value;
		}
	}

	public int NearestPanel
	{
		get
		{
			return NearestPanel__BackingField;
		}
		set
		{
			NearestPanel__BackingField = value;
		}
	}

	private RectTransform[] PanelsRT
	{
		get
		{
			return PanelsRT__BackingField;
		}
		set
		{
			PanelsRT__BackingField = value;
		}
	}

	public GameObject[] Panels
	{
		get
		{
			return Panels__BackingField;
		}
		set
		{
			Panels__BackingField = value;
		}
	}

	public Toggle[] Toggles
	{
		get
		{
			return Toggles__BackingField;
		}
		set
		{
			Toggles__BackingField = value;
		}
	}

	public int NumberOfPanels
	{
		get
		{
			ScrollRect scrollRect = this.scrollRect;
			return scrollRect.m_Content.childCount;
		}
	}

	private void Awake()
	{
		Initialize();
	}

	public void OnEnable()
	{
		Setup();
	}

	private void Start()
	{
		if (Validate())
		{
			Setup();
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Exception ex = default;
		ex._002Ector("Invalid configuration.");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
	}

	private void OnDestroy()
	{
	}

	private void EventsConfig_PreButtonEvent()
	{
		GoToPreviousPanel();
	}

	private void EventsConfig_NextButtonEvent()
	{
		GoToNextPanel();
	}

	private void Update()
	{
		if (NumberOfPanels != 0)
		{
			OnOcclusionCulling();
			OnSelectingAndSnapping();
			OnInfiniteScrolling();
			OnTransitionEffects();
			OnSwipeGestures();
			DetermineVelocity();
		}
	}

	public void OnPointerDown(PointerEventData eventData)
	{
		pressing = true;
	}

	public void OnPointerUp(PointerEventData eventData)
	{
		pressing = false;
	}

	public void OnBeginDrag(PointerEventData eventData)
	{
		if (~(hardSnap ? 1u : 0u) == 0)
		{
			ScrollRect scrollRect = this.scrollRect;
			scrollRect.m_Inertia = true;
		}
		dragging = true;
	}

	public void OnDrag(PointerEventData eventData)
	{
		if (~(dragging ? 1u : 0u) == 0)
		{
			onPanelSelecting.Invoke();
		}
	}

	public void OnEndDrag(PointerEventData eventData)
	{
		//IL_0075: Invalid comparison between VT and F4
		//IL_00bb: Invalid comparison between I and F4
		//IL_0116: Expected Obj, but got VT
		//IL_0129: Expected Obj, but got VT
		dragging = false;
		ScrollRect scrollRect;
		if (movementAxis != MovementAxis.Horizontal)
		{
			if (movementAxis != MovementAxis.Vertical)
			{
				scrollRect = this.scrollRect;
			}
			else
			{
				ScrollRect scrollRect2 = this.scrollRect;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v12 (UnityEngine.UI.ScrollRect)+90]");
				bool flag = 0f > 0f;
				bool flag2 = !flag;
				releaseDirection = (flag2 ? Direction.Down : Direction.Up);
				scrollRect = scrollRect2;
			}
		}
		else
		{
			ScrollRect scrollRect3 = this.scrollRect;
			bool flag3 = scrollRect3.m_Velocity > (object)0f;
			Direction direction = Direction.Right;
			if (!flag3)
			{
				direction = Direction.Left;
			}
			releaseDirection = direction;
			scrollRect = scrollRect3;
		}
		object obj = scrollRect.m_Velocity * scrollRect.m_Velocity;
		object obj2 = scrollRect.m_Velocity >> 32;
		object obj3 = obj2 * obj2;
		float num = (float)obj + (float)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Sqrt not resolved\"");
		releaseSpeed = num;
	}

	private void Initialize()
	{
		//IL_00c4: Expected Obj, but got I
		ScrollRect component = GetComponent<ScrollRect>();
		this.scrollRect = component;
		Canvas componentInParent = GetComponentInParent<Canvas>();
		canvas = componentInParent;
		if (canvas != null)
		{
			CanvasScaler componentInParent2 = canvas.GetComponentInParent<CanvasScaler>();
			canvasScaler = componentInParent2;
			RectTransform component2 = canvas.GetComponent<RectTransform>();
			canvasRectTransform = component2;
		}
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v67 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Int32, UnityEngine.UI.Graphic[]>>>)+4] (should have been resolved before IL gen)");
		Dictionary<int, Graphic[]> dictionary = default;
		panelGraphics = dictionary;
		int num3 = 0;
		while (true)
		{
			ScrollRect scrollRect = this.scrollRect;
			int childCount = scrollRect.m_Content.childCount;
			if (childCount > num3)
			{
				ScrollRect scrollRect2 = this.scrollRect;
				Transform child = scrollRect2.m_Content.GetChild(num3);
				nint num4 = 0;
				nint num5 = 0;
				IntPtr intPtr2 = num5;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v119 @ S5_v4 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.Component::GetComponentsInChildren>>)+4] (should have been resolved before IL gen)");
				nint num6 = 0;
				nint num7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S5_v8 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Int32, UnityEngine.UI.Graphic[]>>)+5C]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v128 @ S5_v9+4] (should have been resolved before IL gen)");
				int num8 = num3 + 1;
				num3 = num8;
				continue;
			}
			break;
		}
	}

	private bool Validate()
	{
		bool flag = pagination != null;
		bool flag2 = !flag;
		bool flag3 = true;
		if (!flag2)
		{
			Transform transform = pagination.transform;
			int childCount = transform.childCount;
			int numberOfPanels = NumberOfPanels;
			bool flag4 = childCount == numberOfPanels;
			flag3 = flag4;
		}
		bool flag5 = snappingSpeed < 0f;
		bool flag6 = !flag5;
		return flag3 & flag6;
	}

	private unsafe void Setup()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0146: Expected Obj, but got I
		//IL_0ca8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cad: Expected VT, but got Unknown
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected Obj, but got Unknown
		//IL_0172: Expected F4, but got VT
		//IL_00e1: Expected VT, but got I
		//IL_0127: Expected Obj, but got I
		//IL_0451: Expected Obj, but got I4
		//IL_0dbf: Expected Obj, but got I4
		//IL_06fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0700: Expected Obj, but got Unknown
		//IL_0710: Expected Obj, but got I
		//IL_125c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1261: Expected VT, but got Unknown
		//IL_1286: Expected Obj, but got I4
		//IL_046a: Expected Obj, but got I4
		//IL_06bc: Expected Obj, but got I
		//IL_0dec: Expected Obj, but got I4
		//IL_0478: Expected Obj, but got I4
		//IL_089e: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a3: Expected Obj, but got Unknown
		//IL_08b4: Expected Obj, but got I
		//IL_08ce: Expected Obj, but got I
		//IL_08f3: Expected Obj, but got I
		//IL_0910: Expected Obj, but got F4
		//IL_0918: Unknown result type (might be due to invalid IL or missing references)
		//IL_091d: Expected VT, but got Unknown
		//IL_0930: Unknown result type (might be due to invalid IL or missing references)
		//IL_0935: Expected VT, but got Unknown
		//IL_12b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_12b6: Expected VT, but got Unknown
		//IL_12db: Expected Obj, but got I4
		//IL_0486: Expected Obj, but got I4
		//IL_0e19: Expected Obj, but got I4
		//IL_0494: Expected Obj, but got I4
		//IL_1306: Unknown result type (might be due to invalid IL or missing references)
		//IL_130b: Expected VT, but got Unknown
		//IL_04a2: Expected Obj, but got I4
		//IL_04c3: Expected Obj, but got I4
		//IL_04f1: Expected Obj, but got I
		//IL_04b0: Expected Obj, but got I4
		//IL_0aa8: Expected Obj, but got I4
		//IL_051e: Expected F4, but got VT
		//IL_0e7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e81: Expected VT, but got Unknown
		//IL_05b2: Expected F4, but got I
		//IL_0ada: Expected Obj, but got I
		//IL_0c2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c32: Expected Obj, but got Unknown
		//IL_0b40: Expected Obj, but got I
		//IL_0b8a: Expected Obj, but got I
		//IL_0bbc: Expected Obj, but got I
		//IL_0bcd: Expected Obj, but got I
		//IL_0bff: Expected Obj, but got I
		object obj = default;
		Vector2 vector = (Vector2)(obj - 192);
		_ = 0;
		_ = 0;
		if (NumberOfPanels == 0)
		{
			return;
		}
		ScrollRect scrollRect = this.scrollRect;
		if (movementType == MovementType.Fixed)
		{
			bool vertical = this.movementAxis == MovementAxis.Vertical;
			scrollRect.m_Vertical = vertical;
			bool horizontal = this.movementAxis == MovementAxis.Horizontal;
			scrollRect.m_Horizontal = horizontal;
		}
		else
		{
			scrollRect.m_Horizontal = true;
		}
		Vector2 vector2;
		object obj2;
		if (sizeControl != SizeControl.Manual)
		{
			RectTransform component = GetComponent<RectTransform>();
			Rect rect = component.rect;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+A8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+A0]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+B8]");
			vector2 = (Vector2)0;
			RectTransform component2 = GetComponent<RectTransform>();
			Rect rect2 = component2.rect;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+A8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+A0]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+BC]");
			obj2 = 0;
		}
		else
		{
			vector2 = size;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (DanielLochner.Assets.SimpleScrollSnap.SimpleScrollSnap)+20]");
			obj2 = 0;
		}
		object obj3 = obj2 << 32;
		Vector2 vector3 = (Vector2)(vector2 | obj3);
		size = vector3;
		int numberOfPanels = NumberOfPanels;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		GameObject[] array = default;
		Panels__BackingField = array;
		int numberOfPanels2 = NumberOfPanels;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		RectTransform[] array2 = default;
		PanelsRT__BackingField = array2;
		object obj4 = this + 32;
		float num = (float)vector2;
		int num2 = 0;
		int numberOfPanels3 = NumberOfPanels;
		if (numberOfPanels3 > num2)
		{
			ScrollRect scrollRect2 = this.scrollRect;
			Transform child = scrollRect2.m_Content.GetChild(num2);
			GameObject gameObject = child.gameObject;
			throw new ArrayTypeMismatchException();
		}
		if (movementType == MovementType.Fixed)
		{
			if (~(automaticallyLayout ? 1u : 0u) == 0)
			{
				ScrollRect scrollRect3 = this.scrollRect;
				object obj5 = 1056964608;
				if (this.movementAxis == MovementAxis.Horizontal)
				{
					obj5 = 0;
				}
				bool flag = this.movementAxis == MovementAxis.Vertical;
				object obj6 = 0;
				if (!flag)
				{
					obj6 = 1056964608;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+70]");
				_ = 0;
				Vector2 anchorMin = vector + 72;
				scrollRect3.m_Content.anchorMin = anchorMin;
				ScrollRect scrollRect4 = this.scrollRect;
				object obj7 = 1056964608;
				if (this.movementAxis == MovementAxis.Horizontal)
				{
					obj7 = 0;
				}
				bool flag2 = this.movementAxis == MovementAxis.Vertical;
				object obj8 = 0;
				if (!flag2)
				{
					obj8 = 1056964608;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+68]");
				_ = 0;
				Vector2 anchorMax = vector - -64;
				scrollRect4.m_Content.anchorMax = anchorMax;
				ScrollRect scrollRect5 = this.scrollRect;
				object obj9 = 1056964608;
				if (this.movementAxis == MovementAxis.Horizontal)
				{
					obj9 = 0;
				}
				bool flag3 = this.movementAxis == MovementAxis.Vertical;
				object obj10 = 0;
				if (!flag3)
				{
					obj10 = 1056964608;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+60]");
				_ = 0;
				Vector2 pivot = vector + 56;
				scrollRect5.m_Content.pivot = pivot;
				RectTransform[] array3 = PanelsRT__BackingField;
				Vector2 anchoredPosition = array3[0].anchoredPosition;
				int numberOfPanels4 = NumberOfPanels;
				object obj11 = numberOfPanels4 - 1;
				object obj12 = obj11 << 2;
				object obj13 = (object)PanelsRT__BackingField + obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v799 @ S1_v173+10]");
				Vector2 anchoredPosition2 = ((RectTransform)0).anchoredPosition;
				MovementAxis movementAxis;
				if (this.movementAxis != MovementAxis.Horizontal)
				{
					float num3 = (float)size;
					movementAxis = this.movementAxis;
				}
				else
				{
					int numberOfPanels5 = NumberOfPanels;
					float num4 = automaticLayoutSpacing + 1f;
					float num5 = (float)numberOfPanels5 * num4;
					float num6 = num5 * (float)size;
					float num7 = (float)size * automaticLayoutSpacing;
					float num8 = num6 - num7;
					float num3 = num8;
					movementAxis = this.movementAxis;
				}
				if (movementAxis != MovementAxis.Vertical)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (DanielLochner.Assets.SimpleScrollSnap.SimpleScrollSnap)+20]");
					float num9 = 0f;
				}
				else
				{
					int numberOfPanels6 = NumberOfPanels;
					float num10 = automaticLayoutSpacing + 1f;
					float num11 = (float)numberOfPanels6 * num10;
					float num12 = num11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (DanielLochner.Assets.SimpleScrollSnap.SimpleScrollSnap)+20]");
					float num13 = num12 * 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (DanielLochner.Assets.SimpleScrollSnap.SimpleScrollSnap)+20]");
					float num14 = 0f * automaticLayoutSpacing;
					float num9 = num13 - num14;
				}
				ScrollRect scrollRect6 = this.scrollRect;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+58]");
				_ = 0;
				Vector2 sizeDelta = vector + 48;
				scrollRect6.m_Content.sizeDelta = sizeDelta;
			}
			if (~(infinitelyScroll ? 1u : 0u) == 0)
			{
				ScrollRect scrollRect7 = this.scrollRect;
				scrollRect7.m_MovementType = ScrollRect.MovementType.Unrestricted;
				ScrollRect scrollRect8 = this.scrollRect;
				object obj14;
				object obj15;
				if (this.movementAxis != MovementAxis.Horizontal)
				{
					Rect rect3 = scrollRect8.m_Content.rect;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+A8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+A0]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+BC]");
					obj14 = 0;
					obj15 = obj4;
				}
				else
				{
					Rect rect4 = scrollRect8.m_Content.rect;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+A8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+A0]");
					_ = 0;
					object obj16 = this + 28;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+B8]");
					obj14 = 0;
					obj15 = obj16;
				}
				float num15 = (float)obj15 * infiniteScrollingEndSpacing;
				float num16 = (float)obj14 + num15;
				contentLength = num16;
				OnInfiniteScrolling(forceUpdate: true);
			}
			if (~(useOcclusionCulling ? 1u : 0u) == 0)
			{
				OnOcclusionCulling(forceUpdate: true);
			}
		}
		else
		{
			infinitelyScroll = false;
			useOcclusionCulling = false;
			automaticallyLayout = false;
		}
		MovementAxis movementAxis2;
		float num17;
		if (this.movementAxis != MovementAxis.Horizontal)
		{
			bool flag4 = movementType != MovementType.Free;
			movementAxis2 = this.movementAxis;
			num17 = 0f;
			if (flag4)
			{
				goto IL_0ef2;
			}
		}
		ScrollRect scrollRect9 = this.scrollRect;
		Rect rect5 = scrollRect9.m_Viewport.rect;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+A8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+A0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+B8]");
		num17 = 0f * 0.5f;
		movementAxis2 = this.movementAxis;
		goto IL_0ef2;
		IL_0ef2:
		float num18;
		if (movementAxis2 != MovementAxis.Vertical)
		{
			bool flag5 = movementType != MovementType.Free;
			num18 = 0f;
			if (flag5)
			{
				goto IL_0f1d;
			}
		}
		ScrollRect scrollRect10 = this.scrollRect;
		Rect rect6 = scrollRect10.m_Viewport.rect;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+A8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+A0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+BC]");
		num18 = 0f * 0.5f;
		goto IL_0f1d;
		IL_0f1d:
		RectTransform[] array4 = PanelsRT__BackingField;
		if (array4.Length > TargetPanel__BackingField)
		{
			ScrollRect scrollRect11 = this.scrollRect;
			int num19 = startingPanel << 2;
			object obj17 = array4 + num19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v565 @ S1_v74+10]");
			Vector2 anchoredPosition3 = ((RectTransform)0).anchoredPosition;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+A0]");
			object obj18 = (nint)0 ^ (nint)int.MinValue;
			float num20 = (float)obj18 + num17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+A4]");
			object obj19 = (nint)0 ^ (nint)int.MinValue;
			float num21 = (float)obj19 + num18;
			object obj20 = num21 << 32;
			Vector2 vector4 = (Vector2)(num20 | obj20);
			Vector2 anchoredPosition4 = vector + 40;
			scrollRect11.m_Content.anchoredPosition = anchoredPosition4;
			previousContentAnchoredPosition = vector4;
			NearestPanel__BackingField = startingPanel;
			TargetPanel__BackingField = startingPanel;
			CurrentPanel__BackingField = startingPanel;
		}
		if (previousButton != null)
		{
			Button button = previousButton;
			button.m_OnClick.RemoveAllListeners();
			Button button2 = previousButton;
			UnityAction unityAction = default;
			unityAction._002Ector(this, (nint)__ldftn(SimpleScrollSnap.GoToPreviousPanel));
			button2.m_OnClick.AddListener(unityAction);
		}
		if (nextButton != null)
		{
			Button button3 = nextButton;
			button3.m_OnClick.RemoveAllListeners();
			Button button4 = nextButton;
			UnityAction unityAction2 = default;
			unityAction2._002Ector(this, (nint)__ldftn(SimpleScrollSnap.GoToNextPanel));
			button4.m_OnClick.AddListener(unityAction2);
		}
		if (!(pagination != null))
		{
			return;
		}
		nint num22 = 0;
		nint num23 = 0;
		IntPtr intPtr = num23;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v934 @ S4_v6 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.GameObject::GetComponentsInChildren>>)+4] (should have been resolved before IL gen)");
		Toggle[] array5 = default;
		Toggles__BackingField = array5;
		object obj21 = 0;
		while (true)
		{
			Toggle[] array6 = Toggles__BackingField;
			if ((nint)obj21 < array6.Length)
			{
				object obj22 = obj21 << 2;
				object obj23 = (object)array6 + obj22;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1028 @ S0_v77+10]");
				if ((UnityEngine.Object)0 != null)
				{
					object obj24 = obj21 << 2;
					object obj25 = (object)Toggles__BackingField + obj24;
					bool isOn = (nint)obj21 == startingPanel;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1055 @ S0_v91+10]");
					((Toggle)0).isOn = isOn;
					object obj26 = obj21 << 2;
					object obj27 = (object)Toggles__BackingField + obj26;
					bool interactable = (nint)obj21 != TargetPanel__BackingField;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1067 @ S0_v95+10]");
					((Selectable)0).interactable = interactable;
					object obj28 = obj21 << 2;
					object obj29 = (object)Toggles__BackingField + obj28;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1081 @ S0_v100+10]");
					object obj30 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1082 @ S0_v101+BC]");
					((UnityEventBase)0).RemoveAllListeners();
					object obj31 = obj21 << 2;
					object obj32 = (object)Toggles__BackingField + obj31;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1090 @ S0_v105+10]");
					object obj33 = 0;
					throw new ArgumentException();
				}
				object obj34 = obj21 + 1;
				obj21 = obj34;
				continue;
			}
			break;
		}
	}

	private unsafe Vector2 DisplacementFromCenter(int index)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected Obj, but got Unknown
		//IL_0048: Expected Obj, but got I
		//IL_0097: Expected Obj, but got I
		//IL_01b7: Expected Obj, but got F4
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected F4, but got Unknown
		//IL_01cc: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		_ = 0;
		int num = index << 2;
		object obj3 = PanelsRT__BackingField + num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v6+10]");
		Vector2 anchoredPosition = ((RectTransform)0).anchoredPosition;
		ScrollRect scrollRect = this.scrollRect;
		Vector2 anchoredPosition2 = scrollRect.m_Content.anchoredPosition;
		object obj4 = obj + obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
		object obj5 = num2 + 0;
		ScrollRect scrollRect2 = this.scrollRect;
		Rect rect = scrollRect2.m_Viewport.rect;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		ScrollRect scrollRect3 = this.scrollRect;
		Vector2 anchorMin = scrollRect3.m_Content.anchorMin;
		ScrollRect scrollRect4 = this.scrollRect;
		Rect rect2 = scrollRect4.m_Viewport.rect;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		ScrollRect scrollRect5 = this.scrollRect;
		Vector2 anchorMin2 = scrollRect5.m_Content.anchorMin;
		float num3 = 0.5f - (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		float num4 = 0f * num3;
		float num5 = (float)obj4 - num4;
		float num6 = 0.5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
		float num7 = num6 - 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
		float num8 = 0f * num7;
		float num9 = (float)obj5 - num8;
		object obj6 = num9 << 32;
		float x = num5 | obj6;
		Vector2 vector = default;
		((Vector2*)(nint)vector)->x = x;
		return vector;
	}

	private int DetermineNearestPanel()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0074: Expected F4, but got I
		//IL_007d: Expected Obj, but got I4
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected Obj, but got Unknown
		//IL_01d7: Expected Obj, but got I
		//IL_01f4: Expected Obj, but got I
		//IL_00ad: Invalid comparison between F4 and I
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Expected Obj, but got Unknown
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected Obj, but got Unknown
		//IL_0127: Invalid comparison between F4 and I
		//IL_00f7: Expected F4, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		int result = NearestPanel__BackingField;
		int numberOfPanels = NumberOfPanels;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		int num = 0;
		object obj4 = default;
		while (true)
		{
			GameObject[] array = Panels__BackingField;
			if (array.Length <= num)
			{
				break;
			}
			Vector2 vector = DisplacementFromCenter(num);
			int num2 = num << 2;
			object obj3 = obj4 + num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			object obj5 = num3 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			object obj6 = num4 * 0;
			object obj7 = obj5 + obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Sqrt not resolved\"");
			int num5 = num + 1;
			num = num5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v13+C]");
		float num6;
		if ((nint)0 == 0)
		{
			num6 = 0f;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v13+10]");
			num6 = 0f;
			object obj8 = 1;
			while (true)
			{
				object obj9 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v13+C]");
				if ((nint)obj9 >= 0)
				{
					break;
				}
				object obj10 = obj8 << 2;
				object obj11 = obj4 + obj10;
				float num7 = num6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S1_v19+10]");
				if (num7 > 0f)
				{
					object obj12 = obj8 << 2;
					object obj13 = obj4 + obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S0_v52+10]");
					num6 = 0f;
				}
				object obj14 = obj8 + 1;
				obj8 = obj14;
			}
		}
		int num8 = 0;
		while (true)
		{
			GameObject[] array2 = Panels__BackingField;
			if (array2.Length <= num8)
			{
				break;
			}
			int num9 = num8 << 2;
			object obj15 = obj4 + num9;
			float num10 = num6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S1_v13+10]");
			if (num10 != 0f)
			{
				int num11 = num8 + 1;
				num8 = num11;
				continue;
			}
			result = num8;
			break;
		}
		return result;
	}

	private void DetermineVelocity()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0047: Expected Obj, but got I
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected Obj, but got Unknown
		//IL_00ca: Expected Obj, but got F4
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected VT, but got Unknown
		//IL_010f: Expected VT, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		ScrollRect scrollRect = this.scrollRect;
		Vector2 anchoredPosition = scrollRect.m_Content.anchoredPosition;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (DanielLochner.Assets.SimpleScrollSnap.SimpleScrollSnap)+A8]");
		object obj3 = num - 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		object obj4 = 0 - previousContentAnchoredPosition;
		float num2 = ((~(useUnscaledTime ? 1u : 0u) == 0) ? Time.unscaledDeltaTime : Time.deltaTime);
		float num3 = (float)obj4 / num2;
		float num4 = (float)obj3 / num2;
		object obj5 = num4 << 32;
		Vector2 vector = (Vector2)(num3 | obj5);
		velocity = vector;
		ScrollRect scrollRect2 = this.scrollRect;
		Vector2 anchoredPosition2 = scrollRect2.m_Content.anchoredPosition;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		previousContentAnchoredPosition = (Vector2)0;
	}

	private void SelectTargetPanel()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00a3: Expected Obj, but got I4
		//IL_0106: Invalid comparison between I and F4
		//IL_0247: Invalid comparison between I and F4
		//IL_0195: Invalid comparison between I and F4
		//IL_0149: Invalid comparison between I and F4
		//IL_02d6: Invalid comparison between I and F4
		//IL_028a: Invalid comparison between I and F4
		//IL_01ea: Invalid comparison between I and F4
		//IL_032b: Invalid comparison between I and F4
		object obj2 = default;
		object obj = obj2 - 16;
		Vector2 vector = DisplacementFromCenter(NearestPanel__BackingField = DetermineNearestPanel());
		if (snapTarget == SnapTarget.Nearest || !(releaseSpeed > minimumSwipeSpeed))
		{
			GoToPanel(NearestPanel__BackingField);
			return;
		}
		object obj3 = snapTarget - 1;
		if (snapTarget != SnapTarget.Previous)
		{
			if ((nint)obj3 != 1)
			{
				return;
			}
			bool flag = releaseDirection == Direction.Right;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			if (!(0f > 0f))
			{
				flag = false;
			}
			if (flag)
			{
				goto IL_02a9;
			}
			if (releaseDirection == Direction.Up)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
				if (0f > 0f)
				{
					goto IL_02a9;
				}
			}
			bool flag2 = releaseDirection == Direction.Left;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			if (!(0f < 0f))
			{
				flag2 = false;
			}
			if (!flag2)
			{
				if (releaseDirection == Direction.Down)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
					if (0f < 0f)
					{
						goto IL_034a;
					}
				}
				GoToPanel(NearestPanel__BackingField);
				return;
			}
			goto IL_034a;
		}
		bool flag3 = releaseDirection == Direction.Right;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		if (!(0f < 0f))
		{
			flag3 = false;
		}
		if (flag3)
		{
			goto IL_0168;
		}
		if (releaseDirection == Direction.Up)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			if (0f < 0f)
			{
				goto IL_0168;
			}
		}
		bool flag4 = releaseDirection == Direction.Left;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		if (!(0f > 0f))
		{
			flag4 = false;
		}
		if (!flag4)
		{
			if (releaseDirection == Direction.Down)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
				if (0f > 0f)
				{
					goto IL_0209;
				}
			}
			GoToPanel(NearestPanel__BackingField);
			return;
		}
		goto IL_0209;
		IL_02a9:
		GoToPreviousPanel();
		return;
		IL_0168:
		GoToNextPanel();
		return;
		IL_034a:
		GoToNextPanel();
		return;
		IL_0209:
		GoToPreviousPanel();
	}

	private unsafe void SnapToTargetPanel()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected Obj, but got Unknown
		//IL_016e: Expected Obj, but got I
		//IL_0188: Expected Obj, but got I
		//IL_01ad: Expected Obj, but got I
		//IL_0360: Expected Obj, but got I
		//IL_039b: Expected Obj, but got F4
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a8: Expected F4, but got Unknown
		//IL_03b0: Expected native int or pointer, but got VT
		//IL_043f: Expected Obj, but got I
		//IL_045c: Expected Obj, but got I
		//IL_0493: Invalid comparison between Obj and F4
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Expected Obj, but got Unknown
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Expected Obj, but got Unknown
		object obj = default;
		Vector2 vector = (Vector2)(obj - 48);
		_ = 0;
		_ = 0;
		MovementAxis movementAxis;
		if (this.movementAxis != MovementAxis.Horizontal)
		{
			bool flag = movementType != MovementType.Free;
			movementAxis = this.movementAxis;
			if (flag)
			{
				goto IL_02cc;
			}
		}
		ScrollRect scrollRect = this.scrollRect;
		Rect rect = scrollRect.m_Viewport.rect;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+28]");
		float num = 0f * 0.5f;
		movementAxis = this.movementAxis;
		goto IL_02cc;
		IL_02f7:
		RectTransform[] array = PanelsRT__BackingField;
		if (TargetPanel__BackingField >= array.Length)
		{
			return;
		}
		int num2 = TargetPanel__BackingField << 2;
		object obj2 = array + num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S1_v14+10]");
		Vector2 anchoredPosition = ((RectTransform)0).anchoredPosition;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+10]");
		object obj3 = (nint)0 ^ (nint)int.MinValue;
		float num3 = (float)obj3 + num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+14]");
		object obj4 = (nint)0 ^ (nint)int.MinValue;
		float num5;
		float num4 = (float)obj4 + num5;
		ScrollRect scrollRect2 = this.scrollRect;
		Vector2 anchoredPosition2 = scrollRect2.m_Content.anchoredPosition;
		float num6 = num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+10]");
		float num7 = num6 - 0f;
		float num8 = ((~(useUnscaledTime ? 1u : 0u) == 0) ? Time.unscaledDeltaTime : Time.deltaTime);
		float num9 = num8 * snappingSpeed;
		float num10 = Math.Min(num9, 1f);
		bool flag2 = num9 < 0f;
		float num11 = 0f;
		if (!flag2)
		{
			num11 = num10;
		}
		float num12 = num7 * num11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+10]");
		float num13 = 0f + num12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+10]");
		object obj5 = (nint)0 >> 32;
		float num14 = num4 - (float)obj5;
		float num15 = num14 * num11;
		float num16 = (float)obj5 + num15;
		object obj6 = num16 << 32;
		float x = num13 | obj6;
		((Vector2*)(nint)vector)->x = x;
		scrollRect2.m_Content.anchoredPosition = vector;
		if (TargetPanel__BackingField != CurrentPanel__BackingField)
		{
			Vector2 vector2 = DisplacementFromCenter(TargetPanel__BackingField);
			ScrollRect scrollRect3 = this.scrollRect;
			Rect rect2 = scrollRect3.m_Viewport.rect;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+10]");
			nint num17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+10]");
			object obj7 = num17 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+14]");
			nint num18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+14]");
			object obj8 = num18 * 0;
			object obj9 = obj7 + obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Sqrt not resolved\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+28]");
			float num19 = 0f / 10f;
			object obj10;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num19))
			{
				CurrentPanel__BackingField = TargetPanel__BackingField;
				obj10 = this + 112;
			}
			else
			{
				obj10 = this + 124;
			}
			((UnityEvent)obj10).Invoke();
		}
		return;
		IL_02cc:
		if (movementAxis != MovementAxis.Vertical)
		{
			bool flag3 = movementType != MovementType.Free;
			num5 = 0f;
			if (flag3)
			{
				goto IL_02f7;
			}
		}
		ScrollRect scrollRect4 = this.scrollRect;
		Rect rect3 = scrollRect4.m_Viewport.rect;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+2C]");
		num5 = 0f * 0.5f;
		goto IL_02f7;
	}

	private void OnSelectingAndSnapping()
	{
		//IL_00bd: Expected Obj, but got VT
		//IL_00da: Expected Obj, but got I
		//IL_00fb: Invalid comparison between F4 and Obj
		if (~(selected ? 1u : 0u) == 0)
		{
			if ((~(dragging ? 1u : 0u) != 0 && ~(pressing ? 1u : 0u) != 0) || !swipeGestures)
			{
				SnapToTargetPanel();
			}
		}
		else if (!dragging)
		{
			ScrollRect scrollRect = this.scrollRect;
			object obj = scrollRect.m_Velocity * scrollRect.m_Velocity;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v8 (UnityEngine.UI.ScrollRect)+90]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v8 (UnityEngine.UI.ScrollRect)+90]");
			object obj2 = num * 0;
			object obj3 = obj + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Sqrt not resolved\"");
			float num2 = thresholdSnappingSpeed;
			bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num2) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3);
			if (thresholdSnappingSpeed == -1f)
			{
				flag = true;
			}
			if (flag)
			{
				SelectTargetPanel();
			}
		}
	}

	private void OnOcclusionCulling(bool forceUpdate = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_023c: Expected Obj, but got VT
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected I, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected I, but got Unknown
		//IL_0075: Expected F4, but got I
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected Obj, but got Unknown
		//IL_012e: Expected F4, but got Obj
		//IL_0142: Expected VT, but got I
		//IL_015a: Expected Obj, but got I
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected Obj, but got Unknown
		//IL_01d6: Expected F4, but got I
		//IL_01ea: Expected VT, but got I
		//IL_0202: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		_ = 0;
		if (~(useOcclusionCulling ? 1u : 0u) != 0)
		{
			return;
		}
		object obj3 = velocity * velocity;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (DanielLochner.Assets.SimpleScrollSnap.SimpleScrollSnap)+B0]");
		float num = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (DanielLochner.Assets.SimpleScrollSnap.SimpleScrollSnap)+B0]");
		float num2 = num * 0f;
		float num3 = (float)obj3 + num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Sqrt not resolved\"");
		bool flag = num3 > 0f;
		bool flag2 = true;
		if (!forceUpdate)
		{
			flag2 = flag;
		}
		if (!flag2)
		{
			return;
		}
		nint num4 = (nint)(this + 28);
		nint num5 = (nint)(this + 32);
		Vector2 vector = velocity;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (DanielLochner.Assets.SimpleScrollSnap.SimpleScrollSnap)+B0]");
		float num6 = 0f;
		int num7 = 0;
		while (true)
		{
			int numberOfPanels = NumberOfPanels;
			if (numberOfPanels <= num7)
			{
				break;
			}
			GameObject gameObject;
			IntPtr intPtr;
			if (movementAxis != MovementAxis.Horizontal)
			{
				if (movementAxis != MovementAxis.Vertical)
				{
					goto IL_020f;
				}
				int num8 = num7 << 2;
				object obj4 = Panels__BackingField + num8;
				Vector2 vector2 = DisplacementFromCenter(num7);
				ScrollRect scrollRect = this.scrollRect;
				Rect rect = scrollRect.m_Viewport.rect;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
				float num9 = Math.Abs(0f);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
				vector = (Vector2)0;
				num6 = num9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S0_v57+10]");
				gameObject = (GameObject)0;
				intPtr = num5;
			}
			else
			{
				int num10 = num7 << 2;
				object obj5 = Panels__BackingField + num10;
				Vector2 vector3 = DisplacementFromCenter(num7);
				ScrollRect scrollRect2 = this.scrollRect;
				Rect rect = scrollRect2.m_Viewport.rect;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				_ = 0;
				float num11 = Math.Abs((float)obj);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
				vector = (Vector2)0;
				num6 = num11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S0_v42+10]");
				gameObject = (GameObject)0;
				intPtr = num4;
			}
			float num12 = (float)vector * 0.5f;
			float num13 = num12 + (float)(nint)intPtr;
			bool active = !(num6 > num13);
			gameObject.SetActive(active);
			goto IL_020f;
			IL_020f:
			int num14 = num7 + 1;
			num7 = num14;
		}
	}

	private unsafe void OnInfiniteScrolling(bool forceUpdate = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_05f0: Expected Obj, but got VT
		//IL_060d: Expected Obj, but got I
		//IL_062d: Invalid comparison between Obj and F4
		//IL_0115: Invalid comparison between F4 and I
		//IL_0254: Invalid comparison between I and F4
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected Obj, but got Unknown
		//IL_0162: Expected Obj, but got I
		//IL_01a5: Expected Obj, but got F4
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected F4, but got Unknown
		//IL_01ba: Expected native int or pointer, but got VT
		//IL_01d9: Expected Obj, but got I
		//IL_03af: Invalid comparison between F4 and I
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Expected Obj, but got Unknown
		//IL_02a1: Expected Obj, but got I
		//IL_02e4: Expected Obj, but got F4
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Expected F4, but got Unknown
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_0309: Expected VT, but got Unknown
		//IL_031e: Expected Obj, but got I
		//IL_04f4: Invalid comparison between I and F4
		//IL_03e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Expected Obj, but got Unknown
		//IL_03fc: Expected Obj, but got I
		//IL_043f: Expected Obj, but got F4
		//IL_0447: Unknown result type (might be due to invalid IL or missing references)
		//IL_044c: Expected F4, but got Unknown
		//IL_045f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0464: Expected VT, but got Unknown
		//IL_0479: Expected Obj, but got I
		//IL_052b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0530: Expected Obj, but got Unknown
		//IL_0541: Expected Obj, but got I
		//IL_0584: Expected Obj, but got F4
		//IL_058c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0591: Expected F4, but got Unknown
		//IL_05a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a9: Expected VT, but got Unknown
		//IL_05be: Expected Obj, but got I
		object obj = default;
		Vector2 vector = (Vector2)(obj - 96);
		_ = 0;
		_ = 0;
		if (~(infinitelyScroll ? 1u : 0u) != 0)
		{
			return;
		}
		object obj2 = velocity * velocity;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (DanielLochner.Assets.SimpleScrollSnap.SimpleScrollSnap)+B0]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (DanielLochner.Assets.SimpleScrollSnap.SimpleScrollSnap)+B0]");
		object obj3 = num * 0;
		object obj4 = obj2 + obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Sqrt not resolved\"");
		bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0f);
		bool flag2 = true;
		if (!forceUpdate)
		{
			flag2 = flag;
		}
		if (!flag2)
		{
			return;
		}
		if (movementAxis != MovementAxis.Horizontal)
		{
			if (movementAxis != MovementAxis.Vertical)
			{
				return;
			}
			int num2 = 0;
			while (true)
			{
				int numberOfPanels = NumberOfPanels;
				if (numberOfPanels <= num2)
				{
					break;
				}
				Vector2 vector2 = DisplacementFromCenter(num2);
				ScrollRect scrollRect = this.scrollRect;
				Rect rect = scrollRect.m_Content.rect;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+48]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+40]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+5C]");
				float num3 = 0f * 0.5f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+44]");
				if (num3 < 0f)
				{
					int num4 = num2 << 2;
					object obj5 = PanelsRT__BackingField + num4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ S1_v109+10]");
					Vector2 anchoredPosition = ((RectTransform)0).anchoredPosition;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+40]");
					float num5 = 0f - 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+44]");
					float num6 = 0f - contentLength;
					object obj6 = num6 << 32;
					float num7 = num5 | obj6;
					Vector2 anchoredPosition2 = vector + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ S1_v109+10]");
					((RectTransform)0).anchoredPosition = anchoredPosition2;
				}
				else
				{
					Vector2 vector3 = DisplacementFromCenter(num2);
					ScrollRect scrollRect2 = this.scrollRect;
					Rect rect2 = scrollRect2.m_Content.rect;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+48]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+40]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+5C]");
					float num8 = 0f * -0.5f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+44]");
					if (0f < num8)
					{
						int num9 = num2 << 2;
						object obj7 = PanelsRT__BackingField + num9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ S1_v97+10]");
						Vector2 anchoredPosition3 = ((RectTransform)0).anchoredPosition;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+40]");
						float num10 = 0f + 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+44]");
						float num11 = 0f + contentLength;
						object obj8 = num11 << 32;
						float num12 = num10 | obj8;
						Vector2 anchoredPosition4 = vector + 24;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ S1_v97+10]");
						((RectTransform)0).anchoredPosition = anchoredPosition4;
					}
				}
				int num13 = num2 + 1;
				num2 = num13;
			}
			return;
		}
		int num14 = 0;
		while (true)
		{
			int numberOfPanels2 = NumberOfPanels;
			if (numberOfPanels2 <= num14)
			{
				break;
			}
			Vector2 vector4 = DisplacementFromCenter(num14);
			ScrollRect scrollRect3 = this.scrollRect;
			Rect rect3 = scrollRect3.m_Content.rect;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+48]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+40]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+58]");
			float num15 = 0f * 0.5f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+40]");
			if (num15 < 0f)
			{
				int num16 = num14 << 2;
				object obj9 = PanelsRT__BackingField + num16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ S1_v56+10]");
				Vector2 anchoredPosition5 = ((RectTransform)0).anchoredPosition;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+40]");
				float num17 = 0f - contentLength;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+44]");
				float num18 = 0f - 0f;
				object obj10 = num18 << 32;
				float x = num17 | obj10;
				((Vector2*)(nint)vector)->x = x;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ S1_v56+10]");
				((RectTransform)0).anchoredPosition = vector;
			}
			else
			{
				Vector2 vector5 = DisplacementFromCenter(num14);
				ScrollRect scrollRect4 = this.scrollRect;
				Rect rect4 = scrollRect4.m_Content.rect;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+48]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+40]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+58]");
				float num19 = 0f * -0.5f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+40]");
				if (0f < num19)
				{
					int num20 = num14 << 2;
					object obj11 = PanelsRT__BackingField + num20;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ S1_v44+10]");
					Vector2 anchoredPosition6 = ((RectTransform)0).anchoredPosition;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+40]");
					float num21 = 0f + contentLength;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+44]");
					float num22 = 0f + 0f;
					object obj12 = num22 << 32;
					float num23 = num21 | obj12;
					Vector2 anchoredPosition7 = vector + 8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ S1_v44+10]");
					((RectTransform)0).anchoredPosition = anchoredPosition7;
				}
			}
			int num24 = num14 + 1;
			num14 = num24;
		}
	}

	private void OnTransitionEffects()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected Obj, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected Obj, but got Unknown
		//IL_2243: Unknown result type (might be due to invalid IL or missing references)
		//IL_2248: Expected Obj, but got Unknown
		//IL_20c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_20ca: Expected Obj, but got Unknown
		//IL_2073: Unknown result type (might be due to invalid IL or missing references)
		//IL_2078: Expected Obj, but got Unknown
		//IL_00ee: Expected Obj, but got I
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Expected Obj, but got Unknown
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected Obj, but got Unknown
		//IL_2226: Expected F4, but got I
		//IL_0319: Expected F4, but got I
		//IL_01f3: Expected F4, but got I
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Expected Obj, but got Unknown
		//IL_034f: Expected Obj, but got I
		//IL_219e: Expected Obj, but got I
		//IL_025c: Expected F4, but got I
		//IL_183c: Expected I4, but got Obj
		//IL_183c: Expected Obj, but got I4
		//IL_178d: Expected I4, but got Obj
		//IL_178d: Expected Obj, but got I4
		//IL_1876: Expected Obj, but got I4
		//IL_16de: Expected I4, but got Obj
		//IL_16de: Expected Obj, but got I4
		//IL_1409: Unknown result type (might be due to invalid IL or missing references)
		//IL_140e: Expected Obj, but got Unknown
		//IL_17c7: Expected Obj, but got I4
		//IL_1718: Expected Obj, but got I4
		//IL_1e44: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e49: Expected Obj, but got Unknown
		//IL_0771: Expected I4, but got Obj
		//IL_0771: Expected Obj, but got I4
		//IL_10ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f4: Expected Obj, but got Unknown
		//IL_1c6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c6f: Expected Obj, but got Unknown
		//IL_148f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1494: Expected Obj, but got Unknown
		//IL_0ef1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef6: Expected Obj, but got Unknown
		//IL_08f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fe: Expected Obj, but got Unknown
		//IL_1e8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e93: Expected Obj, but got Unknown
		//IL_1a7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a84: Expected Obj, but got Unknown
		//IL_07ab: Expected Obj, but got I4
		//IL_0cb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cbc: Expected Obj, but got Unknown
		//IL_1cb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cb9: Expected Obj, but got Unknown
		//IL_0506: Unknown result type (might be due to invalid IL or missing references)
		//IL_050b: Expected Obj, but got Unknown
		//IL_0f6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f73: Expected Obj, but got Unknown
		//IL_1ed8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1edd: Expected Obj, but got Unknown
		//IL_1185: Unknown result type (might be due to invalid IL or missing references)
		//IL_118a: Expected Obj, but got Unknown
		//IL_1586: Unknown result type (might be due to invalid IL or missing references)
		//IL_158b: Expected Obj, but got Unknown
		//IL_1594: Unknown result type (might be due to invalid IL or missing references)
		//IL_1599: Expected Obj, but got Unknown
		//IL_1b05: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b0a: Expected Obj, but got Unknown
		//IL_0d70: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d75: Expected Obj, but got Unknown
		//IL_1240: Unknown result type (might be due to invalid IL or missing references)
		//IL_1245: Expected Obj, but got Unknown
		//IL_124e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1253: Expected Obj, but got Unknown
		//IL_18e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_18e6: Expected Obj, but got Unknown
		//IL_1d3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d3f: Expected Obj, but got Unknown
		//IL_058c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0591: Expected Obj, but got Unknown
		//IL_161a: Unknown result type (might be due to invalid IL or missing references)
		//IL_161f: Expected Obj, but got Unknown
		//IL_09cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d0: Expected Obj, but got Unknown
		//IL_1fab: Expected Obj, but got I4
		//IL_1b4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b54: Expected Obj, but got Unknown
		//IL_12d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_12d9: Expected Obj, but got Unknown
		//IL_192b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1930: Expected Obj, but got Unknown
		//IL_1dd1: Expected Obj, but got I4
		//IL_0a86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8b: Expected Obj, but got Unknown
		//IL_0a94: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a99: Expected Obj, but got Unknown
		//IL_1fe1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fe6: Expected Obj, but got Unknown
		//IL_1bad: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bb2: Expected Obj, but got Unknown
		//IL_1bc2: Expected Obj, but got I
		//IL_1bf7: Expected Obj, but got I4
		//IL_1975: Unknown result type (might be due to invalid IL or missing references)
		//IL_197a: Expected Obj, but got Unknown
		//IL_1e07: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e0c: Expected Obj, but got Unknown
		//IL_0653: Unknown result type (might be due to invalid IL or missing references)
		//IL_0658: Expected Obj, but got Unknown
		//IL_0b1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1f: Expected Obj, but got Unknown
		//IL_1c2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c32: Expected Obj, but got Unknown
		//IL_1a0c: Expected Obj, but got I4
		//IL_1a42: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a47: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 512;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [532B9E]");
		bool flag = (nint)0 == 0;
		bool flag2 = !flag;
		_ = 0;
		_ = 0;
		List<TransitionEffect> list = transitionEffects;
		if (list._size == 0)
		{
			return;
		}
		nint num = default;
		object obj6 = default;
		object obj14 = default;
		object obj15 = default;
		float num7 = default;
		object obj19 = default;
		object obj27 = default;
		object obj35 = default;
		object obj44 = default;
		object obj52 = default;
		float num8 = default;
		object obj58 = default;
		float num12 = default;
		object obj64 = default;
		float num16 = default;
		object obj67 = default;
		float num17 = default;
		object obj70 = default;
		float num18 = default;
		object obj76 = default;
		object obj77 = default;
		object obj79 = default;
		object obj80 = default;
		nint num22 = default;
		while (true)
		{
			int numberOfPanels = NumberOfPanels;
			if (numberOfPanels <= num)
			{
				break;
			}
			object obj3 = obj + 384;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+188]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+180]");
			_ = 0;
			object obj4 = obj + 400;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+180]");
			_ = 0;
			while (true)
			{
				_ = 0;
				object obj5 = obj + 400;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					if (obj6 == null)
					{
						break;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+19C]");
					object obj7 = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						if (movementType == MovementType.Fixed)
						{
							if (movementAxis != MovementAxis.Horizontal)
							{
								if (movementAxis != MovementAxis.Vertical)
								{
									float num2 = 0f;
								}
								else
								{
									_ = 0;
									object obj8 = obj + 384;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									bool flag3 = (nint)0 == 1;
									float num2 = 0f;
									if (flag3)
									{
										goto IL_216d;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+184]");
									num2 = 0f;
								}
							}
							else
							{
								_ = 0;
								object obj9 = obj + 384;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								bool flag4 = (nint)0 == 1;
								float num2 = 0f;
								if (flag4)
								{
									goto IL_216d;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+180]");
								num2 = 0f;
							}
							goto IL_2190;
						}
						_ = 0;
						object obj10 = obj + 384;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [5357E2]");
							float num2;
							if ((nint)0 == 0)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								bool flag5 = (nint)0 == 1;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+184]");
								num2 = 0f;
								if (flag5)
								{
									goto IL_216d;
								}
								_ = 1;
							}
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							bool flag6 = (nint)0 == 1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+184]");
							num2 = 0f;
							if (!flag6)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+180]");
								nint num3 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+180]");
								object obj11 = num3 * 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+184]");
								float num4 = 0f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+184]");
								float num5 = num4 * 0f;
								float num6 = (float)obj11 + num5;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Sqrt not resolved\"");
								num2 = num6;
								goto IL_2190;
							}
						}
					}
				}
				goto IL_216d;
				IL_2190:
				object obj12 = num << 2;
				object obj13 = (object)PanelsRT__BackingField + obj12;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					if ((nint)obj14 < -1431404015)
					{
						if ((nint)obj14 <= -1699845920)
						{
							if ((nint)obj14 != -1699845920)
							{
								if ((nint)obj14 != 468225103)
								{
									continue;
								}
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									if (obj15 == null)
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
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											_ = 0;
											object obj16 = obj + 384;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
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
													_ = 0;
													object obj17 = obj + 384;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													if ((nint)0 != 1)
													{
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30");
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
														bool flag7 = (nint)0 == 1;
														float num2 = num7;
														if (!flag7)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+170]");
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+184]");
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+180]");
															_ = 0;
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+168]");
															_ = 0;
															object obj18 = obj + 8;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
															bool flag8 = (nint)0 != 1;
															num2 = num7;
															if (flag8)
															{
																continue;
															}
															num2 = num7;
														}
													}
												}
											}
										}
									}
								}
							}
							else
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									if (obj19 == null)
									{
										continue;
									}
									_ = 0;
									Graphic[] array = ((Dictionary<int, Graphic[]>)10452).get_Item((int)panelGraphics);
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										object obj20 = 0;
										while ((nint)obj20 < array.Length)
										{
											object obj21 = obj20 << 2;
											object obj22 = (object)array + obj21;
											_ = 0;
											object obj23 = obj + 384;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 != 1)
											{
												_ = 0;
												object obj24 = obj + 384;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 != 1)
												{
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													if ((nint)0 != 1)
													{
														_ = 0;
														object obj25 = obj + 384;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
														if ((nint)0 != 1)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18C]");
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F0]");
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+184]");
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+180]");
															_ = 0;
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+E8]");
															_ = 0;
															((Dictionary<int, Graphic[]>)10458).get_Item(23);
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
															if ((nint)0 != 1)
															{
																object obj26 = obj20 + 1;
																obj20 = obj26;
																continue;
															}
														}
													}
												}
											}
											goto IL_216d;
										}
										continue;
									}
								}
							}
						}
						else if ((nint)obj14 != -1649513063)
						{
							if ((nint)obj14 != -1615957825)
							{
								if ((nint)obj14 != -1431404016)
								{
									continue;
								}
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									if (obj27 == null)
									{
										continue;
									}
									_ = 0;
									Graphic[] array2 = ((Dictionary<int, Graphic[]>)10452).get_Item((int)panelGraphics);
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										object obj28 = 0;
										while ((nint)obj28 < array2.Length)
										{
											object obj29 = obj28 << 2;
											object obj30 = (object)array2 + obj29;
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 != 1)
											{
												_ = 0;
												object obj31 = obj + 384;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 != 1)
												{
													_ = 0;
													object obj32 = obj + 384;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													if ((nint)0 != 1)
													{
														_ = 0;
														object obj33 = obj + 384;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
														if ((nint)0 != 1)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+188]");
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18C]");
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+110]");
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+184]");
															_ = 0;
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+108]");
															_ = 0;
															((Dictionary<int, Graphic[]>)10458).get_Item(23);
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
															if ((nint)0 != 1)
															{
																object obj34 = obj28 + 1;
																obj28 = obj34;
																continue;
															}
														}
													}
												}
											}
											goto IL_216d;
										}
										continue;
									}
								}
							}
							else
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									if (obj35 == null)
									{
										continue;
									}
									_ = 0;
									Graphic[] array3 = ((Dictionary<int, Graphic[]>)10452).get_Item((int)panelGraphics);
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										object obj36 = 0;
										while ((nint)obj36 < array3.Length)
										{
											object obj37 = obj36 << 2;
											object obj38 = (object)array3 + obj37;
											_ = 0;
											object obj39 = obj + 384;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 != 1)
											{
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 != 1)
												{
													_ = 0;
													object obj40 = obj + 384;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													if ((nint)0 != 1)
													{
														_ = 0;
														object obj41 = obj + 384;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
														if ((nint)0 != 1)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+188]");
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18C]");
															_ = 0;
															object obj42 = obj - -64;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+100]");
															obj42 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+180]");
															_ = 0;
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F8]");
															_ = 0;
															((Dictionary<int, Graphic[]>)10458).get_Item(23);
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
															if ((nint)0 != 1)
															{
																object obj43 = obj36 + 1;
																obj36 = obj43;
																continue;
															}
														}
													}
												}
											}
											goto IL_216d;
										}
										continue;
									}
								}
							}
						}
						else
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								if (obj44 == null)
								{
									continue;
								}
								_ = 0;
								Graphic[] array4 = ((Dictionary<int, Graphic[]>)10452).get_Item((int)panelGraphics);
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									object obj45 = 0;
									while ((nint)obj45 < array4.Length)
									{
										object obj46 = obj45 << 2;
										object obj47 = (object)array4 + obj46;
										_ = 0;
										object obj48 = obj + 384;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											_ = 0;
											object obj49 = obj + 384;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 != 1)
											{
												_ = 0;
												object obj50 = obj + 384;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 != 1)
												{
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													if ((nint)0 != 1)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+188]");
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+E0]");
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+184]");
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+180]");
														_ = 0;
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+D8]");
														_ = 0;
														((Dictionary<int, Graphic[]>)10458).get_Item(23);
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
														if ((nint)0 != 1)
														{
															object obj51 = obj45 + 1;
															obj45 = obj51;
															continue;
														}
													}
												}
											}
										}
										goto IL_216d;
									}
									continue;
								}
							}
						}
					}
					else if ((nint)obj14 <= -1314472389)
					{
						if ((nint)obj14 != -1331250008)
						{
							if ((nint)obj14 != -1314472389)
							{
								continue;
							}
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								if (obj52 == null)
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
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										_ = 0;
										object obj53 = obj + 384;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											bool flag9 = (nint)0 == 1;
											float num2 = num8;
											if (!flag9)
											{
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												bool flag10 = (nint)0 == 1;
												num2 = num8;
												if (!flag10)
												{
													_ = 0;
													object obj54 = obj + 384;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													bool flag11 = (nint)0 == 1;
													num2 = num8;
													if (!flag11)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+188]");
														float num9 = 0f * ((float)Math.PI / 180f);
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C8]");
														_ = 0;
														float num10 = num8 * ((float)Math.PI / 180f);
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+180]");
														float num11 = 0f * ((float)Math.PI / 180f);
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C0]");
														_ = 0;
														object obj55 = obj + 464;
														object obj56 = obj + 136;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
														bool flag12 = (nint)0 == 1;
														num2 = num8;
														if (!flag12)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1D8]");
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1D8]");
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1D0]");
															_ = 0;
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1D0]");
															_ = 0;
															object obj57 = obj + 120;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
															bool flag13 = (nint)0 != 1;
															num2 = num8;
															if (flag13)
															{
																continue;
															}
															num2 = num8;
														}
													}
												}
											}
										}
									}
								}
							}
						}
						else
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								if (obj58 == null)
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
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									bool flag14 = (nint)0 == 1;
									float num2 = num12;
									if (!flag14)
									{
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										bool flag15 = (nint)0 == 1;
										num2 = num12;
										if (!flag15)
										{
											_ = 0;
											object obj59 = obj + 384;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											bool flag16 = (nint)0 == 1;
											num2 = num12;
											if (!flag16)
											{
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												bool flag17 = (nint)0 == 1;
												num2 = num12;
												if (!flag17)
												{
													_ = 0;
													object obj60 = obj + 384;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													bool flag18 = (nint)0 == 1;
													num2 = num12;
													if (!flag18)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+188]");
														float num13 = 0f * ((float)Math.PI / 180f);
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1A8]");
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+184]");
														float num14 = 0f * ((float)Math.PI / 180f);
														float num15 = num12 * ((float)Math.PI / 180f);
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1A0]");
														_ = 0;
														object obj61 = obj + 432;
														object obj62 = obj + 104;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
														bool flag19 = (nint)0 == 1;
														num2 = num12;
														if (!flag19)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1B8]");
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1B8]");
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1B0]");
															_ = 0;
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1B0]");
															_ = 0;
															object obj63 = obj + 88;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
															bool flag20 = (nint)0 != 1;
															num2 = num12;
															if (flag20)
															{
																continue;
															}
															num2 = num12;
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
					else if ((nint)obj14 != -1297694770)
					{
						if ((nint)obj14 != -468345412)
						{
							if ((nint)obj14 != -451567793)
							{
								continue;
							}
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								if (obj64 == null)
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
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										_ = 0;
										object obj65 = obj + 384;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											bool flag21 = (nint)0 == 1;
											float num2 = num16;
											if (!flag21)
											{
												_ = 0;
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+180]");
												_ = 0;
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+148]");
												_ = 0;
												object obj66 = obj + 200;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												bool flag22 = (nint)0 != 1;
												num2 = num16;
												if (flag22)
												{
													continue;
												}
												num2 = num16;
											}
										}
									}
								}
							}
						}
						else
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								if (obj67 == null)
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
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									bool flag23 = (nint)0 == 1;
									float num2 = num17;
									if (!flag23)
									{
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										bool flag24 = (nint)0 == 1;
										num2 = num17;
										if (!flag24)
										{
											_ = 0;
											object obj68 = obj + 384;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											bool flag25 = (nint)0 == 1;
											num2 = num17;
											if (!flag25)
											{
												_ = 0;
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+184]");
												_ = 0;
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+158]");
												_ = 0;
												object obj69 = obj + 184;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												bool flag26 = (nint)0 != 1;
												num2 = num17;
												if (flag26)
												{
													continue;
												}
												num2 = num17;
											}
										}
									}
								}
							}
						}
					}
					else
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							if (obj70 == null)
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
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									_ = 0;
									object obj71 = obj + 384;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
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
											_ = 0;
											object obj72 = obj + 384;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 != 1)
											{
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												bool flag27 = (nint)0 == 1;
												float num2 = num18;
												if (!flag27)
												{
													float num19 = num18 * ((float)Math.PI / 180f);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1E8]");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+184]");
													float num20 = 0f * ((float)Math.PI / 180f);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+180]");
													float num21 = 0f * ((float)Math.PI / 180f);
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1E0]");
													_ = 0;
													object obj73 = obj + 496;
													object obj74 = obj + 168;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													bool flag28 = (nint)0 == 1;
													num2 = num18;
													if (!flag28)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1F8]");
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1F8]");
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1F0]");
														_ = 0;
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1F0]");
														_ = 0;
														object obj75 = obj + 152;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
														bool flag29 = (nint)0 != 1;
														num2 = num18;
														if (flag29)
														{
															continue;
														}
														num2 = num18;
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
				goto IL_216d;
				IL_216d:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				bool flag30 = obj76 != obj77;
				object obj78 = obj79;
				if (!flag30)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					obj78 = obj80;
				}
				_ = 0;
				object obj81 = obj + 376;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				return;
			}
			object obj82 = obj + 376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @95E9");
			num = num22 + 1;
		}
	}

	private void OnSwipeGestures()
	{
		ScrollRect scrollRect = this.scrollRect;
		if (~(swipeGestures ? 1u : 0u) != 0)
		{
			scrollRect.m_Vertical = (scrollRect.m_Horizontal = (byte)((dragging ? 1u : 0u) ^ 1u) != 0);
			return;
		}
		bool horizontal = movementAxis == MovementAxis.Horizontal || movementType == MovementType.Free;
		scrollRect.m_Horizontal = horizontal;
		bool vertical = movementAxis == MovementAxis.Vertical || movementType == MovementType.Free;
		scrollRect.m_Vertical = vertical;
	}

	public void GoToPanel(int panelNumber)
	{
		//IL_0027: Expected Obj, but got I4
		//IL_0059: Expected Obj, but got I
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected Obj, but got Unknown
		//IL_00bd: Expected Obj, but got I
		//IL_0102: Expected Obj, but got I
		selected = true;
		TargetPanel__BackingField = panelNumber;
		onPanelSelected.Invoke();
		if (pagination != null)
		{
			object obj = 0;
			while (true)
			{
				Toggle[] array = Toggles__BackingField;
				if ((nint)obj >= array.Length)
				{
					break;
				}
				object obj2 = obj << 2;
				object obj3 = (object)array + obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v27+10]");
				if ((UnityEngine.Object)0 != null)
				{
					object obj4 = obj << 2;
					object obj5 = (object)Toggles__BackingField + obj4;
					bool isOn = (nint)obj == TargetPanel__BackingField;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v38+10]");
					((Toggle)0).isOn = isOn;
					object obj6 = obj << 2;
					object obj7 = (object)Toggles__BackingField + obj6;
					bool interactable = (nint)obj != TargetPanel__BackingField;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v42+10]");
					((Selectable)0).interactable = interactable;
				}
				object obj8 = obj + 1;
				obj = obj8;
			}
		}
		if (~(hardSnap ? 1u : 0u) == 0)
		{
			ScrollRect scrollRect = this.scrollRect;
			scrollRect.m_Inertia = false;
		}
	}

	public void GoToPreviousPanel()
	{
		int num = (NearestPanel__BackingField = DetermineNearestPanel());
		int panelNumber;
		if (num == 0)
		{
			bool flag = (byte)(~(infinitelyScroll ? 1u : 0u)) != 0;
			panelNumber = 0;
			if (flag)
			{
				goto IL_007a;
			}
			num = NumberOfPanels;
		}
		panelNumber = num - 1;
		goto IL_007a;
		IL_007a:
		GoToPanel(panelNumber);
	}

	public void GoToNextPanel()
	{
		//IL_0031: Expected Obj, but got I4
		int num = (NearestPanel__BackingField = DetermineNearestPanel());
		int numberOfPanels = NumberOfPanels;
		object obj = numberOfPanels - 1;
		int panelNumber;
		if (num != (nint)obj)
		{
			panelNumber = NearestPanel__BackingField + 1;
		}
		else
		{
			panelNumber = 0;
			if (!infinitelyScroll)
			{
				panelNumber = NearestPanel__BackingField;
			}
		}
		GoToPanel(panelNumber);
	}

	public void AddToFront(GameObject panel)
	{
		Add(panel, 0);
	}

	public void AddToBack(GameObject panel)
	{
		int numberOfPanels = NumberOfPanels;
		Add(panel, numberOfPanels);
	}

	public unsafe void Add(GameObject panel, int index)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0130: Expected VT, but got Obj
		//IL_013e: Expected Obj, but got VT
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		if (NumberOfPanels != 0)
		{
			if (index >= 0)
			{
				int numberOfPanels = NumberOfPanels;
				if (numberOfPanels >= index)
				{
					goto IL_00d3;
				}
			}
			int numberOfPanels2 = NumberOfPanels;
			int num = obj + 12;
			string text = ((int*)num)->ToString();
			string message = "<b>[SimpleScrollSnap]</b> Index must be an integer from 0 to " + text + ".";
			GameObject context = gameObject;
			Debug.LogError(message, context);
			return;
		}
		goto IL_00d3;
		IL_00d3:
		if (~(automaticallyLayout ? 1u : 0u) != 0)
		{
			Debug.LogError("<b>[SimpleScrollSnap]</b> \"Automatic Layout\" must be enabled for content to be dynamically added during runtime.");
			return;
		}
		ScrollRect scrollRect = this.scrollRect;
		_0021_00210 val = (_0021_00210)UnityEngine.Object.Instantiate<T>((T)(object)panel, (Transform)scrollRect.m_Content, false);
		Transform transform = ((GameObject)val).transform;
		transform.SetSiblingIndex(index);
		Initialize();
		if (Validate())
		{
			int num2 = ((index >= TargetPanel__BackingField) ? TargetPanel__BackingField : (TargetPanel__BackingField + 1));
			startingPanel = num2;
			Setup();
		}
	}

	public void RemoveFromFront()
	{
		Remove(0);
	}

	public void RemoveFromBack()
	{
		int numberOfPanels = NumberOfPanels;
		int index;
		if (numberOfPanels < 1)
		{
			index = 0;
		}
		else
		{
			int numberOfPanels2 = NumberOfPanels;
			index = numberOfPanels2 - 1;
		}
		Remove(index);
	}

	public void Remove(int index)
	{
		//IL_003a: Expected Obj, but got I4
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected Obj, but got Unknown
		//IL_009d: Expected Obj, but got I
		int numberOfPanels = NumberOfPanels;
		if (index < 0 || numberOfPanels == 0)
		{
			return;
		}
		int numberOfPanels2 = NumberOfPanels;
		object obj = numberOfPanels2 - 1;
		if (index > (nint)obj || ~(automaticallyLayout ? 1u : 0u) != 0)
		{
			return;
		}
		int num = index << 2;
		object obj2 = Panels__BackingField + num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v19+10]");
		UnityEngine.Object.DestroyImmediate((UnityEngine.Object)0);
		Initialize();
		if (!Validate())
		{
			return;
		}
		int num2;
		int num3;
		if (index == TargetPanel__BackingField)
		{
			int numberOfPanels3 = NumberOfPanels;
			bool flag = index == numberOfPanels3;
			num2 = TargetPanel__BackingField;
			if (flag)
			{
				goto IL_016a;
			}
			num3 = TargetPanel__BackingField;
		}
		else
		{
			bool flag2 = index > TargetPanel__BackingField;
			num2 = TargetPanel__BackingField;
			num3 = TargetPanel__BackingField;
			if (!flag2)
			{
				goto IL_016a;
			}
		}
		goto IL_01ad;
		IL_016a:
		int num4 = num2 - 1;
		num3 = num4;
		goto IL_01ad;
		IL_01ad:
		startingPanel = num3;
		Setup();
	}

	public void AddVelocity(Vector2 velocity)
	{
		//IL_004d: Expected Obj, but got F4
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected VT, but got Unknown
		ScrollRect scrollRect = this.scrollRect;
		float num = (float)scrollRect.m_Velocity + velocity.x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ S0_v2 (UnityEngine.UI.ScrollRect)+90]");
		float num2 = 0f + velocity.y;
		object obj = num2 << 32;
		Vector2 vector = (Vector2)(num | obj);
		scrollRect.m_Velocity = vector;
		selected = false;
	}

	public SimpleScrollSnap()
	{
		//IL_007a: Expected I4, but got I8
		_ = 4503599628502564864L;
		List<TransitionEffect> list = default;
		list._002Ector();
		transitionEffects = list;
		selected = true;
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v55 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Int32, UnityEngine.UI.Graphic[]>>>)+4] (should have been resolved before IL gen)");
		Dictionary<int, Graphic[]> dictionary = default;
		panelGraphics = dictionary;
		base._002Ector();
	}
}
