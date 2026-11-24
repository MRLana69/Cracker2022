using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public class TweenFill : UITweener
{
	public float from;

	public float to;

	private bool mCached;

	private UIBasicSprite mSprite;

	public unsafe float value
	{
		get
		{
			//IL_001e: Expected I, but got Obj
			//IL_0034: Expected Obj, but got I
			//IL_00bb: Expected I, but got Obj
			//IL_00d1: Expected Obj, but got I
			//IL_005f: Expected I, but got Obj
			//IL_028e: Expected Obj, but got I
			//IL_0173: Expected I, but got Obj
			//IL_0189: Expected Obj, but got I
			//IL_00fc: Expected I, but got Obj
			//IL_02c6: Expected Obj, but got I
			//IL_0150: Expected VT, but got I
			//IL_0160: Expected F4, but got I
			//IL_01b4: Expected I, but got Obj
			//IL_0208: Expected VT, but got I
			//IL_0218: Expected F4, but got I
			if (~(mCached ? 1u : 0u) != 0)
			{
				((TweenAlpha)this).SetStartToCurrentValue();
			}
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v15 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v37 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)mSprite).FindKernel((string)null) != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76C9");
				float result = default;
				return result;
			}
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S1_v9 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S1_v28 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenFill)+70]");
			SpriteRenderer spriteRenderer = default;
			if (((ComputeShader)0).FindKernel(null) != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenFill)+70]");
				spriteRenderer.color = (Color)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (UnityEngine.SpriteRenderer)+C]");
				return 0f;
			}
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S1_v15 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S1_v22 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenFill)+68]");
			if (((ComputeShader)0).FindKernel(null) != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenFill)+68]");
				((Material)(object)spriteRenderer).color = (Color)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (UnityEngine.SpriteRenderer)+C]");
				return 0f;
			}
			return 1f;
		}
		set
		{
			//IL_0351: Unknown result type (might be due to invalid IL or missing references)
			//IL_0356: Expected Obj, but got Unknown
			//IL_035f: Expected Obj, but got I4
			//IL_036e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0373: Expected Obj, but got Unknown
			//IL_037c: Expected Obj, but got I4
			//IL_001e: Expected I, but got Obj
			//IL_0034: Expected Obj, but got I
			//IL_03af: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b4: Expected Ref, but got Unknown
			//IL_00bb: Expected I, but got Obj
			//IL_00d1: Expected Obj, but got I
			//IL_005f: Expected I, but got Obj
			//IL_03f3: Expected Obj, but got I
			//IL_01a9: Expected I, but got Obj
			//IL_01bf: Expected Obj, but got I
			//IL_00fc: Expected I, but got Obj
			//IL_0427: Expected Obj, but got I
			//IL_0150: Expected VT, but got I
			//IL_0191: Expected Obj, but got I
			//IL_0297: Expected I, but got Obj
			//IL_02ad: Expected Obj, but got I
			//IL_01ea: Expected I, but got Obj
			//IL_045a: Expected Obj, but got I
			//IL_023e: Expected VT, but got I
			//IL_027f: Expected Obj, but got Ref
			//IL_027f: Expected Obj, but got I
			//IL_02d8: Expected I, but got Obj
			//IL_0343: Expected Obj, but got I
			SpriteRenderer spriteRenderer = default;
			object obj = spriteRenderer + 32;
			obj = 0;
			_ = 0;
			object obj2 = spriteRenderer + 16;
			obj2 = 0;
			_ = 0;
			if (~(mCached ? 1u : 0u) != 0)
			{
				((TweenAlpha)this).SetStartToCurrentValue();
			}
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v21 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v55 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			ref Color reference = ref *(Color*)(spriteRenderer + 48);
			if (((ComputeShader)(object)mSprite).FindKernel((string)null) != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
				return;
			}
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S1_v15 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S1_v63 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenFill)+70]");
			if (((ComputeShader)0).FindKernel(null) != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenFill)+70]");
				spriteRenderer.color = (Color)0;
				obj = spriteRenderer;
				_ = ((UnityEngine.Object)spriteRenderer).m_CachedPtr;
				reference = ref *(Color*)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenFill)+70]");
				((SpriteRenderer)0).get_color_Injected(out reference);
				return;
			}
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S1_v21 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S1_v49 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenFill)+68]");
			if (((ComputeShader)0).FindKernel(null) != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenFill)+68]");
				((Material)(object)spriteRenderer).color = (Color)0;
				obj2 = spriteRenderer;
				_ = ((UnityEngine.Object)spriteRenderer).m_CachedPtr;
				reference = ref *(Color*)obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenFill)+68]");
				((Material)0).mainTexture = (Texture)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
				return;
			}
			nint num7 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S1_v27 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num8 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S1_v35 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenFill)+6C]");
			if (((ComputeShader)0).FindKernel(null) != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenFill)+74]");
				float mipMapBias = 0f * value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TweenFill)+6C]");
				((Texture)0).mipMapBias = mipMapBias;
			}
		}
	}

	private void Cache()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected Obj, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected Obj, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		Color black = Color.black;
		object obj3 = obj2 + 32;
		obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+8]");
		_ = 0;
		object obj4 = this + 88;
		obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v7+8]");
		_ = 0;
		Color black2 = Color.black;
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj5 = this + 104;
		obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v7+8]");
		_ = 0;
		((UI2DSprite)(object)this).OnUpdate();
	}

	protected unsafe override void OnUpdate(float factor, bool isFinished)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected Obj, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected Obj, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected Obj, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected I4, but got Unknown
		//IL_0077: Expected I4, but got Obj
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected I4, but got Unknown
		//IL_009f: Expected I4, but got Obj
		//IL_00c1: Expected Ref, but got VT
		//IL_00d3: Expected I4, but got F4
		Matrix4x4 matrix4x = default;
		object obj = matrix4x + 32;
		object obj2 = this + 88;
		obj = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v4+8]");
		_ = 0;
		object obj3 = matrix4x + 16;
		object obj4 = this + 104;
		obj3 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v10+8]");
		_ = 0;
		int num = matrix4x + 48;
		((int*)num)->m_value = (int)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+8]");
		_ = 0;
		int num2 = matrix4x - -64;
		((int*)num2)->m_value = (int)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v8+8]");
		_ = 0;
		((Matrix4x4*)matrix4x)->set_Item(num, num2, factor);
		((int*)num2)->m_value = (int)matrix4x.m00;
		_ = matrix4x.m20;
		((TweenHeight)this).height = num2;
	}

	public unsafe static TweenFill Begin(GameObject go, float duration, float fill)
	{
		//IL_0cd7: Expected I, but got Obj
		//IL_0ced: Expected Obj, but got I
		//IL_0d18: Expected I, but got Obj
		//IL_0d2e: Expected Obj, but got I
		//IL_13be: Unknown result type (might be due to invalid IL or missing references)
		//IL_13c3: Expected I, but got Unknown
		//IL_13cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_13d1: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0145: Expected I, but got Obj
		//IL_015b: Expected Obj, but got I
		//IL_0178: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0d9e: Expected Obj, but got I
		//IL_0dd5: Expected I, but got Obj
		//IL_0deb: Expected Obj, but got I
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_0194: Expected I, but got Obj
		//IL_01c4: Expected I, but got Obj
		//IL_01fd: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_024a: Expected I, but got Obj
		//IL_0260: Expected Obj, but got I
		//IL_01ea: Expected I, but got Obj
		//IL_0e5d: Expected I, but got Obj
		//IL_0e73: Expected Obj, but got I
		//IL_028b: Expected I, but got Obj
		//IL_0325: Expected I, but got Obj
		//IL_033b: Expected Obj, but got I
		//IL_02d8: Expected I, but got Obj
		//IL_03b8: Expected I, but got Obj
		//IL_03ce: Expected Obj, but got I
		//IL_0366: Expected I, but got Obj
		//IL_0f13: Expected I, but got Obj
		//IL_0f2e: Expected I, but got Obj
		//IL_0f44: Expected Obj, but got I
		//IL_03f9: Expected I, but got Obj
		//IL_0ec5: Expected I, but got Obj
		//IL_0edb: Expected Obj, but got I
		//IL_0fa3: Expected I, but got Obj
		//IL_0fb9: Expected Obj, but got I
		//IL_0446: Expected I, but got Obj
		//IL_1427: Expected I, but got Obj
		//IL_143d: Expected Obj, but got I
		//IL_1468: Expected I, but got Obj
		//IL_147e: Expected Obj, but got I
		//IL_048e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0493: Expected Obj, but got Unknown
		//IL_049c: Expected Obj, but got I4
		//IL_08ed: Expected I, but got Obj
		//IL_061e: Expected I, but got Obj
		//IL_093a: Expected I, but got Obj
		//IL_066b: Expected I, but got Obj
		//IL_0987: Expected I, but got Obj
		//IL_099d: Expected Obj, but got I
		//IL_06c1: Expected I, but got Obj
		//IL_06d7: Expected Obj, but got I
		//IL_04aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_04af: Expected Obj, but got Unknown
		//IL_04d8: Expected I, but got Obj
		//IL_04ee: Expected Obj, but got I
		//IL_09c8: Expected I, but got Obj
		//IL_1071: Expected I, but got Obj
		//IL_1087: Expected Obj, but got I
		//IL_0702: Expected I, but got Obj
		//IL_0562: Unknown result type (might be due to invalid IL or missing references)
		//IL_0567: Expected Obj, but got Unknown
		//IL_0590: Expected I, but got Obj
		//IL_05a6: Expected Obj, but got I
		//IL_0519: Expected I, but got Obj
		//IL_0a15: Expected I, but got Obj
		//IL_0a2b: Expected Obj, but got I
		//IL_0735: Expected I, but got Obj
		//IL_074b: Expected Obj, but got I
		//IL_0547: Unknown result type (might be due to invalid IL or missing references)
		//IL_054c: Expected Obj, but got Unknown
		//IL_0827: Expected I, but got Obj
		//IL_10bf: Expected I, but got Obj
		//IL_10da: Expected I, but got Obj
		//IL_10f0: Expected Obj, but got I
		//IL_05d1: Expected I, but got Obj
		//IL_0a56: Expected I, but got Obj
		//IL_0776: Expected I, but got Obj
		//IL_0aa3: Expected I, but got Obj
		//IL_0ab9: Expected Obj, but got I
		//IL_0879: Expected I, but got Obj
		//IL_088f: Expected Obj, but got I
		//IL_07a9: Expected I, but got Obj
		//IL_11ea: Expected I, but got Obj
		//IL_1200: Expected Obj, but got I
		//IL_0ae4: Expected I, but got Obj
		//IL_08ba: Expected I, but got Obj
		//IL_1300: Expected I, but got Obj
		//IL_1316: Expected Obj, but got I
		//IL_0b17: Expected I, but got Obj
		//IL_0b4a: Expected I, but got Obj
		//IL_0b60: Expected Obj, but got I
		//IL_0c65: Expected I, but got Obj
		//IL_126b: Expected I, but got Obj
		//IL_1281: Expected Obj, but got I
		//IL_1297: Expected I, but got Obj
		//IL_12ad: Expected Obj, but got I
		//IL_0b8b: Expected I, but got Obj
		//IL_0bbe: Expected I, but got Obj
		//IL_0bf1: Expected I, but got Obj
		//IL_0c07: Expected Obj, but got I
		//IL_135c: Expected I, but got Obj
		//IL_1372: Expected Obj, but got I
		//IL_0c32: Expected I, but got Obj
		float unscaledDeltaTime = Time.unscaledDeltaTime;
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v11 (Il2CppClass<NGUITools>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v413 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v19 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v409 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		nint num5 = (nint)(obj3 + 8);
		object obj4 = obj3 + 4;
		if (NGUITools.mLastClip != go)
		{
			nint num6 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v392 (Il2CppClass<NGUITools>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num7 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v403 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float num8 = NGUITools.mLastTimestamp + 0.1f;
			if (num8 > unscaledDeltaTime)
			{
				return null;
			}
		}
		nint num9 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v33 (Il2CppClass<NGUITools>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		bool flag = obj6 == null;
		nint num10 = (nint)typeof(NGUITools);
		if (!flag)
		{
			nint num11 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v385 (Il2CppClass<NGUITools>)+74]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			num10 = (nint)typeof(NGUITools);
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num10 = (nint)typeof(NGUITools);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ L3_v7 (Il2CppClass<NGUITools>)+5C]");
		object obj7 = (nint)0 + (nint)20;
		obj7 = go;
		NGUITools.mLastTimestamp = unscaledDeltaTime;
		float time = RealTime.time;
		float num12 = duration * time;
		nint num13 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S0_v46 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num14 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S0_v381 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag4 = num12 > 0.01f;
		int num15 = ((ComputeShader)(object)go).FindKernel((string)null);
		if (((flag4 ? 1u : 0u) & (uint)num15) != 0)
		{
			nint num16 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ S0_v55 (Il2CppClass<NGUITools>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num17 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ S0_v375 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num18 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ S0_v63 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num19 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ S0_v371 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (NGUITools.mListener == null)
			{
				nint num20 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ S0_v356 (Il2CppClass<NGUITools>)+BA]");
				object obj11 = (nint)0 & (nint)0x200;
				if (obj11 != null)
				{
					nint num21 = (nint)typeof(NGUITools);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ S0_v365 (Il2CppClass<NGUITools>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (NGUITools.GetActive((GameObject)(object)NGUITools.mListener))
				{
					goto IL_0eb7;
				}
			}
			nint num22 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ S0_v219 (Il2CppClass<System.Type>)+BA]");
			object obj12 = (nint)0 & (nint)0x200;
			if (obj12 != null)
			{
				nint num23 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ S0_v351 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj4 = typeof(AudioListener);
			((IntPtr*)num5)->m_value = (void*)(nint)obj4;
			Type type = Type.internal_from_handle((IntPtr)num5);
			nint num24 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ S0_v228 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj13 = (nint)0 & (nint)0x200;
			if (obj13 != null)
			{
				nint num25 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ S0_v347 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			HideFlags hideFlags = ((UnityEngine.Object)(object)type).hideFlags;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
			object obj14 = default;
			if (obj14 != null)
			{
				object obj15 = obj14 + 12;
				object obj16 = 0;
				while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj16) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj15))
				{
					object obj17 = obj14 + 16;
					object obj18 = obj16 << 2;
					object go2 = obj17 + obj18;
					nint num26 = (nint)typeof(NGUITools);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ S1_v128 (Il2CppClass<NGUITools>)+BA]");
					object obj19 = (nint)0 & (nint)0x200;
					if (obj19 != null)
					{
						nint num27 = (nint)typeof(NGUITools);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ S1_v139 (Il2CppClass<NGUITools>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (!NGUITools.GetActive((GameObject)go2))
					{
						object obj20 = obj16 + 1;
						obj16 = obj20;
						continue;
					}
					object obj21 = obj14 + 16;
					object obj22 = obj16 << 2;
					object mListener = obj21 + obj22;
					nint num28 = (nint)typeof(NGUITools);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ S0_v333 (Il2CppClass<NGUITools>)+BA]");
					object obj23 = (nint)0 & (nint)0x200;
					if (obj23 != null)
					{
						nint num29 = (nint)typeof(NGUITools);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v537 @ S0_v339 (Il2CppClass<NGUITools>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					NGUITools.mListener = (AudioListener)mListener;
					break;
				}
			}
			nint num30 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ S0_v237 (Il2CppClass<NGUITools>)+BA]");
			object obj24 = (nint)0 & (nint)0x200;
			if (obj24 != null)
			{
				nint num31 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ S0_v310 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num32 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ S1_v85 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj25 = (nint)0 & (nint)0x200;
			if (obj25 != null)
			{
				nint num33 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ S1_v116 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (NGUITools.mListener != null)
			{
				Camera camera = Camera.current;
				nint num34 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ S0_v248 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj26 = (nint)0 & (nint)0x200;
				if (obj26 != null)
				{
					nint num35 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ S0_v307 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag5 = camera != null;
				bool flag6 = !flag5;
				Camera camera2 = camera;
				if (!flag6)
				{
					nint num36 = (nint)typeof(Type);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v565 @ S0_v284 (Il2CppClass<System.Type>)+BA]");
					object obj27 = (nint)0 & (nint)0x200;
					if (obj27 != null)
					{
						nint num37 = (nint)typeof(Type);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v595 @ S0_v304 (Il2CppClass<System.Type>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					obj3 = typeof(Camera);
					((IntPtr*)num5)->m_value = (void*)(nint)obj3;
					Type type2 = Type.internal_from_handle((IntPtr)num5);
					nint num38 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v637 @ S1_v106 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj28 = (nint)0 & (nint)0x200;
					if (obj28 != null)
					{
						nint num39 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v650 @ S1_v113 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					string text = ((UnityEngine.Object)(object)type2).ToString();
					Camera camera3;
					if (text != null)
					{
						if ((object)text.GetType() != typeof(Camera))
						{
							text = null;
						}
						camera3 = (Camera)(object)text;
					}
					else
					{
						camera3 = null;
					}
					camera2 = camera3;
				}
				nint num40 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v583 @ S0_v256 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj29 = (nint)0 & (nint)0x200;
				if (obj29 != null)
				{
					nint num41 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v607 @ S0_v278 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)(object)camera2).FindKernel((string)null) != 0)
				{
					string text2 = camera2.tag;
					AudioListener mListener2 = ((GameObject)(object)text2).AddComponent<AudioListener>();
					nint num42 = (nint)typeof(NGUITools);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ S0_v267 (Il2CppClass<NGUITools>)+BA]");
					object obj30 = (nint)0 & (nint)0x200;
					if (obj30 != null)
					{
						nint num43 = (nint)typeof(NGUITools);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v734 @ S0_v273 (Il2CppClass<NGUITools>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					NGUITools.mListener = mListener2;
				}
			}
			goto IL_0eb7;
		}
		return null;
		IL_0eb7:
		nint num44 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ S0_v71 (Il2CppClass<NGUITools>)+BA]");
		object obj31 = (nint)0 & (nint)0x200;
		if (obj31 != null)
		{
			nint num45 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ S0_v209 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num46 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ S1_v27 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj32 = (nint)0 & (nint)0x200;
		if (obj32 != null)
		{
			nint num47 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ S1_v68 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)NGUITools.mListener).FindKernel((string)null) != 0)
		{
			nint num48 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ S0_v82 (Il2CppClass<NGUITools>)+BA]");
			object obj33 = (nint)0 & (nint)0x200;
			if (obj33 != null)
			{
				nint num49 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v451 @ S0_v203 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (NGUITools.mListener.isActiveAndEnabled)
			{
				nint num50 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ S0_v93 (Il2CppClass<NGUITools>)+BA]");
				object obj34 = (nint)0 & (nint)0x200;
				if (obj34 != null)
				{
					nint num51 = (nint)typeof(NGUITools);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ S0_v197 (Il2CppClass<NGUITools>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string fileName = NGUITools.mListener.tag;
				byte[] array = NGUITools.Load(fileName);
				if (array != null)
				{
					nint num52 = (nint)typeof(NGUITools);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ S0_v105 (Il2CppClass<NGUITools>)+BA]");
					object obj35 = (nint)0 & (nint)0x200;
					if (obj35 != null)
					{
						nint num53 = (nint)typeof(NGUITools);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v613 @ S0_v192 (Il2CppClass<NGUITools>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					nint num54 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v624 @ S0_v113 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj36 = (nint)0 & (nint)0x200;
					if (obj36 != null)
					{
						nint num55 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v643 @ S0_v189 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (!UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)NGUITools.audioSource))
					{
						nint num56 = (nint)typeof(NGUITools);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v671 @ S0_v147 (Il2CppClass<NGUITools>)+BA]");
						object obj37 = (nint)0 & (nint)0x200;
						if (obj37 != null)
						{
							nint num57 = (nint)typeof(NGUITools);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v709 @ S0_v184 (Il2CppClass<NGUITools>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						AudioSource component = NGUITools.mListener.GetComponent<AudioSource>();
						nint num58 = (nint)typeof(NGUITools);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ S0_v156 (Il2CppClass<NGUITools>)+5C]");
						object obj38 = (nint)0 + (nint)4;
						obj38 = component;
						nint num59 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v753 @ S1_v54 (Il2CppClass<UnityEngine.Object>)+BA]");
						object obj39 = (nint)0 & (nint)0x200;
						if (obj39 != null)
						{
							nint num60 = (nint)typeof(UnityEngine.Object);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v767 @ S1_v65 (Il2CppClass<UnityEngine.Object>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						if (NGUITools.audioSource != null)
						{
							nint num61 = (nint)typeof(NGUITools);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v782 @ S0_v166 (Il2CppClass<NGUITools>)+BA]");
							object obj40 = (nint)0 & (nint)0x200;
							if (obj40 != null)
							{
								nint num62 = (nint)typeof(NGUITools);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v787 @ S0_v179 (Il2CppClass<NGUITools>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							string text3 = NGUITools.mListener.tag;
							AudioSource audioSource = ((GameObject)(object)text3).AddComponent<AudioSource>();
							nint num63 = (nint)typeof(NGUITools);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v804 @ S0_v176 (Il2CppClass<NGUITools>)+5C]");
							object obj41 = (nint)0 + (nint)4;
							obj41 = audioSource;
						}
					}
					nint num64 = (nint)typeof(NGUITools);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v692 @ S0_v122 (Il2CppClass<NGUITools>)+BA]");
					object obj42 = (nint)0 & (nint)0x200;
					if (obj42 != null)
					{
						nint num65 = (nint)typeof(NGUITools);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v721 @ S0_v141 (Il2CppClass<NGUITools>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					NGUITools.audioSource.rolloffMode = (AudioRolloffMode)50;
					NGUITools.audioSource.time = fill;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1178F");
					return (TweenFill)(object)NGUITools.audioSource;
				}
				return null;
			}
			return null;
		}
		return null;
	}

	public override void SetStartToCurrentValue()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		mCached = true;
		object obj = this + 100;
		UISprite component = GetComponent<UISprite>();
		obj = component;
	}

	public override void SetEndToCurrentValue()
	{
		float fov = ((TweenFOV)this).fov;
		from = fov;
	}

	public TweenFill()
	{
		float fov = ((TweenFOV)this).fov;
		to = fov;
	}
}
