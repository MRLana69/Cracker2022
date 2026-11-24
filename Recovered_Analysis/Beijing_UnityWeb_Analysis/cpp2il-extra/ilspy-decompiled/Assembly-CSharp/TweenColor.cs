using System;
using Cpp2ILInjected;
using UnityEngine;

public class TweenColor : UITweener
{
	public Color from;

	public Color to;

	private bool mCached;

	private UIWidget mWidget;

	private Material mMat;

	private Light mLight;

	private SpriteRenderer mSr;

	public Color color
	{
		get
		{
			Color result = default;
			return result;
		}
		set
		{
			this.value = value;
		}
	}

	public unsafe Color value
	{
		get
		{
			//IL_000a: Expected I4, but got Obj
			//IL_001e: Expected Obj, but got VT
			int num = default;
			((int*)num)->m_value = (int)this;
			_ = ((UnityEngine.Object)this).m_CachedPtr;
			Color color = default;
			((TweenHeight)color).height = num;
			return color;
		}
		set
		{
			//IL_0021: Expected I, but got Obj
			//IL_0037: Expected Obj, but got I
			//IL_0315: Expected Obj, but got I
			//IL_000e: Expected Obj, but got VT
			//IL_00e4: Expected I, but got Obj
			//IL_00fa: Expected Obj, but got I
			//IL_0062: Expected I, but got Obj
			//IL_0348: Expected Obj, but got I
			//IL_00b7: Expected Obj, but got I
			//IL_0189: Expected I, but got Obj
			//IL_019f: Expected Obj, but got I
			//IL_0125: Expected I, but got Obj
			//IL_037c: Expected Obj, but got I
			//IL_0176: Expected VT, but got I
			//IL_022e: Expected I, but got Obj
			//IL_0244: Expected Obj, but got I
			//IL_01ca: Expected I, but got Obj
			//IL_03af: Expected Obj, but got I
			//IL_021b: Expected VT, but got I
			//IL_026f: Expected I, but got Obj
			//IL_02c0: Expected VT, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (UnityEngine.Color)+78]");
			if ((nint)0 == 0)
			{
				((TweenColor)value).SetStartToCurrentValue();
			}
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v34 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (UnityEngine.Color)+7C]");
			if (((ComputeShader)0).FindKernel(null) != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (UnityEngine.Color)+7C]");
				object obj2 = (nint)0 + (nint)80;
				TweenColor tweenColor = (TweenColor)obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S1_v45+8]");
				((UnityEngine.Object)this).m_CachedPtr = (IntPtr)0;
				return;
			}
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S1_v7 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S1_v39 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (UnityEngine.Color)+80]");
			if (((ComputeShader)0).FindKernel(null) != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (UnityEngine.Color)+80]");
				((Material)(object)this).color = (Color)0;
				return;
			}
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S1_v33 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (UnityEngine.Color)+88]");
			if (((ComputeShader)0).FindKernel(null) != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (UnityEngine.Color)+88]");
				((SpriteRenderer)(object)this).color = (Color)0;
				return;
			}
			nint num7 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S1_v19 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num8 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S1_v27 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (UnityEngine.Color)+84]");
			if (((ComputeShader)0).FindKernel(null) != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (UnityEngine.Color)+84]");
				((Light)(object)this).color = (Color)0;
			}
			else
			{
				Color yellow = Color.yellow;
			}
		}
	}

	private void Cache()
	{
		//IL_000b: Expected VT, but got F4
		from = (Color)1f;
		_ = 1f;
		_ = 1f;
		((UI2DSprite)(object)this).OnUpdate();
	}

	protected override void OnUpdate(float factor, bool isFinished)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00ae: Expected F4, but got I
		//IL_00ae: Expected F4, but got VT
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v10 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v15 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Color color = from;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenColor)+5C]");
		float num3 = Mathf.LerpUnclamped((float)color, 0f, factor);
		((TweenFill)this).value = num3;
	}

	public unsafe static TweenColor Begin(GameObject go, float duration, Color color)
	{
		//IL_075f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0764: Expected VT, but got Unknown
		//IL_076d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0772: Expected VT, but got Unknown
		//IL_077b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0780: Expected Obj, but got Unknown
		//IL_0789: Unknown result type (might be due to invalid IL or missing references)
		//IL_078e: Expected Obj, but got Unknown
		//IL_0797: Unknown result type (might be due to invalid IL or missing references)
		//IL_079c: Expected Obj, but got Unknown
		//IL_07a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07aa: Expected Obj, but got Unknown
		//IL_07b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b8: Expected Obj, but got Unknown
		//IL_07c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c6: Expected Obj, but got Unknown
		//IL_07cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d4: Expected Obj, but got Unknown
		//IL_07dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e2: Expected VT, but got Unknown
		//IL_07eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f0: Expected Obj, but got Unknown
		//IL_07f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fe: Expected Obj, but got Unknown
		//IL_0807: Unknown result type (might be due to invalid IL or missing references)
		//IL_080c: Expected Obj, but got Unknown
		//IL_0815: Unknown result type (might be due to invalid IL or missing references)
		//IL_081a: Expected VT, but got Unknown
		//IL_0823: Unknown result type (might be due to invalid IL or missing references)
		//IL_0828: Expected Obj, but got Unknown
		//IL_0831: Unknown result type (might be due to invalid IL or missing references)
		//IL_0836: Expected Obj, but got Unknown
		//IL_083f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0844: Expected Obj, but got Unknown
		//IL_084d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0852: Expected VT, but got Unknown
		//IL_085b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0860: Expected Obj, but got Unknown
		//IL_0869: Unknown result type (might be due to invalid IL or missing references)
		//IL_086e: Expected Obj, but got Unknown
		//IL_0877: Unknown result type (might be due to invalid IL or missing references)
		//IL_087c: Expected Obj, but got Unknown
		//IL_0885: Unknown result type (might be due to invalid IL or missing references)
		//IL_088a: Expected VT, but got Unknown
		//IL_0893: Unknown result type (might be due to invalid IL or missing references)
		//IL_0898: Expected Obj, but got Unknown
		//IL_08a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a6: Expected Obj, but got Unknown
		//IL_08af: Expected Obj, but got I4
		//IL_08be: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c3: Expected Obj, but got Unknown
		//IL_08cc: Expected Obj, but got I4
		//IL_08db: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e0: Expected Obj, but got Unknown
		//IL_08e9: Expected Obj, but got I4
		//IL_04b5: Expected I, but got Obj
		//IL_04cb: Expected Obj, but got I
		//IL_0c25: Expected native int or pointer, but got VT
		//IL_0c33: Expected native int or pointer, but got VT
		//IL_0c41: Expected native int or pointer, but got VT
		//IL_0c4f: Expected native int or pointer, but got VT
		//IL_0c5c: Expected native int or pointer, but got VT
		//IL_0c6e: Expected native int or pointer, but got VT
		//IL_0c80: Expected native int or pointer, but got VT
		//IL_0ca3: Expected F4, but got Obj
		//IL_0c9e: Expected native int or pointer, but got VT
		//IL_0cb5: Expected F4, but got I
		//IL_0cb0: Expected native int or pointer, but got VT
		//IL_0cbf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc4: Expected Obj, but got Unknown
		//IL_0cd1: Expected Obj, but got F4
		//IL_0ce4: Expected Obj, but got I4
		//IL_0cfb: Expected Obj, but got F4
		//IL_0d0e: Expected I, but got F4
		//IL_0d1b: Expected F4, but got Obj
		//IL_0d16: Expected native int or pointer, but got VT
		//IL_0d2d: Expected F4, but got I
		//IL_0d28: Expected native int or pointer, but got VT
		//IL_0d4b: Expected F4, but got Obj
		//IL_0d46: Expected native int or pointer, but got VT
		//IL_0d60: Expected F4, but got I
		//IL_0d5b: Expected native int or pointer, but got VT
		//IL_0d6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d6f: Expected Obj, but got Unknown
		//IL_0d7c: Expected Obj, but got F4
		//IL_0d8f: Expected Obj, but got I4
		//IL_0d9e: Expected Obj, but got F4
		//IL_0db6: Expected F4, but got Obj
		//IL_0db1: Expected native int or pointer, but got VT
		//IL_0dcb: Expected F4, but got I
		//IL_0dc6: Expected native int or pointer, but got VT
		//IL_001f: Expected VT, but got Obj
		//IL_0542: Expected F4, but got Obj
		//IL_053d: Expected native int or pointer, but got VT
		//IL_0554: Expected F4, but got I
		//IL_054f: Expected native int or pointer, but got VT
		//IL_055e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0563: Expected Obj, but got Unknown
		//IL_0570: Expected Obj, but got F4
		//IL_0583: Expected Obj, but got I4
		//IL_059a: Expected Obj, but got F4
		//IL_05ad: Expected I, but got F4
		//IL_05ba: Expected F4, but got Obj
		//IL_05b5: Expected native int or pointer, but got VT
		//IL_05cc: Expected F4, but got I
		//IL_05c7: Expected native int or pointer, but got VT
		//IL_05ea: Expected F4, but got Obj
		//IL_05e5: Expected native int or pointer, but got VT
		//IL_05ff: Expected F4, but got I
		//IL_05fa: Expected native int or pointer, but got VT
		//IL_0609: Unknown result type (might be due to invalid IL or missing references)
		//IL_060e: Expected Obj, but got Unknown
		//IL_061b: Expected Obj, but got F4
		//IL_04f6: Expected I, but got Obj
		//IL_0044: Expected I, but got Obj
		//IL_005a: Expected Obj, but got I
		//IL_0be9: Expected I, but got Obj
		//IL_0bff: Expected Obj, but got I
		//IL_093b: Expected Obj, but got F4
		//IL_094b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0950: Expected Obj, but got Unknown
		//IL_096d: Expected Obj, but got I
		//IL_09b0: Expected VT, but got Obj
		//IL_0f45: Expected Obj, but got VT
		//IL_00e3: Expected VT, but got Obj
		//IL_0113: Expected Obj, but got I4
		//IL_0139: Expected I, but got Obj
		//IL_014f: Expected Obj, but got I
		//IL_0085: Expected I, but got Obj
		//IL_0def: Expected I, but got Obj
		//IL_0e05: Expected Obj, but got I
		//IL_062e: Expected I, but got Obj
		//IL_09c2: Expected F4, but got Obj
		//IL_09bd: Expected native int or pointer, but got VT
		//IL_09d7: Expected F4, but got I
		//IL_09d2: Expected native int or pointer, but got VT
		//IL_09e4: Expected F4, but got Obj
		//IL_09df: Expected native int or pointer, but got VT
		//IL_09f9: Expected F4, but got I
		//IL_09f4: Expected native int or pointer, but got VT
		//IL_0a0a: Expected Ref, but got VT
		//IL_0a2d: Expected I, but got Obj
		//IL_0a43: Expected Obj, but got I
		//IL_0676: Expected Obj, but got I4
		//IL_0a6d: Expected native int or pointer, but got VT
		//IL_0a7f: Expected native int or pointer, but got VT
		//IL_0a91: Expected F4, but got Obj
		//IL_0a8c: Expected native int or pointer, but got VT
		//IL_0aa6: Expected F4, but got I
		//IL_0aa1: Expected native int or pointer, but got VT
		//IL_0ac4: Expected F4, but got Obj
		//IL_0abf: Expected native int or pointer, but got VT
		//IL_0ad9: Expected F4, but got I
		//IL_0ad4: Expected native int or pointer, but got VT
		//IL_0ae3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae8: Expected Obj, but got Unknown
		//IL_0af5: Expected Obj, but got F4
		//IL_0b08: Expected Obj, but got I4
		//IL_0b2d: Expected F4, but got Obj
		//IL_0b28: Expected native int or pointer, but got VT
		//IL_0b42: Expected F4, but got I
		//IL_0b3d: Expected native int or pointer, but got VT
		//IL_0b4f: Expected F4, but got Obj
		//IL_0b4a: Expected native int or pointer, but got VT
		//IL_0b64: Expected F4, but got I
		//IL_0b5f: Expected native int or pointer, but got VT
		//IL_0b75: Expected Ref, but got VT
		//IL_0b82: Expected native int or pointer, but got VT
		//IL_0b94: Expected native int or pointer, but got VT
		//IL_0ba6: Expected F4, but got Obj
		//IL_0ba1: Expected native int or pointer, but got VT
		//IL_0bbb: Expected F4, but got I
		//IL_0bb6: Expected native int or pointer, but got VT
		//IL_017a: Expected I, but got Obj
		//IL_0717: Expected I, but got Obj
		//IL_0213: Expected F4, but got Obj
		//IL_020e: Expected native int or pointer, but got VT
		//IL_0228: Expected F4, but got I
		//IL_0223: Expected native int or pointer, but got VT
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected Obj, but got Unknown
		//IL_0244: Expected Obj, but got F4
		//IL_026c: Expected Obj, but got I4
		//IL_027a: Expected Obj, but got F4
		//IL_0291: Expected F4, but got Obj
		//IL_028c: Expected native int or pointer, but got VT
		//IL_02a6: Expected F4, but got I
		//IL_02a1: Expected native int or pointer, but got VT
		//IL_02b3: Expected F4, but got Obj
		//IL_02ae: Expected native int or pointer, but got VT
		//IL_02c8: Expected F4, but got I
		//IL_02c3: Expected native int or pointer, but got VT
		//IL_02d9: Expected Ref, but got VT
		//IL_02e6: Expected native int or pointer, but got VT
		//IL_02f8: Expected native int or pointer, but got VT
		//IL_030a: Expected F4, but got Obj
		//IL_0305: Expected native int or pointer, but got VT
		//IL_031f: Expected F4, but got I
		//IL_031a: Expected native int or pointer, but got VT
		//IL_01c7: Expected I, but got Obj
		//IL_0342: Expected F4, but got Obj
		//IL_033d: Expected native int or pointer, but got VT
		//IL_0357: Expected F4, but got I
		//IL_0352: Expected native int or pointer, but got VT
		//IL_0361: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Expected Obj, but got Unknown
		//IL_0373: Expected Obj, but got F4
		//IL_039b: Expected Obj, but got I4
		//IL_03a9: Expected Obj, but got F4
		//IL_03c0: Expected F4, but got Obj
		//IL_03bb: Expected native int or pointer, but got VT
		//IL_03d5: Expected F4, but got I
		//IL_03d0: Expected native int or pointer, but got VT
		//IL_03e2: Expected F4, but got Obj
		//IL_03dd: Expected native int or pointer, but got VT
		//IL_03f7: Expected F4, but got I
		//IL_03f2: Expected native int or pointer, but got VT
		//IL_0408: Expected Ref, but got VT
		//IL_0415: Expected native int or pointer, but got VT
		//IL_0427: Expected native int or pointer, but got VT
		//IL_0439: Expected F4, but got Obj
		//IL_0434: Expected native int or pointer, but got VT
		//IL_044e: Expected F4, but got I
		//IL_0449: Expected native int or pointer, but got VT
		//IL_0689: Expected I, but got Obj
		//IL_069f: Expected Obj, but got I
		//IL_0471: Expected F4, but got Obj
		//IL_046c: Expected native int or pointer, but got VT
		//IL_0486: Expected F4, but got I
		//IL_0481: Expected native int or pointer, but got VT
		//IL_0490: Unknown result type (might be due to invalid IL or missing references)
		//IL_0495: Expected Obj, but got Unknown
		//IL_04a2: Expected Obj, but got F4
		//IL_0e2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e31: Expected Obj, but got Unknown
		//IL_0e3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e3f: Expected Obj, but got Unknown
		//IL_0e59: Expected F4, but got Obj
		//IL_0e54: Expected native int or pointer, but got VT
		//IL_0e6e: Expected F4, but got I
		//IL_0e69: Expected native int or pointer, but got VT
		//IL_0e7b: Expected native int or pointer, but got VT
		//IL_0e8d: Expected native int or pointer, but got VT
		//IL_0ea3: Expected Ref, but got VT
		//IL_0ea3: Expected Ref, but got VT
		//IL_0eb0: Expected F4, but got Obj
		//IL_0eab: Expected native int or pointer, but got VT
		//IL_0ec2: Expected F4, but got I
		//IL_0ebd: Expected native int or pointer, but got VT
		//IL_0ecc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed1: Expected Obj, but got Unknown
		//IL_0eda: Unknown result type (might be due to invalid IL or missing references)
		//IL_0edf: Expected Obj, but got Unknown
		//IL_0ef9: Expected Obj, but got F4
		//IL_0f0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f11: Expected Obj, but got Unknown
		//IL_06ca: Expected I, but got Obj
		object obj = default;
		Vector3 vector = (Vector3)(obj + 368);
		Vector3 vector2 = (Vector3)(obj + 352);
		Camera camera = (Camera)(obj + 288);
		PropertyBinding propertyBinding = (PropertyBinding)(obj + 32);
		object obj2 = obj + 16;
		Transform transform = (Transform)(obj + 272);
		Transform transform2 = (Transform)(obj + 256);
		object obj3 = obj + 240;
		object obj4 = obj + 224;
		Quaternion quaternion = (Quaternion)(obj + 212);
		object obj5 = obj + 200;
		object obj6 = obj + 188;
		object obj7 = obj + 176;
		Quaternion quaternion2 = (Quaternion)(obj + 164);
		object obj8 = obj + 152;
		object obj9 = obj + 136;
		object obj10 = obj + 120;
		Quaternion quaternion3 = (Quaternion)(obj + 108);
		object obj11 = obj + 96;
		object obj12 = obj + 80;
		object obj13 = obj + 68;
		Quaternion quaternion4 = (Quaternion)(obj + 56);
		object obj14 = obj + 44;
		object obj15 = obj + 336;
		obj15 = 0;
		_ = 0;
		object obj16 = obj + 320;
		obj16 = 0;
		_ = 0;
		object obj17 = obj + 304;
		obj17 = 0;
		_ = 0;
		if (((Camera)(object)go).transparencySortMode != TransparencySortMode.Default)
		{
			float depth = ((Camera)(object)go).depth;
			camera.rect = (Rect)go;
			obj15 = camera;
			_ = ((UnityEngine.Object)camera).m_CachedPtr;
			nint num = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ S0_v155 (Il2CppClass<NGUITools>)+BA]");
			object obj18 = (nint)0 & (nint)0x200;
			if (obj18 != null)
			{
				nint num2 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ S0_v198 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			propertyBinding.Start();
			obj2 = propertyBinding;
			obj = propertyBinding;
			object obj19 = 0f - depth;
			object obj20 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj21 = obj20 / 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v55+8]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v55+C]");
			object obj22 = num3 / 0;
			object obj23 = obj21 * obj22;
			object obj24 = obj19 * obj23;
			float num4 = depth * (float)obj23;
			GameObject gameObject = ((Component)(object)go).gameObject;
			transform.rotation = (Quaternion)gameObject;
			obj16 = transform;
			_ = ((UnityEngine.Object)transform).m_CachedPtr;
			transform2.position = (Vector3)gameObject;
			obj17 = transform2;
			_ = ((UnityEngine.Object)transform2).m_CachedPtr;
			obj3 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v58+8]");
			_ = 0;
			obj4 = 0;
			_ = 0;
			obj4 = obj24;
			nint num5 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ S1_v155 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
			object obj25 = (nint)0 & (nint)0x200;
			if (obj25 != null)
			{
				nint num6 = (nint)typeof(Quaternion);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v462 @ S1_v255 (Il2CppClass<UnityEngine.Quaternion>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Vector3*)(nint)vector2)->x = (float)obj3;
			Vector3 vector3 = vector2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v23+8]");
			((Vector3*)(nint)vector3)->z = 0f;
			((Vector3*)(nint)vector)->x = (float)obj4;
			Vector3 vector4 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v25+8]");
			((Vector3*)(nint)vector4)->z = 0f;
			((Quaternion*)quaternion)->SetLookRotation(vector2, vector);
			obj5 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v61+8]");
			_ = 0;
			nint num7 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ S1_v167 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj26 = (nint)0 & (nint)0x200;
			if (obj26 != null)
			{
				nint num8 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v525 @ S1_v251 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Vector3*)(nint)vector2)->x = quaternion.x;
			((Vector3*)(nint)vector2)->z = quaternion.z;
			((Vector3*)(nint)vector)->x = (float)obj5;
			Vector3 vector5 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v29+8]");
			((Vector3*)(nint)vector5)->z = 0f;
			Vector3 vector6 = vector2 - vector;
			((Vector3*)(nint)vector)->x = (float)obj6;
			Vector3 vector7 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v31+8]");
			((Vector3*)(nint)vector7)->z = 0f;
			object obj27 = NGUITools.mSides + 16;
			obj27 = vector.x;
			_ = vector.z;
			obj7 = 0;
			_ = 0;
			obj7 = obj24;
			((Vector3*)(nint)vector2)->x = (float)obj16;
			Vector3 vector8 = vector2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v58+8]");
			((Vector3*)(nint)vector8)->z = 0f;
			((Vector3*)(nint)vector)->x = (float)obj7;
			Vector3 vector9 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v33+8]");
			((Vector3*)(nint)vector9)->z = 0f;
			((Quaternion*)quaternion2)->SetLookRotation(vector2, vector);
			((Vector3*)(nint)vector2)->x = quaternion2.x;
			((Vector3*)(nint)vector2)->z = quaternion2.z;
			((Vector3*)(nint)vector)->x = (float)obj17;
			Vector3 vector10 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v61+8]");
			((Vector3*)(nint)vector10)->z = 0f;
			Vector3 vector11 = vector2 - vector;
			((Vector3*)(nint)vector)->x = (float)obj8;
			Vector3 vector12 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v37+8]");
			((Vector3*)(nint)vector12)->z = 0f;
			object obj28 = NGUITools.mSides + 28;
			obj28 = vector.x;
			_ = vector.z;
			obj9 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v58+8]");
			_ = 0;
			obj10 = 0;
			_ = 0;
			obj10 = num4;
			((Vector3*)(nint)vector2)->x = (float)obj9;
			Vector3 vector13 = vector2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v39+8]");
			((Vector3*)(nint)vector13)->z = 0f;
			((Vector3*)(nint)vector)->x = (float)obj10;
			Vector3 vector14 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v41+8]");
			((Vector3*)(nint)vector14)->z = 0f;
			((Quaternion*)quaternion3)->SetLookRotation(vector2, vector);
			((Vector3*)(nint)vector2)->x = quaternion3.x;
			((Vector3*)(nint)vector2)->z = quaternion3.z;
			((Vector3*)(nint)vector)->x = (float)obj17;
			Vector3 vector15 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v61+8]");
			((Vector3*)(nint)vector15)->z = 0f;
			Vector3 vector16 = vector2 - vector;
			((Vector3*)(nint)vector)->x = (float)obj11;
			Vector3 vector17 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v45+8]");
			((Vector3*)(nint)vector17)->z = 0f;
			object obj29 = NGUITools.mSides + 40;
			obj29 = vector.x;
			_ = vector.z;
			obj12 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v58+8]");
			_ = 0;
			obj13 = 0;
			_ = 0;
			obj13 = num4;
			((Vector3*)(nint)vector2)->x = (float)obj12;
			Vector3 vector18 = vector2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v47+8]");
			((Vector3*)(nint)vector18)->z = 0f;
			((Vector3*)(nint)vector)->x = (float)obj13;
			Vector3 vector19 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v49+8]");
			((Vector3*)(nint)vector19)->z = 0f;
			((Quaternion*)quaternion4)->SetLookRotation(vector2, vector);
			((Vector3*)(nint)vector2)->x = quaternion4.x;
			((Vector3*)(nint)vector2)->z = quaternion4.z;
			((Vector3*)(nint)vector)->x = (float)obj17;
			Vector3 vector20 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v61+8]");
			((Vector3*)(nint)vector20)->z = 0f;
			Vector3 vector21 = vector2 - vector;
			((Vector3*)(nint)vector)->x = (float)obj14;
			Vector3 vector22 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v53+8]");
			((Vector3*)(nint)vector22)->z = 0f;
			object obj30 = NGUITools.mSides + 52;
			obj30 = vector.x;
		}
		else
		{
			nint num9 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S0_v117 (Il2CppClass<NGUITools>)+BA]");
			object obj31 = (nint)0 & (nint)0x200;
			if (obj31 != null)
			{
				nint num10 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S0_v143 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Vector3*)(nint)vector2)->x = 0f;
			((Vector3*)(nint)vector2)->z = 0f;
			((Vector3*)(nint)vector2)->x = 0f;
			((Vector3*)(nint)vector2)->y = 0f;
			((Vector3*)(nint)vector2)->z = duration;
			((Vector3*)(nint)vector)->x = vector2.x;
			((Vector3*)(nint)vector)->z = vector2.z;
			Vector3 vector23 = ((Camera)(object)go).ScreenToWorldPoint(vector);
			((Vector3*)(nint)vector)->x = (float)camera;
			((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)camera).m_CachedPtr;
			object obj32 = NGUITools.mSides + 16;
			obj32 = vector.x;
			_ = vector.z;
			propertyBinding = (PropertyBinding)0;
			((UnityEngine.Object)propertyBinding).m_CachedPtr = (IntPtr)0;
			propertyBinding = (PropertyBinding)0f;
			_ = 1f;
			((UnityEngine.Object)propertyBinding).m_CachedPtr = (IntPtr)duration;
			((Vector3*)(nint)vector)->x = (float)propertyBinding;
			((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)propertyBinding).m_CachedPtr;
			Vector3 vector24 = ((Camera)(object)go).ScreenToWorldPoint(vector);
			((Vector3*)(nint)vector)->x = (float)obj2;
			Vector3 vector25 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
			((Vector3*)(nint)vector25)->z = 0f;
			object obj33 = NGUITools.mSides + 28;
			obj33 = vector.x;
			_ = vector.z;
			obj = 0;
			_ = 0;
			obj = 1f;
			_ = 1f;
			((Vector3*)(nint)vector)->x = (float)obj;
			Vector3 vector26 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((Vector3*)(nint)vector26)->z = 0f;
			Vector3 vector27 = ((Camera)(object)go).ScreenToWorldPoint(vector);
			((Vector3*)(nint)vector)->x = (float)transform;
			((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
			object obj34 = NGUITools.mSides + 40;
			obj34 = vector.x;
			_ = vector.z;
			transform2 = (Transform)0;
			((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
			transform2 = (Transform)1f;
			_ = 0f;
			((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)duration;
			((Vector3*)(nint)vector)->x = (float)transform2;
			((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform2).m_CachedPtr;
			Vector3 vector28 = ((Camera)(object)go).ScreenToWorldPoint(vector);
			((Vector3*)(nint)vector)->x = (float)obj3;
			Vector3 vector29 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v23+8]");
			((Vector3*)(nint)vector29)->z = 0f;
			object obj35 = NGUITools.mSides + 52;
			obj35 = vector.x;
		}
		_ = vector.z;
		nint num11 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ S0_v68 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj36 = (nint)0 & (nint)0x200;
		if (obj36 != null)
		{
			nint num12 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ S0_v112 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)color).FindKernel(null) != 0)
		{
			object obj37 = 0;
			while ((nint)obj37 <= 3)
			{
				nint num13 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v619 @ S0_v94 (Il2CppClass<NGUITools>)+BA]");
				object obj38 = (nint)0 & (nint)0x200;
				if (obj38 != null)
				{
					nint num14 = (nint)typeof(NGUITools);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v643 @ S0_v106 (Il2CppClass<NGUITools>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj39 = NGUITools.mSides + 16;
				object obj40 = obj37 * 12;
				object obj41 = obj39 + obj40;
				((Vector3*)(nint)vector2)->x = (float)obj41;
				Vector3 vector30 = vector2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v664 @ S2_v10+8]");
				((Vector3*)(nint)vector30)->z = 0f;
				((Vector3*)(nint)vector)->x = vector2.x;
				((Vector3*)(nint)vector)->z = vector2.z;
				((Transform)(object)camera).Internal_LookAt_Injected(ref *(Vector3*)color, ref *(Vector3*)vector);
				((Vector3*)(nint)vector)->x = (float)camera;
				((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)camera).m_CachedPtr;
				object obj42 = NGUITools.mSides + 16;
				object obj43 = obj37 * 12;
				object obj44 = obj42 + obj43;
				obj44 = vector.x;
				_ = vector.z;
				object obj45 = obj37 + 1;
				obj37 = obj45;
			}
		}
		nint num15 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v519 @ S0_v76 (Il2CppClass<NGUITools>)+BA]");
		object obj46 = (nint)0 & (nint)0x200;
		if (obj46 != null)
		{
			nint num16 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v560 @ S0_v83 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (TweenColor)(object)NGUITools.mSides;
	}

	public override void SetStartToCurrentValue()
	{
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Expected Obj, but got Unknown
		//IL_02bd: Expected I, but got Obj
		//IL_02d3: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_007d: Expected I, but got Obj
		//IL_0093: Expected Obj, but got I
		//IL_00be: Expected I, but got Obj
		//IL_0115: Expected I, but got Obj
		//IL_012b: Expected Obj, but got I
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected Obj, but got Unknown
		//IL_01e5: Expected I, but got Obj
		//IL_01fb: Expected Obj, but got I
		//IL_0156: Expected I, but got Obj
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected Obj, but got Unknown
		//IL_0226: Expected I, but got Obj
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Expected Obj, but got Unknown
		mCached = true;
		object obj = this + 124;
		UIWidget component = GetComponent<UIWidget>();
		obj = component;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v47 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)mWidget).FindKernel((string)null) != 0)
		{
			return;
		}
		object obj3 = this + 136;
		SpriteRenderer component2 = GetComponent<SpriteRenderer>();
		obj3 = component2;
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S1_v41 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)mSr).FindKernel((string)null) != 0)
		{
			return;
		}
		Renderer component3 = GetComponent<Renderer>();
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v28 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v43 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)component3).FindKernel((string)null) != 0)
		{
			object obj6 = this + 128;
			Material sharedMaterial = component3.sharedMaterial;
			obj6 = sharedMaterial;
			return;
		}
		object obj7 = this + 132;
		Light component4 = GetComponent<Light>();
		obj7 = component4;
		nint num7 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S1_v26 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num8 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S1_v34 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (mLight != null)
		{
			object obj9 = this + 124;
			_0021_00210[] componentsInChildren = (_0021_00210[])(object)((Component)this).GetComponentsInChildren<T>();
			obj9 = componentsInChildren;
		}
	}

	public override void SetEndToCurrentValue()
	{
		//IL_000a: Expected VT, but got Obj
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected Obj, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		TweenColor tweenColor = default;
		tweenColor.value = (Color)this;
		object obj = tweenColor + 16;
		obj = tweenColor;
		_ = ((UnityEngine.Object)tweenColor).m_CachedPtr;
		object obj2 = this + 88;
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6+8]");
		_ = 0;
	}

	private void SetCurrentValueToStart()
	{
		//IL_000a: Expected VT, but got Obj
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected Obj, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		TweenColor tweenColor = default;
		tweenColor.value = (Color)this;
		object obj = tweenColor + 16;
		obj = tweenColor;
		_ = ((UnityEngine.Object)tweenColor).m_CachedPtr;
		object obj2 = this + 104;
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6+8]");
		_ = 0;
	}

	private unsafe void SetCurrentValueToEnd()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected I4, but got Unknown
		//IL_003b: Expected I4, but got Obj
		object obj = this + 88;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ S1_v3+8]");
		_ = 0;
		int num = obj2 + 16;
		((int*)num)->m_value = (int)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		((TweenHeight)this).height = num;
	}

	public unsafe TweenColor()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected I4, but got Unknown
		//IL_003b: Expected I4, but got Obj
		object obj = this + 104;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ S1_v3+8]");
		_ = 0;
		int num = obj2 + 16;
		((int*)num)->m_value = (int)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		((TweenHeight)this).height = num;
	}
}
