using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Kiloo.Common.Extensions;
using UnityEngine;
using UnityEngine.Networking.PlayerConnection;

public class UISprite : UIBasicSprite
{
	private UIAtlas mAtlas;

	private string mSpriteName;

	private bool mFillCenter;

	[NonSerialized]
	protected UISpriteData mSprite;

	[NonSerialized]
	private bool mSpriteSet;

	public override Texture mainTexture
	{
		get
		{
			//IL_056e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0573: Expected Obj, but got Unknown
			//IL_057c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0581: Expected Obj, but got Unknown
			//IL_058a: Unknown result type (might be due to invalid IL or missing references)
			//IL_058f: Expected Obj, but got Unknown
			//IL_0598: Unknown result type (might be due to invalid IL or missing references)
			//IL_059d: Expected Obj, but got Unknown
			//IL_05a6: Expected Obj, but got I4
			//IL_0366: Expected I, but got Obj
			//IL_037c: Expected Obj, but got I
			//IL_070a: Unknown result type (might be due to invalid IL or missing references)
			//IL_070f: Expected Obj, but got Unknown
			//IL_03a7: Expected I, but got Obj
			//IL_005e: Expected I, but got Obj
			//IL_0074: Expected Obj, but got I
			//IL_0405: Unknown result type (might be due to invalid IL or missing references)
			//IL_040a: Expected Obj, but got Unknown
			//IL_0625: Unknown result type (might be due to invalid IL or missing references)
			//IL_062a: Expected Obj, but got Unknown
			//IL_04fc: Expected F4, but got I
			//IL_046f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0474: Expected Obj, but got Unknown
			//IL_009f: Expected I, but got Obj
			//IL_077b: Expected I, but got Obj
			//IL_0791: Expected Obj, but got I
			//IL_016c: Expected I, but got Obj
			//IL_0182: Expected Obj, but got I
			//IL_050f: Expected I, but got Obj
			//IL_01ad: Expected I, but got Obj
			//IL_023b: Expected I, but got Obj
			//IL_0251: Expected Obj, but got I
			//IL_02c9: Expected I, but got Obj
			//IL_02df: Expected Obj, but got I
			//IL_027c: Expected I, but got Obj
			//IL_030a: Expected I, but got Obj
			object obj = default;
			PropertyBinding propertyBinding = (PropertyBinding)(obj + 24);
			object obj2 = obj + 16;
			object obj3 = obj + 8;
			object obj4 = obj + 32;
			obj4 = 0;
			AnchorPoint anchorPoint = leftAnchor;
			if ((nint)leftAnchor == 2)
			{
				anchorPoint = null;
			}
			Texture result;
			if (anchorPoint != null)
			{
				UIRoot.Scaling activeScaling = ((UIRoot)(object)this).activeScaling;
				if (activeScaling == (UIRoot.Scaling)3)
				{
					result = (Texture)(object)bottomAnchor;
				}
				else
				{
					nint num = (nint)typeof(NGUITools);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v79 (Il2CppClass<NGUITools>)+BA]");
					object obj5 = (nint)0 & (nint)0x200;
					if (obj5 != null)
					{
						nint num2 = (nint)typeof(NGUITools);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S0_v116 (Il2CppClass<NGUITools>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					propertyBinding.Start();
					obj2 = propertyBinding;
					obj3 = propertyBinding;
					object obj6 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+4]");
					object obj7 = obj6 / 0;
					object obj8 = (object)rightAnchor / (object)bottomAnchor;
					switch (activeScaling)
					{
					case UIRoot.Scaling.Flexible:
					{
						if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7))
						{
							result = (Texture)(object)bottomAnchor;
							break;
						}
						nint num9 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ S1_v75 (Il2CppClass<UnityEngine.Mathf>)+BA]");
						object obj11 = (nint)0 & (nint)0x200;
						if (obj11 != null)
						{
							nint num10 = (nint)typeof(Mathf);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ S1_v81 (Il2CppClass<UnityEngine.Mathf>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						float num11 = (float)rightAnchor / (float)obj7;
						GUILayoutOption gUILayoutOption3 = GUILayout.Width(num11);
						result = (Texture)(object)gUILayoutOption3;
						break;
					}
					case UIRoot.Scaling.Constrained:
					{
						if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7))
						{
							result = (Texture)(object)bottomAnchor;
							break;
						}
						nint num6 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ S1_v87 (Il2CppClass<UnityEngine.Mathf>)+BA]");
						object obj10 = (nint)0 & (nint)0x200;
						if (obj10 != null)
						{
							nint num7 = (nint)typeof(Mathf);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ S1_v93 (Il2CppClass<UnityEngine.Mathf>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						float num8 = (float)rightAnchor / (float)obj7;
						GUILayoutOption gUILayoutOption2 = GUILayout.Width(num8);
						result = (Texture)(object)gUILayoutOption2;
						break;
					}
					case UIRoot.Scaling.ConstrainedOnMobiles:
					{
						nint num3 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ S1_v98 (Il2CppClass<UnityEngine.Mathf>)+BA]");
						object obj9 = (nint)0 & (nint)0x200;
						if (obj9 != null)
						{
							nint num4 = (nint)typeof(Mathf);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ S1_v104 (Il2CppClass<UnityEngine.Mathf>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						float num5 = (float)rightAnchor / (float)obj7;
						GUILayoutOption gUILayoutOption = GUILayout.Width(num5);
						result = (Texture)(object)gUILayoutOption;
						break;
					}
					default:
						result = (Texture)(object)bottomAnchor;
						break;
					}
				}
				goto IL_05f7;
			}
			nint num12 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v24 (Il2CppClass<NGUITools>)+BA]");
			object obj12 = (nint)0 & (nint)0x200;
			if (obj12 != null)
			{
				nint num13 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v71 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			propertyBinding.Start();
			obj4 = propertyBinding;
			obj2 = propertyBinding;
			obj3 = propertyBinding;
			object obj13 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+4]");
			object obj14 = obj13 / 0;
			obj = propertyBinding;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			if (0 < (nint)topAnchor)
			{
				_ = topAnchor;
				propertyBinding = (PropertyBinding)obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (PropertyBinding)+4]");
				object obj15 = 0 * obj14;
				obj4 = obj15;
			}
			else
			{
				propertyBinding = propertyBinding;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (PropertyBinding)+4]");
				if ((nint)0 > (nint)updateAnchors)
				{
					_ = updateAnchors;
					propertyBinding = (PropertyBinding)obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (PropertyBinding)+4]");
					object obj16 = 0 * obj14;
					obj4 = obj16;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UISprite)+23]");
			float num14;
			if ((nint)0 != 0)
			{
				propertyBinding = (PropertyBinding)obj4;
				obj2 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (PropertyBinding)+4]");
				if (0 > (nint)obj2)
				{
					propertyBinding = (PropertyBinding)obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (PropertyBinding)+4]");
					num14 = 0f / (float)obj14;
					goto IL_076d;
				}
			}
			propertyBinding = (PropertyBinding)obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (PropertyBinding)+4]");
			num14 = 0f;
			goto IL_076d;
			IL_05f7:
			return result;
			IL_076d:
			nint num15 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ S1_v24 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj17 = (nint)0 & (nint)0x200;
			if (obj17 != null)
			{
				nint num16 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ S1_v30 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			GUILayoutOption gUILayoutOption4 = GUILayout.Width(num14);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UISprite)+22]");
			bool flag = (nint)0 == 0;
			result = (Texture)(object)gUILayoutOption4;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B73A");
				Texture texture = default;
				result = texture;
			}
			goto IL_05f7;
		}
		set
		{
			//IL_02d2: Expected I, but got Obj
			//IL_02e8: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0029: Expected Obj, but got I
			//IL_01a9: Expected I, but got Obj
			//IL_0054: Expected I, but got Obj
			//IL_00a1: Expected I, but got Obj
			//IL_00b7: Expected Obj, but got I
			//IL_0233: Expected I, but got Obj
			//IL_0249: Expected Obj, but got I
			//IL_00e2: Expected I, but got Obj
			//IL_012f: Expected I, but got Obj
			if ((object)value != null)
			{
				nint num = (nint)typeof(UIRoot);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v19 (Il2CppClass<UIRoot>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num2 = (nint)typeof(UIRoot);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v62 (Il2CppClass<UIRoot>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				List<UIRoot> list = UIRoot.list;
				int num3 = default;
				int num8 = default;
				while (num3 < list._size)
				{
					nint num4 = (nint)typeof(UIRoot);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v33 (Il2CppClass<UIRoot>)+BA]");
					object obj2 = (nint)0 & (nint)0x200;
					if (obj2 != null)
					{
						nint num5 = (nint)typeof(UIRoot);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v56 (Il2CppClass<UIRoot>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					UIRoot uIRoot = UIRoot.list.get_Item(num3);
					nint num6 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S0_v42 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj3 = (nint)0 & (nint)0x200;
					if (obj3 != null)
					{
						nint num7 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v52 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (((ComputeShader)(object)uIRoot).FindKernel((string)null) != 0)
					{
						((GameObject)(object)uIRoot).SendMessage((string)(object)this, (object)value, SendMessageOptions.DontRequireReceiver);
					}
					num3 = num8 + 1;
				}
				return;
			}
			nint num9 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v8 (Il2CppClass<UnityEngine.Debug>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num10 = (nint)typeof(Debug);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v14 (Il2CppClass<UnityEngine.Debug>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Debug.LogException((Exception)(object)"SendMessage is bugged when you try to pass 'null' in the parameter field. It behaves as if no parameter was specified.");
		}
	}

	public override Material material
	{
		get
		{
			//IL_00f3: Expected I, but got Obj
			//IL_0109: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0134: Expected I, but got Obj
			//IL_014a: Expected Obj, but got I
			//IL_01a3: Expected Obj, but got I4
			//IL_0082: Expected I, but got Obj
			//IL_00ca: Expected Obj, but got I4
			//IL_00d6: Expected Obj, but got I4
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
			bool flag = ((ComputeShader)(object)mAtlas).FindKernel((string)null) != 0 && mAtlas.premultipliedAlpha;
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v20 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)flag).FindKernel(null) != 0)
			{
				int renderQueue = ((Material)flag).renderQueue;
				return (Material)renderQueue;
			}
			return null;
		}
		set
		{
			base.shader = null;
		}
	}

	public UIAtlas atlas
	{
		get
		{
			//IL_0110: Expected I, but got Obj
			//IL_0126: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00a1: Expected I, but got Obj
			//IL_017d: Expected Obj, but got I4
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v25 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int num3 = ((ComputeShader)(object)mMat).FindKernel((string)null);
			bool flag = num3 == 0;
			bool flag2 = !flag;
			ComputeShader result = (ComputeShader)(object)mMat;
			if (!flag2)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num5 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag3 = ((ComputeShader)(object)mAtlas).FindKernel((string)null) != 0 && mAtlas.premultipliedAlpha;
				result = (ComputeShader)flag3;
			}
			return (UIAtlas)(object)result;
		}
		set
		{
			base.mainTexture = (Texture)(object)value;
		}
	}

	public string spriteName
	{
		get
		{
			return (string)(object)mAtlas;
		}
		set
		{
			//IL_0265: Expected I, but got Obj
			//IL_027b: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Expected Obj, but got Unknown
			//IL_007c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0081: Expected Obj, but got Unknown
			//IL_008a: Expected Obj, but got I4
			//IL_00e8: Expected I, but got Obj
			//IL_00fe: Expected Obj, but got I
			//IL_0129: Expected I, but got Obj
			//IL_022e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0233: Expected Obj, but got Unknown
			//IL_0248: Expected I4, but got Obj
			//IL_01da: Expected I4, but got Obj
			//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e5: Expected Obj, but got Unknown
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v43 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)mAtlas).FindKernel(value) == 0)
			{
				return;
			}
			base.MarkAsChanged();
			object obj2 = this + 396;
			obj2 = value;
			mSpriteSet = false;
			object obj3 = this + 408;
			obj3 = 0;
			string text = mSpriteName;
			if (mSpriteName == null || text.m_stringLength == 0)
			{
				nint num3 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S1_v22 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num4 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S1_v39 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)(object)mAtlas).FindKernel((string)null) != 0)
				{
					Texture texture = mAtlas.texture;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v38 (UnityEngine.Texture)+C]");
					if ((nint)0 >= (nint)1)
					{
						Texture texture2 = mAtlas.texture;
						UISpriteData uISpriteData = ((List<UISpriteData>)(object)texture2).get_Item(0);
						((UISpriteAnimation)(object)this).framesPerSecond = (int)uISpriteData;
						object obj5 = this + 400;
						UISpriteData uISpriteData2 = mSprite;
						obj5 = uISpriteData2.name;
					}
				}
			}
			string text2 = mSpriteName;
			if (mSpriteName != null && text2.m_stringLength != 0)
			{
				object obj6 = this + 400;
				obj6 = "";
				fillCenter = (byte)(int)mSpriteName != 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
			}
		}
	}

	public bool isValid
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)mSpriteName != 0;
		}
	}

	public bool fillCenter
	{
		get
		{
			int frames = ((UISpriteAnimation)(object)this).frames;
			return frames != 0;
		}
		set
		{
			//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f3: Expected Obj, but got Unknown
			//IL_00fb: Expected Obj, but got I4
			//IL_0101: Unknown result type (might be due to invalid IL or missing references)
			//IL_0106: Expected Obj, but got Unknown
			//IL_010f: Expected Obj, but got I4
			//IL_007b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0080: Expected Obj, but got Unknown
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Expected Obj, but got Unknown
			//IL_009d: Expected Obj, but got I4
			string text = mSpriteName;
			bool flag;
			if (value)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (System.Boolean)+8]");
				flag = (nint)0 == 0;
			}
			else
			{
				flag = true;
			}
			if (!flag)
			{
				if (mSpriteName.get_Chars(value ? 1 : 0) != '\0')
				{
					object obj = this + 400;
					obj = value;
					object obj2 = this + 408;
					obj2 = 0;
					mChanged = true;
					mSpriteSet = false;
				}
			}
			else if (mSpriteName != null && text.m_stringLength != 0)
			{
				object obj3 = this + 400;
				obj3 = "";
				object obj4 = this + 408;
				obj4 = 0;
				mChanged = true;
				mSpriteSet = false;
			}
		}
	}

	public bool applyGradient
	{
		get
		{
			return centerType != AdvancedType.Invisible;
		}
		set
		{
			//IL_0021: Expected Obj, but got I4
			bool flag = centerType != AdvancedType.Invisible;
			object obj = flag ^ value;
			if (obj != null)
			{
				centerType = (value ? AdvancedType.Sliced : AdvancedType.Invisible);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
			}
		}
	}

	public Color gradientTop
	{
		get
		{
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Expected Obj, but got Unknown
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Color)+134]");
			bool flag = (nint)0 != 0;
			object obj = flag ^ this;
			if (obj != null)
			{
				object obj2 = this & 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
			}
			Color result = default;
			return result;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			object obj = value + 312;
			UISprite uISprite = (UISprite)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v2+8]");
			((UnityEngine.Object)this).m_CachedPtr = (IntPtr)0;
		}
	}

	public unsafe Color gradientBottom
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Expected Obj, but got Unknown
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Expected I, but got Unknown
			//IL_0066: Expected I, but got Obj
			//IL_00a1: Expected I, but got Obj
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b6: Expected Obj, but got Unknown
			//IL_00c3: Expected Obj, but got I
			Color color = default;
			object obj = color + 312;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ S1_v3+8]");
			_ = 0;
			Gradient gradient = (Gradient)(obj2 + 16);
			gradient = (Gradient)obj2;
			Gradient gradient2 = gradient;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			gradient2.m_Ptr = (IntPtr)0;
			nint num = (nint)(obj2 + 32);
			((IntPtr*)num)->m_value = (void*)(nint)this;
			_ = ((UnityEngine.Object)this).m_CachedPtr;
			if (gradient.Internal_Equals((IntPtr)num))
			{
				((IntPtr*)num)->m_value = (void*)(nint)this;
				_ = ((UnityEngine.Object)this).m_CachedPtr;
				object obj3 = color + 312;
				obj3 = (object)((IntPtr*)num)->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v10 (System.IntPtr)+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Color)+134]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
				}
			}
			return color;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			object obj = value + 328;
			UISprite uISprite = (UISprite)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v2+8]");
			((UnityEngine.Object)this).m_CachedPtr = (IntPtr)0;
		}
	}

	public unsafe override Vector4 border
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Expected Obj, but got Unknown
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Expected I, but got Unknown
			//IL_0066: Expected I, but got Obj
			//IL_00a1: Expected I, but got Obj
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b6: Expected Obj, but got Unknown
			//IL_00c3: Expected Obj, but got I
			Vector4 vector = default;
			object obj = vector + 328;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ S1_v3+8]");
			_ = 0;
			Gradient gradient = (Gradient)(obj2 + 16);
			gradient = (Gradient)obj2;
			Gradient gradient2 = gradient;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			gradient2.m_Ptr = (IntPtr)0;
			nint num = (nint)(obj2 + 32);
			((IntPtr*)num)->m_value = (void*)(nint)this;
			_ = ((UnityEngine.Object)this).m_CachedPtr;
			if (gradient.Internal_Equals((IntPtr)num))
			{
				((IntPtr*)num)->m_value = (void*)(nint)this;
				_ = ((UnityEngine.Object)this).m_CachedPtr;
				object obj3 = vector + 328;
				obj3 = (object)((IntPtr*)num)->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v10 (System.IntPtr)+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector4)+134]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
				}
			}
			return vector;
		}
	}

	protected unsafe override Vector4 padding
	{
		get
		{
			//IL_00aa: Expected VT, but got I4
			//IL_00aa: Expected Obj, but got VT
			//IL_0030: Expected native int or pointer, but got VT
			//IL_003e: Expected native int or pointer, but got VT
			//IL_0058: Expected F4, but got I
			//IL_0053: Expected native int or pointer, but got VT
			//IL_006d: Expected F4, but got I
			//IL_0068: Expected native int or pointer, but got VT
			//IL_0082: Expected F4, but got I
			//IL_007d: Expected native int or pointer, but got VT
			//IL_0097: Expected F4, but got I
			//IL_0092: Expected native int or pointer, but got VT
			Vector4 vector = default;
			if (((UISpriteAnimation)(object)this).frames != 0)
			{
				((Vector4*)(nint)vector)->x = 0f;
				((Vector4*)(nint)vector)->z = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32)+1C]");
				((Vector4*)(nint)vector)->x = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32)+28]");
				((Vector4*)(nint)vector)->y = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32)+20]");
				((Vector4*)(nint)vector)->z = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32)+24]");
				((Vector4*)(nint)vector)->w = 0f;
			}
			else
			{
				((UIWidget)vector).border = (Vector4)0;
			}
			return vector;
		}
	}

	public override float pixelSize
	{
		get
		{
			//IL_00cd: Expected I, but got Obj
			//IL_00e3: Expected Obj, but got I
			//IL_0148: Expected I, but got Obj
			//IL_015e: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			nint num = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<NGUITools>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v27 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UIRoot uIRoot = NGUITools.FindInParents<UIRoot>((GameObject)(object)this);
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v13 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v23 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)uIRoot).FindKernel((string)null) != 0)
			{
				return UIRoot.GetPixelSizeAdjustment((GameObject)(object)uIRoot);
			}
			return 1f;
		}
	}

	public override int minWidth => mApplyGradient ? 1 : 0;

	public override int minHeight
	{
		get
		{
			//IL_024a: Unknown result type (might be due to invalid IL or missing references)
			//IL_024f: Expected Obj, but got Unknown
			//IL_0258: Unknown result type (might be due to invalid IL or missing references)
			//IL_025d: Expected Obj, but got Unknown
			//IL_0266: Unknown result type (might be due to invalid IL or missing references)
			//IL_026b: Expected Obj, but got Unknown
			//IL_0274: Unknown result type (might be due to invalid IL or missing references)
			//IL_0279: Expected Obj, but got Unknown
			//IL_0282: Expected Obj, but got I4
			//IL_006c: Expected I, but got Obj
			//IL_0082: Expected Obj, but got I
			//IL_0320: Expected I, but got Obj
			//IL_0336: Expected Obj, but got I
			//IL_00ad: Expected I, but got Obj
			//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_03be: Expected Obj, but got Unknown
			//IL_00fa: Expected I, but got Obj
			//IL_043c: Expected I, but got Obj
			//IL_0452: Expected Obj, but got I
			//IL_0147: Expected I, but got Obj
			//IL_015d: Expected Obj, but got I
			//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d5: Expected Obj, but got Unknown
			//IL_03f8: Expected Obj, but got I
			//IL_023c: Expected I4, but got Obj
			//IL_01f0: Expected I, but got Obj
			//IL_0188: Expected I, but got Obj
			object obj2 = default;
			object obj = obj2 - -64;
			object obj3 = obj2 + 32;
			object obj4 = obj2 + 16;
			object obj5 = obj2 + 48;
			obj5 = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			object obj6 = default;
			int num;
			if ((nint)obj6 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				object obj7 = default;
				if ((nint)obj7 != 4)
				{
					num = base.minHeight;
					goto IL_02af;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76C9");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @892A");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76C9");
			nint num2 = (nint)typeof(Vector4);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<UnityEngine.Vector4>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num3 = (nint)typeof(Vector4);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v83 (Il2CppClass<UnityEngine.Vector4>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F51F");
			obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
			_ = 0;
			obj = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
			_ = 0;
			obj2 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
			_ = 0;
			nint num4 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S2_v9 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num5 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S2_v15 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float num6 = (float)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			float num7 = num6 + 0f;
			GUILayoutOption gUILayoutOption = GUILayout.Width(num7);
			int frames = ((UISpriteAnimation)(object)this).frames;
			bool flag = frames == 0;
			GUILayoutOption gUILayoutOption2 = gUILayoutOption;
			if (!flag)
			{
				nint num8 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S0_v71 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj10 = (nint)0 & (nint)0x200;
				if (obj10 != null)
				{
					nint num9 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ S0_v79 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S0_v44 (System.Int32)+30]");
				nint num10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S0_v44 (System.Int32)+2C]");
				object obj11 = num10 + 0;
				object obj12 = default;
				float num11 = (float)obj12 * (float)obj11;
				GUILayoutOption gUILayoutOption3 = GUILayout.Width(num11);
				GUILayoutOption gUILayoutOption4 = (GUILayoutOption)(object)((object)gUILayoutOption3 + (object)gUILayoutOption);
				gUILayoutOption2 = gUILayoutOption4;
			}
			num = base.minHeight;
			object obj13 = gUILayoutOption2 & 1;
			if (obj13 != null)
			{
				GUILayoutOption gUILayoutOption5 = (GUILayoutOption)(gUILayoutOption2 + 1);
				gUILayoutOption2 = gUILayoutOption5;
			}
			nint num12 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ S0_v52 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj14 = (nint)0 & (nint)0x200;
			if (obj14 != null)
			{
				nint num13 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ S0_v60 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (num <= (nint)gUILayoutOption2)
			{
				num = (int)gUILayoutOption2;
			}
			goto IL_02af;
			IL_02af:
			return num;
		}
	}

	public unsafe override Vector4 drawingDimensions
	{
		get
		{
			//IL_0009: Expected Obj, but got I4
			//IL_0022: Expected Obj, but got F4
			//IL_009a: Expected F4, but got Obj
			//IL_0095: Expected native int or pointer, but got VT
			//IL_00af: Expected F4, but got I
			//IL_00aa: Expected native int or pointer, but got VT
			//IL_0061: Expected Obj, but got I
			object obj = 0;
			_ = 0;
			int frames = ((UISpriteAnimation)(object)this).frames;
			obj = 0f;
			_ = 0f;
			_ = 0f;
			_ = 0f;
			if (frames != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S0_v7 (System.Int32)+2C]");
				obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S0_v7 (System.Int32)+38]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S0_v7 (System.Int32)+30]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S0_v7 (System.Int32)+34]");
				_ = 0;
			}
			Vector4 vector = default;
			((Vector4*)(nint)vector)->x = (float)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((Vector4*)(nint)vector)->z = 0f;
			return vector;
		}
	}

	public override bool premultipliedAlpha
	{
		get
		{
			//IL_024a: Unknown result type (might be due to invalid IL or missing references)
			//IL_024f: Expected Obj, but got Unknown
			//IL_0258: Unknown result type (might be due to invalid IL or missing references)
			//IL_025d: Expected Obj, but got Unknown
			//IL_0266: Unknown result type (might be due to invalid IL or missing references)
			//IL_026b: Expected Obj, but got Unknown
			//IL_0274: Unknown result type (might be due to invalid IL or missing references)
			//IL_0279: Expected Obj, but got Unknown
			//IL_0282: Expected Obj, but got I4
			//IL_006c: Expected I, but got Obj
			//IL_0082: Expected Obj, but got I
			//IL_0320: Expected I, but got Obj
			//IL_0336: Expected Obj, but got I
			//IL_00ad: Expected I, but got Obj
			//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c6: Expected Obj, but got Unknown
			//IL_00fa: Expected I, but got Obj
			//IL_0444: Expected I, but got Obj
			//IL_045a: Expected Obj, but got I
			//IL_0147: Expected I, but got Obj
			//IL_015d: Expected Obj, but got I
			//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d5: Expected Obj, but got Unknown
			//IL_0400: Expected Obj, but got I
			//IL_023c: Expected I4, but got Obj
			//IL_01f0: Expected I, but got Obj
			//IL_0188: Expected I, but got Obj
			object obj2 = default;
			object obj = obj2 - -64;
			object obj3 = obj2 + 32;
			object obj4 = obj2 + 16;
			object obj5 = obj2 + 48;
			obj5 = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			object obj6 = default;
			bool flag;
			if ((nint)obj6 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				object obj7 = default;
				if ((nint)obj7 != 4)
				{
					flag = invert;
					goto IL_02af;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76C9");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @892A");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76C9");
			nint num = (nint)typeof(Vector4);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<UnityEngine.Vector4>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num2 = (nint)typeof(Vector4);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v83 (Il2CppClass<UnityEngine.Vector4>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F51F");
			obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
			_ = 0;
			obj = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
			_ = 0;
			obj2 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
			_ = 0;
			nint num3 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S2_v9 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num4 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S2_v15 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
			float num5 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+C]");
			float num6 = num5 + 0f;
			GUILayoutOption gUILayoutOption = GUILayout.Width(num6);
			int frames = ((UISpriteAnimation)(object)this).frames;
			bool flag2 = frames == 0;
			GUILayoutOption gUILayoutOption2 = gUILayoutOption;
			if (!flag2)
			{
				nint num7 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S0_v71 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj10 = (nint)0 & (nint)0x200;
				if (obj10 != null)
				{
					nint num8 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ S0_v79 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S0_v44 (System.Int32)+38]");
				nint num9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S0_v44 (System.Int32)+34]");
				object obj11 = num9 + 0;
				object obj12 = default;
				float num10 = (float)obj12 * (float)obj11;
				GUILayoutOption gUILayoutOption3 = GUILayout.Width(num10);
				GUILayoutOption gUILayoutOption4 = (GUILayoutOption)(object)((object)gUILayoutOption3 + (object)gUILayoutOption);
				gUILayoutOption2 = gUILayoutOption4;
			}
			flag = invert;
			object obj13 = gUILayoutOption2 & 1;
			if (obj13 != null)
			{
				GUILayoutOption gUILayoutOption5 = (GUILayoutOption)(gUILayoutOption2 + 1);
				gUILayoutOption2 = gUILayoutOption5;
			}
			nint num11 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ S0_v52 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj14 = (nint)0 & (nint)0x200;
			if (obj14 != null)
			{
				nint num12 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ S0_v60 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if ((flag ? 1 : 0) <= (nint)gUILayoutOption2)
			{
				flag = (byte)(int)gUILayoutOption2 != 0;
			}
			goto IL_02af;
			IL_02af:
			return flag;
		}
	}

	public UISpriteData GetAtlasSprite()
	{
		//IL_0086: Expected I, but got Obj
		//IL_009c: Expected Obj, but got I
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
		if (((ComputeShader)(object)mAtlas).FindKernel((string)null) != 0)
		{
			return (UISpriteData)(object)mAtlas.spriteList;
		}
		return null;
	}

	protected void SetAtlasSprite(UISpriteData sp)
	{
		//IL_063f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0644: Expected Obj, but got Unknown
		//IL_064d: Expected Obj, but got I4
		//IL_065c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0661: Expected Obj, but got Unknown
		//IL_066a: Expected Obj, but got I4
		//IL_0679: Unknown result type (might be due to invalid IL or missing references)
		//IL_067e: Expected Obj, but got Unknown
		//IL_068b: Expected I4, but got Obj
		//IL_0697: Unsupported input type for neg.
		//IL_0697: Unknown result type (might be due to invalid IL or missing references)
		//IL_069c: Expected Obj, but got Unknown
		//IL_06db: Expected Obj, but got I
		//IL_0915: Expected I, but got Obj
		//IL_092b: Expected Obj, but got I
		//IL_0c05: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c0a: Expected Obj, but got Unknown
		//IL_0c1c: Expected Obj, but got I
		//IL_04f9: Expected I, but got Obj
		//IL_050f: Expected Obj, but got I
		//IL_0405: Expected I, but got Obj
		//IL_0068: Expected Obj, but got I
		//IL_0078: Expected Obj, but got I
		//IL_0088: Expected Obj, but got I
		//IL_0098: Expected Obj, but got I
		//IL_09e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e5: Expected Obj, but got Unknown
		//IL_0a03: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a08: Expected Obj, but got Unknown
		//IL_0a3a: Expected Obj, but got I
		//IL_0a43: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a48: Expected Obj, but got Unknown
		//IL_0a56: Expected I, but got Obj
		//IL_0a6c: Expected Obj, but got I
		//IL_053a: Expected I, but got Obj
		//IL_046b: Expected I, but got Obj
		//IL_0481: Expected Obj, but got I
		//IL_021b: Expected Obj, but got I
		//IL_022b: Expected Obj, but got I
		//IL_023b: Expected Obj, but got I
		//IL_024b: Expected Obj, but got I
		//IL_0c5d: Expected F4, but got Obj
		//IL_0c79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7e: Expected Obj, but got Unknown
		//IL_0c97: Expected F4, but got I
		//IL_0cb3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb8: Expected Obj, but got Unknown
		//IL_0cd1: Expected F4, but got I
		//IL_0ab9: Expected Obj, but got I
		//IL_0ac9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ace: Expected Obj, but got Unknown
		//IL_0afa: Expected Obj, but got I
		//IL_0b0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0f: Expected Obj, but got Unknown
		//IL_0b38: Expected Obj, but got I4
		//IL_00d0: Invalid comparison between Obj and F4
		//IL_05de: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e3: Expected Obj, but got Unknown
		//IL_05fc: Expected F4, but got I
		//IL_0609: Expected Obj, but got I4
		//IL_061c: Expected Obj, but got F4
		//IL_062b: Expected I, but got F4
		//IL_0635: Expected Obj, but got F4
		//IL_0587: Expected I, but got Obj
		//IL_04ac: Expected I, but got Obj
		//IL_0142: Expected I, but got Obj
		//IL_0158: Expected Obj, but got I
		//IL_07d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d7: Expected Obj, but got Unknown
		//IL_00ff: Expected Obj, but got I
		//IL_010f: Expected Obj, but got I
		//IL_011f: Expected Obj, but got I
		//IL_012f: Expected Obj, but got I
		//IL_0b5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b63: Expected Obj, but got Unknown
		//IL_0183: Expected I, but got Obj
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Expected Obj, but got Unknown
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 80;
		obj = 0;
		_ = 0;
		object obj3 = obj2 - -64;
		obj3 = 0;
		_ = 0;
		UIWidget uIWidget = (UIWidget)(obj2 + 16);
		uIWidget.width = (int)sp;
		obj2 = uIWidget;
		object obj4 = 0 - obj2;
		float num = (float)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sp @ L1 (UISpriteData)+64]");
		float num2 = num * 0f;
		float num3 = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sp @ L1 (UISpriteData)+64]");
		float num4 = num3 + 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		object obj5 = -0;
		float num5 = (float)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sp @ L1 (UISpriteData)+68]");
		float num6 = num5 * 0f;
		float num7 = num6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sp @ L1 (UISpriteData)+68]");
		float num8 = num7 + 0f;
		int frames = ((UISpriteAnimation)(object)sp).frames;
		bool flag = frames == 0;
		float num9 = num8;
		float num10 = num6;
		float num11 = num4;
		float num12 = num2;
		GUILayoutOption gUILayoutOption;
		GUILayoutOption gUILayoutOption2;
		GUILayoutOption gUILayoutOption3;
		GUILayoutOption gUILayoutOption4;
		float num23;
		float num24;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sp @ L1 (UISpriteData)+120]");
			bool flag2 = (nint)0 != 2;
			bool flag3 = !flag2;
			num9 = num8;
			num10 = num6;
			num11 = num4;
			num12 = num2;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sp @ L1 (UISpriteData)+198]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sp @ L1 (UISpriteData)+198]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sp @ L1 (UISpriteData)+198]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sp @ L1 (UISpriteData)+198]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sp @ L1 (UISpriteData)+120]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76C9");
					object obj10 = default;
					if (obj10 == (object)1f)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v111+38]");
						gUILayoutOption = (GUILayoutOption)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S0_v117+34]");
						gUILayoutOption2 = (GUILayoutOption)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S0_v108+2C]");
						gUILayoutOption3 = (GUILayoutOption)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S0_v114+30]");
						gUILayoutOption4 = (GUILayoutOption)0;
					}
					else
					{
						nint num13 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ S0_v188 (Il2CppClass<UnityEngine.Mathf>)+BA]");
						object obj11 = (nint)0 & (nint)0x200;
						if (obj11 != null)
						{
							nint num14 = (nint)typeof(Mathf);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ S0_v204 (Il2CppClass<UnityEngine.Mathf>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						float num15 = (float)obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S0_v108+2C]");
						float num16 = num15 * 0f;
						GUILayoutOption gUILayoutOption5 = GUILayout.Width(num16);
						float num17 = (float)obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v111+38]");
						float num18 = num17 * 0f;
						GUILayoutOption gUILayoutOption6 = GUILayout.Width(num18);
						float num19 = (float)obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S0_v114+30]");
						float num20 = num19 * 0f;
						GUILayoutOption gUILayoutOption7 = GUILayout.Width(num20);
						float num21 = (float)obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S0_v117+34]");
						float num22 = num21 * 0f;
						GUILayoutOption gUILayoutOption8 = GUILayout.Width(num22);
						gUILayoutOption = gUILayoutOption6;
						gUILayoutOption2 = gUILayoutOption8;
						gUILayoutOption3 = gUILayoutOption5;
						gUILayoutOption4 = gUILayoutOption7;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v111+38]");
					gUILayoutOption = (GUILayoutOption)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S0_v117+34]");
					gUILayoutOption2 = (GUILayoutOption)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S0_v108+2C]");
					gUILayoutOption3 = (GUILayoutOption)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S0_v114+30]");
					gUILayoutOption4 = (GUILayoutOption)0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sp @ L1 (UISpriteData)+198]");
				object obj12 = 0;
				GUILayoutOption gUILayoutOption9 = gUILayoutOption3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ S2_v31+14]");
				object obj13 = gUILayoutOption9 + 0;
				object obj14 = (object)gUILayoutOption4 + obj13;
				bool flag4 = (nint)obj14 < 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sp @ L1 (UISpriteData)+198]");
				object obj15 = 0;
				GUILayoutOption gUILayoutOption10 = gUILayoutOption;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S3_v12+18]");
				object obj16 = gUILayoutOption10 + 0;
				object obj17 = (object)gUILayoutOption2 + obj16;
				bool flag5 = (nint)obj17 < 1;
				object obj18 = flag4 | flag5;
				if (obj18 != null)
				{
					num23 = 1f;
					num24 = 1f;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sp @ L1 (UISpriteData)+120]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sp @ L1 (UISpriteData)+120]");
						if ((nint)0 != 3)
						{
							num23 = 1f;
							num24 = 1f;
							goto IL_07f4;
						}
					}
					object obj19 = obj14 & 1;
					if (obj19 != null)
					{
						GUILayoutOption gUILayoutOption11 = (GUILayoutOption)(gUILayoutOption4 + 1);
						gUILayoutOption4 = gUILayoutOption11;
					}
					object obj20 = obj17 & 1;
					if (obj20 != null)
					{
						GUILayoutOption gUILayoutOption12 = (GUILayoutOption)(gUILayoutOption2 + 1);
						gUILayoutOption2 = gUILayoutOption12;
					}
					float num25 = 1f / (float)obj14;
					float num26 = num25;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sp @ L1 (UISpriteData)+64]");
					float num27 = num26 * 0f;
					float num28 = 1f / (float)obj17;
					float num29 = num28;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sp @ L1 (UISpriteData)+68]");
					num24 = num29 * 0f;
					num23 = num27;
				}
				goto IL_07f4;
			}
		}
		goto IL_0907;
		IL_0907:
		nint num30 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S1_v24 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj21 = (nint)0 & (nint)0x200;
		if (obj21 != null)
		{
			nint num31 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S1_v87 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj22 = obj2 + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sp @ L1 (UISpriteData)+18C]");
		if (((ComputeShader)0).FindKernel(null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @892A");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76C9");
			nint num32 = (nint)typeof(Vector4);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ S0_v91 (Il2CppClass<UnityEngine.Vector4>)+BA]");
			object obj23 = (nint)0 & (nint)0x200;
			if (obj23 != null)
			{
				nint num33 = (nint)typeof(Vector4);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ S0_v100 (Il2CppClass<UnityEngine.Vector4>)+74]");
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
			obj3 = obj22;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S1_v29+8]");
			_ = 0;
		}
		else
		{
			nint num34 = (nint)typeof(Vector4);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ S0_v76 (Il2CppClass<UnityEngine.Vector4>)+BA]");
			object obj24 = (nint)0 & (nint)0x200;
			if (obj24 != null)
			{
				nint num35 = (nint)typeof(Vector4);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ S0_v83 (Il2CppClass<UnityEngine.Vector4>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((MessageEventArgs)(object)uIWidget)._002Ector();
			obj3 = uIWidget;
			_ = ((UnityEngine.Object)uIWidget).m_CachedPtr;
		}
		obj = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		uIWidget = (UIWidget)obj3;
		UIWidget uIWidget3 = uIWidget;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		((UnityEngine.Object)uIWidget3).m_CachedPtr = (IntPtr)0;
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		UIWidget uIWidget4 = uIWidget;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		object obj25 = uIWidget4 + 0;
		obj22 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		object obj26 = obj2 + 32;
		obj26 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S1_v29+4]");
		nint num36 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ S1_v49+C]");
		object obj27 = num36 + 0;
		object obj28 = sp + 156;
		nint num37 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ S0_v50 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj29 = (nint)0 & (nint)0x200;
		if (obj29 != null)
		{
			nint num38 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ S0_v71 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float b = num11 - (float)obj25;
		float num39 = Mathf.LerpUnclamped(num12, b, (float)obj28);
		float b2 = num9 - (float)obj27;
		object obj30 = sp + 156;
		float a = num10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ S2_v20+4]");
		float num40 = Mathf.LerpUnclamped(a, b2, 0f);
		float a2 = num12 + (float)obj25;
		object obj31 = sp + 156;
		float b3 = num11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v521 @ S2_v23+8]");
		float num41 = Mathf.LerpUnclamped(a2, b3, 0f);
		float a3 = num10 + (float)obj27;
		object obj32 = sp + 156;
		float b4 = num9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ S2_v26+C]");
		float num42 = Mathf.LerpUnclamped(a3, b4, 0f);
		UISprite uISprite = (UISprite)0;
		((UnityEngine.Object)this).m_CachedPtr = (IntPtr)0;
		uISprite = (UISprite)num39;
		((UnityEngine.Object)this).m_CachedPtr = (IntPtr)num41;
		leftAnchor = (AnchorPoint)num42;
		return;
		IL_07f4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sp @ L1 (UISpriteData)+130]");
		if ((nint)0 != 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sp @ L1 (UISpriteData)+130]");
			bool flag6 = (nint)0 == 3;
			GUILayoutOption gUILayoutOption13 = ((!flag6) ? gUILayoutOption3 : gUILayoutOption4);
			if (!flag6)
			{
				gUILayoutOption3 = gUILayoutOption4;
			}
			gUILayoutOption4 = gUILayoutOption13;
		}
		float num43 = (float)gUILayoutOption4 * num23;
		float num44 = num2 + num43;
		float num45 = (float)gUILayoutOption3 * num23;
		float num46 = num4 - num45;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sp @ L1 (UISpriteData)+130]");
		if ((nint)0 != 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sp @ L1 (UISpriteData)+130]");
			if ((nint)0 != 3)
			{
				float num47 = (float)gUILayoutOption * num24;
				float num48 = num6 + num47;
				float num49 = (float)gUILayoutOption2 * num24;
				float num50 = num8 - num49;
				num9 = num50;
				num10 = num48;
				num11 = num46;
				num12 = num44;
				goto IL_0907;
			}
		}
		float num51 = (float)gUILayoutOption2 * num24;
		float num52 = num6 + num51;
		float num53 = (float)gUILayoutOption * num24;
		float num54 = num8 - num53;
		num9 = num54;
		num10 = num52;
		num11 = num46;
		num12 = num44;
		goto IL_0907;
	}

	public override void MakePixelPerfect()
	{
		//IL_000b: Expected Obj, but got I4
		//IL_0016: Expected Obj, but got I4
		//IL_0021: Expected Obj, but got I4
		rightAnchor = (AnchorPoint)1280;
		bottomAnchor = (AnchorPoint)720;
		topAnchor = (AnchorPoint)320;
		updateAnchors = (AnchorUpdate)1536;
		_ = 1;
		CancelInvoke();
	}

	protected override void OnInit()
	{
		//IL_0077: Expected I, but got Obj
		//IL_008d: Expected Obj, but got I
		//IL_00b8: Expected I, but got Obj
		//IL_02fc: Expected I, but got Obj
		//IL_0312: Expected Obj, but got I
		//IL_01a6: Expected I, but got Obj
		//IL_01fd: Expected I, but got Obj
		//IL_0213: Expected Obj, but got I
		//IL_0160: Expected Obj, but got I
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected Obj, but got Unknown
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected Obj, but got Unknown
		//IL_034d: Expected Obj, but got I
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0362: Expected Obj, but got Unknown
		//IL_03a5: Expected Obj, but got I
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ba: Expected Obj, but got Unknown
		//IL_0287: Expected I4, but got Obj
		//IL_023e: Expected I, but got Obj
		if (!fillCenter)
		{
			return;
		}
		AdaptScale();
		if (mType == Type.Tiled || ((UISpriteAnimation)(object)this).frames == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v17 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v56 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UnityEngine.Object obj2 = default;
		if (obj2 != null)
		{
			return;
		}
		if (mType != Type.Simple && mType != Type.Filled)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v13 (System.Int32)+20]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v13 (System.Int32)+1C]");
			object obj3 = num3 | 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v13 (System.Int32)+24]");
			object obj4 = obj3 | 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v13 (System.Int32)+28]");
			object obj5 = obj4 | 0;
			if (obj5 != null)
			{
				return;
			}
		}
		nint num4 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v28 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v44 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)obj2).FindKernel((string)null) == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76C9");
		nint num6 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S2_v5 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num7 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S2_v16 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v13 (System.Int32)+2C]");
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v13 (System.Int32)+14]");
		object obj8 = num8 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v13 (System.Int32)+30]");
		object obj9 = 0 + obj8;
		object obj10 = default;
		float num9 = (float)obj10 * (float)obj9;
		GUILayoutOption gUILayoutOption = GUILayout.Width(num9);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76C9");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v13 (System.Int32)+34]");
		nint num10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v13 (System.Int32)+18]");
		object obj11 = num10 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v13 (System.Int32)+38]");
		object obj12 = 0 + obj11;
		object obj13 = default;
		float num11 = (float)obj13 * (float)obj12;
		GUILayoutOption gUILayoutOption2 = GUILayout.Width(num11);
		height = (int)gUILayoutOption;
		Color color = ((UIWidget)(object)gUILayoutOption2).color;
	}

	protected override void OnUpdate()
	{
		if (~(mFillCenter ? 1u : 0u) != 0)
		{
			mFillCenter = true;
			centerType = AdvancedType.Invisible;
		}
		base.UpgradeFrom265();
	}

	public unsafe override void OnFill(List<Vector3> verts, List<Vector2> uvs, List<Color> cols)
	{
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected Obj, but got Unknown
		//IL_0156: Expected Obj, but got I4
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected Obj, but got Unknown
		//IL_0173: Expected Obj, but got I4
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected Obj, but got Unknown
		//IL_018a: Expected Obj, but got I4
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected Obj, but got Unknown
		//IL_01a1: Expected Obj, but got I4
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected I4, but got Unknown
		//IL_01c9: Expected Obj, but got I4
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected I4, but got Unknown
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Expected Obj, but got Unknown
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Expected Obj, but got Unknown
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Expected Obj, but got Unknown
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Expected Obj, but got Unknown
		//IL_02a1: Expected Obj, but got I4
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Expected Obj, but got Unknown
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02da: Expected Obj, but got Unknown
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_0305: Expected Obj, but got Unknown
		//IL_0323: Unknown result type (might be due to invalid IL or missing references)
		//IL_0328: Expected Obj, but got Unknown
		//IL_036b: Expected Obj, but got F4
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Expected Obj, but got Unknown
		//IL_039c: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Expected Obj, but got Unknown
		//IL_03e4: Expected Obj, but got F4
		//IL_0417: Unknown result type (might be due to invalid IL or missing references)
		//IL_041c: Expected Obj, but got Unknown
		//IL_042d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0432: Expected Obj, but got Unknown
		//IL_0443: Unknown result type (might be due to invalid IL or missing references)
		//IL_0448: Expected Obj, but got Unknown
		//IL_0459: Unknown result type (might be due to invalid IL or missing references)
		//IL_045e: Expected Obj, but got Unknown
		//IL_0483: Expected I4, but got Obj
		//IL_0490: Expected I4, but got Obj
		//IL_04b7: Expected I, but got Obj
		//IL_04cd: Expected Obj, but got I
		//IL_04ff: Expected I4, but got Obj
		//IL_0508: Expected VT, but got I4
		//IL_0100: Expected I, but got Obj
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected Obj, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected Obj, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected Obj, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected Obj, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected Obj, but got Unknown
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected Obj, but got Unknown
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected Obj, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 168;
		obj = 0;
		_ = 0;
		object obj3 = obj2 + 88;
		obj3 = 0;
		object obj4 = obj2 + 80;
		obj4 = 0;
		object obj5 = obj2 + 72;
		obj5 = 0;
		bool flag = (byte)(obj2 + 216) != 0;
		Vector2 clipSoftness = ((UIPanel)(object)verts).clipSoftness;
		obj = ((bool*)(flag ? 1 : 0))->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v18 (System.Boolean)+8]");
		_ = 0;
		bool flag2 = (byte)(obj2 + 200) != 0;
		((bool*)(flag2 ? 1 : 0))->m_value = ((bool*)(flag ? 1 : 0))->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v18 (System.Boolean)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v22 (System.Boolean)+8]");
		float num = 0f * 0.5f;
		Transform transform = (Transform)(obj2 + 184);
		transform = (Transform)obj;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v28 (UnityEngine.Transform)+C]");
		float num2 = 0f * 0.5f;
		Transform transform3 = (Transform)(obj2 + 96);
		transform3 = (Transform)(object)uvs;
		object obj6 = obj2 - -64;
		obj6 = uvs;
		object obj7 = obj2 + 56;
		obj7 = 0;
		obj7 = transform3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v38+4]");
		_ = 0;
		object obj8 = obj2 + 48;
		obj8 = cols;
		object obj9 = obj2 + 32;
		obj9 = cols;
		obj3 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v50+4]");
		_ = 0;
		object obj10 = obj2 + 152;
		obj10 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		object obj11 = obj2 + 136;
		obj11 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S0_v61+4]");
		float num3 = 0f - num2;
		float num4 = (float)obj10 - num;
		obj4 = num4;
		object obj12 = obj2 + 120;
		obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		object obj13 = obj2 + 104;
		obj13 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S0_v74+4]");
		float num5 = 0f + num2;
		float num6 = (float)obj12 + num;
		obj5 = num6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L1 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+60]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L1 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+D8]");
			if ((nint)0 == 3)
			{
				object obj14 = verts + 236;
				object obj15 = obj4 + obj14;
				obj4 = obj15;
				object obj16 = obj4 + 4;
				object obj17 = verts + 236;
				object obj18 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ S2_v11+4]");
				object obj19 = obj18 + 0;
				obj16 = obj19;
				object obj20 = verts + 236;
				object obj21 = obj5 - obj20;
				obj5 = obj21;
				object obj22 = obj5 + 4;
				object obj23 = verts + 236;
				object obj24 = obj22;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ S2_v17+4]");
				object obj25 = obj24 - 0;
				obj22 = obj25;
			}
		}
		object obj26 = obj2 + 40;
		obj26 = obj7;
		object obj27 = obj2 + 24;
		obj27 = obj3;
		object obj28 = obj2 + 16;
		obj28 = obj4;
		object obj29 = obj2 + 8;
		obj29 = obj5;
		transform3 = (Transform)obj26;
		transform = (Transform)obj27;
		((bool*)(flag2 ? 1 : 0))->m_value = (byte)(int)obj28 != 0;
		((bool*)(flag ? 1 : 0))->m_value = (byte)(int)obj29 != 0;
		Bounds bounds = NGUIMath.CalculateRelativeWidgetBounds(transform3, transform, flag2, flag);
		nint num7 = (nint)typeof(Vector2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ S0_v106 (Il2CppClass<UnityEngine.Vector2>)+BA]");
		object obj30 = (nint)0 & (nint)0x200;
		if (obj30 != null)
		{
			nint num8 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ S0_v114 (Il2CppClass<UnityEngine.Vector2>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj2 = obj6;
		((bool*)(flag ? 1 : 0))->m_value = (byte)(int)obj2 != 0;
		Vector3 vector = (Vector4)flag;
	}

	private void CreateUITexture()
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected Obj, but got Unknown
		//IL_0053: Expected Obj, but got I4
		base.OnDisable();
		if (mChanged || ~(mSpriteSet ? 1u : 0u) != 0)
		{
			mSpriteSet = true;
			object obj = this + 408;
			obj = 0;
			mChanged = true;
		}
	}

	public unsafe UISprite()
	{
		//IL_0159: Expected VT, but got Obj
		//IL_016e: Expected Obj, but got VT
		//IL_0010: Expected Obj, but got I4
		//IL_0023: Expected Obj, but got VT
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected I4, but got Unknown
		//IL_0071: Expected I4, but got Obj
		//IL_008b: Expected Obj, but got VT
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected Obj, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected Obj, but got Unknown
		//IL_00c6: Expected I4, but got Obj
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected Obj, but got Unknown
		//IL_010f: Expected I4, but got Obj
		//IL_0131: Expected Obj, but got I4
		string text = tag;
		_0021_00210 val = (_0021_00210)GameObjectExtensions.GetComponentInParents<T>((GameObject)(object)text);
		_ = 0.5f;
		((UIWidget)val).pivot = mPivot;
		Color color = ((UIWidget)mHeight).color;
		((UIWidget)val).height = mWidth;
		object obj2 = default;
		object obj = obj2 + 32;
		object obj3 = this + 80;
		obj = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S1_v15+8]");
		_ = 0;
		Pivot pivot = (Pivot)(obj2 + 48);
		((Pivot*)(int)pivot)->value__ = (int)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v15+8]");
		_ = 0;
		((UIWidget)val).rawPivot = pivot;
		object obj4 = obj2 + 16;
		object obj5 = this + 312;
		obj4 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S1_v27+8]");
		_ = 0;
		((Pivot*)(int)pivot)->value__ = (int)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v22+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A667");
		object obj6 = this + 328;
		obj2 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S1_v37+8]");
		_ = 0;
		((Pivot*)(int)pivot)->value__ = (int)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A668");
		Vector2 vector = ((UIWidget)mDepth).localSize;
		tag = null;
	}
}
