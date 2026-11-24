using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Components.Utilities;
using UnityEngine;

public class UIFont : MonoBehaviour
{
	private Material mMat;

	private Rect mUVRect;

	private BMFont mFont;

	private UIAtlas mAtlas;

	private UIFont mReplacement;

	private List<BMSymbol> mSymbols;

	private Font mDynamicFont;

	private int mDynamicFontSize;

	private FontStyle mDynamicFontStyle;

	[NonSerialized]
	private UISpriteData mSprite;

	private int mPMA;

	private int mPacked;

	public unsafe BMFont bmFont
	{
		get
		{
			//IL_05f9: Expected I, but got Obj
			//IL_060f: Expected Obj, but got I
			//IL_0796: Expected I, but got Obj
			//IL_07ac: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_00ad: Expected I, but got Obj
			//IL_00c3: Expected Obj, but got I
			//IL_063a: Expected I, but got Obj
			//IL_0650: Expected Obj, but got I
			//IL_00ee: Expected I, but got Obj
			//IL_0332: Expected I, but got Obj
			//IL_0348: Expected Obj, but got I
			//IL_0365: Expected I, but got Obj
			//IL_013b: Expected I, but got Obj
			//IL_06db: Expected Obj, but got I
			//IL_06f8: Expected I, but got Obj
			//IL_070e: Expected Obj, but got I
			//IL_0188: Expected I, but got Obj
			//IL_019e: Expected Obj, but got I
			//IL_0381: Expected I, but got Obj
			//IL_03b1: Expected I, but got Obj
			//IL_05dc: Expected Obj, but got I4
			//IL_03ea: Expected I, but got Obj
			//IL_02a4: Expected I, but got Obj
			//IL_02ba: Expected Obj, but got I
			//IL_01c9: Expected I, but got Obj
			//IL_0437: Expected I, but got Obj
			//IL_044d: Expected Obj, but got I
			//IL_03d7: Expected I, but got Obj
			//IL_06a3: Expected Obj, but got I4
			//IL_06c0: Expected I4, but got Obj
			//IL_0216: Expected I, but got Obj
			//IL_022c: Expected Obj, but got I
			//IL_02e5: Expected I, but got Obj
			//IL_0553: Expected I, but got Obj
			//IL_0569: Expected Obj, but got I
			//IL_0478: Expected I, but got Obj
			//IL_0257: Expected I, but got Obj
			//IL_0761: Expected Obj, but got I4
			//IL_077e: Expected I4, but got Obj
			//IL_04c5: Expected I, but got Obj
			//IL_04db: Expected Obj, but got I
			//IL_0594: Expected I, but got Obj
			//IL_0506: Expected I, but got Obj
			nint num = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UICamera>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v145 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v5 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S1_v67 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)UICamera.mTooltip).FindKernel((string)(object)this) != 0)
			{
				nint num5 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v20 (Il2CppClass<UICamera>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num6 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v139 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				nint num7 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S1_v14 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num8 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S1_v63 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)(object)UICamera.mTooltip).FindKernel((string)null) != 0)
				{
					nint num9 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v97 (Il2CppClass<UICamera>)+BA]");
					object obj5 = (nint)0 & (nint)0x200;
					if (obj5 != null)
					{
						nint num10 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S0_v133 (Il2CppClass<UICamera>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (UICamera.onTooltip != null)
					{
						nint num11 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S0_v120 (Il2CppClass<UICamera>)+BA]");
						object obj6 = (nint)0 & (nint)0x200;
						if (obj6 != null)
						{
							nint num12 = (nint)typeof(UICamera);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ S0_v127 (Il2CppClass<UICamera>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A74");
					}
					nint num13 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ S0_v106 (Il2CppClass<UICamera>)+BA]");
					object obj7 = (nint)0 & (nint)0x200;
					if (obj7 != null)
					{
						nint num14 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ S0_v113 (Il2CppClass<UICamera>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					object obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
					bool released = default;
					((UICamera)(object)UICamera.mTooltip).ProcessTouch((byte)(int)"OnTooltip" != 0, released);
				}
				nint num15 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S0_v30 (Il2CppClass<UICamera>)+BA]");
				object obj9 = (nint)0 & (nint)0x200;
				bool flag = obj9 == null;
				nint num16 = (nint)typeof(UICamera);
				if (!flag)
				{
					nint num17 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S0_v90 (Il2CppClass<UICamera>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num16 = (nint)typeof(UICamera);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num16 = (nint)typeof(UICamera);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ L1_v10 (Il2CppClass<UICamera>)+5C]");
				object obj10 = (nint)0 + (nint)268;
				obj10 = this;
				UICamera.mTooltipTime = 0f;
				nint num18 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S1_v25 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj11 = (nint)0 & (nint)0x200;
				if (obj11 != null)
				{
					nint num19 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ S1_v45 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)(object)UICamera.mTooltip).FindKernel((string)null) != 0)
				{
					nint num20 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ S0_v48 (Il2CppClass<UICamera>)+BA]");
					object obj12 = (nint)0 & (nint)0x200;
					if (obj12 != null)
					{
						nint num21 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ S0_v84 (Il2CppClass<UICamera>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (UICamera.onTooltip != null)
					{
						nint num22 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ S0_v71 (Il2CppClass<UICamera>)+BA]");
						object obj13 = (nint)0 & (nint)0x200;
						if (obj13 != null)
						{
							nint num23 = (nint)typeof(UICamera);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ S0_v78 (Il2CppClass<UICamera>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A74");
					}
					nint num24 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ S0_v57 (Il2CppClass<UICamera>)+BA]");
					object obj14 = (nint)0 & (nint)0x200;
					if (obj14 != null)
					{
						nint num25 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ S0_v64 (Il2CppClass<UICamera>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					object obj8 = 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
					bool released2 = default;
					((UICamera)(object)UICamera.mTooltip).ProcessTouch((byte)(int)"OnTooltip" != 0, released2);
				}
				return (BMFont)1;
			}
			return null;
		}
		set
		{
			//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e5: Expected Obj, but got Unknown
			//IL_03fb: Expected I, but got Obj
			//IL_0411: Expected Obj, but got I
			//IL_066c: Invalid comparison between Obj and F4
			//IL_0069: Invalid comparison between Obj and F4
			//IL_0013: Expected I, but got Obj
			//IL_009e: Expected F4, but got Obj
			//IL_0436: Expected Obj, but got F4
			//IL_043f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0444: Expected Obj, but got Unknown
			//IL_045c: Expected F4, but got I
			//IL_046d: Invalid comparison between I and F4
			//IL_00c2: Invalid comparison between I and F4
			//IL_049a: Unknown result type (might be due to invalid IL or missing references)
			//IL_049f: Expected Obj, but got Unknown
			//IL_04b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_04b5: Expected VT, but got Unknown
			//IL_04c2: Expected F4, but got Obj
			//IL_04bd: Expected native int or pointer, but got VT
			//IL_04d1: Expected I4, but got F4
			//IL_04df: Expected I, but got Obj
			//IL_04f5: Expected Obj, but got I
			//IL_0694: Unknown result type (might be due to invalid IL or missing references)
			//IL_0699: Expected Obj, but got Unknown
			//IL_06a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_06a7: Expected Obj, but got Unknown
			//IL_06b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_06b5: Expected Obj, but got Unknown
			//IL_06c7: Expected Obj, but got I
			//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_02de: Expected Obj, but got Unknown
			//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e9: Expected Obj, but got Unknown
			//IL_0302: Expected F4, but got I
			//IL_0302: Expected F4, but got Obj
			//IL_030f: Expected F4, but got Obj
			//IL_030a: Expected native int or pointer, but got VT
			//IL_031c: Expected native int or pointer, but got VT
			//IL_0327: Unknown result type (might be due to invalid IL or missing references)
			//IL_032c: Expected Obj, but got Unknown
			//IL_0339: Expected Obj, but got F4
			//IL_0357: Expected I, but got Obj
			//IL_036d: Expected Obj, but got I
			//IL_00fd: Expected I, but got Obj
			//IL_014f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0154: Expected Obj, but got Unknown
			//IL_015d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0162: Expected Obj, but got Unknown
			//IL_0168: Unknown result type (might be due to invalid IL or missing references)
			//IL_016d: Expected Obj, but got Unknown
			//IL_017b: Expected I, but got Obj
			//IL_0191: Expected Obj, but got I
			//IL_0398: Expected I, but got Obj
			//IL_0523: Expected F4, but got Obj
			//IL_0523: Expected F4, but got Obj
			//IL_0523: Expected F4, but got Obj
			//IL_052f: Expected Obj, but got F4
			//IL_0538: Unknown result type (might be due to invalid IL or missing references)
			//IL_053d: Expected Obj, but got Unknown
			//IL_0546: Unknown result type (might be due to invalid IL or missing references)
			//IL_054b: Expected Obj, but got Unknown
			//IL_0551: Unknown result type (might be due to invalid IL or missing references)
			//IL_0556: Expected Obj, but got Unknown
			//IL_057f: Expected F4, but got I
			//IL_057f: Expected F4, but got I
			//IL_057f: Expected F4, but got I
			//IL_0596: Expected I, but got Obj
			//IL_05ac: Expected Obj, but got I
			//IL_05de: Expected F4, but got Obj
			//IL_05d9: Expected native int or pointer, but got VT
			//IL_05f8: Expected F4, but got Obj
			//IL_05f3: Expected native int or pointer, but got VT
			//IL_0605: Expected native int or pointer, but got VT
			//IL_062a: Expected F4, but got Obj
			//IL_0625: Expected native int or pointer, but got VT
			//IL_063f: Expected F4, but got I
			//IL_063a: Expected native int or pointer, but got VT
			//IL_01bc: Expected I, but got Obj
			//IL_0261: Expected Obj, but got I
			//IL_027a: Expected F4, but got Obj
			//IL_0275: Expected native int or pointer, but got VT
			//IL_0209: Expected I, but got Obj
			//IL_02a8: Expected F4, but got Obj
			//IL_02a3: Expected native int or pointer, but got VT
			//IL_02bd: Expected F4, but got I
			//IL_02b8: Expected native int or pointer, but got VT
			//IL_02ca: Expected Obj, but got VT
			object obj = default;
			MinMaxSliderAttribute minMaxSliderAttribute = (MinMaxSliderAttribute)(obj + 24);
			minMaxSliderAttribute = (MinMaxSliderAttribute)(object)value;
			nint num = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v13 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v92 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float num3;
			if (System.Runtime.CompilerServices.Unsafe.As<MinMaxSliderAttribute, UIntPtr>(ref minMaxSliderAttribute) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0f))
			{
				num3 = 0f;
			}
			else
			{
				num3 = ((System.Runtime.CompilerServices.Unsafe.As<MinMaxSliderAttribute, UIntPtr>(ref minMaxSliderAttribute) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)1f)) ? ((float)minMaxSliderAttribute) : 1f);
			}
			BMFont bMFont = (BMFont)num3;
			object obj3 = obj + 8;
			obj3 = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v19+4]");
			float num4 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v19+4]");
			if (0f < 0f)
			{
				num4 = 0f;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v19+4]");
				if (0f > 1f)
				{
					num4 = 1f;
				}
			}
			object obj4 = obj + 56;
			obj4 = value;
			Vector4 vector = (Vector4)(obj + 80);
			((Vector4*)(nint)vector)->x = (float)obj4;
			mDynamicFontSize = (int)vector.x;
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S1_v26 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S1_v101 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj6 = obj + 48;
			object obj7 = obj - -64;
			object obj8 = obj + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIFont)+1C]");
			if (((ComputeShader)0).FindKernel(null) != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				object obj10 = default;
				object obj9 = obj10 + 16;
				object obj11 = obj10 + 40;
				object obj12 = this + 52;
				nint num7 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ S0_v56 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj13 = (nint)0 & (nint)0x200;
				if (obj13 != null)
				{
					nint num8 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ S0_v88 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float num9 = Mathf.LerpUnclamped((float)obj9, (float)obj11, (float)obj12);
				bMFont = (BMFont)num9;
				object obj14 = obj10 + 16;
				object obj15 = obj10 + 40;
				object obj16 = this + 52;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ S1_v71+4]");
				nint num10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ S2_v19+4]");
				nint num11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ S3_v7+4]");
				float num12 = Mathf.LerpUnclamped(num10, num11, 0f);
				nint num13 = (nint)typeof(Vector2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ S0_v67 (Il2CppClass<UnityEngine.Vector2>)+BA]");
				object obj17 = (nint)0 & (nint)0x200;
				if (obj17 != null)
				{
					nint num14 = (nint)typeof(Vector2);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ S0_v84 (Il2CppClass<UnityEngine.Vector2>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj6 = value;
				((Vector4*)(nint)vector)->x = (float)obj6;
				Vector3 vector2 = vector;
				((Vector4*)(nint)vector)->x = (float)minMaxSliderAttribute;
				((Vector4*)(nint)vector)->z = minMaxSliderAttribute.max;
				Vector3 vector3 = ((Transform)(object)mAtlas).InverseTransformPoint((Vector3)vector);
				((Vector4*)(nint)vector)->x = (float)obj3;
				Vector4 vector4 = vector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v19+8]");
				((Vector4*)(nint)vector4)->z = 0f;
				Vector3 vector5 = (Vector2)vector;
				bMFont = (BMFont)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIFont)+1C]");
				GameObject gameObject = ((Component)0).gameObject;
				obj8 = value;
				((Vector4*)(nint)vector)->x = (float)obj8;
				Vector3 vector6 = vector;
				bool offset = UICamera.IsPartOfUI((GameObject)(object)mDynamicFont);
				((Vector4*)(nint)vector)->x = (float)obj7;
				Vector4 vector7 = vector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S1_v33+8]");
				((Vector4*)(nint)vector7)->z = 0f;
				Color color = NGUIText.ParseColor((string)vector, offset ? 1 : 0);
			}
			object obj18 = this + 52;
			object obj19 = this + 52;
			MinMaxSliderAttribute minMaxSliderAttribute2 = minMaxSliderAttribute;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ S2_v13+4]");
			minMaxSliderAttribute2._002Ector((float)obj18, 0f);
			((Vector4*)(nint)vector)->x = (float)minMaxSliderAttribute;
			((Vector4*)(nint)vector)->z = minMaxSliderAttribute.max;
			object obj20 = this + 12;
			obj20 = vector.x;
			_ = vector.z;
			UIColorPicker.current = (UIColorPicker)(object)this;
			nint num15 = (nint)typeof(EventDelegate);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ S1_v52 (Il2CppClass<EventDelegate>)+BA]");
			object obj21 = (nint)0 & (nint)0x200;
			if (obj21 != null)
			{
				nint num16 = (nint)typeof(EventDelegate);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ S1_v58 (Il2CppClass<EventDelegate>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Localization.dictionary = (Dictionary<string, string[]>)(object)mFont;
			UIColorPicker.current = null;
		}
	}

	public int texWidth
	{
		get
		{
			//IL_000e: Expected I, but got Obj
			//IL_0066: Expected I4, but got Obj
			//IL_0074: Expected I, but got Obj
			//IL_008a: Expected Obj, but got I
			UIFont uIFont = default;
			while (true)
			{
				nint num = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v9 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
				object obj;
				do
				{
					if (((ComputeShader)(object)uIFont.mReplacement).FindKernel((string)null) != 0)
					{
						uIFont = mReplacement;
						nint num2 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
						obj = (nint)0 & (nint)0x200;
						continue;
					}
					return (int)uIFont.mFont;
				}
				while (obj == null);
			}
		}
		set
		{
			//IL_000e: Expected I, but got Obj
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Expected Obj, but got Unknown
			//IL_0072: Expected Obj, but got I4
			//IL_0081: Expected I, but got Obj
			//IL_0097: Expected Obj, but got I
			UIFont uIFont = default;
			while (true)
			{
				nint num = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v11 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
				object obj;
				do
				{
					if (((ComputeShader)(object)uIFont.mReplacement).FindKernel((string)null) != 0)
					{
						uIFont = mReplacement;
						nint num2 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
						obj = (nint)0 & (nint)0x200;
						continue;
					}
					object obj2 = uIFont + 32;
					obj2 = value;
					return;
				}
				while (obj == null);
			}
		}
	}

	public int texHeight
	{
		get
		{
			//IL_000e: Expected I, but got Obj
			//IL_00b9: Expected I, but got Obj
			//IL_00cf: Expected Obj, but got I
			UIFont uIFont = default;
			while (true)
			{
				nint num = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v9 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
				object obj;
				do
				{
					if (((ComputeShader)(object)uIFont.mReplacement).FindKernel((string)null) != 0)
					{
						uIFont = mReplacement;
						nint num2 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
						obj = (nint)0 & (nint)0x200;
						continue;
					}
					if (uIFont.mFont != null)
					{
						BMFont bMFont = uIFont.mFont;
						return bMFont.mWidth;
					}
					return 1;
				}
				while (obj == null);
			}
		}
		set
		{
			//IL_000e: Expected I, but got Obj
			//IL_00ab: Expected I, but got Obj
			//IL_00c1: Expected Obj, but got I
			UIFont uIFont = default;
			while (true)
			{
				nint num = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v11 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
				object obj;
				do
				{
					if (((ComputeShader)(object)uIFont.mReplacement).FindKernel((string)null) != 0)
					{
						uIFont = mReplacement;
						nint num2 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
						obj = (nint)0 & (nint)0x200;
						continue;
					}
					if (uIFont.mFont != null)
					{
						BMFont bMFont = uIFont.mFont;
						bMFont.mWidth = value;
					}
					return;
				}
				while (obj == null);
			}
		}
	}

	public bool hasSymbols
	{
		get
		{
			//IL_000e: Expected I, but got Obj
			//IL_00b9: Expected I, but got Obj
			//IL_00cf: Expected Obj, but got I
			UIFont uIFont = default;
			while (true)
			{
				nint num = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v9 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
				object obj;
				do
				{
					if (((ComputeShader)(object)uIFont.mReplacement).FindKernel((string)null) != 0)
					{
						uIFont = mReplacement;
						nint num2 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
						obj = (nint)0 & (nint)0x200;
						continue;
					}
					if (uIFont.mFont != null)
					{
						BMFont bMFont = uIFont.mFont;
						return (byte)bMFont.mHeight != 0;
					}
					return true;
				}
				while (obj == null);
			}
		}
	}

	public List<BMSymbol> symbols
	{
		get
		{
			//IL_000e: Expected I, but got Obj
			//IL_00aa: Expected Obj, but got I4
			//IL_00c7: Expected I, but got Obj
			//IL_00dd: Expected Obj, but got I
			UIFont uIFont = default;
			while (true)
			{
				nint num = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v11 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
				object obj;
				do
				{
					if (((ComputeShader)(object)uIFont.mReplacement).FindKernel((string)null) != 0)
					{
						uIFont = mReplacement;
						nint num2 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
						obj = (nint)0 & (nint)0x200;
						continue;
					}
					if (uIFont.mSymbols != null)
					{
						List<BMSymbol> list = uIFont.mSymbols;
						bool flag = list._size != 0;
						return (List<BMSymbol>)flag;
					}
					return null;
				}
				while (obj == null);
			}
		}
	}

	public UIAtlas atlas
	{
		get
		{
			//IL_000e: Expected I, but got Obj
			//IL_0074: Expected I, but got Obj
			//IL_008a: Expected Obj, but got I
			UIFont uIFont = default;
			while (true)
			{
				nint num = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v9 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
				object obj;
				do
				{
					if (((ComputeShader)(object)uIFont.mReplacement).FindKernel((string)null) != 0)
					{
						uIFont = mReplacement;
						nint num2 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
						obj = (nint)0 & (nint)0x200;
						continue;
					}
					return (UIAtlas)(object)uIFont.mSymbols;
				}
				while (obj == null);
			}
		}
		set
		{
			//IL_000e: Expected I, but got Obj
			//IL_0098: Expected I4, but got Obj
			//IL_00ab: Expected I, but got Obj
			//IL_00c1: Expected Obj, but got I
			UIFont uIFont = default;
			while (true)
			{
				nint num = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v11 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
				object obj;
				do
				{
					if (((ComputeShader)(object)uIFont.mReplacement).FindKernel((string)null) != 0)
					{
						uIFont = mReplacement;
						nint num2 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
						obj = (nint)0 & (nint)0x200;
						continue;
					}
					if (uIFont.mFont != null)
					{
						BMFont bMFont = uIFont.mFont;
						bMFont.mHeight = (int)value;
					}
					return;
				}
				while (obj == null);
			}
		}
	}

	public Material material
	{
		get
		{
			//IL_000e: Expected I, but got Obj
			//IL_0074: Expected I, but got Obj
			//IL_008a: Expected Obj, but got I
			UIFont uIFont = default;
			while (true)
			{
				nint num = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v9 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
				object obj;
				do
				{
					if (((ComputeShader)(object)uIFont.mReplacement).FindKernel((string)null) != 0)
					{
						uIFont = mReplacement;
						nint num2 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
						obj = (nint)0 & (nint)0x200;
						continue;
					}
					return (Material)(object)uIFont.mAtlas;
				}
				while (obj == null);
			}
		}
		set
		{
			//IL_0246: Expected I, but got Obj
			//IL_025c: Expected Obj, but got I
			//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f0: Expected Obj, but got Unknown
			//IL_0074: Expected I, but got Obj
			//IL_008a: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_00b5: Expected I, but got Obj
			//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ff: Expected Obj, but got Unknown
			//IL_0108: Expected Obj, but got I4
			//IL_010e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0113: Expected Obj, but got Unknown
			//IL_0129: Expected I, but got Obj
			//IL_013f: Expected Obj, but got I
			//IL_016a: Expected I, but got Obj
			//IL_01af: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b4: Expected Obj, but got Unknown
			//IL_01cb: Expected Obj, but got I4
			//IL_0201: Expected VT, but got Obj
			//IL_0219: Unknown result type (might be due to invalid IL or missing references)
			//IL_021e: Expected Obj, but got Unknown
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v54 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UIFont uIFont = default;
			object obj2 = uIFont + 16;
			if (((ComputeShader)(object)mReplacement).FindKernel((string)null) != 0)
			{
				mReplacement.material = value;
				return;
			}
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S1_v49 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)mAtlas).FindKernel((string)(object)value) == 0)
			{
				return;
			}
			object obj4 = this - -64;
			obj4 = -1;
			object obj5 = this + 36;
			obj5 = value;
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S1_v23 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S1_v45 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)mAtlas).FindKernel((string)null) != 0)
			{
				object obj7 = this + 12;
				bool flag = mAtlas.premultipliedAlpha;
				obj7 = flag;
				UIFont uIFont2 = replacement;
				if ((object)uIFont2 != null)
				{
					uIFont.uvRect = (Rect)this;
					obj2 = uIFont;
					_ = ((UnityEngine.Object)uIFont).m_CachedPtr;
					object obj8 = this + 16;
					obj8 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v9+8]");
					_ = 0;
				}
			}
			UpdateUVRect();
		}
	}

	public bool premultipliedAlpha
	{
		get
		{
			//IL_000e: Expected I, but got Obj
			//IL_006a: Expected I, but got Obj
			//IL_0080: Expected Obj, but got I
			//IL_010f: Expected I, but got Obj
			//IL_0125: Expected Obj, but got I
			//IL_00ab: Expected I, but got Obj
			//IL_03fd: Expected I, but got Obj
			//IL_0413: Expected Obj, but got I
			//IL_0374: Expected I, but got Obj
			//IL_038a: Expected Obj, but got I
			//IL_0150: Expected I, but got Obj
			//IL_04c5: Expected I4, but got Obj
			//IL_0251: Expected I, but got Obj
			//IL_02b0: Expected I, but got Obj
			//IL_02c6: Expected Obj, but got I
			//IL_01c1: Expected I, but got Obj
			//IL_021a: Expected I4, but got Obj
			//IL_02f1: Expected I, but got Obj
			//IL_035d: Expected Obj, but got I4
			UIFont uIFont = default;
			while (true)
			{
				nint num = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v43 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
				object obj;
				do
				{
					if (((ComputeShader)(object)uIFont.mReplacement).FindKernel((string)null) != 0)
					{
						uIFont = mReplacement;
						nint num2 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
						obj = (nint)0 & (nint)0x200;
						continue;
					}
					nint num3 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v14 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj2 = (nint)0 & (nint)0x200;
					if (obj2 != null)
					{
						nint num4 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v56 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool result;
					if (((ComputeShader)(object)uIFont.mAtlas).FindKernel((string)null) != 0)
					{
						result = uIFont.mAtlas.premultipliedAlpha;
					}
					else
					{
						nint num5 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+BA]");
						object obj3 = (nint)0 & (nint)0x200;
						if (obj3 != null)
						{
							nint num6 = (nint)typeof(UnityEngine.Object);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S1_v38 (Il2CppClass<UnityEngine.Object>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						int num7 = ((ComputeShader)(object)uIFont.mMat).FindKernel((string)null);
						nint num8 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S1_v21 (Il2CppClass<UnityEngine.Object>)+BA]");
						object obj4 = (nint)0 & (nint)0x200;
						bool flag = obj4 == null;
						if (num7 == 0)
						{
							if (!flag)
							{
								nint num9 = (nint)typeof(UnityEngine.Object);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S0_v49 (Il2CppClass<UnityEngine.Object>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							int num10 = ((ComputeShader)(object)uIFont.mDynamicFont).FindKernel((string)null);
							bool flag2 = num10 == 0;
							result = false;
							if (!flag2)
							{
								string[] fontNames = uIFont.mDynamicFont.fontNames;
								result = (byte)(int)fontNames != 0;
							}
						}
						else
						{
							if (!flag)
							{
								nint num11 = (nint)typeof(UnityEngine.Object);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S0_v38 (Il2CppClass<UnityEngine.Object>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							if (((ComputeShader)(object)uIFont.mDynamicFont).FindKernel((string)null) != 0)
							{
								string[] fontNames2 = uIFont.mDynamicFont.fontNames;
								nint num12 = (nint)typeof(UnityEngine.Object);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S2_v13 (Il2CppClass<UnityEngine.Object>)+BA]");
								object obj5 = (nint)0 & (nint)0x200;
								if (obj5 != null)
								{
									nint num13 = (nint)typeof(UnityEngine.Object);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S2_v21 (Il2CppClass<UnityEngine.Object>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								if (((ComputeShader)(object)uIFont.mMat).FindKernel((string)(object)fontNames2) != 0)
								{
									string[] fontNames3 = uIFont.mDynamicFont.fontNames;
									int renderQueue = ((Material)(object)fontNames3).renderQueue;
									Vector2 mainTextureOffset = ((Material)renderQueue).mainTextureOffset;
								}
							}
							result = (byte)(int)uIFont.mMat != 0;
						}
					}
					return result;
				}
				while (obj == null);
			}
		}
	}

	public bool premultipliedAlphaShader => packedFontShader;

	public bool packedFontShader
	{
		get
		{
			//IL_000e: Expected I, but got Obj
			//IL_006a: Expected I, but got Obj
			//IL_0080: Expected Obj, but got I
			//IL_0112: Unknown result type (might be due to invalid IL or missing references)
			//IL_0117: Expected Obj, but got Unknown
			//IL_00ab: Expected I, but got Obj
			//IL_034b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0350: Expected Obj, but got Unknown
			//IL_0104: Expected I4, but got Obj
			//IL_02d5: Expected I, but got Obj
			//IL_02eb: Expected Obj, but got I
			//IL_015a: Expected I, but got Obj
			//IL_0170: Expected Obj, but got I
			//IL_036d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0372: Expected Obj, but got Unknown
			//IL_037c: Expected Obj, but got I4
			//IL_019b: Expected I, but got Obj
			//IL_0405: Expected Obj, but got I4
			//IL_01e3: Expected Obj, but got I4
			//IL_01f5: Expected I, but got Obj
			//IL_020b: Expected Obj, but got I
			//IL_0236: Expected I, but got Obj
			//IL_027e: Expected Obj, but got I4
			UIFont uIFont = default;
			while (true)
			{
				nint num = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v43 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
				object obj;
				do
				{
					if (((ComputeShader)(object)uIFont.mReplacement).FindKernel((string)null) != 0)
					{
						uIFont = mReplacement;
						nint num2 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
						obj = (nint)0 & (nint)0x200;
						continue;
					}
					nint num3 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj2 = (nint)0 & (nint)0x200;
					if (obj2 != null)
					{
						nint num4 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S1_v39 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (((ComputeShader)(object)uIFont.mAtlas).FindKernel((string)null) != 0)
					{
						List<UISpriteData> spriteList = uIFont.mAtlas.spriteList;
						return (byte)(int)spriteList != 0;
					}
					object obj3 = uIFont - -64;
					if ((nint)obj3 == -1)
					{
						bool flag = uIFont.premultipliedAlpha;
						nint num5 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v27 (Il2CppClass<UnityEngine.Object>)+BA]");
						object obj4 = (nint)0 & (nint)0x200;
						if (obj4 != null)
						{
							nint num6 = (nint)typeof(UnityEngine.Object);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v33 (Il2CppClass<UnityEngine.Object>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						object obj5 = uIFont - -64;
						bool flag2;
						if (((ComputeShader)flag).FindKernel(null) != 0)
						{
							Texture mainTexture = ((Material)flag).mainTexture;
							nint num7 = (nint)typeof(UnityEngine.Object);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S2_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
							object obj6 = (nint)0 & (nint)0x200;
							if (obj6 != null)
							{
								nint num8 = (nint)typeof(UnityEngine.Object);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S2_v23 (Il2CppClass<UnityEngine.Object>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							if (((ComputeShader)(object)mainTexture).FindKernel((string)null) != 0)
							{
								Texture mainTexture2 = ((Material)flag).mainTexture;
								UnityEngine.Object obj7 = UnityEngine.Object.Instantiate((UnityEngine.Object)mainTexture2);
								flag2 = ((string)(object)obj7).EndsWith("Premultiplied");
							}
							else
							{
								flag2 = false;
							}
						}
						else
						{
							flag2 = false;
						}
						obj5 = flag2;
					}
					object obj8 = uIFont - -64;
					return (nint)obj8 == 1;
				}
				while (obj == null);
			}
		}
	}

	public Texture2D texture
	{
		get
		{
			//IL_000e: Expected I, but got Obj
			//IL_006a: Expected I, but got Obj
			//IL_0080: Expected Obj, but got I
			//IL_00ab: Expected I, but got Obj
			//IL_0348: Expected Obj, but got I4
			//IL_02bf: Expected I, but got Obj
			//IL_02d5: Expected Obj, but got I
			//IL_013c: Expected I, but got Obj
			//IL_0152: Expected Obj, but got I
			//IL_0357: Expected Obj, but got I4
			//IL_017d: Expected I, but got Obj
			//IL_01c5: Expected Obj, but got I4
			//IL_01d7: Expected I, but got Obj
			//IL_01ed: Expected Obj, but got I
			//IL_0218: Expected I, but got Obj
			//IL_0260: Expected Obj, but got I4
			UIFont uIFont = default;
			while (true)
			{
				nint num = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v39 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
				object obj;
				do
				{
					if (((ComputeShader)(object)uIFont.mReplacement).FindKernel((string)null) != 0)
					{
						uIFont = mReplacement;
						nint num2 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
						obj = (nint)0 & (nint)0x200;
						continue;
					}
					nint num3 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj2 = (nint)0 & (nint)0x200;
					if (obj2 != null)
					{
						nint num4 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S1_v35 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (((ComputeShader)(object)uIFont.mAtlas).FindKernel((string)null) != 0)
					{
						return null;
					}
					if (uIFont.mPacked == -1)
					{
						bool flag = uIFont.premultipliedAlpha;
						nint num5 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v25 (Il2CppClass<UnityEngine.Object>)+BA]");
						object obj3 = (nint)0 & (nint)0x200;
						if (obj3 != null)
						{
							nint num6 = (nint)typeof(UnityEngine.Object);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v30 (Il2CppClass<UnityEngine.Object>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						int num9;
						if (((ComputeShader)flag).FindKernel(null) != 0)
						{
							Texture mainTexture = ((Material)flag).mainTexture;
							nint num7 = (nint)typeof(UnityEngine.Object);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S2_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
							object obj4 = (nint)0 & (nint)0x200;
							if (obj4 != null)
							{
								nint num8 = (nint)typeof(UnityEngine.Object);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S2_v23 (Il2CppClass<UnityEngine.Object>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							if (((ComputeShader)(object)mainTexture).FindKernel((string)null) != 0)
							{
								Texture mainTexture2 = ((Material)flag).mainTexture;
								UnityEngine.Object obj5 = UnityEngine.Object.Instantiate((UnityEngine.Object)mainTexture2);
								bool flag2 = ((string)(object)obj5).EndsWith("Packed");
								num9 = (flag2 ? 1 : 0);
							}
							else
							{
								num9 = 0;
							}
						}
						else
						{
							num9 = 0;
						}
						uIFont.mPacked = num9;
					}
					bool flag3 = uIFont.mPacked == 1;
					return (Texture2D)flag3;
				}
				while (obj == null);
			}
		}
	}

	public Rect uvRect
	{
		get
		{
			//IL_000e: Expected I, but got Obj
			//IL_01b5: Expected Obj, but got I
			//IL_0070: Expected I, but got Obj
			//IL_0086: Expected Obj, but got I
			//IL_0182: Expected Obj, but got F4
			//IL_005d: Expected VT, but got I
			//IL_00b1: Expected I, but got Obj
			//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fe: Expected Obj, but got Unknown
			//IL_0107: Expected Obj, but got I4
			//IL_0110: Unknown result type (might be due to invalid IL or missing references)
			//IL_0115: Expected Obj, but got Unknown
			//IL_0123: Expected Obj, but got VT
			//IL_013b: Expected I, but got Obj
			//IL_0151: Expected Obj, but got I
			Rect rect = default;
			while (true)
			{
				nint num = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v25 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
				object obj;
				do
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v21 (UnityEngine.Rect)+28]");
					if (((ComputeShader)0).FindKernel(null) != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (UnityEngine.Rect)+28]");
						rect = (Rect)0;
						nint num2 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
						obj = (nint)0 & (nint)0x200;
						continue;
					}
					nint num3 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj2 = (nint)0 & (nint)0x200;
					if (obj2 != null)
					{
						nint num4 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S1_v21 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (((ComputeShader)rect.m_Height).FindKernel((string)(object)this) != 0)
					{
						object obj3 = rect - -64;
						obj3 = -1;
						object obj4 = rect + 12;
						obj4 = this;
						((UIFont)rect).UpdateUVRect();
					}
					return rect;
				}
				while (obj == null);
			}
		}
		set
		{
			//IL_000e: Expected I, but got Obj
			//IL_0211: Expected Obj, but got I
			//IL_0070: Expected I, but got Obj
			//IL_0086: Expected Obj, but got I
			//IL_01dd: Expected Obj, but got I
			//IL_005d: Expected VT, but got I
			//IL_0150: Expected Obj, but got I4
			//IL_0164: Expected Obj, but got F4
			//IL_0175: Expected I, but got F4
			//IL_0180: Expected Obj, but got F4
			//IL_00b1: Expected I, but got Obj
			//IL_00f9: Expected Obj, but got VT
			//IL_0193: Expected I, but got Obj
			//IL_01a9: Expected Obj, but got I
			//IL_0123: Unknown result type (might be due to invalid IL or missing references)
			//IL_0128: Expected Obj, but got Unknown
			Rect rect = default;
			while (true)
			{
				nint num = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v25 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
				object obj;
				do
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v39 (UnityEngine.Rect)+28]");
					if (((ComputeShader)0).FindKernel(null) != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ L1_v1 (UnityEngine.Rect)+28]");
						rect = (Rect)0;
						nint num2 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
						obj = (nint)0 & (nint)0x200;
						continue;
					}
					nint num3 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v14 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj2 = (nint)0 & (nint)0x200;
					if (obj2 != null)
					{
						nint num4 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v34 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v39 (UnityEngine.Rect)+24]");
					UIFont uIFont2;
					if (((ComputeShader)0).FindKernel(null) != 0)
					{
						UIFont uIFont = ((UIFont)rect).replacement;
						if ((object)uIFont != null)
						{
							object obj3 = rect + 16;
							uIFont2 = (UIFont)obj3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S1_v21+8]");
							((UnityEngine.Object)this).m_CachedPtr = (IntPtr)0;
							return;
						}
					}
					uIFont2 = (UIFont)0;
					((UnityEngine.Object)this).m_CachedPtr = (IntPtr)0;
					uIFont2 = (UIFont)0f;
					_ = 0f;
					((UnityEngine.Object)this).m_CachedPtr = (IntPtr)1f;
					mMat = (Material)1f;
					return;
				}
				while (obj == null);
			}
		}
	}

	public unsafe string spriteName
	{
		get
		{
			//IL_000e: Expected I, but got Obj
			//IL_0077: Expected I, but got Obj
			//IL_008d: Expected Obj, but got I
			//IL_01ce: Expected Obj, but got I4
			//IL_00b8: Expected I, but got Obj
			//IL_0100: Expected Obj, but got I4
			//IL_018c: Expected I, but got Obj
			//IL_01a2: Expected Obj, but got I
			//IL_015b: Expected Obj, but got I4
			UIFont uIFont = default;
			while (true)
			{
				nint num = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v16 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
				object obj;
				do
				{
					if (((ComputeShader)(object)uIFont.mReplacement).FindKernel((string)null) != 0)
					{
						uIFont = mReplacement;
						nint num2 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
						obj = (nint)0 & (nint)0x200;
						continue;
					}
					bool flag = uIFont.premultipliedAlpha;
					nint num3 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v14 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj2 = (nint)0 & (nint)0x200;
					if (obj2 != null)
					{
						nint num4 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v35 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (((ComputeShader)flag).FindKernel(null) != 0)
					{
						int renderQueue = ((Material)flag).renderQueue;
						if (renderQueue != 0)
						{
							if (((int*)renderQueue)->m_value == (nint)typeof(Texture2D))
							{
								return (string)renderQueue;
							}
							return null;
						}
						return null;
					}
					return null;
				}
				while (obj == null);
			}
		}
		set
		{
			//IL_0188: Expected I, but got Obj
			//IL_019e: Expected Obj, but got I
			//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ca: Expected Obj, but got Unknown
			//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d8: Expected VT, but got Unknown
			//IL_0013: Expected I, but got Obj
			//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bd: Expected Obj, but got Unknown
			//IL_00df: Expected F4, but got Obj
			//IL_00da: Expected native int or pointer, but got VT
			//IL_00f4: Expected F4, but got I
			//IL_00ef: Expected native int or pointer, but got VT
			//IL_011b: Expected VT, but got Obj
			//IL_0158: Unknown result type (might be due to invalid IL or missing references)
			//IL_015d: Expected Obj, but got Unknown
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v42 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj2 = default;
			string text = (string)(obj2 + 32);
			Rect rect = (Rect)(obj2 + 16);
			if (((ComputeShader)(object)mReplacement).FindKernel((string)null) != 0)
			{
				text = value;
				text.m_stringLength = value.m_stringLength;
				mReplacement.spriteName = text;
				return;
			}
			UIFont uIFont = replacement;
			if ((object)uIFont == null)
			{
				object obj3 = this + 16;
				obj2 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S1_v16+8]");
				_ = 0;
				((Rect*)(nint)rect)->m_XMin = (float)obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				((Rect*)(nint)rect)->m_Width = 0f;
				text = value;
				text.m_stringLength = value.m_stringLength;
				if (rect == (Rect)text)
				{
					text = value;
					text.m_stringLength = value.m_stringLength;
					object obj4 = this + 16;
					obj4 = text;
					_ = text.m_stringLength;
					UpdateUVRect();
				}
			}
		}
	}

	public bool isValid
	{
		get
		{
			//IL_000e: Expected I, but got Obj
			//IL_0073: Expected I4, but got Obj
			//IL_0081: Expected I, but got Obj
			//IL_0097: Expected Obj, but got I
			UIFont uIFont = default;
			while (true)
			{
				nint num = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v9 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
				object obj;
				do
				{
					if (((ComputeShader)(object)uIFont.mReplacement).FindKernel((string)null) != 0)
					{
						uIFont = mReplacement;
						nint num2 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
						obj = (nint)0 & (nint)0x200;
						continue;
					}
					BMFont bMFont = uIFont.mFont;
					return (byte)(int)bMFont.mSpriteName != 0;
				}
				while (obj == null);
			}
		}
	}

	public int size
	{
		get
		{
			//IL_0087: Expected I, but got Obj
			//IL_009d: Expected Obj, but got I
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
			if (((ComputeShader)(object)mDynamicFont).FindKernel((string)null) != 0)
			{
				return 1;
			}
			return mFont.charSize;
		}
		set
		{
			//IL_000e: Expected I, but got Obj
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected Obj, but got Unknown
			//IL_00b7: Expected Obj, but got I4
			//IL_00d4: Expected I, but got Obj
			//IL_00ea: Expected Obj, but got I
			UIFont uIFont = default;
			while (true)
			{
				nint num = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v14 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
				object obj;
				do
				{
					if (((ComputeShader)(object)uIFont.mReplacement).FindKernel((string)null) != 0)
					{
						uIFont = mReplacement;
						nint num2 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
						obj = (nint)0 & (nint)0x200;
						continue;
					}
					BMFont bMFont = uIFont.mFont;
					if (bMFont.mSpriteName.get_Chars(value) != '\0')
					{
						object obj2 = uIFont.mFont + 24;
						obj2 = value;
						uIFont.UpdateUVRect();
					}
					return;
				}
				while (obj == null);
			}
		}
	}

	public int defaultSize
	{
		get
		{
			//IL_000a: Expected I4, but got Obj
			return (int)sprite;
		}
		set
		{
			//IL_000a: Expected Obj, but got I4
			replacement = (UIFont)value;
		}
	}

	public UISpriteData sprite
	{
		get
		{
			//IL_000e: Expected I, but got Obj
			//IL_00c5: Expected Obj, but got I4
			//IL_00d8: Expected I, but got Obj
			//IL_00ee: Expected Obj, but got I
			//IL_00b3: Expected Obj, but got I4
			UIFont uIFont = default;
			while (true)
			{
				nint num = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
				object obj;
				do
				{
					if (((ComputeShader)(object)uIFont.mReplacement).FindKernel((string)null) != 0)
					{
						uIFont = mReplacement;
						nint num2 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
						obj = (nint)0 & (nint)0x200;
						continue;
					}
					Font font = uIFont.dynamicFont;
					if ((object)font == null && uIFont.mFont != null)
					{
						BMFont bMFont = uIFont.mFont;
						return (UISpriteData)bMFont.mSize;
					}
					return (UISpriteData)uIFont.mDynamicFontSize;
				}
				while (obj == null);
			}
		}
	}

	public UIFont replacement
	{
		get
		{
			//IL_000e: Expected I, but got Obj
			//IL_0097: Expected I, but got Obj
			//IL_00ad: Expected Obj, but got I
			//IL_02b1: Expected I, but got Obj
			//IL_02c7: Expected Obj, but got I
			//IL_00d8: Expected I, but got Obj
			//IL_0183: Unknown result type (might be due to invalid IL or missing references)
			//IL_0188: Expected Obj, but got Unknown
			//IL_0244: Unknown result type (might be due to invalid IL or missing references)
			//IL_0249: Expected Obj, but got Unknown
			//IL_0252: Expected Obj, but got I4
			//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f3: Expected Obj, but got Unknown
			UIFont uIFont = default;
			while (true)
			{
				nint num = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v39 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
				object obj;
				do
				{
					if (((ComputeShader)(object)uIFont.mReplacement).FindKernel((string)null) != 0)
					{
						uIFont = mReplacement;
						nint num2 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
						obj = (nint)0 & (nint)0x200;
						continue;
					}
					if (uIFont.mSprite == null)
					{
						nint num3 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v11 (Il2CppClass<UnityEngine.Object>)+BA]");
						object obj2 = (nint)0 & (nint)0x200;
						if (obj2 != null)
						{
							nint num4 = (nint)typeof(UnityEngine.Object);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S1_v35 (Il2CppClass<UnityEngine.Object>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						if (((ComputeShader)(object)uIFont.mAtlas).FindKernel((string)null) != 0)
						{
							BMFont bMFont = uIFont.mFont;
							string mSpriteName = bMFont.mSpriteName;
							if (bMFont.mSpriteName != null && mSpriteName.m_stringLength != 0)
							{
								object obj3 = uIFont + 60;
								BMFont bMFont2 = uIFont.mFont;
								string randomSprite = uIFont.mAtlas.GetRandomSprite(bMFont2.mSpriteName);
								obj3 = randomSprite;
								if (uIFont.mSprite == null)
								{
									object obj4 = uIFont + 60;
									UnityEngine.Object startsWith = UnityEngine.Object.Instantiate((UnityEngine.Object)uIFont);
									string randomSprite2 = uIFont.mAtlas.GetRandomSprite((string)(object)startsWith);
									obj4 = randomSprite2;
								}
								if (uIFont.mSprite != null)
								{
									uIFont._002Ector();
								}
								else
								{
									object obj5 = uIFont.mFont + 24;
									obj5 = 0;
								}
								List<BMSymbol> list = uIFont.mSymbols;
								int num5 = 0;
								while (num5 < list._size)
								{
									UIAtlas uIAtlas = uIFont.atlas;
									BMSymbol bMSymbol = ((List<BMSymbol>)(object)uIAtlas).get_Item(num5);
									bMSymbol.mIsValid = false;
									int num6 = num5 + 1;
									num5 = num6;
								}
							}
						}
					}
					return (UIFont)(object)uIFont.mSprite;
				}
				while (obj == null);
			}
		}
		set
		{
			//IL_000e: Expected I, but got Obj
			//IL_0069: Expected I4, but got Obj
			//IL_0078: Expected I, but got Obj
			//IL_008e: Expected Obj, but got I
			UIFont uIFont = default;
			while (true)
			{
				nint num = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
				object obj;
				do
				{
					if (((ComputeShader)(object)uIFont.mReplacement).FindKernel((string)null) != 0)
					{
						uIFont = mReplacement;
						nint num2 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
						obj = (nint)0 & (nint)0x200;
						continue;
					}
					uIFont.mDynamicFontSize = (int)value;
					return;
				}
				while (obj == null);
			}
		}
	}

	public bool isDynamic
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)mReplacement != 0;
		}
	}

	public Font dynamicFont
	{
		get
		{
			//IL_000e: Expected I, but got Obj
			//IL_006a: Expected I, but got Obj
			//IL_0080: Expected Obj, but got I
			//IL_0143: Expected Obj, but got I4
			//IL_00ab: Expected I, but got Obj
			//IL_00f8: Expected I, but got Obj
			//IL_010e: Expected Obj, but got I
			UIFont uIFont = default;
			while (true)
			{
				nint num = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v19 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
				object obj;
				do
				{
					if (((ComputeShader)(object)uIFont.mReplacement).FindKernel((string)null) != 0)
					{
						uIFont = mReplacement;
						nint num2 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
						obj = (nint)0 & (nint)0x200;
						continue;
					}
					nint num3 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj2 = (nint)0 & (nint)0x200;
					if (obj2 != null)
					{
						nint num4 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S1_v15 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					return (Font)((ComputeShader)(object)uIFont.mDynamicFont).FindKernel((string)null);
				}
				while (obj == null);
			}
		}
		set
		{
			//IL_0341: Expected I, but got Obj
			//IL_0357: Expected Obj, but got I
			//IL_04a4: Expected I, but got Obj
			//IL_04ba: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_00c9: Expected I, but got Obj
			//IL_00df: Expected Obj, but got I
			//IL_03f3: Expected I, but got Obj
			//IL_0409: Expected Obj, but got I
			//IL_010a: Expected I, but got Obj
			//IL_0157: Expected I, but got Obj
			//IL_016d: Expected Obj, but got I
			//IL_0241: Unknown result type (might be due to invalid IL or missing references)
			//IL_0246: Expected Obj, but got Unknown
			//IL_024f: Expected Obj, but got I4
			//IL_025d: Expected I, but got Obj
			//IL_0273: Expected Obj, but got I
			//IL_01f1: Expected I, but got Obj
			//IL_0438: Expected Obj, but got I
			//IL_0198: Expected I, but got Obj
			//IL_029e: Expected I, but got Obj
			//IL_02e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e8: Expected Obj, but got Unknown
			//IL_02f1: Expected Obj, but got I4
			//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_02fc: Expected Obj, but got Unknown
			//IL_0305: Expected Obj, but got I4
			//IL_030b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0310: Expected Obj, but got Unknown
			//IL_0319: Expected Obj, but got I4
			//IL_031f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0324: Expected Obj, but got Unknown
			//IL_032d: Expected Obj, but got I4
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v60 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Font font = default;
			bool flag = font != this;
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v5 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S1_v54 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text;
			if (flag)
			{
				font = null;
				text = null;
			}
			else
			{
				text = (string)(object)font;
			}
			if (((ComputeShader)(object)mReplacement).FindKernel(text) == 0)
			{
				return;
			}
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v17 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v56 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)null).FindKernel((string)null) != 0)
			{
				nint num7 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S1_v42 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num8 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S1_v48 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ L1_v1 (UnityEngine.Font)+28]");
				if ((UnityEngine.Object)0 != this)
				{
					((UIFont)null).dynamicFont = null;
				}
			}
			nint num9 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S1_v16 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num10 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S1_v37 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)mReplacement).FindKernel((string)null) != 0)
			{
				UpdateUVRect();
			}
			object obj6 = this + 40;
			obj6 = 0;
			nint num11 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S0_v31 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num12 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S0_v47 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)null).FindKernel((string)null) != 0)
			{
				object obj8 = this - -64;
				obj8 = -1;
				object obj9 = this + 12;
				obj9 = 0;
				object obj10 = this + 32;
				obj10 = 0;
				object obj11 = this + 48;
				obj11 = 0;
			}
			UpdateUVRect();
		}
	}

	public FontStyle dynamicFontStyle
	{
		get
		{
			//IL_000e: Expected I, but got Obj
			//IL_0066: Expected I4, but got Obj
			//IL_0074: Expected I, but got Obj
			//IL_008a: Expected Obj, but got I
			UIFont uIFont = default;
			while (true)
			{
				nint num = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v9 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
				object obj;
				do
				{
					if (((ComputeShader)(object)uIFont.mReplacement).FindKernel((string)null) != 0)
					{
						uIFont = mReplacement;
						nint num2 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
						obj = (nint)0 & (nint)0x200;
						continue;
					}
					return (FontStyle)uIFont.mDynamicFont;
				}
				while (obj == null);
			}
		}
		set
		{
			//IL_000e: Expected I, but got Obj
			//IL_006a: Expected I, but got Obj
			//IL_0080: Expected Obj, but got I
			//IL_0204: Expected Obj, but got I4
			//IL_00ab: Expected I, but got Obj
			//IL_00f8: Expected I, but got Obj
			//IL_010e: Expected Obj, but got I
			//IL_01ba: Expected I, but got Obj
			//IL_01d0: Expected Obj, but got I
			//IL_0190: Unknown result type (might be due to invalid IL or missing references)
			//IL_0195: Expected Obj, but got Unknown
			//IL_019d: Expected Obj, but got I4
			//IL_0139: Expected I, but got Obj
			UIFont uIFont = default;
			while (true)
			{
				nint num = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v35 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
				object obj;
				do
				{
					if (((ComputeShader)(object)uIFont.mReplacement).FindKernel((string)null) != 0)
					{
						uIFont = mReplacement;
						nint num2 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
						obj = (nint)0 & (nint)0x200;
						continue;
					}
					nint num3 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj2 = (nint)0 & (nint)0x200;
					if (obj2 != null)
					{
						nint num4 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S1_v31 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (((ComputeShader)(object)uIFont.mDynamicFont).FindKernel((string)value) == 0)
					{
						return;
					}
					nint num5 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S1_v17 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj3 = (nint)0 & (nint)0x200;
					if (obj3 != null)
					{
						nint num6 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S1_v27 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (((ComputeShader)(object)uIFont.mDynamicFont).FindKernel((string)null) != 0)
					{
						Rect rect = ((UIFont)null).uvRect;
					}
					object obj4 = uIFont + 48;
					obj4 = value;
					uIFont.UpdateUVRect();
					return;
				}
				while (obj == null);
			}
		}
	}

	private Texture dynamicTexture
	{
		get
		{
			//IL_000e: Expected I, but got Obj
			//IL_0066: Expected Obj, but got I4
			//IL_0074: Expected I, but got Obj
			//IL_008a: Expected Obj, but got I
			UIFont uIFont = default;
			while (true)
			{
				nint num = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v9 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
				object obj;
				do
				{
					if (((ComputeShader)(object)uIFont.mReplacement).FindKernel((string)null) != 0)
					{
						uIFont = mReplacement;
						nint num2 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
						obj = (nint)0 & (nint)0x200;
						continue;
					}
					return (Texture)uIFont.mDynamicFontStyle;
				}
				while (obj == null);
			}
		}
	}

	private void Trim()
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected Obj, but got Unknown
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		Color black = Color.black;
		object obj2 = default;
		object obj = obj2 + 16;
		obj = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj3 = this + 12;
		obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v10+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<EventDelegate> list = default;
		list._002Ector();
		object obj4 = this + 32;
		obj4 = list;
		CancelInvoke();
	}

	private bool References(UIFont font)
	{
		//IL_01d6: Expected I, but got Obj
		//IL_01ec: Expected Obj, but got I
		//IL_007b: Expected I, but got Obj
		//IL_0091: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0128: Expected I, but got Obj
		//IL_013e: Expected Obj, but got I
		//IL_00bc: Expected I, but got Obj
		//IL_0169: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v45 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (font != null)
		{
			return false;
		}
		Collider component = ((GameObject)(object)font).GetComponent<Collider>();
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v16 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v40 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)component).FindKernel((string)null) != 0)
		{
			return component.isTrigger;
		}
		Collider2D component2 = ((GameObject)(object)font).GetComponent<Collider2D>();
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v25 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v34 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)component2).FindKernel((string)null) != 0)
		{
			return component2.isActiveAndEnabled;
		}
		return false;
	}

	public static bool CheckIfRelated(UIFont a, UIFont b)
	{
		//IL_000e: Expected I, but got Obj
		//IL_005b: Expected I, but got Obj
		//IL_0071: Expected Obj, but got I
		//IL_00e9: Expected I, but got Obj
		//IL_00ff: Expected Obj, but got I
		//IL_009c: Expected I, but got Obj
		//IL_012a: Expected I, but got Obj
		//IL_0197: Expected I, but got Obj
		//IL_01ad: Expected Obj, but got I
		UIFont uIFont = default;
		UIFont uIFont2 = default;
		while (true)
		{
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v31 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
			while (true)
			{
				bool flag = b == null;
				bool result = false;
				if (flag)
				{
					nint num2 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v16 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj = (nint)0 & (nint)0x200;
					if (obj != null)
					{
						nint num3 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v27 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool flag2 = b == uIFont.mReplacement;
					result = true;
					if (flag2)
					{
						nint num4 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S1_v11 (Il2CppClass<UnityEngine.Object>)+BA]");
						object obj2 = (nint)0 & (nint)0x200;
						if (obj2 != null)
						{
							nint num5 = (nint)typeof(UnityEngine.Object);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S1_v16 (Il2CppClass<UnityEngine.Object>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						if (((ComputeShader)(object)uIFont2.mReplacement).FindKernel((string)null) != 0)
						{
							uIFont2 = uIFont.mReplacement;
							nint num6 = (nint)typeof(UnityEngine.Object);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v9 (Il2CppClass<UnityEngine.Object>)+BA]");
							object obj3 = (nint)0 & (nint)0x200;
							if (obj3 != null)
							{
								break;
							}
							continue;
						}
						result = false;
					}
				}
				return result;
			}
		}
	}

	public unsafe void MarkAsChanged()
	{
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected Obj, but got Unknown
		//IL_0265: Expected Obj, but got I4
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Expected Obj, but got Unknown
		//IL_0282: Expected Obj, but got I4
		//IL_02a5: Expected I, but got Obj
		//IL_02bb: Expected Obj, but got I
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Expected VT, but got Unknown
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected Obj, but got Unknown
		//IL_00d0: Expected F4, but got Obj
		//IL_00cb: Expected native int or pointer, but got VT
		//IL_00f3: Expected VT, but got I4
		//IL_0141: Expected Obj, but got I4
		//IL_016d: Expected I, but got Obj
		//IL_0183: Expected Obj, but got I
		//IL_0378: Unknown result type (might be due to invalid IL or missing references)
		//IL_037d: Expected Obj, but got Unknown
		//IL_020a: Expected Obj, but got I
		//IL_0249: Expected I4, but got Obj
		//IL_0249: Expected I4, but got Obj
		//IL_0249: Expected I4, but got Obj
		//IL_0249: Expected I4, but got Obj
		//IL_01ae: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 48;
		obj = 0;
		_ = 0;
		object obj3 = obj2 + 32;
		obj3 = 0;
		_ = 0;
		UIAtlas uIAtlas = mAtlas.replacement;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v11 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v62 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector2 vector = (Vector2)(obj2 - -64);
		object obj5 = obj2 + 16;
		if (((ComputeShader)(object)uIAtlas).FindKernel((string)null) == 0 || mSprite == null)
		{
			return;
		}
		object obj6 = this + 16;
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S1_v22+8]");
		_ = 0;
		string text = spriteName;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		string text2 = spriteName;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		((Vector2*)(nint)vector)->x = (float)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S1_v18+8]");
		_ = 0;
		Vector2 maxRect = default;
		Vector2 minArea = default;
		Vector2 vector2 = NGUIMath.ConstrainRect(vector, maxRect, minArea, (Vector2)1);
		obj = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		UISpriteData uISpriteData = mSprite;
		UISpriteData uISpriteData2 = mSprite;
		UISpriteData uISpriteData3 = mSprite;
		UISpriteData uISpriteData4 = mSprite;
		obj3 = uISpriteData4.x;
		_ = uISpriteData.y;
		_ = uISpriteData2.width;
		_ = uISpriteData3.height;
		nint num3 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ S2_v11 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num4 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S2_v16 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float width = (float)obj3 - (float)obj;
		GUILayoutOption gUILayoutOption = GUILayout.Width(width);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+4]");
		float num5 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
		float width2 = num5 - 0f;
		GUILayoutOption gUILayoutOption2 = GUILayout.Width(width2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		object obj8 = 0 + obj3;
		float width3 = (float)obj8 - (float)obj;
		GUILayoutOption gUILayoutOption3 = GUILayout.Width(width3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+C]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+4]");
		object obj9 = num6 + 0;
		float num7 = (float)obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
		float width4 = num7 - 0f;
		GUILayoutOption gUILayoutOption4 = GUILayout.Width(width4);
		((BMGlyph)(object)mFont).Trim((int)gUILayoutOption, (int)gUILayoutOption2, (int)gUILayoutOption3, (int)gUILayoutOption4);
	}

	public void UpdateUVRect()
	{
		//IL_02ba: Expected I, but got Obj
		//IL_02d0: Expected Obj, but got I
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected Obj, but got Unknown
		//IL_0076: Expected Obj, but got I4
		//IL_0084: Expected I, but got Obj
		//IL_009a: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_02ff: Expected Obj, but got I4
		//IL_00c5: Expected I, but got Obj
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected Obj, but got Unknown
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Expected Obj, but got Unknown
		//IL_0176: Expected I, but got Obj
		//IL_018c: Expected Obj, but got I
		//IL_01b7: Expected I, but got Obj
		//IL_0208: Expected Obj, but got I
		//IL_0245: Expected Obj, but got I
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v45 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)mReplacement).FindKernel((string)null) != 0)
		{
			mReplacement.UpdateUVRect();
		}
		object obj2 = this + 60;
		obj2 = 0;
		nint num3 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v12 (Il2CppClass<NGUITools>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v53 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string typeName = NGUITools.GetTypeName<T>();
		object obj4 = 0;
		while ((nint)obj4 < (int)typeName.m_firstChar)
		{
			object obj5 = typeName + 16;
			object obj6 = obj4 << 2;
			object obj7 = obj5 + obj6;
			Behaviour behaviour = (Behaviour)obj7;
			if (((Behaviour)obj7).isActiveAndEnabled)
			{
				string fileName = ((Component)obj7).tag;
				nint num5 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S1_v31 (Il2CppClass<NGUITools>)+BA]");
				object obj8 = (nint)0 & (nint)0x200;
				if (obj8 != null)
				{
					nint num6 = (nint)typeof(NGUITools);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S1_v40 (Il2CppClass<NGUITools>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				byte[] array = NGUITools.Load(fileName);
				if (array != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v39 (UnityEngine.Behaviour)+128]");
					if (UsesSprite((string)0))
					{
						((UILabel)obj7).trueTypeFont = null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v39 (UnityEngine.Behaviour)+128]");
						((UILabel)obj7).trueTypeFont = (Font)0;
					}
				}
			}
			object obj9 = obj4 + 1;
			obj4 = obj9;
		}
		UIAtlas uIAtlas = atlas;
		int num7 = 0;
		while (num7 < (nint)uIAtlas.material)
		{
			UIAtlas uIAtlas2 = atlas;
			BMSymbol bMSymbol = ((List<BMSymbol>)(object)uIAtlas2).get_Item(num7);
			bMSymbol.mIsValid = false;
			int num8 = num7 + 1;
			num7 = num8;
		}
	}

	private BMSymbol GetSymbol(string sequence, bool createIfMissing)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected Obj, but got Unknown
		//IL_007f: Expected Obj, but got I4
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		//IL_00a0: Expected Obj, but got I4
		//IL_005c: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIFont)+EC]");
		bool flag = (nint)0 != 0;
		object obj = flag ^ sequence;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIFont)+ED]");
			bool flag2 = (nint)0 != 0;
			object obj2 = flag2 ^ createIfMissing;
			if (obj2 == null)
			{
				return null;
			}
		}
		mSymbols = (List<BMSymbol>)1;
		object obj3 = sequence & 1;
		return (BMSymbol)1;
	}

	public BMSymbol MatchSymbol(string text, int offset, int textLength)
	{
		//IL_039e: Expected I, but got Obj
		//IL_03b4: Expected Obj, but got I
		//IL_0536: Expected I, but got Obj
		//IL_054c: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0408: Expected I, but got Obj
		//IL_041e: Expected Obj, but got I
		//IL_00f5: Expected I, but got Obj
		//IL_03e3: Expected Obj, but got I4
		//IL_0470: Expected Obj, but got I4
		//IL_0482: Expected I, but got Obj
		//IL_0498: Expected Obj, but got I
		//IL_0084: Expected I, but got Obj
		//IL_01d7: Expected I, but got Obj
		//IL_0458: Expected Obj, but got I4
		//IL_04e5: Expected Obj, but got I4
		//IL_0166: Expected I, but got Obj
		//IL_02b9: Expected I, but got Obj
		//IL_04d2: Expected Obj, but got I4
		//IL_0306: Expected I, but got Obj
		//IL_031c: Expected Obj, but got I
		//IL_0248: Expected I, but got Obj
		//IL_0514: Expected Obj, but got I4
		//IL_0347: Expected I, but got Obj
		nint num = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UICamera>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v99 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UICamera.GetKeyDown.EndInvoke((IAsyncResult)this);
		nint num3 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v15 (Il2CppClass<UICamera>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		bool flag2 = obj2 == null;
		if (flag)
		{
			if (!flag2)
			{
				nint num4 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v95 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Ray currentRay = UICamera.currentRay;
			return (BMSymbol)1;
		}
		if (!flag2)
		{
			nint num5 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v84 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag3 = UICamera.GetKeyDown.EndInvoke((IAsyncResult)(object)text);
		nint num6 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S1_v8 (Il2CppClass<UICamera>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		bool flag4 = obj3 == null;
		if (flag3)
		{
			if (!flag4)
			{
				nint num7 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v80 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Ray currentRay2 = UICamera.currentRay;
			return (BMSymbol)1;
		}
		if (!flag4)
		{
			nint num8 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S0_v69 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag5 = UICamera.GetKeyDown.EndInvoke((IAsyncResult)offset);
		nint num9 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S1_v14 (Il2CppClass<UICamera>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		bool flag6 = obj4 == null;
		if (flag5)
		{
			if (!flag6)
			{
				nint num10 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S0_v65 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Ray currentRay3 = UICamera.currentRay;
			return (BMSymbol)(-1);
		}
		if (!flag6)
		{
			nint num11 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S0_v54 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (UICamera.GetKeyDown.EndInvoke((IAsyncResult)textLength))
		{
			nint num12 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S0_v44 (Il2CppClass<UICamera>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num13 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ S0_v50 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Ray currentRay4 = UICamera.currentRay;
			return (BMSymbol)(-1);
		}
		return null;
	}

	public void AddSymbol(string sequence, string spriteName)
	{
		//IL_05dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e2: Expected Obj, but got Unknown
		//IL_05eb: Expected Obj, but got I4
		//IL_05fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ff: Expected Obj, but got Unknown
		//IL_0608: Expected Obj, but got I4
		//IL_061c: Expected I, but got Obj
		//IL_0632: Expected Obj, but got I
		//IL_07c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c7: Expected Obj, but got Unknown
		//IL_07d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d5: Expected Obj, but got Unknown
		//IL_07de: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e3: Expected Obj, but got Unknown
		//IL_07ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f1: Expected Obj, but got Unknown
		//IL_07fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ff: Expected Obj, but got Unknown
		//IL_0808: Unknown result type (might be due to invalid IL or missing references)
		//IL_080d: Expected Obj, but got Unknown
		//IL_0816: Unknown result type (might be due to invalid IL or missing references)
		//IL_081b: Expected Obj, but got Unknown
		//IL_0824: Unknown result type (might be due to invalid IL or missing references)
		//IL_0829: Expected Obj, but got Unknown
		//IL_0832: Unknown result type (might be due to invalid IL or missing references)
		//IL_0837: Expected Obj, but got Unknown
		//IL_0849: Expected Obj, but got I
		//IL_00a3: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0684: Unknown result type (might be due to invalid IL or missing references)
		//IL_0689: Expected Obj, but got Unknown
		//IL_006c: Expected F4, but got I4
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected Obj, but got Unknown
		//IL_0335: Expected I, but got Obj
		//IL_034b: Expected Obj, but got I
		//IL_065f: Expected Obj, but got I
		//IL_06c2: Expected Obj, but got I
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected Obj, but got Unknown
		//IL_00de: Expected Obj, but got I4
		//IL_051d: Expected F4, but got I4
		//IL_0526: Unknown result type (might be due to invalid IL or missing references)
		//IL_052b: Expected Obj, but got Unknown
		//IL_0554: Expected I, but got Obj
		//IL_056a: Expected Obj, but got I
		//IL_0376: Expected I, but got Obj
		//IL_07ae: Expected Obj, but got I
		//IL_03c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cd: Expected Obj, but got Unknown
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03db: Expected Obj, but got Unknown
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e9: Expected Obj, but got Unknown
		//IL_03f7: Expected I, but got Obj
		//IL_040d: Expected Obj, but got I
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		//IL_031a: Expected Obj, but got Unknown
		//IL_0595: Expected I, but got Obj
		//IL_06f4: Expected F4, but got Obj
		//IL_06f4: Expected F4, but got Obj
		//IL_06f4: Expected F4, but got Obj
		//IL_0700: Expected Obj, but got F4
		//IL_0709: Unknown result type (might be due to invalid IL or missing references)
		//IL_070e: Expected Obj, but got Unknown
		//IL_0717: Unknown result type (might be due to invalid IL or missing references)
		//IL_071c: Expected Obj, but got Unknown
		//IL_0725: Unknown result type (might be due to invalid IL or missing references)
		//IL_072a: Expected Obj, but got Unknown
		//IL_0753: Expected F4, but got I
		//IL_0753: Expected F4, but got I
		//IL_0753: Expected F4, but got I
		//IL_077f: Expected F4, but got I
		//IL_0794: Expected VT, but got Obj
		//IL_0794: Expected Obj, but got I
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected Obj, but got Unknown
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected Obj, but got Unknown
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected Obj, but got Unknown
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Expected Obj, but got Unknown
		//IL_0276: Expected Obj, but got I
		//IL_02a0: Expected Obj, but got I
		//IL_049d: Expected Obj, but got I
		//IL_04c7: Expected Obj, but got I
		//IL_0438: Expected I, but got Obj
		//IL_0669: Unknown result type (might be due to invalid IL or missing references)
		//IL_066e: Expected Obj, but got Unknown
		//IL_04ed: Expected F4, but got I
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Expected Obj, but got Unknown
		//IL_02ec: Expected Obj, but got F4
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 160;
		obj = 0;
		_ = 0;
		object obj3 = obj2 + 144;
		obj3 = 0;
		_ = 0;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S1_v166 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		MinMaxSliderAttribute minMaxSliderAttribute = (MinMaxSliderAttribute)(obj2 + 176);
		object obj5 = obj2 + 128;
		object obj6 = obj2 + 112;
		object obj7 = obj2 + 96;
		object obj8 = obj2 + 80;
		object obj9 = obj2 - -64;
		object obj10 = obj2 + 48;
		object obj11 = obj2 + 32;
		object obj12 = obj2 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sequence @ L1 (System.String)+28]");
		if ((UnityEngine.Object)0 != null)
		{
			minMaxSliderAttribute = (MinMaxSliderAttribute)(object)spriteName;
			minMaxSliderAttribute.max = spriteName.m_stringLength;
			object obj13 = sequence + 12;
			obj13 = minMaxSliderAttribute;
			_ = minMaxSliderAttribute.max;
		}
		else
		{
			float num3 = float.MaxValue;
			object obj14 = 0;
			while (true)
			{
				object obj15 = sequence - -64;
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj15))
				{
					break;
				}
				float num4 = (float)obj14 - 1f;
				object obj16 = sequence - -64;
				float max = num4 / (float)obj16;
				object obj17 = 0;
				while (true)
				{
					object obj18 = obj17;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sequence @ L1 (System.String)+3C]");
					if ((nint)obj18 >= 0)
					{
						break;
					}
					float num5 = (float)obj17 - 1f;
					float num6 = num5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sequence @ L1 (System.String)+3C]");
					float num7 = num6 / 0f;
					minMaxSliderAttribute._002Ector(num7, max);
					obj = minMaxSliderAttribute;
					_ = minMaxSliderAttribute.max;
					obj5 = spriteName;
					_ = spriteName.m_stringLength;
					object obj19 = obj - obj5;
					obj = obj19;
					object obj20 = obj + 4;
					obj6 = spriteName;
					_ = spriteName.m_stringLength;
					object obj21 = obj20;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S1_v19+4]");
					object obj22 = obj21 - 0;
					obj20 = obj22;
					object obj23 = obj + 8;
					obj7 = spriteName;
					_ = spriteName.m_stringLength;
					object obj24 = obj23;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S1_v21+8]");
					object obj25 = obj24 - 0;
					obj23 = obj25;
					obj8 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
					_ = 0;
					obj9 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
					_ = 0;
					obj10 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
					_ = 0;
					obj11 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
					_ = 0;
					obj12 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
					_ = 0;
					obj2 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
					_ = 0;
					object obj26 = obj8 * obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S1_v27+4]");
					nint num8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S1_v29+4]");
					object obj27 = num8 * 0;
					object obj28 = obj26 + obj27;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S1_v31+8]");
					nint num9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					object obj29 = num9 * 0;
					float num10 = (float)obj28 + (float)obj29;
					if (num10 < num3)
					{
						object obj30 = sequence + 52;
						obj30 = num7;
						object obj31 = sequence + 52;
						num3 = num10;
					}
					object obj32 = obj17 + 1;
					obj17 = obj32;
				}
				object obj33 = obj14 + 1;
				obj14 = obj33;
			}
			nint num11 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ S1_v41 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj34 = (nint)0 & (nint)0x200;
			if (obj34 != null)
			{
				nint num12 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ S1_v99 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sequence @ L1 (System.String)+1C]");
			if (((ComputeShader)0).FindKernel(null) != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				object obj36 = default;
				object obj35 = obj36 + 16;
				object obj37 = obj36 + 40;
				object obj38 = sequence + 52;
				nint num13 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ S0_v53 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj39 = (nint)0 & (nint)0x200;
				if (obj39 != null)
				{
					nint num14 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ S0_v70 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float num15 = Mathf.LerpUnclamped((float)obj35, (float)obj37, (float)obj38);
				obj3 = num15;
				object obj40 = obj36 + 16;
				object obj41 = obj36 + 40;
				object obj42 = sequence + 52;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ S1_v77+4]");
				nint num16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ S2_v22+4]");
				nint num17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v477 @ S3_v7+4]");
				float num18 = Mathf.LerpUnclamped(num16, num17, 0f);
				_ = 0f;
				minMaxSliderAttribute = (MinMaxSliderAttribute)obj3;
				MinMaxSliderAttribute minMaxSliderAttribute2 = minMaxSliderAttribute;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
				minMaxSliderAttribute2.max = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sequence @ L1 (System.String)+24]");
				Vector3 vector = ((Transform)0).InverseTransformPoint((Vector3)minMaxSliderAttribute);
				obj3 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S1_v17+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sequence @ L1 (System.String)+1C]");
				GameObject gameObject = ((Component)0).gameObject;
				obj6 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sequence @ L1 (System.String)+30]");
				bool offset = UICamera.IsPartOfUI((GameObject)0);
				minMaxSliderAttribute = (MinMaxSliderAttribute)obj6;
				MinMaxSliderAttribute minMaxSliderAttribute3 = minMaxSliderAttribute;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S1_v19+8]");
				minMaxSliderAttribute3.max = 0f;
				Color color = NGUIText.ParseColor((string)(object)minMaxSliderAttribute, offset ? 1 : 0);
			}
			minMaxSliderAttribute = (MinMaxSliderAttribute)(object)spriteName;
			minMaxSliderAttribute.max = spriteName.m_stringLength;
			object obj43 = sequence + 12;
			obj43 = minMaxSliderAttribute;
			_ = minMaxSliderAttribute.max;
			UIColorPicker.current = (UIColorPicker)(object)sequence;
			nint num19 = (nint)typeof(EventDelegate);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ S1_v58 (Il2CppClass<EventDelegate>)+BA]");
			object obj44 = (nint)0 & (nint)0x200;
			if (obj44 != null)
			{
				nint num20 = (nint)typeof(EventDelegate);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ S1_v64 (Il2CppClass<EventDelegate>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sequence @ L1 (System.String)+20]");
			Localization.dictionary = (Dictionary<string, string[]>)0;
			UIColorPicker.current = null;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sequence @ L1 (System.String)+34]");
		UIFont uIFont = (UIFont)0;
	}

	public void RemoveSymbol(string sequence)
	{
		//IL_000e: Expected I, but got Obj
		//IL_0098: Expected I4, but got Obj
		//IL_00b5: Expected I, but got Obj
		//IL_00cb: Expected Obj, but got I
		UIFont uIFont = default;
		while (true)
		{
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
			object obj;
			do
			{
				if (((ComputeShader)(object)uIFont.mReplacement).FindKernel((string)null) != 0)
				{
					uIFont = mReplacement;
					nint num2 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
					obj = (nint)0 & (nint)0x200;
					continue;
				}
				if ((nint)uIFont.mDynamicFontStyle != (nint)sequence)
				{
					uIFont.mDynamicFontStyle = (FontStyle)sequence;
					uIFont.UpdateUVRect();
				}
				return;
			}
			while (obj == null);
		}
	}

	public void RenameSymbol(string before, string after)
	{
		//IL_000f: Expected VT, but got Obj
		//IL_0021: Expected Obj, but got I4
		int characterIndexAtPosition = ((UILabel)this).GetCharacterIndexAtPosition((Vector3)before, true);
		object obj = characterIndexAtPosition + 12;
		obj = after;
		UpdateUVRect();
	}

	public bool UsesSprite(string s)
	{
		//IL_027d: Expected I, but got Obj
		//IL_0293: Expected Obj, but got I
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00af: Expected I, but got Obj
		//IL_02e5: Expected I, but got Obj
		//IL_02fb: Expected Obj, but got I
		//IL_01da: Expected I, but got Obj
		//IL_0160: Expected Obj, but got I4
		//IL_0177: Expected Obj, but got I4
		//IL_018d: Expected Obj, but got I4
		//IL_01a4: Expected Obj, but got I4
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v49 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool result;
		if (this != null)
		{
			result = false;
		}
		else
		{
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v14 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v44 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if ((UnityEngine.Object)(object)s != null)
			{
				result = false;
			}
			else
			{
				Font font = dynamicFont;
				if ((object)font != null)
				{
					Font font2 = ((UIFont)(object)s).dynamicFont;
					if ((object)font2 != null)
					{
						FontStyle fontStyle = dynamicFontStyle;
						bool dynamic = ((Font)fontStyle).dynamic;
						object obj3 = (dynamic ? 1 : 0) + 16;
						FontStyle fontStyle2 = ((UIFont)(object)s).dynamicFontStyle;
						bool dynamic2 = ((Font)fontStyle2).dynamic;
						object obj4 = (dynamic2 ? 1 : 0) + 16;
						bool flag = (string)obj3 == (string)obj4;
						result = true;
						if (!flag)
						{
							goto IL_0318;
						}
					}
				}
				nint num5 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v24 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num6 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v36 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				result = this != (UnityEngine.Object)(object)s || CheckIfRelated(this, (UIFont)(object)s) || CheckIfRelated((UIFont)(object)s, this);
			}
		}
		goto IL_0318;
		IL_0318:
		return result;
	}

	public unsafe UIFont()
	{
		//IL_036c: Expected I, but got Obj
		//IL_0382: Expected Obj, but got I
		//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d9: Expected VT, but got Unknown
		//IL_03e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e7: Expected Obj, but got Unknown
		//IL_03f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f5: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_006f: Expected I, but got Obj
		//IL_0085: Expected Obj, but got I
		//IL_00b0: Expected I, but got Obj
		//IL_015c: Expected Obj, but got I4
		//IL_0179: Expected Obj, but got I4
		//IL_0198: Expected Obj, but got I4
		//IL_01b4: Expected Obj, but got I4
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Expected Obj, but got Unknown
		//IL_01e2: Expected Obj, but got I4
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected Obj, but got Unknown
		//IL_0206: Expected F4, but got Obj
		//IL_0201: Expected native int or pointer, but got VT
		//IL_021b: Expected F4, but got I
		//IL_0216: Expected native int or pointer, but got VT
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected Obj, but got Unknown
		//IL_0233: Expected Obj, but got F4
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Expected Obj, but got Unknown
		//IL_0283: Expected F4, but got Obj
		//IL_027e: Expected native int or pointer, but got VT
		//IL_0298: Expected F4, but got I
		//IL_0293: Expected native int or pointer, but got VT
		//IL_02ba: Expected F4, but got Obj
		//IL_02b5: Expected native int or pointer, but got VT
		//IL_02cf: Expected F4, but got I
		//IL_02ca: Expected native int or pointer, but got VT
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02da: Expected Obj, but got Unknown
		//IL_02e7: Expected Obj, but got F4
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v66 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = default;
		Rect rect = (Rect)(obj2 + 48);
		object obj3 = obj2 + 32;
		object obj4 = obj2 + 16;
		if (mAtlas != null)
		{
			return;
		}
		UIAtlas uIAtlas = mAtlas.replacement;
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v18 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v86 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)uIAtlas).FindKernel((string)null) != 0)
		{
			UISpriteData uISpriteData = mSprite;
			UISpriteData uISpriteData2 = mSprite;
			UISpriteData uISpriteData3 = mSprite;
			UISpriteData uISpriteData4 = mSprite;
			UISpriteData uISpriteData5 = mSprite;
			UISpriteData uISpriteData6 = mSprite;
			UISpriteData uISpriteData7 = mSprite;
			UISpriteData uISpriteData8 = mSprite;
			UISpriteData uISpriteData9 = mSprite;
			UISpriteData uISpriteData10 = mSprite;
			obj3 = 0;
			_ = 0;
			object obj6 = uISpriteData.x - uISpriteData2.paddingLeft;
			obj3 = obj6;
			object obj7 = uISpriteData3.y - uISpriteData4.paddingTop;
			object obj8 = uISpriteData6.paddingLeft + uISpriteData5.width;
			object obj9 = uISpriteData7.paddingRight + obj8;
			object obj10 = uISpriteData9.paddingTop + uISpriteData8.height;
			object obj11 = uISpriteData10.paddingBottom + obj10;
			((Rect*)(nint)rect)->m_XMin = (float)obj3;
			Rect rect2 = rect;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S1_v11+8]");
			((Rect*)(nint)rect2)->m_Width = 0f;
			object obj12 = this + 16;
			obj12 = rect.m_XMin;
			_ = rect.m_Width;
			object obj13 = this + 16;
			obj4 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ S1_v39+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			((Rect*)(nint)rect)->m_XMin = (float)obj4;
			Rect rect3 = rect;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S1_v13+8]");
			((Rect*)(nint)rect3)->m_Width = 0f;
			int width = default;
			int height = default;
			Rect rect4 = NGUIMath.MakePixelPerfect(rect, width, height);
			((Rect*)(nint)rect)->m_XMin = (float)obj2;
			Rect rect5 = rect;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((Rect*)(nint)rect5)->m_Width = 0f;
			object obj14 = this + 16;
			obj14 = rect.m_XMin;
			_ = rect.m_Width;
			UISpriteData uISpriteData11 = mSprite;
			int num5 = uISpriteData11.paddingRight | uISpriteData11.paddingLeft;
			int num6 = num5 | uISpriteData11.paddingTop;
			if ((num6 | uISpriteData11.paddingBottom) != 0)
			{
				MarkAsChanged();
			}
		}
	}
}
