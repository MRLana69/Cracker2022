using System;
using Cpp2ILInjected;
using UnityEngine;

public class UITexture : UIBasicSprite
{
	private Rect mRect;

	private Texture mTexture;

	private Material mMat;

	private Shader mShader;

	private Vector4 mBorder;

	private bool mFixedAspect;

	[NonSerialized]
	private int mPMA;

	public override Texture mainTexture
	{
		get
		{
			if (mTexture != null)
			{
				return mTexture;
			}
			if (mMat != null)
			{
				return mMat.mainTexture;
			}
			return null;
		}
		set
		{
			//IL_00ca: Expected I, but got Obj
			//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d5: Expected Obj, but got Unknown
			if (!(mTexture != value))
			{
				return;
			}
			if (drawCall != null)
			{
				UIDrawCall uIDrawCall = drawCall;
				if (uIDrawCall.widgetCount == 1 && mMat == null)
				{
					mTexture = value;
					drawCall.mainTexture = value;
					return;
				}
			}
			RemoveFromPanel();
			mTexture = value;
			mPMA = -1;
			nint num = (nint)this;
			object obj = this + 272;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v77 @ S1_v10 (Il2CppClass<UITexture>)+1CC] (should have been resolved before IL gen)");
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
			//IL_002c: Expected I, but got Obj
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Expected Obj, but got Unknown
			if (mMat != value)
			{
				RemoveFromPanel();
				mShader = null;
				mMat = value;
				mPMA = -1;
				nint num = (nint)this;
				object obj = this + 272;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v42 @ S1_v9 (Il2CppClass<UITexture>)+1CC] (should have been resolved before IL gen)");
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
			object result = this + 376;
			if (mShader == null)
			{
				Shader shader = Shader.Find("Unlit/Transparent Colored");
				result = shader;
			}
			return (Shader)result;
		}
		set
		{
			//IL_00d1: Expected I, but got Obj
			//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dc: Expected Obj, but got Unknown
			if (!(mShader != value))
			{
				return;
			}
			if (drawCall != null)
			{
				UIDrawCall uIDrawCall = drawCall;
				if (uIDrawCall.widgetCount == 1 && mMat == null)
				{
					mShader = value;
					drawCall.shader = value;
					return;
				}
			}
			RemoveFromPanel();
			mShader = value;
			mMat = null;
			mPMA = -1;
			nint num = (nint)this;
			object obj = this + 272;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v79 @ S1_v11 (Il2CppClass<UITexture>)+1CC] (should have been resolved before IL gen)");
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
			bool flag3 = (byte)mPMA != 0;
			if (!flag2)
			{
				nint num = (nint)this;
				object obj = this + 192;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v20 @ S1_v6 (Il2CppClass<UITexture>)+17C] (should have been resolved before IL gen)");
				UnityEngine.Object obj2 = default;
				bool flag4 = obj2 != null;
				bool flag5 = !flag4;
				bool flag6 = false;
				if (!flag5)
				{
					Shader shader = ((Material)obj2).shader;
					bool flag7 = shader != null;
					bool flag8 = !flag7;
					flag6 = false;
					if (!flag8)
					{
						Shader shader2 = ((Material)obj2).shader;
						string text = shader2.name;
						flag6 = text.Contains("Premultiplied");
					}
				}
				mPMA = (flag6 ? 1 : 0);
				flag3 = flag6;
			}
			return flag3;
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (UITexture)+184]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UITexture)+180]");
			float num3 = 0f - value.y;
			float num4 = num3 * num3;
			float num5 = num2 + num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UITexture)+184]");
			float num6 = 0f - value.z;
			float num7 = num6 * num6;
			float num8 = num5 + num7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UITexture)+188]");
			float num9 = 0f - value.w;
			float num10 = num9 * num9;
			float num11 = num8 + num10;
			if (!(num11 < 9.9999994E-11f))
			{
				mBorder = (Vector4)value.x;
				_ = value.z;
				nint num12 = (nint)this;
				object obj = this + 272;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v49 @ S1_v23 (Il2CppClass<UITexture>)+1CC] (should have been resolved before IL gen)");
			}
		}
	}

	public unsafe Rect uvRect
	{
		get
		{
			//IL_000f: Expected F4, but got VT
			//IL_000a: Expected native int or pointer, but got VT
			//IL_0024: Expected F4, but got I
			//IL_001f: Expected native int or pointer, but got VT
			Rect rect = default;
			((Rect*)(nint)rect)->m_XMin = (float)mRect;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (UITexture)+168]");
			((Rect*)(nint)rect)->m_Width = 0f;
			return rect;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			//IL_002f: Expected native int or pointer, but got VT
			//IL_0041: Expected native int or pointer, but got VT
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Expected VT, but got Unknown
			//IL_008d: Expected VT, but got F4
			//IL_009c: Expected I, but got Obj
			//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a7: Expected Obj, but got Unknown
			object obj = default;
			Rect rect = (Rect)(obj - 32);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UITexture)+168]");
			_ = 0;
			_ = mRect;
			((Rect*)(nint)rect)->m_Width = value.m_Width;
			((Rect*)(nint)rect)->m_XMin = value.m_XMin;
			Rect rect2 = (Rect)(rect + 16);
			if (rect2 != rect)
			{
				mRect = (Rect)value.m_XMin;
				_ = value.m_Width;
				nint num = (nint)this;
				object obj2 = this + 272;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v35 @ S1_v19 (Il2CppClass<UITexture>)+1CC] (should have been resolved before IL gen)");
			}
		}
	}

	public unsafe override Vector4 drawingDimensions
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_073b: Expected F4, but got I
			//IL_0750: Invalid comparison between I and F4
			//IL_0556: Expected native int or pointer, but got VT
			//IL_058f: Expected F4, but got I
			//IL_05a4: Invalid comparison between I and F4
			//IL_0378: Expected I, but got Obj
			//IL_037e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0383: Expected Obj, but got Unknown
			//IL_03aa: Expected Obj, but got I
			//IL_05e7: Expected native int or pointer, but got VT
			//IL_0620: Expected F4, but got I
			//IL_0635: Invalid comparison between I and F4
			//IL_009d: Expected I, but got Obj
			//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ab: Expected Obj, but got Unknown
			//IL_00c7: Expected I, but got Obj
			//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d5: Expected Obj, but got Unknown
			//IL_0678: Expected native int or pointer, but got VT
			//IL_06ab: Expected F4, but got VT
			//IL_06ba: Invalid comparison between VT and F4
			//IL_0281: Expected Obj, but got I4
			//IL_06fd: Expected native int or pointer, but got VT
			//IL_04ca: Expected Obj, but got I4
			//IL_0508: Expected Obj, but got I4
			//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f9: Expected Obj, but got Unknown
			//IL_0202: Unknown result type (might be due to invalid IL or missing references)
			//IL_0207: Expected Obj, but got Unknown
			//IL_0164: Expected Obj, but got I4
			//IL_019e: Expected Obj, but got I4
			//IL_01e6: Expected Obj, but got I4
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
			bool flag = mTexture != null;
			bool flag2 = !flag;
			float num8 = num7;
			float num9 = num6;
			float num10 = num3;
			float num11 = num2;
			object obj5 = default;
			object obj6 = default;
			float num14;
			float num15;
			object obj7;
			if (!flag2)
			{
				bool flag3 = mType == Type.Tiled;
				num8 = num7;
				num9 = num6;
				num10 = num3;
				num11 = num2;
				if (!flag3)
				{
					Texture texture = mTexture;
					nint num12 = (nint)texture;
					object obj3 = texture + 32;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v103 @ S1_v37 (Il2CppClass<UnityEngine.Texture>)+DC] (should have been resolved before IL gen)");
					Texture texture2 = mTexture;
					nint num13 = (nint)texture2;
					object obj4 = texture2 + 48;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v117 @ S1_v41 (Il2CppClass<UnityEngine.Texture>)+EC] (should have been resolved before IL gen)");
					if ((nint)obj5 >= 1 && (nint)obj6 >= 1)
					{
						if (mType == Type.Simple)
						{
							goto IL_01eb;
						}
						bool flag4 = mType == Type.Sliced;
						num14 = 1f;
						num15 = 1f;
						obj7 = 0;
						if (!flag4)
						{
							bool flag5 = mType == Type.Tiled;
							num14 = 1f;
							num15 = 1f;
							obj7 = 0;
							if (!flag5)
							{
								if (mType == Type.Filled)
								{
									goto IL_01eb;
								}
								num14 = 1f;
								num15 = 1f;
								obj7 = 0;
							}
						}
					}
					else
					{
						num14 = 1f;
						num15 = 1f;
						obj7 = 0;
					}
					goto IL_04ba;
				}
			}
			goto IL_048d;
			IL_01eb:
			object obj8 = obj5 & 1;
			object obj9 = obj6 & 1;
			float num16 = 1f / (float)obj5;
			float num17 = num16 * (float)mWidth;
			float num18 = 1f / (float)obj6;
			float num19 = num18 * (float)mHeight;
			num14 = num17;
			num15 = num19;
			obj7 = obj8;
			goto IL_04ba;
			IL_04ba:
			object obj10 = mFlip - 1;
			if (mFlip == Flip.Horizontally || ((nint)obj10 != 1 && (nint)obj10 == 2))
			{
				float num20 = (float)obj7 * num14;
				float num21 = num2 + num20;
				num10 = num3;
				num11 = num21;
			}
			else
			{
				float num22 = (float)obj7 * num14;
				float num23 = num3 - num22;
				num10 = num23;
				num11 = num2;
			}
			float num24 = (float)obj9 * num15;
			object obj11 = mFlip & (Flip)(-2);
			if ((nint)obj11 == 2)
			{
				float num25 = num6 + num24;
				num8 = num7;
				num9 = num25;
			}
			else
			{
				float num26 = num7 - num24;
				num8 = num26;
				num9 = num6;
			}
			goto IL_048d;
			IL_048d:
			bool flag6 = (byte)(~(mFixedAspect ? 1u : 0u)) != 0;
			bool flag7 = !flag6;
			float num27 = 0f;
			object obj13 = default;
			if (!flag7)
			{
				nint num28 = (nint)this;
				object obj12 = this + 256;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v131 @ S2_v22 (Il2CppClass<UITexture>)+1BC] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
				nint num29 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
				obj13 = num29 + 0;
				float num30 = (float)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				float num31 = num30 + 0f;
				num27 = num31;
			}
			float num32 = num9 + (float)obj13;
			float num33 = num8 - num32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (UITexture)+A0]");
			float num34 = Math.Min(0f, 1f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (UITexture)+A0]");
			bool flag8 = 0f < 0f;
			float num35 = 0f;
			if (!flag8)
			{
				num35 = num34;
			}
			float num36 = num33 * num35;
			float w = num32 + num36;
			Vector4 vector2 = default;
			((Vector4*)(nint)vector2)->w = w;
			float num37 = num11 + num27;
			float num38 = num10 - num37;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (UITexture)+9C]");
			float num39 = Math.Min(0f, 1f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (UITexture)+9C]");
			bool flag9 = 0f < 0f;
			float num40 = 0f;
			if (!flag9)
			{
				num40 = num39;
			}
			float num41 = num38 * num40;
			float z = num37 + num41;
			((Vector4*)(nint)vector2)->z = z;
			float num42 = num8 - (float)obj13;
			float num43 = num42 - num9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (UITexture)+98]");
			float num44 = Math.Min(0f, 1f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (UITexture)+98]");
			bool flag10 = 0f < 0f;
			float num45 = 0f;
			if (!flag10)
			{
				num45 = num44;
			}
			float num46 = num43 * num45;
			float y = num9 + num46;
			((Vector4*)(nint)vector2)->y = y;
			float num47 = num10 - num27;
			float num48 = num47 - num11;
			float num49 = Math.Min((float)mDrawRegion, 1f);
			bool flag11 = mDrawRegion < (object)0f;
			float num50 = 0f;
			if (!flag11)
			{
				num50 = num49;
			}
			float num51 = num48 * num50;
			float x = num11 + num51;
			((Vector4*)(nint)vector2)->x = x;
			return vector2;
		}
	}

	public bool fixedAspect
	{
		get
		{
			return mFixedAspect;
		}
		set
		{
			//IL_0037: Expected VT, but got I4
			//IL_0050: Expected I, but got Obj
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Expected Obj, but got Unknown
			if (value != mFixedAspect)
			{
				mDrawRegion = (Vector4)0;
				mFixedAspect = value;
				_ = 4575657222473777152L;
				nint num = (nint)this;
				object obj = this + 272;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v15 @ S1_v8 (Il2CppClass<UITexture>)+1CC] (should have been resolved before IL gen)");
			}
		}
	}

	public override void MakePixelPerfect()
	{
		//IL_000a: Expected I, but got Obj
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected Obj, but got Unknown
		//IL_010d: Expected I, but got Obj
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected Obj, but got Unknown
		//IL_012d: Expected I, but got Obj
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected Obj, but got Unknown
		base.MakePixelPerfect();
		if (mType == Type.Tiled)
		{
			return;
		}
		nint num = (nint)this;
		object obj = this + 208;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v19 @ S1_v6 (Il2CppClass<UITexture>)+18C] (should have been resolved before IL gen)");
		UnityEngine.Object obj2 = default;
		if (obj2 != null && (mType == Type.Simple || (mType != Type.Sliced && mType != Type.Tiled && mType == Type.Filled) || !hasBorder) && obj2 != null)
		{
			nint num2 = (nint)obj2;
			object obj3 = obj2 + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v76 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+DC] (should have been resolved before IL gen)");
			nint num3 = (nint)obj2;
			object obj4 = obj2 + 48;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v86 @ S1_v17 (Il2CppClass<UnityEngine.Object>)+EC] (should have been resolved before IL gen)");
			int num5 = default;
			int num4 = num5 + 1;
			if ((num5 & 1) == 0)
			{
				num4 = num5;
			}
			width = num4;
			int num7 = default;
			int num6 = num7 + 1;
			if ((num7 & 1) == 0)
			{
				num6 = num7;
			}
			height = num6;
		}
	}

	protected unsafe override void OnUpdate()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0018: Expected I, but got Obj
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_0061: Expected I, but got Obj
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected Obj, but got Unknown
		//IL_01e3: Expected I, but got Obj
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Expected Obj, but got Unknown
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Expected Obj, but got Unknown
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Expected Obj, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected I4, but got Unknown
		//IL_015a: Expected Obj, but got I4
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected I4, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected Obj, but got Unknown
		//IL_0249: Expected F4, but got I
		//IL_0244: Expected native int or pointer, but got VT
		//IL_0256: Expected F4, but got Obj
		//IL_0251: Expected native int or pointer, but got VT
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected Obj, but got Unknown
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected Obj, but got Unknown
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected I4, but got Unknown
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected Obj, but got Unknown
		object obj = default;
		Vector4 vector = (Vector4)(obj - 48);
		base.OnUpdate();
		if (~(mFixedAspect ? 1u : 0u) != 0)
		{
			return;
		}
		nint num = (nint)this;
		object obj2 = this + 208;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v23 @ S1_v7 (Il2CppClass<UITexture>)+18C] (should have been resolved before IL gen)");
		UnityEngine.Object obj3 = default;
		if (obj3 != null)
		{
			nint num2 = (nint)obj3;
			object obj4 = obj3 + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v81 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+DC] (should have been resolved before IL gen)");
			object obj6 = default;
			object obj5 = obj6 + 1;
			object obj7 = obj6 & 1;
			if (obj7 == null)
			{
				obj5 = obj6;
			}
			nint num3 = (nint)obj3;
			object obj8 = obj3 + 48;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v99 @ S2_v12 (Il2CppClass<UnityEngine.Object>)+EC] (should have been resolved before IL gen)");
			object obj10 = default;
			object obj9 = obj10 + 1;
			object obj11 = obj10 & 1;
			if (obj11 == null)
			{
				obj9 = obj10;
			}
			object obj12 = obj5 / obj9;
			int num4 = mWidth / mHeight;
			object obj15;
			if ((nint)obj12 < num4)
			{
				object obj13 = mHeight * obj12;
				object obj14 = mWidth - obj13;
				int num5 = obj14 / mWidth;
				float num6 = (float)num5 * 0.5f;
				float num7 = 1f - num6;
				obj15 = vector + 32;
				float num8 = num7;
				float num9 = 0f;
				float num10 = 1f;
			}
			else
			{
				int num11 = mWidth / obj12;
				object obj16 = mHeight - num11;
				int num12 = obj16 / mHeight;
				float num13 = (float)num12 * 0.5f;
				float num14 = 1f - num13;
				_ = 0;
				obj15 = vector + 16;
				float num8 = 1f;
				float num9 = num13;
				float num10 = num14;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S0_v27+8]");
			((Vector4*)(nint)vector)->z = 0f;
			((Vector4*)(nint)vector)->x = (float)obj15;
			drawRegion = vector;
		}
	}

	public unsafe override void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_05eb: Expected I, but got Obj
		//IL_001b: Expected I, but got Obj
		//IL_002d: Expected I, but got Obj
		//IL_003f: Expected I, but got Obj
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		//IL_005f: Expected I, but got Obj
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected Obj, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected Obj, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected Obj, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected Obj, but got Unknown
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected Obj, but got Unknown
		//IL_00fb: Expected I, but got Obj
		//IL_0122: Expected Obj, but got I
		//IL_013f: Expected Obj, but got I
		//IL_0173: Expected Obj, but got I
		//IL_0190: Expected Obj, but got I
		//IL_01c4: Expected Obj, but got I
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected Obj, but got Unknown
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected Obj, but got Unknown
		//IL_0210: Expected Obj, but got I
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Expected Obj, but got Unknown
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Expected Obj, but got Unknown
		//IL_0247: Expected I, but got Obj
		//IL_0259: Expected I, but got Obj
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Expected Obj, but got Unknown
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected Obj, but got Unknown
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Expected Obj, but got Unknown
		//IL_02bb: Expected Obj, but got F4
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Expected Obj, but got Unknown
		//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Expected Obj, but got Unknown
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Expected Obj, but got Unknown
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Expected Obj, but got Unknown
		//IL_034e: Expected Obj, but got I
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_035c: Expected Obj, but got Unknown
		//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03aa: Expected Obj, but got Unknown
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Expected Obj, but got Unknown
		//IL_03d5: Expected Obj, but got I
		//IL_041d: Expected Obj, but got I
		//IL_046a: Expected Obj, but got I
		//IL_04b2: Expected Obj, but got I
		//IL_04ff: Expected Obj, but got I
		//IL_054c: Expected F4, but got I
		//IL_0547: Expected native int or pointer, but got VT
		//IL_056e: Expected F4, but got I
		//IL_0569: Expected native int or pointer, but got VT
		//IL_0577: Unknown result type (might be due to invalid IL or missing references)
		//IL_057c: Expected VT, but got Unknown
		object obj = default;
		Rect rect = (Rect)(obj - 80);
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v26 @ S1_v8 (Il2CppClass<UITexture>)+18C] (should have been resolved before IL gen)");
		UnityEngine.Object obj2 = default;
		if (obj2 != null)
		{
			nint num2 = (nint)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v44 @ S1_v14 (Il2CppClass<UnityEngine.Object>)+DC] (should have been resolved before IL gen)");
			nint num3 = (nint)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v56 @ S1_v17 (Il2CppClass<UnityEngine.Object>)+EC] (should have been resolved before IL gen)");
			nint num4 = (nint)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v65 @ S1_v20 (Il2CppClass<UnityEngine.Object>)+DC] (should have been resolved before IL gen)");
			object obj3 = rect - -64;
			nint num5 = (nint)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v81 @ S2_v12 (Il2CppClass<UnityEngine.Object>)+EC] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UITexture)+16C]");
			object obj5 = default;
			object obj4 = obj5 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UITexture)+168]");
			object obj7 = default;
			object obj6 = obj7 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UITexture)+164]");
			object obj9 = default;
			object obj8 = 0 * obj9;
			object obj11 = default;
			object obj10 = mRect * obj11;
			obj3 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+48]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+40]");
			_ = 0;
			object obj12 = rect + 32;
			nint num6 = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v113 @ S2_v20 (Il2CppClass<UITexture>)+1BC] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+38]");
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+30]");
			object obj13 = num7 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+30]");
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+20]");
			object obj14 = num8 + 0;
			object obj15 = obj13 - obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+3C]");
			nint num9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+34]");
			object obj16 = num9 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+34]");
			nint num10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+24]");
			object obj17 = num10 + 0;
			object obj18 = obj16 - obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+38]");
			nint num11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+30]");
			object obj19 = num11 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+28]");
			object obj20 = obj19 - 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+30]");
			object obj21 = obj20 - 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+3C]");
			nint num12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+34]");
			object obj22 = num12 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+2C]");
			object obj23 = obj22 - 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+34]");
			object obj24 = obj23 - 0;
			nint num13 = (nint)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v185 @ S1_v63 (Il2CppClass<UnityEngine.Object>)+DC] (should have been resolved before IL gen)");
			nint num14 = (nint)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v194 @ S1_v66 (Il2CppClass<UnityEngine.Object>)+EC] (should have been resolved before IL gen)");
			object obj25 = rect - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ S0_v64+8]");
			object obj26 = 0 + obj25;
			object obj27 = rect - -64;
			object obj28 = default;
			float num15 = 1f / (float)obj28;
			float num16 = (float)obj27 * num15;
			obj25 = num16;
			float num17 = (float)obj26 - num16;
			object obj29 = rect - -64;
			object obj30 = rect - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ S1_v79+8]");
			object obj31 = 0 + obj30;
			float num18 = (float)obj31 * num15;
			float num19 = num18 - (float)obj29;
			object obj32 = rect - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ S0_v72+C]");
			nint num20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ S0_v72+4]");
			object obj33 = num20 + 0;
			object obj34 = rect - -64;
			object obj35 = default;
			float num21 = 1f / (float)obj35;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ S1_v88+4]");
			float num22 = 0f * num21;
			float num23 = (float)obj33 - num22;
			object obj36 = rect - -64;
			object obj37 = rect - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ S1_v95+C]");
			nint num24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ S1_v95+4]");
			object obj38 = num24 + 0;
			float num25 = (float)obj38 * num21;
			float num26 = num25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ S0_v78+4]");
			float num27 = num26 - 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+38]");
			nint num28 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+30]");
			object obj39 = num28 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+30]");
			float num29 = 0f * num15;
			float num30 = (float)obj39 - num29;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+38]");
			nint num31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+30]");
			object obj40 = num31 + 0;
			float num32 = (float)obj40 * num15;
			float num33 = num32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+30]");
			float num34 = num33 - 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+3C]");
			nint num35 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+34]");
			object obj41 = num35 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+34]");
			float num36 = 0f * num21;
			float num37 = (float)obj41 - num36;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+3C]");
			nint num38 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+34]");
			object obj42 = num38 + 0;
			float num39 = (float)obj42 * num21;
			float num40 = num39;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+34]");
			float num41 = num40 - 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+48]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+38]");
			((Rect*)(nint)rect)->m_Width = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+40]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+30]");
			((Rect*)(nint)rect)->m_XMin = 0f;
			Rect outer = (Rect)(rect + 16);
			Fill(verts, uvs, cols, outer, rect);
			OnPostFillCallback onPostFillCallback = onPostFill;
			if (onPostFill != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v416.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
	}

	public UITexture()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0022: Expected Obj, but got I4
		//IL_003d: Expected Obj, but got F4
		//IL_0054: Expected VT, but got Obj
		//IL_0067: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		obj = 0;
		_ = 1f;
		_ = 1f;
		_ = 0f;
		obj = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		mRect = (Rect)obj;
		nint num = (nint)typeof(Vector4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v20 (Il2CppClass<UnityEngine.Vector4>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v21 (Il2CppStaticFields<UnityEngine.Vector4>)+8]");
		_ = 0;
		mBorder = Vector4.zeroVector;
		mPMA = -1;
		base._002Ector();
	}
}
