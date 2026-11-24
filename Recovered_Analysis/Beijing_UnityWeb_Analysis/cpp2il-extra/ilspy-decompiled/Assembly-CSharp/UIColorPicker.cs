using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Common.Data;
using SYBO.Components.Utilities;
using SYBO.Subway.Coins;
using UI.Pages.MissionsPageInternal;
using UnityEngine;

public class UIColorPicker : MonoBehaviour
{
	public static UIColorPicker current;

	public Color value;

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
		//IL_001e: Expected VT, but got I4
		//IL_0027: Expected Obj, but got I4
		//IL_0030: Expected Obj, but got I4
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected Obj, but got Unknown
		//IL_0070: Expected Obj, but got I4
		//IL_0087: Expected Obj, but got F4
		//IL_0092: Expected Obj, but got F4
		//IL_009d: Expected Obj, but got F4
		//IL_00a8: Expected VT, but got F4
		//IL_00b9: Expected I4, but got F4
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected Obj, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected Obj, but got Unknown
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		value = (Color)1;
		obj = 0;
		obj = -1;
		obj2 = obj;
		object obj3 = obj2 + 4;
		obj3 = obj2;
		_ = 1;
		_ = 1;
		_ = 1;
		onChange = (List<EventDelegate>)1;
		_ = 1;
		_ = 1;
		mTrans = (Transform)1f;
		mTex = (Texture2D)4f;
		mCam = (UICamera)10f;
		mPos = (Vector2)40f;
		_ = 40f;
		mWidth = -1;
		object obj4 = this - -64;
		obj4 = "Horizontal";
		object obj5 = this + 68;
		obj5 = "Vertical";
		object obj6 = this + 80;
		obj6 = "Mouse ScrollWheel";
		_ = 1;
		_ = 13;
		_ = 330;
		_ = 27;
		_ = 331;
		_ = 1;
		CancelInvoke();
	}

	private void OnDestroy()
	{
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Expected Obj, but got Unknown
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Expected Obj, but got Unknown
		//IL_0020: Expected I, but got Obj
		//IL_0036: Expected Obj, but got I
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Expected Obj, but got Unknown
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_0305: Expected Obj, but got Unknown
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Expected Obj, but got Unknown
		//IL_0319: Expected Obj, but got I4
		//IL_0325: Expected Obj, but got I4
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Expected Obj, but got Unknown
		//IL_0360: Expected Obj, but got I4
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_036b: Expected Obj, but got Unknown
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_037a: Expected Obj, but got Unknown
		//IL_038d: Expected Obj, but got I4
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c6: Expected Obj, but got Unknown
		//IL_0061: Expected I, but got Obj
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected Obj, but got Unknown
		//IL_01e4: Expected VT, but got I4
		//IL_01e4: Expected I4, but got Obj
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected Obj, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected Obj, but got Unknown
		//IL_00d3: Expected Obj, but got I4
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Expected Obj, but got Unknown
		//IL_0272: Expected F4, but got I
		//IL_028c: Expected I4, but got F4
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Expected Obj, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected Obj, but got Unknown
		//IL_0140: Expected I4, but got F4
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected Obj, but got Unknown
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected Obj, but got Unknown
		object obj = this + 36;
		GameObject gameObject = base.gameObject;
		obj = gameObject;
		object obj2 = this + 40;
		UITexture component = GetComponent<UITexture>();
		obj2 = component;
		string text = tag;
		bool activeSelf = ((GameObject)(object)text).activeSelf;
		nint num = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v16 (Il2CppClass<UICamera>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v83 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIFont uIFont = default;
		string text2 = (string)(uIFont + 24);
		MinMaxSliderAttribute minMaxSliderAttribute = (MinMaxSliderAttribute)(uIFont + 8);
		object obj4 = this + 48;
		int direction = UICamera.GetDirection((string)activeSelf);
		obj4 = direction;
		UITexture uITexture = mUITex;
		mWidth = ((UIWidget)uITexture).mWidth;
		object obj5 = this - -64;
		UITexture uITexture2 = mUITex;
		obj5 = ((UIWidget)uITexture2).mHeight;
		object obj6 = this - -64;
		object obj7 = obj6 * mWidth;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj8 = 0;
		Color32[] array = default;
		while (true)
		{
			object obj9 = this - -64;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9))
			{
				break;
			}
			float num3 = (float)obj8 - 1f;
			object obj10 = this - -64;
			float max = num3 / (float)obj10;
			object obj11 = 0;
			while ((nint)obj11 < mWidth)
			{
				object obj12 = mWidth * obj8;
				object obj13 = obj12 + obj11;
				float num4 = (float)obj11 - 1f;
				float min = num4 / (float)mWidth;
				minMaxSliderAttribute._002Ector(min, max);
				text2 = (string)(object)minMaxSliderAttribute;
				text2.m_stringLength = (int)minMaxSliderAttribute.max;
				object obj14 = array + 16;
				object obj15 = obj13 << 4;
				object obj16 = obj14 + obj15;
				obj16 = text2;
				_ = text2.m_stringLength;
				object obj17 = obj11 + 1;
				obj11 = obj17;
			}
			object obj18 = obj8 + 1;
			obj8 = obj18;
		}
		object obj19 = this - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Texture2D texture2D = default;
		texture2D.SetPixelImpl(mWidth, (int)obj19, 3, (Color)0);
		object obj20 = this + 44;
		obj20 = texture2D;
		mTex.SetPixels32(array);
		mTex.anisoLevel = 2;
		mTex.filterMode = FilterMode.Bilinear;
		((RenderTexture)(object)mTex)._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		object obj21 = this + 12;
		minMaxSliderAttribute = (MinMaxSliderAttribute)obj21;
		MinMaxSliderAttribute minMaxSliderAttribute2 = minMaxSliderAttribute;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ S1_v43+8]");
		minMaxSliderAttribute2.max = 0f;
		text2 = (string)(object)minMaxSliderAttribute;
		text2.m_stringLength = (int)minMaxSliderAttribute.max;
		uIFont.AddSymbol((string)(object)this, text2);
	}

	private void OnPress(bool pressed)
	{
		//IL_030d: Expected I, but got Obj
		//IL_0323: Expected Obj, but got I
		//IL_0464: Expected Obj, but got I4
		//IL_0476: Expected I, but got Obj
		//IL_048c: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00ba: Expected Obj, but got I4
		//IL_0060: Expected I, but got Obj
		//IL_036e: Expected Obj, but got I
		//IL_00cd: Expected I, but got Obj
		//IL_00e3: Expected Obj, but got I
		//IL_03c5: Expected I, but got Obj
		//IL_03db: Expected Obj, but got I
		//IL_010e: Expected I, but got Obj
		//IL_04bb: Expected Obj, but got I
		//IL_015b: Expected I, but got Obj
		//IL_0171: Expected Obj, but got I
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Expected Obj, but got Unknown
		//IL_0257: Expected Obj, but got I4
		//IL_0265: Expected I, but got Obj
		//IL_027b: Expected Obj, but got I
		//IL_01f9: Expected I, but got Obj
		//IL_040a: Expected Obj, but got I
		//IL_019c: Expected I, but got Obj
		//IL_02a6: Expected I, but got Obj
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f0: Expected Obj, but got Unknown
		//IL_02f9: Expected Obj, but got I4
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v54 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag2 = default;
		bool flag = (UnityEngine.Object)flag2 != this;
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v5 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S1_v48 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text;
		if (flag)
		{
			flag2 = false;
			text = null;
		}
		else
		{
			text = (string)flag2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIColorPicker)+18]");
		if (((ComputeShader)0).FindKernel(text) == 0)
		{
			return;
		}
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v17 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v50 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)null).FindKernel((string)null) != 0)
		{
			nint num7 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S1_v36 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num8 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S1_v42 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ L1_v1 (System.Boolean)+18]");
			if ((UnityEngine.Object)0 != this)
			{
				((UIColorPicker)null).OnPress(false);
			}
		}
		nint num9 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S1_v16 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num10 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S1_v31 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIColorPicker)+18]");
		if (((ComputeShader)0).FindKernel(null) != 0)
		{
			((UIAtlas)this)._002Ector();
		}
		object obj6 = this + 24;
		obj6 = 0;
		nint num11 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S0_v31 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num12 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S0_v41 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)null).FindKernel((string)null) != 0)
		{
			object obj8 = this + 12;
			obj8 = 0;
		}
		((UIAtlas)this)._002Ector();
	}

	private void OnDrag(Vector2 delta)
	{
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		bool flag = isActiveAndEnabled;
		object obj = flag & delta;
		if (obj == null)
		{
			return;
		}
		nint num = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<UICamera>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		KeyCode currentKey = UICamera.currentKey;
		if (currentKey != (KeyCode)2)
		{
			this._002Ector();
		}
	}

	private void OnPan(Vector2 delta)
	{
		if (isActiveAndEnabled)
		{
			this._002Ector();
		}
	}

	private void Sample()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected Obj, but got Unknown
		//IL_00b2: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UnityEngine.Object.DestroyImmediate(mTex);
		object obj2 = this + 44;
		obj2 = 0;
	}

	public void Select(Vector2 v)
	{
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected Obj, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected Obj, but got Unknown
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected Obj, but got Unknown
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		//IL_0028: Expected Obj, but got F4
		//IL_0036: Expected I, but got Obj
		//IL_004c: Expected Obj, but got I
		//IL_0077: Expected I, but got Obj
		//IL_01cb: Expected Obj, but got F4
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected Obj, but got Unknown
		//IL_01e3: Expected Obj, but got F4
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected Obj, but got Unknown
		//IL_0244: Expected Obj, but got VT
		object obj = default;
		BMFont bMFont = (BMFont)(obj + 24);
		object obj2 = obj + 16;
		object obj3 = obj + 8;
		if (!isActiveAndEnabled)
		{
			return;
		}
		object obj4 = this + 52;
		object obj5 = this + 52;
		obj2 = v.x;
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S3_v5 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S3_v9 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num3 = (float)obj5 + (float)obj2;
		if (num3 < 0f)
		{
			num3 = 0f;
		}
		else if (num3 > 1f)
		{
			num3 = 1f;
		}
		obj4 = num3;
		object obj7 = this + 52;
		obj3 = v.x;
		object obj8 = this + 52;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v21+4]");
		float num4 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+4]");
		float num5 = num4 + 0f;
		if (num5 < 0f)
		{
			num5 = 0f;
		}
		else if (num5 > 1f)
		{
			num5 = 1f;
		}
		obj = mPos;
		bMFont = (BMFont)obj;
		((UIFont)this).bmFont = bMFont;
	}

	public Vector2 Select(Color c)
	{
		//IL_06da: Invalid comparison between VT and I4
		//IL_0913: Expected I, but got Obj
		//IL_0929: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_0729: Expected I, but got Obj
		//IL_073f: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_095d: Expected I, but got Obj
		//IL_0973: Expected Obj, but got I
		//IL_012c: Expected I, but got Obj
		//IL_0645: Unknown result type (might be due to invalid IL or missing references)
		//IL_064a: Expected Obj, but got Unknown
		//IL_0652: Unknown result type (might be due to invalid IL or missing references)
		//IL_0657: Expected Obj, but got Unknown
		//IL_066e: Expected VT, but got Obj
		//IL_0179: Expected I, but got Obj
		//IL_01c1: Invalid comparison between VT and I4
		//IL_0697: Invalid comparison between VT and I4
		//IL_06a5: Expected VT, but got Obj
		//IL_020b: Invalid comparison between Obj and F4
		//IL_0227: Expected VT, but got Obj
		//IL_06cc: Expected VT, but got Obj
		//IL_0243: Expected I, but got Obj
		//IL_0259: Expected Obj, but got I
		//IL_077c: Invalid comparison between F4 and Obj
		//IL_0795: Expected VT, but got Obj
		//IL_0284: Expected I, but got Obj
		//IL_02d1: Expected I, but got Obj
		//IL_02e7: Expected Obj, but got I
		//IL_07c3: Expected I, but got Obj
		//IL_07d9: Expected Obj, but got I
		//IL_09c3: Expected VT, but got Obj
		//IL_0312: Expected I, but got Obj
		//IL_035f: Expected I, but got Obj
		//IL_03ac: Expected I, but got Obj
		//IL_03c2: Expected Obj, but got I
		//IL_081c: Expected VT, but got Obj
		//IL_03ed: Expected I, but got Obj
		//IL_043a: Expected I, but got Obj
		//IL_0450: Expected Obj, but got I
		//IL_0854: Expected VT, but got Obj
		//IL_047b: Expected I, but got Obj
		//IL_04c8: Expected I, but got Obj
		//IL_04de: Expected Obj, but got I
		//IL_05b0: Expected I, but got Obj
		//IL_05c6: Expected Obj, but got I
		//IL_05e3: Expected VT, but got Obj
		//IL_0509: Expected I, but got Obj
		//IL_08d5: Expected Obj, but got I
		//IL_08e5: Expected Obj, but got I
		//IL_0900: Expected I4, but got Obj
		//IL_0900: Expected Obj, but got I
		//IL_053c: Expected I, but got Obj
		//IL_0552: Expected Obj, but got I
		//IL_05ff: Expected I, but got Obj
		//IL_060d: Expected VT, but got Obj
		//IL_057d: Expected I, but got Obj
		//IL_063b: Expected VT, but got Obj
		if (c != (Color)(object)0)
		{
			nint num = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v175 (Il2CppClass<UICamera>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v181 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UICamera.mTooltipTime = 0f;
		}
		nint num3 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v8 (Il2CppClass<UICamera>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v170 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		KeyCode currentKey = UICamera.currentKey;
		bool flag = currentKey == KeyCode.None;
		UISprite uISprite;
		MissionCell missionCell = default;
		UILabel uILabel;
		if (flag)
		{
			uISprite = missionCell._progressFlashSprite;
			uILabel = (UILabel)(object)missionCell._progressComplete;
		}
		else
		{
			uISprite = missionCell._checkmarkSprite;
			uILabel = missionCell._completedLabel;
		}
		float num5 = (float)uILabel * (float)uILabel;
		float t = (float)uISprite * (float)uISprite;
		nint num6 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v21 (Il2CppClass<UICamera>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num7 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v156 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UICamera.MouseOrTouch currentTouch = UICamera.currentTouch;
		nint num8 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S1_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num9 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S1_v45 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector2 result;
		if (((ComputeShader)(object)currentTouch.pressed).FindKernel((string)null) != 0)
		{
			if (c != (Color)(object)0)
			{
				missionCell.OnMissionProgress(flag ? 1 : 0, num5);
			}
			Vector3 vector = ((CoinCurve)this).EvaluateCurve(t, num5);
			bool flag2 = missionCell._missionProgress != (object)0f;
			bool flag3 = !flag2;
			result = (Vector2)missionCell;
			if (!flag3)
			{
				nint num10 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S0_v45 (Il2CppClass<UICamera>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num11 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ S0_v149 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float newValue = ((Score.ValueChangedEventArgs)(object)UICamera.currentTouch).NewValue;
				UILabel missionProgress = missionCell._missionProgress;
				bool flag4 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)newValue) > System.Runtime.CompilerServices.Unsafe.As<UILabel, UIntPtr>(ref missionProgress);
				bool flag5 = !flag4;
				result = (Vector2)missionCell;
				if (!flag5)
				{
					nint num12 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ S0_v55 (Il2CppClass<UICamera>)+BA]");
					object obj6 = (nint)0 & (nint)0x200;
					if (obj6 != null)
					{
						nint num13 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ S0_v143 (Il2CppClass<UICamera>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					UICamera.MouseOrTouch currentTouch2 = UICamera.currentTouch;
					UICamera.MouseOrTouch currentTouch3 = UICamera.currentTouch;
					nint num14 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ S2_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj7 = (nint)0 & (nint)0x200;
					if (obj7 != null)
					{
						nint num15 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ S2_v16 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool flag6 = currentTouch2.pressed != currentTouch3.current;
					bool flag7 = !flag6;
					result = (Vector2)missionCell;
					if (!flag7)
					{
						nint num16 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ S0_v65 (Il2CppClass<UICamera>)+BA]");
						object obj8 = (nint)0 & (nint)0x200;
						if (obj8 != null)
						{
							nint num17 = (nint)typeof(UICamera);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ S0_v137 (Il2CppClass<UICamera>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						bool flag8 = UICamera.mTooltipTime != 0f;
						bool flag9 = !flag8;
						result = (Vector2)missionCell;
						if (!flag9)
						{
							nint num18 = (nint)typeof(UICamera);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ S0_v74 (Il2CppClass<UICamera>)+BA]");
							object obj9 = (nint)0 & (nint)0x200;
							if (obj9 != null)
							{
								nint num19 = (nint)typeof(UICamera);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ S0_v131 (Il2CppClass<UICamera>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							UICamera.MouseOrTouch currentTouch4 = UICamera.currentTouch;
							bool flag10 = (byte)(~(currentTouch4.dragStarted ? 1u : 0u)) != 0;
							bool flag11 = !flag10;
							result = (Vector2)missionCell;
							if (!flag11)
							{
								nint num20 = (nint)typeof(UICamera);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ S0_v84 (Il2CppClass<UICamera>)+BA]");
								object obj10 = (nint)0 & (nint)0x200;
								if (obj10 != null)
								{
									nint num21 = (nint)typeof(UICamera);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ S0_v126 (Il2CppClass<UICamera>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								UICamera.mTooltipTime = 0f;
								UICamera.MouseOrTouch currentTouch5 = UICamera.currentTouch;
								currentTouch5.clickNotification = UICamera.ClickNotification.None;
								if ((object)missionCell._progressSlider != null)
								{
									nint num22 = (nint)typeof(UICamera);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ S0_v112 (Il2CppClass<UICamera>)+BA]");
									object obj11 = (nint)0 & (nint)0x200;
									if (obj11 != null)
									{
										nint num23 = (nint)typeof(UICamera);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ S0_v121 (Il2CppClass<UICamera>)+74]");
										if ((nint)0 == 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
										}
									}
									UICamera.MouseOrTouch currentTouch6 = UICamera.currentTouch;
									BMFont bmFont = ((UIFont)(object)currentTouch6.pressed).bmFont;
								}
								nint num24 = (nint)typeof(UICamera);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ S0_v98 (Il2CppClass<UICamera>)+BA]");
								object obj12 = (nint)0 & (nint)0x200;
								bool flag12 = obj12 == null;
								result = (Vector2)typeof(UICamera);
								if (!flag12)
								{
									nint num25 = (nint)typeof(UICamera);
									result = (Vector2)typeof(UICamera);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ S0_v106 (Il2CppClass<UICamera>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
										result = (Vector2)typeof(UICamera);
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (UnityEngine.Vector2)+5C]");
								object obj13 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ S0_v103+A0]");
								object obj14 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ S0_v104+34]");
								((UICamera)0).ProcessTouch((byte)(int)"OnLongPress" != 0, released: false);
							}
						}
					}
				}
			}
		}
		else
		{
			object obj15 = flag | this;
			object obj16 = obj15 | c;
			bool flag13 = obj16 == null;
			result = (Vector2)missionCell;
			if (!flag13)
			{
				Vector3 vector2 = ((CoinCurve)this).EvaluateCurve(t, num5);
				bool flag14 = c == (Color)(object)0;
				result = (Vector2)missionCell;
				if (!flag14)
				{
					missionCell.OnMissionProgress(flag ? 1 : 0, num5);
					result = (Vector2)missionCell;
				}
			}
		}
		return result;
	}

	public unsafe static Color Sample(float x, float y)
	{
		//IL_0384: Expected I, but got Obj
		//IL_039a: Expected Obj, but got I
		//IL_0623: Unknown result type (might be due to invalid IL or missing references)
		//IL_0628: Expected Obj, but got Unknown
		//IL_0631: Expected Obj, but got VT
		//IL_005f: Expected VT, but got Obj
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected Obj, but got Unknown
		//IL_0076: Expected Obj, but got I4
		//IL_0084: Expected Obj, but got I4
		//IL_009d: Expected I, but got Obj
		//IL_00b3: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c5: Expected VT, but got Unknown
		//IL_03d2: Expected F4, but got Obj
		//IL_03cd: Expected native int or pointer, but got VT
		//IL_03e4: Expected F4, but got I
		//IL_03df: Expected native int or pointer, but got VT
		//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f2: Expected VT, but got Unknown
		//IL_03ff: Expected F4, but got Obj
		//IL_03fa: Expected native int or pointer, but got VT
		//IL_0414: Expected F4, but got I
		//IL_040f: Expected native int or pointer, but got VT
		//IL_0432: Expected F4, but got Obj
		//IL_042d: Expected native int or pointer, but got VT
		//IL_0447: Expected F4, but got I
		//IL_0442: Expected native int or pointer, but got VT
		//IL_0450: Expected Obj, but got VT
		//IL_046f: Expected I, but got Obj
		//IL_0485: Expected Obj, but got I
		//IL_04b3: Expected Obj, but got I
		//IL_00de: Expected I, but got Obj
		//IL_01a8: Expected Obj, but got I4
		//IL_012b: Expected I, but got Obj
		//IL_04e0: Expected Obj, but got I
		//IL_04ee: Expected I, but got Obj
		//IL_0504: Expected Obj, but got I
		//IL_018c: Expected Obj, but got I
		//IL_019a: Expected Obj, but got I4
		//IL_064b: Expected Obj, but got I
		//IL_0531: Expected Obj, but got I
		//IL_053f: Expected I, but got Obj
		//IL_0555: Expected Obj, but got I
		//IL_01bb: Expected I, but got Obj
		//IL_0681: Expected Obj, but got I
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected Obj, but got Unknown
		//IL_0218: Expected Obj, but got I
		//IL_022d: Expected Obj, but got I
		//IL_0582: Expected Obj, but got I
		//IL_0590: Expected I, but got Obj
		//IL_05a6: Expected Obj, but got I
		//IL_024d: Expected I, but got Obj
		//IL_06af: Expected Obj, but got I
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Expected Obj, but got Unknown
		//IL_02aa: Expected Obj, but got I
		//IL_02bf: Expected Obj, but got I
		//IL_02df: Expected I, but got Obj
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Expected Obj, but got Unknown
		//IL_033c: Expected Obj, but got I
		//IL_0351: Expected Obj, but got I
		//IL_036c: Expected Obj, but got VT
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v86 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float f = x + 0.5f;
		int num3 = Mathf.RoundToInt(f);
		float f2 = y + 0.5f;
		int num4 = Mathf.RoundToInt(f2);
		object obj2 = default;
		Transform transform = (Transform)(obj2 + 24);
		Color color = default;
		Camera anchorCamera = ((UIRect)color).anchorCamera;
		transform.localPosition = (Vector3)anchorCamera;
		object obj3 = obj2 + 12;
		obj3 = 0;
		_ = 0;
		obj3 = num3;
		_ = 0f;
		nint num5 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v28 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num6 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v82 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector = (Vector3)(obj2 + 36);
		((Vector3*)(nint)vector)->x = (float)transform;
		((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
		Vector3 vector2 = (Vector3)(obj2 + 48);
		((Vector3*)(nint)vector2)->x = (float)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v22+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		Vector3 vector3 = vector - vector2;
		((Vector3*)(nint)vector2)->x = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		Vector3 eulerAngles = ((Transform)vector2).eulerAngles;
		float a = color.a;
		nint num7 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S1_v35 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num8 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S1_v87 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S0_v43 (System.Single)+8]");
		object obj7;
		if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)0))
		{
			float a2 = color.a;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S0_v80 (System.Single)+10]");
			object obj6 = (nint)num3 + (nint)0;
			obj7 = 1;
		}
		else
		{
			obj7 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Color)+10]");
		object obj8 = 0;
		nint num9 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S1_v42 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num10 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S1_v81 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S0_v48+8]");
		bool flag = UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)0);
		bool flag2 = !flag;
		object obj10 = obj7;
		if (!flag2)
		{
			object obj11 = obj7 + 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Color)+10]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ S0_v77+10]");
			object obj13 = (nint)num3 + (nint)0;
			obj10 = obj11;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Color)+14]");
		object obj14 = 0;
		nint num11 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ S1_v49 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj15 = (nint)0 & (nint)0x200;
		if (obj15 != null)
		{
			nint num12 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ S1_v74 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S0_v53+8]");
		if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)0))
		{
			object obj16 = obj10 + 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Color)+14]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ S0_v73+10]");
			object obj18 = (nint)num4 + (nint)0;
			obj10 = obj16;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Color)+18]");
		object obj19 = 0;
		nint num13 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ S1_v56 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj20 = (nint)0 & (nint)0x200;
		if (obj20 != null)
		{
			nint num14 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ S1_v67 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ S0_v58+8]");
		if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)0))
		{
			object obj21 = obj10 + 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Color)+18]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ S0_v69+10]");
			object obj23 = (nint)num4 + (nint)0;
			obj10 = obj21;
		}
		if (obj10 != null)
		{
			((UIRect)color).ResetAnchors();
		}
		return color;
	}

	public unsafe UIColorPicker()
	{
		//IL_0526: Unknown result type (might be due to invalid IL or missing references)
		//IL_052b: Expected Obj, but got Unknown
		//IL_0534: Expected Obj, but got I4
		//IL_0548: Expected I, but got Obj
		//IL_055e: Expected Obj, but got I
		//IL_087e: Expected I, but got Obj
		//IL_0894: Expected Obj, but got I
		//IL_0584: Unknown result type (might be due to invalid IL or missing references)
		//IL_0589: Expected Obj, but got Unknown
		//IL_0596: Expected Obj, but got F4
		//IL_059f: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a4: Expected VT, but got Unknown
		//IL_05b1: Expected F4, but got Obj
		//IL_05ac: Expected native int or pointer, but got VT
		//IL_05ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bf: Expected Obj, but got Unknown
		//IL_05fd: Expected F4, but got Obj
		//IL_05f8: Expected native int or pointer, but got VT
		//IL_0612: Expected F4, but got I
		//IL_060d: Expected native int or pointer, but got VT
		//IL_061b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0620: Expected Obj, but got Unknown
		//IL_062d: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_00c1: Expected F4, but got Obj
		//IL_00bc: Expected native int or pointer, but got VT
		//IL_00d6: Expected F4, but got I
		//IL_00d1: Expected native int or pointer, but got VT
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected Obj, but got Unknown
		//IL_00f7: Expected Ref, but got VT
		//IL_0060: Expected I, but got Obj
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected Obj, but got Unknown
		//IL_0130: Expected F4, but got Obj
		//IL_012b: Expected native int or pointer, but got VT
		//IL_0145: Expected F4, but got I
		//IL_0140: Expected native int or pointer, but got VT
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected Obj, but got Unknown
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected Obj, but got Unknown
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected Obj, but got Unknown
		//IL_017d: Expected I, but got Obj
		//IL_0193: Expected Obj, but got I
		//IL_01be: Expected I, but got Obj
		//IL_0696: Expected Obj, but got F4
		//IL_069f: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a4: Expected Obj, but got Unknown
		//IL_06bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c4: Expected Obj, but got Unknown
		//IL_06cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d2: Expected Obj, but got Unknown
		//IL_06ef: Expected Obj, but got I
		//IL_06f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fd: Expected Obj, but got Unknown
		//IL_0706: Unknown result type (might be due to invalid IL or missing references)
		//IL_070b: Expected Obj, but got Unknown
		//IL_0728: Expected Obj, but got I
		//IL_0772: Expected I, but got Obj
		//IL_0788: Expected Obj, but got I
		//IL_0417: Unknown result type (might be due to invalid IL or missing references)
		//IL_041c: Expected Obj, but got Unknown
		//IL_0422: Unknown result type (might be due to invalid IL or missing references)
		//IL_0427: Expected Obj, but got Unknown
		//IL_0440: Expected F4, but got I
		//IL_0440: Expected F4, but got Obj
		//IL_0440: Expected Obj, but got VT
		//IL_044d: Expected native int or pointer, but got VT
		//IL_0467: Expected F4, but got I
		//IL_0462: Expected native int or pointer, but got VT
		//IL_046d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0472: Expected Obj, but got Unknown
		//IL_047f: Expected Obj, but got F4
		//IL_049d: Expected I, but got Obj
		//IL_04b3: Expected Obj, but got I
		//IL_0293: Expected I, but got Obj
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Expected Obj, but got Unknown
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Expected Obj, but got Unknown
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Expected Obj, but got Unknown
		//IL_0307: Expected I, but got Obj
		//IL_031d: Expected Obj, but got I
		//IL_04de: Expected I, but got Obj
		//IL_07b6: Expected F4, but got Obj
		//IL_07b6: Expected F4, but got Obj
		//IL_07b6: Expected F4, but got Obj
		//IL_07c2: Expected Obj, but got F4
		//IL_07cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d0: Expected Obj, but got Unknown
		//IL_07d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07de: Expected Obj, but got Unknown
		//IL_07e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e9: Expected Obj, but got Unknown
		//IL_0812: Expected F4, but got I
		//IL_0812: Expected F4, but got I
		//IL_0812: Expected F4, but got I
		//IL_0828: Expected F4, but got Obj
		//IL_0823: Expected native int or pointer, but got VT
		//IL_083d: Expected F4, but got I
		//IL_0838: Expected native int or pointer, but got VT
		//IL_0394: Expected Obj, but got F4
		//IL_0348: Expected I, but got Obj
		//IL_03e6: Expected F4, but got Obj
		//IL_03e1: Expected native int or pointer, but got VT
		//IL_03fb: Expected F4, but got I
		//IL_03f6: Expected native int or pointer, but got VT
		//IL_0408: Expected Obj, but got VT
		Vector2 vector = default;
		object obj = vector + 72;
		obj = 0;
		_ = 0;
		nint num = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12 (Il2CppClass<UICamera>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v109 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UICamera.lastEventPosition = vector;
		nint num3 = (nint)typeof(Vector2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v18 (Il2CppClass<UnityEngine.Vector2>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v105 (Il2CppClass<UnityEngine.Vector2>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = vector + 16;
		obj4 = vector.x;
		Vector4 vector2 = (Vector4)(vector + 88);
		((Vector4*)(nint)vector2)->x = (float)obj4;
		object obj5 = vector + 60;
		Vector3 vector3 = vector2;
		obj = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v27+8]");
		_ = 0;
		bool flag = UICamera.IsPartOfUI((GameObject)(object)mCam);
		((Vector4*)(nint)vector2)->x = (float)obj;
		Vector4 vector4 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((Vector4*)(nint)vector4)->z = 0f;
		object obj6 = vector + 48;
		Vector3 vector5 = ((Camera)flag).ScreenToViewportPoint(vector2);
		obj = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v36+8]");
		_ = 0;
		((Vector4*)(nint)vector2)->x = (float)obj;
		Vector4 vector6 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((Vector4*)(nint)vector6)->z = 0f;
		Transform transform = (Transform)(vector + 36);
		transform.Internal_LookAt_Injected(ref *(Vector3*)mTrans, ref *(Vector3*)vector2);
		obj = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		object obj7 = this + 52;
		((Vector4*)(nint)vector2)->x = (float)obj;
		Vector4 vector7 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((Vector4*)(nint)vector7)->z = 0f;
		object obj9 = default;
		object obj8 = obj9 + 16;
		object obj10 = obj9 + 40;
		object obj11 = obj9 + 16;
		nint num5 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S3_v11 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		if ((object)((nint)0 & (nint)0x200) != null)
		{
			nint num6 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S3_v31 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num7 = vector2.x - (float)obj8;
		object obj12 = obj10 - obj11;
		float num8 = num7 / (float)obj12;
		if (num8 < 0f)
		{
			num8 = 0f;
		}
		else if (num8 > 1f)
		{
			num8 = 1f;
		}
		obj7 = num8;
		object obj13 = vector + 24;
		obj13 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		object obj14 = this + 52;
		object obj15 = obj9 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ S0_v52+4]");
		nint num9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ S2_v16+4]");
		object obj16 = num9 - 0;
		object obj17 = obj9 + 40;
		object obj18 = obj9 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ S2_v19+4]");
		nint num10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ S3_v19+4]");
		object obj19 = num10 - 0;
		float num11 = (float)obj16 / (float)obj19;
		if (num11 < 0f)
		{
			num11 = 0f;
		}
		else if (num11 > 1f)
		{
			num11 = 1f;
		}
		nint num12 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ S1_v66 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj20 = (nint)0 & (nint)0x200;
		if (obj20 != null)
		{
			nint num13 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ S1_v124 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)selectionWidget).FindKernel((string)null) != 0)
		{
			object obj21 = obj9 + 16;
			object obj22 = obj9 + 40;
			object obj23 = this + 52;
			nint num14 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ S0_v85 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			if ((object)((nint)0 & (nint)0x200) != null)
			{
				nint num15 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ S0_v101 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float num16 = Mathf.LerpUnclamped((float)obj21, (float)obj22, (float)obj23);
			obj = num16;
			object obj24 = obj9 + 16;
			object obj25 = obj9 + 40;
			object obj26 = this + 52;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ S1_v103+4]");
			nint num17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ S2_v35+4]");
			nint num18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ S3_v27+4]");
			float num19 = Mathf.LerpUnclamped(num17, num18, 0f);
			((Vector4*)(nint)vector2)->x = (float)obj;
			Vector4 vector8 = vector2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			((Vector4*)(nint)vector8)->z = 0f;
			Vector3 vector9 = mTrans.InverseTransformPoint(vector2);
			obj = vector.x;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (UnityEngine.Vector2)+8]");
			_ = 0;
			GameObject gameObject = selectionWidget.gameObject;
			obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			_ = 0;
			bool offset = UICamera.IsPartOfUI((GameObject)(object)mCam);
			((Vector4*)(nint)vector2)->x = (float)obj5;
			Vector4 vector10 = vector2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v27+8]");
			((Vector4*)(nint)vector10)->z = 0f;
			Color color = NGUIText.ParseColor((string)vector2, offset ? 1 : 0);
		}
		object obj27 = this + 52;
		object obj28 = this + 52;
		Vector2 vector11 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ S2_v29+4]");
		((MinMaxSliderAttribute)vector11)._002Ector((float)obj27, 0f);
		((Vector4*)(nint)vector2)->x = vector.x;
		Vector4 vector12 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (UnityEngine.Vector2)+8]");
		((Vector4*)(nint)vector12)->z = 0f;
		object obj29 = this + 12;
		obj29 = vector2.x;
		_ = vector2.z;
		current = this;
		nint num20 = (nint)typeof(EventDelegate);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ S1_v86 (Il2CppClass<EventDelegate>)+BA]");
		object obj30 = (nint)0 & (nint)0x200;
		if (obj30 != null)
		{
			nint num21 = (nint)typeof(EventDelegate);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ S1_v92 (Il2CppClass<EventDelegate>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Localization.dictionary = (Dictionary<string, string[]>)(object)onChange;
		current = null;
	}
}
