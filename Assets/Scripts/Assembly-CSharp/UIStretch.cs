using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public class UIStretch : MonoBehaviour
{
	public enum Style
	{
		None,
		Horizontal,
		Vertical,
		Both,
		BasedOnHeight,
		FillKeepingRatio,
		FitInternalKeepingRatio
	}

	public Camera uiCamera;

	public GameObject container;

	public Style style;

	public bool runOnlyOnce = true;

	public Vector2 relativeSize = Vector2.oneVector;

	public Vector2 initialSize = Vector2.oneVector;

	public Vector2 borderPadding = Vector2.zeroVector;

	private UIWidget widgetContainer;

	private Transform mTrans;

	private UIWidget mWidget;

	private UISprite mSprite;

	private UIPanel mPanel;

	private UIRoot mRoot;

	private Animation mAnim;

	private Rect mRect;

	private bool mStarted;

	private unsafe void Awake()
	{
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected Obj, but got Unknown
		Animation component = GetComponent<Animation>();
		mAnim = component;
		object obj = this + 80;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		Transform transform = base.transform;
		mTrans = transform;
		UIWidget component2 = GetComponent<UIWidget>();
		mWidget = component2;
		UISprite component3 = GetComponent<UISprite>();
		mSprite = component3;
		UIPanel component4 = GetComponent<UIPanel>();
		mPanel = component4;
		UICamera.OnScreenResize onScreenResize = default;
		onScreenResize._002Ector(this, (nint)__ldftn(UIStretch.ScreenSizeChanged));
		Delegate obj2 = Delegate.Combine(UICamera.onScreenResize, onScreenResize);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		UICamera.OnScreenResize onScreenResize2 = default;
		UICamera.onScreenResize = onScreenResize2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
	}

	private unsafe void OnDestroy()
	{
		UICamera.OnScreenResize onScreenResize = default;
		onScreenResize._002Ector(this, (nint)__ldftn(UIStretch.ScreenSizeChanged));
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
			object obj2 = this + 52;
			GameObject gameObject = ((Component)obj2).gameObject;
			obj = gameObject;
			obj2 = 0;
		}
		if (uiCamera == null)
		{
			GameObject gameObject2 = base.gameObject;
			int layer = gameObject2.layer;
			Camera camera = NGUITools.FindCameraForLayer(layer);
			uiCamera = camera;
		}
		GameObject go = base.gameObject;
		UIRoot uIRoot = NGUITools.FindInParents<UIRoot>(go);
		mRoot = uIRoot;
		Update();
		mStarted = true;
	}

	private unsafe void Update()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected VT, but got Unknown
		//IL_017a: Expected Ref, but got VT
		//IL_0195: Expected VT, but got I
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected VT, but got Unknown
		//IL_01ac: Expected Ref, but got VT
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected VT, but got Unknown
		//IL_01d4: Expected Ref, but got VT
		//IL_033d: Expected VT, but got F4
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Expected VT, but got Unknown
		//IL_0201: Expected Ref, but got VT
		//IL_05c7: Expected VT, but got I
		//IL_075a: Expected Obj, but got I
		//IL_0660: Invalid comparison between I and F4
		//IL_0edd: Expected Obj, but got I4
		//IL_0ef2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef7: Expected Obj, but got Unknown
		//IL_0f07: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f0c: Expected Obj, but got Unknown
		//IL_0f14: Expected Obj, but got F4
		//IL_0f3f: Expected Obj, but got I4
		//IL_0f6b: Expected Obj, but got I
		//IL_1023: Expected Obj, but got I4
		//IL_049d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a2: Expected VT, but got Unknown
		//IL_04ab: Expected Ref, but got VT
		//IL_04c1: Expected VT, but got I
		//IL_04ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cf: Expected VT, but got Unknown
		//IL_04d8: Expected Ref, but got VT
		//IL_04f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fc: Expected VT, but got Unknown
		//IL_0505: Expected Ref, but got VT
		//IL_051f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0524: Expected VT, but got Unknown
		//IL_052d: Expected Ref, but got VT
		//IL_09a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09aa: Expected I4, but got Unknown
		//IL_07f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f7: Expected I4, but got Unknown
		//IL_0bd8: Expected Obj, but got I
		//IL_0833: Unknown result type (might be due to invalid IL or missing references)
		//IL_0838: Expected Obj, but got Unknown
		//IL_0b72: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b77: Expected Obj, but got Unknown
		//IL_08c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c9: Expected I4, but got Unknown
		//IL_132f: Expected Obj, but got I
		//IL_1351: Expected Obj, but got I
		//IL_137b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1380: Expected Obj, but got Unknown
		//IL_13a3: Invalid comparison between Obj and F4
		//IL_0d47: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d4c: Expected I4, but got Unknown
		//IL_0caa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0caf: Expected Obj, but got Unknown
		//IL_0cbf: Expected Obj, but got I
		//IL_0876: Unknown result type (might be due to invalid IL or missing references)
		//IL_087b: Expected I4, but got Unknown
		//IL_08f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f5: Expected Obj, but got Unknown
		//IL_12a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ab: Expected VT, but got Unknown
		//IL_0c9b: Expected Obj, but got I
		//IL_0981: Unknown result type (might be due to invalid IL or missing references)
		//IL_0986: Expected I4, but got Unknown
		//IL_0dbf: Expected F4, but got I
		//IL_0dba: Expected native int or pointer, but got VT
		//IL_0dde: Expected F4, but got I
		//IL_0dd9: Expected native int or pointer, but got VT
		//IL_12cd: Expected I, but got Obj
		//IL_12ed: Expected Obj, but got I
		//IL_12f6: Expected I4, but got VT
		//IL_0d03: Expected Obj, but got I
		//IL_0c11: Expected I4, but got F8
		//IL_0af5: Expected I4, but got F8
		//IL_0933: Unknown result type (might be due to invalid IL or missing references)
		//IL_0938: Expected I4, but got Unknown
		//IL_0bb0: Expected I4, but got F8
		//IL_0aa9: Expected I4, but got F8
		//IL_1234: Expected I, but got Obj
		//IL_1254: Expected Obj, but got I
		//IL_125d: Expected I4, but got VT
		//IL_116e: Expected I, but got Obj
		//IL_118e: Expected Obj, but got I
		//IL_1197: Expected I4, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 176);
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		if ((mAnim != null && mAnim.isPlaying) || style == Style.None)
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
				goto IL_00e3;
			}
		}
		uIPanel = container.GetComponent<UIPanel>();
		goto IL_00e3;
		IL_1272:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
		_ = 0;
		UIPanel uIPanel2;
		_ = uIPanel2.mClipRange;
		_ = uIPanel2.mClipRange;
		Vector4 baseClipRegion = (Vector4)(vector + 16);
		mPanel.baseClipRegion = baseClipRegion;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1054 @ S0_v144 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1055 @ S0_v145 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
		object obj2 = 0;
		int num3 = (int)Vector3.oneVector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1055 @ S0_v145 (Il2CppStaticFields<UnityEngine.Vector3>)+10]");
		int num4 = 0;
		goto IL_130b;
		IL_104a:
		int num8;
		if (mSprite != null)
		{
			UISprite uISprite = mSprite;
			bool flag5 = uISprite.mAtlas != null;
			bool flag6 = !flag5;
			float num5 = 1f;
			if (!flag6)
			{
				UISprite uISprite2 = mSprite;
				float pixelSize = uISprite2.mAtlas.pixelSize;
				num5 = pixelSize;
			}
			float num6 = (float)borderPadding * num5;
			float num7 = (float)num8 - num6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIStretch)+30]");
			float num9 = 0f * num5;
			float num10 = (float)num4 - num9;
			if (style != Style.Vertical)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
				double num12 = default;
				double num11 = Math.Abs(num12);
				int width = ((!(num11 < 2147483648.0)) ? int.MinValue : ((int)num12));
				mSprite.width = width;
				if (style == Style.Horizontal)
				{
					goto IL_1160;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
			double num14 = default;
			double num13 = Math.Abs(num14);
			int height = ((!(num13 < 2147483648.0)) ? int.MinValue : ((int)num14));
			mSprite.height = height;
			goto IL_1160;
		}
		if (mWidget != null)
		{
			if (style != Style.Vertical)
			{
				object obj3 = num8 - borderPadding;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
				double num16 = default;
				double num15 = Math.Abs(num16);
				int width2 = ((!(num15 < 2147483648.0)) ? int.MinValue : ((int)num16));
				mWidget.width = width2;
				if (style == Style.Horizontal)
				{
					goto IL_1226;
				}
			}
			int num17 = num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIStretch)+30]");
			object obj4 = (nint)num17 - (nint)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
			double num19 = default;
			double num18 = Math.Abs(num19);
			int height2 = ((!(num18 < 2147483648.0)) ? int.MinValue : ((int)num19));
			mWidget.height = height2;
			goto IL_1226;
		}
		if (mPanel != null)
		{
			uIPanel2 = mPanel;
			object obj5;
			object obj7;
			object obj8;
			if (style == Style.Vertical)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v877 @ S0_v125 (UIPanel)+D0]");
				obj5 = 0;
			}
			else
			{
				object obj6 = num8 - borderPadding;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v877 @ S0_v125 (UIPanel)+D4]");
				obj7 = 0;
				bool flag7 = style == Style.Horizontal;
				obj5 = obj6;
				obj8 = obj6;
				if (flag7)
				{
					goto IL_1272;
				}
			}
			int num20 = num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIStretch)+30]");
			obj7 = (nint)num20 - (nint)0;
			obj8 = obj5;
			goto IL_1272;
		}
		if (style != Style.Vertical)
		{
			int num21 = (int)(num8 - borderPadding);
			bool flag8 = style == Style.Horizontal;
			num8 = num21;
			num3 = num21;
			if (flag8)
			{
				goto IL_130b;
			}
		}
		int num22 = num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIStretch)+30]");
		int num23 = (int)((nint)num22 - (nint)0);
		num3 = num8;
		num4 = num23;
		goto IL_130b;
		IL_1160:
		nint num24 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1108 @ S0_v232 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1109 @ S0_v233 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
		obj2 = 0;
		num3 = (int)Vector3.oneVector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1109 @ S0_v233 (Il2CppStaticFields<UnityEngine.Vector3>)+10]");
		num4 = 0;
		goto IL_130b;
		IL_099b:
		int num27;
		int num26 = (int)(relativeSize * num27);
		bool flag9 = style == Style.Horizontal;
		int num28 = num26;
		num8 = num26;
		if (!flag9)
		{
			goto IL_09d9;
		}
		goto IL_104a;
		IL_09d9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIStretch)+20]");
		int num30;
		int num29 = (int)((nint)0 * (nint)num30);
		num8 = num28;
		num4 = num29;
		goto IL_104a;
		IL_130b:
		Vector3 localScale = mTrans.localScale;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
		object obj9 = -num3;
		object obj10 = obj9 * obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+54]");
		object obj11 = -num4;
		object obj12 = obj11 * obj11;
		object obj13 = obj10 + obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
		object obj14 = 0 - obj2;
		object obj15 = obj14 * obj14;
		object obj16 = obj13 + obj15;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj16) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)9.9999994E-11f))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
			((Vector3*)(nint)vector)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
			((Vector3*)(nint)vector)->x = 0f;
			mTrans.localScale = vector;
		}
		if (~(runOnlyOnce ? 1u : 0u) == 0 && Application.isPlaying)
		{
			enabled = false;
		}
		return;
		IL_1226:
		nint num31 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1119 @ S0_v171 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1120 @ S0_v172 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
		obj2 = 0;
		num3 = (int)Vector3.oneVector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1120 @ S0_v172 (Il2CppStaticFields<UnityEngine.Vector3>)+10]");
		num4 = 0;
		goto IL_130b;
		IL_00e3:
		float num33;
		if (uIWidget != null)
		{
			Transform transform = base.transform;
			Transform parent = transform.parent;
			Bounds bounds = uIWidget.CalculateBounds(parent);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
			_ = 0;
			Bounds bounds2 = (Bounds)(vector + 152);
			Vector3 min = ((Bounds*)bounds2)->min;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
			mRect = (Rect)0;
			Bounds bounds3 = (Bounds)(vector + 152);
			Vector3 min2 = ((Bounds*)bounds3)->min;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+54]");
			_ = 0;
			Bounds bounds4 = (Bounds)(vector + 152);
			Vector3 size = ((Bounds*)bounds4)->size;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
			_ = 0;
			Bounds bounds5 = (Bounds)(vector + 152);
			Vector3 size2 = ((Bounds*)bounds5)->size;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+54]");
			_ = 0;
			num33 = 1f;
		}
		else if (uIPanel != null)
		{
			if (uIPanel.mClipping == UIDrawCall.Clipping.None)
			{
				bool flag10 = mRoot != null;
				bool flag11 = !flag10;
				float num34 = 0.5f;
				if (!flag11)
				{
					int activeHeight = mRoot.activeHeight;
					int height3 = Screen.height;
					int num35 = activeHeight / height3;
					float num36 = (float)num35 * 0.5f;
					num34 = num36;
				}
				int width3 = Screen.width;
				object obj17 = -width3;
				float num37 = (float)obj17 * num34;
				object obj18 = this + 80;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ S0_v419+8]");
				object obj19 = 0 + obj18;
				obj18 = num37;
				float num38 = (float)obj19 - num37;
				int height4 = Screen.height;
				object obj20 = -height4;
				float num39 = (float)obj20 * num34;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ S0_v419+C]");
				nint num40 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ S0_v419+4]");
				object obj21 = num40 + 0;
				float num41 = (float)obj21 - num39;
				float num42 = 0f - (float)obj18;
				float num43 = num42 - (float)obj18;
				float num44 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ S0_v419+4]");
				float num45 = num44 - 0f;
				float num46 = num45;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ S0_v419+4]");
				float num47 = num46 - 0f;
				num33 = 1f;
			}
			else
			{
				Vector4 finalClipRegion = uIPanel.finalClipRegion;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
				float num48 = 0f * 0.5f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
				float num49 = 0f - num48;
				mRect = (Rect)num49;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+5C]");
				float num50 = 0f * 0.5f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+54]");
				float num51 = 0f - num50;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+5C]");
				_ = 0;
				num33 = 1f;
			}
		}
		else if (container != null)
		{
			Transform transform2 = base.transform;
			Transform parent2 = transform2.parent;
			bool flag12 = parent2 != null;
			Transform transform3 = container.transform;
			if (flag12)
			{
				Bounds bounds6 = NGUIMath.CalculateRelativeWidgetBounds(parent2, transform3);
			}
			else
			{
				Bounds bounds7 = NGUIMath.CalculateRelativeWidgetBounds(transform3);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+78]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+70]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
			_ = 0;
			Bounds bounds8 = (Bounds)(vector + 128);
			Vector3 min3 = ((Bounds*)bounds8)->min;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
			mRect = (Rect)0;
			Bounds bounds9 = (Bounds)(vector + 128);
			Vector3 min4 = ((Bounds*)bounds9)->min;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+54]");
			_ = 0;
			Bounds bounds10 = (Bounds)(vector + 128);
			Vector3 size3 = ((Bounds*)bounds10)->size;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
			_ = 0;
			Bounds bounds11 = (Bounds)(vector + 128);
			Vector3 size4 = ((Bounds*)bounds11)->size;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+54]");
			_ = 0;
			num33 = 1f;
		}
		else
		{
			if (!(uiCamera != null))
			{
				return;
			}
			Rect pixelRect = uiCamera.pixelRect;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
			mRect = (Rect)0;
			bool flag13 = mRoot != null;
			bool flag14 = !flag13;
			num33 = 1f;
			if (!flag14)
			{
				num33 = mRoot.pixelSizeAdjustment;
			}
		}
		bool flag15 = num33 == 1f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIStretch)+58]");
		num27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIStretch)+5C]");
		num30 = 0;
		if (!flag15)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIStretch)+5C]");
			bool flag16 = 0f > 1f;
			bool flag17 = !flag16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIStretch)+58]");
			num27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIStretch)+5C]");
			num30 = 0;
			if (!flag17)
			{
				int activeHeight2 = mRoot.activeHeight;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIStretch)+5C]");
				int num52 = (int)((nint)activeHeight2 / (nint)0);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIStretch)+58]");
				int num53 = (int)((nint)0 * (nint)num52);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIStretch)+5C]");
				int num54 = (int)((nint)0 * (nint)num52);
				num27 = num53;
				num30 = num54;
			}
		}
		int num55;
		if (mWidget != null)
		{
			UIWidget uIWidget2 = mWidget;
			num55 = uIWidget2.mWidth;
			num4 = uIWidget2.mHeight;
		}
		else
		{
			Vector3 localScale2 = mTrans.localScale;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
			num55 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
			obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+54]");
			num4 = 0;
		}
		object obj22 = style - 2;
		bool flag18 = style == Style.Vertical;
		num28 = num55;
		if (flag18)
		{
			goto IL_09d9;
		}
		if ((nint)obj22 == 1)
		{
			goto IL_099b;
		}
		if ((nint)obj22 != 2)
		{
			if ((nint)obj22 != 3)
			{
				if ((nint)obj22 != 4)
				{
					goto IL_099b;
				}
				Vector2 vector2 = initialSize;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIStretch)+28]");
				object obj23 = vector2 / 0;
				int num56 = num27 / num30;
				if ((nint)obj23 > num56)
				{
					int num57 = (int)(num27 / initialSize);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIStretch)+28]");
					int num58 = (int)((nint)0 * (nint)num57);
					num8 = num27;
					num4 = num58;
				}
				else
				{
					int num59 = num30;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIStretch)+28]");
					int num60 = (int)((nint)num59 / (nint)0);
					int num61 = (int)(initialSize * num60);
					num8 = num61;
					num4 = num30;
				}
			}
			else
			{
				Vector2 vector3 = initialSize;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIStretch)+28]");
				object obj24 = vector3 / 0;
				int num62 = num27 / num30;
				if ((nint)obj24 < num62)
				{
					int num63 = (int)(num27 / initialSize);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIStretch)+28]");
					int num64 = (int)((nint)0 * (nint)num63);
					num8 = num27;
					num4 = num64;
				}
				else
				{
					int num65 = num30;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIStretch)+28]");
					int num66 = (int)((nint)num65 / (nint)0);
					int num67 = (int)(initialSize * num66);
					num8 = num67;
					num4 = num30;
				}
			}
		}
		else
		{
			int num68 = (int)(relativeSize * num30);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIStretch)+20]");
			int num69 = (int)((nint)0 * (nint)num30);
			num8 = num68;
			num4 = num69;
		}
		goto IL_104a;
	}
}
