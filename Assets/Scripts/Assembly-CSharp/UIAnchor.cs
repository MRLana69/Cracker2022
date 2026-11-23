using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public class UIAnchor : MonoBehaviour
{
	public enum Side
	{
		BottomLeft,
		Left,
		TopLeft,
		Top,
		TopRight,
		Right,
		BottomRight,
		Bottom,
		Center
	}

	public Camera uiCamera;

	public GameObject container;

	public Side side = Side.Center;

	public bool runOnlyOnce = true;

	public Vector2 relativeOffset = Vector2.zeroVector;

	public Vector2 pixelOffset = Vector2.zeroVector;

	private UIWidget widgetContainer;

	private Transform mTrans;

	private Animation mAnim;

	private Rect mRect;

	private UIRoot mRoot;

	private bool mStarted;

	private unsafe void Awake()
	{
		Transform transform = base.transform;
		mTrans = transform;
		Animation component = GetComponent<Animation>();
		mAnim = component;
		UICamera.OnScreenResize onScreenResize = default;
		onScreenResize._002Ector(this, (nint)__ldftn(UIAnchor.ScreenSizeChanged));
		Delegate obj = Delegate.Combine(UICamera.onScreenResize, onScreenResize);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		UICamera.OnScreenResize onScreenResize2 = default;
		UICamera.onScreenResize = onScreenResize2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
	}

	private unsafe void OnDestroy()
	{
		UICamera.OnScreenResize onScreenResize = default;
		onScreenResize._002Ector(this, (nint)__ldftn(UIAnchor.ScreenSizeChanged));
		Delegate obj = Delegate.Remove(UICamera.onScreenResize, onScreenResize);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		UICamera.OnScreenResize onScreenResize2 = default;
		UICamera.onScreenResize = onScreenResize2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
	}

	private void ScreenSizeChanged()
	{
		if (~(mStarted ? 1u : 0u) == 0 && ~(runOnlyOnce ? 1u : 0u) == 0)
		{
			Update();
		}
	}

	private void Start()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected Obj, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_0067: Expected Obj, but got I4
		if (container == null && widgetContainer != null)
		{
			object obj = this + 16;
			object obj2 = this + 44;
			GameObject gameObject = ((Component)obj2).gameObject;
			obj = gameObject;
			obj2 = 0;
		}
		GameObject go = base.gameObject;
		UIRoot uIRoot = NGUITools.FindInParents<UIRoot>(go);
		mRoot = uIRoot;
		if (uiCamera == null)
		{
			GameObject gameObject2 = base.gameObject;
			int layer = gameObject2.layer;
			Camera camera = NGUITools.FindCameraForLayer(layer);
			uiCamera = camera;
		}
		Update();
		mStarted = true;
	}

	private unsafe void Update()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected VT, but got Unknown
		//IL_0188: Expected Ref, but got VT
		//IL_01a3: Expected VT, but got I
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected VT, but got Unknown
		//IL_01ba: Expected Ref, but got VT
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected VT, but got Unknown
		//IL_01e2: Expected Ref, but got VT
		//IL_0342: Expected VT, but got F4
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Expected VT, but got Unknown
		//IL_020f: Expected Ref, but got VT
		//IL_0ca3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca8: Expected Obj, but got Unknown
		//IL_0cb2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb7: Expected Obj, but got Unknown
		//IL_0ce4: Expected Obj, but got I
		//IL_0cf4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf9: Expected Obj, but got Unknown
		//IL_0d19: Expected Obj, but got I4
		//IL_05af: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b4: Expected Obj, but got Unknown
		//IL_05c4: Expected Obj, but got I
		//IL_05d6: Expected VT, but got I
		//IL_05df: Expected Obj, but got I4
		//IL_0727: Expected F4, but got I
		//IL_0d61: Expected Obj, but got I4
		//IL_0d76: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d7b: Expected Obj, but got Unknown
		//IL_0d8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d90: Expected Obj, but got Unknown
		//IL_0d98: Expected Obj, but got F4
		//IL_0dc3: Expected Obj, but got I4
		//IL_0def: Expected Obj, but got I
		//IL_0ea2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ea7: Expected Obj, but got Unknown
		//IL_0eb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb6: Expected Obj, but got Unknown
		//IL_0ee2: Expected Obj, but got I
		//IL_0ef2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef7: Expected Obj, but got Unknown
		//IL_06d7: Expected Obj, but got I4
		//IL_06e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e5: Expected Obj, but got Unknown
		//IL_049e: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a3: Expected VT, but got Unknown
		//IL_04ac: Expected Ref, but got VT
		//IL_04c2: Expected VT, but got I
		//IL_04cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d0: Expected VT, but got Unknown
		//IL_04d9: Expected Ref, but got VT
		//IL_04f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fd: Expected VT, but got Unknown
		//IL_0506: Expected Ref, but got VT
		//IL_0520: Unknown result type (might be due to invalid IL or missing references)
		//IL_0525: Expected VT, but got Unknown
		//IL_052e: Expected Ref, but got VT
		//IL_06fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0701: Expected Obj, but got Unknown
		//IL_054d: Expected Obj, but got I4
		//IL_0f86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f8b: Expected VT, but got Unknown
		//IL_0fd8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fdd: Expected VT, but got Unknown
		//IL_07e8: Expected Obj, but got I
		//IL_07f8: Expected Obj, but got I
		//IL_0808: Expected Obj, but got I
		//IL_0a4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a50: Expected VT, but got Unknown
		//IL_1014: Unknown result type (might be due to invalid IL or missing references)
		//IL_1019: Expected Obj, but got Unknown
		//IL_1036: Unknown result type (might be due to invalid IL or missing references)
		//IL_103b: Expected Obj, but got Unknown
		//IL_1065: Unknown result type (might be due to invalid IL or missing references)
		//IL_106a: Expected Obj, but got Unknown
		//IL_108d: Invalid comparison between Obj and F4
		//IL_11a1: Expected Obj, but got I
		//IL_0b5d: Expected Obj, but got I
		//IL_0b6d: Expected Obj, but got I
		//IL_0ba4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba9: Expected VT, but got Unknown
		//IL_0853: Expected Obj, but got I
		//IL_0863: Expected Obj, but got I
		//IL_0873: Expected Obj, but got I
		//IL_08da: Unknown result type (might be due to invalid IL or missing references)
		//IL_08df: Expected VT, but got Unknown
		//IL_06c4: Expected F4, but got VT
		//IL_0b32: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b37: Expected VT, but got Unknown
		//IL_0934: Expected F8, but got I4
		//IL_0973: Expected F8, but got I4
		//IL_1149: Expected Obj, but got I
		//IL_099a: Expected F4, but got I
		//IL_0995: Expected native int or pointer, but got VT
		//IL_09b9: Expected F4, but got I
		//IL_09b4: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 336);
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		if (mAnim != null && mAnim.enabled && mAnim.isPlaying)
		{
			return;
		}
		bool flag = container == null;
		bool flag2 = !flag;
		bool flag3 = !flag2;
		UIWidget uIWidget = null;
		if (!flag3)
		{
			UIWidget component = container.GetComponent<UIWidget>();
			uIWidget = component;
		}
		UIPanel uIPanel;
		if (container == null)
		{
			bool flag4 = uIWidget != null;
			uIPanel = null;
			if (!flag4)
			{
				goto IL_00ec;
			}
		}
		uIPanel = container.GetComponent<UIPanel>();
		goto IL_00ec;
		IL_0e65:
		Side side;
		if (side > Side.Center)
		{
			goto IL_0717;
		}
		object obj2 = 1 << (int)side;
		object obj3 = obj2 & 0x1C;
		float num;
		float num2;
		if (obj3 == null)
		{
			object obj4 = obj2 & 0x122;
			num = num2;
			if (obj4 == null)
			{
				goto IL_0717;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIAnchor)+44]");
			float num3 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIAnchor)+3C]");
			float num4 = num3 + 0f;
			num = num4;
		}
		goto IL_0e90;
		IL_0bbd:
		if (~(runOnlyOnce ? 1u : 0u) == 0 && Application.isPlaying)
		{
			enabled = false;
		}
		return;
		IL_1182:
		Vector3 position = mTrans.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+F8]");
		object obj5 = 0;
		goto IL_0ff5;
		IL_0ff5:
		Vector3 position2 = mTrans.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+F0]");
		object obj7;
		object obj6 = 0 - obj7;
		object obj8 = obj6 * obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+F4]");
		object obj10;
		object obj9 = 0 - obj10;
		object obj11 = obj9 * obj9;
		object obj12 = obj8 + obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+F8]");
		object obj13 = 0 - obj5;
		object obj14 = obj13 * obj13;
		object obj15 = obj12 + obj14;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj15) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)9.9999994E-11f))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+78]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+70]");
			_ = 0;
			Vector3 position3 = vector + 32;
			mTrans.position = position3;
		}
		goto IL_0bbd;
		IL_0b4d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+F0]");
		obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+F4]");
		obj10 = 0;
		goto IL_1182;
		IL_0717:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIAnchor)+3C]");
		num = 0f;
		goto IL_0e90;
		IL_0e90:
		Vector2 vector2 = relativeOffset;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIAnchor)+40]");
		object obj16 = vector2 * 0;
		object obj17 = pixelOffset + obj16;
		float num6;
		float num5 = num6 + (float)obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIAnchor)+20]");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIAnchor)+44]");
		object obj18 = num7 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIAnchor)+28]");
		object obj19 = 0 + obj18;
		float num8 = num + (float)obj19;
		object obj20 = default;
		if (obj20 != null)
		{
			bool orthographic = uiCamera.orthographic;
			bool flag5 = !orthographic;
			float num9 = num8;
			float num10 = num5;
			if (!flag5)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
				float num11 = default;
				num9 = num11;
				float num12 = default;
				num10 = num12;
			}
			Vector3 position4 = mTrans.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+F8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+F8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+F0]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+F0]");
			_ = 0;
			Vector3 position5 = vector - -64;
			Vector3 vector3 = uiCamera.WorldToScreenPoint(position5);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+F8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C0]");
			_ = 0;
			Vector3 position6 = vector + 48;
			Vector3 vector4 = uiCamera.ScreenToWorldPoint(position6);
			bool orthographic2 = uiCamera.orthographic;
			bool flag6 = !orthographic2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+F8]");
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+F0]");
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+F4]");
			obj10 = 0;
			if (!flag6)
			{
				Transform parent = mTrans.parent;
				bool flag7 = parent != null;
				bool flag8 = !flag7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+F8]");
				obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+F0]");
				obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+F4]");
				obj10 = 0;
				if (!flag8)
				{
					Transform parent2 = mTrans.parent;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+F8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+98]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+F4]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+F0]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+90]");
					_ = 0;
					Vector3 position7 = vector + 16;
					Vector3 vector5 = parent2.InverseTransformPoint(position7);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
					double num14 = default;
					double num13 = Math.Abs(num14);
					if (!(num13 < 2147483648.0))
					{
						num14 = -2147483648.0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
					double num16 = default;
					double num15 = Math.Abs(num16);
					if (!(num15 < 2147483648.0))
					{
						num16 = -2147483648.0;
					}
					Vector3 localPosition = mTrans.localPosition;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+F0]");
					double num17 = 0.0 - num14;
					double num18 = num17 * num17;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+F4]");
					double num19 = 0.0 - num16;
					double num20 = num19 * num19;
					double num21 = num18 + num20;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+F8]");
					nint num22 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+F8]");
					object obj21 = num22 - 0;
					object obj22 = obj21 * obj21;
					double num23 = num21 + (double)obj22;
					if (!(num23 < 9.999999439624929E-11))
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+F8]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
						((Vector3*)(nint)vector)->z = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
						((Vector3*)(nint)vector)->x = 0f;
						mTrans.localPosition = vector;
					}
					goto IL_0bbd;
				}
			}
			goto IL_0ff5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		if (uIPanel != null)
		{
			Transform cachedTransform = uIPanel.cachedTransform;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B0]");
			_ = 0;
			Vector3 position8 = vector + 80;
			Vector3 vector6 = cachedTransform.TransformPoint(position8);
			goto IL_0b4d;
		}
		bool flag9 = container != null;
		bool flag10 = !flag9;
		object obj23 = default;
		obj7 = obj23;
		object obj24 = default;
		obj10 = obj24;
		if (!flag10)
		{
			Transform transform = container.transform;
			Transform parent3 = transform.parent;
			bool flag11 = parent3 != null;
			bool flag12 = !flag11;
			obj7 = obj23;
			obj10 = obj24;
			if (!flag12)
			{
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A0]");
				_ = 0;
				Vector3 position9 = vector + 96;
				Vector3 vector7 = parent3.TransformPoint(position9);
				goto IL_0b4d;
			}
		}
		goto IL_1182;
		IL_00ec:
		if (uIWidget != null)
		{
			Transform transform2 = container.transform;
			Transform parent4 = transform2.parent;
			Bounds bounds = uIWidget.CalculateBounds(parent4);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+100]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+F8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+F0]");
			_ = 0;
			Bounds bounds2 = (Bounds)(vector + 312);
			Vector3 min = ((Bounds*)bounds2)->min;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+F0]");
			mRect = (Rect)0;
			Bounds bounds3 = (Bounds)(vector + 312);
			Vector3 min2 = ((Bounds*)bounds3)->min;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+F4]");
			_ = 0;
			Bounds bounds4 = (Bounds)(vector + 312);
			Vector3 size = ((Bounds*)bounds4)->size;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+F0]");
			_ = 0;
			Bounds bounds5 = (Bounds)(vector + 312);
			Vector3 size2 = ((Bounds*)bounds5)->size;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+F4]");
			_ = 0;
		}
		else if (uIPanel != null)
		{
			if (uIPanel.mClipping == UIDrawCall.Clipping.None)
			{
				bool flag13 = mRoot != null;
				bool flag14 = !flag13;
				float num24 = 0.5f;
				if (!flag14)
				{
					int activeHeight = mRoot.activeHeight;
					int height = Screen.height;
					int num25 = activeHeight / height;
					float num26 = (float)num25 * 0.5f;
					num24 = num26;
				}
				int width = Screen.width;
				object obj25 = -width;
				float num27 = (float)obj25 * num24;
				object obj26 = this + 56;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ S0_v357+8]");
				object obj27 = 0 + obj26;
				obj26 = num27;
				float num28 = (float)obj27 - num27;
				int height2 = Screen.height;
				object obj28 = -height2;
				float num29 = (float)obj28 * num24;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ S0_v357+C]");
				nint num30 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ S0_v357+4]");
				object obj29 = num30 + 0;
				float num31 = (float)obj29 - num29;
				float num32 = 0f - (float)obj26;
				float num33 = num32 - (float)obj26;
				float num34 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ S0_v357+4]");
				float num35 = num34 - 0f;
				float num36 = num35;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ S0_v357+4]");
				float num37 = num36 - 0f;
			}
			else
			{
				Vector4 finalClipRegion = uIPanel.finalClipRegion;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+F8]");
				float num38 = 0f * 0.5f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+F0]");
				float num39 = 0f - num38;
				mRect = (Rect)num39;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+FC]");
				float num40 = 0f * 0.5f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+F4]");
				float num41 = 0f - num40;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+F8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+FC]");
				_ = 0;
			}
		}
		else if (container != null)
		{
			Transform transform3 = container.transform;
			Transform parent5 = transform3.parent;
			bool flag15 = parent5 != null;
			Transform transform4 = container.transform;
			if (flag15)
			{
				Bounds bounds6 = NGUIMath.CalculateRelativeWidgetBounds(parent5, transform4);
			}
			else
			{
				Bounds bounds7 = NGUIMath.CalculateRelativeWidgetBounds(transform4);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+100]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+F8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+F0]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+118]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+110]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+108]");
			_ = 0;
			Bounds bounds8 = (Bounds)(vector + 288);
			Vector3 min3 = ((Bounds*)bounds8)->min;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+F0]");
			mRect = (Rect)0;
			Bounds bounds9 = (Bounds)(vector + 288);
			Vector3 min4 = ((Bounds*)bounds9)->min;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+F4]");
			_ = 0;
			Bounds bounds10 = (Bounds)(vector + 288);
			Vector3 size3 = ((Bounds*)bounds10)->size;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+F0]");
			_ = 0;
			Bounds bounds11 = (Bounds)(vector + 288);
			Vector3 size4 = ((Bounds*)bounds11)->size;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+F4]");
			_ = 0;
			obj20 = 0;
		}
		else
		{
			if (!(uiCamera != null))
			{
				return;
			}
			Rect pixelRect = uiCamera.pixelRect;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+E8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+E0]");
			_ = 0;
			object obj30 = this - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+E8]");
			obj30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+E0]");
			mRect = (Rect)0;
			obj20 = 1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIAnchor)+40]");
		object obj31 = 0 + mRect;
		object obj32 = mRect + obj31;
		float num42 = (float)obj32 * 0.5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIAnchor)+44]");
		nint num43 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIAnchor)+3C]");
		object obj33 = num43 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIAnchor)+3C]");
		object obj34 = 0 + obj33;
		num2 = (float)obj34 * 0.5f;
		object obj35 = this.side - 3;
		bool flag16 = this.side == Side.Top;
		num6 = num42;
		side = this.side;
		if (!flag16)
		{
			float num44;
			if ((nint)obj35 != 1 && (nint)obj35 != 2 && (nint)obj35 != 3)
			{
				bool flag17 = (nint)obj35 == 4;
				num6 = num42;
				side = this.side;
				if (flag17)
				{
					goto IL_0e65;
				}
				bool flag18 = (nint)obj35 == 5;
				num = num2;
				num6 = num42;
				if (flag18)
				{
					goto IL_0e90;
				}
				num44 = (float)mRect;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIAnchor)+40]");
				num44 = 0f + (float)mRect;
			}
			num6 = num44;
			side = this.side;
		}
		goto IL_0e65;
	}
}
