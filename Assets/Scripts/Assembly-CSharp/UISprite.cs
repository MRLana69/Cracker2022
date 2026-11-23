using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

public class UISprite : UIBasicSprite
{
	private UIAtlas mAtlas;

	private string mSpriteName;

	private bool mFillCenter = true;

	[NonSerialized]
	protected UISpriteData mSprite;

	[NonSerialized]
	private bool mSpriteSet;

	public override Material material
	{
		get
		{
			if (mAtlas != null)
			{
				return mAtlas.spriteMaterial;
			}
			return null;
		}
	}

	public UIAtlas atlas
	{
		get
		{
			return mAtlas;
		}
		set
		{
			//IL_0075: Expected Obj, but got I4
			//IL_0059: Expected Obj, but got I4
			//IL_014c: Expected Obj, but got I4
			//IL_0130: Expected Obj, but got I4
			//IL_016d: Expected I, but got Obj
			//IL_0173: Unknown result type (might be due to invalid IL or missing references)
			//IL_0178: Expected Obj, but got Unknown
			if (!(mAtlas != value))
			{
				return;
			}
			RemoveFromPanel();
			mAtlas = value;
			mSprite = null;
			mSpriteSet = false;
			string text = mSpriteName;
			object obj;
			if (mSpriteName != null)
			{
				obj = 0;
				if (text._stringLength != 0)
				{
					goto IL_01b4;
				}
			}
			obj = 1;
			goto IL_01b4;
			IL_01b4:
			if (obj != null && mAtlas != null)
			{
				List<UISpriteData> spriteList = mAtlas.spriteList;
				if (spriteList._size >= 1)
				{
					List<UISpriteData> spriteList2 = mAtlas.spriteList;
					UISpriteData atlasSprite = spriteList2.get_Item(0);
					SetAtlasSprite(atlasSprite);
					UISpriteData uISpriteData = mSprite;
					mSpriteName = uISpriteData.name;
				}
			}
			string text2 = mSpriteName;
			object obj2;
			if (mSpriteName != null)
			{
				obj2 = 0;
				if (text2._stringLength != 0)
				{
					goto IL_01fa;
				}
			}
			obj2 = 1;
			goto IL_01fa;
			IL_01fa:
			if (obj2 == null)
			{
				mSpriteName = string.Empty;
				spriteName = mSpriteName;
				nint num = (nint)this;
				object obj3 = this + 272;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v115 @ S1_v17 (Il2CppClass<UISprite>)+1CC] (should have been resolved before IL gen)");
			}
		}
	}

	public string spriteName
	{
		get
		{
			return mSpriteName;
		}
		set
		{
			//IL_002a: Expected Obj, but got I4
			//IL_000e: Expected Obj, but got I4
			//IL_0073: Expected Obj, but got I4
			//IL_0057: Expected Obj, but got I4
			string text = mSpriteName;
			string text2 = default;
			object obj;
			if (text2 != null)
			{
				obj = 0;
				if (text2._stringLength != 0)
				{
					goto IL_00fd;
				}
			}
			obj = 1;
			goto IL_00fd;
			IL_00a9:
			mSpriteName = string.Empty;
			mSprite = null;
			mSpriteSet = false;
			mChanged = true;
			return;
			IL_011a:
			object obj2;
			if (obj2 == null)
			{
				goto IL_00a9;
			}
			return;
			IL_00fd:
			if (obj != null)
			{
				if (mSpriteName != null)
				{
					obj2 = 0;
					if (text._stringLength != 0)
					{
						goto IL_011a;
					}
				}
				obj2 = 1;
				goto IL_011a;
			}
			if (mSpriteName != text2)
			{
				goto IL_00a9;
			}
		}
	}

	public bool isValid
	{
		get
		{
			UISpriteData atlasSprite = GetAtlasSprite();
			return atlasSprite != null;
		}
	}

	public bool fillCenter
	{
		get
		{
			return centerType != AdvancedType.Invisible;
		}
		set
		{
			//IL_004d: Expected I, but got Obj
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Expected Obj, but got Unknown
			bool flag = centerType != AdvancedType.Invisible;
			if (value != flag)
			{
				centerType = (value ? AdvancedType.Sliced : AdvancedType.Invisible);
				nint num = (nint)this;
				object obj = this + 272;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v13 @ S1_v7 (Il2CppClass<UISprite>)+1CC] (should have been resolved before IL gen)");
			}
		}
	}

	public unsafe override Vector4 border
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0083: Expected F4, but got I4
			//IL_007e: Expected native int or pointer, but got VT
			//IL_0095: Expected F4, but got I4
			//IL_0090: Expected native int or pointer, but got VT
			//IL_00a7: Expected F4, but got I4
			//IL_00a2: Expected native int or pointer, but got VT
			//IL_00b9: Expected F4, but got I4
			//IL_00b4: Expected native int or pointer, but got VT
			//IL_005f: Expected F4, but got I
			//IL_005a: Expected native int or pointer, but got VT
			//IL_006c: Expected F4, but got Obj
			//IL_0067: Expected native int or pointer, but got VT
			object obj2 = default;
			object obj = obj2 - 16;
			UISpriteData atlasSprite = GetAtlasSprite();
			Vector4 vector2 = default;
			if (atlasSprite == null)
			{
				Vector4 vector = base.border;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				((Vector4*)(nint)vector2)->z = 0f;
				((Vector4*)(nint)vector2)->x = (float)obj;
			}
			else
			{
				((Vector4*)(nint)vector2)->w = atlasSprite.borderTop;
				((Vector4*)(nint)vector2)->z = atlasSprite.borderRight;
				((Vector4*)(nint)vector2)->y = atlasSprite.borderBottom;
				((Vector4*)(nint)vector2)->x = atlasSprite.borderLeft;
			}
			return vector2;
		}
	}

	public override float pixelSize
	{
		get
		{
			if (mAtlas != null)
			{
				return mAtlas.pixelSize;
			}
			return 1f;
		}
	}

	public override int minWidth
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0013: Expected I, but got Obj
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Expected Obj, but got Unknown
			//IL_0092: Expected I, but got Obj
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected Obj, but got Unknown
			//IL_00ac: Expected I, but got Obj
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b7: Expected Obj, but got Unknown
			//IL_00c6: Expected I, but got Obj
			//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d1: Expected Obj, but got Unknown
			//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fd: Expected Obj, but got Unknown
			//IL_0058: Expected I, but got Obj
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Expected Obj, but got Unknown
			//IL_0149: Expected F8, but got I4
			//IL_0252: Unknown result type (might be due to invalid IL or missing references)
			//IL_0257: Expected Obj, but got Unknown
			//IL_02a5: Invalid comparison between I4 and F8
			//IL_0165: Expected Obj, but got I4
			//IL_01cb: Expected I4, but got F8
			//IL_01b1: Expected F8, but got I4
			object obj2 = default;
			object obj = obj2 - 16;
			nint num = (nint)this;
			object obj3 = this + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v9 @ S1_v3 (Il2CppClass<UISprite>)+1F4] (should have been resolved before IL gen)");
			object obj4 = default;
			int num3;
			if ((nint)obj4 != 1)
			{
				nint num2 = (nint)this;
				object obj5 = this + 312;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v22 @ S1_v37 (Il2CppClass<UISprite>)+1F4] (should have been resolved before IL gen)");
				object obj6 = default;
				if ((nint)obj6 != 4)
				{
					num3 = base.minWidth;
					goto IL_01df;
				}
			}
			nint num4 = (nint)this;
			object obj7 = this + 336;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v38 @ S1_v11 (Il2CppClass<UISprite>)+20C] (should have been resolved before IL gen)");
			nint num5 = (nint)this;
			object obj8 = this + 256;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v50 @ S2_v10 (Il2CppClass<UISprite>)+1BC] (should have been resolved before IL gen)");
			nint num6 = (nint)this;
			object obj9 = this + 336;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v69 @ S2_v14 (Il2CppClass<UISprite>)+20C] (should have been resolved before IL gen)");
			object obj11 = default;
			object obj10 = obj * obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			object obj12 = 0 * obj11;
			object obj13 = obj10 + obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
			double num8 = default;
			double num7 = Math.Abs(num8);
			if (!(num7 < 2147483648.0))
			{
				num8 = -2147483648.0;
			}
			UISpriteData atlasSprite = GetAtlasSprite();
			bool flag = atlasSprite == null;
			double num9 = num8;
			if (!flag)
			{
				object obj14 = atlasSprite.paddingLeft + atlasSprite.paddingRight;
				object obj16 = default;
				object obj15 = obj16 * obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
				double num11 = default;
				double num10 = Math.Abs(num11);
				if (!(num10 < 2147483648.0))
				{
					num11 = -2147483648.0;
				}
				double num12 = num11 + num8;
				num9 = num12;
			}
			num3 = base.minWidth;
			double num13 = num9 + 1.0;
			object obj17 = num9 & 1;
			if (obj17 == null)
			{
				num13 = num9;
			}
			if (!((double)num3 > num13))
			{
				num3 = (int)num13;
			}
			goto IL_01df;
			IL_01df:
			return num3;
		}
	}

	public override int minHeight
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0013: Expected I, but got Obj
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Expected Obj, but got Unknown
			//IL_0092: Expected I, but got Obj
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected Obj, but got Unknown
			//IL_00ac: Expected I, but got Obj
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b7: Expected Obj, but got Unknown
			//IL_00c6: Expected I, but got Obj
			//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d1: Expected Obj, but got Unknown
			//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f0: Expected Obj, but got Unknown
			//IL_0100: Unknown result type (might be due to invalid IL or missing references)
			//IL_0105: Expected Obj, but got Unknown
			//IL_0058: Expected I, but got Obj
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Expected Obj, but got Unknown
			//IL_0151: Expected F8, but got I4
			//IL_025a: Unknown result type (might be due to invalid IL or missing references)
			//IL_025f: Expected Obj, but got Unknown
			//IL_02ad: Invalid comparison between I4 and F8
			//IL_016d: Expected Obj, but got I4
			//IL_01d3: Expected I4, but got F8
			//IL_01b9: Expected F8, but got I4
			object obj2 = default;
			object obj = obj2 - 16;
			nint num = (nint)this;
			object obj3 = this + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v9 @ S1_v3 (Il2CppClass<UISprite>)+1F4] (should have been resolved before IL gen)");
			object obj4 = default;
			int num3;
			if ((nint)obj4 != 1)
			{
				nint num2 = (nint)this;
				object obj5 = this + 312;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v22 @ S1_v38 (Il2CppClass<UISprite>)+1F4] (should have been resolved before IL gen)");
				object obj6 = default;
				if ((nint)obj6 != 4)
				{
					num3 = base.minHeight;
					goto IL_01e7;
				}
			}
			nint num4 = (nint)this;
			object obj7 = this + 336;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v38 @ S1_v11 (Il2CppClass<UISprite>)+20C] (should have been resolved before IL gen)");
			nint num5 = (nint)this;
			object obj8 = this + 256;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v50 @ S2_v10 (Il2CppClass<UISprite>)+1BC] (should have been resolved before IL gen)");
			nint num6 = (nint)this;
			object obj9 = this + 336;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v70 @ S2_v14 (Il2CppClass<UISprite>)+20C] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
			object obj11 = default;
			object obj10 = 0 * obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			object obj12 = 0 * obj11;
			object obj13 = obj10 + obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
			double num8 = default;
			double num7 = Math.Abs(num8);
			if (!(num7 < 2147483648.0))
			{
				num8 = -2147483648.0;
			}
			UISpriteData atlasSprite = GetAtlasSprite();
			bool flag = atlasSprite == null;
			double num9 = num8;
			if (!flag)
			{
				object obj14 = atlasSprite.paddingTop + atlasSprite.paddingBottom;
				object obj16 = default;
				object obj15 = obj16 * obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
				double num11 = default;
				double num10 = Math.Abs(num11);
				if (!(num10 < 2147483648.0))
				{
					num11 = -2147483648.0;
				}
				double num12 = num11 + num8;
				num9 = num12;
			}
			num3 = base.minHeight;
			double num13 = num9 + 1.0;
			object obj17 = num9 & 1;
			if (obj17 == null)
			{
				num13 = num9;
			}
			if (!((double)num3 > num13))
			{
				num3 = (int)num13;
			}
			goto IL_01e7;
			IL_01e7:
			return num3;
		}
	}

	public unsafe override Vector4 drawingDimensions
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0845: Expected I, but got Obj
			//IL_0865: Expected Obj, but got I
			//IL_0875: Expected Obj, but got I
			//IL_088e: Expected Obj, but got I
			//IL_03e3: Expected I, but got Obj
			//IL_03e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ee: Expected Obj, but got Unknown
			//IL_03fd: Expected I, but got Obj
			//IL_0403: Unknown result type (might be due to invalid IL or missing references)
			//IL_0408: Expected Obj, but got Unknown
			//IL_041f: Expected VT, but got Obj
			//IL_042f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0434: Expected Obj, but got Unknown
			//IL_0444: Unknown result type (might be due to invalid IL or missing references)
			//IL_0449: Expected Obj, but got Unknown
			//IL_0459: Unknown result type (might be due to invalid IL or missing references)
			//IL_045e: Expected Obj, but got Unknown
			//IL_0805: Expected F4, but got I
			//IL_081a: Invalid comparison between I and F4
			//IL_007a: Expected F8, but got I4
			//IL_0087: Expected F8, but got I4
			//IL_0094: Expected F8, but got I4
			//IL_00a1: Expected F8, but got I4
			//IL_08b9: Expected native int or pointer, but got VT
			//IL_08c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_08cb: Expected Obj, but got Unknown
			//IL_08ff: Expected F4, but got I
			//IL_0914: Invalid comparison between I and F4
			//IL_0605: Invalid comparison between F8 and I4
			//IL_0957: Expected native int or pointer, but got VT
			//IL_0990: Expected F4, but got I
			//IL_09a5: Invalid comparison between I and F4
			//IL_00b4: Expected I, but got Obj
			//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bf: Expected Obj, but got Unknown
			//IL_00d2: Invalid comparison between Obj and F4
			//IL_00e5: Expected F8, but got I4
			//IL_00f2: Expected F8, but got I4
			//IL_00ff: Expected F8, but got I4
			//IL_010c: Expected F8, but got I4
			//IL_09e8: Expected native int or pointer, but got VT
			//IL_0a1b: Expected F4, but got VT
			//IL_0a2a: Invalid comparison between VT and F4
			//IL_06b5: Expected Obj, but got I4
			//IL_0238: Invalid comparison between F8 and I4
			//IL_0a6d: Expected native int or pointer, but got VT
			//IL_075c: Expected Obj, but got I4
			//IL_031c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0321: Expected Obj, but got Unknown
			//IL_06fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0702: Expected Obj, but got Unknown
			//IL_016d: Expected F8, but got I4
			//IL_01ac: Expected F8, but got I4
			//IL_01eb: Expected F8, but got I4
			//IL_022a: Expected F8, but got I4
			object obj2 = default;
			object obj = obj2 - 16;
			Vector2 vector = pivotOffset;
			float num = 0f - (float)obj;
			float num2 = num * (float)mWidth;
			float num3 = num2 + (float)mWidth;
			float num4 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
			float num5 = num4 - 0f;
			float num6 = num5 * (float)mHeight;
			float num7 = num6 + (float)mHeight;
			UISpriteData atlasSprite = GetAtlasSprite();
			bool flag = atlasSprite == null;
			float num8 = num7;
			float num9 = num6;
			float num10 = num3;
			float num11 = num2;
			double num12;
			double num13;
			double num14;
			double num15;
			double num30;
			double num32;
			float num33;
			float num34;
			if (!flag)
			{
				bool flag2 = mType == Type.Tiled;
				num8 = num7;
				num9 = num6;
				num10 = num3;
				num11 = num2;
				if (!flag2)
				{
					UISpriteData uISpriteData = mSprite;
					bool flag3 = mType == Type.Simple;
					num12 = uISpriteData.paddingBottom;
					num13 = uISpriteData.paddingRight;
					num14 = uISpriteData.paddingTop;
					num15 = uISpriteData.paddingLeft;
					if (!flag3)
					{
						nint num16 = (nint)this;
						object obj3 = this + 336;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v129 @ S1_v73 (Il2CppClass<UISprite>)+20C] (should have been resolved before IL gen)");
						object obj4 = default;
						bool flag4 = obj4 == (object)1f;
						num12 = uISpriteData.paddingBottom;
						num13 = uISpriteData.paddingRight;
						num14 = uISpriteData.paddingTop;
						num15 = uISpriteData.paddingLeft;
						if (!flag4)
						{
							double num17 = (double)obj4 * (double)uISpriteData.paddingLeft;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
							double num19 = default;
							double num18 = Math.Abs(num19);
							if (!(num18 < 2147483648.0))
							{
								num19 = -2147483648.0;
							}
							double num20 = (double)obj4 * (double)uISpriteData.paddingBottom;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
							double num22 = default;
							double num21 = Math.Abs(num22);
							if (!(num21 < 2147483648.0))
							{
								num22 = -2147483648.0;
							}
							double num23 = (double)obj4 * (double)uISpriteData.paddingRight;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
							double num25 = default;
							double num24 = Math.Abs(num25);
							if (!(num24 < 2147483648.0))
							{
								num25 = -2147483648.0;
							}
							double num26 = (double)obj4 * (double)uISpriteData.paddingTop;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
							double num28 = default;
							double num27 = Math.Abs(num28);
							if (!(num27 < 2147483648.0))
							{
								num28 = -2147483648.0;
							}
							num12 = num22;
							num13 = num25;
							num14 = num28;
							num15 = num19;
						}
					}
					UISpriteData uISpriteData2 = mSprite;
					double num29 = num12 + (double)uISpriteData2.height;
					num30 = num14 + num29;
					UISpriteData uISpriteData3 = mSprite;
					double num31 = num15 + (double)uISpriteData3.width;
					num32 = num13 + num31;
					if (!(num32 < 1.0) && !(num30 < 1.0))
					{
						if (mType == Type.Simple)
						{
							goto IL_0303;
						}
						bool flag5 = mType == Type.Sliced;
						num33 = 1f;
						num34 = 1f;
						if (!flag5)
						{
							bool flag6 = mType == Type.Tiled;
							num33 = 1f;
							num34 = 1f;
							if (!flag6)
							{
								if (mType == Type.Filled)
								{
									goto IL_0303;
								}
								num33 = 1f;
								num34 = 1f;
							}
						}
					}
					else
					{
						num33 = 1f;
						num34 = 1f;
					}
					goto IL_06a5;
				}
			}
			goto IL_0579;
			IL_06a5:
			object obj5 = mFlip - 1;
			bool flag7 = mFlip == Flip.Horizontally;
			double num35 = num15;
			double num36 = num13;
			if (!flag7)
			{
				if ((nint)obj5 != 1)
				{
					bool flag8 = (nint)obj5 == 2;
					num35 = num15;
					num36 = num13;
					if (flag8)
					{
						goto IL_0710;
					}
				}
				num35 = num13;
				num36 = num15;
			}
			goto IL_0710;
			IL_0579:
			object obj12;
			object obj13;
			Vector4 vector3;
			object obj14;
			if (mAtlas != null)
			{
				nint num37 = (nint)this;
				object obj6 = this + 256;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v198 @ S2_v24 (Il2CppClass<UISprite>)+1BC] (should have been resolved before IL gen)");
				nint num38 = (nint)this;
				object obj7 = this + 336;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v219 @ S2_v28 (Il2CppClass<UISprite>)+20C] (should have been resolved before IL gen)");
				object obj8 = default;
				Vector4 vector2 = (Vector4)(obj * obj8);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
				object obj9 = 0 * obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				object obj10 = 0 * obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
				object obj11 = 0 * obj8;
				obj12 = obj11;
				obj13 = obj10;
				vector3 = vector2;
				obj14 = obj9;
			}
			else
			{
				nint num39 = (nint)typeof(Vector4);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ S0_v44 (Il2CppClass<UnityEngine.Vector4>)+5C]");
				nint num40 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ S0_v45 (Il2CppStaticFields<UnityEngine.Vector4>)+C]");
				obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ S0_v45 (Il2CppStaticFields<UnityEngine.Vector4>)+8]");
				obj13 = 0;
				vector3 = Vector4.zeroVector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ S0_v45 (Il2CppStaticFields<UnityEngine.Vector4>)+4]");
				obj14 = 0;
			}
			object obj15 = obj14 + obj12;
			float num41 = num9 + (float)obj15;
			float num42 = num8 - num41;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (UISprite)+A0]");
			float num43 = Math.Min(0f, 1f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (UISprite)+A0]");
			bool flag9 = 0f < 0f;
			float num44 = 0f;
			if (!flag9)
			{
				num44 = num43;
			}
			float num45 = num42 * num44;
			float w = num41 + num45;
			Vector4 vector4 = default;
			((Vector4*)(nint)vector4)->w = w;
			object obj16 = vector3 + obj13;
			float num46 = num11 + (float)obj16;
			float num47 = num10 - num46;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (UISprite)+9C]");
			float num48 = Math.Min(0f, 1f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (UISprite)+9C]");
			bool flag10 = 0f < 0f;
			float num49 = 0f;
			if (!flag10)
			{
				num49 = num48;
			}
			float num50 = num47 * num49;
			float z = num46 + num50;
			((Vector4*)(nint)vector4)->z = z;
			float num51 = num8 - (float)obj15;
			float num52 = num51 - num9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (UISprite)+98]");
			float num53 = Math.Min(0f, 1f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (UISprite)+98]");
			bool flag11 = 0f < 0f;
			float num54 = 0f;
			if (!flag11)
			{
				num54 = num53;
			}
			float num55 = num52 * num54;
			float y = num9 + num55;
			((Vector4*)(nint)vector4)->y = y;
			float num56 = num10 - (float)obj16;
			float num57 = num56 - num11;
			float num58 = Math.Min((float)mDrawRegion, 1f);
			bool flag12 = mDrawRegion < (object)0f;
			float num59 = 0f;
			if (!flag12)
			{
				num59 = num58;
			}
			float num60 = num57 * num59;
			float x = num11 + num60;
			((Vector4*)(nint)vector4)->x = x;
			return vector4;
			IL_0303:
			double num61 = num13 + 1.0;
			object obj17 = num32 & 1;
			if (obj17 == null)
			{
				num61 = num13;
			}
			double num62 = num14 + 1.0;
			object obj18 = num30 & 1;
			if (obj18 == null)
			{
				num62 = num14;
			}
			float num63 = 1f / (float)num32;
			float num64 = num63 * (float)mWidth;
			float num65 = 1f / (float)num30;
			float num66 = num65 * (float)mHeight;
			num33 = num66;
			num34 = num64;
			num13 = num61;
			num14 = num62;
			goto IL_06a5;
			IL_0710:
			float num67 = (float)num36 * num34;
			float num68 = num2 + num67;
			float num69 = (float)num35 * num34;
			float num70 = num3 - num69;
			object obj19 = mFlip & (Flip)(-2);
			bool flag13 = (nint)obj19 == 2;
			double num71 = num14;
			if (!flag13)
			{
				num71 = num12;
			}
			float num72 = (float)num71 * num33;
			float num73 = num6 + num72;
			double num74 = num12;
			if (!flag13)
			{
				num74 = num14;
			}
			float num75 = (float)num74 * num33;
			float num76 = num7 - num75;
			num8 = num76;
			num9 = num73;
			num10 = num70;
			num11 = num68;
			goto IL_0579;
		}
	}

	public override bool premultipliedAlpha
	{
		get
		{
			if (mAtlas != null)
			{
				return mAtlas.premultipliedAlpha;
			}
			return false;
		}
	}

	public UISpriteData GetAtlasSprite()
	{
		//IL_008d: Expected Obj, but got I4
		//IL_0071: Expected Obj, but got I4
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Expected Obj, but got Unknown
		if (~(mSpriteSet ? 1u : 0u) != 0)
		{
			mSprite = null;
		}
		if (mSprite != null || !(mAtlas != null))
		{
			goto IL_0208;
		}
		string text = mSpriteName;
		object obj;
		if (mSpriteName != null)
		{
			obj = 0;
			if (text._stringLength != 0)
			{
				goto IL_0217;
			}
		}
		obj = 1;
		goto IL_0217;
		IL_023f:
		UISpriteData result;
		return result;
		IL_0217:
		if (obj == null)
		{
			UISpriteData sprite = mAtlas.GetSprite(mSpriteName);
			bool flag = sprite == null;
			result = null;
			if (flag)
			{
				goto IL_023f;
			}
			SetAtlasSprite(sprite);
		}
		if (mSprite == null)
		{
			List<UISpriteData> spriteList = mAtlas.spriteList;
			if (spriteList._size >= 1)
			{
				List<UISpriteData> spriteList2 = mAtlas.spriteList;
				UISpriteData uISpriteData = spriteList2.get_Item(0);
				bool flag2 = uISpriteData == null;
				result = null;
				if (flag2)
				{
					goto IL_023f;
				}
				SetAtlasSprite(uISpriteData);
				UISpriteData uISpriteData2 = mSprite;
				if (mSprite == null)
				{
					string text2 = mAtlas.name;
					string text3 = text2 + " seems to have a null sprite!";
					return null;
				}
				object obj2 = this + 356;
				obj2 = uISpriteData2.name;
			}
		}
		goto IL_0208;
		IL_0208:
		result = mSprite;
		goto IL_023f;
	}

	protected void SetAtlasSprite(UISpriteData sp)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected Obj, but got Unknown
		mSpriteSet = true;
		mChanged = true;
		object obj = this + 364;
		if (sp != null)
		{
			mSprite = sp;
			UISpriteData uISpriteData = mSprite;
			mSpriteName = uISpriteData.name;
			return;
		}
		if (obj != null)
		{
		}
		mSpriteName = string.Empty;
		mSprite = null;
	}

	public override void MakePixelPerfect()
	{
		//IL_0056: Expected I, but got Obj
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_0187: Expected I, but got Obj
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected Obj, but got Unknown
		//IL_01b3: Expected Obj, but got I4
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected Obj, but got Unknown
		//IL_0211: Expected F8, but got I4
		//IL_02b4: Expected I, but got Obj
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Expected Obj, but got Unknown
		//IL_02e0: Expected Obj, but got I4
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Expected Obj, but got Unknown
		//IL_0250: Expected F8, but got I4
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Expected Obj, but got Unknown
		//IL_032a: Expected I4, but got F8
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Expected Obj, but got Unknown
		//IL_0393: Expected I4, but got F8
		//IL_025d: Expected I4, but got F8
		//IL_026a: Expected I4, but got F8
		if (!isValid)
		{
			return;
		}
		base.MakePixelPerfect();
		if (mType == Type.Tiled)
		{
			return;
		}
		UISpriteData atlasSprite = GetAtlasSprite();
		if (atlasSprite == null)
		{
			return;
		}
		nint num = (nint)this;
		object obj = this + 208;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v72 @ S1_v8 (Il2CppClass<UISprite>)+18C] (should have been resolved before IL gen)");
		UnityEngine.Object obj2 = default;
		if (!(obj2 != null))
		{
			return;
		}
		if (mType != Type.Simple && (mType == Type.Sliced || mType == Type.Tiled || mType != Type.Filled))
		{
			int num2 = atlasSprite.borderRight | atlasSprite.borderLeft;
			int num3 = atlasSprite.borderTop | num2;
			if ((atlasSprite.borderBottom | num3) != 0)
			{
				return;
			}
		}
		if (obj2 != null)
		{
			nint num4 = (nint)this;
			object obj3 = this + 336;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v105 @ S1_v15 (Il2CppClass<UISprite>)+20C] (should have been resolved before IL gen)");
			object obj4 = atlasSprite.width + atlasSprite.paddingLeft;
			object obj5 = atlasSprite.paddingRight + obj4;
			object obj7 = default;
			object obj6 = obj7 * obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
			double num6 = default;
			double num5 = Math.Abs(num6);
			if (!(num5 < 2147483648.0))
			{
				num6 = -2147483648.0;
			}
			nint num7 = (nint)this;
			object obj8 = this + 336;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v146 @ S1_v24 (Il2CppClass<UISprite>)+20C] (should have been resolved before IL gen)");
			object obj9 = atlasSprite.height + atlasSprite.paddingTop;
			object obj10 = atlasSprite.paddingBottom + obj9;
			object obj12 = default;
			object obj11 = obj12 * obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
			double num9 = default;
			double num8 = Math.Abs(num9);
			if (!(num8 < 2147483648.0))
			{
				num9 = -2147483648.0;
			}
			double num10 = num6 + 1.0;
			object obj13 = num6 & 1;
			int num11 = (int)num10;
			if (obj13 == null)
			{
				num11 = (int)num6;
			}
			width = num11;
			double num12 = num9 + 1.0;
			object obj14 = num9 & 1;
			int num13 = (int)num12;
			if (obj14 == null)
			{
				num13 = (int)num9;
			}
			height = num13;
		}
	}

	protected override void OnInit()
	{
		if (~(mFillCenter ? 1u : 0u) != 0)
		{
			centerType = AdvancedType.Invisible;
			mFillCenter = true;
		}
		base.OnInit();
	}

	protected override void OnUpdate()
	{
		base.OnUpdate();
		if (~(mChanged ? 1u : 0u) == 0 || !mSpriteSet)
		{
			mSprite = null;
			mSpriteSet = true;
			mChanged = true;
		}
	}

	public unsafe override void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_037d: Expected I, but got Obj
		//IL_0383: Unknown result type (might be due to invalid IL or missing references)
		//IL_0388: Expected Obj, but got Unknown
		//IL_00d8: Expected Obj, but got I4
		//IL_00ef: Expected Obj, but got I4
		//IL_0106: Expected Obj, but got I4
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected Obj, but got Unknown
		//IL_012f: Expected Obj, but got I4
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected Obj, but got Unknown
		//IL_0177: Expected I, but got Obj
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected Obj, but got Unknown
		//IL_0197: Expected I, but got Obj
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Expected Obj, but got Unknown
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected VT, but got Unknown
		//IL_0228: Expected I, but got Obj
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Expected Obj, but got Unknown
		//IL_0248: Expected I, but got Obj
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Expected Obj, but got Unknown
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Expected VT, but got Unknown
		//IL_02de: Expected F4, but got I
		//IL_02d9: Expected native int or pointer, but got VT
		//IL_0300: Expected F4, but got I
		//IL_02fb: Expected native int or pointer, but got VT
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Expected VT, but got Unknown
		object obj = default;
		Rect rect = (Rect)(obj - 144);
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		nint num = (nint)this;
		object obj2 = this + 208;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v26 @ S1_v8 (Il2CppClass<UISprite>)+18C] (should have been resolved before IL gen)");
		UnityEngine.Object obj3 = default;
		if (!(obj3 != null))
		{
			return;
		}
		bool flag = mSprite == null;
		bool flag2 = !flag;
		UISpriteData uISpriteData = mSprite;
		if (!flag2)
		{
			UISpriteData sprite = mAtlas.GetSprite(mSpriteName);
			mSprite = sprite;
			bool flag3 = mSprite == null;
			uISpriteData = mSprite;
			if (flag3)
			{
				return;
			}
		}
		_ = uISpriteData.height;
		_ = uISpriteData.width;
		_ = uISpriteData.y;
		_ = uISpriteData.x;
		UISpriteData uISpriteData2 = mSprite;
		object obj4 = uISpriteData2.borderLeft + uISpriteData2.x;
		object obj5 = uISpriteData2.borderTop + uISpriteData2.y;
		object obj6 = uISpriteData2.width - uISpriteData2.borderLeft;
		object obj7 = obj6 - uISpriteData2.borderRight;
		object obj8 = uISpriteData2.height - uISpriteData2.borderBottom;
		object obj9 = obj8 - uISpriteData2.borderTop;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+88]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+80]");
		_ = 0;
		nint num2 = (nint)obj3;
		object obj10 = obj3 + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v187 @ S1_v39 (Il2CppClass<UnityEngine.Object>)+DC] (should have been resolved before IL gen)");
		nint num3 = (nint)obj3;
		object obj11 = obj3 + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v198 @ S1_v43 (Il2CppClass<UnityEngine.Object>)+EC] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+68]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+60]");
		_ = 0;
		Rect rect2 = (Rect)(rect + 48);
		int num4 = default;
		int num5 = default;
		Rect rect3 = NGUIMath.ConvertToTexCoords(rect2, num4, num5);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+58]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+50]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+78]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+70]");
		_ = 0;
		nint num6 = (nint)obj3;
		object obj12 = obj3 + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v238 @ S1_v62 (Il2CppClass<UnityEngine.Object>)+DC] (should have been resolved before IL gen)");
		nint num7 = (nint)obj3;
		object obj13 = obj3 + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v249 @ S1_v66 (Il2CppClass<UnityEngine.Object>)+EC] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+58]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+50]");
		_ = 0;
		Rect rect4 = (Rect)(rect + 32);
		int num8 = default;
		int num9 = default;
		Rect rect5 = NGUIMath.ConvertToTexCoords(rect4, num8, num9);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+48]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+40]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+88]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+48]");
		((Rect*)(nint)rect)->m_Width = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+80]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+40]");
		((Rect*)(nint)rect)->m_XMin = 0f;
		Rect outer = (Rect)(rect + 16);
		Fill(verts, uvs, cols, outer, rect);
		OnPostFillCallback onPostFillCallback = onPostFill;
		if (onPostFill != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v298.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}
}
