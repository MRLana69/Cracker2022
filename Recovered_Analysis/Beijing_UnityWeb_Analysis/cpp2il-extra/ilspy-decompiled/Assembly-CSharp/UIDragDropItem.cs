using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Kiloo.Integration.Google;
using Kiloo.Monetization.FlurryPlugin;
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

	public Restriction restriction;

	public bool cloneOnDrag;

	public float pressAndHoldDelay;

	public bool interactable;

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
		CancelInvoke();
	}

	protected virtual void OnEnable()
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected Obj, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected Obj, but got Unknown
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected Obj, but got Unknown
		object obj = this + 28;
		GameObject gameObject = base.gameObject;
		obj = gameObject;
		object obj2 = this + 36;
		string text = tag;
		Collider component = ((GameObject)(object)text).GetComponent<Collider>();
		obj2 = component;
		object obj3 = this + 40;
		string text2 = tag;
		Collider2D component2 = ((GameObject)(object)text2).GetComponent<Collider2D>();
		obj3 = component2;
	}

	protected virtual void OnDisable()
	{
	}

	protected virtual void Start()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_00c0: Expected VT, but got Obj
		//IL_0054: Expected I, but got Obj
		if (~(mDragging ? 1u : 0u) != 0)
		{
			return;
		}
		nint num = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v9 (Il2CppClass<UICamera>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v14 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		GameObject controllerNavigationObject = UICamera.controllerNavigationObject;
		OnDragDropMove((Vector2)controllerNavigationObject);
	}

	protected unsafe virtual void OnPress(bool isPressed)
	{
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected Obj, but got Unknown
		//IL_001d: Expected I, but got Obj
		//IL_0033: Expected Obj, but got I
		//IL_005e: Expected I, but got Obj
		//IL_00ab: Expected I, but got Obj
		//IL_00c1: Expected Obj, but got I
		//IL_01e2: Expected Obj, but got I4
		//IL_00ec: Expected I, but got Obj
		//IL_0136: Expected Obj, but got I4
		//IL_0160: Expected Obj, but got I4
		object obj = default;
		UIDragObject uIDragObject = (UIDragObject)(obj + 8);
		if (!isActiveAndEnabled)
		{
			return;
		}
		string fileName = tag;
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S1_v8 (Il2CppClass<NGUITools>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S1_v27 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		byte[] array = NGUITools.Load(fileName);
		if (array == null)
		{
			return;
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S1_v14 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S1_v23 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)restriction).FindKernel(null) != 0 && ((Behaviour)restriction).isActiveAndEnabled)
		{
			obj = ((bool*)(isPressed ? 1 : 0))->m_value;
			uIDragObject = (UIDragObject)obj;
			Vector3 dragMovement = uIDragObject.dragMovement;
		}
	}

	protected virtual void Update()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected Obj, but got Unknown
		//IL_003f: Expected Obj, but got VT
		object obj = this + 44;
		UIButton component = GetComponent<UIButton>();
		obj = component;
		object obj2 = this - -64;
		_0021_00210 componentInChildren = (_0021_00210)((Component)this).GetComponentInChildren<T>();
		obj2 = componentInChildren;
	}

	protected virtual void OnDragStart()
	{
		if (restriction == Restriction.PressAndHold && ~(mPressed ? 1u : 0u) == 0 && ~(mDragging ? 1u : 0u) != 0)
		{
			float unscaledDeltaTime = Time.unscaledDeltaTime;
			if (mDragStartTime < unscaledDeltaTime)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
			}
		}
	}

	public virtual void StartDragging()
	{
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Expected Obj, but got Unknown
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Expected Obj, but got Unknown
		//IL_0036: Expected I, but got Obj
		//IL_004c: Expected Obj, but got I
		//IL_0077: Expected I, but got Obj
		//IL_0219: Expected Obj, but got VT
		//IL_022f: Expected I, but got Obj
		//IL_0245: Expected Obj, but got I
		//IL_0116: Expected Obj, but got VT
		//IL_012c: Expected I, but got Obj
		//IL_0142: Expected Obj, but got I
		//IL_0380: Expected F4, but got Obj
		//IL_0395: Expected F4, but got I
		//IL_031f: Expected F4, but got Obj
		//IL_0334: Expected F4, but got I
		//IL_0270: Expected I, but got Obj
		//IL_016d: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		object obj3 = obj2 + 8;
		if (~(interactable ? 1u : 0u) != 0 || !isActiveAndEnabled)
		{
			return;
		}
		nint num = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S1_v8 (Il2CppClass<UICamera>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S1_v56 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (mTouch != UICamera.currentTouch)
		{
			return;
		}
		if (restriction != Restriction.None)
		{
			if (restriction == Restriction.Horizontal)
			{
				UICamera.MouseOrTouch mouseOrTouch = mTouch;
				obj = mouseOrTouch.totalDelta;
				obj3 = obj;
				nint num3 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S1_v44 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num4 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S1_v52 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj2 = obj;
				float num5 = Math.Abs((float)obj3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
				float num6 = Math.Abs(0f);
				if (num5 < num6)
				{
					return;
				}
			}
			else if (restriction != Restriction.Vertical)
			{
				if (restriction == Restriction.PressAndHold)
				{
					return;
				}
			}
			else
			{
				UICamera.MouseOrTouch mouseOrTouch2 = mTouch;
				obj = mouseOrTouch2.totalDelta;
				obj3 = obj;
				nint num7 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S1_v25 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num8 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S1_v33 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj2 = obj;
				float num9 = Math.Abs((float)obj3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
				float num10 = Math.Abs(0f);
				if (num9 > num10)
				{
					return;
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
	}

	protected virtual void OnClone(GameObject original)
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_00b7: Expected Obj, but got I
		//IL_00e2: Expected I, but got Obj
		//IL_0215: Expected I, but got Obj
		//IL_022b: Expected Obj, but got I
		//IL_016e: Expected I, but got Obj
		//IL_0184: Expected Obj, but got I
		//IL_0256: Expected I, but got Obj
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Expected Obj, but got Unknown
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Expected Obj, but got Unknown
		//IL_02b4: Expected Obj, but got I4
		//IL_01af: Expected I, but got Obj
		if (~(interactable ? 1u : 0u) != 0)
		{
			return;
		}
		nint num = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v9 (Il2CppClass<UICamera>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v59 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (UICamera.currentTouchID == -2)
		{
			return;
		}
		nint num3 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v18 (Il2CppClass<UICamera>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v53 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (UICamera.currentTouchID == -3)
		{
			return;
		}
		bool flag = mPressed;
		if ((object)original != null)
		{
			if (flag)
			{
				return;
			}
			nint num5 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v39 (Il2CppClass<UICamera>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v47 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj4 = this + 72;
			obj4 = UICamera.currentTouch;
			float unscaledDeltaTime = Time.unscaledDeltaTime;
			float num7 = unscaledDeltaTime + pressAndHoldDelay;
			mDragStartTime = num7;
			mPressed = true;
		}
		else
		{
			if (!flag)
			{
				return;
			}
			nint num8 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S1_v9 (Il2CppClass<UICamera>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num9 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S1_v19 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (mTouch == UICamera.currentTouch)
			{
				mPressed = false;
				object obj6 = this + 72;
				obj6 = 0;
			}
		}
	}

	protected virtual void OnDrag(Vector2 delta)
	{
	}

	protected virtual void OnDragEnd()
	{
		//IL_05f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f5: Expected Obj, but got Unknown
		//IL_05fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0603: Expected Obj, but got Unknown
		//IL_060c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0611: Expected Obj, but got Unknown
		//IL_00b8: Expected I, but got Obj
		//IL_00ce: Expected Obj, but got I
		//IL_0638: Expected I4, but got Obj
		//IL_0645: Expected Obj, but got I4
		//IL_0145: Expected VT, but got Obj
		//IL_00f9: Expected I, but got Obj
		//IL_017a: Expected Obj, but got I4
		//IL_019a: Expected VT, but got Obj
		//IL_01cf: Expected Obj, but got I4
		//IL_01ef: Expected VT, but got Obj
		//IL_0216: Expected Obj, but got I4
		//IL_0224: Expected Obj, but got I4
		//IL_0236: Expected I, but got Obj
		//IL_024c: Expected Obj, but got I
		//IL_0277: Expected I, but got Obj
		//IL_068c: Expected Obj, but got I4
		//IL_0699: Unknown result type (might be due to invalid IL or missing references)
		//IL_069e: Expected Obj, but got Unknown
		//IL_033f: Expected I, but got Obj
		//IL_0355: Expected Obj, but got I
		//IL_02f9: Expected I4, but got Obj
		//IL_044b: Expected I, but got Obj
		//IL_0461: Expected Obj, but got I
		//IL_0380: Expected I, but got Obj
		//IL_0784: Unknown result type (might be due to invalid IL or missing references)
		//IL_0789: Expected Obj, but got Unknown
		//IL_0792: Expected Obj, but got I4
		//IL_07a5: Expected Obj, but got I4
		//IL_07bd: Expected I, but got Obj
		//IL_07d3: Expected Obj, but got I
		//IL_048c: Expected I, but got Obj
		//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cf: Expected Obj, but got Unknown
		//IL_03d7: Expected Obj, but got I4
		//IL_03e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e7: Expected Obj, but got Unknown
		//IL_03ef: Expected Obj, but got I4
		//IL_03fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ff: Expected Obj, but got Unknown
		//IL_0407: Expected Obj, but got I4
		//IL_0412: Unknown result type (might be due to invalid IL or missing references)
		//IL_0417: Expected Obj, but got Unknown
		//IL_041f: Expected Obj, but got I4
		//IL_075c: Expected I4, but got Obj
		//IL_076f: Expected Obj, but got I4
		//IL_04d9: Expected I, but got Obj
		//IL_04ef: Expected Obj, but got I
		//IL_050c: Expected I, but got Obj
		//IL_05e2: Expected I4, but got Obj
		//IL_0591: Expected I, but got Obj
		//IL_073b: Expected Obj, but got I
		//IL_0528: Expected I, but got Obj
		//IL_0558: Expected I, but got Obj
		//IL_057e: Expected I, but got Obj
		Transform transform2 = default;
		Transform transform = (Transform)(transform2 + 48);
		Transform transform3 = (Transform)(transform2 + 32);
		Transform transform4 = (Transform)(transform2 + 16);
		if (~(interactable ? 1u : 0u) != 0 || ~(mDragging ? 1u : 0u) == 0)
		{
			return;
		}
		if (~(cloneOnDrag ? 1u : 0u) != 0)
		{
			mDragging = true;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
			return;
		}
		mPressed = false;
		GameObject gameObject = base.gameObject;
		Transform parentInternal = ((Transform)(object)gameObject).parentInternal;
		string go = parentInternal.tag;
		string text = tag;
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S2_v4 (Il2CppClass<NGUITools>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S2_v57 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num3 = NGUITools.CalculateNextDepth((GameObject)(object)go, (byte)(int)text != 0);
		int layer = ((GameObject)num3).layer;
		GameObject gameObject2 = base.gameObject;
		transform3.localPosition = (Vector3)gameObject2;
		transform = transform3;
		((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)transform3).m_CachedPtr;
		Vector3 eulerAngles = transform.eulerAngles;
		int layer2 = ((GameObject)num3).layer;
		GameObject gameObject3 = base.gameObject;
		transform4.localRotation = (Quaternion)gameObject3;
		transform = transform4;
		((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)transform4).m_CachedPtr;
		Vector3 localScale = transform.localScale;
		int layer3 = ((GameObject)num3).layer;
		GameObject gameObject4 = base.gameObject;
		transform2.localScale = (Vector3)gameObject4;
		transform = transform2;
		((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)transform2).m_CachedPtr;
		((Transform)layer3).parent = transform;
		UIButtonColor component = ((GameObject)num3).GetComponent<UIButtonColor>();
		nint num4 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S0_v38 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S0_v114 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)component).FindKernel((string)null) != 0)
		{
			_0021_00210 componentInChildren = (_0021_00210)((Component)this).GetComponentInChildren<T>();
			((UIButtonColor)(object)transform3).defaultColor = (Color)componentInChildren;
			transform = transform3;
			((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)transform3).m_CachedPtr;
			component.isEnabled = (byte)(int)transform != 0;
		}
		if (mTouch != null)
		{
			UICamera.MouseOrTouch mouseOrTouch = mTouch;
			string text2 = tag;
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ S2_v44 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num7 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ S2_v49 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (mouseOrTouch.pressed != (UnityEngine.Object)(object)text2)
			{
				object obj4 = mTouch + 52;
				obj4 = num3;
				object obj5 = mTouch + 56;
				obj5 = num3;
				object obj6 = mTouch + 60;
				obj6 = num3;
				object obj7 = mTouch + 48;
				obj7 = num3;
			}
		}
		_0021_00210 componentInChildren2 = (_0021_00210)((GameObject)num3).GetComponentInChildren<T>();
		object obj8 = componentInChildren2 + 72;
		obj8 = mTouch;
		_ = 1;
		_ = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		string text3 = tag;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		nint num8 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ S0_v57 (Il2CppClass<UICamera>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num9 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ S0_v88 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (UICamera.currentTouch == null)
		{
			nint num10 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ S0_v75 (Il2CppClass<UICamera>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			bool flag = obj10 == null;
			nint num11 = (nint)typeof(UICamera);
			if (!flag)
			{
				nint num12 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ S0_v82 (Il2CppClass<UICamera>)+74]");
				bool flag2 = (nint)0 == 0;
				bool flag3 = !flag2;
				num11 = (nint)typeof(UICamera);
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num11 = (nint)typeof(UICamera);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ L1_v9 (Il2CppClass<UICamera>)+5C]");
			object obj11 = (nint)0 + (nint)160;
			obj11 = mTouch;
		}
		object obj12 = this + 72;
		obj12 = 0;
		string text4 = tag;
		transform = (Transform)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		nint num13 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ S1_v54 (Il2CppClass<UICamera>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num14 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ S1_v67 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool released = default;
		((UICamera)(object)text4).ProcessTouch((byte)(int)"OnPress" != 0, released);
		string text5 = tag;
		transform3 = (Transform)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		bool released2 = default;
		((UICamera)(object)text5).ProcessTouch((byte)(int)"OnHover" != 0, released2);
	}

	public unsafe void StopDragging(GameObject go = null)
	{
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Expected VT, but got Unknown
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Expected Obj, but got Unknown
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Expected Obj, but got Unknown
		//IL_004f: Expected I, but got Obj
		//IL_0065: Expected Obj, but got I
		//IL_0090: Expected I, but got Obj
		//IL_00dd: Expected I, but got Obj
		//IL_00f3: Expected Obj, but got I
		//IL_019e: Expected I, but got Obj
		//IL_01b4: Expected Obj, but got I
		//IL_011e: Expected I, but got Obj
		//IL_02d9: Expected F4, but got Obj
		//IL_02d4: Expected native int or pointer, but got VT
		//IL_02f7: Expected F4, but got Obj
		//IL_02f2: Expected native int or pointer, but got VT
		//IL_0172: Expected F4, but got Obj
		//IL_016d: Expected native int or pointer, but got VT
		//IL_01df: Expected I, but got Obj
		object obj = default;
		Vector2 vector = (Vector2)(obj + 24);
		object obj2 = obj + 16;
		object obj3 = obj + 8;
		if (~(interactable ? 1u : 0u) != 0 || ~(mDragging ? 1u : 0u) != 0 || !isActiveAndEnabled)
		{
			return;
		}
		nint num = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S1_v9 (Il2CppClass<UICamera>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S1_v41 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (mTouch != UICamera.currentTouch)
		{
			return;
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S1_v17 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S1_v37 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)mRoot).FindKernel((string)null) == 0)
		{
			obj = go;
			((Vector2*)(nint)vector)->x = (float)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8D6A");
			return;
		}
		float pixelSizeAdjustment = UIRoot.GetPixelSizeAdjustment((GameObject)(object)mRoot);
		nint num5 = (nint)typeof(Vector2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S0_v33 (Il2CppClass<UnityEngine.Vector2>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num6 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S0_v42 (Il2CppClass<UnityEngine.Vector2>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj2 = go;
		((Vector2*)(nint)vector)->x = (float)obj2;
		Vector2 vector2 = vector / pixelSizeAdjustment;
		((Vector2*)(nint)vector)->x = (float)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8D6A");
	}

	protected virtual void OnDragDropStart()
	{
		//IL_0036: Expected I, but got Obj
		//IL_004c: Expected Obj, but got I
		//IL_0077: Expected I, but got Obj
		//IL_00c4: Expected I, but got Obj
		//IL_00da: Expected Obj, but got I
		//IL_019a: Expected VT, but got Obj
		//IL_0105: Expected I, but got Obj
		if (~(interactable ? 1u : 0u) != 0 || !isActiveAndEnabled)
		{
			return;
		}
		nint num = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S1_v5 (Il2CppClass<UICamera>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S1_v15 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (mTouch != UICamera.currentTouch)
		{
			return;
		}
		nint num3 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v14 (Il2CppClass<UICamera>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v19 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		GameObject controllerNavigationObject = UICamera.controllerNavigationObject;
		OnDragDropMove((Vector2)controllerNavigationObject);
	}

	protected virtual void OnDragDropMove(Vector2 delta)
	{
		if (~(mDragging ? 1u : 0u) == 0)
		{
			mDragging = false;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		}
	}

	protected unsafe virtual void OnDragDropRelease(GameObject surface)
	{
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected Obj, but got Unknown
		//IL_00bc: Expected VT, but got Obj
		//IL_00ca: Expected I, but got Obj
		//IL_00e0: Expected Obj, but got I
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected VT, but got Unknown
		//IL_0120: Expected F4, but got Obj
		//IL_011b: Expected native int or pointer, but got VT
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected Obj, but got Unknown
		//IL_0148: Expected F4, but got Obj
		//IL_0143: Expected native int or pointer, but got VT
		//IL_015d: Expected F4, but got I
		//IL_0158: Expected native int or pointer, but got VT
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected Obj, but got Unknown
		//IL_018c: Expected I, but got Obj
		//IL_01a2: Expected Obj, but got I
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Expected VT, but got Unknown
		//IL_01da: Expected F4, but got Obj
		//IL_01d5: Expected native int or pointer, but got VT
		//IL_01ec: Expected F4, but got I
		//IL_01e7: Expected native int or pointer, but got VT
		//IL_01f9: Expected F4, but got Obj
		//IL_01f4: Expected native int or pointer, but got VT
		//IL_020e: Expected F4, but got I
		//IL_0209: Expected native int or pointer, but got VT
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected Obj, but got Unknown
		//IL_023a: Expected F4, but got Obj
		//IL_0235: Expected native int or pointer, but got VT
		//IL_024f: Expected F4, but got I
		//IL_024a: Expected native int or pointer, but got VT
		//IL_0258: Expected Obj, but got VT
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		object obj = default;
		Transform transform = (Transform)(obj + 44);
		transform.localPosition = (Vector3)mTrans;
		nint num = (nint)typeof(Vector2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v15 (Il2CppClass<UnityEngine.Vector2>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v48 (Il2CppClass<UnityEngine.Vector2>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj = surface;
		Vector4 vector = (Vector4)(obj + 68);
		((Vector4*)(nint)vector)->x = (float)obj;
		object obj3 = obj + 32;
		Vector3 vector2 = vector;
		((Vector4*)(nint)vector)->x = (float)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v23+8]");
		((Vector4*)(nint)vector)->z = 0f;
		object obj4 = obj + 20;
		Vector3 vector3 = mTrans.TransformPoint(vector);
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v29 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num4 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v44 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector4 = (Vector3)(obj + 56);
		((Vector3*)(nint)vector4)->x = (float)transform;
		((Vector3*)(nint)vector4)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
		((Vector4*)(nint)vector)->x = (float)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v27+8]");
		((Vector4*)(nint)vector)->z = 0f;
		object obj6 = obj + 8;
		Vector3 vector5 = vector4 - vector;
		((Vector4*)(nint)vector)->x = (float)obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v39+8]");
		((Vector4*)(nint)vector)->z = 0f;
		Vector3 eulerAngles = ((Transform)vector).eulerAngles;
	}

	protected virtual void DestroySelf()
	{
		//IL_07c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c8: Expected Obj, but got Unknown
		//IL_07d1: Expected Obj, but got I4
		//IL_07e5: Expected I, but got Obj
		//IL_07fb: Expected Obj, but got I
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected Obj, but got Unknown
		//IL_00f9: Expected I, but got Obj
		//IL_010f: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_01a1: Expected I, but got Obj
		//IL_01b7: Expected Obj, but got I
		//IL_013a: Expected I, but got Obj
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected Obj, but got Unknown
		//IL_00a1: Expected I, but got Obj
		//IL_023e: Expected I, but got Obj
		//IL_0254: Expected Obj, but got I
		//IL_01e2: Expected I, but got Obj
		//IL_02e1: Expected I, but got Obj
		//IL_02f7: Expected Obj, but got I
		//IL_027f: Expected I, but got Obj
		//IL_08b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b7: Expected Obj, but got Unknown
		//IL_08dc: Expected I, but got Obj
		//IL_08f2: Expected Obj, but got I
		//IL_0942: Unknown result type (might be due to invalid IL or missing references)
		//IL_0947: Expected Obj, but got Unknown
		//IL_0964: Unknown result type (might be due to invalid IL or missing references)
		//IL_0969: Expected Obj, but got Unknown
		//IL_0986: Unknown result type (might be due to invalid IL or missing references)
		//IL_098b: Expected Obj, but got Unknown
		//IL_0322: Expected I, but got Obj
		//IL_03d5: Expected I, but got Obj
		//IL_03eb: Expected Obj, but got I
		//IL_0380: Expected I, but got Obj
		//IL_0479: Expected VT, but got Obj
		//IL_049a: Unknown result type (might be due to invalid IL or missing references)
		//IL_049f: Expected Obj, but got Unknown
		//IL_0416: Expected I, but got Obj
		//IL_04e6: Expected I, but got Obj
		//IL_04fc: Expected Obj, but got I
		//IL_058d: Expected I, but got Obj
		//IL_05a3: Expected Obj, but got I
		//IL_0527: Expected I, but got Obj
		//IL_0634: Expected I, but got Obj
		//IL_064a: Expected Obj, but got I
		//IL_05ce: Expected I, but got Obj
		//IL_0a38: Expected I, but got Obj
		//IL_0a4e: Expected Obj, but got I
		//IL_0675: Expected I, but got Obj
		//IL_0724: Expected I, but got Obj
		//IL_073a: Expected Obj, but got I
		//IL_06c2: Expected I, but got Obj
		//IL_0711: Expected Obj, but got I4
		//IL_0765: Expected I, but got Obj
		//IL_07b4: Expected Obj, but got I4
		Transform transform = default;
		object obj = transform + 12;
		obj = 0;
		_ = 0;
		nint num = (nint)typeof(UIDragDropItem);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12 (Il2CppClass<UIDragDropItem>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UIDragDropItem);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v147 (Il2CppClass<UIDragDropItem>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!draggedItems.Contains(this))
		{
			nint num3 = (nint)typeof(UIDragDropItem);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v134 (Il2CppClass<UIDragDropItem>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(UIDragDropItem);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v141 (Il2CppClass<UIDragDropItem>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F73");
		}
		object obj4 = this - -64;
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S1_v11 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S1_v135 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)obj4).FindKernel((string)null) != 0)
		{
			object obj6 = this - -64;
			((Component)obj6).tag = null;
		}
		nint num7 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S0_v30 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num8 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v126 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)mButton).FindKernel((string)null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		}
		else
		{
			nint num9 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S1_v110 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num10 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S1_v127 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)mCollider).FindKernel((string)null) != 0)
			{
				mCollider.isTrigger = false;
			}
			else
			{
				nint num11 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ S1_v116 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj9 = (nint)0 & (nint)0x200;
				if (obj9 != null)
				{
					nint num12 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ S1_v122 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)(object)mCollider2D).FindKernel((string)null) != 0)
				{
					mCollider2D.tag = null;
				}
			}
		}
		object obj10 = this + 32;
		Transform parentInternal = mTrans.parentInternal;
		obj10 = parentInternal;
		nint num13 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ S0_v42 (Il2CppClass<NGUITools>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num14 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S0_v111 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj12 = this + 48;
		UIRoot uIRoot = NGUITools.FindInParents<UIRoot>(mParent);
		obj12 = uIRoot;
		object obj13 = this + 52;
		UIGrid uIGrid = NGUITools.FindInParents<UIGrid>(mParent);
		obj13 = uIGrid;
		object obj14 = this + 56;
		UITable uITable = NGUITools.FindInParents<UITable>(mParent);
		obj14 = uITable;
		nint num15 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ S1_v37 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj15 = (nint)0 & (nint)0x200;
		if (obj15 != null)
		{
			nint num16 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ S1_v105 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)UIDragDropRoot.root).FindKernel((string)null) != 0)
		{
			mTrans.parentInternal = UIDragDropRoot.root;
		}
		transform.localPosition = (Vector3)mTrans;
		obj = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		_ = 0f;
		Transform transform2 = (Transform)(transform + 24);
		transform2 = (Transform)obj;
		Transform transform3 = transform2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform2.eulerAngles;
		TweenPosition component = GetComponent<TweenPosition>();
		nint num17 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ S0_v67 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj16 = (nint)0 & (nint)0x200;
		if (obj16 != null)
		{
			nint num18 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ S0_v105 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)component).FindKernel((string)null) != 0)
		{
			component.tag = null;
		}
		SpringPosition component2 = GetComponent<SpringPosition>();
		nint num19 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ S0_v77 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj17 = (nint)0 & (nint)0x200;
		if (obj17 != null)
		{
			nint num20 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ S0_v100 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)component2).FindKernel((string)null) != 0)
		{
			component2.tag = null;
		}
		string clipboard = tag;
		nint num21 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ S1_v66 (Il2CppClass<NGUITools>)+BA]");
		object obj18 = (nint)0 & (nint)0x200;
		if (obj18 != null)
		{
			nint num22 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ S1_v95 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		NGUITools.clipboard = clipboard;
		nint num23 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ S1_v72 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj19 = (nint)0 & (nint)0x200;
		if (obj19 != null)
		{
			nint num24 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ S1_v91 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)mTable).FindKernel((string)null) != 0)
		{
			mTable.Sort((List<Transform>)1);
		}
		nint num25 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ S1_v79 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj20 = (nint)0 & (nint)0x200;
		if (obj20 != null)
		{
			nint num26 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ S1_v86 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)mGrid).FindKernel((string)null) != 0)
		{
			mGrid.AddChild((Transform)1);
		}
	}

	protected virtual void OnDragDropEnd()
	{
		//IL_006a: Expected I, but got Obj
		//IL_0080: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		string t = tag;
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S1_v4 (Il2CppClass<NGUITools>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v9 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		NGUITools.DestroyChildren((Transform)(object)t);
	}

	protected void EnableDragScrollView()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UIDragDropItem);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIDragDropItem>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIDragDropItem);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<UIDragDropItem>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10E8D");
	}

	protected void OnApplicationFocus(bool focus)
	{
		//IL_07c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ce: Expected Obj, but got Unknown
		//IL_07d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07dc: Expected Obj, but got Unknown
		//IL_07e5: Expected Obj, but got I4
		//IL_001b: Expected Obj, but got I
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected Obj, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		//IL_00bd: Expected I, but got Obj
		//IL_00d3: Expected Obj, but got I
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected Obj, but got Unknown
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected Obj, but got Unknown
		//IL_009c: Expected Obj, but got I4
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected Obj, but got Unknown
		//IL_015a: Expected I, but got Obj
		//IL_0170: Expected Obj, but got I
		//IL_00fe: Expected I, but got Obj
		//IL_01fd: Expected I, but got Obj
		//IL_0213: Expected Obj, but got I
		//IL_019b: Expected I, but got Obj
		//IL_089e: Expected I, but got Obj
		//IL_08b4: Expected Obj, but got I
		//IL_0b0f: Expected Obj, but got I4
		//IL_023e: Expected I, but got Obj
		//IL_0372: Expected VT, but got Obj
		//IL_02a0: Expected I, but got Obj
		//IL_028d: Expected Obj, but got I4
		//IL_091e: Expected I, but got Obj
		//IL_0934: Expected Obj, but got I
		//IL_02ed: Expected I, but got Obj
		//IL_0303: Expected Obj, but got I
		//IL_0b36: Expected Obj, but got VT
		//IL_0907: Expected Obj, but got I4
		//IL_090b: Expected VT, but got Obj
		//IL_0385: Expected I, but got Obj
		//IL_032e: Expected I, but got Obj
		//IL_0507: Unknown result type (might be due to invalid IL or missing references)
		//IL_050c: Expected Obj, but got Unknown
		//IL_0531: Expected I, but got Obj
		//IL_0547: Expected Obj, but got I
		//IL_03d2: Expected I, but got Obj
		//IL_03e8: Expected Obj, but got I
		//IL_098a: Unknown result type (might be due to invalid IL or missing references)
		//IL_098f: Expected Obj, but got Unknown
		//IL_09ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b1: Expected Obj, but got Unknown
		//IL_09ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d3: Expected Obj, but got Unknown
		//IL_09e1: Expected I, but got Obj
		//IL_09f7: Expected Obj, but got I
		//IL_0963: Expected Obj, but got I
		//IL_0572: Expected I, but got Obj
		//IL_0470: Expected Obj, but got VT
		//IL_0413: Expected I, but got Obj
		//IL_062b: Expected I, but got Obj
		//IL_0641: Expected Obj, but got I
		//IL_05bf: Expected I, but got Obj
		//IL_049f: Expected VT, but got Obj
		//IL_0462: Expected Obj, but got I
		//IL_0a56: Expected I, but got Obj
		//IL_0a6c: Expected Obj, but got I
		//IL_060e: Expected I4, but got Obj
		//IL_066c: Expected I, but got Obj
		//IL_071b: Expected I, but got Obj
		//IL_0731: Expected Obj, but got I
		//IL_06b9: Expected I, but got Obj
		//IL_0708: Expected Obj, but got I4
		//IL_075c: Expected I, but got Obj
		//IL_07ab: Expected Obj, but got I4
		Transform transform2 = default;
		Transform transform = (Transform)(transform2 + 24);
		object obj = transform2 + 12;
		obj = 0;
		_ = 0;
		if (~(cloneOnDrag ? 1u : 0u) != 0)
		{
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S2_v3 (Il2CppMethodInfo)+18]");
			object obj2 = 0;
			object obj3 = obj2;
			object obj4 = obj3 & 0x1FFF;
			object obj5 = obj4 + 22691;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v45 @ S3_v5 (should have been resolved before IL gen)");
			object obj7 = default;
			object obj6 = obj7 + 12;
			object obj8 = default;
			object obj11 = default;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6))
			{
				object obj9 = obj7 + 16;
				object obj10 = obj11 << 2;
				object obj12 = obj9 + obj10;
				object obj13 = obj12 + 12;
				obj13 = 0;
				obj8 = obj11 + 1;
			}
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S0_v32 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj14 = (nint)0 & (nint)0x200;
			if (obj14 != null)
			{
				nint num3 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S0_v141 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)mButton).FindKernel((string)null) != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
			}
			else
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S1_v111 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj15 = (nint)0 & (nint)0x200;
				if (obj15 != null)
				{
					nint num5 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S1_v128 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)(object)mCollider).FindKernel((string)null) != 0)
				{
					mCollider.isTrigger = true;
				}
				else
				{
					nint num6 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ S1_v117 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj16 = (nint)0 & (nint)0x200;
					if (obj16 != null)
					{
						nint num7 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ S1_v123 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (((ComputeShader)(object)mCollider2D).FindKernel((string)null) != 0)
					{
						mCollider2D.tag = (string)1;
					}
				}
			}
			nint num8 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ S0_v40 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj17 = (nint)0 & (nint)0x200;
			if (obj17 != null)
			{
				nint num9 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ S0_v126 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			_0021_00210 val;
			if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)focus))
			{
				nint num10 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ S0_v116 (Il2CppClass<NGUITools>)+BA]");
				object obj18 = (nint)0 & (nint)0x200;
				if (obj18 != null)
				{
					nint num11 = (nint)typeof(NGUITools);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ S0_v122 (Il2CppClass<NGUITools>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				val = (_0021_00210)NGUITools.FindInParents<T>((Transform)focus);
			}
			else
			{
				val = (_0021_00210)null;
			}
			nint num12 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ S0_v48 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj19 = (nint)0 & (nint)0x200;
			if (obj19 != null)
			{
				nint num13 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ S0_v110 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)val).FindKernel(null) != 0)
			{
				nint num14 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ S0_v95 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj20 = (nint)0 & (nint)0x200;
				if (obj20 != null)
				{
					nint num15 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ S0_v106 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ S0_v46 (T)+C]");
				Transform parentInternal;
				if (((ComputeShader)0).FindKernel(null) != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ S0_v46 (T)+C]");
					parentInternal = (Transform)0;
				}
				else
				{
					GameObject gameObject = ((Component)val).gameObject;
					parentInternal = (Transform)(object)gameObject;
				}
				mTrans.parentInternal = parentInternal;
				transform2.localPosition = (Vector3)mTrans;
				obj = transform2;
				_ = ((UnityEngine.Object)transform2).m_CachedPtr;
				_ = 0f;
				transform = (Transform)obj;
				Transform transform3 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
				((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
				Vector3 eulerAngles = transform.eulerAngles;
			}
			else
			{
				mTrans.parentInternal = mParent;
			}
			object obj21 = this + 32;
			Transform parentInternal2 = mTrans.parentInternal;
			obj21 = parentInternal2;
			nint num16 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ S0_v60 (Il2CppClass<NGUITools>)+BA]");
			object obj22 = (nint)0 & (nint)0x200;
			if (obj22 != null)
			{
				nint num17 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ S0_v87 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj23 = this + 52;
			UIGrid uIGrid = NGUITools.FindInParents<UIGrid>(mParent);
			obj23 = uIGrid;
			object obj24 = this + 56;
			UITable uITable = NGUITools.FindInParents<UITable>(mParent);
			obj24 = uITable;
			object obj25 = this - -64;
			nint num18 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ S1_v41 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj26 = (nint)0 & (nint)0x200;
			if (obj26 != null)
			{
				nint num19 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ S1_v83 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)obj25).FindKernel((string)null) != 0)
			{
				((RectTransform)(object)this).SetSizeWithCurrentAnchors((RectTransform.Axis)"EnableDragScrollView", 0.001f);
			}
			string clipboard = tag;
			nint num20 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ S1_v49 (Il2CppClass<NGUITools>)+BA]");
			object obj27 = (nint)0 & (nint)0x200;
			if (obj27 != null)
			{
				nint num21 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ S1_v77 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			NGUITools.clipboard = clipboard;
			nint num22 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ S1_v55 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj28 = (nint)0 & (nint)0x200;
			if (obj28 != null)
			{
				nint num23 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ S1_v73 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)mTable).FindKernel((string)null) != 0)
			{
				mTable.Sort((List<Transform>)1);
			}
			nint num24 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ S1_v62 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj29 = (nint)0 & (nint)0x200;
			if (obj29 != null)
			{
				nint num25 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v447 @ S1_v68 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)mGrid).FindKernel((string)null) != 0)
			{
				mGrid.AddChild((Transform)1);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		if (~(cloneOnDrag ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		}
	}

	public UIDragDropItem()
	{
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected Obj, but got Unknown
		//IL_008a: Expected I, but got Obj
		//IL_00a0: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_006b: Expected Obj, but got I4
		object obj = this - -64;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)obj).FindKernel((string)null) != 0)
		{
			object obj3 = this - -64;
			((Component)obj3).tag = (string)1;
		}
	}

	static UIDragDropItem()
	{
		//IL_0105: Expected Obj, but got I
		//IL_0115: Expected Obj, but got I
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected Obj, but got Unknown
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected Obj, but got Unknown
		//IL_016c: Expected Obj, but got I
		//IL_017c: Expected Obj, but got I
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected Obj, but got Unknown
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected Obj, but got Unknown
		//IL_01b8: Expected I, but got Obj
		//IL_01ce: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_006e: Expected Obj, but got I
		//IL_00c6: Expected I, but got Obj
		//IL_00dc: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S3_v3+60]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v28 @ S4_v4 (should have been resolved before IL gen)");
		Dictionary<string, string> currentLanguageMap = default;
		Strings._currentLanguageMap = currentLanguageMap;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S3_v7 (Il2CppMethodInfo)+C]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S3_v8+60]");
		object obj7 = 0;
		object obj8 = obj7;
		object obj9 = obj8 & 0x1FFF;
		object obj10 = obj9 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v51 @ S4_v8 (should have been resolved before IL gen)");
		nint num3 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v15 (Il2CppClass<Strings>)+5C]");
		object obj11 = (nint)0 + (nint)4;
		object obj12 = default;
		obj11 = obj12;
		Strings.gibberish = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num4 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v25 (Il2CppClass<Strings>)+5C]");
		object obj13 = (nint)0 + (nint)16;
		object obj14 = default;
		obj13 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
		nint num5 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v32 (Il2CppClass<Strings>)+5C]");
		object obj15 = (nint)0 + (nint)24;
		object obj16 = default;
		obj15 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		GoogleKilooAuthPlatform._003CUpdateAsyncCoroutine_003Ed__9 obj17 = default;
		((IDisposable)obj17).Dispose();
		obj17._003C_003E1__state = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		string text = default;
		FlurryVideoAds.LogError(text, (UnityEngine.Object)(object)obj17);
		nint num6 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v43 (Il2CppClass<Strings>)+5C]");
		object obj18 = (nint)0 + (nint)32;
		obj18 = text;
	}
}
