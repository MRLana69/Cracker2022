using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public class UI2DSprite : UIBasicSprite
{
	private Sprite mSprite;

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
			//IL_0049: Expected Obj, but got I4
			//IL_003b: Expected Obj, but got I4
			float tweenFactor = ((UITweener)(object)this).tweenFactor;
			if (tweenFactor < 0f)
			{
				return (Sprite)(-1);
			}
			return (Sprite)1;
		}
		set
		{
			//IL_00a8: Expected I, but got Obj
			//IL_00be: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0077: Expected Obj, but got I4
			//IL_007d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0082: Expected Obj, but got Unknown
			//IL_008b: Expected Obj, but got I4
			float tweenFactor = ((UITweener)(object)this).tweenFactor;
			nint num = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v25 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float num3 = Math.Abs(tweenFactor);
			finalAlpha = num3;
			if ((object)value == null)
			{
				float num4 = 0f - finalAlpha;
				finalAlpha = num4;
			}
			if (!isActiveAndEnabled)
			{
				tag = (string)1;
				object obj2 = this - -64;
				obj2 = 0;
			}
			((UITweener)(object)this).OnDisable();
		}
	}

	public override Material material
	{
		get
		{
			return (Material)(object)mSprite;
		}
		set
		{
			//IL_009d: Expected I, but got Obj
			//IL_00b3: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Expected Obj, but got Unknown
			//IL_0071: Unknown result type (might be due to invalid IL or missing references)
			//IL_0076: Expected Obj, but got Unknown
			//IL_007f: Expected Obj, but got I4
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v15 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)mSprite).FindKernel((string)(object)value) != 0)
			{
				base.MarkAsChanged();
				object obj2 = this + 396;
				obj2 = value;
				object obj3 = this + 428;
				obj3 = 0;
				int num3 = ((UIWidget)this).minWidth;
			}
		}
	}

	public override Shader shader
	{
		get
		{
			return (Shader)(object)mMat;
		}
		set
		{
			//IL_0094: Expected I, but got Obj
			//IL_00aa: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Expected Obj, but got Unknown
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v14 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)mMat).FindKernel((string)(object)value) != 0)
			{
				base.MarkAsChanged();
				object obj2 = this + 112;
				obj2 = value;
				mPMA = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
			}
		}
	}

	public override Texture mainTexture
	{
		get
		{
			//IL_0128: Expected I, but got Obj
			//IL_013e: Expected Obj, but got I
			//IL_0074: Expected I, but got Obj
			//IL_008a: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_00b5: Expected I, but got Obj
			//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ff: Expected Obj, but got Unknown
			//IL_0115: Expected Obj, but got I4
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v25 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)mMat).FindKernel((string)null) != 0)
			{
				return mMat.mainTexture;
			}
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S1_v20 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (mShader != null)
			{
				object obj3 = this + 400;
				int num5 = Shader.PropertyToID("Unlit/Transparent Colored");
				obj3 = num5;
			}
			return (Texture)(object)mShader;
		}
	}

	public bool fixedAspect
	{
		get
		{
			//IL_0134: Expected I, but got Obj
			//IL_014a: Expected Obj, but got I
			//IL_007c: Expected I, but got Obj
			//IL_0092: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0069: Expected I4, but got Obj
			//IL_00bd: Expected I, but got Obj
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v21 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)mSprite).FindKernel((string)null) != 0)
			{
				Texture2D associatedAlphaSplitTexture = mSprite.associatedAlphaSplitTexture;
				return (byte)(int)associatedAlphaSplitTexture != 0;
			}
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S1_v16 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)mMat).FindKernel((string)null) != 0)
			{
				return (byte)mMat.renderQueue != 0;
			}
			return false;
		}
		set
		{
			//IL_0121: Expected I, but got Obj
			//IL_0137: Expected Obj, but got I
			//IL_018d: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Expected Obj, but got Unknown
			//IL_006b: Expected Obj, but got I4
			//IL_0079: Expected I, but got Obj
			//IL_008f: Expected Obj, but got I
			//IL_00ba: Expected I, but got Obj
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v24 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)mShader).FindKernel((string)value) == 0)
			{
				return;
			}
			base.MarkAsChanged();
			object obj2 = this + 400;
			obj2 = value;
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S1_v20 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (mMat != null)
			{
				mPMA = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
			}
		}
	}

	public override bool premultipliedAlpha => mFixedAspect;

	public override float pixelSize
	{
		get
		{
			//IL_0007: Expected F4, but got VT
			return (float)mColor;
		}
	}

	public override Vector4 drawingDimensions
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Expected Obj, but got Unknown
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Expected Obj, but got Unknown
			//IL_0068: Expected Obj, but got I4
			//IL_0077: Expected Obj, but got F4
			//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ac: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector4)+1A4]");
			bool flag = (nint)0 != 0;
			object obj3 = flag ^ this;
			Vector4 vector = default;
			if (obj3 != null)
			{
				object obj4 = this & 1;
				obj2 = 0;
				_ = 0;
				obj2 = 0f;
				_ = 0f;
				_ = 1f;
				_ = 1f;
				obj = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				_ = 0;
				object obj5 = vector + 156;
				obj5 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
			}
			return vector;
		}
	}

	public unsafe override Vector4 border
	{
		get
		{
			//IL_0688: Unknown result type (might be due to invalid IL or missing references)
			//IL_068d: Expected Obj, but got Unknown
			//IL_0696: Expected Obj, but got I4
			//IL_06a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_06aa: Expected Obj, but got Unknown
			//IL_06b3: Expected Obj, but got I4
			//IL_06c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_06c7: Expected Obj, but got Unknown
			//IL_06d1: Expected I4, but got Obj
			//IL_06dd: Unsupported input type for neg.
			//IL_06dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_06e2: Expected Obj, but got Unknown
			//IL_0715: Expected Obj, but got I
			//IL_0745: Expected I, but got Obj
			//IL_075b: Expected Obj, but got I
			//IL_0781: Unknown result type (might be due to invalid IL or missing references)
			//IL_0786: Expected Obj, but got Unknown
			//IL_078f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0794: Expected Obj, but got Unknown
			//IL_079d: Unknown result type (might be due to invalid IL or missing references)
			//IL_07a2: Expected Obj, but got Unknown
			//IL_07ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_07b0: Expected Obj, but got Unknown
			//IL_07b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_07be: Expected Obj, but got Unknown
			//IL_07c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_07cc: Expected Obj, but got Unknown
			//IL_07d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_07da: Expected Obj, but got Unknown
			//IL_07e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_07e8: Expected Obj, but got Unknown
			//IL_0013: Expected I, but got Obj
			//IL_0526: Expected I, but got Obj
			//IL_053c: Expected Obj, but got I
			//IL_09dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_09e2: Expected Obj, but got Unknown
			//IL_09f0: Expected I, but got Obj
			//IL_0a06: Expected Obj, but got I
			//IL_00ce: Expected I, but got Obj
			//IL_00e4: Expected Obj, but got I
			//IL_0567: Expected I, but got Obj
			//IL_0bb1: Expected F4, but got Obj
			//IL_0bca: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bcf: Expected Obj, but got Unknown
			//IL_0be8: Expected F4, but got I
			//IL_0c01: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c06: Expected Obj, but got Unknown
			//IL_0c1f: Expected F4, but got I
			//IL_0846: Expected F4, but got I
			//IL_087f: Expected F4, but got I
			//IL_0608: Unknown result type (might be due to invalid IL or missing references)
			//IL_060d: Expected Obj, but got Unknown
			//IL_0626: Expected F4, but got I
			//IL_0633: Expected native int or pointer, but got VT
			//IL_0641: Expected native int or pointer, but got VT
			//IL_064e: Expected native int or pointer, but got VT
			//IL_065b: Expected native int or pointer, but got VT
			//IL_0668: Expected native int or pointer, but got VT
			//IL_0675: Expected native int or pointer, but got VT
			//IL_05b4: Expected I, but got Obj
			//IL_0166: Expected F4, but got Obj
			//IL_010f: Expected I, but got Obj
			//IL_018f: Expected F4, but got I
			//IL_0211: Expected Obj, but got I
			//IL_02ab: Expected Obj, but got I
			//IL_02ff: Expected Obj, but got I4
			//IL_0891: Unknown result type (might be due to invalid IL or missing references)
			//IL_0896: Expected Obj, but got Unknown
			//IL_0b06: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b0b: Expected Obj, but got Unknown
			//IL_03bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c4: Expected Obj, but got Unknown
			//IL_03da: Unknown result type (might be due to invalid IL or missing references)
			//IL_03df: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 160;
			obj = 0;
			_ = 0;
			object obj3 = obj2 + 144;
			obj3 = 0;
			_ = 0;
			UIWidget uIWidget = (UIWidget)(obj2 + 16);
			uIWidget.width = (int)this;
			obj2 = uIWidget;
			object obj4 = 0 - obj2;
			float num = (float)obj4 * (float)mWidth;
			float num2 = num + (float)mWidth;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj5 = -0;
			float num3 = (float)obj5 * (float)mHeight;
			float num4 = num3 + (float)mHeight;
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v30 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v216 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Sprite sprite = (Sprite)(obj2 + 128);
			Sprite sprite2 = (Sprite)(obj2 + 112);
			object obj7 = obj2 + 96;
			object obj8 = obj2 + 80;
			Sprite sprite3 = (Sprite)(obj2 + 72);
			object obj9 = obj2 + 56;
			object obj10 = obj2 + 40;
			Sprite sprite4 = (Sprite)(obj2 + 32);
			int num7 = ((ComputeShader)(object)mSprite).FindKernel((string)null);
			bool flag = num7 == 0;
			float num8 = num4;
			float num9 = num3;
			float num10 = num2;
			float num11 = num;
			if (!flag)
			{
				bool flag2 = mType != Type.Tiled;
				bool flag3 = !flag2;
				num8 = num4;
				num9 = num3;
				num10 = num2;
				num11 = num;
				if (!flag3)
				{
					Vector4 vector = mSprite.border;
					obj = uIWidget;
					_ = ((UnityEngine.Object)uIWidget).m_CachedPtr;
					nint num12 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S1_v85 (Il2CppClass<UnityEngine.Mathf>)+BA]");
					object obj11 = (nint)0 & (nint)0x200;
					if (obj11 != null)
					{
						nint num13 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ S1_v167 (Il2CppClass<UnityEngine.Mathf>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
					GUILayoutOption gUILayoutOption = GUILayout.Width(0f);
					Vector4 vector2 = mSprite.border;
					obj = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+C]");
					GUILayoutOption gUILayoutOption2 = GUILayout.Width(0f);
					sprite.GetTextureRect_Injected(out *(Rect*)mSprite);
					GUILayoutOption gUILayoutOption3 = GUILayout.Width((float)sprite);
					sprite2.GetTextureRect_Injected(out *(Rect*)mSprite);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v37 (UnityEngine.Sprite)+4]");
					GUILayoutOption gUILayoutOption4 = GUILayout.Width(0f);
					Vector4 vector3 = mSprite.border;
					obj = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v39+8]");
					_ = 0;
					Vector2 textureRectOffset = mSprite.textureRectOffset;
					obj = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v41+8]");
					_ = 0;
					sprite3.GetTextureRect_Injected(out *(Rect*)mSprite);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
					nint num14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
					object obj12 = num14 - 0;
					float num15 = (float)obj12 - (float)sprite3;
					GUILayoutOption gUILayoutOption5 = GUILayout.Width(num15);
					Vector4 vector4 = mSprite.border;
					obj = obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v45+8]");
					_ = 0;
					Vector2 textureRectOffset2 = mSprite.textureRectOffset;
					obj = obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v47+8]");
					_ = 0;
					sprite4.GetTextureRect_Injected(out *(Rect*)mSprite);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+C]");
					nint num16 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+C]");
					object obj13 = num16 - 0;
					float num17 = (float)obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v49 (UnityEngine.Sprite)+4]");
					float num18 = num17 - 0f;
					GUILayoutOption gUILayoutOption6 = GUILayout.Width(num18);
					bool flag4 = (nint)gUILayoutOption < 1;
					bool flag5 = (nint)gUILayoutOption2 < 1;
					object obj14 = flag4 | flag5;
					float num19;
					GUILayoutOption gUILayoutOption7;
					GUILayoutOption gUILayoutOption8;
					float num20;
					if (obj14 != null)
					{
						num19 = 1f;
						gUILayoutOption7 = gUILayoutOption6;
						gUILayoutOption8 = gUILayoutOption5;
						num20 = 1f;
					}
					else if (mType != Type.Simple && mType != Type.Filled)
					{
						num19 = 1f;
						gUILayoutOption7 = gUILayoutOption6;
						gUILayoutOption8 = gUILayoutOption5;
						num20 = 1f;
					}
					else
					{
						object obj15 = gUILayoutOption & 1;
						bool flag6 = obj15 == null;
						gUILayoutOption8 = gUILayoutOption5;
						if (!flag6)
						{
							GUILayoutOption gUILayoutOption9 = (GUILayoutOption)(gUILayoutOption5 + 1);
							gUILayoutOption8 = gUILayoutOption9;
						}
						object obj16 = gUILayoutOption2 & 1;
						bool flag7 = obj16 == null;
						gUILayoutOption7 = gUILayoutOption6;
						if (!flag7)
						{
							GUILayoutOption gUILayoutOption10 = (GUILayoutOption)(gUILayoutOption6 + 1);
							gUILayoutOption7 = gUILayoutOption10;
						}
						float num21 = 1f / (float)gUILayoutOption;
						float num22 = num21 * (float)mWidth;
						float num23 = 1f / (float)gUILayoutOption2;
						num20 = num23 * (float)mHeight;
						num19 = num22;
					}
					GUILayoutOption gUILayoutOption11;
					if (mFlip == Flip.Horizontally)
					{
						gUILayoutOption11 = gUILayoutOption8;
						gUILayoutOption8 = gUILayoutOption3;
					}
					else
					{
						bool flag8 = mFlip == Flip.Both;
						GUILayoutOption gUILayoutOption12 = ((!flag8) ? gUILayoutOption3 : gUILayoutOption8);
						bool flag9 = !flag8;
						gUILayoutOption11 = gUILayoutOption12;
						if (!flag9)
						{
							gUILayoutOption11 = gUILayoutOption12;
							gUILayoutOption8 = gUILayoutOption3;
						}
					}
					float num24 = (float)gUILayoutOption11 * num19;
					float num25 = num + num24;
					float num26 = (float)gUILayoutOption8 * num19;
					float num27 = num2 - num26;
					if (mFlip != Flip.Vertically && mFlip != Flip.Both)
					{
						float num28 = (float)gUILayoutOption4 * num20;
						float num29 = num3 + num28;
						float num30 = (float)gUILayoutOption7 * num20;
						float num31 = num4 - num30;
						num8 = num31;
						num9 = num29;
						num10 = num27;
						num11 = num25;
					}
					else
					{
						float num32 = (float)gUILayoutOption7 * num20;
						float num33 = num3 + num32;
						float num34 = (float)gUILayoutOption4 * num20;
						float num35 = num4 - num34;
						num8 = num35;
						num9 = num33;
						num10 = num27;
						num11 = num25;
					}
				}
			}
			float num36;
			float num37;
			if (~(mFixedAspect ? 1u : 0u) == 0)
			{
				num36 = 0f;
				num37 = 0f;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @892A");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76C9");
				nint num38 = (nint)typeof(Vector4);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ S0_v89 (Il2CppClass<UnityEngine.Vector4>)+BA]");
				object obj17 = (nint)0 & (nint)0x200;
				if (obj17 != null)
				{
					nint num39 = (nint)typeof(Vector4);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ S0_v108 (Il2CppClass<UnityEngine.Vector4>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				uIWidget = (UIWidget)obj2;
				UIWidget uIWidget2 = uIWidget;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				((UnityEngine.Object)uIWidget2).m_CachedPtr = (IntPtr)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F51F");
				obj3 = sprite;
				_ = ((UnityEngine.Object)sprite).m_CachedPtr;
				uIWidget = (UIWidget)(object)sprite;
				((UnityEngine.Object)uIWidget).m_CachedPtr = ((UnityEngine.Object)sprite).m_CachedPtr;
				sprite2 = (Sprite)obj3;
				Sprite sprite5 = sprite2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
				((UnityEngine.Object)sprite5).m_CachedPtr = (IntPtr)0;
				float num40 = (float)uIWidget + (float)(nint)((UnityEngine.Object)sprite2).m_CachedPtr;
				obj7 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
				_ = 0;
				obj8 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v39+4]");
				float num41 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v41+C]");
				num37 = num41 + 0f;
				num36 = num40;
			}
			object obj18 = this + 156;
			nint num42 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ S0_v60 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj19 = (nint)0 & (nint)0x200;
			if (obj19 != null)
			{
				nint num43 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ S0_v81 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float b = num10 - num36;
			float x = Mathf.LerpUnclamped(num11, b, (float)obj18);
			float b2 = num8 - num37;
			object obj20 = this + 156;
			float a = num9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ S2_v9+4]");
			float y = Mathf.LerpUnclamped(a, b2, 0f);
			float a2 = num11 + num36;
			object obj21 = this + 156;
			float b3 = num10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ S2_v12+8]");
			float z = Mathf.LerpUnclamped(a2, b3, 0f);
			float a3 = num9 + num37;
			object obj22 = this + 156;
			float b4 = num8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ S2_v15+C]");
			float w = Mathf.LerpUnclamped(a3, b4, 0f);
			Vector4 vector5 = default;
			((Vector4*)(nint)vector5)->x = 0f;
			((Vector4*)(nint)vector5)->z = 0f;
			((Vector4*)(nint)vector5)->x = x;
			((Vector4*)(nint)vector5)->y = y;
			((Vector4*)(nint)vector5)->z = z;
			((Vector4*)(nint)vector5)->w = w;
			return vector5;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			object obj = value + 404;
			UI2DSprite uI2DSprite = (UI2DSprite)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v2+8]");
			((UnityEngine.Object)this).m_CachedPtr = (IntPtr)0;
		}
	}

	protected override void OnUpdate()
	{
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected Obj, but got Unknown
		//IL_0116: Expected Obj, but got I4
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected Obj, but got Unknown
		//IL_000e: Expected Obj, but got I4
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected Obj, but got Unknown
		//IL_00a2: Expected Obj, but got I4
		//IL_00ad: Expected Obj, but got F4
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected Obj, but got Unknown
		//IL_00e3: Expected Obj, but got F4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj2 = default;
		object obj = obj2 + 28;
		obj = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F64A");
		object obj3 = obj2 + 56;
		obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v12+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v12+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v12+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @752D");
		obj2 = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F64A");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @752D");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		AnimationCurve animationCurve = default;
		Keyframe[] keys = default;
		animationCurve.keys = keys;
		object obj4 = this + 20;
		obj4 = animationCurve;
		topAnchor = (AnchorPoint)1;
		mGo = (GameObject)1f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<EventDelegate> list = default;
		list._002Ector();
		object obj5 = this + 48;
		obj5 = list;
		((UIRect)this).mParent = (UIRect)1f;
		finalAlpha = 1000f;
		CancelInvoke();
	}

	public unsafe override void MakePixelPerfect()
	{
		//IL_054d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0552: Expected Obj, but got Unknown
		//IL_055b: Expected Obj, but got I4
		//IL_056f: Expected I, but got Obj
		//IL_0585: Expected Obj, but got I
		//IL_05ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b0: Expected Obj, but got Unknown
		//IL_05b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05be: Expected Obj, but got Unknown
		//IL_05c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cc: Expected Obj, but got Unknown
		//IL_05d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05da: Expected Obj, but got Unknown
		//IL_05e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e8: Expected Obj, but got Unknown
		//IL_05f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f6: Expected Obj, but got Unknown
		//IL_05ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0604: Expected Obj, but got Unknown
		//IL_060d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0612: Expected Obj, but got Unknown
		//IL_061b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0620: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0122: Expected I, but got Obj
		//IL_0138: Expected Obj, but got I
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected Obj, but got Unknown
		//IL_0105: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		//IL_0163: Expected I, but got Obj
		//IL_01d1: Expected I, but got Obj
		//IL_01e7: Expected Obj, but got I
		//IL_06ae: Expected F4, but got I
		//IL_06e7: Expected F4, but got I
		//IL_0269: Expected F4, but got Obj
		//IL_0212: Expected I, but got Obj
		//IL_0292: Expected F4, but got I
		//IL_0314: Expected Obj, but got I
		//IL_03c8: Expected Obj, but got I
		//IL_04d3: Expected Obj, but got I4
		//IL_04e2: Expected Obj, but got F4
		//IL_04ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f1: Expected I4, but got Unknown
		//IL_0500: Expected Obj, but got I4
		//IL_050a: Unknown result type (might be due to invalid IL or missing references)
		//IL_050f: Expected I4, but got Unknown
		//IL_0459: Expected Obj, but got I4
		//IL_0469: Unknown result type (might be due to invalid IL or missing references)
		//IL_046e: Expected Obj, but got Unknown
		//IL_0478: Unknown result type (might be due to invalid IL or missing references)
		//IL_047d: Expected Obj, but got Unknown
		//IL_0487: Unknown result type (might be due to invalid IL or missing references)
		//IL_048c: Expected I4, but got Unknown
		//IL_04a4: Expected Obj, but got F4
		Sprite sprite = default;
		object obj = sprite + 112;
		obj = 0;
		_ = 0;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v7 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v130 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)nextSprite).FindKernel((string)null) != 0)
		{
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S2_v54 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S2_v61 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)nextSprite).FindKernel((string)(object)mSprite) != 0)
			{
				material = (Material)(object)nextSprite;
			}
			object obj4 = this + 428;
			obj4 = 0;
		}
		UIWidget uIWidget = (UIWidget)(sprite + 128);
		object obj5 = sprite + 96;
		Sprite sprite2 = (Sprite)(sprite + 88);
		Sprite sprite3 = (Sprite)(sprite + 80);
		object obj6 = sprite - -64;
		object obj7 = sprite + 48;
		Sprite sprite4 = (Sprite)(sprite + 40);
		object obj8 = sprite + 24;
		object obj9 = sprite + 8;
		base.OnDisable();
		if (~(mFixedAspect ? 1u : 0u) != 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S1_v26 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S1_v119 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		ComputeShader computeShader = default;
		if (computeShader.FindKernel(null) == 0)
		{
			return;
		}
		Vector4 vector = mSprite.border;
		obj = uIWidget;
		_ = ((UnityEngine.Object)uIWidget).m_CachedPtr;
		nint num7 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ S1_v38 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num8 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ S1_v115 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		GUILayoutOption gUILayoutOption = GUILayout.Width(0f);
		Vector4 vector2 = mSprite.border;
		obj = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v18+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+C]");
		GUILayoutOption gUILayoutOption2 = GUILayout.Width(0f);
		sprite2.GetTextureRect_Injected(out *(Rect*)mSprite);
		GUILayoutOption gUILayoutOption3 = GUILayout.Width((float)sprite2);
		sprite3.GetTextureRect_Injected(out *(Rect*)mSprite);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v22 (UnityEngine.Sprite)+4]");
		GUILayoutOption gUILayoutOption4 = GUILayout.Width(0f);
		Vector4 vector3 = mSprite.border;
		obj = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v24+8]");
		_ = 0;
		Vector2 textureRectOffset = mSprite.textureRectOffset;
		obj = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v26+8]");
		_ = 0;
		sprite4.GetTextureRect_Injected(out *(Rect*)mSprite);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		nint num9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		object obj12 = num9 - 0;
		float num10 = (float)obj12 - (float)sprite4;
		GUILayoutOption gUILayoutOption5 = GUILayout.Width(num10);
		Vector4 vector4 = mSprite.border;
		obj = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v30+8]");
		_ = 0;
		Vector2 textureRectOffset2 = mSprite.textureRectOffset;
		obj = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v32+8]");
		_ = 0;
		sprite.GetTextureRect_Injected(out *(Rect*)mSprite);
		object obj13 = (object)gUILayoutOption5 + (object)gUILayoutOption3;
		object obj14 = obj13 + (object)gUILayoutOption;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+C]");
		nint num11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+C]");
		object obj15 = num11 - 0;
		float num12 = (float)obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (UnityEngine.Sprite)+4]");
		float num13 = num12 - 0f;
		GUILayoutOption gUILayoutOption6 = GUILayout.Width(num13);
		object obj16 = (object)gUILayoutOption4 + (object)gUILayoutOption6;
		object obj17 = obj16 + (object)gUILayoutOption2;
		object obj18 = obj14 / obj17;
		int num14 = mWidth / mHeight;
		if ((nint)obj18 < num14)
		{
			obj5 = 0;
			_ = 0;
			object obj19 = mHeight * obj18;
			object obj20 = mWidth - obj19;
			int num15 = obj20 / mWidth;
			float num16 = (float)num15 * 0.5f;
			obj5 = num16;
			_ = 0f;
			float num17 = 1f - num16;
			_ = 1f;
		}
		else
		{
			obj5 = 0;
			_ = 0;
			obj5 = 0f;
			int num18 = mWidth / obj18;
			object obj21 = mHeight - num18;
			int num19 = obj21 / mHeight;
			float num20 = (float)num19 * 0.5f;
			_ = 1f;
			float num21 = 1f - num20;
		}
		uIWidget = (UIWidget)obj5;
		UIWidget uIWidget2 = uIWidget;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v18+8]");
		((UnityEngine.Object)uIWidget2).m_CachedPtr = (IntPtr)0;
		Vector2 vector5 = uIWidget.pivotOffset;
	}

	public unsafe override void OnFill(List<Vector3> verts, List<Vector2> uvs, List<Color> cols)
	{
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected VT, but got Unknown
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected Obj, but got Unknown
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected Obj, but got Unknown
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected Obj, but got Unknown
		//IL_01a3: Expected Obj, but got I4
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected VT, but got Unknown
		//IL_01ce: Expected Obj, but got F4
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Expected Obj, but got Unknown
		//IL_00bf: Expected F4, but got Obj
		//IL_00ba: Expected native int or pointer, but got VT
		//IL_00d4: Expected F4, but got I
		//IL_00cf: Expected native int or pointer, but got VT
		//IL_00e2: Expected I, but got Obj
		//IL_00f8: Expected Obj, but got I
		//IL_02b9: Expected native int or pointer, but got VT
		//IL_02cb: Expected native int or pointer, but got VT
		//IL_02de: Expected F4, but got Obj
		//IL_02de: Expected I4, but got VT
		//IL_0032: Expected I, but got Obj
		//IL_0048: Expected Obj, but got I
		//IL_0123: Expected I, but got Obj
		//IL_0200: Expected F4, but got Obj
		//IL_01fb: Expected native int or pointer, but got VT
		//IL_0215: Expected F4, but got I
		//IL_0210: Expected native int or pointer, but got VT
		//IL_0222: Expected F4, but got Obj
		//IL_021d: Expected native int or pointer, but got VT
		//IL_0237: Expected F4, but got I
		//IL_0232: Expected native int or pointer, but got VT
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Expected Obj, but got Unknown
		//IL_0073: Expected I, but got Obj
		object obj = default;
		Vector3 vector = (Vector3)(obj + 48);
		object obj2 = obj + 24;
		object obj3 = obj + 12;
		object obj4 = obj + 36;
		obj4 = 0;
		_ = 0;
		Vector3 vector2 = (Vector3)(obj + 60);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8873");
		obj4 = vector2.x;
		_ = vector2.z;
		object obj5 = uvs + 1;
		object obj6 = obj5;
		while (true)
		{
			object obj7 = (object)cols + (object)uvs;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7))
			{
				break;
			}
			obj2 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8873");
			nint num = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v45 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num2 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v58 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Vector3*)(nint)vector)->x = (float)obj2;
			Vector3 vector3 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
			((Vector3*)(nint)vector3)->z = 0f;
			((Vector3*)(nint)vector2)->x = (float)obj3;
			Vector3 vector4 = vector2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
			((Vector3*)(nint)vector4)->z = 0f;
			Vector3 vector5 = vector - vector2;
			obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			object obj9 = obj6 + 1;
			obj6 = obj9;
		}
		((Vector3*)(nint)vector)->x = (float)obj4;
		Vector3 vector6 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
		((Vector3*)(nint)vector6)->z = 0f;
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v29 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num4 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v37 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Vector3*)(nint)vector2)->x = vector.x;
		((Vector3*)(nint)vector2)->z = vector.z;
		((Vector2*)this)->set_Item((int)vector2, (float)cols);
	}

	public UI2DSprite()
	{
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected Obj, but got Unknown
		//IL_028f: Expected Obj, but got I4
		//IL_001d: Expected I, but got Obj
		//IL_0033: Expected Obj, but got I
		//IL_005e: Expected I, but got Obj
		//IL_0308: Expected I, but got Obj
		//IL_031e: Expected Obj, but got I
		//IL_010f: Expected I, but got Obj
		//IL_018f: Expected I, but got Obj
		//IL_01a5: Expected Obj, but got I
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Expected Obj, but got Unknown
		//IL_01d0: Expected I, but got Obj
		//IL_039c: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Expected Obj, but got Unknown
		//IL_03fb: Expected I4, but got Obj
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected Obj, but got Unknown
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj = 0;
		_ = 0;
		AdaptScale();
		if (mType == Type.Tiled)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v20 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v69 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UnityEngine.Object obj4 = default;
		if (obj4 != null || (mType != Type.Simple && mType != Type.Filled && base.premultipliedAlpha))
		{
			return;
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v31 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v60 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)obj4).FindKernel((string)null) == 0)
		{
			return;
		}
		Vector4 vector = mSprite.border;
		obj = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76C9");
		nint num5 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S2_v6 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num6 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S2_v12 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj7 = default;
		float num7 = (float)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		float num8 = num7 * 0f;
		GUILayoutOption gUILayoutOption = GUILayout.Width(num8);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76C9");
		object obj8 = default;
		float num9 = (float)obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+C]");
		float num10 = num9 * 0f;
		GUILayoutOption gUILayoutOption2 = GUILayout.Width(num10);
		object obj9 = gUILayoutOption & 1;
		bool flag = obj9 == null;
		GUILayoutOption gUILayoutOption3 = gUILayoutOption;
		if (!flag)
		{
			GUILayoutOption gUILayoutOption4 = (GUILayoutOption)(gUILayoutOption + 1);
			gUILayoutOption3 = gUILayoutOption4;
		}
		object obj10 = gUILayoutOption2 & 1;
		bool flag2 = obj10 == null;
		GUILayoutOption gUILayoutOption5 = gUILayoutOption2;
		if (!flag2)
		{
			GUILayoutOption gUILayoutOption6 = (GUILayoutOption)(gUILayoutOption2 + 1);
			gUILayoutOption5 = gUILayoutOption6;
		}
		height = (int)gUILayoutOption3;
		Color color = ((UIWidget)(object)gUILayoutOption5).color;
	}
}
