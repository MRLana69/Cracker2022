using System;
using Cpp2ILInjected;
using UnityEngine;

public class UI2DSprite : UIBasicSprite
{
	private Sprite mSprite;

	private Material mMat;

	private Shader mShader;

	private Vector4 mBorder;

	private bool mFixedAspect;

	private float mPixelSize;

	public Sprite nextSprite;

	[NonSerialized]
	private int mPMA;

	public Sprite sprite2D
	{
		get
		{
			return mSprite;
		}
		set
		{
			if (mSprite != value)
			{
				RemoveFromPanel();
				mSprite = value;
				nextSprite = null;
				UIPanel uIPanel = CreatePanel();
			}
		}
	}

	public override Material material
	{
		get
		{
			return mMat;
		}
		set
		{
			//IL_0025: Expected I, but got Obj
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Expected Obj, but got Unknown
			if (mMat != value)
			{
				RemoveFromPanel();
				mMat = value;
				mPMA = -1;
				nint num = (nint)this;
				object obj = this + 272;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v40 @ S1_v8 (Il2CppClass<UI2DSprite>)+1CC] (should have been resolved before IL gen)");
			}
		}
	}

	public override Shader shader
	{
		get
		{
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Expected Obj, but got Unknown
			if (mMat != null)
			{
				return mMat.shader;
			}
			object result = this + 360;
			if (mShader == null)
			{
				Shader shader = Shader.Find("Unlit/Transparent Colored");
				result = shader;
			}
			return (Shader)result;
		}
		set
		{
			//IL_0053: Expected I, but got Obj
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Expected Obj, but got Unknown
			if (mShader != value)
			{
				RemoveFromPanel();
				mShader = value;
				if (mMat == null)
				{
					mPMA = -1;
					nint num = (nint)this;
					object obj = this + 272;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v51 @ S1_v9 (Il2CppClass<UI2DSprite>)+1CC] (should have been resolved before IL gen)");
				}
			}
		}
	}

	public override Texture mainTexture
	{
		get
		{
			if (mSprite != null)
			{
				return mSprite.texture;
			}
			if (mMat != null)
			{
				return mMat.mainTexture;
			}
			return null;
		}
	}

	public override bool premultipliedAlpha
	{
		get
		{
			//IL_000a: Expected I, but got Obj
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected Obj, but got Unknown
			bool flag = mPMA == -1;
			bool flag2 = !flag;
			int num = mPMA;
			if (!flag2)
			{
				nint num2 = (nint)this;
				object obj = this + 224;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v22 @ S1_v6 (Il2CppClass<UI2DSprite>)+19C] (should have been resolved before IL gen)");
				UnityEngine.Object obj2 = default;
				bool flag3 = obj2 != null;
				bool flag4 = !flag3;
				num = 0;
				if (!flag4)
				{
					string text = obj2.name;
					bool flag5 = text.Contains("Premultiplied");
					num = (flag5 ? 1 : 0);
				}
				mPMA = num;
			}
			return num == 1;
		}
	}

	public override float pixelSize => mPixelSize;

	public unsafe override Vector4 drawingDimensions
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0b0a: Expected F4, but got I
			//IL_0b1f: Invalid comparison between I and F4
			//IL_0925: Expected native int or pointer, but got VT
			//IL_095e: Expected F4, but got I
			//IL_0973: Invalid comparison between I and F4
			//IL_0485: Expected I, but got Obj
			//IL_048b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0490: Expected Obj, but got Unknown
			//IL_049f: Expected I, but got Obj
			//IL_04a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_04aa: Expected Obj, but got Unknown
			//IL_04d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d6: Expected Obj, but got Unknown
			//IL_04f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_04fa: Expected Obj, but got Unknown
			//IL_050a: Unknown result type (might be due to invalid IL or missing references)
			//IL_050f: Expected Obj, but got Unknown
			//IL_09b6: Expected native int or pointer, but got VT
			//IL_09ef: Expected F4, but got I
			//IL_0a04: Invalid comparison between I and F4
			//IL_0a47: Expected native int or pointer, but got VT
			//IL_0a7a: Expected F4, but got VT
			//IL_0a89: Invalid comparison between VT and F4
			//IL_0acc: Expected native int or pointer, but got VT
			//IL_00eb: Expected F8, but got I4
			//IL_012a: Expected F8, but got I4
			//IL_0169: Expected F8, but got I4
			//IL_01a8: Expected F8, but got I4
			//IL_01ca: Expected Obj, but got I
			//IL_0216: Expected F8, but got I4
			//IL_0238: Expected Obj, but got I
			//IL_0248: Unknown result type (might be due to invalid IL or missing references)
			//IL_024d: Expected Obj, but got Unknown
			//IL_028c: Expected F8, but got I4
			//IL_07cc: Invalid comparison between F8 and I4
			//IL_07f0: Expected Obj, but got I4
			//IL_029a: Invalid comparison between F8 and I4
			//IL_0897: Expected Obj, but got I4
			//IL_03ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b3: Expected Obj, but got Unknown
			//IL_0838: Unknown result type (might be due to invalid IL or missing references)
			//IL_083d: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 - 32;
			_ = 0;
			_ = 0;
			Vector2 vector = pivotOffset;
			float num = 0f - (float)obj;
			float num2 = num * (float)mWidth;
			float num3 = num2 + (float)mWidth;
			float num4 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
			float num5 = num4 - 0f;
			float num6 = num5 * (float)mHeight;
			float num7 = num6 + (float)mHeight;
			bool flag = mSprite != null;
			bool flag2 = !flag;
			float num8 = num7;
			float num9 = num6;
			float num10 = num3;
			float num11 = num2;
			double num13 = default;
			double num15 = default;
			double num17 = default;
			double num19 = default;
			double num22 = default;
			double num25 = default;
			double num26;
			float num27;
			float num28;
			double num29;
			if (!flag2)
			{
				bool flag3 = mType == Type.Tiled;
				num8 = num7;
				num9 = num6;
				num10 = num3;
				num11 = num2;
				if (!flag3)
				{
					Rect rect = mSprite.rect;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
					double num12 = Math.Abs(num13);
					if (!(num12 < 2147483648.0))
					{
						num13 = -2147483648.0;
					}
					Rect rect2 = mSprite.rect;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
					double num14 = Math.Abs(num15);
					if (!(num14 < 2147483648.0))
					{
						num15 = -2147483648.0;
					}
					Vector2 textureRectOffset = mSprite.textureRectOffset;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
					double num16 = Math.Abs(num17);
					if (!(num16 < 2147483648.0))
					{
						num17 = -2147483648.0;
					}
					Vector2 textureRectOffset2 = mSprite.textureRectOffset;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
					double num18 = Math.Abs(num19);
					if (!(num18 < 2147483648.0))
					{
						num19 = -2147483648.0;
					}
					Rect rect3 = mSprite.rect;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
					_ = 0;
					Rect textureRect = mSprite.textureRect;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
					_ = 0;
					Vector2 textureRectOffset3 = mSprite.textureRectOffset;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
					nint num20 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
					object obj3 = num20 - 0;
					object obj4 = obj3 - obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
					double num21 = Math.Abs(num22);
					if (!(num21 < 2147483648.0))
					{
						num22 = -2147483648.0;
					}
					Rect rect4 = mSprite.rect;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
					_ = 0;
					Rect textureRect2 = mSprite.textureRect;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
					_ = 0;
					Vector2 textureRectOffset4 = mSprite.textureRectOffset;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
					nint num23 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
					object obj5 = num23 - 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
					object obj6 = obj5 - 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
					double num24 = Math.Abs(num25);
					if (!(num24 < 2147483648.0))
					{
						num25 = -2147483648.0;
					}
					if (!(num13 < 1.0) && !(num15 < 1.0))
					{
						if (mType == Type.Simple)
						{
							goto IL_0395;
						}
						bool flag4 = mType == Type.Sliced;
						num26 = num25;
						num27 = 1f;
						num28 = 1f;
						num29 = num22;
						if (!flag4)
						{
							bool flag5 = mType == Type.Tiled;
							num26 = num25;
							num27 = 1f;
							num28 = 1f;
							num29 = num22;
							if (!flag5)
							{
								if (mType == Type.Filled)
								{
									goto IL_0395;
								}
								num26 = num25;
								num27 = 1f;
								num28 = 1f;
								num29 = num22;
							}
						}
					}
					else
					{
						num26 = num25;
						num27 = 1f;
						num28 = 1f;
						num29 = num22;
					}
					goto IL_07e0;
				}
			}
			goto IL_05f4;
			IL_07e0:
			object obj7 = mFlip - 1;
			bool flag6 = mFlip == Flip.Horizontally;
			double num30 = num17;
			double num31 = num29;
			if (!flag6)
			{
				if ((nint)obj7 != 1)
				{
					bool flag7 = (nint)obj7 == 2;
					num30 = num17;
					num31 = num29;
					if (flag7)
					{
						goto IL_084b;
					}
				}
				num30 = num29;
				num31 = num17;
			}
			goto IL_084b;
			IL_0395:
			double num32 = num22 + 1.0;
			object obj8 = num13 & 1;
			if (obj8 == null)
			{
				num32 = num22;
			}
			double num33 = num25 + 1.0;
			object obj9 = num15 & 1;
			if (obj9 == null)
			{
				num33 = num25;
			}
			float num34 = 1f / (float)num13;
			float num35 = num34 * (float)mWidth;
			float num36 = 1f / (float)num15;
			float num37 = num36 * (float)mHeight;
			num26 = num33;
			num27 = num35;
			num28 = num37;
			num29 = num32;
			goto IL_07e0;
			IL_084b:
			double num38 = num31 * (double)num27;
			float num39 = num2 + (float)num38;
			double num40 = num30 * (double)num27;
			float num41 = num3 - (float)num40;
			object obj10 = mFlip & (Flip)(-2);
			bool flag8 = (nint)obj10 == 2;
			double num42 = num26;
			if (!flag8)
			{
				num42 = num19;
			}
			double num43 = num42 * (double)num28;
			float num44 = num6 + (float)num43;
			double num45 = num19;
			if (!flag8)
			{
				num45 = num26;
			}
			double num46 = num45 * (double)num28;
			float num47 = num7 - (float)num46;
			num8 = num47;
			num9 = num44;
			num10 = num41;
			num11 = num39;
			goto IL_05f4;
			IL_05f4:
			bool flag9 = (byte)(~(mFixedAspect ? 1u : 0u)) != 0;
			bool flag10 = !flag9;
			float num48 = 0f;
			object obj18 = default;
			if (!flag10)
			{
				nint num49 = (nint)this;
				object obj11 = this + 256;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v126 @ S2_v22 (Il2CppClass<UI2DSprite>)+1BC] (should have been resolved before IL gen)");
				nint num50 = (nint)this;
				object obj12 = this + 336;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v147 @ S2_v26 (Il2CppClass<UI2DSprite>)+20C] (should have been resolved before IL gen)");
				object obj14 = default;
				object obj13 = obj * obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				object obj15 = 0 * obj14;
				float num51 = (float)obj13 + (float)obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
				object obj16 = 0 * obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
				object obj17 = 0 * obj14;
				obj18 = obj16 + obj17;
				num48 = num51;
			}
			float num52 = num9 + (float)obj18;
			float num53 = num8 - num52;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (UI2DSprite)+A0]");
			float num54 = Math.Min(0f, 1f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (UI2DSprite)+A0]");
			bool flag11 = 0f < 0f;
			float num55 = 0f;
			if (!flag11)
			{
				num55 = num54;
			}
			float num56 = num53 * num55;
			float w = num52 + num56;
			Vector4 vector2 = default;
			((Vector4*)(nint)vector2)->w = w;
			float num57 = num11 + num48;
			float num58 = num10 - num57;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (UI2DSprite)+9C]");
			float num59 = Math.Min(0f, 1f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (UI2DSprite)+9C]");
			bool flag12 = 0f < 0f;
			float num60 = 0f;
			if (!flag12)
			{
				num60 = num59;
			}
			float num61 = num58 * num60;
			float z = num57 + num61;
			((Vector4*)(nint)vector2)->z = z;
			float num62 = num8 - (float)obj18;
			float num63 = num62 - num9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (UI2DSprite)+98]");
			float num64 = Math.Min(0f, 1f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (UI2DSprite)+98]");
			bool flag13 = 0f < 0f;
			float num65 = 0f;
			if (!flag13)
			{
				num65 = num64;
			}
			float num66 = num63 * num65;
			float y = num9 + num66;
			((Vector4*)(nint)vector2)->y = y;
			float num67 = num10 - num48;
			float num68 = num67 - num11;
			float num69 = Math.Min((float)mDrawRegion, 1f);
			bool flag14 = mDrawRegion < (object)0f;
			float num70 = 0f;
			if (!flag14)
			{
				num70 = num69;
			}
			float num71 = num68 * num70;
			float x = num11 + num71;
			((Vector4*)(nint)vector2)->x = x;
			return vector2;
		}
	}

	public unsafe override Vector4 border
	{
		get
		{
			//IL_000f: Expected F4, but got VT
			//IL_000a: Expected native int or pointer, but got VT
			//IL_0024: Expected F4, but got I
			//IL_001f: Expected native int or pointer, but got VT
			Vector4 vector = default;
			((Vector4*)(nint)vector)->x = (float)mBorder;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (UI2DSprite)+174]");
			((Vector4*)(nint)vector)->z = 0f;
			return vector;
		}
		set
		{
			//IL_0115: Expected VT, but got F4
			//IL_0124: Expected I, but got Obj
			//IL_012a: Unknown result type (might be due to invalid IL or missing references)
			//IL_012f: Expected Obj, but got Unknown
			float num = (float)mBorder - value.x;
			float num2 = num * num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI2DSprite)+170]");
			float num3 = 0f - value.y;
			float num4 = num3 * num3;
			float num5 = num2 + num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI2DSprite)+174]");
			float num6 = 0f - value.z;
			float num7 = num6 * num6;
			float num8 = num5 + num7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI2DSprite)+178]");
			float num9 = 0f - value.w;
			float num10 = num9 * num9;
			float num11 = num8 + num10;
			if (!(num11 < 9.9999994E-11f))
			{
				mBorder = (Vector4)value.x;
				_ = value.z;
				nint num12 = (nint)this;
				object obj = this + 272;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v49 @ S1_v23 (Il2CppClass<UI2DSprite>)+1CC] (should have been resolved before IL gen)");
			}
		}
	}

	protected unsafe override void OnUpdate()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0075: Expected I, but got Obj
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected Obj, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		//IL_006b: Expected Obj, but got I4
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected Obj, but got Unknown
		//IL_012c: Expected F8, but got I4
		//IL_0487: Unknown result type (might be due to invalid IL or missing references)
		//IL_048c: Expected Obj, but got Unknown
		//IL_016b: Expected F8, but got I4
		//IL_01aa: Expected F8, but got I4
		//IL_01e9: Expected F8, but got I4
		//IL_053f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0544: Expected Obj, but got Unknown
		//IL_0576: Unknown result type (might be due to invalid IL or missing references)
		//IL_057b: Expected Obj, but got Unknown
		//IL_020b: Expected Obj, but got I
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected Obj, but got Unknown
		//IL_025f: Expected F8, but got I4
		//IL_05dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e2: Expected Obj, but got Unknown
		//IL_0614: Unknown result type (might be due to invalid IL or missing references)
		//IL_0619: Expected Obj, but got Unknown
		//IL_0281: Expected Obj, but got I
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Expected Obj, but got Unknown
		//IL_02d5: Expected F8, but got I4
		//IL_06ad: Invalid comparison between F8 and I4
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c6: Expected Obj, but got Unknown
		//IL_06f0: Expected F4, but got I
		//IL_06eb: Expected native int or pointer, but got VT
		//IL_06fd: Expected F4, but got Obj
		//IL_06f8: Expected native int or pointer, but got VT
		//IL_033b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0340: Expected Obj, but got Unknown
		object obj = default;
		Vector4 vector = (Vector4)(obj - 80);
		_ = 0;
		_ = 0;
		if (nextSprite != null)
		{
			if (nextSprite != mSprite)
			{
				sprite2D = nextSprite;
			}
			object obj2 = this + 388;
			obj2 = 0;
		}
		base.OnUpdate();
		if (~(mFixedAspect ? 1u : 0u) != 0)
		{
			return;
		}
		nint num = (nint)this;
		object obj3 = this + 208;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v60 @ S1_v11 (Il2CppClass<UI2DSprite>)+18C] (should have been resolved before IL gen)");
		UnityEngine.Object obj4 = default;
		if (obj4 != null)
		{
			Rect rect = mSprite.rect;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector4)+38]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector4)+30]");
			_ = 0;
			object obj5 = vector - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
			double num3 = default;
			double num2 = Math.Abs(num3);
			if (!(num2 < 2147483648.0))
			{
				num3 = -2147483648.0;
			}
			Rect rect2 = mSprite.rect;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector4)+38]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector4)+30]");
			_ = 0;
			object obj6 = vector - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
			double num5 = default;
			double num4 = Math.Abs(num5);
			if (!(num4 < 2147483648.0))
			{
				num5 = -2147483648.0;
			}
			Vector2 textureRectOffset = mSprite.textureRectOffset;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
			double num7 = default;
			double num6 = Math.Abs(num7);
			if (!(num6 < 2147483648.0))
			{
				num7 = -2147483648.0;
			}
			Vector2 textureRectOffset2 = mSprite.textureRectOffset;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
			double num9 = default;
			double num8 = Math.Abs(num9);
			if (!(num8 < 2147483648.0))
			{
				num9 = -2147483648.0;
			}
			Rect rect3 = mSprite.rect;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector4)+38]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector4)+30]");
			_ = 0;
			object obj7 = vector - -64;
			Rect textureRect = mSprite.textureRect;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector4)+38]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector4)+30]");
			_ = 0;
			object obj8 = vector - -64;
			Vector2 textureRectOffset3 = mSprite.textureRectOffset;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ S0_v101+8]");
			nint num10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ S0_v108+8]");
			object obj9 = num10 - 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector4)+30]");
			object obj10 = obj9 - 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
			double num12 = default;
			double num11 = Math.Abs(num12);
			if (!(num11 < 2147483648.0))
			{
				num12 = -2147483648.0;
			}
			Rect rect4 = mSprite.rect;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector4)+38]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector4)+30]");
			_ = 0;
			object obj11 = vector - -64;
			Rect textureRect2 = mSprite.textureRect;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector4)+38]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector4)+30]");
			_ = 0;
			object obj12 = vector - -64;
			Vector2 textureRectOffset4 = mSprite.textureRectOffset;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ S0_v131+C]");
			nint num13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ S0_v138+C]");
			object obj13 = num13 - 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector4)+34]");
			object obj14 = obj13 - 0;
			double num14 = num7 + num12;
			double num15 = num14 + num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
			double num17 = default;
			double num16 = Math.Abs(num17);
			if (!(num16 < 2147483648.0))
			{
				num17 = -2147483648.0;
			}
			double num18 = num17 + num9;
			double num19 = num18 + num5;
			double num20 = num15 / num19;
			int num21 = mWidth / mHeight;
			object obj15;
			if (num20 < (double)num21)
			{
				double num22 = (double)mHeight * num20;
				double num23 = (double)mWidth - num22;
				double num24 = num23 / (double)mWidth;
				double num25 = num24 * 0.5;
				float num26 = 1f - (float)num25;
				obj15 = vector + 32;
				float num27 = num26;
				float num28 = 1f;
				double num29 = 0.0;
			}
			else
			{
				double num30 = (double)mWidth / num20;
				double num31 = (double)mHeight - num30;
				double num32 = num31 / (double)mHeight;
				double num33 = num32 * 0.5;
				float num34 = 1f - (float)num33;
				_ = 0;
				obj15 = vector + 16;
				float num27 = 1f;
				float num28 = num34;
				double num29 = num33;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ S0_v156+8]");
			((Vector4*)(nint)vector)->z = 0f;
			((Vector4*)(nint)vector)->x = (float)obj15;
			drawRegion = vector;
		}
	}

	public override void MakePixelPerfect()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0018: Expected I, but got Obj
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_0173: Expected F8, but got I4
		//IL_01b2: Expected F8, but got I4
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Expected Obj, but got Unknown
		//IL_024a: Expected I4, but got F8
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Expected Obj, but got Unknown
		//IL_02b3: Expected I4, but got F8
		//IL_01bf: Expected I4, but got F8
		//IL_01cc: Expected I4, but got F8
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		_ = 0;
		base.MakePixelPerfect();
		if (mType == Type.Tiled)
		{
			return;
		}
		nint num = (nint)this;
		object obj3 = this + 208;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v28 @ S1_v10 (Il2CppClass<UI2DSprite>)+18C] (should have been resolved before IL gen)");
		UnityEngine.Object obj4 = default;
		if (obj4 != null && (mType == Type.Simple || (mType != Type.Sliced && mType != Type.Tiled && mType == Type.Filled) || !hasBorder) && obj4 != null)
		{
			Rect rect = mSprite.rect;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
			double num3 = default;
			double num2 = Math.Abs(num3);
			if (!(num2 < 2147483648.0))
			{
				num3 = -2147483648.0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
			double num5 = default;
			double num4 = Math.Abs(num5);
			if (!(num4 < 2147483648.0))
			{
				num5 = -2147483648.0;
			}
			double num6 = num3 + 1.0;
			object obj5 = num3 & 1;
			int num7 = (int)num6;
			if (obj5 == null)
			{
				num7 = (int)num3;
			}
			width = num7;
			double num8 = num5 + 1.0;
			object obj6 = num5 & 1;
			int num9 = (int)num8;
			if (obj6 == null)
			{
				num9 = (int)num5;
			}
			height = num9;
		}
	}

	public unsafe override void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00cc: Expected I, but got Obj
		//IL_005d: Expected I, but got Obj
		//IL_006f: Expected I, but got Obj
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected Obj, but got Unknown
		//IL_0154: Expected I, but got Obj
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected Obj, but got Unknown
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected Obj, but got Unknown
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected Obj, but got Unknown
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected Obj, but got Unknown
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected Obj, but got Unknown
		//IL_01e9: Expected Obj, but got I
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Expected Obj, but got Unknown
		//IL_0214: Expected Obj, but got I
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Expected Obj, but got Unknown
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected Obj, but got Unknown
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected Obj, but got Unknown
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Expected Obj, but got Unknown
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Expected Obj, but got Unknown
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Expected Obj, but got Unknown
		//IL_02bc: Expected Obj, but got I
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Expected Obj, but got Unknown
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Expected Obj, but got Unknown
		//IL_02f3: Expected I, but got Obj
		//IL_0305: Expected I, but got Obj
		//IL_032c: Expected Obj, but got I
		//IL_0389: Expected Obj, but got I
		//IL_03d1: Expected Obj, but got I
		//IL_042e: Expected Obj, but got I
		//IL_0462: Unknown result type (might be due to invalid IL or missing references)
		//IL_0467: Expected Obj, but got Unknown
		//IL_0477: Unknown result type (might be due to invalid IL or missing references)
		//IL_047c: Expected Obj, but got Unknown
		//IL_0485: Unknown result type (might be due to invalid IL or missing references)
		//IL_048a: Expected Obj, but got Unknown
		//IL_04a1: Expected Obj, but got F4
		//IL_04be: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c3: Expected Obj, but got Unknown
		//IL_04cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d1: Expected Obj, but got Unknown
		//IL_04e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e6: Expected Obj, but got Unknown
		//IL_0512: Unknown result type (might be due to invalid IL or missing references)
		//IL_0517: Expected Obj, but got Unknown
		//IL_0534: Expected Obj, but got I
		//IL_053d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0542: Expected Obj, but got Unknown
		//IL_057b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0580: Expected Obj, but got Unknown
		//IL_0589: Unknown result type (might be due to invalid IL or missing references)
		//IL_058e: Expected Obj, but got Unknown
		//IL_05ab: Expected Obj, but got I
		//IL_05f8: Expected F4, but got I
		//IL_05f3: Expected native int or pointer, but got VT
		//IL_061a: Expected F4, but got I
		//IL_0615: Expected native int or pointer, but got VT
		//IL_0623: Unknown result type (might be due to invalid IL or missing references)
		//IL_0628: Expected VT, but got Unknown
		object obj = default;
		Rect rect = (Rect)(obj - 96);
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v26 @ S1_v8 (Il2CppClass<UI2DSprite>)+18C] (should have been resolved before IL gen)");
		UnityEngine.Object obj2 = default;
		if (obj2 != null)
		{
			if (mSprite != null)
			{
				Rect textureRect = mSprite.textureRect;
			}
			else
			{
				nint num2 = (nint)obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v121 @ S1_v132 (Il2CppClass<UnityEngine.Object>)+DC] (should have been resolved before IL gen)");
				nint num3 = (nint)obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v130 @ S1_v135 (Il2CppClass<UnityEngine.Object>)+EC] (should have been resolved before IL gen)");
				_ = 0;
				_ = 0;
				_ = 0f;
				_ = 0f;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+28]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+20]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+38]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+38]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+30]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+30]");
			_ = 0;
			object obj3 = rect + 32;
			nint num4 = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v177 @ S2_v8 (Il2CppClass<UI2DSprite>)+1BC] (should have been resolved before IL gen)");
			object obj4 = rect - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ S0_v42+8]");
			object obj5 = 0 + obj4;
			object obj6 = rect - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+20]");
			object obj7 = obj6 + 0;
			obj4 = obj7;
			object obj8 = obj5 - obj7;
			object obj9 = rect - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ S0_v48+C]");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ S0_v48+4]");
			object obj10 = num5 + 0;
			object obj11 = rect - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ S1_v40+4]");
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+24]");
			object obj12 = num6 + 0;
			object obj13 = obj10 - obj12;
			object obj14 = rect - -64;
			object obj15 = rect - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ S1_v47+8]");
			object obj16 = 0 + obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+28]");
			object obj17 = obj16 - 0;
			object obj18 = obj17 - obj14;
			object obj19 = rect - -64;
			object obj20 = rect - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ S1_v54+C]");
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ S1_v54+4]");
			object obj21 = num7 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+2C]");
			object obj22 = obj21 - 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ S0_v56+4]");
			object obj23 = obj22 - 0;
			nint num8 = (nint)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v268 @ S1_v60 (Il2CppClass<UnityEngine.Object>)+DC] (should have been resolved before IL gen)");
			nint num9 = (nint)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v277 @ S1_v63 (Il2CppClass<UnityEngine.Object>)+EC] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+58]");
			nint num10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+50]");
			object obj24 = num10 + 0;
			object obj25 = default;
			float num11 = 1f / (float)obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+50]");
			float num12 = 0f * num11;
			float num13 = (float)obj24 - num12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+58]");
			nint num14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+50]");
			object obj26 = num14 + 0;
			float num15 = (float)obj26 * num11;
			float num16 = num15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+50]");
			float num17 = num16 - 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+5C]");
			nint num18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+54]");
			object obj27 = num18 + 0;
			object obj28 = default;
			float num19 = 1f / (float)obj28;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+54]");
			float num20 = 0f * num19;
			float num21 = (float)obj27 - num20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+5C]");
			nint num22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+54]");
			object obj29 = num22 + 0;
			float num23 = (float)obj29 * num19;
			float num24 = num23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+54]");
			float num25 = num24 - 0f;
			object obj30 = rect - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ S0_v74+8]");
			object obj31 = 0 + obj30;
			object obj32 = rect - -64;
			float num26 = (float)obj32 * num11;
			obj30 = num26;
			float num27 = (float)obj31 - num26;
			object obj33 = rect - -64;
			object obj34 = rect - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ S1_v100+8]");
			object obj35 = 0 + obj34;
			float num28 = (float)obj35 * num11;
			float num29 = num28 - (float)obj33;
			object obj36 = rect - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ S0_v82+C]");
			nint num30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ S0_v82+4]");
			object obj37 = num30 + 0;
			object obj38 = rect - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ S1_v109+4]");
			float num31 = 0f * num19;
			float num32 = (float)obj37 - num31;
			object obj39 = rect - -64;
			object obj40 = rect - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ S1_v116+C]");
			nint num33 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ S1_v116+4]");
			object obj41 = num33 + 0;
			float num34 = (float)obj41 * num19;
			float num35 = num34;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ S0_v88+4]");
			float num36 = num35 - 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+58]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+48]");
			((Rect*)(nint)rect)->m_Width = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+50]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+40]");
			((Rect*)(nint)rect)->m_XMin = 0f;
			Rect outer = (Rect)(rect + 16);
			Fill(verts, uvs, cols, outer, rect);
			OnPostFillCallback onPostFillCallback = onPostFill;
			if (onPostFill != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v437.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
	}

	public UI2DSprite()
	{
		//IL_0018: Expected I, but got Obj
		nint num = (nint)typeof(Vector4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<UnityEngine.Vector4>)+5C]");
		nint num2 = 0;
		mPMA = -1;
		mPixelSize = 1f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v11 (Il2CppStaticFields<UnityEngine.Vector4>)+8]");
		_ = 0;
		mBorder = Vector4.zeroVector;
		base._002Ector();
	}
}
