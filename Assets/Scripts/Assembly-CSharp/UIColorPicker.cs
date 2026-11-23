using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

public class UIColorPicker : MonoBehaviour
{
	public static UIColorPicker current;

	public Color value = (Color)4575657222473777152L;

	public UIWidget selectionWidget;

	public List<EventDelegate> onChange;

	[NonSerialized]
	private Transform mTrans;

	[NonSerialized]
	private UITexture mUITex;

	[NonSerialized]
	private Texture2D mTex;

	[NonSerialized]
	private UICamera mCam;

	[NonSerialized]
	private Vector2 mPos;

	[NonSerialized]
	private int mWidth;

	[NonSerialized]
	private int mHeight;

	private static AnimationCurve mRed;

	private static AnimationCurve mGreen;

	private static AnimationCurve mBlue;

	private void Start()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_007b: Expected Obj, but got I4
		//IL_00b4: Expected Obj, but got I4
		//IL_0204: Expected I, but got Obj
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Expected VT, but got Unknown
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected Obj, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected Obj, but got Unknown
		//IL_0124: Expected Obj, but got I
		//IL_0132: Expected I4, but got Obj
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected Obj, but got Unknown
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 48;
		Transform transform = base.transform;
		mTrans = transform;
		UITexture component = GetComponent<UITexture>();
		mUITex = component;
		GameObject gameObject = base.gameObject;
		int layer = gameObject.layer;
		UICamera uICamera = UICamera.FindCameraForLayer(layer);
		mCam = uICamera;
		UITexture uITexture = mUITex;
		mWidth = ((UIWidget)uITexture).mWidth;
		mHeight = ((UIWidget)uITexture).mHeight;
		object obj3 = ((UIWidget)uITexture).mHeight * ((UIWidget)uITexture).mWidth;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		object obj4 = default;
		Color[] array = default;
		object obj10 = default;
		while (mHeight > (nint)obj4)
		{
			float num = (float)obj4 - 1f;
			float y = num / (float)mHeight;
			object obj5 = 0;
			while (mWidth > (nint)obj5)
			{
				object obj6 = mWidth * obj4;
				object obj7 = obj6 + obj5;
				float num2 = (float)obj5 - 1f;
				float x = num2 / (float)mWidth;
				Color color = Sample(x, y);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
				obj = 0;
				int num3 = obj7 << 4;
				object obj8 = array + num3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				_ = 0;
				object obj9 = obj5 + 1;
				obj5 = obj9;
			}
			obj4 = obj10 + 1;
		}
		Texture2D texture2D = default;
		texture2D._002Ector(mWidth, mHeight, TextureFormat.RGB24, mipChain: false);
		mTex = texture2D;
		mTex.SetPixels(array);
		mTex.filterMode = FilterMode.Trilinear;
		mTex.wrapMode = TextureWrapMode.Clamp;
		mTex.Apply();
		UITexture uITexture2 = mUITex;
		nint num4 = (nint)uITexture2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v181 @ S2_v12 (Il2CppClass<UITexture>)+194] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIColorPicker)+14]");
		_ = 0;
		_ = value;
		Color c = (Color)(obj + 16);
		Vector2 vector = Select(c);
	}

	private void OnDestroy()
	{
		UnityEngine.Object.Destroy(mTex);
		mTex = null;
	}

	private void OnPress(bool pressed)
	{
		if (enabled && pressed)
		{
			UICamera.ControlScheme currentScheme = UICamera.currentScheme;
			if (currentScheme != UICamera.ControlScheme.Controller)
			{
				Sample();
			}
		}
	}

	private void OnDrag(Vector2 delta)
	{
		if (enabled)
		{
			Sample();
		}
	}

	private unsafe void OnPan(Vector2 delta)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00a4: Expected VT, but got F4
		//IL_010c: Expected F4, but got VT
		//IL_0107: Expected native int or pointer, but got VT
		object obj = default;
		Vector2 vector = (Vector2)(obj - 16);
		if (enabled)
		{
			float num = (float)mPos + delta.x;
			float num2 = Math.Min(num, 1f);
			bool flag = num < 0f;
			float num3 = 0f;
			if (!flag)
			{
				num3 = num2;
			}
			mPos = (Vector2)num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIColorPicker)+38]");
			float num4 = 0f + delta.y;
			float num5 = Math.Min(num4, 1f);
			bool flag2 = num4 < 0f;
			float num6 = 0f;
			if (!flag2)
			{
				num6 = num5;
			}
			((Vector2*)(nint)vector)->x = (float)mPos;
			_ = mPos;
			Select(vector);
		}
	}

	private unsafe void Sample()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected VT, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected VT, but got Unknown
		//IL_00c4: Expected I, but got Obj
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected Obj, but got Unknown
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected Obj, but got Unknown
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected Obj, but got Unknown
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected Obj, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected Obj, but got Unknown
		//IL_02e0: Expected VT, but got F4
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Expected Obj, but got Unknown
		//IL_030b: Expected Obj, but got I
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Expected Obj, but got Unknown
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Expected Obj, but got Unknown
		//IL_0344: Expected Obj, but got I
		//IL_0279: Expected F4, but got I
		//IL_0279: Expected F4, but got VT
		//IL_029c: Expected VT, but got I
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected Obj, but got Unknown
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Expected Obj, but got Unknown
		//IL_01c2: Expected F4, but got VT
		//IL_01d1: Invalid comparison between VT and F4
		//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e5: Expected Obj, but got Unknown
		//IL_03ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f3: Expected Obj, but got Unknown
		//IL_0410: Expected Obj, but got I
		//IL_0426: Expected F4, but got I
		//IL_043b: Invalid comparison between I and F4
		//IL_04b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bd: Expected VT, but got Unknown
		//IL_022a: Expected F4, but got I
		//IL_0225: Expected native int or pointer, but got VT
		//IL_024c: Expected F4, but got I
		//IL_0247: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 144);
		Vector2 lastEventPosition = UICamera.lastEventPosition;
		Camera cachedCamera = mCam.cachedCamera;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
		_ = 0;
		Vector3 position = vector + 48;
		Vector3 vector2 = cachedCamera.ScreenToWorldPoint(position);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+78]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+70]");
		_ = 0;
		Vector3 position2 = vector + 32;
		Vector3 vector3 = mTrans.InverseTransformPoint(position2);
		UITexture uITexture = mUITex;
		nint num = (nint)uITexture;
		object obj2 = uITexture + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v91 @ S4_v2 (Il2CppClass<UITexture>)+104] (should have been resolved before IL gen)");
		object obj4 = default;
		object obj3 = obj4 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
		object obj5 = 0 - obj3;
		object obj6 = obj4 + 40;
		object obj7 = obj4 + 16;
		object obj8 = obj6 - obj7;
		float num2 = (float)obj5 / (float)obj8;
		float num3 = Math.Min(num2, 1f);
		bool flag = num2 < 0f;
		float num4 = 0f;
		if (!flag)
		{
			num4 = num3;
		}
		mPos = (Vector2)num4;
		object obj9 = obj4 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+44]");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S3_v18+4]");
		object obj10 = num5 - 0;
		object obj11 = obj4 + 40;
		object obj12 = obj4 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S3_v21+4]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S4_v14+4]");
		object obj13 = num6 - 0;
		float num7 = (float)obj10 / (float)obj13;
		float num8 = Math.Min(num7, 1f);
		bool flag2 = num7 < 0f;
		float num9 = 0f;
		if (!flag2)
		{
			num9 = num8;
		}
		if (selectionWidget != null)
		{
			object obj14 = obj4 + 16;
			object obj15 = obj4 + 40;
			object obj16 = obj15 - obj14;
			float num10 = Math.Min((float)mPos, 1f);
			bool flag3 = mPos < (object)0f;
			float num11 = 0f;
			if (!flag3)
			{
				num11 = num10;
			}
			float num12 = (float)obj16 * num11;
			float num13 = (float)obj14 + num12;
			object obj17 = obj4 + 16;
			object obj18 = obj4 + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ S1_v46+4]");
			nint num14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ S0_v73+4]");
			object obj19 = num14 - 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIColorPicker)+38]");
			float num15 = Math.Min(0f, 1f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIColorPicker)+38]");
			bool flag4 = 0f < 0f;
			float num16 = 0f;
			if (!flag4)
			{
				num16 = num15;
			}
			float num17 = (float)obj19 * num16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ S0_v73+4]");
			float num18 = 0f + num17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
			_ = 0;
			Vector3 position3 = vector + 16;
			Vector3 vector4 = mTrans.TransformPoint(position3);
			Transform trans = selectionWidget.transform;
			Camera cachedCamera2 = mCam.cachedCamera;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
			((Vector3*)(nint)vector)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
			((Vector3*)(nint)vector)->x = 0f;
			NGUIMath.OverlayPosition(trans, vector, cachedCamera2);
		}
		Vector2 vector5 = mPos;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIColorPicker)+38]");
		Color color = Sample((float)vector5, 0f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
		value = (Color)0;
		current = this;
		EventDelegate.Execute(onChange);
		current = null;
	}

	public unsafe void Select(Vector2 v)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_01d0: Expected native int or pointer, but got VT
		//IL_021f: Expected native int or pointer, but got VT
		//IL_0233: Expected VT, but got F4
		//IL_0146: Expected F4, but got I
		//IL_0146: Expected F4, but got VT
		//IL_0169: Expected VT, but got I
		//IL_003f: Expected I, but got Obj
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected Obj, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected Obj, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected Obj, but got Unknown
		//IL_0090: Expected F4, but got VT
		//IL_009f: Invalid comparison between VT and F4
		//IL_0282: Expected native int or pointer, but got VT
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Expected Obj, but got Unknown
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected Obj, but got Unknown
		//IL_02c0: Expected Obj, but got I
		//IL_02d6: Expected F4, but got I
		//IL_02eb: Invalid comparison between I and F4
		//IL_0336: Expected native int or pointer, but got VT
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Expected VT, but got Unknown
		//IL_0399: Expected Obj, but got I
		//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ae: Expected F4, but got Unknown
		//IL_03b6: Expected native int or pointer, but got VT
		//IL_00e5: Expected native int or pointer, but got VT
		//IL_0119: Expected F4, but got I
		//IL_0114: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 80);
		float num = Math.Min(v.x, 1f);
		bool flag = v.x < 0f;
		float x = 0f;
		if (!flag)
		{
			x = num;
		}
		((Vector2*)(nint)v)->x = x;
		float num2 = Math.Min(v.y, 1f);
		bool flag2 = v.y < 0f;
		float y = 0f;
		if (!flag2)
		{
			y = num2;
		}
		((Vector2*)(nint)v)->y = y;
		mPos = (Vector2)v.x;
		if (selectionWidget != null)
		{
			UITexture uITexture = mUITex;
			nint num3 = (nint)uITexture;
			object obj2 = uITexture + 72;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v61 @ S2_v12 (Il2CppClass<UITexture>)+104] (should have been resolved before IL gen)");
			object obj4 = default;
			object obj3 = obj4 + 16;
			object obj5 = obj4 + 40;
			object obj6 = obj5 - obj3;
			float num4 = Math.Min((float)mPos, 1f);
			bool flag3 = mPos < (object)0f;
			float num5 = 0f;
			if (!flag3)
			{
				num5 = num4;
			}
			float num6 = (float)obj6 * num5;
			float x2 = (float)obj3 + num6;
			((Vector2*)(nint)v)->x = x2;
			object obj7 = obj4 + 16;
			object obj8 = obj4 + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S2_v23+4]");
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S1_v29+4]");
			object obj9 = num7 - 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIColorPicker)+38]");
			float num8 = Math.Min(0f, 1f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIColorPicker)+38]");
			bool flag4 = 0f < 0f;
			float num9 = 0f;
			if (!flag4)
			{
				num9 = num8;
			}
			float num10 = (float)obj9 * num9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S1_v29+4]");
			float y2 = 0f + num10;
			((Vector2*)(nint)v)->y = y2;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
			_ = 0;
			_ = v.x;
			_ = v.x;
			Vector3 position = vector + 16;
			Vector3 vector2 = mTrans.TransformPoint(position);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
			object obj10 = (nint)0 << 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
			float x3 = 0 | obj10;
			((Vector2*)(nint)v)->x = x3;
			Transform trans = selectionWidget.transform;
			Camera cachedCamera = mCam.cachedCamera;
			_ = 0;
			((Vector3*)(nint)vector)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
			((Vector3*)(nint)vector)->x = 0f;
			NGUIMath.OverlayPosition(trans, vector, cachedCamera);
		}
		Vector2 vector3 = mPos;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIColorPicker)+38]");
		Color color = Sample((float)vector3, 0f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
		value = (Color)0;
		current = this;
		EventDelegate.Execute(onChange);
		current = null;
	}

	public unsafe Vector2 Select(Color c)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0043: Expected F4, but got I4
		//IL_0022: Expected VT, but got F4
		//IL_0336: Expected F4, but got VT
		//IL_0331: Expected native int or pointer, but got VT
		//IL_0072: Expected Obj, but got I4
		//IL_02c7: Expected VT, but got F4
		//IL_01de: Expected I, but got Obj
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Expected Obj, but got Unknown
		//IL_021d: Expected Obj, but got I
		//IL_022d: Expected F4, but got VT
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Expected Obj, but got Unknown
		//IL_0241: Invalid comparison between VT and F4
		//IL_03c7: Expected Obj, but got I
		//IL_03dd: Expected F4, but got I
		//IL_03f2: Invalid comparison between I and F4
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Expected Obj, but got Unknown
		//IL_045c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0461: Expected VT, but got Unknown
		//IL_017e: Expected VT, but got F4
		//IL_028d: Expected F4, but got I
		//IL_0288: Expected native int or pointer, but got VT
		//IL_02a2: Expected F4, but got I
		//IL_029d: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj + -64);
		_ = 0;
		_ = 0;
		if (mUITex == null)
		{
			value = (Color)c.r;
			_ = c.b;
		}
		else
		{
			float num = float.MaxValue;
			float num2 = 0f;
			object obj2 = default;
			object obj5 = default;
			while (mHeight > (nint)obj2)
			{
				float num3 = (float)obj2 - 1f;
				float y = num3 / (float)mHeight;
				object obj3 = 0;
				while (mWidth > (nint)obj3)
				{
					float num4 = (float)obj3 - 1f;
					float num5 = num4 / (float)mWidth;
					Color color = Sample(num5, y);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
					float num6 = 0f - c.r;
					float num7 = num6 * num6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
					float num8 = 0f - c.g;
					float num9 = num8 * num8;
					float num10 = num7 + num9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
					float num11 = 0f - c.b;
					num2 = num11 * num11;
					float num12 = num10 + num2;
					if (num > num12)
					{
						mPos = (Vector2)num5;
						num = num12;
					}
					object obj4 = obj3 + 1;
					obj3 = obj4;
				}
				obj2 = obj5 + 1;
			}
			if (selectionWidget != null)
			{
				UITexture uITexture = mUITex;
				nint num13 = (nint)uITexture;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v209 @ S1_v22 (Il2CppClass<UITexture>)+104] (should have been resolved before IL gen)");
				object obj6 = vector + 48;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ S0_v58+28]");
				nint num14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ S0_v58+10]");
				object obj7 = num14 - 0;
				float num15 = Math.Min((float)mPos, 1f);
				bool flag = mPos < (object)0f;
				float num16 = 0f;
				if (!flag)
				{
					num16 = num15;
				}
				float num17 = (float)obj7 * num16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ S0_v58+10]");
				float num18 = 0f + num17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ S0_v58+2C]");
				nint num19 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ S0_v58+14]");
				object obj8 = num19 - 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (UIColorPicker)+38]");
				float num20 = Math.Min(0f, 1f);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (UIColorPicker)+38]");
				bool flag2 = 0f < 0f;
				float num21 = 0f;
				if (!flag2)
				{
					num21 = num20;
				}
				float num22 = (float)obj8 * num21;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ S0_v58+14]");
				float num23 = 0f + num22;
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
				_ = 0;
				Vector3 position = vector + 16;
				Vector3 vector2 = mTrans.TransformPoint(position);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
				_ = 0;
				Transform trans = selectionWidget.transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
				_ = 0;
				Camera cachedCamera = mCam.cachedCamera;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
				((Vector3*)(nint)vector)->z = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
				((Vector3*)(nint)vector)->x = 0f;
				NGUIMath.OverlayPosition(trans, vector, cachedCamera);
			}
			value = (Color)c.r;
			_ = c.b;
			current = this;
			EventDelegate.Execute(onChange);
			current = null;
		}
		Vector2 vector3 = default;
		((Vector2*)(nint)vector3)->x = (float)mPos;
		return vector3;
	}

	public unsafe static Color Sample(float x, float y)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_0034: Expected Obj, but got I4
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected Obj, but got Unknown
		//IL_004b: Expected Obj, but got I4
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
		//IL_0062: Expected Obj, but got I4
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected Obj, but got Unknown
		//IL_008b: Expected Obj, but got F4
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected Obj, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected Obj, but got Unknown
		//IL_00e7: Expected Obj, but got I4
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected Obj, but got Unknown
		//IL_00fe: Expected Obj, but got I4
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected Obj, but got Unknown
		//IL_0115: Expected Obj, but got I4
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected Obj, but got Unknown
		//IL_013e: Expected Obj, but got F4
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected Obj, but got Unknown
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected Obj, but got Unknown
		//IL_0195: Expected Obj, but got I4
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected Obj, but got Unknown
		//IL_01ac: Expected Obj, but got I4
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected Obj, but got Unknown
		//IL_01c3: Expected Obj, but got I4
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected Obj, but got Unknown
		//IL_01ec: Expected Obj, but got F4
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Expected Obj, but got Unknown
		//IL_10a9: Expected I, but got Obj
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Expected Obj, but got Unknown
		//IL_0248: Expected Obj, but got I4
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Expected Obj, but got Unknown
		//IL_025f: Expected Obj, but got I4
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected Obj, but got Unknown
		//IL_0276: Expected Obj, but got I4
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Expected Obj, but got Unknown
		//IL_029f: Expected Obj, but got F4
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Expected Obj, but got Unknown
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Expected Obj, but got Unknown
		//IL_02f6: Expected Obj, but got I4
		//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Expected Obj, but got Unknown
		//IL_030d: Expected Obj, but got I4
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Expected Obj, but got Unknown
		//IL_0324: Expected Obj, but got I4
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Expected Obj, but got Unknown
		//IL_034d: Expected Obj, but got F4
		//IL_037e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Expected Obj, but got Unknown
		//IL_106a: Expected native int or pointer, but got VT
		//IL_1077: Expected native int or pointer, but got VT
		//IL_1084: Expected native int or pointer, but got VT
		//IL_1091: Expected native int or pointer, but got VT
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a0: Expected Obj, but got Unknown
		//IL_03a9: Expected Obj, but got I4
		//IL_03b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b7: Expected Obj, but got Unknown
		//IL_03c0: Expected Obj, but got I4
		//IL_03c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ce: Expected Obj, but got Unknown
		//IL_03d7: Expected Obj, but got I4
		//IL_03e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Expected Obj, but got Unknown
		//IL_0400: Expected Obj, but got F4
		//IL_0431: Unknown result type (might be due to invalid IL or missing references)
		//IL_0436: Expected Obj, but got Unknown
		//IL_0449: Unknown result type (might be due to invalid IL or missing references)
		//IL_044e: Expected Obj, but got Unknown
		//IL_0457: Expected Obj, but got I4
		//IL_0460: Unknown result type (might be due to invalid IL or missing references)
		//IL_0465: Expected Obj, but got Unknown
		//IL_046e: Expected Obj, but got I4
		//IL_0477: Unknown result type (might be due to invalid IL or missing references)
		//IL_047c: Expected Obj, but got Unknown
		//IL_0485: Expected Obj, but got I4
		//IL_0494: Unknown result type (might be due to invalid IL or missing references)
		//IL_0499: Expected Obj, but got Unknown
		//IL_04ae: Expected Obj, but got F4
		//IL_04df: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e4: Expected Obj, but got Unknown
		//IL_04fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0501: Expected Obj, but got Unknown
		//IL_050a: Expected Obj, but got I4
		//IL_0513: Unknown result type (might be due to invalid IL or missing references)
		//IL_0518: Expected Obj, but got Unknown
		//IL_0521: Expected Obj, but got I4
		//IL_052a: Unknown result type (might be due to invalid IL or missing references)
		//IL_052f: Expected Obj, but got Unknown
		//IL_0538: Expected Obj, but got I4
		//IL_0547: Unknown result type (might be due to invalid IL or missing references)
		//IL_054c: Expected Obj, but got Unknown
		//IL_0561: Expected Obj, but got F4
		//IL_0592: Unknown result type (might be due to invalid IL or missing references)
		//IL_0597: Expected Obj, but got Unknown
		//IL_05d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d9: Expected Obj, but got Unknown
		//IL_05e2: Expected Obj, but got I4
		//IL_05eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f0: Expected Obj, but got Unknown
		//IL_05f9: Expected Obj, but got I4
		//IL_0602: Unknown result type (might be due to invalid IL or missing references)
		//IL_0607: Expected Obj, but got Unknown
		//IL_0610: Expected Obj, but got I4
		//IL_061f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0624: Expected Obj, but got Unknown
		//IL_0639: Expected Obj, but got F4
		//IL_066a: Unknown result type (might be due to invalid IL or missing references)
		//IL_066f: Expected Obj, but got Unknown
		//IL_0682: Unknown result type (might be due to invalid IL or missing references)
		//IL_0687: Expected Obj, but got Unknown
		//IL_0690: Expected Obj, but got I4
		//IL_0699: Unknown result type (might be due to invalid IL or missing references)
		//IL_069e: Expected Obj, but got Unknown
		//IL_06a7: Expected Obj, but got I4
		//IL_06b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b5: Expected Obj, but got Unknown
		//IL_06be: Expected Obj, but got I4
		//IL_06cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d2: Expected Obj, but got Unknown
		//IL_06e7: Expected Obj, but got F4
		//IL_0718: Unknown result type (might be due to invalid IL or missing references)
		//IL_071d: Expected Obj, but got Unknown
		//IL_0735: Unknown result type (might be due to invalid IL or missing references)
		//IL_073a: Expected Obj, but got Unknown
		//IL_0743: Expected Obj, but got I4
		//IL_074c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0751: Expected Obj, but got Unknown
		//IL_075a: Expected Obj, but got I4
		//IL_0763: Unknown result type (might be due to invalid IL or missing references)
		//IL_0768: Expected Obj, but got Unknown
		//IL_0771: Expected Obj, but got I4
		//IL_0780: Unknown result type (might be due to invalid IL or missing references)
		//IL_0785: Expected Obj, but got Unknown
		//IL_079a: Expected Obj, but got F4
		//IL_07cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d0: Expected Obj, but got Unknown
		//IL_07e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e8: Expected Obj, but got Unknown
		//IL_07f1: Expected Obj, but got I4
		//IL_07fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ff: Expected Obj, but got Unknown
		//IL_0808: Expected Obj, but got I4
		//IL_0811: Unknown result type (might be due to invalid IL or missing references)
		//IL_0816: Expected Obj, but got Unknown
		//IL_081f: Expected Obj, but got I4
		//IL_082e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0833: Expected Obj, but got Unknown
		//IL_0848: Expected Obj, but got F4
		//IL_0879: Unknown result type (might be due to invalid IL or missing references)
		//IL_087e: Expected Obj, but got Unknown
		//IL_0896: Unknown result type (might be due to invalid IL or missing references)
		//IL_089b: Expected Obj, but got Unknown
		//IL_08a4: Expected Obj, but got I4
		//IL_08ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b2: Expected Obj, but got Unknown
		//IL_08bb: Expected Obj, but got I4
		//IL_08c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c9: Expected Obj, but got Unknown
		//IL_08d2: Expected Obj, but got I4
		//IL_08e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e6: Expected Obj, but got Unknown
		//IL_08fb: Expected Obj, but got F4
		//IL_092c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0931: Expected Obj, but got Unknown
		//IL_0944: Unknown result type (might be due to invalid IL or missing references)
		//IL_0949: Expected Obj, but got Unknown
		//IL_0952: Expected Obj, but got I4
		//IL_095b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0960: Expected Obj, but got Unknown
		//IL_0969: Expected Obj, but got I4
		//IL_0972: Unknown result type (might be due to invalid IL or missing references)
		//IL_0977: Expected Obj, but got Unknown
		//IL_0980: Expected Obj, but got I4
		//IL_098f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0994: Expected Obj, but got Unknown
		//IL_09a9: Expected Obj, but got F4
		//IL_09da: Unknown result type (might be due to invalid IL or missing references)
		//IL_09df: Expected Obj, but got Unknown
		//IL_09f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fc: Expected Obj, but got Unknown
		//IL_0a05: Expected Obj, but got I4
		//IL_0a0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a13: Expected Obj, but got Unknown
		//IL_0a1c: Expected Obj, but got I4
		//IL_0a25: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2a: Expected Obj, but got Unknown
		//IL_0a33: Expected Obj, but got I4
		//IL_0a42: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a47: Expected Obj, but got Unknown
		//IL_0a5c: Expected Obj, but got F4
		//IL_0a8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a92: Expected Obj, but got Unknown
		//IL_0aa5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aaa: Expected Obj, but got Unknown
		//IL_0ab3: Expected Obj, but got I4
		//IL_0abc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac1: Expected Obj, but got Unknown
		//IL_0aca: Expected Obj, but got I4
		//IL_0ad3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad8: Expected Obj, but got Unknown
		//IL_0ae1: Expected Obj, but got I4
		//IL_0af0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af5: Expected Obj, but got Unknown
		//IL_0b0a: Expected Obj, but got F4
		//IL_0b3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b40: Expected Obj, but got Unknown
		//IL_0be7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bec: Expected Obj, but got Unknown
		//IL_0c6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c73: Expected Obj, but got Unknown
		//IL_0cf0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf5: Expected Obj, but got Unknown
		//IL_0d77: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d7c: Expected Obj, but got Unknown
		//IL_0df9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dfe: Expected Obj, but got Unknown
		//IL_0e80: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e85: Expected Obj, but got Unknown
		//IL_0f02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f07: Expected Obj, but got Unknown
		//IL_0f83: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 1536;
		if (mRed == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			object obj3 = obj + 1528;
			obj3 = 0;
			object obj4 = obj + 1520;
			obj4 = 0;
			object obj5 = obj + 1512;
			obj5 = 0;
			_ = 0;
			object obj6 = obj + 1504;
			_ = 0;
			_ = 1f;
			obj6 = 0f;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+5E0]");
			_ = 0;
			object obj7 = obj + 736;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @62F");
			object obj8 = obj + 1496;
			obj8 = 0;
			object obj9 = obj + 1488;
			obj9 = 0;
			object obj10 = obj + 1480;
			obj10 = 0;
			_ = 0;
			object obj11 = obj + 1472;
			_ = 0;
			_ = 1f;
			obj11 = 1f / 7f;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+5C0]");
			_ = 0;
			object obj12 = obj + 704;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @62F");
			object obj13 = obj + 1464;
			obj13 = 0;
			object obj14 = obj + 1456;
			obj14 = 0;
			object obj15 = obj + 1448;
			obj15 = 0;
			_ = 0;
			object obj16 = obj + 1440;
			_ = 0;
			_ = 0f;
			obj16 = 0.2857143f;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+5A0]");
			_ = 0;
			object obj17 = obj + 672;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @62F");
			object obj18 = obj + 1432;
			obj18 = 0;
			object obj19 = obj + 1424;
			obj19 = 0;
			object obj20 = obj + 1416;
			obj20 = 0;
			_ = 0;
			object obj21 = obj + 1408;
			_ = 0;
			_ = 0f;
			obj21 = 1755f / 4095f;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+580]");
			_ = 0;
			object obj22 = obj + 640;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @62F");
			object obj23 = obj + 1400;
			obj23 = 0;
			object obj24 = obj + 1392;
			obj24 = 0;
			object obj25 = obj + 1384;
			obj25 = 0;
			_ = 0;
			object obj26 = obj + 1376;
			_ = 0;
			_ = 0f;
			obj26 = 0.5714286f;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+560]");
			_ = 0;
			object obj27 = obj + 608;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @62F");
			object obj28 = obj + 1368;
			obj28 = 0;
			object obj29 = obj + 1360;
			obj29 = 0;
			object obj30 = obj + 1352;
			obj30 = 0;
			_ = 0;
			object obj31 = obj + 1344;
			_ = 0;
			_ = 1f;
			obj31 = 2925f / 4095f;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+540]");
			_ = 0;
			object obj32 = obj + 576;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @62F");
			object obj33 = obj + 1336;
			obj33 = 0;
			object obj34 = obj + 1328;
			obj34 = 0;
			object obj35 = obj + 1320;
			obj35 = 0;
			_ = 0;
			object obj36 = obj + 1312;
			_ = 0;
			_ = 1f;
			obj36 = 3510f / 4095f;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+520]");
			_ = 0;
			object obj37 = obj + 544;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @62F");
			object obj38 = obj + 1304;
			obj38 = 0;
			object obj39 = obj + 1296;
			obj39 = 0;
			object obj40 = obj + 1288;
			obj40 = 0;
			_ = 0;
			object obj41 = obj + 1280;
			_ = 0;
			_ = 0.5f;
			obj41 = 1f;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+500]");
			_ = 0;
			object obj42 = obj + 512;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @62F");
			AnimationCurve animationCurve = default;
			Keyframe[] keys = default;
			animationCurve._002Ector(keys);
			mRed = animationCurve;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			object obj43 = obj + 1272;
			obj43 = 0;
			object obj44 = obj + 1264;
			obj44 = 0;
			object obj45 = obj + 1256;
			obj45 = 0;
			_ = 0;
			object obj46 = obj + 1248;
			_ = 0;
			_ = 0f;
			obj46 = 0f;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4E0]");
			_ = 0;
			object obj47 = obj + 480;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @62F");
			object obj48 = obj + 1240;
			obj48 = 0;
			object obj49 = obj + 1232;
			obj49 = 0;
			object obj50 = obj + 1224;
			obj50 = 0;
			_ = 0;
			object obj51 = obj + 1216;
			_ = 0;
			_ = 1f;
			obj51 = 1f / 7f;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4C0]");
			_ = 0;
			object obj52 = obj + 448;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @62F");
			object obj53 = obj + 1208;
			obj53 = 0;
			object obj54 = obj + 1200;
			obj54 = 0;
			object obj55 = obj + 1192;
			obj55 = 0;
			_ = 0;
			object obj56 = obj + 1184;
			_ = 0;
			_ = 1f;
			obj56 = 0.2857143f;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4A0]");
			_ = 0;
			object obj57 = obj + 416;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @62F");
			object obj58 = obj + 1176;
			obj58 = 0;
			object obj59 = obj + 1168;
			obj59 = 0;
			object obj60 = obj + 1160;
			obj60 = 0;
			_ = 0;
			object obj61 = obj + 1152;
			_ = 0;
			_ = 1f;
			obj61 = 1755f / 4095f;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+480]");
			_ = 0;
			object obj62 = obj + 384;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @62F");
			object obj63 = obj + 1144;
			obj63 = 0;
			object obj64 = obj + 1136;
			obj64 = 0;
			object obj65 = obj + 1128;
			obj65 = 0;
			_ = 0;
			object obj66 = obj + 1120;
			_ = 0;
			_ = 0f;
			obj66 = 0.5714286f;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+460]");
			_ = 0;
			object obj67 = obj + 352;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @62F");
			object obj68 = obj + 1112;
			obj68 = 0;
			object obj69 = obj + 1104;
			obj69 = 0;
			object obj70 = obj + 1096;
			obj70 = 0;
			_ = 0;
			object obj71 = obj + 1088;
			_ = 0;
			_ = 0f;
			obj71 = 2925f / 4095f;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+440]");
			_ = 0;
			object obj72 = obj + 320;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @62F");
			object obj73 = obj + 1080;
			obj73 = 0;
			object obj74 = obj + 1072;
			obj74 = 0;
			object obj75 = obj + 1064;
			obj75 = 0;
			_ = 0;
			object obj76 = obj + 1056;
			_ = 0;
			_ = 0f;
			obj76 = 3510f / 4095f;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+420]");
			_ = 0;
			object obj77 = obj + 288;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @62F");
			object obj78 = obj + 1048;
			obj78 = 0;
			object obj79 = obj + 1040;
			obj79 = 0;
			object obj80 = obj + 1032;
			obj80 = 0;
			_ = 0;
			object obj81 = obj + 1024;
			_ = 0;
			_ = 0.5f;
			obj81 = 1f;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+400]");
			_ = 0;
			object obj82 = obj + 256;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @62F");
			AnimationCurve animationCurve2 = default;
			Keyframe[] keys2 = default;
			animationCurve2._002Ector(keys2);
			mGreen = animationCurve2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			_ = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			_ = 0f;
			_ = 0f;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3F8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3F0]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3E8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3E0]");
			_ = 0;
			object obj83 = obj + 224;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @62F");
			_ = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			_ = 0f;
			_ = 1f / 7f;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3D8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3D0]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3C8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3C0]");
			_ = 0;
			object obj84 = obj + 192;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @62F");
			_ = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			_ = 0f;
			_ = 0.2857143f;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3B8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3B0]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3A8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3A0]");
			_ = 0;
			object obj85 = obj + 160;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @62F");
			_ = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			_ = 1f;
			_ = 1755f / 4095f;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+398]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+390]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+388]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+380]");
			_ = 0;
			object obj86 = obj + 128;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @62F");
			_ = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			_ = 1f;
			_ = 0.5714286f;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+378]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+370]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+368]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+360]");
			_ = 0;
			object obj87 = obj + 96;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @62F");
			_ = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			_ = 1f;
			_ = 2925f / 4095f;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+358]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+350]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+348]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+340]");
			_ = 0;
			object obj88 = obj - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @62F");
			_ = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			_ = 0f;
			_ = 3510f / 4095f;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+338]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+330]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+328]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+320]");
			_ = 0;
			object obj89 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @62F");
			_ = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			_ = 0.5f;
			_ = 1f;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+318]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+310]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+308]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+300]");
			obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @62F");
			AnimationCurve animationCurve3 = default;
			Keyframe[] keys3 = default;
			animationCurve3._002Ector(keys3);
			mBlue = animationCurve3;
		}
		float num = mRed.Evaluate(x);
		float num2 = mGreen.Evaluate(x);
		float num3 = mBlue.Evaluate(x);
		float b;
		float r;
		float g;
		if (y < 0.5f)
		{
			float num4 = y + y;
			float num5 = num * num4;
			float num6 = num2 * num4;
			b = num3 * num4;
			r = num5;
			g = num6;
		}
		else
		{
			nint num7 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ S0_v42 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num8 = 0;
			float num9 = (float)Vector3.oneVector - num;
			float num10 = y + y;
			float num11 = num10 - 1f;
			float num12 = Math.Min(num11, 1f);
			bool flag = num11 < 0f;
			float num13 = 0f;
			if (!flag)
			{
				num13 = num12;
			}
			float num14 = num9 * num13;
			float num15 = num + num14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ S0_v43 (Il2CppStaticFields<UnityEngine.Vector3>)+10]");
			float num16 = 0f - num2;
			float num17 = num16 * num13;
			float num18 = num2 + num17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ S0_v43 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
			float num19 = 0f - num3;
			float num20 = num19 * num13;
			b = num3 + num20;
			r = num15;
			g = num18;
		}
		Color color = default;
		((Color*)(nint)color)->a = 1f;
		((Color*)(nint)color)->b = b;
		((Color*)(nint)color)->g = g;
		((Color*)(nint)color)->r = r;
		return color;
	}

	public UIColorPicker()
	{
		//IL_0015: Expected VT, but got I8
		_ = 4575657222473777152L;
		List<EventDelegate> list = default;
		list._002Ector();
		onChange = list;
		base._002Ector();
	}
}
