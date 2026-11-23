using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

public class UIDragDropItem : MonoBehaviour
{
	public enum Restriction
	{
		None,
		Horizontal,
		Vertical,
		PressAndHold
	}

	private sealed class _003CEnableDragScrollView_003Ed__34(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public UIDragDropItem _003C_003E4__this;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					UIDragDropItem uIDragDropItem = _003C_003E4__this;
					if (uIDragDropItem.mDragScrollView != null)
					{
						uIDragDropItem.mDragScrollView.enabled = true;
					}
				}
				return false;
			}
			_003C_003E1__state = -1;
			object obj = default;
			_003C_003E2__current = obj;
			_003C_003E1__state = 1;
			return true;
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

	public Restriction restriction;

	public bool cloneOnDrag;

	public float pressAndHoldDelay = 1f;

	public bool interactable = true;

	[NonSerialized]
	protected Transform mTrans;

	[NonSerialized]
	protected Transform mParent;

	[NonSerialized]
	protected Collider mCollider;

	[NonSerialized]
	protected Collider2D mCollider2D;

	[NonSerialized]
	protected UIButton mButton;

	[NonSerialized]
	protected UIRoot mRoot;

	[NonSerialized]
	protected UIGrid mGrid;

	[NonSerialized]
	protected UITable mTable;

	[NonSerialized]
	protected float mDragStartTime;

	[NonSerialized]
	protected UIDragScrollView mDragScrollView;

	[NonSerialized]
	protected bool mPressed;

	[NonSerialized]
	protected bool mDragging;

	[NonSerialized]
	protected UICamera.MouseOrTouch mTouch;

	public static List<UIDragDropItem> draggedItems;

	protected virtual void Awake()
	{
		Transform transform = base.transform;
		mTrans = transform;
		GameObject gameObject = base.gameObject;
		Collider component = gameObject.GetComponent<Collider>();
		mCollider = component;
		GameObject gameObject2 = base.gameObject;
		Collider2D component2 = gameObject2.GetComponent<Collider2D>();
		mCollider2D = component2;
	}

	protected virtual void OnEnable()
	{
	}

	protected virtual void OnDisable()
	{
		//IL_003c: Expected I, but got Obj
		if (~(mDragging ? 1u : 0u) == 0)
		{
			GameObject hoveredObject = UICamera.hoveredObject;
			if (~(mDragging ? 1u : 0u) == 0)
			{
				mDragging = false;
				nint num = (nint)this;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v43 @ S2_v3 (Il2CppClass<UIDragDropItem>)+13C] (should have been resolved before IL gen)");
			}
		}
	}

	protected virtual void Start()
	{
		UIButton component = GetComponent<UIButton>();
		mButton = component;
		UIDragScrollView component2 = GetComponent<UIDragScrollView>();
		mDragScrollView = component2;
	}

	protected virtual void OnPress(bool isPressed)
	{
		if (~(interactable ? 1u : 0u) != 0 || UICamera.currentTouchID == -2 || UICamera.currentTouchID == -3)
		{
			return;
		}
		if (isPressed)
		{
			if (!mPressed)
			{
				mTouch = UICamera.currentTouch;
				float unscaledTime = Time.unscaledTime;
				float num = unscaledTime + pressAndHoldDelay;
				mPressed = true;
				mDragStartTime = num;
			}
		}
		else if (~(mPressed ? 1u : 0u) == 0 && mTouch == UICamera.currentTouch)
		{
			mTouch = null;
			mPressed = false;
		}
	}

	protected virtual void Update()
	{
		//IL_0082: Expected I, but got Obj
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		if (restriction == Restriction.PressAndHold && ~(mPressed ? 1u : 0u) == 0 && !mDragging)
		{
			float unscaledTime = Time.unscaledTime;
			if (mDragStartTime < unscaledTime)
			{
				nint num = (nint)this;
				object obj = this + 88;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v29 @ S1_v6 (Il2CppClass<UIDragDropItem>)+114] (should have been resolved before IL gen)");
			}
		}
	}

	protected virtual void OnDragStart()
	{
		//IL_005a: Expected Obj, but got I4
		//IL_00d0: Expected F4, but got VT
		//IL_00e5: Expected F4, but got I
		//IL_0171: Expected I, but got Obj
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected Obj, but got Unknown
		//IL_0132: Expected F4, but got VT
		//IL_0147: Expected F4, but got I
		if (~(interactable ? 1u : 0u) != 0 || !enabled || mTouch != UICamera.currentTouch)
		{
			return;
		}
		object obj = restriction - 1;
		if (restriction != Restriction.Horizontal)
		{
			if ((nint)obj != 1)
			{
				if ((nint)obj == 2)
				{
					return;
				}
			}
			else
			{
				UICamera.MouseOrTouch mouseOrTouch = mTouch;
				float num = Math.Abs((float)mouseOrTouch.totalDelta);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v30 (UICamera+MouseOrTouch)+28]");
				float num2 = Math.Abs(0f);
				if (num > num2)
				{
					return;
				}
			}
		}
		else
		{
			UICamera.MouseOrTouch mouseOrTouch2 = mTouch;
			float num3 = Math.Abs((float)mouseOrTouch2.totalDelta);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v24 (UICamera+MouseOrTouch)+28]");
			float num4 = Math.Abs(0f);
			if (num3 < num4)
			{
				return;
			}
		}
		nint num5 = (nint)this;
		object obj2 = this + 88;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v75 @ S1_v11 (Il2CppClass<UIDragDropItem>)+114] (should have been resolved before IL gen)");
	}

	public unsafe virtual void StartDragging()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_03fa: Expected I, but got Obj
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		//IL_0405: Expected Obj, but got Unknown
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected VT, but got Unknown
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected VT, but got Unknown
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected VT, but got Unknown
		//IL_0460: Expected I, but got Obj
		//IL_0469: Unknown result type (might be due to invalid IL or missing references)
		//IL_046e: Expected Obj, but got Unknown
		//IL_0480: Expected I, but got Obj
		//IL_0489: Unknown result type (might be due to invalid IL or missing references)
		//IL_048e: Expected Obj, but got Unknown
		//IL_04e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e6: Expected Obj, but got Unknown
		//IL_0283: Expected F4, but got I
		//IL_027e: Expected native int or pointer, but got VT
		//IL_02a5: Expected F4, but got I
		//IL_02a0: Expected native int or pointer, but got VT
		//IL_03bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c4: Expected Obj, but got Unknown
		object obj = default;
		Color color = (Color)(obj - 144);
		if (~(interactable ? 1u : 0u) != 0 || mDragging)
		{
			return;
		}
		if (~(cloneOnDrag ? 1u : 0u) == 0)
		{
			mPressed = false;
			Transform transform = base.transform;
			Transform parent = transform.parent;
			GameObject parent2 = parent.gameObject;
			GameObject prefab = base.gameObject;
			GameObject gameObject = NGUITools.AddChild(parent2, prefab);
			Transform transform2 = gameObject.transform;
			Transform transform3 = base.transform;
			Vector3 localPosition = transform3.localPosition;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+78]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+78]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+70]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+70]");
			_ = 0;
			Vector3 localPosition2 = (Vector3)(color + 48);
			transform2.localPosition = localPosition2;
			Transform transform4 = gameObject.transform;
			Transform transform5 = base.transform;
			Quaternion localRotation = transform5.localRotation;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+78]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+78]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+70]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+70]");
			_ = 0;
			Quaternion localRotation2 = (Quaternion)(color + 32);
			transform4.localRotation = localRotation2;
			Transform transform6 = gameObject.transform;
			Transform transform7 = base.transform;
			Vector3 localScale = transform7.localScale;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+78]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+78]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+70]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+70]");
			_ = 0;
			Vector3 localScale2 = (Vector3)(color + 16);
			transform6.localScale = localScale2;
			UIButtonColor component = gameObject.GetComponent<UIButtonColor>();
			if (component != null)
			{
				UIButtonColor component2 = GetComponent<UIButtonColor>();
				Color defaultColor = component2.defaultColor;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+78]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+78]");
				((Color*)(nint)color)->b = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+70]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+70]");
				((Color*)(nint)color)->r = 0f;
				component.defaultColor = color;
			}
			UICamera.MouseOrTouch mouseOrTouch = mTouch;
			if (mTouch != null)
			{
				GameObject gameObject2 = base.gameObject;
				if (mouseOrTouch.pressed == gameObject2)
				{
					UICamera.MouseOrTouch mouseOrTouch2 = mTouch;
					mouseOrTouch2.current = gameObject;
					UICamera.MouseOrTouch mouseOrTouch3 = mTouch;
					mouseOrTouch3.pressed = gameObject;
					UICamera.MouseOrTouch mouseOrTouch4 = mTouch;
					mouseOrTouch4.dragged = gameObject;
					UICamera.MouseOrTouch mouseOrTouch5 = mTouch;
					mouseOrTouch5.last = gameObject;
				}
			}
			UIDragDropItem component3 = gameObject.GetComponent<UIDragDropItem>();
			component3.mTouch = mTouch;
			component3.mPressed = true;
			nint num = (nint)component3;
			object obj2 = component3 + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v257 @ S1_v63 (Il2CppClass<UIDragDropItem>)+F4] (should have been resolved before IL gen)");
			nint num2 = (nint)component3;
			object obj3 = component3 + 112;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v267 @ S1_v67 (Il2CppClass<UIDragDropItem>)+12C] (should have been resolved before IL gen)");
			if (UICamera.currentTouch == null)
			{
				UICamera.currentTouch = mTouch;
			}
			mTouch = null;
			GameObject go = base.gameObject;
			_ = 0;
			object obj4 = color + 112;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			object obj5 = default;
			UICamera.Notify(go, "OnPress", obj5);
			GameObject go2 = base.gameObject;
			_ = 0;
			object obj6 = color + 63;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			object obj7 = default;
			UICamera.Notify(go2, "OnHover", obj7);
		}
		else
		{
			mDragging = true;
			nint num3 = (nint)this;
			object obj8 = this + 112;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v73 @ S1_v7 (Il2CppClass<UIDragDropItem>)+12C] (should have been resolved before IL gen)");
		}
	}

	protected virtual void OnDrag(Vector2 delta)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00b6: Expected Obj, but got F4
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		if (~(interactable ? 1u : 0u) == 0 && ~(mDragging ? 1u : 0u) == 0 && enabled && mTouch == UICamera.currentTouch)
		{
			float pixelSizeAdjustment = mRoot.pixelSizeAdjustment;
			float num = delta.x * pixelSizeAdjustment;
			float num2 = delta.y * pixelSizeAdjustment;
			object obj3 = num2 << 32;
			object obj4 = num | obj3;
			obj = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @684");
		}
	}

	protected virtual void OnDragEnd()
	{
		//IL_0081: Expected I, but got Obj
		if (~(interactable ? 1u : 0u) == 0 && enabled && mTouch == UICamera.currentTouch)
		{
			GameObject hoveredObject = UICamera.hoveredObject;
			if (~(mDragging ? 1u : 0u) == 0)
			{
				mDragging = false;
				nint num = (nint)this;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v58 @ S2_v3 (Il2CppClass<UIDragDropItem>)+13C] (should have been resolved before IL gen)");
			}
		}
	}

	public void StopDragging(GameObject go)
	{
		//IL_0029: Expected I, but got Obj
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		if (~(mDragging ? 1u : 0u) == 0)
		{
			mDragging = false;
			nint num = (nint)this;
			object obj = this + 128;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v10 @ S2_v3 (Il2CppClass<UIDragDropItem>)+13C] (should have been resolved before IL gen)");
		}
	}

	protected unsafe virtual void OnDragDropStart()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00a6: Expected I, but got Obj
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected Obj, but got Unknown
		//IL_0223: Expected F4, but got I
		//IL_021e: Expected native int or pointer, but got VT
		//IL_0245: Expected F4, but got I
		//IL_0240: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 48);
		if (!draggedItems.Contains(this))
		{
			draggedItems.Add(this);
		}
		if (mDragScrollView != null)
		{
			mDragScrollView.enabled = false;
		}
		if (mButton != null)
		{
			UIButton uIButton = mButton;
			nint num = (nint)uIButton;
			object obj2 = uIButton + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v81 @ S2_v37 (Il2CppClass<UIButton>)+E4] (should have been resolved before IL gen)");
		}
		else if (mCollider != null)
		{
			mCollider.enabled = false;
		}
		else if (mCollider2D != null)
		{
			mCollider2D.enabled = false;
		}
		Transform parent = mTrans.parent;
		mParent = parent;
		UIRoot uIRoot = NGUITools.FindInParents<UIRoot>(mParent);
		mRoot = uIRoot;
		UIGrid uIGrid = NGUITools.FindInParents<UIGrid>(mParent);
		mGrid = uIGrid;
		UITable uITable = NGUITools.FindInParents<UITable>(mParent);
		mTable = uITable;
		if (UIDragDropRoot.root != null)
		{
			mTrans.parent = UIDragDropRoot.root;
		}
		Vector3 localPosition = mTrans.localPosition;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
		((Vector3*)(nint)vector)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
		((Vector3*)(nint)vector)->x = 0f;
		mTrans.localPosition = vector;
		TweenPosition component = GetComponent<TweenPosition>();
		if (component != null)
		{
			component.enabled = false;
		}
		SpringPosition component2 = GetComponent<SpringPosition>();
		if (component2 != null)
		{
			component2.enabled = false;
		}
		GameObject go = gameObject;
		NGUITools.MarkParentAsChanged(go);
		if (mTable != null)
		{
			mTable.repositionNow = true;
		}
		if (mGrid != null)
		{
			mGrid.repositionNow = true;
		}
	}

	protected unsafe virtual void OnDragDropMove(Vector2 delta)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0087: Expected F4, but got I
		//IL_0082: Expected native int or pointer, but got VT
		//IL_00a6: Expected F4, but got I
		//IL_00a1: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 48);
		Vector3 localPosition = mTrans.localPosition;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
		float num = 0f + delta.x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
		float num2 = 0f + delta.y;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
		float num3 = 0f + 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
		((Vector3*)(nint)vector)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
		((Vector3*)(nint)vector)->x = 0f;
		mTrans.localPosition = vector;
	}

	protected unsafe virtual void OnDragDropRelease(GameObject surface)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0053: Expected I, but got Obj
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_0157: Expected Obj, but got I
		//IL_0189: Expected Obj, but got I
		//IL_01de: Expected F4, but got I
		//IL_01d9: Expected native int or pointer, but got VT
		//IL_0200: Expected F4, but got I
		//IL_01fb: Expected native int or pointer, but got VT
		//IL_036d: Expected I, but got Obj
		//IL_0373: Unknown result type (might be due to invalid IL or missing references)
		//IL_0378: Expected Obj, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj - 48);
		if (~(cloneOnDrag ? 1u : 0u) != 0)
		{
			if (mButton != null)
			{
				UIButton uIButton = mButton;
				nint num = (nint)uIButton;
				object obj2 = uIButton + 40;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v47 @ S2_v36 (Il2CppClass<UIButton>)+E4] (should have been resolved before IL gen)");
			}
			else if (mCollider != null)
			{
				mCollider.enabled = true;
			}
			else if (mCollider2D != null)
			{
				mCollider2D.enabled = true;
			}
			bool flag = surface;
			bool flag2 = !flag;
			UnityEngine.Object obj3 = null;
			if (!flag2)
			{
				UIDragDropContainer uIDragDropContainer = NGUITools.FindInParents<UIDragDropContainer>(surface);
				obj3 = uIDragDropContainer;
			}
			if (obj3 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ L3_v5 (UnityEngine.Object)+C]");
				Transform parent;
				if ((UnityEngine.Object)0 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ L3_v5 (UnityEngine.Object)+C]");
					parent = (Transform)0;
				}
				else
				{
					parent = ((Component)obj3).transform;
				}
				mTrans.parent = parent;
				Vector3 localPosition = mTrans.localPosition;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
				((Vector3*)(nint)vector)->z = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
				((Vector3*)(nint)vector)->x = 0f;
				mTrans.localPosition = vector;
			}
			else
			{
				mTrans.parent = mParent;
			}
			Transform parent2 = mTrans.parent;
			mParent = parent2;
			UIGrid uIGrid = NGUITools.FindInParents<UIGrid>(mParent);
			mGrid = uIGrid;
			UITable uITable = NGUITools.FindInParents<UITable>(mParent);
			mTable = uITable;
			if (mDragScrollView != null)
			{
				IEnumerator routine = EnableDragScrollView();
				Coroutine coroutine = StartCoroutine(routine);
			}
			GameObject go = gameObject;
			NGUITools.MarkParentAsChanged(go);
			if (mTable != null)
			{
				mTable.repositionNow = true;
			}
			if (mGrid != null)
			{
				mGrid.repositionNow = true;
			}
			nint num2 = (nint)this;
			object obj4 = this + 136;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v287 @ S1_v30 (Il2CppClass<UIDragDropItem>)+144] (should have been resolved before IL gen)");
		}
		else
		{
			GameObject obj5 = gameObject;
			NGUITools.Destroy(obj5);
		}
	}

	protected virtual void OnDragDropEnd()
	{
		bool flag = draggedItems.Remove(this);
	}

	protected IEnumerator EnableDragScrollView()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	static UIDragDropItem()
	{
		List<UIDragDropItem> list = default;
		list._002Ector();
		draggedItems = list;
	}
}
