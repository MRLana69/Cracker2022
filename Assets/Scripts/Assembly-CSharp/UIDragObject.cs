using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Common.Components.Singleton;
using UnityEngine;

public class UIDragObject : MonoBehaviour
{
	public enum DragEffect
	{
		None,
		Momentum,
		MomentumAndSpring
	}

	public Transform target;

	public UIPanel panelRegion;

	public Vector3 scrollMomentum;

	public bool restrictWithinPanel;

	public UIRect contentRect;

	public DragEffect dragEffect;

	public float momentumAmount;

	protected Vector3 scale;

	private float scrollWheelFactor;

	private Plane mPlane;

	private Vector3 mTargetPos;

	private Vector3 mLastPos;

	private Vector3 mMomentum;

	private Vector3 mScroll;

	private Bounds mBounds;

	private int mTouchID;

	private bool mStarted;

	private bool mPressed;

	public unsafe Vector3 dragMovement
	{
		get
		{
			//IL_000f: Expected F4, but got VT
			//IL_000a: Expected native int or pointer, but got VT
			//IL_0024: Expected F4, but got I
			//IL_001f: Expected native int or pointer, but got VT
			Vector3 vector = default;
			((Vector3*)(nint)vector)->x = (float)scale;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (UIDragObject)+38]");
			((Vector3*)(nint)vector)->z = 0f;
			return vector;
		}
		set
		{
			//IL_000f: Expected VT, but got F4
			scale = (Vector3)value.x;
			_ = value.z;
		}
	}

	private void OnEnable()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0077: Expected VT, but got F4
		//IL_01da: Expected I, but got Obj
		//IL_01be: Expected VT, but got I
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		_ = 0;
		if (scrollWheelFactor != 0f)
		{
			float num = (float)scale * scrollWheelFactor;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIDragObject)+34]");
			float num2 = 0f * scrollWheelFactor;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIDragObject)+38]");
			float num3 = 0f * scrollWheelFactor;
			scrollWheelFactor = 0f;
			scrollMomentum = (Vector3)num;
		}
		if (contentRect == null && target != null && Application.isPlaying)
		{
			UIWidget component = target.GetComponent<UIWidget>();
			if (component != null)
			{
				object obj3 = this + 36;
				obj3 = component;
			}
		}
		if (target != null)
		{
			Vector3 position = target.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
		}
		else
		{
			nint num4 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S1_v18 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S1_v19 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
			_ = 0;
			_ = Vector3.zeroVector;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		mTargetPos = (Vector3)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
	}

	private void OnDisable()
	{
		mStarted = false;
	}

	private void FindPanel()
	{
		UIPanel uIPanel;
		if (target != null)
		{
			Transform transform = target.transform;
			Transform parent = transform.parent;
			uIPanel = UIPanel.Find(parent);
		}
		else
		{
			uIPanel = null;
		}
		panelRegion = uIPanel;
		if (panelRegion == null)
		{
			restrictWithinPanel = false;
		}
	}

	private unsafe void UpdateBounds()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected Obj, but got Unknown
		//IL_02e1: Expected VT, but got I
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected Obj, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected Obj, but got Unknown
		//IL_0085: Expected I, but got Obj
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected Obj, but got Unknown
		//IL_00a6: Expected Obj, but got I4
		//IL_031c: Expected I, but got Obj
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Expected Obj, but got Unknown
		//IL_0364: Expected Obj, but got I
		//IL_0398: Unknown result type (might be due to invalid IL or missing references)
		//IL_039d: Expected VT, but got Unknown
		//IL_03a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ab: Expected VT, but got Unknown
		//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b9: Expected VT, but got Unknown
		//IL_03c5: Expected native int or pointer, but got VT
		//IL_03f6: Expected VT, but got I
		//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0401: Expected VT, but got Unknown
		//IL_040a: Expected Obj, but got I4
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected Obj, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected VT, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected VT, but got Unknown
		//IL_0123: Expected Ref, but got VT
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected Obj, but got Unknown
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected Obj, but got Unknown
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Expected Obj, but got Unknown
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Expected VT, but got Unknown
		//IL_0234: Expected Ref, but got VT
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 272;
		object obj3 = obj + 208;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @237");
		bool flag = contentRect;
		Transform cachedTransform = panelRegion.cachedTransform;
		if (flag)
		{
			Matrix4x4 worldToLocalMatrix = cachedTransform.worldToLocalMatrix;
			object obj4 = obj + 208;
			object obj5 = obj + 144;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
			UIRect uIRect = contentRect;
			nint num = (nint)uIRect;
			object obj6 = uIRect + 80;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v82 @ S1_v26 (Il2CppClass<UIRect>)+10C] (should have been resolved before IL gen)");
			object obj7 = 0;
			object obj10 = default;
			while ((nint)obj7 < 4)
			{
				object obj8 = obj7 * 12;
				object obj9 = obj10 + obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S1_v77+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S1_v77+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+98]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+90]");
				_ = 0;
				Matrix4x4 matrix4x = (Matrix4x4)(obj + 208);
				Vector3 point = (Vector3)(obj + 24);
				Vector3 vector = ((Matrix4x4*)matrix4x)->MultiplyPoint3x4(point);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+60]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+60]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+58]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+58]");
				_ = 0;
				object obj11 = obj7 * 12;
				object obj12 = obj10 + obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				_ = 0;
				object obj13 = obj7 + 1;
				obj7 = obj13;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v38+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v38+10]");
			_ = 0;
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ S1_v37 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ S1_v38 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+60]");
			_ = 0;
			object obj14 = obj - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ S1_v38 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
			obj14 = 0;
			_ = Vector3.zeroVector;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+58]");
			_ = 0;
			_ = Vector3.zeroVector;
			_ = 0;
			Bounds bounds = (Bounds)(obj + 144);
			Vector3 center = (Vector3)(obj + 72);
			Vector3 size = (Vector3)(obj + 56);
			*(Bounds*)(nint)bounds = new Bounds(center, size);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A0]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+98]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+90]");
			mBounds = (Bounds)0;
			Bounds bounds2 = (Bounds)(this + 128);
			object obj15 = 1;
			while ((nint)obj15 < 4)
			{
				object obj16 = obj15 * 12;
				object obj17 = obj10 + obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ S1_v64+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ S1_v64+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+98]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+90]");
				_ = 0;
				Vector3 point2 = (Vector3)(obj + 40);
				((Bounds*)bounds2)->Encapsulate(point2);
				object obj18 = obj15 + 1;
				obj15 = obj18;
			}
		}
		else
		{
			Bounds bounds3 = NGUIMath.CalculateRelativeWidgetBounds(cachedTransform, target);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+60]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+58]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+60]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+58]");
			mBounds = (Bounds)0;
		}
	}

	private unsafe void OnPress(bool pressed)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_003a: Expected VT, but got Obj
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Expected Ref, but got Unknown
		//IL_03a2: Expected I, but got Obj
		//IL_03e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ed: Expected VT, but got Unknown
		//IL_03f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Expected VT, but got Unknown
		//IL_0434: Expected I, but got Obj
		//IL_047f: Expected F4, but got I
		//IL_047a: Expected native int or pointer, but got VT
		//IL_048d: Expected F4, but got VT
		//IL_0488: Expected native int or pointer, but got VT
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_049b: Expected VT, but got Unknown
		//IL_04a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a9: Expected VT, but got Unknown
		//IL_04b5: Expected native int or pointer, but got VT
		//IL_0288: Expected VT, but got I
		object obj = default;
		Vector3 vector = (Vector3)(obj - 112);
		_ = 0;
		_ = 0;
		if (UICamera.currentTouchID == -2 || UICamera.currentTouchID == -3)
		{
			return;
		}
		_00210 val = (_00210)SingletonMonobehavior<>.Instance;
		float timeScale = Time.timeScale;
		bool flag = timeScale < 0.01f;
		if (timeScale == 0f)
		{
			flag = false;
		}
		if (flag || !enabled)
		{
			return;
		}
		GameObject go = gameObject;
		if (!NGUITools.GetActive(go) || !(target != null))
		{
			return;
		}
		if (pressed)
		{
			if (mPressed)
			{
				return;
			}
			mTouchID = UICamera.currentTouchID;
			mStarted = false;
			CancelMovement();
			if (~(restrictWithinPanel ? 1u : 0u) == 0)
			{
				if (panelRegion == null)
				{
					FindPanel();
				}
				if (~(restrictWithinPanel ? 1u : 0u) == 0)
				{
					UpdateBounds();
				}
			}
			CancelSpring();
			Transform transform = UICamera.currentCamera.transform;
			if (panelRegion != null)
			{
				Transform cachedTransform = panelRegion.cachedTransform;
				Quaternion rotation = cachedTransform.rotation;
			}
			else
			{
				Quaternion rotation2 = transform.rotation;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
			_ = 0;
			nint num = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ S0_v105 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ S0_v106 (Il2CppStaticFields<UnityEngine.Vector3>)+5C]");
			_ = 0;
			_ = Vector3.backVector;
			Quaternion quaternion = (Quaternion)(vector + 48);
			Vector3 vector2 = vector + 32;
			Vector3 vector3 = quaternion * vector2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
			_ = 0;
			nint num3 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ S0_v118 (Il2CppClass<UICamera>)+5C]");
			nint num4 = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ S0_v119 (Il2CppStaticFields<UICamera>)+34]");
			((Vector3*)(nint)vector)->z = 0f;
			((Vector3*)(nint)vector)->x = (float)UICamera.lastWorldPosition;
			Plane plane = (Plane)(vector + 80);
			Vector3 inNormal = vector + 16;
			*(Plane*)(nint)plane = new Plane(inNormal, vector);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
			mPlane = (Plane)0;
		}
		else if (~(mPressed ? 1u : 0u) == 0 && mTouchID == UICamera.currentTouchID)
		{
			mPressed = false;
			if (~(restrictWithinPanel ? 1u : 0u) == 0 && dragEffect == DragEffect.MomentumAndSpring && panelRegion.ConstrainTargetToBounds(target, ref *(Bounds*)(this + 128), immediate: false))
			{
				CancelMovement();
			}
		}
	}

	private unsafe void OnDrag(Vector2 delta)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected VT, but got Unknown
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected VT, but got Unknown
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected VT, but got Unknown
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected Ref, but got Unknown
		//IL_01b3: Expected Ref, but got VT
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected VT, but got Unknown
		//IL_01f3: Expected F4, but got I
		//IL_01f3: Expected Ref, but got VT
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Expected VT, but got Unknown
		//IL_022b: Expected Obj, but got I
		//IL_0248: Expected Obj, but got I
		//IL_0274: Expected VT, but got I
		//IL_06d6: Invalid comparison between Obj and F4
		//IL_06e5: Invalid comparison between VT and F4
		//IL_0707: Expected I, but got Obj
		//IL_0727: Expected Obj, but got I
		//IL_0737: Expected Obj, but got I
		//IL_07c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ce: Expected VT, but got Unknown
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_0305: Expected VT, but got Unknown
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_032f: Expected Obj, but got Unknown
		//IL_034c: Expected Obj, but got I
		//IL_0369: Expected Obj, but got I
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a0: Expected VT, but got Unknown
		//IL_052d: Expected VT, but got F4
		//IL_03c8: Expected Obj, but got I
		//IL_03d8: Expected Obj, but got I
		//IL_03e8: Expected VT, but got I
		//IL_0538: Unknown result type (might be due to invalid IL or missing references)
		//IL_053d: Expected Ref, but got Unknown
		//IL_0580: Expected Obj, but got I
		//IL_0590: Unknown result type (might be due to invalid IL or missing references)
		//IL_0595: Expected Obj, but got Unknown
		//IL_05b2: Expected Obj, but got I
		//IL_05c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c7: Expected Obj, but got Unknown
		//IL_05e4: Expected Obj, but got I
		//IL_05f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f9: Expected Obj, but got Unknown
		//IL_0625: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 240;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		if (~(mPressed ? 1u : 0u) != 0 || mTouchID != UICamera.currentTouchID || !enabled)
		{
			return;
		}
		GameObject go = gameObject;
		if (!NGUITools.GetActive(go) || !(target != null))
		{
			return;
		}
		UICamera.MouseOrTouch currentTouch = UICamera.currentTouch;
		currentTouch.clickNotification = UICamera.ClickNotification.BasedOnDelta;
		UICamera.MouseOrTouch currentTouch2 = UICamera.currentTouch;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B0]");
		_ = 0;
		_ = currentTouch2.pos;
		_ = currentTouch2.pos;
		Vector3 pos = (Vector3)(obj + 88);
		Ray ray = UICamera.currentCamera.ScreenPointToRay(pos);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B8]");
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B8]");
		_ = 0;
		Plane plane = (Plane)(this - -64);
		Ray ray2 = (Ray)(obj - -64);
		if (!((Plane*)plane)->Raycast(ray2, out *(float*)(obj + 212)))
		{
			return;
		}
		Ray ray3 = (Ray)(obj + 216);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+D4]");
		Vector3 point = ((Ray*)ray3)->GetPoint(0f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B8]");
		Vector3 vector = 0 - mLastPos;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+BC]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIDragObject)+60]");
		object obj3 = num - 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C0]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIDragObject)+64]");
		object obj4 = num2 - 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+BC]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B8]");
		mLastPos = (Vector3)0;
		bool flag = (byte)(~(mStarted ? 1u : 0u)) != 0;
		bool flag2 = !flag;
		object obj5 = obj4;
		object obj6 = obj3;
		Vector3 vector2 = vector;
		if (!flag2)
		{
			mStarted = true;
			nint num3 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ S0_v190 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ S0_v191 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ S0_v191 (Il2CppStaticFields<UnityEngine.Vector3>)+4]");
			obj6 = 0;
			vector2 = Vector3.zeroVector;
		}
		bool flag3 = obj6 == (object)0f;
		if (vector2 != (Vector3)(object)0f)
		{
			flag3 = false;
		}
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A0]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+98]");
			_ = 0;
			Vector3 direction = (Vector3)(obj + 48);
			Vector3 vector3 = target.InverseTransformDirection(direction);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B8]");
			object obj7 = 0 * scale;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+BC]");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIDragObject)+34]");
			object obj8 = num5 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C0]");
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIDragObject)+38]");
			object obj9 = num6 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+90]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+88]");
			_ = 0;
			Vector3 direction2 = (Vector3)(obj + 32);
			Vector3 vector4 = target.TransformDirection(direction2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C0]");
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+BC]");
			obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B8]");
			vector2 = (Vector3)0;
		}
		if (dragEffect != DragEffect.None)
		{
			float num7 = momentumAmount * 0.01f;
			float num8 = (float)vector2 * num7;
			float num9 = (float)obj5 * num7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIDragObject)+70]");
			float num10 = 0f + num9;
			float num11 = num10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIDragObject)+70]");
			float num12 = num11 - 0f;
			float num13 = num12 * 0.67f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIDragObject)+70]");
			float num14 = 0f + num13;
			float num15 = (float)obj6 * num7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIDragObject)+6C]");
			float num16 = 0f + num15;
			float num17 = num16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIDragObject)+6C]");
			float num18 = num17 - 0f;
			float num19 = num18 * 0.67f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIDragObject)+6C]");
			float num20 = 0f + num19;
			float num21 = (float)mMomentum + num8;
			float num22 = num21 - (float)mMomentum;
			float num23 = num22 * 0.67f;
			float num24 = (float)mMomentum + num23;
			mMomentum = (Vector3)num24;
		}
		Vector3 localPosition = target.localPosition;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+80]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+78]");
		_ = 0;
		Vector3 worldDelta = (Vector3)(obj + 16);
		Move(worldDelta);
		if (~(restrictWithinPanel ? 1u : 0u) == 0)
		{
			_ = *(Bounds*)(this + 128);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ S1_v68 (UnityEngine.Bounds&)+8]");
			_ = 0;
			Vector3 localPosition2 = target.localPosition;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B8]");
			nint num25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B8]");
			object obj10 = num25 - 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B8]");
			object obj11 = 0 + obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+BC]");
			nint num26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+BC]");
			object obj12 = num26 - 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+BC]");
			object obj13 = 0 + obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C0]");
			nint num27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C0]");
			object obj14 = num27 - 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C0]");
			object obj15 = 0 + obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+70]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
			obj = 0;
			ref Bounds targetBounds = ref *(Bounds*)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			if (dragEffect != DragEffect.MomentumAndSpring && panelRegion.ConstrainTargetToBounds(target, ref targetBounds, immediate: true))
			{
				CancelMovement();
			}
		}
	}

	private unsafe void Move(Vector3 worldDelta)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0485: Unknown result type (might be due to invalid IL or missing references)
		//IL_048a: Expected Obj, but got Unknown
		//IL_0462: Unknown result type (might be due to invalid IL or missing references)
		//IL_0467: Expected VT, but got Unknown
		//IL_008e: Expected VT, but got F4
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected Obj, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected Obj, but got Unknown
		//IL_035c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0361: Expected VT, but got Unknown
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected VT, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected VT, but got Unknown
		//IL_0152: Expected Ref, but got VT
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Expected VT, but got Unknown
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Expected VT, but got Unknown
		//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03be: Expected Obj, but got Unknown
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Expected Obj, but got Unknown
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected Obj, but got Unknown
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected VT, but got Unknown
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected VT, but got Unknown
		//IL_022d: Expected Ref, but got VT
		//IL_0253: Expected F4, but got I
		//IL_024e: Expected native int or pointer, but got VT
		//IL_0275: Expected F4, but got I
		//IL_0270: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 304);
		object obj2 = vector + 240;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @237");
		if (panelRegion != null)
		{
			float num = (float)mTargetPos + worldDelta.x;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIDragObject)+54]");
			float num2 = 0f + worldDelta.y;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIDragObject)+58]");
			float num3 = 0f + worldDelta.z;
			mTargetPos = (Vector3)num;
			Transform parent = target.parent;
			Rigidbody component = target.GetComponent<Rigidbody>();
			if (parent != null)
			{
				Matrix4x4 worldToLocalMatrix = parent.worldToLocalMatrix;
				object obj3 = vector + 240;
				object obj4 = vector + 176;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIDragObject)+58]");
				_ = 0;
				_ = mTargetPos;
				Matrix4x4 matrix4x = (Matrix4x4)(vector + 240);
				Vector3 point = vector + 48;
				Vector3 vector2 = ((Matrix4x4*)matrix4x)->MultiplyPoint3x4(point);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
				if (component != null)
				{
					Matrix4x4 localToWorldMatrix = parent.localToWorldMatrix;
					object obj5 = vector + 240;
					object obj6 = vector + 176;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A0]");
					_ = 0;
					Matrix4x4 matrix4x2 = (Matrix4x4)(vector + 240);
					Vector3 point2 = vector + 16;
					Vector3 vector3 = ((Matrix4x4*)matrix4x2)->MultiplyPoint3x4(point2);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+98]");
					((Vector3*)(nint)vector)->z = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B0]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B0]");
					((Vector3*)(nint)vector)->x = 0f;
					component.position = vector;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
					_ = 0;
					Vector3 localPosition = vector + 32;
					target.localPosition = localPosition;
				}
			}
			else if (component != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIDragObject)+58]");
				_ = 0;
				_ = mTargetPos;
				Vector3 position = vector - -64;
				component.position = position;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIDragObject)+58]");
				_ = 0;
				_ = mTargetPos;
				Vector3 position2 = vector + 80;
				target.position = position2;
			}
			UIScrollView component2 = panelRegion.GetComponent<UIScrollView>();
			if (component2 != null)
			{
				object obj7 = component2 - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v285 @ S2_v16+BC] (should have been resolved before IL gen)");
			}
		}
		else
		{
			Vector3 position3 = target.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B0]");
			float num4 = 0f + worldDelta.x;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B4]");
			float num5 = 0f + worldDelta.y;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B8]");
			float num6 = 0f + worldDelta.z;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+78]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+70]");
			_ = 0;
			Vector3 position4 = vector + 96;
			target.position = position4;
		}
	}

	private unsafe void LateUpdate()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_004a: Expected Obj, but got I
		//IL_0067: Expected Obj, but got I
		//IL_028d: Expected I, but got Obj
		//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Expected VT, but got Unknown
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Expected VT, but got Unknown
		//IL_034c: Expected VT, but got I
		//IL_0362: Expected Obj, but got VT
		//IL_037f: Expected Obj, but got I
		//IL_03a9: Expected Obj, but got I
		//IL_03c9: Invalid comparison between Obj and F4
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected Ref, but got Unknown
		//IL_0134: Expected F4, but got I
		//IL_012f: Expected native int or pointer, but got VT
		//IL_0156: Expected F4, but got I
		//IL_0151: Expected native int or pointer, but got VT
		//IL_03ee: Expected Obj, but got VT
		//IL_040b: Expected Obj, but got I
		//IL_0435: Expected Obj, but got I
		//IL_0455: Invalid comparison between Obj and F4
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected Ref, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj - 128);
		if (!(target != null))
		{
			return;
		}
		float unscaledDeltaTime = Time.unscaledDeltaTime;
		Vector3 vector2 = mMomentum - mScroll;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIDragObject)+6C]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIDragObject)+78]");
		object obj2 = num - 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIDragObject)+70]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIDragObject)+7C]");
		object obj3 = num2 - 0;
		mMomentum = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIDragObject)+7C]");
		_ = 0;
		_ = mScroll;
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S1_v21 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S1_v22 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+78]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S1_v22 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		_ = Vector3.zeroVector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+70]");
		_ = 0;
		_ = Vector3.zeroVector;
		Vector3 vector3 = vector + 32;
		Vector3 to = vector + 16;
		Vector3 vector4 = NGUIMath.SpringLerp(vector3, to, 20f, unscaledDeltaTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
		mScroll = (Vector3)0;
		object obj4 = mMomentum * mMomentum;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIDragObject)+6C]");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIDragObject)+6C]");
		object obj5 = num5 * 0;
		object obj6 = obj4 + obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIDragObject)+70]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIDragObject)+70]");
		object obj7 = num6 * 0;
		object obj8 = obj6 + obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Sqrt not resolved\"");
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0.0001f))
		{
			return;
		}
		ref Vector3 velocity = ref *(Vector3*)(this + 104);
		if (~(mPressed ? 1u : 0u) != 0)
		{
			if (panelRegion == null)
			{
				FindPanel();
			}
			Vector3 vector5 = NGUIMath.SpringDampen(ref velocity, 9f, unscaledDeltaTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+78]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+78]");
			((Vector3*)(nint)vector)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+70]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+70]");
			((Vector3*)(nint)vector)->x = 0f;
			Move(vector);
			if (~(restrictWithinPanel ? 1u : 0u) == 0 && panelRegion != null)
			{
				UpdateBounds();
				ref Bounds targetBounds = ref *(Bounds*)(this + 128);
				bool immediate = dragEffect == DragEffect.None;
				if (panelRegion.ConstrainTargetToBounds(target, ref targetBounds, immediate))
				{
					CancelMovement();
				}
				else
				{
					CancelSpring();
				}
			}
			Vector3 vector6 = NGUIMath.SpringDampen(ref velocity, 9f, unscaledDeltaTime);
			object obj9 = mMomentum * mMomentum;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIDragObject)+6C]");
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIDragObject)+6C]");
			object obj10 = num7 * 0;
			object obj11 = obj9 + obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIDragObject)+70]");
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIDragObject)+70]");
			object obj12 = num8 * 0;
			object obj13 = obj11 + obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Sqrt not resolved\"");
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0.0001f))
			{
				CancelMovement();
			}
		}
		else
		{
			Vector3 vector7 = NGUIMath.SpringDampen(ref velocity, 9f, unscaledDeltaTime);
		}
	}

	public unsafe void CancelMovement()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0213: Expected I, but got Obj
		//IL_01f3: Expected VT, but got I
		//IL_0061: Expected F8, but got I4
		//IL_02b8: Expected I, but got Obj
		//IL_0249: Expected I, but got Obj
		//IL_00a0: Expected F8, but got I4
		//IL_00df: Expected F8, but got I4
		//IL_01ae: Expected F4, but got I
		//IL_01a9: Expected native int or pointer, but got VT
		//IL_01cd: Expected F4, but got I
		//IL_01c8: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj + -64);
		if (target != null)
		{
			Vector3 localPosition = target.localPosition;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
			double value = default;
			double num = Math.Abs(value);
			if (!(num < 2147483648.0))
			{
				value = -2147483648.0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
			double value2 = default;
			double num2 = Math.Abs(value2);
			if (!(num2 < 2147483648.0))
			{
				value2 = -2147483648.0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
			double value3 = default;
			double num3 = Math.Abs(value3);
			if (!(num3 < 2147483648.0))
			{
				value3 = -2147483648.0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
			((Vector3*)(nint)vector)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
			((Vector3*)(nint)vector)->x = 0f;
			target.localPosition = vector;
		}
		if (target != null)
		{
			Vector3 position = target.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
			_ = 0;
		}
		else
		{
			nint num4 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S1_v24 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S1_v25 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
			_ = 0;
			_ = Vector3.zeroVector;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
		mTargetPos = (Vector3)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
		_ = 0;
		nint num6 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S0_v28 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S0_v29 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		mMomentum = Vector3.zeroVector;
		nint num8 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S0_v38 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v39 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		mScroll = Vector3.zeroVector;
	}

	public void CancelSpring()
	{
		SpringPosition component = target.GetComponent<SpringPosition>();
		if (component != null)
		{
			component.enabled = false;
		}
	}

	private void OnScroll(float delta)
	{
		//IL_00dc: Expected VT, but got F4
		if (enabled)
		{
			GameObject go = gameObject;
			if (NGUITools.GetActive(go))
			{
				float num = delta * 0.05f;
				float num2 = (float)scrollMomentum * num;
				float num3 = (float)mScroll - num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIDragObject)+18]");
				float num4 = 0f * num;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIDragObject)+78]");
				float num5 = 0f - num4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIDragObject)+1C]");
				float num6 = 0f * num;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIDragObject)+7C]");
				float num7 = 0f - num6;
				mScroll = (Vector3)num3;
			}
		}
	}

	public UIDragObject()
	{
		//IL_0013: Expected I, but got Obj
		//IL_00a7: Expected I, but got Obj
		//IL_006a: Expected I, but got Obj
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ S0_v6 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		_ = 1065353216;
		momentumAmount = 35f;
		dragEffect = DragEffect.MomentumAndSpring;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v7 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		scrollMomentum = Vector3.zeroVector;
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v21 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v22 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		mMomentum = Vector3.zeroVector;
		nint num5 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v31 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v32 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		mScroll = Vector3.zeroVector;
		base._002Ector();
	}
}
