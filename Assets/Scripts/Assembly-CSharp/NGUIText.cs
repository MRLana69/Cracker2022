using System;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using UnityEngine;

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
		Colored
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

	private static Color32 s_c0;

	private static Color32 s_c1;

	private static float[] mBoldOffset;

	public static void Update()
	{
		Update(request: true);
	}

	public unsafe static void Update(bool request)
	{
		//IL_003f: Expected F8, but got I4
		//IL_031e: Expected I4, but got F8
		//IL_00e5: Expected I, but got Obj
		//IL_01e8: Expected I, but got Obj
		//IL_0143: Expected I, but got Obj
		//IL_0163: Expected F8, but got I
		//IL_0174: Expected F8, but got I
		//IL_0249: Expected I, but got Obj
		//IL_0269: Expected F8, but got I
		//IL_027a: Expected F8, but got I
		//IL_01b7: Expected F8, but got I4
		//IL_02bd: Expected F8, but got I4
		//IL_03dd: Expected I, but got Obj
		//IL_03f3: Expected Obj, but got I
		//IL_02d0: Expected F8, but got I4
		float num = (float)fontSize / pixelDensity;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
		double num3 = default;
		double num2 = Math.Abs(num3);
		if (!(num2 < 2147483648.0))
		{
			num3 = -2147483648.0;
		}
		finalSize = (int)num3;
		float num4 = spacingX * fontScale;
		finalSpacingX = num4;
		float num5 = (float)fontSize + spacingY;
		float num6 = num5 * fontScale;
		finalLineHeight = num6;
		bool flag = bitmapFont != null;
		bool flag2 = !flag;
		bool flag3 = false;
		if (!flag2)
		{
			bool hasSymbols = bitmapFont.hasSymbols;
			bool flag4 = !hasSymbols;
			flag3 = false;
			if (!flag4)
			{
				flag3 = false;
			}
		}
		useSymbols = flag3;
		if (!(dynamicFont != null) || !request)
		{
			return;
		}
		dynamicFont.RequestCharactersInTexture(")_-", finalSize, fontStyle);
		nint num7 = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ S2_v22 (Il2CppClass<NGUIText>)+5C]");
		if (dynamicFont.GetCharacterInfo(')', out *(CharacterInfo*)((nint)0 + (nint)168), finalSize, fontStyle))
		{
			nint num8 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ S0_v104 (Il2CppClass<NGUIText>)+5C]");
			nint num9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ S0_v105 (Il2CppStaticFields<NGUIText>)+C0]");
			double num10 = 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ S0_v105 (Il2CppStaticFields<NGUIText>)+C0]");
			double num11 = Math.Abs(0.0);
			if (!(num11 < 2147483648.0))
			{
				num10 = -2147483648.0;
			}
			if ((int)num10 != 0)
			{
				goto IL_023b;
			}
		}
		dynamicFont.RequestCharactersInTexture("A", finalSize, fontStyle);
		nint num12 = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ S2_v45 (Il2CppClass<NGUIText>)+5C]");
		if (dynamicFont.GetCharacterInfo('A', out *(CharacterInfo*)((nint)0 + (nint)168), finalSize, fontStyle))
		{
			goto IL_023b;
		}
		float num13 = 0f;
		goto IL_02d5;
		IL_02d5:
		baseline = num13;
		return;
		IL_023b:
		nint num14 = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ S0_v76 (Il2CppClass<NGUIText>)+5C]");
		nint num15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ S0_v77 (Il2CppStaticFields<NGUIText>)+C0]");
		double num16 = 0.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ S0_v77 (Il2CppStaticFields<NGUIText>)+C0]");
		double num17 = Math.Abs(0.0);
		if (!(num17 < 2147483648.0))
		{
			num16 = -2147483648.0;
		}
		double num18 = (double)finalSize - num16;
		nint num19 = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ S2_v29 (Il2CppClass<NGUIText>)+5C]");
		object obj = (nint)0 + (nint)168;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ S2_v31+18]");
		double num20 = 0.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ S2_v31+20]");
		double num21 = num20 + 0.0;
		double num22 = Math.Abs(num21);
		if (!(num22 < 2147483648.0))
		{
			num21 = -2147483648.0;
		}
		double num23 = num18 + num21;
		double num24 = num23 * 0.5;
		double num25 = num16 + num24;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		goto IL_02d5;
	}

	public static void Prepare(string text)
	{
		if (dynamicFont != null)
		{
			dynamicFont.RequestCharactersInTexture(text, finalSize, fontStyle);
		}
	}

	public static BMSymbol GetSymbol(string text, int index, int textLength)
	{
		if (bitmapFont != null)
		{
			return bitmapFont.MatchSymbol(text, index, textLength);
		}
		return null;
	}

	public unsafe static float GetGlyphWidth(int ch, int prev)
	{
		//IL_0121: Expected I, but got Obj
		//IL_0183: Expected I, but got Obj
		//IL_0199: Expected VT, but got I
		//IL_01a2: Expected Ref, but got VT
		if (bitmapFont != null)
		{
			BMFont bmFont = bitmapFont.bmFont;
			bool flag = ch == 8201;
			int index = 32;
			if (!flag)
			{
				index = ch;
			}
			BMGlyph bMGlyph = bmFont.GetGlyph(index);
			if (bMGlyph == null)
			{
				return 0f;
			}
			int num2;
			if (prev != 0)
			{
				int kerning = bMGlyph.GetKerning(prev);
				bool flag2 = ch == 8201;
				int num = bMGlyph.advance >> (flag2 ? 1 : 0);
				num2 = kerning + num;
			}
			else
			{
				num2 = bMGlyph.advance;
			}
			return fontScale * (float)num2;
		}
		if (dynamicFont != null)
		{
			char ch2 = (char)(ch & 0xFFFF);
			nint num3 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S2_v6 (Il2CppClass<NGUIText>)+5C]");
			if (dynamicFont.GetCharacterInfo(ch2, out *(CharacterInfo*)((nint)0 + (nint)168), finalSize, fontStyle))
			{
				nint num4 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S0_v39 (Il2CppClass<NGUIText>)+5C]");
				CharacterInfo characterInfo = (CharacterInfo)((nint)0 + (nint)168);
				int advance = ((CharacterInfo*)characterInfo)->advance;
				float num5 = (float)advance * fontScale;
				return num5 * pixelDensity;
			}
		}
		float result = default;
		return result;
	}

	public unsafe static GlyphInfo GetGlyph(int ch, int prev)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01ec: Expected I, but got Obj
		//IL_025c: Expected I, but got Obj
		//IL_027c: Expected F8, but got I
		//IL_028d: Expected F8, but got I
		//IL_02d0: Expected F8, but got I4
		//IL_0618: Expected VT, but got I4
		//IL_0634: Expected Obj, but got I4
		//IL_065d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0662: Expected VT, but got Unknown
		//IL_069b: Expected Obj, but got I
		//IL_06bb: Expected VT, but got I4
		//IL_06db: Expected Obj, but got I4
		//IL_0700: Expected VT, but got I4
		//IL_0853: Expected VT, but got F8
		//IL_086a: Expected I, but got Obj
		//IL_0880: Expected Obj, but got I
		//IL_02e3: Expected F8, but got I4
		//IL_00fb: Expected Obj, but got F4
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected VT, but got Unknown
		//IL_0159: Expected Obj, but got F4
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected VT, but got Unknown
		//IL_08e5: Expected VT, but got F8
		//IL_08fc: Expected I, but got Obj
		//IL_091c: Expected F8, but got I
		//IL_092d: Expected F8, but got I
		//IL_02f6: Expected F8, but got I4
		//IL_0989: Expected I, but got Obj
		//IL_099f: Expected Obj, but got I
		//IL_0309: Expected F8, but got I4
		//IL_0a23: Expected I, but got Obj
		//IL_0a39: Expected VT, but got I
		//IL_0a42: Expected Ref, but got VT
		//IL_0a5b: Expected VT, but got I
		//IL_0a72: Expected I, but got Obj
		//IL_0a88: Expected VT, but got I
		//IL_0a91: Expected Ref, but got VT
		//IL_0aaa: Expected VT, but got I
		//IL_0ac1: Expected I, but got Obj
		//IL_0ad7: Expected VT, but got I
		//IL_0ae0: Expected Ref, but got VT
		//IL_0323: Expected VT, but got I
		//IL_033a: Expected I, but got Obj
		//IL_0350: Expected VT, but got I
		//IL_0359: Expected Ref, but got VT
		//IL_0372: Expected VT, but got I
		//IL_0389: Expected I, but got Obj
		//IL_039f: Expected VT, but got I
		//IL_03a8: Expected Ref, but got VT
		//IL_03be: Expected F4, but got I4
		//IL_04f1: Expected Obj, but got F4
		//IL_04f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fe: Expected VT, but got Unknown
		//IL_054d: Expected Obj, but got F4
		//IL_0555: Unknown result type (might be due to invalid IL or missing references)
		//IL_055a: Expected VT, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		GlyphInfo result;
		if (bitmapFont != null)
		{
			BMFont bmFont = bitmapFont.bmFont;
			bool flag = ch == 8201;
			int index = 32;
			if (!flag)
			{
				index = ch;
			}
			BMGlyph bMGlyph = bmFont.GetGlyph(index);
			bool flag2 = bMGlyph == null;
			result = null;
			if (!flag2)
			{
				int kerning = default;
				if (prev != 0)
				{
					kerning = bMGlyph.GetKerning(prev);
				}
				GlyphInfo glyphInfo = glyph;
				int num = kerning + bMGlyph.offsetX;
				if (prev == 0)
				{
					num = bMGlyph.offsetX;
				}
				glyphInfo.v0 = (Vector2)num;
				GlyphInfo glyphInfo2 = glyph;
				object obj3 = -bMGlyph.offsetY;
				GlyphInfo glyphInfo3 = glyph;
				GlyphInfo glyphInfo4 = glyph;
				Vector2 v = glyphInfo4.v0 + bMGlyph.width;
				glyphInfo3.v1 = v;
				GlyphInfo glyphInfo5 = glyph;
				GlyphInfo glyphInfo6 = glyph;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ S1_v155 (NGUIText+GlyphInfo)+14]");
				object obj4 = -bMGlyph.height;
				GlyphInfo glyphInfo7 = glyph;
				glyphInfo7.u0 = (Vector2)bMGlyph.x;
				GlyphInfo glyphInfo8 = glyph;
				object obj5 = bMGlyph.y + bMGlyph.height;
				GlyphInfo glyphInfo9 = glyph;
				Vector2 u = (Vector2)(bMGlyph.x + bMGlyph.width);
				glyphInfo9.u2 = u;
				GlyphInfo glyphInfo10 = glyph;
				_ = bMGlyph.y;
				GlyphInfo glyphInfo11 = glyph;
				GlyphInfo glyphInfo12 = glyph;
				glyphInfo11.u1 = glyphInfo12.u0;
				GlyphInfo glyphInfo13 = glyph;
				GlyphInfo glyphInfo14 = glyph;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ S1_v176 (NGUIText+GlyphInfo)+2C]");
				_ = 0;
				GlyphInfo glyphInfo15 = glyph;
				GlyphInfo glyphInfo16 = glyph;
				glyphInfo15.u3 = glyphInfo16.u2;
				GlyphInfo glyphInfo17 = glyph;
				GlyphInfo glyphInfo18 = glyph;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ S1_v186 (NGUIText+GlyphInfo)+1C]");
				_ = 0;
				GlyphInfo glyphInfo19 = glyph;
				bool flag3 = ch == 8201;
				int num2 = bMGlyph.advance >> (flag3 ? 1 : 0);
				float advance = (float)kerning + (float)num2;
				glyphInfo19.advance = advance;
				GlyphInfo glyphInfo20 = glyph;
				glyphInfo20.channel = bMGlyph.channel;
				if (fontScale != 1f)
				{
					GlyphInfo glyphInfo21 = glyph;
					float num3 = (float)glyphInfo21.v0 * fontScale;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ S0_v220 (NGUIText+GlyphInfo)+C]");
					float num4 = 0f * fontScale;
					object obj6 = num4 << 32;
					Vector2 v2 = (Vector2)(num3 | obj6);
					glyphInfo21.v0 = v2;
					GlyphInfo glyphInfo22 = glyph;
					float num5 = (float)glyphInfo22.v1 * fontScale;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ S0_v226 (NGUIText+GlyphInfo)+14]");
					float num6 = 0f * fontScale;
					object obj7 = num6 << 32;
					Vector2 v3 = (Vector2)(num5 | obj7);
					glyphInfo22.v1 = v3;
					GlyphInfo glyphInfo23 = glyph;
					float advance2 = glyphInfo23.advance * fontScale;
					glyphInfo23.advance = advance2;
				}
				goto IL_0838;
			}
		}
		else
		{
			bool flag4 = dynamicFont != null;
			bool flag5 = !flag4;
			result = null;
			if (!flag5)
			{
				char ch2 = (char)(ch & 0xFFFF);
				nint num7 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S3_v6 (Il2CppClass<NGUIText>)+5C]");
				bool characterInfo = dynamicFont.GetCharacterInfo(ch2, out *(CharacterInfo*)((nint)0 + (nint)168), finalSize, fontStyle);
				bool flag6 = !characterInfo;
				result = null;
				if (!flag6)
				{
					GlyphInfo glyphInfo24 = glyph;
					nint num8 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ S1_v17 (Il2CppClass<NGUIText>)+5C]");
					nint num9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S1_v18 (Il2CppStaticFields<NGUIText>)+BC]");
					double num10 = 0.0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S1_v18 (Il2CppStaticFields<NGUIText>)+BC]");
					double num11 = Math.Abs(0.0);
					if (!(num11 < 2147483648.0))
					{
						num10 = -2147483648.0;
					}
					glyphInfo24.v0 = (Vector2)num10;
					GlyphInfo glyphInfo25 = glyph;
					nint num12 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ S1_v24 (Il2CppClass<NGUIText>)+5C]");
					object obj8 = (nint)0 + (nint)168;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ S1_v26+14]");
					double num13 = 0.0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ S1_v26+1C]");
					double num14 = num13 + 0.0;
					double num15 = Math.Abs(num14);
					if (!(num15 < 2147483648.0))
					{
						num14 = -2147483648.0;
					}
					glyphInfo25.v1 = (Vector2)num14;
					GlyphInfo glyphInfo26 = glyph;
					nint num16 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ S1_v33 (Il2CppClass<NGUIText>)+5C]");
					nint num17 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ S1_v34 (Il2CppStaticFields<NGUIText>)+C0]");
					double num18 = 0.0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ S1_v34 (Il2CppStaticFields<NGUIText>)+C0]");
					double num19 = Math.Abs(0.0);
					if (!(num19 < 2147483648.0))
					{
						num18 = -2147483648.0;
					}
					double num20 = num18 - (double)baseline;
					GlyphInfo glyphInfo27 = glyph;
					nint num21 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ S1_v41 (Il2CppClass<NGUIText>)+5C]");
					object obj9 = (nint)0 + (nint)168;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v447 @ S1_v43+18]");
					double num22 = 0.0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v447 @ S1_v43+20]");
					double num23 = num22 + 0.0;
					double num24 = Math.Abs(num23);
					if (!(num24 < 2147483648.0))
					{
						num23 = -2147483648.0;
					}
					double num25 = num23 - (double)baseline;
					GlyphInfo glyphInfo28 = glyph;
					nint num26 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ S1_v52 (Il2CppClass<NGUIText>)+5C]");
					CharacterInfo characterInfo2 = (CharacterInfo)((nint)0 + (nint)168);
					Vector2 uvTopLeft = ((CharacterInfo*)characterInfo2)->uvTopLeft;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
					glyphInfo28.u0 = (Vector2)0;
					GlyphInfo glyphInfo29 = glyph;
					nint num27 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ S1_v59 (Il2CppClass<NGUIText>)+5C]");
					CharacterInfo characterInfo3 = (CharacterInfo)((nint)0 + (nint)168);
					Vector2 uvBottomLeft = ((CharacterInfo*)characterInfo3)->uvBottomLeft;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
					glyphInfo29.u1 = (Vector2)0;
					GlyphInfo glyphInfo30 = glyph;
					nint num28 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ S1_v66 (Il2CppClass<NGUIText>)+5C]");
					CharacterInfo characterInfo4 = (CharacterInfo)((nint)0 + (nint)168);
					Vector2 uvBottomRight = ((CharacterInfo*)characterInfo4)->uvBottomRight;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
					glyphInfo30.u2 = (Vector2)0;
					GlyphInfo glyphInfo31 = glyph;
					nint num29 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v528 @ S1_v73 (Il2CppClass<NGUIText>)+5C]");
					CharacterInfo characterInfo5 = (CharacterInfo)((nint)0 + (nint)168);
					Vector2 uvTopRight = ((CharacterInfo*)characterInfo5)->uvTopRight;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
					glyphInfo31.u3 = (Vector2)0;
					GlyphInfo glyphInfo32 = glyph;
					nint num30 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ S1_v79 (Il2CppClass<NGUIText>)+5C]");
					CharacterInfo characterInfo6 = (CharacterInfo)((nint)0 + (nint)168);
					int advance3 = ((CharacterInfo*)characterInfo6)->advance;
					glyphInfo32.advance = advance3;
					GlyphInfo glyphInfo33 = glyph;
					glyphInfo33.channel = 0;
					GlyphInfo glyphInfo34 = glyph;
					GlyphInfo glyphInfo35 = glyph;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
					Vector2 v4 = default;
					glyphInfo34.v0 = v4;
					GlyphInfo glyphInfo36 = glyph;
					GlyphInfo glyphInfo37 = glyph;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
					GlyphInfo glyphInfo38 = glyph;
					GlyphInfo glyphInfo39 = glyph;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
					Vector2 v5 = default;
					glyphInfo38.v1 = v5;
					GlyphInfo glyphInfo40 = glyph;
					GlyphInfo glyphInfo41 = glyph;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
					float num31 = fontScale * pixelDensity;
					if (num31 != 1f)
					{
						GlyphInfo glyphInfo42 = glyph;
						float num32 = (float)glyphInfo42.v0 * num31;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v617 @ S0_v122 (NGUIText+GlyphInfo)+C]");
						float num33 = 0f * num31;
						object obj10 = num33 << 32;
						Vector2 v6 = (Vector2)(num32 | obj10);
						glyphInfo42.v0 = v6;
						GlyphInfo glyphInfo43 = glyph;
						float num34 = (float)glyphInfo43.v1 * num31;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v635 @ S0_v128 (NGUIText+GlyphInfo)+14]");
						float num35 = 0f * num31;
						object obj11 = num35 << 32;
						Vector2 v7 = (Vector2)(num34 | obj11);
						glyphInfo43.v1 = v7;
						GlyphInfo glyphInfo44 = glyph;
						float advance4 = glyphInfo44.advance * num31;
						glyphInfo44.advance = advance4;
					}
					goto IL_0838;
				}
			}
		}
		goto IL_05dd;
		IL_05dd:
		return result;
		IL_0838:
		result = glyph;
		goto IL_05dd;
	}

	public static float ParseAlpha(string text, int index)
	{
		int index2 = index + 1;
		char ch = text.get_Chars(index2);
		int num = NGUIMath.HexToDecimal(ch);
		int index3 = index + 2;
		char ch2 = text.get_Chars(index3);
		int num2 = NGUIMath.HexToDecimal(ch2);
		int num3 = num << 4;
		int num4 = num2 | num3;
		float num5 = (float)num4 / 255f;
		float num6 = Math.Min(num5, 1f);
		bool flag = num5 < 0f;
		float result = 0f;
		if (!flag)
		{
			result = num6;
		}
		return result;
	}

	public unsafe static Color ParseColor(string text, int offset)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0039: Expected F4, but got I
		//IL_0034: Expected native int or pointer, but got VT
		//IL_0046: Expected F4, but got Obj
		//IL_0041: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj = obj2 - 16;
		Color color = ParseColor24(text, offset);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		Color color2 = default;
		((Color*)(nint)color2)->b = 0f;
		((Color*)(nint)color2)->r = (float)obj;
		return color2;
	}

	public unsafe static Color ParseColor24(string text, int offset)
	{
		//IL_014c: Expected native int or pointer, but got VT
		//IL_0159: Expected native int or pointer, but got VT
		//IL_0191: Expected native int or pointer, but got VT
		//IL_01c9: Expected native int or pointer, but got VT
		char ch = text.get_Chars(offset);
		int num = NGUIMath.HexToDecimal(ch);
		int index = offset + 1;
		char ch2 = text.get_Chars(index);
		int num2 = NGUIMath.HexToDecimal(ch2);
		int index2 = offset + 2;
		char ch3 = text.get_Chars(index2);
		int num3 = NGUIMath.HexToDecimal(ch3);
		int index3 = offset + 3;
		char ch4 = text.get_Chars(index3);
		int num4 = NGUIMath.HexToDecimal(ch4);
		int index4 = offset + 4;
		char ch5 = text.get_Chars(index4);
		int num5 = NGUIMath.HexToDecimal(ch5);
		int num6 = num5 << 4;
		int index5 = offset + 5;
		char ch6 = text.get_Chars(index5);
		int num7 = NGUIMath.HexToDecimal(ch6);
		int num8 = num6 | num7;
		float b = (float)num8 * (1f / 255f);
		Color color = default;
		((Color*)(nint)color)->a = 1f;
		((Color*)(nint)color)->b = b;
		int num9 = num3 << 4;
		int num10 = num4 | num9;
		float g = (float)num10 * (1f / 255f);
		((Color*)(nint)color)->g = g;
		int num11 = num << 4;
		int num12 = num2 | num11;
		float r = (float)num12 * (1f / 255f);
		((Color*)(nint)color)->r = r;
		return color;
	}

	public unsafe static Color ParseColor32(string text, int offset)
	{
		//IL_01ad: Expected native int or pointer, but got VT
		//IL_01e5: Expected native int or pointer, but got VT
		//IL_021d: Expected native int or pointer, but got VT
		//IL_0255: Expected native int or pointer, but got VT
		char ch = text.get_Chars(offset);
		int num = NGUIMath.HexToDecimal(ch);
		int index = offset + 1;
		char ch2 = text.get_Chars(index);
		int num2 = NGUIMath.HexToDecimal(ch2);
		int index2 = offset + 2;
		char ch3 = text.get_Chars(index2);
		int num3 = NGUIMath.HexToDecimal(ch3);
		int index3 = offset + 3;
		char ch4 = text.get_Chars(index3);
		int num4 = NGUIMath.HexToDecimal(ch4);
		int index4 = offset + 4;
		char ch5 = text.get_Chars(index4);
		int num5 = NGUIMath.HexToDecimal(ch5);
		int index5 = offset + 5;
		char ch6 = text.get_Chars(index5);
		int num6 = NGUIMath.HexToDecimal(ch6);
		int index6 = offset + 6;
		char ch7 = text.get_Chars(index6);
		int num7 = NGUIMath.HexToDecimal(ch7);
		int num8 = num7 << 4;
		int index7 = offset + 7;
		char ch8 = text.get_Chars(index7);
		int num9 = NGUIMath.HexToDecimal(ch8);
		int num10 = num8 | num9;
		float a = (float)num10 * (1f / 255f);
		Color color = default;
		((Color*)(nint)color)->a = a;
		int num11 = num5 << 4;
		int num12 = num6 | num11;
		float b = (float)num12 * (1f / 255f);
		((Color*)(nint)color)->b = b;
		int num13 = num3 << 4;
		int num14 = num4 | num13;
		float g = (float)num14 * (1f / 255f);
		((Color*)(nint)color)->g = g;
		int num15 = num << 4;
		int num16 = num2 | num15;
		float r = (float)num16 * (1f / 255f);
		((Color*)(nint)color)->r = r;
		return color;
	}

	public unsafe static string EncodeColor(Color c)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0020: Expected native int or pointer, but got VT
		//IL_0032: Expected native int or pointer, but got VT
		object obj = default;
		Color color = (Color)(obj - 16);
		((Color*)(nint)color)->b = c.b;
		((Color*)(nint)color)->r = c.r;
		return EncodeColor24(color);
	}

	public static string EncodeColor(string text, Color c)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		object obj = default;
		Color color = (Color)(obj - 16);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}

	public static string EncodeAlpha(float a)
	{
		//IL_004f: Expected F8, but got I4
		//IL_0095: Invalid comparison between F8 and I4
		//IL_00c4: Invalid comparison between F8 and I4
		//IL_00d2: Expected I4, but got F8
		//IL_005d: Expected F8, but got I4
		float num = a * 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
		double num3 = default;
		double num2 = Math.Abs(num3);
		if (!(num2 < 2147483648.0))
		{
			num3 = -2147483648.0;
		}
		if (!(num3 < 255.0))
		{
			num3 = 255.0;
		}
		bool flag = num3 > 0.0;
		int num4 = (int)num3;
		if (!flag)
		{
			num4 = 0;
		}
		return NGUIMath.DecimalToHex8(num4);
	}

	public unsafe static string EncodeColor24(Color c)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_001b: Expected native int or pointer, but got VT
		//IL_002d: Expected native int or pointer, but got VT
		object obj = default;
		Color color = (Color)(obj - 16);
		((Color*)(nint)color)->b = c.b;
		((Color*)(nint)color)->r = c.r;
		int num = NGUIMath.ColorToInt(color);
		int num2 = num >> 8;
		return NGUIMath.DecimalToHex24(num2);
	}

	public unsafe static string EncodeColor32(Color c)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_001b: Expected native int or pointer, but got VT
		//IL_002d: Expected native int or pointer, but got VT
		object obj = default;
		Color color = (Color)(obj - 16);
		((Color*)(nint)color)->b = c.b;
		((Color*)(nint)color)->r = c.r;
		int num = NGUIMath.ColorToInt(color);
		return NGUIMath.DecimalToHex32(num);
	}

	public unsafe static bool ParseSymbol(string text, ref int index)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected Ref, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected Ref, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Ref, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Ref, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected Ref, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected Ref, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 1;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		return ParseSymbol(text, ref index, null, premultiply: false, ref *(int*)(obj + 12), ref *(bool*)(obj + 11), ref *(bool*)(obj + 10), ref *(bool*)(obj + 9), ref *(bool*)(obj + 8), ref *(bool*)(obj + 7));
	}

	public static bool IsHex(char ch)
	{
		//IL_000e: Expected Obj, but got I4
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		//IL_0047: Expected Obj, but got I4
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected Obj, but got Unknown
		//IL_0080: Expected Obj, but got I4
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected Obj, but got Unknown
		object obj = ch - 48;
		object obj2 = obj & 0xFFFF;
		if ((nint)obj2 >= 10)
		{
			object obj3 = ch - 97;
			object obj4 = obj3 & 0xFFFF;
			if ((nint)obj4 >= 6)
			{
				object obj5 = ch - 65;
				object obj6 = obj5 & 0xFFFF;
				return (nint)obj6 < 6;
			}
		}
		return true;
	}

	public unsafe static bool ParseSymbol(string text, ref int index, BetterList<Color> colors, bool premultiply, ref int sub, ref bool bold, ref bool italic, ref bool underline, ref bool strike, ref bool ignoreColor)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_1054: Expected Obj, but got I4
		//IL_02f4: Expected Obj, but got I4
		//IL_0600: Expected Obj, but got I4
		//IL_0704: Expected Obj, but got I4
		//IL_0a00: Expected Obj, but got I4
		//IL_0d47: Expected Obj, but got I4
		//IL_0aed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af2: Expected VT, but got Unknown
		//IL_0e2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e31: Expected VT, but got Unknown
		//IL_0b91: Expected Obj, but got I
		//IL_0baf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb4: Expected Obj, but got Unknown
		//IL_0be9: Expected F4, but got I
		//IL_0bf9: Expected F4, but got I
		//IL_0c09: Expected F4, but got I
		//IL_0c19: Expected F4, but got I
		//IL_10a7: Expected F4, but got I
		//IL_10a2: Expected native int or pointer, but got VT
		//IL_10c6: Expected F4, but got I
		//IL_10c1: Expected native int or pointer, but got VT
		//IL_0c38: Invalid comparison between I and F4
		//IL_0c4e: Expected F4, but got I
		//IL_0c5e: Expected F4, but got I
		//IL_0c6e: Expected F4, but got I
		//IL_0c7e: Expected F4, but got I
		//IL_0ed5: Expected F4, but got I
		//IL_0ee5: Expected F4, but got I
		//IL_0ef5: Expected F4, but got I
		//IL_0f05: Expected F4, but got I
		//IL_1222: Unknown result type (might be due to invalid IL or missing references)
		//IL_1227: Expected VT, but got Unknown
		//IL_0c9a: Expected I, but got Obj
		//IL_0cd8: Expected F4, but got I
		//IL_0f24: Invalid comparison between I and F4
		//IL_0f3a: Expected F4, but got I
		//IL_0f4a: Expected F4, but got I
		//IL_0f5a: Expected F4, but got I
		//IL_0f6a: Expected F4, but got I
		//IL_0cf2: Invalid comparison between I and F4
		//IL_0f86: Expected I, but got Obj
		//IL_0fc4: Expected F4, but got I
		//IL_0fde: Invalid comparison between I and F4
		object obj = default;
		Color color = (Color)(obj - 144);
		object obj2 = index + 3;
		int num;
		if (text._stringLength >= (nint)obj2)
		{
			char c = text.get_Chars(index);
			if (c == '[')
			{
				int index2 = index + 2;
				char c2 = text.get_Chars(index2);
				if (c2 != ']')
				{
					goto IL_02e1;
				}
				int index3 = index + 1;
				char c3 = text.get_Chars(index3);
				if (c3 == '-')
				{
					if (colors != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [colors @ L2 (BetterList`1<UnityEngine.Color>)+C]");
						if ((nint)0 >= (nint)2)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [colors @ L2 (BetterList`1<UnityEngine.Color>)+C]");
							int index4 = (int)(-1);
							((BetterList<>)(object)colors).RemoveAt(index4);
						}
					}
					num = index + 3;
				}
				else
				{
					string text2 = text.Substring(index, 3);
					if (!(text2 == "[b]"))
					{
						if (text2 != "[i]")
						{
							if (text2 != "[u]")
							{
								if (text2 != "[s]")
								{
									if (!(text2 == "[c]"))
									{
										goto IL_02e1;
									}
									ref bool reference = ref *(bool*)1;
									num = index + 3;
								}
								else
								{
									ref bool reference2 = ref *(bool*)1;
									num = index + 3;
								}
							}
							else
							{
								ref bool reference3 = ref *(bool*)1;
								num = index + 3;
							}
						}
						else
						{
							ref bool reference4 = ref *(bool*)1;
							num = index + 3;
						}
					}
					else
					{
						ref bool reference5 = ref *(bool*)1;
						num = index + 3;
					}
				}
				goto IL_107b;
			}
		}
		goto IL_1075;
		IL_107b:
		ref int reference6 = ref *(int*)num;
		goto IL_1075;
		IL_05ed:
		object obj3 = index + 5;
		if (text._stringLength < (nint)obj3)
		{
			goto IL_1075;
		}
		int index5 = index + 4;
		char c4 = text.get_Chars(index5);
		if (c4 != ']')
		{
			goto IL_06f1;
		}
		string text3 = text.Substring(index, 5);
		if (text3 != "[sub]")
		{
			if (!(text3 == "[sup]"))
			{
				goto IL_06f1;
			}
			ref int reference7 = ref *(int*)2;
			num = index + 5;
		}
		else
		{
			ref int reference7 = ref *(int*)1;
			num = index + 5;
		}
		goto IL_107b;
		IL_02e1:
		object obj4 = index + 4;
		if (text._stringLength < (nint)obj4)
		{
			goto IL_1075;
		}
		int index6 = index + 3;
		char c5 = text.get_Chars(index6);
		if (c5 != ']')
		{
			goto IL_05ed;
		}
		string text4 = text.Substring(index, 4);
		if (!(text4 == "[/b]"))
		{
			if (text4 != "[/i]")
			{
				if (text4 != "[/u]")
				{
					if (text4 != "[/s]")
					{
						if (text4 == "[/c]")
						{
							ref bool reference = ref *(bool*)null;
							num = index + 4;
						}
						else
						{
							int index7 = index + 1;
							char ch = text.get_Chars(index7);
							int index8 = index + 2;
							char ch2 = text.get_Chars(index8);
							if (!IsHex(ch) || !IsHex(ch2))
							{
								goto IL_05ed;
							}
							int num2 = NGUIMath.HexToDecimal(ch);
							int num3 = NGUIMath.HexToDecimal(ch2);
							int num4 = num2 << 4;
							int num5 = num3 | num4;
							float num6 = (float)num5 / 255f;
							mAlpha = num6;
							num = index + 4;
						}
					}
					else
					{
						ref bool reference2 = ref *(bool*)null;
						num = index + 4;
					}
				}
				else
				{
					ref bool reference3 = ref *(bool*)null;
					num = index + 4;
				}
			}
			else
			{
				ref bool reference4 = ref *(bool*)null;
				num = index + 4;
			}
		}
		else
		{
			ref bool reference5 = ref *(bool*)null;
			num = index + 4;
		}
		goto IL_107b;
		IL_06f1:
		object obj5 = index + 6;
		if (text._stringLength < (nint)obj5)
		{
			goto IL_1075;
		}
		int index9 = index + 5;
		char c6 = text.get_Chars(index9);
		if (c6 != ']')
		{
			goto IL_0864;
		}
		string text5 = text.Substring(index, 6);
		if (!(text5 == "[/sub]"))
		{
			if (text5 != "[/sup]")
			{
				if (!(text5 == "[/url]"))
				{
					goto IL_0864;
				}
				num = index + 6;
			}
			else
			{
				ref int reference7 = ref *(int*)null;
				num = index + 6;
			}
		}
		else
		{
			ref int reference7 = ref *(int*)null;
			num = index + 6;
		}
		goto IL_107b;
		IL_0864:
		int index10 = index + 1;
		char c7 = text.get_Chars(index10);
		if (c7 == 'u')
		{
			int index11 = index + 2;
			char c8 = text.get_Chars(index11);
			if (c8 == 'r')
			{
				int index12 = index + 3;
				char c9 = text.get_Chars(index12);
				if (c9 == 'l')
				{
					int index13 = index + 4;
					char c10 = text.get_Chars(index13);
					if (c10 == '=')
					{
						int startIndex = index + 4;
						int num7 = text.IndexOf(']', startIndex);
						num = ((num7 == -1) ? text._stringLength : (num7 + 1));
						goto IL_107b;
					}
				}
			}
		}
		object obj6 = index + 8;
		if (text._stringLength >= (nint)obj6)
		{
			int index14 = index + 7;
			char c11 = text.get_Chars(index14);
			if (c11 == ']')
			{
				int offset = index + 1;
				Color color2 = ParseColor24(text, offset);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+88]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+8C]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+78]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+84]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+80]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+70]");
				_ = 0;
				Color c12 = color + 16;
				string text6 = EncodeColor24(c12);
				int startIndex2 = index + 1;
				string text7 = text.Substring(startIndex2, 6);
				string text8 = text7.ToUpper();
				if (text6 == text8)
				{
					if (colors != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [colors @ L2 (BetterList`1<UnityEngine.Color>)+C]");
						object obj7 = -1;
						object obj8 = obj7 << 4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [colors @ L2 (BetterList`1<UnityEngine.Color>)+8]");
						object obj9 = 0 + obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ S2_v120+18]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ S2_v120+10]");
						_ = 0;
						bool flag = !premultiply;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+8C]");
						float num8 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+80]");
						float num9 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+84]");
						float num10 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+88]");
						float num11 = 0f;
						if (!flag)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+8C]");
							bool flag2 = 0f == 1f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+8C]");
							num8 = 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+80]");
							num9 = 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+84]");
							num10 = 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+88]");
							num11 = 0f;
							if (!flag2)
							{
								nint num12 = (nint)typeof(NGUIText);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v788 @ S1_v141 (Il2CppClass<NGUIText>)+5C]");
								nint num13 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+80]");
								float num14 = 0f - (float)mInvisible;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+8C]");
								float num15 = Math.Min(0f, 1f);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+8C]");
								bool flag3 = 0f < 0f;
								float num16 = 0f;
								if (!flag3)
								{
									num16 = num15;
								}
								float num17 = num14 * num16;
								float num18 = (float)mInvisible + num17;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+84]");
								float num19 = 0f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ S1_v142 (Il2CppStaticFields<NGUIText>)+94]");
								float num20 = num19 - 0f;
								float num21 = num20 * num16;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ S1_v142 (Il2CppStaticFields<NGUIText>)+94]");
								float num22 = 0f + num21;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+88]");
								float num23 = 0f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ S1_v142 (Il2CppStaticFields<NGUIText>)+98]");
								float num24 = num23 - 0f;
								float num25 = num24 * num16;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ S1_v142 (Il2CppStaticFields<NGUIText>)+98]");
								float num26 = 0f + num25;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+8C]");
								float num27 = 0f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ S1_v142 (Il2CppStaticFields<NGUIText>)+9C]");
								float num28 = num27 - 0f;
								float num29 = num28 * num16;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ S1_v142 (Il2CppStaticFields<NGUIText>)+9C]");
								float num30 = 0f + num29;
								num8 = num30;
								num9 = num18;
								num10 = num22;
								num11 = num26;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+68]");
						((Color*)(nint)color)->b = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+60]");
						((Color*)(nint)color)->r = 0f;
						colors.Add(color);
					}
					num = index + 8;
					goto IL_107b;
				}
			}
			else
			{
				object obj10 = index + 10;
				if (text._stringLength >= (nint)obj10)
				{
					int index15 = index + 9;
					char c13 = text.get_Chars(index15);
					if (c13 == ']')
					{
						int offset2 = index + 1;
						Color color3 = ParseColor32(text, offset2);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+88]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+8C]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+58]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+84]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+80]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+50]");
						_ = 0;
						Color c14 = color + 48;
						string text9 = EncodeColor32(c14);
						int startIndex3 = index + 1;
						string text10 = text.Substring(startIndex3, 8);
						string text11 = text10.ToUpper();
						if (text9 == text11)
						{
							if (colors != null)
							{
								bool flag4 = !premultiply;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+80]");
								float num31 = 0f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+84]");
								float num32 = 0f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+88]");
								float num33 = 0f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+8C]");
								float num34 = 0f;
								if (!flag4)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+8C]");
									bool flag5 = 0f == 1f;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+80]");
									num31 = 0f;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+84]");
									num32 = 0f;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+88]");
									num33 = 0f;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+8C]");
									num34 = 0f;
									if (!flag5)
									{
										nint num35 = (nint)typeof(NGUIText);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v886 @ S1_v87 (Il2CppClass<NGUIText>)+5C]");
										nint num36 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+80]");
										float num37 = 0f - (float)mInvisible;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+8C]");
										float num38 = Math.Min(0f, 1f);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+8C]");
										bool flag6 = 0f < 0f;
										float num39 = 0f;
										if (!flag6)
										{
											num39 = num38;
										}
										float num40 = num37 * num39;
										float num41 = (float)mInvisible + num40;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+84]");
										float num42 = 0f;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v887 @ S1_v88 (Il2CppStaticFields<NGUIText>)+94]");
										float num43 = num42 - 0f;
										float num44 = num43 * num39;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v887 @ S1_v88 (Il2CppStaticFields<NGUIText>)+94]");
										float num45 = 0f + num44;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+88]");
										float num46 = 0f;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v887 @ S1_v88 (Il2CppStaticFields<NGUIText>)+98]");
										float num47 = num46 - 0f;
										float num48 = num47 * num39;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v887 @ S1_v88 (Il2CppStaticFields<NGUIText>)+98]");
										float num49 = 0f + num48;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+8C]");
										float num50 = 0f;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v887 @ S1_v88 (Il2CppStaticFields<NGUIText>)+9C]");
										float num51 = num50 - 0f;
										float num52 = num51 * num39;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v887 @ S1_v88 (Il2CppStaticFields<NGUIText>)+9C]");
										float num53 = 0f + num52;
										num31 = num41;
										num32 = num45;
										num33 = num49;
										num34 = num53;
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+48]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+40]");
								_ = 0;
								Color item = color + 32;
								colors.Add(item);
							}
							num = index + 10;
							goto IL_107b;
						}
					}
				}
			}
		}
		goto IL_1075;
		IL_1075:
		return true;
	}

	public unsafe static string StripSymbols(string text)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Ref, but got Unknown
		object obj = default;
		ref int reference = ref *(int*)(obj - 16);
		reference = ref *(int*)null;
		string text2 = default;
		bool flag = text2 == null;
		int num = 0;
		string result = null;
		if (!flag)
		{
			string text3 = default;
			while (num < text3._stringLength)
			{
				char c = text3.get_Chars(num);
				if (c == '[')
				{
					_ = 0;
					_ = 0;
					_ = 0;
					_ = 0;
					_ = 0;
					_ = 0;
					reference = ref *(int*)num;
					if (ParseSymbol(text3, ref reference, null, premultiply: false, ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 3), ref System.Runtime.CompilerServices.Unsafe.As<int, bool>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 11)), ref System.Runtime.CompilerServices.Unsafe.As<int, bool>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 10)), ref System.Runtime.CompilerServices.Unsafe.As<int, bool>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 9)), ref System.Runtime.CompilerServices.Unsafe.As<int, bool>(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 2)), ref System.Runtime.CompilerServices.Unsafe.As<int, bool>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 7))))
					{
						int count = reference - num;
						text3 = text2.Remove(num, count);
						continue;
					}
				}
				int num2 = num + 1;
				num = num2;
			}
			result = text3;
		}
		return result;
	}

	public static void Align(BetterList<Vector3> verts, int indexOffset, float printedWidth, int elements = 4)
	{
		//IL_04fd: Expected Obj, but got I4
		//IL_014a: Expected F8, but got I4
		//IL_00a6: Expected Obj, but got I4
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected Obj, but got Unknown
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected Obj, but got Unknown
		//IL_00e0: Expected Obj, but got F4
		//IL_0750: Unknown result type (might be due to invalid IL or missing references)
		//IL_0755: Expected Obj, but got Unknown
		//IL_0243: Expected Obj, but got I
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected I4, but got Unknown
		//IL_0189: Expected F8, but got I4
		//IL_05b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b5: Expected Obj, but got Unknown
		//IL_0289: Expected Obj, but got I4
		//IL_02b6: Expected Obj, but got I4
		//IL_02bf: Expected Obj, but got I4
		//IL_0788: Unknown result type (might be due to invalid IL or missing references)
		//IL_078d: Expected Obj, but got Unknown
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Expected Obj, but got Unknown
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Expected Obj, but got Unknown
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Expected Obj, but got Unknown
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Expected Obj, but got Unknown
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Expected Obj, but got Unknown
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Expected Obj, but got Unknown
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_033b: Expected Obj, but got Unknown
		//IL_019c: Expected Obj, but got I4
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected Obj, but got Unknown
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected Obj, but got Unknown
		//IL_01d6: Expected Obj, but got F4
		//IL_0657: Expected Obj, but got I4
		//IL_0685: Unknown result type (might be due to invalid IL or missing references)
		//IL_068a: Expected Obj, but got Unknown
		//IL_069a: Unknown result type (might be due to invalid IL or missing references)
		//IL_069f: Expected Obj, but got Unknown
		//IL_06a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ad: Expected Obj, but got Unknown
		//IL_06be: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c3: Expected Obj, but got Unknown
		//IL_0735: Unknown result type (might be due to invalid IL or missing references)
		//IL_073a: Expected Obj, but got Unknown
		//IL_06d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06de: Expected Obj, but got Unknown
		//IL_06ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f3: Expected Obj, but got Unknown
		//IL_06fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0701: Expected Obj, but got Unknown
		//IL_0712: Unknown result type (might be due to invalid IL or missing references)
		//IL_0717: Expected Obj, but got Unknown
		//IL_0454: Unknown result type (might be due to invalid IL or missing references)
		//IL_0459: Expected Obj, but got Unknown
		//IL_0469: Unknown result type (might be due to invalid IL or missing references)
		//IL_046e: Expected Obj, but got Unknown
		//IL_0477: Unknown result type (might be due to invalid IL or missing references)
		//IL_047c: Expected Obj, but got Unknown
		//IL_048d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0492: Expected Obj, but got Unknown
		//IL_049b: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a0: Expected Obj, but got Unknown
		//IL_04a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ae: Expected Obj, but got Unknown
		//IL_04be: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c3: Expected Obj, but got Unknown
		//IL_04cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d1: Expected Obj, but got Unknown
		object obj = alignment - 2;
		int num4 = default;
		int num6 = default;
		float num7 = default;
		float num8 = default;
		object obj5 = default;
		object obj6 = default;
		if (alignment != Alignment.Center)
		{
			if ((nint)obj != 1)
			{
				if ((nint)obj != 2)
				{
					return;
				}
				float num = (float)rectWidth * 0.65f;
				if (!(printedWidth < num))
				{
					float num2 = (float)rectWidth - printedWidth;
					float num3 = num2 * 0.5f;
					if (!(num3 < 1f))
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L0 (BetterList`1<UnityEngine.Vector3>)+C]");
						object obj2 = -num4;
						int num5 = obj2 / elements;
						if (num5 >= 1)
						{
							num6 = elements / 2;
							object obj3 = num5 - 1;
							num7 = 1f / (float)obj3;
							num8 = (float)rectWidth / printedWidth;
							object obj4 = num4 + elements;
							obj5 = 1;
							obj6 = obj4;
							goto IL_0796;
						}
						return;
					}
					return;
				}
				return;
			}
			float num9 = (float)rectWidth - printedWidth;
			if (num9 < 0f)
			{
				return;
			}
			while (true)
			{
				int num10 = num4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L0 (BetterList`1<UnityEngine.Vector3>)+C]");
				if ((nint)num10 < (nint)0)
				{
					object obj7 = num4 * 12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L0 (BetterList`1<UnityEngine.Vector3>)+8]");
					object obj8 = 0 + obj7;
					object obj9 = obj8 + 16;
					float num11 = (float)obj9 + num9;
					obj9 = num11;
					int num12 = num4 + 1;
					num4 = num12;
					continue;
				}
				break;
			}
			return;
		}
		float num13 = (float)rectWidth - printedWidth;
		float num14 = num13 * 0.5f;
		if (num14 < 0f)
		{
			return;
		}
		float num15 = (float)rectWidth - printedWidth;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
		double num17 = default;
		double num16 = Math.Abs(num17);
		if (!(num16 < 2147483648.0))
		{
			num17 = -2147483648.0;
		}
		object obj10 = num17 & 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
		double num19 = default;
		double num18 = Math.Abs(num19);
		if (!(num18 < 2147483648.0))
		{
			num19 = -2147483648.0;
		}
		object obj11 = num19 & 1;
		if (obj11 != null)
		{
			bool flag = obj10 == null;
			object obj12 = num19 & flag;
			if (obj12 == null)
			{
				goto IL_0796;
			}
		}
		while (true)
		{
			int num20 = num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L0 (BetterList`1<UnityEngine.Vector3>)+C]");
			if ((nint)num20 < (nint)0)
			{
				object obj13 = num4 * 12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L0 (BetterList`1<UnityEngine.Vector3>)+8]");
				object obj14 = 0 + obj13;
				object obj15 = obj14 + 16;
				float num21 = (float)obj15 + num14;
				obj15 = num21;
				int num22 = num4 + 1;
				num4 = num22;
				continue;
			}
			break;
		}
		return;
		IL_0796:
		object obj27 = default;
		object obj37 = default;
		while (true)
		{
			object obj16 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L0 (BetterList`1<UnityEngine.Vector3>)+C]");
			if ((nint)obj16 >= 0)
			{
				break;
			}
			object obj17 = obj6 + num6;
			object obj18 = obj17 * 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L0 (BetterList`1<UnityEngine.Vector3>)+8]");
			object obj19 = 0 + obj18;
			object obj20 = obj19 + 16;
			object obj21 = obj6 * 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L0 (BetterList`1<UnityEngine.Vector3>)+8]");
			object obj22 = 0 + obj21;
			object obj23 = obj22 + 16;
			object obj24 = obj20 - obj23;
			float num23 = (float)obj20 * num8;
			float num24 = num23 - (float)obj24;
			float num25 = (float)obj23 * num8;
			float num26 = num25 + (float)obj24;
			float num27 = num23 - num26;
			float num28 = (float)obj5 * num7;
			float num29 = Math.Min(num28, 1f);
			bool flag2 = num28 < 0f;
			float num30 = 0f;
			if (!flag2)
			{
				num30 = num29;
			}
			float num31 = num27 * num30;
			float num32 = num26 + num31;
			float num33 = num24 - num25;
			float num34 = num33 * num30;
			float num35 = num25 + num34;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
			object obj25 = elements - 1;
			bool flag3 = elements == 1;
			object obj26 = obj27;
			if (!flag3)
			{
				bool flag4 = (nint)obj25 == 1;
				object obj28 = obj27;
				if (!flag4)
				{
					if ((nint)obj25 == 2 || (nint)obj25 != 3)
					{
						goto IL_072c;
					}
					object obj29 = obj6 * 12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L0 (BetterList`1<UnityEngine.Vector3>)+8]");
					object obj30 = 0 + obj29;
					object obj31 = obj30 + 16;
					obj31 = obj27;
					object obj32 = obj6 + 1;
					object obj33 = obj32 + 1;
					object obj34 = obj32 * 12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L0 (BetterList`1<UnityEngine.Vector3>)+8]");
					object obj35 = 0 + obj34;
					object obj36 = obj35 + 16;
					obj36 = obj27;
					obj28 = obj37;
					obj6 = obj33;
				}
				object obj38 = obj6 * 12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L0 (BetterList`1<UnityEngine.Vector3>)+8]");
				object obj39 = 0 + obj38;
				object obj40 = obj39 + 16;
				obj40 = obj28;
				object obj41 = obj6 + 1;
				obj26 = obj37;
				obj6 = obj41;
			}
			object obj42 = obj6 * 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L0 (BetterList`1<UnityEngine.Vector3>)+8]");
			object obj43 = 0 + obj42;
			object obj44 = obj43 + 16;
			obj44 = obj26;
			object obj45 = obj6 + 1;
			obj6 = obj45;
			goto IL_072c;
			IL_072c:
			object obj46 = obj5 + 1;
			obj5 = obj46;
		}
	}

	public static int GetExactCharacterIndex(BetterList<Vector3> verts, BetterList<int> indices, Vector2 pos)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_022d: Expected Obj, but got I4
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected Obj, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected Obj, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected Obj, but got Unknown
		//IL_006f: Expected Obj, but got I
		//IL_007c: Invalid comparison between F4 and Obj
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Expected Obj, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected Obj, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected Obj, but got Unknown
		//IL_00d0: Expected Obj, but got I
		//IL_00dd: Invalid comparison between F4 and Obj
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected Obj, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected Obj, but got Unknown
		//IL_0131: Expected Obj, but got I
		//IL_0146: Invalid comparison between F4 and I
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected Obj, but got Unknown
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected Obj, but got Unknown
		//IL_019a: Expected Obj, but got I
		//IL_01af: Invalid comparison between F4 and I
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		object obj3 = 0;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [indices @ L1 (BetterList`1<System.Int32>)+C]");
			if (0 <= (nint)obj3)
			{
				break;
			}
			object obj4 = obj3 << 1;
			object obj5 = obj4 + 1;
			object obj6 = obj4 * 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L0 (BetterList`1<UnityEngine.Vector3>)+8]");
			object obj7 = 0 + obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S1_v11+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S1_v11+10]");
			obj = 0;
			float x = pos.x;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)x) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
			{
				object obj8 = obj5 * 12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L0 (BetterList`1<UnityEngine.Vector3>)+8]");
				object obj9 = 0 + obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S1_v21+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S1_v21+10]");
				obj = 0;
				float x2 = pos.x;
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)x2) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
				{
					object obj10 = obj4 * 12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L0 (BetterList`1<UnityEngine.Vector3>)+8]");
					object obj11 = 0 + obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S1_v29+18]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S1_v29+10]");
					obj = 0;
					float y = pos.y;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
					if (!(y < 0f))
					{
						object obj12 = obj5 * 12;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L0 (BetterList`1<UnityEngine.Vector3>)+8]");
						object obj13 = 0 + obj12;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S1_v37+18]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S1_v37+10]");
						obj = 0;
						float y2 = pos.y;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
						if (!(y2 > 0f))
						{
							object obj14 = obj3 << 2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [indices @ L1 (BetterList`1<System.Int32>)+8]");
							object obj15 = 0 + obj14;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S0_v55+10]");
							return 0;
						}
					}
				}
			}
			object obj16 = obj3 + 1;
			obj3 = obj16;
		}
		return 0;
	}

	public static int GetApproximateCharacterIndex(BetterList<Vector3> verts, BetterList<int> indices, Vector2 pos)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01a2: Expected Obj, but got I4
		//IL_01ab: Expected Obj, but got I4
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_0053: Expected Obj, but got I
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Expected Obj, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected Obj, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected Obj, but got Unknown
		//IL_00d8: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		object obj3 = 0;
		object obj4 = 0;
		float num = float.MaxValue;
		float num2 = float.MaxValue;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L0 (BetterList`1<UnityEngine.Vector3>)+C]");
			if (0 <= (nint)obj4)
			{
				break;
			}
			object obj5 = obj4 * 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L0 (BetterList`1<UnityEngine.Vector3>)+8]");
			object obj6 = 0 + obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S1_v10+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S1_v10+10]");
			obj = 0;
			float num3 = pos.y;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
			float value = num3 - 0f;
			float num4 = Math.Abs(value);
			if (!(num4 > num2))
			{
				object obj7 = obj4 * 12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L0 (BetterList`1<UnityEngine.Vector3>)+8]");
				object obj8 = 0 + obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S1_v21+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S1_v21+10]");
				obj = 0;
				float value2 = pos.x - (float)obj;
				float num5 = Math.Abs(value2);
				object obj9;
				if (num2 > num4)
				{
					num2 = num4;
					obj9 = obj4;
				}
				else
				{
					if (!(num > num5))
					{
						goto IL_01c2;
					}
					obj9 = obj4;
				}
				obj3 = obj9;
				num = num5;
			}
			goto IL_01c2;
			IL_01c2:
			object obj10 = obj4 + 1;
			obj4 = obj10;
		}
		object obj11 = obj3 << 2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [indices @ L1 (BetterList`1<System.Int32>)+8]");
		object obj12 = 0 + obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v23+10]");
		return 0;
	}

	private static bool IsSpace(int ch)
	{
		//IL_000e: Expected Obj, but got I4
		object obj = ch - 8201;
		bool flag = (nint)obj < 3;
		bool result = true;
		if (!flag)
		{
			bool flag2 = ch == 32;
			result = true;
			if (!flag2)
			{
				result = false;
			}
		}
		return result;
	}

	public static void EndLine(ref StringBuilder s)
	{
		//IL_00cc: Expected Obj, but got I4
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected I4, but got Unknown
		//IL_002a: Expected Obj, but got I4
		//IL_0042: Expected Obj, but got I4
		//IL_0068: Expected Obj, but got I4
		//IL_007f: Expected Obj, but got I4
		StringBuilder stringBuilder = s;
		object obj = stringBuilder.m_ChunkOffset + stringBuilder.m_ChunkLength;
		int num = obj - 1;
		if (num >= 1)
		{
			char c = s.get_Chars(num);
			object obj2 = c - 8201;
			bool flag = (nint)obj2 < 3;
			object obj3 = 1;
			if (!flag)
			{
				bool flag2 = c == ' ';
				obj3 = 1;
				if (!flag2)
				{
					obj3 = 0;
				}
			}
			if (obj3 != null)
			{
				s.set_Chars(num, '\n');
				return;
			}
		}
		StringBuilder stringBuilder2 = s.Append('\n');
	}

	private static void ReplaceSpaceWithNewline(ref StringBuilder s)
	{
		//IL_00bd: Expected Obj, but got I4
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected I4, but got Unknown
		//IL_002a: Expected Obj, but got I4
		//IL_0042: Expected Obj, but got I4
		//IL_0068: Expected Obj, but got I4
		//IL_007f: Expected Obj, but got I4
		StringBuilder stringBuilder = s;
		object obj = stringBuilder.m_ChunkOffset + stringBuilder.m_ChunkLength;
		int num = obj - 1;
		if (num < 1)
		{
			return;
		}
		char c = s.get_Chars(num);
		object obj2 = c - 8201;
		bool flag = (nint)obj2 < 3;
		object obj3 = 1;
		if (!flag)
		{
			bool flag2 = c == ' ';
			obj3 = 1;
			if (!flag2)
			{
				obj3 = 0;
			}
		}
		if (obj3 != null)
		{
			s.set_Chars(num, '\n');
		}
	}

	public unsafe static Vector2 CalculatePrintedSize(string text)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0530: Expected I, but got Obj
		//IL_0038: Expected Obj, but got I4
		//IL_001c: Expected Obj, but got I4
		//IL_0056: Expected F4, but got I
		//IL_0342: Expected native int or pointer, but got VT
		//IL_0354: Expected F4, but got VT
		//IL_034f: Expected native int or pointer, but got VT
		//IL_051d: Expected VT, but got I
		//IL_01f2: Expected F8, but got I4
		//IL_02a3: Expected F8, but got I4
		//IL_03f0: Invalid comparison between F8 and I4
		//IL_0469: Invalid comparison between F8 and I4
		//IL_04cd: Expected Obj, but got I4
		//IL_04d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04da: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		nint num = (nint)typeof(Vector2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13 (Il2CppClass<UnityEngine.Vector2>)+5C]");
		nint num2 = 0;
		string text2 = default;
		object obj3;
		if (text2 != null)
		{
			obj3 = 0;
			if (text2._stringLength != 0)
			{
				goto IL_031d;
			}
		}
		obj3 = 1;
		goto IL_031d;
		IL_031d:
		Vector2 vector;
		float y;
		if (obj3 != null)
		{
			vector = Vector2.zeroVector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v14 (Il2CppStaticFields<UnityEngine.Vector2>)+4]");
			y = 0f;
		}
		else
		{
			string text3 = default;
			if (~(encoding ? 1u : 0u) == 0)
			{
				text3 = StripSymbols(text2);
			}
			Prepare(text3);
			float num3 = 0f;
			float num4 = 0f;
			int prev = 0;
			int num5 = default;
			int num26;
			float num8 = default;
			double num13 = default;
			double num22 = default;
			for (; num5 < text3._stringLength; num26 = num5 + 1, num5 = num26)
			{
				char c = text3.get_Chars(num5);
				if (c == '\n')
				{
					bool flag = num3 > num4;
					float num6 = num3;
					if (!flag)
					{
						num6 = num4;
					}
					float num7 = num8 + finalLineHeight;
					num8 = num7;
					num3 = 0f;
					num4 = num6;
				}
				else
				{
					if (c < ' ')
					{
						continue;
					}
					float num16;
					if (~(useSymbols ? 1u : 0u) == 0)
					{
						BMSymbol symbol = GetSymbol(text3, num5, text3._stringLength);
						if (symbol != null)
						{
							float num9 = (float)symbol.mAdvance * fontScale;
							float num10 = finalSpacingX + num9;
							float num11 = num3 + num10;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
							double num12 = Math.Abs(num13);
							double num14 = ((!(num12 < 2147483648.0)) ? (-2147483648.0) : num13);
							if (!(num14 > (double)regionWidth))
							{
								float num15 = num3 + num10;
								num16 = num15;
							}
							else
							{
								float num17 = num8 + finalLineHeight;
								num8 = num17;
								num16 = num10;
							}
							string sequence = symbol.sequence;
							object obj4 = sequence._stringLength - 1;
							int num18 = obj4 + num5;
							num5 = num18;
							num3 = num16;
							prev = 0;
							continue;
						}
					}
					float glyphWidth = GetGlyphWidth(c, prev);
					bool flag2 = glyphWidth == 0f;
					num16 = glyphWidth;
					if (!flag2)
					{
						float num19 = glyphWidth + finalSpacingX;
						float num20 = num3 + num19;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
						double num21 = Math.Abs(num22);
						double num23 = ((!(num21 < 2147483648.0)) ? (-2147483648.0) : num22);
						if (!(num23 > (double)regionWidth))
						{
							float num24 = num3 + num19;
							num16 = num19;
							num3 = num24;
							prev = c;
						}
						else
						{
							float num25 = num8 + finalLineHeight;
							num8 = num25;
							num16 = num19;
							num3 = num19;
							prev = c;
						}
					}
				}
			}
			if (num3 > num4)
			{
				float num27 = num3 - finalSpacingX;
			}
			else
			{
				float num27 = num4;
			}
			y = num8 + finalLineHeight;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			vector = (Vector2)0;
		}
		Vector2 vector2 = default;
		((Vector2*)(nint)vector2)->y = y;
		((Vector2*)(nint)vector2)->x = (float)vector;
		return vector2;
	}

	public static int CalculateOffsetToFit(string text)
	{
		//IL_002a: Expected Obj, but got I4
		//IL_000e: Expected Obj, but got I4
		//IL_02c2: Invalid comparison between I4 and F4
		//IL_0239: Invalid comparison between I4 and F4
		//IL_0289: Expected Obj, but got I
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected Obj, but got Unknown
		//IL_0189: Expected Obj, but got I4
		//IL_0192: Expected Obj, but got I4
		//IL_01e6: Expected Obj, but got I4
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected I4, but got Unknown
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected Obj, but got Unknown
		object obj;
		if (text != null)
		{
			obj = 0;
			if (text._stringLength != 0)
			{
				goto IL_0319;
			}
		}
		obj = 1;
		goto IL_0319;
		IL_0319:
		int num = 0;
		if (obj == null)
		{
			bool flag = regionWidth < 1;
			num = 0;
			if (!flag)
			{
				Prepare(text);
				int num2 = default;
				int num4;
				char c;
				for (int prev = 0; num2 < text._stringLength; num4 = num2 + 1, num2 = num4, prev = c)
				{
					if (~(useSymbols ? 1u : 0u) == 0)
					{
						BMSymbol symbol = GetSymbol(text, num2, text._stringLength);
						if (symbol != null)
						{
							object obj2 = symbol.mAdvance * fontScale;
							float item = finalSpacingX + (float)obj2;
							mSizes.Add(item);
							string sequence = symbol.sequence;
							object obj3 = sequence._stringLength - 1;
							object obj4 = 0;
							while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3))
							{
								mSizes.Add(0f);
								object obj5 = obj4 + 1;
								obj4 = obj5;
							}
							string sequence2 = symbol.sequence;
							object obj6 = sequence2._stringLength - 1;
							int num3 = obj6 + num2;
							num2 = num3;
							c = '\0';
							continue;
						}
					}
					c = text.get_Chars(num2);
					float glyphWidth = GetGlyphWidth(c, prev);
					if (glyphWidth != 0f)
					{
						float item2 = finalSpacingX + glyphWidth;
						mSizes.Add(item2);
					}
				}
				BetterList<float> betterList = mSizes;
				int num5 = regionWidth;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v35 (BetterList`1<System.Single>)+C]");
				num = 0;
				while (true)
				{
					BetterList<float> betterList2 = mSizes;
					if (num < 1 || !((float)num5 > 0f))
					{
						break;
					}
					int num6 = num - 1;
					int num7 = num6 << 2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S0_v43 (BetterList`1<System.Single>)+8]");
					object obj7 = (nint)0 + (nint)num7;
					int num8 = num5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ S1_v17+10]");
					int num9 = (int)((nint)num8 - (nint)0);
					num5 = num9;
					num = num6;
				}
				_ = 0;
				if ((float)num5 < 0f)
				{
					int num10 = num + 1;
					num = num10;
				}
			}
		}
		return num;
	}

	public static string GetEndOfLineThatFits(string text)
	{
		int num = CalculateOffsetToFit(text);
		int length = text._stringLength - num;
		return text.Substring(num, length);
	}

	public static bool WrapText(string text, out string finalText, bool wrapLineColors = false)
	{
		return WrapText(text, out finalText, keepCharCount: false, wrapLineColors);
	}

	public unsafe static bool WrapText(string text, out string finalText, bool keepCharCount, bool wrapLineColors)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Ref, but got Unknown
		//IL_0101: Expected F4, but got I4
		//IL_00c0: Invalid comparison between I4 and F4
		//IL_00cf: Expected F4, but got I4
		//IL_15a5: Expected I4, but got F4
		//IL_0129: Expected F8, but got I4
		//IL_15f4: Invalid comparison between F8 and I4
		//IL_0187: Expected Obj, but got I4
		//IL_016b: Expected Obj, but got I4
		//IL_01b2: Expected I, but got Obj
		//IL_0206: Expected Obj, but got I4
		//IL_164a: Expected Obj, but got I4
		//IL_1653: Expected I4, but got Obj
		//IL_165c: Expected F8, but got I4
		//IL_0254: Expected Obj, but got Ref
		//IL_0264: Expected Obj, but got I
		//IL_0292: Expected VT, but got Ref
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Expected Obj, but got Unknown
		//IL_1488: Expected Obj, but got I
		//IL_1405: Expected Obj, but got I
		//IL_146f: Expected Obj, but got I
		//IL_03f8: Expected Obj, but got I
		//IL_1520: Expected F8, but got I4
		//IL_1529: Invalid comparison between I4 and F8
		//IL_0419: Expected Obj, but got I4
		//IL_0397: Expected Obj, but got I
		//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a5: Expected I4, but got Unknown
		//IL_03cf: Expected Obj, but got I
		//IL_097e: Expected Obj, but got I4
		//IL_09b6: Expected Obj, but got I4
		//IL_16b4: Expected Obj, but got I4
		//IL_17ad: Expected Obj, but got I4
		//IL_07f6: Expected Obj, but got I
		//IL_0814: Unknown result type (might be due to invalid IL or missing references)
		//IL_0819: Expected Obj, but got Unknown
		//IL_0681: Expected Obj, but got I
		//IL_0462: Expected Obj, but got I4
		//IL_1764: Expected Obj, but got I4
		//IL_0788: Expected Obj, but got I
		//IL_07a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ab: Expected Obj, but got Unknown
		//IL_0480: Expected Obj, but got I
		//IL_049d: Expected Obj, but got I
		//IL_04a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ab: Expected I4, but got Unknown
		//IL_04ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cf: Expected Obj, but got Unknown
		//IL_04d7: Expected I4, but got Obj
		//IL_0a08: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0d: Expected Obj, but got Unknown
		//IL_0a16: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1b: Expected Obj, but got Unknown
		//IL_08b2: Expected Obj, but got I
		//IL_04fa: Expected Obj, but got I
		//IL_0861: Unknown result type (might be due to invalid IL or missing references)
		//IL_0866: Expected I4, but got Unknown
		//IL_088a: Unknown result type (might be due to invalid IL or missing references)
		//IL_088f: Expected Obj, but got Unknown
		//IL_052a: Unknown result type (might be due to invalid IL or missing references)
		//IL_052f: Expected I4, but got Unknown
		//IL_058b: Expected VT, but got Ref
		//IL_05ad: Expected Obj, but got I
		//IL_0c19: Expected F8, but got I4
		//IL_05cc: Expected Obj, but got I
		//IL_05d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05de: Expected Obj, but got Unknown
		//IL_1882: Invalid comparison between F8 and I4
		//IL_0a74: Expected Obj, but got I
		//IL_0a7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a82: Expected I4, but got Unknown
		//IL_0c34: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c39: Expected Obj, but got Unknown
		//IL_181f: Expected Obj, but got I
		//IL_184a: Expected Obj, but got I4
		//IL_199e: Expected Obj, but got I4
		//IL_19ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_19b3: Expected Obj, but got Unknown
		//IL_19d2: Expected I4, but got F4
		//IL_133f: Expected I4, but got F4
		//IL_1908: Expected Obj, but got I
		//IL_0c6f: Expected Obj, but got I4
		//IL_0fdb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe0: Expected I4, but got Unknown
		//IL_0cfa: Expected Obj, but got I4
		//IL_0d03: Expected Obj, but got I4
		//IL_10b1: Expected Obj, but got I4
		//IL_0fca: Expected Obj, but got I
		//IL_0b62: Expected Obj, but got I4
		//IL_0b7a: Expected Obj, but got I4
		//IL_12ee: Expected Obj, but got I4
		//IL_10f2: Expected Obj, but got I4
		//IL_0f01: Expected Obj, but got I4
		//IL_0d85: Expected Obj, but got I
		//IL_0da2: Expected Obj, but got I
		//IL_0dab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db0: Expected I4, but got Unknown
		//IL_0dcf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd4: Expected Obj, but got Unknown
		//IL_0ddc: Expected I4, but got Obj
		//IL_0ba0: Expected Obj, but got I4
		//IL_1294: Expected Obj, but got I4
		//IL_12b7: Expected F4, but got I4
		//IL_0dff: Expected Obj, but got I
		//IL_1110: Expected Obj, but got I
		//IL_1127: Expected Obj, but got I4
		//IL_1130: Unknown result type (might be due to invalid IL or missing references)
		//IL_1135: Expected I4, but got Unknown
		//IL_1154: Unknown result type (might be due to invalid IL or missing references)
		//IL_1159: Expected Obj, but got Unknown
		//IL_0e90: Expected VT, but got Ref
		//IL_0eb2: Expected Obj, but got I
		//IL_0bb7: Expected Obj, but got I4
		//IL_117c: Expected Obj, but got I
		//IL_0ed1: Expected Obj, but got I
		//IL_11ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_11b1: Expected Obj, but got Unknown
		//IL_120d: Expected VT, but got Ref
		//IL_122f: Expected Obj, but got I
		//IL_124e: Expected Obj, but got I
		//IL_125b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1260: Expected Obj, but got Unknown
		object obj = default;
		ref int reference = ref *(int*)(obj - 176);
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		bool result;
		double num8;
		object obj2;
		ref string reference2;
		if (regionWidth < 1 || regionHeight < 1 || finalLineHeight < 1f)
		{
			reference2 = ref *(string*)string.Empty;
			result = false;
		}
		else
		{
			int num = regionHeight;
			if (maxLines >= 1)
			{
				float num2 = finalLineHeight * (float)maxLines;
				bool flag = (float)regionHeight < num2;
				float num3 = regionHeight;
				if (!flag)
				{
					num3 = num2;
				}
				num = (int)num3;
			}
			float num4 = ((maxLines >= 1) ? ((float)maxLines) : 1000000f);
			float num5 = (float)num / finalLineHeight;
			if (!(num4 < num5))
			{
				num4 = num5;
			}
			float num6 = num4 + 0.01f;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Floor not resolved\"");
			double num7 = Math.Abs((double)num6);
			num8 = ((!(num7 < 2147483648.0)) ? (-2147483648.0) : ((double)num6));
			if (num8 != 0.0)
			{
				if (text != null)
				{
					obj2 = 0;
					if (text._stringLength != 0)
					{
						goto IL_1613;
					}
				}
				obj2 = 1;
				goto IL_1613;
			}
			reference2 = ref *(string*)string.Empty;
			result = false;
		}
		goto IL_1598;
		IL_1598:
		return result;
		IL_1613:
		string text2 = " ";
		if (obj2 == null)
		{
			text2 = text;
		}
		Prepare(text2);
		StringBuilder stringBuilder = default;
		stringBuilder._002Ector();
		_ = 0;
		nint num9 = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ S0_v104 (Il2CppClass<NGUIText>)+5C]");
		nint num10 = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		bool flag2 = useSymbols;
		object obj3 = flag2 & wrapLineColors;
		bool flag3 = obj3 == null;
		int num11 = 0;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ S0_v105 (Il2CppStaticFields<NGUIText>)+28]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ S0_v105 (Il2CppStaticFields<NGUIText>)+2C]");
			_ = 0;
			object obj4 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref reference, -64));
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+90]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ S0_v105 (Il2CppStaticFields<NGUIText>)+24]");
			_ = 0;
			_ = tint;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+88]");
			_ = 0;
			Color item = (Color)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 14));
			mColors.Add(item);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+A8]");
			num11 = 0;
		}
		object obj5 = 1;
		int num12 = (int)" ";
		double num13 = 1.0;
		int num14 = 1;
		int prev = 0;
		int num15 = regionWidth;
		object obj6 = default;
		int num20 = default;
		double num29 = default;
		while (true)
		{
			char c;
			float num19;
			object obj18;
			BMSymbol bMSymbol;
			ref int reference3;
			if (num11 < text2._stringLength)
			{
				c = text2.get_Chars(num11);
				bool flag4 = c > '⿿';
				obj6 |= flag4;
				if (c != '\n')
				{
					if (~(encoding ? 1u : 0u) == 0)
					{
						if (obj3 == null)
						{
							if (ParseSymbol(text2, ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 42)))
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+A8]");
								object obj7 = -1;
								goto IL_1713;
							}
						}
						else if (ParseSymbol(text2, ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 42), mColors, premultiply, ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 41), ref System.Runtime.CompilerServices.Unsafe.As<int, bool>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 163)), ref System.Runtime.CompilerServices.Unsafe.As<int, bool>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 162)), ref System.Runtime.CompilerServices.Unsafe.As<int, bool>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 161)), ref System.Runtime.CompilerServices.Unsafe.As<int, bool>(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 40)), ref System.Runtime.CompilerServices.Unsafe.As<int, bool>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 159))))
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+9F]");
							if ((nint)0 != 0)
							{
								BetterList<Color> betterList = mColors;
								BetterList<Color> betterList2 = mColors;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v907 @ S2_v106 (BetterList`1<UnityEngine.Color>)+C]");
								object obj8 = -1;
								object obj9 = obj8 << 4;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v902 @ S1_v281 (BetterList`1<UnityEngine.Color>)+8]");
								object obj10 = 0 + obj9;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v913 @ S1_v283+18]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v913 @ S1_v283+10]");
								_ = 0;
							}
							else
							{
								BetterList<Color> betterList3 = mColors;
								BetterList<Color> betterList4 = mColors;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v951 @ S2_v99 (BetterList`1<UnityEngine.Color>)+C]");
								object obj11 = -1;
								object obj12 = obj11 << 4;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v946 @ S1_v268 (BetterList`1<UnityEngine.Color>)+8]");
								object obj13 = 0 + obj12;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v957 @ S1_v270+18]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v957 @ S1_v270+10]");
								_ = 0;
							}
							BetterList<Color> betterList5 = mColors;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1031 @ S0_v467 (BetterList`1<UnityEngine.Color>)+C]");
							int num16 = (int)(-2);
							object obj14 = 0;
							while ((nint)obj14 < num16)
							{
								BetterList<Color> betterList6 = mColors;
								object obj15 = obj14 << 4;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1143 @ S1_v256 (BetterList`1<UnityEngine.Color>)+8]");
								int num17 = 0 + obj15;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1146 @ S1_v258 (System.Int32)+18]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1146 @ S1_v258 (System.Int32)+10]");
								_ = 0;
								object obj16 = obj14 + 1;
								obj14 = obj16;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+A8]");
							object obj17 = -1;
							num12 = num16;
							goto IL_1713;
						}
					}
					if (~(useSymbols ? 1u : 0u) == 0)
					{
						string text3 = text2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+A8]");
						BMSymbol symbol = GetSymbol(text3, 0, text2._stringLength);
						bMSymbol = symbol;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+A8]");
						num12 = 0;
						reference3 = ref reference;
						if (symbol != null)
						{
							float num18 = (float)symbol.mAdvance * fontScale;
							num19 = finalSpacingX + num18;
							obj18 = 0;
							bMSymbol = symbol;
							reference3 = ref reference;
							goto IL_1790;
						}
					}
					float glyphWidth = GetGlyphWidth(c, prev);
					if (glyphWidth == 0f)
					{
						goto IL_1713;
					}
					num19 = finalSpacingX + glyphWidth;
					obj18 = 1;
					bMSymbol = null;
					goto IL_1790;
				}
				if (num13 != num8)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+A8]");
					if ((nint)0 > (nint)num20)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+A8]");
						object obj19 = -num20;
						int length = obj19 + 1;
						string value = text2.Substring(num20, length);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+AC]");
						StringBuilder stringBuilder2 = ((StringBuilder)0).Append(value);
						reference3 = ref *(int*)null;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+AC]");
						StringBuilder stringBuilder3 = ((StringBuilder)0).Append('\n');
					}
					bool flag5 = obj3 == null;
					object obj20 = 0;
					int num21 = num12;
					if (!flag5)
					{
						object obj21;
						while (true)
						{
							BetterList<Color> betterList7 = mColors;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v778 @ S0_v549 (BetterList`1<UnityEngine.Color>)+C]");
							bool flag6 = 0 > (nint)obj20;
							bool flag7 = !flag6;
							obj21 = 0;
							if (flag7)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+AC]");
							StringBuilder stringBuilder4 = (StringBuilder)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v856 @ S0_v580 (System.Text.StringBuilder)+14]");
							nint num22 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v856 @ S0_v580 (System.Text.StringBuilder)+10]");
							object obj22 = num22 + 0;
							int index = obj22 - 1;
							StringBuilder stringBuilder5 = stringBuilder4.Insert(index, "[-]");
							object obj23 = obj20 + 1;
							num12 = (int)stringBuilder4;
							obj20 = obj23;
						}
						while (true)
						{
							BetterList<Color> betterList8 = mColors;
							object obj24 = obj21;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v897 @ S1_v309 (BetterList`1<UnityEngine.Color>)+C]");
							bool flag8 = (nint)obj24 >= 0;
							num21 = num12;
							if (flag8)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+AC]");
							StringBuilder stringBuilder6 = ((StringBuilder)0).Append("[");
							BetterList<Color> betterList9 = mColors;
							object obj25 = obj21 << 4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1048 @ S1_v316 (BetterList`1<UnityEngine.Color>)+8]");
							int num23 = 0 + obj25;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1052 @ S1_v318 (System.Int32)+18]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1052 @ S1_v318 (System.Int32)+10]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+80]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+80]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+78]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+78]");
							_ = 0;
							Color c2 = (Color)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 2));
							string value2 = EncodeColor(c2);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+AC]");
							StringBuilder stringBuilder7 = ((StringBuilder)0).Append(value2);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+AC]");
							StringBuilder stringBuilder8 = ((StringBuilder)0).Append("]");
							object obj26 = obj21 + 1;
							num12 = num23;
							obj21 = obj26;
						}
					}
					double num24 = num13 + 1.0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+A8]");
					int num25 = (int)((nint)0 + (nint)1);
					num20 = num25;
					obj5 = 1;
					num12 = num21;
					num13 = num24;
					prev = 0;
					num15 = regionWidth;
					goto IL_1713;
				}
				num13 = num8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+A8]");
				num11 = 0;
			}
			if (num11 > num20)
			{
				int length2 = num11 - num20;
				string value3 = text2.Substring(num20, length2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+AC]");
				StringBuilder stringBuilder9 = ((StringBuilder)0).Append(value3);
			}
			break;
			IL_1713:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+A8]");
			int num26 = (int)((nint)0 + (nint)1);
			num11 = num26;
			continue;
			IL_17f5:
			int length3;
			string value4 = text2.Substring(num20, length3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+AC]");
			StringBuilder stringBuilder10 = ((StringBuilder)0).Append(value4);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+A8]");
			int num27 = (int)((nint)0 + (nint)1);
			num20 = num27;
			obj5 = 0;
			reference3 = ref *(int*)null;
			goto IL_1a7d;
			IL_1a7d:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
			double num28 = Math.Abs(num29);
			double num30 = ((!(num28 < 2147483648.0)) ? (-2147483648.0) : num29);
			bool flag9 = num30 > -1.0;
			float num32;
			float num31 = num32;
			char c3 = c;
			int num35;
			if (!flag9)
			{
				bool flag10 = num13 == num8;
				object obj27 = flag10 | obj5;
				if (obj27 == null)
				{
					object obj28 = num20 - 1;
					double num33 = num13 + 1.0;
					if (keepCharCount)
					{
						ReplaceSpaceWithNewline(ref System.Runtime.CompilerServices.Unsafe.As<int, StringBuilder>(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 43)));
					}
					else
					{
						EndLine(ref System.Runtime.CompilerServices.Unsafe.As<int, StringBuilder>(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 43)));
					}
					bool flag11 = obj3 == null;
					int num34 = num35;
					object obj29 = 0;
					obj5 = 1;
					num12 = num35;
					num13 = num33;
					prev = 0;
					num15 = regionWidth;
					if (!flag11)
					{
						int num36;
						while (true)
						{
							BetterList<Color> betterList10 = mColors;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1376 @ S0_v351 (BetterList`1<UnityEngine.Color>)+C]");
							bool flag12 = 0 > (nint)obj29;
							bool flag13 = !flag12;
							num36 = 0;
							if (flag13)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+AC]");
							StringBuilder stringBuilder11 = (StringBuilder)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1389 @ S0_v387 (System.Text.StringBuilder)+14]");
							nint num37 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1389 @ S0_v387 (System.Text.StringBuilder)+10]");
							object obj30 = num37 + 0;
							int index2 = obj30 - 1;
							StringBuilder stringBuilder12 = stringBuilder11.Insert(index2, "[-]");
							object obj31 = obj29 + 1;
							num34 = (int)stringBuilder11;
							obj29 = obj31;
						}
						while (true)
						{
							BetterList<Color> betterList11 = mColors;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1423 @ S0_v360 (BetterList`1<UnityEngine.Color>)+C]");
							if ((nint)0 <= (nint)num36)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+AC]");
							StringBuilder stringBuilder13 = ((StringBuilder)0).Append("[");
							BetterList<Color> betterList12 = mColors;
							int num38 = num36 << 4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1490 @ S1_v165 (BetterList`1<UnityEngine.Color>)+8]");
							int num39 = (int)((nint)0 + (nint)num38);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1494 @ S1_v167 (System.Int32)+18]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1494 @ S1_v167 (System.Int32)+10]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+80]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+80]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+78]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+78]");
							_ = 0;
							Color c4 = (Color)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 10));
							string value5 = EncodeColor(c4);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+AC]");
							StringBuilder stringBuilder14 = ((StringBuilder)0).Append(value5);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+AC]");
							StringBuilder stringBuilder15 = ((StringBuilder)0).Append("]");
							int num40 = num36 + 1;
							num34 = num39;
							num36 = num40;
						}
						obj5 = 1;
						num12 = num34;
						num13 = num33;
						prev = 0;
						num15 = regionWidth;
					}
					goto IL_1713;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+A8]");
				int num41 = (int)(-num20);
				bool flag14 = num41 > 0;
				if (!flag14)
				{
					num41 = 0;
				}
				string value6 = text2.Substring(num20, num41);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+AC]");
				StringBuilder stringBuilder16 = ((StringBuilder)0).Append(value6);
				if (obj3 != null)
				{
					BetterList<Color> betterList13 = mColors;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1383 @ S0_v320 (BetterList`1<UnityEngine.Color>)+C]");
					if ((nint)0 >= (nint)1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+AC]");
						StringBuilder stringBuilder17 = ((StringBuilder)0).Append("[-]");
					}
				}
				int num42 = num14 & obj6;
				bool flag15 = num13 != num8;
				double num43 = num13 + 1.0;
				if (!flag15)
				{
					int num44 = num14;
					if (num35 == 0)
					{
						num44 = num42;
					}
					num13 = num43;
					num14 = num44;
					break;
				}
				if (keepCharCount)
				{
					ReplaceSpaceWithNewline(ref System.Runtime.CompilerServices.Unsafe.As<int, StringBuilder>(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 43)));
				}
				else
				{
					EndLine(ref System.Runtime.CompilerServices.Unsafe.As<int, StringBuilder>(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 43)));
				}
				bool flag16 = obj3 == null;
				object obj32 = 0;
				if (!flag16)
				{
					object obj33;
					while (true)
					{
						BetterList<Color> betterList14 = mColors;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1519 @ S0_v273 (BetterList`1<UnityEngine.Color>)+C]");
						bool flag17 = 0 > (nint)obj32;
						bool flag18 = !flag17;
						obj33 = 0;
						if (flag18)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+AC]");
						StringBuilder stringBuilder18 = (StringBuilder)0;
						object obj34 = stringBuilder18.m_ChunkOffset + stringBuilder18.m_ChunkLength;
						int index3 = obj34 - 1;
						StringBuilder stringBuilder19 = stringBuilder18.Insert(index3, "[-]");
						object obj35 = obj32 + 1;
						obj32 = obj35;
					}
					while (true)
					{
						BetterList<Color> betterList15 = mColors;
						object obj36 = obj33;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1576 @ S1_v114 (BetterList`1<UnityEngine.Color>)+C]");
						if ((nint)obj36 >= 0)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+AC]");
						StringBuilder stringBuilder20 = ((StringBuilder)0).Append("[");
						BetterList<Color> betterList16 = mColors;
						object obj37 = obj33 << 4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1594 @ S1_v121 (BetterList`1<UnityEngine.Color>)+8]");
						object obj38 = 0 + obj37;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1598 @ S1_v123+18]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1598 @ S1_v123+10]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+80]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+80]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+78]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+78]");
						_ = 0;
						Color c5 = (Color)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 6));
						string value7 = EncodeColor(c5);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+AC]");
						StringBuilder stringBuilder21 = ((StringBuilder)0).Append(value7);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+AC]");
						StringBuilder stringBuilder22 = ((StringBuilder)0).Append("]");
						object obj39 = obj33 + 1;
						obj33 = obj39;
					}
				}
				if (num35 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+A8]");
					int num45 = (int)((nint)0 + (nint)1);
					num20 = num45;
					obj5 = 1;
					ref bool reference4 = ref *(bool*)null;
					ref bool reference5 = ref *(flag14 ? ((bool*)1) : ((bool*)null));
					reference3 = ref *(int*)null;
					num13 = num43;
					num31 = regionWidth;
					c3 = '\0';
				}
				else
				{
					float num46 = (float)regionWidth - num19;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+A8]");
					num20 = 0;
					obj5 = 1;
					ref bool reference4 = ref *(bool*)null;
					ref bool reference5 = ref *(flag14 ? ((bool*)1) : ((bool*)null));
					reference3 = ref *(int*)null;
					num13 = num43;
					num14 = num42;
					num31 = num46;
					c3 = '\0';
				}
			}
			if (obj18 != null)
			{
				num12 = num35;
				prev = c3;
				num15 = (int)num31;
			}
			else
			{
				bool flag19 = bMSymbol.mLength == 0;
				bool flag20 = !flag19;
				int num47 = bMSymbol.mLength;
				if (!flag20)
				{
					string sequence = bMSymbol.sequence;
					bMSymbol.mLength = sequence._stringLength;
					num47 = sequence._stringLength;
				}
				object obj40 = num47 - 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+A8]");
				object obj41 = 0 + obj40;
				num12 = num35;
				prev = 0;
				num15 = (int)num31;
			}
			goto IL_1713;
			IL_1790:
			num32 = (float)num15 - num19;
			object obj42 = c - 8201;
			bool flag21 = (nint)obj42 < 3;
			num35 = 1;
			if (!flag21)
			{
				bool flag22 = c == ' ';
				num35 = 1;
				if (!flag22)
				{
					num35 = 0;
				}
			}
			if (num35 != 0)
			{
				object obj43 = obj6 ^ 1;
				object obj44 = obj43 & 1;
				if (obj44 != null)
				{
					int num48 = num20;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+A8]");
					if ((nint)num48 < (nint)0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+A8]");
						object obj45 = -num20;
						int num49 = obj45 + 1;
						bool flag23 = num13 != num8;
						length3 = num49;
						if (!flag23)
						{
							bool flag24 = !(num32 > 0f);
							bool flag25 = !flag24;
							length3 = num49;
							if (!flag25)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+A8]");
								bool flag26 = (nint)0 >= (nint)text2._stringLength;
								length3 = num49;
								if (!flag26)
								{
									string text4 = text2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+A8]");
									char c6 = text4.get_Chars(0);
									if (c6 >= ' ')
									{
										object obj46 = c6 - 8201;
										bool flag27 = (nint)obj46 < 3;
										object obj47 = 1;
										if (!flag27)
										{
											bool flag28 = c6 == ' ';
											obj47 = 1;
											if (!flag28)
											{
												obj47 = 0;
											}
										}
										bool flag29 = obj47 == null;
										length3 = num49;
										if (flag29)
										{
											goto IL_17f5;
										}
									}
									int num50 = num49 - 1;
									length3 = num50;
								}
							}
						}
						goto IL_17f5;
					}
				}
			}
			goto IL_1a7d;
		}
		if (obj3 != null)
		{
			BetterList<Color> betterList17 = mColors;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v577 @ S0_v158 (BetterList`1<UnityEngine.Color>)+C]");
			if ((nint)0 >= (nint)1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+AC]");
				StringBuilder stringBuilder23 = ((StringBuilder)0).Append("[-]");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+AC]");
		object obj48 = 0;
		object obj49 = obj48;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v559 @ S2_v15+D4] (should have been resolved before IL gen)");
		object obj50 = default;
		reference2 = ref *(string*)obj50;
		BetterList<Color> betterList18 = mColors;
		_ = 0;
		int num51 = num14 & 1;
		bool flag30 = num51 == 0;
		result = false;
		if (!flag30)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+A8]");
			bool flag31 = (nint)0 == text2._stringLength;
			result = true;
			if (!flag31)
			{
				double num52 = maxLines;
				if (!((double)maxLines < num8))
				{
					num52 = num8;
				}
				result = !(num13 > num52);
			}
		}
		goto IL_1598;
	}

	public unsafe static void Print(string text, BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Ref, but got Unknown
		//IL_2b92: Expected Obj, but got Ref
		//IL_2b9b: Expected Obj, but got I4
		//IL_2bb5: Expected Obj, but got Ref
		//IL_2bbe: Expected Obj, but got I4
		//IL_0038: Expected Obj, but got I4
		//IL_001c: Expected Obj, but got I4
		//IL_0059: Expected Obj, but got Ref
		//IL_0066: Expected Obj, but got I8
		//IL_008d: Expected VT, but got Ref
		//IL_00b3: Expected I, but got Obj
		//IL_00d1: Expected I, but got Obj
		//IL_00f0: Expected Obj, but got VT
		//IL_010d: Expected Obj, but got I
		//IL_012a: Expected Obj, but got I
		//IL_0147: Expected Obj, but got I
		//IL_0155: Expected I, but got Obj
		//IL_0173: Expected I, but got Obj
		//IL_0192: Expected Obj, but got VT
		//IL_01af: Expected Obj, but got I
		//IL_01cc: Expected Obj, but got I
		//IL_01e9: Expected Obj, but got I
		//IL_01f7: Expected I, but got Obj
		//IL_0216: Expected F4, but got VT
		//IL_0229: Invalid comparison between VT and F4
		//IL_2c1f: Expected F4, but got I
		//IL_2c34: Invalid comparison between I and F4
		//IL_2c81: Expected F4, but got I
		//IL_2c96: Invalid comparison between I and F4
		//IL_2ce3: Expected F4, but got I
		//IL_2cf8: Invalid comparison between I and F4
		//IL_02a1: Expected Obj, but got Ref
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Expected Obj, but got Unknown
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Expected Obj, but got Unknown
		//IL_031d: Expected I4, but got VT
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Expected I4, but got Unknown
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_0337: Expected I4, but got Unknown
		//IL_0380: Expected Obj, but got Ref
		//IL_038e: Expected Obj, but got Ref
		//IL_03b1: Expected Obj, but got Ref
		//IL_03e2: Expected Obj, but got Ref
		//IL_05d2: Expected I, but got Obj
		//IL_1082: Expected VT, but got F4
		//IL_10c1: Expected VT, but got F4
		//IL_070d: Expected Obj, but got Ref
		//IL_0735: Expected Obj, but got I
		//IL_0753: Unknown result type (might be due to invalid IL or missing references)
		//IL_0758: Expected Obj, but got Unknown
		//IL_0775: Expected Obj, but got I
		//IL_07e8: Expected Obj, but got I
		//IL_11fe: Expected Ref, but got F4
		//IL_0615: Expected Obj, but got Ref
		//IL_063d: Expected Obj, but got I
		//IL_065b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0660: Expected Obj, but got Unknown
		//IL_067d: Expected Obj, but got I
		//IL_068b: Expected I, but got Obj
		//IL_06da: Expected F4, but got I
		//IL_06ea: Expected F4, but got I
		//IL_06fa: Expected F4, but got I
		//IL_118c: Expected Ref, but got F4
		//IL_0b15: Expected F8, but got I4
		//IL_1271: Expected F8, but got I4
		//IL_302b: Invalid comparison between F8 and I4
		//IL_3289: Invalid comparison between I4 and F8
		//IL_446e: Expected Obj, but got Ref
		//IL_4477: Expected Obj, but got I4
		//IL_44a2: Expected VT, but got Ref
		//IL_44bd: Expected Obj, but got Ref
		//IL_44c6: Expected Obj, but got I4
		//IL_44f1: Expected VT, but got Ref
		//IL_450c: Expected Obj, but got Ref
		//IL_4515: Expected Obj, but got I4
		//IL_4540: Expected VT, but got Ref
		//IL_32d6: Expected Obj, but got I4
		//IL_32ee: Expected Obj, but got I4
		//IL_0bd2: Expected Obj, but got Ref
		//IL_0bdb: Expected Obj, but got I4
		//IL_0c06: Expected VT, but got Ref
		//IL_086b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0870: Expected Obj, but got Unknown
		//IL_087e: Expected Obj, but got VT
		//IL_0887: Unknown result type (might be due to invalid IL or missing references)
		//IL_088c: Expected Obj, but got Unknown
		//IL_089a: Expected I4, but got Obj
		//IL_08a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a7: Expected I4, but got Unknown
		//IL_08af: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b4: Expected I4, but got Unknown
		//IL_08d3: Expected Obj, but got I
		//IL_08f5: Expected Obj, but got I4
		//IL_1338: Expected Obj, but got I4
		//IL_30fd: Expected Obj, but got I4
		//IL_310d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3112: Expected Obj, but got Unknown
		//IL_33fd: Expected Obj, but got I4
		//IL_3415: Expected VT, but got I4
		//IL_134f: Expected Obj, but got I4
		//IL_0cc5: Expected Obj, but got Ref
		//IL_0cd5: Expected Obj, but got I
		//IL_0ced: Expected Obj, but got Ref
		//IL_0cfb: Expected Obj, but got Ref
		//IL_0d20: Expected Obj, but got Ref
		//IL_0d4d: Expected Obj, but got Ref
		//IL_0d7a: Expected VT, but got Ref
		//IL_0dac: Expected VT, but got Ref
		//IL_2fa6: Expected Obj, but got I
		//IL_0908: Expected VT, but got Ref
		//IL_091f: Expected I4, but got Obj
		//IL_0934: Expected VT, but got I
		//IL_0951: Expected native int or pointer, but got VT
		//IL_0976: Unknown result type (might be due to invalid IL or missing references)
		//IL_097b: Expected Obj, but got Unknown
		//IL_13c4: Expected VT, but got I4
		//IL_0de3: Expected VT, but got Ref
		//IL_0e1d: Expected VT, but got Ref
		//IL_0e3a: Expected F4, but got I
		//IL_0ee3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee8: Expected I4, but got Unknown
		//IL_0ef1: Expected Obj, but got I4
		//IL_13db: Expected VT, but got I4
		//IL_0f89: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f8e: Expected Obj, but got Unknown
		//IL_0fa5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0faa: Expected Obj, but got Unknown
		//IL_0fb3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb8: Expected Obj, but got Unknown
		//IL_0fc6: Expected I4, but got Obj
		//IL_0fce: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd3: Expected I4, but got Unknown
		//IL_0fdb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe0: Expected I4, but got Unknown
		//IL_0fe8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fed: Expected I4, but got Unknown
		//IL_0ff6: Expected Obj, but got I4
		//IL_16b1: Expected VT, but got I
		//IL_3472: Expected Obj, but got I4
		//IL_0f0e: Expected VT, but got Ref
		//IL_0f24: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f29: Expected Obj, but got Unknown
		//IL_462b: Unknown result type (might be due to invalid IL or missing references)
		//IL_4630: Expected Obj, but got Unknown
		//IL_4663: Expected Obj, but got I4
		//IL_34b0: Invalid comparison between VT and I4
		//IL_34ca: Expected Obj, but got I4
		//IL_4577: Expected Obj, but got I4
		//IL_1453: Expected Obj, but got Ref
		//IL_1460: Unknown result type (might be due to invalid IL or missing references)
		//IL_1465: Expected Obj, but got Unknown
		//IL_1472: Expected VT, but got Obj
		//IL_148d: Expected Obj, but got Ref
		//IL_149a: Unknown result type (might be due to invalid IL or missing references)
		//IL_149f: Expected Obj, but got Unknown
		//IL_14ac: Expected VT, but got Obj
		//IL_14c7: Expected Obj, but got Ref
		//IL_14e4: Expected Obj, but got I
		//IL_14f9: Expected Obj, but got I
		//IL_1519: Expected Obj, but got Ref
		//IL_1536: Expected Obj, but got I
		//IL_155b: Expected Obj, but got I
		//IL_15bb: Expected Obj, but got I4
		//IL_1013: Expected VT, but got Ref
		//IL_1029: Unknown result type (might be due to invalid IL or missing references)
		//IL_102e: Expected Obj, but got Unknown
		//IL_3505: Expected VT, but got I4
		//IL_20cc: Expected Obj, but got I
		//IL_46a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_46ae: Expected I4, but got Unknown
		//IL_46b7: Expected Obj, but got I4
		//IL_1ed5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1eda: Expected Obj, but got Unknown
		//IL_3c06: Expected VT, but got Ref
		//IL_3c53: Expected VT, but got Ref
		//IL_15e2: Expected VT, but got Ref
		//IL_1611: Expected VT, but got Ref
		//IL_398a: Invalid comparison between Obj and VT
		//IL_39a3: Expected VT, but got I
		//IL_1ab4: Expected VT, but got I4
		//IL_206b: Expected VT, but got Ref
		//IL_209a: Expected Obj, but got Ref
		//IL_1dfc: Expected VT, but got Ref
		//IL_1e3a: Expected VT, but got Ref
		//IL_1645: Expected VT, but got Ref
		//IL_1674: Expected VT, but got Ref
		//IL_3d09: Expected VT, but got Ref
		//IL_3d84: Expected VT, but got Ref
		//IL_3dff: Expected VT, but got Ref
		//IL_3c89: Expected VT, but got Ref
		//IL_1e7d: Expected VT, but got Ref
		//IL_1e9d: Expected Obj, but got Ref
		//IL_168f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1694: Expected Obj, but got Unknown
		//IL_3b0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b11: Expected Obj, but got Unknown
		//IL_1ad1: Expected VT, but got Ref
		//IL_1ae7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1aec: Expected Obj, but got Unknown
		//IL_1fdb: Expected VT, but got Ref
		//IL_1ff1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ff6: Expected Obj, but got Unknown
		//IL_200e: Expected F4, but got I
		//IL_201e: Expected F4, but got I
		//IL_1cd9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cde: Expected Obj, but got Unknown
		//IL_1cff: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d04: Expected Obj, but got Unknown
		//IL_1d21: Expected I4, but got Obj
		//IL_1d29: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d2e: Expected I4, but got Unknown
		//IL_1d36: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d3b: Expected I4, but got Unknown
		//IL_1d43: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d48: Expected I4, but got Unknown
		//IL_1d51: Expected VT, but got I4
		//IL_3ec3: Invalid comparison between VT and I4
		//IL_3edd: Expected Obj, but got I4
		//IL_3b29: Expected Obj, but got I4
		//IL_3b36: Invalid comparison between Obj and VT
		//IL_3b68: Expected VT, but got I
		//IL_1d70: Expected VT, but got I4
		//IL_23d4: Expected VT, but got Ref
		//IL_23f5: Expected Obj, but got Ref
		//IL_23fe: Expected Obj, but got I4
		//IL_2423: Expected VT, but got Ref
		//IL_3ef4: Expected VT, but got I4
		//IL_1810: Unknown result type (might be due to invalid IL or missing references)
		//IL_1815: Expected Obj, but got Unknown
		//IL_182c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1831: Expected Obj, but got Unknown
		//IL_1848: Unknown result type (might be due to invalid IL or missing references)
		//IL_184d: Expected Obj, but got Unknown
		//IL_1882: Expected VT, but got Obj
		//IL_3f7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f82: Expected I4, but got Unknown
		//IL_3f8b: Expected VT, but got I4
		//IL_24ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_24f3: Expected Obj, but got Unknown
		//IL_256e: Expected VT, but got Ref
		//IL_2466: Expected VT, but got Ref
		//IL_24a4: Expected VT, but got Ref
		//IL_46d3: Expected Obj, but got VT
		//IL_46ec: Expected Obj, but got I4
		//IL_2169: Expected Obj, but got Ref
		//IL_2176: Unknown result type (might be due to invalid IL or missing references)
		//IL_217b: Expected Obj, but got Unknown
		//IL_2188: Expected VT, but got Obj
		//IL_21a3: Expected Obj, but got Ref
		//IL_21b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_21b5: Expected Obj, but got Unknown
		//IL_21c2: Expected VT, but got Obj
		//IL_21dd: Expected Obj, but got Ref
		//IL_21fa: Expected Obj, but got I
		//IL_220f: Expected Obj, but got I
		//IL_222f: Expected Obj, but got Ref
		//IL_224c: Expected Obj, but got I
		//IL_2271: Expected Obj, but got I
		//IL_1d8d: Expected VT, but got Ref
		//IL_1da3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1da8: Expected Obj, but got Unknown
		//IL_46fa: Expected Obj, but got I4
		//IL_25df: Expected VT, but got Ref
		//IL_264b: Expected VT, but got Ref
		//IL_3f0a: Invalid comparison between Obj and VT
		//IL_2291: Expected VT, but got I4
		//IL_4408: Invalid comparison between Obj and VT
		//IL_2abb: Expected VT, but got I4
		//IL_26bc: Expected VT, but got Ref
		//IL_26d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_26d7: Expected Obj, but got Unknown
		//IL_26e7: Expected F4, but got I
		//IL_26f7: Expected F4, but got I
		//IL_22c3: Expected VT, but got Ref
		//IL_22fd: Expected VT, but got Ref
		//IL_2ad8: Expected VT, but got Ref
		//IL_2aee: Unknown result type (might be due to invalid IL or missing references)
		//IL_2af3: Expected Obj, but got Unknown
		//IL_233c: Expected VT, but got Ref
		//IL_2376: Expected VT, but got Ref
		//IL_2391: Unknown result type (might be due to invalid IL or missing references)
		//IL_2396: Expected Obj, but got Unknown
		//IL_1942: Unknown result type (might be due to invalid IL or missing references)
		//IL_1947: Expected Obj, but got Unknown
		//IL_195e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1963: Expected Obj, but got Unknown
		//IL_1971: Expected Obj, but got VT
		//IL_197a: Unknown result type (might be due to invalid IL or missing references)
		//IL_197f: Expected Obj, but got Unknown
		//IL_1995: Unknown result type (might be due to invalid IL or missing references)
		//IL_199a: Expected I4, but got Unknown
		//IL_19a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_19a7: Expected I4, but got Unknown
		//IL_19af: Unknown result type (might be due to invalid IL or missing references)
		//IL_19b4: Expected I4, but got Unknown
		//IL_19bd: Expected VT, but got I4
		//IL_19c6: Expected Obj, but got I4
		//IL_3924: Expected Obj, but got I4
		//IL_3953: Expected Ref, but got F4
		//IL_396c: Expected VT, but got I
		//IL_19e5: Expected Obj, but got I4
		//IL_280e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2813: Expected Obj, but got Unknown
		//IL_282a: Unknown result type (might be due to invalid IL or missing references)
		//IL_282f: Expected Obj, but got Unknown
		//IL_2846: Unknown result type (might be due to invalid IL or missing references)
		//IL_284b: Expected Obj, but got Unknown
		//IL_2880: Expected VT, but got Obj
		//IL_1a04: Expected VT, but got Ref
		//IL_1a30: Expected VT, but got Ref
		//IL_1a57: Expected VT, but got Ref
		//IL_1a83: Expected VT, but got Ref
		//IL_1a99: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a9e: Expected Obj, but got Unknown
		//IL_2940: Unknown result type (might be due to invalid IL or missing references)
		//IL_2945: Expected Obj, but got Unknown
		//IL_2953: Expected Obj, but got VT
		//IL_295c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2961: Expected Obj, but got Unknown
		//IL_296f: Expected Obj, but got VT
		//IL_2978: Unknown result type (might be due to invalid IL or missing references)
		//IL_297d: Expected Obj, but got Unknown
		//IL_2993: Unknown result type (might be due to invalid IL or missing references)
		//IL_2998: Expected I4, but got Unknown
		//IL_29a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_29a5: Expected I4, but got Unknown
		//IL_29ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_29b2: Expected I4, but got Unknown
		//IL_29bb: Expected VT, but got I4
		//IL_29c4: Expected Obj, but got I4
		//IL_43aa: Expected Obj, but got I4
		//IL_43d9: Expected Ref, but got F4
		//IL_29e3: Expected Obj, but got I4
		//IL_2a02: Expected VT, but got Ref
		//IL_2a2e: Expected VT, but got Ref
		//IL_2a55: Expected VT, but got Ref
		//IL_2a81: Expected VT, but got Ref
		//IL_2a97: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a9c: Expected Obj, but got Unknown
		object obj = default;
		ref int reference = ref *(int*)(obj - 1200);
		object obj2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 298));
		obj2 = 0;
		_ = 0;
		_ = 0;
		object obj3 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 290));
		obj3 = 0;
		_ = 0;
		object obj4;
		if (text != null)
		{
			obj4 = 0;
			if (text._stringLength != 0)
			{
				goto IL_2be1;
			}
		}
		obj4 = 1;
		goto IL_2be1;
		IL_2be1:
		if (obj4 != null)
		{
			return;
		}
		Prepare(text);
		object obj5 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 286));
		obj5 = 4575657222473777152L;
		_ = 4575657222473777152L;
		_ = 4575657222473777152L;
		Color item = (Color)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 130));
		mColors.Add(item);
		mAlpha = 1f;
		nint num = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ S0_v42 (Il2CppClass<NGUIText>)+5C]");
		nint num2 = 0;
		nint num3 = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ S0_v46 (Il2CppClass<NGUIText>)+5C]");
		nint num4 = 0;
		object obj6 = tint * gradientBottom;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ S0_v43 (Il2CppStaticFields<NGUIText>)+24]");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ S0_v47 (Il2CppStaticFields<NGUIText>)+4C]");
		object obj7 = num5 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ S0_v43 (Il2CppStaticFields<NGUIText>)+28]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ S0_v47 (Il2CppStaticFields<NGUIText>)+50]");
		object obj8 = num6 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ S0_v43 (Il2CppStaticFields<NGUIText>)+2C]");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ S0_v47 (Il2CppStaticFields<NGUIText>)+54]");
		object obj9 = num7 * 0;
		nint num8 = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ S0_v61 (Il2CppClass<NGUIText>)+5C]");
		nint num9 = 0;
		nint num10 = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ S0_v65 (Il2CppClass<NGUIText>)+5C]");
		nint num11 = 0;
		object obj10 = tint * gradientTop;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ S0_v62 (Il2CppStaticFields<NGUIText>)+24]");
		nint num12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ S0_v66 (Il2CppStaticFields<NGUIText>)+5C]");
		object obj11 = num12 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ S0_v62 (Il2CppStaticFields<NGUIText>)+28]");
		nint num13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ S0_v66 (Il2CppStaticFields<NGUIText>)+60]");
		object obj12 = num13 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ S0_v62 (Il2CppStaticFields<NGUIText>)+2C]");
		nint num14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ S0_v66 (Il2CppStaticFields<NGUIText>)+64]");
		object obj13 = num14 * 0;
		nint num15 = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ S0_v80 (Il2CppClass<NGUIText>)+5C]");
		nint num16 = 0;
		float num17 = Math.Min((float)tint, 1f);
		bool flag = tint < (object)0f;
		float num18 = 0f;
		if (!flag)
		{
			num18 = num17;
		}
		float num19 = num18 * 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ S0_v81 (Il2CppStaticFields<NGUIText>)+24]");
		float num20 = Math.Min(0f, 1f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ S0_v81 (Il2CppStaticFields<NGUIText>)+24]");
		bool flag2 = 0f < 0f;
		float num21 = 0f;
		if (!flag2)
		{
			num21 = num20;
		}
		float num22 = num21 * 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ S0_v81 (Il2CppStaticFields<NGUIText>)+28]");
		float num23 = Math.Min(0f, 1f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ S0_v81 (Il2CppStaticFields<NGUIText>)+28]");
		bool flag3 = 0f < 0f;
		float num24 = 0f;
		if (!flag3)
		{
			num24 = num23;
		}
		float num25 = num24 * 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ S0_v81 (Il2CppStaticFields<NGUIText>)+2C]");
		float num26 = Math.Min(0f, 1f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ S0_v81 (Il2CppStaticFields<NGUIText>)+2C]");
		bool flag4 = 0f < 0f;
		float num27 = 0f;
		if (!flag4)
		{
			num27 = num26;
		}
		float num28 = num27 * 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
		object obj14 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 296));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		float num29 = (float)finalSize * pixelDensity;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		object obj16 = default;
		object obj15 = obj16 & 0xFF;
		object obj18 = default;
		object obj17 = obj18 << 8;
		object obj19 = obj17 & 0xFF00;
		Color32 color = default;
		int num30 = color << 16;
		int num31 = obj19 | num30;
		int num32 = obj15 | num31;
		int num33 = default;
		int num34 = default;
		if (bitmapFont != null)
		{
			Rect uvRect = bitmapFont.uvRect;
			object obj20 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 298));
			object obj21 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 282));
			obj20 = obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+460]");
			_ = 0;
			object obj22 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 296));
			int texWidth = bitmapFont.texWidth;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v554 @ S0_v1264+8]");
			num33 = (int)((nint)0 / (nint)texWidth);
			object obj23 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 296));
			int texHeight = bitmapFont.texHeight;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ S0_v1268+C]");
			num34 = (int)((nint)0 / (nint)texHeight);
		}
		int num35 = num32;
		object obj25 = default;
		object obj24 = obj25;
		Color32 color2 = color;
		int num36 = 16;
		float num38 = default;
		float num37 = num38;
		float num40 = default;
		float num39 = num40;
		float num41 = 0f;
		int num42 = 0;
		char prev = '\0';
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L1 (BetterList`1<UnityEngine.Vector3>)+C]");
		int num43 = 0;
		float num45 = default;
		object obj36 = default;
		Color32 color3 = default;
		object obj39 = default;
		float num81 = default;
		float num83 = default;
		float num85 = default;
		object obj44 = default;
		double num98 = default;
		object obj60 = default;
		object obj63 = default;
		object obj66 = default;
		float num118 = default;
		float num119 = default;
		float num120 = default;
		double num142 = default;
		object obj91 = default;
		object obj93 = default;
		object obj96 = default;
		object obj99 = default;
		object obj107 = default;
		object obj109 = default;
		Color32 color7 = default;
		object obj113 = default;
		float num210 = default;
		float num211 = default;
		float num212 = default;
		object obj123 = default;
		object obj125 = default;
		object obj128 = default;
		object obj130 = default;
		float num251 = default;
		float num252 = default;
		float num253 = default;
		object obj172 = default;
		object obj174 = default;
		object obj177 = default;
		object obj180 = default;
		object obj188 = default;
		Color32 color12 = default;
		Color32 color13 = default;
		object obj193 = default;
		float num366 = default;
		float num367 = default;
		float num368 = default;
		float num369 = default;
		while (true)
		{
			if (num42 < text._stringLength)
			{
				char c = text.get_Chars(num42);
				if (c == '\n')
				{
					if (alignment != Alignment.Left)
					{
						float printedWidth = num41 - finalSpacingX;
						Align(verts, num43, printedWidth);
						ref int reference2 = ref reference;
						num36 = 4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L1 (BetterList`1<UnityEngine.Vector3>)+C]");
						num43 = 0;
					}
					float num44 = num45 + finalLineHeight;
					num45 = num44;
					num41 = 0f;
					prev = '\0';
				}
				else
				{
					if (c >= ' ')
					{
						float num80;
						float num82;
						float num84;
						if (~(encoding ? 1u : 0u) == 0)
						{
							bool flag5 = ParseSymbol(text, ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 292), mColors, premultiply, ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 295), ref System.Runtime.CompilerServices.Unsafe.As<int, bool>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 1179)), ref System.Runtime.CompilerServices.Unsafe.As<int, bool>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 1178)), ref System.Runtime.CompilerServices.Unsafe.As<int, bool>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 1177)), ref System.Runtime.CompilerServices.Unsafe.As<int, bool>(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 294)), ref System.Runtime.CompilerServices.Unsafe.As<int, bool>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 1175)));
							bool flag6 = !flag5;
							num36 = (premultiply ? 1 : 0);
							if (!flag6)
							{
								nint num46 = (nint)typeof(NGUIText);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v868 @ S0_v1103 (Il2CppClass<NGUIText>)+5C]");
								nint num47 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+497]");
								float num52;
								float num53;
								float num54;
								if ((nint)0 != 0)
								{
									object obj26 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 280));
									BetterList<Color> betterList = mColors;
									BetterList<Color> betterList2 = mColors;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v885 @ S2_v550 (BetterList`1<UnityEngine.Color>)+C]");
									object obj27 = -1;
									object obj28 = obj27 << 4;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v880 @ S1_v946 (BetterList`1<UnityEngine.Color>)+8]");
									object obj29 = 0 + obj28;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v891 @ S1_v948+18]");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v891 @ S1_v948+10]");
									obj26 = 0;
									nint num48 = (nint)typeof(NGUIText);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v913 @ S2_v555 (Il2CppClass<NGUIText>)+5C]");
									nint num49 = 0;
									float num50 = mAlpha;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v914 @ S2_v556 (Il2CppStaticFields<NGUIText>)+2C]");
									float num51 = num50 * 0f;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+46C]");
									num52 = 0f * num51;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+464]");
									num53 = 0f;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+468]");
									num54 = 0f;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+460]");
									num39 = 0f;
								}
								else
								{
									object obj30 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 280));
									BetterList<Color> betterList3 = mColors;
									BetterList<Color> betterList4 = mColors;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v944 @ S2_v543 (BetterList`1<UnityEngine.Color>)+C]");
									object obj31 = -1;
									object obj32 = obj31 << 4;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v939 @ S1_v926 (BetterList`1<UnityEngine.Color>)+8]");
									object obj33 = 0 + obj32;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v950 @ S1_v928+18]");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v950 @ S1_v928+10]");
									obj30 = 0;
									float num55 = (float)tint;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+460]");
									float num56 = num55 * 0f;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v869 @ S0_v1104 (Il2CppStaticFields<NGUIText>)+24]");
									float num57 = 0f;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+464]");
									float num58 = num57 * 0f;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v869 @ S0_v1104 (Il2CppStaticFields<NGUIText>)+28]");
									float num59 = 0f;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+468]");
									float num60 = num59 * 0f;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v869 @ S0_v1104 (Il2CppStaticFields<NGUIText>)+2C]");
									nint num61 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+46C]");
									object obj34 = num61 * 0;
									num52 = (float)obj34 * mAlpha;
									num53 = num58;
									num54 = num60;
									num39 = num56;
								}
								float num62 = Math.Min(num39, 1f);
								bool flag7 = num39 < 0f;
								float num63 = 0f;
								if (!flag7)
								{
									num63 = num62;
								}
								float num64 = num63 * 255f;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
								float num65 = Math.Min(num53, 1f);
								bool flag8 = num53 < 0f;
								float num66 = 0f;
								if (!flag8)
								{
									num66 = num65;
								}
								float num67 = num66 * 255f;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
								float num68 = Math.Min(num54, 1f);
								bool flag9 = num54 < 0f;
								float num69 = 0f;
								if (!flag9)
								{
									num69 = num68;
								}
								float num70 = num69 * 255f;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
								float num71 = Math.Min(num52, 1f);
								bool flag10 = num52 < 0f;
								float num72 = 0f;
								if (!flag10)
								{
									num72 = num71;
								}
								float num73 = num72 * 255f;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
								object obj35 = obj36 & 0xFF;
								object obj37 = color3 << 8;
								object obj38 = obj37 & 0xFF00;
								int num74 = obj39 << 16;
								int num75 = obj38 | num74;
								int num76 = obj35 | num75;
								BetterList<Color> betterList5 = mColors;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1704 @ S0_v1140 (BetterList`1<UnityEngine.Color>)+C]");
								object obj40 = -2;
								color2 = color3;
								num36 = 16;
								num37 = num52;
								object obj41 = 0;
								while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj40) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj41))
								{
									Color32 color4 = (Color32)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 280));
									BetterList<Color> betterList6 = mColors;
									int num77 = obj41 << 4;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1853 @ S1_v913 (BetterList`1<UnityEngine.Color>)+8]");
									Color32 color5 = (Color32)((nint)0 + (nint)num77);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1856 @ S1_v915 (UnityEngine.Color32)+18]");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1856 @ S1_v915 (UnityEngine.Color32)+10]");
									((Color32*)(nint)color4)->rgba = 0;
									float num78 = num37;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+46C]");
									float num79 = num78 * 0f;
									object obj42 = obj41 + 1;
									color2 = color4;
									num36 = 4;
									num37 = num79;
									obj41 = obj42;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+490]");
								object obj43 = -1;
								num80 = num81;
								num82 = num83;
								num84 = num85;
								num35 = num76;
								obj24 = obj44;
								goto IL_2dd8;
							}
						}
						if (~(useSymbols ? 1u : 0u) == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+490]");
							BMSymbol symbol = GetSymbol(text, 0, text._stringLength);
							bool flag11 = symbol == null;
							num36 = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
							if (!flag11)
							{
								float num86 = (float)symbol.mOffsetX * fontScale;
								float num87 = num41 + num86;
								float num88 = (float)symbol.mWidth * fontScale;
								float num89 = num87 + num88;
								float num90 = (float)symbol.mOffsetY * fontScale;
								float num91 = num45 + num90;
								float num92 = 0f - num91;
								float num93 = (float)symbol.mHeight * fontScale;
								float num94 = num92 - num93;
								float num95 = (float)symbol.mAdvance * fontScale;
								float num96 = num41 + num95;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
								double num97 = Math.Abs(num98);
								double num99 = ((!(num97 < 2147483648.0)) ? (-2147483648.0) : num98);
								bool flag12 = num99 > (double)regionWidth;
								bool flag13 = !flag12;
								float num53 = num92;
								float num54 = num89;
								num37 = num87;
								num39 = num94;
								if (!flag13)
								{
									if (num41 == 0f)
									{
										break;
									}
									if (alignment != Alignment.Left)
									{
										int num100 = num43;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L1 (BetterList`1<UnityEngine.Vector3>)+C]");
										if ((nint)num100 < (nint)0)
										{
											float printedWidth2 = num41 - finalSpacingX;
											Align(verts, num43, printedWidth2);
											ref int reference2 = ref reference;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L1 (BetterList`1<UnityEngine.Vector3>)+C]");
											num43 = 0;
										}
									}
									float num101 = num87 - num41;
									float num102 = num89 - num41;
									float num103 = num94 - finalLineHeight;
									float num104 = num92 - finalLineHeight;
									float num105 = num45 + finalLineHeight;
									num53 = num104;
									num54 = num102;
									num45 = num105;
									num37 = num101;
									num39 = num103;
									num41 = 0f;
								}
								object obj45 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 278));
								obj45 = 0;
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+450]");
								_ = 0;
								Vector3 item2 = (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 126));
								verts.Add(item2);
								object obj46 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 274));
								obj46 = 0;
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+440]");
								_ = 0;
								Vector3 item3 = (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 122));
								verts.Add(item3);
								object obj47 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 270));
								obj47 = 0;
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+430]");
								_ = 0;
								Vector3 item4 = (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 118));
								verts.Add(item4);
								object obj48 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 266));
								obj48 = 0;
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+420]");
								_ = 0;
								Vector3 item5 = (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 114));
								verts.Add(item5);
								float num106 = (float)symbol.mAdvance * fontScale;
								float num107 = finalSpacingX + num106;
								float num108 = num41 + num107;
								bool flag14 = symbol.mLength == 0;
								bool flag15 = !flag14;
								int num109 = symbol.mLength;
								if (!flag15)
								{
									string sequence = symbol.sequence;
									symbol.mLength = sequence._stringLength;
									num109 = sequence._stringLength;
								}
								object obj49 = num109 - 1;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+490]");
								object obj50 = 0 + obj49;
								if (uvs != null)
								{
									object obj51 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 290));
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v864 @ S0_v914 (BMSymbol)+38]");
									obj51 = 0;
									_ = symbol.mUV;
									object obj52 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 288));
									object obj53 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 288));
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1532 @ S0_v1036+8]");
									float num110 = 0f + (float)obj53;
									object obj54 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 288));
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1541 @ S0_v1040+C]");
									float num111 = 0f;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1541 @ S0_v1040+4]");
									float num112 = num111 + 0f;
									object obj55 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 288));
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1551 @ S1_v828+4]");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+418]");
									_ = 0;
									Vector2 item6 = (Vector2)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 112));
									uvs.Add(item6);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+410]");
									_ = 0;
									Vector2 item7 = (Vector2)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 110));
									uvs.Add(item7);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+408]");
									_ = 0;
									Vector2 item8 = (Vector2)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 108));
									uvs.Add(item8);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1551 @ S1_v828+4]");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+400]");
									_ = 0;
									Vector2 item9 = (Vector2)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 106));
									uvs.Add(item9);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1551 @ S1_v828+4]");
									num54 = 0f;
									num37 = num112;
									num39 = num110;
								}
								if (cols == null)
								{
									num36 = 1;
									num41 = num108;
									prev = '\0';
								}
								else if (symbolStyle == SymbolStyle.Colored)
								{
									int num113 = num35 & 0xFFFFFF;
									object obj56 = obj24 << 24;
									int num114 = num113 | obj56;
									object obj57 = 0;
									while (true)
									{
										bool flag16 = (nint)obj57 >= 4;
										num36 = 1;
										num41 = num108;
										prev = '\0';
										if (flag16)
										{
											break;
										}
										Color32 item10 = (Color32)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 104));
										cols.Add(item10);
										object obj58 = obj57 + 1;
										obj57 = obj58;
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
									object obj59 = obj60 << 16;
									object obj61 = obj59 & 0xFF0000;
									object obj62 = obj63 << 8;
									object obj64 = obj62 & 0xFF00;
									object obj65 = obj66 & 0xFF;
									num36 = obj24 << 24;
									int num115 = obj65 | num36;
									int num116 = obj64 | num115;
									int num117 = obj61 | num116;
									object obj67 = 0;
									while (true)
									{
										bool flag17 = (nint)obj67 >= 4;
										num54 = num118;
										ref int reference2 = ref *(int*)24;
										num37 = num119;
										num39 = num120;
										num41 = num108;
										prev = '\0';
										if (flag17)
										{
											break;
										}
										Color32 item11 = (Color32)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 105));
										cols.Add(item11);
										object obj68 = obj67 + 1;
										obj67 = obj68;
									}
								}
								goto IL_2dd8;
							}
						}
						GlyphInfo glyphInfo = GetGlyph(c, prev);
						if (glyphInfo == null)
						{
							goto IL_2dd8;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+49C]");
						if ((nint)0 != 0)
						{
							float num121 = (float)glyphInfo.v0 * 0.75f;
							glyphInfo.v0 = (Vector2)num121;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v866 @ S0_v193 (NGUIText+GlyphInfo)+C]");
							float num122 = 0f * 0.75f;
							float num123 = (float)glyphInfo.v1 * 0.75f;
							glyphInfo.v1 = (Vector2)num123;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v866 @ S0_v193 (NGUIText+GlyphInfo)+14]");
							float num124 = 0f * 0.75f;
							float num125 = fontScale * (float)fontSize;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+49C]");
							if ((nint)0 == 1)
							{
								float num126 = num125 * 0.4f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v866 @ S0_v193 (NGUIText+GlyphInfo)+C]");
								float num127 = 0f - num126;
								float num128 = fontScale * (float)fontSize;
								float num129 = num128 * 0.4f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v866 @ S0_v193 (NGUIText+GlyphInfo)+14]");
								float num130 = 0f - num129;
								ref int reference2 = ref *(int*)0.4f;
							}
							else
							{
								float num131 = num125 * 0.05f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v866 @ S0_v193 (NGUIText+GlyphInfo)+C]");
								float num132 = 0f + num131;
								float num133 = fontScale * (float)fontSize;
								float num134 = num133 * 0.05f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v866 @ S0_v193 (NGUIText+GlyphInfo)+14]");
								float num130 = 0f + num134;
								ref int reference2 = ref *(int*)0.05f;
							}
						}
						float num135 = (float)glyphInfo.v0 + num41;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v866 @ S0_v193 (NGUIText+GlyphInfo)+C]");
						float num136 = 0f - num45;
						float num137 = (float)glyphInfo.v1 + num41;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v866 @ S0_v193 (NGUIText+GlyphInfo)+14]");
						float num138 = 0f - num45;
						float num139 = ((!(finalSpacingX < 0f)) ? glyphInfo.advance : (glyphInfo.advance + finalSpacingX));
						float num140 = num41 + num139;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
						double num141 = Math.Abs(num142);
						double num143 = ((!(num141 < 2147483648.0)) ? (-2147483648.0) : num142);
						bool flag18 = (double)regionWidth < num143;
						bool flag19 = !flag18;
						num80 = num137;
						num82 = num135;
						num84 = num138;
						num39 = num136;
						if (!flag19)
						{
							if (num41 == 0f)
							{
								break;
							}
							if (alignment != Alignment.Left)
							{
								int num144 = num43;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L1 (BetterList`1<UnityEngine.Vector3>)+C]");
								if ((nint)num144 < (nint)0)
								{
									float printedWidth3 = num41 - finalSpacingX;
									Align(verts, num43, printedWidth3);
									ref int reference2 = ref reference;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L1 (BetterList`1<UnityEngine.Vector3>)+C]");
									num43 = 0;
								}
							}
							float num145 = num135 - num41;
							float num146 = num137 - num41;
							float num147 = num136 - finalLineHeight;
							float num148 = num138 - finalLineHeight;
							float num149 = num45 + finalLineHeight;
							num80 = num146;
							num82 = num145;
							num84 = num148;
							num45 = num149;
							num39 = num147;
							num41 = 0f;
						}
						object obj69 = c - 8201;
						bool flag20 = (nint)obj69 < 3;
						object obj70 = 1;
						if (!flag20)
						{
							bool flag21 = c == ' ';
							obj70 = 1;
							if (!flag21)
							{
								obj70 = 0;
							}
						}
						bool flag22 = obj70 == null;
						char c2 = c;
						if (!flag22)
						{
							c2 = '_';
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+499]");
							if ((nint)0 == 0)
							{
								c2 = '-';
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+498]");
								if ((nint)0 == 0)
								{
									c2 = c;
								}
							}
						}
						float num150 = finalSpacingX + glyphInfo.advance;
						float num151 = num150 * 0.75f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+49C]");
						if ((nint)0 == 0)
						{
							num151 = num150;
						}
						float num152 = num41 + num151;
						object obj71 = c2 - 8201;
						bool flag23 = (nint)obj71 < 3;
						color2 = (Color32)1;
						if (!flag23)
						{
							bool flag24 = c2 == ' ';
							color2 = (Color32)1;
							if (!flag24)
							{
								color2 = (Color32)0;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+49C]");
						num36 = 0;
						if ((int)color2 == 0)
						{
							bool flag25 = uvs == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+49C]");
							num36 = 0;
							if (!flag25)
							{
								bool flag26 = bitmapFont != null;
								bool flag27 = !flag26;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+49C]");
								num36 = 0;
								if (!flag27)
								{
									object obj72 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 296));
									object obj73 = num33 * glyphInfo.u0;
									Vector2 u = (Vector2)(obj72 + obj73);
									glyphInfo.u0 = u;
									object obj74 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 296));
									object obj75 = num33 * glyphInfo.u2;
									Vector2 u2 = (Vector2)(obj74 + obj75);
									glyphInfo.u2 = u2;
									object obj76 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 296));
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2132 @ S1_v650+C]");
									nint num153 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2132 @ S1_v650+4]");
									object obj77 = num153 + 0;
									int num154 = num34;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v866 @ S0_v193 (NGUIText+GlyphInfo)+1C]");
									object obj78 = (nint)num154 * (nint)0;
									object obj79 = obj77 - obj78;
									object obj80 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 296));
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2146 @ S1_v655+C]");
									nint num155 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2146 @ S1_v655+4]");
									object obj81 = num155 + 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v866 @ S0_v193 (NGUIText+GlyphInfo)+2C]");
									num36 = 0;
									int num156 = num34;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v866 @ S0_v193 (NGUIText+GlyphInfo)+2C]");
									object obj82 = (nint)num156 * (nint)0;
									float num157 = (float)obj81 - (float)obj82;
									glyphInfo.u1 = glyphInfo.u0;
									glyphInfo.u3 = glyphInfo.u2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v866 @ S0_v193 (NGUIText+GlyphInfo)+1C]");
									_ = 0;
									num37 = num157;
								}
								object obj83 = 4;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+49B]");
								if ((nint)0 == 0)
								{
									obj83 = 1;
								}
								object obj84 = 0;
								while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj84) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj83))
								{
									_ = glyphInfo.u0;
									_ = glyphInfo.u0;
									Vector2 item12 = (Vector2)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 102));
									uvs.Add(item12);
									_ = glyphInfo.u1;
									_ = glyphInfo.u1;
									Vector2 item13 = (Vector2)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 100));
									uvs.Add(item13);
									_ = glyphInfo.u2;
									_ = glyphInfo.u2;
									Vector2 item14 = (Vector2)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 98));
									uvs.Add(item14);
									_ = glyphInfo.u3;
									_ = glyphInfo.u3;
									Vector2 item15 = (Vector2)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 96));
									uvs.Add(item15);
									object obj85 = obj84 + 1;
									obj84 = obj85;
								}
							}
							if (cols == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+49B]");
								color2 = (Color32)0;
							}
							else
							{
								bool flag28 = glyphInfo.channel != 15;
								if (glyphInfo.channel == 0)
								{
									flag28 = false;
								}
								if (!flag28)
								{
									if (~(gradient ? 1u : 0u) == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v866 @ S0_v193 (NGUIText+GlyphInfo)+14]");
										float num158 = 0f / fontScale;
										float num159 = num29 + num158;
										object obj86 = obj10 - obj6;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v866 @ S0_v193 (NGUIText+GlyphInfo)+C]");
										float num160 = 0f / fontScale;
										float num161 = num29 + num160;
										float num162 = num161 / num29;
										float num163 = Math.Min(num162, 1f);
										bool flag29 = num162 < 0f;
										float num164 = 0f;
										if (!flag29)
										{
											num164 = num163;
										}
										float num165 = (float)obj86 * num164;
										float num166 = (float)obj6 + num165;
										float num167 = Math.Min(num166, 1f);
										bool flag30 = num166 < 0f;
										float num168 = 0f;
										if (!flag30)
										{
											num168 = num167;
										}
										float num169 = num168 * 255f;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
										object obj87 = obj11 - obj7;
										float num170 = (float)obj87 * num164;
										float num171 = (float)obj7 + num170;
										float num172 = Math.Min(num171, 1f);
										bool flag31 = num171 < 0f;
										float num173 = 0f;
										if (!flag31)
										{
											num173 = num172;
										}
										float num174 = num173 * 255f;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
										object obj88 = obj12 - obj8;
										float num175 = (float)obj88 * num164;
										float num176 = (float)obj8 + num175;
										float num177 = Math.Min(num176, 1f);
										bool flag32 = num176 < 0f;
										float num178 = 0f;
										if (!flag32)
										{
											num178 = num177;
										}
										float num179 = num178 * 255f;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
										object obj89 = obj13 - obj9;
										float num180 = (float)obj89 * num164;
										float num181 = (float)obj9 + num180;
										float num182 = Math.Min(num181, 1f);
										bool flag33 = num181 < 0f;
										float num183 = 0f;
										if (!flag33)
										{
											num183 = num182;
										}
										float num184 = num183 * 255f;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
										object obj90 = obj91 & 0xFF;
										object obj92 = obj93 << 8;
										object obj94 = obj92 & 0xFF00;
										object obj95 = obj96 << 16;
										object obj97 = obj95 & 0xFF0000;
										object obj98 = obj99 << 24;
										object obj100 = obj97 | obj98;
										object obj101 = obj94 | obj100;
										Color32 color6 = (Color32)(obj90 | obj101);
										s_c0 = color6;
										object obj102 = obj10 - obj6;
										float num185 = num159 / num29;
										float num186 = Math.Min(num185, 1f);
										bool flag34 = num185 < 0f;
										float num187 = 0f;
										if (!flag34)
										{
											num187 = num186;
										}
										float num188 = (float)obj102 * num187;
										float num189 = (float)obj6 + num188;
										float num190 = Math.Min(num189, 1f);
										bool flag35 = num189 < 0f;
										float num191 = 0f;
										if (!flag35)
										{
											num191 = num190;
										}
										float num192 = num191 * 255f;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
										object obj103 = obj11 - obj7;
										float num193 = (float)obj103 * num187;
										float num194 = (float)obj7 + num193;
										float num195 = Math.Min(num194, 1f);
										bool flag36 = num194 < 0f;
										float num196 = 0f;
										if (!flag36)
										{
											num196 = num195;
										}
										float num197 = num196 * 255f;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
										object obj104 = obj12 - obj8;
										float num198 = (float)obj104 * num187;
										float num199 = (float)obj8 + num198;
										float num200 = Math.Min(num199, 1f);
										bool flag37 = num199 < 0f;
										float num201 = 0f;
										if (!flag37)
										{
											num201 = num200;
										}
										float num202 = num201 * 255f;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
										object obj105 = obj13 - obj9;
										float num203 = (float)obj105 * num187;
										float num204 = (float)obj9 + num203;
										float num205 = Math.Min(num204, 1f);
										bool flag38 = num204 < 0f;
										float num206 = 0f;
										if (!flag38)
										{
											num206 = num205;
										}
										float num207 = num206 * 255f;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
										object obj106 = obj107 & 0xFF;
										object obj108 = obj109 << 8;
										object obj110 = obj108 & 0xFF00;
										object obj111 = color7 << 16;
										object obj112 = obj111 & 0xFF0000;
										num36 = obj112 | System.Runtime.CompilerServices.Unsafe.AsPointer(ref *(byte*)(obj113 << 24));
										int num208 = obj110 | num36;
										int num209 = obj106 | num208;
										s_c1 = (Color32)num209;
										object obj114 = 4;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+49B]");
										if ((nint)0 == 0)
										{
											obj114 = 1;
										}
										object obj115 = 0;
										while (true)
										{
											bool flag39 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj115) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj114);
											float num53 = num210;
											float num54 = num211;
											ref bool reference3 = ref *(bool*)0f;
											ref bool reference4 = ref *(bool*)24;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+49B]");
											color2 = (Color32)0;
											num37 = num212;
											if (flag39)
											{
												break;
											}
											_ = s_c0;
											_ = s_c0;
											Color32 item16 = (Color32)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 95));
											cols.Add(item16);
											_ = s_c1;
											_ = s_c1;
											Color32 item17 = (Color32)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 94));
											cols.Add(item17);
											_ = s_c1;
											_ = s_c1;
											Color32 item18 = (Color32)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 93));
											cols.Add(item18);
											_ = s_c0;
											_ = s_c0;
											Color32 item19 = (Color32)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 92));
											cols.Add(item19);
											object obj116 = obj115 + 1;
											obj115 = obj116;
										}
									}
									else
									{
										Color32 color8 = (Color32)16;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+49B]");
										if ((nint)0 == 0)
										{
											color8 = (Color32)4;
										}
										int num213 = num35 & 0xFFFFFF;
										object obj117 = obj24 << 24;
										int num214 = num213 | obj117;
										object obj118 = 0;
										while (true)
										{
											bool flag40 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj118) >= System.Runtime.CompilerServices.Unsafe.As<Color32, UIntPtr>(ref color8);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+49B]");
											color2 = (Color32)0;
											if (flag40)
											{
												break;
											}
											Color32 item20 = (Color32)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 91));
											cols.Add(item20);
											object obj119 = obj118 + 1;
											obj118 = obj119;
										}
									}
								}
								else
								{
									int num215 = num35 & 0xFF;
									float num216 = (float)num215 / 255f;
									float num217 = num216 * 0.49f;
									int num218 = num35 & 0xFFFFFF;
									int num219 = num218 >> 8;
									int num220 = num219 & 0xFF;
									float num221 = (float)num220 / 255f;
									float num222 = num221 * 0.49f;
									int num223 = num218 >> 16;
									float num224 = (float)num223 / 255f;
									float num225 = num224 * 0.49f;
									object obj120 = obj24 & 0xFF;
									float num226 = (float)obj120 / 255f;
									float num227 = num226 * 0.49f;
									object obj121 = glyphInfo.channel - 1;
									float num228;
									float num229;
									float num230;
									float num231;
									if (glyphInfo.channel != 1)
									{
										if ((nint)obj121 != 1)
										{
											bool flag41 = (nint)obj121 == 2;
											num228 = num227;
											num229 = num225;
											num230 = num222;
											num231 = num217;
											if (!flag41)
											{
												if ((nint)obj121 != 3)
												{
													bool flag42 = glyphInfo.channel != 8;
													num228 = num227;
													num229 = num225;
													num230 = num222;
													num231 = num217;
													if (!flag42)
													{
														float num232 = num227 + 0.51f;
														num228 = num232;
														num229 = num225;
														num230 = num222;
														num231 = num217;
													}
												}
												else
												{
													float num233 = num217 + 0.51f;
													num228 = num227;
													num229 = num225;
													num230 = num222;
													num231 = num233;
												}
											}
										}
										else
										{
											float num234 = num222 + 0.51f;
											num228 = num227;
											num229 = num225;
											num230 = num234;
											num231 = num217;
										}
									}
									else
									{
										float num235 = num225 + 0.51f;
										num228 = num227;
										num229 = num235;
										num230 = num222;
										num231 = num217;
									}
									float num236 = Math.Min(num231, 1f);
									bool flag43 = num231 < 0f;
									float num237 = 0f;
									if (!flag43)
									{
										num237 = num236;
									}
									float num238 = num237 * 255f;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
									float num239 = Math.Min(num230, 1f);
									bool flag44 = num230 < 0f;
									float num240 = 0f;
									if (!flag44)
									{
										num240 = num239;
									}
									float num241 = num240 * 255f;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
									float num242 = Math.Min(num229, 1f);
									bool flag45 = num229 < 0f;
									float num243 = 0f;
									if (!flag45)
									{
										num243 = num242;
									}
									float num244 = num243 * 255f;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
									float num245 = Math.Min(num228, 1f);
									bool flag46 = num228 < 0f;
									float num246 = 0f;
									if (!flag46)
									{
										num246 = num245;
									}
									float num247 = num246 * 255f;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
									object obj122 = obj123 & 0xFF;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
									object obj124 = obj125 << 8;
									object obj126 = obj124 & 0xFF00;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
									object obj127 = obj128 << 16;
									object obj129 = obj127 & 0xFF0000;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
									num36 = obj130 << 24;
									int num248 = obj129 | num36;
									int num249 = obj126 | num248;
									int num250 = obj122 | num249;
									Color32 color9 = (Color32)16;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+49B]");
									if ((nint)0 == 0)
									{
										color9 = (Color32)4;
									}
									object obj131 = 0;
									while (true)
									{
										bool flag47 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj131) >= System.Runtime.CompilerServices.Unsafe.As<Color32, UIntPtr>(ref color9);
										float num53 = num251;
										float num54 = num252;
										ref int reference2 = ref *(int*)24;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+49B]");
										color2 = (Color32)0;
										num37 = num253;
										if (flag47)
										{
											break;
										}
										Color32 item21 = (Color32)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 90));
										cols.Add(item21);
										object obj132 = obj131 + 1;
										obj131 = obj132;
									}
								}
							}
							bool flag48 = color2 == (Color32)(object)0;
							bool flag49 = !flag48;
							object obj133 = 0;
							if (!flag49)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+49A]");
								if ((nint)0 == 0)
								{
									_ = 0;
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+390]");
									_ = 0;
									Vector3 item22 = (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 58));
									verts.Add(item22);
									_ = 0;
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+380]");
									_ = 0;
									Vector3 item23 = (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 54));
									verts.Add(item23);
									_ = 0;
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+370]");
									_ = 0;
									Vector3 item24 = (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 50));
									verts.Add(item24);
									object obj134 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 216));
								}
								else
								{
									float num254 = (float)fontSize * 0.1f;
									float num255 = num84 - num39;
									num36 = fontSize;
									float num256 = num255 / (float)fontSize;
									float num257 = num254 * num256;
									float num258 = num82 - num257;
									_ = 0;
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+350]");
									_ = 0;
									Vector3 item25 = (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 70));
									verts.Add(item25);
									_ = 0;
									_ = 0;
									float num259 = num82 + num257;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+340]");
									_ = 0;
									Vector3 item26 = (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 66));
									verts.Add(item26);
									_ = 0;
									_ = 0;
									float num260 = num80 + num257;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+330]");
									_ = 0;
									Vector3 item27 = (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 62));
									verts.Add(item27);
									float num261 = num80 - num257;
									object obj134 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 200));
									float num54 = num258;
									num37 = num257;
								}
								_ = 0;
								_ = 0;
								Vector3 item28 = (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 46));
								verts.Add(item28);
							}
							else
							{
								while ((nint)obj133 < 4)
								{
									object obj135 = obj133 << 3;
									object obj136 = (object)mBoldOffset + obj135;
									object obj137 = obj133 << 1;
									object obj138 = obj137 + 1;
									object obj139 = obj138 << 2;
									object obj140 = (object)mBoldOffset + obj139;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+49A]");
									float num265;
									if ((nint)0 != 0)
									{
										float num262 = (float)fontSize * 0.1f;
										float num263 = num84 - num39;
										float num264 = num263 / (float)fontSize;
										num265 = num262 * num264;
									}
									else
									{
										num265 = 0f;
									}
									_ = 0;
									_ = 0;
									float num266 = num39;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2318 @ S0_v284+10]");
									float num267 = num266 + 0f;
									float num268 = num82;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2305 @ S0_v278+10]");
									float num269 = num268 + 0f;
									float num270 = num269 - num265;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+310]");
									_ = 0;
									Vector3 item29 = (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 86));
									verts.Add(item29);
									_ = 0;
									_ = 0;
									float num271 = num84;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2318 @ S0_v284+10]");
									float num272 = num271 + 0f;
									float num273 = num82;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2305 @ S0_v278+10]");
									float num274 = num273 + 0f;
									float num275 = num274 + num265;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+300]");
									_ = 0;
									Vector3 item30 = (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 82));
									verts.Add(item30);
									_ = 0;
									_ = 0;
									float num276 = num84;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2318 @ S0_v284+10]");
									float num277 = num276 + 0f;
									float num278 = num80;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2305 @ S0_v278+10]");
									float num279 = num278 + 0f;
									float num280 = num279 + num265;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+2F0]");
									_ = 0;
									Vector3 item31 = (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 78));
									verts.Add(item31);
									_ = 0;
									_ = 0;
									float num281 = num39;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2318 @ S0_v284+10]");
									float num282 = num281 + 0f;
									float num283 = num80;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2305 @ S0_v278+10]");
									float num284 = num283 + 0f;
									float num285 = num284 - num265;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+2E0]");
									_ = 0;
									Vector3 item32 = (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 74));
									verts.Add(item32);
									object obj141 = obj133 + 1;
									float num53 = num265;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2318 @ S0_v284+10]");
									float num54 = 0f;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2305 @ S0_v278+10]");
									num37 = 0f;
									obj133 = obj141;
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+498]");
							nint num286 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+499]");
							object obj142 = num286 | 0;
							if (obj142 != null)
							{
								int ch = 45;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+498]");
								if ((nint)0 == 0)
								{
									ch = 95;
								}
								GlyphInfo glyphInfo2 = GetGlyph(ch, c);
								if (glyphInfo2 != null)
								{
									if (uvs != null)
									{
										if (bitmapFont != null)
										{
											object obj143 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 296));
											object obj144 = num33 * glyphInfo2.u0;
											Vector2 u3 = (Vector2)(obj143 + obj144);
											glyphInfo2.u0 = u3;
											object obj145 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 296));
											object obj146 = num33 * glyphInfo2.u2;
											Vector2 u4 = (Vector2)(obj145 + obj146);
											glyphInfo2.u2 = u4;
											object obj147 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 296));
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2956 @ S1_v404+C]");
											nint num287 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2956 @ S1_v404+4]");
											object obj148 = num287 + 0;
											int num288 = num34;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2546 @ S0_v332 (NGUIText+GlyphInfo)+1C]");
											object obj149 = (nint)num288 * (nint)0;
											object obj150 = obj148 - obj149;
											object obj151 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 296));
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2970 @ S1_v409+C]");
											nint num289 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2970 @ S1_v409+4]");
											object obj152 = num289 + 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2546 @ S0_v332 (NGUIText+GlyphInfo)+2C]");
											num36 = 0;
											int num290 = num34;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2546 @ S0_v332 (NGUIText+GlyphInfo)+2C]");
											object obj153 = (nint)num290 * (nint)0;
											object obj154 = obj152 - obj153;
										}
										Color32 color10 = (Color32)4;
										if ((int)color2 == 0)
										{
											color10 = (Color32)1;
										}
										object obj155 = glyphInfo2.u0 + glyphInfo2.u2;
										float num291 = (float)obj155 * 0.5f;
										object obj156 = 0;
										while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj156) < System.Runtime.CompilerServices.Unsafe.As<Color32, UIntPtr>(ref color10))
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2546 @ S0_v332 (NGUIText+GlyphInfo)+1C]");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+2D8]");
											_ = 0;
											Vector2 item33 = (Vector2)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 44));
											uvs.Add(item33);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2546 @ S0_v332 (NGUIText+GlyphInfo)+2C]");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+2D0]");
											_ = 0;
											Vector2 item34 = (Vector2)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 42));
											uvs.Add(item34);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2546 @ S0_v332 (NGUIText+GlyphInfo)+2C]");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+2C8]");
											_ = 0;
											Vector2 item35 = (Vector2)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 40));
											uvs.Add(item35);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2546 @ S0_v332 (NGUIText+GlyphInfo)+1C]");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+2C0]");
											_ = 0;
											Vector2 item36 = (Vector2)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 38));
											uvs.Add(item36);
											object obj157 = obj156 + 1;
											obj156 = obj157;
										}
									}
									float num292 = 0f - num45;
									float num293 = num292;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2546 @ S0_v332 (NGUIText+GlyphInfo)+C]");
									float num294 = num293 + 0f;
									float num295 = 0f - num45;
									float num296 = num295;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2546 @ S0_v332 (NGUIText+GlyphInfo)+14]");
									float num297 = num296 + 0f;
									bool flag50 = color2 == (Color32)(object)0;
									bool flag51 = !flag50;
									object obj158 = 0;
									if (!flag51)
									{
										_ = 0;
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+270]");
										_ = 0;
										Vector3 item37 = (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 18));
										verts.Add(item37);
										_ = 0;
										object obj159 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref reference, -64));
										obj159 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+260]");
										_ = 0;
										Vector3 item38 = (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 14));
										verts.Add(item38);
										_ = 0;
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+250]");
										_ = 0;
										Vector3 item39 = (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 10));
										verts.Add(item39);
										_ = 0;
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+240]");
										_ = 0;
										Vector3 item40 = (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 6));
										verts.Add(item40);
									}
									else
									{
										while ((nint)obj158 < 4)
										{
											object obj160 = obj158 << 3;
											object obj161 = (object)mBoldOffset + obj160;
											object obj162 = obj158 << 1;
											object obj163 = obj162 + 1;
											object obj164 = obj163 << 2;
											object obj165 = (object)mBoldOffset + obj164;
											_ = 0;
											_ = 0;
											float num298 = num294;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2896 @ S0_v361+10]");
											float num299 = num298 + 0f;
											float num300 = num41;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2883 @ S0_v355+10]");
											float num301 = num300 + 0f;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+2B0]");
											_ = 0;
											Vector3 item41 = (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 34));
											verts.Add(item41);
											_ = 0;
											_ = 0;
											float num302 = num297;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2896 @ S0_v361+10]");
											float num303 = num302 + 0f;
											float num304 = num41;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2883 @ S0_v355+10]");
											float num305 = num304 + 0f;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+2A0]");
											_ = 0;
											Vector3 item42 = (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 30));
											verts.Add(item42);
											_ = 0;
											_ = 0;
											float num306 = num297;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2896 @ S0_v361+10]");
											float num307 = num306 + 0f;
											float num308 = num152;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2883 @ S0_v355+10]");
											float num309 = num308 + 0f;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+290]");
											_ = 0;
											Vector3 item43 = (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 26));
											verts.Add(item43);
											_ = 0;
											_ = 0;
											float num310 = num294;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2896 @ S0_v361+10]");
											float num311 = num310 + 0f;
											float num312 = num152;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2883 @ S0_v355+10]");
											float num313 = num312 + 0f;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+280]");
											_ = 0;
											Vector3 item44 = (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 22));
											verts.Add(item44);
											object obj166 = obj158 + 1;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2896 @ S0_v361+10]");
											float num53 = 0f;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2883 @ S0_v355+10]");
											float num54 = 0f;
											obj158 = obj166;
										}
									}
									if (~(gradient ? 1u : 0u) == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2546 @ S0_v332 (NGUIText+GlyphInfo)+14]");
										float num314 = 0f / fontScale;
										float num315 = num29 + num314;
										object obj167 = obj10 - obj6;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2546 @ S0_v332 (NGUIText+GlyphInfo)+C]");
										float num316 = 0f / fontScale;
										float num317 = num29 + num316;
										float num318 = num317 / num29;
										float num319 = Math.Min(num318, 1f);
										bool flag52 = num318 < 0f;
										float num320 = 0f;
										if (!flag52)
										{
											num320 = num319;
										}
										float num321 = (float)obj167 * num320;
										float num322 = (float)obj6 + num321;
										float num323 = Math.Min(num322, 1f);
										bool flag53 = num322 < 0f;
										float num324 = 0f;
										if (!flag53)
										{
											num324 = num323;
										}
										float num325 = num324 * 255f;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
										object obj168 = obj11 - obj7;
										float num326 = (float)obj168 * num320;
										float num327 = (float)obj7 + num326;
										float num328 = Math.Min(num327, 1f);
										bool flag54 = num327 < 0f;
										float num329 = 0f;
										if (!flag54)
										{
											num329 = num328;
										}
										float num330 = num329 * 255f;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
										object obj169 = obj12 - obj8;
										float num331 = (float)obj169 * num320;
										float num332 = (float)obj8 + num331;
										float num333 = Math.Min(num332, 1f);
										bool flag55 = num332 < 0f;
										float num334 = 0f;
										if (!flag55)
										{
											num334 = num333;
										}
										float num335 = num334 * 255f;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
										object obj170 = obj13 - obj9;
										float num336 = (float)obj170 * num320;
										float num337 = (float)obj9 + num336;
										float num338 = Math.Min(num337, 1f);
										bool flag56 = num337 < 0f;
										float num339 = 0f;
										if (!flag56)
										{
											num339 = num338;
										}
										float num340 = num339 * 255f;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
										object obj171 = obj172 & 0xFF;
										object obj173 = obj174 << 8;
										object obj175 = obj173 & 0xFF00;
										object obj176 = obj177 << 16;
										object obj178 = obj176 & 0xFF0000;
										object obj179 = obj180 << 24;
										object obj181 = obj178 | obj179;
										object obj182 = obj175 | obj181;
										Color32 color11 = (Color32)(obj171 | obj182);
										s_c0 = color11;
										object obj183 = obj10 - obj6;
										float num341 = num315 / num29;
										float num342 = Math.Min(num341, 1f);
										bool flag57 = num341 < 0f;
										float num343 = 0f;
										if (!flag57)
										{
											num343 = num342;
										}
										float num344 = (float)obj183 * num343;
										float num345 = (float)obj6 + num344;
										float num346 = Math.Min(num345, 1f);
										bool flag58 = num345 < 0f;
										float num347 = 0f;
										if (!flag58)
										{
											num347 = num346;
										}
										float num348 = num347 * 255f;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
										object obj184 = obj11 - obj7;
										float num349 = (float)obj184 * num343;
										float num350 = (float)obj7 + num349;
										float num351 = Math.Min(num350, 1f);
										bool flag59 = num350 < 0f;
										float num352 = 0f;
										if (!flag59)
										{
											num352 = num351;
										}
										float num353 = num352 * 255f;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
										object obj185 = obj12 - obj8;
										float num354 = (float)obj185 * num343;
										float num355 = (float)obj8 + num354;
										float num356 = Math.Min(num355, 1f);
										bool flag60 = num355 < 0f;
										float num357 = 0f;
										if (!flag60)
										{
											num357 = num356;
										}
										float num358 = num357 * 255f;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
										object obj186 = obj13 - obj9;
										float num359 = (float)obj186 * num343;
										float num360 = (float)obj9 + num359;
										float num361 = Math.Min(num360, 1f);
										bool flag61 = num360 < 0f;
										float num362 = 0f;
										if (!flag61)
										{
											num362 = num361;
										}
										float num363 = num362 * 255f;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
										object obj187 = obj188 & 0xFF;
										object obj189 = color12 << 8;
										object obj190 = obj189 & 0xFF00;
										object obj191 = color13 << 16;
										object obj192 = obj191 & 0xFF0000;
										num36 = obj192 | System.Runtime.CompilerServices.Unsafe.AsPointer(ref *(byte*)(obj193 << 24));
										int num364 = obj190 | num36;
										int num365 = obj187 | num364;
										s_c1 = (Color32)num365;
										object obj194 = 4;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+49B]");
										if ((nint)0 == 0)
										{
											obj194 = 1;
										}
										color2 = color12;
										object obj195 = 0;
										while (true)
										{
											bool flag62 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj194) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj195);
											float num53 = num366;
											float num54 = num367;
											ref bool reference3 = ref *(bool*)0f;
											ref bool reference4 = ref *(bool*)24;
											num37 = num368;
											num39 = num369;
											if (flag62)
											{
												break;
											}
											_ = s_c0;
											_ = s_c0;
											Color32 item45 = (Color32)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 5));
											cols.Add(item45);
											_ = s_c1;
											_ = s_c1;
											Color32 item46 = (Color32)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 4));
											cols.Add(item46);
											_ = s_c1;
											_ = s_c1;
											Color32 item47 = (Color32)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 3));
											cols.Add(item47);
											_ = s_c0;
											_ = s_c0;
											Color32 item48 = (Color32)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 2));
											cols.Add(item48);
											object obj196 = obj195 + 1;
											color2 = s_c0;
											obj195 = obj196;
										}
									}
									else
									{
										int num370 = num35 & 0xFFFFFF;
										object obj197 = obj24 << 24;
										int num371 = num370 | obj197;
										Color32 color14 = (Color32)16;
										if ((int)color2 == 0)
										{
											color14 = (Color32)4;
										}
										object obj198 = 0;
										while (true)
										{
											bool flag63 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj198) >= System.Runtime.CompilerServices.Unsafe.As<Color32, UIntPtr>(ref color14);
											color2 = color14;
											num37 = num297;
											num39 = num294;
											if (flag63)
											{
												break;
											}
											Color32 item49 = (Color32)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 1));
											cols.Add(item49);
											object obj199 = obj198 + 1;
											obj198 = obj199;
										}
									}
								}
							}
						}
						num41 = num152;
					}
					prev = c;
				}
				goto IL_2dd8;
			}
			if (alignment != Alignment.Left)
			{
				int num372 = num43;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L1 (BetterList`1<UnityEngine.Vector3>)+C]");
				if ((nint)num372 < (nint)0)
				{
					float printedWidth4 = num41 - finalSpacingX;
					Align(verts, num43, printedWidth4);
				}
			}
			BetterList<Color> betterList7 = mColors;
			_ = 0;
			break;
			IL_2dd8:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+490]");
			int num373 = (int)((nint)0 + (nint)1);
			num42 = num373;
		}
	}

	public unsafe static void PrintApproximateCharacterPositions(string text, BetterList<Vector3> verts, BetterList<int> indices)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0038: Expected Obj, but got I4
		//IL_001c: Expected Obj, but got I4
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected VT, but got Unknown
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected Ref, but got Unknown
		//IL_0208: Expected Obj, but got I
		//IL_0300: Expected F8, but got I4
		//IL_043f: Expected F8, but got I4
		//IL_066f: Invalid comparison between F8 and I4
		//IL_076f: Invalid comparison between F8 and I4
		//IL_06c2: Expected native int or pointer, but got VT
		//IL_0705: Expected F4, but got I
		//IL_0700: Expected native int or pointer, but got VT
		//IL_07fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0803: Expected VT, but got Unknown
		//IL_0853: Expected Obj, but got I4
		//IL_0863: Unknown result type (might be due to invalid IL or missing references)
		//IL_0868: Expected Obj, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj - 96);
		object obj2;
		if (text != null)
		{
			obj2 = 0;
			if (text._stringLength != 0)
			{
				goto IL_0590;
			}
		}
		obj2 = 1;
		goto IL_0590;
		IL_0590:
		string text2 = " ";
		if (obj2 == null)
		{
			text2 = text;
		}
		Prepare(text2);
		float num = (float)fontSize * fontScale;
		float num2 = num * 0.5f;
		int prev = 0;
		int num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L1 (BetterList`1<UnityEngine.Vector3>)+C]");
		int num4 = 0;
		float num6 = default;
		float num8 = default;
		double num14 = default;
		double num25 = default;
		while (true)
		{
			if (num3 < text2._stringLength)
			{
				char c = text2.get_Chars(num3);
				_ = 0;
				_ = 0;
				float num5 = 0f - num6;
				float num7 = num5 - num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
				_ = 0;
				Vector3 item = vector + 32;
				verts.Add(item);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+5C]");
				indices.Add(0);
				if (c == '\n')
				{
					if (alignment != Alignment.Left)
					{
						float printedWidth = num8 - finalSpacingX;
						Align(verts, num4, printedWidth, 1);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L1 (BetterList`1<UnityEngine.Vector3>)+C]");
						num4 = 0;
					}
					float num9 = num6 + finalLineHeight;
					num6 = num9;
					num8 = 0f;
					prev = 0;
				}
				else if (c < ' ')
				{
					prev = 0;
				}
				else if (~(encoding ? 1u : 0u) == 0 && ParseSymbol(text2, ref *(int*)(vector + 92)))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+5C]");
					object obj3 = -1;
				}
				else
				{
					float num18;
					if (~(useSymbols ? 1u : 0u) == 0)
					{
						string text3 = text2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+5C]");
						BMSymbol symbol = GetSymbol(text3, 0, text2._stringLength);
						if (symbol != null)
						{
							float num10 = (float)symbol.mAdvance * fontScale;
							float num11 = num10 + finalSpacingX;
							float num12 = num8 + num11;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
							double num13 = Math.Abs(num14);
							double num15 = ((!(num13 < 2147483648.0)) ? (-2147483648.0) : num14);
							if (num15 > (double)regionWidth)
							{
								if (num8 == 0f)
								{
									break;
								}
								if (alignment != Alignment.Left)
								{
									int num16 = num4;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L1 (BetterList`1<UnityEngine.Vector3>)+C]");
									if ((nint)num16 < (nint)0)
									{
										float printedWidth2 = num8 - finalSpacingX;
										Align(verts, num4, printedWidth2, 1);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L1 (BetterList`1<UnityEngine.Vector3>)+C]");
										num4 = 0;
									}
								}
								float num17 = num6 + finalLineHeight;
								num18 = num11;
								num6 = num17;
							}
							else
							{
								float num19 = num8 + num11;
								num18 = num19;
							}
							_ = 0;
							_ = 0;
							float num20 = 0f - num6;
							float num21 = num20 - num2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
							_ = 0;
							Vector3 item2 = vector + 16;
							verts.Add(item2);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+5C]");
							int item3 = (int)((nint)0 + (nint)1);
							indices.Add(item3);
							string sequence = symbol.sequence;
							object obj4 = sequence._stringLength - 1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+5C]");
							object obj5 = 0 + obj4;
							num8 = num18;
							prev = 0;
							goto IL_0627;
						}
					}
					float glyphWidth = GetGlyphWidth(c, prev);
					bool flag = glyphWidth == 0f;
					num18 = glyphWidth;
					if (!flag)
					{
						float num22 = glyphWidth + finalSpacingX;
						float num23 = num8 + num22;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
						double num24 = Math.Abs(num25);
						double num26 = ((!(num24 < 2147483648.0)) ? (-2147483648.0) : num25);
						if (num26 > (double)regionWidth)
						{
							if (num8 == 0f)
							{
								break;
							}
							if (alignment != Alignment.Left)
							{
								int num27 = num4;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L1 (BetterList`1<UnityEngine.Vector3>)+C]");
								if ((nint)num27 < (nint)0)
								{
									float printedWidth3 = num8 - finalSpacingX;
									Align(verts, num4, printedWidth3, 1);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L1 (BetterList`1<UnityEngine.Vector3>)+C]");
									num4 = 0;
								}
							}
							float num28 = num6 + finalLineHeight;
							num18 = num22;
							num6 = num28;
						}
						else
						{
							float num29 = num8 + num22;
							num18 = num29;
						}
						_ = 0;
						((Vector3*)(nint)vector)->z = 0f;
						float num30 = 0f - num6;
						float num31 = num30 - num2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
						((Vector3*)(nint)vector)->x = 0f;
						verts.Add(vector);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+5C]");
						int item4 = (int)((nint)0 + (nint)1);
						indices.Add(item4);
						num8 = num18;
						prev = c;
					}
				}
				goto IL_0627;
			}
			if (alignment != Alignment.Left)
			{
				int num32 = num4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L1 (BetterList`1<UnityEngine.Vector3>)+C]");
				if ((nint)num32 < (nint)0)
				{
					float printedWidth4 = num8 - finalSpacingX;
					Align(verts, num4, printedWidth4, 1);
				}
			}
			break;
			IL_0627:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+5C]");
			int num33 = (int)((nint)0 + (nint)1);
			num3 = num33;
		}
	}

	public unsafe static void PrintExactCharacterPositions(string text, BetterList<Vector3> verts, BetterList<int> indices)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0038: Expected Obj, but got I4
		//IL_001c: Expected Obj, but got I4
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected Ref, but got Unknown
		//IL_0191: Expected Obj, but got I
		//IL_0281: Expected F8, but got I4
		//IL_049e: Expected F8, but got I4
		//IL_07d7: Invalid comparison between F8 and I4
		//IL_0865: Invalid comparison between F8 and I4
		//IL_0389: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Expected VT, but got Unknown
		//IL_05a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ab: Expected VT, but got Unknown
		//IL_03af: Expected native int or pointer, but got VT
		//IL_03f2: Expected F4, but got I
		//IL_03ed: Expected native int or pointer, but got VT
		//IL_0608: Unknown result type (might be due to invalid IL or missing references)
		//IL_060d: Expected VT, but got Unknown
		//IL_063a: Expected Obj, but got I4
		//IL_064a: Unknown result type (might be due to invalid IL or missing references)
		//IL_064f: Expected Obj, but got Unknown
		//IL_081c: Expected Obj, but got I
		//IL_08aa: Expected Obj, but got I
		object obj = default;
		Vector3 vector = (Vector3)(obj - 128);
		object obj2;
		if (text != null)
		{
			obj2 = 0;
			if (text._stringLength != 0)
			{
				goto IL_0708;
			}
		}
		obj2 = 1;
		goto IL_0708;
		IL_0708:
		string text2 = " ";
		if (obj2 == null)
		{
			text2 = text;
		}
		Prepare(text2);
		float num = (float)fontSize * fontScale;
		int prev = 0;
		int num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L1 (BetterList`1<UnityEngine.Vector3>)+C]");
		int num3 = 0;
		float num4 = default;
		float num6 = default;
		double num11 = default;
		double num23 = default;
		while (true)
		{
			if (num2 < text2._stringLength)
			{
				char c = text2.get_Chars(num2);
				if (c == '\n')
				{
					if (alignment != Alignment.Left)
					{
						float printedWidth = num4 - finalSpacingX;
						Align(verts, num3, printedWidth, 2);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L1 (BetterList`1<UnityEngine.Vector3>)+C]");
						num3 = 0;
					}
					float num5 = num6 + finalLineHeight;
					num6 = num5;
					num4 = 0f;
					prev = 0;
				}
				else if (c < ' ')
				{
					prev = 0;
				}
				else if (~(encoding ? 1u : 0u) == 0 && ParseSymbol(text2, ref *(int*)(vector + 124)))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+7C]");
					object obj3 = -1;
				}
				else
				{
					if (~(useSymbols ? 1u : 0u) == 0)
					{
						string text3 = text2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+7C]");
						BMSymbol symbol = GetSymbol(text3, 0, text2._stringLength);
						if (symbol != null)
						{
							float num7 = (float)symbol.mAdvance * fontScale;
							float num8 = num7 + finalSpacingX;
							float num9 = num4 + num8;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
							double num10 = Math.Abs(num11);
							double num12 = ((!(num10 < 2147483648.0)) ? (-2147483648.0) : num11);
							if (num12 > (double)regionWidth)
							{
								if (num4 == 0f)
								{
									break;
								}
								if (alignment != Alignment.Left)
								{
									int num13 = num3;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L1 (BetterList`1<UnityEngine.Vector3>)+C]");
									if ((nint)num13 < (nint)0)
									{
										float printedWidth2 = num4 - finalSpacingX;
										Align(verts, num3, printedWidth2, 2);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L1 (BetterList`1<UnityEngine.Vector3>)+C]");
										num3 = 0;
									}
								}
								float num14 = num6 + finalLineHeight;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+7C]");
								object obj4 = -1;
								num6 = num14;
								num4 = 0f;
								prev = 0;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+7C]");
								indices.Add(0);
								_ = 0;
								_ = 0;
								float num15 = 0f - num6;
								float num16 = num15 - num;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
								_ = 0;
								Vector3 item = vector + 48;
								verts.Add(item);
								_ = 0;
								_ = 0;
								float num17 = 0f - num6;
								float num18 = num4 + num8;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
								_ = 0;
								Vector3 item2 = vector + 32;
								verts.Add(item2);
								string sequence = symbol.sequence;
								object obj5 = sequence._stringLength - 1;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+7C]");
								object obj6 = 0 + obj5;
								float num19 = num4 + num8;
								num4 = num19;
								prev = 0;
							}
							goto IL_078f;
						}
					}
					float glyphWidth = GetGlyphWidth(c, prev);
					if (glyphWidth != 0f)
					{
						float num20 = glyphWidth + finalSpacingX;
						float num21 = num4 + num20;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
						double num22 = Math.Abs(num23);
						double num24 = ((!(num22 < 2147483648.0)) ? (-2147483648.0) : num23);
						if (num24 > (double)regionWidth)
						{
							if (num4 == 0f)
							{
								break;
							}
							if (alignment != Alignment.Left)
							{
								int num25 = num3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L1 (BetterList`1<UnityEngine.Vector3>)+C]");
								if ((nint)num25 < (nint)0)
								{
									float printedWidth3 = num4 - finalSpacingX;
									Align(verts, num3, printedWidth3, 2);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L1 (BetterList`1<UnityEngine.Vector3>)+C]");
									num3 = 0;
								}
							}
							float num26 = num6 + finalLineHeight;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+7C]");
							object obj7 = -1;
							num6 = num26;
							num4 = 0f;
							prev = 0;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+7C]");
							indices.Add(0);
							_ = 0;
							_ = 0;
							float num27 = 0f - num6;
							float num28 = num27 - num;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+70]");
							_ = 0;
							Vector3 item3 = vector + 16;
							verts.Add(item3);
							_ = 0;
							((Vector3*)(nint)vector)->z = 0f;
							float num29 = 0f - num6;
							float num30 = num4 + num20;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
							((Vector3*)(nint)vector)->x = 0f;
							verts.Add(vector);
							float num31 = num4 + num20;
							num4 = num31;
							prev = c;
						}
					}
				}
				goto IL_078f;
			}
			if (alignment != Alignment.Left)
			{
				int num32 = num3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L1 (BetterList`1<UnityEngine.Vector3>)+C]");
				if ((nint)num32 < (nint)0)
				{
					float printedWidth4 = num4 - finalSpacingX;
					Align(verts, num3, printedWidth4, 2);
				}
			}
			break;
			IL_078f:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+7C]");
			int num33 = (int)((nint)0 + (nint)1);
			num2 = num33;
		}
	}

	public unsafe static void PrintCaretAndSelection(string text, int start, int end, BetterList<Vector3> caret, BetterList<Vector3> highlight)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0038: Expected Obj, but got I4
		//IL_001c: Expected Obj, but got I4
		//IL_1297: Expected I, but got Obj
		//IL_15fe: Expected I, but got Obj
		//IL_1627: Expected F4, but got I
		//IL_1640: Expected F4, but got I
		//IL_1649: Expected Obj, but got I4
		//IL_0096: Expected Obj, but got I4
		//IL_0f70: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f75: Expected Obj, but got Unknown
		//IL_0db4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db9: Expected VT, but got Unknown
		//IL_0e12: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e17: Expected VT, but got Unknown
		//IL_0fbe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc3: Expected VT, but got Unknown
		//IL_0fe3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe8: Expected Obj, but got Unknown
		//IL_0e75: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e7a: Expected VT, but got Unknown
		//IL_0ee2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee7: Expected VT, but got Unknown
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected VT, but got Unknown
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected VT, but got Unknown
		//IL_15aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_15af: Expected VT, but got Unknown
		//IL_063b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0640: Expected Ref, but got Unknown
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Expected VT, but got Unknown
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Expected VT, but got Unknown
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Expected Obj, but got Unknown
		//IL_1086: Unknown result type (might be due to invalid IL or missing references)
		//IL_108b: Expected VT, but got Unknown
		//IL_10d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_10d9: Expected VT, but got Unknown
		//IL_1137: Unknown result type (might be due to invalid IL or missing references)
		//IL_113c: Expected VT, but got Unknown
		//IL_118b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1190: Expected Obj, but got Unknown
		//IL_0685: Expected Obj, but got I
		//IL_055c: Expected Obj, but got I4
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Expected VT, but got Unknown
		//IL_0394: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Expected Obj, but got Unknown
		//IL_1327: Expected native int or pointer, but got VT
		//IL_1339: Expected F4, but got Obj
		//IL_1334: Expected native int or pointer, but got VT
		//IL_07d5: Expected F8, but got I4
		//IL_058c: Expected Obj, but got I4
		//IL_13cf: Invalid comparison between F8 and I4
		//IL_0434: Unknown result type (might be due to invalid IL or missing references)
		//IL_0439: Expected VT, but got Unknown
		//IL_0482: Unknown result type (might be due to invalid IL or missing references)
		//IL_0487: Expected VT, but got Unknown
		//IL_04e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ea: Expected VT, but got Unknown
		//IL_0539: Unknown result type (might be due to invalid IL or missing references)
		//IL_053e: Expected Obj, but got Unknown
		//IL_05ce: Expected Obj, but got I4
		//IL_1522: Expected VT, but got F4
		//IL_1532: Expected VT, but got F4
		//IL_08dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e2: Expected Obj, but got Unknown
		//IL_0bdc: Expected Obj, but got I4
		//IL_0c9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca1: Expected Obj, but got Unknown
		//IL_0caa: Expected Obj, but got I4
		//IL_0b18: Expected Obj, but got I4
		//IL_092b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0930: Expected VT, but got Unknown
		//IL_0950: Unknown result type (might be due to invalid IL or missing references)
		//IL_0955: Expected Obj, but got Unknown
		//IL_0c0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c12: Expected Obj, but got Unknown
		//IL_0c2a: Expected Obj, but got I4
		//IL_1503: Unknown result type (might be due to invalid IL or missing references)
		//IL_1508: Expected VT, but got Unknown
		//IL_0ce4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce9: Expected VT, but got Unknown
		//IL_0d09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d0e: Expected Obj, but got Unknown
		//IL_0b48: Expected Obj, but got I4
		//IL_1571: Unknown result type (might be due to invalid IL or missing references)
		//IL_1576: Expected VT, but got Unknown
		//IL_0c64: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c69: Expected VT, but got Unknown
		//IL_0c89: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c8e: Expected Obj, but got Unknown
		//IL_09f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f5: Expected VT, but got Unknown
		//IL_0a3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a43: Expected VT, but got Unknown
		//IL_0aa1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa6: Expected VT, but got Unknown
		//IL_0af5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afa: Expected Obj, but got Unknown
		//IL_0b8b: Expected Obj, but got I4
		object obj = default;
		Vector3 vector = (Vector3)(obj - 896);
		object obj2;
		if (text != null)
		{
			obj2 = 0;
			if (text._stringLength != 0)
			{
				goto IL_1223;
			}
		}
		obj2 = 1;
		goto IL_1223;
		IL_1223:
		string text2 = " ";
		if (obj2 == null)
		{
			text2 = text;
		}
		Prepare(text2);
		float num = (float)fontSize * fontScale;
		BetterList<Vector3> betterList = default;
		if (betterList != null)
		{
		}
		int num2 = default;
		if (highlight != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [highlight @ L4 (BetterList`1<UnityEngine.Vector3>)+C]");
			num2 = 0;
		}
		_ = 0;
		nint num3 = (nint)typeof(Vector2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v34 (Il2CppClass<UnityEngine.Vector2>)+5C]");
		nint num4 = 0;
		bool flag = start > end;
		int num5 = end;
		if (!flag)
		{
			num5 = start;
		}
		int num6 = start;
		if (!flag)
		{
			num6 = end;
		}
		nint num7 = (nint)typeof(Vector2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S0_v48 (Il2CppClass<UnityEngine.Vector2>)+5C]");
		nint num8 = 0;
		Vector2 zeroVector = Vector2.zeroVector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v49 (Il2CppStaticFields<UnityEngine.Vector2>)+4]");
		float num9 = 0f;
		Vector2 zeroVector2 = Vector2.zeroVector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v35 (Il2CppStaticFields<UnityEngine.Vector2>)+4]");
		float num10 = 0f;
		object obj3 = 0;
		char prev = '\0';
		int num11 = 0;
		float num13 = default;
		float num16 = default;
		double num62 = default;
		while (true)
		{
			bool flag2;
			char c;
			BetterList<Vector3> betterList2;
			object obj6;
			float num36;
			if (num11 < text2._stringLength)
			{
				flag2 = betterList == null;
				object obj4 = (flag2 ? 1 : 0) | 1;
				if (obj4 == null && num11 >= end)
				{
					_ = 0;
					_ = 0;
					float num12 = 0f - num13;
					float num14 = num12 - num;
					float num15 = num16 - 1f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+370]");
					_ = 0;
					Vector3 item = vector + 256;
					betterList.Add(item);
					_ = 0;
					_ = 0;
					float num17 = 0f - num13;
					float num18 = num16 - 1f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+360]");
					_ = 0;
					Vector3 item2 = vector + 240;
					betterList.Add(item2);
					_ = 0;
					_ = 0;
					float num19 = 0f - num13;
					float num20 = num16 + 1f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+350]");
					_ = 0;
					Vector3 item3 = vector + 224;
					betterList.Add(item3);
					_ = 0;
					_ = 0;
					float num21 = 0f - num13;
					float num22 = num21 - num;
					float num23 = num16 + 1f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+340]");
					_ = 0;
					Vector3 item4 = vector + 208;
					betterList.Add(item4);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+37C]");
					num11 = 0;
				}
				c = text2.get_Chars(num11);
				if (c == '\n')
				{
					int num24 = 1 ^ -1;
					int num25 = (flag2 ? 1 : 0) | num24;
					int num26 = num25 & 1;
					betterList2 = betterList;
					if (num26 == 0)
					{
						bool flag3 = alignment == Alignment.Left;
						betterList2 = null;
						if (!flag3)
						{
							float printedWidth = num16 - finalSpacingX;
							BetterList<Vector3> verts = betterList;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ L3_v3 (BetterList`1<UnityEngine.Vector3>)+C]");
							Align(verts, 0, printedWidth);
							betterList2 = null;
						}
					}
					if (highlight != null)
					{
						object obj5 = obj3 & 1;
						if (obj5 != null)
						{
							_ = 0;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+330]");
							_ = 0;
							Vector3 item5 = vector + 16;
							highlight.Add(item5);
							obj6 = vector + 800;
							goto IL_1318;
						}
						int num27 = num5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+37C]");
						if ((nint)num27 <= (nint)0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+37C]");
							if ((nint)0 < (nint)num6)
							{
								_ = 0;
								_ = 0;
								float num28 = 0f - num13;
								float num29 = num28 - num;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+310]");
								_ = 0;
								Vector3 item6 = vector - -64;
								highlight.Add(item6);
								_ = 0;
								_ = 0;
								float num30 = 0f - num13;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+300]");
								_ = 0;
								Vector3 item7 = vector + 48;
								highlight.Add(item7);
								_ = 0;
								_ = 0;
								float num31 = 0f - num13;
								float num32 = num16 + 2f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+2F0]");
								_ = 0;
								Vector3 item8 = vector + 32;
								highlight.Add(item8);
								float num33 = 0f - num13;
								float num34 = num33 - num;
								float num35 = num16 + 2f;
								obj6 = vector + 736;
								goto IL_1318;
							}
						}
						goto IL_0543;
					}
					goto IL_134b;
				}
				if (c < ' ')
				{
					prev = '\0';
					goto IL_1382;
				}
				if (~(encoding ? 1u : 0u) == 0 && ParseSymbol(text2, ref *(int*)(vector + 892)))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+37C]");
					object obj7 = -1;
					goto IL_1382;
				}
				if (~(useSymbols ? 1u : 0u) == 0)
				{
					string text3 = text2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+37C]");
					BMSymbol symbol = GetSymbol(text3, 0, text2._stringLength);
					if (symbol != null)
					{
						num36 = (float)symbol.mAdvance * fontScale;
						goto IL_071b;
					}
				}
				num36 = GetGlyphWidth(c, prev);
				goto IL_071b;
			}
			if (betterList != null)
			{
				if (1 == 0)
				{
					_ = 0;
					_ = 0;
					float num37 = 0f - num13;
					float num38 = num37 - num;
					float num39 = num16 - 1f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+230]");
					_ = 0;
					Vector3 item9 = vector + 400;
					betterList.Add(item9);
					_ = 0;
					_ = 0;
					float num40 = 0f - num13;
					float num41 = num16 - 1f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+220]");
					_ = 0;
					Vector3 item10 = vector + 384;
					betterList.Add(item10);
					_ = 0;
					_ = 0;
					float num42 = 0f - num13;
					float num43 = num16 + 1f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+210]");
					_ = 0;
					Vector3 item11 = vector + 368;
					betterList.Add(item11);
					_ = 0;
					_ = 0;
					float num44 = 0f - num13;
					float num45 = num44 - num;
					float num46 = num16 + 1f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+200]");
					_ = 0;
					Vector3 item12 = vector + 352;
					betterList.Add(item12);
				}
				if (alignment != Alignment.Left)
				{
					float printedWidth2 = num16 - finalSpacingX;
					BetterList<Vector3> verts2 = betterList;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ L3_v3 (BetterList`1<UnityEngine.Vector3>)+C]");
					Align(verts2, 0, printedWidth2);
				}
			}
			if (highlight == null)
			{
				break;
			}
			object obj8 = obj3 & 1;
			if (obj8 != null)
			{
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1F0]");
				_ = 0;
				Vector3 item13 = vector + 288;
				highlight.Add(item13);
				object obj9 = vector + 480;
				goto IL_1590;
			}
			int num47 = num5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+37C]");
			if ((nint)num47 < (nint)0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+37C]");
				if ((nint)0 == num6)
				{
					_ = 0;
					_ = 0;
					float num48 = 0f - num13;
					float num49 = num48 - num;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1D0]");
					_ = 0;
					Vector3 item14 = vector + 336;
					highlight.Add(item14);
					_ = 0;
					_ = 0;
					float num50 = 0f - num13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1C0]");
					_ = 0;
					Vector3 item15 = vector + 320;
					highlight.Add(item15);
					_ = 0;
					_ = 0;
					float num51 = 0f - num13;
					float num52 = num16 + 2f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1B0]");
					_ = 0;
					Vector3 item16 = vector + 304;
					highlight.Add(item16);
					float num53 = 0f - num13;
					float num54 = num53 - num;
					float num55 = num16 + 2f;
					object obj9 = vector + 416;
					goto IL_1590;
				}
			}
			goto IL_1195;
			IL_1590:
			_ = 0;
			_ = 0;
			Vector3 item17 = vector + 272;
			highlight.Add(item17);
			goto IL_1195;
			IL_071b:
			if (num36 == 0f)
			{
				goto IL_1382;
			}
			float num56 = 0f - num13;
			float num57 = num56 - num;
			float num58 = 0f - num13;
			float num59 = num16 + num36;
			float num60 = num59 + finalSpacingX;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
			double num61 = Math.Abs(num62);
			double num63 = ((!(num61 < 2147483648.0)) ? (-2147483648.0) : num62);
			float num65;
			float num66;
			float num67;
			object obj10;
			float num64;
			if (!(num63 > (double)regionWidth))
			{
				num64 = num16;
				num65 = num59;
				num66 = num58;
				num67 = num57;
				obj10 = obj3;
				goto IL_13f1;
			}
			if (num16 == 0f)
			{
				break;
			}
			int num68 = 1 ^ -1;
			int num69 = (flag2 ? 1 : 0) | num68;
			int num70 = num69 & 1;
			BetterList<Vector3> betterList3 = betterList;
			if (num70 == 0)
			{
				bool flag4 = alignment == Alignment.Left;
				betterList3 = null;
				if (!flag4)
				{
					float printedWidth3 = num16 - finalSpacingX;
					BetterList<Vector3> verts3 = betterList;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ L3_v3 (BetterList`1<UnityEngine.Vector3>)+C]");
					Align(verts3, 0, printedWidth3);
					betterList3 = null;
				}
			}
			if (highlight == null)
			{
				obj10 = obj3;
				goto IL_145d;
			}
			object obj11 = obj3 & 1;
			if (obj11 != null)
			{
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+2D0]");
				_ = 0;
				Vector3 item18 = vector + 144;
				highlight.Add(item18);
				object obj12 = vector + 704;
				goto IL_14e9;
			}
			int num71 = num5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+37C]");
			if ((nint)num71 <= (nint)0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+37C]");
				if ((nint)0 < (nint)num6)
				{
					_ = 0;
					_ = 0;
					float num72 = 0f - num13;
					float num73 = num72 - num;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+2B0]");
					_ = 0;
					Vector3 item19 = vector + 192;
					highlight.Add(item19);
					_ = 0;
					_ = 0;
					float num74 = 0f - num13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+2A0]");
					_ = 0;
					Vector3 item20 = vector + 176;
					highlight.Add(item20);
					_ = 0;
					_ = 0;
					float num75 = 0f - num13;
					float num76 = num16 + 2f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+290]");
					_ = 0;
					Vector3 item21 = vector + 160;
					highlight.Add(item21);
					float num77 = 0f - num13;
					float num78 = num77 - num;
					float num79 = num16 + 2f;
					object obj12 = vector + 640;
					goto IL_14e9;
				}
			}
			goto IL_0aff;
			IL_14e9:
			_ = 0;
			_ = 0;
			Vector3 item22 = vector + 128;
			highlight.Add(item22);
			goto IL_0aff;
			IL_0543:
			bool flag5 = alignment == Alignment.Left;
			obj3 = 0;
			if (!flag5)
			{
				int num80 = num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [highlight @ L4 (BetterList`1<UnityEngine.Vector3>)+C]");
				bool flag6 = (nint)num80 >= (nint)0;
				obj3 = 0;
				if (!flag6)
				{
					float printedWidth4 = num16 - finalSpacingX;
					Align(highlight, num2, printedWidth4);
					obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [highlight @ L4 (BetterList`1<UnityEngine.Vector3>)+C]");
					num2 = 0;
				}
			}
			goto IL_134b;
			IL_134b:
			float num81 = num13 + finalLineHeight;
			betterList = betterList2;
			num13 = num81;
			num16 = 0f;
			prev = '\0';
			goto IL_1382;
			IL_13f1:
			float num82 = num36 + finalSpacingX;
			float num83 = num16 + num82;
			bool flag7 = highlight == null;
			object obj13 = obj10;
			if (!flag7)
			{
				int num84 = num5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+37C]");
				bool flag8 = (nint)num84 <= (nint)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+37C]");
				bool flag9 = (nint)0 < (nint)num6;
				object obj14 = flag8 & flag9;
				if (obj14 == null)
				{
					object obj15 = obj10 & 1;
					bool flag10 = obj15 == null;
					obj13 = 0;
					if (flag10)
					{
						goto IL_151a;
					}
					_ = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+270]");
					_ = 0;
					Vector3 item23 = vector + 112;
					highlight.Add(item23);
					object obj16 = vector + 608;
				}
				else
				{
					object obj17 = obj10 & 1;
					obj13 = 1;
					if (obj17 != null)
					{
						goto IL_151a;
					}
					_ = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+250]");
					_ = 0;
					Vector3 item24 = vector + 96;
					highlight.Add(item24);
					object obj16 = vector + 576;
				}
				_ = 0;
				_ = 0;
				Vector3 item25 = vector + 80;
				highlight.Add(item25);
				obj13 = obj14;
			}
			goto IL_151a;
			IL_151a:
			zeroVector = (Vector2)num65;
			num9 = num66;
			zeroVector2 = (Vector2)num65;
			num10 = num67;
			num16 = num83;
			obj3 = obj13;
			prev = c;
			goto IL_1382;
			IL_145d:
			float num85 = num16 - num16;
			float num86 = num59 - num16;
			float num87 = num57 - finalLineHeight;
			float num88 = num58 - finalLineHeight;
			float num89 = num13 + finalLineHeight;
			betterList = betterList3;
			num64 = num85;
			num65 = num86;
			num66 = num88;
			num67 = num87;
			num13 = num89;
			num16 = 0f;
			goto IL_13f1;
			IL_1382:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+37C]");
			int num90 = (int)((nint)0 + (nint)1);
			num11 = num90;
			continue;
			IL_1195:
			if (alignment != Alignment.Left)
			{
				int num91 = num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [highlight @ L4 (BetterList`1<UnityEngine.Vector3>)+C]");
				if ((nint)num91 < (nint)0)
				{
					float printedWidth5 = num16 - finalSpacingX;
					Align(highlight, num2, printedWidth5);
				}
			}
			break;
			IL_0aff:
			bool flag11 = alignment == Alignment.Left;
			obj10 = 0;
			if (!flag11)
			{
				int num92 = num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [highlight @ L4 (BetterList`1<UnityEngine.Vector3>)+C]");
				bool flag12 = (nint)num92 >= (nint)0;
				obj10 = 0;
				if (!flag12)
				{
					float printedWidth6 = num16 - finalSpacingX;
					Align(highlight, num2, printedWidth6);
					obj10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [highlight @ L4 (BetterList`1<UnityEngine.Vector3>)+C]");
					num2 = 0;
				}
			}
			goto IL_145d;
			IL_1318:
			_ = 0;
			((Vector3*)(nint)vector)->z = 0f;
			((Vector3*)(nint)vector)->x = (float)obj6;
			highlight.Add(vector);
			goto IL_0543;
		}
	}

	static NGUIText()
	{
		//IL_007e: Expected I, but got Obj
		//IL_00a6: Expected VT, but got I8
		//IL_00f0: Expected I, but got Obj
		//IL_0118: Expected VT, but got I8
		//IL_0126: Expected I, but got Obj
		//IL_014e: Expected VT, but got I8
		//IL_01b6: Expected I, but got Obj
		//IL_01d0: Expected VT, but got I4
		GlyphInfo glyphInfo = default;
		glyph = glyphInfo;
		fontSize = 16;
		fontScale = 1f;
		pixelDensity = 1f;
		fontStyle = FontStyle.Normal;
		alignment = Alignment.Left;
		nint num = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v30 (Il2CppClass<NGUIText>)+5C]");
		nint num2 = 0;
		_ = 4575657222473777152L;
		tint = (Color)4575657222473777152L;
		rectWidth = 1000000;
		rectHeight = 1000000;
		regionWidth = 1000000;
		regionHeight = 1000000;
		maxLines = 0;
		gradient = false;
		nint num3 = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v52 (Il2CppClass<NGUIText>)+5C]");
		nint num4 = 0;
		_ = 4575657222473777152L;
		gradientBottom = (Color)4575657222473777152L;
		nint num5 = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v56 (Il2CppClass<NGUIText>)+5C]");
		nint num6 = 0;
		_ = 4575657222473777152L;
		gradientTop = (Color)4575657222473777152L;
		encoding = false;
		spacingX = 0f;
		spacingY = 0f;
		premultiply = false;
		finalSize = 0;
		finalSpacingX = 0f;
		finalLineHeight = 0f;
		baseline = 0f;
		useSymbols = false;
		nint num7 = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S0_v87 (Il2CppClass<NGUIText>)+5C]");
		nint num8 = 0;
		mInvisible = (Color)0;
		_ = 0;
		BetterList<Color> betterList = default;
		mColors = betterList;
		mAlpha = 1f;
		BetterList<float> betterList2 = default;
		mSizes = betterList2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Array array = default;
		RuntimeHelpers.InitializeArray(array, __ldtoken(_003CPrivateImplementationDetails_003E._07F953EB3DB1131FBDB6AA2748FD8EC70F792C02BF125F3577B8988B69AF80B0));
		mBoldOffset = (float[])array;
	}
}
