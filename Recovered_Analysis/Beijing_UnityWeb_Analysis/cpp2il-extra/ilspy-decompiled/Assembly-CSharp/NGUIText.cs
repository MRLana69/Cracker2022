using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using AnimationOrTween;
using Cpp2ILInjected;
using Missions;
using SYBO.Components.Json;
using UnityEngine;
using UnityEngine.Bindings;

public static class NGUIText
{
	public enum Alignment
	{
		Automatic,
		Left,
		Center,
		Right,
		Justified
	}

	public enum SymbolStyle
	{
		None,
		Normal,
		Colored,
		NoOutline
	}

	public class GlyphInfo
	{
		public Vector2 v0;

		public Vector2 v1;

		public Vector2 u0;

		public Vector2 u1;

		public Vector2 u2;

		public Vector2 u3;

		public float advance;

		public int channel;

		public GlyphInfo()
		{
			//IL_0015: Expected Obj, but got I
			//IL_007e: Expected Obj, but got I4
			//IL_0050: Expected Obj, but got I
			//IL_0060: Expected Obj, but got I
			//IL_00b6: Expected Obj, but got I
			//IL_00c6: Expected Obj, but got I
			//IL_011b: Expected Obj, but got I
			//IL_0138: Expected Obj, but got I4
			//IL_0380: Expected Obj, but got I
			//IL_0389: Unknown result type (might be due to invalid IL or missing references)
			//IL_038e: Expected Obj, but got Unknown
			//IL_03d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d5: Expected Obj, but got Unknown
			//IL_01c4: Expected Obj, but got I
			//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d2: Expected Obj, but got Unknown
			//IL_0190: Expected Obj, but got I
			//IL_0199: Unknown result type (might be due to invalid IL or missing references)
			//IL_019e: Expected Obj, but got Unknown
			//IL_0257: Expected Obj, but got I
			//IL_02b7: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (NGUIText+GlyphInfo)+34]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (NGUIText+GlyphInfo)+34]");
			object obj3;
			object obj4;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (NGUIText+GlyphInfo)+34]");
				object obj2 = (nint)0 + (nint)16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6+C]");
				obj3 = 0;
				obj4 = obj2;
			}
			else
			{
				obj4 = this;
				obj3 = 1;
			}
			object obj5 = default;
			object obj23 = default;
			object obj20 = default;
			for (; obj5 != obj3; obj5 = obj23 + 1)
			{
				object obj6 = obj5 << 2;
				object obj7 = obj4 + obj6;
				object obj8 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v14+10]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v14+14]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v19+28]");
				if ((nint)0 == -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A98");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v19+24]");
				object obj11 = (nint)0 & (nint)0x10;
				bool flag = obj11 == null;
				object obj12 = (flag ? 1 : 0) ^ 1;
				if (obj12 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v19+2A]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v14+8]");
						object obj13 = (nint)0 & (nint)0x3FFF;
						object obj14 = obj13 + 80504;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v104 @ S2_v14 (should have been resolved before IL gen)");
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v14+8]");
						object obj15 = (nint)0 & (nint)0x7FFF;
						object obj16 = obj15 + 46824;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v111 @ S1_v33 (should have been resolved before IL gen)");
					}
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v19+28]");
				if ((nint)0 != -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v14+10]");
					bool flag2;
					if ((nint)0 != 0)
					{
						object obj17 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S0_v59+9C]");
						object obj18 = (nint)0 & (nint)0x100;
						flag2 = obj18 != null;
					}
					else
					{
						flag2 = false;
					}
					if (!flag2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (NGUIText+GlyphInfo)+C]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v19+2B]");
							object obj19 = (nint)0 & (nint)3;
							bool flag3 = (nint)obj19 == 2;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120B8");
							if (flag3)
							{
								if (obj20 != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B8");
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B9");
								}
							}
							else if (obj20 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
							}
							continue;
						}
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v14+8]");
				object obj21 = (nint)0 & (nint)0x3FFF;
				object obj22 = obj21 + 80504;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v129 @ S2_v6 (should have been resolved before IL gen)");
			}
		}
	}

	public static UIFont bitmapFont;

	public static Font dynamicFont;

	public static GlyphInfo glyph;

	public static int fontSize;

	public static float fontScale;

	public static float pixelDensity;

	public static FontStyle fontStyle;

	public static Alignment alignment;

	public static Color tint;

	public static int rectWidth;

	public static int rectHeight;

	public static int regionWidth;

	public static int regionHeight;

	public static int maxLines;

	public static bool gradient;

	public static Color gradientBottom;

	public static Color gradientTop;

	public static bool encoding;

	public static float spacingX;

	public static float spacingY;

	public static bool premultiply;

	public static SymbolStyle symbolStyle;

	public static int finalSize;

	public static float finalSpacingX;

	public static float finalLineHeight;

	public static float baseline;

	public static bool useSymbols;

	private static Color mInvisible;

	private static BetterList<Color> mColors;

	private static float mAlpha;

	private static CharacterInfo mTempChar;

	private static BetterList<float> mSizes;

	private static Color s_c0;

	private static Color s_c1;

	private const float sizeShrinkage = 0.75f;

	private static float[] mBoldOffset;

	public static void Update()
	{
		//IL_0030: Expected I, but got Obj
		//IL_0046: Expected Obj, but got I
		//IL_005c: Expected I, but got Obj
		//IL_0072: Expected Obj, but got I
		//IL_007b: Expected Obj, but got I4
		NGUIDebug.mRayDebug = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<string> list = default;
		list._002Ector();
		nint num = (nint)typeof(NGUIDebug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v12 (Il2CppClass<NGUIDebug>)+5C]");
		object obj = (nint)0 + (nint)4;
		obj = list;
		nint num2 = (nint)typeof(NGUIDebug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v16 (Il2CppClass<NGUIDebug>)+5C]");
		object obj2 = (nint)0 + (nint)8;
		obj2 = 0;
	}

	public static void Update(bool request)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}

	public static void Prepare(string text)
	{
		//IL_06c4: Expected I, but got Obj
		//IL_06da: Expected Obj, but got I
		//IL_0994: Expected I, but got Obj
		//IL_09aa: Expected Obj, but got I
		//IL_0af7: Expected I4, but got Obj
		//IL_0b49: Expected I, but got Obj
		//IL_0b5f: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_01e3: Expected I, but got Obj
		//IL_01f9: Expected Obj, but got I
		//IL_00ad: Expected I, but got Obj
		//IL_00fa: Expected I, but got Obj
		//IL_0110: Expected Obj, but got I
		//IL_0224: Expected I, but got Obj
		//IL_0722: Expected I, but got Obj
		//IL_0738: Expected Obj, but got I
		//IL_0763: Expected I, but got Obj
		//IL_0779: Expected Obj, but got I
		//IL_0271: Expected I, but got Obj
		//IL_0287: Expected Obj, but got I
		//IL_013b: Expected I, but got Obj
		//IL_0a0d: Expected I, but got Obj
		//IL_0a23: Expected Obj, but got I
		//IL_0188: Expected I, but got Obj
		//IL_0b93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b98: Expected I4, but got Unknown
		//IL_030d: Expected I, but got Obj
		//IL_02b2: Expected I, but got Obj
		//IL_035a: Expected I, but got Obj
		//IL_03a7: Expected I, but got Obj
		//IL_03bd: Expected Obj, but got I
		//IL_07ed: Expected I, but got Obj
		//IL_0803: Expected Obj, but got I
		//IL_04f2: Expected I, but got Obj
		//IL_0508: Expected Obj, but got I
		//IL_03e8: Expected I, but got Obj
		//IL_08dd: Expected I, but got Obj
		//IL_08f3: Expected Obj, but got I
		//IL_0435: Expected I, but got Obj
		//IL_044b: Expected Obj, but got I
		//IL_0468: Expected I, but got Obj
		//IL_0875: Expected I, but got Obj
		//IL_088b: Expected Obj, but got I
		//IL_08a8: Expected I, but got Obj
		//IL_0533: Expected I, but got Obj
		//IL_0840: Expected Obj, but got I
		//IL_0a56: Expected Obj, but got I
		//IL_0a6e: Expected I, but got Obj
		//IL_0a84: Expected Obj, but got I
		//IL_0a9c: Expected I, but got Obj
		//IL_0ab2: Expected Obj, but got I
		//IL_0580: Expected I, but got Obj
		//IL_0596: Expected Obj, but got I
		//IL_0484: Expected I, but got Obj
		//IL_04b4: Expected I, but got Obj
		//IL_093d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0942: Expected Obj, but got Unknown
		//IL_060e: Expected I, but got Obj
		//IL_063e: Expected I, but got Obj
		//IL_0677: Expected I, but got Obj
		//IL_05c1: Expected I, but got Obj
		//IL_04da: Expected I, but got Obj
		//IL_0664: Expected I, but got Obj
		nint num = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<NGUIText>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v198 (Il2CppClass<NGUIText>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num3 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v8 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v92 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float width = (float)fontSize / pixelDensity;
		GUILayoutOption gUILayoutOption = GUILayout.Width(width);
		finalSize = (int)gUILayoutOption;
		float num5 = spacingX * fontScale;
		finalSpacingX = num5;
		float num6 = (float)fontSize + spacingY;
		float num7 = num6 * fontScale;
		finalLineHeight = num7;
		nint num8 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v29 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num9 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v194 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag;
		if (((ComputeShader)(object)dynamicFont).FindKernel((string)null) == 0)
		{
			nint num10 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v179 (Il2CppClass<NGUIText>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num11 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S0_v188 (Il2CppClass<NGUIText>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num12 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S1_v83 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num13 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ S1_v88 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)bitmapFont).FindKernel((string)null) == 0)
			{
				flag = false;
				goto IL_0755;
			}
		}
		nint num14 = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S0_v149 (Il2CppClass<NGUIText>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num15 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S0_v172 (Il2CppClass<NGUIText>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(encoding ? 1u : 0u) == 0)
		{
			nint num16 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S0_v158 (Il2CppClass<NGUIText>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num17 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ S0_v166 (Il2CppClass<NGUIText>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			flag = symbolStyle != SymbolStyle.None;
		}
		else
		{
			flag = false;
		}
		goto IL_0755;
		IL_0867:
		nint num18 = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ S0_v67 (Il2CppClass<NGUIText>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		bool flag2 = obj8 == null;
		nint num19 = (nint)typeof(NGUIText);
		if (!flag2)
		{
			nint num20 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ S0_v80 (Il2CppClass<NGUIText>)+74]");
			bool flag3 = (nint)0 == 0;
			bool flag4 = !flag3;
			num19 = (nint)typeof(NGUIText);
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num19 = (nint)typeof(NGUIText);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ L0_v6 (Il2CppClass<NGUIText>)+5C]");
		object obj9 = (nint)0 + (nint)168;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11567");
		nint num21 = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ S1_v45 (Il2CppClass<NGUIText>)+5C]");
		object obj10 = (nint)0 + (nint)168;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11565");
		nint num22 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ S1_v54 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num23 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ S1_v63 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj13 = default;
		object obj12 = finalSize - obj13;
		object obj15 = default;
		object obj14 = obj12 + obj15;
		float num24 = (float)obj14 * 0.5f;
		float num25 = (float)obj13 + num24;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72EB");
		float num26 = default;
		baseline = num26;
		return;
		IL_0755:
		nint num27 = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ S0_v37 (Il2CppClass<NGUIText>)+BA]");
		object obj16 = (nint)0 & (nint)0x200;
		if (obj16 != null)
		{
			nint num28 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ S0_v141 (Il2CppClass<NGUIText>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag5 = flag;
		useSymbols = flag5;
		nint num29 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ S0_v48 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj17 = (nint)0 & (nint)0x200;
		if (obj17 != null)
		{
			nint num30 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ S0_v137 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num31 = ((ComputeShader)(object)dynamicFont).FindKernel((string)null);
		if ((num31 & text) == 0)
		{
			return;
		}
		nint num32 = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ S0_v57 (Il2CppClass<NGUIText>)+BA]");
		object obj18 = (nint)0 & (nint)0x200;
		if (obj18 != null)
		{
			nint num33 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ S0_v131 (Il2CppClass<NGUIText>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((UnityEngine.Bindings.NativeMethodAttribute)(object)dynamicFont)._002Ector(")_-", (byte)finalSize != 0, (byte)fontStyle != 0);
		nint num34 = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ S2_v23 (Il2CppClass<NGUIText>)+5C]");
		object obj19 = (nint)0 + (nint)168;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11588");
		object obj20 = default;
		if (obj20 != null)
		{
			nint num35 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ S0_v116 (Il2CppClass<NGUIText>)+BA]");
			object obj21 = (nint)0 & (nint)0x200;
			bool flag6 = obj21 == null;
			nint num36 = (nint)typeof(NGUIText);
			if (!flag6)
			{
				nint num37 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ S0_v125 (Il2CppClass<NGUIText>)+74]");
				bool flag7 = (nint)0 == 0;
				bool flag8 = !flag7;
				num36 = (nint)typeof(NGUIText);
				if (!flag8)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num36 = (nint)typeof(NGUIText);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ L0_v17 (Il2CppClass<NGUIText>)+5C]");
			object obj22 = (nint)0 + (nint)168;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11567");
			object obj23 = default;
			if (obj23 != null)
			{
				goto IL_0867;
			}
		}
		nint num38 = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ S0_v88 (Il2CppClass<NGUIText>)+BA]");
		object obj24 = (nint)0 & (nint)0x200;
		if (obj24 != null)
		{
			nint num39 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ S0_v109 (Il2CppClass<NGUIText>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((UnityEngine.Bindings.NativeMethodAttribute)(object)dynamicFont)._002Ector("A", (byte)finalSize != 0, (byte)fontStyle != 0);
		nint num40 = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ S2_v37 (Il2CppClass<NGUIText>)+5C]");
		object obj25 = (nint)0 + (nint)168;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11588");
		object obj26 = default;
		if (obj26 == null)
		{
			nint num41 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ S0_v97 (Il2CppClass<NGUIText>)+BA]");
			object obj27 = (nint)0 & (nint)0x200;
			if (obj27 != null)
			{
				nint num42 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ S0_v103 (Il2CppClass<NGUIText>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			baseline = 0f;
			return;
		}
		goto IL_0867;
	}

	public unsafe static BMSymbol GetSymbol(string text, int index, int textLength)
	{
		//IL_0210: Expected I, but got Obj
		//IL_0226: Expected Obj, but got I
		//IL_044d: Expected I, but got Obj
		//IL_0463: Expected Obj, but got I
		//IL_0018: Expected Obj, but got I4
		//IL_0026: Expected I, but got Obj
		//IL_003c: Expected Obj, but got I
		//IL_0251: Expected I, but got Obj
		//IL_0504: Expected Obj, but got I4
		//IL_029e: Expected I, but got Obj
		//IL_03d3: Expected Obj, but got I4
		//IL_0067: Expected I, but got Obj
		//IL_00b4: Expected I, but got Obj
		//IL_00ca: Expected Obj, but got I
		//IL_02fd: Expected Obj, but got I4
		//IL_0142: Expected Obj, but got I4
		//IL_016a: Expected Obj, but got I4
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected Obj, but got Unknown
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected Obj, but got Unknown
		//IL_00f5: Expected I, but got Obj
		ref string[] reference = ref *(string[]*)null;
		string[] result;
		if (index != 0)
		{
			object key = text.m_stringLength + 16;
			nint num = (nint)typeof(Localization);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v59 (Il2CppClass<Localization>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Localization);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v98 (Il2CppClass<Localization>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (!Localization.mDictionary.TryGetValue((string)key, out reference))
			{
				nint num3 = (nint)typeof(Localization);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v87 (Il2CppClass<Localization>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(Localization);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S0_v92 (Il2CppClass<Localization>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string[] mLanguages = Localization.mLanguages;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
				object obj3 = default;
				reference = ref *(string[]*)obj3;
			}
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [index @ L1 (System.Int32)+C]");
			if ((nint)obj4 < 0)
			{
				object obj5 = index + 16;
				object obj6 = obj4 << 2;
				object key2 = obj5 + obj6;
				int num5 = ((Dictionary<string, int>)textLength).get_Item((string)key2);
				object obj7 = obj4 << 2;
				object obj8 = text.m_stringLength + obj7;
				object obj9 = obj8 + 20;
				throw new ArrayTypeMismatchException();
			}
			result = reference;
		}
		else
		{
			nint num6 = (nint)typeof(Localization);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v14 (Il2CppClass<Localization>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num7 = (nint)typeof(Localization);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v46 (Il2CppClass<Localization>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string[] mLanguages2 = Localization.mLanguages;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			nint num8 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v24 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			if (obj11 != null)
			{
				nint num9 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v42 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string[] array = default;
			char c = (char)(array.Length + 1);
			bool flag = text.m_firstChar >= c;
			bool flag2 = !flag;
			char c2 = text.m_firstChar;
			if (!flag2)
			{
				c2 = c;
			}
			object obj12 = 1;
			bool flag3 = (nint)obj12 < (int)c2;
			bool flag4 = !flag3;
			result = array;
			if (!flag4)
			{
				object obj13 = text.m_stringLength + 16;
				object obj14 = obj12 << 2;
				object obj15 = obj13 + obj14;
				throw new ArrayTypeMismatchException();
			}
		}
		return (BMSymbol)(object)result;
	}

	public static float GetGlyphWidth(int ch, int prev, float fontScale)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		return 0f;
	}

	public static GlyphInfo GetGlyph(int ch, int prev, float fontScale = 1f)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		return null;
	}

	public unsafe static float ParseAlpha(string text, int index)
	{
		//IL_052f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0534: Expected VT, but got Unknown
		//IL_053d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0542: Expected VT, but got Unknown
		//IL_054b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0550: Expected Obj, but got Unknown
		//IL_0559: Unknown result type (might be due to invalid IL or missing references)
		//IL_055e: Expected Obj, but got Unknown
		//IL_0567: Unknown result type (might be due to invalid IL or missing references)
		//IL_056c: Expected Obj, but got Unknown
		//IL_0575: Unknown result type (might be due to invalid IL or missing references)
		//IL_057a: Expected Obj, but got Unknown
		//IL_0583: Unknown result type (might be due to invalid IL or missing references)
		//IL_0588: Expected Obj, but got Unknown
		//IL_0591: Unknown result type (might be due to invalid IL or missing references)
		//IL_0596: Expected Obj, but got Unknown
		//IL_059f: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a4: Expected Obj, but got Unknown
		//IL_05ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b2: Expected Obj, but got Unknown
		//IL_05bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c0: Expected Obj, but got Unknown
		//IL_05c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ce: Expected Obj, but got Unknown
		//IL_05d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05dc: Expected Obj, but got Unknown
		//IL_05e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ea: Expected Obj, but got Unknown
		//IL_05f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f8: Expected Obj, but got Unknown
		//IL_0601: Expected Obj, but got I4
		//IL_0610: Unknown result type (might be due to invalid IL or missing references)
		//IL_0615: Expected Obj, but got Unknown
		//IL_061e: Expected Obj, but got I4
		//IL_062d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0632: Expected Obj, but got Unknown
		//IL_063b: Expected Obj, but got I4
		//IL_064a: Unknown result type (might be due to invalid IL or missing references)
		//IL_064f: Expected Obj, but got Unknown
		//IL_0658: Expected Obj, but got I4
		//IL_0670: Expected Obj, but got I4
		//IL_0333: Expected Obj, but got I4
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_004d: Expected F4, but got Obj
		//IL_0048: Expected native int or pointer, but got VT
		//IL_005b: Expected I, but got Obj
		//IL_0071: Expected Obj, but got I
		//IL_0682: Expected Obj, but got F4
		//IL_068f: Expected F4, but got Obj
		//IL_068a: Expected native int or pointer, but got VT
		//IL_06ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bf: Expected Obj, but got Unknown
		//IL_0709: Expected F4, but got Obj
		//IL_0704: Expected native int or pointer, but got VT
		//IL_00fd: Expected F4, but got Obj
		//IL_00f8: Expected native int or pointer, but got VT
		//IL_0112: Expected F4, but got I
		//IL_010d: Expected native int or pointer, but got VT
		//IL_011f: Expected Obj, but got I4
		//IL_0141: Expected Obj, but got I4
		//IL_0156: Invalid comparison between F4 and I
		//IL_0187: Expected Obj, but got I4
		//IL_009c: Expected I, but got Obj
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Expected Obj, but got Unknown
		//IL_0380: Expected I, but got Obj
		//IL_0396: Expected Obj, but got I
		//IL_075e: Expected F4, but got Obj
		//IL_0759: Expected native int or pointer, but got VT
		//IL_0789: Unknown result type (might be due to invalid IL or missing references)
		//IL_078e: Expected Obj, but got Unknown
		//IL_0797: Unknown result type (might be due to invalid IL or missing references)
		//IL_079c: Expected I4, but got Unknown
		//IL_07e6: Expected F4, but got Obj
		//IL_07e1: Expected native int or pointer, but got VT
		//IL_01b6: Expected F4, but got I4
		//IL_01b1: Expected native int or pointer, but got VT
		//IL_01c3: Expected F4, but got Obj
		//IL_01be: Expected native int or pointer, but got VT
		//IL_01f2: Expected Obj, but got I4
		//IL_0277: Expected Obj, but got I
		//IL_02a3: Expected Obj, but got I
		//IL_0422: Expected F4, but got Obj
		//IL_041d: Expected native int or pointer, but got VT
		//IL_0437: Expected F4, but got I
		//IL_0432: Expected native int or pointer, but got VT
		//IL_0451: Expected F4, but got Obj
		//IL_044c: Expected native int or pointer, but got VT
		//IL_0466: Expected F4, but got I
		//IL_0461: Expected native int or pointer, but got VT
		//IL_03c1: Expected I, but got Obj
		//IL_0485: Expected Obj, but got I4
		//IL_04a2: Expected F4, but got Obj
		//IL_049d: Expected native int or pointer, but got VT
		//IL_04af: Expected F4, but got Obj
		//IL_04aa: Expected native int or pointer, but got VT
		//IL_04b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bd: Expected Obj, but got Unknown
		//IL_04dd: Expected Obj, but got VT
		//IL_04fc: Expected Obj, but got I4
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Expected Obj, but got Unknown
		object obj = default;
		Vector4 vector = (Vector4)(obj + 112);
		Vector2 vector2 = (Vector2)(obj + 96);
		Vector3[] array = (Vector3[])(obj + 196);
		object obj2 = obj + 88;
		object obj3 = obj + 56;
		object obj4 = obj + 136;
		object obj5 = obj + 80;
		object obj6 = obj + 24;
		object obj7 = obj + 124;
		object obj8 = obj + 72;
		object obj9 = obj - -64;
		object obj10 = obj + 48;
		object obj11 = obj + 40;
		object obj12 = obj + 16;
		object obj13 = obj + 184;
		obj13 = 0;
		_ = 0;
		object obj14 = obj + 172;
		obj14 = 0;
		_ = 0;
		object obj15 = obj + 160;
		obj15 = 0;
		_ = 0;
		object obj16 = obj + 148;
		obj16 = 0;
		_ = 0;
		int val = 4;
		object obj17 = 0;
		int num = default;
		int num11 = default;
		while (num <= 4)
		{
			object obj18 = text + 16;
			string text2 = NGUIMath.IntToBinary(num, 4);
			object obj19 = (object)text2 << 3;
			object obj20 = obj18 + obj19;
			((Vector2*)(nint)vector2)->x = (float)obj20;
			nint num2 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ S0_v106 (Il2CppClass<UnityEngine.Vector2>)+BA]");
			object obj21 = (nint)0 & (nint)0x200;
			if (obj21 != null)
			{
				nint num3 = (nint)typeof(Vector2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ S0_v136 (Il2CppClass<UnityEngine.Vector2>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj2 = vector2.x;
			((Vector4*)(nint)vector)->x = (float)obj2;
			Vector3 vector3 = vector;
			obj13 = array;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13 (UnityEngine.Vector3[])+8]");
			_ = 0;
			object obj22 = text + 16;
			string text3 = NGUIMath.IntToBinary(val, 4);
			object obj23 = (object)text3 << 3;
			object obj24 = obj22 + obj23;
			obj3 = obj24;
			obj5 = obj3;
			((Vector4*)(nint)vector)->x = (float)obj5;
			Vector3 vector4 = vector;
			obj14 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
			_ = 0;
			((Vector4*)(nint)vector)->x = (float)obj13;
			Vector4 vector5 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v37+8]");
			((Vector4*)(nint)vector5)->z = 0f;
			obj6 = ((int*)index)->m_value;
			obj7 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v40+8]");
			_ = 0;
			obj = ((int*)index)->m_value;
			float y = vector.y;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v23+4]");
			bool flag = y > 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v25+4]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			bool flag2 = num4 > 0;
			object obj25 = flag ^ flag2;
			if (obj25 != null)
			{
				((Vector4*)(nint)vector)->x = ((int*)index)->m_value;
				((Vector2*)(nint)vector2)->x = (float)obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v40+8]");
				_ = 0;
				array = (Vector3[])obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v37+8]");
				_ = 0;
				obj3 = ((int*)index)->m_value;
				obj4 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v37+8]");
				_ = 0;
				obj6 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v40+8]");
				_ = 0;
				obj7 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v37+8]");
				_ = 0;
				obj = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v37+8]");
				_ = 0;
				float num5 = vector2.x - (float)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+4]");
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+4]");
				object obj26 = num6 - 0;
				float num7 = num5 * (float)obj26;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v23+4]");
				nint num8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v25+4]");
				object obj27 = num8 - 0;
				float num9 = num7 / (float)obj27;
				float num10 = num9 + (float)obj;
				if (vector.x < num10)
				{
					object obj28 = obj17 ^ 1;
					obj17 = obj28;
				}
			}
			num = num11 + 1;
			val = num;
		}
		float num12;
		if (obj17 == null)
		{
			object obj29 = 0;
			num12 = -1f;
			while ((nint)obj29 <= 3)
			{
				object obj30 = text + 16;
				object obj31 = obj29 << 3;
				object obj32 = obj30 + obj31;
				obj3 = obj32;
				nint num13 = (nint)typeof(Vector2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ S0_v66 (Il2CppClass<UnityEngine.Vector2>)+BA]");
				object obj33 = (nint)0 & (nint)0x200;
				if (obj33 != null)
				{
					nint num14 = (nint)typeof(Vector2);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ S0_v99 (Il2CppClass<UnityEngine.Vector2>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj8 = obj3;
				((Vector4*)(nint)vector)->x = (float)obj8;
				Vector3 vector6 = vector;
				obj15 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
				_ = 0;
				object obj34 = text + 16;
				int val2 = obj29 + 1;
				string text4 = NGUIMath.IntToBinary(val2, 4);
				object obj35 = (object)text4 << 3;
				object obj36 = obj34 + obj35;
				obj6 = obj36;
				obj9 = obj6;
				((Vector4*)(nint)vector)->x = (float)obj9;
				Vector3 vector7 = vector;
				obj16 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v25+8]");
				_ = 0;
				((Vector4*)(nint)vector)->x = (float)obj15;
				Vector4 vector8 = vector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v43+8]");
				((Vector4*)(nint)vector8)->z = 0f;
				Vector3 vector9 = (Vector2)vector;
				((Vector4*)(nint)vector)->x = (float)obj16;
				Vector4 vector10 = vector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v46+8]");
				((Vector4*)(nint)vector10)->z = 0f;
				Vector3 vector11 = (Vector2)vector;
				obj10 = ((int*)index)->m_value;
				obj11 = obj;
				array = (Vector3[])obj10;
				((Vector2*)(nint)vector2)->x = (float)obj11;
				((Vector4*)(nint)vector)->x = (float)obj12;
				object obj37 = obj29 + 1;
				bool flag3 = num12 < 0f;
				float num15 = NGUIMath.DistanceToRectangle(array, vector2, (Camera)vector);
				bool flag4 = num15 < num12;
				object obj38 = flag3 | flag4;
				if (obj38 != null)
				{
					num12 = num15;
				}
				obj29 = obj37;
			}
		}
		else
		{
			num12 = 0f;
		}
		return num12;
	}

	public static Color ParseColor(string text, int offset = 0)
	{
		//IL_00d9: Expected Obj, but got VT
		//IL_00f8: Expected I, but got Obj
		//IL_010e: Expected Obj, but got I
		//IL_0134: Expected Obj, but got I4
		//IL_0146: Expected I, but got Obj
		//IL_015c: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00c6: Expected Obj, but got I4
		//IL_00c6: Expected Obj, but got VT
		Color color = default;
		string tag = ((Component)color).tag;
		bool activeSelf = ((GameObject)(object)tag).activeSelf;
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v6 (Il2CppClass<NGUITools>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S1_v19 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string typeName = NGUITools.GetTypeName((UnityEngine.Object)activeSelf);
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v13 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v24 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)typeName).FindKernel((string)null) != 0)
		{
			_ = text.m_stringLength;
			Print((string)color, (List<Vector3>)(object)text, (List<Vector2>)offset, (List<Color>)(object)typeName);
		}
		return color;
	}

	public static Color ParseColor24(string text, int offset = 0)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<NGUIText>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<NGUIText>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Color color = ParseColor32(text, offset);
		Color result = default;
		return result;
	}

	public unsafe static Color ParseColor32(string text, int offset)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_001a: Expected I4, but got Obj
		//IL_0031: Expected Obj, but got I4
		//IL_004b: Expected I4, but got Obj
		//IL_007d: Expected Obj, but got I4
		//IL_0097: Expected I4, but got Obj
		//IL_00ae: Expected Obj, but got I4
		//IL_00c8: Expected I4, but got Obj
		//IL_00fa: Expected Obj, but got I4
		//IL_0114: Expected I4, but got Obj
		//IL_012b: Expected Obj, but got I4
		//IL_0145: Expected I4, but got Obj
		//IL_0172: Expected native int or pointer, but got VT
		//IL_0180: Expected native int or pointer, but got VT
		//IL_019d: Expected native int or pointer, but got VT
		//IL_01ba: Expected native int or pointer, but got VT
		//IL_01d7: Expected native int or pointer, but got VT
		//IL_01e5: Expected native int or pointer, but got VT
		string[] array = text.Split((char[])offset);
		char c = NGUIMath.DecimalToHexChar((int)array);
		char[] separator = (char[])(offset + 1);
		string[] array2 = text.Split(separator);
		char c2 = NGUIMath.DecimalToHexChar((int)array2);
		int num = (int)((uint)c << 4);
		int num2 = c2 | num;
		char[] separator2 = (char[])(offset + 2);
		string[] array3 = text.Split(separator2);
		char c3 = NGUIMath.DecimalToHexChar((int)array3);
		char[] separator3 = (char[])(offset + 3);
		string[] array4 = text.Split(separator3);
		char c4 = NGUIMath.DecimalToHexChar((int)array4);
		int num3 = (int)((uint)c3 << 4);
		int num4 = c4 | num3;
		char[] separator4 = (char[])(offset + 4);
		string[] array5 = text.Split(separator4);
		char c5 = NGUIMath.DecimalToHexChar((int)array5);
		char[] separator5 = (char[])(offset + 5);
		string[] array6 = text.Split(separator5);
		char c6 = NGUIMath.DecimalToHexChar((int)array6);
		int num5 = (int)((uint)c5 << 4);
		int num6 = c6 | num5;
		Color color = default;
		((Color*)(nint)color)->r = 0f;
		((Color*)(nint)color)->b = 0f;
		float r = 1f / 255f * (float)num2;
		((Color*)(nint)color)->r = r;
		float g = 1f / 255f * (float)num4;
		((Color*)(nint)color)->g = g;
		float b = 1f / 255f * (float)num6;
		((Color*)(nint)color)->b = b;
		((Color*)(nint)color)->a = 1f;
		return color;
	}

	public static string EncodeColor(Color c)
	{
		//IL_000d: Expected Obj, but got F4
		//IL_0016: Invalid comparison between Obj and F4
		//IL_00e7: Expected Obj, but got F4
		//IL_00f0: Invalid comparison between Obj and F4
		//IL_01b0: Expected Obj, but got F4
		//IL_01c1: Invalid comparison between I and F4
		//IL_01d0: Expected Obj, but got I4
		//IL_0042: Expected Obj, but got F4
		//IL_0053: Invalid comparison between I and F4
		//IL_011c: Expected Obj, but got F4
		//IL_012d: Invalid comparison between I and F4
		//IL_013c: Expected Obj, but got I4
		//IL_0084: Expected Obj, but got F4
		//IL_0095: Invalid comparison between I and F4
		//IL_01eb: Expected Obj, but got F4
		//IL_01fc: Invalid comparison between I and F4
		//IL_00c7: Expected Obj, but got I4
		//IL_0232: Expected Obj, but got I4
		//IL_0157: Expected Obj, but got F4
		//IL_0168: Invalid comparison between I and F4
		//IL_00d5: Expected Obj, but got I4
		//IL_0224: Expected Obj, but got I4
		//IL_019e: Expected Obj, but got I4
		//IL_0190: Expected Obj, but got I4
		object obj = c.r;
		string result;
		if (obj == (object)0f)
		{
			obj = c.r;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			if (0f != 0f)
			{
				obj = c.r;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
				if (0f == 1f)
				{
					return null;
				}
				return (string)3;
			}
			result = (string)6;
		}
		else
		{
			obj = c.r;
			if (obj == (object)1f)
			{
				obj = c.r;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
				bool flag = 0f == 0f;
				result = (string)8;
				if (!flag)
				{
					obj = c.r;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
					result = ((0f != 1f) ? ((string)5) : ((string)2));
				}
			}
			else
			{
				obj = c.r;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
				bool flag2 = 0f == 0f;
				result = (string)7;
				if (!flag2)
				{
					obj = c.r;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
					result = ((0f != 1f) ? ((string)4) : ((string)1));
				}
			}
		}
		return result;
	}

	public static string EncodeColor(string text, Color c)
	{
		//IL_024e: Expected Obj, but got I4
		//IL_02e9: Invalid comparison between VT and I4
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_001c: Invalid comparison between VT and I4
		//IL_0213: Expected I4, but got Obj
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected VT, but got Unknown
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected Obj, but got Unknown
		//IL_0286: Expected Obj, but got I4
		//IL_023b: Expected Obj, but got I4
		//IL_022d: Expected Obj, but got I4
		object obj = 0;
		string text2 = "";
		Color color = default;
		int totalLength = default;
		while (color >= (object)1)
		{
			object obj2 = color - 8;
			if (color == (Color)(object)8 || ((nint)obj2 != 1 && (nint)obj2 != 2 && (nint)obj2 != 3 && (nint)obj2 != 4 && (nint)obj2 != 5 && (nint)obj2 != 6 && (nint)obj2 != 7 && ((nint)obj2 == 8 || ((nint)obj2 != 9 && (nint)obj2 != 10 && (nint)obj2 != 11 && (nint)obj2 != 12 && (nint)obj2 != 13 && (nint)obj2 != 14 && (nint)obj2 != 15 && (nint)obj2 == 16))))
			{
				string text3 = string.ConcatArray((string[])(object)text2, (int)" ");
				text2 = text3;
			}
			color = (Color)(color - 1);
			object obj3 = color & 0x1F;
			object obj4 = 1 << (int)obj3;
			object obj5 = obj4 & (object)text;
			object obj6 = ((obj5 == null) ? ((object)48) : ((object)49));
			obj = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E2B3");
			string text4 = string.ConcatArray((string[])(object)text2, totalLength);
			text2 = text4;
		}
		return text2;
	}

	public static string EncodeAlpha(float a)
	{
		//IL_0165: Expected I, but got Obj
		//IL_017b: Expected Obj, but got I
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected Obj, but got Unknown
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected Obj, but got Unknown
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected Obj, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_00bb: Expected I, but got Obj
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected Obj, but got Unknown
		float value = UnityEngine.Random.value;
		string dataPath = Application.dataPath;
		bool flag = value == 0f;
		bool flag2 = !flag;
		float num = value;
		if (!flag2)
		{
			object obj = dataPath - 8;
			num = (((nint)dataPath == 8 || ((nint)obj != 1 && (nint)obj != 2 && (nint)obj == 3)) ? 160f : 96f);
		}
		nint num2 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v13 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num3 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v28 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num4 = 96f / num;
		float width = a * num4;
		GUILayoutOption gUILayoutOption = GUILayout.Width(width);
		object obj3 = gUILayoutOption & 1;
		object obj4 = obj3 + 7;
		object obj5 = obj4 & 7;
		bool flag3 = obj5 == null;
		bool flag4 = !flag3;
		GUILayoutOption result = gUILayoutOption;
		if (!flag4)
		{
			GUILayoutOption gUILayoutOption2 = (GUILayoutOption)(gUILayoutOption + 1);
			result = gUILayoutOption2;
		}
		return (string)(object)result;
	}

	public unsafe static string EncodeColor24(Color c)
	{
		//IL_005f: Expected Obj, but got F4
		//IL_0077: Expected I, but got Obj
		//IL_008d: Expected Obj, but got I
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected VT, but got Unknown
		//IL_00c5: Expected F4, but got Obj
		//IL_00c0: Expected native int or pointer, but got VT
		//IL_00da: Expected F4, but got I
		//IL_00d5: Expected native int or pointer, but got VT
		//IL_0013: Expected I, but got Obj
		object obj = c.r;
		_ = c.b;
		nint num = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11 (Il2CppClass<NGUIText>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v20 (Il2CppClass<NGUIText>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Color color = (Color)(obj + 16);
		((Color*)(nint)color)->r = (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Color*)(nint)color)->b = 0f;
		return EncodeColor32(color);
	}

	public unsafe static string EncodeColor32(Color c)
	{
		//IL_000d: Expected native int or pointer, but got VT
		Vector2 vector = default;
		((Vector2*)(nint)vector)->x = c.r;
		_ = c.b;
		UIWidget.Pivot pivot = NGUIMath.GetPivot(vector);
		int num = (int)pivot >> 8;
		return NGUIMath.DecimalToHex32(num);
	}

	public static bool ParseSymbol(string text, ref int index)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		throw new ArrayTypeMismatchException();
	}

	public unsafe static bool IsHex(char ch)
	{
		//IL_0012: Expected F4, but got I4
		//IL_000d: Expected native int or pointer, but got VT
		//IL_0035: Expected VT, but got I4
		Vector2 vector = default;
		((Vector2*)(nint)vector)->x = (int)((char*)(int)ch)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ch @ L0 (System.Char)+8]");
		_ = 0;
		UIWidget.Pivot pivot = NGUIMath.GetPivot(vector);
		return (byte)NGUIMath.ColorToInt((Color)pivot) != 0;
	}

	public static bool ParseSymbol(string text, ref int index, BetterList<Color> colors, bool premultiply, ref int sub, ref bool bold, ref bool italic, ref bool underline, ref bool strike, ref bool ignoreColor)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		return false;
	}

	public static string StripSymbols(string text)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected Obj, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected Obj, but got Unknown
		//IL_0117: Expected Obj, but got I4
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected Obj, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected Obj, but got Unknown
		//IL_0109: Expected Obj, but got I4
		object obj = text + -48;
		object obj2 = obj << 16;
		object obj3 = obj2 >> 16;
		object obj4 = obj3 & 0xFFFF;
		bool flag;
		if ((nint)obj4 > 9)
		{
			object obj5 = text + -97;
			object obj6 = obj5 << 16;
			object obj7 = obj6 >> 16;
			object obj8 = obj7 & 0xFFFF;
			flag = (nint)obj8 > 5;
		}
		else
		{
			flag = false;
		}
		if (flag)
		{
			object obj9 = text + -65;
			object obj10 = obj9 << 16;
			object obj11 = obj10 >> 16;
			object obj12 = obj11 & 0xFFFF;
			bool flag2 = (nint)obj12 < 6;
			return (string)flag2;
		}
		return (string)1;
	}

	public unsafe static void Align(List<Vector3> verts, int indexOffset, float printedWidth, int elements = 4)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001b: Expected Obj, but got I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_003f: Expected Obj, but got I4
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected Ref, but got Unknown
		//IL_00b1: Expected Obj, but got I
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected Obj, but got Unknown
		//IL_00d5: Expected Obj, but got I4
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected Obj, but got Unknown
		//IL_00f9: Expected Obj, but got I4
		//IL_015d: Expected Obj, but got I
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected Obj, but got Unknown
		//IL_0181: Expected Obj, but got I4
		//IL_0197: Expected Obj, but got I4
		//IL_01fb: Expected Obj, but got I
		//IL_0214: Invalid comparison between I and F4
		//IL_0257: Invalid comparison between I and F4
		//IL_029d: Expected Obj, but got Ref
		object obj2 = default;
		object obj = obj2 + 108;
		obj = ((int*)elements)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [elements @ L3 (System.Int32)+8]");
		_ = 0;
		object obj3 = obj2 + 80;
		obj3 = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F648");
		ref Keyframe reference = ref *(Keyframe*)(obj2 + 120);
		reference = ref *(Keyframe*)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S1_v8+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S1_v8+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S1_v8+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L0 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+8]");
		int num = ((AnimationCurve)0).MoveKey_Injected(indexOffset, ref reference);
		object obj4 = obj2 + 68;
		obj4 = ((int*)elements)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [elements @ L3 (System.Int32)+8]");
		_ = 0;
		object obj5 = obj2 + 40;
		obj5 = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F648");
		reference = ref *(Keyframe*)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S1_v25+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S1_v25+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S1_v25+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L0 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+C]");
		int num2 = ((AnimationCurve)0).MoveKey_Injected(indexOffset, ref reference);
		object obj6 = obj2 + 28;
		obj6 = ((int*)elements)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [elements @ L3 (System.Int32)+8]");
		_ = 0;
		obj2 = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F648");
		reference = ref *(Keyframe*)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L0 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
		int num3 = ((AnimationCurve)0).MoveKey_Injected(indexOffset, ref reference);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L0 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+2C]");
		if (0f > printedWidth)
		{
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L0 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+30]");
		if (0f < printedWidth)
		{
		}
		reference = ref *(Keyframe*)((int*)elements)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [elements @ L3 (System.Int32)+8]");
		_ = 0;
		((FPSLog)(object)verts).SetLastRunResult = (string)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
	}

	public static int GetExactCharacterIndex(List<Vector3> verts, List<int> indices, Vector2 pos)
	{
		//IL_0149: Expected I, but got Obj
		//IL_015f: Expected Obj, but got I
		//IL_01b6: Expected I, but got Obj
		//IL_01cc: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_0192: Expected I4, but got VT
		//IL_0192: Expected I4, but got Obj
		//IL_00ee: Expected I, but got Obj
		nint num = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<NGUIText>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v31 (Il2CppClass<NGUIText>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)bitmapFont).FindKernel((string)null) != 0)
		{
			nint num5 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v17 (Il2CppClass<NGUIText>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v25 (Il2CppClass<NGUIText>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return ((UIInput)(object)bitmapFont).Validate((string)(object)verts, (int)indices, (char)(int)pos);
		}
		return 0;
	}

	public static int GetApproximateCharacterIndex(List<Vector3> verts, List<int> indices, Vector2 pos)
	{
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Expected Obj, but got Unknown
		//IL_0026: Expected Obj, but got I4
		//IL_003d: Expected Obj, but got F4
		//IL_0086: Expected Obj, but got F4
		//IL_00cf: Expected Obj, but got F4
		//IL_0128: Expected Obj, but got F4
		object obj2 = default;
		object obj = obj2 + 8;
		int num = 0;
		while (true)
		{
			int num2 = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [indices @ L1 (System.Collections.Generic.List`1<System.Int32>)+C]");
			if ((nint)num2 < (nint)0)
			{
				int num3 = num << 1;
				object obj3 = num3 + 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8873");
				obj2 = pos.x;
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8873");
					obj2 = pos.x;
					if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8873");
						obj2 = pos.x;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
						nint num4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
						if (num4 >= 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8873");
							obj2 = pos.x;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
							nint num5 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
							if (num5 <= 0)
							{
								break;
							}
						}
					}
				}
				int num6 = num + 1;
				num = num6;
				continue;
			}
			return 0;
		}
		return indices.get_Item(num);
	}

	public static bool IsSpace(int ch)
	{
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Expected Obj, but got Unknown
		//IL_01a2: Expected Obj, but got I4
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected Obj, but got Unknown
		//IL_01b9: Expected Obj, but got I4
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected Obj, but got Unknown
		//IL_01d0: Expected Obj, but got I4
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected Obj, but got Unknown
		//IL_01e7: Expected Obj, but got I4
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected Obj, but got Unknown
		//IL_01fe: Expected Obj, but got I4
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Expected Obj, but got Unknown
		//IL_0215: Expected Obj, but got I4
		//IL_021e: Expected Obj, but got I4
		//IL_002c: Expected Obj, but got I4
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected Obj, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected Obj, but got Unknown
		//IL_006f: Expected Obj, but got I4
		//IL_0078: Expected Obj, but got I4
		//IL_0081: Expected Obj, but got I4
		//IL_008a: Expected Obj, but got I4
		//IL_0093: Expected Obj, but got I4
		//IL_009c: Expected Obj, but got I4
		//IL_00b2: Expected I, but got Obj
		//IL_00c8: Expected Obj, but got I
		//IL_016b: Expected Obj, but got I4
		//IL_0178: Expected I4, but got Obj
		//IL_00f3: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 4;
		obj = 0;
		object obj3 = obj2 + 12;
		obj3 = 0;
		object obj4 = obj2 + 11;
		obj4 = 0;
		object obj5 = obj2 + 10;
		obj5 = 0;
		object obj6 = obj2 + 9;
		obj6 = 0;
		object obj7 = obj2 + 8;
		obj7 = 0;
		obj2 = 0;
		int num = default;
		if (num != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ L0_v2 (System.Int32)+8]");
			int num2 = 0;
			char[] array = null;
			object obj10 = default;
			while ((nint)array < num2)
			{
				string[] array2 = ((string)num).Split(array);
				object obj8 = array2 & 0xFFFF;
				if ((nint)obj8 == 91)
				{
					obj = 0;
					obj3 = 0;
					obj4 = 0;
					obj5 = 0;
					obj6 = 0;
					obj7 = 0;
					obj2 = array;
					nint num3 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S0_v47 (Il2CppClass<NGUIText>)+BA]");
					object obj9 = (nint)0 & (nint)0x200;
					if (obj9 != null)
					{
						nint num4 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ S0_v57 (Il2CppClass<NGUIText>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B752");
					if (obj10 != null)
					{
						object arg = obj2 - (object)array;
						string text = string.Format((string)num, array, arg);
						num = (int)text;
						num2 = text.m_stringLength;
						continue;
					}
				}
				char[] array3 = (char[])(array + 1);
				array = array3;
			}
		}
		else
		{
			num = 0;
		}
		return (byte)num != 0;
	}

	public unsafe static void EndLine(ref StringBuilder s)
	{
		//IL_013c: Expected I, but got Obj
		//IL_0152: Expected Obj, but got I
		//IL_01a9: Expected I, but got Obj
		//IL_01bf: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_0187: Expected Obj, but got Ref
		//IL_00ee: Expected I, but got Obj
		nint num = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<NGUIText>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v35 (Il2CppClass<NGUIText>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		BetterList<Color> betterList = mColors;
		_ = 0;
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v5 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)dynamicFont).FindKernel((string)null) == 0)
		{
			return;
		}
		nint num5 = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v22 (Il2CppClass<NGUIText>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v29 (Il2CppClass<NGUIText>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((UnityEngine.Bindings.NativeMethodAttribute)(object)dynamicFont)._002Ector((string)System.Runtime.CompilerServices.Unsafe.AsPointer(ref s), (byte)finalSize != 0, (byte)fontStyle != 0);
	}

	private static void ReplaceSpaceWithNewline(ref StringBuilder s)
	{
		//IL_00f6: Expected Obj, but got I4
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected Obj, but got Unknown
		//IL_0025: Expected I, but got Obj
		//IL_003b: Expected Obj, but got I
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected Obj, but got Unknown
		//IL_0066: Expected I, but got Obj
		//IL_00b8: Expected I4, but got Obj
		StringBuilder stringBuilder = s;
		object obj = stringBuilder.m_ChunkLength + stringBuilder.m_ChunkOffset;
		string text = (string)(obj - 1);
		if ((nint)text >= 1)
		{
			StringBuilder stringBuilder2 = s.Append(text);
			nint num = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S1_v11 (Il2CppClass<NGUIText>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S1_v18 (Il2CppClass<NGUIText>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text2 = (string)(stringBuilder2 & 0xFFFF);
			if (CalculateOffsetToFit(text2) != 0)
			{
				((UnicodeEncoding)(object)s)._002Ector((byte)(int)text != 0, true);
				return;
			}
		}
		StringBuilder stringBuilder3 = s.Append(10);
	}

	public static Vector2 CalculatePrintedSize(string text)
	{
		//IL_01bd: Expected Obj, but got VT
		//IL_01dc: Expected I, but got Obj
		//IL_01f2: Expected Obj, but got I
		//IL_0218: Expected Obj, but got I4
		//IL_005b: Expected Obj, but got I4
		//IL_006d: Expected I, but got Obj
		//IL_0083: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Expected Obj, but got Unknown
		//IL_00ae: Expected I, but got Obj
		//IL_00fb: Expected I, but got Obj
		//IL_0111: Expected Obj, but got I
		//IL_013c: Expected I, but got Obj
		//IL_0188: Expected VT, but got Obj
		//IL_01af: Expected Obj, but got VT
		Vector2 vector = default;
		string tag = ((Component)vector).tag;
		bool activeSelf = ((GameObject)(object)tag).activeSelf;
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v6 (Il2CppClass<NGUITools>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S1_v26 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string typeName = NGUITools.GetTypeName((UnityEngine.Object)activeSelf);
		string tag2 = ((Component)(object)text).tag;
		bool activeSelf2 = ((GameObject)(object)tag2).activeSelf;
		string typeName2 = NGUITools.GetTypeName((UnityEngine.Object)activeSelf2);
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v17 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v42 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Transform transform = default;
		List<Vector3> list = (List<Vector3>)(transform + 12);
		if (((ComputeShader)(object)typeName).FindKernel((string)null) != 0)
		{
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v28 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v38 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)typeName2).FindKernel((string)null) != 0)
			{
				transform.position = (Vector3)text;
				list = (List<Vector3>)(object)transform;
				_ = ((UnityEngine.Object)transform).m_CachedPtr;
				Print((string)vector, list, (List<Vector2>)(object)typeName2, (List<Color>)(object)typeName);
			}
		}
		return vector;
	}

	public static int CalculateOffsetToFit(string text)
	{
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected Obj, but got Unknown
		if ((nint)text < 8202)
		{
			if ((nint)text != 32)
			{
				goto IL_0067;
			}
		}
		else if ((nint)text != 8202)
		{
			goto IL_0067;
		}
		return 1;
		IL_0067:
		object obj = text | 2;
		return ((nint)obj == 8203) ? 1 : 0;
	}

	public unsafe static string GetEndOfLineThatFits(string text)
	{
		//IL_08b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b6: Expected Obj, but got Unknown
		//IL_08bf: Expected Obj, but got I4
		//IL_08c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cd: Expected Obj, but got Unknown
		//IL_08d6: Expected Obj, but got I4
		//IL_08df: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e4: Expected Obj, but got Unknown
		//IL_08ed: Expected Obj, but got I4
		//IL_08f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fb: Expected Obj, but got Unknown
		//IL_0904: Expected Obj, but got I4
		//IL_090d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0912: Expected Obj, but got Unknown
		//IL_091b: Expected Obj, but got I4
		//IL_0924: Unknown result type (might be due to invalid IL or missing references)
		//IL_0929: Expected Obj, but got Unknown
		//IL_0932: Expected Obj, but got I4
		//IL_093b: Expected Obj, but got I4
		//IL_0044: Expected I, but got Obj
		//IL_005a: Expected Obj, but got I
		//IL_0085: Expected I, but got Obj
		//IL_00d2: Expected I, but got Obj
		//IL_00e8: Expected Obj, but got I
		//IL_09b1: Expected Obj, but got I4
		//IL_09ba: Expected Obj, but got I4
		//IL_09c3: Expected Obj, but got I4
		//IL_09cc: Expected Obj, but got I4
		//IL_09d5: Expected Obj, but got I4
		//IL_09de: Expected Obj, but got I4
		//IL_09e7: Expected Obj, but got I4
		//IL_0113: Expected I, but got Obj
		//IL_0721: Expected I, but got Obj
		//IL_0737: Expected Obj, but got I
		//IL_0c13: Expected Obj, but got I
		//IL_0160: Expected I, but got Obj
		//IL_0176: Expected Obj, but got I
		//IL_0d4c: Expected I, but got Obj
		//IL_0d62: Expected Obj, but got I
		//IL_0d89: Invalid comparison between I4 and F4
		//IL_0da7: Expected Obj, but got I4
		//IL_0762: Expected I, but got Obj
		//IL_0c9a: Invalid comparison between I4 and F4
		//IL_0cc7: Expected I, but got Obj
		//IL_0cdd: Expected Obj, but got I
		//IL_0245: Expected I, but got Obj
		//IL_0844: Expected I, but got Obj
		//IL_0c37: Expected Obj, but got I
		//IL_0c40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c45: Expected Obj, but got Unknown
		//IL_0c68: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c6d: Expected I4, but got Unknown
		//IL_01d4: Expected I, but got Obj
		//IL_088c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0891: Expected Obj, but got Unknown
		//IL_07d3: Expected I, but got Obj
		//IL_0292: Expected I, but got Obj
		//IL_0a3d: Expected I, but got Obj
		//IL_0a53: Expected Obj, but got I
		//IL_02df: Expected I, but got Obj
		//IL_02f5: Expected Obj, but got I
		//IL_0a26: Expected VT, but got I4
		//IL_037b: Expected I, but got Obj
		//IL_0320: Expected I, but got Obj
		//IL_05d2: Expected I, but got Obj
		//IL_05e8: Expected Obj, but got I
		//IL_03c8: Expected I, but got Obj
		//IL_03de: Expected Obj, but got I
		//IL_0b7c: Expected Obj, but got I
		//IL_0b92: Expected Obj, but got I
		//IL_0b9b: Expected Obj, but got I4
		//IL_04bb: Expected I, but got Obj
		//IL_04d1: Expected Obj, but got I
		//IL_0613: Expected I, but got Obj
		//IL_0acf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad4: Expected Obj, but got Unknown
		//IL_0409: Expected I, but got Obj
		//IL_06d6: Expected Obj, but got I
		//IL_06ec: Expected Obj, but got I
		//IL_04fc: Expected I, but got Obj
		//IL_0451: Unknown result type (might be due to invalid IL or missing references)
		//IL_0456: Expected Obj, but got Unknown
		//IL_0ab4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab9: Expected Obj, but got Unknown
		//IL_0660: Expected I, but got Obj
		//IL_0676: Expected Obj, but got I
		//IL_0549: Expected I, but got Obj
		//IL_055f: Expected Obj, but got I
		//IL_0bb8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bbd: Expected Obj, but got Unknown
		//IL_06a1: Expected I, but got Obj
		//IL_058a: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 4;
		obj = 0;
		object obj3 = obj2 + 12;
		obj3 = 0;
		object obj4 = obj2 + 11;
		obj4 = 0;
		object obj5 = obj2 + 10;
		obj5 = 0;
		object obj6 = obj2 + 9;
		obj6 = 0;
		object obj7 = obj2 + 8;
		obj7 = 0;
		obj2 = 0;
		string text2;
		if (text == null || text.m_stringLength == 0)
		{
			text2 = null;
		}
		else
		{
			nint num = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v27 (Il2CppClass<NGUIText>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num2 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S0_v281 (Il2CppClass<NGUIText>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (regionWidth > 0)
			{
				nint num3 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S0_v37 (Il2CppClass<NGUIText>)+BA]");
				object obj9 = (nint)0 & (nint)0x200;
				if (obj9 != null)
				{
					nint num4 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S0_v277 (Il2CppClass<NGUIText>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				EndLine(ref *(StringBuilder*)text);
				obj = 0;
				obj3 = 0;
				obj4 = 0;
				obj5 = 0;
				obj6 = 0;
				obj7 = 0;
				object obj10 = default;
				object obj18;
				object obj16 = default;
				string text3 = default;
				for (obj2 = 0; (nint)obj10 < text.m_stringLength; obj10 = obj18 + 1, obj2 = obj10)
				{
					nint num5 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ S0_v117 (Il2CppClass<NGUIText>)+BA]");
					object obj11 = (nint)0 & (nint)0x200;
					bool flag = obj11 == null;
					float num7;
					if (obj != null)
					{
						if (!flag)
						{
							nint num6 = (nint)typeof(NGUIText);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ S0_v271 (Il2CppClass<NGUIText>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						num7 = fontScale * 0.75f;
					}
					else
					{
						if (!flag)
						{
							nint num8 = (nint)typeof(NGUIText);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ S0_v258 (Il2CppClass<NGUIText>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						num7 = fontScale;
					}
					nint num9 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ S0_v125 (Il2CppClass<NGUIText>)+BA]");
					object obj12 = (nint)0 & (nint)0x200;
					if (obj12 != null)
					{
						nint num10 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ S0_v246 (Il2CppClass<NGUIText>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					int num13;
					if (~(useSymbols ? 1u : 0u) == 0)
					{
						nint num11 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ S0_v236 (Il2CppClass<NGUIText>)+BA]");
						object obj13 = (nint)0 & (nint)0x200;
						if (obj13 != null)
						{
							nint num12 = (nint)typeof(NGUIText);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ S0_v242 (Il2CppClass<NGUIText>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						num13 = GetExactCharacterIndex((List<Vector3>)(object)text, (List<int>)obj2, (Vector2)text.m_stringLength);
					}
					else
					{
						num13 = 0;
					}
					nint num14 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ S0_v134 (Il2CppClass<NGUIText>)+BA]");
					object obj14 = (nint)0 & (nint)0x200;
					if (obj14 != null)
					{
						nint num15 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ S0_v226 (Il2CppClass<NGUIText>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (~(encoding ? 1u : 0u) == 0)
					{
						nint num16 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ S0_v210 (Il2CppClass<NGUIText>)+BA]");
						object obj15 = (nint)0 & (nint)0x200;
						if (obj15 != null)
						{
							nint num17 = (nint)typeof(NGUIText);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v478 @ S0_v220 (Il2CppClass<NGUIText>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						bool flag2 = premultiply;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B752");
						if (obj16 != null)
						{
							object obj17 = obj2 - 1;
							obj2 = obj17;
							obj18 = obj17;
							text3 = text3;
							continue;
						}
					}
					if (num13 == 0)
					{
						string[] array = text.Split((char[])obj2);
						nint num18 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ S1_v77 (Il2CppClass<NGUIText>)+BA]");
						object obj19 = (nint)0 & (nint)0x200;
						if (obj19 != null)
						{
							nint num19 = (nint)typeof(NGUIText);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ S1_v91 (Il2CppClass<NGUIText>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						JsonDict jsonDict = (JsonDict)(array & 0xFFFF);
						float num20 = jsonDict.GetFloat(text3, num7);
						if (num20 != 0f)
						{
							nint num21 = (nint)typeof(NGUIText);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v611 @ S0_v197 (Il2CppClass<NGUIText>)+BA]");
							object obj20 = (nint)0 & (nint)0x200;
							if (obj20 != null)
							{
								nint num22 = (nint)typeof(NGUIText);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v638 @ S0_v204 (Il2CppClass<NGUIText>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							float item = finalSpacingX + num20;
							mSizes.Add(item);
						}
						obj18 = obj2;
						text3 = (string)(object)jsonDict;
						continue;
					}
					nint num23 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ S0_v149 (Il2CppClass<NGUIText>)+BA]");
					object obj21 = (nint)0 & (nint)0x200;
					if (obj21 != null)
					{
						nint num24 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ S0_v181 (Il2CppClass<NGUIText>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ S0_v132 (System.Int32)+2C]");
					float num25 = 0f * num7;
					float item2 = finalSpacingX + num25;
					mSizes.Add(item2);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ S0_v132 (System.Int32)+8]");
					object obj22 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ S0_v157+8]");
					object obj23 = -1;
					object obj24 = 0;
					while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj24) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj23))
					{
						nint num26 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v626 @ S0_v167 (Il2CppClass<NGUIText>)+BA]");
						object obj25 = (nint)0 & (nint)0x200;
						if (obj25 != null)
						{
							nint num27 = (nint)typeof(NGUIText);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v651 @ S0_v176 (Il2CppClass<NGUIText>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						mSizes.Add(0f);
						object obj26 = obj24 + 1;
						obj24 = obj26;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ S0_v132 (System.Int32)+8]");
					object obj27 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v633 @ S1_v67+8]");
					object obj28 = -1;
					object obj29 = obj28 + obj2;
					obj2 = obj29;
					obj18 = obj29;
					text3 = null;
				}
				nint num28 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ S0_v57 (Il2CppClass<NGUIText>)+BA]");
				object obj30 = (nint)0 & (nint)0x200;
				if (obj30 != null)
				{
					nint num29 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ S0_v110 (Il2CppClass<NGUIText>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				BetterList<float> betterList = mSizes;
				int num30 = regionWidth;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ S0_v67 (BetterList`1<System.Single>)+C]");
				text2 = (string)0;
				bool flag3;
				while (true)
				{
					nint num31 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ S0_v71 (Il2CppClass<NGUIText>)+BA]");
					object obj31 = (nint)0 & (nint)0x200;
					flag3 = obj31 == null;
					bool flag4 = (nint)text2 < 1;
					bool flag5 = (float)num30 > 0f;
					bool flag6 = !flag5;
					object obj32 = flag4 | flag6;
					if (obj32 != null)
					{
						break;
					}
					if (!flag3)
					{
						nint num32 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ S0_v104 (Il2CppClass<NGUIText>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					BetterList<float> betterList2 = mSizes;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ S1_v43 (BetterList`1<System.Single>)+8]");
					object obj33 = (nint)0 + (nint)16;
					string text4 = (string)(text2 - 1);
					object obj34 = (object)text4 << 2;
					object obj35 = obj33 + obj34;
					int num33 = num30 - obj35;
					num30 = num33;
					text2 = text4;
				}
				if (!flag3)
				{
					nint num34 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ S0_v91 (Il2CppClass<NGUIText>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				BetterList<float> betterList3 = mSizes;
				_ = 0;
				if ((float)num30 < 0f)
				{
					string text5 = text2 + 1;
					text2 = text5;
				}
			}
			else
			{
				text2 = null;
			}
		}
		return text2;
	}

	public unsafe static bool WrapText(string text, out string finalText, bool wrapLineColors = false)
	{
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected Obj, but got Unknown
		//IL_01b5: Expected Obj, but got Ref
		//IL_0012: Expected Obj, but got I4
		//IL_002a: Expected I, but got Obj
		//IL_0040: Expected Obj, but got I
		//IL_006b: Expected I, but got Obj
		//IL_00b7: Expected Obj, but got I4
		//IL_00cf: Expected I, but got Obj
		//IL_00e5: Expected Obj, but got I
		//IL_0110: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 8;
		int num = 0;
		int index = 0;
		float num2 = float.MaxValue;
		float num3 = float.MaxValue;
		while (num < text.m_firstChar)
		{
			obj2 = ((bool*)(wrapLineColors ? 1 : 0))->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8873");
			nint num4 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S2_v6 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num5 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S2_v21 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			float num6 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
			float value = num6 - 0f;
			float num7 = Math.Abs(value);
			if (!(num7 > num2))
			{
				obj2 = ((bool*)(wrapLineColors ? 1 : 0))->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8873");
				nint num8 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S2_v13 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num9 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S2_v17 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float value2 = (float)obj2 - (float)obj;
				float num10 = Math.Abs(value2);
				if (num7 < num2)
				{
					index = num;
					num2 = num7;
					num3 = num10;
				}
				else if (num10 < num3)
				{
					index = num;
					num3 = num10;
				}
			}
			int num11 = num + 1;
			num = num11;
		}
		return (byte)((List<int>)System.Runtime.CompilerServices.Unsafe.AsPointer(ref finalText)).get_Item(index) != 0;
	}

	public static bool WrapText(string text, out string finalText, bool keepCharCount, bool wrapLineColors, bool useEllipsis = false)
	{
		//IL_01cb: Expected I, but got Obj
		//IL_01e1: Expected Obj, but got I
		//IL_0020: Expected I, but got Obj
		//IL_0036: Expected Obj, but got I
		//IL_048b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0490: Expected Obj, but got Unknown
		//IL_020c: Expected I, but got Obj
		//IL_0061: Expected I, but got Obj
		//IL_0532: Expected I4, but got Obj
		//IL_00e3: Expected I, but got Obj
		//IL_00f9: Expected Obj, but got I
		//IL_03f0: Expected Obj, but got I
		//IL_0401: Unknown result type (might be due to invalid IL or missing references)
		//IL_0406: Expected Obj, but got Unknown
		//IL_040f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0414: Expected Obj, but got Unknown
		//IL_0427: Expected Obj, but got I4
		//IL_0124: Expected I, but got Obj
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected Obj, but got Unknown
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected Obj, but got Unknown
		ActiveAnimation activeAnimation;
		if ((wrapLineColors ? 1 : 0) != 2)
		{
			string tag = ((Component)(object)text).tag;
			nint num = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S1_v43 (Il2CppClass<NGUITools>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S1_v69 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			byte[] array = NGUITools.Load(tag);
			if (array == null)
			{
				if (!wrapLineColors)
				{
					activeAnimation = null;
					return (byte)(int)activeAnimation != 0;
				}
				string tag2 = ((Component)(object)text).tag;
				nint num3 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S1_v51 (Il2CppClass<NGUITools>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(NGUITools);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S1_v65 (Il2CppClass<NGUITools>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				NGUITools.SetActiveChildren((GameObject)(object)tag2, state: true);
				string tag3 = ((Component)(object)text).tag;
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S2_v14 (Il2CppMethodInfo)+18]");
				object obj3 = 0;
				object obj4 = obj3;
				object obj5 = obj4 & 0x1FFF;
				object obj6 = obj5 + 22691;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v27 @ S3_v7 (should have been resolved before IL gen)");
				object obj7 = 0;
				object obj10 = default;
				while (true)
				{
					object obj8 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S0_v53+C]");
					if ((nint)obj8 >= 0)
					{
						break;
					}
					object obj9 = obj10 + 16;
					object obj11 = obj7 << 2;
					object obj12 = obj9 + obj11;
					((UIPanel)obj12)._002Ector();
					object obj13 = obj7 + 1;
					obj7 = obj13;
				}
			}
		}
		ActiveAnimation component = ((Component)(object)text).GetComponent<ActiveAnimation>();
		nint num6 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v13 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj14 = (nint)0 & (nint)0x200;
		if (obj14 != null)
		{
			nint num7 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v39 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = component != null;
		bool flag2 = !flag;
		activeAnimation = component;
		if (!flag2)
		{
			string tag4 = ((Component)(object)text).tag;
			ActiveAnimation activeAnimation2 = ((GameObject)(object)tag4).AddComponent<ActiveAnimation>();
			activeAnimation = activeAnimation2;
		}
		object obj15 = activeAnimation + 40;
		obj15 = text;
		activeAnimation.mDisableDirection = (useEllipsis ? Direction.Forward : Direction.Toggle);
		throw new IndexOutOfRangeException();
	}

	public unsafe static void Print(string text, List<Vector3> verts, List<Vector2> uvs, List<Color> cols)
	{
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected Obj, but got Unknown
		//IL_010e: Expected Obj, but got I4
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected VT, but got Unknown
		//IL_012f: Expected F4, but got Obj
		//IL_012a: Expected native int or pointer, but got VT
		//IL_0144: Expected F4, but got I
		//IL_013f: Expected native int or pointer, but got VT
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected Obj, but got Unknown
		//IL_0182: Expected F4, but got Obj
		//IL_017d: Expected native int or pointer, but got VT
		//IL_0194: Expected F4, but got I
		//IL_018f: Expected native int or pointer, but got VT
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_0204: Expected F4, but got Obj
		//IL_01ff: Expected native int or pointer, but got VT
		//IL_0219: Expected F4, but got I
		//IL_0214: Expected native int or pointer, but got VT
		//IL_0222: Expected Obj, but got VT
		//IL_00a0: Expected F4, but got Obj
		//IL_009b: Expected native int or pointer, but got VT
		//IL_00b5: Expected F4, but got I
		//IL_00b0: Expected native int or pointer, but got VT
		//IL_00c6: Expected Ref, but got VT
		object obj2 = default;
		object obj = obj2 + 24;
		obj = 0;
		_ = 0;
		Vector3 vector = (Vector3)(obj2 + 36);
		((Vector3*)(nint)vector)->x = (float)verts;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L1 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Transform transform = (Transform)(obj2 + 12);
		Vector3 vector2 = ((Camera)(object)uvs).ViewportToWorldPoint(vector);
		List<Vector3> list = (List<Vector3>)(object)transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		((Vector3*)(nint)vector)->x = (float)transform;
		((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
		Vector3 vector3 = ((Camera)(object)cols).ScreenToWorldPoint(vector);
		list = (List<Vector3>)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Transform parentInternal = ((Transform)(object)text).parentInternal;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v26 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v44 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)parentInternal).FindKernel((string)null) != 0)
		{
			((Vector3*)(nint)vector)->x = (float)verts;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L1 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+8]");
			((Vector3*)(nint)vector)->z = 0f;
			transform.Internal_LookAt_Injected(ref *(Vector3*)parentInternal, ref *(Vector3*)vector);
			obj = transform;
			_ = ((UnityEngine.Object)transform).m_CachedPtr;
		}
		else
		{
			obj = verts;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L1 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+8]");
			_ = 0;
		}
		((Vector3*)(nint)vector)->x = (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Vector3 eulerAngles = ((Transform)vector).eulerAngles;
	}

	public static void PrintApproximateCharacterPositions(string text, List<Vector3> verts, List<int> indices)
	{
		//IL_001a: Expected I4, but got Obj
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected Obj, but got Unknown
		//IL_004b: Expected I4, but got Obj
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected Obj, but got Unknown
		//IL_0097: Expected I4, but got Obj
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected Obj, but got Unknown
		//IL_00c8: Expected I4, but got Obj
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected Obj, but got Unknown
		//IL_0114: Expected I4, but got Obj
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected Obj, but got Unknown
		//IL_0145: Expected I4, but got Obj
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected Obj, but got Unknown
		//IL_0191: Expected I4, but got Obj
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected Obj, but got Unknown
		//IL_01c2: Expected I4, but got Obj
		//IL_01ef: Expected Obj, but got I4
		//IL_0215: Expected Obj, but got F4
		//IL_0247: Expected I4, but got F4
		//IL_0264: Expected I4, but got F4
		string[] array = ((string)(object)verts).Split((char[])(object)indices);
		char c = NGUIMath.DecimalToHexChar((int)array);
		char[] separator = (char[])(indices + 1);
		string[] array2 = ((string)(object)verts).Split(separator);
		char c2 = NGUIMath.DecimalToHexChar((int)array2);
		int num = (int)((uint)c << 4);
		int num2 = c2 | num;
		char[] separator2 = (char[])(indices + 2);
		string[] array3 = ((string)(object)verts).Split(separator2);
		char c3 = NGUIMath.DecimalToHexChar((int)array3);
		char[] separator3 = (char[])(indices + 3);
		string[] array4 = ((string)(object)verts).Split(separator3);
		char c4 = NGUIMath.DecimalToHexChar((int)array4);
		int num3 = (int)((uint)c3 << 4);
		int num4 = c4 | num3;
		char[] separator4 = (char[])(indices + 4);
		string[] array5 = ((string)(object)verts).Split(separator4);
		char c5 = NGUIMath.DecimalToHexChar((int)array5);
		char[] separator5 = (char[])(indices + 5);
		string[] array6 = ((string)(object)verts).Split(separator5);
		char c6 = NGUIMath.DecimalToHexChar((int)array6);
		int num5 = (int)((uint)c5 << 4);
		int num6 = c6 | num5;
		char[] separator6 = (char[])(indices + 6);
		string[] array7 = ((string)(object)verts).Split(separator6);
		char c7 = NGUIMath.DecimalToHexChar((int)array7);
		char[] separator7 = (char[])(indices + 7);
		string[] array8 = ((string)(object)verts).Split(separator7);
		char c8 = NGUIMath.DecimalToHexChar((int)array8);
		int num7 = (int)((uint)c7 << 4);
		int num8 = c8 | num7;
		string text2 = (string)0;
		text.m_stringLength = 0;
		float num9 = 1f / 255f * (float)num2;
		text2 = (string)num9;
		float num10 = 1f / 255f * (float)num4;
		float num11 = 1f / 255f * (float)num6;
		text.m_stringLength = (int)num11;
		float num12 = 1f / 255f * (float)num8;
		text.m_firstChar = (char)(int)num12;
	}

	public unsafe static void PrintExactCharacterPositions(string text, List<Vector3> verts, List<int> indices)
	{
		//IL_0b7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b83: Expected Obj, but got Unknown
		//IL_0b8c: Expected Obj, but got I4
		//IL_0b95: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9a: Expected Obj, but got Unknown
		//IL_0ba3: Expected Obj, but got I4
		//IL_0bac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb1: Expected Obj, but got Unknown
		//IL_0bba: Expected Obj, but got I4
		//IL_0bc3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc8: Expected Obj, but got Unknown
		//IL_0bd1: Expected Obj, but got I4
		//IL_0bda: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bdf: Expected Obj, but got Unknown
		//IL_0be8: Expected Obj, but got I4
		//IL_0bf1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf6: Expected Obj, but got Unknown
		//IL_0bff: Expected Obj, but got I4
		//IL_0c08: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c0d: Expected Obj, but got Unknown
		//IL_0c16: Expected Obj, but got I4
		//IL_0c41: Expected I, but got Obj
		//IL_0c57: Expected Obj, but got I
		//IL_1176: Unknown result type (might be due to invalid IL or missing references)
		//IL_117b: Expected VT, but got Unknown
		//IL_003a: Expected I, but got Obj
		//IL_0c97: Expected Obj, but got I4
		//IL_0ca0: Expected Obj, but got I4
		//IL_0ca9: Expected Obj, but got I4
		//IL_0cb2: Expected Obj, but got I4
		//IL_0cbb: Expected Obj, but got I4
		//IL_0cc4: Expected Obj, but got I4
		//IL_0a38: Expected I, but got Obj
		//IL_0a4e: Expected Obj, but got I
		//IL_00c4: Expected I, but got Obj
		//IL_00da: Expected Obj, but got I
		//IL_0a79: Expected I, but got Obj
		//IL_119d: Unknown result type (might be due to invalid IL or missing references)
		//IL_11a2: Expected Obj, but got Unknown
		//IL_11ab: Expected Obj, but got I4
		//IL_11b9: Expected Obj, but got F4
		//IL_11c2: Expected Obj, but got F4
		//IL_11f9: Expected F4, but got Obj
		//IL_11f4: Expected native int or pointer, but got VT
		//IL_120e: Expected F4, but got I
		//IL_1209: Expected native int or pointer, but got VT
		//IL_1228: Expected I4, but got Obj
		//IL_1231: Unknown result type (might be due to invalid IL or missing references)
		//IL_1236: Expected Obj, but got Unknown
		//IL_01a9: Expected I, but got Obj
		//IL_0af5: Expected I, but got Obj
		//IL_0b0b: Expected Obj, but got I
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_036c: Expected Obj, but got Unknown
		//IL_0138: Expected I, but got Obj
		//IL_01f6: Expected I, but got Obj
		//IL_020c: Expected Obj, but got I
		//IL_0b36: Expected I, but got Obj
		//IL_0e09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e0e: Expected Obj, but got Unknown
		//IL_03a2: Expected I, but got Obj
		//IL_03b8: Expected Obj, but got I
		//IL_0291: Expected I, but got Obj
		//IL_02a7: Expected Obj, but got I
		//IL_0237: Expected I, but got Obj
		//IL_129f: Expected I, but got Obj
		//IL_12b5: Expected Obj, but got I
		//IL_03e3: Expected I, but got Obj
		//IL_0430: Expected I, but got Obj
		//IL_0446: Expected Obj, but got I
		//IL_0d3e: Expected I, but got Obj
		//IL_0d54: Expected Obj, but got I
		//IL_02d2: Expected I, but got Obj
		//IL_130c: Expected I, but got Obj
		//IL_1322: Expected Obj, but got I
		//IL_04e2: Expected I, but got Obj
		//IL_052f: Expected I, but got Obj
		//IL_0545: Expected Obj, but got I
		//IL_0471: Expected I, but got Obj
		//IL_031f: Expected I, but got Obj
		//IL_0820: Expected I, but got Obj
		//IL_0836: Expected Obj, but got I
		//IL_07c6: Expected I, but got Obj
		//IL_0e51: Expected VT, but got I4
		//IL_04b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04be: Expected Obj, but got Unknown
		//IL_0570: Expected I, but got Obj
		//IL_0861: Expected I, but got Obj
		//IL_05bd: Expected I, but got Obj
		//IL_05d3: Expected Obj, but got I
		//IL_1410: Expected Obj, but got I4
		//IL_141e: Expected Obj, but got F4
		//IL_1445: Expected F4, but got Obj
		//IL_1440: Expected native int or pointer, but got VT
		//IL_145a: Expected F4, but got I
		//IL_1455: Expected native int or pointer, but got VT
		//IL_1470: Unknown result type (might be due to invalid IL or missing references)
		//IL_1475: Expected I4, but got Unknown
		//IL_05fe: Expected I, but got Obj
		//IL_08cb: Expected I, but got Obj
		//IL_08e1: Expected Obj, but got I
		//IL_1348: Expected Obj, but got I4
		//IL_1356: Expected Obj, but got F4
		//IL_137d: Expected F4, but got Obj
		//IL_1378: Expected native int or pointer, but got VT
		//IL_1392: Expected F4, but got I
		//IL_138d: Expected native int or pointer, but got VT
		//IL_13a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_13ad: Expected I4, but got Unknown
		//IL_13ca: Expected Obj, but got I
		//IL_13e0: Expected Obj, but got I
		//IL_1070: Expected I, but got Obj
		//IL_1086: Expected Obj, but got I
		//IL_090c: Expected I, but got Obj
		//IL_0668: Expected I, but got Obj
		//IL_067e: Expected Obj, but got I
		//IL_10f8: Expected Obj, but got F4
		//IL_09da: Expected I, but got Obj
		//IL_0f09: Expected I, but got Obj
		//IL_0f1f: Expected Obj, but got I
		//IL_06a9: Expected I, but got Obj
		//IL_0966: Expected I, but got Obj
		//IL_097c: Expected Obj, but got I
		//IL_0f91: Expected Obj, but got F4
		//IL_0777: Expected I, but got Obj
		//IL_09a7: Expected I, but got Obj
		//IL_0703: Expected I, but got Obj
		//IL_0719: Expected Obj, but got I
		//IL_0744: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		obj = 0;
		object obj3 = obj2 + 36;
		obj3 = 0;
		object obj4 = obj2 + 35;
		obj4 = 0;
		object obj5 = obj2 + 34;
		obj5 = 0;
		object obj6 = obj2 + 33;
		obj6 = 0;
		object obj7 = obj2 + 32;
		obj7 = 0;
		object obj8 = obj2 + 12;
		obj8 = 0;
		bool flag = text == null || text.m_stringLength == 0;
		nint num = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S1_v20 (Il2CppClass<NGUIText>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num2 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S1_v174 (Il2CppClass<NGUIText>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector = (Vector3)(obj2 + 20);
		string text2;
		ref StringBuilder s;
		if (flag)
		{
			text2 = " ";
			s = ref *(StringBuilder*)" ";
		}
		else
		{
			text2 = text;
			s = ref *(StringBuilder*)text;
		}
		EndLine(ref s);
		float num3 = (float)regionWidth + 0.01f;
		obj = 0;
		obj3 = 0;
		obj4 = 0;
		obj5 = 0;
		obj6 = 0;
		obj7 = 0;
		char[] array = null;
		string text3 = null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L1 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+C]");
		int num4 = 0;
		float num9 = default;
		float num10 = default;
		object obj19 = default;
		while (true)
		{
			obj8 = array;
			if ((nint)array >= text2.m_stringLength)
			{
				break;
			}
			string[] array2 = text2.Split(array);
			nint num5 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ S0_v84 (Il2CppClass<NGUIText>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			bool flag2 = obj10 == null;
			float num7;
			if (obj != null)
			{
				if (!flag2)
				{
					nint num6 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ S0_v404 (Il2CppClass<NGUIText>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				num7 = fontScale * 0.75f;
			}
			else
			{
				if (!flag2)
				{
					nint num8 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ S0_v391 (Il2CppClass<NGUIText>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				num7 = fontScale;
			}
			JsonDict jsonDict = (JsonDict)(array2 & 0xFFFF);
			obj2 = 0;
			_ = 0;
			obj2 = num9;
			object obj11 = 0f - num10;
			float num11 = num7 * 0.5f;
			float num12 = (float)obj11 - num11;
			_ = 0f;
			((Vector3*)(nint)vector)->x = (float)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((Vector3*)(nint)vector)->z = 0f;
			verts.Add(vector);
			indices.Add((int)obj8);
			object obj12 = array2 & 0xFFFF;
			string text4;
			if ((nint)obj12 == 10)
			{
				nint num13 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ S0_v352 (Il2CppClass<NGUIText>)+BA]");
				object obj13 = (nint)0 & (nint)0x200;
				if (obj13 != null)
				{
					nint num14 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ S0_v379 (Il2CppClass<NGUIText>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				int num15;
				if (alignment == Alignment.Left)
				{
					num15 = num4;
				}
				else
				{
					nint num16 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ S0_v363 (Il2CppClass<NGUIText>)+BA]");
					object obj14 = (nint)0 & (nint)0x200;
					if (obj14 != null)
					{
						nint num17 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v513 @ S0_v372 (Il2CppClass<NGUIText>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					float completedFactor = num9 - finalSpacingX;
					((MissionsManager)(object)verts).Complete(num4, completedFactor, true);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L1 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+C]");
					num15 = 0;
				}
				nint num18 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ S1_v158 (Il2CppClass<NGUIText>)+BA]");
				object obj15 = (nint)0 & (nint)0x200;
				if (obj15 != null)
				{
					nint num19 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v549 @ S1_v165 (Il2CppClass<NGUIText>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float num20 = num10 + finalLineHeight;
				num9 = 0f;
				num10 = num20;
				num4 = num15;
				text4 = null;
			}
			else
			{
				object obj16 = array2 & 0xFFFF;
				if ((nint)obj16 > 31)
				{
					nint num21 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ S0_v116 (Il2CppClass<NGUIText>)+BA]");
					object obj17 = (nint)0 & (nint)0x200;
					if (obj17 != null)
					{
						nint num22 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ S0_v345 (Il2CppClass<NGUIText>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (~(encoding ? 1u : 0u) == 0)
					{
						nint num23 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v527 @ S0_v331 (Il2CppClass<NGUIText>)+BA]");
						object obj18 = (nint)0 & (nint)0x200;
						if (obj18 != null)
						{
							nint num24 = (nint)typeof(NGUIText);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v566 @ S0_v339 (Il2CppClass<NGUIText>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						bool flag3 = premultiply;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B752");
						if (obj19 != null)
						{
							object obj20 = obj8 - 1;
							obj8 = obj20;
							text4 = text3;
							goto IL_0e00;
						}
					}
					nint num25 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ S0_v125 (Il2CppClass<NGUIText>)+BA]");
					object obj21 = (nint)0 & (nint)0x200;
					if (obj21 != null)
					{
						nint num26 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v582 @ S0_v324 (Il2CppClass<NGUIText>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (~(useSymbols ? 1u : 0u) == 0)
					{
						nint num27 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v603 @ S0_v231 (Il2CppClass<NGUIText>)+BA]");
						object obj22 = (nint)0 & (nint)0x200;
						if (obj22 != null)
						{
							nint num28 = (nint)typeof(NGUIText);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v633 @ S0_v320 (Il2CppClass<NGUIText>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						if (GetExactCharacterIndex((List<Vector3>)(object)text2, (List<int>)obj8, (Vector2)text2.m_stringLength) != 0)
						{
							nint num29 = (nint)typeof(NGUIText);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v660 @ S0_v240 (Il2CppClass<NGUIText>)+BA]");
							object obj23 = (nint)0 & (nint)0x200;
							if (obj23 != null)
							{
								nint num30 = (nint)typeof(NGUIText);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v674 @ S0_v314 (Il2CppClass<NGUIText>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v619 @ S0_v236 (System.Int32)+2C]");
							float num31 = 0f * num7;
							float num32 = num31 + finalSpacingX;
							float num33 = num9 + num32;
							object obj28;
							float num42;
							if (num33 > num3)
							{
								if (num9 == 0f)
								{
									return;
								}
								nint num34 = (nint)typeof(NGUIText);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v742 @ S0_v266 (Il2CppClass<NGUIText>)+BA]");
								object obj24 = (nint)0 & (nint)0x200;
								if (obj24 != null)
								{
									nint num35 = (nint)typeof(NGUIText);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v830 @ S0_v309 (Il2CppClass<NGUIText>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								if (alignment != Alignment.Left)
								{
									int num36 = num4;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L1 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+C]");
									if ((nint)num36 < (nint)0)
									{
										nint num37 = (nint)typeof(NGUIText);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v925 @ S0_v295 (Il2CppClass<NGUIText>)+BA]");
										object obj25 = (nint)0 & (nint)0x200;
										if (obj25 != null)
										{
											nint num38 = (nint)typeof(NGUIText);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v961 @ S0_v304 (Il2CppClass<NGUIText>)+74]");
											if ((nint)0 == 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
											}
										}
										float completedFactor2 = num9 - finalSpacingX;
										((MissionsManager)(object)verts).Complete(num4, completedFactor2, true);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L1 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+C]");
										num4 = 0;
									}
								}
								nint num39 = (nint)typeof(NGUIText);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v886 @ S0_v276 (Il2CppClass<NGUIText>)+BA]");
								object obj26 = (nint)0 & (nint)0x200;
								if (obj26 != null)
								{
									nint num40 = (nint)typeof(NGUIText);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v930 @ S0_v285 (Il2CppClass<NGUIText>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								float num41 = num10 + finalLineHeight;
								object obj27 = 0f - num41;
								num10 = num41;
								obj28 = obj27;
								num42 = num32;
							}
							else
							{
								num42 = num9 + num32;
								obj28 = obj11;
							}
							obj2 = 0;
							_ = 0;
							obj2 = num42;
							float num43 = (float)obj28 - num11;
							_ = 0f;
							((Vector3*)(nint)vector)->x = (float)obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
							((Vector3*)(nint)vector)->z = 0f;
							verts.Add(vector);
							int item = obj8 + 1;
							indices.Add(item);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v619 @ S0_v236 (System.Int32)+8]");
							object obj29 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v893 @ S1_v132+8]");
							object obj30 = -1;
							object obj31 = obj30 + obj8;
							obj8 = obj31;
							num9 = num42;
							text4 = null;
							goto IL_0e00;
						}
					}
					nint num44 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v621 @ S0_v134 (Il2CppClass<NGUIText>)+BA]");
					object obj32 = (nint)0 & (nint)0x200;
					if (obj32 != null)
					{
						nint num45 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v641 @ S0_v223 (Il2CppClass<NGUIText>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					float num46 = jsonDict.GetFloat(text3, num7);
					if (num46 == 0f)
					{
						text4 = text3;
					}
					else
					{
						nint num47 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v668 @ S0_v143 (Il2CppClass<NGUIText>)+BA]");
						object obj33 = (nint)0 & (nint)0x200;
						if (obj33 != null)
						{
							nint num48 = (nint)typeof(NGUIText);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v707 @ S0_v216 (Il2CppClass<NGUIText>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						float num49 = num46 + finalSpacingX;
						float num50 = num9 + num49;
						object obj38;
						float num59;
						if (num50 > num3)
						{
							if (num9 == 0f)
							{
								return;
							}
							nint num51 = (nint)typeof(NGUIText);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v787 @ S0_v168 (Il2CppClass<NGUIText>)+BA]");
							object obj34 = (nint)0 & (nint)0x200;
							if (obj34 != null)
							{
								nint num52 = (nint)typeof(NGUIText);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v849 @ S0_v211 (Il2CppClass<NGUIText>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							if (alignment != Alignment.Left)
							{
								int num53 = num4;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L1 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+C]");
								if ((nint)num53 < (nint)0)
								{
									nint num54 = (nint)typeof(NGUIText);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v944 @ S0_v197 (Il2CppClass<NGUIText>)+BA]");
									object obj35 = (nint)0 & (nint)0x200;
									if (obj35 != null)
									{
										nint num55 = (nint)typeof(NGUIText);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v972 @ S0_v206 (Il2CppClass<NGUIText>)+74]");
										if ((nint)0 == 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
										}
									}
									float completedFactor3 = num9 - finalSpacingX;
									((MissionsManager)(object)verts).Complete(num4, completedFactor3, true);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L1 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+C]");
									num4 = 0;
								}
							}
							nint num56 = (nint)typeof(NGUIText);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v918 @ S0_v178 (Il2CppClass<NGUIText>)+BA]");
							object obj36 = (nint)0 & (nint)0x200;
							if (obj36 != null)
							{
								nint num57 = (nint)typeof(NGUIText);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v949 @ S0_v187 (Il2CppClass<NGUIText>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							float num58 = num10 + finalLineHeight;
							object obj37 = 0f - num58;
							num10 = num58;
							obj38 = obj37;
							num59 = num49;
						}
						else
						{
							num59 = num9 + num49;
							obj38 = obj11;
						}
						obj2 = 0;
						_ = 0;
						obj2 = num59;
						float num60 = (float)obj38 - num11;
						_ = 0f;
						((Vector3*)(nint)vector)->x = (float)obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
						((Vector3*)(nint)vector)->z = 0f;
						verts.Add(vector);
						int item2 = obj8 + 1;
						indices.Add(item2);
						num9 = num59;
						text4 = (string)(object)jsonDict;
					}
				}
				else
				{
					text4 = null;
				}
			}
			goto IL_0e00;
			IL_0e00:
			char[] array3 = (char[])(obj8 + 1);
			array = array3;
			text3 = text4;
		}
		nint num61 = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ S0_v51 (Il2CppClass<NGUIText>)+BA]");
		object obj39 = (nint)0 & (nint)0x200;
		if (obj39 != null)
		{
			nint num62 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ S0_v75 (Il2CppClass<NGUIText>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (alignment == Alignment.Left)
		{
			return;
		}
		int num63 = num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L1 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+C]");
		if ((nint)num63 >= (nint)0)
		{
			return;
		}
		nint num64 = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ S0_v64 (Il2CppClass<NGUIText>)+BA]");
		object obj40 = (nint)0 & (nint)0x200;
		if (obj40 != null)
		{
			nint num65 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ S0_v69 (Il2CppClass<NGUIText>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float completedFactor4 = num9 - finalSpacingX;
		((MissionsManager)(object)verts).Complete(num4, completedFactor4, true);
	}

	public unsafe static void PrintCaretAndSelection(string text, int start, int end, List<Vector3> caret, List<Vector3> highlight)
	{
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected VT, but got Unknown
		//IL_0198: Expected F4, but got I4
		//IL_0193: Expected native int or pointer, but got VT
		//IL_01ad: Expected F4, but got I
		//IL_01a8: Expected native int or pointer, but got VT
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected Obj, but got Unknown
		//IL_01c8: Expected Obj, but got I4
		//IL_01d9: Expected I4, but got Obj
		//IL_01f3: Expected F4, but got Obj
		//IL_01ee: Expected native int or pointer, but got VT
		//IL_0208: Expected F4, but got I
		//IL_0203: Expected native int or pointer, but got VT
		//IL_0226: Expected I4, but got Obj
		//IL_0241: Expected I, but got Obj
		//IL_0257: Expected Obj, but got I
		//IL_0094: Expected I, but got Obj
		//IL_00aa: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_005f: Expected Obj, but got I4
		//IL_014d: Expected F4, but got I4
		//IL_0148: Expected native int or pointer, but got VT
		//IL_0162: Expected F4, but got I
		//IL_015d: Expected native int or pointer, but got VT
		//IL_0173: Expected Ref, but got VT
		//IL_00d5: Expected I, but got Obj
		//IL_0121: Expected Obj, but got I4
		object obj = default;
		Vector3 vector = (Vector3)(obj + 24);
		((Vector3*)(nint)vector)->x = ((int*)start)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [start @ L1 (System.Int32)+8]");
		((Vector3*)(nint)vector)->z = 0f;
		object obj2 = obj + 12;
		Vector3 vector2 = ((Camera)end).ViewportToWorldPoint(vector);
		((int*)start)->m_value = (int)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v12+8]");
		_ = 0;
		((Vector3*)(nint)vector)->x = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v12+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Vector3 vector3 = ((Camera)(object)caret).ScreenToWorldPoint(vector);
		((int*)start)->m_value = (int)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v21 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v49 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if ((UnityEngine.Object)(object)highlight != null)
		{
			string text2 = (string)((int*)start)->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [start @ L1 (System.Int32)+8]");
			text.m_stringLength = 0;
			return;
		}
		Transform parentInternal = ((Transform)(object)highlight).parentInternal;
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v32 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v43 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (parentInternal != null)
		{
			string text2 = (string)((int*)start)->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [start @ L1 (System.Int32)+8]");
			text.m_stringLength = 0;
		}
		else
		{
			((Vector3*)(nint)vector)->x = ((int*)start)->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [start @ L1 (System.Int32)+8]");
			((Vector3*)(nint)vector)->z = 0f;
			((Transform)(object)text).Internal_LookAt_Injected(ref *(Vector3*)parentInternal, ref *(Vector3*)vector);
		}
	}

	public unsafe static bool ReplaceLink(ref string text, ref int index, string type, string prefix = null, string suffix = null)
	{
		//IL_2392: Unknown result type (might be due to invalid IL or missing references)
		//IL_2397: Expected Obj, but got Unknown
		//IL_23a0: Expected Obj, but got I4
		//IL_23a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_23ae: Expected Obj, but got Unknown
		//IL_23b7: Expected Obj, but got I4
		//IL_23c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_23c5: Expected Obj, but got Unknown
		//IL_23ce: Expected Obj, but got I4
		//IL_23ed: Expected native int or pointer, but got F4
		//IL_23fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_2400: Expected I4, but got Unknown
		//IL_2417: Unknown result type (might be due to invalid IL or missing references)
		//IL_241c: Expected Obj, but got Unknown
		//IL_2425: Expected Obj, but got I4
		//IL_242e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2433: Expected Obj, but got Unknown
		//IL_243c: Expected Obj, but got I4
		//IL_2445: Unknown result type (might be due to invalid IL or missing references)
		//IL_244a: Expected Obj, but got Unknown
		//IL_2453: Expected Obj, but got I4
		//IL_245c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2461: Expected Obj, but got Unknown
		//IL_246a: Expected Obj, but got I4
		//IL_2478: Expected I, but got Obj
		//IL_248e: Expected Obj, but got I
		//IL_368b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3690: Expected VT, but got Unknown
		//IL_3699: Unknown result type (might be due to invalid IL or missing references)
		//IL_369e: Expected VT, but got Unknown
		//IL_36a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_36ac: Expected Obj, but got Unknown
		//IL_36b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_36ba: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_012f: Expected I, but got Obj
		//IL_017c: Expected I, but got Obj
		//IL_0192: Expected Obj, but got I
		//IL_01af: Expected I, but got Obj
		//IL_24fd: Expected Obj, but got I
		//IL_251a: Expected I, but got Obj
		//IL_2530: Expected Obj, but got I
		//IL_01cb: Expected I, but got Obj
		//IL_01fb: Expected I, but got Obj
		//IL_371e: Expected I, but got Obj
		//IL_3734: Expected Obj, but got I
		//IL_3751: Expected I, but got Obj
		//IL_0331: Expected I, but got Obj
		//IL_2566: Expected I, but got Obj
		//IL_257c: Expected Obj, but got I
		//IL_258a: Expected I, but got Obj
		//IL_25a0: Expected Obj, but got I
		//IL_0221: Expected I, but got Obj
		//IL_3aad: Expected Obj, but got I
		//IL_36f1: Invalid comparison between I4 and F4
		//IL_0258: Expected I, but got Obj
		//IL_049a: Expected F4, but got I4
		//IL_037e: Expected I, but got Obj
		//IL_03ae: Expected I, but got Obj
		//IL_02a5: Expected I, but got Obj
		//IL_376d: Expected I, but got Obj
		//IL_3783: Expected Obj, but got I
		//IL_03e7: Expected I, but got Obj
		//IL_03fd: Expected Obj, but got I
		//IL_041a: Expected I, but got Obj
		//IL_25c5: Expected I4, but got F4
		//IL_02ed: Expected F4, but got I4
		//IL_2609: Expected I, but got Obj
		//IL_261f: Expected Obj, but got I
		//IL_25ee: Expected Obj, but got I
		//IL_25f6: Expected F4, but got Obj
		//IL_03d4: Expected I, but got Obj
		//IL_04ad: Expected I, but got Obj
		//IL_0436: Expected I, but got Obj
		//IL_0466: Expected I, but got Obj
		//IL_04fa: Expected I, but got Obj
		//IL_048c: Expected I, but got Obj
		//IL_26ad: Expected I, but got Obj
		//IL_26c3: Expected Obj, but got I
		//IL_0622: Expected Obj, but got I4
		//IL_0630: Expected I, but got Obj
		//IL_0646: Expected Obj, but got I
		//IL_0653: Expected F4, but got Obj
		//IL_064e: Expected native int or pointer, but got VT
		//IL_0668: Expected F4, but got I
		//IL_0663: Expected native int or pointer, but got VT
		//IL_0675: Expected Obj, but got F4
		//IL_0688: Expected native int or pointer, but got F4
		//IL_06a4: Expected Obj, but got I4
		//IL_06ad: Expected Obj, but got I4
		//IL_06b6: Expected Obj, but got I4
		//IL_06bf: Expected Obj, but got I4
		//IL_06cd: Expected I, but got Obj
		//IL_06e3: Expected Obj, but got I
		//IL_05d2: Expected I, but got Obj
		//IL_272c: Expected I, but got Obj
		//IL_2742: Expected Obj, but got I
		//IL_0798: Expected I, but got Obj
		//IL_26f4: Expected Obj, but got I4
		//IL_26f4: Expected Obj, but got I4
		//IL_3805: Expected F4, but got Obj
		//IL_3800: Expected native int or pointer, but got VT
		//IL_381a: Expected F4, but got I
		//IL_3815: Expected native int or pointer, but got VT
		//IL_3843: Unknown result type (might be due to invalid IL or missing references)
		//IL_3848: Expected Obj, but got Unknown
		//IL_0741: Expected I, but got Obj
		//IL_08bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c0: Expected Obj, but got Unknown
		//IL_08c8: Expected F4, but got I4
		//IL_08e2: Expected Obj, but got I4
		//IL_07cb: Expected I, but got Obj
		//IL_0829: Expected F4, but got Obj
		//IL_0824: Expected native int or pointer, but got VT
		//IL_083e: Expected F4, but got I
		//IL_0839: Expected native int or pointer, but got VT
		//IL_084c: Expected I, but got Obj
		//IL_0862: Expected Obj, but got I
		//IL_277a: Expected native int or pointer, but got VT
		//IL_278c: Expected native int or pointer, but got VT
		//IL_27c6: Expected I, but got Obj
		//IL_090f: Expected Obj, but got Ref
		//IL_0921: Expected I, but got Obj
		//IL_0937: Expected Obj, but got I
		//IL_088d: Expected I, but got Obj
		//IL_3a64: Expected I, but got Obj
		//IL_3a7a: Expected Obj, but got I
		//IL_214f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2154: Expected I4, but got Unknown
		//IL_2165: Expected Obj, but got Ref
		//IL_27d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_27d9: Expected Obj, but got Unknown
		//IL_27ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_27f4: Expected Obj, but got Unknown
		//IL_280b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2810: Expected Obj, but got Unknown
		//IL_2827: Unknown result type (might be due to invalid IL or missing references)
		//IL_282c: Expected Obj, but got Unknown
		//IL_21aa: Expected I, but got Obj
		//IL_21c0: Expected Obj, but got I
		//IL_0bf1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf6: Expected Obj, but got Unknown
		//IL_0c04: Expected I, but got Obj
		//IL_0c1a: Expected Obj, but got I
		//IL_0962: Expected I, but got Obj
		//IL_2235: Expected I, but got Obj
		//IL_21eb: Expected I, but got Obj
		//IL_2a5c: Expected I, but got Obj
		//IL_2a72: Expected Obj, but got I
		//IL_0c45: Expected I, but got Obj
		//IL_0c78: Expected I, but got Obj
		//IL_0c8e: Expected Obj, but got I
		//IL_2295: Expected I, but got Obj
		//IL_22ab: Expected Obj, but got I
		//IL_22c8: Expected I, but got Obj
		//IL_1032: Expected I, but got Obj
		//IL_09dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e1: Expected Obj, but got Unknown
		//IL_09ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ef: Expected I4, but got Unknown
		//IL_0a00: Expected Obj, but got Ref
		//IL_3604: Expected Obj, but got I
		//IL_3612: Expected I, but got Obj
		//IL_3628: Expected Obj, but got I
		//IL_2e18: Expected I, but got Obj
		//IL_2e2e: Expected Obj, but got I
		//IL_2e41: Expected native int or pointer, but got F4
		//IL_2e4b: Invalid comparison between F4 and I4
		//IL_1065: Expected I, but got Obj
		//IL_107b: Expected Obj, but got I
		//IL_0cb9: Expected I, but got Obj
		//IL_388f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3894: Expected I4, but got Unknown
		//IL_38c3: Expected Obj, but got I4
		//IL_22e4: Expected I, but got Obj
		//IL_22f2: Expected I, but got Obj
		//IL_2df8: Expected VT, but got I
		//IL_2df8: Expected Obj, but got Ref
		//IL_0cf7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cfc: Expected Obj, but got Unknown
		//IL_0d05: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d0a: Expected Obj, but got Unknown
		//IL_0d12: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d17: Expected Obj, but got Unknown
		//IL_0a65: Expected Obj, but got I4
		//IL_2333: Expected I, but got Obj
		//IL_10a6: Expected I, but got Obj
		//IL_1f2a: Expected Obj, but got I4
		//IL_1f33: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f38: Expected I4, but got Unknown
		//IL_1f49: Expected Obj, but got Ref
		//IL_2dad: Unknown result type (might be due to invalid IL or missing references)
		//IL_2db2: Expected Obj, but got Unknown
		//IL_289a: Expected I, but got Obj
		//IL_28b0: Expected Obj, but got I
		//IL_2360: Expected I4, but got Obj
		//IL_2320: Expected I, but got Obj
		//IL_3984: Expected I, but got Obj
		//IL_399a: Expected Obj, but got I
		//IL_1162: Expected I, but got Obj
		//IL_1f67: Expected native int or pointer, but got F4
		//IL_1f71: Expected I4, but got F4
		//IL_0d42: Expected Obj, but got I4
		//IL_110b: Expected I, but got Obj
		//IL_2aa2: Expected native int or pointer, but got F4
		//IL_2aab: Expected I4, but got F4
		//IL_0b0f: Expected Obj, but got I4
		//IL_0a78: Expected I, but got Obj
		//IL_0d79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d7e: Expected I4, but got Unknown
		//IL_0d8f: Expected Obj, but got Ref
		//IL_29c0: Expected I, but got Obj
		//IL_29d6: Expected Obj, but got I
		//IL_0aa5: Expected I, but got Obj
		//IL_0ac2: Expected Obj, but got I
		//IL_0acb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad0: Expected I4, but got Unknown
		//IL_0ae2: Expected I4, but got Obj
		//IL_0ae2: Expected Obj, but got I
		//IL_0aef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af4: Expected Obj, but got Unknown
		//IL_0b01: Expected I, but got Obj
		//IL_1269: Expected I, but got Obj
		//IL_127f: Expected Obj, but got I
		//IL_1210: Expected I, but got Obj
		//IL_2ebd: Expected F4, but got I4
		//IL_0fe7: Expected I4, but got Obj
		//IL_0dc5: Expected I, but got Obj
		//IL_0ddb: Expected Obj, but got I
		//IL_0db2: Expected I4, but got Obj
		//IL_1256: Expected I, but got F4
		//IL_11b9: Expected I, but got Obj
		//IL_1001: Unknown result type (might be due to invalid IL or missing references)
		//IL_1006: Expected Obj, but got Unknown
		//IL_1017: Expected I4, but got Obj
		//IL_101f: Expected I4, but got Obj
		//IL_0f9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa1: Expected I4, but got Unknown
		//IL_0fb2: Expected Obj, but got Ref
		//IL_0e82: Expected I, but got Obj
		//IL_0b22: Expected I, but got Obj
		//IL_12aa: Expected I, but got Obj
		//IL_3af1: Expected I4, but got Obj
		//IL_2bc6: Expected Obj, but got I
		//IL_2c03: Expected Obj, but got I
		//IL_2c13: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c18: Expected Obj, but got Unknown
		//IL_2c3a: Expected F4, but got Obj
		//IL_2c35: Expected native int or pointer, but got VT
		//IL_2c4f: Expected F4, but got I
		//IL_2c4a: Expected native int or pointer, but got VT
		//IL_2c5c: Expected F4, but got Obj
		//IL_2c57: Expected native int or pointer, but got VT
		//IL_2c71: Expected F4, but got I
		//IL_2c6c: Expected native int or pointer, but got VT
		//IL_2ca0: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ca5: Expected Obj, but got Unknown
		//IL_2cbd: Expected Obj, but got F4
		//IL_2cc5: Expected F4, but got Obj
		//IL_0b67: Expected I, but got Obj
		//IL_0b7d: Expected Obj, but got I
		//IL_1361: Expected F4, but got I4
		//IL_12dd: Expected I, but got Obj
		//IL_12f3: Expected Obj, but got I
		//IL_38d6: Expected I, but got Obj
		//IL_38ec: Expected Obj, but got I
		//IL_0e9e: Expected I, but got Obj
		//IL_0eac: Expected I, but got Obj
		//IL_2ae1: Expected Obj, but got I
		//IL_2af1: Unknown result type (might be due to invalid IL or missing references)
		//IL_2af6: Expected Obj, but got Unknown
		//IL_2b03: Expected F4, but got Obj
		//IL_2afe: Expected native int or pointer, but got VT
		//IL_2b18: Expected F4, but got I
		//IL_2b13: Expected native int or pointer, but got VT
		//IL_2b25: Expected Obj, but got F4
		//IL_2b38: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b3d: Expected Obj, but got Unknown
		//IL_2b4b: Expected I, but got Obj
		//IL_2ba2: Expected Obj, but got F4
		//IL_2baa: Expected F4, but got Obj
		//IL_291c: Expected Obj, but got I
		//IL_292a: Expected I, but got Obj
		//IL_2932: Unknown result type (might be due to invalid IL or missing references)
		//IL_2937: Expected Obj, but got Unknown
		//IL_2944: Expected F4, but got Obj
		//IL_293f: Expected native int or pointer, but got VT
		//IL_2959: Expected F4, but got I
		//IL_2954: Expected native int or pointer, but got VT
		//IL_2966: Expected native int or pointer, but got VT
		//IL_2978: Expected native int or pointer, but got VT
		//IL_2f5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f61: Expected Obj, but got Unknown
		//IL_2f69: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f6e: Expected I4, but got Unknown
		//IL_2cf2: Expected Obj, but got I
		//IL_0e39: Expected I, but got Obj
		//IL_0bd6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bdb: Expected Obj, but got Unknown
		//IL_0ba8: Expected I, but got Obj
		//IL_15a2: Expected I, but got F4
		//IL_15aa: Expected I4, but got Obj
		//IL_131e: Expected I, but got Obj
		//IL_0eed: Expected I, but got Obj
		//IL_0eda: Expected I, but got Obj
		//IL_3007: Unknown result type (might be due to invalid IL or missing references)
		//IL_300c: Expected I4, but got Unknown
		//IL_136e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1373: Expected Obj, but got Unknown
		//IL_1391: Expected Obj, but got I4
		//IL_13af: Unknown result type (might be due to invalid IL or missing references)
		//IL_13b4: Expected Obj, but got Unknown
		//IL_0f1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f20: Expected Obj, but got Unknown
		//IL_0f2e: Expected I, but got Obj
		//IL_0f44: Expected Obj, but got I
		//IL_152d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1532: Expected I4, but got Unknown
		//IL_1543: Expected Obj, but got Ref
		//IL_13e6: Expected Obj, but got Ref
		//IL_13f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f8: Expected Obj, but got Unknown
		//IL_1401: Unknown result type (might be due to invalid IL or missing references)
		//IL_1406: Expected Obj, but got Unknown
		//IL_2d1f: Expected Obj, but got I
		//IL_2d35: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d3a: Expected Obj, but got Unknown
		//IL_2d47: Expected F4, but got Obj
		//IL_2d42: Expected native int or pointer, but got VT
		//IL_2d5c: Expected F4, but got I
		//IL_2d57: Expected native int or pointer, but got VT
		//IL_2d78: Expected Obj, but got F4
		//IL_2d8e: Expected F4, but got Obj
		//IL_1566: Unknown result type (might be due to invalid IL or missing references)
		//IL_156b: Expected I4, but got Unknown
		//IL_1573: Expected I4, but got Obj
		//IL_157c: Expected Obj, but got I4
		//IL_14c9: Invalid comparison between F4 and I4
		//IL_14ee: Expected Obj, but got I4
		//IL_14f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_14fb: Expected Obj, but got Unknown
		//IL_1511: Unknown result type (might be due to invalid IL or missing references)
		//IL_1516: Expected Obj, but got Unknown
		//IL_14ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_14b3: Expected Obj, but got Unknown
		//IL_0f6f: Expected I, but got Obj
		//IL_143f: Expected I, but got Obj
		//IL_1455: Expected Obj, but got I
		//IL_3082: Unknown result type (might be due to invalid IL or missing references)
		//IL_3087: Expected Obj, but got Unknown
		//IL_3554: Expected Obj, but got I
		//IL_355c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3561: Expected Obj, but got Unknown
		//IL_1fde: Expected Obj, but got I4
		//IL_1fe7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fec: Expected I4, but got Unknown
		//IL_1ffd: Expected Obj, but got Ref
		//IL_1480: Expected I, but got Obj
		//IL_1ef6: Expected Obj, but got I
		//IL_1a05: Expected I, but got Obj
		//IL_1a1b: Expected Obj, but got I
		//IL_16c6: Expected Obj, but got I4
		//IL_16ea: Expected I, but got Obj
		//IL_1700: Expected Obj, but got I
		//IL_209d: Expected Obj, but got I4
		//IL_20a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_20ab: Expected I4, but got Unknown
		//IL_20bc: Expected Obj, but got Ref
		//IL_1625: Expected Obj, but got I4
		//IL_1625: Expected Obj, but got Ref
		//IL_1637: Expected I, but got Obj
		//IL_164d: Expected Obj, but got I
		//IL_1a46: Expected I, but got Obj
		//IL_30ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_30b2: Expected Obj, but got Unknown
		//IL_32e5: Expected Obj, but got Ref
		//IL_3302: Unknown result type (might be due to invalid IL or missing references)
		//IL_3307: Expected I4, but got Unknown
		//IL_17b5: Expected I, but got Obj
		//IL_1678: Expected I, but got Obj
		//IL_183f: Expected Obj, but got I4
		//IL_175e: Expected I, but got Obj
		//IL_1a94: Expected I, but got Obj
		//IL_1aaa: Expected Obj, but got I
		//IL_313e: Expected I, but got Obj
		//IL_3154: Expected Obj, but got I
		//IL_1818: Expected Obj, but got I4
		//IL_1b1f: Expected I, but got Obj
		//IL_1b35: Expected Obj, but got I
		//IL_1ad5: Expected I, but got Obj
		//IL_18e9: Expected Obj, but got I4
		//IL_1852: Expected I, but got Obj
		//IL_326c: Expected I, but got Obj
		//IL_3282: Expected Obj, but got I
		//IL_187f: Expected I, but got Obj
		//IL_189c: Expected Obj, but got I
		//IL_18a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_18aa: Expected I4, but got Unknown
		//IL_18bc: Expected I4, but got Obj
		//IL_18bc: Expected Obj, but got I
		//IL_18c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_18ce: Expected Obj, but got Unknown
		//IL_18db: Expected I, but got Obj
		//IL_1bea: Expected I, but got Obj
		//IL_1b93: Expected I, but got Obj
		//IL_19d9: Expected Obj, but got I4
		//IL_18fc: Expected I, but got Obj
		//IL_1e1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e20: Expected I4, but got Unknown
		//IL_1e29: Expected Obj, but got I4
		//IL_1e3e: Expected I4, but got Obj
		//IL_1e46: Expected I4, but got Obj
		//IL_1c3e: Expected Obj, but got I4
		//IL_1941: Expected I, but got Obj
		//IL_1957: Expected Obj, but got I
		//IL_1dd8: Expected Obj, but got I4
		//IL_1de5: Expected I4, but got Obj
		//IL_1ded: Expected I4, but got Obj
		//IL_1df5: Expected I4, but got Obj
		//IL_33c1: Expected I, but got Obj
		//IL_33d7: Expected Obj, but got I
		//IL_31c8: Expected Obj, but got I
		//IL_31d6: Expected I, but got Obj
		//IL_31de: Unknown result type (might be due to invalid IL or missing references)
		//IL_31e3: Expected Obj, but got Unknown
		//IL_31f0: Expected F4, but got Obj
		//IL_31eb: Expected native int or pointer, but got VT
		//IL_3205: Expected F4, but got I
		//IL_3200: Expected native int or pointer, but got VT
		//IL_3212: Expected native int or pointer, but got VT
		//IL_3224: Expected native int or pointer, but got VT
		//IL_19b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_19b5: Expected Obj, but got Unknown
		//IL_1982: Expected I, but got Obj
		//IL_1ced: Expected Obj, but got I4
		//IL_1c51: Expected I, but got Obj
		//IL_34e7: Expected I, but got Obj
		//IL_34fd: Expected Obj, but got I
		//IL_1c7e: Expected I, but got Obj
		//IL_1c9b: Expected Obj, but got I
		//IL_1ca4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ca9: Expected I4, but got Unknown
		//IL_1cbb: Expected I4, but got Obj
		//IL_1cbb: Expected Obj, but got I
		//IL_1cc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ccd: Expected Obj, but got Unknown
		//IL_1d08: Expected I, but got Obj
		//IL_1d4d: Expected I, but got Obj
		//IL_1d63: Expected Obj, but got I
		//IL_3443: Expected Obj, but got I
		//IL_3451: Expected I, but got Obj
		//IL_3459: Unknown result type (might be due to invalid IL or missing references)
		//IL_345e: Expected Obj, but got Unknown
		//IL_346b: Expected F4, but got Obj
		//IL_3466: Expected native int or pointer, but got VT
		//IL_3480: Expected F4, but got I
		//IL_347b: Expected native int or pointer, but got VT
		//IL_348d: Expected native int or pointer, but got VT
		//IL_349f: Expected native int or pointer, but got VT
		//IL_1dbc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dc1: Expected Obj, but got Unknown
		//IL_1d8e: Expected I, but got Obj
		object obj = default;
		GameObject gameObject = (GameObject)(obj + 76);
		gameObject = (GameObject)0;
		object obj2 = obj + 72;
		obj2 = 0;
		object obj3 = obj + 56;
		obj3 = 0;
		_ = 0;
		float num = (float)obj + 48f;
		((float*)(nint)num)->m_value = 0f;
		int num2 = obj + 116;
		((int*)num2)->m_value = 0;
		object obj4 = obj + 115;
		obj4 = 0;
		object obj5 = obj + 114;
		obj5 = 0;
		object obj6 = obj + 113;
		obj6 = 0;
		object obj7 = obj + 112;
		obj7 = 0;
		nint num3 = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v28 (Il2CppClass<NGUIText>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num4 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v968 (Il2CppClass<NGUIText>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Color color = (Color)(obj + 96);
		Matrix4x4 matrix4x = (Matrix4x4)(obj + 80);
		object obj9 = obj + 32;
		object obj10 = obj + 16;
		bool result;
		ref int reference;
		if (regionWidth >= 1)
		{
			nint num5 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v51 (Il2CppClass<NGUIText>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			if (obj11 != null)
			{
				nint num6 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v962 (Il2CppClass<NGUIText>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (regionHeight >= 1)
			{
				nint num7 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ S0_v60 (Il2CppClass<NGUIText>)+BA]");
				object obj12 = (nint)0 & (nint)0x200;
				if (obj12 != null)
				{
					nint num8 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ S0_v956 (Il2CppClass<NGUIText>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (!(finalLineHeight < 1f))
				{
					nint num9 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ S0_v69 (Il2CppClass<NGUIText>)+BA]");
					object obj13 = (nint)0 & (nint)0x200;
					bool flag = obj13 == null;
					nint num10 = (nint)typeof(NGUIText);
					if (!flag)
					{
						nint num11 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ S0_v950 (Il2CppClass<NGUIText>)+74]");
						bool flag2 = (nint)0 == 0;
						bool flag3 = !flag2;
						num10 = (nint)typeof(NGUIText);
						if (!flag3)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							num10 = (nint)typeof(NGUIText);
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ L5_v10 (Il2CppClass<NGUIText>)+5C]");
					object obj14 = -(-64);
					bool flag4 = (nint)obj14 > 0;
					nint num12 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ S1_v41 (Il2CppClass<NGUIText>)+BA]");
					object obj15 = (nint)0 & (nint)0x200;
					bool flag5 = obj15 == null;
					int num19;
					if (flag4)
					{
						if (!flag5)
						{
							nint num13 = (nint)typeof(NGUIText);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ S0_v944 (Il2CppClass<NGUIText>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						nint num14 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ S1_v568 (Il2CppClass<NGUIText>)+5C]");
						object obj16 = -(-64);
						nint num15 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ S1_v573 (Il2CppClass<UnityEngine.Mathf>)+BA]");
						object obj17 = (nint)0 & (nint)0x200;
						if (obj17 != null)
						{
							nint num16 = (nint)typeof(Mathf);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ S1_v579 (Il2CppClass<UnityEngine.Mathf>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						float num17 = finalLineHeight * (float)obj16;
						float num18 = ((!((float)regionHeight < num17)) ? num17 : ((float)regionHeight));
						num19 = (int)num18;
					}
					else
					{
						if (!flag5)
						{
							nint num20 = (nint)typeof(NGUIText);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ S0_v928 (Il2CppClass<NGUIText>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						num19 = regionHeight;
					}
					nint num21 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ S0_v80 (Il2CppClass<NGUIText>)+BA]");
					object obj18 = (nint)0 & (nint)0x200;
					bool flag6 = obj18 == null;
					nint num22 = (nint)typeof(NGUIText);
					if (!flag6)
					{
						nint num23 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ S0_v916 (Il2CppClass<NGUIText>)+74]");
						bool flag7 = (nint)0 == 0;
						bool flag8 = !flag7;
						num22 = (nint)typeof(NGUIText);
						if (!flag8)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							num22 = (nint)typeof(NGUIText);
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ L5_v14 (Il2CppClass<NGUIText>)+5C]");
					object obj19 = -(-64);
					float num27;
					if ((nint)obj19 > 0)
					{
						nint num24 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ S0_v902 (Il2CppClass<NGUIText>)+BA]");
						object obj20 = (nint)0 & (nint)0x200;
						bool flag9 = obj20 == null;
						nint num25 = (nint)typeof(NGUIText);
						if (!flag9)
						{
							nint num26 = (nint)typeof(NGUIText);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ S0_v910 (Il2CppClass<NGUIText>)+74]");
							bool flag10 = (nint)0 == 0;
							bool flag11 = !flag10;
							num25 = (nint)typeof(NGUIText);
							if (!flag11)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								num25 = (nint)typeof(NGUIText);
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v447 @ L5_v34 (Il2CppClass<NGUIText>)+5C]");
						object obj21 = -(-64);
						num27 = (float)obj21;
					}
					else
					{
						num27 = 1000000f;
					}
					nint num28 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v462 @ S1_v51 (Il2CppClass<NGUIText>)+BA]");
					object obj22 = (nint)0 & (nint)0x200;
					if (obj22 != null)
					{
						nint num29 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ S1_v555 (Il2CppClass<NGUIText>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					nint num30 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v483 @ S1_v59 (Il2CppClass<UnityEngine.Mathf>)+BA]");
					object obj23 = (nint)0 & (nint)0x200;
					if (obj23 != null)
					{
						nint num31 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ S1_v551 (Il2CppClass<UnityEngine.Mathf>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					float num32 = (float)num19 / finalLineHeight;
					if (!(num27 < num32))
					{
						num27 = num32;
					}
					float f = num27 + 0.01f;
					int num33 = Mathf.RoundToInt(f);
					if (num33 == 0)
					{
						reference = ref *(int*)"";
						result = false;
					}
					else
					{
						bool flag12;
						if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref text) != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [text @ L0 (System.String&)+8]");
							flag12 = (nint)0 == 0;
						}
						else
						{
							flag12 = true;
						}
						ref string reference2 = ref !flag12 ? ref text : ref *(string*)" ";
						nint num34 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v530 @ S0_v102 (Il2CppClass<NGUIText>)+BA]");
						object obj24 = (nint)0 & (nint)0x200;
						if (obj24 != null)
						{
							nint num35 = (nint)typeof(NGUIText);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ S0_v884 (Il2CppClass<NGUIText>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						EndLine(ref System.Runtime.CompilerServices.Unsafe.As<string, StringBuilder>(ref reference2));
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						StringBuilder stringBuilder = default;
						System.Text.StringBuilderCache.Release(stringBuilder);
						gameObject = (GameObject)(object)stringBuilder;
						obj2 = 0;
						nint num36 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v560 @ S2_v9 (Il2CppClass<NGUIText>)+5C]");
						object obj25 = (nint)0 + (nint)32;
						((Color*)(nint)color)->r = (float)obj25;
						Color color2 = color;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ S2_v11+8]");
						((Color*)(nint)color2)->b = 0f;
						obj3 = color.r;
						_ = color.b;
						((float*)(nint)num)->m_value = 0f;
						((int*)num2)->m_value = 0;
						obj4 = 0;
						obj5 = 0;
						obj6 = 0;
						obj7 = 0;
						nint num37 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ S1_v83 (Il2CppClass<NGUIText>)+BA]");
						object obj26 = (nint)0 & (nint)0x200;
						bool flag13 = obj26 == null;
						float num41;
						if (suffix != null)
						{
							if (!flag13)
							{
								nint num38 = (nint)typeof(NGUIText);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v604 @ S1_v544 (Il2CppClass<NGUIText>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							float num39 = ((JsonDict)46).GetFloat((string)46, fontScale);
							float num40 = finalSpacingX + num39;
							num41 = num40 * 3f;
						}
						else
						{
							if (!flag13)
							{
								nint num42 = (nint)typeof(NGUIText);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v621 @ S1_v531 (Il2CppClass<NGUIText>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							num41 = finalSpacingX;
						}
						nint num43 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v643 @ S1_v90 (Il2CppClass<NGUIText>)+BA]");
						object obj27 = (nint)0 & (nint)0x200;
						if (obj27 != null)
						{
							nint num44 = (nint)typeof(NGUIText);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v651 @ S1_v519 (Il2CppClass<NGUIText>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						((Color*)(nint)color)->r = (float)obj3;
						Color color3 = color;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v13+8]");
						((Color*)(nint)color3)->b = 0f;
						mColors.Add(color);
						bool flag14 = useSymbols;
						object obj28 = flag14 & prefix;
						bool flag15 = obj28 == null;
						nint num45 = 0;
						if (!flag15)
						{
							StringBuilder stringBuilder2 = ((StringBuilder)(object)gameObject).AppendLine("[");
							((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
							Matrix4x4 matrix4x2 = matrix4x;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v13+8]");
							((Matrix4x4*)(nint)matrix4x2)->m20 = 0f;
							nint num46 = (nint)typeof(NGUIText);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v726 @ S2_v227 (Il2CppClass<NGUIText>)+BA]");
							object obj29 = (nint)0 & (nint)0x200;
							if (obj29 != null)
							{
								nint num47 = (nint)typeof(NGUIText);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v795 @ S2_v237 (Il2CppClass<NGUIText>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							((Color*)(nint)color)->r = matrix4x.m00;
							((Color*)(nint)color)->b = matrix4x.m20;
							string value = EncodeColor24(color);
							StringBuilder stringBuilder3 = ((StringBuilder)(object)gameObject).AppendLine(value);
							StringBuilder stringBuilder4 = ((StringBuilder)(object)gameObject).AppendLine("]");
							num45 = unchecked((nint)null);
						}
						object obj30 = suffix ^ 1;
						float num48 = num19;
						char[] array = (char[])obj2;
						int num49 = 0;
						object obj31 = 1;
						float num50 = 0f;
						int num51 = 1;
						int num52 = 1;
						object obj34 = default;
						object obj39 = default;
						int num60 = default;
						string name = default;
						float num99 = default;
						while (true)
						{
							char[] array2 = array;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v527 @ S0_v99 (System.String&)+8]");
							string text2;
							int num55;
							bool flag17;
							object obj36;
							bool flag30;
							bool flag32;
							float num100;
							bool flag36;
							float num101;
							object obj71;
							object obj75;
							int num106;
							object obj89;
							bool flag24;
							if ((nint)array2 < 0)
							{
								string[] array3 = ((string)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2)).Split(array);
								nint num53 = (nint)typeof(NGUIText);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v839 @ S0_v199 (Il2CppClass<NGUIText>)+BA]");
								object obj32 = (nint)0 & (nint)0x200;
								if (obj32 != null)
								{
									nint num54 = (nint)typeof(NGUIText);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v923 @ S0_v881 (Il2CppClass<NGUIText>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								text2 = (string)(array3 & 0xFFFF);
								num55 = CalculateOffsetToFit(text2);
								object obj33 = array3 & 0xFFFF;
								bool flag16 = (nint)obj33 > 12287;
								obj34 |= flag16;
								flag17 = num52 == num33;
								object obj35 = array3 & 0xFFFF;
								if ((nint)obj35 != 10)
								{
									obj36 = obj31 | flag17;
									nint num56 = (nint)typeof(NGUIText);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v989 @ S0_v222 (Il2CppClass<NGUIText>)+BA]");
									object obj37 = (nint)0 & (nint)0x200;
									if (obj37 != null)
									{
										nint num57 = (nint)typeof(NGUIText);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1020 @ S0_v806 (Il2CppClass<NGUIText>)+74]");
										if ((nint)0 == 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
										}
									}
									bool flag18 = (byte)(~(encoding ? 1u : 0u)) != 0;
									bool flag19 = (byte)num45 != 0;
									if (!flag18)
									{
										nint num58 = (nint)typeof(NGUIText);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1050 @ S0_v667 (Il2CppClass<NGUIText>)+BA]");
										object obj38 = (nint)0 & (nint)0x200;
										if (obj38 != null)
										{
											nint num59 = (nint)typeof(NGUIText);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1093 @ S0_v801 (Il2CppClass<NGUIText>)+74]");
											if ((nint)0 == 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
											}
										}
										flag19 = premultiply;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B752");
										if (obj39 != null)
										{
											bool flag20 = num49 >= num60;
											object obj40 = flag17 & suffix;
											object obj41 = obj40 ^ 1;
											object obj42 = flag20 | obj41;
											if (obj42 != null)
											{
												object obj43 = num60 + 1;
												bool flag21 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj43) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2);
												bool flag22 = !flag21;
												int num61 = (flag19 ? 1 : 0);
												if (!flag22)
												{
													num61 = obj2 - num49;
													string value2 = ((string)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2)).InternalSubString(num49, num61);
													StringBuilder stringBuilder5 = ((StringBuilder)(object)gameObject).AppendLine(value2);
													num49 = (int)obj2;
												}
												bool flag23 = obj28 == null;
												flag24 = (byte)(int)((float*)(nint)num)->m_value != 0;
												if (!flag23)
												{
													nint num62 = (nint)typeof(NGUIText);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1473 @ S0_v707 (Il2CppClass<NGUIText>)+BA]");
													object obj44 = (nint)0 & (nint)0x200;
													bool flag25 = obj44 == null;
													if (obj7 != null)
													{
														if (!flag25)
														{
															nint num63 = (nint)typeof(NGUIText);
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1584 @ S0_v791 (Il2CppClass<NGUIText>)+74]");
															if ((nint)0 == 0)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
															}
														}
														BetterList<Color> betterList = mColors;
														BetterList<Color> betterList2 = mColors;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1600 @ S2_v185 (BetterList`1<UnityEngine.Color>)+C]");
														object obj45 = (nint)0 << 4;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1595 @ S1_v446 (BetterList`1<UnityEngine.Color>)+8]");
														object obj46 = 0 + obj45;
														((Color*)(nint)color)->r = (float)obj46;
														Color color4 = color;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1604 @ S1_v448+8]");
														((Color*)(nint)color4)->b = 0f;
														obj3 = color.r;
														_ = color.b;
														object obj47 = obj3 + 12;
														nint num64 = (nint)typeof(NGUIText);
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1629 @ S3_v71 (Il2CppClass<NGUIText>)+5C]");
														float num65 = 0f + 32f;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1632 @ S3_v73 (System.Single)+C]");
														num61 = 0;
														float num66 = mAlpha;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1632 @ S3_v73 (System.Single)+C]");
														float num67 = num66 * 0f;
														float num68 = (float)obj47 * num67;
														obj47 = num68;
														num48 = (float)obj47;
													}
													else
													{
														bool flag26 = !flag25;
														bool flag27 = !flag26;
														nint num69 = (nint)typeof(NGUIText);
														if (!flag27)
														{
															nint num70 = (nint)typeof(NGUIText);
															num69 = (nint)typeof(NGUIText);
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1636 @ S0_v773 (Il2CppClass<NGUIText>)+74]");
															if ((nint)0 == 0)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																num69 = (nint)typeof(NGUIText);
															}
														}
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1638 @ L3_v78 (Il2CppClass<NGUIText>)+5C]");
														object obj48 = (nint)0 + (nint)32;
														obj9 = obj48;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1646 @ S1_v415+8]");
														_ = 0;
														BetterList<Color> betterList3 = mColors;
														BetterList<Color> betterList4 = mColors;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1663 @ S2_v174 (BetterList`1<UnityEngine.Color>)+C]");
														object obj49 = (nint)0 << 4;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1658 @ S1_v422 (BetterList`1<UnityEngine.Color>)+8]");
														object obj50 = 0 + obj49;
														obj10 = obj50;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1667 @ S1_v424+8]");
														_ = 0;
														((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj9;
														Matrix4x4 matrix4x3 = matrix4x;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v37+8]");
														((Matrix4x4*)(nint)matrix4x3)->m20 = 0f;
														((Color*)(nint)color)->r = (float)obj10;
														Color color5 = color;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v39+8]");
														((Color*)(nint)color5)->b = 0f;
														Matrix4x4 matrix4x4 = matrix4x * (Matrix4x4)color;
														obj3 = obj;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
														_ = 0;
														object obj51 = obj3 + 12;
														float num71 = (float)obj51 * mAlpha;
														obj51 = num71;
														num48 = (float)obj51;
														num61 = 0;
													}
													nint num72 = (nint)typeof(NGUIText);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1743 @ S0_v715 (Il2CppClass<NGUIText>)+BA]");
													object obj52 = (nint)0 & (nint)0x200;
													if (obj52 != null)
													{
														nint num73 = (nint)typeof(NGUIText);
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1814 @ S0_v748 (Il2CppClass<NGUIText>)+74]");
														if ((nint)0 == 0)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
														}
													}
													BetterList<Color> betterList5 = mColors;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1822 @ S0_v721 (BetterList`1<UnityEngine.Color>)+C]");
													object obj53 = -2;
													flag24 = false;
													while ((flag24 ? 1 : 0) < (nint)obj53)
													{
														object obj54 = obj3 + 12;
														nint num74 = (nint)typeof(NGUIText);
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1901 @ S0_v732 (Il2CppClass<NGUIText>)+BA]");
														object obj55 = (nint)0 & (nint)0x200;
														if (obj55 != null)
														{
															nint num75 = (nint)typeof(NGUIText);
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1922 @ S0_v743 (Il2CppClass<NGUIText>)+74]");
															if ((nint)0 == 0)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
															}
														}
														BetterList<Color> betterList6 = mColors;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1933 @ S1_v403 (BetterList`1<UnityEngine.Color>)+8]");
														object obj56 = (nint)0 + (nint)16;
														int num76 = (int)((flag24 ? 1u : 0u) << 4);
														object obj57 = obj56 + num76;
														((Color*)(nint)color)->r = (float)obj57;
														Color color6 = color;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1939 @ S1_v406+8]");
														((Color*)(nint)color6)->b = 0f;
														float num77 = (float)obj54 * color.a;
														obj54 = num77;
														bool flag28 = (byte)((flag24 ? 1u : 0u) + 1u) != 0;
														num48 = (float)obj54;
														flag24 = flag28;
														num61 = 4;
													}
												}
												if (num49 < (nint)obj2)
												{
													int num78 = obj2 - num49;
													string value3 = ((string)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2)).InternalSubString(num49, num78);
													StringBuilder stringBuilder6 = ((StringBuilder)(object)gameObject).AppendLine(value3);
													num45 = num78;
												}
												else
												{
													StringBuilder stringBuilder7 = ((StringBuilder)(object)gameObject).Append((int)array3);
													num45 = num61;
												}
												object obj58 = obj2 - 1;
												obj2 = obj58;
												num49 = (int)obj2;
												num60 = (int)obj2;
												goto IL_2da4;
											}
											object obj59 = num60 - num49;
											int length = obj59 + 1;
											string value4 = ((string)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2)).InternalSubString(num49, length);
											StringBuilder stringBuilder8 = ((StringBuilder)(object)gameObject).AppendLine(value4);
											if ((int)(~((float*)(nint)num)->m_value) == 0)
											{
												StringBuilder stringBuilder9 = ((StringBuilder)(object)gameObject).AppendLine("[/sub]");
											}
											StringBuilder stringBuilder10 = ((StringBuilder)(object)gameObject).AppendLine("...");
											break;
										}
									}
									nint num79 = (nint)typeof(NGUIText);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1069 @ S0_v231 (Il2CppClass<NGUIText>)+BA]");
									object obj60 = (nint)0 & (nint)0x200;
									if (obj60 != null)
									{
										nint num80 = (nint)typeof(NGUIText);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1107 @ S0_v661 (Il2CppClass<NGUIText>)+74]");
										if ((nint)0 == 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
										}
									}
									int num83;
									if (~(useSymbols ? 1u : 0u) == 0)
									{
										nint num81 = (nint)typeof(NGUIText);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1176 @ S0_v652 (Il2CppClass<NGUIText>)+BA]");
										object obj61 = (nint)0 & (nint)0x200;
										if (obj61 != null)
										{
											nint num82 = (nint)typeof(NGUIText);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1270 @ S0_v658 (Il2CppClass<NGUIText>)+74]");
											if ((nint)0 == 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
											}
										}
										object indices = obj2;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v527 @ S0_v99 (System.String&)+8]");
										num83 = GetExactCharacterIndex((List<Vector3>)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2), (List<int>)indices, (Vector2)0);
										flag19 = false;
									}
									else
									{
										num83 = 0;
									}
									nint num84 = (nint)typeof(NGUIText);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1287 @ S0_v240 (Il2CppClass<NGUIText>)+BA]");
									object obj62 = (nint)0 & (nint)0x200;
									bool flag29 = obj62 == null;
									flag30 = ((float*)(nint)num)->m_value == 0f;
									float num86;
									if (flag30)
									{
										if (!flag29)
										{
											nint num85 = (nint)typeof(NGUIText);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1431 @ S0_v643 (Il2CppClass<NGUIText>)+74]");
											if ((nint)0 == 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
											}
										}
										num86 = fontScale;
									}
									else
									{
										if (!flag29)
										{
											nint num87 = (nint)typeof(NGUIText);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1440 @ S0_v632 (Il2CppClass<NGUIText>)+74]");
											if ((nint)0 == 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
											}
										}
										num86 = fontScale * 0.75f;
									}
									nint num88 = (nint)typeof(NGUIText);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1518 @ S0_v249 (Il2CppClass<NGUIText>)+BA]");
									object obj63 = (nint)0 & (nint)0x200;
									bool flag31 = obj63 == null;
									flag32 = num83 != 0;
									float num91;
									float num92;
									if (flag32)
									{
										if (!flag31)
										{
											nint num89 = (nint)typeof(NGUIText);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1698 @ S0_v620 (Il2CppClass<NGUIText>)+74]");
											if ((nint)0 == 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
											}
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1285 @ S0_v238 (System.Int32)+2C]");
										float num90 = 0f * num86;
										num91 = finalSpacingX + num90;
										num92 = (flag19 ? 1 : 0);
									}
									else
									{
										if (!flag31)
										{
											nint num93 = (nint)typeof(NGUIText);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1712 @ S0_v610 (Il2CppClass<NGUIText>)+74]");
											if ((nint)0 == 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
											}
										}
										float num94 = ((JsonDict)(object)text2).GetFloat(name, num86);
										bool flag33 = num94 != 0f;
										if (((uint)num55 | (flag33 ? 1u : 0u)) == 0)
										{
											num48 = num94;
											flag24 = flag31;
											num60 = num60;
											num45 = (nint)num86;
											goto IL_2da4;
										}
										nint num95 = (nint)typeof(NGUIText);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1851 @ S0_v596 (Il2CppClass<NGUIText>)+BA]");
										object obj64 = (nint)0 & (nint)0x200;
										if (obj64 != null)
										{
											nint num96 = (nint)typeof(NGUIText);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1881 @ S0_v604 (Il2CppClass<NGUIText>)+74]");
											if ((nint)0 == 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
											}
										}
										num91 = finalSpacingX + num94;
										num92 = num86;
									}
									bool flag34 = !flag30;
									bool flag35 = !flag34;
									num48 = num91;
									if (!flag35)
									{
										nint num97 = (nint)typeof(Mathf);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1831 @ S0_v580 (Il2CppClass<UnityEngine.Mathf>)+BA]");
										object obj65 = (nint)0 & (nint)0x200;
										if (obj65 != null)
										{
											nint num98 = (nint)typeof(Mathf);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1872 @ S0_v586 (Il2CppClass<UnityEngine.Mathf>)+74]");
											if ((nint)0 == 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
											}
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72EB");
										num48 = num99;
									}
									num100 = num50 + num48;
									flag36 = (byte)(obj36 & (object)suffix) != 0;
									num101 = ((!flag36) ? ((float)regionWidth) : ((float)regionWidth - num41));
									object obj66 = obj34 ^ 1;
									int num102 = num55 & obj66;
									bool flag37 = num49 < (nint)obj2;
									if (((uint)num102 & (flag37 ? 1u : 0u)) != 0)
									{
										object obj67 = obj2 - num49;
										bool flag38 = !(num100 < num101);
										object obj68 = flag17 & flag38;
										object obj69 = obj2;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v527 @ S0_v99 (System.String&)+8]");
										bool flag39 = (nint)obj69 < 0;
										object obj70 = obj68 & flag39;
										bool flag40 = obj70 == null;
										obj71 = obj67;
										if (!flag40)
										{
											string[] array4 = ((string)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2)).Split((char[])obj2);
											string text3 = (string)(array4 & 0xFFFF);
											object obj72 = array4 & 0xFFFF;
											if ((nint)obj72 >= 32)
											{
												nint num103 = (nint)typeof(NGUIText);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2051 @ S0_v566 (Il2CppClass<NGUIText>)+BA]");
												object obj73 = (nint)0 & (nint)0x200;
												if (obj73 != null)
												{
													nint num104 = (nint)typeof(NGUIText);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2067 @ S0_v573 (Il2CppClass<NGUIText>)+74]");
													if ((nint)0 == 0)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
													}
												}
												int num105 = CalculateOffsetToFit(text3);
												bool flag41 = num105 == 0;
												obj71 = obj67;
												if (flag41)
												{
													goto IL_2fd8;
												}
											}
											object obj74 = obj67 - 1;
											obj71 = obj74;
										}
										goto IL_2fd8;
									}
									obj75 = obj31;
									num45 = (nint)num92;
									num106 = (int)obj2;
									goto IL_2ff1;
								}
								if (!flag17)
								{
									if (num49 < (nint)obj2)
									{
										object obj76 = obj2 - num49;
										int num107 = obj76 + 1;
										string value5 = ((string)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2)).InternalSubString(num49, num107);
										StringBuilder stringBuilder11 = ((StringBuilder)(object)gameObject).AppendLine(value5);
										num45 = num107;
									}
									else
									{
										StringBuilder stringBuilder12 = ((StringBuilder)(object)gameObject).Append(10);
									}
									if (obj28 != null)
									{
										object obj77 = 0;
										while (true)
										{
											nint num108 = (nint)typeof(NGUIText);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1207 @ S0_v831 (Il2CppClass<NGUIText>)+BA]");
											object obj78 = (nint)0 & (nint)0x200;
											if (obj78 != null)
											{
												nint num109 = (nint)typeof(NGUIText);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1301 @ S0_v871 (Il2CppClass<NGUIText>)+74]");
												if ((nint)0 == 0)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
												}
											}
											BetterList<Color> betterList7 = mColors;
											object obj79 = obj77;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1310 @ S1_v471 (BetterList`1<UnityEngine.Color>)+C]");
											if ((nint)obj79 >= 0)
											{
												break;
											}
											nint num110 = (nint)gameObject;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1394 @ S0_v863 (Il2CppClass<UnityEngine.GameObject>)+10]");
											nint num111 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1394 @ S0_v863 (Il2CppClass<UnityEngine.GameObject>)+14]");
											object obj80 = num111 + 0;
											int index2 = obj80 - 1;
											StringBuilder stringBuilder13 = ((StringBuilder)num110).Insert(index2, (char)(int)"[-]");
											object obj81 = obj77 + 1;
											obj77 = obj81;
											num45 = unchecked((nint)null);
										}
										object obj82 = 0;
										while (true)
										{
											nint num112 = (nint)typeof(NGUIText);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1466 @ S0_v840 (Il2CppClass<NGUIText>)+BA]");
											object obj83 = (nint)0 & (nint)0x200;
											if (obj83 != null)
											{
												nint num113 = (nint)typeof(NGUIText);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1529 @ S0_v857 (Il2CppClass<NGUIText>)+74]");
												if ((nint)0 == 0)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
												}
											}
											BetterList<Color> betterList8 = mColors;
											object obj84 = obj82;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1537 @ S1_v477 (BetterList`1<UnityEngine.Color>)+C]");
											if ((nint)obj84 >= 0)
											{
												break;
											}
											StringBuilder stringBuilder14 = ((StringBuilder)(object)gameObject).AppendLine("[");
											nint num114 = (nint)typeof(NGUIText);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1724 @ S1_v482 (Il2CppClass<NGUIText>)+BA]");
											object obj85 = (nint)0 & (nint)0x200;
											if (obj85 != null)
											{
												nint num115 = (nint)typeof(NGUIText);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1783 @ S1_v497 (Il2CppClass<NGUIText>)+74]");
												if ((nint)0 == 0)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
												}
											}
											BetterList<Color> betterList9 = mColors;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1794 @ S2_v203 (BetterList`1<UnityEngine.Color>)+8]");
											object obj86 = (nint)0 + (nint)16;
											num45 = obj82 << 4;
											object obj87 = obj86 + num45;
											((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj87;
											Matrix4x4 matrix4x5 = matrix4x;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1799 @ S2_v206+8]");
											((Matrix4x4*)(nint)matrix4x5)->m20 = 0f;
											((Color*)(nint)color)->r = matrix4x.m00;
											((Color*)(nint)color)->b = matrix4x.m20;
											string value6 = EncodeColor24(color);
											StringBuilder stringBuilder15 = ((StringBuilder)(object)gameObject).AppendLine(value6);
											StringBuilder stringBuilder16 = ((StringBuilder)(object)gameObject).AppendLine("]");
											object obj88 = obj82 + 1;
											obj82 = obj88;
										}
									}
									int num116 = num52 + 1;
									int num117 = obj2 + 1;
									name = null;
									num49 = num117;
									num50 = 0f;
									num60 = num60;
									num52 = num116;
									obj89 = 1;
									goto IL_386b;
								}
								num52 = num33;
							}
							if (num49 < (nint)obj2)
							{
								int length2 = obj2 - num49;
								string value7 = ((string)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2)).InternalSubString(num49, length2);
								StringBuilder stringBuilder17 = ((StringBuilder)(object)gameObject).AppendLine(value7);
							}
							break;
							IL_386b:
							obj31 = obj89;
							goto IL_2da4;
							IL_2ff1:
							int num118 = num55 ^ 1;
							int num119 = num118 & suffix;
							bool flag42 = num100 < num101;
							int num120 = ((((uint)num119 & (flag42 ? 1u : 0u)) == 0) ? num60 : num106);
							object obj122;
							string text5;
							int num157;
							float num158;
							if (num100 > num101)
							{
								if (obj36 == null)
								{
									while (true)
									{
										int num121 = num49;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v527 @ S0_v99 (System.String&)+8]");
										if ((nint)num121 >= (nint)0)
										{
											break;
										}
										string[] array5 = ((string)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2)).Split((char[])num49);
										nint num122 = (nint)typeof(NGUIText);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2201 @ S1_v310 (Il2CppClass<NGUIText>)+BA]");
										object obj90 = (nint)0 & (nint)0x200;
										if (obj90 != null)
										{
											nint num123 = (nint)typeof(NGUIText);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2252 @ S1_v317 (Il2CppClass<NGUIText>)+74]");
											if ((nint)0 == 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
											}
										}
										string text4 = (string)(array5 & 0xFFFF);
										if (CalculateOffsetToFit(text4) == 0)
										{
											break;
										}
										int num124 = num49 + 1;
										num49 = num124;
									}
									object obj91 = num49 - 1;
									obj2 = obj91;
									int num125 = num52 + 1;
									nint num126 = (nint)typeof(NGUIText);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2175 @ S0_v433 (Il2CppClass<NGUIText>)+BA]");
									object obj92 = (nint)0 & (nint)0x200;
									bool flag43 = obj92 == null;
									if (type != null)
									{
										if (!flag43)
										{
											nint num127 = (nint)typeof(NGUIText);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2259 @ S0_v506 (Il2CppClass<NGUIText>)+74]");
											if ((nint)0 == 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
											}
										}
										NGUITools.AddWidgetCollider(gameObject);
									}
									else
									{
										if (!flag43)
										{
											nint num128 = (nint)typeof(NGUIText);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2265 @ S0_v499 (Il2CppClass<NGUIText>)+74]");
											if ((nint)0 == 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
											}
										}
										ReplaceSpaceWithNewline(ref *(StringBuilder*)gameObject);
									}
									if (obj28 == null)
									{
										name = null;
										flag24 = flag36;
										obj31 = 1;
										num50 = 0f;
										num60 = num120;
										num52 = num125;
									}
									else
									{
										object obj93 = 0;
										while (true)
										{
											nint num129 = (nint)typeof(NGUIText);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2314 @ S0_v444 (Il2CppClass<NGUIText>)+BA]");
											object obj94 = (nint)0 & (nint)0x200;
											if (obj94 != null)
											{
												nint num130 = (nint)typeof(NGUIText);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2327 @ S0_v487 (Il2CppClass<NGUIText>)+74]");
												if ((nint)0 == 0)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
												}
											}
											BetterList<Color> betterList10 = mColors;
											object obj95 = obj93;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2336 @ S1_v270 (BetterList`1<UnityEngine.Color>)+C]");
											if ((nint)obj95 >= 0)
											{
												break;
											}
											nint num131 = (nint)gameObject;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2358 @ S0_v479 (Il2CppClass<UnityEngine.GameObject>)+10]");
											nint num132 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2358 @ S0_v479 (Il2CppClass<UnityEngine.GameObject>)+14]");
											object obj96 = num132 + 0;
											int index3 = obj96 - 1;
											StringBuilder stringBuilder18 = ((StringBuilder)num131).Insert(index3, (char)(int)"[-]");
											object obj97 = obj93 + 1;
											obj93 = obj97;
											num45 = unchecked((nint)null);
										}
										object obj98 = 0;
										while (true)
										{
											nint num133 = (nint)typeof(NGUIText);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2406 @ S0_v453 (Il2CppClass<NGUIText>)+BA]");
											object obj99 = (nint)0 & (nint)0x200;
											if (obj99 != null)
											{
												nint num134 = (nint)typeof(NGUIText);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2422 @ S0_v473 (Il2CppClass<NGUIText>)+74]");
												if ((nint)0 == 0)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
												}
											}
											BetterList<Color> betterList11 = mColors;
											object obj100 = obj98;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2431 @ S1_v276 (BetterList`1<UnityEngine.Color>)+C]");
											if ((nint)obj100 >= 0)
											{
												break;
											}
											StringBuilder stringBuilder19 = ((StringBuilder)(object)gameObject).AppendLine("[");
											nint num135 = (nint)typeof(NGUIText);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2464 @ S1_v281 (Il2CppClass<NGUIText>)+BA]");
											object obj101 = (nint)0 & (nint)0x200;
											if (obj101 != null)
											{
												nint num136 = (nint)typeof(NGUIText);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2489 @ S1_v296 (Il2CppClass<NGUIText>)+74]");
												if ((nint)0 == 0)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
												}
											}
											BetterList<Color> betterList12 = mColors;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2500 @ S2_v108 (BetterList`1<UnityEngine.Color>)+8]");
											object obj102 = (nint)0 + (nint)16;
											num45 = obj98 << 4;
											object obj103 = obj102 + num45;
											((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj103;
											Matrix4x4 matrix4x6 = matrix4x;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2505 @ S2_v111+8]");
											((Matrix4x4*)(nint)matrix4x6)->m20 = 0f;
											((Color*)(nint)color)->r = matrix4x.m00;
											((Color*)(nint)color)->b = matrix4x.m20;
											string value8 = EncodeColor24(color);
											StringBuilder stringBuilder20 = ((StringBuilder)(object)gameObject).AppendLine(value8);
											StringBuilder stringBuilder21 = ((StringBuilder)(object)gameObject).AppendLine("]");
											object obj104 = obj98 + 1;
											obj98 = obj104;
										}
										name = null;
										flag24 = flag36;
										obj31 = 1;
										num50 = 0f;
										num60 = num120;
										num52 = num125;
									}
									goto IL_2da4;
								}
								bool flag44 = num106 < 1;
								object obj105 = flag44 | obj30;
								if (obj105 == null)
								{
									if (num120 > num49)
									{
										object obj106 = num120 - num49;
										int length3 = obj106 + 1;
										string value9 = ((string)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2)).InternalSubString(num49, length3);
										StringBuilder stringBuilder22 = ((StringBuilder)(object)gameObject).AppendLine(value9);
									}
									if (!flag30)
									{
										StringBuilder stringBuilder23 = ((StringBuilder)(object)gameObject).AppendLine("[/sub]");
									}
									StringBuilder stringBuilder24 = ((StringBuilder)(object)gameObject).AppendLine("...");
									break;
								}
								nint num137 = (nint)typeof(Mathf);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2187 @ S1_v195 (Il2CppClass<UnityEngine.Mathf>)+BA]");
								object obj107 = (nint)0 & (nint)0x200;
								if (obj107 != null)
								{
									nint num138 = (nint)typeof(Mathf);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2210 @ S1_v255 (Il2CppClass<UnityEngine.Mathf>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								int num139 = num106 - num49;
								int num140 = ((0 <= num139) ? num139 : 0);
								string value10 = ((string)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2)).InternalSubString(num49, num140);
								StringBuilder stringBuilder25 = ((StringBuilder)(object)gameObject).AppendLine(value10);
								int num141 = obj34 | num55;
								int num142 = num51 & num141;
								if (obj28 != null)
								{
									nint num143 = (nint)typeof(NGUIText);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2340 @ S0_v408 (Il2CppClass<NGUIText>)+BA]");
									object obj108 = (nint)0 & (nint)0x200;
									if (obj108 != null)
									{
										nint num144 = (nint)typeof(NGUIText);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2372 @ S0_v420 (Il2CppClass<NGUIText>)+74]");
										if ((nint)0 == 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
										}
									}
									BetterList<Color> betterList13 = mColors;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2379 @ S0_v414 (BetterList`1<UnityEngine.Color>)+C]");
									if ((nint)0 >= (nint)1)
									{
										StringBuilder stringBuilder26 = ((StringBuilder)(object)gameObject).AppendLine("[-]");
									}
								}
								int num145 = num52 + 1;
								if (flag17)
								{
									num51 = num142;
									num52 = num145;
									break;
								}
								nint num146 = (nint)typeof(NGUIText);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2382 @ S0_v322 (Il2CppClass<NGUIText>)+BA]");
								object obj109 = (nint)0 & (nint)0x200;
								bool flag45 = obj109 == null;
								if (type != null)
								{
									if (!flag45)
									{
										nint num147 = (nint)typeof(NGUIText);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2434 @ S0_v404 (Il2CppClass<NGUIText>)+74]");
										if ((nint)0 == 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
										}
									}
									NGUITools.AddWidgetCollider(gameObject);
								}
								else
								{
									if (!flag45)
									{
										nint num148 = (nint)typeof(NGUIText);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2440 @ S0_v397 (Il2CppClass<NGUIText>)+74]");
										if ((nint)0 == 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
										}
									}
									ReplaceSpaceWithNewline(ref *(StringBuilder*)gameObject);
								}
								bool flag46 = obj28 == null;
								num45 = num140;
								if (!flag46)
								{
									object obj110 = 0;
									while (true)
									{
										nint num149 = (nint)typeof(NGUIText);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2535 @ S0_v348 (Il2CppClass<NGUIText>)+BA]");
										object obj111 = (nint)0 & (nint)0x200;
										if (obj111 != null)
										{
											nint num150 = (nint)typeof(NGUIText);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2553 @ S0_v388 (Il2CppClass<NGUIText>)+74]");
											if ((nint)0 == 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
											}
										}
										BetterList<Color> betterList14 = mColors;
										object obj112 = obj110;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2562 @ S1_v213 (BetterList`1<UnityEngine.Color>)+C]");
										if ((nint)obj112 >= 0)
										{
											break;
										}
										nint num151 = (nint)gameObject;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2573 @ S0_v380 (Il2CppClass<UnityEngine.GameObject>)+10]");
										nint num152 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2573 @ S0_v380 (Il2CppClass<UnityEngine.GameObject>)+14]");
										object obj113 = num152 + 0;
										int index4 = obj113 - 1;
										StringBuilder stringBuilder27 = ((StringBuilder)num151).Insert(index4, (char)(int)"[-]");
										object obj114 = obj110 + 1;
										obj110 = obj114;
										num140 = 0;
									}
									object obj115 = 0;
									num45 = num140;
									while (true)
									{
										nint num153 = (nint)typeof(NGUIText);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2603 @ S0_v357 (Il2CppClass<NGUIText>)+BA]");
										object obj116 = (nint)0 & (nint)0x200;
										if (obj116 != null)
										{
											nint num154 = (nint)typeof(NGUIText);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2608 @ S0_v374 (Il2CppClass<NGUIText>)+74]");
											if ((nint)0 == 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
											}
										}
										BetterList<Color> betterList15 = mColors;
										object obj117 = obj115;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2616 @ S1_v219 (BetterList`1<UnityEngine.Color>)+C]");
										if ((nint)obj117 >= 0)
										{
											break;
										}
										StringBuilder stringBuilder28 = ((StringBuilder)(object)gameObject).AppendLine("[");
										nint num155 = (nint)typeof(NGUIText);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2628 @ S1_v224 (Il2CppClass<NGUIText>)+BA]");
										object obj118 = (nint)0 & (nint)0x200;
										if (obj118 != null)
										{
											nint num156 = (nint)typeof(NGUIText);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2633 @ S1_v239 (Il2CppClass<NGUIText>)+74]");
											if ((nint)0 == 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
											}
										}
										BetterList<Color> betterList16 = mColors;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2644 @ S2_v82 (BetterList`1<UnityEngine.Color>)+8]");
										object obj119 = (nint)0 + (nint)16;
										num45 = obj115 << 4;
										object obj120 = obj119 + num45;
										((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj120;
										Matrix4x4 matrix4x7 = matrix4x;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2649 @ S2_v85+8]");
										((Matrix4x4*)(nint)matrix4x7)->m20 = 0f;
										((Color*)(nint)color)->r = matrix4x.m00;
										((Color*)(nint)color)->b = matrix4x.m20;
										string value11 = EncodeColor24(color);
										StringBuilder stringBuilder29 = ((StringBuilder)(object)gameObject).AppendLine(value11);
										StringBuilder stringBuilder30 = ((StringBuilder)(object)gameObject).AppendLine("]");
										object obj121 = obj115 + 1;
										obj115 = obj121;
									}
								}
								if (num55 == 0)
								{
									obj122 = 1;
									text5 = null;
									num49 = (int)obj2;
									num157 = (int)obj2;
									num60 = (int)obj2;
									num51 = num142;
									num52 = num145;
									num158 = num48;
								}
								else
								{
									int num159 = obj2 + 1;
									obj122 = 1;
									text5 = null;
									num49 = num159;
									num157 = (int)obj2;
									num60 = (int)obj2;
									num51 = num142;
									num52 = num145;
									num158 = 0f;
								}
							}
							else
							{
								obj122 = obj75;
								text5 = text2;
								num157 = num106;
								num60 = num120;
								num158 = num100;
							}
							if (!flag32)
							{
								name = text5;
								flag24 = flag36;
								obj31 = obj122;
								num50 = num158;
								goto IL_2da4;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1285 @ S0_v238 (System.Int32)+18]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1285 @ S0_v238 (System.Int32)+8]");
								object obj123 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2242 @ S1_v181+8]");
								_ = 0;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1285 @ S0_v238 (System.Int32)+18]");
							object obj124 = -1;
							object obj125 = obj124 + num157;
							obj2 = obj125;
							name = null;
							flag24 = flag36;
							num50 = num158;
							obj89 = obj122;
							goto IL_386b;
							IL_2da4:
							char[] array6 = (char[])(obj2 + 1);
							obj2 = array6;
							array = array6;
							continue;
							IL_2fd8:
							if (flag36)
							{
								bool flag47 = num100 < (float)regionWidth;
								bool flag48 = num49 >= num60;
								object obj126 = (flag48 ? 1 : 0) ^ 1;
								object obj127 = flag47 & obj126;
								bool flag49 = num100 > num101;
								object obj128 = obj127 & flag49;
								if (obj128 != null)
								{
									if (!flag48)
									{
										object obj129 = num60 - num49;
										int length4 = obj129 + 1;
										string value12 = ((string)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2)).InternalSubString(num49, length4);
										StringBuilder stringBuilder31 = ((StringBuilder)(object)gameObject).AppendLine(value12);
									}
									if (!flag30)
									{
										StringBuilder stringBuilder32 = ((StringBuilder)(object)gameObject).AppendLine("[/sub]");
									}
									StringBuilder stringBuilder33 = ((StringBuilder)(object)gameObject).AppendLine("...");
									break;
								}
							}
							int num160 = obj71 + 1;
							string value13 = ((string)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2)).InternalSubString(num49, num160);
							StringBuilder stringBuilder34 = ((StringBuilder)(object)gameObject).AppendLine(value13);
							int num161 = obj2 + 1;
							num106 = (int)obj2;
							obj75 = 0;
							num49 = num161;
							num45 = num160;
							goto IL_2ff1;
						}
						if (obj28 != null)
						{
							nint num162 = (nint)typeof(NGUIText);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v933 @ S0_v173 (Il2CppClass<NGUIText>)+BA]");
							object obj130 = (nint)0 & (nint)0x200;
							if (obj130 != null)
							{
								nint num163 = (nint)typeof(NGUIText);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v967 @ S0_v185 (Il2CppClass<NGUIText>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							BetterList<Color> betterList17 = mColors;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v974 @ S0_v179 (BetterList`1<UnityEngine.Color>)+C]");
							if ((nint)0 >= (nint)1)
							{
								StringBuilder stringBuilder35 = ((StringBuilder)(object)gameObject).AppendLine("[-]");
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
						object obj131 = default;
						reference = ref *(int*)obj131;
						nint num164 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v977 @ S0_v132 (Il2CppClass<NGUIText>)+BA]");
						object obj132 = (nint)0 & (nint)0x200;
						if (obj132 != null)
						{
							nint num165 = (nint)typeof(NGUIText);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v999 @ S0_v167 (Il2CppClass<NGUIText>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						BetterList<Color> betterList18 = mColors;
						_ = 0;
						bool flag50 = num51 == 0;
						result = false;
						if (!flag50)
						{
							object obj133 = obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v527 @ S0_v99 (System.String&)+8]");
							bool flag51 = obj133 == null;
							result = true;
							if (!flag51)
							{
								nint num166 = (nint)typeof(NGUIText);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1077 @ S0_v144 (Il2CppClass<NGUIText>)+BA]");
								object obj134 = (nint)0 & (nint)0x200;
								bool flag52 = obj134 == null;
								nint num167 = (nint)typeof(NGUIText);
								if (!flag52)
								{
									nint num168 = (nint)typeof(NGUIText);
									num167 = (nint)typeof(NGUIText);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1117 @ S0_v162 (Il2CppClass<NGUIText>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
										num167 = (nint)typeof(NGUIText);
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1119 @ L0_v14 (Il2CppClass<NGUIText>)+5C]");
								object obj135 = -(-64);
								nint num169 = (nint)typeof(Mathf);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1129 @ S0_v153 (Il2CppClass<UnityEngine.Mathf>)+BA]");
								object obj136 = (nint)0 & (nint)0x200;
								if (obj136 != null)
								{
									nint num170 = (nint)typeof(Mathf);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1184 @ S0_v159 (Il2CppClass<UnityEngine.Mathf>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								int num171 = (((nint)obj135 >= num33) ? num33 : ((int)obj135));
								result = num52 <= num171;
							}
						}
					}
					goto IL_2681;
				}
			}
		}
		reference = ref *(int*)"";
		result = false;
		goto IL_2681;
		IL_2681:
		return result;
	}

	public unsafe static bool InsertHyperlink(ref string text, ref int index, string keyword, string link, string prefix = null, string suffix = null)
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0094: Expected I4, but got Obj
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		//IL_0052: Expected Obj, but got Ref
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected Obj, but got Unknown
		object obj = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj) < System.Runtime.CompilerServices.Unsafe.As<string, UIntPtr>(ref link))
		{
			object obj2 = prefix + 16;
			object obj3 = obj + suffix;
			object obj4 = obj3 << 1;
			object obj5 = obj2 + obj4;
			object obj6 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref index, 4));
			object obj7 = obj + keyword;
			object obj8 = obj6 + obj7;
			obj5 = obj8;
			object obj9 = obj + 1;
			obj = obj9;
		}
		return (byte)(int)link != 0;
	}

	public unsafe static void ReplaceLinks(ref string text, string prefix = null, string suffix = null)
	{
		//IL_0d97: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d9c: Expected Obj, but got Unknown
		//IL_0da5: Expected Obj, but got I4
		//IL_0dae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db3: Expected Obj, but got Unknown
		//IL_0dbc: Expected Obj, but got I4
		//IL_0dc5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dca: Expected Obj, but got Unknown
		//IL_0dd3: Expected Obj, but got I4
		//IL_0ddc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de1: Expected Obj, but got Unknown
		//IL_0dea: Expected Obj, but got I4
		//IL_0df3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df8: Expected Obj, but got Unknown
		//IL_0e01: Expected Obj, but got I4
		//IL_0e0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e0f: Expected Obj, but got Unknown
		//IL_0e18: Expected Obj, but got I4
		//IL_0e21: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e26: Expected Obj, but got Unknown
		//IL_0e2f: Expected Obj, but got I4
		//IL_0e5a: Expected I, but got Obj
		//IL_0e70: Expected Obj, but got I
		//IL_13e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_13ea: Expected VT, but got Unknown
		//IL_13f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f8: Expected Obj, but got Unknown
		//IL_003d: Expected I, but got Obj
		//IL_0ec1: Expected Obj, but got I4
		//IL_0eca: Expected Obj, but got I4
		//IL_0ed3: Expected Obj, but got I4
		//IL_0edc: Expected Obj, but got I4
		//IL_0ee5: Expected Obj, but got I4
		//IL_0eee: Expected Obj, but got I4
		//IL_0c54: Expected I, but got Obj
		//IL_0c6a: Expected Obj, but got I
		//IL_00a4: Expected Obj, but got Ref
		//IL_00b6: Expected I, but got Obj
		//IL_00cc: Expected Obj, but got I
		//IL_0c95: Expected I, but got Obj
		//IL_141a: Unknown result type (might be due to invalid IL or missing references)
		//IL_141f: Expected Obj, but got Unknown
		//IL_1428: Unknown result type (might be due to invalid IL or missing references)
		//IL_142d: Expected Obj, but got Unknown
		//IL_019b: Expected I, but got Obj
		//IL_0d0e: Expected I, but got Obj
		//IL_0d24: Expected Obj, but got I
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0351: Expected Obj, but got Unknown
		//IL_012a: Expected I, but got Obj
		//IL_01e8: Expected I, but got Obj
		//IL_01fe: Expected Obj, but got I
		//IL_0d4f: Expected I, but got Obj
		//IL_1023: Unknown result type (might be due to invalid IL or missing references)
		//IL_1028: Expected Obj, but got Unknown
		//IL_0387: Expected I, but got Obj
		//IL_039d: Expected Obj, but got I
		//IL_1463: Expected I, but got Obj
		//IL_1479: Expected Obj, but got I
		//IL_0229: Expected I, but got Obj
		//IL_14a4: Expected I, but got Obj
		//IL_14ba: Expected Obj, but got I
		//IL_03c8: Expected I, but got Obj
		//IL_0276: Expected I, but got Obj
		//IL_028c: Expected Obj, but got I
		//IL_0415: Expected I, but got Obj
		//IL_042b: Expected Obj, but got I
		//IL_0304: Expected I, but got Obj
		//IL_1514: Expected I, but got Obj
		//IL_152a: Expected Obj, but got I
		//IL_04c7: Expected I, but got Obj
		//IL_02b7: Expected I, but got Obj
		//IL_0514: Expected I, but got Obj
		//IL_052a: Expected Obj, but got I
		//IL_0456: Expected I, but got Obj
		//IL_0938: Expected I, but got Obj
		//IL_094e: Expected Obj, but got I
		//IL_08d5: Expected I, but got Obj
		//IL_106e: Expected VT, but got I
		//IL_106e: Expected Obj, but got Ref
		//IL_049e: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a3: Expected Obj, but got Unknown
		//IL_0555: Expected I, but got Obj
		//IL_0979: Expected I, but got Obj
		//IL_05a2: Expected I, but got Obj
		//IL_05b8: Expected Obj, but got I
		//IL_09c5: Expected I4, but got Obj
		//IL_09ce: Expected Obj, but got I4
		//IL_09dc: Expected Obj, but got F4
		//IL_0a0c: Expected F4, but got Obj
		//IL_0a07: Expected native int or pointer, but got VT
		//IL_0a21: Expected F4, but got I
		//IL_0a1c: Expected native int or pointer, but got VT
		//IL_0ae3: Expected I, but got Obj
		//IL_0af9: Expected Obj, but got I
		//IL_0a3c: Expected Obj, but got I4
		//IL_0a59: Expected Obj, but got F4
		//IL_0a71: Expected F4, but got Obj
		//IL_0a6c: Expected native int or pointer, but got VT
		//IL_0a86: Expected F4, but got I
		//IL_0a81: Expected native int or pointer, but got VT
		//IL_05e3: Expected I, but got Obj
		//IL_062f: Expected I4, but got Obj
		//IL_0638: Expected Obj, but got I4
		//IL_0646: Expected Obj, but got F4
		//IL_0676: Expected F4, but got Obj
		//IL_0671: Expected native int or pointer, but got VT
		//IL_068b: Expected F4, but got I
		//IL_0686: Expected native int or pointer, but got VT
		//IL_12ce: Expected I, but got Obj
		//IL_12e4: Expected Obj, but got I
		//IL_0b24: Expected I, but got Obj
		//IL_078d: Expected I, but got Obj
		//IL_07a3: Expected Obj, but got I
		//IL_06a6: Expected Obj, but got I4
		//IL_06c3: Expected Obj, but got F4
		//IL_06db: Expected F4, but got Obj
		//IL_06d6: Expected native int or pointer, but got VT
		//IL_06f0: Expected F4, but got I
		//IL_06eb: Expected native int or pointer, but got VT
		//IL_070d: Expected Obj, but got I
		//IL_0723: Expected Obj, but got I
		//IL_135c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1361: Expected Obj, but got Unknown
		//IL_0c12: Expected I, but got Obj
		//IL_113a: Expected I, but got Obj
		//IL_1150: Expected Obj, but got I
		//IL_07ce: Expected I, but got Obj
		//IL_0b9e: Expected I, but got Obj
		//IL_0bb4: Expected Obj, but got I
		//IL_11c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_11cd: Expected Obj, but got Unknown
		//IL_08a2: Expected I, but got Obj
		//IL_0bdf: Expected I, but got Obj
		//IL_082e: Expected I, but got Obj
		//IL_0844: Expected Obj, but got I
		//IL_086f: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 28;
		obj = 0;
		object obj3 = obj2 + 48;
		obj3 = 0;
		object obj4 = obj2 + 47;
		obj4 = 0;
		object obj5 = obj2 + 46;
		obj5 = 0;
		object obj6 = obj2 + 45;
		obj6 = 0;
		object obj7 = obj2 + 44;
		obj7 = 0;
		object obj8 = obj2 + 24;
		obj8 = 0;
		bool flag;
		if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref text) != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [text @ L0 (System.String&)+8]");
			flag = (nint)0 == 0;
		}
		else
		{
			flag = true;
		}
		nint num = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S1_v20 (Il2CppClass<NGUIText>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num2 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S1_v182 (Il2CppClass<NGUIText>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector = (Vector3)(obj2 + 32);
		object obj10 = obj2 + 12;
		ref StringBuilder reference = ref !flag ? ref System.Runtime.CompilerServices.Unsafe.As<string, StringBuilder>(ref text) : ref *(StringBuilder*)" ";
		EndLine(ref reference);
		float num3 = (float)regionWidth + 0.01f;
		float num4 = (float)fontSize * fontScale;
		obj = 0;
		obj3 = 0;
		obj4 = 0;
		obj5 = 0;
		obj6 = 0;
		obj7 = 0;
		char[] array = null;
		string text2 = null;
		int firstChar = prefix.m_firstChar;
		float num13 = default;
		float num17 = default;
		object obj19 = default;
		while (true)
		{
			obj8 = array;
			char[] array2 = array;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v24 (System.Text.StringBuilder&)+8]");
			if ((nint)array2 >= 0)
			{
				break;
			}
			string[] array3 = ((string)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference)).Split(array);
			nint num5 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ S0_v89 (Il2CppClass<NGUIText>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			bool flag2 = obj11 == null;
			float num7;
			if (obj != null)
			{
				if (!flag2)
				{
					nint num6 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ S0_v432 (Il2CppClass<NGUIText>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				num7 = fontScale * 0.75f;
			}
			else
			{
				if (!flag2)
				{
					nint num8 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ S0_v419 (Il2CppClass<NGUIText>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				num7 = fontScale;
			}
			JsonDict jsonDict = (JsonDict)(array3 & 0xFFFF);
			object obj12 = array3 & 0xFFFF;
			if ((nint)obj12 == 10)
			{
				nint num9 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ S0_v367 (Il2CppClass<NGUIText>)+BA]");
				object obj13 = (nint)0 & (nint)0x200;
				if (obj13 != null)
				{
					nint num10 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ S0_v407 (Il2CppClass<NGUIText>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (alignment != Alignment.Left)
				{
					nint num11 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ S0_v392 (Il2CppClass<NGUIText>)+BA]");
					object obj14 = (nint)0 & (nint)0x200;
					if (obj14 != null)
					{
						nint num12 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v505 @ S0_v401 (Il2CppClass<NGUIText>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					float completedFactor = num13 - finalSpacingX;
					((MissionsManager)(object)prefix).Complete(firstChar, completedFactor, true);
					bool flag3 = true;
					firstChar = prefix.m_firstChar;
				}
				nint num14 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ S0_v377 (Il2CppClass<NGUIText>)+BA]");
				object obj15 = (nint)0 & (nint)0x200;
				if (obj15 != null)
				{
					nint num15 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ S0_v385 (Il2CppClass<NGUIText>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float num16 = num17 + finalLineHeight;
				num17 = num16;
				num13 = 0f;
				jsonDict = null;
			}
			else
			{
				object obj16 = array3 & 0xFFFF;
				if ((nint)obj16 > 31)
				{
					nint num18 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ S0_v110 (Il2CppClass<NGUIText>)+BA]");
					object obj17 = (nint)0 & (nint)0x200;
					if (obj17 != null)
					{
						nint num19 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ S0_v360 (Il2CppClass<NGUIText>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (~(encoding ? 1u : 0u) == 0)
					{
						nint num20 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v531 @ S0_v346 (Il2CppClass<NGUIText>)+BA]");
						object obj18 = (nint)0 & (nint)0x200;
						if (obj18 != null)
						{
							nint num21 = (nint)typeof(NGUIText);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v559 @ S0_v354 (Il2CppClass<NGUIText>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						bool flag3 = premultiply;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B752");
						if (obj19 != null)
						{
							object obj20 = obj8 - 1;
							obj8 = obj20;
							jsonDict = (JsonDict)(object)text2;
							goto IL_101a;
						}
					}
					nint num22 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v547 @ S0_v119 (Il2CppClass<NGUIText>)+BA]");
					object obj21 = (nint)0 & (nint)0x200;
					if (obj21 != null)
					{
						nint num23 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ S0_v339 (Il2CppClass<NGUIText>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (~(useSymbols ? 1u : 0u) == 0)
					{
						nint num24 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v596 @ S0_v236 (Il2CppClass<NGUIText>)+BA]");
						object obj22 = (nint)0 & (nint)0x200;
						if (obj22 != null)
						{
							nint num25 = (nint)typeof(NGUIText);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v624 @ S0_v335 (Il2CppClass<NGUIText>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						object indices = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v24 (System.Text.StringBuilder&)+8]");
						if (GetExactCharacterIndex((List<Vector3>)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference), (List<int>)indices, (Vector2)0) != 0)
						{
							nint num26 = (nint)typeof(NGUIText);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v649 @ S0_v245 (Il2CppClass<NGUIText>)+BA]");
							object obj23 = (nint)0 & (nint)0x200;
							if (obj23 != null)
							{
								nint num27 = (nint)typeof(NGUIText);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v663 @ S0_v329 (Il2CppClass<NGUIText>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v611 @ S0_v241 (System.Int32)+2C]");
							float num28 = 0f * num7;
							float num29 = num28 + finalSpacingX;
							float num30 = num13 + num29;
							if (!(num30 > num3))
							{
								((List<int>)(object)suffix).Add((int)obj8);
								obj10 = 0;
								_ = 0;
								obj10 = num13;
								float num31 = 0f - num17;
								float num32 = num31 - num4;
								_ = 0f;
								((Vector3*)(nint)vector)->x = (float)obj10;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S1_v27+8]");
								((Vector3*)(nint)vector)->z = 0f;
								((List<Vector3>)(object)prefix).Add(vector);
								obj2 = 0;
								_ = 0;
								float num33 = num13 + num29;
								obj2 = num33;
								_ = 0f;
								((Vector3*)(nint)vector)->x = (float)obj2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
								((Vector3*)(nint)vector)->z = 0f;
								((List<Vector3>)(object)prefix).Add(vector);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v611 @ S0_v241 (System.Int32)+8]");
								object obj24 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v871 @ S1_v162+8]");
								object obj25 = -1;
								object obj26 = obj25 + obj8;
								obj8 = obj26;
								float num34 = num13 + num29;
								bool flag3 = false;
								num13 = num34;
								jsonDict = null;
							}
							else
							{
								if (num13 == 0f)
								{
									return;
								}
								nint num35 = (nint)typeof(NGUIText);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v758 @ S0_v256 (Il2CppClass<NGUIText>)+BA]");
								object obj27 = (nint)0 & (nint)0x200;
								if (obj27 != null)
								{
									nint num36 = (nint)typeof(NGUIText);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v820 @ S0_v299 (Il2CppClass<NGUIText>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								bool flag4 = alignment != Alignment.Left;
								bool flag5 = !flag4;
								bool flag3 = false;
								if (!flag5)
								{
									bool flag6 = firstChar >= prefix.m_firstChar;
									flag3 = false;
									if (!flag6)
									{
										nint num37 = (nint)typeof(NGUIText);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v935 @ S0_v285 (Il2CppClass<NGUIText>)+BA]");
										object obj28 = (nint)0 & (nint)0x200;
										if (obj28 != null)
										{
											nint num38 = (nint)typeof(NGUIText);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v975 @ S0_v294 (Il2CppClass<NGUIText>)+74]");
											if ((nint)0 == 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
											}
										}
										float completedFactor2 = num13 - finalSpacingX;
										((MissionsManager)(object)prefix).Complete(firstChar, completedFactor2, true);
										flag3 = true;
										firstChar = prefix.m_firstChar;
									}
								}
								nint num39 = (nint)typeof(NGUIText);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v900 @ S0_v266 (Il2CppClass<NGUIText>)+BA]");
								object obj29 = (nint)0 & (nint)0x200;
								if (obj29 != null)
								{
									nint num40 = (nint)typeof(NGUIText);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v940 @ S0_v275 (Il2CppClass<NGUIText>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								float num41 = num17 + finalLineHeight;
								object obj30 = obj8 - 1;
								obj8 = obj30;
								num17 = num41;
								num13 = 0f;
								jsonDict = null;
							}
							goto IL_101a;
						}
					}
					nint num42 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v613 @ S0_v128 (Il2CppClass<NGUIText>)+BA]");
					object obj31 = (nint)0 & (nint)0x200;
					if (obj31 != null)
					{
						nint num43 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v632 @ S0_v228 (Il2CppClass<NGUIText>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					float num44 = jsonDict.GetFloat(text2, num7);
					string text3;
					if (num44 == 0f)
					{
						bool flag3 = false;
						text3 = text2;
					}
					else
					{
						nint num45 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v657 @ S0_v137 (Il2CppClass<NGUIText>)+BA]");
						object obj32 = (nint)0 & (nint)0x200;
						if (obj32 != null)
						{
							nint num46 = (nint)typeof(NGUIText);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v694 @ S0_v221 (Il2CppClass<NGUIText>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						float num47 = num44 + finalSpacingX;
						float num48 = num13 + num47;
						bool flag3;
						if (!(num48 > num3))
						{
							((List<int>)(object)suffix).Add((int)obj8);
							obj10 = 0;
							_ = 0;
							obj10 = num13;
							float num49 = 0f - num17;
							float num50 = num49 - num4;
							_ = 0f;
							((Vector3*)(nint)vector)->x = (float)obj10;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S1_v27+8]");
							((Vector3*)(nint)vector)->z = 0f;
							((List<Vector3>)(object)prefix).Add(vector);
							obj2 = 0;
							_ = 0;
							float num51 = num13 + num47;
							obj2 = num51;
							_ = 0f;
							((Vector3*)(nint)vector)->x = (float)obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
							((Vector3*)(nint)vector)->z = 0f;
							((List<Vector3>)(object)prefix).Add(vector);
							float num52 = num13 + num47;
							flag3 = false;
							num13 = num52;
							goto IL_101a;
						}
						if (num13 == 0f)
						{
							return;
						}
						nint num53 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v791 @ S0_v148 (Il2CppClass<NGUIText>)+BA]");
						object obj33 = (nint)0 & (nint)0x200;
						if (obj33 != null)
						{
							nint num54 = (nint)typeof(NGUIText);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v854 @ S0_v191 (Il2CppClass<NGUIText>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						bool flag7 = alignment != Alignment.Left;
						bool flag8 = !flag7;
						flag3 = false;
						if (!flag8)
						{
							bool flag9 = firstChar >= prefix.m_firstChar;
							flag3 = false;
							if (!flag9)
							{
								nint num55 = (nint)typeof(NGUIText);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v956 @ S0_v177 (Il2CppClass<NGUIText>)+BA]");
								object obj34 = (nint)0 & (nint)0x200;
								if (obj34 != null)
								{
									nint num56 = (nint)typeof(NGUIText);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v986 @ S0_v186 (Il2CppClass<NGUIText>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								float completedFactor3 = num13 - finalSpacingX;
								((MissionsManager)(object)prefix).Complete(firstChar, completedFactor3, true);
								flag3 = true;
								firstChar = prefix.m_firstChar;
							}
						}
						nint num57 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v928 @ S0_v158 (Il2CppClass<NGUIText>)+BA]");
						object obj35 = (nint)0 & (nint)0x200;
						if (obj35 != null)
						{
							nint num58 = (nint)typeof(NGUIText);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v961 @ S0_v167 (Il2CppClass<NGUIText>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						float num59 = num17 + finalLineHeight;
						object obj36 = obj8 - 1;
						obj8 = obj36;
						num17 = num59;
						num13 = 0f;
						text3 = null;
					}
					jsonDict = (JsonDict)(object)text3;
				}
				else
				{
					jsonDict = null;
				}
			}
			goto IL_101a;
			IL_101a:
			char[] array4 = (char[])(obj8 + 1);
			array = array4;
			text2 = (string)(object)jsonDict;
		}
		nint num60 = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ S0_v56 (Il2CppClass<NGUIText>)+BA]");
		object obj37 = (nint)0 & (nint)0x200;
		if (obj37 != null)
		{
			nint num61 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ S0_v80 (Il2CppClass<NGUIText>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (alignment == Alignment.Left || firstChar >= prefix.m_firstChar)
		{
			return;
		}
		nint num62 = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ S0_v69 (Il2CppClass<NGUIText>)+BA]");
		object obj38 = (nint)0 & (nint)0x200;
		if (obj38 != null)
		{
			nint num63 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ S0_v74 (Il2CppClass<NGUIText>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float completedFactor4 = num13 - finalSpacingX;
		((MissionsManager)(object)prefix).Complete(firstChar, completedFactor4, true);
	}

	static NGUIText()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_009d: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<NGUIText>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<NGUIText>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Prepare((string)1);
	}
}
