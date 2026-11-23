using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public class UITooltip : MonoBehaviour
{
	protected static UITooltip mInstance;

	public Camera uiCamera;

	public UILabel text;

	public UISprite background;

	public float appearSpeed = 10f;

	public bool scalingTransitions = true;

	protected GameObject mTooltip;

	protected Transform mTrans;

	protected float mTarget;

	protected float mCurrent;

	protected Vector3 mPos;

	protected Vector3 mSize;

	protected UIWidget[] mWidgets;

	public static bool isVisible
	{
		get
		{
			if (mInstance != null)
			{
				UITooltip uITooltip = mInstance;
				return uITooltip.mTarget == 1f;
			}
			return false;
		}
	}

	private void Awake()
	{
		mInstance = this;
	}

	private void OnDestroy()
	{
		mInstance = null;
	}

	protected virtual void Start()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00ed: Expected VT, but got Obj
		//IL_00f7: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 - 32;
		Transform transform = base.transform;
		mTrans = transform;
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v31 @ S4_v3 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.Component::GetComponentsInChildren>>)+4] (should have been resolved before IL gen)");
		UIWidget[] array = default;
		mWidgets = array;
		Vector3 localPosition = mTrans.localPosition;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		mPos = (Vector3)obj;
		if (uiCamera == null)
		{
			GameObject gameObject = base.gameObject;
			int layer = gameObject.layer;
			Camera camera = NGUITools.FindCameraForLayer(layer);
			uiCamera = camera;
		}
		nint num3 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v76 @ S2_v7 (Il2CppClass<UITooltip>)+EC] (should have been resolved before IL gen)");
	}

	protected unsafe virtual void Update()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0238: Expected I, but got Obj
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected Obj, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected Obj, but got Unknown
		//IL_0274: Expected I, but got Obj
		//IL_0413: Unknown result type (might be due to invalid IL or missing references)
		//IL_0418: Expected VT, but got Unknown
		//IL_0458: Expected F4, but got I
		//IL_0453: Expected native int or pointer, but got VT
		//IL_0477: Expected F4, but got I
		//IL_0472: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj + -64);
		float num;
		if (!(mTooltip != UICamera.mTooltip))
		{
			num = mTarget;
		}
		else
		{
			mTooltip = null;
			mTarget = 0f;
			num = 0f;
		}
		if (num == mCurrent)
		{
			return;
		}
		float num2 = num - mCurrent;
		float unscaledDeltaTime = Time.unscaledDeltaTime;
		float num3 = unscaledDeltaTime * appearSpeed;
		float num4 = Math.Min(num3, 1f);
		bool flag = num3 < 0f;
		float num5 = 0f;
		if (!flag)
		{
			num5 = num4;
		}
		float num6 = num2 * num5;
		float value = (mCurrent += num6) - mTarget;
		float num7 = Math.Abs(value);
		float num8;
		if (!(num7 < 0.001f))
		{
			num8 = mCurrent;
		}
		else
		{
			mCurrent = mTarget;
			num8 = mTarget;
		}
		float num9 = num8 * num8;
		nint num10 = (nint)this;
		object obj2 = this + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v162 @ S2_v8 (Il2CppClass<UITooltip>)+EC] (should have been resolved before IL gen)");
		if (~(scalingTransitions ? 1u : 0u) == 0)
		{
			float num11 = (float)mSize * 0.25f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UITooltip)+44]");
			float num12 = 0f * 0.25f;
			object obj3 = this - -64;
			float num13 = (float)obj3 * 0.25f;
			float num14 = 0f - num13;
			nint num15 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ S0_v55 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num16 = 0;
			float num17 = mCurrent * 0.5f;
			float num18 = 1.5f - num17;
			float num19 = (float)Vector3.oneVector * num18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ S0_v56 (Il2CppStaticFields<UnityEngine.Vector3>)+10]");
			float num20 = 0f * num18;
			float num21 = (float)mPos - num11;
			float num22 = (float)mPos - num21;
			float num23 = Math.Min(mCurrent, 1f);
			bool flag2 = mCurrent < 0f;
			float num24 = 0f;
			if (!flag2)
			{
				num24 = num23;
			}
			float num25 = num22 * num24;
			float num26 = num21 + num25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UITooltip)+34]");
			float num27 = 0f - num14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UITooltip)+34]");
			float num28 = 0f - num27;
			float num29 = num28 * num24;
			float num30 = num27 + num29;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UITooltip)+38]");
			float num31 = 0f - num12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UITooltip)+38]");
			float num32 = 0f - num31;
			float num33 = num32 * num24;
			float num34 = num31 + num33;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
			_ = 0;
			Vector3 localPosition = vector + 16;
			mTrans.localPosition = localPosition;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ S0_v56 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
			float num35 = 0f * num18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
			((Vector3*)(nint)vector)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
			((Vector3*)(nint)vector)->x = 0f;
			mTrans.localScale = vector;
		}
	}

	protected unsafe virtual void SetAlpha(float val)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_004a: Expected Obj, but got I
		//IL_0071: Expected F4, but got I
		//IL_006c: Expected native int or pointer, but got VT
		//IL_008d: Expected F4, but got VT
		//IL_0088: Expected native int or pointer, but got VT
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected Obj, but got Unknown
		object obj = default;
		Color color = (Color)(obj - 32);
		UIWidget[] array = mWidgets;
		object obj2 = default;
		object obj4 = default;
		while ((nint)obj2 < array.Length)
		{
			object obj3 = obj4 << 2;
			object obj5 = (object)mWidgets + obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S1_v7+10]");
			UIWidget uIWidget = (UIWidget)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S1_v8 (UIWidget)+54]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+18]");
			((Color*)(nint)color)->b = 0f;
			_ = uIWidget.mColor;
			((Color*)(nint)color)->r = (float)uIWidget.mColor;
			uIWidget.color = color;
			obj2 = obj4 + 1;
		}
	}

	protected unsafe virtual void SetText(string tooltipText)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0055: Expected Obj, but got I4
		//IL_0039: Expected Obj, but got I4
		//IL_0086: Expected Obj, but got I
		//IL_009d: Expected VT, but got I
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected Obj, but got Unknown
		//IL_0106: Expected Obj, but got I
		//IL_0120: Expected VT, but got I
		//IL_013d: Expected VT, but got I
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected Obj, but got Unknown
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected Obj, but got Unknown
		//IL_01b2: Expected I, but got Obj
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected Obj, but got Unknown
		//IL_01e7: Expected Obj, but got I
		//IL_0204: Expected Obj, but got I
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Expected VT, but got Unknown
		//IL_0254: Expected Obj, but got I
		//IL_0561: Expected Obj, but got VT
		//IL_07b9: Expected Obj, but got I
		//IL_07c2: Invalid comparison between Obj and F4
		//IL_08b4: Expected VT, but got F4
		//IL_05a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a9: Expected VT, but got Unknown
		//IL_06aa: Expected VT, but got F4
		//IL_02f6: Expected I4, but got F8
		//IL_0429: Expected F4, but got VT
		//IL_0489: Invalid comparison between F4 and VT
		//IL_0741: Expected VT, but got F4
		//IL_0751: Expected F4, but got I
		//IL_0787: Invalid comparison between F4 and I
		//IL_033d: Expected I4, but got F8
		//IL_0803: Unknown result type (might be due to invalid IL or missing references)
		//IL_0808: Expected VT, but got Unknown
		//IL_0858: Unknown result type (might be due to invalid IL or missing references)
		//IL_085d: Expected VT, but got Unknown
		//IL_04f0: Expected VT, but got I
		//IL_052d: Expected F4, but got I
		//IL_0528: Expected native int or pointer, but got VT
		//IL_053c: Expected F4, but got VT
		//IL_0537: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 96);
		if (!(text != null))
		{
			goto IL_05ca;
		}
		object obj2;
		if (tooltipText != null)
		{
			obj2 = 0;
			if (tooltipText._stringLength != 0)
			{
				goto IL_060a;
			}
		}
		obj2 = 1;
		goto IL_060a;
		IL_060a:
		if (obj2 == null)
		{
			mTarget = 1f;
			mTooltip = UICamera.mTooltip;
			text.text = tooltipText;
			Vector2 lastEventPosition = UICamera.lastEventPosition;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
			object obj3 = (nint)0 >> 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
			mPos = (Vector3)0;
			Transform transform = text.transform;
			Vector3 localPosition = transform.localPosition;
			Vector3 localScale = transform.localScale;
			Vector2 printedSize = text.printedSize;
			_ = 0;
			object obj4 = this - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
			object obj5 = (nint)0 >> 32;
			obj4 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
			mSize = (Vector3)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
			Vector3 vector2 = (Vector3)(num * 0);
			mSize = vector2;
			object obj6 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+54]");
			object obj7 = obj6 * 0;
			obj4 = obj7;
			if (background != null)
			{
				object obj8 = vector + 80;
				UISprite uISprite = background;
				nint num2 = (nint)uISprite;
				object obj9 = uISprite + 256;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v225 @ S2_v45 (Il2CppClass<UISprite>)+1BC] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
				object obj10 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
				object obj11 = num4 - 0;
				object obj12 = obj11 + obj11;
				object obj13 = obj10 + obj12;
				Vector3 vector3 = mSize + obj13;
				mSize = vector3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+54]");
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+5C]");
				object obj14 = num5 + 0;
				float num6 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+54]");
				float num7 = num6 - 0f;
				float num8 = num7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+54]");
				float num9 = num8 - 0f;
				float num10 = num9 + num9;
				float num11 = (float)obj14 + num10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UITooltip)+40]");
				float num12 = 0f + num11;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
				double num14 = default;
				double num13 = Math.Abs(num14);
				int width = ((!(num13 < 2147483648.0)) ? int.MinValue : ((int)num14));
				background.width = width;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
				double num16 = default;
				double num15 = Math.Abs(num16);
				int height = ((!(num15 < 2147483648.0)) ? int.MinValue : ((int)num16));
				background.height = height;
			}
			if (uiCamera != null)
			{
				int width2 = Screen.width;
				float num17 = (float)mPos / (float)width2;
				float num18 = Math.Min(num17, 1f);
				bool flag = num17 < 0f;
				float num19 = 0f;
				if (!flag)
				{
					num19 = num18;
				}
				mPos = (Vector3)num19;
				int height2 = Screen.height;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UITooltip)+34]");
				float num20 = 0f / (float)height2;
				float num21 = Math.Min(num20, 1f);
				bool flag2 = num20 < 0f;
				float num22 = 0f;
				if (!flag2)
				{
					num22 = num21;
				}
				float orthographicSize = uiCamera.orthographicSize;
				Transform parent = mTrans.parent;
				Vector3 lossyScale = parent.lossyScale;
				int height3 = Screen.height;
				float num23 = (float)height3 * 0.5f;
				int width3 = Screen.width;
				int height4 = Screen.height;
				float num24 = (float)mPos;
				float num25 = orthographicSize;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+54]");
				float num26 = num25 / 0f;
				float num27 = num23 / num26;
				float num28 = num27 * (float)mSize;
				float num29 = num28 / (float)width3;
				float num30 = 1f - num29;
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num30) <= System.Runtime.CompilerServices.Unsafe.As<Vector3, UIntPtr>(ref mPos))
				{
					num24 = num30;
				}
				mPos = (Vector3)num24;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UITooltip)+34]");
				float num31 = 0f;
				float num32 = num27;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UITooltip)+40]");
				float num33 = num32 * 0f;
				float num34 = num33 / (float)height4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UITooltip)+34]");
				if (!(num34 < 0f))
				{
					num31 = num34;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UITooltip)+38]");
				_ = 0;
				_ = mPos;
				Vector3 position = vector + 32;
				Vector3 vector4 = uiCamera.ViewportToWorldPoint(position);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
				_ = 0;
				Vector3 position2 = vector + 16;
				mTrans.position = position2;
				Vector3 localPosition2 = mTrans.localPosition;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
				mPos = (Vector3)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
				Vector3 vector5 = default;
				mPos = vector5;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UITooltip)+38]");
				((Vector3*)(nint)vector)->z = 0f;
				((Vector3*)(nint)vector)->x = (float)mPos;
				mTrans.localPosition = vector;
			}
			else
			{
				object obj15 = mPos + mSize;
				int width4 = Screen.width;
				if ((nint)obj15 > width4)
				{
					int width5 = Screen.width;
					Vector3 vector6 = width5 - mSize;
					mPos = vector6;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UITooltip)+34]");
				nint num35 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UITooltip)+40]");
				object obj16 = num35 - 0;
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj16) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0f))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UITooltip)+40]");
					_ = 0;
				}
				int width6 = Screen.width;
				float num36 = (float)width6 * 0.5f;
				float num37 = (float)mPos - num36;
				mPos = (Vector3)num37;
				int height5 = Screen.height;
				float num38 = (float)height5 * 0.5f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UITooltip)+34]");
				float num39 = 0f - num38;
			}
			return;
		}
		goto IL_05ca;
		IL_05ca:
		mTooltip = null;
		mTarget = 0f;
	}

	public static void ShowText(string text)
	{
		//IL_0016: Expected I, but got Obj
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected Obj, but got Unknown
		if (mInstance != null)
		{
			UITooltip uITooltip = mInstance;
			nint num = (nint)uITooltip;
			object obj = uITooltip + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v31 @ S2_v4 (Il2CppClass<UITooltip>)+F4] (should have been resolved before IL gen)");
		}
	}

	public static void Show(string text)
	{
		//IL_0016: Expected I, but got Obj
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected Obj, but got Unknown
		if (mInstance != null)
		{
			UITooltip uITooltip = mInstance;
			nint num = (nint)uITooltip;
			object obj = uITooltip + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v31 @ S2_v4 (Il2CppClass<UITooltip>)+F4] (should have been resolved before IL gen)");
		}
	}

	public static void Hide()
	{
		if (mInstance != null)
		{
			UITooltip uITooltip = mInstance;
			uITooltip.mTooltip = null;
			UITooltip uITooltip2 = mInstance;
			uITooltip2.mTarget = 0f;
		}
	}

	public UITooltip()
	{
		//IL_0029: Expected I, but got Obj
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v8 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v9 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		mSize = Vector3.zeroVector;
		base._002Ector();
	}
}
