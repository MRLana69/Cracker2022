using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public class UIDraggableCamera : MonoBehaviour
{
	public Transform rootForBounds;

	public Vector2 scale = Vector2.oneVector;

	public float scrollWheelFactor;

	public UIDragObject.DragEffect dragEffect = UIDragObject.DragEffect.MomentumAndSpring;

	public bool smoothDragStart = true;

	public float momentumAmount = 35f;

	private Camera mCam;

	private Transform mTrans;

	private bool mPressed;

	private Vector2 mMomentum = Vector2.zeroVector;

	private Bounds mBounds;

	private float mScroll;

	private UIRoot mRoot;

	private bool mDragStarted;

	public unsafe Vector2 currentMomentum
	{
		get
		{
			//IL_000f: Expected F4, but got VT
			//IL_000a: Expected native int or pointer, but got VT
			Vector2 vector = default;
			((Vector2*)(nint)vector)->x = (float)mMomentum;
			return vector;
		}
		set
		{
			//IL_000f: Expected VT, but got F4
			mMomentum = (Vector2)value.x;
		}
	}

	private void Start()
	{
		Camera component = GetComponent<Camera>();
		mCam = component;
		Transform transform = base.transform;
		mTrans = transform;
		GameObject go = gameObject;
		UIRoot uIRoot = NGUITools.FindInParents<UIRoot>(go);
		mRoot = uIRoot;
		if (rootForBounds == null)
		{
			GameObject obj = gameObject;
			string hierarchy = NGUITools.GetHierarchy(obj);
			string text = hierarchy + " needs the 'Root For Bounds' parameter to be set";
			enabled = false;
		}
	}

	private unsafe Vector3 CalculateConstrainOffset()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_03e7: Expected I, but got Obj
		//IL_0405: Expected F4, but got VT
		//IL_0400: Expected native int or pointer, but got VT
		//IL_041a: Expected F4, but got I
		//IL_0415: Expected native int or pointer, but got VT
		//IL_00b8: Expected Obj, but got I
		//IL_00fe: Expected Obj, but got I
		//IL_0152: Expected Obj, but got I
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected Obj, but got Unknown
		//IL_019a: Expected Obj, but got I
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected VT, but got Unknown
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Expected Obj, but got Unknown
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected VT, but got Unknown
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Expected VT, but got Unknown
		//IL_023e: Expected Ref, but got VT
		//IL_024b: Expected Ref, but got VT
		//IL_025d: Expected Ref, but got VT
		//IL_026a: Expected Ref, but got VT
		//IL_02c9: Expected F4, but got I
		//IL_02c4: Expected native int or pointer, but got VT
		//IL_02ec: Expected Obj, but got I
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Expected Obj, but got Unknown
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Expected VT, but got Unknown
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Expected VT, but got Unknown
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		//IL_0335: Expected VT, but got Unknown
		//IL_0357: Expected native int or pointer, but got VT
		//IL_0372: Expected F4, but got I
		//IL_037a: Expected native int or pointer, but got VT
		//IL_0394: Expected F4, but got I
		//IL_038f: Expected native int or pointer, but got VT
		object obj = default;
		Vector2 vector = (Vector2)(obj - 160);
		_ = 0;
		_ = 0;
		Vector3 vector5 = default;
		if (!(rootForBounds == null) && rootForBounds.childCount != 0)
		{
			Rect rect = mCam.rect;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+88]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+80]");
			_ = 0;
			int width = Screen.width;
			Rect rect2 = mCam.rect;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+88]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+80]");
			_ = 0;
			int height = Screen.height;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+94]");
			object obj2 = (nint)0 * (nint)height;
			Rect rect3 = mCam.rect;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+88]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+80]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+98]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+90]");
			object obj3 = num + 0;
			int width2 = Screen.width;
			Rect rect4 = mCam.rect;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+88]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+80]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+9C]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+94]");
			object obj4 = num2 + 0;
			int height2 = Screen.height;
			object obj5 = obj4 * height2;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+78]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+90]");
			object obj6 = (nint)0 * (nint)width;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+70]");
			_ = 0;
			Vector3 position = (Vector3)(vector + 48);
			Vector3 vector2 = mCam.ScreenToWorldPoint(position);
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+68]");
			_ = 0;
			object obj7 = obj3 * width2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+60]");
			_ = 0;
			Vector3 position2 = (Vector3)(vector + 32);
			Vector3 vector3 = mCam.ScreenToWorldPoint(position2);
			Bounds bounds = (Bounds)(this + 60);
			Vector3 min = ((Bounds*)bounds)->min;
			Vector3 min2 = ((Bounds*)bounds)->min;
			Vector3 max = ((Bounds*)bounds)->max;
			Vector3 max2 = ((Bounds*)bounds)->max;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+84]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+80]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+80]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+80]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+80]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+80]");
			((Vector2*)(nint)vector)->x = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+58]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+84]");
			object obj8 = (nint)0 << 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+80]");
			object obj9 = 0 | obj8;
			Vector2 minRect = vector + 24;
			Vector2 maxRect = vector + 16;
			Vector2 minArea = vector + 8;
			Vector2 vector4 = NGUIMath.ConstrainRect(minRect, maxRect, minArea, vector);
			((Vector3*)(nint)vector5)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+80]");
			float y = (nint)0 >> 32;
			((Vector3*)(nint)vector5)->y = y;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+80]");
			((Vector3*)(nint)vector5)->x = 0f;
		}
		else
		{
			nint num3 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S1_v11 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num4 = 0;
			((Vector3*)(nint)vector5)->x = (float)Vector3.zeroVector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S1_v12 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
			((Vector3*)(nint)vector5)->z = 0f;
		}
		return vector5;
	}

	public unsafe bool ConstrainToBounds(bool immediate)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0068: Expected Obj, but got I
		//IL_0085: Expected Obj, but got I
		//IL_00af: Expected Obj, but got I
		//IL_00c5: Invalid comparison between Obj and F4
		//IL_01f0: Expected Obj, but got I
		//IL_020d: Expected Obj, but got I
		//IL_022a: Expected Obj, but got I
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected VT, but got Unknown
		//IL_0129: Expected Obj, but got I
		//IL_0146: Expected Obj, but got I
		//IL_0163: Expected Obj, but got I
		//IL_017d: Expected F4, but got I
		//IL_0178: Expected native int or pointer, but got VT
		//IL_019c: Expected F4, but got I
		//IL_0197: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 80);
		if (mTrans != null && rootForBounds != null)
		{
			Vector3 vector2 = CalculateConstrainOffset();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
			object obj2 = num * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+44]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+44]");
			object obj3 = num2 * 0;
			object obj4 = obj2 + obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
			object obj5 = num3 * 0;
			object obj6 = obj4 + obj5;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0f))
			{
				if (immediate)
				{
					Vector3 position = mTrans.position;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
					nint num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
					object obj7 = num4 - 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+44]");
					nint num5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+44]");
					object obj8 = num5 - 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
					nint num6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
					object obj9 = num6 - 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
					((Vector3*)(nint)vector)->z = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
					((Vector3*)(nint)vector)->x = 0f;
					mTrans.position = vector;
				}
				else
				{
					GameObject go = gameObject;
					Vector3 position2 = mTrans.position;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
					nint num7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
					object obj10 = num7 - 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+44]");
					nint num8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+44]");
					object obj11 = num8 - 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
					nint num9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
					object obj12 = num9 - 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
					_ = 0;
					Vector3 pos = vector + 16;
					SpringPosition springPosition = SpringPosition.Begin(go, pos, 13f);
					springPosition.worldSpace = true;
				}
			}
		}
		return true;
	}

	public void Press(bool isPressed)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0098: Expected VT, but got Obj
		object obj2 = default;
		object obj = obj2 - 48;
		if (isPressed)
		{
			mDragStarted = false;
		}
		if (!(rootForBounds != null))
		{
			return;
		}
		mPressed = isPressed;
		if (isPressed)
		{
			Bounds bounds = NGUIMath.CalculateAbsoluteWidgetBounds(rootForBounds);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			mBounds = (Bounds)obj;
			mScroll = 0f;
			mMomentum = Vector2.zeroVector;
			SpringPosition component = GetComponent<SpringPosition>();
			if (component != null)
			{
				component.enabled = false;
			}
		}
		else if (dragEffect == UIDragObject.DragEffect.MomentumAndSpring)
		{
			bool flag = ConstrainToBounds(immediate: false);
		}
	}

	public unsafe void Drag(Vector2 delta)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected Obj, but got Unknown
		//IL_0173: Expected Obj, but got F4
		//IL_0189: Expected Obj, but got I
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected Obj, but got Unknown
		//IL_0203: Expected F4, but got I
		//IL_01fe: Expected native int or pointer, but got VT
		//IL_0222: Expected F4, but got I
		//IL_021d: Expected native int or pointer, but got VT
		//IL_0307: Expected Obj, but got F4
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Expected VT, but got Unknown
		//IL_00bb: Expected Obj, but got F4
		//IL_00d8: Expected Obj, but got F4
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected F4, but got Unknown
		//IL_00ed: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 48);
		if (~(smoothDragStart ? 1u : 0u) == 0 && !mDragStarted)
		{
			mDragStarted = true;
			return;
		}
		UICamera.MouseOrTouch currentTouch = UICamera.currentTouch;
		currentTouch.clickNotification = UICamera.ClickNotification.BasedOnDelta;
		bool flag = mRoot != null;
		bool flag2 = !flag;
		float num = delta.x;
		if (!flag2)
		{
			float pixelSizeAdjustment = mRoot.pixelSizeAdjustment;
			float num2 = delta.x * pixelSizeAdjustment;
			object obj2 = delta.x >> 32;
			float num3 = (float)obj2 * pixelSizeAdjustment;
			object obj3 = num3 << 32;
			num = (((Vector2*)(nint)delta)->x = num2 | obj3);
		}
		object obj4 = scale ^ int.MinValue;
		float num4 = num * (float)obj4;
		object obj5 = num >> 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIDraggableCamera)+14]");
		object obj6 = (nint)0 ^ (nint)int.MinValue;
		object obj7 = obj5 * obj6;
		Vector3 localPosition = mTrans.localPosition;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
		float num5 = 0f + num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
		object obj8 = 0 + obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
		float num6 = 0f + 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
		((Vector3*)(nint)vector)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
		((Vector3*)(nint)vector)->x = 0f;
		mTrans.localPosition = vector;
		float num7 = momentumAmount * 0.01f;
		float num8 = num4 * num7;
		float num9 = (float)mMomentum + num8;
		float num10 = num9 - (float)mMomentum;
		float num11 = num10 * 0.67f;
		float num12 = (float)mMomentum + num11;
		float num13 = (float)obj7 * num7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIDraggableCamera)+38]");
		float num14 = 0f + num13;
		float num15 = num14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIDraggableCamera)+38]");
		float num16 = num15 - 0f;
		float num17 = num16 * 0.67f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIDraggableCamera)+38]");
		float num18 = 0f + num17;
		object obj9 = num18 << 32;
		Vector2 vector2 = (Vector2)(num12 | obj9);
		mMomentum = vector2;
		if (dragEffect != UIDragObject.DragEffect.MomentumAndSpring && ConstrainToBounds(immediate: true))
		{
			mScroll = 0f;
			mMomentum = Vector2.zeroVector;
		}
	}

	public void Scroll(float delta)
	{
		if (!enabled)
		{
			return;
		}
		GameObject go = gameObject;
		if (NGUITools.GetActive(go))
		{
			bool flag = !(mScroll < 0f);
			float num = 1f;
			if (!flag)
			{
				num = -1f;
			}
			bool flag2 = !(delta < 0f);
			float num2 = 1f;
			if (!flag2)
			{
				num2 = -1f;
			}
			float num3;
			if (num != num2)
			{
				mScroll = 0f;
				num3 = 0f;
			}
			else
			{
				num3 = mScroll;
			}
			float num4 = delta * scrollWheelFactor;
			float num5 = num3 + num4;
			mScroll = num5;
		}
	}

	private unsafe void Update()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00cc: Expected Obj, but got F4
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected VT, but got Unknown
		//IL_0320: Expected Obj, but got VT
		//IL_033d: Expected Obj, but got I
		//IL_035d: Invalid comparison between Obj and F4
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Expected Ref, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected Ref, but got Unknown
		//IL_0161: Expected Obj, but got I
		//IL_017e: Expected Obj, but got I
		//IL_01b0: Expected F4, but got I
		//IL_01ab: Expected native int or pointer, but got VT
		//IL_01cf: Expected F4, but got I
		//IL_01ca: Expected native int or pointer, but got VT
		//IL_0245: Expected VT, but got I
		object obj = default;
		Vector3 vector = (Vector3)(obj - 80);
		float unscaledDeltaTime = Time.unscaledDeltaTime;
		if (~(mPressed ? 1u : 0u) == 0)
		{
			SpringPosition component = GetComponent<SpringPosition>();
			if (component != null)
			{
				component.enabled = false;
			}
		}
		else
		{
			float num = mScroll * 20f;
			float num2 = (float)scale * num;
			float num3 = (float)mMomentum + num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIDraggableCamera)+14]");
			float num4 = 0f * num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIDraggableCamera)+38]");
			float num5 = 0f + num4;
			object obj2 = num5 << 32;
			Vector2 vector2 = (Vector2)(num3 | obj2);
			mMomentum = vector2;
			float num6 = NGUIMath.SpringLerp(mScroll, 0f, 20f, unscaledDeltaTime);
			mScroll = num6;
			object obj3 = mMomentum * mMomentum;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIDraggableCamera)+38]");
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIDraggableCamera)+38]");
			object obj4 = num7 * 0;
			object obj5 = obj3 + obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Sqrt not resolved\"");
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0.01f))
			{
				Vector3 localPosition = mTrans.localPosition;
				Vector2 vector3 = NGUIMath.SpringDampen(ref *(Vector2*)(this + 52), 9f, unscaledDeltaTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
				nint num8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
				object obj6 = num8 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+2C]");
				nint num9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+2C]");
				object obj7 = num9 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
				float num10 = 0f + 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
				((Vector3*)(nint)vector)->z = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
				((Vector3*)(nint)vector)->x = 0f;
				mTrans.localPosition = vector;
				Bounds bounds = NGUIMath.CalculateAbsoluteWidgetBounds(rootForBounds);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
				mBounds = (Bounds)0;
				bool immediate = dragEffect == UIDragObject.DragEffect.None;
				if (!ConstrainToBounds(immediate))
				{
					SpringPosition component2 = GetComponent<SpringPosition>();
					if (component2 != null)
					{
						component2.enabled = false;
					}
				}
				return;
			}
		}
		mScroll = 0f;
		Vector2 vector4 = NGUIMath.SpringDampen(ref *(Vector2*)(this + 52), 9f, unscaledDeltaTime);
	}
}
