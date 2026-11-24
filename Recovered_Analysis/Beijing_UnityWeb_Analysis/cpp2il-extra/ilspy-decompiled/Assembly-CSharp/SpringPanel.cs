using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public class SpringPanel : MonoBehaviour
{
	public delegate void OnFinished();

	public static SpringPanel current;

	public Vector3 target;

	public float strength;

	public OnFinished onFinished;

	private UIPanel mPanel;

	private Transform mTrans;

	private UIScrollView mDrag;

	private void Start()
	{
		CancelInvoke();
	}

	private void Update()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected Obj, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected Obj, but got Unknown
		object obj = this + 32;
		UIPanel component = GetComponent<UIPanel>();
		obj = component;
		object obj2 = this + 40;
		UIScrollView component2 = GetComponent<UIScrollView>();
		obj2 = component2;
		object obj3 = this + 36;
		GameObject gameObject = base.gameObject;
		obj3 = gameObject;
	}

	protected virtual void AdvanceTowardsPosition()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
	}

	public unsafe static SpringPanel Begin(GameObject go, Vector3 pos, float strength)
	{
		//IL_0a33: Expected I, but got Obj
		//IL_0a49: Expected Obj, but got I
		//IL_1015: Expected I, but got Obj
		//IL_102b: Expected Obj, but got I
		//IL_12d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_12de: Expected VT, but got Unknown
		//IL_12e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ec: Expected Obj, but got Unknown
		//IL_12f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_12fa: Expected Obj, but got Unknown
		//IL_1303: Unknown result type (might be due to invalid IL or missing references)
		//IL_1308: Expected Obj, but got Unknown
		//IL_1311: Unknown result type (might be due to invalid IL or missing references)
		//IL_1316: Expected Obj, but got Unknown
		//IL_131f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1324: Expected Obj, but got Unknown
		//IL_132d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1332: Expected Obj, but got Unknown
		//IL_133b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1340: Expected Obj, but got Unknown
		//IL_1349: Unknown result type (might be due to invalid IL or missing references)
		//IL_134e: Expected Obj, but got Unknown
		//IL_1357: Unknown result type (might be due to invalid IL or missing references)
		//IL_135c: Expected Obj, but got Unknown
		//IL_1365: Unknown result type (might be due to invalid IL or missing references)
		//IL_136a: Expected Obj, but got Unknown
		//IL_1373: Unknown result type (might be due to invalid IL or missing references)
		//IL_1378: Expected Obj, but got Unknown
		//IL_1381: Unknown result type (might be due to invalid IL or missing references)
		//IL_1386: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_03e0: Expected I, but got Obj
		//IL_03f6: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_0dab: Expected I, but got Obj
		//IL_0dc1: Expected Obj, but got I
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_0421: Expected I, but got Obj
		//IL_046e: Expected I, but got Obj
		//IL_0143: Expected I4, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_04bb: Expected I, but got Obj
		//IL_04d1: Expected Obj, but got I
		//IL_0aa9: Expected Obj, but got I4
		//IL_0de7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dec: Expected Obj, but got Unknown
		//IL_0dfa: Expected I, but got Obj
		//IL_0e10: Expected Obj, but got I
		//IL_04fc: Expected I, but got Obj
		//IL_0151: Invalid comparison between VT and I4
		//IL_0549: Expected I, but got Obj
		//IL_055f: Expected Obj, but got I
		//IL_0e41: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e46: Expected Obj, but got Unknown
		//IL_0e54: Expected I, but got Obj
		//IL_0e6a: Expected Obj, but got I
		//IL_0e86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e8b: Expected Obj, but got Unknown
		//IL_0e99: Expected I, but got Obj
		//IL_0eaf: Expected Obj, but got I
		//IL_0ecb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed0: Expected Obj, but got Unknown
		//IL_0ede: Expected I, but got Obj
		//IL_0ef4: Expected Obj, but got I
		//IL_0ad8: Expected I, but got Obj
		//IL_0aee: Expected Obj, but got I
		//IL_0180: Expected Obj, but got VT
		//IL_0180: Expected Obj, but got I4
		//IL_05e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ed: Expected Obj, but got Unknown
		//IL_05fb: Expected I, but got Obj
		//IL_0611: Expected Obj, but got I
		//IL_0647: Expected I, but got Obj
		//IL_065d: Expected Obj, but got I
		//IL_058a: Expected I, but got Obj
		//IL_1052: Unknown result type (might be due to invalid IL or missing references)
		//IL_1057: Expected Obj, but got Unknown
		//IL_1072: Expected Obj, but got I
		//IL_0679: Expected F4, but got Obj
		//IL_0674: Expected native int or pointer, but got VT
		//IL_068b: Expected VT, but got F4
		//IL_06a2: Expected I, but got Obj
		//IL_06b8: Expected Obj, but got I
		//IL_06cf: Expected F4, but got Obj
		//IL_06ca: Expected native int or pointer, but got VT
		//IL_06e1: Expected VT, but got F4
		//IL_06f8: Expected I, but got Obj
		//IL_070e: Expected Obj, but got I
		//IL_13c8: Expected I, but got Obj
		//IL_13de: Expected Obj, but got I
		//IL_01a5: Expected I, but got Obj
		//IL_072a: Expected F4, but got Obj
		//IL_0725: Expected native int or pointer, but got VT
		//IL_073c: Expected VT, but got F4
		//IL_0753: Expected I, but got Obj
		//IL_0769: Expected Obj, but got I
		//IL_0780: Expected F4, but got Obj
		//IL_077b: Expected native int or pointer, but got VT
		//IL_0792: Expected VT, but got F4
		//IL_0b15: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1a: Expected Obj, but got Unknown
		//IL_0b30: Expected Obj, but got I
		//IL_0b3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b44: Expected Obj, but got Unknown
		//IL_0b4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b53: Expected Obj, but got Unknown
		//IL_0b63: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b68: Expected Obj, but got Unknown
		//IL_0b7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b7f: Expected Obj, but got Unknown
		//IL_0b89: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8e: Expected Obj, but got Unknown
		//IL_0bab: Expected Obj, but got I
		//IL_0bba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bbf: Expected Obj, but got Unknown
		//IL_0bcf: Expected Obj, but got I
		//IL_0bd9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bde: Expected Obj, but got Unknown
		//IL_0bfb: Expected Obj, but got I
		//IL_0c0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c0f: Expected Obj, but got Unknown
		//IL_0c2c: Expected Obj, but got I
		//IL_0c3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c43: Expected Obj, but got Unknown
		//IL_0c5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c5f: Expected Obj, but got Unknown
		//IL_0c69: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c6e: Expected Obj, but got Unknown
		//IL_0c80: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c85: Expected Obj, but got Unknown
		//IL_0c8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c94: Expected Obj, but got Unknown
		//IL_0cab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb0: Expected Obj, but got Unknown
		//IL_0cba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cbf: Expected Obj, but got Unknown
		//IL_0cd1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd6: Expected Obj, but got Unknown
		//IL_0ce0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce5: Expected Obj, but got Unknown
		//IL_0d00: Expected I, but got Obj
		//IL_0d16: Expected Obj, but got I
		//IL_01f9: Expected Obj, but got I
		//IL_07b6: Expected F4, but got Obj
		//IL_07d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07dc: Expected Obj, but got Unknown
		//IL_07e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07eb: Expected Obj, but got Unknown
		//IL_07f9: Expected I, but got Obj
		//IL_080f: Expected Obj, but got I
		//IL_109e: Expected Obj, but got I
		//IL_0214: Expected I, but got Obj
		//IL_0f1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f24: Expected Obj, but got Unknown
		//IL_0f2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f33: Expected Obj, but got Unknown
		//IL_0f4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f51: Expected Obj, but got Unknown
		//IL_0f5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f60: Expected Obj, but got Unknown
		//IL_1409: Expected I, but got Obj
		//IL_141f: Expected Obj, but got I
		//IL_0261: Expected I, but got Obj
		//IL_088b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0890: Expected Obj, but got Unknown
		//IL_089a: Unknown result type (might be due to invalid IL or missing references)
		//IL_089f: Expected Obj, but got Unknown
		//IL_083a: Expected I, but got Obj
		//IL_02ae: Expected I, but got Obj
		//IL_02c4: Expected Obj, but got I
		//IL_0f7d: Expected I, but got Obj
		//IL_0f93: Expected Obj, but got I
		//IL_0389: Expected I, but got Obj
		//IL_0d49: Expected Obj, but got VT
		//IL_0d57: Expected I, but got Obj
		//IL_0d6d: Expected Obj, but got I
		//IL_08f7: Expected I, but got Obj
		//IL_090d: Expected Obj, but got I
		//IL_1118: Expected F4, but got Obj
		//IL_1113: Expected native int or pointer, but got VT
		//IL_1136: Expected F4, but got Obj
		//IL_1131: Expected native int or pointer, but got VT
		//IL_1148: Expected VT, but got F4
		//IL_115e: Expected Obj, but got VT
		//IL_116b: Expected F4, but got Obj
		//IL_1166: Expected native int or pointer, but got VT
		//IL_1189: Expected F4, but got Obj
		//IL_1184: Expected native int or pointer, but got VT
		//IL_119b: Expected VT, but got F4
		//IL_02ef: Expected I, but got Obj
		//IL_09d2: Expected I, but got Obj
		//IL_0fc6: Expected Obj, but got VT
		//IL_0fd4: Expected I, but got Obj
		//IL_0fea: Expected Obj, but got I
		//IL_033c: Expected I, but got Obj
		//IL_121e: Expected F4, but got Obj
		//IL_1219: Expected native int or pointer, but got VT
		//IL_123c: Expected F4, but got Obj
		//IL_1237: Expected native int or pointer, but got VT
		//IL_124e: Expected VT, but got F4
		//IL_1264: Expected Obj, but got VT
		//IL_1271: Expected F4, but got Obj
		//IL_126c: Expected native int or pointer, but got VT
		//IL_128f: Expected F4, but got Obj
		//IL_128a: Expected native int or pointer, but got VT
		//IL_12a1: Expected VT, but got F4
		//IL_0938: Expected I, but got Obj
		//IL_0985: Expected I, but got Obj
		nint num = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<NGUIText>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v354 (Il2CppClass<NGUIText>)+74]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S1_v291 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		Vector2 vector = (Vector2)(obj3 + 104);
		object obj4 = obj3 + 16;
		object obj5 = obj3 + 96;
		object obj6 = obj3 + 88;
		object obj7 = obj3 + 80;
		object obj8 = obj3 + 72;
		object obj9 = obj3 - -64;
		object obj10 = obj3 + 56;
		object obj11 = obj3 + 48;
		object obj12 = obj3 + 40;
		object obj13 = obj3 + 32;
		object obj14 = obj3 + 24;
		object obj15 = obj3 + 8;
		if (((ComputeShader)(object)NGUIText.bitmapFont).FindKernel((string)null) != 0)
		{
			nint num5 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v179 (Il2CppClass<NGUIText>)+BA]");
			object obj16 = (nint)0 & (nint)0x200;
			if (obj16 != null)
			{
				nint num6 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v348 (Il2CppClass<NGUIText>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int texWidth = NGUIText.bitmapFont.texWidth;
			bool flag = (nint)go == 8201;
			int previousChar = ((!flag) ? ((int)go) : 32);
			int kerning = ((BMGlyph)texWidth).GetKerning(previousChar);
			if (kerning != 0)
			{
				bool flag2 = pos != (Vector3)(object)0;
				bool flag3 = flag2 && ((BMSymbol)kerning).Validate((UIAtlas)pos);
				nint num7 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ S0_v194 (Il2CppClass<NGUIText>)+BA]");
				object obj17 = (nint)0 & (nint)0x200;
				if (obj17 != null)
				{
					nint num8 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ S0_v339 (Il2CppClass<NGUIText>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj18 = NGUIText.glyph + 8;
				bool flag4 = !flag2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v187 (System.Int32)+1C]");
				object obj19 = 0;
				if (!flag4)
				{
					bool flag5 = flag3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v187 (System.Int32)+1C]");
					object obj20 = (nint)(flag5 ? 1 : 0) + (nint)0;
					obj19 = obj20;
				}
				obj18 = obj19;
				nint num9 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ S0_v203 (Il2CppClass<NGUIText>)+BA]");
				object obj21 = (nint)0 & (nint)0x200;
				if (obj21 != null)
				{
					nint num10 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ S0_v333 (Il2CppClass<NGUIText>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj22 = NGUIText.glyph + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v187 (System.Int32)+20]");
				object obj23 = -0;
				object obj24 = NGUIText.glyph + 16;
				object obj25 = NGUIText.glyph + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v187 (System.Int32)+14]");
				object obj26 = obj25 + 0;
				obj24 = obj26;
				object obj27 = NGUIText.glyph + 8;
				object obj28 = NGUIText.glyph + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ S1_v203+4]");
				nint num11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v187 (System.Int32)+18]");
				object obj29 = num11 - 0;
				object obj30 = NGUIText.glyph + 24;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v187 (System.Int32)+C]");
				obj30 = 0;
				object obj31 = NGUIText.glyph + 24;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v187 (System.Int32)+18]");
				nint num12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v187 (System.Int32)+10]");
				object obj32 = num12 + 0;
				object obj33 = NGUIText.glyph + 40;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v187 (System.Int32)+14]");
				nint num13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v187 (System.Int32)+C]");
				object obj34 = num13 + 0;
				obj33 = obj34;
				object obj35 = NGUIText.glyph + 40;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v187 (System.Int32)+10]");
				_ = 0;
				object obj36 = NGUIText.glyph + 32;
				object obj37 = NGUIText.glyph + 24;
				obj36 = obj37;
				object obj38 = NGUIText.glyph + 32;
				object obj39 = NGUIText.glyph + 40;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v509 @ S1_v232+4]");
				_ = 0;
				object obj40 = NGUIText.glyph + 48;
				object obj41 = NGUIText.glyph + 40;
				obj40 = obj41;
				object obj42 = NGUIText.glyph + 48;
				object obj43 = NGUIText.glyph + 24;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ S1_v246+4]");
				_ = 0;
				nint num14 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ S0_v264 (Il2CppClass<NGUIText>)+BA]");
				object obj44 = (nint)0 & (nint)0x200;
				if (obj44 != null)
				{
					nint num15 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v565 @ S0_v327 (Il2CppClass<NGUIText>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				NGUIText.GlyphInfo glyph = NGUIText.glyph;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v187 (System.Int32)+24]");
				object obj45 = (nint)0 >> (flag ? 1 : 0);
				float advance = (float)(flag3 ? 1 : 0) + (float)obj45;
				glyph.advance = advance;
				NGUIText.GlyphInfo glyph2 = NGUIText.glyph;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v187 (System.Int32)+28]");
				glyph2.channel = 0;
				if (strength != 1f)
				{
					nint num16 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v611 @ S0_v293 (Il2CppClass<NGUIText>)+BA]");
					object obj46 = (nint)0 & (nint)0x200;
					if (obj46 != null)
					{
						nint num17 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ S0_v321 (Il2CppClass<NGUIText>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					NGUIText.GlyphInfo glyph3 = NGUIText.glyph;
					obj4 = glyph3.v0;
					nint num18 = (nint)typeof(Vector2);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v667 @ S0_v299 (Il2CppClass<UnityEngine.Vector2>)+BA]");
					object obj47 = (nint)0 & (nint)0x200;
					if (obj47 != null)
					{
						nint num19 = (nint)typeof(Vector2);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v699 @ S0_v317 (Il2CppClass<UnityEngine.Vector2>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					obj5 = obj4;
					((Vector2*)(nint)vector)->x = (float)obj5;
					Vector2 vector2 = vector / strength;
					((Vector2*)(nint)vector)->x = (float)obj6;
					glyph3.v0 = (Vector2)vector.x;
					NGUIText.GlyphInfo glyph4 = NGUIText.glyph;
					obj7 = glyph4.v1;
					((Vector2*)(nint)vector)->x = (float)obj7;
					Vector2 vector3 = vector / strength;
					((Vector2*)(nint)vector)->x = (float)obj8;
					glyph4.v1 = (Vector2)vector.x;
					NGUIText.GlyphInfo glyph5 = NGUIText.glyph;
					float advance2 = glyph5.advance * strength;
					glyph5.advance = advance2;
				}
				nint num20 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ S0_v279 (Il2CppClass<NGUIText>)+BA]");
				object obj48 = (nint)0 & (nint)0x200;
				if (obj48 != null)
				{
					nint num21 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v673 @ S0_v286 (Il2CppClass<NGUIText>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				return (SpringPanel)(object)NGUIText.glyph;
			}
			return null;
		}
		nint num22 = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S0_v19 (Il2CppClass<NGUIText>)+BA]");
		object obj49 = (nint)0 & (nint)0x200;
		if (obj49 != null)
		{
			nint num23 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S0_v172 (Il2CppClass<NGUIText>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num24 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S1_v40 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj50 = (nint)0 & (nint)0x200;
		if (obj50 != null)
		{
			nint num25 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S1_v167 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)NGUIText.dynamicFont).FindKernel((string)null) != 0)
		{
			nint num26 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ S0_v29 (Il2CppClass<NGUIText>)+BA]");
			object obj51 = (nint)0 & (nint)0x200;
			if (obj51 != null)
			{
				nint num27 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ S0_v166 (Il2CppClass<NGUIText>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj52 = go & 0xFFFF;
			nint num28 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ S2_v21 (Il2CppClass<NGUIText>)+5C]");
			object obj53 = (nint)0 + (nint)168;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11588");
			object obj54 = default;
			if (obj54 != null)
			{
				nint num29 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ S0_v40 (Il2CppClass<NGUIText>)+BA]");
				object obj55 = (nint)0 & (nint)0x200;
				if (obj55 != null)
				{
					nint num30 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ S0_v160 (Il2CppClass<NGUIText>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj56 = NGUIText.glyph + 8;
				nint num31 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ S1_v52 (Il2CppClass<NGUIText>)+5C]");
				object obj57 = (nint)0 + (nint)168;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11569");
				object obj58 = default;
				obj56 = obj58;
				object obj59 = NGUIText.glyph + 16;
				nint num32 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ S1_v58 (Il2CppClass<NGUIText>)+5C]");
				object obj60 = (nint)0 + (nint)168;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1156B");
				object obj61 = default;
				obj59 = obj61;
				object obj62 = NGUIText.glyph + 8;
				nint num33 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ S1_v64 (Il2CppClass<NGUIText>)+5C]");
				object obj63 = (nint)0 + (nint)168;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11567");
				object obj64 = default;
				float num34 = (float)obj64 - NGUIText.baseline;
				object obj65 = NGUIText.glyph + 16;
				nint num35 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v558 @ S1_v71 (Il2CppClass<NGUIText>)+5C]");
				object obj66 = (nint)0 + (nint)168;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11565");
				object obj67 = default;
				float num36 = (float)obj67 - NGUIText.baseline;
				NGUIText.GlyphInfo glyph6 = NGUIText.glyph;
				nint num37 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v603 @ S2_v42 (Il2CppClass<NGUIText>)+5C]");
				object obj68 = (nint)0 + (nint)168;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1157B");
				((Vector2*)(nint)vector)->x = (float)obj9;
				glyph6.u0 = (Vector2)vector.x;
				NGUIText.GlyphInfo glyph7 = NGUIText.glyph;
				nint num38 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v646 @ S2_v48 (Il2CppClass<NGUIText>)+5C]");
				object obj69 = (nint)0 + (nint)168;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11575");
				((Vector2*)(nint)vector)->x = (float)obj10;
				glyph7.u1 = (Vector2)vector.x;
				NGUIText.GlyphInfo glyph8 = NGUIText.glyph;
				nint num39 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v693 @ S2_v54 (Il2CppClass<NGUIText>)+5C]");
				object obj70 = (nint)0 + (nint)168;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11577");
				((Vector2*)(nint)vector)->x = (float)obj11;
				glyph8.u2 = (Vector2)vector.x;
				NGUIText.GlyphInfo glyph9 = NGUIText.glyph;
				nint num40 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v728 @ S2_v60 (Il2CppClass<NGUIText>)+5C]");
				object obj71 = (nint)0 + (nint)168;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11579");
				((Vector2*)(nint)vector)->x = (float)obj12;
				glyph9.u3 = (Vector2)vector.x;
				NGUIText.GlyphInfo glyph10 = NGUIText.glyph;
				ArrayTypeMismatchException ex = new ArrayTypeMismatchException();
				glyph10.advance = (float)ex;
				NGUIText.GlyphInfo glyph11 = NGUIText.glyph;
				glyph11.channel = 0;
				object obj72 = NGUIText.glyph + 8;
				object obj73 = NGUIText.glyph + 8;
				nint num41 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v800 @ S2_v69 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj74 = (nint)0 & (nint)0x200;
				if (obj74 != null)
				{
					nint num42 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v806 @ S2_v80 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72EB");
				object obj75 = default;
				obj72 = obj75;
				object obj76 = NGUIText.glyph + 8;
				object obj77 = NGUIText.glyph + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72EB");
				object obj78 = NGUIText.glyph + 16;
				object obj79 = NGUIText.glyph + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72EB");
				object obj80 = default;
				obj78 = obj80;
				object obj81 = NGUIText.glyph + 16;
				object obj82 = NGUIText.glyph + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72EB");
				float num43 = strength * NGUIText.pixelDensity;
				if (num43 != 1f)
				{
					nint num44 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v866 @ S0_v126 (Il2CppClass<NGUIText>)+BA]");
					object obj83 = (nint)0 & (nint)0x200;
					if (obj83 != null)
					{
						nint num45 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v890 @ S0_v154 (Il2CppClass<NGUIText>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					NGUIText.GlyphInfo glyph12 = NGUIText.glyph;
					obj4 = glyph12.v0;
					nint num46 = (nint)typeof(Vector2);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v905 @ S0_v132 (Il2CppClass<UnityEngine.Vector2>)+BA]");
					object obj84 = (nint)0 & (nint)0x200;
					if (obj84 != null)
					{
						nint num47 = (nint)typeof(Vector2);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v921 @ S0_v150 (Il2CppClass<UnityEngine.Vector2>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					obj13 = obj4;
					((Vector2*)(nint)vector)->x = (float)obj13;
					Vector2 vector4 = vector / num43;
					((Vector2*)(nint)vector)->x = (float)obj14;
					glyph12.v0 = (Vector2)vector.x;
					NGUIText.GlyphInfo glyph13 = NGUIText.glyph;
					obj15 = glyph13.v1;
					((Vector2*)(nint)vector)->x = (float)obj15;
					Vector2 vector5 = vector / num43;
					((Vector2*)(nint)vector)->x = (float)obj3;
					glyph13.v1 = (Vector2)vector.x;
					NGUIText.GlyphInfo glyph14 = NGUIText.glyph;
					float advance3 = glyph14.advance * num43;
					glyph14.advance = advance3;
				}
				nint num48 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v885 @ S0_v112 (Il2CppClass<NGUIText>)+BA]");
				object obj85 = (nint)0 & (nint)0x200;
				if (obj85 != null)
				{
					nint num49 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v911 @ S0_v119 (Il2CppClass<NGUIText>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				return (SpringPanel)(object)NGUIText.glyph;
			}
			return null;
		}
		return null;
	}

	public static SpringPanel Stop(GameObject go)
	{
		//IL_0186: Expected I, but got Obj
		//IL_019c: Expected Obj, but got I
		//IL_01fd: Expected Obj, but got I
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected Obj, but got Unknown
		//IL_013a: Expected Obj, but got I4
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected Obj, but got Unknown
		//IL_0151: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0062: Expected Obj, but got I
		//IL_015f: Expected Obj, but got I4
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected Obj, but got Unknown
		//IL_00de: Expected Obj, but got I
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected Obj, but got Unknown
		//IL_0112: Expected Obj, but got I
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v40 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(nint)((UnityEngine.Object)go).m_CachedPtr).FindKernel(null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [go @ L0 (UnityEngine.GameObject)+C]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [go @ L0 (UnityEngine.GameObject)+C]");
			bool flag;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v30+8]");
				flag = (nint)0 == 0;
			}
			else
			{
				flag = true;
			}
			if (!flag)
			{
				object obj3 = go + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11995");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [go @ L0 (UnityEngine.GameObject)+C]");
				Type type2 = default;
				Type type = type2.GetInterface((string)0);
				obj3 = type;
				object obj4 = go + 20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [go @ L0 (UnityEngine.GameObject)+C]");
				MemberInfo[] member = type2.GetMember((string)0);
				obj4 = member;
				goto IL_01c7;
			}
		}
		object obj5 = go + 16;
		obj5 = 0;
		object obj6 = go + 20;
		obj6 = 0;
		goto IL_01c7;
		IL_01c7:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @FF49");
		object obj7 = default;
		if (obj7 != null)
		{
			return (SpringPanel)1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @FF49");
		SpringPanel result = default;
		return result;
	}

	public unsafe SpringPanel()
	{
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Expected Obj, but got Unknown
		//IL_032b: Expected Obj, but got I4
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Expected Obj, but got Unknown
		//IL_0348: Expected Obj, but got I4
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_035c: Expected Obj, but got Unknown
		//IL_0365: Expected Obj, but got I4
		//IL_0374: Unknown result type (might be due to invalid IL or missing references)
		//IL_0379: Expected Obj, but got Unknown
		//IL_0382: Expected Obj, but got I4
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0390: Expected Obj, but got Unknown
		//IL_0399: Expected Obj, but got I4
		//IL_03b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b6: Expected Obj, but got Unknown
		//IL_03c5: Expected VT, but got Obj
		//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e5: Expected Obj, but got Unknown
		//IL_03f4: Expected VT, but got Obj
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected Obj, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected VT, but got Unknown
		//IL_004e: Expected F4, but got Obj
		//IL_0049: Expected native int or pointer, but got VT
		//IL_0060: Expected F4, but got I
		//IL_005b: Expected native int or pointer, but got VT
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected VT, but got Unknown
		//IL_007b: Expected F4, but got Obj
		//IL_0076: Expected native int or pointer, but got VT
		//IL_0090: Expected F4, but got I
		//IL_008b: Expected native int or pointer, but got VT
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected Obj, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected Obj, but got Unknown
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected Obj, but got Unknown
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected Obj, but got Unknown
		//IL_012d: Expected I, but got Obj
		//IL_0143: Expected Obj, but got I
		//IL_0406: Expected F4, but got Obj
		//IL_0401: Expected native int or pointer, but got VT
		//IL_041b: Expected F4, but got I
		//IL_0416: Expected native int or pointer, but got VT
		//IL_0428: Expected F4, but got Obj
		//IL_0423: Expected native int or pointer, but got VT
		//IL_043d: Expected F4, but got I
		//IL_0438: Expected native int or pointer, but got VT
		//IL_0446: Unknown result type (might be due to invalid IL or missing references)
		//IL_044b: Expected Obj, but got Unknown
		//IL_049b: Expected Obj, but got I
		//IL_04c5: Expected Obj, but got I
		//IL_04db: Invalid comparison between Obj and F4
		//IL_020f: Expected Obj, but got I4
		//IL_016e: Expected I, but got Obj
		//IL_0507: Expected F4, but got Obj
		//IL_0502: Expected native int or pointer, but got VT
		//IL_051c: Expected F4, but got I
		//IL_0517: Expected native int or pointer, but got VT
		//IL_0525: Expected Obj, but got VT
		//IL_0571: Expected I, but got Obj
		//IL_0587: Expected Obj, but got I
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected Obj, but got Unknown
		//IL_01c5: Expected F4, but got Obj
		//IL_01c0: Expected native int or pointer, but got VT
		//IL_01da: Expected F4, but got I
		//IL_01d5: Expected native int or pointer, but got VT
		//IL_01e7: Expected Obj, but got F4
		//IL_0201: Expected Obj, but got I4
		//IL_05b1: Expected F4, but got Obj
		//IL_05ac: Expected native int or pointer, but got VT
		//IL_05c3: Expected F4, but got I
		//IL_05be: Expected native int or pointer, but got VT
		//IL_05d0: Expected F4, but got Obj
		//IL_05cb: Expected native int or pointer, but got VT
		//IL_05e2: Expected F4, but got I
		//IL_05dd: Expected native int or pointer, but got VT
		//IL_061f: Expected Obj, but got VT
		//IL_062c: Expected F4, but got Obj
		//IL_0627: Expected native int or pointer, but got VT
		//IL_0641: Expected F4, but got I
		//IL_063c: Expected native int or pointer, but got VT
		//IL_065d: Expected Obj, but got F4
		//IL_0666: Unknown result type (might be due to invalid IL or missing references)
		//IL_066b: Expected Obj, but got Unknown
		//IL_0690: Unknown result type (might be due to invalid IL or missing references)
		//IL_0695: Expected Obj, but got Unknown
		//IL_06b2: Expected F4, but got Obj
		//IL_06ad: Expected native int or pointer, but got VT
		//IL_06c1: Expected Obj, but got VT
		//IL_06cf: Expected I, but got Obj
		//IL_06e5: Expected Obj, but got I
		//IL_0222: Expected I, but got Obj
		//IL_026f: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 136;
		obj = 0;
		_ = 0;
		object obj3 = obj2 + 124;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 112;
		obj4 = 0;
		_ = 0;
		object obj5 = obj2 + 8;
		obj5 = 0;
		object obj6 = obj2 + 100;
		obj6 = 0;
		_ = 0;
		float fixedDeltaTime = Time.fixedDeltaTime;
		Transform transform = (Transform)(obj2 + 88);
		transform.localPosition = (Vector3)mTrans;
		obj = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		Transform transform2 = (Transform)(obj2 + 76);
		transform2.localPosition = (Vector3)mTrans;
		object obj7 = obj2 - -64;
		object obj8 = this + 12;
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S1_v29+8]");
		_ = 0;
		Quaternion quaternion = (Quaternion)(obj2 + 148);
		((Quaternion*)(nint)quaternion)->x = (float)transform2;
		((Quaternion*)(nint)quaternion)->z = (nint)((UnityEngine.Object)transform2).m_CachedPtr;
		Quaternion quaternion2 = (Quaternion)(obj2 + 160);
		((Quaternion*)(nint)quaternion2)->x = (float)obj7;
		Quaternion quaternion3 = quaternion2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v31+8]");
		((Quaternion*)(nint)quaternion3)->z = 0f;
		object obj9 = obj2 + 52;
		Quaternion quaternion4 = NGUIMath.SpringLerp(quaternion, quaternion2, strength, fixedDeltaTime);
		obj3 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v42+8]");
		_ = 0;
		object obj10 = obj2 + 40;
		obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v42+8]");
		_ = 0;
		object obj11 = obj2 + 28;
		object obj12 = this + 12;
		obj11 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S1_v56+8]");
		_ = 0;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S0_v52 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S0_v90 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Quaternion*)(nint)quaternion)->x = (float)obj10;
		Quaternion quaternion5 = quaternion;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S0_v46+8]");
		((Quaternion*)(nint)quaternion5)->z = 0f;
		((Quaternion*)(nint)quaternion2)->x = (float)obj11;
		Quaternion quaternion6 = quaternion2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v49+8]");
		((Quaternion*)(nint)quaternion6)->z = 0f;
		object obj14 = obj2 + 16;
		Quaternion quaternion7 = Quaternion.FromToRotation((Vector3)quaternion, (Vector3)quaternion2);
		obj6 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ S0_v61+8]");
		_ = 0;
		object obj15 = obj6 * obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v20+4]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v20+4]");
		object obj16 = num3 * 0;
		object obj17 = obj15 + obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v20+8]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v20+8]");
		object obj18 = num4 * 0;
		object obj19 = obj17 + obj18;
		object obj21;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj19) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0.01f))
		{
			object obj20 = this + 12;
			((Quaternion*)(nint)quaternion2)->x = (float)obj20;
			Quaternion quaternion8 = quaternion2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ S1_v131+8]");
			((Quaternion*)(nint)quaternion8)->z = 0f;
			obj3 = quaternion2.x;
			_ = quaternion2.z;
			tag = null;
			obj21 = 1;
		}
		else
		{
			obj21 = 0;
		}
		((Quaternion*)(nint)quaternion2)->x = (float)obj3;
		Quaternion quaternion9 = quaternion2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		((Quaternion*)(nint)quaternion9)->z = 0f;
		Vector3 eulerAngles = ((Transform)quaternion2).eulerAngles;
		transform = (Transform)obj3;
		Transform transform3 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
		transform2 = (Transform)obj;
		Transform transform4 = transform2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
		nint num5 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ S1_v92 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj22 = (nint)0 & (nint)0x200;
		if (obj22 != null)
		{
			nint num6 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ S1_v126 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Quaternion*)(nint)quaternion)->x = (float)transform;
		((Quaternion*)(nint)quaternion)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
		((Quaternion*)(nint)quaternion2)->x = (float)transform2;
		((Quaternion*)(nint)quaternion2)->z = (nint)((UnityEngine.Object)transform2).m_CachedPtr;
		Quaternion quaternion10 = Quaternion.FromToRotation((Vector3)quaternion, (Vector3)quaternion2);
		obj4 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v31+8]");
		_ = 0;
		UIPanel uIPanel = mPanel;
		obj5 = uIPanel.mClipOffset;
		((Quaternion*)(nint)quaternion)->x = (float)obj4;
		Quaternion quaternion11 = quaternion;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
		((Quaternion*)(nint)quaternion11)->z = 0f;
		float num7 = (float)obj5 - quaternion.x;
		obj5 = num7;
		object obj23 = obj5 + 4;
		obj9 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
		_ = 0;
		object obj24 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v42+4]");
		object obj25 = obj24 - 0;
		obj23 = obj25;
		obj2 = obj5;
		((Quaternion*)(nint)quaternion2)->x = (float)obj2;
		mPanel.clipTexture = (Texture2D)quaternion2;
		nint num8 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ S2_v57 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj26 = (nint)0 & (nint)0x200;
		if (obj26 != null)
		{
			nint num9 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ S2_v65 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)mDrag).FindKernel((string)null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		}
		if (obj21 != null && onFinished != null)
		{
			current = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
			current = null;
		}
	}
}
